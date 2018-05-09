Option Explicit On
Option Infer On
Option Strict On

Imports System.Linq


Public Class HRSServiceManagementWSProxy
    Inherits HRSService.HRMData.Services

    '_user = ADF.Presentation.Windows.ApplicationSecurity.SecurityManager.CurrentSecurityManager.GetUserID()
    'OR using System.Environment.UserName
    Private _user As String = System.Environment.UserName

    Protected Overrides Function GetWebRequest(ByVal uri As System.Uri) As System.Net.WebRequest
        Dim wr As System.Net.WebRequest
        Dim language As String
        wr = MyBase.GetWebRequest(uri)
        language = Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        wr.Headers.Add("Accept-Language", language)
        wr.Headers.Add("UserName", _user)

        'Siddien - nov 2006 - domain account meegeven (windows Auth.)
        wr.Credentials = System.Net.CredentialCache.DefaultCredentials
        Return wr
    End Function
End Class

Class HRSServiceManagementProxy
    Inherits ADF.RemoteServices.WebServiceProxyBase

    Private _webService As HRSServiceManagementWSProxy

    Public Sub New()
        MyBase.New()
        Me.LogicalName = "HRSService.HRMData"
        _webService = New HRSServiceManagementWSProxy

        'weglaten
        '17/11/2006 - nee, zeker niet weglaten, want anders werkt de code niet op QA en PROD,
        'de code werkt dan enkel lokaal goed (localhost)!!!
        'sidnaco - Eric Uittenhove
        _webService.Url = Me.Url
    End Sub

    Public Overridable ReadOnly Property WebService As HRSServiceManagementWSProxy
        Get
            Return _webService
        End Get
    End Property

End Class

Public Class HRSServiceManagementServicesProxy

    Private myProxy As HRSServiceManagementProxy

    Public Sub New()
        MyBase.New()
        myProxy = New HRSServiceManagementProxy
    End Sub

    Public Function GetPostVak(ByVal pPersonalId As String) As String
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Dim returnTds As HRSService.HRMData.TDSdspers = New HRSService.HRMData.TDSdspers
                returnTds.Merge(myProxy.WebService.GetPersonDetail(pPersonalId))

                If returnTds.DSPERS.Rows.Count > 0 Then
                    Return returnTds.DSPERS(0).VLG_INT_COD_PO
                End If
                Return String.Empty
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetEMailChef(ByVal stamnr As Integer) As String

        Dim data = myProxy.WebService.GetDirectChefs(stamnr.ToString)

        If data IsNot Nothing AndAlso data.Tables.Count > 0 Then
            For Each row As DataRow In data.Tables(0).Rows
                If CInt(row("VOLGNRCHEF")) = 1 Then
                    Return CStr(row("EMAL"))
                End If
            Next
        End If

        Return ""
    End Function

End Class