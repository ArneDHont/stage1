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
Imports System.Data.SqlTypes

Imports Microsoft.Office.Interop 'mails versturen voor IKP - naco - 30/11/2012
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class FormBewakingAanrijding
    Inherits System.Windows.Forms.Form

    Private _comboLijst As ArrayList
    Private _idRegistratie As Integer = -1
    Private _errorString As String
    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    Friend WithEvents ButtonMailIKP As System.Windows.Forms.Button

    Private _oTdsAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal IdReg As Integer)
        MyBase.New()

        _idRegistratie = IdReg

        'This call is required by the Windows Form Designer.
        InitializeComponent()
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
    Friend WithEvents GroupBoxBetrokkenen As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInlichtingen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxHoofding As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPlaats As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaats As System.Windows.Forms.Label
    Friend WithEvents LabelUur As System.Windows.Forms.Label
    Friend WithEvents LabelDatum As System.Windows.Forms.Label
    Friend WithEvents TextBoxVerslagnummer As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerslagnr As System.Windows.Forms.Label
    Friend WithEvents LabelTitel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxToestand As System.Windows.Forms.GroupBox
    Friend WithEvents TabPageKiezen As System.Windows.Forms.TabPage
    Friend WithEvents LabelToestandTerrein As System.Windows.Forms.Label
    Friend WithEvents LabelAardBodem As System.Windows.Forms.Label
    Friend WithEvents LabelToestandBodem As System.Windows.Forms.Label
    Friend WithEvents LabelBebouwing As System.Windows.Forms.Label
    Friend WithEvents LabelWeg As System.Windows.Forms.Label
    Friend WithEvents LabelVerlichting As System.Windows.Forms.Label
    Friend WithEvents LabelAtmosferisch As System.Windows.Forms.Label
    Friend WithEvents UltraGridBetrokkenen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ButtonDeleteBetrokkene As System.Windows.Forms.Button
    Friend WithEvents ButtonNieuweBetrokkene As System.Windows.Forms.Button
    Friend WithEvents ButtonWijzigBetrokkene As System.Windows.Forms.Button
    Friend WithEvents TabControlToestand As System.Windows.Forms.TabControl
    Friend WithEvents GroupBoxInterventie As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents UserControlGeneralFunctionsAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataBEWPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel
    Friend WithEvents _dataToestanden As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSToestanden
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBoxInlichtingen As System.Windows.Forms.GroupBox
    Friend WithEvents UltraMaskedEditUur As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
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
    Friend WithEvents _dataVaststellerAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVaststellerAanrijding
    Friend WithEvents ComboBoxOverheidVaststelde As System.Windows.Forms.ComboBox
    Friend WithEvents LabelNaamMelder As System.Windows.Forms.Label
    Friend WithEvents UltraMaskedEditStamnrMelder As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents LabelOverheidVaststellen As System.Windows.Forms.Label
    Friend WithEvents TextBoxPlaatsVoorval As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRelaas As System.Windows.Forms.TextBox
    Friend WithEvents LabelPlaatsVoorval As System.Windows.Forms.Label
    Friend WithEvents LabelRelaas As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesPersoon As System.Windows.Forms.Button
    Friend WithEvents GroupBoxAlgemeneGegevens As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxToestandTerrein As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAardBodem As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxToestandBodem As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBebouwing As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxWeg As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxVerlichting As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAtmosferisch As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMelder As System.Windows.Forms.Label
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents UltraDateTimeEditorDatum As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents _dataAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents lblZichtbaarheid As System.Windows.Forms.Label
    Friend WithEvents lblWindrichting As System.Windows.Forms.Label
    Friend WithEvents lblWindkracht As System.Windows.Forms.Label
    Friend WithEvents txtZichtbaarheid As System.Windows.Forms.TextBox
    Friend WithEvents txtWindrichting As System.Windows.Forms.TextBox
    Friend WithEvents txtWindkracht As System.Windows.Forms.TextBox
    Friend WithEvents TabPageVoorval As System.Windows.Forms.TabPage
    Friend WithEvents txtVoorval As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKorteOms As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
    Friend WithEvents LabelVolgnr As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingAanrijding))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBTROGV", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BTRK_OGV")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND_BTRK", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_BTRK")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BRK_TSP")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_VZK")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_POLIS")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROMP_LTSL")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAT_LTSL")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KAR_TSP")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_IND_TSP_BRTK")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_TRL_VKM_TSP")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_Q_KG_VKM_TSP")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RB_NR")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RB_CAT")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RB_DAT_UITG")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RB_PL_UITG")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BTW_NR")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HD_NM_VN")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TSP")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ButtonDeleteBetrokkene = New System.Windows.Forms.Button()
        Me.ButtonNieuweBetrokkene = New System.Windows.Forms.Button()
        Me.GroupBoxBetrokkenen = New System.Windows.Forms.GroupBox()
        Me.UltraGridBetrokkenen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataAanrijding = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding()
        Me.ButtonWijzigBetrokkene = New System.Windows.Forms.Button()
        Me._dataVaststellerAanrijding = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVaststellerAanrijding()
        Me.TextBoxInlichtingen = New System.Windows.Forms.TextBox()
        Me.GroupBoxHoofding = New System.Windows.Forms.GroupBox()
        Me.LabelVolgnr = New System.Windows.Forms.Label()
        Me.TextBoxKorteOms = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UltraMaskedEditUur = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxPlaats = New System.Windows.Forms.TextBox()
        Me.LabelPlaats = New System.Windows.Forms.Label()
        Me.LabelUur = New System.Windows.Forms.Label()
        Me.LabelDatum = New System.Windows.Forms.Label()
        Me.TextBoxVerslagnummer = New System.Windows.Forms.TextBox()
        Me.LabelVerslagnr = New System.Windows.Forms.Label()
        Me.LabelTitel = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorDatum = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.TabControlToestand = New System.Windows.Forms.TabControl()
        Me.TabPageKiezen = New System.Windows.Forms.TabPage()
        Me.txtWindkracht = New System.Windows.Forms.TextBox()
        Me.txtWindrichting = New System.Windows.Forms.TextBox()
        Me.txtZichtbaarheid = New System.Windows.Forms.TextBox()
        Me.lblWindkracht = New System.Windows.Forms.Label()
        Me.lblWindrichting = New System.Windows.Forms.Label()
        Me.lblZichtbaarheid = New System.Windows.Forms.Label()
        Me.ComboBoxAtmosferisch = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVerlichting = New System.Windows.Forms.ComboBox()
        Me.ComboBoxWeg = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBebouwing = New System.Windows.Forms.ComboBox()
        Me.ComboBoxToestandBodem = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAardBodem = New System.Windows.Forms.ComboBox()
        Me.ComboBoxToestandTerrein = New System.Windows.Forms.ComboBox()
        Me.LabelAtmosferisch = New System.Windows.Forms.Label()
        Me.LabelVerlichting = New System.Windows.Forms.Label()
        Me.LabelWeg = New System.Windows.Forms.Label()
        Me.LabelBebouwing = New System.Windows.Forms.Label()
        Me.LabelToestandBodem = New System.Windows.Forms.Label()
        Me.LabelAardBodem = New System.Windows.Forms.Label()
        Me.LabelToestandTerrein = New System.Windows.Forms.Label()
        Me.TabPageVoorval = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVoorval = New System.Windows.Forms.TextBox()
        Me._dataToestanden = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSToestanden()
        Me.GroupBoxToestand = New System.Windows.Forms.GroupBox()
        Me.GroupBoxInterventie = New System.Windows.Forms.GroupBox()
        Me.ButtonMailIKP = New System.Windows.Forms.Button()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsAanrijding = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me._dataBEWPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBWPersoneel()
        Me.GroupBoxInlichtingen = New System.Windows.Forms.GroupBox()
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
        Me.ComboBoxOverheidVaststelde = New System.Windows.Forms.ComboBox()
        Me.LabelMelder = New System.Windows.Forms.Label()
        Me.LabelNaamMelder = New System.Windows.Forms.Label()
        Me.UltraMaskedEditStamnrMelder = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.LabelOverheidVaststellen = New System.Windows.Forms.Label()
        Me.TextBoxPlaatsVoorval = New System.Windows.Forms.TextBox()
        Me.TextBoxRelaas = New System.Windows.Forms.TextBox()
        Me.LabelPlaatsVoorval = New System.Windows.Forms.Label()
        Me.LabelRelaas = New System.Windows.Forms.Label()
        Me.ButtonKiesPersoon = New System.Windows.Forms.Button()
        Me.GroupBoxAlgemeneGegevens = New System.Windows.Forms.GroupBox()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me.GroupBoxBetrokkenen.SuspendLayout()
        CType(Me.UltraGridBetrokkenen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAanrijding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVaststellerAanrijding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxHoofding.SuspendLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlToestand.SuspendLayout()
        Me.TabPageKiezen.SuspendLayout()
        Me.TabPageVoorval.SuspendLayout()
        CType(Me._dataToestanden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxToestand.SuspendLayout()
        Me.GroupBoxInterventie.SuspendLayout()
        Me.GroupBoxOverige.SuspendLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInlichtingen.SuspendLayout()
        Me.GroupBoxVerzending.SuspendLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlgemeneGegevens.SuspendLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDeleteBetrokkene
        '
        Me.ButtonDeleteBetrokkene.Image = CType(resources.GetObject("ButtonDeleteBetrokkene.Image"), System.Drawing.Image)
        Me.ButtonDeleteBetrokkene.Location = New System.Drawing.Point(592, 64)
        Me.ButtonDeleteBetrokkene.Name = "ButtonDeleteBetrokkene"
        Me.ButtonDeleteBetrokkene.Size = New System.Drawing.Size(24, 24)
        Me.ButtonDeleteBetrokkene.TabIndex = 30
        '
        'ButtonNieuweBetrokkene
        '
        Me.ButtonNieuweBetrokkene.Image = CType(resources.GetObject("ButtonNieuweBetrokkene.Image"), System.Drawing.Image)
        Me.ButtonNieuweBetrokkene.Location = New System.Drawing.Point(592, 16)
        Me.ButtonNieuweBetrokkene.Name = "ButtonNieuweBetrokkene"
        Me.ButtonNieuweBetrokkene.Size = New System.Drawing.Size(24, 24)
        Me.ButtonNieuweBetrokkene.TabIndex = 29
        '
        'GroupBoxBetrokkenen
        '
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonDeleteBetrokkene)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonNieuweBetrokkene)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.UltraGridBetrokkenen)
        Me.GroupBoxBetrokkenen.Controls.Add(Me.ButtonWijzigBetrokkene)
        Me.GroupBoxBetrokkenen.Location = New System.Drawing.Point(0, 272)
        Me.GroupBoxBetrokkenen.Name = "GroupBoxBetrokkenen"
        Me.GroupBoxBetrokkenen.Size = New System.Drawing.Size(624, 144)
        Me.GroupBoxBetrokkenen.TabIndex = 19
        Me.GroupBoxBetrokkenen.TabStop = False
        Me.GroupBoxBetrokkenen.Text = "Betrokkenen"
        '
        'UltraGridBetrokkenen
        '
        Me.UltraGridBetrokkenen.DataMember = "BBBTROGV"
        Me.UltraGridBetrokkenen.DataSource = Me._dataAanrijding
        Me.UltraGridBetrokkenen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 30
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 22
        UltraGridColumn3.Header.Caption = "Stamnummer"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 157
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 23
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 40
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 41
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 38
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 45
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 41
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 40
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 65
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 76
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 93
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 52
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 56
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 91
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 102
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 91
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 137
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 118
        UltraGridColumn21.Header.Caption = "Naam"
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.Width = 202
        UltraGridColumn22.Header.Caption = "Voornaam"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.Width = 196
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Me.UltraGridBetrokkenen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance1.FontData.BoldAsString = "False"
        Me.UltraGridBetrokkenen.DisplayLayout.CaptionAppearance = Appearance1
        Me.UltraGridBetrokkenen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBetrokkenen.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBetrokkenen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridBetrokkenen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBetrokkenen.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBetrokkenen.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridBetrokkenen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridBetrokkenen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridBetrokkenen.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridBetrokkenen.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridBetrokkenen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridBetrokkenen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridBetrokkenen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridBetrokkenen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridBetrokkenen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridBetrokkenen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.UltraGridBetrokkenen.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Me.UltraGridBetrokkenen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridBetrokkenen.DisplayLayout.Override.CellPadding = 0
        Appearance8.BackColor = System.Drawing.SystemColors.Control
        Appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance8.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBetrokkenen.DisplayLayout.Override.GroupByRowAppearance = Appearance8
        Me.UltraGridBetrokkenen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridBetrokkenen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridBetrokkenen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance9
        Me.UltraGridBetrokkenen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridBetrokkenen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridBetrokkenen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridBetrokkenen.Location = New System.Drawing.Point(8, 16)
        Me.UltraGridBetrokkenen.Name = "UltraGridBetrokkenen"
        Me.UltraGridBetrokkenen.Size = New System.Drawing.Size(576, 120)
        Me.UltraGridBetrokkenen.TabIndex = 0
        '
        '_dataAanrijding
        '
        Me._dataAanrijding.DataSetName = "TDSAanrijding"
        Me._dataAanrijding.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAanrijding.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonWijzigBetrokkene
        '
        Me.ButtonWijzigBetrokkene.Image = CType(resources.GetObject("ButtonWijzigBetrokkene.Image"), System.Drawing.Image)
        Me.ButtonWijzigBetrokkene.Location = New System.Drawing.Point(592, 40)
        Me.ButtonWijzigBetrokkene.Name = "ButtonWijzigBetrokkene"
        Me.ButtonWijzigBetrokkene.Size = New System.Drawing.Size(24, 24)
        Me.ButtonWijzigBetrokkene.TabIndex = 20
        '
        '_dataVaststellerAanrijding
        '
        Me._dataVaststellerAanrijding.DataSetName = "TDSVaststellerAanrijding"
        Me._dataVaststellerAanrijding.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataVaststellerAanrijding.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxInlichtingen
        '
        Me.TextBoxInlichtingen.Location = New System.Drawing.Point(8, 16)
        Me.TextBoxInlichtingen.MaxLength = 200
        Me.TextBoxInlichtingen.Multiline = True
        Me.TextBoxInlichtingen.Name = "TextBoxInlichtingen"
        Me.TextBoxInlichtingen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInlichtingen.Size = New System.Drawing.Size(360, 96)
        Me.TextBoxInlichtingen.TabIndex = 0
        '
        'GroupBoxHoofding
        '
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVolgnr)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxKorteOms)
        Me.GroupBoxHoofding.Controls.Add(Me.Label7)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraMaskedEditUur)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelPlaats)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelUur)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelDatum)
        Me.GroupBoxHoofding.Controls.Add(Me.TextBoxVerslagnummer)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelVerslagnr)
        Me.GroupBoxHoofding.Controls.Add(Me.LabelTitel)
        Me.GroupBoxHoofding.Controls.Add(Me.UltraDateTimeEditorDatum)
        Me.GroupBoxHoofding.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxHoofding.Name = "GroupBoxHoofding"
        Me.GroupBoxHoofding.Size = New System.Drawing.Size(1008, 56)
        Me.GroupBoxHoofding.TabIndex = 17
        Me.GroupBoxHoofding.TabStop = False
        Me.GroupBoxHoofding.Text = "Hoofding"
        '
        'LabelVolgnr
        '
        Me.LabelVolgnr.Location = New System.Drawing.Point(136, 16)
        Me.LabelVolgnr.Name = "LabelVolgnr"
        Me.LabelVolgnr.Size = New System.Drawing.Size(8, 16)
        Me.LabelVolgnr.TabIndex = 13
        Me.LabelVolgnr.Visible = False
        '
        'TextBoxKorteOms
        '
        Me.TextBoxKorteOms.Location = New System.Drawing.Point(600, 32)
        Me.TextBoxKorteOms.MaxLength = 200
        Me.TextBoxKorteOms.Name = "TextBoxKorteOms"
        Me.TextBoxKorteOms.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxKorteOms.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Korte omschr.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditUur
        '
        Me.UltraMaskedEditUur.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditUur.InputMask = "{time}"
        Me.UltraMaskedEditUur.Location = New System.Drawing.Point(392, 32)
        Me.UltraMaskedEditUur.Name = "UltraMaskedEditUur"
        Me.UltraMaskedEditUur.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditUur.TabIndex = 2
        Me.UltraMaskedEditUur.Text = ":"
        Me.UltraMaskedEditUur.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxPlaats
        '
        Me.TextBoxPlaats.Location = New System.Drawing.Point(600, 8)
        Me.TextBoxPlaats.MaxLength = 200
        Me.TextBoxPlaats.Name = "TextBoxPlaats"
        Me.TextBoxPlaats.Size = New System.Drawing.Size(400, 20)
        Me.TextBoxPlaats.TabIndex = 3
        '
        'LabelPlaats
        '
        Me.LabelPlaats.AutoSize = True
        Me.LabelPlaats.Location = New System.Drawing.Point(544, 8)
        Me.LabelPlaats.Name = "LabelPlaats"
        Me.LabelPlaats.Size = New System.Drawing.Size(39, 13)
        Me.LabelPlaats.TabIndex = 10
        Me.LabelPlaats.Text = "Plaats:"
        Me.LabelPlaats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUur
        '
        Me.LabelUur.AutoSize = True
        Me.LabelUur.Location = New System.Drawing.Point(352, 32)
        Me.LabelUur.Name = "LabelUur"
        Me.LabelUur.Size = New System.Drawing.Size(27, 13)
        Me.LabelUur.TabIndex = 8
        Me.LabelUur.Text = "Uur:"
        Me.LabelUur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDatum
        '
        Me.LabelDatum.AutoSize = True
        Me.LabelDatum.Location = New System.Drawing.Point(336, 8)
        Me.LabelDatum.Name = "LabelDatum"
        Me.LabelDatum.Size = New System.Drawing.Size(41, 13)
        Me.LabelDatum.TabIndex = 6
        Me.LabelDatum.Text = "Datum:"
        Me.LabelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxVerslagnummer
        '
        Me.TextBoxVerslagnummer.Enabled = False
        Me.TextBoxVerslagnummer.Location = New System.Drawing.Point(208, 24)
        Me.TextBoxVerslagnummer.Name = "TextBoxVerslagnummer"
        Me.TextBoxVerslagnummer.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxVerslagnummer.TabIndex = 0
        '
        'LabelVerslagnr
        '
        Me.LabelVerslagnr.AutoSize = True
        Me.LabelVerslagnr.Location = New System.Drawing.Point(144, 24)
        Me.LabelVerslagnr.Name = "LabelVerslagnr"
        Me.LabelVerslagnr.Size = New System.Drawing.Size(60, 13)
        Me.LabelVerslagnr.TabIndex = 2
        Me.LabelVerslagnr.Text = "Verslag nr.:"
        Me.LabelVerslagnr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTitel
        '
        Me.LabelTitel.AutoSize = True
        Me.LabelTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitel.Location = New System.Drawing.Point(8, 16)
        Me.LabelTitel.Name = "LabelTitel"
        Me.LabelTitel.Size = New System.Drawing.Size(131, 29)
        Me.LabelTitel.TabIndex = 1
        Me.LabelTitel.Text = "Aanrijding"
        Me.LabelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UltraDateTimeEditorDatum
        '
        Me.UltraDateTimeEditorDatum.Location = New System.Drawing.Point(392, 8)
        Me.UltraDateTimeEditorDatum.Name = "UltraDateTimeEditorDatum"
        Me.UltraDateTimeEditorDatum.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorDatum.TabIndex = 1
        Me.UltraDateTimeEditorDatum.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TabControlToestand
        '
        Me.TabControlToestand.Controls.Add(Me.TabPageKiezen)
        Me.TabControlToestand.Controls.Add(Me.TabPageVoorval)
        Me.TabControlToestand.Location = New System.Drawing.Point(8, 16)
        Me.TabControlToestand.Name = "TabControlToestand"
        Me.TabControlToestand.SelectedIndex = 0
        Me.TabControlToestand.Size = New System.Drawing.Size(360, 216)
        Me.TabControlToestand.TabIndex = 0
        '
        'TabPageKiezen
        '
        Me.TabPageKiezen.Controls.Add(Me.txtWindkracht)
        Me.TabPageKiezen.Controls.Add(Me.txtWindrichting)
        Me.TabPageKiezen.Controls.Add(Me.txtZichtbaarheid)
        Me.TabPageKiezen.Controls.Add(Me.lblWindkracht)
        Me.TabPageKiezen.Controls.Add(Me.lblWindrichting)
        Me.TabPageKiezen.Controls.Add(Me.lblZichtbaarheid)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxAtmosferisch)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxVerlichting)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxWeg)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxBebouwing)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxToestandBodem)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxAardBodem)
        Me.TabPageKiezen.Controls.Add(Me.ComboBoxToestandTerrein)
        Me.TabPageKiezen.Controls.Add(Me.LabelAtmosferisch)
        Me.TabPageKiezen.Controls.Add(Me.LabelVerlichting)
        Me.TabPageKiezen.Controls.Add(Me.LabelWeg)
        Me.TabPageKiezen.Controls.Add(Me.LabelBebouwing)
        Me.TabPageKiezen.Controls.Add(Me.LabelToestandBodem)
        Me.TabPageKiezen.Controls.Add(Me.LabelAardBodem)
        Me.TabPageKiezen.Controls.Add(Me.LabelToestandTerrein)
        Me.TabPageKiezen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageKiezen.Name = "TabPageKiezen"
        Me.TabPageKiezen.Size = New System.Drawing.Size(352, 190)
        Me.TabPageKiezen.TabIndex = 0
        Me.TabPageKiezen.Text = "Kiezen"
        '
        'txtWindkracht
        '
        Me.txtWindkracht.Location = New System.Drawing.Point(272, 56)
        Me.txtWindkracht.MaxLength = 500
        Me.txtWindkracht.Name = "txtWindkracht"
        Me.txtWindkracht.Size = New System.Drawing.Size(72, 20)
        Me.txtWindkracht.TabIndex = 18
        '
        'txtWindrichting
        '
        Me.txtWindrichting.Location = New System.Drawing.Point(272, 32)
        Me.txtWindrichting.MaxLength = 500
        Me.txtWindrichting.Name = "txtWindrichting"
        Me.txtWindrichting.Size = New System.Drawing.Size(72, 20)
        Me.txtWindrichting.TabIndex = 17
        '
        'txtZichtbaarheid
        '
        Me.txtZichtbaarheid.Location = New System.Drawing.Point(272, 8)
        Me.txtZichtbaarheid.MaxLength = 500
        Me.txtZichtbaarheid.Name = "txtZichtbaarheid"
        Me.txtZichtbaarheid.Size = New System.Drawing.Size(72, 20)
        Me.txtZichtbaarheid.TabIndex = 16
        '
        'lblWindkracht
        '
        Me.lblWindkracht.Location = New System.Drawing.Point(200, 56)
        Me.lblWindkracht.Name = "lblWindkracht"
        Me.lblWindkracht.Size = New System.Drawing.Size(80, 23)
        Me.lblWindkracht.TabIndex = 15
        Me.lblWindkracht.Text = "Windkracht:"
        Me.lblWindkracht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWindrichting
        '
        Me.lblWindrichting.Location = New System.Drawing.Point(200, 32)
        Me.lblWindrichting.Name = "lblWindrichting"
        Me.lblWindrichting.Size = New System.Drawing.Size(80, 23)
        Me.lblWindrichting.TabIndex = 14
        Me.lblWindrichting.Text = "Windrichting:"
        Me.lblWindrichting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblZichtbaarheid
        '
        Me.lblZichtbaarheid.Location = New System.Drawing.Point(200, 8)
        Me.lblZichtbaarheid.Name = "lblZichtbaarheid"
        Me.lblZichtbaarheid.Size = New System.Drawing.Size(80, 23)
        Me.lblZichtbaarheid.TabIndex = 13
        Me.lblZichtbaarheid.Text = "Zichtbaarheid:"
        Me.lblZichtbaarheid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxAtmosferisch
        '
        Me.ComboBoxAtmosferisch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAtmosferisch.Location = New System.Drawing.Point(104, 152)
        Me.ComboBoxAtmosferisch.Name = "ComboBoxAtmosferisch"
        Me.ComboBoxAtmosferisch.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxAtmosferisch.TabIndex = 6
        '
        'ComboBoxVerlichting
        '
        Me.ComboBoxVerlichting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVerlichting.Location = New System.Drawing.Point(104, 128)
        Me.ComboBoxVerlichting.Name = "ComboBoxVerlichting"
        Me.ComboBoxVerlichting.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxVerlichting.TabIndex = 5
        '
        'ComboBoxWeg
        '
        Me.ComboBoxWeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWeg.Location = New System.Drawing.Point(104, 104)
        Me.ComboBoxWeg.Name = "ComboBoxWeg"
        Me.ComboBoxWeg.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxWeg.TabIndex = 4
        '
        'ComboBoxBebouwing
        '
        Me.ComboBoxBebouwing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBebouwing.Location = New System.Drawing.Point(104, 80)
        Me.ComboBoxBebouwing.Name = "ComboBoxBebouwing"
        Me.ComboBoxBebouwing.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxBebouwing.TabIndex = 3
        '
        'ComboBoxToestandBodem
        '
        Me.ComboBoxToestandBodem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxToestandBodem.Location = New System.Drawing.Point(104, 56)
        Me.ComboBoxToestandBodem.Name = "ComboBoxToestandBodem"
        Me.ComboBoxToestandBodem.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxToestandBodem.TabIndex = 2
        '
        'ComboBoxAardBodem
        '
        Me.ComboBoxAardBodem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAardBodem.Location = New System.Drawing.Point(104, 32)
        Me.ComboBoxAardBodem.Name = "ComboBoxAardBodem"
        Me.ComboBoxAardBodem.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxAardBodem.TabIndex = 1
        '
        'ComboBoxToestandTerrein
        '
        Me.ComboBoxToestandTerrein.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxToestandTerrein.Location = New System.Drawing.Point(104, 8)
        Me.ComboBoxToestandTerrein.Name = "ComboBoxToestandTerrein"
        Me.ComboBoxToestandTerrein.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxToestandTerrein.TabIndex = 0
        '
        'LabelAtmosferisch
        '
        Me.LabelAtmosferisch.Location = New System.Drawing.Point(8, 152)
        Me.LabelAtmosferisch.Name = "LabelAtmosferisch"
        Me.LabelAtmosferisch.Size = New System.Drawing.Size(96, 23)
        Me.LabelAtmosferisch.TabIndex = 12
        Me.LabelAtmosferisch.Text = "Atmosferische toestand:"
        Me.LabelAtmosferisch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerlichting
        '
        Me.LabelVerlichting.Location = New System.Drawing.Point(8, 128)
        Me.LabelVerlichting.Name = "LabelVerlichting"
        Me.LabelVerlichting.Size = New System.Drawing.Size(100, 23)
        Me.LabelVerlichting.TabIndex = 10
        Me.LabelVerlichting.Text = "Verlichting:"
        Me.LabelVerlichting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelWeg
        '
        Me.LabelWeg.Location = New System.Drawing.Point(8, 104)
        Me.LabelWeg.Name = "LabelWeg"
        Me.LabelWeg.Size = New System.Drawing.Size(100, 23)
        Me.LabelWeg.TabIndex = 8
        Me.LabelWeg.Text = "Weg:"
        Me.LabelWeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelBebouwing
        '
        Me.LabelBebouwing.Location = New System.Drawing.Point(8, 80)
        Me.LabelBebouwing.Name = "LabelBebouwing"
        Me.LabelBebouwing.Size = New System.Drawing.Size(100, 23)
        Me.LabelBebouwing.TabIndex = 6
        Me.LabelBebouwing.Text = "Bebouwing:"
        Me.LabelBebouwing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelToestandBodem
        '
        Me.LabelToestandBodem.Location = New System.Drawing.Point(8, 56)
        Me.LabelToestandBodem.Name = "LabelToestandBodem"
        Me.LabelToestandBodem.Size = New System.Drawing.Size(136, 23)
        Me.LabelToestandBodem.TabIndex = 4
        Me.LabelToestandBodem.Text = "Toestand bodem:"
        Me.LabelToestandBodem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelAardBodem
        '
        Me.LabelAardBodem.Location = New System.Drawing.Point(8, 32)
        Me.LabelAardBodem.Name = "LabelAardBodem"
        Me.LabelAardBodem.Size = New System.Drawing.Size(112, 23)
        Me.LabelAardBodem.TabIndex = 2
        Me.LabelAardBodem.Text = "Aard bodem:"
        Me.LabelAardBodem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelToestandTerrein
        '
        Me.LabelToestandTerrein.Location = New System.Drawing.Point(8, 8)
        Me.LabelToestandTerrein.Name = "LabelToestandTerrein"
        Me.LabelToestandTerrein.Size = New System.Drawing.Size(96, 23)
        Me.LabelToestandTerrein.TabIndex = 1
        Me.LabelToestandTerrein.Text = "Toestand terrein:"
        Me.LabelToestandTerrein.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageVoorval
        '
        Me.TabPageVoorval.Controls.Add(Me.Label3)
        Me.TabPageVoorval.Controls.Add(Me.Label2)
        Me.TabPageVoorval.Controls.Add(Me.Label1)
        Me.TabPageVoorval.Controls.Add(Me.txtVoorval)
        Me.TabPageVoorval.Location = New System.Drawing.Point(4, 22)
        Me.TabPageVoorval.Name = "TabPageVoorval"
        Me.TabPageVoorval.Size = New System.Drawing.Size(352, 190)
        Me.TabPageVoorval.TabIndex = 1
        Me.TabPageVoorval.Text = "Voorval"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "heeft voorgedaan."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "dat zich"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Om ... uur verwittigd door ..."
        '
        'txtVoorval
        '
        Me.txtVoorval.Location = New System.Drawing.Point(56, 40)
        Me.txtVoorval.Multiline = True
        Me.txtVoorval.Name = "txtVoorval"
        Me.txtVoorval.Size = New System.Drawing.Size(104, 24)
        Me.txtVoorval.TabIndex = 0
        Me.txtVoorval.Text = "een aanrijding"
        '
        '_dataToestanden
        '
        Me._dataToestanden.DataSetName = "TDSToestanden"
        Me._dataToestanden.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataToestanden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxToestand
        '
        Me.GroupBoxToestand.Controls.Add(Me.TabControlToestand)
        Me.GroupBoxToestand.Location = New System.Drawing.Point(632, 56)
        Me.GroupBoxToestand.Name = "GroupBoxToestand"
        Me.GroupBoxToestand.Size = New System.Drawing.Size(376, 240)
        Me.GroupBoxToestand.TabIndex = 21
        Me.GroupBoxToestand.TabStop = False
        Me.GroupBoxToestand.Text = "Toestand"
        '
        'GroupBoxInterventie
        '
        Me.GroupBoxInterventie.Controls.Add(Me.ButtonMailIKP)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxInterventie.Location = New System.Drawing.Point(0, 560)
        Me.GroupBoxInterventie.Name = "GroupBoxInterventie"
        Me.GroupBoxInterventie.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxInterventie.TabIndex = 33
        Me.GroupBoxInterventie.TabStop = False
        Me.GroupBoxInterventie.Text = "Aanrijding"
        '
        'ButtonMailIKP
        '
        Me.ButtonMailIKP.Image = CType(resources.GetObject("ButtonMailIKP.Image"), System.Drawing.Image)
        Me.ButtonMailIKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMailIKP.Location = New System.Drawing.Point(310, 25)
        Me.ButtonMailIKP.Name = "ButtonMailIKP"
        Me.ButtonMailIKP.Size = New System.Drawing.Size(108, 23)
        Me.ButtonMailIKP.TabIndex = 9
        Me.ButtonMailIKP.Text = "Mail IKP/PEB"
        Me.ButtonMailIKP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMailIKP.UseVisualStyleBackColor = True
        Me.ButtonMailIKP.Visible = False
        '
        'UltraButtonAfdrukken
        '
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance10
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 13)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 6
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonAnnuleer
        '
        Appearance11.Image = CType(resources.GetObject("Appearance11.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance11
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(8, 13)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 5
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance12.Image = CType(resources.GetObject("Appearance12.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance12
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(216, 13)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 0
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraButtonOverzicht
        '
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Me.UltraButtonOverzicht.Appearance = Appearance13
        Me.UltraButtonOverzicht.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOverzicht.Location = New System.Drawing.Point(320, 13)
        Me.UltraButtonOverzicht.Name = "UltraButtonOverzicht"
        Me.UltraButtonOverzicht.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOverzicht.TabIndex = 8
        Me.UltraButtonOverzicht.Text = "Overzicht"
        '
        'UltraButtonSluiten
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance14
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(424, 13)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 1
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsAanrijding)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 416)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 144)
        Me.GroupBoxOverige.TabIndex = 34
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsAanrijding
        '
        Me.UserControlGeneralFunctionsAanrijding.AutoSize = True
        Me.UserControlGeneralFunctionsAanrijding.DatumOpstelling = New Date(2006, 5, 8, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsAanrijding.GetReportContractant = False
        Me.UserControlGeneralFunctionsAanrijding.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsAanrijding.Name = "UserControlGeneralFunctionsAanrijding"
        Me.UserControlGeneralFunctionsAanrijding.Opsteller = 0
        Me.UserControlGeneralFunctionsAanrijding.Size = New System.Drawing.Size(512, 120)
        Me.UserControlGeneralFunctionsAanrijding.TabIndex = 0
        Me.UserControlGeneralFunctionsAanrijding.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        '_dataBEWPersoneel
        '
        Me._dataBEWPersoneel.DataSetName = "TDSBWPersoneel"
        Me._dataBEWPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBEWPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxInlichtingen
        '
        Me.GroupBoxInlichtingen.Controls.Add(Me.TextBoxInlichtingen)
        Me.GroupBoxInlichtingen.Location = New System.Drawing.Point(632, 296)
        Me.GroupBoxInlichtingen.Name = "GroupBoxInlichtingen"
        Me.GroupBoxInlichtingen.Size = New System.Drawing.Size(376, 120)
        Me.GroupBoxInlichtingen.TabIndex = 35
        Me.GroupBoxInlichtingen.TabStop = False
        Me.GroupBoxInlichtingen.Text = "Bijkomende inlichtingen"
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
        Me.GroupBoxVerzending.Location = New System.Drawing.Point(528, 416)
        Me.GroupBoxVerzending.Name = "GroupBoxVerzending"
        Me.GroupBoxVerzending.Size = New System.Drawing.Size(480, 192)
        Me.GroupBoxVerzending.TabIndex = 1005
        Me.GroupBoxVerzending.TabStop = False
        Me.GroupBoxVerzending.Text = "Verzending"
        '
        'ButtonTerugZenden
        '
        Me.ButtonTerugZenden.Location = New System.Drawing.Point(384, 72)
        Me.ButtonTerugZenden.Name = "ButtonTerugZenden"
        Me.ButtonTerugZenden.Size = New System.Drawing.Size(88, 20)
        Me.ButtonTerugZenden.TabIndex = 16
        Me.ButtonTerugZenden.Text = "Stuur terug"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Opm mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Opm mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Opm mail:"
        '
        'UltraDateTimeEditorBestemmelingen
        '
        Me.UltraDateTimeEditorBestemmelingen.Location = New System.Drawing.Point(184, 128)
        Me.UltraDateTimeEditorBestemmelingen.Name = "UltraDateTimeEditorBestemmelingen"
        Me.UltraDateTimeEditorBestemmelingen.ReadOnly = True
        Me.UltraDateTimeEditorBestemmelingen.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorBestemmelingen.TabIndex = 9
        Me.UltraDateTimeEditorBestemmelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorGoedkeuring
        '
        Me.UltraDateTimeEditorGoedkeuring.Location = New System.Drawing.Point(184, 72)
        Me.UltraDateTimeEditorGoedkeuring.Name = "UltraDateTimeEditorGoedkeuring"
        Me.UltraDateTimeEditorGoedkeuring.ReadOnly = True
        Me.UltraDateTimeEditorGoedkeuring.Size = New System.Drawing.Size(88, 21)
        Me.UltraDateTimeEditorGoedkeuring.TabIndex = 5
        Me.UltraDateTimeEditorGoedkeuring.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraDateTimeEditorVerzending
        '
        Me.UltraDateTimeEditorVerzending.Location = New System.Drawing.Point(184, 16)
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
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(288, 72)
        Me.ButtonGoedkeuring.Name = "ButtonGoedkeuring"
        Me.ButtonGoedkeuring.Size = New System.Drawing.Size(88, 20)
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
        'ComboBoxOverheidVaststelde
        '
        Me.ComboBoxOverheidVaststelde.DataSource = Me._dataVaststellerAanrijding
        Me.ComboBoxOverheidVaststelde.DisplayMember = "BBVASTOGV.SCF_VAST_OGV"
        Me.ComboBoxOverheidVaststelde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOverheidVaststelde.ItemHeight = 13
        Me.ComboBoxOverheidVaststelde.Location = New System.Drawing.Point(216, 192)
        Me.ComboBoxOverheidVaststelde.MaxDropDownItems = 3
        Me.ComboBoxOverheidVaststelde.Name = "ComboBoxOverheidVaststelde"
        Me.ComboBoxOverheidVaststelde.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxOverheidVaststelde.TabIndex = 5
        Me.ComboBoxOverheidVaststelde.ValueMember = "BBVASTOGV.ID_VAST_OGV"
        '
        'LabelMelder
        '
        Me.LabelMelder.Location = New System.Drawing.Point(8, 16)
        Me.LabelMelder.Name = "LabelMelder"
        Me.LabelMelder.Size = New System.Drawing.Size(64, 23)
        Me.LabelMelder.TabIndex = 32
        Me.LabelMelder.Text = "Melder:"
        Me.LabelMelder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNaamMelder
        '
        Me.LabelNaamMelder.BackColor = System.Drawing.SystemColors.Control
        Me.LabelNaamMelder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelNaamMelder.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelNaamMelder.Location = New System.Drawing.Point(168, 16)
        Me.LabelNaamMelder.Name = "LabelNaamMelder"
        Me.LabelNaamMelder.Size = New System.Drawing.Size(256, 20)
        Me.LabelNaamMelder.TabIndex = 1
        Me.LabelNaamMelder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraMaskedEditStamnrMelder
        '
        Me.UltraMaskedEditStamnrMelder.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.UltraMaskedEditStamnrMelder.InputMask = "nnnnnnnn"
        Me.UltraMaskedEditStamnrMelder.Location = New System.Drawing.Point(104, 16)
        Me.UltraMaskedEditStamnrMelder.MaxValue = 99999999
        Me.UltraMaskedEditStamnrMelder.Name = "UltraMaskedEditStamnrMelder"
        Me.UltraMaskedEditStamnrMelder.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditStamnrMelder.TabIndex = 0
        Me.UltraMaskedEditStamnrMelder.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'LabelOverheidVaststellen
        '
        Me.LabelOverheidVaststellen.Location = New System.Drawing.Point(8, 192)
        Me.LabelOverheidVaststellen.Name = "LabelOverheidVaststellen"
        Me.LabelOverheidVaststellen.Size = New System.Drawing.Size(200, 21)
        Me.LabelOverheidVaststellen.TabIndex = 27
        Me.LabelOverheidVaststellen.Text = "Overheid die het ongeval vaststelde:"
        Me.LabelOverheidVaststellen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPlaatsVoorval
        '
        Me.TextBoxPlaatsVoorval.Location = New System.Drawing.Point(104, 168)
        Me.TextBoxPlaatsVoorval.Name = "TextBoxPlaatsVoorval"
        Me.TextBoxPlaatsVoorval.Size = New System.Drawing.Size(512, 20)
        Me.TextBoxPlaatsVoorval.TabIndex = 4
        '
        'TextBoxRelaas
        '
        Me.TextBoxRelaas.Location = New System.Drawing.Point(104, 40)
        Me.TextBoxRelaas.Multiline = True
        Me.TextBoxRelaas.Name = "TextBoxRelaas"
        Me.TextBoxRelaas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRelaas.Size = New System.Drawing.Size(512, 128)
        Me.TextBoxRelaas.TabIndex = 3
        '
        'LabelPlaatsVoorval
        '
        Me.LabelPlaatsVoorval.Location = New System.Drawing.Point(8, 168)
        Me.LabelPlaatsVoorval.Name = "LabelPlaatsVoorval"
        Me.LabelPlaatsVoorval.Size = New System.Drawing.Size(96, 23)
        Me.LabelPlaatsVoorval.TabIndex = 23
        Me.LabelPlaatsVoorval.Text = "Plaats voorval:"
        Me.LabelPlaatsVoorval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelRelaas
        '
        Me.LabelRelaas.Location = New System.Drawing.Point(8, 40)
        Me.LabelRelaas.Name = "LabelRelaas"
        Me.LabelRelaas.Size = New System.Drawing.Size(104, 23)
        Me.LabelRelaas.TabIndex = 21
        Me.LabelRelaas.Text = "Relaas der feiten:"
        Me.LabelRelaas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKiesPersoon
        '
        Me.ButtonKiesPersoon.Location = New System.Drawing.Point(432, 16)
        Me.ButtonKiesPersoon.Name = "ButtonKiesPersoon"
        Me.ButtonKiesPersoon.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoon.TabIndex = 2
        Me.ButtonKiesPersoon.Text = "Kies persoon"
        '
        'GroupBoxAlgemeneGegevens
        '
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ComboBoxOverheidVaststelde)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelMelder)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelNaamMelder)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelOverheidVaststellen)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.TextBoxPlaatsVoorval)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.TextBoxRelaas)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelPlaatsVoorval)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.LabelRelaas)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.ButtonKiesPersoon)
        Me.GroupBoxAlgemeneGegevens.Controls.Add(Me.UltraMaskedEditStamnrMelder)
        Me.GroupBoxAlgemeneGegevens.Location = New System.Drawing.Point(0, 56)
        Me.GroupBoxAlgemeneGegevens.Name = "GroupBoxAlgemeneGegevens"
        Me.GroupBoxAlgemeneGegevens.Size = New System.Drawing.Size(624, 216)
        Me.GroupBoxAlgemeneGegevens.TabIndex = 18
        Me.GroupBoxAlgemeneGegevens.TabStop = False
        Me.GroupBoxAlgemeneGegevens.Text = "Algemene gegevens"
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 680)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1006
        Me._statusBar.User = ""
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBewakingAanrijding
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 702)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxVerzending)
        Me.Controls.Add(Me.GroupBoxInlichtingen)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxInterventie)
        Me.Controls.Add(Me.GroupBoxToestand)
        Me.Controls.Add(Me.GroupBoxBetrokkenen)
        Me.Controls.Add(Me.GroupBoxHoofding)
        Me.Controls.Add(Me.GroupBoxAlgemeneGegevens)
        Me.Name = "FormBewakingAanrijding"
        Me.Text = "Registratie Aanrijding"
        Me.GroupBoxBetrokkenen.ResumeLayout(False)
        CType(Me.UltraGridBetrokkenen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAanrijding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVaststellerAanrijding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxHoofding.ResumeLayout(False)
        Me.GroupBoxHoofding.PerformLayout()
        CType(Me.UltraDateTimeEditorDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlToestand.ResumeLayout(False)
        Me.TabPageKiezen.ResumeLayout(False)
        Me.TabPageKiezen.PerformLayout()
        Me.TabPageVoorval.ResumeLayout(False)
        Me.TabPageVoorval.PerformLayout()
        CType(Me._dataToestanden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxToestand.ResumeLayout(False)
        Me.GroupBoxInterventie.ResumeLayout(False)
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        CType(Me._dataBEWPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInlichtingen.ResumeLayout(False)
        Me.GroupBoxInlichtingen.PerformLayout()
        Me.GroupBoxVerzending.ResumeLayout(False)
        Me.GroupBoxVerzending.PerformLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlgemeneGegevens.ResumeLayout(False)
        Me.GroupBoxAlgemeneGegevens.PerformLayout()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Binds"

    Private Sub setToestandCombobox()
        Try
            Dim id_sta As Integer
            Dim id_ty_sta As Integer
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVSTARow

            'Alle combo's leegzetten
            Me.ComboBoxToestandTerrein.SelectedIndex = -1
            Me.ComboBoxAardBodem.SelectedIndex = -1
            Me.ComboBoxToestandBodem.SelectedIndex = -1
            Me.ComboBoxBebouwing.SelectedIndex = -1
            Me.ComboBoxWeg.SelectedIndex = -1
            Me.ComboBoxVerlichting.SelectedIndex = -1
            Me.ComboBoxAtmosferisch.SelectedIndex = -1

            For Each aRow In Me._oTdsAanrijding.BBOGVSTA
                id_sta = aRow.ID_STA()

                id_ty_sta = CType(CType(Me._dataToestanden.BBSTA.Select("ID_STA = " & CStr(id_sta))(0), System.Data.DataRow), Be.Sidmar.RIS.BrandweerBewaking.Client.TDSToestanden.BBSTARow).ID_TY_STA

                Select Case id_ty_sta
                    Case 1 'Toestand van het terrein
                        Me.ComboBoxToestandTerrein.SelectedValue = id_sta
                    Case 2 'Aard van de bodem
                        Me.ComboBoxAardBodem.SelectedValue = id_sta
                    Case 3 'Toestand van de bodem
                        Me.ComboBoxToestandBodem.SelectedValue = id_sta
                    Case 4 'Bebouwing
                        Me.ComboBoxBebouwing.SelectedValue = id_sta
                    Case 5 'Weg
                        Me.ComboBoxWeg.SelectedValue = id_sta
                    Case 6 'Verlichting 
                        Me.ComboBoxVerlichting.SelectedValue = id_sta
                    Case 7 'Atmosferische toestand   
                        Me.ComboBoxAtmosferisch.SelectedValue = id_sta
                End Select
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Private Sub bindComboBoxen()
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

            Dim i As Integer
            Dim comboLijst As ArrayList = New ArrayList
            'Dim comboLijst() As Infragistics.Win.UltraWinGrid.UltraCombo = New Infragistics.Win.UltraWinGrid.UltraCombo
            comboLijst.Add(Me.ComboBoxToestandTerrein)
            comboLijst.Add(Me.ComboBoxAardBodem)
            comboLijst.Add(Me.ComboBoxToestandBodem)
            comboLijst.Add(Me.ComboBoxBebouwing)
            comboLijst.Add(Me.ComboBoxWeg)
            comboLijst.Add(Me.ComboBoxVerlichting)
            comboLijst.Add(Me.ComboBoxAtmosferisch)

            Me._dataToestanden.Merge(Me._controller.GetToestanden())

            For i = 0 To comboLijst.Count - 1
                'Lege rij toevoegen zodat de gebruiker ook "niks" kan selecteren.
                Me._dataToestanden.BBSTA.AddBBSTARow(i + 1, "", "")
                Dim filter As String = "ID_TY_STA=" & i + 1

                Dim combo As ComboBox = CType(comboLijst(i), ComboBox)
                combo.DataSource = _dataToestanden.BBSTA.Select(filter, "SCF_STA")
                combo.DisplayMember = "SCF_STA"
                combo.ValueMember = "ID_STA"
            Next


            'Lege rij toevoegen zodat de gebruiker ook "niks" kan selecteren.
            Me._dataVaststellerAanrijding.BBVASTOGV.AddBBVASTOGVRow("")
            Me._dataVaststellerAanrijding.Merge(Me._controller.GetVaststellerAanrijding())

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerAanrijding - bindComboBoxen" & vbCrLf & _
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

        Me.UserControlGeneralFunctionsAanrijding.setPersoneelData(_dataBEWPersoneel)
    End Sub
#End Region

#Region "Functions"
    Private Sub initializeDataSetConfig()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie))
        UserControlGeneralFunctionsAanrijding.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub setLabelsVerplicht()
        LabelDatum.Text &= " *"
        LabelUur.Text &= " *"
        LabelPlaats.Text &= " *"
        LabelMelder.Text &= " *"
        LabelRelaas.Text &= " *"
        LabelOverheidVaststellen.Text &= " *"
    End Sub
#End Region

#Region "User Control"

    Private Sub UserControlGeneralFunctionsAanrijding_NieuwBestemmelingen(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserControlGeneralFunctionsAanrijding.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, String.Empty)

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    Me.UserControlGeneralFunctionsAanrijding.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                Else
                    Me.UserControlGeneralFunctionsAanrijding.addBestemmeling(Me._idRegistratie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
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

    Private Sub FormBewakingAanrijding_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _oTdsAanrijding = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding
            'Add any initialization after the InitializeComponent() call
            bindAndSetBEWPersoneel()
            bindComboBoxen()
            initializeMailInfo()

            setLabelsVerplicht()
            initializeDataSetConfig()

            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing

            'Siddien - okt 2006
            If Me._idRegistratie > 0 Then
                bindRegistratie()
            End If
            If TextBoxVerslagnummer.Text = "" Then
                UserControlGeneralFunctionsAanrijding.DatumOpstelling = Now
            End If

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

            Me.UserControlGeneralFunctionsAanrijding.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.bewaking

            Me.MdiParent.Activate()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - FormBewakingAanrijding_Load" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindRegistratie()
        'Doel: gegevens aanrijding invullen
        'Auteur: DIen - okt. 2006
        Try

            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            'Ophalen aanrijding 
            _oTdsAanrijding.Clear()
            Me._dataAanrijding.Clear()

            Me._oTdsAanrijding.Merge(Me._controller.GetAanrijding(Me._idRegistratie))

            'Algemene registratieGegevens invullen
            Dim dr As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBEWREGRow
            dr = CType(Me._oTdsAanrijding.BBBEWREG.Rows.Find(Me._idRegistratie), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBEWREGRow)

            If Not dr.IsVLG_REG_JR_BPLNull Then
                TextBoxVerslagnummer.Text = CStr((dr.VLG_REG_JR_BPL()))
                LabelVolgnr.Text = CStr(dr.VLG_REG_JR_BPL)
            End If
            If Not dr.IsTMS_INCNull Then
                UltraDateTimeEditorDatum.DateTime = CType(dr.TMS_INC, Date)
                UltraMaskedEditUur.Text = dr.TMS_INC.ToShortTimeString
            End If

            If Not dr.IsTMS_OPS_REGNull Then
                UserControlGeneralFunctionsAanrijding.DatumOpstelling = dr.TMS_OPS_REG
            End If

            If Not dr.IsPLA_INCNull Then
                TextBoxPlaats.Text = dr.PLA_INC
            End If

            If Not dr.IsSCF_REGNull Then
                TextBoxKorteOms.Text = dr.SCF_REG
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsAanrijding.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsAanrijding.Opsteller = Nothing
            End If

            'Aanrijdinggegevens opvullen
            Dim drAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVTSPRow
            drAanrijding = CType(Me._oTdsAanrijding.BBOGVTSP(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVTSPRow)

            If drAanrijding.IsID_MLDNull = False Then
                Me.UltraMaskedEditStamnrMelder.Value = drAanrijding.ID_MLD()
            End If
            If drAanrijding.IsNM_INDNull = False Then
                Me.LabelNaamMelder.Text = drAanrijding.NM_IND & " "
            End If
            If drAanrijding.IsVNM_INDNull = False Then
                Me.LabelNaamMelder.Text &= drAanrijding.VNM_IND
            End If

            If drAanrijding.IsSCF_LNG_OGVNull = False Then
                Me.TextBoxRelaas.Text = drAanrijding.SCF_LNG_OGV
            End If
            If drAanrijding.IsPLA_OGVNull = False Then
                Me.TextBoxPlaatsVoorval.Text = drAanrijding.PLA_OGV
            End If
            If drAanrijding.IsID_OGV_VASTNull = False Then
                ComboBoxOverheidVaststelde.SelectedValue = drAanrijding.ID_OGV_VAST
            End If
            If drAanrijding.IsINF_EXNull = False Then
                TextBoxInlichtingen.Text = drAanrijding.INF_EX()
            End If
            If drAanrijding.IsGBEUNull = False Then
                Me.txtVoorval.Text = drAanrijding.GBEU
            End If
            If drAanrijding.IsZBHNull = False Then
                Me.txtZichtbaarheid.Text = drAanrijding.ZBH
            End If
            If drAanrijding.IsWND_RICNull = False Then
                Me.txtWindrichting.Text = drAanrijding.WND_RIC
            End If
            If drAanrijding.IsWND_KRNull = False Then
                Me.txtWindkracht.Text = drAanrijding.WND_KR
            End If

            'Betrokkenen
            Me._dataAanrijding.Merge(_oTdsAanrijding)


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
            If Not dr.IsDT_VZ_RAP_NWNull And dr.IsDT_OKNull And dr.IsDT_VZ_BSTNull Then
                ButtonTerugZenden.Enabled = True
            Else
                ButtonTerugZenden.Enabled = False
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

            'Toestanden
            setToestandCombobox()

            Me.UserControlGeneralFunctionsAanrijding.setBijlageData(Me._oTdsAanrijding.BBBYLG)
            Me.UserControlGeneralFunctionsAanrijding.setBestemmelingenData(Me._oTdsAanrijding.BBBST)

            'VRST 11/03/2013 -> VeraReference
            If (Me._oTdsAanrijding.BBBEWREG.Rows.Count > 0) Then
                If Not (Me._oTdsAanrijding.BBBEWREG(0).IsVeraLinkNull) Then
                    Me.UserControlGeneralFunctionsAanrijding.SetVeraData(Me._oTdsAanrijding.BBBEWREG(0).VeraReference,
                                                                         Me._oTdsAanrijding.BBBEWREG(0).VeraLink)
                End If

                If Not (Me._oTdsAanrijding.BBBEWREG(0).IsVerslagContractantYNNull) Then
                    Me.UserControlGeneralFunctionsAanrijding.GetReportContractant = Me._oTdsAanrijding.BBBEWREG(0).VerslagContractantYN
                End If
            End If

            ' Set save button disabled when report has been invalidated
            If IsReportInvalid(_idRegistratie) Then
                UltraButtonOpslaan.Enabled = False
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub UltraButtonAnnuleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAnnuleer.Click
        'Doel: als nieuwe interventie => terug alles leeg zetten
        '      als je bestaande registratie aan het wijzigen was: terug alles zetten zoals het in de database staat
        'Auteur: naco - 21/04/2006

        Try
            'Me.setStatus("")
            'Call Me.bindRegistratie() 'terug ophalen en tonen (zo zit je met de juiste data uit de database)
            'Me.setStatus("De wijzigingen werden ongedaan gemaakt")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - UltraButtonAnnuleer_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub showReport()
        'Doel: print preview van het interventierapport tonen
        'Auteur: Nancy Coppens - 26/04/2006
        'Opgelet: afdrukken kan pas als de interventie is opgeslaan! Dus eerst vragen om de interventie te bewaren

        Try
            Dim f_rap As New FormRapportenPreview

            f_rap.Show()
            f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "RegistratieAanrijding", "ID_REG", CStr(_idRegistratie), "", "", "", "")

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - showReport" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

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

    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        Try
            Me.OpslaanAanrijding()
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

    Private Sub UltraButtonOverzicht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOverzicht.Click
        Try
            FormManager.Current.OpenFormOverzichtBewakingRegistratieEntity(False, True, True)
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

    Private Sub refreshGrid()
        Try
            Me._dataAanrijding.Merge(Me._oTdsAanrijding)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonNieuweBetrokkene_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNieuweBetrokkene.Click
        Try
            Dim oFormBetrokkene As New FormBewakingBetrokkene(Me._idRegistratie, Me._oTdsAanrijding.BBBTROGV, Nothing)
            oFormBetrokkene.ShowDialog(Me)

            refreshGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonWijzigBetrokkene_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWijzigBetrokkene.Click
        Try
            If Not Me.UltraGridBetrokkenen.ActiveRow Is Nothing Then
                Dim id_btrk_ogv As Integer = CInt(Me.UltraGridBetrokkenen.ActiveRow.Cells("ID_BTRK_OGV").Value)

                'opzoeken van rij uit de grid 
                Dim rows() As DataRow = Me._oTdsAanrijding.BBBTROGV.Select("ID_BTRK_OGV = " & CStr(id_btrk_ogv))
                Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow = Nothing
                If rows.Length > 0 Then
                    aRow = CType(rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow)
                End If

                Dim oFormBetrokkene As New FormBewakingBetrokkene(Me._idRegistratie, Me._oTdsAanrijding.BBBTROGV, aRow)
                oFormBetrokkene.ShowDialog(Me)

                Me.refreshGrid()
            Else
                MessageBox.Show("Gelieve een betrokkene te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonDeleteBetrokkene_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteBetrokkene.Click
        Try

            If Not Me.UltraGridBetrokkenen.ActiveRow Is Nothing Then
                Dim id_btrk_ogv As Integer = CInt(Me.UltraGridBetrokkenen.ActiveRow.Cells("ID_BTRK_OGV").Value)

                'opzoeken van rij uit de grid 
                Dim rows() As DataRow = Me._oTdsAanrijding.BBBTROGV.Select("ID_BTRK_OGV = " & CStr(id_btrk_ogv))
                Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow
                If rows.Length > 0 Then
                    aRow = CType(rows(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow)
                    aRow.Delete()

                    Me.refreshGrid()

                Else
                    MessageBox.Show("Gelieve een betrokkene te selecteren uit de grid.", "Selecteer betrokkene", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoon.Click
        Try
            Dim oFrmIndividu As New FormIndividuen(False, String.Empty)
            oFrmIndividu.ShowDialog(Me)

            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow = oFrmIndividu.Individu
            If Not aRow Is Nothing Then
                UltraMaskedEditStamnrMelder.Value = aRow.ID_IND()
                If aRow.IsVNM_INDNull = False Then
                    LabelNaamMelder.Text = aRow.VNM_IND & " "
                End If
                If aRow.IsNM_INDNull = False Then
                    LabelNaamMelder.Text &= aRow.NM_IND
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setGegegevensPersoon(ByVal stamnummer As Integer)
        Try
            Dim oIndividu As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen.BBINDRow
            oIndividu = Me._controller.GetIndividu(stamnummer)
            If oIndividu.BBIND.Count > 0 Then
                aRow = oIndividu.BBIND(0)
                If aRow.IsVNM_INDNull = False Then
                    LabelNaamMelder.Text = aRow.VNM_IND & " "
                End If
                If aRow.IsNM_INDNull = False Then
                    LabelNaamMelder.Text &= aRow.NM_IND
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function controleVeldenok() As Boolean
        If UltraMaskedEditStamnrMelder.Text.Trim = "" Then
            MessageBox.Show("Gelieve een melder te selecteren", "Melder", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        If Me.UserControlGeneralFunctionsAanrijding.Opsteller = 0 Then
            MessageBox.Show("Gelieve de opsteller te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Sub OpslaanAanrijding()
        'Doel:   nieuwe aanrijding toevoegen of bestaande wijzigen
        'Auteur: DIEN okt. 2006

        If controleVeldenok() Then
            Cursor.Current = Cursors.WaitCursor
            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy


            '1. Registratie
            Dim drRegistratie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBEWREGRow
            '2. Aanrijding
            Dim drAanrijding As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVTSPRow
            '3. Bijlagen
            Dim drBylagen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBYLGRow
            '4. Bestemmelingen
            Dim drBestemmelingen As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBSTRow

            Dim dsBest As New DataSet
            Dim dsByl As New DataSet

            Dim id_reg As Integer
            Dim volgnr_reg_jaar As Integer

            Dim arrayOfDeletedChronicleID As New ArrayList

            Try

                _oTdsAanrijding.BBBST.DataSet.Clear()
                _oTdsAanrijding.BBBYLG.DataSet.Clear()

                dsBest.Merge(UserControlGeneralFunctionsAanrijding.getDataBestemmelingen)
                dsByl.Merge(UserControlGeneralFunctionsAanrijding.getDataBijlagen)

                If (UserControlGeneralFunctionsAanrijding.CheckBestemmelingen(dsBest) = True) Then
                    _controller = New ControllerGetData

                    If Me._idRegistratie = -1 Then 'nieuwe aanrijding

                        drRegistratie = Me._oTdsAanrijding.BBBEWREG.NewBBBEWREGRow()

                        '-------------------------
                        _controller.GetMaxValuesRegistratie(CType(UltraDateTimeEditorDatum.Value, DateTime), id_reg, volgnr_reg_jaar)

                        '1. Registratie-record
                        '---------------------
                        With drRegistratie
                            .ID_REG = id_reg
                            .ID_OPS = Me.UserControlGeneralFunctionsAanrijding.Opsteller
                            .ID_TY_REG = 1
                            .TMS_OPS_REG = Me.UserControlGeneralFunctionsAanrijding.getOpstelDatum
                            .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                            .PLA_INC = Me.TextBoxPlaats.Text
                            .VLG_REG_JR_BPL = volgnr_reg_jaar
                            LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                            .SCF_REG = TextBoxKorteOms.Text
                            'VRST - 11/03/2013 
                            .VeraLink = Me.UserControlGeneralFunctionsAanrijding.GetVeraLink
                            .VeraReference = Me.UserControlGeneralFunctionsAanrijding.GetVeraReference
                            .VerslagContractantYN = Me.UserControlGeneralFunctionsAanrijding.GetReportContractant
                            'LabelVolgnr.Text = CStr(.VLG_REG_JR_BPL)
                        End With
                        Me._oTdsAanrijding.BBBEWREG.AddBBBEWREGRow(drRegistratie)

                        '2. Aanrijding
                        '--------------
                        drAanrijding = Me._oTdsAanrijding.BBOGVTSP.NewBBOGVTSPRow()

                        With drAanrijding
                            .ID_REG = id_reg
                            'Id van de melder
                            .ID_MLD = CInt(Me.UltraMaskedEditStamnrMelder.Text)
                            'Relaas der feiten
                            If Not Me.TextBoxRelaas.Text = "" Then
                                .SCF_LNG_OGV = Me.TextBoxRelaas.Text
                            End If
                            'Id van de vaststeller (overheid die het ongeval vaststelde)
                            .ID_OGV_VAST = CInt(ComboBoxOverheidVaststelde.SelectedValue)
                            'Bijkomende informatie
                            If Not TextBoxInlichtingen.Text = "" Then
                                .INF_EX = TextBoxInlichtingen.Text
                            End If
                            'Plaats van de aanrijding 
                            If Not TextBoxPlaatsVoorval.Text = "" Then
                                .PLA_OGV = TextBoxPlaatsVoorval.Text
                            End If
                            'Voorval
                            .GBEU = Me.txtVoorval.Text

                            If Not txtZichtbaarheid.Text = "" Then
                                .ZBH = txtZichtbaarheid.Text
                            End If
                            If Not txtWindrichting.Text = "" Then
                                .WND_RIC = txtWindrichting.Text
                            End If
                            If Not txtWindkracht.Text = "" Then
                                .WND_KR = txtWindkracht.Text
                            End If
                        End With
                        Me._oTdsAanrijding.BBOGVTSP.AddBBOGVTSPRow(drAanrijding)


                        '3. Bijlagen => grid overlopen en New rows toevoegen
                        '------------------------------------------------------------

                        Dim drByl As DataRow
                        Dim chronicleID As String
                        For Each drByl In dsByl.Tables(0).Rows
                            drBylagen = Me._oTdsAanrijding.BBBYLG.NewBBBYLGRow
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
                                chronicleID = UploadAanrijdingBijlageToDocumentum(drByl, volgnr_reg_jaar.ToString)
                                'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                                If (chronicleID <> "") Then
                                    drBylagen.ID_DOC = chronicleID
                                End If
                            End If

                            Me._oTdsAanrijding.BBBYLG.AddBBBYLGRow(drBylagen)
                        Next

                        '4. Bestemmelingen => grid overlopen en New rows toevoegen
                        '------------------------------------------------------------
                        Dim drBest As DataRow
                        For Each drBest In dsBest.Tables(0).Rows
                            drBestemmelingen = Me._oTdsAanrijding.BBBST.NewBBBSTRow
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

                            Me._oTdsAanrijding.BBBST.AddBBBSTRow(drBestemmelingen)
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

                        '6. Toestanden opslaan
                        '-----------------------------------
                        Dim drAanrijdingToestand As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVSTARow

                        '1. toestand van het terrein
                        If Not Me.ComboBoxToestandTerrein.SelectedValue Is Nothing And _
                              Me.ComboBoxToestandTerrein.Text <> "" Then
                            'Toevoegen
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxToestandTerrein.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If

                        '2. Aard van de bodem
                        If Not Me.ComboBoxAardBodem.SelectedValue Is Nothing _
                           And Me.ComboBoxAardBodem.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxAardBodem.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '3. Toestand van de bodem
                        If Not Me.ComboBoxToestandBodem.SelectedValue Is Nothing _
                           And Me.ComboBoxToestandBodem.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxToestandBodem.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '4. Bebouwing 
                        If Not Me.ComboBoxBebouwing.SelectedValue Is Nothing _
                           And Me.ComboBoxBebouwing.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxBebouwing.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '5. weg 
                        If Not Me.ComboBoxWeg.SelectedValue Is Nothing _
                            And Me.ComboBoxWeg.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxWeg.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '6. Verlichting 
                        If Not Me.ComboBoxVerlichting.SelectedValue Is Nothing _
                           And Me.ComboBoxVerlichting.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxVerlichting.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '7. Atmosferische toestand 
                        If Not Me.ComboBoxAtmosferisch.SelectedValue Is Nothing _
                           And Me.ComboBoxAtmosferisch.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxAtmosferisch.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If


                        '7. lijst met betrokkenen
                        '------------------------
                        'deze code ontbrak bij updaten van een bestaande aanrijding
                        'naco - 16/10/2007
                        Dim aBBBTROGVRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow
                        For Each aBBBTROGVRow In Me._dataAanrijding.BBBTROGV.Rows
                            aBBBTROGVRow.ID_REG = id_reg
                        Next

                        '  Dim drNewBetrokkene As DataRow 'Dien - aug2008 - migratie 2008
                        _oTdsAanrijding.Merge(Me._dataAanrijding.BBBTROGV)

                    Else

                        id_reg = Me._idRegistratie

                        'UPDATEN
                        'bestaande aanrijding wijzigen
                        '1. Registratie-record
                        '---------------------
                        _oTdsAanrijding.Merge(Me._controller.GetAanrijding(Me._idRegistratie))
                        drRegistratie = _oTdsAanrijding.BBBEWREG.FindByID_REG(Me._idRegistratie)
                        'drRegistratie = Me._oTdsAanrijding.BBBEWREG(0)
                        With drRegistratie
                            .ID_REG = id_reg
                            .ID_OPS = Me.UserControlGeneralFunctionsAanrijding.Opsteller
                            .ID_TY_REG = 1
                            .TMS_OPS_REG = Me.UserControlGeneralFunctionsAanrijding.getOpstelDatum
                            .TMS_INC = CType(Me.UltraDateTimeEditorDatum.Text & " " & Me.UltraMaskedEditUur.Text, DateTime)
                            .PLA_INC = Me.TextBoxPlaats.Text
                            .SCF_REG = Me.TextBoxKorteOms.Text
                            'VRST - 11/03/2013 
                            .VeraLink = Me.UserControlGeneralFunctionsAanrijding.GetVeraLink
                            .VeraReference = Me.UserControlGeneralFunctionsAanrijding.GetVeraReference
                            .VerslagContractantYN = Me.UserControlGeneralFunctionsAanrijding.GetReportContractant
                        End With

                        '2. Aanrijding
                        '--------------
                        drAanrijding = Me._oTdsAanrijding.BBOGVTSP(0)

                        With drAanrijding
                            .ID_REG = id_reg
                            'Id van de melder
                            .ID_MLD = CInt(Me.UltraMaskedEditStamnrMelder.Text)
                            'Relaas der feiten
                            If Not Me.TextBoxRelaas.Text = "" Then
                                .SCF_LNG_OGV = Me.TextBoxRelaas.Text
                            End If
                            'Id van de vaststeller (overheid die het ongeval vaststelde)
                            .ID_OGV_VAST = CInt(ComboBoxOverheidVaststelde.SelectedValue)
                            'Bijkomende informatie
                            If Not TextBoxInlichtingen.Text = "" Then
                                .INF_EX = TextBoxInlichtingen.Text
                            End If
                            'Plaats van de aanrijding 
                            If Not TextBoxPlaatsVoorval.Text = "" Then
                                .PLA_OGV = TextBoxPlaatsVoorval.Text
                            End If
                            'Voorval
                            .GBEU = Me.txtVoorval.Text
                            'Zichtbaarheid
                            .ZBH = txtZichtbaarheid.Text
                            'windrichting
                            .WND_RIC = txtWindrichting.Text
                            'Windkracht
                            .WND_KR = txtWindkracht.Text
                        End With

                        '3. Bijlagen => grid overlopen en New rows()
                        '----------------------------------------------------
                        'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten

                        Dim drBylg As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBYLGRow

                        For Each drBylg In Me._oTdsAanrijding.BBBYLG.Rows
                            If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                                'rij is teruggevonden
                                'ElseIf drTijden.RowState = DataRowState.Deleted Then
                                '    'do nothing
                            Else
                                If _oTdsAanrijding.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                                    'eerst kijken of het record al effectief bestond in de database
                                    'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                    If (Not drBylg.ID_DOC Is DBNull.Value) Then
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
                                    chronicleID = UploadAanrijdingBijlageToDocumentum(drGridBYLG, LabelVolgnr.Text)
                                Else
                                    chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                                End If
                            End If

                            If drGridBYLG.RowState = DataRowState.Added Then
                                drBylagen = _oTdsAanrijding.BBBYLG.NewBBBYLGRow

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
                                _oTdsAanrijding.BBBYLG.AddBBBYLGRow(drBylagen)

                            ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                                Dim arrBylg() As DataRow
                                arrBylg = _oTdsAanrijding.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                    drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBYLGRow)
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
                                End If
                            ElseIf drGridBYLG.RowState = DataRowState.Unchanged Then
                                'Wanneer een document nog niet is doorgestuurd naar documentum,
                                'mag dit alsnog gebeuren ook al is er niets veranderd aan de registratie
                                If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                                    Dim arrBylg() As DataRow
                                    arrBylg = _oTdsAanrijding.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                                    If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                        drBylagen = DirectCast(arrBylg(0), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBYLGRow)
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
                        Dim drBest As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBSTRow

                        For Each drBest In _oTdsAanrijding.BBBST.Rows
                            If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                'rij is teruggevonden
                                'ElseIf drTijden.RowState = DataRowState.Deleted Then
                                '    'do nothing
                            Else
                                If _oTdsAanrijding.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                                    'eerst kijken of het record al effectief bestond in de database
                                    'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                                    drBest.Delete() 'rij was verwijderd uit grid
                                End If
                            End If
                        Next

                        Dim drGridBST As DataRow
                        For Each drGridBST In dsBest.Tables(0).Rows
                            If drGridBST.RowState = DataRowState.Added Then
                                drBestemmelingen = _oTdsAanrijding.BBBST.NewBBBSTRow
                                drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                                drBestemmelingen.ID_REG = Me._idRegistratie
                                drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                                drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                                If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                                    drBestemmelingen.AD_EMAL_IND = ""
                                Else
                                    drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                                End If
                                _oTdsAanrijding.BBBST.AddBBBSTRow(drBestemmelingen)
                            End If
                        Next

                        '5. Opmerkingen en datums verzending
                        '-----------------------------------
                        With drRegistratie
                            'Dim sqldatenull As SqlDateTime 'Dien - aug2008 - migratie 2008

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

                        '6. Toestanden
                        '-------------
                        '--> ofwel toevoegen/verwijderen of updaten
                        Me._oTdsAanrijding.BBOGVSTA.Clear()
                        Me._oTdsAanrijding.BBOGVSTA.AcceptChanges()

                        Dim drAanrijdingToestand As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBOGVSTARow

                        '1. toestand van het terrein
                        If Not Me.ComboBoxToestandTerrein.SelectedValue Is Nothing _
                           And Me.ComboBoxToestandTerrein.Text <> "" Then
                            'Toevoegen
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxToestandTerrein.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If

                        '2. Aard van de bodem
                        If Not Me.ComboBoxAardBodem.SelectedValue Is Nothing _
                           And Me.ComboBoxAardBodem.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxAardBodem.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '3. Toestand van de bodem
                        If Not Me.ComboBoxToestandBodem.SelectedValue Is Nothing _
                           And Me.ComboBoxToestandBodem.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxToestandBodem.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '4. Bebouwing 
                        If Not Me.ComboBoxBebouwing.SelectedValue Is Nothing _
                          And Me.ComboBoxBebouwing.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxBebouwing.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '5. weg 
                        If Not Me.ComboBoxWeg.SelectedValue Is Nothing _
                           And Me.ComboBoxWeg.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxWeg.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '6. Verlichting 
                        If Not Me.ComboBoxVerlichting.SelectedValue Is Nothing _
                           And Me.ComboBoxVerlichting.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxVerlichting.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If
                        '7. Atmosferische toestand 
                        If Not Me.ComboBoxAtmosferisch.SelectedValue Is Nothing _
                           And Me.ComboBoxAtmosferisch.Text <> "" Then
                            drAanrijdingToestand = Me._oTdsAanrijding.BBOGVSTA.NewBBOGVSTARow
                            drAanrijdingToestand.ID_REG = id_reg
                            drAanrijdingToestand.ID_STA = CInt(Me.ComboBoxAtmosferisch.SelectedValue)
                            Me._oTdsAanrijding.BBOGVSTA.AddBBOGVSTARow(drAanrijdingToestand)
                        End If

                        '7. lijst met betrokkenen
                        '------------------------
                        'deze code ontbrak bij updaten van een bestaande aanrijding
                        'naco - 16/10/2007
                        Dim aBBBTROGVRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding.BBBTROGVRow
                        For Each aBBBTROGVRow In Me._dataAanrijding.BBBTROGV.Rows
                            aBBBTROGVRow.ID_REG = id_reg
                        Next

                        For Each aBBBTROGVRow In _oTdsAanrijding.BBBTROGV.Rows
                            aBBBTROGVRow.Delete()
                        Next

                        'Dim drNewBetrokkene As DataRow 'Dien - aug2008 - migratie 2008
                        _oTdsAanrijding.Merge(Me._dataAanrijding.BBBTROGV)

                    End If

                    'Effectief bewaren
                    '-----------------
                    'getChanges() stuurt enkel de gewijzigde records door over de webservice
                    Dim ds As New Proxy.BBWService.Mgt.TDSAanrijding
                    ds.Merge(Me._oTdsAanrijding.GetChanges)

                    proxy.RegisterRegistratieAanrijding(ds, System.Environment.UserName)

                    Me._oTdsAanrijding.AcceptChanges()
                    'Me.UserControlGeneralFunctionsAanrijding.setBijlageData(Me._oTdsAanrijding.BBBYLG)

                    'als het om een nieuw aanrijding gaat, worden volgende velden ingevuld
                    If Me._idRegistratie = -1 Then
                        TextBoxVerslagnummer.Text = volgnr_reg_jaar.ToString & " / " & Year(Me.UserControlGeneralFunctionsAanrijding.getOpstelDatum)
                        'id instellen zodat er bij het refreshen geen nieuw scherm getoond wordt
                        Me._idRegistratie = id_reg
                    End If
                    Call Me.bindRegistratie()

                    If arrayOfDeletedChronicleID.Count > 0 Then
                        For Each aChronicleId As String In arrayOfDeletedChronicleID
                            Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                        Next
                    End If

                    Cursor.Current = Cursors.Default

                    Me.setStatus("De aanrijding werd succesvol opgeslagen")
                End If
            Catch ex As Exception
                Me._oTdsAanrijding.RejectChanges()
                MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                "Form: FormBewakingAanrijding - OpslaanRegistratie" & vbCrLf & _
                                "Message: " & ex.Message & vbCrLf & _
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Function UploadAanrijdingBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
        'Doel:   Uploaden van de bijlage van een aanrijdingsverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(UltraDateTimeEditorDatum.DateTime) & "/" & volgnr & " - " & LabelTitel.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BEWAKING", "FolderPathDocumentum").WD()

        Return BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName, documentumFolderPath)

    End Function

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
            ElseIf Not controleVeldenok() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorVerzending.Value = Now
                Me.OpslaanAanrijding()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf & _
                            "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                            "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                            "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                            "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf & _
                            "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                            "Opsteller:         " & UserControlGeneralFunctionsAanrijding.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingAanrijding - ButtonVerzendingBBW_Click()" & vbCrLf & _
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
            Me.OpslaanAanrijding()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Verzending").WD & vbCrLf
            textMail &= vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsAanrijding.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingAanrijding - ButtonGoedkeuring_Click()" & vbCrLf & _
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
            Me.OpslaanAanrijding()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BEWAKING", "Terugzenden").WD & vbCrLf & vbCrLf
            textMail &= "Onderstaand verslag kan niet worden goedgekeurd. Gelieve het verslag te wijzigen." & vbCrLf & vbCrLf & _
                        "Datum registratie: " & UltraDateTimeEditorDatum.Text & vbCrLf & _
                        "Registratietype:   " & LabelTitel.Text & vbCrLf & _
                        "Plaats:            " & TextBoxPlaats.Text & vbCrLf & _
                        "Omschrijving:      " & TextBoxKorteOms.Text & vbCrLf & _
                        "Verslagnummer:     " & TextBoxVerslagnummer.Text & vbCrLf & vbCrLf & _
                        "Opsteller:         " & UserControlGeneralFunctionsAanrijding.getOpsteller & vbCrLf & vbCrLf & _
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
                            "Form: FormBewakingAanrijding - ButtonGoedkeuring_Click()" & vbCrLf & _
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
        Dim specBest As New ArrayList
        Dim titelMail As String
        Dim textMail As String
        Dim textMailURL As String = ""
        Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim specPathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim dsSpecBest As New TDSBBBSTBY
        Dim drSpecBest As TDSBBBSTBY.BBBSTBYRow
        Dim IsSpecialBest As Boolean = False
        Dim IsNormalBest As Boolean = False

        Try
            For Each bestRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsAanrijding.getDataBestemmelingen.Tables(0).Rows
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
            For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAanrijding.getDataBijlagen.Tables(0).Rows
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
                Me.OpslaanAanrijding()

                'Eerst rapport exporteren naar PDF-file. Dit mag zowel naar de interne als externe bestemmelingen worden doorgestuurd.
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
                        "Opsteller:         " & UserControlGeneralFunctionsAanrijding.getOpsteller & vbCrLf & vbCrLf & _
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf & _
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf & vbCrLf
               
                Dim urlString As String
                For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAanrijding.getDataBijlagen.Tables(0).Rows
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
                                                   "RegistratieAanrijding", _
                                                   pathPDFfile, _
                                                   Me._idRegistratie)
                f_rap.Dispose()

                'Dan mail versturen met PDF-file in attachment

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
                Me.OpslaanAanrijding()

                Me.setStatus("Registratieverslag succesvol verzonden naar de bestemmelingen")

            Else
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze registratie. Het registratieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            Me.setStatus("OPGELET: registratieverslag niet verzonden naar de bestemmelingen")

            MessageBox.Show("OPGELET: verslag is niet succesvol verzonden naar bestemmelingen.", "Niet succesvol", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingAanrijding - ButtonVerzendingBest_Click()" & vbCrLf & _
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
            If FormManager.Current.PostOverste Then
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonVerzendingBest.Visible = False
            ElseIf FormManager.Current.BBWVerantwoordelijke Then
                'do nothing, mag alles zien
                ButtonMailIKP.Top = UltraButtonOverzicht.Top
                ButtonMailIKP.Visible = True
            ElseIf FormManager.Current.Chip Or FormManager.Current.IKPvtw Then
                If FormManager.Current.IKPvtw Or FormManager.Current.Chip Then
                    UltraButtonOverzicht.Enabled = False
                    ButtonMailIKP.Visible = True
                    ButtonMailIKP.Top = UltraButtonOverzicht.Top
                End If
                UltraButtonOpslaan.Enabled = False
                UltraButtonAnnuleer.Visible = False

                GroupBoxHoofding.Enabled = False
                GroupBoxBetrokkenen.Enabled = False
                GroupBoxOverige.Enabled = False
                GroupBoxAlgemeneGegevens.Enabled = False
                GroupBoxToestand.Enabled = False
                GroupBoxInlichtingen.Enabled = False


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

    Private Sub UltraMaskedEditStamnrMelder_MaskChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles UltraMaskedEditStamnrMelder.MaskChanged

    End Sub

    Private Sub UltraMaskedEditStamnrMelder_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraMaskedEditStamnrMelder.Leave
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
            'For Each bijlageRow As Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsAanrijding.getDataBijlagen.Tables(0).Rows

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
                "RegistratieAanrijding",
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
                             "Form: FormBewakingAanrijding - SendMailIKP" & vbCrLf &
                             "Message: " & ex.Message & vbCrLf &
                             "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
