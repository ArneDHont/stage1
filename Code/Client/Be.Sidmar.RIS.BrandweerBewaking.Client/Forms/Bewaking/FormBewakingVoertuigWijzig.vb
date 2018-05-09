Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection


Public Class FormBewakingVoertuigWijzig
    Inherits System.Windows.Forms.Form

    Private _proxy As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

    Private _oTdsFirmas As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
    Private _oTdsVoertuigTypes As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
    Private _aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen.BBTSPRow

    Private _isNew As Boolean
    Private _opSaveGeklikt As Boolean = False


#Region "Properties"
    Public ReadOnly Property opSaveGeklikt() As Boolean
        Get
            Return Me._opSaveGeklikt
        End Get
    End Property
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me._proxy = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
    End Sub

    Public Sub New(ByVal aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen.BBTSPRow, _
                    ByVal isNew As Boolean)
        Me.New()
        Me._aRow = aRow
        Me._isNew = isNew
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
    Friend WithEvents lblEigenaar As System.Windows.Forms.Label
    Friend WithEvents lblFirma As System.Windows.Forms.Label
    Friend WithEvents lblMerk As System.Windows.Forms.Label
    Friend WithEvents lblAard As System.Windows.Forms.Label
    Friend WithEvents lblNummerplaat As System.Windows.Forms.Label
    Friend WithEvents lblCylinderinhoud As System.Windows.Forms.Label
    Friend WithEvents lblBouwjaar As System.Windows.Forms.Label
    Friend WithEvents lblChassisnummer As System.Windows.Forms.Label
    Friend WithEvents lblDatumLaatsteControle As System.Windows.Forms.Label
    Friend WithEvents btnZoek As System.Windows.Forms.Button
    Friend WithEvents txtStamnummer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtMerk As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNummerplaat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCylinderInhoud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBouwjaar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtChassisnummer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraOptionSetVoertuig As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents _dataFirmas As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
    Friend WithEvents UltraComboFirma As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataVoertuigTypes As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
    Friend WithEvents UltraComboAard As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblVoornaam As System.Windows.Forms.Label
    Friend WithEvents lblNaam As System.Windows.Forms.Label
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBFRM", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STRA_FRM")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_PLA_FRM")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBTYTSP", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_TSP")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_TSP")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormBewakingVoertuigWijzig))
        Me.lblEigenaar = New System.Windows.Forms.Label
        Me.lblFirma = New System.Windows.Forms.Label
        Me.lblMerk = New System.Windows.Forms.Label
        Me.lblAard = New System.Windows.Forms.Label
        Me.lblNummerplaat = New System.Windows.Forms.Label
        Me.lblCylinderinhoud = New System.Windows.Forms.Label
        Me.lblBouwjaar = New System.Windows.Forms.Label
        Me.lblChassisnummer = New System.Windows.Forms.Label
        Me.lblDatumLaatsteControle = New System.Windows.Forms.Label
        Me.UltraOptionSetVoertuig = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.btnZoek = New System.Windows.Forms.Button
        Me.txtStamnummer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txtMerk = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtNummerplaat = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtCylinderInhoud = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtBouwjaar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtChassisnummer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me._dataFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
        Me.UltraComboFirma = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me._dataVoertuigTypes = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
        Me.UltraComboAard = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lblVoornaam = New System.Windows.Forms.Label
        Me.lblNaam = New System.Windows.Forms.Label
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraOptionSetVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNummerplaat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCylinderInhoud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBouwjaar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChassisnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVoertuigTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboAard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEigenaar
        '
        Me.lblEigenaar.AutoSize = True
        Me.lblEigenaar.Location = New System.Drawing.Point(8, 16)
        Me.lblEigenaar.Name = "lblEigenaar"
        Me.lblEigenaar.Size = New System.Drawing.Size(53, 16)
        Me.lblEigenaar.TabIndex = 0
        Me.lblEigenaar.Text = "Eigenaar:"
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(8, 48)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(36, 16)
        Me.lblFirma.TabIndex = 1
        Me.lblFirma.Text = "Firma:"
        '
        'lblMerk
        '
        Me.lblMerk.AutoSize = True
        Me.lblMerk.Location = New System.Drawing.Point(8, 112)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(32, 16)
        Me.lblMerk.TabIndex = 4
        Me.lblMerk.Text = "Merk:"
        '
        'lblAard
        '
        Me.lblAard.AutoSize = True
        Me.lblAard.Location = New System.Drawing.Point(8, 144)
        Me.lblAard.Name = "lblAard"
        Me.lblAard.Size = New System.Drawing.Size(80, 16)
        Me.lblAard.TabIndex = 5
        Me.lblAard.Text = "Type voertuig:*"
        '
        'lblNummerplaat
        '
        Me.lblNummerplaat.AutoSize = True
        Me.lblNummerplaat.Location = New System.Drawing.Point(496, 16)
        Me.lblNummerplaat.Name = "lblNummerplaat"
        Me.lblNummerplaat.Size = New System.Drawing.Size(83, 16)
        Me.lblNummerplaat.TabIndex = 6
        Me.lblNummerplaat.Text = "Nummerplaat: *"
        '
        'lblCylinderinhoud
        '
        Me.lblCylinderinhoud.Location = New System.Drawing.Point(496, 48)
        Me.lblCylinderinhoud.Name = "lblCylinderinhoud"
        Me.lblCylinderinhoud.Size = New System.Drawing.Size(88, 23)
        Me.lblCylinderinhoud.TabIndex = 7
        Me.lblCylinderinhoud.Text = "Cylinderinhoud:"
        '
        'lblBouwjaar
        '
        Me.lblBouwjaar.AutoSize = True
        Me.lblBouwjaar.Location = New System.Drawing.Point(496, 80)
        Me.lblBouwjaar.Name = "lblBouwjaar"
        Me.lblBouwjaar.Size = New System.Drawing.Size(55, 16)
        Me.lblBouwjaar.TabIndex = 8
        Me.lblBouwjaar.Text = "Bouwjaar:"
        '
        'lblChassisnummer
        '
        Me.lblChassisnummer.AutoSize = True
        Me.lblChassisnummer.Location = New System.Drawing.Point(496, 112)
        Me.lblChassisnummer.Name = "lblChassisnummer"
        Me.lblChassisnummer.Size = New System.Drawing.Size(89, 16)
        Me.lblChassisnummer.TabIndex = 9
        Me.lblChassisnummer.Text = "Chassisnummer:"
        '
        'lblDatumLaatsteControle
        '
        Me.lblDatumLaatsteControle.AutoSize = True
        Me.lblDatumLaatsteControle.Location = New System.Drawing.Point(496, 144)
        Me.lblDatumLaatsteControle.Name = "lblDatumLaatsteControle"
        Me.lblDatumLaatsteControle.Size = New System.Drawing.Size(81, 16)
        Me.lblDatumLaatsteControle.TabIndex = 10
        Me.lblDatumLaatsteControle.Text = "Datum keuring:"
        '
        'UltraOptionSetVoertuig
        '
        Me.UltraOptionSetVoertuig.ItemAppearance = Appearance1
        ValueListItem1.DataValue = CType(0, Byte)
        ValueListItem1.DisplayText = "Arcelor-voertuig"
        ValueListItem2.DataValue = CType(1, Byte)
        ValueListItem2.DisplayText = "Privé-voertuig of firma"
        Me.UltraOptionSetVoertuig.Items.Add(ValueListItem1)
        Me.UltraOptionSetVoertuig.Items.Add(ValueListItem2)
        Me.UltraOptionSetVoertuig.Location = New System.Drawing.Point(88, 72)
        Me.UltraOptionSetVoertuig.Name = "UltraOptionSetVoertuig"
        Me.UltraOptionSetVoertuig.Size = New System.Drawing.Size(392, 32)
        Me.UltraOptionSetVoertuig.TabIndex = 3
        '
        'btnZoek
        '
        Me.btnZoek.Location = New System.Drawing.Point(408, 16)
        Me.btnZoek.Name = "btnZoek"
        Me.btnZoek.TabIndex = 1
        Me.btnZoek.Text = "Opzoeken"
        '
        'txtStamnummer
        '
        Me.txtStamnummer.Location = New System.Drawing.Point(88, 16)
        Me.txtStamnummer.Name = "txtStamnummer"
        Me.txtStamnummer.Nullable = True
        Me.txtStamnummer.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtStamnummer.Size = New System.Drawing.Size(100, 21)
        Me.txtStamnummer.TabIndex = 0
        Me.txtStamnummer.Value = Nothing
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(88, 112)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(392, 21)
        Me.txtMerk.TabIndex = 4
        '
        'txtNummerplaat
        '
        Me.txtNummerplaat.Location = New System.Drawing.Point(584, 16)
        Me.txtNummerplaat.Name = "txtNummerplaat"
        Me.txtNummerplaat.Size = New System.Drawing.Size(152, 21)
        Me.txtNummerplaat.TabIndex = 6
        '
        'txtCylinderInhoud
        '
        Me.txtCylinderInhoud.Location = New System.Drawing.Point(584, 48)
        Me.txtCylinderInhoud.Name = "txtCylinderInhoud"
        Me.txtCylinderInhoud.Size = New System.Drawing.Size(152, 21)
        Me.txtCylinderInhoud.TabIndex = 7
        '
        'txtBouwjaar
        '
        Me.txtBouwjaar.Location = New System.Drawing.Point(584, 80)
        Me.txtBouwjaar.Name = "txtBouwjaar"
        Me.txtBouwjaar.Size = New System.Drawing.Size(152, 21)
        Me.txtBouwjaar.TabIndex = 8
        '
        'txtChassisnummer
        '
        Me.txtChassisnummer.Location = New System.Drawing.Point(584, 112)
        Me.txtChassisnummer.Name = "txtChassisnummer"
        Me.txtChassisnummer.Size = New System.Drawing.Size(152, 21)
        Me.txtChassisnummer.TabIndex = 9
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(584, 144)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(152, 21)
        'Me.UltraDateTimeEditorDatum.SupportThemes = False 'Dien - aug2008 - migratie 2008
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.False
        Me.UltraDateTimeEditorDatum.TabIndex = 10
        Me.UltraDateTimeEditorDatum.Value = Nothing
        '
        '_dataFirmas
        '
        Me._dataFirmas.DataSetName = "TDSFirmas"
        Me._dataFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraComboFirma
        '
        Me.UltraComboFirma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UltraComboFirma.DataSource = Me._dataFirmas.BBFRM
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboFirma.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Firma"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 224
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.UltraComboFirma.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboFirma.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboFirma.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.UltraComboFirma.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboFirma.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboFirma.DisplayLayout.Override.CellAppearance = Appearance9
        Me.UltraComboFirma.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboFirma.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraComboFirma.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.UltraComboFirma.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboFirma.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboFirma.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraComboFirma.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboFirma.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraComboFirma.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboFirma.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboFirma.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboFirma.DisplayMember = "NM_FRM"
        Me.UltraComboFirma.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboFirma.Location = New System.Drawing.Point(88, 40)
        Me.UltraComboFirma.Name = "UltraComboFirma"
        Me.UltraComboFirma.Size = New System.Drawing.Size(392, 21)
        Me.UltraComboFirma.TabIndex = 2
        Me.UltraComboFirma.ValueMember = "ID_FRM"
        '
        '_dataVoertuigTypes
        '
        Me._dataVoertuigTypes.DataSetName = "TDSVoertuigTypes"
        Me._dataVoertuigTypes.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraComboAard
        '
        Me.UltraComboAard.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UltraComboAard.DataMember = "BBTYTSP"
        Me.UltraComboAard.DataSource = Me._dataVoertuigTypes
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAard.DisplayLayout.Appearance = Appearance14
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Omschrijving"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Width = 224
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7})
        Me.UltraComboAard.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraComboAard.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboAard.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAard.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAard.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.UltraComboAard.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAard.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.UltraComboAard.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboAard.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboAard.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboAard.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UltraComboAard.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboAard.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboAard.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboAard.DisplayLayout.Override.CellAppearance = Appearance21
        Me.UltraComboAard.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboAard.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAard.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraComboAard.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.UltraComboAard.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboAard.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboAard.DisplayLayout.Override.RowAppearance = Appearance24
        Me.UltraComboAard.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboAard.DisplayLayout.Override.TemplateAddRowAppearance = Appearance25
        Me.UltraComboAard.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboAard.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboAard.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboAard.DisplayMember = "SCF_TY_TSP"
        Me.UltraComboAard.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboAard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboAard.Location = New System.Drawing.Point(88, 144)
        Me.UltraComboAard.Name = "UltraComboAard"
        Me.UltraComboAard.Size = New System.Drawing.Size(392, 21)
        Me.UltraComboAard.TabIndex = 5
        Me.UltraComboAard.ValueMember = "ID_TY_TSP"
        '
        'lblVoornaam
        '
        Me.lblVoornaam.Location = New System.Drawing.Point(200, 16)
        Me.lblVoornaam.Name = "lblVoornaam"
        Me.lblVoornaam.TabIndex = 26
        Me.lblVoornaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNaam
        '
        Me.lblNaam.Location = New System.Drawing.Point(312, 16)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(88, 23)
        Me.lblNaam.TabIndex = 27
        Me.lblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraButtonOpslaan
        '
        Appearance26.Image = CType(resources.GetObject("Appearance26.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance26
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(648, 176)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 28
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'FormBewakingVoertuigWijzig
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 208)
        Me.Controls.Add(Me.UltraButtonOpslaan)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblVoornaam)
        Me.Controls.Add(Me.UltraComboAard)
        Me.Controls.Add(Me.UltraComboFirma)
        Me.Controls.Add(Me.UltraDateTimeEditorDatum)
        Me.Controls.Add(Me.txtChassisnummer)
        Me.Controls.Add(Me.txtBouwjaar)
        Me.Controls.Add(Me.txtCylinderInhoud)
        Me.Controls.Add(Me.txtNummerplaat)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.btnZoek)
        Me.Controls.Add(Me.txtStamnummer)
        Me.Controls.Add(Me.UltraOptionSetVoertuig)
        Me.Controls.Add(Me.lblDatumLaatsteControle)
        Me.Controls.Add(Me.lblChassisnummer)
        Me.Controls.Add(Me.lblBouwjaar)
        Me.Controls.Add(Me.lblCylinderinhoud)
        Me.Controls.Add(Me.lblNummerplaat)
        Me.Controls.Add(Me.lblAard)
        Me.Controls.Add(Me.lblMerk)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.lblEigenaar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormBewakingVoertuigWijzig"
        Me.Text = "Voertuig"
        CType(Me.UltraOptionSetVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNummerplaat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCylinderInhoud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBouwjaar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChassisnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVoertuigTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboAard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormBewakingVoertuigWijzig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Doel:   Voertuig-gegevens invullen (als bestaand voertuig wordt gewijzigd)
        'Auteur: Dieter Vanneste - okt 2006
        'Wijzigingen: Nancy Coppens - 19/12/2006

        Try
            _oTdsFirmas = Me._proxy.GetFirmas()
            _oTdsVoertuigTypes = Me._proxy.GetVoertuigTypes()

            Me.UltraComboFirma.DisplayMember = "NM_FRM"
            Me.UltraComboFirma.ValueMember = "ID_FRM"
            Me.UltraComboFirma.DataSource = Me._oTdsFirmas

            Me.UltraComboAard.DisplayMember = "SCF_TY_TSP"
            Me.UltraComboAard.ValueMember = "ID_TY_TSP"
            Me.UltraComboAard.DataSource = Me._oTdsVoertuigTypes

            Me.UltraOptionSetVoertuig.Value = 0

            If Me._isNew = False Then
                'Invullen van gegevens row
                'Stamnummer 
                If Not Me._aRow.IsID_EIG_TSPNull Then 'eigenaar is niet verplicht)
                    Me.txtStamnummer.Text = Me._aRow.ID_EIG_TSP.ToString
                End If

                'Firma
                If Me._aRow.IsID_FRM_TSPNull = False Then
                    Me.UltraComboFirma.Value = Me._aRow.ID_FRM_TSP
                End If
                'Andere of privé voertuig 
                If Me._aRow.IsINDI_TSP_ARCNull = False Then
                    If Me._aRow.INDI_TSP_ARC = True Then
                        Me.UltraOptionSetVoertuig.Value = 0
                        Me._aRow.INDI_TSP_PRIV = False
                    Else
                        Me.UltraOptionSetVoertuig.Value = 1
                    End If
                ElseIf Me._aRow.IsINDI_TSP_PRIVNull = False Then
                    If Me._aRow.INDI_TSP_PRIV = True Then
                        Me.UltraOptionSetVoertuig.Value = 1
                        Me._aRow.INDI_TSP_ARC = False
                    Else
                        Me.UltraOptionSetVoertuig.Value = 0
                    End If
                End If
                'Merk
                If Me._aRow.IsSCF_MRK_TSPNull = False Then
                    Me.txtMerk.Text = Me._aRow.SCF_MRK_TSP
                End If
                'Aard
                If Me._aRow.IsID_TY_TSPNull = False Then
                    UltraComboAard.Value = Me._aRow.ID_TY_TSP
                End If
                'Nummerplaat
                If Me._aRow.IsPL_NR_TSPNull = False Then
                    Me.txtNummerplaat.Text = Me._aRow.PL_NR_TSP
                End If
                'Cylinderinhoud 
                If Me._aRow.IsINH_CYL_TSPNull = False Then
                    Me.txtCylinderInhoud.Text = Me._aRow.INH_CYL_TSP
                End If
                'Bouwjaar
                If Me._aRow.IsJR_BOU_TSPNull = False Then
                    Me.txtBouwjaar.Text = Me._aRow.JR_BOU_TSP
                End If
                'Chassisnummer 
                If Me._aRow.IsNR_CHAS_TSPNull = False Then
                    Me.txtChassisnummer.Text = Me._aRow.NR_CHAS_TSP
                End If
                'Datum laatste controle
                If Me._aRow.IsDT_KEU_L_TSPNull = False Then
                    Me.UltraDateTimeEditorDatum.Value = Me._aRow.DT_KEU_L_TSP
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub btnZoek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoek.Click
        Try
            Dim oFormIndividu As New FormIndividuen(False, String.Empty)
            oFormIndividu.ShowDialog(Me)

            Dim aRowIndividu As Be.Sidmar.ris.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
            aRowIndividu = oFormIndividu.Individu()

            invullenIndividu(aRowIndividu)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub txtStamnummer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStamnummer.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.txtStamnummer.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim aRowIndividu As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
                    aRowIndividu = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(CInt(Me.txtStamnummer.Text.Trim))
                    invullenIndividu(aRowIndividu)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub invullenIndividu(ByVal aRowIndividu As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow)
        Try
            If Not aRowIndividu Is Nothing Then
                Me.txtStamnummer.Text = CStr(aRowIndividu.ID_IND())

                If aRowIndividu.IsNM_INDNull = False Then
                    Me.lblNaam.Text = aRowIndividu.NM_IND()
                End If
                If aRowIndividu.IsVNM_INDNull = False Then
                    Me.lblVoornaam.Text = aRowIndividu.VNM_IND()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub txtStamnummer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStamnummer.ValueChanged

    End Sub

    Private Sub txtStamnummer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStamnummer.LostFocus
        'Doel:   bij verlaten stamnummer => ook naam, voornaam invullen
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            'ophalen stamnummer en invullen gegevens
            If Me.txtStamnummer.Text.Trim = "" Then
            Else
                Dim aRowIndividu As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
                aRowIndividu = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(CInt(Me.txtStamnummer.Text.Trim))
                invullenIndividu(aRowIndividu)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        'Doel:        Wijzigingen aan voertuig opslaan
        'Auteur:      Dieter Vanneste - okt 2006
        'Wijzigingen: Nancy Coppens - 19/12/2006

        Try
            Dim id_tsp As Integer

            If Me._isNew = True Then
                'ophalen nieuw id_tsp nummer 
                id_tsp = Me._proxy.GetMaxBBTSP()

                Me._aRow.ID_TSP = id_tsp + 1
            End If

            'If Me.UltraComboFirma.DataSource Is Nothing Then
            '    MessageBox.Show("Gelieve een firma te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'Luc Van Hamme: firma is niet verplicht (18/12/2006)
            'één van beide (eigenaar of firma) is voldoende
            If Me.txtStamnummer.Text.Trim = "" And UltraComboFirma.Text.Trim = "" Then
                MessageBox.Show("Gelieve een eigenaar of een firma te selecteren aub.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.UltraComboAard.Text.Trim = "" Then
                MessageBox.Show("Gelieve de aard van het voertuig te selecteren aub.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.txtNummerplaat.Text.Trim = "" Then
                MessageBox.Show("Gelieve de nummerplaat in te vullen aub.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Invullen van gegevens row
            'stamnummer 
            If Me.txtStamnummer.Text.Trim = "" Then
                Me._aRow.SetID_EIG_TSPNull()
            Else
                Me._aRow.ID_EIG_TSP = CInt(Me.txtStamnummer.Text)
            End If

            Me._aRow.VNM_IND = Me.lblVoornaam.Text
            Me._aRow.NM_IND = Me.lblNaam.Text

            'Firma
            If Me.UltraComboFirma.Text.Trim = "" Then
                Me._aRow.SetID_FRM_TSPNull()
            Else
                Me._aRow.ID_FRM_TSP = CInt(Me.UltraComboFirma.Value)
            End If


            'Andere of privé voertuig 
            'Dien - aug2008 - migratie VS2005 (cast naar int)
            Select Case CInt(Me.UltraOptionSetVoertuig.Value)
                Case 0
                    Me._aRow.INDI_TSP_ARC = True
                    Me._aRow.INDI_TSP_PRIV = False
                Case 1
                    Me._aRow.INDI_TSP_PRIV = True
                    Me._aRow.INDI_TSP_ARC = False
            End Select
            'Merk
            Me._aRow.SCF_MRK_TSP = Me.txtMerk.Text
            'Aard
            Me._aRow.ID_TY_TSP = CInt(UltraComboAard.Value)
            'Nummerplaat
            Me._aRow.PL_NR_TSP = Me.txtNummerplaat.Text
            'Cylinderinhoud 
            Me._aRow.INH_CYL_TSP = Me.txtCylinderInhoud.Text
            'Bouwjaar
            Me._aRow.JR_BOU_TSP = Me.txtBouwjaar.Text
            'Chassisnummer 
            Me._aRow.NR_CHAS_TSP = Me.txtChassisnummer.Text
            'Datum laatste controle
            If (Not Me.UltraDateTimeEditorDatum.Value Is Nothing) Then
                Me._aRow.DT_KEU_L_TSP = CDate(Me.UltraDateTimeEditorDatum.Value)
            Else
                Me._aRow.IsDT_KEU_L_TSPNull()
            End If

            _opSaveGeklikt = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub
End Class
