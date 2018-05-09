Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerAfdelingMateriaal
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
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("AfdelingMateriaal", -1)
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatID")
            Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatOmschr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
            Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgNr")
            Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortTypeMatOmschr")
            Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdelingCode")
            Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieZone")
            Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieOmschr")
            Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BeheerderAfdelingNaam")
            Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodeMat")
            Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieNr")
            Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VolgnummerAfdeling")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "TypeMatID", 0, True, "AfdelingMateriaal", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerAfdelingMateriaal))
            Me.ToolStripWijzigen = New System.Windows.Forms.ToolStrip()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.LabelCodes = New System.Windows.Forms.Label()
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.ComboBoxAfd = New System.Windows.Forms.ComboBox()
            Me.LabelAfd = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.UltraGridAfdMat = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerAfdelingMateriaal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerAfdelingMateriaal()
            Me.ToolStripButtonWijzigen = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonEditMateriaalvolgnr = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonExit = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripWijzigen.SuspendLayout()
            CType(Me.UltraGridAfdMat, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerAfdelingMateriaal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStripWijzigen
            '
            Me.ToolStripWijzigen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonWijzigen, Me.ToolStripButtonEditMateriaalvolgnr, Me.ToolStripSeparator1, Me.ToolStripButtonPrint, Me.ToolStripButtonCopy, Me.ToolStripSeparator2, Me.ToolStripButtonRefresh, Me.ToolStripButtonExit})
            Me.ToolStripWijzigen.Location = New System.Drawing.Point(0, 0)
            Me.ToolStripWijzigen.Name = "ToolStripWijzigen"
            Me.ToolStripWijzigen.Size = New System.Drawing.Size(1178, 25)
            Me.ToolStripWijzigen.TabIndex = 0
            Me.ToolStripWijzigen.Text = "Wijzigen Beheerder"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'LabelCodes
            '
            Me.LabelCodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelCodes.ForeColor = System.Drawing.SystemColors.InfoText
            Me.LabelCodes.Location = New System.Drawing.Point(13, 383)
            Me.LabelCodes.Name = "LabelCodes"
            Me.LabelCodes.Size = New System.Drawing.Size(1153, 16)
            Me.LabelCodes.TabIndex = 1
            Me.LabelCodes.Text = "Info i.v.m. de Codes"
            Me.LabelCodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraGridPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'UltraGridPrintDocument1
            '
            Me.UltraGridPrintDocument1.Grid = Me.UltraGridAfdMat
            '
            'ComboBoxAfd
            '
            Me.ComboBoxAfd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxAfd.FormattingEnabled = True
            Me.ComboBoxAfd.Items.AddRange(New Object() {"COO", "DD", "DECO", "GHV", "GLT", "HOO", "KBH", "KWA", "LPK", "RBV", "SGL", "STL", "TBG", "WWA"})
            Me.ComboBoxAfd.Location = New System.Drawing.Point(270, 2)
            Me.ComboBoxAfd.Name = "ComboBoxAfd"
            Me.ComboBoxAfd.Size = New System.Drawing.Size(84, 21)
            Me.ComboBoxAfd.TabIndex = 3
            Me.ToolTip1.SetToolTip(Me.ComboBoxAfd, "Aanduiden afdeling en Refresh knop klikken (is enkel voor brandweer)")
            Me.ComboBoxAfd.Visible = False
            '
            'LabelAfd
            '
            Me.LabelAfd.AutoSize = True
            Me.LabelAfd.Location = New System.Drawing.Point(216, 6)
            Me.LabelAfd.Name = "LabelAfd"
            Me.LabelAfd.Size = New System.Drawing.Size(48, 13)
            Me.LabelAfd.TabIndex = 4
            Me.LabelAfd.Text = "Afdeling:"
            Me.LabelAfd.Visible = False
            '
            'UltraGridAfdMat
            '
            Me.UltraGridAfdMat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGridAfdMat.DataMember = "AfdelingMateriaal"
            Me.UltraGridAfdMat.DataSource = Me._dataBrandweerAfdelingMateriaal
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridAfdMat.DisplayLayout.Appearance = Appearance1
            UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn12.Header.VisiblePosition = 0
            UltraGridColumn12.Hidden = True
            UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn13.Header.Caption = "Type"
            UltraGridColumn13.Header.VisiblePosition = 1
            UltraGridColumn13.Width = 150
            UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn14.Header.Caption = "Volgnr"
            UltraGridColumn14.Header.VisiblePosition = 2
            UltraGridColumn14.Hidden = True
            UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn15.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
            UltraGridColumn15.Header.Caption = "Soort"
            UltraGridColumn15.Header.VisiblePosition = 3
            UltraGridColumn15.Width = 171
            UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn16.Header.Caption = "Afdeling"
            UltraGridColumn16.Header.VisiblePosition = 4
            UltraGridColumn16.Width = 74
            UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn17.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
            UltraGridColumn17.Header.Caption = "Zone"
            UltraGridColumn17.Header.VisiblePosition = 5
            UltraGridColumn17.Width = 62
            UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn18.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
            UltraGridColumn18.Header.Caption = "Locatie Omschr"
            UltraGridColumn18.Header.VisiblePosition = 7
            UltraGridColumn18.Width = 454
            UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn19.Header.Caption = "Beheerder"
            UltraGridColumn19.Header.VisiblePosition = 8
            UltraGridColumn19.Width = 95
            UltraGridColumn20.Header.Caption = "Code"
            UltraGridColumn20.Header.VisiblePosition = 9
            UltraGridColumn20.Hidden = True
            UltraGridColumn20.Width = 65
            UltraGridColumn21.Header.VisiblePosition = 6
            UltraGridColumn21.Width = 81
            UltraGridColumn22.Header.VisiblePosition = 10
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
            UltraGridBand1.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance2
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridAfdMat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridAfdMat.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridAfdMat.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance3.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridAfdMat.DisplayLayout.GroupByBox.Appearance = Appearance3
            Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridAfdMat.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
            Me.UltraGridAfdMat.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance5.BackColor2 = System.Drawing.SystemColors.Control
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridAfdMat.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
            Me.UltraGridAfdMat.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridAfdMat.DisplayLayout.MaxRowScrollRegions = 1
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridAfdMat.DisplayLayout.Override.ActiveCellAppearance = Appearance6
            Appearance7.BackColor = System.Drawing.SystemColors.Highlight
            Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridAfdMat.DisplayLayout.Override.ActiveRowAppearance = Appearance7
            Me.UltraGridAfdMat.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridAfdMat.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridAfdMat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridAfdMat.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridAfdMat.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridAfdMat.DisplayLayout.Override.CardAreaAppearance = Appearance8
            Appearance9.BorderColor = System.Drawing.Color.Black
            Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridAfdMat.DisplayLayout.Override.CellAppearance = Appearance9
            Me.UltraGridAfdMat.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridAfdMat.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridAfdMat.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance10.BackColor = System.Drawing.SystemColors.Control
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridAfdMat.DisplayLayout.Override.GroupByRowAppearance = Appearance10
            Appearance11.TextHAlignAsString = "Left"
            Me.UltraGridAfdMat.DisplayLayout.Override.HeaderAppearance = Appearance11
            Me.UltraGridAfdMat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridAfdMat.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance12.BackColor = System.Drawing.SystemColors.Info
            Me.UltraGridAfdMat.DisplayLayout.Override.RowAlternateAppearance = Appearance12
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.BorderColor = System.Drawing.Color.Black
            Me.UltraGridAfdMat.DisplayLayout.Override.RowAppearance = Appearance13
            Me.UltraGridAfdMat.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridAfdMat.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridAfdMat.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridAfdMat.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
            Me.UltraGridAfdMat.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridAfdMat.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
            Me.UltraGridAfdMat.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridAfdMat.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridAfdMat.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGridAfdMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridAfdMat.Location = New System.Drawing.Point(13, 29)
            Me.UltraGridAfdMat.Name = "UltraGridAfdMat"
            Me.UltraGridAfdMat.Size = New System.Drawing.Size(1153, 351)
            Me.UltraGridAfdMat.TabIndex = 2
            Me.UltraGridAfdMat.Text = "UltraGrid1"
            '
            '_dataBrandweerAfdelingMateriaal
            '
            Me._dataBrandweerAfdelingMateriaal.DataSetName = "TDSBrandweerAfdelingMateriaal"
            Me._dataBrandweerAfdelingMateriaal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ToolStripButtonWijzigen
            '
            Me.ToolStripButtonWijzigen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonWijzigen.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Edit
            Me.ToolStripButtonWijzigen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonWijzigen.Name = "ToolStripButtonWijzigen"
            Me.ToolStripButtonWijzigen.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonWijzigen.Text = "Wijzigen"
            Me.ToolStripButtonWijzigen.ToolTipText = "Wijzigen van de Beheerder"
            '
            'ToolStripButtonEditMateriaalvolgnr
            '
            Me.ToolStripButtonEditMateriaalvolgnr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonEditMateriaalvolgnr.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.DailyReport
            Me.ToolStripButtonEditMateriaalvolgnr.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonEditMateriaalvolgnr.Name = "ToolStripButtonEditMateriaalvolgnr"
            Me.ToolStripButtonEditMateriaalvolgnr.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonEditMateriaalvolgnr.ToolTipText = "Wijzig VolgnummerAfdeling"
            '
            'ToolStripButtonPrint
            '
            Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
            Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonPrint.Text = "Print"
            Me.ToolStripButtonPrint.ToolTipText = "Print - Afdrukvoorbeeld"
            '
            'ToolStripButtonCopy
            '
            Me.ToolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCopy.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Copy
            Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
            Me.ToolStripButtonCopy.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCopy.Text = "Copy to Clipboard"
            '
            'ToolStripButtonRefresh
            '
            Me.ToolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonRefresh.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Refresh
            Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
            Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonRefresh.Text = "Refresh"
            Me.ToolStripButtonRefresh.ToolTipText = "Refresh en sorteer op Nr"
            '
            'ToolStripButtonExit
            '
            Me.ToolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonExit.Image = CType(resources.GetObject("ToolStripButtonExit.Image"), System.Drawing.Image)
            Me.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonExit.Name = "ToolStripButtonExit"
            Me.ToolStripButtonExit.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonExit.Text = "ToolStripButton2"
            Me.ToolStripButtonExit.ToolTipText = "Afsluiten Scherm"
            '
            'FormBrandweerAfdelingMateriaal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1178, 408)
            Me.Controls.Add(Me.LabelAfd)
            Me.Controls.Add(Me.ComboBoxAfd)
            Me.Controls.Add(Me.UltraGridAfdMat)
            Me.Controls.Add(Me.LabelCodes)
            Me.Controls.Add(Me.ToolStripWijzigen)
            Me.Name = "FormBrandweerAfdelingMateriaal"
            Me.ShowInTaskbar = False
            Me.Text = "Brandweermateriaal van een Afdeling"
            Me.ToolStripWijzigen.ResumeLayout(False)
            Me.ToolStripWijzigen.PerformLayout()
            CType(Me.UltraGridAfdMat, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerAfdelingMateriaal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStripWijzigen As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButtonWijzigen As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
        Friend WithEvents LabelCodes As System.Windows.Forms.Label
        Friend WithEvents UltraGridAfdMat As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataBrandweerAfdelingMateriaal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerAfdelingMateriaal
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonExit As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ComboBoxAfd As System.Windows.Forms.ComboBox
        Friend WithEvents LabelAfd As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents ToolStripButtonEditMateriaalvolgnr As System.Windows.Forms.ToolStripButton
    End Class
End Namespace