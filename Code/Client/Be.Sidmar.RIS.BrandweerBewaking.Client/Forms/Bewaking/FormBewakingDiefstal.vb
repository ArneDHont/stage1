Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection
Imports System.IO


Imports Microsoft.Office.Interop 'mails versturen voor IKP - naco - 30/11/2012
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class FormBewakingDiefstal
    Inherits System.Windows.Forms.Form

#Region "Constants"
    Private _idRegistratie As Integer = -1
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
    Friend WithEvents GroupBoxPolitie As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPvNummer As System.Windows.Forms.Label
    Friend WithEvents TextBoxPVNummer As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxPolitieGeweest As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPolitieGevraagd As System.Windows.Forms.CheckBox
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
        bindUltraOptionSet()
        bindAndSetBEWPersoneel()
        bindDdlAfdelingen()
        setLabelsVerplicht()
    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()

        _idRegistratie = IdReg

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initializeMailInfo()
        'Add any initialization after the InitializeComponent() call
        bindUltraOptionSet()
        bindAndSetBEWPersoneel()
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
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxRelaas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxInformatie As System.Windows.Forms.GroupBox
    Friend WithEvents LabelBeschrijving As System.Windows.Forms.Label
    Friend WithEvents LabelWaarde As System.Windows.Forms.Label
    Friend WithEvents LabelStaat As System.Windows.Forms.Label
    Friend WithEvents TextBoxBeschrijving As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStaat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxRelaas As System.Windows.Forms.GroupBox
    Friend WithEvents _dataDiefDup As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDiefDup
    Friend WithEvents _dataRegDiefstal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegDiefstal
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UserControlGeneralFunctionsDiefstal As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents GroupBoxDiefstal As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents UltraMaskedEditWaarde As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
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
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxVerzending As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxBenadeelde As System.Windows.Forms.GroupBox
    Friend WithEvents UltraOptionSetBenadeelde As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents PanelFirma As System.Windows.Forms.Panel
    Friend WithEvents LabelFirmaAdres As System.Windows.Forms.Label
    Friend WithEvents LabelNaamBenadeeldeFirma As System.Windows.Forms.Label
    Friend WithEvents LabelFirma As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesFirmas As System.Windows.Forms.Button
    Friend WithEvents TextBoxFirmaId As System.Windows.Forms.TextBox
    Friend WithEvents PanelPersoon As System.Windows.Forms.Panel
    Friend WithEvents LabelBTWnr As System.Windows.Forms.Label
    Friend WithEvents TextBoxBTWnr As System.Windows.Forms.TextBox
    Friend WithEvents LabelNaamBenadeelde As System.Windows.Forms.Label
    Friend WithEvents UltraMaskedEditStamnrBelanghebbende As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ButtonKiesPersoonBenadeelde As System.Windows.Forms.Button
    Friend WithEvents LabelStamnummerBenadeelde As System.Windows.Forms.Label
    Friend WithEvents LabelAdresVaststeller As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
    Friend WithEvents LabelNaamVaststeller As System.Windows.Forms.Label
    Friend WithEvents UltraMaskedEditStamnrVaststeller As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ButtonKiesPersoonVaststeller As System.Windows.Forms.Button
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LabelVoorwerp As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingDiefstal))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me.LabelNaamVaststeller = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrVaststeller = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ButtonKiesPersoonVaststeller = New System.Windows.Forms.Button()
        Me.LabelAdresVaststeller = New System.Windows.Forms.Label()
        Me.TextBoxRelaas = New System.Windows.Forms.TextBox()
        Me.GroupBoxInformatie = New System.Windows.Forms.GroupBox()
        Me.LabelVoorwerp = New System.Windows.Forms.Label()
        Me.UltraMaskedEditWaarde = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxStaat = New System.Windows.Forms.TextBox()
        Me.TextBoxBeschrijving = New System.Windows.Forms.TextBox()
        Me.LabelStaat = New System.Windows.Forms.Label()
        Me.LabelWaarde = New System.Windows.Forms.Label()
        Me.LabelBeschrijving = New System.Windows.Forms.Label()
        Me.GroupBoxRelaas = New System.Windows.Forms.GroupBox()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsDiefstal = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me.GroupBoxDiefstal = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me.GroupBoxVerzending = New System.Windows.Forms.GroupBox()
        Me.ButtonTerugZenden = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.GroupBoxBenadeelde = New System.Windows.Forms.GroupBox()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.UltraOptionSetBenadeelde = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me._dataDiefDup = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDiefDup()
        Me.PanelPersoon = New System.Windows.Forms.Panel()
        Me.LabelBTWnr = New System.Windows.Forms.Label()
        Me.TextBoxBTWnr = New System.Windows.Forms.TextBox()
        Me.LabelNaamBenadeelde = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrBelanghebbende = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ButtonKiesPersoonBenadeelde = New System.Windows.Forms.Button()
        Me.LabelStamnummerBenadeelde = New System.Windows.Forms.Label()
        Me.PanelFirma = New System.Windows.Forms.Panel()
        Me.LabelFirmaAdres = New System.Windows.Forms.Label()
        Me.LabelNaamBenadeeldeFirma = New System.Windows.Forms.Label()
        Me.LabelFirma = New System.Windows.Forms.Label()
        Me.ButtonKiesFirmas = New System.Windows.Forms.Button()
        Me.TextBoxFirmaId = New System.Windows.Forms.TextBox()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me._dataRegDiefstal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegDiefstal()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me.GroupBoxPolitie = New System.Windows.Forms.GroupBox()
        Me.LabelPvNummer = New System.Windows.Forms.Label()
        Me.TextBoxPVNummer = New System.Windows.Forms.TextBox()
        Me.CheckBoxPolitieGeweest = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPolitieGevraagd = New System.Windows.Forms.CheckBox()
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        Me.GroupBoxInformatie.SuspendLayout()
        Me.GroupBoxRelaas.SuspendLayout()
        Me.GroupBoxOverige.SuspendLayout()
        Me.GroupBoxDiefstal.SuspendLayout()
        Me.GroupBoxVerzending.SuspendLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBenadeelde.SuspendLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataDiefDup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPersoon.SuspendLayout()
        Me.PanelFirma.SuspendLayout()
        CType(Me._dataRegDiefstal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPolitie.SuspendLayout()
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
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(560, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(432, 20)
        Me.TextBoxKorteOms.TabIndex = 1007
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1008
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(352, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 6
        Me.UltraMaskedEditUur.Text = ":"
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(352, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 4
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(560, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(432, 20)
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
        Me.LabelUur.Location = New System.Drawing.Point(312, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(40, 21)
        Me.LabelUur.TabIndex = 5
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.Location = New System.Drawing.Point(304, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(48, 21)
        Me.LabelDatum.TabIndex = 3
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(192, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.Location = New System.Drawing.Point(128, 24)
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
        Me.LabelTitel.Size = New System.Drawing.Size(106, 32)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Diefstal"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(120, 24)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 23)
        Me.LabelVolgnr.TabIndex = 9
        Me.LabelVolgnr.Visible = False
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelNaamVaststeller)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraMaskedEditStamnrVaststeller)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ButtonKiesPersoonVaststeller)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelAdresVaststeller)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 56)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(424, 62)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 1
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Vaststeller"
        '
        'LabelNaamVaststeller
        '
        Me.LabelNaamVaststeller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamVaststeller.Location = New System.Drawing.Point(66, 15)
        Me.LabelNaamVaststeller.Name = "LabelNaamVaststeller"
        Me.LabelNaamVaststeller.Size = New System.Drawing.Size(256, 20)
        Me.LabelNaamVaststeller.TabIndex = 7
        Me.LabelNaamVaststeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrVaststeller
        '
        Me.UltraMaskedEditStamnrVaststeller.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrVaststeller.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrVaststeller.Location = New System.Drawing.Point(10, 15)
        Me.UltraMaskedEditStamnrVaststeller.MaxValue = 99999999
        Me.UltraMaskedEditStamnrVaststeller.Name = "UltraMaskedEditStamnrVaststeller"
        Me.UltraMaskedEditStamnrVaststeller.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrVaststeller.TabIndex = 6
        Me.UltraMaskedEditStamnrVaststeller.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ButtonKiesPersoonVaststeller
        '
        Me.ButtonKiesPersoonVaststeller.Location = New System.Drawing.Point(328, 15)
        Me.ButtonKiesPersoonVaststeller.Name = "ButtonKiesPersoonVaststeller"
        Me.ButtonKiesPersoonVaststeller.Size = New System.Drawing.Size(78, 20)
        Me.ButtonKiesPersoonVaststeller.TabIndex = 8
        Me.ButtonKiesPersoonVaststeller.Text = "Kies persoon"
        '
        'LabelAdresVaststeller
        '
        Me.LabelAdresVaststeller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAdresVaststeller.Location = New System.Drawing.Point(10, 38)
        Me.LabelAdresVaststeller.Name = "LabelAdresVaststeller"
        Me.LabelAdresVaststeller.Size = New System.Drawing.Size(398, 20)
        Me.LabelAdresVaststeller.TabIndex = 5
        Me.LabelAdresVaststeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxRelaas
        '
        Me.TextBoxRelaas.Location = New System.Drawing.Point(8, 16)
        Me.TextBoxRelaas.MaxLength = 3000
        Me.TextBoxRelaas.Multiline = True
        Me.TextBoxRelaas.Name = "TextBoxRelaas"
        Me.TextBoxRelaas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRelaas.Size = New System.Drawing.Size(992, 112)
        Me.TextBoxRelaas.TabIndex = 0
        '
        'GroupBoxInformatie
        '
        Me.GroupBoxInformatie.Controls.Add(Me.LabelVoorwerp)
        Me.GroupBoxInformatie.Controls.Add(Me.UltraMaskedEditWaarde)
        Me.GroupBoxInformatie.Controls.Add(Me.TextBoxStaat)
        Me.GroupBoxInformatie.Controls.Add(Me.TextBoxBeschrijving)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelStaat)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelWaarde)
        Me.GroupBoxInformatie.Controls.Add(Me.LabelBeschrijving)
        Me.GroupBoxInformatie.Location = New System.Drawing.Point(0, 184)
        Me.GroupBoxInformatie.Name = "GroupBoxInformatie"
        Me.GroupBoxInformatie.Size = New System.Drawing.Size(1008, 80)
        Me.GroupBoxInformatie.TabIndex = 2
        Me.GroupBoxInformatie.TabStop = False
        Me.GroupBoxInformatie.Text = "Informatie gestolen goed"
        '
        'LabelVoorwerp
        '
        Me.LabelVoorwerp.Location = New System.Drawing.Point(16, 40)
        Me.LabelVoorwerp.Name = "LabelVoorwerp"
        Me.LabelVoorwerp.Size = New System.Drawing.Size(64, 23)
        Me.LabelVoorwerp.TabIndex = 6
        Me.LabelVoorwerp.Text = "(Voorwerp)"
        '
        'UltraMaskedEditWaarde
        '
        Me.UltraMaskedEditWaarde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.UltraMaskedEditWaarde.InputMask = "{currency:6.2}"
        Me.UltraMaskedEditWaarde.Location = New System.Drawing.Point(632, 56)
        Me.UltraMaskedEditWaarde.Name = "UltraMaskedEditWaarde"
        Me.UltraMaskedEditWaarde.Size = New System.Drawing.Size(72, 20)
        Me.UltraMaskedEditWaarde.TabIndex = 5
        Me.UltraMaskedEditWaarde.Text = "€"
        Me.UltraMaskedEditWaarde.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxStaat
        '
        Me.TextBoxStaat.Location = New System.Drawing.Point(632, 16)
        Me.TextBoxStaat.MaxLength = 500
        Me.TextBoxStaat.Multiline = True
        Me.TextBoxStaat.Name = "TextBoxStaat"
        Me.TextBoxStaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxStaat.Size = New System.Drawing.Size(368, 40)
        Me.TextBoxStaat.TabIndex = 3
        '
        'TextBoxBeschrijving
        '
        Me.TextBoxBeschrijving.Location = New System.Drawing.Point(96, 16)
        Me.TextBoxBeschrijving.MaxLength = 500
        Me.TextBoxBeschrijving.Multiline = True
        Me.TextBoxBeschrijving.Name = "TextBoxBeschrijving"
        Me.TextBoxBeschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxBeschrijving.Size = New System.Drawing.Size(456, 56)
        Me.TextBoxBeschrijving.TabIndex = 1
        '
        'LabelStaat
        '
        Me.LabelStaat.Location = New System.Drawing.Point(568, 16)
        Me.LabelStaat.Name = "LabelStaat"
        Me.LabelStaat.Size = New System.Drawing.Size(40, 23)
        Me.LabelStaat.TabIndex = 2
        Me.LabelStaat.Text = "Staat:"
        Me.LabelStaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelWaarde
        '
        Me.LabelWaarde.Location = New System.Drawing.Point(568, 56)
        Me.LabelWaarde.Name = "LabelWaarde"
        Me.LabelWaarde.Size = New System.Drawing.Size(64, 23)
        Me.LabelWaarde.TabIndex = 4
        Me.LabelWaarde.Text = "Waarde:"
        Me.LabelWaarde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBeschrijving
        '
        Me.LabelBeschrijving.Location = New System.Drawing.Point(16, 16)
        Me.LabelBeschrijving.Name = "LabelBeschrijving"
        Me.LabelBeschrijving.Size = New System.Drawing.Size(80, 23)
        Me.LabelBeschrijving.TabIndex = 0
        Me.LabelBeschrijving.Text = "Beschrijving:"
        Me.LabelBeschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxRelaas
        '
        Me.GroupBoxRelaas.Controls.Add(Me.TextBoxRelaas)
        Me.GroupBoxRelaas.Location = New System.Drawing.Point(0, 264)
        Me.GroupBoxRelaas.Name = "GroupBoxRelaas"
        Me.GroupBoxRelaas.Size = New System.Drawing.Size(1008, 136)
        Me.GroupBoxRelaas.TabIndex = 3
        Me.GroupBoxRelaas.TabStop = False
        Me.GroupBoxRelaas.Text = "Relaas der feiten"
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsDiefstal)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 400)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 144)
        Me.GroupBoxOverige.TabIndex = 4
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsDiefstal
        '
        Me.UserControlGeneralFunctionsDiefstal.AutoSize = True
        Me.UserControlGeneralFunctionsDiefstal.DatumOpstelling = New Date(2006, 5, 2, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsDiefstal.GetReportContractant = False
        Me.UserControlGeneralFunctionsDiefstal.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsDiefstal.Name = "UserControlGeneralFunctionsDiefstal"
        Me.UserControlGeneralFunctionsDiefstal.Opsteller = 0
        Me.UserControlGeneralFunctionsDiefstal.Size = New System.Drawing.Size(512, 120)
        Me.UserControlGeneralFunctionsDiefstal.TabIndex = 0
        Me.UserControlGeneralFunctionsDiefstal.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        'GroupBoxDiefstal
        '
        Me.GroupBoxDiefstal.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxDiefstal.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxDiefstal.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxDiefstal.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxDiefstal.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxDiefstal.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxDiefstal.Location = New System.Drawing.Point(0, 544)
        Me.GroupBoxDiefstal.Name = "GroupBoxDiefstal"
        Me.GroupBoxDiefstal.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxDiefstal.TabIndex = 6
        Me.GroupBoxDiefstal.TabStop = False
        Me.GroupBoxDiefstal.Text = "Diefstal"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(307, 25)
        Me.ButtonMailIKP.Name = "ButtonMailIKP"
        Me.ButtonMailIKP.Size = New System.Drawing.Size(111, 23)
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
        Me._statusBar.Location = New System.Drawing.Point(0, 593)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1002
        Me._statusBar.User = ""
        '
        'GroupBoxVerzending
        '
        Me.GroupBoxVerzending.Controls.Add(Me.ButtonTerugZenden)
        Me.GroupBoxVerzending.Controls.Add(Me.Label6)
        Me.GroupBoxVerzending.Controls.Add(Me.Label5)
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 400)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 192)
        Me.GroupBoxVerzending.TabIndex = 1003
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonTerugZenden
        '
        Me.ButtonTerugZenden.Location = New System.Drawing.Point(392, 72)
        Me.ButtonTerugZenden.Name = "ButtonTerugZenden"
        Me.ButtonTerugZenden.Size = New System.Drawing.Size(80, 20)
        Me.ButtonTerugZenden.TabIndex = 19
        Me.ButtonTerugZenden.Text = "Stuur terug"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Opm mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Opm mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Opm mail:"
        '
        'UltraDateTimeEditorBestemmelingen
        '
        Me.UltraDateTimeEditorBestemmelingen.Location = New System.Drawing.Point(200, 128)
        Me.UltraDateTimeEditorBestemmelingen.Name = "UltraDateTimeEditorBestemmelingen"
        Me.UltraDateTimeEditorBestemmelingen.ReadOnly = True
        Me.UltraDateTimeEditorBestemmelingen.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorBestemmelingen.TabIndex = 9
        Me.UltraDateTimeEditorBestemmelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorGoedkeuring
        '
        Me.UltraDateTimeEditorGoedkeuring.Location = New System.Drawing.Point(200, 72)
        Me.UltraDateTimeEditorGoedkeuring.Name = "UltraDateTimeEditorGoedkeuring"
        Me.UltraDateTimeEditorGoedkeuring.ReadOnly = True
        Me.UltraDateTimeEditorGoedkeuring.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorGoedkeuring.TabIndex = 5
        Me.UltraDateTimeEditorGoedkeuring.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorVerzending
        '
        Me.UltraDateTimeEditorVerzending.Location = New System.Drawing.Point(200, 16)
        Me.UltraDateTimeEditorVerzending.Name = "UltraDateTimeEditorVerzending"
        Me.UltraDateTimeEditorVerzending.ReadOnly = True
        Me.UltraDateTimeEditorVerzending.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorVerzending.TabIndex = 1
        Me.UltraDateTimeEditorVerzending.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ButtonVerzendingBest
        '
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(344, 128)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(128, 20)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen"
        '
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(304, 72)
        Me.ButtonGoedkeuring.Name = "ButtonGoedkeuring"
        Me.ButtonGoedkeuring.Size = New System.Drawing.Size(80, 20)
        Me.ButtonGoedkeuring.TabIndex = 7
        Me.ButtonGoedkeuring.Text = "Keur goed"
        '
        'ButtonVerzendingBBW
        '
        Me.ButtonVerzendingBBW.Location = New System.Drawing.Point(344, 16)
        Me.ButtonVerzendingBBW.Name = "ButtonVerzendingBBW"
        Me.ButtonVerzendingBBW.Size = New System.Drawing.Size(128, 20)
        Me.ButtonVerzendingBBW.TabIndex = 3
        Me.ButtonVerzendingBBW.Text = "Naar Postoverste"
        '
        'TextBoxVerzendingBestemmelingen
        '
        Me.TextBoxVerzendingBestemmelingen.Location = New System.Drawing.Point(64, 152)
        Me.TextBoxVerzendingBestemmelingen.MaxLength = 100
        Me.TextBoxVerzendingBestemmelingen.Name = "TextBoxVerzendingBestemmelingen"
        Me.TextBoxVerzendingBestemmelingen.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxVerzendingBestemmelingen.TabIndex = 10
        '
        'TextBoxGoedkeuring
        '
        Me.TextBoxGoedkeuring.Location = New System.Drawing.Point(64, 96)
        Me.TextBoxGoedkeuring.MaxLength = 100
        Me.TextBoxGoedkeuring.Name = "TextBoxGoedkeuring"
        Me.TextBoxGoedkeuring.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxGoedkeuring.TabIndex = 6
        '
        'TextBoxVerzending
        '
        Me.TextBoxVerzending.Location = New System.Drawing.Point(64, 40)
        Me.TextBoxVerzending.MaxLength = 100
        Me.TextBoxVerzending.Name = "TextBoxVerzending"
        Me.TextBoxVerzending.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxVerzending.TabIndex = 2
        '
        'LabelVerzendingBest
        '
        Me.LabelVerzendingBest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerzendingBest.Location = New System.Drawing.Point(8, 128)
        Me.LabelVerzendingBest.Name = "LabelVerzendingBest"
        Me.LabelVerzendingBest.Size = New System.Drawing.Size(192, 16)
        Me.LabelVerzendingBest.TabIndex = 8
        Me.LabelVerzendingBest.Text = "Datum verzending bestemmelingen:"
        '
        'LabelGoedkeuring
        '
        Me.LabelGoedkeuring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoedkeuring.Location = New System.Drawing.Point(8, 72)
        Me.LabelGoedkeuring.Name = "LabelGoedkeuring"
        Me.LabelGoedkeuring.Size = New System.Drawing.Size(160, 16)
        Me.LabelGoedkeuring.TabIndex = 4
        Me.LabelGoedkeuring.Text = "Datum goedkeuring:"
        '
        'LabelVerzending
        '
        Me.LabelVerzending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerzending.Location = New System.Drawing.Point(8, 16)
        Me.LabelVerzending.Name = "LabelVerzending"
        Me.LabelVerzending.Size = New System.Drawing.Size(168, 16)
        Me.LabelVerzending.TabIndex = 0
        Me.LabelVerzending.Text = "Datum verzending postoverste:"
        '
        'GroupBoxBenadeelde
        '
        Me.GroupBoxBenadeelde.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxBenadeelde.Controls.Add(Me.UltraOptionSetBenadeelde)
        Me.GroupBoxBenadeelde.Controls.Add(Me.PanelPersoon)
        Me.GroupBoxBenadeelde.Controls.Add(Me.PanelFirma)
        Me.GroupBoxBenadeelde.Location = New System.Drawing.Point(424, 56)
        Me.GroupBoxBenadeelde.Name = "GroupBoxBenadeelde"
        Me.GroupBoxBenadeelde.Size = New System.Drawing.Size(584, 128)
        Me.GroupBoxBenadeelde.TabIndex = 1004
        Me.GroupBoxBenadeelde.TabStop = False
        Me.GroupBoxBenadeelde.Text = "Benadeelde"
        '
        'UltraComboAfdelingen
        '
        Me.UltraComboAfdelingen.DataMember = "BBAFD"
        Me.UltraComboAfdelingen.DataSource = Me._dataAfdelingen
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAfdelingen.DisplayLayout.Appearance = Appearance6
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Afdeling"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Width = 125
        UltraGridColumn6.Header.Caption = "Afkorting"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 55
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.UltraComboAfdelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraComboAfdelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboAfdelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraComboAfdelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboAfdelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellPadding = 0
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAppearance = Appearance17
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboAfdelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.UltraComboAfdelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboAfdelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboAfdelingen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboAfdelingen.DisplayMember = "KRT_AFD"
        Me.UltraComboAfdelingen.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(56, 40)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 16
        Me.UltraComboAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAfdelingen.ValueMember = "ID_AFD"
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraOptionSetBenadeelde
        '
        Me.UltraOptionSetBenadeelde.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetBenadeelde.DataMember = "BBDIEFDU"
        Me.UltraOptionSetBenadeelde.DataSource = Me._dataDiefDup
        Me.UltraOptionSetBenadeelde.DisplayMember = "SCF_DUP"
        Me.UltraOptionSetBenadeelde.Location = New System.Drawing.Point(8, 16)
        Me.UltraOptionSetBenadeelde.Name = "UltraOptionSetBenadeelde"
        Me.UltraOptionSetBenadeelde.Size = New System.Drawing.Size(560, 16)
        Me.UltraOptionSetBenadeelde.TabIndex = 9
        Me.UltraOptionSetBenadeelde.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraOptionSetBenadeelde.ValueMember = "ID_DUP_DIEF"
        '
        '_dataDiefDup
        '
        Me._dataDiefDup.DataSetName = "TDSDiefDup"
        Me._dataDiefDup.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataDiefDup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelPersoon
        '
        Me.PanelPersoon.Controls.Add(Me.LabelBTWnr)
        Me.PanelPersoon.Controls.Add(Me.TextBoxBTWnr)
        Me.PanelPersoon.Controls.Add(Me.LabelNaamBenadeelde)
        Me.PanelPersoon.Controls.Add(Me.UltraMaskedEditStamnrBelanghebbende)
        Me.PanelPersoon.Controls.Add(Me.ButtonKiesPersoonBenadeelde)
        Me.PanelPersoon.Controls.Add(Me.LabelStamnummerBenadeelde)
        Me.PanelPersoon.Location = New System.Drawing.Point(8, 64)
        Me.PanelPersoon.Name = "PanelPersoon"
        Me.PanelPersoon.Size = New System.Drawing.Size(496, 56)
        Me.PanelPersoon.TabIndex = 11
        Me.PanelPersoon.Visible = False
        '
        'LabelBTWnr
        '
        Me.LabelBTWnr.Location = New System.Drawing.Point(8, 32)
        Me.LabelBTWnr.Name = "LabelBTWnr"
        Me.LabelBTWnr.Size = New System.Drawing.Size(56, 23)
        Me.LabelBTWnr.TabIndex = 6
        Me.LabelBTWnr.Text = "BTW Nr.:"
        Me.LabelBTWnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxBTWnr
        '
        Me.TextBoxBTWnr.Location = New System.Drawing.Point(128, 32)
        Me.TextBoxBTWnr.MaxLength = 20
        Me.TextBoxBTWnr.Name = "TextBoxBTWnr"
        Me.TextBoxBTWnr.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxBTWnr.TabIndex = 7
        '
        'LabelNaamBenadeelde
        '
        Me.LabelNaamBenadeelde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamBenadeelde.Location = New System.Drawing.Point(184, 8)
        Me.LabelNaamBenadeelde.Name = "LabelNaamBenadeelde"
        Me.LabelNaamBenadeelde.Size = New System.Drawing.Size(216, 20)
        Me.LabelNaamBenadeelde.TabIndex = 2
        Me.LabelNaamBenadeelde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrBelanghebbende
        '
        Me.UltraMaskedEditStamnrBelanghebbende.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrBelanghebbende.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrBelanghebbende.Location = New System.Drawing.Point(128, 8)
        Me.UltraMaskedEditStamnrBelanghebbende.MaxValue = 99999999
        Me.UltraMaskedEditStamnrBelanghebbende.Name = "UltraMaskedEditStamnrBelanghebbende"
        Me.UltraMaskedEditStamnrBelanghebbende.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrBelanghebbende.TabIndex = 1
        Me.UltraMaskedEditStamnrBelanghebbende.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ButtonKiesPersoonBenadeelde
        '
        Me.ButtonKiesPersoonBenadeelde.Location = New System.Drawing.Point(408, 6)
        Me.ButtonKiesPersoonBenadeelde.Name = "ButtonKiesPersoonBenadeelde"
        Me.ButtonKiesPersoonBenadeelde.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoonBenadeelde.TabIndex = 3
        Me.ButtonKiesPersoonBenadeelde.Text = "Kies persoon"
        '
        'LabelStamnummerBenadeelde
        '
        Me.LabelStamnummerBenadeelde.Location = New System.Drawing.Point(8, 6)
        Me.LabelStamnummerBenadeelde.Name = "LabelStamnummerBenadeelde"
        Me.LabelStamnummerBenadeelde.Size = New System.Drawing.Size(136, 23)
        Me.LabelStamnummerBenadeelde.TabIndex = 0
        Me.LabelStamnummerBenadeelde.Text = "Benadeelde Persoon:"
        Me.LabelStamnummerBenadeelde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelFirma
        '
        Me.PanelFirma.Controls.Add(Me.LabelFirmaAdres)
        Me.PanelFirma.Controls.Add(Me.LabelNaamBenadeeldeFirma)
        Me.PanelFirma.Controls.Add(Me.LabelFirma)
        Me.PanelFirma.Controls.Add(Me.ButtonKiesFirmas)
        Me.PanelFirma.Controls.Add(Me.TextBoxFirmaId)
        Me.PanelFirma.Location = New System.Drawing.Point(8, 64)
        Me.PanelFirma.Name = "PanelFirma"
        Me.PanelFirma.Size = New System.Drawing.Size(496, 48)
        Me.PanelFirma.TabIndex = 10
        Me.PanelFirma.Visible = False
        '
        'LabelFirmaAdres
        '
        Me.LabelFirmaAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirmaAdres.Location = New System.Drawing.Point(120, 32)
        Me.LabelFirmaAdres.Name = "LabelFirmaAdres"
        Me.LabelFirmaAdres.Size = New System.Drawing.Size(368, 20)
        Me.LabelFirmaAdres.TabIndex = 4
        Me.LabelFirmaAdres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamBenadeeldeFirma
        '
        Me.LabelNaamBenadeeldeFirma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamBenadeeldeFirma.Location = New System.Drawing.Point(120, 6)
        Me.LabelNaamBenadeeldeFirma.Name = "LabelNaamBenadeeldeFirma"
        Me.LabelNaamBenadeeldeFirma.Size = New System.Drawing.Size(280, 20)
        Me.LabelNaamBenadeeldeFirma.TabIndex = 1
        Me.LabelNaamBenadeeldeFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFirma
        '
        Me.LabelFirma.Location = New System.Drawing.Point(8, 6)
        Me.LabelFirma.Name = "LabelFirma"
        Me.LabelFirma.Size = New System.Drawing.Size(112, 23)
        Me.LabelFirma.TabIndex = 0
        Me.LabelFirma.Text = "Benadeelde Firma:"
        Me.LabelFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesFirmas
        '
        Me.ButtonKiesFirmas.Location = New System.Drawing.Point(408, 6)
        Me.ButtonKiesFirmas.Name = "ButtonKiesFirmas"
        Me.ButtonKiesFirmas.Size = New System.Drawing.Size(80, 23)
        Me.ButtonKiesFirmas.TabIndex = 2
        Me.ButtonKiesFirmas.Text = "Firma's"
        '
        'TextBoxFirmaId
        '
        Me.TextBoxFirmaId.Location = New System.Drawing.Point(56, 32)
        Me.TextBoxFirmaId.Name = "TextBoxFirmaId"
        Me.TextBoxFirmaId.Size = New System.Drawing.Size(8, 20)
        Me.TextBoxFirmaId.TabIndex = 3
        Me.TextBoxFirmaId.Visible = False
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(432, 96)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(48, 16)
        Me.LabelAfdeling.TabIndex = 1005
        Me.LabelAfdeling.Text = "Afdeling:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_dataRegDiefstal
        '
        Me._dataRegDiefstal.DataSetName = "TDSRegDiefstal"
        Me._dataRegDiefstal.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegDiefstal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GroupBoxPolitie
        '
        Me.GroupBoxPolitie.Controls.Add(Me.LabelPvNummer)
        Me.GroupBoxPolitie.Controls.Add(Me.TextBoxPVNummer)
        Me.GroupBoxPolitie.Controls.Add(Me.CheckBoxPolitieGeweest)
        Me.GroupBoxPolitie.Controls.Add(Me.CheckBoxPolitieGevraagd)
        Me.GroupBoxPolitie.Location = New System.Drawing.Point(0, 120)
        Me.GroupBoxPolitie.Name = "GroupBoxPolitie"
        Me.GroupBoxPolitie.Size = New System.Drawing.Size(424, 64)
        Me.GroupBoxPolitie.TabIndex = 1006
        Me.GroupBoxPolitie.TabStop = False
        Me.GroupBoxPolitie.Text = "Politie"
        '
        'LabelPvNummer
        '
        Me.LabelPvNummer.AutoSize = True
        Me.LabelPvNummer.Location = New System.Drawing.Point(166, 41)
        Me.LabelPvNummer.Name = "LabelPvNummer"
        Me.LabelPvNummer.Size = New System.Drawing.Size(66, 13)
        Me.LabelPvNummer.TabIndex = 16
        Me.LabelPvNummer.Text = "PV Nummer:"
        '
        'TextBoxPVNummer
        '
        Me.TextBoxPVNummer.Location = New System.Drawing.Point(238, 38)
        Me.TextBoxPVNummer.Name = "TextBoxPVNummer"
        Me.TextBoxPVNummer.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxPVNummer.TabIndex = 15
        '
        'CheckBoxPolitieGeweest
        '
        Me.CheckBoxPolitieGeweest.AutoSize = True
        Me.CheckBoxPolitieGeweest.Location = New System.Drawing.Point(10, 40)
        Me.CheckBoxPolitieGeweest.Name = "CheckBoxPolitieGeweest"
        Me.CheckBoxPolitieGeweest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxPolitieGeweest.Size = New System.Drawing.Size(122, 17)
        Me.CheckBoxPolitieGeweest.TabIndex = 14
        Me.CheckBoxPolitieGeweest.Text = "Politie langsgeweest"
        Me.CheckBoxPolitieGeweest.UseVisualStyleBackColor = True
        '
        'CheckBoxPolitieGevraagd
        '
        Me.CheckBoxPolitieGevraagd.AutoSize = True
        Me.CheckBoxPolitieGevraagd.Location = New System.Drawing.Point(10, 19)
        Me.CheckBoxPolitieGevraagd.Name = "CheckBoxPolitieGevraagd"
        Me.CheckBoxPolitieGevraagd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxPolitieGevraagd.Size = New System.Drawing.Size(166, 17)
        Me.CheckBoxPolitieGevraagd.TabIndex = 13
        Me.CheckBoxPolitieGevraagd.Text = "Politie gevraagd door afdeling"
        Me.CheckBoxPolitieGevraagd.UseVisualStyleBackColor = True
        '
        'FormBewakingDiefstal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 615)
        Me.Controls.Add(Me.GroupBoxPolitie)
        Me.Controls.Add(Me.LabelAfdeling)
        Me.Controls.Add(Me.GroupBoxBenadeelde)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxRelaas)
        Me.Controls.Add(Me.GroupBoxInformatie)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Controls.Add(Me.GroupBoxDiefstal)
        Me.Name = "FormBewakingDiefstal"
        Me.Text = "Registratie Diefstal"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        Me.GroupBoxInformatie.ResumeLayout(False)
        Me.GroupBoxInformatie.PerformLayout()
        Me.GroupBoxRelaas.ResumeLayout(False)
        Me.GroupBoxRelaas.PerformLayout()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        Me.GroupBoxDiefstal.ResumeLayout(False)
        Me.GroupBoxVerzending.ResumeLayout(False)
        Me.GroupBoxVerzending.PerformLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBenadeelde.ResumeLayout(False)
        Me.GroupBoxBenadeelde.PerformLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetBenadeelde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataDiefDup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPersoon.ResumeLayout(False)
        Me.PanelPersoon.PerformLayout()
        Me.PanelFirma.ResumeLayout(False)
        Me.PanelFirma.PerformLayout()
        CType(Me._dataRegDiefstal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPolitie.ResumeLayout(False)
        Me.GroupBoxPolitie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Load"
    Private Sub FormBewakingDiefstal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing

            'Mensen met Diefstal-profiel moeten enkel overzicht hebben en detail ZIEN, maw niet aanpassen
            If FormManager.Current.Diefstal = True Then
                GroupBoxPolitie.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False
                GroupBoxBenadeelde.Enabled = False
                GroupBoxHoofding.Enabled = False
                TextBoxBeschrijving.ReadOnly = True
                TextBoxStaat.ReadOnly = True
                UltraMaskedEditWaarde.ReadOnly = True
                TextBoxRelaas.ReadOnly = True
                GroupBoxVerzending.Enabled = False
                UltraButtonOpslaan.Enabled = False
                UltraButtonOverzicht.Enabled = False
            End If



            If _idRegistratie <> -1 Then
                bindRegistratie()
            End If

            'voor usercontrol
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsDiefstal.DatumOpstelling = Now
            End If

            bindBijlagen()
            bindBestemmelingen()
            initializeDataSetConfig()
            initializeDataSetIndividuen()

            Me.checkControls()

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
            Me.UserControlGeneralFunctionsDiefstal.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

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
        'Doel:  registratie diefstal gegevens invullen op scherm
        'Datum: Nancy Coppens - 21/09/2006

        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            _dataRegDiefstal.Clear()
            Me._dataRegDiefstal.Merge(Me._controller.GetRegDiefstal(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegDiefstal.BBBEWREGRow
            dr = Me._dataRegDiefstal.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsDiefstal.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsDiefstal.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsDiefstal.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsDiefstal.SetVeraData(dr.VeraReference, dr.VeraLink)
            End If

            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsDiefstal.GetReportContractant = dr.VerslagContractantYN
            End If

            'Diefstal opvullen
            Dim drDief As TDSRegDiefstal.BBDIEFSTRow
            drDief = Me._dataRegDiefstal.BBDIEFST.FindByID_REG(_idRegistratie)

            If drDief Is Nothing Then 'naco - 15/09/2006
                MessageBox.Show("Record niet gevonden in BBDIEFST-tabel voor ID_REG = " & _idRegistratie, "ID_REG", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            UltraMaskedEditStamnrVaststeller.Text = CStr(drDief.ID_MLD)
            If Not drDief.IsNM_INDNull And Not drDief.IsVNM_INDNull Then
                LabelNaamVaststeller.Text = drDief.NM_IND.Trim & " " & drDief.VNM_IND
            ElseIf Not drDief.IsNM_INDNull Then
                LabelNaamVaststeller.Text = drDief.NM_IND
            ElseIf Not drDief.IsVNM_INDNull Then
                LabelNaamVaststeller.Text = drDief.VNM_IND
            Else
                LabelNaamVaststeller.Text = ""
            End If
            If Not drDief.IsAD_INDNull Then
                LabelAdresVaststeller.Text = drDief.AD_IND.Trim
            End If
            If Not drDief.IsPO_COD_WNPL_INDNull Then
                LabelAdresVaststeller.Text &= " " & drDief.PO_COD_WNPL_IND.Trim
            End If
            If Not drDief.IsWNPL_INDNull Then
                LabelAdresVaststeller.Text &= " " & drDief.WNPL_IND
            End If

            If Not drDief.IsID_DUPNull Then
                UltraOptionSetBenadeelde.Value = drDief.ID_DUP
            End If

            handleBenadeelde(CType(Me._dataDiefDup.BBDIEFDU.FindByID_DUP_DIEF(drDief.ID_DUP.ToString), TDSDiefDup.BBDIEFDURow))

            If Not drDief.IsID_AFDNull Then
                UltraComboAfdelingen.Value = drDief.ID_AFD
            End If


            'Add Politie gegevens to binding

            If Not drDief.IsPolitieLangsgeweestYNNull Then
                CheckBoxPolitieGeweest.Checked = drDief.PolitieLangsgeweestYN
            End If

            If Not drDief.IsPolitieGevraagdDoorAfdYNNull Then
                CheckBoxPolitieGevraagd.Checked = drDief.PolitieGevraagdDoorAfdYN
            End If

            If Not drDief.IsPolitiePVnummerNull Then
                TextBoxPVNummer.Text = drDief.PolitiePVnummer
            End If



            'Firma gegevens
            If Not Me._dataRegDiefstal.BBFRM.Rows.Count() = 0 Then

                Dim drFirma As TDSRegDiefstal.BBFRMRow
                drFirma = CType(Me._dataRegDiefstal.BBFRM.Rows.Item(0), TDSRegDiefstal.BBFRMRow)

                TextBoxFirmaId.Text = CStr(drFirma.ID_FRM)
                If Not drFirma.IsNM_FRMNull Then
                    LabelNaamBenadeeldeFirma.Text = drFirma.NM_FRM.Trim
                End If
                If Not drFirma.IsSTRA_FRMNull Then
                    LabelFirmaAdres.Text = drFirma.STRA_FRM.Trim
                End If
                If Not drFirma.IsPO_COD_PLA_FRMNull Then
                    LabelFirmaAdres.Text &= " , " & drFirma.PO_COD_PLA_FRM.Trim
                End If
                If Not drFirma.IsPLA_FRMNull Then
                    LabelFirmaAdres.Text &= " " & drFirma.PLA_FRM
                End If
            End If

            If Not drDief.IsID_DUP_INDNull Then
                UltraMaskedEditStamnrBelanghebbende.Text = CStr(drDief.ID_DUP_IND)
            End If
            If Not drDief.IsNM_IND1Null And Not drDief.IsVNM_IND1Null Then
                LabelNaamBenadeelde.Text = drDief.NM_IND1.Trim & " " & drDief.VNM_IND1
            ElseIf Not drDief.IsNM_IND1Null Then
                LabelNaamBenadeelde.Text = drDief.NM_IND1
            ElseIf Not drDief.IsVNM_IND1Null Then
                LabelNaamBenadeelde.Text = drDief.VNM_IND1
            Else
                LabelNaamBenadeelde.Text = ""
            End If
            If Not drDief.IsNR_BTWNull Then
                TextBoxBTWnr.Text = drDief.NR_BTW
            End If
            If Not drDief.IsSCF_MAT_STLNNull Then
                TextBoxBeschrijving.Text = drDief.SCF_MAT_STLN
            End If
            If Not drDief.IsSTA_MATNull Then
                TextBoxStaat.Text = drDief.STA_MAT
            End If
            If Not drDief.IsWD_MATNull Then
                UltraMaskedEditWaarde.Value = drDief.WD_MAT
            End If
            If Not drDief.IsSCF_LNG_DIEFNull Then
                TextBoxRelaas.Text = drDief.SCF_LNG_DIEF
            End If

            'Gegevens verzending
            '-------------------
            If Not dr.IsDT_VZ_RAP_NWNull Then
                UltraDateTimeEditorVerzending.Value = dr.DT_VZ_RAP_NW
                'indien de interventie reeds doorgemaild is, en de gebruiker is niet de postoverste
                'of de bbwverantwoordelijke, dan mag hij deze niet meer wijzigen
                If FormManager.Current.PostOverste = False And FormManager.Current.BBWVerantwoordelijke = False Then
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

            Me.UserControlGeneralFunctionsDiefstal.setBijlageData(Me._dataRegDiefstal.BBBYLG)
            Me.UserControlGeneralFunctionsDiefstal.setBestemmelingenData(Me._dataRegDiefstal.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingDiefstal - bindInterventie()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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
    Private Sub bindUltraOptionSet()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataDiefDup.Merge(Me._controller.GetDiefDup())

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
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

        Me.UserControlGeneralFunctionsDiefstal.setPersoneelData(_dataBEWPersoneel)
    End Sub

    Private Sub bindBijlagen()
        Me.UserControlGeneralFunctionsDiefstal.setBijlageData(_dataRegDiefstal.BBBYLG)
    End Sub

    Private Sub bindBestemmelingen()
        Me.UserControlGeneralFunctionsDiefstal.setBestemmelingenData(_dataRegDiefstal.BBBST)
    End Sub
#End Region

#Region "Button en optionevents"
    Private Sub ButtonKiesFirmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesFirmas.Click
        Try
            Using f_firma As FormBewakingFirmas = New FormBewakingFirmas

                f_firma.ShowDialog()

                If f_firma.DialogResult = DialogResult.OK Then
                    TextBoxFirmaId.Text = CStr(f_firma.IdFirma)
                    LabelNaamBenadeeldeFirma.Text = f_firma.NaamFirma
                    LabelFirmaAdres.Text = f_firma.AdresFirma & ", " & f_firma.PostNrFirma & " " & f_firma.GemeenteFirma
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonVaststeller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonVaststeller.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrVaststeller.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamVaststeller.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamVaststeller.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamVaststeller.Text = individu.VNM_IND
                Else
                    LabelNaamVaststeller.Text = ""
                End If
                If Not individu.IsAD_INDNull Then
                    LabelAdresVaststeller.Text = individu.AD_IND
                End If
                If Not individu.IsPO_COD_WNPL_INDNull Then
                    LabelAdresVaststeller.Text &= " " & individu.PO_COD_WNPL_IND
                End If
                If Not individu.IsWNPL_INDNull Then
                    LabelAdresVaststeller.Text &= " " & individu.WNPL_IND
                End If
            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Public Sub checkControls()
        'als het reeds verstuurd is geweest
        If Not FormManager.Current.PostOverste And Not FormManager.Current.BBWVerantwoordelijke Then
            If Not _idRegistratie = -1 And Not Me.UltraDateTimeEditorVerzending.Text = "" Then
                UserControlGeneralFunctionsDiefstal.lockControls()
            End If
        End If
    End Sub

    Private Sub ButtonKiesPersoonBenadeelde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonBenadeelde.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrBelanghebbende.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamBenadeelde.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamBenadeelde.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamBenadeelde.Text = individu.VNM_IND
                Else
                    LabelNaamBenadeelde.Text = ""
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

    Private Sub UltraOptionSetBenadeelde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraOptionSetBenadeelde.ValueChanged
        Try
            handleBenadeelde(CType(Me._dataDiefDup.BBDIEFDU.FindByID_DUP_DIEF(CType(UltraOptionSetBenadeelde.Value, _
                                                                                   String)), TDSDiefDup.BBDIEFDURow))
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UserControlGeneralFunctionsDiefstal_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsDiefstal.NieuwBestemmelingen
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, GetAfdeling())

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
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
#Region "Functions"
    Private Sub handleBenadeelde(ByVal drDiefDup As TDSDiefDup.BBDIEFDURow)
        If Not drDiefDup.IsINDI_NM_FRM_VPNull Then
            If Not drDiefDup.IsINDI_NR_ST_VPNull Then
                showPanels(drDiefDup.INDI_NM_FRM_VP, drDiefDup.INDI_NR_ST_VP)
            Else
                showPanels(drDiefDup.INDI_NM_FRM_VP, False)
            End If
        Else
            If Not drDiefDup.IsINDI_NR_ST_VPNull Then
                showPanels(False, drDiefDup.INDI_NR_ST_VP)
            Else
                showPanels(False, False)
            End If
        End If
    End Sub

    Private Sub showPanels(ByVal boolFirma As Boolean, ByVal boolWerknemer As Boolean)
        PanelFirma.Visible = boolFirma
        PanelPersoon.Visible = boolWerknemer
    End Sub

    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsDiefstal.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
        UserControlGeneralFunctionsDiefstal.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub

    Private Sub setLabelsVerplicht()
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        GroupBoxAlgemeneGegevens.Text &= " *"
        GroupBoxBenadeelde.Text &= " *"
        LabelFirma.Text &= " *"
        LabelStamnummerBenadeelde.Text &= " *"
        LabelBeschrijving.Text &= " *"
        GroupBoxRelaas.Text &= " *"
        LabelWaarde.Text &= " *"
    End Sub

    Private Function GetAfdeling() As String
        Return UltraComboAfdelingen.Text
    End Function

#End Region
#Region "Textboxevents"
    Private Sub TextBoxStamnrMelder_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrVaststeller, Me.LabelNaamVaststeller, Me.LabelAdresVaststeller)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrVaststeller_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrVaststeller, Me.LabelNaamVaststeller, Me.LabelAdresVaststeller)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrBelanghebbende_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrBelanghebbende.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBelanghebbende, Me.LabelNaamBenadeelde, Nothing)
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
                Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrBelanghebbende, Me.LabelNaamBenadeelde, Nothing)
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
                            LabelAdres.Text &= " " & individu.WNPL_IND
                        End If
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
        Cursor.Current = Cursors.WaitCursor
        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus("De registratie werd succesvol opgeslagen")
            Else
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub opslaanRegistratie()
        'Doel: nieuwe diefstalregistratie toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 27/04/2006
        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy

        Dim dsDiefstal As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal
        Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBEWREGRow
        Dim drDiefstal As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBDIEFSTRow
        Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBYLGRow
        Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try

            dsDiefstal.BBBST.DataSet.Clear()
            dsDiefstal.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsDiefstal.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsDiefstal.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd
            If (UserControlGeneralFunctionsDiefstal.CheckBestemmelingen(dsBest) = True) Then
                _controller = New ControllerGetData

                If Me._idRegistratie = -1 Then 'nieuwe alcoholtest

                    drRegistratie = dsDiefstal.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsDiefstal.Opsteller
                        .ID_TY_REG = 3
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsDiefstal.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsDiefstal.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsDiefstal.GetVeraReference
                        .VerslagContractantYN = UserControlGeneralFunctionsDiefstal.GetReportContractant
                    End With
                    dsDiefstal.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Diefstal
                    '-----------
                    drDiefstal = dsDiefstal.BBDIEFST.NewBBDIEFSTRow
                    With drDiefstal
                        .ID_REG = id_reg
                        .ID_MLD = CInt(Me.UltraMaskedEditStamnrVaststeller.Text)
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If

                        ' Men kan maar 1 soort benadeelde hebben (Individu, Firma of Sidmar zelf)
                        ' Bij het wijzigen kan het zijn dat er nog gegevens in bv Firma staan terwijl enkel het Individu
                        ' opgeslagen moet worden. Door SetID_... ledigt men de overbodige gegevens.
                        If PanelPersoon.Visible = True Then
                            .ID_DUP_IND = CInt(Me.UltraMaskedEditStamnrBelanghebbende.Text)
                            .SetID_FRMNull()
                            Me.TextBoxFirmaId.Text = ""
                        ElseIf PanelFirma.Visible = True Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                            .SetID_DUP_INDNull()
                            Me.UltraMaskedEditStamnrBelanghebbende.Text = ""
                        Else
                            .SetID_FRMNull()
                            .SetID_DUP_INDNull()

                            Me.TextBoxFirmaId.Text = ""
                            Me.UltraMaskedEditStamnrBelanghebbende.Text = ""
                        End If

                        .ID_DUP = CInt(Me.UltraOptionSetBenadeelde.Value)
                        .SCF_MAT_STLN = Me.TextBoxBeschrijving.Text
                        .STA_MAT = Me.TextBoxStaat.Text
                        If UltraMaskedEditWaarde.Text = "______,__" Or UltraMaskedEditWaarde.Text = "€" Then
                            'do nothing ==> geen gegevens van waarde toevoegen 
                        Else
                            .WD_MAT = CType(Me.UltraMaskedEditWaarde.Value, Double)
                        End If
                        .NR_BTW = Me.TextBoxBTWnr.Text
                        .SCF_LNG_DIEF = Me.TextBoxRelaas.Text
                        .PolitieGevraagdDoorAfdYN = Me.CheckBoxPolitieGevraagd.Checked
                        .PolitieLangsgeweestYN = Me.CheckBoxPolitieGeweest.Checked
                        .PolitiePVnummer = Me.TextBoxPVNummer.Text
                    End With
                    dsDiefstal.BBDIEFST.AddBBDIEFSTRow(drDiefstal)

                    '3. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------

                    Dim drByl As DataRow
                    Dim chronicleID As String
                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsDiefstal.BBBYLG.NewBBBYLGRow
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
                            chronicleID = UploadDiefstalBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If

                        dsDiefstal.BBBYLG.AddBBBYLGRow(drBylagen)
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegDiefstal.BBBSTRow 'Dien - aug2008 - migratie 2008
                    Dim drBest As DataRow
                    Dim stamnrVerantwVerzekering As Integer
                    Dim bAddAssuranceResponsible As Boolean = True
                    Dim tdsIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
                    Dim drIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen.BBINDRow

                    stamnrVerantwVerzekering = CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Assurance Responsible").WD)
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsDiefstal.BBBST.NewBBBSTRow
                        drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST"))
                        drBestemmelingen.ID_IND = CInt(drBest.Item("ID_IND"))
                        'Nagaan of de verantwoordelijke van de verzekering voorkomt in de lijst van de bestemmelingen,
                        'zoniet moet deze toegevoegd worden
                        If (CInt(drbest.Item("ID_IND")) = stamnrVerantwVerzekering) Then
                            bAddAssuranceResponsible = False
                        End If
                        drBestemmelingen.ID_REG = id_reg
                        drBestemmelingen.NM_IND = CType(drBest.Item("NM_IND"), String)
                        drBestemmelingen.VNM_IND = CType(drBest.Item("VNM_IND"), String)
                        If drBest.Item("AD_EMAL_IND") Is DBNull.Value Then
                            drBestemmelingen.AD_EMAL_IND = ""
                        Else
                            drBestemmelingen.AD_EMAL_IND = CType(drBest.Item("AD_EMAL_IND"), String)
                        End If

                        dsDiefstal.BBBST.AddBBBSTRow(drBestemmelingen)
                    Next


                    'Toevoegen van de verantwoordelijke van de verzekeringen indien de waarde van de diefstal > 2500 Euro
                    'If bAddAssuranceResponsible And (CType(UltraMaskedEditWaarde.Value, Double) > CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "MinWaardeDiefstal").WD)) Then
                    '27/01/2011 - op vraag van Toni Masson - niet meer rekening houden met de minimum waarde van de diefstal
                    'alle diefstallen doorsturen
                    If bAddAssuranceResponsible Then
                        If (MessageBox.Show("Wens je de verantwoordelijke van de verzekeringen (voor diefstallen) toe te voegen aan de bestemmelingen?", "Bestemmelingen", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes) Then
                            drBestemmelingen = dsDiefstal.BBBST.NewBBBSTRow
                            tdsIndividu = proxy.GetIndividu(CInt(stamnrVerantwVerzekering))
                            If tdsIndividu.BBIND.Count > 0 Then
                                drIndividu = tdsIndividu.BBIND(0)
                                'drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST"))
                                drBestemmelingen.ID_IND = CInt(drIndividu.Item("ID_IND"))
                                drBestemmelingen.ID_REG = id_reg
                                drBestemmelingen.NM_IND = CType(drIndividu.Item("NM_IND"), String)
                                drBestemmelingen.VNM_IND = CType(drIndividu.Item("VNM_IND"), String)
                                If drIndividu.Item("AD_EMAL_IND") Is DBNull.Value Then
                                    drBestemmelingen.AD_EMAL_IND = ""
                                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(id_reg, CInt(drIndividu.Item("ID_IND")), CType(drIndividu.Item("NM_IND"), String), CType(drIndividu.Item("VNM_IND"), String), Nothing)
                                Else
                                    drBestemmelingen.AD_EMAL_IND = CType(drIndividu.Item("AD_EMAL_IND"), String)
                                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(id_reg, CInt(drIndividu.Item("ID_IND")), CType(drIndividu.Item("NM_IND"), String), CType(drIndividu.Item("VNM_IND"), String), CType(drIndividu.Item("AD_EMAL_IND"), String))
                                End If
                                dsDiefstal.BBBST.AddBBBSTRow(drBestemmelingen)
                            End If
                        End If
                    End If

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

                Else 'bestaande interventie wijzigen
                    dsDiefstal.Merge(Me._controller.GetRegDiefstal(Me._idRegistratie))
                    drRegistratie = dsDiefstal.BBBEWREG.FindByID_REG(Me._idRegistratie)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsDiefstal.Opsteller
                        .ID_TY_REG = 3
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsDiefstal.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(LabelVolgnr.Text)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsDiefstal.GetVeraLink
                        .VeraReference = UserControlGeneralFunctionsDiefstal.GetVeraReference
                        .VerslagContractantYN = UserControlGeneralFunctionsDiefstal.GetReportContractant
                    End With
                    '2. Diefstal-record
                    '------------------
                    drDiefstal = CType(dsDiefstal.BBDIEFST.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBDIEFSTRow)
                    With drDiefstal
                        .ID_REG = Me._idRegistratie
                        .ID_MLD = CInt(Me.UltraMaskedEditStamnrVaststeller.Text)
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If

                        ' Men kan maar 1 soort benadeelde hebben (Individu, Firma of Sidmar zelf)
                        ' Bij het wijzigen kan het zijn dat er nog gegevens in bv Firma staan terwijl enkel het Individu
                        ' opgeslagen moet worden. Door SetID_... ledigt men de overbodige gegevens.
                        If PanelPersoon.Visible = True Then
                            .ID_DUP_IND = CInt(Me.UltraMaskedEditStamnrBelanghebbende.Text)
                            .SetID_FRMNull()
                            Me.TextBoxFirmaId.Text = ""
                        ElseIf PanelFirma.Visible = True Then
                            .ID_FRM = CInt(TextBoxFirmaId.Text)
                            .SetID_DUP_INDNull()
                            Me.UltraMaskedEditStamnrBelanghebbende.Text = ""
                        Else
                            .SetID_FRMNull()
                            .SetID_DUP_INDNull()
                            Me.TextBoxFirmaId.Text = ""
                            Me.UltraMaskedEditStamnrBelanghebbende.Text = ""
                        End If

                        .ID_DUP = CInt(Me.UltraOptionSetBenadeelde.Value)
                        .SCF_MAT_STLN = Me.TextBoxBeschrijving.Text
                        .STA_MAT = Me.TextBoxStaat.Text
                        If UltraMaskedEditWaarde.Text = "______,__" Or UltraMaskedEditWaarde.Text = "€" Then
                            'do nothing ==> geen gegevens van waarde toevoegen 
                        Else
                            .WD_MAT = CType(Me.UltraMaskedEditWaarde.Value, Double)
                        End If
                        .NR_BTW = Me.TextBoxBTWnr.Text
                        .SCF_LNG_DIEF = Me.TextBoxRelaas.Text
                        .PolitieGevraagdDoorAfdYN = Me.CheckBoxPolitieGevraagd.Checked
                        .PolitieLangsgeweestYN = Me.CheckBoxPolitieGeweest.Checked
                        .PolitiePVnummer = Me.TextBoxPVNummer.Text
                    End With

                    '3. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten

                    Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBYLGRow

                    For Each drBylg In dsDiefstal.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsDiefstal.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                                chronicleID = UploadDiefstalBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If

                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsDiefstal.BBBYLG.NewBBBYLGRow

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
                            dsDiefstal.BBBYLG.AddBBBYLGRow(drBylagen)

                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsDiefstal.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBYLGRow)
                                'drBylagen.ID_BYLG = CInt(drGridBYLG.Item("ID_BYLG"))
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
                                arrBylg = dsDiefstal.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBYLGRow)
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
                    Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal.BBBSTRow
                    Dim bAddAssuranceResponsible As Boolean = True
                    Dim tdsIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
                    Dim drIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen.BBINDRow
                    Dim stamnrVerantwVerzekering As Integer

                    stamnrVerantwVerzekering = CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "Assurance Responsible").WD)

                    For Each drBest In dsDiefstal.BBBST.Rows ' dsBest.Tables(0).Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsDiefstal.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drGridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsDiefstal.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._idRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsDiefstal.BBBST.AddBBBSTRow(drBestemmelingen)
                        End If
                        If drGridBST.RowState <> DataRowState.Deleted Then
                            If (CInt(drGridBST.Item("ID_IND")) = stamnrVerantwVerzekering) Then
                                bAddAssuranceResponsible = False
                            End If
                        End If
                    Next

                    'Toevoegen van de verantwoordelijke van de verzekeringen indien de waarde van de diefstal > 2500 Euro
                    If bAddAssuranceResponsible And (CType(UltraMaskedEditWaarde.Value, Double) > CInt(_dataConfiguratie.BBCONF.FindByGR_SLESLE("BBW", "MinWaardeDiefstal").WD)) Then
                        If (MsgBox("Wens je de verantwoordelijke van de verzekeringen (voor diefstallen) toe te voegen aan de bestemmelingen?", MsgBoxStyle.YesNo, "Bestemmelingen") = MsgBoxResult.Yes) Then
                            drBestemmelingen = dsDiefstal.BBBST.NewBBBSTRow
                            tdsIndividu = proxy.GetIndividu(CInt(stamnrVerantwVerzekering))
                            If tdsIndividu.BBIND.Count > 0 Then
                                drIndividu = tdsIndividu.BBIND(0)
                                'drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST"))
                                drBestemmelingen.ID_IND = CInt(drIndividu.Item("ID_IND"))
                                drBestemmelingen.ID_REG = Me._idRegistratie
                                drBestemmelingen.NM_IND = CType(drIndividu.Item("NM_IND"), String)
                                drBestemmelingen.VNM_IND = CType(drIndividu.Item("VNM_IND"), String)
                                If drIndividu.Item("AD_EMAL_IND") Is DBNull.Value Then
                                    drBestemmelingen.AD_EMAL_IND = ""
                                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(id_reg, CInt(drIndividu.Item("ID_IND")), CType(drIndividu.Item("NM_IND"), String), CType(drIndividu.Item("VNM_IND"), String), Nothing)
                                Else
                                    drBestemmelingen.AD_EMAL_IND = CType(drIndividu.Item("AD_EMAL_IND"), String)
                                    Me.UserControlGeneralFunctionsDiefstal.addBestemmeling(id_reg, CInt(drIndividu.Item("ID_IND")), CType(drIndividu.Item("NM_IND"), String), CType(drIndividu.Item("VNM_IND"), String), CType(drIndividu.Item("AD_EMAL_IND"), String))
                                End If
                                dsDiefstal.BBBST.AddBBBSTRow(drBestemmelingen)
                            End If
                        End If
                    End If

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
                Dim ds As New Proxy.BBWService.Mgt.TDSDiefstal
                ds.Merge(dsDiefstal.GetChanges)

                proxy.RegisterRegistratieDiefstal(ds, System.Environment.UserName)
                dsDiefstal.AcceptChanges()

                'als het om een nieuwe interventie gaat, worden volgende velden ingevuld
                If Me._idRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsDiefstal.getOpstelDatum)
                    'id instellen zodat bij refreshen geen nieuw scherm getoond word
                    Me._idRegistratie = id_reg
                End If

                Call Me.bindRegistratie()

                If arrayOfDeletedChronicleID.Count > 0 Then
                    For Each aChronicleId As String In arrayOfDeletedChronicleID
                        Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                    Next
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - opslaanRegistratie" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        'boodschap weergeven
    End Sub
    Private Function UploadDiefstalBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
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
        If UltraMaskedEditStamnrVaststeller.Text = "" Then
            errorBool = False
        End If
        If UltraOptionSetBenadeelde.Value Is Nothing Then
            errorBool = False
        Else
            Dim drDiefDup As TDSDiefDup.BBDIEFDURow = CType(Me._dataDiefDup.BBDIEFDU.FindByID_DUP_DIEF(CType(UltraOptionSetBenadeelde.Value, String)), TDSDiefDup.BBDIEFDURow)
            If Not drDiefDup.IsINDI_NM_FRM_VPNull And drDiefDup.INDI_NM_FRM_VP Then
                If TextBoxFirmaId.Text = "" Then
                    errorBool = False
                End If
            ElseIf Not drDiefDup.IsINDI_NR_ST_VPNull And drDiefDup.INDI_NR_ST_VP Then
                If UltraMaskedEditStamnrBelanghebbende.Text = "" Then
                    errorBool = False
                End If
            End If
        End If

        If TextBoxBeschrijving.Text = "" Then
            errorBool = False
        End If
        If TextBoxRelaas.Text = "" Then
            errorBool = False
        End If

        If Not UserControlGeneralFunctionsDiefstal.checkPersoneelOK Then
            errorBool = False
        End If

        If (IsDBNull(UltraMaskedEditWaarde.Value)) Then
            'If CStr(UltraMaskedEditWaarde.Value) = "______,__" Or CStr(UltraMaskedEditWaarde.Value) = "€" Then
            errorBool = False
            'End If
        End If

        Return errorBool
    End Function

    Private Sub FormBewakingDiefstal_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub
#End Region
#Region "Mailing"
    Private Sub sendMail(ByVal mailTo As ArrayList, _
                         ByVal aText As String, ByVal subject As String, _
                         ByVal pathAttach As ArrayList)
        Try
            MailBBW.sendMail(mailTo, aText, subject, pathAttach)

            Me.setStatus("Registratie succesvol verzonden naar de bestemmelingen")
        Catch ex As Exception
            Me.setStatus("OPGELET: registratie niet verzonden naar de bestemmelingen")

            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub initializeMailInfo()
        'Doel:   Verzending van mails => knoppen en textboxen goed zetten
        'Auteur: Nancy Coppens - 19/09/2006 (overgenomen van Brandweerinterventie Rajiv)

        Try
            If FormManager.Current.PostOverste Then
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonVerzendingBest.Visible = False
            ElseIf FormManager.Current.BBWVerantwoordelijke Then
                'do nothing, mag alles zien
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or FormManager.Current.Chip Then
                    UltraButtonOverzicht.Enabled = False
                    ButtonMailIKP.Visible = True
                    ButtonMailIKP.Top = UltraButtonOverzicht.Top
                End If
                UltraButtonOpslaan.Enabled = False
                UltraButtonAnnuleer.Visible = False
                GroupBoxHoofding.Enabled = False
                GroupBoxOverige.Enabled = False

                GroupBoxPolitie.Enabled = False
                GroupBoxBenadeelde.Enabled = False
                GroupBoxInformatie.Enabled = False
                GroupBoxRelaas.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False

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
                            "Form: FormBewakingDiefstal - intializeMailInfo" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    'Private Sub showReport()
    '    'Doel: print preview van het registratie tonen
    '    'Auteur: Nancy Coppens - 26/04/2006
    '    'Opgelet: afdrukken kan pas als het rapport is opgeslaan! Dus eerst vragen om rapport te bewaren
    '    Try
    '        Dim f_rap As New FormRapportenPreview

    '        If Me._idRegistratie = -1 Then
    '            'vragen om te bewaren
    '        End If

    '        f_rap.RegistratieID = Me._idRegistratie
    '        f_rap.Show()
    '        f_rap.ToonRapport()
    '        f_rap.ExportPDF()

    '    Catch ex As Exception
    '        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
    '                        "Form: FormBrandweerInterventie - showReport" & vbCrLf & _
    '                        "Message: " & ex.Message & vbCrLf & _
    '                        "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
    '                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    End Try
    'End Sub
#End Region


    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.showReport()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingDiefstal - UltraButtonAfdrukken_Click" & vbCrLf & _
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
                            'f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieDiefstal", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                            f_rap.ToonRapport(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD, _
                                              "RegistratieDiefstal", _
                                              "ID_REG", _
                                              CStr(Me._idRegistratie), "", "", "", "")
                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "RegistratieDiefstal")
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
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieDiefstal", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                    'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "AlcoholtestBewaking")
                    'report.AddParameter("ID_REG", Me._IDRegistratie)
                    'f_rap.ExportPDF()
                Else
                    MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingDiefstal - showReport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

#Region "Buttons verzending"
    Private Sub ButtonVerzendingBBW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerzendingBBW.Click
        'Doel:   verstuur verslag naar postoverste
        'Auteur: Koen Heye - mei 2006 - naco - 20/09/2006

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
                            "Opsteller:         " & UserControlGeneralFunctionsDiefstal.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiefstal - ButtonVerzendingBBW_Click()" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonGoedkeuring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - naco - 21/09/2006

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
                        "Opsteller:         " & UserControlGeneralFunctionsDiefstal.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiefstal - ButtonGoedkeuring_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsDiefstal.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingDiefstal - ButtonTerugZenden_Click()" & vbCrLf & _
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


            'naco - 01/03/2007
            'controleren of de bijlagen bestaan => anders kan de mail niet verstuurd worden
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDiefstal.getDataBijlagen.Tables(0).Rows
                If bijlageRow.RowState = DataRowState.Deleted Then
                    'het kan zijn dat er juist een bijlage gedelete is
                Else
                    Dim fi As New FileInfo(bijlageRow.PLA_BYLG)
                    If fi.Exists = False Then
                        MessageBox.Show("OPGELET: verslag kan niet doorgemaild worden." & vbCrLf & vbCrLf & _
                                        "Bijlage '" & bijlagerow.PLA_BYLG & "' kan niet teruggevonden worden." & _
                                        vbCrLf & "Gelieve het path van deze bijlage aan te passen aub.", "Bijlage niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.setStatus("")
                        Exit Sub
                    End If
                End If
            Next

            Me.opslaanRegistratie()

            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsDiefstal.getDataBestemmelingen.Tables(0).Rows
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


                textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsDiefstal.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String
                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDiefstal.getDataBijlagen.Tables(0).Rows
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
                                                   "RegistratieDiefstal", _
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
                            "Form: FormBewakingDiefstal - ButtonVerzendingBest_Click()" & vbCrLf & _
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

    Private Sub LabelAdresVaststeller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelAdresVaststeller.Click

    End Sub

    Private Sub UltraOptionSetVoertuig_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonMailIKP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMailIKP.Click
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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsDiefstal.getDataBijlagen.Tables(0).Rows

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
                "RegistratieDiefstal",
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
                             "Form: FormBewakingDiefstal - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function UserControlGeneralFunctionsSchadegeval() As Object
        Throw New NotImplementedException
    End Function

End Class
