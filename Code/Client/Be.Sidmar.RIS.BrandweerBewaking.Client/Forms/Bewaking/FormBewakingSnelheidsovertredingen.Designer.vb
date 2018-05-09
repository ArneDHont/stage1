Namespace Forms.Bewaking
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBewakingSnelheidsovertredingen
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
            Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Snelheidsovertredingen", -1)
            Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
            Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
            Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
            Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
            Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
            Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
            Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
            Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
            Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
            Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
            Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
            Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
            Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
            Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
            Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
            Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
            Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
            Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
            Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
            Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("70+")
            Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
            Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_DIR")
            Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_AFD")
            Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SECT")
            Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
            Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
            Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
            Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
            Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "RegistratieID", 0, True, "Lijst_Snelheidsovertredingen", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
            Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_Snelheidsovertredingen", -1)
            Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
            Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
            Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
            Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
            Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
            Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
            Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
            Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
            Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
            Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
            Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
            Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
            Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
            Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
            Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
            Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodVan")
            Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RijverbodTot")
            Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfspraakPBH")
            Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdrukTijdstip")
            Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("70+")
            Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoDieContactId")
            Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_DIR")
            Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_AFD")
            Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SECT")
            Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumBrief")
            Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortSanctie")
            Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaalBrief")
            Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamFirma")
            Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctieOmschrijving")
            Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "RegistratieID", 0, True, "Lijst_Snelheidsovertredingen", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanctionMatrix", -1)
            Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionMatrixID")
            Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionMatrixDescr")
            Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zone")
            Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SpeedFrom")
            Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SpeedTo")
            Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CarMotorYN")
            Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TruckYN")
            Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction1")
            Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction2_24months")
            Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sanction3_24months")
            Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remark")
            Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "SanctionMatrixID", 0, True, "BBINBRSanctionMatrix", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRSanction", -1)
            Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
            Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDescr")
            Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionNL")
            Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionFR")
            Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionEN")
            Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDE")
            Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
            Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
            Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "SanctionID", 0, True, "BBINBRSanction", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
            Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingSnelheidsovertredingen))
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
            Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
            Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
            Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
            Me.UltraGridLijstSnelheidsovertredingenIntern = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataSnelheidsOvertredingenIntern = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSSnelheidsOvertredingen()
            Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
            Me.UltraGridLijstSnelheidsovertredingenExtern = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataSnelheidsOvertredingenExtern = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSSnelheidsOvertredingen()
            Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
            Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBewakingSnelheidSanctionMatrix = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanctionMatrix()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBewakingSnelheidSanction = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UltraButtonOpenVerslag = New Infragistics.Win.Misc.UltraButton()
            Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
            Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
            Me.UltraTabControlForGrids = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
            Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
            Me.UltraGroupBoxSnelheidsovertredingen = New Infragistics.Win.Misc.UltraGroupBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
            Me.UltraTabPageControl1.SuspendLayout()
            CType(Me.UltraGridLijstSnelheidsovertredingenIntern, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataSnelheidsOvertredingenIntern, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraTabPageControl2.SuspendLayout()
            CType(Me.UltraGridLijstSnelheidsovertredingenExtern, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataSnelheidsOvertredingenExtern, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraTabPageControl3.SuspendLayout()
            CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBewakingSnelheidSanctionMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.UltraTabControlForGrids, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraTabControlForGrids.SuspendLayout()
            CType(Me.UltraGroupBoxSnelheidsovertredingen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraGroupBoxSnelheidsovertredingen.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'UltraTabPageControl1
            '
            Me.UltraTabPageControl1.Controls.Add(Me.UltraGridLijstSnelheidsovertredingenIntern)
            Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
            Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
            Me.UltraTabPageControl1.Size = New System.Drawing.Size(1011, 539)
            '
            'UltraGridLijstSnelheidsovertredingenIntern
            '
            Me.UltraGridLijstSnelheidsovertredingenIntern.DataSource = Me._dataSnelheidsOvertredingenIntern
            Appearance16.BackColor = System.Drawing.SystemColors.Window
            Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Appearance = Appearance16
            UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn59.Header.VisiblePosition = 0
            UltraGridColumn59.Hidden = True
            UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn60.Header.VisiblePosition = 6
            UltraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn61.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn61.Header.VisiblePosition = 7
            UltraGridColumn61.Width = 77
            UltraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn62.Header.Caption = "Overtreder"
            UltraGridColumn62.Header.VisiblePosition = 5
            UltraGridColumn62.Width = 80
            UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn63.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn63.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
            UltraGridColumn63.Header.VisiblePosition = 4
            UltraGridColumn63.Width = 97
            UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn64.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn64.Header.VisiblePosition = 1
            UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn65.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn65.Header.VisiblePosition = 17
            UltraGridColumn66.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn66.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn66.Header.VisiblePosition = 18
            UltraGridColumn67.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn67.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn67.Header.VisiblePosition = 8
            UltraGridColumn68.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn68.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn68.Header.Caption = "Toegelaten"
            UltraGridColumn68.Header.VisiblePosition = 11
            UltraGridColumn68.Width = 79
            UltraGridColumn69.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn69.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn69.Header.Caption = "Geregistreerd"
            UltraGridColumn69.Header.VisiblePosition = 12
            UltraGridColumn69.Width = 89
            UltraGridColumn70.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn70.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn70.Header.VisiblePosition = 9
            UltraGridColumn70.Width = 67
            UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn71.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn71.Header.VisiblePosition = 10
            UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn72.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn72.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
            UltraGridColumn72.Header.VisiblePosition = 3
            UltraGridColumn72.Width = 78
            UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn73.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn73.Header.VisiblePosition = 2
            UltraGridColumn74.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn74.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn74.Header.VisiblePosition = 13
            UltraGridColumn75.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn75.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn75.Header.VisiblePosition = 14
            UltraGridColumn76.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn76.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn76.Header.VisiblePosition = 15
            UltraGridColumn77.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn77.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn77.Header.VisiblePosition = 16
            UltraGridColumn78.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn78.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn78.Header.Caption = "20+"
            UltraGridColumn78.Header.VisiblePosition = 19
            UltraGridColumn79.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn79.Header.VisiblePosition = 20
            UltraGridColumn79.Hidden = True
            UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn80.Header.Caption = "Dir"
            UltraGridColumn80.Header.VisiblePosition = 21
            UltraGridColumn80.Width = 41
            UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn81.Header.Caption = "Afd"
            UltraGridColumn81.Header.VisiblePosition = 22
            UltraGridColumn81.Width = 48
            UltraGridColumn82.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn82.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn82.Header.Caption = "Sectie"
            UltraGridColumn82.Header.VisiblePosition = 23
            UltraGridColumn82.Width = 55
            UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn83.Header.VisiblePosition = 24
            UltraGridColumn83.Hidden = True
            UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn84.Header.VisiblePosition = 25
            UltraGridColumn84.Hidden = True
            UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn85.Header.VisiblePosition = 26
            UltraGridColumn85.Hidden = True
            UltraGridColumn86.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn86.Header.VisiblePosition = 27
            UltraGridColumn86.Hidden = True
            UltraGridColumn87.Header.VisiblePosition = 28
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance4
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance30.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.GroupByBox.Appearance = Appearance30
            Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance32.BackColor2 = System.Drawing.SystemColors.Control
            Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.MaxRowScrollRegions = 1
            Appearance33.BackColor = System.Drawing.SystemColors.Window
            Appearance33.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.ActiveCellAppearance = Appearance33
            Appearance34.BackColor = System.Drawing.SystemColors.Highlight
            Appearance34.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.ActiveRowAppearance = Appearance34
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance35.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.CardAreaAppearance = Appearance35
            Appearance36.BorderColor = System.Drawing.Color.Silver
            Appearance36.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.CellAppearance = Appearance36
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance37.BackColor = System.Drawing.SystemColors.Control
            Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance37.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance37.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.GroupByRowAppearance = Appearance37
            Appearance38.TextHAlignAsString = "Left"
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.HeaderAppearance = Appearance38
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance39.BackColor = System.Drawing.SystemColors.Window
            Appearance39.BorderColor = System.Drawing.Color.Silver
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.RowAppearance = Appearance39
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance40.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.TemplateAddRowAppearance = Appearance40
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridLijstSnelheidsovertredingenIntern.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UltraGridLijstSnelheidsovertredingenIntern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridLijstSnelheidsovertredingenIntern.Location = New System.Drawing.Point(0, 0)
            Me.UltraGridLijstSnelheidsovertredingenIntern.Name = "UltraGridLijstSnelheidsovertredingenIntern"
            Me.UltraGridLijstSnelheidsovertredingenIntern.Size = New System.Drawing.Size(1011, 539)
            Me.UltraGridLijstSnelheidsovertredingenIntern.TabIndex = 8
            Me.UltraGridLijstSnelheidsovertredingenIntern.Text = "UltraGrid1"
            '
            '_dataSnelheidsOvertredingenIntern
            '
            Me._dataSnelheidsOvertredingenIntern.DataSetName = "TDSSnelheidsOvertredingen"
            Me._dataSnelheidsOvertredingenIntern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraTabPageControl2
            '
            Me.UltraTabPageControl2.Controls.Add(Me.UltraGridLijstSnelheidsovertredingenExtern)
            Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
            Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
            Me.UltraTabPageControl2.Size = New System.Drawing.Size(1011, 539)
            '
            'UltraGridLijstSnelheidsovertredingenExtern
            '
            Me.UltraGridLijstSnelheidsovertredingenExtern.DataMember = "Lijst_Snelheidsovertredingen"
            Me.UltraGridLijstSnelheidsovertredingenExtern.DataSource = Me._dataSnelheidsOvertredingenExtern
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Appearance = Appearance5
            UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn30.Header.VisiblePosition = 0
            UltraGridColumn30.Hidden = True
            UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn31.Header.VisiblePosition = 6
            UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn32.Header.VisiblePosition = 7
            UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn33.Header.Caption = "Overtreder"
            UltraGridColumn33.Header.VisiblePosition = 5
            UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn34.Header.VisiblePosition = 4
            UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn35.Header.VisiblePosition = 1
            UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn36.Header.VisiblePosition = 17
            UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn37.Header.VisiblePosition = 18
            UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn38.Header.VisiblePosition = 8
            UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn39.Header.Caption = "Toegelaten"
            UltraGridColumn39.Header.VisiblePosition = 11
            UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn40.Header.Caption = "Geregistreerd"
            UltraGridColumn40.Header.VisiblePosition = 12
            UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn41.Header.VisiblePosition = 9
            UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn42.Header.VisiblePosition = 10
            UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn43.Header.VisiblePosition = 3
            UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn44.Header.VisiblePosition = 2
            UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn45.Header.VisiblePosition = 13
            UltraGridColumn45.Hidden = True
            UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn46.Header.VisiblePosition = 14
            UltraGridColumn46.Hidden = True
            UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn47.Header.VisiblePosition = 15
            UltraGridColumn47.Hidden = True
            UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn48.Header.VisiblePosition = 16
            UltraGridColumn48.Hidden = True
            UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn49.Header.Caption = "20+"
            UltraGridColumn49.Header.VisiblePosition = 19
            UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn50.Header.VisiblePosition = 20
            UltraGridColumn50.Hidden = True
            UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn51.Header.Caption = "Directie"
            UltraGridColumn51.Header.VisiblePosition = 21
            UltraGridColumn51.Hidden = True
            UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn52.Header.Caption = "Afdeling"
            UltraGridColumn52.Header.VisiblePosition = 22
            UltraGridColumn52.Hidden = True
            UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn53.Header.Caption = "Sectie"
            UltraGridColumn53.Header.VisiblePosition = 23
            UltraGridColumn53.Hidden = True
            UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn54.Format = "dd-MM-yyy HH:mm"
            UltraGridColumn54.Header.Caption = "Datum Brief"
            UltraGridColumn54.Header.VisiblePosition = 24
            UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn55.Header.Caption = "Soort Sanctie"
            UltraGridColumn55.Header.VisiblePosition = 25
            UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn56.Header.Caption = "Taal"
            UltraGridColumn56.Header.VisiblePosition = 26
            UltraGridColumn56.Width = 50
            UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn57.Header.Caption = "Externe Firma"
            UltraGridColumn57.Header.VisiblePosition = 27
            UltraGridColumn58.Header.VisiblePosition = 28
            UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
            SummarySettings2.DisplayFormat = "Aantal = {0}"
            SummarySettings2.GroupBySummaryValueAppearance = Appearance3
            UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings2})
            UltraGridBand2.SummaryFooterCaption = ""
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance7.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.GroupByBox.Appearance = Appearance7
            Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance9.BackColor2 = System.Drawing.SystemColors.Control
            Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.MaxRowScrollRegions = 1
            Appearance10.BackColor = System.Drawing.SystemColors.Window
            Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.ActiveCellAppearance = Appearance10
            Appearance11.BackColor = System.Drawing.SystemColors.Highlight
            Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.ActiveRowAppearance = Appearance11
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.CardAreaAppearance = Appearance12
            Appearance13.BorderColor = System.Drawing.Color.Silver
            Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.CellAppearance = Appearance13
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance18.BackColor = System.Drawing.SystemColors.Control
            Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance18.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.GroupByRowAppearance = Appearance18
            Appearance41.TextHAlignAsString = "Left"
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.HeaderAppearance = Appearance41
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance42.BackColor = System.Drawing.SystemColors.Window
            Appearance42.BorderColor = System.Drawing.Color.Silver
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.RowAppearance = Appearance42
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance43.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.TemplateAddRowAppearance = Appearance43
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridLijstSnelheidsovertredingenExtern.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UltraGridLijstSnelheidsovertredingenExtern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridLijstSnelheidsovertredingenExtern.Location = New System.Drawing.Point(0, 0)
            Me.UltraGridLijstSnelheidsovertredingenExtern.Name = "UltraGridLijstSnelheidsovertredingenExtern"
            Me.UltraGridLijstSnelheidsovertredingenExtern.Size = New System.Drawing.Size(1011, 539)
            Me.UltraGridLijstSnelheidsovertredingenExtern.TabIndex = 9
            Me.UltraGridLijstSnelheidsovertredingenExtern.Text = "UltraGrid1"
            '
            '_dataSnelheidsOvertredingenExtern
            '
            Me._dataSnelheidsOvertredingenExtern.DataSetName = "TDSSnelheidsOvertredingen"
            Me._dataSnelheidsOvertredingenExtern.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraTabPageControl3
            '
            Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid2)
            Me.UltraTabPageControl3.Controls.Add(Me.Label2)
            Me.UltraTabPageControl3.Controls.Add(Me.Label1)
            Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid1)
            Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
            Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
            Me.UltraTabPageControl3.Size = New System.Drawing.Size(1011, 539)
            '
            'UltraGrid2
            '
            Me.UltraGrid2.DataSource = Me._dataBewakingSnelheidSanctionMatrix
            Appearance57.BackColor = System.Drawing.SystemColors.Window
            Appearance57.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid2.DisplayLayout.Appearance = Appearance57
            UltraGridColumn88.Header.Caption = "Matrix ID"
            UltraGridColumn88.Header.VisiblePosition = 0
            UltraGridColumn88.Width = 40
            UltraGridColumn89.Header.Caption = "Matrix omschr"
            UltraGridColumn89.Header.VisiblePosition = 1
            UltraGridColumn89.Width = 94
            UltraGridColumn90.Header.VisiblePosition = 2
            UltraGridColumn90.Width = 49
            UltraGridColumn91.Header.Caption = "Snelh van"
            UltraGridColumn91.Header.VisiblePosition = 3
            UltraGridColumn91.Width = 66
            UltraGridColumn92.Header.Caption = "Snelh tot"
            UltraGridColumn92.Header.VisiblePosition = 4
            UltraGridColumn92.Width = 61
            UltraGridColumn93.Header.Caption = "Auto/moto"
            UltraGridColumn93.Header.VisiblePosition = 5
            UltraGridColumn93.Width = 67
            UltraGridColumn94.Header.Caption = "Vrachtwagen"
            UltraGridColumn94.Header.VisiblePosition = 6
            UltraGridColumn94.Width = 79
            UltraGridColumn95.Header.Caption = "Sanctienr 1ste inbr"
            UltraGridColumn95.Header.VisiblePosition = 7
            UltraGridColumn96.Header.Caption = "Sanctienr 2de inbr (24 mnd)"
            UltraGridColumn96.Header.VisiblePosition = 8
            UltraGridColumn96.Width = 152
            UltraGridColumn97.Header.Caption = "Sanctienr 1ste inbr (24 mnd)"
            UltraGridColumn97.Header.VisiblePosition = 9
            UltraGridColumn97.Width = 158
            UltraGridColumn98.Header.Caption = "Opmerking"
            UltraGridColumn98.Header.VisiblePosition = 10
            UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98})
            SummarySettings3.DisplayFormat = "Aantal = {0}"
            SummarySettings3.GroupBySummaryValueAppearance = Appearance6
            UltraGridBand3.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings3})
            UltraGridBand3.SummaryFooterCaption = ""
            Me.UltraGrid2.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
            Me.UltraGrid2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance59.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance59.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid2.DisplayLayout.GroupByBox.Appearance = Appearance59
            Appearance60.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid2.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance60
            Me.UltraGrid2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance61.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance61.BackColor2 = System.Drawing.SystemColors.Control
            Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid2.DisplayLayout.GroupByBox.PromptAppearance = Appearance61
            Me.UltraGrid2.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid2.DisplayLayout.MaxRowScrollRegions = 1
            Appearance62.BackColor = System.Drawing.SystemColors.Window
            Appearance62.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid2.DisplayLayout.Override.ActiveCellAppearance = Appearance62
            Appearance63.BackColor = System.Drawing.SystemColors.Highlight
            Appearance63.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid2.DisplayLayout.Override.ActiveRowAppearance = Appearance63
            Me.UltraGrid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid2.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance64.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid2.DisplayLayout.Override.CardAreaAppearance = Appearance64
            Appearance65.BorderColor = System.Drawing.Color.Silver
            Appearance65.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid2.DisplayLayout.Override.CellAppearance = Appearance65
            Me.UltraGrid2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid2.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid2.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance66.BackColor = System.Drawing.SystemColors.Control
            Appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance66.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance66.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid2.DisplayLayout.Override.GroupByRowAppearance = Appearance66
            Appearance67.TextHAlignAsString = "Left"
            Me.UltraGrid2.DisplayLayout.Override.HeaderAppearance = Appearance67
            Me.UltraGrid2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance68.BackColor = System.Drawing.SystemColors.Window
            Appearance68.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid2.DisplayLayout.Override.RowAppearance = Appearance68
            Me.UltraGrid2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid2.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance69.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid2.DisplayLayout.Override.TemplateAddRowAppearance = Appearance69
            Me.UltraGrid2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid2.Location = New System.Drawing.Point(5, 28)
            Me.UltraGrid2.Name = "UltraGrid2"
            Me.UltraGrid2.Size = New System.Drawing.Size(997, 198)
            Me.UltraGrid2.TabIndex = 13
            Me.UltraGrid2.Text = "UltraGrid2"
            '
            '_dataBewakingSnelheidSanctionMatrix
            '
            Me._dataBewakingSnelheidSanctionMatrix.DataSetName = "TDSBewakingSnelheidSanctionMatrix"
            Me._dataBewakingSnelheidSanctionMatrix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(5, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(73, 13)
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "Sanctiematrix:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 229)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 13)
            Me.Label1.TabIndex = 11
            Me.Label1.Text = "Sancties:"
            '
            'UltraGrid1
            '
            Me.UltraGrid1.DataSource = Me._dataBewakingSnelheidSanction
            Appearance44.BackColor = System.Drawing.SystemColors.Window
            Appearance44.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance44
            UltraGridColumn99.Header.Caption = "Sanctienr"
            UltraGridColumn99.Header.VisiblePosition = 0
            UltraGridColumn99.Width = 43
            UltraGridColumn100.Header.Caption = "Sanctie omschr"
            UltraGridColumn100.Header.VisiblePosition = 1
            UltraGridColumn100.Width = 155
            UltraGridColumn101.Header.Caption = "Sanctie NL"
            UltraGridColumn101.Header.VisiblePosition = 2
            UltraGridColumn101.Width = 185
            UltraGridColumn102.Header.Caption = "Sanctie FR"
            UltraGridColumn102.Header.VisiblePosition = 3
            UltraGridColumn102.Width = 214
            UltraGridColumn103.Header.Caption = "Sanctie EN"
            UltraGridColumn103.Header.VisiblePosition = 4
            UltraGridColumn103.Width = 208
            UltraGridColumn104.Header.Caption = "Sanctie DE"
            UltraGridColumn104.Header.VisiblePosition = 5
            UltraGridColumn104.Width = 160
            UltraGridColumn105.Header.VisiblePosition = 6
            UltraGridColumn106.Header.VisiblePosition = 7
            UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106})
            SummarySettings4.DisplayFormat = "Aantal = {0}"
            SummarySettings4.GroupBySummaryValueAppearance = Appearance17
            UltraGridBand4.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings4})
            UltraGridBand4.SummaryFooterCaption = ""
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance46.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance46.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance46
            Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance47
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance48.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance48.BackColor2 = System.Drawing.SystemColors.Control
            Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance48.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance48
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance49.BackColor = System.Drawing.SystemColors.Window
            Appearance49.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance49
            Appearance50.BackColor = System.Drawing.SystemColors.Highlight
            Appearance50.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance50
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance51.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance51
            Appearance52.BorderColor = System.Drawing.Color.Silver
            Appearance52.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance52
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance53.BackColor = System.Drawing.SystemColors.Control
            Appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance53.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance53.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance53
            Appearance54.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance54
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance55.BackColor = System.Drawing.SystemColors.Window
            Appearance55.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance55
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance56.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance56
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(5, 250)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(997, 265)
            Me.UltraGrid1.TabIndex = 10
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            '_dataBewakingSnelheidSanction
            '
            Me._dataBewakingSnelheidSanction.DataSetName = "TDSBewakingSnelheidSanction"
            Me._dataBewakingSnelheidSanction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.UltraButtonOpenVerslag)
            Me.GroupBox1.Controls.Add(Me.UltraButtonAfdrukken)
            Me.GroupBox1.Controls.Add(Me.UltraButtonSluiten)
            Me.GroupBox1.Location = New System.Drawing.Point(3, 619)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1021, 40)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            '
            'UltraButtonOpenVerslag
            '
            Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
            Me.UltraButtonOpenVerslag.Appearance = Appearance1
            Me.UltraButtonOpenVerslag.Location = New System.Drawing.Point(124, 11)
            Me.UltraButtonOpenVerslag.Name = "UltraButtonOpenVerslag"
            Me.UltraButtonOpenVerslag.Size = New System.Drawing.Size(110, 23)
            Me.UltraButtonOpenVerslag.TabIndex = 9
            Me.UltraButtonOpenVerslag.Text = "Open Verslag"
            '
            'UltraButtonAfdrukken
            '
            Me.UltraButtonAfdrukken.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
            Me.UltraButtonAfdrukken.Appearance = Appearance14
            Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
            Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(8, 11)
            Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
            Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(110, 23)
            Me.UltraButtonAfdrukken.TabIndex = 8
            Me.UltraButtonAfdrukken.Text = "Afdrukken"
            '
            'UltraButtonSluiten
            '
            Me.UltraButtonSluiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
            Me.UltraButtonSluiten.Appearance = Appearance15
            Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
            Me.UltraButtonSluiten.Location = New System.Drawing.Point(929, 11)
            Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
            Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
            Me.UltraButtonSluiten.TabIndex = 7
            Me.UltraButtonSluiten.Text = "Sluiten"
            '
            'UltraTabControlForGrids
            '
            Me.UltraTabControlForGrids.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None
            Me.UltraTabControlForGrids.Controls.Add(Me.UltraTabSharedControlsPage1)
            Me.UltraTabControlForGrids.Controls.Add(Me.UltraTabPageControl1)
            Me.UltraTabControlForGrids.Controls.Add(Me.UltraTabPageControl2)
            Me.UltraTabControlForGrids.Controls.Add(Me.UltraTabPageControl3)
            Me.UltraTabControlForGrids.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UltraTabControlForGrids.Location = New System.Drawing.Point(3, 16)
            Me.UltraTabControlForGrids.Name = "UltraTabControlForGrids"
            Me.UltraTabControlForGrids.SharedControlsPage = Me.UltraTabSharedControlsPage1
            Me.UltraTabControlForGrids.Size = New System.Drawing.Size(1015, 565)
            Me.UltraTabControlForGrids.TabIndex = 10
            Me.UltraTabControlForGrids.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
            UltraTab1.TabPage = Me.UltraTabPageControl1
            UltraTab1.Text = "Intern"
            UltraTab2.TabPage = Me.UltraTabPageControl2
            UltraTab2.Text = "Extern"
            UltraTab3.TabPage = Me.UltraTabPageControl3
            UltraTab3.Text = "Tabel sancties (extern)"
            Me.UltraTabControlForGrids.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
            Me.UltraTabControlForGrids.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
            Me.UltraTabControlForGrids.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Standard
            '
            'UltraTabSharedControlsPage1
            '
            Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
            Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
            Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1011, 539)
            '
            'UltraGroupBoxSnelheidsovertredingen
            '
            Me.UltraGroupBoxSnelheidsovertredingen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGroupBoxSnelheidsovertredingen.Controls.Add(Me.UltraTabControlForGrids)
            Me.UltraGroupBoxSnelheidsovertredingen.Location = New System.Drawing.Point(3, 29)
            Me.UltraGroupBoxSnelheidsovertredingen.Name = "UltraGroupBoxSnelheidsovertredingen"
            Me.UltraGroupBoxSnelheidsovertredingen.Size = New System.Drawing.Size(1021, 584)
            Me.UltraGroupBoxSnelheidsovertredingen.TabIndex = 11
            Me.UltraGroupBoxSnelheidsovertredingen.Text = "Snelheidsovertredingen"
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCopy, Me.ToolStripButtonRefresh})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(1024, 25)
            Me.ToolStrip1.TabIndex = 12
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButtonCopy
            '
            Me.ToolStripButtonCopy.Image = CType(resources.GetObject("ToolStripButtonCopy.Image"), System.Drawing.Image)
            Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
            Me.ToolStripButtonCopy.Size = New System.Drawing.Size(63, 22)
            Me.ToolStripButtonCopy.Text = "Kopieer"
            Me.ToolStripButtonCopy.ToolTipText = "Kopieer data naar clipboard"
            '
            'ToolStripButtonRefresh
            '
            Me.ToolStripButtonRefresh.Image = CType(resources.GetObject("ToolStripButtonRefresh.Image"), System.Drawing.Image)
            Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
            Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(83, 22)
            Me.ToolStripButtonRefresh.Text = "Vernieuwen"
            Me.ToolStripButtonRefresh.ToolTipText = "Data in grid vernieuwen"
            '
            'FormBewakingSnelheidsovertredingen
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1024, 661)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.UltraGroupBoxSnelheidsovertredingen)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "FormBewakingSnelheidsovertredingen"
            Me.Text = "Snelheidsovertredingen"
            Me.UltraTabPageControl1.ResumeLayout(False)
            CType(Me.UltraGridLijstSnelheidsovertredingenIntern, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataSnelheidsOvertredingenIntern, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraTabPageControl2.ResumeLayout(False)
            CType(Me.UltraGridLijstSnelheidsovertredingenExtern, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataSnelheidsOvertredingenExtern, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraTabPageControl3.ResumeLayout(False)
            Me.UltraTabPageControl3.PerformLayout()
            CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBewakingSnelheidSanctionMatrix, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBewakingSnelheidSanction, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.UltraTabControlForGrids, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraTabControlForGrids.ResumeLayout(False)
            CType(Me.UltraGroupBoxSnelheidsovertredingen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraGroupBoxSnelheidsovertredingen.ResumeLayout(False)
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
        Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
        Friend WithEvents UltraGridLijstSnelheidsovertredingenIntern As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataSnelheidsOvertredingenIntern As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSSnelheidsOvertredingen
        Friend WithEvents UltraTabControlForGrids As Infragistics.Win.UltraWinTabControl.UltraTabControl
        Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Friend WithEvents UltraGridLijstSnelheidsovertredingenExtern As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents UltraGroupBoxSnelheidsovertredingen As Infragistics.Win.Misc.UltraGroupBox
        Friend WithEvents _dataSnelheidsOvertredingenExtern As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSSnelheidsOvertredingen
        Friend WithEvents UltraButtonOpenVerslag As Infragistics.Win.Misc.UltraButton
        Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataBewakingSnelheidSanctionMatrix As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanctionMatrix
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents _dataBewakingSnelheidSanction As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingSnelheidSanction
    End Class
End Namespace