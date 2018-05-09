Option Explicit On
Option Strict On
Option Infer On

Imports System.Windows.Forms


Namespace Forms.Brandweer

    Public Class FormBrandweerJaarrapport
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
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarBrandenPerAfdeling As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonBrandenPerAfdeling As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarComboInterventies As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonAard As System.Windows.Forms.Button
        Friend WithEvents ButtonOorzaken As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarComboGeblustDoor As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonGeblustDoor As System.Windows.Forms.Button
        Friend WithEvents LabelInterventietype As System.Windows.Forms.Label
        Friend WithEvents UltraComboEditorInterventieTypes As Infragistics.Win.UltraWinEditors.UltraComboEditor
        Friend WithEvents _dataInterventieTypesTDS As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents NumericUpDownJaartal As System.Windows.Forms.NumericUpDown
        Friend WithEvents ButtonHervuldPerType As System.Windows.Forms.Button
        Friend WithEvents ButtonHervuldPerAfdeling As System.Windows.Forms.Button
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraCalendarDienstverslag As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ButtonDienstverslag As System.Windows.Forms.Button
        Friend WithEvents UltraOptionSetRapportType As Infragistics.Win.UltraWinEditors.UltraOptionSet
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
            Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
            Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
            Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton3 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton4 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.NumericUpDownJaartal = New System.Windows.Forms.NumericUpDown()
            Me.ButtonHervuldPerType = New System.Windows.Forms.Button()
            Me.ButtonHervuldPerAfdeling = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.UltraOptionSetRapportType = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
            Me.UltraCalendarBrandenPerAfdeling = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonBrandenPerAfdeling = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.UltraComboEditorInterventieTypes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
            Me._dataInterventieTypesTDS = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType()
            Me.LabelInterventietype = New System.Windows.Forms.Label()
            Me.UltraCalendarComboInterventies = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonAard = New System.Windows.Forms.Button()
            Me.ButtonOorzaken = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.UltraCalendarComboGeblustDoor = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonGeblustDoor = New System.Windows.Forms.Button()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.UltraCalendarDienstverslag = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ButtonDienstverslag = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            CType(Me.NumericUpDownJaartal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.UltraOptionSetRapportType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraCalendarBrandenPerAfdeling, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.UltraComboEditorInterventieTypes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataInterventieTypesTDS, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraCalendarComboInterventies, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            CType(Me.UltraCalendarComboGeblustDoor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox6.SuspendLayout()
            CType(Me.UltraCalendarDienstverslag, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox6)
            Me.GroupBox1.Controls.Add(Me.GroupBox5)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.GroupBox4)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(488, 635)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Jaarrapporten"
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.NumericUpDownJaartal)
            Me.GroupBox5.Controls.Add(Me.ButtonHervuldPerType)
            Me.GroupBox5.Controls.Add(Me.ButtonHervuldPerAfdeling)
            Me.GroupBox5.Location = New System.Drawing.Point(8, 418)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(472, 118)
            Me.GroupBox5.TabIndex = 7
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Jaaroverzicht Hervulde Blustoestellen"
            '
            'NumericUpDownJaartal
            '
            Me.NumericUpDownJaartal.Location = New System.Drawing.Point(160, 42)
            Me.NumericUpDownJaartal.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
            Me.NumericUpDownJaartal.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
            Me.NumericUpDownJaartal.Name = "NumericUpDownJaartal"
            Me.NumericUpDownJaartal.Size = New System.Drawing.Size(80, 20)
            Me.NumericUpDownJaartal.TabIndex = 5
            Me.NumericUpDownJaartal.Value = New Decimal(New Integer() {1990, 0, 0, 0})
            '
            'ButtonHervuldPerType
            '
            Me.ButtonHervuldPerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonHervuldPerType.Location = New System.Drawing.Point(16, 69)
            Me.ButtonHervuldPerType.Name = "ButtonHervuldPerType"
            Me.ButtonHervuldPerType.Size = New System.Drawing.Size(120, 32)
            Me.ButtonHervuldPerType.TabIndex = 4
            Me.ButtonHervuldPerType.Text = "Per Type"
            '
            'ButtonHervuldPerAfdeling
            '
            Me.ButtonHervuldPerAfdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonHervuldPerAfdeling.Location = New System.Drawing.Point(16, 31)
            Me.ButtonHervuldPerAfdeling.Name = "ButtonHervuldPerAfdeling"
            Me.ButtonHervuldPerAfdeling.Size = New System.Drawing.Size(120, 32)
            Me.ButtonHervuldPerAfdeling.TabIndex = 4
            Me.ButtonHervuldPerAfdeling.Text = "Per Afdeling"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.UltraOptionSetRapportType)
            Me.GroupBox3.Controls.Add(Me.UltraCalendarBrandenPerAfdeling)
            Me.GroupBox3.Controls.Add(Me.ButtonBrandenPerAfdeling)
            Me.GroupBox3.Location = New System.Drawing.Point(8, 284)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(472, 128)
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Administratie"
            '
            'UltraOptionSetRapportType
            '
            Me.UltraOptionSetRapportType.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
            Me.UltraOptionSetRapportType.CheckedIndex = 0
            ValueListItem1.DataValue = "1"
            ValueListItem1.DisplayText = "Per aard"
            ValueListItem2.DataValue = "2"
            ValueListItem2.DisplayText = "Per oorzaak"
            ValueListItem3.DataValue = "3"
            ValueListItem3.DisplayText = "Per aard/oorzaak"
            Me.UltraOptionSetRapportType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
            Me.UltraOptionSetRapportType.ItemSpacingVertical = 3
            Me.UltraOptionSetRapportType.Location = New System.Drawing.Point(160, 64)
            Me.UltraOptionSetRapportType.Name = "UltraOptionSetRapportType"
            Me.UltraOptionSetRapportType.Size = New System.Drawing.Size(160, 56)
            Me.UltraOptionSetRapportType.TabIndex = 6
            Me.UltraOptionSetRapportType.Text = "Per aard"
            Me.UltraOptionSetRapportType.TextIndentation = 5
            '
            'UltraCalendarBrandenPerAfdeling
            '
            Me.UltraCalendarBrandenPerAfdeling.DateButtons.Add(DateButton2)
            Me.UltraCalendarBrandenPerAfdeling.Location = New System.Drawing.Point(160, 32)
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
            Me.Label1.Location = New System.Drawing.Point(16, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(448, 16)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Kies een datum binnen het jaar waarvoor je het rapport wil afdrukken."
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.UltraComboEditorInterventieTypes)
            Me.GroupBox2.Controls.Add(Me.LabelInterventietype)
            Me.GroupBox2.Controls.Add(Me.UltraCalendarComboInterventies)
            Me.GroupBox2.Controls.Add(Me.ButtonAard)
            Me.GroupBox2.Controls.Add(Me.ButtonOorzaken)
            Me.GroupBox2.Location = New System.Drawing.Point(8, 150)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(472, 128)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Interventies"
            '
            'UltraComboEditorInterventieTypes
            '
            Me.UltraComboEditorInterventieTypes.DataMember = "BBINTVTY"
            Me.UltraComboEditorInterventieTypes.DataSource = Me._dataInterventieTypesTDS
            Me.UltraComboEditorInterventieTypes.DisplayMember = "SCF_TY_INTV"
            Me.UltraComboEditorInterventieTypes.Location = New System.Drawing.Point(160, 88)
            Me.UltraComboEditorInterventieTypes.Name = "UltraComboEditorInterventieTypes"
            Me.UltraComboEditorInterventieTypes.Size = New System.Drawing.Size(144, 21)
            Me.UltraComboEditorInterventieTypes.TabIndex = 5
            Me.UltraComboEditorInterventieTypes.ValueMember = "ID_TY_INTV"
            '
            '_dataInterventieTypesTDS
            '
            Me._dataInterventieTypesTDS.DataSetName = "_dataInterventieTypesTDS"
            Me._dataInterventieTypesTDS.Locale = New System.Globalization.CultureInfo("en-US")
            Me._dataInterventieTypesTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'LabelInterventietype
            '
            Me.LabelInterventietype.Location = New System.Drawing.Point(160, 72)
            Me.LabelInterventietype.Name = "LabelInterventietype"
            Me.LabelInterventietype.Size = New System.Drawing.Size(80, 16)
            Me.LabelInterventietype.TabIndex = 4
            Me.LabelInterventietype.Text = "Interventietype"
            '
            'UltraCalendarComboInterventies
            '
            Me.UltraCalendarComboInterventies.DateButtons.Add(DateButton3)
            Me.UltraCalendarComboInterventies.Location = New System.Drawing.Point(160, 32)
            Me.UltraCalendarComboInterventies.Name = "UltraCalendarComboInterventies"
            Me.UltraCalendarComboInterventies.NonAutoSizeHeight = 23
            Me.UltraCalendarComboInterventies.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarComboInterventies.TabIndex = 3
            '
            'ButtonAard
            '
            Me.ButtonAard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAard.Location = New System.Drawing.Point(16, 80)
            Me.ButtonAard.Name = "ButtonAard"
            Me.ButtonAard.Size = New System.Drawing.Size(120, 32)
            Me.ButtonAard.TabIndex = 2
            Me.ButtonAard.Text = "Aard"
            '
            'ButtonOorzaken
            '
            Me.ButtonOorzaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonOorzaken.Location = New System.Drawing.Point(16, 32)
            Me.ButtonOorzaken.Name = "ButtonOorzaken"
            Me.ButtonOorzaken.Size = New System.Drawing.Size(120, 32)
            Me.ButtonOorzaken.TabIndex = 0
            Me.ButtonOorzaken.Text = "Oorzaken"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.UltraCalendarComboGeblustDoor)
            Me.GroupBox4.Controls.Add(Me.ButtonGeblustDoor)
            Me.GroupBox4.Location = New System.Drawing.Point(8, 64)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(472, 80)
            Me.GroupBox4.TabIndex = 6
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Ontleding branden"
            '
            'UltraCalendarComboGeblustDoor
            '
            Me.UltraCalendarComboGeblustDoor.DateButtons.Add(DateButton4)
            Me.UltraCalendarComboGeblustDoor.Location = New System.Drawing.Point(160, 40)
            Me.UltraCalendarComboGeblustDoor.Name = "UltraCalendarComboGeblustDoor"
            Me.UltraCalendarComboGeblustDoor.NonAutoSizeHeight = 23
            Me.UltraCalendarComboGeblustDoor.Size = New System.Drawing.Size(112, 21)
            Me.UltraCalendarComboGeblustDoor.TabIndex = 5
            '
            'ButtonGeblustDoor
            '
            Me.ButtonGeblustDoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonGeblustDoor.Location = New System.Drawing.Point(16, 32)
            Me.ButtonGeblustDoor.Name = "ButtonGeblustDoor"
            Me.ButtonGeblustDoor.Size = New System.Drawing.Size(120, 32)
            Me.ButtonGeblustDoor.TabIndex = 4
            Me.ButtonGeblustDoor.Text = "Geblust door"
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.UltraCalendarDienstverslag)
            Me.GroupBox6.Controls.Add(Me.ButtonDienstverslag)
            Me.GroupBox6.Location = New System.Drawing.Point(8, 542)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(472, 80)
            Me.GroupBox6.TabIndex = 8
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Dienstverslag"
            '
            'UltraCalendarDienstverslag
            '
            Me.UltraCalendarDienstverslag.DateButtons.Add(DateButton1)
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
            'FormBrandweerJaarrapport
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(504, 654)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "FormBrandweerJaarrapport"
            Me.ShowInTaskbar = False
            Me.Text = "Jaarrapport Brandweer"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox5.ResumeLayout(False)
            CType(Me.NumericUpDownJaartal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.UltraOptionSetRapportType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraCalendarBrandenPerAfdeling, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.UltraComboEditorInterventieTypes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataInterventieTypesTDS, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraCalendarComboInterventies, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.UltraCalendarComboGeblustDoor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            CType(Me.UltraCalendarDienstverslag, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private _controller As ControllerGetData

        ''' <summary>
        ''' Doel:
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Auteur: Stein Peeters - juli 2007 (vakantiejob)</remarks>
        Private Sub FormBrandweerJaarrapportLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Try
                UltraCalendarBrandenPerAfdeling.Value = Now
                UltraCalendarComboGeblustDoor.Value = Now
                UltraCalendarComboInterventies.Value = Now
                UltraCalendarDienstverslag.Value = Now

                _controller = New ControllerGetData

                _dataInterventieTypesTDS.Merge(_controller.GetInterventieType)
                UltraComboEditorInterventieTypes.SelectedIndex = 0

                NumericUpDownJaartal.Value = DateTime.Now.Year

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                "Form: FormBrandweerJaarrapport - FormBrandweerJaarrapport_Load" & vbCrLf & _
                                "Message: " & ex.Message & vbCrLf & _
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        Private Sub ShowReport(ByVal naamRapport As String, Optional ByVal paramNaam1 As String = "", Optional ByVal paramValue1 As String = "", Optional ByVal paramNaam2 As String = "", Optional ByVal paramValue2 As String = "")

            Try
                Dim fRap As New FormRapportenPreview

                fRap.Show()

                fRap.ToonRapport("/GENT/PLANT/PEB/BBW", naamRapport, paramNaam1, paramValue1, paramNaam2, paramValue2)

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                "Form: FormBrandweerJaarrapport - ShowReport" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden jaarrapport Geblust door
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Auteur: Stein - 27/07/06</remarks>
        Private Sub ButtonGeblustDoorClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonGeblustDoor.Click

            Try
                If IsDBNull(UltraCalendarComboGeblustDoor.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen het jaar waarvan u het jaarrapport wilt bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarComboGeblustDoor.Value)
                    ShowReport("JaarrapportGeblustDoor", "Jaartal", datum.Year.ToString)
                End If

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                "Form: FormBrandweerJaarrapport - ButtonGeblustDoor_Click" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden jaarrapport oorzaken interventies
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>
        ''' Auteur: Stein - 27/07/06
        ''' Aanpassing: Nancy Coppens - 28/09/2006
        ''' </remarks>
        Private Sub ButtonOorzakenClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonOorzaken.Click

            Try
                If UltraComboEditorInterventieTypes.Value Is Nothing Then
                    MessageBox.Show("Gelieve een interventietype te kiezen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf IsDBNull(UltraCalendarComboInterventies.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen het jaar waarvan u het jaarrapport wil bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    Dim datum = CDate(UltraCalendarComboInterventies.Value)
                    ShowReport("JaarrapportInterventieOorzaken", "Jaartal", datum.Year.ToString, "InterventieTypeID", CStr(UltraComboEditorInterventieTypes.Value))
                End If

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                "Form: FormBrandweerJaarrapport - ButtonOorzaken_Click" & vbCrLf & _
                                "Message: " & ex.Message & vbCrLf & _
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden jaarrapport aarden interventies
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>
        ''' Auteur: Stein - 27/07/06
        ''' Aanpassing: Nancy Coppens - 28/09/2006
        ''' </remarks>
        Private Sub ButtonAardClick(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAard.Click

            Try
                If UltraComboEditorInterventieTypes.Value Is Nothing Then
                    MessageBox.Show("Gelieve een interventietype te kiezen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf IsDBNull(UltraCalendarComboInterventies.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen het jaar waarvan u het jaarrapport wil bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    Dim datum = CDate(UltraCalendarComboInterventies.Value)
                    ShowReport("JaarrapportInterventieAarden", "Jaartal", datum.Year.ToString, "InterventieTypeID", CStr(UltraComboEditorInterventieTypes.Value))
                End If

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                "Form: FormBrandweerJaarrapport - ButtonAard_Click" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Doel:   Laden jaarrapport per afdeling (afhankelijk van geselecteerd type rapport)
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>
        ''' Auteur: Stein - 27/07/06
        ''' Aanpassing: Nancy Coppens - 28/09/2006
        ''' </remarks>
        Private Sub ButtonBrandenPerAfdelingClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonBrandenPerAfdeling.Click

            Try
                'interventieType bepalen
                If UltraOptionSetRapportType.CheckedItem Is Nothing OrElse
                   UltraOptionSetRapportType.CheckedItem Is DBNull.Value Then
                    MessageBox.Show("Gelieve een interventietype te kiezen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf IsDBNull(UltraCalendarComboInterventies.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen het jaar waarvan u het jaarrapport wil bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    Dim datum = CDate(UltraCalendarComboInterventies.Value)
                    Select Case CInt(UltraOptionSetRapportType.Value)
                        Case 1
                            ShowReport("JaarrapportBrandenPerAfdAard", "Jaar", datum.Year.ToString)
                        Case 2
                            ShowReport("JaarrapportBrandenPerAfdOorzaak", "Jaar", datum.Year.ToString)
                        Case Else
                            ShowReport("JaarrapportBrandenPerAfdAardOorzaak", "Jaar", datum.Year.ToString)
                    End Select
                End If

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                "Form: FormBrandweerJaarrapport - ButtonBrandenPerAfdelingClick" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonHervuldPerAfdelingClick(sender As Object, e As EventArgs) Handles ButtonHervuldPerAfdeling.Click
            Using f As New FormBrandweerJaaroverzichtHervuldeBlustoestellen
                f.Initialize(NumericUpDownJaartal.Value, True)
                f.ShowDialog(Me)
            End Using
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonHervuldPerTypeClick(sender As Object, e As EventArgs) Handles ButtonHervuldPerType.Click
            Using f As New FormBrandweerJaaroverzichtHervuldeBlustoestellen
                f.Initialize(NumericUpDownJaartal.Value, False)
                f.ShowDialog(Me)
            End Using
        End Sub

        ''' <summary>
        ''' Opstarten van het jaarrapport van de dienstverslagen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonDienstverslagClick(sender As Object, e As EventArgs) Handles ButtonDienstverslag.Click

            Try
                If IsDBNull(UltraCalendarDienstverslag.Value) Then
                    MessageBox.Show("Gelieve een datum te kiezen binnen het jaar waarvan u het jaarrapport wil bezichtigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim datum = CDate(UltraCalendarDienstverslag.Value)
                    ShowReport("JaarRapportDienstverslag", "jaar", datum.Year.ToString())
                End If

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                "Form: FormBrandweerJaarrapport - ButtonDienstverslagClick" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

    End Class

End Namespace