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

Public Class FormBewakingSchadegeval
    Inherits System.Windows.Forms.Form

#Region "Variabelen"
    Private _idRegistratie As Integer = -1
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonInfoChip As System.Windows.Forms.Button
    Friend WithEvents _dataFirmaHRM As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM
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
        setLabelsVerplicht()
    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()

        Me._idRegistratie = IdReg

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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBoxHoofding As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaats As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaats As System.Windows.Forms.Label
    Friend WithEvents LabelUur As System.Windows.Forms.Label
    Friend WithEvents LabelDatum As System.Windows.Forms.Label
    Friend WithEvents TextBoxVerslagnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerslagnr As System.Windows.Forms.Label
    Friend WithEvents LabelTitel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxInlichtingen As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAard As System.Windows.Forms.Label
    Friend WithEvents LabelOorzaak As System.Windows.Forms.Label
    Friend WithEvents TextBoxAard As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOorzaak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxVerzekering As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPolisnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelPolisnummer As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesVerzekering As System.Windows.Forms.Button
    Friend WithEvents LabelVerzekering As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents LabelSchadeAan As System.Windows.Forms.Label
    Friend WithEvents UltraOptionSetSchadeAan As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents LabelBenadeelde As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAangever As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents LabelAangever As System.Windows.Forms.Label
    Friend WithEvents LabelFirma As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesFirma As System.Windows.Forms.Button
    Friend WithEvents GroupBoxVoertuig As System.Windows.Forms.GroupBox
    Friend WithEvents LabelEigenaar As System.Windows.Forms.Label
    Friend WithEvents LabelMerk As System.Windows.Forms.Label
    Friend WithEvents LabelNummerplaat As System.Windows.Forms.Label
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents _dataRegSchadegeval As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegSchadegeval
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UserControlGeneralFunctionsSchadegeval As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataScadObjecten As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSScadObjecten
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents TextBoxVerzFirmaId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFirmaId As System.Windows.Forms.TextBox
    Friend WithEvents LabelChassisnummer As System.Windows.Forms.Label
    Friend WithEvents TextBoxVoertuigId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxSchadegeval As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ButtonKiesPersoonAangever As System.Windows.Forms.Button
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents TextBoxBtwnr As System.Windows.Forms.TextBox
    Friend WithEvents LabelBtwnr As System.Windows.Forms.Label
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraOptionSetBenadeelde As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents _dataBewakingDup As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingDup
    Friend WithEvents ButtonKiesVoertuig As System.Windows.Forms.Button
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents UltraMaskedEditStamnrAangever As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents LabelNaamAangever As System.Windows.Forms.Label
    Friend WithEvents LabelAdresAangever As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaNaam As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaAdres As System.Windows.Forms.Label
    Friend WithEvents LabelStamnrEigenaar As System.Windows.Forms.Label
    Friend WithEvents LabelNaamEigenaar As System.Windows.Forms.Label
    Friend WithEvents LabelMerkVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelNummerplaatVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelChassisnummerVoertuig As System.Windows.Forms.Label
    Friend WithEvents LabelVerzekeringsNaam As System.Windows.Forms.Label
    Friend WithEvents LabelVerzekeringsAdres As System.Windows.Forms.Label
    Friend WithEvents TextBoxOpmerkingen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSAPAfdeling As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingSchadegeval))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Firma", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanaam")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanummer")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parent")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parentnaam")
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
        Me.GroupBoxInlichtingen = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxOpmerkingen = New System.Windows.Forms.TextBox()
        Me.TextBoxOorzaak = New System.Windows.Forms.TextBox()
        Me.TextBoxAard = New System.Windows.Forms.TextBox()
        Me.LabelOorzaak = New System.Windows.Forms.Label()
        Me.LabelAard = New System.Windows.Forms.Label()
        Me.GroupBoxVerzekering = New System.Windows.Forms.GroupBox()
        Me.LabelVerzekeringsAdres = New System.Windows.Forms.Label()
        Me.LabelVerzekeringsNaam = New System.Windows.Forms.Label()
        Me.TextBoxVerzFirmaId = New System.Windows.Forms.TextBox()
        Me.TextBoxPolisnummer = New System.Windows.Forms.TextBox()
        Me.LabelPolisnummer = New System.Windows.Forms.Label()
        Me.ButtonKiesVerzekering = New System.Windows.Forms.Button()
        Me.LabelVerzekering = New System.Windows.Forms.Label()
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me.UltraOptionSetBenadeelde = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataBewakingDup = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBewakingDup()
        Me.LabelBenadeelde = New System.Windows.Forms.Label()
        Me.UltraOptionSetSchadeAan = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataScadObjecten = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSScadObjecten()
        Me.LabelSchadeAan = New System.Windows.Forms.Label()
        Me.GroupBoxAangever = New System.Windows.Forms.GroupBox()
        Me.LabelSAPAfdeling = New System.Windows.Forms.Label()
        Me.LabelFirmaAdres = New System.Windows.Forms.Label()
        Me.LabelFirmaNaam = New System.Windows.Forms.Label()
        Me.LabelAdresAangever = New System.Windows.Forms.Label()
        Me.LabelNaamAangever = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrAangever = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxBtwnr = New System.Windows.Forms.TextBox()
        Me.LabelBtwnr = New System.Windows.Forms.Label()
        Me.TextBoxFirmaId = New System.Windows.Forms.TextBox()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.ButtonKiesFirma = New System.Windows.Forms.Button()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.LabelAangever = New System.Windows.Forms.Label()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonAangever = New System.Windows.Forms.Button()
        Me.GroupBoxVoertuig = New System.Windows.Forms.GroupBox()
        Me.LabelChassisnummerVoertuig = New System.Windows.Forms.Label()
        Me.LabelNummerplaatVoertuig = New System.Windows.Forms.Label()
        Me.LabelMerkVoertuig = New System.Windows.Forms.Label()
        Me.LabelNaamEigenaar = New System.Windows.Forms.Label()
        Me.LabelStamnrEigenaar = New System.Windows.Forms.Label()
        Me.TextBoxVoertuigId = New System.Windows.Forms.TextBox()
        Me.LabelChassisnummer = New System.Windows.Forms.Label()
        Me.LabelNummerplaat = New System.Windows.Forms.Label()
        Me.LabelMerk = New System.Windows.Forms.Label()
        Me.LabelEigenaar = New System.Windows.Forms.Label()
        Me.ButtonKiesVoertuig = New System.Windows.Forms.Button()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsSchadegeval = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me._dataRegSchadegeval = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegSchadegeval()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me.GroupBoxSchadegeval = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBoxInlichtingen.SuspendLayout()
        Me.GroupBoxVerzekering.SuspendLayout()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetSchadeAan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataScadObjecten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAangever.SuspendLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVoertuig.SuspendLayout()
        Me.GroupBoxOverige.SuspendLayout()
        CType(Me._dataRegSchadegeval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSchadegeval.SuspendLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(608, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(384, 20)
        Me.TextBoxKorteOms.TabIndex = 1015
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1016
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(408, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.NonAutoSizeHeight = 20
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 6
        Me.UltraMaskedEditUur.Text = ":"
        Me.UltraMaskedEditUur.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(408, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 4
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(608, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(384, 20)
        Me.TextBoxPlaats.TabIndex = 8
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(560, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 7
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(368, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 5
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(352, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 3
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(248, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.AutoSize = True
        Me.LabelVerslagnr.Location = New System.Drawing.Point(184, 24)
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
        Me.LabelTitel.Size = New System.Drawing.Size(164, 29)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Schadegeval"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(192, 24)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 16)
        Me.LabelVolgnr.TabIndex = 9
        Me.LabelVolgnr.Visible = False
        '
        'GroupBoxInlichtingen
        '
        Me.GroupBoxInlichtingen.Controls.Add(Me.Label1)
        Me.GroupBoxInlichtingen.Controls.Add(Me.TextBoxOpmerkingen)
        Me.GroupBoxInlichtingen.Controls.Add(Me.TextBoxOorzaak)
        Me.GroupBoxInlichtingen.Controls.Add(Me.TextBoxAard)
        Me.GroupBoxInlichtingen.Controls.Add(Me.LabelOorzaak)
        Me.GroupBoxInlichtingen.Controls.Add(Me.LabelAard)
        Me.GroupBoxInlichtingen.Location = New System.Drawing.Point(0, 218)
        Me.GroupBoxInlichtingen.Name = "GroupBoxInlichtingen"
        Me.GroupBoxInlichtingen.Size = New System.Drawing.Size(1008, 195)
        Me.GroupBoxInlichtingen.TabIndex = 5
        Me.GroupBoxInlichtingen.TabStop = False
        Me.GroupBoxInlichtingen.Text = "Inlichtingen beschadiging"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Opmerkingen:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxOpmerkingen
        '
        Me.TextBoxOpmerkingen.Location = New System.Drawing.Point(80, 124)
        Me.TextBoxOpmerkingen.MaxLength = 5000
        Me.TextBoxOpmerkingen.Multiline = True
        Me.TextBoxOpmerkingen.Name = "TextBoxOpmerkingen"
        Me.TextBoxOpmerkingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOpmerkingen.Size = New System.Drawing.Size(920, 65)
        Me.TextBoxOpmerkingen.TabIndex = 4
        '
        'TextBoxOorzaak
        '
        Me.TextBoxOorzaak.Location = New System.Drawing.Point(80, 70)
        Me.TextBoxOorzaak.MaxLength = 2000
        Me.TextBoxOorzaak.Multiline = True
        Me.TextBoxOorzaak.Name = "TextBoxOorzaak"
        Me.TextBoxOorzaak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOorzaak.Size = New System.Drawing.Size(920, 48)
        Me.TextBoxOorzaak.TabIndex = 3
        '
        'TextBoxAard
        '
        Me.TextBoxAard.Location = New System.Drawing.Point(80, 16)
        Me.TextBoxAard.MaxLength = 2000
        Me.TextBoxAard.Multiline = True
        Me.TextBoxAard.Name = "TextBoxAard"
        Me.TextBoxAard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAard.Size = New System.Drawing.Size(920, 48)
        Me.TextBoxAard.TabIndex = 1
        '
        'LabelOorzaak
        '
        Me.LabelOorzaak.AutoSize = True
        Me.LabelOorzaak.Location = New System.Drawing.Point(6, 64)
        Me.LabelOorzaak.Name = "LabelOorzaak"
        Me.LabelOorzaak.Size = New System.Drawing.Size(50, 13)
        Me.LabelOorzaak.TabIndex = 2
        Me.LabelOorzaak.Text = "Oorzaak:"
        Me.LabelOorzaak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAard
        '
        Me.LabelAard.AutoSize = True
        Me.LabelAard.Location = New System.Drawing.Point(6, 16)
        Me.LabelAard.Name = "LabelAard"
        Me.LabelAard.Size = New System.Drawing.Size(32, 13)
        Me.LabelAard.TabIndex = 0
        Me.LabelAard.Text = "Aard:"
        Me.LabelAard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxVerzekering
        '
        Me.GroupBoxVerzekering.Controls.Add(Me.LabelVerzekeringsAdres)
        Me.GroupBoxVerzekering.Controls.Add(Me.LabelVerzekeringsNaam)
        Me.GroupBoxVerzekering.Controls.Add(Me.TextBoxVerzFirmaId)
        Me.GroupBoxVerzekering.Controls.Add(Me.TextBoxPolisnummer)
        Me.GroupBoxVerzekering.Controls.Add(Me.LabelPolisnummer)
        Me.GroupBoxVerzekering.Controls.Add(Me.ButtonKiesVerzekering)
        Me.GroupBoxVerzekering.Controls.Add(Me.LabelVerzekering)
        Me.GroupBoxVerzekering.Location = New System.Drawing.Point(600, 155)
        Me.GroupBoxVerzekering.Name = "GroupBoxVerzekering"
        Me.GroupBoxVerzekering.Size = New System.Drawing.Size(408, 64)
        Me.GroupBoxVerzekering.TabIndex = 4
        Me.GroupBoxVerzekering.TabStop = False
        Me.GroupBoxVerzekering.Text = "Verzekering"
        '
        'LabelVerzekeringsAdres
        '
        Me.LabelVerzekeringsAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelVerzekeringsAdres.Location = New System.Drawing.Point(48, 40)
        Me.LabelVerzekeringsAdres.Name = "LabelVerzekeringsAdres"
        Me.LabelVerzekeringsAdres.Size = New System.Drawing.Size(200, 20)
        Me.LabelVerzekeringsAdres.TabIndex = 2
        Me.LabelVerzekeringsAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerzekeringsNaam
        '
        Me.LabelVerzekeringsNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelVerzekeringsNaam.Location = New System.Drawing.Point(48, 16)
        Me.LabelVerzekeringsNaam.Name = "LabelVerzekeringsNaam"
        Me.LabelVerzekeringsNaam.Size = New System.Drawing.Size(200, 20)
        Me.LabelVerzekeringsNaam.TabIndex = 1
        Me.LabelVerzekeringsNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerzFirmaId
        '
        Me.TextBoxVerzFirmaId.Location = New System.Drawing.Point(376, 16)
        Me.TextBoxVerzFirmaId.Name = "TextBoxVerzFirmaId"
        Me.TextBoxVerzFirmaId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxVerzFirmaId.TabIndex = 4
        Me.TextBoxVerzFirmaId.Visible = False
        '
        'TextBoxPolisnummer
        '
        Me.TextBoxPolisnummer.Location = New System.Drawing.Point(296, 40)
        Me.TextBoxPolisnummer.Name = "TextBoxPolisnummer"
        Me.TextBoxPolisnummer.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxPolisnummer.TabIndex = 6
        '
        'LabelPolisnummer
        '
        Me.LabelPolisnummer.AutoSize = True
        Me.LabelPolisnummer.Location = New System.Drawing.Point(256, 40)
        Me.LabelPolisnummer.Name = "LabelPolisnummer"
        Me.LabelPolisnummer.Size = New System.Drawing.Size(41, 13)
        Me.LabelPolisnummer.TabIndex = 5
        Me.LabelPolisnummer.Text = "Polisnr:"
        Me.LabelPolisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesVerzekering
        '
        Me.ButtonKiesVerzekering.Location = New System.Drawing.Point(256, 16)
        Me.ButtonKiesVerzekering.Name = "ButtonKiesVerzekering"
        Me.ButtonKiesVerzekering.Size = New System.Drawing.Size(104, 20)
        Me.ButtonKiesVerzekering.TabIndex = 3
        Me.ButtonKiesVerzekering.Text = "Kies Verzekering"
        '
        'LabelVerzekering
        '
        Me.LabelVerzekering.AutoSize = True
        Me.LabelVerzekering.Location = New System.Drawing.Point(8, 16)
        Me.LabelVerzekering.Name = "LabelVerzekering"
        Me.LabelVerzekering.Size = New System.Drawing.Size(38, 13)
        Me.LabelVerzekering.TabIndex = 0
        Me.LabelVerzekering.Text = "Naam:"
        Me.LabelVerzekering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraOptionSetBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelBenadeelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraOptionSetSchadeAan)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelSchadeAan)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 55)
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
        Me.UltraOptionSetBenadeelde.Location = New System.Drawing.Point(104, 14)
        Me.UltraOptionSetBenadeelde.Name = "UltraOptionSetBenadeelde"
        Me.UltraOptionSetBenadeelde.Size = New System.Drawing.Size(224, 16)
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
        Me.LabelBenadeelde.Location = New System.Drawing.Point(16, 14)
        Me.LabelBenadeelde.Name = "LabelBenadeelde"
        Me.LabelBenadeelde.Size = New System.Drawing.Size(67, 13)
        Me.LabelBenadeelde.TabIndex = 0
        Me.LabelBenadeelde.Text = "Benadeelde:"
        Me.LabelBenadeelde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraOptionSetSchadeAan
        '
        Me.UltraOptionSetSchadeAan.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetSchadeAan.DataMember = "BBSCADAN"
        Me.UltraOptionSetSchadeAan.DataSource = Me._dataScadObjecten
        Me.UltraOptionSetSchadeAan.DisplayMember = "SCF_OBJ_SCAD"
        Me.UltraOptionSetSchadeAan.Location = New System.Drawing.Point(448, 14)
        Me.UltraOptionSetSchadeAan.Name = "UltraOptionSetSchadeAan"
        Me.UltraOptionSetSchadeAan.Size = New System.Drawing.Size(544, 16)
        Me.UltraOptionSetSchadeAan.TabIndex = 3
        Me.UltraOptionSetSchadeAan.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetSchadeAan.ValueMember = "ID_OBJ_SCAD"
        '
        '_dataScadObjecten
        '
        Me._dataScadObjecten.DataSetName = "TDSScadObjecten"
        Me._dataScadObjecten.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataScadObjecten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelSchadeAan
        '
        Me.LabelSchadeAan.AutoSize = True
        Me.LabelSchadeAan.Location = New System.Drawing.Point(352, 14)
        Me.LabelSchadeAan.Name = "LabelSchadeAan"
        Me.LabelSchadeAan.Size = New System.Drawing.Size(68, 13)
        Me.LabelSchadeAan.TabIndex = 2
        Me.LabelSchadeAan.Text = "Schade aan:"
        Me.LabelSchadeAan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxAangever
        '
        Me.GroupBoxAangever.Controls.Add(Me.LabelSAPAfdeling)
        Me.GroupBoxAangever.Controls.Add(Me.LabelFirmaAdres)
        Me.GroupBoxAangever.Controls.Add(Me.LabelFirmaNaam)
        Me.GroupBoxAangever.Controls.Add(Me.LabelAdresAangever)
        Me.GroupBoxAangever.Controls.Add(Me.LabelNaamAangever)
        Me.GroupBoxAangever.Controls.Add(Me.UltraMaskedEditStamnrAangever)
        Me.GroupBoxAangever.Controls.Add(Me.TextBoxBtwnr)
        Me.GroupBoxAangever.Controls.Add(Me.LabelBtwnr)
        Me.GroupBoxAangever.Controls.Add(Me.TextBoxFirmaId)
        Me.GroupBoxAangever.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxAangever.Controls.Add(Me.ButtonKiesFirma)
        Me.GroupBoxAangever.Controls.Add(Me.LabelFirma)
        Me.GroupBoxAangever.Controls.Add(Me.LabelAangever)
        Me.GroupBoxAangever.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxAangever.Controls.Add(Me.ButtonKiesPersoonAangever)
        Me.GroupBoxAangever.Location = New System.Drawing.Point(0, 92)
        Me.GroupBoxAangever.Name = "GroupBoxAangever"
        Me.GroupBoxAangever.Size = New System.Drawing.Size(1008, 64)
        Me.GroupBoxAangever.TabIndex = 2
        Me.GroupBoxAangever.TabStop = False
        Me.GroupBoxAangever.Text = "Identiteit aangever"
        '
        'LabelSAPAfdeling
        '
        Me.LabelSAPAfdeling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSAPAfdeling.Location = New System.Drawing.Point(448, 16)
        Me.LabelSAPAfdeling.Name = "LabelSAPAfdeling"
        Me.LabelSAPAfdeling.Size = New System.Drawing.Size(56, 20)
        Me.LabelSAPAfdeling.TabIndex = 17
        Me.LabelSAPAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirmaAdres
        '
        Me.LabelFirmaAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaAdres.Location = New System.Drawing.Point(560, 40)
        Me.LabelFirmaAdres.Name = "LabelFirmaAdres"
        Me.LabelFirmaAdres.Size = New System.Drawing.Size(216, 20)
        Me.LabelFirmaAdres.TabIndex = 12
        Me.LabelFirmaAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirmaNaam
        '
        Me.LabelFirmaNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaNaam.Location = New System.Drawing.Point(560, 16)
        Me.LabelFirmaNaam.Name = "LabelFirmaNaam"
        Me.LabelFirmaNaam.Size = New System.Drawing.Size(216, 20)
        Me.LabelFirmaNaam.TabIndex = 11
        Me.LabelFirmaNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAdresAangever
        '
        Me.LabelAdresAangever.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAdresAangever.Location = New System.Drawing.Point(64, 40)
        Me.LabelAdresAangever.Name = "LabelAdresAangever"
        Me.LabelAdresAangever.Size = New System.Drawing.Size(344, 20)
        Me.LabelAdresAangever.TabIndex = 3
        Me.LabelAdresAangever.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamAangever
        '
        Me.LabelNaamAangever.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamAangever.Location = New System.Drawing.Point(120, 16)
        Me.LabelNaamAangever.Name = "LabelNaamAangever"
        Me.LabelNaamAangever.Size = New System.Drawing.Size(200, 20)
        Me.LabelNaamAangever.TabIndex = 2
        Me.LabelNaamAangever.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrAangever
        '
        Me.UltraMaskedEditStamnrAangever.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrAangever.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrAangever.Location = New System.Drawing.Point(64, 16)
        Me.UltraMaskedEditStamnrAangever.MaxValue = 99999999
        Me.UltraMaskedEditStamnrAangever.Name = "UltraMaskedEditStamnrAangever"
        Me.UltraMaskedEditStamnrAangever.NonAutoSizeHeight = 20
        Me.UltraMaskedEditStamnrAangever.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrAangever.TabIndex = 1
        Me.UltraMaskedEditStamnrAangever.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxBtwnr
        '
        Me.TextBoxBtwnr.Location = New System.Drawing.Point(848, 40)
        Me.TextBoxBtwnr.MaxLength = 20
        Me.TextBoxBtwnr.Name = "TextBoxBtwnr"
        Me.TextBoxBtwnr.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxBtwnr.TabIndex = 6
        '
        'LabelBtwnr
        '
        Me.LabelBtwnr.Location = New System.Drawing.Point(792, 40)
        Me.LabelBtwnr.Name = "LabelBtwnr"
        Me.LabelBtwnr.Size = New System.Drawing.Size(56, 16)
        Me.LabelBtwnr.TabIndex = 5
        Me.LabelBtwnr.Text = "B.T.W. nr:"
        Me.LabelBtwnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxFirmaId
        '
        Me.TextBoxFirmaId.Location = New System.Drawing.Point(856, 16)
        Me.TextBoxFirmaId.Name = "TextBoxFirmaId"
        Me.TextBoxFirmaId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxFirmaId.TabIndex = 9
        Me.TextBoxFirmaId.Visible = False
        '
        'UltraComboAfdelingen
        '
        Me.UltraComboAfdelingen.DataMember = "BBAFD"
        Me.UltraComboAfdelingen.DataSource = Me._dataAfdelingen
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAfdelingen.DisplayLayout.Appearance = Appearance1
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Afdeling"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn6.Header.Caption = "Afkorting"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
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
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(448, 40)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 8
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
        'ButtonKiesFirma
        '
        Me.ButtonKiesFirma.Location = New System.Drawing.Point(784, 16)
        Me.ButtonKiesFirma.Name = "ButtonKiesFirma"
        Me.ButtonKiesFirma.Size = New System.Drawing.Size(75, 20)
        Me.ButtonKiesFirma.TabIndex = 13
        Me.ButtonKiesFirma.Text = "Kies Firma"
        '
        'LabelFirma
        '
        Me.LabelFirma.AutoSize = True
        Me.LabelFirma.Location = New System.Drawing.Point(528, 16)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(35, 13)
        Me.LabelFirma.TabIndex = 10
        Me.LabelFirma.Text = "Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAangever
        '
        Me.LabelAangever.AutoSize = True
        Me.LabelAangever.Location = New System.Drawing.Point(6, 16)
        Me.LabelAangever.Name = "LabelAangever"
        Me.LabelAangever.Size = New System.Drawing.Size(56, 13)
        Me.LabelAangever.TabIndex = 0
        Me.LabelAangever.Text = "Aangever:"
        Me.LabelAangever.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.AutoSize = True
        Me.LabelAfdeling.Location = New System.Drawing.Point(416, 16)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(29, 13)
        Me.LabelAfdeling.TabIndex = 7
        Me.LabelAfdeling.Text = "Afd.:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonAangever
        '
        Me.ButtonKiesPersoonAangever.Location = New System.Drawing.Point(328, 16)
        Me.ButtonKiesPersoonAangever.Name = "ButtonKiesPersoonAangever"
        Me.ButtonKiesPersoonAangever.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoonAangever.TabIndex = 4
        Me.ButtonKiesPersoonAangever.Text = "Kies persoon"
        '
        'GroupBoxVoertuig
        '
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelChassisnummerVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNummerplaatVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelMerkVoertuig)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNaamEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelStamnrEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.TextBoxVoertuigId)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelChassisnummer)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelNummerplaat)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelMerk)
        Me.GroupBoxVoertuig.Controls.Add(Me.LabelEigenaar)
        Me.GroupBoxVoertuig.Controls.Add(Me.ButtonKiesVoertuig)
        Me.GroupBoxVoertuig.Location = New System.Drawing.Point(0, 155)
        Me.GroupBoxVoertuig.Name = "GroupBoxVoertuig"
        Me.GroupBoxVoertuig.Size = New System.Drawing.Size(592, 64)
        Me.GroupBoxVoertuig.TabIndex = 3
        Me.GroupBoxVoertuig.TabStop = False
        Me.GroupBoxVoertuig.Text = "Voertuig"
        '
        'LabelChassisnummerVoertuig
        '
        Me.LabelChassisnummerVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelChassisnummerVoertuig.Location = New System.Drawing.Point(472, 40)
        Me.LabelChassisnummerVoertuig.Name = "LabelChassisnummerVoertuig"
        Me.LabelChassisnummerVoertuig.Size = New System.Drawing.Size(112, 20)
        Me.LabelChassisnummerVoertuig.TabIndex = 9
        Me.LabelChassisnummerVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaatVoertuig
        '
        Me.LabelNummerplaatVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNummerplaatVoertuig.Location = New System.Drawing.Point(472, 16)
        Me.LabelNummerplaatVoertuig.Name = "LabelNummerplaatVoertuig"
        Me.LabelNummerplaatVoertuig.Size = New System.Drawing.Size(112, 20)
        Me.LabelNummerplaatVoertuig.TabIndex = 7
        Me.LabelNummerplaatVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerkVoertuig
        '
        Me.LabelMerkVoertuig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMerkVoertuig.Location = New System.Drawing.Point(64, 40)
        Me.LabelMerkVoertuig.Name = "LabelMerkVoertuig"
        Me.LabelMerkVoertuig.Size = New System.Drawing.Size(256, 20)
        Me.LabelMerkVoertuig.TabIndex = 3
        Me.LabelMerkVoertuig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamEigenaar
        '
        Me.LabelNaamEigenaar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamEigenaar.Location = New System.Drawing.Point(120, 16)
        Me.LabelNaamEigenaar.Name = "LabelNaamEigenaar"
        Me.LabelNaamEigenaar.Size = New System.Drawing.Size(200, 20)
        Me.LabelNaamEigenaar.TabIndex = 2
        Me.LabelNaamEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelStamnrEigenaar
        '
        Me.LabelStamnrEigenaar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStamnrEigenaar.Location = New System.Drawing.Point(64, 16)
        Me.LabelStamnrEigenaar.Name = "LabelStamnrEigenaar"
        Me.LabelStamnrEigenaar.Size = New System.Drawing.Size(56, 20)
        Me.LabelStamnrEigenaar.TabIndex = 1
        Me.LabelStamnrEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVoertuigId
        '
        Me.TextBoxVoertuigId.Location = New System.Drawing.Point(344, 40)
        Me.TextBoxVoertuigId.Name = "TextBoxVoertuigId"
        Me.TextBoxVoertuigId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxVoertuigId.TabIndex = 1
        Me.TextBoxVoertuigId.Visible = False
        '
        'LabelChassisnummer
        '
        Me.LabelChassisnummer.AutoSize = True
        Me.LabelChassisnummer.Location = New System.Drawing.Point(416, 40)
        Me.LabelChassisnummer.Name = "LabelChassisnummer"
        Me.LabelChassisnummer.Size = New System.Drawing.Size(55, 13)
        Me.LabelChassisnummer.TabIndex = 8
        Me.LabelChassisnummer.Text = "Chassisnr:"
        Me.LabelChassisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNummerplaat
        '
        Me.LabelNummerplaat.AutoSize = True
        Me.LabelNummerplaat.Location = New System.Drawing.Point(416, 16)
        Me.LabelNummerplaat.Name = "LabelNummerplaat"
        Me.LabelNummerplaat.Size = New System.Drawing.Size(44, 13)
        Me.LabelNummerplaat.TabIndex = 6
        Me.LabelNummerplaat.Text = "Nrplaat:"
        Me.LabelNummerplaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerk
        '
        Me.LabelMerk.AutoSize = True
        Me.LabelMerk.Location = New System.Drawing.Point(6, 40)
        Me.LabelMerk.Name = "LabelMerk"
        Me.LabelMerk.Size = New System.Drawing.Size(34, 13)
        Me.LabelMerk.TabIndex = 5
        Me.LabelMerk.Text = "Merk:"
        Me.LabelMerk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEigenaar
        '
        Me.LabelEigenaar.AutoSize = True
        Me.LabelEigenaar.Location = New System.Drawing.Point(6, 16)
        Me.LabelEigenaar.Name = "LabelEigenaar"
        Me.LabelEigenaar.Size = New System.Drawing.Size(52, 13)
        Me.LabelEigenaar.TabIndex = 0
        Me.LabelEigenaar.Text = "Eigenaar:"
        Me.LabelEigenaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesVoertuig
        '
        Me.ButtonKiesVoertuig.Location = New System.Drawing.Point(328, 16)
        Me.ButtonKiesVoertuig.Name = "ButtonKiesVoertuig"
        Me.ButtonKiesVoertuig.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesVoertuig.TabIndex = 4
        Me.ButtonKiesVoertuig.Text = "Kies Voertuig"
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsSchadegeval)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 411)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 168)
        Me.GroupBoxOverige.TabIndex = 7
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsSchadegeval
        '
        Me.UserControlGeneralFunctionsSchadegeval.AutoSize = True
        Me.UserControlGeneralFunctionsSchadegeval.DatumOpstelling = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsSchadegeval.GetReportContractant = False
        Me.UserControlGeneralFunctionsSchadegeval.Location = New System.Drawing.Point(6, 16)
        Me.UserControlGeneralFunctionsSchadegeval.Name = "UserControlGeneralFunctionsSchadegeval"
        Me.UserControlGeneralFunctionsSchadegeval.Opsteller = 0
        Me.UserControlGeneralFunctionsSchadegeval.Size = New System.Drawing.Size(516, 146)
        Me.UserControlGeneralFunctionsSchadegeval.TabIndex = 0
        Me.UserControlGeneralFunctionsSchadegeval.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        '_dataRegSchadegeval
        '
        Me._dataRegSchadegeval.DataSetName = "TDSRegSchadegeval"
        Me._dataRegSchadegeval.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegSchadegeval.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxSchadegeval
        '
        Me.GroupBoxSchadegeval.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxSchadegeval.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxSchadegeval.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxSchadegeval.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxSchadegeval.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxSchadegeval.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxSchadegeval.Location = New System.Drawing.Point(0, 578)
        Me.GroupBoxSchadegeval.Name = "GroupBoxSchadegeval"
        Me.GroupBoxSchadegeval.Size = New System.Drawing.Size(528, 51)
        Me.GroupBoxSchadegeval.TabIndex = 9
        Me.GroupBoxSchadegeval.TabStop = False
        Me.GroupBoxSchadegeval.Text = "Schadegeval"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(310, 28)
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
        Me._statusBar.Location = New System.Drawing.Point(0, 630)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1002
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
        Me.GroupBoxVerzending.Controls.Add(Me.Label3)
        Me.GroupBoxVerzending.Controls.Add(Me.Label2)
        Me.GroupBoxVerzending.Controls.Add(Me.Label4)
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 411)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 218)
        Me.GroupBoxVerzending.TabIndex = 1003
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonInfoChip
        '
        Me.ButtonInfoChip.Image = CType(resources.GetObject("ButtonInfoChip.Image"), System.Drawing.Image)
        Me.ButtonInfoChip.Location = New System.Drawing.Point(257, 102)
        Me.ButtonInfoChip.Name = "ButtonInfoChip"
        Me.ButtonInfoChip.Size = New System.Drawing.Size(32, 21)
        Me.ButtonInfoChip.TabIndex = 1005
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
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboFirma.DisplayLayout.Appearance = Appearance19
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Width = 150
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
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
        Me.UltraComboFirma.Location = New System.Drawing.Point(258, 190)
        Me.UltraComboFirma.Name = "UltraComboFirma"
        Me.UltraComboFirma.Size = New System.Drawing.Size(214, 22)
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
        Me.cbxVerslagnrCHIP.Location = New System.Drawing.Point(256, 148)
        Me.cbxVerslagnrCHIP.Name = "cbxVerslagnrCHIP"
        Me.cbxVerslagnrCHIP.Size = New System.Drawing.Size(51, 17)
        Me.cbxVerslagnrCHIP.TabIndex = 23
        Me.cbxVerslagnrCHIP.Text = "CHIP"
        Me.cbxVerslagnrCHIP.UseVisualStyleBackColor = True
        '
        'LabelOpmerkingNaarCHIP
        '
        Me.LabelOpmerkingNaarCHIP.AutoSize = True
        Me.LabelOpmerkingNaarCHIP.Location = New System.Drawing.Point(6, 168)
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
        Me.LabelNaarChip.Location = New System.Drawing.Point(8, 145)
        Me.LabelNaarChip.Name = "LabelNaarChip"
        Me.LabelNaarChip.Size = New System.Drawing.Size(192, 16)
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
        Me.Label3.Location = New System.Drawing.Point(8, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Opm mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Opm mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Opm mail:"
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
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(297, 102)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(175, 21)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen en CHIP"
        Me.ToolTip1.SetToolTip(Me.ButtonVerzendingBest, "Naar bestemmelingen en automatisch nr CHIP (indien firma SAP gekend)")
        '
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(297, 56)
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
        Me.LabelVerzendingBest.Location = New System.Drawing.Point(8, 101)
        Me.LabelVerzendingBest.Name = "LabelVerzendingBest"
        Me.LabelVerzendingBest.Size = New System.Drawing.Size(168, 16)
        Me.LabelVerzendingBest.TabIndex = 8
        Me.LabelVerzendingBest.Text = "Datum verz. bestem.:"
        '
        'LabelGoedkeuring
        '
        Me.LabelGoedkeuring.AutoSize = True
        Me.LabelGoedkeuring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoedkeuring.Location = New System.Drawing.Point(8, 56)
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
        Me.LabelVerzending.Size = New System.Drawing.Size(168, 16)
        Me.LabelVerzending.TabIndex = 0
        Me.LabelVerzending.Text = "Datum verz. postoverste:"
        '
        'FormBewakingSchadegeval
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 652)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxSchadegeval)
        Me.Controls.Add(Me.GroupBoxVoertuig)
        Me.Controls.Add(Me.GroupBoxAangever)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxVerzekering)
        Me.Controls.Add(Me.GroupBoxInlichtingen)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Name = "FormBewakingSchadegeval"
        Me.Text = "Schadegeval"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInlichtingen.ResumeLayout(False)
        Me.GroupBoxInlichtingen.PerformLayout()
        Me.GroupBoxVerzekering.ResumeLayout(False)
        Me.GroupBoxVerzekering.PerformLayout()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBewakingDup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetSchadeAan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataScadObjecten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAangever.ResumeLayout(False)
        Me.GroupBoxAangever.PerformLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVoertuig.ResumeLayout(False)
        Me.GroupBoxVoertuig.PerformLayout()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        CType(Me._dataRegSchadegeval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSchadegeval.ResumeLayout(False)
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub FormBewakingSchadegeval_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

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

            'voor usercontrolSchadegeval
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsSchadegeval.DatumOpstelling = Now
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

            Me.UserControlGeneralFunctionsSchadegeval.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

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
        'Doel: gegevens schadegeval invullen
        'Auteur: Koen Heye - april 2006

        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            _dataRegSchadegeval.Clear()
            Me._dataRegSchadegeval.Merge(Me._controller.GetRegSchadegeval(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegSchadegeval.BBBEWREGRow
            dr = Me._dataRegSchadegeval.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsSchadegeval.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsSchadegeval.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsSchadegeval.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsSchadegeval.SetVeraData(dr.VeraReference, dr.VeraLink)
            End If

            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsSchadegeval.GetReportContractant = dr.VerslagContractantYN
            End If

            'Schadegegevens opvullen
            Dim drScad As TDSRegSchadegeval.BBSCADRow
            drScad = CType(Me._dataRegSchadegeval.BBSCAD.Rows.Item(0), TDSRegSchadegeval.BBSCADRow)

            If Not drScad.IsNR_POLISNull Then
                TextBoxPolisnummer.Text = drScad.NR_POLIS
            End If
            If Not drScad.IsTY_SCADNull Then
                TextBoxAard.Text = drScad.TY_SCAD
            End If
            If Not drScad.IsRD_SCADNull Then
                TextBoxOorzaak.Text = drScad.RD_SCAD
            End If
            If Not drScad.IsOPM_SCADNull Then
                TextBoxOpmerkingen.Text = drScad.OPM_SCAD
            End If
            If Not drScad.IsID_OBJ_SCADNull Then
                UltraOptionSetSchadeAan.Value = drScad.ID_OBJ_SCAD
            End If
            If Not drScad.IsID_BEW_DUPNull Then
                UltraOptionSetBenadeelde.Value = drScad.ID_BEW_DUP
            End If
            If Not drScad.IsNR_BTWNull Then
                TextBoxBtwnr.Text = drScad.NR_BTW()
            End If

            'Gegevens aangever
            UltraMaskedEditStamnrAangever.Text = CStr(drScad.ID_MLD)
            If Not drScad.IsNM_INDNull And Not drScad.IsVNM_INDNull Then
                LabelNaamAangever.Text = drScad.NM_IND.Trim & " " & drScad.VNM_IND.Trim
            ElseIf Not drScad.IsNM_INDNull Then
                LabelNaamAangever.Text = drScad.NM_IND
            ElseIf Not drScad.IsVNM_INDNull Then
                LabelNaamAangever.Text = drScad.VNM_IND
            Else
                LabelNaamAangever.Text = ""
            End If
            If Not drScad.IsAD_INDNull Then
                LabelAdresAangever.Text = drScad.AD_IND.Trim
            End If
            If Not drScad.IsPO_COD_WNPL_INDNull Then
                LabelAdresAangever.Text &= " " & drScad.PO_COD_WNPL_IND.Trim
            End If
            If Not drScad.IsWNPL_INDNull Then
                LabelAdresAangever.Text &= " " & drScad.WNPL_IND
            End If
            If Not drScad.IsSAP_AFDNull Then 'toegevoegd sidnaco - 18/09/2006
                LabelSAPAfdeling.Text = drScad.SAP_AFD
            End If

            'Firma opvullen
            If Not Me._dataRegSchadegeval.BBFRM.Rows.Count() = 0 Then

                Dim drFirma As TDSRegSchadegeval.BBFRMRow
                drFirma = CType(Me._dataRegSchadegeval.BBFRM.Rows.Item(0), TDSRegSchadegeval.BBFRMRow)

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
            End If

            'Voertuig opvullen
            If Not Me._dataRegSchadegeval.BBTSP.Rows.Count() = 0 Then

                Dim drVoer As TDSRegSchadegeval.BBTSPRow
                drVoer = CType(Me._dataRegSchadegeval.BBTSP.Rows.Item(0), TDSRegSchadegeval.BBTSPRow)

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
                If Not drVoer.IsPL_NR_TSPNull Then
                    LabelNummerplaatVoertuig.Text = drVoer.PL_NR_TSP
                End If
                If Not drVoer.IsNR_CHAS_TSPNull Then
                    LabelChassisnummerVoertuig.Text = drVoer.NR_CHAS_TSP
                End If
            End If

            'Verzekering opvullen
            If Not Me._dataRegSchadegeval.BBVZKFRM.Rows.Count() = 0 Then

                Dim drVerz As TDSRegSchadegeval.BBVZKFRMRow
                drVerz = CType(Me._dataRegSchadegeval.BBVZKFRM.Rows.Item(0), TDSRegSchadegeval.BBVZKFRMRow)

                TextBoxVerzFirmaId.Text = CStr(drVerz.ID_FRM_VZK)
                If Not drVerz.IsNM_FRM_VZKNull Then
                    LabelVerzekeringsNaam.Text = drVerz.NM_FRM_VZK
                End If
                If Not drVerz.IsAD_FRM_VZKNull Then
                    LabelVerzekeringsAdres.Text = drVerz.AD_FRM_VZK
                ElseIf Not drVerz.IsPLA_FRM_VZKNull Then
                    LabelVerzekeringsAdres.Text &= drVerz.PLA_FRM_VZK
                End If
                If Not drVerz.IsPLA_FRM_VZKNull Then
                    LabelVerzekeringsAdres.Text = drVerz.PLA_FRM_VZK
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
            If Not dr.IsDT_OKNull Then
                UltraDateTimeEditorGoedkeuring.Value = dr.DT_OK
            Else
                UltraDateTimeEditorGoedkeuring.Value = Nothing
            End If
            If Not dr.IsDT_VZ_RAP_NWNull And dr.IsDT_OKNull And dr.IsDT_VZ_BSTNull Then
                ButtonTerugZenden.Enabled = True
            Else
                ButtonTerugZenden.Enabled = False
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

            Me.UserControlGeneralFunctionsSchadegeval.setBijlageData(Me._dataRegSchadegeval.BBBYLG)
            Me.UserControlGeneralFunctionsSchadegeval.setBestemmelingenData(Me._dataRegSchadegeval.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindDdlAfdelingen()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindUltraOptionSets()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataScadObjecten.Merge(Me._controller.GetScadObjecten)

            Me._dataBewakingDup.Merge(Me._controller.GetBewakingDup())
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
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
            Me.UserControlGeneralFunctionsSchadegeval.setPersoneelData(_dataBEWPersoneel)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBijlagen()
        Try
            Me.UserControlGeneralFunctionsSchadegeval.setBijlageData(_dataRegSchadegeval.BBBYLG)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)

        End Try
    End Sub

    Private Sub bindBestemmelingen()
        Try
            Me.UserControlGeneralFunctionsSchadegeval.setBestemmelingenData(_dataRegSchadegeval.BBBST)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Button and Optionset Eventhandlers"

    Private Sub ButtonKiesVerzekering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesVerzekering.Click
        Try
            Dim f_verzFirma As FormBewakingVerzekeringsfirma = New FormBewakingVerzekeringsfirma

            f_verzFirma.ShowDialog()

            If Not f_verzFirma.Canceled Then
                Dim firmaVerz As TDSVerzFirmas.BBVZKFRMRow = f_verzFirma.Firma

                TextBoxVerzFirmaId.Text = CStr(firmaVerz.ID_FRM_VZK)
                If Not firmaVerz.IsNM_FRM_VZKNull Then
                    LabelVerzekeringsNaam.Text = firmaVerz.NM_FRM_VZK
                End If
                If Not firmaVerz.IsAD_FRM_VZKNull Then
                    LabelVerzekeringsAdres.Text = firmaVerz.AD_FRM_VZK
                End If
                If Not firmaVerz.IsPLA_FRM_VZKNull Then
                    LabelVerzekeringsAdres.Text &= " , " & firmaVerz.PLA_FRM_VZK
                End If
            End If

            f_verzFirma.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesFirma.Click
        Try
            Using f_firma As FormBewakingFirmas = New FormBewakingFirmas

                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    TextBoxFirmaId.Text = CStr(f_firma.IdFirma)
                    LabelFirmaNaam.Text = f_firma.NaamFirma
                    LabelFirmaAdres.Text = f_firma.AdresFirma & ", " & f_firma.PostNrFirma & " " & f_firma.GemeenteFirma

                    ToolTip1.SetToolTip(LabelFirmaNaam, "")

                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonAangever_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonAangever.Click

        Dim f_ind As FormIndividuen = New FormIndividuen

        Try
            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrAangever.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamAangever.Text = individu.NM_IND.Trim & " " & individu.VNM_IND.Trim
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamAangever.Text = individu.NM_IND.Trim
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamAangever.Text = individu.VNM_IND.Trim
                Else
                    LabelNaamAangever.Text = ""
                End If
                If Not individu.IsAD_INDNull Then
                    LabelAdresAangever.Text = individu.AD_IND.Trim
                End If
                If Not individu.IsPO_COD_WNPL_INDNull Then
                    LabelAdresAangever.Text &= " " & individu.PO_COD_WNPL_IND.Trim
                End If
                If Not individu.IsWNPL_INDNull Then
                    LabelAdresAangever.Text &= " " & individu.WNPL_IND.Trim
                End If
                If Not individu.IsSAP_AFDNull Then 'toegevoegd sidnaco - 18/09/2006
                    LabelSAPAfdeling.Text = individu.SAP_AFD
                End If

                If Not individu.IsNR_IND_WKGNull And Not individu.IsNM_JUR_VENONull Then
                    GetFirmAutomatically(individu.NR_IND_WKG)
                Else
                    LabelFirmaNaam.Text = ""
                    TextBoxFirmaId.Text = ""
                    ToolTip1.SetToolTip(LabelFirmaNaam, "")
                End If

            End If

            f_ind.Close()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingSchadegeval - ButtonKiesPersoonAangever_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding - GetFirmAutomatically", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation)
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

    Private Function GetAfdeling() As String
        Return LabelSAPAfdeling.Text
    End Function

    Private Sub initializeDataSetConfig()
        Try
            _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
            UserControlGeneralFunctionsSchadegeval.setDataSetConfiguration(_dataConfiguratie)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub initializeDataSetIndividuen()
        Try
            _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
            UserControlGeneralFunctionsSchadegeval.setDataSetIndividuen("bewaking", _dataIndividuen)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        Try
            Me._statusBar.SetStatusbarInfo(statusText)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setLabelsVerplicht()
        Try
            LabelDatum.Text &= " *"
            LabelUur.Text &= " *"
            LabelPlaats.Text &= " *"
            LabelAangever.Text &= " *"
            LabelBenadeelde.Text &= " *"
            LabelSchadeAan.Text &= " *"
            LabelAard.Text &= " *"
            LabelOorzaak.Text &= " *"
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "User Control"

    Private Sub UserControlGeneralFunctionsSchadegeval_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsSchadegeval.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, GetAfdeling())

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsSchadegeval.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsSchadegeval.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
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
    Private Sub UltraMaskedEditStamnrAangever_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrAangever.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrAangever, Me.LabelNaamAangever, Me.LabelAdresAangever)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrAangever_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrAangever.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrAangever, Me.LabelNaamAangever, Me.LabelAdresAangever)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub handleAfterStamnrLeave(ByRef UltraMaskedEditStamnr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit, ByRef LabelNaam As Label, ByRef LabelAdres As Label)
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

                    If Me.UltraMaskedEditStamnrAangever.Name = UltraMaskedEditStamnr.Name Then
                        LabelSAPAfdeling.Text = individu.SAP_AFD
                    End If

                    If Not individu.IsNR_IND_WKGNull And Not individu.IsNM_JUR_VENONull Then
                        GetFirmAutomatically(individu.NR_IND_WKG)
                    Else
                        LabelFirmaNaam.Text = ""
                        TextBoxFirmaId.Text = ""
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
    Private Sub FormBewakingSchadegeval_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Opslaan"
    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        Try
            Me.OpslaanRegistratie()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub OpslaanRegistratie()
        'Doel:   nieuwe schadegeval toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 27/04/2006
        Try
            If controleVeldenOK() Then
                Cursor.Current = Cursors.WaitCursor
                Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

                Dim dsSchadegeval As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval
                Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBEWREGRow
                Dim drSchadegeval As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBSCADRow
                Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBYLGRow
                Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBSTRow

                Dim dsBest As New DataSet
                Dim dsByl As New DataSet

                Dim id_reg As Integer
                Dim volgnr_reg_jaar As Integer

                Dim arrayOfDeletedChronicleID As New ArrayList

                Try

                    dsSchadegeval.BBBST.DataSet.Clear()
                    dsSchadegeval.BBBYLG.DataSet.Clear()

                    dsBest.Merge(UserControlGeneralFunctionsSchadegeval.getDataBestemmelingen)
                    dsByl.Merge(UserControlGeneralFunctionsSchadegeval.getDataBijlagen)

                    'Ann vragen
                    '1. Transaction
                    '2. user hier ophalen die is ingelogd
                    If (UserControlGeneralFunctionsSchadegeval.CheckBestemmelingen(dsBest) = True) Then

                        _controller = New ControllerGetData

                        If Me._idRegistratie = -1 Then 'nieuw schadegeval

                            drRegistratie = dsSchadegeval.BBBEWREG.NewBBBEWREGRow
                            '-------------------------
                            _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                            '1. Registratie-record
                            '---------------------
                            With drRegistratie
                                .ID_REG = id_reg
                                .ID_OPS = Me.UserControlGeneralFunctionsSchadegeval.Opsteller
                                .ID_TY_REG = 5
                                .TMS_OPS_REG = Me.UserControlGeneralFunctionsSchadegeval.getOpstelDatum
                                .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                                .PLA_INC = Me.TextBoxPlaats.Text
                                .VLG_REG_JR_BPL = volgnr_reg_jaar
                                LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                                .SCF_REG = Me.TextBoxKorteOms.Text
                                .VeraLink = UserControlGeneralFunctionsSchadegeval.GetVeraLink
                                .VeraReference = UserControlGeneralFunctionsSchadegeval.GetVeraReference
                                .VerslagContractantYN = UserControlGeneralFunctionsSchadegeval.GetReportContractant
                            End With
                            dsSchadegeval.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                            '2. Schadegeval
                            '--------------
                            drSchadegeval = dsSchadegeval.BBSCAD.NewBBSCADRow
                            With drSchadegeval
                                .ID_REG = id_reg
                                .ID_MLD = CInt(Me.UltraMaskedEditStamnrAangever.Text)
                                If Not TextBoxFirmaId.Text = "" Then
                                    .ID_FRM = CInt(TextBoxFirmaId.Text)
                                End If
                                If Not TextBoxVoertuigId.Text = "" Then
                                    .ID_TSP = CInt(TextBoxVoertuigId.Text)
                                End If
                                If Not UltraOptionSetSchadeAan.Value Is Nothing Then
                                    .ID_OBJ_SCAD = CInt(UltraOptionSetSchadeAan.Value)
                                End If
                                If Not TextBoxVerzFirmaId.Text = "" Then
                                    .ID_FRM_VZK = CInt(TextBoxVerzFirmaId.Text)
                                End If
                                If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                                    .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                                End If
                                If Not TextBoxBtwnr.Text = "" Then
                                    .NR_BTW = TextBoxBtwnr.Text
                                End If
                                If Not TextBoxPolisnummer.Text = "" Then
                                    .NR_POLIS = TextBoxPolisnummer.Text
                                End If
                                .TY_SCAD = TextBoxAard.Text
                                .RD_SCAD = TextBoxOorzaak.Text
                                .OPM_SCAD = TextBoxOpmerkingen.Text

                            End With
                            dsSchadegeval.BBSCAD.AddBBSCADRow(drSchadegeval)

                            '3. Bijlagen => grid overlopen en New rows toevoegen
                            '------------------------------------------------------------

                            Dim drByl As DataRow
                            Dim chronicleID As String

                            For Each drByl In dsByl.Tables(0).Rows
                                drBylagen = dsSchadegeval.BBBYLG.NewBBBYLGRow
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
                                    chronicleID = UploadSchadegevalBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                                    'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                                    If (chronicleID <> "") Then
                                        drBylagen.ID_DOC = chronicleID
                                    End If
                                End If

                                dsSchadegeval.BBBYLG.AddBBBYLGRow(drBylagen)
                            Next

                            '4. Bestemmelingen => grid overlopen en New rows toevoegen
                            '------------------------------------------------------------
                            'Dim drGridBST As TDSRegSchadegeval.BBBSTRow
                            Dim drBest As DataRow
                            For Each drBest In dsBest.Tables(0).Rows
                                drBestemmelingen = dsSchadegeval.BBBST.NewBBBSTRow
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

                                dsSchadegeval.BBBST.AddBBBSTRow(drBestemmelingen)
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

                        Else 'bestaand schadegeval wijzigen
                            dsSchadegeval.Merge(Me._controller.GetRegSchadegeval(Me._idRegistratie))
                            drRegistratie = dsSchadegeval.BBBEWREG.FindByID_REG(Me._idRegistratie)

                            '1. Registratie-record
                            '---------------------
                            With drRegistratie
                                .ID_REG = Me._idRegistratie
                                .ID_OPS = Me.UserControlGeneralFunctionsSchadegeval.Opsteller
                                .ID_TY_REG = 5
                                .TMS_OPS_REG = Me.UserControlGeneralFunctionsSchadegeval.getOpstelDatum
                                .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                                .PLA_INC = Me.TextBoxPlaats.Text
                                .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                                .SCF_REG = Me.TextBoxKorteOms.Text
                                .VeraLink = UserControlGeneralFunctionsSchadegeval.GetVeraLink
                                .VeraReference = UserControlGeneralFunctionsSchadegeval.GetVeraReference
                                .VerslagContractantYN = UserControlGeneralFunctionsSchadegeval.GetReportContractant
                            End With

                            '2. Schadegeval
                            '--------------
                            drSchadegeval = CType(dsSchadegeval.BBSCAD.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBSCADRow)
                            With drSchadegeval
                                .ID_REG = Me._idRegistratie
                                .ID_MLD = CInt(Me.UltraMaskedEditStamnrAangever.Text)
                                If Not TextBoxFirmaId.Text = "" Then
                                    .ID_FRM = CInt(TextBoxFirmaId.Text)
                                End If
                                If Not TextBoxVoertuigId.Text = "" Then
                                    .ID_TSP = CInt(TextBoxVoertuigId.Text)
                                End If
                                If Not UltraOptionSetSchadeAan.Value Is Nothing Then
                                    .ID_OBJ_SCAD = CInt(UltraOptionSetSchadeAan.Value)
                                End If
                                If Not TextBoxVerzFirmaId.Text = "" Then
                                    .ID_FRM_VZK = CInt(TextBoxVerzFirmaId.Text)
                                End If
                                If Not UltraOptionSetBenadeelde.Value Is Nothing Then
                                    .ID_BEW_DUP = CInt(UltraOptionSetBenadeelde.Value)
                                End If
                                If Not TextBoxBtwnr.Text = "" Then
                                    .NR_BTW = TextBoxBtwnr.Text
                                End If
                                If Not TextBoxPolisnummer.Text = "" Then
                                    .NR_POLIS = TextBoxPolisnummer.Text
                                End If
                                .TY_SCAD = TextBoxAard.Text
                                .RD_SCAD = TextBoxOorzaak.Text
                                .OPM_SCAD = TextBoxOpmerkingen.Text
                            End With

                            '3. Bijlagen => grid overlopen en New rows()
                            '----------------------------------------------------
                            'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                            Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBYLGRow

                            For Each drBylg In dsSchadegeval.BBBYLG.Rows
                                If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                                    'rij is teruggevonden
                                    'ElseIf drTijden.RowState = DataRowState.Deleted Then
                                    '    'do nothing
                                Else
                                    If dsSchadegeval.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                                If (drGridBYLG.RowState <> DataRowState.Deleted) Then
                                    If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                        chronicleID = UploadSchadegevalBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                                    Else
                                        chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                                    End If
                                End If

                                If drGridBYLG.RowState = DataRowState.Added Then
                                    drBylagen = dsSchadegeval.BBBYLG.NewBBBYLGRow

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

                                    dsSchadegeval.BBBYLG.AddBBBYLGRow(drBylagen)

                                ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                                    Dim arrBylg() As DataRow
                                    arrBylg = dsSchadegeval.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                    If arrBylg.Length > 0 Then
                                        drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBYLGRow)

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
                                        arrBylg = dsSchadegeval.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                        If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                            drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBYLGRow)
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
                            Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval.BBBSTRow

                            For Each drBest In dsSchadegeval.BBBST.Rows
                                If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                    'rij is teruggevonden
                                    'ElseIf drTijden.RowState = DataRowState.Deleted Then
                                    '    'do nothing
                                Else
                                    If dsSchadegeval.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                        'eerst kijken of het record al effectief bestond in de database
                                        'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                        drBest.Delete() 'rij was verwijderd uit grid
                                    End If
                                End If
                            Next

                            Dim drGridBST As DataRow
                            For Each drGridBST In dsBest.Tables(0).Rows
                                If drGridBST.RowState = DataRowState.Added Then
                                    drBestemmelingen = dsSchadegeval.BBBST.NewBBBSTRow
                                    drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                                    drBestemmelingen.ID_REG = Me._idRegistratie
                                    drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                                    drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                                    If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                        drBestemmelingen.AD_EMAL_IND = ""
                                    Else
                                        drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                                    End If
                                    dsSchadegeval.BBBST.AddBBBSTRow(drBestemmelingen)
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
                        Dim ds As New Proxy.BBWService.Mgt.TDSSchadegeval
                        ds.Merge(dsSchadegeval.GetChanges)

                        proxy.RegisterRegistratieSchadegeval(ds, System.Environment.UserName)
                        dsSchadegeval.AcceptChanges()

                        'als het om een nieuw schadegeval gaat, worden volgende velden ingevuld
                        If Me._idRegistratie = -1 Then
                            TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsSchadegeval.getOpstelDatum)
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

                    Me.setStatus("Het Schadegeval werd succesvol opgeslagen")
                Catch ex As Exception
                    MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                    "Form: FormBewakingSchadegeval - OpslaanRegistratie" & vbCrLf & _
                                    "Message: " & ex.Message & vbCrLf & _
                                    "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                'boodschap weergeven
            Else
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
    Private Function UploadSchadegevalBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
        'Doel:   Uploaden van de bijlage van een aanrijdingsverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(UltraDateTimeEditorDatum.DateTime) & "/" & volgnr & " - " & LabelTitel.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BEWAKING", "FolderPathDocumentum").WD()

        Return BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName, documentumFolderPath)

    End Function
    Private Function controleVeldenOK() As Boolean
        'Doel:
        'Auteur: Koen Heye - mei 2006
        Try
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
            If UltraMaskedEditStamnrAangever.Text = "" Then
                errorBool = False
            End If
            If UltraOptionSetBenadeelde.Value Is Nothing Then
                errorBool = False
            End If
            If UltraOptionSetSchadeAan.Value Is Nothing Then
                errorBool = False
            End If
            If TextBoxAard.Text = "" Then
                errorBool = False
            End If
            If TextBoxOorzaak.Text = "" Then
                errorBool = False
            End If
            If Not UserControlGeneralFunctionsSchadegeval.checkPersoneelOK Then
                errorBool = False
            End If
            Return errorBool
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Function

#End Region

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        'Doel: Rapport 'Schadegeval' afdrukken
        'Auteur: Nancy Coppens - 15/09/2006 (was blijkbaar vergeten door onze student Stein?)
        Try
            Me.showReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
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
                            Me.OpslaanRegistratie()
                            Me.setStatus("Het registratieverslag schadegeval werd succesvol opgeslagen")

                            'rapport tonen
                            f_rap.InterventieID = Me._idRegistratie
                            f_rap.Show()
                            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                              "RegistratieSchadegeval", _
                                              "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "RegistratieDiefstal")
                            'report.AddParameter("ID_REG", Me._IDRegistratie)
                            'f_rap.ExportPDF()


                        Else
                            MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                        "Form: FormBewakingSchadegeval - ShowReport" & vbCrLf & _
                                        "Message: " & ex.Message & vbCrLf & _
                                        "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                    Cursor.Current = Cursors.Default
                End If
            Else
                If controleVeldenOK() Then
                    'altijd eerst opslaan
                    Me.OpslaanRegistratie()
                    Me.setStatus("Het registratieverslag schadegeval werd succesvol opgeslagen")

                    'rapport tonen
                    f_rap.InterventieID = Me._idRegistratie
                    f_rap.Show()
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieSchadegeval", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                    'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking")
                    'report.AddParameter("ID_REG", Me._IDRegistratie)
                    'f_rap.ExportPDF()
                Else
                    MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

#Region "Buttons verzending"
    Private Sub ButtonVerzendingBBW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerzendingBBW.Click
        'Doel:   verstuur verslag naar postoverste
        'Auteur: Koen Heye - mei 2006 - naco - 21/09/2006

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
                Me.OpslaanRegistratie()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf & _
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                            "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                            "Opsteller:         " & UserControlGeneralFunctionsSchadegeval.getOpsteller & vbCrLf & vbCrLf & _
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
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonGoedkeuring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - naco - 21/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorGoedkeuring.Value = Now
            Me.OpslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Verzending").WD & vbCrLf
            textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsSchadegeval.getOpsteller & vbCrLf & vbCrLf & _
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
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
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
            Me.OpslaanRegistratie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Terugzenden").WD & vbCrLf & vbCrLf
            textMail &= "Onderstaand verslag kan niet worden goedgekeurd. Gelieve het verslag te wijzigen." & vbCrLf & vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsSchadegeval.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingSchadegeval - ButtonTerugZenden_Click()" & vbCrLf & _
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
        Dim textMailCHIP As String

        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim specBest As New ArrayList
        Dim textMailURL As String = ""
        Dim specPathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim dsSpecBest As New TDSBBBSTBY
        Dim drSpecBest As TDSBBBSTBY.BBBSTBYRow
        Dim IsSpecialBest As Boolean = False
        Dim IsNormalBest As Boolean = False


        Try
            'naco - 01/03/2007
            'controleren of de bijlagen bestaan => anders kan de mail niet verstuurd worden
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsSchadegeval.getDataBijlagen.Tables(0).Rows
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

            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsSchadegeval.getDataBestemmelingen.Tables(0).Rows
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


            If best.Count <> 0 Or specBest.Count <> 0 Then
                Me.OpslaanRegistratie()

                'Eerst rapport exporteren naar PDF-file
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD & _
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
                                "Opsteller:         " & UserControlGeneralFunctionsSchadegeval.getOpsteller 'naco - sept 2016

                textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsSchadegeval.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String

                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsSchadegeval.getDataBijlagen.Tables(0).Rows
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
                f_rap.ExportPdfBewakingRegistratie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                                   "RegistratieSchadegeval", _
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

                UltraDateTimeEditorBestemmelingen.Value = Now 'Pas datum opslaan als het effectief succesvol was
                Me.OpslaanRegistratie()


                '2. naar CHIP automatisch - sept 2016 - naco
                '-------------------------------------------
                If LabelFirmaNaam.Text.Trim = "" Then
                    MessageBox.Show("Firmanaam is niet ingevuld: verslag wordt niet automatisch naar CHIP gestuurd.", "Firmanaam - CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(CInt(_dataRegSchadegeval.BBSCAD.Rows(0).Item("ID_FRM").ToString))
                    'MessageBox.Show("ID FRM: " & _dataRegSchadegeval.BBSCAD.Rows(0).Item("ID_FRM").ToString)
                    If intIDFirmSAP > 0 And intIDFirmSAP <> 616206 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP) - 1001674 = oude ID_FRM BBW
                        cbxVerslagnrCHIP.Checked = True
                        UltraComboFirma.Value = intIDFirmSAP
                        UltraDateTimeEditorNaarCHIP.DateTime = Now

                        Dim strMailToFirm As String
                        'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                        strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP) 'vanaf 13/03/2017 - naco/borb

                        If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                            If TextBoxNaarCHIP.Text = "" Then
                                TextBoxNaarCHIP.Text = Strings.Left("Geen contactpers SAP firma " & intIDFirmSAP & " (" & Now & ")", 100) 'varchar(100)
                            Else
                                TextBoxNaarCHIP.Text = Strings.Left(TextBoxNaarCHIP.Text.Trim & " - Geen contactpers SAP firma " & intIDFirmSAP & "( " & Now & ")", 100)
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
                                                               "AM Gent - Verslag bewaking (schadegeval) - " & LabelFirmaNaam.Text & " (" & intIDFirmSAP.ToString & ") - " & UltraDateTimeEditorDatum.Text,
                                                               pathPDFfile)
                        End If

                        'update tabel BBBEWREG
                        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                        proxy.CHIPUpdate(Me._idRegistratie, Me.UltraComboFirma.Value.ToString(), _
                                                                DateTime.Now.Date, Me.TextBoxNaarCHIP.Text)
                    Else
                        If intIDFirmSAP <> 616206 Then '1001674 = ArcelorMittal Gent => geen msgbox tonen - 1001674 = oude ID_FRM BBW
                            MessageBox.Show("Verslag kan niet automatisch naar firma gestuurd worden en niet naar CHIP portaal." & vbCrLf &
                                            "SAP firmanr niet gekend voor deze firma: " & LabelFirmaNaam.Text & ".", "Verslag automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
                '-------------------------------------------

                Me.setStatus("Registratieverslag succesvol verzonden naar de bestemmelingen")

            Else
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")

            MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
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
#End Region

#Region "Mailing"
    Private Sub sendMail(ByVal mailTo As ArrayList, ByVal aText As String, _
                         ByVal subject As String, ByVal pathAttach As ArrayList)
        Try
            MailBBW.sendMail(mailTo, aText, subject, pathAttach)
            Me.setStatus("Registratie succesvol verzonden naar de bestemmelingen")
        Catch ex As Exception
            Me.setStatus("OPGELET: registratie niet verzonden naar de bestemmelingen")
            'MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            ElseIf FormManager.Current.BbwVerantwoordelijke Then
                'mag alles zien
                cbxVerslagnrCHIP.Enabled = True
                UltraComboFirma.Enabled = True
                ButtonNaarCHIP.Enabled = True
                TextBoxNaarCHIP.ReadOnly = False
                ButtonMailIKP.Visible = True
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
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

                GroupBoxHoofding.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False
                GroupBoxAangever.Enabled = False
                GroupBoxVoertuig.Enabled = False
                GroupBoxVerzekering.Enabled = False
                GroupBoxInlichtingen.Enabled = False
                GroupBoxOverige.Enabled = False

                UltraButtonAnnuleer.Visible = False
                UltraButtonOpslaan.Enabled = False

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

    Private Sub UltraMaskedEditStamnrAangever_MaskChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles UltraMaskedEditStamnrAangever.MaskChanged

    End Sub

    Private Sub UltraMaskedEditStamnrAangever_InvalidOperation(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinMaskedEdit.InvalidOperationEventArgs) Handles UltraMaskedEditStamnrAangever.InvalidOperation

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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsSchadegeval.getDataBijlagen.Tables(0).Rows

            '    'juli 2007 - dumi -Als er een chronicleID bestaat voor de bijlage, betekent dit dat het al werd opgeladen in documentum.
            '    'Dan kan de url worden samengesteld die de link vormt naar documentum.
            '    'vb url: http://svsim045.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0901bad18001a60f&latestflag=y
            '    If (Not IsDBNull(bijlageRow.Item("ID_DOC"))) Then
            '        urlString = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_PRE", "Path").WD & bijlageRow.ID_DOC & _
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

            'David Martens (IKP) kan niet op de T-drive van de bewaking
            'For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In _
            '    UserControlGeneralFunctionsSchadegeval.getDataBijlagen.Tables(0).Rows

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
            f_rap.ExportPdfBewakingRegistratie(
                _dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                "RegistratieSchadegeval",
                pathPDFfile,
                Me._idRegistratie)
            f_rap.Dispose()

            olmail.Attachments.Add(pathPDFfile)

            '-> de bijlagen (resizen)
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
                             "Form: FormBewakingSchadegeval - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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
        Dim intIDFRM_BBW As Integer = CInt(_dataRegSchadegeval.BBSCAD.Rows(0).Item("ID_FRM").ToString)

        If strFirmaNaamBBW = "" Then
            MessageBox.Show("Firmanaam is niet ingevuld: verslag kan niet automatisch naar CHIP gestuurd worden.", "Firmanaam - CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(intIDFRM_BBW)

            If intIDFirmSAP > 0 And intIDFRM_BBW <> 1001674 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP)

                Dim strMailToFirm As String
                'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP)

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
