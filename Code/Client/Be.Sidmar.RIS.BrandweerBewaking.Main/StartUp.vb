Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports ADF.ExceptionHandling
Imports ADF.Presentation.Windows.ApplicationSecurity


Public Class StartUp
    Inherits ApplicationContext

    Private _tracer As ADF.Diagnostics.TextFileTracer
    Private _beginTime As DateTime

    Private _userLoggedOn As Boolean = False
    Private _userName As String = ""

    Public Sub New()
		MyBase.New()

		InitializeStartUp()
	End Sub

	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		MyBase.Dispose(disposing)
	End Sub

	''' <summary>
	''' The main entry point for the application
	''' </summary>
	<STAThread()> _
	Shared Sub Main()
		Application.Run(New StartUp)
	End Sub

	Private Sub InitializeStartUp()
		Try
            FormSplash.ShowSplashScreen()



			_beginTime = DateTime.Now
            ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Start van de toepassing ")
			AddHandler Application.ThreadException, AddressOf OnThreadException
			AddHandler Application.ApplicationExit, AddressOf OnApplicationExit

            ''Lawrence Verbruggen - 17/03/2011
            ''If directory c:\_DATA\bbw\ does not exists, create directory
            'Dim di As New System.IO.DirectoryInfo("c:\_DATA\bbw\")

            'If (Not di.Exists) Then
            '    di.Create()
            'End If




			LogOn()

            'Dien - aug2008 - migratie VS2005
            'Dim t As New Thread(New ThreadStart(AddressOf InitializeWebServices))
            't.Priority = ThreadPriority.Lowest
            't.Start()

            LoadMainForm()



			FormSplash.CloseForm()
		Catch ex As Exception
			FormSplash.CloseForm()
			ExceptionManager.Publish(ex)
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub LogOn()
        Try
#If USE_SECURITY Then
            SecurityManager.CurrentSecurityManager.LoadData(System.Environment.UserName)
            _userName = SecurityManager.CurrentSecurityManager.GetUserId()
            _userLoggedOn = True
#Else
            _userName = System.Environment.UserName
            _userLoggedOn = True
#End If

            'Usersettings
            ADF.Configuration.ConfigurationSettings.UserSettingsManager.CurrentUserSettingsManager.ReadSettings(_userName)

        Catch ex As Exception
#If USE_SECURITY Then
            SecurityManager.CurrentSecurityManager.ClearData()

            '--------------------------------------------------------------
            _userName = System.Environment.UserName 'naco - 20/12/2016
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            Dim UserDepartementId As Integer
            Dim UserDepartementId2 As Integer
            Dim UserDepartementId3 As Integer

            UserDepartementId = proxy.GetAfdelingVoorGebruiker(_userName)
            UserDepartementId2 = proxy.GetAfdelingVoorGebruiker2(_userName)
            UserDepartementId3 = proxy.GetAfdelingVoorGebruiker3(_userName)

            If UserDepartementId < 1 Then Throw
            'DepartementalUserLoggedOn = True
            '--------------------------------------------------------------


#End If
        End Try
	End Sub

	Private Sub InitializeWebServices()
		'add code here to initialize any web services

		'example:
		'Dim AdministrationProxy As IAdministrationServicesProxy
        'AdministrationProxy = CType(ADF.Activator.CreateInstance(GetType(IAdministrationServicesProxy)), IAdministrationServicesProxy)
		'AdministrationProxy.IsActive()
	End Sub

	Private Sub LoadMainForm()
        ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Start laden mainform en infragistics")

		Dim frm As New FormMainMDI
		AddHandler frm.Closed, AddressOf StopApplication

		frm.WindowState = FormWindowState.Maximized
		frm.UserName = _userName
        frm.UserLoggedOn = _userLoggedOn


        'naco - 22/12/2016 - als een afdelinguser inlogt, onmiddellijk het materiaalscherm tonen van die afdeling
        'anders moet de user nog eens inloggen
        '---
        Dim UserDepartementId As Integer
        Dim UserDepartementId2 As Integer
        Dim UserDepartementId3 As Integer
        frm.DepartementalUserLoggedOn = True

        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
        UserDepartementId = proxy.GetAfdelingVoorGebruiker(_userName)
        UserDepartementId2 = proxy.GetAfdelingVoorGebruiker2(_userName)
        UserDepartementId3 = proxy.GetAfdelingVoorGebruiker3(_userName)

        If UserDepartementId > 1 Then
            frm.DepartementalUserLoggedOn = True
            frm.UserDepartementId = UserDepartementId
            frm.UserDepartementId2 = UserDepartementId2
            frm.UserDepartementId3 = UserDepartementId3
        End If
        '---

        'Voor scherm te tonen, individuen ophalen
        frm.LoadIndividuen()
        frm.LoadConfigurationSettings()


		frm.Show()
		frm.Activate()

        ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Mainform geladen")
	End Sub


	Private Sub StopApplication(ByVal sender As Object, ByVal e As EventArgs)
        ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Stop toepassing")

		ExitThread()
	End Sub


	Private Sub OnApplicationExit(ByVal sender As Object, ByVal e As EventArgs)
        ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Einde van de toepassing ")
        ADF.Diagnostics.TextFileTracer.Write(Now.ToShortDateString & " " & Now.ToLongTimeString & " " & "Gebruikstijd = " & DateTime.Now.Subtract(_beginTime).ToString)
		'End
	End Sub

	Private Sub OnThreadException(ByVal sender As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
		'In case of an unhandled exception
		ExceptionManager.Publish(e.Exception)
		MessageBox.Show(e.Exception.Message)
    End Sub
End Class
