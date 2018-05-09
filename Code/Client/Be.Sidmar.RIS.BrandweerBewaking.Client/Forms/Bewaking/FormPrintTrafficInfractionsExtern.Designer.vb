<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintTrafficInfractionsExtern
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanction", -1)
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDescr")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionNL")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionFR")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionEN")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDE")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Overtredingen", -1)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_dir")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_afd")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_sect")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieDuur")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctiePeriode")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inbreukklasse")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20+")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FirmaId")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionId")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inbreukKlasseId")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remarks")
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.UltraComboSanction = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataBewakingSnelheidSanction = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction()
        Me.LabelSanction = New System.Windows.Forms.Label()
        Me.GroupBoxInfractions = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInbr3 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbr2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbr1 = New System.Windows.Forms.RadioButton()
        Me.UltraDateAfspraakPBH = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelAfspraak = New System.Windows.Forms.Label()
        Me.GroupBoxDates = New System.Windows.Forms.GroupBox()
        Me.LabelDatumPrint = New System.Windows.Forms.Label()
        Me.UltraDateTimeletterSend = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelRijverbodTot = New System.Windows.Forms.Label()
        Me.UltraDateRijverbodVan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelRijverbodVan = New System.Windows.Forms.Label()
        Me.UltraDateRijverbodTot = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelLanguage = New System.Windows.Forms.Label()
        Me.GroupBoxInfraction = New System.Windows.Forms.GroupBox()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.ButtonZoekFirma = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelAddressFirm = New System.Windows.Forms.Label()
        Me.TextBoxCityFirm = New System.Windows.Forms.TextBox()
        Me.TextBoxAddressFirm = New System.Windows.Forms.TextBox()
        Me.TextBoxNameFirm = New System.Windows.Forms.TextBox()
        Me.LabelNameFirm = New System.Windows.Forms.Label()
        Me.TextBoxVoertuig = New System.Windows.Forms.TextBox()
        Me.LabelTypeCar = New System.Windows.Forms.Label()
        Me.TextBoxNrPlate = New System.Windows.Forms.TextBox()
        Me.LabelLicensePlate = New System.Windows.Forms.Label()
        Me.TextBoxDriverName = New System.Windows.Forms.TextBox()
        Me.LabelNameDriver = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDoubleUp = New System.Windows.Forms.CheckBox()
        Me.TextBoxSanctionPeriod = New System.Windows.Forms.TextBox()
        Me.LabelSanctionPeriod = New System.Windows.Forms.Label()
        Me.TextBoxSanctionDuration = New System.Windows.Forms.TextBox()
        Me.LabelSanctionDuration = New System.Windows.Forms.Label()
        Me.TextBoxInfractionClass = New System.Windows.Forms.TextBox()
        Me.LabelInfractionClass = New System.Windows.Forms.Label()
        Me.LabelKMOur = New System.Windows.Forms.Label()
        Me.TextBoxMaxSnelheid = New System.Windows.Forms.TextBox()
        Me.LabelSpeedAllowed = New System.Windows.Forms.Label()
        Me.LabelKMHour = New System.Windows.Forms.Label()
        Me.TextBoxSnelheid = New System.Windows.Forms.TextBox()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.GroupBoxPreviousInfractions = New System.Windows.Forms.GroupBox()
        Me.UltraGridPreviousInfractions = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataOvertreding = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding()
        Me.UltraComboEditorLanguage = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolTipBBW = New System.Windows.Forms.ToolTip(Me.components)
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        CType(Me.UltraComboSanction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInfractions.SuspendLayout()
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDates.SuspendLayout()
        CType(Me.UltraDateTimeletterSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInfraction.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxPreviousInfractions.SuspendLayout()
        CType(Me.UltraGridPreviousInfractions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOvertreding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboEditorLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraComboSanction
        '
        Me.UltraComboSanction.DataMember = "BBINBRSanction"
        Me.UltraComboSanction.DataSource = Me._dataBewakingSnelheidSanction
        Me.UltraComboSanction.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn91.Header.VisiblePosition = 0
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 1
        UltraGridColumn92.Width = 299
        UltraGridColumn93.Header.VisiblePosition = 2
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 3
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 4
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 5
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 6
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 7
        UltraGridColumn98.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98})
        Me.UltraComboSanction.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboSanction.DisplayMember = "SanctionDescr"
        Me.UltraComboSanction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboSanction.Location = New System.Drawing.Point(69, 8)
        Me.UltraComboSanction.Name = "UltraComboSanction"
        Me.UltraComboSanction.Size = New System.Drawing.Size(301, 22)
        Me.UltraComboSanction.TabIndex = 49
        Me.UltraComboSanction.ValueMember = "SanctionID"
        '
        '_dataBewakingSnelheidSanction
        '
        Me._dataBewakingSnelheidSanction.DataSetName = "TDSBewakingSnelheidSanction"
        Me._dataBewakingSnelheidSanction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelSanction
        '
        Me.LabelSanction.AutoSize = True
        Me.LabelSanction.Location = New System.Drawing.Point(17, 13)
        Me.LabelSanction.Name = "LabelSanction"
        Me.LabelSanction.Size = New System.Drawing.Size(46, 13)
        Me.LabelSanction.TabIndex = 52
        Me.LabelSanction.Text = "Sanctie:"
        '
        'GroupBoxInfractions
        '
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr3)
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr2)
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr1)
        Me.GroupBoxInfractions.Location = New System.Drawing.Point(376, 33)
        Me.GroupBoxInfractions.Name = "GroupBoxInfractions"
        Me.GroupBoxInfractions.Size = New System.Drawing.Size(212, 102)
        Me.GroupBoxInfractions.TabIndex = 51
        Me.GroupBoxInfractions.TabStop = False
        Me.GroupBoxInfractions.Text = "Inbreuk"
        '
        'RadioButtonInbr3
        '
        Me.RadioButtonInbr3.AutoSize = True
        Me.RadioButtonInbr3.Location = New System.Drawing.Point(7, 71)
        Me.RadioButtonInbr3.Name = "RadioButtonInbr3"
        Me.RadioButtonInbr3.Size = New System.Drawing.Size(192, 17)
        Me.RadioButtonInbr3.TabIndex = 2
        Me.RadioButtonInbr3.Text = "3de inbreuk in 24 maanden of meer"
        Me.RadioButtonInbr3.UseVisualStyleBackColor = True
        '
        'RadioButtonInbr2
        '
        Me.RadioButtonInbr2.AutoSize = True
        Me.RadioButtonInbr2.Location = New System.Drawing.Point(7, 48)
        Me.RadioButtonInbr2.Name = "RadioButtonInbr2"
        Me.RadioButtonInbr2.Size = New System.Drawing.Size(154, 17)
        Me.RadioButtonInbr2.TabIndex = 1
        Me.RadioButtonInbr2.Text = "2de inbreuk in 24 maanden"
        Me.RadioButtonInbr2.UseVisualStyleBackColor = True
        '
        'RadioButtonInbr1
        '
        Me.RadioButtonInbr1.AutoSize = True
        Me.RadioButtonInbr1.Checked = True
        Me.RadioButtonInbr1.Location = New System.Drawing.Point(7, 25)
        Me.RadioButtonInbr1.Name = "RadioButtonInbr1"
        Me.RadioButtonInbr1.Size = New System.Drawing.Size(83, 17)
        Me.RadioButtonInbr1.TabIndex = 0
        Me.RadioButtonInbr1.TabStop = True
        Me.RadioButtonInbr1.Text = "1ste inbreuk"
        Me.RadioButtonInbr1.UseVisualStyleBackColor = True
        '
        'UltraDateAfspraakPBH
        '
        Me.UltraDateAfspraakPBH.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateAfspraakPBH.Enabled = False
        Me.UltraDateAfspraakPBH.Location = New System.Drawing.Point(260, 100)
        Me.UltraDateAfspraakPBH.Name = "UltraDateAfspraakPBH"
        Me.UltraDateAfspraakPBH.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateAfspraakPBH.TabIndex = 6
        Me.UltraDateAfspraakPBH.Value = Nothing
        Me.UltraDateAfspraakPBH.Visible = False
        '
        'LabelAfspraak
        '
        Me.LabelAfspraak.AutoSize = True
        Me.LabelAfspraak.Location = New System.Drawing.Point(95, 104)
        Me.LabelAfspraak.Name = "LabelAfspraak"
        Me.LabelAfspraak.Size = New System.Drawing.Size(111, 13)
        Me.LabelAfspraak.TabIndex = 9
        Me.LabelAfspraak.Text = "Datum brief verstuurd:"
        Me.LabelAfspraak.Visible = False
        '
        'GroupBoxDates
        '
        Me.GroupBoxDates.Controls.Add(Me.LabelDatumPrint)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateAfspraakPBH)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateTimeletterSend)
        Me.GroupBoxDates.Controls.Add(Me.LabelRijverbodTot)
        Me.GroupBoxDates.Controls.Add(Me.LabelAfspraak)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateRijverbodVan)
        Me.GroupBoxDates.Controls.Add(Me.LabelRijverbodVan)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateRijverbodTot)
        Me.GroupBoxDates.Location = New System.Drawing.Point(12, 33)
        Me.GroupBoxDates.Name = "GroupBoxDates"
        Me.GroupBoxDates.Size = New System.Drawing.Size(358, 127)
        Me.GroupBoxDates.TabIndex = 50
        Me.GroupBoxDates.TabStop = False
        Me.GroupBoxDates.Text = "Datums"
        '
        'LabelDatumPrint
        '
        Me.LabelDatumPrint.AutoSize = True
        Me.LabelDatumPrint.Location = New System.Drawing.Point(95, 77)
        Me.LabelDatumPrint.Name = "LabelDatumPrint"
        Me.LabelDatumPrint.Size = New System.Drawing.Size(92, 13)
        Me.LabelDatumPrint.TabIndex = 12
        Me.LabelDatumPrint.Text = "Datum afdrukken:"
        '
        'UltraDateTimeletterSend
        '
        Me.UltraDateTimeletterSend.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateTimeletterSend.Location = New System.Drawing.Point(260, 73)
        Me.UltraDateTimeletterSend.Name = "UltraDateTimeletterSend"
        Me.UltraDateTimeletterSend.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateTimeletterSend.TabIndex = 13
        Me.UltraDateTimeletterSend.Value = Nothing
        '
        'LabelRijverbodTot
        '
        Me.LabelRijverbodTot.AutoSize = True
        Me.LabelRijverbodTot.Enabled = False
        Me.LabelRijverbodTot.Location = New System.Drawing.Point(95, 50)
        Me.LabelRijverbodTot.Name = "LabelRijverbodTot"
        Me.LabelRijverbodTot.Size = New System.Drawing.Size(101, 13)
        Me.LabelRijverbodTot.TabIndex = 11
        Me.LabelRijverbodTot.Text = "Rijverbod geldig tot:"
        '
        'UltraDateRijverbodVan
        '
        Me.UltraDateRijverbodVan.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateRijverbodVan.Enabled = False
        Me.UltraDateRijverbodVan.Location = New System.Drawing.Point(260, 19)
        Me.UltraDateRijverbodVan.Name = "UltraDateRijverbodVan"
        Me.UltraDateRijverbodVan.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodVan.TabIndex = 7
        Me.UltraDateRijverbodVan.Value = Nothing
        '
        'LabelRijverbodVan
        '
        Me.LabelRijverbodVan.AutoSize = True
        Me.LabelRijverbodVan.Enabled = False
        Me.LabelRijverbodVan.Location = New System.Drawing.Point(95, 23)
        Me.LabelRijverbodVan.Name = "LabelRijverbodVan"
        Me.LabelRijverbodVan.Size = New System.Drawing.Size(116, 13)
        Me.LabelRijverbodVan.TabIndex = 10
        Me.LabelRijverbodVan.Text = "Rijverbod geldig vanaf:"
        '
        'UltraDateRijverbodTot
        '
        Me.UltraDateRijverbodTot.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateRijverbodTot.Enabled = False
        Me.UltraDateRijverbodTot.Location = New System.Drawing.Point(260, 46)
        Me.UltraDateRijverbodTot.Name = "UltraDateRijverbodTot"
        Me.UltraDateRijverbodTot.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodTot.TabIndex = 8
        Me.UltraDateRijverbodTot.Value = Nothing
        '
        'LabelLanguage
        '
        Me.LabelLanguage.AutoSize = True
        Me.LabelLanguage.Location = New System.Drawing.Point(376, 13)
        Me.LabelLanguage.Name = "LabelLanguage"
        Me.LabelLanguage.Size = New System.Drawing.Size(31, 13)
        Me.LabelLanguage.TabIndex = 53
        Me.LabelLanguage.Text = "Taal:"
        '
        'GroupBoxInfraction
        '
        Me.GroupBoxInfraction.Controls.Add(Me.ButtonReport)
        Me.GroupBoxInfraction.Controls.Add(Me.ButtonZoekFirma)
        Me.GroupBoxInfraction.Controls.Add(Me.Label1)
        Me.GroupBoxInfraction.Controls.Add(Me.LabelAddressFirm)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxCityFirm)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxAddressFirm)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxNameFirm)
        Me.GroupBoxInfraction.Controls.Add(Me.LabelNameFirm)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxVoertuig)
        Me.GroupBoxInfraction.Controls.Add(Me.LabelTypeCar)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxNrPlate)
        Me.GroupBoxInfraction.Controls.Add(Me.LabelLicensePlate)
        Me.GroupBoxInfraction.Controls.Add(Me.TextBoxDriverName)
        Me.GroupBoxInfraction.Controls.Add(Me.LabelNameDriver)
        Me.GroupBoxInfraction.Location = New System.Drawing.Point(12, 141)
        Me.GroupBoxInfraction.Name = "GroupBoxInfraction"
        Me.GroupBoxInfraction.Size = New System.Drawing.Size(576, 152)
        Me.GroupBoxInfraction.TabIndex = 55
        Me.GroupBoxInfraction.TabStop = False
        Me.GroupBoxInfraction.Text = "Informatie overtreder"
        '
        'ButtonReport
        '
        Me.ButtonReport.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.FACTORY
        Me.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReport.Location = New System.Drawing.Point(401, 121)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(162, 23)
        Me.ButtonReport.TabIndex = 61
        Me.ButtonReport.Text = "Ophalen uit verslag"
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'ButtonZoekFirma
        '
        Me.ButtonZoekFirma.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.find
        Me.ButtonZoekFirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonZoekFirma.Location = New System.Drawing.Point(401, 71)
        Me.ButtonZoekFirma.Name = "ButtonZoekFirma"
        Me.ButtonZoekFirma.Size = New System.Drawing.Size(64, 23)
        Me.ButtonZoekFirma.TabIndex = 60
        Me.ButtonZoekFirma.Text = "Zoek"
        Me.ButtonZoekFirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonZoekFirma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Gemeente firma:"
        '
        'LabelAddressFirm
        '
        Me.LabelAddressFirm.AutoSize = True
        Me.LabelAddressFirm.Location = New System.Drawing.Point(35, 100)
        Me.LabelAddressFirm.Name = "LabelAddressFirm"
        Me.LabelAddressFirm.Size = New System.Drawing.Size(62, 13)
        Me.LabelAddressFirm.TabIndex = 43
        Me.LabelAddressFirm.Text = "Adres firma:"
        '
        'TextBoxCityFirm
        '
        Me.TextBoxCityFirm.Location = New System.Drawing.Point(109, 123)
        Me.TextBoxCityFirm.Name = "TextBoxCityFirm"
        Me.TextBoxCityFirm.ReadOnly = True
        Me.TextBoxCityFirm.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxCityFirm.TabIndex = 42
        Me.TextBoxCityFirm.TabStop = False
        '
        'TextBoxAddressFirm
        '
        Me.TextBoxAddressFirm.Location = New System.Drawing.Point(109, 97)
        Me.TextBoxAddressFirm.Name = "TextBoxAddressFirm"
        Me.TextBoxAddressFirm.ReadOnly = True
        Me.TextBoxAddressFirm.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxAddressFirm.TabIndex = 41
        Me.TextBoxAddressFirm.TabStop = False
        '
        'TextBoxNameFirm
        '
        Me.TextBoxNameFirm.Location = New System.Drawing.Point(109, 71)
        Me.TextBoxNameFirm.Name = "TextBoxNameFirm"
        Me.TextBoxNameFirm.ReadOnly = True
        Me.TextBoxNameFirm.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxNameFirm.TabIndex = 40
        Me.TextBoxNameFirm.TabStop = False
        '
        'LabelNameFirm
        '
        Me.LabelNameFirm.AutoSize = True
        Me.LabelNameFirm.Location = New System.Drawing.Point(34, 74)
        Me.LabelNameFirm.Name = "LabelNameFirm"
        Me.LabelNameFirm.Size = New System.Drawing.Size(63, 13)
        Me.LabelNameFirm.TabIndex = 39
        Me.LabelNameFirm.Text = "Naam firma:"
        '
        'TextBoxVoertuig
        '
        Me.TextBoxVoertuig.Location = New System.Drawing.Point(370, 45)
        Me.TextBoxVoertuig.Name = "TextBoxVoertuig"
        Me.TextBoxVoertuig.ReadOnly = True
        Me.TextBoxVoertuig.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxVoertuig.TabIndex = 38
        Me.TextBoxVoertuig.TabStop = False
        '
        'LabelTypeCar
        '
        Me.LabelTypeCar.AutoSize = True
        Me.LabelTypeCar.Location = New System.Drawing.Point(283, 48)
        Me.LabelTypeCar.Name = "LabelTypeCar"
        Me.LabelTypeCar.Size = New System.Drawing.Size(75, 13)
        Me.LabelTypeCar.TabIndex = 37
        Me.LabelTypeCar.Text = "Type voertuig:"
        '
        'TextBoxNrPlate
        '
        Me.TextBoxNrPlate.Location = New System.Drawing.Point(109, 45)
        Me.TextBoxNrPlate.Name = "TextBoxNrPlate"
        Me.TextBoxNrPlate.ReadOnly = True
        Me.TextBoxNrPlate.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxNrPlate.TabIndex = 36
        Me.TextBoxNrPlate.TabStop = False
        '
        'LabelLicensePlate
        '
        Me.LabelLicensePlate.AutoSize = True
        Me.LabelLicensePlate.Location = New System.Drawing.Point(25, 48)
        Me.LabelLicensePlate.Name = "LabelLicensePlate"
        Me.LabelLicensePlate.Size = New System.Drawing.Size(72, 13)
        Me.LabelLicensePlate.TabIndex = 35
        Me.LabelLicensePlate.Text = "Nummerplaat:"
        '
        'TextBoxDriverName
        '
        Me.TextBoxDriverName.Location = New System.Drawing.Point(109, 19)
        Me.TextBoxDriverName.Name = "TextBoxDriverName"
        Me.TextBoxDriverName.ReadOnly = True
        Me.TextBoxDriverName.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxDriverName.TabIndex = 34
        Me.TextBoxDriverName.TabStop = False
        '
        'LabelNameDriver
        '
        Me.LabelNameDriver.AutoSize = True
        Me.LabelNameDriver.Location = New System.Drawing.Point(11, 22)
        Me.LabelNameDriver.Name = "LabelNameDriver"
        Me.LabelNameDriver.Size = New System.Drawing.Size(86, 13)
        Me.LabelNameDriver.TabIndex = 33
        Me.LabelNameDriver.Text = "Naam chauffeur:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxDoubleUp)
        Me.GroupBox1.Controls.Add(Me.TextBoxSanctionPeriod)
        Me.GroupBox1.Controls.Add(Me.LabelSanctionPeriod)
        Me.GroupBox1.Controls.Add(Me.TextBoxSanctionDuration)
        Me.GroupBox1.Controls.Add(Me.LabelSanctionDuration)
        Me.GroupBox1.Controls.Add(Me.TextBoxInfractionClass)
        Me.GroupBox1.Controls.Add(Me.LabelInfractionClass)
        Me.GroupBox1.Controls.Add(Me.LabelKMOur)
        Me.GroupBox1.Controls.Add(Me.TextBoxMaxSnelheid)
        Me.GroupBox1.Controls.Add(Me.LabelSpeedAllowed)
        Me.GroupBox1.Controls.Add(Me.LabelKMHour)
        Me.GroupBox1.Controls.Add(Me.TextBoxSnelheid)
        Me.GroupBox1.Controls.Add(Me.LabelSpeed)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 123)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informatie overtreding"
        '
        'CheckBoxDoubleUp
        '
        Me.CheckBoxDoubleUp.AutoSize = True
        Me.CheckBoxDoubleUp.Enabled = False
        Me.CheckBoxDoubleUp.Location = New System.Drawing.Point(93, 97)
        Me.CheckBoxDoubleUp.Name = "CheckBoxDoubleUp"
        Me.CheckBoxDoubleUp.Size = New System.Drawing.Size(159, 17)
        Me.CheckBoxDoubleUp.TabIndex = 69
        Me.CheckBoxDoubleUp.Text = "Verdubbeling laatste sanctie"
        Me.CheckBoxDoubleUp.UseVisualStyleBackColor = True
        '
        'TextBoxSanctionPeriod
        '
        Me.TextBoxSanctionPeriod.Location = New System.Drawing.Point(253, 71)
        Me.TextBoxSanctionPeriod.Name = "TextBoxSanctionPeriod"
        Me.TextBoxSanctionPeriod.ReadOnly = True
        Me.TextBoxSanctionPeriod.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSanctionPeriod.TabIndex = 68
        Me.TextBoxSanctionPeriod.TabStop = False
        '
        'LabelSanctionPeriod
        '
        Me.LabelSanctionPeriod.AutoSize = True
        Me.LabelSanctionPeriod.Location = New System.Drawing.Point(180, 74)
        Me.LabelSanctionPeriod.Name = "LabelSanctionPeriod"
        Me.LabelSanctionPeriod.Size = New System.Drawing.Size(67, 13)
        Me.LabelSanctionPeriod.TabIndex = 67
        Me.LabelSanctionPeriod.Text = "Sanctieduur:"
        '
        'TextBoxSanctionDuration
        '
        Me.TextBoxSanctionDuration.Location = New System.Drawing.Point(93, 71)
        Me.TextBoxSanctionDuration.Name = "TextBoxSanctionDuration"
        Me.TextBoxSanctionDuration.ReadOnly = True
        Me.TextBoxSanctionDuration.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSanctionDuration.TabIndex = 66
        Me.TextBoxSanctionDuration.TabStop = False
        '
        'LabelSanctionDuration
        '
        Me.LabelSanctionDuration.AutoSize = True
        Me.LabelSanctionDuration.Location = New System.Drawing.Point(14, 74)
        Me.LabelSanctionDuration.Name = "LabelSanctionDuration"
        Me.LabelSanctionDuration.Size = New System.Drawing.Size(67, 13)
        Me.LabelSanctionDuration.TabIndex = 65
        Me.LabelSanctionDuration.Text = "Sanctieduur:"
        '
        'TextBoxInfractionClass
        '
        Me.TextBoxInfractionClass.Location = New System.Drawing.Point(354, 19)
        Me.TextBoxInfractionClass.Name = "TextBoxInfractionClass"
        Me.TextBoxInfractionClass.ReadOnly = True
        Me.TextBoxInfractionClass.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxInfractionClass.TabIndex = 64
        Me.TextBoxInfractionClass.TabStop = False
        '
        'LabelInfractionClass
        '
        Me.LabelInfractionClass.AutoSize = True
        Me.LabelInfractionClass.Location = New System.Drawing.Point(266, 22)
        Me.LabelInfractionClass.Name = "LabelInfractionClass"
        Me.LabelInfractionClass.Size = New System.Drawing.Size(76, 13)
        Me.LabelInfractionClass.TabIndex = 63
        Me.LabelInfractionClass.Text = "Inbreukklasse:"
        '
        'LabelKMOur
        '
        Me.LabelKMOur.AutoSize = True
        Me.LabelKMOur.Location = New System.Drawing.Point(171, 48)
        Me.LabelKMOur.Name = "LabelKMOur"
        Me.LabelKMOur.Size = New System.Drawing.Size(32, 13)
        Me.LabelKMOur.TabIndex = 62
        Me.LabelKMOur.Text = "km/h"
        '
        'TextBoxMaxSnelheid
        '
        Me.TextBoxMaxSnelheid.Location = New System.Drawing.Point(93, 45)
        Me.TextBoxMaxSnelheid.Name = "TextBoxMaxSnelheid"
        Me.TextBoxMaxSnelheid.ReadOnly = True
        Me.TextBoxMaxSnelheid.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxMaxSnelheid.TabIndex = 61
        Me.TextBoxMaxSnelheid.TabStop = False
        '
        'LabelSpeedAllowed
        '
        Me.LabelSpeedAllowed.AutoSize = True
        Me.LabelSpeedAllowed.Location = New System.Drawing.Point(17, 48)
        Me.LabelSpeedAllowed.Name = "LabelSpeedAllowed"
        Me.LabelSpeedAllowed.Size = New System.Drawing.Size(64, 13)
        Me.LabelSpeedAllowed.TabIndex = 60
        Me.LabelSpeedAllowed.Text = "Toegelaten:"
        '
        'LabelKMHour
        '
        Me.LabelKMHour.AutoSize = True
        Me.LabelKMHour.Location = New System.Drawing.Point(172, 22)
        Me.LabelKMHour.Name = "LabelKMHour"
        Me.LabelKMHour.Size = New System.Drawing.Size(32, 13)
        Me.LabelKMHour.TabIndex = 59
        Me.LabelKMHour.Text = "km/h"
        '
        'TextBoxSnelheid
        '
        Me.TextBoxSnelheid.Location = New System.Drawing.Point(93, 19)
        Me.TextBoxSnelheid.Name = "TextBoxSnelheid"
        Me.TextBoxSnelheid.ReadOnly = True
        Me.TextBoxSnelheid.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSnelheid.TabIndex = 58
        Me.TextBoxSnelheid.TabStop = False
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Location = New System.Drawing.Point(30, 22)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(51, 13)
        Me.LabelSpeed.TabIndex = 57
        Me.LabelSpeed.Text = "Snelheid:"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(422, 428)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(80, 25)
        Me.ButtonCancel.TabIndex = 57
        Me.ButtonCancel.Text = "Annuleren"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
        Me.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOK.Location = New System.Drawing.Point(508, 428)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(80, 25)
        Me.ButtonOK.TabIndex = 58
        Me.ButtonOK.Text = "OK + mail"
        Me.ButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTipBBW.SetToolTip(Me.ButtonOK, "Print verslag (tonen als pdf) + automatische mail naar firma")
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'GroupBoxPreviousInfractions
        '
        Me.GroupBoxPreviousInfractions.Controls.Add(Me.UltraGridPreviousInfractions)
        Me.GroupBoxPreviousInfractions.Location = New System.Drawing.Point(12, 459)
        Me.GroupBoxPreviousInfractions.Name = "GroupBoxPreviousInfractions"
        Me.GroupBoxPreviousInfractions.Size = New System.Drawing.Size(576, 176)
        Me.GroupBoxPreviousInfractions.TabIndex = 59
        Me.GroupBoxPreviousInfractions.TabStop = False
        Me.GroupBoxPreviousInfractions.Text = "Vastgestelde inbreuken (laatste 24 maanden en  later dan 15 maart 2013)"
        '
        'UltraGridPreviousInfractions
        '
        Me.UltraGridPreviousInfractions.DataMember = "Lijst_Overtredingen"
        Me.UltraGridPreviousInfractions.DataSource = Me._dataOvertreding
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn99.Header.VisiblePosition = 0
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn100.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn100.Header.VisiblePosition = 2
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn101.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn101.Header.VisiblePosition = 3
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn102.Header.VisiblePosition = 1
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn103.Header.VisiblePosition = 29
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn104.Header.VisiblePosition = 6
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn105.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn105.Header.VisiblePosition = 33
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn106.Header.VisiblePosition = 34
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn107.Header.VisiblePosition = 7
        UltraGridColumn108.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn108.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn108.Header.Caption = "Toegelaten"
        UltraGridColumn108.Header.VisiblePosition = 8
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn109.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn109.Header.Caption = "Geregistreerd"
        UltraGridColumn109.Header.VisiblePosition = 9
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn110.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn110.Header.VisiblePosition = 10
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn111.Header.VisiblePosition = 11
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn112.Header.VisiblePosition = 12
        UltraGridColumn113.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn113.Header.VisiblePosition = 4
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn114.Header.VisiblePosition = 13
        UltraGridColumn115.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn115.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn115.Header.VisiblePosition = 14
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn116.Header.VisiblePosition = 15
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn117.Header.VisiblePosition = 16
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn118.Header.VisiblePosition = 17
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn119.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn119.Header.VisiblePosition = 18
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn120.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn120.Header.VisiblePosition = 19
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn121.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn121.Header.VisiblePosition = 20
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn122.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn122.Header.VisiblePosition = 21
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn123.Header.VisiblePosition = 22
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn124.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn124.Header.VisiblePosition = 23
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn125.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn125.Header.VisiblePosition = 24
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn126.Header.VisiblePosition = 25
        UltraGridColumn127.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn127.Header.VisiblePosition = 26
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn128.Header.VisiblePosition = 27
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.VisiblePosition = 5
        UltraGridColumn130.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn130.Header.VisiblePosition = 28
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn131.Header.Caption = "Dubbel?"
        UltraGridColumn131.Header.VisiblePosition = 30
        UltraGridColumn132.Header.VisiblePosition = 31
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 32
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 35
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 36
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135})
        Me.UltraGridPreviousInfractions.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridPreviousInfractions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPreviousInfractions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridPreviousInfractions.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridPreviousInfractions.Name = "UltraGridPreviousInfractions"
        Me.UltraGridPreviousInfractions.Size = New System.Drawing.Size(570, 157)
        Me.UltraGridPreviousInfractions.TabIndex = 0
        '
        '_dataOvertreding
        '
        Me._dataOvertreding.DataSetName = "TDSOvertreding"
        Me._dataOvertreding.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraComboEditorLanguage
        '
        Me.UltraComboEditorLanguage.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "NL"
        ValueListItem1.DisplayText = "Nederlands"
        ValueListItem2.DataValue = "EN"
        ValueListItem2.DisplayText = "Engels"
        ValueListItem3.DataValue = "FR"
        ValueListItem3.DisplayText = "Frans"
        ValueListItem4.DataValue = "DE"
        ValueListItem4.DisplayText = "Duits"
        Me.UltraComboEditorLanguage.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4})
        Me.UltraComboEditorLanguage.Location = New System.Drawing.Point(422, 9)
        Me.UltraComboEditorLanguage.Name = "UltraComboEditorLanguage"
        Me.UltraComboEditorLanguage.Size = New System.Drawing.Size(166, 21)
        Me.UltraComboEditorLanguage.TabIndex = 60
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormPrintTrafficInfractionsExtern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 642)
        Me.Controls.Add(Me.UltraComboEditorLanguage)
        Me.Controls.Add(Me.GroupBoxPreviousInfractions)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxInfraction)
        Me.Controls.Add(Me.LabelLanguage)
        Me.Controls.Add(Me.UltraComboSanction)
        Me.Controls.Add(Me.LabelSanction)
        Me.Controls.Add(Me.GroupBoxInfractions)
        Me.Controls.Add(Me.GroupBoxDates)
        Me.Name = "FormPrintTrafficInfractionsExtern"
        Me.Text = "Afdrukken overtredingen Externen (PEB)"
        CType(Me.UltraComboSanction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInfractions.ResumeLayout(False)
        Me.GroupBoxInfractions.PerformLayout()
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDates.ResumeLayout(False)
        Me.GroupBoxDates.PerformLayout()
        CType(Me.UltraDateTimeletterSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInfraction.ResumeLayout(False)
        Me.GroupBoxInfraction.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxPreviousInfractions.ResumeLayout(False)
        CType(Me.UltraGridPreviousInfractions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataOvertreding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboEditorLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraComboSanction As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LabelSanction As System.Windows.Forms.Label
    Friend WithEvents GroupBoxInfractions As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInbr3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInbr2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInbr1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxDates As System.Windows.Forms.GroupBox
    Friend WithEvents UltraDateAfspraakPBH As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelRijverbodTot As System.Windows.Forms.Label
    Friend WithEvents UltraDateRijverbodVan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelRijverbodVan As System.Windows.Forms.Label
    Friend WithEvents UltraDateRijverbodTot As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelAfspraak As System.Windows.Forms.Label
    Friend WithEvents LabelLanguage As System.Windows.Forms.Label
    Friend WithEvents GroupBoxInfraction As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelAddressFirm As System.Windows.Forms.Label
    Friend WithEvents TextBoxCityFirm As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAddressFirm As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNameFirm As System.Windows.Forms.TextBox
    Friend WithEvents LabelNameFirm As System.Windows.Forms.Label
    Friend WithEvents TextBoxVoertuig As System.Windows.Forms.TextBox
    Friend WithEvents LabelTypeCar As System.Windows.Forms.Label
    Friend WithEvents TextBoxNrPlate As System.Windows.Forms.TextBox
    Friend WithEvents LabelLicensePlate As System.Windows.Forms.Label
    Friend WithEvents TextBoxDriverName As System.Windows.Forms.TextBox
    Friend WithEvents LabelNameDriver As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxSanctionPeriod As System.Windows.Forms.TextBox
    Friend WithEvents LabelSanctionPeriod As System.Windows.Forms.Label
    Friend WithEvents TextBoxSanctionDuration As System.Windows.Forms.TextBox
    Friend WithEvents LabelSanctionDuration As System.Windows.Forms.Label
    Friend WithEvents TextBoxInfractionClass As System.Windows.Forms.TextBox
    Friend WithEvents LabelInfractionClass As System.Windows.Forms.Label
    Friend WithEvents LabelKMOur As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaxSnelheid As System.Windows.Forms.TextBox
    Friend WithEvents LabelSpeedAllowed As System.Windows.Forms.Label
    Friend WithEvents LabelKMHour As System.Windows.Forms.Label
    Friend WithEvents TextBoxSnelheid As System.Windows.Forms.TextBox
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDoubleUp As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents GroupBoxPreviousInfractions As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridPreviousInfractions As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataOvertreding As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding
    Friend WithEvents _dataBewakingSnelheidSanction As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction
    Friend WithEvents ButtonZoekFirma As System.Windows.Forms.Button
    Friend WithEvents UltraComboEditorLanguage As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraDateTimeletterSend As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelDatumPrint As System.Windows.Forms.Label
    Friend WithEvents ButtonReport As System.Windows.Forms.Button
    Friend WithEvents ToolTipBBW As System.Windows.Forms.ToolTip
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
End Class
