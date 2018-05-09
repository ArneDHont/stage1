Option Explicit On
Option Strict On
Option Infer On

Imports System.Windows.Forms


Namespace Forms.Brandweer

    Public Class FormBrandweerMaandrapport
        Inherits Form

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
        Friend WithEvents TdsIntvType1 As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents ButtonBranden As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ButtonMilieuDiverse As System.Windows.Forms.Button
        Friend WithEvents UltraCalendarComboBranden As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents UltraCalendarComboMilieuDiverse As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarBrandenPerAfdeling As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonBrandenPerAfdeling As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarDienstverslag As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonDienstverslag As System.Windows.Forms.Button
        Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim DateButton5 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton6 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton7 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton8 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Me.TdsIntvType1 = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.UltraCalendarDienstverslag = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonDienstverslag = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.UltraCalendarBrandenPerAfdeling = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonBrandenPerAfdeling = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UltraCalendarComboMilieuDiverse = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.UltraCalendarComboBranden = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonMilieuDiverse = New System.Windows.Forms.Button()
            Me.ButtonBranden = New System.Windows.Forms.Button()
            Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
            CType(Me.TdsIntvType1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.UltraCalendarDienstverslag, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.UltraCalendarBrandenPerAfdeling, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.UltraCalendarComboMilieuDiverse, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraCalendarComboBranden, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TdsIntvType1
            '
            Me.TdsIntvType1.DataSetName = "TDSIntvType"
            Me.TdsIntvType1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.TdsIntvType1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox4)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(496, 413)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Maandrapporten"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.UltraCalendarDienstverslag)
            Me.GroupBox4.Controls.Add(Me.ButtonDienstverslag)
            Me.GroupBox4.Location = New System.Drawing.Point(8, 302)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(480, 96)
            Me.GroupBox4.TabIndex = 6
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Dienstverslag"
            '
            'UltraCalendarDienstverslag
            '
            Me.UltraCalendarDienstverslag.DateButtons.Add(DateButton5)
            Me.UltraCalendarDienstverslag.Location = New System.Drawing.Point(160, 40)
            Me.UltraCalendarDienstverslag.Name = "UltraCalendarDienstverslag"
            Me.UltraCalendarDienstverslag.NonAutoSizeHeight = 23
            Me.UltraCalendarDienstverslag.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarDienstverslag.TabIndex = 5
            '
            'ButtonDienstverslag
            '
            Me.ButtonDienstverslag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonDienstverslag.Location = New System.Drawing.Point(16, 32)
            Me.ButtonDienstverslag.Name = "ButtonDienstverslag"
            Me.ButtonDienstverslag.Size = New System.Drawing.Size(120, 32)
            Me.ButtonDienstverslag.TabIndex = 4
            Me.ButtonDienstverslag.Text = "Dienstverslag"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.UltraCalendarBrandenPerAfdeling)
            Me.GroupBox3.Controls.Add(Me.ButtonBrandenPerAfdeling)
            Me.GroupBox3.Location = New System.Drawing.Point(8, 200)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(480, 96)
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Administratie"
            '
            'UltraCalendarBrandenPerAfdeling
            '
            Me.UltraCalendarBrandenPerAfdeling.DateButtons.Add(DateButton6)
            Me.UltraCalendarBrandenPerAfdeling.Location = New System.Drawing.Point(160, 40)
            Me.UltraCalendarBrandenPerAfdeling.Name = "UltraCalendarBrandenPerAfdeling"
            Me.UltraCalendarBrandenPerAfdeling.NonAutoSizeHeight = 23
            Me.UltraCalendarBrandenPerAfdeling.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarBrandenPerAfdeling.TabIndex = 5
            '
            'ButtonBrandenPerAfdeling
            '
            Me.ButtonBrandenPerAfdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonBrandenPerAfdeling.Location = New System.Drawing.Point(16, 32)
            Me.ButtonBrandenPerAfdeling.Name = "ButtonBrandenPerAfdeling"
            Me.ButtonBrandenPerAfdeling.Size = New System.Drawing.Size(120, 32)
            Me.ButtonBrandenPerAfdeling.TabIndex = 4
            Me.ButtonBrandenPerAfdeling.Text = "Branden per Afdeling"
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(16, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(448, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Kies een datum binnen de maand waarvoor je het rapport wil afdrukken."
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.UltraCalendarComboMilieuDiverse)
            Me.GroupBox2.Controls.Add(Me.UltraCalendarComboBranden)
            Me.GroupBox2.Controls.Add(Me.ButtonMilieuDiverse)
            Me.GroupBox2.Controls.Add(Me.ButtonBranden)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 64)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(480, 128)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Overzicht interventies"
            '
            'UltraCalendarComboMilieuDiverse
            '
            Me.UltraCalendarComboMilieuDiverse.DateButtons.Add(DateButton7)
            Me.UltraCalendarComboMilieuDiverse.Location = New System.Drawing.Point(160, 88)
            Me.UltraCalendarComboMilieuDiverse.Name = "UltraCalendarComboMilieuDiverse"
            Me.UltraCalendarComboMilieuDiverse.NonAutoSizeHeight = 23
            Me.UltraCalendarComboMilieuDiverse.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarComboMilieuDiverse.TabIndex = 4
            '
            'UltraCalendarComboBranden
            '
            Me.UltraCalendarComboBranden.DateButtons.Add(DateButton8)
            Me.UltraCalendarComboBranden.Location = New System.Drawing.Point(160, 40)
            Me.UltraCalendarComboBranden.Name = "UltraCalendarComboBranden"
            Me.UltraCalendarComboBranden.NonAutoSizeHeight = 23
            Me.UltraCalendarComboBranden.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarComboBranden.TabIndex = 3
            '
            'ButtonMilieuDiverse
            '
            Me.ButtonMilieuDiverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonMilieuDiverse.Location = New System.Drawing.Point(16, 80)
            Me.ButtonMilieuDiverse.Name = "ButtonMilieuDiverse"
            Me.ButtonMilieuDiverse.Size = New System.Drawing.Size(128, 32)
            Me.ButtonMilieuDiverse.TabIndex = 2
            Me.ButtonMilieuDiverse.Text = "Milieu en Diverse"
            '
            'ButtonBranden
            '
            Me.ButtonBranden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonBranden.Location = New System.Drawing.Point(16, 32)
            Me.ButtonBranden.Name = "ButtonBranden"
            Me.ButtonBranden.Size = New System.Drawing.Size(128, 32)
            Me.ButtonBranden.TabIndex = 0
            Me.ButtonBranden.Text = "Branden"
            '
            '_dataConfiguratie
            '
            Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
            Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
            Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'FormBrandweerMaandrapport
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(512, 434)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "FormBrandweerMaandrapport"
            Me.ShowInTaskbar = False
            Me.Text = "Maandrapport Brandweer"
            CType(Me.TdsIntvType1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.UltraCalendarDienstverslag, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.UltraCalendarBrandenPerAfdeling, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.UltraCalendarComboMilieuDiverse, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraCalendarComboBranden, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private _controller As ControllerGetData

        Private Sub FormBrandweerMaandrapportLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Try
                UltraCalendarComboBranden.Value = Now
                UltraCalendarComboMilieuDiverse.Value = Now
                UltraCalendarBrandenPerAfdeling.Value = Now
                UltraCalendarDienstverslag.Value = Now

                _controller = New ControllerGetData
                _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, TDSConfiguratie))

                TdsIntvType1.Merge(_controller.GetInterventieType)
            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking: " & ex.Message, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden maandrapport Branden
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Auteur: Stein - 25/07/06</remarks>
        Private Sub ButtonBrandenClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonBranden.Click

            Try
                If IsDBNull(UltraCalendarComboBranden.Value) Then
                    MessageBox.Show("Gelieve een datum aan te kiezen binnen de maand waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarComboBranden.Value)
                    ShowReport("MaandrapportOverzichtBranden", "Maand", datum.Month.ToString, "Jaar", datum.Year.ToString)
                End If

            Catch ex As Exception
                MessageBox.Show("Fout bij het laden van het maandrapport branden: " & vbCrLf & ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden maandrapport Milieu en Diverse
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Auteur: Stein - 25/07/06</remarks>
        Private Sub ButtonMilieuDiverseClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonMilieuDiverse.Click

            Try
                If IsDBNull(UltraCalendarComboMilieuDiverse.Value) Then
                    MessageBox.Show("Gelieve een datum aan te kiezen binnen de maand waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarComboMilieuDiverse.Value)
                    ShowReport("MaandrapportOverzichtMilieuDivers", "Maand", datum.Month.ToString, "Jaar", datum.Year.ToString)
                End If

            Catch ex As Exception
                MessageBox.Show("Fout bij het laden van het maandrapport milieu - diverse: " & vbCrLf & ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden jaarrapport Branden per Afdeling
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>
        ''' Auteur: Stein - 25/07/06
        ''' Aanpassing: Nancy Coppens - 28/09/2006
        ''' </remarks>
        Private Sub ButtonBrandenPerAfdelingClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonBrandenPerAfdeling.Click

            Try
                If IsDBNull(UltraCalendarBrandenPerAfdeling.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen de maand waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarBrandenPerAfdeling.Value)
                    ShowReport("MaandrapportBrandenPerAfd", "Maand", datum.Month.ToString, "Jaar", datum.Year.ToString)
                End If

            Catch ex As Exception
                MessageBox.Show("Fout bij het laden van het maandrapport/afdeling: " & vbCrLf & ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

        ''' <summary>
        ''' Opstarten van het maandrapport van de dienstverslagen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonDienstverslagClick(sender As Object, e As EventArgs) Handles ButtonDienstverslag.Click

            Try
                If IsDBNull(UltraCalendarDienstverslag.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen de maand waarvan u het rapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarDienstverslag.Value)
                    ShowReport("MaandRapportDienstverslag", "maand", datum.Month.ToString(), "jaar", datum.Year.ToString())
                End If

            Catch ex As Exception
                MessageBox.Show("Fout bij het laden van het maandrapport dienstverslagen: " & vbCrLf & ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

        ''' <summary>
        ''' Doel: Print preview van jaarrapport tonen
        ''' </summary>
        ''' <param name="naamRapport"></param>
        ''' <param name="paramNaam1"></param>
        ''' <param name="paramValue1"></param>
        ''' <param name="paramNaam2"></param>
        ''' <param name="paramValue2"></param>
        ''' <remarks>Auteur: Stein Peeters - 04/07/2006</remarks>
        Private Sub ShowReport(ByVal naamRapport As String,
                               Optional ByVal paramNaam1 As String = "", Optional ByVal paramValue1 As String = "",
                               Optional ByVal paramNaam2 As String = "", Optional ByVal paramValue2 As String = "")

            Try
                Dim rapport As New FormRapportenPreview

                rapport.Show()

                rapport.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                                    naamRapport, paramNaam1, paramValue1, paramNaam2, paramValue2)

            Catch ex As Exception
                MessageBox.Show("Fout bij openen jaarrapport. Contacteer iemand van informatica!", "BMA Brandweer materiaal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

    End Class

End Namespace