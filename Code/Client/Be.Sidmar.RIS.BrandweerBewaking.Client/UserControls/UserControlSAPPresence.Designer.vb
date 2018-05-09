<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSAPPresence
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ZPRESENT", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PERNR")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DATUM")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AWART")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BEGUZ")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ENDUZ")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBoxPresence = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraGridSAPPresence = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataPresenceEmployee = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSPresenceEmployee()
        Me.DateTimePickerPresence = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxPresence.SuspendLayout()
        CType(Me.UltraGridSAPPresence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataPresenceEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxPresence
        '
        Me.GroupBoxPresence.Controls.Add(Me.Label2)
        Me.GroupBoxPresence.Controls.Add(Me.UltraGridSAPPresence)
        Me.GroupBoxPresence.Controls.Add(Me.DateTimePickerPresence)
        Me.GroupBoxPresence.Controls.Add(Me.Label1)
        Me.GroupBoxPresence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPresence.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxPresence.Name = "GroupBoxPresence"
        Me.GroupBoxPresence.Size = New System.Drawing.Size(499, 292)
        Me.GroupBoxPresence.TabIndex = 93
        Me.GroupBoxPresence.TabStop = False
        Me.GroupBoxPresence.Text = "Aanwezigheidsinfo"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "A = aanwezig"
        '
        'UltraGridSAPPresence
        '
        Me.UltraGridSAPPresence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGridSAPPresence.DataMember = "ZPRESENT"
        Me.UltraGridSAPPresence.DataSource = Me._dataPresenceEmployee
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridSAPPresence.DisplayLayout.Appearance = Appearance1
        UltraGridColumn6.Header.Caption = "Stamnr"
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Width = 82
        UltraGridColumn7.Header.Caption = "Datum"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.Header.Caption = "AfwCode"
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Width = 66
        UltraGridColumn9.Header.Caption = "Beginuur"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 84
        UltraGridColumn10.Header.Caption = "Einduur"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 84
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.UltraGridSAPPresence.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridSAPPresence.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridSAPPresence.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridSAPPresence.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridSAPPresence.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridSAPPresence.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridSAPPresence.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridSAPPresence.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridSAPPresence.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridSAPPresence.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridSAPPresence.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridSAPPresence.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridSAPPresence.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridSAPPresence.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridSAPPresence.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridSAPPresence.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridSAPPresence.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridSAPPresence.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridSAPPresence.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridSAPPresence.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridSAPPresence.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridSAPPresence.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraGridSAPPresence.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridSAPPresence.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraGridSAPPresence.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridSAPPresence.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridSAPPresence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSAPPresence.Location = New System.Drawing.Point(6, 42)
        Me.UltraGridSAPPresence.Name = "UltraGridSAPPresence"
        Me.UltraGridSAPPresence.Size = New System.Drawing.Size(487, 244)
        Me.UltraGridSAPPresence.TabIndex = 105
        Me.UltraGridSAPPresence.Text = "UltraGrid1"
        '
        '_dataPresenceEmployee
        '
        Me._dataPresenceEmployee.DataSetName = "TDSPresenceEmployee"
        Me._dataPresenceEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePickerPresence
        '
        Me.DateTimePickerPresence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerPresence.Location = New System.Drawing.Point(59, 16)
        Me.DateTimePickerPresence.Name = "DateTimePickerPresence"
        Me.DateTimePickerPresence.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePickerPresence.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datum:"
        '
        'UserControlSAPPresence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBoxPresence)
        Me.Name = "UserControlSAPPresence"
        Me.Size = New System.Drawing.Size(499, 292)
        Me.GroupBoxPresence.ResumeLayout(False)
        Me.GroupBoxPresence.PerformLayout()
        CType(Me.UltraGridSAPPresence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataPresenceEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPresence As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraGridSAPPresence As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents DateTimePickerPresence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _dataPresenceEmployee As TDSPresenceEmployee

End Class
