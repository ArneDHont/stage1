Option Explicit On
Option Infer On
Option Strict On

Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers

Namespace Forms.Bewaking

    Public Class FormRapportSORijverbod

        Private _documentPrinted As Boolean

        ' Public Properties
        ' -----------------
        Public Property RegistrationID() As Integer
        Public Property TijdstipOvertreding() As DateTime
        Public Property Snelheid() As Integer
        Public Property DatumAfspraak() As DateTime
        Public Property DatumStartVerbod() As DateTime
        Public Property DatumStopVerbod() As String
        Public Property GetPostvak() As String
        Public Property SoDieContactID() As Integer

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormRapportSORijverbodLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Using New WaitCursor(Me)

                InitializeDataSetConfig()
                _documentPrinted = False

                ReportViewerSnelheidsOvertredingen.ServerReport.ReportServerUrl = New Uri(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "UrlReportingServer").WD())
                ReportViewerSnelheidsOvertredingen.ServerReport.ReportPath = _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD() & "/SORijverbod"

                'Dim params = New ReportParameter() {New ReportParameter("RegistratieID", RegistrationID.ToString),
                '                                    New ReportParameter("Postbin", GetPostvak.ToString)}

                Dim params = New ReportParameter() {New ReportParameter("RegistratieID", RegistrationID.ToString)}

                ReportViewerSnelheidsOvertredingen.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                ReportViewerSnelheidsOvertredingen.ServerReport.SetParameters(params)
                ReportViewerSnelheidsOvertredingen.ServerReport.Refresh()

                ReportViewerSnelheidsOvertredingen.RefreshReport()
            End Using
        End Sub

        ''' <summary>
        ''' Afdrukken van een brief.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ReportViewerSnelheidsOvertredingenPrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportViewerSnelheidsOvertredingen.Print
            Using New WaitCursor(Me)
                _documentPrinted = True
                Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                proxy.UpdateSnelheidsovertredingPrint(RegistrationID, DateTime.Now, SoDieContactID)
            End Using
        End Sub

        ''' <summary>
        ''' Return the 'printed' status to the caller.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormRapportSORijverbodFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            DialogResult = If(_documentPrinted, DialogResult.OK, DialogResult.Cancel)
        End Sub

        ''' <summary>
        ''' Initialize the dataset.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub InitializeDataSetConfig()
            _dataConfiguratie.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))
        End Sub

    End Class

End Namespace