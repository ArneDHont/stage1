Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDienstverslagEntry
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
            Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Acties", -1)
            Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieCodeGroepId")
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieCodeId")
            Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieOmschr")
            Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActieCodeGroepOmschr")
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBoxPloeg = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.ComboBoxOverste = New System.Windows.Forms.ComboBox()
            Me._dataDienstVerslagDetailOversten = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailOversten()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPageInfo = New System.Windows.Forms.TabPage()
            Me.TextBoxAantalPersonen = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.ComboBoxAfdeling = New System.Windows.Forms.ComboBox()
            Me._dataDienstverslagAfdelingen = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagAfdelingen()
            Me.LabelOpleiding = New System.Windows.Forms.Label()
            Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
            Me._dataDienstverslagDetailActies = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagDetailActies()
            Me.TabPageOpmerking = New System.Windows.Forms.TabPage()
            Me.TextBoxOpm = New System.Windows.Forms.TextBox()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripButtonAddPerson = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButtonCancel = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
            Me.TextBoxDatum = New System.Windows.Forms.TextBox()
            Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
            Me.UltraPrintDocument1 = New Infragistics.Win.Printing.UltraPrintDocument(Me.components)
            Me.UltraGridPrintDocument1 = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
            CType(Me._dataDienstVerslagDetailOversten, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPageInfo.SuspendLayout()
            CType(Me._dataDienstverslagAfdelingen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataDienstverslagDetailActies, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPageOpmerking.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(38, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Datum"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(193, 31)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Ploeg"
            '
            'TextBoxPloeg
            '
            Me.TextBoxPloeg.Location = New System.Drawing.Point(244, 28)
            Me.TextBoxPloeg.Name = "TextBoxPloeg"
            Me.TextBoxPloeg.ReadOnly = True
            Me.TextBoxPloeg.Size = New System.Drawing.Size(40, 20)
            Me.TextBoxPloeg.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(308, 31)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Verantwoordelijke"
            '
            'ComboBoxOverste
            '
            Me.ComboBoxOverste.DataSource = Me._dataDienstVerslagDetailOversten
            Me.ComboBoxOverste.DisplayMember = "Oversten.Naam"
            Me.ComboBoxOverste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxOverste.FormattingEnabled = True
            Me.ComboBoxOverste.Location = New System.Drawing.Point(405, 28)
            Me.ComboBoxOverste.Name = "ComboBoxOverste"
            Me.ComboBoxOverste.Size = New System.Drawing.Size(178, 21)
            Me.ComboBoxOverste.TabIndex = 5
            Me.ComboBoxOverste.ValueMember = "Oversten.Id"
            '
            '_dataDienstVerslagDetailOversten
            '
            Me._dataDienstVerslagDetailOversten.DataSetName = "TDSDienstVerslagDetailOversten"
            Me._dataDienstVerslagDetailOversten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TabControl1
            '
            Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TabControl1.Controls.Add(Me.TabPageInfo)
            Me.TabControl1.Controls.Add(Me.TabPageOpmerking)
            Me.TabControl1.Location = New System.Drawing.Point(13, 55)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(767, 406)
            Me.TabControl1.TabIndex = 6
            '
            'TabPageInfo
            '
            Me.TabPageInfo.Controls.Add(Me.TextBoxAantalPersonen)
            Me.TabPageInfo.Controls.Add(Me.Label5)
            Me.TabPageInfo.Controls.Add(Me.ComboBoxAfdeling)
            Me.TabPageInfo.Controls.Add(Me.LabelOpleiding)
            Me.TabPageInfo.Controls.Add(Me.UltraGrid1)
            Me.TabPageInfo.Location = New System.Drawing.Point(4, 22)
            Me.TabPageInfo.Name = "TabPageInfo"
            Me.TabPageInfo.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPageInfo.Size = New System.Drawing.Size(759, 380)
            Me.TabPageInfo.TabIndex = 0
            Me.TabPageInfo.Text = "Dienstverslag"
            Me.TabPageInfo.UseVisualStyleBackColor = True
            '
            'TextBoxAantalPersonen
            '
            Me.TextBoxAantalPersonen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBoxAantalPersonen.Enabled = False
            Me.TextBoxAantalPersonen.Location = New System.Drawing.Point(653, 358)
            Me.TextBoxAantalPersonen.Name = "TextBoxAantalPersonen"
            Me.TextBoxAantalPersonen.Size = New System.Drawing.Size(100, 20)
            Me.TextBoxAantalPersonen.TabIndex = 4
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(562, 361)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(85, 13)
            Me.Label5.TabIndex = 3
            Me.Label5.Text = "Aantal Personen"
            '
            'ComboBoxAfdeling
            '
            Me.ComboBoxAfdeling.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboBoxAfdeling.DataSource = Me._dataDienstverslagAfdelingen
            Me.ComboBoxAfdeling.DisplayMember = "Afdeling.AfdelingNaam"
            Me.ComboBoxAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxAfdeling.Enabled = False
            Me.ComboBoxAfdeling.FormattingEnabled = True
            Me.ComboBoxAfdeling.Location = New System.Drawing.Point(374, 357)
            Me.ComboBoxAfdeling.Name = "ComboBoxAfdeling"
            Me.ComboBoxAfdeling.Size = New System.Drawing.Size(182, 21)
            Me.ComboBoxAfdeling.TabIndex = 2
            Me.ComboBoxAfdeling.ValueMember = "Afdeling.AfdelingId"
            '
            '_dataDienstverslagAfdelingen
            '
            Me._dataDienstverslagAfdelingen.DataSetName = "TDSDienstverslagAfdelingen"
            Me._dataDienstverslagAfdelingen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'LabelOpleiding
            '
            Me.LabelOpleiding.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelOpleiding.Location = New System.Drawing.Point(6, 361)
            Me.LabelOpleiding.Name = "LabelOpleiding"
            Me.LabelOpleiding.Size = New System.Drawing.Size(365, 13)
            Me.LabelOpleiding.TabIndex = 1
            Me.LabelOpleiding.Text = "Opleiding"
            Me.LabelOpleiding.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'UltraGrid1
            '
            Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UltraGrid1.DataMember = "Acties"
            Me.UltraGrid1.DataSource = Me._dataDienstverslagDetailActies
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
            Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
            UltraGridBand1.ColHeaderLines = 2
            UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Appearance2.FontData.BoldAsString = "True"
            UltraGridColumn1.GroupByRowAppearance = Appearance2
            UltraGridColumn1.Header.VisiblePosition = 2
            UltraGridColumn1.Hidden = True
            UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn2.Header.VisiblePosition = 3
            UltraGridColumn2.Hidden = True
            UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            UltraGridColumn3.Header.Caption = "Actie"
            UltraGridColumn3.Header.Fixed = True
            UltraGridColumn3.Header.VisiblePosition = 0
            UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Appearance3.FontData.BoldAsString = "True"
            UltraGridColumn4.GroupByRowAppearance = Appearance3
            UltraGridColumn4.Header.Caption = "Actie Groep"
            UltraGridColumn4.Header.Fixed = True
            UltraGridColumn4.Header.VisiblePosition = 1
            UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
            UltraGridBand1.SummaryFooterCaption = "Totaal Geregistreerde Uren:"
            Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
            Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
            Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
            Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            Appearance4.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance4
            Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
            Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
            Me.UltraGrid1.DisplayLayout.GroupByBox.Hidden = True
            Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
            Appearance6.BackColor2 = System.Drawing.SystemColors.Control
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
            Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
            Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
            Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance7
            Appearance8.BackColor = System.Drawing.SystemColors.Highlight
            Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
            Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance8
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
            Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance9
            Appearance10.BorderColor = System.Drawing.Color.Silver
            Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
            Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance10
            Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
            Appearance11.BackColor = System.Drawing.SystemColors.Control
            Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
            Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
            Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
            Appearance11.BorderColor = System.Drawing.SystemColors.Window
            Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance11
            Appearance12.TextHAlignAsString = "Left"
            Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance12
            Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
            Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Appearance13.BorderColor = System.Drawing.Color.Silver
            Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance13
            Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
            Me.UltraGrid1.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
            Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
            Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
            Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
            Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
            Me.UltraGrid1.DisplayLayout.UseFixedHeaders = True
            Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
            Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UltraGrid1.Location = New System.Drawing.Point(6, 6)
            Me.UltraGrid1.Name = "UltraGrid1"
            Me.UltraGrid1.Size = New System.Drawing.Size(747, 345)
            Me.UltraGrid1.TabIndex = 0
            Me.UltraGrid1.Text = "UltraGrid1"
            '
            '_dataDienstverslagDetailActies
            '
            Me._dataDienstverslagDetailActies.DataSetName = "TDSDienstverslagDetailActies"
            Me._dataDienstverslagDetailActies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TabPageOpmerking
            '
            Me.TabPageOpmerking.Controls.Add(Me.TextBoxOpm)
            Me.TabPageOpmerking.Location = New System.Drawing.Point(4, 22)
            Me.TabPageOpmerking.Name = "TabPageOpmerking"
            Me.TabPageOpmerking.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPageOpmerking.Size = New System.Drawing.Size(759, 380)
            Me.TabPageOpmerking.TabIndex = 1
            Me.TabPageOpmerking.Text = "Opmerkingen"
            Me.TabPageOpmerking.UseVisualStyleBackColor = True
            '
            'TextBoxOpm
            '
            Me.TextBoxOpm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBoxOpm.Location = New System.Drawing.Point(3, 3)
            Me.TextBoxOpm.Multiline = True
            Me.TextBoxOpm.Name = "TextBoxOpm"
            Me.TextBoxOpm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TextBoxOpm.Size = New System.Drawing.Size(753, 374)
            Me.TextBoxOpm.TabIndex = 0
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAddPerson, Me.ToolStripSeparator2, Me.ToolStripButtonSave, Me.ToolStripButtonCancel, Me.ToolStripSeparator1, Me.ToolStripButtonPrint})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
            Me.ToolStrip1.TabIndex = 7
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripButtonAddPerson
            '
            Me.ToolStripButtonAddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonAddPerson.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.male
            Me.ToolStripButtonAddPerson.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonAddPerson.Name = "ToolStripButtonAddPerson"
            Me.ToolStripButtonAddPerson.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonAddPerson.ToolTipText = "Toevoegen van een tijdelijke medewerker"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonSave
            '
            Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonSave.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Save
            Me.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
            Me.ToolStripButtonSave.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonSave.ToolTipText = "Opslaan van de wijzigingen"
            '
            'ToolStripButtonCancel
            '
            Me.ToolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonCancel.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Cancel
            Me.ToolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonCancel.Name = "ToolStripButtonCancel"
            Me.ToolStripButtonCancel.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonCancel.ToolTipText = "Annuleren van de wijzigingen"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButtonPrint
            '
            Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButtonPrint.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client2.My.Resources.Resources.Print
            Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
            Me.ToolStripButtonPrint.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButtonPrint.ToolTipText = "Afdrukken"
            '
            'TextBoxDatum
            '
            Me.TextBoxDatum.Location = New System.Drawing.Point(62, 29)
            Me.TextBoxDatum.Name = "TextBoxDatum"
            Me.TextBoxDatum.ReadOnly = True
            Me.TextBoxDatum.Size = New System.Drawing.Size(100, 20)
            Me.TextBoxDatum.TabIndex = 8
            '
            'UltraPrintPreviewDialog1
            '
            Me.UltraPrintPreviewDialog1.Document = Me.UltraPrintDocument1
            Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
            '
            'UltraPrintDocument1
            '
            '
            'UltraGridPrintDocument1
            '
            Me.UltraGridPrintDocument1.Grid = Me.UltraGrid1
            '
            'FormDienstverslagEntry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 473)
            Me.Controls.Add(Me.TextBoxDatum)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.ComboBoxOverste)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBoxPloeg)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.MinimumSize = New System.Drawing.Size(560, 300)
            Me.Name = "FormDienstverslagEntry"
            Me.Text = "Inbrengen van een Dienstverslag"
            CType(Me._dataDienstVerslagDetailOversten, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPageInfo.ResumeLayout(False)
            Me.TabPageInfo.PerformLayout()
            CType(Me._dataDienstverslagAfdelingen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataDienstverslagDetailActies, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPageOpmerking.ResumeLayout(False)
            Me.TabPageOpmerking.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBoxPloeg As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ComboBoxOverste As System.Windows.Forms.ComboBox
        Friend WithEvents _dataDienstVerslagDetailOversten As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailOversten
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPageInfo As System.Windows.Forms.TabPage
        Friend WithEvents TabPageOpmerking As System.Windows.Forms.TabPage
        Friend WithEvents TextBoxOpm As System.Windows.Forms.TextBox
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents TextBoxDatum As System.Windows.Forms.TextBox
        Friend WithEvents ToolStripButtonSave As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButtonCancel As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
        Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
        Friend WithEvents UltraPrintDocument1 As Infragistics.Win.Printing.UltraPrintDocument
        Friend WithEvents _dataDienstverslagDetailActies As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagDetailActies
        Friend WithEvents ToolStripButtonAddPerson As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
        Friend WithEvents TextBoxAantalPersonen As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents ComboBoxAfdeling As System.Windows.Forms.ComboBox
        Friend WithEvents LabelOpleiding As System.Windows.Forms.Label
        Friend WithEvents _dataDienstverslagAfdelingen As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstverslagAfdelingen
        Friend WithEvents UltraGridPrintDocument1 As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    End Class
End Namespace