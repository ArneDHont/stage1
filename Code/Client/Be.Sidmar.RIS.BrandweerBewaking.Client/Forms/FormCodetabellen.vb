Option Strict On
Option Explicit On 

Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports System.IO
Imports System.Drawing

Public Class FormCodetabellen
    Inherits System.Windows.Forms.Form

    ' GMAE - 2013-06-20: changed the alternate colour in the grids from 'InactiveCaptionText' into 'Info'

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
    Friend WithEvents RadioButtonAarden As System.Windows.Forms.RadioButton
    Friend WithEvents _dataAarden As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAarden
    Friend WithEvents UltraGridAarden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBoxCodetabel As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents _dataOorzaken As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOorzaken
    Friend WithEvents UltraGridOorzaken As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonOorzaken As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonInterventietypes As System.Windows.Forms.RadioButton
    Friend WithEvents _dataIntvType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType
    Friend WithEvents UltraGridInterventietypes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDropDownInterventietypes As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents RadioButtonAfdelingen As System.Windows.Forms.RadioButton
    Friend WithEvents _dataAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen
    Friend WithEvents UltraGridAfdelingen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonEenheden As System.Windows.Forms.RadioButton
    Friend WithEvents _dataEenheden As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSEenheden
    Friend WithEvents UltraGridEenheden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonArtikelgroep As System.Windows.Forms.RadioButton
    Friend WithEvents _dataArtikelgroep As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSArtikelgroep
    Friend WithEvents UltraGridArtikelgroepen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonInbreuktype As System.Windows.Forms.RadioButton
    Friend WithEvents _dataInbrType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrType
    Friend WithEvents UltraGridInbreuktypes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataRegType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegType
    Friend WithEvents UltraGridRegistratietype As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonRegistratietypes As System.Windows.Forms.RadioButton
    Friend WithEvents _dataIndividutype As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype
    Friend WithEvents RadioButtonIndividutypes As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGridIndividutypes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataInbrArt As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrArt
    Friend WithEvents UltraGridInbreukartikelen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonInbreukartikelen As System.Windows.Forms.RadioButton
    Friend WithEvents UltraDropDownInbreuktypes As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraGridTypeBetrokkenen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonTypesBetrokkenen As System.Windows.Forms.RadioButton
    Friend WithEvents _dataTypeBetrokkene As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSTypeBetrokkene
    Friend WithEvents _dataVoertuigTypes As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVoertuigTypes
    Friend WithEvents UltraGridVoertuigType As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonVoertuigTypes As System.Windows.Forms.RadioButton
    Friend WithEvents _dataAanspreektitel As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAanspreektitel
    Friend WithEvents UltraGridAanspreektitel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonAanspreektitel As System.Windows.Forms.RadioButton
    Friend WithEvents _dataPloeg As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSPloeg
    Friend WithEvents UltraGridPloeg As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonPloegen As System.Windows.Forms.RadioButton
    Friend WithEvents _dataScadObjecten As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSScadObjecten
    Friend WithEvents UltraGridSchadeAan As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonSchadeAan As System.Windows.Forms.RadioButton
    Friend WithEvents _dataGebruikVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSGebruikVoertuig
    Friend WithEvents UltraGridGebruikVoertuig As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonGebruikVoertuig As System.Windows.Forms.RadioButton
    Friend WithEvents _dataWerfVoertuig As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSWerfVoertuig
    Friend WithEvents UltraGridWerfvoertuig As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonWerfvoertuig As System.Windows.Forms.RadioButton
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridPrintDocumentCodeTabellen As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialogCodeTabellen As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraButtonVernieuwen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBoxBrandweer As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxBewaking As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxAlgemeen As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents _dataIntvArt As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt
    Friend WithEvents UltraGridnterventieartikelen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonInterventieartikelen As System.Windows.Forms.RadioButton
    Friend WithEvents UltraDropDownEenheden As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDropDownInterventieartikelen As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents StatusBarCodetabellen As ADF.Windows.Forms.UserControls.StatusBar
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents RadioButtonFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents _dataFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas
    Friend WithEvents UltraGridFirmas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridVerzekeringFirmas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataVerzFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas
    Friend WithEvents RadioButtonVerzekeringFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRegistratietypesDagverslag As System.Windows.Forms.RadioButton
    Friend WithEvents _dataDagverslagRegistratieType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType
    Friend WithEvents ultraGridDagverslagRegistratyType As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataDagverslagInlichtingType As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
    Friend WithEvents UltraGridDagverslagInlichtingType As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonDagverslagInlichtingType As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPersoneel As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGridPersoneel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents RadioButtonAMC As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGridAFDAMC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataAFDAMC As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBBAFDAMC
    Friend WithEvents UltraDropDownAfdeling As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDropDownIndividuen As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents _dataIndividuen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen
    Friend WithEvents _dataBBBWPERS As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBBBWPERS

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBIND", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
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
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_FIE")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBARTGR", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_GR_ART", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBEH", -1)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_EH")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRTY", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INBR")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INBR", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTVTY", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INTV")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFDAMC", -1)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD", -1, "UltraDropDownAfdeling", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND", -1, "UltraDropDownIndividuen")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRTY", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BR_TY_INTV")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_TY_INTV")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BZ")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRAR", -1)
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INBR")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INBR")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_ART_INBR")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukKlasseID")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_FR")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_EN")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INBR_DE")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INBR")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_CLS_INBR")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCodetabellen))
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBREGTY", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_REG")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_REG")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBARTGR", -1)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_GR_ART", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBAFD", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_AFD")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_AFD")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRRD", -1)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BR_RD_INTV")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_RD_INTV")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BZ")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTART", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_ART_INTV")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GR_ART", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_ART_INTV")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_EH_ART_INTV")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TSP_DU_INTV")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBWPERS", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_IND")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_PLG_IND")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BRDW")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WAK")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGPODL", -1)
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PO_DL")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_DG_PO_DL")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INV_PO")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG")
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGTYREG", -1)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PERS_TY_REG")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_DG_PERS_TY_REG")
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBVZKFRM", -1)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_VZK")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_VZK")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_FRM_VZK")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM_VZK")
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBFRM", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STRA_FRM")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_PLA_FRM")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_IND_FRM_SAP")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_SAP")
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand20 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBWRFTSP", -1)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WRF_TSP")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_WRF_TSP")
        Dim Appearance250 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance251 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance252 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance253 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance254 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance255 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance256 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance257 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance258 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance259 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance260 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance261 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance262 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand21 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBRKTSP", -1)
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_BRK_TSP")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BRK_TSP", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance263 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance264 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance265 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance266 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance267 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance268 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance269 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance270 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance271 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance272 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance273 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance274 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance275 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand22 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBSCADAN", -1)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_OBJ_SCAD")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_OBJ_SCAD")
        Dim Appearance276 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance277 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance278 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance279 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance280 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance281 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance282 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance283 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance284 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance285 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance286 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance287 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance288 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand23 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBBWPLG", -1)
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_PLG_IND")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_PLG_IND")
        Dim Appearance289 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance290 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance291 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance292 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance293 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance294 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance295 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance296 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance297 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance298 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance299 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance300 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance301 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand24 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINDGSL", -1)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_GSL_IND")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_IND_GSL_RAP", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance302 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance303 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance304 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance305 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance306 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance307 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance308 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance309 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance310 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance311 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance312 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance313 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance314 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand25 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBTYTSP", -1)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_TSP")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_TSP")
        Dim Appearance315 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance316 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance317 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance318 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance319 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance320 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance321 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance322 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance323 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance324 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance325 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance326 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance327 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand26 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBTYBTRK", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_BTRK")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_BTRK")
        Dim Appearance328 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance329 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance330 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance331 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance332 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance333 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance334 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance335 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance336 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance337 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance338 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance339 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance340 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand27 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINDTY", -1)
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_IND")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_IND", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance341 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance342 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance343 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance344 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance345 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance346 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance347 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance348 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance349 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance350 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance351 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance352 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance353 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand28 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINBRTY", -1)
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INBR")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INBR", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance354 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance355 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance356 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance357 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance358 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance359 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance360 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance361 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance362 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance363 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance364 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance365 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance366 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand29 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBEH", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_EH")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_EH")
        Dim Appearance367 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance368 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance369 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance370 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance371 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance372 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance373 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance374 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance375 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance376 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance377 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance378 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance379 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand30 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINTVTY", -1)
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance380 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance381 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance382 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance383 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance384 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance385 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance386 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance387 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance388 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance389 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance390 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance391 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance392 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.RadioButtonAarden = New System.Windows.Forms.RadioButton()
        Me.UltraGroupBoxBrandweer = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraDropDownIndividuen = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataIndividuen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen()
        Me.UltraDropDownAfdeling = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAfdelingen()
        Me.UltraDropDownInterventieartikelen = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataArtikelgroep = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSArtikelgroep()
        Me.UltraDropDownEenheden = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataEenheden = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSEenheden()
        Me.RadioButtonInterventieartikelen = New System.Windows.Forms.RadioButton()
        Me.UltraDropDownInbreuktypes = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataInbrType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrType()
        Me.UltraDropDownInterventietypes = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me._dataIntvType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvType()
        Me.RadioButtonInterventietypes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOorzaken = New System.Windows.Forms.RadioButton()
        Me.RadioButtonArtikelgroep = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEenheden = New System.Windows.Forms.RadioButton()
        Me.RadioButtonWerfvoertuig = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGebruikVoertuig = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSchadeAan = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPloegen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAanspreektitel = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVoertuigTypes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTypesBetrokkenen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbreukartikelen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIndividutypes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRegistratietypes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInbreuktype = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAfdelingen = New System.Windows.Forms.RadioButton()
        Me.UltraGroupBoxCodetabel = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGridAFDAMC = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataAFDAMC = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBBAFDAMC()
        Me.UltraGridAarden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataAarden = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAarden()
        Me.UltraGridInbreukartikelen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataInbrArt = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInbrArt()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridRegistratietype = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataRegType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSRegType()
        Me.UltraGridArtikelgroepen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridAfdelingen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridOorzaken = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataOorzaken = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSOorzaken()
        Me.UltraGridnterventieartikelen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataIntvArt = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIntvArt()
        Me.UltraGridPersoneel = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBBBWPERS = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBBBWPERS()
        Me.UltraGridDagverslagInlichtingType = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataDagverslagInlichtingType = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType()
        Me.ultraGridDagverslagRegistratyType = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataDagverslagRegistratieType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType()
        Me.UltraGridVerzekeringFirmas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataVerzFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas()
        Me.UltraGridFirmas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridWerfvoertuig = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataWerfVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSWerfVoertuig()
        Me.UltraGridGebruikVoertuig = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataGebruikVoertuig = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSGebruikVoertuig()
        Me.UltraGridSchadeAan = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataScadObjecten = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSScadObjecten()
        Me.UltraGridPloeg = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataPloeg = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSPloeg()
        Me.UltraGridAanspreektitel = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataAanspreektitel = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSAanspreektitel()
        Me.UltraGridVoertuigType = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataVoertuigTypes = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVoertuigTypes()
        Me.UltraGridTypeBetrokkenen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataTypeBetrokkene = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSTypeBetrokkene()
        Me.UltraGridIndividutypes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataIndividutype = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype()
        Me.UltraGridInbreuktypes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridEenheden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridInterventietypes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraButtonVernieuwen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridPrintDocumentCodeTabellen = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialogCodeTabellen = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.UltraGroupBoxBewaking = New Infragistics.Win.Misc.UltraGroupBox()
        Me.RadioButtonDagverslagInlichtingType = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRegistratietypesDagverslag = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVerzekeringFirmas = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFirmas = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPersoneel = New System.Windows.Forms.RadioButton()
        Me.UltraGroupBoxAlgemeen = New Infragistics.Win.Misc.UltraGroupBox()
        Me.RadioButtonAMC = New System.Windows.Forms.RadioButton()
        Me.StatusBarCodetabellen = New ADF.Windows.Forms.UserControls.StatusBar()
        CType(Me.UltraGroupBoxBrandweer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxBrandweer.SuspendLayout()
        CType(Me.UltraDropDownIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownAfdeling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownInterventieartikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataArtikelgroep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownEenheden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataEenheden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownInbreuktypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInbrType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDropDownInterventietypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIntvType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxCodetabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxCodetabel.SuspendLayout()
        CType(Me.UltraGridAFDAMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAFDAMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridAarden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAarden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridInbreukartikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInbrArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridRegistratietype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataRegType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridArtikelgroepen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridOorzaken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataOorzaken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridnterventieartikelen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIntvArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridPersoneel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBBBWPERS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridDagverslagInlichtingType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataDagverslagInlichtingType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultraGridDagverslagRegistratyType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataDagverslagRegistratieType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridVerzekeringFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridWerfvoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataWerfVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridGebruikVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataGebruikVoertuig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridSchadeAan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataScadObjecten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridPloeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataPloeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridAanspreektitel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataAanspreektitel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridVoertuigType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataVoertuigTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridTypeBetrokkenen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataTypeBetrokkene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridIndividutypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataIndividutype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridInbreuktypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridEenheden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridInterventietypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxBewaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxBewaking.SuspendLayout()
        CType(Me.UltraGroupBoxAlgemeen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxAlgemeen.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButtonAarden
        '
        Me.RadioButtonAarden.Location = New System.Drawing.Point(16, 16)
        Me.RadioButtonAarden.Name = "RadioButtonAarden"
        Me.RadioButtonAarden.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonAarden.TabIndex = 0
        Me.RadioButtonAarden.Text = "Aarden"
        '
        'UltraGroupBoxBrandweer
        '
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownIndividuen)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownAfdeling)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownInterventieartikelen)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownEenheden)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonInterventieartikelen)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownInbreuktypes)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraDropDownInterventietypes)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonInterventietypes)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonOorzaken)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonAarden)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonArtikelgroep)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.RadioButtonEenheden)
        Me.UltraGroupBoxBrandweer.Location = New System.Drawing.Point(16, 0)
        Me.UltraGroupBoxBrandweer.Name = "UltraGroupBoxBrandweer"
        Me.UltraGroupBoxBrandweer.Size = New System.Drawing.Size(208, 168)
        Me.UltraGroupBoxBrandweer.TabIndex = 0
        Me.UltraGroupBoxBrandweer.Text = "Brandweer"
        Me.UltraGroupBoxBrandweer.Visible = False
        '
        'UltraDropDownIndividuen
        '
        Me.UltraDropDownIndividuen.DataSource = Me._dataIndividuen
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownIndividuen.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Stamnr"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 90
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Naam"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 120
        UltraGridColumn5.Header.Caption = "Voornaam"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 120
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "EMAIL"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 120
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 19
        UltraGridColumn28.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn28})
        Me.UltraDropDownIndividuen.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraDropDownIndividuen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownIndividuen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownIndividuen.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownIndividuen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraDropDownIndividuen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownIndividuen.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraDropDownIndividuen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownIndividuen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownIndividuen.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownIndividuen.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraDropDownIndividuen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownIndividuen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownIndividuen.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownIndividuen.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraDropDownIndividuen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownIndividuen.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownIndividuen.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.UltraDropDownIndividuen.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraDropDownIndividuen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownIndividuen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownIndividuen.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownIndividuen.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraDropDownIndividuen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownIndividuen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraDropDownIndividuen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownIndividuen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownIndividuen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownIndividuen.DisplayMember = "NM_IND"
        Me.UltraDropDownIndividuen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownIndividuen.Location = New System.Drawing.Point(126, 96)
        Me.UltraDropDownIndividuen.Name = "UltraDropDownIndividuen"
        Me.UltraDropDownIndividuen.Size = New System.Drawing.Size(16, 32)
        Me.UltraDropDownIndividuen.TabIndex = 16
        Me.UltraDropDownIndividuen.Text = "UltraDropDownIndividuen"
        Me.UltraDropDownIndividuen.ValueMember = "ID_IND"
        Me.UltraDropDownIndividuen.Visible = False
        '
        '_dataIndividuen
        '
        Me._dataIndividuen.DataSetName = "TDSIndividuen"
        Me._dataIndividuen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividuen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownAfdeling
        '
        Me.UltraDropDownAfdeling.DataSource = Me._dataAfdelingen
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownAfdeling.DisplayLayout.Appearance = Appearance14
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Afdeling"
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Width = 200
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn31.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.UltraDropDownAfdeling.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraDropDownAfdeling.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownAfdeling.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownAfdeling.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownAfdeling.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.UltraDropDownAfdeling.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownAfdeling.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.UltraDropDownAfdeling.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownAfdeling.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownAfdeling.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownAfdeling.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UltraDropDownAfdeling.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownAfdeling.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownAfdeling.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownAfdeling.DisplayLayout.Override.CellAppearance = Appearance21
        Me.UltraDropDownAfdeling.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownAfdeling.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownAfdeling.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Left"
        Me.UltraDropDownAfdeling.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.UltraDropDownAfdeling.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownAfdeling.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownAfdeling.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownAfdeling.DisplayLayout.Override.RowAppearance = Appearance25
        Me.UltraDropDownAfdeling.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownAfdeling.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.UltraDropDownAfdeling.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownAfdeling.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownAfdeling.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownAfdeling.DisplayMember = "SCF_AFD"
        Me.UltraDropDownAfdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownAfdeling.Location = New System.Drawing.Point(96, 68)
        Me.UltraDropDownAfdeling.Name = "UltraDropDownAfdeling"
        Me.UltraDropDownAfdeling.Size = New System.Drawing.Size(24, 32)
        Me.UltraDropDownAfdeling.TabIndex = 15
        Me.UltraDropDownAfdeling.Text = "UltraDropDown1"
        Me.UltraDropDownAfdeling.ValueMember = "ID_AFD"
        Me.UltraDropDownAfdeling.Visible = False
        '
        '_dataAfdelingen
        '
        Me._dataAfdelingen.DataSetName = "TDSAfdelingen"
        Me._dataAfdelingen.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownInterventieartikelen
        '
        Me.UltraDropDownInterventieartikelen.DataSource = Me._dataArtikelgroep
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Appearance = Appearance27
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Artikelgroep"
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33})
        Me.UltraDropDownInterventieartikelen.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.UltraDropDownInterventieartikelen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownInterventieartikelen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance28.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieartikelen.DisplayLayout.GroupByBox.Appearance = Appearance28
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventieartikelen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance29
        Me.UltraDropDownInterventieartikelen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance30.BackColor2 = System.Drawing.SystemColors.Control
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventieartikelen.DisplayLayout.GroupByBox.PromptAppearance = Appearance30
        Me.UltraDropDownInterventieartikelen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownInterventieartikelen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.CardAreaAppearance = Appearance33
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.CellAppearance = Appearance34
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.RowAlternateAppearance = Appearance37
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.RowAppearance = Appearance38
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownInterventieartikelen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance39
        Me.UltraDropDownInterventieartikelen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownInterventieartikelen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownInterventieartikelen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownInterventieartikelen.DisplayMember = "SCF_GR_ART"
        Me.UltraDropDownInterventieartikelen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownInterventieartikelen.Location = New System.Drawing.Point(152, 8)
        Me.UltraDropDownInterventieartikelen.Name = "UltraDropDownInterventieartikelen"
        Me.UltraDropDownInterventieartikelen.Size = New System.Drawing.Size(16, 32)
        Me.UltraDropDownInterventieartikelen.TabIndex = 14
        Me.UltraDropDownInterventieartikelen.Text = "UltraDropDown1"
        Me.UltraDropDownInterventieartikelen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownInterventieartikelen.ValueMember = "ID_GR_ART"
        Me.UltraDropDownInterventieartikelen.Visible = False
        '
        '_dataArtikelgroep
        '
        Me._dataArtikelgroep.DataSetName = "TDSArtikelgroep"
        Me._dataArtikelgroep.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataArtikelgroep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownEenheden
        '
        Me.UltraDropDownEenheden.DataSource = Me._dataEenheden
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownEenheden.DisplayLayout.Appearance = Appearance40
        UltraGridColumn34.Header.VisiblePosition = 0
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Eenheid"
        UltraGridColumn35.Header.VisiblePosition = 1
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn34, UltraGridColumn35})
        Me.UltraDropDownEenheden.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.UltraDropDownEenheden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownEenheden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance41.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance41.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.Appearance = Appearance41
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance42
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance43.BackColor2 = System.Drawing.SystemColors.Control
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownEenheden.DisplayLayout.GroupByBox.PromptAppearance = Appearance43
        Me.UltraDropDownEenheden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownEenheden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Appearance44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownEenheden.DisplayLayout.Override.ActiveCellAppearance = Appearance44
        Appearance45.BackColor = System.Drawing.SystemColors.Highlight
        Appearance45.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownEenheden.DisplayLayout.Override.ActiveRowAppearance = Appearance45
        Me.UltraDropDownEenheden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownEenheden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.Override.CardAreaAppearance = Appearance46
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Appearance47.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellAppearance = Appearance47
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownEenheden.DisplayLayout.Override.CellPadding = 0
        Appearance48.BackColor = System.Drawing.SystemColors.Control
        Appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance48.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance48.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownEenheden.DisplayLayout.Override.GroupByRowAppearance = Appearance48
        Appearance49.TextHAlignAsString = "Left"
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderAppearance = Appearance49
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownEenheden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance50.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowAlternateAppearance = Appearance50
        Appearance51.BackColor = System.Drawing.SystemColors.Window
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowAppearance = Appearance51
        Me.UltraDropDownEenheden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownEenheden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance52
        Me.UltraDropDownEenheden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownEenheden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownEenheden.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownEenheden.DisplayMember = "SCF_EH"
        Me.UltraDropDownEenheden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownEenheden.Location = New System.Drawing.Point(192, 64)
        Me.UltraDropDownEenheden.Name = "UltraDropDownEenheden"
        Me.UltraDropDownEenheden.Size = New System.Drawing.Size(16, 32)
        Me.UltraDropDownEenheden.TabIndex = 13
        Me.UltraDropDownEenheden.Text = "UltraDropDown1"
        Me.UltraDropDownEenheden.ValueMember = "ID_EH"
        Me.UltraDropDownEenheden.Visible = False
        '
        '_dataEenheden
        '
        Me._dataEenheden.DataSetName = "TDSEenheden"
        Me._dataEenheden.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataEenheden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButtonInterventieartikelen
        '
        Me.RadioButtonInterventieartikelen.Location = New System.Drawing.Point(16, 40)
        Me.RadioButtonInterventieartikelen.Name = "RadioButtonInterventieartikelen"
        Me.RadioButtonInterventieartikelen.Size = New System.Drawing.Size(128, 24)
        Me.RadioButtonInterventieartikelen.TabIndex = 1
        Me.RadioButtonInterventieartikelen.Text = "Interventieartikelen"
        '
        'UltraDropDownInbreuktypes
        '
        Me.UltraDropDownInbreuktypes.DataSource = Me._dataInbrType.BBINBRTY
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownInbreuktypes.DisplayLayout.Appearance = Appearance53
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.Caption = "Omschrijving"
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37})
        Me.UltraDropDownInbreuktypes.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.UltraDropDownInbreuktypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownInbreuktypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance54.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance54.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreuktypes.DisplayLayout.GroupByBox.Appearance = Appearance54
        Appearance55.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInbreuktypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance55
        Me.UltraDropDownInbreuktypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance56.BackColor2 = System.Drawing.SystemColors.Control
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance56.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInbreuktypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance56
        Me.UltraDropDownInbreuktypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownInbreuktypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance57.BackColor = System.Drawing.SystemColors.Window
        Appearance57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.ActiveCellAppearance = Appearance57
        Appearance58.BackColor = System.Drawing.SystemColors.Highlight
        Appearance58.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.ActiveRowAppearance = Appearance58
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.CardAreaAppearance = Appearance59
        Appearance60.BorderColor = System.Drawing.Color.Silver
        Appearance60.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.CellAppearance = Appearance60
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.CellPadding = 0
        Appearance61.BackColor = System.Drawing.SystemColors.Control
        Appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance61.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance61.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.GroupByRowAppearance = Appearance61
        Appearance62.TextHAlignAsString = "Left"
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.HeaderAppearance = Appearance62
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance63.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.RowAlternateAppearance = Appearance63
        Appearance64.BackColor = System.Drawing.SystemColors.Window
        Appearance64.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.RowAppearance = Appearance64
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance65.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownInbreuktypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance65
        Me.UltraDropDownInbreuktypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownInbreuktypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownInbreuktypes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownInbreuktypes.DisplayMember = "SCF_TY_INBR"
        Me.UltraDropDownInbreuktypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownInbreuktypes.Location = New System.Drawing.Point(168, 40)
        Me.UltraDropDownInbreuktypes.Name = "UltraDropDownInbreuktypes"
        Me.UltraDropDownInbreuktypes.Size = New System.Drawing.Size(16, 32)
        Me.UltraDropDownInbreuktypes.TabIndex = 11
        Me.UltraDropDownInbreuktypes.ValueMember = "ID_TY_INBR"
        Me.UltraDropDownInbreuktypes.Visible = False
        '
        '_dataInbrType
        '
        Me._dataInbrType.DataSetName = "TDSInbrType"
        Me._dataInbrType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInbrType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraDropDownInterventietypes
        '
        Me.UltraDropDownInterventietypes.DataSource = Me._dataIntvType.BBINTVTY
        Appearance66.BackColor = System.Drawing.SystemColors.Window
        Appearance66.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraDropDownInterventietypes.DisplayLayout.Appearance = Appearance66
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.Caption = "Interventietype"
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39})
        Me.UltraDropDownInterventietypes.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.UltraDropDownInterventietypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraDropDownInterventietypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance67.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance67.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance67.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventietypes.DisplayLayout.GroupByBox.Appearance = Appearance67
        Appearance68.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventietypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance68
        Me.UltraDropDownInterventietypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance69.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance69.BackColor2 = System.Drawing.SystemColors.Control
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance69.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraDropDownInterventietypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance69
        Me.UltraDropDownInterventietypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraDropDownInterventietypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance70.BackColor = System.Drawing.SystemColors.Window
        Appearance70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.ActiveCellAppearance = Appearance70
        Appearance71.BackColor = System.Drawing.SystemColors.Highlight
        Appearance71.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.ActiveRowAppearance = Appearance71
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance72.BackColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.CardAreaAppearance = Appearance72
        Appearance73.BorderColor = System.Drawing.Color.Silver
        Appearance73.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.CellAppearance = Appearance73
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.CellPadding = 0
        Appearance74.BackColor = System.Drawing.SystemColors.Control
        Appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance74.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance74.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.GroupByRowAppearance = Appearance74
        Appearance75.TextHAlignAsString = "Left"
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.HeaderAppearance = Appearance75
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance76.BackColor = System.Drawing.SystemColors.Info
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.RowAlternateAppearance = Appearance76
        Appearance77.BackColor = System.Drawing.SystemColors.Window
        Appearance77.BorderColor = System.Drawing.Color.Silver
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.RowAppearance = Appearance77
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance78.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraDropDownInterventietypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance78
        Me.UltraDropDownInterventietypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraDropDownInterventietypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraDropDownInterventietypes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraDropDownInterventietypes.DisplayMember = "SCF_TY_INTV"
        Me.UltraDropDownInterventietypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraDropDownInterventietypes.Location = New System.Drawing.Point(200, 8)
        Me.UltraDropDownInterventietypes.Name = "UltraDropDownInterventietypes"
        Me.UltraDropDownInterventietypes.Size = New System.Drawing.Size(32, 32)
        Me.UltraDropDownInterventietypes.TabIndex = 3
        Me.UltraDropDownInterventietypes.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraDropDownInterventietypes.ValueMember = "ID_TY_INTV"
        Me.UltraDropDownInterventietypes.Visible = False
        '
        '_dataIntvType
        '
        Me._dataIntvType.DataSetName = "TDSIntvType"
        Me._dataIntvType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIntvType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButtonInterventietypes
        '
        Me.RadioButtonInterventietypes.Location = New System.Drawing.Point(16, 64)
        Me.RadioButtonInterventietypes.Name = "RadioButtonInterventietypes"
        Me.RadioButtonInterventietypes.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonInterventietypes.TabIndex = 2
        Me.RadioButtonInterventietypes.Text = "Interventietypes"
        '
        'RadioButtonOorzaken
        '
        Me.RadioButtonOorzaken.Location = New System.Drawing.Point(16, 88)
        Me.RadioButtonOorzaken.Name = "RadioButtonOorzaken"
        Me.RadioButtonOorzaken.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonOorzaken.TabIndex = 3
        Me.RadioButtonOorzaken.Text = "Oorzaken"
        '
        'RadioButtonArtikelgroep
        '
        Me.RadioButtonArtikelgroep.Location = New System.Drawing.Point(16, 112)
        Me.RadioButtonArtikelgroep.Name = "RadioButtonArtikelgroep"
        Me.RadioButtonArtikelgroep.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonArtikelgroep.TabIndex = 4
        Me.RadioButtonArtikelgroep.Text = "Artikelgroepen"
        '
        'RadioButtonEenheden
        '
        Me.RadioButtonEenheden.Location = New System.Drawing.Point(16, 136)
        Me.RadioButtonEenheden.Name = "RadioButtonEenheden"
        Me.RadioButtonEenheden.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonEenheden.TabIndex = 5
        Me.RadioButtonEenheden.Text = "Eenheden"
        '
        'RadioButtonWerfvoertuig
        '
        Me.RadioButtonWerfvoertuig.Location = New System.Drawing.Point(16, 208)
        Me.RadioButtonWerfvoertuig.Name = "RadioButtonWerfvoertuig"
        Me.RadioButtonWerfvoertuig.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonWerfvoertuig.TabIndex = 8
        Me.RadioButtonWerfvoertuig.Text = "Werfvoertuigen"
        '
        'RadioButtonGebruikVoertuig
        '
        Me.RadioButtonGebruikVoertuig.Location = New System.Drawing.Point(16, 16)
        Me.RadioButtonGebruikVoertuig.Name = "RadioButtonGebruikVoertuig"
        Me.RadioButtonGebruikVoertuig.Size = New System.Drawing.Size(112, 24)
        Me.RadioButtonGebruikVoertuig.TabIndex = 0
        Me.RadioButtonGebruikVoertuig.Text = "Gebruik Voertuig"
        '
        'RadioButtonSchadeAan
        '
        Me.RadioButtonSchadeAan.Location = New System.Drawing.Point(16, 136)
        Me.RadioButtonSchadeAan.Name = "RadioButtonSchadeAan"
        Me.RadioButtonSchadeAan.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonSchadeAan.TabIndex = 5
        Me.RadioButtonSchadeAan.Text = "Schade Aan"
        '
        'RadioButtonPloegen
        '
        Me.RadioButtonPloegen.Location = New System.Drawing.Point(16, 66)
        Me.RadioButtonPloegen.Name = "RadioButtonPloegen"
        Me.RadioButtonPloegen.Size = New System.Drawing.Size(104, 16)
        Me.RadioButtonPloegen.TabIndex = 2
        Me.RadioButtonPloegen.Text = "Ploegen"
        '
        'RadioButtonAanspreektitel
        '
        Me.RadioButtonAanspreektitel.Location = New System.Drawing.Point(16, 16)
        Me.RadioButtonAanspreektitel.Name = "RadioButtonAanspreektitel"
        Me.RadioButtonAanspreektitel.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonAanspreektitel.TabIndex = 0
        Me.RadioButtonAanspreektitel.Text = "Aanspreektitels"
        '
        'RadioButtonVoertuigTypes
        '
        Me.RadioButtonVoertuigTypes.Location = New System.Drawing.Point(16, 184)
        Me.RadioButtonVoertuigTypes.Name = "RadioButtonVoertuigTypes"
        Me.RadioButtonVoertuigTypes.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonVoertuigTypes.TabIndex = 7
        Me.RadioButtonVoertuigTypes.Text = "Types voertuig"
        '
        'RadioButtonTypesBetrokkenen
        '
        Me.RadioButtonTypesBetrokkenen.Location = New System.Drawing.Point(16, 160)
        Me.RadioButtonTypesBetrokkenen.Name = "RadioButtonTypesBetrokkenen"
        Me.RadioButtonTypesBetrokkenen.Size = New System.Drawing.Size(120, 24)
        Me.RadioButtonTypesBetrokkenen.TabIndex = 6
        Me.RadioButtonTypesBetrokkenen.Text = "Types betrokkenen"
        '
        'RadioButtonInbreukartikelen
        '
        Me.RadioButtonInbreukartikelen.Location = New System.Drawing.Point(16, 40)
        Me.RadioButtonInbreukartikelen.Name = "RadioButtonInbreukartikelen"
        Me.RadioButtonInbreukartikelen.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonInbreukartikelen.TabIndex = 1
        Me.RadioButtonInbreukartikelen.Text = "Inbreukartikelen"
        '
        'RadioButtonIndividutypes
        '
        Me.RadioButtonIndividutypes.Location = New System.Drawing.Point(16, 88)
        Me.RadioButtonIndividutypes.Name = "RadioButtonIndividutypes"
        Me.RadioButtonIndividutypes.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonIndividutypes.TabIndex = 3
        Me.RadioButtonIndividutypes.Text = "Individutypes"
        '
        'RadioButtonRegistratietypes
        '
        Me.RadioButtonRegistratietypes.Location = New System.Drawing.Point(16, 112)
        Me.RadioButtonRegistratietypes.Name = "RadioButtonRegistratietypes"
        Me.RadioButtonRegistratietypes.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonRegistratietypes.TabIndex = 4
        Me.RadioButtonRegistratietypes.Text = "Registratietypes"
        '
        'RadioButtonInbreuktype
        '
        Me.RadioButtonInbreuktype.Location = New System.Drawing.Point(16, 64)
        Me.RadioButtonInbreuktype.Name = "RadioButtonInbreuktype"
        Me.RadioButtonInbreuktype.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonInbreuktype.TabIndex = 2
        Me.RadioButtonInbreuktype.Text = "Inbreuktypes"
        '
        'RadioButtonAfdelingen
        '
        Me.RadioButtonAfdelingen.Location = New System.Drawing.Point(16, 40)
        Me.RadioButtonAfdelingen.Name = "RadioButtonAfdelingen"
        Me.RadioButtonAfdelingen.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonAfdelingen.TabIndex = 1
        Me.RadioButtonAfdelingen.Text = "Afdelingen"
        '
        'UltraGroupBoxCodetabel
        '
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridAFDAMC)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridAarden)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridInbreukartikelen)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraButtonSluiten)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridRegistratietype)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridArtikelgroepen)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridAfdelingen)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridOorzaken)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridnterventieartikelen)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridPersoneel)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridDagverslagInlichtingType)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.ultraGridDagverslagRegistratyType)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridVerzekeringFirmas)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridFirmas)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraButtonAfdrukken)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraButtonOpslaan)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridWerfvoertuig)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridGebruikVoertuig)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridSchadeAan)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridPloeg)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridAanspreektitel)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridVoertuigType)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridTypeBetrokkenen)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridIndividutypes)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridInbreuktypes)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridEenheden)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraGridInterventietypes)
        Me.UltraGroupBoxCodetabel.Controls.Add(Me.UltraButtonVernieuwen)
        Me.UltraGroupBoxCodetabel.Location = New System.Drawing.Point(240, 0)
        Me.UltraGroupBoxCodetabel.Name = "UltraGroupBoxCodetabel"
        Me.UltraGroupBoxCodetabel.Size = New System.Drawing.Size(760, 672)
        Me.UltraGroupBoxCodetabel.TabIndex = 3
        Me.UltraGroupBoxCodetabel.Text = "Codetabel"
        '
        'UltraGridAFDAMC
        '
        Me.UltraGridAFDAMC.DataMember = "BBAFDAMC"
        Me.UltraGridAFDAMC.DataSource = Me._dataAFDAMC
        Appearance79.BackColor = System.Drawing.SystemColors.Window
        Appearance79.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridAFDAMC.DisplayLayout.Appearance = Appearance79
        Me.UltraGridAFDAMC.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn40.Header.Caption = "Afdeling"
        UltraGridColumn40.Header.VisiblePosition = 0
        UltraGridColumn40.Width = 175
        UltraGridColumn41.Header.Caption = "Persoon"
        UltraGridColumn41.Header.VisiblePosition = 1
        UltraGridColumn41.Width = 516
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn40, UltraGridColumn41})
        Me.UltraGridAFDAMC.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.UltraGridAFDAMC.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAFDAMC.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance80.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance80.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance80.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAFDAMC.DisplayLayout.GroupByBox.Appearance = Appearance80
        Appearance81.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAFDAMC.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance81
        Me.UltraGridAFDAMC.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAFDAMC.DisplayLayout.GroupByBox.Hidden = True
        Appearance82.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance82.BackColor2 = System.Drawing.SystemColors.Control
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance82.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAFDAMC.DisplayLayout.GroupByBox.PromptAppearance = Appearance82
        Me.UltraGridAFDAMC.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridAFDAMC.DisplayLayout.MaxRowScrollRegions = 1
        Appearance83.BackColor = System.Drawing.SystemColors.Window
        Appearance83.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridAFDAMC.DisplayLayout.Override.ActiveCellAppearance = Appearance83
        Appearance84.BackColor = System.Drawing.SystemColors.Highlight
        Appearance84.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridAFDAMC.DisplayLayout.Override.ActiveRowAppearance = Appearance84
        Me.UltraGridAFDAMC.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridAFDAMC.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAFDAMC.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridAFDAMC.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAFDAMC.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridAFDAMC.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance85.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridAFDAMC.DisplayLayout.Override.CardAreaAppearance = Appearance85
        Appearance86.BorderColor = System.Drawing.Color.Silver
        Appearance86.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridAFDAMC.DisplayLayout.Override.CellAppearance = Appearance86
        Me.UltraGridAFDAMC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridAFDAMC.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridAFDAMC.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance87.BackColor = System.Drawing.SystemColors.Control
        Appearance87.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance87.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance87.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAFDAMC.DisplayLayout.Override.GroupByRowAppearance = Appearance87
        Appearance88.TextHAlignAsString = "Left"
        Me.UltraGridAFDAMC.DisplayLayout.Override.HeaderAppearance = Appearance88
        Me.UltraGridAFDAMC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridAFDAMC.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance89.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridAFDAMC.DisplayLayout.Override.RowAlternateAppearance = Appearance89
        Appearance90.BackColor = System.Drawing.SystemColors.Window
        Appearance90.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridAFDAMC.DisplayLayout.Override.RowAppearance = Appearance90
        Me.UltraGridAFDAMC.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAFDAMC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridAFDAMC.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance91.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridAFDAMC.DisplayLayout.Override.TemplateAddRowAppearance = Appearance91
        Me.UltraGridAFDAMC.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridAFDAMC.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridAFDAMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAFDAMC.Location = New System.Drawing.Point(16, 300)
        Me.UltraGridAFDAMC.Name = "UltraGridAFDAMC"
        Me.UltraGridAFDAMC.Size = New System.Drawing.Size(728, 72)
        Me.UltraGridAFDAMC.TabIndex = 44
        '
        '_dataAFDAMC
        '
        Me._dataAFDAMC.DataSetName = "TDSBBAFDAMC"
        Me._dataAFDAMC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridAarden
        '
        Me.UltraGridAarden.DataSource = Me._dataAarden.BBBRTY
        Appearance92.BackColor = System.Drawing.SystemColors.Window
        Appearance92.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridAarden.DisplayLayout.Appearance = Appearance92
        Me.UltraGridAarden.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn42.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn42.Header.Caption = "IdAard"
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.Width = 50
        UltraGridColumn43.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn43.Header.Caption = "Omschrijving"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.Width = 287
        UltraGridColumn44.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn44.Header.Caption = "InGebruik"
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Width = 192
        UltraGridColumn45.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn45.Header.Caption = "Interventietype"
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.Width = 212
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45})
        Me.UltraGridAarden.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.UltraGridAarden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAarden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance93.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAarden.DisplayLayout.GroupByBox.Appearance = Appearance93
        Appearance94.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAarden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance94
        Me.UltraGridAarden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAarden.DisplayLayout.GroupByBox.Hidden = True
        Appearance95.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance95.BackColor2 = System.Drawing.SystemColors.Control
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance95.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAarden.DisplayLayout.GroupByBox.PromptAppearance = Appearance95
        Me.UltraGridAarden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridAarden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance96.BackColor = System.Drawing.SystemColors.Window
        Appearance96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridAarden.DisplayLayout.Override.ActiveCellAppearance = Appearance96
        Appearance97.BackColor = System.Drawing.SystemColors.Highlight
        Appearance97.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridAarden.DisplayLayout.Override.ActiveRowAppearance = Appearance97
        Me.UltraGridAarden.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridAarden.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAarden.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridAarden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAarden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridAarden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance98.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridAarden.DisplayLayout.Override.CardAreaAppearance = Appearance98
        Appearance99.BorderColor = System.Drawing.Color.Silver
        Appearance99.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridAarden.DisplayLayout.Override.CellAppearance = Appearance99
        Me.UltraGridAarden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridAarden.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridAarden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance100.BackColor = System.Drawing.SystemColors.Control
        Appearance100.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance100.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAarden.DisplayLayout.Override.GroupByRowAppearance = Appearance100
        Appearance101.TextHAlignAsString = "Left"
        Me.UltraGridAarden.DisplayLayout.Override.HeaderAppearance = Appearance101
        Me.UltraGridAarden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridAarden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance102.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridAarden.DisplayLayout.Override.RowAlternateAppearance = Appearance102
        Appearance103.BackColor = System.Drawing.SystemColors.Window
        Appearance103.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridAarden.DisplayLayout.Override.RowAppearance = Appearance103
        Me.UltraGridAarden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAarden.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridAarden.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance104.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridAarden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance104
        Me.UltraGridAarden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridAarden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridAarden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAarden.Location = New System.Drawing.Point(16, 24)
        Me.UltraGridAarden.Name = "UltraGridAarden"
        Me.UltraGridAarden.Size = New System.Drawing.Size(728, 72)
        Me.UltraGridAarden.TabIndex = 1
        Me.UltraGridAarden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataAarden
        '
        Me._dataAarden.DataSetName = "TDSAarden"
        Me._dataAarden.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAarden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridInbreukartikelen
        '
        Me.UltraGridInbreukartikelen.DataSource = Me._dataInbrArt.BBINBRAR
        Appearance105.BackColor = System.Drawing.SystemColors.Window
        Appearance105.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridInbreukartikelen.DisplayLayout.Appearance = Appearance105
        UltraGridColumn46.Header.VisiblePosition = 0
        UltraGridColumn47.Header.VisiblePosition = 1
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridColumn49.Header.VisiblePosition = 3
        UltraGridColumn50.Header.VisiblePosition = 4
        UltraGridColumn51.Header.VisiblePosition = 5
        UltraGridColumn52.Header.VisiblePosition = 6
        UltraGridColumn53.Header.VisiblePosition = 7
        UltraGridColumn54.Header.VisiblePosition = 8
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 9
        UltraGridColumn55.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55})
        Me.UltraGridInbreukartikelen.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.UltraGridInbreukartikelen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreukartikelen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance106.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance106.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance106.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.Appearance = Appearance106
        Appearance107.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance107
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.Hidden = True
        Appearance108.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance108.BackColor2 = System.Drawing.SystemColors.Control
        Appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance108.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreukartikelen.DisplayLayout.GroupByBox.PromptAppearance = Appearance108
        Me.UltraGridInbreukartikelen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridInbreukartikelen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance109.BackColor = System.Drawing.SystemColors.Window
        Appearance109.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.ActiveCellAppearance = Appearance109
        Appearance110.BackColor = System.Drawing.SystemColors.Highlight
        Appearance110.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.ActiveRowAppearance = Appearance110
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance111.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CardAreaAppearance = Appearance111
        Appearance112.BorderColor = System.Drawing.Color.Silver
        Appearance112.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellAppearance = Appearance112
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.CellPadding = 0
        Appearance113.BackColor = System.Drawing.SystemColors.Control
        Appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance113.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance113.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.GroupByRowAppearance = Appearance113
        Appearance114.TextHAlignAsString = "Left"
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderAppearance = Appearance114
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance115.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowAlternateAppearance = Appearance115
        Appearance116.BackColor = System.Drawing.SystemColors.Window
        Appearance116.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowAppearance = Appearance116
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance117.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridInbreukartikelen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance117
        Me.UltraGridInbreukartikelen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridInbreukartikelen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridInbreukartikelen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInbreukartikelen.Location = New System.Drawing.Point(16, 240)
        Me.UltraGridInbreukartikelen.Name = "UltraGridInbreukartikelen"
        Me.UltraGridInbreukartikelen.Size = New System.Drawing.Size(736, 80)
        Me.UltraGridInbreukartikelen.TabIndex = 10
        Me.UltraGridInbreukartikelen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataInbrArt
        '
        Me._dataInbrArt.DataSetName = "TDSInbrArt"
        Me._dataInbrArt.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataInbrArt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraButtonSluiten
        '
        Appearance118.Image = CType(resources.GetObject("Appearance118.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance118
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(664, 640)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 3
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'UltraGridRegistratietype
        '
        Me.UltraGridRegistratietype.DataSource = Me._dataRegType
        Appearance119.BackColor = System.Drawing.SystemColors.Window
        Appearance119.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridRegistratietype.DisplayLayout.Appearance = Appearance119
        Me.UltraGridRegistratietype.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn56.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.Width = 457
        UltraGridColumn57.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn57.Header.Caption = "Registratietype"
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Width = 323
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57})
        Me.UltraGridRegistratietype.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.UltraGridRegistratietype.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridRegistratietype.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance120.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance120.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance120.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance120.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratietype.DisplayLayout.GroupByBox.Appearance = Appearance120
        Appearance121.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridRegistratietype.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance121
        Me.UltraGridRegistratietype.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridRegistratietype.DisplayLayout.GroupByBox.Hidden = True
        Appearance122.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance122.BackColor2 = System.Drawing.SystemColors.Control
        Appearance122.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance122.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridRegistratietype.DisplayLayout.GroupByBox.PromptAppearance = Appearance122
        Me.UltraGridRegistratietype.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridRegistratietype.DisplayLayout.MaxRowScrollRegions = 1
        Appearance123.BackColor = System.Drawing.SystemColors.Window
        Appearance123.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridRegistratietype.DisplayLayout.Override.ActiveCellAppearance = Appearance123
        Appearance124.BackColor = System.Drawing.SystemColors.Highlight
        Appearance124.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridRegistratietype.DisplayLayout.Override.ActiveRowAppearance = Appearance124
        Me.UltraGridRegistratietype.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridRegistratietype.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridRegistratietype.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridRegistratietype.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridRegistratietype.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridRegistratietype.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance125.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratietype.DisplayLayout.Override.CardAreaAppearance = Appearance125
        Appearance126.BorderColor = System.Drawing.Color.Silver
        Appearance126.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridRegistratietype.DisplayLayout.Override.CellAppearance = Appearance126
        Me.UltraGridRegistratietype.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridRegistratietype.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridRegistratietype.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance127.BackColor = System.Drawing.SystemColors.Control
        Appearance127.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance127.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance127.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridRegistratietype.DisplayLayout.Override.GroupByRowAppearance = Appearance127
        Appearance128.TextHAlignAsString = "Left"
        Me.UltraGridRegistratietype.DisplayLayout.Override.HeaderAppearance = Appearance128
        Me.UltraGridRegistratietype.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridRegistratietype.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance129.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridRegistratietype.DisplayLayout.Override.RowAlternateAppearance = Appearance129
        Appearance130.BackColor = System.Drawing.SystemColors.Window
        Appearance130.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridRegistratietype.DisplayLayout.Override.RowAppearance = Appearance130
        Me.UltraGridRegistratietype.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridRegistratietype.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance131.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridRegistratietype.DisplayLayout.Override.TemplateAddRowAppearance = Appearance131
        Me.UltraGridRegistratietype.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridRegistratietype.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridRegistratietype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridRegistratietype.Location = New System.Drawing.Point(384, 192)
        Me.UltraGridRegistratietype.Name = "UltraGridRegistratietype"
        Me.UltraGridRegistratietype.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridRegistratietype.TabIndex = 8
        Me.UltraGridRegistratietype.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataRegType
        '
        Me._dataRegType.DataSetName = "TDSRegType"
        Me._dataRegType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataRegType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridArtikelgroepen
        '
        Me.UltraGridArtikelgroepen.DataSource = Me._dataArtikelgroep.BBARTGR
        Appearance132.BackColor = System.Drawing.SystemColors.Window
        Appearance132.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridArtikelgroepen.DisplayLayout.Appearance = Appearance132
        Me.UltraGridArtikelgroepen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn58.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn58.Header.VisiblePosition = 0
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn59.Header.Caption = "Artikelgroep"
        UltraGridColumn59.Header.VisiblePosition = 1
        UltraGridColumn59.Width = 323
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn58, UltraGridColumn59})
        Me.UltraGridArtikelgroepen.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.UltraGridArtikelgroepen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridArtikelgroepen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance133.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance133.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridArtikelgroepen.DisplayLayout.GroupByBox.Appearance = Appearance133
        Appearance134.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridArtikelgroepen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance134
        Me.UltraGridArtikelgroepen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridArtikelgroepen.DisplayLayout.GroupByBox.Hidden = True
        Appearance135.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance135.BackColor2 = System.Drawing.SystemColors.Control
        Appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance135.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridArtikelgroepen.DisplayLayout.GroupByBox.PromptAppearance = Appearance135
        Me.UltraGridArtikelgroepen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridArtikelgroepen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance136.BackColor = System.Drawing.SystemColors.Window
        Appearance136.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.ActiveCellAppearance = Appearance136
        Appearance137.BackColor = System.Drawing.SystemColors.Highlight
        Appearance137.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.ActiveRowAppearance = Appearance137
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance138.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.CardAreaAppearance = Appearance138
        Appearance139.BorderColor = System.Drawing.Color.Silver
        Appearance139.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.CellAppearance = Appearance139
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance140.BackColor = System.Drawing.SystemColors.Control
        Appearance140.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance140.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance140.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance140.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.GroupByRowAppearance = Appearance140
        Appearance141.TextHAlignAsString = "Left"
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.HeaderAppearance = Appearance141
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance142.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.RowAlternateAppearance = Appearance142
        Appearance143.BackColor = System.Drawing.SystemColors.Window
        Appearance143.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.RowAppearance = Appearance143
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance144.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridArtikelgroepen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance144
        Me.UltraGridArtikelgroepen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridArtikelgroepen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridArtikelgroepen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridArtikelgroepen.Location = New System.Drawing.Point(128, 144)
        Me.UltraGridArtikelgroepen.Name = "UltraGridArtikelgroepen"
        Me.UltraGridArtikelgroepen.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridArtikelgroepen.TabIndex = 6
        Me.UltraGridArtikelgroepen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGridAfdelingen
        '
        Me.UltraGridAfdelingen.DataSource = Me._dataAfdelingen
        Appearance145.BackColor = System.Drawing.SystemColors.Window
        Appearance145.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridAfdelingen.DisplayLayout.Appearance = Appearance145
        Me.UltraGridAfdelingen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn60.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Width = 85
        UltraGridColumn61.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn61.Header.Caption = "Omschrijving"
        UltraGridColumn61.Header.VisiblePosition = 2
        UltraGridColumn61.Width = 305
        UltraGridColumn62.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn62.Header.Caption = "Afdeling"
        UltraGridColumn62.Header.VisiblePosition = 1
        UltraGridColumn62.Width = 282
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61, UltraGridColumn62})
        Me.UltraGridAfdelingen.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.UltraGridAfdelingen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAfdelingen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance146.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance146.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance146.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance146.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAfdelingen.DisplayLayout.GroupByBox.Appearance = Appearance146
        Appearance147.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAfdelingen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance147
        Me.UltraGridAfdelingen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAfdelingen.DisplayLayout.GroupByBox.Hidden = True
        Appearance148.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance148.BackColor2 = System.Drawing.SystemColors.Control
        Appearance148.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance148.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAfdelingen.DisplayLayout.GroupByBox.PromptAppearance = Appearance148
        Me.UltraGridAfdelingen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridAfdelingen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance149.BackColor = System.Drawing.SystemColors.Window
        Appearance149.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridAfdelingen.DisplayLayout.Override.ActiveCellAppearance = Appearance149
        Appearance150.BackColor = System.Drawing.SystemColors.Highlight
        Appearance150.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridAfdelingen.DisplayLayout.Override.ActiveRowAppearance = Appearance150
        Me.UltraGridAfdelingen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridAfdelingen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAfdelingen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridAfdelingen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAfdelingen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridAfdelingen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance151.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridAfdelingen.DisplayLayout.Override.CardAreaAppearance = Appearance151
        Appearance152.BorderColor = System.Drawing.Color.Silver
        Appearance152.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridAfdelingen.DisplayLayout.Override.CellAppearance = Appearance152
        Me.UltraGridAfdelingen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridAfdelingen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridAfdelingen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance153.BackColor = System.Drawing.SystemColors.Control
        Appearance153.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance153.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance153.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance153.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAfdelingen.DisplayLayout.Override.GroupByRowAppearance = Appearance153
        Appearance154.TextHAlignAsString = "Left"
        Me.UltraGridAfdelingen.DisplayLayout.Override.HeaderAppearance = Appearance154
        Me.UltraGridAfdelingen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridAfdelingen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance155.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridAfdelingen.DisplayLayout.Override.RowAlternateAppearance = Appearance155
        Appearance156.BackColor = System.Drawing.SystemColors.Window
        Appearance156.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridAfdelingen.DisplayLayout.Override.RowAppearance = Appearance156
        Me.UltraGridAfdelingen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAfdelingen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance157.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridAfdelingen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance157
        Me.UltraGridAfdelingen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridAfdelingen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridAfdelingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAfdelingen.Location = New System.Drawing.Point(120, 96)
        Me.UltraGridAfdelingen.Name = "UltraGridAfdelingen"
        Me.UltraGridAfdelingen.Size = New System.Drawing.Size(624, 80)
        Me.UltraGridAfdelingen.TabIndex = 4
        Me.UltraGridAfdelingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGridOorzaken
        '
        Me.UltraGridOorzaken.DataSource = Me._dataOorzaken.BBBRRD
        Appearance158.BackColor = System.Drawing.SystemColors.Window
        Appearance158.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridOorzaken.DisplayLayout.Appearance = Appearance158
        Me.UltraGridOorzaken.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn63.Header.VisiblePosition = 0
        UltraGridColumn63.Width = 86
        UltraGridColumn64.Header.VisiblePosition = 1
        UltraGridColumn64.Width = 95
        UltraGridColumn65.Header.VisiblePosition = 2
        UltraGridColumn65.Width = 56
        UltraGridColumn66.Header.VisiblePosition = 3
        UltraGridColumn66.Width = 70
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        Me.UltraGridOorzaken.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.UltraGridOorzaken.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOorzaken.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance159.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance159.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance159.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOorzaken.DisplayLayout.GroupByBox.Appearance = Appearance159
        Appearance160.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOorzaken.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance160
        Me.UltraGridOorzaken.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridOorzaken.DisplayLayout.GroupByBox.Hidden = True
        Appearance161.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance161.BackColor2 = System.Drawing.SystemColors.Control
        Appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance161.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridOorzaken.DisplayLayout.GroupByBox.PromptAppearance = Appearance161
        Me.UltraGridOorzaken.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridOorzaken.DisplayLayout.MaxRowScrollRegions = 1
        Appearance162.BackColor = System.Drawing.SystemColors.Window
        Appearance162.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridOorzaken.DisplayLayout.Override.ActiveCellAppearance = Appearance162
        Appearance163.BackColor = System.Drawing.SystemColors.Highlight
        Appearance163.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridOorzaken.DisplayLayout.Override.ActiveRowAppearance = Appearance163
        Me.UltraGridOorzaken.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridOorzaken.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOorzaken.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridOorzaken.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOorzaken.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridOorzaken.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance164.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridOorzaken.DisplayLayout.Override.CardAreaAppearance = Appearance164
        Appearance165.BorderColor = System.Drawing.Color.Silver
        Appearance165.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridOorzaken.DisplayLayout.Override.CellAppearance = Appearance165
        Me.UltraGridOorzaken.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridOorzaken.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridOorzaken.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance166.BackColor = System.Drawing.SystemColors.Control
        Appearance166.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance166.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance166.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance166.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridOorzaken.DisplayLayout.Override.GroupByRowAppearance = Appearance166
        Appearance167.TextHAlignAsString = "Left"
        Me.UltraGridOorzaken.DisplayLayout.Override.HeaderAppearance = Appearance167
        Me.UltraGridOorzaken.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridOorzaken.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance168.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridOorzaken.DisplayLayout.Override.RowAlternateAppearance = Appearance168
        Appearance169.BackColor = System.Drawing.SystemColors.Window
        Appearance169.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridOorzaken.DisplayLayout.Override.RowAppearance = Appearance169
        Me.UltraGridOorzaken.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridOorzaken.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance170.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridOorzaken.DisplayLayout.Override.TemplateAddRowAppearance = Appearance170
        Me.UltraGridOorzaken.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridOorzaken.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridOorzaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridOorzaken.Location = New System.Drawing.Point(384, 24)
        Me.UltraGridOorzaken.Name = "UltraGridOorzaken"
        Me.UltraGridOorzaken.Size = New System.Drawing.Size(344, 80)
        Me.UltraGridOorzaken.TabIndex = 2
        Me.UltraGridOorzaken.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataOorzaken
        '
        Me._dataOorzaken.DataSetName = "TDSOorzaken"
        Me._dataOorzaken.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataOorzaken.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridnterventieartikelen
        '
        Me.UltraGridnterventieartikelen.DataSource = Me._dataIntvArt
        Appearance171.BackColor = System.Drawing.SystemColors.Window
        Appearance171.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridnterventieartikelen.DisplayLayout.Appearance = Appearance171
        Me.UltraGridnterventieartikelen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn21.Header.Caption = "Eenheid"
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn21.Width = 33
        UltraGridColumn22.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn22.Header.Caption = "Artikelgroep"
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn22.Width = 64
        UltraGridColumn23.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn23.Header.Caption = "Omschrijving"
        UltraGridColumn23.Header.VisiblePosition = 3
        UltraGridColumn23.Width = 104
        UltraGridColumn24.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn24.Header.Caption = "Prijs"
        UltraGridColumn24.Header.VisiblePosition = 4
        UltraGridColumn24.Width = 83
        UltraGridColumn25.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn25.Header.Caption = "Intv.voertuig"
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.Width = 39
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.UltraGridnterventieartikelen.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.UltraGridnterventieartikelen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridnterventieartikelen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance172.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance172.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance172.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance172.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridnterventieartikelen.DisplayLayout.GroupByBox.Appearance = Appearance172
        Appearance173.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridnterventieartikelen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance173
        Me.UltraGridnterventieartikelen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridnterventieartikelen.DisplayLayout.GroupByBox.Hidden = True
        Appearance174.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance174.BackColor2 = System.Drawing.SystemColors.Control
        Appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance174.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridnterventieartikelen.DisplayLayout.GroupByBox.PromptAppearance = Appearance174
        Me.UltraGridnterventieartikelen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridnterventieartikelen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance175.BackColor = System.Drawing.SystemColors.Window
        Appearance175.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.ActiveCellAppearance = Appearance175
        Appearance176.BackColor = System.Drawing.SystemColors.Highlight
        Appearance176.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.ActiveRowAppearance = Appearance176
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance177.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.CardAreaAppearance = Appearance177
        Appearance178.BorderColor = System.Drawing.Color.Silver
        Appearance178.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.CellAppearance = Appearance178
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance179.BackColor = System.Drawing.SystemColors.Control
        Appearance179.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance179.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance179.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.GroupByRowAppearance = Appearance179
        Appearance180.TextHAlignAsString = "Left"
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.HeaderAppearance = Appearance180
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance181.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.RowAlternateAppearance = Appearance181
        Appearance182.BackColor = System.Drawing.SystemColors.Window
        Appearance182.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.RowAppearance = Appearance182
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance183.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridnterventieartikelen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance183
        Me.UltraGridnterventieartikelen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridnterventieartikelen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridnterventieartikelen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridnterventieartikelen.Location = New System.Drawing.Point(392, 440)
        Me.UltraGridnterventieartikelen.Name = "UltraGridnterventieartikelen"
        Me.UltraGridnterventieartikelen.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridnterventieartikelen.TabIndex = 37
        Me.UltraGridnterventieartikelen.Text = "UltraGrid1"
        Me.UltraGridnterventieartikelen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataIntvArt
        '
        Me._dataIntvArt.DataSetName = "TDSIntvArt"
        Me._dataIntvArt.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIntvArt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridPersoneel
        '
        Me.UltraGridPersoneel.DataSource = Me._dataBBBWPERS
        Appearance184.BackColor = System.Drawing.SystemColors.Window
        Appearance184.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridPersoneel.DisplayLayout.Appearance = Appearance184
        Me.UltraGridPersoneel.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn67.Header.Caption = "Stamnummer"
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Width = 137
        UltraGridColumn68.Header.Caption = "Ploegnr. Ind."
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Width = 253
        UltraGridColumn69.Header.Caption = "Brandweerman"
        UltraGridColumn69.Header.VisiblePosition = 2
        UltraGridColumn69.Width = 160
        UltraGridColumn70.Header.Caption = "Bewaker"
        UltraGridColumn70.Header.VisiblePosition = 3
        UltraGridColumn70.Width = 141
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70})
        Me.UltraGridPersoneel.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.UltraGridPersoneel.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridPersoneel.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance185.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance185.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance185.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridPersoneel.DisplayLayout.GroupByBox.Appearance = Appearance185
        Appearance186.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridPersoneel.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance186
        Me.UltraGridPersoneel.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridPersoneel.DisplayLayout.GroupByBox.Hidden = True
        Appearance187.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance187.BackColor2 = System.Drawing.SystemColors.Control
        Appearance187.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance187.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridPersoneel.DisplayLayout.GroupByBox.PromptAppearance = Appearance187
        Me.UltraGridPersoneel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridPersoneel.DisplayLayout.MaxRowScrollRegions = 1
        Appearance188.BackColor = System.Drawing.SystemColors.Window
        Appearance188.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridPersoneel.DisplayLayout.Override.ActiveCellAppearance = Appearance188
        Appearance189.BackColor = System.Drawing.SystemColors.Highlight
        Appearance189.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridPersoneel.DisplayLayout.Override.ActiveRowAppearance = Appearance189
        Me.UltraGridPersoneel.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridPersoneel.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridPersoneel.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridPersoneel.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridPersoneel.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance190.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridPersoneel.DisplayLayout.Override.CardAreaAppearance = Appearance190
        Appearance191.BorderColor = System.Drawing.Color.Silver
        Appearance191.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridPersoneel.DisplayLayout.Override.CellAppearance = Appearance191
        Me.UltraGridPersoneel.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridPersoneel.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridPersoneel.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance192.BackColor = System.Drawing.SystemColors.Control
        Appearance192.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance192.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance192.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridPersoneel.DisplayLayout.Override.GroupByRowAppearance = Appearance192
        Appearance193.TextHAlignAsString = "Left"
        Me.UltraGridPersoneel.DisplayLayout.Override.HeaderAppearance = Appearance193
        Me.UltraGridPersoneel.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridPersoneel.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance194.BackColor = System.Drawing.SystemColors.Window
        Appearance194.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridPersoneel.DisplayLayout.Override.RowAppearance = Appearance194
        Me.UltraGridPersoneel.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance195.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridPersoneel.DisplayLayout.Override.TemplateAddRowAppearance = Appearance195
        Me.UltraGridPersoneel.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridPersoneel.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridPersoneel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridPersoneel.Location = New System.Drawing.Point(16, 560)
        Me.UltraGridPersoneel.Name = "UltraGridPersoneel"
        Me.UltraGridPersoneel.Size = New System.Drawing.Size(728, 80)
        Me.UltraGridPersoneel.TabIndex = 43
        Me.UltraGridPersoneel.Text = "Firma's"
        '
        '_dataBBBWPERS
        '
        Me._dataBBBWPERS.DataSetName = "TDSBBBWPERS"
        Me._dataBBBWPERS.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataBBBWPERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridDagverslagInlichtingType
        '
        Me.UltraGridDagverslagInlichtingType.DataSource = Me._dataDagverslagInlichtingType
        Appearance196.BackColor = System.Drawing.SystemColors.Window
        Appearance196.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Appearance = Appearance196
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn71.Header.VisiblePosition = 0
        UltraGridColumn71.Width = 91
        UltraGridColumn72.Header.VisiblePosition = 1
        UltraGridColumn72.Width = 103
        UltraGridColumn73.Header.VisiblePosition = 2
        UltraGridColumn73.Width = 60
        UltraGridColumn74.Header.VisiblePosition = 3
        UltraGridColumn74.Width = 53
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74})
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance197.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance197.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance197.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.GroupByBox.Appearance = Appearance197
        Appearance198.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance198
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.GroupByBox.Hidden = True
        Appearance199.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance199.BackColor2 = System.Drawing.SystemColors.Control
        Appearance199.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance199.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.GroupByBox.PromptAppearance = Appearance199
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance200.BackColor = System.Drawing.SystemColors.Window
        Appearance200.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.ActiveCellAppearance = Appearance200
        Appearance201.BackColor = System.Drawing.SystemColors.Highlight
        Appearance201.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.ActiveRowAppearance = Appearance201
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance202.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.CardAreaAppearance = Appearance202
        Appearance203.BorderColor = System.Drawing.Color.Silver
        Appearance203.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.CellAppearance = Appearance203
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance204.BackColor = System.Drawing.SystemColors.Control
        Appearance204.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance204.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance204.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.GroupByRowAppearance = Appearance204
        Appearance205.TextHAlignAsString = "Left"
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.HeaderAppearance = Appearance205
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance206.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.RowAlternateAppearance = Appearance206
        Appearance207.BackColor = System.Drawing.SystemColors.Window
        Appearance207.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.RowAppearance = Appearance207
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance208.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance208
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridDagverslagInlichtingType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridDagverslagInlichtingType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridDagverslagInlichtingType.Location = New System.Drawing.Point(392, 296)
        Me.UltraGridDagverslagInlichtingType.Name = "UltraGridDagverslagInlichtingType"
        Me.UltraGridDagverslagInlichtingType.Size = New System.Drawing.Size(344, 80)
        Me.UltraGridDagverslagInlichtingType.TabIndex = 42
        Me.UltraGridDagverslagInlichtingType.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataDagverslagInlichtingType
        '
        Me._dataDagverslagInlichtingType.DataSetName = "TDSDagverslagInlichtingType"
        Me._dataDagverslagInlichtingType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataDagverslagInlichtingType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ultraGridDagverslagRegistratyType
        '
        Me.ultraGridDagverslagRegistratyType.DataSource = Me._dataDagverslagRegistratieType
        Appearance209.BackColor = System.Drawing.SystemColors.Window
        Appearance209.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Appearance = Appearance209
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn75.Header.Caption = "ID"
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Width = 283
        UltraGridColumn76.Header.Caption = "Omschrijving"
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn76.Width = 307
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn75, UltraGridColumn76})
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance210.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance210.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance210.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance210.BorderColor = System.Drawing.SystemColors.Window
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.GroupByBox.Appearance = Appearance210
        Appearance211.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance211
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.GroupByBox.Hidden = True
        Appearance212.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance212.BackColor2 = System.Drawing.SystemColors.Control
        Appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance212.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.GroupByBox.PromptAppearance = Appearance212
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.MaxColScrollRegions = 1
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance213.BackColor = System.Drawing.SystemColors.Window
        Appearance213.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.ActiveCellAppearance = Appearance213
        Appearance214.BackColor = System.Drawing.SystemColors.Highlight
        Appearance214.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.ActiveRowAppearance = Appearance214
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance215.BackColor = System.Drawing.SystemColors.Window
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.CardAreaAppearance = Appearance215
        Appearance216.BorderColor = System.Drawing.Color.Silver
        Appearance216.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.CellAppearance = Appearance216
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.CellPadding = 0
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance217.BackColor = System.Drawing.SystemColors.Control
        Appearance217.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance217.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance217.BorderColor = System.Drawing.SystemColors.Window
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.GroupByRowAppearance = Appearance217
        Appearance218.TextHAlignAsString = "Left"
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.HeaderAppearance = Appearance218
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance219.BackColor = System.Drawing.SystemColors.Info
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.RowAlternateAppearance = Appearance219
        Appearance220.BackColor = System.Drawing.SystemColors.Window
        Appearance220.BorderColor = System.Drawing.Color.Silver
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.RowAppearance = Appearance220
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance221.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance221
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ultraGridDagverslagRegistratyType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ultraGridDagverslagRegistratyType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ultraGridDagverslagRegistratyType.Location = New System.Drawing.Point(230, 368)
        Me.ultraGridDagverslagRegistratyType.Name = "ultraGridDagverslagRegistratyType"
        Me.ultraGridDagverslagRegistratyType.Size = New System.Drawing.Size(344, 80)
        Me.ultraGridDagverslagRegistratyType.TabIndex = 41
        Me.ultraGridDagverslagRegistratyType.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataDagverslagRegistratieType
        '
        Me._dataDagverslagRegistratieType.DataSetName = "TDSDagverslagRegistratieType"
        Me._dataDagverslagRegistratieType.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataDagverslagRegistratieType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridVerzekeringFirmas
        '
        Me.UltraGridVerzekeringFirmas.DataSource = Me._dataVerzFirmas.BBVZKFRM
        Appearance222.BackColor = System.Drawing.SystemColors.Window
        Appearance222.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Appearance = Appearance222
        Me.UltraGridVerzekeringFirmas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn77.Header.VisiblePosition = 0
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.Width = 77
        UltraGridColumn78.Header.Caption = "Naam"
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridColumn78.Width = 223
        UltraGridColumn79.Header.Caption = "Adres"
        UltraGridColumn79.Header.VisiblePosition = 2
        UltraGridColumn79.Width = 218
        UltraGridColumn80.Header.Caption = "Plaats"
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Width = 242
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80})
        Me.UltraGridVerzekeringFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Me.UltraGridVerzekeringFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVerzekeringFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance223.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance223.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance223.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance223.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzekeringFirmas.DisplayLayout.GroupByBox.Appearance = Appearance223
        Appearance224.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVerzekeringFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance224
        Me.UltraGridVerzekeringFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVerzekeringFirmas.DisplayLayout.GroupByBox.Hidden = True
        Appearance225.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance225.BackColor2 = System.Drawing.SystemColors.Control
        Appearance225.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance225.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVerzekeringFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance225
        Me.UltraGridVerzekeringFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridVerzekeringFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance226.BackColor = System.Drawing.SystemColors.Window
        Appearance226.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance226
        Appearance227.BackColor = System.Drawing.SystemColors.Highlight
        Appearance227.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance227
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance228.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance228
        Appearance229.BorderColor = System.Drawing.Color.Silver
        Appearance229.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.CellAppearance = Appearance229
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance230.BackColor = System.Drawing.SystemColors.Control
        Appearance230.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance230.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance230.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance230.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance230
        Appearance231.TextHAlignAsString = "Left"
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.HeaderAppearance = Appearance231
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance232.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.RowAlternateAppearance = Appearance232
        Appearance233.BackColor = System.Drawing.SystemColors.Window
        Appearance233.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.RowAppearance = Appearance233
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance234.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridVerzekeringFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance234
        Me.UltraGridVerzekeringFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridVerzekeringFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridVerzekeringFirmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridVerzekeringFirmas.Location = New System.Drawing.Point(16, 360)
        Me.UltraGridVerzekeringFirmas.Name = "UltraGridVerzekeringFirmas"
        Me.UltraGridVerzekeringFirmas.Size = New System.Drawing.Size(720, 80)
        Me.UltraGridVerzekeringFirmas.TabIndex = 40
        Me.UltraGridVerzekeringFirmas.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataVerzFirmas
        '
        Me._dataVerzFirmas.DataSetName = "TDSVerzFirmas"
        Me._dataVerzFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataVerzFirmas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridFirmas
        '
        Me.UltraGridFirmas.DataSource = Me._dataFirmas
        Appearance235.BackColor = System.Drawing.SystemColors.Window
        Appearance235.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridFirmas.DisplayLayout.Appearance = Appearance235
        Me.UltraGridFirmas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn81.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.Width = 48
        UltraGridColumn82.Header.Caption = "Firma"
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridColumn82.Width = 126
        UltraGridColumn83.Header.Caption = "Straat"
        UltraGridColumn83.Header.VisiblePosition = 2
        UltraGridColumn83.Width = 129
        UltraGridColumn84.Header.Caption = "Postcode"
        UltraGridColumn84.Header.VisiblePosition = 3
        UltraGridColumn84.Width = 136
        UltraGridColumn85.Header.Caption = "Plaats"
        UltraGridColumn85.Header.VisiblePosition = 4
        UltraGridColumn85.Width = 137
        UltraGridColumn86.Header.VisiblePosition = 5
        UltraGridColumn86.Width = 95
        UltraGridColumn87.Header.VisiblePosition = 6
        UltraGridColumn87.Width = 76
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        Me.UltraGridFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Me.UltraGridFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance236.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance236.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance236.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance236.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.Appearance = Appearance236
        Appearance237.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance237
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.Hidden = True
        Appearance238.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance238.BackColor2 = System.Drawing.SystemColors.Control
        Appearance238.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance238.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance238
        Me.UltraGridFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance239.BackColor = System.Drawing.SystemColors.Window
        Appearance239.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance239
        Appearance240.BackColor = System.Drawing.SystemColors.Highlight
        Appearance240.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance240
        Me.UltraGridFirmas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridFirmas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance241.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance241
        Appearance242.BorderColor = System.Drawing.Color.Silver
        Appearance242.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridFirmas.DisplayLayout.Override.CellAppearance = Appearance242
        Me.UltraGridFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridFirmas.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridFirmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance243.BackColor = System.Drawing.SystemColors.Control
        Appearance243.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance243.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance243.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance243.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance243
        Appearance244.TextHAlignAsString = "Left"
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderAppearance = Appearance244
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance245.BackColor = System.Drawing.SystemColors.Window
        Appearance245.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridFirmas.DisplayLayout.Override.RowAppearance = Appearance245
        Me.UltraGridFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance246.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance246
        Me.UltraGridFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridFirmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridFirmas.Location = New System.Drawing.Point(8, 504)
        Me.UltraGridFirmas.Name = "UltraGridFirmas"
        Me.UltraGridFirmas.Size = New System.Drawing.Size(736, 64)
        Me.UltraGridFirmas.TabIndex = 39
        Me.UltraGridFirmas.Text = "Firma's"
        '
        '_dataFirmas
        '
        Me._dataFirmas.DataSetName = "TDSFirmas"
        Me._dataFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataFirmas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraButtonAfdrukken
        '
        Appearance247.Image = CType(resources.GetObject("Appearance247.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance247
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(440, 640)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonOpslaan
        '
        Appearance248.Image = CType(resources.GetObject("Appearance248.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance248
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(536, 640)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 2
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'UltraGridWerfvoertuig
        '
        Me.UltraGridWerfvoertuig.DataSource = Me._dataWerfVoertuig.BBWRFTSP
        Appearance249.BackColor = System.Drawing.SystemColors.Window
        Appearance249.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridWerfvoertuig.DisplayLayout.Appearance = Appearance249
        Me.UltraGridWerfvoertuig.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn88.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Hidden = True
        UltraGridColumn88.Width = 462
        UltraGridColumn89.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn89.Header.Caption = "Werfvoertuig"
        UltraGridColumn89.Header.VisiblePosition = 1
        UltraGridColumn89.Width = 323
        UltraGridBand20.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89})
        Me.UltraGridWerfvoertuig.DisplayLayout.BandsSerializer.Add(UltraGridBand20)
        Me.UltraGridWerfvoertuig.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridWerfvoertuig.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance250.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance250.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance250.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridWerfvoertuig.DisplayLayout.GroupByBox.Appearance = Appearance250
        Appearance251.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridWerfvoertuig.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance251
        Me.UltraGridWerfvoertuig.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridWerfvoertuig.DisplayLayout.GroupByBox.Hidden = True
        Appearance252.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance252.BackColor2 = System.Drawing.SystemColors.Control
        Appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance252.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridWerfvoertuig.DisplayLayout.GroupByBox.PromptAppearance = Appearance252
        Me.UltraGridWerfvoertuig.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridWerfvoertuig.DisplayLayout.MaxRowScrollRegions = 1
        Appearance253.BackColor = System.Drawing.SystemColors.Window
        Appearance253.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.ActiveCellAppearance = Appearance253
        Appearance254.BackColor = System.Drawing.SystemColors.Highlight
        Appearance254.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.ActiveRowAppearance = Appearance254
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance255.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.CardAreaAppearance = Appearance255
        Appearance256.BorderColor = System.Drawing.Color.Silver
        Appearance256.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.CellAppearance = Appearance256
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance257.BackColor = System.Drawing.SystemColors.Control
        Appearance257.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance257.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance257.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance257.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.GroupByRowAppearance = Appearance257
        Appearance258.TextHAlignAsString = "Left"
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.HeaderAppearance = Appearance258
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance259.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.RowAlternateAppearance = Appearance259
        Appearance260.BackColor = System.Drawing.SystemColors.Window
        Appearance260.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.RowAppearance = Appearance260
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance261.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridWerfvoertuig.DisplayLayout.Override.TemplateAddRowAppearance = Appearance261
        Me.UltraGridWerfvoertuig.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridWerfvoertuig.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridWerfvoertuig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridWerfvoertuig.Location = New System.Drawing.Point(144, 344)
        Me.UltraGridWerfvoertuig.Name = "UltraGridWerfvoertuig"
        Me.UltraGridWerfvoertuig.Size = New System.Drawing.Size(360, 48)
        Me.UltraGridWerfvoertuig.TabIndex = 17
        Me.UltraGridWerfvoertuig.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataWerfVoertuig
        '
        Me._dataWerfVoertuig.DataSetName = "TDSWerfVoertuig"
        Me._dataWerfVoertuig.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataWerfVoertuig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridGebruikVoertuig
        '
        Me.UltraGridGebruikVoertuig.DataSource = Me._dataGebruikVoertuig.BBBRKTSP
        Appearance262.BackColor = System.Drawing.SystemColors.Window
        Appearance262.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridGebruikVoertuig.DisplayLayout.Appearance = Appearance262
        Me.UltraGridGebruikVoertuig.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn90.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn90.Header.VisiblePosition = 0
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Width = 459
        UltraGridColumn91.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn91.Header.Caption = "Gebruik Voertuig"
        UltraGridColumn91.Header.VisiblePosition = 1
        UltraGridColumn91.Width = 323
        UltraGridBand21.Columns.AddRange(New Object() {UltraGridColumn90, UltraGridColumn91})
        Me.UltraGridGebruikVoertuig.DisplayLayout.BandsSerializer.Add(UltraGridBand21)
        Me.UltraGridGebruikVoertuig.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridGebruikVoertuig.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance263.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance263.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance263.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance263.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridGebruikVoertuig.DisplayLayout.GroupByBox.Appearance = Appearance263
        Appearance264.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridGebruikVoertuig.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance264
        Me.UltraGridGebruikVoertuig.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridGebruikVoertuig.DisplayLayout.GroupByBox.Hidden = True
        Appearance265.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance265.BackColor2 = System.Drawing.SystemColors.Control
        Appearance265.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance265.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridGebruikVoertuig.DisplayLayout.GroupByBox.PromptAppearance = Appearance265
        Me.UltraGridGebruikVoertuig.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridGebruikVoertuig.DisplayLayout.MaxRowScrollRegions = 1
        Appearance266.BackColor = System.Drawing.SystemColors.Window
        Appearance266.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.ActiveCellAppearance = Appearance266
        Appearance267.BackColor = System.Drawing.SystemColors.Highlight
        Appearance267.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.ActiveRowAppearance = Appearance267
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance268.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.CardAreaAppearance = Appearance268
        Appearance269.BorderColor = System.Drawing.Color.Silver
        Appearance269.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.CellAppearance = Appearance269
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance270.BackColor = System.Drawing.SystemColors.Control
        Appearance270.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance270.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance270.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance270.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.GroupByRowAppearance = Appearance270
        Appearance271.TextHAlignAsString = "Left"
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.HeaderAppearance = Appearance271
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance272.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.RowAlternateAppearance = Appearance272
        Appearance273.BackColor = System.Drawing.SystemColors.Window
        Appearance273.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.RowAppearance = Appearance273
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance274.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridGebruikVoertuig.DisplayLayout.Override.TemplateAddRowAppearance = Appearance274
        Me.UltraGridGebruikVoertuig.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridGebruikVoertuig.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridGebruikVoertuig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridGebruikVoertuig.Location = New System.Drawing.Point(16, 440)
        Me.UltraGridGebruikVoertuig.Name = "UltraGridGebruikVoertuig"
        Me.UltraGridGebruikVoertuig.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridGebruikVoertuig.TabIndex = 16
        Me.UltraGridGebruikVoertuig.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataGebruikVoertuig
        '
        Me._dataGebruikVoertuig.DataSetName = "TDSGebruikVoertuig"
        Me._dataGebruikVoertuig.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataGebruikVoertuig.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridSchadeAan
        '
        Me.UltraGridSchadeAan.DataSource = Me._dataScadObjecten.BBSCADAN
        Appearance275.BackColor = System.Drawing.SystemColors.Window
        Appearance275.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridSchadeAan.DisplayLayout.Appearance = Appearance275
        Me.UltraGridSchadeAan.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn92.Header.VisiblePosition = 0
        UltraGridColumn92.Width = 155
        UltraGridColumn93.Header.VisiblePosition = 1
        UltraGridColumn93.Width = 168
        UltraGridBand22.Columns.AddRange(New Object() {UltraGridColumn92, UltraGridColumn93})
        Me.UltraGridSchadeAan.DisplayLayout.BandsSerializer.Add(UltraGridBand22)
        Me.UltraGridSchadeAan.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridSchadeAan.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance276.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance276.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance276.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance276.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridSchadeAan.DisplayLayout.GroupByBox.Appearance = Appearance276
        Appearance277.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridSchadeAan.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance277
        Me.UltraGridSchadeAan.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridSchadeAan.DisplayLayout.GroupByBox.Hidden = True
        Appearance278.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance278.BackColor2 = System.Drawing.SystemColors.Control
        Appearance278.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance278.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridSchadeAan.DisplayLayout.GroupByBox.PromptAppearance = Appearance278
        Me.UltraGridSchadeAan.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridSchadeAan.DisplayLayout.MaxRowScrollRegions = 1
        Appearance279.BackColor = System.Drawing.SystemColors.Window
        Appearance279.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridSchadeAan.DisplayLayout.Override.ActiveCellAppearance = Appearance279
        Appearance280.BackColor = System.Drawing.SystemColors.Highlight
        Appearance280.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridSchadeAan.DisplayLayout.Override.ActiveRowAppearance = Appearance280
        Me.UltraGridSchadeAan.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridSchadeAan.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridSchadeAan.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridSchadeAan.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridSchadeAan.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridSchadeAan.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance281.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridSchadeAan.DisplayLayout.Override.CardAreaAppearance = Appearance281
        Appearance282.BorderColor = System.Drawing.Color.Silver
        Appearance282.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridSchadeAan.DisplayLayout.Override.CellAppearance = Appearance282
        Me.UltraGridSchadeAan.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridSchadeAan.DisplayLayout.Override.CellPadding = 0
        Appearance283.BackColor = System.Drawing.SystemColors.Control
        Appearance283.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance283.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance283.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance283.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridSchadeAan.DisplayLayout.Override.GroupByRowAppearance = Appearance283
        Appearance284.TextHAlignAsString = "Left"
        Me.UltraGridSchadeAan.DisplayLayout.Override.HeaderAppearance = Appearance284
        Me.UltraGridSchadeAan.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridSchadeAan.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance285.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridSchadeAan.DisplayLayout.Override.RowAlternateAppearance = Appearance285
        Appearance286.BackColor = System.Drawing.SystemColors.Window
        Appearance286.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridSchadeAan.DisplayLayout.Override.RowAppearance = Appearance286
        Me.UltraGridSchadeAan.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridSchadeAan.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance287.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridSchadeAan.DisplayLayout.Override.TemplateAddRowAppearance = Appearance287
        Me.UltraGridSchadeAan.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridSchadeAan.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridSchadeAan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSchadeAan.Location = New System.Drawing.Point(16, 360)
        Me.UltraGridSchadeAan.Name = "UltraGridSchadeAan"
        Me.UltraGridSchadeAan.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridSchadeAan.TabIndex = 15
        Me.UltraGridSchadeAan.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataScadObjecten
        '
        Me._dataScadObjecten.DataSetName = "TDSScadObjecten"
        Me._dataScadObjecten.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataScadObjecten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridPloeg
        '
        Me.UltraGridPloeg.DataSource = Me._dataPloeg.BBBWPLG
        Appearance288.BackColor = System.Drawing.SystemColors.Window
        Appearance288.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridPloeg.DisplayLayout.Appearance = Appearance288
        Me.UltraGridPloeg.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn94.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn94.Header.VisiblePosition = 0
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.Width = 458
        UltraGridColumn95.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn95.Header.Caption = "Ploeg"
        UltraGridColumn95.Header.VisiblePosition = 1
        UltraGridColumn95.Width = 323
        UltraGridBand23.Columns.AddRange(New Object() {UltraGridColumn94, UltraGridColumn95})
        Me.UltraGridPloeg.DisplayLayout.BandsSerializer.Add(UltraGridBand23)
        Me.UltraGridPloeg.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridPloeg.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance289.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance289.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance289.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance289.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridPloeg.DisplayLayout.GroupByBox.Appearance = Appearance289
        Appearance290.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridPloeg.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance290
        Me.UltraGridPloeg.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridPloeg.DisplayLayout.GroupByBox.Hidden = True
        Appearance291.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance291.BackColor2 = System.Drawing.SystemColors.Control
        Appearance291.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance291.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridPloeg.DisplayLayout.GroupByBox.PromptAppearance = Appearance291
        Me.UltraGridPloeg.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridPloeg.DisplayLayout.MaxRowScrollRegions = 1
        Appearance292.BackColor = System.Drawing.SystemColors.Window
        Appearance292.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridPloeg.DisplayLayout.Override.ActiveCellAppearance = Appearance292
        Appearance293.BackColor = System.Drawing.SystemColors.Highlight
        Appearance293.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridPloeg.DisplayLayout.Override.ActiveRowAppearance = Appearance293
        Me.UltraGridPloeg.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridPloeg.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridPloeg.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridPloeg.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridPloeg.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridPloeg.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance294.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridPloeg.DisplayLayout.Override.CardAreaAppearance = Appearance294
        Appearance295.BorderColor = System.Drawing.Color.Silver
        Appearance295.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridPloeg.DisplayLayout.Override.CellAppearance = Appearance295
        Me.UltraGridPloeg.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridPloeg.DisplayLayout.Override.CellPadding = 0
        Appearance296.BackColor = System.Drawing.SystemColors.Control
        Appearance296.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance296.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance296.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance296.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridPloeg.DisplayLayout.Override.GroupByRowAppearance = Appearance296
        Appearance297.TextHAlignAsString = "Left"
        Me.UltraGridPloeg.DisplayLayout.Override.HeaderAppearance = Appearance297
        Me.UltraGridPloeg.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridPloeg.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance298.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridPloeg.DisplayLayout.Override.RowAlternateAppearance = Appearance298
        Appearance299.BackColor = System.Drawing.SystemColors.Window
        Appearance299.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridPloeg.DisplayLayout.Override.RowAppearance = Appearance299
        Me.UltraGridPloeg.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridPloeg.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance300.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridPloeg.DisplayLayout.Override.TemplateAddRowAppearance = Appearance300
        Me.UltraGridPloeg.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridPloeg.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridPloeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridPloeg.Location = New System.Drawing.Point(16, 336)
        Me.UltraGridPloeg.Name = "UltraGridPloeg"
        Me.UltraGridPloeg.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridPloeg.TabIndex = 14
        Me.UltraGridPloeg.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataPloeg
        '
        Me._dataPloeg.DataSetName = "TDSPloeg"
        Me._dataPloeg.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataPloeg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridAanspreektitel
        '
        Me.UltraGridAanspreektitel.DataSource = Me._dataAanspreektitel.BBINDGSL
        Appearance301.BackColor = System.Drawing.SystemColors.Window
        Appearance301.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridAanspreektitel.DisplayLayout.Appearance = Appearance301
        Me.UltraGridAanspreektitel.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn96.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn96.Hidden = True
        UltraGridColumn96.Width = 397
        UltraGridColumn97.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn97.Header.Caption = "Aanspreektitel"
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn97.Width = 323
        UltraGridBand24.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn97})
        Me.UltraGridAanspreektitel.DisplayLayout.BandsSerializer.Add(UltraGridBand24)
        Me.UltraGridAanspreektitel.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAanspreektitel.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance302.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance302.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance302.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance302.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAanspreektitel.DisplayLayout.GroupByBox.Appearance = Appearance302
        Appearance303.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAanspreektitel.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance303
        Me.UltraGridAanspreektitel.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridAanspreektitel.DisplayLayout.GroupByBox.Hidden = True
        Appearance304.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance304.BackColor2 = System.Drawing.SystemColors.Control
        Appearance304.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance304.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridAanspreektitel.DisplayLayout.GroupByBox.PromptAppearance = Appearance304
        Me.UltraGridAanspreektitel.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridAanspreektitel.DisplayLayout.MaxRowScrollRegions = 1
        Appearance305.BackColor = System.Drawing.SystemColors.Window
        Appearance305.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridAanspreektitel.DisplayLayout.Override.ActiveCellAppearance = Appearance305
        Appearance306.BackColor = System.Drawing.SystemColors.Highlight
        Appearance306.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridAanspreektitel.DisplayLayout.Override.ActiveRowAppearance = Appearance306
        Me.UltraGridAanspreektitel.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridAanspreektitel.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAanspreektitel.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridAanspreektitel.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAanspreektitel.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridAanspreektitel.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance307.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridAanspreektitel.DisplayLayout.Override.CardAreaAppearance = Appearance307
        Appearance308.BorderColor = System.Drawing.Color.Silver
        Appearance308.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridAanspreektitel.DisplayLayout.Override.CellAppearance = Appearance308
        Me.UltraGridAanspreektitel.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridAanspreektitel.DisplayLayout.Override.CellPadding = 0
        Appearance309.BackColor = System.Drawing.SystemColors.Control
        Appearance309.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance309.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance309.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance309.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridAanspreektitel.DisplayLayout.Override.GroupByRowAppearance = Appearance309
        Appearance310.TextHAlignAsString = "Left"
        Me.UltraGridAanspreektitel.DisplayLayout.Override.HeaderAppearance = Appearance310
        Me.UltraGridAanspreektitel.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridAanspreektitel.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance311.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridAanspreektitel.DisplayLayout.Override.RowAlternateAppearance = Appearance311
        Appearance312.BackColor = System.Drawing.SystemColors.Window
        Appearance312.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridAanspreektitel.DisplayLayout.Override.RowAppearance = Appearance312
        Me.UltraGridAanspreektitel.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridAanspreektitel.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance313.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridAanspreektitel.DisplayLayout.Override.TemplateAddRowAppearance = Appearance313
        Me.UltraGridAanspreektitel.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridAanspreektitel.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridAanspreektitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAanspreektitel.Location = New System.Drawing.Point(16, 312)
        Me.UltraGridAanspreektitel.Name = "UltraGridAanspreektitel"
        Me.UltraGridAanspreektitel.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridAanspreektitel.TabIndex = 13
        Me.UltraGridAanspreektitel.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataAanspreektitel
        '
        Me._dataAanspreektitel.DataSetName = "TDSAanspreektitel"
        Me._dataAanspreektitel.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataAanspreektitel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridVoertuigType
        '
        Me.UltraGridVoertuigType.DataSource = Me._dataVoertuigTypes.BBTYTSP
        Appearance314.BackColor = System.Drawing.SystemColors.Window
        Appearance314.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridVoertuigType.DisplayLayout.Appearance = Appearance314
        Me.UltraGridVoertuigType.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn98.Header.VisiblePosition = 0
        UltraGridColumn98.Width = 154
        UltraGridColumn99.Header.VisiblePosition = 1
        UltraGridColumn99.Width = 169
        UltraGridBand25.Columns.AddRange(New Object() {UltraGridColumn98, UltraGridColumn99})
        Me.UltraGridVoertuigType.DisplayLayout.BandsSerializer.Add(UltraGridBand25)
        Me.UltraGridVoertuigType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVoertuigType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance315.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance315.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance315.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance315.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigType.DisplayLayout.GroupByBox.Appearance = Appearance315
        Appearance316.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVoertuigType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance316
        Me.UltraGridVoertuigType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVoertuigType.DisplayLayout.GroupByBox.Hidden = True
        Appearance317.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance317.BackColor2 = System.Drawing.SystemColors.Control
        Appearance317.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance317.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVoertuigType.DisplayLayout.GroupByBox.PromptAppearance = Appearance317
        Me.UltraGridVoertuigType.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridVoertuigType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance318.BackColor = System.Drawing.SystemColors.Window
        Appearance318.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridVoertuigType.DisplayLayout.Override.ActiveCellAppearance = Appearance318
        Appearance319.BackColor = System.Drawing.SystemColors.Highlight
        Appearance319.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridVoertuigType.DisplayLayout.Override.ActiveRowAppearance = Appearance319
        Me.UltraGridVoertuigType.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridVoertuigType.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVoertuigType.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridVoertuigType.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVoertuigType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridVoertuigType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance320.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigType.DisplayLayout.Override.CardAreaAppearance = Appearance320
        Appearance321.BorderColor = System.Drawing.Color.Silver
        Appearance321.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridVoertuigType.DisplayLayout.Override.CellAppearance = Appearance321
        Me.UltraGridVoertuigType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridVoertuigType.DisplayLayout.Override.CellPadding = 0
        Appearance322.BackColor = System.Drawing.SystemColors.Control
        Appearance322.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance322.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance322.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance322.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVoertuigType.DisplayLayout.Override.GroupByRowAppearance = Appearance322
        Appearance323.TextHAlignAsString = "Left"
        Me.UltraGridVoertuigType.DisplayLayout.Override.HeaderAppearance = Appearance323
        Me.UltraGridVoertuigType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridVoertuigType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance324.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridVoertuigType.DisplayLayout.Override.RowAlternateAppearance = Appearance324
        Appearance325.BackColor = System.Drawing.SystemColors.Window
        Appearance325.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridVoertuigType.DisplayLayout.Override.RowAppearance = Appearance325
        Me.UltraGridVoertuigType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridVoertuigType.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance326.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridVoertuigType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance326
        Me.UltraGridVoertuigType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridVoertuigType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridVoertuigType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridVoertuigType.Location = New System.Drawing.Point(16, 288)
        Me.UltraGridVoertuigType.Name = "UltraGridVoertuigType"
        Me.UltraGridVoertuigType.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridVoertuigType.TabIndex = 12
        Me.UltraGridVoertuigType.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataVoertuigTypes
        '
        Me._dataVoertuigTypes.DataSetName = "TDSVoertuigTypes"
        Me._dataVoertuigTypes.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataVoertuigTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridTypeBetrokkenen
        '
        Me.UltraGridTypeBetrokkenen.DataMember = "BBTYBTRK"
        Me.UltraGridTypeBetrokkenen.DataSource = Me._dataTypeBetrokkene
        Appearance327.BackColor = System.Drawing.SystemColors.Window
        Appearance327.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Appearance = Appearance327
        Me.UltraGridTypeBetrokkenen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.Width = 154
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.Width = 169
        UltraGridBand26.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101})
        Me.UltraGridTypeBetrokkenen.DisplayLayout.BandsSerializer.Add(UltraGridBand26)
        Me.UltraGridTypeBetrokkenen.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridTypeBetrokkenen.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance328.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance328.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance328.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance328.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridTypeBetrokkenen.DisplayLayout.GroupByBox.Appearance = Appearance328
        Appearance329.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridTypeBetrokkenen.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance329
        Me.UltraGridTypeBetrokkenen.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridTypeBetrokkenen.DisplayLayout.GroupByBox.Hidden = True
        Appearance330.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance330.BackColor2 = System.Drawing.SystemColors.Control
        Appearance330.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance330.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridTypeBetrokkenen.DisplayLayout.GroupByBox.PromptAppearance = Appearance330
        Me.UltraGridTypeBetrokkenen.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridTypeBetrokkenen.DisplayLayout.MaxRowScrollRegions = 1
        Appearance331.BackColor = System.Drawing.SystemColors.Window
        Appearance331.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.ActiveCellAppearance = Appearance331
        Appearance332.BackColor = System.Drawing.SystemColors.Highlight
        Appearance332.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.ActiveRowAppearance = Appearance332
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance333.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.CardAreaAppearance = Appearance333
        Appearance334.BorderColor = System.Drawing.Color.Silver
        Appearance334.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.CellAppearance = Appearance334
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.CellPadding = 0
        Appearance335.BackColor = System.Drawing.SystemColors.Control
        Appearance335.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance335.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance335.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance335.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.GroupByRowAppearance = Appearance335
        Appearance336.TextHAlignAsString = "Left"
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.HeaderAppearance = Appearance336
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance337.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.RowAlternateAppearance = Appearance337
        Appearance338.BackColor = System.Drawing.SystemColors.Window
        Appearance338.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.RowAppearance = Appearance338
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance339.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridTypeBetrokkenen.DisplayLayout.Override.TemplateAddRowAppearance = Appearance339
        Me.UltraGridTypeBetrokkenen.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridTypeBetrokkenen.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridTypeBetrokkenen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridTypeBetrokkenen.Location = New System.Drawing.Point(16, 264)
        Me.UltraGridTypeBetrokkenen.Name = "UltraGridTypeBetrokkenen"
        Me.UltraGridTypeBetrokkenen.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridTypeBetrokkenen.TabIndex = 11
        Me.UltraGridTypeBetrokkenen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataTypeBetrokkene
        '
        Me._dataTypeBetrokkene.DataSetName = "TDSTypeBetrokkene"
        Me._dataTypeBetrokkene.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataTypeBetrokkene.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridIndividutypes
        '
        Me.UltraGridIndividutypes.DataSource = Me._dataIndividutype
        Appearance340.BackColor = System.Drawing.SystemColors.Window
        Appearance340.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridIndividutypes.DisplayLayout.Appearance = Appearance340
        Me.UltraGridIndividutypes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn102.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn102.Header.VisiblePosition = 0
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.Width = 442
        UltraGridColumn103.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn103.Header.Caption = "Individutype"
        UltraGridColumn103.Header.VisiblePosition = 1
        UltraGridColumn103.Width = 323
        UltraGridBand27.Columns.AddRange(New Object() {UltraGridColumn102, UltraGridColumn103})
        Me.UltraGridIndividutypes.DisplayLayout.BandsSerializer.Add(UltraGridBand27)
        Me.UltraGridIndividutypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridIndividutypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance341.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance341.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance341.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance341.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividutypes.DisplayLayout.GroupByBox.Appearance = Appearance341
        Appearance342.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridIndividutypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance342
        Me.UltraGridIndividutypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridIndividutypes.DisplayLayout.GroupByBox.Hidden = True
        Appearance343.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance343.BackColor2 = System.Drawing.SystemColors.Control
        Appearance343.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance343.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridIndividutypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance343
        Me.UltraGridIndividutypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridIndividutypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance344.BackColor = System.Drawing.SystemColors.Window
        Appearance344.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridIndividutypes.DisplayLayout.Override.ActiveCellAppearance = Appearance344
        Appearance345.BackColor = System.Drawing.SystemColors.Highlight
        Appearance345.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridIndividutypes.DisplayLayout.Override.ActiveRowAppearance = Appearance345
        Me.UltraGridIndividutypes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridIndividutypes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIndividutypes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridIndividutypes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIndividutypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridIndividutypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance346.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividutypes.DisplayLayout.Override.CardAreaAppearance = Appearance346
        Appearance347.BorderColor = System.Drawing.Color.Silver
        Appearance347.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridIndividutypes.DisplayLayout.Override.CellAppearance = Appearance347
        Me.UltraGridIndividutypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridIndividutypes.DisplayLayout.Override.CellPadding = 0
        Appearance348.BackColor = System.Drawing.SystemColors.Control
        Appearance348.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance348.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance348.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance348.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridIndividutypes.DisplayLayout.Override.GroupByRowAppearance = Appearance348
        Appearance349.TextHAlignAsString = "Left"
        Me.UltraGridIndividutypes.DisplayLayout.Override.HeaderAppearance = Appearance349
        Me.UltraGridIndividutypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridIndividutypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance350.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridIndividutypes.DisplayLayout.Override.RowAlternateAppearance = Appearance350
        Appearance351.BackColor = System.Drawing.SystemColors.Window
        Appearance351.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridIndividutypes.DisplayLayout.Override.RowAppearance = Appearance351
        Me.UltraGridIndividutypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIndividutypes.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance352.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridIndividutypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance352
        Me.UltraGridIndividutypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridIndividutypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridIndividutypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridIndividutypes.Location = New System.Drawing.Point(16, 216)
        Me.UltraGridIndividutypes.Name = "UltraGridIndividutypes"
        Me.UltraGridIndividutypes.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridIndividutypes.TabIndex = 9
        Me.UltraGridIndividutypes.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        '_dataIndividutype
        '
        Me._dataIndividutype.DataSetName = "TDSIndividutype"
        Me._dataIndividutype.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataIndividutype.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraGridInbreuktypes
        '
        Me.UltraGridInbreuktypes.DataSource = Me._dataInbrType.BBINBRTY
        Appearance353.BackColor = System.Drawing.SystemColors.Window
        Appearance353.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridInbreuktypes.DisplayLayout.Appearance = Appearance353
        Me.UltraGridInbreuktypes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn104.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn104.Header.VisiblePosition = 0
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn105.Header.Caption = "Inbreuktype"
        UltraGridColumn105.Header.VisiblePosition = 1
        UltraGridColumn105.Width = 323
        UltraGridBand28.Columns.AddRange(New Object() {UltraGridColumn104, UltraGridColumn105})
        Me.UltraGridInbreuktypes.DisplayLayout.BandsSerializer.Add(UltraGridBand28)
        Me.UltraGridInbreuktypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreuktypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance354.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance354.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance354.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance354.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreuktypes.DisplayLayout.GroupByBox.Appearance = Appearance354
        Appearance355.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreuktypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance355
        Me.UltraGridInbreuktypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInbreuktypes.DisplayLayout.GroupByBox.Hidden = True
        Appearance356.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance356.BackColor2 = System.Drawing.SystemColors.Control
        Appearance356.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance356.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInbreuktypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance356
        Me.UltraGridInbreuktypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridInbreuktypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance357.BackColor = System.Drawing.SystemColors.Window
        Appearance357.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridInbreuktypes.DisplayLayout.Override.ActiveCellAppearance = Appearance357
        Appearance358.BackColor = System.Drawing.SystemColors.Highlight
        Appearance358.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridInbreuktypes.DisplayLayout.Override.ActiveRowAppearance = Appearance358
        Me.UltraGridInbreuktypes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridInbreuktypes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreuktypes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridInbreuktypes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreuktypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridInbreuktypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance359.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreuktypes.DisplayLayout.Override.CardAreaAppearance = Appearance359
        Appearance360.BorderColor = System.Drawing.Color.Silver
        Appearance360.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridInbreuktypes.DisplayLayout.Override.CellAppearance = Appearance360
        Me.UltraGridInbreuktypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridInbreuktypes.DisplayLayout.Override.CellPadding = 0
        Appearance361.BackColor = System.Drawing.SystemColors.Control
        Appearance361.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance361.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance361.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance361.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInbreuktypes.DisplayLayout.Override.GroupByRowAppearance = Appearance361
        Appearance362.TextHAlignAsString = "Left"
        Me.UltraGridInbreuktypes.DisplayLayout.Override.HeaderAppearance = Appearance362
        Me.UltraGridInbreuktypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridInbreuktypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance363.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridInbreuktypes.DisplayLayout.Override.RowAlternateAppearance = Appearance363
        Appearance364.BackColor = System.Drawing.SystemColors.Window
        Appearance364.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridInbreuktypes.DisplayLayout.Override.RowAppearance = Appearance364
        Me.UltraGridInbreuktypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInbreuktypes.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance365.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridInbreuktypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance365
        Me.UltraGridInbreuktypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridInbreuktypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridInbreuktypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInbreuktypes.Location = New System.Drawing.Point(16, 168)
        Me.UltraGridInbreuktypes.Name = "UltraGridInbreuktypes"
        Me.UltraGridInbreuktypes.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridInbreuktypes.TabIndex = 7
        Me.UltraGridInbreuktypes.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGridEenheden
        '
        Me.UltraGridEenheden.DataSource = Me._dataEenheden.BBEH
        Appearance366.BackColor = System.Drawing.SystemColors.Window
        Appearance366.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridEenheden.DisplayLayout.Appearance = Appearance366
        Me.UltraGridEenheden.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn114.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn114.Hidden = True
        UltraGridColumn114.Width = 283
        UltraGridColumn115.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn115.Header.Caption = "Eenheden"
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn115.Width = 323
        UltraGridBand29.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115})
        Me.UltraGridEenheden.DisplayLayout.BandsSerializer.Add(UltraGridBand29)
        Me.UltraGridEenheden.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridEenheden.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance367.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance367.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance367.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance367.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridEenheden.DisplayLayout.GroupByBox.Appearance = Appearance367
        Appearance368.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridEenheden.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance368
        Me.UltraGridEenheden.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridEenheden.DisplayLayout.GroupByBox.Hidden = True
        Appearance369.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance369.BackColor2 = System.Drawing.SystemColors.Control
        Appearance369.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance369.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridEenheden.DisplayLayout.GroupByBox.PromptAppearance = Appearance369
        Me.UltraGridEenheden.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridEenheden.DisplayLayout.MaxRowScrollRegions = 1
        Appearance370.BackColor = System.Drawing.SystemColors.Window
        Appearance370.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridEenheden.DisplayLayout.Override.ActiveCellAppearance = Appearance370
        Appearance371.BackColor = System.Drawing.SystemColors.Highlight
        Appearance371.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridEenheden.DisplayLayout.Override.ActiveRowAppearance = Appearance371
        Me.UltraGridEenheden.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridEenheden.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridEenheden.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridEenheden.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridEenheden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridEenheden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance372.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridEenheden.DisplayLayout.Override.CardAreaAppearance = Appearance372
        Appearance373.BorderColor = System.Drawing.Color.Silver
        Appearance373.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridEenheden.DisplayLayout.Override.CellAppearance = Appearance373
        Me.UltraGridEenheden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridEenheden.DisplayLayout.Override.CellPadding = 0
        Appearance374.BackColor = System.Drawing.SystemColors.Control
        Appearance374.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance374.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance374.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance374.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridEenheden.DisplayLayout.Override.GroupByRowAppearance = Appearance374
        Appearance375.TextHAlignAsString = "Left"
        Me.UltraGridEenheden.DisplayLayout.Override.HeaderAppearance = Appearance375
        Me.UltraGridEenheden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridEenheden.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance376.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridEenheden.DisplayLayout.Override.RowAlternateAppearance = Appearance376
        Appearance377.BackColor = System.Drawing.SystemColors.Window
        Appearance377.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridEenheden.DisplayLayout.Override.RowAppearance = Appearance377
        Me.UltraGridEenheden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridEenheden.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance378.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridEenheden.DisplayLayout.Override.TemplateAddRowAppearance = Appearance378
        Me.UltraGridEenheden.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridEenheden.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridEenheden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridEenheden.Location = New System.Drawing.Point(16, 120)
        Me.UltraGridEenheden.Name = "UltraGridEenheden"
        Me.UltraGridEenheden.Size = New System.Drawing.Size(360, 80)
        Me.UltraGridEenheden.TabIndex = 5
        Me.UltraGridEenheden.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGridInterventietypes
        '
        Me.UltraGridInterventietypes.DataSource = Me._dataIntvType.BBINTVTY
        Appearance379.BackColor = System.Drawing.SystemColors.Window
        Appearance379.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridInterventietypes.DisplayLayout.Appearance = Appearance379
        Me.UltraGridInterventietypes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn116.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn116.Header.VisiblePosition = 0
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn117.Header.Caption = "Interventietype"
        UltraGridColumn117.Header.VisiblePosition = 1
        UltraGridColumn117.Width = 683
        UltraGridBand30.Columns.AddRange(New Object() {UltraGridColumn116, UltraGridColumn117})
        Me.UltraGridInterventietypes.DisplayLayout.BandsSerializer.Add(UltraGridBand30)
        Me.UltraGridInterventietypes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInterventietypes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance380.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance380.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance380.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance380.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventietypes.DisplayLayout.GroupByBox.Appearance = Appearance380
        Appearance381.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInterventietypes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance381
        Me.UltraGridInterventietypes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridInterventietypes.DisplayLayout.GroupByBox.Hidden = True
        Appearance382.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance382.BackColor2 = System.Drawing.SystemColors.Control
        Appearance382.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance382.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridInterventietypes.DisplayLayout.GroupByBox.PromptAppearance = Appearance382
        Me.UltraGridInterventietypes.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridInterventietypes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance383.BackColor = System.Drawing.SystemColors.Window
        Appearance383.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridInterventietypes.DisplayLayout.Override.ActiveCellAppearance = Appearance383
        Appearance384.BackColor = System.Drawing.SystemColors.Highlight
        Appearance384.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridInterventietypes.DisplayLayout.Override.ActiveRowAppearance = Appearance384
        Me.UltraGridInterventietypes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop
        Me.UltraGridInterventietypes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInterventietypes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UltraGridInterventietypes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInterventietypes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridInterventietypes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance385.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventietypes.DisplayLayout.Override.CardAreaAppearance = Appearance385
        Appearance386.BorderColor = System.Drawing.Color.Silver
        Appearance386.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridInterventietypes.DisplayLayout.Override.CellAppearance = Appearance386
        Me.UltraGridInterventietypes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridInterventietypes.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridInterventietypes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance387.BackColor = System.Drawing.SystemColors.Control
        Appearance387.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance387.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance387.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance387.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridInterventietypes.DisplayLayout.Override.GroupByRowAppearance = Appearance387
        Appearance388.TextHAlignAsString = "Left"
        Me.UltraGridInterventietypes.DisplayLayout.Override.HeaderAppearance = Appearance388
        Me.UltraGridInterventietypes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridInterventietypes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance389.BackColor = System.Drawing.SystemColors.Info
        Me.UltraGridInterventietypes.DisplayLayout.Override.RowAlternateAppearance = Appearance389
        Appearance390.BackColor = System.Drawing.SystemColors.Window
        Appearance390.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridInterventietypes.DisplayLayout.Override.RowAppearance = Appearance390
        Me.UltraGridInterventietypes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridInterventietypes.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance391.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridInterventietypes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance391
        Me.UltraGridInterventietypes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridInterventietypes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridInterventietypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInterventietypes.Location = New System.Drawing.Point(16, 72)
        Me.UltraGridInterventietypes.Name = "UltraGridInterventietypes"
        Me.UltraGridInterventietypes.Size = New System.Drawing.Size(720, 56)
        Me.UltraGridInterventietypes.TabIndex = 3
        Me.UltraGridInterventietypes.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButtonVernieuwen
        '
        Appearance392.Image = CType(resources.GetObject("Appearance392.Image"), Object)
        Me.UltraButtonVernieuwen.Appearance = Appearance392
        Me.UltraButtonVernieuwen.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonVernieuwen.Location = New System.Drawing.Point(336, 640)
        Me.UltraButtonVernieuwen.Name = "UltraButtonVernieuwen"
        Me.UltraButtonVernieuwen.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonVernieuwen.TabIndex = 0
        Me.UltraButtonVernieuwen.Text = "Vernieuwen"
        '
        'UltraPrintPreviewDialogCodeTabellen
        '
        Me.UltraPrintPreviewDialogCodeTabellen.Document = Me.UltraGridPrintDocumentCodeTabellen
        Me.UltraPrintPreviewDialogCodeTabellen.Name = "UltraPrintPreviewDialogCodeTabellen"
        '
        'UltraGroupBoxBewaking
        '
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonDagverslagInlichtingType)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonRegistratietypesDagverslag)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonVerzekeringFirmas)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonFirmas)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonWerfvoertuig)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonGebruikVoertuig)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonSchadeAan)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonVoertuigTypes)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonTypesBetrokkenen)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonInbreukartikelen)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonIndividutypes)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonRegistratietypes)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.RadioButtonInbreuktype)
        Me.UltraGroupBoxBewaking.Location = New System.Drawing.Point(16, 168)
        Me.UltraGroupBoxBewaking.Name = "UltraGroupBoxBewaking"
        Me.UltraGroupBoxBewaking.Size = New System.Drawing.Size(208, 336)
        Me.UltraGroupBoxBewaking.TabIndex = 1
        Me.UltraGroupBoxBewaking.Text = "Bewaking"
        Me.UltraGroupBoxBewaking.Visible = False
        '
        'RadioButtonDagverslagInlichtingType
        '
        Me.RadioButtonDagverslagInlichtingType.Location = New System.Drawing.Point(16, 304)
        Me.RadioButtonDagverslagInlichtingType.Name = "RadioButtonDagverslagInlichtingType"
        Me.RadioButtonDagverslagInlichtingType.Size = New System.Drawing.Size(168, 24)
        Me.RadioButtonDagverslagInlichtingType.TabIndex = 12
        Me.RadioButtonDagverslagInlichtingType.Text = "Rubrieken dagverslag"
        '
        'RadioButtonRegistratietypesDagverslag
        '
        Me.RadioButtonRegistratietypesDagverslag.Location = New System.Drawing.Point(16, 280)
        Me.RadioButtonRegistratietypesDagverslag.Name = "RadioButtonRegistratietypesDagverslag"
        Me.RadioButtonRegistratietypesDagverslag.Size = New System.Drawing.Size(168, 24)
        Me.RadioButtonRegistratietypesDagverslag.TabIndex = 11
        Me.RadioButtonRegistratietypesDagverslag.Text = "Registratietypes dagverslag"
        '
        'RadioButtonVerzekeringFirmas
        '
        Me.RadioButtonVerzekeringFirmas.Location = New System.Drawing.Point(16, 256)
        Me.RadioButtonVerzekeringFirmas.Name = "RadioButtonVerzekeringFirmas"
        Me.RadioButtonVerzekeringFirmas.Size = New System.Drawing.Size(152, 24)
        Me.RadioButtonVerzekeringFirmas.TabIndex = 10
        Me.RadioButtonVerzekeringFirmas.Text = "Verzekeringfirma's"
        '
        'RadioButtonFirmas
        '
        Me.RadioButtonFirmas.Location = New System.Drawing.Point(16, 232)
        Me.RadioButtonFirmas.Name = "RadioButtonFirmas"
        Me.RadioButtonFirmas.Size = New System.Drawing.Size(104, 24)
        Me.RadioButtonFirmas.TabIndex = 9
        Me.RadioButtonFirmas.Text = "Firma's"
        '
        'RadioButtonPersoneel
        '
        Me.RadioButtonPersoneel.Location = New System.Drawing.Point(16, 88)
        Me.RadioButtonPersoneel.Name = "RadioButtonPersoneel"
        Me.RadioButtonPersoneel.Size = New System.Drawing.Size(168, 16)
        Me.RadioButtonPersoneel.TabIndex = 3
        Me.RadioButtonPersoneel.Text = "Personeel"
        '
        'UltraGroupBoxAlgemeen
        '
        Me.UltraGroupBoxAlgemeen.Controls.Add(Me.RadioButtonAMC)
        Me.UltraGroupBoxAlgemeen.Controls.Add(Me.RadioButtonPloegen)
        Me.UltraGroupBoxAlgemeen.Controls.Add(Me.RadioButtonAanspreektitel)
        Me.UltraGroupBoxAlgemeen.Controls.Add(Me.RadioButtonAfdelingen)
        Me.UltraGroupBoxAlgemeen.Controls.Add(Me.RadioButtonPersoneel)
        Me.UltraGroupBoxAlgemeen.Location = New System.Drawing.Point(16, 504)
        Me.UltraGroupBoxAlgemeen.Name = "UltraGroupBoxAlgemeen"
        Me.UltraGroupBoxAlgemeen.Size = New System.Drawing.Size(208, 182)
        Me.UltraGroupBoxAlgemeen.TabIndex = 2
        Me.UltraGroupBoxAlgemeen.Text = "Algemeen"
        '
        'RadioButtonAMC
        '
        Me.RadioButtonAMC.Location = New System.Drawing.Point(16, 110)
        Me.RadioButtonAMC.Name = "RadioButtonAMC"
        Me.RadioButtonAMC.Size = New System.Drawing.Size(168, 16)
        Me.RadioButtonAMC.TabIndex = 4
        Me.RadioButtonAMC.Text = "Afdelingsmilieucoördinator"
        '
        'StatusBarCodetabellen
        '
        Me.StatusBarCodetabellen.Department = ""
        Me.StatusBarCodetabellen.Location = New System.Drawing.Point(0, 692)
        Me.StatusBarCodetabellen.Message = ""
        Me.StatusBarCodetabellen.Name = "StatusBarCodetabellen"
        Me.StatusBarCodetabellen.ShowPanels = True
        Me.StatusBarCodetabellen.Size = New System.Drawing.Size(1016, 22)
        Me.StatusBarCodetabellen.TabIndex = 4
        Me.StatusBarCodetabellen.User = ""
        '
        'FormCodetabellen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 714)
        Me.Controls.Add(Me.StatusBarCodetabellen)
        Me.Controls.Add(Me.UltraGroupBoxAlgemeen)
        Me.Controls.Add(Me.UltraGroupBoxBewaking)
        Me.Controls.Add(Me.UltraGroupBoxCodetabel)
        Me.Controls.Add(Me.UltraGroupBoxBrandweer)
        Me.Name = "FormCodetabellen"
        Me.Text = "Codetabellen"
        CType(Me.UltraGroupBoxBrandweer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxBrandweer.ResumeLayout(False)
        CType(Me.UltraDropDownIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividuen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownAfdeling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownInterventieartikelen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataArtikelgroep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownEenheden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataEenheden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownInbreuktypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInbrType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDropDownInterventietypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIntvType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxCodetabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxCodetabel.ResumeLayout(False)
        CType(Me.UltraGridAFDAMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAFDAMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridAarden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAarden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridInbreukartikelen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInbrArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridRegistratietype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataRegType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridArtikelgroepen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridOorzaken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataOorzaken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridnterventieartikelen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIntvArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridPersoneel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBBBWPERS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridDagverslagInlichtingType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataDagverslagInlichtingType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultraGridDagverslagRegistratyType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataDagverslagRegistratieType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridVerzekeringFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridWerfvoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataWerfVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridGebruikVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataGebruikVoertuig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridSchadeAan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataScadObjecten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridPloeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataPloeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridAanspreektitel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataAanspreektitel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridVoertuigType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataVoertuigTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridTypeBetrokkenen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataTypeBetrokkene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridIndividutypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataIndividutype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridInbreuktypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridEenheden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridInterventietypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxBewaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxBewaking.ResumeLayout(False)
        CType(Me.UltraGroupBoxAlgemeen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxAlgemeen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Constants"
    Private _controller As ControllerGetData
    Private POSITIEGRID As New Point(16, 24)   ' Voor de positie van de zichtbare ultragrid
    Private GROOTTEGRID As New Size(728, 540) ' Voor de grootte van de zichtbare ultragrid
    Private ULTRAGRIDS(23) As UltraGrid         ' Tabel die de verschillende grids bevat
    Private POSITIEBUTTONREFRESH As New Point(180, 569)   'Positie van de vernieuwknop
    Private POSITIEBUTTONPRINT As New Point(275, 569)   'Positie van de afdrukknop
    Private POSITIEBUTTONSAVE As New Point(370, 569)    'Positie van de opslaanknop
#End Region
#Region "formLoad"
    Private Sub FormCodetabellen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Doel:   Opvullen van de tabellen en de data in de grids
        'Auteur: Koen/Rajiv - 18/04/2006

        'opbouw statusbar
        Dim ctrl As Control
        If Me.IsMdiChild Then
            For Each ctrl In Me.MdiParent.Controls
                If TypeOf (ctrl) Is ADF.Windows.Forms.UserControls.StatusBar AndAlso Not ctrl Is StatusBarCodetabellen Then
                    StatusBarCodetabellen.Remove()
                    StatusBarCodetabellen = CType(ctrl, ADF.Windows.Forms.UserControls.StatusBar)
                    Exit For
                End If
            Next
        End If

        'opvullen array
        ULTRAGRIDS(0) = UltraGridAarden
        ULTRAGRIDS(1) = UltraGridOorzaken
        ULTRAGRIDS(2) = UltraGridInterventietypes
        ULTRAGRIDS(3) = UltraGridAfdelingen
        ULTRAGRIDS(4) = UltraGridEenheden
        ULTRAGRIDS(5) = UltraGridArtikelgroepen
        ULTRAGRIDS(6) = UltraGridInbreuktypes
        ULTRAGRIDS(7) = UltraGridRegistratietype
        ULTRAGRIDS(8) = UltraGridIndividutypes
        ULTRAGRIDS(9) = UltraGridInbreukartikelen
        ULTRAGRIDS(10) = UltraGridTypeBetrokkenen
        ULTRAGRIDS(11) = UltraGridVoertuigType
        ULTRAGRIDS(12) = UltraGridAanspreektitel
        ULTRAGRIDS(13) = UltraGridPloeg
        ULTRAGRIDS(14) = UltraGridSchadeAan
        ULTRAGRIDS(15) = UltraGridGebruikVoertuig
        ULTRAGRIDS(16) = UltraGridWerfvoertuig
        ULTRAGRIDS(17) = UltraGridnterventieartikelen
        ULTRAGRIDS(18) = UltraGridFirmas
        ULTRAGRIDS(19) = UltraGridVerzekeringFirmas
        ULTRAGRIDS(20) = ultraGridDagverslagRegistratyType
        ULTRAGRIDS(21) = UltraGridDagverslagInlichtingType
        ULTRAGRIDS(22) = UltraGridPersoneel
        ULTRAGRIDS(23) = UltraGridAFDAMC

        'initieel de aarden tonen
        RadioButtonAarden.Checked = True

        'Positie knoppen instellen
        UltraButtonAfdrukken.Location = POSITIEBUTTONPRINT
        UltraButtonOpslaan.Location = POSITIEBUTTONSAVE
        UltraButtonVernieuwen.Location = POSITIEBUTTONREFRESH

        'properties instellen
        Dim grid As UltraGrid
        For Each grid In ULTRAGRIDS
            grid.DisplayLayout.Override.TemplateAddRowPrompt = "Klik hier om een rij toe te voegen..."
            grid.DisplayLayout.Override.TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
            grid.DisplayLayout.Override.SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
            grid.DisplayLayout.Override.BorderStyleSpecialRowSeparator = Infragistics.Win.UIElementBorderStyle.RaisedSoft
        Next

        'valuelists binden
        Me.UltraGridAarden.DisplayLayout.Bands(0).Columns("ID_TY_INTV").ValueList = Me.UltraDropDownInterventietypes
        Me.UltraGridOorzaken.DisplayLayout.Bands(0).Columns("ID_TY_INTV").ValueList = Me.UltraDropDownInterventietypes
        Me.UltraGridInbreukartikelen.DisplayLayout.Bands(0).Columns("ID_TY_INBR").ValueList = Me.UltraDropDownInbreuktypes
        Me.UltraGridnterventieartikelen.DisplayLayout.Bands(0).Columns("ID_EH").ValueList = Me.UltraDropDownEenheden
        Me.UltraGridnterventieartikelen.DisplayLayout.Bands(0).Columns("ID_GR_ART").ValueList = Me.UltraDropDownInterventieartikelen
        Me.UltraGridAFDAMC.DisplayLayout.Bands(0).Columns("ID_AFD").ValueList = Me.UltraDropDownAfdeling
        Me.UltraGridAFDAMC.DisplayLayout.Bands(0).Columns("ID_IND").ValueList = Me.UltraDropDownIndividuen

        'groupboxen tonen, instellen location codetabel algemeen als bewaking = true
        If FormManager.Current.Brandweer = True Then
            UltraGroupBoxBrandweer.Visible = True
            UltraGroupBoxAlgemeen.Location = Me.UltraGroupBoxBewaking.Location
        ElseIf FormManager.Current.Bewaking = True Then
            UltraGroupBoxBewaking.Location = Me.UltraGroupBoxBrandweer.Location
            UltraGroupBoxAlgemeen.Location = New System.Drawing.Point(Me.UltraGroupBoxBewaking.Left, Me.UltraGroupBoxBewaking.Location.Y + Me.UltraGroupBoxBewaking.Size.Height + 2)
            UltraGroupBoxBewaking.Visible = True
        Else
            UltraGroupBoxBewaking.Visible = True
            UltraGroupBoxBrandweer.Visible = True
        End If

        Me.fillGrids()

        Me.UltraButtonOpslaan.Enabled = False
    End Sub
#End Region
#Region "CheckedChanged"
    Private Sub RadioButtonAarden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAarden.CheckedChanged
        If (RadioButtonAarden.Checked) Then
            SetGridsInvisible(UltraGridAarden)
            UltraGridAarden.Location = POSITIEGRID
            UltraGridAarden.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonAarden()
    End Sub

    Private Sub RadioButtonOorzaken_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOorzaken.CheckedChanged
        If (RadioButtonOorzaken.Checked) Then
            SetGridsInvisible(UltraGridOorzaken)
            UltraGridOorzaken.Location = POSITIEGRID
            UltraGridOorzaken.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonOorzaken()
    End Sub

    Private Sub RadioButtonInterventietypes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonInterventietypes.CheckedChanged
        If (RadioButtonInterventietypes.Checked) Then
            SetGridsInvisible(UltraGridInterventietypes)
            UltraGridInterventietypes.Location = POSITIEGRID
            UltraGridInterventietypes.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonInterventietypes()
    End Sub

    Private Sub RadioButtonAfdelingen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAfdelingen.CheckedChanged
        If (RadioButtonAfdelingen.Checked) Then
            SetGridsInvisible(UltraGridAfdelingen)
            UltraGridAfdelingen.Location = POSITIEGRID
            UltraGridAfdelingen.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonAfdelingen()
    End Sub

    Private Sub RadioButtonEenheden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonEenheden.CheckedChanged
        If (RadioButtonEenheden.Checked) Then
            SetGridsInvisible(UltraGridEenheden)
            UltraGridEenheden.Location = POSITIEGRID
            UltraGridEenheden.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonEenheden()
    End Sub

    Private Sub RadioButtonArtikelgroep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonArtikelgroep.CheckedChanged
        If (RadioButtonArtikelgroep.Checked) Then
            SetGridsInvisible(UltraGridArtikelgroepen)
            UltraGridArtikelgroepen.Location = POSITIEGRID
            UltraGridArtikelgroepen.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonArtikelgroepen()
    End Sub

    Private Sub RadioButtonInbreuktype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonInbreuktype.CheckedChanged
        If (RadioButtonInbreuktype.Checked) Then
            SetGridsInvisible(UltraGridInbreuktypes)
            UltraGridInbreuktypes.Location = POSITIEGRID
            UltraGridInbreuktypes.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonInbreuktypes()
    End Sub

    Private Sub RadioButtonRegistratietypes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRegistratietypes.CheckedChanged
        If (RadioButtonRegistratietypes.Checked) Then
            SetGridsInvisible(UltraGridRegistratietype)
            UltraGridRegistratietype.Location = POSITIEGRID
            UltraGridRegistratietype.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonRegistratietypes()
    End Sub

    Private Sub RadioButtonIndividutypes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonIndividutypes.CheckedChanged
        If (RadioButtonIndividutypes.Checked) Then
            SetGridsInvisible(UltraGridIndividutypes)
            UltraGridIndividutypes.Location = POSITIEGRID
            UltraGridIndividutypes.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonIndividutypes()
    End Sub

    Private Sub RadioButtonInbreukartikelen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonInbreukartikelen.CheckedChanged
        If (RadioButtonInbreukartikelen.Checked) Then
            SetGridsInvisible(UltraGridInbreukartikelen)
            UltraGridInbreukartikelen.Location = POSITIEGRID
            UltraGridInbreukartikelen.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonInbreukartikelen()
    End Sub

    Private Sub RadioButtonTypesBetrokkenen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTypesBetrokkenen.CheckedChanged
        If (RadioButtonTypesBetrokkenen.Checked) Then
            SetGridsInvisible(UltraGridTypeBetrokkenen)
            UltraGridTypeBetrokkenen.Location = POSITIEGRID
            UltraGridTypeBetrokkenen.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonBetrokkenentypes()
    End Sub

    Private Sub RadioButtonVoertuigTypes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVoertuigTypes.CheckedChanged
        If (RadioButtonVoertuigTypes.Checked) Then
            SetGridsInvisible(UltraGridVoertuigType)
            UltraGridVoertuigType.Location = POSITIEGRID
            UltraGridVoertuigType.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonVoertuigtypes()
    End Sub

    Private Sub RadioButtonAanspreektitel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAanspreektitel.CheckedChanged
        If (RadioButtonAanspreektitel.Checked) Then
            SetGridsInvisible(UltraGridAanspreektitel)
            UltraGridAanspreektitel.Location = POSITIEGRID
            UltraGridAanspreektitel.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonAanspreektitels()
    End Sub

    Private Sub RadioButtonPloegen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPloegen.CheckedChanged
        If (RadioButtonPloegen.Checked) Then
            SetGridsInvisible(UltraGridPloeg)
            UltraGridPloeg.Location = POSITIEGRID
            UltraGridPloeg.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonPloegen()
    End Sub

    Private Sub RadioButtonSchadeAan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSchadeAan.CheckedChanged
        If (RadioButtonSchadeAan.Checked) Then
            SetGridsInvisible(UltraGridSchadeAan)
            UltraGridSchadeAan.Location = POSITIEGRID
            UltraGridSchadeAan.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonSchadeAan()
    End Sub

    Private Sub RadioButtonGebruikVoertuig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonGebruikVoertuig.CheckedChanged
        If (RadioButtonGebruikVoertuig.Checked) Then
            SetGridsInvisible(UltraGridGebruikVoertuig)
            UltraGridGebruikVoertuig.Location = POSITIEGRID
            UltraGridGebruikVoertuig.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonGebruikVoertuig()
    End Sub

    Private Sub RadioButtonWerfvoertuig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonWerfvoertuig.CheckedChanged
        If (RadioButtonWerfvoertuig.Checked) Then
            SetGridsInvisible(UltraGridWerfvoertuig)
            UltraGridWerfvoertuig.Location = POSITIEGRID
            UltraGridWerfvoertuig.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonWerfVoertuig()
    End Sub
    Private Sub RadioButtonFirmas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonFirmas.CheckedChanged
        If (RadioButtonFirmas.Checked) Then
            SetGridsInvisible(ultragridFirmas)
            UltragridFirmas.location = POSITIEGRID
            UltragridFirmas.size = GROOTTEGRID
        End If
        Me.enableopslaanButtonFirmas()
    End Sub


    Private Sub RadioButtonVerzekeringFirmas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonVerzekeringFirmas.CheckedChanged
        If (RadioButtonVerzekeringFirmas.Checked) Then
            SetGridsInvisible(UltraGridVerzekeringFirmas)
            UltraGridVerzekeringFirmas.Location = POSITIEGRID
            UltraGridVerzekeringFirmas.Size = GROOTTEGRID
        End If
        Me.enableopslaanButtonverzFirmas()
    End Sub
    Private Sub RadioButtonInterventieartikelen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonInterventieartikelen.CheckedChanged
        If (RadioButtonInterventieartikelen.Checked) Then
            SetGridsInvisible(UltraGridnterventieartikelen)
            UltraGridnterventieartikelen.Location = POSITIEGRID
            UltraGridnterventieartikelen.Size = GROOTTEGRID
        End If
        Me.EnableOpslaanButtonInterventieartikelen()
    End Sub

    Private Sub RadioButtonRegistratietypesDagverslag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonRegistratietypesDagverslag.CheckedChanged
        If (RadioButtonRegistratietypesDagverslag.Checked) Then
            SetGridsInvisible(ultraGridDagverslagRegistratyType)
            ultraGridDagverslagRegistratyType.Location = POSITIEGRID
            ultraGridDagverslagRegistratyType.Size = GROOTTEGRID
        End If
        Me.enableOpslaanButtonTypesDagverslag()
    End Sub


    Private Sub RadioButtonDagverslagInlichtingType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDagverslagInlichtingType.CheckedChanged
        If (RadioButtonDagverslagInlichtingType.Checked) Then
            SetGridsInvisible(UltraGridDagverslagInlichtingType)
            UltraGridDagverslagInlichtingType.Location = POSITIEGRID
            UltraGridDagverslagInlichtingType.Size = GROOTTEGRID
        End If
    End Sub

    Private Sub RadioButtonPersoneel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPersoneel.CheckedChanged
        If (RadioButtonPersoneel.Checked) Then
            SetGridsInvisible(ultragridpersoneel)
            UltraGridPersoneel.Location = POSITIEGRID
            UltraGridPersoneel.Size = GROOTTEGRID
        End If
    End Sub

    Private Sub RadioButtonAMC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonAMC.CheckedChanged
        If (RadioButtonAMC.Checked) Then
            SetGridsInvisible(UltraGridAFDAMC)
            UltraGridAFDAMC.Location = POSITIEGRID
            UltraGridAFDAMC.Size = GROOTTEGRID
        End If
    End Sub
#End Region
#Region "Functions"
    Public Sub fillGrids()
        'Doel:   Opvullen van de verschillende Grids
        'Auteur: Koen/Rajiv - 18/04/2006
        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataIndividuen.Merge(Me._controller.GetIndividuen())
            Me._dataIntvType.Merge(Me._controller.GetInterventieType)
            Me._dataEenheden.Merge(Me._controller.GetEenheden)
            Me._dataArtikelgroep.Merge(Me._controller.GetArtikelGroepen)
            Me._dataInbrType.Merge(Me._controller.GetInbrType)
            Me._dataAarden.Merge(Me._controller.GetAarden(-1))
            Me._dataOorzaken.Merge(Me._controller.GetOorzaken(-1))
            Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)
            Me._dataRegType.Merge(Me._controller.GetRegistratieType)
            Me._dataIndividutype.Merge(Me._controller.GetIndividuTypes)
            Me._dataInbrArt.Merge(Me._controller.GetInbreukArtikel(0))
            Me._dataTypeBetrokkene.Merge(Me._controller.GetTypeBetrokkenen)
            Me._dataVoertuigTypes.Merge(Me._controller.GetVoertuigTypes)
            Me._dataAanspreektitel.Merge(Me._controller.GetAanspreektitel)
            Me._dataPloeg.Merge(Me._controller.GetPloeg)
            Me._dataScadObjecten.Merge(Me._controller.GetScadObjecten)
            Me._dataGebruikVoertuig.Merge(Me._controller.GetGebruikVoertuig)
            Me._dataWerfVoertuig.Merge(Me._controller.GetWerfVoertuig)
            Me._dataIntvArt.Merge(Me._controller.GetInterventieArtikelen)
            Me._dataFirmas.Merge(Me._controller.GetFirmas())
            Me._dataVerzFirmas.Merge(Me._controller.GetVerzFirmas)
            Me._dataDagverslagRegistratieType.Merge(Me._controller.GetDagverslagRegistratieType())
            Me._dataDagverslagInlichtingType.Merge(Me._controller.GetDagverslagInlichtingType())
            Me._dataBBBWPERS.Merge(Me._controller.getPersoneel())
            Me._dataAFDAMC.Merge(Me._controller.getAFDAMC())




        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerInterventie - bindDdlBBWPersoneel" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub clearGrids()
        Me._dataIntvType.Clear()
        Me._dataEenheden.Clear()
        Me._dataArtikelgroep.Clear()
        Me._dataInbrType.Clear()
        Me._dataAarden.Clear()
        Me._dataOorzaken.Clear()
        Me._dataAfdelingen.Clear()
        Me._dataRegType.Clear()
        Me._dataIndividutype.Clear()
        Me._dataInbrArt.Clear()
        Me._dataTypeBetrokkene.Clear()
        Me._dataVoertuigTypes.Clear()
        Me._dataAanspreektitel.Clear()
        Me._dataPloeg.Clear()
        Me._dataScadObjecten.Clear()
        Me._dataGebruikVoertuig.Clear()
        Me._dataWerfVoertuig.Clear()
        Me._dataIntvArt.Clear()
        Me._dataFirmas.Clear()
        Me._dataVerzFirmas.Clear()
        Me._dataDagverslagRegistratieType.Clear()
        Me._dataDagverslagInlichtingType.Clear()
        Me._dataBBBWPERS.Clear()
        Me._dataIndividuen.Clear()
    End Sub

    Private Sub SetGridsInvisible(ByVal visibleGrid As UltraGrid)
        'Doel:   Maakt elke grid uit de tabel ULTRAGRIDS (verschillend van de opgegeven grid) onzichtbaar
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim grid As UltraGrid

        For Each grid In ULTRAGRIDS
            If (Not grid Is visibleGrid) Then
                grid.Visible = False
            Else
                grid.Visible = True
            End If
        Next grid
    End Sub

    Private Function GetVisibleGrid() As UltraGrid
        'Doel:   Geeft de huidige zichtbare grid terug
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim grid As UltraGrid

        For Each grid In ULTRAGRIDS
            If (grid.Visible) Then
                Return grid
            End If
        Next grid

        Return Nothing
    End Function

    Private Sub UltraButtonVernieuwen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonVernieuwen.Click
        Call Me.clearGrids()
        Call Me.fillGrids()
        UltraButtonOpslaan.Enabled = False
    End Sub

    Private Sub setStatus(ByVal statusText As String)
        StatusBarCodetabellen.SetStatusbarInfo(statusText)
    End Sub

    Private Sub FormCodetabellen_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.setStatus("")
    End Sub
#End Region
#Region "Printing"
    Private Sub UltraButtonAfdrukken_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        'Doel:   Gaat de grid die op dat moment zichtbaar is afprinten
        'Auteur: Stein - 10/03/2006

        Dim visibleGrid As UltraGrid
        visibleGrid = GetVisibleGrid()

        UltraGridPrintDocumentCodeTabellen.Grid = visibleGrid

        Me.UltraPrintPreviewDialogCodeTabellen.ShowDialog(Me)
    End Sub
#End Region
#Region "Saving"
    Private Sub UltraButtonOpslaan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            If (UltraGridAarden Is GetVisibleGrid()) Then
                If Me._dataAarden.HasChanges Then
                    Dim dataInAarden As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden
                    dataInAarden.Merge(Me._dataAarden)
                    Me._dataAarden.Merge(proxy.RegisterAarden(CType(dataInAarden.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden), _
                    System.Environment.UserName))
                    _dataAarden.AcceptChanges()
                    Me.setStatus("De codetabel Aarden werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridOorzaken Is GetVisibleGrid()) Then
                If Me._dataOorzaken.HasChanges Then
                    Dim dataInOorzaken As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken
                    dataInOorzaken.Merge(Me._dataOorzaken)
                    Me._dataOorzaken.Merge(proxy.RegisterOorzaken(CType(dataInOorzaken.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken), _
                    System.Environment.UserName))
                    _dataOorzaken.AcceptChanges()
                    Me.setStatus("De codetabel Oorzaken werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridInterventietypes Is GetVisibleGrid()) Then
                If Me._dataIntvType.HasChanges Then
                    Dim dataInInterventietype As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType
                    dataInInterventietype.Merge(Me._dataIntvType)
                    Me._dataIntvType.Merge(proxy.RegisterInterventietype(CType(dataInInterventietype.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType), _
                    System.Environment.UserName))
                    _dataIntvType.AcceptChanges()
                    Me.setStatus("De codetabel Interventietypes werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridAfdelingen Is GetVisibleGrid()) Then
                If Me._dataAfdelingen.HasChanges Then
                    Dim dataInAfdelingen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen
                    dataInAfdelingen.Merge(Me._dataAfdelingen)
                    Me._dataAfdelingen.Merge(proxy.RegisterAfdelingen(CType(dataInAfdelingen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen), _
                    System.Environment.UserName))
                    _dataAfdelingen.AcceptChanges()
                    Me.setStatus("De codetabel Afdelingen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridEenheden Is GetVisibleGrid()) Then
                If Me._dataEenheden.HasChanges Then
                    Dim dataInEenheden As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden
                    dataInEenheden.Merge(Me._dataEenheden)
                    Me._dataEenheden.Merge(proxy.RegisterEenheden(CType(dataInEenheden.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden), _
                    System.Environment.UserName))
                    _dataEenheden.AcceptChanges()
                    Me.setStatus("De codetabel Eenheden werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridArtikelgroepen Is GetVisibleGrid()) Then
                If Me._dataArtikelgroep.HasChanges Then
                    Dim dataInArtikelgroepen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep
                    dataInArtikelgroepen.Merge(Me._dataArtikelgroep)
                    Me._dataArtikelgroep.Merge(proxy.RegisterArtikelgroepen(CType(dataInArtikelgroepen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep), _
                    System.Environment.UserName))
                    _dataArtikelgroep.AcceptChanges()
                    Me.setStatus("De codetabel Artikelgroepen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridInbreuktypes Is GetVisibleGrid()) Then
                If Me._dataInbrType.HasChanges Then
                    Dim dataInInbreuktypes As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType
                    dataInInbreuktypes.Merge(Me._dataInbrType)
                    Me._dataInbrType.Merge(proxy.RegisterInbreuktypes(CType(dataInInbreuktypes.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType), _
                    System.Environment.UserName))
                    _dataInbrType.AcceptChanges()
                    Me.setStatus("De codetabel Inbreuktypes werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridRegistratietype Is GetVisibleGrid()) Then
                If Me._dataRegType.HasChanges Then
                    Dim dataInRegistratietypes As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType
                    dataInRegistratietypes.Merge(Me._dataRegType)
                    Me._dataRegType.Merge(proxy.RegisterRegistratietypes(CType(dataInRegistratietypes.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType), _
                    System.Environment.UserName))
                    _dataRegType.AcceptChanges()
                    Me.setStatus("De codetabel Registratietypes werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridIndividutypes Is GetVisibleGrid()) Then
                If Me._dataIndividutype.HasChanges Then
                    Dim dataInIndividutypes As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType
                    dataInIndividutypes.Merge(Me._dataIndividutype)
                    Me._dataIndividutype.Merge(proxy.RegisterIndividutypes(CType(dataInIndividutypes.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType), _
                    System.Environment.UserName))
                    _dataIndividutype.AcceptChanges()
                    Me.setStatus("De codetabel Individutypes werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridInbreukartikelen Is GetVisibleGrid()) Then
                If Me._dataInbrArt.HasChanges Then
                    Dim dataInInbreukartikelen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt
                    dataInInbreukartikelen.Merge(Me._dataInbrArt)
                    Me._dataInbrArt.Merge(proxy.RegisterInbreukartikelen(CType(dataInInbreukartikelen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt), _
                    System.Environment.UserName))
                    _dataInbrArt.AcceptChanges()
                    Me.setStatus("De codetabel Inbreukartikelen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridTypeBetrokkenen Is GetVisibleGrid()) Then
                If Me._dataTypeBetrokkene.HasChanges Then
                    Dim dataInTypeBetrokkenen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
                    dataInTypeBetrokkenen.Merge(Me._dataTypeBetrokkene)
                    Me._dataTypeBetrokkene.Merge(proxy.RegisterTypesBetrokkenen(CType(dataInTypeBetrokkenen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene), _
                    System.Environment.UserName))
                    _dataTypeBetrokkene.AcceptChanges()
                    Me.setStatus("De codetabel Types Betrokkenen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridVoertuigType Is GetVisibleGrid()) Then
                If Me._dataVoertuigTypes.HasChanges Then
                    Dim dataInVoertuigTypes As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
                    dataInVoertuigTypes.Merge(Me._dataVoertuigTypes)
                    Me._dataVoertuigTypes.Merge(proxy.RegisterTypesVoertuigen(CType(dataInVoertuigTypes.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes), _
                    System.Environment.UserName))
                    _dataVoertuigTypes.AcceptChanges()
                    Me.setStatus("De codetabel Voertuigtypes werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridAanspreektitel Is GetVisibleGrid()) Then
                If Me._dataAanspreektitel.HasChanges Then
                    Dim dataInAanspreektitels As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel
                    dataInAanspreektitels.Merge(Me._dataAanspreektitel)
                    Me._dataAanspreektitel.Merge(proxy.RegisterAanspreektitels(CType(dataInAanspreektitels.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel), _
                    System.Environment.UserName))
                    _dataAanspreektitel.AcceptChanges()
                    _dataVoertuigTypes.AcceptChanges()
                    Me.setStatus("De codetabel Aanspreektitels werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridPloeg Is GetVisibleGrid()) Then
                If Me._dataPloeg.HasChanges Then
                    Dim dataInPloeg As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg
                    dataInPloeg.Merge(Me._dataPloeg)
                    Me._dataPloeg.Merge(proxy.RegisterPloeg(CType(dataInPloeg.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg), _
                    System.Environment.UserName))
                    _dataPloeg.AcceptChanges()
                    Me.setStatus("De codetabel Ploegen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridSchadeAan Is GetVisibleGrid()) Then
                If Me._dataScadObjecten.HasChanges Then
                    Dim dataInSchadeAan As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten
                    dataInSchadeAan.Merge(Me._dataScadObjecten)
                    Me._dataScadObjecten.Merge(proxy.RegisterSchadeAan(CType(dataInSchadeAan.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten), _
                    System.Environment.UserName))
                    _dataScadObjecten.AcceptChanges()
                    Me.setStatus("De codetabel Schade Aan werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridGebruikVoertuig Is GetVisibleGrid()) Then
                If Me._dataGebruikVoertuig.HasChanges Then
                    Dim dataInGebruikVoertuig As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
                    dataInGebruikVoertuig.Merge(Me._dataGebruikVoertuig)
                    Me._dataGebruikVoertuig.Merge(proxy.RegisterGebruikVoertuig(CType(dataInGebruikVoertuig.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig), _
                    System.Environment.UserName))
                    _dataGebruikVoertuig.AcceptChanges()
                    Me.setStatus("De codetabel Gebruik Voertuig werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridWerfvoertuig Is GetVisibleGrid()) Then
                If Me._dataWerfVoertuig.HasChanges Then
                    Dim dataInWerfvoertuigen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig
                    dataInWerfvoertuigen.Merge(Me._dataWerfVoertuig)
                    Me._dataWerfVoertuig.Merge(proxy.RegisterWerfvoertuig(CType(dataInWerfvoertuigen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig), _
                    System.Environment.UserName))
                    _dataWerfVoertuig.AcceptChanges()
                    Me.setStatus("De codetabel Werfvoertuigen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridnterventieartikelen Is GetVisibleGrid()) Then
                If Me._dataIntvArt.HasChanges Then
                    Dim dataInInterventieArtikelen As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt
                    dataInInterventieArtikelen.Merge(Me._dataIntvArt)
                    Me._dataIntvArt.Merge(proxy.RegisterInterventieartikelen(CType(dataInInterventieArtikelen.GetChanges, Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt), _
                    System.Environment.UserName))
                    _dataIntvArt.AcceptChanges()
                    Me.setStatus("De codetabel Interventieartikelen werd succesvol opgeslagen")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven")
                End If
            ElseIf (UltraGridFirmas Is GetVisibleGrid()) Then
                If Me._dataFirmas.HasChanges Then
                    Dim dataFirma As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
                    dataFirma.Merge(Me._dataFirmas)
                    Me._dataFirmas.Merge(proxy.RegisterFirmas(CType(dataFirma.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas), _
                    System.Environment.UserName))
                    _dataFirmas.AcceptChanges()
                    Me.setStatus("De codetabel firma's werd succesvol opgeslagen.")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven.")
                End If
            ElseIf (UltraGridVerzekeringFirmas Is GetVisibleGrid()) Then
                If Me._dataVerzFirmas.HasChanges Then
                    Dim dataVerzFirma As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas
                    dataVerzFirma.Merge(Me._dataVerzFirmas)
                    Me._dataVerzFirmas.Merge(proxy.RegisterVerzFirmas(CType(dataVerzFirma.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas), _
                        System.Environment.UserName))
                    _dataVerzFirmas.AcceptChanges()
                    Me.setStatus("De codetabel verzekeringfirma's werd succesvol opgeslagen.")
                Else
                    Me.setStatus("Geen wijzigingen om weg te schrijven.")
                End If
            ElseIf (ultraGridDagverslagRegistratyType Is GetVisibleGrid()) Then
                If Me._dataDagverslagRegistratieType.HasChanges Then
                    Dim datadagverslagRegistratieType As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
                    datadagverslagRegistratieType.Merge(Me._dataDagverslagRegistratieType)
                    Me._dataDagverslagRegistratieType.Merge(proxy.RegisterDagverslagRegistratieType(CType(datadagverslagRegistratieType.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType), _
                                    System.Environment.UserName))
                    _dataDagverslagRegistratieType.AcceptChanges()
                    Me.setStatus("De codetabel dagverslag registratietypes werd succesvol opgeslagen.")
                End If
            ElseIf (UltraGridDagverslagInlichtingType Is GetVisibleGrid()) Then
                If Me._dataDagverslagInlichtingType.HasChanges Then
                    Dim datadagverslagInlichtingType As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
                    datadagverslagInlichtingType.Merge(Me._dataDagverslagInlichtingType)
                    Me._dataDagverslagInlichtingType.Merge(proxy.RegisterDagverslagInlichtingType(CType(datadagverslagInlichtingType.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType), _
                                    System.Environment.UserName))
                    _dataDagverslagInlichtingType.AcceptChanges()
                    Me.setStatus("De codetabel dagverslag inlichtingtype werd succesvol opgeslagen.")
                End If
            ElseIf (UltraGridPersoneel Is GetVisibleGrid()) Then
                If Me._dataBBBWPERS.HasChanges() Then
                    Dim dataPersoneel As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS
                    dataPersoneel.Merge(Me._dataBBBWPERS)
                    Me._dataBBBWPERS.Merge(proxy.RegisterPersoneel(CType(dataPersoneel.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS), _
                                    System.Environment.UserName))
                    _dataBBBWPERS.AcceptChanges()
                    Me.setStatus("De codetabel personeel werd succesvol opgeslagen.")
                End If
            ElseIf (UltraGridAFDAMC Is GetVisibleGrid()) Then
                If Me._dataAFDAMC.HasChanges() Then
                    Dim dataAFDAMC As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC
                    dataAFDAMC.Merge(Me._dataAFDAMC)
                    Me._dataAFDAMC.Merge(proxy.RegisterAFDAMC(CType(dataAFDAMC.GetChanges(), Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC), _
                                    System.Environment.UserName))
                    _dataAFDAMC.AcceptChanges()
                    Me.setStatus("De codetabel afdelingsmilieucoördinator werd succesvol opgeslagen.")
                End If
            End If
            Cursor.Current = Cursors.Default
            Me.UltraButtonOpslaan.Enabled = False
        Catch ex As Exception
            Dim message As String = ex.Message + vbCrLf
            If (Not ex.InnerException Is Nothing) Then
                message = message + ex.InnerException.Message
            End If
            MessageBox.Show(message)
        End Try
    End Sub
#End Region
#Region "AfterRowInsert"
    Private Sub UltraGridAarden_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridAarden.AfterRowInsert
        Dim r As TDSAarden.BBBRTYRow
        Dim max As Integer = 0
        For Each r In Me._dataAarden.BBBRTY
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_BR_TY_INTV > max Then
                    max = r.ID_BR_TY_INTV
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridTypeBetrokkenen_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridTypeBetrokkenen.AfterRowInsert
        Dim r As TDSTypeBetrokkene.BBTYBTRKRow
        Dim max As Integer = 0
        For Each r In Me._dataTypeBetrokkene.BBTYBTRK
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_BTRK > max Then
                    max = r.ID_TY_BTRK
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridOorzaken_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridOorzaken.AfterRowInsert
        Dim r As TDSOorzaken.BBBRRDRow
        Dim max As Integer = 0
        For Each r In Me._dataOorzaken.BBBRRD
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_BR_RD_INTV > max Then
                    max = r.ID_BR_RD_INTV
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridInterventietypes_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridInterventietypes.AfterRowInsert
        Dim r As TDSIntvType.BBINTVTYRow
        Dim max As Integer = 0
        For Each r In Me._dataIntvType.BBINTVTY
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_INTV > max Then
                    max = r.ID_TY_INTV
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridAfdelingen_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridAfdelingen.AfterRowInsert
        Dim r As TDSAfdelingen.BBAFDRow
        Dim max As Integer = 0
        For Each r In Me._dataAfdelingen.BBAFD
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_AFD > max Then
                    max = r.ID_AFD
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridEenheden_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridEenheden.AfterRowInsert
        Dim r As TDSEenheden.BBEHRow
        Dim max As Integer = 0
        For Each r In Me._dataEenheden.BBEH
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If CType(r.ID_EH, Integer) > max Then
                    max = CType(r.ID_EH, Integer)
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridArtikelgroepen_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridArtikelgroepen.AfterRowInsert
        Dim r As TDSArtikelgroep.BBARTGRRow
        Dim max As Integer = 0
        For Each r In Me._dataArtikelgroep.BBARTGR
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_GR_ART > max Then
                    max = r.ID_GR_ART
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridInbreuktypes_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridInbreuktypes.AfterRowInsert
        Dim r As TDSInbrType.BBINBRTYRow
        Dim max As Integer = 0
        For Each r In Me._dataInbrType.BBINBRTY
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_INBR > max Then
                    max = r.ID_TY_INBR
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridRegistratietype_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridRegistratietype.AfterRowInsert
        Dim r As TDSRegType.BBREGTYRow
        Dim max As Integer = 0
        For Each r In Me._dataRegType.BBREGTY
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_REG > max Then
                    max = r.ID_TY_REG
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridIndividutypes_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridIndividutypes.AfterRowInsert
        Dim r As TDSIndividutype.BBINDTYRow
        Dim max As Integer = 0
        For Each r In Me._dataIndividutype.BBINDTY
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_IND > max Then
                    max = r.ID_TY_IND
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridInbreukartikelen_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridInbreukartikelen.AfterRowInsert
        Dim r As TDSInbrArt.BBINBRARRow
        Dim max As Integer = 0
        For Each r In Me._dataInbrArt.BBINBRAR
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_ART_INBR > max Then
                    max = r.ID_ART_INBR
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridVoertuigType_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridVoertuigType.AfterRowInsert
        Dim r As TDSVoertuigTypes.BBTYTSPRow
        Dim max As Integer = 0
        For Each r In Me._dataVoertuigTypes.BBTYTSP
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_TY_TSP > max Then
                    max = r.ID_TY_TSP
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridAanspreektitel_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridAanspreektitel.AfterRowInsert
        Dim r As TDSAanspreektitel.BBINDGSLRow
        Dim max As Integer = 0
        For Each r In Me._dataAanspreektitel.BBINDGSL
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_GSL_IND > max Then
                    max = r.ID_GSL_IND
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridPloeg_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridPloeg.AfterRowInsert
        Dim r As TDSPloeg.BBBWPLGRow
        Dim max As Integer = 0
        For Each r In Me._dataPloeg.BBBWPLG
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_PLG_IND > max Then
                    max = r.ID_PLG_IND
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridSchadeAan_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridSchadeAan.AfterRowInsert
        Dim r As TDSScadObjecten.BBSCADANRow
        Dim max As Integer = 0
        For Each r In Me._dataScadObjecten.BBSCADAN
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_OBJ_SCAD > max Then
                    max = r.ID_OBJ_SCAD
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridGebruikVoertuig_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridGebruikVoertuig.AfterRowInsert
        Dim r As TDSGebruikVoertuig.BBBRKTSPRow
        Dim max As Integer = 0
        For Each r In Me._dataGebruikVoertuig.BBBRKTSP
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_BRK_TSP > max Then
                    max = r.ID_BRK_TSP
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridWerfvoertuig_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridWerfvoertuig.AfterRowInsert
        Dim r As TDSWerfVoertuig.BBWRFTSPRow = Nothing
        Dim max As Integer
        Do
            max = (Now.Year * Now.Month * Now.Day + Now.Hour + Now.Minute + Now.Second) * 1000 + Now.Millisecond
            Debug.WriteLine(max)
            r = Me._dataWerfVoertuig.BBWRFTSP.FindByID_WRF_TSP(max)
        Loop While Not r Is Nothing

        'For Each r In Me._dataWerfVoertuig.BBWRFTSP
        '    If r.RowState = DataRowState.Deleted Then
        '        'do nothing
        '    Else
        '        If r.ID_WRF_TSP > max Then
        '            max = r.ID_WRF_TSP
        '        End If
        '    End If
        'Next
        e.Row.Cells(0).Value = max
    End Sub

    Private Sub UltraGridnterventieartikelen_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridnterventieartikelen.AfterRowInsert
        Dim r As TDSIntvArt.BBINTARTRow = Nothing
        Dim max As Integer
        Do
            max = (Now.Year * Now.Month * Now.Day + Now.Hour + Now.Minute + Now.Second) * 1000 + Now.Millisecond
            Debug.WriteLine(max)
            r = Me._dataIntvArt.BBINTART.FindByID_ART_INTV(max)
        Loop While Not r Is Nothing

        e.Row.Cells(0).Value = max
    End Sub


    Private Sub UltraGridFirmas_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridFirmas.AfterRowInsert
        Dim r As TDSFirmas.BBFRMRow
        Dim max As Integer = 0
        For Each r In Me._dataFirmas.BBFRM
            If r.RowState = DataRowState.Deleted Then
                'do nothing
            Else
                If r.ID_FRM > max Then
                    max = r.ID_FRM
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridVerzekeringFirmas_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridVerzekeringFirmas.AfterRowInsert
        Dim r As TDSVerzFirmas.BBVZKFRMRow
        Dim max As Integer = 0
        For Each r In Me._dataVerzFirmas.BBVZKFRM
            If r.RowState = DataRowState.Deleted Then
                'Do nothing 
            Else
                If r.ID_FRM_VZK > max Then
                    max = r.ID_FRM_VZK
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub

    Private Sub UltraGridDagverslagRegistratietype_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ultraGridDagverslagRegistratyType.AfterRowInsert
        Dim r As TDSDagverslagRegistratieType.BBDGTYREGRow
        Dim max As Integer = 0
        For Each r In Me._dataDagverslagRegistratieType.BBDGTYREG
            If r.RowState = DataRowState.Deleted Then
            Else
                If r.ID_DG_PERS_TY_REG > max Then
                    max = r.ID_DG_PERS_TY_REG
                End If
            End If
        Next
        e.Row.Cells(0).Value = max + 1
    End Sub
    Private Sub UltraGridDagverslagInlichtingType_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridDagverslagInlichtingType.AfterRowInsert
        Dim r As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType.BBDGPODLRow
        Dim max As Integer = 0
        For Each r In Me._dataDagverslagInlichtingType.BBDGPODL
            If r.RowState = DataRowState.Deleted Then
            Else
                If r.ID_DG_PO_DL > max Then
                    max = r.ID_DG_PO_DL
                End If
            End If
        Next
        e.Row.Cells("ID_DG_PO_DL").Value = max + 1

        max = 0
        For Each r In Me._dataDagverslagInlichtingType.BBDGPODL
            If r.RowState = DataRowState.Deleted Then
            Else
                If r.VLG > max Then
                    max = r.VLG
                End If
            End If
        Next
        e.Row.Cells("VLG").Value = max + 1
    End Sub

    Private Sub UltraGridAFDAMC_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGridAFDAMC.AfterRowInsert

    End Sub
#End Region
#Region "EventsGrid"

#Region "Aarden"
    Private Sub UltraGridAarden_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridAarden.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridAarden_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAarden.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridAarden_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAarden.AfterCellActivate
        Me.EnableOpslaanButtonAarden()
    End Sub
#End Region
#Region "Afdelingen"
    Private Sub UltraGridAfdelingen_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridAfdelingen.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridAfdelingen_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAfdelingen.AfterCellActivate
        Me.EnableOpslaanButtonAfdelingen()
    End Sub

    Private Sub UltraGridAfdelingen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAfdelingen.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Oorzaken"
    Private Sub UltraGridOorzaken_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridOorzaken.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridOorzaken_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridOorzaken.AfterCellActivate
        Me.EnableOpslaanButtonOorzaken()
    End Sub

    Private Sub UltraGridOorzaken_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridOorzaken.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Interventietypes"
    Private Sub UltraGridInterventietypes_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridInterventietypes.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridInterventietypes_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInterventietypes.AfterCellActivate
        Me.EnableOpslaanButtonInterventietypes()
    End Sub

    Private Sub UltraGridInterventietypes_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInterventietypes.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Eenheden"
    Private Sub UltraGridEenheden_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridEenheden.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridEenheden_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridEenheden.AfterCellActivate
        Me.EnableOpslaanButtonEenheden()
    End Sub

    Private Sub UltraGridEenheden_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridEenheden.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Artikelgroepen"
    Private Sub UltraGridArtikelgroepen_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridArtikelgroepen.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridArtikelgroepen_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridArtikelgroepen.AfterCellActivate
        Me.EnableOpslaanButtonArtikelgroepen()
    End Sub

    Private Sub UltraGridArtikelgroepen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridArtikelgroepen.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Inbreuktypes"
    Private Sub UltraGridInbreuktypes_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridInbreuktypes.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridInbreuktypes_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInbreuktypes.AfterCellActivate
        Me.EnableOpslaanButtonInbreuktypes()
    End Sub

    Private Sub UltraGridInbreuktypes_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInbreuktypes.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Registratietypes"
    Private Sub UltraGridRegistratietype_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridRegistratietype.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridRegistratietype_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridRegistratietype.AfterCellActivate
        Me.EnableOpslaanButtonRegistratietypes()
    End Sub

    Private Sub UltraGridRegistratietype_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridRegistratietype.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Individutypes"
    Private Sub UltraGridIndividutypes_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridIndividutypes.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridIndividutypes_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridIndividutypes.AfterCellActivate
        Me.EnableOpslaanButtonIndividutypes()
    End Sub

    Private Sub UltraGridIndividutypes_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridIndividutypes.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Inbreukartikelen"
    Private Sub UltraGridInbreukartikelen_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridInbreukartikelen.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridInbreukartikelen_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInbreukartikelen.AfterCellActivate
        Me.EnableOpslaanButtonInbreukartikelen()
    End Sub

    Private Sub UltraGridInbreukartikelen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridInbreukartikelen.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Types betrokkenen"
    Private Sub UltraGridTypeBetrokkenen_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTypeBetrokkenen.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridTypeBetrokkenen_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridTypeBetrokkenen.AfterCellActivate
        Me.EnableOpslaanButtonBetrokkenentypes()
    End Sub

    Private Sub UltraGridTypeBetrokkenen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridTypeBetrokkenen.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Types voertuigen"
    Private Sub UltraGridVoertuigType_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridVoertuigType.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridVoertuigType_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridVoertuigType.AfterCellActivate
        Me.EnableOpslaanButtonVoertuigtypes()
    End Sub

    Private Sub UltraGridVoertuigType_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridVoertuigType.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Aanspreektitels"
    Private Sub UltraGridAanspreektitel_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridAanspreektitel.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridAanspreektitel_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAanspreektitel.AfterCellActivate
        Me.EnableOpslaanButtonAanspreektitels()
    End Sub

    Private Sub UltraGridAanspreektitel_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAanspreektitel.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Ploegen"
    Private Sub UltraGridPloeg_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPloeg.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridPloeg_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridPloeg.AfterCellActivate
        Me.EnableOpslaanButtonPloegen()
    End Sub

    Private Sub UltraGridPloeg_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridPloeg.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Schade Aan"
    Private Sub UltraGridSchadeAan_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridSchadeAan.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridSchadeAan_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridSchadeAan.AfterCellActivate
        Me.EnableOpslaanButtonSchadeAan()
    End Sub

    Private Sub UltraGridSchadeAan_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridSchadeAan.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Gebruik Voertuig"
    Private Sub UltraGridGebruikVoertuig_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridGebruikVoertuig.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridGebruikVoertuig_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridGebruikVoertuig.AfterCellActivate
        Me.EnableOpslaanButtonGebruikVoertuig()
    End Sub

    Private Sub UltraGridGebruikVoertuig_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridGebruikVoertuig.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Werfvoertuigen"
    Private Sub UltraGridWerfvoertuig_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridWerfvoertuig.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridWerfvoertuig_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridWerfvoertuig.AfterCellActivate
        Me.EnableOpslaanButtonWerfVoertuig()
    End Sub

    Private Sub UltraGridWerfvoertuig_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridWerfvoertuig.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region
#Region "Interventieartikelen"
    Private Sub UltraGridnterventieartikelen_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridnterventieartikelen.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub

    Private Sub UltraGridnterventieartikelen_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridnterventieartikelen.AfterCellActivate
        Me.EnableOpslaanButtonInterventieartikelen()
    End Sub

    Private Sub UltraGridnterventieartikelen_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridnterventieartikelen.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region

#Region "Firma's"
    Private Sub ultraGridRegistratieFirmas_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridFirmas.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub UltraGridRegistratieFirmas_afterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridFirmas.AfterCellActivate
        Me.enableopslaanButtonFirmas()
    End Sub
    Private Sub UltraGridRegistratieFirmas_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridFirmas.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region

#Region "Registratietypes dagverslag"
    Private Sub ultraGridDagverslagRegistratyTypee_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ultraGridDagverslagRegistratyType.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub ultraGridDagverslagRegistratyType_afterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ultraGridDagverslagRegistratyType.AfterCellActivate
        Me.enableOpslaanButtonTypesDagverslag()
    End Sub
    Private Sub ultraGridDagverslagRegistratyType_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ultraGridDagverslagRegistratyType.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region

#Region "Verz. firma's"
    Private Sub ultraGridRegistratieVerzFirmas_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridVerzekeringFirmas.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub UltraGridRegistratieVerzFirmas_afterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridVerzekeringFirmas.AfterCellActivate
        Me.enableopslaanButtonverzFirmas()
    End Sub
    Private Sub UltraGridRegistratieVerzFirmas_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridVerzekeringFirmas.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region

#Region "Dagverslag inlichtingtype "
    Private Sub UltraGridDagverslagInlichtingType_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridDagverslagInlichtingType.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub UltraGridDagverslagInlichtingType_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridDagverslagInlichtingType.AfterCellActivate
        Me.enableopslaanbuttonDagverslagInlichtingType()
    End Sub
    Private Sub UltraGridDagverslagInlichtingType_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridDagverslagInlichtingType.AfterRowsDeleted
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
#End Region

#Region "Personeel"
    Private Sub UltraGridPersoneel_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridPersoneel.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub UltraGridPersoneel_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridPersoneel.AfterCellActivate
        Me.enableOpslaanButtonPersoneel()
    End Sub
    Private Sub UltraGridPersoneel_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridPersoneel.AfterRowsDeleted
        Me.UltraGridPersoneel.Enabled = True
    End Sub
#End Region

#Region "Afdeling AMC"
    Private Sub UltraGridAFDAMC_cellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridAFDAMC.CellChange
        Me.UltraButtonOpslaan.Enabled = True
    End Sub
    Private Sub UltraGridAFDAMC_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAFDAMC.AfterCellActivate
        Me.enableOpslaanButtonAFDAMC()
    End Sub
    Private Sub UltraGridAFDAMC_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridAFDAMC.AfterRowsDeleted
        Me.UltraGridAFDAMC.Enabled = True
    End Sub
#End Region
#End Region
#Region "EnableButtonOpslaan"
    Private Sub EnableOpslaanButtonAarden()
        If Me._dataAarden.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonOorzaken()
        If Me._dataOorzaken.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonInterventietypes()
        If Me._dataIntvType.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonAfdelingen()
        If Me._dataAfdelingen.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonEenheden()
        If Me._dataEenheden.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonArtikelgroepen()
        If Me._dataArtikelgroep.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonInbreuktypes()
        If Me._dataInbrType.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonRegistratietypes()
        If Me._dataRegType.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonIndividutypes()
        If Me._dataIndividutype.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonInbreukartikelen()
        If Me._dataInbrArt.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonBetrokkenentypes()
        If Me._dataTypeBetrokkene.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonVoertuigtypes()
        If Me._dataVoertuigTypes.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonAanspreektitels()
        If Me._dataAanspreektitel.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonPloegen()
        If Me._dataPloeg.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonSchadeAan()
        If Me._dataScadObjecten.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonGebruikVoertuig()
        If Me._dataGebruikVoertuig.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonWerfVoertuig()
        If Me._dataWerfVoertuig.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub enableopslaanButtonFirmas()
        If Me._dataFirmas.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub enableopslaanButtonverzFirmas()
        If Me._dataVerzFirmas.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub

    Private Sub EnableOpslaanButtonInterventieartikelen()
        If Me._dataIntvArt.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub
    Private Sub enableOpslaanButtonTypesDagverslag()
        If Me._dataDagverslagRegistratieType.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub
    Private Sub enableopslaanbuttonDagverslagInlichtingType()
        If Me._dataDagverslagInlichtingType.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub
    Private Sub enableOpslaanButtonPersoneel()
        If Me._dataBBBWPERS.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub
    Private Sub enableOpslaanButtonAFDAMC()
        If Me._dataAFDAMC.HasChanges Then
            Me.UltraButtonOpslaan.Enabled = True
        Else
            Me.UltraButtonOpslaan.Enabled = False
        End If
    End Sub
#End Region
#Region "InitializePrint"
    Private Sub UltraGridAanspreektitel_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridAanspreektitel.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Aanspreektitels"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Aanspreektitels " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridAarden_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridAarden.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Aarden"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Aarden " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridAfdelingen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridAfdelingen.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Afdelingen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Afdelingen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridArtikelgroepen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridArtikelgroepen.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Artikelgroepen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Artikelgroepen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridEenheden_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridEenheden.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Eenheden"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Eenheden " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridGebruikVoertuig_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridGebruikVoertuig.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Gebruik Voertuigen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel GebruikVoertuigen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridInbreukartikelen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridInbreukartikelen.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Inbreukartikelen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Inbreukartikelen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridInbreuktypes_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridInbreuktypes.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Inbreuktypes"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Inbreuktypes " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridIndividutypes_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridIndividutypes.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Individutypes"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Individutypes " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridInterventietypes_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridInterventietypes.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Interventietypes"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Interventietypes " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridnterventieartikelen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridnterventieartikelen.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Interventieartikelen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Interventieartikelen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridOorzaken_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridOorzaken.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Oorzaken"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Oorzaken " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridPloeg_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridPloeg.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Ploegen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Ploegen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridRegistratietype_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridRegistratietype.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Registratietypes"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Registratietypes " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridSchadeAan_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridSchadeAan.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Schade Aan"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Schade Aan " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridTypeBetrokkenen_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridTypeBetrokkenen.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Types Betrokkenen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Types Betrokkenen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridVoertuigType_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridVoertuigType.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Voertuigtypes"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Voertuigtypes " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridWerfvoertuig_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridWerfvoertuig.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Koen/Rajiv - 09/05/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel Werfvoertuigen"
            e.DefaultLogicalPageLayoutInfo.PageHeader = " Codetabel Werfvoertuigen " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridFirmas_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridFirmas.InitializePrint
        Try
            e.PrintDocument.PrinterSettings.PrintRange = Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel firma's"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Codetabel firma's " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridPersoneel_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridPersoneel.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Dien - okt. 2006
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel personeel"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Codetabel personeel " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraGridAFDAMC_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridAFDAMC.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Dien - mei. 2009
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Codetabel AFDAMC"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "AFDAMC " & Now()
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
#End Region
#Region "InitializeLayout"
    Private Sub UltraGridAarden_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAarden.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_BR_TY_INTV"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridOorzaken_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridOorzaken.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_BR_RD_INTV"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridInterventietypes_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridInterventietypes.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_INTV"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridAfdelingen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAfdelingen.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_AFD"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridEenheden_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridEenheden.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_EH"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridArtikelgroepen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridArtikelgroepen.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_GR_ART"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridInbreuktypes_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridInbreuktypes.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_INBR"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridRegistratietype_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridRegistratietype.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_REG"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridIndividutypes_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridIndividutypes.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_IND"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridInbreukartikelen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridInbreukartikelen.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_ART_INBR"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridTypeBetrokkenen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridTypeBetrokkenen.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_BTRK"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridVoertuigType_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridVoertuigType.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_TY_TSP"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridAanspreektitel_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAanspreektitel.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_IND_GSL_RAP"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridPloeg_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridPloeg.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_PLG_IND"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridSchadeAan_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridSchadeAan.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_OBJ_SCAD"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridGebruikVoertuig_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridGebruikVoertuig.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_BRK_TSP"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridWerfvoertuig_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridWerfvoertuig.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_WRF_TSP"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub UltraGridnterventieartikelen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridnterventieartikelen.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("SCF_ART_INTV"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub

    Private Sub Ultragridpersoneel_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridPersoneel.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_IND"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub
    Private Sub UltraGridFirmas_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridFirmas.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_FRM"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub
    Private Sub UltraGridAFDAMC_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAFDAMC.InitializeLayout
        e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
        Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_AFD"))
        summary.SummaryPosition = SummaryPosition.Left
        e.Layout.Bands(0).SummaryFooterCaption = ""
    End Sub
#End Region

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Me.setStatus("")
        Me.Dispose()
    End Sub



End Class
