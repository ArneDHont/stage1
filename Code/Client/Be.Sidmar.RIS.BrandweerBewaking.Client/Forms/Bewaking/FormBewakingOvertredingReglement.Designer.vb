<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBewakingOvertredingReglement
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Overtredingen", -1)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_dir")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_afd")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_sect")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieDuur")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctiePeriode")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inbreukklasse")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20+")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FirmaId")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionId")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inbreukKlasseId")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remarks")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "RegistratieID", 0, True, "Lijst_Overtredingen", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Overtredingen", -1)
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_dir")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_afd")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sap_sect")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieDuur")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctiePeriode")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Inbreukklasse")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("20+")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FirmaId")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionId")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("inbreukKlasseId")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remarks")
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "RegistratieID", 0, True, "Lijst_Overtredingen", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, "RegistratieID", 0, True)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanction", -1)
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDescr")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionNL")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionFR")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionEN")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDE")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanctionMatrix", -1)
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionMatrixID")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionMatrixDescr")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zone")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SpeedFrom")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SpeedTo")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CarMotorYN")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TruckYN")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction1")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction2_24months")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction3_24months")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remark")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingOvertredingReglement))
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
        Me.UltraTabPageControlIntern = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridIntern = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataOvertredingIntern = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding()
        Me.UltraTabPageControlExtern = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridInfractionsExtern = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataOvertredingExtern = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding()
        Me.UltraTabPageControlSanctions = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GroupBoxInfractions2eKlasse = New System.Windows.Forms.GroupBox()
        Me.LabelKlasse23 = New System.Windows.Forms.Label()
        Me.LabelKlasse22 = New System.Windows.Forms.Label()
        Me.LabelKlasse21 = New System.Windows.Forms.Label()
        Me.GroupBoxInfraction1stClass = New System.Windows.Forms.GroupBox()
        Me.LabelKlasse12 = New System.Windows.Forms.Label()
        Me.LabelKlasse1 = New System.Windows.Forms.Label()
        Me.GroupBoxSanctions = New System.Windows.Forms.GroupBox()
        Me.UltraGridSanctions = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBewakingSnelheidSanction = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction()
        Me.GroupBoxSpeedViolations = New System.Windows.Forms.GroupBox()
        Me.UltraGridSpeedViolations = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBewakingSnelheidSanctionMatrix = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanctionMatrix()
        Me.ToolStripInfractions = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonLetterSent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonGiveRemarks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDeleteSanction = New System.Windows.Forms.ToolStripButton()
        Me.ToolTipInfractionsRegulations = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainerInfractions = New System.Windows.Forms.SplitContainer()
        Me.UltraTabControlInfractions = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.GroupBoxSearchOptions = New System.Windows.Forms.GroupBox()
        Me.ButtonRetrieveData = New System.Windows.Forms.Button()
        Me.UltraComboRetrieveInfractionsFrom = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
        Me.LabelRetrieveInfractionsFrom = New System.Windows.Forms.Label()
        Me.GroupBoxLegenda = New System.Windows.Forms.GroupBox()
        Me.LabelClassOne = New System.Windows.Forms.Label()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.ButtonOpenReport = New System.Windows.Forms.Button()
        Me.ButtonMail = New System.Windows.Forms.Button()
        Me.ButtonShowHierarchicalLine = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelDirectChefs = New System.Windows.Forms.Label()
        Me.UltraTabPageControlIntern.SuspendLayout()
        CType(Me.UltraGridIntern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOvertredingIntern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControlExtern.SuspendLayout()
        CType(Me.UltraGridInfractionsExtern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOvertredingExtern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControlSanctions.SuspendLayout()
        Me.GroupBoxInfractions2eKlasse.SuspendLayout()
        Me.GroupBoxInfraction1stClass.SuspendLayout()
        Me.GroupBoxSanctions.SuspendLayout()
        CType(Me.UltraGridSanctions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSpeedViolations.SuspendLayout()
        CType(Me.UltraGridSpeedViolations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingSnelheidSanctionMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripInfractions.SuspendLayout()
        CType(Me.SplitContainerInfractions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerInfractions.Panel1.SuspendLayout()
        Me.SplitContainerInfractions.Panel2.SuspendLayout()
        Me.SplitContainerInfractions.SuspendLayout()
        CType(Me.UltraTabControlInfractions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlInfractions.SuspendLayout()
        Me.GroupBoxSearchOptions.SuspendLayout()
        CType(Me.UltraComboRetrieveInfractionsFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLegenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControlIntern
        '
        Me.UltraTabPageControlIntern.Controls.Add(Me.UltraGridIntern)
        Me.UltraTabPageControlIntern.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControlIntern.Name = "UltraTabPageControlIntern"
        Me.UltraTabPageControlIntern.Size = New System.Drawing.Size(1020, 510)
        '
        'UltraGridIntern
        '
        Me.UltraGridIntern.DataMember = "Lijst_Overtredingen"
        Me.UltraGridIntern.DataSource = Me._dataOvertredingIntern
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn92.Header.VisiblePosition = 28
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn93.Header.VisiblePosition = 4
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn94.Header.VisiblePosition = 5
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn95.Header.Caption = "Overtreder"
        UltraGridColumn95.Header.VisiblePosition = 2
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn96.Header.VisiblePosition = 3
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn97.Header.VisiblePosition = 0
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn98.Header.VisiblePosition = 19
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn99.Header.VisiblePosition = 20
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn100.Header.VisiblePosition = 6
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn101.Header.Caption = "Toegelaten"
        UltraGridColumn101.Header.VisiblePosition = 10
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn102.Header.Caption = "Geregistreerd"
        UltraGridColumn102.Header.VisiblePosition = 11
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn103.Header.VisiblePosition = 7
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn104.Header.VisiblePosition = 8
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn105.Header.VisiblePosition = 27
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn107.Header.VisiblePosition = 15
        UltraGridColumn108.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn108.Header.VisiblePosition = 16
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn109.Header.VisiblePosition = 17
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn110.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn110.Header.VisiblePosition = 18
        UltraGridColumn110.Width = 100
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn111.Header.VisiblePosition = 29
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn112.Header.Caption = "Dir"
        UltraGridColumn112.Header.VisiblePosition = 21
        UltraGridColumn112.Width = 58
        UltraGridColumn113.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn113.Header.Caption = "Afd"
        UltraGridColumn113.Header.VisiblePosition = 22
        UltraGridColumn113.Width = 59
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn114.Header.Caption = "Sectie"
        UltraGridColumn114.Header.VisiblePosition = 23
        UltraGridColumn114.Width = 69
        UltraGridColumn115.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn115.Header.VisiblePosition = 30
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn116.Header.VisiblePosition = 24
        UltraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn117.Header.VisiblePosition = 31
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn118.Header.VisiblePosition = 32
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn119.Header.VisiblePosition = 14
        UltraGridColumn120.Header.VisiblePosition = 25
        UltraGridColumn121.Header.VisiblePosition = 26
        UltraGridColumn122.Header.VisiblePosition = 9
        UltraGridColumn123.Header.VisiblePosition = 12
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn124.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn124.Header.Caption = "Dubbel?"
        UltraGridColumn124.Header.VisiblePosition = 33
        UltraGridColumn125.Header.VisiblePosition = 34
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 35
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 36
        UltraGridColumn127.Hidden = True
        UltraGridColumn1.Header.Caption = "Opm"
        UltraGridColumn1.Header.VisiblePosition = 13
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn1})
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        SummarySettings1.DisplayFormat = "Aantal= {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance1
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridIntern.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridIntern.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridIntern.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UltraGridIntern.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.UltraGridIntern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridIntern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridIntern.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridIntern.Name = "UltraGridIntern"
        Me.UltraGridIntern.Size = New System.Drawing.Size(1020, 510)
        Me.UltraGridIntern.TabIndex = 1
        '
        '_dataOvertredingIntern
        '
        Me._dataOvertredingIntern.DataSetName = "TDSOvertreding"
        Me._dataOvertredingIntern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraTabPageControlExtern
        '
        Me.UltraTabPageControlExtern.Controls.Add(Me.UltraGridInfractionsExtern)
        Me.UltraTabPageControlExtern.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControlExtern.Name = "UltraTabPageControlExtern"
        Me.UltraTabPageControlExtern.Size = New System.Drawing.Size(1020, 510)
        '
        'UltraGridInfractionsExtern
        '
        Me.UltraGridInfractionsExtern.DataMember = "Lijst_Overtredingen"
        Me.UltraGridInfractionsExtern.DataSource = Me._dataOvertredingExtern
        UltraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn128.Header.VisiblePosition = 19
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.VisiblePosition = 3
        UltraGridColumn130.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn130.Header.VisiblePosition = 4
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn131.Header.Caption = "Overtreder"
        UltraGridColumn131.Header.VisiblePosition = 2
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn132.Header.VisiblePosition = 32
        UltraGridColumn133.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn133.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn133.Header.VisiblePosition = 0
        UltraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn134.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn134.Header.VisiblePosition = 12
        UltraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn135.Header.VisiblePosition = 13
        UltraGridColumn136.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn136.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn136.Header.VisiblePosition = 5
        UltraGridColumn137.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn137.Header.Caption = "Toegelaten"
        UltraGridColumn137.Header.VisiblePosition = 9
        UltraGridColumn138.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn138.Header.Caption = "Geregistreerd"
        UltraGridColumn138.Header.VisiblePosition = 10
        UltraGridColumn139.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn139.Header.VisiblePosition = 6
        UltraGridColumn140.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn140.Header.VisiblePosition = 7
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn141.Header.VisiblePosition = 30
        UltraGridColumn142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn142.Header.VisiblePosition = 1
        UltraGridColumn143.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn143.Header.VisiblePosition = 20
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn144.Header.VisiblePosition = 21
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn145.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn145.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn145.Header.Caption = "Brief gepost"
        UltraGridColumn145.Header.VisiblePosition = 18
        UltraGridColumn145.Width = 103
        UltraGridColumn146.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn146.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn146.Header.VisiblePosition = 22
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn147.Header.VisiblePosition = 23
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn148.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn148.Header.VisiblePosition = 24
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn149.Header.VisiblePosition = 25
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn150.Header.VisiblePosition = 26
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn151.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn151.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn151.Header.Caption = "Datum afgedrukt"
        UltraGridColumn151.Header.VisiblePosition = 17
        UltraGridColumn151.Width = 99
        UltraGridColumn152.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn152.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn152.Header.VisiblePosition = 14
        UltraGridColumn153.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn153.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn153.Header.VisiblePosition = 15
        UltraGridColumn153.Width = 54
        UltraGridColumn154.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn154.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn154.Header.Caption = "Externe Firma"
        UltraGridColumn154.Header.VisiblePosition = 16
        UltraGridColumn155.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn155.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn155.Header.VisiblePosition = 27
        UltraGridColumn156.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn156.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn156.Header.VisiblePosition = 28
        UltraGridColumn157.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn157.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn157.Header.VisiblePosition = 29
        UltraGridColumn158.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn158.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn158.Header.VisiblePosition = 8
        UltraGridColumn159.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn159.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn159.Header.VisiblePosition = 11
        UltraGridColumn160.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn160.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn160.Header.Caption = "Dubbel?"
        UltraGridColumn160.Header.VisiblePosition = 31
        UltraGridColumn161.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn161.Header.VisiblePosition = 33
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn162.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn162.Header.VisiblePosition = 34
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 35
        UltraGridColumn163.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 36
        UltraGridColumn2.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn2})
        SummarySettings2.DisplayFormat = "Aantal= {0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance2
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings2})
        UltraGridBand2.SummaryFooterCaption = ""
        Me.UltraGridInfractionsExtern.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridInfractionsExtern.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridInfractionsExtern.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UltraGridInfractionsExtern.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.UltraGridInfractionsExtern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridInfractionsExtern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInfractionsExtern.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridInfractionsExtern.Name = "UltraGridInfractionsExtern"
        Me.UltraGridInfractionsExtern.Size = New System.Drawing.Size(1020, 510)
        Me.UltraGridInfractionsExtern.TabIndex = 0
        '
        '_dataOvertredingExtern
        '
        Me._dataOvertredingExtern.DataSetName = "TDSOvertreding"
        Me._dataOvertredingExtern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraTabPageControlSanctions
        '
        Me.UltraTabPageControlSanctions.Controls.Add(Me.GroupBoxInfractions2eKlasse)
        Me.UltraTabPageControlSanctions.Controls.Add(Me.GroupBoxInfraction1stClass)
        Me.UltraTabPageControlSanctions.Controls.Add(Me.GroupBoxSanctions)
        Me.UltraTabPageControlSanctions.Controls.Add(Me.GroupBoxSpeedViolations)
        Me.UltraTabPageControlSanctions.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControlSanctions.Name = "UltraTabPageControlSanctions"
        Me.UltraTabPageControlSanctions.Size = New System.Drawing.Size(1020, 510)
        '
        'GroupBoxInfractions2eKlasse
        '
        Me.GroupBoxInfractions2eKlasse.Controls.Add(Me.LabelKlasse23)
        Me.GroupBoxInfractions2eKlasse.Controls.Add(Me.LabelKlasse22)
        Me.GroupBoxInfractions2eKlasse.Controls.Add(Me.LabelKlasse21)
        Me.GroupBoxInfractions2eKlasse.Location = New System.Drawing.Point(521, 403)
        Me.GroupBoxInfractions2eKlasse.Name = "GroupBoxInfractions2eKlasse"
        Me.GroupBoxInfractions2eKlasse.Size = New System.Drawing.Size(490, 100)
        Me.GroupBoxInfractions2eKlasse.TabIndex = 3
        Me.GroupBoxInfractions2eKlasse.TabStop = False
        Me.GroupBoxInfractions2eKlasse.Text = "Overtredingen 2e klasse"
        '
        'LabelKlasse23
        '
        Me.LabelKlasse23.AutoSize = True
        Me.LabelKlasse23.Location = New System.Drawing.Point(6, 74)
        Me.LabelKlasse23.Name = "LabelKlasse23"
        Me.LabelKlasse23.Size = New System.Drawing.Size(384, 13)
        Me.LabelKlasse23.TabIndex = 4
        Me.LabelKlasse23.Text = "- Parkeerklem bij herhaalde inbreuken tegen het parkeren (Administratiegebouw)"
        '
        'LabelKlasse22
        '
        Me.LabelKlasse22.AutoSize = True
        Me.LabelKlasse22.Location = New System.Drawing.Point(6, 51)
        Me.LabelKlasse22.Name = "LabelKlasse22"
        Me.LabelKlasse22.Size = New System.Drawing.Size(297, 13)
        Me.LabelKlasse22.TabIndex = 3
        Me.LabelKlasse22.Text = "- Vanaf 3 x Klasse 2 binnen de 24 maanden: 1 week rijverbod"
        '
        'LabelKlasse21
        '
        Me.LabelKlasse21.AutoSize = True
        Me.LabelKlasse21.Location = New System.Drawing.Point(6, 29)
        Me.LabelKlasse21.Name = "LabelKlasse21"
        Me.LabelKlasse21.Size = New System.Drawing.Size(304, 13)
        Me.LabelKlasse21.TabIndex = 2
        Me.LabelKlasse21.Text = "- Tot 2 x Klasse 2 binnen de 24 maanden: schriftelijke berisping"
        '
        'GroupBoxInfraction1stClass
        '
        Me.GroupBoxInfraction1stClass.Controls.Add(Me.LabelKlasse12)
        Me.GroupBoxInfraction1stClass.Controls.Add(Me.LabelKlasse1)
        Me.GroupBoxInfraction1stClass.Location = New System.Drawing.Point(11, 403)
        Me.GroupBoxInfraction1stClass.Name = "GroupBoxInfraction1stClass"
        Me.GroupBoxInfraction1stClass.Size = New System.Drawing.Size(490, 100)
        Me.GroupBoxInfraction1stClass.TabIndex = 2
        Me.GroupBoxInfraction1stClass.TabStop = False
        Me.GroupBoxInfraction1stClass.Text = "Overtredingen 1e klasse"
        '
        'LabelKlasse12
        '
        Me.LabelKlasse12.AutoSize = True
        Me.LabelKlasse12.Location = New System.Drawing.Point(6, 51)
        Me.LabelKlasse12.Name = "LabelKlasse12"
        Me.LabelKlasse12.Size = New System.Drawing.Size(305, 13)
        Me.LabelKlasse12.TabIndex = 1
        Me.LabelKlasse12.Text = "- Recidive binnen de 24 maanden: verdubbeling laatste sanctie"
        '
        'LabelKlasse1
        '
        Me.LabelKlasse1.AutoSize = True
        Me.LabelKlasse1.Location = New System.Drawing.Point(6, 29)
        Me.LabelKlasse1.Name = "LabelKlasse1"
        Me.LabelKlasse1.Size = New System.Drawing.Size(91, 13)
        Me.LabelKlasse1.TabIndex = 0
        Me.LabelKlasse1.Text = "- 1 week rijverbod"
        '
        'GroupBoxSanctions
        '
        Me.GroupBoxSanctions.Controls.Add(Me.UltraGridSanctions)
        Me.GroupBoxSanctions.Location = New System.Drawing.Point(11, 203)
        Me.GroupBoxSanctions.Name = "GroupBoxSanctions"
        Me.GroupBoxSanctions.Size = New System.Drawing.Size(1000, 194)
        Me.GroupBoxSanctions.TabIndex = 1
        Me.GroupBoxSanctions.TabStop = False
        Me.GroupBoxSanctions.Text = "Sancties"
        '
        'UltraGridSanctions
        '
        Me.UltraGridSanctions.DataMember = "BBINBRSanction"
        Me.UltraGridSanctions.DataSource = Me._dataBewakingSnelheidSanction
        Me.UltraGridSanctions.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn164.Header.VisiblePosition = 0
        UltraGridColumn164.Width = 53
        UltraGridColumn165.Header.Caption = "Sanctie omschr."
        UltraGridColumn165.Header.VisiblePosition = 1
        UltraGridColumn165.Width = 295
        UltraGridColumn166.Header.Caption = "Sanctie NL"
        UltraGridColumn166.Header.VisiblePosition = 2
        UltraGridColumn166.Width = 326
        UltraGridColumn167.Header.Caption = "Sanctie FR"
        UltraGridColumn167.Header.VisiblePosition = 3
        UltraGridColumn167.Width = 94
        UltraGridColumn168.Header.Caption = "Sanctie EN"
        UltraGridColumn168.Header.VisiblePosition = 4
        UltraGridColumn168.Width = 94
        UltraGridColumn169.Header.Caption = "Sanctie DE"
        UltraGridColumn169.Header.VisiblePosition = 5
        UltraGridColumn169.Width = 94
        UltraGridColumn170.Header.Caption = "Duur"
        UltraGridColumn170.Header.VisiblePosition = 6
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.Caption = "Periode"
        UltraGridColumn171.Header.VisiblePosition = 7
        UltraGridColumn171.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171})
        Me.UltraGridSanctions.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraGridSanctions.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridSanctions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSanctions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSanctions.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridSanctions.Name = "UltraGridSanctions"
        Me.UltraGridSanctions.Size = New System.Drawing.Size(994, 175)
        Me.UltraGridSanctions.TabIndex = 1
        '
        '_dataBewakingSnelheidSanction
        '
        Me._dataBewakingSnelheidSanction.DataSetName = "TDSBewakingSnelheidSanction"
        Me._dataBewakingSnelheidSanction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxSpeedViolations
        '
        Me.GroupBoxSpeedViolations.Controls.Add(Me.UltraGridSpeedViolations)
        Me.GroupBoxSpeedViolations.Location = New System.Drawing.Point(11, 3)
        Me.GroupBoxSpeedViolations.Name = "GroupBoxSpeedViolations"
        Me.GroupBoxSpeedViolations.Size = New System.Drawing.Size(1000, 194)
        Me.GroupBoxSpeedViolations.TabIndex = 0
        Me.GroupBoxSpeedViolations.TabStop = False
        Me.GroupBoxSpeedViolations.Text = "Matrix snelheidsovertredingen"
        '
        'UltraGridSpeedViolations
        '
        Me.UltraGridSpeedViolations.DataMember = "BBINBRSanctionMatrix"
        Me.UltraGridSpeedViolations.DataSource = Me._dataBewakingSnelheidSanctionMatrix
        UltraGridColumn172.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn172.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn172.Header.VisiblePosition = 0
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn173.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn173.Header.Caption = "Matrix omschr"
        UltraGridColumn173.Header.VisiblePosition = 1
        UltraGridColumn174.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn174.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn174.Header.VisiblePosition = 2
        UltraGridColumn175.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn175.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn175.Header.Caption = "Snelh. van"
        UltraGridColumn175.Header.VisiblePosition = 3
        UltraGridColumn176.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn176.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn176.Header.Caption = "Snelh. tot"
        UltraGridColumn176.Header.VisiblePosition = 4
        UltraGridColumn177.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn177.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn177.Header.Caption = "Auto/moto"
        UltraGridColumn177.Header.VisiblePosition = 5
        UltraGridColumn178.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn178.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn178.Header.Caption = "Vrachtwagen"
        UltraGridColumn178.Header.VisiblePosition = 6
        UltraGridColumn179.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn179.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn179.Header.Caption = "SanctieNr. 1e inbr."
        UltraGridColumn179.Header.VisiblePosition = 7
        UltraGridColumn180.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn180.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn180.Header.Caption = "SanctieNr. 2e inbr (24m)"
        UltraGridColumn180.Header.VisiblePosition = 8
        UltraGridColumn181.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn181.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn181.Header.Caption = "SanctieNr. 3e inbr (24m)"
        UltraGridColumn181.Header.VisiblePosition = 9
        UltraGridColumn182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn182.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn182.Header.Caption = "Opmerking"
        UltraGridColumn182.Header.VisiblePosition = 10
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182})
        Me.UltraGridSpeedViolations.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraGridSpeedViolations.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridSpeedViolations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpeedViolations.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSpeedViolations.Location = New System.Drawing.Point(3, 16)
        Me.UltraGridSpeedViolations.Name = "UltraGridSpeedViolations"
        Me.UltraGridSpeedViolations.Size = New System.Drawing.Size(994, 175)
        Me.UltraGridSpeedViolations.TabIndex = 0
        '
        '_dataBewakingSnelheidSanctionMatrix
        '
        Me._dataBewakingSnelheidSanctionMatrix.DataSetName = "TDSBewakingSnelheidSanctionMatrix"
        Me._dataBewakingSnelheidSanctionMatrix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripInfractions
        '
        Me.ToolStripInfractions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCopy, Me.ToolStripButtonRefresh, Me.ToolStripSeparator1, Me.ToolStripButtonLetterSent, Me.ToolStripButtonGiveRemarks, Me.ToolStripButtonDeleteSanction})
        Me.ToolStripInfractions.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripInfractions.Name = "ToolStripInfractions"
        Me.ToolStripInfractions.Size = New System.Drawing.Size(1024, 25)
        Me.ToolStripInfractions.TabIndex = 15
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.Image = CType(resources.GetObject("ToolStripButtonCopy.Image"), System.Drawing.Image)
        Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        Me.ToolStripButtonCopy.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButtonCopy.Text = "Kopieer"
        Me.ToolStripButtonCopy.ToolTipText = "Kopieer data naar clipboard"
        '
        'ToolStripButtonRefresh
        '
        Me.ToolStripButtonRefresh.Image = CType(resources.GetObject("ToolStripButtonRefresh.Image"), System.Drawing.Image)
        Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
        Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButtonRefresh.Text = "Vernieuwen"
        Me.ToolStripButtonRefresh.ToolTipText = "Data in grid vernieuwen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonLetterSent
        '
        Me.ToolStripButtonLetterSent.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Verzendingen
        Me.ToolStripButtonLetterSent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLetterSent.Name = "ToolStripButtonLetterSent"
        Me.ToolStripButtonLetterSent.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripButtonLetterSent.Text = "Brief gepost"
        '
        'ToolStripButtonGiveRemarks
        '
        Me.ToolStripButtonGiveRemarks.Enabled = False
        Me.ToolStripButtonGiveRemarks.Image = CType(resources.GetObject("ToolStripButtonGiveRemarks.Image"), System.Drawing.Image)
        Me.ToolStripButtonGiveRemarks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGiveRemarks.Name = "ToolStripButtonGiveRemarks"
        Me.ToolStripButtonGiveRemarks.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButtonGiveRemarks.Text = "Geef opmerking"
        '
        'ToolStripButtonDeleteSanction
        '
        Me.ToolStripButtonDeleteSanction.Enabled = False
        Me.ToolStripButtonDeleteSanction.Image = CType(resources.GetObject("ToolStripButtonDeleteSanction.Image"), System.Drawing.Image)
        Me.ToolStripButtonDeleteSanction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDeleteSanction.Name = "ToolStripButtonDeleteSanction"
        Me.ToolStripButtonDeleteSanction.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripButtonDeleteSanction.Text = "Sanctie legen"
        '
        'SplitContainerInfractions
        '
        Me.SplitContainerInfractions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerInfractions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainerInfractions.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainerInfractions.Name = "SplitContainerInfractions"
        Me.SplitContainerInfractions.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerInfractions.Panel1
        '
        Me.SplitContainerInfractions.Panel1.Controls.Add(Me.UltraTabControlInfractions)
        '
        'SplitContainerInfractions.Panel2
        '
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.GroupBoxSearchOptions)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.GroupBoxLegenda)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.ButtonOpenReport)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.ButtonMail)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.ButtonShowHierarchicalLine)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.LabelName)
        Me.SplitContainerInfractions.Panel2.Controls.Add(Me.LabelDirectChefs)
        Me.SplitContainerInfractions.Size = New System.Drawing.Size(1024, 636)
        Me.SplitContainerInfractions.SplitterDistance = 536
        Me.SplitContainerInfractions.TabIndex = 16
        '
        'UltraTabControlInfractions
        '
        Me.UltraTabControlInfractions.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControlInfractions.Controls.Add(Me.UltraTabPageControlIntern)
        Me.UltraTabControlInfractions.Controls.Add(Me.UltraTabPageControlExtern)
        Me.UltraTabControlInfractions.Controls.Add(Me.UltraTabPageControlSanctions)
        Me.UltraTabControlInfractions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlInfractions.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlInfractions.Name = "UltraTabControlInfractions"
        Me.UltraTabControlInfractions.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControlInfractions.Size = New System.Drawing.Size(1024, 536)
        Me.UltraTabControlInfractions.TabIndex = 20
        UltraTab1.Key = "InternInfractions"
        UltraTab1.TabPage = Me.UltraTabPageControlIntern
        UltraTab1.Text = "Intern (PBH)"
        UltraTab2.Key = "ExternInfractions"
        UltraTab2.TabPage = Me.UltraTabPageControlExtern
        UltraTab2.Text = "Extern (PEB)"
        UltraTab3.Key = "Sanctions"
        UltraTab3.TabPage = Me.UltraTabPageControlSanctions
        UltraTab3.Text = "Sancties"
        Me.UltraTabControlInfractions.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1020, 510)
        '
        'GroupBoxSearchOptions
        '
        Me.GroupBoxSearchOptions.Controls.Add(Me.ButtonRetrieveData)
        Me.GroupBoxSearchOptions.Controls.Add(Me.UltraComboRetrieveInfractionsFrom)
        Me.GroupBoxSearchOptions.Controls.Add(Me.LabelRetrieveInfractionsFrom)
        Me.GroupBoxSearchOptions.Location = New System.Drawing.Point(766, 7)
        Me.GroupBoxSearchOptions.Name = "GroupBoxSearchOptions"
        Me.GroupBoxSearchOptions.Size = New System.Drawing.Size(246, 81)
        Me.GroupBoxSearchOptions.TabIndex = 27
        Me.GroupBoxSearchOptions.TabStop = false
        Me.GroupBoxSearchOptions.Text = "Overtredingen ophalen"
        Me.GroupBoxSearchOptions.Visible = false
        '
        'ButtonRetrieveData
        '
        Me.ButtonRetrieveData.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.find
        Me.ButtonRetrieveData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRetrieveData.Location = New System.Drawing.Point(139, 31)
        Me.ButtonRetrieveData.Name = "ButtonRetrieveData"
        Me.ButtonRetrieveData.Size = New System.Drawing.Size(101, 23)
        Me.ButtonRetrieveData.TabIndex = 28
        Me.ButtonRetrieveData.Text = "Ophalen"
        Me.ButtonRetrieveData.UseVisualStyleBackColor = true
        '
        'UltraComboRetrieveInfractionsFrom
        '
        Me.UltraComboRetrieveInfractionsFrom.DateButtons.Add(DateButton1)
        Me.UltraComboRetrieveInfractionsFrom.Location = New System.Drawing.Point(6, 33)
        Me.UltraComboRetrieveInfractionsFrom.Name = "UltraComboRetrieveInfractionsFrom"
        Me.UltraComboRetrieveInfractionsFrom.NonAutoSizeHeight = 21
        Me.UltraComboRetrieveInfractionsFrom.Size = New System.Drawing.Size(127, 21)
        Me.UltraComboRetrieveInfractionsFrom.TabIndex = 28
        '
        'LabelRetrieveInfractionsFrom
        '
        Me.LabelRetrieveInfractionsFrom.AutoSize = true
        Me.LabelRetrieveInfractionsFrom.Location = New System.Drawing.Point(6, 17)
        Me.LabelRetrieveInfractionsFrom.Name = "LabelRetrieveInfractionsFrom"
        Me.LabelRetrieveInfractionsFrom.Size = New System.Drawing.Size(148, 13)
        Me.LabelRetrieveInfractionsFrom.TabIndex = 28
        Me.LabelRetrieveInfractionsFrom.Text = "Ophalen overtredingen vanaf:"
        '
        'GroupBoxLegenda
        '
        Me.GroupBoxLegenda.Controls.Add(Me.LabelClassOne)
        Me.GroupBoxLegenda.Controls.Add(Me.LabelSpeed)
        Me.GroupBoxLegenda.Location = New System.Drawing.Point(12, 7)
        Me.GroupBoxLegenda.Name = "GroupBoxLegenda"
        Me.GroupBoxLegenda.Size = New System.Drawing.Size(120, 81)
        Me.GroupBoxLegenda.TabIndex = 26
        Me.GroupBoxLegenda.TabStop = false
        Me.GroupBoxLegenda.Text = "Legende"
        '
        'LabelClassOne
        '
        Me.LabelClassOne.AutoSize = true
        Me.LabelClassOne.BackColor = System.Drawing.Color.Orange
        Me.LabelClassOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelClassOne.ForeColor = System.Drawing.Color.Black
        Me.LabelClassOne.Location = New System.Drawing.Point(6, 48)
        Me.LabelClassOne.Name = "LabelClassOne"
        Me.LabelClassOne.Size = New System.Drawing.Size(55, 13)
        Me.LabelClassOne.TabIndex = 1
        Me.LabelClassOne.Text = "Klasse 1"
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = true
        Me.LabelSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelSpeed.ForeColor = System.Drawing.Color.Red
        Me.LabelSpeed.Location = New System.Drawing.Point(6, 22)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(99, 13)
        Me.LabelSpeed.TabIndex = 0
        Me.LabelSpeed.Text = "Snelheid >= 20+"
        '
        'ButtonOpenReport
        '
        Me.ButtonOpenReport.Image = CType(resources.GetObject("ButtonOpenReport.Image"),System.Drawing.Image)
        Me.ButtonOpenReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOpenReport.Location = New System.Drawing.Point(138, 65)
        Me.ButtonOpenReport.Name = "ButtonOpenReport"
        Me.ButtonOpenReport.Size = New System.Drawing.Size(157, 23)
        Me.ButtonOpenReport.TabIndex = 25
        Me.ButtonOpenReport.Text = "Open verslag"
        Me.ButtonOpenReport.UseVisualStyleBackColor = true
        '
        'ButtonMail
        '
        Me.ButtonMail.Enabled = false
        Me.ButtonMail.Image = CType(resources.GetObject("ButtonMail.Image"),System.Drawing.Image)
        Me.ButtonMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMail.Location = New System.Drawing.Point(138, 36)
        Me.ButtonMail.Name = "ButtonMail"
        Me.ButtonMail.Size = New System.Drawing.Size(157, 23)
        Me.ButtonMail.TabIndex = 24
        Me.ButtonMail.Text = "Mailen"
        Me.ButtonMail.UseVisualStyleBackColor = true
        '
        'ButtonShowHierarchicalLine
        '
        Me.ButtonShowHierarchicalLine.Image = CType(resources.GetObject("ButtonShowHierarchicalLine.Image"),System.Drawing.Image)
        Me.ButtonShowHierarchicalLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShowHierarchicalLine.Location = New System.Drawing.Point(138, 7)
        Me.ButtonShowHierarchicalLine.Name = "ButtonShowHierarchicalLine"
        Me.ButtonShowHierarchicalLine.Size = New System.Drawing.Size(157, 23)
        Me.ButtonShowHierarchicalLine.TabIndex = 21
        Me.ButtonShowHierarchicalLine.Text = "Toon Leiding"
        Me.ButtonShowHierarchicalLine.UseVisualStyleBackColor = true
        '
        'LabelName
        '
        Me.LabelName.AutoSize = true
        Me.LabelName.Location = New System.Drawing.Point(336, 17)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(0, 13)
        Me.LabelName.TabIndex = 23
        '
        'LabelDirectChefs
        '
        Me.LabelDirectChefs.AutoSize = true
        Me.LabelDirectChefs.Location = New System.Drawing.Point(336, 41)
        Me.LabelDirectChefs.Name = "LabelDirectChefs"
        Me.LabelDirectChefs.Size = New System.Drawing.Size(0, 13)
        Me.LabelDirectChefs.TabIndex = 22
        '
        'FormBewakingOvertredingReglement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.SplitContainerInfractions)
        Me.Controls.Add(Me.ToolStripInfractions)
        Me.Name = "FormBewakingOvertredingReglement"
        Me.Text = " Alle Overtredingen"
        Me.UltraTabPageControlIntern.ResumeLayout(false)
        CType(Me.UltraGridIntern,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me._dataOvertredingIntern,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControlExtern.ResumeLayout(false)
        CType(Me.UltraGridInfractionsExtern,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me._dataOvertredingExtern,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControlSanctions.ResumeLayout(false)
        Me.GroupBoxInfractions2eKlasse.ResumeLayout(false)
        Me.GroupBoxInfractions2eKlasse.PerformLayout
        Me.GroupBoxInfraction1stClass.ResumeLayout(false)
        Me.GroupBoxInfraction1stClass.PerformLayout
        Me.GroupBoxSanctions.ResumeLayout(false)
        CType(Me.UltraGridSanctions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me._dataBewakingSnelheidSanction,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxSpeedViolations.ResumeLayout(false)
        CType(Me.UltraGridSpeedViolations,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me._dataBewakingSnelheidSanctionMatrix,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStripInfractions.ResumeLayout(false)
        Me.ToolStripInfractions.PerformLayout
        Me.SplitContainerInfractions.Panel1.ResumeLayout(false)
        Me.SplitContainerInfractions.Panel2.ResumeLayout(false)
        Me.SplitContainerInfractions.Panel2.PerformLayout
        CType(Me.SplitContainerInfractions,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerInfractions.ResumeLayout(false)
        CType(Me.UltraTabControlInfractions,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabControlInfractions.ResumeLayout(false)
        Me.GroupBoxSearchOptions.ResumeLayout(false)
        Me.GroupBoxSearchOptions.PerformLayout
        CType(Me.UltraComboRetrieveInfractionsFrom,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxLegenda.ResumeLayout(false)
        Me.GroupBoxLegenda.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents _dataOvertredingIntern As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding
    Friend WithEvents ToolStripInfractions As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents _dataOvertredingExtern As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOvertreding
    Friend WithEvents ToolTipInfractionsRegulations As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainerInfractions As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraTabControlInfractions As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControlIntern As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridIntern As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControlExtern As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridInfractionsExtern As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ButtonMail As System.Windows.Forms.Button
    Friend WithEvents ButtonShowHierarchicalLine As System.Windows.Forms.Button
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelDirectChefs As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenReport As System.Windows.Forms.Button
    Friend WithEvents GroupBoxLegenda As System.Windows.Forms.GroupBox
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents LabelClassOne As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControlSanctions As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GroupBoxSpeedViolations As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxSanctions As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridSanctions As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridSpeedViolations As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataBewakingSnelheidSanction As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction
    Friend WithEvents _dataBewakingSnelheidSanctionMatrix As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanctionMatrix
    Friend WithEvents GroupBoxInfractions2eKlasse As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxInfraction1stClass As System.Windows.Forms.GroupBox
    Friend WithEvents LabelKlasse23 As System.Windows.Forms.Label
    Friend WithEvents LabelKlasse22 As System.Windows.Forms.Label
    Friend WithEvents LabelKlasse21 As System.Windows.Forms.Label
    Friend WithEvents LabelKlasse12 As System.Windows.Forms.Label
    Friend WithEvents LabelKlasse1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButtonLetterSent As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBoxSearchOptions As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonRetrieveData As System.Windows.Forms.Button
    Friend WithEvents UltraComboRetrieveInfractionsFrom As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
    Friend WithEvents LabelRetrieveInfractionsFrom As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonGiveRemarks As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonDeleteSanction As System.Windows.Forms.ToolStripButton
End Class
