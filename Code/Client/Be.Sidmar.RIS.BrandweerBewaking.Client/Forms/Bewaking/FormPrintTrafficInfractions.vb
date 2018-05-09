Option Explicit On
Option Infer On
Option Strict On

Imports System.IO
Imports System.Reflection.MethodBase
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt


Public Class FormPrintTrafficInfractions

    Private Const _temporaryFile As String = "C:\Temp\brief.pdf"

    Private _myProxy As BBWServiceManagementServicesProxy
    Private _myDataSetRow As TDSOvertreding.Lijst_OvertredingenRow
    Private _mySanctionHelper As SanctionHelper

    ''' <summary>
    ''' Public constructor.
    ''' </summary>
    ''' <param name="datasetRow"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal datasetRow As TDSOvertreding.Lijst_OvertredingenRow)
        Try
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _myProxy = New BBWServiceManagementServicesProxy()
            _myDataSetRow = datasetRow

            _dataBewakingSnelheidSanction.Merge(_myProxy.GetSnelheidSanction())

            Dim dsInfo As TDSBriefSnelheidsovertredingInfo
            dsInfo = _myProxy.GetBriefSnelheidsovertredingInfo(datasetRow.RegistratieID)

            TextBoxDriverName.Text = datasetRow.Naam.TrimEnd().TrimStart() & " " & datasetRow.Voornaam.TrimEnd().TrimStart()
            TextBoxSnelheid.Text = If(datasetRow.IsGeregistreerdeSnelheidNull, 0, datasetRow.GeregistreerdeSnelheid).ToString
            TextBoxMaxSnelheid.Text = If(datasetRow.IsToegelatenSnelheidNull, 0, datasetRow.ToegelatenSnelheid).ToString
            TextBoxInfractionClass.Text = datasetRow.Inbreukklasse
            'TextBoxSanctionDuration.Text = If(datasetRow.IsSanctieDuurNull, "", datasetRow.SanctieDuur)
            'TextBoxSanctionPeriod.Text = If(datasetRow.IsSanctiePeriodeNull, "", datasetRow.SanctiePeriode)

            If Not datasetRow.IsLastSanctionDoubledYNNull Then
                CheckBoxDoubleUp.Checked = datasetRow.LastSanctionDoubledYN
            End If

            If Not (datasetRow.IsSanctionIdNull) Then
                UltraComboSanction.Value = datasetRow.SanctionId
            End If

            If (dsInfo.Info.Rows.Count > 0) Then
                TextBoxNrPlate.Text = dsInfo.Info(0).LicensePlate.ToString()

                If datasetRow.SoortSanctie.Equals(String.Empty) Then
                    Select Case UltraGridPreviousInfractions.Rows.Count
                        Case 0
                            RadioButtonInbr1.Checked = True
                        Case 1
                            RadioButtonInbr2.Checked = True
                        Case Else
                            RadioButtonInbr3.Checked = True
                    End Select
                Else
                    Select Case True
                        Case datasetRow.SoortSanctie.Equals("1e Inbreuk")
                            RadioButtonInbr1.Checked = True
                        Case datasetRow.SoortSanctie.Equals("2e Inbreuk")
                            RadioButtonInbr2.Checked = True
                        Case Else
                            RadioButtonInbr3.Checked = True
                    End Select
                End If
                TextBoxVoertuig.Text = If(dsInfo.Info(0).IsVehiculeTypeNull(), "", dsInfo.Info(0).VehiculeType)

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

            If Not _myDataSetRow.IsAfdrukTijdstipNull Then
                UltraDateTimeAfdrukken.Value = _myDataSetRow.AfdrukTijdstip
            End If

            Dim hrProxy = New HRSServiceManagementServicesProxy
            TextBoxEmailChef.Text = hrProxy.GetEMailChef(_myDataSetRow.StamnrOvertreder)

            ucSAPPresence.PersonalNr = _myDataSetRow.StamnrOvertreder.ToString
            ucSAPPresence.Datum = DateTime.Today.AddDays(2)

            Cursor = Cursors.Default
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

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
    Private Sub UltraComboSanction_ValueChanged(sender As System.Object, e As System.EventArgs) Handles UltraComboSanction.ValueChanged
        Try
            Cursor = Cursors.WaitCursor
            If Not (IsNothing(UltraComboSanction.Value)) Then
                If CInt(UltraComboSanction.Value) = 1 Or CInt(UltraComboSanction.Value) = 0 Then
                    If (TextBoxInfractionClass.Text.Trim.ToLower.Equals("klasse 1")) Then
                        MessageBox.Show("Een klasse 1 kan onmogelijk een schriftelijke berisping krijgen." & Environment.NewLine &
                                        "De minimale sanctie is één week rijverbod." & Environment.NewLine &
                                        "Gelieve een nieuwe sanctie te kiezen.", "Ongeldige sanctie gekozen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        UltraComboSanction.Value = Nothing
                        Exit Sub
                    End If

                    UltraDateAfspraakPBH.Enabled = False
                    UltraDateRijverbodVan.Enabled = False
                    UltraDateRijverbodTot.Enabled = False
                    UltraDateAfspraakPBH.Value = Nothing
                    UltraDateRijverbodVan.Value = Nothing
                    UltraDateRijverbodTot.Value = Nothing

                    TextBoxSanctionDuration.Text = String.Empty
                    TextBoxSanctionPeriod.Text = String.Empty
                    If CInt(UltraComboSanction.Value) = 0 Then
                        UltraDateTimeAfdrukken.Enabled = False
                    End If
                Else
                    UltraDateAfspraakPBH.Enabled = True
                    UltraDateRijverbodVan.Enabled = True
                    UltraDateRijverbodTot.Enabled = True
                    If (CInt(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value) > 0) Then
                        If (IsNothing(UltraDateAfspraakPBH.Value)) Then
                            UltraDateAfspraakPBH.Value = DateTime.Now
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
                        GroupBoxDates.Enabled = True
                        If CheckBoxDoubleUp.Checked Then
                            TextBoxSanctionDuration.Text = CStr(CInt(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value) * 2)
                        Else
                            TextBoxSanctionDuration.Text = CStr(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionDurationColumn.ColumnName).Value)
                        End If
                        TextBoxSanctionPeriod.Text = CStr(UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionPeriodColumn.ColumnName).Value)
                    End If
                End If
                LabelRijverbodTot.Enabled = UltraDateRijverbodTot.Enabled
                LabelRijverbodVan.Enabled = UltraDateRijverbodVan.Enabled
                LabelAfspraak.Enabled = UltraDateAfspraakPBH.Enabled
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
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub ButtonOK_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOK.Click
        Try
            Cursor = Cursors.Default
            'InputControle
            If Not (InputControle()) Then
                Exit Sub
            End If
            'Save Record
            _myProxy.UpdateOvertredingPrint(_myDataSetRow.RegistratieID, DateTime.Now, CheckBoxDoubleUp.Checked,
                                            GetInbreukKlasse(), If(TextBoxSanctionDuration.Text.Equals(String.Empty), Nothing, CInt(TextBoxSanctionDuration.Text)),
                                            If(TextBoxSanctionPeriod.Text.Equals(String.Empty), Nothing, CStr(TextBoxSanctionPeriod.Text)),
                                            CInt(UltraComboSanction.Value), 0, String.Empty, DateTime.Now,
                                            CDate(UltraDateRijverbodVan.Value), CDate(UltraDateRijverbodTot.Value), CDate(UltraDateAfspraakPBH.Value),
                                            _myDataSetRow.StamnrOvertreder)
            'Update Record in Grid
            _myDataSetRow.DatumBrief = DateTime.Now
            _myDataSetRow.SanctieOmschrijving = UltraComboSanction.Text
            _myDataSetRow.SoortSanctie = GetInbreukKlasse()
            _myDataSetRow.LastSanctionDoubledYN = CheckBoxDoubleUp.Checked
            _myDataSetRow.SanctionId = CInt(UltraComboSanction.Value)

            If (GroupBoxDates.Enabled) Then
                If Not (UltraDateAfspraakPBH.Value Is Nothing) Then
                    _myDataSetRow.AfspraakPBH = CDate(UltraDateAfspraakPBH.Value)
                End If
                If Not (UltraDateRijverbodVan.Value Is Nothing) Then
                    _myDataSetRow.RijverbodVan = CDate(UltraDateRijverbodVan.Value)
                End If
                If Not (UltraDateRijverbodTot.Value Is Nothing) Then
                    _myDataSetRow.RijverbodTot = CDate(UltraDateRijverbodTot.Value)
                End If
            End If


            If Not (TextBoxSanctionDuration.Text.Equals(String.Empty)) Then
                _myDataSetRow.SanctieDuur = CInt(TextBoxSanctionDuration.Text)
            End If
            If Not (TextBoxSanctionPeriod.Text.Equals(String.Empty)) Then
                _myDataSetRow.SanctiePeriode = TextBoxSanctionPeriod.Text
            End If
            If Not (UltraDateTimeAfdrukken.Value Is Nothing) Then
                _myDataSetRow.AfdrukTijdstip = Convert.ToDateTime(UltraDateTimeAfdrukken.Value).Date.AddTicks(DateTime.Now.TimeOfDay.Ticks)
            Else
                _myDataSetRow.AfdrukTijdstip = DateTime.Now
            End If

            If CInt(UltraComboSanction.Value) > 0 Then
                ' Show Report
                ' -----------
                Using myReport As New FormRapportInfractions(True, CInt(UltraComboSanction.Value) = 2)
                    myReport.RegistrationID = _myDataSetRow.RegistratieID
                    myReport.PersonalId = _myDataSetRow.StamnrOvertreder
                    If Not (TextBoxSanctionPeriod.Text.Equals(String.Empty)) Then
                        myReport.SanctionPeriod = TextBoxSanctionPeriod.Text
                        myReport.SanctionDuration = TextBoxSanctionDuration.Text
                    End If
                    myReport.ShowDialog()

                    myReport.SaveAsPdf(_temporaryFile)
                End Using

                ' Open e-mail
                ' -----------
                If File.Exists(_temporaryFile) Then
                    Dim outlookApp = New Outlook.Application
                    outlookApp.CreateObject("outlook.application")
                    Dim mail = DirectCast(outlookApp.CreateItem(Outlook.OlItemType.olMailItem), Outlook._MailItem)
                    mail.To = TextBoxEmailChef.Text
                    mail.Subject = "Verkeersovertreding"
                    mail.Body = "Beste," & vbCrLf &
                                "Bijgaande brief werd aan uw medewerker bezorgd via interne post." & vbCrLf & vbCrLf &
                                "Met vriendelijke groeten," & vbCrLf & vbCrLf &
                                "Isabelle HEBBRECHT" & vbCrLf &
                                "ArcelorMittal Gent" & vbCrLf & vbCrLf &
                                "Secretary | Management Development" & vbCrLf &
                                "John Kennedylaan 51 B-9042 Gent" & vbCrLf &
                                "T +32 9 347 34 05"

                    mail.Attachments.Add(_temporaryFile)
                    mail.Display()
                End If
            End If

            'DialogResult = True
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' Form Closed event - clean up the mess we left behind.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormPrintTrafficInfractions_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ' But leave the file in case we're debugging
        If Not System.Diagnostics.Debugger.IsAttached Then
            File.Delete(_temporaryFile)
        End If
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>SIDVRST 02/05/2013</remarks>
    Private Sub CheckBoxDoubleUp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxDoubleUp.CheckedChanged
        Try
            Cursor = Cursors.WaitCursor
            If UltraComboSanction.SelectedRow Is Nothing Then
                Exit Sub
            End If
            If Not (TextBoxSanctionDuration.Text.Equals(String.Empty)) Then
                If (CheckBoxDoubleUp.Checked) Then
                    TextBoxSanctionDuration.Text = (CInt(TextBoxSanctionDuration.Text) * 2).ToString
                Else
                    TextBoxSanctionDuration.Text = Math.Round(CInt(TextBoxSanctionDuration.Text) / 2, 0).ToString
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

        If (GroupBoxDates.Enabled) Then
            If (UltraDateAfspraakPBH.Enabled) Then
                If (IsNothing(UltraDateAfspraakPBH.Value)) Then
                    MessageBox.Show("U vergat de datum op te geven van de afspraak met de personeelsdienst." & Environment.NewLine &
                                    "Alle datums die te vinden zijn onder 'datums' zijn verplicht",
                                    "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
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
                If (CDate(UltraDateRijverbodVan.Value) > CDate(UltraDateRijverbodTot.Value)) Then
                    MessageBox.Show("De begindatum van het rijverbod mag niet later vallen dan de einddatum." & Environment.NewLine &
                                    "Gelieve de datums aan te passen zodat de begindatum voor de einddatum valt.",
                                    "Ontbrekende datums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
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
                    Dim datePart As String = UltraComboSanction.SelectedRow.Cells(_dataBewakingSnelheidSanction.BBINBRSanction.SanctionPeriodColumn.ColumnName).Value.ToString
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
            ExceptionManager.Publish(ex)
        End Try

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
            Cursor = Cursors.WaitCursor
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

                dRow.Item(_dataOvertreding.Lijst_Overtredingen.DatumBriefColumn.ColumnName) = DateTime.Now
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
                dRow.Item(_dataOvertreding.Lijst_Overtredingen.SanctionIdColumn.ColumnName) = _myDataSetRow.SanctionId

                If Not (UltraDateTimeAfdrukken.Value Is Nothing) Then
                    dRow.Item(_dataOvertreding.Lijst_Overtredingen.AfdrukTijdstipColumn.ColumnName) = _myDataSetRow.AfdrukTijdstip
                End If

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
    Private Sub FormPrintTrafficInfractions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If (UltraComboSanction.SelectedRow Is Nothing) Then
                '1. Truck?
                Dim isTruck As Boolean = False
                If (TextBoxVoertuig.Text.ToLower.Trim().Contains("vrachtwagen")) Then
                    isTruck = True
                End If

                '2. Kijken of klasseid = 3 of 5 of 6 in de vorige overtredingen zitten
                '=> groen tonen, moeten niet in rekening gebracht worden - naco 17/10/2014
                'zo wordt een 2de inbreuk bv. 1ste inbreuk
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

                '3. Sanctie bepalen
                Dim lastSanction As Integer = 0
                'If (UltraGridPreviousInfractions.Rows.Count > 0) Then 'naco - 17/10/2014
                If (rowCount > 0) Then
                    Dim lastSanctionObj As Object = _dataOvertreding.Lijst_Overtredingen.OrderByDescending(Function(fc) fc.Tijdstip).AsDataView()(0).Item(_dataOvertreding.Lijst_Overtredingen.SanctionIdColumn.ColumnName)
                    If Not IsDBNull(lastSanctionObj) Then
                        Integer.TryParse(lastSanctionObj.ToString, lastSanction)
                    End If
                End If

                _mySanctionHelper = New SanctionHelper(TextBoxInfractionClass.Text, rowCount)
                '_mySanctionHelper = New SanctionHelper(TextBoxInfractionClass.Text, UltraGridPreviousInfractions.Rows.Count) - naco - 17/10/2014
                Dim speedLimit As Integer = 0
                Dim velocity As Integer = 0

                Integer.TryParse(TextBoxMaxSnelheid.Text, speedLimit)
                Integer.TryParse(TextBoxSnelheid.Text, velocity)

                'If (_dataOvertreding.Lijst_Overtredingen.Rows.Count > 0) Then
                If (rowCount > 0) Then 'naco - 17/10/2014
                    UltraComboSanction.Value = _mySanctionHelper.CalculateSanction(lastSanction, CInt(TextBoxMaxSnelheid.Text), CInt(TextBoxSnelheid.Text), isTruck)
                Else
                    UltraComboSanction.Value = _mySanctionHelper.CalculateSanction(Nothing, CInt(TextBoxMaxSnelheid.Text), CInt(TextBoxSnelheid.Text), isTruck)
                End If
                CheckBoxDoubleUp.Checked = _mySanctionHelper.DoubleUpLastSanction
            End If

            '4. Vorige overtredingen => rows groen kleuren voor 3 en 5
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
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 14/10/2014</remarks>
    Private Sub ButtonInfo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInfo.Click

        Dim strMsg As String = ""
        strMsg = "Extra info:" & vbCrLf & vbCrLf &
                 "1. Datum >= 15/03/2013" & vbCrLf &
                 "----------------------------" & vbCrLf &
                 "=> opstart nieuwe regelmentering en sancties overtredingen (vastgelegd door PEB en PBH)." & vbCrLf & vbCrLf &
                 "2. Groene kleur" & vbCrLf &
                 "------------------" & vbCrLf &
                 "= inbreukklasse 3) Overige en 5) Alg Bouwplaatsreglement" & vbCrLf & vbCrLf &
                 "3. Mogelijke inbreukklasses:" & vbCrLf &
                 "-------------------------------" & vbCrLf &
                 "1) Klasse 1" & vbCrLf &
                 "2) Klasse 2" & vbCrLf &
                 "3) Overige" & vbCrLf &
                 "4) Snelheid" & vbCrLf &
                 "5) Alg Bouwplaatsreglement" & vbCrLf &
                 "6) Arbeidsreglement"

        'Tabel BBINBRKlasse
        '1 Klasse 1
        '2 Klasse 2
        '3 Overige
        '4 Snelheid
        '5 Alg Bouwplaatsreglement
        '6 Arbeidsreglement

        MessageBox.Show(strMsg, "Info over sancties", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class