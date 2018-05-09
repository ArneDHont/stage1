Option Explicit On 
Option Strict On

Imports System.Windows.Forms
Imports System.Drawing
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormBewakingRegistratieOverzicht
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
    Friend WithEvents _dataRegBew As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegBew
    Friend WithEvents UltraGridRegistratieOverzicht As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpenen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CheckBoxVersturenBestemmelingen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxGoedkeuring As System.Windows.Forms.CheckBox
    Friend WithEvents UltraPrintPreviewDialogRegistraties As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintDocumentRegistraties As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents UltraPrintPreviewDialogInterventies As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents CheckBoxVersturenPostoverste As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNaarCHIP As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButtonInvalid As Infragistics.Win.Misc.UltraButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraButtonVernieuwen As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingRegistratieOverzicht))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBEWREG", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_REG")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_IND")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VNM_IND")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_PLG_IND")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_REG")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_REG_JR_BPL", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JR_REG")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_OPS_REG")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INC")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INC")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_RAP_NW")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OK")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_BST")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_OPS")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_CHEF_PO")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_HFD_BRW")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_OPS")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OPS_RAP_INTV")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_REG")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SUPPLIER_ID")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_CHIP")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_CHIP")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CHIP_YN")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_IKP_SENDMAIL")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DateInvalid")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UserInvalid")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RemarkInvalid")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYD_INC", 0)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_INC", 1)
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UltraButtonInvalid = New Infragistics.Win.Misc.UltraButton()
        Me.CheckBoxNaarCHIP = New System.Windows.Forms.CheckBox()
        Me.UltraButtonVernieuwen = New Infragistics.Win.Misc.UltraButton()
        Me.CheckBoxVersturenPostoverste = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVersturenBestemmelingen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGoedkeuring = New System.Windows.Forms.CheckBox()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpenen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPrintPreviewDialogInterventies = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintDocumentRegistraties = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraGridRegistratieOverzicht = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataRegBew = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegBew()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraGridRegistratieOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegBew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraButtonInvalid)
        Me.GroupBox1.Controls.Add(Me.CheckBoxNaarCHIP)
        Me.GroupBox1.Controls.Add(Me.UltraButtonVernieuwen)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVersturenPostoverste)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVersturenBestemmelingen)
        Me.GroupBox1.Controls.Add(Me.CheckBoxGoedkeuring)
        Me.GroupBox1.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBox1.Controls.Add(Me.UltraButtonOpenen)
        Me.GroupBox1.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 40)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'UltraButtonInvalid
        '
        Appearance1.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.verslag_cancel_16
        Me.UltraButtonInvalid.Appearance = Appearance1
        Me.UltraButtonInvalid.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonInvalid.Location = New System.Drawing.Point(302, 10)
        Me.UltraButtonInvalid.Name = "UltraButtonInvalid"
        Me.UltraButtonInvalid.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonInvalid.TabIndex = 40
        Me.UltraButtonInvalid.Text = "Ongeldig"
        '
        'CheckBoxNaarCHIP
        '
        Me.CheckBoxNaarCHIP.Location = New System.Drawing.Point(788, 10)
        Me.CheckBoxNaarCHIP.Name = "CheckBoxNaarCHIP"
        Me.CheckBoxNaarCHIP.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxNaarCHIP.TabIndex = 39
        Me.CheckBoxNaarCHIP.Text = "-> verst. nr CHIP"
        Me.CheckBoxNaarCHIP.Visible = False
        '
        'UltraButtonVernieuwen
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonVernieuwen.Appearance = Appearance2
        Me.UltraButtonVernieuwen.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonVernieuwen.Location = New System.Drawing.Point(208, 10)
        Me.UltraButtonVernieuwen.Name = "UltraButtonVernieuwen"
        Me.UltraButtonVernieuwen.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonVernieuwen.TabIndex = 38
        Me.UltraButtonVernieuwen.Text = "Vernieuwen"
        '
        'CheckBoxVersturenPostoverste
        '
        Me.CheckBoxVersturenPostoverste.Location = New System.Drawing.Point(400, 8)
        Me.CheckBoxVersturenPostoverste.Name = "CheckBoxVersturenPostoverste"
        Me.CheckBoxVersturenPostoverste.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxVersturenPostoverste.TabIndex = 10
        Me.CheckBoxVersturenPostoverste.Text = "-> verst. nr postoverste"
        '
        'CheckBoxVersturenBestemmelingen
        '
        Me.CheckBoxVersturenBestemmelingen.Location = New System.Drawing.Point(657, 9)
        Me.CheckBoxVersturenBestemmelingen.Name = "CheckBoxVersturenBestemmelingen"
        Me.CheckBoxVersturenBestemmelingen.Size = New System.Drawing.Size(125, 24)
        Me.CheckBoxVersturenBestemmelingen.TabIndex = 9
        Me.CheckBoxVersturenBestemmelingen.Text = "-> verst. nr bestemm."
        '
        'CheckBoxGoedkeuring
        '
        Me.CheckBoxGoedkeuring.Location = New System.Drawing.Point(541, 8)
        Me.CheckBoxGoedkeuring.Name = "CheckBoxGoedkeuring"
        Me.CheckBoxGoedkeuring.Size = New System.Drawing.Size(110, 24)
        Me.CheckBoxGoedkeuring.TabIndex = 8
        Me.CheckBoxGoedkeuring.Text = "-> goed te keuren"
        '
        'UltraButtonSluiten
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance3
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(900, 10)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonSluiten.TabIndex = 5
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraButtonOpenen
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonOpenen.Appearance = Appearance4
        Me.UltraButtonOpenen.Location = New System.Drawing.Point(112, 10)
        Me.UltraButtonOpenen.Name = "UltraButtonOpenen"
        Me.UltraButtonOpenen.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonOpenen.TabIndex = 4
        Me.UltraButtonOpenen.Text = "Openen"
        '
        'UltraButtonAfdrukken
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance5
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(16, 10)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonAfdrukken.TabIndex = 3
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraPrintPreviewDialogInterventies
        '
        Me.UltraPrintPreviewDialogInterventies.Document = Me.UltraGridPrintDocumentRegistraties
        Me.UltraPrintPreviewDialogInterventies.Name = "UltraPrintPreviewDialogInterventies"
        '
        'UltraGridPrintDocumentRegistraties
        '
        Me.UltraGridPrintDocumentRegistraties.Grid = Me.UltraGridRegistratieOverzicht
        '
        'UltraGridRegistratieOverzicht
        '
        Me.UltraGridRegistratieOverzicht.DataMember = "BBBEWREG"
        Me.UltraGridRegistratieOverzicht.DataSource = Me._dataRegBew
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Appearance = Appearance6
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn1.Header.VisiblePosition = 23
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 37
        UltraGridColumn2.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn2.Header.VisiblePosition = 24
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 79
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn3.Header.Caption = "Naam Opsteller"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 96
        UltraGridColumn30.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn30.Header.Caption = "Voornaam Opsteller"
        UltraGridColumn30.Header.VisiblePosition = 4
        UltraGridColumn31.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn31.Header.Caption = "Ploeg"
        UltraGridColumn31.Header.VisiblePosition = 5
        UltraGridColumn31.Width = 53
        UltraGridColumn32.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn32.Header.Caption = "Registratie Type"
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn33.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn33.Header.Caption = "Volgnr"
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Width = 54
        UltraGridColumn34.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn34.Header.Caption = "Jaar"
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Width = 48
        UltraGridColumn35.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn35.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.GreaterThanOrEqualTo
        UltraGridColumn35.Header.Caption = "Datum opstelling"
        UltraGridColumn35.Header.VisiblePosition = 6
        UltraGridColumn35.Width = 95
        UltraGridColumn36.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn36.Header.VisiblePosition = 25
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.Width = 82
        UltraGridColumn37.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn37.Header.Caption = "Plaats incident"
        UltraGridColumn37.Header.VisiblePosition = 9
        UltraGridColumn37.Width = 148
        UltraGridColumn38.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn38.Header.Caption = "Datum verz rapp."
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn38.Width = 101
        UltraGridColumn39.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn39.Header.Caption = "Datum goedkeuring"
        UltraGridColumn39.Header.VisiblePosition = 12
        UltraGridColumn39.Width = 112
        UltraGridColumn40.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn40.Header.Caption = "Datum verz best."
        UltraGridColumn40.Header.VisiblePosition = 13
        UltraGridColumn40.Width = 104
        UltraGridColumn41.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn41.Header.VisiblePosition = 20
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 60
        UltraGridColumn42.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn42.Header.VisiblePosition = 18
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Width = 67
        UltraGridColumn43.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn43.Header.VisiblePosition = 22
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 68
        UltraGridColumn44.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn44.Header.VisiblePosition = 17
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn45.Header.VisiblePosition = 21
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn46.Header.Caption = "Korte oms."
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn47.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn47.Header.VisiblePosition = 29
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn48.Header.Caption = "Datum CHIP"
        UltraGridColumn48.Header.VisiblePosition = 15
        UltraGridColumn49.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn49.Header.VisiblePosition = 19
        UltraGridColumn50.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn50.DefaultCellValue = "False"
        UltraGridColumn50.Header.Caption = "CHIP"
        UltraGridColumn50.Header.VisiblePosition = 16
        UltraGridColumn51.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn51.Header.Caption = "Vera Rapport"
        UltraGridColumn51.Header.VisiblePosition = 26
        UltraGridColumn52.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn52.Header.Caption = "Ivm Contractant"
        UltraGridColumn52.Header.VisiblePosition = 27
        UltraGridColumn53.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn53.Header.Caption = "Mail sent IKP"
        UltraGridColumn53.Header.VisiblePosition = 14
        UltraGridColumn54.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn54.Header.Caption = "Ongeldig: datum"
        UltraGridColumn54.Header.VisiblePosition = 28
        UltraGridColumn55.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn55.Header.Caption = "Ongeldig: gebruiker"
        UltraGridColumn55.Header.VisiblePosition = 30
        UltraGridColumn56.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn56.Header.Caption = "Ongeldig: opmerking"
        UltraGridColumn56.Header.VisiblePosition = 31
        UltraGridColumn57.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn57.DataType = GetType(Date)
        UltraGridColumn57.Format = "HH:mm"
        UltraGridColumn57.Header.Caption = "Uur incident"
        UltraGridColumn57.Header.VisiblePosition = 8
        UltraGridColumn57.MaskInput = "{time}"
        UltraGridColumn57.Width = 69
        UltraGridColumn58.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn58.DataType = GetType(Date)
        UltraGridColumn58.Format = "dd/MM/yyyy"
        UltraGridColumn58.Header.Caption = "Datum incident"
        UltraGridColumn58.Header.VisiblePosition = 7
        UltraGridColumn58.Width = 93
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
        Me.UltraGridRegistratieOverzicht.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridRegistratieOverzicht.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridRegistratieOverzicht.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratieOverzicht.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridRegistratieOverzicht.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraGridRegistratieOverzicht.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridRegistratieOverzicht.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridRegistratieOverzicht.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraGridRegistratieOverzicht.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridRegistratieOverzicht.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.RowAppearance = Appearance17
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.UltraGridRegistratieOverzicht.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
        Me.UltraGridRegistratieOverzicht.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridRegistratieOverzicht.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridRegistratieOverzicht.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRegistratieOverzicht.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridRegistratieOverzicht.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridRegistratieOverzicht.Name = "UltraGridRegistratieOverzicht"
        Me.UltraGridRegistratieOverzicht.Size = New System.Drawing.Size(1229, 640)
        Me.UltraGridRegistratieOverzicht.TabIndex = 0
        Me.UltraGridRegistratieOverzicht.Text = "Registratie Overzicht"
        Me.UltraGridRegistratieOverzicht.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataRegBew
        '
        Me._dataRegBew.DataSetName = "TDSRegBew"
        Me._dataRegBew.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegBew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 692)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1229, 22)
        Me._statusBar.TabIndex = 1003
        Me._statusBar.User = ""
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridRegistratieOverzicht)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1229, 692)
        Me.SplitContainer1.SplitterDistance = 640
        Me.SplitContainer1.TabIndex = 1004
        '
        'FormBewakingRegistratieOverzicht
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1229, 714)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me._statusBar)
        Me.Name = "FormBewakingRegistratieOverzicht"
        Me.Text = "Overzicht Bewakingsregistratie"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraGridRegistratieOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegBew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FormBewakingRegistratieOverzicht_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor

            If FormManager.Current.PostOverste Or FormManager.Current.BbwVerantwoordelijke Then
                CheckBoxGoedkeuring.Visible = True
            Else
                CheckBoxGoedkeuring.Visible = False
            End If

            If FormManager.Current.BbwVerantwoordelijke Then
                CheckBoxVersturenBestemmelingen.Visible = True
                CheckBoxNaarCHIP.Visible = True
            Else
                CheckBoxVersturenBestemmelingen.Visible = False
            End If

            If FormManager.Current.Chip Then
                CheckBoxNaarCHIP.Visible = True
                CheckBoxVersturenPostoverste.Visible = False
            End If

            UltraButtonInvalid.Enabled = FormManager.Current.CanInvalidateReport

            _controller = New ControllerGetData
            Me._dataRegBew.Merge(Me._controller.GetRegistraties)

            Cursor.Current = Cursors.Default

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

            Dim toolTipButtonInvalid As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip
            toolTipButtonInvalid.SetToolTip(UltraButtonInvalid, "Ongeldige verslagen = achtergrond lichtgrijs")
            toolTipButtonInvalid.Active = True

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingRegistratieOverzicht - FormBewakingRegistratieOverzicht_Load" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub UltraGridRegistratieOverzicht_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridRegistratieOverzicht.InitializeLayout

        Try
            'naco - 02/01/2007
            'filter toevoegen op DT_INC (alles tonen >= 1ste van de maand)
            UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_INC").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, _
                                                        New DateTime(Year(Today), Month(Today), 1))

            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_REG"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridRegistratieOverzicht_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridRegistratieOverzicht.DoubleClickRow
        Try
            If Not Me.UltraGridRegistratieOverzicht.ActiveRow Is Nothing Then
                openRegistratieForm(CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_TY_REG").Value))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonAfsluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)

        End Try
    End Sub

    Private Sub UltraGridRegistratieOverzicht_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridRegistratieOverzicht.InitializeRow
        Try
            e.Row.Cells("DT_INC").Value = e.Row.Cells("TMS_INC").Value
            e.Row.Cells("TYD_INC").Value = CType(e.Row.Cells("TMS_INC").Value, DateTime).ToShortTimeString
            If Not IsDBNull(e.Row.Cells("DateInvalid").Value) Then
                e.Row.CellAppearance.BackColor = Color.LightGray
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpenen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpenen.Click
        'Doel:   Registratieform openen
        'Auteur: Koen Heye - mei 2006
        Try
            If Not Me.UltraGridRegistratieOverzicht.ActiveRow Is Nothing Then
                If Not IsDBNull(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_TY_REG").Value) Then
                    openRegistratieForm(CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_TY_REG").Value))
                Else
                    MessageBox.Show("Gelieve een registratie te selecteren aub.", "Selecteer registratie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        Try
            Me.UltraPrintPreviewDialogInterventies.ShowDialog(Me.UltraGridRegistratieOverzicht)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub CheckBoxGoedkeuring_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxGoedkeuring.CheckedChanged
        'Doel:   enkel de nog te keuren registraties tonen
        'Auteur: Nancy Coppens - 22/09/2006
        Try
            FiltersOnCheckboxes()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingRegistratieOverzicht - CheckBoxGoedkeuring_CheckedChanged" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CheckBoxVersturenBestemmelingen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenBestemmelingen.CheckedChanged
        'Doel:   enkel de nog te versturen naar bestemmelingen registraties tonen
        'Auteur: Nancy Coppens - 22/09/2006
        Try
            FiltersOnCheckboxes()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBewakingRegistratieOverzicht - CheckBoxVersturenBestemmelingen_CheckedChanged" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub CheckBoxVersturenPostoverste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxVersturenPostoverste.CheckedChanged
        'Doel:   alle registraties tonen die nog moeten verstuurd worden naar de postoverste
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            FiltersOnCheckboxes()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingRegistratieOverzicht " & _
                            "- CheckBoxVersturenPostoverste_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub CheckBoxNaarCHIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNaarCHIP.CheckedChanged
        'Doel:   alle registraties tonen gemarkeerd zijn voor CHIP maar nog niet verstuurd zijn
        'Auteur: Nancy Coppens - 04/03/2011

        Try
            FiltersOnCheckboxes()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingRegistratieOverzicht " & _
                            "- CheckBoxNaarCHIP_CheckedChanged " & vbCrLf & _
                            ex.Message & vbCrLf & "Stacktrace: " & ex.StackTrace, _
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridPrintDocumentRegistraties_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocumentRegistraties.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocumentRegistraties.PageNumber
            e.Section.TextLeft = "Datum afdruk: " & Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonVernieuwen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonVernieuwen.Click
        ReloadScreen()
    End Sub

    Private Sub UltraGridRegistratieOverzicht_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridRegistratieOverzicht.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Nancy Coppens - 19/12/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Bewaking: Overzicht registraties"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Bewaking: Overzicht registraties"

            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonInvalid_Click(sender As System.Object, e As System.EventArgs) Handles UltraButtonInvalid.Click
        Try
            If Not Me.UltraGridRegistratieOverzicht.ActiveRow Is Nothing Then
                If Not IsDBNull(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Value) Then

                    Dim form As FormBewakingOngeldigVerslag = New FormBewakingOngeldigVerslag(Convert.ToInt32(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Value),
                                                                                              UltraGridRegistratieOverzicht.ActiveRow.Cells("SCF_TY_REG").Value.ToString(),
                                                                                              Convert.ToInt32(UltraGridRegistratieOverzicht.ActiveRow.Cells("VLG_REG_JR_BPL").Value))
                    If (form.ShowDialog() = DialogResult.OK) Then
                        ReloadScreen()
                    End If
                Else
                    MessageBox.Show("Gelieve een registratie te selecteren aub.", "Selecteer registratie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Functions"

    Private Sub ReloadScreen()
        'Doel:  als er een nieuwe registratie is toegevoegd, de dataset refreshen (door de gebruiker)
        'Auteur: Nancy Coppens - 08/12/2006

        Try
            Me.Cursor = Cursors.WaitCursor

            _controller = New ControllerGetData
            Me._dataRegBew.Clear()
            Me._dataRegBew.Merge(Me._controller.GetRegistraties)

            Me.Cursor = Cursors.Default

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
                    FormManager.Current.OpenFormAanrijding(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 8
                    Me.setStatus("Openen Registratie Alcoholtest")
                    FormManager.Current.OpenFormAlcoholtest(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 2
                    Me.setStatus("Openen Registratie Controle op voertuigen")
                    FormManager.Current.OpenFormControleVoertuigen(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 3
                    Me.setStatus("Openen Registratie Diefstal")
                    FormManager.Current.OpenFormDiefstal(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 7
                    Me.setStatus("Openen Registratie Diverse Registratie")
                    FormManager.Current.OpenFormDiverseRegistratie(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 4
                    Me.setStatus("Openen Registratie Inbreuk op reglementen")
                    FormManager.Current.OpenFormInbreukReglementen(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 6
                    Me.setStatus("Openen Registratie Openmaken kleerkast")
                    FormManager.Current.OpenFormOpenmakenKleerkast(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 5
                    Me.setStatus("Openen Registratie Schadegeval")
                    FormManager.Current.OpenFormSchadegeval(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
                Case 9
                    Me.setStatus("Openen Registratie milieuverontreiniging")
                    FormManager.Current.OpenFormBewakingMilieuVerontreiniging(False, False, True, CInt(UltraGridRegistratieOverzicht.ActiveRow.Cells("ID_REG").Text))
            End Select
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

    Private Sub FiltersOnCheckboxes()
        'Doel:   Filters instellen via de checkboxen
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
            'naco - 05/03/2007 - alle filters uitzetten! Omdat er default een filter staat op de 1ste van de huidige maand,
            'werden soms rapporten vergeten als je "nog te versturen naar bestemmeling" opvraagt

            If CheckBoxVersturenPostoverste.Checked Then
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
            Else
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_RAP_NW").FilterConditions.Clear()
            End If

            If CheckBoxGoedkeuring.Checked Then
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DateInvalid").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
                '05/01/2017 - naco - verslagen die ongeldig zijn => niet goedkeuren (vraag van Hans De Vijlder)
            Else
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_OK").FilterConditions.Clear()
            End If

            If CheckBoxVersturenBestemmelingen.Checked Then
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DateInvalid").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
                '05/01/2017 - naco - verslagen die ongeldig zijn => niet goedkeuren (vraag van Hans De Vijlder)
            Else
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_VZ_BST").FilterConditions.Clear()
            End If
            If CheckBoxNaarCHIP.Checked Then
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_CHIP").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, Nothing)
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("CHIP_YN").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, True)
            Else
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("DT_CHIP").FilterConditions.Clear()
                UltraGridRegistratieOverzicht.DisplayLayout.Bands(0).ColumnFilters("CHIP_YN").FilterConditions.Clear()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

End Class
