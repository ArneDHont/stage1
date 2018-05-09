Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaalOpLocatie
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BrandweerMateriaal", -1)
            Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatID")
            Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgNr")
            Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatOmschr", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
            Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoortTypeMatOmschr")
            Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FabricatieNr")
            Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AfdelingCode")
            Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieZone")
            Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieNr")
            Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LocatieOmschr")
            Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NaamLeverancier")
            Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BeheerderAfdelingNaam")
            Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LeveringsDatum")
            Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VisueleControleFreq")
            Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumVisueleKeuring")
            Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
            Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumPoederControle")
            Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumHervullingNaGebruik")
            Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HervullingGemeld")
            Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumLaatsteKeuring")
            Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumVolgendeKeuring")
            Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GroteControleFreq")
            Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BrandblusCodeomschr")
            Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VervangenDoor")
            Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DatumHerkeuringLeverancier")
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VolgnummerAfdeling")
            Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Poedercontrole", 0)
            Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Laatste Keuring", 1)
            Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naar Leverancier", 2)
            Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam Beheerder", 3)
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "TypeMatOmschr", 2, True, "BrandweerMateriaal", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Me.ToolStripMateriaal = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButtonNew = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonPrintFiche = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCopyClipboard = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonMissingNr = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonCheckList = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonHerkeuring = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonLogin = New System.Windows.Forms.ToolStripButton()
            Me.UltraPrintPreviewDialogGrid = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraGridPrintDoc = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            Me.UltraGridMaterial = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerMateriaal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaal()
            Me.UltraPrintDocument1 = New Infragistics.Win.Printing.UltraPrintDocument(Me.components)
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.LabelUserLogin = New System.Windows.Forms.Label()
            Me.ToolStripButtonDeleteMaterial = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripMateriaal.SuspendLayout()
            CType(Me.UltraGridMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerMateriaal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStripMateriaal
            '
            Me.ToolStripMateriaal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNew, Me.ToolStripButtonEdit, Me.ToolStripSeparator1, Me.ToolStripButtonPrintFiche, Me.ToolStripButtonPrint, Me.ToolStripButtonCopyClipboard, Me.ToolStripSeparator2, Me.ToolStripButtonMissingNr, Me.ToolStripButtonRefresh, Me.ToolStripSeparator3, Me.ToolStripButtonCheckList, Me.ToolStripButtonHerkeuring, Me.ToolStripButtonDeleteMaterial, Me.ToolStripButtonLogin})
            Me.ToolStripMateriaal.Location = New System.Drawing.Point(0, 0)
            Me.ToolStripMateriaal.Name = "ToolStripMateriaal"
            Me.ToolStripMateriaal.Size = New System.Drawing.Size(1718, 25)
            Me.ToolStripMateriaal.TabIndex = 1
            Me.ToolStripMateriaal.Text = "ToolStrip1"
            '
            'ToolStripButtonNew
            '
            Me.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonNew.Enabled = False
            Me.ToolStripButtonNew.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._New
            Me.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonNew.Name = "ToolStripButtonNew"
            Me.ToolStripButtonNew.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonNew.Text = "ToolStripButtonNew"
            Me.ToolStripButtonNew.ToolTipText = "Materiaal toevoegen"
            '
            'ToolStripButtonEdit
            '
            Me.ToolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonEdit.Enabled = False
            Me.ToolStripButtonEdit.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Edit
            Me.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonEdit.Name = "ToolStripButtonEdit"
            Me.ToolStripButtonEdit.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonEdit.Text = "Edit"
            Me.ToolStripButtonEdit.ToolTipText = "Materiaal wijzigen"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonPrintFiche
            '
            Me.ToolStripButtonPrintFiche.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._1483730697_print
            Me.ToolStripButtonPrintFiche.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrintFiche.Name = "ToolStripButtonPrintFiche"
            Me.ToolStripButtonPrintFiche.Size = New System.Drawing.Size(90, 22)
            Me.ToolStripButtonPrintFiche.Text = "Print 1 fiche"
            Me.ToolStripButtonPrintFiche.ToolTipText = "Print fiche van geselecteerd materiaal (onm. naar printer)"
            '
            'ToolStripButtonPrint
            '
            Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
            Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonPrint.Text = "Print"
            Me.ToolStripButtonPrint.ToolTipText = "Lijst materiaal afdrukken (afdrukvoorbeeld)"
            '
            'ToolStripButtonCopyClipboard
            '
            Me.ToolStripButtonCopyClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCopyClipboard.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Copy
            Me.ToolStripButtonCopyClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCopyClipboard.Name = "ToolStripButtonCopyClipboard"
            Me.ToolStripButtonCopyClipboard.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCopyClipboard.Text = "CopyClipboard"
            Me.ToolStripButtonCopyClipboard.ToolTipText = "Lijst kopiëren naar clipboard"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonMissingNr
            '
            Me.ToolStripButtonMissingNr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonMissingNr.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._123
            Me.ToolStripButtonMissingNr.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonMissingNr.Name = "ToolStripButtonMissingNr"
            Me.ToolStripButtonMissingNr.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonMissingNr.Text = "MissingNr"
            Me.ToolStripButtonMissingNr.ToolTipText = "Toon de lijst van de ontbrekende nummers voor de geselecteerde combinatie materia" & _
                "al/afdeling/zone"
            '
            'ToolStripButtonRefresh
            '
            Me.ToolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonRefresh.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Refresh
            Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
            Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonRefresh.Text = "Refresh"
            Me.ToolStripButtonRefresh.ToolTipText = "Refresh lijst en sorteer op Nr"
            '
            'ToolStripSeparator3
            '
            Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
            Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonCheckList
            '
            Me.ToolStripButtonCheckList.Enabled = False
            Me.ToolStripButtonCheckList.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Check
            Me.ToolStripButtonCheckList.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCheckList.Name = "ToolStripButtonCheckList"
            Me.ToolStripButtonCheckList.Size = New System.Drawing.Size(104, 22)
            Me.ToolStripButtonCheckList.Text = "Controlelijsten"
            Me.ToolStripButtonCheckList.ToolTipText = "Toon controlelijsten (visueel - poedercontrole)"
            '
            'ToolStripButtonHerkeuring
            '
            Me.ToolStripButtonHerkeuring.Enabled = False
            Me.ToolStripButtonHerkeuring.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._1485875482_tick_circle
            Me.ToolStripButtonHerkeuring.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonHerkeuring.Name = "ToolStripButtonHerkeuring"
            Me.ToolStripButtonHerkeuring.Size = New System.Drawing.Size(86, 22)
            Me.ToolStripButtonHerkeuring.Text = "Herkeuring"
            Me.ToolStripButtonHerkeuring.ToolTipText = "Herkeuring (datum ingeven)"
            '
            'ToolStripButtonLogin
            '
            Me.ToolStripButtonLogin.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources._1486653931_Login
            Me.ToolStripButtonLogin.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonLogin.Name = "ToolStripButtonLogin"
            Me.ToolStripButtonLogin.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButtonLogin.Text = "Login"
            Me.ToolStripButtonLogin.ToolTipText = "Login - wijzigen materiaal"
            '
            'UltraPrintPreviewDialogGrid
            '
            Me.UltraPrintPreviewDialogGrid.Document = Me.UltraGridPrintDoc
            Me.UltraPrintPreviewDialogGrid.Name = "UltraPrintPreviewDialogGrid"
            '
            'UltraGridPrintDoc
            '
            Me.UltraGridPrintDoc.Grid = Me.UltraGridMaterial
            '
            'UltraGridMaterial
            '
            Me.UltraGridMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGridMaterial.DataMember = "BrandweerMateriaal"
            Me.UltraGridMaterial.DataSource = Me._dataBrandweerMateriaal
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGridMaterial.DisplayLayout.Appearance = Appearance1
            UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn28.Header.Fixed = True
            UltraGridColumn28.Header.VisiblePosition = 0
            UltraGridColumn28.Hidden = True
            UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn29.Header.Caption = "MateriaalVolgnr"
            UltraGridColumn29.Header.VisiblePosition = 26
            UltraGridColumn29.Width = 111
            UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn30.Header.Caption = "Type Materiaal"
            UltraGridColumn30.Header.Fixed = True
            UltraGridColumn30.Header.VisiblePosition = 1
            UltraGridColumn30.RowLayoutColumnInfo.OriginX = 0
            UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn31.Header.Caption = "Soort Materiaal"
            UltraGridColumn31.Header.Fixed = True
            UltraGridColumn31.Header.VisiblePosition = 2
            UltraGridColumn31.RowLayoutColumnInfo.OriginX = 2
            UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn31.Width = 118
            UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn32.Header.Caption = "Fabricatie Nr"
            UltraGridColumn32.Header.VisiblePosition = 12
            UltraGridColumn32.RowLayoutColumnInfo.OriginX = 24
            UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn33.Header.Caption = "Afd"
            UltraGridColumn33.Header.Fixed = True
            UltraGridColumn33.Header.VisiblePosition = 3
            UltraGridColumn33.RowLayoutColumnInfo.OriginX = 4
            UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn33.Width = 71
            UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn34.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
            UltraGridColumn34.Header.Caption = "Zone"
            UltraGridColumn34.Header.Fixed = True
            UltraGridColumn34.Header.VisiblePosition = 4
            UltraGridColumn34.RowLayoutColumnInfo.OriginX = 6
            UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn34.Width = 73
            UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn35.Header.Caption = "Nr"
            UltraGridColumn35.Header.Fixed = True
            UltraGridColumn35.Header.VisiblePosition = 5
            UltraGridColumn35.RowLayoutColumnInfo.OriginX = 8
            UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn35.Width = 64
            UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn36.Header.Caption = "Locatie Omschrijving"
            UltraGridColumn36.Header.VisiblePosition = 6
            UltraGridColumn36.RowLayoutColumnInfo.OriginX = 10
            UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn36.Width = 261
            UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn37.Header.Caption = "Leverancier"
            UltraGridColumn37.Header.VisiblePosition = 7
            UltraGridColumn37.RowLayoutColumnInfo.OriginX = 12
            UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn38.Header.Caption = "Beheerder Afd"
            UltraGridColumn38.Header.VisiblePosition = 8
            UltraGridColumn38.RowLayoutColumnInfo.OriginX = 14
            UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn38.Width = 102
            UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn39.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn39.Header.Caption = "Leveringsdatum"
            UltraGridColumn39.Header.VisiblePosition = 9
            UltraGridColumn39.RowLayoutColumnInfo.OriginX = 16
            UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn40.Header.Caption = "Visuele contr."
            UltraGridColumn40.Header.VisiblePosition = 10
            UltraGridColumn40.RowLayoutColumnInfo.OriginX = 18
            UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn41.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn41.Header.Caption = "Datum vis. contr."
            UltraGridColumn41.Header.VisiblePosition = 11
            UltraGridColumn41.RowLayoutColumnInfo.OriginX = 20
            UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn41.Width = 110
            UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn42.Header.VisiblePosition = 20
            UltraGridColumn42.RowLayoutColumnInfo.OriginX = 22
            UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn43.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn43.Header.Caption = "Poeder/Schuim contr"
            UltraGridColumn43.Header.VisiblePosition = 16
            UltraGridColumn43.Width = 126
            UltraGridColumn44.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn44.Header.Caption = "Hervulling na gebruik"
            UltraGridColumn44.Header.VisiblePosition = 18
            UltraGridColumn45.Header.Caption = "Hervulling gemeld"
            UltraGridColumn45.Header.VisiblePosition = 19
            UltraGridColumn46.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn46.Header.Caption = "Laatste keuring"
            UltraGridColumn46.Header.VisiblePosition = 14
            UltraGridColumn47.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn47.Header.Caption = "Datum vlgnde keuring"
            UltraGridColumn47.Header.VisiblePosition = 15
            UltraGridColumn48.Header.Caption = "Keuring freq (m)"
            UltraGridColumn48.Header.VisiblePosition = 21
            UltraGridColumn48.Hidden = True
            UltraGridColumn49.Header.Caption = "Brandbluscode"
            UltraGridColumn49.Header.VisiblePosition = 22
            UltraGridColumn50.Header.VisiblePosition = 27
            UltraGridColumn51.Header.Caption = "Datum nr leverancier"
            UltraGridColumn51.Header.VisiblePosition = 23
            UltraGridColumn1.Header.VisiblePosition = 24
            UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn52.Header.VisiblePosition = 13
            UltraGridColumn52.Hidden = True
            UltraGridColumn52.RowLayoutColumnInfo.OriginX = 26
            UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn54.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo
            UltraGridColumn54.Header.VisiblePosition = 17
            UltraGridColumn54.Hidden = True
            UltraGridColumn54.RowLayoutColumnInfo.OriginX = 28
            UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn55.Header.VisiblePosition = 25
            UltraGridColumn55.Hidden = True
            UltraGridColumn55.RowLayoutColumnInfo.OriginX = 30
            UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
            UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn56.Header.VisiblePosition = 28
            UltraGridColumn56.Hidden = True
            UltraGridColumn56.RowLayoutColumnInfo.OriginX = 32
            UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
            UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
            UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn1, UltraGridColumn52, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance2
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGridMaterial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGridMaterial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGridMaterial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance3.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridMaterial.DisplayLayout.GroupByBox.Appearance = Appearance3
            Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridMaterial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
            Me.UltraGridMaterial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance5.BackColor2 = System.Drawing.SystemColors.Control
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGridMaterial.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
            Me.UltraGridMaterial.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGridMaterial.DisplayLayout.MaxRowScrollRegions = 1
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGridMaterial.DisplayLayout.Override.ActiveCellAppearance = Appearance6
            Appearance7.BackColor = System.Drawing.SystemColors.Highlight
            Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGridMaterial.DisplayLayout.Override.ActiveRowAppearance = Appearance7
            Me.UltraGridMaterial.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGridMaterial.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridMaterial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGridMaterial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGridMaterial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGridMaterial.DisplayLayout.Override.CardAreaAppearance = Appearance8
            Appearance9.BorderColor = System.Drawing.Color.Silver
            Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGridMaterial.DisplayLayout.Override.CellAppearance = Appearance9
            Me.UltraGridMaterial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGridMaterial.DisplayLayout.Override.CellPadding = 0
            Me.UltraGridMaterial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance10.BackColor = System.Drawing.SystemColors.Control
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGridMaterial.DisplayLayout.Override.GroupByRowAppearance = Appearance10
            Appearance11.TextHAlignAsString = "Left"
            Me.UltraGridMaterial.DisplayLayout.Override.HeaderAppearance = Appearance11
            Me.UltraGridMaterial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGridMaterial.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance12.BackColor = System.Drawing.SystemColors.Info
            Me.UltraGridMaterial.DisplayLayout.Override.RowAlternateAppearance = Appearance12
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.BorderColor = System.Drawing.Color.Silver
            Me.UltraGridMaterial.DisplayLayout.Override.RowAppearance = Appearance13
            Me.UltraGridMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGridMaterial.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridMaterial.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGridMaterial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
            Me.UltraGridMaterial.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGridMaterial.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
            Me.UltraGridMaterial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGridMaterial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGridMaterial.DisplayLayout.UseFixedHeaders = True
            Me.UltraGridMaterial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGridMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGridMaterial.Location = New System.Drawing.Point(12, 28)
            Me.UltraGridMaterial.Name = "UltraGridMaterial"
            Me.UltraGridMaterial.Size = New System.Drawing.Size(1694, 508)
            Me.UltraGridMaterial.TabIndex = 2
            Me.UltraGridMaterial.Text = "UltraGrid1"
            '
            '_dataBrandweerMateriaal
            '
            Me._dataBrandweerMateriaal.DataSetName = "TDSBrandweerMateriaal"
            Me._dataBrandweerMateriaal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'LinkLabel1
            '
            Me.LinkLabel1.AutoSize = True
            Me.LinkLabel1.Location = New System.Drawing.Point(767, 6)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(159, 13)
            Me.LinkLabel1.TabIndex = 3
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "Handleiding Brandweermateriaal"
            '
            'LabelUserLogin
            '
            Me.LabelUserLogin.AutoSize = True
            Me.LabelUserLogin.Location = New System.Drawing.Point(650, 6)
            Me.LabelUserLogin.Name = "LabelUserLogin"
            Me.LabelUserLogin.Size = New System.Drawing.Size(0, 13)
            Me.LabelUserLogin.TabIndex = 4
            '
            'ToolStripButtonDeleteMaterial
            '
            Me.ToolStripButtonDeleteMaterial.Enabled = False
            Me.ToolStripButtonDeleteMaterial.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Trashcan
            Me.ToolStripButtonDeleteMaterial.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonDeleteMaterial.Name = "ToolStripButtonDeleteMaterial"
            Me.ToolStripButtonDeleteMaterial.Size = New System.Drawing.Size(100, 22)
            Me.ToolStripButtonDeleteMaterial.Text = "Verwijder mat"
            Me.ToolStripButtonDeleteMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolStripButtonDeleteMaterial.ToolTipText = "Verwijder mat (DateDeleted instellen)"
            '
            'FormBrandweerMateriaalOpLocatie
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1718, 548)
            Me.Controls.Add(Me.LabelUserLogin)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.UltraGridMaterial)
            Me.Controls.Add(Me.ToolStripMateriaal)
            Me.Name = "FormBrandweerMateriaalOpLocatie"
            Me.ShowInTaskbar = False
            Me.Text = "Overzicht brandweer materiaal"
            Me.ToolStripMateriaal.ResumeLayout(False)
            Me.ToolStripMateriaal.PerformLayout()
            CType(Me.UltraGridMaterial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerMateriaal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ToolStripMateriaal As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButtonNew As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonEdit As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCopyClipboard As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonMissingNr As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCheckList As System.Windows.Forms.ToolStripButton
        Friend WithEvents _dataBrandweerMateriaal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaal
        Friend WithEvents UltraGridMaterial As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents UltraPrintPreviewDialogGrid As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraGridPrintDoc As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
        Friend WithEvents UltraPrintDocument1 As Infragistics.Win.Printing.UltraPrintDocument
        Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonPrintFiche As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonHerkeuring As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
        Friend WithEvents ToolStripButtonLogin As System.Windows.Forms.ToolStripButton
        Friend WithEvents LabelUserLogin As System.Windows.Forms.Label
        Friend WithEvents ToolStripButtonDeleteMaterial As System.Windows.Forms.ToolStripButton
    End Class
End Namespace