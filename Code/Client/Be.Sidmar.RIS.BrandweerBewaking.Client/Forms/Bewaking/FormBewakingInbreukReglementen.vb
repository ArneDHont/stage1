Option Explicit On
Option Infer On
Option Strict On

Imports System.Windows.Forms
Imports System.ComponentModel
Imports ADF
Imports Be.Sidmar.RIS.BrandweerBewaking.Component
Imports System.Drawing
Imports System.Globalization
Imports ADF.ExceptionHandling
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinMaskedEdit
Imports Infragistics.Win
Imports System.Reflection
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt
Imports System.IO
Imports Appearance = Infragistics.Win.Appearance
Imports StatusBar = ADF.Windows.Forms.UserControls.StatusBar

Imports Microsoft.Office.Interop 'mails versturen voor IKP - naco - 30/11/2012
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class FormBewakingInbreukReglementen
    Inherits Form

#Region "Variabelen"

    Private _idRegistratie As Integer = -1
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
    Private _controller As ControllerGetData
    Private _myProxy As BBWServiceManagementServicesProxy
    Friend WithEvents GroupBoxVerzending As GroupBox
    Friend WithEvents LabelBevestigdDoorLeverancier As Label
    Friend WithEvents UltraDateTimeEditorBevestigdDoorLeverancier As UltraDateTimeEditor
    Friend WithEvents UltraComboFirma As UltraCombo
    Friend WithEvents LabelLeverancier As Label
    Friend WithEvents cbxVerslagnrCHIP As CheckBox
    Friend WithEvents LabelOpmerkingNaarCHIP As Label
    Friend WithEvents UltraDateTimeEditorNaarCHIP As UltraDateTimeEditor
    Friend WithEvents ButtonNaarCHIP As Button
    Friend WithEvents TextBoxNaarCHIP As TextBox
    Friend WithEvents LabelNaarChip As Label
    Friend WithEvents ButtonTerugZenden As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents UltraDateTimeEditorBestemmelingen As UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorGoedkeuring As UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorVerzending As UltraDateTimeEditor
    Friend WithEvents ButtonVerzendingBest As Button
    Friend WithEvents ButtonGoedkeuring As Button
    Friend WithEvents ButtonVerzendingBBW As Button
    Friend WithEvents TextBoxVerzendingBestemmelingen As TextBox
    Friend WithEvents TextBoxGoedkeuring As TextBox
    Friend WithEvents TextBoxVerzending As TextBox
    Friend WithEvents LabelVerzendingBest As Label
    Friend WithEvents LabelGoedkeuring As Label
    Friend WithEvents LabelVerzending As Label
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonInfoChip As System.Windows.Forms.Button
    Friend WithEvents _dataFirmaHRM As TDSFirmaHRM

#End Region

    ' GMAE - 2013-06-20: changed the colour of the labels from 'InactiveCaptionText' into 'Control'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initializeMailInfo()

        'Add any initialization after the InitializeComponent() call
        bindAndSetBEWPersoneel()
        bindUltraOptionSets()
        bindDdlAfdelingen()
        setLabelsVerplicht()

        _myProxy = New BBWServiceManagementServicesProxy
    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()

        _idRegistratie = IdReg

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initializeMailInfo()

        'Add any initialization after the InitializeComponent() call
        bindAndSetBEWPersoneel()
        bindUltraOptionSets()
        bindDdlAfdelingen()
        setLabelsVerplicht()
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
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBoxHoofding As GroupBox
    Friend WithEvents TextBoxPlaats As TextBox
    Friend WithEvents LabelPlaats As Label
    Friend WithEvents LabelUur As Label
    Friend WithEvents LabelDatum As Label
    Friend WithEvents TextBoxVerslagnummer As TextBox
    Friend WithEvents LabelVerslagnr As Label
    Friend WithEvents LabelTitel As Label
    Friend WithEvents GroupBoxAlgemeneGegevens As GroupBox
    Friend WithEvents GroupBoxVoertuig As GroupBox
    Friend WithEvents LabelChassisnummer As Label
    Friend WithEvents LabelNummerplaat As Label
    Friend WithEvents LabelMerk As Label
    Friend WithEvents LabelEigenaar As Label
    Friend WithEvents LabelAard As Label
    Friend WithEvents GroupBoxOverige As GroupBox
    Friend WithEvents GroupBoxInbreuk As GroupBox
    Friend WithEvents TabControlInbreuken As TabControl
    Friend WithEvents TabPageInbreuk As TabPage
    Friend WithEvents TabPageVoorbijeInbreuken As TabPage
    Friend WithEvents _dataBEWPersoneel As TDSBWPersoneel
    Friend WithEvents _dataRegInbreukRegl As TDSRegInbreukRegl
    Friend WithEvents UltraDateTimeEditorDatum As UltraDateTimeEditor
    Friend WithEvents UltraButtonAfdrukken As UltraButton
    Friend WithEvents UltraButtonAnnuleer As UltraButton
    Friend WithEvents UltraButtonOpslaan As UltraButton
    Friend WithEvents UltraButtonOverzicht As UltraButton
    Friend WithEvents UltraButtonSluiten As UltraButton
    Friend WithEvents UltraMaskedEditUur As UltraMaskedEdit
    Friend WithEvents _statusBar As StatusBar
    Friend WithEvents LabelVolgnr As Label
    Friend WithEvents UltraOptionSetBenadeelde As UltraOptionSet
    Friend WithEvents LabelBenadeelde As Label
    Friend WithEvents _dataBewakingDup As TDSBewakingDup
    Friend WithEvents _dataAfdelingen As TDSAfdelingen
    Friend WithEvents ButtonKiesVoertuig As Button
    Friend WithEvents TextBoxVoertuigId As TextBox
    Friend WithEvents _dataConfiguratie As TDSConfiguratie
    Friend WithEvents _dataIndividuen As TDSIndividuen
    Friend WithEvents GroupBoxInbreukReglementen As GroupBox
    Friend WithEvents UltraGridHuidigeInbreuken As UltraGrid
    Friend WithEvents UltraGridVastgesteldeInbreuken As UltraGrid
    Friend WithEvents _dataVastgesteldeInbreuken As TDSVastgesteldeInbreuken
    Friend WithEvents ButtonDeleteBijlage As Button
    Friend WithEvents GroupBoxOpmerkingen As GroupBox
    Friend WithEvents GroupBoxOvertreder As GroupBox
    Friend WithEvents TextBoxFirmaId As TextBox
    Friend WithEvents ButtonKiesFirma As Button
    Friend WithEvents LabelFirma As Label
    Friend WithEvents ButtonKiesPersoonOvertreder As Button
    Friend WithEvents ButtonNewInbreuk As Button
    Friend WithEvents LabelStamnrEigenaar As Label
    Friend WithEvents LabelNaamEigenaar As Label
    Friend WithEvents LabelMerkVoertuig As Label
    Friend WithEvents LabelAardVoertuig As Label
    Friend WithEvents LabelNummerplaatVoertuig As Label
    Friend WithEvents LabelChassisnummerVoertuig As Label
    Friend WithEvents UltraMaskedEditStamnrOvertreder As UltraMaskedEdit
    Friend WithEvents LabelNaamOvertreder As Label
    Friend WithEvents LabelAdresOvertreder As Label
    Friend WithEvents LabelFirmaNaam As Label
    Friend WithEvents LabelOvertreder As Label
    Friend WithEvents UserControlGeneralFunctionsInbreukRegl As UserControlGeneralFunctions
    Friend WithEvents _dataOvertrederType As TDSInbrIndTy
    Friend WithEvents UltraComboOvertrederType As UltraCombo
    Friend WithEvents LabelOvertrederType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelAfdelingOvertreder As Label
    Friend WithEvents TextBoxVerklaring As TextBox
    Friend WithEvents TextBoxOpmerkingen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxKorteOms As TextBox
    Friend WithEvents Label7 As Label

    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingInbreukReglementen))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRVA", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INBRVA")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INBR")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SNL_OK")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SNL_REG")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PBH_NOK_SNL_DT_VAN")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PBH_NOK_SNL_DT_TOT")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PBH_DT_OVK")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PBH_TMS_PRINT")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SODIE_CNT_ID")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatePrintLetterExt")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Language")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Recidive")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KindOfSanction")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFirm")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remark")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_ART_INBR")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRVA", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INBRVA")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INBR")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SNL_OK")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SNL_REG")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_ART_INBR")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INC")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_REG_JR_BPL")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_OPS_REG")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatePrintLetterExt")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Language")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Recidive")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KindOfSanction")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionID")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFirm")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Remark")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionDuration")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SanctionPeriod")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastSanctionDoubledYN")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_VLG_REG", 0)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRINDTY", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INBR_IND_TY")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_INBR_IND_TY")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Firma", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanaam")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanummer")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parent")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parentnaam")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBoxHoofding = New System.Windows.Forms.GroupBox()
        Me.TextBoxKorteOms = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UltraMaskedEditUur = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.TextBoxPlaats = New System.Windows.Forms.TextBox()
        Me.LabelPlaats = New System.Windows.Forms.Label()
        Me.LabelUur = New System.Windows.Forms.Label()
        Me.LabelDatum = New System.Windows.Forms.Label()
        Me.TextBoxVerslagnummer = New System.Windows.Forms.TextBox()
        Me.LabelVerslagnr = New System.Windows.Forms.Label()
        Me.LabelTitel = New System.Windows.Forms.Label()
        Me.LabelVolgnr = New System.Windows.Forms.Label()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me.UltraOptionSetBenadeelde = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataBewakingDup = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingDup()
        Me.LabelBenadeelde = New System.Windows.Forms.Label()
        Me.GroupBoxVoertuig = New System.Windows.Forms.GroupBox()
        Me.LabelChassisnummerVoertuig = New System.Windows.Forms.Label()
        Me.LabelNummerplaatVoertuig = New System.Windows.Forms.Label()
        Me.LabelAardVoertuig = New System.Windows.Forms.Label()
        Me.LabelMerkVoertuig = New System.Windows.Forms.Label()
        Me.LabelNaamEigenaar = New System.Windows.Forms.Label()
        Me.LabelStamnrEigenaar = New System.Windows.Forms.Label()
        Me.TextBoxVoertuigId = New System.Windows.Forms.TextBox()
        Me.LabelAard = New System.Windows.Forms.Label()
        Me.LabelChassisnummer = New System.Windows.Forms.Label()
        Me.LabelNummerplaat = New System.Windows.Forms.Label()
        Me.LabelMerk = New System.Windows.Forms.Label()
        Me.LabelEigenaar = New System.Windows.Forms.Label()
        Me.ButtonKiesVoertuig = New System.Windows.Forms.Button()
        Me.GroupBoxInbreuk = New System.Windows.Forms.GroupBox()
        Me.TabControlInbreuken = New System.Windows.Forms.TabControl()
        Me.TabPageInbreuk = New System.Windows.Forms.TabPage()
        Me.ButtonNewInbreuk = New System.Windows.Forms.Button()
        Me.UltraGridHuidigeInbreuken = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataRegInbreukRegl = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegInbreukRegl()
        Me.ButtonDeleteBijlage = New System.Windows.Forms.Button()
        Me.TabPageVoorbijeInbreuken = New System.Windows.Forms.TabPage()
        Me.UltraGridVastgesteldeInbreuken = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataVastgesteldeInbreuken = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVastgesteldeInbreuken()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsInbreukRegl = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me.GroupBoxInbreukReglementen = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me.GroupBoxOpmerkingen = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxOpmerkingen = New System.Windows.Forms.TextBox()
        Me.TextBoxVerklaring = New System.Windows.Forms.TextBox()
        Me.GroupBoxOvertreder = New System.Windows.Forms.GroupBox()
        Me.LabelAfdelingOvertreder = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelOvertrederType = New System.Windows.Forms.Label()
        Me.UltraComboOvertrederType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataOvertrederType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrIndTy()
        Me.LabelFirmaNaam = New System.Windows.Forms.Label()
        Me.LabelAdresOvertreder = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrOvertreder = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxFirmaId = New System.Windows.Forms.TextBox()
        Me.ButtonKiesFirma = New System.Windows.Forms.Button()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.LabelOvertreder = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonOvertreder = New System.Windows.Forms.Button()
        Me.LabelNaamOvertreder = New System.Windows.Forms.Label()
        Me.GroupBoxVerzending = New System.Windows.Forms.GroupBox()
        Me.ButtonInfoChip = New System.Windows.Forms.Button()
        Me.LabelBevestigdDoorLeverancier = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorBevestigdDoorLeverancier = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraComboFirma = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataFirmaHRM = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM()
        Me.LabelLeverancier = New System.Windows.Forms.Label()
        Me.cbxVerslagnrCHIP = New System.Windows.Forms.CheckBox()
        Me.LabelOpmerkingNaarCHIP = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorNaarCHIP = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ButtonNaarCHIP = New System.Windows.Forms.Button()
        Me.TextBoxNaarCHIP = New System.Windows.Forms.TextBox()
        Me.LabelNaarChip = New System.Windows.Forms.Label()
        Me.ButtonTerugZenden = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorBestemmelingen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateTimeEditorGoedkeuring = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateTimeEditorVerzending = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ButtonVerzendingBest = New System.Windows.Forms.Button()
        Me.ButtonGoedkeuring = New System.Windows.Forms.Button()
        Me.ButtonVerzendingBBW = New System.Windows.Forms.Button()
        Me.TextBoxVerzendingBestemmelingen = New System.Windows.Forms.TextBox()
        Me.TextBoxGoedkeuring = New System.Windows.Forms.TextBox()
        Me.TextBoxVerzending = New System.Windows.Forms.TextBox()
        Me.LabelVerzendingBest = New System.Windows.Forms.Label()
        Me.LabelGoedkeuring = New System.Windows.Forms.Label()
        Me.LabelVerzending = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVoertuig.SuspendLayout()
        Me.GroupBoxInbreuk.SuspendLayout()
        Me.TabControlInbreuken.SuspendLayout()
        Me.TabPageInbreuk.SuspendLayout()
        CType(Me.UltraGridHuidigeInbreuken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegInbreukRegl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVoorbijeInbreuken.SuspendLayout()
        CType(Me.UltraGridVastgesteldeInbreuken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVastgesteldeInbreuken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOverige.SuspendLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInbreukReglementen.SuspendLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpmerkingen.SuspendLayout()
        Me.GroupBoxOvertreder.SuspendLayout()
        CType(Me.UltraComboOvertrederType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOvertrederType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVerzending.SuspendLayout()
        CType(Me.UltraDateTimeEditorBevestigdDoorLeverancier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorNaarCHIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxHoofding
        '
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxKorteOms)
        Me.GroupBoxHoofding.Controls.Add(Me.Label7)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraMaskedEditUur)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraDateTimeEditorDatum)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelUur)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelDatum)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxVerslagnummer)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVerslagnr)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelTitel)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVolgnr)
        Me.GroupBoxHoofding.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxHoofding.Name = "GroupBoxHoofding"
        Me.GroupBoxHoofding.Size = New System.Drawing.Size(1008, 56)
        Me.GroupBoxHoofding.TabIndex = 0
        Me.GroupBoxHoofding.TabStop = False
        Me.GroupBoxHoofding.Text = "Hoofding"
        '
        'TextBoxKorteOms
        '
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(672, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(328, 20)
        Me.TextBoxKorteOms.TabIndex = 1011
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(592, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1012
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(504, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.NonAutoSizeHeight = 20
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 6
        Me.UltraMaskedEditUur.Text = ":"
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(504, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 4
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(672, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(328, 20)
        Me.TextBoxPlaats.TabIndex = 8
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(624, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 7
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(464, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 5
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(456, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 3
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(376, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.AutoSize = True
        Me.LabelVerslagnr.Location = New System.Drawing.Point(312, 24)
        Me.LabelVerslagnr.Name = "LabelVerslagnr"
        Me.LabelVerslagnr.Size = New System.Drawing.Size(60, 13)
        Me.LabelVerslagnr.TabIndex = 1
        Me.LabelVerslagnr.Text = "Verslag nr.:"
        Me.LabelVerslagnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitel
        '
        Me.LabelTitel.AutoSize = True
        Me.LabelTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitel.Location = New System.Drawing.Point(8, 16)
        Me.LabelTitel.Name = "LabelTitel"
        Me.LabelTitel.Size = New System.Drawing.Size(300, 29)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Inbreuk op Reglementen"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(56, 48)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 16)
        Me.LabelVolgnr.TabIndex = 1004
        Me.LabelVolgnr.Visible = False
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraOptionSetBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 56)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(528, 40)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 1
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Algemene gegevens"
        Me.GroupBoxAlgemeneGegevens.Visible = False
        '
        'UltraOptionSetBenadeelde
        '
        Me.UltraOptionSetBenadeelde.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetBenadeelde.DataMember = "BBBEWDUP"
        Me.UltraOptionSetBenadeelde.DataSource = Me._dataBewakingDup
        Me.UltraOptionSetBenadeelde.DisplayMember = "SCF_BEW_DUP"
        Me.UltraOptionSetBenadeelde.Location = New System.Drawing.Point(80, 16)
        Me.UltraOptionSetBenadeelde.Name = "UltraOptionSetBenadeelde"
        Me.UltraOptionSetBenadeelde.Size = New System.Drawing.Size(440, 16)
        Me.UltraOptionSetBenadeelde.TabIndex = 1
        Me.UltraOptionSetBenadeelde.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetBenadeelde.ValueMember = "ID_BEW_DUP"
        '
        '_dataBewakingDup
        '
        Me._dataBewakingDup.DataSetName = "TDSBewakingDup"
        Me._dataBewakingDup.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBewakingDup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelBenadeelde
        '
        Me.LabelBenadeelde.AutoSize = True
        Me.LabelBenadeelde.Location = New System.Drawing.Point(8, 16)
        Me.LabelBenadeelde.Name = "LabelBenadeelde"
        Me.LabelBenadeelde.Size = New System.Drawing.Size(67, 13)
        Me.LabelBenadeelde.TabIndex = 0
        Me.LabelBenadeelde.Text = "Benadeelde:"
        Me.LabelBenadeelde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxVoertuig
        '
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelChassisnummerVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNummerplaatVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelAardVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelMerkVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNaamEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelStamnrEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.TextBoxVoertuigId)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelAard)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelChassisnummer)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNummerplaat)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelMerk)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.ButtonKiesVoertuig)
        Me.GroupBoxVoertuig.Location = New System.Drawing.Point(0, 55)
        Me.GroupBoxVoertuig.Name = "GroupBoxVoertuig"
        Me.GroupBoxVoertuig.Size = New System.Drawing.Size(528, 88)
        Me.GroupBoxVoertuig.TabIndex = 2
        Me.GroupBoxVoertuig.TabStop = False
        Me.GroupBoxVoertuig.Text = "Voertuig"
        '
        'LabelChassisnummerVoertuig
        '
        Me.LabelChassisnummerVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelChassisnummerVoertuig.Location = New System.Drawing.Point(376, 64)
        Me.LabelChassisnummerVoertuig.Name = "LabelChassisnummerVoertuig"
        Me.LabelChassisnummerVoertuig.Size = New System.Drawing.Size(144, 20)
        Me.LabelChassisnummerVoertuig.TabIndex = 11
        Me.LabelChassisnummerVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaatVoertuig
        '
        Me.LabelNummerplaatVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNummerplaatVoertuig.Location = New System.Drawing.Point(376, 40)
        Me.LabelNummerplaatVoertuig.Name = "LabelNummerplaatVoertuig"
        Me.LabelNummerplaatVoertuig.Size = New System.Drawing.Size(144, 20)
        Me.LabelNummerplaatVoertuig.TabIndex = 9
        Me.LabelNummerplaatVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAardVoertuig
        '
        Me.LabelAardVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAardVoertuig.Location = New System.Drawing.Point(88, 64)
        Me.LabelAardVoertuig.Name = "LabelAardVoertuig"
        Me.LabelAardVoertuig.Size = New System.Drawing.Size(168, 20)
        Me.LabelAardVoertuig.TabIndex = 7
        Me.LabelAardVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerkVoertuig
        '
        Me.LabelMerkVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMerkVoertuig.Location = New System.Drawing.Point(88, 40)
        Me.LabelMerkVoertuig.Name = "LabelMerkVoertuig"
        Me.LabelMerkVoertuig.Size = New System.Drawing.Size(168, 20)
        Me.LabelMerkVoertuig.TabIndex = 5
        Me.LabelMerkVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamEigenaar
        '
        Me.LabelNaamEigenaar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamEigenaar.Location = New System.Drawing.Point(144, 16)
        Me.LabelNaamEigenaar.Name = "LabelNaamEigenaar"
        Me.LabelNaamEigenaar.Size = New System.Drawing.Size(280, 20)
        Me.LabelNaamEigenaar.TabIndex = 2
        Me.LabelNaamEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStamnrEigenaar
        '
        Me.LabelStamnrEigenaar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStamnrEigenaar.Location = New System.Drawing.Point(88, 16)
        Me.LabelStamnrEigenaar.Name = "LabelStamnrEigenaar"
        Me.LabelStamnrEigenaar.Size = New System.Drawing.Size(56, 20)
        Me.LabelStamnrEigenaar.TabIndex = 1
        Me.LabelStamnrEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVoertuigId
        '
        Me.TextBoxVoertuigId.Location = New System.Drawing.Point(264, 40)
        Me.TextBoxVoertuigId.Name = "TextBoxVoertuigId"
        Me.TextBoxVoertuigId.Size = New System.Drawing.Size(24, 20)
        Me.TextBoxVoertuigId.TabIndex = 12
        Me.TextBoxVoertuigId.Visible = False
        '
        'LabelAard
        '
        Me.LabelAard.AutoSize = True
        Me.LabelAard.Location = New System.Drawing.Point(8, 64)
        Me.LabelAard.Name = "LabelAard"
        Me.LabelAard.Size = New System.Drawing.Size(75, 13)
        Me.LabelAard.TabIndex = 6
        Me.LabelAard.Text = "Type voertuig:"
        Me.LabelAard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelChassisnummer
        '
        Me.LabelChassisnummer.AutoSize = True
        Me.LabelChassisnummer.Location = New System.Drawing.Point(312, 64)
        Me.LabelChassisnummer.Name = "LabelChassisnummer"
        Me.LabelChassisnummer.Size = New System.Drawing.Size(55, 13)
        Me.LabelChassisnummer.TabIndex = 10
        Me.LabelChassisnummer.Text = "Chassisnr:"
        Me.LabelChassisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaat
        '
        Me.LabelNummerplaat.AutoSize = True
        Me.LabelNummerplaat.Location = New System.Drawing.Point(312, 40)
        Me.LabelNummerplaat.Name = "LabelNummerplaat"
        Me.LabelNummerplaat.Size = New System.Drawing.Size(44, 13)
        Me.LabelNummerplaat.TabIndex = 8
        Me.LabelNummerplaat.Text = "Nrplaat:"
        Me.LabelNummerplaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerk
        '
        Me.LabelMerk.Location = New System.Drawing.Point(8, 40)
        Me.LabelMerk.Name = "LabelMerk"
        Me.LabelMerk.Size = New System.Drawing.Size(48, 16)
        Me.LabelMerk.TabIndex = 4
        Me.LabelMerk.Text = "Merk:"
        Me.LabelMerk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEigenaar
        '
        Me.LabelEigenaar.Location = New System.Drawing.Point(8, 16)
        Me.LabelEigenaar.Name = "LabelEigenaar"
        Me.LabelEigenaar.Size = New System.Drawing.Size(72, 23)
        Me.LabelEigenaar.TabIndex = 0
        Me.LabelEigenaar.Text = "Eigenaar:"
        Me.LabelEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesVoertuig
        '
        Me.ButtonKiesVoertuig.Location = New System.Drawing.Point(432, 16)
        Me.ButtonKiesVoertuig.Name = "ButtonKiesVoertuig"
        Me.ButtonKiesVoertuig.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesVoertuig.TabIndex = 3
        Me.ButtonKiesVoertuig.Text = "Kies Voertuig"
        '
        'GroupBoxInbreuk
        '
        Me.GroupBoxInbreuk.Controls.Add(Me.TabControlInbreuken)
        Me.GroupBoxInbreuk.Location = New System.Drawing.Point(0, 271)
        Me.GroupBoxInbreuk.Name = "GroupBoxInbreuk"
        Me.GroupBoxInbreuk.Size = New System.Drawing.Size(1008, 144)
        Me.GroupBoxInbreuk.TabIndex = 4
        Me.GroupBoxInbreuk.TabStop = False
        Me.GroupBoxInbreuk.Text = "Inbreuk(en)"
        '
        'TabControlInbreuken
        '
        Me.TabControlInbreuken.Controls.Add(Me.TabPageInbreuk)
        Me.TabControlInbreuken.Controls.Add(Me.TabPageVoorbijeInbreuken)
        Me.TabControlInbreuken.Location = New System.Drawing.Point(8, 16)
        Me.TabControlInbreuken.Name = "TabControlInbreuken"
        Me.TabControlInbreuken.SelectedIndex = 0
        Me.TabControlInbreuken.Size = New System.Drawing.Size(992, 120)
        Me.TabControlInbreuken.TabIndex = 0
        '
        'TabPageInbreuk
        '
        Me.TabPageInbreuk.Controls.Add(Me.ButtonNewInbreuk)
        Me.TabPageInbreuk.Controls.Add(Me.UltraGridHuidigeInbreuken)
        Me.TabPageInbreuk.Controls.Add(Me.ButtonDeleteBijlage)
        Me.TabPageInbreuk.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInbreuk.Name = "TabPageInbreuk"
        Me.TabPageInbreuk.Size = New System.Drawing.Size(984, 94)
        Me.TabPageInbreuk.TabIndex = 0
        Me.TabPageInbreuk.Text = "Huidige Inbreuk(en)"
        '
        'ButtonNewInbreuk
        '
        Me.ButtonNewInbreuk.Image = CType(resources.GetObject("ButtonNewInbreuk.Image"), System.Drawing.Image)
        Me.ButtonNewInbreuk.Location = New System.Drawing.Point(952, 8)
        Me.ButtonNewInbreuk.Name = "ButtonNewInbreuk"
        Me.ButtonNewInbreuk.Size = New System.Drawing.Size(24, 24)
        Me.ButtonNewInbreuk.TabIndex = 1
        '
        'UltraGridHuidigeInbreuken
        '
        Me.UltraGridHuidigeInbreuken.DataMember = "BBINBRVA"
        Me.UltraGridHuidigeInbreuken.DataSource = Me._dataRegInbreukRegl
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Appearance = Appearance1
        Me.UltraGridHuidigeInbreuken.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Width = 61
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "Toegelaten"
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn27.Header.Caption = "Geregistreerd"
        UltraGridColumn27.Header.VisiblePosition = 6
        UltraGridColumn27.Width = 80
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn28.Header.VisiblePosition = 7
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn29.Header.VisiblePosition = 8
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.VisiblePosition = 9
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn31.Header.VisiblePosition = 10
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn32.Header.VisiblePosition = 11
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn33.Header.VisiblePosition = 12
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn34.Header.VisiblePosition = 13
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn35.Header.VisiblePosition = 14
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.VisiblePosition = 15
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn37.Header.VisiblePosition = 16
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn38.Header.VisiblePosition = 17
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 18
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.Caption = "Artikelnr."
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Width = 80
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Header.Caption = "Omschrijving Artikel"
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 550
        UltraGridColumn42.Header.VisiblePosition = 19
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 20
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 21
        UltraGridColumn44.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        Me.UltraGridHuidigeInbreuken.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridHuidigeInbreuken.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridHuidigeInbreuken.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridHuidigeInbreuken.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridHuidigeInbreuken.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridHuidigeInbreuken.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridHuidigeInbreuken.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridHuidigeInbreuken.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridHuidigeInbreuken.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridHuidigeInbreuken.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraGridHuidigeInbreuken.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridHuidigeInbreuken.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridHuidigeInbreuken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridHuidigeInbreuken.Location = New System.Drawing.Point(8, 0)
        Me.UltraGridHuidigeInbreuken.Name = "UltraGridHuidigeInbreuken"
        Me.UltraGridHuidigeInbreuken.Size = New System.Drawing.Size(936, 96)
        Me.UltraGridHuidigeInbreuken.TabIndex = 0
        Me.UltraGridHuidigeInbreuken.Text = "Huidige Inbreuken"
        '
        '_dataRegInbreukRegl
        '
        Me._dataRegInbreukRegl.DataSetName = "TDSRegInbreukRegl"
        Me._dataRegInbreukRegl.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegInbreukRegl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonDeleteBijlage
        '
        Me.ButtonDeleteBijlage.Enabled = False
        Me.ButtonDeleteBijlage.Image = CType(resources.GetObject("ButtonDeleteBijlage.Image"), System.Drawing.Image)
        Me.ButtonDeleteBijlage.Location = New System.Drawing.Point(952, 64)
        Me.ButtonDeleteBijlage.Name = "ButtonDeleteBijlage"
        Me.ButtonDeleteBijlage.Size = New System.Drawing.Size(24, 24)
        Me.ButtonDeleteBijlage.TabIndex = 2
        '
        'TabPageVoorbijeInbreuken
        '
        Me.TabPageVoorbijeInbreuken.Controls.Add(Me.UltraGridVastgesteldeInbreuken)
        Me.TabPageVoorbijeInbreuken.Location = New System.Drawing.Point(4, 22)
        Me.TabPageVoorbijeInbreuken.Name = "TabPageVoorbijeInbreuken"
        Me.TabPageVoorbijeInbreuken.Size = New System.Drawing.Size(984, 94)
        Me.TabPageVoorbijeInbreuken.TabIndex = 1
        Me.TabPageVoorbijeInbreuken.Text = "Reeds vastgestelde inbreuken"
        '
        'UltraGridVastgesteldeInbreuken
        '
        Me.UltraGridVastgesteldeInbreuken.DataMember = "BBINBRVA"
        Me.UltraGridVastgesteldeInbreuken.DataSource = Me._dataVastgesteldeInbreuken
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Appearance = Appearance13
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.Width = 72
        UltraGridColumn46.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn46.Header.VisiblePosition = 7
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn47.Header.VisiblePosition = 6
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn48.Header.VisiblePosition = 8
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn49.Header.Caption = "Vastgesteld"
        UltraGridColumn49.Header.VisiblePosition = 5
        UltraGridColumn49.Width = 86
        UltraGridColumn50.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn50.Header.Caption = "Artikelnr"
        UltraGridColumn50.Header.VisiblePosition = 3
        UltraGridColumn50.Width = 78
        UltraGridColumn51.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn51.Header.Caption = "Omschrijving"
        UltraGridColumn51.Header.VisiblePosition = 4
        UltraGridColumn51.Width = 612
        UltraGridColumn52.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn52.Header.Caption = "Datum"
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn52.Width = 94
        UltraGridColumn53.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn53.Header.VisiblePosition = 9
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn54.Header.VisiblePosition = 10
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 11
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.Width = 57
        UltraGridColumn56.Header.VisiblePosition = 12
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.Width = 50
        UltraGridColumn57.Header.VisiblePosition = 13
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.Width = 37
        UltraGridColumn58.Header.VisiblePosition = 14
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.Width = 55
        UltraGridColumn59.Header.VisiblePosition = 15
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.Width = 49
        UltraGridColumn60.Header.VisiblePosition = 16
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Width = 38
        UltraGridColumn61.Header.VisiblePosition = 17
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.Width = 67
        UltraGridColumn62.Header.VisiblePosition = 18
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.Width = 80
        UltraGridColumn63.Header.VisiblePosition = 19
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.Width = 76
        UltraGridColumn64.Header.VisiblePosition = 20
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 122
        UltraGridColumn65.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn65.Header.Caption = "Volgnr"
        UltraGridColumn65.Header.VisiblePosition = 1
        UltraGridColumn65.Width = 45
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65})
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.CellAppearance = Appearance20
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.RowAppearance = Appearance23
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance24.BackColor = System.Drawing.Color.Yellow
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.SpecialRowSeparatorAppearance = Appearance24
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.Override.TemplateAddRowAppearance = Appearance25
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridVastgesteldeInbreuken.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridVastgesteldeInbreuken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridVastgesteldeInbreuken.Location = New System.Drawing.Point(8, 0)
        Me.UltraGridVastgesteldeInbreuken.Name = "UltraGridVastgesteldeInbreuken"
        Me.UltraGridVastgesteldeInbreuken.Size = New System.Drawing.Size(936, 96)
        Me.UltraGridVastgesteldeInbreuken.TabIndex = 0
        '
        '_dataVastgesteldeInbreuken
        '
        Me._dataVastgesteldeInbreuken.DataSetName = "TDSVastgesteldeInbreuken"
        Me._dataVastgesteldeInbreuken.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataVastgesteldeInbreuken.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsInbreukRegl)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 414)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 166)
        Me.GroupBoxOverige.TabIndex = 6
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsInbreukRegl
        '
        Me.UserControlGeneralFunctionsInbreukRegl.AutoSize = True
        Me.UserControlGeneralFunctionsInbreukRegl.DatumOpstelling = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsInbreukRegl.GetReportContractant = False
        Me.UserControlGeneralFunctionsInbreukRegl.Location = New System.Drawing.Point(6, 16)
        Me.UserControlGeneralFunctionsInbreukRegl.Name = "UserControlGeneralFunctionsInbreukRegl"
        Me.UserControlGeneralFunctionsInbreukRegl.Opsteller = 0
        Me.UserControlGeneralFunctionsInbreukRegl.Size = New System.Drawing.Size(516, 144)
        Me.UserControlGeneralFunctionsInbreukRegl.TabIndex = 1
        Me.UserControlGeneralFunctionsInbreukRegl.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxInbreukReglementen
        '
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxInbreukReglementen.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxInbreukReglementen.Location = New System.Drawing.Point(0, 578)
        Me.GroupBoxInbreukReglementen.Name = "GroupBoxInbreukReglementen"
        Me.GroupBoxInbreukReglementen.Size = New System.Drawing.Size(528, 54)
        Me.GroupBoxInbreukReglementen.TabIndex = 8
        Me.GroupBoxInbreukReglementen.TabStop = False
        Me.GroupBoxInbreukReglementen.Text = "Inbreuk op reglementen"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(310, 31)
        Me.ButtonMailIKP.Name = "ButtonMailIKP"
        Me.ButtonMailIKP.Size = New System.Drawing.Size(108, 23)
        Me.ButtonMailIKP.TabIndex = 5
        Me.ButtonMailIKP.Text = "Mail IKP/PEB"
        Me.ButtonMailIKP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMailIKP.UseVisualStyleBackColor = True
        Me.ButtonMailIKP.Visible = False
        '
        'UltraButtonAfdrukken
        '
        Appearance55.Image = CType(resources.GetObject("Appearance55.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance55
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonAnnuleer
        '
        Appearance56.Image = CType(resources.GetObject("Appearance56.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance56
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 0
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance57.Image = CType(resources.GetObject("Appearance57.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance57
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(216, 16)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 2
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraButtonOverzicht
        '
        Appearance58.Image = CType(resources.GetObject("Appearance58.Image"), Object)
        Me.UltraButtonOverzicht.Appearance = Appearance58
        Me.UltraButtonOverzicht.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOverzicht.Location = New System.Drawing.Point(320, 16)
        Me.UltraButtonOverzicht.Name = "UltraButtonOverzicht"
        Me.UltraButtonOverzicht.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOverzicht.TabIndex = 3
        Me.UltraButtonOverzicht.Text = "Overzicht"
        '
        'UltraButtonSluiten
        '
        Appearance59.Image = CType(resources.GetObject("Appearance59.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance59
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(424, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 635)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1003
        Me._statusBar.User = ""
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxOpmerkingen
        '
        Me.GroupBoxOpmerkingen.Controls.Add(Me.Label3)
        Me.GroupBoxOpmerkingen.Controls.Add(Me.Label2)
        Me.GroupBoxOpmerkingen.Controls.Add(Me.TextBoxOpmerkingen)
        Me.GroupBoxOpmerkingen.Controls.Add(Me.TextBoxVerklaring)
        Me.GroupBoxOpmerkingen.Location = New System.Drawing.Point(528, 55)
        Me.GroupBoxOpmerkingen.Name = "GroupBoxOpmerkingen"
        Me.GroupBoxOpmerkingen.Size = New System.Drawing.Size(480, 216)
        Me.GroupBoxOpmerkingen.TabIndex = 5
        Me.GroupBoxOpmerkingen.TabStop = False
        Me.GroupBoxOpmerkingen.Text = "Verklaring + Opmerking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Opmerking:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Verklaring overtreder:"
        '
        'TextBoxOpmerkingen
        '
        Me.TextBoxOpmerkingen.Location = New System.Drawing.Point(8, 128)
        Me.TextBoxOpmerkingen.MaxLength = 3000
        Me.TextBoxOpmerkingen.Multiline = True
        Me.TextBoxOpmerkingen.Name = "TextBoxOpmerkingen"
        Me.TextBoxOpmerkingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOpmerkingen.Size = New System.Drawing.Size(464, 80)
        Me.TextBoxOpmerkingen.TabIndex = 2
        '
        'TextBoxVerklaring
        '
        Me.TextBoxVerklaring.Location = New System.Drawing.Point(8, 32)
        Me.TextBoxVerklaring.MaxLength = 3000
        Me.TextBoxVerklaring.Multiline = True
        Me.TextBoxVerklaring.Name = "TextBoxVerklaring"
        Me.TextBoxVerklaring.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxVerklaring.Size = New System.Drawing.Size(464, 80)
        Me.TextBoxVerklaring.TabIndex = 1
        '
        'GroupBoxOvertreder
        '
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelAfdelingOvertreder)
        Me.GroupBoxOvertreder.Controls.Add(Me.Label1)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelOvertrederType)
        Me.GroupBoxOvertreder.Controls.Add(Me.UltraComboOvertrederType)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelFirmaNaam)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelAdresOvertreder)
        Me.GroupBoxOvertreder.Controls.Add(Me.UltraMaskedEditStamnrOvertreder)
        Me.GroupBoxOvertreder.Controls.Add(Me.TextBoxFirmaId)
        Me.GroupBoxOvertreder.Controls.Add(Me.ButtonKiesFirma)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelFirma)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelOvertreder)
        Me.GroupBoxOvertreder.Controls.Add(Me.ButtonKiesPersoonOvertreder)
        Me.GroupBoxOvertreder.Controls.Add(Me.LabelNaamOvertreder)
        Me.GroupBoxOvertreder.Location = New System.Drawing.Point(0, 151)
        Me.GroupBoxOvertreder.Name = "GroupBoxOvertreder"
        Me.GroupBoxOvertreder.Size = New System.Drawing.Size(528, 120)
        Me.GroupBoxOvertreder.TabIndex = 3
        Me.GroupBoxOvertreder.TabStop = False
        Me.GroupBoxOvertreder.Text = "Identiteit overtreder"
        '
        'LabelAfdelingOvertreder
        '
        Me.LabelAfdelingOvertreder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAfdelingOvertreder.Location = New System.Drawing.Point(88, 64)
        Me.LabelAfdelingOvertreder.Name = "LabelAfdelingOvertreder"
        Me.LabelAfdelingOvertreder.Size = New System.Drawing.Size(56, 20)
        Me.LabelAfdelingOvertreder.TabIndex = 15
        Me.LabelAfdelingOvertreder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Afdeling:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOvertrederType
        '
        Me.LabelOvertrederType.AutoSize = True
        Me.LabelOvertrederType.Location = New System.Drawing.Point(160, 64)
        Me.LabelOvertrederType.Name = "LabelOvertrederType"
        Me.LabelOvertrederType.Size = New System.Drawing.Size(83, 13)
        Me.LabelOvertrederType.TabIndex = 12
        Me.LabelOvertrederType.Text = "Overtreder type:"
        Me.LabelOvertrederType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraComboOvertrederType
        '
        Me.UltraComboOvertrederType.DataMember = "BBINBRINDTY"
        Me.UltraComboOvertrederType.DataSource = Me._dataOvertrederType
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboOvertrederType.DisplayLayout.Appearance = Appearance31
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 100
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 140
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.UltraComboOvertrederType.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraComboOvertrederType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboOvertrederType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboOvertrederType.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboOvertrederType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.UltraComboOvertrederType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboOvertrederType.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.UltraComboOvertrederType.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboOvertrederType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboOvertrederType.DisplayLayout.Override.ActiveCellAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.SystemColors.Highlight
        Appearance36.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboOvertrederType.DisplayLayout.Override.ActiveRowAppearance = Appearance36
        Me.UltraComboOvertrederType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboOvertrederType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboOvertrederType.DisplayLayout.Override.CardAreaAppearance = Appearance37
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboOvertrederType.DisplayLayout.Override.CellAppearance = Appearance38
        Me.UltraComboOvertrederType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboOvertrederType.DisplayLayout.Override.CellPadding = 0
        Appearance39.BackColor = System.Drawing.SystemColors.Control
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboOvertrederType.DisplayLayout.Override.GroupByRowAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Left"
        Me.UltraComboOvertrederType.DisplayLayout.Override.HeaderAppearance = Appearance40
        Me.UltraComboOvertrederType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboOvertrederType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboOvertrederType.DisplayLayout.Override.RowAppearance = Appearance41
        Me.UltraComboOvertrederType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboOvertrederType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance42
        Me.UltraComboOvertrederType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboOvertrederType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboOvertrederType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboOvertrederType.DisplayMember = "SCF_INBR_IND_TY"
        Me.UltraComboOvertrederType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboOvertrederType.Location = New System.Drawing.Point(256, 64)
        Me.UltraComboOvertrederType.Name = "UltraComboOvertrederType"
        Me.UltraComboOvertrederType.Size = New System.Drawing.Size(168, 22)
        Me.UltraComboOvertrederType.TabIndex = 5
        Me.UltraComboOvertrederType.ValueMember = "ID_INBR_IND_TY"
        '
        '_dataOvertrederType
        '
        Me._dataOvertrederType.DataSetName = "TDSInbrIndTy"
        Me._dataOvertrederType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataOvertrederType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelFirmaNaam
        '
        Me.LabelFirmaNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaNaam.Location = New System.Drawing.Point(88, 96)
        Me.LabelFirmaNaam.Name = "LabelFirmaNaam"
        Me.LabelFirmaNaam.Size = New System.Drawing.Size(336, 20)
        Me.LabelFirmaNaam.TabIndex = 8
        Me.LabelFirmaNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAdresOvertreder
        '
        Me.LabelAdresOvertreder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAdresOvertreder.Location = New System.Drawing.Point(88, 40)
        Me.LabelAdresOvertreder.Name = "LabelAdresOvertreder"
        Me.LabelAdresOvertreder.Size = New System.Drawing.Size(432, 20)
        Me.LabelAdresOvertreder.TabIndex = 3
        Me.LabelAdresOvertreder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrOvertreder
        '
        Me.UltraMaskedEditStamnrOvertreder.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrOvertreder.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrOvertreder.Location = New System.Drawing.Point(88, 16)
        Me.UltraMaskedEditStamnrOvertreder.MaxValue = 99999999
        Me.UltraMaskedEditStamnrOvertreder.Name = "UltraMaskedEditStamnrOvertreder"
        Me.UltraMaskedEditStamnrOvertreder.NonAutoSizeHeight = 20
        Me.UltraMaskedEditStamnrOvertreder.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrOvertreder.TabIndex = 1
        '
        'TextBoxFirmaId
        '
        Me.TextBoxFirmaId.Location = New System.Drawing.Point(45, 96)
        Me.TextBoxFirmaId.Name = "TextBoxFirmaId"
        Me.TextBoxFirmaId.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxFirmaId.TabIndex = 10
        '
        'ButtonKiesFirma
        '
        Me.ButtonKiesFirma.Location = New System.Drawing.Point(432, 96)
        Me.ButtonKiesFirma.Name = "ButtonKiesFirma"
        Me.ButtonKiesFirma.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesFirma.TabIndex = 9
        Me.ButtonKiesFirma.Text = "Kies Firma"
        '
        'LabelFirma
        '
        Me.LabelFirma.AutoSize = True
        Me.LabelFirma.Location = New System.Drawing.Point(8, 96)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(35, 13)
        Me.LabelFirma.TabIndex = 7
        Me.LabelFirma.Text = "Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOvertreder
        '
        Me.LabelOvertreder.AutoSize = True
        Me.LabelOvertreder.Location = New System.Drawing.Point(8, 16)
        Me.LabelOvertreder.Name = "LabelOvertreder"
        Me.LabelOvertreder.Size = New System.Drawing.Size(60, 13)
        Me.LabelOvertreder.TabIndex = 0
        Me.LabelOvertreder.Text = "Overtreder:"
        Me.LabelOvertreder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonOvertreder
        '
        Me.ButtonKiesPersoonOvertreder.Location = New System.Drawing.Point(432, 16)
        Me.ButtonKiesPersoonOvertreder.Name = "ButtonKiesPersoonOvertreder"
        Me.ButtonKiesPersoonOvertreder.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesPersoonOvertreder.TabIndex = 4
        Me.ButtonKiesPersoonOvertreder.Text = "Kies persoon"
        '
        'LabelNaamOvertreder
        '
        Me.LabelNaamOvertreder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamOvertreder.Location = New System.Drawing.Point(144, 16)
        Me.LabelNaamOvertreder.Name = "LabelNaamOvertreder"
        Me.LabelNaamOvertreder.Size = New System.Drawing.Size(280, 20)
        Me.LabelNaamOvertreder.TabIndex = 2
        Me.LabelNaamOvertreder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxVerzending
        '
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonInfoChip)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelBevestigdDoorLeverancier)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraDateTimeEditorBevestigdDoorLeverancier)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraComboFirma)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelLeverancier)
        Me.GroupBoxVerzending.Controls.Add(Me.cbxVerslagnrCHIP)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelOpmerkingNaarCHIP)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraDateTimeEditorNaarCHIP)
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonNaarCHIP)
        Me.GroupBoxVerzending.Controls.Add(Me.TextBoxNaarCHIP)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelNaarChip)
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonTerugZenden)
        Me.GroupBoxVerzending.Controls.Add(Me.Label4)
        Me.GroupBoxVerzending.Controls.Add(Me.Label5)
        Me.GroupBoxVerzending.Controls.Add(Me.Label6)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraDateTimeEditorBestemmelingen)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraDateTimeEditorGoedkeuring)
        Me.GroupBoxVerzending.Controls.Add(Me.UltraDateTimeEditorVerzending)
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonVerzendingBest)
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonGoedkeuring)
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonVerzendingBBW)
        Me.GroupBoxVerzending.Controls.Add(Me.TextBoxVerzendingBestemmelingen)
        Me.GroupBoxVerzending.Controls.Add(Me.TextBoxGoedkeuring)
        Me.GroupBoxVerzending.Controls.Add(Me.TextBoxVerzending)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelVerzendingBest)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelGoedkeuring)
        Me.GroupBoxVerzending.Controls.Add(Me.LabelVerzending)
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 414)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 218)
        Me.GroupBoxVerzending.TabIndex = 1006
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonInfoChip
        '
        Me.ButtonInfoChip.Image = CType(resources.GetObject("ButtonInfoChip.Image"), System.Drawing.Image)
        Me.ButtonInfoChip.Location = New System.Drawing.Point(248, 101)
        Me.ButtonInfoChip.Name = "ButtonInfoChip"
        Me.ButtonInfoChip.Size = New System.Drawing.Size(32, 21)
        Me.ButtonInfoChip.TabIndex = 1006
        Me.ToolTip1.SetToolTip(Me.ButtonInfoChip, "info over SAP firma en contactpersoon")
        Me.ButtonInfoChip.UseVisualStyleBackColor = True
        '
        'LabelBevestigdDoorLeverancier
        '
        Me.LabelBevestigdDoorLeverancier.AutoSize = True
        Me.LabelBevestigdDoorLeverancier.Location = New System.Drawing.Point(8, 194)
        Me.LabelBevestigdDoorLeverancier.Name = "LabelBevestigdDoorLeverancier"
        Me.LabelBevestigdDoorLeverancier.Size = New System.Drawing.Size(120, 13)
        Me.LabelBevestigdDoorLeverancier.TabIndex = 1004
        Me.LabelBevestigdDoorLeverancier.Text = "Gelezen dr Leverancier:"
        Me.LabelBevestigdDoorLeverancier.Visible = False
        '
        'UltraDateTimeEditorBevestigdDoorLeverancier
        '
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Location = New System.Drawing.Point(132, 190)
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Name = "UltraDateTimeEditorBevestigdDoorLeverancier"
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.ReadOnly = True
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.TabIndex = 1003
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Value = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Visible = False
        '
        'UltraComboFirma
        '
        Me.UltraComboFirma.DataMember = "Firma"
        Me.UltraComboFirma.DataSource = Me._dataFirmaHRM
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboFirma.DisplayLayout.Appearance = Appearance43
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Width = 150
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.UltraComboFirma.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraComboFirma.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboFirma.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance44.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.GroupByBox.Appearance = Appearance44
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance45
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance46.BackColor2 = System.Drawing.SystemColors.Control
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.PromptAppearance = Appearance46
        Me.UltraComboFirma.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboFirma.DisplayLayout.MaxRowScrollRegions = 1
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveCellAppearance = Appearance47
        Appearance48.BackColor = System.Drawing.SystemColors.Highlight
        Appearance48.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveRowAppearance = Appearance48
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.CardAreaAppearance = Appearance49
        Appearance50.BorderColor = System.Drawing.Color.Silver
        Appearance50.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboFirma.DisplayLayout.Override.CellAppearance = Appearance50
        Me.UltraComboFirma.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboFirma.DisplayLayout.Override.CellPadding = 0
        Appearance51.BackColor = System.Drawing.SystemColors.Control
        Appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance51.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.GroupByRowAppearance = Appearance51
        Appearance52.TextHAlignAsString = "Left"
        Me.UltraComboFirma.DisplayLayout.Override.HeaderAppearance = Appearance52
        Me.UltraComboFirma.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboFirma.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboFirma.DisplayLayout.Override.RowAppearance = Appearance53
        Me.UltraComboFirma.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance54.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboFirma.DisplayLayout.Override.TemplateAddRowAppearance = Appearance54
        Me.UltraComboFirma.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboFirma.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboFirma.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboFirma.DisplayMember = "firmanaam"
        Me.UltraComboFirma.Enabled = False
        Me.UltraComboFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboFirma.Location = New System.Drawing.Point(259, 191)
        Me.UltraComboFirma.Name = "UltraComboFirma"
        Me.UltraComboFirma.Size = New System.Drawing.Size(213, 22)
        Me.UltraComboFirma.TabIndex = 1002
        Me.UltraComboFirma.ValueMember = "firmanummer"
        '
        '_dataFirmaHRM
        '
        Me._dataFirmaHRM.DataSetName = "TDSFirmaHRM"
        Me._dataFirmaHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelLeverancier
        '
        Me.LabelLeverancier.AutoSize = True
        Me.LabelLeverancier.Location = New System.Drawing.Point(226, 194)
        Me.LabelLeverancier.Name = "LabelLeverancier"
        Me.LabelLeverancier.Size = New System.Drawing.Size(35, 13)
        Me.LabelLeverancier.TabIndex = 25
        Me.LabelLeverancier.Text = "Firma:"
        '
        'cbxVerslagnrCHIP
        '
        Me.cbxVerslagnrCHIP.AutoSize = True
        Me.cbxVerslagnrCHIP.Enabled = False
        Me.cbxVerslagnrCHIP.Location = New System.Drawing.Point(259, 148)
        Me.cbxVerslagnrCHIP.Name = "cbxVerslagnrCHIP"
        Me.cbxVerslagnrCHIP.Size = New System.Drawing.Size(51, 17)
        Me.cbxVerslagnrCHIP.TabIndex = 23
        Me.cbxVerslagnrCHIP.Text = "CHIP"
        Me.cbxVerslagnrCHIP.UseVisualStyleBackColor = True
        '
        'LabelOpmerkingNaarCHIP
        '
        Me.LabelOpmerkingNaarCHIP.AutoSize = True
        Me.LabelOpmerkingNaarCHIP.Location = New System.Drawing.Point(8, 171)
        Me.LabelOpmerkingNaarCHIP.Name = "LabelOpmerkingNaarCHIP"
        Me.LabelOpmerkingNaarCHIP.Size = New System.Drawing.Size(55, 13)
        Me.LabelOpmerkingNaarCHIP.TabIndex = 22
        Me.LabelOpmerkingNaarCHIP.Text = "Opm chip:"
        '
        'UltraDateTimeEditorNaarCHIP
        '
        Me.UltraDateTimeEditorNaarCHIP.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorNaarCHIP.Location = New System.Drawing.Point(132, 145)
        Me.UltraDateTimeEditorNaarCHIP.Name = "UltraDateTimeEditorNaarCHIP"
        Me.UltraDateTimeEditorNaarCHIP.ReadOnly = True
        Me.UltraDateTimeEditorNaarCHIP.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorNaarCHIP.TabIndex = 19
        Me.UltraDateTimeEditorNaarCHIP.Value = New Date(2011, 3, 3, 0, 0, 0, 0)
        '
        'ButtonNaarCHIP
        '
        Me.ButtonNaarCHIP.Location = New System.Drawing.Point(344, 145)
        Me.ButtonNaarCHIP.Name = "ButtonNaarCHIP"
        Me.ButtonNaarCHIP.Size = New System.Drawing.Size(128, 21)
        Me.ButtonNaarCHIP.TabIndex = 21
        Me.ButtonNaarCHIP.Text = "Naar CHIP"
        '
        'TextBoxNaarCHIP
        '
        Me.TextBoxNaarCHIP.Location = New System.Drawing.Point(64, 168)
        Me.TextBoxNaarCHIP.MaxLength = 100
        Me.TextBoxNaarCHIP.Name = "TextBoxNaarCHIP"
        Me.TextBoxNaarCHIP.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxNaarCHIP.TabIndex = 20
        '
        'LabelNaarChip
        '
        Me.LabelNaarChip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNaarChip.Location = New System.Drawing.Point(8, 149)
        Me.LabelNaarChip.Name = "LabelNaarChip"
        Me.LabelNaarChip.Size = New System.Drawing.Size(106, 16)
        Me.LabelNaarChip.TabIndex = 18
        Me.LabelNaarChip.Text = "Datum naar CHIP:"
        '
        'ButtonTerugZenden
        '
        Me.ButtonTerugZenden.Location = New System.Drawing.Point(392, 56)
        Me.ButtonTerugZenden.Name = "ButtonTerugZenden"
        Me.ButtonTerugZenden.Size = New System.Drawing.Size(80, 21)
        Me.ButtonTerugZenden.TabIndex = 17
        Me.ButtonTerugZenden.Text = "Stuur terug"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Opm mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Opm mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Opm mail:"
        '
        'UltraDateTimeEditorBestemmelingen
        '
        Me.UltraDateTimeEditorBestemmelingen.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorBestemmelingen.Location = New System.Drawing.Point(132, 100)
        Me.UltraDateTimeEditorBestemmelingen.Name = "UltraDateTimeEditorBestemmelingen"
        Me.UltraDateTimeEditorBestemmelingen.ReadOnly = True
        Me.UltraDateTimeEditorBestemmelingen.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorBestemmelingen.TabIndex = 9
        Me.UltraDateTimeEditorBestemmelingen.Value = New Date(2011, 3, 3, 0, 0, 0, 0)
        '
        'UltraDateTimeEditorGoedkeuring
        '
        Me.UltraDateTimeEditorGoedkeuring.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorGoedkeuring.Location = New System.Drawing.Point(132, 55)
        Me.UltraDateTimeEditorGoedkeuring.Name = "UltraDateTimeEditorGoedkeuring"
        Me.UltraDateTimeEditorGoedkeuring.ReadOnly = True
        Me.UltraDateTimeEditorGoedkeuring.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorGoedkeuring.TabIndex = 5
        Me.UltraDateTimeEditorGoedkeuring.Value = New Date(2011, 3, 3, 0, 0, 0, 0)
        '
        'UltraDateTimeEditorVerzending
        '
        Me.UltraDateTimeEditorVerzending.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorVerzending.Location = New System.Drawing.Point(132, 9)
        Me.UltraDateTimeEditorVerzending.Name = "UltraDateTimeEditorVerzending"
        Me.UltraDateTimeEditorVerzending.ReadOnly = True
        Me.UltraDateTimeEditorVerzending.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorVerzending.TabIndex = 1
        Me.UltraDateTimeEditorVerzending.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDateTimeEditorVerzending.Value = New Date(2011, 3, 3, 0, 0, 0, 0)
        '
        'ButtonVerzendingBest
        '
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(286, 101)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(186, 21)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen en CHIP"
        Me.ToolTip1.SetToolTip(Me.ButtonVerzendingBest, "Naar bestemmelingen en automatisch nr CHIP (indien firma SAP gekend)")
        '
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(286, 56)
        Me.ButtonGoedkeuring.Name = "ButtonGoedkeuring"
        Me.ButtonGoedkeuring.Size = New System.Drawing.Size(80, 21)
        Me.ButtonGoedkeuring.TabIndex = 7
        Me.ButtonGoedkeuring.Text = "Keur goed"
        '
        'ButtonVerzendingBBW
        '
        Me.ButtonVerzendingBBW.Location = New System.Drawing.Point(344, 12)
        Me.ButtonVerzendingBBW.Name = "ButtonVerzendingBBW"
        Me.ButtonVerzendingBBW.Size = New System.Drawing.Size(128, 20)
        Me.ButtonVerzendingBBW.TabIndex = 3
        Me.ButtonVerzendingBBW.Text = "Naar Postoverste"
        '
        'TextBoxVerzendingBestemmelingen
        '
        Me.TextBoxVerzendingBestemmelingen.Location = New System.Drawing.Point(64, 124)
        Me.TextBoxVerzendingBestemmelingen.MaxLength = 100
        Me.TextBoxVerzendingBestemmelingen.Name = "TextBoxVerzendingBestemmelingen"
        Me.TextBoxVerzendingBestemmelingen.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxVerzendingBestemmelingen.TabIndex = 10
        '
        'TextBoxGoedkeuring
        '
        Me.TextBoxGoedkeuring.Location = New System.Drawing.Point(64, 79)
        Me.TextBoxGoedkeuring.MaxLength = 100
        Me.TextBoxGoedkeuring.Name = "TextBoxGoedkeuring"
        Me.TextBoxGoedkeuring.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxGoedkeuring.TabIndex = 6
        '
        'TextBoxVerzending
        '
        Me.TextBoxVerzending.Location = New System.Drawing.Point(64, 34)
        Me.TextBoxVerzending.MaxLength = 100
        Me.TextBoxVerzending.Name = "TextBoxVerzending"
        Me.TextBoxVerzending.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxVerzending.TabIndex = 2
        '
        'LabelVerzendingBest
        '
        Me.LabelVerzendingBest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerzendingBest.Location = New System.Drawing.Point(8, 104)
        Me.LabelVerzendingBest.Name = "LabelVerzendingBest"
        Me.LabelVerzendingBest.Size = New System.Drawing.Size(120, 18)
        Me.LabelVerzendingBest.TabIndex = 8
        Me.LabelVerzendingBest.Text = "Datum verz. bestem.:"
        '
        'LabelGoedkeuring
        '
        Me.LabelGoedkeuring.AutoSize = True
        Me.LabelGoedkeuring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoedkeuring.Location = New System.Drawing.Point(8, 59)
        Me.LabelGoedkeuring.Name = "LabelGoedkeuring"
        Me.LabelGoedkeuring.Size = New System.Drawing.Size(103, 13)
        Me.LabelGoedkeuring.TabIndex = 4
        Me.LabelGoedkeuring.Text = "Datum goedkeuring:"
        '
        'LabelVerzending
        '
        Me.LabelVerzending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerzending.Location = New System.Drawing.Point(8, 13)
        Me.LabelVerzending.Name = "LabelVerzending"
        Me.LabelVerzending.Size = New System.Drawing.Size(132, 17)
        Me.LabelVerzending.TabIndex = 0
        Me.LabelVerzending.Text = "Datum verz. postoverste:"
        '
        'FormBewakingInbreukReglementen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 657)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me.GroupBoxOvertreder)
        Me.Controls.Add(Me.GroupBoxOpmerkingen)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxInbreuk)
        Me.Controls.Add(Me.GroupBoxVoertuig)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Controls.Add(Me.GroupBoxInbreukReglementen)
        Me.Name = "FormBewakingInbreukReglementen"
        Me.Text = "Inbreuk op Reglementen"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVoertuig.ResumeLayout(False)
        Me.GroupBoxVoertuig.PerformLayout()
        Me.GroupBoxInbreuk.ResumeLayout(False)
        Me.TabControlInbreuken.ResumeLayout(False)
        Me.TabPageInbreuk.ResumeLayout(False)
        CType(Me.UltraGridHuidigeInbreuken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegInbreukRegl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVoorbijeInbreuken.ResumeLayout(False)
        CType(Me.UltraGridVastgesteldeInbreuken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVastgesteldeInbreuken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInbreukReglementen.ResumeLayout(False)
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpmerkingen.ResumeLayout(False)
        Me.GroupBoxOpmerkingen.PerformLayout()
        Me.GroupBoxOvertreder.ResumeLayout(False)
        Me.GroupBoxOvertreder.PerformLayout()
        CType(Me.UltraComboOvertrederType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataOvertrederType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVerzending.ResumeLayout(False)
        Me.GroupBoxVerzending.PerformLayout()
        CType(Me.UltraDateTimeEditorBevestigdDoorLeverancier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorNaarCHIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"

    Private Sub FormBewakingInbreukReglementen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing
            UltraDateTimeEditorNaarCHIP.Value = Nothing

            'tooltip CHIP - lawrence - 03/03/2011
            Dim toolTipCHIP As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip
            toolTipCHIP.SetToolTip(ButtonNaarCHIP, "Complaints Handling In Portal")
            toolTipCHIP.Active = True

            'tooltip CHIP - lawrence - 04/03/2011
            Dim toolTipCHIPcbx As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip
            toolTipCHIPcbx.SetToolTip(cbxVerslagnrCHIP, "Verslag bestemd voor CHIP")
            toolTipCHIPcbx.Active = True

            'combobox CHIP - firma - naco - 01/03/2011
            Dim dsFirma As New TDSFirmaHRM
            Dim objFirma As New HRMdata
            dsFirma.Merge(objFirma.GetFirma)
            _dataFirmaHRM.Merge(dsFirma.Tables("Firma").Select("", "firmanaam ASC"))


            'naco - 19/12/2006 - overtredertype toegevoegd (op vraag vazn Luc Van Hamme)
            _controller = New ControllerGetData
            _dataOvertrederType.Merge(_controller.GetOvertrederType)

            If _idRegistratie <> -1 Then
                bindRegistratie()
            End If

            'voor(usercontrolInbreukReglementen)
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsInbreukRegl.DatumOpstelling = Now
            End If

            bindBijlagen()
            bindBestemmelingen()
            initializeDataSetConfig()
            initializeDataSetIndividuen()

            'opbouw statusbar
            Dim ctrl As Control
            If IsMdiChild Then
                For Each ctrl In MdiParent.Controls
                    If TypeOf (ctrl) Is StatusBar AndAlso Not ctrl Is _statusBar Then
                        _statusBar.Remove()
                        _statusBar = CType(ctrl, StatusBar)
                        Exit For
                    End If
                Next
            End If

            UserControlGeneralFunctionsInbreukRegl.typeBrOfBew =
                UserControlGeneralFunctions.brandweerOfBewaking.bewaking

            If MdiParent IsNot Nothing Then MdiParent.Activate()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Binds"

    Private Sub bindRegistratie()
        Try
            _dataRegInbreukRegl.Clear()

            _controller = New ControllerGetData
            _dataRegInbreukRegl.Merge(Me._controller.GetRegInbreukRegl(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegInbreukRegl.BBBEWREGRow
            dr = Me._dataRegInbreukRegl.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsInbreukRegl.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            'usercontrol
            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsInbreukRegl.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsInbreukRegl.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsInbreukRegl.SetVeraData(dr.VeraReference, dr.VeraLink)
            End If

            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsInbreukRegl.GetReportContractant = dr.VerslagContractantYN
            End If

            'Inbreuk op reglementen opvullen
            Dim drInbr As TDSRegInbreukRegl.BBINBRRGRow
            drInbr = CType(Me._dataRegInbreukRegl.BBINBRRG.Rows.Item(0), TDSRegInbreukRegl.BBINBRRGRow)

            If Not drInbr.IsID_BEW_DUPNull Then
                UltraOptionSetBenadeelde.Value = drInbr.ID_BEW_DUP
            End If

            UltraMaskedEditStamnrOvertreder.Text = CStr(drInbr.ID_INBR)
            If Not drInbr.IsNM_INDNull And Not drInbr.IsVNM_INDNull Then
                LabelNaamOvertreder.Text = drInbr.NM_IND.Trim & " " & drInbr.VNM_IND.Trim
            ElseIf Not drInbr.IsNM_INDNull Then
                LabelNaamOvertreder.Text = drInbr.NM_IND
            ElseIf Not drInbr.IsVNM_INDNull Then
                LabelNaamOvertreder.Text = drInbr.VNM_IND
            Else
                LabelNaamOvertreder.Text = ""
            End If

            If Not drInbr.IsAD_INDNull Then
                LabelAdresOvertreder.Text = drInbr.AD_IND.Trim
            End If
            If Not drInbr.IsPO_COD_WNPL_INDNull Then
                LabelAdresOvertreder.Text &= " " & drInbr.PO_COD_WNPL_IND.Trim
            End If
            If Not drInbr.IsSAP_AFDNull Then
                LabelAfdelingOvertreder.Text = drInbr.SAP_AFD
            End If

            If Not drInbr.IsWNPL_INDNull Then
                LabelAdresOvertreder.Text &= " " & drInbr.WNPL_IND
            End If

            If Not drInbr.IsVKLR_INBRNull Then
                TextBoxVerklaring.Text = drInbr.VKLR_INBR
            End If
            If Not drInbr.IsOPM_EX_INBR_VSFNull Then
                TextBoxOpmerkingen.Text = drInbr.OPM_EX_INBR_VSF
            End If

            'Firma opvullen
            If Not Me._dataRegInbreukRegl.BBFRM.Rows.Count() = 0 Then

                Dim drFirma As TDSRegInbreukRegl.BBFRMRow
                drFirma = CType(Me._dataRegInbreukRegl.BBFRM.Rows.Item(0), TDSRegInbreukRegl.BBFRMRow)

                TextBoxFirmaId.Text = CStr(drFirma.ID_FRM)
                If Not drFirma.IsNM_FRMNull Then
                    LabelFirmaNaam.Text = drFirma.NM_FRM
                End If
            End If

            'Type overtreder opvullen
            If Not drInbr.IsID_INBR_IND_TYNull Then
                UltraComboOvertrederType.Value = drInbr.ID_INBR_IND_TY
            End If

            'Voertuig opvullen
            If Not Me._dataRegInbreukRegl.BBTSP.Rows.Count() = 0 Then

                Dim drVoer As TDSRegInbreukRegl.BBTSPRow
                drVoer = CType(Me._dataRegInbreukRegl.BBTSP.Rows.Item(0), TDSRegInbreukRegl.BBTSPRow)
                TextBoxVoertuigId.Text = drVoer.ID_TSP.ToString

                If Not drVoer.IsID_EIG_TSPNull Then
                    LabelStamnrEigenaar.Text = CStr(drVoer.ID_EIG_TSP)
                    If Not drVoer.IsNM_INDNull And Not drVoer.IsVNM_INDNull Then
                        LabelNaamEigenaar.Text = drVoer.NM_IND.Trim & " " & drVoer.VNM_IND
                    ElseIf Not drVoer.IsNM_INDNull Then
                        LabelNaamEigenaar.Text = drVoer.NM_IND
                    ElseIf Not drVoer.IsVNM_INDNull Then
                        LabelNaamEigenaar.Text = drVoer.VNM_IND
                    Else
                        LabelNaamEigenaar.Text = ""
                    End If
                ElseIf Not drVoer.IsID_FRM_TSPNull Then
                    LabelStamnrEigenaar.Text = "Firma"
                    If Not drVoer.IsNM_FRMNull Then
                        LabelNaamEigenaar.Text = drVoer.NM_FRM
                    End If
                End If

                If Not drVoer.IsSCF_MRK_TSPNull Then
                    LabelMerkVoertuig.Text = drVoer.SCF_MRK_TSP
                End If
                If Not drVoer.IsSCF_TY_TSPNull Then
                    LabelAardVoertuig.Text = drVoer.SCF_TY_TSP
                End If
                If Not drVoer.IsPL_NR_TSPNull Then
                    LabelNummerplaatVoertuig.Text = drVoer.PL_NR_TSP
                End If
                If Not drVoer.IsNR_CHAS_TSPNull Then
                    LabelChassisnummerVoertuig.Text = drVoer.NR_CHAS_TSP
                End If
            End If

            'Gegevens verzending
            '-------------------
            If Not dr.IsDT_VZ_RAP_NWNull Then
                UltraDateTimeEditorVerzending.Value = dr.DT_VZ_RAP_NW
                'indien de interventie reeds doorgemaild is, en de gebruiker is niet de postoverste
                'of de bbwverantwoordelijke, dan mag hij deze niet meer wijzigen
                If FormManager.Current.PostOverste = False And FormManager.Current.BbwVerantwoordelijke = False Then
                    UltraButtonOpslaan.Enabled = False
                End If
            Else
                UltraDateTimeEditorVerzending.Value = Nothing
            End If
            If Not dr.IsDT_VZ_RAP_NWNull And dr.IsDT_OKNull And dr.IsDT_VZ_BSTNull Then
                ButtonTerugZenden.Enabled = True
            Else
                ButtonTerugZenden.Enabled = False
            End If
            If Not dr.IsDT_OKNull Then
                UltraDateTimeEditorGoedkeuring.Value = dr.DT_OK
            Else
                UltraDateTimeEditorGoedkeuring.Value = Nothing
            End If
            If Not dr.IsDT_VZ_BSTNull Then
                UltraDateTimeEditorBestemmelingen.Value = dr.DT_VZ_BST
            Else
                UltraDateTimeEditorBestemmelingen.Value = Nothing
            End If
            If Not dr.IsOPM_OPSNull Then
                TextBoxVerzending.Text = dr.OPM_OPS
            End If
            If Not dr.IsOPM_CHEF_PONull Then
                TextBoxGoedkeuring.Text = dr.OPM_CHEF_PO
            End If
            If Not dr.IsOPM_HFD_BRWNull Then
                TextBoxVerzendingBestemmelingen.Text = dr.OPM_HFD_BRW
            End If
            If Not dr.IsDT_CHIPNull Then
                UltraDateTimeEditorNaarCHIP.Value = dr.DT_CHIP
            Else
                UltraDateTimeEditorNaarCHIP.Value = Nothing
            End If
            If Not dr.IsOPM_CHIPNull Then
                TextBoxNaarCHIP.Text = dr.OPM_CHIP
            End If
            If Not dr.IsCHIP_YNNull Then
                cbxVerslagnrCHIP.Checked = dr.CHIP_YN
            Else
                cbxVerslagnrCHIP.Checked = False
            End If
            If Not dr.IsSAP_SUPPLIER_IDNull Then
                For Each Item As UltraGridRow In UltraComboFirma.Rows
                    If Item.Cells("firmanummer").Value.ToString() = dr.SAP_SUPPLIER_ID Then
                        UltraComboFirma.SelectedRow = Item
                        Exit For
                    End If
                Next
            End If


            Me.UserControlGeneralFunctionsInbreukRegl.setBijlageData(Me._dataRegInbreukRegl.BBBYLG)
            Me.UserControlGeneralFunctionsInbreukRegl.setBestemmelingenData(Me._dataRegInbreukRegl.BBBST)
            bindVorigeInbreuken(drInbr.ID_INBR)
            enableInbreukButtons()


            If (UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_NOK_SNL_DT_VAN")) Then
                UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns("PBH_NOK_SNL_DT_VAN").Hidden = True
            End If
            If (UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_NOK_SNL_DT_TOT")) Then
                UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns("PBH_NOK_SNL_DT_TOT").Hidden = True
            End If
            If (UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_DT_OVK")) Then
                UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns("PBH_DT_OVK").Hidden = True
            End If
            If (UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_TMS_PRINT")) Then
                UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns("PBH_TMS_PRINT").Hidden = True
            End If
            If (UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns.Exists("SODIE_CNT_ID")) Then
                UltraGridHuidigeInbreuken.DisplayLayout.Bands(0).Columns("SODIE_CNT_ID").Hidden = True
            End If


            'UltraGridVastgesteldeInbreuken
            If (UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_NOK_SNL_DT_VAN")) Then
                UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns("PBH_NOK_SNL_DT_VAN").Hidden = True
            End If
            If (UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_NOK_SNL_DT_TOT")) Then
                UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns("PBH_NOK_SNL_DT_TOT").Hidden = True
            End If
            If (UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_DT_OVK")) Then
                UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns("PBH_DT_OVK").Hidden = True
            End If
            If (UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns.Exists("PBH_TMS_PRINT")) Then
                UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns("PBH_TMS_PRINT").Hidden = True
            End If
            If (UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns.Exists("SODIE_CNT_ID")) Then
                UltraGridVastgesteldeInbreuken.DisplayLayout.Bands(0).Columns("SODIE_CNT_ID").Hidden = True
            End If

            UltraGridVastgesteldeInbreuken.UpdateData()
            UltraGridHuidigeInbreuken.UpdateData()

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - bindRegistratie()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindVorigeInbreuken(ByVal individu As Integer)
        'Doel: toon vastgestelde inbreuken van de laatste 2 jaar
        'Auteur: Koen Heye - mei 2006
        Try
            Me._dataVastgesteldeInbreuken.Clear()
            _controller = New ControllerGetData
            Me._dataVastgesteldeInbreuken.Merge(Me._controller.GetVastgesteldeInbreuken(individu, Me._idRegistratie))
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - BindDdlAfdelingen()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindDdlAfdelingen()
        Try
            _controller = New ControllerGetData
            Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - BindDdlAfdelingen()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindUltraOptionSets()
        Try
            _controller = New ControllerGetData

            Me._dataBewakingDup.Merge(Me._controller.GetBewakingDup())
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - BindUltraOptionSets" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub bindAndSetBEWPersoneel()
        Try
            _controller = New ControllerGetData

            If _idRegistratie = -1 Then 'nieuwe registratie - naco 08/02/2017
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneelActief())
            Else
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneel())
            End If

            Me.UserControlGeneralFunctionsInbreukRegl.setPersoneelData(_dataBEWPersoneel)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBijlagen()
        Try
            Me.UserControlGeneralFunctionsInbreukRegl.setBijlageData(_dataRegInbreukRegl.BBBYLG)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBestemmelingen()
        Try
            Me.UserControlGeneralFunctionsInbreukRegl.setBestemmelingenData(_dataRegInbreukRegl.BBBST)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Button and Optionset Eventhandlers"

    Private Sub ButtonKiesFirma_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonKiesFirma.Click
        Try
            Using f_firma = New FormBewakingFirmas
                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    Dim firma As TDSFirmas.BBFRMRow = f_firma.Firma

                    TextBoxFirmaId.Text = CStr(firma.ID_FRM)
                    If Not firma.IsNM_FRMNull Then
                        LabelFirmaNaam.Text = firma.NM_FRM
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonOvertreder_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonKiesPersoonOvertreder.Click
        Try
            Using f_ind = New FormIndividuen
                f_ind.ShowDialog()

                If Not f_ind.Canceled Then
                    Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                    UltraMaskedEditStamnrOvertreder.Text = CStr(individu.ID_IND)
                    If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                        LabelNaamOvertreder.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                    ElseIf Not individu.IsNM_INDNull Then
                        LabelNaamOvertreder.Text = individu.NM_IND.Trim
                    ElseIf Not individu.IsVNM_INDNull Then
                        LabelNaamOvertreder.Text = individu.VNM_IND.Trim
                    Else
                        LabelNaamOvertreder.Text = ""
                    End If
                    If Not individu.IsAD_INDNull Then
                        LabelAdresOvertreder.Text = individu.AD_IND.Trim
                    End If
                    If Not individu.IsPO_COD_WNPL_INDNull Then
                        LabelAdresOvertreder.Text &= " " & individu.PO_COD_WNPL_IND.Trim
                    End If
                    If Not individu.IsWNPL_INDNull Then
                        LabelAdresOvertreder.Text &= " " & individu.WNPL_IND.Trim
                    End If

                    If Not individu.IsNR_IND_WKGNull And Not individu.IsNM_JUR_VENONull Then
                        GetFirmAutomatically(individu.NR_IND_WKG)
                    Else
                        LabelFirmaNaam.Text = ""
                        TextBoxFirmaId.Text = ""
                        ToolTip1.SetToolTip(LabelFirmaNaam, "")
                    End If

                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesVoertuig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonKiesVoertuig.Click
        Try
            Using f_voer = New FormBewakingVoertuig
                f_voer.ShowDialog()

                If Not f_voer.Canceled Then
                    Dim voertuig As TDSVoertuigen.BBTSPRow = f_voer.Voertuig

                    TextBoxVoertuigId.Text = CStr(voertuig.ID_TSP)
                    If Not voertuig.IsID_EIG_TSPNull Then
                        LabelStamnrEigenaar.Text = CStr(voertuig.ID_EIG_TSP)
                        If Not voertuig.IsNM_INDNull And Not voertuig.IsVNM_INDNull Then
                            LabelNaamEigenaar.Text = voertuig.NM_IND & " " & voertuig.VNM_IND
                        ElseIf Not voertuig.IsNM_INDNull Then
                            LabelNaamEigenaar.Text = voertuig.NM_IND
                        ElseIf Not voertuig.IsVNM_INDNull Then
                            LabelNaamEigenaar.Text = voertuig.VNM_IND
                        Else
                            LabelNaamEigenaar.Text = ""
                        End If
                    ElseIf Not voertuig.IsID_FRM_TSPNull Then
                        LabelStamnrEigenaar.Text = "Firma"
                        If Not voertuig.IsNM_FRMNull Then
                            LabelNaamEigenaar.Text = voertuig.NM_FRM
                        End If
                    End If
                    If Not voertuig.IsSCF_TY_TSPNull Then
                        LabelAardVoertuig.Text = voertuig.SCF_TY_TSP
                    End If
                    If Not voertuig.IsSCF_MRK_TSPNull Then
                        LabelMerkVoertuig.Text = voertuig.SCF_MRK_TSP
                    End If
                    If Not voertuig.IsPL_NR_TSPNull Then
                        LabelNummerplaatVoertuig.Text = voertuig.PL_NR_TSP
                    End If
                    If Not voertuig.IsNR_CHAS_TSPNull Then
                        LabelChassisnummerVoertuig.Text = voertuig.NR_CHAS_TSP
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOverzicht_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonOverzicht.Click
        Try
            FormManager.Current.OpenFormOverzichtBewakingRegistratieEntity(False, True, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonSluiten.Click
        Try
            setStatus("")
            Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAnnuleer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonAnnuleer.Click
        'Doel: als nieuwe interventie => terug alles leeg zetten
        '      als je bestaande interventie aan het wijzigen was: terug alles zetten zoals het in de database staat
        'Auteur: naco - 21/04/2006

        Try
            Me.setStatus("")
            Call Me.bindRegistratie()
            'terug ophalen en tonen (zo zit je met de juiste data uit de database)
            Me.setStatus("De wijzigingen werden ongedaan gemaakt")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBrandweerInterventie - UltraButtonAnnuleer_Click" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridVastgesteldeInbreuken_InitializeRow(ByVal sender As Object, ByVal e As InitializeRowEventArgs) _
        Handles UltraGridVastgesteldeInbreuken.InitializeRow
        Try
            e.Row.Cells("ID_VLG_REG").Value = CStr(e.Row.Cells("VLG_REG_JR_BPL").Value) & " / " &
                                               Year(CType(e.Row.Cells("TMS_OPS_REG").Value, DateTime))
            e.Row.Cells("TMS_INC").Value = CType(e.Row.Cells("TMS_INC").Value, DateTime).ToShortDateString

            If CStr(e.Row.Cells("ID_VLG_REG").Value) = TextBoxVerslagnummer.Text Then
                e.Row.Appearance.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonNewInbreuk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonNewInbreuk.Click
        Try
            If (UltraGridHuidigeInbreuken.Rows.Count > 0) Then
                MessageBox.Show("Het is niet mogelijk om meerdere inbreuken te toe te kennen aan één enkel verslag." & System.Environment.NewLine &
                                "Gelieve per inbreuk een apart verslag aan te maken.", "Foutief toekennen inbreuk", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using f = New FormBewakingInbreuken
                f.ShowDialog()

                If Not f.Canceled Then
                    Dim inbreuk = f.Inbreuk

                    'id reg is nog niet goed
                    _dataRegInbreukRegl.BBINBRVA.AddBBINBRVARow(_idRegistratie, inbreuk.ID_ART_INBR, 0, 0, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing,
                                                                Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, inbreuk.NR_ART_INBR, inbreuk.SCF_ART_INBR, Nothing, Nothing, Nothing)
                End If
            End Using

            enableInbreukButtons()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonDeleteBijlage_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonDeleteBijlage.Click
        Try
            'Doel:   Verwijdert een geselecteerde rij uit de grid
            'Auteur: Koen - Rajiv - 22/05/2006
            If UltraGridHuidigeInbreuken.ActiveRow.Activated = True Then
                UltraGridHuidigeInbreuken.DeleteSelectedRows()
            End If
            enableInbreukButtons()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Functions"

    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, TDSConfiguratie))
        UserControlGeneralFunctionsInbreukRegl.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, TDSIndividuen))
        UserControlGeneralFunctionsInbreukRegl.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub

    Private Sub enableInbreukButtons()
        If UltraGridHuidigeInbreuken.Rows.Count > 0 Then
            ButtonDeleteBijlage.Enabled = True
        Else
            ButtonDeleteBijlage.Enabled = False
        End If
    End Sub

    Private Sub setLabelsVerplicht()
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelOvertreder.Text &= " *"
        LabelEigenaar.Text &= " *"
        LabelBenadeelde.Text &= " *"
        LabelFirma.Text &= " *"
        LabelOvertrederType.Text &= " *"
    End Sub

    Private Function GetAfdeling() As String
        Return LabelAfdelingOvertreder.Text
    End Function

#End Region

#Region "User Control"

    Private Sub UserControlGeneralFunctionsInbreukReglementen_NieuwBestemmelingen(ByVal sender As Object, ByVal e As EventArgs) Handles UserControlGeneralFunctionsInbreukRegl.NieuwBestemmelingen
        Try
            Using f_ind = New FormIndividuen(True, GetAfdeling())
                f_ind.ShowDialog()

                If Not f_ind.Canceled Then
                    Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                    If Not individu.IsAD_EMAL_INDNull Then
                        UserControlGeneralFunctionsInbreukRegl.addBestemmeling(_idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                    Else
                        UserControlGeneralFunctionsInbreukRegl.addBestemmeling(_idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Textboxevents"

    Private Sub UltraMaskedEditStamnrOvertreder_Leave(ByVal sender As Object, ByVal e As EventArgs) _
        Handles UltraMaskedEditStamnrOvertreder.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrOvertreder, Me.LabelNaamOvertreder,
                                       Me.LabelAdresOvertreder)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)

        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrOvertreder_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) _
        Handles UltraMaskedEditStamnrOvertreder.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditStamnrOvertreder.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrOvertreder,
                                               Me.LabelNaamOvertreder,
                                               Me.LabelAdresOvertreder)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try

    End Sub

    Private Sub handleAfterStamnrLeave(ByRef UltraMaskedEditStamnr As UltraMaskedEdit, ByRef LabelNaam As Label,
                                        ByRef LabelAdres As Label)
        If UltraMaskedEditStamnr.Text <> "" Then
            Try
                Dim stamnr As Integer = CInt(UltraMaskedEditStamnr.Text)
                If FormManager.Current Is Nothing Then
                    'MDI-form gesloten
                    Exit Sub
                Else
                    Dim individu As TDSIndividuen.BBINDRow =
                            CType(FormManager.Current.DataIndividuen, TDSIndividuen).BBIND.FindByID_IND(CInt(stamnr))
                    If individu Is Nothing Then
                        LabelNaam.Text = ""
                        If Not LabelAdres Is Nothing Then
                            LabelAdres.Text = ""
                        End If
                        UltraMaskedEditStamnr.Text = ""
                        MessageBox.Show("Het stamnummer " & stamnr & " werd niet teruggevonden.",
                                         "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        UltraMaskedEditStamnr.Focus()
                        Exit Sub
                    ElseIf Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                        LabelNaam.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                    ElseIf Not individu.IsNM_INDNull Then
                        LabelNaam.Text = individu.NM_IND.Trim
                    ElseIf Not individu.IsVNM_INDNull Then
                        LabelNaam.Text = individu.VNM_IND.Trim
                    Else
                        LabelNaam.Text = ""
                    End If

                    If Not LabelAdres Is Nothing Then
                        If Not individu.IsAD_INDNull Then
                            LabelAdres.Text = individu.AD_IND.Trim
                        End If
                        If Not individu.IsPO_COD_WNPL_INDNull Then
                            LabelAdres.Text &= " " & individu.PO_COD_WNPL_IND.Trim
                        End If
                        If Not individu.IsWNPL_INDNull Then
                            LabelAdres.Text &= " " & individu.WNPL_IND.Trim
                        End If
                    End If

                    If UltraMaskedEditStamnr.Name = Me.UltraMaskedEditStamnrOvertreder.Name Then
                        If individu.IsSAP_AFDNull Then
                            LabelAfdelingOvertreder.Text = ""
                        Else
                            LabelAfdelingOvertreder.Text = individu.SAP_AFD
                        End If
                    End If

                    If Not individu.IsNR_IND_WKGNull And Not individu.IsNM_JUR_VENONull Then
                        GetFirmAutomatically(individu.NR_IND_WKG)
                    Else
                        LabelFirmaNaam.Text = ""
                        TextBoxFirmaId.Text = ""
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & " " & ex.StackTrace, "Fout", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
            End Try
        Else
            LabelNaam.Text = ""
            If Not LabelAdres Is Nothing Then
                LabelAdres.Text = ""
            End If
        End If
    End Sub

    Private Sub GetFirmAutomatically(ByVal aNR_IND_WKG As Integer)
        'nr_firma en nm_firma automatisch ophalen (indien SAP firmanr is gekend in BBFRM en indien firmanr van stamnr = SAP firmanr)
        'april 2017 - naco
        Try

            TextBoxFirmaId.Text = "" 'zeker leeg zetten, als je bv. een 2de stamnr ingeeft (na bv. foutieve ingave)
            LabelFirmaNaam.Text = ""

            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            Dim nrID_FRM As Integer = 0
            Dim strNM_FRM As String = ""

            ToolTip1.SetToolTip(LabelFirmaNaam, "")

            nrID_FRM = proxy.GetFirm_ID_FRMforSAPnr(aNR_IND_WKG)
            strNM_FRM = proxy.GetFirm_NM_FRMforSAPnr(aNR_IND_WKG)

            TextBoxFirmaId.Text = CStr(nrID_FRM)
            LabelFirmaNaam.Text = strNM_FRM

            If nrID_FRM <> 0 Then
                ToolTip1.SetToolTip(LabelFirmaNaam, "SAP firmanr: " & aNR_IND_WKG & " (" & strNM_FRM & ")")
            Else
                ToolTip1.SetToolTip(LabelFirmaNaam, "")
            End If

            If Microsoft.VisualBasic.Left(LabelFirmaNaam.Text, 7).ToUpper = "ARCELOR" Then
                UltraComboOvertrederType.Value = 1 'ArcelorMittal overtreder
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding - GetFirmAutomatically", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormBewakingInbreukReglementen_Closed(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Closed
        Try
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Opslaan"

    Private Sub UltraButtonOpslaan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonOpslaan.Click
        'Doel: nieuwe inbreuk op reglementen toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 05/05/2006
        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus("De Inbreuk op Reglementen werd succesvol opgeslagen")
            Else
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub opslaanRegistratie()
        'Doel:   opslaan 'Inbreuk reglementen'
        'Auteur: Koen Heye - mei 2006

        Cursor.Current = Cursors.WaitCursor
        Dim proxy As New BBWServiceManagementServicesProxy

        Dim dsInbreukRegl As New TDSInbreukRegl
        Dim drRegistratie As TDSInbreukRegl.BBBEWREGRow
        Dim drInbreukRegl As TDSInbreukRegl.BBINBRRGRow
        Dim drInbreuken As TDSInbreukRegl.BBINBRVARow
        Dim drBylagen As TDSInbreukRegl.BBBYLGRow
        Dim drBestemmelingen As TDSInbreukRegl.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try

            dsInbreukRegl.BBBST.DataSet.Clear()
            dsInbreukRegl.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsInbreukRegl.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsInbreukRegl.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd
            If (UserControlGeneralFunctionsInbreukRegl.CheckBestemmelingen(dsBest) = True) Then
                _controller = New ControllerGetData

                If Me._idRegistratie = -1 Then 'nieuw Inbreuk op reglementen

                    drRegistratie = dsInbreukRegl.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg,
                                                         volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsInbreukRegl.Opsteller
                        .ID_TY_REG = 4
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsInbreukRegl.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsInbreukRegl.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsInbreukRegl.GetVeraReference
                        .VerslagContractantYN = UserControlGeneralFunctionsInbreukRegl.GetReportContractant
                    End With
                    dsInbreukRegl.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Inbreuk op reglementen
                    '-------------------------
                    drInbreukRegl = dsInbreukRegl.BBINBRRG.NewBBINBRRGRow
                    With drInbreukRegl
                        .ID_REG = id_reg
                        .ID_INBR = CInt(UltraMaskedEditStamnrOvertreder.Text)
                        If TextBoxVoertuigId.Text.Trim = "" Then
                            .SetID_TSPNull()
                        Else
                            .ID_TSP = CInt(TextBoxVoertuigId.Text)
                        End If
                        If Not TextBoxVerklaring.Text = "" Then
                            .VKLR_INBR = TextBoxVerklaring.Text
                        End If
                        If Not TextBoxOpmerkingen.Text = "" Then
                            .OPM_EX_INBR_VSF = TextBoxOpmerkingen.Text
                        End If
                        If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                            .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                        End If
                        If Not TextBoxFirmaId.Text.Trim = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        If Not UltraComboOvertrederType.Value Is Nothing Then
                            .ID_INBR_IND_TY = CType(Me.UltraComboOvertrederType.Value, Integer)
                        End If
                    End With

                    dsInbreukRegl.BBINBRRG.AddBBINBRRGRow(drInbreukRegl)

                    '3. Inbreuken => grid overlopen en New rows toevoegen
                    '-------------------------------------------------
                    Dim drGrid As TDSRegInbreukRegl.BBINBRVARow
                    For Each drGrid In _dataRegInbreukRegl.BBINBRVA
                        drInbreuken = dsInbreukRegl.BBINBRVA.NewBBINBRVARow
                        drInbreuken.ID_REG = id_reg
                        drInbreuken.ID_ART_INBR = drGrid.ID_ART_INBR
                        drInbreuken.SNL_OK = drGrid.SNL_OK
                        drInbreuken.SNL_REG = drGrid.SNL_REG
                        dsInbreukRegl.BBINBRVA.AddBBINBRVARow(drInbreuken)
                    Next

                    '4. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBYL As TDSRegInbreukRegl.BBBYLGRow 'Dien - aug2008 - migratie 2008
                    Dim drByl As DataRow
                    Dim chronicleID As String
                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsInbreukRegl.BBBYLG.NewBBBYLGRow
                        drBylagen.ID_BYLG = CInt(drByl.Item("ID_BYLG"))
                        drBylagen.ID_REG = id_reg
                        drBylagen.PLA_BYLG = CType(drByl.Item("PLA_BYLG"), String)
                        If Not drByl.Item("SCF_BYLG") Is DBNull.Value Then
                            drBylagen.SCF_BYLG = CType(drByl.Item("SCF_BYLG"), String)
                        Else
                            drBylagen.SCF_BYLG = ""
                        End If
                        'Wanneer het chronicleID nog niet gekend is, betekent dit dat het document nog niet geïmporteerd is in documentum.
                        If drByl.Item("ID_DOC") Is DBNull.Value Then
                            chronicleID = UploadInbreukReglementBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If

                        dsInbreukRegl.BBBYLG.AddBBBYLGRow(drBylagen)
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegInbreukRegl.BBBSTRow 'Dien - aug2008 - migratie 2008
                    Dim drBest As DataRow
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsInbreukRegl.BBBST.NewBBBSTRow
                        drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST"))
                        drBestemmelingen.ID_IND = CInt(drBest.Item("ID_IND"))
                        drBestemmelingen.ID_REG = id_reg
                        drBestemmelingen.NM_IND = CType(drBest.Item("NM_IND"), String)
                        drBestemmelingen.VNM_IND = CType(drBest.Item("VNM_IND"), String)
                        If drBest.Item("AD_EMAL_IND") Is DBNull.Value Then
                            drBestemmelingen.AD_EMAL_IND = ""
                        Else
                            drBestemmelingen.AD_EMAL_IND = CType(drBest.Item("AD_EMAL_IND"), String)
                        End If

                        dsInbreukRegl.BBBST.AddBBBSTRow(drBestemmelingen)
                    Next

                    '5. Opmerkingen en datums verzending
                    '-----------------------------------
                    With drRegistratie
                        'Verzending goed te keuren verslag
                        If Not UltraDateTimeEditorVerzending.Value Is Nothing Then
                            .DT_VZ_RAP_NW = CType(UltraDateTimeEditorVerzending.Value, DateTime)
                        Else
                            .SetDT_VZ_RAP_NWNull()
                        End If
                        If Not TextBoxVerzending.Text = "" Then
                            .OPM_OPS = TextBoxVerzending.Text
                        End If
                    End With
                Else 'bestaand inbreuk op reglementen
                    dsInbreukRegl.Merge(Me._controller.GetRegInbreukRegl(Me._idRegistratie))
                    drRegistratie = dsInbreukRegl.BBBEWREG.FindByID_REG(Me._idRegistratie)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsInbreukRegl.Opsteller
                        .ID_TY_REG = 4
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsInbreukRegl.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraReference = UserControlGeneralFunctionsInbreukRegl.GetVeraReference
                        .VeraLink = UserControlGeneralFunctionsInbreukRegl.GetVeraLink
                        .VerslagContractantYN = UserControlGeneralFunctionsInbreukRegl.GetReportContractant
                    End With

                    '2. Inbreuk op reglementen
                    '-------------------------
                    drInbreukRegl = CType(dsInbreukRegl.BBINBRRG.Rows(0), TDSInbreukRegl.BBINBRRGRow)
                    With drInbreukRegl
                        .ID_REG = Me._idRegistratie
                        .ID_INBR = CInt(UltraMaskedEditStamnrOvertreder.Text)
                        If TextBoxVoertuigId.Text.Trim = "" Then
                            .SetID_TSPNull()
                        Else
                            .ID_TSP = CInt(TextBoxVoertuigId.Text)
                        End If

                        If Not TextBoxVerklaring.Text = "" Then
                            .VKLR_INBR = TextBoxVerklaring.Text
                        End If
                        If Not TextBoxOpmerkingen.Text = "" Then
                            .OPM_EX_INBR_VSF = TextBoxOpmerkingen.Text
                        End If
                        If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                            .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                        End If
                        If Not TextBoxFirmaId.Text.Trim = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        If Not UltraComboOvertrederType.Value Is Nothing Then
                            .ID_INBR_IND_TY = CType(Me.UltraComboOvertrederType.Value, Integer)
                        End If
                    End With

                    '3. Inbreuken => grid overlopen en New rows toevoegen
                    '-------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    For Each drInbreuken In dsInbreukRegl.BBINBRVA.Rows
                        If _dataRegInbreukRegl.BBINBRVA.Select("ID_INBRVA = " & drInbreuken.ID_INBRVA).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsInbreukRegl.BBINBRVA.Select("ID_INBRVA = " & drInbreuken.ID_INBRVA).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drInbreuken.Delete()
                                'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGrid As TDSRegInbreukRegl.BBINBRVARow
                    For Each drGrid In _dataRegInbreukRegl.BBINBRVA
                        If drGrid.RowState = DataRowState.Added Then
                            drInbreuken = dsInbreukRegl.BBINBRVA.NewBBINBRVARow
                            drInbreuken.ID_REG = Me._idRegistratie
                            drInbreuken.ID_ART_INBR = drGrid.ID_ART_INBR
                            drInbreuken.SNL_OK = drGrid.SNL_OK
                            drInbreuken.SNL_REG = drGrid.SNL_REG
                            dsInbreukRegl.BBINBRVA.AddBBINBRVARow(drInbreuken)
                        ElseIf drGrid.RowState = DataRowState.Modified Then
                            Dim inbr() As DataRow
                            inbr = dsInbreukRegl.BBINBRVA.Select("ID_INBRVA = " & drGrid.ID_INBRVA)
                            If inbr.Length > 0 Then
                                drInbreuken = DirectCast(inbr(0), TDSInbreukRegl.BBINBRVARow)
                                drInbreuken.ID_REG = Me._idRegistratie
                                drInbreuken.ID_ART_INBR = drGrid.ID_ART_INBR
                                drInbreuken.SNL_OK = drGrid.SNL_OK
                                drInbreuken.SNL_REG = drGrid.SNL_REG
                            End If
                        End If
                    Next

                    '4. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBylg As TDSInbreukRegl.BBBYLGRow

                    For Each drBylg In dsInbreukRegl.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsInbreukRegl.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                If (Not drBylg.IsID_DOCNull) Then
                                    'Bijhouden van de verwijderde chronicleID's in een array zodat deze op het einde (nadat het bewaren is gelukt)
                                    'kunnen verwijderd worden uit documentum
                                    arrayOfDeletedChronicleID.Add(drBylg.ID_DOC)
                                End If
                                drBylg.Delete()
                                'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBYLG As DataRow
                    Dim chronicleID As String = ""
                    For Each drGridBYLG In dsByl.Tables(0).Rows
                        If (drGridBYLG.RowState <> DataRowState.Deleted) Then
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                chronicleID = UploadInbreukReglementBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If
                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsInbreukRegl.BBBYLG.NewBBBYLGRow

                            drBylagen.ID_REG = Me._idRegistratie
                            drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                            If Not drGridBYLG.Item("SCF_BYLG") Is DBNull.Value Then
                                drBylagen.SCF_BYLG = CType(drGridBYLG.Item("SCF_BYLG"), String)
                            Else
                                drBylagen.SCF_BYLG = ""
                            End If
                            If chronicleID <> "" Then
                                drBylagen.ID_DOC = chronicleID
                            End If

                            dsInbreukRegl.BBBYLG.AddBBBYLGRow(drBylagen)

                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsInbreukRegl.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 Then
                                drBylagen = DirectCast(arrBylg(0), TDSInbreukRegl.BBBYLGRow)

                                drBylagen.ID_REG = Me._idRegistratie
                                drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                                If Not drBylg.Item("SCF_BYLG") Is DBNull.Value Then
                                    drBylagen.SCF_BYLG = CType(drGridBYLG.Item("SCF_BYLG"), String)
                                Else
                                    drBylagen.SCF_BYLG = ""
                                End If
                                If chronicleID <> "" Then
                                    drBylagen.ID_DOC = chronicleID
                                End If
                            End If
                        ElseIf drGridBYLG.RowState = DataRowState.Unchanged Then
                            'Wanneer een document nog niet is doorgestuurd naar documentum,
                            'mag dit alsnog gebeuren ook al is er niets veranderd aan de registratie
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                Dim arrBylg() As DataRow
                                arrBylg = dsInbreukRegl.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), TDSInbreukRegl.BBBYLGRow)
                                    If chronicleID <> "" Then
                                        drBylagen.ID_DOC = chronicleID
                                    End If
                                End If
                            End If
                        End If

                    Next

                    '5. Bestemmelingen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBest As TDSInbreukRegl.BBBSTRow

                    For Each drBest In dsInbreukRegl.BBBST.Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsInbreukRegl.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete()
                                'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drGridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsInbreukRegl.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._idRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsInbreukRegl.BBBST.AddBBBSTRow(drBestemmelingen)
                        End If
                    Next

                    '6. Opmerkingen en datums verzending
                    '-----------------------------------
                    With drRegistratie
                        'Verzending goed te keuren verslag
                        If Not UltraDateTimeEditorVerzending.Value Is Nothing Then
                            .DT_VZ_RAP_NW = CType(UltraDateTimeEditorVerzending.Value, DateTime)
                        Else
                            .SetDT_VZ_RAP_NWNull()
                        End If
                        If Not TextBoxVerzending.Text = "" Then
                            .OPM_OPS = TextBoxVerzending.Text
                        End If
                        'Verzending goedgekeurd verslag
                        If Not UltraDateTimeEditorGoedkeuring.Value Is Nothing Then
                            .DT_OK = CType(UltraDateTimeEditorGoedkeuring.Value, DateTime)
                        End If
                        If Not TextBoxGoedkeuring.Text = "" Then
                            .OPM_CHEF_PO = TextBoxGoedkeuring.Text
                        End If
                        'Verzending bestemmelingen
                        If Not UltraDateTimeEditorBestemmelingen.Value Is Nothing Then
                            .DT_VZ_BST = CType(UltraDateTimeEditorBestemmelingen.Value, DateTime)
                        End If
                        If Not TextBoxVerzendingBestemmelingen.Text = "" Then
                            .OPM_HFD_BRW = TextBoxVerzendingBestemmelingen.Text
                        End If
                    End With

                End If

                'Effectief bewaren
                '-----------------
                'getChanges() stuurt enkel de gewijzigde records door over de webservice
                Dim ds As New TDSInbreukRegl
                ds.Merge(dsInbreukRegl.GetChanges)

                proxy.RegisterRegistratieInbreukRegl(ds, System.Environment.UserName)
                dsInbreukRegl.AcceptChanges()

                'als het om een nieuw inbreuk op reglementen gaat, worden volgende velden ingevuld
                If Me._idRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " &
                                                Year(Me.UserControlGeneralFunctionsInbreukRegl.getOpstelDatum)
                    'id instellen zodat er bij het refreshen geen nieuw scherm getoond wordt
                    Me._idRegistratie = id_reg
                End If

                'de bewaarde registratie opnieuw gaan tonen
                '------------------------------------------
                'eerst de grids van kosten en interventietijden terug leeg maken
                _dataRegInbreukRegl.BBINBRVA.Clear()
                _dataRegInbreukRegl.BBINBRRG.Clear()

                Call Me.bindRegistratie()
                'terug ophalen en tonen (zo zit je met de juiste data uit de database)

                If arrayOfDeletedChronicleID.Count > 0 Then
                    For Each aChronicleId As String In arrayOfDeletedChronicleID
                        Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                    Next
                End If

            End If
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBrandweerInbreukReglementen - ButtonOpslaan_Click" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        'boodschap weergeven
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    'Adjusted of code for Sodie-Interaction
    'this function was found to be not IN-USE
    ' June 2013 : Stijn Vranken
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    'Private Sub opslaanSodie()
    '    'Doel:   Opslaan contact voor SoDie
    '    'Auteur: Lawrence Verbruggen - april 2011

    '    Cursor.Current = Cursors.WaitCursor
    '    Dim proxy As New BBWServiceManagementServicesProxy
    '    Try
    '        proxy.InsertSoDie(CInt(UltraMaskedEditStamnrOvertreder.Text), CInt(_idRegistratie))
    '        Cursor.Current = Cursors.Default
    '    Catch ex As Exception
    '        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
    '                         "Form: FormBrandweerInbreukReglementen - ButtonOpslaan_Click" & vbCrLf &
    '                         "Message: " & ex.Message & vbCrLf &
    '                         "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
    '                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End Try
    'End Sub

    Private Function UploadInbreukReglementBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) _
        As String
        'Doel:   Uploaden van de bijlage van een aanrijdingsverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(UltraDateTimeEditorDatum.DateTime) & "/" & volgnr & " - " & LabelTitel.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String =
                _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BEWAKING", "FolderPathDocumentum").WD()

        Return _
            BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName,
                                                documentumFolderPath)

    End Function

    Private Function controleVeldenOK() As Boolean
        Dim errorBool As Boolean = True
        If UltraDateTimeEditorDatum.Text = "__/__/____" Or UltraDateTimeEditorDatum.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditUur.Text = "__:__" Or UltraMaskedEditUur.Text = ":" Then
            errorBool = False
        End If
        If TextBoxPlaats.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditStamnrOvertreder.Text = "" Then
            errorBool = False
        End If
        If TextBoxVoertuigId.Text = "" Then
            errorBool = False
        End If
        If Not UserControlGeneralFunctionsInbreukRegl.checkPersoneelOK Then
            errorBool = False
        End If
        If UltraComboOvertrederType.SelectedRow Is Nothing Then
            errorBool = False
        End If

        Return errorBool
    End Function

#End Region

#Region "Afdrukken rapport"

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles UltraButtonAfdrukken.Click
        Try
            Me.showReport()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBrandweerInterventie - UltraButtonAfdrukken_Click" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub showReport()
        'Doel: print preview van het interventierapport tonen
        'Auteur: Stein Peeters - 20/07/2006
        'Opgelet: afdrukken kan pas als de interventie is opgeslaan! Dus eerst vragen om de interventie te bewaren
        Try
            Dim f_rap As New FormRapportenPreview

            If Me._idRegistratie = -1 Then
                'vragen om te bewaren
                Dim dr As New DialogResult
                dr = MessageBox.Show("De registratie dient eerst opgeslagen te worden. Wilt u het nu opslaan?",
                                      "Opslaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button1)

                If dr = DialogResult.Yes Then
                    'opslaan
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        If controleVeldenOK() Then
                            Me.opslaanRegistratie()

                            'rapport tonen
                            f_rap.InterventieID = Me._idRegistratie
                            f_rap.Show()
                            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                                               "RegistratieInbreukRegl",
                                               "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "RegistratieInbreukRegl")
                            'report.AddParameter("ID_REG", Me._IDRegistratie)
                            'f_rap.ExportPDF()

                            Me.setStatus("De registratie werd succesvol opgeslagen")
                        Else
                            MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK,
                                             MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                         "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf &
                                         "Message: " & ex.Message & vbCrLf &
                                         "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                    Cursor.Current = Cursors.Default
                End If
            Else
                If controleVeldenOK() Then
                    'rapport tonen
                    f_rap.InterventieID = Me._idRegistratie
                    f_rap.Show()
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieInbreukRegl", "ID_REG",
                                       CStr(Me._idRegistratie), "", "", "", "")

                    'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking")
                    'report.AddParameter("ID_REG", Me._IDRegistratie)
                    'f_rap.ExportPDF()
                Else
                    MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBrandweerInterventie - showReport" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

#End Region


#Region "Buttons verzending"

    Private Sub ButtonVerzendingBBW_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonVerzendingBBW.Click
        'Doel:   verstuur verslag naar postoverste
        'Auteur: Koen Heye - mei 2006 - naco - 21/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            If TextBoxVerslagnummer.Text = "" Then
                MessageBox.Show("Gelieve eerst een registratie aan te maken en/of op te slaan",
                                 "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            ElseIf Not controleVeldenOK() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorVerzending.Value = Now
                Me.opslaanRegistratie()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf &
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf &
                            "Registratietype:   " & LabelTitel.Text & vbCrLf &
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf &
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf &
                            "Opsteller:         " & UserControlGeneralFunctionsInbreukRegl.getOpsteller & vbCrLf &
                            vbCrLf &
                            "Opmerking Opsteller: " & TextBoxVerzending.Text

                Dim mailTo As New ArrayList
                mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Postoverste").WD)
                Me.sendMail(mailTo, textMail,
                             "Nieuwe registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text,
                             pathsAttachment)

                Me.setStatus("Het registratieverslag werd succesvol verzonden")
                If FormManager.Current.Bewaking Then
                    UltraButtonOpslaan.Enabled = False
                End If
                ButtonTerugZenden.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - ButtonVerzendingBBW_Click()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonGoedkeuring_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - naco - 21/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorGoedkeuring.Value = Now
            Me.opslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Verzending").WD & vbCrLf
            textMail &= vbCrLf &
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf &
                        "Registratietype:   " & LabelTitel.Text & vbCrLf &
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf &
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf &
                        "Opsteller:         " & UserControlGeneralFunctionsInbreukRegl.getOpsteller & vbCrLf & vbCrLf &
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf &
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Verantwoordelijke").WD)
            Me.sendMail(mailTo,
                         textMail,
                         "Goedgekeurde registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text,
                         pathsAttachment)

            Me.setStatus("De registratie werd succesvol goedgekeurd")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - ButtonGoedkeuring_Click()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonTerugZenden_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonTerugZenden.Click
        'Doel:   Terugsturen verslag naar groepsusernaam van bewaking
        'Auteur: Mieke Duynslager - mei 2007

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            Me.opslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Terugzenden").WD & vbCrLf & vbCrLf
            textMail &= "Onderstaand verslag kan niet worden goedgekeurd. Gelieve het verslag te wijzigen." & vbCrLf &
                        vbCrLf &
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf &
                        "Registratietype:   " & LabelTitel.Text & vbCrLf &
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf &
                        "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf &
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf &
                        "Opsteller:         " & UserControlGeneralFunctionsInbreukRegl.getOpsteller & vbCrLf & vbCrLf &
                        "Opmerking: " & TextBoxGoedkeuring.Text

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Bewaking").WD)
            Me.sendMail(mailTo,
                         textMail,
                         "Teruggezonden registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text,
                         pathsAttachment)

            ButtonTerugZenden.Enabled = False
            ButtonVerzendingBBW.Enabled = True
            Me.setStatus("De registratie werd teruggestuurd.")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - ButtonTerugZenden_Click()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonVerzendingBest_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonVerzendingBest.Click
        'Doel:   verstuur verslag naar bestemmelingen
        'DUMI: 19/9/2007: Er bestaan twee types bestemmelingen. Voor de internen (best) sturen we voor de bijlagen de URL van documentum door.
        'Voor de externe bestemmelingen (specbest) (die niet behoren tot het Arcelor-domein) sturen we de bijlagen als attachment door.
        'Auteur: Koen Heye - mei 2006
        'Wijzigingen: Nancy Coppens - 19/09/2006

        Dim best As New ArrayList
        Dim titelMail As String
        Dim textMail As String
        Dim textMailCHIP As String

        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim specBest As New ArrayList
        Dim textMailURL As String = ""
        Dim specPathsAttachment As New ArrayList
        Dim BBWServiceProxy As New BBWServiceManagementServicesProxy
        Dim dsSpecBest As New TDSBBBSTBY
        Dim drSpecBest As TDSBBBSTBY.BBBSTBYRow
        Dim IsSpecialBest As Boolean = False
        Dim IsNormalBest As Boolean = False

        Try
            For Each bestRow As Component.TDSBBBestemmelingen.BBBSTRow In _
                UserControlGeneralFunctionsInbreukRegl.getDataBestemmelingen.Tables(0).Rows
                If bestRow.RowState = DataRowState.Deleted Then
                    'het kan zijn dat er juist een bestemmeling gedelete is
                Else
                    'Als het om een externe bestemmeling gaat, kunnen de bijlagen niet als URL verstuurd worden, maar als attachment.
                    dsSpecBest.Merge(BBWServiceProxy.GetSpecBestForMailMetBijlage())
                    IsSpecialBest = False
                    For Each drSpecBest In dsSpecBest.Tables(0).Rows
                        If drSpecBest.ID_IND_BST = bestRow.ID_IND Then
                            specBest.Add(bestRow.AD_EMAL_IND)
                            IsSpecialBest = True
                        End If
                    Next
                    If IsSpecialBest = False Then
                        best.Add(bestRow.AD_EMAL_IND)
                        IsNormalBest = True
                    End If
                End If
            Next

            'naco - 01/03/2007
            'controleren of de bijlagen bestaan => anders kan de mail niet verstuurd worden
            For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In _
                UserControlGeneralFunctionsInbreukRegl.getDataBijlagen.Tables(0).Rows
                If bijlageRow.RowState = DataRowState.Deleted Then
                    'het kan zijn dat er juist een bijlage gedelete is
                Else
                    Dim fi As New FileInfo(bijlageRow.PLA_BYLG)
                    If fi.Exists = False Then
                        MessageBox.Show("OPGELET: verslag kan niet doorgemaild worden." & vbCrLf & vbCrLf &
                                         "Bijlage '" & bijlageRow.PLA_BYLG & "' kan niet teruggevonden worden." &
                                         vbCrLf & "Gelieve het path van deze bijlage aan te passen aub.",
                                         "Bijlage niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.setStatus("")
                        Exit Sub
                    End If

                End If
            Next

            If best.Count <> 0 Or specBest.Count <> 0 Then
                Me.opslaanRegistratie()

                Dim bSnelheidsovertreding As Boolean = False
                If (_myProxy Is Nothing) Then
                    _myProxy = New BBWServiceManagementServicesProxy()
                End If
                _dataRegInbreukRegl.AcceptChanges()
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                'Code no longer in use since June 2013
                'Insertion into SoDie should now be possible when printing the document
                'For Each row As TDSRegInbreukRegl.BBINBRVARow In _dataRegInbreukRegl.BBINBRVA.Rows

                '    bSnelheidsovertreding = _myProxy.DetermineSodieInfraction(CInt(row(_dataRegInbreukRegl.BBINBRVA.ID_ART_INBRColumn.ColumnName)))
                'Next

                'If (bSnelheidsovertreding) Then
                '    Me.opslaanSodie()
                'End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                'Eerst rapport exporteren naar PDF-file
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD &
                              "Bewaking" & Year(Now) & "_" & Me._idRegistratie & ".pdf"
                pathsAttachment.Add(pathPDFfile)
                specPathsAttachment.Add(pathPDFfile)

                'Dan mail versturen met PDF-file in attachment
                Dim nullDate As Date
                If CDate(UltraDateTimeEditorBestemmelingen.Value) = nullDate Then 'naco - feb 2013
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Bestemmelingen").WD & vbCrLf 'nieuw verslag
                Else
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "BestemmelingenWijziging").WD & vbCrLf
                End If

                textMailCHIP = textMail & vbCrLf & "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                                "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                                "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                                "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                                "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                                "Opsteller:         " & UserControlGeneralFunctionsInbreukRegl.getOpsteller 'naco - sept 2016

                textMail &= vbCrLf &
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf &
                            "Registratietype:   " & LabelTitel.Text & vbCrLf &
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf &
                            "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf &
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf &
                            "Opsteller:         " & UserControlGeneralFunctionsInbreukRegl.getOpsteller & vbCrLf &
                            vbCrLf &
                            "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf &
                            "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf


                Dim urlString As String

                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In _
                    UserControlGeneralFunctionsInbreukRegl.getDataBijlagen.Tables(0).Rows
                    If bijlageRow.RowState = DataRowState.Deleted Then
                        'het kan zijn dat er juist een bijlage gedelete is
                    Else
                        If (best.Count > 0) Then
                            'juli 2007 - dumi -Als er een chronicleID bestaat voor de bijlage, betekent dit dat het al werd opgeladen in documentum.
                            'Dan kan de url worden samengesteld die de link vormt naar documentum.
                            'vb url: http://svsim045.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0901bad18001a60f&latestflag=y
                            If (Not IsDBNull(bijlageRow.Item("ID_DOC"))) Then
                                urlString =
                                    _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_PRE", "Path").WD &
                                    bijlageRow.ID_DOC &
                                    _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_POST", "Path").WD
                                textMailURL &= "Bijlagen:          " & urlString & vbCrLf
                                'Als het document niet is opgeladen in documentum, dient de bijlage als attachment te worden verstuurd
                            Else
                                pathsAttachment.Add(bijlageRow.PLA_BYLG)
                            End If
                        End If
                        ' Voor de externe bestemmelingen worden de bijlagen steeds als attachment opgestuurd.
                        If (specBest.Count > 0) Then
                            specPathsAttachment.Add(bijlageRow.PLA_BYLG)
                        End If
                    End If
                Next


                f_rap.Show()
                f_rap.ExportPDFBewakingRegistratie(
                    _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                    "RegistratieInbreukRegl",
                    pathPDFfile,
                    Me._idRegistratie)
                f_rap.Dispose()

                If CDate(UltraDateTimeEditorBestemmelingen.Value) = nullDate Then 'naco - feb 2013
                    titelMail = "Nieuwe registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text
                Else
                    titelMail = "Bestaande registratie Bewaking aangepast: " & LabelTitel.Text & " " & TextBoxPlaats.Text
                End If

                If (best.Count > 0) Then
                    Me.sendMail(best, textMail & textMailURL, titelMail, pathsAttachment)
                End If

                If (specBest.Count > 0) Then
                    Me.sendMail(specBest, textMail, titelMail, specPathsAttachment)
                End If

                UltraDateTimeEditorBestemmelingen.Value = Now
                Me.opslaanRegistratie()

                '2. naar CHIP automatisch - sept 2016 - naco
                '-------------------------------------------
                Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(CInt(_dataRegInbreukRegl.BBINBRRG.Rows(0).Item("ID_FRM").ToString))
                'Dim strMailFirmaBBW As String = ""
                'Dim strMailFirmaBBW_Language As String = "NL"

                If intIDFirmSAP > 0 And intIDFirmSAP <> 616206 Then  'SAP firma nr gevonden of  = ArcelorMittal Gent (dan geen mail versturen naar CHIP) - 1001674 = oude ID_FRM BBW
                    cbxVerslagnrCHIP.Checked = True
                    UltraComboFirma.Value = intIDFirmSAP
                    UltraDateTimeEditorNaarCHIP.DateTime = Now

                    Dim strMailToFirm As String
                    'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                    strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP)
                    'If strMailToFirm = "" Then
                    '    'naco - 21/03/20187 kijken of er een BBW mail-adres is ingevuld => SAP firma mail heeft voorrang
                    '    strMailToFirm = strMailFirmaBBW 'eigen bewaard email-adres gebruiken
                    '    strMailFirmaBBW_Language = "" 'eigen bewaarde taal
                    'End If

                    If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                        If TextBoxNaarCHIP.Text = "" Then
                            TextBoxNaarCHIP.Text = Strings.Left("Geen contactpers SAP firma " & intIDFirmSAP & " - " & LabelFirmaNaam.Text & " (" & Now & ")", 100) 'varchar(100)
                        Else
                            TextBoxNaarCHIP.Text = Strings.Left(TextBoxNaarCHIP.Text.Trim & " - Geen contactpers SAP firma " & intIDFirmSAP & " - " & LabelFirmaNaam.Text & " ( " & Now & ")", 100)
                        End If
                        MailBBW.SendMail_CHIP_NoContactPersonFound(intIDFirmSAP, LabelFirmaNaam.Text) 'Preventiedienst verwittigen => zo kan een contactpersoon worden ingevuld in SAP

                    Else 'wel een contactpersoon => mail met verslag in bijlage versturen
                        If TextBoxNaarCHIP.Text = "" Then
                            TextBoxNaarCHIP.Text = Strings.Left("Mail nr " & strMailToFirm & " (" & Now & ")", 100) 'varchar(100)
                        Else
                            TextBoxNaarCHIP.Text = Strings.Left(TextBoxNaarCHIP.Text.Trim & " - Mail nr " & strMailToFirm & " (" & Now & ")", 100)
                        End If

                        'mail versturen
                        MailBBW.sendMailCHIP_ContactPerson(strMailToFirm, textMailCHIP,
                                                           "AM Gent - Verslag bewaking (inbreuk regl) - " & LabelFirmaNaam.Text & " (" & intIDFirmSAP.ToString & ") - " & UltraDateTimeEditorDatum.Text,
                                                           pathPDFfile)
                    End If

                    'update tabel BBBEWREG
                    Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                    proxy.CHIPUpdate(Me._idRegistratie, Me.UltraComboFirma.Value.ToString(), _
                                                            DateTime.Now.Date, Me.TextBoxNaarCHIP.Text)
                Else
                    If intIDFirmSAP <> 616206 Then '616206 = ArcelorMittal Gent => geen msgbox tonen - 1001674 = oude ID_FRM BBW
                        MessageBox.Show("Verslag kan niet automatisch naar firma gestuurd worden en niet naar CHIP portaal." & vbCrLf &
                                        "SAP firmanr niet gekend voor deze firma: " & LabelFirmaNaam.Text & ".", "Verslag automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
                '-------------------------------------------

                Me.setStatus("Registratieverslag succesvol verzonden naar de bestemmelingen")
            Else
                Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")
                MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)

                MessageBox.Show(
                    "Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.",
                    "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - ButtonVerzendingBest_Click()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks>Nancy Coppens - 30/11/2012</remarks>
    Private Sub SendMailIKP()
        Dim strMail As String
        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim specBest As New ArrayList
        Dim specPathsAttachment As New ArrayList

        Try

            Dim urlstring As String = String.Empty
            Dim textMailURL As String = String.Empty
            'op vraag van David Martens - bijlagen uit Documentum hoeven niet meegestuurd te worden (naco - 14/12/2012)
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsInbreukRegl.getDataBijlagen.Tables(0).Rows

            '    'juli 2007 - dumi -Als er een chronicleID bestaat voor de bijlage, betekent dit dat het al werd opgeladen in documentum.
            '    'Dan kan de url worden samengesteld die de link vormt naar documentum.
            '    'vb url: http://svsim045.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0901bad18001a60f&latestflag=y
            '    If (Not IsDBNull(bijlageRow.Item("ID_DOC"))) Then
            '        urlstring = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_PRE", "Path").WD & bijlageRow.ID_DOC & _
            '        _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_POST", "Path").WD
            '        textMailURL &= urlstring & vbCrLf
            '        'Als het document niet is opgeladen in documentum, dient de bijlage als attachment te worden verstuurd
            '    Else
            '        pathsAttachment.Add(bijlageRow.PLA_BYLG)
            '    End If

            'Next


            'Dan mail versturen met PDF-file in attachment
            strMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Bestemmelingen").WD & vbCrLf
            strMail &= vbCrLf &
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf &
                        "Registratietype:   " & LabelTitel.Text & vbCrLf &
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf &
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf &
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf &
                        "Bijlagen:          " & vbCrLf & textMailURL

            'For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In _
            '    UserControlGeneralFunctionsInbreukRegl.getDataBijlagen.Tables(0).Rows

            '    ' Voor de externe bestemmelingen worden de bijlagen steeds als attachment opgestuurd.
            '    If (specBest.Count > 0) Then
            '        specPathsAttachment.Add(bijlageRow.PLA_BYLG)
            '    End If
            'Next

            Dim outlookAppClass As New Outlook.Application
            outlookAppClass.CreateObject("outlook.application")

            Dim olmail As Outlook.MailItem
            olmail = CType(outlookAppClass.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)
            olmail.Subject = "Verslag bewaking ArcelorMittal Gent: " & LabelTitel.Text & " - " & TextBoxPlaats.Text
            olmail.BodyFormat = Outlook.OlBodyFormat.olFormatRichText
            olmail.Body = strMail

            '-> Eerst rapport exporteren naar PDF-file
            pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD &
                          "Bewaking" & Year(Now) & "_" & Me._idRegistratie & ".pdf"

            f_rap.Show()
            f_rap.ExportPDFBewakingRegistratie(
                _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                "RegistratieInbreukRegl",
                pathPDFfile,
                Me._idRegistratie)
            f_rap.Dispose()

            olmail.Attachments.Add(pathPDFfile)

            ''-> de bijlagen (resizen)
            'Dim pathBijlageResized As String
            'Dim arrResizedImages As New ArrayList

            'For Each pathBijlage As String In specPathsAttachment
            '    pathBijlageResized = pathBijlage

            '    If MailBBW.isFoto(pathBijlage) = True Then
            '        'Indien de foto > 20 kb --> resizen
            '        Dim oFileSize As New FileInfo(pathBijlage)
            '        If oFileSize.Length() > 20000 Then
            '            'nieuwe file aanmaken en na het versturen terug verwijderen
            '            ImageResizer.resizeImage(pathBijlage, pathBijlageResized)
            '            arrResizedImages.Add(pathBijlageResized)
            '        End If
            '    End If

            '    olmail.Attachments.Add(pathBijlageResized)
            'Next

            olmail.Display(False)

            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            proxy.UpdateIKPSendMail(Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute, _idRegistratie)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonNaarCHIP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonNaarCHIP.Click
        'Doel:   Versturen naar CHIP data
        'Auteur: Lawrence Verbruggen (SIDLAWV)
        'Aangemaakt: 04/03/2011
        Dim nullDate As Date

        Try
            'Is de registratie volledig en opgeslaan
            If TextBoxVerslagnummer.Text = "" Then
                MessageBox.Show("Gelieve eerst een registratie aan te maken en/of op te slaan", "Naar CHIP zenden",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
                'Zijn alle velden correct ingevuld
            ElseIf Not controleVeldenOK() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
                'Werd ze reeds naar Bestemmelingen verstuurd
            ElseIf UltraDateTimeEditorBestemmelingen.DateTime.Date = nullDate Then
                MessageBox.Show("Registratie moet eerst verzonden worden naar bestemmelingen", "Naar CHIP zenden",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Is de registratie bestemd voor CHIP
            ElseIf cbxVerslagnrCHIP.Checked = False Then
                MessageBox.Show("Registratie moet aangevinkt zijn voor CHIP", "Naar CHIP zenden", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
                'Werd de betrokken leverancier geselecteerd
            ElseIf UltraComboFirma.Value Is Nothing OrElse UltraComboFirma.Value.ToString() = "" Then
                MessageBox.Show("Gelieve eerst een leverancier te selecteren", "Naar CHIP zenden", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorNaarCHIP.Value = DateTime.Now
                Me.setStatus("")

                Dim proxy As New BBWServiceManagementServicesProxy
                proxy.CHIPUpdate(Me._idRegistratie, Me.UltraComboFirma.Value.ToString(),
                                  DateTime.Now.Date, Me.TextBoxNaarCHIP.Text)

                Me.setStatus("Registratie succesvol opgeslaan voor CHIP")
            End If


        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingAlcoholtest - ButtonNaarCHIP_Click()" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub cbxVerslagnrCHIP_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cbxVerslagnrCHIP.CheckedChanged
        'Doel: Registratie markeren voor CHIP verslag
        'Auteur: Lawrence Verbruggen
        'Aangemaakt: 04/03/2011

        Dim proxy As New BBWServiceManagementServicesProxy
        proxy.CHIPRegistration(Me._idRegistratie, Me.cbxVerslagnrCHIP.Checked)

        'Als CheckBox aangevinkt sta, dan markeren voor CHIP, anders markering voor CHIP verwijderen
        If FormManager.Current.IKPvtw Then
            Me.ButtonNaarCHIP.Enabled = False
        Else
            Me.ButtonNaarCHIP.Enabled = Me.cbxVerslagnrCHIP.Checked
        End If

        Me.setStatus("Registratie klaar voor CHIP")
    End Sub

#End Region

#Region "Mailing"

    Private Sub sendMail(ByVal mailTo As ArrayList, ByVal aText As String,
                          ByVal subject As String, ByVal pathAttach As ArrayList)
        Try
            MailBBW.sendMail(mailTo, aText, subject, pathAttach)
            Me.setStatus("Registratie succesvol verzonden naar de bestemmelingen")
        Catch ex As Exception
            Me.setStatus("OPGELET: Registratie niet verzonden naar de bestemmelingen")

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsException)
        End Try
    End Sub


    Private Sub initializeMailInfo()
        'Doel:   Verzending van mails => knoppen en textboxen goed zetten
        'Auteur: Nancy Coppens - 19/09/2006 (overgenomen van Brandweerinterventie Rajiv)

        Try
            cbxVerslagnrCHIP.Enabled = False
            UltraComboFirma.Enabled = False
            ButtonNaarCHIP.Enabled = False
            TextBoxNaarCHIP.ReadOnly = True

            If FormManager.Current.PostOverste Then
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonVerzendingBest.Enabled = False
            ElseIf FormManager.Current.BbwVerantwoordelijke Then
                'mag alles zien
                cbxVerslagnrCHIP.Enabled = True
                UltraComboFirma.Enabled = True
                ButtonNaarCHIP.Enabled = True
                TextBoxNaarCHIP.ReadOnly = False
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
                ButtonMailIKP.Visible = True
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or FormManager.Current.Chip Then
                    UltraButtonOverzicht.Enabled = False
                    ButtonMailIKP.Visible = True
                    ButtonNaarCHIP.Enabled = False
                    ButtonMailIKP.Top = UltraButtonOverzicht.Top
                End If
                If FormManager.Current.Chip Then
                    UltraComboFirma.Enabled = True
                    ButtonNaarCHIP.Enabled = True
                    TextBoxNaarCHIP.ReadOnly = False
                Else
                    UltraComboFirma.Enabled = False
                    ButtonNaarCHIP.Enabled = False
                    TextBoxNaarCHIP.ReadOnly = True
                End If

                UltraButtonOpslaan.Enabled = False
                UltraButtonAnnuleer.Visible = False
                GroupBoxHoofding.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False
                GroupBoxVoertuig.Enabled = False
                GroupBoxOverige.Enabled = False
                GroupBoxOvertreder.Enabled = False
                GroupBoxInbreuk.Enabled = False
                GroupBoxOpmerkingen.Enabled = False

                ButtonVerzendingBBW.Enabled = False
                ButtonGoedkeuring.Enabled = False
                ButtonTerugZenden.Enabled = False
                ButtonVerzendingBest.Enabled = False

                TextBoxVerzending.ReadOnly = True
                TextBoxGoedkeuring.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
            Else 'brandweerman
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                UltraDateTimeEditorGoedkeuring.ReadOnly = True
                TextBoxGoedkeuring.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonGoedkeuring.Visible = False
                ButtonTerugZenden.Visible = False
                ButtonVerzendingBest.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingInbreukReglementen - intializeMailInfo" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

#End Region

    Private Sub UltraDateTimeEditorVerzending_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles UltraDateTimeEditorVerzending.ValueChanged
        If UltraDateTimeEditorVerzending.Value Is Nothing And Not FormManager.Current.Chip Then
            ButtonVerzendingBBW.Enabled = True
        Else
            ButtonVerzendingBBW.Enabled = False
        End If

        If FormManager.Current.IKPvtw Then
            ButtonVerzendingBBW.Enabled = False
        End If
    End Sub

    Private Sub UltraMaskedEditStamnrOvertreder_MaskChanged(ByVal sender As Object, ByVal e As MaskChangedEventArgs) _
        Handles UltraMaskedEditStamnrOvertreder.MaskChanged

    End Sub

    Private Sub ButtonMailIKP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMailIKP.Click
        If MessageBox.Show("Mag vink Chip aangevinkt worden?", "Chip aanvinken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            cbxVerslagnrCHIP.Checked = True
        End If
        SendMailIKP()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 10/01/2017</remarks>
    Private Sub ButtonInfoChip_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInfoChip.Click

        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim strFirmaNaamBBW As String = LabelFirmaNaam.Text.Trim
        Dim intIDFRM_BBW As Integer = CInt(_dataRegInbreukRegl.BBINBRRG.Rows(0).Item("ID_FRM").ToString)

        If strFirmaNaamBBW = "" Then
            MessageBox.Show("Firmanaam is niet ingevuld: verslag kan niet automatisch naar CHIP gestuurd worden.", "Firmanaam - CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(intIDFRM_BBW)

            If intIDFirmSAP > 0 And intIDFRM_BBW <> 1001674 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP)

                Dim strMailToFirm As String
                'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP) 'vanaf 13/03/2017 - naco/borb

                If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                    MessageBox.Show("Geen contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firma nr: " & intIDFirmSAP & ".", "Geen contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else 'wel een contactpersoon => mail met verslag in bijlage versturen
                    MessageBox.Show("Contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firmanr: " & intIDFirmSAP & vbCrLf & vbCrLf & strMailToFirm, "Contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                If intIDFRM_BBW <> 1001674 Then '1001674 = ArcelorMittal Gent => geen msgbox tonen
                    MessageBox.Show("Verslag kan niet automatisch naar firma gestuurd worden en niet naar CHIP portaal." & vbCrLf & vbCrLf &
                                    "SAP firmanr niet gekend voor deze BBW firma: " & vbCrLf & strFirmaNaamBBW & ".", "Verslag automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Verslag waarvoor BBW firma = ArcelorMittal Gent." & vbCrLf &
                                    "Verslagen voor AM Gent worden niet naar CHIP verstuurd.", "Verslag AM Gent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub
End Class
