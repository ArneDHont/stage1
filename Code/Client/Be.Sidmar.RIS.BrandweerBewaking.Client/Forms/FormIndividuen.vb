Option Explicit On 
Option Strict On

Imports System.Windows.Forms
Imports System.Drawing
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Collections.Generic
Imports System.Linq


Public Class FormIndividuen
    Inherits System.Windows.Forms.Form

    Private _canceled As Boolean = True
    Private _idIndi As Integer
    Private _individu As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LabelVevidis As System.Windows.Forms.Label
    Friend WithEvents PictureBoxVevidis As System.Windows.Forms.PictureBox
    Friend WithEvents LabelAfdhoofd As System.Windows.Forms.Label
    Friend WithEvents PictureBoxBrandco As System.Windows.Forms.PictureBox
    Private _bestemmelingen As Boolean
    Private ReadOnly _afdeling As String

    Private _dataConfiguratie As New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents LabelBrandco As System.Windows.Forms.Label
    Friend WithEvents PictureBoxAfdhoofd As System.Windows.Forms.PictureBox
    Friend WithEvents LabelChefs As System.Windows.Forms.Label
    Friend WithEvents ButtonShowInfoChiefs As Infragistics.Win.Misc.UltraButton
    Friend WithEvents TextBoxStamnrInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents ButtonInfoBrandcoord As System.Windows.Forms.Button
    Friend WithEvents LabelAMC As System.Windows.Forms.Label
    Friend WithEvents PictureBoxAMC As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip 'naco - 01/02/2013 - stamnrs brandcoördinatoren
    Private _strBrandCoordinatorenStamnrs As String = ""

    Private _afdelingsMilieuCoordinatoren As Proxy.BBWService.Mgt.TDSBBAFDAMC
    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitializeDataSet()
    End Sub

    Public Sub New(ByVal bestemmelingen As Boolean, ByVal afdeling As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        _bestemmelingen = bestemmelingen
        _afdeling = afdeling

        InitializeDataSet()
        If (_bestemmelingen) Then
            SelectDefaultAfdelingshoofd_Bestemmelingen()
        End If

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
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonWijzig As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSelecteer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridIndividuen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBoxOpties As System.Windows.Forms.GroupBox
    Friend WithEvents _dataviewIndividuen As System.Data.DataView
    Friend WithEvents UltraGridBestemmelingen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraButtonNieuw As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBIND", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_IND")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_IND_TK")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_IND")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_WNPL_IND")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WNPL_IND")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_GBR_IND")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_GBR_IND")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_EMAL_IND")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GSL_IND")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BST_IND")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_DIR")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_AFD")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SECT")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_UIT_DNS")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_IND")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_TEL_SID")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_FIE")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BST_ACTIVE")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_IND_WKG")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_JUR_VENO")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIndividuen))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBIND", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_IND")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_IND_TK")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_IND")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_WNPL_IND")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WNPL_IND")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_GBR_IND")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_GBR_IND")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_EMAL_IND")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GSL_IND")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BST_IND")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_DIR")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_AFD")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SECT")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_UIT_DNS")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_IND")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_TEL_SID")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_FIE")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BST_ACTIVE")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_IND_WKG")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_JUR_VENO")
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
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me.UltraGridIndividuen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.GroupBoxOpties = New System.Windows.Forms.GroupBox()
        Me.LabelAMC = New System.Windows.Forms.Label()
        Me.PictureBoxAMC = New System.Windows.Forms.PictureBox()
        Me.ButtonInfoBrandcoord = New System.Windows.Forms.Button()
        Me.LabelBrandco = New System.Windows.Forms.Label()
        Me.PictureBoxAfdhoofd = New System.Windows.Forms.PictureBox()
        Me.LabelVevidis = New System.Windows.Forms.Label()
        Me.PictureBoxVevidis = New System.Windows.Forms.PictureBox()
        Me.LabelAfdhoofd = New System.Windows.Forms.Label()
        Me.PictureBoxBrandco = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraButtonNieuw = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSelecteer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._dataviewIndividuen = New System.Data.DataView()
        Me.UltraGridBestemmelingen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TextBoxStamnrInfo = New System.Windows.Forms.TextBox()
        Me.LabelChefs = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonShowInfoChiefs = New Infragistics.Win.Misc.UltraButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpties.SuspendLayout()
        CType(Me.PictureBoxAMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAfdhoofd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVevidis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBrandco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataviewIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridIndividuen
        '
        Me.UltraGridIndividuen.DataMember = "BBIND"
        Me.UltraGridIndividuen.DataSource = Me._dataIndividuen
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridIndividuen.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn1.Header.Caption = "Stamnr"
        UltraGridColumn1.Header.Fixed = True
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 62
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn2.Header.VisiblePosition = 13
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn3.Header.VisiblePosition = 14
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn4.Header.Caption = "Naam"
        UltraGridColumn4.Header.Fixed = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 69
        UltraGridColumn5.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn5.Header.Caption = "Voornaam"
        UltraGridColumn5.Header.Fixed = True
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 65
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn6.Header.Caption = "Adres"
        UltraGridColumn6.Header.VisiblePosition = 8
        UltraGridColumn6.Width = 88
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn7.Header.Caption = "Postcode"
        UltraGridColumn7.Header.VisiblePosition = 9
        UltraGridColumn7.Width = 51
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn8.Header.Caption = "Woonplaats"
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.Width = 65
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn9.Header.VisiblePosition = 15
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn10.Header.VisiblePosition = 16
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn11.Header.Caption = "Email"
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Width = 77
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn12.Header.VisiblePosition = 17
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn13.Header.VisiblePosition = 18
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn14.Header.Caption = "Dir"
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.Width = 54
        UltraGridColumn15.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn15.Header.Caption = "Afd"
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn15.Width = 55
        UltraGridColumn16.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn16.Header.Caption = "Sectie"
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.Width = 58
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn17.Header.Caption = "Datum uit dienst"
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 83
        UltraGridColumn18.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn18.Header.Caption = "Type"
        UltraGridColumn18.Header.VisiblePosition = 11
        UltraGridColumn18.Width = 70
        UltraGridColumn19.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn19.Header.Caption = "Tel"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.Width = 61
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn20.Header.Caption = "Functie"
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridColumn20.Width = 208
        UltraGridColumn42.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn42.Header.VisiblePosition = 20
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 21
        UltraGridColumn44.Header.VisiblePosition = 22
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        UltraGridBand1.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.UltraGridIndividuen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridIndividuen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridIndividuen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividuen.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridIndividuen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridIndividuen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridIndividuen.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridIndividuen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridIndividuen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridIndividuen.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridIndividuen.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridIndividuen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIndividuen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.UltraGridIndividuen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridIndividuen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividuen.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridIndividuen.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridIndividuen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridIndividuen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridIndividuen.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridIndividuen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividuen.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridIndividuen.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridIndividuen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridIndividuen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridIndividuen.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridIndividuen.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridIndividuen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridIndividuen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIndividuen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridIndividuen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridIndividuen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridIndividuen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridIndividuen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridIndividuen.DisplayLayout.UseFixedHeaders = True
        Me.UltraGridIndividuen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridIndividuen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridIndividuen.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridIndividuen.Name = "UltraGridIndividuen"
        Me.UltraGridIndividuen.Size = New System.Drawing.Size(1514, 452)
        Me.UltraGridIndividuen.TabIndex = 0
        '
        'GroupBoxOpties
        '
        Me.GroupBoxOpties.Controls.Add(Me.LabelAMC)
        Me.GroupBoxOpties.Controls.Add(Me.PictureBoxAMC)
        Me.GroupBoxOpties.Controls.Add(Me.ButtonInfoBrandcoord)
        Me.GroupBoxOpties.Controls.Add(Me.LabelBrandco)
        Me.GroupBoxOpties.Controls.Add(Me.PictureBoxAfdhoofd)
        Me.GroupBoxOpties.Controls.Add(Me.LabelVevidis)
        Me.GroupBoxOpties.Controls.Add(Me.PictureBoxVevidis)
        Me.GroupBoxOpties.Controls.Add(Me.LabelAfdhoofd)
        Me.GroupBoxOpties.Controls.Add(Me.PictureBoxBrandco)
        Me.GroupBoxOpties.Controls.Add(Me.Label1)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonNieuw)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSelecteer)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpties.Location = New System.Drawing.Point(7, 3)
        Me.GroupBoxOpties.Name = "GroupBoxOpties"
        Me.GroupBoxOpties.Size = New System.Drawing.Size(957, 72)
        Me.GroupBoxOpties.TabIndex = 5
        Me.GroupBoxOpties.TabStop = False
        Me.GroupBoxOpties.Text = "Opties"
        '
        'LabelAMC
        '
        Me.LabelAMC.AutoSize = True
        Me.LabelAMC.Location = New System.Drawing.Point(566, 51)
        Me.LabelAMC.Name = "LabelAMC"
        Me.LabelAMC.Size = New System.Drawing.Size(163, 13)
        Me.LabelAMC.TabIndex = 15
        Me.LabelAMC.Text = "AMC - AfdelingsMilieuCoördinator"
        '
        'PictureBoxAMC
        '
        Me.PictureBoxAMC.BackColor = System.Drawing.Color.LightGreen
        Me.PictureBoxAMC.Location = New System.Drawing.Point(519, 51)
        Me.PictureBoxAMC.Name = "PictureBoxAMC"
        Me.PictureBoxAMC.Size = New System.Drawing.Size(41, 15)
        Me.PictureBoxAMC.TabIndex = 14
        Me.PictureBoxAMC.TabStop = False
        '
        'ButtonInfoBrandcoord
        '
        Me.ButtonInfoBrandcoord.Image = CType(resources.GetObject("ButtonInfoBrandcoord.Image"), System.Drawing.Image)
        Me.ButtonInfoBrandcoord.Location = New System.Drawing.Point(733, 47)
        Me.ButtonInfoBrandcoord.Name = "ButtonInfoBrandcoord"
        Me.ButtonInfoBrandcoord.Size = New System.Drawing.Size(32, 21)
        Me.ButtonInfoBrandcoord.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ButtonInfoBrandcoord, "Info over brandcoördinatoren")
        Me.ButtonInfoBrandcoord.UseVisualStyleBackColor = True
        '
        'LabelBrandco
        '
        Me.LabelBrandco.AutoSize = True
        Me.LabelBrandco.Location = New System.Drawing.Point(421, 51)
        Me.LabelBrandco.Name = "LabelBrandco"
        Me.LabelBrandco.Size = New System.Drawing.Size(88, 13)
        Me.LabelBrandco.TabIndex = 12
        Me.LabelBrandco.Text = "Brandcoördinator"
        '
        'PictureBoxAfdhoofd
        '
        Me.PictureBoxAfdhoofd.BackColor = System.Drawing.Color.Orange
        Me.PictureBoxAfdhoofd.Location = New System.Drawing.Point(10, 51)
        Me.PictureBoxAfdhoofd.Name = "PictureBoxAfdhoofd"
        Me.PictureBoxAfdhoofd.Size = New System.Drawing.Size(41, 15)
        Me.PictureBoxAfdhoofd.TabIndex = 11
        Me.PictureBoxAfdhoofd.TabStop = False
        '
        'LabelVevidis
        '
        Me.LabelVevidis.AutoSize = True
        Me.LabelVevidis.Location = New System.Drawing.Point(289, 51)
        Me.LabelVevidis.Name = "LabelVevidis"
        Me.LabelVevidis.Size = New System.Drawing.Size(70, 13)
        Me.LabelVevidis.TabIndex = 10
        Me.LabelVevidis.Text = "Vevidisexpert"
        '
        'PictureBoxVevidis
        '
        Me.PictureBoxVevidis.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBoxVevidis.Location = New System.Drawing.Point(242, 51)
        Me.PictureBoxVevidis.Name = "PictureBoxVevidis"
        Me.PictureBoxVevidis.Size = New System.Drawing.Size(41, 15)
        Me.PictureBoxVevidis.TabIndex = 9
        Me.PictureBoxVevidis.TabStop = False
        '
        'LabelAfdhoofd
        '
        Me.LabelAfdhoofd.AutoSize = True
        Me.LabelAfdhoofd.Location = New System.Drawing.Point(57, 51)
        Me.LabelAfdhoofd.Name = "LabelAfdhoofd"
        Me.LabelAfdhoofd.Size = New System.Drawing.Size(176, 13)
        Me.LabelAfdhoofd.TabIndex = 8
        Me.LabelAfdhoofd.Text = "Afdelingshoofd of Verantwoordelijke"
        '
        'PictureBoxBrandco
        '
        Me.PictureBoxBrandco.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBoxBrandco.Location = New System.Drawing.Point(374, 51)
        Me.PictureBoxBrandco.Name = "PictureBoxBrandco"
        Me.PictureBoxBrandco.Size = New System.Drawing.Size(41, 15)
        Me.PictureBoxBrandco.TabIndex = 7
        Me.PictureBoxBrandco.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(342, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Opgelet: 2 grids boven elkaar"
        Me.Label1.Visible = False
        '
        'UltraButtonNieuw
        '
        Me.UltraButtonNieuw.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonNieuw.Location = New System.Drawing.Point(8, 16)
        Me.UltraButtonNieuw.Name = "UltraButtonNieuw"
        Me.UltraButtonNieuw.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonNieuw.TabIndex = 5
        Me.UltraButtonNieuw.Text = "Nieuw"
        '
        'UltraButtonAfdrukken
        '
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(216, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        Me.UltraButtonAfdrukken.Visible = False
        '
        'UltraButtonWijzig
        '
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(104, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        '
        'UltraButtonSelecteer
        '
        Me.UltraButtonSelecteer.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSelecteer.Location = New System.Drawing.Point(764, 16)
        Me.UltraButtonSelecteer.Name = "UltraButtonSelecteer"
        Me.UltraButtonSelecteer.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSelecteer.TabIndex = 3
        Me.UltraButtonSelecteer.Text = "Selecteer"
        '
        'UltraButtonSluiten
        '
        Me.UltraButtonSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(860, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        '_dataviewIndividuen
        '
        Me._dataviewIndividuen.RowFilter = "BST_IND = 1"
        Me._dataviewIndividuen.Sort = "ID_IND"
        Me._dataviewIndividuen.Table = Me._dataIndividuen.BBIND
        '
        'UltraGridBestemmelingen
        '
        Me.UltraGridBestemmelingen.DataSource = Me._dataviewIndividuen
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridBestemmelingen.DisplayLayout.Appearance = Appearance14
        UltraGridColumn21.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn21.Header.Caption = "Stamnr"
        UltraGridColumn21.Header.Fixed = True
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn21.Width = 63
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn24.Header.Caption = "Naam"
        UltraGridColumn24.Header.Fixed = True
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Width = 111
        UltraGridColumn25.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn25.Header.Caption = "Voornaam"
        UltraGridColumn25.Header.Fixed = True
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Width = 86
        UltraGridColumn26.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn26.Header.Caption = "Adres"
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.Width = 103
        UltraGridColumn27.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn27.Header.Caption = "Postcode"
        UltraGridColumn27.Header.VisiblePosition = 12
        UltraGridColumn27.Width = 59
        UltraGridColumn28.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn28.Header.Caption = "Woonplaats"
        UltraGridColumn28.Header.VisiblePosition = 13
        UltraGridColumn28.Width = 80
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn30.Header.VisiblePosition = 15
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn31.Header.Caption = "Email"
        UltraGridColumn31.Header.VisiblePosition = 5
        UltraGridColumn31.Width = 134
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn34.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn34.Header.Caption = "Dir"
        UltraGridColumn34.Header.VisiblePosition = 6
        UltraGridColumn34.Width = 51
        UltraGridColumn35.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn35.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn35.Header.Caption = "Afd"
        UltraGridColumn35.Header.VisiblePosition = 7
        UltraGridColumn35.Width = 64
        UltraGridColumn36.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn36.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn36.Header.Caption = "Sectie"
        UltraGridColumn36.Header.VisiblePosition = 8
        UltraGridColumn36.Width = 50
        UltraGridColumn37.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn37.Header.VisiblePosition = 19
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn38.Header.Caption = "Type"
        UltraGridColumn38.Header.VisiblePosition = 16
        UltraGridColumn38.Width = 94
        UltraGridColumn39.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn39.Header.Caption = "Tel"
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Width = 52
        UltraGridColumn40.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn40.Header.Caption = "Functie"
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Width = 192
        UltraGridColumn41.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn41.Header.VisiblePosition = 20
        UltraGridColumn41.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 21
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn46.Header.Caption = "Firma SAP HR"
        UltraGridColumn46.Header.VisiblePosition = 22
        UltraGridColumn46.Width = 192
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn45, UltraGridColumn46})
        UltraGridBand2.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.UltraGridBestemmelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridBestemmelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridBestemmelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridBestemmelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.UltraGridBestemmelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridBestemmelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridBestemmelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellAppearance = Appearance21
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridBestemmelingen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridBestemmelingen.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridBestemmelingen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridBestemmelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Left"
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridBestemmelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowAppearance = Appearance25
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridBestemmelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridBestemmelingen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridBestemmelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.UltraGridBestemmelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridBestemmelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridBestemmelingen.DisplayLayout.UseFixedHeaders = True
        Me.UltraGridBestemmelingen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBestemmelingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridBestemmelingen.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBestemmelingen.Name = "UltraGridBestemmelingen"
        Me.UltraGridBestemmelingen.Size = New System.Drawing.Size(1514, 452)
        Me.UltraGridBestemmelingen.TabIndex = 6
        Me.UltraGridBestemmelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridBestemmelingen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridIndividuen)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxOpties)
        Me.SplitContainer1.Size = New System.Drawing.Size(1514, 599)
        Me.SplitContainer1.SplitterDistance = 452
        Me.SplitContainer1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelName)
        Me.GroupBox1.Controls.Add(Me.TextBoxStamnrInfo)
        Me.GroupBox1.Controls.Add(Me.LabelChefs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButtonShowInfoChiefs)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 65)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chefs"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(5, 46)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(10, 13)
        Me.LabelName.TabIndex = 10
        Me.LabelName.Text = "-"
        '
        'TextBoxStamnrInfo
        '
        Me.TextBoxStamnrInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStamnrInfo.Location = New System.Drawing.Point(154, 19)
        Me.TextBoxStamnrInfo.Name = "TextBoxStamnrInfo"
        Me.TextBoxStamnrInfo.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxStamnrInfo.TabIndex = 7
        '
        'LabelChefs
        '
        Me.LabelChefs.Location = New System.Drawing.Point(350, 7)
        Me.LabelChefs.Name = "LabelChefs"
        Me.LabelChefs.Size = New System.Drawing.Size(598, 55)
        Me.LabelChefs.TabIndex = 9
        Me.LabelChefs.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Leidinggevenden van stamnr:"
        '
        'ButtonShowInfoChiefs
        '
        Appearance27.Image = CType(resources.GetObject("Appearance27.Image"), Object)
        Me.ButtonShowInfoChiefs.Appearance = Appearance27
        Me.ButtonShowInfoChiefs.ImageSize = New System.Drawing.Size(14, 14)
        Me.ButtonShowInfoChiefs.Location = New System.Drawing.Point(245, 17)
        Me.ButtonShowInfoChiefs.Name = "ButtonShowInfoChiefs"
        Me.ButtonShowInfoChiefs.Size = New System.Drawing.Size(99, 24)
        Me.ButtonShowInfoChiefs.TabIndex = 8
        Me.ButtonShowInfoChiefs.Text = "Toon leiding"
        '
        'FormIndividuen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.UltraButtonSluiten
        Me.ClientSize = New System.Drawing.Size(1514, 599)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIndividuen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecteer Individu"
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpties.ResumeLayout(False)
        Me.GroupBoxOpties.PerformLayout()
        CType(Me.PictureBoxAMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAfdhoofd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVevidis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBrandco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataviewIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"
    Public ReadOnly Property Canceled() As Boolean
        Get
            Return _canceled
        End Get
    End Property
    Public ReadOnly Property Individu() As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
        Get
            Return _individu
        End Get
    End Property

    Public ReadOnly Property IdIndi() As Integer
        Get
            Return _idIndi
        End Get
    End Property
#End Region

    Private Sub UltraGridIndividuenBestemmelingen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) _
                                Handles UltraGridIndividuen.InitializeLayout, UltraGridBestemmelingen.InitializeLayout

        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_IND"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""

        e.Layout.Bands(0).ColumnFilters("DT_UIT_DNS").FilterConditions.Add(FilterComparisionOperator.Equals, "9999-12-31")
        'AllowRowFiltering = False instellen op column in properties

    End Sub

    Private Sub InitializeDataSet()
        Try
            Dim controller As New Client.ControllerGetData
            _dataConfiguratie.Merge(controller.GetConfigurationSettings)
            _afdelingsMilieuCoordinatoren = controller.getAFDAMC()

            _strBrandCoordinatorenStamnrs = CStr(_dataConfiguratie.BBCONF.FindByGR_SLESLE("Brandcoordinatoren", "Stamnummers").WD)

            If _bestemmelingen Then
                _dataIndividuen.Merge(FormManager.Current.DataIndividuen_Bestemmelingen)
                UltraGridBestemmelingen.DataSource = _dataIndividuen
                UltraGridIndividuen.Visible = False

                UltraGridBestemmelingen.DisplayLayout.Bands(0).Columns("NR_IND_WKG").Hidden = True
                UltraGridBestemmelingen.DisplayLayout.Bands(0).Columns("NM_JUR_VENO").Hidden = True
                UltraGridBestemmelingen.DisplayLayout.Bands(0).Columns("VLG_INT_COD_PO").Hidden = True
            Else
                _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen))
                UltraGridIndividuen.DataSource = _dataIndividuen
                UltraGridIndividuen.DataMember = "BBIND"
                UltraGridBestemmelingen.Visible = False

                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("NR_IND_WKG").Hidden = True
                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("NM_JUR_VENO").Hidden = False 'april 2017 - naco
                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("NM_JUR_VENO").Header.Caption = "Firma SAP HR" 'april 2017 - naco
                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("NM_JUR_VENO").AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False 'april 2017 - naco
                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("NM_JUR_VENO").Width = 250 'april 2017 - naco
                UltraGridIndividuen.DisplayLayout.Bands(0).Columns("VLG_INT_COD_PO").Hidden = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub SelectDefaultAfdelingshoofd_Bestemmelingen()

        Dim rows As DataRow() = _dataIndividuen.BBIND.Select(String.Format("SCF_FIE like '{0}%' AND TRIM(SAP_AFD) = '{1}'", "HFD", _afdeling.Trim()))
        If (rows.Count = 1) Then
            For Each row As UltraGridRow In UltraGridBestemmelingen.Rows()
                If row.Cells("ID_IND").Value.ToString() = rows(0)("ID_IND").ToString() Then
                    row.Activate()
                End If
            Next
        End If
    End Sub

    Private Sub UltraButtonSelecteer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSelecteer.Click
        'Doel:
        'Auteur: Rajiv Blancke - mei 2006
        'Wijzigingen: Nancy Coppens - 13/09/2006 => email-adres

        Try

            If UltraGridIndividuen.Visible Then
                If Not UltraGridIndividuen.ActiveRow Is Nothing Then
                    Me._idIndi = CInt(UltraGridIndividuen.ActiveRow.Cells("ID_IND").Value)
                    Me._individu = Me._dataIndividuen.BBIND.FindByID_IND(_idIndi)
                    Me._canceled = False
                    Me.Hide()
                Else
                    MessageBox.Show("Geen individu geselecteerd.", "Individu", MessageBoxButtons.OK)
                End If
            ElseIf UltraGridBestemmelingen.Visible Then
                If Not UltraGridBestemmelingen.ActiveRow Is Nothing Then
                    If IsDBNull(UltraGridBestemmelingen.ActiveRow.Cells("AD_EMAL_IND").Value) Then
                        MessageBox.Show("Gelieve een bestemmeling met email-adres te selecteren aub.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Me._idIndi = CInt(UltraGridBestemmelingen.ActiveRow.Cells("ID_IND").Value)
                        Me._individu = Me._dataIndividuen.BBIND.FindByID_IND(_idIndi)
                        Me._canceled = False
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Geen bestemmeling geselecteerd.", "Bestemmeling", MessageBoxButtons.OK)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraButtonSelecteer_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me._canceled = True
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraButtonSluiten_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub UltraGridBestemmelingen_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridBestemmelingen.DoubleClickRow
        Try
            If Not UltraGridBestemmelingen.ActiveRow Is Nothing Then
                Me._idIndi = CInt(UltraGridBestemmelingen.ActiveRow.Cells("ID_IND").Value)
                Me._individu = Me._dataIndividuen.BBIND.FindByID_IND(_idIndi)
                Me._canceled = False
                Me.Hide()
            Else
                MessageBox.Show("Geen bestemmeling geselecteerd.", "Bestemmeling", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraGridBestemmelingen_DoubleClickRow" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridIndividuen_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridIndividuen.DoubleClickRow
        Try
            If Not UltraGridIndividuen.ActiveRow Is Nothing Then
                Me._idIndi = CInt(UltraGridIndividuen.ActiveRow.Cells("ID_IND").Value)
                Me._individu = Me._dataIndividuen.BBIND.FindByID_IND(_idIndi)
                Me._canceled = False
                Me.Hide()
            Else
                MessageBox.Show("Geen individu geselecteerd.", "Individu", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraGridIndividuen_DoubleClickRow" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonNieuw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonNieuw.Click
        Try
            If Me._bestemmelingen Then
                Dim oFrmIndividu As New FormIndividuBestemmeling
                oFrmIndividu.ShowDialog(Me)

                'Indien de bestemmeling werd toegevoegd --> refresh. 
                If oFrmIndividu.hasChanged Then
                    InitializeDataSet()
                End If
            Else
                'nieuw
                Dim aFormInd As New FormIndividuChange
                aFormInd.ShowDialog(Me)

                InitializeDataSet()
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraGridIndividuen_DoubleClickRow" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonWijzig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonWijzig.Click
        'Purpose:
        'Author: Dieter Vanneste - november 2007
        'Changes: sidnaco - 02/03/2007 - also implement code voor UltraGridBestemmelingen
        Try

            If UltraGridIndividuen.Visible Then
                If Not UltraGridIndividuen.ActiveRow Is Nothing Then
                    Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
                    Dim rijen() As DataRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.Select("ID_IND = " & CStr(UltraGridIndividuen.ActiveRow.Cells("ID_IND").Value))
                    If rijen.Length > 1 Then
                        MessageBox.Show("Gelieve één individu te selecteren.", "Individu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        aRow = CType(rijen(0), Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow)
                        Dim oFrmIndividu As New FormIndividuChange(aRow)
                        oFrmIndividu.ShowDialog(Me)
                        'Refreshen grid 
                        InitializeDataSet()
                    End If
                Else
                    MessageBox.Show("Geen individu geselecteerd.", "Individu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Not UltraGridBestemmelingen.ActiveRow Is Nothing Then
                    Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow
                    Dim rijen() As DataRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.Select("ID_IND = " & CStr(UltraGridBestemmelingen.ActiveRow.Cells("ID_IND").Value))
                    If rijen.Length > 1 Then
                        MessageBox.Show("Gelieve één individu te selecteren.", "Individu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        aRow = CType(rijen(0), Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow)
                        Dim oFrmIndividu As New FormIndividuChange(aRow)
                        oFrmIndividu.ShowDialog(Me)
                        'Refreshen grid 
                        InitializeDataSet()
                    End If
                Else
                    MessageBox.Show("Geen individu geselecteerd.", "Individu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraButtonWijzig_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormIndividuen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Doel:   er staan 2 grids boven elkaar: grid bestemmelingen een beetje naar rechts opgeschoven
        '        om beter te kunnen werken in design
        'Auteur: Nancy Coppens - 27/12/2006

        'UltraGridBestemmelingen.Left = UltraGridIndividuen.Left => Dock = Fill ingesteld
        'UltraGridBestemmelingen.Width = UltraGridIndividuen.Width => Dock = Fill ingesteld

        If Me._bestemmelingen = False Then
            PictureBoxAfdhoofd.Visible = False
            PictureBoxVevidis.Visible = False
            PictureBoxBrandco.Visible = False
            PictureBoxAMC.Visible = False

            LabelAfdhoofd.Visible = False
            LabelVevidis.Visible = False
            LabelBrandco.Visible = False
            LabelAMC.Visible = False

            ButtonInfoBrandcoord.Visible = False
        Else
            PictureBoxAfdhoofd.Visible = True
            PictureBoxVevidis.Visible = True
            PictureBoxBrandco.Visible = True
            PictureBoxAMC.Visible = True

            LabelAfdhoofd.Visible = True
            LabelVevidis.Visible = True
            LabelBrandco.Visible = True
            LabelAMC.Visible = True

            ButtonInfoBrandcoord.Visible = True
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 31/01/2013</remarks>
    Private Sub UltraGridBestemmelingen_InitializeRow(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridBestemmelingen.InitializeRow
        Try
            ShowRowColor(e)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraGridBestemmelingen_InitializeRow" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - jan 2013</remarks>
    Private Sub UltraGridIndividuen_InitializeRow(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridIndividuen.InitializeRow
        Try
            If _bestemmelingen Then
                ShowRowColor(e)
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - UltraGridIndividuen_InitializeRow" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' Show rows in Infragistics grid in a certain color (depending on employee function)
    ''' </summary>
    ''' <remarks>naco - 01/02/2013</remarks>
    Private Sub ShowRowColor(e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs)
        Try
            e.Row.Appearance.FontData.Bold = DefaultableBoolean.False
            Dim colorToSet As Drawing.Color = Color.White

            '1. Afdelingshoofden - Verantwoordelijken (bv. FMA, IKP, ...)
            '------------------------------------------------------------
            If e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("HFD") Or e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("VR ") Then
                colorToSet = Color.Orange
            End If

            '2. Vevidis
            '----------
            If e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("VEVIDIS") Then
                colorToSet = Color.RoyalBlue
            End If

            '3. Brandcoordinatoren
            '---------------------
            If ListContainsBrandcoordYn(e.Row.Cells("ID_IND").Value.ToString) Then
                colorToSet = Color.Tomato
            End If

            '4. AMC - Afdelingsmilieucoordinatoren
            '-------------------------------------
            If ListContainsMilieucoordYn(e.Row.Cells("ID_IND").Value.ToString) Then

                If ListContainsBrandcoordYn(e.Row.Cells("ID_IND").Value.ToString) _
                    Or e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("HFD") _
                    Or e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("VR ") _
                    Or e.Row.Cells("SCF_FIE").Value.ToString.StartsWith("VEVIDIS") Then

                    'volgende 3 kolommen groen (iemand kan brand- en milieucoördinator zijn)
                    e.Row.Cells(10).Appearance.BackColor = Color.LightGreen
                    e.Row.Cells(13).Appearance.BackColor = Color.LightGreen
                    e.Row.Cells(14).Appearance.BackColor = Color.LightGreen

                    e.Row.Appearance.FontData.Bold = DefaultableBoolean.True
                End If
            End If

            ' Set color
            If colorToSet <> Color.White Then
                e.Row.Cells(0).Appearance.BackColor = colorToSet
                e.Row.Cells(3).Appearance.BackColor = colorToSet
                e.Row.Cells(4).Appearance.BackColor = colorToSet

                e.Row.Appearance.FontData.Bold = DefaultableBoolean.True
            End If

        Catch ex As Exception
            'gewoon verder doen met de volgende rij
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aStamnr"></param>
    ''' <returns></returns>
    ''' <remarks>naco - 01/02/2013</remarks>
    Private Function ListContainsBrandcoordYn(ByVal aStamnr As String) As Boolean

        Dim listStamnrsBrandcoord As New List(Of String)(_strBrandCoordinatorenStamnrs.Split(","c))
        'tabel BBCONF: Brandcoordinatoren - Stamnummers
        '109256,816805,705148,834154,123630,255036,709347,485723,738756,737432,338124,725895,738055,121428,63913,91801,883352

        If listStamnrsBrandcoord.Contains(aStamnr) Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' AMC - AfdelingsMilieuCoordinator
    ''' </summary>
    ''' <param name="aStamnr"></param>
    ''' <returns></returns>
    ''' <remarks>naco - 07/02/2013</remarks>
    Private Function ListContainsMilieucoordYn(ByVal aStamnr As String) As Boolean

        Dim foundRow As DataRow() = _afdelingsMilieuCoordinatoren.BBAFDAMC.Select("ID_IND = '" & aStamnr & "'")
        If foundRow.Length = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 01/02/2013</remarks>
    Private Sub ButtonShowInfoChiefs_Click(sender As System.Object, e As System.EventArgs) Handles ButtonShowInfoChiefs.Click
        Dim wsHRS As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.HRSService.HRMData.Services
        Dim dsChefs As New DataSet

        Try
            Dim strStamnr As String = "0"
            LabelChefs.Text = ""
            LabelName.Text = ""

            If TextBoxStamnrInfo.Text.Trim = "" Then
                MessageBox.Show("Gelieve een stamnummer in te vullen aub.", "Stamnr", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBoxStamnrInfo.Focus()
            Else
                '1. naam van stamnummer
                '----------------------
                Dim dsPers As New DataSet
                dsPers.Merge(wsHRS.GetPersonDetail(TextBoxStamnrInfo.Text))
                If dsPers.Tables(0).Rows.Count = 0 Then
                Else
                    LabelName.Text = dsPers.Tables(0).Rows(0).Item("NM_FAM").ToString.Trim & " " &
                                     dsPers.Tables(0).Rows(0).Item("VNM").ToString.Trim & " - " &
                                     dsPers.Tables(0).Rows(0).Item("COD_EH_ORG_AFD").ToString.Trim & " - " &
                                     dsPers.Tables(0).Rows(0).Item("SCF_FIE").ToString.Trim
                End If

                '2. directe chefs
                '----------------
                dsChefs.Merge(wsHRS.GetDirectChefs(TextBoxStamnrInfo.Text))
                Dim i As Integer
                LabelChefs.Text = ""
                Dim strChef As String

                If dsChefs.Tables.Count = 0 Then
                    MessageBox.Show("Geen leidinggevenden gevonden bij ArcelorMittal Gent voor deze persoon.", "Leiding", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    For i = 0 To dsChefs.Tables(0).Rows.Count - 1
                        strChef = (i + 1).ToString & ") Stamnr: " & dsChefs.Tables(0).Rows(i).Item(1).ToString & " - " &
                            dsChefs.Tables(0).Rows(i).Item(2).ToString.Trim & " " &
                            dsChefs.Tables(0).Rows(i).Item(3).ToString.Trim & " - " &
                            "Tel: " & dsChefs.Tables(0).Rows(i).Item(4).ToString & " - " &
                            dsChefs.Tables(0).Rows(i).Item(6).ToString.Trim

                        If i = 0 Then
                            LabelChefs.Text = strChef
                        Else
                            LabelChefs.Text = LabelChefs.Text & vbCrLf &
                                              strChef
                        End If

                    Next
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormIndividuen - ButtonShowInfoChiefs_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub TextBoxStamnrInfo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxStamnrInfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonShowInfoChiefs.PerformClick()
        End If
    End Sub

    Private Sub TextBoxStamnrInfo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxStamnrInfo.KeyPress
        If Char.IsNumber(e.KeyChar) Or _
            e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or _
            e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Delete) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(3) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(22) Or
            e.KeyChar = Microsoft.VisualBasic.ChrW(24) Then '3 = Ctrl C, 22 = Ctrl V, 24 = Ctrl X
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxStamnrInfo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxStamnrInfo.TextChanged

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 07/02/2013</remarks>
    Private Sub ButtonInfoBrandcoord_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInfoBrandcoord.Click

        MessageBox.Show("1. Stamnummers brandcoördinatoren: " & vbCrLf & _strBrandCoordinatorenStamnrs & "." & vbCrLf & vbCrLf &
                        "Indien een wijziging nodig is in de stamnummers, gelieve de PC-cel te verwittigen aub." & vbCrLf &
                        "Wijziging dient te gebeuren in de BBW-database (tabel BBCONF)." & vbCrLf & vbCrLf &
                        "2. De AMC's (AfdelingsMilieucoördinatoren) worden beheerd via de codetabellen.", "Brandcoördinatoren - AMC", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub FormIndividuen_MinimumSizeChanged(sender As Object, e As System.EventArgs) Handles Me.MinimumSizeChanged

    End Sub
End Class
