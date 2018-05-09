Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerZoekVervangmateriaal
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
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BrandweerMateriaal", -1)
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatID")
            Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgNr")
            Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatOmschr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
            Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortTypeMatOmschr")
            Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FabricatieNr")
            Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdelingCode")
            Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieZone")
            Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieNr")
            Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieOmschr")
            Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamLeverancier")
            Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BeheerderAfdelingNaam")
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LeveringsDatum")
            Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VisueleControleFreq")
            Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumVisueleKeuring")
            Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
            Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumPoederControle")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "TypeMatID", 0, True, "BrandweerMateriaal", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Me.ButtonCancel = New System.Windows.Forms.Button()
            Me.ButtonOk = New System.Windows.Forms.Button()
            Me.UltraGridVervangLijst = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerMateriaal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaal()
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            CType(Me.UltraGridVervangLijst, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerMateriaal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ButtonCancel
            '
            Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonCancel.Location = New System.Drawing.Point(1085, 370)
            Me.ButtonCancel.Name = "ButtonCancel"
            Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
            Me.ButtonCancel.TabIndex = 0
            Me.ButtonCancel.Text = "Cancel"
            Me.ButtonCancel.UseVisualStyleBackColor = True
            '
            'ButtonOk
            '
            Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOk.Location = New System.Drawing.Point(1004, 369)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.ButtonOk.TabIndex = 1
            Me.ButtonOk.Text = "Ok"
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'UltraGridVervangLijst
            '
            Me.UltraGridVervangLijst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGridVervangLijst.DataMember = "BrandweerMateriaal"
            Me.UltraGridVervangLijst.DataSource = Me._dataBrandweerMateriaal
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridVervangLijst.DisplayLayout.Appearance = Appearance1
            UltraGridColumn1.Header.VisiblePosition = 0
            UltraGridColumn1.Hidden = True
            UltraGridColumn2.Header.VisiblePosition = 1
            UltraGridColumn2.Hidden = True
            UltraGridColumn3.Header.Caption = "Type Materiaal"
            UltraGridColumn3.Header.VisiblePosition = 2
            UltraGridColumn4.Header.Caption = "Soort Materiaal"
            UltraGridColumn4.Header.VisiblePosition = 3
            UltraGridColumn5.Header.Caption = "Fabricatie Nr"
            UltraGridColumn5.Header.VisiblePosition = 4
            UltraGridColumn6.Header.Caption = "Afdeling"
            UltraGridColumn6.Header.VisiblePosition = 5
            UltraGridColumn7.Header.Caption = "Zone"
            UltraGridColumn7.Header.VisiblePosition = 6
            UltraGridColumn8.Header.Caption = "Nr"
            UltraGridColumn8.Header.VisiblePosition = 7
            UltraGridColumn8.Width = 65
            UltraGridColumn9.Header.Caption = "Locatie Omschrijving"
            UltraGridColumn9.Header.VisiblePosition = 8
            UltraGridColumn9.Width = 206
            UltraGridColumn10.Header.Caption = "Leverancier"
            UltraGridColumn10.Header.VisiblePosition = 9
            UltraGridColumn11.Header.Caption = "Naam Beheerder"
            UltraGridColumn11.Header.VisiblePosition = 10
            UltraGridColumn12.Header.Caption = "Leveringsdatum"
            UltraGridColumn12.Header.VisiblePosition = 11
            UltraGridColumn13.Header.Caption = "Visuele Controle"
            UltraGridColumn13.Header.VisiblePosition = 12
            UltraGridColumn14.Header.Caption = "Datum Visuele Controle"
            UltraGridColumn14.Header.VisiblePosition = 13
            UltraGridColumn15.Header.VisiblePosition = 14
            UltraGridColumn16.Header.VisiblePosition = 15
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance2
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridVervangLijst.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridVervangLijst.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridVervangLijst.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance3.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridVervangLijst.DisplayLayout.GroupByBox.Appearance = Appearance3
            Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridVervangLijst.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
            Me.UltraGridVervangLijst.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance5.BackColor2 = System.Drawing.SystemColors.Control
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridVervangLijst.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
            Me.UltraGridVervangLijst.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridVervangLijst.DisplayLayout.MaxRowScrollRegions = 1
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridVervangLijst.DisplayLayout.Override.ActiveCellAppearance = Appearance6
            Appearance7.BackColor = System.Drawing.SystemColors.Highlight
            Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridVervangLijst.DisplayLayout.Override.ActiveRowAppearance = Appearance7
            Me.UltraGridVervangLijst.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridVervangLijst.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridVervangLijst.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridVervangLijst.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridVervangLijst.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridVervangLijst.DisplayLayout.Override.CardAreaAppearance = Appearance8
            Appearance9.BorderColor = System.Drawing.Color.Silver
            Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridVervangLijst.DisplayLayout.Override.CellAppearance = Appearance9
            Me.UltraGridVervangLijst.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridVervangLijst.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridVervangLijst.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance10.BackColor = System.Drawing.SystemColors.Control
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridVervangLijst.DisplayLayout.Override.GroupByRowAppearance = Appearance10
            Appearance11.TextHAlignAsString = "Left"
            Me.UltraGridVervangLijst.DisplayLayout.Override.HeaderAppearance = Appearance11
            Me.UltraGridVervangLijst.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridVervangLijst.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Appearance12.BorderColor = System.Drawing.Color.Silver
            Me.UltraGridVervangLijst.DisplayLayout.Override.RowAppearance = Appearance12
            Me.UltraGridVervangLijst.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridVervangLijst.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridVervangLijst.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridVervangLijst.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
            Me.UltraGridVervangLijst.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridVervangLijst.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
            Me.UltraGridVervangLijst.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridVervangLijst.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridVervangLijst.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGridVervangLijst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridVervangLijst.Location = New System.Drawing.Point(13, 13)
            Me.UltraGridVervangLijst.Name = "UltraGridVervangLijst"
            Me.UltraGridVervangLijst.Size = New System.Drawing.Size(1147, 350)
            Me.UltraGridVervangLijst.TabIndex = 2
            '
            '_dataBrandweerMateriaal
            '
            Me._dataBrandweerMateriaal.DataSetName = "TDSBrandweerMateriaal"
            Me._dataBrandweerMateriaal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'FormBrandweerZoekVervangmateriaal
            '
            Me.AcceptButton = Me.ButtonOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1172, 405)
            Me.Controls.Add(Me.UltraGridVervangLijst)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.ButtonCancel)
            Me.Name = "FormBrandweerZoekVervangmateriaal"
            Me.ShowInTaskbar = False
            Me.Text = "Zoek Vervangmateriaal"
            CType(Me.UltraGridVervangLijst, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerMateriaal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ButtonCancel As System.Windows.Forms.Button
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
        Friend WithEvents UltraGridVervangLijst As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataBrandweerMateriaal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaal
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
    End Class
End Namespace