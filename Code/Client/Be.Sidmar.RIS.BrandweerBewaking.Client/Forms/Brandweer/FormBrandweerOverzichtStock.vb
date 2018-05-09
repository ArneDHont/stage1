Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports System.Drawing
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBrandweerOverzichtStock
    Inherits System.Windows.Forms.Form

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

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
    Friend WithEvents _dataVerbruiksArtikelen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerbruiksArtikelen
    Friend WithEvents GroupBoxOverzicht As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridOverzicht As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _dataArtikelgroep As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSArtikelgroep
    Friend WithEvents UltraDropDownArtikelgroep As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents _dataEenheden As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSEenheden
    Friend WithEvents UltraDropDownEenheden As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraButtonClose As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPrintPreviewDialogStock As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintStock As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraButtonPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonVernieuwen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents RadioButtonToonAlles As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonToonMinStock As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRKART", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_BRK")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_ART_BRK_SAP")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STK_ACT_ART")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STK_MIN_ART")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STK_MAX_ART")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_EH_ART_INTV")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_WY_L")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerOverzichtStock))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBEH", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_EH", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
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
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBARTGR", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_GR_ART")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me._dataVerbruiksArtikelen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerbruiksArtikelen()
        Me.GroupBoxOverzicht = New System.Windows.Forms.GroupBox()
        Me.UltraGridOverzicht = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonToonMinStock = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToonAlles = New System.Windows.Forms.RadioButton()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonVernieuwen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDropDownEenheden = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataEenheden = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSEenheden()
        Me.UltraButtonClose = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSave = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonPrint = New Infragistics.Win.Misc.UltraButton()
        Me.UltraDropDownArtikelgroep = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataArtikelgroep = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSArtikelgroep()
        Me.UltraPrintPreviewDialogStock = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintStock = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        CType(Me._dataVerbruiksArtikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOverzicht.SuspendLayout()
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraDropDownEenheden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataEenheden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownArtikelgroep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataArtikelgroep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_dataVerbruiksArtikelen
        '
        Me._dataVerbruiksArtikelen.DataSetName = "TDSVerbruiksArtikelen"
        Me._dataVerbruiksArtikelen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataVerbruiksArtikelen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxOverzicht
        '
        Me.GroupBoxOverzicht.Controls.Add(Me.UltraGridOverzicht)
        Me.GroupBoxOverzicht.Location = New System.Drawing.Point(8, 8)
        Me.GroupBoxOverzicht.Name = "GroupBoxOverzicht"
        Me.GroupBoxOverzicht.Size = New System.Drawing.Size(1000, 552)
        Me.GroupBoxOverzicht.TabIndex = 4
        Me.GroupBoxOverzicht.TabStop = False
        Me.GroupBoxOverzicht.Text = "Overzicht"
        '
        'UltraGridOverzicht
        '
        Me.UltraGridOverzicht.DataMember = "BBBRKART"
        Me.UltraGridOverzicht.DataSource = Me._dataVerbruiksArtikelen
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridOverzicht.DisplayLayout.Appearance = Appearance1
        Me.UltraGridOverzicht.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 78
        UltraGridColumn2.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn2.Header.Caption = "Artikelgroep"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 92
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn3.Header.Caption = "Eenheid"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 126
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn4.Header.Caption = "SAP nummer"
        UltraGridColumn4.Header.VisiblePosition = 8
        UltraGridColumn4.Width = 121
        UltraGridColumn5.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn5.Header.Caption = "Artikel omschrijving"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 205
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn6.Header.Caption = "In stock"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 75
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn7.Header.Caption = "Min. stock"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 63
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn8.Header.Caption = "Max. stock"
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Width = 69
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.Header.Caption = "Eenheidsprijs (euro)"
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 112
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Datum wijziging"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.UltraGridOverzicht.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridOverzicht.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzicht.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridOverzicht.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridOverzicht.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridOverzicht.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridOverzicht.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzicht.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridOverzicht.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridOverzicht.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridOverzicht.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridOverzicht.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridOverzicht.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridOverzicht.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridOverzicht.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridOverzicht.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzicht.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridOverzicht.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridOverzicht.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridOverzicht.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridOverzicht.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridOverzicht.Location = New System.Drawing.Point(8, 16)
        Me.UltraGridOverzicht.Name = "UltraGridOverzicht"
        Me.UltraGridOverzicht.Size = New System.Drawing.Size(984, 520)
        Me.UltraGridOverzicht.TabIndex = 1
        Me.UltraGridOverzicht.Text = "Z"
        Me.UltraGridOverzicht.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonToonMinStock)
        Me.GroupBox1.Controls.Add(Me.RadioButtonToonAlles)
        Me.GroupBox1.Controls.Add(Me.UltraButton1)
        Me.GroupBox1.Controls.Add(Me.UltraButtonVernieuwen)
        Me.GroupBox1.Controls.Add(Me.UltraDropDownEenheden)
        Me.GroupBox1.Controls.Add(Me.UltraButtonClose)
        Me.GroupBox1.Controls.Add(Me.UltraButtonSave)
        Me.GroupBox1.Controls.Add(Me.UltraButtonPrint)
        Me.GroupBox1.Controls.Add(Me.UltraDropDownArtikelgroep)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 560)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 40)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonToonMinStock
        '
        Me.RadioButtonToonMinStock.Location = New System.Drawing.Point(416, 16)
        Me.RadioButtonToonMinStock.Name = "RadioButtonToonMinStock"
        Me.RadioButtonToonMinStock.Size = New System.Drawing.Size(216, 16)
        Me.RadioButtonToonMinStock.TabIndex = 41
        Me.RadioButtonToonMinStock.Text = "Toon stock < min stock"
        '
        'RadioButtonToonAlles
        '
        Me.RadioButtonToonAlles.Checked = True
        Me.RadioButtonToonAlles.Location = New System.Drawing.Point(328, 16)
        Me.RadioButtonToonAlles.Name = "RadioButtonToonAlles"
        Me.RadioButtonToonAlles.Size = New System.Drawing.Size(80, 16)
        Me.RadioButtonToonAlles.TabIndex = 40
        Me.RadioButtonToonAlles.TabStop = True
        Me.RadioButtonToonAlles.Text = "Toon alle"
        '
        'UltraButton1
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButton1.Appearance = Appearance14
        Me.UltraButton1.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButton1.Location = New System.Drawing.Point(792, 8)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(90, 23)
        Me.UltraButton1.TabIndex = 38
        Me.UltraButton1.Text = "Afdrukken"
        Me.UltraButton1.Visible = False
        '
        'UltraButtonVernieuwen
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonVernieuwen.Appearance = Appearance15
        Me.UltraButtonVernieuwen.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonVernieuwen.Location = New System.Drawing.Point(208, 10)
        Me.UltraButtonVernieuwen.Name = "UltraButtonVernieuwen"
        Me.UltraButtonVernieuwen.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonVernieuwen.TabIndex = 37
        Me.UltraButtonVernieuwen.Text = "Vernieuwen"
        '
        'UltraDropDownEenheden
        '
        Me.UltraDropDownEenheden.DataSource = Me._dataEenheden.BBEH
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownEenheden.DisplayLayout.Appearance = Appearance16
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Caption = "Eenheid"
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12})
        Me.UltraDropDownEenheden.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownEenheden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownEenheden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.Appearance = Appearance17
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance18
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance19.BackColor2 = System.Drawing.SystemColors.Control
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.PromptAppearance = Appearance19
        Me.UltraDropDownEenheden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownEenheden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownEenheden.DisplayLayout.Override.ActiveCellAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.SystemColors.Highlight
        Appearance21.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownEenheden.DisplayLayout.Override.ActiveRowAppearance = Appearance21
        Me.UltraDropDownEenheden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownEenheden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellAppearance = Appearance23
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellPadding = 0
        Appearance24.BackColor = System.Drawing.SystemColors.Control
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.Override.GroupByRowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Left"
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance26.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowAlternateAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowAppearance = Appearance27
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownEenheden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance28
        Me.UltraDropDownEenheden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownEenheden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownEenheden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownEenheden.DisplayMember = "SCF_EH"
        Me.UltraDropDownEenheden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownEenheden.Location = New System.Drawing.Point(392, 16)
        Me.UltraDropDownEenheden.Name = "UltraDropDownEenheden"
        Me.UltraDropDownEenheden.PreferredDropDownSize = New System.Drawing.Size(0, 0)
        Me.UltraDropDownEenheden.Size = New System.Drawing.Size(48, 56)
        Me.UltraDropDownEenheden.TabIndex = 7
        Me.UltraDropDownEenheden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownEenheden.ValueMember = "ID_EH"
        Me.UltraDropDownEenheden.Visible = False
        '
        '_dataEenheden
        '
        Me._dataEenheden.DataSetName = "TDSEenheden"
        Me._dataEenheden.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataEenheden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraButtonClose
        '
        Appearance29.Image = CType(resources.GetObject("Appearance29.Image"), Object)
        Me.UltraButtonClose.Appearance = Appearance29
        Me.UltraButtonClose.Location = New System.Drawing.Point(900, 10)
        Me.UltraButtonClose.Name = "UltraButtonClose"
        Me.UltraButtonClose.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonClose.TabIndex = 5
        Me.UltraButtonClose.Text = "Sluiten"
        '
        'UltraButtonSave
        '
        Appearance30.Image = CType(resources.GetObject("Appearance30.Image"), Object)
        Me.UltraButtonSave.Appearance = Appearance30
        Me.UltraButtonSave.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSave.Location = New System.Drawing.Point(104, 10)
        Me.UltraButtonSave.Name = "UltraButtonSave"
        Me.UltraButtonSave.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonSave.TabIndex = 4
        Me.UltraButtonSave.Text = "Opslaan"
        '
        'UltraButtonPrint
        '
        Appearance31.Image = CType(resources.GetObject("Appearance31.Image"), Object)
        Me.UltraButtonPrint.Appearance = Appearance31
        Me.UltraButtonPrint.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonPrint.Location = New System.Drawing.Point(8, 10)
        Me.UltraButtonPrint.Name = "UltraButtonPrint"
        Me.UltraButtonPrint.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonPrint.TabIndex = 3
        Me.UltraButtonPrint.Text = "Afdrukken"
        '
        'UltraDropDownArtikelgroep
        '
        Me.UltraDropDownArtikelgroep.DataSource = Me._dataArtikelgroep.BBARTGR
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownArtikelgroep.DisplayLayout.Appearance = Appearance32
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Artikelgroep"
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Width = 147
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14})
        Me.UltraDropDownArtikelgroep.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraDropDownArtikelgroep.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownArtikelgroep.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelgroep.DisplayLayout.GroupByBox.Appearance = Appearance33
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownArtikelgroep.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance34
        Me.UltraDropDownArtikelgroep.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance35.BackColor2 = System.Drawing.SystemColors.Control
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownArtikelgroep.DisplayLayout.GroupByBox.PromptAppearance = Appearance35
        Me.UltraDropDownArtikelgroep.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownArtikelgroep.DisplayLayout.MaxRowScrollRegions = 1
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.ActiveCellAppearance = Appearance36
        Appearance37.BackColor = System.Drawing.SystemColors.Highlight
        Appearance37.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.ActiveRowAppearance = Appearance37
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.CardAreaAppearance = Appearance38
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Appearance39.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.CellAppearance = Appearance39
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.CellPadding = 0
        Appearance40.BackColor = System.Drawing.SystemColors.Control
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.GroupByRowAppearance = Appearance40
        Appearance41.TextHAlignAsString = "Left"
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance42.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.RowAlternateAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.RowAppearance = Appearance43
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownArtikelgroep.DisplayLayout.Override.TemplateAddRowAppearance = Appearance44
        Me.UltraDropDownArtikelgroep.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownArtikelgroep.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownArtikelgroep.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownArtikelgroep.DisplayMember = "SCF_GR_ART"
        Me.UltraDropDownArtikelgroep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownArtikelgroep.Location = New System.Drawing.Point(360, 16)
        Me.UltraDropDownArtikelgroep.Name = "UltraDropDownArtikelgroep"
        Me.UltraDropDownArtikelgroep.PreferredDropDownSize = New System.Drawing.Size(0, 0)
        Me.UltraDropDownArtikelgroep.Size = New System.Drawing.Size(24, 56)
        Me.UltraDropDownArtikelgroep.TabIndex = 6
        Me.UltraDropDownArtikelgroep.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownArtikelgroep.ValueMember = "ID_GR_ART"
        Me.UltraDropDownArtikelgroep.Visible = False
        '
        '_dataArtikelgroep
        '
        Me._dataArtikelgroep.DataSetName = "TDSArtikelgroep"
        Me._dataArtikelgroep.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataArtikelgroep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraPrintPreviewDialogStock
        '
        Me.UltraPrintPreviewDialogStock.Document = Me.UltraGridPrintStock
        Me.UltraPrintPreviewDialogStock.Name = "UltraPrintPreviewDialogStock"
        '
        'UltraGridPrintStock
        '
        Me.UltraGridPrintStock.Grid = Me.UltraGridOverzicht
        '
        'FormBrandweerOverzichtStock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 614)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxOverzicht)
        Me.Name = "FormBrandweerOverzichtStock"
        Me.ShowInTaskbar = False
        Me.Text = "Overzicht Stock"
        CType(Me._dataVerbruiksArtikelen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOverzicht.ResumeLayout(False)
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraDropDownEenheden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataEenheden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownArtikelgroep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataArtikelgroep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _controller As ControllerGetData

    Private Sub FormBrandweerOverzichtStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bindOverzicht()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindOverzicht()
        'Doel:
        'Auteur:      studenten
        'Wijzigingen: Nancy Coppens - 07/12/2006 => toon stock < min stock

        Cursor.Current = Cursors.WaitCursor

        _controller = New ControllerGetData

        Me._dataArtikelgroep.Clear()
        Me._dataVerbruiksArtikelen.Clear()
        Me._dataEenheden.Clear()

        Me._dataArtikelgroep.Merge(Me._controller.GetArtikelGroepen)
        Me._dataEenheden.Merge(Me._controller.GetEenheden)
        If RadioButtonToonAlles.Checked = True Then
            Me._dataVerbruiksArtikelen.Merge(Me._controller.GetVerbruiksArtikelen)
        Else
            Me._dataVerbruiksArtikelen.Merge(Me._controller.GetVerbruiksArtikelenMinStock)
        End If

        Me.UltraGridOverzicht.DisplayLayout.Override.TemplateAddRowPrompt = "Klik hier om een rij toe te voegen..."
        Me.UltraGridOverzicht.DisplayLayout.Override.TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
        Me.UltraGridOverzicht.DisplayLayout.Override.SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
        Me.UltraGridOverzicht.DisplayLayout.Override.BorderStyleSpecialRowSeparator = Infragistics.Win.UIElementBorderStyle.RaisedSoft

        Cursor.Current = Cursors.Default
        UltraButtonSave.Enabled = False
    End Sub

    Private Sub UltraGridOverzicht_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridOverzicht.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_GR_ART"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""

            Me.UltraGridOverzicht.DisplayLayout.Bands(0).Columns("ID_GR_ART").ValueList = Me.UltraDropDownArtikelgroep
            Me.UltraGridOverzicht.DisplayLayout.Bands(0).Columns("ID_EH").ValueList = Me.UltraDropDownEenheden
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraGridOverzicht_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridOverzicht.AfterCellUpdate
        Try
            If Not e.Cell.Row.Cells("STK_ACT_ART").Value Is DBNull.Value And Not e.Cell.Row.Cells("STK_MIN_ART").Value Is DBNull.Value Then
                If CType(e.Cell.Row.Cells("STK_ACT_ART").Value, Integer) < CType(e.Cell.Row.Cells("STK_MIN_ART").Value, Integer) Then
                    e.Cell.Row.Appearance.ForeColor = System.Drawing.Color.Red
                Else
                    e.Cell.Row.Appearance.ForeColor = System.Drawing.Color.Black
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridOverzicht_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridOverzicht.InitializeRow
        Try
            If Not e.Row.Cells("STK_ACT_ART").Value Is DBNull.Value And Not e.Row.Cells("STK_MIN_ART").Value Is DBNull.Value Then
                If CType(e.Row.Cells("STK_ACT_ART").Value, Integer) < CType(e.Row.Cells("STK_MIN_ART").Value, Integer) Then
                    e.Row.Appearance.ForeColor = System.Drawing.Color.Red
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonClose.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonPrint.Click
        Try
            Me.UltraPrintPreviewDialogStock.ShowDialog(Me.UltraGridOverzicht)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridOverzicht_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridOverzicht.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 21/04/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Overzicht Stock"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Overzicht Stock " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSave.Click
        Try
            If Me._dataVerbruiksArtikelen.HasChanges Then
                Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                Dim dataInStock As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel
                dataInStock.Merge(Me._dataVerbruiksArtikelen)
                Me._dataVerbruiksArtikelen.Merge(proxy.RegisterStock(CType(dataInStock.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel), _
                System.Environment.UserName))
                _dataVerbruiksArtikelen.AcceptChanges()
                MessageBox.Show("De stock werd succesvol opgeslagen", "BBW Brandweer-Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.EnableOpslaanButton()
            Else
                MessageBox.Show("Geen wijzigingen om weg te schrijven", "BBW", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraGridOverzicht_BeforeExitEditMode(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs) Handles UltraGridOverzicht.BeforeExitEditMode
        Try
            If e.CancellingEditOperation Then Return

            If Me.UltraGridOverzicht.ActiveCell.Column.Key = "STK_ACT_ART" Then
                If Not Me.UltraGridOverzicht.ActiveRow.Cells("STK_ACT_ART").Value Is DBNull.Value Then
                    If CInt(Me.UltraGridOverzicht.ActiveCell.Text) > CInt(Me.UltraGridOverzicht.ActiveRow.Cells("STK_MAX_ART").Value) Then
                        MessageBox.Show("De huidige stock kan niet groter zijn dan de maximum stock", "BBW Brandweer-Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If e.ForceExit Then
                            Me.UltraGridOverzicht.ActiveCell.CancelUpdate()
                        End If
                        e.Cancel = True
                    End If
                End If
            ElseIf Me.UltraGridOverzicht.ActiveCell.Column.Key = "STK_MAX_ART" Then
                If Not Me.UltraGridOverzicht.ActiveRow.Cells("STK_ACT_ART").Value Is DBNull.Value Then
                    If CInt(Me.UltraGridOverzicht.ActiveCell.Text) < CInt(Me.UltraGridOverzicht.ActiveRow.Cells("STK_ACT_ART").Value) Then
                        MessageBox.Show("De huidige stock kan niet groter zijn dan de maximum stock", "BBW Brandweer-Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If e.ForceExit Then
                            Me.UltraGridOverzicht.ActiveCell.CancelUpdate()
                        End If
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonVernieuwen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonVernieuwen.Click
        Try
            Call Me.bindOverzicht()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub EnableOpslaanButton()
        Try
            If Me._dataVerbruiksArtikelen.HasChanges Then
                Me.UltraButtonSave.Enabled = True
            Else
                Me.UltraButtonSave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridOverzicht_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridOverzicht.CellChange
        Try
            If e.Cell.Row.Cells("ID_ART_BRK").Value Is DBNull.Value Then 'filter
                Exit Sub
            Else
                e.Cell.Row.Cells("DT_WY_L").Value = Now
                Me.UltraButtonSave.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridOverzicht_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridOverzicht.AfterRowsDeleted
        Try
            Me.EnableOpslaanButton()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        _dataVerbruiksArtikelen.BBBRKART.Select("STK_ACT_ART < STK_MIN_ART")

    End Sub

    Private Sub RadioButtonToonMinStock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonToonMinStock.Click
        'Doel:   toon alles waarvoor huidige stock < min stock
        'Auteur: Nancy Coppens - 07/12/2006

        bindOverzicht()

    End Sub

    Private Sub RadioButtonToonAlles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonToonAlles.Click
        'Doel:   toon alles
        'Auteur: Nancy Coppens - 07/12/2006

        bindOverzicht()

    End Sub
End Class
