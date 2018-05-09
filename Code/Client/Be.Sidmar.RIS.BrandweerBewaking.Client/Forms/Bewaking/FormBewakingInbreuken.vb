Option Strict On
Option Explicit On 

Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBewakingInbreuken
    Inherits System.Windows.Forms.Form

    Private _controller As ControllerGetData
    Private _canceled As Boolean = True
    Private _idInbreuk As Integer
    Friend WithEvents _dataInbrArt As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrArt
    Private _inbreuk As TDSInbrArt.BBINBRARRow

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
    Friend WithEvents GroupBoxOpties As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonWijzig As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSelecteer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridInbreukartikelen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataInbrType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrType
    Friend WithEvents UltraDropDownInbreukTypes As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraGridPrintDocumentInbreuken As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialogInbreuken As Infragistics.Win.Printing.UltraPrintPreviewDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingInbreuken))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRAR", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INBR")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INBR", -1, "UltraDropDownInbreukTypes")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_ART_INBR", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukKlasseID")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_FR")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_EN")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_DE")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INBR")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_CLS_INBR")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRTY", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INBR")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INBR")
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
        Me.GroupBoxOpties = New System.Windows.Forms.GroupBox()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSelecteer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridInbreukartikelen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataInbrArt = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrArt()
        Me._dataInbrType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrType()
        Me.UltraDropDownInbreukTypes = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.UltraGridPrintDocumentInbreuken = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialogInbreuken = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.GroupBoxOpties.SuspendLayout()
        CType(Me.UltraGridInbreukartikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInbrArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInbrType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownInbreukTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxOpties
        '
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSelecteer)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpties.Location = New System.Drawing.Point(8, 416)
        Me.GroupBoxOpties.Name = "GroupBoxOpties"
        Me.GroupBoxOpties.Size = New System.Drawing.Size(776, 48)
        Me.GroupBoxOpties.TabIndex = 8
        Me.GroupBoxOpties.TabStop = False
        Me.GroupBoxOpties.Text = "Opties"
        '
        'UltraButtonAfdrukken
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance1
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonWijzig
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonWijzig.Appearance = Appearance2
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(208, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        '
        'UltraButtonSelecteer
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonSelecteer.Appearance = Appearance3
        Me.UltraButtonSelecteer.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSelecteer.Location = New System.Drawing.Point(424, 16)
        Me.UltraButtonSelecteer.Name = "UltraButtonSelecteer"
        Me.UltraButtonSelecteer.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSelecteer.TabIndex = 3
        Me.UltraButtonSelecteer.Text = "Selecteer"
        '
        'UltraButtonSluiten
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance4
        Me.UltraButtonSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(520, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraGridInbreukartikelen
        '
        Me.UltraGridInbreukartikelen.DataMember = "BBINBRAR"
        Me.UltraGridInbreukartikelen.DataSource = Me._dataInbrArt
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Appearance44.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridInbreukartikelen.DisplayLayout.Appearance = Appearance44
        Me.UltraGridInbreukartikelen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 242
        UltraGridColumn2.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.Caption = "Inbreuktype"
        UltraGridColumn2.Header.VisiblePosition = 5
        UltraGridColumn2.Width = 143
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.Caption = "Artikelnr"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 114
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.Caption = "Artikelomschrijving"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 397
        UltraGridColumn5.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 65
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 78
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 79
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 79
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Header.Caption = "Inbreukklasse"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 78
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Header.Caption = "Inbreukklasse"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 101
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.UltraGridInbreukartikelen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridInbreukartikelen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreukartikelen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.UltraGridInbreukartikelen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridInbreukartikelen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.ActiveCellAppearance = Appearance48
        Appearance49.BackColor = System.Drawing.SystemColors.Highlight
        Appearance49.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.ActiveRowAppearance = Appearance49
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance50.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CardAreaAppearance = Appearance50
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Appearance51.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellAppearance = Appearance51
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance52.BackColor = System.Drawing.SystemColors.Control
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.GroupByRowAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Left"
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance54.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowAlternateAppearance = Appearance54
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Appearance55.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowAppearance = Appearance55
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance56
        Me.UltraGridInbreukartikelen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridInbreukartikelen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridInbreukartikelen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInbreukartikelen.Location = New System.Drawing.Point(8, 8)
        Me.UltraGridInbreukartikelen.Name = "UltraGridInbreukartikelen"
        Me.UltraGridInbreukartikelen.Size = New System.Drawing.Size(776, 408)
        Me.UltraGridInbreukartikelen.TabIndex = 11
        Me.UltraGridInbreukartikelen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataInbrArt
        '
        Me._dataInbrArt.DataSetName = "TDSInbrArt"
        Me._dataInbrArt.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInbrArt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataInbrType
        '
        Me._dataInbrType.DataSetName = "TDSInbrType"
        Me._dataInbrType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInbrType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownInbreukTypes
        '
        Me.UltraDropDownInbreukTypes.DataMember = "BBINBRTY"
        Me.UltraDropDownInbreukTypes.DataSource = Me._dataInbrType
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownInbreukTypes.DisplayLayout.Appearance = Appearance18
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 47
        UltraGridColumn12.Header.Caption = "Type"
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Width = 184
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12})
        Me.UltraDropDownInbreukTypes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownInbreukTypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownInbreukTypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreukTypes.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInbreukTypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.UltraDropDownInbreukTypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInbreukTypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.UltraDropDownInbreukTypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownInbreukTypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.ActiveCellAppearance = Appearance22
        Appearance23.BackColor = System.Drawing.SystemColors.Highlight
        Appearance23.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.ActiveRowAppearance = Appearance23
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.CardAreaAppearance = Appearance24
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Appearance25.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.CellAppearance = Appearance25
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.CellPadding = 0
        Appearance26.BackColor = System.Drawing.SystemColors.Control
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.GroupByRowAppearance = Appearance26
        Appearance27.TextHAlignAsString = "Left"
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.HeaderAppearance = Appearance27
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance28.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.RowAlternateAppearance = Appearance28
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.RowAppearance = Appearance29
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownInbreukTypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
        Me.UltraDropDownInbreukTypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownInbreukTypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownInbreukTypes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownInbreukTypes.DisplayMember = "SCF_TY_INBR"
        Me.UltraDropDownInbreukTypes.Location = New System.Drawing.Point(760, 32)
        Me.UltraDropDownInbreukTypes.Name = "UltraDropDownInbreukTypes"
        Me.UltraDropDownInbreukTypes.PreferredDropDownSize = New System.Drawing.Size(0, 0)
        Me.UltraDropDownInbreukTypes.Size = New System.Drawing.Size(16, 32)
        Me.UltraDropDownInbreukTypes.TabIndex = 12
        Me.UltraDropDownInbreukTypes.ValueMember = "ID_TY_INBR"
        Me.UltraDropDownInbreukTypes.Visible = False
        '
        'UltraGridPrintDocumentInbreuken
        '
        Me.UltraGridPrintDocumentInbreuken.Grid = Me.UltraGridInbreukartikelen
        '
        'UltraPrintPreviewDialogInbreuken
        '
        Me.UltraPrintPreviewDialogInbreuken.Document = Me.UltraGridPrintDocumentInbreuken
        Me.UltraPrintPreviewDialogInbreuken.Name = "UltraPrintPreviewDialogInbreuken"
        '
        'FormBewakingInbreuken
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 466)
        Me.Controls.Add(Me.UltraDropDownInbreukTypes)
        Me.Controls.Add(Me.UltraGridInbreukartikelen)
        Me.Controls.Add(Me.GroupBoxOpties)
        Me.Name = "FormBewakingInbreuken"
        Me.Text = "Inbreuken"
        Me.GroupBoxOpties.ResumeLayout(False)
        CType(Me.UltraGridInbreukartikelen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInbrArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInbrType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownInbreukTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"
    Public ReadOnly Property Canceled() As Boolean
        Get
            Return _canceled
        End Get
    End Property
    Public ReadOnly Property Inbreuk() As TDSInbrArt.BBINBRARRow
        Get
            Return _inbreuk
        End Get
    End Property

    Public ReadOnly Property IdInbreuk() As Integer
        Get
            Return _idInbreuk
        End Get
    End Property
#End Region

    Private Sub FormBewakingInbreuken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _controller = New ControllerGetData

            Me._dataInbrArt.Merge(Me._controller.GetInbreukArtikel(0))

            Me._dataInbrType.Merge(Me._controller.GetInbrType)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingInbreuken - MyBase.Load" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonSelecteer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSelecteer.Click, UltraGridInbreukartikelen.DoubleClick
        Try
            If UltraGridInbreukartikelen.Selected.Rows.Count() <> 0 Then
                Me._idInbreuk = CInt(UltraGridInbreukartikelen.Selected.Rows(0).Cells("ID_ART_INBR").Value)
                Me._inbreuk = Me._dataInbrArt.BBINBRAR.FindByID_ART_INBR(Me._idInbreuk)
                Me._canceled = False
                Me.Hide()
            Else
                MessageBox.Show("Geen inbreuk geselecteerd.", "Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me._canceled = True
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridVerzFirmas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridInbreukartikelen.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_ART_INBR"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        'Doel:   Grid afdrukken
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            Me.UltraPrintPreviewDialogInbreuken.ShowDialog(Me.UltraGridInbreukartikelen)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridPrintDocumentinbreuken_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) _
        Handles UltraGridPrintDocumentInbreuken.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocumentInbreuken.PageNumber
            e.Section.TextLeft = "Datum afdruk: " & Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridLijstInbreuken_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridInbreukartikelen.InitializePrint
        'Doel:   instellingen voor printout
        'Auteur: Nancy Coppens - 19/12/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Bewaking: Inbreuken op reglement"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Bewaking: Inbreuken op reglement"

            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
