Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection.MethodBase
Imports Infragistics.Win.UltraWinGrid

Public Class FormPrintTrafficInfractionsExtern
    Private _myProxy As BBWServiceManagementServicesProxy
    Private _myDataSetRow As TDSOvertreding.Lijst_OvertredingenRow
    Private _searchCompanies As FormBewakingFirmas
    Private _mySanctionHelper As SanctionHelper

    ''' <summary>
    ''' Om het aantal gebruikte velden te besparen, hebben we ervoor geopteerd om de datum van afspraak PBH te hergebruiken
    ''' Bij de externen zal deze datum gelden als de datum waarop de brief werd verstuurd.
    ''' </summary>
    ''' <param name="datasetRow"></param>
    ''' <remarks> SIDVRST - 02/05/2013</remarks>
    Public Sub New(ByVal datasetRow As TDSOvertreding.Lijst_OvertredingenRow)
        Try
            Cursor = Cursors.WaitCursor
            ' This call is required by the designer.
            InitializeComponent()
            _myProxy = New BBWServiceManagementServicesProxy()
            _searchCompanies = New FormBewakingFirmas()
            _myDataSetRow = datasetRow
            ' Add any initialization after the InitializeComponent() call.

            _dataBewakingSnelheidSanction.Merge(_myProxy.GetSnelheidSanction())
            Dim dsInfo As New TDSBriefSnelheidsovertredingInfo
            dsInfo = _myProxy.GetBriefSnelheidsovertredingInfo(datasetRow.RegistratieID)

            TextBoxDriverName.Text = datasetRow.Naam.TrimEnd().TrimStart() & " " & datasetRow.Voornaam.TrimEnd().TrimStart()
            TextBoxSnelheid.Text = If(datasetRow.IsGeregistreerdeSnelheidNull, 0, datasetRow.GeregistreerdeSnelheid)
            TextBoxMaxSnelheid.Text = If(datasetRow.IsToegelatenSnelheidNull, 0, datasetRow.ToegelatenSnelheid)
            TextBoxInfractionClass.Text = datasetRow.Inbreukklasse
            'TextBoxSanctionDuration.Text = If(datasetRow.IsSanctieDuurNull, "", datasetRow.SanctieDuur)
            'TextBoxSanctionPeriod.Text = If(datasetRow.IsSanctiePeriodeNull, "", datasetRow.SanctiePeriode)

            If (dsInfo.Info.Rows.Count > 0) Then
                TextBoxNrPlate.Text = dsInfo.Info(0).LicensePlate.ToString()

                If datasetRow.Inbreukklasse.Equals(String.Empty) Then
                    Select Case dsInfo.Info(0).Aantal
                        Case 0, 1
                            RadioButtonInbr1.Checked = True
                        Case 2
                            RadioButtonInbr2.Checked = True
                        Case Else
                            RadioButtonInbr3.Checked = True
                    End Select
                Else
                    Select Case True
                        Case datasetRow.SoortSanctie.ToUpper().Equals("1E INBREUK")
                            RadioButtonInbr1.Checked = True
                        Case datasetRow.SoortSanctie.ToUpper().Equals("2E INBREUK")
                            RadioButtonInbr2.Checked = True
                        Case Else
                            RadioButtonInbr3.Checked = True
                    End Select
                End If
            End If
            TextBoxVoertuig.Text = If(dsInfo.Info(0).IsVehiculeTypeNull(), "", dsInfo.Info(0).VehiculeType)

            If Not (datasetRow.IsSanctionIdNull) Then
                UltraComboSanction.Value = datasetRow.SanctionId
            End If
            If Not (datasetRow.IsTaalBriefNull) Then
                UltraComboEditorLanguage.Value = datasetRow.TaalBrief
            Else
                UltraComboEditorLanguage.Value = 1
            End If

            If Not _myDataSetRow.IsFirmaIdNull Then
                If (_myDataSetRow.FirmaId > 0) Then
                    _searchCompanies.FindFirmById(_myDataSetRow.FirmaId)
                    FillUpCompanyData()
                End If
            End If

            If Not _myDataSetRow.IsRijverbodVanNull Then
                UltraDateRijverbodVan.Value = _myDataSetRow.RijverbodVan
            End If

            If Not _myDataSetRow.IsRijverbodTotNull Then
                UltraDateRijverbodTot.Value = _myDataSetRow.RijverbodTot
            End If

            If Not _myDataSetRow.IsAfspraakPBHNull Then
                UltraDateAfspraakPBH.Value = _myDataSetRow.AfspraakPBH
            End If

            If Not _myDataSetRow.IsDatumBriefNull Then
                UltraDateTimeletterSend.Value = _myDataSetRow.DatumBrief
            End If

            ToolTipBBW.SetToolTip(ButtonReport, "Ophalen firma uit verslag")

        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default



    End Sub

    ''' <summary>
    ''' Firma ophalen uit lijst
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Private Sub ButtonZoekFirma_Click(sender As System.Object, e As System.EventArgs) Handles ButtonZoekFirma.Click
        Try
            Cursor = Cursors.WaitCursor
            If (_searchCompanies Is Nothing) Then
                _searchCompanies = New FormBewakingFirmas
            End If

            _searchCompanies.ShowDialog(Me)

            If _searchCompanies.DialogResult = DialogResult.OK Then
                FillUpCompanyData()
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default


    End Sub

    ''' <summary>
    ''' Opvullen velden met de gekozen firma
    ''' </summary>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub FillUpCompanyData()
        _myDataSetRow.FirmaId = _searchCompanies.IdFirma
        TextBoxNameFirm.Text = _searchCompanies.NaamFirma
        TextBoxAddressFirm.Text = _searchCompanies.AdresFirma
        TextBoxCityFirm.Text = _searchCompanies.PostNrFirma & " " & _searchCompanies.GemeenteFirma
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub UltraComboSanction_ValueChanged(sender As System.Object, e As System.EventArgs) Handles UltraComboSanction.ValueChanged

        Try
            Cursor = Cursors.Default
            If Not (IsNothing(UltraComboSanction.Value)) Then
                If UltraComboSanction.Value = 1 Or UltraComboSanction.Value = 0 Then

                    UltraDateRijverbodVan.Enabled = False
                    UltraDateRijverbodTot.Enabled = False

                    UltraDateRijverbodVan.Value = Nothing
                    UltraDateRijverbodTot.Value = Nothing

                    TextBoxSanctionDuration.Text = String.Empty
                    TextBoxSanctionPeriod.Text = String.Empty

                    If (UltraComboSanction.Value = 0) Then
                        UltraDateTimeletterSend.Enabled = False
                    End If

                Else
                    UltraDateRijverbodVan.Enabled = True
                    UltraDateRijverbodTot.Enabled = True
                    If (CInt(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value) > 0) Then
                        'If (IsNothing(UltraDateAfspraakPBH.Value)) Then
                        '    UltraDateAfspraakPBH.Value = DateTime.Now
                        'End If
                        If (IsNothing(UltraDateTimeletterSend.Value)) Then
                            UltraDateTimeletterSend.Value = DateTime.Now
                        End If
                        If (IsNothing(UltraDateRijverbodVan.Value)) Then
                            UltraDateRijverbodVan.Value = DateTime.Now
                        End If
                        RefreshRestrictions()
                        If Not _myDataSetRow.IsLastSanctionDoubledYNNull Then
                            If Not _myDataSetRow.LastSanctionDoubledYN Then
                                CheckBoxDoubleUp.Checked = False
                            End If
                        End If

                        If CheckBoxDoubleUp.Checked Then
                            TextBoxSanctionDuration.Text = UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value * 2
                        Else
                            TextBoxSanctionDuration.Text = UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value
                        End If
                        TextBoxSanctionPeriod.Text = UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionPeriodColumn.ColumnName).Value
                    End If
                End If
                UltraDateTimeletterSend.Value = DateTime.Now
            End If

            LabelRijverbodTot.Enabled = UltraDateRijverbodTot.Enabled
            LabelRijverbodVan.Enabled = UltraDateRijverbodVan.Enabled
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default



    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    ''' <summary>
    ''' Bepalen over welke inbreukkklasse we spreken
    ''' </summary>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Public ReadOnly Property GetInbreukKlasse() As String
        Get
            If (RadioButtonInbr1.Checked) Then
                Return "1e Inbreuk"
            End If
            If (RadioButtonInbr2.Checked) Then
                Return "2e Inbreuk"
            End If
            If (RadioButtonInbr3.Checked) Then
                Return "3e(+) Inbreuk"
            End If

            Return String.Empty
        End Get
    End Property

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub ButtonOK_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOK.Click
        Try
            Cursor = Cursors.WaitCursor

            'InputControle
            If Not (InputControle()) Then
                Cursor = Cursors.Default
                Exit Sub
            End If
            'Save Record
            _myProxy.UpdateOvertredingPrint(_myDataSetRow.RegistratieID, DateTime.Now, CheckBoxDoubleUp.Checked,
                                            GetInbreukKlasse(), If(TextBoxSanctionDuration.Text.Equals(String.Empty), Nothing, CInt(TextBoxSanctionDuration.Text)), _
                                            If(TextBoxSanctionPeriod.Text.Equals(String.Empty), Nothing, CStr(TextBoxSanctionPeriod.Text)), _
                                            UltraComboSanction.Value, _myDataSetRow.FirmaId, UltraComboEditorLanguage.Value, DateTime.Now, UltraDateRijverbodVan.Value, UltraDateRijverbodTot.Value, Nothing, 0)
            'Update Record in Grid
            _myDataSetRow.DatumBrief = DateTime.Now
            _myDataSetRow.SanctieOmschrijving = UltraComboSanction.Text
            _myDataSetRow.SoortSanctie = GetInbreukKlasse()
            _myDataSetRow.LastSanctionDoubledYN = CheckBoxDoubleUp.Checked

            If (GroupBoxDates.Enabled) Then

                If Not UltraDateRijverbodVan.Value Is Nothing Then
                    _myDataSetRow.RijverbodVan = UltraDateRijverbodVan.Value
                End If
                If Not UltraDateRijverbodTot.Value Is Nothing Then
                    _myDataSetRow.RijverbodTot = UltraDateRijverbodTot.Value
                End If

            End If

            If Not (TextBoxSanctionDuration.Text.Equals(String.Empty)) Then
                _myDataSetRow.SanctieDuur = CInt(TextBoxSanctionDuration.Text)
                _myDataSetRow.SanctiePeriode = TextBoxSanctionPeriod.Text
            End If

            If Not (IsNothing(UltraComboEditorLanguage.Value)) Then
                _myDataSetRow.TaalBrief = UltraComboEditorLanguage.Value
            End If
            _myDataSetRow.NaamFirma = TextBoxNameFirm.Text
            If Not UltraDateTimeletterSend Is Nothing Then
                '_myDataSetRow.DatumBrief = UltraDateTimeletterSend.Value
                _myDataSetRow.DatumBrief = Convert.ToDateTime(UltraDateTimeletterSend.Value).Date.AddTicks(DateTime.Now.TimeOfDay.Ticks)
            Else
                _myDataSetRow.DatumBrief = DateTime.Now
            End If
            _myDataSetRow.SanctionId = UltraComboSanction.Value

            If (UltraComboSanction.Value > 0) Then
                'Show Report
                Using myReport As New FormRapportInfractions(False, UltraComboSanction.Value = 2)
                    myReport.RegistrationID = _myDataSetRow.RegistratieID
                    myReport.PersonalId = _myDataSetRow.StamnrOvertreder
                    myReport.ShowDialog()
                End Using
            End If

            SendMail_LetterSanction() 'naco - sept 2016 - ibo-aanvraag EVAR 2015 10

            'DialogResult = True
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' ibo-aanvraag Eddy Van Renterghem - EVAR 2015 10
    ''' BBW - Vanuit toepassing bij "RIJVERBOD EXTERNE FIRMA" rechtstreeks een mail naar lokale verantwoordelijk sturen 
    ''' </summary>
    ''' <remarks>Nancy Coppens - 16/09/2016</remarks>
    Private Sub SendMail_LetterSanction()

        Dim f_rap As New FormRapportenPreview
        Dim textMailAutomatic As String
        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim pathPDFfile As String
        Dim lngRegistratieID As Long

        Try
            textMailAutomatic = "Geachte," & vbCrLf & vbCrLf &
                          "Er is een sanctiebrief afgedrukt voor deze overtreding:" & vbCrLf & vbCrLf &
                            "Naam chauffeur:   " & TextBoxDriverName.Text & vbCrLf & _
                            "Nrplaat:          " & TextBoxNrPlate.Text & vbCrLf & _
                            "Sanctie:          " & UltraComboSanction.Text & vbCrLf & vbCrLf & _
                            "Zie details in brief in bijlage."
            lngRegistratieID = CLng(_myDataSetRow.RegistratieID)

            _dataConfiguratie.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))
            pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD & _
                                  "Bewaking" & Year(Now) & "_" & lngRegistratieID.ToString & ".pdf"



            Dim rapportParameters As Hashtable = New Hashtable() 'Parameters voor rapport
            Dim rapportPreviewer As FormRapportenPreview = New FormRapportenPreview() 'Rapportgenerator
            Dim tdsConfig As TDSConfiguratie = New TDSConfiguratie
            tdsConfig.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))
            Dim serverpath As String = tdsConfig.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD()

            rapportParameters.Add("RegistratieID", lngRegistratieID)
            rapportPreviewer.ExportPdfBewakingRegistratie(serverpath, "InbreukVerkeersreglementExtern", pathPDFfile, rapportParameters)

            '2. automatische mail naar firma - sept 2016 - naco
            '-------------------------------------------
            Dim intIDFirmSAP As Integer
            'intIDFirmSAP = BBWServiceProxy.GetCHIP_SAPFirmNr(CInt(_myDataSetRow.FirmaId))
            intIDFirmSAP = HRMdata.GetSAPFirm_EmailContact_Firma(CInt(_myDataSetRow.FirmaId))

            If intIDFirmSAP > 0 And intIDFirmSAP <> 1001674 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP)

                Dim strMailToFirm As String
                'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP)

                If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                    MailBBW.SendMail_CHIP_NoContactPersonFound(intIDFirmSAP, TextBoxNameFirm.Text) 'Preventiedienst verwittigen => zo kan een contactpersoon worden ingevuld in SAP

                Else 'wel een contactpersoon => mail met verslag in bijlage versturen
                    'mail versturen
                    MailBBW.sendMailCHIP_ContactPerson(strMailToFirm, textMailAutomatic,
                                                       "AM Gent - Brief sanctie - " & TextBoxNameFirm.Text & " (" & intIDFirmSAP.ToString & ") - " & Now.Date,
                                                       pathPDFfile)
                End If

            Else
                If intIDFirmSAP <> 1001674 Then '1001674 = ArcelorMittal Gent => geen msgbox tonen
                    MessageBox.Show("Sanctiebrief kan niet automatisch naar firma gestuurd worden." & vbCrLf &
                                    "SAP firmanr niet gekend voor deze firma: " & _myDataSetRow.FirmaId & " - " & TextBoxNameFirm.Text & ".", "Automatische mail sanctiebrief", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            '-------------------------------------------

        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub CheckBoxDoubleUp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxDoubleUp.CheckedChanged

        Try
            Cursor = Cursors.WaitCursor
            If Not (TextBoxSanctionDuration.Text.Equals(String.Empty)) Then
                If (CheckBoxDoubleUp.Checked) Then
                    TextBoxSanctionDuration.Text = CInt(TextBoxSanctionDuration.Text) * 2
                Else
                    TextBoxSanctionDuration.Text = Math.Round(CInt(TextBoxSanctionDuration.Text) / 2, 0)
                End If
            End If
            RefreshRestrictions()
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default


    End Sub

    ''' <summary>
    ''' Controle van de ingegeven data
    ''' </summary>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Function InputControle() As Boolean
        If (IsNothing(UltraComboSanction.Value)) Then
            MessageBox.Show("Gelieve een sanctie aan te vullen. " & Environment.NewLine &
                            "Er werd nog geen sanctie geselecteerd voor deze overtreding.",
                            "Ontbrekende sanctie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        'If (UltraDateAfspraakPBH.Enabled) Then
        '    If (IsNothing(UltraDateAfspraakPBH.Value)) Then
        '        MessageBox.Show("U vergat de datum op te geven van de afspraak met de personeelsdienst." & Environment.NewLine &
        '                        "Alle datums die te vinden zijn onder 'datums' zijn verplicht",
        '                        "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return False
        '    End If
        'End If
        If (UltraDateRijverbodVan.Enabled) Then
            If (IsNothing(UltraDateRijverbodVan.Value)) Then
                MessageBox.Show("U vergat een startdatum van het rijverbod op te geven." & Environment.NewLine &
                                "Gelieve de datum op te geven wanneer het rijverbod begint.",
                                "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If
        If (UltraDateRijverbodTot.Enabled) Then
            If (IsNothing(UltraDateRijverbodTot.Value)) Then
                MessageBox.Show("U vergat een einddatum van het rijverbod op te geven." & Environment.NewLine &
                                "Gelieve de datum op te geven wanneer het rijverbod verloopt.",
                                "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If
        If (UltraDateRijverbodVan.Enabled And UltraDateRijverbodTot.Enabled) Then
            If (UltraDateRijverbodVan.Value > UltraDateRijverbodTot.Value) Then
                MessageBox.Show("De begindatum van het rijverbod mag niet later vallen dan de einddatum." & Environment.NewLine &
                                "Gelieve de datums aan te passen zodat de begindatum voor de einddatum valt.",
                                "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        If (TextBoxNameFirm.Text.Equals(String.Empty)) Then
            MessageBox.Show("U vergat een firma op te geven voor wie de betrokkene werkt." & Environment.NewLine &
                "Gelieve een firma te kiezen.",
                "Ontbrekende firma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If (IsNothing(UltraComboEditorLanguage.Value)) Then
            MessageBox.Show("U vergat een taal voor de brief te kiezen." & Environment.NewLine &
                            "Gelieve een taal aan te duiden.",
                            "Ontbrekende firma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Not (TextBoxMaxSnelheid.Text.Equals(String.Empty) Or TextBoxSnelheid.Equals(String.Empty)) Then
            If (CInt(TextBoxMaxSnelheid.Text) > CInt(TextBoxSnelheid.Text)) Then
                MessageBox.Show("De maximaal toegelaten snelheid kan bij een inbreuk onmogelijk hoger liggen dan gemeten snelheid." & Environment.NewLine &
                                "Gelieve de meting na te zien en de correcte snelheden op te laten.", "Incorrecte gegevens gedetecteerd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Herladen van het rijverbod
    ''' </summary>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub RefreshRestrictions()
        Try
            Cursor = Cursors.WaitCursor
            If Not IsNothing(UltraComboSanction.Value) Then
                If Not (IsNothing(UltraDateRijverbodVan.Value)) Then
                    Dim duration As Integer = CInt(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value)
                    Dim datePart As String = UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionPeriodColumn.ColumnName).Value
                    TextBoxSanctionPeriod.Text = datePart
                    Dim multiplier As Integer = 1
                    If (CheckBoxDoubleUp.Checked) Then
                        multiplier = 2
                    End If

                    Select Case True
                        Case datePart.Contains("maand")
                            UltraDateRijverbodTot.Value = CDate(UltraDateRijverbodVan.Value).AddMonths(duration * multiplier)
                            If (multiplier > 1) Then
                                TextBoxSanctionPeriod.Text = "maanden"
                            End If
                        Case datePart.Contains("week")
                            UltraDateRijverbodTot.Value = CDate(UltraDateRijverbodVan.Value).AddDays(duration * 7 * multiplier)
                            If (multiplier > 1) Then
                                TextBoxSanctionPeriod.Text = "weken"
                            End If
                        Case datePart.Contains("weken")
                            UltraDateRijverbodTot.Value = CDate(UltraDateRijverbodVan.Value).AddDays(duration * 7 * multiplier)
                        Case Else
                            Exit Sub
                    End Select

                End If
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub UltraDateRijverbodVan_ValueChanged(sender As System.Object, e As System.EventArgs) Handles UltraDateRijverbodVan.ValueChanged
        RefreshRestrictions()
    End Sub

    ''' <summary>
    ''' Datasetrow updaten met de nieuwe waarden
    ''' </summary>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Sub UpdateRow(ByRef dataRowCollection As DataRow())
        Try
            For Each dRow As DataRow In dataRowCollection
                If Not (UltraDateAfspraakPBH.Value Is Nothing) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.AfspraakPBHColumn.ColumnName) = _myDataSetRow.AfspraakPBH
                Else
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.AfspraakPBHColumn.ColumnName) = DBNull.Value
                End If
                If Not (UltraDateRijverbodVan.Value Is Nothing) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.RijverbodVanColumn.ColumnName) = _myDataSetRow.RijverbodVan
                Else
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.RijverbodVanColumn.ColumnName) = DBNull.Value
                End If
                If Not (UltraDateRijverbodTot.Value Is Nothing) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.RijverbodTotColumn.ColumnName) = _myDataSetRow.RijverbodTot
                Else
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.RijverbodTotColumn.ColumnName) = DBNull.Value
                End If
                If Not (UltraDateTimeletterSend.Value Is Nothing) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.DatumBriefColumn.ColumnName) = _myDataSetRow.DatumBrief
                Else
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.DatumBriefColumn.ColumnName) = DBNull.Value
                End If

                dRow.Item(_dataOvertreding.Lijst_Overtredingen.DatumBriefColumn.ColumnName) = _myDataSetRow.DatumBrief
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.AfdrukTijdstipColumn.ColumnName) = DateTime.Now

                dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctieOmschrijvingColumn.ColumnName) = _myDataSetRow.SanctieOmschrijving
                If (Not TextBoxSanctionDuration.Text.Equals(String.Empty)) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctieDuurColumn.ColumnName) = _myDataSetRow.SanctieDuur
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctiePeriodeColumn.ColumnName) = _myDataSetRow.SanctiePeriode
                Else
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctieDuurColumn.ColumnName) = DBNull.Value
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctiePeriodeColumn.ColumnName) = DBNull.Value
                End If
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.LastSanctionDoubledYNColumn.ColumnName) = _myDataSetRow.LastSanctionDoubledYN

                dRow.Item(_dataOvertreding.Lijst_Overtredingen.SoortSanctieColumn.ColumnName) = _myDataSetRow.SoortSanctie
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.InbreukklasseColumn.ColumnName) = _myDataSetRow.Inbreukklasse

                dRow.Item(_dataOvertreding.Lijst_Overtredingen.NaamFirmaColumn.ColumnName) = TextBoxNameFirm.Text
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctiePeriodeColumn.ColumnName) = _myDataSetRow.SanctiePeriode
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.TaalBriefColumn.ColumnName) = _myDataSetRow.TaalBrief
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctionIdColumn.ColumnName) = _myDataSetRow.SanctionId
            Next
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default

    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub FormPrintTrafficInfractionsExtern_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor
            If (UltraComboSanction.SelectedRow Is Nothing) Then

                Dim isTruck As Boolean = False
                If (TextBoxVoertuig.Text.ToLower.Trim().Contains("vrachtwagen")) Then
                    isTruck = True
                End If

                Dim rowCount As Integer
                If (_dataOvertreding.Lijst_Overtredingen.Rows.Count > 0) Then
                    rowCount = (From row In _dataOvertreding.Lijst_Overtredingen.AsEnumerable()
                                Where (row.inbreukKlasseId = 3 Or row.inbreukKlasseId = 5 Or row.inbreukKlasseId = 6)
                                Select row).AsDataView.Count()
                    rowCount = _dataOvertreding.Lijst_Overtredingen.Rows.Count - rowCount
                Else
                    rowCount = 0
                End If

                Select Case rowCount
                    Case 0
                        RadioButtonInbr1.Checked = True
                    Case 1
                        RadioButtonInbr2.Checked = True
                    Case Else
                        RadioButtonInbr3.Checked = True
                End Select

                Dim lastSanction As Integer = 0
                If (rowCount > 0) Then
                    Dim lastSanctionObj As Object = _dataOvertreding.Lijst_Overtredingen.OrderByDescending(Function(fc) fc.Tijdstip).AsDataView()(0).Item(_dataOvertreding.Lijst_Overtredingen.SanctionIdColumn.ColumnName)
                    If Not IsDBNull(lastSanctionObj) Then
                        Integer.TryParse(lastSanctionObj, lastSanction)
                    End If
                End If

                _mySanctionHelper = New SanctionHelper(TextBoxInfractionClass.Text, rowCount)
                Dim speedLimit As Integer = 0
                Dim velocity As Integer = 0

                Integer.TryParse(TextBoxMaxSnelheid.Text, speedLimit)
                Integer.TryParse(TextBoxSnelheid.Text, velocity)

                If (rowCount > 0) Then
                    UltraComboSanction.Value = _mySanctionHelper.CalculateSanction(lastSanction, TextBoxMaxSnelheid.Text, TextBoxSnelheid.Text, isTruck)
                Else
                    UltraComboSanction.Value = _mySanctionHelper.CalculateSanction(Nothing, TextBoxMaxSnelheid.Text, TextBoxSnelheid.Text, isTruck)
                End If
                CheckBoxDoubleUp.Checked = _mySanctionHelper.DoubleUpLastSanction

                If (UltraComboEditorLanguage.Value Is Nothing) Then
                    UltraComboEditorLanguage.Value = "NL"
                End If
            End If

            For Each dsRow As UltraGridRow In UltraGridPreviousInfractions.Rows
                Select Case CInt(dsRow.Cells(_dataOvertreding.Lijst_Overtredingen.inbreukKlasseIdColumn.ColumnName).Value)
                    Case 1 'Klasse 1
                        Continue For
                    Case 2 'Klasse 2
                        Continue For
                    Case 3 'Overige
                        dsRow.Appearance.BackColor = Drawing.Color.Green
                    Case 4 'Speeding
                        Continue For
                    Case 5 'Alg Bouwplaatsreglement
                        dsRow.Appearance.BackColor = Drawing.Color.Green
                    Case Else
                        Continue For
                End Select
            Next
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default

    End Sub

    Private Sub UltraDateTimeletterSend_ValueChanged(sender As System.Object, e As System.EventArgs) Handles UltraDateTimeletterSend.ValueChanged
    End Sub

    ''' <summary>
    ''' Ophalen Firma aan de hand van het verslag
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub ButtonReport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReport.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim TdsFirma As TDSFirmas = New TDSFirmas
            TdsFirma.Merge(_myProxy.GetFirmaIdForRegistration(_myDataSetRow.RegistratieID))

            Dim returnedId As Integer
            If (TdsFirma.BBFRM.Rows.Count > 0) Then
                returnedId = TdsFirma.BBFRM(0).ID_FRM
            End If

            If (returnedId > 0) Then
                _searchCompanies.FindFirmById(returnedId)
                FillUpCompanyData()
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub UltraGridPreviousInfractions_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridPreviousInfractions.InitializeLayout

    End Sub

    Private Sub RadioButtonInbr2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInbr2.CheckedChanged
        If (_myDataSetRow.SoortSanctie.Equals(String.Empty)) Then
            If (RadioButtonInbr2.Checked And UltraGridPreviousInfractions.Rows.Count = 0) Then
                If Not (MessageBox.Show("Opgelet: er zijn geen vorige inbreuken in de afgelopen 24 maanden en >= 15 maart 2013." & Environment.NewLine &
                                "Bent u zeker dat u 2de inbreuk wenst te selecteren?", "Opgelet!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                    RadioButtonInbr1.Checked = True
                End If

            End If
        End If
    End Sub

    Private Sub RadioButtonInbr3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInbr3.CheckedChanged
        If Me.Visible = False Then
            Exit Sub
        End If
        If (_myDataSetRow.SoortSanctie.Equals(String.Empty)) Then
            If (RadioButtonInbr3.Checked And UltraGridPreviousInfractions.Rows.Count = 1) Then
                If Not (MessageBox.Show("Opgelet: er zijn geen 2 vorige inbreuken in de afgelopen 24 maanden en >= 15 maart 2013." & Environment.NewLine &
                                "Bent u zeker dat u 3de inbreuk wenst te selecteren?", "Opgelet!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                    RadioButtonInbr3.Checked = True
                End If

            End If
        End If
    End Sub
End Class