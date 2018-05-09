Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerJaaroverzichtHervuldeBlustoestellen
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
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Report", -1)
            Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Label", -1, Nothing, 1715633882, 0, 0)
            Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AantalSchriftelijk", -1, Nothing, 1715633897, 0, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PercentageSchriftelijk", -1, Nothing, 1715633897, 1, 0)
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AantalTelefonisch", -1, Nothing, 1715633898, 0, 0)
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PercentageTelefonisch", -1, Nothing, 1715633898, 1, 0)
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AantalNietGemeld", -1, Nothing, 1715633899, 0, 0)
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PercentageNietGemeld", -1, Nothing, 1715633899, 1, 0)
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AantalTotaal", -1, Nothing, 1715633900, 0, 0)
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PercentageTotaal", -1, Nothing, 1715633900, 1, 0)
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GroupAfdeling", 1715633882)
            Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GroupSchriftelijk", 1715633897)
            Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GroupTelefonisch", 1715633898)
            Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GroupNietGemeld", 1715633899)
            Dim UltraGridGroup5 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("GroupTotaal", 1715633900)
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Me.LabelTitel1 = New System.Windows.Forms.Label()
            Me.LabelTitel2 = New System.Windows.Forms.Label()
            Me.UltraGridJaarRapport = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerReportHervuldeBlustoestellen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerReportHervuldeBlustoestellen()
            Me.ButtonPrint = New System.Windows.Forms.Button()
            Me.ButtonClose = New System.Windows.Forms.Button()
            Me.UltraPrintPreviewDialogGrid = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraGridPrintDoc = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.ButtonCopy = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.UltraGridJaarRapport, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerReportHervuldeBlustoestellen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LabelTitel1
            '
            Me.LabelTitel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelTitel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelTitel1.Location = New System.Drawing.Point(12, 9)
            Me.LabelTitel1.Name = "LabelTitel1"
            Me.LabelTitel1.Size = New System.Drawing.Size(842, 23)
            Me.LabelTitel1.TabIndex = 0
            Me.LabelTitel1.Text = "Jaarverslag - XXXX"
            Me.LabelTitel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LabelTitel2
            '
            Me.LabelTitel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelTitel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelTitel2.Location = New System.Drawing.Point(12, 32)
            Me.LabelTitel2.Name = "LabelTitel2"
            Me.LabelTitel2.Size = New System.Drawing.Size(842, 23)
            Me.LabelTitel2.TabIndex = 1
            Me.LabelTitel2.Text = "Jaaroverzicht Hervulde Blustoestellen per Afdeling"
            Me.LabelTitel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'UltraGridJaarRapport
            '
            Me.UltraGridJaarRapport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGridJaarRapport.DataMember = "Report"
            Me.UltraGridJaarRapport.DataSource = Me._dataBrandweerReportHervuldeBlustoestellen
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridJaarRapport.DisplayLayout.Appearance = Appearance1
            UltraGridColumn10.Header.Caption = "Afdeling"
            UltraGridColumn10.Width = 168
            Appearance2.TextHAlignAsString = "Right"
            UltraGridColumn11.CellAppearance = Appearance2
            UltraGridColumn11.Header.Caption = "Aantal"
            UltraGridColumn11.Width = 57
            Appearance3.TextHAlignAsString = "Right"
            UltraGridColumn12.CellAppearance = Appearance3
            UltraGridColumn12.Format = "P2"
            UltraGridColumn12.Header.Caption = "%"
            Appearance4.TextHAlignAsString = "Right"
            UltraGridColumn13.CellAppearance = Appearance4
            UltraGridColumn13.Header.Caption = "Aantal"
            Appearance5.TextHAlignAsString = "Right"
            UltraGridColumn14.CellAppearance = Appearance5
            UltraGridColumn14.Format = "P2"
            UltraGridColumn14.Header.Caption = "%"
            Appearance6.TextHAlignAsString = "Right"
            UltraGridColumn15.CellAppearance = Appearance6
            UltraGridColumn15.Header.Caption = "Aantal"
            Appearance7.TextHAlignAsString = "Right"
            UltraGridColumn16.CellAppearance = Appearance7
            UltraGridColumn16.Format = "P2"
            UltraGridColumn16.Header.Caption = "%"
            Appearance8.TextHAlignAsString = "Right"
            UltraGridColumn17.CellAppearance = Appearance8
            UltraGridColumn17.Header.Caption = "Aantal"
            Appearance9.TextHAlignAsString = "Right"
            UltraGridColumn18.CellAppearance = Appearance9
            UltraGridColumn18.Format = "P2"
            UltraGridColumn18.Header.Caption = "%"
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
            UltraGridGroup1.Header.Caption = ""
            UltraGridGroup1.Key = "GroupAfdeling"
            UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
            UltraGridGroup2.Header.Caption = "Schriftelijk Gemeld"
            UltraGridGroup2.Key = "GroupSchriftelijk"
            UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
            UltraGridGroup3.Header.Caption = "Telefonisch Gemeld"
            UltraGridGroup3.Key = "GroupTelefonisch"
            UltraGridGroup3.RowLayoutGroupInfo.LabelSpan = 1
            UltraGridGroup4.Header.Caption = "Niet Gemeld"
            UltraGridGroup4.Key = "GroupNietGemeld"
            UltraGridGroup4.RowLayoutGroupInfo.LabelSpan = 1
            UltraGridGroup5.Header.Caption = "Totaal"
            UltraGridGroup5.Key = "GroupTotaal"
            UltraGridGroup5.RowLayoutGroupInfo.LabelSpan = 1
            UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4, UltraGridGroup5})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridJaarRapport.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridJaarRapport.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridJaarRapport.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridJaarRapport.DisplayLayout.GroupByBox.Appearance = Appearance10
            Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridJaarRapport.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
            Me.UltraGridJaarRapport.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance12.BackColor2 = System.Drawing.SystemColors.Control
            Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridJaarRapport.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
            Me.UltraGridJaarRapport.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridJaarRapport.DisplayLayout.MaxRowScrollRegions = 1
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridJaarRapport.DisplayLayout.Override.ActiveCellAppearance = Appearance13
            Appearance14.BackColor = System.Drawing.SystemColors.Highlight
            Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridJaarRapport.DisplayLayout.Override.ActiveRowAppearance = Appearance14
            Me.UltraGridJaarRapport.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridJaarRapport.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridJaarRapport.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridJaarRapport.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.BasedOnDataType
            Me.UltraGridJaarRapport.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridJaarRapport.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridJaarRapport.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance15.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridJaarRapport.DisplayLayout.Override.CardAreaAppearance = Appearance15
            Appearance16.BorderColor = System.Drawing.Color.Silver
            Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridJaarRapport.DisplayLayout.Override.CellAppearance = Appearance16
            Me.UltraGridJaarRapport.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridJaarRapport.DisplayLayout.Override.CellPadding = 0
            Appearance17.BackColor = System.Drawing.SystemColors.Control
            Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance17.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridJaarRapport.DisplayLayout.Override.GroupByRowAppearance = Appearance17
            Appearance18.TextHAlignAsString = "Left"
            Me.UltraGridJaarRapport.DisplayLayout.Override.HeaderAppearance = Appearance18
            Me.UltraGridJaarRapport.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridJaarRapport.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance19.BackColor = System.Drawing.SystemColors.Window
            Appearance19.BorderColor = System.Drawing.Color.Silver
            Me.UltraGridJaarRapport.DisplayLayout.Override.RowAppearance = Appearance19
            Me.UltraGridJaarRapport.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridJaarRapport.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
            Me.UltraGridJaarRapport.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridJaarRapport.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridJaarRapport.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridJaarRapport.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
            Me.UltraGridJaarRapport.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridJaarRapport.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridJaarRapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridJaarRapport.Location = New System.Drawing.Point(16, 59)
            Me.UltraGridJaarRapport.Name = "UltraGridJaarRapport"
            Me.UltraGridJaarRapport.Size = New System.Drawing.Size(838, 403)
            Me.UltraGridJaarRapport.TabIndex = 2
            Me.UltraGridJaarRapport.Text = "UltraGrid1"
            '
            '_dataBrandweerReportHervuldeBlustoestellen
            '
            Me._dataBrandweerReportHervuldeBlustoestellen.DataSetName = "TDSBrandweerReportHervuldeBlustoestellen"
            Me._dataBrandweerReportHervuldeBlustoestellen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ButtonPrint
            '
            Me.ButtonPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonPrint.Location = New System.Drawing.Point(698, 468)
            Me.ButtonPrint.Name = "ButtonPrint"
            Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
            Me.ButtonPrint.TabIndex = 3
            Me.ButtonPrint.Text = "Print"
            Me.ButtonPrint.UseVisualStyleBackColor = True
            '
            'ButtonClose
            '
            Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonClose.Location = New System.Drawing.Point(779, 468)
            Me.ButtonClose.Name = "ButtonClose"
            Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
            Me.ButtonClose.TabIndex = 4
            Me.ButtonClose.Text = "Close"
            Me.ButtonClose.UseVisualStyleBackColor = True
            '
            'UltraPrintPreviewDialogGrid
            '
            Me.UltraPrintPreviewDialogGrid.Document = Me.UltraGridPrintDoc
            Me.UltraPrintPreviewDialogGrid.Name = "UltraPrintPreviewDialogGrid"
            '
            'UltraGridPrintDoc
            '
            Me.UltraGridPrintDoc.Grid = Me.UltraGridJaarRapport
            '
            'ButtonCopy
            '
            Me.ButtonCopy.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Copy
            Me.ButtonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonCopy.Location = New System.Drawing.Point(16, 12)
            Me.ButtonCopy.Name = "ButtonCopy"
            Me.ButtonCopy.Size = New System.Drawing.Size(61, 23)
            Me.ButtonCopy.TabIndex = 5
            Me.ButtonCopy.Text = "Copy"
            Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.ButtonCopy, "Kopieer grid naar clipboard")
            Me.ButtonCopy.UseVisualStyleBackColor = True
            '
            'FormBrandweerJaaroverzichtHervuldeBlustoestellen
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonClose
            Me.ClientSize = New System.Drawing.Size(866, 503)
            Me.Controls.Add(Me.ButtonCopy)
            Me.Controls.Add(Me.ButtonClose)
            Me.Controls.Add(Me.ButtonPrint)
            Me.Controls.Add(Me.UltraGridJaarRapport)
            Me.Controls.Add(Me.LabelTitel2)
            Me.Controls.Add(Me.LabelTitel1)
            Me.Name = "FormBrandweerJaaroverzichtHervuldeBlustoestellen"
            Me.ShowInTaskbar = False
            Me.Text = "Jaaroverzicht Hervulde Blustoestellen"
            CType(Me.UltraGridJaarRapport, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerReportHervuldeBlustoestellen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LabelTitel1 As System.Windows.Forms.Label
        Friend WithEvents LabelTitel2 As System.Windows.Forms.Label
        Friend WithEvents UltraGridJaarRapport As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents ButtonPrint As System.Windows.Forms.Button
        Friend WithEvents ButtonClose As System.Windows.Forms.Button
        Friend WithEvents _dataBrandweerReportHervuldeBlustoestellen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerReportHervuldeBlustoestellen
        Friend WithEvents UltraPrintPreviewDialogGrid As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraGridPrintDoc As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents ButtonCopy As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    End Class
End Namespace