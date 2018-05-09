Option Strict On
Option Explicit On
Option Infer On

Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.Linq
Imports System.Windows.Forms

Imports ADF.Windows.Forms
Imports ADF.Presentation.Windows
Imports ADF.Presentation.Windows.ApplicationSecurity
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinTree
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt


Friend Class FormMainMDI
    Inherits Forms.FormBase

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
    Friend WithEvents _ultraToolbarsManager As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _FormMainMDI_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormMainMDI_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormMainMDI_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FormMainMDI_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _ultraTabbedMdiManager As Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager
    Friend WithEvents _ultraDockManager As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _FormMainMDIUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FormMainMDIUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FormMainMDIUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _FormMainMDIUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _timerOnderhoud As System.Windows.Forms.Timer
    Friend WithEvents _FormMainMDIAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("menu")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Application")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MDIEntity")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Windows")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Help")
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("toolBar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MainMenu")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOn")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOff")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CloseApplication")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOn")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainMDI))
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOff")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CloseApplication")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool5 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Application")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MainMenu")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOn")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("LogOff")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CloseApplication")
        Dim PopupMenuTool6 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Help")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("About")
        Dim ButtonTool55 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("UserManualBMA")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("About")
        Dim PopupMenuTool7 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MDIEntity")
        Dim PopupMenuTool8 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Brandweer")
        Dim PopupMenuTool9 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Bewaking")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Codetabellen")
        Dim ButtonTool51 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Update Firma")
        Dim PopupMenuTool10 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MDISelection")
        Dim PopupMenuTool11 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Windows")
        Dim StateButtonTool1 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("TabPages", "")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cascade")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vertical")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Horizontal")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MinimizeAll")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MaximizeAll")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CloseAll")
        Dim MdiWindowListTool1 As Infragistics.Win.UltraWinToolbars.MdiWindowListTool = New Infragistics.Win.UltraWinToolbars.MdiWindowListTool("MDIWindowList")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cascade")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Vertical")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Horizontal")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MinimizeAll")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MaximizeAll")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("CloseAll")
        Dim MdiWindowListTool2 As Infragistics.Win.UltraWinToolbars.MdiWindowListTool = New Infragistics.Win.UltraWinToolbars.MdiWindowListTool("MDIWindowList")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("MainMenu")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim StateButtonTool2 As Infragistics.Win.UltraWinToolbars.StateButtonTool = New Infragistics.Win.UltraWinToolbars.StateButtonTool("TabPages", "")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("TreeMainMenu")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool12 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("MDIReports")
        Dim PopupMenuTool13 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Brandweer")
        Dim ButtonTool29 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Nieuwe Interventie")
        Dim ButtonTool30 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Overzicht Interventies")
        Dim ButtonTool31 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Maandrapport")
        Dim ButtonTool32 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Jaarrapport")
        Dim ButtonTool33 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Overzicht Stock")
        Dim PopupMenuTool14 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Bewaking")
        Dim ButtonTool34 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Nieuwe Registratie")
        Dim ButtonTool35 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Overzicht Registraties")
        Dim ButtonTool36 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Maandrapport")
        Dim ButtonTool37 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Jaarrapport")
        Dim ButtonTool38 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Nieuw Dienstverslag")
        Dim ButtonTool39 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Nieuwe Interventie")
        Dim ButtonTool40 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Overzicht Interventies")
        Dim ButtonTool41 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Jaarrapport")
        Dim ButtonTool42 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BRW Maandrapport")
        Dim ButtonTool43 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Nieuw Dienstverslag")
        Dim ButtonTool44 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Jaarrapport")
        Dim ButtonTool45 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Maandrapport")
        Dim ButtonTool46 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Overzicht Registraties")
        Dim ButtonTool47 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Codetabellen")
        Dim ButtonTool48 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Overzicht Stock")
        Dim ButtonTool49 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool50 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("BEW Nieuwe Registratie")
        Dim ComboBoxTool1 As Infragistics.Win.UltraWinToolbars.ComboBoxTool = New Infragistics.Win.UltraWinToolbars.ComboBoxTool("ComboBoxTool1")
        Dim ValueList1 As Infragistics.Win.ValueList = New Infragistics.Win.ValueList(0)
        Dim MdiWindowListTool3 As Infragistics.Win.UltraWinToolbars.MdiWindowListTool = New Infragistics.Win.UltraWinToolbars.MdiWindowListTool("MDIWindowListTool1")
        Dim ButtonTool52 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Update Firma")
        Dim LabelTool4 As Infragistics.Win.UltraWinToolbars.LabelTool = New Infragistics.Win.UltraWinToolbars.LabelTool("UserManual")
        Dim ButtonTool54 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Gebruikershandleiding Brandweermateriaal")
        Dim ButtonTool56 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("UserManualBMA")
        Me._ultraToolbarsManager = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._FormMainMDI_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormMainMDI_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormMainMDI_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._ultraTabbedMdiManager = New Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(Me.components)
        Me._ultraDockManager = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._FormMainMDIUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FormMainMDIUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FormMainMDIUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FormMainMDIUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._FormMainMDIAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me._timerOnderhoud = New System.Windows.Forms.Timer(Me.components)
        CType(Me._ultraToolbarsManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ultraTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ultraDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_statusBar
        '
        Me._statusBar.Location = New System.Drawing.Point(0, 624)
        Me._statusBar.Size = New System.Drawing.Size(844, 26)
        Me._statusBar.UseHistoryList = True
        '
        '_ultraToolbarsManager
        '
        Me._ultraToolbarsManager.DesignerFlags = 1
        Me._ultraToolbarsManager.DockWithinContainer = Me
        Me._ultraToolbarsManager.DockWithinContainerBaseType = GetType(ADF.Presentation.Windows.Forms.FormBase)
        Me._ultraToolbarsManager.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingSize = New System.Drawing.Size(113, 60)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool1, PopupMenuTool2, PopupMenuTool3, PopupMenuTool4})
        UltraToolbar1.Text = "menu"
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 1
        ButtonTool2.InstanceProps.IsFirstInGroup = True
        ButtonTool3.InstanceProps.IsFirstInGroup = True
        ButtonTool4.InstanceProps.IsFirstInGroup = True
        UltraToolbar2.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4})
        UltraToolbar2.Text = "toolBar"
        Me._ultraToolbarsManager.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1, UltraToolbar2})
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance1
        ButtonTool5.SharedPropsInternal.Caption = "Aanmelden..."
        ButtonTool5.SharedPropsInternal.Category = "Application"
        ButtonTool5.SharedPropsInternal.ToolTipText = "Aanmelden..."
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance2
        ButtonTool6.SharedPropsInternal.Caption = "Afmelden"
        ButtonTool6.SharedPropsInternal.Category = "Application"
        ButtonTool6.SharedPropsInternal.ToolTipText = "Afmelden"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        ButtonTool7.SharedPropsInternal.AppearancesSmall.Appearance = Appearance3
        ButtonTool7.SharedPropsInternal.Caption = "Afsluiten"
        ButtonTool7.SharedPropsInternal.Category = "Application"
        ButtonTool7.SharedPropsInternal.ToolTipText = "Afsluiten"
        PopupMenuTool5.SharedPropsInternal.Caption = "Toepassing"
        PopupMenuTool5.SharedPropsInternal.Category = "General"
        ButtonTool8.InstanceProps.IsFirstInGroup = True
        ButtonTool9.InstanceProps.IsFirstInGroup = True
        ButtonTool10.InstanceProps.IsFirstInGroup = True
        ButtonTool11.InstanceProps.IsFirstInGroup = True
        PopupMenuTool5.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11})
        PopupMenuTool6.SharedPropsInternal.Caption = "Help"
        PopupMenuTool6.SharedPropsInternal.Category = "General"
        PopupMenuTool6.SharedPropsInternal.MergeOrder = 100
        ButtonTool12.InstanceProps.IsFirstInGroup = True
        PopupMenuTool6.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool12, ButtonTool55})
        ButtonTool13.SharedPropsInternal.Caption = "About..."
        ButtonTool13.SharedPropsInternal.Category = "Help"
        PopupMenuTool7.SharedPropsInternal.Caption = "Beheer"
        PopupMenuTool7.SharedPropsInternal.Category = "General"
        PopupMenuTool7.SharedPropsInternal.MergeOrder = 10
        PopupMenuTool7.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool8, PopupMenuTool9, ButtonTool14, ButtonTool51})
        PopupMenuTool10.SharedPropsInternal.Caption = "Zoeken"
        PopupMenuTool10.SharedPropsInternal.Category = "General"
        PopupMenuTool10.SharedPropsInternal.MergeOrder = 20
        PopupMenuTool11.SharedPropsInternal.Caption = "Vensters"
        PopupMenuTool11.SharedPropsInternal.Category = "General"
        PopupMenuTool11.SharedPropsInternal.MergeOrder = 99
        StateButtonTool1.InstanceProps.IsFirstInGroup = True
        StateButtonTool1.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        ButtonTool15.InstanceProps.IsFirstInGroup = True
        ButtonTool18.InstanceProps.IsFirstInGroup = True
        PopupMenuTool11.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {StateButtonTool1, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool19, ButtonTool20, MdiWindowListTool1})
        ButtonTool21.SharedPropsInternal.Caption = "Cascade"
        ButtonTool21.SharedPropsInternal.Category = "Windows"
        ButtonTool22.SharedPropsInternal.Caption = "Verticaal"
        ButtonTool22.SharedPropsInternal.Category = "Windows"
        ButtonTool23.SharedPropsInternal.Caption = "Horizontaal"
        ButtonTool23.SharedPropsInternal.Category = "Windows"
        ButtonTool24.SharedPropsInternal.Caption = "Alles minimaliseren"
        ButtonTool24.SharedPropsInternal.Category = "Windows"
        ButtonTool25.SharedPropsInternal.Caption = "Alles maximaliseren"
        ButtonTool25.SharedPropsInternal.Category = "Windows"
        ButtonTool26.SharedPropsInternal.Caption = "Alles sluiten"
        ButtonTool26.SharedPropsInternal.Category = "Windows"
        MdiWindowListTool2.DisplayArrangeIconsCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayCascadeCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayCloseWindowsCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayMinimizeCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayTileHorizontalCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.DisplayTileVerticalCommand = Infragistics.Win.UltraWinToolbars.MdiWindowListCommandDisplayStyle.Hide
        MdiWindowListTool2.SharedPropsInternal.Caption = "MDIWindowList"
        MdiWindowListTool2.SharedPropsInternal.Category = "Windows"
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        ButtonTool27.SharedPropsInternal.AppearancesSmall.Appearance = Appearance4
        ButtonTool27.SharedPropsInternal.Caption = "Hoofdmenu"
        ButtonTool27.SharedPropsInternal.Category = "Application"
        StateButtonTool2.MenuDisplayStyle = Infragistics.Win.UltraWinToolbars.StateButtonMenuDisplayStyle.DisplayCheckmark
        StateButtonTool2.SharedPropsInternal.Caption = "Tabbladen"
        StateButtonTool2.SharedPropsInternal.Category = "Windows"
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        ButtonTool28.SharedPropsInternal.AppearancesSmall.Appearance = Appearance5
        ButtonTool28.SharedPropsInternal.Caption = "Tree Hoofdmenu"
        ButtonTool28.SharedPropsInternal.Category = "Application"
        PopupMenuTool12.SharedPropsInternal.Caption = "Rapporten"
        PopupMenuTool12.SharedPropsInternal.Category = "General"
        PopupMenuTool12.SharedPropsInternal.MergeOrder = 25
        PopupMenuTool13.SharedPropsInternal.Caption = "Brandweer"
        PopupMenuTool13.SharedPropsInternal.Category = "General"
        PopupMenuTool13.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool29, ButtonTool30, ButtonTool31, ButtonTool32, ButtonTool33})
        PopupMenuTool14.SharedPropsInternal.Caption = "Bewaking"
        PopupMenuTool14.SharedPropsInternal.Category = "General"
        PopupMenuTool14.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool34, ButtonTool35, ButtonTool36, ButtonTool37})
        ButtonTool38.SharedPropsInternal.Caption = "Nieuw Dienstverslag"
        ButtonTool39.SharedPropsInternal.Caption = "Nieuwe Interventie"
        ButtonTool40.SharedPropsInternal.Caption = "Overzicht Interventies"
        ButtonTool41.SharedPropsInternal.Caption = "Jaarrapport"
        ButtonTool42.SharedPropsInternal.Caption = "Maandrapport"
        ButtonTool43.SharedPropsInternal.Caption = "Nieuw Dienstverslag"
        ButtonTool44.SharedPropsInternal.Caption = "Jaarrapport"
        ButtonTool45.SharedPropsInternal.Caption = "Maandrapport"
        ButtonTool46.SharedPropsInternal.Caption = "Overzicht Registraties"
        ButtonTool47.SharedPropsInternal.Caption = "Codetabellen"
        ButtonTool48.SharedPropsInternal.Caption = "Overzicht Stock"
        ButtonTool48.SharedPropsInternal.Category = "Application"
        ButtonTool49.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool50.SharedPropsInternal.Caption = "Nieuwe Registratie "
        ComboBoxTool1.SharedPropsInternal.Caption = "ComboBoxTool1"
        ComboBoxTool1.ValueList = ValueList1
        MdiWindowListTool3.SharedPropsInternal.Caption = "MDIWindowListTool1"
        ButtonTool52.SharedPropsInternal.Caption = "Update Firma"
        LabelTool4.SharedPropsInternal.Caption = "LabelTool1"
        ButtonTool54.SharedPropsInternal.Caption = "Gebruikershandleiding Brandweermateriaal"
        ButtonTool54.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        ButtonTool56.SharedPropsInternal.Caption = "Gebruikershandleiding Brandweermateriaal"
        Me._ultraToolbarsManager.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool5, ButtonTool6, ButtonTool7, PopupMenuTool5, PopupMenuTool6, ButtonTool13, PopupMenuTool7, PopupMenuTool10, PopupMenuTool11, ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24, ButtonTool25, ButtonTool26, MdiWindowListTool2, ButtonTool27, StateButtonTool2, ButtonTool28, PopupMenuTool12, PopupMenuTool13, PopupMenuTool14, ButtonTool38, ButtonTool39, ButtonTool40, ButtonTool41, ButtonTool42, ButtonTool43, ButtonTool44, ButtonTool45, ButtonTool46, ButtonTool47, ButtonTool48, ButtonTool49, ButtonTool50, ComboBoxTool1, MdiWindowListTool3, ButtonTool52, LabelTool4, ButtonTool54, ButtonTool56})
        '
        '_FormMainMDI_Toolbars_Dock_Area_Left
        '
        Me._FormMainMDI_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormMainMDI_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._FormMainMDI_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._FormMainMDI_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormMainMDI_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 48)
        Me._FormMainMDI_Toolbars_Dock_Area_Left.Name = "_FormMainMDI_Toolbars_Dock_Area_Left"
        Me._FormMainMDI_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 576)
        Me._FormMainMDI_Toolbars_Dock_Area_Left.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormMainMDI_Toolbars_Dock_Area_Right
        '
        Me._FormMainMDI_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormMainMDI_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._FormMainMDI_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._FormMainMDI_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormMainMDI_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(844, 48)
        Me._FormMainMDI_Toolbars_Dock_Area_Right.Name = "_FormMainMDI_Toolbars_Dock_Area_Right"
        Me._FormMainMDI_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 576)
        Me._FormMainMDI_Toolbars_Dock_Area_Right.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormMainMDI_Toolbars_Dock_Area_Top
        '
        Me._FormMainMDI_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormMainMDI_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._FormMainMDI_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._FormMainMDI_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormMainMDI_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._FormMainMDI_Toolbars_Dock_Area_Top.Name = "_FormMainMDI_Toolbars_Dock_Area_Top"
        Me._FormMainMDI_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(844, 48)
        Me._FormMainMDI_Toolbars_Dock_Area_Top.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_FormMainMDI_Toolbars_Dock_Area_Bottom
        '
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 624)
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.Name = "_FormMainMDI_Toolbars_Dock_Area_Bottom"
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(844, 0)
        Me._FormMainMDI_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me._ultraToolbarsManager
        '
        '_ultraTabbedMdiManager
        '
        Me._ultraTabbedMdiManager.MdiParent = Me
        Me._ultraTabbedMdiManager.TabGroupSettings.TabStyle = Infragistics.Win.UltraWinTabs.TabStyle.Excel
        Me._ultraTabbedMdiManager.TabSettings.TabCloseAction = Infragistics.Win.UltraWinTabbedMdi.MdiTabCloseAction.Close
        '
        '_ultraDockManager
        '
        Me._ultraDockManager.HostControl = Me
        '
        '_FormMainMDIUnpinnedTabAreaLeft
        '
        Me._FormMainMDIUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._FormMainMDIUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FormMainMDIUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 48)
        Me._FormMainMDIUnpinnedTabAreaLeft.Name = "_FormMainMDIUnpinnedTabAreaLeft"
        Me._FormMainMDIUnpinnedTabAreaLeft.Owner = Me._ultraDockManager
        Me._FormMainMDIUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 576)
        Me._FormMainMDIUnpinnedTabAreaLeft.TabIndex = 21
        '
        '_FormMainMDIUnpinnedTabAreaRight
        '
        Me._FormMainMDIUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._FormMainMDIUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FormMainMDIUnpinnedTabAreaRight.Location = New System.Drawing.Point(844, 48)
        Me._FormMainMDIUnpinnedTabAreaRight.Name = "_FormMainMDIUnpinnedTabAreaRight"
        Me._FormMainMDIUnpinnedTabAreaRight.Owner = Me._ultraDockManager
        Me._FormMainMDIUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 576)
        Me._FormMainMDIUnpinnedTabAreaRight.TabIndex = 22
        '
        '_FormMainMDIUnpinnedTabAreaTop
        '
        Me._FormMainMDIUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._FormMainMDIUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FormMainMDIUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 48)
        Me._FormMainMDIUnpinnedTabAreaTop.Name = "_FormMainMDIUnpinnedTabAreaTop"
        Me._FormMainMDIUnpinnedTabAreaTop.Owner = Me._ultraDockManager
        Me._FormMainMDIUnpinnedTabAreaTop.Size = New System.Drawing.Size(844, 0)
        Me._FormMainMDIUnpinnedTabAreaTop.TabIndex = 23
        '
        '_FormMainMDIUnpinnedTabAreaBottom
        '
        Me._FormMainMDIUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._FormMainMDIUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FormMainMDIUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 624)
        Me._FormMainMDIUnpinnedTabAreaBottom.Name = "_FormMainMDIUnpinnedTabAreaBottom"
        Me._FormMainMDIUnpinnedTabAreaBottom.Owner = Me._ultraDockManager
        Me._FormMainMDIUnpinnedTabAreaBottom.Size = New System.Drawing.Size(844, 0)
        Me._FormMainMDIUnpinnedTabAreaBottom.TabIndex = 24
        '
        '_FormMainMDIAutoHideControl
        '
        Me._FormMainMDIAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FormMainMDIAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._FormMainMDIAutoHideControl.Name = "_FormMainMDIAutoHideControl"
        Me._FormMainMDIAutoHideControl.Owner = Me._ultraDockManager
        Me._FormMainMDIAutoHideControl.Size = New System.Drawing.Size(0, 0)
        Me._FormMainMDIAutoHideControl.TabIndex = 25
        '
        '_timerOnderhoud
        '
        Me._timerOnderhoud.Enabled = True
        Me._timerOnderhoud.Interval = 300000
        '
        'FormMainMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(844, 650)
        Me.Controls.Add(Me._FormMainMDIAutoHideControl)
        Me.Controls.Add(Me._FormMainMDIUnpinnedTabAreaTop)
        Me.Controls.Add(Me._FormMainMDIUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._FormMainMDIUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._FormMainMDIUnpinnedTabAreaRight)
        Me.Controls.Add(Me._FormMainMDI_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._FormMainMDI_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._FormMainMDI_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._FormMainMDI_Toolbars_Dock_Area_Top)
        Me.IsMdiContainer = True
        Me.Name = "FormMainMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brandweer - Bewakingtoepassing"
        Me.Controls.SetChildIndex(Me._FormMainMDI_Toolbars_Dock_Area_Top, 0)
        Me.Controls.SetChildIndex(Me._statusBar, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDI_Toolbars_Dock_Area_Bottom, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDI_Toolbars_Dock_Area_Right, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDI_Toolbars_Dock_Area_Left, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDIUnpinnedTabAreaRight, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDIUnpinnedTabAreaLeft, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDIUnpinnedTabAreaBottom, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDIUnpinnedTabAreaTop, 0)
        Me.Controls.SetChildIndex(Me._FormMainMDIAutoHideControl, 0)
        CType(Me._ultraToolbarsManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ultraTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ultraDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Constants "

    Private Class ToolKeys
        Public Const Application As String = "Application"
        Public Const MainMenu As String = "MainMenu"
        Public Const TreeMainMenu As String = "TreeMainMenu"
        Public Const LogOn As String = "LogOn"
        Public Const LogOff As String = "LogOff"
        Public Const CloseApplication As String = "CloseApplication"
        Public Const MDIEntity As String = "MDIEntity"
        Public Const MDISelection As String = "MDISelection"
        Public Const MDIReports As String = "MDIReports"
        Public Const Windows As String = "Windows"
        Public Const TabPages As String = "TabPages"
        Public Const Cascade As String = "Cascade"
        Public Const Vertical As String = "Vertical"
        Public Const Horizontal As String = "Horizontal"
        Public Const MinimizeAll As String = "MinimizeAll"
        Public Const MaximizeAll As String = "MaximizeAll"
        Public Const CloseAll As String = "CloseAll"
        Public Const MDIWindowList As String = "MDIWindowList"
        Public Const Help As String = "Help"
        Public Const About As String = "About"
        Public Const UserManualBMA As String = "UserManualBMA"
        Public Const UpdateFirma As String = "Update Firma"

        Public Const BRWDienstverslag As String = "BRW Nieuw Dienstverslag"
        Public Const BRWInterventie As String = "BRW Nieuwe Interventie"
        Public Const BRWInterventieOverzicht As String = "BRW Overzicht Interventies"
        Public Const BRWJaarrapport As String = "BRW Jaarrapport"
        Public Const BRWMaandrapport As String = "BRW Maandrapport"
        Public Const BRWMateriaalOpLocatie As String = "BRW Materiaal op Locatie"
        Public Const BRWVerzendingen As String = "BRW Verzendingen"

        Public Const BEWDienstverslag As String = "BEW Nieuw Dienstverslag"
        Public Const BEWRegistratie As String = "BEW Nieuwe Registratie"
        Public Const BEWRegistratieOverzicht As String = "BEW Overzicht Registraties"
        Public Const BEWJaarrapport As String = "BEW Jaarrapport"
        Public Const BEWMaandrapport As String = "BEW Maandrapport"
        'TODO 3. Add Constant for each menu item
    End Class

#End Region

    Private _formManager As Forms.FormManagerBase
    Private _treeMainMenu As UltraTree

    Private WithEvents _dataIndividuen As DataSet
    Private WithEvents _dataIndividuen_Bestemmelingen As Client.TDSIndividuen
    Private WithEvents _dataConfigurationSettings As DataSet
    Private _controller As Client.ControllerGetData

#Region " Properties "

    'TODO 1. Add FormManager
    'Add a reference to the project with your FormManager
    'Replace [!OUTPUT FORM_MANAGER] with your FormManager classname	

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Used to open forms
    ''' </summary>
    ''' <value></value>
    ''' 	''' <remarks>
    ''' FormManager is a singleton that retains a reference to this MDI form
    ''' So any forms opened by the FormManager (even from another form) have this MDI as parent
    ''' </remarks>
    ''' <history>
    ''' 	[SIDWOSE]	9/06/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Friend ReadOnly Property CurrentFormManager() As Client.FormManager
        Get
            Return CType(_formManager, Client.FormManager)
        End Get
    End Property

    Public Property UserLoggedOn() As Boolean = False

    Public Property DepartementalUserLoggedOn() As Boolean = False

    Public Property UserName() As String = ""

    Public Property UserDepartementId() As Integer
    Public Property UserDepartementId2() As Integer
    Public Property UserDepartementId3() As Integer

    Public Overridable Property DockAreaWidth() As Integer = 180 'original 220

    Public Overridable Property DataIndividuen() As DataSet
        Get
            Return _dataIndividuen
        End Get
        Set(ByVal value As DataSet)
            _dataIndividuen = value
        End Set
    End Property

    Public Overridable Property DataIndividuen_Bestemmelingen() As Client.TDSIndividuen
        Get
            Return _dataIndividuen_Bestemmelingen
        End Get
        Set(ByVal value As Client.TDSIndividuen)
            _dataIndividuen_Bestemmelingen = value
        End Set
    End Property

    Public Overridable Property DataConfiguration() As DataSet
        Get
            Return _dataConfigurationSettings
        End Get
        Set(ByVal value As DataSet)
            _dataConfigurationSettings = value
        End Set
    End Property

#End Region

#Region " Events "

    Protected Overrides Sub FormLoad(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.FormLoad(sender, e)

        'show in which environment the application runs
        Try
            Dim stage As String = ADF.Configuration.ConfigurationSettings.Instrumentation.Stage
            If stage Is Nothing OrElse stage = "" Then
                Text &= " ?"
            Else
                Text &= " " & stage
            End If
        Catch ex As Exception
            Text &= " ?"
        End Try

        'Localize strings for ultragrids
        InfragisticsHelpers.UltraGridHelper.LocalizeStrings()

        If UserLoggedOn = True Or DepartementalUserLoggedOn = True Then 'naco - 22/12/2016 - DepartementalUserLoggedOn = True toegevoegd
            'Show the main menu
            _formManager = Client.FormManager.Create(Me)
            ShowMainMenu()

            'Show tabpages
            CType(_ultraToolbarsManager.Tools.Item(ToolKeys.TabPages), UltraWinToolbars.StateButtonTool).Checked = True
        End If

        If UserLoggedOn = True Or DepartementalUserLoggedOn = True Then 'naco - 22/12/2016 - DepartementalUserLoggedOn = True toegevoegd
            UserControls.StatusBar.DefaultUserName = UserName
            Message = "Gebruiker " & UserName & " is aangemeld"

            'TODO Load all formManagers
            'This makes it possible to create a new formmanager (with parentform = nothing) in a modal form
            'without using the MainMDI form as parentform, which is not available at that time
            CType(_formManager, Client.FormManager).DataIndividuen = DataIndividuen
            CType(_formManager, Client.FormManager).DataIndividuen_Bestemmelingen = DataIndividuen_Bestemmelingen
            CType(_formManager, Client.FormManager).DataConfiguration = DataConfiguration
        Else
            Message = "Gelieve aan te melden"
        End If

        SetEnablements()
    End Sub

    Protected Overrides Sub FormIsClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If MessageBox.Show(Me, "BBW toepassing afsluiten ?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
            e.Cancel = True
        End If

        MyBase.FormIsClosing(sender, e)
    End Sub

    Private Sub FormMainMDIClosed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
        Client.FormManager.Release()
        If UserLoggedOn Then
            ADF.Configuration.ConfigurationSettings.UserSettingsManager.CurrentUserSettingsManager.WriteSettings(UserName)
        End If
    End Sub

    Private Sub MenuClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles _ultraToolbarsManager.ToolClick
        Cursor.Current = Cursors.WaitCursor
        Try
            Select Case e.Tool.Key
                Case ToolKeys.MainMenu
                    ShowMainMenu()
                Case ToolKeys.TreeMainMenu
                    'ShowTreeMainMenu()
                Case ToolKeys.LogOn
                    LogOn()
                Case ToolKeys.LogOff
                    LogOff()
                Case ToolKeys.CloseApplication
                    Close()
                Case ToolKeys.TabPages
                    _ultraTabbedMdiManager.Enabled = CType(e.Tool, Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
                Case ToolKeys.Cascade
                    LayoutMdi(MdiLayout.Cascade)
                Case ToolKeys.Vertical
                    LayoutMdi(MdiLayout.TileVertical)
                Case ToolKeys.Horizontal
                    LayoutMdi(MdiLayout.TileHorizontal)
                Case ToolKeys.MinimizeAll
                    For Each childWindow As Form In MdiChildren
                        childWindow.WindowState = FormWindowState.Minimized
                    Next
                Case ToolKeys.MaximizeAll
                    For Each childWindow As Form In MdiChildren
                        childWindow.WindowState = FormWindowState.Maximized
                    Next
                Case ToolKeys.CloseAll
                    CloseAllWindows()
                Case ToolKeys.MDIWindowList
                    'to show list of open windows
                Case ToolKeys.About
                    About()

                Case ToolKeys.UserManualBMA
                    Dim sInfo As ProcessStartInfo = New ProcessStartInfo("http://wfdocprod.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0900f6f0805fab32&latestflag=y")
                    Process.Start(sInfo)
                    'naco - jan 2017 - user manual in Documentum - EasyExplore

                Case ToolKeys.UpdateFirma
                    ToonFormUpdateFirmas(False, True, True)

                    'TODO 4. Add menuItems to your MDI-form
                    'implement the click event here (call methods created in TODO 2)
                Case ToolKeys.BRWDienstverslag
                    NieuwDienstverslagBrandweerEntity(False, True, True)

                Case ToolKeys.BRWInterventie
                    ' NieuweInterventieBrandweerEntity(False, True, True, "")

                Case ToolKeys.BRWInterventieOverzicht
                    OverzichtInterventiesBrandweerEntity(False, True, True)

                Case ToolKeys.BRWJaarrapport
                    JaarrapportBrandweerEntity(False, True, True)

                Case ToolKeys.BRWMateriaalOpLocatie
                    OverzichtMateriaalOpLocatie(False, True, True)

                Case ToolKeys.BRWVerzendingen
                    OverzichtBrandweerVerzendingen(False, True, True)

                Case ToolKeys.BRWMaandrapport
                    MaandrapportBrandweerEntity(False, True, True)

                Case ToolKeys.BEWDienstverslag
                    NieuwDienstverslagBewakingEntity(False, True, True)

                Case ToolKeys.BEWRegistratie
                    NieuweRegistratieBewakingEntity(False, True, True)

                Case ToolKeys.BEWRegistratieOverzicht
                    OverzichtRegistratiesBewakingEntity(False, True, True)

                Case ToolKeys.BEWJaarrapport
                    JaarrapportBewakingEntity(False, True, True)

                Case ToolKeys.BEWMaandrapport
                    MaandrapportBewakingEntity(False, True, True)

                Case Else
                    Debug.WriteLine("Unhandled key from menu : " & e.Tool.Key)
            End Select
        Catch ex As Exception
            HandleException(ex)
        Finally
            SetEnablements()
            Cursor.Current = Cursors.Default
        End Try
    End Sub
#End Region

    Public Overrides Sub SetEnablements()
        With _ultraToolbarsManager.Tools
            .Item(ToolKeys.MainMenu).SharedProps.Visible = UserLoggedOn
            .Item(ToolKeys.TreeMainMenu).SharedProps.Visible = UserLoggedOn
            .Item(ToolKeys.MinimizeAll).SharedProps.Enabled = Not CType(.Item(ToolKeys.TabPages), Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
            .Item(ToolKeys.MaximizeAll).SharedProps.Enabled = Not CType(.Item(ToolKeys.TabPages), Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
            .Item(ToolKeys.Cascade).SharedProps.Enabled = Not CType(.Item(ToolKeys.TabPages), Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
            .Item(ToolKeys.Horizontal).SharedProps.Enabled = Not CType(.Item(ToolKeys.TabPages), Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
            .Item(ToolKeys.Vertical).SharedProps.Enabled = Not CType(.Item(ToolKeys.TabPages), Infragistics.Win.UltraWinToolbars.StateButtonTool).Checked
            .Item(ToolKeys.MDIEntity).SharedProps.Visible = UserLoggedOn And Not DepartementalUserLoggedOn
            .Item(ToolKeys.MDISelection).SharedProps.Visible = UserLoggedOn
            .Item(ToolKeys.MDIReports).SharedProps.Visible = UserLoggedOn
#If USE_SECURITY Then
            .Item(ToolKeys.LogOn).SharedProps.Visible = Not UserLoggedOn
            .Item(ToolKeys.LogOff).SharedProps.Visible = UserLoggedOn
#Else
			.Item(ToolKeys.LogOn).SharedProps.Visible = False
			.Item(ToolKeys.LogOff).SharedProps.Visible = False
			.Item(ToolKeys.LogOn).SharedProps.Enabled = False
			.Item(ToolKeys.LogOff).SharedProps.Enabled = False
#End If
        End With
    End Sub

    Public Sub LogOn()
        Dim frm As New DialogLogon
        frm.StartPosition = FormStartPosition.CenterScreen
        Dim aUser As DialogLogon.UserIdentification

        aUser = frm.ShowDialog()
        If Not aUser.Password Is Nothing Then
            Try
                SecurityManager.CurrentSecurityManager.ValidatePassword(aUser.Name, aUser.Password)

                Try
                    SecurityManager.CurrentSecurityManager.LoadData(aUser.Name)

                Catch ex As ADF.Security.ApplicationSecurity.UserNotAllowedForApplicationException
                    Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                    UserDepartementId = proxy.GetAfdelingVoorGebruiker(aUser.Name)
                    UserDepartementId2 = proxy.GetAfdelingVoorGebruiker2(aUser.Name)
                    UserDepartementId3 = proxy.GetAfdelingVoorGebruiker3(aUser.Name)

                    If UserDepartementId < 1 Then Throw

                    DepartementalUserLoggedOn = True
                End Try

                UserLoggedOn = True
                UserName = aUser.Name
                UserControls.StatusBar.DefaultUserName = If(DepartementalUserLoggedOn, aUser.Name, SecurityManager.CurrentSecurityManager.GetUserId)
                Message = String.Empty

                'Usersettings
                ADF.Configuration.ConfigurationSettings.UserSettingsManager.CurrentUserSettingsManager.ReadSettings(UserName)

                'Show the main menu
                ShowMainMenu()

                'Show tabpages
                CType(_ultraToolbarsManager.Tools.Item(ToolKeys.TabPages), UltraWinToolbars.StateButtonTool).Checked = True

                'Show Tree
                'ShowTreeMainMenu()

            Catch ex As ADF.Security.ApplicationSecurity.LogonFailedException
                'user and password are not correct
                SecurityManager.CurrentSecurityManager.ClearData()
                ADF.Presentation.Windows.Forms.DialogHelper.ShowErrorDialog("aanloggen voor user " & aUser.Name & " niet gelukt")
                Message = "Gelieve aan te melden"

            Catch ex As ADF.Security.ApplicationSecurity.UserNotAllowedForApplicationException
                'user and password are OK, but no data for the user for this application
                SecurityManager.CurrentSecurityManager.ClearData()
                ADF.Presentation.Windows.Forms.DialogHelper.ShowErrorDialog("Gebruiker " & aUser.Name & " heeft geen toegang tot de toepassing.")
                Message = "Gelieve aan te melden"
            Catch ex As Exception
                SecurityManager.CurrentSecurityManager.ClearData()
                HandleException(ex)
                Message = "Gelieve aan te melden"
            Finally
                SetEnablements()
            End Try

        End If
    End Sub

    Public Sub LogOff()
        Dim result As ModalMessageBox.Button
        Dim butcoll As ModalMessageBox.ButtonCollection
        butcoll = New ModalMessageBox.ButtonCollection
        Const textYes As String = "Ja"
        Const textNo As String = "Nee"
        butcoll.Add(textYes)
        butcoll.Add(textNo, , True)
        Dim currentCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.Default
        result = ModalMessageBox.Show("Wilt u zich afmelden?", "Afmelden", ModalMessageBox.Icontypes.Question, butcoll)

        Select Case result.Text
            Case textYes

                'Close the MenuForm (not handled by the formmanager)
                For Each child As Form In MdiChildren
                    If TypeOf child Is FormMenu OrElse
                       TypeOf child Is Client.Forms.Brandweer.FormBrandweerAfdelingMateriaal Then
                        child.Close()
                    End If
                Next

                UserControls.StatusBar.DefaultUserName = String.Empty
                UserControls.StatusBar.DefaultUserDept = String.Empty
                Dim tempUser As String = _UserName
                With _statusBar
                    .Message = String.Empty
                    .User = String.Empty
                    .Department = String.Empty
                End With
                SecurityManager.CurrentSecurityManager.ClearData()
                UserLoggedOn = False
                DepartementalUserLoggedOn = False
                UserName = ""

                'Usersettings
                ADF.Configuration.ConfigurationSettings.UserSettingsManager.CurrentUserSettingsManager.WriteSettings(tempUser)

                'No tabpages
                CType(_ultraToolbarsManager.Tools.Item(ToolKeys.TabPages), UltraWinToolbars.StateButtonTool).Checked = False

                'Hide Tree
                HideTreeMainMenu()

                Message = "Gelieve aan te melden"

            Case textNo
                'Do nothing special
        End Select
        Cursor.Current = currentCursor
    End Sub

    Public Sub CloseAllWindows()
        'Closes all forms (MDIchilds are not) except the MDI form

        'close all windows if you are logging off (menuform is not handled by the formmanager)

        'Show the main menu 
        ShowMainMenu()

    End Sub

    Public Sub About()
        Dim frm As New DialogAbout
        frm.StartPosition = FormStartPosition.CenterScreen
        ''If you use the generic DialogBox, applicationname is set invisible because it is not filled in
        'frm.LabelNameApplication.Visible = False
        'frm.LabelTextNameApplication.Visible = False
        frm.LabelTextNameApplication.Text = "Brandweer-Bewaking Toepassing (INF - LWA Nancy Coppens/Kristien Vanerom/Hans Deleu)"
        frm.ShowDialog()
    End Sub

#Region " MenuHandling "

    Public Sub ShowMainMenu()
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen hoofdmenu"

            ' Toon het scherm voor de departementele gebruikers
            ' -------------------------------------------------
            If DepartementalUserLoggedOn = True And UserLoggedOn = False Then
                Dim form As Form = Array.Find(MdiChildren, Function(f) TypeOf f Is Client.Forms.Brandweer.FormBrandweerAfdelingMateriaal)
                If form IsNot Nothing Then
                    form.Activate()
                    form.Show()
                    Exit Sub
                End If

                form = New Client.Forms.Brandweer.FormBrandweerAfdelingMateriaal With {.Afdeling = UserDepartementId, .Afdeling2 = UserDepartementId2, .Afdeling3 = UserDepartementId3, .MdiParent = Me}
                form.Show()

                Message = ""
                Return
            End If

            ' Toon het normale hoofdscherm (met menu)
            ' ---------------------------------------
            Dim frm As Form = Array.Find(MdiChildren, Function(f) TypeOf f Is FormMenu)
            If frm IsNot Nothing Then
                frm.Activate()
                frm.Show()
                Exit Sub
            End If

            'if the window does not exist, then a new one is made
            Dim frmMenu As New FormMenu
            frmMenu.MdiParent = Me
            frmMenu.Show()

            Dim menuTab As Infragistics.Win.UltraWinTabbedMdi.MdiTab = _ultraTabbedMdiManager.TabFromForm(frmMenu)
            menuTab.Reposition(menuTab, Infragistics.Win.UltraWinTabbedMdi.MdiTabPosition.First)

            'Security: groupboxen zichtbaar maken - 03/04/2006 - sidnaco -- aangepast door koen
            Dim brandweerUser, bewakingUser As Boolean
            brandweerUser = False
            bewakingUser = False

            frmMenu.UltraGroupBoxOverige.Visible = False


            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("BEWAKING", "VIEW") Then
                frmMenu.UltraGroupBoxBewaking.Visible = True
                frmMenu.UltraGroupBoxSnelheidsovertredingen.Visible = True
                frmMenu.UltraGroupBoxOverige.Visible = True
                frmMenu.ButtonCodeTablesBM.Visible = False
                frmMenu.UltraGroupBoxInkoop.Visible = True
                CurrentFormManager.Bewaking = True
                bewakingUser = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("BRANDWEER", "VIEW") Then
                frmMenu.UltraGroupBoxBrandweer.Visible = True
                frmMenu.UltraGroupBoxOverige.Visible = True
                frmMenu.ButtonCodeTablesBM.Visible = True
                CurrentFormManager.Brandweer = True
                brandweerUser = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("POSTOVERSTE", "VIEW") Then
                frmMenu.UltraGroupBoxBewaking.Visible = True
                frmMenu.UltraGroupBoxBrandweer.Visible = True
                frmMenu.UltraGroupBoxOverige.Visible = True
                frmMenu.UltraGroupBoxInkoop.Visible = True
                frmMenu.ButtonCodeTablesBM.Visible = True
                CurrentFormManager.PostOverste = True
            Else
                CurrentFormManager.PostOverste = False
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("DIEFSTAL", "VIEW") Then
                frmMenu.UltraGroupBoxDiefstalPerTrimester.Visible = True
                CurrentFormManager.Diefstal = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("SNELHEID", "VIEW") Then
                frmMenu.UltraGroupBoxSnelheidsovertredingen.Visible = True
                CurrentFormManager.Snelheid = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("IKP", "VIEW") Then 'naco - 28/11/2012
                frmMenu.UltraGroupBoxInkoop.Visible = True
                frmMenu.UltraGroupBoxInkoop.Location = frmMenu.UltraGroupBoxBrandweer.Location

                CurrentFormManager.IKPvtw = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("CHIP", "VIEW") Then
                frmMenu.UltraGroupBoxBewaking.Visible = True
                frmMenu.UltraGroupBoxBrandweer.Visible = False
                frmMenu.UltraGroupBoxDiefstalPerTrimester.Visible = False
                frmMenu.UltraGroupBoxMilieuDienst.Visible = False
                frmMenu.UltraGroupBoxOverige.Visible = False
                frmMenu.UltraGroupBoxSnelheidsovertredingen.Visible = True
                frmMenu.UltraGroupBoxInkoop.Visible = True

                frmMenu.UltraButtonDagverslagPersoneel.Visible = False
                frmMenu.UltraButtonDagverslagInlichtingen.Visible = False
                frmMenu.UltraButtonBEWJaarrapport.Visible = False
                frmMenu.UltraButtonBEWMaandrapport.Visible = False
                frmMenu.GroupBoxBewaking.Visible = False

                CurrentFormManager.Chip = True
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("ONGELDIG_RAPPORT_PBH", "VIEW") Then
                frmMenu.UltraGroupBoxBewaking.Visible = True
                frmMenu.UltraButtonDagverslagPersoneel.Visible = False
                frmMenu.UltraButtonDagverslagInlichtingen.Visible = False
                frmMenu.UltraButtonBEWMaandrapport.Visible = False
                frmMenu.UltraButtonBEWJaarrapport.Visible = False
                frmMenu.GroupBoxBewaking.Visible = False
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("VERANTWOORDELIJKE", "VIEW") Then
                frmMenu.UltraGroupBoxBewaking.Visible = True
                frmMenu.UltraGroupBoxBrandweer.Visible = True
                frmMenu.UltraGroupBoxMilieuDienst.Visible = True
                frmMenu.UltraGroupBoxDiefstalPerTrimester.Visible = True
                frmMenu.UltraGroupBoxSnelheidsovertredingen.Visible = True
                frmMenu.UltraGroupBoxOverige.Visible = True
                frmMenu.ButtonCodeTablesBM.Visible = True
                frmMenu.UltraGroupBoxInkoop.Visible = True

                CurrentFormManager.BbwVerantwoordelijke = True
            Else
                CurrentFormManager.BbwVerantwoordelijke = False
            End If

            CurrentFormManager.CanInvalidateReport = SecurityManager.CurrentSecurityManager.IsOperationAllowed("ONGELDIG_RAPPORT", "VIEW")

            If bewakingUser Or brandweerUser Then
                frmMenu.UltraGroupBoxOverige.Location = frmMenu.UltraGroupBoxBewaking.Location
            End If

            If bewakingUser And Not brandweerUser Then
                frmMenu.UltraGroupBoxBewaking.Location = frmMenu.UltraGroupBoxBrandweer.Location
            End If

            If SecurityManager.CurrentSecurityManager.IsOperationAllowed("MILIEUDIENST", "VIEW") Then
                frmMenu.UltraGroupBoxMilieuDienst.Visible = True
                frmMenu.UltraGroupBoxMilieuDienst.Location = frmMenu.UltraGroupBoxBrandweer.Location
                CurrentFormManager.BbwMilieuDienst = True
            Else
                CurrentFormManager.BbwMilieuDienst = False
            End If

            If System.Environment.UserName.ToUpper = "SIDNACO" Or System.Environment.UserName.ToUpper = "SIDEVAR" Or System.Environment.UserName.ToUpper = "SIDHADR" Or System.Environment.UserName.ToUpper = "SIDABGU" Then
                'aug 2016 - update firma sap nr nodig om verslagen automatisch naar CHIP te kunnen sturen
                frmMenu.GroupBoxUpdateFirm.Visible = True
            Else
                frmMenu.GroupBoxUpdateFirm.Visible = False
            End If

            Message = ""

        Catch ex As Exception
            HandleException(ex)

        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    'TODO 2. Add methods to open forms
    'Add methods to open forms with the CurrentFormManager
    'Example:
    Public Sub OverzichtInterventiesBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Interventies"
            CurrentFormManager.OpenFormBrandweerOverzichtInterventies(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtMilieuverontreinigingenEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Milieuverontreinigingen"
            CurrentFormManager.OpenFormBrandweerOverzichtMilieuverontreinigingen(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtDiefstalPerTrimesterEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Diefstal per Trimester"
            CurrentFormManager.OpenformDiefstalPerTrimester(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtSnelheidsovertredingenEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Snelheidsovertredingen"
            CurrentFormManager.OpenformSnelheidsovertredingen(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtOvertredingenEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm inbreuk Reglementen"
            CurrentFormManager.OpenformOvertredingen(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtInkoopEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen bewaking verslagen bestemmeling Inkoopdienst"
            CurrentFormManager.OpenformInkoop(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtInkoopBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen brandweer verslagen bestemmeling Inkoopdienst"
            CurrentFormManager.OpenformInkoopBrandweer(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub


    Public Sub OverzichtIKPQuerymetFirma(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            'naco - 06/07/2015
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen lijst Inkoop overzicht met firma (vinkje Naar CHIP)"
            CurrentFormManager.OpenformBewakingIKP_VinkjeCHIP(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub
    Public Sub OverzichtBeheerAmcEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen beheer AMC"
            CurrentFormManager.OpenFormBeheerAMC(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtMateriaalOpLocatie(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Materiaal op Locatie"
            CurrentFormManager.OpenFormMateriaalOpLocatie(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtMateriaalOpLocatieAfdeling(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Materiaal op Locatie - Afdeling"
            CurrentFormManager.OpenFormMateriaalOpLocatieAfdeling(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub
    Public Sub OverzichtBrandweerVerzendingen(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Verzendingen"
            CurrentFormManager.OpenFormBrandweerVerzendingen(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtStockBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Registraties"
            CurrentFormManager.OpenFormBrandweerOverzichtStock(showModal, asSingleton, asMdiChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub NieuweInterventieBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMdiChild As Boolean, ByVal interventieType As Integer, ByVal interventieOmschrijving As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Toevoegen nieuwe interventie"
            CurrentFormManager.OpenFormNieuweBrandweerInterventies(showModal, asSingleton, asMdiChild, interventieType, interventieOmschrijving, -1)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
            MessageBox.Show("Fout opgetreden in FormMainMDI - NieuweInterventieBrandweerEntity: " & vbCrLf & ex.Message & vbCrLf & "InnerException:" & vbCrLf & ex.InnerException.ToString, "Fout in BBW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub NieuwDienstverslagBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Toevoegen nieuw brandweerdienstverslag"
            CurrentFormManager.OpenFormBrandweerDienstverslag(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub DienstverslagOverzichtEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzicht Dienstverslagen Brandweer"
            CurrentFormManager.OpenFormDienstverslagOverzicht(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub MaandrapportBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen maandrapport brandweer"
            CurrentFormManager.OpenFormBrandweerMaandrapport(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub JaarrapportBrandweerEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen jaarrapport brandweer"
            CurrentFormManager.OpenFormBrandweerjaarrapport(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OverzichtRegistratiesBewakingEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Overzichtscherm Registraties"
            CurrentFormManager.OpenFormOverzichtBewakingRegistratieEntity(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub NieuweRegistratieBewakingEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Toevoegen nieuwe registratie"
            CurrentFormManager.OpenFormNieuweBewakingRegistratieEntity(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub NieuwDienstverslagBewakingEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Toevoegen nieuw bewakingsdienstverslag"
            CurrentFormManager.OpenFormBewakingDienstverslagEntity(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub MaandrapportBewakingEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen maandrapport bewaking"
            CurrentFormManager.OpenFormBewakingMaandrapport(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub JaarrapportBewakingEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen jaarrapport bewaking"
            CurrentFormManager.OpenFormBewakingjaarrapport(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub CodetabellenEntity(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Codetabellen"
            CurrentFormManager.OpenFormCodetabellenEntity(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub
    '
    'Bewaking
    '
    Public Sub Aanrijding(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Aanrijding"
            CurrentFormManager.OpenFormAanrijding(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub Alcoholtest(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Alcoholtest"
            CurrentFormManager.OpenFormAlcoholtest(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ControleVoertuig(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Controle Voertuig"
            CurrentFormManager.OpenFormControleVoertuigen(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub Diefstal(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Diefstal"
            CurrentFormManager.OpenFormDiefstal(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub Diversen(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Diversen"
            CurrentFormManager.OpenFormDiverseRegistratie(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub InbreukReglementen(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Inbreuk op reglementen"
            CurrentFormManager.OpenFormInbreukReglementen(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub OpenmakenKleerkast(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Openmaken van een kleerkast"
            CurrentFormManager.OpenFormOpenmakenKleerkast(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub Schadegeval(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen Registratie Schadegeval"
            CurrentFormManager.OpenFormSchadegeval(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ToonFormDagverslagPersoneelOverzicht(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen overzichtscherm dagverslag personeel"
            CurrentFormManager.OpenFormDagVerslagPersoneelOverzicht(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ToonFormDagverslagInlichtingen(ByVal showModal As Boolean, ByVal asSingleTon As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen overzichtscherm dagverslag inlichtingen"
            CurrentFormManager.OpenformDagVerslagInlichtingen(showModal, asSingleTon, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ToonFormBewakingMilieuVerslag(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen scherm milieuverslag"
            CurrentFormManager.OpenFormBewakingMilieuVerslag(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ToonFormBrandweerCodetables(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen scherm codetabellen brandweermateriaal"
            CurrentFormManager.OpenformCodeTablesBM(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

    Public Sub ToonFormUpdateFirmas(ByVal showModal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Message = "Openen scherm update firma's"
            CurrentFormManager.OpenFormUpdateFirma(showModal, asSingleton, asMDIChild)
            Message = ""
        Catch ex As Exception
            HandleException(ex)
        Finally
            Cursor.Current = Cursors.Default
            SetEnablements()
        End Try
    End Sub

#End Region

#Region " Docking Methods "

    Private Sub RemoveDockingPane(ByVal aControl As Control)
        If _ultraDockManager.DockAreas.IndexOf(aControl.Name) >= 0 Then
            _ultraDockManager.ControlPanes.Remove(aControl.Name)
        End If
    End Sub

    'Private Sub AddToDockingPane(ByVal aControl As Control, ByVal aCaption As String)
    '    If _ultraDockManager.DockAreas.IndexOf(aControl.Name) < 0 Then
    '        Dim paneSolution As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(aControl.Name)
    '        paneSolution.Control = aControl
    '        paneSolution.Text = aCaption
    '        paneSolution.TextTab = aCaption

    '        'Dim tabGroup As Infragistics.Win.UltraWinDock.DockableGroupPane = New Infragistics.Win.UltraWinDock.DockableGroupPane(aControl.Name)
    '        'tabGroup.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {paneSolution})
    '        'tabGroup.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup

    '        Dim dockArea As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, aControl.Name)
    '        dockArea.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {paneSolution})
    '        dockArea.Size = New Size(_dockAreaWidth, -1)

    '        _ultraDockManager.DockAreas.Add(dockArea)
    '    End If
    'End Sub

#End Region

#Region " UltraTree Methods "

    Private ReadOnly Property CurrentTreeMainMenu() As UltraTree
        Get
            If _treeMainMenu Is Nothing Then
                _treeMainMenu = New UltraTree
                _treeMainMenu.Name = "UltraTreeMenu"

                LoadTreeMenu()
                AddHandler _treeMainMenu.Click, AddressOf TreeMainMenuClick
            End If

            Return _treeMainMenu             'return to dock in main form
        End Get
    End Property

    'TODO 5. Add nodes to the tree menu

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Loads the tree menu with the nodes
    ''' </summary>
    ''' <remarks>
    ''' Add any additional nodes here
    ''' </remarks>
    ''' <history>
    ''' 	[SIDWOSE]	9/06/2005	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub LoadTreeMenu()
        Dim nodeApplication As New UltraTreeNode
        nodeApplication.Text = "Toepassing"
        nodeApplication.Selected = True
        _treeMainMenu.Nodes.Add(nodeApplication)
        _treeMainMenu.ActiveNode = nodeApplication

        Dim nodeMainMenu As New UltraTreeNode
        nodeMainMenu.Text = "Hoofdmenu"
        nodeMainMenu.Key = ToolKeys.MainMenu
        nodeApplication.Nodes.Add(nodeMainMenu)

        'Entity
        Dim nodeMdiEntity As New UltraTreeNode
        nodeMdiEntity.Text = "Beheer"
        nodeApplication.Nodes.Add(nodeMdiEntity)

        Dim nodeBrandweerEntity As New UltraTreeNode
        nodeBrandweerEntity.Text = "Brandweer"
        nodeMdiEntity.Nodes.Add(nodeBrandweerEntity)

        Dim nodeBrwDienstverslagEntity As New UltraTreeNode
        nodeBrwDienstverslagEntity.Text = "Dienstverslag"
        nodeBrwDienstverslagEntity.Key = ToolKeys.BRWDienstverslag
        nodeBrandweerEntity.Nodes.Add(nodeBrwDienstverslagEntity)

        Dim nodeBrwInterventieEntity As New UltraTreeNode
        nodeBrwInterventieEntity.Text = "Interventie"
        nodeBrwInterventieEntity.Key = ToolKeys.BRWInterventie
        nodeBrandweerEntity.Nodes.Add(nodeBrwInterventieEntity)

        Dim nodeBrwInterventieOverzichtEntity As New UltraTreeNode
        nodeBrwInterventieOverzichtEntity.Text = "InterventieOverzicht"
        nodeBrwInterventieOverzichtEntity.Key = ToolKeys.BRWInterventieOverzicht
        nodeBrandweerEntity.Nodes.Add(nodeBrwInterventieOverzichtEntity)

        Dim nodeBrwJaarrapportEntity As New UltraTreeNode
        nodeBrwJaarrapportEntity.Text = "Jaarrapport"
        nodeBrwJaarrapportEntity.Key = ToolKeys.BRWJaarrapport
        nodeBrandweerEntity.Nodes.Add(nodeBrwJaarrapportEntity)

        Dim nodeBrwMaandrapportEntity As New UltraTreeNode
        nodeBrwMaandrapportEntity.Text = "Maandrapport"
        nodeBrwMaandrapportEntity.Key = ToolKeys.BRWMaandrapport
        nodeBrandweerEntity.Nodes.Add(nodeBrwMaandrapportEntity)

        'Selection
        Dim nodeMdiSelection As New UltraTreeNode
        nodeMdiSelection.Text = "Zoeken"
        nodeApplication.Nodes.Add(nodeMdiSelection)

        nodeApplication.ExpandAll()
    End Sub

    Private Sub TreeMainMenuClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim node As UltraTreeNode = CType(sender, Infragistics.Win.UltraWinTree.UltraTree).ActiveNode
        If (node Is Nothing) Then Return

        If (node.Selected) Then
            Select Case node.Key
                Case ToolKeys.MainMenu
                    ShowMainMenu()

                    'TODO 6. Implement click events for nodes
                    'call methods created in TODO 2

                    ' Nog aan te passen
                Case ToolKeys.BRWDienstverslag
                    NieuwDienstverslagBrandweerEntity(False, True, True)
                Case ToolKeys.BRWInterventie
                    ' NieuweInterventieBrandweerEntity(False, True, True, "")
                Case ToolKeys.BRWInterventieOverzicht
                    OverzichtInterventiesBrandweerEntity(False, True, True)
                Case ToolKeys.BRWJaarrapport
                    JaarrapportBrandweerEntity(False, True, True)
                Case ToolKeys.BRWMaandrapport
                    MaandrapportBrandweerEntity(False, True, True)
            End Select
        End If
    End Sub

    'Public Overridable Sub ShowTreeMainMenu()
    '    Try
    '        ' Message = "Openen tree hoofdmenu..."
    '        'CurrentTreeMainMenu.Show()
    '        ' RemoveDockingPane(CurrentTreeMainMenu)
    '        '          AddToDockingPane(CurrentTreeMainMenu, "Hoofdmenu")

    '        '          _ultraDockManager.UnpinAll()

    '        ' Message = ""
    '    Catch ex As Exception
    '        HandleException(ex)
    '    End Try
    'End Sub

    Public Overridable Sub HideTreeMainMenu()
        Try
            'Remove the dockingpane
            RemoveDockingPane(CurrentTreeMainMenu)

            'Hide the tree
            CurrentTreeMainMenu.Hide()
        Catch ex As Exception
            HandleException(ex)
        End Try
    End Sub

#End Region

    'Doel: Het inladen van alle individuen die zich in de database bevinden. 
    'Zo worden de individuen (een 10.000-tal) maar één keer ingeladen.
    'Auteur: naco - Koen - Rajiv - 00/04/2006
    Public Sub LoadIndividuen()
        Try
            If _dataIndividuen Is Nothing Then
                _dataIndividuen = New Client.TDSIndividuen
            End If

            _controller = New Client.ControllerGetData
            ' _dataIndividuen.Merge( _controller.GetIndividuen())

            '02/03/2007 - naco/dien
            'in overleg met Philip Matthijs - in heel uitzonderlijke gevallen is dit toegelaten
            'rechtstreeks op database lezen, niet via webservice

            Dim dtaMgrBbw As New DataManagerBBW
            _dataIndividuen.Merge(dtaMgrBbw.GetIndividuen())

            ' Initialize bestemmelingen dataset
            _dataIndividuen_Bestemmelingen = New Client.TDSIndividuen()
            _dataIndividuen_Bestemmelingen.Merge(_dataIndividuen.Tables(0).Select("BST_IND = 1 AND BST_ACTIVE = 1"))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormMainMDI - LoadIndividuen" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub LoadConfigurationSettings()
        Try
            If _dataConfigurationSettings Is Nothing Then
                _dataConfigurationSettings = New Client.TDSConfiguratie
            End If

            _controller = New Client.ControllerGetData
            _dataConfigurationSettings.Merge(_controller.GetConfigurationSettings)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                            "Form: FormMainMDI - LoadConfigurationSettings" & vbCrLf & _
                            "Message: " & ex.Message & vbCrLf & _
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

#Region "Waarschuwing voor Stilstanden"

    ''' <summary>
    ''' Controleer op regelmatige tijdstippen of we toevallig op een moment voor onderhoud aangekomen zijn.
    ''' Iedere derde donderdag van de maand tussen 12u en 13u worden de applicatieservers immers heropgestart.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimerOnderhoudTick(sender As Object, e As EventArgs) Handles _timerOnderhoud.Tick

        ' Een enkele message volstaat
        ' ---------------------------
        Static once As Boolean
        If once Then Return

        ' Haal het moment van de stilstand
        ' --------------------------------
        Dim config = DirectCast(CurrentFormManager.DataConfiguration, Client.TDSConfiguratie).BBCONF
        Dim nu As DateTime = DateTime.Now

        ' Controleer de dag van de week
        ' -----------------------------
        Dim dag As DayOfWeek
        Dim dayInfo = config.Select("GR_SLE = 'ALGEMEEN' AND SLE = 'ServerMaintenanceDay'")
        If Not dayInfo.Any Then Return
        If Not DayOfWeek.TryParse(DirectCast(dayInfo, Client.TDSConfiguratie.BBCONFRow()).First.WD, dag) Then Return

        If nu.DayOfWeek <> dag Then Return

        ' Controleer het uur + 5 minuten ervoor
        ' -------------------------------------
        Dim uur As Integer
        Dim hourInfo = config.Select("GR_SLE = 'ALGEMEEN' AND SLE = 'ServerMaintenanceHour'")
        If Not hourInfo.Any Then Return
        If Not Integer.TryParse(DirectCast(hourInfo, Client.TDSConfiguratie.BBCONFRow()).First.WD, uur) Then Return

        Dim hour As Integer = nu.Hour
        Dim minutes As Integer = nu.Minute
        If (hour <> uur) Then
            If hour <> uur - 1 OrElse minutes < 55 Then Return
        End If

        ' Controleer de week in de maand
        ' ------------------------------
        Dim week As Integer
        Dim weekInfo = config.Select("GR_SLE = 'ALGEMEEN' AND SLE = 'ServerMaintenanceWeek'")
        If Not weekInfo.Any Then Return
        If Not Integer.TryParse(DirectCast(weekInfo, Client.TDSConfiguratie.BBCONFRow()).First.WD, week) Then Return

        Dim maand As Integer = nu.Month
        Dim weekNr As Integer = 1
        If nu.AddDays(-7).Month = maand Then weekNr += 1
        If nu.AddDays(-14).Month = maand Then weekNr += 1
        If nu.AddDays(-21).Month = maand Then weekNr += 1
        If nu.AddDays(-28).Month = maand Then weekNr += 1

        If weekNr <> week Then Return

        ' Vraag de user om de toepassing de stoppen tot na de stilstand
        ' -------------------------------------------------------------
        Const msg As String = "Opgepast: de servers worden deze middag heropgestart. " &
                              "Gelieve de toepassing af te sluiten en pas om {0}u opnieuw op te starten."

        once = True
        MessageBox.Show(Me, String.Format(msg, uur + 1), "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        once = False
    End Sub

#End Region

End Class
