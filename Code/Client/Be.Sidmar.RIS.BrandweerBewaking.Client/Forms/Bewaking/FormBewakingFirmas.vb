Option Explicit On
Option Infer On
Option Strict On

Imports System.Reflection
Imports ADF.ExceptionHandling
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid

Imports System.Drawing

Public Class FormBewakingFirmas
    Inherits Form

    Private _idFirma As Integer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonInfoChip As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private _firma As TDSFirmas.BBFRMRow

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
    Friend WithEvents _dataFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas
    Friend WithEvents UltraGridFirmas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBoxOpties As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonWijzig As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSelecteer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingFirmas))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBFRM", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STRA_FRM")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_COD_PLA_FRM")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NR_IND_FRM_SAP")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_SAP")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactPersonMail_FRS")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmEmailContacts")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmRemark")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BBW_FirmLanguage")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DateCreatedFirm")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.GroupBoxOpties = New System.Windows.Forms.GroupBox()
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSelecteer = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonInfoChip = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltraGridFirmas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSFirmas()
        Me.GroupBoxOpties.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxOpties
        '
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSelecteer)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpties.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxOpties.Name = "GroupBoxOpties"
        Me.GroupBoxOpties.Size = New System.Drawing.Size(555, 48)
        Me.GroupBoxOpties.TabIndex = 6
        Me.GroupBoxOpties.TabStop = False
        Me.GroupBoxOpties.Text = "Opties"
        '
        'UltraButtonAfdrukken
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance1
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(11, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        Me.UltraButtonAfdrukken.Visible = False
        '
        'UltraButtonWijzig
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonWijzig.Appearance = Appearance2
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(105, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        Me.UltraButtonWijzig.Visible = False
        '
        'UltraButtonSelecteer
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.UltraButtonSelecteer.Appearance = Appearance3
        Me.UltraButtonSelecteer.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSelecteer.Location = New System.Drawing.Point(348, 16)
        Me.UltraButtonSelecteer.Name = "UltraButtonSelecteer"
        Me.UltraButtonSelecteer.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSelecteer.TabIndex = 3
        Me.UltraButtonSelecteer.Text = "Selecteer"
        '
        'UltraButtonSluiten
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance4
        Me.UltraButtonSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(455, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(604, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Oranje = Nr firma SAP ingevuld (nodig voor automatische mail bij verzenden naar b" & _
            "est)"
        '
        'ButtonInfoChip
        '
        Me.ButtonInfoChip.Image = CType(resources.GetObject("ButtonInfoChip.Image"), System.Drawing.Image)
        Me.ButtonInfoChip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInfoChip.Location = New System.Drawing.Point(1059, 18)
        Me.ButtonInfoChip.Name = "ButtonInfoChip"
        Me.ButtonInfoChip.Size = New System.Drawing.Size(143, 24)
        Me.ButtonInfoChip.TabIndex = 1008
        Me.ButtonInfoChip.Text = "Mail contactpers SAP"
        Me.ButtonInfoChip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ButtonInfoChip, "info uit SAP: email contactpersoon firma")
        Me.ButtonInfoChip.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(-2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraGridFirmas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxOpties)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ButtonInfoChip)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1627, 550)
        Me.SplitContainer1.SplitterDistance = 488
        Me.SplitContainer1.TabIndex = 1009
        '
        'UltraGridFirmas
        '
        Me.UltraGridFirmas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGridFirmas.DataMember = "BBFRM"
        Me.UltraGridFirmas.DataSource = Me._dataFirmas
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridFirmas.DisplayLayout.Appearance = Appearance5
        Me.UltraGridFirmas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 97
        UltraGridColumn6.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Naam"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 221
        UltraGridColumn7.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Header.Caption = "Straat"
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Width = 231
        UltraGridColumn15.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Header.Caption = "Postcode"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Width = 75
        UltraGridColumn16.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Header.Caption = "Plaats"
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 279
        UltraGridColumn17.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn17.Header.Caption = "Nr firma SAP"
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.Width = 108
        UltraGridColumn18.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn18.Header.Caption = "Naam firma SAP"
        UltraGridColumn18.Header.VisiblePosition = 6
        UltraGridColumn18.Width = 118
        UltraGridColumn19.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn19.Header.VisiblePosition = 7
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn20.Header.Caption = "BBW_Firma mailcontact(en)"
        UltraGridColumn20.Header.VisiblePosition = 8
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Width = 187
        UltraGridColumn21.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn21.Header.Caption = "BBW_Firma opm"
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridColumn22.Header.Caption = "BBW_Firma taal"
        UltraGridColumn22.Header.VisiblePosition = 10
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.Width = 97
        UltraGridColumn23.Header.VisiblePosition = 11
        UltraGridColumn23.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        Me.UltraGridFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.Appearance = Appearance6
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance7
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance8
        Me.UltraGridFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.SystemColors.Highlight
        Appearance10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance10
        Me.UltraGridFirmas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGridFirmas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridFirmas.DisplayLayout.Override.CellAppearance = Appearance12
        Me.UltraGridFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridFirmas.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridFirmas.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridFirmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance13.BackColor = System.Drawing.SystemColors.Control
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Left"
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridFirmas.DisplayLayout.Override.RowAppearance = Appearance15
        Me.UltraGridFirmas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UltraGridFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridFirmas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UltraGridFirmas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance16
        Me.UltraGridFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridFirmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridFirmas.Location = New System.Drawing.Point(3, 0)
        Me.UltraGridFirmas.Name = "UltraGridFirmas"
        Me.UltraGridFirmas.Size = New System.Drawing.Size(1621, 485)
        Me.UltraGridFirmas.TabIndex = 0
        '
        '_dataFirmas
        '
        Me._dataFirmas.DataSetName = "TDSFirmas"
        Me._dataFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataFirmas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBewakingFirmas
        '
        Me.AcceptButton = Me.UltraButtonSelecteer
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.UltraButtonSluiten
        Me.ClientSize = New System.Drawing.Size(1624, 553)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormBewakingFirmas"
        Me.Text = "Selecteer Firma"
        Me.GroupBoxOpties.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraGridFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property Firma() As TDSFirmas.BBFRMRow
        Get
            Return _firma
        End Get
    End Property

    Public ReadOnly Property IdFirma() As Integer
        Get
            Return _idFirma
        End Get
    End Property

    Public ReadOnly Property NaamFirma As String
        Get
            Return If(_firma.IsNM_FRMNull, "", _firma.NM_FRM)
        End Get
    End Property

    Public ReadOnly Property AdresFirma As String
        Get
            Return If(_firma.IsSTRA_FRMNull, "", _firma.STRA_FRM)
        End Get
    End Property

    Public ReadOnly Property PostNrFirma As String
        Get
            Return If(_firma.IsPO_COD_PLA_FRMNull, "", _firma.PO_COD_PLA_FRM)
        End Get
    End Property

    Public ReadOnly Property GemeenteFirma As String
        Get
            Return If(_firma.IsPLA_FRMNull, "", _firma.PLA_FRM)
        End Get
    End Property

    Public ReadOnly Property LandFirma As String
        Get
            ' Wordt (voorlopig) niet geïmplementeerd.
            Return ""
        End Get
    End Property

#End Region

    Private Sub FormBewakingFirmas_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            'UltraGridFirmas.DisplayLayout.Override.TemplateAddRowPrompt = "Klik hier om een rij toe te voegen..."
            'UltraGridFirmas.DisplayLayout.Override.TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
            'UltraGridFirmas.DisplayLayout.Override.SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
            'UltraGridFirmas.DisplayLayout.Override.BorderStyleSpecialRowSeparator = Infragistics.Win.UIElementBorderStyle.RaisedSoft

            Dim controller = New ControllerGetData
            _dataFirmas.Merge(controller.GetFirmas)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf &
                            "Form: FormBewakingFirmas - ButtonFirma_Click" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Firma's",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UltraButtonSelecteer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonSelecteer.Click, UltraGridFirmas.DoubleClick
        Try
            If UltraGridFirmas.ActiveRow Is Nothing OrElse Not UltraGridFirmas.ActiveRow.IsDataRow Then
                MessageBox.Show("Geen firma geselecteerd.", "Error", MessageBoxButtons.OK)
                Return
            End If

            _idFirma = CInt(UltraGridFirmas.ActiveRow.Cells("ID_FRM").Value)
            _firma = _dataFirmas.BBFRM.FindByID_FRM(_idFirma)

            'naco - maart 2017 - eigen email adres in BBW opslaan (indien geen link met SAP firmanr en indien nog geen eigen BBW mail-adres gekend)
            'voorlopig nog niet => eerst overleggen met Eddy Van Renterghem
            'If UltraGridFirmas.ActiveRow.Cells("NR_IND_FRM_SAP").Value.ToString = "" And UltraGridFirmas.ActiveRow.Cells("BBW_FirmEmailContacts").Value.ToString.Trim = "" Then
            '    Dim f_firma As New FormUpdateFirmMail_BBW

            '    f_firma.pFirmId = CInt(UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.ID_FRMColumn.ColumnName).Value)
            '    f_firma.pFirmName = UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.NM_FRMColumn.ColumnName).Value.ToString

            '    f_firma.ShowDialog()

            '    If f_firma.pCanceled = False Then

            '        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            '        proxy.UpdateBBFRM_EmailRemarkLanguage(f_firma.pFirmId, f_firma.pFirmEmail, f_firma.pFirmRemark, f_firma.pFirmLanguage)

            '    End If

            '    f_firma = Nothing
            'Else
            '    'reeds koppeling met SAP firmanr => daar emailadres contactpers opvragen bij verzenden naar bestemmelingen
            'End If


            DialogResult = DialogResult.OK
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonSluiten.Click
        Try
            DialogResult = DialogResult.Cancel
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridFirmas_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridFirmas.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_FRM"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Public Sub FindFirmById(ByVal pId As Integer)
        If (_firma Is Nothing) Then
            _firma = _dataFirmas.BBFRM.NewBBFRMRow()
        End If
        If _dataFirmas.BBFRM.Rows.Count = 0 Then
            Dim controller = New ControllerGetData
            _dataFirmas.Merge(controller.GetFirmas)
        End If
        _idFirma = pId
        _firma = _dataFirmas.BBFRM.FindByID_FRM(pId)
    End Sub

    Private Sub UltraGridFirmas_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridFirmas.InitializeRow
        Try
            If e.Row.Cells("NR_IND_FRM_SAP").Value.ToString.Trim = "" Then
            Else 'als nr_ind_frm_sap ingevuld => oranje tonen
                e.Row.Appearance.BackColor = Color.Orange
            End If
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub ButtonInfoChip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInfoChip.Click
        'naco - 21/03/2017

        If UltraGridFirmas.ActiveRow Is Nothing OrElse Not UltraGridFirmas.ActiveRow.IsDataRow Then
            MessageBox.Show("Geen firma geselecteerd.", "Error", MessageBoxButtons.OK)
            Return
        End If

        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim strFirmaNaamBBW As String = UltraGridFirmas.ActiveRow.Cells("NM_FRM").Value.ToString
        Dim intIDFRM_BBW As Integer = CInt(UltraGridFirmas.ActiveRow.Cells("ID_FRM").Value)

        If strFirmaNaamBBW = "" Then
            MessageBox.Show("Firmanaam is niet ingevuld: verslag kan niet automatisch naar CHIP gestuurd worden.", "Firmanaam - CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(intIDFRM_BBW)

            If intIDFirmSAP > 0 And intIDFRM_BBW <> 1001674 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP)

                Dim strMailToFirm As String
                'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP)

                If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                    MessageBox.Show("Geen contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firma nr: " & intIDFirmSAP & ".", "Geen contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else 'wel een contactpersoon => mail met verslag in bijlage versturen
                    MessageBox.Show("Contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firmanr: " & intIDFirmSAP & vbCrLf & vbCrLf & strMailToFirm, "Contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                If intIDFRM_BBW <> 1001674 Then '1001674 = ArcelorMittal Gent => geen msgbox tonen
                    MessageBox.Show("Verslag kan niet automatisch naar firma gestuurd worden en niet naar CHIP portaal." & vbCrLf & vbCrLf &
                                    "SAP firmanr niet gekend voor deze BBW firma: " & vbCrLf & strFirmaNaamBBW & ".", "Verslag automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Verslag waarvoor BBW firma = ArcelorMittal Gent." & vbCrLf &
                                    "Verslagen voor AM Gent worden niet naar CHIP verstuurd.", "Verslag AM Gent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
End Class
