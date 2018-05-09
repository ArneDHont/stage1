Option Strict On
Option Explicit On 

Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBrandweerMilieuverontreinigingen
    Inherits System.Windows.Forms.Form
    Private _controller As ControllerGetData

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents GroupBoxOverzicht As System.Windows.Forms.GroupBox
    Friend WithEvents UltraPrintPreviewDialogInterventies As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintDocumentInterventies As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents GroupBoxActies As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonVernieuwen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CheckBoxVersturenPostoverste As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVersturenBestemmelingen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxGoedkeuring As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButtonOpenen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents _dataMilieuverontr As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvBr
    Friend WithEvents UltraGridOverzicht As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridOverzichtBewaking As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataMilieuVerontreinigingenBewaking As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegBew
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonVernieuwenBewaking As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CheckBoxVersturenPostoversteBewaking As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVersturenBestemmelingenBewaking As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxGoedkeuringBewaking As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpenenBewaking As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAfdrukkenBewaking As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTVBR", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INTV")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_TY_INTV_JR")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("YEAR")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INTV")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_TY_INTV")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_RD_INTV")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRD_BLUS_AFD")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRD_BLUS_SID")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRDW_SID_OPR")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_RAP_INC_OTV")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_RAP_NW")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OK")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_BST")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfoId")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VolgnrAfd")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBEWREG", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_REG")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_PLG_IND")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_REG")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_REG_JR_BPL", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JR_REG")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_OPS_REG")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INC")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INC")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_RAP_NW")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OK")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_BST")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_OPS")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_CHEF_PO")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_HFD_BRW")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_OPS")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OPS_RAP_INTV")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_REG")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SUPPLIER_ID")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_CHIP")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_CHIP")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CHIP_YN")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_IKP_SENDMAIL")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DateInvalid")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UserInvalid")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RemarkInvalid")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYD_INC", 0)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_INC", 1)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerMilieuverontreinigingen))
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GroupBoxOverzicht = New System.Windows.Forms.GroupBox()
        Me.UltraGridOverzicht = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataMilieuverontr = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvBr()
        Me.UltraGridOverzichtBewaking = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataMilieuVerontreinigingenBewaking = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegBew()
        Me.GroupBoxActies = New System.Windows.Forms.GroupBox()
        Me.UltraButtonVernieuwen = New Infragistics.Win.Misc.UltraButton()
        Me.CheckBoxVersturenPostoverste = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVersturenBestemmelingen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGoedkeuring = New System.Windows.Forms.CheckBox()
        Me.UltraButtonOpenen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPrintPreviewDialogInterventies = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintDocumentInterventies = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UltraButtonVernieuwenBewaking = New Infragistics.Win.Misc.UltraButton()
        Me.CheckBoxVersturenPostoversteBewaking = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVersturenBestemmelingenBewaking = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGoedkeuringBewaking = New System.Windows.Forms.CheckBox()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpenenBewaking = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAfdrukkenBewaking = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxOverzicht.SuspendLayout()
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataMilieuverontr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridOverzichtBewaking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataMilieuVerontreinigingenBewaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxActies.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxOverzicht
        '
        Me.GroupBoxOverzicht.Controls.Add(Me.UltraGridOverzicht)
        Me.GroupBoxOverzicht.Location = New System.Drawing.Point(8, 8)
        Me.GroupBoxOverzicht.Name = "GroupBoxOverzicht"
        Me.GroupBoxOverzicht.Size = New System.Drawing.Size(1000, 294)
        Me.GroupBoxOverzicht.TabIndex = 2
        Me.GroupBoxOverzicht.TabStop = False
        Me.GroupBoxOverzicht.Text = "Overzicht milieuverontreinigingen brandweer"
        '
        'UltraGridOverzicht
        '
        Me.UltraGridOverzicht.DataMember = "BBINTVBR"
        Me.UltraGridOverzicht.DataSource = Me._dataMilieuverontr
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridOverzicht.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn3.Header.Caption = "Interventietype"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn4.Header.Caption = "Volgnr"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 70
        UltraGridColumn5.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn5.Header.Caption = "Jaar"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn6.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.GreaterThanOrEqualTo
        UltraGridColumn6.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn6.Header.Caption = "Datum opr"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 110
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn7.Header.Caption = "Afd"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 95
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn8.Header.Caption = "Plaats tussenkomst"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 175
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.Header.Caption = "Aard"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 175
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.Header.Caption = "Oorzaak"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 175
        UltraGridColumn11.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn11.Header.Caption = "Geblust afd"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 85
        UltraGridColumn12.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn12.Header.Caption = "Geblust BW"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 85
        UltraGridColumn13.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn13.Header.Caption = "Oproep BW"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 85
        UltraGridColumn14.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn14.Header.Caption = "Inc verslag "
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Width = 85
        UltraGridColumn15.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn15.Header.Caption = "Datum verz rapp."
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn16.Header.Caption = "Datum goedkeuring"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn17.Header.Caption = "Datum verz best."
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn50.Header.VisiblePosition = 17
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn52.Header.VisiblePosition = 19
        UltraGridColumn53.Header.VisiblePosition = 20
        UltraGridColumn54.Header.VisiblePosition = 21
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridOverzicht.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridOverzicht.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzicht.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzicht.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridOverzicht.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridOverzicht.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridOverzicht.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridOverzicht.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridOverzicht.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridOverzicht.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridOverzicht.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridOverzicht.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridOverzicht.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridOverzicht.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridOverzicht.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        Me.UltraGridOverzicht.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzicht.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridOverzicht.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridOverzicht.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridOverzicht.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridOverzicht.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzicht.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridOverzicht.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridOverzicht.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridOverzicht.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridOverzicht.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridOverzicht.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridOverzicht.Location = New System.Drawing.Point(16, 16)
        Me.UltraGridOverzicht.Name = "UltraGridOverzicht"
        Me.UltraGridOverzicht.Size = New System.Drawing.Size(976, 270)
        Me.UltraGridOverzicht.TabIndex = 1
        Me.UltraGridOverzicht.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataMilieuverontr
        '
        Me._dataMilieuverontr.DataSetName = "TDSIntvBr"
        Me._dataMilieuverontr.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataMilieuverontr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridOverzichtBewaking
        '
        Me.UltraGridOverzichtBewaking.DataMember = "BBBEWREG"
        Me.UltraGridOverzichtBewaking.DataSource = Me._dataMilieuVerontreinigingenBewaking
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridOverzichtBewaking.DisplayLayout.Appearance = Appearance14
        UltraGridColumn18.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn18.Header.Caption = "Registratie Id"
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 37
        UltraGridColumn19.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 79
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn20.Header.Caption = "Naam Opsteller"
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Width = 92
        UltraGridColumn21.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn21.Header.Caption = "Voornaam Opsteller"
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Width = 116
        UltraGridColumn22.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn22.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn22.Header.Caption = "Ploegnr"
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn22.Width = 42
        UltraGridColumn23.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn23.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn23.Header.Caption = "Registratie Type"
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Width = 111
        UltraGridColumn24.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn24.Header.Caption = "Volgnr"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.Width = 54
        UltraGridColumn25.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn25.Header.Caption = "Jaar"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.Width = 69
        UltraGridColumn26.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn26.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.GreaterThanOrEqualTo
        UltraGridColumn26.Header.Caption = "Datum opstelling"
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.Width = 95
        UltraGridColumn27.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn27.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn27.Header.Caption = "Tijdstip inc"
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.Width = 109
        UltraGridColumn28.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn28.Header.Caption = "Plaats incident"
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.Width = 148
        UltraGridColumn29.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn29.Header.Caption = "Datum verz rapp."
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn29.Width = 101
        UltraGridColumn30.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn30.Header.Caption = "Datum goedkeuring"
        UltraGridColumn30.Header.VisiblePosition = 15
        UltraGridColumn30.Width = 112
        UltraGridColumn31.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn31.Header.Caption = "Datum verz best."
        UltraGridColumn31.Header.VisiblePosition = 16
        UltraGridColumn31.Width = 104
        UltraGridColumn32.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.Width = 60
        UltraGridColumn33.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 67
        UltraGridColumn34.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn34.Header.VisiblePosition = 22
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.Width = 68
        UltraGridColumn35.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn35.Header.VisiblePosition = 19
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn36.Header.VisiblePosition = 20
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn37.Header.Caption = "Korte oms."
        UltraGridColumn37.Header.VisiblePosition = 13
        UltraGridColumn38.Header.VisiblePosition = 21
        UltraGridColumn39.Header.VisiblePosition = 23
        UltraGridColumn40.Header.VisiblePosition = 24
        UltraGridColumn41.Header.VisiblePosition = 26
        UltraGridColumn44.Header.VisiblePosition = 25
        UltraGridColumn45.Header.VisiblePosition = 27
        UltraGridColumn46.Header.VisiblePosition = 28
        UltraGridColumn47.Header.VisiblePosition = 29
        UltraGridColumn48.Header.VisiblePosition = 30
        UltraGridColumn49.Header.VisiblePosition = 31
        UltraGridColumn42.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn42.DataType = GetType(Date)
        UltraGridColumn42.Format = "HH:mm"
        UltraGridColumn42.Header.Caption = "Uur incident"
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.MaskInput = "{time}"
        UltraGridColumn42.Width = 69
        UltraGridColumn43.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn43.DataType = GetType(Date)
        UltraGridColumn43.Format = "dd/MM/yyyy"
        UltraGridColumn43.Header.Caption = "Datum incident"
        UltraGridColumn43.Header.VisiblePosition = 9
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 93
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn42, UltraGridColumn43})
        Me.UltraGridOverzichtBewaking.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGridOverzichtBewaking.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzichtBewaking.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzichtBewaking.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzichtBewaking.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.UltraGridOverzichtBewaking.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOverzichtBewaking.DisplayLayout.GroupByBox.Hidden = True
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOverzichtBewaking.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.UltraGridOverzichtBewaking.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridOverzichtBewaking.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.CellAppearance = Appearance21
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Left"
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.RowAppearance = Appearance25
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridOverzichtBewaking.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.UltraGridOverzichtBewaking.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
        Me.UltraGridOverzichtBewaking.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridOverzichtBewaking.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridOverzichtBewaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridOverzichtBewaking.Location = New System.Drawing.Point(14, 19)
        Me.UltraGridOverzichtBewaking.Name = "UltraGridOverzichtBewaking"
        Me.UltraGridOverzichtBewaking.Size = New System.Drawing.Size(976, 329)
        Me.UltraGridOverzichtBewaking.TabIndex = 2
        Me.UltraGridOverzichtBewaking.Text = "Overzicht milieuverontreinigingen bewaking"
        Me.UltraGridOverzichtBewaking.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataMilieuVerontreinigingenBewaking
        '
        Me._dataMilieuVerontreinigingenBewaking.DataSetName = "TDSRegBew"
        Me._dataMilieuVerontreinigingenBewaking.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataMilieuVerontreinigingenBewaking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxActies
        '
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonVernieuwen)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxVersturenPostoverste)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxVersturenBestemmelingen)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxGoedkeuring)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonOpenen)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxActies.Location = New System.Drawing.Point(8, 300)
        Me.GroupBoxActies.Name = "GroupBoxActies"
        Me.GroupBoxActies.Size = New System.Drawing.Size(1000, 40)
        Me.GroupBoxActies.TabIndex = 3
        Me.GroupBoxActies.TabStop = False
        '
        'UltraButtonVernieuwen
        '
        Appearance27.Image = CType(resources.GetObject("Appearance27.Image"), Object)
        Me.UltraButtonVernieuwen.Appearance = Appearance27
        Me.UltraButtonVernieuwen.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonVernieuwen.Location = New System.Drawing.Point(208, 10)
        Me.UltraButtonVernieuwen.Name = "UltraButtonVernieuwen"
        Me.UltraButtonVernieuwen.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonVernieuwen.TabIndex = 39
        Me.UltraButtonVernieuwen.Text = "Vernieuwen"
        '
        'CheckBoxVersturenPostoverste
        '
        Me.CheckBoxVersturenPostoverste.Location = New System.Drawing.Point(312, 8)
        Me.CheckBoxVersturenPostoverste.Name = "CheckBoxVersturenPostoverste"
        Me.CheckBoxVersturenPostoverste.Size = New System.Drawing.Size(200, 24)
        Me.CheckBoxVersturenPostoverste.TabIndex = 8
        Me.CheckBoxVersturenPostoverste.Text = "Nog te versturen naar postoverste"
        '
        'CheckBoxVersturenBestemmelingen
        '
        Me.CheckBoxVersturenBestemmelingen.Location = New System.Drawing.Point(656, 8)
        Me.CheckBoxVersturenBestemmelingen.Name = "CheckBoxVersturenBestemmelingen"
        Me.CheckBoxVersturenBestemmelingen.Size = New System.Drawing.Size(224, 24)
        Me.CheckBoxVersturenBestemmelingen.TabIndex = 7
        Me.CheckBoxVersturenBestemmelingen.Text = "Nog te versturen naar bestemmelingen"
        '
        'CheckBoxGoedkeuring
        '
        Me.CheckBoxGoedkeuring.Location = New System.Drawing.Point(520, 8)
        Me.CheckBoxGoedkeuring.Name = "CheckBoxGoedkeuring"
        Me.CheckBoxGoedkeuring.Size = New System.Drawing.Size(128, 24)
        Me.CheckBoxGoedkeuring.TabIndex = 6
        Me.CheckBoxGoedkeuring.Text = "Nog goed te keuren"
        '
        'UltraButtonOpenen
        '
        Appearance28.Image = CType(resources.GetObject("Appearance28.Image"), Object)
        Me.UltraButtonOpenen.Appearance = Appearance28
        Me.UltraButtonOpenen.Location = New System.Drawing.Point(112, 10)
        Me.UltraButtonOpenen.Name = "UltraButtonOpenen"
        Me.UltraButtonOpenen.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonOpenen.TabIndex = 4
        Me.UltraButtonOpenen.Text = "Openen"
        '
        'UltraButtonAfdrukken
        '
        Appearance29.Image = CType(resources.GetObject("Appearance29.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance29
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(16, 10)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonAfdrukken.TabIndex = 3
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraPrintPreviewDialogInterventies
        '
        Me.UltraPrintPreviewDialogInterventies.Document = Me.UltraGridPrintDocumentInterventies
        Me.UltraPrintPreviewDialogInterventies.Name = "UltraPrintPreviewDialogInterventies"
        '
        'UltraGridPrintDocumentInterventies
        '
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 736)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1002
        Me._statusBar.User = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraButtonVernieuwenBewaking)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVersturenPostoversteBewaking)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVersturenBestemmelingenBewaking)
        Me.GroupBox1.Controls.Add(Me.CheckBoxGoedkeuringBewaking)
        Me.GroupBox1.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBox1.Controls.Add(Me.UltraButtonOpenenBewaking)
        Me.GroupBox1.Controls.Add(Me.UltraButtonAfdrukkenBewaking)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 690)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 40)
        Me.GroupBox1.TabIndex = 1003
        Me.GroupBox1.TabStop = False
        '
        'UltraButtonVernieuwenBewaking
        '
        Appearance30.Image = CType(resources.GetObject("Appearance30.Image"), Object)
        Me.UltraButtonVernieuwenBewaking.Appearance = Appearance30
        Me.UltraButtonVernieuwenBewaking.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonVernieuwenBewaking.Location = New System.Drawing.Point(208, 10)
        Me.UltraButtonVernieuwenBewaking.Name = "UltraButtonVernieuwenBewaking"
        Me.UltraButtonVernieuwenBewaking.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonVernieuwenBewaking.TabIndex = 39
        Me.UltraButtonVernieuwenBewaking.Text = "Vernieuwen"
        '
        'CheckBoxVersturenPostoversteBewaking
        '
        Me.CheckBoxVersturenPostoversteBewaking.Location = New System.Drawing.Point(312, 8)
        Me.CheckBoxVersturenPostoversteBewaking.Name = "CheckBoxVersturenPostoversteBewaking"
        Me.CheckBoxVersturenPostoversteBewaking.Size = New System.Drawing.Size(200, 24)
        Me.CheckBoxVersturenPostoversteBewaking.TabIndex = 8
        Me.CheckBoxVersturenPostoversteBewaking.Text = "Nog te versturen naar postoverste"
        '
        'CheckBoxVersturenBestemmelingenBewaking
        '
        Me.CheckBoxVersturenBestemmelingenBewaking.Location = New System.Drawing.Point(656, 8)
        Me.CheckBoxVersturenBestemmelingenBewaking.Name = "CheckBoxVersturenBestemmelingenBewaking"
        Me.CheckBoxVersturenBestemmelingenBewaking.Size = New System.Drawing.Size(224, 24)
        Me.CheckBoxVersturenBestemmelingenBewaking.TabIndex = 7
        Me.CheckBoxVersturenBestemmelingenBewaking.Text = "Nog te versturen naar bestemmelingen"
        '
        'CheckBoxGoedkeuringBewaking
        '
        Me.CheckBoxGoedkeuringBewaking.Location = New System.Drawing.Point(520, 8)
        Me.CheckBoxGoedkeuringBewaking.Name = "CheckBoxGoedkeuringBewaking"
        Me.CheckBoxGoedkeuringBewaking.Size = New System.Drawing.Size(128, 24)
        Me.CheckBoxGoedkeuringBewaking.TabIndex = 6
        Me.CheckBoxGoedkeuringBewaking.Text = "Nog goed te keuren"
        '
        'UltraButtonSluiten
        '
        Appearance31.Image = CType(resources.GetObject("Appearance31.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance31
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(900, 10)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonSluiten.TabIndex = 5
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraButtonOpenenBewaking
        '
        Appearance32.Image = CType(resources.GetObject("Appearance32.Image"), Object)
        Me.UltraButtonOpenenBewaking.Appearance = Appearance32
        Me.UltraButtonOpenenBewaking.Location = New System.Drawing.Point(112, 10)
        Me.UltraButtonOpenenBewaking.Name = "UltraButtonOpenenBewaking"
        Me.UltraButtonOpenenBewaking.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonOpenenBewaking.TabIndex = 4
        Me.UltraButtonOpenenBewaking.Text = "Openen"
        '
        'UltraButtonAfdrukkenBewaking
        '
        Appearance33.Image = CType(resources.GetObject("Appearance33.Image"), Object)
        Me.UltraButtonAfdrukkenBewaking.Appearance = Appearance33
        Me.UltraButtonAfdrukkenBewaking.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukkenBewaking.Location = New System.Drawing.Point(16, 10)
        Me.UltraButtonAfdrukkenBewaking.Name = "UltraButtonAfdrukkenBewaking"
        Me.UltraButtonAfdrukkenBewaking.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonAfdrukkenBewaking.TabIndex = 3
        Me.UltraButtonAfdrukkenBewaking.Text = "Afdrukken"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UltraGridOverzichtBewaking)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 354)
        Me.GroupBox2.TabIndex = 1004
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Overzicht milieuverslagen bewaking"
        '
        'FormBrandweerMilieuverontreinigingen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 758)
        Me.Controls.Add(Me.GroupBoxActies)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxOverzicht)
        Me.Name = "FormBrandweerMilieuverontreinigingen"
        Me.ShowInTaskbar = False
        Me.Text = "Milieuverontreinigingen"
        Me.GroupBoxOverzicht.ResumeLayout(False)
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataMilieuverontr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridOverzichtBewaking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataMilieuVerontreinigingenBewaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxActies.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FormBrandweerMilieuverontreinigingen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor

            If FormManager.Current.PostOverste Or FormManager.Current.BBWVerantwoordelijke Then
                CheckBoxGoedkeuring.Visible = True
                CheckBoxGoedkeuringBewaking.Visible = True
            Else
                CheckBoxGoedkeuring.Visible = False
                CheckBoxGoedkeuringBewaking.Visible = False
            End If

            If FormManager.Current.BBWVerantwoordelijke = True Then
                CheckBoxVersturenBestemmelingen.Visible = True
                CheckBoxVersturenBestemmelingenBewaking.Visible = True
            Else
                CheckBoxVersturenBestemmelingen.Visible = False
                CheckBoxVersturenBestemmelingenBewaking.Visible = False
            End If

            _controller = New ControllerGetData

            Me._dataMilieuverontr.Merge(Me._controller.GetMilieuverontreinigingen)
            Me._dataMilieuVerontreinigingenBewaking.Merge(Me._controller.GetMilieuverontreinigingenBewaking)

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

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerMilieuverontreinigingen - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Events brandweer"
    Private Sub UltraGridOverzicht_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridOverzicht.DoubleClickRow
        Try
            If Not Me.UltraGridOverzicht.ActiveRow Is Nothing Then
                Me.setStatus("Openen Interventie")
                FormManager.Current.OpenFormNieuweBrandweerInterventies(False, False, True, CType(UltraGridOverzicht.ActiveRow.Cells("ID_TY_INTV").Text, Integer), UltraGridOverzicht.ActiveRow.Cells("SCF_TY_INTV").Text, CType(UltraGridOverzicht.ActiveRow.Cells("ID_INTV_BRDW").Text, Integer))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.UltraPrintPreviewDialogInterventies.ShowDialog(Me.UltraGridOverzicht)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpenen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpenen.Click
        'Doel:   brandweerinterventie openen
        'Auteur: Nancy Coppens - 25/09/2006
        Try
            If Not Me.UltraGridOverzicht.ActiveRow Is Nothing Then
                Me.setStatus("Openen Interventie")
                If Not IsDBNull(UltraGridOverzicht.ActiveRow.Cells("ID_TY_INTV").Value) Then
                    FormManager.Current.OpenFormNieuweBrandweerInterventies(False, False, True, CType(UltraGridOverzicht.ActiveRow.Cells("ID_TY_INTV").Text, Integer), UltraGridOverzicht.ActiveRow.Cells("SCF_TY_INTV").Text, CType(UltraGridOverzicht.ActiveRow.Cells("ID_INTV_BRDW").Text, Integer))
                Else
                    MessageBox.Show("Gelieve een interventie te selecteren aub.", "Selecteer interventie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub CheckBoxGoedkeuring_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxGoedkeuring.CheckedChanged
        'Doel: alle interventies tonen die nog moeten goedgekeurd worden door de postoverste
        'Auteur: Koen - Rajiv - mei 2006

        Try
            FiltersOnCheckboxes()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBrandweerOverzichtInterventies " & _
                            "- CheckBoxGoedkeuring_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub CheckBoxVersturenBestemmelingen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenBestemmelingen.CheckedChanged
        Try
            FiltersOnCheckboxes()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region

#Region "Events bewaking"
    Private Sub UltraGridOverzichtBewaking_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridOverzichtBewaking.DoubleClickRow
        Try
            If Not Me.UltraGridOverzichtBewaking.ActiveRow Is Nothing Then
                Me.setStatus("Openen Interventie")
                openRegistratieForm(CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_TY_REG").Value))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub openRegistratieForm(ByVal regtype As Integer)
        'Doel:      Bewaking registratieform openen
        'Auteur:    Rajiv - Koen - april 2006
        'Opmerking: paramater asSingleton = False => dan wordt iedere keer een nieuwe form geopend van de child form
        '           (info ontvangen van Ann Verdoodt)
        Try

            Select Case regtype
                Case 1
                    Me.setStatus("Openen Registratie Aanrijding")
                    FormManager.Current.OpenFormAanrijding(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 8
                    Me.setStatus("Openen Registratie Alcoholtest")
                    FormManager.Current.OpenFormAlcoholtest(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 2
                    Me.setStatus("Openen Registratie Controle op voertuigen")
                    FormManager.Current.OpenFormControleVoertuigen(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 3
                    Me.setStatus("Openen Registratie Diefstal")
                    FormManager.Current.OpenFormDiefstal(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 7
                    Me.setStatus("Openen Registratie Diverse Registratie")
                    FormManager.Current.OpenFormDiverseRegistratie(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 4
                    Me.setStatus("Openen Registratie Inbreuk op reglementen")
                    FormManager.Current.OpenFormInbreukReglementen(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 6
                    Me.setStatus("Openen Registratie Openmaken kleerkast")
                    FormManager.Current.OpenFormOpenmakenKleerkast(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 5
                    Me.setStatus("Openen Registratie Schadegeval")
                    FormManager.Current.OpenFormSchadegeval(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
                Case 9
                    Me.setStatus("Openen Registratie milieuverontreiniging")
                    FormManager.Current.OpenFormBewakingMilieuVerontreiniging(False, False, True, CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_REG").Text))
            End Select
            Me.setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukkenBewaking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukkenBewaking.Click
        Try
            Me.UltraPrintPreviewDialogInterventies.ShowDialog(Me.UltraGridOverzichtBewaking)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpenenBewaking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpenenBewaking.Click
        'Doel:   brandweerinterventie openen
        'Auteur: Nancy Coppens - 25/09/2006
        Try
            If Not Me.UltraGridOverzichtBewaking.ActiveRow Is Nothing Then
                Me.setStatus("Openen Interventie")
                If Not IsDBNull(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_TY_REG").Value) Then
                    openRegistratieForm(CInt(UltraGridOverzichtBewaking.ActiveRow.Cells("ID_TY_REG").Value))
                Else
                    MessageBox.Show("Gelieve een interventie te selecteren aub.", "Selecteer interventie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub CheckBoxGoedkeuringBewaking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxGoedkeuringBewaking.CheckedChanged
        'Doel: alle interventies tonen die nog moeten goedgekeurd worden door de postoverste
        'Auteur: Koen - Rajiv - mei 2006

        Try
            FiltersOnCheckboxesBewaking()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBrandweerOverzichtInterventies " & _
                            "- CheckBoxGoedkeuring_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub CheckBoxVersturenBestemmelingenBewaking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenBestemmelingenBewaking.CheckedChanged
        Try
            FiltersOnCheckboxesBewaking()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region




#Region "Functions"


    Private Sub UltraGridOverzicht_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridOverzicht.InitializeLayout
        Try
            'UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("TMS_INTV").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThan, "01/01/2006")
            'naco - default alles tonen > 1ste dag van de maand
            UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("TMS_INTV").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, _
                                                                    New DateTime(Year(Today), Month(Today), 1))

            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_INTV"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


   

    Private Sub UltraGridOverzicht_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridOverzicht.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 06/04/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Overzicht Interventies"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Overzicht Interventies " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridPrintDocumentInterventies_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocumentInterventies.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocumentInterventies.PageNumber
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        Try
            _statusBar.SetStatusbarInfo(statusText)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region



    Private Sub CheckBoxVersturenPostoverste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenPostoverste.CheckedChanged
        'Doel:   alle interventies tonen die nog moeten verstuurd worden naar de postoverste
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            FiltersOnCheckboxes()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBrandweerOverzichtInterventies " & _
                            "- CheckBoxVersturenPostoverste_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try

    End Sub



    Private Sub FiltersOnCheckboxes()
        'Doel:   Filters instellen via de checkboxen
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
            'naco - 05/03/2007 - alle filters uitzetten! Omdat er default een filter staat op de 1ste van de huidige maand,
            'werden soms rapporten vergeten als je "nog te versturen naar bestemmeling" opvraagt

            If CheckBoxVersturenPostoverste.Checked Then
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Clear()
            End If

            If CheckBoxGoedkeuring.Checked Then
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Clear()
            End If

            If CheckBoxVersturenBestemmelingen.Checked Then
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Clear()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub UltraButtonVernieuwen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonVernieuwen.Click
        'Doel:  als er een nieuwe interventie is toegevoegd, de dataset refreshen (door de gebruiker)
        'Auteur: Nancy Coppens - 08/12/2006

        Try
            Me.Cursor = Cursors.WaitCursor

            _controller = New ControllerGetData
            Me._dataMilieuverontr.Clear()
            Me._dataMilieuverontr.Merge(Me._controller.GetInterventies)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try

    End Sub

#Region "overzicht bewaking"
    Private Sub UltraGridOverzichtBewaking_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridOverzichtBewaking.InitializeLayout
        Try
            UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("TMS_INC").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo,
                                                                    New DateTime(Year(Today), Month(Today), 1))

            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_REG"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridOverzichtBewaking_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridOverzichtBewaking.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 06/04/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Overzicht Interventies"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Overzicht Interventies " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FiltersOnCheckboxesBewaking()
        'Doel:   Filters instellen via de checkboxen
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
            'naco - 05/03/2007 - alle filters uitzetten! Omdat er default een filter staat op de 1ste van de huidige maand,
            'werden soms rapporten vergeten als je "nog te versturen naar bestemmeling" opvraagt

            If CheckBoxVersturenPostoversteBewaking.Checked Then
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Clear()
            End If

            If CheckBoxGoedkeuringBewaking.Checked Then
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Clear()
            End If

            If CheckBoxVersturenBestemmelingenBewaking.Checked Then
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridOverzichtBewaking.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Clear()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub CheckBoxVersturenPostoversteBewaking_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenPostoversteBewaking.CheckedChanged
        'Doel:   alle interventies tonen die nog moeten verstuurd worden naar de postoverste
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            FiltersOnCheckboxesBewaking()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBrandweerOverzichtInterventies " & _
                            "- CheckBoxVersturenPostoversteBewaking_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonVernieuwenBewaking_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraButtonVernieuwenBewaking.Click
        'Doel:  als er een nieuwe interventie is toegevoegd, de dataset refreshen (door de gebruiker)
        'Auteur: Nancy Coppens - 08/12/2006

        Try
            Me.Cursor = Cursors.WaitCursor

            _controller = New ControllerGetData

            _dataMilieuVerontreinigingenBewaking.Clear()
            _dataMilieuVerontreinigingenBewaking.Merge(Me._controller.GetMilieuverontreinigingenBewaking)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try

    End Sub
#End Region




    Private Sub UltraButtonSluiten_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
