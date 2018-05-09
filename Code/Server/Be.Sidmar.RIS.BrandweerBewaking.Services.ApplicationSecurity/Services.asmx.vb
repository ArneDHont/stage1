Imports System.Web.Services
Imports System.Reflection
Imports ADF.ExceptionHandling

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
Public Class Services
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' WEB SERVICE EXAMPLE
    ' The HelloWorld() example service returns the string Hello World.
    ' To build, uncomment the following lines then save and build the project.
    ' To test this web service, ensure that the .asmx file is the start page
    ' and press F5.
    '

    <WebMethod()> _
        Public Function HelloWorld() As String

        Try
            Return "Hello"
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try

    End Function

    <WebMethod()> _
    Public Function GetApplicationSecurity(ByVal user As String) As ADF.Security.ApplicationSecurity.TDSApplicationSecurity

        Try
            Dim bsSecurity As New ADF.Security.ApplicationSecurity.Services
            Return bsSecurity.GetApplicationSecurity(user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try

    End Function


End Class