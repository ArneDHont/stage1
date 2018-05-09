<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateFirmaBBW
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBFRM", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STRA_FRM")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_PLA_FRM")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_IND_FRM_SAP")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_SAP")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactPersonMail_FRS")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmEmailContacts")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmRemark")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmLanguage")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DateCreatedFirm")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "ID_FRM", 0, True, "BBFRM", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, "ID_FRM", 0, True)
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Firma", -1)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanaam")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanummer")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parent")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parentnaam", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "firmanaam", 0, True, "Firma", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateFirmaBBW))
        Me.UltraGridFirmas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TDSFirmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._dataFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas()
        Me.UltraGridAshFrima = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TDSFirmaHRMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._dataFirmaHRM = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firmaBBWlbl = New System.Windows.Forms.Label()
        Me.firmaNaamSaptxtBx = New System.Windows.Forms.TextBox()
        Me.firmaNrSaptxtBx = New System.Windows.Forms.TextBox()
        Me.firmaBBWtxtBx = New System.Windows.Forms.TextBox()
        Me.bewaarBtn = New System.Windows.Forms.Button()
        Me.hrmFirmaGridTitleLbl = New System.Windows.Forms.Label()
        Me.bbwFirmaGridTitleLbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonFillColumnMail = New System.Windows.Forms.Button()
        Me.ButtonEditBBFRM = New System.Windows.Forms.Button()
        Me.ButtonInfoChip = New System.Windows.Forms.Button()
        Me.ButtonCheckInSAP = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelMailContactProgress = New System.Windows.Forms.Label()
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDSFirmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridAshFrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDSFirmaHRMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGridFirmas
        '
        Me.UltraGridFirmas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGridFirmas.DataMember = "BBFRM"
        Me.UltraGridFirmas.DataSource = Me.TDSFirmasBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridFirmas.DisplayLayout.Appearance = Appearance1
        Me.UltraGridFirmas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Width = 78
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Naam"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Width = 157
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Straat"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Width = 262
        UltraGridColumn11.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Header.Caption = "Postcode"
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.Width = 75
        UltraGridColumn12.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn12.Header.Caption = "Plaats"
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Width = 174
        UltraGridColumn13.Header.Caption = "Nr firma SAP"
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn14.Header.Caption = "Naam firma SAP"
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Width = 151
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn20.Header.Caption = "BBW_Firm Emailcontact(en)"
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "BBW_Firm Opm"
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "BBW_Firm Taal"
        UltraGridColumn22.Header.VisiblePosition = 10
        UltraGridColumn22.Hidden = True
        UltraGridColumn1.Header.Caption = "Datum creatie in BBW"
        UltraGridColumn1.Header.VisiblePosition = 11
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn1})
        SummarySettings1.DisplayFormat = "Aantal = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance2
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.UltraGridFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.UltraGridFirmas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridFirmas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridFirmas.DisplayLayout.Override.CellAppearance = Appearance9
        Me.UltraGridFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridFirmas.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridFirmas.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridFirmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlignAsString = "Left"
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridFirmas.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridFirmas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridFirmas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridFirmas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGridFirmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridFirmas.Location = New System.Drawing.Point(3, 27)
        Me.UltraGridFirmas.Name = "UltraGridFirmas"
        Me.UltraGridFirmas.Size = New System.Drawing.Size(1395, 265)
        Me.UltraGridFirmas.TabIndex = 1
        '
        'TDSFirmasBindingSource
        '
        Me.TDSFirmasBindingSource.DataSource = Me._dataFirmas
        Me.TDSFirmasBindingSource.Position = 0
        '
        '_dataFirmas
        '
        Me._dataFirmas.DataSetName = "TDSFirmas"
        Me._dataFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataFirmas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridAshFrima
        '
        Me.UltraGridAshFrima.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGridAshFrima.DataMember = "Firma"
        Me.UltraGridAshFrima.DataSource = Me.TDSFirmaHRMBindingSource
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridAshFrima.DisplayLayout.Appearance = Appearance14
        Me.UltraGridAshFrima.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn24.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn24.Width = 145
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn27.Header.VisiblePosition = 3
        UltraGridColumn27.Width = 14
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        SummarySettings2.DisplayFormat = "Aantal = {0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance15
        UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings2})
        UltraGridBand2.SummaryFooterCaption = ""
        Me.UltraGridAshFrima.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridAshFrima.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAshFrima.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAshFrima.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAshFrima.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.UltraGridAshFrima.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance18.BackColor2 = System.Drawing.SystemColors.Control
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAshFrima.DisplayLayout.GroupByBox.PromptAppearance = Appearance18
        Me.UltraGridAshFrima.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridAshFrima.DisplayLayout.MaxRowScrollRegions = 1
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridAshFrima.DisplayLayout.Override.ActiveCellAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.SystemColors.Highlight
        Appearance20.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridAshFrima.DisplayLayout.Override.ActiveRowAppearance = Appearance20
        Me.UltraGridAshFrima.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridAshFrima.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridAshFrima.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAshFrima.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.UltraGridAshFrima.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridAshFrima.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridAshFrima.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridAshFrima.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridAshFrima.DisplayLayout.Override.CellAppearance = Appearance22
        Me.UltraGridAshFrima.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridAshFrima.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridAshFrima.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridAshFrima.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance23.BackColor = System.Drawing.SystemColors.Control
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAshFrima.DisplayLayout.Override.GroupByRowAppearance = Appearance23
        Appearance24.TextHAlignAsString = "Left"
        Me.UltraGridAshFrima.DisplayLayout.Override.HeaderAppearance = Appearance24
        Me.UltraGridAshFrima.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridAshFrima.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridAshFrima.DisplayLayout.Override.RowAppearance = Appearance25
        Me.UltraGridAshFrima.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridAshFrima.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAshFrima.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridAshFrima.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridAshFrima.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridAshFrima.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridAshFrima.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.UltraGridAshFrima.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridAshFrima.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridAshFrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAshFrima.Location = New System.Drawing.Point(6, 75)
        Me.UltraGridAshFrima.Name = "UltraGridAshFrima"
        Me.UltraGridAshFrima.Size = New System.Drawing.Size(1392, 275)
        Me.UltraGridAshFrima.TabIndex = 2
        '
        'TDSFirmaHRMBindingSource
        '
        Me.TDSFirmaHRMBindingSource.DataSource = Me._dataFirmaHRM
        Me.TDSFirmaHRMBindingSource.Position = 0
        '
        '_dataFirmaHRM
        '
        Me._dataFirmaHRM.DataSetName = "TDSFirmaHRM"
        Me._dataFirmaHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.firmaBBWlbl)
        Me.GroupBox1.Controls.Add(Me.firmaNaamSaptxtBx)
        Me.GroupBox1.Controls.Add(Me.firmaNrSaptxtBx)
        Me.GroupBox1.Controls.Add(Me.firmaBBWtxtBx)
        Me.GroupBox1.Controls.Add(Me.bewaarBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(972, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update firma BBW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Firmanaam SAP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Firmanr SAP:"
        '
        'firmaBBWlbl
        '
        Me.firmaBBWlbl.AutoSize = True
        Me.firmaBBWlbl.Location = New System.Drawing.Point(10, 23)
        Me.firmaBBWlbl.Name = "firmaBBWlbl"
        Me.firmaBBWlbl.Size = New System.Drawing.Size(63, 13)
        Me.firmaBBWlbl.TabIndex = 4
        Me.firmaBBWlbl.Text = "Firma BBW:"
        '
        'firmaNaamSaptxtBx
        '
        Me.firmaNaamSaptxtBx.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.firmaNaamSaptxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firmaNaamSaptxtBx.Location = New System.Drawing.Point(548, 20)
        Me.firmaNaamSaptxtBx.Name = "firmaNaamSaptxtBx"
        Me.firmaNaamSaptxtBx.Size = New System.Drawing.Size(216, 20)
        Me.firmaNaamSaptxtBx.TabIndex = 3
        '
        'firmaNrSaptxtBx
        '
        Me.firmaNrSaptxtBx.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.firmaNrSaptxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firmaNrSaptxtBx.Location = New System.Drawing.Point(344, 20)
        Me.firmaNrSaptxtBx.Name = "firmaNrSaptxtBx"
        Me.firmaNrSaptxtBx.Size = New System.Drawing.Size(97, 20)
        Me.firmaNrSaptxtBx.TabIndex = 2
        '
        'firmaBBWtxtBx
        '
        Me.firmaBBWtxtBx.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.firmaBBWtxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firmaBBWtxtBx.Location = New System.Drawing.Point(82, 20)
        Me.firmaBBWtxtBx.Name = "firmaBBWtxtBx"
        Me.firmaBBWtxtBx.Size = New System.Drawing.Size(164, 20)
        Me.firmaBBWtxtBx.TabIndex = 1
        '
        'bewaarBtn
        '
        Me.bewaarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bewaarBtn.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Save
        Me.bewaarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bewaarBtn.Location = New System.Drawing.Point(784, 14)
        Me.bewaarBtn.Name = "bewaarBtn"
        Me.bewaarBtn.Size = New System.Drawing.Size(121, 33)
        Me.bewaarBtn.TabIndex = 0
        Me.bewaarBtn.Text = "Bewaar in BBW ..."
        Me.bewaarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.bewaarBtn, "Update NM_FRM, NR_IND_FRM_SAP en NM_FRM_SAP in firma tabel van BBW (+ update adre" & _
                "sgegevens)")
        Me.bewaarBtn.UseVisualStyleBackColor = True
        '
        'hrmFirmaGridTitleLbl
        '
        Me.hrmFirmaGridTitleLbl.AutoSize = True
        Me.hrmFirmaGridTitleLbl.Location = New System.Drawing.Point(6, 59)
        Me.hrmFirmaGridTitleLbl.Name = "hrmFirmaGridTitleLbl"
        Me.hrmFirmaGridTitleLbl.Size = New System.Drawing.Size(94, 13)
        Me.hrmFirmaGridTitleLbl.TabIndex = 4
        Me.hrmFirmaGridTitleLbl.Text = "SAP firma's (HRM)"
        '
        'bbwFirmaGridTitleLbl
        '
        Me.bbwFirmaGridTitleLbl.AutoSize = True
        Me.bbwFirmaGridTitleLbl.Location = New System.Drawing.Point(3, 9)
        Me.bbwFirmaGridTitleLbl.Name = "bbwFirmaGridTitleLbl"
        Me.bbwFirmaGridTitleLbl.Size = New System.Drawing.Size(104, 13)
        Me.bbwFirmaGridTitleLbl.TabIndex = 5
        Me.bbwFirmaGridTitleLbl.Text = "BBW - firma's (BBW)"
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCopy.Location = New System.Drawing.Point(126, 4)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(62, 22)
        Me.ButtonCopy.TabIndex = 6
        Me.ButtonCopy.Text = "Copy"
        Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonCopy, "Kopieer grid BBW firma's naar clipboard")
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(825, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Oranje = Nr firma SAP ingevuld"
        Me.ToolTip1.SetToolTip(Me.Label3, "Firma's in oranje zijn reeds OK (nr firma SAP reeds toegekend)")
        '
        'ButtonFillColumnMail
        '
        Me.ButtonFillColumnMail.Image = CType(resources.GetObject("ButtonFillColumnMail.Image"), System.Drawing.Image)
        Me.ButtonFillColumnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFillColumnMail.Location = New System.Drawing.Point(418, 3)
        Me.ButtonFillColumnMail.Name = "ButtonFillColumnMail"
        Me.ButtonFillColumnMail.Size = New System.Drawing.Size(154, 23)
        Me.ButtonFillColumnMail.TabIndex = 1009
        Me.ButtonFillColumnMail.Text = "Mails in grid contactpers"
        Me.ButtonFillColumnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonFillColumnMail, "Vul kolom ContactPersonMail met mail uit SAP (FRS service Bart/Jeroen)")
        Me.ButtonFillColumnMail.UseVisualStyleBackColor = True
        '
        'ButtonEditBBFRM
        '
        Me.ButtonEditBBFRM.Image = CType(resources.GetObject("ButtonEditBBFRM.Image"), System.Drawing.Image)
        Me.ButtonEditBBFRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditBBFRM.Location = New System.Drawing.Point(631, 4)
        Me.ButtonEditBBFRM.Name = "ButtonEditBBFRM"
        Me.ButtonEditBBFRM.Size = New System.Drawing.Size(170, 23)
        Me.ButtonEditBBFRM.TabIndex = 1011
        Me.ButtonEditBBFRM.Text = "Wijzig BBW email contacten"
        Me.ButtonEditBBFRM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonEditBBFRM, "Vul email BBW in (indien geen koppeling met firmanr SAP)")
        Me.ButtonEditBBFRM.UseVisualStyleBackColor = True
        Me.ButtonEditBBFRM.Visible = False
        '
        'ButtonInfoChip
        '
        Me.ButtonInfoChip.Image = CType(resources.GetObject("ButtonInfoChip.Image"), System.Drawing.Image)
        Me.ButtonInfoChip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInfoChip.Location = New System.Drawing.Point(204, 2)
        Me.ButtonInfoChip.Name = "ButtonInfoChip"
        Me.ButtonInfoChip.Size = New System.Drawing.Size(143, 24)
        Me.ButtonInfoChip.TabIndex = 1012
        Me.ButtonInfoChip.Text = "Mail contactpers SAP"
        Me.ButtonInfoChip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonInfoChip, "info uit SAP: email contactpersoon - geselecteerde firma")
        Me.ButtonInfoChip.UseVisualStyleBackColor = True
        '
        'ButtonCheckInSAP
        '
        Me.ButtonCheckInSAP.Location = New System.Drawing.Point(1010, 7)
        Me.ButtonCheckInSAP.Name = "ButtonCheckInSAP"
        Me.ButtonCheckInSAP.Size = New System.Drawing.Size(72, 41)
        Me.ButtonCheckInSAP.TabIndex = 7
        Me.ButtonCheckInSAP.Text = "Check in SAP"
        Me.ButtonCheckInSAP.UseVisualStyleBackColor = True
        Me.ButtonCheckInSAP.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1088, 7)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 53)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1017, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "aug 2016 - naco: tijdelijk - eenmalige automatische update van sap firmanr voor 6" & _
            "06 firma's"
        Me.Label4.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonInfoChip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEditBBFRM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelMailContactProgress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonFillColumnMail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridFirmas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bbwFirmaGridTitleLbl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCopy)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraGridAshFrima)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.hrmFirmaGridTitleLbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonCheckInSAP)
        Me.SplitContainer1.Size = New System.Drawing.Size(1405, 660)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 1009
        '
        'LabelMailContactProgress
        '
        Me.LabelMailContactProgress.AutoSize = True
        Me.LabelMailContactProgress.Location = New System.Drawing.Point(578, 9)
        Me.LabelMailContactProgress.Name = "LabelMailContactProgress"
        Me.LabelMailContactProgress.Size = New System.Drawing.Size(10, 13)
        Me.LabelMailContactProgress.TabIndex = 1010
        Me.LabelMailContactProgress.Text = "-"
        '
        'FormUpdateFirmaBBW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormUpdateFirmaBBW"
        Me.Text = "Update firma tabel BBW"
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDSFirmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridAshFrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDSFirmaHRMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGridFirmas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridAshFrima As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firmaBBWlbl As System.Windows.Forms.Label
    Friend WithEvents firmaNaamSaptxtBx As System.Windows.Forms.TextBox
    Friend WithEvents firmaNrSaptxtBx As System.Windows.Forms.TextBox
    Friend WithEvents firmaBBWtxtBx As System.Windows.Forms.TextBox
    Friend WithEvents bewaarBtn As System.Windows.Forms.Button
    Friend WithEvents TDSFirmasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _dataFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas
    Friend WithEvents TDSFirmaHRMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _dataFirmaHRM As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM
    Friend WithEvents hrmFirmaGridTitleLbl As System.Windows.Forms.Label
    Friend WithEvents bbwFirmaGridTitleLbl As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
    Friend WithEvents ButtonCheckInSAP As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonFillColumnMail As System.Windows.Forms.Button
    Friend WithEvents LabelMailContactProgress As System.Windows.Forms.Label
    Friend WithEvents ButtonEditBBFRM As System.Windows.Forms.Button
    Friend WithEvents ButtonInfoChip As System.Windows.Forms.Button
End Class
