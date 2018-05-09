Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaalVisueleEnPoederControle
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
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ControleLijst", -1)
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMateriaal")
            Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeBlustoestel")
            Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Afdeling")
            Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zone")
            Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nr")
            Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
            Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamBeheerderAfdeling")
            Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gecontroleerd")
            Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumControle")
            Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VorigGewicht")
            Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NieuwGewicht")
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatID")
            Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgNr")
            Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumVisueleKeuring")
            Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumPoederControle")
            Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumVolgendePoederControle")
            Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieOmschr")
            Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Opmerking", 0)
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "TypeMateriaal", 0, True, "ControleLijst", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.UltraGridControle = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerMateriaalControleLijst = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaalControleLijst()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.RadioButtonPrintEnkelzijdig = New System.Windows.Forms.RadioButton()
            Me.RadioButtonPrintDubbelzijdig = New System.Windows.Forms.RadioButton()
            Me.ComboBoxFontsize = New System.Windows.Forms.ComboBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ButtonCopyGrid = New System.Windows.Forms.Button()
            Me.ButtonPrint = New System.Windows.Forms.Button()
            Me.ButtonOpslaan = New System.Windows.Forms.Button()
            Me.LabelPoederSchuim = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ButtonVerlaat = New System.Windows.Forms.Button()
            CType(Me.UltraGridControle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerMateriaalControleLijst, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraGridPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'UltraGridPrintDocument1
            '
            Me.UltraGridPrintDocument1.Grid = Me.UltraGridControle
            '
            'UltraGridControle
            '
            Me.UltraGridControle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGridControle.DataMember = "ControleLijst"
            Me.UltraGridControle.DataSource = Me._dataBrandweerMateriaalControleLijst
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridControle.DisplayLayout.Appearance = Appearance1
            UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn1.Header.Caption = "Type Materiaal"
            UltraGridColumn1.Header.VisiblePosition = 0
            UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn2.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
            UltraGridColumn2.Header.Caption = "Type Blustoestel"
            UltraGridColumn2.Header.VisiblePosition = 1
            UltraGridColumn2.Width = 182
            UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn3.Header.Caption = "Afd"
            UltraGridColumn3.Header.VisiblePosition = 2
            UltraGridColumn3.Width = 70
            UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn4.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
            UltraGridColumn4.Header.VisiblePosition = 3
            UltraGridColumn4.Width = 68
            UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn5.Header.VisiblePosition = 4
            UltraGridColumn5.Width = 58
            UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn6.Header.VisiblePosition = 6
            UltraGridColumn6.Hidden = True
            UltraGridColumn6.Width = 69
            UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn7.Header.Caption = "BeheerderAfd"
            UltraGridColumn7.Header.VisiblePosition = 7
            UltraGridColumn7.Width = 86
            UltraGridColumn8.Header.VisiblePosition = 8
            UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
            UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn9.Header.Caption = "Datum Controle"
            UltraGridColumn9.Header.VisiblePosition = 9
            UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn10.Header.Caption = "Vorig Gew."
            UltraGridColumn10.Header.VisiblePosition = 10
            UltraGridColumn10.Width = 70
            UltraGridColumn11.Header.Caption = "Nieuw Gewicht"
            UltraGridColumn11.Header.VisiblePosition = 11
            UltraGridColumn11.MaskInput = "{double:9.2}"
            UltraGridColumn11.Width = 91
            UltraGridColumn12.Header.VisiblePosition = 12
            UltraGridColumn12.Hidden = True
            UltraGridColumn13.Header.Caption = "MateriaalVolgnr"
            UltraGridColumn13.Header.VisiblePosition = 13
            UltraGridColumn13.Hidden = True
            UltraGridColumn14.Header.Caption = "Datum vis. contr."
            UltraGridColumn14.Header.VisiblePosition = 14
            UltraGridColumn27.Header.Caption = "Datum Poedercontr."
            UltraGridColumn27.Header.VisiblePosition = 15
            UltraGridColumn28.Header.Caption = "Datum vlgnde Poedercontr."
            UltraGridColumn28.Header.VisiblePosition = 16
            UltraGridColumn29.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
            UltraGridColumn29.Header.Caption = "Locatie Omschrijving"
            UltraGridColumn29.Header.VisiblePosition = 5
            UltraGridColumn29.Width = 263
            UltraGridColumn33.Header.VisiblePosition = 17
            UltraGridColumn33.Hidden = True
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn33})
            Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            UltraGridBand1.Override.RowAlternateAppearance = Appearance2
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance3
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridControle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridControle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridControle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance4.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridControle.DisplayLayout.GroupByBox.Appearance = Appearance4
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridControle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
            Me.UltraGridControle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance6.BackColor2 = System.Drawing.SystemColors.Control
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridControle.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
            Me.UltraGridControle.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridControle.DisplayLayout.MaxRowScrollRegions = 1
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridControle.DisplayLayout.Override.ActiveCellAppearance = Appearance7
            Appearance8.BackColor = System.Drawing.SystemColors.Highlight
            Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridControle.DisplayLayout.Override.ActiveRowAppearance = Appearance8
            Me.UltraGridControle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridControle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridControle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridControle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridControle.DisplayLayout.Override.CardAreaAppearance = Appearance9
            Appearance10.BorderColor = System.Drawing.Color.Black
            Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridControle.DisplayLayout.Override.CellAppearance = Appearance10
            Me.UltraGridControle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridControle.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridControle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance11.BackColor = System.Drawing.SystemColors.Control
            Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance11.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridControle.DisplayLayout.Override.GroupByRowAppearance = Appearance11
            Appearance12.TextHAlignAsString = "Left"
            Me.UltraGridControle.DisplayLayout.Override.HeaderAppearance = Appearance12
            Me.UltraGridControle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridControle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.BorderColor = System.Drawing.Color.Black
            Me.UltraGridControle.DisplayLayout.Override.RowAppearance = Appearance13
            Me.UltraGridControle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridControle.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
            Me.UltraGridControle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridControle.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
            Me.UltraGridControle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridControle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridControle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGridControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridControle.Location = New System.Drawing.Point(13, 43)
            Me.UltraGridControle.Name = "UltraGridControle"
            Me.UltraGridControle.Size = New System.Drawing.Size(1545, 510)
            Me.UltraGridControle.TabIndex = 0
            '
            '_dataBrandweerMateriaalControleLijst
            '
            Me._dataBrandweerMateriaalControleLijst.DataSetName = "TDSBrandweerMateriaalControleLijst"
            Me._dataBrandweerMateriaalControleLijst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'RadioButtonPrintEnkelzijdig
            '
            Me.RadioButtonPrintEnkelzijdig.AutoSize = True
            Me.RadioButtonPrintEnkelzijdig.Checked = True
            Me.RadioButtonPrintEnkelzijdig.Location = New System.Drawing.Point(6, 8)
            Me.RadioButtonPrintEnkelzijdig.Name = "RadioButtonPrintEnkelzijdig"
            Me.RadioButtonPrintEnkelzijdig.Size = New System.Drawing.Size(75, 17)
            Me.RadioButtonPrintEnkelzijdig.TabIndex = 0
            Me.RadioButtonPrintEnkelzijdig.TabStop = True
            Me.RadioButtonPrintEnkelzijdig.Text = "Enkelzijdig"
            Me.ToolTip1.SetToolTip(Me.RadioButtonPrintEnkelzijdig, "Controlelijst enkelzijdig afdrukken")
            Me.RadioButtonPrintEnkelzijdig.UseVisualStyleBackColor = True
            '
            'RadioButtonPrintDubbelzijdig
            '
            Me.RadioButtonPrintDubbelzijdig.AutoSize = True
            Me.RadioButtonPrintDubbelzijdig.Location = New System.Drawing.Point(87, 8)
            Me.RadioButtonPrintDubbelzijdig.Name = "RadioButtonPrintDubbelzijdig"
            Me.RadioButtonPrintDubbelzijdig.Size = New System.Drawing.Size(82, 17)
            Me.RadioButtonPrintDubbelzijdig.TabIndex = 1
            Me.RadioButtonPrintDubbelzijdig.Text = "Dubbelzijdig"
            Me.ToolTip1.SetToolTip(Me.RadioButtonPrintDubbelzijdig, "Controlelijst dubbelzijdig afdrukken")
            Me.RadioButtonPrintDubbelzijdig.UseVisualStyleBackColor = True
            '
            'ComboBoxFontsize
            '
            Me.ComboBoxFontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxFontsize.FormattingEnabled = True
            Me.ComboBoxFontsize.Items.AddRange(New Object() {"8,25", "10", "11", "12"})
            Me.ComboBoxFontsize.Location = New System.Drawing.Point(391, 12)
            Me.ComboBoxFontsize.Name = "ComboBoxFontsize"
            Me.ComboBoxFontsize.Size = New System.Drawing.Size(51, 21)
            Me.ComboBoxFontsize.TabIndex = 8
            Me.ToolTip1.SetToolTip(Me.ComboBoxFontsize, "Lettergrootte afdruk")
            '
            'Button1
            '
            Me.Button1.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Refresh
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(636, 12)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(87, 23)
            Me.Button1.TabIndex = 7
            Me.Button1.Text = "Refresh"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.Button1, "Refresh lijst en sorteer op Nr")
            Me.Button1.UseVisualStyleBackColor = True
            '
            'ButtonCopyGrid
            '
            Me.ButtonCopyGrid.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Copy
            Me.ButtonCopyGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonCopyGrid.Location = New System.Drawing.Point(543, 12)
            Me.ButtonCopyGrid.Name = "ButtonCopyGrid"
            Me.ButtonCopyGrid.Size = New System.Drawing.Size(87, 23)
            Me.ButtonCopyGrid.TabIndex = 4
            Me.ButtonCopyGrid.Text = "Copy grid"
            Me.ButtonCopyGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.ButtonCopyGrid, "Lijst kopiëren naar clipboard")
            Me.ButtonCopyGrid.UseVisualStyleBackColor = True
            '
            'ButtonPrint
            '
            Me.ButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.ButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonPrint.Location = New System.Drawing.Point(13, 12)
            Me.ButtonPrint.Name = "ButtonPrint"
            Me.ButtonPrint.Size = New System.Drawing.Size(87, 23)
            Me.ButtonPrint.TabIndex = 1
            Me.ButtonPrint.Text = "Afdrukken"
            Me.ButtonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.ButtonPrint, "Afdrukvoorbeeld controlelijst")
            Me.ButtonPrint.UseVisualStyleBackColor = True
            '
            'ButtonOpslaan
            '
            Me.ButtonOpslaan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOpslaan.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Save
            Me.ButtonOpslaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonOpslaan.Location = New System.Drawing.Point(1359, 559)
            Me.ButtonOpslaan.Name = "ButtonOpslaan"
            Me.ButtonOpslaan.Size = New System.Drawing.Size(103, 23)
            Me.ButtonOpslaan.TabIndex = 2
            Me.ButtonOpslaan.Text = "Opslaan"
            Me.ButtonOpslaan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.ButtonOpslaan, "Aangeduide controles (en ingevuld gewicht) bewaren")
            Me.ButtonOpslaan.UseVisualStyleBackColor = True
            '
            'LabelPoederSchuim
            '
            Me.LabelPoederSchuim.AutoSize = True
            Me.LabelPoederSchuim.Location = New System.Drawing.Point(633, 564)
            Me.LabelPoederSchuim.Name = "LabelPoederSchuim"
            Me.LabelPoederSchuim.Size = New System.Drawing.Size(251, 13)
            Me.LabelPoederSchuim.TabIndex = 5
            Me.LabelPoederSchuim.Text = "Poeder: controle + 2 jaar / Schuim: controle + 6 jaar"
            Me.LabelPoederSchuim.Visible = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.RadioButtonPrintDubbelzijdig)
            Me.GroupBox1.Controls.Add(Me.RadioButtonPrintEnkelzijdig)
            Me.GroupBox1.Location = New System.Drawing.Point(116, 7)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(185, 28)
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(315, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Lettergrootte:"
            '
            'ButtonVerlaat
            '
            Me.ButtonVerlaat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonVerlaat.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
            Me.ButtonVerlaat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonVerlaat.Location = New System.Drawing.Point(1468, 559)
            Me.ButtonVerlaat.Name = "ButtonVerlaat"
            Me.ButtonVerlaat.Size = New System.Drawing.Size(90, 23)
            Me.ButtonVerlaat.TabIndex = 3
            Me.ButtonVerlaat.Text = "Annuleren"
            Me.ButtonVerlaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonVerlaat.UseVisualStyleBackColor = True
            '
            'FormBrandweerMateriaalVisueleEnPoederControle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1570, 594)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ComboBoxFontsize)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.LabelPoederSchuim)
            Me.Controls.Add(Me.ButtonCopyGrid)
            Me.Controls.Add(Me.ButtonPrint)
            Me.Controls.Add(Me.UltraGridControle)
            Me.Controls.Add(Me.ButtonOpslaan)
            Me.Controls.Add(Me.ButtonVerlaat)
            Me.Name = "FormBrandweerMateriaalVisueleEnPoederControle"
            Me.ShowInTaskbar = False
            Me.Text = "Visuele Controle  en Poeder Controle"
            CType(Me.UltraGridControle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerMateriaalControleLijst, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ButtonVerlaat As System.Windows.Forms.Button
        Friend WithEvents ButtonOpslaan As System.Windows.Forms.Button
        Friend WithEvents UltraGridControle As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataBrandweerMateriaalControleLijst As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaalControleLijst
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents ButtonPrint As System.Windows.Forms.Button
        Friend WithEvents ButtonCopyGrid As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents LabelPoederSchuim As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButtonPrintDubbelzijdig As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonPrintEnkelzijdig As System.Windows.Forms.RadioButton
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents ComboBoxFontsize As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace