Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormDagverslagInlichtingenOverzicht
    Inherits System.Windows.Forms.Form

    Private _aProxy As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
    Private _currentTdsDagverslagInlichtingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingen
    Private _currentTdsInlichtingenTypes As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType

    Private _arrNieuweRegistraties As ArrayList
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me._aProxy = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
        Me._arrNieuweRegistraties = New ArrayList
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
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblOverzichtVan As System.Windows.Forms.Label
    Friend WithEvents dtpVan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents dtpTot As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnToon As System.Windows.Forms.Button
    Friend WithEvents UltraGridDagverslagInlichtingen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDropDownTypes As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents _DataDagverslagInlichtingType1 As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
    Friend WithEvents btnRecordsAanmaken As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNewRecords As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents dtpDagverslag As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnAfdrukDagverslag As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMailenNaarPersoneelsdienst As Infragistics.Win.Misc.UltraButton
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents _DataDagverslagInlichtingen2 As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagVerslagInlichtingen
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDagverslagInlichtingenOverzicht))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGPO", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PO_DL", -1, "UltraDropDownTypes")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_REG_DG_PO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_PO_1")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_PO_2")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_PO_4")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_PO_ALG")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekNr")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INV_PO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGPODL", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PO_DL")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_DG_PO_DL", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INV_PO")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBoxDagverslagPersoneel = New System.Windows.Forms.GroupBox
        Me.btnAfdrukDagverslag = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton
        Me.btnMailenNaarPersoneelsdienst = New Infragistics.Win.Misc.UltraButton
        Me.dtpDagverslag = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraGridDagverslagInlichtingen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._DataDagverslagInlichtingen2 = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagVerslagInlichtingen
        Me.lblOverzichtVan = New System.Windows.Forms.Label
        Me.dtpVan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lblTot = New System.Windows.Forms.Label
        Me.dtpTot = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnToon = New System.Windows.Forms.Button
        Me.UltraDropDownTypes = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me._DataDagverslagInlichtingType1 = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
        Me.btnRecordsAanmaken = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpNewRecords = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
        Me.GroupBoxDagverslagPersoneel.SuspendLayout()
        CType(Me.dtpDagverslag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridDagverslagInlichtingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DataDagverslagInlichtingen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DataDagverslagInlichtingType1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpNewRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxDagverslagPersoneel
        '
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.btnAfdrukDagverslag)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxDagverslagPersoneel.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxDagverslagPersoneel.Location = New System.Drawing.Point(8, 384)
        Me.GroupBoxDagverslagPersoneel.Name = "GroupBoxDagverslagPersoneel"
        Me.GroupBoxDagverslagPersoneel.Size = New System.Drawing.Size(872, 48)
        Me.GroupBoxDagverslagPersoneel.TabIndex = 16
        Me.GroupBoxDagverslagPersoneel.TabStop = False
        Me.GroupBoxDagverslagPersoneel.Text = "Dagverslag inlichtingen"
        '
        'btnAfdrukDagverslag
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnAfdrukDagverslag.Appearance = Appearance1
        Me.btnAfdrukDagverslag.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAfdrukDagverslag.Location = New System.Drawing.Point(408, 16)
        Me.btnAfdrukDagverslag.Name = "btnAfdrukDagverslag"
        Me.btnAfdrukDagverslag.Size = New System.Drawing.Size(152, 23)
        Me.btnAfdrukDagverslag.TabIndex = 3
        Me.btnAfdrukDagverslag.Text = "Afdrukken dagverslag"
        '
        'UltraButtonAfdrukken
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance2
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(104, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(112, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken tabel"
        '
        'UltraButtonOpslaan
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance3
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 0
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraButtonSluiten
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance4
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(768, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'btnMailenNaarPersoneelsdienst
        '
        Me.btnMailenNaarPersoneelsdienst.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnMailenNaarPersoneelsdienst.Location = New System.Drawing.Point(576, 400)
        Me.btnMailenNaarPersoneelsdienst.Name = "btnMailenNaarPersoneelsdienst"
        Me.btnMailenNaarPersoneelsdienst.Size = New System.Drawing.Size(168, 23)
        Me.btnMailenNaarPersoneelsdienst.TabIndex = 5
        Me.btnMailenNaarPersoneelsdienst.Text = "Mailen naar personeelsdienst"
        Me.btnMailenNaarPersoneelsdienst.Visible = False
        '
        'dtpDagverslag
        '
        Me.dtpDagverslag.Location = New System.Drawing.Point(312, 400)
        Me.dtpDagverslag.Name = "dtpDagverslag"
        Me.dtpDagverslag.Size = New System.Drawing.Size(96, 21)
        Me.dtpDagverslag.TabIndex = 2
        '
        'UltraGridDagverslagInlichtingen
        '
        Me.UltraGridDagverslagInlichtingen.DataSource = Me._DataDagverslagInlichtingen2
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Appearance = Appearance5
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Rubriek"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Disallow
        UltraGridColumn2.Width = 343
        UltraGridColumn3.Header.Caption = "Tijdstip"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Disallow
        UltraGridColumn3.Width = 74
        UltraGridColumn4.Header.Caption = "P1"
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.MaskInput = "nnnnnnnnn"
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn4.Width = 91
        UltraGridColumn5.Header.Caption = "P2"
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.MaskInput = "nnnnnnnnn"
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn5.Width = 82
        UltraGridColumn6.Header.Caption = "P4"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.MaskInput = "nnnnnnnnn"
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn6.Width = 82
        UltraGridColumn7.Header.Caption = "ALG"
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.MaskInput = "nnnnnnnnn"
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn7.Width = 69
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.MaskInput = "nnnn"
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn8.Width = 52
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.MaskInput = "nn"
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn9.Width = 52
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.MaskInput = "nn"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.IntegerPositive
        UltraGridColumn10.Width = 56
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Post"
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Width = 82
        UltraGridColumn12.Header.Caption = "Nr"
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Width = 28
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.ActiveCellAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.CellAppearance = Appearance12
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance13.BackColor = System.Drawing.SystemColors.Control
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.RowAppearance = Appearance15
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance16
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridDagverslagInlichtingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridDagverslagInlichtingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridDagverslagInlichtingen.Location = New System.Drawing.Point(8, 48)
        Me.UltraGridDagverslagInlichtingen.Name = "UltraGridDagverslagInlichtingen"
        Me.UltraGridDagverslagInlichtingen.Size = New System.Drawing.Size(872, 328)
        Me.UltraGridDagverslagInlichtingen.TabIndex = 20
        '
        '_DataDagverslagInlichtingen2
        '
        Me._DataDagverslagInlichtingen2.DataSetName = "TDSDagVerslagInlichtingen"
        Me._DataDagverslagInlichtingen2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'lblOverzichtVan
        '
        Me.lblOverzichtVan.AutoSize = True
        Me.lblOverzichtVan.Location = New System.Drawing.Point(16, 8)
        Me.lblOverzichtVan.Name = "lblOverzichtVan"
        Me.lblOverzichtVan.Size = New System.Drawing.Size(41, 16)
        Me.lblOverzichtVan.TabIndex = 21
        Me.lblOverzichtVan.Text = "Datum:"
        Me.lblOverzichtVan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpVan
        '
        Me.dtpVan.Location = New System.Drawing.Point(64, 8)
        Me.dtpVan.Name = "dtpVan"
        Me.dtpVan.Size = New System.Drawing.Size(112, 21)
        Me.dtpVan.TabIndex = 0
        '
        'lblTot
        '
        Me.lblTot.Location = New System.Drawing.Point(336, 8)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(48, 23)
        Me.lblTot.TabIndex = 23
        Me.lblTot.Text = "tot"
        Me.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTot.Visible = False
        '
        'dtpTot
        '
        Me.dtpTot.Location = New System.Drawing.Point(384, 8)
        Me.dtpTot.Name = "dtpTot"
        Me.dtpTot.Size = New System.Drawing.Size(112, 21)
        Me.dtpTot.TabIndex = 1
        Me.dtpTot.Visible = False
        '
        'btnToon
        '
        Me.btnToon.Location = New System.Drawing.Point(184, 8)
        Me.btnToon.Name = "btnToon"
        Me.btnToon.TabIndex = 2
        Me.btnToon.Text = "&Toon"
        '
        'UltraDropDownTypes
        '
        Me.UltraDropDownTypes.DataMember = "BBDGPODL"
        Me.UltraDropDownTypes.DataSource = Me._DataDagverslagInlichtingType1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownTypes.DisplayLayout.Appearance = Appearance17
        Me.UltraDropDownTypes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 148
        UltraGridColumn14.Header.Caption = "Omschrijving"
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Width = 226
        UltraGridColumn15.Header.Caption = "Post"
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.Width = 129
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.Width = 50
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.UltraDropDownTypes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownTypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownTypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownTypes.DisplayLayout.GroupByBox.Appearance = Appearance18
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownTypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance19
        Me.UltraDropDownTypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownTypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance20
        Me.UltraDropDownTypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownTypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownTypes.DisplayLayout.Override.ActiveCellAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.SystemColors.Highlight
        Appearance22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownTypes.DisplayLayout.Override.ActiveRowAppearance = Appearance22
        Me.UltraDropDownTypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownTypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownTypes.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Appearance24.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownTypes.DisplayLayout.Override.CellAppearance = Appearance24
        Me.UltraDropDownTypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownTypes.DisplayLayout.Override.CellPadding = 0
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownTypes.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraDropDownTypes.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.UltraDropDownTypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownTypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownTypes.DisplayLayout.Override.RowAppearance = Appearance27
        Me.UltraDropDownTypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownTypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance28
        Me.UltraDropDownTypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownTypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownTypes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownTypes.DisplayMember = "SCF_DG_PO_DL"
        Me.UltraDropDownTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownTypes.Location = New System.Drawing.Point(424, 168)
        Me.UltraDropDownTypes.Name = "UltraDropDownTypes"
        Me.UltraDropDownTypes.TabIndex = 26
        Me.UltraDropDownTypes.ValueMember = "ID_DG_PO_DL"
        Me.UltraDropDownTypes.Visible = False
        '
        '_DataDagverslagInlichtingType1
        '
        Me._DataDagverslagInlichtingType1.DataSetName = "TDSDagverslagInlichtingType"
        Me._DataDagverslagInlichtingType1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnRecordsAanmaken
        '
        Me.btnRecordsAanmaken.Location = New System.Drawing.Point(216, 12)
        Me.btnRecordsAanmaken.Name = "btnRecordsAanmaken"
        Me.btnRecordsAanmaken.Size = New System.Drawing.Size(144, 23)
        Me.btnRecordsAanmaken.TabIndex = 1
        Me.btnRecordsAanmaken.Text = "&Aanmaken records"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNewRecords)
        Me.GroupBox1.Controls.Add(Me.btnRecordsAanmaken)
        Me.GroupBox1.Location = New System.Drawing.Point(512, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 40)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'dtpNewRecords
        '
        Me.dtpNewRecords.Location = New System.Drawing.Point(40, 12)
        Me.dtpNewRecords.Name = "dtpNewRecords"
        Me.dtpNewRecords.Size = New System.Drawing.Size(128, 21)
        Me.dtpNewRecords.TabIndex = 0
        '
        'UltraGridPrintDocument1
        '
        Me.UltraGridPrintDocument1.Grid = Me.UltraGridDagverslagInlichtingen
        '
        'UltraPrintPreviewDialog1
        '
        Me.UltraPrintPreviewDialog1.Document = Me.UltraGridPrintDocument1
        Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FormDagverslagInlichtingenOverzicht
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 446)
        Me.Controls.Add(Me.dtpDagverslag)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UltraDropDownTypes)
        Me.Controls.Add(Me.btnToon)
        Me.Controls.Add(Me.dtpTot)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.dtpVan)
        Me.Controls.Add(Me.lblOverzichtVan)
        Me.Controls.Add(Me.UltraGridDagverslagInlichtingen)
        Me.Controls.Add(Me.btnMailenNaarPersoneelsdienst)
        Me.Controls.Add(Me.GroupBoxDagverslagPersoneel)
        Me.Name = "FormDagverslagInlichtingenOverzicht"
        Me.Text = "Overzicht dagverslag inlichtingen"
        Me.GroupBoxDagverslagPersoneel.ResumeLayout(False)
        CType(Me.dtpDagverslag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridDagverslagInlichtingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DataDagverslagInlichtingen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DataDagverslagInlichtingType1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtpNewRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FormDagverslagInlichtingenOverzicht_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

            _currentTdsInlichtingenTypes = Me._aProxy.GetDagverslagInlichtingTypes()
            Me.UltraDropDownTypes.DataSource = Me._currentTdsInlichtingenTypes

            'opvragen van registraties van vandaag
            getRegistraties()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub getRegistraties()
        'Doel:
        'Auteur: Dieter Vanneste - okt 2006
        'Wijziging: Nancy Coppens - 03/07/2006 (enkel voor één dag tonen, niet van - tot => verwarrend voor gebruikers)

        Try
            'Me._currentTdsDagverslagInlichtingen = Me._aProxy.GetDagverslagInlichtingen(Me.dtpVan.Value, Me.dtpTot.Value)
            Me._currentTdsDagverslagInlichtingen = Me._aProxy.GetDagverslagInlichtingen(Me.dtpVan.Value, _
                                                                                        Me.dtpVan.Value)
            Me.UltraGridDagverslagInlichtingen.DataSource = Me._currentTdsDagverslagInlichtingen
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Function areValidDates() As Boolean
        'Controle geldige datums
        'Wijziging Nancy Coppens - 03/01/2007 - enkel nog datum Van
        Try
            If Me.dtpVan.Value Is Nothing Then
                MessageBox.Show("Ongeldige begindatum.", "Begindatum", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf Me.dtpTot.Value Is Nothing Then
                '    MessageBox.Show("Ongeldige einddatum.", "Einddatum", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ElseIf Me.dtpVan.Value > dtpTot.Value Then
                '    MessageBox.Show("Begindatum is groter dan einddatum.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return True
            End If

            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnToon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToon.Click
        Try
            'Ophalen dagverslag inlichtingtn
            If areValidDates() = True Then
                '1. Automatisch records aanmaken voor deze dag, als nog niet bestaat
                Call AanmakenRecords()

                '2. ophalen records voor die dag
                getRegistraties()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraGridDagverslagInlichtingen_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridDagverslagInlichtingen.InitializeRow
        Try
            If e.ReInitialize = False Then
                setGridColors(e.Row, False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub setGridColors(ByVal row As Infragistics.Win.UltraWinGrid.UltraGridRow, _
                                ByVal isNewRecord As Boolean)
        Try
            If Not row.Cells("ID_DG_PO_DL").Value Is DBNull.Value Then
                Dim id_dg_po_dl As Integer = Int(row.Cells("ID_DG_PO_DL").Value)

                Dim resulRow() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType.BBDGPODLRow = _currentTdsInlichtingenTypes.BBDGPODL.Select("ID_DG_PO_DL = " & CStr(id_dg_po_dl))


                row.Cells("INV_PO").Value = resulRow(0).INV_PO


                If resulRow(0).INV_PO = True Then
                    row.Cells("Q_PO_1").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    row.Cells("Q_PO_1").Appearance.BackColor = Drawing.Color.Empty 'Dien - aug2008 - migratie 2008

                    row.Cells("Q_PO_2").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    row.Cells("Q_PO_2").Appearance.BackColor = Drawing.Color.Empty 'Dien - aug2008 - migratie 2008

                    row.Cells("Q_PO_4").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    row.Cells("Q_PO_4").Appearance.BackColor = Drawing.Color.Empty 'Dien - aug2008 - migratie 2008

                    row.Cells("Q_PO_ALG").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    row.Cells("Q_PO_ALG").Appearance.BackColor = System.Drawing.Color.LightGray
                Else
                    row.Cells("Q_PO_1").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    row.Cells("Q_PO_1").Appearance.BackColor = System.Drawing.Color.LightGray

                    row.Cells("Q_PO_2").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    row.Cells("Q_PO_2").Appearance.BackColor = System.Drawing.Color.LightGray

                    row.Cells("Q_PO_4").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    row.Cells("Q_PO_4").Appearance.BackColor = System.Drawing.Color.LightGray

                    If isNewRecord = True Then
                        row.Cells("Q_PO_1").Value = DBNull.Value
                        row.Cells("Q_PO_2").Value = DBNull.Value
                        row.Cells("Q_PO_4").Value = DBNull.Value
                    End If

                    row.Cells("Q_PO_ALG").Activation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                    row.Cells("Q_PO_ALG").Appearance.BackColor = Drawing.Color.Empty 'Dien - aug2008 - migratie VS2005
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub AanmakenRecords()
        'Doel:
        'Auteur:    Dieter Vanneste
        'Wijziging: Nancy Coppens - 03/01/2007
        Dim dateDagverslag As Date

        Try

            'dateDagverslag = Me.dtpNewRecords.Value 'vroeger vóór 03/01/2007
            dateDagverslag = CDate(Me.dtpVan.Value) 'vanaf 03/01/2007

            'Controle of de dagverslagen voor dag ... aangemaakt zijn
            'Extra controle: indien records reeds werden toegevoegd aan de grid maar niet in de database --> niet toevoegen
            If Me._aProxy.BestaatDagverslagInlichtingVoorDag(dateDagverslag) = True Or _
                Me._arrNieuweRegistraties.Contains(CDate(dateDagverslag)) = True Then
                'Aanmaken records.
                'MessageBox.Show("De registraties werden reeds aangemaakt voor die dag.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Nancy Coppens - 03/01/2007 - wordt nu opgeroepen via de Toon-knop (allemaal automatisch)
            Else
                'Toevoegen nieuwe registraties 

                Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType.BBDGPODLRow
                For Each aRow In Me._currentTdsInlichtingenTypes.BBDGPODL
                    Dim newRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingen.BBDGPORow
                    newRow = Me._currentTdsDagverslagInlichtingen.BBDGPO.NewBBDGPORow()
                    newRow.ID_DG_PO_DL = aRow.ID_DG_PO_DL
                    newRow.TMS_REG_DG_PO = dateDagverslag
                    newRow.Jaar = dateDagverslag.Year
                    newRow.Maand = dateDagverslag.Month
                    newRow.WeekNr = DatePart("ww", dateDagverslag)
                    Me._currentTdsDagverslagInlichtingen.BBDGPO.AddBBDGPORow(newRow)
                Next
                'Toevoegen nieuwe registratie
                Me._arrNieuweRegistraties.Add(dateDagverslag)

                Call opslaanWijzigingen() 'naco - al onmiddellijk opslaan
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        Try
            If opslaanWijzigingen() = False Then
                MessageBox.Show("Er zijn geen wijzigingen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Function opslaanWijzigingen() As Boolean
        Dim ds As DataSet = Me._currentTdsDagverslagInlichtingen.GetChanges()

        If Not ds Is Nothing Then
            Me._aProxy.RegisterDagverslagInlichtingen(ds, System.Environment.UserName)
            Me._currentTdsDagverslagInlichtingen.BBDGPO.AcceptChanges()
            'er zijn wijzigingen
            Return True
        Else
            Return False 'geen wijz.
        End If
    End Function

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.UltraPrintPreviewDialog1.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraGridDagverslagInlichtingen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridDagverslagInlichtingen.InitializePrint
        'Doel: rapport instellingen
        'Auteur: Siddien -okt. 2006
        Try
            e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Dagverslag inlichtingen."
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 2
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                     ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraPrintPreviewDialog1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraPrintPreviewDialog1.Load
        Try
            Me.UltraPrintPreviewDialog1.Document.DocumentName = "Dagverslag inlichtingen."
            Me.UltraPrintPreviewDialog1.Text = "Dagverslag inlichtingen."
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                         ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub btnAfdrukDagverslag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfdrukDagverslag.Click
        Try
            'Dien - 26 dec 2006. Opslaan wijzigingen voordat men afdrukt.
            opslaanWijzigingen()

            Dim _dataConfiguratie As New TDSConfiguratie
            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))

            Dim f_rap As New FormRapportenPreview
            f_rap.Show()

            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                 "DagverslagInlichtingen", "datum", Format(Me.dtpDagverslag.Value, "dd/MM/yyyy"))

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

    Private Sub btnMailenNaarPersoneelsdienst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailenNaarPersoneelsdienst.Click
        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim textMail As String
        Dim titelMail As String
        Dim best As New ArrayList

        Try
            'ophalen bestemmeling
            Dim mailAdres As String
            Dim mailAdressen() As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "MailDagVerslag").WD().Split(";")
            For Each mailAdres In mailAdressen
                best.Add(mailAdres)
            Next

            If best.Count = 0 Then
                MessageBox.Show("Er zijn geen bestemmelingen gevonden. Gelieve contact op te nemen met informatica.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD & _
                                   "DagverslagInl" & "_" & CType(dtpDagverslag.Value, DateTime).ToString("ddMMyyyy") & ".pdf"

                pathsAttachment.Add(pathPDFfile)

                Dim params As New Hashtable
                params.Add("datum", Format(Me.dtpDagverslag.Value, "dd/MM/yyyy"))

                f_rap.Show()
                f_rap.ExportPdfBewakingRegistratie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                                   "DagverslagInlichtingen", _
                                                   pathPDFfile, _
                                                   params)
                f_rap.Dispose()

                'Dan mail versturen met PDF-file in attachment

                textMail = ""

                titelMail = "Dagverslag " & CType(dtpDagverslag.Value, DateTime).ToString("dd/MM/yyyy")


                MailBBW.sendMail(best, textMail, titelMail, pathsAttachment)

                MessageBox.Show("Mail werd correct verzonden.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                                ReThrowOptions.PublishOnly)
        End Try
    End Sub
End Class
