Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBewakingVoertuig
    Inherits System.Windows.Forms.Form

    Private _controller As ControllerGetData
    Private _canceled As Boolean = True
    Private _idVoertuig As Integer
    Private _voertuig As TDSVoertuigen.BBTSPRow

    Private _proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

    Private _oTdsVoertuigen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen

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
    Friend WithEvents _dataVoertuigen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVoertuigen
    Friend WithEvents UltraGridVoertuigen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButtonNieuw As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridPrintDocumentVoertuig As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialogVoertuig As Infragistics.Win.Printing.UltraPrintPreviewDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormBewakingVoertuig))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBTSP", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TSP")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_TSP")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EIG_TSP")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_TSP")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_TSP_ARC")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_TSP_PRIV")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_MRK_TSP")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PL_NR_TSP")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INH_CYL_TSP")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JR_BOU_TSP")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_CHAS_TSP")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_KEU_L_TSP")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_TSP")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STRA_FRM")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_PLA_FRM")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBoxOpties = New System.Windows.Forms.GroupBox
        Me.UltraButtonNieuw = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSelecteer = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton
        Me._dataVoertuigen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVoertuigen
        Me.UltraGridVoertuigen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGridPrintDocumentVoertuig = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialogVoertuig = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.GroupBoxOpties.SuspendLayout()
        CType(Me._dataVoertuigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridVoertuigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxOpties
        '
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonNieuw)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSelecteer)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpties.Location = New System.Drawing.Point(8, 416)
        Me.GroupBoxOpties.Name = "GroupBoxOpties"
        Me.GroupBoxOpties.Size = New System.Drawing.Size(920, 48)
        Me.GroupBoxOpties.TabIndex = 6
        Me.GroupBoxOpties.TabStop = False
        Me.GroupBoxOpties.Text = "Opties"
        '
        'UltraButtonNieuw
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonNieuw.Appearance = Appearance1
        Me.UltraButtonNieuw.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonNieuw.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonNieuw.Name = "UltraButtonNieuw"
        Me.UltraButtonNieuw.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonNieuw.TabIndex = 6
        Me.UltraButtonNieuw.Text = "Nieuw"
        '
        'UltraButtonAfdrukken
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance2
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonWijzig
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonWijzig.Appearance = Appearance3
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(208, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        '
        'UltraButtonSelecteer
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonSelecteer.Appearance = Appearance4
        Me.UltraButtonSelecteer.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSelecteer.Location = New System.Drawing.Point(728, 16)
        Me.UltraButtonSelecteer.Name = "UltraButtonSelecteer"
        Me.UltraButtonSelecteer.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSelecteer.TabIndex = 3
        Me.UltraButtonSelecteer.Text = "Selecteer"
        '
        'UltraButtonSluiten
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance5
        Me.UltraButtonSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(824, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        '_dataVoertuigen
        '
        Me._dataVoertuigen.DataSetName = "TDSVoertuigen"
        Me._dataVoertuigen.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraGridVoertuigen
        '
        Me.UltraGridVoertuigen.DataMember = "BBTSP"
        Me.UltraGridVoertuigen.DataSource = Me._dataVoertuigen
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridVoertuigen.DisplayLayout.Appearance = Appearance6
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn1.Header.Caption = "Voertuignr"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn3.Header.Caption = "Stamnr eigenaar"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 76
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn5.Header.Caption = "Arcelorvoertuig"
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn6.Header.Caption = "Privévoertuig"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn7.Header.Caption = "Merk"
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Width = 77
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn8.Header.Caption = "Nummerplaat"
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Width = 78
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn9.Header.Caption = "Cylinderinhoud"
        UltraGridColumn9.Header.VisiblePosition = 14
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn10.Header.Caption = "Bouwjaar"
        UltraGridColumn10.Header.VisiblePosition = 15
        UltraGridColumn11.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn11.Header.Caption = "Chassisnr"
        UltraGridColumn11.Header.VisiblePosition = 16
        UltraGridColumn12.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn12.Header.Caption = "Datum keuring"
        UltraGridColumn12.Header.VisiblePosition = 17
        UltraGridColumn13.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn13.Header.Caption = "Type voertuig"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn14.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn14.Header.Caption = "Naam"
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Width = 80
        UltraGridColumn15.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn15.Header.Caption = "Voornaam"
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn15.Width = 64
        UltraGridColumn16.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn16.Header.VisiblePosition = 18
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn17.Header.Caption = "Firmanaam"
        UltraGridColumn17.Header.VisiblePosition = 10
        UltraGridColumn18.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn18.Header.Caption = "Straat"
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn19.Header.Caption = "Postcode"
        UltraGridColumn19.Header.VisiblePosition = 11
        UltraGridColumn19.Width = 61
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn20.Header.Caption = "Plaats"
        UltraGridColumn20.Header.VisiblePosition = 12
        UltraGridColumn20.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        Me.UltraGridVoertuigen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridVoertuigen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVoertuigen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigen.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVoertuigen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraGridVoertuigen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVoertuigen.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraGridVoertuigen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridVoertuigen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridVoertuigen.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridVoertuigen.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraGridVoertuigen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridVoertuigen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridVoertuigen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridVoertuigen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridVoertuigen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigen.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridVoertuigen.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraGridVoertuigen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridVoertuigen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridVoertuigen.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridVoertuigen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigen.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGridVoertuigen.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraGridVoertuigen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridVoertuigen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridVoertuigen.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridVoertuigen.DisplayLayout.Override.RowAppearance = Appearance17
        Me.UltraGridVoertuigen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridVoertuigen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridVoertuigen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.UltraGridVoertuigen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridVoertuigen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridVoertuigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridVoertuigen.Location = New System.Drawing.Point(8, 8)
        Me.UltraGridVoertuigen.Name = "UltraGridVoertuigen"
        Me.UltraGridVoertuigen.Size = New System.Drawing.Size(920, 408)
        Me.UltraGridVoertuigen.TabIndex = 7
        '
        'UltraGridPrintDocumentVoertuig
        '
        Me.UltraGridPrintDocumentVoertuig.Grid = Me.UltraGridVoertuigen
        '
        'UltraPrintPreviewDialogVoertuig
        '
        Me.UltraPrintPreviewDialogVoertuig.Document = Me.UltraGridPrintDocumentVoertuig
        Me.UltraPrintPreviewDialogVoertuig.Name = "UltraPrintPreviewDialogVoertuig"
        '
        'FormBewakingVoertuig
        '
        Me.AcceptButton = Me.UltraButtonSelecteer
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.UltraButtonSluiten
        Me.ClientSize = New System.Drawing.Size(936, 466)
        Me.Controls.Add(Me.UltraGridVoertuigen)
        Me.Controls.Add(Me.GroupBoxOpties)
        Me.Name = "FormBewakingVoertuig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecteer Voertuig"
        Me.GroupBoxOpties.ResumeLayout(False)
        CType(Me._dataVoertuigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridVoertuigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"
    Public ReadOnly Property Canceled() As Boolean
        Get
            Return _canceled
        End Get
    End Property
    Public ReadOnly Property Voertuig() As TDSVoertuigen.BBTSPRow
        Get
            Return _voertuig
        End Get
    End Property

    Public ReadOnly Property IdVoertuig() As Integer
        Get
            Return _idVoertuig
        End Get
    End Property
#End Region

    Private Sub FormBewakingVerzekeringsfirma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _controller = New ControllerGetData

            _oTdsVoertuigen = Me._controller.GetVoertuigen()

            bindGrid()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindGrid()
        Try
            Me._dataVoertuigen.Clear()
            'Me._dataVoertuigen.Merge(Me._oTdsVoertuigen)
            Me._dataVoertuigen.Merge(Me._controller.GetVoertuigen) 'naco - 19/12/2006 - refresh van de grid werkt niet goed (firma is niet ingevuld)
            Me.UltraGridVoertuigen.Refresh()
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Private Sub UltraButtonSelecteer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSelecteer.Click, UltraGridVoertuigen.DoubleClick
        Try
            If Not UltraGridVoertuigen.ActiveRow Is Nothing Then
                Me._idVoertuig = CInt(UltraGridVoertuigen.ActiveRow.Cells("ID_TSP").Value)
                Me._voertuig = Me._dataVoertuigen.BBTSP.FindByID_TSP(Me._idVoertuig)
                Me._canceled = False
                Me.Hide()
            Else
                MessageBox.Show("Geen voertuig geselecteerd.", "Error", MessageBoxButtons.OK)
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

    Private Sub UltraGridVoertuigen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridVoertuigen.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_TSP"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonWijzig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonWijzig.Click
        'Doel:
        'Auteur: Dieter Vanneste - 19/12/2006

        Try
            If Not Me.UltraGridVoertuigen.ActiveRow Is Nothing Then
                Dim id_tsp As Integer
                If Not IsDBNull(Me.UltraGridVoertuigen.ActiveRow.Cells("ID_TSP").Value) Then
                    id_tsp = CInt(Me.UltraGridVoertuigen.ActiveRow.Cells("ID_TSP").Value)

                    Dim resRows() As DataRow
                    resRows = _oTdsVoertuigen.BBTSP.Select("ID_TSP = " & CStr(id_tsp))


                    If Not resRows Is Nothing AndAlso resRows.Length > 0 Then
                        'Update row 
                        Dim oFrmBewakingVoertuigWijzig As New FormBewakingVoertuigWijzig(resRows(0), False)
                        oFrmBewakingVoertuigWijzig.ShowDialog(Me)

                        If oFrmBewakingVoertuigWijzig.opSaveGeklikt = True Then
                            'Save
                            Me._proxy.RegisterVoertuigen(Me._oTdsVoertuigen.GetChanges, System.Environment.UserName)

                            'acceptchanges
                            Me._oTdsVoertuigen.AcceptChanges()

                            bindGrid()
                        Else
                            resRows(0).RejectChanges()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)

        End Try
    End Sub

    Private Sub UltraButtonNieuw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonNieuw.Click
        Try
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen.BBTSPRow
            aRow = Me._oTdsVoertuigen.BBTSP.NewBBTSPRow()

            Dim oFrmBewakingVoertuigWijzig As New FormBewakingVoertuigWijzig(aRow, True)
            oFrmBewakingVoertuigWijzig.ShowDialog(Me)
            'controle rij ingevuld --> opslaan
            If oFrmBewakingVoertuigWijzig.opSaveGeklikt = True Then
                Me._oTdsVoertuigen.BBTSP.AddBBTSPRow(aRow)

                'Save
                Me._proxy.RegisterVoertuigen(Me._oTdsVoertuigen.GetChanges, System.Environment.UserName)

                'acceptchanges
                Me._oTdsVoertuigen.AcceptChanges()

                bindGrid()
            End If
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
            Me.UltraPrintPreviewDialogVoertuig.ShowDialog(Me.UltraGridVoertuigen)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridVoertuigen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridVoertuigen.InitializePrint
        'Doel:   instellingen voor printout
        'Auteur: Nancy Coppens - 19/12/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Bewaking: lijst voertuigen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Bewaking: lijst voertuigen"

            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridPrintDocumentVoertuig_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) _
            Handles UltraGridPrintDocumentVoertuig.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocumentVoertuig.PageNumber
            e.Section.TextLeft = "Datum afdruk: " & Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

End Class
