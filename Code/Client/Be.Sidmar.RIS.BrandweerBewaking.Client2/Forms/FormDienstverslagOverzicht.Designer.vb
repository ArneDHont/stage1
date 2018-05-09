Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDienstverslagOverzicht
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
            Me.components = New System.ComponentModel.Container()
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dienstverslag", -1)
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Datum")
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ploeg")
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Verantwoordelijke")
            Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Opmerkingen")
            Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PloegId")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "Datum", 0, True, "Dienstverslag", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCopyClipboard = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonExit = New System.Windows.Forms.ToolStripButton()
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataDienstverslagLijst = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagLijst()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ComboBoxMonths = New System.Windows.Forms.ComboBox()
            Me.BindingSourceMaanden = New System.Windows.Forms.BindingSource(Me.components)
            Me._dataDienstverslagMaanden = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagMaanden()
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.ToolStrip1.SuspendLayout()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataDienstverslagLijst, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BindingSourceMaanden, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataDienstverslagMaanden, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripButtonEdit, Me.ToolStripSeparator1, Me.ToolStripButtonPrint, Me.ToolStripButtonCopyClipboard, Me.ToolStripSeparator2, Me.ToolStripButtonExit})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(806, 25)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButtonNew
            '
            Me.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonNew.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources._New
            Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
            Me.ToolStripButtonNew.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonNew.ToolTipText = "Toevoegen van een dienstverslag"
            '
            'ToolStripButtonEdit
            '
            Me.ToolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonEdit.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Edit
            Me.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonEdit.Name = "ToolStripButtonEdit"
            Me.ToolStripButtonEdit.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonEdit.ToolTipText = "Editeer de geselecteerde informatie"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonPrint
            '
            Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Print
            Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
            Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonPrint.ToolTipText = "Afdrukken van het overzicht"
            '
            'ToolStripButtonCopyClipboard
            '
            Me.ToolStripButtonCopyClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCopyClipboard.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Copy
            Me.ToolStripButtonCopyClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCopyClipboard.Name = "ToolStripButtonCopyClipboard"
            Me.ToolStripButtonCopyClipboard.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCopyClipboard.ToolTipText = "Exporteren naar Excel"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonExit
            '
            Me.ToolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonExit.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Exit2
            Me.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonExit.Name = "ToolStripButtonExit"
            Me.ToolStripButtonExit.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonExit.ToolTipText = "Sluit het overzicht af"
            '
            'UltraGrid1
            '
            Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGrid1.DataMember = "Dienstverslag"
            Me.UltraGrid1.DataSource = Me._dataDienstverslagLijst
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance6
            Me.UltraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
            UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Appearance1.TextHAlignAsString = "Center"
            UltraGridColumn1.CellAppearance = Appearance1
            UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Appearance2.TextHAlignAsString = "Center"
            UltraGridColumn1.Header.Appearance = Appearance2
            UltraGridColumn1.Header.VisiblePosition = 0
            UltraGridColumn1.Width = 100
            UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Appearance3.TextHAlignAsString = "Center"
            UltraGridColumn2.CellAppearance = Appearance3
            UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Appearance4.TextHAlignAsString = "Center"
            UltraGridColumn2.Header.Appearance = Appearance4
            UltraGridColumn2.Header.VisiblePosition = 1
            UltraGridColumn2.Width = 80
            UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn3.Header.VisiblePosition = 2
            UltraGridColumn3.Width = 180
            UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn4.Header.VisiblePosition = 3
            UltraGridColumn4.Width = 400
            UltraGridColumn5.Header.VisiblePosition = 4
            UltraGridColumn5.Hidden = True
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance5
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance12.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance12.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance12
            Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance13
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance14.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance14.BackColor2 = System.Drawing.SystemColors.Control
            Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance14
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance15.BackColor = System.Drawing.SystemColors.Window
            Appearance15.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance15
            Appearance16.BackColor = System.Drawing.SystemColors.Highlight
            Appearance16.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance16
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance17.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance17
            Appearance18.BorderColor = System.Drawing.Color.Silver
            Appearance18.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance18
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance19.BackColor = System.Drawing.SystemColors.Control
            Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance19.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance19.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance19
            Appearance20.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance20
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance21.BackColor = System.Drawing.SystemColors.Window
            Appearance21.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance21
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance22.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance22
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(12, 56)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(782, 222)
            Me.UltraGrid1.TabIndex = 1
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            '_dataDienstverslagLijst
            '
            Me._dataDienstverslagLijst.DataSetName = "TDSDienstverslagLijst"
            Me._dataDienstverslagLijst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(129, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Maand van de Registratie"
            '
            'ComboBoxMonths
            '
            Me.ComboBoxMonths.DataSource = Me.BindingSourceMaanden
            Me.ComboBoxMonths.DisplayMember = "FormattedValue"
            Me.ComboBoxMonths.FormattingEnabled = True
            Me.ComboBoxMonths.Location = New System.Drawing.Point(149, 29)
            Me.ComboBoxMonths.Name = "ComboBoxMonths"
            Me.ComboBoxMonths.Size = New System.Drawing.Size(160, 21)
            Me.ComboBoxMonths.TabIndex = 3
            Me.ComboBoxMonths.ValueMember = "JaarMaand"
            '
            'BindingSourceMaanden
            '
            Me.BindingSourceMaanden.DataMember = "Maanden"
            Me.BindingSourceMaanden.DataSource = Me._dataDienstverslagMaanden
            Me.BindingSourceMaanden.Sort = "JaarMaand desc"
            '
            '_dataDienstverslagMaanden
            '
            Me._dataDienstverslagMaanden.DataSetName = "TDSDienstverslagMaanden"
            Me._dataDienstverslagMaanden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraGridPrintDocument1
            '
            Me.UltraGridPrintDocument1.Grid = Me.UltraGrid1
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraGridPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'FormDienstverslagOverzicht
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(806, 290)
            Me.Controls.Add(Me.ComboBoxMonths)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.UltraGrid1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Name = "FormDienstverslagOverzicht"
            Me.Text = "Overzicht van de Dienstverslagen"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataDienstverslagLijst, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BindingSourceMaanden, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataDienstverslagMaanden, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButtonEdit As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCopyClipboard As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonExit As System.Windows.Forms.ToolStripButton
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ComboBoxMonths As System.Windows.Forms.ComboBox
        Friend WithEvents BindingSourceMaanden As System.Windows.Forms.BindingSource
        Friend WithEvents _dataDienstverslagLijst As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagLijst
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents _dataDienstverslagMaanden As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagMaanden
        Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
    End Class
End Namespace