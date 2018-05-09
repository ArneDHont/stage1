Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaalFiche
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerMateriaalFiche))
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("MateriaalActie", -1)
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieId")
            Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatId")
            Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgnr")
            Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Datum")
            Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieCodeId")
            Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieOmschr")
            Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gewicht")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "Datum", 3, True, "MateriaalActie", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButtonNieuw = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonCancel = New System.Windows.Forms.ToolStripButton()
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerMateriaalActie = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerMateriaalActie()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerMateriaalActie, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNieuw, Me.ToolStripButtonEdit, Me.ToolStripButtonDelete, Me.ToolStripSeparator1, Me.ToolStripButtonPrint, Me.ToolStripButtonCopy, Me.ToolStripSeparator2, Me.ToolStripButtonCancel})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(443, 25)
            Me.ToolStrip1.TabIndex = 2
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButtonNieuw
            '
            Me.ToolStripButtonNieuw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonNieuw.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._New
            Me.ToolStripButtonNieuw.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonNieuw.Name = "ToolStripButtonNieuw"
            Me.ToolStripButtonNieuw.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonNieuw.Text = "ToolStripButton1"
            Me.ToolStripButtonNieuw.ToolTipText = "Toevoegen van een actie"
            '
            'ToolStripButtonEdit
            '
            Me.ToolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonEdit.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Edit
            Me.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonEdit.Name = "ToolStripButtonEdit"
            Me.ToolStripButtonEdit.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonEdit.Text = "ToolStripButton2"
            Me.ToolStripButtonEdit.ToolTipText = "Wijzigen van de geselecteerde actie"
            '
            'ToolStripButtonDelete
            '
            Me.ToolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonDelete.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Trashcan
            Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
            Me.ToolStripButtonDelete.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonDelete.Text = "ToolStripButton3"
            Me.ToolStripButtonDelete.ToolTipText = "Shrap de geselecteerde actie"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonPrint
            '
            Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
            Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonPrint.Text = "ToolStripButton1"
            Me.ToolStripButtonPrint.ToolTipText = "Afdrukken van het overzicht"
            '
            'ToolStripButtonCopy
            '
            Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCopy.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Copy
            Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
            Me.ToolStripButtonCopy.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCopy.Text = "ToolStripButton2"
            Me.ToolStripButtonCopy.ToolTipText = "Exporteer de informatie naar het clipboard"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonCancel
            '
            Me.ToolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCancel.Image = CType(resources.GetObject("ToolStripButtonCancel.Image"), System.Drawing.Image)
            Me.ToolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCancel.Name = "ToolStripButtonCancel"
            Me.ToolStripButtonCancel.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCancel.Text = "ToolStripButton5"
            Me.ToolStripButtonCancel.ToolTipText = "Afsluiten van de materiaalfiche"
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraGridPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'UltraGridPrintDocument1
            '
            Me.UltraGridPrintDocument1.Grid = Me.UltraGrid1
            '
            'UltraGrid1
            '
            Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGrid1.DataMember = "MateriaalActie"
            Me.UltraGrid1.DataSource = Me._dataBrandweerMateriaalActie
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
            UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn1.Header.VisiblePosition = 0
            UltraGridColumn1.Hidden = True
            UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn2.Header.VisiblePosition = 1
            UltraGridColumn2.Hidden = True
            UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn3.Header.VisiblePosition = 2
            UltraGridColumn3.Hidden = True
            UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn4.Header.VisiblePosition = 3
            UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn5.Header.VisiblePosition = 4
            UltraGridColumn5.Hidden = True
            UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn6.Header.Caption = "Uitgevoerde Actie"
            UltraGridColumn6.Header.VisiblePosition = 5
            UltraGridColumn6.Width = 200
            UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn7.Header.Caption = "Gewicht (kg)"
            UltraGridColumn7.Header.VisiblePosition = 6
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance2
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance3.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance3
            Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance5.BackColor2 = System.Drawing.SystemColors.Control
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance6
            Appearance7.BackColor = System.Drawing.SystemColors.Highlight
            Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance7
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance8
            Appearance9.BorderColor = System.Drawing.Color.Silver
            Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance9
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance10.BackColor = System.Drawing.SystemColors.Control
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance10
            Appearance11.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance11
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Appearance12.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance12
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(12, 29)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(419, 422)
            Me.UltraGrid1.TabIndex = 3
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            '_dataBrandweerMateriaalActie
            '
            Me._dataBrandweerMateriaalActie.DataSetName = "TDSBrandweerMateriaalActie"
            Me._dataBrandweerMateriaalActie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'FormBrandweerMateriaalFiche
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(443, 463)
            Me.Controls.Add(Me.UltraGrid1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBrandweerMateriaalFiche"
            Me.Text = "Materiaal Fiche - acties"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerMateriaalActie, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents _dataBrandweerMateriaalActie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerMateriaalActie
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents ToolStripButtonNieuw As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonEdit As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonDelete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonCancel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    End Class
End Namespace