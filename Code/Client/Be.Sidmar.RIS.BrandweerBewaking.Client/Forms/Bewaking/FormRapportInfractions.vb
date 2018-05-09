Option Explicit On
Option Infer On
Option Strict On

Imports System.Collections.Generic
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy


Public Class FormRapportInfractions

    Private myProxy As HRSServiceManagementServicesProxy

    Private Property IsIntern As Boolean
    Private Property Is1Week As Boolean

    Public Property RegistrationID As Integer
    Public Property PersonalId As Integer
    Public Property SanctionDuration As String
    Public Property SanctionPeriod As String

    ''' <summary>
    ''' Public Constructor.
    ''' </summary>
    ''' <param name="intern"></param>
    ''' <param name="oneWeek"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal intern As Boolean, ByVal oneWeek As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        IsIntern = intern
        Is1Week = oneWeek

        SanctionDuration = String.Empty
        SanctionPeriod = String.Empty
    End Sub

    ''' <summary>
    ''' Load the report.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormRapportInfractions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Using New WaitCursor(Me)

            _dataConfiguratie.Merge(DirectCast(FormManager.Current.DataConfiguration, TDSConfiguratie))

            myProxy = New HRSServiceManagementServicesProxy

            ReportViewerInfractions.ServerReport.ReportServerUrl = New Uri(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "UrlReportingServer").WD())
            ReportViewerInfractions.ServerReport.ReportPath = _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD()

            Dim postVak As String = String.Empty
            If IsIntern Then
                postVak = myProxy.GetPostVak(PersonalId.ToString)
                If Is1Week Then
                    ' GMae, 2014-06-16: Tijdelijk komt enkel dit rapport vanaf de nieuwe server.
                    ReportViewerInfractions.ServerReport.ReportServerUrl = New Uri(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "UrlReportingServer2008").WD())
                    ReportViewerInfractions.ServerReport.ReportPath &= "/InbreukVerkeersreglement_1_week"
                Else
                    ReportViewerInfractions.ServerReport.ReportPath &= "/InbreukVerkeersreglement"
                End If
            Else
                ReportViewerInfractions.ServerReport.ReportPath &= "/InbreukVerkeersreglementExtern"
            End If

            Dim params As New List(Of ReportParameter)
            params.Add(New ReportParameter("RegistratieID", RegistrationID.ToString))
            If IsIntern Then
                If Not (SanctionDuration.Equals(String.Empty)) Then
                    params.Add(New ReportParameter("SanctionDuration", SanctionDuration))
                    params.Add(New ReportParameter("SanctionPeriod", SanctionPeriod))
                Else
                    params.Add(New ReportParameter("SanctionDuration", String.Empty))
                    params.Add(New ReportParameter("SanctionPeriod", String.Empty))
                End If
            End If

            If Not (postVak.Equals(String.Empty)) Then
                params.Add(New ReportParameter("Postbin", postVak))
            End If

            ReportViewerInfractions.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewerInfractions.ServerReport.SetParameters(params)
            ReportViewerInfractions.ServerReport.Refresh()

            ReportViewerInfractions.RefreshReport()
        End Using
    End Sub

    ''' <summary>
    ''' Save a copy of the report as a PDF file.
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <remarks></remarks>
    Public Sub SaveAsPdf(ByVal fileName As String)

        ' Maak de folder aan, indien nodig
        ' --------------------------------
        Dim folder = Path.GetDirectoryName(fileName)
        If Not String.IsNullOrWhiteSpace(folder) Then Directory.CreateDirectory(folder)

        ' Kuis eventuele oude rommel op
        ' -----------------------------
        File.Delete(fileName)

        ' Genereer de PDF als een byte stream
        ' -----------------------------------
        Dim streams = New String() {}
        Dim warnings = New Warning() {}
        Dim bytes = ReportViewerInfractions.ServerReport.Render("PDF", Nothing, "", "", "", streams, warnings)

        ' Schrijf de byte stream in de file
        ' ---------------------------------
        Using oFilestream = New FileStream(fileName, FileMode.CreateNew)
            oFilestream.Write(bytes, 0, bytes.Length)
        End Using
    End Sub

End Class