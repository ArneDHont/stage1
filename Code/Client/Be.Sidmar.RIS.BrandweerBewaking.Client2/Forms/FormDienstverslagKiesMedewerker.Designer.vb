Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDienstverslagKiesMedewerker
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TeamMembers", -1)
            Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_PLG_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
            Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
            Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "NM_IND", 2, True, "TeamMembers", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Me._dataDienstVerslagDetailTeamMembers = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailTeamMembers()
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me.ButtonCancel = New System.Windows.Forms.Button()
            Me.ButtonOk = New System.Windows.Forms.Button()
            CType(Me._dataDienstVerslagDetailTeamMembers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_dataDienstVerslagDetailTeamMembers
            '
            Me._dataDienstVerslagDetailTeamMembers.DataSetName = "TDSDienstVerslagDetailTeamMembers"
            Me._dataDienstVerslagDetailTeamMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraGrid1
            '
            Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGrid1.DataMember = "TeamMembers"
            Me.UltraGrid1.DataSource = Me._dataDienstVerslagDetailTeamMembers
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance13
            Me.UltraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
            UltraGridColumn9.Header.Caption = "Ploeg"
            UltraGridColumn9.Header.VisiblePosition = 3
            UltraGridColumn9.Width = 50
            UltraGridColumn10.Header.VisiblePosition = 0
            UltraGridColumn10.Hidden = True
            UltraGridColumn11.Header.Caption = "Naam"
            UltraGridColumn11.Header.VisiblePosition = 1
            UltraGridColumn11.Width = 100
            UltraGridColumn12.Header.Caption = "Voornaam"
            UltraGridColumn12.Header.VisiblePosition = 2
            UltraGridColumn12.Width = 100
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance3
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance15.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance15
            Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance17.BackColor2 = System.Drawing.SystemColors.Control
            Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance18.BackColor = System.Drawing.SystemColors.Window
            Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance18
            Appearance19.BackColor = System.Drawing.SystemColors.Highlight
            Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance19
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance20.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance20
            Appearance21.BorderColor = System.Drawing.Color.Silver
            Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance21
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance22.BackColor = System.Drawing.SystemColors.Control
            Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance22.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance22
            Appearance23.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance23
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance24.BackColor = System.Drawing.SystemColors.Window
            Appearance24.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance24
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(12, 12)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(328, 420)
            Me.UltraGrid1.TabIndex = 0
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            'ButtonCancel
            '
            Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonCancel.Location = New System.Drawing.Point(265, 438)
            Me.ButtonCancel.Name = "ButtonCancel"
            Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
            Me.ButtonCancel.TabIndex = 1
            Me.ButtonCancel.Text = "Cancel"
            Me.ButtonCancel.UseVisualStyleBackColor = True
            '
            'ButtonOk
            '
            Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOk.Location = New System.Drawing.Point(184, 438)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.ButtonOk.TabIndex = 2
            Me.ButtonOk.Text = "Ok"
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'FormDienstverslagKiesMedewerker
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonCancel
            Me.ClientSize = New System.Drawing.Size(352, 473)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.ButtonCancel)
            Me.Controls.Add(Me.UltraGrid1)
            Me.MinimumSize = New System.Drawing.Size(210, 240)
            Me.Name = "FormDienstverslagKiesMedewerker"
            Me.Text = "Selectie Medewerker"
            CType(Me._dataDienstVerslagDetailTeamMembers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents _dataDienstVerslagDetailTeamMembers As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailTeamMembers
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents ButtonCancel As System.Windows.Forms.Button
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
    End Class
End Namespace