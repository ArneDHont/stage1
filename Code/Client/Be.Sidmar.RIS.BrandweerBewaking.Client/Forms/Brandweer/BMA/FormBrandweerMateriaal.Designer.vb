Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaal
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
            Dim DateButton1 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton2 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton3 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton4 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton5 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton6 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton7 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("MateriaalActie", -1)
            Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieId")
            Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TypeMatId")
            Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MateriaalVolgnr")
            Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Datum", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
            Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieCodeId")
            Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieOmschr")
            Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gewicht")
            Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "Datum", 3, True, "MateriaalActie", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
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
            Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
            Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
            Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
            Me.BeheerderAfdelingText = New System.Windows.Forms.TextBox()
            Me.ControleFrequentieText = New System.Windows.Forms.TextBox()
            Me.VolgendeNazichtText = New System.Windows.Forms.TextBox()
            Me.LaatsteNazichtCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.VolgendeKeuringText = New System.Windows.Forms.TextBox()
            Me.LaatsteKeuringsdatumCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.LeveringsdatumCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.StatusCombo = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerStatus = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerStatus()
            Me.VolgnummerText = New System.Windows.Forms.TextBox()
            Me.FabricatienummerText = New System.Windows.Forms.TextBox()
            Me.LeveranciersCombo = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerLeveranciers = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerLeveranciers()
            Me.TypeMateriaalCombo = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerTypeMateriaal1 = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerTypeMateriaal()
            Me.SoortBlustoestelCombo = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerSoortBlustoestel1 = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerSoortBlustoestel()
            Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
            Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
            Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
            Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
            Me._dataBrandweerBeheerderAfdeling = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerBeheerderAfdeling()
            Me.AnnulerenButton = New System.Windows.Forms.Button()
            Me.SaveButton = New System.Windows.Forms.Button()
            Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
            Me.PlaatsOmschrijvingText = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.LocatienummerText = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.ZoneCombo = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerAfdelingen()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.AfdelingCombo = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
            Me.LabelVervangenDoorOmschr = New System.Windows.Forms.Label()
            Me.CheckBoxLijnToevoegen = New System.Windows.Forms.CheckBox()
            Me.NietGemeldRadioButton = New System.Windows.Forms.RadioButton()
            Me.TelefonischGemeldRadioButton = New System.Windows.Forms.RadioButton()
            Me.GemeldRadioButton = New System.Windows.Forms.RadioButton()
            Me.VervangenDoorButton = New System.Windows.Forms.Button()
            Me.PoederVolgendeCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.VervangenDoorText = New System.Windows.Forms.TextBox()
            Me.LeverancierDatumCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.HervullingDatumCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.PoederDatumCombo = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
            Me.OpmerkingText = New System.Windows.Forms.TextBox()
            Me._dataBrandweerMateriaalItem = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaalItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.MateriaalFicheButton = New System.Windows.Forms.Button()
            Me.PrintButton = New System.Windows.Forms.Button()
            Me.UltraPrintDocument1 = New Infragistics.Win.Printing.UltraPrintDocument(Me.components)
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataBrandweerMateriaalActie = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerMateriaalActie()
            CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraGroupBox1.SuspendLayout()
            CType(Me.LaatsteNazichtCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LaatsteKeuringsdatumCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LeveringsdatumCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerLeveranciers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerTypeMateriaal1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerSoortBlustoestel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerBeheerderAfdeling, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraGroupBox2.SuspendLayout()
            CType(Me._dataBrandweerAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraGroupBox3.SuspendLayout()
            CType(Me.PoederVolgendeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LeverancierDatumCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HervullingDatumCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PoederDatumCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraGroupBox4.SuspendLayout()
            CType(Me._dataBrandweerMateriaalItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerMateriaalActie, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'UltraLabel1
            '
            Me.UltraLabel1.AutoSize = True
            Me.UltraLabel1.Location = New System.Drawing.Point(10, 10)
            Me.UltraLabel1.Name = "UltraLabel1"
            Me.UltraLabel1.Size = New System.Drawing.Size(79, 14)
            Me.UltraLabel1.TabIndex = 0
            Me.UltraLabel1.Text = "Type Materiaal"
            '
            'UltraLabel2
            '
            Me.UltraLabel2.AutoSize = True
            Me.UltraLabel2.Location = New System.Drawing.Point(10, 36)
            Me.UltraLabel2.Name = "UltraLabel2"
            Me.UltraLabel2.Size = New System.Drawing.Size(90, 14)
            Me.UltraLabel2.TabIndex = 2
            Me.UltraLabel2.Text = "Soort Blustoestel"
            '
            'UltraGroupBox1
            '
            Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGroupBox1.Controls.Add(Me.BeheerderAfdelingText)
            Me.UltraGroupBox1.Controls.Add(Me.ControleFrequentieText)
            Me.UltraGroupBox1.Controls.Add(Me.VolgendeNazichtText)
            Me.UltraGroupBox1.Controls.Add(Me.LaatsteNazichtCombo)
            Me.UltraGroupBox1.Controls.Add(Me.VolgendeKeuringText)
            Me.UltraGroupBox1.Controls.Add(Me.LaatsteKeuringsdatumCombo)
            Me.UltraGroupBox1.Controls.Add(Me.Label7)
            Me.UltraGroupBox1.Controls.Add(Me.Label6)
            Me.UltraGroupBox1.Controls.Add(Me.Label4)
            Me.UltraGroupBox1.Controls.Add(Me.Label5)
            Me.UltraGroupBox1.Controls.Add(Me.Label3)
            Me.UltraGroupBox1.Controls.Add(Me.Label2)
            Me.UltraGroupBox1.Controls.Add(Me.LeveringsdatumCombo)
            Me.UltraGroupBox1.Controls.Add(Me.Label1)
            Me.UltraGroupBox1.Controls.Add(Me.StatusCombo)
            Me.UltraGroupBox1.Controls.Add(Me.VolgnummerText)
            Me.UltraGroupBox1.Controls.Add(Me.FabricatienummerText)
            Me.UltraGroupBox1.Controls.Add(Me.LeveranciersCombo)
            Me.UltraGroupBox1.Controls.Add(Me.TypeMateriaalCombo)
            Me.UltraGroupBox1.Controls.Add(Me.SoortBlustoestelCombo)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
            Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
            Me.UltraGroupBox1.Location = New System.Drawing.Point(13, 12)
            Me.UltraGroupBox1.Name = "UltraGroupBox1"
            Me.UltraGroupBox1.Size = New System.Drawing.Size(1115, 189)
            Me.UltraGroupBox1.TabIndex = 0
            '
            'BeheerderAfdelingText
            '
            Me.BeheerderAfdelingText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BeheerderAfdelingText.Location = New System.Drawing.Point(825, 148)
            Me.BeheerderAfdelingText.Name = "BeheerderAfdelingText"
            Me.BeheerderAfdelingText.ReadOnly = True
            Me.BeheerderAfdelingText.Size = New System.Drawing.Size(283, 20)
            Me.BeheerderAfdelingText.TabIndex = 25
            '
            'ControleFrequentieText
            '
            Me.ControleFrequentieText.Location = New System.Drawing.Point(646, 148)
            Me.ControleFrequentieText.MaxLength = 3
            Me.ControleFrequentieText.Name = "ControleFrequentieText"
            Me.ControleFrequentieText.Size = New System.Drawing.Size(100, 20)
            Me.ControleFrequentieText.TabIndex = 23
            Me.ToolTip1.SetToolTip(Me.ControleFrequentieText, "Om de hoeveel maand moet dit toestel visueel gecontroleerd worden?")
            '
            'VolgendeNazichtText
            '
            Me.VolgendeNazichtText.Location = New System.Drawing.Point(540, 148)
            Me.VolgendeNazichtText.Name = "VolgendeNazichtText"
            Me.VolgendeNazichtText.ReadOnly = True
            Me.VolgendeNazichtText.Size = New System.Drawing.Size(100, 20)
            Me.VolgendeNazichtText.TabIndex = 21
            '
            'LaatsteNazichtCombo
            '
            Me.LaatsteNazichtCombo.DateButtons.Add(DateButton1)
            Me.LaatsteNazichtCombo.Location = New System.Drawing.Point(412, 148)
            Me.LaatsteNazichtCombo.Name = "LaatsteNazichtCombo"
            Me.LaatsteNazichtCombo.NonAutoSizeHeight = 21
            Me.LaatsteNazichtCombo.Size = New System.Drawing.Size(121, 21)
            Me.LaatsteNazichtCombo.TabIndex = 19
            Me.LaatsteNazichtCombo.Value = ""
            '
            'VolgendeKeuringText
            '
            Me.VolgendeKeuringText.Location = New System.Drawing.Point(141, 148)
            Me.VolgendeKeuringText.Name = "VolgendeKeuringText"
            Me.VolgendeKeuringText.ReadOnly = True
            Me.VolgendeKeuringText.Size = New System.Drawing.Size(100, 20)
            Me.VolgendeKeuringText.TabIndex = 17
            Me.ToolTip1.SetToolTip(Me.VolgendeKeuringText, "laatste keuring + 10 jaar")
            '
            'LaatsteKeuringsdatumCombo
            '
            Me.LaatsteKeuringsdatumCombo.DateButtons.Add(DateButton2)
            Me.LaatsteKeuringsdatumCombo.Location = New System.Drawing.Point(13, 148)
            Me.LaatsteKeuringsdatumCombo.Name = "LaatsteKeuringsdatumCombo"
            Me.LaatsteKeuringsdatumCombo.NonAutoSizeHeight = 21
            Me.LaatsteKeuringsdatumCombo.Size = New System.Drawing.Size(121, 21)
            Me.LaatsteKeuringsdatumCombo.TabIndex = 15
            Me.LaatsteKeuringsdatumCombo.Value = ""
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(823, 131)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(77, 13)
            Me.Label7.TabIndex = 24
            Me.Label7.Text = "Beheerder afd."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(643, 131)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(123, 13)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "Controle freq. (maanden)"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(537, 131)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(89, 13)
            Me.Label4.TabIndex = 20
            Me.Label4.Text = "Volgende nazicht"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(411, 131)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(79, 13)
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "Laatste nazicht"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(138, 131)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(90, 13)
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Volgende keuring"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 131)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(114, 13)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Laatste keuringsdatum"
            '
            'LeveringsdatumCombo
            '
            Me.LeveringsdatumCombo.DateButtons.Add(DateButton3)
            Me.LeveringsdatumCombo.Location = New System.Drawing.Point(523, 60)
            Me.LeveringsdatumCombo.Name = "LeveringsdatumCombo"
            Me.LeveringsdatumCombo.NonAutoSizeHeight = 21
            Me.LeveringsdatumCombo.Size = New System.Drawing.Size(121, 21)
            Me.LeveringsdatumCombo.TabIndex = 11
            Me.LeveringsdatumCombo.Value = ""
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(412, 62)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(82, 13)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Leveringsdatum"
            '
            'StatusCombo
            '
            Me.StatusCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.StatusCombo.DataSource = Me._dataBrandweerStatus
            Me.StatusCombo.DisplayMember = "Status.Status"
            Me.StatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.StatusCombo.FormattingEnabled = True
            Me.StatusCombo.Location = New System.Drawing.Point(121, 61)
            Me.StatusCombo.Name = "StatusCombo"
            Me.StatusCombo.Size = New System.Drawing.Size(238, 21)
            Me.StatusCombo.TabIndex = 5
            Me.StatusCombo.ValueMember = "Status.StatusId"
            '
            '_dataBrandweerStatus
            '
            Me._dataBrandweerStatus.DataSetName = "TDSBrandweerStatus"
            Me._dataBrandweerStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'VolgnummerText
            '
            Me.VolgnummerText.Location = New System.Drawing.Point(872, 10)
            Me.VolgnummerText.Name = "VolgnummerText"
            Me.VolgnummerText.ReadOnly = True
            Me.VolgnummerText.Size = New System.Drawing.Size(84, 20)
            Me.VolgnummerText.TabIndex = 13
            Me.ToolTip1.SetToolTip(Me.VolgnummerText, "Intern volgnr database")
            '
            'FabricatienummerText
            '
            Me.FabricatienummerText.Location = New System.Drawing.Point(523, 34)
            Me.FabricatienummerText.MaxLength = 20
            Me.FabricatienummerText.Name = "FabricatienummerText"
            Me.FabricatienummerText.Size = New System.Drawing.Size(118, 20)
            Me.FabricatienummerText.TabIndex = 9
            '
            'LeveranciersCombo
            '
            Me.LeveranciersCombo.DataSource = Me._dataBrandweerLeveranciers
            Me.LeveranciersCombo.DisplayMember = "Leverancier.NaamLeverancier"
            Me.LeveranciersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.LeveranciersCombo.FormattingEnabled = True
            Me.LeveranciersCombo.Location = New System.Drawing.Point(523, 7)
            Me.LeveranciersCombo.MaxDropDownItems = 12
            Me.LeveranciersCombo.Name = "LeveranciersCombo"
            Me.LeveranciersCombo.Size = New System.Drawing.Size(238, 21)
            Me.LeveranciersCombo.TabIndex = 7
            Me.LeveranciersCombo.ValueMember = "Leverancier.LeverancierID"
            '
            '_dataBrandweerLeveranciers
            '
            Me._dataBrandweerLeveranciers.DataSetName = "TDSBrandweerLeveranciers"
            Me._dataBrandweerLeveranciers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TypeMateriaalCombo
            '
            Me.TypeMateriaalCombo.DataSource = Me._dataBrandweerTypeMateriaal1
            Me.TypeMateriaalCombo.DisplayMember = "BrandweerMateriaalTypes.TypeMatOmschr"
            Me.TypeMateriaalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.TypeMateriaalCombo.FormattingEnabled = True
            Me.TypeMateriaalCombo.Location = New System.Drawing.Point(121, 6)
            Me.TypeMateriaalCombo.MaxDropDownItems = 12
            Me.TypeMateriaalCombo.Name = "TypeMateriaalCombo"
            Me.TypeMateriaalCombo.Size = New System.Drawing.Size(238, 21)
            Me.TypeMateriaalCombo.TabIndex = 1
            Me.TypeMateriaalCombo.ValueMember = "BrandweerMateriaalTypes.TypeMatID"
            '
            '_dataBrandweerTypeMateriaal1
            '
            Me._dataBrandweerTypeMateriaal1.DataSetName = "TDSBrandweerTypeMateriaal"
            Me._dataBrandweerTypeMateriaal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'SoortBlustoestelCombo
            '
            Me.SoortBlustoestelCombo.DataSource = Me._dataBrandweerSoortBlustoestel1
            Me.SoortBlustoestelCombo.DisplayMember = "TypeBlustoestel.SoortTypeMatOmschr"
            Me.SoortBlustoestelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.SoortBlustoestelCombo.FormattingEnabled = True
            Me.SoortBlustoestelCombo.Location = New System.Drawing.Point(121, 33)
            Me.SoortBlustoestelCombo.MaxDropDownItems = 12
            Me.SoortBlustoestelCombo.Name = "SoortBlustoestelCombo"
            Me.SoortBlustoestelCombo.Size = New System.Drawing.Size(238, 21)
            Me.SoortBlustoestelCombo.TabIndex = 3
            Me.SoortBlustoestelCombo.ValueMember = "TypeBlustoestel.SoortTypeMatID"
            '
            '_dataBrandweerSoortBlustoestel1
            '
            Me._dataBrandweerSoortBlustoestel1.DataSetName = "TDSBrandweerSoortBlustoestel"
            Me._dataBrandweerSoortBlustoestel1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'UltraLabel6
            '
            Me.UltraLabel6.AutoSize = True
            Me.UltraLabel6.Location = New System.Drawing.Point(10, 61)
            Me.UltraLabel6.Name = "UltraLabel6"
            Me.UltraLabel6.Size = New System.Drawing.Size(36, 14)
            Me.UltraLabel6.TabIndex = 4
            Me.UltraLabel6.Text = "Status"
            '
            'UltraLabel5
            '
            Me.UltraLabel5.AutoSize = True
            Me.UltraLabel5.Location = New System.Drawing.Point(826, 10)
            Me.UltraLabel5.Name = "UltraLabel5"
            Me.UltraLabel5.Size = New System.Drawing.Size(37, 14)
            Me.UltraLabel5.TabIndex = 12
            Me.UltraLabel5.Text = "Volgnr"
            '
            'UltraLabel4
            '
            Me.UltraLabel4.AutoSize = True
            Me.UltraLabel4.Location = New System.Drawing.Point(412, 10)
            Me.UltraLabel4.Name = "UltraLabel4"
            Me.UltraLabel4.Size = New System.Drawing.Size(63, 14)
            Me.UltraLabel4.TabIndex = 6
            Me.UltraLabel4.Text = "Leverancier"
            '
            'UltraLabel3
            '
            Me.UltraLabel3.AutoSize = True
            Me.UltraLabel3.Location = New System.Drawing.Point(412, 36)
            Me.UltraLabel3.Name = "UltraLabel3"
            Me.UltraLabel3.Size = New System.Drawing.Size(96, 14)
            Me.UltraLabel3.TabIndex = 8
            Me.UltraLabel3.Text = "Fabricatienummer"
            '
            '_dataBrandweerBeheerderAfdeling
            '
            Me._dataBrandweerBeheerderAfdeling.DataSetName = "TDSBrandweerBeheerderAfdeling"
            Me._dataBrandweerBeheerderAfdeling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'AnnulerenButton
            '
            Me.AnnulerenButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.AnnulerenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.AnnulerenButton.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
            Me.AnnulerenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.AnnulerenButton.Location = New System.Drawing.Point(1051, 610)
            Me.AnnulerenButton.Name = "AnnulerenButton"
            Me.AnnulerenButton.Size = New System.Drawing.Size(80, 24)
            Me.AnnulerenButton.TabIndex = 7
            Me.AnnulerenButton.Text = "Annuleren"
            Me.AnnulerenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.AnnulerenButton, "Wijzigingen niet bewaren")
            Me.AnnulerenButton.UseVisualStyleBackColor = True
            '
            'SaveButton
            '
            Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SaveButton.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Save
            Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.SaveButton.Location = New System.Drawing.Point(965, 610)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(80, 24)
            Me.SaveButton.TabIndex = 6
            Me.SaveButton.Text = "Opslaan"
            Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.SaveButton, "Materiaal wijzigingen bewaren")
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'UltraGroupBox2
            '
            Me.UltraGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGroupBox2.Controls.Add(Me.PlaatsOmschrijvingText)
            Me.UltraGroupBox2.Controls.Add(Me.Label11)
            Me.UltraGroupBox2.Controls.Add(Me.LocatienummerText)
            Me.UltraGroupBox2.Controls.Add(Me.Label10)
            Me.UltraGroupBox2.Controls.Add(Me.ZoneCombo)
            Me.UltraGroupBox2.Controls.Add(Me.Label9)
            Me.UltraGroupBox2.Controls.Add(Me.AfdelingCombo)
            Me.UltraGroupBox2.Controls.Add(Me.Label8)
            Me.UltraGroupBox2.Location = New System.Drawing.Point(13, 207)
            Me.UltraGroupBox2.Name = "UltraGroupBox2"
            Me.UltraGroupBox2.Size = New System.Drawing.Size(1115, 53)
            Me.UltraGroupBox2.TabIndex = 1
            '
            'PlaatsOmschrijvingText
            '
            Me.PlaatsOmschrijvingText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PlaatsOmschrijvingText.Location = New System.Drawing.Point(341, 22)
            Me.PlaatsOmschrijvingText.MaxLength = 150
            Me.PlaatsOmschrijvingText.Name = "PlaatsOmschrijvingText"
            Me.PlaatsOmschrijvingText.Size = New System.Drawing.Size(767, 20)
            Me.PlaatsOmschrijvingText.TabIndex = 7
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(341, 5)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(99, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Plaats Omschrijving"
            '
            'LocatienummerText
            '
            Me.LocatienummerText.Location = New System.Drawing.Point(285, 22)
            Me.LocatienummerText.MaxLength = 5
            Me.LocatienummerText.Name = "LocatienummerText"
            Me.LocatienummerText.Size = New System.Drawing.Size(50, 20)
            Me.LocatienummerText.TabIndex = 5
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(282, 5)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(18, 13)
            Me.Label10.TabIndex = 4
            Me.Label10.Text = "Nr"
            '
            'ZoneCombo
            '
            Me.ZoneCombo.DataSource = Me._dataBrandweerAfdelingen
            Me.ZoneCombo.DisplayMember = "Zone.LocatieZone"
            Me.ZoneCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ZoneCombo.FormattingEnabled = True
            Me.ZoneCombo.Location = New System.Drawing.Point(202, 22)
            Me.ZoneCombo.MaxDropDownItems = 12
            Me.ZoneCombo.Name = "ZoneCombo"
            Me.ZoneCombo.Size = New System.Drawing.Size(77, 21)
            Me.ZoneCombo.TabIndex = 3
            Me.ZoneCombo.ValueMember = "Zone.LocatieID"
            '
            '_dataBrandweerAfdelingen
            '
            Me._dataBrandweerAfdelingen.DataSetName = "TDSBrandweerAfdelingen"
            Me._dataBrandweerAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(201, 6)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(32, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Zone"
            '
            'AfdelingCombo
            '
            Me.AfdelingCombo.DataSource = Me._dataBrandweerAfdelingen
            Me.AfdelingCombo.DisplayMember = "Afdeling.AfdelingNaam"
            Me.AfdelingCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.AfdelingCombo.FormattingEnabled = True
            Me.AfdelingCombo.Location = New System.Drawing.Point(13, 22)
            Me.AfdelingCombo.MaxDropDownItems = 12
            Me.AfdelingCombo.Name = "AfdelingCombo"
            Me.AfdelingCombo.Size = New System.Drawing.Size(183, 21)
            Me.AfdelingCombo.TabIndex = 1
            Me.AfdelingCombo.ValueMember = "Afdeling.AfdelingID"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(10, 5)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(45, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Afdeling"
            '
            'UltraGroupBox3
            '
            Me.UltraGroupBox3.Controls.Add(Me.LabelVervangenDoorOmschr)
            Me.UltraGroupBox3.Controls.Add(Me.CheckBoxLijnToevoegen)
            Me.UltraGroupBox3.Controls.Add(Me.NietGemeldRadioButton)
            Me.UltraGroupBox3.Controls.Add(Me.TelefonischGemeldRadioButton)
            Me.UltraGroupBox3.Controls.Add(Me.GemeldRadioButton)
            Me.UltraGroupBox3.Controls.Add(Me.VervangenDoorButton)
            Me.UltraGroupBox3.Controls.Add(Me.PoederVolgendeCombo)
            Me.UltraGroupBox3.Controls.Add(Me.Label17)
            Me.UltraGroupBox3.Controls.Add(Me.Label16)
            Me.UltraGroupBox3.Controls.Add(Me.VervangenDoorText)
            Me.UltraGroupBox3.Controls.Add(Me.LeverancierDatumCombo)
            Me.UltraGroupBox3.Controls.Add(Me.HervullingDatumCombo)
            Me.UltraGroupBox3.Controls.Add(Me.PoederDatumCombo)
            Me.UltraGroupBox3.Controls.Add(Me.Label15)
            Me.UltraGroupBox3.Controls.Add(Me.Label14)
            Me.UltraGroupBox3.Controls.Add(Me.Label13)
            Me.UltraGroupBox3.Controls.Add(Me.Label12)
            Me.UltraGroupBox3.Location = New System.Drawing.Point(13, 269)
            Me.UltraGroupBox3.Name = "UltraGroupBox3"
            Me.UltraGroupBox3.Size = New System.Drawing.Size(762, 151)
            Me.UltraGroupBox3.TabIndex = 2
            Me.UltraGroupBox3.Text = "Uitgevoerde handelingen"
            '
            'LabelVervangenDoorOmschr
            '
            Me.LabelVervangenDoorOmschr.AutoSize = True
            Me.LabelVervangenDoorOmschr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelVervangenDoorOmschr.ForeColor = System.Drawing.Color.DarkBlue
            Me.LabelVervangenDoorOmschr.Location = New System.Drawing.Point(345, 123)
            Me.LabelVervangenDoorOmschr.Name = "LabelVervangenDoorOmschr"
            Me.LabelVervangenDoorOmschr.Size = New System.Drawing.Size(0, 13)
            Me.LabelVervangenDoorOmschr.TabIndex = 16
            '
            'CheckBoxLijnToevoegen
            '
            Me.CheckBoxLijnToevoegen.AutoSize = True
            Me.CheckBoxLijnToevoegen.Location = New System.Drawing.Point(324, 96)
            Me.CheckBoxLijnToevoegen.Name = "CheckBoxLijnToevoegen"
            Me.CheckBoxLijnToevoegen.Size = New System.Drawing.Size(164, 17)
            Me.CheckBoxLijnToevoegen.TabIndex = 15
            Me.CheckBoxLijnToevoegen.Text = "Lijn toevoegen bij verzending"
            Me.CheckBoxLijnToevoegen.UseVisualStyleBackColor = True
            Me.CheckBoxLijnToevoegen.Visible = False
            '
            'NietGemeldRadioButton
            '
            Me.NietGemeldRadioButton.AutoSize = True
            Me.NietGemeldRadioButton.Location = New System.Drawing.Point(514, 69)
            Me.NietGemeldRadioButton.Name = "NietGemeldRadioButton"
            Me.NietGemeldRadioButton.Size = New System.Drawing.Size(81, 17)
            Me.NietGemeldRadioButton.TabIndex = 9
            Me.NietGemeldRadioButton.TabStop = True
            Me.NietGemeldRadioButton.Text = "Niet gemeld"
            Me.NietGemeldRadioButton.UseVisualStyleBackColor = True
            '
            'TelefonischGemeldRadioButton
            '
            Me.TelefonischGemeldRadioButton.AutoSize = True
            Me.TelefonischGemeldRadioButton.Location = New System.Drawing.Point(391, 69)
            Me.TelefonischGemeldRadioButton.Name = "TelefonischGemeldRadioButton"
            Me.TelefonischGemeldRadioButton.Size = New System.Drawing.Size(117, 17)
            Me.TelefonischGemeldRadioButton.TabIndex = 8
            Me.TelefonischGemeldRadioButton.TabStop = True
            Me.TelefonischGemeldRadioButton.Text = "Telefonisch gemeld"
            Me.TelefonischGemeldRadioButton.UseVisualStyleBackColor = True
            '
            'GemeldRadioButton
            '
            Me.GemeldRadioButton.AutoSize = True
            Me.GemeldRadioButton.Location = New System.Drawing.Point(324, 69)
            Me.GemeldRadioButton.Name = "GemeldRadioButton"
            Me.GemeldRadioButton.Size = New System.Drawing.Size(61, 17)
            Me.GemeldRadioButton.TabIndex = 7
            Me.GemeldRadioButton.TabStop = True
            Me.GemeldRadioButton.Text = "Gemeld"
            Me.GemeldRadioButton.UseVisualStyleBackColor = True
            '
            'VervangenDoorButton
            '
            Me.VervangenDoorButton.Location = New System.Drawing.Point(300, 118)
            Me.VervangenDoorButton.Name = "VervangenDoorButton"
            Me.VervangenDoorButton.Size = New System.Drawing.Size(24, 23)
            Me.VervangenDoorButton.TabIndex = 14
            Me.VervangenDoorButton.Text = "..."
            Me.VervangenDoorButton.UseVisualStyleBackColor = True
            '
            'PoederVolgendeCombo
            '
            Me.PoederVolgendeCombo.DateButtons.Add(DateButton4)
            Me.PoederVolgendeCombo.Location = New System.Drawing.Point(323, 37)
            Me.PoederVolgendeCombo.Name = "PoederVolgendeCombo"
            Me.PoederVolgendeCombo.NonAutoSizeHeight = 21
            Me.PoederVolgendeCombo.Size = New System.Drawing.Size(121, 21)
            Me.PoederVolgendeCombo.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.PoederVolgendeCombo, "Poeder: + 2 jaar / Schuim:+ 6 jaar")
            Me.PoederVolgendeCombo.Value = ""
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(321, 20)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(89, 13)
            Me.Label17.TabIndex = 1
            Me.Label17.Text = "Volgende nazicht"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(10, 124)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(120, 13)
            Me.Label16.TabIndex = 12
            Me.Label16.Text = "Tijdelijk vervangen door"
            '
            'VervangenDoorText
            '
            Me.VervangenDoorText.Enabled = False
            Me.VervangenDoorText.Location = New System.Drawing.Point(144, 121)
            Me.VervangenDoorText.Name = "VervangenDoorText"
            Me.VervangenDoorText.Size = New System.Drawing.Size(150, 20)
            Me.VervangenDoorText.TabIndex = 13
            '
            'LeverancierDatumCombo
            '
            Me.LeverancierDatumCombo.DateButtons.Add(DateButton5)
            Me.LeverancierDatumCombo.Location = New System.Drawing.Point(144, 93)
            Me.LeverancierDatumCombo.Name = "LeverancierDatumCombo"
            Me.LeverancierDatumCombo.NonAutoSizeHeight = 21
            Me.LeverancierDatumCombo.Size = New System.Drawing.Size(121, 21)
            Me.LeverancierDatumCombo.TabIndex = 11
            Me.LeverancierDatumCombo.Value = ""
            '
            'HervullingDatumCombo
            '
            Me.HervullingDatumCombo.DateButtons.Add(DateButton6)
            Me.HervullingDatumCombo.Location = New System.Drawing.Point(144, 65)
            Me.HervullingDatumCombo.Name = "HervullingDatumCombo"
            Me.HervullingDatumCombo.NonAutoSizeHeight = 21
            Me.HervullingDatumCombo.Size = New System.Drawing.Size(121, 21)
            Me.HervullingDatumCombo.TabIndex = 6
            Me.HervullingDatumCombo.Value = ""
            '
            'PoederDatumCombo
            '
            Me.PoederDatumCombo.DateButtons.Add(DateButton7)
            Me.PoederDatumCombo.Location = New System.Drawing.Point(144, 37)
            Me.PoederDatumCombo.Name = "PoederDatumCombo"
            Me.PoederDatumCombo.NonAutoSizeHeight = 21
            Me.PoederDatumCombo.Size = New System.Drawing.Size(121, 21)
            Me.PoederDatumCombo.TabIndex = 3
            Me.PoederDatumCombo.Value = ""
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(141, 20)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(38, 13)
            Me.Label15.TabIndex = 0
            Me.Label15.Text = "Datum"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(10, 96)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(85, 13)
            Me.Label14.TabIndex = 10
            Me.Label14.Text = "Naar leverancier"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(10, 68)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(107, 13)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Hervulling na gebruik"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(10, 40)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(122, 13)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "Poeder/Schuim controle"
            '
            'UltraGroupBox4
            '
            Me.UltraGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.UltraGroupBox4.Controls.Add(Me.OpmerkingText)
            Me.UltraGroupBox4.Location = New System.Drawing.Point(13, 441)
            Me.UltraGroupBox4.Name = "UltraGroupBox4"
            Me.UltraGroupBox4.Size = New System.Drawing.Size(761, 162)
            Me.UltraGroupBox4.TabIndex = 3
            Me.UltraGroupBox4.Text = "Opmerking"
            '
            'OpmerkingText
            '
            Me.OpmerkingText.AcceptsReturn = True
            Me.OpmerkingText.AcceptsTab = True
            Me.OpmerkingText.AllowDrop = True
            Me.OpmerkingText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.OpmerkingText.Location = New System.Drawing.Point(13, 20)
            Me.OpmerkingText.Multiline = True
            Me.OpmerkingText.Name = "OpmerkingText"
            Me.OpmerkingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.OpmerkingText.Size = New System.Drawing.Size(733, 136)
            Me.OpmerkingText.TabIndex = 0
            Me.OpmerkingText.WordWrap = False
            '
            '_dataBrandweerMateriaalItem
            '
            Me._dataBrandweerMateriaalItem.DataSetName = "TDSBrandweerMateriaalItem"
            Me._dataBrandweerMateriaalItem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'MateriaalFicheButton
            '
            Me.MateriaalFicheButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.MateriaalFicheButton.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.DailyReport
            Me.MateriaalFicheButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.MateriaalFicheButton.Location = New System.Drawing.Point(8, 15)
            Me.MateriaalFicheButton.Name = "MateriaalFicheButton"
            Me.MateriaalFicheButton.Size = New System.Drawing.Size(80, 24)
            Me.MateriaalFicheButton.TabIndex = 5
            Me.MateriaalFicheButton.Text = "Acties"
            Me.MateriaalFicheButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.MateriaalFicheButton, "Acties op materiaal (bv. weging)")
            Me.MateriaalFicheButton.UseVisualStyleBackColor = True
            '
            'PrintButton
            '
            Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.PrintButton.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.PrintButton.Location = New System.Drawing.Point(12, 610)
            Me.PrintButton.Name = "PrintButton"
            Me.PrintButton.Size = New System.Drawing.Size(80, 24)
            Me.PrintButton.TabIndex = 5
            Me.PrintButton.Text = "Afdrukken"
            Me.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.PrintButton, "Afdrukvoorbeeld scherm")
            Me.PrintButton.UseVisualStyleBackColor = True
            '
            'UltraPrintDocument1
            '
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.UltraGrid1)
            Me.GroupBox1.Controls.Add(Me.MateriaalFicheButton)
            Me.GroupBox1.Location = New System.Drawing.Point(780, 269)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(348, 334)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Acties"
            '
            'UltraGrid1
            '
            Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGrid1.DataMember = "MateriaalActie"
            Me.UltraGrid1.DataSource = Me._dataBrandweerMateriaalActie
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
            UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn8.Header.VisiblePosition = 0
            UltraGridColumn8.Hidden = True
            UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn9.Header.VisiblePosition = 1
            UltraGridColumn9.Hidden = True
            UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn10.Header.VisiblePosition = 2
            UltraGridColumn10.Hidden = True
            UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn11.Header.VisiblePosition = 3
            UltraGridColumn11.Width = 77
            UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn12.Header.VisiblePosition = 4
            UltraGridColumn12.Hidden = True
            UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn13.Header.Caption = "Uitgevoerde Actie"
            UltraGridColumn13.Header.VisiblePosition = 5
            UltraGridColumn13.Width = 131
            UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            UltraGridColumn14.Header.Caption = "Gewicht (kg)"
            UltraGridColumn14.Header.VisiblePosition = 6
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
            SummarySettings1.DisplayFormat = "Aantal = {0}"
            SummarySettings1.GroupBySummaryValueAppearance = Appearance2
            UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
            UltraGridBand1.SummaryFooterCaption = ""
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance3.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance3
            Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance5.BackColor2 = System.Drawing.SystemColors.Control
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance6
            Appearance7.BackColor = System.Drawing.SystemColors.Highlight
            Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance7
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance8
            Appearance9.BorderColor = System.Drawing.Color.Silver
            Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance9
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Me.UltraGrid1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            Appearance10.BackColor = System.Drawing.SystemColors.Control
            Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance10.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance10
            Appearance11.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance11
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Appearance12.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance12
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
            Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(8, 40)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(334, 288)
            Me.UltraGrid1.TabIndex = 8
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            '_dataBrandweerMateriaalActie
            '
            Me._dataBrandweerMateriaalActie.DataSetName = "TDSBrandweerMateriaalActie"
            Me._dataBrandweerMateriaalActie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'FormBrandweerMateriaal
            '
            Me.AcceptButton = Me.SaveButton
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1140, 644)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.PrintButton)
            Me.Controls.Add(Me.UltraGroupBox4)
            Me.Controls.Add(Me.UltraGroupBox3)
            Me.Controls.Add(Me.UltraGroupBox2)
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(Me.AnnulerenButton)
            Me.Controls.Add(Me.UltraGroupBox1)
            Me.MinimumSize = New System.Drawing.Size(850, 530)
            Me.Name = "FormBrandweerMateriaal"
            Me.ShowInTaskbar = False
            Me.Text = "Materiaalfiche"
            CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraGroupBox1.ResumeLayout(False)
            Me.UltraGroupBox1.PerformLayout()
            CType(Me.LaatsteNazichtCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LaatsteKeuringsdatumCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LeveringsdatumCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerLeveranciers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerTypeMateriaal1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerSoortBlustoestel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerBeheerderAfdeling, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraGroupBox2.ResumeLayout(False)
            Me.UltraGroupBox2.PerformLayout()
            CType(Me._dataBrandweerAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraGroupBox3.ResumeLayout(False)
            Me.UltraGroupBox3.PerformLayout()
            CType(Me.PoederVolgendeCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LeverancierDatumCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HervullingDatumCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PoederDatumCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraGroupBox4.ResumeLayout(False)
            Me.UltraGroupBox4.PerformLayout()
            CType(Me._dataBrandweerMateriaalItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerMateriaalActie, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
        Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
        Friend WithEvents _dataBrandweerTypeMateriaal1 As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerTypeMateriaal
        Friend WithEvents _dataBrandweerSoortBlustoestel1 As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerSoortBlustoestel
        Friend WithEvents SoortBlustoestelCombo As System.Windows.Forms.ComboBox
        Friend WithEvents AnnulerenButton As System.Windows.Forms.Button
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents LeveranciersCombo As System.Windows.Forms.ComboBox
        Friend WithEvents TypeMateriaalCombo As System.Windows.Forms.ComboBox
        Friend WithEvents LeveringsdatumCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents StatusCombo As System.Windows.Forms.ComboBox
        Friend WithEvents VolgnummerText As System.Windows.Forms.TextBox
        Friend WithEvents FabricatienummerText As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents BeheerderAfdelingText As System.Windows.Forms.TextBox
        Friend WithEvents ControleFrequentieText As System.Windows.Forms.TextBox
        Friend WithEvents VolgendeNazichtText As System.Windows.Forms.TextBox
        Friend WithEvents LaatsteNazichtCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents VolgendeKeuringText As System.Windows.Forms.TextBox
        Friend WithEvents LaatsteKeuringsdatumCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
        Friend WithEvents PlaatsOmschrijvingText As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents LocatienummerText As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents ZoneCombo As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents AfdelingCombo As System.Windows.Forms.ComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
        Friend WithEvents VervangenDoorButton As System.Windows.Forms.Button
        Friend WithEvents PoederVolgendeCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents VervangenDoorText As System.Windows.Forms.TextBox
        Friend WithEvents LeverancierDatumCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents HervullingDatumCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents PoederDatumCombo As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
        Friend WithEvents OpmerkingText As System.Windows.Forms.TextBox
        Friend WithEvents NietGemeldRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents TelefonischGemeldRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents GemeldRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents _dataBrandweerLeveranciers As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerLeveranciers
        Friend WithEvents _dataBrandweerMateriaalItem As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerMateriaalItem
        Friend WithEvents _dataBrandweerBeheerderAfdeling As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerBeheerderAfdeling
        Friend WithEvents _dataBrandweerAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerAfdelingen
        Friend WithEvents CheckBoxLijnToevoegen As System.Windows.Forms.CheckBox
        Friend WithEvents _dataBrandweerStatus As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerStatus
        Protected WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents UltraPrintDocument1 As Infragistics.Win.Printing.UltraPrintDocument
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents PrintButton As System.Windows.Forms.Button
        Friend WithEvents MateriaalFicheButton As System.Windows.Forms.Button
        Friend WithEvents _dataBrandweerMateriaalActie As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerMateriaalActie
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents LabelVervangenDoorOmschr As System.Windows.Forms.Label
    End Class
End Namespace