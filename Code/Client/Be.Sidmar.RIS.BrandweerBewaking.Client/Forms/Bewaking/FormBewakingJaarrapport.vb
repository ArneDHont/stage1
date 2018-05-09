Imports System.Reflection
Imports System.Windows.Forms

Public Class FormBewakingJaarrapport
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraCalendarComboRegistratieOverzicht As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents ButtonRegistratieOverzicht As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonJaaroverzichtDagverslagPers As System.Windows.Forms.Button
    Friend WithEvents buttonJaaroverzichtDagverslag As System.Windows.Forms.Button
    Friend WithEvents UltraCalendarComboJaaroverzichtDagverslagPers As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents UltraCalendarComboJaaroverzichtDagverslag As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton3 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboRegistratieOverzicht = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.ButtonRegistratieOverzicht = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboJaaroverzichtDagverslagPers = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.buttonJaaroverzichtDagverslagPers = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboJaaroverzichtDagverslag = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.buttonJaaroverzichtDagverslag = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.UltraCalendarComboRegistratieOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.UltraCalendarComboJaaroverzichtDagverslagPers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraCalendarComboJaaroverzichtDagverslag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UltraCalendarComboRegistratieOverzicht)
        Me.GroupBox2.Controls.Add(Me.ButtonRegistratieOverzicht)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Overzicht registraties"
        '
        'UltraCalendarComboRegistratieOverzicht
        '
        Me.UltraCalendarComboRegistratieOverzicht.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCalendarComboRegistratieOverzicht.DateButtons.Add(DateButton1)
        Me.UltraCalendarComboRegistratieOverzicht.Location = New System.Drawing.Point(160, 40)
        Me.UltraCalendarComboRegistratieOverzicht.Name = "UltraCalendarComboRegistratieOverzicht"
        Me.UltraCalendarComboRegistratieOverzicht.NonAutoSizeHeight = 23
        Me.UltraCalendarComboRegistratieOverzicht.Size = New System.Drawing.Size(112, 21)
        Me.UltraCalendarComboRegistratieOverzicht.TabIndex = 3
        '
        'ButtonRegistratieOverzicht
        '
        Me.ButtonRegistratieOverzicht.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistratieOverzicht.Location = New System.Drawing.Point(16, 32)
        Me.ButtonRegistratieOverzicht.Name = "ButtonRegistratieOverzicht"
        Me.ButtonRegistratieOverzicht.Size = New System.Drawing.Size(128, 32)
        Me.ButtonRegistratieOverzicht.TabIndex = 0
        Me.ButtonRegistratieOverzicht.Text = "Registratie overzicht"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kies een datum binnen het jaar waarvoor je het rapport wil afdrukken."
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UltraCalendarComboJaaroverzichtDagverslagPers)
        Me.GroupBox4.Controls.Add(Me.buttonJaaroverzichtDagverslagPers)
        Me.GroupBox4.Location = New System.Drawing.Point(304, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 81)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dagverslag personeel"
        '
        'UltraCalendarComboJaaroverzichtDagverslagPers
        '
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.DateButtons.Add(DateButton2)
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.Location = New System.Drawing.Point(160, 40)
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.Name = "UltraCalendarComboJaaroverzichtDagverslagPers"
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.NonAutoSizeHeight = 23
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.Size = New System.Drawing.Size(112, 21)
        Me.UltraCalendarComboJaaroverzichtDagverslagPers.TabIndex = 3
        '
        'buttonJaaroverzichtDagverslagPers
        '
        Me.buttonJaaroverzichtDagverslagPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonJaaroverzichtDagverslagPers.Location = New System.Drawing.Point(16, 32)
        Me.buttonJaaroverzichtDagverslagPers.Name = "buttonJaaroverzichtDagverslagPers"
        Me.buttonJaaroverzichtDagverslagPers.Size = New System.Drawing.Size(128, 32)
        Me.buttonJaaroverzichtDagverslagPers.TabIndex = 0
        Me.buttonJaaroverzichtDagverslagPers.Text = "Jaaroverzicht dagverslag personeel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraCalendarComboJaaroverzichtDagverslag)
        Me.GroupBox1.Controls.Add(Me.buttonJaaroverzichtDagverslag)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dagverslag inlichtingen"
        '
        'UltraCalendarComboJaaroverzichtDagverslag
        '
        Me.UltraCalendarComboJaaroverzichtDagverslag.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCalendarComboJaaroverzichtDagverslag.DateButtons.Add(DateButton3)
        Me.UltraCalendarComboJaaroverzichtDagverslag.Location = New System.Drawing.Point(160, 40)
        Me.UltraCalendarComboJaaroverzichtDagverslag.Name = "UltraCalendarComboJaaroverzichtDagverslag"
        Me.UltraCalendarComboJaaroverzichtDagverslag.NonAutoSizeHeight = 23
        Me.UltraCalendarComboJaaroverzichtDagverslag.Size = New System.Drawing.Size(112, 21)
        Me.UltraCalendarComboJaaroverzichtDagverslag.TabIndex = 3
        '
        'buttonJaaroverzichtDagverslag
        '
        Me.buttonJaaroverzichtDagverslag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonJaaroverzichtDagverslag.Location = New System.Drawing.Point(16, 32)
        Me.buttonJaaroverzichtDagverslag.Name = "buttonJaaroverzichtDagverslag"
        Me.buttonJaaroverzichtDagverslag.Size = New System.Drawing.Size(128, 32)
        Me.buttonJaaroverzichtDagverslag.TabIndex = 0
        Me.buttonJaaroverzichtDagverslag.Text = "Jaaroverzicht dagverslag inlichtingen"
        '
        'FormBewakingJaarrapport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 230)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormBewakingJaarrapport"
        Me.Text = "Jaarrapport Bewaking"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UltraCalendarComboRegistratieOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.UltraCalendarComboJaaroverzichtDagverslagPers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraCalendarComboJaaroverzichtDagverslag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonRegistratieOverzicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistratieOverzicht.Click
        'Doel:   Laden jaarrapport overzicht bewaking registraties
        'Auteur: Nancy Coppens - 28/09/2006

        Try
            Dim jaar As Integer = 0
            Dim maand As Integer = 0

            Dim s() As String = Me.UltraCalendarComboRegistratieOverzicht.Text.Split("/"c)

            'maand bepalen
            If Not s(1).Equals("") Then
                maand = s(1)
            End If

            'jaar bepalen
            If Not s(2).Equals("") Then
                jaar = s(2)
            End If

            'als jaar werd ingevuld
            If Not maand.Equals(0) AndAlso Not jaar.Equals(0) Then
                Me.ShowReport("JaarrapportBewakingOverzicht", _
                              "Jaar", jaar.ToString)
            Else
                MessageBox.Show("Gelieve een datum aan te duiden binnen het jaar waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingJaarrapport - ButtonRegistratieOverzicht_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ShowReport(ByVal naamRapport As String, _
                        Optional ByVal paramNaam1 As String = "", Optional ByVal paramValue1 As String = "", _
                        Optional ByVal paramNaam2 As String = "", Optional ByVal paramValue2 As String = "")
        'Doel: Print preview van jaarrapport tonen
        'Auteur: Nancy Coppens - 26/09/2006

        Try
            Dim f_rap As New FormRapportenPreview

            f_rap.Show()

            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                              naamRapport, paramNaam1, paramValue1, paramNaam2, paramValue2)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingJaarrapport - ShowReport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormBewakingJaarrapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.UltraCalendarComboRegistratieOverzicht.Value = Now

            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingJaarrapport - FormBewakingJaarrapport_Load" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub buttonJaaroverzichtDagverslag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonJaaroverzichtDagverslag.Click
        'Doel:   Laden jaarrapport overzicht dagverslag inlichtingen
        'Auteur: Mieke Duynslager - 29/05/2007

        Try
            Dim jaar As Integer = 0
            Dim maand As Integer = 0

            Dim s() As String = Me.UltraCalendarComboJaaroverzichtDagverslag.Text.Split("/"c)

            'maand bepalen
            If Not s(1).Equals("") Then
                maand = s(1)
            End If

            'jaar bepalen
            If Not s(2).Equals("") Then
                jaar = s(2)
            End If

            'als jaar werd ingevuld
            If Not maand.Equals(0) AndAlso Not jaar.Equals(0) Then
                Me.ShowReport("JaarRapportDagverslagInl", _
                              "Jaar", jaar.ToString)
            Else
                MessageBox.Show("Gelieve een datum aan te duiden binnen het jaar waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingJaarrapport - buttonJaaroverzichtDagverslag_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub buttonJaaroverzichtDagverslagPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonJaaroverzichtDagverslagPers.Click
        'Doel:   Laden jaarrapport overzicht dagverslag personeel
        'Auteur: Mieke Duynslager - 29/05/2007

        Try
            Dim jaar As Integer = 0
            Dim maand As Integer = 0

            Dim s() As String = Me.UltraCalendarComboJaaroverzichtDagverslagPers.Text.Split("/"c)

            'maand bepalen
            If Not s(1).Equals("") Then
                maand = s(1)
            End If

            'jaar bepalen
            If Not s(2).Equals("") Then
                jaar = s(2)
            End If

            'als jaar werd ingevuld
            If Not maand.Equals(0) AndAlso Not jaar.Equals(0) Then
                Me.ShowReport("JaarRapportDagverslagPers", _
                              "Jaar", jaar.ToString)
            Else
                MessageBox.Show("Gelieve een datum aan te duiden binnen het jaar waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingJaarrapport - buttonJaaroverzichtDagverslagPers_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
