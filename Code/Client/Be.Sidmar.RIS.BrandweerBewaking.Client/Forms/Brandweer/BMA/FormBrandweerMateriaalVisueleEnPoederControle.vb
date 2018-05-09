Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports Infragistics.Win.UltraWinGrid

Namespace Forms.Brandweer

    Public Class FormBrandweerMateriaalVisueleEnPoederControle

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        Public Property IsVisueleControle As Boolean
        Public Property DatumVorigeControle As DateTime

        Protected Property Dirty As Boolean
        Protected Property strCodes As String = ""

        Private Sub FormBrandweerMateriaalVisueleEnPoederControleLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            Try

                If IsVisueleControle Then
                    Text = "Lijst Visuele Controle"
                    LabelPoederSchuim.Visible = False

                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumVisueleKeuring").Hidden = True 'mag hidden- want is zelfde kolom als Datum Controle - naco 23/12/2016
                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumPoederControle").Hidden = True
                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumVolgendePoederControle").Hidden = True
                Else
                    Text = "Lijst Poeder/Schuim Controle"
                    LabelPoederSchuim.Visible = True

                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumVisueleKeuring").Hidden = True
                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumPoederControle").Hidden = True 'mag hidden- want is zelfde kolom als Datum Controle - naco 23/12/2016
                    UltraGridControle.DisplayLayout.Bands(0).Columns("DatumVolgendePoederControle").Hidden = True
                End If

                _dataBrandweerMateriaalControleLijst.Clear()
                _dataBrandweerMateriaalControleLijst.Merge(_proxy.GetMateriaalControleLijst(IsVisueleControle, DatumVorigeControle))

                ComboBoxFontsize.Text = "11"

            Catch ex As Exception
                Dim msg As String = String.Format("Fout opgetreden in BBW:" & vbCrLf &
                                  "Form: FormBrandweerMateriaalVisueleEnPoederControle - FormBrandweerMateriaalVisueleEnPoederControleLoad" & vbCrLf &
                                  "Message: {0}" & vbCrLf &
                                  "InnerException: " & vbCrLf & ex.InnerException.ToString &
                                  "Stacktrace: {1}",
                                  ex.Message, ex.StackTrace)
                MessageBox.Show(msg, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub UltraGrid1AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridControle.AfterCellUpdate
            Dirty = True

            If e.Cell.Column.Key = "NieuwGewicht" Then
                UltraGridControle.ActiveRow.Cells("Gecontroleerd").Value = True
            End If
        End Sub

        Private Sub UltraGrid1InitializePrint(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridControle.InitializePrint
            SetupPrint(e)
        End Sub

        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = String.Format("Datum afdruk: {0:dd/MM/yyyy HH:mm}", DateTime.Now)

            e.Section.TextCenter = strCodes

            e.Section.TextRight = String.Format("Pg {0}", _UltraGridPrintDocument1.PageNumber)
        End Sub

        Private Sub ButtonPrintClick(sender As Object, e As EventArgs) Handles ButtonPrint.Click
            Me.UltraGridControle.Font = New System.Drawing.Font("Microsoft Sans Serif", CSng(ComboBoxFontsize.Text), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            UltraGridControle.DisplayLayout.Bands(0).Columns("Gecontroleerd").Hidden = True
            UltraGridControle.DisplayLayout.Bands(0).Columns("DatumControle").Hidden = True
            UltraGridControle.DisplayLayout.Bands(0).Columns("Opmerking").Hidden = False

            Application.DoEvents()

            UltraPrintPreviewDialog1.ShowDialog(Me)

            Me.UltraGridControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            UltraGridControle.DisplayLayout.Bands(0).Columns("Gecontroleerd").Hidden = False
            UltraGridControle.DisplayLayout.Bands(0).Columns("DatumControle").Hidden = False
            UltraGridControle.DisplayLayout.Bands(0).Columns("Opmerking").Hidden = True
            Application.DoEvents()

        End Sub

        Private Sub ButtonOpslaanClick(sender As Object, e As EventArgs) Handles ButtonOpslaan.Click

            Try


                Using ds As New Proxy.BBWService.Mgt.TDSBrandweerMateriaalControleLijst

                    For Each row As TDSBrandweerMateriaalControleLijst.ControleLijstRow In
                        _dataBrandweerMateriaalControleLijst.ControleLijst.Select("Gecontroleerd <> 0")
                        ds.ControleLijst.ImportRow(row)
                    Next

                    If _proxy.SaveMateriaalControleLijst(ds, IsVisueleControle, DateTime.Today) Then
                        DialogResult = DialogResult.OK
                        Close()
                        Return
                    End If
                End Using

            Catch ex As Exception
                Dim msg As String = String.Format("Fout opgetreden in BBW:" & vbCrLf &
                                  "Form: FormBrandweerMateriaalVisueleEnPoederControle - ButtonOpslaanClick" & vbCrLf &
                                  "Message: {0}" & vbCrLf & "InnerException: " & ex.InnerException.ToString &
                                  "Stacktrace: {1}",
                                  ex.Message, ex.StackTrace)
                MessageBox.Show(msg, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub ButtonVerlaatClick(sender As Object, e As EventArgs) Handles ButtonVerlaat.Click
            If Dirty Then
                If MessageBox.Show(Me, "Bent u zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                    Return
                End If
            End If

            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Doel:   rapport instellingen
        ''' Auteur: Nancy Coppens - 05/10/2006
        ''' Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        ''' </summary>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SetupPrint(ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs)

            Try
                Using zandloper As New WaitCursor(Me)
                    Dim info As String = If(IsVisueleControle, "Visuele", "Poeder")

                    e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
                    e.PrintDocument.DefaultPageSettings.Landscape = True

                    Dim strFilter As String = ""
                    If UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("TypeMateriaal").FilterConditions.Count > 0 Then
                        strFilter = UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("TypeMateriaal").FilterConditions(0).CompareValue.ToString

                        Select Case strFilter
                            Case "Brandblusapparaat"
                                strCodes = "A = niet te vinden, B = niet gelood, C = aanduiding, D = ophanging, E = nummerbord, F = slang vervangen"
                            Case "Brandweerkasten en kranen"
                                strCodes = "A = niet te vinden, B = niet gelood, C = aanduiding, D = dichtingsring, E = kast beschadigd/geroest, F = kraan defect"
                            Case "Brancard kast", "Axiale haspel", "Bovengrondse Hydrant", "Droge stijgleidingen"
                                strCodes = ""
                            Case Else
                                strCodes = ""
                        End Select

                    Else
                        MessageBox.Show("U hebt geen filter ingesteld op Type Materiaal: alle materiaaltypes zullen worden afgedrukt.", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        strFilter = "Alle materiaal"
                    End If

                    If UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Afdeling").FilterConditions.Count > 0 Then
                        If UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Afdeling").FilterConditions(0).CompareValue.ToString <> "" Then
                            strFilter = strFilter & " - Afd " & UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Afdeling").FilterConditions(0).CompareValue.ToString
                        End If
                    Else
                        strFilter = strFilter & " - Alle afd"
                    End If

                    If UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Zone").FilterConditions.Count > 0 Then
                        If UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Zone").FilterConditions(0).CompareValue.ToString <> "" Then
                            strFilter = strFilter & " - Zone " & UltraGridControle.DisplayLayout.Bands(0).ColumnFilters("Zone").FilterConditions(0).CompareValue.ToString
                        End If
                    Else
                        strFilter = strFilter & " - Alle zones"
                    End If

                    If strFilter <> "" Then
                        e.DefaultLogicalPageLayoutInfo.PageHeader = "ArcelorMittal Gent - " & String.Format("Controlelijst {0} Controle", info) & " - " & strFilter
                    Else
                        e.DefaultLogicalPageLayoutInfo.PageHeader = "ArcelorMittal Gent - " & String.Format("Controlelijst {0} Controle", info)
                    End If

                    e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                    e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                    e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

                    If RadioButtonPrintEnkelzijdig.Checked = True Then 'naco - 01/02/2017
                        e.PrintDocument.PrinterSettings.Duplex = Drawing.Printing.Duplex.Simplex
                    Else
                        e.PrintDocument.PrinterSettings.Duplex = Drawing.Printing.Duplex.Default
                    End If

                End Using

            Catch ex As Exception
                Dim msg As String = String.Format("Fout opgetreden in BBW:" & vbCrLf &
                                                  "Form: FormBrandweerMateriaalVisueleEnPoederControle - SetupPrint" & vbCrLf &
                                                  "Message: {0}" & vbCrLf &
                                                  "Stacktrace: {1}",
                                                  ex.Message, ex.StackTrace)
                MessageBox.Show(msg, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub ButtonCopyGrid_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopyGrid.Click
            Using zandloper As New WaitCursor(Me)

                For Each row As UltraGridRow In UltraGridControle.Rows
                    row.Selected = True
                Next row

                UltraGridControle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                UltraGridControle.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub UltraGridPrintDocument1_PagePrinting(sender As System.Object, e As Infragistics.Win.Printing.PagePrintingEventArgs) Handles UltraGridPrintDocument1.PagePrinting

        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
            'naco - 29/12/2016 - workaround om numeriek te sorteren op alfanumeriek veld LocatieNr

            Using zandloper As New Helpers.WaitCursor(Me)

                _dataBrandweerMateriaalControleLijst.Clear()
                _dataBrandweerMateriaalControleLijst.Merge(_proxy.GetMateriaalControleLijst(IsVisueleControle, DatumVorigeControle))

                For i As Integer = 0 To UltraGridControle.DisplayLayout.Bands(0).Columns.Count - 1 'deze knop werkt pas goed als alle sorteringen van de kolommen zijn weggehaald
                    UltraGridControle.DisplayLayout.Bands(0).Columns(i).SortIndicator = SortIndicator.None
                Next

                UltraGridControle.DisplayLayout.Bands(0).Columns("TypeMateriaal").SortIndicator = SortIndicator.Ascending 'om de sortering op LocatieNr numeriek te maken
            End Using
        End Sub

        Private Sub UltraPrintPreviewDialog1_PageSetupDialogDisplaying(sender As System.Object, e As Infragistics.Win.Printing.PageSetupDialogDisplayingEventArgs) Handles UltraPrintPreviewDialog1.PageSetupDialogDisplaying

        End Sub

        Private Sub UltraGridControle_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridControle.InitializeLayout

        End Sub

        Private Sub UltraGridControle_AfterRowActivate(sender As Object, e As System.EventArgs) Handles UltraGridControle.AfterRowActivate
            'naco - 08/02/2017

            Dim row As UltraGridRow = UltraGridControle.ActiveRow

            Select Case row.GetCellValue("TypeMateriaal").ToString

                Case "Brandblusapparaat"
                    LabelPoederSchuim.Text = "A = niet te vinden, B = niet gelood, C = aanduiding, D = ophanging, E = nummerbord, F = slang vervangen"

                Case "Brandweerkasten en kranen"
                    LabelPoederSchuim.Text = "A = niet te vinden, B = niet gelood, C = aanduiding, D = dichtingsring, E = aanduiding, F = kast beschadigd/geroest, G = kraan defect"

                Case "Brancard kast", "Axiale haspel", "Bovengrondse Hydrant", "Droge stijgleidingen"
                    LabelPoederSchuim.Text = ""
                Case Else
                    LabelPoederSchuim.Text = ""
            End Select
        End Sub
    End Class

End Namespace
