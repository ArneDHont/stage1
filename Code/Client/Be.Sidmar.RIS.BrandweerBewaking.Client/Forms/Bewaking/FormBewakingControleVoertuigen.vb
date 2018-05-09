Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection
Imports ADF.ExceptionHandling
Imports System.IO

Imports Microsoft.Office.Interop 'mails versturen voor IKP - naco - 30/11/2012
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class FormBewakingControleVoertuigen
    Inherits System.Windows.Forms.Form

#Region "Variabelen"
    Private _idRegistratie As Integer = -1
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
    Private _keuringsOrganisme As String
    Private _opmerkingenAttest As String
    Private _dateKeuring As Date = Now
    Friend WithEvents _dataFirmaHRM As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
#End Region

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

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
    Friend WithEvents GroupBoxVerzending As System.Windows.Forms.GroupBox
    Friend WithEvents LabelBevestigdDoorLeverancier As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorBevestigdDoorLeverancier As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraComboFirma As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LabelLeverancier As System.Windows.Forms.Label
    Friend WithEvents cbxVerslagnrCHIP As System.Windows.Forms.CheckBox
    Friend WithEvents LabelOpmerkingNaarCHIP As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorNaarCHIP As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ButtonNaarCHIP As System.Windows.Forms.Button
    Friend WithEvents TextBoxNaarCHIP As System.Windows.Forms.TextBox
    Friend WithEvents LabelNaarChip As System.Windows.Forms.Label
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorBestemmelingen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorGoedkeuring As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorVerzending As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ButtonVerzendingBest As System.Windows.Forms.Button
    Friend WithEvents ButtonGoedkeuring As System.Windows.Forms.Button
    Friend WithEvents ButtonVerzendingBBW As System.Windows.Forms.Button
    Friend WithEvents TextBoxVerzendingBestemmelingen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGoedkeuring As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVerzending As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerzendingBest As System.Windows.Forms.Label
    Friend WithEvents LabelGoedkeuring As System.Windows.Forms.Label
    Friend WithEvents LabelVerzending As System.Windows.Forms.Label
    Friend WithEvents GroupBoxHoofding As System.Windows.Forms.GroupBox
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents TextBoxPlaats As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaats As System.Windows.Forms.Label
    Friend WithEvents LabelUur As System.Windows.Forms.Label
    Friend WithEvents LabelDatum As System.Windows.Forms.Label
    Friend WithEvents TextBoxVerslagnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerslagnr As System.Windows.Forms.Label
    Friend WithEvents LabelTitel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents LabelBenadeelde As System.Windows.Forms.Label
    Friend WithEvents LabelSoortVoertuig As System.Windows.Forms.Label
    Friend WithEvents GroupBoxVoertuig As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAard As System.Windows.Forms.Label
    Friend WithEvents LabelChassisnummerVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelNummerplaatVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelChassisnummer As System.Windows.Forms.Label
    Friend WithEvents LabelNummerplaat As System.Windows.Forms.Label
    Friend WithEvents LabelMerk As System.Windows.Forms.Label
    Friend WithEvents LabelEigenaar As System.Windows.Forms.Label
    Friend WithEvents GroupBoxBestuurder As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonKiesFirma As System.Windows.Forms.Button
    Friend WithEvents LabelFirma As System.Windows.Forms.Label
    Friend WithEvents LabelBestuurder As System.Windows.Forms.Label
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents LabelVerantwoordelijke As System.Windows.Forms.Label
    Friend WithEvents TextBoxKeuringsorganisme As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOpmerkingenAttest As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents GroupBoxInlichtingenHefwerktuig As System.Windows.Forms.GroupBox
    Friend WithEvents _dataWerfVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSWerfVoertuig
    Friend WithEvents UltraOptionSetBenadeelde As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents _dataBewakingDup As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingDup
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents GroupBoxControleVoertuigen As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraOptionSetSoortVoertuig As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents TextBoxFirmaId As System.Windows.Forms.TextBox
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents TextBoxVoertuigId As System.Windows.Forms.TextBox
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents UserControlGeneralFunctionsControleVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataRegControleVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegControleVoertuig
    Friend WithEvents UltraDateTimeEditorKeuring As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ButtonKiesPersoonVerantwoordelijke As System.Windows.Forms.Button
    Friend WithEvents ButtonKiesPersoonBestuurder As System.Windows.Forms.Button
    Friend WithEvents ButtonKiesVoertuig As System.Windows.Forms.Button
    Friend WithEvents Extra As System.Windows.Forms.GroupBox
    Friend WithEvents TabControlOverige2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDefecten As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxDefecten As System.Windows.Forms.TextBox
    Friend WithEvents TabPageMaatregelen As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxMaatregelen As System.Windows.Forms.TextBox
    Friend WithEvents LabelNaamBestuurder As System.Windows.Forms.Label
    Friend WithEvents LabelNaamVerantwoordelijke As System.Windows.Forms.Label
    Friend WithEvents LabelAdresBestuurder As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaNaam As System.Windows.Forms.Label
    Friend WithEvents LabelStamnrEigenaar As System.Windows.Forms.Label
    Friend WithEvents LabelNaamEigenaar As System.Windows.Forms.Label
    Friend WithEvents LabelKeuringsorg As System.Windows.Forms.Label
    Friend WithEvents LabelOpmAttest As System.Windows.Forms.Label
    Friend WithEvents LabelDatumKeuring As System.Windows.Forms.Label
    Friend WithEvents LabelMerkVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelAardVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaAdres As System.Windows.Forms.Label
    Friend WithEvents UltraMaskedEditStamnrBestuurder As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditStamnrVerantwoordelijke As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents TextBoxBestemmingFabriek As System.Windows.Forms.TextBox
    Friend WithEvents LabelBestemmingFabriek As System.Windows.Forms.Label
    Friend WithEvents LabelSAPAfdeling As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingControleVoertuigen))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Firma", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanaam")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanummer")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parent")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parentnaam")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBoxHoofding = New System.Windows.Forms.GroupBox()
        Me.TextBoxKorteOms = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelVolgnr = New System.Windows.Forms.Label()
        Me.UltraMaskedEditUur = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.TextBoxPlaats = New System.Windows.Forms.TextBox()
        Me.LabelPlaats = New System.Windows.Forms.Label()
        Me.LabelUur = New System.Windows.Forms.Label()
        Me.LabelDatum = New System.Windows.Forms.Label()
        Me.TextBoxVerslagnummer = New System.Windows.Forms.TextBox()
        Me.LabelVerslagnr = New System.Windows.Forms.Label()
        Me.LabelTitel = New System.Windows.Forms.Label()
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me.UltraOptionSetBenadeelde = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataBewakingDup = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingDup()
        Me.LabelBenadeelde = New System.Windows.Forms.Label()
        Me.UltraOptionSetSoortVoertuig = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataWerfVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSWerfVoertuig()
        Me.LabelSoortVoertuig = New System.Windows.Forms.Label()
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
        Me.GroupBoxBestuurder = New System.Windows.Forms.GroupBox()
        Me.LabelSAPAfdeling = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrVerantwoordelijke = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEditStamnrBestuurder = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.LabelFirmaAdres = New System.Windows.Forms.Label()
        Me.LabelFirmaNaam = New System.Windows.Forms.Label()
        Me.LabelAdresBestuurder = New System.Windows.Forms.Label()
        Me.LabelNaamVerantwoordelijke = New System.Windows.Forms.Label()
        Me.LabelNaamBestuurder = New System.Windows.Forms.Label()
        Me.TextBoxFirmaId = New System.Windows.Forms.TextBox()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.ButtonKiesPersoonVerantwoordelijke = New System.Windows.Forms.Button()
        Me.LabelVerantwoordelijke = New System.Windows.Forms.Label()
        Me.ButtonKiesFirma = New System.Windows.Forms.Button()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.LabelBestuurder = New System.Windows.Forms.Label()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonBestuurder = New System.Windows.Forms.Button()
        Me.GroupBoxInlichtingenHefwerktuig = New System.Windows.Forms.GroupBox()
        Me.TextBoxBestemmingFabriek = New System.Windows.Forms.TextBox()
        Me.LabelBestemmingFabriek = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorKeuring = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.TextBoxOpmerkingenAttest = New System.Windows.Forms.TextBox()
        Me.TextBoxKeuringsorganisme = New System.Windows.Forms.TextBox()
        Me.LabelKeuringsorg = New System.Windows.Forms.Label()
        Me.LabelOpmAttest = New System.Windows.Forms.Label()
        Me.LabelDatumKeuring = New System.Windows.Forms.Label()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsControleVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me.TabControlOverige2 = New System.Windows.Forms.TabControl()
        Me.TabPageDefecten = New System.Windows.Forms.TabPage()
        Me.TextBoxDefecten = New System.Windows.Forms.TextBox()
        Me.TabPageMaatregelen = New System.Windows.Forms.TabPage()
        Me.TextBoxMaatregelen = New System.Windows.Forms.TextBox()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me.GroupBoxControleVoertuigen = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me._dataRegControleVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegControleVoertuig()
        Me.Extra = New System.Windows.Forms.GroupBox()
        Me.GroupBoxVerzending = New System.Windows.Forms.GroupBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetSoortVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataWerfVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVoertuig.SuspendLayout()
        Me.GroupBoxBestuurder.SuspendLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInlichtingenHefwerktuig.SuspendLayout()
        CType(Me.UltraDateTimeEditorKeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOverige.SuspendLayout()
        Me.TabControlOverige2.SuspendLayout()
        Me.TabPageDefecten.SuspendLayout()
        Me.TabPageMaatregelen.SuspendLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxControleVoertuigen.SuspendLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegControleVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Extra.SuspendLayout()
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
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVolgnr)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraMaskedEditUur)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraDateTimeEditorDatum)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelUur)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelDatum)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxVerslagnummer)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVerslagnr)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelTitel)
        Me.GroupBoxHoofding.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxHoofding.Name = "GroupBoxHoofding"
        Me.GroupBoxHoofding.Size = New System.Drawing.Size(1008, 56)
        Me.GroupBoxHoofding.TabIndex = 0
        Me.GroupBoxHoofding.TabStop = False
        Me.GroupBoxHoofding.Text = "Hoofding"
        '
        'TextBoxKorteOms
        '
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(648, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(352, 20)
        Me.TextBoxKorteOms.TabIndex = 1005
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(560, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1006
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(248, 24)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 16)
        Me.LabelVolgnr.TabIndex = 3
        Me.LabelVolgnr.Visible = False
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(464, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 7
        Me.UltraMaskedEditUur.Text = ":"
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(464, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 5
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(648, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(352, 20)
        Me.TextBoxPlaats.TabIndex = 9
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(592, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 8
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(432, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 6
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(416, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 4
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(312, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.Location = New System.Drawing.Point(256, 24)
        Me.LabelVerslagnr.Name = "LabelVerslagnr"
        Me.LabelVerslagnr.Size = New System.Drawing.Size(64, 21)
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
        Me.LabelTitel.Size = New System.Drawing.Size(247, 29)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Controle Voertuigen"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraOptionSetBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraOptionSetSoortVoertuig)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelSoortVoertuig)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 56)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(1008, 36)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 1
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Algemene gegevens"
        '
        'UltraOptionSetBenadeelde
        '
        Me.UltraOptionSetBenadeelde.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetBenadeelde.DataMember = "BBBEWDUP"
        Me.UltraOptionSetBenadeelde.DataSource = Me._dataBewakingDup
        Me.UltraOptionSetBenadeelde.DisplayMember = "SCF_BEW_DUP"
        Me.UltraOptionSetBenadeelde.Location = New System.Drawing.Point(656, 14)
        Me.UltraOptionSetBenadeelde.Name = "UltraOptionSetBenadeelde"
        Me.UltraOptionSetBenadeelde.Size = New System.Drawing.Size(328, 16)
        Me.UltraOptionSetBenadeelde.TabIndex = 3
        Me.UltraOptionSetBenadeelde.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetBenadeelde.ValueMember = "ID_BEW_DUP"
        Me.UltraOptionSetBenadeelde.Visible = False
        '
        '_dataBewakingDup
        '
        Me._dataBewakingDup.DataSetName = "TDSBewakingDup"
        Me._dataBewakingDup.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBewakingDup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelBenadeelde
        '
        Me.LabelBenadeelde.Location = New System.Drawing.Point(584, 14)
        Me.LabelBenadeelde.Name = "LabelBenadeelde"
        Me.LabelBenadeelde.Size = New System.Drawing.Size(72, 16)
        Me.LabelBenadeelde.TabIndex = 2
        Me.LabelBenadeelde.Text = "Benadeelde:"
        Me.LabelBenadeelde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelBenadeelde.Visible = False
        '
        'UltraOptionSetSoortVoertuig
        '
        Me.UltraOptionSetSoortVoertuig.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetSoortVoertuig.DataMember = "BBWRFTSP"
        Me.UltraOptionSetSoortVoertuig.DataSource = Me._dataWerfVoertuig
        Me.UltraOptionSetSoortVoertuig.DisplayMember = "SCF_WRF_TSP"
        Me.UltraOptionSetSoortVoertuig.Location = New System.Drawing.Point(96, 14)
        Me.UltraOptionSetSoortVoertuig.Name = "UltraOptionSetSoortVoertuig"
        Me.UltraOptionSetSoortVoertuig.Size = New System.Drawing.Size(488, 16)
        Me.UltraOptionSetSoortVoertuig.TabIndex = 1
        Me.UltraOptionSetSoortVoertuig.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetSoortVoertuig.ValueMember = "ID_WRF_TSP"
        '
        '_dataWerfVoertuig
        '
        Me._dataWerfVoertuig.DataSetName = "TDSWerfVoertuig"
        Me._dataWerfVoertuig.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataWerfVoertuig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelSoortVoertuig
        '
        Me.LabelSoortVoertuig.Location = New System.Drawing.Point(8, 14)
        Me.LabelSoortVoertuig.Name = "LabelSoortVoertuig"
        Me.LabelSoortVoertuig.Size = New System.Drawing.Size(104, 16)
        Me.LabelSoortVoertuig.TabIndex = 0
        Me.LabelSoortVoertuig.Text = "Soort Voertuig:"
        Me.LabelSoortVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBoxVoertuig.Location = New System.Drawing.Point(0, 184)
        Me.GroupBoxVoertuig.Name = "GroupBoxVoertuig"
        Me.GroupBoxVoertuig.Size = New System.Drawing.Size(528, 96)
        Me.GroupBoxVoertuig.TabIndex = 3
        Me.GroupBoxVoertuig.TabStop = False
        Me.GroupBoxVoertuig.Text = "Voertuig Gegevens"
        '
        'LabelChassisnummerVoertuig
        '
        Me.LabelChassisnummerVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelChassisnummerVoertuig.Location = New System.Drawing.Point(400, 64)
        Me.LabelChassisnummerVoertuig.Name = "LabelChassisnummerVoertuig"
        Me.LabelChassisnummerVoertuig.Size = New System.Drawing.Size(120, 20)
        Me.LabelChassisnummerVoertuig.TabIndex = 11
        Me.LabelChassisnummerVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaatVoertuig
        '
        Me.LabelNummerplaatVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNummerplaatVoertuig.Location = New System.Drawing.Point(400, 40)
        Me.LabelNummerplaatVoertuig.Name = "LabelNummerplaatVoertuig"
        Me.LabelNummerplaatVoertuig.Size = New System.Drawing.Size(120, 20)
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
        Me.LabelNaamEigenaar.Size = New System.Drawing.Size(248, 20)
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
        Me.TextBoxVoertuigId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxVoertuigId.TabIndex = 1
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
        Me.LabelChassisnummer.Location = New System.Drawing.Point(336, 64)
        Me.LabelChassisnummer.Name = "LabelChassisnummer"
        Me.LabelChassisnummer.Size = New System.Drawing.Size(72, 16)
        Me.LabelChassisnummer.TabIndex = 10
        Me.LabelChassisnummer.Text = "Chassisnr:"
        Me.LabelChassisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaat
        '
        Me.LabelNummerplaat.Location = New System.Drawing.Point(336, 40)
        Me.LabelNummerplaat.Name = "LabelNummerplaat"
        Me.LabelNummerplaat.Size = New System.Drawing.Size(80, 23)
        Me.LabelNummerplaat.TabIndex = 8
        Me.LabelNummerplaat.Text = "Nrplaat:"
        Me.LabelNummerplaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerk
        '
        Me.LabelMerk.AutoSize = True
        Me.LabelMerk.Location = New System.Drawing.Point(8, 40)
        Me.LabelMerk.Name = "LabelMerk"
        Me.LabelMerk.Size = New System.Drawing.Size(34, 13)
        Me.LabelMerk.TabIndex = 4
        Me.LabelMerk.Text = "Merk:"
        Me.LabelMerk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEigenaar
        '
        Me.LabelEigenaar.AutoSize = True
        Me.LabelEigenaar.Location = New System.Drawing.Point(8, 14)
        Me.LabelEigenaar.Name = "LabelEigenaar"
        Me.LabelEigenaar.Size = New System.Drawing.Size(52, 13)
        Me.LabelEigenaar.TabIndex = 0
        Me.LabelEigenaar.Text = "Eigenaar:"
        Me.LabelEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesVoertuig
        '
        Me.ButtonKiesVoertuig.Location = New System.Drawing.Point(400, 16)
        Me.ButtonKiesVoertuig.Name = "ButtonKiesVoertuig"
        Me.ButtonKiesVoertuig.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesVoertuig.TabIndex = 3
        Me.ButtonKiesVoertuig.Text = "Kies Voertuig"
        '
        'GroupBoxBestuurder
        '
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelSAPAfdeling)
        Me.GroupBoxBestuurder.Controls.Add(Me.UltraMaskedEditStamnrVerantwoordelijke)
        Me.GroupBoxBestuurder.Controls.Add(Me.UltraMaskedEditStamnrBestuurder)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelFirmaAdres)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelFirmaNaam)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelAdresBestuurder)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelNaamVerantwoordelijke)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelNaamBestuurder)
        Me.GroupBoxBestuurder.Controls.Add(Me.TextBoxFirmaId)
        Me.GroupBoxBestuurder.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxBestuurder.Controls.Add(Me.ButtonKiesPersoonVerantwoordelijke)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelVerantwoordelijke)
        Me.GroupBoxBestuurder.Controls.Add(Me.ButtonKiesFirma)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelFirma)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelBestuurder)
        Me.GroupBoxBestuurder.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxBestuurder.Controls.Add(Me.ButtonKiesPersoonBestuurder)
        Me.GroupBoxBestuurder.Location = New System.Drawing.Point(0, 92)
        Me.GroupBoxBestuurder.Name = "GroupBoxBestuurder"
        Me.GroupBoxBestuurder.Size = New System.Drawing.Size(1008, 92)
        Me.GroupBoxBestuurder.TabIndex = 2
        Me.GroupBoxBestuurder.TabStop = False
        Me.GroupBoxBestuurder.Text = "Identiteit bestuurder"
        '
        'LabelSAPAfdeling
        '
        Me.LabelSAPAfdeling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSAPAfdeling.Location = New System.Drawing.Point(584, 16)
        Me.LabelSAPAfdeling.Name = "LabelSAPAfdeling"
        Me.LabelSAPAfdeling.Size = New System.Drawing.Size(56, 20)
        Me.LabelSAPAfdeling.TabIndex = 16
        Me.LabelSAPAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrVerantwoordelijke
        '
        Me.UltraMaskedEditStamnrVerantwoordelijke.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrVerantwoordelijke.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrVerantwoordelijke.Location = New System.Drawing.Point(88, 65)
        Me.UltraMaskedEditStamnrVerantwoordelijke.MaxValue = 99999999
        Me.UltraMaskedEditStamnrVerantwoordelijke.Name = "UltraMaskedEditStamnrVerantwoordelijke"
        Me.UltraMaskedEditStamnrVerantwoordelijke.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrVerantwoordelijke.TabIndex = 13
        Me.UltraMaskedEditStamnrVerantwoordelijke.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraMaskedEditStamnrBestuurder
        '
        Me.UltraMaskedEditStamnrBestuurder.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrBestuurder.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrBestuurder.Location = New System.Drawing.Point(88, 16)
        Me.UltraMaskedEditStamnrBestuurder.MaxValue = 99999999
        Me.UltraMaskedEditStamnrBestuurder.Name = "UltraMaskedEditStamnrBestuurder"
        Me.UltraMaskedEditStamnrBestuurder.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrBestuurder.TabIndex = 1
        Me.UltraMaskedEditStamnrBestuurder.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'LabelFirmaAdres
        '
        Me.LabelFirmaAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaAdres.Location = New System.Drawing.Point(584, 64)
        Me.LabelFirmaAdres.Name = "LabelFirmaAdres"
        Me.LabelFirmaAdres.Size = New System.Drawing.Size(336, 20)
        Me.LabelFirmaAdres.TabIndex = 10
        Me.LabelFirmaAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirmaNaam
        '
        Me.LabelFirmaNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaNaam.Location = New System.Drawing.Point(584, 40)
        Me.LabelFirmaNaam.Name = "LabelFirmaNaam"
        Me.LabelFirmaNaam.Size = New System.Drawing.Size(248, 20)
        Me.LabelFirmaNaam.TabIndex = 9
        Me.LabelFirmaNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAdresBestuurder
        '
        Me.LabelAdresBestuurder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAdresBestuurder.Location = New System.Drawing.Point(88, 40)
        Me.LabelAdresBestuurder.Name = "LabelAdresBestuurder"
        Me.LabelAdresBestuurder.Size = New System.Drawing.Size(400, 20)
        Me.LabelAdresBestuurder.TabIndex = 3
        Me.LabelAdresBestuurder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamVerantwoordelijke
        '
        Me.LabelNaamVerantwoordelijke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamVerantwoordelijke.Location = New System.Drawing.Point(144, 65)
        Me.LabelNaamVerantwoordelijke.Name = "LabelNaamVerantwoordelijke"
        Me.LabelNaamVerantwoordelijke.Size = New System.Drawing.Size(248, 20)
        Me.LabelNaamVerantwoordelijke.TabIndex = 14
        Me.LabelNaamVerantwoordelijke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamBestuurder
        '
        Me.LabelNaamBestuurder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamBestuurder.Location = New System.Drawing.Point(144, 16)
        Me.LabelNaamBestuurder.Name = "LabelNaamBestuurder"
        Me.LabelNaamBestuurder.Size = New System.Drawing.Size(248, 20)
        Me.LabelNaamBestuurder.TabIndex = 2
        Me.LabelNaamBestuurder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxFirmaId
        '
        Me.TextBoxFirmaId.Location = New System.Drawing.Point(904, 16)
        Me.TextBoxFirmaId.Name = "TextBoxFirmaId"
        Me.TextBoxFirmaId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxFirmaId.TabIndex = 7
        Me.TextBoxFirmaId.Visible = False
        '
        'UltraComboAfdelingen
        '
        Me.UltraComboAfdelingen.DataMember = "BBAFD"
        Me.UltraComboAfdelingen.DataSource = Me._dataAfdelingen
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAfdelingen.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Afdeling"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Afkorting"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.UltraComboAfdelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboAfdelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboAfdelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraComboAfdelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboAfdelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboAfdelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraComboAfdelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboAfdelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboAfdelingen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboAfdelingen.DisplayMember = "KRT_AFD"
        Me.UltraComboAfdelingen.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(840, 16)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 6
        Me.UltraComboAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAfdelingen.ValueMember = "ID_AFD"
        Me.UltraComboAfdelingen.Visible = False
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonKiesPersoonVerantwoordelijke
        '
        Me.ButtonKiesPersoonVerantwoordelijke.Location = New System.Drawing.Point(400, 65)
        Me.ButtonKiesPersoonVerantwoordelijke.Name = "ButtonKiesPersoonVerantwoordelijke"
        Me.ButtonKiesPersoonVerantwoordelijke.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesPersoonVerantwoordelijke.TabIndex = 15
        Me.ButtonKiesPersoonVerantwoordelijke.Text = "Kies persoon"
        '
        'LabelVerantwoordelijke
        '
        Me.LabelVerantwoordelijke.Location = New System.Drawing.Point(8, 65)
        Me.LabelVerantwoordelijke.Name = "LabelVerantwoordelijke"
        Me.LabelVerantwoordelijke.Size = New System.Drawing.Size(88, 16)
        Me.LabelVerantwoordelijke.TabIndex = 12
        Me.LabelVerantwoordelijke.Text = "Verantw Dienst:"
        '
        'ButtonKiesFirma
        '
        Me.ButtonKiesFirma.Location = New System.Drawing.Point(840, 40)
        Me.ButtonKiesFirma.Name = "ButtonKiesFirma"
        Me.ButtonKiesFirma.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesFirma.TabIndex = 11
        Me.ButtonKiesFirma.Text = "Kies Firma"
        '
        'LabelFirma
        '
        Me.LabelFirma.Location = New System.Drawing.Point(520, 40)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(40, 16)
        Me.LabelFirma.TabIndex = 8
        Me.LabelFirma.Text = "Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBestuurder
        '
        Me.LabelBestuurder.Location = New System.Drawing.Point(8, 16)
        Me.LabelBestuurder.Name = "LabelBestuurder"
        Me.LabelBestuurder.Size = New System.Drawing.Size(88, 23)
        Me.LabelBestuurder.TabIndex = 0
        Me.LabelBestuurder.Text = "Bestuurder:"
        Me.LabelBestuurder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(520, 16)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(48, 23)
        Me.LabelAfdeling.TabIndex = 5
        Me.LabelAfdeling.Text = "Afdeling:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonBestuurder
        '
        Me.ButtonKiesPersoonBestuurder.Location = New System.Drawing.Point(400, 16)
        Me.ButtonKiesPersoonBestuurder.Name = "ButtonKiesPersoonBestuurder"
        Me.ButtonKiesPersoonBestuurder.Size = New System.Drawing.Size(88, 20)
        Me.ButtonKiesPersoonBestuurder.TabIndex = 4
        Me.ButtonKiesPersoonBestuurder.Text = "Kies persoon"
        '
        'GroupBoxInlichtingenHefwerktuig
        '
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.TextBoxBestemmingFabriek)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.LabelBestemmingFabriek)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.UltraDateTimeEditorKeuring)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.TextBoxOpmerkingenAttest)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.TextBoxKeuringsorganisme)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.LabelKeuringsorg)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.LabelOpmAttest)
        Me.GroupBoxInlichtingenHefwerktuig.Controls.Add(Me.LabelDatumKeuring)
        Me.GroupBoxInlichtingenHefwerktuig.Enabled = False
        Me.GroupBoxInlichtingenHefwerktuig.Location = New System.Drawing.Point(0, 318)
        Me.GroupBoxInlichtingenHefwerktuig.Name = "GroupBoxInlichtingenHefwerktuig"
        Me.GroupBoxInlichtingenHefwerktuig.Size = New System.Drawing.Size(1008, 88)
        Me.GroupBoxInlichtingenHefwerktuig.TabIndex = 4
        Me.GroupBoxInlichtingenHefwerktuig.TabStop = False
        Me.GroupBoxInlichtingenHefwerktuig.Text = "Inlichtingen keuring (hefwerktuig)"
        '
        'TextBoxBestemmingFabriek
        '
        Me.TextBoxBestemmingFabriek.Location = New System.Drawing.Point(160, 64)
        Me.TextBoxBestemmingFabriek.Name = "TextBoxBestemmingFabriek"
        Me.TextBoxBestemmingFabriek.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxBestemmingFabriek.TabIndex = 15
        '
        'LabelBestemmingFabriek
        '
        Me.LabelBestemmingFabriek.Location = New System.Drawing.Point(8, 64)
        Me.LabelBestemmingFabriek.Name = "LabelBestemmingFabriek"
        Me.LabelBestemmingFabriek.Size = New System.Drawing.Size(152, 16)
        Me.LabelBestemmingFabriek.TabIndex = 14
        Me.LabelBestemmingFabriek.Text = "Bestemming binnen fabriek:"
        '
        'UltraDateTimeEditorKeuring
        '
        Me.UltraDateTimeEditorKeuring.Location = New System.Drawing.Point(160, 40)
        Me.UltraDateTimeEditorKeuring.Name = "UltraDateTimeEditorKeuring"
        Me.UltraDateTimeEditorKeuring.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorKeuring.TabIndex = 3
        Me.UltraDateTimeEditorKeuring.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxOpmerkingenAttest
        '
        Me.TextBoxOpmerkingenAttest.Location = New System.Drawing.Point(400, 16)
        Me.TextBoxOpmerkingenAttest.Multiline = True
        Me.TextBoxOpmerkingenAttest.Name = "TextBoxOpmerkingenAttest"
        Me.TextBoxOpmerkingenAttest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOpmerkingenAttest.Size = New System.Drawing.Size(600, 40)
        Me.TextBoxOpmerkingenAttest.TabIndex = 5
        '
        'TextBoxKeuringsorganisme
        '
        Me.TextBoxKeuringsorganisme.Location = New System.Drawing.Point(160, 16)
        Me.TextBoxKeuringsorganisme.Name = "TextBoxKeuringsorganisme"
        Me.TextBoxKeuringsorganisme.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxKeuringsorganisme.TabIndex = 1
        '
        'LabelKeuringsorg
        '
        Me.LabelKeuringsorg.Location = New System.Drawing.Point(8, 16)
        Me.LabelKeuringsorg.Name = "LabelKeuringsorg"
        Me.LabelKeuringsorg.Size = New System.Drawing.Size(112, 16)
        Me.LabelKeuringsorg.TabIndex = 0
        Me.LabelKeuringsorg.Text = "Keuringsorganisme:"
        '
        'LabelOpmAttest
        '
        Me.LabelOpmAttest.Location = New System.Drawing.Point(328, 16)
        Me.LabelOpmAttest.Name = "LabelOpmAttest"
        Me.LabelOpmAttest.Size = New System.Drawing.Size(80, 16)
        Me.LabelOpmAttest.TabIndex = 4
        Me.LabelOpmAttest.Text = "Opm op attest:"
        '
        'LabelDatumKeuring
        '
        Me.LabelDatumKeuring.Location = New System.Drawing.Point(8, 40)
        Me.LabelDatumKeuring.Name = "LabelDatumKeuring"
        Me.LabelDatumKeuring.Size = New System.Drawing.Size(120, 16)
        Me.LabelDatumKeuring.TabIndex = 2
        Me.LabelDatumKeuring.Text = "Datum laatste keuring:"
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsControleVoertuig)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 406)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 166)
        Me.GroupBoxOverige.TabIndex = 6
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsControleVoertuig
        '
        Me.UserControlGeneralFunctionsControleVoertuig.AutoSize = True
        Me.UserControlGeneralFunctionsControleVoertuig.DatumOpstelling = New Date(2006, 5, 4, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsControleVoertuig.GetReportContractant = False
        Me.UserControlGeneralFunctionsControleVoertuig.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsControleVoertuig.Name = "UserControlGeneralFunctionsControleVoertuig"
        Me.UserControlGeneralFunctionsControleVoertuig.Opsteller = 0
        Me.UserControlGeneralFunctionsControleVoertuig.Size = New System.Drawing.Size(512, 144)
        Me.UserControlGeneralFunctionsControleVoertuig.TabIndex = 0
        Me.UserControlGeneralFunctionsControleVoertuig.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        'TabControlOverige2
        '
        Me.TabControlOverige2.Controls.Add(Me.TabPageDefecten)
        Me.TabControlOverige2.Controls.Add(Me.TabPageMaatregelen)
        Me.TabControlOverige2.Location = New System.Drawing.Point(8, 16)
        Me.TabControlOverige2.Name = "TabControlOverige2"
        Me.TabControlOverige2.SelectedIndex = 0
        Me.TabControlOverige2.Size = New System.Drawing.Size(456, 112)
        Me.TabControlOverige2.TabIndex = 0
        '
        'TabPageDefecten
        '
        Me.TabPageDefecten.Controls.Add(Me.TextBoxDefecten)
        Me.TabPageDefecten.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDefecten.Name = "TabPageDefecten"
        Me.TabPageDefecten.Size = New System.Drawing.Size(448, 86)
        Me.TabPageDefecten.TabIndex = 0
        Me.TabPageDefecten.Text = "Vastgestelde defecten"
        '
        'TextBoxDefecten
        '
        Me.TextBoxDefecten.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxDefecten.Multiline = True
        Me.TextBoxDefecten.Name = "TextBoxDefecten"
        Me.TextBoxDefecten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDefecten.Size = New System.Drawing.Size(432, 72)
        Me.TextBoxDefecten.TabIndex = 0
        '
        'TabPageMaatregelen
        '
        Me.TabPageMaatregelen.Controls.Add(Me.TextBoxMaatregelen)
        Me.TabPageMaatregelen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMaatregelen.Name = "TabPageMaatregelen"
        Me.TabPageMaatregelen.Size = New System.Drawing.Size(448, 86)
        Me.TabPageMaatregelen.TabIndex = 1
        Me.TabPageMaatregelen.Text = "Getroffen maatregelen"
        Me.TabPageMaatregelen.Visible = False
        '
        'TextBoxMaatregelen
        '
        Me.TextBoxMaatregelen.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxMaatregelen.Multiline = True
        Me.TextBoxMaatregelen.Name = "TextBoxMaatregelen"
        Me.TextBoxMaatregelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMaatregelen.Size = New System.Drawing.Size(432, 72)
        Me.TextBoxMaatregelen.TabIndex = 0
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxControleVoertuigen
        '
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxControleVoertuigen.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxControleVoertuigen.Location = New System.Drawing.Point(0, 576)
        Me.GroupBoxControleVoertuigen.Name = "GroupBoxControleVoertuigen"
        Me.GroupBoxControleVoertuigen.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxControleVoertuigen.TabIndex = 8
        Me.GroupBoxControleVoertuigen.TabStop = False
        Me.GroupBoxControleVoertuigen.Text = "Controle Voertuigen"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(310, 25)
        Me.ButtonMailIKP.Name = "ButtonMailIKP"
        Me.ButtonMailIKP.Size = New System.Drawing.Size(108, 23)
        Me.ButtonMailIKP.TabIndex = 6
        Me.ButtonMailIKP.Text = "Mail IKP/PEB"
        Me.ButtonMailIKP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMailIKP.UseVisualStyleBackColor = True
        Me.ButtonMailIKP.Visible = False
        '
        'UltraButtonAfdrukken
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance14
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonAnnuleer
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance15
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 0
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance16
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(216, 16)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 2
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraButtonOverzicht
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.UltraButtonOverzicht.Appearance = Appearance17
        Me.UltraButtonOverzicht.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOverzicht.Location = New System.Drawing.Point(320, 16)
        Me.UltraButtonOverzicht.Name = "UltraButtonOverzicht"
        Me.UltraButtonOverzicht.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOverzicht.TabIndex = 3
        Me.UltraButtonOverzicht.Text = "Overzicht"
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
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 626)
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
        '_dataRegControleVoertuig
        '
        Me._dataRegControleVoertuig.DataSetName = "TDSRegControleVoertuig"
        Me._dataRegControleVoertuig.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegControleVoertuig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Extra
        '
        Me.Extra.Controls.Add(Me.TabControlOverige2)
        Me.Extra.Location = New System.Drawing.Point(536, 184)
        Me.Extra.Name = "Extra"
        Me.Extra.Size = New System.Drawing.Size(472, 136)
        Me.Extra.TabIndex = 5
        Me.Extra.TabStop = False
        Me.Extra.Text = "Extra"
        '
        'GroupBoxVerzending
        '
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
        Me.GroupBoxVerzending.Controls.Add(Me.Label3)
        Me.GroupBoxVerzending.Controls.Add(Me.Label2)
        Me.GroupBoxVerzending.Controls.Add(Me.Label1)
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 406)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 218)
        Me.GroupBoxVerzending.TabIndex = 1004
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
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
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboFirma.DisplayLayout.Appearance = Appearance19
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Width = 150
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.UltraComboFirma.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraComboFirma.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboFirma.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.UltraComboFirma.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboFirma.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Highlight
        Appearance24.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveRowAppearance = Appearance24
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboFirma.DisplayLayout.Override.CellAppearance = Appearance26
        Me.UltraComboFirma.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboFirma.DisplayLayout.Override.CellPadding = 0
        Appearance27.BackColor = System.Drawing.SystemColors.Control
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.GroupByRowAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Left"
        Me.UltraComboFirma.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.UltraComboFirma.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboFirma.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboFirma.DisplayLayout.Override.RowAppearance = Appearance29
        Me.UltraComboFirma.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboFirma.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
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
        Me.cbxVerslagnrCHIP.Location = New System.Drawing.Point(287, 105)
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
        Me.LabelOpmerkingNaarCHIP.Size = New System.Drawing.Size(32, 13)
        Me.LabelOpmerkingNaarCHIP.TabIndex = 22
        Me.LabelOpmerkingNaarCHIP.Text = "Opm:"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Opm mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Opm mail:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Opm mail:"
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
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(344, 101)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(128, 21)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen"
        '
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(304, 56)
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
        'FormBewakingControleVoertuigen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 648)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me.Extra)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxControleVoertuigen)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxInlichtingenHefwerktuig)
        Me.Controls.Add(Me.GroupBoxVoertuig)
        Me.Controls.Add(Me.GroupBoxBestuurder)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Name = "FormBewakingControleVoertuigen"
        Me.Text = "Controle Voertuigen"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetSoortVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataWerfVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVoertuig.ResumeLayout(False)
        Me.GroupBoxVoertuig.PerformLayout()
        Me.GroupBoxBestuurder.ResumeLayout(False)
        Me.GroupBoxBestuurder.PerformLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInlichtingenHefwerktuig.ResumeLayout(False)
        Me.GroupBoxInlichtingenHefwerktuig.PerformLayout()
        CType(Me.UltraDateTimeEditorKeuring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        Me.TabControlOverige2.ResumeLayout(False)
        Me.TabPageDefecten.ResumeLayout(False)
        Me.TabPageDefecten.PerformLayout()
        Me.TabPageMaatregelen.ResumeLayout(False)
        Me.TabPageMaatregelen.PerformLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxControleVoertuigen.ResumeLayout(False)
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegControleVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Extra.ResumeLayout(False)
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
    Private Sub FormBewakingControleVoertuig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.setLabelsVerplicht()

            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing
            UltraDateTimeEditorNaarCHIP.Value = Nothing

            'tooltip CHIP - lawrence - 03/03/2011
            Dim toolTipCHIP As ToolTip = New ToolTip
            toolTipCHIP.SetToolTip(ButtonNaarCHIP, "Complaints Handling In Portal")
            toolTipCHIP.Active = True

            'tooltip CHIP - lawrence - 04/03/2011
            Dim toolTipCHIPcbx As ToolTip = New ToolTip
            toolTipCHIPcbx.SetToolTip(cbxVerslagnrCHIP, "Verslag bestemd voor CHIP")
            toolTipCHIPcbx.Active = True

            'combobox CHIP - firma - naco - 01/03/2011
            Dim dsFirma As New TDSFirmaHRM
            Dim objFirma As New HRMdata
            dsFirma.Merge(objFirma.GetFirma)
            _dataFirmaHRM.Merge(dsFirma.Tables("Firma").Select("", "firmanaam ASC"))


            If _idRegistratie <> -1 Then
                bindRegistratie()
            End If

            'voor usercontrolControleVoertuig
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsControleVoertuig.DatumOpstelling = Now
            End If

            bindBijlagen()
            bindBestemmelingen()
            initializeDataSetConfig()
            initializeDataSetIndividuen()

            'opbouw statusbar
            Dim ctrl As Control
            If Me.IsMdiChild Then
                For Each ctrl In Me.MdiParent.Controls
                    If TypeOf (ctrl) Is ADF.Windows.Forms.UserControls.StatusBar AndAlso Not ctrl Is _statusBar Then
                        _statusBar.Remove()
                        _statusBar = CType(ctrl, ADF.Windows.Forms.UserControls.StatusBar)
                        Exit For
                    End If
                Next
            End If

            Me.UserControlGeneralFunctionsControleVoertuig.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

            Me.MdiParent.Activate()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Binds"

    Private Sub bindRegistratie()
        'Doel:   Registratie gegevens invullen voor een Controle van voertuigen
        'Auteur: Nancy Coppens - 18/09/2006

        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

            _dataRegControleVoertuig.Clear()
            Me._dataRegControleVoertuig.Merge(Me._controller.GetRegControleVoertuig(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegControleVoertuig.BBBEWREGRow
            dr = Me._dataRegControleVoertuig.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsControleVoertuig.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsControleVoertuig.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsControleVoertuig.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsControleVoertuig.SetVeraData(dr.VeraReference,
                                                                        dr.VeraLink)
            End If
            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsControleVoertuig.GetReportContractant = dr.VerslagContractantYN
            End If


            'Controle Voertuiggegevens opvullen
            Dim drCont As TDSRegControleVoertuig.BBKEUTSPRow
            drCont = CType(Me._dataRegControleVoertuig.BBKEUTSP.Rows.Item(0), TDSRegControleVoertuig.BBKEUTSPRow)

            If Not drCont.IsID_BEW_DUPNull Then
                UltraOptionSetBenadeelde.Value = drCont.ID_BEW_DUP
            Else
                UltraOptionSetBenadeelde.Value = Nothing
            End If
            If Not drCont.IsID_WRF_TSPNull Then
                UltraOptionSetSoortVoertuig.Value = drCont.ID_WRF_TSP
            End If

            'Bestuurder
            UltraMaskedEditStamnrBestuurder.Text = CStr(drCont.ID_STUR_TSP_KEU)
            If Not drCont.IsNM_INDNull And Not drCont.IsVNM_INDNull Then
                LabelNaamBestuurder.Text = drCont.NM_IND.Trim & " " & drCont.VNM_IND.Trim
            ElseIf Not drCont.IsNM_INDNull Then
                LabelNaamBestuurder.Text = drCont.NM_IND
            ElseIf Not drCont.IsVNM_INDNull Then
                LabelNaamBestuurder.Text = drCont.VNM_IND
            Else
                LabelNaamBestuurder.Text = ""
            End If
            If Not drCont.IsAD_INDNull Then
                LabelAdresBestuurder.Text = drCont.AD_IND.Trim
            End If
            If Not drCont.IsPO_COD_WNPL_INDNull Then
                LabelAdresBestuurder.Text &= " " & drCont.PO_COD_WNPL_IND.Trim
            End If
            If Not drCont.IsWNPL_INDNull Then
                LabelAdresBestuurder.Text &= " " & drCont.WNPL_IND
            End If
            If Not drCont.IsSAP_AFDNull Then 'toegevoegd sidnaco - 18/09/2006
                LabelSAPAfdeling.Text = drCont.SAP_AFD
            End If

            If Not drCont.IsID_DNS_VTW_WR_KEUNull Then
                UltraMaskedEditStamnrVerantwoordelijke.Text = CStr(drCont.ID_DNS_VTW_WR_KEU)
                If Not drCont.IsNM_IND1Null And Not drCont.IsVNM_IND1Null Then
                    LabelNaamVerantwoordelijke.Text = drCont.NM_IND1.Trim & " " & drCont.VNM_IND1.Trim
                ElseIf Not drCont.IsNM_IND1Null Then
                    LabelNaamVerantwoordelijke.Text = drCont.NM_IND1
                ElseIf Not drCont.IsVNM_IND1Null Then
                    LabelNaamVerantwoordelijke.Text = drCont.VNM_IND1
                Else
                    LabelNaamVerantwoordelijke.Text = ""
                End If
            Else
                UltraMaskedEditStamnrVerantwoordelijke.Text = ""
                LabelNaamVerantwoordelijke.Text = ""
            End If

            If Not drCont.IsID_TSP_KEUNull Then
                TextBoxVoertuigId.Text = CStr(drCont.ID_TSP_KEU)
            End If

            If Not drCont.IsFA_BST_TSPNull Then
                TextBoxBestemmingFabriek.Text = drCont.FA_BST_TSP
            Else
                TextBoxBestemmingFabriek.Text = ""
            End If

            If Not drCont.IsSCF_ORG_KEU_TSPNull Then
                TextBoxKeuringsorganisme.Text = drCont.SCF_ORG_KEU_TSP
            Else
                TextBoxKeuringsorganisme.Text = ""
            End If
            If drCont.IsDT_L_KEU_TSPNull Then
                UltraDateTimeEditorKeuring.Value = Nothing
            Else
                UltraDateTimeEditorKeuring.Value = drCont.DT_L_KEU_TSP
            End If
            If Not drCont.IsOPM_VKLR_TSPNull Then
                TextBoxOpmerkingenAttest.Text = drCont.OPM_VKLR_TSP
            Else
                TextBoxOpmerkingenAttest.Text = ""
            End If

            If Not drCont.IsSCF_DFC_REG_TSPNull Then
                TextBoxDefecten.Text = drCont.SCF_DFC_REG_TSP
            Else
                TextBoxDefecten.Text = ""
            End If
            If Not drCont.IsRGL_NEM_KEUNull Then
                TextBoxMaatregelen.Text = drCont.RGL_NEM_KEU
            Else
                TextBoxMaatregelen.Text = ""
            End If

            'Firma gegevens
            If Not Me._dataRegControleVoertuig.BBFRM.Rows.Count() = 0 Then

                Dim drFirma As TDSRegControleVoertuig.BBFRMRow
                drFirma = CType(Me._dataRegControleVoertuig.BBFRM.Rows.Item(0), TDSRegControleVoertuig.BBFRMRow)

                TextBoxFirmaId.Text = CStr(drFirma.ID_FRM)
                If Not drFirma.IsNM_FRMNull Then
                    LabelFirmaNaam.Text = drFirma.NM_FRM
                End If
                If Not drFirma.IsSTRA_FRMNull Then
                    LabelFirmaAdres.Text = drFirma.STRA_FRM
                End If
                If Not drFirma.IsPO_COD_PLA_FRMNull Then
                    LabelFirmaAdres.Text &= " , " & drFirma.PO_COD_PLA_FRM
                End If
                If Not drFirma.IsPLA_FRMNull Then
                    LabelFirmaAdres.Text &= " " & drFirma.PLA_FRM
                End If
            Else
                TextBoxFirmaId.Text = ""
                LabelFirmaNaam.Text = ""
                LabelFirmaAdres.Text = ""
            End If

            'Voertuig opvullen
            If Not Me._dataRegControleVoertuig.BBTSP.Rows.Count() = 0 Then

                Dim drVoer As TDSRegControleVoertuig.BBTSPRow
                drVoer = CType(Me._dataRegControleVoertuig.BBTSP.Rows.Item(0), TDSRegControleVoertuig.BBTSPRow)

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
                If Not drVoer.IsSCF_TY_TSPNull Then
                    LabelAardVoertuig.Text = drVoer.SCF_TY_TSP
                End If
                If Not drVoer.IsSCF_MRK_TSPNull Then
                    LabelMerkVoertuig.Text = drVoer.SCF_MRK_TSP
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
                For Each Item As Infragistics.Win.UltraWinGrid.UltraGridRow In UltraComboFirma.Rows
                    If Item.Cells("firmanummer").Value.ToString() = dr.SAP_SUPPLIER_ID Then
                        UltraComboFirma.SelectedRow = Item
                        Exit For
                    End If
                Next
            End If

            Me.UserControlGeneralFunctionsControleVoertuig.setBijlageData(Me._dataRegControleVoertuig.BBBYLG)
            Me.UserControlGeneralFunctionsControleVoertuig.setBestemmelingenData(Me._dataRegControleVoertuig.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerControleVoertuigen - bindRegistratie()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindDdlAfdelingen()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - BindDdlAfdelingen()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindAndSetBEWPersoneel()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

            If _idRegistratie = -1 Then 'nieuwe registratie - naco 08/02/2017
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneelActief())
            Else
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneel())
            End If

            Me.UserControlGeneralFunctionsControleVoertuig.setPersoneelData(_dataBEWPersoneel)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindUltraOptionSets()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataWerfVoertuig.Merge(Me._controller.GetWerfVoertuig())

            Me._dataBewakingDup.Merge(Me._controller.GetBewakingDup())
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBijlagen()
        Me.UserControlGeneralFunctionsControleVoertuig.setBijlageData(_dataRegControleVoertuig.BBBYLG)
    End Sub

    Private Sub bindBestemmelingen()
        Me.UserControlGeneralFunctionsControleVoertuig.setBestemmelingenData(_dataRegControleVoertuig.BBBST)
    End Sub
#End Region
#Region "Button and Optionset Eventhandlers"
    Private Sub UltraOptionSetInbreukOp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraOptionSetSoortVoertuig.ValueChanged
        Try
            If _dataWerfVoertuig.BBWRFTSP(CInt(UltraOptionSetSoortVoertuig.Value)).ID_WRF_TSP = 0 Then
                GroupBoxInlichtingenHefwerktuig.Enabled = True
                TextBoxKeuringsorganisme.Text = _keuringsOrganisme
                TextBoxOpmerkingenAttest.Text = _opmerkingenAttest
                UltraDateTimeEditorKeuring.Value = _dateKeuring
            Else
                GroupBoxInlichtingenHefwerktuig.Enabled = False
                If Not TextBoxKeuringsorganisme.Text = "" Then
                    _keuringsOrganisme = TextBoxKeuringsorganisme.Text
                End If
                If Not TextBoxOpmerkingenAttest.Text = "" Then
                    _opmerkingenAttest = TextBoxOpmerkingenAttest.Text
                End If
                If Not UltraDateTimeEditorKeuring.Value Is Nothing Then
                    _dateKeuring = CType(UltraDateTimeEditorKeuring.Value, Date)
                End If
                clearGroupBoxInlichtingenHefwerktuig()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub clearGroupBoxInlichtingenHefwerktuig()
        TextBoxKeuringsorganisme.Text = ""
        UltraDateTimeEditorKeuring.Value = Nothing
        TextBoxOpmerkingenAttest.Text = ""
    End Sub

    Private Sub ButtonKiesFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesFirma.Click
        Try
            Using f_firma As FormBewakingFirmas = New FormBewakingFirmas

                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    TextBoxFirmaId.Text = CStr(f_firma.IdFirma)
                    LabelFirmaNaam.Text = f_firma.NaamFirma
                    LabelFirmaAdres.Text = f_firma.AdresFirma & ", " & f_firma.PostNrFirma & " " & f_firma.GemeenteFirma
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonBestuurder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonBestuurder.Click
        'Doel:
        'Auteur: Koen Heye - mei 2006

        Dim f_ind As FormIndividuen = New FormIndividuen

        Try
            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrBestuurder.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamBestuurder.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamBestuurder.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamBestuurder.Text = individu.VNM_IND
                Else
                    LabelNaamBestuurder.Text = ""
                End If
                If Not individu.IsAD_INDNull Then
                    LabelAdresBestuurder.Text = individu.AD_IND
                End If
                If Not individu.IsPO_COD_WNPL_INDNull Then
                    LabelAdresBestuurder.Text &= " " & individu.PO_COD_WNPL_IND
                End If
                If Not individu.IsWNPL_INDNull Then
                    LabelAdresBestuurder.Text &= " " & individu.WNPL_IND
                End If
                If Not individu.IsSAP_AFDNull Then 'toegevoegd sidnaco - 18/09/2006
                    LabelSAPAfdeling.Text = individu.SAP_AFD
                End If
            End If

            f_ind.Close()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - ButtonKiesPersoonBestuurder_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonVerantwoordelijkeDienst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonVerantwoordelijke.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrVerantwoordelijke.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamVerantwoordelijke.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamVerantwoordelijke.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamVerantwoordelijke.Text = individu.VNM_IND
                Else
                    LabelNaamVerantwoordelijke.Text = ""
                End If
            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesVoertuig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonKiesVoertuig.Click
        Try
            Dim f_voer As FormBewakingVoertuig = New FormBewakingVoertuig

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
            f_voer.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOverzicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOverzicht.Click
        Try
            FormManager.Current.OpenFormOverzichtBewakingRegistratieEntity(False, True, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.setStatus("")
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAnnuleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAnnuleer.Click
        'Doel: als nieuwe interventie => terug alles leeg zetten
        '      als je bestaande interventie aan het wijzigen was: terug alles zetten zoals het in de database staat
        'Auteur: naco - 21/04/2006

        Try
            Me.setStatus("")
            Call Me.bindRegistratie() 'terug ophalen en tonen (zo zit je met de juiste data uit de database)
            Me.setStatus("De wijzigingen werden ongedaan gemaakt")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - UltraButtonAnnuleer_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#End Region
#Region "Functions"
    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsControleVoertuig.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
        UserControlGeneralFunctionsControleVoertuig.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub

    Private Sub setLabelsVerplicht()
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelSoortVoertuig.Text &= " *"
        LabelEigenaar.Text &= " *"
        LabelBestuurder.Text &= " *"
    End Sub
#End Region
#Region "User Control"

    Private Sub UserControlGeneralFunctionsControleVoertuig_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsControleVoertuig.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, String.Empty)

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsControleVoertuig.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsControleVoertuig.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
                End If

            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Textboxevents"
    Private Sub UltraMaskedEditStamnrBestuurder_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrBestuurder.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBestuurder, Me.LabelNaamBestuurder, Me.LabelAdresBestuurder)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrBestuurder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrBestuurder.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditStamnrBestuurder.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBestuurder, Me.LabelNaamBestuurder, Me.LabelAdresBestuurder)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrVerantwoordelijke_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrVerantwoordelijke.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrVerantwoordelijke, Me.LabelNaamVerantwoordelijke, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrVerantwoordelijke_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrVerantwoordelijke.KeyDown
        'Doel:   naam verantwoordelijke tonen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                If UltraMaskedEditStamnrVerantwoordelijke.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te vullen aub.", "Stamnummer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim stamnr As Integer = CInt(UltraMaskedEditStamnrVerantwoordelijke.Text)

                If FormManager.Current Is Nothing Then
                    'MDI-form gesloten
                    Exit Sub
                Else
                    Dim individu As TDSIndividuen.BBINDRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(CInt(stamnr))
                    If individu Is Nothing Then
                        LabelNaamVerantwoordelijke.Text = ""
                        UltraMaskedEditStamnrVerantwoordelijke.Text = ""

                        MessageBox.Show("Het stamnummer " & stamnr & " werd niet teruggevonden.", "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        UltraMaskedEditStamnrVerantwoordelijke.Focus()
                        Exit Sub
                    ElseIf Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                        LabelNaamVerantwoordelijke.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                    ElseIf Not individu.IsNM_INDNull Then
                        LabelNaamVerantwoordelijke.Text = individu.NM_IND
                    ElseIf Not individu.IsVNM_INDNull Then
                        LabelNaamVerantwoordelijke.Text = individu.VNM_IND
                    Else
                        LabelNaamVerantwoordelijke.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub handleAfterStamnrLeave(ByRef UltraMaskedEditStamnr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit, ByRef LabelNaam As Label, ByRef LabelAdres As Label)
        'Doel:   naam, adres en afdeling invullen
        'Auteur: studenten - mei 2006

        If UltraMaskedEditStamnr.Text <> "" Then
            Try
                Dim stamnr As Integer = CInt(UltraMaskedEditStamnr.Text)
                If FormManager.Current Is Nothing Then
                    'MDI-form gesloten
                    Exit Sub
                Else
                    Dim individu As TDSIndividuen.BBINDRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(CInt(stamnr))
                    If individu Is Nothing Then
                        LabelNaam.Text = ""
                        If Not LabelAdres Is Nothing Then
                            LabelAdres.Text = ""
                        End If
                        UltraMaskedEditStamnr.Text = ""
                        MessageBox.Show("Het stamnummer " & stamnr & " werd niet teruggevonden.", "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        UltraMaskedEditStamnr.Focus()
                        Exit Sub
                    ElseIf Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                        LabelNaam.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                    ElseIf Not individu.IsNM_INDNull Then
                        LabelNaam.Text = individu.NM_IND
                    ElseIf Not individu.IsVNM_INDNull Then
                        LabelNaam.Text = individu.VNM_IND
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

                    If Not individu.IsSAP_AFDNull Then 'naco - 27/12/2006
                        LabelSAPAfdeling.Text = individu.SAP_AFD()
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & " " & ex.StackTrace, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            LabelNaam.Text = ""
            If Not LabelAdres Is Nothing Then
                LabelAdres.Text = ""
            End If
        End If
    End Sub
#End Region
#Region "Opslaan"
    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        'Doel: nieuw controle voertuig toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 04/05/2006
        Try

            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus("De controle van het voertuig werd succesvol opgeslagen")
            Else
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub opslaanRegistratie()
        'Doel: 
        'Auteur: Koen Heye - mei 2006

        Cursor.Current = Cursors.WaitCursor
        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

        Dim dsControleVoertuig As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig
        Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBEWREGRow
        Dim drControleVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBKEUTSPRow
        Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBYLGRow
        Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try
            dsControleVoertuig.BBBST.DataSet.Clear()
            dsControleVoertuig.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsControleVoertuig.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsControleVoertuig.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd
            If (UserControlGeneralFunctionsControleVoertuig.CheckBestemmelingen(dsBest) = True) Then
                _controller = New ControllerGetData

                If Me._idRegistratie = -1 Then 'nieuw controle voertuig

                    drRegistratie = dsControleVoertuig.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(Me.UserControlGeneralFunctionsControleVoertuig.getOpstelDatum, id_reg, volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsControleVoertuig.Opsteller
                        .ID_TY_REG = 2
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsControleVoertuig.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsControleVoertuig.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsControleVoertuig.GetVeraReference
                        .VerslagContractantYN = Me.UserControlGeneralFunctionsControleVoertuig.GetReportContractant
                    End With
                    dsControleVoertuig.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Controle voertuig
                    '--------------
                    drControleVoertuig = dsControleVoertuig.BBKEUTSP.NewBBKEUTSPRow
                    With drControleVoertuig
                        .ID_REG = id_reg
                        .ID_STUR_TSP_KEU = CInt(UltraMaskedEditStamnrBestuurder.Text)
                        If Not TextBoxFirmaId.Text = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        If Not TextBoxVoertuigId.Text = "" Then
                            .ID_TSP_KEU = CInt(TextBoxVoertuigId.Text)
                        End If
                        If Not UltraMaskedEditStamnrVerantwoordelijke.Text = "" Then
                            .ID_DNS_VTW_WR_KEU = CInt(UltraMaskedEditStamnrVerantwoordelijke.Text)
                        End If
                        'controles op null mogen weg
                        If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                            .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                        End If
                        .ID_WRF_TSP = CInt(UltraOptionSetSoortVoertuig.Value)
                        'Deze 3 velden worden enkel ingevuld bij een hefwerktuig
                        If _dataWerfVoertuig.BBWRFTSP(CInt(UltraOptionSetSoortVoertuig.Value)).ID_WRF_TSP = 0 Then
                            .SCF_ORG_KEU_TSP = TextBoxKeuringsorganisme.Text
                            .DT_L_KEU_TSP = CDate(UltraDateTimeEditorKeuring.Text)
                            .OPM_VKLR_TSP = TextBoxOpmerkingenAttest.Text
                        Else
                            'Dim nullDate As Date
                            .SCF_ORG_KEU_TSP = ""
                            '.DT_L_KEU_TSP = nullDate
                            .SetDT_L_KEU_TSPNull()
                            .OPM_VKLR_TSP = ""
                        End If
                        If Not TextBoxBestemmingFabriek.Text = "" Then
                            .FA_BST_TSP = TextBoxBestemmingFabriek.Text
                        End If
                        If Not TextBoxDefecten.Text = "" Then
                            .SCF_DFC_REG_TSP = TextBoxDefecten.Text
                        End If
                        If Not TextBoxMaatregelen.Text = "" Then
                            .RGL_NEM_KEU = TextBoxMaatregelen.Text
                        End If
                    End With
                    dsControleVoertuig.BBKEUTSP.AddBBKEUTSPRow(drControleVoertuig)

                    '3. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    Dim drByl As DataRow
                    Dim chronicleID As String

                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsControleVoertuig.BBBYLG.NewBBBYLGRow
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
                            chronicleID = UploadControleVoertoegenBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If
                        dsControleVoertuig.BBBYLG.AddBBBYLGRow(drBylagen)
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegControleVoertuig.BBBSTRow
                    Dim drBest As DataRow
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsControleVoertuig.BBBST.NewBBBSTRow
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

                        dsControleVoertuig.BBBST.AddBBBSTRow(drBestemmelingen)
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

                Else 'bestaande controle voertuig wijzigen
                    dsControleVoertuig.Merge(Me._controller.GetRegControleVoertuig(Me._idRegistratie))
                    drRegistratie = dsControleVoertuig.BBBEWREG.FindByID_REG(Me._idRegistratie)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsControleVoertuig.Opsteller
                        .ID_TY_REG = 2
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsControleVoertuig.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsControleVoertuig.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsControleVoertuig.GetVeraReference
                        .VerslagContractantYN = UserControlGeneralFunctionsControleVoertuig.GetReportContractant
                    End With

                    '2. Controle voertuig
                    '--------------
                    drControleVoertuig = CType(dsControleVoertuig.BBKEUTSP.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBKEUTSPRow)
                    With drControleVoertuig
                        .ID_REG = Me._idRegistratie
                        .ID_STUR_TSP_KEU = CInt(UltraMaskedEditStamnrBestuurder.Text)
                        If Not TextBoxFirmaId.Text = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        If Not TextBoxVoertuigId.Text = "" Then
                            .ID_TSP_KEU = CInt(TextBoxVoertuigId.Text)
                        End If
                        If Not UltraMaskedEditStamnrVerantwoordelijke.Text = "" Then
                            .ID_DNS_VTW_WR_KEU = CInt(UltraMaskedEditStamnrVerantwoordelijke.Text)
                        End If
                        If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                            .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                        End If
                        .ID_WRF_TSP = CInt(UltraOptionSetSoortVoertuig.Value)
                        'Deze 3 velden worden enkel ingevuld bij een hefwerktuig
                        If _dataWerfVoertuig.BBWRFTSP(CInt(UltraOptionSetSoortVoertuig.Value)).ID_WRF_TSP = 0 Then
                            .SCF_ORG_KEU_TSP = TextBoxKeuringsorganisme.Text
                            .DT_L_KEU_TSP = CDate(UltraDateTimeEditorKeuring.Text)
                            .OPM_VKLR_TSP = TextBoxOpmerkingenAttest.Text
                        Else
                            'Dim nullDate As Date
                            .SCF_ORG_KEU_TSP = ""
                            .SetDT_L_KEU_TSPNull()
                            .OPM_VKLR_TSP = ""
                        End If
                        If Not TextBoxBestemmingFabriek.Text = "" Then
                            .FA_BST_TSP = TextBoxBestemmingFabriek.Text
                        End If
                        If Not TextBoxDefecten.Text = "" Then
                            .SCF_DFC_REG_TSP = TextBoxDefecten.Text
                        End If
                        If Not TextBoxMaatregelen.Text = "" Then
                            .RGL_NEM_KEU = TextBoxMaatregelen.Text
                        End If
                    End With

                    '3. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------

                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBYLGRow

                    For Each drBylg In dsControleVoertuig.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsControleVoertuig.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                If (Not drBylg.IsID_DOCNull) Then
                                    'Bijhouden van de verwijderde chronicleID's in een array zodat deze op het einde (nadat het bewaren is gelukt)
                                    'kunnen verwijderd worden uit documentum
                                    arrayOfDeletedChronicleID.Add(drBylg.ID_DOC)
                                End If
                                drBylg.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBYLG As DataRow
                    Dim chronicleID As String = ""
                    For Each drGridBYLG In dsByl.Tables(0).Rows
                        'Opsturen van de bijlage naar documentum wanneer dit nog niet is gebeurd.
                        If (drGridBYLG.RowState <> DataRowState.Deleted) Then
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                chronicleID = UploadControleVoertoegenBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If

                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsControleVoertuig.BBBYLG.NewBBBYLGRow

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

                            dsControleVoertuig.BBBYLG.AddBBBYLGRow(drBylagen)

                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsControleVoertuig.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBYLGRow)

                                drBylagen.ID_REG = Me._idRegistratie
                                drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                                If Not drGridBYLG.Item("SCF_BYLG") Is DBNull.Value Then
                                    drBylagen.SCF_BYLG = CType(drGridBYLG.Item("SCF_BYLG"), String)
                                Else
                                    drBylagen.SCF_BYLG = ""
                                End If
                                If chronicleID <> "" Then
                                    drBylagen.Item("ID_DOC") = chronicleID
                                End If
                            End If

                        ElseIf drGridBYLG.RowState = DataRowState.Unchanged Then
                            'Wanneer een document nog niet is doorgestuurd naar documentum,
                            'mag dit alsnog gebeuren ook al is er niets veranderd aan de registratie
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                Dim arrBylg() As DataRow
                                arrBylg = dsControleVoertuig.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBYLGRow)
                                    If chronicleID <> "" Then
                                        drBylagen.Item("ID_DOC") = chronicleID
                                    End If
                                End If
                            End If
                        End If
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig.BBBSTRow

                    For Each drBest In dsControleVoertuig.BBBST.Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsControleVoertuig.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drGridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsControleVoertuig.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._idRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsControleVoertuig.BBBST.AddBBBSTRow(drBestemmelingen)
                        End If
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
                Dim ds As New Proxy.BBWService.Mgt.TDSControleVoertuig
                ds.Merge(dsControleVoertuig.GetChanges)

                proxy.RegisterRegistratieControleVoertuig(ds, System.Environment.UserName)

                dsControleVoertuig.AcceptChanges()
                'als het om een nieuw controle voertuig gaat, worden volgende velden ingevuld
                If Me._idRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsControleVoertuig.getOpstelDatum)
                    'id instellen zodat er bij het refreshen geen nieuw scherm getoond wordt
                    Me._idRegistratie = id_reg
                End If
            End If
            Call Me.bindRegistratie()

            If arrayOfDeletedChronicleID.Count > 0 Then
                For Each aChronicleId As String In arrayOfDeletedChronicleID
                    Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                Next
            End If

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerControleVoertuigen - ButtonOpslaan_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Function UploadControleVoertoegenBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
        'Doel:   Uploaden van de bijlage van een aanrijdingsverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(UltraDateTimeEditorDatum.DateTime) & "/" & volgnr & " - " & LabelTitel.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BEWAKING", "FolderPathDocumentum").WD()

        Return BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName, documentumFolderPath)

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
        If UltraOptionSetSoortVoertuig.Value Is Nothing Then
            errorBool = False
        End If
        If UltraMaskedEditStamnrBestuurder.Text = "" Then
            errorBool = False
        End If
        If TextBoxVoertuigId.Text = "" Then
            errorBool = False
        End If
        If Not UserControlGeneralFunctionsControleVoertuig.checkPersoneelOK Then
            errorBool = False
        End If
        Return errorBool
    End Function

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub

    Private Sub FormBewakingControleVoertuigen_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Afdrukken rapport"
    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.showReport()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - UltraButtonAfdrukken_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
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
                dr = MessageBox.Show("De registratie dient eerst opgeslagen te worden. Wilt u het nu opslaan?", "Opslaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If dr = DialogResult.Yes Then
                    'opslaan
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        If controleVeldenOK() Then
                            Me.opslaanRegistratie()

                            'rapport tonen
                            f_rap.InterventieID = Me._idRegistratie
                            f_rap.Show()
                            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                              "RegistratieDiverseControle", _
                                              "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "RegistratieDiverseControle")
                            'report.AddParameter("ID_REG", Me._IDRegistratie)
                            'f_rap.ExportPDF()

                            Me.setStatus("Het interventieverslag werd succesvol opgeslagen")
                        Else
                            MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                        "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf & _
                                        "Message: " & ex.Message & vbCrLf & _
                                        "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                    Cursor.Current = Cursors.Default
                End If
            Else
                If controleVeldenOK() Then
                    'rapport tonen
                    f_rap.InterventieID = Me._idRegistratie
                    f_rap.Show()
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieDiverseControle", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                    'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking")
                    'report.AddParameter("ID_REG", Me._IDRegistratie)
                    'f_rap.ExportPDF()
                Else
                    MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - showReport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub
#End Region

#Region "Buttons verzending"
    Private Sub ButtonVerzendingBBW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerzendingBBW.Click
        'Doel:   verstuur verslag naar postoverste
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 22/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            If TextBoxVerslagnummer.Text = "" Then
                MessageBox.Show("Gelieve eerst een registratie aan te maken en/of op te slaan", "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            ElseIf Not controleVeldenOK() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorVerzending.Value = Now
                Me.opslaanRegistratie()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf & _
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                            "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                            "Opsteller:         " & UserControlGeneralFunctionsControleVoertuig.getOpsteller & vbCrLf & vbCrLf & _
                            "Opmerking Opsteller: " & TextBoxVerzending.Text
                Dim mailTo As New ArrayList
                mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Postoverste").WD)
                Me.sendMail(mailTo, textMail, "Nieuwe registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text, pathsAttachment)

                Me.setStatus("Het registratieverslag werd succesvol verzonden")
                If FormManager.Current.Bewaking Then
                    UltraButtonOpslaan.Enabled = False
                End If
                ButtonTerugZenden.Enabled = True

            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - ButtonVerzendingBBW_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonGoedkeuring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 22/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorGoedkeuring.Value = Now
            Me.opslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Verzending").WD & vbCrLf
            textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsControleVoertuig.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Verantwoordelijke").WD)
            Me.sendMail(mailTo, _
                        textMail, _
                        "Goedgekeurde registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text, _
                        pathsAttachment)

            Me.setStatus("De registratie werd succesvol goedgekeurd")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - ButtonGoedkeuring_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub ButtonTerugZenden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTerugZenden.Click
        'Doel:   Terugsturen verslag naar groepsusernaam van bewaking
        'Auteur: Mieke Duynslager - mei 2007

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            Me.opslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Terugzenden").WD & vbCrLf & vbCrLf
            textMail &= "Onderstaand verslag kan niet worden goedgekeurd. Gelieve het verslag te wijzigen." & vbCrLf & vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsControleVoertuig.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking: " & TextBoxGoedkeuring.Text

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Bewaking").WD)
            Me.sendMail(mailTo, _
                        textMail, _
                        "Teruggezonden registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text, _
                        pathsAttachment)

            ButtonTerugZenden.Enabled = False
            ButtonVerzendingBBW.Enabled = True

            Me.setStatus("De registratie werd teruggestuurd.")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - ButtonTerugZenden_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonVerzendingBest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerzendingBest.Click
        'Doel:   verstuur verslag naar bestemmelingen
        'DUMI: 19/9/2007: Er bestaan twee types bestemmelingen. Voor de internen (best) sturen we voor de bijlagen de URL van documentum door.
        'Voor de externe bestemmelingen (specbest) (die niet behoren tot het Arcelor-domein) sturen we de bijlagen als attachment door.
        'Auteur: Koen Heye - mei 2006
        'Wijzigingen: Nancy Coppens - 19/09/2006

        Dim best As New ArrayList
        Dim titelMail As String
        Dim textMail As String
        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim specBest As New ArrayList
        Dim textMailURL As String = ""
        Dim specPathsAttachment As New ArrayList
        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim dsSpecBest As New TDSBBBSTBY
        Dim drSpecBest As TDSBBBSTBY.BBBSTBYRow
        Dim IsSpecialBest As Boolean = False
        Dim IsNormalBest As Boolean = False

        Try
            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsControleVoertuig.getDataBestemmelingen.Tables(0).Rows
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
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsControleVoertuig.getDataBijlagen.Tables(0).Rows
                If bijlageRow.RowState = DataRowState.Deleted Then
                    'het kan zijn dat er juist een bijlage gedelete is
                Else
                    Dim fi As New FileInfo(bijlageRow.PLA_BYLG)
                    If fi.Exists = False Then
                        MessageBox.Show("OPGELET: verslag kan niet doorgemaild worden." & vbCrLf & vbCrLf & _
                                        "Bijlage '" & bijlageRow.PLA_BYLG & "' kan niet teruggevonden worden." & _
                                        vbCrLf & "Gelieve het path van deze bijlage aan te passen aub.", "Bijlage niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.setStatus("")
                        Exit Sub
                    End If
                End If
            Next

            If best.Count <> 0 Or specBest.Count <> 0 Then
                Me.opslaanRegistratie()

                'Eerst rapport exporteren naar PDF-file
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD & _
                               "Bewaking" & Year(Now) & "_" & Me._idRegistratie & ".pdf"
                pathsAttachment.Add(pathPDFfile)
                specPathsAttachment.Add(pathPDFfile)

                Dim nullDate As Date
                If CDate(UltraDateTimeEditorBestemmelingen.Value) = nullDate Then 'naco - feb 2013
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Bestemmelingen").WD & vbCrLf 'nieuw verslag
                Else
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "BestemmelingenWijziging").WD & vbCrLf
                End If

                textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsControleVoertuig.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String
                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsControleVoertuig.getDataBijlagen.Tables(0).Rows
                    If bijlageRow.RowState = DataRowState.Deleted Then
                        'het kan zijn dat er juist een bijlage gedelete is
                    Else
                        If (best.Count > 0) Then
                            'juli 2007 - dumi -Als er een chronicleID bestaat voor de bijlage, betekent dit dat het al werd opgeladen in documentum.
                            'Dan kan de url worden samengesteld die de link vormt naar documentum.
                            'vb url: http://svsim045.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0901bad18001a60f&latestflag=y
                            If (Not IsDBNull(bijlageRow.Item("ID_DOC"))) Then
                                urlString = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_PRE", "Path").WD & bijlageRow.ID_DOC & _
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
                f_rap.ExportPDFBewakingRegistratie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                                   "DiverseBewaking", _
                                                   pathPDFfile, _
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

                Me.setStatus("Registratieverslag succesvol verzonden naar de bestemmelingen")

            Else
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")

            MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingControleVoertuigen - ButtonVerzendingBest_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cbxVerslagnrCHIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVerslagnrCHIP.CheckedChanged
        'Doel: Registratie markeren voor CHIP verslag
        'Auteur: Lawrence Verbruggen
        'Aangemaakt: 04/03/2011

        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
        proxy.CHIPRegistration(Me._idRegistratie, Me.cbxVerslagnrCHIP.Checked)

        'Als CheckBox aangevinkt sta, dan markeren voor CHIP, anders markering voor CHIP verwijderen
        If FormManager.Current.IKPvtw Then
            Me.ButtonNaarCHIP.Enabled = False
        Else
            Me.ButtonNaarCHIP.Enabled = Me.cbxVerslagnrCHIP.Checked
        End If
        Me.setStatus("Registratie klaar voor CHIP")

    End Sub

    Private Sub ButtonNaarCHIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNaarCHIP.Click
        'Doel:   Versturen naar CHIP data
        'Auteur: Lawrence Verbruggen (SIDLAWV)
        'Aangemaakt: 04/03/2011
        Dim nullDate As Date

        Try
            'Is de registratie volledig en opgeslaan
            If TextBoxVerslagnummer.Text = "" Then
                MessageBox.Show("Gelieve eerst een registratie aan te maken en/of op te slaan", "Naar CHIP zenden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
                'Zijn alle velden correct ingevuld
            ElseIf Not controleVeldenOK() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Werd ze reeds naar Bestemmelingen verstuurd
            ElseIf UltraDateTimeEditorBestemmelingen.DateTime.Date = nullDate Then
                MessageBox.Show("Registratie moet eerst verzonden worden naar bestemmelingen", "Naar CHIP zenden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Is de registratie bestemd voor CHIP
            ElseIf cbxVerslagnrCHIP.Checked = False Then
                MessageBox.Show("Registratie moet aangevinkt zijn voor CHIP", "Naar CHIP zenden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Werd de betrokken leverancier geselecteerd
            ElseIf UltraComboFirma.Value Is Nothing OrElse UltraComboFirma.Value.ToString() = "" Then
                MessageBox.Show("Gelieve eerst een leverancier te selecteren", "Naar CHIP zenden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorNaarCHIP.Value = DateTime.Now
                Me.setStatus("")

                Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                proxy.CHIPUpdate(Me._idRegistratie, Me.UltraComboFirma.Value.ToString(), _
                                                        DateTime.Now.Date, Me.TextBoxNaarCHIP.Text)

                Me.setStatus("Registratie succesvol opgeslaan voor CHIP")
            End If


        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - ButtonNaarCHIP_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub
#End Region

#Region "Mailing"
    Private Sub sendMail(ByVal mailTo As ArrayList, ByVal aText As String, _
                         ByVal subject As String, ByVal pathAttach As ArrayList)
        Try
            MailBBW.sendMail(mailTo, aText, subject, pathAttach)

            Me.setStatus("Registratie succesvol verzonden naar de bestemmelingen")
        Catch ex As Exception
            Me.setStatus("OPGELET: registratie niet verzonden naar de bestemmelingen")

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
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
            ElseIf FormManager.Current.BBWVerantwoordelijke Then
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
                GroupBoxOverige.Enabled = False
                GroupBoxBestuurder.Enabled = False
                GroupBoxVoertuig.Enabled = False
                Extra.Enabled = False
                GroupBoxInlichtingenHefwerktuig.Enabled = False
                UserControlGeneralFunctionsControleVoertuig.Enabled = False
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
                ButtonVerzendingBest.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - intializeMailInfo" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
#End Region

    Private Sub UltraDateTimeEditorVerzending_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraDateTimeEditorVerzending.ValueChanged
        If UltraDateTimeEditorVerzending.Value Is Nothing And Not FormManager.Current.Chip Then
            ButtonVerzendingBBW.Enabled = True
        Else
            ButtonVerzendingBBW.Enabled = False
        End If

        If FormManager.Current.IKPvtw Then
            ButtonVerzendingBBW.Enabled = False
        End If
    End Sub

    
    Private Sub ButtonMailIKP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMailIKP.Click
        If MessageBox.Show("Mag vink Chip aangevinkt worden?", "Chip aanvinken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            SendMailIKP()
        End If
        cbxVerslagnrCHIP.Checked = True
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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsControleVoertuig.getDataBijlagen.Tables(0).Rows

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
            '    UserControlGeneralFunctionsControleVoertuig.getDataBijlagen.Tables(0).Rows

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
                "DiverseBewaking",
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
                             "Form: FormBewakingControleVoertuigen - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
