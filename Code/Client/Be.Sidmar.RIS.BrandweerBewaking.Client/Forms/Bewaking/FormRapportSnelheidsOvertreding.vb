Imports System.Configuration


Public Class FormRapportSnelheidsOvertreding

    Private _registratieID As Integer
    Private DocumentPrinted As Boolean

    Public Property RegistrationID() As Integer
        Get
            Return _registratieID
        End Get
        Set(ByVal value As Integer)
            _registratieID = value
        End Set
    End Property

    Private _soDieContactId As Integer
    Public Property SoDieContactID() As Integer
        Get
            Return _soDieContactId
        End Get
        Set(ByVal value As Integer)
            _soDieContactId = value
        End Set
    End Property


    Private Sub FormRapportSnelheidsOvertreding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeDataSetConfig()

        DocumentPrinted = False
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ReportViewerSnelheidsOvertredingen.ServerReport.ReportServerUrl = New Uri(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "UrlReportingServer").WD())
        ReportViewerSnelheidsOvertredingen.ServerReport.ReportPath = _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD() & "/SnelheidsOvertreding"

        Dim paramRegId As New Microsoft.Reporting.WinForms.ReportParameter("id", Me.RegistrationID)

        Dim params As New System.Collections.Generic.List(Of Microsoft.Reporting.WinForms.ReportParameter)

        params.Add(paramRegId)


        ReportViewerSnelheidsOvertredingen.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewerSnelheidsOvertredingen.ServerReport.SetParameters(params)
        ReportViewerSnelheidsOvertredingen.ServerReport.Refresh()

        Me.ReportViewerSnelheidsOvertredingen.RefreshReport()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ReportViewerSnelheidsOvertredingen_Print(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportViewerSnelheidsOvertredingen.Print
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DocumentPrinted = True
        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
        proxy.UpdateSnelheidsovertredingPrint(Me.RegistrationID, DateTime.Now, SoDieContactID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FormRapportSnelheidsOvertreding_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (DocumentPrinted) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
    End Sub


    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
    End Sub
End Class