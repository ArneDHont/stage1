Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormDagVerslagPersoneelOverzicht
    Inherits System.Windows.Forms.Form

    Private aProxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

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
    Friend WithEvents GroupBoxDagverslagPersoneel As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonDelete As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonNieuw As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonWijzig As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblVanaf As System.Windows.Forms.Label
    Friend WithEvents dtpVanaf As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents bntToon As System.Windows.Forms.Button
    Friend WithEvents UltraGridDagverslagPersoneel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataDagverslagRegistratietypes As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType
    Friend WithEvents UltraDropDownRegistratieTypes As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents _dataDagverslagpersoneel As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel
    Friend WithEvents UltraPrintPreviewDialogDagverslagPersoneel As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents btnMailenNaarPersoneelsdienst As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpDatumMailPersoneelsdienst As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGPERS", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PERS")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_REG_DG_PERS", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PERS_TY_REG", -1, "UltraDropDownRegistratieTypes")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("jaar")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("maand")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("weekNr")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("dag", 0)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "TMS_REG_DG_PERS", 4, True, "BBDGPERS", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDagVerslagPersoneelOverzicht))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGTYREG", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PERS_TY_REG", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_DG_PERS_TY_REG")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGridDagverslagPersoneel = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBoxDagverslagPersoneel = New System.Windows.Forms.GroupBox
        Me.dtpDatumMailPersoneelsdienst = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnMailenNaarPersoneelsdienst = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonDelete = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonNieuw = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton
        Me.lblVanaf = New System.Windows.Forms.Label
        Me.dtpVanaf = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.bntToon = New System.Windows.Forms.Button
        Me._dataDagverslagRegistratietypes = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType
        Me.UltraDropDownRegistratieTypes = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraPrintPreviewDialogDagverslagPersoneel = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
        CType(Me.UltraGridDagverslagPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDagverslagPersoneel.SuspendLayout()
        CType(Me.dtpDatumMailPersoneelsdienst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpVanaf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataDagverslagRegistratietypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownRegistratieTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGridDagverslagPersoneel
        '
        Me.UltraGridDagverslagPersoneel.DataMember = "BBDGPERS"
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Appearance = Appearance1
        Me.UltraGridDagverslagPersoneel.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.Header.Caption = "Naam"
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn2.Header.Caption = "Voornaam"
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Stamnummer"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn5.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn5.Header.Caption = "Tijdstip"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 120
        UltraGridColumn6.Header.Caption = "Registratietype"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.Caption = "Opmerking"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.Caption = "Jaar"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.Caption = "Maand"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.Caption = "Weeknr"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Dag"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 50
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        SummarySettings1.DisplayFormat = "Aantal = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance2
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridDagverslagPersoneel.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridDagverslagPersoneel.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDagverslagPersoneel.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagPersoneel.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagPersoneel.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.UltraGridDagverslagPersoneel.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagPersoneel.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.UltraGridDagverslagPersoneel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridDagverslagPersoneel.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.CellAppearance = Appearance9
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridDagverslagPersoneel.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridDagverslagPersoneel.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridDagverslagPersoneel.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridDagverslagPersoneel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridDagverslagPersoneel.Location = New System.Drawing.Point(16, 64)
        Me.UltraGridDagverslagPersoneel.Name = "UltraGridDagverslagPersoneel"
        Me.UltraGridDagverslagPersoneel.Size = New System.Drawing.Size(904, 408)
        Me.UltraGridDagverslagPersoneel.TabIndex = 11
        '
        'GroupBoxDagverslagPersoneel
        '
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.dtpDatumMailPersoneelsdienst)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.btnMailenNaarPersoneelsdienst)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonDelete)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonNieuw)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxDagverslagPersoneel.Location = New System.Drawing.Point(16, 488)
        Me.GroupBoxDagverslagPersoneel.Name = "GroupBoxDagverslagPersoneel"
        Me.GroupBoxDagverslagPersoneel.Size = New System.Drawing.Size(904, 48)
        Me.GroupBoxDagverslagPersoneel.TabIndex = 10
        Me.GroupBoxDagverslagPersoneel.TabStop = False
        Me.GroupBoxDagverslagPersoneel.Text = "Dagverslag personeel"
        '
        'dtpDatumMailPersoneelsdienst
        '
        Me.dtpDatumMailPersoneelsdienst.Location = New System.Drawing.Point(576, 16)
        Me.dtpDatumMailPersoneelsdienst.Name = "dtpDatumMailPersoneelsdienst"
        Me.dtpDatumMailPersoneelsdienst.TabIndex = 17
        '
        'btnMailenNaarPersoneelsdienst
        '
        Me.btnMailenNaarPersoneelsdienst.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnMailenNaarPersoneelsdienst.Location = New System.Drawing.Point(728, 16)
        Me.btnMailenNaarPersoneelsdienst.Name = "btnMailenNaarPersoneelsdienst"
        Me.btnMailenNaarPersoneelsdienst.Size = New System.Drawing.Size(168, 23)
        Me.btnMailenNaarPersoneelsdienst.TabIndex = 6
        Me.btnMailenNaarPersoneelsdienst.Text = "Mailen naar personeelsdienst"
        '
        'UltraButtonDelete
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonDelete.Appearance = Appearance14
        Me.UltraButtonDelete.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonDelete.Location = New System.Drawing.Point(200, 16)
        Me.UltraButtonDelete.Name = "UltraButtonDelete"
        Me.UltraButtonDelete.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonDelete.TabIndex = 5
        Me.UltraButtonDelete.Text = "Verwijder"
        '
        'UltraButtonAfdrukken
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance15
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(328, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonNieuw
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.UltraButtonNieuw.Appearance = Appearance16
        Me.UltraButtonNieuw.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonNieuw.Name = "UltraButtonNieuw"
        Me.UltraButtonNieuw.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonNieuw.TabIndex = 0
        Me.UltraButtonNieuw.Text = "Nieuw"
        '
        'UltraButtonWijzig
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.UltraButtonWijzig.Appearance = Appearance17
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(104, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        '
        'UltraButtonSluiten
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance18
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(424, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'lblVanaf
        '
        Me.lblVanaf.Location = New System.Drawing.Point(16, 16)
        Me.lblVanaf.Name = "lblVanaf"
        Me.lblVanaf.Size = New System.Drawing.Size(136, 23)
        Me.lblVanaf.TabIndex = 15
        Me.lblVanaf.Text = "Overzicht verslagen vanaf"
        Me.lblVanaf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpVanaf
        '
        Me.dtpVanaf.Location = New System.Drawing.Point(152, 16)
        Me.dtpVanaf.Name = "dtpVanaf"
        Me.dtpVanaf.TabIndex = 16
        '
        'bntToon
        '
        Me.bntToon.Location = New System.Drawing.Point(304, 16)
        Me.bntToon.Name = "bntToon"
        Me.bntToon.TabIndex = 17
        Me.bntToon.Text = "&Toon"
        '
        '_dataDagverslagRegistratietypes
        '
        Me._dataDagverslagRegistratietypes.DataSetName = "TDSDagverslagRegistratieType"
        Me._dataDagverslagRegistratietypes.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraDropDownRegistratieTypes
        '
        Me.UltraDropDownRegistratieTypes.DataMember = "BBDGTYREG"
        Me.UltraDropDownRegistratieTypes.DataSource = Me._dataDagverslagRegistratietypes
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Appearance = Appearance19
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Type"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Width = 291
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13})
        Me.UltraDropDownRegistratieTypes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownRegistratieTypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownRegistratieTypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownRegistratieTypes.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownRegistratieTypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.UltraDropDownRegistratieTypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownRegistratieTypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.UltraDropDownRegistratieTypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownRegistratieTypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Highlight
        Appearance24.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.ActiveRowAppearance = Appearance24
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.CellAppearance = Appearance26
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.CellPadding = 0
        Appearance27.BackColor = System.Drawing.SystemColors.Control
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.GroupByRowAppearance = Appearance27
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.RowAppearance = Appearance29
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownRegistratieTypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
        Me.UltraDropDownRegistratieTypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownRegistratieTypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownRegistratieTypes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownRegistratieTypes.DisplayMember = "SCF_DG_PERS_TY_REG"
        Me.UltraDropDownRegistratieTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownRegistratieTypes.Location = New System.Drawing.Point(496, 8)
        Me.UltraDropDownRegistratieTypes.Name = "UltraDropDownRegistratieTypes"
        Me.UltraDropDownRegistratieTypes.TabIndex = 18
        Me.UltraDropDownRegistratieTypes.ValueMember = "ID_DG_PERS_TY_REG"
        Me.UltraDropDownRegistratieTypes.Visible = False
        '
        'UltraPrintPreviewDialogDagverslagPersoneel
        '
        Me.UltraPrintPreviewDialogDagverslagPersoneel.Document = Me.UltraGridPrintDocument1
        Me.UltraPrintPreviewDialogDagverslagPersoneel.Name = "UltraPrintPreviewDialogDagverslagPersoneel"
        '
        'UltraGridPrintDocument1
        '
        Me.UltraGridPrintDocument1.Grid = Me.UltraGridDagverslagPersoneel
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FormDagVerslagPersoneelOverzicht
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 558)
        Me.Controls.Add(Me.bntToon)
        Me.Controls.Add(Me.UltraDropDownRegistratieTypes)
        Me.Controls.Add(Me.dtpVanaf)
        Me.Controls.Add(Me.lblVanaf)
        Me.Controls.Add(Me.UltraGridDagverslagPersoneel)
        Me.Controls.Add(Me.GroupBoxDagverslagPersoneel)
        Me.Name = "FormDagVerslagPersoneelOverzicht"
        Me.Text = "Overzicht dagverslag personeel"
        CType(Me.UltraGridDagverslagPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDagverslagPersoneel.ResumeLayout(False)
        CType(Me.dtpDatumMailPersoneelsdienst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpVanaf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataDagverslagRegistratietypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownRegistratieTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormDagVerslagPersoneelOverzicht_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

            'Me.dtpVanaf.Value = Now.Subtract(New TimeSpan(30, 0, 0, 0, 0))
            Me.dtpVanaf.Value = Now
            Me.UltraDropDownRegistratieTypes.DataSource = aProxy.DagverslagRegistratieTypes()

            'al onmiddellijk de grid eens vullen (anders problemen als je nieuwe registratie toevoegt, en je hebt niet eerst op Toon geklikt)
            Dim datumVanaf As New DateTime(CType(Me.dtpVanaf.Value, DateTime).Year, _
                                            CType(Me.dtpVanaf.Value, DateTime).Month, _
                                            CType(Me.dtpVanaf.Value, DateTime).Day)
            Me.UltraGridDagverslagPersoneel.DataSource = aProxy.GetDagverslagPersoneel(datumVanaf)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonNieuw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonNieuw.Click
        Try
            Dim oFrmDagVerslagPersoneel As New FormDagverslagPersoneel(-1, CType(Me.UltraGridDagverslagPersoneel.DataSource, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel))
            oFrmDagVerslagPersoneel.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonWijzig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonWijzig.Click
        Try
            If Not Me.UltraGridDagverslagPersoneel.ActiveRow Is Nothing Then
                Dim id_dgpers As Integer
                Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel.BBDGPERSRow
                aRow = CType(Me.UltraGridDagverslagPersoneel.DataSource, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel).BBDGPERS.FindByID_DG_PERS(Me.UltraGridDagverslagPersoneel.ActiveRow.Cells("ID_DG_PERS").Value)

                id_dgpers = aRow("id_dg_pers")

                Dim oFrmDagVerslagPersoneel As New FormDagverslagPersoneel(id_dgpers, CType(Me.UltraGridDagverslagPersoneel.DataSource, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel))
                oFrmDagVerslagPersoneel.ShowDialog(Me)
            Else
                MessageBox.Show("Gelieve een registratie te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub bntToon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntToon.Click
        Try

            Dim datumVanaf As New DateTime(CType(Me.dtpVanaf.Value, DateTime).Year, _
                                            CType(Me.dtpVanaf.Value, DateTime).Month, _
                                            CType(Me.dtpVanaf.Value, DateTime).Day)
            Me.UltraGridDagverslagPersoneel.DataSource = aProxy.GetDagverslagPersoneel(datumVanaf)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonDelete.Click
        'Auteur: Siddien 
        'Datum: okt 2006
        Try
            Dim aResult As DialogResult = MessageBox.Show("Bent u zeker?", "Verwijderen registratie", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If aResult = DialogResult.Yes Then
                Dim aDat As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel = CType(Me.UltraGridDagverslagPersoneel.DataSource, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel)
                Dim id_dg_pers As Integer
                If Me.UltraGridDagverslagPersoneel.ActiveRow Is Nothing Then
                    MessageBox.Show("Gelieve een registratie te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'Verwijderen van de rij.
                    id_dg_pers = Me.UltraGridDagverslagPersoneel.ActiveRow.Cells("id_dg_pers").Value
                    aDat.BBDGPERS.FindByID_DG_PERS(id_dg_pers).Delete()
                    Dim aProxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                    aProxy.RegisterDagverslagPersoneel(aDat.GetChanges(DataRowState.Deleted), System.Environment.UserName)

                    aDat.AcceptChanges()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.UltraPrintPreviewDialogDagverslagPersoneel.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridDagverslagPersoneel_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridDagverslagPersoneel.InitializePrint
        'Doel: rapport instellingen
        'Auteur: Siddien - okt 2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = False
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Dagverslag personeel " & Now()
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


    Private Sub UltraPrintPreviewDialogDagverslagPersoneel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraPrintPreviewDialogDagverslagPersoneel.Load
        Try
            Me.UltraPrintPreviewDialogDagverslagPersoneel.Document.DocumentName = "Dagverslag personeel"
            Me.UltraPrintPreviewDialogDagverslagPersoneel.Text = "Dagverslag personeel"
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridPrintDocument1_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocument1.PageNumber
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try

    End Sub

    Private Sub UltraGridDagverslagPersoneel_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridDagverslagPersoneel.InitializeRow
        Try
            e.Row.Cells("dag").Value = CType(e.Row.Cells("TMS_REG_DG_PERS").Value, DateTime).ToString("dddd")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub btnMailenNaarPersoneelsdienst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailenNaarPersoneelsdienst.Click
        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim textMail As String
        Dim titelMail As String
        Dim best As New ArrayList

        Try

            Dim datumPersoneel As DateTime = New DateTime(CType(Me.dtpDatumMailPersoneelsdienst.Value, DateTime).Year, _
                                                            CType(Me.dtpDatumMailPersoneelsdienst.Value, DateTime).Month, _
                                                            CType(Me.dtpDatumMailPersoneelsdienst.Value, DateTime).Day)

            'Controle reeds verzonden
            If aProxy.dagVerslagPersoneelReedsDoorgestuurd(datumPersoneel) = True Then
                Dim result As DialogResult
                result = MessageBox.Show("Het verslag werd reeds verzonden, wenst u dit nogmaals te verzenden?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Exit Sub
                End If
            End If

            'ophalen bestemmeling
            Dim mailAdres As String
            Dim mailAdressen() As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "MailDagVerslag").WD().Split(";")
            For Each mailAdres In mailAdressen
                best.Add(mailAdres)
            Next

            If MessageBox.Show("Wenst u het dagverslag personeel voor " & Format(datumPersoneel, "dd/MM/yyyy") & " door te mailen naar '" & _
                                _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "MailDagVerslag").WD() & "'?", "Dagverslag personeel", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            If best.Count = 0 Then
                MessageBox.Show("Er zijn geen bestemmelingen gevonden. Gelieve contact op te nemen met informatica.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD & _
                                   "DagverslagPers" & "_" & CType(Me.dtpDatumMailPersoneelsdienst.Value, DateTime).ToString("ddMMyyyy") & ".pdf"

                pathsAttachment.Add(pathPDFfile)

                Dim params As New Hashtable



                params.Add("datumPersoneel", Format(datumPersoneel, "dd/MM/yyyy"))
                params.Add("datumEndPersoneel", Format(datumPersoneel.AddDays(1), "dd/MM/yyyy"))

                f_rap.Show()
                f_rap.ExportPdfBewakingRegistratie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                                   "DagverslagPersoneel", _
                                                   pathPDFfile, _
                                                   params)
                f_rap.Dispose()

                'Dan mail versturen met PDF-file in attachment

                textMail = "Geachte, in bijlage vindt u een nieuw dagverslag personeel bewaking"

                titelMail = "Dagverslag personeel bewaking " & CType(dtpDatumMailPersoneelsdienst.Value, DateTime).ToString("dd/MM/yyyy")


                MailBBW.sendMail(best, textMail, titelMail, pathsAttachment)

                Me.aProxy.ToevoegenDagverslagPersoneel(datumPersoneel)
                MessageBox.Show("Mail werd correct verzonden.", "Mail dagverslag personeel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                                ReThrowOptions.PublishOnly)
        End Try
    End Sub
End Class
