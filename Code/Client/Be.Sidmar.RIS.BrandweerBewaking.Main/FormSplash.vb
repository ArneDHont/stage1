Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading

Public Class FormSplash
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents LabelVersion As System.Windows.Forms.Label
    Public WithEvents LabelWelcome As System.Windows.Forms.Label
    Public WithEvents PictureBoxWelcome As System.Windows.Forms.PictureBox
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormSplash))
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.LabelWelcome = New System.Windows.Forms.Label
        Me.PictureBoxWelcome = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'LabelVersion
        '
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelVersion.Location = New System.Drawing.Point(54, 295)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(316, 40)
        Me.LabelVersion.TabIndex = 14
        Me.LabelVersion.Text = "Versie"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelWelcome
        '
        Me.LabelWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelWelcome.Location = New System.Drawing.Point(54, 228)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(316, 56)
        Me.LabelWelcome.TabIndex = 13
        Me.LabelWelcome.Text = "Welkom bij de Brandweer-Bewakingstoepassing"
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxWelcome
        '
        Me.PictureBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxWelcome.Image = CType(resources.GetObject("PictureBoxWelcome.Image"), System.Drawing.Image)
        Me.PictureBoxWelcome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBoxWelcome.Location = New System.Drawing.Point(28, 16)
        Me.PictureBoxWelcome.Name = "PictureBoxWelcome"
        Me.PictureBoxWelcome.Size = New System.Drawing.Size(156, 192)
        Me.PictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxWelcome.TabIndex = 12
        Me.PictureBoxWelcome.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(236, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FormSplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 374)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.PictureBoxWelcome)
        Me.Name = "FormSplash"
        Me.Text = "FormSplash"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Static Methods"
	Private Shared frmSplash As FormSplash

	Public Shared Sub ShowSplashScreen()
		'make sure it's only launched once
		If (Not frmSplash Is Nothing) Then Return

        ShowForm()

        'Dien - migratie 2005 - crossthread problem
        '  Dim myThread As Thread = New Thread(New ThreadStart(AddressOf ShowForm))
        '	myThread.Start()
	End Sub

	Private Shared Sub ShowForm()
		frmSplash = New FormSplash
        'frmSplash.ShowDialog() 'Dien - migratie 2005 - crossthread problem
        frmSplash.Show()
        frmSplash.Refresh()
	End Sub

	Public Shared Sub CloseForm()
		If (frmSplash Is Nothing) Then Return

		frmSplash.Close()
		frmSplash = Nothing
	End Sub 
#End Region

	Private _starttime As DateTime

	Private Sub FormSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		' Center the splash screen background
		Me.Left = CType((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2, Integer)
		Me.Top = CType((Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2, Integer)


		Dim appVersion As String = String.Empty
		Me.LabelVersion.Text = "Versie "
		Try
			appVersion = System.Reflection.Assembly.GetEntryAssembly.FullName.Split(","c)(1).Trim.Replace("Version=", "")
		Catch ex As Exception
			appVersion = "Unknown"
		End Try

		If appVersion.Trim.Length > 0 Then
			Me.LabelVersion.Text += appVersion
		End If

		Me.Text = ""
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ControlBox = False
		Me.FormBorderStyle = FormBorderStyle.None
		Me.Menu = Nothing

		_starttime = DateTime.Now

	End Sub

End Class
