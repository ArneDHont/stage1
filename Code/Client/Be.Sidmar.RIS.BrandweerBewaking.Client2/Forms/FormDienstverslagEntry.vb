Option Explicit On
Option Strict On
Option Infer On

Imports System.Drawing
Imports System.Windows.Forms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers
Imports System.Text.RegularExpressions
Imports Infragistics.Win.UltraWinGrid

Namespace Forms

    Public Class FormDienstverslagEntry

        Private Const AantalVasteKolommen As Integer = 4

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        Private ReadOnly _columnToId As New Dictionary(Of String, Integer)
        Private ReadOnly _idToColumn As New Dictionary(Of Integer, String)
        Private ReadOnly _opleidingAfdelingen As New InfoStore(Of Integer)
        Private ReadOnly _opleidingPersonen As New InfoStore(Of Short)

        Private Property Dirty As Boolean

        Private Property TimeRegEx As Regex

        ''' <summary>
        ''' The date for the edit operation.
        ''' </summary>
        Public Property Datum As DateTime

        ''' <summary>
        ''' The team for the edit operation.
        ''' </summary>
        ''' <value></value>
        Public Property PloegId As Integer

        ''' <summary>
        ''' The name of the team for the edit operation.
        ''' </summary>
        ''' <value></value>
        Public Property PloegNaam As String

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormDienstverslagEntryLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            Using zandloper As New WaitCursor(Me)

                Debug.Assert(Not Datum.Equals(DateTime.MinValue))
                Debug.Assert(PloegId > 0)
                Debug.Assert(Not String.IsNullOrEmpty(PloegNaam))

                TimeRegEx = New Regex("^[0-9][0-9]:[0-5][0-9]$")

                TextBoxDatum.Text = Datum.ToShortDateString()
                TextBoxPloeg.Text = PloegNaam

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstVerslagDetailOversten = _proxy.DienstverslagGetSuperiors()
                    _dataDienstVerslagDetailOversten.Clear()
                    _dataDienstVerslagDetailOversten.Merge(dsIn)
                End Using

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstverslagAfdelingen = _proxy.DienstVerslagGetDepartments()
                    _dataDienstverslagAfdelingen.Clear()
                    _dataDienstverslagAfdelingen.Merge(dsIn)
                End Using

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstverslagDetailActies = _proxy.DienstVerslagGetActions()
                    _dataDienstverslagDetailActies.Clear()
                    For Each groep As Proxy.BBWService.Mgt.TDSDienstverslagDetailActies.ActiegroepenRow In dsIn.Actiegroepen
                        For Each detail In groep.GetActiesRows()
                            _dataDienstverslagDetailActies.Acties.AddActiesRow(groep.ActieCodeGroepId, detail.ActieCodeId, detail.ActieOmschr, groep.ActieCodeGroepOmschr)
                        Next
                    Next
                End Using

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstVerslagDetail = _proxy.DienstVerslagGetDetail(Datum, PloegId)
                    HandleHeaderInfo(dsIn.Header)
                    HandleDetailInfo(dsIn.Detail, dsIn.Werknemer)
                End Using

                UltraGrid1.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False
                UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("ActieCodeGroepOmschr", False, True)
                UltraGrid1.Rows.ExpandAll(True)
            End Using
        End Sub

        ''' <summary>
        '''  Form closing Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormDienstverslagEntryFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Dirty Then
                If MessageBox.Show(Me, "Bent u zeker dat u de wijzigingen wil annuleren?", "Annuleren", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End Sub

        ''' <summary>
        ''' Het veldje voor het aantal personen mag enkel cijfers accepteren.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TextBoxAantalPersonen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAantalPersonen.KeyPress
            If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then Return
            e.Handled = True
        End Sub

        ''' <summary>
        ''' Toevoegen van een tijdelijke medewerker
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonAddPersonClick(sender As Object, e As EventArgs) Handles ToolStripButtonAddPerson.Click
            Using f As New FormDienstverslagKiesMedewerker
                f.ExcludeIds = _idToColumn.Keys
                If f.ShowDialog(Me) = DialogResult.OK Then
                    AddPerson(f.SelectedId, f.SelectedName, f.SelectedFirstname)
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Opslaan van de wijzigingen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonSaveClick(sender As Object, e As EventArgs) Handles ToolStripButtonSave.Click

            Using zandloper As New WaitCursor(Me)

                If Not TestAchtUurOké() Then Return

                Dim result As New Proxy.BBWService.Mgt.TDSDienstVerslagDetail

                result.Header.AddHeaderRow(-1, Datum, CStr(ComboBoxOverste.SelectedValue), PloegId, TextBoxOpm.Text.Trim())

                Dim columnCount = _dataDienstverslagDetailActies.Acties.Columns.Count - 1
                Dim id = 0
                For Each row As TDSDienstverslagDetailActies.ActiesRow In _dataDienstverslagDetailActies.Acties.Rows
                    For i As Integer = AantalVasteKolommen To columnCount

                        Dim value = row(i)
                        Dim interval As TimeSpan
                        If Not IsDBNull(value) AndAlso TimeSpan.TryParse(CStr(value), interval) Then

                            Dim newRow = result.Detail.NewDetailRow
                            With newRow
                                id += 1
                                .DagVerslagActieID = id
                                .DagVerslagID = -1
                                .WerknemerID = CStr(_columnToId(_dataDienstverslagDetailActies.Acties.Columns(i).Caption))
                                .ActieCodeID = row.ActieCodeId
                                .AantalUur = interval.Hours
                                .AantalMinuten = interval.Minutes

                                Dim afdelingId = _opleidingAfdelingen.GetValue(row.ActieCodeId, i)
                                If afdelingId < 1 Then
                                    .SetOpleidingAfdelingIDNull()
                                Else
                                    .OpleidingAfdelingID = afdelingId
                                End If

                                Dim personen = _opleidingPersonen.GetValue(row.ActieCodeId, i)
                                If personen < 1 Then
                                    .SetOpleidingAantalPersonenNull()
                                Else
                                    .OpleidingAantalPersonen = personen
                                End If
                            End With
                            result.Detail.AddDetailRow(newRow)
                        End If
                    Next
                Next

                If Not _proxy.DienstVerslagSave(result) Then
                    zandloper.Revert()
                    MessageBox.Show(Me, "Fout bij het opslaan van de registraties!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Dirty = False
                DialogResult = DialogResult.OK
                Close()
            End Using
        End Sub

        ''' <summary>
        ''' Annuleren van de wijzigingen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonCancelClick(sender As Object, e As EventArgs) Handles ToolStripButtonCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Afdrukken van het scherm.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonPrintClick(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click
            UltraPrintPreviewDialog1.Document = If(TabControl1.SelectedIndex = 0, UltraGridPrintDocument1, UltraPrintDocument1)
            UltraPrintPreviewDialog1.ShowDialog(Me)
        End Sub

        ''' <summary>
        ''' Moeten we de velden voor opleiding activeren?
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1AfterCellActivate(sender As Object, e As EventArgs) Handles UltraGrid1.AfterCellActivate

            ' Is er een actieve selectie?
            ' ---------------------------
            If UltraGrid1.ActiveRow Is Nothing Then Return
            If UltraGrid1.ActiveRow.IsFilterRow Then Return

            ' Is het een relevante kolom
            ' --------------------------
            Dim column = UltraGrid1.ActiveCell.Column
            If column.Index >= AantalVasteKolommen Then

                Dim actieCodeId = CInt(UltraGrid1.ActiveRow.GetCellValue("ActieCodeId"))

                Select Case actieCodeId

                    Case 49
                        LabelOpleiding.Text = "Opleiding - Eigen"
                        ComboBoxAfdeling.Enabled = False
                        ComboBoxAfdeling.SelectedValue = 18 ' Brandweer
                        TextBoxAantalPersonen.Enabled = True
                        TextBoxAantalPersonen.Text = CStr(_opleidingPersonen.GetValue(actieCodeId, column.Index))
                        Return

                    Case 50
                        LabelOpleiding.Text = "Opleiding - Blustoestellen"
                        ComboBoxAfdeling.Enabled = True
                        ComboBoxAfdeling.SelectedValue = _opleidingAfdelingen.GetValue(actieCodeId, column.Index)
                        TextBoxAantalPersonen.Enabled = True
                        TextBoxAantalPersonen.Text = CStr(_opleidingPersonen.GetValue(actieCodeId, column.Index))
                        Return

                    Case 69
                        LabelOpleiding.Text = "Opleiding - Afdelingsbrandweer"
                        ComboBoxAfdeling.Enabled = True
                        ComboBoxAfdeling.SelectedValue = _opleidingAfdelingen.GetValue(actieCodeId, column.Index)
                        TextBoxAantalPersonen.Enabled = True
                        TextBoxAantalPersonen.Text = CStr(_opleidingPersonen.GetValue(actieCodeId, column.Index))
                        Return

                End Select
            End If

            ' Geen afdelingsinformatie mogelijk met de huidige selectie
            ' ---------------------------------------------------------
            LabelOpleiding.Text = "Opleiding"
            ComboBoxAfdeling.SelectedIndex = -1
            ComboBoxAfdeling.Enabled = False
            TextBoxAantalPersonen.Text = String.Empty
            TextBoxAantalPersonen.Enabled = False
        End Sub

        ''' <summary>
        ''' Vang de toetsaanslagen op om het gedrag van de VB6 toepassing na te bootsen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1KeyPress(sender As Object, e As KeyPressEventArgs) Handles UltraGrid1.KeyPress

            If Char.IsDigit(e.KeyChar) Then Return
            If Char.IsControl(e.KeyChar) Then Return

            If e.KeyChar = "."c OrElse e.KeyChar = ","c OrElse e.KeyChar = ":"c OrElse e.KeyChar = ";"c Then
                Dim cell = UltraGrid1.ActiveCell
                If cell IsNot Nothing AndAlso cell.Text.Contains(":") Then
                    e.Handled = True
                Else
                    e.KeyChar = ":"c
                End If
            Else
                e.Handled = True
            End If
        End Sub

        ''' <summary>
        ''' Check if a value that is being edited follows the syntax of a valid time interval.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGrid1.AfterCellUpdate
            Const tooltip As String = "Ongeldige waarde, gebruik uu:mm"

            Dim s As TimeSpan
            Dim f As Single
            Dim isOké As Boolean = False

            ' Controleer de vorm van de data
            ' ------------------------------
            If String.IsNullOrWhiteSpace(e.Cell.Text) Then
                isOké = True

            ElseIf TimeRegEx.IsMatch(e.Cell.Text) Then
                isOké = True

            ElseIf Single.TryParse(e.Cell.Text, f) Then
                s = If(f <= 8.0 + Single.Epsilon, TimeSpan.FromHours(f), TimeSpan.FromMinutes(f))
                e.Cell.SetValue(s.ToString("hh\:mm"), False)
                isOké = True

            ElseIf TimeSpan.TryParse(e.Cell.Text, s) Then
                e.Cell.SetValue(s.ToString("hh\:mm"), False)
                isOké = True
            End If

            ' Geef visuele feed-back over de correctheid
            ' ------------------------------------------
            If isOké Then
                e.Cell.Appearance.ResetBackColor()
                e.Cell.SelectedAppearance.ResetBackColor()
                e.Cell.ToolTipText = String.Empty
            Else
                e.Cell.Appearance.BackColor = Color.Red
                e.Cell.SelectedAppearance.BackColor = Color.Red
                e.Cell.ToolTipText = tooltip
            End If

            ' Dirty flag
            ' ----------
            Dirty = True
        End Sub

        ''' <summary>
        ''' A different departmetn was chosen, save the information.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ComboBoxAfdelingTextChanged(sender As Object, e As EventArgs) Handles ComboBoxAfdeling.TextChanged

            ' Is er een actieve selectie?
            ' ---------------------------
            If UltraGrid1.ActiveRow Is Nothing Then Return
            If UltraGrid1.ActiveRow.IsFilterRow Then Return

            ' Is het een relevante kolom
            ' --------------------------
            Dim column = UltraGrid1.ActiveCell.Column.Index
            If column < AantalVasteKolommen Then Return

            Dim actieCodeId = CInt(UltraGrid1.ActiveRow.GetCellValue("ActieCodeId"))
            If actieCodeId <> 49 And actieCodeId <> 50 And actieCodeId <> 69 Then Return

            ' Bewaar de informatie
            ' --------------------
            _opleidingAfdelingen.SetValue(actieCodeId, column, If(ComboBoxAfdeling.SelectedValue Is Nothing, 0, CInt(ComboBoxAfdeling.SelectedValue)))
        End Sub

        ''' <summary>
        ''' A different head count was entered, save the information.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TextBoxAantalPersonenTextChanged(sender As Object, e As EventArgs) Handles TextBoxAantalPersonen.TextChanged

            ' Is er een actieve selectie?
            ' ---------------------------
            If UltraGrid1.ActiveRow Is Nothing Then Return
            If UltraGrid1.ActiveRow.IsFilterRow Then Return

            ' Is het een relevante kolom
            ' --------------------------
            Dim column = UltraGrid1.ActiveCell.Column.Index
            If column < AantalVasteKolommen Then Return

            Dim actieCodeId = CInt(UltraGrid1.ActiveRow.GetCellValue("ActieCodeId"))
            If actieCodeId <> 49 And actieCodeId <> 50 And actieCodeId <> 69 Then Return

            ' Bewaar de informatie
            ' --------------------
            _opleidingPersonen.SetValue(actieCodeId, column, TextBoxAantalPersonen.Text.SaveToShort())
        End Sub

        ''' <summary>
        ''' Setup of the Print Document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraPrintDocument1BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles UltraPrintDocument1.BeginPrint, UltraGridPrintDocument1.BeginPrint
            With DirectCast(sender, Infragistics.Win.Printing.UltraPrintDocument)
                .DefaultPageSettings.Landscape = True
                .DefaultPageSettings.Margins.Left = 25
                .DefaultPageSettings.Margins.Right = 40
                .DefaultPageSettings.Margins.Top = 25
                .DefaultPageSettings.Margins.Bottom = 40
            End With
        End Sub

        ''' <summary>
        ''' Render the Form on the Print Document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraPrintDocument1PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles UltraPrintDocument1.PrintPage

            ' Get a Picture of the current Form
            ' ---------------------------------
            Dim s As Size = Size
            Dim b As New Bitmap(s.Width, s.Height)
            Dim r As New Rectangle(0, 0, s.Width, s.Height)
            DrawToBitmap(b, r)

            ' A little Calculation to preserve the Aspect Ratio
            ' -------------------------------------------------
            Dim ratioSource As Double = s.Width / s.Height
            Dim ratioDestination As Double = e.MarginBounds.Width / e.MarginBounds.Height

            Dim r2 As Rectangle
            If ratioSource > ratioDestination Then
                Dim factor As Double = ratioDestination / ratioSource
                Dim newY As Integer = e.MarginBounds.Y + CInt(e.MarginBounds.Height * (1 - factor) / 2)
                Dim newHeight As Integer = CInt(e.MarginBounds.Height * factor)
                r2 = New Rectangle(e.MarginBounds.X, newY, e.MarginBounds.Width, newHeight)
            Else
                Dim factor As Double = ratioSource / ratioDestination
                Dim newX As Integer = e.MarginBounds.X + CInt(e.MarginBounds.Width * (1 - factor) / 2)
                Dim newWidth As Integer = CInt(e.MarginBounds.Width * factor)
                r2 = New Rectangle(newX, e.MarginBounds.Y, newWidth, e.MarginBounds.Height)
            End If

            ' Draw the Image on the Print Document
            ' ------------------------------------
            e.Graphics.DrawImage(b, r2, r, GraphicsUnit.Pixel)
        End Sub

        ''' <summary>
        ''' Print a Footer on the Print Document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & _UltraPrintDocument1.PageNumber '& "/" & NrOfPages
        End Sub

        ''' <summary>
        ''' Handle the information in the 'dienstverslag' header.
        ''' </summary>
        ''' <param name="header"></param>
        ''' <remarks></remarks>
        Private Sub HandleHeaderInfo(ByVal header As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.HeaderDataTable)

            If header.Rows.Count = 0 Then Return

            Dim row As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.HeaderRow
            row = DirectCast(header.Rows(0), Proxy.BBWService.Mgt.TDSDienstVerslagDetail.HeaderRow)

            ComboBoxOverste.SelectedValue = row.PloegoversteID
            TextBoxOpm.Text = If(row.IsOpmerkingenNull(), "", row.Opmerkingen)
        End Sub

        ''' <summary>
        ''' Handle the information in the 'dienstverslag' detail.
        ''' </summary>
        ''' <param name="detail"></param>
        ''' <param name="werknemer"></param>
        ''' <remarks></remarks>
        Private Sub HandleDetailInfo(ByVal detail As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.DetailDataTable,
                                     ByVal werknemer As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.WerknemerDataTable)

            Dim acties As TDSDienstverslagDetailActies.ActiesDataTable = _dataDienstverslagDetailActies.Acties

            ' Remove any old Columns
            ' ----------------------
            Dim count As Integer = acties.Columns.Count
            Do While count > AantalVasteKolommen
                count -= 1
                acties.Columns.RemoveAt(count)
            Loop

            ' Create new Columns for the Members of the Team
            ' ----------------------------------------------
            If detail.Rows.Count = 0 Then

                ' Haal alle leden van het team
                Dim teamMembers = _proxy.DienstVerslagGetTeamMembers(PloegId).TeamMembers
                For Each i As Proxy.BBWService.Mgt.TDSDienstVerslagDetailTeamMembers.TeamMembersRow In teamMembers
                    AddPerson(i.ID_IND, i.NM_IND, i.VNM_IND)
                Next i

            Else

                ' Voeg alle medewerkers van de bestaande registratie toe
                For Each w As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.WerknemerRow In werknemer.Rows
                    AddPerson(w.WerknemerId, w.WerknemerNaam, String.Empty)
                Next

                ' Voeg de bestaande registraties toe.
                For Each entry As Proxy.BBWService.Mgt.TDSDienstVerslagDetail.DetailRow In detail.Rows

                    Dim rows = _dataDienstverslagDetailActies.Acties.Select("ActieCodeID=" & entry.ActieCodeID)
                    If rows.Any Then

                        Dim row = rows.First
                        Dim colName = _idToColumn(CInt(entry.WerknemerID))
                        Dim registratie = (New TimeSpan(entry.AantalUur, entry.AantalMinuten, 0)).ToString("hh\:mm")

                        row(colName) = registratie

                        If Not (entry.IsOpleidingAfdelingIDNull() Or entry.IsOpleidingAantalPersonenNull()) Then
                            Dim colId = _dataDienstverslagDetailActies.Acties.Columns(colName).Ordinal
                            _opleidingAfdelingen.SetValue(entry.ActieCodeID, colId, entry.OpleidingAfdelingID)
                            _opleidingPersonen.SetValue(entry.ActieCodeID, colId, entry.OpleidingAantalPersonen)
                        End If
                    End If
                Next
            End If
        End Sub

        ''' <summary>
        ''' Voeg een kolom toe met een medewerker.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <param name="naam"></param>
        ''' <param name="voornaam"></param>
        ''' <remarks></remarks>
        Private Sub AddPerson(ByVal id As Integer, ByVal naam As String, ByVal voornaam As String)

            Dim columnName = (voornaam.Trim.ProperCase & " " & naam.Trim.ProperCase & vbCrLf & id).Trim

            ' Hou een cross reference van de werknemers bij
            _columnToId.Add(columnName, id)
            _idToColumn.Add(id, columnName)

            ' Voeg de kolom toe aan de view
            _dataDienstverslagDetailActies.Acties.Columns.Add(columnName, GetType(String))

            ' Berekening van het totaal van de nieuwe kolom
            UltraGrid1.DisplayLayout.Bands(0).Summaries.Add(SummaryType.Custom, New TimeSpanAggregator(columnName),
                                                            UltraGrid1.DisplayLayout.Bands(0).Columns(columnName),
                                                            SummaryPosition.UseSummaryPositionColumn, Nothing).
                DisplayFormat = "{0}"
        End Sub

        ''' <summary>
        ''' Werd er voor alle personen in het overzicht wel degelijk 8 uur geregistreerd?
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function TestAchtUurOké() As Boolean

            Dim columnCount = _dataDienstverslagDetailActies.Acties.Columns.Count - 1
            Dim totalen = New Dictionary(Of Integer, TimeSpan)()
            Dim ongeldigeWaardes = False

            ' Sommeer de registraties
            ' -----------------------
            For Each row As TDSDienstverslagDetailActies.ActiesRow In _dataDienstverslagDetailActies.Acties.Rows
                For i As Integer = AantalVasteKolommen To columnCount

                    Dim value = row(i)
                    Dim interval As TimeSpan
                    If Not IsDBNull(value) Then

                        If TimeSpan.TryParse(CStr(value), interval) Then
                            If totalen.ContainsKey(i) Then
                                totalen(i) = totalen(i).Add(interval)
                            Else
                                totalen(i) = interval
                            End If
                        Else
                            ongeldigeWaardes = True
                        End If
                    End If
                Next
            Next

            ' Staan er nog ongeldige waardes in het overzicht?
            ' ------------------------------------------------
            If ongeldigeWaardes Then
                MessageBox.Show(Me, "Er staan nog ongeldige registraties in het overzicht! Gelieve deze eerst op te corrigeren.", "Bewaar - Controle", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Zijn er werknemers met te weinig geregistreerde uren?
            ' -----------------------------------------------------
            Dim teWeinigUren = totalen.Where(Function(x) x.Value.Hours < 8)
            If teWeinigUren.Any Then
                Dim message = "Voor volgende personen zijn geen 8 uren voldaan:" & vbCrLf &
                              teWeinigUren.Aggregate("", Function(s, x) s & vbCrLf & _dataDienstverslagDetailActies.Acties.Columns(x.Key).ColumnName) &
                              vbCrLf & vbCrLf &
                              "Doorgaan met sluiten?"
                If MessageBox.Show(Me, message, "Bewaar - Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                    Return False
                End If
            End If

            ' Alles is oké
            ' ------------
            Return True
        End Function

    End Class

End Namespace
