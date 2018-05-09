Option Strict On
Option Explicit On 

Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBrandweerOverzichtInterventies
    Inherits Form

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
    Friend WithEvents GroupBoxActies As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridOverzicht As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataIntvBr As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvBr
    Friend WithEvents UltraPrintPreviewDialogInterventies As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridPrintDocumentInterventies As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpenen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CheckBoxGoedkeuring As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVersturenBestemmelingen As System.Windows.Forms.CheckBox
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents CheckBoxVersturenPostoverste As System.Windows.Forms.CheckBox
    Friend WithEvents UltraButtonVernieuwen As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerOverzichtInterventies))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfoId")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VolgnrAfd")
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
        Me.GroupBoxOverzicht = New System.Windows.Forms.GroupBox()
        Me.GroupBoxActies = New System.Windows.Forms.GroupBox()
        Me.UltraButtonVernieuwen = New Infragistics.Win.Misc.UltraButton()
        Me.CheckBoxVersturenPostoverste = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVersturenBestemmelingen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGoedkeuring = New System.Windows.Forms.CheckBox()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpenen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPrintPreviewDialogInterventies = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGridPrintDocumentInterventies = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me.UltraGridOverzicht = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataIntvBr = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvBr()
        Me.GroupBoxOverzicht.SuspendLayout()
        Me.GroupBoxActies.SuspendLayout()
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIntvBr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxOverzicht
        '
        Me.GroupBoxOverzicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxOverzicht.Controls.Add(Me.UltraGridOverzicht)
        Me.GroupBoxOverzicht.Location = New System.Drawing.Point(8, 8)
        Me.GroupBoxOverzicht.Name = "GroupBoxOverzicht"
        Me.GroupBoxOverzicht.Size = New System.Drawing.Size(1000, 301)
        Me.GroupBoxOverzicht.TabIndex = 1
        Me.GroupBoxOverzicht.TabStop = False
        Me.GroupBoxOverzicht.Text = "Overzicht"
        '
        'GroupBoxActies
        '
        Me.GroupBoxActies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonVernieuwen)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxVersturenPostoverste)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxVersturenBestemmelingen)
        Me.GroupBoxActies.Controls.Add(Me.CheckBoxGoedkeuring)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonOpenen)
        Me.GroupBoxActies.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxActies.Location = New System.Drawing.Point(8, 309)
        Me.GroupBoxActies.Name = "GroupBoxActies"
        Me.GroupBoxActies.Size = New System.Drawing.Size(1000, 40)
        Me.GroupBoxActies.TabIndex = 2
        Me.GroupBoxActies.TabStop = False
        '
        'UltraButtonVernieuwen
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonVernieuwen.Appearance = Appearance14
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
        'UltraButtonSluiten
        '
        Me.UltraButtonSluiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance15
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(900, 10)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonSluiten.TabIndex = 5
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraButtonOpenen
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.UltraButtonOpenen.Appearance = Appearance16
        Me.UltraButtonOpenen.Location = New System.Drawing.Point(112, 10)
        Me.UltraButtonOpenen.Name = "UltraButtonOpenen"
        Me.UltraButtonOpenen.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonOpenen.TabIndex = 4
        Me.UltraButtonOpenen.Text = "Openen"
        '
        'UltraButtonAfdrukken
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance17
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
        Me.UltraGridPrintDocumentInterventies.Grid = Me.UltraGridOverzicht
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 351)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 1001
        Me._statusBar.User = ""
        '
        'UltraGridOverzicht
        '
        Me.UltraGridOverzicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGridOverzicht.DataMember = "BBINTVBR"
        Me.UltraGridOverzicht.DataSource = Me._dataIntvBr
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridOverzicht.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
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
        UltraGridColumn7.Width = 86
        UltraGridColumn8.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn8.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridColumn8.Header.Caption = "Plaats tussenkomst"
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Width = 175
        UltraGridColumn9.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn9.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridColumn9.Header.Caption = "Aard"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Width = 175
        UltraGridColumn10.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn10.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridColumn10.Header.Caption = "Oorzaak"
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 175
        UltraGridColumn11.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn11.Header.Caption = "Geblust afd"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Width = 85
        UltraGridColumn12.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn12.Header.Caption = "Geblust BW"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Width = 85
        UltraGridColumn13.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn13.Header.Caption = "Oproep BW"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Width = 85
        UltraGridColumn14.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn14.Header.Caption = "Inc verslag "
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Width = 85
        UltraGridColumn15.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn15.Header.Caption = "Datum verz rapp."
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn16.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn16.Header.Caption = "Datum goedkeuring"
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn17.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn17.Header.Caption = "Datum verz best."
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridColumn19.Header.Caption = "Brand Extra Info"
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn20.Header.Caption = "Vera Rapport"
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn21.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn21.Header.Caption = "Ivm Contractant"
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn43.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Width = 69
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn43})
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
        Me.UltraGridOverzicht.Size = New System.Drawing.Size(976, 277)
        Me.UltraGridOverzicht.TabIndex = 0
        Me.UltraGridOverzicht.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataIntvBr
        '
        Me._dataIntvBr.DataSetName = "TDSIntvBr"
        Me._dataIntvBr.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIntvBr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBrandweerOverzichtInterventies
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 373)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.GroupBoxActies)
        Me.Controls.Add(Me.GroupBoxOverzicht)
        Me.MinimumSize = New System.Drawing.Size(1024, 400)
        Me.Name = "FormBrandweerOverzichtInterventies"
        Me.ShowInTaskbar = False
        Me.Text = "Overzicht Interventies"
        Me.GroupBoxOverzicht.ResumeLayout(False)
        Me.GroupBoxActies.ResumeLayout(False)
        CType(Me.UltraGridOverzicht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIntvBr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Load"
    Private Sub FormBrandweerOverzichtInterventies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor

            If FormManager.Current.PostOverste Or FormManager.Current.BBWVerantwoordelijke Then
                CheckBoxGoedkeuring.Visible = True
            Else
                CheckBoxGoedkeuring.Visible = False
            End If

            If FormManager.Current.BBWVerantwoordelijke = True Then
                CheckBoxVersturenBestemmelingen.Visible = True
            Else
                CheckBoxVersturenBestemmelingen.Visible = False
            End If

            _controller = New ControllerGetData

            Me._dataIntvBr.Merge(Me._controller.GetInterventies)

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
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "Events"
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

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
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
            Me._dataIntvBr.Clear()
            Me._dataIntvBr.Merge(Me._controller.GetInterventies)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try

    End Sub
End Class
