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

Public Class FormBewakingAlcoholtest
    Inherits System.Windows.Forms.Form

#Region "Variabelen"
    Private _IDRegistratie As Integer = -1
    'Private _registratieType As Integer
    'Private _registratieDesc As String
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
    Friend WithEvents LabelLeverancier As System.Windows.Forms.Label
    Friend WithEvents _dataFirmaHRM As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM
    Friend WithEvents UltraComboFirma As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LabelBevestigdDoorLeverancier As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorBevestigdDoorLeverancier As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
#End Region

    ' GMAE - 2013-06-20: changed the colour of the labels from 'InactiveCaptionText' into 'Control'

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        bindAndSetBEWPersoneel()
        bindUltraOptionSet()
        initializeMailInfo()

    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()

        _IDRegistratie = IdReg

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        bindAndSetBEWPersoneel()
        bindUltraOptionSet()
        initializeMailInfo()
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
    Friend WithEvents GroupBoxBetrokkenen As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonKiesPersoonMelder As System.Windows.Forms.Button
    Friend WithEvents TextBoxRelaas As System.Windows.Forms.TextBox
    Friend WithEvents LabelRelaas As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesPersoonBelanghebbende As System.Windows.Forms.Button
    Friend WithEvents LabelBelanghebbende As System.Windows.Forms.Label
    Friend WithEvents TextBoxAfdeling As System.Windows.Forms.TextBox
    Friend WithEvents ButtonKiesFirma As System.Windows.Forms.Button
    Friend WithEvents LabelFirma As System.Windows.Forms.Label
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAlcoholtesten As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxTest1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxTest2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelUurTest1 As System.Windows.Forms.Label
    Friend WithEvents LabelUurTest2 As System.Windows.Forms.Label
    Friend WithEvents LabelUitslagTest1 As System.Windows.Forms.Label
    Friend WithEvents LabelUitslagTest2 As System.Windows.Forms.Label
    Friend WithEvents UltraOptionSetUitslagTest1 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraOptionSetUitslagTest2 As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents LabelLocatieTest1 As System.Windows.Forms.Label
    Friend WithEvents LabelLocatieTest2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLocatieTest1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLocatieTest2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMaatregelen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInlichtingen As System.Windows.Forms.TextBox
    Friend WithEvents UltraOptionSetWerknemerVan As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents _dataRegAlcoholtest As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegAlcoholtest
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelWerknemerVan As System.Windows.Forms.Label
    Friend WithEvents UserControlGeneralFunctionsAlcoholtest As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents UltraMaskedEditTest1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditTest2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents _dataIndividuType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype
    Friend WithEvents GroupBoxAlcoholtest As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents TextBoxFirmaId As System.Windows.Forms.TextBox
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents TabOverige As System.Windows.Forms.TabControl
    Friend WithEvents TabPageMaatregelen As System.Windows.Forms.TabPage
    Friend WithEvents TabPageOpmerkingen As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxExtra As System.Windows.Forms.GroupBox
    Friend WithEvents UltraMaskedEditStamnrMelder As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditStamnrBelanghebbende As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents GroupBoxVerzending As System.Windows.Forms.GroupBox
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
    Friend WithEvents LabelNaamMelder As System.Windows.Forms.Label
    Friend WithEvents LabelNaamBelanghebbende As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaNaam As System.Windows.Forms.Label
    Friend WithEvents LabelMelder As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
    Friend WithEvents cbxVerslagnrCHIP As System.Windows.Forms.CheckBox
    Friend WithEvents LabelOpmerkingNaarCHIP As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditorNaarCHIP As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ButtonNaarCHIP As System.Windows.Forms.Button
    Friend WithEvents TextBoxNaarCHIP As System.Windows.Forms.TextBox
    Friend WithEvents LabelNaarChip As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingAlcoholtest))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Firma", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanaam")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("firmanummer")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parent")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("parentnaam")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.GroupBoxBetrokkenen = New System.Windows.Forms.GroupBox()
        Me.LabelFirmaNaam = New System.Windows.Forms.Label()
        Me.LabelNaamBelanghebbende = New System.Windows.Forms.Label()
        Me.LabelNaamMelder = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrBelanghebbende = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEditStamnrMelder = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxFirmaId = New System.Windows.Forms.TextBox()
        Me.UltraOptionSetWerknemerVan = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataIndividuType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype()
        Me.LabelWerknemerVan = New System.Windows.Forms.Label()
        Me.TextBoxAfdeling = New System.Windows.Forms.TextBox()
        Me.ButtonKiesFirma = New System.Windows.Forms.Button()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonBelanghebbende = New System.Windows.Forms.Button()
        Me.LabelBelanghebbende = New System.Windows.Forms.Label()
        Me.TextBoxRelaas = New System.Windows.Forms.TextBox()
        Me.LabelRelaas = New System.Windows.Forms.Label()
        Me.LabelMelder = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonMelder = New System.Windows.Forms.Button()
        Me.GroupBoxAlcoholtesten = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTest2 = New System.Windows.Forms.GroupBox()
        Me.UltraMaskedEditTest2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxLocatieTest2 = New System.Windows.Forms.TextBox()
        Me.LabelLocatieTest2 = New System.Windows.Forms.Label()
        Me.UltraOptionSetUitslagTest2 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.LabelUitslagTest2 = New System.Windows.Forms.Label()
        Me.LabelUurTest2 = New System.Windows.Forms.Label()
        Me.GroupBoxTest1 = New System.Windows.Forms.GroupBox()
        Me.UltraMaskedEditTest1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxLocatieTest1 = New System.Windows.Forms.TextBox()
        Me.LabelLocatieTest1 = New System.Windows.Forms.Label()
        Me.UltraOptionSetUitslagTest1 = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.LabelUitslagTest1 = New System.Windows.Forms.Label()
        Me.LabelUurTest1 = New System.Windows.Forms.Label()
        Me.GroupBoxExtra = New System.Windows.Forms.GroupBox()
        Me.TabOverige = New System.Windows.Forms.TabControl()
        Me.TabPageMaatregelen = New System.Windows.Forms.TabPage()
        Me.TextBoxMaatregelen = New System.Windows.Forms.TextBox()
        Me.TabPageOpmerkingen = New System.Windows.Forms.TabPage()
        Me.TextBoxInlichtingen = New System.Windows.Forms.TextBox()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsAlcoholtest = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me.GroupBoxAlcoholtest = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
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
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me._dataRegAlcoholtest = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegAlcoholtest()
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBetrokkenen.SuspendLayout()
        CType(Me.UltraOptionSetWerknemerVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlcoholtesten.SuspendLayout()
        Me.GroupBoxTest2.SuspendLayout()
        CType(Me.UltraOptionSetUitslagTest2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTest1.SuspendLayout()
        CType(Me.UltraOptionSetUitslagTest1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxExtra.SuspendLayout()
        Me.TabOverige.SuspendLayout()
        Me.TabPageMaatregelen.SuspendLayout()
        Me.TabPageOpmerkingen.SuspendLayout()
        Me.GroupBoxOverige.SuspendLayout()
        Me.GroupBoxAlcoholtest.SuspendLayout()
        Me.GroupBoxVerzending.SuspendLayout()
        CType(Me.UltraDateTimeEditorBevestigdDoorLeverancier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorNaarCHIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegAlcoholtest, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(568, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxKorteOms.TabIndex = 1003
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1004
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(384, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 6
        Me.UltraMaskedEditUur.Text = ":"
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(384, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 4
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(568, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxPlaats.TabIndex = 8
        '
        'LabelPlaats
        '
        Me.LabelPlaats.Location = New System.Drawing.Point(512, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(48, 21)
        Me.LabelPlaats.TabIndex = 7
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.Location = New System.Drawing.Point(352, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(40, 21)
        Me.LabelUur.TabIndex = 5
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.Location = New System.Drawing.Point(336, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(56, 21)
        Me.LabelDatum.TabIndex = 3
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(224, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.Location = New System.Drawing.Point(160, 24)
        Me.LabelVerslagnr.Name = "LabelVerslagnr"
        Me.LabelVerslagnr.Size = New System.Drawing.Size(64, 21)
        Me.LabelVerslagnr.TabIndex = 1
        Me.LabelVerslagnr.Text = "Verslag nr.:"
        Me.LabelVerslagnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitel
        '
        Me.LabelTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitel.Location = New System.Drawing.Point(8, 16)
        Me.LabelTitel.Name = "LabelTitel"
        Me.LabelTitel.Size = New System.Drawing.Size(146, 32)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Alcoholtest"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(216, 8)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 23)
        Me.LabelVolgnr.TabIndex = 1002
        Me.LabelVolgnr.Visible = False
        '
        'GroupBoxBetrokkenen
        '
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelFirmaNaam)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelNaamBelanghebbende)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelNaamMelder)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.UltraMaskedEditStamnrBelanghebbende)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.UltraMaskedEditStamnrMelder)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.TextBoxFirmaId)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.UltraOptionSetWerknemerVan)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelWerknemerVan)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.TextBoxAfdeling)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonKiesFirma)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelFirma)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonKiesPersoonBelanghebbende)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelBelanghebbende)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.TextBoxRelaas)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelRelaas)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.LabelMelder)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonKiesPersoonMelder)
        Me.GroupBoxBetrokkenen.Location = New System.Drawing.Point(0, 55)
        Me.GroupBoxBetrokkenen.Name = "GroupBoxBetrokkenen"
        Me.GroupBoxBetrokkenen.Size = New System.Drawing.Size(1008, 228)
        Me.GroupBoxBetrokkenen.TabIndex = 1
        Me.GroupBoxBetrokkenen.TabStop = False
        Me.GroupBoxBetrokkenen.Text = "Betrokkenen"
        '
        'LabelFirmaNaam
        '
        Me.LabelFirmaNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaNaam.Location = New System.Drawing.Point(600, 201)
        Me.LabelFirmaNaam.Name = "LabelFirmaNaam"
        Me.LabelFirmaNaam.Size = New System.Drawing.Size(312, 20)
        Me.LabelFirmaNaam.TabIndex = 15
        Me.LabelFirmaNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamBelanghebbende
        '
        Me.LabelNaamBelanghebbende.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamBelanghebbende.Location = New System.Drawing.Point(176, 177)
        Me.LabelNaamBelanghebbende.Name = "LabelNaamBelanghebbende"
        Me.LabelNaamBelanghebbende.Size = New System.Drawing.Size(240, 20)
        Me.LabelNaamBelanghebbende.TabIndex = 8
        Me.LabelNaamBelanghebbende.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamMelder
        '
        Me.LabelNaamMelder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamMelder.Location = New System.Drawing.Point(176, 11)
        Me.LabelNaamMelder.Name = "LabelNaamMelder"
        Me.LabelNaamMelder.Size = New System.Drawing.Size(240, 20)
        Me.LabelNaamMelder.TabIndex = 2
        Me.LabelNaamMelder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrBelanghebbende
        '
        Me.UltraMaskedEditStamnrBelanghebbende.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrBelanghebbende.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrBelanghebbende.Location = New System.Drawing.Point(120, 177)
        Me.UltraMaskedEditStamnrBelanghebbende.MaxValue = 99999999
        Me.UltraMaskedEditStamnrBelanghebbende.Name = "UltraMaskedEditStamnrBelanghebbende"
        Me.UltraMaskedEditStamnrBelanghebbende.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrBelanghebbende.TabIndex = 7
        '
        'UltraMaskedEditStamnrMelder
        '
        Me.UltraMaskedEditStamnrMelder.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrMelder.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrMelder.Location = New System.Drawing.Point(120, 11)
        Me.UltraMaskedEditStamnrMelder.MaxValue = 99999999
        Me.UltraMaskedEditStamnrMelder.Name = "UltraMaskedEditStamnrMelder"
        Me.UltraMaskedEditStamnrMelder.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrMelder.TabIndex = 1
        '
        'TextBoxFirmaId
        '
        Me.TextBoxFirmaId.Location = New System.Drawing.Point(584, 201)
        Me.TextBoxFirmaId.Name = "TextBoxFirmaId"
        Me.TextBoxFirmaId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxFirmaId.TabIndex = 17
        Me.TextBoxFirmaId.Visible = False
        '
        'UltraOptionSetWerknemerVan
        '
        Me.UltraOptionSetWerknemerVan.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetWerknemerVan.DataMember = "BBINDTY"
        Me.UltraOptionSetWerknemerVan.DataSource = Me._dataIndividuType
        Me.UltraOptionSetWerknemerVan.DisplayMember = "SCF_TY_IND"
        Me.UltraOptionSetWerknemerVan.Location = New System.Drawing.Point(110, 201)
        Me.UltraOptionSetWerknemerVan.Name = "UltraOptionSetWerknemerVan"
        Me.UltraOptionSetWerknemerVan.Size = New System.Drawing.Size(408, 16)
        Me.UltraOptionSetWerknemerVan.TabIndex = 13
        Me.UltraOptionSetWerknemerVan.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetWerknemerVan.ValueMember = "ID_TY_IND"
        '
        '_dataIndividuType
        '
        Me._dataIndividuType.DataSetName = "TDSIndividutype"
        Me._dataIndividuType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelWerknemerVan
        '
        Me.LabelWerknemerVan.Location = New System.Drawing.Point(16, 201)
        Me.LabelWerknemerVan.Name = "LabelWerknemerVan"
        Me.LabelWerknemerVan.Size = New System.Drawing.Size(88, 16)
        Me.LabelWerknemerVan.TabIndex = 12
        Me.LabelWerknemerVan.Text = "Werknemer van:"
        Me.LabelWerknemerVan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxAfdeling
        '
        Me.TextBoxAfdeling.Enabled = False
        Me.TextBoxAfdeling.Location = New System.Drawing.Point(600, 177)
        Me.TextBoxAfdeling.Name = "TextBoxAfdeling"
        Me.TextBoxAfdeling.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxAfdeling.TabIndex = 11
        '
        'ButtonKiesFirma
        '
        Me.ButtonKiesFirma.Location = New System.Drawing.Point(920, 201)
        Me.ButtonKiesFirma.Name = "ButtonKiesFirma"
        Me.ButtonKiesFirma.Size = New System.Drawing.Size(75, 20)
        Me.ButtonKiesFirma.TabIndex = 16
        Me.ButtonKiesFirma.Text = "Kies Firma"
        '
        'LabelFirma
        '
        Me.LabelFirma.Location = New System.Drawing.Point(536, 201)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(40, 16)
        Me.LabelFirma.TabIndex = 14
        Me.LabelFirma.Text = "Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(536, 177)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(48, 23)
        Me.LabelAfdeling.TabIndex = 10
        Me.LabelAfdeling.Text = "Afdeling:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonBelanghebbende
        '
        Me.ButtonKiesPersoonBelanghebbende.Location = New System.Drawing.Point(424, 177)
        Me.ButtonKiesPersoonBelanghebbende.Name = "ButtonKiesPersoonBelanghebbende"
        Me.ButtonKiesPersoonBelanghebbende.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoonBelanghebbende.TabIndex = 9
        Me.ButtonKiesPersoonBelanghebbende.Text = "Kies persoon"
        '
        'LabelBelanghebbende
        '
        Me.LabelBelanghebbende.Location = New System.Drawing.Point(16, 177)
        Me.LabelBelanghebbende.Name = "LabelBelanghebbende"
        Me.LabelBelanghebbende.Size = New System.Drawing.Size(100, 23)
        Me.LabelBelanghebbende.TabIndex = 6
        Me.LabelBelanghebbende.Text = "Belanghebbende:"
        Me.LabelBelanghebbende.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxRelaas
        '
        Me.TextBoxRelaas.Location = New System.Drawing.Point(120, 33)
        Me.TextBoxRelaas.Multiline = True
        Me.TextBoxRelaas.Name = "TextBoxRelaas"
        Me.TextBoxRelaas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRelaas.Size = New System.Drawing.Size(880, 144)
        Me.TextBoxRelaas.TabIndex = 5
        '
        'LabelRelaas
        '
        Me.LabelRelaas.Location = New System.Drawing.Point(16, 33)
        Me.LabelRelaas.Name = "LabelRelaas"
        Me.LabelRelaas.Size = New System.Drawing.Size(104, 23)
        Me.LabelRelaas.TabIndex = 4
        Me.LabelRelaas.Text = "Relaas der feiten:"
        Me.LabelRelaas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMelder
        '
        Me.LabelMelder.Location = New System.Drawing.Point(16, 11)
        Me.LabelMelder.Name = "LabelMelder"
        Me.LabelMelder.Size = New System.Drawing.Size(72, 23)
        Me.LabelMelder.TabIndex = 0
        Me.LabelMelder.Text = "Melder:"
        Me.LabelMelder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonMelder
        '
        Me.ButtonKiesPersoonMelder.Location = New System.Drawing.Point(424, 11)
        Me.ButtonKiesPersoonMelder.Name = "ButtonKiesPersoonMelder"
        Me.ButtonKiesPersoonMelder.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoonMelder.TabIndex = 3
        Me.ButtonKiesPersoonMelder.Text = "Kies persoon"
        '
        'GroupBoxAlcoholtesten
        '
        Me.GroupBoxAlcoholtesten.Controls.Add(Me.GroupBoxTest2)
        Me.GroupBoxAlcoholtesten.Controls.Add(Me.GroupBoxTest1)
        Me.GroupBoxAlcoholtesten.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxAlcoholtesten.Name = "GroupBoxAlcoholtesten"
        Me.GroupBoxAlcoholtesten.Size = New System.Drawing.Size(528, 128)
        Me.GroupBoxAlcoholtesten.TabIndex = 2
        Me.GroupBoxAlcoholtesten.TabStop = False
        Me.GroupBoxAlcoholtesten.Text = "Alcoholtesten"
        Me.GroupBoxAlcoholtesten.Visible = False
        '
        'GroupBoxTest2
        '
        Me.GroupBoxTest2.Controls.Add(Me.UltraMaskedEditTest2)
        Me.GroupBoxTest2.Controls.Add(Me.TextBoxLocatieTest2)
        Me.GroupBoxTest2.Controls.Add(Me.LabelLocatieTest2)
        Me.GroupBoxTest2.Controls.Add(Me.UltraOptionSetUitslagTest2)
        Me.GroupBoxTest2.Controls.Add(Me.LabelUitslagTest2)
        Me.GroupBoxTest2.Controls.Add(Me.LabelUurTest2)
        Me.GroupBoxTest2.Location = New System.Drawing.Point(280, 24)
        Me.GroupBoxTest2.Name = "GroupBoxTest2"
        Me.GroupBoxTest2.Size = New System.Drawing.Size(240, 96)
        Me.GroupBoxTest2.TabIndex = 1
        Me.GroupBoxTest2.TabStop = False
        Me.GroupBoxTest2.Text = "Test 2"
        '
        'UltraMaskedEditTest2
        '
        Me.UltraMaskedEditTest2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditTest2.InputMask = "{time}"
        Me.UltraMaskedEditTest2.Location = New System.Drawing.Point(80, 16)
        Me.UltraMaskedEditTest2.Name = "UltraMaskedEditTest2"
        Me.UltraMaskedEditTest2.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditTest2.TabIndex = 1
        Me.UltraMaskedEditTest2.Text = ":"
        Me.UltraMaskedEditTest2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxLocatieTest2
        '
        Me.TextBoxLocatieTest2.Enabled = False
        Me.TextBoxLocatieTest2.Location = New System.Drawing.Point(80, 64)
        Me.TextBoxLocatieTest2.Name = "TextBoxLocatieTest2"
        Me.TextBoxLocatieTest2.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxLocatieTest2.TabIndex = 5
        Me.TextBoxLocatieTest2.Text = "Onbekend"
        '
        'LabelLocatieTest2
        '
        Me.LabelLocatieTest2.Location = New System.Drawing.Point(8, 64)
        Me.LabelLocatieTest2.Name = "LabelLocatieTest2"
        Me.LabelLocatieTest2.Size = New System.Drawing.Size(56, 23)
        Me.LabelLocatieTest2.TabIndex = 4
        Me.LabelLocatieTest2.Text = "Locatie:"
        Me.LabelLocatieTest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraOptionSetUitslagTest2
        '
        Me.UltraOptionSetUitslagTest2.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetUitslagTest2.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraOptionSetUitslagTest2.Enabled = False
        ValueListItem17.DataValue = True
        ValueListItem17.DisplayText = "Positief"
        ValueListItem18.DataValue = False
        ValueListItem18.DisplayText = "Negatief"
        Me.UltraOptionSetUitslagTest2.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem17, ValueListItem18})
        Me.UltraOptionSetUitslagTest2.Location = New System.Drawing.Point(80, 44)
        Me.UltraOptionSetUitslagTest2.Name = "UltraOptionSetUitslagTest2"
        Me.UltraOptionSetUitslagTest2.Size = New System.Drawing.Size(120, 16)
        Me.UltraOptionSetUitslagTest2.TabIndex = 3
        Me.UltraOptionSetUitslagTest2.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        '
        'LabelUitslagTest2
        '
        Me.LabelUitslagTest2.Location = New System.Drawing.Point(8, 40)
        Me.LabelUitslagTest2.Name = "LabelUitslagTest2"
        Me.LabelUitslagTest2.Size = New System.Drawing.Size(48, 23)
        Me.LabelUitslagTest2.TabIndex = 2
        Me.LabelUitslagTest2.Text = "Uitslag:"
        Me.LabelUitslagTest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUurTest2
        '
        Me.LabelUurTest2.Location = New System.Drawing.Point(8, 16)
        Me.LabelUurTest2.Name = "LabelUurTest2"
        Me.LabelUurTest2.Size = New System.Drawing.Size(32, 23)
        Me.LabelUurTest2.TabIndex = 0
        Me.LabelUurTest2.Text = "Uur:"
        Me.LabelUurTest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxTest1
        '
        Me.GroupBoxTest1.Controls.Add(Me.UltraMaskedEditTest1)
        Me.GroupBoxTest1.Controls.Add(Me.TextBoxLocatieTest1)
        Me.GroupBoxTest1.Controls.Add(Me.LabelLocatieTest1)
        Me.GroupBoxTest1.Controls.Add(Me.UltraOptionSetUitslagTest1)
        Me.GroupBoxTest1.Controls.Add(Me.LabelUitslagTest1)
        Me.GroupBoxTest1.Controls.Add(Me.LabelUurTest1)
        Me.GroupBoxTest1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBoxTest1.Name = "GroupBoxTest1"
        Me.GroupBoxTest1.Size = New System.Drawing.Size(240, 96)
        Me.GroupBoxTest1.TabIndex = 0
        Me.GroupBoxTest1.TabStop = False
        Me.GroupBoxTest1.Text = "Test 1"
        '
        'UltraMaskedEditTest1
        '
        Me.UltraMaskedEditTest1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditTest1.InputMask = "{time}"
        Me.UltraMaskedEditTest1.Location = New System.Drawing.Point(80, 16)
        Me.UltraMaskedEditTest1.Name = "UltraMaskedEditTest1"
        Me.UltraMaskedEditTest1.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditTest1.TabIndex = 1
        Me.UltraMaskedEditTest1.Text = ":"
        Me.UltraMaskedEditTest1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxLocatieTest1
        '
        Me.TextBoxLocatieTest1.Enabled = False
        Me.TextBoxLocatieTest1.Location = New System.Drawing.Point(80, 64)
        Me.TextBoxLocatieTest1.Name = "TextBoxLocatieTest1"
        Me.TextBoxLocatieTest1.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxLocatieTest1.TabIndex = 5
        Me.TextBoxLocatieTest1.Text = "Onbekend"
        '
        'LabelLocatieTest1
        '
        Me.LabelLocatieTest1.Location = New System.Drawing.Point(8, 64)
        Me.LabelLocatieTest1.Name = "LabelLocatieTest1"
        Me.LabelLocatieTest1.Size = New System.Drawing.Size(64, 23)
        Me.LabelLocatieTest1.TabIndex = 4
        Me.LabelLocatieTest1.Text = "Locatie:"
        Me.LabelLocatieTest1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraOptionSetUitslagTest1
        '
        Me.UltraOptionSetUitslagTest1.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetUitslagTest1.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraOptionSetUitslagTest1.Enabled = False
        ValueListItem19.DataValue = True
        ValueListItem19.DisplayText = "Positief"
        ValueListItem20.DataValue = False
        ValueListItem20.DisplayText = "Negatief"
        Me.UltraOptionSetUitslagTest1.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem19, ValueListItem20})
        Me.UltraOptionSetUitslagTest1.Location = New System.Drawing.Point(80, 44)
        Me.UltraOptionSetUitslagTest1.Name = "UltraOptionSetUitslagTest1"
        Me.UltraOptionSetUitslagTest1.Size = New System.Drawing.Size(120, 16)
        Me.UltraOptionSetUitslagTest1.TabIndex = 3
        Me.UltraOptionSetUitslagTest1.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        '
        'LabelUitslagTest1
        '
        Me.LabelUitslagTest1.Location = New System.Drawing.Point(8, 40)
        Me.LabelUitslagTest1.Name = "LabelUitslagTest1"
        Me.LabelUitslagTest1.Size = New System.Drawing.Size(48, 23)
        Me.LabelUitslagTest1.TabIndex = 2
        Me.LabelUitslagTest1.Text = "Uitslag:"
        Me.LabelUitslagTest1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUurTest1
        '
        Me.LabelUurTest1.Location = New System.Drawing.Point(8, 16)
        Me.LabelUurTest1.Name = "LabelUurTest1"
        Me.LabelUurTest1.Size = New System.Drawing.Size(56, 23)
        Me.LabelUurTest1.TabIndex = 0
        Me.LabelUurTest1.Text = "Uur:"
        Me.LabelUurTest1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxExtra
        '
        Me.GroupBoxExtra.Controls.Add(Me.TabOverige)
        Me.GroupBoxExtra.Controls.Add(Me.GroupBoxAlcoholtesten)
        Me.GroupBoxExtra.Location = New System.Drawing.Point(0, 282)
        Me.GroupBoxExtra.Name = "GroupBoxExtra"
        Me.GroupBoxExtra.Size = New System.Drawing.Size(1008, 128)
        Me.GroupBoxExtra.TabIndex = 3
        Me.GroupBoxExtra.TabStop = False
        Me.GroupBoxExtra.Text = "Extra"
        '
        'TabOverige
        '
        Me.TabOverige.Controls.Add(Me.TabPageMaatregelen)
        Me.TabOverige.Controls.Add(Me.TabPageOpmerkingen)
        Me.TabOverige.Location = New System.Drawing.Point(8, 16)
        Me.TabOverige.Name = "TabOverige"
        Me.TabOverige.SelectedIndex = 0
        Me.TabOverige.Size = New System.Drawing.Size(976, 104)
        Me.TabOverige.TabIndex = 0
        '
        'TabPageMaatregelen
        '
        Me.TabPageMaatregelen.Controls.Add(Me.TextBoxMaatregelen)
        Me.TabPageMaatregelen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMaatregelen.Name = "TabPageMaatregelen"
        Me.TabPageMaatregelen.Size = New System.Drawing.Size(968, 78)
        Me.TabPageMaatregelen.TabIndex = 0
        Me.TabPageMaatregelen.Text = "Maatregelen"
        '
        'TextBoxMaatregelen
        '
        Me.TextBoxMaatregelen.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxMaatregelen.Multiline = True
        Me.TextBoxMaatregelen.Name = "TextBoxMaatregelen"
        Me.TextBoxMaatregelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMaatregelen.Size = New System.Drawing.Size(952, 64)
        Me.TextBoxMaatregelen.TabIndex = 0
        '
        'TabPageOpmerkingen
        '
        Me.TabPageOpmerkingen.Controls.Add(Me.TextBoxInlichtingen)
        Me.TabPageOpmerkingen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOpmerkingen.Name = "TabPageOpmerkingen"
        Me.TabPageOpmerkingen.Size = New System.Drawing.Size(968, 78)
        Me.TabPageOpmerkingen.TabIndex = 1
        Me.TabPageOpmerkingen.Text = "Opmerkingen"
        '
        'TextBoxInlichtingen
        '
        Me.TextBoxInlichtingen.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxInlichtingen.Multiline = True
        Me.TextBoxInlichtingen.Name = "TextBoxInlichtingen"
        Me.TextBoxInlichtingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInlichtingen.Size = New System.Drawing.Size(952, 64)
        Me.TextBoxInlichtingen.TabIndex = 0
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsAlcoholtest)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 409)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 166)
        Me.GroupBoxOverige.TabIndex = 4
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsAlcoholtest
        '
        Me.UserControlGeneralFunctionsAlcoholtest.AutoSize = True
        Me.UserControlGeneralFunctionsAlcoholtest.DatumOpstelling = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsAlcoholtest.GetReportContractant = False
        Me.UserControlGeneralFunctionsAlcoholtest.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsAlcoholtest.Name = "UserControlGeneralFunctionsAlcoholtest"
        Me.UserControlGeneralFunctionsAlcoholtest.Opsteller = 0
        Me.UserControlGeneralFunctionsAlcoholtest.Size = New System.Drawing.Size(512, 144)
        Me.UserControlGeneralFunctionsAlcoholtest.TabIndex = 0
        Me.UserControlGeneralFunctionsAlcoholtest.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        'GroupBoxAlcoholtest
        '
        Me.GroupBoxAlcoholtest.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxAlcoholtest.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxAlcoholtest.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxAlcoholtest.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxAlcoholtest.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxAlcoholtest.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxAlcoholtest.Location = New System.Drawing.Point(0, 577)
        Me.GroupBoxAlcoholtest.Name = "GroupBoxAlcoholtest"
        Me.GroupBoxAlcoholtest.Size = New System.Drawing.Size(528, 50)
        Me.GroupBoxAlcoholtest.TabIndex = 6
        Me.GroupBoxAlcoholtest.TabStop = False
        Me.GroupBoxAlcoholtest.Text = "Alcoholtest"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(310, 27)
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
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance1
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonAnnuleer
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance2
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 0
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance3
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(216, 16)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 2
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraButtonOverzicht
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonOverzicht.Appearance = Appearance4
        Me.UltraButtonOverzicht.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOverzicht.Location = New System.Drawing.Point(320, 16)
        Me.UltraButtonOverzicht.Name = "UltraButtonOverzicht"
        Me.UltraButtonOverzicht.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOverzicht.TabIndex = 3
        Me.UltraButtonOverzicht.Text = "Overzicht"
        '
        'UltraButtonSluiten
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance5
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
        Me._statusBar.Location = New System.Drawing.Point(0, 628)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1001
        Me._statusBar.User = ""
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 409)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 218)
        Me.GroupBoxVerzending.TabIndex = 5
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'LabelBevestigdDoorLeverancier
        '
        Me.LabelBevestigdDoorLeverancier.AutoSize = True
        Me.LabelBevestigdDoorLeverancier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboFirma.DisplayLayout.Appearance = Appearance6
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 150
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.UltraComboFirma.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboFirma.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboFirma.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraComboFirma.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboFirma.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraComboFirma.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboFirma.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboFirma.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboFirma.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboFirma.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraComboFirma.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboFirma.DisplayLayout.Override.CellPadding = 0
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboFirma.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraComboFirma.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraComboFirma.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboFirma.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboFirma.DisplayLayout.Override.RowAppearance = Appearance16
        Me.UltraComboFirma.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboFirma.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
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
        Me.cbxVerslagnrCHIP.Location = New System.Drawing.Point(287, 101)
        Me.cbxVerslagnrCHIP.Name = "cbxVerslagnrCHIP"
        Me.cbxVerslagnrCHIP.Size = New System.Drawing.Size(51, 17)
        Me.cbxVerslagnrCHIP.TabIndex = 23
        Me.cbxVerslagnrCHIP.Text = "CHIP"
        Me.cbxVerslagnrCHIP.UseVisualStyleBackColor = True
        '
        'LabelOpmerkingNaarCHIP
        '
        Me.LabelOpmerkingNaarCHIP.AutoSize = True
        Me.LabelOpmerkingNaarCHIP.Location = New System.Drawing.Point(8, 168)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
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
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataRegAlcoholtest
        '
        Me._dataRegAlcoholtest.DataSetName = "TDSRegAlcoholtest"
        Me._dataRegAlcoholtest.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegAlcoholtest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBewakingAlcoholtest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 650)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxAlcoholtest)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxExtra)
        Me.Controls.Add(Me.GroupBoxBetrokkenen)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Name = "FormBewakingAlcoholtest"
        Me.Text = "Alcoholtest"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBetrokkenen.ResumeLayout(False)
        Me.GroupBoxBetrokkenen.PerformLayout()
        CType(Me.UltraOptionSetWerknemerVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlcoholtesten.ResumeLayout(False)
        Me.GroupBoxTest2.ResumeLayout(False)
        Me.GroupBoxTest2.PerformLayout()
        CType(Me.UltraOptionSetUitslagTest2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTest1.ResumeLayout(False)
        Me.GroupBoxTest1.PerformLayout()
        CType(Me.UltraOptionSetUitslagTest1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxExtra.ResumeLayout(False)
        Me.TabOverige.ResumeLayout(False)
        Me.TabPageMaatregelen.ResumeLayout(False)
        Me.TabPageMaatregelen.PerformLayout()
        Me.TabPageOpmerkingen.ResumeLayout(False)
        Me.TabPageOpmerkingen.PerformLayout()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        Me.GroupBoxAlcoholtest.ResumeLayout(False)
        Me.GroupBoxVerzending.ResumeLayout(False)
        Me.GroupBoxVerzending.PerformLayout()
        CType(Me.UltraDateTimeEditorBevestigdDoorLeverancier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmaHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorNaarCHIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegAlcoholtest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FormBewakingAlcoholtest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            setLabelsVerplicht()

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
            '-----------------------------------------------------------------------

            If _IDRegistratie <> -1 Then
                bindRegistratie()
            End If
            'voor usercontrolAlcoholtest
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsAlcoholtest.DatumOpstelling = Now
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


            Me.UserControlGeneralFunctionsAlcoholtest.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

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
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            _dataRegAlcoholtest.Clear()
            Me._dataRegAlcoholtest.Merge(Me._controller.GetRegAlcoholtest(_IDRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegAlcoholtest.BBBEWREGRow
            dr = Me._dataRegAlcoholtest.BBBEWREG.FindByID_REG(_IDRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsAlcoholtest.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsAlcoholtest.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsAlcoholtest.Opsteller = Nothing
            End If

            If (Me._dataRegAlcoholtest.BBBEWREG.Rows.Count > 0) Then
                If Not (_dataRegAlcoholtest.BBBEWREG(0).IsVeraLinkNull) Then
                    UserControlGeneralFunctionsAlcoholtest.SetVeraData(_dataRegAlcoholtest.BBBEWREG(0).VeraReference.ToString,
                                                                       _dataRegAlcoholtest.BBBEWREG(0).VeraLink.ToString)
                End If

                If Not (_dataRegAlcoholtest.BBBEWREG(0).IsVerslagContractantYNNull) Then
                    UserControlGeneralFunctionsAlcoholtest.GetReportContractant = _dataRegAlcoholtest.BBBEWREG(0).VerslagContractantYN
                End If
            End If

            'Alcoholtestgegevens opvullen
            Dim drAlch As TDSRegAlcoholtest.BBALCTSTRow
            drAlch = CType(Me._dataRegAlcoholtest.BBALCTST.Rows.Item(0), TDSRegAlcoholtest.BBALCTSTRow)

            UltraMaskedEditStamnrMelder.Text = CStr(drAlch.ID_MLD)
            If Not drAlch.IsNM_INDNull And Not drAlch.IsVNM_INDNull Then
                LabelNaamMelder.Text = drAlch.NM_IND.Trim & " " & drAlch.VNM_IND.Trim
            ElseIf Not drAlch.IsNM_INDNull Then
                LabelNaamMelder.Text = drAlch.NM_IND
            ElseIf Not drAlch.IsVNM_INDNull Then
                LabelNaamMelder.Text = drAlch.VNM_IND
            Else
                LabelNaamMelder.Text = ""
            End If

            If Not drAlch.IsSCF_LNG_TST_ALCNull Then
                TextBoxRelaas.Text = drAlch.SCF_LNG_TST_ALC
            End If

            UltraMaskedEditStamnrBelanghebbende.Text = CStr(drAlch.ID_BTRK)
            If Not drAlch.IsNM_IND1Null And Not drAlch.IsVNM_IND1Null Then
                LabelNaamBelanghebbende.Text = drAlch.NM_IND1.Trim & " " & drAlch.VNM_IND1.Trim
            ElseIf Not drAlch.IsNM_IND1Null Then
                LabelNaamBelanghebbende.Text = drAlch.NM_IND1
            ElseIf Not drAlch.IsVNM_IND1Null Then
                LabelNaamBelanghebbende.Text = drAlch.VNM_IND1
            Else
                LabelNaamBelanghebbende.Text = ""
            End If

            If Not drAlch.IsSAP_AFDNull Then
                TextBoxAfdeling.Text = drAlch.SAP_AFD
            End If
            If Not drAlch.IsID_FRMNull Then
                TextBoxFirmaId.Text = CStr(drAlch.ID_FRM)
            End If
            If Not drAlch.IsNM_FRMNull Then
                LabelFirmaNaam.Text = drAlch.NM_FRM
            End If
            If Not drAlch.IsTYD_TST_ALC_1Null Then
                UltraMaskedEditTest1.Text = CStr(drAlch.TYD_TST_ALC_1)
                If Not drAlch.IsINDI_TST_1_POSNull Then
                    UltraOptionSetUitslagTest1.Value = drAlch.INDI_TST_1_POS
                    UltraOptionSetUitslagTest1.Enabled = True
                    TextBoxLocatieTest1.Enabled = True
                End If
            End If
            If Not drAlch.IsTYD_TST_ALC_2Null Then
                UltraMaskedEditTest2.Text = CStr(drAlch.TYD_TST_ALC_2)
                If Not drAlch.IsINDI_TST_2_POSNull Then
                    UltraOptionSetUitslagTest2.Value = drAlch.INDI_TST_2_POS
                    UltraOptionSetUitslagTest2.Enabled = True
                    TextBoxLocatieTest2.Enabled = True
                End If
            End If

            If Not drAlch.IsID_TY_INDNull Then
                UltraOptionSetWerknemerVan.Value = drAlch.ID_TY_IND
            End If
            If Not drAlch.IsPLA_TST_ALC_1Null Then
                TextBoxLocatieTest1.Text = drAlch.PLA_TST_ALC_1
            End If
            If Not drAlch.IsPLA_TST_ALC_2Null Then
                TextBoxLocatieTest2.Text = drAlch.PLA_TST_ALC_2
            End If
            If Not drAlch.IsSCF_RGL_NEMNull Then
                TextBoxMaatregelen.Text = drAlch.SCF_RGL_NEM
            End If
            If Not drAlch.IsINF_EX_TST_ALCNull Then
                TextBoxInlichtingen.Text = drAlch.INF_EX_TST_ALC
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

            Me.UserControlGeneralFunctionsAlcoholtest.setBijlageData(Me._dataRegAlcoholtest.BBBYLG)
            Me.UserControlGeneralFunctionsAlcoholtest.setBestemmelingenData(Me._dataRegAlcoholtest.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_IDRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - bindRegistratie()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindUltraOptionSet()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataIndividuType.Merge(Me._controller.GetIndividuTypes)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - bindUltraOptionSet" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindAndSetBEWPersoneel()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

            If _IDRegistratie = -1 Then 'nieuwe registratie - naco 08/02/2017
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneelActief())
            Else
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneel())
            End If

            Me.UserControlGeneralFunctionsAlcoholtest.setPersoneelData(_dataBEWPersoneel)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerAlcoholtest - bindAndSetBEWPersoneel" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindBijlagen()
        Me.UserControlGeneralFunctionsAlcoholtest.setBijlageData(_dataRegAlcoholtest.BBBYLG)
    End Sub

    Private Sub bindBestemmelingen()
        Me.UserControlGeneralFunctionsAlcoholtest.setBestemmelingenData(_dataRegAlcoholtest.BBBST)
    End Sub
#End Region

#Region "Button and Optionset Eventhandlers"

    Private Sub ButtonKiesFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesFirma.Click
        Try
            Using f_firma As FormBewakingFirmas = New FormBewakingFirmas

                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    TextBoxFirmaId.Text = CStr(f_firma.IdFirma)
                    LabelFirmaNaam.Text = f_firma.NaamFirma
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonMelder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonMelder.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrMelder.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamMelder.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamMelder.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamMelder.Text = individu.VNM_IND
                Else
                    LabelNaamMelder.Text = ""
                End If
            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonBelanghebbende_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonBelanghebbende.Click
        Try

            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrBelanghebbende.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamBelanghebbende.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamBelanghebbende.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamBelanghebbende.Text = individu.VNM_IND
                Else
                    LabelNaamBelanghebbende.Text = ""
                End If

                If Not individu.IsID_TY_INDNull Then
                    UltraOptionSetWerknemerVan.Value = individu.ID_TY_IND
                Else
                    UltraOptionSetWerknemerVan.Value = Nothing
                End If
                If Not individu.IsSAP_AFDNull Then
                    TextBoxAfdeling.Text = individu.SAP_AFD
                Else
                    TextBoxAfdeling.Text = ""
                End If
            End If

            f_ind.Close()

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
        '      als je bestaande registratie aan het wijzigen was: terug alles zetten zoals het in de database staat
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

    Private Sub UltraMaskedEditTest1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraMaskedEditTest1.ValueChanged
        Try
            If UltraMaskedEditTest1.Text <> "__:__" And UltraMaskedEditTest1.Text <> ":" Then
                UltraOptionSetUitslagTest1.Enabled = True
                TextBoxLocatieTest1.Enabled = True
            Else
                UltraOptionSetUitslagTest1.Enabled = False
                TextBoxLocatieTest1.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditTest2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraMaskedEditTest2.ValueChanged
        Try
            If UltraMaskedEditTest2.Text <> "__:__" And UltraMaskedEditTest2.Text <> ":" Then
                UltraOptionSetUitslagTest2.Enabled = True
                TextBoxLocatieTest2.Enabled = True
            Else
                UltraOptionSetUitslagTest2.Enabled = False
                TextBoxLocatieTest2.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region

#Region "Functions"
    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsAlcoholtest.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
        UserControlGeneralFunctionsAlcoholtest.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub

    Private Sub setLabelsVerplicht()
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelMelder.Text &= " *"
        LabelRelaas.Text &= " *"
        LabelBelanghebbende.Text &= " *"
        LabelUurTest1.Text &= " *"
        LabelLocatieTest1.Text &= " *"
        LabelLocatieTest2.Text &= " *"
    End Sub
#End Region

#Region "User Control"

    Private Sub UserControlGeneralFunctionsAlcoholtest_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsAlcoholtest.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, String.Empty)

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsAlcoholtest.addBestemmeling(Me._IDRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsAlcoholtest.addBestemmeling(Me._IDRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
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
    Private Sub UltraMaskedEditStamnrMelder_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrMelder.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrMelder, Me.LabelNaamMelder)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrMelder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrMelder.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrMelder, Me.LabelNaamMelder)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrBelanghebbende_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrBelanghebbende.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBelanghebbende, Me.LabelNaamBelanghebbende)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrBelanghebbende_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrBelanghebbende.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBelanghebbende, Me.LabelNaamBelanghebbende)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub handleAfterStamnrLeave(ByRef UltraMaskedEditStamnr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit, _
                                       ByRef LabelNaam As Label)
        Try

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

                        'naco - 27/12/2006 - ook afdeling invullen
                        If UltraMaskedEditStamnr.Name = Me.UltraMaskedEditStamnrBelanghebbende.Name Then
                            If individu.IsSAP_AFDNull Then
                                TextBoxAfdeling.Text = ""
                            Else
                                TextBoxAfdeling.Text = individu.SAP_AFD
                            End If

                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message & " " & ex.StackTrace, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                LabelNaam.Text = ""

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
    Private Sub FormBewakingAlcoholtest_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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
        'Doel: nieuwe alcoholtest toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 27/04/2006
        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus("De registratie werd succesvol opgeslagen")
            Else
                'boodschap weergeven
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

        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

        Dim dsAlcoholtest As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest
        Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBEWREGRow
        Dim drAlcoholtest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBALCTSTRow
        Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBYLGRow
        Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList


        Try

            Me.Cursor = Cursors.WaitCursor
            dsAlcoholtest.BBBST.DataSet.Clear()
            dsAlcoholtest.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsAlcoholtest.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsAlcoholtest.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd

            If (UserControlGeneralFunctionsAlcoholtest.CheckBestemmelingen(dsBest) = True) Then
                _controller = New ControllerGetData
                If Me._IDRegistratie = -1 Then 'nieuwe alcoholtest

                    drRegistratie = dsAlcoholtest.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsAlcoholtest.Opsteller
                        .ID_TY_REG = 8
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsAlcoholtest.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsAlcoholtest.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsAlcoholtest.GetVeraReference
                        .VerslagContractantYN = Me.UserControlGeneralFunctionsAlcoholtest.GetReportContractant
                    End With
                    dsAlcoholtest.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Alcoholtest
                    '--------------
                    drAlcoholtest = dsAlcoholtest.BBALCTST.NewBBALCTSTRow
                    With drAlcoholtest
                        .ID_REG = id_reg
                        .ID_MLD = CInt(Me.UltraMaskedEditStamnrMelder.Text)
                        .ID_BTRK = CInt(Me.UltraMaskedEditStamnrBelanghebbende.Text)
                        If Not TextBoxFirmaId.Text = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        .SCF_LNG_TST_ALC = Me.TextBoxRelaas.Text
                        .TYD_TST_ALC_1 = Me.UltraMaskedEditTest1.Text
                        .INDI_TST_1_POS = CType(Me.UltraOptionSetUitslagTest1.Value, Boolean)
                        .PLA_TST_ALC_1 = Me.TextBoxLocatieTest1.Text
                        If UltraMaskedEditTest2.Text = "__:__" Or UltraMaskedEditTest2.Text = ":" Then
                            'do nothing ==> geen gegevens van test 2 toevoegen
                        Else
                            .TYD_TST_ALC_2 = Me.UltraMaskedEditTest2.Text
                            .INDI_TST_2_POS = CType(Me.UltraOptionSetUitslagTest2.Value, Boolean)
                            .PLA_TST_ALC_2 = Me.TextBoxLocatieTest2.Text
                        End If
                        .SCF_RGL_NEM = Me.TextBoxMaatregelen.Text
                        .INF_EX_TST_ALC = Me.TextBoxInlichtingen.Text
                    End With
                    dsAlcoholtest.BBALCTST.AddBBALCTSTRow(drAlcoholtest)

                    '3. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    Dim drByl As DataRow
                    Dim chronicleID As String

                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsAlcoholtest.BBBYLG.NewBBBYLGRow
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
                            chronicleID = UploadAlcoholtestBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If
                        dsAlcoholtest.BBBYLG.AddBBBYLGRow(drBylagen)

                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegDivRegistratie.BBBSTRow
                    Dim drBest As DataRow
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsAlcoholtest.BBBST.NewBBBSTRow
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

                        dsAlcoholtest.BBBST.AddBBBSTRow(drBestemmelingen)
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

                Else 'bestaande alcoholtest wijzigen
                    dsAlcoholtest.Merge(Me._controller.GetRegAlcoholtest(Me._IDRegistratie))
                    drRegistratie = dsAlcoholtest.BBBEWREG.FindByID_REG(Me._IDRegistratie)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._IDRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsAlcoholtest.Opsteller
                        .ID_TY_REG = 8
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsAlcoholtest.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsAlcoholtest.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsAlcoholtest.GetVeraReference
                        .VerslagContractantYN = Me.UserControlGeneralFunctionsAlcoholtest.GetReportContractant
                    End With

                    '2. Alcoholtest
                    '--------------
                    drAlcoholtest = CType(dsAlcoholtest.BBALCTST.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBALCTSTRow)
                    With drAlcoholtest
                        .ID_REG = Me._IDRegistratie
                        .ID_MLD = CInt(Me.UltraMaskedEditStamnrMelder.Text)
                        .ID_BTRK = CInt(Me.UltraMaskedEditStamnrBelanghebbende.Text)
                        If Not TextBoxFirmaId.Text = "" Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                        End If
                        .SCF_LNG_TST_ALC = Me.TextBoxRelaas.Text
                        .TYD_TST_ALC_1 = Me.UltraMaskedEditTest1.Text
                        .INDI_TST_1_POS = CType(Me.UltraOptionSetUitslagTest1.Value, Boolean)
                        .PLA_TST_ALC_1 = Me.TextBoxLocatieTest1.Text
                        If UltraMaskedEditTest2.Text = "__:__" Or UltraMaskedEditTest2.Text = ":" Then
                            'do nothing ==> geen gegevens van test 2 toevoegen
                        Else
                            .TYD_TST_ALC_2 = Me.UltraMaskedEditTest2.Text
                            .INDI_TST_2_POS = CType(Me.UltraOptionSetUitslagTest2.Value, Boolean)
                            .PLA_TST_ALC_2 = Me.TextBoxLocatieTest2.Text
                        End If
                        .SCF_RGL_NEM = Me.TextBoxMaatregelen.Text
                        .INF_EX_TST_ALC = Me.TextBoxInlichtingen.Text

                    End With

                    '3. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------

                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBYLGRow
                    Dim chronicleID As String = ""

                    For Each drBylg In dsAlcoholtest.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsAlcoholtest.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                    For Each drGridBYLG In dsByl.Tables(0).Rows
                        If (drGridBYLG.RowState <> DataRowState.Deleted) Then
                            'Opsturen van de bijlage naar documentum wanneer dit nog niet is gebeurd.
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                chronicleID = UploadAlcoholtestBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If
                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsAlcoholtest.BBBYLG.NewBBBYLGRow

                            drBylagen.ID_REG = Me._IDRegistratie
                            drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                            If Not drGridBYLG.Item("SCF_BYLG") Is DBNull.Value Then
                                drBylagen.SCF_BYLG = CType(drGridBYLG.Item("SCF_BYLG"), String)
                            Else
                                drBylagen.SCF_BYLG = ""
                            End If
                            If chronicleID <> "" Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                            dsAlcoholtest.BBBYLG.AddBBBYLGRow(drBylagen)

                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsAlcoholtest.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBYLGRow)

                                drBylagen.ID_REG = Me._IDRegistratie
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
                                arrBylg = dsAlcoholtest.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBYLGRow)
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
                    Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest.BBBSTRow

                    For Each drBest In dsAlcoholtest.BBBST.Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsAlcoholtest.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drGridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsAlcoholtest.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._IDRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsAlcoholtest.BBBST.AddBBBSTRow(drBestemmelingen)
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
                Dim ds As New Proxy.BBWService.Mgt.TDSAlcoholtest
                ds.Merge(dsAlcoholtest.GetChanges)

                proxy.RegisterRegistratieAlcoholtest(ds, System.Environment.UserName)

                dsAlcoholtest.AcceptChanges()

                'als het om een nieuwe registratie gaat, worden volgende velden ingevuld
                If Me._IDRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsAlcoholtest.getOpstelDatum)
                    'id instellen zodat er bij het refreshen geen nieuw scherm getoond wordt              
                    Me._IDRegistratie = id_reg
                End If
            End If
            Call Me.bindRegistratie()

            If arrayOfDeletedChronicleID.Count > 0 Then
                For Each aChronicleId As String In arrayOfDeletedChronicleID
                    Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                Next
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - opslaanRegistratie" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Function UploadAlcoholtestBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
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
        If UltraMaskedEditStamnrMelder.Text = "" Then
            errorBool = False
        End If
        If TextBoxRelaas.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditStamnrBelanghebbende.Text = "" Then
            errorBool = False
        End If
        'SIDDIEN - 27 dec 06 - alcoholtesten mogen niet meer zichtbaar zijn.
        'If UltraMaskedEditTest1.Text = "__:__" Or UltraMaskedEditTest1.Text = ":" Then
        '    errorBool = False
        'End If
        ''If UltraOptionSetUitslagTest1.Value Is Nothing Then
        ''errorBool = False
        ''End If
        'If TextBoxLocatieTest1.Text = "" Then
        '    errorBool = False
        'End If
        'If UltraMaskedEditTest2.Text <> "__:__" And UltraMaskedEditTest2.Text <> ":" Then
        '    'If UltraOptionSetUitslagTest2.Value Is Nothing Then
        '    'errorBool = False
        '    'End If
        '    If TextBoxLocatieTest2.Text = "" Then
        '        errorBool = False
        '    End If
        'End If
        If Not UserControlGeneralFunctionsAlcoholtest.checkPersoneelOK Then
            errorBool = False
        End If
        Return errorBool
    End Function
#End Region

#Region "Toon rapport"
    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click

        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie() 'eerst nog eens bewaren alvorens het verslag te tonen
                Me.setStatus("Het registratieverslag werd succesvol opgeslagen")

                Me.showReport()
            Else
                'boodschap weergeven
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

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

            If Me._IDRegistratie = -1 Then
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
                            f_rap.InterventieID = Me._IDRegistratie
                            f_rap.Show()
                            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                              "AlcoholtestBewaking", _
                                              "ID_REG", _
                                              CStr(Me._IDRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking")
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
                    f_rap.InterventieID = Me._IDRegistratie
                    f_rap.Show()
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking", "ID_REG", CStr(Me._IDRegistratie), "", "", "", "")

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
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 20/09/2006

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
                            "Opsteller:         " & UserControlGeneralFunctionsAlcoholtest.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingAlcoholtest - ButtonVerzendingBBW_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub ButtonGoedkeuring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 20/09/2006

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
                        "Opsteller:         " & UserControlGeneralFunctionsAlcoholtest.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingAlcoholtest - ButtonGoedkeuring_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsAlcoholtest.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking: " & TextBoxGoedkeuring.Text

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Bewaking").WD)
            Me.sendMail(mailTo, _
                        textMail, _
                        "Teruggezonden registratie Bewaking: " & LabelTitel.Text & " " & TextBoxPlaats.Text, _
                        pathsAttachment)

            Me.setStatus("De registratie werd teruggestuurd.")
            ButtonTerugZenden.Enabled = False
            ButtonVerzendingBBW.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - ButtonTerugZenden_Click()" & vbCrLf & _
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
        'Wijzigingen: Nancy Coppens - 19/09/2006 - Nancy Coppens - 20/09/2006

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
            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsAlcoholtest.getDataBestemmelingen.Tables(0).Rows
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
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAlcoholtest.getDataBijlagen.Tables(0).Rows
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
                               "Bewaking" & Year(Now) & "_" & Me._IDRegistratie & ".pdf"
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
                        "Opsteller:         " & UserControlGeneralFunctionsAlcoholtest.getOpsteller & vbCrLf & vbCrLf & _
                         "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String
                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAlcoholtest.getDataBijlagen.Tables(0).Rows
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
                                                   "AlcoholtestBewaking", _
                                                   pathPDFfile, _
                                                   Me._IDRegistratie)
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
                MessageBox.Show("Verslagen i.v.m. alcoholtest worden niet automatisch naar CHIP gestuurd." & vbCrLf &
                                "Indien nodig, gelieve het verslag manueel naar CHIP te verzenden aub.", "Niet automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'naco - sept 2016

                Me.setStatus("Registratieverslag succesvol verzonden naar de bestemmelingen")

            Else
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")

            MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAlcoholtest - ButtonVerzendingBest_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                proxy.CHIPUpdate(Me._IDRegistratie, Me.UltraComboFirma.Value.ToString(), _
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
        proxy.CHIPRegistration(Me._IDRegistratie, Me.cbxVerslagnrCHIP.Checked)

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
                ButtonVerzendingBest.Visible = False
            ElseIf FormManager.Current.BBWVerantwoordelijke Then
                cbxVerslagnrCHIP.Enabled = True
                UltraComboFirma.Visible = True
                UltraComboFirma.Enabled = True
                ButtonNaarCHIP.Visible = True
                TextBoxNaarCHIP.ReadOnly = False
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
                ButtonMailIKP.Visible = True
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or FormManager.Current.Chip Then
                    UltraButtonOverzicht.Enabled = False
                    ButtonNaarCHIP.Enabled = False
                    ButtonMailIKP.Visible = True
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
                GroupBoxBetrokkenen.Enabled = False
                GroupBoxOverige.Enabled = False
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
        If UltraDateTimeEditorVerzending.Value Is Nothing Then
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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAlcoholtest.getDataBijlagen.Tables(0).Rows

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
            '    UserControlGeneralFunctionsAlcoholtest.getDataBijlagen.Tables(0).Rows

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
                "AlcoholtestBewaking",
                pathPDFfile,
                Me._IDRegistratie)
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
            proxy.UpdateIKPSendMail(Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute, _IDRegistratie)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                             "Form: FormBewakingAanrijding - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
