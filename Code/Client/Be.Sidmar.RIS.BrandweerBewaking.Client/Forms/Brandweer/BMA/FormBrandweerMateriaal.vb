Option Explicit On
Option Strict On

Imports System
Imports System.Windows.Forms
Imports System.Linq
Imports System.Drawing


Namespace Forms.Brandweer

    Public Class FormBrandweerMateriaal

        Private Const TypeMateriaalBlustoestel As Integer = 1
        Private Const SoortBlustoestelPoeder As Integer = 1 'poeder = om de 2 jaar controleren
        Private Const SoortBlustoestelSchuim As Integer = 5 'naco - op vraag van Hans De Vijlder - Steven De Smaele - ook schuimblustoestellen (om de 6 jaar controleren)

        ' TODO: volgende constante in de config file plaatsen
        Private Const IntervalPoederControleYears As Integer = 2 'poeder = 2 jaar
        Private Const IntervalSchuimControleYears As Integer = 6 'schuim = 6 jaar

        Private Property Dirty As Boolean

        Private Property TypeMateriaalId As Integer
        Private Property MateriaalVolgnummer As Integer

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

#Region "Form Initialisation"

        ''' <summary>
        ''' Set the primary key of the maaterial that needs editing.
        ''' </summary>
        ''' <param name="typeMateriaal">The ID of the material type.</param>
        ''' <param name="volgnummer">The sequence number within the material type.</param>
        ''' <remarks></remarks>
        Public Sub SetPrimaryKey(ByVal typeMateriaal As Integer, ByVal volgnummer As Integer)
            TypeMateriaalId = typeMateriaal
            MateriaalVolgnummer = volgnummer
        End Sub

        ''' <summary>
        ''' Set the data for the drop-down controls.
        ''' </summary>
        ''' <param name="materiaalTypes">The list of material types.</param>
        ''' <param name="blustoestellen">The list of types of fire extinguishers.</param>
        ''' <param name="leveranciers">The list of suppliers.</param>
        ''' <param name="beheerders">The list of managers.</param>
        ''' <param name="afdelingen">The list of departments.</param>
        ''' <param name="status">The list of status values.</param>
        ''' <remarks></remarks>
        Public Sub SetCodeTables(ByVal materiaalTypes As Proxy.BBWService.Mgt.TDSBrandweerMateriaalTypes,
                                 ByVal blustoestellen As Proxy.BBWService.Mgt.TDSBrandweerExtinguisherTypes,
                                 ByVal leveranciers As Proxy.BBWService.Mgt.TDSBrandweerLeveranciers,
                                 ByVal beheerders As Proxy.BBWService.Mgt.TDSBrandweerBeheerderAfdeling,
                                 ByVal afdelingen As Proxy.BBWService.Mgt.TDSBrandweerAfdelingen,
                                 ByVal status As Proxy.BBWService.Mgt.TDSBrandweerStatus)
            _dataBrandweerTypeMateriaal1.Merge(materiaalTypes)
            _dataBrandweerSoortBlustoestel1.Merge(blustoestellen)
            _dataBrandweerLeveranciers.Merge(leveranciers)
            _dataBrandweerBeheerderAfdeling.Merge(beheerders)
            _dataBrandweerAfdelingen.Merge(afdelingen)
            _dataBrandweerStatus.Merge(status)
        End Sub

#End Region

#Region "Event Handlers"

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerMateriaalLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ReadData()

            _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))
        End Sub

        ''' <summary>
        ''' Save button handler.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SaveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click

            Dim datumKeuring As DateTime
            Dim datumHervulling As DateTime

            Try

                If TypeMateriaalCombo.Text.Trim = "" Then
                    MessageBox.Show("Gelieve Type materiaal in te vullen aub.", "Type materiaal leeg", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TypeMateriaalCombo.Focus()
                    Exit Sub
                End If

                If TypeMateriaalCombo.SelectedValue.ToString = "1" Then 'Brandblusapparaat
                    If SoortBlustoestelCombo.Text.Trim = "" Then
                        If MessageBox.Show("Opgelet, Soort Blustoestel is niet aangeduid. Wenst u verder te gaan met bewaren (met lege waarde voor Soort Blustoestel)?", "Soort blustoestel leeg", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                            SoortBlustoestelCombo.Focus()
                            Exit Sub
                        End If

                    End If
                End If

                If HervullingDatumCombo.Text <> "" Then
                    If GemeldRadioButton.Checked = False And NietGemeldRadioButton.Checked = False And TelefonischGemeldRadioButton.Checked = False Then
                        MessageBox.Show("Datum Hervulling na gebruik is ingevuld." &
                                        "Gelieve aan te duiden: Gemeld - Telefonisch gemeld - Niet gemeld." & vbCrLf & vbCrLf & "Wijzigingen zijn nog niet bewaard.", "Datum hervulling", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If

                'naco - 09/05/2017 - overgenomen van VB6 (vastgesteld door Luc Haenebalcke dat dit niet automatisch gebeurde)
                ' ligt de datum van hervulling na gebruik na datum van poedercontrole
                ' poedercontrole en volgende poedercontrole aanpassen aan nieuwe datum
                If HervullingDatumCombo.Enabled = True And PoederDatumCombo.Enabled = True Then
                    If HervullingDatumCombo.Text <> "" And PoederDatumCombo.Text <> "" Then
                        If DateValue(HervullingDatumCombo.Text) > DateValue(PoederDatumCombo.Text) Then
                            Select Case MessageBox.Show("De datum van hervulling na gebruik ligt na de datum van de laatste poedercontrole." & vbCrLf & vbCrLf &
                                               "Mogen de data van laatste poedercontrole en volgende poedercontrole hieraan aangepast worden?", "Materiaal op Locatie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                Case System.Windows.Forms.DialogResult.Yes
                                    ' tel het verschil tussen volgende poedercontrole en laatste poedercontrole bij hervulling
                                    PoederVolgendeCombo.Text = Format$(DateAdd("d", DateDiff("d", PoederDatumCombo.Text, PoederVolgendeCombo.Text), HervullingDatumCombo.Text), "dd/mm/yyyy")
                                    PoederDatumCombo.Text = HervullingDatumCombo.Text
                            End Select
                        End If
                    End If
                End If

                If AfdelingCombo.Text.Trim = "" Or ZoneCombo.Text.Trim = "" Or LocatienummerText.Text.Trim = "" Or PlaatsOmschrijvingText.Text.Trim = "" Then
                    MessageBox.Show("Gelieve Afdeling, Zone, LocatieNr én Plaats Omschrijving in te vullen aub.", "Lege velden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If LocatienummerText.Text.Trim = "" Then
                        LocatienummerText.Focus()
                    ElseIf PlaatsOmschrijvingText.Text.Trim = "" Then
                        PlaatsOmschrijvingText.Focus()
                    End If
                    Exit Sub
                End If

                If LeverancierDatumCombo.Text = "" And CheckBoxLijnToevoegen.Checked = True Then 'naco - 02/05/2017 (datum terug leegmaken bij terugbrengen toestel)
                    CheckBoxLijnToevoegen.Checked = False
                End If

                ' Overgenomen van oude VB6-toepassing Brandweer
                ' Nancy Coppens - 12/3/1999
                ' Op vraag van Guido Matthys een msgbox geven als Datum hervulling na gebruik > Datum laatste keuring + 5 jaar
                ' Het is nl. zo: als een toestel hervuld wordt en het is meer dan 5 jaar geleden dat het gekeurd werd,
                ' dan moet het naar de leverancier voor keuring.
                If Not IsDBNull(LaatsteKeuringsdatumCombo.Value) AndAlso
                   Not IsDBNull(HervullingDatumCombo.Value) AndAlso
                   Date.TryParse(CStr(LaatsteKeuringsdatumCombo.Value), datumKeuring) AndAlso
                   Date.TryParse(CStr(HervullingDatumCombo.Value), datumHervulling) AndAlso
                   datumHervulling >= datumKeuring.AddYears(5) Then
                    MessageBox.Show(Me, "Opgelet: dit toestel moet naar de leverancier voor herkeuring.", "Toestel naar leverancier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Controle op dubbele combinaties van TypeMatId / LocatieID / LocatieNr voor nieuwe records
                If String.IsNullOrWhiteSpace(VolgnummerText.Text) AndAlso
                   _proxy.BrandweerMateriaalBestaat(CInt(TypeMateriaalCombo.SelectedValue), CInt(ZoneCombo.SelectedValue), LocatienummerText.Text) Then
                    Dim msg As String
                    msg = String.Format("Het nummer {0} wordt reeds gebruikt voor een {1} in de afdeling {2}, zone {3}.",
                                        LocatienummerText.Text, TypeMateriaalCombo.Text, AfdelingCombo.Text, ZoneCombo.Text)
                    MessageBox.Show(Me, msg, "Materiaal op locatie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf WriteData() Then
                    WriteVerzendData()
                    DialogResult = DialogResult.OK
                    Close()
                Else
                    MessageBox.Show(Me, "Fout bij het wegschrijven van de wijzigingen!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerMateriaal - SaveButton_Click" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "InnerException: " & ex.InnerException.ToString & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Cancel all pending changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub AnnulerenButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles AnnulerenButton.Click
            If Dirty Then
                If MessageBox.Show(Me, "Wijzigingen annuleren?", "Annuleren", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return
                End If
            End If

            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Choose a temporary replacement of this piece of material.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub VervangenDoorButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles VervangenDoorButton.Click
            Dim type As Integer
            Dim volgnr As Integer
            Dim vervanger As Integer

            If Not Integer.TryParse(CStr(TypeMateriaalCombo.SelectedValue), type) Then type = 0
            If Not Integer.TryParse(VolgnummerText.Text, volgnr) Then volgnr = 0

            If Integer.TryParse(VervangenDoorText.Text, vervanger) Then

                If MessageBox.Show(Me, "De vervanging van het toestel wordt beëindigd.", "Einde Vervanging", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    Dirty = True
                    VervangenDoorText.Text = ""
                    LabelVervangenDoorOmschr.Text = ""
                    '_proxy.BrandweerVrijgaveVervangMateriaal(type, vervanger)
                    'naco - 13/04/2017 - ik weet niet waarom Geert Maertens deze update heeft opgenomen (was niet aanwezig in VB6)
                    'de afdeling en locatie en volgnr van het materiaal, dat tijdelijk ter vervanging wordt geplaatst, mag niet overschreven worden
                End If

            ElseIf type > 0 AndAlso volgnr > 0 Then

                Using frm As New FormBrandweerZoekVervangmateriaal With {.MateriaalType = type}
                    If frm.ShowDialog() = DialogResult.OK Then
                        Dirty = True
                        VervangenDoorText.Text = frm.MateriaalVolgNr.ToString()
                        '_proxy.BrandweerMarkeerVervangMateriaal(type, frm.MateriaalVolgNr, volgnr)
                        'naco - 13/04/2017 - ik weet niet waarom Geert Maertens deze update heeft opgenomen (was niet aanwezig in VB6)
                        'de afdeling en locatie en volgnr van het materiaal, dat tijdelijk ter vervanging wordt geplaatst, mag niet overschreven worden
                        LabelVervangenDoorOmschr.Text = "Vervangen door: " & _proxy.BrandweerGetMateriaalOmschr(CInt(VervangenDoorText.Text))


                    End If
                End Using

            Else
                MessageBox.Show(Me, "Gelieve eerst het apparaat te creëren vooraleer het te vervangen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        ''' <summary>
        ''' Changed the material type, enable the appropriate controls.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TypeMateriaalComboSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TypeMateriaalCombo.SelectedIndexChanged
            Dirty = True
            BehandelSoortBlustoestel()
        End Sub

        ''' <summary>
        ''' Changed the material soort/type, enable the appropriate controls.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SoortBlustoestelComboSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SoortBlustoestelCombo.SelectedIndexChanged
            Dirty = True
            BehandelSoortBlustoestel()
        End Sub

        ''' <summary>
        ''' Changed the location, refill the combo with the matching departments.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub AfdelingComboSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AfdelingCombo.SelectedIndexChanged
            Dirty = True

            Dim value As Integer = CInt(AfdelingCombo.SelectedValue)

            ZoneCombo.DataSource = _dataBrandweerAfdelingen.Zone.Select("AfdelingId=" & value)
            ZoneCombo.DisplayMember = "LocatieZone"
            ZoneCombo.ValueMember = "LocatieId"
            ZoneCombo.SelectedIndex = -1
        End Sub

        ''' <summary>
        ''' Need to recalculate the date for the next control by the supplier.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LaatsteKeuringsdatumComboValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LaatsteKeuringsdatumCombo.ValueChanged
            Dirty = True
            BepaalVolgendeKeuring()
        End Sub

        ''' <summary>
        ''' Need to recalculate the date for the next visual inspection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LaatsteNazichtComboValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LaatsteNazichtCombo.ValueChanged
            Dirty = True
            BepaalVolgendeNazicht()
        End Sub

        Private Sub ControleFrequentieText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ControleFrequentieText.KeyPress
            If Char.IsNumber(e.KeyChar) Or _
            e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or _
            e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Delete) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(3) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(22) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(24) Then '3 = Ctrl C, 22 = Ctrl V, 24 = Ctrl X
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        ''' <summary>
        ''' Need to recalculate the date for the next visual inspection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ControleFrequentieTextTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ControleFrequentieText.TextChanged
            Dirty = True
            BepaalVolgendeNazicht()
        End Sub

        ''' <summary>
        ''' Need to recalculate the date for the next inspection of the powder contents.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PoederDatumComboValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PoederDatumCombo.ValueChanged
            Dirty = True
            BepaalVolgendePoederControle()
        End Sub

        ''' <summary>
        ''' Make sure we remember to add a record to the 'send' list.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub LeverancierDatumComboValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LeverancierDatumCombo.ValueChanged
            Dim d As DateTime
            Dirty = True
            If LeverancierDatumCombo.Enabled AndAlso Not IsDBNull(LeverancierDatumCombo.Value) AndAlso DateTime.TryParse(CStr(LeverancierDatumCombo.Value), d) Then
                CheckBoxLijnToevoegen.Visible = True
                CheckBoxLijnToevoegen.Checked = True
            End If
        End Sub

        ''' <summary>
        ''' Changed any of the passive controls, set the dirty flag.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LeveranciersCombo.SelectedIndexChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged2(ByVal sender As Object, ByVal e As EventArgs) Handles StatusCombo.SelectedIndexChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged3(ByVal sender As Object, ByVal e As EventArgs) Handles LeveringsdatumCombo.ValueChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged4(ByVal sender As Object, ByVal e As EventArgs) Handles ZoneCombo.SelectedIndexChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged5(ByVal sender As Object, ByVal e As EventArgs) Handles LocatienummerText.TextChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged6(ByVal sender As Object, ByVal e As EventArgs) Handles FabricatienummerText.TextChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged7(ByVal sender As Object, ByVal e As EventArgs) Handles PlaatsOmschrijvingText.TextChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged8(ByVal sender As Object, ByVal e As EventArgs) Handles PoederVolgendeCombo.ValueChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged9(ByVal sender As Object, ByVal e As EventArgs) Handles HervullingDatumCombo.ValueChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged10(ByVal sender As Object, ByVal e As EventArgs) Handles VervangenDoorText.TextChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged11(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxLijnToevoegen.CheckedChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged12(ByVal sender As Object, ByVal e As EventArgs) Handles TelefonischGemeldRadioButton.CheckedChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged13(ByVal sender As Object, ByVal e As EventArgs) Handles GemeldRadioButton.CheckedChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged14(ByVal sender As Object, ByVal e As EventArgs) Handles NietGemeldRadioButton.CheckedChanged
            Dirty = True
        End Sub
        Private Sub ValueChanged15(ByVal sender As Object, ByVal e As EventArgs) Handles OpmerkingText.TextChanged
            Dirty = True
        End Sub

        ''' <summary>
        ''' Toon de materiaalfiche voor het materiaal.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MateriaalFicheButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles MateriaalFicheButton.Click
            Using frm As New FormBrandweerMateriaalFiche
                frm.SetPrimaryKey(TypeMateriaalId, MateriaalVolgnummer)
                frm.ShowDialog()

                _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))

            End Using
        End Sub

        Public Sub PrintFiche()
            'naco - 06/01/2017 - printen vanuit overzicht materiaal - op vraag van Steven De Smaele (na demo)
            Me.Show()
            UltraPrintPreviewDialog1.Document.Print()
        End Sub

        ''' <summary>
        ''' Make a print-out of the current form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PrintButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles PrintButton.Click
            UltraPrintPreviewDialog1.ShowDialog(Me)
        End Sub

        ''' <summary>
        ''' Setup of the Print Document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraPrintDocument1BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles UltraPrintDocument1.BeginPrint
            With UltraPrintDocument1
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
        Private Sub UltraGridPrintDocPageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & _UltraPrintDocument1.PageNumber '& "/" & NrOfPages
        End Sub

#End Region

#Region "Berekende Velden"

        ''' <summary>
        ''' Activate/deactivate fields depending on the type of fire extinguisher.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub BehandelSoortBlustoestel()

            Dim typeMateriaal As Integer = CInt(TypeMateriaalCombo.SelectedValue)

            If typeMateriaal <> TypeMateriaalBlustoestel Then
                SoortBlustoestelCombo.Enabled = False
                SoortBlustoestelCombo.SelectedIndex = -1

                LaatsteKeuringsdatumCombo.Enabled = False
                PoederDatumCombo.Enabled = False
                PoederVolgendeCombo.Enabled = False
                LeverancierDatumCombo.Enabled = False
                Return

            End If

            SoortBlustoestelCombo.Enabled = True

            Dim soortToestelInfo As DataRowView = TryCast(SoortBlustoestelCombo.SelectedItem, DataRowView)
            If soortToestelInfo IsNot Nothing Then

                Dim soortToestel As TDSBrandweerSoortBlustoestel.TypeBlustoestelRow = TryCast(soortToestelInfo.Row, TDSBrandweerSoortBlustoestel.TypeBlustoestelRow)
                If soortToestel IsNot Nothing Then

                    If soortToestel.BrandblusCodeID = SoortBlustoestelPoeder Or soortToestel.BrandblusCodeID = SoortBlustoestelSchuim Then
                        LaatsteKeuringsdatumCombo.Enabled = False
                        PoederDatumCombo.Enabled = True
                        PoederVolgendeCombo.Enabled = True
                        LeverancierDatumCombo.Enabled = False

                    Else
                        LaatsteKeuringsdatumCombo.Enabled = True
                        PoederDatumCombo.Enabled = False
                        PoederVolgendeCombo.Enabled = False
                        LeverancierDatumCombo.Enabled = True
                    End If
                    Return
                End If
            End If

            LaatsteKeuringsdatumCombo.Enabled = True
            PoederDatumCombo.Enabled = True
            PoederVolgendeCombo.Enabled = True
            LeverancierDatumCombo.Enabled = True
        End Sub

        ''' <summary>
        ''' Calculate the date for the next visual control.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub BepaalVolgendeNazicht()
            Dim frequency As Integer
            If Not Convert.IsDBNull(LaatsteNazichtCombo.Value) AndAlso
               Not String.IsNullOrEmpty(CStr(LaatsteNazichtCombo.Value)) AndAlso
               Integer.TryParse(ControleFrequentieText.Text, frequency) Then
                VolgendeNazichtText.Text = CDate(LaatsteNazichtCombo.Value).AddMonths(frequency).ToShortDateString()
                Return
            End If
            VolgendeNazichtText.Text = ""
        End Sub

        ''' <summary>
        ''' Calculate the date for the next inspection by the supplier.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub BepaalVolgendeKeuring()
            Dim datum As DateTime
            If Not Convert.IsDBNull(_LaatsteKeuringsdatumCombo.Value) AndAlso
               DateTime.TryParse(CStr(_LaatsteKeuringsdatumCombo.Value), datum) Then
                Dim soortId As Integer = CInt(SoortBlustoestelCombo.SelectedValue)
                If soortId <> -1 Then
                    Try
                        Dim blusCodeId As Integer = _dataBrandweerSoortBlustoestel1.TypeBlustoestel.Single(Function(r) r.SoortTypeMatID = soortId).BrandblusCodeID
                        Dim frequency As Integer = _dataBrandweerSoortBlustoestel1.BrandblusCode.Single(Function(r) r.BrandblusCodeID = blusCodeId).GroteControleFreq
                        VolgendeKeuringText.Text = datum.AddMonths(frequency).ToShortDateString()
                        Return
                    Catch ex As InvalidOperationException
                        ' No element satisfies the condition in 'Single' predicate. Too bad.
                    End Try
                End If
            End If
            VolgendeKeuringText.Text = ""
        End Sub

        ''' <summary>
        ''' Calculate the date for the next powder inspection.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub BepaalVolgendePoederControle()

            Dim datum As DateTime

            If Not Convert.IsDBNull(PoederDatumCombo.Value) AndAlso
               DateTime.TryParse(CStr(PoederDatumCombo.Value), datum) Then

                Dim soortToestelInfo As DataRowView = TryCast(SoortBlustoestelCombo.SelectedItem, DataRowView)
                Dim soortToestel As TDSBrandweerSoortBlustoestel.TypeBlustoestelRow = TryCast(soortToestelInfo.Row, TDSBrandweerSoortBlustoestel.TypeBlustoestelRow)
                If soortToestel IsNot Nothing Then

                    If soortToestel.BrandblusCodeID = SoortBlustoestelPoeder Then
                        PoederVolgendeCombo.Value = datum.AddYears(IntervalPoederControleYears)
                    ElseIf soortToestel.BrandblusCodeID = SoortBlustoestelSchuim Then
                        PoederVolgendeCombo.Value = datum.AddYears(IntervalSchuimControleYears) 'schuim - 6 jaar (nieuw naco - jan 2017)
                    End If


                End If
            End If

        End Sub

#End Region

#Region "Read/Write Data"

        ''' <summary>
        ''' Read the data for an existing entry.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ReadData()
            _dataBrandweerMateriaalItem.Clear()

            If TypeMateriaalId < 1 Or MateriaalVolgnummer < 1 Then
                TypeMateriaalCombo.SelectedIndex = -1
                SoortBlustoestelCombo.SelectedIndex = -1
                LeveranciersCombo.SelectedIndex = -1
                StatusCombo.SelectedIndex = -1
                AfdelingCombo.SelectedIndex = -1
                ZoneCombo.SelectedIndex = -1
                '
                Text &= " - Nieuw"

            Else
                _dataBrandweerMateriaalItem.Merge(_proxy.GetBrandweerMateriaalByTypeVolgnr(TypeMateriaalId, MateriaalVolgnummer))

                Dim info As TDSBrandweerMateriaalItem.MateriaalRow = _dataBrandweerMateriaalItem.Materiaal.First()
                TypeMateriaalCombo.SelectedValue = info.TypeMatID
                SoortBlustoestelCombo.SelectedValue = If(info.IsSoortTypeMatIDNull(), DBNull.Value, CObj(info.SoortTypeMatID))
                FabricatienummerText.Text = If(info.IsFabricatieNrNull(), String.Empty, info.FabricatieNr)
                LeveranciersCombo.SelectedValue = If(info.IsLeverancierIDNull(), DBNull.Value, CObj(info.LeverancierID))
                VolgnummerText.Text = CStr(info.MateriaalVolgNr)
                StatusCombo.SelectedValue = If(info.IsStatusIdNull(), DBNull.Value, CObj(info.StatusId))
                LeveringsdatumCombo.Value = If(info.IsLeveringsDatumNull(), DBNull.Value, CObj(info.LeveringsDatum))
                LaatsteKeuringsdatumCombo.Value = If(info.IsDatumLaatsteKeuringNull(), DBNull.Value, CObj(info.DatumLaatsteKeuring))
                LaatsteNazichtCombo.Value = If(info.IsDatumVisueleKeuringNull(), DBNull.Value, CObj(info.DatumVisueleKeuring))
                ControleFrequentieText.Text = If(info.IsVisueleControleFreqNull(), String.Empty, CStr(info.VisueleControleFreq))

                'BeheerderAfdelingText.Text = If(info.IsBeheerderAfdelingIDNull(), String.Empty, CStr(info.BeheerderAfdelingID))
                If info.IsBeheerderAfdelingIDNull Then
                    BeheerderAfdelingText.Text = String.Empty
                Else
                    Dim drBeheerderAfd() As DataRow
                    drBeheerderAfd = _dataBrandweerBeheerderAfdeling.Tables(0).Select("BeheerderAfdelingID = " & info.BeheerderAfdelingID)

                    If drBeheerderAfd.Count > 0 Then
                        BeheerderAfdelingText.Text = drBeheerderAfd(0).Item("BeheerderAfdelingNaam").ToString
                    End If
                End If


                'BeheerderAfdelingText.Text = info.beheerderafdelingnaa
                AfdelingCombo.SelectedValue = If(info.IsLocatieIDNull(), DBNull.Value, CObj(GetAfdelingId(info.LocatieID)))
                ZoneCombo.SelectedValue = If(info.IsLocatieIDNull(), DBNull.Value, CObj(info.LocatieID))
                LocatienummerText.Text = If(info.IsLocatieNrNull(), String.Empty, info.LocatieNr)
                PlaatsOmschrijvingText.Text = If(info.IsLocatieOmschrNull(), String.Empty, info.LocatieOmschr)
                PoederDatumCombo.Value = If(info.IsDatumPoederControleNull(), DBNull.Value, CObj(info.DatumPoederControle))
                PoederVolgendeCombo.Value = If(info.IsDatumVolgendePoederControleNull(), DBNull.Value, CObj(info.DatumVolgendePoederControle))
                HervullingDatumCombo.Value = If(info.IsDatumHervullingNaGebruikNull(), DBNull.Value, CObj(info.DatumHervullingNaGebruik))
                LeverancierDatumCombo.Value = If(info.IsDatumHerkeuringLeverancierNull(), DBNull.Value, CObj(info.DatumHerkeuringLeverancier))
                VervangenDoorText.Text = If(info.IsVervangenDoorNull() OrElse info.VervangenDoor < 1, String.Empty, CStr(info.VervangenDoor)) ' TODO: convert into description
                If VervangenDoorText.Text <> "" Then
                    LabelVervangenDoorOmschr.Text = "Vervangen door: " & _proxy.BrandweerGetMateriaalOmschr(CInt(VervangenDoorText.Text)) 'naco - 13/04/2017
                End If

                OpmerkingText.Text = If(info.IsOpmerkingNull(), String.Empty, info.Opmerking)

                ' Control Enablements
                TypeMateriaalComboSelectedIndexChanged(Nothing, EventArgs.Empty)

                If Not info.IsHervullingGemeldNull() Then
                    Select Case info.HervullingGemeld
                        Case 0
                            GemeldRadioButton.Checked = True
                        Case 1
                            TelefonischGemeldRadioButton.Checked = True
                        Case 2
                            NietGemeldRadioButton.Checked = True
                    End Select
                End If
            End If

            ' Berekende Velden
            BehandelSoortBlustoestel()
            BepaalVolgendeKeuring()
            BepaalVolgendeNazicht()

            ' Initialise the dirty flag
            Dirty = False
        End Sub

        ''' <summary>
        ''' Get the ID of the department that corresponds to a given location.
        ''' </summary>
        ''' <param name="locatie">A given location.</param>
        ''' <returns>The ID of the corresponding department.</returns>
        ''' <remarks></remarks>
        Private Function GetAfdelingId(ByVal locatie As Integer) As Integer
            Return _dataBrandweerAfdelingen.Zone.Single(Function(r) r.LocatieID = locatie).AfdelingID
        End Function

        ''' <summary>
        ''' Write the data to the database.
        ''' </summary>
        ''' <returns>True on success.</returns>
        ''' <remarks></remarks>
        Private Function WriteData() As Boolean
            Dim i As Integer
            Dim s As Short
            Dim d As DateTime

            ' Maak een nieuwe data set
            ' ------------------------
            Dim info As New Proxy.BBWService.Mgt.TDSBrandweerMateriaalItem
            Dim row As Proxy.BBWService.Mgt.TDSBrandweerMateriaalItem.MateriaalRow = info.Materiaal.NewMateriaalRow()

            With row
                .TypeMatID = If(Integer.TryParse(CStr(TypeMateriaalCombo.SelectedValue), i), i, 0)
                .MateriaalVolgNr = If(Integer.TryParse(VolgnummerText.Text, i), i, 0)

                If ZoneCombo.SelectedValue Is Nothing Then
                    .SetLocatieIDNull()
                Else
                    .LocatieID = CInt(ZoneCombo.SelectedValue)
                End If

                .LocatieNr = LocatienummerText.Text
                .LocatieOmschr = PlaatsOmschrijvingText.Text

                If IsDBNull(ControleFrequentieText.Text) OrElse Not Short.TryParse(ControleFrequentieText.Text, s) Then
                    .SetVisueleControleFreqNull()
                Else
                    .VisueleControleFreq = s
                End If

                .BeheerderID = ""

                If StatusCombo.SelectedValue Is Nothing Then
                    .SetStatusIdNull()
                Else
                    .StatusId = CInt(StatusCombo.SelectedValue)
                End If

                If SoortBlustoestelCombo.SelectedValue Is Nothing Then
                    .SetSoortTypeMatIDNull()
                Else
                    .SoortTypeMatID = CInt(SoortBlustoestelCombo.SelectedValue)
                End If

                If LeveranciersCombo.SelectedValue Is Nothing Then
                    .SetLeverancierIDNull()
                Else
                    .LeverancierID = CInt(LeveranciersCombo.SelectedValue)
                End If

                .FabricatieNr = FabricatienummerText.Text

                If IsDBNull(LeveringsdatumCombo.Value) OrElse Not DateTime.TryParse(CStr(LeveringsdatumCombo.Value), d) Then
                    .SetLeveringsDatumNull()
                Else
                    .LeveringsDatum = d
                End If

                If IsDBNull(LaatsteKeuringsdatumCombo.Value) OrElse Not DateTime.TryParse(CStr(LaatsteKeuringsdatumCombo.Value), d) Then
                    .SetDatumLaatsteKeuringNull()
                Else
                    .DatumLaatsteKeuring = d
                End If

                If IsDBNull(LaatsteNazichtCombo.Value) OrElse Not DateTime.TryParse(CStr(LaatsteNazichtCombo.Value), d) Then
                    .SetDatumVisueleKeuringNull()
                Else
                    .DatumVisueleKeuring = d
                End If

                If IsDBNull(PoederDatumCombo.Value) OrElse Not DateTime.TryParse(CStr(PoederDatumCombo.Value), d) Then
                    .SetDatumPoederControleNull()
                Else
                    .DatumPoederControle = d
                End If

                If IsDBNull(PoederVolgendeCombo.Value) OrElse Not DateTime.TryParse(CStr(PoederVolgendeCombo.Value), d) Then
                    .SetDatumVolgendePoederControleNull()
                Else
                    .DatumVolgendePoederControle = d
                End If

                If IsDBNull(HervullingDatumCombo.Value) OrElse Not DateTime.TryParse(CStr(HervullingDatumCombo.Value), d) Then
                    .SetDatumHervullingNaGebruikNull()
                Else
                    .DatumHervullingNaGebruik = d
                End If

                If GemeldRadioButton.Checked Then
                    .HervullingGemeld = 0
                ElseIf TelefonischGemeldRadioButton.Checked Then
                    .HervullingGemeld = 1
                ElseIf NietGemeldRadioButton.Checked Then
                    .HervullingGemeld = 2
                Else
                    .SetHervullingGemeldNull()
                End If

                If IsDBNull(LeverancierDatumCombo.Value) OrElse Not DateTime.TryParse(CStr(LeverancierDatumCombo.Value), d) Then
                    .SetDatumHerkeuringLeverancierNull()
                Else
                    .DatumHerkeuringLeverancier = d
                End If

                If IsDBNull(VervangenDoorText.Text) OrElse Not Integer.TryParse(VervangenDoorText.Text, i) OrElse i < 1 Then
                    .SetVervangenDoorNull()
                Else
                    .VervangenDoor = i
                End If

                If IsDBNull(BeheerderAfdelingText.Text) OrElse Not Integer.TryParse(BeheerderAfdelingText.Text, i) Then
                    .SetBeheerderAfdelingIDNull()
                Else
                    .BeheerderAfdelingID = i
                End If

                .Opmerking = OpmerkingText.Text
                .GecontroleerdYN = False
                .GecontroleerdPoederYN = False
                .VolgnummerAfdeling = 0
            End With

            info.Materiaal.AddMateriaalRow(row)

            ' Op naar de server
            ' -----------------
            Return _proxy.SaveBrandweerMateriaal(info)
        End Function

        ''' <summary>
        ''' Write a record to the 'bmVerzending' table.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub WriteVerzendData()
            Dim i As Integer
            Dim d As DateTime

            ' Misschien hoeft dit helemaal niet...
            ' ------------------------------------
            If Not CheckBoxLijnToevoegen.Checked Then Return

            ' Maak een nieuwe data set
            ' ------------------------
            Dim info As New Proxy.BBWService.Mgt.TDSBrandweerVerzending
            Dim row As Proxy.BBWService.Mgt.TDSBrandweerVerzending.VerzendingRow = info.Verzending.NewVerzendingRow()


            With row
                .VerzendingID = 0
                .TypeMatID = If(Integer.TryParse(CStr(TypeMateriaalCombo.SelectedValue), i), i, 0)
                .MateriaalVolgNr = If(Integer.TryParse(VolgnummerText.Text, i), i, 0)
                .SetDatumTerugNull()
                .HerkeurdYN = False
                .SetOpmerkingNull()

                If LeveranciersCombo.SelectedValue Is Nothing Then
                    .SetLeverancierIDNull()
                Else
                    .LeverancierID = CInt(LeveranciersCombo.SelectedValue)
                End If

                If IsDBNull(LeverancierDatumCombo.Value) OrElse Not DateTime.TryParse(CStr(LeverancierDatumCombo.Value), d) Then
                    .SetDatumVerstuurdNull()
                Else
                    .DatumVerstuurd = d
                End If

            End With

            info.Verzending.AddVerzendingRow(row)

            ' Op naar de server
            ' -----------------
            _proxy.StoreVerzending(info)
        End Sub

#End Region

        Private Sub LaatsteNazichtCombo_BeforeDropDown(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LaatsteNazichtCombo.BeforeDropDown

        End Sub

        Private Sub UltraPrintPreviewDialog1_PageSetupDialogDisplaying(ByVal sender As System.Object, ByVal e As Infragistics.Win.Printing.PageSetupDialogDisplayingEventArgs) Handles UltraPrintPreviewDialog1.PageSetupDialogDisplaying

        End Sub

        Private Sub UltraPrintDocument1_PageHeaderPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraPrintDocument1.PageHeaderPrinting
            e.Section.TextLeft = "ArcelorMittal Gent - BBW Brandweer Bewaking"
        End Sub
    End Class

End Namespace