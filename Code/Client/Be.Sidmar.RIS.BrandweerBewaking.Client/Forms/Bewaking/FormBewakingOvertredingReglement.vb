Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection
Imports System.Threading.Tasks
Imports Infragistics.Win
Imports System.Collections.Generic
Imports Infragistics.Win.UltraWinGrid
Imports System.Drawing
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding
Imports System.Data.Linq
Imports System.Linq
Imports System.IO.File
Imports System.Reflection.MethodBase
Imports System.IO
Imports System.Configuration
Imports Microsoft.Office.Interop

Public Class FormBewakingOvertredingReglement

    Private _myProxy As BBWServiceManagementServicesProxy
    Private _listOfEmail As List(Of String)
    Private _emailAdressesToAvoid As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ToolTipInfractionsRegulations.SetToolTip(ButtonShowHierarchicalLine, "Enkel eerste 3 leidinggevenden in hiërarchische lijn")
        'If (DateTime.Now.Date.Year = 2013) Then
        '    UltraComboRetrieveInfractionsFrom.Value = New DateTime(2013, 3, 15)
        'Else
        '    UltraComboRetrieveInfractionsFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        'End If

    End Sub

    Private Sub FormBewakingOvertredingReglement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            _myProxy = New BBWServiceManagementServicesProxy
            _dataOvertredingIntern.Clear()
            _dataOvertredingIntern.Merge(_myProxy.GetOvertredingen(True, UltraComboRetrieveInfractionsFrom.Value))
            _listOfEmail = New List(Of String)
            _emailAdressesToAvoid = New List(Of String)
            _emailAdressesToAvoid = _myProxy.GetPersonalIdsToAvoidDuringMailing()
            MarkeerHogeSnelheden(UltraGridIntern)
        Catch ex As Exception

            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub MarkeerHogeSnelheden(ByVal grid As UltraGrid)

        For Each row As UltraGridRow In grid.Rows
            If ((CInt(row.Cells("GeregistreerdeSnelheid").Value) - CInt(row.Cells("ToegelatenSnelheid").Value)) >= 20) Then
                row.Appearance.ForeColor = Color.Red
                row.Appearance.FontData.Bold = DefaultableBoolean.True
                row.Cells("20+").Value = True
                row.Update()
            Else
                row.Update()
            End If
            If row.Cells("Inbreukklasse").Value.Equals("Klasse 1") Then
                row.Appearance.BackColor = Color.Orange
                row.Appearance.FontData.Bold = DefaultableBoolean.True
            End If
        Next
    End Sub

    Private Sub UltraTabControlInfractions_SelectedTabChanged(sender As System.Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControlInfractions.SelectedTabChanged
        Try


            LabelDirectChefs.Text = String.Empty
            LabelName.Text = String.Empty

            ToolStripButtonLetterSent.Enabled = True
            ButtonShowHierarchicalLine.Enabled = True
            ButtonMail.Enabled = True
            ButtonOpenReport.Enabled = True

            ToolStripButtonGiveRemarks.Enabled = False
            ToolStripButtonDeleteSanction.Enabled = False

            Cursor = Cursors.WaitCursor
            If (_myProxy Is Nothing) Then
                _myProxy = New BBWServiceManagementServicesProxy()
            End If

            If (UltraComboRetrieveInfractionsFrom.Value Is Nothing) Then
                Exit Sub
            End If

            Select Case UltraTabControlInfractions.SelectedTab.Index
                Case 0
                    ToolStripButtonLetterSent.Enabled = False
                    _dataOvertredingIntern.Clear()
                    _dataOvertredingIntern.Merge(_myProxy.GetOvertredingen(True, UltraComboRetrieveInfractionsFrom.Value))
                    ButtonShowHierarchicalLine.Enabled = True

                    With UltraGridIntern.DisplayLayout.Bands(0)
                        .ColumnFilters.ClearAllFilters()
                        If (DateTime.Now.Year >= 2014) Then
                            .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(DateTime.Now.Year, 1, 1))
                        Else
                            .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(2013, 3, 15))
                        End If

                    End With
                    ToolStripButtonGiveRemarks.Enabled = True
                    ToolStripButtonDeleteSanction.Enabled = True
                    MarkeerHogeSnelheden(UltraGridIntern)
                Case 1
                    ToolStripButtonLetterSent.Enabled = True
                    _dataOvertredingExtern.Clear()
                    _dataOvertredingExtern.Merge(_myProxy.GetOvertredingen(False, UltraComboRetrieveInfractionsFrom.Value))
                    ButtonShowHierarchicalLine.Enabled = False
                    ToolStripButtonGiveRemarks.Enabled = False
                    ToolStripButtonDeleteSanction.Enabled = False

                    With UltraGridInfractionsExtern.DisplayLayout.Bands(0)
                        .ColumnFilters.ClearAllFilters()
                        If (DateTime.Now.Year >= 2014) Then
                            .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(DateTime.Now.Year, 1, 1))
                        Else
                            .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(2013, 3, 15))
                        End If

                    End With
                    MarkeerHogeSnelheden(UltraGridInfractionsExtern)
                Case 2
                    ToolStripButtonLetterSent.Enabled = False
                    ButtonShowHierarchicalLine.Enabled = False
                    ButtonMail.Enabled = False
                    ButtonOpenReport.Enabled = False
                    ToolStripButtonGiveRemarks.Enabled = False
                    ToolStripButtonDeleteSanction.Enabled = False

                    If (_dataBewakingSnelheidSanction.BBINBRSanction.Rows.Count = 0) Then
                        _dataBewakingSnelheidSanction.Merge(_myProxy.GetSnelheidSanction)
                    End If

                    If (_dataBewakingSnelheidSanctionMatrix.BBINBRSanctionMatrix.Rows.Count = 0) Then
                        _dataBewakingSnelheidSanctionMatrix.Merge(_myProxy.GetSnelheidSanctionMatrix)
                    End If
                Case Else
                    ToolStripButtonLetterSent.Enabled = False
            End Select
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

    End Sub

    Private Sub ButtonShowHierarchicalLine_Click(sender As System.Object, e As System.EventArgs) Handles ButtonShowHierarchicalLine.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim personalId As Integer = 0
            Select Case UltraTabControlInfractions.SelectedTab.Index
                Case 0
                    If Not UltraGridIntern.ActiveRow Is Nothing Then
                        If Not UltraGridIntern.ActiveRow.IsFilterRow Then
                            personalId = CInt(UltraGridIntern.ActiveRow.Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value)
                        End If
                    End If
                Case 1
                    If Not UltraGridInfractionsExtern.ActiveRow Is Nothing Then
                        If Not UltraGridInfractionsExtern.ActiveRow.IsFilterRow Then
                            personalId = CInt(UltraGridInfractionsExtern.ActiveRow.Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value)
                        End If
                    End If
            End Select

            If (personalId = 0) Then
                MessageBox.Show("Gelieve een rij te selecteren.", "Geen selectie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim wsHRS As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.HRSService.HRMData.Services
            Dim dsChefs As New DataSet

            Try
                Dim strStamnr As String = "0"
                LabelDirectChefs.Text = ""
                LabelName.Text = ""

                '1. naam van stamnummer
                '----------------------
                Dim dsPers As New DataSet
                dsPers.Merge(wsHRS.GetPersonDetail(personalId))
                If dsPers.Tables(0).Rows.Count = 0 Then
                Else
                    LabelName.Text = dsPers.Tables(0).Rows(0).Item("NM_FAM").ToString.Trim & " " &
                                     dsPers.Tables(0).Rows(0).Item("VNM").ToString.Trim & " - " &
                                     dsPers.Tables(0).Rows(0).Item("COD_EH_ORG_AFD").ToString.Trim & " - " &
                                     dsPers.Tables(0).Rows(0).Item("SCF_FIE").ToString.Trim
                End If

                '2. directe chefs
                '----------------
                dsChefs.Merge(wsHRS.GetDirectChefs(personalId))
                Dim i As Integer
                LabelDirectChefs.Text = ""
                Dim strChef As String
                _listOfEmail.Clear()

                If dsChefs.Tables.Count = 0 Then
                    MessageBox.Show("Geen leidinggevenden gevonden bij ArcelorMittal Gent voor deze persoon.", "Leiding", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    For i = 0 To dsChefs.Tables(0).Rows.Count - 1
                        strChef = (i + 1).ToString & ") Stamnr: " & dsChefs.Tables(0).Rows(i).Item(1).ToString & " - " &
                            dsChefs.Tables(0).Rows(i).Item(2).ToString.Trim & " " &
                            dsChefs.Tables(0).Rows(i).Item(3).ToString.Trim & " - " &
                            "Tel: " & dsChefs.Tables(0).Rows(i).Item(4).ToString & " - " &
                            dsChefs.Tables(0).Rows(i).Item(6).ToString.Trim & " - " &
                            "Email: " & dsChefs.Tables(0).Rows(i).Item("EMAL").ToString.Trim


                        If Not _emailAdressesToAvoid.Contains(dsChefs.Tables(0).Rows(i).Item(1).ToString) Then
                            _listOfEmail.Add(dsChefs.Tables(0).Rows(i).Item("EMAL").ToString.Trim)
                        End If


                        If i = 0 Then
                            LabelDirectChefs.Text = strChef
                        Else
                            LabelDirectChefs.Text = LabelDirectChefs.Text & vbCrLf &
                                                    strChef
                        End If

                    Next
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

    Private Sub ToolStripButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonCopy.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim row As Infragistics.Win.UltraWinGrid.UltraGridRow

            Select Case UltraTabControlInfractions.ActiveTab.Index
                Case 0
                    UltraGridIntern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                    UltraGridIntern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

                    For Each row In UltraGridIntern.Rows
                        row.Selected = True
                    Next row

                    UltraGridIntern.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

                    UltraGridIntern.Selected.Rows.Clear()
                    UltraGridIntern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
                    UltraGridIntern.ActiveRow = UltraGridIntern.ActiveRowScrollRegion.FirstRow

                Case 1
                    UltraGridInfractionsExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                    UltraGridInfractionsExtern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

                    For Each row In UltraGridInfractionsExtern.Rows
                        row.Selected = True
                    Next row

                    UltraGridInfractionsExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                    UltraGridInfractionsExtern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                    UltraGridInfractionsExtern.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

                    UltraGridInfractionsExtern.Selected.Rows.Clear()
                    UltraGridInfractionsExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
                    UltraGridInfractionsExtern.ActiveRow = UltraGridInfractionsExtern.ActiveRowScrollRegion.FirstRow

                Case Else

            End Select

            Cursor = Cursors.Default

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click
        Try

            If (UltraComboRetrieveInfractionsFrom.Value Is Nothing) Then
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            Dim controller As New ControllerGetData
            controller = New ControllerGetData
            Select Case UltraTabControlInfractions.ActiveTab.Index
                Case 0
                    _dataOvertredingIntern.Clear()
                    _dataOvertredingIntern.Merge(_myProxy.GetOvertredingen(True, UltraComboRetrieveInfractionsFrom.Value))
                    MarkeerHogeSnelheden(UltraGridIntern)
                    UltraGridIntern.DataBind()
                Case 1
                    _dataOvertredingExtern.Clear()
                    _dataOvertredingExtern.Merge(_myProxy.GetOvertredingen(False, UltraComboRetrieveInfractionsFrom.Value))
                    MarkeerHogeSnelheden(UltraGridInfractionsExtern)
                    UltraGridInfractionsExtern.DataBind()
            End Select

            UltraGridIntern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
            UltraGridInfractionsExtern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

            With UltraGridIntern.DisplayLayout.Bands(0)
                .ColumnFilters.ClearAllFilters()
                'If (DateTime.Now.Year >= 2014) Then
                '    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(DateTime.Now.Year, 1, 1))
                'Else
                '    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(2013, 3, 15))
                'End If
                '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Like, "Arcelor Gent")
                .Columns("OvertrederType").Hidden = True
                MarkeerHogeSnelheden(UltraGridIntern)
            End With

            With UltraGridInfractionsExtern.DisplayLayout.Bands(0)
                .ColumnFilters.ClearAllFilters()
                'If (DateTime.Now.Year >= 2014) Then
                '    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(DateTime.Now.Year, 1, 1))
                'Else
                '    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(2013, 3, 15))
                'End If
                '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.NotLike, "Arcelor Gent")
                MarkeerHogeSnelheden(UltraGridInfractionsExtern)
            End With
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
    End Sub

    Private Sub ButtonOpenReport_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpenReport.Click
        Try
            Dim grid = If(UltraTabControlInfractions.ActiveTab.Index = 0,
                  UltraGridIntern,
                  UltraGridInfractionsExtern)

            If grid.ActiveRow Is Nothing Then Return
            If Not grid.ActiveRow.IsDataRow Then Return

            Dim idRegistratie = Convert.ToInt32(grid.ActiveRow.GetCellValue("RegistratieID"))
            If idRegistratie <= 0 Then Return

            Using f = New FormBewakingInbreukReglementen(idRegistratie)
                f.ShowDialog(Me)
            End Using
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

    Private Sub ButtonMail_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMail.Click
        Try
            Cursor = Cursors.WaitCursor
            'Lokale variabelen
            Dim selectedId As Integer 'Id vd registratie
            Dim fileLocation As String = String.Empty 'locatie van de pdf
            Dim rapportPreviewer As FormRapportenPreview = New FormRapportenPreview() 'Rapportgenerator
            Dim rapportNaam As String = String.Empty 'naam rapport (op de reporting server)
            Dim rapportParameters As Hashtable = New Hashtable() 'Parameters voor rapport
            Dim hrsProxy As HRSServiceManagementServicesProxy = New HRSServiceManagementServicesProxy() 'Hrs -> Postvak & direct verantwoordelijken
            Dim folderLocation As String 'Map voor de pdf's

            'Ophalen waar de pdf's worden opgeslagen.
            folderLocation = ConfigurationManager.AppSettings.Get("ExportFolderPdf").ToString()
            folderLocation = "C:\temp\files\BBW\"

            'De locatie op de reportingserver ophalen
            Dim tdsConfig As TDSConfiguratie = New TDSConfiguratie
            tdsConfig.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))
            Dim serverpath As String = tdsConfig.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD()

            'Intern
            If (UltraTabControlInfractions.SelectedTab.Index = 0) Then
                If (UltraGridIntern.Selected.Rows.Count > 0) Then
                    'Ophalen registratieId
                    selectedId = UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                    'Ophalen rapport  + invullen parameters
                    rapportNaam = "InbreukVerkeersreglement"
                    rapportParameters.Add("RegistratieID", selectedId)
                    rapportParameters.Add("Postbin", hrsProxy.GetPostVak(UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value.ToString()))
                    rapportParameters.Add("SanctionDuration", UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.SanctieDuurColumn.ColumnName).Value.ToString())
                    rapportParameters.Add("SanctionPeriod", UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.SanctiePeriodeColumn.ColumnName).Value.ToString())
                End If

                'Opbouwen bestandsnaam
                fileLocation = folderLocation & UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.JaarColumn.ColumnName).Value.ToString() & "_" &
                                                UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.VolgnrColumn.ColumnName).Value.ToString() & "_" &
                                                UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.VoornaamColumn.ColumnName).Value.ToString().Trim() & "-" &
                                                UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.NaamColumn.ColumnName).Value.ToString().Trim() & ".pdf"
                'Extern
            ElseIf (UltraTabControlInfractions.SelectedTab.Index = 1) Then
                If (UltraGridInfractionsExtern.Selected.Rows.Count > 0) Then
                    'Ophalen registratieId
                    selectedId = UltraGridInfractionsExtern.Selected.Rows(0).Cells(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                    'Ophalen rapport  + invullen parameters
                    rapportNaam = "InbreukVerkeersreglementExtern"
                    rapportParameters.Add("RegistratieID", selectedId)
                End If

                fileLocation = folderLocation & UltraGridInfractionsExtern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.JaarColumn.ColumnName).Value.ToString() & "_" &
                                                UltraGridInfractionsExtern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.VolgnrColumn.ColumnName).Value.ToString() & "_" &
                                                UltraGridInfractionsExtern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.VoornaamColumn.ColumnName).Value.ToString().Trim() & "-" &
                                                UltraGridInfractionsExtern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.NaamColumn.ColumnName).Value.ToString().Trim() & ".pdf"

            End If

            'Checken bestaan directories
            If Not Directory.Exists(folderLocation) Then
                Directory.CreateDirectory(folderLocation)
            End If
            If File.Exists(fileLocation) Then
                File.Delete(fileLocation)
            End If

            'exporteren pdf
            rapportPreviewer.ExportPdfBewakingRegistratie(serverpath, rapportNaam, fileLocation, rapportParameters)

            'Ophalen bestemmelingen - Enkel voor internen
            'Dit zijn de 1e 3 Directe chefs
            _listOfEmail.Clear()
            If (_listOfEmail.Count = 0 And
                UltraTabControlInfractions.SelectedTab.Index = 0) Then

                Dim dsChefs As DataSet = New DataSet
                Dim wsHRS As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.HRSService.HRMData.Services

                dsChefs.Merge(wsHRS.GetDirectChefs(UltraGridIntern.Selected.Rows(0).Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value.ToString()))
                Dim i As Integer

                _listOfEmail.Clear()

                If dsChefs.Tables.Count > 0 Then
                    For i = 0 To dsChefs.Tables(0).Rows.Count - 1

                        If Not _emailAdressesToAvoid.Contains(dsChefs.Tables(0).Rows(i).Item(1).ToString) Then
                            _listOfEmail.Add(dsChefs.Tables(0).Rows(i).Item("EMAL").ToString.Trim)
                        End If

                    Next
                End If
            End If

            Dim destintees As String = String.Empty
            For Each person As String In _listOfEmail
                destintees &= person & ";"
            Next

            'Opbouwen e-mail
            Dim outlookApp As New Outlook.Application
            outlookApp.CreateObject("outlook.application")
            Dim olMail As Outlook._MailItem
            olMail = outlookApp.CreateItem(Outlook.OlItemType.olMailItem)
            olMail.To = destintees
            olMail.Body = "Beste," & vbCrLf &
                          "Bijgaande brief werd aan uw medewerker bezorgd via interne post." & vbCrLf & vbCrLf &
                          "Met vriendelijke groeten,"
            'naco - body aangepast op vraag van Isabel Hebbrecht - 11/09/2014

            olMail.Subject = "Inbreuk op verkeersreglement ArcelorMittal Gent"
            olMail.Attachments.Add(fileLocation)
            olMail.Display()
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

    Private Sub UltraGridIntern_DoubleClickCell(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles UltraGridIntern.DoubleClickCell
        Cursor = Cursors.WaitCursor
        Try
            If Not e.Cell.Row.IsFilterRow Then
                'Ophalen indien geldige klasse
                Dim strInbreukklasse As String = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.InbreukklasseColumn.ColumnName).Value.ToString().Trim().ToLower()
                If Not (strInbreukklasse.Equals("klasse 1") Or _
                        strInbreukklasse.Equals("klasse 2") Or _
                        strInbreukklasse.Equals("snelheid")) Then
                    MessageBox.Show("Voor deze overtreding hoeft geen sanctie te worden afgedrukt." & Environment.NewLine &
                                    "Dit is enkel nodig voor Klasse 1, Klasse 2 en Snelheid.", " Geen Sanctie nodig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                'Ophalen RegistratieId + ArtikelNr van de geselecteerde rij
                Dim selectedId As Integer = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                Dim artNbr As String = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.ArtnrColumn.ColumnName).Value

                'Ophalen Overtredingrij aan de hand van voorgaande variabelen
                Dim selectedRow As TDSOvertreding.Lijst_OvertredingenRow = (From infraction In _dataOvertredingIntern.Lijst_Overtredingen.AsEnumerable()
                                                                             Where infraction.RegistratieID = selectedId And infraction.Artnr.Equals(artNbr)
                                                                             Select infraction).SingleOrDefault()

                If Not (IsNothing(selectedRow)) Then
                    Dim frmPrintTrafficInfraction As FormPrintTrafficInfractions = New FormPrintTrafficInfractions(selectedRow)
                    If strInbreukklasse.Equals("klasse 1") Then
                        frmPrintTrafficInfraction.CheckBoxDoubleUp.Enabled = True
                    End If
                    'Ophalen stamnummer overtreder
                    Dim selectedPersonalId As Integer = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value
                    Dim timeIncident As DateTime = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.TijdstipColumn.ColumnName).Value
                    'Ophalen overtredingen van vorige Persoon gedurende de laatste 24 maanden (sinds 15/03/2013)
                    frmPrintTrafficInfraction._dataOvertreding.Merge((From infraction In _dataOvertredingIntern.Lijst_Overtredingen.AsEnumerable()
                                                                      Where infraction.StamnrOvertreder = selectedPersonalId And
                                                                      infraction.RegistratieID <> selectedId And
                                                                      infraction.Tijdstip >= DateTime.Now.AddYears(-2) And
                                                                      infraction.Tijdstip <= timeIncident And
                                                                      infraction.Tijdstip >= New DateTime(2013, 3, 15, 0, 0, 0)
                                                                      Select infraction).ToArray())
                    '
                    Cursor = Cursors.Default
                    If (frmPrintTrafficInfraction.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                        frmPrintTrafficInfraction.UpdateRow(_dataOvertredingIntern.Lijst_Overtredingen.Select(_dataOvertredingIntern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName & "=" & selectedId))
                    End If

                End If

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

    Private Sub UltraGridInfractionsExtern_DoubleClickCell(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles UltraGridInfractionsExtern.DoubleClickCell
        Try
            Cursor = Cursors.WaitCursor
            If Not e.Cell.Row.IsFilterRow Then

                Dim strInbreukklasse As String = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.InbreukklasseColumn.ColumnName).Value.ToString().Trim().ToLower()
                If Not (strInbreukklasse.Equals("klasse 1") Or _
                        strInbreukklasse.Equals("klasse 2") Or _
                        strInbreukklasse.Equals("snelheid")) Then
                    MessageBox.Show("Voor deze overtreding hoeft geen sanctie te worden afgedrukt." & Environment.NewLine &
                                    "Dit is enkel nodig voor Klasse 1, Klasse 2 en Snelheid.", " Geen Sanctie nodig", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                'Ophalen RegistratieId + ArtikelNr van de geselecteerde rij
                Dim selectedId As Integer = e.Cell.Row.Cells(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                Dim artNbr As String = e.Cell.Row.Cells(_dataOvertredingExtern.Lijst_Overtredingen.ArtnrColumn.ColumnName).Value

                'Ophalen Overtredingrij aan de hand van voorgaande variabelen
                Dim selectedRow As TDSOvertreding.Lijst_OvertredingenRow = (From infraction In _dataOvertredingExtern.Lijst_Overtredingen.AsEnumerable()
                                                                             Where infraction.RegistratieID = selectedId And infraction.Artnr.Equals(artNbr)
                                                                           Select infraction).SingleOrDefault()

                If Not (IsNothing(selectedRow)) Then
                    Dim frmPrintTrafficInfraction As FormPrintTrafficInfractionsExtern = New FormPrintTrafficInfractionsExtern(selectedRow)
                    If strInbreukklasse.Equals("klasse 1") Then
                        frmPrintTrafficInfraction.CheckBoxDoubleUp.Enabled = True
                    End If
                    'Ophalen stamnummer overtreder
                    Dim selectedPersonalId As Integer = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.StamnrOvertrederColumn.ColumnName).Value
                    Dim timeIncident As DateTime = e.Cell.Row.Cells(_dataOvertredingIntern.Lijst_Overtredingen.TijdstipColumn.ColumnName).Value
                    'Ophalen overtredingen van vorige Persoon gedurende de laatste 24 maanden (sinds 15/03/2013)
                    frmPrintTrafficInfraction._dataOvertreding.Merge((From infraction In _dataOvertredingExtern.Lijst_Overtredingen.AsEnumerable()
                                                                      Where infraction.StamnrOvertreder = selectedPersonalId And
                                                                      infraction.RegistratieID <> selectedId And
                                                                      infraction.Tijdstip >= DateTime.Now.AddYears(-2) And
                                                                      infraction.Tijdstip <= timeIncident And
                                                                      infraction.Tijdstip >= New DateTime(2013, 3, 15, 0, 0, 0)
                                                                      Select infraction).ToArray())

                    If (frmPrintTrafficInfraction.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                        frmPrintTrafficInfraction.UpdateRow(_dataOvertredingExtern.Lijst_Overtredingen.Select(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName & "=" & selectedId))
                    End If

                End If

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

    Private Sub ToolStripButtonLetterSent_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonLetterSent.Click
        If MessageBox.Show(" Bent u zeker dat de door u geselecteerde brief werd verstuurd?", "Bevestiging gevraagd",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        Try
            If (UltraTabControlInfractions.SelectedTab.Index = 1) Then
                For Each dr As UltraGridRow In UltraGridInfractionsExtern.Selected.Rows
                    Dim selectedId As Integer = dr.Cells(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                    If (Not IsNothing(selectedId)) Then

                        If Not IsDBNull(dr.Cells(_dataOvertredingExtern.Lijst_Overtredingen.AfdrukTijdstipColumn.ColumnName).Value) Then
                            _myProxy.UpdateDateLetterSent(selectedId, DateTime.Now)
                            dr.Cells(_dataOvertredingExtern.Lijst_Overtredingen.AfspraakPBHColumn.ColumnName).Value = DateTime.Now
                        Else
                            MessageBox.Show("Voor deze inbreuk werd nog geen brief opgemaakt." & Environment.NewLine &
                                            "Gelieve eerst een brief op te maken.", "Geen brief gevonden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If

                    End If
                Next
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

    Private Sub UltraGridIntern_AfterRowActivate(sender As System.Object, e As System.EventArgs) Handles UltraGridIntern.AfterRowActivate
        LabelDirectChefs.Text = String.Empty
        LabelName.Text = String.Empty
    End Sub

    Private Sub ButtonRetrieveData_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRetrieveData.Click
        ToolStripButtonRefresh.PerformClick()
    End Sub

    Private Sub ToolStripButtonDeleteSanction_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonDeleteSanction.Click
        If Not (UltraGridIntern.ActiveRow Is Nothing) Then
            If Not (UltraGridIntern.ActiveRow.IsFilterRow()) Then

                If (MessageBox.Show("Bent u zeker dat u de sanctie van deze persoon wenst te wissen?", "Bevestiging gevraagd", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No) Then
                    Exit Sub
                End If

                Dim selectedId As Integer = UltraGridIntern.ActiveRow.Cells(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                Dim artNbr As String = UltraGridIntern.ActiveRow.Cells(_dataOvertredingExtern.Lijst_Overtredingen.ArtnrColumn.ColumnName).Value

                Dim selectedRow As TDSOvertreding.Lijst_OvertredingenRow = (From infraction In _dataOvertredingIntern.Lijst_Overtredingen.AsEnumerable()
                                                             Where infraction.RegistratieID = selectedId And infraction.Artnr.Equals(artNbr)
                                                             Select infraction).SingleOrDefault()

                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.AfdrukTijdstipColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.AfspraakPBHColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.DatumBriefColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.LastSanctionDoubledYN = False
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.RijverbodVanColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.RijverbodTotColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.SanctieDuurColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.SanctiePeriodeColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.SanctieOmschrijving = String.Empty
                selectedRow.Item(_dataOvertredingIntern.Lijst_Overtredingen.SanctionIdColumn.ColumnName.ToString) = DBNull.Value
                selectedRow.SoortSanctie = String.Empty

                _myProxy.ClearSanction(selectedRow.RegistratieID)

            Else
                MessageBox.Show("Gelieve een correcte rij te selecteren." & Environment.NewLine & " Uw selectie is ongeldig.",
                "Ongeldige selectie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Gelieve een correcte rij te selecteren." & Environment.NewLine & " Uw selectie is ongeldig.",
                            "Ongeldige selectie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    ''' <summary>
    ''' Deze functie voegt een opmerking toe aan een interne overtreding
    ''' </summary>
    ''' <remarks>Juni 2013 Stijn V.</remarks>
    Private Sub ToolStripButtonGiveRemarks_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonGiveRemarks.Click
        If Not (UltraGridIntern.ActiveRow Is Nothing) Then
            If Not (UltraGridIntern.ActiveRow.IsFilterRow()) Then
                Dim selectedId As Integer = UltraGridIntern.ActiveRow.Cells(_dataOvertredingExtern.Lijst_Overtredingen.RegistratieIDColumn.ColumnName).Value
                Dim artNbr As String = UltraGridIntern.ActiveRow.Cells(_dataOvertredingExtern.Lijst_Overtredingen.ArtnrColumn.ColumnName).Value

                Dim selectedRow As TDSOvertreding.Lijst_OvertredingenRow = (From infraction In _dataOvertredingIntern.Lijst_Overtredingen.AsEnumerable()
                                                             Where infraction.RegistratieID = selectedId And infraction.Artnr.Equals(artNbr)
                                                             Select infraction).SingleOrDefault()

                Dim frmRemarks As FormBewakingAddRemarks = New FormBewakingAddRemarks(selectedRow.RegistratieID, selectedRow.Remarks)

                If (frmRemarks.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                    selectedRow.Remarks = frmRemarks.TextBoxRemark.Text.ToString()
                End If

                _dataOvertredingIntern.AcceptChanges()

            Else
                MessageBox.Show("Gelieve een correcte overtreding te selecteren." & Environment.NewLine & " Uw selectie is ongeldig.",
                "Ongeldige overtreding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Gelieve een correcte overtreding te selecteren." & Environment.NewLine & " Uw selectie is ongeldig.",
                            "Ongeldige overtreding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class