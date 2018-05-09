Option Explicit On
Option Infer On
Option Strict On

Imports Microsoft.Reporting.WinForms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers

Namespace Forms.Bewaking

    Public Class FormRapportSnelheidPrintExt

        ' Public Properties
        ' -----------------
        Public Property RegistrationID() As Integer

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormRapportSnelheidPrintExtLoad(sender As System.Object, e As EventArgs) Handles MyBase.Load

            Using New WaitCursor(Me)

                _dataConfiguratie.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))

                ReportViewer1.ServerReport.ReportServerUrl = New Uri(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "UrlReportingServer").WD())
                ReportViewer1.ServerReport.ReportPath = _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD() & "/BriefSnelheidsovertredingExternen"

                Dim params = New ReportParameter() {New ReportParameter("id", RegistrationID.ToString)}

                ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                ReportViewer1.ServerReport.SetParameters(params)
                ReportViewer1.ServerReport.Refresh()

                ReportViewer1.RefreshReport()
            End Using
        End Sub
    End Class

End Namespace
