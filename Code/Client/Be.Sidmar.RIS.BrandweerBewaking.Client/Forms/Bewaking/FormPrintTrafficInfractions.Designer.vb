<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintTrafficInfractions
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Overtredingen", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_dir")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_afd")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_sect")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieDuur")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctiePeriode")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inbreukklasse")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20+")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FirmaId")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionId")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inbreukKlasseId")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remarks")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanction", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDescr")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionNL")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionFR")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionEN")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDE")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintTrafficInfractions))
        Me.TextBoxVoertuig = New System.Windows.Forms.TextBox()
        Me.LabelTypeCar = New System.Windows.Forms.Label()
        Me.LabelKMOur = New System.Windows.Forms.Label()
        Me.TextBoxMaxSnelheid = New System.Windows.Forms.TextBox()
        Me.LabelSpeedAllowed = New System.Windows.Forms.Label()
        Me.LabelKMHour = New System.Windows.Forms.Label()
        Me.TextBoxSnelheid = New System.Windows.Forms.TextBox()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.TextBoxNrPlate = New System.Windows.Forms.TextBox()
        Me.LabelLicensePlate = New System.Windows.Forms.Label()
        Me.TextBoxDriverName = New System.Windows.Forms.TextBox()
        Me.LabelNameDriver = New System.Windows.Forms.Label()
        Me.GroupBoxInfractions = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInbr3 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbr2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbr1 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDates = New System.Windows.Forms.GroupBox()
        Me.LabelPrintenBrief = New System.Windows.Forms.Label()
        Me.UltraDateTimeAfdrukken = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateAfspraakPBH = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelRijverbodTot = New System.Windows.Forms.Label()
        Me.UltraDateRijverbodVan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelRijverbodVan = New System.Windows.Forms.Label()
        Me.UltraDateRijverbodTot = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelAfspraak = New System.Windows.Forms.Label()
        Me.LabelSanction = New System.Windows.Forms.Label()
        Me.CheckBoxDoubleUp = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPreviousInfractions = New System.Windows.Forms.GroupBox()
        Me.UltraGridPreviousInfractions = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataOvertreding = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding()
        Me.LabelInfractionClass = New System.Windows.Forms.Label()
        Me.TextBoxInfractionClass = New System.Windows.Forms.TextBox()
        Me.TextBoxSanctionDuration = New System.Windows.Forms.TextBox()
        Me.LabelSanctionDuration = New System.Windows.Forms.Label()
        Me.TextBoxSanctionPeriod = New System.Windows.Forms.TextBox()
        Me.LabelSanctionPeriod = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmailChef = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.UltraComboSanction = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataBewakingSnelheidSanction = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.ucSAPPresence = New Be.Sidmar.RIS.BrandweerBewaking.Client.UserControlSAPPresence()
        Me.GroupBoxInfractions.SuspendLayout()
        Me.GroupBoxDates.SuspendLayout()
        CType(Me.UltraDateTimeAfdrukken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPreviousInfractions.SuspendLayout()
        CType(Me.UltraGridPreviousInfractions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOvertreding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboSanction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxVoertuig
        '
        Me.TextBoxVoertuig.Location = New System.Drawing.Point(376, 197)
        Me.TextBoxVoertuig.Name = "TextBoxVoertuig"
        Me.TextBoxVoertuig.ReadOnly = True
        Me.TextBoxVoertuig.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxVoertuig.TabIndex = 32
        Me.TextBoxVoertuig.TabStop = False
        '
        'LabelTypeCar
        '
        Me.LabelTypeCar.AutoSize = True
        Me.LabelTypeCar.Location = New System.Drawing.Point(289, 200)
        Me.LabelTypeCar.Name = "LabelTypeCar"
        Me.LabelTypeCar.Size = New System.Drawing.Size(75, 13)
        Me.LabelTypeCar.TabIndex = 31
        Me.LabelTypeCar.Text = "Type voertuig:"
        '
        'LabelKMOur
        '
        Me.LabelKMOur.AutoSize = True
        Me.LabelKMOur.Location = New System.Drawing.Point(193, 252)
        Me.LabelKMOur.Name = "LabelKMOur"
        Me.LabelKMOur.Size = New System.Drawing.Size(32, 13)
        Me.LabelKMOur.TabIndex = 38
        Me.LabelKMOur.Text = "km/h"
        '
        'TextBoxMaxSnelheid
        '
        Me.TextBoxMaxSnelheid.Location = New System.Drawing.Point(115, 249)
        Me.TextBoxMaxSnelheid.Name = "TextBoxMaxSnelheid"
        Me.TextBoxMaxSnelheid.ReadOnly = True
        Me.TextBoxMaxSnelheid.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxMaxSnelheid.TabIndex = 37
        Me.TextBoxMaxSnelheid.TabStop = False
        '
        'LabelSpeedAllowed
        '
        Me.LabelSpeedAllowed.AutoSize = True
        Me.LabelSpeedAllowed.Location = New System.Drawing.Point(39, 252)
        Me.LabelSpeedAllowed.Name = "LabelSpeedAllowed"
        Me.LabelSpeedAllowed.Size = New System.Drawing.Size(64, 13)
        Me.LabelSpeedAllowed.TabIndex = 36
        Me.LabelSpeedAllowed.Text = "Toegelaten:"
        '
        'LabelKMHour
        '
        Me.LabelKMHour.AutoSize = True
        Me.LabelKMHour.Location = New System.Drawing.Point(194, 226)
        Me.LabelKMHour.Name = "LabelKMHour"
        Me.LabelKMHour.Size = New System.Drawing.Size(32, 13)
        Me.LabelKMHour.TabIndex = 35
        Me.LabelKMHour.Text = "km/h"
        '
        'TextBoxSnelheid
        '
        Me.TextBoxSnelheid.Location = New System.Drawing.Point(115, 223)
        Me.TextBoxSnelheid.Name = "TextBoxSnelheid"
        Me.TextBoxSnelheid.ReadOnly = True
        Me.TextBoxSnelheid.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSnelheid.TabIndex = 34
        Me.TextBoxSnelheid.TabStop = False
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Location = New System.Drawing.Point(52, 226)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(51, 13)
        Me.LabelSpeed.TabIndex = 33
        Me.LabelSpeed.Text = "Snelheid:"
        '
        'TextBoxNrPlate
        '
        Me.TextBoxNrPlate.Location = New System.Drawing.Point(115, 197)
        Me.TextBoxNrPlate.Name = "TextBoxNrPlate"
        Me.TextBoxNrPlate.ReadOnly = True
        Me.TextBoxNrPlate.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxNrPlate.TabIndex = 30
        Me.TextBoxNrPlate.TabStop = False
        '
        'LabelLicensePlate
        '
        Me.LabelLicensePlate.AutoSize = True
        Me.LabelLicensePlate.Location = New System.Drawing.Point(31, 200)
        Me.LabelLicensePlate.Name = "LabelLicensePlate"
        Me.LabelLicensePlate.Size = New System.Drawing.Size(72, 13)
        Me.LabelLicensePlate.TabIndex = 29
        Me.LabelLicensePlate.Text = "Nummerplaat:"
        '
        'TextBoxDriverName
        '
        Me.TextBoxDriverName.Location = New System.Drawing.Point(115, 171)
        Me.TextBoxDriverName.Name = "TextBoxDriverName"
        Me.TextBoxDriverName.ReadOnly = True
        Me.TextBoxDriverName.Size = New System.Drawing.Size(286, 20)
        Me.TextBoxDriverName.TabIndex = 28
        Me.TextBoxDriverName.TabStop = False
        '
        'LabelNameDriver
        '
        Me.LabelNameDriver.AutoSize = True
        Me.LabelNameDriver.Location = New System.Drawing.Point(17, 174)
        Me.LabelNameDriver.Name = "LabelNameDriver"
        Me.LabelNameDriver.Size = New System.Drawing.Size(86, 13)
        Me.LabelNameDriver.TabIndex = 27
        Me.LabelNameDriver.Text = "Naam chauffeur:"
        '
        'GroupBoxInfractions
        '
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr3)
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr2)
        Me.GroupBoxInfractions.Controls.Add(Me.RadioButtonInbr1)
        Me.GroupBoxInfractions.Location = New System.Drawing.Point(376, 37)
        Me.GroupBoxInfractions.Name = "GroupBoxInfractions"
        Me.GroupBoxInfractions.Size = New System.Drawing.Size(212, 99)
        Me.GroupBoxInfractions.TabIndex = 26
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
        'GroupBoxDates
        '
        Me.GroupBoxDates.Controls.Add(Me.LabelPrintenBrief)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateTimeAfdrukken)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateAfspraakPBH)
        Me.GroupBoxDates.Controls.Add(Me.LabelRijverbodTot)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateRijverbodVan)
        Me.GroupBoxDates.Controls.Add(Me.LabelRijverbodVan)
        Me.GroupBoxDates.Controls.Add(Me.UltraDateRijverbodTot)
        Me.GroupBoxDates.Controls.Add(Me.LabelAfspraak)
        Me.GroupBoxDates.Location = New System.Drawing.Point(12, 37)
        Me.GroupBoxDates.Name = "GroupBoxDates"
        Me.GroupBoxDates.Size = New System.Drawing.Size(358, 128)
        Me.GroupBoxDates.TabIndex = 25
        Me.GroupBoxDates.TabStop = False
        Me.GroupBoxDates.Text = "Datums"
        '
        'LabelPrintenBrief
        '
        Me.LabelPrintenBrief.AutoSize = True
        Me.LabelPrintenBrief.Location = New System.Drawing.Point(95, 103)
        Me.LabelPrintenBrief.Name = "LabelPrintenBrief"
        Me.LabelPrintenBrief.Size = New System.Drawing.Size(82, 13)
        Me.LabelPrintenBrief.TabIndex = 13
        Me.LabelPrintenBrief.Text = "Afdrukken brief:"
        '
        'UltraDateTimeAfdrukken
        '
        Me.UltraDateTimeAfdrukken.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateTimeAfdrukken.Location = New System.Drawing.Point(260, 99)
        Me.UltraDateTimeAfdrukken.Name = "UltraDateTimeAfdrukken"
        Me.UltraDateTimeAfdrukken.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateTimeAfdrukken.TabIndex = 12
        Me.UltraDateTimeAfdrukken.Value = Nothing
        '
        'UltraDateAfspraakPBH
        '
        Me.UltraDateAfspraakPBH.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateAfspraakPBH.Enabled = False
        Me.UltraDateAfspraakPBH.Location = New System.Drawing.Point(260, 19)
        Me.UltraDateAfspraakPBH.Name = "UltraDateAfspraakPBH"
        Me.UltraDateAfspraakPBH.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateAfspraakPBH.TabIndex = 6
        Me.UltraDateAfspraakPBH.Value = Nothing
        '
        'LabelRijverbodTot
        '
        Me.LabelRijverbodTot.AutoSize = True
        Me.LabelRijverbodTot.Enabled = False
        Me.LabelRijverbodTot.Location = New System.Drawing.Point(95, 76)
        Me.LabelRijverbodTot.Name = "LabelRijverbodTot"
        Me.LabelRijverbodTot.Size = New System.Drawing.Size(101, 13)
        Me.LabelRijverbodTot.TabIndex = 11
        Me.LabelRijverbodTot.Text = "Rijverbod geldig tot:"
        '
        'UltraDateRijverbodVan
        '
        Me.UltraDateRijverbodVan.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateRijverbodVan.Enabled = False
        Me.UltraDateRijverbodVan.Location = New System.Drawing.Point(260, 45)
        Me.UltraDateRijverbodVan.Name = "UltraDateRijverbodVan"
        Me.UltraDateRijverbodVan.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodVan.TabIndex = 7
        Me.UltraDateRijverbodVan.Value = Nothing
        '
        'LabelRijverbodVan
        '
        Me.LabelRijverbodVan.AutoSize = True
        Me.LabelRijverbodVan.Enabled = False
        Me.LabelRijverbodVan.Location = New System.Drawing.Point(95, 49)
        Me.LabelRijverbodVan.Name = "LabelRijverbodVan"
        Me.LabelRijverbodVan.Size = New System.Drawing.Size(116, 13)
        Me.LabelRijverbodVan.TabIndex = 10
        Me.LabelRijverbodVan.Text = "Rijverbod geldig vanaf:"
        '
        'UltraDateRijverbodTot
        '
        Me.UltraDateRijverbodTot.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UltraDateRijverbodTot.Enabled = False
        Me.UltraDateRijverbodTot.Location = New System.Drawing.Point(260, 72)
        Me.UltraDateRijverbodTot.Name = "UltraDateRijverbodTot"
        Me.UltraDateRijverbodTot.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodTot.TabIndex = 8
        Me.UltraDateRijverbodTot.Value = Nothing
        '
        'LabelAfspraak
        '
        Me.LabelAfspraak.AutoSize = True
        Me.LabelAfspraak.Enabled = False
        Me.LabelAfspraak.Location = New System.Drawing.Point(95, 23)
        Me.LabelAfspraak.Name = "LabelAfspraak"
        Me.LabelAfspraak.Size = New System.Drawing.Size(160, 13)
        Me.LabelAfspraak.TabIndex = 9
        Me.LabelAfspraak.Text = "Afspraak met Personeelsbeheer:"
        '
        'LabelSanction
        '
        Me.LabelSanction.AutoSize = True
        Me.LabelSanction.Location = New System.Drawing.Point(17, 17)
        Me.LabelSanction.Name = "LabelSanction"
        Me.LabelSanction.Size = New System.Drawing.Size(46, 13)
        Me.LabelSanction.TabIndex = 48
        Me.LabelSanction.Text = "Sanctie:"
        '
        'CheckBoxDoubleUp
        '
        Me.CheckBoxDoubleUp.AutoSize = True
        Me.CheckBoxDoubleUp.Enabled = False
        Me.CheckBoxDoubleUp.Location = New System.Drawing.Point(115, 301)
        Me.CheckBoxDoubleUp.Name = "CheckBoxDoubleUp"
        Me.CheckBoxDoubleUp.Size = New System.Drawing.Size(159, 17)
        Me.CheckBoxDoubleUp.TabIndex = 49
        Me.CheckBoxDoubleUp.Text = "Verdubbeling laatste sanctie"
        Me.CheckBoxDoubleUp.UseVisualStyleBackColor = True
        '
        'GroupBoxPreviousInfractions
        '
        Me.GroupBoxPreviousInfractions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPreviousInfractions.Controls.Add(Me.UltraGridPreviousInfractions)
        Me.GroupBoxPreviousInfractions.Location = New System.Drawing.Point(12, 356)
        Me.GroupBoxPreviousInfractions.Name = "GroupBoxPreviousInfractions"
        Me.GroupBoxPreviousInfractions.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBoxPreviousInfractions.Size = New System.Drawing.Size(1047, 147)
        Me.GroupBoxPreviousInfractions.TabIndex = 50
        Me.GroupBoxPreviousInfractions.TabStop = False
        Me.GroupBoxPreviousInfractions.Text = "Vastgestelde inbreuken (laatste 24 maanden en  later dan 15 maart 2013)"
        '
        'UltraGridPreviousInfractions
        '
        Me.UltraGridPreviousInfractions.DataMember = "Lijst_Overtredingen"
        Me.UltraGridPreviousInfractions.DataSource = Me._dataOvertreding
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37})
        Me.UltraGridPreviousInfractions.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridPreviousInfractions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPreviousInfractions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridPreviousInfractions.Location = New System.Drawing.Point(10, 23)
        Me.UltraGridPreviousInfractions.Name = "UltraGridPreviousInfractions"
        Me.UltraGridPreviousInfractions.Size = New System.Drawing.Size(1027, 114)
        Me.UltraGridPreviousInfractions.TabIndex = 0
        '
        '_dataOvertreding
        '
        Me._dataOvertreding.DataSetName = "TDSOvertreding"
        Me._dataOvertreding.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelInfractionClass
        '
        Me.LabelInfractionClass.AutoSize = True
        Me.LabelInfractionClass.Location = New System.Drawing.Point(288, 226)
        Me.LabelInfractionClass.Name = "LabelInfractionClass"
        Me.LabelInfractionClass.Size = New System.Drawing.Size(76, 13)
        Me.LabelInfractionClass.TabIndex = 51
        Me.LabelInfractionClass.Text = "Inbreukklasse:"
        '
        'TextBoxInfractionClass
        '
        Me.TextBoxInfractionClass.Location = New System.Drawing.Point(376, 223)
        Me.TextBoxInfractionClass.Name = "TextBoxInfractionClass"
        Me.TextBoxInfractionClass.ReadOnly = True
        Me.TextBoxInfractionClass.Size = New System.Drawing.Size(205, 20)
        Me.TextBoxInfractionClass.TabIndex = 52
        Me.TextBoxInfractionClass.TabStop = False
        '
        'TextBoxSanctionDuration
        '
        Me.TextBoxSanctionDuration.Location = New System.Drawing.Point(115, 275)
        Me.TextBoxSanctionDuration.Name = "TextBoxSanctionDuration"
        Me.TextBoxSanctionDuration.ReadOnly = True
        Me.TextBoxSanctionDuration.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSanctionDuration.TabIndex = 54
        Me.TextBoxSanctionDuration.TabStop = False
        '
        'LabelSanctionDuration
        '
        Me.LabelSanctionDuration.AutoSize = True
        Me.LabelSanctionDuration.Location = New System.Drawing.Point(36, 278)
        Me.LabelSanctionDuration.Name = "LabelSanctionDuration"
        Me.LabelSanctionDuration.Size = New System.Drawing.Size(67, 13)
        Me.LabelSanctionDuration.TabIndex = 53
        Me.LabelSanctionDuration.Text = "Sanctieduur:"
        '
        'TextBoxSanctionPeriod
        '
        Me.TextBoxSanctionPeriod.Location = New System.Drawing.Point(275, 275)
        Me.TextBoxSanctionPeriod.Name = "TextBoxSanctionPeriod"
        Me.TextBoxSanctionPeriod.ReadOnly = True
        Me.TextBoxSanctionPeriod.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxSanctionPeriod.TabIndex = 56
        Me.TextBoxSanctionPeriod.TabStop = False
        '
        'LabelSanctionPeriod
        '
        Me.LabelSanctionPeriod.AutoSize = True
        Me.LabelSanctionPeriod.Location = New System.Drawing.Point(202, 278)
        Me.LabelSanctionPeriod.Name = "LabelSanctionPeriod"
        Me.LabelSanctionPeriod.Size = New System.Drawing.Size(67, 13)
        Me.LabelSanctionPeriod.TabIndex = 55
        Me.LabelSanctionPeriod.Text = "Sanctieduur:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "E-mail n+1 chef:"
        '
        'TextBoxEmailChef
        '
        Me.TextBoxEmailChef.Location = New System.Drawing.Point(115, 325)
        Me.TextBoxEmailChef.Name = "TextBoxEmailChef"
        Me.TextBoxEmailChef.ReadOnly = True
        Me.TextBoxEmailChef.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxEmailChef.TabIndex = 58
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(468, 325)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(120, 25)
        Me.ButtonCancel.TabIndex = 46
        Me.ButtonCancel.Text = "Annuleren"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
        Me.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOK.Location = New System.Drawing.Point(468, 293)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(120, 25)
        Me.ButtonOK.TabIndex = 47
        Me.ButtonOK.Text = "OK + Send mail"
        Me.ButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'UltraComboSanction
        '
        Me.UltraComboSanction.DataMember = "BBINBRSanction"
        Me.UltraComboSanction.DataSource = Me._dataBewakingSnelheidSanction
        Me.UltraComboSanction.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridColumn39.Width = 242
        UltraGridColumn40.Header.VisiblePosition = 2
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 3
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 6
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 7
        UltraGridColumn45.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45})
        Me.UltraComboSanction.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraComboSanction.DisplayMember = "SanctionDescr"
        Me.UltraComboSanction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboSanction.Location = New System.Drawing.Point(110, 13)
        Me.UltraComboSanction.Name = "UltraComboSanction"
        Me.UltraComboSanction.Size = New System.Drawing.Size(260, 22)
        Me.UltraComboSanction.TabIndex = 0
        Me.UltraComboSanction.ValueMember = "SanctionID"
        '
        '_dataBewakingSnelheidSanction
        '
        Me._dataBewakingSnelheidSanction.DataSetName = "TDSBewakingSnelheidSanction"
        Me._dataBewakingSnelheidSanction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonInfo
        '
        Me.ButtonInfo.Image = CType(resources.GetObject("ButtonInfo.Image"), System.Drawing.Image)
        Me.ButtonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInfo.Location = New System.Drawing.Point(387, 354)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(54, 19)
        Me.ButtonInfo.TabIndex = 60
        Me.ButtonInfo.Text = "Info"
        Me.ButtonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInfo.UseVisualStyleBackColor = True
        '
        'ucSAPPresence
        '
        Me.ucSAPPresence.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucSAPPresence.Datum = New Date(CType(0, Long))
        Me.ucSAPPresence.Location = New System.Drawing.Point(594, 37)
        Me.ucSAPPresence.Name = "ucSAPPresence"
        Me.ucSAPPresence.PersonalNr = Nothing
        Me.ucSAPPresence.Size = New System.Drawing.Size(465, 313)
        Me.ucSAPPresence.TabIndex = 59
        '
        'FormPrintTrafficInfractions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 515)
        Me.Controls.Add(Me.ButtonInfo)
        Me.Controls.Add(Me.ucSAPPresence)
        Me.Controls.Add(Me.TextBoxEmailChef)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSanctionPeriod)
        Me.Controls.Add(Me.LabelSanctionPeriod)
        Me.Controls.Add(Me.TextBoxSanctionDuration)
        Me.Controls.Add(Me.LabelSanctionDuration)
        Me.Controls.Add(Me.TextBoxInfractionClass)
        Me.Controls.Add(Me.LabelInfractionClass)
        Me.Controls.Add(Me.GroupBoxPreviousInfractions)
        Me.Controls.Add(Me.CheckBoxDoubleUp)
        Me.Controls.Add(Me.UltraComboSanction)
        Me.Controls.Add(Me.LabelSanction)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxVoertuig)
        Me.Controls.Add(Me.LabelTypeCar)
        Me.Controls.Add(Me.LabelKMOur)
        Me.Controls.Add(Me.TextBoxMaxSnelheid)
        Me.Controls.Add(Me.LabelSpeedAllowed)
        Me.Controls.Add(Me.LabelKMHour)
        Me.Controls.Add(Me.TextBoxSnelheid)
        Me.Controls.Add(Me.LabelSpeed)
        Me.Controls.Add(Me.TextBoxNrPlate)
        Me.Controls.Add(Me.LabelLicensePlate)
        Me.Controls.Add(Me.TextBoxDriverName)
        Me.Controls.Add(Me.LabelNameDriver)
        Me.Controls.Add(Me.GroupBoxInfractions)
        Me.Controls.Add(Me.GroupBoxDates)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(860, 520)
        Me.Name = "FormPrintTrafficInfractions"
        Me.Text = "Afdrukken overtreding internen (PBH)"
        Me.GroupBoxInfractions.ResumeLayout(False)
        Me.GroupBoxInfractions.PerformLayout()
        Me.GroupBoxDates.ResumeLayout(False)
        Me.GroupBoxDates.PerformLayout()
        CType(Me.UltraDateTimeAfdrukken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPreviousInfractions.ResumeLayout(False)
        CType(Me.UltraGridPreviousInfractions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataOvertreding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboSanction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TextBoxVoertuig As System.Windows.Forms.TextBox
    Friend WithEvents LabelTypeCar As System.Windows.Forms.Label
    Friend WithEvents LabelKMOur As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaxSnelheid As System.Windows.Forms.TextBox
    Friend WithEvents LabelSpeedAllowed As System.Windows.Forms.Label
    Friend WithEvents LabelKMHour As System.Windows.Forms.Label
    Friend WithEvents TextBoxSnelheid As System.Windows.Forms.TextBox
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents TextBoxNrPlate As System.Windows.Forms.TextBox
    Friend WithEvents LabelLicensePlate As System.Windows.Forms.Label
    Friend WithEvents TextBoxDriverName As System.Windows.Forms.TextBox
    Friend WithEvents LabelNameDriver As System.Windows.Forms.Label
    Friend WithEvents GroupBoxInfractions As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInbr3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInbr2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInbr1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxDates As System.Windows.Forms.GroupBox
    Friend WithEvents LabelSanction As System.Windows.Forms.Label
    Friend WithEvents UltraComboSanction As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraDateAfspraakPBH As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelRijverbodTot As System.Windows.Forms.Label
    Friend WithEvents UltraDateRijverbodVan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelRijverbodVan As System.Windows.Forms.Label
    Friend WithEvents UltraDateRijverbodTot As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelAfspraak As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDoubleUp As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxPreviousInfractions As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridPreviousInfractions As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataOvertreding As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding
    Friend WithEvents _dataBewakingSnelheidSanction As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction
    Friend WithEvents LabelInfractionClass As System.Windows.Forms.Label
    Friend WithEvents TextBoxInfractionClass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSanctionDuration As System.Windows.Forms.TextBox
    Friend WithEvents LabelSanctionDuration As System.Windows.Forms.Label
    Friend WithEvents TextBoxSanctionPeriod As System.Windows.Forms.TextBox
    Friend WithEvents LabelSanctionPeriod As System.Windows.Forms.Label
    Friend WithEvents LabelPrintenBrief As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeAfdrukken As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmailChef As System.Windows.Forms.TextBox
    Friend WithEvents ucSAPPresence As Be.Sidmar.RIS.BrandweerBewaking.Client.UserControlSAPPresence
    Friend WithEvents ButtonInfo As System.Windows.Forms.Button
End Class
