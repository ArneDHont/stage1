Imports Be.Sidmar


Class BBWServiceDocumentumWSProxy
    Inherits BBWService.Documentum.BBWServices
    
    'TODO: initialize _user using SecurityManager
    '_user = ADF.Presentation.Windows.ApplicationSecurity.SecurityManager.CurrentSecurityManager.GetUserID()
    'OR using System.Environment.UserName
    Private _user As String
    
    Protected Overrides Function GetWebRequest(ByVal uri As System.Uri) As System.Net.WebRequest
        Dim wr As System.Net.WebRequest
        Dim language As String
        wr = MyBase.GetWebRequest(uri)
        language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        wr.Headers.Add("Accept-Language", language)
        wr.Headers.Add("UserName", _user)
        Return wr
    End Function
End Class


Class BBWServiceDocumentumProxy
    Inherits ADF.RemoteServices.WebServiceProxyBase
    
    Private _webService As BBWServiceDocumentumWSProxy
    
    Public Sub New()
        MyBase.New
        Me.LogicalName = "BBWServiceDocumentum"
        _webService = New BBWServiceDocumentumWSProxy
        _webService.Url = Me.Url
    End Sub
    
    Public Overridable ReadOnly Property WebService As BBWServiceDocumentumWSProxy
        Get
            Return _webService
        End Get
    End Property
End Class


Public Class BBWServiceDocumentumServicesProxy
    
    Private myProxy As BBWServiceDocumentumProxy
    
    Public Sub New()
        MyBase.New
        myProxy = New BBWServiceDocumentumProxy
    End Sub
    
    Public Function ImportDocumentDirect(ByVal objectName As String, ByVal content() As Byte, ByVal contentType As String, ByVal folderPath As String, ByVal userName As String, ByVal title As String, ByVal language As String) As String
        Dim firstTry As Boolean = true
        
        Do While ((myProxy.Finished = false)  _
                    OrElse firstTry)
            Try 
                firstTry = false
                Return myProxy.WebService.ImportDocumentDirect(objectName, content, contentType, folderPath, userName, title, language)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
            
        Loop
        Return Nothing
    End Function
    
    Public Sub DeleteDocument(ByVal chronicleId As String, ByVal userName As String)
        Dim firstTry As Boolean = true
        
        Do While ((myProxy.Finished = false)  _
                    OrElse firstTry)
            Try 
                firstTry = false
                myProxy.WebService.DeleteDocument(chronicleId, userName)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
            
        Loop
    End Sub
    
    Public Function GetContent(ByVal chronicleId As String, ByVal userName As String, ByRef fileName As System.String) As Byte()
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetContent(chronicleId, userName, fileName)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return nothing 'Dien - aug2008 - migratie 2008
    End Function

    Public Function CreateNewVersion(ByVal chronicleId As String, ByVal content() As Byte, ByVal userName As String) As String
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.CreateNewVersion(chronicleId, content, userName)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie 2008
    End Function
End Class
