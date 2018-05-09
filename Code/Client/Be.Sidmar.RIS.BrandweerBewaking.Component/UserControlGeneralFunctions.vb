Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.IO
Imports System.Diagnostics
Imports System.Configuration
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports System.Net

Public Class UserControlGeneralFunctions
    Inherits System.Windows.Forms.UserControl

    Public Enum brandweerOfBewaking
        brandweer
        bewaking
    End Enum

    Private _hoofdDienst As String
    Private _myProxy As BBWServiceManagementServicesProxy
    Private _flagEmptyBijlagen As Boolean = True
    Friend WithEvents TabPageVera As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxVeraReport As System.Windows.Forms.TextBox
    Friend WithEvents LabelVeraReport As System.Windows.Forms.Label
    Friend WithEvents CheckBoxVera As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxVeraLink As System.Windows.Forms.TextBox
    Friend WithEvents LabelVeraLink As System.Windows.Forms.Label
    Friend WithEvents CheckBoxReportContractant As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipControls As System.Windows.Forms.ToolTip
    Private _typeBrOfBew As brandweerOfBewaking

    Public Event NieuwBestemmelingen(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event IKPReportChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents OpenFileDialogBijlagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControlOverige As System.Windows.Forms.TabControl
    Friend WithEvents TabPageOpgemaakt As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxHoofd As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPostoverste As System.Windows.Forms.TextBox
    Friend WithEvents LabelPostoverste As System.Windows.Forms.Label
    Friend WithEvents LabelDoor As System.Windows.Forms.Label
    Friend WithEvents LabelOpgemaakt As System.Windows.Forms.Label
    Friend WithEvents TabPageBijlage As System.Windows.Forms.TabPage
    Friend WithEvents ButtonDeleteBijlage As System.Windows.Forms.Button
    Friend WithEvents ButtonNewBijlage As System.Windows.Forms.Button
    Friend WithEvents UltraGridBijlage As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TabPageBestemmelingen As System.Windows.Forms.TabPage
    Friend WithEvents ButtonDeleteBest As System.Windows.Forms.Button
    Friend WithEvents ButtonNieuwBest As System.Windows.Forms.Button
    Friend WithEvents CheckBoxBijlage As System.Windows.Forms.CheckBox
    Friend WithEvents UltraGridBestemmelingen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents CheckBoxBestemmelingen As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonDetailBijlage As System.Windows.Forms.Button
    Friend WithEvents LabelHoofdDienst As System.Windows.Forms.Label
    ' Friend WithEvents _dataPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSPersoneel
    Friend WithEvents UltraComboPersoneel As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataBBPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBPersoneel
    Friend WithEvents _dataBijlagen As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen
    Friend WithEvents _dataBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSConfiguratie
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSIndividuen
    Friend WithEvents UltraDateTimeEditorOpgemaakt As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRPERS", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_PLG_IND")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlGeneralFunctions))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBYLG", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BYLG")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_BYLG")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BYLG")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DOC", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_BYLG", 0)
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
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBST", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BST")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_EMAL_IND")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.OpenFileDialogBijlagen = New System.Windows.Forms.OpenFileDialog()
        Me.TabControlOverige = New System.Windows.Forms.TabControl()
        Me.TabPageOpgemaakt = New System.Windows.Forms.TabPage()
        Me.CheckBoxReportContractant = New System.Windows.Forms.CheckBox()
        Me.UltraDateTimeEditorOpgemaakt = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraComboPersoneel = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataBBPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBPersoneel()
        Me.TextBoxHoofd = New System.Windows.Forms.TextBox()
        Me.LabelHoofdDienst = New System.Windows.Forms.Label()
        Me.TextBoxPostoverste = New System.Windows.Forms.TextBox()
        Me.LabelPostoverste = New System.Windows.Forms.Label()
        Me.LabelDoor = New System.Windows.Forms.Label()
        Me.LabelOpgemaakt = New System.Windows.Forms.Label()
        Me.TabPageBijlage = New System.Windows.Forms.TabPage()
        Me.ButtonDeleteBijlage = New System.Windows.Forms.Button()
        Me.ButtonNewBijlage = New System.Windows.Forms.Button()
        Me.ButtonDetailBijlage = New System.Windows.Forms.Button()
        Me.UltraGridBijlage = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBijlagen = New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen()
        Me.TabPageBestemmelingen = New System.Windows.Forms.TabPage()
        Me.ButtonDeleteBest = New System.Windows.Forms.Button()
        Me.ButtonNieuwBest = New System.Windows.Forms.Button()
        Me.UltraGridBestemmelingen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBestemmelingen = New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen()
        Me.TabPageVera = New System.Windows.Forms.TabPage()
        Me.TextBoxVeraLink = New System.Windows.Forms.TextBox()
        Me.LabelVeraLink = New System.Windows.Forms.Label()
        Me.TextBoxVeraReport = New System.Windows.Forms.TextBox()
        Me.LabelVeraReport = New System.Windows.Forms.Label()
        Me.CheckBoxBestemmelingen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBijlage = New System.Windows.Forms.CheckBox()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSConfiguratie()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSIndividuen()
        Me.CheckBoxVera = New System.Windows.Forms.CheckBox()
        Me.ToolTipControls = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControlOverige.SuspendLayout()
        Me.TabPageOpgemaakt.SuspendLayout()
        CType(Me.UltraDateTimeEditorOpgemaakt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBBPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBijlage.SuspendLayout()
        CType(Me.UltraGridBijlage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBijlagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBestemmelingen.SuspendLayout()
        CType(Me.UltraGridBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVera.SuspendLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlOverige
        '
        Me.TabControlOverige.Controls.Add(Me.TabPageOpgemaakt)
        Me.TabControlOverige.Controls.Add(Me.TabPageBijlage)
        Me.TabControlOverige.Controls.Add(Me.TabPageBestemmelingen)
        Me.TabControlOverige.Controls.Add(Me.TabPageVera)
        Me.TabControlOverige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlOverige.ItemSize = New System.Drawing.Size(73, 18)
        Me.TabControlOverige.Location = New System.Drawing.Point(0, 0)
        Me.TabControlOverige.Name = "TabControlOverige"
        Me.TabControlOverige.SelectedIndex = 0
        Me.TabControlOverige.Size = New System.Drawing.Size(512, 120)
        Me.TabControlOverige.TabIndex = 0
        '
        'TabPageOpgemaakt
        '
        Me.TabPageOpgemaakt.Controls.Add(Me.CheckBoxReportContractant)
        Me.TabPageOpgemaakt.Controls.Add(Me.UltraDateTimeEditorOpgemaakt)
        Me.TabPageOpgemaakt.Controls.Add(Me.UltraComboPersoneel)
        Me.TabPageOpgemaakt.Controls.Add(Me.TextBoxHoofd)
        Me.TabPageOpgemaakt.Controls.Add(Me.LabelHoofdDienst)
        Me.TabPageOpgemaakt.Controls.Add(Me.TextBoxPostoverste)
        Me.TabPageOpgemaakt.Controls.Add(Me.LabelPostoverste)
        Me.TabPageOpgemaakt.Controls.Add(Me.LabelDoor)
        Me.TabPageOpgemaakt.Controls.Add(Me.LabelOpgemaakt)
        Me.TabPageOpgemaakt.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOpgemaakt.Name = "TabPageOpgemaakt"
        Me.TabPageOpgemaakt.Size = New System.Drawing.Size(504, 94)
        Me.TabPageOpgemaakt.TabIndex = 0
        Me.TabPageOpgemaakt.Text = "Opmaak Info"
        '
        'CheckBoxReportContractant
        '
        Me.CheckBoxReportContractant.AutoSize = True
        Me.CheckBoxReportContractant.Location = New System.Drawing.Point(11, 66)
        Me.CheckBoxReportContractant.Name = "CheckBoxReportContractant"
        Me.CheckBoxReportContractant.Size = New System.Drawing.Size(137, 17)
        Me.CheckBoxReportContractant.TabIndex = 9
        Me.CheckBoxReportContractant.Text = "Verslag ivm contractant"
        Me.CheckBoxReportContractant.UseVisualStyleBackColor = True
        '
        'UltraDateTimeEditorOpgemaakt
        '
        Me.UltraDateTimeEditorOpgemaakt.Location = New System.Drawing.Point(96, 8)
        Me.UltraDateTimeEditorOpgemaakt.Name = "UltraDateTimeEditorOpgemaakt"
        Me.UltraDateTimeEditorOpgemaakt.ReadOnly = True
        Me.UltraDateTimeEditorOpgemaakt.Size = New System.Drawing.Size(104, 21)
        Me.UltraDateTimeEditorOpgemaakt.TabIndex = 8
        Me.UltraDateTimeEditorOpgemaakt.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraComboPersoneel
        '
        Me.UltraComboPersoneel.DataSource = Me._dataBBPersoneel
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboPersoneel.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Naam"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Voornaam"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.Caption = "Ploeg"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.UltraComboPersoneel.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboPersoneel.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboPersoneel.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboPersoneel.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboPersoneel.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraComboPersoneel.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboPersoneel.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraComboPersoneel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboPersoneel.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboPersoneel.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboPersoneel.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraComboPersoneel.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboPersoneel.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboPersoneel.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboPersoneel.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraComboPersoneel.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboPersoneel.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboPersoneel.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraComboPersoneel.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraComboPersoneel.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboPersoneel.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboPersoneel.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboPersoneel.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraComboPersoneel.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboPersoneel.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraComboPersoneel.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboPersoneel.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboPersoneel.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboPersoneel.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboPersoneel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboPersoneel.Location = New System.Drawing.Point(96, 40)
        Me.UltraComboPersoneel.Name = "UltraComboPersoneel"
        Me.UltraComboPersoneel.Size = New System.Drawing.Size(104, 22)
        Me.UltraComboPersoneel.TabIndex = 3
        Me.UltraComboPersoneel.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataBBPersoneel
        '
        Me._dataBBPersoneel.DataSetName = "TDSBBPersoneel"
        Me._dataBBPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBBPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxHoofd
        '
        Me.TextBoxHoofd.Enabled = False
        Me.TextBoxHoofd.Location = New System.Drawing.Point(352, 40)
        Me.TextBoxHoofd.Name = "TextBoxHoofd"
        Me.TextBoxHoofd.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxHoofd.TabIndex = 7
        '
        'LabelHoofdDienst
        '
        Me.LabelHoofdDienst.Location = New System.Drawing.Point(224, 40)
        Me.LabelHoofdDienst.Name = "LabelHoofdDienst"
        Me.LabelHoofdDienst.Size = New System.Drawing.Size(136, 23)
        Me.LabelHoofdDienst.TabIndex = 6
        Me.LabelHoofdDienst.Text = "Hoofd bedrijfsbeveiliging:"
        Me.LabelHoofdDienst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPostoverste
        '
        Me.TextBoxPostoverste.Enabled = False
        Me.TextBoxPostoverste.Location = New System.Drawing.Point(352, 8)
        Me.TextBoxPostoverste.Name = "TextBoxPostoverste"
        Me.TextBoxPostoverste.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxPostoverste.TabIndex = 5
        '
        'LabelPostoverste
        '
        Me.LabelPostoverste.Location = New System.Drawing.Point(224, 8)
        Me.LabelPostoverste.Name = "LabelPostoverste"
        Me.LabelPostoverste.Size = New System.Drawing.Size(100, 23)
        Me.LabelPostoverste.TabIndex = 4
        Me.LabelPostoverste.Text = "Postoverste:"
        Me.LabelPostoverste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDoor
        '
        Me.LabelDoor.Location = New System.Drawing.Point(8, 40)
        Me.LabelDoor.Name = "LabelDoor"
        Me.LabelDoor.Size = New System.Drawing.Size(48, 23)
        Me.LabelDoor.TabIndex = 2
        Me.LabelDoor.Text = "Door:"
        Me.LabelDoor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOpgemaakt
        '
        Me.LabelOpgemaakt.Location = New System.Drawing.Point(8, 8)
        Me.LabelOpgemaakt.Name = "LabelOpgemaakt"
        Me.LabelOpgemaakt.Size = New System.Drawing.Size(88, 23)
        Me.LabelOpgemaakt.TabIndex = 0
        Me.LabelOpgemaakt.Text = "Opgemaakt op:"
        Me.LabelOpgemaakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageBijlage
        '
        Me.TabPageBijlage.Controls.Add(Me.ButtonDeleteBijlage)
        Me.TabPageBijlage.Controls.Add(Me.ButtonNewBijlage)
        Me.TabPageBijlage.Controls.Add(Me.ButtonDetailBijlage)
        Me.TabPageBijlage.Controls.Add(Me.UltraGridBijlage)
        Me.TabPageBijlage.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBijlage.Name = "TabPageBijlage"
        Me.TabPageBijlage.Size = New System.Drawing.Size(504, 94)
        Me.TabPageBijlage.TabIndex = 1
        Me.TabPageBijlage.Text = "Bijlagen        "
        Me.TabPageBijlage.Visible = False
        '
        'ButtonDeleteBijlage
        '
        Me.ButtonDeleteBijlage.Enabled = False
        Me.ButtonDeleteBijlage.Image = CType(resources.GetObject("ButtonDeleteBijlage.Image"), System.Drawing.Image)
        Me.ButtonDeleteBijlage.Location = New System.Drawing.Point(477, 60)
        Me.ButtonDeleteBijlage.Name = "ButtonDeleteBijlage"
        Me.ButtonDeleteBijlage.Size = New System.Drawing.Size(24, 24)
        Me.ButtonDeleteBijlage.TabIndex = 3
        '
        'ButtonNewBijlage
        '
        Me.ButtonNewBijlage.Image = CType(resources.GetObject("ButtonNewBijlage.Image"), System.Drawing.Image)
        Me.ButtonNewBijlage.Location = New System.Drawing.Point(477, 8)
        Me.ButtonNewBijlage.Name = "ButtonNewBijlage"
        Me.ButtonNewBijlage.Size = New System.Drawing.Size(24, 24)
        Me.ButtonNewBijlage.TabIndex = 1
        '
        'ButtonDetailBijlage
        '
        Me.ButtonDetailBijlage.Enabled = False
        Me.ButtonDetailBijlage.Image = CType(resources.GetObject("ButtonDetailBijlage.Image"), System.Drawing.Image)
        Me.ButtonDetailBijlage.Location = New System.Drawing.Point(477, 34)
        Me.ButtonDetailBijlage.Name = "ButtonDetailBijlage"
        Me.ButtonDetailBijlage.Size = New System.Drawing.Size(24, 24)
        Me.ButtonDetailBijlage.TabIndex = 2
        '
        'UltraGridBijlage
        '
        Me.UltraGridBijlage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraGridBijlage.DataMember = "BBBYLG"
        Me.UltraGridBijlage.DataSource = Me._dataBijlagen
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridBijlage.DisplayLayout.Appearance = Appearance14
        Me.UltraGridBijlage.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.Header.Caption = "Plaats"
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.Width = 77
        UltraGridColumn27.Header.Caption = "Omschrijving"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.Width = 119
        UltraGridColumn28.Header.Caption = "Docum. ChronicleID "
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.Width = 117
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.Caption = "Naam"
        UltraGridColumn29.Header.VisiblePosition = 3
        UltraGridColumn29.Width = 121
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.UltraGridBijlage.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridBijlage.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBijlage.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBijlage.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBijlage.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.UltraGridBijlage.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBijlage.DisplayLayout.GroupByBox.Hidden = True
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBijlage.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.UltraGridBijlage.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridBijlage.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridBijlage.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridBijlage.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UltraGridBijlage.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridBijlage.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridBijlage.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridBijlage.DisplayLayout.Override.CellAppearance = Appearance21
        Me.UltraGridBijlage.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridBijlage.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBijlage.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Left"
        Me.UltraGridBijlage.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.UltraGridBijlage.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridBijlage.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridBijlage.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridBijlage.DisplayLayout.Override.RowAppearance = Appearance25
        Me.UltraGridBijlage.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridBijlage.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridBijlage.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.UltraGridBijlage.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridBijlage.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridBijlage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridBijlage.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBijlage.Name = "UltraGridBijlage"
        Me.UltraGridBijlage.Size = New System.Drawing.Size(472, 96)
        Me.UltraGridBijlage.TabIndex = 0
        Me.UltraGridBijlage.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataBijlagen
        '
        Me._dataBijlagen.DataSetName = "TDSBijlagen"
        Me._dataBijlagen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBijlagen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPageBestemmelingen
        '
        Me.TabPageBestemmelingen.Controls.Add(Me.ButtonDeleteBest)
        Me.TabPageBestemmelingen.Controls.Add(Me.ButtonNieuwBest)
        Me.TabPageBestemmelingen.Controls.Add(Me.UltraGridBestemmelingen)
        Me.TabPageBestemmelingen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBestemmelingen.Name = "TabPageBestemmelingen"
        Me.TabPageBestemmelingen.Size = New System.Drawing.Size(504, 94)
        Me.TabPageBestemmelingen.TabIndex = 2
        Me.TabPageBestemmelingen.Text = "Bestemmelingen         "
        Me.TabPageBestemmelingen.Visible = False
        '
        'ButtonDeleteBest
        '
        Me.ButtonDeleteBest.Image = CType(resources.GetObject("ButtonDeleteBest.Image"), System.Drawing.Image)
        Me.ButtonDeleteBest.Location = New System.Drawing.Point(477, 60)
        Me.ButtonDeleteBest.Name = "ButtonDeleteBest"
        Me.ButtonDeleteBest.Size = New System.Drawing.Size(24, 24)
        Me.ButtonDeleteBest.TabIndex = 2
        '
        'ButtonNieuwBest
        '
        Me.ButtonNieuwBest.Image = CType(resources.GetObject("ButtonNieuwBest.Image"), System.Drawing.Image)
        Me.ButtonNieuwBest.Location = New System.Drawing.Point(477, 8)
        Me.ButtonNieuwBest.Name = "ButtonNieuwBest"
        Me.ButtonNieuwBest.Size = New System.Drawing.Size(24, 24)
        Me.ButtonNieuwBest.TabIndex = 1
        '
        'UltraGridBestemmelingen
        '
        Me.UltraGridBestemmelingen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UltraGridBestemmelingen.DataMember = "BBBST"
        Me.UltraGridBestemmelingen.DataSource = Me._dataBestemmelingen
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridBestemmelingen.DisplayLayout.Appearance = Appearance27
        Me.UltraGridBestemmelingen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn34.Header.Caption = "Naam"
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Width = 109
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.Header.Caption = "Voornaam"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Width = 115
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.Caption = "Emailadres"
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Width = 210
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.UltraGridBestemmelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraGridBestemmelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBestemmelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance28.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.Appearance = Appearance28
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance29
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.Hidden = True
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance30.BackColor2 = System.Drawing.SystemColors.Control
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance30
        Me.UltraGridBestemmelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridBestemmelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.UltraGridBestemmelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridBestemmelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CardAreaAppearance = Appearance33
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellAppearance = Appearance34
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance37
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowAppearance = Appearance38
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridBestemmelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance39
        Me.UltraGridBestemmelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridBestemmelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridBestemmelingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridBestemmelingen.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBestemmelingen.Name = "UltraGridBestemmelingen"
        Me.UltraGridBestemmelingen.Size = New System.Drawing.Size(472, 96)
        Me.UltraGridBestemmelingen.TabIndex = 0
        Me.UltraGridBestemmelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataBestemmelingen
        '
        Me._dataBestemmelingen.DataSetName = "TDSBBBestemmelingen"
        Me._dataBestemmelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBestemmelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPageVera
        '
        Me.TabPageVera.Controls.Add(Me.TextBoxVeraLink)
        Me.TabPageVera.Controls.Add(Me.LabelVeraLink)
        Me.TabPageVera.Controls.Add(Me.TextBoxVeraReport)
        Me.TabPageVera.Controls.Add(Me.LabelVeraReport)
        Me.TabPageVera.Location = New System.Drawing.Point(4, 22)
        Me.TabPageVera.Name = "TabPageVera"
        Me.TabPageVera.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageVera.Size = New System.Drawing.Size(504, 94)
        Me.TabPageVera.TabIndex = 3
        Me.TabPageVera.Text = "Vera            "
        Me.TabPageVera.UseVisualStyleBackColor = True
        '
        'TextBoxVeraLink
        '
        Me.TextBoxVeraLink.Location = New System.Drawing.Point(80, 38)
        Me.TextBoxVeraLink.Multiline = True
        Me.TextBoxVeraLink.Name = "TextBoxVeraLink"
        Me.TextBoxVeraLink.Size = New System.Drawing.Size(338, 50)
        Me.TextBoxVeraLink.TabIndex = 4
        '
        'LabelVeraLink
        '
        Me.LabelVeraLink.AutoSize = True
        Me.LabelVeraLink.Location = New System.Drawing.Point(6, 41)
        Me.LabelVeraLink.Name = "LabelVeraLink"
        Me.LabelVeraLink.Size = New System.Drawing.Size(51, 13)
        Me.LabelVeraLink.TabIndex = 3
        Me.LabelVeraLink.Text = "Vera link:"
        '
        'TextBoxVeraReport
        '
        Me.TextBoxVeraReport.Location = New System.Drawing.Point(80, 12)
        Me.TextBoxVeraReport.Name = "TextBoxVeraReport"
        Me.TextBoxVeraReport.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVeraReport.TabIndex = 2
        '
        'LabelVeraReport
        '
        Me.LabelVeraReport.AutoSize = True
        Me.LabelVeraReport.Location = New System.Drawing.Point(6, 15)
        Me.LabelVeraReport.Name = "LabelVeraReport"
        Me.LabelVeraReport.Size = New System.Drawing.Size(68, 13)
        Me.LabelVeraReport.TabIndex = 0
        Me.LabelVeraReport.Text = "Vera rapport:"
        '
        'CheckBoxBestemmelingen
        '
        Me.CheckBoxBestemmelingen.Enabled = False
        Me.CheckBoxBestemmelingen.Location = New System.Drawing.Point(240, 5)
        Me.CheckBoxBestemmelingen.Name = "CheckBoxBestemmelingen"
        Me.CheckBoxBestemmelingen.Size = New System.Drawing.Size(16, 16)
        Me.CheckBoxBestemmelingen.TabIndex = 2
        '
        'CheckBoxBijlage
        '
        Me.CheckBoxBijlage.Enabled = False
        Me.CheckBoxBijlage.Location = New System.Drawing.Point(128, 5)
        Me.CheckBoxBijlage.Name = "CheckBoxBijlage"
        Me.CheckBoxBijlage.Size = New System.Drawing.Size(16, 16)
        Me.CheckBoxBijlage.TabIndex = 1
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfig"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBoxVera
        '
        Me.CheckBoxVera.Enabled = False
        Me.CheckBoxVera.Location = New System.Drawing.Point(299, 5)
        Me.CheckBoxVera.Name = "CheckBoxVera"
        Me.CheckBoxVera.Size = New System.Drawing.Size(16, 16)
        Me.CheckBoxVera.TabIndex = 3
        '
        'UserControlGeneralFunctions
        '
        Me.AutoSize = True
        Me.Controls.Add(Me.CheckBoxVera)
        Me.Controls.Add(Me.CheckBoxBestemmelingen)
        Me.Controls.Add(Me.CheckBoxBijlage)
        Me.Controls.Add(Me.TabControlOverige)
        Me.Name = "UserControlGeneralFunctions"
        Me.Size = New System.Drawing.Size(512, 120)
        Me.TabControlOverige.ResumeLayout(False)
        Me.TabPageOpgemaakt.ResumeLayout(False)
        Me.TabPageOpgemaakt.PerformLayout()
        CType(Me.UltraDateTimeEditorOpgemaakt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBBPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBijlage.ResumeLayout(False)
        CType(Me.UltraGridBijlage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBijlagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBestemmelingen.ResumeLayout(False)
        CType(Me.UltraGridBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVera.ResumeLayout(False)
        Me.TabPageVera.PerformLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Bijlage Methods & Buttonevents"

    Private Sub ButtonNewBijlage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewBijlage.Click
        'Doel:   Toevoegen van gekozen bijlagen (indien nog niet in grid)
        'Auteur: Koen - Rajiv - 07/04/2006
        Try
            Me.OpenFileDialogBijlagen.Multiselect = True
            Me.OpenFileDialogBijlagen.Title = "Kies de bijlage(n)"

            Dim path As String
            If Me._typeBrOfBew = brandweerOfBewaking.brandweer Then
                path = Me._dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_BRANDWEER", "PATH").WD()
            Else
                path = Me._dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_BEWAKING", "PATH").WD()
            End If

            Me.OpenFileDialogBijlagen.InitialDirectory = path
            Me.OpenFileDialogBijlagen.ShowDialog()

            Dim arrayTemp As New ArrayList(Me.OpenFileDialogBijlagen.FileNames())
            'Controle geldig path
            Dim i As Integer
            'Dim fileName As String
            Dim ongeldigPath As Boolean = False
            For i = 0 To arrayTemp.Count - 1
                If CStr(arrayTemp(i)).ToLower.StartsWith(path.ToLower) = True Then
                    'OK
                Else
                    ongeldigPath = True
                    MessageBox.Show("Gelieve een file selecteren uit de map: " & path, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next


            Me.OpenFileDialogBijlagen.Reset()

            If arrayTemp.Count <> 0 Then
                If _flagEmptyBijlagen Then
                    voegBijlagenToe(arrayTemp)
                Else
                    Dim pathArray As New ArrayList
                    For Each row As UltraGridRow In UltraGridBijlage.Rows
                        pathArray.Add(row.Cells("PLA_BYLG").Value)
                    Next
                    'For Each str As String In arrayTemp
                    '    If pathArray.Contains(str) Then
                    '        arrayTemp.Remove(str)
                    '    End If
                    'Next
                    If arrayTemp.Count <> 0 Then
                        voegBijlagenToe(arrayTemp)
                    End If
                End If
            End If

            checkEmptyBijlagen(UltraGridBijlage.Rows.Count)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "UsercontrolGeneralFunctions - ButtonNewBijlage_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonDetailBijlage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDetailBijlage.Click
        'Doel:   Bestand openen
        '        DUMI: Als het document reeds werd opgeladen in documentum, dient dit te worden geopend
        '         Wanneer er zich een probleem voordoet met documentum, kan alsnog geprobeerd worden de file op de pc te openen.
        'Auteur: Koen - Rajiv - 07/04/2006
        If IsDBNull(Me.UltraGridBijlage.ActiveRow.Cells("ID_DOC").Value) Then
            bekijkDetail(Me.UltraGridBijlage.ActiveRow.Cells("PLA_BYLG").Value)
        Else
            If (OpenDocumentumFile(Me.UltraGridBijlage.ActiveRow.Cells("ID_DOC").Value)) = False Then
                bekijkDetail(Me.UltraGridBijlage.ActiveRow.Cells("PLA_BYLG").Value)
            End If
        End If
    End Sub

    Private Sub UltraGridBijlage_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridBijlage.DoubleClickRow
        'Doel:   Bestand openen
        'Auteur: Koen - Rajiv - 07/04/2006
        '        DUMI: Als het document reeds werd opgeladen in documentum, dient dit te worden geopend
        '         Wanneer er zich een probleem voordoet met documentum, kan alsnog geprobeerd worden de file op de pc te openen.
        If IsDBNull(Me.UltraGridBijlage.ActiveRow.Cells("ID_DOC").Value) Then
            bekijkDetail(Me.UltraGridBijlage.ActiveRow.Cells("PLA_BYLG").Value)
        Else
            If (OpenDocumentumFile(Me.UltraGridBijlage.ActiveRow.Cells("ID_DOC").Value)) = False Then
                bekijkDetail(Me.UltraGridBijlage.ActiveRow.Cells("PLA_BYLG").Value)
            End If
        End If
    End Sub

    Private Sub ButtonDeleteBijlage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteBijlage.Click
        'Doel:   Verwijdert een geselecteerde rij uit de grid
        'Auteur: Koen - Rajiv - 07/04/2006
        If UltraGridBijlage.ActiveRow.Activated = True Then
            'Dien - 27 dec 2006 - verwijderen bijlagen.
            UltraGridBijlage.ActiveRow.Delete(True)
        End If
    End Sub

    Private Sub voegBijlagenToe(ByVal bijlagen As ArrayList)
        'Doel:   Nieuwe bijlagen laten tonen in de grid
        'Auteur: Koen - Rajiv - 07/04/2006
        Dim max As Integer
        Dim r As TDSBijlagen.BBBYLGRow = Nothing
        Do
            max = (Now.Year * Now.Month * Now.Day + Now.Hour + Now.Minute + Now.Second + Now.Millisecond) * 1000 + Now.Millisecond
            r = Me._dataBijlagen.BBBYLG.FindByID_BYLG(max)
        Loop While Not r Is Nothing

        For Each gegeven As String In bijlagen
            Dim newRow As DataRow = _dataBijlagen.BBBYLG.NewRow
            'newRow.Item("ID_BYLG") = max
            newRow.Item("PLA_BYLG") = gegeven
            _dataBijlagen.BBBYLG.Rows.Add(newRow)
        Next
    End Sub
    Private Sub deleteBijlageInDocumentum(ByVal chronicleID As String)
        'Doel:   Verwijderen van de bijlage in documentum
        'Auteur: DUMI - Juli 2007
        'Bij het verwijderen van één of meerdere bijlagen uit de grid, de chronicle id(s) bijhouden in een array
        'en vervolgens bij bewaren één voor één verwijderen uit documentum.
        'delete
        Dim documentumService As New Proxy.BBWServiceDocumentumServicesProxy
        Dim user As String = System.Environment.UserName

        Try
            documentumService.DeleteDocument(chronicleID, user)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Er is een fout opgetreden bij het verwijderen van de bijlage in Documentum", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine(ex.StackTrace)
        End Try

    End Sub
    Private Sub bekijkDetail(ByVal path As String)
        'Doel:   Bestand openen (pad wordt meegegeven)
        'Auteur: Koen - Rajiv - 07/04/2006
        Try
            Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process
            myProcess.StartInfo.FileName = path
            myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            myProcess.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fout Openen Bijlage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Debug.WriteLine(ex.StackTrace)
        End Try
    End Sub
    Private Function OpenDocumentumFile(ByVal chronicleID As String) As Boolean
        'Doel:   Ophalen van het bestand uit documentum (chronicleID wordt meegegeven)
        '       Returns true als het bestand kan geopend worden, false wanneer er zich bvb een probleem voordoet in documentum
        'Auteur: Dumi - Juli 2007
        Dim documentumService As New Proxy.BBWServiceDocumentumServicesProxy
        Dim fs As FileStream
        Dim content As Byte()
        Dim directoryPath As String
        Dim fileName As String = ""
        Dim filePath As String
        Dim user As String = System.Environment.UserName
        Call DeleteOldFiles()

        Try
            content = documentumService.GetContent(chronicleID, user, fileName)
            directoryPath = Me._dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_GET_DOCUMENTUM", "Path").WD()

            If (Not Directory.Exists(directoryPath)) Then
                Directory.CreateDirectory(directoryPath)
            End If

            filePath = Path.Combine(directoryPath, fileName)

            fs = New FileStream(filePath, System.IO.FileMode.Create)
            fs.Write(content, 0, content.Length)
            fs.Close()

            Process.Start(filePath)

            Return True

        Catch ex As Exception
            'Wanneer de file reeds geopend staat op de pc, krijgen we een error.
            'Wanneer er een probleem is met documentum, kan alsnog geprobeerd worden de file op de PC te openen.
            If (MsgBox("Er is een probleem gedetecteerd bij het openen van het document: " & fileName & " Staat het document reeds geopend?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "File openen") = MsgBoxResult.Yes) Then
                Return True
            Else
                Return False
            End If
            Exit Function
        End Try
    End Function
    Private Function DeleteOldFiles() As Boolean
        'Doel:   Verwijderen van alle files die ouder zijn dan 1 dag
        '           RETURNS: True, if succesful
        '           False otherwise (e.g.deletion fails because file is in use, file doesn't exist, etc.)
        'Auteur: Dumi - Juli 2007
        Dim sFileSpec As String
        'Dim dCompDate As Date
        Dim sFileName As String
        Dim sFileSplit() As String
        Dim iCtr As Integer, iCount As Integer
        Dim sDir As String = ""

        Try
            sFileSpec = Me._dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_GET_DOCUMENTUM", "Path").WD()
            sFileName = Dir(sFileSpec)
            If sFileName = "" Then
                'returns false is file doesn't exist
                DeleteOldFiles = False
                Exit Function
            End If

            Do
                If InStr(sFileSpec, "\") > 0 Then
                    sFileSplit = Split(sFileSpec, "\")
                    iCount = UBound(sFileSplit) - 1
                    For iCtr = 0 To iCount
                        sDir &= sFileSplit(iCtr) & "\"
                    Next
                    sFileName = sDir & sFileName
                End If

                If DateDiff("d", FileDateTime(sFileName), Now) >= 1 Then
                    Kill(sFileName)
                End If

                sFileName = Dir()
                sDir = ""
            Loop

            DeleteOldFiles = True

            Exit Function
        Catch ex As Exception
            DeleteOldFiles = True
            Exit Function
        End Try
    End Function

    Public Sub setBijlageData(ByVal bijlageTable As DataTable)
        'Doel:   Dataset opvullen met meegekregen tabel
        'Auteur: Koen - Rajiv - 19/04/2006
        _dataBijlagen.Clear()
        _dataBijlagen.Merge(bijlageTable)


        checkEmptyBijlagen(_dataBijlagen.BBBYLG.Rows.Count)


    End Sub
    'Public Sub FillBijlageGrid(ByVal bijlageTable As DataTable)
    '    'Doel:   Dataset opvullen met meegekregen tabel
    '    'Auteur: Koen - Rajiv - 19/04/2006
    '    _dataBijlagen.Clear()
    '    _dataBijlagen.Merge(bijlageTable)
    '    checkEmptyBijlagen(_dataBijlagen.BBBYLG.Rows.Count)
    'End Sub
    Private Sub checkEmptyBijlagen(ByVal count As Integer)
        'Doel:   Kijken of er bijlagen zijn
        'Auteur: Koen - Rajiv - 07/04/2006
        If count = 0 Then
            _flagEmptyBijlagen = True
            Me.CheckBoxBijlage.Checked = False
            Me.ButtonDetailBijlage.Enabled = False
            Me.ButtonDeleteBijlage.Enabled = False
        Else
            _flagEmptyBijlagen = False
            Me.CheckBoxBijlage.Checked = True
            Me.ButtonDetailBijlage.Enabled = True
            Me.ButtonDeleteBijlage.Enabled = True
        End If

    End Sub

    Private Sub UltraGridBijlage_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridBijlage.InitializeRow
        'Doel:   Van elke rij moet men in de kolom "NM_BYLG" enkel de naam van het bestand
        '        tonen.
        'Auteur: Koen - Rajiv - 19/04/2006
        Dim plaats As String = e.Row.Cells("PLA_BYLG").Text
        e.Row.Cells("NM_BYLG").Value = plaats.Remove(0, plaats.LastIndexOf("\") + 1)
    End Sub

    Private Sub UltraGridBijlage_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridBijlage.AfterRowsDeleted

        checkEmptyBijlagen(UltraGridBijlage.Rows.Count)
    End Sub
#End Region

#Region "Bestemmelingen Methods & Buttonevents"

    Private Sub ButtonNewBest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNieuwBest.Click
        'Doel:   Oproepen individuscherm
        'Auteur: Koen - Rajiv - 24/04/2006
        RaiseEvent NieuwBestemmelingen(sender, e)
    End Sub

    Private Sub ButtonDeleteBest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteBest.Click
        'Doel:   Verwijdert een geselecteerde rij uit de grid
        'Auteur: Koen - Rajiv - 19/04/2006
        If UltraGridBestemmelingen.ActiveRow.Activated = True Then
            UltraGridBestemmelingen.DeleteSelectedRows()
            '_dataBestemmelingen.AcceptChanges()
            checkEmptyBestemmelingen(_dataBestemmelingen.BBBST.Rows.Count)
        End If
    End Sub

    Public Sub setBestemmelingenData(ByVal bestemmelingen As DataTable)
        'Doel:   Dataset opvullen met meegekregen tabel
        'Auteur: Koen - Rajiv - 19/04/2006
        _dataBestemmelingen.Clear()
        _dataBestemmelingen.Merge(bestemmelingen)
        checkEmptyBestemmelingen(_dataBestemmelingen.BBBST.Rows.Count)
    End Sub

    Public Function CheckBestemmelingen(ByVal dsBestemmeling As DataSet) As Boolean
        Dim dr As DataRow
        Dim bBest As Boolean = True

        If (dsBestemmeling.Tables(0).Rows.Count = 0) Then
            MsgBox("Gelieve minstens één bestemmeling voor deze registratie in te geven a.u.b.", MsgBoxStyle.OkOnly, "Bestemmeling")
            Return False
        End If
        'Als alle rijen in de grid werden verwijderd, moet ook een melding worden gegeven
        For Each dr In dsBestemmeling.Tables(0).Rows
            If dr.RowState = DataRowState.Deleted Then
                bBest = False
            Else
                Return True
            End If
        Next
        If bBest = False Then
            MsgBox("Gelieve minstens één bestemmeling voor deze registratie in te geven a.u.b.", MsgBoxStyle.OkOnly, "Bestemmeling")
            Return False
        End If

    End Function

    Private Sub checkEmptyBestemmelingen(ByVal count As Integer)
        'Doel:   Kijken of er bestemmelingen zijn
        'Auteur: Koen - Rajiv - 19/04/2006
        If count = 0 Then
            _flagEmptyBijlagen = True
            Me.CheckBoxBestemmelingen.Checked = False
            Me.ButtonDeleteBest.Enabled = False
        Else
            _flagEmptyBijlagen = False
            Me.CheckBoxBestemmelingen.Checked = True
            Me.ButtonDeleteBest.Enabled = True
        End If
    End Sub

    Public Sub addBestemmeling(ByVal idReg As Integer, ByVal idInd As Integer, ByVal nmInd As String, ByVal vnmInd As String, ByVal adEmalInd As String)
        'Doel:   Voegt een bestemmeling toe aan de dataset
        'Auteur: Koen - Rajiv - 24/04/2006
        Dim bestemRow As DataRow = Me._dataBestemmelingen.BBBST.NewBBBSTRow
        Dim r As TDSBBBestemmelingen.BBBSTRow = Nothing
        Dim max As Integer
        Do
            max = (Now.Year * Now.Month * Now.Day + Now.Hour + Now.Minute + Now.Second + Now.Millisecond) * 1000 + Now.Millisecond
            r = Me._dataBestemmelingen.BBBST.FindByID_BST(max)
        Loop While Not r Is Nothing

        'bestemRow("ID_BST") = max
        bestemRow("ID_REG") = idReg
        bestemRow("ID_IND") = idInd

        bestemRow("NM_IND") = nmInd

        bestemRow("VNM_IND") = vnmInd
        If Not adEmalInd Is Nothing Then
            bestemRow("AD_EMAL_IND") = adEmalInd
        End If

        Try
            If checkOkToevoegen(bestemRow) Then
                Me._dataBestemmelingen.BBBST.Rows.Add(bestemRow)
                checkEmptyBestemmelingen(_dataBestemmelingen.BBBST.Rows.Count)
            Else
                Throw New Exception(bestemRow("NM_IND") & " " & bestemRow("VNM_IND") & " is reeds toegevoegd aan de bestemmelingen.")
            End If
            checkEmptyBestemmelingen(UltraGridBestemmelingen.Rows.Count)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fout in bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub RemoveBestemmeling(ByVal idInd As Integer)
        _dataBestemmelingen.BBBST.RemoveBBBSTRow(_dataBestemmelingen.BBBST.Select("ID_IND=" & idInd)(0))
        _dataBestemmelingen.AcceptChanges()

        checkEmptyBestemmelingen(_dataBestemmelingen.BBBST.Rows.Count)
    End Sub

    Private Function checkOkToevoegen(ByVal bestemRow As DataRow) As Boolean
        'Doel:   Kijkt of een rij nog niet bestaat in de dataset
        'Auteur: Koen - Rajiv - 24/04/2006
        Dim okToevoegen As Boolean = True
        Dim row As UltraGridRow
        'For Each row In Me._dataBestemmelingen.BBBST.Rows
        For Each row In Me.UltraGridBestemmelingen.Rows
            If row.Cells("ID_IND").Value = bestemRow("ID_IND") Then
                okToevoegen = False
            Else
                okToevoegen = True
            End If
        Next
        Return okToevoegen
    End Function

    Private Sub UltraGridBestemmelingen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridBestemmelingen.AfterRowsDeleted
        checkEmptyBestemmelingen(UltraGridBestemmelingen.Rows.Count)
    End Sub

    Private Sub CheckBoxReportContractant_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxReportContractant.CheckedChanged
        RaiseEvent IKPReportChanged(sender, e)
    End Sub

#End Region

#Region "UltracomboPersoneels Methods & Buttonevents"
    Public Sub setPersoneelData(ByVal TDSPersoneel As DataSet)
        'Doel:   Dataset personeel opvullen met meegekregen dataset
        'Auteur: Koen - Rajiv - 19/04/2006
        _dataBBPersoneel.Merge(TDSPersoneel)
        If _dataBBPersoneel.BBBRPERS.Rows.Count() <> 0 Then
            UltraComboPersoneel.DataMember = "BBBRPERS"
        ElseIf _dataBBPersoneel.BBWAKPERS.Rows.Count() <> 0 Then
            UltraComboPersoneel.DataMember = "BBWAKPERS"
        End If
        UltraComboPersoneel.DisplayMember = "NM_IND"
        UltraComboPersoneel.ValueMember = "ID_IND"
    End Sub
#End Region

#Region "Functions"
    Public Function checkPersoneelOK() As Boolean
        Dim errorBool As Boolean = True
        If UltraComboPersoneel.SelectedRow Is Nothing Then
            errorBool = False
        End If
        Return errorBool
    End Function

    Public Function getOpsteller() As String
        Return UltraComboPersoneel.Text
    End Function

    Public Function getDataBestemmelingen() As DataSet
        Return _dataBestemmelingen
    End Function

    Public Function getDataBijlagen() As DataSet
        Return _dataBijlagen
    End Function

    Public Function getOpstelDatum() As DateTime
        Return CType(UltraDateTimeEditorOpgemaakt.Value, DateTime)
    End Function

    Public Sub setDataSetConfiguration(ByVal _dataConfig As DataSet)
        _dataConfiguratie.Merge(_dataConfig)
    End Sub

    Public Sub setDataSetIndividuen(ByVal type As String, ByVal _dataInd As DataSet)
        _dataIndividuen.Merge(_dataInd)
        TextBoxPostoverste.Text = _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Postoverste").WD).NM_IND & _
        " " & _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Postoverste").WD).VNM_IND

        If type = "brandweer" Then
            TextBoxHoofd.Text = _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Verantwoordelijke").WD).NM_IND & _
            " " & _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Verantwoordelijke").WD).VNM_IND
        Else
            TextBoxHoofd.Text = _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Bedrijfsbeveiliging").WD).NM_IND & _
            " " & _dataIndividuen.BBIND.FindByID_IND(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Bedrijfsbeveiliging").WD).VNM_IND
        End If
    End Sub

    Public Sub setLabelVerplicht()
        LabelDoor.Text &= " *"
    End Sub

    Public Sub SetVeraData(ByVal veraReference As String,
                           ByVal veraLink As String)

        TextBoxVeraLink.Text = veraLink
        TextBoxVeraReport.Text = veraReference
        If Not (TextBoxVeraReport.Text.Trim().Equals(String.Empty)) Then
            CheckBoxVera.Checked = True
        End If
        If veraLink.Equals(String.Empty) Then
            TextBoxVeraLink.Text = _myProxy.GetBaseLinkVera() & TextBoxVeraReport.Text
        End If
    End Sub

    Public Sub clearDate()
        Me.UltraDateTimeEditorOpgemaakt.Value = Nothing
    End Sub

    Public Sub lockControls()
        Me.UltraDateTimeEditorOpgemaakt.ReadOnly = True
        Me.UltraComboPersoneel.ReadOnly = True
        Me.ButtonNewBijlage.Enabled = False
        Me.ButtonDeleteBijlage.Enabled = False
        Me.ButtonDetailBijlage.Enabled = False
        Me.ButtonNieuwBest.Enabled = False
        Me.ButtonDeleteBest.Enabled = False
        Me.UltraGridBijlage.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Public Sub lockControlsMilieuDienst()
        Me.UltraDateTimeEditorOpgemaakt.ReadOnly = True
        Me.UltraComboPersoneel.ReadOnly = True
        Me.ButtonNewBijlage.Enabled = False
        Me.ButtonDeleteBijlage.Enabled = False
        Me.ButtonDetailBijlage.Enabled = True
        Me.ButtonNieuwBest.Enabled = False
        Me.ButtonDeleteBest.Enabled = False
        Me.UltraGridBijlage.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
    End Sub
#End Region
#Region "Properties"
    Property Opsteller() As Integer
        Get
            Return CInt(UltraComboPersoneel.Value)
        End Get
        Set(ByVal Value As Integer)
            UltraComboPersoneel.Value = Value
        End Set
    End Property

    Property DatumOpstelling() As DateTime
        Get
            Return CType(UltraDateTimeEditorOpgemaakt.Value, DateTime)
        End Get
        Set(ByVal Value As DateTime)
            UltraDateTimeEditorOpgemaakt.Value = Value
        End Set
    End Property
    Public Property typeBrOfBew() As brandweerOfBewaking
        Get
            Return Me._typeBrOfBew
        End Get
        Set(ByVal Value As brandweerOfBewaking)
            Me._typeBrOfBew = Value
        End Set
    End Property
    Public Property GetReportContractant As Boolean
        Get
            Return CheckBoxReportContractant.Checked
        End Get
        Set(value As Boolean)
            CheckBoxReportContractant.Checked = value
        End Set
    End Property
    Public ReadOnly Property GetVeraReference() As String
        Get
            Return TextBoxVeraReport.Text
        End Get
    End Property
    Public ReadOnly Property GetVeraLink() As String
        Get

            If (TextBoxVeraLink.Text.Contains("?")) Then
                Return TextBoxVeraLink.Text.Substring(0, TextBoxVeraLink.Text.IndexOf("?"))
            Else
                Return TextBoxVeraLink.Text
            End If

        End Get
    End Property
#End Region


    Private Sub UserControlGeneralFunctions_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            'Add any initialization after the InitializeComponent() call
            Me.setLabelVerplicht()
            _myProxy = New BBWServiceManagementServicesProxy()
            ToolTipControls.SetToolTip(Me.CheckBoxReportContractant, "Bij aanvinken wordt IKP als bestemmeling toegevoegd")
        End If

    End Sub

    Private Sub TextBoxVeraLink_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBoxVeraLink.MouseDoubleClick
        Dim basicUrl As String = System.Configuration.ConfigurationManager.AppSettings.Get("VeraBasicUrl")

        If Not TextBoxVeraLink.Text.Equals(String.Empty) Then

            If TextBoxVeraLink.Text.Contains(basicUrl) Then
                System.Diagnostics.Process.Start(TextBoxVeraLink.Text)
            Else
                MessageBox.Show("Het pad dat u ingaf is ongekend in het systeem," &
                                "Gelieve een geldig pad te voorzien", "Foutief pad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub TextBoxVeraReport_Leave(sender As System.Object, e As System.EventArgs) Handles TextBoxVeraReport.Leave
        Dim baseLinkVera As String = _myProxy.GetBaseLinkVera()

        If (TextBoxVeraReport.Text.Trim.Equals(String.Empty)) Then
            CheckBoxVera.Checked = False
            Exit Sub
        End If
        If (TextBoxVeraLink.Text.Equals(String.Empty) And Not baseLinkVera.Equals(String.Empty)) Then
            Dim url As New System.Uri(baseLinkVera & TextBoxVeraReport.Text)
            Dim req As System.Net.WebRequest
            req = System.Net.WebRequest.Create(url)
            'Dim resp As System.Net.WebResponse

            Try
                'resp = req.GetResponse()
                'If Not resp.ResponseUri.AbsoluteUri.ToString.Equals(baseLinkVera & TextBoxVeraReport.Text) Then
                '    Throw New Exception
                'End If

                'resp.Close()
                'req = Nothing

                'If Not (My.Computer.Network.IsAvailable AndAlso My.Computer.Network.Ping(baseLinkVera & TextBoxVeraReport.Text, 1000)) Then
                '    Throw New Exception
                'End If
                Using myClient As New WebClient
                    myClient.DownloadString(baseLinkVera & TextBoxVeraReport.Text)
                End Using

            Catch ex As Exception
                Exit Sub
            End Try

            TextBoxVeraLink.Text = baseLinkVera & TextBoxVeraReport.Text
        End If
    End Sub
End Class

