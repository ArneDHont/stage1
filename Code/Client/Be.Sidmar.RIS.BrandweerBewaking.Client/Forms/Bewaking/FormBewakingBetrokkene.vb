Imports System.Windows.Forms
Imports System.Reflection
Imports ADF.ExceptionHandling

Public Class FormBewakingBetrokkene
    Inherits System.Windows.Forms.Form

    Private _proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

    Private _idRegistratie As Integer
    Private _dataBetrokkenen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVDataTable

    'Indien betrokkene niet nothing is --> update
    Private _betrokkene As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow

    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    Private _oRowIndividu As TDSIndividuen.BBINDRow
    Private _oRowVoertuig As TDSVoertuigen.BBTSPRow

    Private _isNew As Boolean = True

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    End Sub
    Public Sub New(ByVal idRegistratie As Integer, _
                  ByRef dataBetrokkenen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVDataTable, _
                  ByVal betrokkene As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow)
        'siddien - okt 2006

        Me.New()
        Me._idRegistratie = idRegistratie
        Me._dataBetrokkenen = dataBetrokkenen

        If betrokkene Is Nothing Then
            _isNew = True
            Me._betrokkene = dataBetrokkenen.NewBBBTROGVRow()
        Else
            _isNew = False
            Me._betrokkene = betrokkene
        End If
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
    Friend WithEvents lblBetrokkene As System.Windows.Forms.Label
    Friend WithEvents lblStamnummer As System.Windows.Forms.Label
    Friend WithEvents txtStamnummer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblNaamVoornaam As System.Windows.Forms.Label
    Friend WithEvents txtNaamVoornaam As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAdres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblAdres As System.Windows.Forms.Label
    Friend WithEvents lblGeboorteplaats As System.Windows.Forms.Label
    Friend WithEvents txtHandelendInNaamvan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTelefoon As System.Windows.Forms.Label
    Friend WithEvents txtTelefoon As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblRijbewijs As System.Windows.Forms.Label
    Friend WithEvents lblRijbNummer As System.Windows.Forms.Label
    Friend WithEvents lblRijbCategorie As System.Windows.Forms.Label
    Friend WithEvents lblRijbDatumUitgifte As System.Windows.Forms.Label
    Friend WithEvents lblPlaatsUitgifte As System.Windows.Forms.Label
    Friend WithEvents txtRijbNummer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtRijbCat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpRijbDatumUitgifte As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblGebruikVoertuig As System.Windows.Forms.Label
    Friend WithEvents lblHoedanigheid As System.Windows.Forms.Label
    Friend WithEvents UltraOptionSetHoedanigheid As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblVervoerdePersonen As System.Windows.Forms.Label
    Friend WithEvents lblAanhangwagen As System.Windows.Forms.Label
    Friend WithEvents chkAanhangwagen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtAanhangwagenGewicht As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblBeschrijvingVoertuig As System.Windows.Forms.Label
    Friend WithEvents lblMerkEnAard As System.Windows.Forms.Label
    Friend WithEvents lblCylinderInhoud As System.Windows.Forms.Label
    Friend WithEvents lblBouwjaar As System.Windows.Forms.Label
    Friend WithEvents txtMerkEnAard As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCylinderInhoud As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtBouwjaar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNummerplaat As System.Windows.Forms.Label
    Friend WithEvents lblChassisnummer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNummerplaat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtChassisnummer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDatumLaatsteTechnControle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnOphalenVoertuig As System.Windows.Forms.Button
    Friend WithEvents lblSchade As System.Windows.Forms.Label
    Friend WithEvents lblVerzekering As System.Windows.Forms.Label
    Friend WithEvents lblNaamMaatschappij As System.Windows.Forms.Label
    Friend WithEvents lblPolisnummer As System.Windows.Forms.Label
    Friend WithEvents lblBtwNr As System.Windows.Forms.Label
    Friend WithEvents txtPolisnummer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cobGebruikVoertuig As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataGebruikVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
    Friend WithEvents txtBTWNr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cobVerzekeringFirmas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataVerzFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas
    Friend WithEvents btnZoek As System.Windows.Forms.Button
    Friend WithEvents txtGeboorteplaatsEnDatum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAfdeling As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblAfdeling As System.Windows.Forms.Label
    Friend WithEvents btnOpslaan As System.Windows.Forms.Button
    Friend WithEvents UltraOptionSetBetrokkene As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents _dataTypeBetrokkene As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
    Friend WithEvents txtAtlVervoerdePers As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtRijbPlaatsUitgifte As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtLichamelijkeSchade As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMatSchade As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblLichamelijkeSchade As System.Windows.Forms.Label
    Friend WithEvents lblMaterieleSchade As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRKTSP", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BRK_TSP")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BRK_TSP")
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBVZKFRM", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_VZK")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_VZK")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_FRM_VZK")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM_VZK")
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormBewakingBetrokkene))
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.lblBetrokkene = New System.Windows.Forms.Label
        Me.lblStamnummer = New System.Windows.Forms.Label
        Me.txtStamnummer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.lblNaamVoornaam = New System.Windows.Forms.Label
        Me.txtNaamVoornaam = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtAdres = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblAdres = New System.Windows.Forms.Label
        Me.txtGeboorteplaatsEnDatum = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblGeboorteplaats = New System.Windows.Forms.Label
        Me.txtHandelendInNaamvan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTelefoon = New System.Windows.Forms.Label
        Me.txtTelefoon = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblRijbewijs = New System.Windows.Forms.Label
        Me.lblRijbNummer = New System.Windows.Forms.Label
        Me.lblRijbCategorie = New System.Windows.Forms.Label
        Me.lblRijbDatumUitgifte = New System.Windows.Forms.Label
        Me.lblPlaatsUitgifte = New System.Windows.Forms.Label
        Me.txtRijbNummer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtRijbCat = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dtpRijbDatumUitgifte = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lblGebruikVoertuig = New System.Windows.Forms.Label
        Me.cobGebruikVoertuig = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me._dataGebruikVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
        Me.lblHoedanigheid = New System.Windows.Forms.Label
        Me.UltraOptionSetHoedanigheid = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.lblVervoerdePersonen = New System.Windows.Forms.Label
        Me.lblAanhangwagen = New System.Windows.Forms.Label
        Me.chkAanhangwagen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txtAanhangwagenGewicht = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.lblBeschrijvingVoertuig = New System.Windows.Forms.Label
        Me.lblMerkEnAard = New System.Windows.Forms.Label
        Me.lblCylinderInhoud = New System.Windows.Forms.Label
        Me.lblBouwjaar = New System.Windows.Forms.Label
        Me.txtMerkEnAard = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtCylinderInhoud = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtBouwjaar = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblNummerplaat = New System.Windows.Forms.Label
        Me.lblChassisnummer = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNummerplaat = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtChassisnummer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtDatumLaatsteTechnControle = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnOphalenVoertuig = New System.Windows.Forms.Button
        Me.lblSchade = New System.Windows.Forms.Label
        Me.lblVerzekering = New System.Windows.Forms.Label
        Me.lblNaamMaatschappij = New System.Windows.Forms.Label
        Me.lblPolisnummer = New System.Windows.Forms.Label
        Me.lblBtwNr = New System.Windows.Forms.Label
        Me.txtPolisnummer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtBTWNr = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cobVerzekeringFirmas = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me._dataVerzFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas
        Me.btnZoek = New System.Windows.Forms.Button
        Me.txtAfdeling = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblAfdeling = New System.Windows.Forms.Label
        Me.btnOpslaan = New System.Windows.Forms.Button
        Me.UltraOptionSetBetrokkene = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me._dataTypeBetrokkene = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
        Me.txtAtlVervoerdePers = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txtRijbPlaatsUitgifte = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtLichamelijkeSchade = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMatSchade = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblLichamelijkeSchade = New System.Windows.Forms.Label
        Me.lblMaterieleSchade = New System.Windows.Forms.Label
        Me.ButtonCancel = New System.Windows.Forms.Button
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNaamVoornaam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGeboorteplaatsEnDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHandelendInNaamvan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefoon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRijbNummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRijbCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRijbDatumUitgifte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cobGebruikVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataGebruikVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetHoedanigheid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAanhangwagenGewicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMerkEnAard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCylinderInhoud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBouwjaar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNummerplaat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChassisnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatumLaatsteTechnControle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPolisnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBTWNr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cobVerzekeringFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAfdeling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetBetrokkene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataTypeBetrokkene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAtlVervoerdePers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRijbPlaatsUitgifte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLichamelijkeSchade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatSchade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBetrokkene
        '
        Me.lblBetrokkene.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBetrokkene.Location = New System.Drawing.Point(8, 8)
        Me.lblBetrokkene.Name = "lblBetrokkene"
        Me.lblBetrokkene.TabIndex = 0
        Me.lblBetrokkene.Text = "Betrokkene:"
        Me.lblBetrokkene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStamnummer
        '
        Me.lblStamnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStamnummer.Location = New System.Drawing.Point(112, 8)
        Me.lblStamnummer.Name = "lblStamnummer"
        Me.lblStamnummer.TabIndex = 1
        Me.lblStamnummer.Text = "Stamnummer:"
        Me.lblStamnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStamnummer
        '
        Me.txtStamnummer.Location = New System.Drawing.Point(272, 8)
        Me.txtStamnummer.Name = "txtStamnummer"
        Me.txtStamnummer.Nullable = True
        Me.txtStamnummer.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtStamnummer.Size = New System.Drawing.Size(100, 21)
        Me.txtStamnummer.TabIndex = 1
        Me.txtStamnummer.Value = Nothing
        '
        'lblNaamVoornaam
        '
        Me.lblNaamVoornaam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaamVoornaam.Location = New System.Drawing.Point(112, 32)
        Me.lblNaamVoornaam.Name = "lblNaamVoornaam"
        Me.lblNaamVoornaam.Size = New System.Drawing.Size(112, 23)
        Me.lblNaamVoornaam.TabIndex = 3
        Me.lblNaamVoornaam.Text = "Naam en voornaam:"
        Me.lblNaamVoornaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNaamVoornaam
        '
        Me.txtNaamVoornaam.Location = New System.Drawing.Point(272, 32)
        Me.txtNaamVoornaam.Name = "txtNaamVoornaam"
        Me.txtNaamVoornaam.ReadOnly = True
        Me.txtNaamVoornaam.Size = New System.Drawing.Size(520, 21)
        Me.txtNaamVoornaam.TabIndex = 4
        Me.txtNaamVoornaam.TabStop = False
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(272, 56)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.ReadOnly = True
        Me.txtAdres.Size = New System.Drawing.Size(520, 21)
        Me.txtAdres.TabIndex = 5
        Me.txtAdres.TabStop = False
        '
        'lblAdres
        '
        Me.lblAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdres.Location = New System.Drawing.Point(112, 56)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(112, 23)
        Me.lblAdres.TabIndex = 5
        Me.lblAdres.Text = "Adres:"
        Me.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGeboorteplaatsEnDatum
        '
        Me.txtGeboorteplaatsEnDatum.Location = New System.Drawing.Point(272, 80)
        Me.txtGeboorteplaatsEnDatum.Name = "txtGeboorteplaatsEnDatum"
        Me.txtGeboorteplaatsEnDatum.ReadOnly = True
        Me.txtGeboorteplaatsEnDatum.Size = New System.Drawing.Size(520, 21)
        Me.txtGeboorteplaatsEnDatum.TabIndex = 6
        Me.txtGeboorteplaatsEnDatum.TabStop = False
        '
        'lblGeboorteplaats
        '
        Me.lblGeboorteplaats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeboorteplaats.Location = New System.Drawing.Point(112, 80)
        Me.lblGeboorteplaats.Name = "lblGeboorteplaats"
        Me.lblGeboorteplaats.Size = New System.Drawing.Size(152, 23)
        Me.lblGeboorteplaats.TabIndex = 7
        Me.lblGeboorteplaats.Text = "Geboorteplaats en datum:"
        Me.lblGeboorteplaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHandelendInNaamvan
        '
        Me.txtHandelendInNaamvan.Location = New System.Drawing.Point(272, 128)
        Me.txtHandelendInNaamvan.Name = "txtHandelendInNaamvan"
        Me.txtHandelendInNaamvan.Size = New System.Drawing.Size(520, 21)
        Me.txtHandelendInNaamvan.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Handelend in naam van:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefoon
        '
        Me.lblTelefoon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefoon.Location = New System.Drawing.Point(496, 8)
        Me.lblTelefoon.Name = "lblTelefoon"
        Me.lblTelefoon.Size = New System.Drawing.Size(64, 23)
        Me.lblTelefoon.TabIndex = 11
        Me.lblTelefoon.Text = "Telefoon:"
        Me.lblTelefoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefoon
        '
        Me.txtTelefoon.Location = New System.Drawing.Point(568, 8)
        Me.txtTelefoon.Name = "txtTelefoon"
        Me.txtTelefoon.ReadOnly = True
        Me.txtTelefoon.Size = New System.Drawing.Size(224, 21)
        Me.txtTelefoon.TabIndex = 3
        Me.txtTelefoon.TabStop = False
        '
        'lblRijbewijs
        '
        Me.lblRijbewijs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRijbewijs.Location = New System.Drawing.Point(8, 160)
        Me.lblRijbewijs.Name = "lblRijbewijs"
        Me.lblRijbewijs.Size = New System.Drawing.Size(88, 23)
        Me.lblRijbewijs.TabIndex = 13
        Me.lblRijbewijs.Text = "Rijbewijs:"
        Me.lblRijbewijs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRijbNummer
        '
        Me.lblRijbNummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRijbNummer.Location = New System.Drawing.Point(112, 160)
        Me.lblRijbNummer.Name = "lblRijbNummer"
        Me.lblRijbNummer.TabIndex = 14
        Me.lblRijbNummer.Text = "Nummer:"
        Me.lblRijbNummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRijbCategorie
        '
        Me.lblRijbCategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRijbCategorie.Location = New System.Drawing.Point(112, 184)
        Me.lblRijbCategorie.Name = "lblRijbCategorie"
        Me.lblRijbCategorie.Size = New System.Drawing.Size(104, 23)
        Me.lblRijbCategorie.TabIndex = 15
        Me.lblRijbCategorie.Text = "Categorie:"
        Me.lblRijbCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRijbDatumUitgifte
        '
        Me.lblRijbDatumUitgifte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRijbDatumUitgifte.Location = New System.Drawing.Point(112, 208)
        Me.lblRijbDatumUitgifte.Name = "lblRijbDatumUitgifte"
        Me.lblRijbDatumUitgifte.Size = New System.Drawing.Size(104, 23)
        Me.lblRijbDatumUitgifte.TabIndex = 16
        Me.lblRijbDatumUitgifte.Text = "Datum uitgifte:"
        Me.lblRijbDatumUitgifte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlaatsUitgifte
        '
        Me.lblPlaatsUitgifte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaatsUitgifte.Location = New System.Drawing.Point(112, 232)
        Me.lblPlaatsUitgifte.Name = "lblPlaatsUitgifte"
        Me.lblPlaatsUitgifte.Size = New System.Drawing.Size(104, 23)
        Me.lblPlaatsUitgifte.TabIndex = 17
        Me.lblPlaatsUitgifte.Text = "Plaats uitgifte:"
        Me.lblPlaatsUitgifte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRijbNummer
        '
        Me.txtRijbNummer.Location = New System.Drawing.Point(192, 160)
        Me.txtRijbNummer.Name = "txtRijbNummer"
        Me.txtRijbNummer.Size = New System.Drawing.Size(200, 21)
        Me.txtRijbNummer.TabIndex = 9
        '
        'txtRijbCat
        '
        Me.txtRijbCat.Location = New System.Drawing.Point(192, 184)
        Me.txtRijbCat.Name = "txtRijbCat"
        Me.txtRijbCat.Size = New System.Drawing.Size(200, 21)
        Me.txtRijbCat.TabIndex = 10
        '
        'dtpRijbDatumUitgifte
        '
        Me.dtpRijbDatumUitgifte.Location = New System.Drawing.Point(192, 208)
        Me.dtpRijbDatumUitgifte.Name = "dtpRijbDatumUitgifte"
        Me.dtpRijbDatumUitgifte.TabIndex = 11
        '
        'lblGebruikVoertuig
        '
        Me.lblGebruikVoertuig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGebruikVoertuig.Location = New System.Drawing.Point(400, 160)
        Me.lblGebruikVoertuig.Name = "lblGebruikVoertuig"
        Me.lblGebruikVoertuig.Size = New System.Drawing.Size(96, 23)
        Me.lblGebruikVoertuig.TabIndex = 22
        Me.lblGebruikVoertuig.Text = "Gebruik voertuig:"
        Me.lblGebruikVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cobGebruikVoertuig
        '
        Me.cobGebruikVoertuig.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cobGebruikVoertuig.DataSource = Me._dataGebruikVoertuig.BBBRKTSP
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cobGebruikVoertuig.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Omschrijving"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cobGebruikVoertuig.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cobGebruikVoertuig.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cobGebruikVoertuig.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.cobGebruikVoertuig.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobGebruikVoertuig.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.cobGebruikVoertuig.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobGebruikVoertuig.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.cobGebruikVoertuig.DisplayLayout.MaxColScrollRegions = 1
        Me.cobGebruikVoertuig.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cobGebruikVoertuig.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cobGebruikVoertuig.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.cobGebruikVoertuig.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cobGebruikVoertuig.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.cobGebruikVoertuig.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cobGebruikVoertuig.DisplayLayout.Override.CellAppearance = Appearance8
        Me.cobGebruikVoertuig.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cobGebruikVoertuig.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.cobGebruikVoertuig.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Me.cobGebruikVoertuig.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.cobGebruikVoertuig.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cobGebruikVoertuig.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.cobGebruikVoertuig.DisplayLayout.Override.RowAppearance = Appearance11
        Me.cobGebruikVoertuig.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cobGebruikVoertuig.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.cobGebruikVoertuig.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cobGebruikVoertuig.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cobGebruikVoertuig.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cobGebruikVoertuig.DisplayMember = "SCF_BRK_TSP"
        Me.cobGebruikVoertuig.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cobGebruikVoertuig.Location = New System.Drawing.Point(408, 184)
        Me.cobGebruikVoertuig.Name = "cobGebruikVoertuig"
        Me.cobGebruikVoertuig.Size = New System.Drawing.Size(112, 21)
        Me.cobGebruikVoertuig.TabIndex = 13
        Me.cobGebruikVoertuig.ValueMember = "ID_BRK_TSP"
        '
        '_dataGebruikVoertuig
        '
        Me._dataGebruikVoertuig.DataSetName = "TDSGebruikVoertuig"
        Me._dataGebruikVoertuig.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'lblHoedanigheid
        '
        Me.lblHoedanigheid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoedanigheid.Location = New System.Drawing.Point(536, 160)
        Me.lblHoedanigheid.Name = "lblHoedanigheid"
        Me.lblHoedanigheid.Size = New System.Drawing.Size(96, 23)
        Me.lblHoedanigheid.TabIndex = 24
        Me.lblHoedanigheid.Text = "Hoedanigheid:"
        Me.lblHoedanigheid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraOptionSetHoedanigheid
        '
        Me.UltraOptionSetHoedanigheid.ItemAppearance = Appearance13
        ValueListItem1.DataValue = CType(0, Short)
        ValueListItem1.DisplayText = "Eigenaar"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Aangestelde"
        Me.UltraOptionSetHoedanigheid.Items.Add(ValueListItem1)
        Me.UltraOptionSetHoedanigheid.Items.Add(ValueListItem2)
        Me.UltraOptionSetHoedanigheid.Location = New System.Drawing.Point(648, 160)
        Me.UltraOptionSetHoedanigheid.Name = "UltraOptionSetHoedanigheid"
        Me.UltraOptionSetHoedanigheid.Size = New System.Drawing.Size(144, 32)
        Me.UltraOptionSetHoedanigheid.TabIndex = 14
        '
        'lblVervoerdePersonen
        '
        Me.lblVervoerdePersonen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVervoerdePersonen.Location = New System.Drawing.Point(536, 200)
        Me.lblVervoerdePersonen.Name = "lblVervoerdePersonen"
        Me.lblVervoerdePersonen.Size = New System.Drawing.Size(112, 23)
        Me.lblVervoerdePersonen.TabIndex = 15
        Me.lblVervoerdePersonen.Text = "Vervoerde personen:"
        Me.lblVervoerdePersonen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAanhangwagen
        '
        Me.lblAanhangwagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAanhangwagen.Location = New System.Drawing.Point(536, 224)
        Me.lblAanhangwagen.Name = "lblAanhangwagen"
        Me.lblAanhangwagen.Size = New System.Drawing.Size(112, 23)
        Me.lblAanhangwagen.TabIndex = 17
        Me.lblAanhangwagen.Text = "Aanhangwagen:"
        Me.lblAanhangwagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAanhangwagen
        '
        Me.chkAanhangwagen.Location = New System.Drawing.Point(648, 224)
        Me.chkAanhangwagen.Name = "chkAanhangwagen"
        Me.chkAanhangwagen.Size = New System.Drawing.Size(16, 20)
        Me.chkAanhangwagen.TabIndex = 18
        '
        'txtAanhangwagenGewicht
        '
        Me.txtAanhangwagenGewicht.Location = New System.Drawing.Point(672, 200)
        Me.txtAanhangwagenGewicht.Name = "txtAanhangwagenGewicht"
        Me.txtAanhangwagenGewicht.Nullable = True
        Me.txtAanhangwagenGewicht.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtAanhangwagenGewicht.Size = New System.Drawing.Size(120, 21)
        Me.txtAanhangwagenGewicht.TabIndex = 16
        Me.txtAanhangwagenGewicht.Value = Nothing
        '
        'lblBeschrijvingVoertuig
        '
        Me.lblBeschrijvingVoertuig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeschrijvingVoertuig.Location = New System.Drawing.Point(8, 264)
        Me.lblBeschrijvingVoertuig.Name = "lblBeschrijvingVoertuig"
        Me.lblBeschrijvingVoertuig.Size = New System.Drawing.Size(88, 24)
        Me.lblBeschrijvingVoertuig.TabIndex = 31
        Me.lblBeschrijvingVoertuig.Text = "Beschrijving voertuig:"
        Me.lblBeschrijvingVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMerkEnAard
        '
        Me.lblMerkEnAard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerkEnAard.Location = New System.Drawing.Point(112, 264)
        Me.lblMerkEnAard.Name = "lblMerkEnAard"
        Me.lblMerkEnAard.Size = New System.Drawing.Size(80, 23)
        Me.lblMerkEnAard.TabIndex = 32
        Me.lblMerkEnAard.Text = "Merk en aard:"
        Me.lblMerkEnAard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCylinderInhoud
        '
        Me.lblCylinderInhoud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCylinderInhoud.Location = New System.Drawing.Point(112, 288)
        Me.lblCylinderInhoud.Name = "lblCylinderInhoud"
        Me.lblCylinderInhoud.Size = New System.Drawing.Size(88, 23)
        Me.lblCylinderInhoud.TabIndex = 33
        Me.lblCylinderInhoud.Text = "CylinderInhoud:"
        Me.lblCylinderInhoud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBouwjaar
        '
        Me.lblBouwjaar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBouwjaar.Location = New System.Drawing.Point(112, 312)
        Me.lblBouwjaar.Name = "lblBouwjaar"
        Me.lblBouwjaar.Size = New System.Drawing.Size(88, 23)
        Me.lblBouwjaar.TabIndex = 34
        Me.lblBouwjaar.Text = "Bouwjaar:"
        Me.lblBouwjaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMerkEnAard
        '
        Me.txtMerkEnAard.Location = New System.Drawing.Point(192, 264)
        Me.txtMerkEnAard.Name = "txtMerkEnAard"
        Me.txtMerkEnAard.ReadOnly = True
        Me.txtMerkEnAard.Size = New System.Drawing.Size(208, 21)
        Me.txtMerkEnAard.TabIndex = 21
        Me.txtMerkEnAard.TabStop = False
        '
        'txtCylinderInhoud
        '
        Me.txtCylinderInhoud.Location = New System.Drawing.Point(192, 288)
        Me.txtCylinderInhoud.Name = "txtCylinderInhoud"
        Me.txtCylinderInhoud.ReadOnly = True
        Me.txtCylinderInhoud.Size = New System.Drawing.Size(208, 21)
        Me.txtCylinderInhoud.TabIndex = 22
        Me.txtCylinderInhoud.TabStop = False
        '
        'txtBouwjaar
        '
        Me.txtBouwjaar.Location = New System.Drawing.Point(192, 312)
        Me.txtBouwjaar.Name = "txtBouwjaar"
        Me.txtBouwjaar.ReadOnly = True
        Me.txtBouwjaar.Size = New System.Drawing.Size(208, 21)
        Me.txtBouwjaar.TabIndex = 23
        Me.txtBouwjaar.TabStop = False
        '
        'lblNummerplaat
        '
        Me.lblNummerplaat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNummerplaat.Location = New System.Drawing.Point(416, 264)
        Me.lblNummerplaat.Name = "lblNummerplaat"
        Me.lblNummerplaat.Size = New System.Drawing.Size(80, 23)
        Me.lblNummerplaat.TabIndex = 38
        Me.lblNummerplaat.Text = "Nummerplaat:"
        Me.lblNummerplaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChassisnummer
        '
        Me.lblChassisnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChassisnummer.Location = New System.Drawing.Point(416, 288)
        Me.lblChassisnummer.Name = "lblChassisnummer"
        Me.lblChassisnummer.Size = New System.Drawing.Size(96, 23)
        Me.lblChassisnummer.TabIndex = 39
        Me.lblChassisnummer.Text = "Chassisnummer:"
        Me.lblChassisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Datum laatste techn. controle:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNummerplaat
        '
        Me.txtNummerplaat.Location = New System.Drawing.Point(504, 264)
        Me.txtNummerplaat.Name = "txtNummerplaat"
        Me.txtNummerplaat.ReadOnly = True
        Me.txtNummerplaat.Size = New System.Drawing.Size(288, 21)
        Me.txtNummerplaat.TabIndex = 24
        Me.txtNummerplaat.TabStop = False
        '
        'txtChassisnummer
        '
        Me.txtChassisnummer.Location = New System.Drawing.Point(504, 288)
        Me.txtChassisnummer.Name = "txtChassisnummer"
        Me.txtChassisnummer.ReadOnly = True
        Me.txtChassisnummer.Size = New System.Drawing.Size(288, 21)
        Me.txtChassisnummer.TabIndex = 25
        Me.txtChassisnummer.TabStop = False
        '
        'txtDatumLaatsteTechnControle
        '
        Me.txtDatumLaatsteTechnControle.Location = New System.Drawing.Point(576, 312)
        Me.txtDatumLaatsteTechnControle.Name = "txtDatumLaatsteTechnControle"
        Me.txtDatumLaatsteTechnControle.ReadOnly = True
        Me.txtDatumLaatsteTechnControle.Size = New System.Drawing.Size(216, 21)
        Me.txtDatumLaatsteTechnControle.TabIndex = 26
        Me.txtDatumLaatsteTechnControle.TabStop = False
        '
        'btnOphalenVoertuig
        '
        Me.btnOphalenVoertuig.Location = New System.Drawing.Point(16, 296)
        Me.btnOphalenVoertuig.Name = "btnOphalenVoertuig"
        Me.btnOphalenVoertuig.Size = New System.Drawing.Size(75, 32)
        Me.btnOphalenVoertuig.TabIndex = 20
        Me.btnOphalenVoertuig.Text = "Ophalen voertuig"
        '
        'lblSchade
        '
        Me.lblSchade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchade.Location = New System.Drawing.Point(8, 344)
        Me.lblSchade.Name = "lblSchade"
        Me.lblSchade.Size = New System.Drawing.Size(88, 24)
        Me.lblSchade.TabIndex = 45
        Me.lblSchade.Text = "Schade:"
        Me.lblSchade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerzekering
        '
        Me.lblVerzekering.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerzekering.Location = New System.Drawing.Point(8, 400)
        Me.lblVerzekering.Name = "lblVerzekering"
        Me.lblVerzekering.Size = New System.Drawing.Size(88, 24)
        Me.lblVerzekering.TabIndex = 48
        Me.lblVerzekering.Text = "Verzekering:"
        Me.lblVerzekering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNaamMaatschappij
        '
        Me.lblNaamMaatschappij.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaamMaatschappij.Location = New System.Drawing.Point(112, 400)
        Me.lblNaamMaatschappij.Name = "lblNaamMaatschappij"
        Me.lblNaamMaatschappij.Size = New System.Drawing.Size(192, 23)
        Me.lblNaamMaatschappij.TabIndex = 49
        Me.lblNaamMaatschappij.Text = "Naam van maatschappij:"
        Me.lblNaamMaatschappij.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPolisnummer
        '
        Me.lblPolisnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPolisnummer.Location = New System.Drawing.Point(112, 432)
        Me.lblPolisnummer.Name = "lblPolisnummer"
        Me.lblPolisnummer.Size = New System.Drawing.Size(88, 23)
        Me.lblPolisnummer.TabIndex = 50
        Me.lblPolisnummer.Text = "Polisnummer:"
        Me.lblPolisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBtwNr
        '
        Me.lblBtwNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtwNr.Location = New System.Drawing.Point(432, 432)
        Me.lblBtwNr.Name = "lblBtwNr"
        Me.lblBtwNr.Size = New System.Drawing.Size(64, 23)
        Me.lblBtwNr.TabIndex = 51
        Me.lblBtwNr.Text = "BTW-nr:"
        Me.lblBtwNr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPolisnummer
        '
        Me.txtPolisnummer.Location = New System.Drawing.Point(184, 432)
        Me.txtPolisnummer.Name = "txtPolisnummer"
        Me.txtPolisnummer.Size = New System.Drawing.Size(232, 21)
        Me.txtPolisnummer.TabIndex = 30
        '
        'txtBTWNr
        '
        Me.txtBTWNr.Location = New System.Drawing.Point(512, 432)
        Me.txtBTWNr.Name = "txtBTWNr"
        Me.txtBTWNr.Size = New System.Drawing.Size(280, 21)
        Me.txtBTWNr.TabIndex = 31
        '
        'cobVerzekeringFirmas
        '
        Me.cobVerzekeringFirmas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cobVerzekeringFirmas.DataSource = Me._dataVerzFirmas
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cobVerzekeringFirmas.DisplayLayout.Appearance = Appearance14
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Naam"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 198
        UltraGridColumn5.Header.Caption = "Adres"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn6.Header.Caption = "Plaats"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.cobVerzekeringFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cobVerzekeringFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cobVerzekeringFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.cobVerzekeringFirmas.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobVerzekeringFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.cobVerzekeringFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobVerzekeringFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.cobVerzekeringFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.cobVerzekeringFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cobVerzekeringFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cobVerzekeringFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.cobVerzekeringFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cobVerzekeringFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.cobVerzekeringFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cobVerzekeringFirmas.DisplayLayout.Override.CellAppearance = Appearance21
        Me.cobVerzekeringFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cobVerzekeringFirmas.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.cobVerzekeringFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Me.cobVerzekeringFirmas.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.cobVerzekeringFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cobVerzekeringFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.cobVerzekeringFirmas.DisplayLayout.Override.RowAppearance = Appearance24
        Me.cobVerzekeringFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cobVerzekeringFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance25
        Me.cobVerzekeringFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cobVerzekeringFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cobVerzekeringFirmas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cobVerzekeringFirmas.DisplayMember = "NM_FRM_VZK"
        Me.cobVerzekeringFirmas.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cobVerzekeringFirmas.Location = New System.Drawing.Point(248, 400)
        Me.cobVerzekeringFirmas.Name = "cobVerzekeringFirmas"
        Me.cobVerzekeringFirmas.Size = New System.Drawing.Size(544, 21)
        Me.cobVerzekeringFirmas.TabIndex = 29
        Me.cobVerzekeringFirmas.ValueMember = "ID_FRM_VZK"
        '
        '_dataVerzFirmas
        '
        Me._dataVerzFirmas.DataSetName = "TDSVerzFirmas"
        Me._dataVerzFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnZoek
        '
        Me.btnZoek.Location = New System.Drawing.Point(384, 8)
        Me.btnZoek.Name = "btnZoek"
        Me.btnZoek.TabIndex = 2
        Me.btnZoek.Text = "Opzoeken"
        '
        'txtAfdeling
        '
        Me.txtAfdeling.Location = New System.Drawing.Point(272, 104)
        Me.txtAfdeling.Name = "txtAfdeling"
        Me.txtAfdeling.ReadOnly = True
        Me.txtAfdeling.Size = New System.Drawing.Size(520, 21)
        Me.txtAfdeling.TabIndex = 7
        Me.txtAfdeling.TabStop = False
        '
        'lblAfdeling
        '
        Me.lblAfdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfdeling.Location = New System.Drawing.Point(112, 104)
        Me.lblAfdeling.Name = "lblAfdeling"
        Me.lblAfdeling.Size = New System.Drawing.Size(152, 23)
        Me.lblAfdeling.TabIndex = 57
        Me.lblAfdeling.Text = "Afdeling"
        Me.lblAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Image = CType(resources.GetObject("btnOpslaan.Image"), System.Drawing.Image)
        Me.btnOpslaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpslaan.Location = New System.Drawing.Point(728, 464)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(64, 24)
        Me.btnOpslaan.TabIndex = 32
        Me.btnOpslaan.Text = "OK"
        '
        'UltraOptionSetBetrokkene
        '
        Me.UltraOptionSetBetrokkene.DataSource = Me._dataTypeBetrokkene.BBTYBTRK
        Me.UltraOptionSetBetrokkene.DisplayMember = "SCF_TY_BTRK"
        Me.UltraOptionSetBetrokkene.ItemAppearance = Appearance26
        Me.UltraOptionSetBetrokkene.Location = New System.Drawing.Point(16, 40)
        Me.UltraOptionSetBetrokkene.Name = "UltraOptionSetBetrokkene"
        Me.UltraOptionSetBetrokkene.Size = New System.Drawing.Size(80, 96)
        Me.UltraOptionSetBetrokkene.TabIndex = 0
        Me.UltraOptionSetBetrokkene.ValueMember = "ID_TY_BTRK"
        '
        '_dataTypeBetrokkene
        '
        Me._dataTypeBetrokkene.DataSetName = "TDSTypeBetrokkene"
        Me._dataTypeBetrokkene.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'txtAtlVervoerdePers
        '
        Me.txtAtlVervoerdePers.Location = New System.Drawing.Point(672, 224)
        Me.txtAtlVervoerdePers.Name = "txtAtlVervoerdePers"
        Me.txtAtlVervoerdePers.Nullable = True
        Me.txtAtlVervoerdePers.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.txtAtlVervoerdePers.Size = New System.Drawing.Size(120, 21)
        Me.txtAtlVervoerdePers.TabIndex = 19
        Me.txtAtlVervoerdePers.Value = Nothing
        '
        'txtRijbPlaatsUitgifte
        '
        Me.txtRijbPlaatsUitgifte.Location = New System.Drawing.Point(192, 232)
        Me.txtRijbPlaatsUitgifte.Name = "txtRijbPlaatsUitgifte"
        Me.txtRijbPlaatsUitgifte.Size = New System.Drawing.Size(200, 21)
        Me.txtRijbPlaatsUitgifte.TabIndex = 12
        '
        'txtLichamelijkeSchade
        '
        Me.txtLichamelijkeSchade.Location = New System.Drawing.Point(240, 344)
        Me.txtLichamelijkeSchade.Name = "txtLichamelijkeSchade"
        Me.txtLichamelijkeSchade.Size = New System.Drawing.Size(552, 21)
        Me.txtLichamelijkeSchade.TabIndex = 27
        '
        'txtMatSchade
        '
        Me.txtMatSchade.Location = New System.Drawing.Point(240, 368)
        Me.txtMatSchade.Name = "txtMatSchade"
        Me.txtMatSchade.Size = New System.Drawing.Size(552, 21)
        Me.txtMatSchade.TabIndex = 28
        '
        'lblLichamelijkeSchade
        '
        Me.lblLichamelijkeSchade.Location = New System.Drawing.Point(112, 344)
        Me.lblLichamelijkeSchade.Name = "lblLichamelijkeSchade"
        Me.lblLichamelijkeSchade.Size = New System.Drawing.Size(112, 23)
        Me.lblLichamelijkeSchade.TabIndex = 58
        Me.lblLichamelijkeSchade.Text = "Lichamelijke schade"
        Me.lblLichamelijkeSchade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaterieleSchade
        '
        Me.lblMaterieleSchade.Location = New System.Drawing.Point(112, 368)
        Me.lblMaterieleSchade.Name = "lblMaterieleSchade"
        Me.lblMaterieleSchade.Size = New System.Drawing.Size(120, 23)
        Me.lblMaterieleSchade.TabIndex = 59
        Me.lblMaterieleSchade.Text = "Materiële schade"
        Me.lblMaterieleSchade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Image = CType(resources.GetObject("ButtonCancel.Image"), System.Drawing.Image)
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(632, 464)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(80, 24)
        Me.ButtonCancel.TabIndex = 60
        Me.ButtonCancel.Text = "Annuleren"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormBewakingBetrokkene
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.lblMaterieleSchade)
        Me.Controls.Add(Me.lblLichamelijkeSchade)
        Me.Controls.Add(Me.txtMatSchade)
        Me.Controls.Add(Me.txtLichamelijkeSchade)
        Me.Controls.Add(Me.txtRijbPlaatsUitgifte)
        Me.Controls.Add(Me.txtAtlVervoerdePers)
        Me.Controls.Add(Me.UltraOptionSetBetrokkene)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.txtAfdeling)
        Me.Controls.Add(Me.lblAfdeling)
        Me.Controls.Add(Me.btnZoek)
        Me.Controls.Add(Me.cobVerzekeringFirmas)
        Me.Controls.Add(Me.txtBTWNr)
        Me.Controls.Add(Me.txtPolisnummer)
        Me.Controls.Add(Me.lblBtwNr)
        Me.Controls.Add(Me.lblPolisnummer)
        Me.Controls.Add(Me.lblNaamMaatschappij)
        Me.Controls.Add(Me.lblVerzekering)
        Me.Controls.Add(Me.lblSchade)
        Me.Controls.Add(Me.btnOphalenVoertuig)
        Me.Controls.Add(Me.txtDatumLaatsteTechnControle)
        Me.Controls.Add(Me.txtChassisnummer)
        Me.Controls.Add(Me.txtNummerplaat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblChassisnummer)
        Me.Controls.Add(Me.lblNummerplaat)
        Me.Controls.Add(Me.txtBouwjaar)
        Me.Controls.Add(Me.txtCylinderInhoud)
        Me.Controls.Add(Me.txtMerkEnAard)
        Me.Controls.Add(Me.lblBouwjaar)
        Me.Controls.Add(Me.lblCylinderInhoud)
        Me.Controls.Add(Me.lblMerkEnAard)
        Me.Controls.Add(Me.lblBeschrijvingVoertuig)
        Me.Controls.Add(Me.txtAanhangwagenGewicht)
        Me.Controls.Add(Me.chkAanhangwagen)
        Me.Controls.Add(Me.lblAanhangwagen)
        Me.Controls.Add(Me.lblVervoerdePersonen)
        Me.Controls.Add(Me.UltraOptionSetHoedanigheid)
        Me.Controls.Add(Me.lblHoedanigheid)
        Me.Controls.Add(Me.cobGebruikVoertuig)
        Me.Controls.Add(Me.lblGebruikVoertuig)
        Me.Controls.Add(Me.dtpRijbDatumUitgifte)
        Me.Controls.Add(Me.txtRijbCat)
        Me.Controls.Add(Me.txtRijbNummer)
        Me.Controls.Add(Me.lblPlaatsUitgifte)
        Me.Controls.Add(Me.lblRijbDatumUitgifte)
        Me.Controls.Add(Me.lblRijbCategorie)
        Me.Controls.Add(Me.lblRijbNummer)
        Me.Controls.Add(Me.lblRijbewijs)
        Me.Controls.Add(Me.txtTelefoon)
        Me.Controls.Add(Me.lblTelefoon)
        Me.Controls.Add(Me.txtHandelendInNaamvan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGeboorteplaatsEnDatum)
        Me.Controls.Add(Me.lblGeboorteplaats)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.lblAdres)
        Me.Controls.Add(Me.txtNaamVoornaam)
        Me.Controls.Add(Me.lblNaamVoornaam)
        Me.Controls.Add(Me.txtStamnummer)
        Me.Controls.Add(Me.lblStamnummer)
        Me.Controls.Add(Me.lblBetrokkene)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "FormBewakingBetrokkene"
        Me.Text = "Gegegevens betrokkene"
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNaamVoornaam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGeboorteplaatsEnDatum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHandelendInNaamvan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefoon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRijbNummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRijbCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRijbDatumUitgifte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cobGebruikVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataGebruikVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetHoedanigheid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAanhangwagenGewicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMerkEnAard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCylinderInhoud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBouwjaar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNummerplaat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChassisnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatumLaatsteTechnControle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPolisnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBTWNr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cobVerzekeringFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAfdeling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetBetrokkene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataTypeBetrokkene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAtlVervoerdePers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRijbPlaatsUitgifte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLichamelijkeSchade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatSchade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub setPersoonsGegevens(ByVal stamnummer As String)
        Try
            Dim oIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen.BBINDRow
            oIndividu = Me._controller.GetIndividu(stamnummer)
            If oIndividu.BBIND.Count > 0 Then
                aRow = oIndividu.BBIND(0)
                If aRow.IsNM_INDNull = False Then
                    Me.txtNaamVoornaam.Text = aRow.NM_IND.Trim & " "
                Else
                    Me.txtNaamVoornaam.Text = ""
                End If
                If aRow.IsVNM_INDNull = False Then
                    Me.txtNaamVoornaam.Text &= aRow.VNM_IND.Trim
                End If
                If aRow.IsAD_INDNull = False Then
                    Me.txtAdres.Text = aRow.AD_IND.Trim & ", "
                Else
                    Me.txtAdres.Text = ""
                End If
                If aRow.IsPO_COD_WNPL_INDNull = False Then
                    Me.txtAdres.Text &= aRow.PO_COD_WNPL_IND() & " "
                End If
                If aRow.IsWNPL_INDNull = False Then
                    Me.txtAdres.Text &= aRow.WNPL_IND
                End If
                If aRow.IsPLA_GBR_INDNull = False Then
                    Me.txtGeboorteplaatsEnDatum.Text = aRow.PLA_GBR_IND & " "
                Else
                    Me.txtGeboorteplaatsEnDatum.Text = ""
                End If
                If aRow.IsDT_GBR_INDNull = False Then
                    Me.txtGeboorteplaatsEnDatum.Text &= aRow.DT_GBR_IND
                Else
                    Me.txtGeboorteplaatsEnDatum.Text = ""
                End If
                If aRow.IsAD_INDNull = False Then
                    Me.txtAfdeling.Text = aRow.AD_IND
                Else
                    Me.txtAfdeling.Text = ""
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnOphalenVoertuig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOphalenVoertuig.Click
        Try
            Dim oFormVoertuig As New FormBewakingVoertuig
            oFormVoertuig.ShowDialog(Me)

            Me._oRowVoertuig = oFormVoertuig.Voertuig

            If Not _oRowVoertuig Is Nothing Then
                If _oRowVoertuig.IsSCF_MRK_TSPNull = False Then
                    Me.txtMerkEnAard.Text = _oRowVoertuig.SCF_MRK_TSP
                End If
                If _oRowVoertuig.IsINH_CYL_TSPNull = False Then
                    Me.txtCylinderInhoud.Text = _oRowVoertuig.INH_CYL_TSP
                End If
                If _oRowVoertuig.IsJR_BOU_TSPNull = False Then
                    Me.txtBouwjaar.Text = _oRowVoertuig.JR_BOU_TSP
                End If
                If _oRowVoertuig.IsPL_NR_TSPNull = False Then
                    Me.txtNummerplaat.Text = _oRowVoertuig.PL_NR_TSP
                End If
                If _oRowVoertuig.IsNR_CHAS_TSPNull = False Then
                    Me.txtChassisnummer.Text = _oRowVoertuig.NR_CHAS_TSP
                End If
                If _oRowVoertuig.IsDT_KEU_L_TSPNull = False Then
                    Me.txtDatumLaatsteTechnControle.Text = _oRowVoertuig.DT_KEU_L_TSP
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setGegevensVoertuig(ByVal id_tsp As Integer)
        Try
            Dim oVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen
            oVoertuig = Me._controller.GetVoertuigen()
            If oVoertuig.BBTSP.Count > 0 Then
                Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen.BBTSPRow
                aRow = oVoertuig.BBTSP.Select("ID_TSP = " & id_tsp)(0)
                'aRow = oVoertuig.BBTSP(0)

                If aRow.IsSCF_MRK_TSPNull = False Then
                    Me.txtMerkEnAard.Text = aRow.SCF_MRK_TSP
                End If
                If aRow.IsINH_CYL_TSPNull = False Then
                    Me.txtCylinderInhoud.Text = aRow.INH_CYL_TSP
                End If
                If aRow.IsJR_BOU_TSPNull = False Then
                    Me.txtBouwjaar.Text = aRow.JR_BOU_TSP
                End If
                If aRow.IsPL_NR_TSPNull = False Then
                    Me.txtNummerplaat.Text = aRow.PL_NR_TSP
                End If
                If aRow.IsNR_CHAS_TSPNull = False Then
                    Me.txtChassisnummer.Text = aRow.NR_CHAS_TSP
                End If
                If aRow.IsDT_KEU_L_TSPNull = False Then
                    Me.txtDatumLaatsteTechnControle.Text = aRow.DT_KEU_L_TSP().ToString("dd/MM/yyyy")
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub FormBewakingBetrokkene_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me._dataGebruikVoertuig.Merge(_controller.GetGebruikVoertuig())
            Me._dataVerzFirmas.Merge(_controller.GetVerzFirmas())
            Me._dataTypeBetrokkene.Merge(_controller.GetTypeBetrokkenen())


            Me.UltraOptionSetHoedanigheid.Value = 0 'eigenaar
            Me.UltraOptionSetBetrokkene.Value = 1 'Sidmar, 2 = derden
            'Me.cobGebruikVoertuig.v = 1 '

            If Not Me._betrokkene Is Nothing And Me._isNew = False Then



                ' *******Betrokkene***********
                'Advh stamnummer --> persoon invullen
                If Not Me._betrokkene.IsID_IND_BTRKNull Then
                    Me.txtStamnummer.Text = Me._betrokkene.ID_IND_BTRK
                End If

                If Not Me._betrokkene.IsHD_NM_VNNull Then
                    Me.txtHandelendInNaamvan.Text = Me._betrokkene.HD_NM_VN
                End If

                If Not Me._betrokkene.IsID_TY_BTRKNull Then
                    Me.UltraOptionSetBetrokkene.Value = Me._betrokkene.ID_TY_BTRK()
                End If


                'Ophalen persoonsgegevens
                setPersoonsGegevens(Me._betrokkene.ID_IND_BTRK)
                '*******Rijbewijs ************
                If Not Me._betrokkene.IsRB_NRNull Then
                    Me.txtRijbNummer.Text = Me._betrokkene.RB_NR
                End If
                If Not Me._betrokkene.IsRB_CATNull Then
                    Me.txtRijbCat.Text = Me._betrokkene.RB_CAT
                End If
                If Not Me._betrokkene.IsRB_DAT_UITGNull Then
                    Me.dtpRijbDatumUitgifte.Value = Me._betrokkene.RB_DAT_UITG
                End If
                If Not Me._betrokkene.IsRB_PL_UITGNull Then
                    Me.txtRijbPlaatsUitgifte.Value = Me._betrokkene.RB_PL_UITG
                End If

                If Not Me._betrokkene.IsID_BRK_TSPNull Then
                    Me.cobGebruikVoertuig.Value = Me._betrokkene.ID_BRK_TSP
                End If
                If Not Me._betrokkene.IsKAR_TSPNull Then
                    Me.UltraOptionSetHoedanigheid.Value = IIf(Me._betrokkene.KAR_TSP = True, 1, 0)
                End If
                If Not Me._betrokkene.IsQ_IND_TSP_BRTKNull Then
                    Me.txtAtlVervoerdePers.Text = Me._betrokkene.Q_IND_TSP_BRTK
                End If
                If Not Me._betrokkene.IsINDI_TRL_VKM_TSPNull Then
                    Me.chkAanhangwagen.Checked = Me._betrokkene.INDI_TRL_VKM_TSP()
                End If

                If Me.chkAanhangwagen.Checked = True Then
                    If Me._betrokkene.IsSCF_Q_KG_VKM_TSPNull Then
                        Me.txtAanhangwagenGewicht.Text = Me._betrokkene.SCF_Q_KG_VKM_TSP
                    Else
                        Me.txtAanhangwagenGewicht.Text = ""
                    End If
                Else
                    Me.txtAanhangwagenGewicht.Text = ""
                End If

                If Me._betrokkene.IsID_TSPNull Then
                    Me.txtMerkEnAard.Text = ""
                    Me.txtCylinderInhoud.Text = ""
                    Me.txtBouwjaar.Text = ""
                    Me.txtNummerplaat.Text = ""
                    Me.txtChassisnummer.Text = ""
                    Me.txtDatumLaatsteTechnControle.Text = ""
                Else
                    'Ophalen informatie voertuig 
                    Dim id_tsp As Integer = Me._betrokkene.ID_TSP() '--> relatie naar voertuig
                    setGegevensVoertuig(id_tsp)
                End If

                '******Schade******
                'Lichamelijke schade
                Me.txtLichamelijkeSchade.Text = Me._betrokkene.ROMP_LTSL
                Me.txtMatSchade.Text = Me._betrokkene.MAT_LTSL

                '******Verzekering
                If Not Me._betrokkene.IsID_FRM_VZKNull Then
                    Me.cobVerzekeringFirmas.Value = Me._betrokkene.ID_FRM_VZK
                End If
                If Not Me._betrokkene.IsNR_POLISNull Then
                    Me.txtPolisnummer.Text = Me._betrokkene.NR_POLIS
                End If
                If Not Me._betrokkene.IsBTW_NRNull Then
                    Me.txtBTWNr.Text = Me._betrokkene.BTW_NR
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub btnZoek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoek.Click
        Try
            Dim oFormIndividu As New FormIndividuen(False, String.Empty)
            oFormIndividu.ShowDialog(Me)

            Me._oRowIndividu = oFormIndividu.Individu()

            invullenIndividu()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Public Function controleGegevensIngevuldOK() As Boolean

        If Me.txtStamnummer.Text.Trim = "" Then
            MessageBox.Show("Gelieve een stamnummer in te vullen.")
            Return False
        End If

        If Me.txtRijbNummer.Text.Trim = "" Then
            MessageBox.Show("Gelieve een rijbewijsnummer in te vullen.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpslaan.Click
        'Gegevens niet opslaan indien je de reg_id niet gekend is.
        'Auteur: Dien - okt. 2006
        Try
            If controleGegevensIngevuldOK() = True Then
                Me._betrokkene.ID_REG = Me._idRegistratie
                '********Betrokkene***********
                'stamnummer betrokkene
                Me._betrokkene.ID_IND_BTRK = Me.txtStamnummer.Text

                'Naam en voornaam invullen om in grid te kunnen tonen
                If Not Me._oRowIndividu Is Nothing Then
                    If Not Me._oRowIndividu.IsNM_INDNull Then
                        Me._betrokkene.NM_IND = _oRowIndividu.NM_IND
                    End If
                    If Not Me._oRowIndividu.IsVNM_INDNull Then
                        Me._betrokkene.VNM_IND = _oRowIndividu.VNM_IND
                    End If
                End If

                'Handelend in naam van
                Me._betrokkene.HD_NM_VN = Me.txtHandelendInNaamvan.Text
                'Id. type betrokkene
                Me._betrokkene.ID_TY_BTRK = Me.UltraOptionSetBetrokkene.Value

                '************Rijbewijs********
                'Rijbewijsnummer
                Me._betrokkene.RB_NR = Me.txtRijbNummer.Text
                'Rijbewijscategorie
                Me._betrokkene.RB_CAT = Me.txtRijbCat.Text
                'Rijbewijs datum uitgifte
                Me._betrokkene.RB_DAT_UITG = Me.dtpRijbDatumUitgifte.Value
                'Rijbewijs plaats uitgifte 
                Me._betrokkene.RB_PL_UITG = Me.txtRijbPlaatsUitgifte.Value

                'Id. v/h. gebruik v/h. voertuig.
                Me._betrokkene.ID_BRK_TSP = Me.cobGebruikVoertuig.Value
                'Hoedanigheid v/h. voertuig.
                Me._betrokkene.KAR_TSP = IIf(Me.UltraOptionSetHoedanigheid.Value = 1, True, False)
                'Atl. personen vervoerd.
                Me._betrokkene.Q_IND_TSP_BRTK = Me.txtAtlVervoerdePers.Text
                'Met aanhangwagen.
                Me._betrokkene.INDI_TRL_VKM_TSP = Me.chkAanhangwagen.Checked
                'Gewicht aanhangwagen.
                If Me.chkAanhangwagen.Checked = True Then
                    Me._betrokkene.SCF_Q_KG_VKM_TSP = Me.txtAanhangwagenGewicht.Text
                Else
                    Me._betrokkene.SCF_Q_KG_VKM_TSP = ""
                End If

                If Not _oRowVoertuig Is Nothing Then
                    'Voertuig.
                    Me._betrokkene.ID_TSP = _oRowVoertuig.ID_TSP
                End If


                '******Schade******
                'Lichamelijke schade 
                Me._betrokkene.ROMP_LTSL = Me.txtLichamelijkeSchade.Text
                Me._betrokkene.MAT_LTSL = Me.txtMatSchade.Text

                '******Verzekering
                Me._betrokkene.ID_FRM_VZK = Me.cobVerzekeringFirmas.Value
                Me._betrokkene.NR_POLIS = Me.txtPolisnummer.Text
                Me._betrokkene.BTW_NR = Me.txtBTWNr.Text

                If Me._isNew = True Then
                    'Tenslotte wijzigingen toevoegen.
                    Me._dataBetrokkenen.AddBBBTROGVRow(Me._betrokkene)
                End If

                Me.Close()
            End If
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
                    Me._oRowIndividu = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(Me.txtStamnummer.Text.Trim)
                    invullenIndividu()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub invullenIndividu()
        Try
            'Naam & sap directie & sap afdeling.
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
            If Not _oRowIndividu Is Nothing Then
                Me.txtStamnummer.Text = _oRowIndividu.ID_IND
                aRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(Me.txtStamnummer.Text.Trim)
                If _oRowIndividu.IsNR_TEL_SIDNull = False Then
                    Me.txtTelefoon.Text = _oRowIndividu.NR_TEL_SID
                End If

                If _oRowIndividu.IsNM_INDNull = False Then
                    Me.txtNaamVoornaam.Text = _oRowIndividu.NM_IND
                End If

                If _oRowIndividu.IsVNM_INDNull = False Then
                    Me.txtNaamVoornaam.Text &= " " & _oRowIndividu.VNM_IND
                End If

                If _oRowIndividu.IsAD_INDNull = False Then
                    Me.txtAdres.Text = _oRowIndividu.AD_IND
                End If
                If _oRowIndividu.IsPO_COD_WNPL_INDNull = False Then
                    Me.txtAdres.Text &= ", " & _oRowIndividu.PO_COD_WNPL_IND
                End If

                If _oRowIndividu.IsPLA_GBR_INDNull = False Then
                    Me.txtGeboorteplaatsEnDatum.Text = _oRowIndividu.PLA_GBR_IND
                End If

                If _oRowIndividu.IsDT_GBR_INDNull = False Then
                    Me.txtGeboorteplaatsEnDatum.Text &= " " & _oRowIndividu.DT_GBR_IND
                End If

                If _oRowIndividu.IsSAP_AFDNull = False Then
                    Me.txtAfdeling.Text = _oRowIndividu.SAP_AFD
                End If
            Else
                Me.txtStamnummer.Text = 0
                Me.txtNaamVoornaam.Text = ""
                Me.txtAdres.Text = ""
                Me.txtGeboorteplaatsEnDatum.Text = ""
                Me.txtAfdeling.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        'Author: Nancy Coppens - 16/10/2007
        'Purpose: gewoon sluiten, zonder bewaren
        Me.Close()

    End Sub
End Class
