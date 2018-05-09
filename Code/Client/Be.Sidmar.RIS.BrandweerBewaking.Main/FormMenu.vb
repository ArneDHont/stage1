Option Strict On
Option Explicit On

Imports System
Imports System.Windows.Forms


Friend Class FormMenu
    Inherits ADF.Presentation.Windows.Forms.FormBase

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        _toolTip.SetToolTip(ButtonOverviewAllInfractions, "Inbreuken op reglement intern/extern")
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
    Friend WithEvents UltraLabelBackGround As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents _ultraToolbarsManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents FormBase_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _FormBase_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormBase_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormBase_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormBase_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraGroupBoxBrandweer As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxBewaking As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButtonBEWJaarrapport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonBEWMaandrapport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonBEWOverzichtRegistraties As Infragistics.Win.Misc.UltraButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents LabelInterventietype As System.Windows.Forms.Label
    Friend WithEvents ButtonBRWNieuweInterventie As System.Windows.Forms.Button
    Friend WithEvents ButtonOverzichtInterventies As System.Windows.Forms.Button
    Friend WithEvents ButtonBRWMaandrapport As System.Windows.Forms.Button
    Friend WithEvents ButtonBRWJaarrapport As System.Windows.Forms.Button
    Friend WithEvents GroupBoxBrandweer As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxBewaking As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonBEWNieuw As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelRegistratietype As System.Windows.Forms.Label
    Friend WithEvents ButtonCodetabellen As System.Windows.Forms.Button
    Friend WithEvents UltraComboInterventieType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraComboRegistratieType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ButtonOverzichtStock As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBoxOverige As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButtonDagverslagPersoneel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonDagverslagInlichtingen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBoxMilieuDienst As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ButtonBeheerAMC As System.Windows.Forms.Button
    Friend WithEvents ButtonDiefstalOverzichtPerTrimester As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBoxDiefstalPerTrimester As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBoxSnelheidsovertredingen As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ButtonSnelheidsovertredingen As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBoxBMA As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ButtonVerzendingen As System.Windows.Forms.Button
    Friend WithEvents ButtonMateriaalOpLocatie As System.Windows.Forms.Button
    Friend WithEvents ButtonCodeTablesBM As System.Windows.Forms.Button
    Friend WithEvents ButtonDienstverslag As System.Windows.Forms.Button
    Friend WithEvents UltraGroupBoxInkoop As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ButtonIKPBewaking As System.Windows.Forms.Button
    Friend WithEvents ButtonOverviewAllInfractions As System.Windows.Forms.Button
    Friend WithEvents ButtonIKPBrandweer As System.Windows.Forms.Button
    Friend WithEvents ButtonIKPqueryCHIP As System.Windows.Forms.Button
    Friend WithEvents GroupBoxUpdateFirm As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateFGegevensBtn As System.Windows.Forms.Button
    Friend WithEvents ButtonMatAfdeling As System.Windows.Forms.Button
    Friend WithEvents ButtonOverzichtMilieuVerontr As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopUp")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("OpenInNewWindow")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("OpenInNewWindow")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UltraLabelBackGround = New Infragistics.Win.Misc.UltraLabel()
        Me._ultraToolbarsManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.FormBase_Fill_Panel = New System.Windows.Forms.Panel()
        Me.GroupBoxUpdateFirm = New System.Windows.Forms.GroupBox()
        Me.UpdateFGegevensBtn = New System.Windows.Forms.Button()
        Me.UltraGroupBoxInkoop = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonIKPqueryCHIP = New System.Windows.Forms.Button()
        Me.ButtonIKPBrandweer = New System.Windows.Forms.Button()
        Me.ButtonIKPBewaking = New System.Windows.Forms.Button()
        Me.UltraGroupBoxSnelheidsovertredingen = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonOverviewAllInfractions = New System.Windows.Forms.Button()
        Me.ButtonSnelheidsovertredingen = New System.Windows.Forms.Button()
        Me.UltraGroupBoxDiefstalPerTrimester = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonDiefstalOverzichtPerTrimester = New System.Windows.Forms.Button()
        Me.UltraGroupBoxMilieuDienst = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonBeheerAMC = New System.Windows.Forms.Button()
        Me.ButtonOverzichtMilieuVerontr = New System.Windows.Forms.Button()
        Me.UltraGroupBoxOverige = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonCodeTablesBM = New System.Windows.Forms.Button()
        Me.ButtonCodetabellen = New System.Windows.Forms.Button()
        Me.UltraGroupBoxBewaking = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButtonDagverslagInlichtingen = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonDagverslagPersoneel = New Infragistics.Win.Misc.UltraButton()
        Me.GroupBoxBewaking = New System.Windows.Forms.GroupBox()
        Me.UltraComboRegistratieType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.LabelRegistratietype = New System.Windows.Forms.Label()
        Me.UltraButtonBEWNieuw = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonBEWJaarrapport = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonBEWMaandrapport = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonBEWOverzichtRegistraties = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBoxBrandweer = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonDienstverslag = New System.Windows.Forms.Button()
        Me.UltraGroupBoxBMA = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ButtonMatAfdeling = New System.Windows.Forms.Button()
        Me.ButtonVerzendingen = New System.Windows.Forms.Button()
        Me.ButtonMateriaalOpLocatie = New System.Windows.Forms.Button()
        Me.ButtonOverzichtStock = New System.Windows.Forms.Button()
        Me.ButtonBRWJaarrapport = New System.Windows.Forms.Button()
        Me.ButtonBRWMaandrapport = New System.Windows.Forms.Button()
        Me.ButtonOverzichtInterventies = New System.Windows.Forms.Button()
        Me.GroupBoxBrandweer = New System.Windows.Forms.GroupBox()
        Me.UltraComboInterventieType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ButtonBRWNieuweInterventie = New System.Windows.Forms.Button()
        Me.LabelInterventietype = New System.Windows.Forms.Label()
        Me._FormBase_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormBase_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormBase_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormBase_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me._ultraToolbarsManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormBase_Fill_Panel.SuspendLayout()
        Me.GroupBoxUpdateFirm.SuspendLayout()
        CType(Me.UltraGroupBoxInkoop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxInkoop.SuspendLayout()
        CType(Me.UltraGroupBoxSnelheidsovertredingen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxSnelheidsovertredingen.SuspendLayout()
        CType(Me.UltraGroupBoxDiefstalPerTrimester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxDiefstalPerTrimester.SuspendLayout()
        CType(Me.UltraGroupBoxMilieuDienst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxMilieuDienst.SuspendLayout()
        CType(Me.UltraGroupBoxOverige, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxOverige.SuspendLayout()
        CType(Me.UltraGroupBoxBewaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxBewaking.SuspendLayout()
        Me.GroupBoxBewaking.SuspendLayout()
        CType(Me.UltraComboRegistratieType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBoxBrandweer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxBrandweer.SuspendLayout()
        CType(Me.UltraGroupBoxBMA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBoxBMA.SuspendLayout()
        Me.GroupBoxBrandweer.SuspendLayout()
        CType(Me.UltraComboInterventieType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_statusBar
        '
        Me._statusBar.Location = New System.Drawing.Point(0, 579)
        Me._statusBar.Size = New System.Drawing.Size(992, 26)
        '
        'UltraLabelBackGround
        '
        Me.UltraLabelBackGround.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BorderColor = System.Drawing.Color.DarkBlue
        Me.UltraLabelBackGround.Appearance = Appearance1
        Me.UltraLabelBackGround.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabelBackGround.Location = New System.Drawing.Point(3, 22)
        Me.UltraLabelBackGround.Name = "UltraLabelBackGround"
        Me.UltraLabelBackGround.Size = New System.Drawing.Size(964, 551)
        Me.UltraLabelBackGround.TabIndex = 0
        '
        '_ultraToolbarsManager
        '
        Me._ultraToolbarsManager.DesignerFlags = 1
        Me._ultraToolbarsManager.DockWithinContainer = Me
        Me._ultraToolbarsManager.DockWithinContainerBaseType = GetType(ADF.Presentation.Windows.Forms.FormBase)
        Me._ultraToolbarsManager.ShowFullMenusDelay = 500
        PopupMenuTool1.SharedPropsInternal.Caption = "PopUp"
        PopupMenuTool1.SharedPropsInternal.Category = "General"
        PopupMenuTool1.SharedPropsInternal.MergeOrder = 30
        PopupMenuTool1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        ButtonTool2.SharedPropsInternal.Caption = "Openen in nieuw venster"
        ButtonTool2.SharedPropsInternal.Category = "PopUp"
        Me._ultraToolbarsManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool1, ButtonTool2})
        '
        'FormBase_Fill_Panel
        '
        Me.FormBase_Fill_Panel.Controls.Add(Me.GroupBoxUpdateFirm)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxInkoop)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxSnelheidsovertredingen)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxDiefstalPerTrimester)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxMilieuDienst)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxOverige)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxBewaking)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraGroupBoxBrandweer)
        Me.FormBase_Fill_Panel.Controls.Add(Me.UltraLabelBackGround)
        Me.FormBase_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBase_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormBase_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.FormBase_Fill_Panel.Name = "FormBase_Fill_Panel"
        Me.FormBase_Fill_Panel.Size = New System.Drawing.Size(992, 579)
        Me.FormBase_Fill_Panel.TabIndex = 0
        '
        'GroupBoxUpdateFirm
        '
        Me.GroupBoxUpdateFirm.Controls.Add(Me.UpdateFGegevensBtn)
        Me.GroupBoxUpdateFirm.Location = New System.Drawing.Point(632, 199)
        Me.GroupBoxUpdateFirm.Name = "GroupBoxUpdateFirm"
        Me.GroupBoxUpdateFirm.Size = New System.Drawing.Size(186, 53)
        Me.GroupBoxUpdateFirm.TabIndex = 7
        Me.GroupBoxUpdateFirm.TabStop = False
        Me.GroupBoxUpdateFirm.Text = "Update BBFRM - SAP"
        Me._toolTip.SetToolTip(Me.GroupBoxUpdateFirm, "Update SAP firmanr (nodig voor CHIP)")
        '
        'UpdateFGegevensBtn
        '
        Me.UpdateFGegevensBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateFGegevensBtn.Location = New System.Drawing.Point(14, 19)
        Me.UpdateFGegevensBtn.Name = "UpdateFGegevensBtn"
        Me.UpdateFGegevensBtn.Size = New System.Drawing.Size(151, 23)
        Me.UpdateFGegevensBtn.TabIndex = 1
        Me.UpdateFGegevensBtn.Text = "Update Firma gegevens"
        Me.UpdateFGegevensBtn.UseVisualStyleBackColor = True
        '
        'UltraGroupBoxInkoop
        '
        Me.UltraGroupBoxInkoop.Controls.Add(Me.ButtonIKPqueryCHIP)
        Me.UltraGroupBoxInkoop.Controls.Add(Me.ButtonIKPBrandweer)
        Me.UltraGroupBoxInkoop.Controls.Add(Me.ButtonIKPBewaking)
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraGroupBoxInkoop.HeaderAppearance = Appearance2
        Me.UltraGroupBoxInkoop.Location = New System.Drawing.Point(418, 407)
        Me.UltraGroupBoxInkoop.Name = "UltraGroupBoxInkoop"
        Me.UltraGroupBoxInkoop.Size = New System.Drawing.Size(199, 109)
        Me.UltraGroupBoxInkoop.TabIndex = 6
        Me.UltraGroupBoxInkoop.Text = "Inkoopdienst"
        Me.UltraGroupBoxInkoop.Visible = False
        '
        'ButtonIKPqueryCHIP
        '
        Me.ButtonIKPqueryCHIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIKPqueryCHIP.Location = New System.Drawing.Point(6, 76)
        Me.ButtonIKPqueryCHIP.Name = "ButtonIKPqueryCHIP"
        Me.ButtonIKPqueryCHIP.Size = New System.Drawing.Size(187, 23)
        Me.ButtonIKPqueryCHIP.TabIndex = 2
        Me.ButtonIKPqueryCHIP.Text = "IKP bewaking query met firma"
        Me._toolTip.SetToolTip(Me.ButtonIKPqueryCHIP, "juli 2015 - nieuwe query verslagen Naar chip (maar nog niet in CHIP)")
        '
        'ButtonIKPBrandweer
        '
        Me.ButtonIKPBrandweer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIKPBrandweer.Location = New System.Drawing.Point(6, 47)
        Me.ButtonIKPBrandweer.Name = "ButtonIKPBrandweer"
        Me.ButtonIKPBrandweer.Size = New System.Drawing.Size(187, 23)
        Me.ButtonIKPBrandweer.TabIndex = 1
        Me.ButtonIKPBrandweer.Text = "Overzicht IKP brandweer"
        Me._toolTip.SetToolTip(Me.ButtonIKPBrandweer, "Overzicht brandweerverslagen met als bestemmeling IKP")
        '
        'ButtonIKPBewaking
        '
        Me.ButtonIKPBewaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIKPBewaking.Location = New System.Drawing.Point(6, 18)
        Me.ButtonIKPBewaking.Name = "ButtonIKPBewaking"
        Me.ButtonIKPBewaking.Size = New System.Drawing.Size(187, 23)
        Me.ButtonIKPBewaking.TabIndex = 0
        Me.ButtonIKPBewaking.Text = "Overzicht IKP bewaking"
        Me._toolTip.SetToolTip(Me.ButtonIKPBewaking, "Overzicht bewaking verslagen met als bestemmeling IKP")
        '
        'UltraGroupBoxSnelheidsovertredingen
        '
        Me.UltraGroupBoxSnelheidsovertredingen.Controls.Add(Me.ButtonOverviewAllInfractions)
        Me.UltraGroupBoxSnelheidsovertredingen.Controls.Add(Me.ButtonSnelheidsovertredingen)
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraGroupBoxSnelheidsovertredingen.HeaderAppearance = Appearance3
        Me.UltraGroupBoxSnelheidsovertredingen.Location = New System.Drawing.Point(218, 407)
        Me.UltraGroupBoxSnelheidsovertredingen.Name = "UltraGroupBoxSnelheidsovertredingen"
        Me.UltraGroupBoxSnelheidsovertredingen.Size = New System.Drawing.Size(194, 83)
        Me.UltraGroupBoxSnelheidsovertredingen.TabIndex = 5
        Me.UltraGroupBoxSnelheidsovertredingen.Text = "Inbreuk reglementen"
        Me.UltraGroupBoxSnelheidsovertredingen.Visible = False
        '
        'ButtonOverviewAllInfractions
        '
        Me.ButtonOverviewAllInfractions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOverviewAllInfractions.Location = New System.Drawing.Point(6, 47)
        Me.ButtonOverviewAllInfractions.Name = "ButtonOverviewAllInfractions"
        Me.ButtonOverviewAllInfractions.Size = New System.Drawing.Size(181, 23)
        Me.ButtonOverviewAllInfractions.TabIndex = 1
        Me.ButtonOverviewAllInfractions.Text = "Overzicht alle overtredingen"
        Me._toolTip.SetToolTip(Me.ButtonOverviewAllInfractions, "Snelheidsovertredingen intern/extern")
        '
        'ButtonSnelheidsovertredingen
        '
        Me.ButtonSnelheidsovertredingen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSnelheidsovertredingen.Location = New System.Drawing.Point(6, 18)
        Me.ButtonSnelheidsovertredingen.Name = "ButtonSnelheidsovertredingen"
        Me.ButtonSnelheidsovertredingen.Size = New System.Drawing.Size(181, 23)
        Me.ButtonSnelheidsovertredingen.TabIndex = 0
        Me.ButtonSnelheidsovertredingen.Text = "(Snelheidsovertredingen - oud)"
        Me._toolTip.SetToolTip(Me.ButtonSnelheidsovertredingen, "Snelheidsovertredingen intern/extern")
        '
        'UltraGroupBoxDiefstalPerTrimester
        '
        Me.UltraGroupBoxDiefstalPerTrimester.Controls.Add(Me.ButtonDiefstalOverzichtPerTrimester)
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraGroupBoxDiefstalPerTrimester.HeaderAppearance = Appearance4
        Me.UltraGroupBoxDiefstalPerTrimester.Location = New System.Drawing.Point(44, 406)
        Me.UltraGroupBoxDiefstalPerTrimester.Name = "UltraGroupBoxDiefstalPerTrimester"
        Me.UltraGroupBoxDiefstalPerTrimester.Size = New System.Drawing.Size(168, 55)
        Me.UltraGroupBoxDiefstalPerTrimester.TabIndex = 4
        Me.UltraGroupBoxDiefstalPerTrimester.Text = "Diefstallen"
        Me.UltraGroupBoxDiefstalPerTrimester.Visible = False
        '
        'ButtonDiefstalOverzichtPerTrimester
        '
        Me.ButtonDiefstalOverzichtPerTrimester.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiefstalOverzichtPerTrimester.Location = New System.Drawing.Point(22, 19)
        Me.ButtonDiefstalOverzichtPerTrimester.Name = "ButtonDiefstalOverzichtPerTrimester"
        Me.ButtonDiefstalOverzichtPerTrimester.Size = New System.Drawing.Size(132, 23)
        Me.ButtonDiefstalOverzichtPerTrimester.TabIndex = 0
        Me.ButtonDiefstalOverzichtPerTrimester.Text = "Overzicht per trimester"
        '
        'UltraGroupBoxMilieuDienst
        '
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Opaque
        Me.UltraGroupBoxMilieuDienst.ContentAreaAppearance = Appearance5
        Me.UltraGroupBoxMilieuDienst.Controls.Add(Me.ButtonBeheerAMC)
        Me.UltraGroupBoxMilieuDienst.Controls.Add(Me.ButtonOverzichtMilieuVerontr)
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.UltraGroupBoxMilieuDienst.HeaderAppearance = Appearance6
        Me.UltraGroupBoxMilieuDienst.Location = New System.Drawing.Point(44, 336)
        Me.UltraGroupBoxMilieuDienst.Name = "UltraGroupBoxMilieuDienst"
        Me.UltraGroupBoxMilieuDienst.Size = New System.Drawing.Size(573, 64)
        Me.UltraGroupBoxMilieuDienst.TabIndex = 3
        Me.UltraGroupBoxMilieuDienst.Text = "MilieuDienst"
        Me.UltraGroupBoxMilieuDienst.Visible = False
        '
        'ButtonBeheerAMC
        '
        Me.ButtonBeheerAMC.Location = New System.Drawing.Point(301, 19)
        Me.ButtonBeheerAMC.Name = "ButtonBeheerAMC"
        Me.ButtonBeheerAMC.Size = New System.Drawing.Size(250, 23)
        Me.ButtonBeheerAMC.TabIndex = 1
        Me.ButtonBeheerAMC.Text = "Beheer AMC"
        '
        'ButtonOverzichtMilieuVerontr
        '
        Me.ButtonOverzichtMilieuVerontr.Location = New System.Drawing.Point(22, 19)
        Me.ButtonOverzichtMilieuVerontr.Name = "ButtonOverzichtMilieuVerontr"
        Me.ButtonOverzichtMilieuVerontr.Size = New System.Drawing.Size(250, 23)
        Me.ButtonOverzichtMilieuVerontr.TabIndex = 0
        Me.ButtonOverzichtMilieuVerontr.Text = "Overzicht Milieuverslagen-verontreinigingen"
        Me._toolTip.SetToolTip(Me.ButtonOverzichtMilieuVerontr, "Milieuverontreinigingen brandweer en Milieuverslagen bewaking")
        '
        'UltraGroupBoxOverige
        '
        Me.UltraGroupBoxOverige.Controls.Add(Me.ButtonCodeTablesBM)
        Me.UltraGroupBoxOverige.Controls.Add(Me.ButtonCodetabellen)
        Appearance7.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Main.Resources.OnderhoudTabellen
        Me.UltraGroupBoxOverige.HeaderAppearance = Appearance7
        Me.UltraGroupBoxOverige.Location = New System.Drawing.Point(44, 516)
        Me.UltraGroupBoxOverige.Name = "UltraGroupBoxOverige"
        Me.UltraGroupBoxOverige.Size = New System.Drawing.Size(573, 55)
        Me.UltraGroupBoxOverige.TabIndex = 6
        Me.UltraGroupBoxOverige.Text = "Codetabellen"
        Me.UltraGroupBoxOverige.Visible = False
        '
        'ButtonCodeTablesBM
        '
        Me.ButtonCodeTablesBM.Location = New System.Drawing.Point(310, 19)
        Me.ButtonCodeTablesBM.Name = "ButtonCodeTablesBM"
        Me.ButtonCodeTablesBM.Size = New System.Drawing.Size(200, 23)
        Me.ButtonCodeTablesBM.TabIndex = 1
        Me.ButtonCodeTablesBM.Text = "Codetabellen Brandweer"
        Me._toolTip.SetToolTip(Me.ButtonCodeTablesBM, "Brandweer materiaal")
        '
        'ButtonCodetabellen
        '
        Me.ButtonCodetabellen.Location = New System.Drawing.Point(22, 19)
        Me.ButtonCodetabellen.Name = "ButtonCodetabellen"
        Me.ButtonCodetabellen.Size = New System.Drawing.Size(200, 23)
        Me.ButtonCodetabellen.TabIndex = 0
        Me.ButtonCodetabellen.Text = "Codetabellen"
        '
        'UltraGroupBoxBewaking
        '
        Appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Opaque
        Me.UltraGroupBoxBewaking.ContentAreaAppearance = Appearance8
        Me.UltraGroupBoxBewaking.Controls.Add(Me.UltraButtonDagverslagInlichtingen)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.UltraButtonDagverslagPersoneel)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.GroupBoxBewaking)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.UltraButtonBEWJaarrapport)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.UltraButtonBEWMaandrapport)
        Me.UltraGroupBoxBewaking.Controls.Add(Me.UltraButtonBEWOverzichtRegistraties)
        Appearance23.Image = CType(resources.GetObject("Appearance23.Image"), Object)
        Me.UltraGroupBoxBewaking.HeaderAppearance = Appearance23
        Me.UltraGroupBoxBewaking.Location = New System.Drawing.Point(44, 188)
        Me.UltraGroupBoxBewaking.Name = "UltraGroupBoxBewaking"
        Me.UltraGroupBoxBewaking.Size = New System.Drawing.Size(573, 142)
        Me.UltraGroupBoxBewaking.TabIndex = 2
        Me.UltraGroupBoxBewaking.Text = "Bewaking"
        Me.UltraGroupBoxBewaking.Visible = False
        '
        'UltraButtonDagverslagInlichtingen
        '
        Me.UltraButtonDagverslagInlichtingen.Location = New System.Drawing.Point(236, 64)
        Me.UltraButtonDagverslagInlichtingen.Name = "UltraButtonDagverslagInlichtingen"
        Me.UltraButtonDagverslagInlichtingen.Size = New System.Drawing.Size(132, 23)
        Me.UltraButtonDagverslagInlichtingen.TabIndex = 2
        Me.UltraButtonDagverslagInlichtingen.Text = "Dagverslag Inlichtingen"
        Me.UltraButtonDagverslagInlichtingen.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButtonDagverslagPersoneel
        '
        Me.UltraButtonDagverslagPersoneel.Location = New System.Drawing.Point(236, 28)
        Me.UltraButtonDagverslagPersoneel.Name = "UltraButtonDagverslagPersoneel"
        Me.UltraButtonDagverslagPersoneel.Size = New System.Drawing.Size(132, 23)
        Me.UltraButtonDagverslagPersoneel.TabIndex = 1
        Me.UltraButtonDagverslagPersoneel.Text = "Dagverslag Personeel"
        Me.UltraButtonDagverslagPersoneel.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'GroupBoxBewaking
        '
        Me.GroupBoxBewaking.Controls.Add(Me.UltraComboRegistratieType)
        Me.GroupBoxBewaking.Controls.Add(Me.LabelRegistratietype)
        Me.GroupBoxBewaking.Controls.Add(Me.UltraButtonBEWNieuw)
        Me.GroupBoxBewaking.Location = New System.Drawing.Point(12, 93)
        Me.GroupBoxBewaking.Name = "GroupBoxBewaking"
        Me.GroupBoxBewaking.Size = New System.Drawing.Size(539, 40)
        Me.GroupBoxBewaking.TabIndex = 5
        Me.GroupBoxBewaking.TabStop = False
        '
        'UltraComboRegistratieType
        '
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboRegistratieType.DisplayLayout.Appearance = Appearance9
        Me.UltraComboRegistratieType.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.UltraComboRegistratieType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboRegistratieType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboRegistratieType.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboRegistratieType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.UltraComboRegistratieType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboRegistratieType.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.UltraComboRegistratieType.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboRegistratieType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboRegistratieType.DisplayLayout.Override.ActiveCellAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Highlight
        Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboRegistratieType.DisplayLayout.Override.ActiveRowAppearance = Appearance14
        Me.UltraComboRegistratieType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboRegistratieType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboRegistratieType.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboRegistratieType.DisplayLayout.Override.CellAppearance = Appearance16
        Me.UltraComboRegistratieType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboRegistratieType.DisplayLayout.Override.CellPadding = 0
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboRegistratieType.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Left"
        Me.UltraComboRegistratieType.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.UltraComboRegistratieType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboRegistratieType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance19.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboRegistratieType.DisplayLayout.Override.RowAlternateAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboRegistratieType.DisplayLayout.Override.RowAppearance = Appearance20
        Me.UltraComboRegistratieType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboRegistratieType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance21
        Me.UltraComboRegistratieType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboRegistratieType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboRegistratieType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboRegistratieType.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboRegistratieType.Location = New System.Drawing.Point(108, 12)
        Me.UltraComboRegistratieType.MaxDropDownItems = 10
        Me.UltraComboRegistratieType.Name = "UltraComboRegistratieType"
        Me.UltraComboRegistratieType.Size = New System.Drawing.Size(136, 22)
        Me.UltraComboRegistratieType.TabIndex = 1
        Me.UltraComboRegistratieType.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'LabelRegistratietype
        '
        Me.LabelRegistratietype.Location = New System.Drawing.Point(4, 12)
        Me.LabelRegistratietype.Name = "LabelRegistratietype"
        Me.LabelRegistratietype.Size = New System.Drawing.Size(80, 23)
        Me.LabelRegistratietype.TabIndex = 0
        Me.LabelRegistratietype.Text = "Registratietype"
        Me.LabelRegistratietype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraButtonBEWNieuw
        '
        Appearance22.Image = CType(resources.GetObject("Appearance22.Image"), Object)
        Me.UltraButtonBEWNieuw.Appearance = Appearance22
        Me.UltraButtonBEWNieuw.Location = New System.Drawing.Point(268, 12)
        Me.UltraButtonBEWNieuw.Name = "UltraButtonBEWNieuw"
        Me.UltraButtonBEWNieuw.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonBEWNieuw.TabIndex = 2
        Me.UltraButtonBEWNieuw.Text = "Nieuw"
        Me.UltraButtonBEWNieuw.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButtonBEWJaarrapport
        '
        Me.UltraButtonBEWJaarrapport.Location = New System.Drawing.Point(419, 64)
        Me.UltraButtonBEWJaarrapport.Name = "UltraButtonBEWJaarrapport"
        Me.UltraButtonBEWJaarrapport.Size = New System.Drawing.Size(132, 23)
        Me.UltraButtonBEWJaarrapport.TabIndex = 4
        Me.UltraButtonBEWJaarrapport.Text = "Jaarrapport"
        Me.UltraButtonBEWJaarrapport.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButtonBEWMaandrapport
        '
        Me.UltraButtonBEWMaandrapport.Location = New System.Drawing.Point(420, 28)
        Me.UltraButtonBEWMaandrapport.Name = "UltraButtonBEWMaandrapport"
        Me.UltraButtonBEWMaandrapport.Size = New System.Drawing.Size(131, 23)
        Me.UltraButtonBEWMaandrapport.TabIndex = 3
        Me.UltraButtonBEWMaandrapport.Text = "Maandrapport"
        Me.UltraButtonBEWMaandrapport.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraButtonBEWOverzichtRegistraties
        '
        Me.UltraButtonBEWOverzichtRegistraties.Location = New System.Drawing.Point(22, 28)
        Me.UltraButtonBEWOverzichtRegistraties.Name = "UltraButtonBEWOverzichtRegistraties"
        Me.UltraButtonBEWOverzichtRegistraties.Size = New System.Drawing.Size(132, 23)
        Me.UltraButtonBEWOverzichtRegistraties.TabIndex = 0
        Me.UltraButtonBEWOverzichtRegistraties.Text = "Overzicht Registraties"
        Me.UltraButtonBEWOverzichtRegistraties.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBoxBrandweer
        '
        Appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Opaque
        Me.UltraGroupBoxBrandweer.ContentAreaAppearance = Appearance24
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.ButtonDienstverslag)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.UltraGroupBoxBMA)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.ButtonBRWJaarrapport)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.ButtonBRWMaandrapport)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.ButtonOverzichtInterventies)
        Me.UltraGroupBoxBrandweer.Controls.Add(Me.GroupBoxBrandweer)
        Appearance38.Image = CType(resources.GetObject("Appearance38.Image"), Object)
        Me.UltraGroupBoxBrandweer.HeaderAppearance = Appearance38
        Me.UltraGroupBoxBrandweer.Location = New System.Drawing.Point(44, 40)
        Me.UltraGroupBoxBrandweer.Name = "UltraGroupBoxBrandweer"
        Me.UltraGroupBoxBrandweer.Size = New System.Drawing.Size(774, 142)
        Me.UltraGroupBoxBrandweer.TabIndex = 1
        Me.UltraGroupBoxBrandweer.Text = "Brandweer"
        Me.UltraGroupBoxBrandweer.Visible = False
        '
        'ButtonDienstverslag
        '
        Me.ButtonDienstverslag.Location = New System.Drawing.Point(22, 64)
        Me.ButtonDienstverslag.Name = "ButtonDienstverslag"
        Me.ButtonDienstverslag.Size = New System.Drawing.Size(132, 23)
        Me.ButtonDienstverslag.TabIndex = 1
        Me.ButtonDienstverslag.Text = "Dienstverslag"
        Me.ButtonDienstverslag.UseVisualStyleBackColor = True
        '
        'UltraGroupBoxBMA
        '
        Me.UltraGroupBoxBMA.Controls.Add(Me.ButtonMatAfdeling)
        Me.UltraGroupBoxBMA.Controls.Add(Me.ButtonVerzendingen)
        Me.UltraGroupBoxBMA.Controls.Add(Me.ButtonMateriaalOpLocatie)
        Me.UltraGroupBoxBMA.Controls.Add(Me.ButtonOverzichtStock)
        Me.UltraGroupBoxBMA.Location = New System.Drawing.Point(380, 21)
        Me.UltraGroupBoxBMA.Name = "UltraGroupBoxBMA"
        Me.UltraGroupBoxBMA.Size = New System.Drawing.Size(379, 115)
        Me.UltraGroupBoxBMA.TabIndex = 5
        Me.UltraGroupBoxBMA.Text = "Brandweermateriaal"
        '
        'ButtonMatAfdeling
        '
        Me.ButtonMatAfdeling.Image = CType(resources.GetObject("ButtonMatAfdeling.Image"), System.Drawing.Image)
        Me.ButtonMatAfdeling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMatAfdeling.Location = New System.Drawing.Point(222, 24)
        Me.ButtonMatAfdeling.Name = "ButtonMatAfdeling"
        Me.ButtonMatAfdeling.Size = New System.Drawing.Size(151, 23)
        Me.ButtonMatAfdeling.TabIndex = 3
        Me.ButtonMatAfdeling.Text = "Mat. op locatie - afd"
        Me._toolTip.SetToolTip(Me.ButtonMatAfdeling, "Materiaal op locatie - voor afdeling KWA (afdelinguser)")
        Me.ButtonMatAfdeling.UseVisualStyleBackColor = True
        '
        'ButtonVerzendingen
        '
        Me.ButtonVerzendingen.Image = CType(resources.GetObject("ButtonVerzendingen.Image"), System.Drawing.Image)
        Me.ButtonVerzendingen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVerzendingen.Location = New System.Drawing.Point(30, 53)
        Me.ButtonVerzendingen.Name = "ButtonVerzendingen"
        Me.ButtonVerzendingen.Size = New System.Drawing.Size(147, 23)
        Me.ButtonVerzendingen.TabIndex = 1
        Me.ButtonVerzendingen.Text = "Verzendingen"
        Me._toolTip.SetToolTip(Me.ButtonVerzendingen, "Verzending brandweermateriaal")
        Me.ButtonVerzendingen.UseVisualStyleBackColor = True
        '
        'ButtonMateriaalOpLocatie
        '
        Me.ButtonMateriaalOpLocatie.Image = CType(resources.GetObject("ButtonMateriaalOpLocatie.Image"), System.Drawing.Image)
        Me.ButtonMateriaalOpLocatie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMateriaalOpLocatie.Location = New System.Drawing.Point(30, 24)
        Me.ButtonMateriaalOpLocatie.Name = "ButtonMateriaalOpLocatie"
        Me.ButtonMateriaalOpLocatie.Size = New System.Drawing.Size(147, 23)
        Me.ButtonMateriaalOpLocatie.TabIndex = 0
        Me.ButtonMateriaalOpLocatie.Text = "Materiaal op locatie"
        Me._toolTip.SetToolTip(Me.ButtonMateriaalOpLocatie, "Materiaal op locatie (brandweer)")
        Me.ButtonMateriaalOpLocatie.UseVisualStyleBackColor = True
        '
        'ButtonOverzichtStock
        '
        Me.ButtonOverzichtStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOverzichtStock.Location = New System.Drawing.Point(30, 83)
        Me.ButtonOverzichtStock.Name = "ButtonOverzichtStock"
        Me.ButtonOverzichtStock.Size = New System.Drawing.Size(147, 23)
        Me.ButtonOverzichtStock.TabIndex = 2
        Me.ButtonOverzichtStock.Text = "Overzicht Stock"
        '
        'ButtonBRWJaarrapport
        '
        Me.ButtonBRWJaarrapport.Location = New System.Drawing.Point(259, 64)
        Me.ButtonBRWJaarrapport.Name = "ButtonBRWJaarrapport"
        Me.ButtonBRWJaarrapport.Size = New System.Drawing.Size(92, 23)
        Me.ButtonBRWJaarrapport.TabIndex = 3
        Me.ButtonBRWJaarrapport.Text = "Jaarrapport"
        '
        'ButtonBRWMaandrapport
        '
        Me.ButtonBRWMaandrapport.Location = New System.Drawing.Point(259, 28)
        Me.ButtonBRWMaandrapport.Name = "ButtonBRWMaandrapport"
        Me.ButtonBRWMaandrapport.Size = New System.Drawing.Size(92, 23)
        Me.ButtonBRWMaandrapport.TabIndex = 2
        Me.ButtonBRWMaandrapport.Text = "Maandrapport"
        '
        'ButtonOverzichtInterventies
        '
        Me.ButtonOverzichtInterventies.Location = New System.Drawing.Point(22, 28)
        Me.ButtonOverzichtInterventies.Name = "ButtonOverzichtInterventies"
        Me.ButtonOverzichtInterventies.Size = New System.Drawing.Size(132, 23)
        Me.ButtonOverzichtInterventies.TabIndex = 0
        Me.ButtonOverzichtInterventies.Text = "Overzicht Interventies"
        '
        'GroupBoxBrandweer
        '
        Me.GroupBoxBrandweer.Controls.Add(Me.UltraComboInterventieType)
        Me.GroupBoxBrandweer.Controls.Add(Me.ButtonBRWNieuweInterventie)
        Me.GroupBoxBrandweer.Controls.Add(Me.LabelInterventietype)
        Me.GroupBoxBrandweer.Location = New System.Drawing.Point(12, 93)
        Me.GroupBoxBrandweer.Name = "GroupBoxBrandweer"
        Me.GroupBoxBrandweer.Size = New System.Drawing.Size(356, 40)
        Me.GroupBoxBrandweer.TabIndex = 4
        Me.GroupBoxBrandweer.TabStop = False
        '
        'UltraComboInterventieType
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraComboInterventieType.DisplayLayout.Appearance = Appearance25
        Me.UltraComboInterventieType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraComboInterventieType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboInterventieType.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboInterventieType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.UltraComboInterventieType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraComboInterventieType.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.UltraComboInterventieType.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraComboInterventieType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraComboInterventieType.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraComboInterventieType.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.UltraComboInterventieType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraComboInterventieType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.UltraComboInterventieType.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraComboInterventieType.DisplayLayout.Override.CellAppearance = Appearance32
        Me.UltraComboInterventieType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraComboInterventieType.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraComboInterventieType.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.UltraComboInterventieType.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.UltraComboInterventieType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraComboInterventieType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Info
        Me.UltraComboInterventieType.DisplayLayout.Override.RowAlternateAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Me.UltraComboInterventieType.DisplayLayout.Override.RowAppearance = Appearance36
        Me.UltraComboInterventieType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraComboInterventieType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance37
        Me.UltraComboInterventieType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraComboInterventieType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraComboInterventieType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraComboInterventieType.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.UltraComboInterventieType.Location = New System.Drawing.Point(108, 12)
        Me.UltraComboInterventieType.Name = "UltraComboInterventieType"
        Me.UltraComboInterventieType.Size = New System.Drawing.Size(136, 22)
        Me.UltraComboInterventieType.TabIndex = 1
        Me.UltraComboInterventieType.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ButtonBRWNieuweInterventie
        '
        Me.ButtonBRWNieuweInterventie.Image = CType(resources.GetObject("ButtonBRWNieuweInterventie.Image"), System.Drawing.Image)
        Me.ButtonBRWNieuweInterventie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBRWNieuweInterventie.Location = New System.Drawing.Point(264, 11)
        Me.ButtonBRWNieuweInterventie.Name = "ButtonBRWNieuweInterventie"
        Me.ButtonBRWNieuweInterventie.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBRWNieuweInterventie.TabIndex = 2
        Me.ButtonBRWNieuweInterventie.Text = "    Nieuw"
        '
        'LabelInterventietype
        '
        Me.LabelInterventietype.Location = New System.Drawing.Point(12, 15)
        Me.LabelInterventietype.Name = "LabelInterventietype"
        Me.LabelInterventietype.Size = New System.Drawing.Size(80, 16)
        Me.LabelInterventietype.TabIndex = 0
        Me.LabelInterventietype.Text = "Interventietype"
        '
        '_FormBase_Toolbars_Dock_Area_Left
        '
        Me._FormBase_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormBase_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._FormBase_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._FormBase_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormBase_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._FormBase_Toolbars_Dock_Area_Left.Name = "_FormBase_Toolbars_Dock_Area_Left"
        Me._FormBase_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 579)
        Me._FormBase_Toolbars_Dock_Area_Left.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormBase_Toolbars_Dock_Area_Right
        '
        Me._FormBase_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormBase_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._FormBase_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._FormBase_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormBase_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(992, 0)
        Me._FormBase_Toolbars_Dock_Area_Right.Name = "_FormBase_Toolbars_Dock_Area_Right"
        Me._FormBase_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 579)
        Me._FormBase_Toolbars_Dock_Area_Right.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormBase_Toolbars_Dock_Area_Top
        '
        Me._FormBase_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormBase_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._FormBase_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._FormBase_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormBase_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._FormBase_Toolbars_Dock_Area_Top.Name = "_FormBase_Toolbars_Dock_Area_Top"
        Me._FormBase_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(992, 0)
        Me._FormBase_Toolbars_Dock_Area_Top.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormBase_Toolbars_Dock_Area_Bottom
        '
        Me._FormBase_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormBase_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._FormBase_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._FormBase_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormBase_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 579)
        Me._FormBase_Toolbars_Dock_Area_Bottom.Name = "_FormBase_Toolbars_Dock_Area_Bottom"
        Me._FormBase_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(992, 0)
        Me._FormBase_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me._ultraToolbarsManager
        '
        'FormMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 605)
        Me.Controls.Add(Me.FormBase_Fill_Panel)
        Me.Controls.Add(Me._FormBase_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._FormBase_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._FormBase_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._FormBase_Toolbars_Dock_Area_Top)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMenu"
        Me.Text = "Hoofdmenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me._FormBase_Toolbars_Dock_Area_Top, 0)
        Me.Controls.SetChildIndex(Me._statusBar, 0)
        Me.Controls.SetChildIndex(Me._FormBase_Toolbars_Dock_Area_Bottom, 0)
        Me.Controls.SetChildIndex(Me._FormBase_Toolbars_Dock_Area_Right, 0)
        Me.Controls.SetChildIndex(Me._FormBase_Toolbars_Dock_Area_Left, 0)
        Me.Controls.SetChildIndex(Me.FormBase_Fill_Panel, 0)
        CType(Me._ultraToolbarsManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormBase_Fill_Panel.ResumeLayout(False)
        Me.GroupBoxUpdateFirm.ResumeLayout(False)
        CType(Me.UltraGroupBoxInkoop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxInkoop.ResumeLayout(False)
        CType(Me.UltraGroupBoxSnelheidsovertredingen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxSnelheidsovertredingen.ResumeLayout(False)
        CType(Me.UltraGroupBoxDiefstalPerTrimester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxDiefstalPerTrimester.ResumeLayout(False)
        CType(Me.UltraGroupBoxMilieuDienst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxMilieuDienst.ResumeLayout(False)
        CType(Me.UltraGroupBoxOverige, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxOverige.ResumeLayout(False)
        CType(Me.UltraGroupBoxBewaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxBewaking.ResumeLayout(False)
        Me.GroupBoxBewaking.ResumeLayout(False)
        Me.GroupBoxBewaking.PerformLayout()
        CType(Me.UltraComboRegistratieType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBoxBrandweer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxBrandweer.ResumeLayout(False)
        CType(Me.UltraGroupBoxBMA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBoxBMA.ResumeLayout(False)
        Me.GroupBoxBrandweer.ResumeLayout(False)
        Me.GroupBoxBrandweer.PerformLayout()
        CType(Me.UltraComboInterventieType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private _ButtonClicked As Infragistics.Win.Misc.UltraButton
    Private _controller As Client.ControllerGetData
    Private WithEvents _dataRegType As New Client.TDSRegType
    Private WithEvents _dataIntvType As New Client.TDSIntvType

    Public Class ToolKeys

        Public Const PopUp As String = "PopUp"
        Public Const OpenInNewWindow As String = "OpenInNewWindow"

    End Class

    Public Class ControlNames

        Public Const UltraButtonPostalCodeEntity As String = "UltraButtonPostalCodeEntity"
        Public Const UltraButtonPostalCodeEntityWithSelection As String = "UltraButtonPostalCodeEntityWithSelection"
        Public Const UltraButtonPersonEntity As String = "UltraButtonPersonEntity"
        Public Const UltraButtonOrganisationEntity As String = "UltraButtonOrganisationEntity"

        Public Const UltraButtonPostalCodeSelection As String = "UltraButtonPostalCodeSelection"
        Public Const UltraButtonPersonSelection As String = "UltraButtonPersonSelection"
        Public Const UltraButtonOrganisationSelection As String = "UltraButtonOrganisationSelection"

    End Class

    Private Sub FormMenu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        BindComboInterventieTypes()
        BindComboRegistratieTypes()
        _ultraToolbarsManager.Visible = False
        SetEnablements()

        ' ***************************
        ' *** Temporary test code ***
        ' ***************************
        Dim activeUser As String = Environ("USERNAME").ToUpperInvariant()
        Dim isTester As Boolean = True ' (activeUser = "SIDGMAE" OrElse activeUser = "SIDNACO")
        ButtonMateriaalOpLocatie.Enabled = isTester
        ButtonVerzendingen.Enabled = isTester
        ' ***************************
    End Sub

    Private ReadOnly Property MyParent As FormMainMDI
        Get
            Return DirectCast(MdiParent, FormMainMDI)
        End Get
    End Property

    Private Sub BindComboInterventieTypes()
        Try
            _controller = New Client.ControllerGetData
            _dataIntvType.Merge(_controller.GetInterventieType())

            UltraComboInterventieType.DataSource = _dataIntvType
            UltraComboInterventieType.ValueMember = "BBINTVTY.ID_TY_INTV"
            UltraComboInterventieType.DisplayMember = "BBINTVTY.SCF_TY_INTV"

            UltraComboInterventieType.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UltraComboInterventieType.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Interventietype"
            UltraComboInterventieType.DisplayLayout.Bands(0).Columns(1).Width = 136
            UltraComboInterventieType.Value = 1
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormBrandweerOverzichtInterventies - bindComboInterventieTypes" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub BindComboRegistratieTypes()
        Try
            _controller = New Client.ControllerGetData
            _dataRegType.Merge(_controller.GetRegistratieType)

            UltraComboRegistratieType.DataSource = _dataRegType
            UltraComboRegistratieType.DisplayMember = "BBREGTY.SCF_TY_REG"
            UltraComboRegistratieType.ValueMember = "BBREGTY.ID_TY_REG"

            UltraComboRegistratieType.DisplayLayout.Bands(0).Columns(0).Hidden = True
            UltraComboRegistratieType.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Registratietype"
            UltraComboRegistratieType.DisplayLayout.Bands(0).Columns(1).Width = 136
            UltraComboRegistratieType.Value = 1
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormMenu - Button1_Click" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Overrides Sub SetEnablements()
        With _ultraToolbarsManager.Tools
            .Item(ToolKeys.PopUp).SharedProps.Visible = False
        End With
    End Sub

#Region "Bewaking"
    Private Sub UltraButtonBEWOverzichtRegistraties_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonBEWOverzichtRegistraties.Click
        MyParent.OverzichtRegistratiesBewakingEntity(False, True, True)
    End Sub

    Private Sub UltraButtonBEWDienstverslag_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        MyParent.NieuwDienstverslagBewakingEntity(False, True, True)
    End Sub

    Private Sub UltraButtonBEWMaandrapport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonBEWMaandrapport.Click
        MyParent.MaandrapportBewakingEntity(False, True, True)
    End Sub

    Private Sub UltraButtonBEWJaarrapport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonBEWJaarrapport.Click
        MyParent.JaarrapportBewakingEntity(False, True, True)
    End Sub

    Private Sub UltraButtonDagverslagPersoneel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonDagverslagPersoneel.Click
        'Doel:   nieuwe form voor dagverslag personeel
        'Auteur: Nancy Coppens - 14/09/2006
        MyParent.ToonFormDagverslagPersoneelOverzicht(False, True, True)
    End Sub


    Private Sub UltraButtonDagverslagInlichtingen_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonDagverslagInlichtingen.Click
        'Doel:  nieuwe form voor dagverslag personeel type
        'Auteur: DIEN - okt 2006
        MyParent.ToonFormDagverslagInlichtingen(False, True, True)
    End Sub

    Private Sub UltraButtonBEWNieuw_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles UltraButtonBEWNieuw.Click
        Select Case CInt(UltraComboRegistratieType.SelectedRow.Cells("ID_TY_REG").Value)
            Case 1
                MyParent.Aanrijding(False, True, True)
            Case 2
                MyParent.ControleVoertuig(False, True, True)
            Case 3
                MyParent.Diefstal(False, True, True)
            Case 4
                MyParent.InbreukReglementen(False, True, True)
            Case 5
                MyParent.Schadegeval(False, True, True)
            Case 6
                MyParent.OpenmakenKleerkast(False, True, True)
            Case 7
                MyParent.Diversen(False, True, True)
            Case 8
                MyParent.Alcoholtest(False, True, True)
            Case 9
                MyParent.ToonFormBewakingMilieuVerslag(False, True, True)
            Case Else
                MessageBox.Show("Gelieve een registratietype te selecteren.", "Registratie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

#End Region

#Region "Brandweer"
    Private Sub ButtonBRWNieuweInterventieClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonBRWNieuweInterventie.Click
        If UltraComboInterventieType.SelectedRow Is Nothing Then
            MessageBox.Show("Gelieve een interventietype te kiezen", "BBW Brandweer Bewaking Verslagen", _
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MyParent.NieuweInterventieBrandweerEntity(False, False, True, DirectCast(UltraComboInterventieType.Value, Integer), DirectCast(UltraComboInterventieType.Text, String))
        End If
    End Sub

    Private Sub ButtonOverzichtInterventiesClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonOverzichtInterventies.Click
        MyParent.OverzichtInterventiesBrandweerEntity(False, True, True)
    End Sub

    'Private Sub ButtonBRWDienstverslag_Click(ByVal sender As System.Object, ByVal e As EventArgs)
    '    MyParent.NieuwDienstverslagBrandweerEntity(False, True, True)
    'End Sub

    Private Sub ButtonDienstverslagClick(sender As Object, e As EventArgs) Handles ButtonDienstverslag.Click
        MyParent.DienstverslagOverzichtEntity(False, True, True)
    End Sub

    Private Sub ButtonBRWMaandrapportClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonBRWMaandrapport.Click
        MyParent.MaandrapportBrandweerEntity(False, True, True)
    End Sub

    Private Sub ButtonBRWJaarrapportClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonBRWJaarrapport.Click
        MyParent.JaarrapportBrandweerEntity(False, True, True)
    End Sub

    Private Sub ButtonMateriaalOpLocatieClick(sender As System.Object, e As EventArgs) Handles ButtonMateriaalOpLocatie.Click
        MyParent.OverzichtMateriaalOpLocatie(False, True, True)
    End Sub

    Private Sub ButtonVerzendingenClick(sender As System.Object, e As EventArgs) Handles ButtonVerzendingen.Click
        MyParent.OverzichtBrandweerVerzendingen(False, True, True)
    End Sub

    Private Sub ButtonOverzichtStockClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonOverzichtStock.Click
        MyParent.OverzichtStockBrandweerEntity(False, True, True)
    End Sub
#End Region

#Region "Milieudienst"
    Private Sub ButtonOverzichtMilieuVerontr_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonOverzichtMilieuVerontr.Click
        MyParent.OverzichtMilieuverontreinigingenEntity(False, True, True)
    End Sub
#End Region

#Region "Diefstal"
    Private Sub ButtonDiefstalOverzichtPerTrimester_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDiefstalOverzichtPerTrimester.Click
        MyParent.OverzichtDiefstalPerTrimesterEntity(False, True, True)
    End Sub
#End Region

#Region "Codetabellen"

    Private Sub ButtonCodetabellen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonCodetabellen.Click
        If MyParent.CurrentFormManager.Brandweer = True Then
            'voor de brandweer: om paswoord vragen
            If InputBox("Gelieve het paswoord in te geven voor onderhoud tabellen aub:", "Paswoord 'Onderhoud tabellen'") = "guido" Then
                MyParent.CodetabellenEntity(False, True, True)
            Else
                MessageBox.Show("Geen geldig paswoord", "Paswoord", MessageBoxButtons.OK)
            End If
        Else
            MyParent.CodetabellenEntity(False, True, True)
        End If
    End Sub

    Private Sub ButtonCodeTablesBM_Click(sender As Object, e As EventArgs) Handles ButtonCodeTablesBM.Click
        MyParent.ToonFormBrandweerCodetables(False, True, True)
    End Sub

#End Region

#Region "AMC"

    Private Sub btnBeheerAMC_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonBeheerAMC.Click
        MyParent.OverzichtBeheerAmcEntity(False, True, True)
    End Sub

#End Region

#Region "Snelheidsovertredingen"

    Private Sub ButtonSnelheidsovertredingen_Click(sender As Object, e As EventArgs) Handles ButtonSnelheidsovertredingen.Click
        MessageBox.Show("Dit scherm dient enkel ter raadpleging." & Environment.NewLine &
                        "Voor het afdrukken van brieven, gelieve het scherm: 'Overzicht alle overtredingen' te gebruiken.",
                        "Dit scherm is enkel ter raadpleging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        MyParent.OverzichtSnelheidsovertredingenEntity(False, True, True)
    End Sub

    Private Sub ButtonOverviewAllInfractions_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOverviewAllInfractions.Click
        MyParent.OverzichtOvertredingenEntity(False, True, True)
    End Sub

#End Region

    Private Sub ButtonIKP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIKPBewaking.Click
        MyParent.OverzichtInkoopEntity(False, True, True)
    End Sub

    Private Sub ButtonIKPBrandweer_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIKPBrandweer.Click
        MyParent.OverzichtInkoopBrandweerEntity(False, True, True)
    End Sub

    Private Sub ButtonIKPqueryCHIP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIKPqueryCHIP.Click
        MyParent.OverzichtIKPQuerymetFirma(False, True, True)
    End Sub

    Private Sub UpdateFGegevensBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateFGegevensBtn.Click
        MyParent.ToonFormUpdateFirmas(False, True, True)
    End Sub

    Private Sub ButtonMatAfdeling_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMatAfdeling.Click
        MyParent.OverzichtMateriaalOpLocatieAfdeling(False, True, True)
    End Sub
End Class
