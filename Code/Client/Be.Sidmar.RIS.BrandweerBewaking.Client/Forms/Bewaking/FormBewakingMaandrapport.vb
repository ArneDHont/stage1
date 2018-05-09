Imports System.Reflection
Imports System.Windows.Forms

Public Class FormBewakingMaandrapport
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraCalendarComboRegistratieOverzicht As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents ButtonRegistratieOverzicht As System.Windows.Forms.Button
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraCalendarComboMaandoverzichtDagverslag As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents buttonMaandoverzichtDagverslag As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonLijstInbreuken As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraCalendarComboMaandoverzichtDagverslagPers As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents buttonMaandoverzichtDagverslagPers As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDiefstalOverzichtPerTrimester As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Dim DateButton3 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboRegistratieOverzicht = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.ButtonRegistratieOverzicht = New System.Windows.Forms.Button
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboMaandoverzichtDagverslag = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.buttonMaandoverzichtDagverslag = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ButtonLijstInbreuken = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.UltraCalendarComboMaandoverzichtDagverslagPers = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Me.buttonMaandoverzichtDagverslagPers = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ButtonDiefstalOverzichtPerTrimester = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.UltraCalendarComboRegistratieOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraCalendarComboMaandoverzichtDagverslag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.UltraCalendarComboMaandoverzichtDagverslagPers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kies een datum binnen de maand waarvoor je het rapport wil afdrukken."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UltraCalendarComboRegistratieOverzicht)
        Me.GroupBox2.Controls.Add(Me.ButtonRegistratieOverzicht)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox2.TabIndex = 4
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
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraCalendarComboMaandoverzichtDagverslag)
        Me.GroupBox1.Controls.Add(Me.buttonMaandoverzichtDagverslag)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dagverslag inlichtingen"
        '
        'UltraCalendarComboMaandoverzichtDagverslag
        '
        Me.UltraCalendarComboMaandoverzichtDagverslag.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCalendarComboMaandoverzichtDagverslag.DateButtons.Add(DateButton2)
        Me.UltraCalendarComboMaandoverzichtDagverslag.Location = New System.Drawing.Point(160, 40)
        Me.UltraCalendarComboMaandoverzichtDagverslag.Name = "UltraCalendarComboMaandoverzichtDagverslag"
        Me.UltraCalendarComboMaandoverzichtDagverslag.NonAutoSizeHeight = 23
        Me.UltraCalendarComboMaandoverzichtDagverslag.Size = New System.Drawing.Size(112, 21)
        Me.UltraCalendarComboMaandoverzichtDagverslag.TabIndex = 3
        '
        'buttonMaandoverzichtDagverslag
        '
        Me.buttonMaandoverzichtDagverslag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMaandoverzichtDagverslag.Location = New System.Drawing.Point(16, 32)
        Me.buttonMaandoverzichtDagverslag.Name = "buttonMaandoverzichtDagverslag"
        Me.buttonMaandoverzichtDagverslag.Size = New System.Drawing.Size(128, 32)
        Me.buttonMaandoverzichtDagverslag.TabIndex = 0
        Me.buttonMaandoverzichtDagverslag.Text = "Maandoverzicht dagverslag inlichtingen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonLijstInbreuken)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inbreuken op reglement"
        '
        'ButtonLijstInbreuken
        '
        Me.ButtonLijstInbreuken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLijstInbreuken.Location = New System.Drawing.Point(16, 32)
        Me.ButtonLijstInbreuken.Name = "ButtonLijstInbreuken"
        Me.ButtonLijstInbreuken.Size = New System.Drawing.Size(128, 32)
        Me.ButtonLijstInbreuken.TabIndex = 0
        Me.ButtonLijstInbreuken.Text = "Lijst Inbreuken"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UltraCalendarComboMaandoverzichtDagverslagPers)
        Me.GroupBox4.Controls.Add(Me.buttonMaandoverzichtDagverslagPers)
        Me.GroupBox4.Location = New System.Drawing.Point(304, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 80)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dagverslag personeel"
        '
        'UltraCalendarComboMaandoverzichtDagverslagPers
        '
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.DateButtons.Add(DateButton3)
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.Location = New System.Drawing.Point(160, 40)
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.Name = "UltraCalendarComboMaandoverzichtDagverslagPers"
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.NonAutoSizeHeight = 23
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.Size = New System.Drawing.Size(112, 21)
        Me.UltraCalendarComboMaandoverzichtDagverslagPers.TabIndex = 3
        '
        'buttonMaandoverzichtDagverslagPers
        '
        Me.buttonMaandoverzichtDagverslagPers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMaandoverzichtDagverslagPers.Location = New System.Drawing.Point(16, 32)
        Me.buttonMaandoverzichtDagverslagPers.Name = "buttonMaandoverzichtDagverslagPers"
        Me.buttonMaandoverzichtDagverslagPers.Size = New System.Drawing.Size(128, 32)
        Me.buttonMaandoverzichtDagverslagPers.TabIndex = 0
        Me.buttonMaandoverzichtDagverslagPers.Text = "Maandoverzicht dagverslag personeel"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonDiefstalOverzichtPerTrimester)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 72)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Overzicht diefstallen"
        '
        'ButtonDiefstalOverzichtPerTrimester
        '
        Me.ButtonDiefstalOverzichtPerTrimester.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiefstalOverzichtPerTrimester.Location = New System.Drawing.Point(16, 24)
        Me.ButtonDiefstalOverzichtPerTrimester.Name = "ButtonDiefstalOverzichtPerTrimester"
        Me.ButtonDiefstalOverzichtPerTrimester.Size = New System.Drawing.Size(128, 32)
        Me.ButtonDiefstalOverzichtPerTrimester.TabIndex = 1
        Me.ButtonDiefstalOverzichtPerTrimester.Text = "Overzicht per trimester"
        '
        'FormBewakingMaandrapport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 406)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormBewakingMaandrapport"
        Me.Text = "Maandrapport Bewaking"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UltraCalendarComboRegistratieOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraCalendarComboMaandoverzichtDagverslag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.UltraCalendarComboMaandoverzichtDagverslagPers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonMaandoverzichtDagverslag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMaandoverzichtDagverslag.Click
        'Doel: ophalen maandoverzicht dagverslag 
        'Auteur: Siddien - okt. 2006
        Try
            Dim gekozenDatum As DateTime = Me.UltraCalendarComboMaandoverzichtDagverslag.Value
            Me.ShowReport("MaandRapportDagverslagInl", _
                          "Jaar", gekozenDatum.Year, _
                          "Maand", gekozenDatum.Month)



        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - ButtonMaandoverzichtDagverslag_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonRegistratieOverzicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistratieOverzicht.Click
        'Doel:   Laden maandrapport Branden
        'Auteur: Stein - 25/07/06

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
                Me.ShowReport("MaandrapportBewakingOverzicht", _
                              "Maand", maand.ToString, "Jaar", jaar.ToString)
            Else
                MessageBox.Show("Gelieve een datum aan te duiden binnen de maand waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - ButtonRegistratieOverzicht_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ShowReport(ByVal naamRapport As String, _
                        Optional ByVal paramNaam1 As String = "", Optional ByVal paramValue1 As String = "", _
                        Optional ByVal paramNaam2 As String = "", Optional ByVal paramValue2 As String = "", _
                        Optional ByVal paramNaam3 As String = "", Optional ByVal paramValue3 As String = "")
        'Doel: Print preview van maandrapport tonen
        'Auteur: Nancy Coppens - 26/09/2006

        Try
            Dim f_rap As New FormRapportenPreview

            f_rap.Show()

            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                              naamRapport, paramNaam1, paramValue1, paramNaam2, paramValue2, _
                              paramNaam3, paramValue3)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - ShowReport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormBewakingMaandrapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.UltraCalendarComboRegistratieOverzicht.Value = Now

            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - FormBewakingMaandrapport_Load" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ButtonLijstInbreuken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLijstInbreuken.Click
        'Doel: nieuwe form openen met grid met lijst inbreuken op reglemente
        'Auteur: Nancy Coppens - 19/12/2006

        FormManager.Current.openformMaandrapportInbreuken(False, True, True)

    End Sub

    Private Sub buttonMaandoverzichtDagverslagPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMaandoverzichtDagverslagPers.Click
        'Doel: ophalen maandoverzicht dagverslag personeel
        'Auteur: Nancy Coppens - 03/01/2007

        Try
            Dim gekozenDatum As DateTime = Me.UltraCalendarComboMaandoverzichtDagverslagPers.Value
            Me.ShowReport("MaandRapportDagverslagPers", _
                          "Jaar", gekozenDatum.Year, _
                          "Maand", gekozenDatum.Month)



        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - ButtonMaandoverzichtDagverslag_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonDiefstalOverzichtPerTrimester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDiefstalOverzichtPerTrimester.Click
        Try
            'Dim frmDiefstalPerTrimester As FormBewakingTrimesterDiefstal = New FormBewakingTrimesterDiefstal
            FormManager.Current.openformDiefstalPerTrimester(False, True, True)

            'frmDiefstalPerTrimester.Show()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingMaandrapport - ButtonDiefstalOverzichtPerTrimester_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class
