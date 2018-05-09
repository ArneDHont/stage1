Option Explicit On 
Option Strict On

Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormBewakingTrimesterDiefstal
    Inherits System.Windows.Forms.Form
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private _dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie

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
    Friend WithEvents _dataTrimesterDiefstal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSTrimesterDiefstal
    Friend WithEvents UltraGridDiefstalPerTrimester As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _ultraGridPrintDocumentDiefstalTrimester As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents _ultraPrintPreviewDialogTrimesterDiefstal As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonExportExcel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents _ultraGridExcelExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DiefstalTrimester", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JR_REG")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trimester")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_REG_JR_BPL")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INC", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INC")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_REG")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STA_MAT")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WD_MAT")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_LNG_DIEF")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_MAT_STLN")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_RAP_NW")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OK")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_BST")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MinValue")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MinMaxValue")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaxValue")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PolitieGevraagdDoorAfdYN")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PolitieLangsgeweestYN")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PolitiePVnummer")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "ID_REG", 2, True, "DiefstalTrimester", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "JR_REG", 0, True)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MinValue", 14, True, "DiefstalTrimester", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MinValue", 14, True)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MinMaxValue", 15, True, "DiefstalTrimester", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MinMaxValue", 15, True)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MaxValue", 16, True, "DiefstalTrimester", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MaxValue", 16, True)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "WD_MAT", 8, True, "DiefstalTrimester", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "WD_MAT", 8, True)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingTrimesterDiefstal))
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me._ultraGridPrintDocumentDiefstalTrimester = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraGridDiefstalPerTrimester = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataTrimesterDiefstal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSTrimesterDiefstal()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me._ultraPrintPreviewDialogTrimesterDiefstal = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonExportExcel = New Infragistics.Win.Misc.UltraButton()
        Me._ultraGridExcelExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.UltraGridDiefstalPerTrimester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataTrimesterDiefstal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_ultraGridPrintDocumentDiefstalTrimester
        '
        Me._ultraGridPrintDocumentDiefstalTrimester.Grid = Me.UltraGridDiefstalPerTrimester
        '
        'UltraGridDiefstalPerTrimester
        '
        Me.UltraGridDiefstalPerTrimester.DataMember = "DiefstalTrimester"
        Me.UltraGridDiefstalPerTrimester.DataSource = Me._dataTrimesterDiefstal
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Jaar"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Volgnr"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn5.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn5.Header.Caption = "Tijdstip"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.Header.Caption = "Plaats"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.Header.Caption = "Omschrijving"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Width = 109
        UltraGridColumn8.Header.Caption = "Status"
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn9.Header.Caption = "Waarde"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 94
        UltraGridColumn10.Header.Caption = "Acties"
        UltraGridColumn10.Header.VisiblePosition = 17
        UltraGridColumn11.Header.Caption = "Voorwerp"
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Width = 51
        UltraGridColumn19.Header.Caption = "Politie Gevraagd"
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Width = 97
        UltraGridColumn20.Header.Caption = "Politie Geweest"
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Width = 92
        UltraGridColumn21.Header.Caption = "PV-nr"
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        SummarySettings1.DisplayFormat = "Aantal = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance2
        SummarySettings2.DisplayFormat = "Aantal={0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance3
        SummarySettings3.DisplayFormat = "Aantal = {0}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance4
        SummarySettings4.DisplayFormat = "Aantal = {0}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance5
        SummarySettings5.DisplayFormat = "Waarde = {0}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance6
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.RowAppearance = Appearance16
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridDiefstalPerTrimester.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGridDiefstalPerTrimester.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDiefstalPerTrimester.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridDiefstalPerTrimester.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDiefstalPerTrimester.Name = "UltraGridDiefstalPerTrimester"
        Me.UltraGridDiefstalPerTrimester.Size = New System.Drawing.Size(1218, 569)
        Me.UltraGridDiefstalPerTrimester.TabIndex = 0
        Me.UltraGridDiefstalPerTrimester.Text = "UltraGrid1"
        '
        '_dataTrimesterDiefstal
        '
        Me._dataTrimesterDiefstal.DataSetName = "TDSTrimesterDiefstal"
        Me._dataTrimesterDiefstal.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataTrimesterDiefstal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraButtonAfdrukken
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance18
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(6, 9)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonAfdrukken.TabIndex = 4
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        '_ultraPrintPreviewDialogTrimesterDiefstal
        '
        Me._ultraPrintPreviewDialogTrimesterDiefstal.Document = Me._ultraGridPrintDocumentDiefstalTrimester
        Me._ultraPrintPreviewDialogTrimesterDiefstal.Name = "_ultraPrintPreviewDialogTrimesterDiefstal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBox1.Controls.Add(Me.UltraButtonExportExcel)
        Me.GroupBox1.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 35)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'UltraButtonSluiten
        '
        Appearance19.Image = CType(resources.GetObject("Appearance19.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance19
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(904, 9)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonSluiten.TabIndex = 6
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraButtonExportExcel
        '
        Appearance20.Image = CType(resources.GetObject("Appearance20.Image"), Object)
        Me.UltraButtonExportExcel.Appearance = Appearance20
        Me.UltraButtonExportExcel.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonExportExcel.Location = New System.Drawing.Point(128, 9)
        Me.UltraButtonExportExcel.Name = "UltraButtonExportExcel"
        Me.UltraButtonExportExcel.Size = New System.Drawing.Size(120, 23)
        Me.UltraButtonExportExcel.TabIndex = 5
        Me.UltraButtonExportExcel.Text = "Export naar Excel"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridDiefstalPerTrimester)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1218, 623)
        Me.SplitContainer1.SplitterDistance = 569
        Me.SplitContainer1.TabIndex = 6
        '
        'FormBewakingTrimesterDiefstal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1218, 623)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormBewakingTrimesterDiefstal"
        Me.Text = "Overzicht diefstallen per trimester"
        CType(Me.UltraGridDiefstalPerTrimester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataTrimesterDiefstal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me._ultraPrintPreviewDialogTrimesterDiefstal.ShowDialog(Me.UltraGridDiefstalPerTrimester)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridDiefstalPerTrimester_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridDiefstalPerTrimester.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Nancy Coppens - 19/12/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Bewaking: Overzicht diefstallen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Bewaking: Overzicht diefstallen"

            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub _ultraGridPrintDocumentDiefstalTrimester_PagePrinting(ByVal sender As System.Object, ByVal e As Infragistics.Win.Printing.PagePrintingEventArgs) Handles _ultraGridPrintDocumentDiefstalTrimester.PagePrinting

    End Sub

    Private Sub _ultraGridPrintDocumentDiefstalTrimester_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles _ultraGridPrintDocumentDiefstalTrimester.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me._ultraGridPrintDocumentDiefstalTrimester.PageNumber
            e.Section.TextLeft = "Datum afdruk: " & Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub FormBewakingTrimesterDiefstal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim aRow As TDSTrimesterDiefstal.DiefstalTrimesterRow
        'Dim waarde As Integer 'Dien - aug2008 - migratie 2008
        Dim minWaarde As Integer
        Dim maxWaarde As Integer

        Try
            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
            minWaarde = CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "MinWaardeDiefstal").WD)
            maxWaarde = CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "MaxWaardeDiefstal").WD)
            UltraGridDiefstalPerTrimester.DisplayLayout.Bands(0).Columns("MinValue").Header.Caption = "<" & minWaarde
            UltraGridDiefstalPerTrimester.DisplayLayout.Bands(0).Columns("MinMaxValue").Header.Caption = ">" & minWaarde & " en <" & maxWaarde
            UltraGridDiefstalPerTrimester.DisplayLayout.Bands(0).Columns("MaxValue").Header.Caption = ">" & maxWaarde
            UltraGridDiefstalPerTrimester.DisplayLayout.Bands(0).SortedColumns.Clear()
            UltraGridDiefstalPerTrimester.DisplayLayout.Bands(0).Columns("TMS_INC").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending

            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataTrimesterDiefstal.Merge(Me._controller.GetDiefstallenPerTrimester)

            For Each aRow In _dataTrimesterDiefstal.DiefstalTrimester
                With aRow
                    If Not .IsWD_MATNull Then
                        If .WD_MAT < minWaarde Then
                            .MinValue = True
                        ElseIf .WD_MAT > minWaarde And .WD_MAT < maxWaarde Then
                            .MinMaxValue = True
                        ElseIf .WD_MAT > maxWaarde Then
                            .MaxValue = True
                        End If
                    End If
                End With

                aRow.Maand = Month(aRow.TMS_INC)
            Next

            _dataTrimesterDiefstal.AcceptChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
    Private Sub UltraButtonExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonExportExcel.Click
        'Doel: Exporteren van de gegevens naar excel
        'Auteur: Mieke Duynslager - 14/06/2007
        'Dim Excelpad As String 'Dien - aug2008 - migratie 2008
        Dim saveFile As New SaveFileDialog

        Try
            'Set the file name filter to default to .xls to list the type of file to save as, and present
            '.xls as the first file type in the drop down list.
            saveFile.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            saveFile.FilterIndex = 1
            saveFile.DefaultExt = ".xls"

            'Open a Windows save file dailog box and ask the user to save the file where ever they want.
            'Pass in the grid and the FileName property to the exporter.
            If saveFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Me._ultraGridExcelExporter.Export(Me.UltraGridDiefstalPerTrimester, saveFile.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)

        End Try
    End Sub

    Private Sub UltraGridDiefstalPerTrimester_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridDiefstalPerTrimester.DoubleClickRow
        Try
            If Not Me.UltraGridDiefstalPerTrimester.ActiveRow Is Nothing Then
                FormManager.Current.OpenFormDiefstal(False, False, True, CInt(UltraGridDiefstalPerTrimester.ActiveRow.Cells("ID_REG").Text))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridDiefstalPerTrimester_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridDiefstalPerTrimester.InitializeLayout

    End Sub
End Class
