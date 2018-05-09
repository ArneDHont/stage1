Public Class FormDagverslagInlichtingen
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
    Friend WithEvents LabelRubriek As System.Windows.Forms.Label
    Friend WithEvents UltraCombo1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelDatumRegistratie As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAlgemeen As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxAlgemeen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxAantalPost1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TextBoxPost2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPost4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDagverslagInlichtingen))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.LabelRubriek = New System.Windows.Forms.Label
        Me.UltraCombo1 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelDatumRegistratie = New System.Windows.Forms.Label
        Me.GroupBoxAlgemeen = New System.Windows.Forms.GroupBox
        Me.TextBoxAlgemeen = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBoxPost4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxPost2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxAantalPost1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelRubriek
        '
        Me.LabelRubriek.AutoSize = True
        Me.LabelRubriek.Location = New System.Drawing.Point(8, 40)
        Me.LabelRubriek.Name = "LabelRubriek"
        Me.LabelRubriek.Size = New System.Drawing.Size(46, 16)
        Me.LabelRubriek.TabIndex = 31
        Me.LabelRubriek.Text = "Rubriek:"
        '
        'UltraCombo1
        '
        Me.UltraCombo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraCombo1.DisplayLayout.Appearance = Appearance1
        Me.UltraCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraCombo1.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraCombo1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraCombo1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraCombo1.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraCombo1.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraCombo1.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraCombo1.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraCombo1.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraCombo1.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraCombo1.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraCombo1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraCombo1.DisplayMember = ""
        Me.UltraCombo1.Location = New System.Drawing.Point(104, 40)
        Me.UltraCombo1.Name = "UltraCombo1"
        Me.UltraCombo1.Size = New System.Drawing.Size(376, 21)
        Me.UltraCombo1.TabIndex = 1
        Me.UltraCombo1.ValueMember = ""
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(312, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "default today"
        '
        'LabelDatumRegistratie
        '
        Me.LabelDatumRegistratie.AutoSize = True
        Me.LabelDatumRegistratie.Location = New System.Drawing.Point(8, 8)
        Me.LabelDatumRegistratie.Name = "LabelDatumRegistratie"
        Me.LabelDatumRegistratie.Size = New System.Drawing.Size(94, 16)
        Me.LabelDatumRegistratie.TabIndex = 27
        Me.LabelDatumRegistratie.Text = "Datum registratie:"
        '
        'GroupBoxAlgemeen
        '
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxAlgemeen)
        Me.GroupBoxAlgemeen.Controls.Add(Me.Label2)
        Me.GroupBoxAlgemeen.Location = New System.Drawing.Point(104, 72)
        Me.GroupBoxAlgemeen.Name = "GroupBoxAlgemeen"
        Me.GroupBoxAlgemeen.Size = New System.Drawing.Size(128, 56)
        Me.GroupBoxAlgemeen.TabIndex = 34
        Me.GroupBoxAlgemeen.TabStop = False
        Me.GroupBoxAlgemeen.Text = "Aantal"
        '
        'TextBoxAlgemeen
        '
        Me.TextBoxAlgemeen.Location = New System.Drawing.Point(64, 24)
        Me.TextBoxAlgemeen.Name = "TextBoxAlgemeen"
        Me.TextBoxAlgemeen.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAlgemeen.TabIndex = 1
        Me.TextBoxAlgemeen.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Algemeen:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPost4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxPost2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxAantalPost1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(248, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 56)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aantal per post"
        '
        'TextBoxPost4
        '
        Me.TextBoxPost4.Location = New System.Drawing.Point(184, 24)
        Me.TextBoxPost4.Name = "TextBoxPost4"
        Me.TextBoxPost4.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxPost4.TabIndex = 5
        Me.TextBoxPost4.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "P4:"
        '
        'TextBoxPost2
        '
        Me.TextBoxPost2.Location = New System.Drawing.Point(104, 24)
        Me.TextBoxPost2.Name = "TextBoxPost2"
        Me.TextBoxPost2.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxPost2.TabIndex = 3
        Me.TextBoxPost2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "P2:"
        '
        'TextBoxAantalPost1
        '
        Me.TextBoxAantalPost1.Location = New System.Drawing.Point(32, 24)
        Me.TextBoxAantalPost1.Name = "TextBoxAantalPost1"
        Me.TextBoxAantalPost1.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxAantalPost1.TabIndex = 1
        Me.TextBoxAantalPost1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "P1:"
        '
        'UltraButtonAnnuleer
        '
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance13
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(280, 144)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 3
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance14
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(392, 144)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 2
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(104, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        'Me.UltraDateTimeEditorDatum.SupportThemes = False 'Dien - aug2008 - migratie 2008
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.False
        Me.UltraDateTimeEditorDatum.TabIndex = 0
        '
        'FormDagverslagInlichtingen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 206)
        Me.Controls.Add(Me.UltraDateTimeEditorDatum)
        Me.Controls.Add(Me.GroupBoxAlgemeen)
        Me.Controls.Add(Me.LabelRubriek)
        Me.Controls.Add(Me.LabelDatumRegistratie)
        Me.Controls.Add(Me.UltraCombo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UltraButtonOpslaan)
        Me.Controls.Add(Me.UltraButtonAnnuleer)
        Me.Name = "FormDagverslagInlichtingen"
        Me.Text = "Dagverslag inlichtingen"
        CType(Me.UltraCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeen.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
