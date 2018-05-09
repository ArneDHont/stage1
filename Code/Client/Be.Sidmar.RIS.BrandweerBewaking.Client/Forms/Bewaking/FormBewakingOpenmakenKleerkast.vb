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

Public Class FormBewakingOpenmakenKleerkast
    Inherits System.Windows.Forms.Form
#Region "Constants"
    Private _idRegistratie As Integer = -1
    Private _errorString As String = "Gelieve de verplichte velden, aangeduid met een *, in te vullen. "
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
    Friend WithEvents GroupBoxHoofding As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaats As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaats As System.Windows.Forms.Label
    Friend WithEvents LabelUur As System.Windows.Forms.Label
    Friend WithEvents LabelDatum As System.Windows.Forms.Label
    Friend WithEvents TextBoxVerslagnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerslagnr As System.Windows.Forms.Label
    Friend WithEvents LabelTitel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInlichtingen As System.Windows.Forms.TextBox
    Friend WithEvents LabelTitularis As System.Windows.Forms.Label
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents LabelReden As System.Windows.Forms.Label
    Friend WithEvents GroupBoxInhoud As System.Windows.Forms.GroupBox
    Friend WithEvents LabelAfgegevenTitularis As System.Windows.Forms.Label
    Friend WithEvents LabelEigendomTitularis As System.Windows.Forms.Label
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxInlichtingen As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEigendomSidmar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEigendomTitularis As System.Windows.Forms.TextBox
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents _dataRegOpenKleerkast As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegOpenKleerkast
    Friend WithEvents UserControlGeneralFunctionsOpenKleerkast As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents GroupBoxOpenKleerkast As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelAanvragDienst As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesPersoonTitularis As System.Windows.Forms.Button
    Friend WithEvents LabelAfgegevenAan As System.Windows.Forms.Label
    Friend WithEvents LabelEigendomSidmar As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesPersoonAanvragDienst As System.Windows.Forms.Button
    Friend WithEvents ButtonKiesPersoonAfgegevenTitularis As System.Windows.Forms.Button
    Friend WithEvents ButtonKiesPersoonAfgegevenSidmar As System.Windows.Forms.Button
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents TextBoxReden As System.Windows.Forms.TextBox
    Friend WithEvents UltraMaskedEditStamnrTitularis As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditAanvragDienst As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditAfgegevenSidmar As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEditAfgegevenTitularis As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents LabelNaamTitularis As System.Windows.Forms.Label
    Friend WithEvents LabelAfgegevenSidmar As System.Windows.Forms.Label
    Friend WithEvents LabelNaamAanvragDienst As System.Windows.Forms.Label
    Friend WithEvents LabelNaamAfgegevenTitularis As System.Windows.Forms.Label
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingOpenmakenKleerkast))
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
        Me.LabelNaamAanvragDienst = New System.Windows.Forms.Label()
        Me.LabelNaamTitularis = New System.Windows.Forms.Label()
        Me.UltraMaskedEditAanvragDienst = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEditStamnrTitularis = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ButtonKiesPersoonAanvragDienst = New System.Windows.Forms.Button()
        Me.LabelAanvragDienst = New System.Windows.Forms.Label()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.TextBoxReden = New System.Windows.Forms.TextBox()
        Me.LabelReden = New System.Windows.Forms.Label()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.LabelTitularis = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonTitularis = New System.Windows.Forms.Button()
        Me.TextBoxInlichtingen = New System.Windows.Forms.TextBox()
        Me.GroupBoxInhoud = New System.Windows.Forms.GroupBox()
        Me.LabelNaamAfgegevenTitularis = New System.Windows.Forms.Label()
        Me.LabelAfgegevenSidmar = New System.Windows.Forms.Label()
        Me.UltraMaskedEditAfgegevenTitularis = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEditAfgegevenSidmar = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxEigendomTitularis = New System.Windows.Forms.TextBox()
        Me.TextBoxEigendomSidmar = New System.Windows.Forms.TextBox()
        Me.ButtonKiesPersoonAfgegevenTitularis = New System.Windows.Forms.Button()
        Me.LabelAfgegevenTitularis = New System.Windows.Forms.Label()
        Me.LabelEigendomTitularis = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoonAfgegevenSidmar = New System.Windows.Forms.Button()
        Me.LabelAfgegevenAan = New System.Windows.Forms.Label()
        Me.LabelEigendomSidmar = New System.Windows.Forms.Label()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsOpenKleerkast = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me.GroupBoxInlichtingen = New System.Windows.Forms.GroupBox()
        Me._dataRegOpenKleerkast = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegOpenKleerkast()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me.GroupBoxOpenKleerkast = New System.Windows.Forms.GroupBox()
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
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInhoud.SuspendLayout()
        Me.GroupBoxOverige.SuspendLayout()
        Me.GroupBoxInlichtingen.SuspendLayout()
        CType(Me._dataRegOpenKleerkast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpenKleerkast.SuspendLayout()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVerzending.SuspendLayout()
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
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(704, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(296, 20)
        Me.TextBoxKorteOms.TabIndex = 1013
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(624, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1014
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(536, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 6
        Me.UltraMaskedEditUur.Text = ":"
        Me.UltraMaskedEditUur.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(536, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 4
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(704, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(296, 20)
        Me.TextBoxPlaats.TabIndex = 8
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(656, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 7
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(496, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 5
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(480, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 3
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(360, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 2
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.Location = New System.Drawing.Point(296, 24)
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
        Me.LabelTitel.Size = New System.Drawing.Size(271, 29)
        Me.LabelTitel.TabIndex = 0
        Me.LabelTitel.Text = "Openmaken Kleerkast"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(280, 16)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 23)
        Me.LabelVolgnr.TabIndex = 12
        Me.LabelVolgnr.Visible = False
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelNaamAanvragDienst)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelNaamTitularis)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraMaskedEditAanvragDienst)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraMaskedEditStamnrTitularis)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ButtonKiesPersoonAanvragDienst)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelAanvragDienst)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.TextBoxReden)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelReden)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelTitularis)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ButtonKiesPersoonTitularis)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 72)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(600, 168)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 1
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Algemene gegevens"
        '
        'LabelNaamAanvragDienst
        '
        Me.LabelNaamAanvragDienst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamAanvragDienst.Location = New System.Drawing.Point(184, 104)
        Me.LabelNaamAanvragDienst.Name = "LabelNaamAanvragDienst"
        Me.LabelNaamAanvragDienst.Size = New System.Drawing.Size(320, 20)
        Me.LabelNaamAanvragDienst.TabIndex = 8
        Me.LabelNaamAanvragDienst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamTitularis
        '
        Me.LabelNaamTitularis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamTitularis.Location = New System.Drawing.Point(184, 24)
        Me.LabelNaamTitularis.Name = "LabelNaamTitularis"
        Me.LabelNaamTitularis.Size = New System.Drawing.Size(320, 20)
        Me.LabelNaamTitularis.TabIndex = 2
        Me.LabelNaamTitularis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditAanvragDienst
        '
        Me.UltraMaskedEditAanvragDienst.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditAanvragDienst.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditAanvragDienst.Location = New System.Drawing.Point(128, 104)
        Me.UltraMaskedEditAanvragDienst.MaxValue = 99999999
        Me.UltraMaskedEditAanvragDienst.Name = "UltraMaskedEditAanvragDienst"
        Me.UltraMaskedEditAanvragDienst.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditAanvragDienst.TabIndex = 7
        Me.UltraMaskedEditAanvragDienst.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraMaskedEditStamnrTitularis
        '
        Me.UltraMaskedEditStamnrTitularis.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrTitularis.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrTitularis.Location = New System.Drawing.Point(128, 24)
        Me.UltraMaskedEditStamnrTitularis.MaxValue = 99999999
        Me.UltraMaskedEditStamnrTitularis.Name = "UltraMaskedEditStamnrTitularis"
        Me.UltraMaskedEditStamnrTitularis.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrTitularis.TabIndex = 1
        Me.UltraMaskedEditStamnrTitularis.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ButtonKiesPersoonAanvragDienst
        '
        Me.ButtonKiesPersoonAanvragDienst.Location = New System.Drawing.Point(512, 104)
        Me.ButtonKiesPersoonAanvragDienst.Name = "ButtonKiesPersoonAanvragDienst"
        Me.ButtonKiesPersoonAanvragDienst.Size = New System.Drawing.Size(80, 21)
        Me.ButtonKiesPersoonAanvragDienst.TabIndex = 9
        Me.ButtonKiesPersoonAanvragDienst.Text = "Kies persoon"
        '
        'LabelAanvragDienst
        '
        Me.LabelAanvragDienst.Location = New System.Drawing.Point(8, 104)
        Me.LabelAanvragDienst.Name = "LabelAanvragDienst"
        Me.LabelAanvragDienst.Size = New System.Drawing.Size(128, 23)
        Me.LabelAanvragDienst.TabIndex = 6
        Me.LabelAanvragDienst.Text = "Aanvragende dienst:"
        Me.LabelAanvragDienst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(128, 128)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 11
        Me.UltraComboAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAfdelingen.ValueMember = "ID_AFD"
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxReden
        '
        Me.TextBoxReden.Location = New System.Drawing.Point(128, 48)
        Me.TextBoxReden.MaxLength = 3000
        Me.TextBoxReden.Multiline = True
        Me.TextBoxReden.Name = "TextBoxReden"
        Me.TextBoxReden.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxReden.Size = New System.Drawing.Size(464, 56)
        Me.TextBoxReden.TabIndex = 5
        '
        'LabelReden
        '
        Me.LabelReden.Location = New System.Drawing.Point(8, 48)
        Me.LabelReden.Name = "LabelReden"
        Me.LabelReden.Size = New System.Drawing.Size(112, 23)
        Me.LabelReden.TabIndex = 4
        Me.LabelReden.Text = "Reden openmaking:"
        Me.LabelReden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(72, 128)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(48, 23)
        Me.LabelAfdeling.TabIndex = 10
        Me.LabelAfdeling.Text = "Afdeling:"
        Me.LabelAfdeling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitularis
        '
        Me.LabelTitularis.Location = New System.Drawing.Point(8, 24)
        Me.LabelTitularis.Name = "LabelTitularis"
        Me.LabelTitularis.Size = New System.Drawing.Size(104, 23)
        Me.LabelTitularis.TabIndex = 0
        Me.LabelTitularis.Text = "Titularis:"
        Me.LabelTitularis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonTitularis
        '
        Me.ButtonKiesPersoonTitularis.Location = New System.Drawing.Point(512, 24)
        Me.ButtonKiesPersoonTitularis.Name = "ButtonKiesPersoonTitularis"
        Me.ButtonKiesPersoonTitularis.Size = New System.Drawing.Size(80, 21)
        Me.ButtonKiesPersoonTitularis.TabIndex = 3
        Me.ButtonKiesPersoonTitularis.Text = "Kies persoon"
        '
        'TextBoxInlichtingen
        '
        Me.TextBoxInlichtingen.Location = New System.Drawing.Point(8, 16)
        Me.TextBoxInlichtingen.MaxLength = 1000
        Me.TextBoxInlichtingen.Multiline = True
        Me.TextBoxInlichtingen.Name = "TextBoxInlichtingen"
        Me.TextBoxInlichtingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInlichtingen.Size = New System.Drawing.Size(392, 144)
        Me.TextBoxInlichtingen.TabIndex = 0
        '
        'GroupBoxInhoud
        '
        Me.GroupBoxInhoud.Controls.Add(Me.LabelNaamAfgegevenTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.LabelAfgegevenSidmar)
        Me.GroupBoxInhoud.Controls.Add(Me.UltraMaskedEditAfgegevenTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.UltraMaskedEditAfgegevenSidmar)
        Me.GroupBoxInhoud.Controls.Add(Me.TextBoxEigendomTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.TextBoxEigendomSidmar)
        Me.GroupBoxInhoud.Controls.Add(Me.ButtonKiesPersoonAfgegevenTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.LabelAfgegevenTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.LabelEigendomTitularis)
        Me.GroupBoxInhoud.Controls.Add(Me.ButtonKiesPersoonAfgegevenSidmar)
        Me.GroupBoxInhoud.Controls.Add(Me.LabelAfgegevenAan)
        Me.GroupBoxInhoud.Controls.Add(Me.LabelEigendomSidmar)
        Me.GroupBoxInhoud.Location = New System.Drawing.Point(0, 240)
        Me.GroupBoxInhoud.Name = "GroupBoxInhoud"
        Me.GroupBoxInhoud.Size = New System.Drawing.Size(1008, 160)
        Me.GroupBoxInhoud.TabIndex = 2
        Me.GroupBoxInhoud.TabStop = False
        Me.GroupBoxInhoud.Text = "Inhoud kast"
        '
        'LabelNaamAfgegevenTitularis
        '
        Me.LabelNaamAfgegevenTitularis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamAfgegevenTitularis.Location = New System.Drawing.Point(664, 128)
        Me.LabelNaamAfgegevenTitularis.Name = "LabelNaamAfgegevenTitularis"
        Me.LabelNaamAfgegevenTitularis.Size = New System.Drawing.Size(248, 20)
        Me.LabelNaamAfgegevenTitularis.TabIndex = 10
        Me.LabelNaamAfgegevenTitularis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAfgegevenSidmar
        '
        Me.LabelAfgegevenSidmar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAfgegevenSidmar.Location = New System.Drawing.Point(184, 128)
        Me.LabelAfgegevenSidmar.Name = "LabelAfgegevenSidmar"
        Me.LabelAfgegevenSidmar.Size = New System.Drawing.Size(264, 20)
        Me.LabelAfgegevenSidmar.TabIndex = 4
        Me.LabelAfgegevenSidmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditAfgegevenTitularis
        '
        Me.UltraMaskedEditAfgegevenTitularis.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditAfgegevenTitularis.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditAfgegevenTitularis.Location = New System.Drawing.Point(608, 128)
        Me.UltraMaskedEditAfgegevenTitularis.MaxValue = 99999999
        Me.UltraMaskedEditAfgegevenTitularis.Name = "UltraMaskedEditAfgegevenTitularis"
        Me.UltraMaskedEditAfgegevenTitularis.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditAfgegevenTitularis.TabIndex = 9
        Me.UltraMaskedEditAfgegevenTitularis.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraMaskedEditAfgegevenSidmar
        '
        Me.UltraMaskedEditAfgegevenSidmar.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditAfgegevenSidmar.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditAfgegevenSidmar.Location = New System.Drawing.Point(128, 128)
        Me.UltraMaskedEditAfgegevenSidmar.MaxValue = 99999999
        Me.UltraMaskedEditAfgegevenSidmar.Name = "UltraMaskedEditAfgegevenSidmar"
        Me.UltraMaskedEditAfgegevenSidmar.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditAfgegevenSidmar.TabIndex = 3
        Me.UltraMaskedEditAfgegevenSidmar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxEigendomTitularis
        '
        Me.TextBoxEigendomTitularis.Location = New System.Drawing.Point(608, 16)
        Me.TextBoxEigendomTitularis.MaxLength = 1000
        Me.TextBoxEigendomTitularis.Multiline = True
        Me.TextBoxEigendomTitularis.Name = "TextBoxEigendomTitularis"
        Me.TextBoxEigendomTitularis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxEigendomTitularis.Size = New System.Drawing.Size(392, 104)
        Me.TextBoxEigendomTitularis.TabIndex = 7
        '
        'TextBoxEigendomSidmar
        '
        Me.TextBoxEigendomSidmar.Location = New System.Drawing.Point(128, 16)
        Me.TextBoxEigendomSidmar.MaxLength = 1000
        Me.TextBoxEigendomSidmar.Multiline = True
        Me.TextBoxEigendomSidmar.Name = "TextBoxEigendomSidmar"
        Me.TextBoxEigendomSidmar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxEigendomSidmar.Size = New System.Drawing.Size(408, 104)
        Me.TextBoxEigendomSidmar.TabIndex = 1
        '
        'ButtonKiesPersoonAfgegevenTitularis
        '
        Me.ButtonKiesPersoonAfgegevenTitularis.Location = New System.Drawing.Point(920, 128)
        Me.ButtonKiesPersoonAfgegevenTitularis.Name = "ButtonKiesPersoonAfgegevenTitularis"
        Me.ButtonKiesPersoonAfgegevenTitularis.Size = New System.Drawing.Size(80, 21)
        Me.ButtonKiesPersoonAfgegevenTitularis.TabIndex = 11
        Me.ButtonKiesPersoonAfgegevenTitularis.Text = "Kies persoon"
        '
        'LabelAfgegevenTitularis
        '
        Me.LabelAfgegevenTitularis.Location = New System.Drawing.Point(544, 128)
        Me.LabelAfgegevenTitularis.Name = "LabelAfgegevenTitularis"
        Me.LabelAfgegevenTitularis.Size = New System.Drawing.Size(72, 23)
        Me.LabelAfgegevenTitularis.TabIndex = 8
        Me.LabelAfgegevenTitularis.Text = "Afgegeven aan:"
        Me.LabelAfgegevenTitularis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEigendomTitularis
        '
        Me.LabelEigendomTitularis.Location = New System.Drawing.Point(544, 16)
        Me.LabelEigendomTitularis.Name = "LabelEigendomTitularis"
        Me.LabelEigendomTitularis.Size = New System.Drawing.Size(80, 40)
        Me.LabelEigendomTitularis.TabIndex = 6
        Me.LabelEigendomTitularis.Text = "Eigendom Titularis:"
        Me.LabelEigendomTitularis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoonAfgegevenSidmar
        '
        Me.ButtonKiesPersoonAfgegevenSidmar.Location = New System.Drawing.Point(456, 128)
        Me.ButtonKiesPersoonAfgegevenSidmar.Name = "ButtonKiesPersoonAfgegevenSidmar"
        Me.ButtonKiesPersoonAfgegevenSidmar.Size = New System.Drawing.Size(80, 21)
        Me.ButtonKiesPersoonAfgegevenSidmar.TabIndex = 5
        Me.ButtonKiesPersoonAfgegevenSidmar.Text = "Kies persoon"
        '
        'LabelAfgegevenAan
        '
        Me.LabelAfgegevenAan.Location = New System.Drawing.Point(8, 128)
        Me.LabelAfgegevenAan.Name = "LabelAfgegevenAan"
        Me.LabelAfgegevenAan.Size = New System.Drawing.Size(112, 23)
        Me.LabelAfgegevenAan.TabIndex = 2
        Me.LabelAfgegevenAan.Text = "Afgegeven aan:"
        Me.LabelAfgegevenAan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEigendomSidmar
        '
        Me.LabelEigendomSidmar.AutoSize = True
        Me.LabelEigendomSidmar.Location = New System.Drawing.Point(8, 16)
        Me.LabelEigendomSidmar.Name = "LabelEigendomSidmar"
        Me.LabelEigendomSidmar.Size = New System.Drawing.Size(119, 13)
        Me.LabelEigendomSidmar.TabIndex = 0
        Me.LabelEigendomSidmar.Text = "Eigendom Arcelor Gent:"
        Me.LabelEigendomSidmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsOpenKleerkast)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 400)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 144)
        Me.GroupBoxOverige.TabIndex = 4
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsOpenKleerkast
        '
        Me.UserControlGeneralFunctionsOpenKleerkast.AutoSize = True
        Me.UserControlGeneralFunctionsOpenKleerkast.DatumOpstelling = New Date(2006, 5, 3, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsOpenKleerkast.GetReportContractant = False
        Me.UserControlGeneralFunctionsOpenKleerkast.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsOpenKleerkast.Name = "UserControlGeneralFunctionsOpenKleerkast"
        Me.UserControlGeneralFunctionsOpenKleerkast.Opsteller = 0
        Me.UserControlGeneralFunctionsOpenKleerkast.Size = New System.Drawing.Size(512, 120)
        Me.UserControlGeneralFunctionsOpenKleerkast.TabIndex = 0
        Me.UserControlGeneralFunctionsOpenKleerkast.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        'GroupBoxInlichtingen
        '
        Me.GroupBoxInlichtingen.Controls.Add(Me.TextBoxInlichtingen)
        Me.GroupBoxInlichtingen.Location = New System.Drawing.Point(600, 72)
        Me.GroupBoxInlichtingen.Name = "GroupBoxInlichtingen"
        Me.GroupBoxInlichtingen.Size = New System.Drawing.Size(408, 168)
        Me.GroupBoxInlichtingen.TabIndex = 3
        Me.GroupBoxInlichtingen.TabStop = False
        Me.GroupBoxInlichtingen.Text = "Bijkomende inlichtingen"
        '
        '_dataRegOpenKleerkast
        '
        Me._dataRegOpenKleerkast.DataSetName = "TDSRegOpenKleerkast"
        Me._dataRegOpenKleerkast.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegOpenKleerkast.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxOpenKleerkast
        '
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxOpenKleerkast.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpenKleerkast.Location = New System.Drawing.Point(0, 544)
        Me.GroupBoxOpenKleerkast.Name = "GroupBoxOpenKleerkast"
        Me.GroupBoxOpenKleerkast.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxOpenKleerkast.TabIndex = 6
        Me.GroupBoxOpenKleerkast.TabStop = False
        Me.GroupBoxOpenKleerkast.Text = "Openmaken kleerkast"
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
        Me._statusBar.Location = New System.Drawing.Point(0, 692)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1003
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
        Me.GroupBoxVerzending.TabIndex = 1004
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonTerugZenden
        '
        Me.ButtonTerugZenden.Location = New System.Drawing.Point(392, 72)
        Me.ButtonTerugZenden.Name = "ButtonTerugZenden"
        Me.ButtonTerugZenden.Size = New System.Drawing.Size(80, 20)
        Me.ButtonTerugZenden.TabIndex = 22
        Me.ButtonTerugZenden.Text = "Stuur terug"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Opm mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Opm mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 19
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
        'FormBewakingOpenmakenKleerkast
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 714)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxOpenKleerkast)
        Me.Controls.Add(Me.GroupBoxInlichtingen)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxInhoud)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Name = "FormBewakingOpenmakenKleerkast"
        Me.Text = "Openmaken Kleerkast"
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInhoud.ResumeLayout(False)
        Me.GroupBoxInhoud.PerformLayout()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        Me.GroupBoxInlichtingen.ResumeLayout(False)
        Me.GroupBoxInlichtingen.PerformLayout()
        CType(Me._dataRegOpenKleerkast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpenKleerkast.ResumeLayout(False)
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVerzending.ResumeLayout(False)
        Me.GroupBoxVerzending.PerformLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Load"
    Private Sub FormBewakingOpenKleerkast_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.setLabelsVerplicht()

            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing

            If _idRegistratie <> -1 Then
                bindRegistratie()

            End If

            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsOpenKleerkast.DatumOpstelling = Now
            End If
            'voor usercontrol
            initializeDataSetConfig()
            initializeDataSetIndividuen()
            bindBijlagen()
            bindBestemmelingen()

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

            Me.UserControlGeneralFunctionsOpenKleerkast.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking
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
            _dataRegOpenKleerkast.Clear()
            Me._dataRegOpenKleerkast.Merge(Me._controller.GetRegOpenKleerkast(_idRegistratie))

            'Algemene registratiegegevens opvullen
            Dim dr As TDSRegOpenKleerkast.BBBEWREGRow
            dr = Me._dataRegOpenKleerkast.BBBEWREG.FindByID_REG(_idRegistratie)

            LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = dr.VLG_REG_JR_BPL & " / " & Year(dr.TMS_OPS_REG)
            End If

            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsOpenKleerkast.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If


            'usercontrol
            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsOpenKleerkast.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsOpenKleerkast.Opsteller = Nothing
            End If

            If Not dr.IsVeraLinkNull Then
                UserControlGeneralFunctionsOpenKleerkast.SetVeraData(dr.VeraReference,
                                                                     dr.VeraLink)
            End If

            If Not dr.IsVerslagContractantYNNull Then
                UserControlGeneralFunctionsOpenKleerkast.GetReportContractant = dr.VerslagContractantYN
            End If

            'Schadegegevens opvullen
            Dim drOpKast As TDSRegOpenKleerkast.BBOPKASTRow
            drOpKast = CType(Me._dataRegOpenKleerkast.BBOPKAST.Rows.Item(0), TDSRegOpenKleerkast.BBOPKASTRow)

            UltraMaskedEditStamnrTitularis.Text = CStr(drOpKast.ID_TITU_KAST)
            If Not drOpKast.IsNM_INDNull And Not drOpKast.IsVNM_INDNull Then
                LabelNaamTitularis.Text = drOpKast.NM_IND.Trim & " " & drOpKast.VNM_IND.Trim
            ElseIf Not drOpKast.IsNM_INDNull Then
                LabelNaamTitularis.Text = drOpKast.NM_IND
            ElseIf Not drOpKast.IsVNM_INDNull Then
                LabelNaamTitularis.Text = drOpKast.VNM_IND
            Else
                LabelNaamTitularis.Text = ""
            End If
            If Not drOpKast.IsID_AFDNull Then
                UltraComboAfdelingen.Value = drOpKast.ID_AFD
            End If

            UltraMaskedEditAanvragDienst.Text = CStr(drOpKast.ID_DNS_OPS_KAST_VR)
            If Not drOpKast.IsNM_IND1Null And Not drOpKast.IsVNM_IND1Null Then
                LabelNaamAanvragDienst.Text = drOpKast.NM_IND1.Trim & " " & drOpKast.VNM_IND1.Trim
            ElseIf Not drOpKast.IsNM_IND1Null Then
                LabelNaamAanvragDienst.Text = drOpKast.NM_IND1
            ElseIf Not drOpKast.IsVNM_IND1Null Then
                LabelNaamAanvragDienst.Text = drOpKast.VNM_IND1
            Else
                LabelNaamAanvragDienst.Text = ""
            End If

            If Not drOpKast.IsSCF_RD_OPN_KASTNull Then
                TextBoxReden.Text = drOpKast.SCF_RD_OPN_KAST
            End If
            If Not drOpKast.IsSCF_EIG_SIDNull Then
                TextBoxEigendomSidmar.Text = drOpKast.SCF_EIG_SID
            End If
            If Not drOpKast.IsSCF_EIG_TITUNull Then
                TextBoxEigendomTitularis.Text = drOpKast.SCF_EIG_TITU
            End If

            UltraMaskedEditAfgegevenSidmar.Text = CStr(drOpKast.ID_OTV_EIG_SID)
            If Not drOpKast.IsNM_IND2Null And Not drOpKast.IsVNM_IND2Null Then
                LabelAfgegevenSidmar.Text = drOpKast.NM_IND2.Trim & " " & drOpKast.VNM_IND2.Trim
            ElseIf Not drOpKast.IsNM_IND2Null Then
                LabelAfgegevenSidmar.Text = drOpKast.NM_IND2
            ElseIf Not drOpKast.IsVNM_IND2Null Then
                LabelAfgegevenSidmar.Text = drOpKast.VNM_IND2
            Else
                LabelAfgegevenSidmar.Text = ""
            End If

            UltraMaskedEditAfgegevenTitularis.Text = CStr(drOpKast.ID_OTV_EIG_TITU)
            If Not drOpKast.IsNM_IND3Null And Not drOpKast.IsVNM_IND3Null Then
                LabelNaamAfgegevenTitularis.Text = drOpKast.NM_IND3.Trim & " " & drOpKast.VNM_IND3.Trim
            ElseIf Not drOpKast.IsNM_IND3Null Then
                LabelNaamAfgegevenTitularis.Text = drOpKast.NM_IND3
            ElseIf Not drOpKast.IsVNM_IND3Null Then
                LabelNaamAfgegevenTitularis.Text = drOpKast.VNM_IND3
            Else
                LabelNaamAfgegevenTitularis.Text = ""
            End If
            If Not drOpKast.IsINF_EX_OPN_KASTNull Then
                TextBoxInlichtingen.Text = drOpKast.INF_EX_OPN_KAST
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

            Me.UserControlGeneralFunctionsOpenKleerkast.setBijlageData(Me._dataRegOpenKleerkast.BBBYLG)
            Me.UserControlGeneralFunctionsOpenKleerkast.setBestemmelingenData(Me._dataRegOpenKleerkast.BBBST)

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventies - bindInterventie()" & vbCrLf & _
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

    Private Sub bindAndSetBEWPersoneel()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

            If _idRegistratie = -1 Then 'nieuwe registratie - naco 08/02/2017
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneelActief())
            Else
                Me._dataBEWPersoneel.Merge(Me._controller.GetBWPersoneel())
            End If

            Me.UserControlGeneralFunctionsOpenKleerkast.setPersoneelData(_dataBEWPersoneel)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBijlagen()
        Try
            Me.UserControlGeneralFunctionsOpenKleerkast.setBijlageData(_dataRegOpenKleerkast.BBBYLG)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub bindBestemmelingen()
        Try
            Me.UserControlGeneralFunctionsOpenKleerkast.setBestemmelingenData(_dataRegOpenKleerkast.BBBST)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Buttonhandlers"
    Private Sub ButtonKiesPersoonTitularis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonTitularis.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen
            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditStamnrTitularis.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamTitularis.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamTitularis.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamTitularis.Text = individu.VNM_IND
                Else
                    LabelNaamTitularis.Text = ""
                End If
            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonAanvragDienst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonAanvragDienst.Click
        Try

        Dim f_ind As FormIndividuen = New FormIndividuen

        f_ind.ShowDialog()

        If Not f_ind.Canceled Then
            Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

            UltraMaskedEditAanvragDienst.Text = CStr(individu.ID_IND)
            If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                LabelNaamAanvragDienst.Text = individu.NM_IND & " " & individu.VNM_IND
            ElseIf Not individu.IsNM_INDNull Then
                LabelNaamAanvragDienst.Text = individu.NM_IND
            ElseIf Not individu.IsVNM_INDNull Then
                LabelNaamAanvragDienst.Text = individu.VNM_IND
            Else
                LabelNaamAanvragDienst.Text = ""
            End If
        End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonAfgegevenSidmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonAfgegevenSidmar.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditAfgegevenSidmar.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelAfgegevenSidmar.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelAfgegevenSidmar.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelAfgegevenSidmar.Text = individu.VNM_IND
                Else
                    LabelAfgegevenSidmar.Text = ""
                End If
            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonAfgegevenTitularis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonAfgegevenTitularis.Click
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen
            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu

                UltraMaskedEditAfgegevenTitularis.Text = CStr(individu.ID_IND)
                If Not individu.IsNM_INDNull And Not individu.IsVNM_INDNull Then
                    LabelNaamAfgegevenTitularis.Text = individu.NM_IND & " " & individu.VNM_IND
                ElseIf Not individu.IsNM_INDNull Then
                    LabelNaamAfgegevenTitularis.Text = individu.NM_IND
                ElseIf Not individu.IsVNM_INDNull Then
                    LabelNaamAfgegevenTitularis.Text = individu.VNM_IND
                Else
                    LabelNaamAfgegevenTitularis.Text = ""
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
            Me.setStatus("")
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
#End Region
#Region "Textboxevents"
    Private Sub UltraMaskedEditStamnrTitularis_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrTitularis.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrTitularis, Me.LabelNaamTitularis)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditStamnrTitularis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditStamnrTitularis.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditStamnrTitularis.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditStamnrTitularis, _
                                              Me.LabelNaamTitularis)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAanvragDienst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditAanvragDienst.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditAanvragDienst.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditAanvragDienst, _
                                              Me.LabelNaamAanvragDienst)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAanvragDienst_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditAanvragDienst.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditAanvragDienst, Me.LabelNaamAanvragDienst)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAfgegevenSidmar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditAfgegevenSidmar.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditAfgegevenSidmar, Me.LabelAfgegevenSidmar)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAfgegevenTitularis_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraMaskedEditAfgegevenTitularis.Leave
        Try
            Me.handleAfterStamnrLeave(Me.UltraMaskedEditAfgegevenTitularis, Me.LabelNaamAfgegevenTitularis)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAfgegevenTitularis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditAfgegevenTitularis.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditAanvragDienst.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditAfgegevenTitularis, Me.LabelNaamAfgegevenTitularis)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraMaskedEditAfgegevenSidmar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraMaskedEditAfgegevenSidmar.KeyDown
        'Doel:   enter-toets opvangen
        'Auteur: Nancy Coppens - 27/12/2006

        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen stamnummer en invullen gegevens
                If Me.UltraMaskedEditAanvragDienst.Text.Trim = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.handleAfterStamnrLeave(Me.UltraMaskedEditAfgegevenSidmar, Me.LabelAfgegevenSidmar)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub handleAfterStamnrLeave(ByRef UltraMaskedEditStamnr As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit, ByRef LabelNaam As Label)
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
                        LabelNaam.Focus()
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
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & " " & ex.StackTrace, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            LabelNaam.Text = ""
        End If
    End Sub
#End Region
#Region "Opslaan"
    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        'Doel: nieuwe interventie toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 27/04/2006
        Try
            If controleVeldenOK() Then
                Me.opslaanRegistratie()

                Me.setStatus("Het openmaken van de kleerkast werd succesvol opgeslagen.")
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

        Dim dsOpenKleerkast As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast
        Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBEWREGRow
        Dim drOpenKleerkast As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBOPKASTRow
        Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBYLGRow
        Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBSTRow

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim id_reg As Integer
        Dim volgnr_reg_jaar As Integer

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try

            dsOpenKleerkast.BBBST.DataSet.Clear()
            dsOpenKleerkast.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsOpenKleerkast.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsOpenKleerkast.getDataBijlagen)

            'Ann vragen
            '1. Transaction
            '2. user hier ophalen die is ingelogd
            If (UserControlGeneralFunctionsOpenKleerkast.CheckBestemmelingen(dsBest) = True) Then

                _controller = New ControllerGetData

                If Me._idRegistratie = -1 Then 'nieuwe alcoholtest
                    'dsAlcoholtest.Merge(Me._controller.GetRegAlcoholtest(1))

                    drRegistratie = dsOpenKleerkast.BBBEWREG.NewBBBEWREGRow
                    '-------------------------
                    _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                    '1. Registratie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = id_reg
                        .ID_OPS = Me.UserControlGeneralFunctionsOpenKleerkast.Opsteller
                        .ID_TY_REG = 6
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsOpenKleerkast.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = volgnr_reg_jaar
                        LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraLink = UserControlGeneralFunctionsOpenKleerkast.GetVeraLink
                    End With
                    dsOpenKleerkast.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                    '2. Openmaken kleerkast
                    '-----------------------
                    drOpenKleerkast = dsOpenKleerkast.BBOPKAST.NewBBOPKASTRow
                    With drOpenKleerkast
                        .ID_REG = id_reg
                        .ID_TITU_KAST = CInt(Me.UltraMaskedEditStamnrTitularis.Text)
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If
                        .ID_DNS_OPS_KAST_VR = CInt(Me.UltraMaskedEditAanvragDienst.Text)
                        .ID_OTV_EIG_SID = CInt(Me.UltraMaskedEditAfgegevenSidmar.Text)
                        .ID_OTV_EIG_TITU = CInt(Me.UltraMaskedEditAfgegevenTitularis.Text)
                        .SCF_RD_OPN_KAST = Me.TextBoxReden.Text
                        .SCF_EIG_SID = Me.TextBoxEigendomSidmar.Text
                        .SCF_EIG_TITU = Me.TextBoxEigendomTitularis.Text
                        .INF_EX_OPN_KAST = Me.TextBoxInlichtingen.Text
                    End With
                    dsOpenKleerkast.BBOPKAST.AddBBOPKASTRow(drOpenKleerkast)

                    '3. Bijlagen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBYL As TDSRegOpenKleerkast.BBBYLGRow 'Dien - aug2008 - migratie 2008
                    Dim drByl As DataRow
                    Dim chronicleID As String

                    For Each drByl In dsByl.Tables(0).Rows
                        drBylagen = dsOpenKleerkast.BBBYLG.NewBBBYLGRow
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
                            chronicleID = UploadOpenmakenKleerkastBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                            'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                            If (chronicleID <> "") Then
                                drBylagen.ID_DOC = chronicleID
                            End If
                        End If

                        dsOpenKleerkast.BBBYLG.AddBBBYLGRow(drBylagen)
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows toevoegen
                    '------------------------------------------------------------
                    'Dim drGridBST As TDSRegOpenKleerkast.BBBSTRow 'Dien - aug2008 - migratie 2008
                    Dim drBest As DataRow
                    For Each drBest In dsBest.Tables(0).Rows
                        drBestemmelingen = dsOpenKleerkast.BBBST.NewBBBSTRow
                        drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST"))
                        drBestemmelingen.ID_IND = CInt(drBest.Item("ID_IND"))
                        drBestemmelingen.ID_REG = id_reg
                        drBestemmelingen.NM_IND = CType(drBest.Item("NM_IND"), String)
                        drBestemmelingen.VNM_IND = CType(drBest.Item("VNM_IND"), String)
                        drBestemmelingen.AD_EMAL_IND = CType(drBest.Item("AD_EMAL_IND"), String)
                        dsOpenKleerkast.BBBST.AddBBBSTRow(drBestemmelingen)
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

                Else 'bestaande OpenmakenKleerkast wijzigen
                    dsOpenKleerkast.Merge(Me._controller.GetRegOpenKleerkast(Me._idRegistratie))
                    drRegistratie = dsOpenKleerkast.BBBEWREG.FindByID_REG(Me._idRegistratie)

                    '1. Interventie-record
                    '---------------------
                    With drRegistratie
                        .ID_REG = Me._idRegistratie
                        .ID_OPS = Me.UserControlGeneralFunctionsOpenKleerkast.Opsteller
                        .ID_TY_REG = 6
                        .TMS_OPS_REG = Me.UserControlGeneralFunctionsOpenKleerkast.getOpstelDatum
                        .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                        .PLA_INC = Me.TextBoxPlaats.Text
                        .VLG_REG_JR_BPL = CInt(.VLG_REG_JR_BPL)
                        .SCF_REG = Me.TextBoxKorteOms.Text
                        .VeraReference = UserControlGeneralFunctionsOpenKleerkast.GetVeraReference
                        .VeraLink = UserControlGeneralFunctionsOpenKleerkast.GetVeraLink
                        .VerslagContractantYN = UserControlGeneralFunctionsOpenKleerkast.GetReportContractant
                    End With

                    '2. OpenmakenKleerkast registereren
                    '----------------------------------
                    drOpenKleerkast = CType(dsOpenKleerkast.BBOPKAST.Rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBOPKASTRow)
                    With drOpenKleerkast
                        .ID_REG = id_reg
                        .ID_TITU_KAST = CInt(Me.UltraMaskedEditStamnrTitularis.Text)
                        If Not Me.UltraComboAfdelingen.Value Is Nothing Then
                            .ID_AFD = CInt(UltraComboAfdelingen.Value)
                        End If
                        .ID_DNS_OPS_KAST_VR = CInt(Me.UltraMaskedEditAanvragDienst.Text)
                        .ID_OTV_EIG_SID = CInt(Me.UltraMaskedEditAfgegevenSidmar.Text)
                        .ID_OTV_EIG_TITU = CInt(Me.UltraMaskedEditAfgegevenTitularis.Text)
                        .SCF_RD_OPN_KAST = Me.TextBoxReden.Text
                        .SCF_EIG_SID = Me.TextBoxEigendomSidmar.Text
                        .SCF_EIG_TITU = Me.TextBoxEigendomTitularis.Text
                        .INF_EX_OPN_KAST = Me.TextBoxInlichtingen.Text
                    End With

                    '3. Bijlagen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBYLGRow

                    For Each drBylg In dsOpenKleerkast.BBBYLG.Rows
                        If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsOpenKleerkast.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                                chronicleID = UploadOpenmakenKleerkastBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                            Else
                                chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                            End If
                        End If

                        If drGridBYLG.RowState = DataRowState.Added Then
                            drBylagen = dsOpenKleerkast.BBBYLG.NewBBBYLGRow

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
                            dsOpenKleerkast.BBBYLG.AddBBBYLGRow(drBylagen)

                        ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                            Dim arrBylg() As DataRow
                            arrBylg = dsOpenKleerkast.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBYLGRow)
                                'drBylagen.ID_BYLG = CInt(drGridBYLG.Item("ID_BYLG"))
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
                                arrBylg = dsOpenKleerkast.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBYLGRow)
                                    If chronicleID <> "" Then
                                        drBylagen.Item("ID_DOC") = ChronicleID
                                    End If
                                End If
                            End If
                        End If
                    Next

                    '4. Bestemmelingen => grid overlopen en New rows()
                    '----------------------------------------------------
                    'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                    Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast.BBBSTRow
                    For Each drBest In dsOpenKleerkast.BBBST.Rows ' dsBest.Tables(0).Rows
                        If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'rij is teruggevonden
                            'ElseIf drTijden.RowState = DataRowState.Deleted Then
                            '    'do nothing
                        Else
                            If dsOpenKleerkast.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'eerst kijken of het record al effectief bestond in de database
                                'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                drBest.Delete() 'rij was verwijderd uit grid
                            End If
                        End If
                    Next

                    Dim drGridBST As DataRow
                    For Each drGridBST In dsBest.Tables(0).Rows
                        If drgridBST.RowState = DataRowState.Added Then
                            drBestemmelingen = dsOpenKleerkast.BBBST.NewBBBSTRow
                            drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                            drBestemmelingen.ID_REG = Me._idRegistratie
                            drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                            If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                drBestemmelingen.AD_EMAL_IND = ""
                            Else
                                drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                            End If
                            dsOpenKleerkast.BBBST.AddBBBSTRow(drBestemmelingen)
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
                Dim ds As New Proxy.BBWService.Mgt.TDSOpenKleerkast
                ds.Merge(dsOpenKleerkast.GetChanges)

                proxy.RegisterRegistratieOpenKleerkast(ds, System.Environment.UserName)
                dsOpenKleerkast.AcceptChanges()

                'als het om een nieuwe interventie gaat, worden volgende velden ingevuld
                If Me._idRegistratie = -1 Then
                    TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsOpenKleerkast.getOpstelDatum)
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
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Function UploadOpenmakenKleerkastBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
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
        If UltraMaskedEditStamnrTitularis.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditAanvragDienst.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditAfgegevenSidmar.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditAfgegevenTitularis.Text = "" Then
            errorBool = False
        End If

        If Not UserControlGeneralFunctionsOpenKleerkast.checkPersoneelOK Then
            errorBool = False
        End If
        Return errorBool
    End Function
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
                                              "OpenmakenKleerkastBewaking", _
                                              "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "OpenmakenKleerkastBewaking")
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
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "OpenmakenKleerkastBewaking", "ID_REG", CStr(Me._idRegistratie), "", "", "", "")

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

#Region "Events"
    Private Sub UserControlGeneralFunctionsOpenmakenKleerkast_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsOpenKleerkast.NieuwBestemmelingen
        '
        '
        Dim f_ind As FormIndividuen = New FormIndividuen(True, GetAfdeling())

        f_ind.ShowDialog()

        If Not f_ind.Canceled Then
            Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
            If Not individu.IsAD_EMAL_INDNull Then
                Me.UserControlGeneralFunctionsOpenKleerkast.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
            Else
                Me.UserControlGeneralFunctionsOpenKleerkast.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
            End If

        End If

        f_ind.Close()
    End Sub

    Private Sub FormBewakingOpenmakenKleerkast_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.setStatus("")
    End Sub
#End Region

#Region "Functions"

    Private Function GetAfdeling() As String
        Return UltraComboAfdelingen.Text
    End Function

    Private Sub setStatus(ByVal statusText As String)
        Me._statusBar.SetStatusbarInfo(statusText)
    End Sub

    Private Sub setLabelsVerplicht()
        '        Private Function controleVeldenOK() As Boolean
        '    Dim errorBool As Boolean = True
        '    _errorString &= "Volgende velden dienen verplicht ingevuld te worden: "
        '    If UltraDateTimeEditorDatum.Text = "" Then
        '        _errorString &= vbCrLf & "- Datum"
        '        errorBool = False
        '    End If
        '    If UltraMaskedEditUur.Text = "__:__" Or UltraMaskedEditUur.Text = ":" Then
        '        _errorString &= vbCrLf & "- Uur"
        '        errorBool = False
        '    End If
        '    If TextBoxPlaats.Text = "" Then
        '        _errorString &= vbCrLf & "- Plaats"
        '        errorBool = False
        '    End If
        '    If UltraMaskedEditStamnrTitularis.Text = "" Then
        '        _errorString &= vbCrLf & "- Naam titularis"
        '        errorBool = False
        '    End If
        '    If UltraMaskedEditAanvragDienst.Text = "" Then
        '        _errorString &= vbCrLf & "- Naam aanvragende dienst"
        '        errorBool = False
        '    End If
        '    If UltraMaskedEditAfgegevenSidmar.Text = "" Then
        '        _errorString &= vbCrLf & "- Naam afgegeven sidmar"
        '        errorBool = False
        '    End If
        '    If UltraMaskedEditAfgegevenTitularis.Text = "" Then
        '        _errorString &= vbCrLf & "- Naam afgegeven titularis"
        '        errorBool = False
        '    End If

        '    If Not UserControlGeneralFunctionsOpenKleerkast.checkPersoneelOK Then
        '        _errorString &= vbCrLf & "- Opsteller"
        '        errorBool = False
        '    End If
        '    Return errorBool
        'End Function
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelTitularis.Text &= " *"
        LabelAanvragDienst.Text &= " *"
        LabelAfgegevenAan.Text &= " *"
        LabelAfgegevenTitularis.Text &= " *"
    End Sub
#End Region

#Region "Datasets"
    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsOpenKleerkast.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub initializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
        UserControlGeneralFunctionsOpenKleerkast.setDataSetIndividuen("bewaking", _dataIndividuen)
    End Sub
#End Region

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
                Me.opslaanRegistratie()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf & _
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                            "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                            "Opsteller:         " & UserControlGeneralFunctionsOpenKleerkast.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingOpenmakenKleerkast - ButtonVerzendingBBW_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsOpenKleerkast.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingOpenmakenKleerkast - ButtonGoedkeuring_Click()" & vbCrLf & _
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
                        "Opsteller:         " & UserControlGeneralFunctionsOpenKleerkast.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingOpenmakenKleerkast - ButtonTerugZenden_Click()" & vbCrLf & _
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
            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsOpenKleerkast.getDataBestemmelingen.Tables(0).Rows
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
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsOpenKleerkast.getDataBijlagen.Tables(0).Rows
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

                textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Korte omschr:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsOpenKleerkast.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String
                '29 dec 2006 - Dien -toevoegen bijlagen
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsOpenKleerkast.getDataBijlagen.Tables(0).Rows
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
                                                   "OpenmakenKleerkastBewaking", _
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
                            "Form: FormBewakingOpenmakenKleerkast - ButtonVerzendingBest_Click()" & vbCrLf & _
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
            ButtonVerzendingBBW.Enabled = True

            If FormManager.Current.PostOverste Then
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonVerzendingBest.Enabled = False
            ElseIf FormManager.Current.BBWVerantwoordelijke Then
                'do nothing, mag alles zien
                ButtonMailIKP.Visible = True
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or FormManager.Current.Chip Then
                    UltraButtonOverzicht.Enabled = False
                    ButtonMailIKP.Visible = True
                    ButtonMailIKP.Top = UltraButtonOverzicht.Top
                End If

                GroupBoxHoofding.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False
                GroupBoxInlichtingen.Enabled = False
                GroupBoxInhoud.Enabled = False
                GroupBoxOverige.Enabled = False
                UltraButtonAnnuleer.Visible = False
                UltraButtonOpslaan.Enabled = False
                ButtonVerzendingBBW.Enabled = False


                ButtonVerzendingBest.Visible = False
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
                            "Form: FormBewakingOpenmakenKleerkast - intializeMailInfo" & vbCrLf & _
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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsOpenKleerkast.getDataBijlagen.Tables(0).Rows

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
            '    UserControlGeneralFunctionsOpenKleerkast.getDataBijlagen.Tables(0).Rows

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
                "OpenmakenKleerkastBewaking",
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
                             "Form: FormBewakingOpenmakenKleerkast - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class

