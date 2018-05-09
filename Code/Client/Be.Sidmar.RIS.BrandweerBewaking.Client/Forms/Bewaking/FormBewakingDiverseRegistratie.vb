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

Public Class FormBewakingDiverseRegistratie
    Inherits System.Windows.Forms.Form

#Region "Variabelen"
    Protected _idRegistratie As Integer = -1
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
    Friend WithEvents _dataFirmaHRM As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmaHRM
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonInfoChip As System.Windows.Forms.Button
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
#End Region

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        _idRegistratie = IdReg


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
    Friend WithEvents TextBoxPlaats As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaats As System.Windows.Forms.Label
    Friend WithEvents LabelUur As System.Windows.Forms.Label
    Friend WithEvents LabelDatum As System.Windows.Forms.Label
    Friend WithEvents TextBoxVerslagnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerslagnr As System.Windows.Forms.Label
    Friend WithEvents LabelTitel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxHoofding As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents LabelFirma As System.Windows.Forms.Label
    Friend WithEvents LabelAndereFirmas As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesFirma As System.Windows.Forms.Button
    Friend WithEvents TextBoxAndereFirmas As System.Windows.Forms.TextBox
    Friend WithEvents LabelBTWnr As System.Windows.Forms.Label
    Friend WithEvents TextBoxBTWnr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxInformatie As System.Windows.Forms.GroupBox
    Friend WithEvents LabelKorteOmschrijving As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOmschrijving As System.Windows.Forms.TextBox
    Friend WithEvents LabelRelaas As System.Windows.Forms.Label
    Friend WithEvents TextBoxRelaas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents LabelVerzekering As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesVerzekering As System.Windows.Forms.Button
    Friend WithEvents LabelPolisnummer As System.Windows.Forms.Label
    Friend WithEvents TextBoxPolisnummer As System.Windows.Forms.TextBox
    Friend WithEvents UserControlGeneralFunctionsDivRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents _dataRegDivRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegDivRegistratie
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents GroupBoxDiverseRegistratie As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents LabelFirmaId As System.Windows.Forms.Label
    Friend WithEvents LabelVerzFirmaId As System.Windows.Forms.Label
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents LabelFirmaNaam As System.Windows.Forms.Label
    Friend WithEvents LabelFirmaAdres As System.Windows.Forms.Label
    Friend WithEvents LabelVerzekeringsNaam As System.Windows.Forms.Label
    Friend WithEvents LabelVerzekeringsAdres As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingDiverseRegistratie))
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
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.TextBoxPlaats = New System.Windows.Forms.TextBox()
        Me.LabelPlaats = New System.Windows.Forms.Label()
        Me.LabelUur = New System.Windows.Forms.Label()
        Me.LabelDatum = New System.Windows.Forms.Label()
        Me.TextBoxVerslagnummer = New System.Windows.Forms.TextBox()
        Me.LabelVerslagnr = New System.Windows.Forms.Label()
        Me.LabelTitel = New System.Windows.Forms.Label()
        Me.GroupBoxHoofding = New System.Windows.Forms.GroupBox()
        Me.TextBoxKorteOms = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelVolgnr = New System.Windows.Forms.Label()
        Me.UltraMaskedEditUur = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me.LabelFirmaAdres = New System.Windows.Forms.Label()
        Me.LabelFirmaNaam = New System.Windows.Forms.Label()
        Me.LabelFirmaId = New System.Windows.Forms.Label()
        Me.TextBoxBTWnr = New System.Windows.Forms.TextBox()
        Me.LabelBTWnr = New System.Windows.Forms.Label()
        Me.TextBoxAndereFirmas = New System.Windows.Forms.TextBox()
        Me.ButtonKiesFirma = New System.Windows.Forms.Button()
        Me.LabelAndereFirmas = New System.Windows.Forms.Label()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.GroupBoxInformatie = New System.Windows.Forms.GroupBox()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.LabelVerzekeringsAdres = New System.Windows.Forms.Label()
        Me.LabelVerzekeringsNaam = New System.Windows.Forms.Label()
        Me.LabelVerzFirmaId = New System.Windows.Forms.Label()
        Me.TextBoxPolisnummer = New System.Windows.Forms.TextBox()
        Me.LabelPolisnummer = New System.Windows.Forms.Label()
        Me.ButtonKiesVerzekering = New System.Windows.Forms.Button()
        Me.LabelVerzekering = New System.Windows.Forms.Label()
        Me.TextBoxRelaas = New System.Windows.Forms.TextBox()
        Me.LabelRelaas = New System.Windows.Forms.Label()
        Me.TextBoxKorteOmschrijving = New System.Windows.Forms.TextBox()
        Me.LabelKorteOmschrijving = New System.Windows.Forms.Label()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsDivRegistratie = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me._dataRegDivRegistratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegDivRegistratie()
        Me.GroupBoxDiverseRegistratie = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxHoofding.SuspendLayout()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        Me.GroupBoxInformatie.SuspendLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOverige.SuspendLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegDivRegistratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDiverseRegistratie.SuspendLayout()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(448, 8)
        Me.UltraDateTimeEditorDatum.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.UltraDateTimeEditorDatum.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 5
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(632, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(360, 20)
        Me.TextBoxPlaats.TabIndex = 9
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(576, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 8
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(408, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 6
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(392, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 4
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(296, 26)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.AutoSize = True
        Me.LabelVerslagnr.Location = New System.Drawing.Point(240, 26)
        Me.LabelVerslagnr.Name = "LabelVerslagnr"
        Me.LabelVerslagnr.Size = New System.Drawing.Size(60, 13)
        Me.LabelVerslagnr.TabIndex = 1
        Me.LabelVerslagnr.Text = "Verslag nr.:"
        Me.LabelVerslagnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitel
        '
        Me.LabelTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitel.Location = New System.Drawing.Point(8, 16)
        Me.LabelTitel.Name = "LabelTitel"
        Me.LabelTitel.Size = New System.Drawing.Size(232, 32)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Diverse Registratie"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(632, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(360, 20)
        Me.TextBoxKorteOms.TabIndex = 1009
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1010
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(176, 48)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(40, 16)
        Me.LabelVolgnr.TabIndex = 3
        Me.LabelVolgnr.Visible = False
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(448, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.NonAutoSizeHeight = 20
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 7
        Me.UltraMaskedEditUur.Text = ":"
        Me.UltraMaskedEditUur.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelFirmaAdres)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelFirmaNaam)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelFirmaId)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.TextBoxBTWnr)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelBTWnr)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.TextBoxAndereFirmas)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ButtonKiesFirma)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelAndereFirmas)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelFirma)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 56)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(1008, 88)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 1
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Algemene gegevens"
        '
        'LabelFirmaAdres
        '
        Me.LabelFirmaAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaAdres.Location = New System.Drawing.Point(120, 40)
        Me.LabelFirmaAdres.Name = "LabelFirmaAdres"
        Me.LabelFirmaAdres.Size = New System.Drawing.Size(384, 20)
        Me.LabelFirmaAdres.TabIndex = 3
        Me.LabelFirmaAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirmaNaam
        '
        Me.LabelFirmaNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaNaam.Location = New System.Drawing.Point(120, 16)
        Me.LabelFirmaNaam.Name = "LabelFirmaNaam"
        Me.LabelFirmaNaam.Size = New System.Drawing.Size(272, 20)
        Me.LabelFirmaNaam.TabIndex = 2
        Me.LabelFirmaNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirmaId
        '
        Me.LabelFirmaId.Location = New System.Drawing.Point(104, 16)
        Me.LabelFirmaId.Name = "LabelFirmaId"
        Me.LabelFirmaId.Size = New System.Drawing.Size(8, 23)
        Me.LabelFirmaId.TabIndex = 1
        Me.LabelFirmaId.Visible = False
        '
        'TextBoxBTWnr
        '
        Me.TextBoxBTWnr.Location = New System.Drawing.Point(120, 64)
        Me.TextBoxBTWnr.MaxLength = 20
        Me.TextBoxBTWnr.Name = "TextBoxBTWnr"
        Me.TextBoxBTWnr.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxBTWnr.TabIndex = 6
        '
        'LabelBTWnr
        '
        Me.LabelBTWnr.Location = New System.Drawing.Point(16, 64)
        Me.LabelBTWnr.Name = "LabelBTWnr"
        Me.LabelBTWnr.Size = New System.Drawing.Size(56, 16)
        Me.LabelBTWnr.TabIndex = 5
        Me.LabelBTWnr.Text = "BTW nr.:"
        Me.LabelBTWnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxAndereFirmas
        '
        Me.TextBoxAndereFirmas.Location = New System.Drawing.Point(616, 16)
        Me.TextBoxAndereFirmas.Multiline = True
        Me.TextBoxAndereFirmas.Name = "TextBoxAndereFirmas"
        Me.TextBoxAndereFirmas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAndereFirmas.Size = New System.Drawing.Size(384, 64)
        Me.TextBoxAndereFirmas.TabIndex = 8
        '
        'ButtonKiesFirma
        '
        Me.ButtonKiesFirma.Location = New System.Drawing.Point(400, 16)
        Me.ButtonKiesFirma.Name = "ButtonKiesFirma"
        Me.ButtonKiesFirma.Size = New System.Drawing.Size(104, 20)
        Me.ButtonKiesFirma.TabIndex = 4
        Me.ButtonKiesFirma.Text = "Kies Firma"
        '
        'LabelAndereFirmas
        '
        Me.LabelAndereFirmas.Location = New System.Drawing.Point(520, 16)
        Me.LabelAndereFirmas.Name = "LabelAndereFirmas"
        Me.LabelAndereFirmas.Size = New System.Drawing.Size(128, 23)
        Me.LabelAndereFirmas.TabIndex = 7
        Me.LabelAndereFirmas.Text = "Andere Firma's:"
        Me.LabelAndereFirmas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirma
        '
        Me.LabelFirma.Location = New System.Drawing.Point(16, 16)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(72, 23)
        Me.LabelFirma.TabIndex = 0
        Me.LabelFirma.Text = "Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxInformatie
        '
        Me.GroupBoxInformatie.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelVerzekeringsAdres)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelVerzekeringsNaam)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelVerzFirmaId)
        Me.GroupBoxInformatie.Controls.Add(Me.TextBoxPolisnummer)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelPolisnummer)
        Me.GroupBoxInformatie.Controls.Add(Me.ButtonKiesVerzekering)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelVerzekering)
        Me.GroupBoxInformatie.Controls.Add(Me.TextBoxRelaas)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelRelaas)
        Me.GroupBoxInformatie.Controls.Add(Me.TextBoxKorteOmschrijving)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelKorteOmschrijving)
        Me.GroupBoxInformatie.Location = New System.Drawing.Point(0, 144)
        Me.GroupBoxInformatie.Name = "GroupBoxInformatie"
        Me.GroupBoxInformatie.Size = New System.Drawing.Size(1008, 256)
        Me.GroupBoxInformatie.TabIndex = 2
        Me.GroupBoxInformatie.TabStop = False
        Me.GroupBoxInformatie.Text = "Informatie"
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
        UltraGridColumn2.Width = 125
        UltraGridColumn3.Header.Caption = "Afkorting"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 55
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
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(120, 208)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 15
        Me.UltraComboAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAfdelingen.ValueMember = "ID_AFD"
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(36, 208)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(68, 16)
        Me.LabelAfdeling.TabIndex = 14
        Me.LabelAfdeling.Text = "Afdeling:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerzekeringsAdres
        '
        Me.LabelVerzekeringsAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelVerzekeringsAdres.Location = New System.Drawing.Point(320, 232)
        Me.LabelVerzekeringsAdres.Name = "LabelVerzekeringsAdres"
        Me.LabelVerzekeringsAdres.Size = New System.Drawing.Size(384, 20)
        Me.LabelVerzekeringsAdres.TabIndex = 6
        Me.LabelVerzekeringsAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerzekeringsNaam
        '
        Me.LabelVerzekeringsNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelVerzekeringsNaam.Location = New System.Drawing.Point(320, 208)
        Me.LabelVerzekeringsNaam.Name = "LabelVerzekeringsNaam"
        Me.LabelVerzekeringsNaam.Size = New System.Drawing.Size(272, 20)
        Me.LabelVerzekeringsNaam.TabIndex = 5
        Me.LabelVerzekeringsNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerzFirmaId
        '
        Me.LabelVerzFirmaId.Location = New System.Drawing.Point(104, 208)
        Me.LabelVerzFirmaId.Name = "LabelVerzFirmaId"
        Me.LabelVerzFirmaId.Size = New System.Drawing.Size(8, 23)
        Me.LabelVerzFirmaId.TabIndex = 8
        Me.LabelVerzFirmaId.Visible = False
        '
        'TextBoxPolisnummer
        '
        Me.TextBoxPolisnummer.Location = New System.Drawing.Point(816, 208)
        Me.TextBoxPolisnummer.MaxLength = 30
        Me.TextBoxPolisnummer.Name = "TextBoxPolisnummer"
        Me.TextBoxPolisnummer.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPolisnummer.TabIndex = 10
        '
        'LabelPolisnummer
        '
        Me.LabelPolisnummer.Location = New System.Drawing.Point(720, 208)
        Me.LabelPolisnummer.Name = "LabelPolisnummer"
        Me.LabelPolisnummer.Size = New System.Drawing.Size(112, 23)
        Me.LabelPolisnummer.TabIndex = 9
        Me.LabelPolisnummer.Text = "Polisnummer:"
        Me.LabelPolisnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesVerzekering
        '
        Me.ButtonKiesVerzekering.Location = New System.Drawing.Point(600, 208)
        Me.ButtonKiesVerzekering.Name = "ButtonKiesVerzekering"
        Me.ButtonKiesVerzekering.Size = New System.Drawing.Size(104, 20)
        Me.ButtonKiesVerzekering.TabIndex = 7
        Me.ButtonKiesVerzekering.Text = "Kies Verzekering"
        '
        'LabelVerzekering
        '
        Me.LabelVerzekering.Location = New System.Drawing.Point(216, 208)
        Me.LabelVerzekering.Name = "LabelVerzekering"
        Me.LabelVerzekering.Size = New System.Drawing.Size(88, 23)
        Me.LabelVerzekering.TabIndex = 4
        Me.LabelVerzekering.Text = "Verzekering:"
        Me.LabelVerzekering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxRelaas
        '
        Me.TextBoxRelaas.Location = New System.Drawing.Point(120, 88)
        Me.TextBoxRelaas.Multiline = True
        Me.TextBoxRelaas.Name = "TextBoxRelaas"
        Me.TextBoxRelaas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRelaas.Size = New System.Drawing.Size(880, 112)
        Me.TextBoxRelaas.TabIndex = 3
        '
        'LabelRelaas
        '
        Me.LabelRelaas.Location = New System.Drawing.Point(16, 88)
        Me.LabelRelaas.Name = "LabelRelaas"
        Me.LabelRelaas.Size = New System.Drawing.Size(120, 23)
        Me.LabelRelaas.TabIndex = 2
        Me.LabelRelaas.Text = "Relaas der feiten:"
        Me.LabelRelaas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxKorteOmschrijving
        '
        Me.TextBoxKorteOmschrijving.Location = New System.Drawing.Point(120, 16)
        Me.TextBoxKorteOmschrijving.Multiline = True
        Me.TextBoxKorteOmschrijving.Name = "TextBoxKorteOmschrijving"
        Me.TextBoxKorteOmschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxKorteOmschrijving.Size = New System.Drawing.Size(880, 72)
        Me.TextBoxKorteOmschrijving.TabIndex = 1
        '
        'LabelKorteOmschrijving
        '
        Me.LabelKorteOmschrijving.Location = New System.Drawing.Point(16, 16)
        Me.LabelKorteOmschrijving.Name = "LabelKorteOmschrijving"
        Me.LabelKorteOmschrijving.Size = New System.Drawing.Size(72, 23)
        Me.LabelKorteOmschrijving.TabIndex = 0
        Me.LabelKorteOmschrijving.Text = "Betreft:"
        Me.LabelKorteOmschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsDivRegistratie)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 401)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 164)
        Me.GroupBoxOverige.TabIndex = 3
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsDivRegistratie
        '
        Me.UserControlGeneralFunctionsDivRegistratie.AutoSize = True
        Me.UserControlGeneralFunctionsDivRegistratie.DatumOpstelling = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsDivRegistratie.GetReportContractant = False
        Me.UserControlGeneralFunctionsDivRegistratie.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsDivRegistratie.Name = "UserControlGeneralFunctionsDivRegistratie"
        Me.UserControlGeneralFunctionsDivRegistratie.Opsteller = 0
        Me.UserControlGeneralFunctionsDivRegistratie.Size = New System.Drawing.Size(512, 142)
        Me.UserControlGeneralFunctionsDivRegistratie.TabIndex = 0
        Me.UserControlGeneralFunctionsDivRegistratie.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataRegDivRegistratie
        '
        Me._dataRegDivRegistratie.DataSetName = "TDSRegDivRegistratie"
        Me._dataRegDivRegistratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegDivRegistratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxDiverseRegistratie
        '
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxDiverseRegistratie.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxDiverseRegistratie.Location = New System.Drawing.Point(0, 571)
        Me.GroupBoxDiverseRegistratie.Name = "GroupBoxDiverseRegistratie"
        Me.GroupBoxDiverseRegistratie.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxDiverseRegistratie.TabIndex = 5
        Me.GroupBoxDiverseRegistratie.TabStop = False
        Me.GroupBoxDiverseRegistratie.Text = "Diverse Registratie"
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
        Me._statusBar.Location = New System.Drawing.Point(0, 620)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1002
        Me._statusBar.User = ""
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 401)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 218)
        Me.GroupBoxVerzending.TabIndex = 1005
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonInfoChip
        '
        Me.ButtonInfoChip.Image = CType(resources.GetObject("ButtonInfoChip.Image"), System.Drawing.Image)
        Me.ButtonInfoChip.Location = New System.Drawing.Point(250, 101)
        Me.ButtonInfoChip.Name = "ButtonInfoChip"
        Me.ButtonInfoChip.Size = New System.Drawing.Size(32, 21)
        Me.ButtonInfoChip.TabIndex = 1007
        Me.ToolTip1.SetToolTip(Me.ButtonInfoChip, "info over SAP firma en contactpersoon")
        Me.ButtonInfoChip.UseVisualStyleBackColor = True
        '
        'LabelBevestigdDoorLeverancier
        '
        Me.LabelBevestigdDoorLeverancier.AutoSize = True
        Me.LabelBevestigdDoorLeverancier.ForeColor = System.Drawing.Color.Red
        Me.LabelBevestigdDoorLeverancier.Location = New System.Drawing.Point(8, 194)
        Me.LabelBevestigdDoorLeverancier.Name = "LabelBevestigdDoorLeverancier"
        Me.LabelBevestigdDoorLeverancier.Size = New System.Drawing.Size(123, 13)
        Me.LabelBevestigdDoorLeverancier.TabIndex = 1004
        Me.LabelBevestigdDoorLeverancier.Text = "Gelezen. dr Leverancier:"
        Me.LabelBevestigdDoorLeverancier.Visible = False
        '
        'UltraDateTimeEditorBevestigdDoorLeverancier
        '
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.DateTime = New Date(2011, 3, 3, 0, 0, 0, 0)
        Me.UltraDateTimeEditorBevestigdDoorLeverancier.Location = New System.Drawing.Point(88, 190)
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
        Me.LabelLeverancier.Location = New System.Drawing.Point(196, 194)
        Me.LabelLeverancier.Name = "LabelLeverancier"
        Me.LabelLeverancier.Size = New System.Drawing.Size(59, 13)
        Me.LabelLeverancier.TabIndex = 25
        Me.LabelLeverancier.Text = "Firma SAP:"
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
        Me.ToolTip1.SetToolTip(Me.cbxVerslagnrCHIP, "Is een mogelijk verslag voor CHIP portaal")
        Me.cbxVerslagnrCHIP.UseVisualStyleBackColor = True
        '
        'LabelOpmerkingNaarCHIP
        '
        Me.LabelOpmerkingNaarCHIP.AutoSize = True
        Me.LabelOpmerkingNaarCHIP.Location = New System.Drawing.Point(7, 171)
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
        Me.ToolTip1.SetToolTip(Me.ButtonNaarCHIP, "Toon op portaal aan leverancier")
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
        Me.UltraDateTimeEditorVerzending.DateTime = New Date(2017, 3, 13, 0, 0, 0, 0)
        Me.UltraDateTimeEditorVerzending.Location = New System.Drawing.Point(132, 9)
        Me.UltraDateTimeEditorVerzending.Name = "UltraDateTimeEditorVerzending"
        Me.UltraDateTimeEditorVerzending.ReadOnly = True
        Me.UltraDateTimeEditorVerzending.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorVerzending.TabIndex = 1
        Me.UltraDateTimeEditorVerzending.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDateTimeEditorVerzending.Value = New Date(2017, 3, 13, 0, 0, 0, 0)
        '
        'ButtonVerzendingBest
        '
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(288, 101)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(184, 21)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen en CHIP"
        Me.ToolTip1.SetToolTip(Me.ButtonVerzendingBest, "Naar bestemmelingen en automatisch nr CHIP (indien firma SAP gekend)")
        '
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(288, 56)
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
        'FormBewakingDiverseRegistratie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 642)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxDiverseRegistratie)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxInformatie)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Name = "FormBewakingDiverseRegistratie"
        Me.Text = "Diverse Registratie"
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        Me.GroupBoxInformatie.ResumeLayout(False)
        Me.GroupBoxInformatie.PerformLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegDivRegistratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDiverseRegistratie.ResumeLayout(False)
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
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

#Region "Properties"
    Protected Function isNewRecord() As Boolean
        If Me._idRegistratie = -1 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Load"
    Private Sub FormBewakingDivRegistratie_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Me.DesignMode = True Then
                Return
            End If
            initializeMailInfo()

            'Add any initialization after the InitializeComponent() call
            bindAndSetBEWPersoneel()
            bindDdlAfdelingen()

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

            'voor usercontrolDivRegistratie
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsDivRegistratie.DatumOpstelling = Now
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

            Me.UserControlGeneralFunctionsDivRegistratie.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

            SetGUI()

            Me.MdiParent.Activate()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Protected Overridable Sub SetGUI()

    End Sub

#End Region

#Region "Binds"

    Private Sub bindRegistratie()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            _dataRegDivRegistratie.Clear()
            Me._dataRegDivRegistratie.Merge(Me._controller.GetRegDivRegistratie(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegDivRegistratie.BBBEWREGRow
            dr = Me._dataRegDivRegistratie.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsDivRegistratie.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsDivRegistratie.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsDivRegistratie.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsDivRegistratie.SetVeraData(dr.VeraReference.ToString,
                                                                      dr.VeraLink.ToString)
            End If

            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsDivRegistratie.GetReportContractant = dr.VerslagContractantYN
            End If

            'Diverse Registratiegegevens opvullen
            Dim drDivR As TDSRegDivRegistratie.BBREGVSHRow
            drDivR = CType(Me._dataRegDivRegistratie.BBREGVSH.Rows.Item(0), TDSRegDivRegistratie.BBREGVSHRow)

            If Not drDivR.IsID_FRMNull Then
                LabelFirmaId.Text = CStr(drDivR.ID_FRM)
            End If
            If Not drDivR.IsNM_FRMNull Then
                LabelFirmaNaam.Text = drDivR.NM_FRM
            End If
            If Not drDivR.IsSTRA_FRMNull Then
                LabelFirmaAdres.Text = drDivR.STRA_FRM
            End If
            If Not drDivR.IsPO_COD_PLA_FRMNull Then
                LabelFirmaAdres.Text &= " , " & drDivR.PO_COD_PLA_FRM
            End If
            If Not drDivR.IsPLA_FRMNull Then
                LabelFirmaAdres.Text &= " " & drDivR.PLA_FRM
            End If

            If Not drDivR.IsNR_BTWNull Then
                TextBoxBTWnr.Text = drDivR.NR_BTW
            End If

            If Not drDivR.IsSCF_FRM_BTRK_ALTNull Then
                TextBoxAndereFirmas.Text = drDivR.SCF_FRM_BTRK_ALT
            End If
            If Not drDivR.IsSCF_KRT_REG_VSHNull Then
                TextBoxKorteOmschrijving.Text = drDivR.SCF_KRT_REG_VSH
            End If
            If Not drDivR.IsSCF_LNG_REG_VSHNull Then
                TextBoxRelaas.Text = drDivR.SCF_LNG_REG_VSH
            End If

            If Not drDivR.IsID_FRM_VZKNull Then
                LabelVerzFirmaId.Text = CStr(drDivR.ID_FRM_VZK)
            End If
            If Not drDivR.IsNM_FRM_VZKNull Then
                LabelVerzekeringsNaam.Text = drDivR.NM_FRM_VZK
            End If
            If Not drDivR.IsAD_FRM_VZKNull Then
                LabelVerzekeringsAdres.Text = drDivR.AD_FRM_VZK
            ElseIf Not drDivR.IsPLA_FRM_VZKNull Then
                LabelVerzekeringsAdres.Text &= drDivR.PLA_FRM_VZK
            End If
            If Not drDivR.IsPLA_FRM_VZKNull Then
                LabelVerzekeringsAdres.Text = drDivR.PLA_FRM_VZK
            End If

            If Not drDivR.IsNR_POLISNull Then
                TextBoxPolisnummer.Text = drDivR.NR_POLIS
            End If

            If Not drDivR.IsID_AFDNull Then
                UltraComboAfdelingen.Value = drDivR.ID_AFD
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

            Me.UserControlGeneralFunctionsDivRegistratie.setBijlageData(Me._dataRegDivRegistratie.BBBYLG)
            Me.UserControlGeneralFunctionsDivRegistratie.setBestemmelingenData(Me._dataRegDivRegistratie.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerDiverseRegistratie - bindRegistratie()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindAndSetBEWPersoneel()
        _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

        If _idRegistratie = -1 Then 'nieuwe registratie - naco 08/02/2017
            Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneelActief())
        Else
            Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneel())
        End If

        Me.UserControlGeneralFunctionsDivRegistratie.setPersoneelData(_dataBEWPersoneel)
    End Sub

    Private Sub bindBijlagen()
        Me.UserControlGeneralFunctionsDivRegistratie.setBijlageData(_dataRegDivRegistratie.BBBYLG)
    End Sub

    Protected Overridable Sub bindBestemmelingen()
        Me.UserControlGeneralFunctionsDivRegistratie.setBestemmelingenData(_dataRegDivRegistratie.BBBST)
    End Sub

    Private Sub bindDdlAfdelingen()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Button and Optionset Eventhandlers"

    Private Sub ButtonKiesFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesFirma.Click
        Try
            Using f_firma As FormBewakingFirmas = New FormBewakingFirmas

                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    LabelFirmaId.Text = CStr(f_firma.IdFirma)
                    LabelFirmaNaam.Text = f_firma.NaamFirma
                    LabelFirmaAdres.Text = f_firma.AdresFirma & ", " & f_firma.PostNrFirma & " " & f_firma.GemeenteFirma
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesVerzekering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesVerzekering.Click
        Try
            Dim f_verzFirma As FormBewakingVerzekeringsfirma = New FormBewakingVerzekeringsfirma

            f_verzFirma.ShowDialog()

            If Not f_verzFirma.Canceled Then
                Dim firmaVerz As TDSVerzFirmas.BBVZKFRMRow = f_verzFirma.Firma

                LabelVerzFirmaId.Text = CStr(firmaVerz.ID_FRM_VZK)
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
        Return UltraComboAfdelingen.Text
    End Function

    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsDivRegistratie.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
        UserControlGeneralFunctionsDivRegistratie.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub
#End Region

    Protected Overridable Sub setLabelsVerplicht()
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelFirma.Text &= " *"
        LabelKorteOmschrijving.Text &= " *"
        LabelRelaas.Text &= " *"
    End Sub

#Region "User Control"
    Private Sub UserControlGeneralFunctionsDivRegistratie_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsDivRegistratie.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, GetAfdeling())

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsDivRegistratie.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsDivRegistratie.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
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

#Region "Opslaan"
    Protected Overridable Function getNaamVerslag() As String
        Return "De Diverse Registratie"
    End Function

    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        'Doel: nieuwe diverse registratie toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 04/05/2006
        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus(getNaamVerslag() & " werd succesvol opgeslagen")
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
        Cursor.Current = Cursors.WaitCursor
        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

        Dim dsDivRegistratie As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie
        Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBEWREGRow
        Dim drDivRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBREGVSHRow
        Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBYLGRow
        Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try
            dsDivRegistratie.BBBST.DataSet.Clear()
            dsDivRegistratie.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsDivRegistratie.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsDivRegistratie.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd
            If (UserControlGeneralFunctionsDivRegistratie.CheckBestemmelingen(dsBest) = True) Then
                _controller = New ControllerGetData

                If Me._idRegistratie = -1 Then 'nieuwe diverse registratie

                    drRegistratie = dsDivRegistratie.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsDivRegistratie.Opsteller
                        .ID_TY_REG = getTyReg()
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsDivRegistratie.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = Me.UserControlGeneralFunctionsDivRegistratie.GetVeraLink
                        .VeraReference = Me.UserControlGeneralFunctionsDivRegistratie.GetVeraReference
                        .VerslagContractantYN = Me.UserControlGeneralFunctionsDivRegistratie.GetReportContractant
                    End With
                    dsDivRegistratie.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Diverse Registratie
                    '--------------
                    drDivRegistratie = dsDivRegistratie.BBREGVSH.NewBBREGVSHRow
                    With drDivRegistratie
                        .ID_REG = id_reg
                        .ID_FRM = CInt(LabelFirmaId.Text)
                        If Not LabelVerzFirmaId.Text = "" Then
                            .ID_FRM_VZK = CInt(LabelVerzFirmaId.Text)
                        End If
                        If Not TextBoxAndereFirmas.Text = "" Then
                            .SCF_FRM_BTRK_ALT = TextBoxAndereFirmas.Text
                        End If
                        If Not TextBoxBTWnr.Text = "" Then
                            .NR_BTW = TextBoxBTWnr.Text
                        End If
                        .SCF_KRT_REG_VSH = TextBoxKorteOmschrijving.Text
                        .SCF_LNG_REG_VSH = TextBoxRelaas.Text
                        If Not TextBoxPolisnummer.Text = "" Then
                            .NR_POLIS = TextBoxPolisnummer.Text
                        End If
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If
                    End With
                    dsDivRegistratie.BBREGVSH.AddBBREGVSHRow(drDivRegistratie)

                    '3. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    Dim drByl As DataRow
                    Dim chronicleID As String
                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsDivRegistratie.BBBYLG.NewBBBYLGRow
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
                            chronicleID = UploadDivRegistratieBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If

                        dsDivRegistratie.BBBYLG.AddBBBYLGRow(drBylagen)
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegDivRegistratie.BBBSTRow 'Dien - aug2008 - migratie 2008
                    Dim drBest As DataRow
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsDivRegistratie.BBBST.NewBBBSTRow
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

                        dsDivRegistratie.BBBST.AddBBBSTRow(drBestemmelingen)
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
                Else 'bestaande diverse registratie wijzigen
                    dsDivRegistratie.Merge(Me._controller.GetRegDivRegistratie(Me._idRegistratie))
                    drRegistratie = dsDivRegistratie.BBBEWREG.FindByID_REG(Me._idRegistratie)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsDivRegistratie.Opsteller
                        .ID_TY_REG = getTyReg()
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsDivRegistratie.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = Me.UserControlGeneralFunctionsDivRegistratie.GetVeraLink
                        .VeraReference = Me.UserControlGeneralFunctionsDivRegistratie.GetVeraReference
                        .VerslagContractantYN = Me.UserControlGeneralFunctionsDivRegistratie.GetReportContractant
                    End With

                    '2. Diverse Registratie
                    '--------------
                    drDivRegistratie = CType(dsDivRegistratie.BBREGVSH.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBREGVSHRow)
                    With drDivRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_FRM = CInt(LabelFirmaId.Text)
                        If Not LabelVerzFirmaId.Text = "" Then
                            .ID_FRM_VZK = CInt(LabelVerzFirmaId.Text)
                        End If
                        If Not TextBoxAndereFirmas.Text = "" Then
                            .SCF_FRM_BTRK_ALT = TextBoxAndereFirmas.Text
                        End If
                        If Not TextBoxBTWnr.Text = "" Then
                            .NR_BTW = TextBoxBTWnr.Text
                        End If
                        .SCF_KRT_REG_VSH = TextBoxKorteOmschrijving.Text
                        .SCF_LNG_REG_VSH = TextBoxRelaas.Text
                        If Not TextBoxPolisnummer.Text = "" Then
                            .NR_POLIS = TextBoxPolisnummer.Text
                        End If
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If
                    End With

                    '3. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBYLGRow

                    For Each drBylg In dsDivRegistratie.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsDivRegistratie.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                            'Opsturen van de bijlage naar documentum wanneer dit nog niet is gebeurd.
                            If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                chronicleID = UploadDivRegistratieBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If

                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsDivRegistratie.BBBYLG.NewBBBYLGRow

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

                            dsDivRegistratie.BBBYLG.AddBBBYLGRow(drBylagen)
                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsDivRegistratie.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBYLGRow)

                                drBylagen.ID_REG = Me._idRegistratie
                                drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                                If Not drBylg.Item("SCF_BYLG") Is DBNull.Value Then
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
                                arrBylg = dsDivRegistratie.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBYLGRow)
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
                    Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie.BBBSTRow

                    For Each drBest In dsDivRegistratie.BBBST.Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsDivRegistratie.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drGridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsDivRegistratie.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._idRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsDivRegistratie.BBBST.AddBBBSTRow(drBestemmelingen)
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
                Dim ds As New Proxy.BBWService.Mgt.TDSDivRegistratie
                ds.Merge(dsDivRegistratie.GetChanges)

                proxy.RegisterRegistratieDivRegistratie(ds, System.Environment.UserName)
                dsDivRegistratie.AcceptChanges()

                'als het om een nieuwe diverse registratie gaat, worden volgende velden ingevuld
                If Me._idRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsDivRegistratie.getOpstelDatum)
                    'id instellen zodat er bij het refreshen geen nieuw scherm getoond wordt              
                    Me._idRegistratie = id_reg
                End If
                Call Me.bindRegistratie()

                If arrayOfDeletedChronicleID.Count > 0 Then
                    For Each aChronicleId As String In arrayOfDeletedChronicleID
                        Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                    Next
                End If

            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerDiverseRegistratie - ButtonOpslaan_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Protected Overridable Function getTyReg() As Integer
        Return 7
    End Function

    Private Function UploadDivRegistratieBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
        'Doel:   Uploaden van de bijlage van een aanrijdingsverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(UltraDateTimeEditorDatum.DateTime) & "/" & volgnr & " - " & LabelTitel.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BEWAKING", "FolderPathDocumentum").WD()

        Return BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName, documentumFolderPath)

    End Function
    Protected Overridable Function controleVeldenOK() As Boolean
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
        If LabelFirmaId.Text = "" Then
            errorBool = False
        End If
        If TextBoxKorteOmschrijving.Text = "" Then
            errorBool = False
        End If
        If TextBoxRelaas.Text = "" Then
            errorBool = False
        End If
        If Not UserControlGeneralFunctionsDivRegistratie.checkPersoneelOK Then
            errorBool = False
        End If
        Return errorBool
    End Function

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub

    Private Sub FormBewakingDiverseRegistratie_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region

#Region "Rapport afdrukken"
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
                                              "DiverseBewaking", _
                                              "ID_REG", _
                                              CStr(Me._idRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "DiverseBewaking")
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
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "DiverseBewaking", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

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
                            "Opsteller:         " & UserControlGeneralFunctionsDivRegistratie.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiverseRegistratie - ButtonVerzendingBBW_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsDivRegistratie.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiverseRegistratie - ButtonGoedkeuring_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsDivRegistratie.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiverseRegistratie - ButtonTerugZenden_Click()" & vbCrLf & _
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
        Dim f_rap As New FormRapportenPreview
        Dim pathsAttachment As New ArrayList
        Dim specBest As New ArrayList
        Dim textMailURL As String = ""
        Dim specPathsAttachment As New ArrayList
        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim dsSpecBest As New TDSBBBSTBY
        Dim drSpecBest As TDSBBBSTBY.BBBSTBYRow
        Dim IsSpecialBest As Boolean = False
        Dim IsNormalBest As Boolean = False

        Try
            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsDivRegistratie.getDataBestemmelingen.Tables(0).Rows
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
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDivRegistratie.getDataBijlagen.Tables(0).Rows
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
                        "Opsteller:         " & UserControlGeneralFunctionsDivRegistratie.getOpsteller 'naco - sept 2016

                textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsDivRegistratie.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String

                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDivRegistratie.getDataBijlagen.Tables(0).Rows
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

                '2. naar CHIP automatisch - sept 2016 - naco
                '-------------------------------------------
                Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(CInt(_dataRegDivRegistratie.BBREGVSH.Rows(0).Item("ID_FRM").ToString))
                If intIDFirmSAP > 0 And intIDFirmSAP <> 616206 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP) - 1001674 = oude ID_FRM BBW
                    cbxVerslagnrCHIP.Checked = True
                    UltraComboFirma.Value = intIDFirmSAP
                    UltraDateTimeEditorNaarCHIP.DateTime = Now

                    Dim strMailToFirm As String
                    'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                    strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP) 'vanaf 13/03/2017 - naco/borb

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
                                                           "AM Gent - Verslag bewaking (diverse) - " & LabelFirmaNaam.Text & " (" & intIDFirmSAP.ToString & ") - " & UltraDateTimeEditorDatum.Text,
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
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")

            MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingDiverseRegistratie - ButtonVerzendingBest_Click()" & vbCrLf & _
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
                UltraComboFirma.Enabled = True
                ButtonNaarCHIP.Enabled = True
                TextBoxNaarCHIP.ReadOnly = False
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
                ButtonMailIKP.Visible = True
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or
                    FormManager.Current.Chip Then
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
                GroupBoxInformatie.Enabled = False
                GroupBoxOverige.Enabled = False
                GroupBoxInformatie.Enabled = False


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

    Private Sub UltraComboAfdelingen_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraComboAfdelingen.ValueChanged
        setBestemmelingen(CInt(UltraComboAfdelingen.Value))
    End Sub

    Protected Overridable Sub setBestemmelingen(ByVal afdeling As Integer)

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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDivRegistratie.getDataBijlagen.Tables(0).Rows

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

            For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In _
                UserControlGeneralFunctionsDivRegistratie.getDataBijlagen.Tables(0).Rows

                ' Voor de externe bestemmelingen worden de bijlagen steeds als attachment opgestuurd.
                If (specBest.Count > 0) Then
                    specPathsAttachment.Add(bijlageRow.PLA_BYLG)
                End If
            Next

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
                "DiverseBewaking",
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
                             "Form: FormBewakingDivereRegistratie - SendMailIKP" & vbCrLf &
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
        Dim intIDFRM_BBW As Integer = CInt(_dataRegDivRegistratie.BBREGVSH.Rows(0).Item("ID_FRM").ToString)

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
