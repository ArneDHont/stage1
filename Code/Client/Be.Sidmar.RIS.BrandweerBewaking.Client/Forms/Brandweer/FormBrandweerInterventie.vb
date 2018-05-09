Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Reflection
Imports ADF.ExceptionHandling

Public Class FormBrandweerInterventie
    Inherits System.Windows.Forms.Form


#Region "Constants"
    Private ReadOnly _interventieType As Integer
    Private ReadOnly _interventieDesc As String
    Private ReadOnly _dsInterventie As New Proxy.BBWService.Mgt.TDSInterventie
    Private _idInterventie As Integer
    Private _errorString As String
    Private _controller As ControllerGetData
    Friend WithEvents GroupBoxExtraInfoBrand As GroupBox
    Friend WithEvents UltraOptionSetExtraInfoBrand As Infragistics.Win.UltraWinEditors.UltraOptionSet

    Protected StandaardZin As String '= Configuration.ConfigurationSettings.AppSettings("StandaardzinMilieuverslagBrandweer")

#End Region
#Region "Construction / Destruction"

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        initializeDataSet()
        initializeDataSetIndividuen()
        initializeMailInfo()
    End Sub

    Public Sub New(ByVal interventieId As Integer, ByVal interventieOmschrijving As String, ByVal idInterventie As Integer)
        MyBase.New()
        Try
            InitializeComponent()
            InitializeDataSet()
            InitializeDataSetIndividuen()
            initializeMailInfo()
            _interventieType = interventieId
            _interventieDesc = interventieOmschrijving
            _idInterventie = idInterventie
            _controller = New ControllerGetData

            If idInterventie = -1 Then
                'nieuw verslag - enkel actieve brandweermannen tonen
                _dataBRPersoneel.Merge(_controller.GetBRPersoneelActief())
                UserControlGeneralFunctionsBrandweer.setPersoneelData(_dataBRPersoneel)
            Else
                _dataBRPersoneel.Merge(_controller.GetBRPersoneel())
                UserControlGeneralFunctionsBrandweer.setPersoneelData(_dataBRPersoneel)
            End If

            If (interventieId = 2) Then
                UltraOptionSetGeblust.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - New" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

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

#End Region

    ' GMAE - 2013-06-20: changed the alternate colour in the grids from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents GroupBoxAlgemeen As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOmschrijving As System.Windows.Forms.TextBox
    Friend WithEvents LabelOmschrijving As System.Windows.Forms.Label
    Friend WithEvents LabelOorzaak As System.Windows.Forms.Label
    Friend WithEvents LabelAard As System.Windows.Forms.Label
    Friend WithEvents TextBoxWerk_vuurverg As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTussenkomst As System.Windows.Forms.TextBox
    Friend WithEvents LabelTijdstip As System.Windows.Forms.Label
    Friend WithEvents TextBoxOpgeroepen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVolgnummer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelAfdeling As System.Windows.Forms.Label
    Friend WithEvents LabelDatumInterventie As System.Windows.Forms.Label
    Friend WithEvents GroupBoxKosten As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxOverige As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxInterventie As System.Windows.Forms.GroupBox
    Friend WithEvents LabelInterventieType As System.Windows.Forms.Label
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents UltraComboAfdelingen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents _dataOorzaken As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOorzaken
    Friend WithEvents _dataAarden As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAarden
    Friend WithEvents UltraComboAarden As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraComboOorzaak As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGridKosten As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataInterventieArtikelen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt
    Friend WithEvents TextBoxJaar As System.Windows.Forms.TextBox
    Friend WithEvents UserControlGeneralFunctionsBrandweer As Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions
    Friend WithEvents _dataInterventie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInterventie
    Friend WithEvents UltraDropDownArtikelenKost As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDropDownInterventieTijden As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraCalcManagerKosten As Infragistics.Win.UltraWinCalcManager.UltraCalcManager
    Friend WithEvents _dataBRPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBRPersoneel
    Friend WithEvents _dataWagens As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt
    Friend WithEvents UltraMaskedEditTijdstip As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOverzicht As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBoxInterventieTijden As System.Windows.Forms.GroupBox
    Friend WithEvents UltraGridInterventieTijden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraMaskedEditTime As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
    Friend WithEvents _statusBar As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents LabelBestemmelingenOud As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraOptionSetGeblust As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents CheckBoxIncOntvangen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBWOproep As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxExtraInfo As System.Windows.Forms.GroupBox
    Friend WithEvents UltraDateTimeEditorBestemmelingen As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorGoedkeuring As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditorVerzending As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents TextBoxVerzending As System.Windows.Forms.TextBox
    Friend WithEvents ButtonVerzendingBest As System.Windows.Forms.Button
    Friend WithEvents ButtonVerzendingBBW As System.Windows.Forms.Button
    Friend WithEvents TextBoxGoedkeuring As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVerzendingBestemmelingen As System.Windows.Forms.TextBox
    Friend WithEvents LabelVerzendingBest As System.Windows.Forms.Label
    Friend WithEvents LabelGoedkeuring As System.Windows.Forms.Label
    Friend WithEvents LabelOpgeroepen As System.Windows.Forms.Label
    Friend WithEvents LabelTussenkomst As System.Windows.Forms.Label
    Friend WithEvents LabelWerkvuurvergunning As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeDatumOpmaak As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonTerugZenden As System.Windows.Forms.Button
    Friend WithEvents ButtonGoedkeuring As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Opmerking BBWVerantwoordelijke", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo4 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Opmerking goedkeurder", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo5 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Opmerking opsteller", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Naar Bestemmelingen", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Naar Postoverste", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRRD", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BR_RD_INTV")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_RD_INTV")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BZ")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRTY", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BR_TY_INTV")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_TY_INTV")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BZ")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTART", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INTV")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_EH_ART_INTV")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TSP_DU_INTV")
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
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTART", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INTV")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_EH_ART_INTV")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TSP_DU_INTV")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBMATPR", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_PR_MAT")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INTV")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INTV")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Q_ART")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_TOT_ART")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_EH_ART_INTV")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerInterventie))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTVDU", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DU_INTV")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INTV")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYD_OPR")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYD_KO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYD_END")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.UltraMaskedEditTime = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.TextBoxVerzendingBestemmelingen = New System.Windows.Forms.TextBox()
        Me.TextBoxGoedkeuring = New System.Windows.Forms.TextBox()
        Me.TextBoxVerzending = New System.Windows.Forms.TextBox()
        Me.ButtonVerzendingBest = New System.Windows.Forms.Button()
        Me.ButtonVerzendingBBW = New System.Windows.Forms.Button()
        Me.GroupBoxAlgemeen = New System.Windows.Forms.GroupBox()
        Me.UltraDateTimeDatumOpmaak = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraMaskedEditTijdstip = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.TextBoxJaar = New System.Windows.Forms.TextBox()
        Me.UltraComboOorzaak = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraCalcManagerKosten = New Infragistics.Win.UltraWinCalcManager.UltraCalcManager(Me.components)
        Me._dataOorzaken = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOorzaken()
        Me.UltraComboAarden = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAarden = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAarden()
        Me.UltraComboAfdelingen = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.LabelInterventieType = New System.Windows.Forms.Label()
        Me.TextBoxOmschrijving = New System.Windows.Forms.TextBox()
        Me.LabelOmschrijving = New System.Windows.Forms.Label()
        Me.LabelOorzaak = New System.Windows.Forms.Label()
        Me.LabelAard = New System.Windows.Forms.Label()
        Me.TextBoxWerk_vuurverg = New System.Windows.Forms.TextBox()
        Me.LabelWerkvuurvergunning = New System.Windows.Forms.Label()
        Me.TextBoxTussenkomst = New System.Windows.Forms.TextBox()
        Me.LabelTussenkomst = New System.Windows.Forms.Label()
        Me.LabelTijdstip = New System.Windows.Forms.Label()
        Me.TextBoxOpgeroepen = New System.Windows.Forms.TextBox()
        Me.LabelOpgeroepen = New System.Windows.Forms.Label()
        Me.TextBoxVolgnummer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelAfdeling = New System.Windows.Forms.Label()
        Me.LabelDatumInterventie = New System.Windows.Forms.Label()
        Me.GroupBoxKosten = New System.Windows.Forms.GroupBox()
        Me.UltraDropDownInterventieTijden = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataWagens = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt()
        Me.UltraDropDownArtikelenKost = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataInterventieArtikelen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt()
        Me.UltraGridKosten = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataInterventie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInterventie()
        Me.GroupBoxOverige = New System.Windows.Forms.GroupBox()
        Me.UserControlGeneralFunctionsBrandweer = New Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions()
        Me.LabelBestemmelingenOud = New System.Windows.Forms.Label()
        Me.GroupBoxInterventie = New System.Windows.Forms.GroupBox()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOverzicht = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me._dataBRPersoneel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBRPersoneel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBoxInterventieTijden = New System.Windows.Forms.GroupBox()
        Me.UltraGridInterventieTijden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        Me._statusBar = New ADF.Windows.Forms.UserControls.StatusBar()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonTerugZenden = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditorBestemmelingen = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateTimeEditorGoedkeuring = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateTimeEditorVerzending = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ButtonGoedkeuring = New System.Windows.Forms.Button()
        Me.LabelVerzendingBest = New System.Windows.Forms.Label()
        Me.LabelGoedkeuring = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UltraOptionSetGeblust = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.CheckBoxIncOntvangen = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBWOproep = New System.Windows.Forms.CheckBox()
        Me.GroupBoxExtraInfo = New System.Windows.Forms.GroupBox()
        Me.GroupBoxExtraInfoBrand = New System.Windows.Forms.GroupBox()
        Me.UltraOptionSetExtraInfoBrand = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.GroupBoxAlgemeen.SuspendLayout()
        CType(Me.UltraDateTimeDatumOpmaak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboOorzaak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCalcManagerKosten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOorzaken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboAarden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAarden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxKosten.SuspendLayout()
        CType(Me.UltraDropDownInterventieTijden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataWagens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownArtikelenKost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInterventieArtikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridKosten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInterventie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOverige.SuspendLayout()
        Me.GroupBoxInterventie.SuspendLayout()
        CType(Me._dataBRPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInterventieTijden.SuspendLayout()
        CType(Me.UltraGridInterventieTijden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetGeblust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxExtraInfo.SuspendLayout()
        Me.GroupBoxExtraInfoBrand.SuspendLayout()
        CType(Me.UltraOptionSetExtraInfoBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraMaskedEditTime
        '
        Me.UltraMaskedEditTime.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.UltraMaskedEditTime.InputMask = "{time}"
        Me.UltraMaskedEditTime.Location = New System.Drawing.Point(896, 152)
        Me.UltraMaskedEditTime.Name = "UltraMaskedEditTime"
        Me.UltraMaskedEditTime.NonAutoSizeHeight = 20
        Me.UltraMaskedEditTime.Size = New System.Drawing.Size(40, 20)
        Me.UltraMaskedEditTime.TabIndex = 7
        Me.UltraMaskedEditTime.Text = ":"
        Me.UltraMaskedEditTime.Visible = False
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.Standard
        '
        'TextBoxVerzendingBestemmelingen
        '
        Me.TextBoxVerzendingBestemmelingen.Location = New System.Drawing.Point(64, 152)
        Me.TextBoxVerzendingBestemmelingen.MaxLength = 100
        Me.TextBoxVerzendingBestemmelingen.Name = "TextBoxVerzendingBestemmelingen"
        Me.TextBoxVerzendingBestemmelingen.Size = New System.Drawing.Size(392, 20)
        Me.TextBoxVerzendingBestemmelingen.TabIndex = 10
        UltraToolTipInfo3.ToolTipText = "Opmerking BBWVerantwoordelijke"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.TextBoxVerzendingBestemmelingen, UltraToolTipInfo3)
        '
        'TextBoxGoedkeuring
        '
        Me.TextBoxGoedkeuring.Location = New System.Drawing.Point(64, 96)
        Me.TextBoxGoedkeuring.MaxLength = 100
        Me.TextBoxGoedkeuring.Name = "TextBoxGoedkeuring"
        Me.TextBoxGoedkeuring.Size = New System.Drawing.Size(392, 20)
        Me.TextBoxGoedkeuring.TabIndex = 6
        UltraToolTipInfo4.ToolTipText = "Opmerking goedkeurder"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.TextBoxGoedkeuring, UltraToolTipInfo4)
        '
        'TextBoxVerzending
        '
        Me.TextBoxVerzending.Location = New System.Drawing.Point(64, 40)
        Me.TextBoxVerzending.MaxLength = 100
        Me.TextBoxVerzending.Name = "TextBoxVerzending"
        Me.TextBoxVerzending.Size = New System.Drawing.Size(392, 20)
        Me.TextBoxVerzending.TabIndex = 2
        UltraToolTipInfo5.ToolTipText = "Opmerking opsteller"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.TextBoxVerzending, UltraToolTipInfo5)
        '
        'ButtonVerzendingBest
        '
        Me.ButtonVerzendingBest.Location = New System.Drawing.Point(328, 128)
        Me.ButtonVerzendingBest.Name = "ButtonVerzendingBest"
        Me.ButtonVerzendingBest.Size = New System.Drawing.Size(128, 20)
        Me.ButtonVerzendingBest.TabIndex = 11
        Me.ButtonVerzendingBest.Text = "Naar bestemmelingen"
        UltraToolTipInfo1.ToolTipText = "Naar Bestemmelingen"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ButtonVerzendingBest, UltraToolTipInfo1)
        '
        'ButtonVerzendingBBW
        '
        Me.ButtonVerzendingBBW.Location = New System.Drawing.Point(328, 16)
        Me.ButtonVerzendingBBW.Name = "ButtonVerzendingBBW"
        Me.ButtonVerzendingBBW.Size = New System.Drawing.Size(128, 20)
        Me.ButtonVerzendingBBW.TabIndex = 3
        Me.ButtonVerzendingBBW.Text = "Naar Postoverste"
        UltraToolTipInfo2.ToolTipText = "Naar Postoverste"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.ButtonVerzendingBBW, UltraToolTipInfo2)
        '
        'GroupBoxAlgemeen
        '
        Me.GroupBoxAlgemeen.Controls.Add(Me.UltraDateTimeDatumOpmaak)
        Me.GroupBoxAlgemeen.Controls.Add(Me.UltraMaskedEditTijdstip)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxJaar)
        Me.GroupBoxAlgemeen.Controls.Add(Me.UltraComboOorzaak)
        Me.GroupBoxAlgemeen.Controls.Add(Me.UltraComboAarden)
        Me.GroupBoxAlgemeen.Controls.Add(Me.UltraComboAfdelingen)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelInterventieType)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxOmschrijving)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelOmschrijving)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelOorzaak)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelAard)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxWerk_vuurverg)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelWerkvuurvergunning)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxTussenkomst)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelTussenkomst)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelTijdstip)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxOpgeroepen)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelOpgeroepen)
        Me.GroupBoxAlgemeen.Controls.Add(Me.TextBoxVolgnummer)
        Me.GroupBoxAlgemeen.Controls.Add(Me.Label1)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelAfdeling)
        Me.GroupBoxAlgemeen.Controls.Add(Me.LabelDatumInterventie)
        Me.GroupBoxAlgemeen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxAlgemeen.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxAlgemeen.Name = "GroupBoxAlgemeen"
        Me.GroupBoxAlgemeen.Size = New System.Drawing.Size(872, 224)
        Me.GroupBoxAlgemeen.TabIndex = 0
        Me.GroupBoxAlgemeen.TabStop = False
        Me.GroupBoxAlgemeen.Text = "Algemeen"
        '
        'UltraDateTimeDatumOpmaak
        '
        Me.UltraDateTimeDatumOpmaak.Location = New System.Drawing.Point(136, 16)
        Me.UltraDateTimeDatumOpmaak.Name = "UltraDateTimeDatumOpmaak"
        Me.UltraDateTimeDatumOpmaak.Size = New System.Drawing.Size(144, 21)
        Me.UltraDateTimeDatumOpmaak.TabIndex = 41
        Me.UltraDateTimeDatumOpmaak.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraMaskedEditTijdstip
        '
        Me.UltraMaskedEditTijdstip.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.UltraMaskedEditTijdstip.Location = New System.Drawing.Point(376, 40)
        Me.UltraMaskedEditTijdstip.Name = "UltraMaskedEditTijdstip"
        Me.UltraMaskedEditTijdstip.NonAutoSizeHeight = 20
        Me.UltraMaskedEditTijdstip.Size = New System.Drawing.Size(56, 20)
        Me.UltraMaskedEditTijdstip.TabIndex = 6
        Me.UltraMaskedEditTijdstip.Text = "__:__"
        Me.UltraMaskedEditTijdstip.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'TextBoxJaar
        '
        Me.TextBoxJaar.Enabled = False
        Me.TextBoxJaar.Location = New System.Drawing.Point(560, 16)
        Me.TextBoxJaar.Name = "TextBoxJaar"
        Me.TextBoxJaar.ReadOnly = True
        Me.TextBoxJaar.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxJaar.TabIndex = 2
        '
        'UltraComboOorzaak
        '
        Me.UltraComboOorzaak.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraComboOorzaak.DataSource = Me._dataOorzaken.BBBRRD
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboOorzaak.DisplayLayout.Appearance = Appearance59
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Omschrijving"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Width = 280
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.UltraComboOorzaak.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.UltraComboOorzaak.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboOorzaak.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboOorzaak.DisplayLayout.GroupByBox.Appearance = Appearance60
        Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboOorzaak.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance61
        Me.UltraComboOorzaak.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance62.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance62.BackColor2 = System.Drawing.SystemColors.Control
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance62.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboOorzaak.DisplayLayout.GroupByBox.PromptAppearance = Appearance62
        Me.UltraComboOorzaak.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboOorzaak.DisplayLayout.MaxRowScrollRegions = 1
        Appearance63.BackColor = System.Drawing.SystemColors.Window
        Appearance63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboOorzaak.DisplayLayout.Override.ActiveCellAppearance = Appearance63
        Appearance64.BackColor = System.Drawing.SystemColors.Highlight
        Appearance64.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboOorzaak.DisplayLayout.Override.ActiveRowAppearance = Appearance64
        Me.UltraComboOorzaak.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboOorzaak.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance65.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboOorzaak.DisplayLayout.Override.CardAreaAppearance = Appearance65
        Appearance66.BorderColor = System.Drawing.Color.Silver
        Appearance66.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboOorzaak.DisplayLayout.Override.CellAppearance = Appearance66
        Me.UltraComboOorzaak.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboOorzaak.DisplayLayout.Override.CellPadding = 0
        Appearance67.BackColor = System.Drawing.SystemColors.Control
        Appearance67.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance67.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance67.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboOorzaak.DisplayLayout.Override.GroupByRowAppearance = Appearance67
        Appearance68.TextHAlignAsString = "Left"
        Me.UltraComboOorzaak.DisplayLayout.Override.HeaderAppearance = Appearance68
        Me.UltraComboOorzaak.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboOorzaak.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance69.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboOorzaak.DisplayLayout.Override.RowAlternateAppearance = Appearance69
        Appearance70.BackColor = System.Drawing.SystemColors.Window
        Appearance70.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboOorzaak.DisplayLayout.Override.RowAppearance = Appearance70
        Me.UltraComboOorzaak.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance71.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboOorzaak.DisplayLayout.Override.TemplateAddRowAppearance = Appearance71
        Me.UltraComboOorzaak.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboOorzaak.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboOorzaak.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboOorzaak.DisplayMember = "SCF_BR_RD_INTV"
        Me.UltraComboOorzaak.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboOorzaak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboOorzaak.Location = New System.Drawing.Point(560, 88)
        Me.UltraComboOorzaak.Name = "UltraComboOorzaak"
        Me.UltraComboOorzaak.Size = New System.Drawing.Size(296, 22)
        Me.UltraComboOorzaak.TabIndex = 10
        Me.UltraComboOorzaak.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboOorzaak.ValueMember = "ID_BR_RD_INTV"
        '
        'UltraCalcManagerKosten
        '
        Me.UltraCalcManagerKosten.ContainingControl = Me
        '
        '_dataOorzaken
        '
        Me._dataOorzaken.DataSetName = "TDSOorzaken"
        Me._dataOorzaken.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataOorzaken.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraComboAarden
        '
        Me.UltraComboAarden.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraComboAarden.DataSource = Me._dataAarden.BBBRTY
        Appearance72.BackColor = System.Drawing.SystemColors.Window
        Appearance72.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAarden.DisplayLayout.Appearance = Appearance72
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Omschrijving"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Width = 280
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn45})
        Me.UltraComboAarden.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.UltraComboAarden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboAarden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance73.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance73.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAarden.DisplayLayout.GroupByBox.Appearance = Appearance73
        Appearance74.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAarden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance74
        Me.UltraComboAarden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance75.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance75.BackColor2 = System.Drawing.SystemColors.Control
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAarden.DisplayLayout.GroupByBox.PromptAppearance = Appearance75
        Me.UltraComboAarden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboAarden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance76.BackColor = System.Drawing.SystemColors.Window
        Appearance76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboAarden.DisplayLayout.Override.ActiveCellAppearance = Appearance76
        Appearance77.BackColor = System.Drawing.SystemColors.Highlight
        Appearance77.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboAarden.DisplayLayout.Override.ActiveRowAppearance = Appearance77
        Me.UltraComboAarden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboAarden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance78.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboAarden.DisplayLayout.Override.CardAreaAppearance = Appearance78
        Appearance79.BorderColor = System.Drawing.Color.Silver
        Appearance79.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboAarden.DisplayLayout.Override.CellAppearance = Appearance79
        Me.UltraComboAarden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboAarden.DisplayLayout.Override.CellPadding = 0
        Appearance80.BackColor = System.Drawing.SystemColors.Control
        Appearance80.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance80.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance80.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAarden.DisplayLayout.Override.GroupByRowAppearance = Appearance80
        Appearance81.TextHAlignAsString = "Left"
        Me.UltraComboAarden.DisplayLayout.Override.HeaderAppearance = Appearance81
        Me.UltraComboAarden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboAarden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance82.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboAarden.DisplayLayout.Override.RowAlternateAppearance = Appearance82
        Appearance83.BackColor = System.Drawing.SystemColors.Window
        Appearance83.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboAarden.DisplayLayout.Override.RowAppearance = Appearance83
        Me.UltraComboAarden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboAarden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance84
        Me.UltraComboAarden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboAarden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboAarden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboAarden.DisplayMember = "SCF_BR_TY_INTV"
        Me.UltraComboAarden.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboAarden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboAarden.Location = New System.Drawing.Point(136, 88)
        Me.UltraComboAarden.Name = "UltraComboAarden"
        Me.UltraComboAarden.Size = New System.Drawing.Size(296, 22)
        Me.UltraComboAarden.TabIndex = 9
        Me.UltraComboAarden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAarden.ValueMember = "ID_BR_TY_INTV"
        '
        '_dataAarden
        '
        Me._dataAarden.DataSetName = "TDSAarden"
        Me._dataAarden.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAarden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraComboAfdelingen
        '
        Me.UltraComboAfdelingen.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraComboAfdelingen.DataSource = Me._dataAfdelingen.BBAFD
        Appearance85.BackColor = System.Drawing.SystemColors.Window
        Appearance85.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboAfdelingen.DisplayLayout.Appearance = Appearance85
        UltraGridColumn46.Header.Caption = "Afdeling_id"
        UltraGridColumn46.Header.VisiblePosition = 0
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.Width = 65
        UltraGridColumn47.Header.Caption = "Omschrijving"
        UltraGridColumn47.Header.VisiblePosition = 1
        UltraGridColumn47.Width = 120
        UltraGridColumn48.Header.Caption = "Afd"
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn46, UltraGridColumn47, UltraGridColumn48})
        Me.UltraComboAfdelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.UltraComboAfdelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboAfdelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance86.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance86.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance86.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.Appearance = Appearance86
        Appearance87.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance87
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance88.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance88.BackColor2 = System.Drawing.SystemColors.Control
        Appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance88.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboAfdelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance88
        Me.UltraComboAfdelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboAfdelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance89.BackColor = System.Drawing.SystemColors.Window
        Appearance89.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance89
        Appearance90.BackColor = System.Drawing.SystemColors.Highlight
        Appearance90.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboAfdelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance90
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboAfdelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance91.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.CardAreaAppearance = Appearance91
        Appearance92.BorderColor = System.Drawing.Color.Silver
        Appearance92.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellAppearance = Appearance92
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboAfdelingen.DisplayLayout.Override.CellPadding = 0
        Appearance93.BackColor = System.Drawing.SystemColors.Control
        Appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance93.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance93.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboAfdelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance93
        Appearance94.TextHAlignAsString = "Left"
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderAppearance = Appearance94
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboAfdelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance95.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance95
        Appearance96.BackColor = System.Drawing.SystemColors.Window
        Appearance96.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowAppearance = Appearance96
        Me.UltraComboAfdelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance97.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboAfdelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance97
        Me.UltraComboAfdelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboAfdelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboAfdelingen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboAfdelingen.DisplayMember = "KRT_AFD"
        Me.UltraComboAfdelingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraComboAfdelingen.Location = New System.Drawing.Point(376, 16)
        Me.UltraComboAfdelingen.Name = "UltraComboAfdelingen"
        Me.UltraComboAfdelingen.Size = New System.Drawing.Size(56, 22)
        Me.UltraComboAfdelingen.TabIndex = 1
        Me.UltraComboAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraComboAfdelingen.ValueMember = "ID_AFD"
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelInterventieType
        '
        Me.LabelInterventieType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInterventieType.Location = New System.Drawing.Point(656, 16)
        Me.LabelInterventieType.Name = "LabelInterventieType"
        Me.LabelInterventieType.Size = New System.Drawing.Size(184, 20)
        Me.LabelInterventieType.TabIndex = 4
        '
        'TextBoxOmschrijving
        '
        Me.TextBoxOmschrijving.Location = New System.Drawing.Point(136, 112)
        Me.TextBoxOmschrijving.Multiline = True
        Me.TextBoxOmschrijving.Name = "TextBoxOmschrijving"
        Me.TextBoxOmschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOmschrijving.Size = New System.Drawing.Size(720, 104)
        Me.TextBoxOmschrijving.TabIndex = 11
        '
        'LabelOmschrijving
        '
        Me.LabelOmschrijving.Location = New System.Drawing.Point(6, 112)
        Me.LabelOmschrijving.Name = "LabelOmschrijving"
        Me.LabelOmschrijving.Size = New System.Drawing.Size(120, 16)
        Me.LabelOmschrijving.TabIndex = 40
        Me.LabelOmschrijving.Text = "Korte omschrijving:"
        '
        'LabelOorzaak
        '
        Me.LabelOorzaak.Location = New System.Drawing.Point(494, 90)
        Me.LabelOorzaak.Name = "LabelOorzaak"
        Me.LabelOorzaak.Size = New System.Drawing.Size(64, 16)
        Me.LabelOorzaak.TabIndex = 39
        Me.LabelOorzaak.Text = "Oorzaak:"
        '
        'LabelAard
        '
        Me.LabelAard.Location = New System.Drawing.Point(77, 90)
        Me.LabelAard.Name = "LabelAard"
        Me.LabelAard.Size = New System.Drawing.Size(51, 16)
        Me.LabelAard.TabIndex = 36
        Me.LabelAard.Text = "Aard:"
        '
        'TextBoxWerk_vuurverg
        '
        Me.TextBoxWerk_vuurverg.Location = New System.Drawing.Point(136, 64)
        Me.TextBoxWerk_vuurverg.Name = "TextBoxWerk_vuurverg"
        Me.TextBoxWerk_vuurverg.Size = New System.Drawing.Size(296, 20)
        Me.TextBoxWerk_vuurverg.TabIndex = 8
        '
        'LabelWerkvuurvergunning
        '
        Me.LabelWerkvuurvergunning.Location = New System.Drawing.Point(26, 66)
        Me.LabelWerkvuurvergunning.Name = "LabelWerkvuurvergunning"
        Me.LabelWerkvuurvergunning.Size = New System.Drawing.Size(102, 16)
        Me.LabelWerkvuurvergunning.TabIndex = 34
        Me.LabelWerkvuurvergunning.Text = "Werk-vuurverg:"
        '
        'TextBoxTussenkomst
        '
        Me.TextBoxTussenkomst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxTussenkomst.Location = New System.Drawing.Point(560, 40)
        Me.TextBoxTussenkomst.Multiline = True
        Me.TextBoxTussenkomst.Name = "TextBoxTussenkomst"
        Me.TextBoxTussenkomst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxTussenkomst.Size = New System.Drawing.Size(296, 45)
        Me.TextBoxTussenkomst.TabIndex = 7
        '
        'LabelTussenkomst
        '
        Me.LabelTussenkomst.Location = New System.Drawing.Point(440, 44)
        Me.LabelTussenkomst.Name = "LabelTussenkomst"
        Me.LabelTussenkomst.Size = New System.Drawing.Size(120, 16)
        Me.LabelTussenkomst.TabIndex = 32
        Me.LabelTussenkomst.Text = "Plaats tussenkomst:"
        '
        'LabelTijdstip
        '
        Me.LabelTijdstip.Location = New System.Drawing.Point(307, 44)
        Me.LabelTijdstip.Name = "LabelTijdstip"
        Me.LabelTijdstip.Size = New System.Drawing.Size(64, 16)
        Me.LabelTijdstip.TabIndex = 30
        Me.LabelTijdstip.Text = "Tijdstip:"
        '
        'TextBoxOpgeroepen
        '
        Me.TextBoxOpgeroepen.Location = New System.Drawing.Point(136, 40)
        Me.TextBoxOpgeroepen.Name = "TextBoxOpgeroepen"
        Me.TextBoxOpgeroepen.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxOpgeroepen.TabIndex = 5
        '
        'LabelOpgeroepen
        '
        Me.LabelOpgeroepen.Location = New System.Drawing.Point(14, 44)
        Me.LabelOpgeroepen.Name = "LabelOpgeroepen"
        Me.LabelOpgeroepen.Size = New System.Drawing.Size(112, 16)
        Me.LabelOpgeroepen.TabIndex = 28
        Me.LabelOpgeroepen.Text = "Opgeroepen door:"
        '
        'TextBoxVolgnummer
        '
        Me.TextBoxVolgnummer.Enabled = False
        Me.TextBoxVolgnummer.Location = New System.Drawing.Point(600, 16)
        Me.TextBoxVolgnummer.Name = "TextBoxVolgnummer"
        Me.TextBoxVolgnummer.ReadOnly = True
        Me.TextBoxVolgnummer.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxVolgnummer.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(440, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Volgnr (intv-afd)/jaar: "
        '
        'LabelAfdeling
        '
        Me.LabelAfdeling.Location = New System.Drawing.Point(304, 20)
        Me.LabelAfdeling.Name = "LabelAfdeling"
        Me.LabelAfdeling.Size = New System.Drawing.Size(64, 16)
        Me.LabelAfdeling.TabIndex = 23
        Me.LabelAfdeling.Text = "Afdeling:"
        '
        'LabelDatumInterventie
        '
        Me.LabelDatumInterventie.Location = New System.Drawing.Point(68, 20)
        Me.LabelDatumInterventie.Name = "LabelDatumInterventie"
        Me.LabelDatumInterventie.Size = New System.Drawing.Size(61, 16)
        Me.LabelDatumInterventie.TabIndex = 21
        Me.LabelDatumInterventie.Text = "Datum:"
        '
        'GroupBoxKosten
        '
        Me.GroupBoxKosten.Controls.Add(Me.UltraDropDownInterventieTijden)
        Me.GroupBoxKosten.Controls.Add(Me.UltraDropDownArtikelenKost)
        Me.GroupBoxKosten.Controls.Add(Me.UltraGridKosten)
        Me.GroupBoxKosten.Location = New System.Drawing.Point(0, 224)
        Me.GroupBoxKosten.Name = "GroupBoxKosten"
        Me.GroupBoxKosten.Size = New System.Drawing.Size(496, 128)
        Me.GroupBoxKosten.TabIndex = 1
        Me.GroupBoxKosten.TabStop = False
        Me.GroupBoxKosten.Text = "Kosten"
        '
        'UltraDropDownInterventieTijden
        '
        Me.UltraDropDownInterventieTijden.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraDropDownInterventieTijden.DataSource = Me._dataWagens.BBINTART
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownInterventieTijden.DisplayLayout.Appearance = Appearance19
        Me.UltraDropDownInterventieTijden.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.Caption = "Artikel"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Width = 147
        UltraGridColumn19.Header.Caption = "Prijs"
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Width = 54
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        Me.UltraDropDownInterventieTijden.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownInterventieTijden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownInterventieTijden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieTijden.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventieTijden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.UltraDropDownInterventieTijden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventieTijden.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.UltraDropDownInterventieTijden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownInterventieTijden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.ActiveCellAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.SystemColors.Highlight
        Appearance24.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.ActiveRowAppearance = Appearance24
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.CellAppearance = Appearance26
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.CellPadding = 0
        Appearance27.BackColor = System.Drawing.SystemColors.Control
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.GroupByRowAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Left"
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance29.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.RowAlternateAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.RowAppearance = Appearance30
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance31.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownInterventieTijden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance31
        Me.UltraDropDownInterventieTijden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownInterventieTijden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownInterventieTijden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownInterventieTijden.DisplayMember = "SCF_ART_INTV"
        Me.UltraDropDownInterventieTijden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownInterventieTijden.Location = New System.Drawing.Point(16, 88)
        Me.UltraDropDownInterventieTijden.MaxDropDownItems = 15
        Me.UltraDropDownInterventieTijden.Name = "UltraDropDownInterventieTijden"
        Me.UltraDropDownInterventieTijden.Size = New System.Drawing.Size(220, 32)
        Me.UltraDropDownInterventieTijden.TabIndex = 28
        Me.UltraDropDownInterventieTijden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownInterventieTijden.ValueMember = "ID_ART_INTV"
        Me.UltraDropDownInterventieTijden.Visible = False
        '
        '_dataWagens
        '
        Me._dataWagens.DataSetName = "TDSIntvArt"
        Me._dataWagens.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataWagens.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownArtikelenKost
        '
        Me.UltraDropDownArtikelenKost.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraDropDownArtikelenKost.DataSource = Me._dataInterventieArtikelen.BBINTART
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownArtikelenKost.DisplayLayout.Appearance = Appearance32
        Me.UltraDropDownArtikelenKost.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "Artikel"
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.Width = 160
        UltraGridColumn25.Header.Caption = "Prijs"
        UltraGridColumn25.Header.VisiblePosition = 4
        UltraGridColumn25.Width = 41
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        Me.UltraDropDownArtikelenKost.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraDropDownArtikelenKost.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownArtikelenKost.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelenKost.DisplayLayout.GroupByBox.Appearance = Appearance33
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownArtikelenKost.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance34
        Me.UltraDropDownArtikelenKost.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance35.BackColor2 = System.Drawing.SystemColors.Control
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownArtikelenKost.DisplayLayout.GroupByBox.PromptAppearance = Appearance35
        Me.UltraDropDownArtikelenKost.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownArtikelenKost.DisplayLayout.MaxRowScrollRegions = 1
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.ActiveCellAppearance = Appearance36
        Appearance37.BackColor = System.Drawing.SystemColors.Highlight
        Appearance37.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.ActiveRowAppearance = Appearance37
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.CardAreaAppearance = Appearance38
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Appearance39.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.CellAppearance = Appearance39
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.CellPadding = 0
        Appearance40.BackColor = System.Drawing.SystemColors.Control
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.GroupByRowAppearance = Appearance40
        Appearance41.TextHAlignAsString = "Left"
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance42.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.RowAlternateAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.RowAppearance = Appearance43
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownArtikelenKost.DisplayLayout.Override.TemplateAddRowAppearance = Appearance44
        Me.UltraDropDownArtikelenKost.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownArtikelenKost.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownArtikelenKost.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownArtikelenKost.DisplayMember = "SCF_ART_INTV"
        Me.UltraDropDownArtikelenKost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownArtikelenKost.Location = New System.Drawing.Point(16, 48)
        Me.UltraDropDownArtikelenKost.MaxDropDownItems = 12
        Me.UltraDropDownArtikelenKost.Name = "UltraDropDownArtikelenKost"
        Me.UltraDropDownArtikelenKost.Size = New System.Drawing.Size(220, 32)
        Me.UltraDropDownArtikelenKost.TabIndex = 27
        Me.UltraDropDownArtikelenKost.Text = "UltraDropDown1"
        Me.UltraDropDownArtikelenKost.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownArtikelenKost.ValueMember = "ID_ART_INTV"
        Me.UltraDropDownArtikelenKost.Visible = False
        '
        '_dataInterventieArtikelen
        '
        Me._dataInterventieArtikelen.DataSetName = "TDSIntvArt"
        Me._dataInterventieArtikelen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInterventieArtikelen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridKosten
        '
        Me.UltraGridKosten.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraGridKosten.DataSource = Me._dataInterventie.BBMATPR
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridKosten.DisplayLayout.Appearance = Appearance45
        Me.UltraGridKosten.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Artikel"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 169
        UltraGridColumn31.Header.Caption = "Aantal"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 57
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance46
        UltraGridColumn32.Formula = "[Q_ART] * [PR_EH_ART_INTV]"
        UltraGridColumn32.Header.Caption = "Totaal (euro)"
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn32.Width = 86
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn33.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33})
        Me.UltraGridKosten.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraGridKosten.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridKosten.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance47.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance47.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance47.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridKosten.DisplayLayout.GroupByBox.Appearance = Appearance47
        Appearance48.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridKosten.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance48
        Me.UltraGridKosten.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridKosten.DisplayLayout.GroupByBox.Hidden = True
        Appearance49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance49.BackColor2 = System.Drawing.SystemColors.Control
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance49.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridKosten.DisplayLayout.GroupByBox.PromptAppearance = Appearance49
        Me.UltraGridKosten.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridKosten.DisplayLayout.MaxRowScrollRegions = 1
        Appearance50.BackColor = System.Drawing.SystemColors.Window
        Appearance50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridKosten.DisplayLayout.Override.ActiveCellAppearance = Appearance50
        Appearance51.BackColor = System.Drawing.SystemColors.Highlight
        Appearance51.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridKosten.DisplayLayout.Override.ActiveRowAppearance = Appearance51
        Me.UltraGridKosten.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.UltraGridKosten.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridKosten.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridKosten.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridKosten.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance52.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridKosten.DisplayLayout.Override.CardAreaAppearance = Appearance52
        Appearance53.BorderColor = System.Drawing.Color.Silver
        Appearance53.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridKosten.DisplayLayout.Override.CellAppearance = Appearance53
        Me.UltraGridKosten.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridKosten.DisplayLayout.Override.CellPadding = 0
        Appearance54.BackColor = System.Drawing.SystemColors.Control
        Appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance54.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance54.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridKosten.DisplayLayout.Override.GroupByRowAppearance = Appearance54
        Appearance55.TextHAlignAsString = "Left"
        Me.UltraGridKosten.DisplayLayout.Override.HeaderAppearance = Appearance55
        Me.UltraGridKosten.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridKosten.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance56.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridKosten.DisplayLayout.Override.RowAlternateAppearance = Appearance56
        Appearance57.BackColor = System.Drawing.SystemColors.Window
        Appearance57.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridKosten.DisplayLayout.Override.RowAppearance = Appearance57
        Me.UltraGridKosten.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance58.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridKosten.DisplayLayout.Override.TemplateAddRowAppearance = Appearance58
        Me.UltraGridKosten.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridKosten.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridKosten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridKosten.Location = New System.Drawing.Point(136, 14)
        Me.UltraGridKosten.Name = "UltraGridKosten"
        Me.UltraGridKosten.Size = New System.Drawing.Size(350, 106)
        Me.UltraGridKosten.TabIndex = 2
        Me.UltraGridKosten.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataInterventie
        '
        Me._dataInterventie.DataSetName = "TDSInterventie"
        Me._dataInterventie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInterventie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxOverige
        '
        Me.GroupBoxOverige.Controls.Add(Me.UserControlGeneralFunctionsBrandweer)
        Me.GroupBoxOverige.Controls.Add(Me.LabelBestemmelingenOud)
        Me.GroupBoxOverige.Location = New System.Drawing.Point(0, 428)
        Me.GroupBoxOverige.Name = "GroupBoxOverige"
        Me.GroupBoxOverige.Size = New System.Drawing.Size(528, 184)
        Me.GroupBoxOverige.TabIndex = 4
        Me.GroupBoxOverige.TabStop = False
        Me.GroupBoxOverige.Text = "Overige"
        '
        'UserControlGeneralFunctionsBrandweer
        '
        Me.UserControlGeneralFunctionsBrandweer.AutoSize = True
        Me.UserControlGeneralFunctionsBrandweer.DatumOpstelling = New Date(2006, 5, 2, 0, 0, 0, 0)
        Me.UserControlGeneralFunctionsBrandweer.GetReportContractant = False
        Me.UserControlGeneralFunctionsBrandweer.Location = New System.Drawing.Point(8, 16)
        Me.UserControlGeneralFunctionsBrandweer.Name = "UserControlGeneralFunctionsBrandweer"
        Me.UserControlGeneralFunctionsBrandweer.Opsteller = 0
        Me.UserControlGeneralFunctionsBrandweer.Size = New System.Drawing.Size(512, 120)
        Me.UserControlGeneralFunctionsBrandweer.TabIndex = 46
        Me.UserControlGeneralFunctionsBrandweer.typeBrOfBew = Be.Sidmar.RIS.BrandweerBewaking.Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer
        '
        'LabelBestemmelingenOud
        '
        Me.LabelBestemmelingenOud.Location = New System.Drawing.Point(8, 144)
        Me.LabelBestemmelingenOud.Name = "LabelBestemmelingenOud"
        Me.LabelBestemmelingenOud.Size = New System.Drawing.Size(512, 32)
        Me.LabelBestemmelingenOud.TabIndex = 50
        '
        'GroupBoxInterventie
        '
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonAnnuleer)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonOpslaan)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonOverzicht)
        Me.GroupBoxInterventie.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxInterventie.Location = New System.Drawing.Point(0, 612)
        Me.GroupBoxInterventie.Name = "GroupBoxInterventie"
        Me.GroupBoxInterventie.Size = New System.Drawing.Size(528, 48)
        Me.GroupBoxInterventie.TabIndex = 6
        Me.GroupBoxInterventie.TabStop = False
        Me.GroupBoxInterventie.Text = "Interventie"
        '
        'UltraButtonAfdrukken
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance1
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(104, 16)
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
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(200, 16)
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
        Me.UltraButtonOverzicht.Location = New System.Drawing.Point(296, 16)
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
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(432, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        '_dataBRPersoneel
        '
        Me._dataBRPersoneel.DataSetName = "TDSBRPersoneel"
        Me._dataBRPersoneel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBRPersoneel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxInterventieTijden
        '
        Me.GroupBoxInterventieTijden.Controls.Add(Me.UltraGridInterventieTijden)
        Me.GroupBoxInterventieTijden.Location = New System.Drawing.Point(504, 224)
        Me.GroupBoxInterventieTijden.Name = "GroupBoxInterventieTijden"
        Me.GroupBoxInterventieTijden.Size = New System.Drawing.Size(368, 128)
        Me.GroupBoxInterventieTijden.TabIndex = 2
        Me.GroupBoxInterventieTijden.TabStop = False
        Me.GroupBoxInterventieTijden.Text = "Interventietijden"
        '
        'UltraGridInterventieTijden
        '
        Me.UltraGridInterventieTijden.CalcManager = Me.UltraCalcManagerKosten
        Me.UltraGridInterventieTijden.DataSource = Me._dataInterventie.BBINTVDU
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridInterventieTijden.DisplayLayout.Appearance = Appearance6
        Me.UltraGridInterventieTijden.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 68
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 70
        UltraGridColumn4.EditorComponent = Me.UltraMaskedEditTime
        UltraGridColumn4.Format = ""
        UltraGridColumn4.Header.Caption = "Oproep"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn4.MaskInput = "{time}"
        UltraGridColumn4.Width = 60
        UltraGridColumn5.EditorComponent = Me.UltraMaskedEditTime
        UltraGridColumn5.Format = ""
        UltraGridColumn5.Header.Caption = "Aankomst"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.MaskInput = "{time}"
        UltraGridColumn5.Width = 64
        UltraGridColumn6.EditorComponent = Me.UltraMaskedEditTime
        UltraGridColumn6.Format = ""
        UltraGridColumn6.Header.Caption = "Inrukken"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.MaskInput = "{time}"
        UltraGridColumn6.Width = 66
        UltraGridColumn7.Header.Caption = "Type wagen"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Width = 116
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.UltraGridInterventieTijden.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridInterventieTijden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInterventieTijden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventieTijden.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInterventieTijden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.UltraGridInterventieTijden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInterventieTijden.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInterventieTijden.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.UltraGridInterventieTijden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridInterventieTijden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridInterventieTijden.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.Highlight
        Appearance11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridInterventieTijden.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.UltraGridInterventieTijden.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.UltraGridInterventieTijden.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInterventieTijden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInterventieTijden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridInterventieTijden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventieTijden.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridInterventieTijden.DisplayLayout.Override.CellAppearance = Appearance13
        Me.UltraGridInterventieTijden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridInterventieTijden.DisplayLayout.Override.CellPadding = 0
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventieTijden.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Left"
        Me.UltraGridInterventieTijden.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.UltraGridInterventieTijden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridInterventieTijden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance16.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridInterventieTijden.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridInterventieTijden.DisplayLayout.Override.RowAppearance = Appearance17
        Me.UltraGridInterventieTijden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridInterventieTijden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.UltraGridInterventieTijden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridInterventieTijden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridInterventieTijden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInterventieTijden.Location = New System.Drawing.Point(8, 16)
        Me.UltraGridInterventieTijden.Name = "UltraGridInterventieTijden"
        Me.UltraGridInterventieTijden.Size = New System.Drawing.Size(344, 104)
        Me.UltraGridInterventieTijden.TabIndex = 0
        Me.UltraGridInterventieTijden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_statusBar
        '
        Me._statusBar.Department = ""
        Me._statusBar.Location = New System.Drawing.Point(0, 680)
        Me._statusBar.Message = ""
        Me._statusBar.Name = "_statusBar"
        Me._statusBar.ShowPanels = True
        Me._statusBar.Size = New System.Drawing.Size(1016, 22)
        Me._statusBar.TabIndex = 8
        Me._statusBar.User = ""
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonTerugZenden)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.UltraDateTimeEditorBestemmelingen)
        Me.GroupBox2.Controls.Add(Me.UltraDateTimeEditorGoedkeuring)
        Me.GroupBox2.Controls.Add(Me.UltraDateTimeEditorVerzending)
        Me.GroupBox2.Controls.Add(Me.ButtonVerzendingBest)
        Me.GroupBox2.Controls.Add(Me.ButtonGoedkeuring)
        Me.GroupBox2.Controls.Add(Me.ButtonVerzendingBBW)
        Me.GroupBox2.Controls.Add(Me.TextBoxVerzendingBestemmelingen)
        Me.GroupBox2.Controls.Add(Me.TextBoxGoedkeuring)
        Me.GroupBox2.Controls.Add(Me.TextBoxVerzending)
        Me.GroupBox2.Controls.Add(Me.LabelVerzendingBest)
        Me.GroupBox2.Controls.Add(Me.LabelGoedkeuring)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 428)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 184)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Verzending"
        '
        'ButtonTerugZenden
        '
        Me.ButtonTerugZenden.Location = New System.Drawing.Point(376, 72)
        Me.ButtonTerugZenden.Name = "ButtonTerugZenden"
        Me.ButtonTerugZenden.Size = New System.Drawing.Size(80, 20)
        Me.ButtonTerugZenden.TabIndex = 17
        Me.ButtonTerugZenden.Text = "Stuur terug"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Opm mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Opm mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Opm mail:"
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
        'ButtonGoedkeuring
        '
        Me.ButtonGoedkeuring.Location = New System.Drawing.Point(280, 72)
        Me.ButtonGoedkeuring.Name = "ButtonGoedkeuring"
        Me.ButtonGoedkeuring.Size = New System.Drawing.Size(80, 20)
        Me.ButtonGoedkeuring.TabIndex = 7
        Me.ButtonGoedkeuring.Text = "Keur goed"
        '
        'LabelVerzendingBest
        '
        Me.LabelVerzendingBest.AutoSize = True
        Me.LabelVerzendingBest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerzendingBest.Location = New System.Drawing.Point(8, 128)
        Me.LabelVerzendingBest.Name = "LabelVerzendingBest"
        Me.LabelVerzendingBest.Size = New System.Drawing.Size(175, 13)
        Me.LabelVerzendingBest.TabIndex = 8
        Me.LabelVerzendingBest.Text = "Datum verzending bestemmelingen:"
        '
        'LabelGoedkeuring
        '
        Me.LabelGoedkeuring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGoedkeuring.Location = New System.Drawing.Point(8, 72)
        Me.LabelGoedkeuring.Name = "LabelGoedkeuring"
        Me.LabelGoedkeuring.Size = New System.Drawing.Size(112, 16)
        Me.LabelGoedkeuring.TabIndex = 4
        Me.LabelGoedkeuring.Text = "Datum goedkeuring:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Datum verzending postoverste:"
        '
        'UltraOptionSetGeblust
        '
        Me.UltraOptionSetGeblust.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem1.DataValue = "ValueListItem0"
        ValueListItem1.DisplayText = "Brand geblust door afdeling"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "Brand geblust door brandweer"
        Me.UltraOptionSetGeblust.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.UltraOptionSetGeblust.Location = New System.Drawing.Point(136, 12)
        Me.UltraOptionSetGeblust.Name = "UltraOptionSetGeblust"
        Me.UltraOptionSetGeblust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UltraOptionSetGeblust.Size = New System.Drawing.Size(336, 16)
        Me.UltraOptionSetGeblust.TabIndex = 0
        '
        'CheckBoxIncOntvangen
        '
        Me.CheckBoxIncOntvangen.Location = New System.Drawing.Point(736, 8)
        Me.CheckBoxIncOntvangen.Name = "CheckBoxIncOntvangen"
        Me.CheckBoxIncOntvangen.Size = New System.Drawing.Size(184, 22)
        Me.CheckBoxIncOntvangen.TabIndex = 2
        Me.CheckBoxIncOntvangen.Text = "Incidentenverslag ontvangen"
        '
        'CheckBoxBWOproep
        '
        Me.CheckBoxBWOproep.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CheckBoxBWOproep.Location = New System.Drawing.Point(544, 8)
        Me.CheckBoxBWOproep.Name = "CheckBoxBWOproep"
        Me.CheckBoxBWOproep.Size = New System.Drawing.Size(176, 22)
        Me.CheckBoxBWOproep.TabIndex = 1
        Me.CheckBoxBWOproep.Text = "Brandweerdienst opgeroepen"
        '
        'GroupBoxExtraInfo
        '
        Me.GroupBoxExtraInfo.Controls.Add(Me.CheckBoxBWOproep)
        Me.GroupBoxExtraInfo.Controls.Add(Me.CheckBoxIncOntvangen)
        Me.GroupBoxExtraInfo.Controls.Add(Me.UltraOptionSetGeblust)
        Me.GroupBoxExtraInfo.Location = New System.Drawing.Point(0, 352)
        Me.GroupBoxExtraInfo.Name = "GroupBoxExtraInfo"
        Me.GroupBoxExtraInfo.Size = New System.Drawing.Size(1000, 32)
        Me.GroupBoxExtraInfo.TabIndex = 2
        Me.GroupBoxExtraInfo.TabStop = False
        Me.GroupBoxExtraInfo.Text = "Extra Info"
        '
        'GroupBoxExtraInfoBrand
        '
        Me.GroupBoxExtraInfoBrand.Controls.Add(Me.UltraOptionSetExtraInfoBrand)
        Me.GroupBoxExtraInfoBrand.Location = New System.Drawing.Point(0, 386)
        Me.GroupBoxExtraInfoBrand.Name = "GroupBoxExtraInfoBrand"
        Me.GroupBoxExtraInfoBrand.Size = New System.Drawing.Size(1000, 36)
        Me.GroupBoxExtraInfoBrand.TabIndex = 3
        Me.GroupBoxExtraInfoBrand.TabStop = False
        Me.GroupBoxExtraInfoBrand.Text = "Extra Info Brand"
        '
        'UltraOptionSetExtraInfoBrand
        '
        Me.UltraOptionSetExtraInfoBrand.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraOptionSetExtraInfoBrand.CheckedIndex = 0
        ValueListItem3.DataValue = 0
        ValueListItem3.DisplayText = "Niet gekend"
        ValueListItem4.DataValue = 1
        ValueListItem4.DisplayText = "Menselijk / Organisatorisch"
        ValueListItem5.DataValue = 2
        ValueListItem5.DisplayText = "Activiteit"
        ValueListItem6.DataValue = 3
        ValueListItem6.DisplayText = "Defect"
        Me.UltraOptionSetExtraInfoBrand.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6})
        Me.UltraOptionSetExtraInfoBrand.ItemSpacingHorizontal = 75
        Me.UltraOptionSetExtraInfoBrand.Location = New System.Drawing.Point(136, 14)
        Me.UltraOptionSetExtraInfoBrand.Name = "UltraOptionSetExtraInfoBrand"
        Me.UltraOptionSetExtraInfoBrand.Size = New System.Drawing.Size(627, 16)
        Me.UltraOptionSetExtraInfoBrand.TabIndex = 4
        Me.UltraOptionSetExtraInfoBrand.Text = "Niet gekend"
        '
        'FormBrandweerInterventie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 702)
        Me.Controls.Add(Me.GroupBoxExtraInfoBrand)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxOverige)
        Me.Controls.Add(Me.GroupBoxExtraInfo)
        Me.Controls.Add(Me.GroupBoxInterventie)
        Me.Controls.Add(Me._statusBar)
        Me.Controls.Add(Me.UltraMaskedEditTime)
        Me.Controls.Add(Me.GroupBoxInterventieTijden)
        Me.Controls.Add(Me.GroupBoxKosten)
        Me.Controls.Add(Me.GroupBoxAlgemeen)
        Me.Name = "FormBrandweerInterventie"
        Me.ShowInTaskbar = False
        Me.Text = "Interventie Brandweer"
        Me.GroupBoxAlgemeen.ResumeLayout(False)
        Me.GroupBoxAlgemeen.PerformLayout()
        CType(Me.UltraDateTimeDatumOpmaak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboOorzaak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCalcManagerKosten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataOorzaken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboAarden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAarden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraComboAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxKosten.ResumeLayout(False)
        CType(Me.UltraDropDownInterventieTijden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataWagens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownArtikelenKost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInterventieArtikelen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridKosten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInterventie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOverige.ResumeLayout(False)
        Me.GroupBoxOverige.PerformLayout()
        Me.GroupBoxInterventie.ResumeLayout(False)
        CType(Me._dataBRPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInterventieTijden.ResumeLayout(False)
        CType(Me.UltraGridInterventieTijden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UltraDateTimeEditorBestemmelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorGoedkeuring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditorVerzending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetGeblust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxExtraInfo.ResumeLayout(False)
        Me.GroupBoxExtraInfoBrand.ResumeLayout(False)
        CType(Me.UltraOptionSetExtraInfoBrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Load"

    Private Sub FormBrandweerInterventie_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If FormManager.Current.BbwMilieuDienst = True Then
                GroupBoxAlgemeen.Enabled = False
                GroupBoxKosten.Enabled = False
                GroupBoxInterventieTijden.Enabled = False
                GroupBoxExtraInfo.Enabled = False
                GroupBox2.Enabled = False
                UltraButtonOpslaan.Enabled = False
                UltraButtonOverzicht.Enabled = False
                UserControlGeneralFunctionsBrandweer.lockControlsMilieuDienst()
            End If

            If FormManager.Current.BbwVerantwoordelijke = True Then
                UltraButtonOverzicht.Enabled = False
            End If

            setLabelsVerplicht()
            LabelInterventieType.Text = _interventieDesc
            UserControlGeneralFunctionsBrandweer.DatumOpstelling = Now
            bindDdlAfdelingen()
            bindDdlAarden()
            bindDdlOorzaken()
            bindInterventieArtikelen()
            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            UltraDateTimeEditorBestemmelingen.Value = Nothing
            '-1 = details intv bekijken
            If Not _idInterventie = -1 Then
                BindInterventie()
            Else
                UltraOptionSetExtraInfoBrand.Enabled = _interventieDesc.Equals("brand", StringComparison.InvariantCultureIgnoreCase)
            End If

            'usercontrolBrandweer
            UserControlGeneralFunctionsBrandweer.setBestemmelingenData(_dataInterventie.BBBST)
            UserControlGeneralFunctionsBrandweer.setBijlageData(_dataInterventie.BBBYLG)

            If (_dataInterventie.BBINTVBR.Rows.Count > 0) Then
                If Not (_dataInterventie.BBINTVBR(0).VeraReference.Equals(String.Empty)) Then
                    UserControlGeneralFunctionsBrandweer.SetVeraData(_dataInterventie.BBINTVBR(0).VeraReference,
                                                                     _dataInterventie.BBINTVBR(0).VeraLink)
                End If

                If Not (_dataInterventie.BBINTVBR(0).IsVerslagContractantYNNull) Then
                    UserControlGeneralFunctionsBrandweer.GetReportContractant = _dataInterventie.BBINTVBR(0).VerslagContractantYN
                End If
            End If

            checkControls()

            'opbouw statusbar
            Dim ctrl As Control
            If IsMdiChild Then
                For Each ctrl In MdiParent.Controls
                    If TypeOf (ctrl) Is ADF.Windows.Forms.UserControls.StatusBar AndAlso Not ctrl Is _statusBar Then
                        _statusBar.Remove()
                        _statusBar = CType(ctrl, ADF.Windows.Forms.UserControls.StatusBar)
                        Exit For
                    End If
                Next
            End If
            setStatus("")

            UserControlGeneralFunctionsBrandweer.typeBrOfBew = Component.UserControlGeneralFunctions.brandweerOfBewaking.brandweer

            MdiParent.Activate()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region
#Region "Bind"
    Private Sub bindInterventieArtikelen()
        Try
            Dim ds As Proxy.BBWService.Mgt.TDSIntvArt

            _controller = New ControllerGetData
            ds = _controller.GetInterventieArtikelen

            _dataInterventieArtikelen.Merge(ds)
            _dataWagens.Merge(ds.BBINTART.Select("TSP_DU_INTV = " & 1))

            UltraGridKosten.DisplayLayout.Bands(0).Columns("SCF_ART_INTV").ValueList = UltraDropDownArtikelenKost
            UltraGridInterventieTijden.DisplayLayout.Bands(0).Columns("SCF_ART_INTV").ValueList = UltraDropDownInterventieTijden

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventies - bindInterventieArtikelen()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub BindInterventie()
        'Doel: interventiegegevens tonen op scherm
        'Auteur: Rajiv - april 2006
        Try
            _controller = New ControllerGetData
            _dataInterventie.Clear()
            _dataInterventie.Merge(_controller.GetInterventie(_idInterventie))

            Dim dr As TDSInterventie.BBINTVBRRow
            dr = _dataInterventie.BBINTVBR.FindByID_INTV_BRDW(_idInterventie)

            TextBoxVolgnummer.Text = CType(dr.VLG_TY_INTV_JR, String)
            TextBoxJaar.Text = CType(dr.VLG_TY_INTV_AFD, String)
            TextBoxOpgeroepen.Text = dr.IND_OPR_DR
            TextBoxTussenkomst.Text = dr.PLA_INTV
            TextBoxOmschrijving.Text = dr.SCF_LNG_INTV
            TextBoxWerk_vuurverg.Text = dr.ID_OK_VU_TK
            UltraDateTimeDatumOpmaak.Value = dr.TMS_INTV
            UltraComboAfdelingen.Value = dr.ID_AFD
            UltraComboAfdelingen.ReadOnly = True
            UltraComboAarden.Value = dr.ID_BR_TY_INTV
            UltraComboOorzaak.Value = dr.ID_BR_RD_INTV
            If dr.IsDT_OPS_RAP_INTVNull Then
                UserControlGeneralFunctionsBrandweer.clearDate()
            Else
                UserControlGeneralFunctionsBrandweer.DatumOpstelling = dr.DT_OPS_RAP_INTV
            End If

            If Not dr.IsBST_OUD_PGNull Then
                LabelBestemmelingenOud.Text = "Bestemmelingen: " & dr.BST_OUD_PG
            End If

            CheckBoxBWOproep.Checked = dr.INDI_BRDW_SID_OPR
            CheckBoxIncOntvangen.Checked = dr.INDI_RAP_INC_OTV
            UltraMaskedEditTijdstip.Text = dr.TYD_OPR


            'afdeling
            TextBoxVolgnummer.Text = CType(dr.VLG_TY_INTV_AFD, String)
            'jaar
            TextBoxJaar.Text = CType(dr.VLG_TY_INTV_JR, String)

            'Gegevens verzending
            If Not dr.IsDT_VZ_RAP_NWNull Then
                UltraDateTimeEditorVerzending.Value = dr.DT_VZ_RAP_NW
                'indien de interventie reeds doorgemaild is, en de gebruiker is niet de postoverste
                'of de bbwverantwoordelijke, dan mag hij deze niet meer wijzigen
                If FormManager.Current.PostOverste = False And FormManager.Current.BbwVerantwoordelijke = False Then
                    setInterventieUneditable()
                End If
            Else
                UltraDateTimeEditorVerzending.Value = Nothing
            End If

            If Not dr.IsID_OPSNull Then
                UserControlGeneralFunctionsBrandweer.Opsteller = dr.ID_OPS
            Else
                UserControlGeneralFunctionsBrandweer.Opsteller = Nothing
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

            'optionset vullen
            If dr.INDI_BRD_BLUS_AFD Then
                UltraOptionSetGeblust.CheckedIndex = 0
            ElseIf dr.INDI_BRD_BLUS_SID Then
                UltraOptionSetGeblust.CheckedIndex = 1
            Else
                UltraOptionSetGeblust.CheckedIndex = -1
            End If

            ' Extra Info brand invullen
            If _interventieDesc.Equals("brand", StringComparison.InvariantCultureIgnoreCase) Then
                UltraOptionSetExtraInfoBrand.Enabled = True
                UltraOptionSetExtraInfoBrand.CheckedIndex = dr.FireCauseExtraInfoId
            Else
                UltraOptionSetExtraInfoBrand.CheckedIndex = 0
                UltraOptionSetExtraInfoBrand.Enabled = False
            End If

            'Knoppen 'Verzenden naar bestemmelingen' en 'Naar postoverste'
            If FormManager.Current.BbwVerantwoordelijke Then
                ButtonVerzendingBest.Visible = True
                TextBoxVerzendingBestemmelingen.ReadOnly = False
            Else
                ButtonVerzendingBest.Visible = False
                TextBoxVerzendingBestemmelingen.ReadOnly = True
            End If

            If FormManager.Current.BbwVerantwoordelijke Or FormManager.Current.PostOverste Then
                If Not UltraDateTimeEditorVerzending.Text = "" Then
                    ButtonVerzendingBBW.Visible = False
                    TextBoxVerzending.ReadOnly = True
                End If
            End If

            UserControlGeneralFunctionsBrandweer.setBijlageData(_dataInterventie.BBBYLG)
            UserControlGeneralFunctionsBrandweer.setBestemmelingenData(_dataInterventie.BBBST)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventies - bindInterventie()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindDdlAfdelingen()
        Try
            _controller = New ControllerGetData
            _dataAfdelingen.Merge(_controller.GetAfdelingen)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindDdlAarden()
        Try
            _controller = New ControllerGetData
            _dataAarden.Merge(_controller.GetAarden(_interventieType))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bindDdlOorzaken()
        Try
            _controller = New ControllerGetData
            _dataOorzaken.Merge(_controller.GetOorzaken(_interventieType))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerOverzichtInterventies - Button1_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "Events"

    Private Sub ButtonOverzicht_Click(ByVal sender As Object, ByVal e As EventArgs)
        FormManager.Current.OpenFormBrandweerOverzichtInterventies(False, True, True)
    End Sub

    Private Sub UltraDropDownArtikelenKost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraDropDownArtikelenKost.Click
        Try
            'Remark : code from Infragistics!

            'Cast the sender into an UltraGrid
            Dim dropDown As Infragistics.Win.UltraWinGrid.UltraDropDown = DirectCast(sender, Infragistics.Win.UltraWinGrid.UltraDropDown)

            'Get the last element that the mouse entered
            Dim lastElementEntered As Infragistics.Win.UIElement = dropDown.DisplayLayout.UIElement.LastElementEntered

            'See if there's a RowUIElement in the chain.
            Dim rowElement As Infragistics.Win.UltraWinGrid.RowUIElement
            If TypeOf lastElementEntered Is Infragistics.Win.UltraWinGrid.RowUIElement Then
                rowElement = DirectCast(lastElementEntered, Infragistics.Win.UltraWinGrid.RowUIElement)
            Else
                rowElement = DirectCast(lastElementEntered.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.RowUIElement)), Infragistics.Win.UltraWinGrid.RowUIElement)
            End If
            If rowElement Is Nothing Then Exit Sub

            'Try to get a row from the element
            Dim RowClicked As Infragistics.Win.UltraWinGrid.UltraGridRow = DirectCast(rowElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow)), Infragistics.Win.UltraWinGrid.UltraGridRow)
            'If no row was returned, then the mouse is not over a row. 
            If (RowClicked Is Nothing) Then Exit Sub

            'Get the current mouse pointer location and convert it
            'to grid coords. 
            Dim MousePosition As Point = dropDown.PointToClient(Control.MousePosition)

            'Get the lowest UIElement that is at the mouse coordinates
            Dim uielement As Infragistics.Win.UIElement
            uielement = lastElementEntered.ElementFromPoint(MousePosition)

            ' prevent doubleclick of clicked on the expansion indicator or in the space around
            If TypeOf (uielement) Is Infragistics.Win.UltraWinGrid.PreRowAreaUIElement Or TypeOf (uielement) Is Infragistics.Win.ExpansionIndicatorUIElement Then Exit Sub

            'add here your code
            UltraGridKosten.ActiveRow.Cells("PR_EH_ART_INTV").Value = UltraDropDownArtikelenKost.SelectedRow.Cells("PR_EH_ART_INTV").Text
            UltraGridKosten.ActiveRow.Cells("ID_ART_INTV").Value = UltraDropDownArtikelenKost.SelectedRow.Cells("ID_ART_INTV").Text
            If UltraGridKosten.ActiveRow.Cells("Q_ART").Value Is DBNull.Value Then
                UltraGridKosten.ActiveRow.Cells("Q_ART").Value = 1
            End If

        Catch ex As Exception
            'handle exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                "Form: FormBrandweerInterventie - UltraDropDownArtikelenKost_Click" & vbCrLf &
                "Message: " & ex.Message & vbCrLf &
                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraDropDownInterventieTijden_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraDropDownInterventieTijden.Click
        'Doel: als de gebruiker een interventietijd wil invullen => automatisch het artikel invullen in de Kosten-tabel
        '      => dit was vroeger ook zo in VB6
        'Auteur: Nancy Coppens - 05/12/2006

        Try
            UltraGridInterventieTijden.ActiveRow.Cells("ID_ART_INTV").Value = UltraDropDownInterventieTijden.SelectedRow.Cells("ID_ART_INTV").Text
            _dataInterventie.BBMATPR.AddBBMATPRRow(Nothing,
                                            CInt(UltraDropDownInterventieTijden.SelectedRow.Cells("ID_ART_INTV").Text),
                                            UltraDropDownInterventieTijden.SelectedRow.Cells("SCF_ART_INTV").Text,
                                            1,
                                            CDbl(UltraDropDownInterventieTijden.SelectedRow.Cells("PR_EH_ART_INTV").Text),
                                            CDbl(UltraDropDownInterventieTijden.SelectedRow.Cells("PR_EH_ART_INTV").Text))

        Catch ex As Exception
            'handle exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                "Form: FormBrandweerInterventie - UltraDropDownInterventieTijden_Click" & vbCrLf &
                "Message: " & ex.Message & vbCrLf &
                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonOpslaan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonOpslaan.Click
        'Doel:   
        'Auteur: Rajiv Blancke - mei 2006

        Cursor = Cursors.WaitCursor
        Try
            If controleVeldenOK() Then
                opslaanInterventie()
            Else
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub UltraButtonOverzicht_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonOverzicht.Click
        Try
            setStatus("")
            FormManager.Current.OpenFormBrandweerOverzichtInterventies(False, True, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonSluiten.Click
        Try
            setStatus("")
            Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAnnuleer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonAnnuleer.Click
        'Doel: als nieuwe interventie => terug alles leeg zetten
        '      als je bestaande interventie aan het wijzigen was: terug alles zetten zoals het in de database staat
        'Auteur: naco - 21/04/2006

        Try
            If _idInterventie = -1 Then
                'wachten op antwoord van Ann
            Else
                _dataInterventie.BBMATPR.Clear()
                _dataInterventie.BBINTVDU.Clear()

                setStatus("")
                Call BindInterventie() 'terug ophalen en tonen (zo zit je met de juiste data uit de database)
                setStatus("De wijzigingen werden ongedaan gemaakt")
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - UltraButtonAnnuleer_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonAfdrukken.Click

        Try
            If controleVeldenOK() Then
                opslaanInterventie()
                showReport()
            Else
                MessageBox.Show("Niet alle velden zijn goed ingevuld.", "Controle velden", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - UltraButtonAfdrukken_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormBrandweerInterventie_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
        Try
            setStatus("")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region

#Region "Saving"
    Private Sub opslaanInterventie()
        'Doel:   nieuwe interventie toevoegen of bestaande wijzigen
        'Auteur: naco - Koen - Rajiv - 06/04/2006

        Dim proxy As New Proxy.BBWServiceManagementServicesProxy


        Dim drInterventie As Proxy.BBWService.Mgt.TDSInterventie.BBINTVBRRow
        Dim drKost As Proxy.BBWService.Mgt.TDSInterventie.BBMATPRRow
        Dim drTijden As Proxy.BBWService.Mgt.TDSInterventie.BBINTVDURow
        Dim drBylagen As Proxy.BBWService.Mgt.TDSInterventie.BBBYLGRow
        Dim drBestemmelingen As Proxy.BBWService.Mgt.TDSInterventie.BBBSTRow
        Dim idInterventieMax As Integer
        Dim volgnummerJaar As Integer
        Dim volgnummerAfd As Integer

        Dim dsBest As New DataSet
        Dim dsByl As New DataSet

        Dim lijnnrError As String = "Start opslaan interventie"

        Dim arrayOfDeletedChronicleID As New ArrayList

        Try

            _errorString = ""
            Cursor = Cursors.WaitCursor

            _dsInterventie.BBBST.DataSet.Clear()
            _dsInterventie.BBBYLG.DataSet.Clear()

            dsBest.Merge(UserControlGeneralFunctionsBrandweer.getDataBestemmelingen)
            dsByl.Merge(UserControlGeneralFunctionsBrandweer.getDataBijlagen)
            'Ann vragen
            '1. eerst interventies uit tabel lezen => aanpassen: deze van Interventieform nemen??? vragen aan Ann
            '2. Transaction
            '3. user hier ophalen die is ingelogd

            _controller = New ControllerGetData

            If _idInterventie = -1 Then  'nieuwe interventie
                lijnnrError = "Opslaan nieuwe interventie"

                _dsInterventie.Merge(_controller.GetInterventies)

                drInterventie = _dsInterventie.BBINTVBR.NewBBINTVBRRow
                '-------------------------
                _controller.GetMaxValuesInterventie(_interventieType, CType(UltraComboAfdelingen.Value, Integer), Year(CDate(UltraDateTimeDatumOpmaak.Value)),
                                                                idInterventieMax, volgnummerJaar, volgnummerAfd)
                '1. Interventie-record
                '---------------------
                lijnnrError = "Nieuwe interventie: 1. interventie-record"

                With drInterventie
                    '.ID_INTV_BRDW = 0
                    .ID_INTV_BRDW = idInterventieMax
                    .VLG_TY_INTV_JR = volgnummerJaar
                    .VLG_TY_INTV_AFD = volgnummerAfd
                    .ID_TY_INTV = _interventieType
                    .ID_BR_TY_INTV = CType(UltraComboAarden.Value, Integer)
                    .ID_BR_RD_INTV = CType(UltraComboOorzaak.Value, Integer)
                    .ID_AFD = CType(UltraComboAfdelingen.Value, Integer)
                    .IND_OPR_DR = TextBoxOpgeroepen.Text
                    .TMS_INTV = CType(UltraDateTimeDatumOpmaak.Text & " " & UltraMaskedEditTijdstip.Text, DateTime)
                    .PLA_INTV = TextBoxTussenkomst.Text
                    .ID_OK_VU_TK = TextBoxWerk_vuurverg.Text
                    .ID_OPS = UserControlGeneralFunctionsBrandweer.Opsteller
                    .SCF_LNG_INTV = TextBoxOmschrijving.Text
                    .INDI_BRDW_SID_OPR = CheckBoxBWOproep.Checked
                    .INDI_RAP_INC_OTV = CheckBoxIncOntvangen.Checked
                    .DT_OPS_RAP_INTV = Now

                    .VeraLink = UserControlGeneralFunctionsBrandweer.GetVeraLink
                    .VeraReference = UserControlGeneralFunctionsBrandweer.GetVeraReference
                    .VerslagContractantYN = UserControlGeneralFunctionsBrandweer.GetReportContractant


                    If UltraOptionSetGeblust.CheckedIndex = 0 Then
                        .INDI_BRD_BLUS_AFD = True
                        .INDI_BRD_BLUS_SID = False
                    ElseIf UltraOptionSetGeblust.CheckedIndex = 1 Then
                        .INDI_BRD_BLUS_AFD = False
                        .INDI_BRD_BLUS_SID = True
                    Else
                        .INDI_BRD_BLUS_AFD = False
                        .INDI_BRD_BLUS_SID = False
                    End If

                    .FireCauseExtraInfoId = UltraOptionSetExtraInfoBrand.CheckedIndex

                    'Verzending goedgekeurd verslag
                    If Not UltraDateTimeEditorGoedkeuring.Value Is Nothing Then
                        .DT_OK = CType(UltraDateTimeEditorGoedkeuring.Value, DateTime)
                    End If
                    If Not TextBoxGoedkeuring.Text = "" Then
                        .OPM_CHEF_PO = TextBoxGoedkeuring.Text
                    End If

                End With
                _dsInterventie.BBINTVBR.AddBBINTVBRRow(drInterventie)

                '2. Kosten => grid overlopen en New rows toevoegen
                '-------------------------------------------------
                lijnnrError = "Nieuwe interventie: 2. kosten"
                Dim drGrid As TDSInterventie.BBMATPRRow
                For Each drGrid In _dataInterventie.BBMATPR
                    drKost = _dsInterventie.BBMATPR.NewBBMATPRRow
                    drKost.ID_INTV_BRDW = idInterventieMax
                    drKost.ID_ART_INTV = drGrid.ID_ART_INTV
                    drKost.Q_ART = drGrid.Q_ART
                    drKost.PR_TOT_ART = drGrid.PR_TOT_ART
                    _dsInterventie.BBMATPR.AddBBMATPRRow(drKost)
                Next

                '3. Interventietijden => grid overlopen en New rows toevoegen
                '------------------------------------------------------------
                lijnnrError = "Nieuwe interventie: 3. interventietijden"
                Dim drGridDU As TDSInterventie.BBINTVDURow
                For Each drGridDU In _dataInterventie.BBINTVDU
                    drTijden = _dsInterventie.BBINTVDU.NewBBINTVDURow
                    drTijden.ID_INTV_BRDW = idInterventieMax
                    drTijden.ID_ART_INTV = drGridDU.ID_ART_INTV
                    drTijden.TYD_OPR = drGridDU.TYD_OPR
                    drTijden.TYD_KO = drGridDU.TYD_KO
                    drTijden.TYD_END = drGridDU.TYD_END
                    _dsInterventie.BBINTVDU.AddBBINTVDURow(drTijden)
                Next

                '4. Bijlagen => grid overlopen en New rows toevoegen
                '------------------------------------------------------------
                lijnnrError = "Nieuwe interventie: 4. bijlagen"
                'Dim drGridBYL As TDSInterventie.BBBYLGRow 'Dien - aug2008 - migratie 2008
                Dim drByl As DataRow
                Dim chronicleID As String

                For Each drByl In dsByl.Tables(0).Rows
                    drBylagen = _dsInterventie.BBBYLG.NewBBBYLGRow
                    drBylagen.ID_BYLG = CInt(drByl.Item("ID_BYLG"))
                    drBylagen.ID_INTV_BRDW = idInterventieMax
                    drBylagen.PLA_BYLG = CType(drByl.Item("PLA_BYLG"), String)
                    If Not drByl.Item("SCF_BYLG") Is DBNull.Value Then
                        drBylagen.SCF_BYLG = CType(drByl.Item("SCF_BYLG"), String)
                    Else
                        drBylagen.SCF_BYLG = ""
                    End If
                    'Wanneer het chronicleID nog niet gekend is, betekent dit dat het document nog niet geïmporteerd is in documentum.
                    If drByl.Item("ID_DOC") Is DBNull.Value Then
                        chronicleID = UploadInterventieBijlageToDocumentum(drByl, volgnummerJaar.ToString & "/" & volgnummerAfd.ToString)
                        'Opslaan van het chronicleID van documentum in de tabel BBBYLG
                        If (chronicleID <> "") Then
                            drBylagen.ID_DOC = chronicleID
                        End If
                    End If
                    _dsInterventie.BBBYLG.AddBBBYLGRow(drBylagen)
                Next

                '5. Bestemmelingen => grid overlopen en New rows toevoegen
                '------------------------------------------------------------
                lijnnrError = "Nieuwe interventie: 5. bestemmelingen"
                'Dim drGridBST As TDSInterventie.BBBSTRow 'Dien - aug2008 - migratie 2008
                Dim drBest As DataRow
                For Each drBest In dsBest.Tables(0).Rows
                    drBestemmelingen = _dsInterventie.BBBST.NewBBBSTRow
                    drBestemmelingen.ID_BST = CInt(drBest.Item("ID_BST")) 'drGridBST.ID_BST
                    drBestemmelingen.ID_IND = CInt(drBest.Item("ID_IND"))
                    drBestemmelingen.ID_INTV_BRDW = idInterventieMax
                    drBestemmelingen.NM_IND = CType(drBest.Item("NM_IND"), String)
                    If drBest.Item("VNM_IND") Is DBNull.Value Then
                        drBestemmelingen.VNM_IND = ""
                    Else
                        drBestemmelingen.VNM_IND = CType(drBest.Item("VNM_IND"), String)
                    End If

                    If drBest.Item("AD_EMAL_IND") Is DBNull.Value Then
                        drBestemmelingen.AD_EMAL_IND = ""
                    Else
                        drBestemmelingen.AD_EMAL_IND = CType(drBest.Item("AD_EMAL_IND"), String)
                    End If

                    _dsInterventie.BBBST.AddBBBSTRow(drBestemmelingen)
                Next

            Else 'bestaande interventie wijzigen
                _dsInterventie.Merge(_controller.GetInterventie(_idInterventie))
                drInterventie = _dsInterventie.BBINTVBR.FindByID_INTV_BRDW(_idInterventie)

                '1. Interventie-record
                '---------------------
                lijnnrError = "Bestaande interventie: 1. interventie-record"
                With drInterventie
                    .ID_BR_TY_INTV = CType(UltraComboAarden.Value, Integer)
                    .ID_BR_RD_INTV = CType(UltraComboOorzaak.Value, Integer)
                    .VLG_TY_INTV_JR = CType(TextBoxJaar.Text, Integer)
                    .VLG_TY_INTV_AFD = CType(TextBoxVolgnummer.Text, Integer)
                    .IND_OPR_DR = TextBoxOpgeroepen.Text
                    .TMS_INTV = CType(UltraDateTimeDatumOpmaak.Text & " " & UltraMaskedEditTijdstip.Text, DateTime)
                    .PLA_INTV = TextBoxTussenkomst.Text
                    .ID_AFD = CType(UltraComboAfdelingen.Value, Integer)
                    .ID_OK_VU_TK = TextBoxWerk_vuurverg.Text
                    .ID_OPS = UserControlGeneralFunctionsBrandweer.Opsteller
                    .SCF_LNG_INTV = TextBoxOmschrijving.Text
                    .INDI_BRDW_SID_OPR = CheckBoxBWOproep.Checked
                    .INDI_RAP_INC_OTV = CheckBoxIncOntvangen.Checked
                    If Not UserControlGeneralFunctionsBrandweer.DatumOpstelling = Nothing Then
                        .DT_OPS_RAP_INTV = UserControlGeneralFunctionsBrandweer.DatumOpstelling
                    End If

                    'Update Vera-Data
                    .VeraLink = UserControlGeneralFunctionsBrandweer.GetVeraLink
                    .VeraReference = UserControlGeneralFunctionsBrandweer.GetVeraReference
                    .VerslagContractantYN = UserControlGeneralFunctionsBrandweer.GetReportContractant

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

                    If UltraOptionSetGeblust.CheckedIndex = 0 Then
                        .INDI_BRD_BLUS_AFD = True
                        .INDI_BRD_BLUS_SID = False
                    ElseIf UltraOptionSetGeblust.CheckedIndex = 1 Then
                        .INDI_BRD_BLUS_AFD = False
                        .INDI_BRD_BLUS_SID = True
                    Else
                        .INDI_BRD_BLUS_AFD = False
                        .INDI_BRD_BLUS_SID = False
                    End If

                    .FireCauseExtraInfoId = UltraOptionSetExtraInfoBrand.CheckedIndex

                End With

                '2. Kosten => grid overlopen en New rows 
                '---------------------------------------
                'Eerst de gedelete rijen (anders fout) => kijken welke rijen we niet terugvinden in de grid: deze deleten
                lijnnrError = "Bestaande interventie: 2. Kosten"
                For Each drKost In _dsInterventie.BBMATPR.Rows
                    If _dataInterventie.BBMATPR.Select("ID_PR_MAT = " & drKost.ID_PR_MAT).Length > 0 Then
                        'rij is teruggevonden
                    Else
                        If _dsInterventie.BBMATPR.Select("ID_PR_MAT = " & drKost.ID_PR_MAT).Length > 0 Then
                            'eerst kijken of het record al effectief bestond in de database
                            'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                            drKost.Delete() 'rij was verwijderd uit grid
                        End If
                    End If
                Next

                Dim drGrid As TDSInterventie.BBMATPRRow
                For Each drGrid In _dataInterventie.BBMATPR
                    If drGrid.RowState = DataRowState.Added Then
                        drKost = _dsInterventie.BBMATPR.NewBBMATPRRow
                        drKost.ID_INTV_BRDW = _idInterventie
                        drKost.ID_ART_INTV = drGrid.ID_ART_INTV
                        drKost.Q_ART = drGrid.Q_ART
                        drKost.PR_TOT_ART = drGrid.PR_TOT_ART
                        _dsInterventie.BBMATPR.AddBBMATPRRow(drKost)
                    ElseIf drGrid.RowState = DataRowState.Modified Then
                        Dim arrKost() As DataRow
                        arrKost = _dsInterventie.BBMATPR.Select("ID_PR_MAT = " & drGrid.ID_PR_MAT)
                        If arrKost.Length > 0 Then
                            drKost = DirectCast(arrKost(0), Proxy.BBWService.Mgt.TDSInterventie.BBMATPRRow)
                            'drKost.ID_INTV_BRDW = idInterventieMax
                            drKost.ID_ART_INTV = drGrid.ID_ART_INTV
                            drKost.Q_ART = drGrid.Q_ART
                            drKost.PR_TOT_ART = drGrid.PR_TOT_ART
                        End If
                    End If
                Next

                '3. Interventietijden => grid overlopen en New rows()
                '----------------------------------------------------
                'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                lijnnrError = "Bestaande interventie: 3. Interventietijden"
                For Each drTijden In _dsInterventie.BBINTVDU.Rows
                    If _dataInterventie.BBINTVDU.Select("ID_DU_INTV = " & drTijden.ID_DU_INTV).Length > 0 Then
                        'rij is teruggevonden
                        'ElseIf drTijden.RowState = DataRowState.Deleted Then
                        '    'do nothing
                    Else
                        If _dsInterventie.BBINTVDU.Select("ID_DU_INTV = " & drTijden.ID_DU_INTV).Length > 0 Then
                            'eerst kijken of het record al effectief bestond in de database
                            'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                            drTijden.Delete() 'rij was verwijderd uit grid
                        End If
                    End If
                Next

                Dim drGridDU As TDSInterventie.BBINTVDURow
                For Each drGridDU In _dataInterventie.BBINTVDU
                    If drGridDU.RowState = DataRowState.Added Then
                        drTijden = _dsInterventie.BBINTVDU.NewBBINTVDURow
                        drTijden.ID_INTV_BRDW = _idInterventie
                        drTijden.ID_ART_INTV = drGridDU.ID_ART_INTV
                        drTijden.TYD_OPR = drGridDU.TYD_OPR
                        drTijden.TYD_KO = drGridDU.TYD_KO
                        drTijden.TYD_END = drGridDU.TYD_END
                        _dsInterventie.BBINTVDU.AddBBINTVDURow(drTijden)
                    ElseIf drGridDU.RowState = DataRowState.Modified Then
                        Dim arrKost() As DataRow
                        arrKost = _dsInterventie.BBINTVDU.Select("ID_DU_INTV = " & drGridDU.ID_DU_INTV)
                        If arrKost.Length > 0 Then
                            drTijden = DirectCast(arrKost(0), Proxy.BBWService.Mgt.TDSInterventie.BBINTVDURow)
                            'drKost.ID_INTV_BRDW = idInterventieMax
                            drTijden.ID_ART_INTV = drGridDU.ID_ART_INTV
                            drTijden.TYD_OPR = drGridDU.TYD_OPR
                            drTijden.TYD_KO = drGridDU.TYD_KO
                            drTijden.TYD_END = drGridDU.TYD_END
                        End If
                    End If
                Next

                '4. Bijlagen => grid overlopen en New rows()
                '----------------------------------------------------
                'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                Dim drBylg As Proxy.BBWService.Mgt.TDSInterventie.BBBYLGRow
                '------fout zoeken, kan geen nieuwe geadd worden
                lijnnrError = "Bestaande interventie: 4. Bijlagen"
                For Each drBylg In _dsInterventie.BBBYLG.Rows
                    If dsByl.Tables(0).Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
                        'rij is teruggevonden
                        'ElseIf drTijden.RowState = DataRowState.Deleted Then
                        '    'do nothing
                    Else
                        If _dsInterventie.BBBYLG.Select("ID_BYLG = " & CInt(drBylg.ID_BYLG)).Length > 0 Then
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
                        If drGridBYLG.Item("ID_DOC") Is DBNull.Value Then
                            chronicleID = UploadInterventieBijlageToDocumentum(drGridBYLG, TextBoxJaar.Text & "/" & TextBoxVolgnummer.Text)
                        Else
                            chronicleID = CType(drGridBYLG.Item("ID_DOC"), String)
                        End If
                    End If

                    If drGridBYLG.RowState = DataRowState.Added Then
                        drBylagen = _dsInterventie.BBBYLG.NewBBBYLGRow
                        'drBylagen.ID_BYLG = CInt(drGridBYLG.Item("ID_BYLG"))
                        drBylagen.ID_INTV_BRDW = _idInterventie
                        drBylagen.PLA_BYLG = CType(drGridBYLG.Item("PLA_BYLG"), String)
                        If Not drGridBYLG.Item("SCF_BYLG") Is DBNull.Value Then
                            drBylagen.SCF_BYLG = CType(drGridBYLG.Item("SCF_BYLG"), String)
                        Else
                            drBylagen.SCF_BYLG = ""
                        End If
                        If chronicleID <> "" Then
                            drBylagen.ID_DOC = chronicleID
                        End If
                        _dsInterventie.BBBYLG.AddBBBYLGRow(drBylagen)

                    ElseIf drGridBYLG.RowState = DataRowState.Modified Then
                        Dim arrBylg() As DataRow
                        arrBylg = _dsInterventie.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                        If arrBylg.Length > 0 Then
                            drBylagen = DirectCast(arrBylg(0), Proxy.BBWService.Mgt.TDSInterventie.BBBYLGRow)
                            'drBylagen.ID_BYLG = CInt(drGridBYLG.Item("ID_BYLG"))
                            drBylagen.ID_INTV_BRDW = _idInterventie
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
                            arrBylg = _dsInterventie.BBBYLG.Select("ID_BYLG = " & CStr(drGridBYLG.Item("ID_BYLG")))
                            If arrBylg.Length > 0 And CInt(drGridBYLG.Item("ID_BYLG")) > 0 Then
                                drBylagen = DirectCast(arrBylg(0), Proxy.BBWService.Mgt.TDSInterventie.BBBYLGRow)
                                If chronicleID <> "" Then
                                    drBylagen.Item("ID_DOC") = chronicleID
                                End If
                            End If
                        End If
                    End If
                Next

                '5. Bestemmelingen => grid overlopen en New rows()
                '----------------------------------------------------
                'Eerst de gedelete rijen (anders fout)=> kijken welke rijen we niet terugvinden in de grid: deze deleten
                Dim drBest As Proxy.BBWService.Mgt.TDSInterventie.BBBSTRow
                lijnnrError = "Bestaande interventie: 5. Bestemmelingen"
                For Each drBest In _dsInterventie.BBBST.Rows ' dsBest.Tables(0).Rows
                    If dsBest.Tables(0).Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                        'rij is teruggevonden
                        'ElseIf drTijden.RowState = DataRowState.Deleted Then
                        '    'do nothing
                    Else
                        If _dsInterventie.BBBST.Select("ID_BST = " & CInt(drBest.ID_BST)).Length > 0 Then
                            'eerst kijken of het record al effectief bestond in de database
                            'als je een nieuwe rij toevoegt, en onmiddellijk delete, dan hoeft die rij niet verwijderd te worden op de database
                            drBest.Delete() 'rij was verwijderd uit grid
                        End If
                    End If
                Next

                Dim drGridBST As DataRow
                For Each drGridBST In dsBest.Tables(0).Rows
                    If drGridBST.RowState = DataRowState.Added Then
                        drBestemmelingen = _dsInterventie.BBBST.NewBBBSTRow
                        'drBestemmelingen.ID_BST = CInt(drGridBST.Item("ID_BST")) 'drGridBST.ID_BST
                        drBestemmelingen.ID_IND = CInt(drGridBST.Item("ID_IND"))
                        drBestemmelingen.ID_INTV_BRDW = _idInterventie
                        drBestemmelingen.NM_IND = CType(drGridBST.Item("NM_IND"), String)
                        If drGridBST.Item("VNM_IND") Is DBNull.Value Then
                            drBestemmelingen.VNM_IND = ""
                        Else
                            drBestemmelingen.VNM_IND = CType(drGridBST.Item("VNM_IND"), String)
                        End If

                        If drGridBST.Item("AD_EMAL_IND") Is DBNull.Value Then
                            drBestemmelingen.AD_EMAL_IND = ""
                        Else
                            drBestemmelingen.AD_EMAL_IND = CType(drGridBST.Item("AD_EMAL_IND"), String)
                        End If
                        _dsInterventie.BBBST.AddBBBSTRow(drBestemmelingen)
                    End If
                Next
            End If

            'Effectief bewaren
            '-----------------
            'getChanges() stuurt enkel de gewijzigde records door over de webservice
            lijnnrError = "6. Effectief bewaren"
            Dim ds As New Proxy.BBWService.Mgt.TDSInterventie
            ds.Merge(_dsInterventie.GetChanges)

            proxy.RegisterInterventie(ds, Environment.UserName)
            _dsInterventie.AcceptChanges()
            'als het om een nieuwe interventie gaat, worden volgende velden ingevuld
            If _idInterventie = -1 Then
                TextBoxJaar.Text = volgnummerJaar.ToString
                TextBoxVolgnummer.Text = volgnummerAfd.ToString
                _idInterventie = idInterventieMax
            End If

            If arrayOfDeletedChronicleID.Count > 0 Then
                For Each aChronicleId As String In arrayOfDeletedChronicleID
                    Call BBWDocumentum.DeleteFileDocumentum(aChronicleId)
                Next
            End If

            Cursor = Cursors.Default

            setStatus("Het interventieverslag werd succesvol opgeslagen")

            'de bewaarde interventie opnieuw gaan tonen
            '------------------------------------------
            'eerst de grids van kosten en interventietijden terug leeg maken
            lijnnrError = "7. Grids leegmaken"
            _dataInterventie.BBMATPR.Clear()
            _dataInterventie.BBINTVDU.Clear()

            lijnnrError = "8. Interventie terug tonen na opslaan"
            Call bindInterventie() 'terug ophalen en tonen (zo zit je met de juiste data uit de database)

        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - OpslaanInterventie" & vbCrLf &
                            "Lijnnr error: " & lijnnrError & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        'boodschap weergeven
    End Sub
    Private Function UploadInterventieBijlageToDocumentum(ByVal drByl As DataRow, ByVal volgnr As String) As String
        'Doel:   Uploaden van de bijlage van een brandweerinterentieverslag in documentum
        'Auteur: Mieke Duynslager - juli 2007

        Dim objectName As String = Year(CDate(UltraDateTimeDatumOpmaak.Value)) & " / " & volgnr & " - " & LabelInterventieType.Text
        Dim locatie As String = CType(drByl.Item("PLA_BYLG"), String)
        Dim titel As String = locatie.Remove(0, locatie.LastIndexOf("\") + 1)
        Dim documentumFolderPath As String = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_DOCUMENTUM_BRANDWEER", "FolderPathDocumentum").WD()

        Return BBWDocumentum.UploadFileDocumentum(CType(drByl.Item("PLA_BYLG"), String), titel, objectName, documentumFolderPath)

    End Function
#End Region
#Region "Datasets"
    Private Sub InitializeDataSet()
        _dataConfiguratie.Merge(CType(FormManager.Current.DataConfiguration, TDSConfiguratie))
        UserControlGeneralFunctionsBrandweer.setDataSetConfiguration(_dataConfiguratie)
    End Sub

    Private Sub InitializeDataSetIndividuen()
        _dataIndividuen.Merge(CType(FormManager.Current.DataIndividuen, TDSIndividuen))
        UserControlGeneralFunctionsBrandweer.setDataSetIndividuen("brandweer", _dataIndividuen)
    End Sub
#End Region
#Region "Functions"
    Private Function controleVeldenOK() As Boolean
        Dim errorBool As Boolean = True

        '08/08/2007 - sidnaco
        'extra controle op Afdeling (op vraag van Toni Masson)
        'EXO (externe ondernemingen) mag niet gekozen worden als afdeling
        If CInt(UltraComboAfdelingen.Value) = 24 Then 'ID_AFD = 24 => EXO
            errorBool = False
            _errorString = "Gelieve de afdeling EXO (externe ondernemingen) te vervangen door een afdeling van ArcelorMittal Gent."
            Return errorBool
        End If
        _errorString = "Gelieve de verplichte velden, aangeduid met een *, in te vullen."

        If UltraDateTimeDatumOpmaak.Text = "" Or UltraDateTimeDatumOpmaak.Text = "__/__/____" Then
            errorBool = False
        End If
        If UltraComboAfdelingen.SelectedRow Is Nothing Then
            errorBool = False
        End If
        If TextBoxOpgeroepen.Text = "" Then
            errorBool = False
        End If
        If UltraMaskedEditTijdstip.Text = "__:__" Or UltraMaskedEditTijdstip.Text = ":" Then
            errorBool = False
        End If
        If TextBoxTussenkomst.Text = "" Then
            errorBool = False
        End If
        If TextBoxWerk_vuurverg.Text = "" Then
            errorBool = False
        End If
        If UltraComboAarden.SelectedRow Is Nothing Then
            errorBool = False
        End If
        If UltraComboOorzaak.SelectedRow Is Nothing Then
            errorBool = False
        End If
        If TextBoxOmschrijving.Text = "" Then
            errorBool = False
        End If
        If Not UserControlGeneralFunctionsBrandweer.checkPersoneelOK Then
            errorBool = False
        End If

        If UltraOptionSetGeblust.CheckedIndex = 1 Then
            CheckOorzakenboom()
        End If

        If _interventieType = 2 Then 'Milieuverontreiniging
            StandaardZin = _dataConfiguratie.BBCONF.FindByGR_SLESLE("MILIEU", "ExtraZinVerslag").WD 'feb 2010 - aanpassing code

            If InStr(UCase(TextBoxOmschrijving.Text), UCase(StandaardZin)) = 0 Then
                TextBoxOmschrijving.Text &= vbCrLf & StandaardZin
            End If
        End If

        Return errorBool
    End Function

    Private Sub setLabelsVerplicht()
        LabelDatumInterventie.Text &= " *"
        LabelAfdeling.Text &= " *"
        LabelOpgeroepen.Text &= " *"
        LabelTijdstip.Text &= " *"
        LabelTussenkomst.Text &= " *"
        LabelWerkvuurvergunning.Text &= " *"
        LabelAard.Text &= " *"
        LabelOorzaak.Text &= " *"
        LabelOmschrijving.Text &= " *"
    End Sub

    Private Sub setInterventieUneditable()
        UltraDateTimeDatumOpmaak.ReadOnly = True
        UltraComboAfdelingen.ReadOnly = True
        TextBoxOpgeroepen.ReadOnly = True
        UltraMaskedEditTijdstip.ReadOnly = True
        TextBoxTussenkomst.ReadOnly = True
        TextBoxWerk_vuurverg.ReadOnly = True
        UltraComboAarden.ReadOnly = True
        UltraComboOorzaak.ReadOnly = True
        TextBoxOmschrijving.ReadOnly = True
        For Each columnMat As Infragistics.Win.UltraWinGrid.UltraGridColumn In UltraGridKosten.DisplayLayout.Bands(0).Columns
            columnMat.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next

        For Each columnTijd As Infragistics.Win.UltraWinGrid.UltraGridColumn In UltraGridInterventieTijden.DisplayLayout.Bands(0).Columns
            columnTijd.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
        UltraOptionSetGeblust.Enabled = False
        UltraOptionSetGeblust.Appearance.ForeColorDisabled = System.Drawing.Color.Black
        UltraOptionSetExtraInfoBrand.Enabled = False
        CheckBoxBWOproep.Enabled = False
        CheckBoxIncOntvangen.Enabled = False
        UltraDateTimeEditorVerzending.ReadOnly = True
        TextBoxVerzending.ReadOnly = True
        ButtonVerzendingBBW.Enabled = False
        UserControlGeneralFunctionsBrandweer.lockControls()
        UltraButtonOpslaan.Enabled = False
        UltraButtonAnnuleer.Enabled = False
    End Sub

    Private Sub initializeMailInfo()
        'Doel:   Verzending van mails => knoppen en textboxen goed zetten
        'Auteur: Rajiv - mei 2006

        Try

            If FormManager.Current.PostOverste Then
                LabelGoedkeuring.Visible = True
                LabelVerzendingBest.Visible = True
                UltraDateTimeEditorBestemmelingen.ReadOnly = True
                TextBoxVerzendingBestemmelingen.ReadOnly = True
                ButtonVerzendingBest.Visible = False
            ElseIf FormManager.Current.BbwVerantwoordelijke Then
                'do nothing, mag alles zien
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
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - intializeMailInfo" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Public Sub checkControls()
        'als het reeds verstuurd is geweest
        If Not FormManager.Current.PostOverste And Not FormManager.Current.BbwVerantwoordelijke Then
            If Not _idInterventie = -1 And Not UltraDateTimeEditorVerzending.Text = "" Then
                UserControlGeneralFunctionsBrandweer.lockControls()
            End If
        End If
    End Sub
    Private Sub CheckOorzakenboom()
        'als het woord oorzakenboom niet voorkomt in de omschrijving, volgende zin toevoegen.
        If InStr(UCase(TextBoxOmschrijving.Text), "OORZAKENBOOM") = 0 Then
            TextBoxOmschrijving.Text += vbCrLf & "Gelieve oorzakenboom op te stellen."

        End If
    End Sub
    Private Sub setStatus(ByVal statusText As String)
        _statusBar.SetStatusbarInfo(statusText)
    End Sub


#End Region
#Region "Mailing"
    Private Sub sendMail(ByVal mailTo As ArrayList,
                         ByVal aText As String,
                         ByVal subject As String,
                         ByVal pathAttach As ArrayList)
        'Purpose:
        'Author:
        'Remark: 17/12/2006 - nacp - pathAttach = ArrayList (meerdere bijlagen kunnen toevoegen in mail)
        Try
            MailBBW.sendMail(mailTo, aText, subject, pathAttach)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

#Region "Rapport"
    Private Sub showReport()
        'Doel:       print preview van het interventierapport tonen
        'Auteur:     Stein Peeters - 20/07/2006
        'Opgelet:    afdrukken kan pas als de interventie is opgeslaan! Dus eerst vragen om de interventie te bewaren
        'Parameters: 
        Try
            Dim f_rap As New FormRapportenPreview

            If _idInterventie = -1 Then
                'vragen om te bewaren
                Dim dr As New DialogResult
                dr = MessageBox.Show("De interventie dient eerst opgeslagen te worden. Wilt u het nu opslaan?", "Opslaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If dr = DialogResult.Yes Then
                    'opslaan
                    Cursor.Current = Cursors.WaitCursor
                    Try
                        If controleVeldenOK() Then

                            opslaanInterventie()

                            'rapport tonen
                            f_rap.InterventieID = _idInterventie
                            f_rap.Show()
                            f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "InterventieBrandweer", "ID_INTV_BRDW", CStr(_idInterventie), "", "", "", "")

                            'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "InterventieBrandweer")
                            'report.AddParameter("ID_INTV_BRDW", InterventieID)
                            'f_rap.ExportPDF("/GENT/PLANT/PEB/BBW", "InterventieBrandweer", "ID_INTV_BRDW", CStr(IDInterventie), "", "", "", "")

                            setStatus("Het interventieverslag werd succesvol opgeslagen")
                        Else
                            MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                                        "Form: FormBrandweerInterventie - ButtonVoegToe_Click" & vbCrLf &
                                        "Message: " & ex.Message & vbCrLf &
                                        "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                    Cursor.Current = Cursors.Default
                End If
            Else
                If controleVeldenOK() Then
                    'rapport tonen
                    f_rap.InterventieID = _idInterventie
                    f_rap.Show()
                    f_rap.ToonRapport("/GENT/PLANT/PEB/BBW", "InterventieBrandweer", "ID_INTV_BRDW", CStr(_idInterventie), "", "", "", "")

                    'Dim report As New ADF.Reporting.SRS.UrlAccess.Report("/GENT/PLANT/PEB/BBW", "InterventieBrandweer")
                    'report.AddParameter("ID_INTV_BRDW", InterventieID)
                    'f_rap.ExportPDF()
                Else
                    MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - showReport" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "User control"
    Private Sub UserControlGeneralFunctionsBrandweer_IKPReportChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UserControlGeneralFunctionsBrandweer.IKPReportChanged
        Try
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            Dim tempIKPAddressees As Component.TDSBBBestemmelingen = New Component.TDSBBBestemmelingen
            Dim rowCount As Integer

            tempIKPAddressees.Merge(proxy.GetAddresseesFromConfig(Configuration.ConfigurationSettings.AppSettings.Get("IKP_AddresseesConfigKey")))

            If (CType(sender, CheckBox).Checked) Then

                For Each destineeRow As Component.TDSBBBestemmelingen.BBBSTRow In tempIKPAddressees.BBBST.Rows
                    rowCount = CType(UserControlGeneralFunctionsBrandweer.getDataBestemmelingen, Component.TDSBBBestemmelingen).BBBST.Select("ID_IND=" & destineeRow.ID_IND).Length

                    If Not (rowCount <> 0) Then
                        If (destineeRow.IsAD_EMAL_INDNull) Then
                            UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, destineeRow.ID_IND, destineeRow.NM_IND.ToString(), destineeRow.VNM_IND.ToString(), String.Empty)
                        Else
                            UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, destineeRow.ID_IND, destineeRow.NM_IND.ToString(), destineeRow.VNM_IND.ToString(), destineeRow.AD_EMAL_IND.ToString())
                        End If

                    End If

                    rowCount = 0
                Next
            Else

                For Each destineeRow As Component.TDSBBBestemmelingen.BBBSTRow In tempIKPAddressees.BBBST.Rows
                    rowCount = CType(UserControlGeneralFunctionsBrandweer.getDataBestemmelingen, Component.TDSBBBestemmelingen).BBBST.Select("ID_IND=" & destineeRow.ID_IND).Length

                    If (rowCount <> 0) Then
                        UserControlGeneralFunctionsBrandweer.RemoveBestemmeling(destineeRow.ID_IND)
                    End If

                    rowCount = 0
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UserControlGeneralFunctionsBrandweer_NieuwBestemmelingen(ByVal sender As Object, ByVal e As EventArgs) Handles UserControlGeneralFunctionsBrandweer.NieuwBestemmelingen
        '
        '
        Try
            Dim f_ind As FormIndividuen = New FormIndividuen(True, GetAfdeling())

            f_ind.ShowDialog()

            If Not f_ind.Canceled Then
                Dim individu As TDSIndividuen.BBINDRow = f_ind.Individu
                If Not individu.IsAD_EMAL_INDNull Then
                    If Not individu.IsVNM_INDNull Then
                        UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, individu.AD_EMAL_IND)
                    Else
                        UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, individu.ID_IND, individu.NM_IND, "", individu.AD_EMAL_IND)
                    End If
                Else
                    MessageBox.Show("Opgelet, deze persoon heeft geen e-mailadres en zal het verslag dus niet ontvangen.", "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Not individu.IsVNM_INDNull Then
                        UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, individu.ID_IND, individu.NM_IND, individu.VNM_IND, Nothing)
                    Else
                        UserControlGeneralFunctionsBrandweer.addBestemmeling(_idInterventie, individu.ID_IND, individu.NM_IND, "", Nothing)
                    End If
                End If

            End If

            f_ind.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod),
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
#End Region

#Region "Buttons verzending"
    Private Sub ButtonVerzendingBBW_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonVerzendingBBW.Click
        'Doel:   verstuur verslag naar postoverste
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 20/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            If TextBoxJaar.Text = "" And TextBoxVolgnummer.Text = "" Then
                MessageBox.Show("Gelieve eerst een interventie aan te maken en/of op te slaan", "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            ElseIf Not controleVeldenOK() Then
                MessageBox.Show(_errorString, "BBW Brandweer Bewaking Verslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                UltraDateTimeEditorVerzending.Value = Now
                opslaanInterventie()

                textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BRANDWEER", "Goedkeuring").WD & vbCrLf
                textMail &= vbCrLf &
                            "Datum interventie:   " & UltraDateTimeDatumOpmaak.Text & vbCrLf &
                            "Interventietype:     " & _interventieDesc & vbCrLf &
                            "Afdeling:            " & UltraComboAfdelingen.Text & vbCrLf &
                            "Volgnummer Jaar:     " & TextBoxJaar.Text & vbCrLf &
                            "Volgnummer Afdeling: " & TextBoxVolgnummer.Text & vbCrLf &
                            "Opsteller:           " & UserControlGeneralFunctionsBrandweer.getOpsteller & vbCrLf & vbCrLf &
                            "Opmerking Opsteller: " & TextBoxVerzending.Text
                Dim mailTo As New ArrayList
                mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Postoverste").WD)
                sendMail(mailTo, textMail, "Nieuwe interventie Brandweer: " & _interventieDesc & " " & UltraComboAfdelingen.Text, pathsAttachment)

                setStatus("Het interventieverslag werd succesvol verzonden")
                If FormManager.Current.Bewaking Then
                    setInterventieUneditable()
                    UltraButtonOpslaan.Enabled = False
                End If
                ButtonTerugZenden.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - ButtonVerzendingBBW_Click()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonGoedkeuring_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonGoedkeuring.Click
        'Doel:   keur verslag goed
        'Auteur: Koen Heye - mei 2006 - Nancy Coppens - 20/09/2006

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            If Not UltraDateTimeEditorGoedkeuring.Text = "" Then
                If MessageBox.Show("Opgelet, dit verslag is reeds goedgekeurd. Wilt u verder gaan?", "Opgelet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Else
                    Exit Sub
                End If
            End If

            UltraDateTimeEditorGoedkeuring.Value = Now
            opslaanInterventie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BRANDWEER", "Verzending").WD & vbCrLf
            textMail &= vbCrLf &
                        "Datum interventie:   " & UltraDateTimeDatumOpmaak.Text & vbCrLf &
                        "Interventietype:     " & _interventieDesc & vbCrLf &
                        "Afdeling:            " & UltraComboAfdelingen.Text & vbCrLf &
                        "Volgnummer Jaar:     " & TextBoxJaar.Text & vbCrLf &
                        "Volgnummer Afdeling: " & TextBoxVolgnummer.Text & vbCrLf &
                        "Opsteller:           " & UserControlGeneralFunctionsBrandweer.getOpsteller & vbCrLf & vbCrLf &
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf &
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Verantwoordelijke").WD)
            sendMail(mailTo,
                        textMail,
                        "Goedgekeurd interventieverslag Brandweer: " & _interventieDesc & " " & UltraComboAfdelingen.Text,
                        pathsAttachment)

            setStatus("Het interventieverslag werd succesvol goedgekeurd")
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - ButtonGoedkeuring_Click()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ButtonVerzendingBest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonVerzendingBest.Click
        'Doel:        verstuur verslag naar bestemmelingen
        'DUMI: 19/9/2007: Er bestaan twee types bestemmelingen. Voor de internen (best) sturen we voor de bijlagen de URL van documentum door.
        'Voor de externe bestemmelingen (specbest) (die niet behoren tot het Arcelor-domein) sturen we de bijlagen als attachment door.
        'Auteur:      Koen Heye - mei 2006
        'Wijzigingen: Nancy Coppens - 25/09/2006

        Dim best As New ArrayList
        Dim titelMail As String
        Dim textMail As String
        Dim pathsAttachment As New ArrayList
        Dim pathPDFfile As String
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
            If Not UltraDateTimeEditorBestemmelingen.Text = "" Then
                If MessageBox.Show("Opgelet, dit verslag is reeds verzonden naar de bestemmelingen. Wilt u verder gaan?", "Opgelet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Else
                    Exit Sub
                End If
            End If

            For Each bestRow As Component.TDSBBBestemmelingen.BBBSTRow In UserControlGeneralFunctionsBrandweer.getDataBestemmelingen.Tables(0).Rows
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
                UltraDateTimeEditorBestemmelingen.Value = Now
                opslaanInterventie()

                'Eerst rapport exporteren naar PDF-file
                pathPDFfile = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATHS", "PathPDFreports").WD &
                               "Brandweer" & Year(Now()) & "_" & _idInterventie & ".pdf"
                pathsAttachment.Add(pathPDFfile)
                specPathsAttachment.Add(pathPDFfile)

                'Dan mail versturen met PDF-file in attachment
                Dim nullDate As Date
                If CDate(UltraDateTimeEditorBestemmelingen.Value) = nullDate Then 'naco - feb 2013
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BRANDWEER", "Bestemmelingen").WD & vbCrLf 'nieuw verslag
                Else
                    textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BRANDWEER", "BestemmelingenWijziging").WD & vbCrLf
                End If

                textMail &= vbCrLf &
                            "Datum interventie:   " & UltraDateTimeDatumOpmaak.Text & vbCrLf &
                            "Interventietype:     " & _interventieDesc & vbCrLf &
                            "Afdeling:            " & UltraComboAfdelingen.Text & vbCrLf &
                            "Volgnummer Jaar:     " & TextBoxJaar.Text & vbCrLf &
                            "Volgnummer Afdeling: " & TextBoxVolgnummer.Text & vbCrLf &
                            "Opsteller:           " & UserControlGeneralFunctionsBrandweer.getOpsteller & vbCrLf & vbCrLf &
                            "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf &
                            "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

                Dim urlString As String

                'bijlagen toevoegen
                For Each bijlageRow As Component.TDSBijlagen.BBBYLGRow In UserControlGeneralFunctionsBrandweer.getDataBijlagen.Tables(0).Rows
                    If bijlageRow.RowState = DataRowState.Deleted Then
                        'het kan zijn dat er juist een bestemmeling gedelete is
                    Else
                        If (best.Count > 0) Then
                            'juli 2007 - dumi -Als er een chronicleID bestaat voor de bijlage, betekent dit dat het al werd opgeladen in documentum.
                            'Dan kan de url worden samengesteld die de link vormt naar documentum.
                            'vb url: http://svsim045.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0901bad18001a60f&latestflag=y
                            If (Not IsDBNull(bijlageRow.Item("ID_DOC"))) Then
                                urlString = _dataConfiguratie.BBCONF.FindByGR_SLESLE("PATH_URL_DOCUMENTUM_PRE", "Path").WD & bijlageRow.ID_DOC &
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
                f_rap.ExportPdfBrandweerInterventie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("REPORTS", "FolderReports").WD,
                                                   "InterventieBrandweer",
                                                   pathPDFfile,
                                                   CStr(_idInterventie))
                f_rap.Dispose()

                If CDate(UltraDateTimeEditorBestemmelingen.Value) = nullDate Then 'naco - feb 2013
                    titelMail = "Nieuw interventieverslag Brandweer: " & _interventieDesc & " " & UltraComboAfdelingen.Text
                Else
                    titelMail = "Bestaand interventieverslag Brandweer aangepast: " & _interventieDesc & " " & UltraComboAfdelingen.Text
                End If

                If (best.Count > 0) Then
                    sendMail(best, textMail & textMailURL, titelMail, pathsAttachment)
                End If

                If (specBest.Count > 0) Then
                    sendMail(specBest, textMail, titelMail, specPathsAttachment)
                End If

                setStatus("Interventieverslag succesvol verzonden naar de bestemmelingen")

            Else
                MessageBox.Show("Gelieve bestemmelingen in te vullen aub voor deze interventie. Het interventieverslag is niet verstuurd.", "Bestemmelingen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                setStatus("Geen bestemmelingen opgegeven")
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - ButtonVerzendingBest_Click()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonTerugZenden_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonTerugZenden.Click
        'Doel:   Terugsturen verslag naar groepsusernaam van brandweer
        'Auteur: Mieke Duynslager - mei 2007

        Dim textMail As String
        Dim pathsAttachment As New ArrayList

        Try
            UltraDateTimeEditorVerzending.Value = Nothing
            UltraDateTimeEditorGoedkeuring.Value = Nothing
            opslaanInterventie()

            textMail = _dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_BRANDWEER", "Terugzenden").WD & vbCrLf & vbCrLf
            textMail &= "Onderstaand verslag kan niet worden goedgekeurd. Gelieve het verslag te wijzigen." & vbCrLf & vbCrLf &
                        "Datum interventie:   " & UltraDateTimeDatumOpmaak.Text & vbCrLf &
                        "Interventietype:     " & _interventieDesc & vbCrLf &
                        "Afdeling:            " & UltraComboAfdelingen.Text & vbCrLf &
                        "Volgnummer Jaar:     " & TextBoxJaar.Text & vbCrLf &
                        "Volgnummer Afdeling: " & TextBoxVolgnummer.Text & vbCrLf &
                        "Opsteller:           " & UserControlGeneralFunctionsBrandweer.getOpsteller & vbCrLf & vbCrLf &
                        "Opmerking Goedkeurder: " & TextBoxGoedkeuring.Text & vbCrLf &
                        "Opmerking Bestemmeling: " & TextBoxVerzendingBestemmelingen.Text & vbCrLf

            Dim mailTo As New ArrayList
            mailTo.Add(_dataConfiguratie.BBCONF.FindByGR_SLESLE("EMAIL_ADRES", "Brandweer").WD)
            sendMail(mailTo,
                        textMail,
                        "Teruggezonden registratie Brandweer: " & _interventieDesc & " " & UltraComboAfdelingen.Text,
                        pathsAttachment)

            setStatus("De registratie werd teruggestuurd.")

            ButtonTerugZenden.Enabled = False
            ButtonVerzendingBBW.Visible = True
            ButtonVerzendingBBW.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBrandweerInterventie - ButtonTerugZenden_Click()" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region

    Private Sub UltraComboAfdelingen_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UltraComboAfdelingen.ValueChanged

        If _interventieType = 2 Then 'only for Milieuverontreiniging - naco - 15/03/2010
            Dim aTds As Proxy.BBWService.Mgt.TDSBeheerAFDAMC
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy

            aTds = proxy.GetBestemmelingenAfdeling(CInt(UltraComboAfdelingen.Value))
            Dim aTableBestem As New Component.TDSBBBestemmelingen

            '-> 1. AMC of selected department (eg. STL, KWA, ...)
            If aTds.BBAFDAMC.Rows.Count = 0 Then
                MessageBox.Show("Gelieve een AMC op te laden voor de afdeling.", "Geen bestemmelingen AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                For Each aRow As Proxy.BBWService.Mgt.TDSBeheerAFDAMC.BBAFDAMCRow In aTds.BBAFDAMC
                    aTableBestem.BBBST.AddBBBSTRow(_idInterventie, Nothing, aRow.ID_IND, aRow.NM_IND, aRow.VNM_IND, aRow.MAIL)
                Next

            End If

            '-> 2. AMC of department MIL
            '16/02/2010 - naco
            'Telefoon Nico Hautekiet => also add the AMC's of deparment MIL to the addressees 
            Dim aTdsMIL As Proxy.BBWService.Mgt.TDSBeheerAFDAMC
            aTdsMIL = proxy.GetBestemmelingenAfdeling(54) 'id_afd = 54 = MIL

            If aTdsMIL.BBAFDAMC.Rows.Count = 0 Then
                MessageBox.Show("Gelieve een AMC op te laden voor de afdeling MIL.", "Geen bestemmelingen AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                For Each aRow As Proxy.BBWService.Mgt.TDSBeheerAFDAMC.BBAFDAMCRow In aTdsMIL.BBAFDAMC
                    aTableBestem.BBBST.AddBBBSTRow(_idInterventie, Nothing, aRow.ID_IND, aRow.NM_IND, aRow.VNM_IND, aRow.MAIL)
                Next
            End If

            UserControlGeneralFunctionsBrandweer.setBestemmelingenData(aTableBestem.BBBST)

        End If


    End Sub

    Private Function GetAfdeling() As String
        Return UltraComboAfdelingen.Text
    End Function

    Private Sub UltraGridInterventieTijden_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridInterventieTijden.InitializeLayout

    End Sub

    Private Sub UltraDropDownArtikelenKost_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraDropDownArtikelenKost.InitializeLayout

    End Sub
End Class

