<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBrandweerInkoop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrandweerInkoop))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TDSInkoopBrandweer", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_INTV_BRDW")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_INTV")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_INTV")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VLG_TY_INTV_JR")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("YEAR")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INTV", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KRT_AFD")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INTV")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_TY_INTV")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_BR_RD_INTV")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRD_BLUS_AFD")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRD_BLUS_SID")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_BRDW_SID_OPR")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INDI_RAP_INC_OTV")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_RAP_NW")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_OK")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_VZ_BST")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfoId")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FireCauseExtraInfo")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "ID_INTV_BRDW", 0, True, "TDSInkoopBrandweer", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStripInkoopBrandweer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonOpenVerslag = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRemark = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonMailsentNull = New System.Windows.Forms.ToolStripButton()
        Me.UltraGridInkoop = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataBrandweerInkoop1 = New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerInkoop()
        Me.ToolStripInkoopBrandweer.SuspendLayout()
        CType(Me.UltraGridInkoop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataBrandweerInkoop1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripInkoopBrandweer
        '
        Me.ToolStripInkoopBrandweer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCopy, Me.ToolStripButtonRefresh, Me.ToolStripButtonOpenVerslag, Me.ToolStripButtonRemark, Me.ToolStripButtonMailsentNull})
        Me.ToolStripInkoopBrandweer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripInkoopBrandweer.Name = "ToolStripInkoopBrandweer"
        Me.ToolStripInkoopBrandweer.Size = New System.Drawing.Size(1181, 25)
        Me.ToolStripInkoopBrandweer.TabIndex = 15
        '
        'ToolStripButtonCopy
        '
        Me.ToolStripButtonCopy.Image = CType(resources.GetObject("ToolStripButtonCopy.Image"), System.Drawing.Image)
        Me.ToolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        Me.ToolStripButtonCopy.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButtonCopy.Text = "Kopieer"
        Me.ToolStripButtonCopy.ToolTipText = "Kopieer data naar clipboard"
        '
        'ToolStripButtonRefresh
        '
        Me.ToolStripButtonRefresh.Image = CType(resources.GetObject("ToolStripButtonRefresh.Image"), System.Drawing.Image)
        Me.ToolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefresh.Name = "ToolStripButtonRefresh"
        Me.ToolStripButtonRefresh.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButtonRefresh.Text = "Vernieuwen"
        Me.ToolStripButtonRefresh.ToolTipText = "Data in grid vernieuwen"
        '
        'ToolStripButtonOpenVerslag
        '
        Me.ToolStripButtonOpenVerslag.Image = CType(resources.GetObject("ToolStripButtonOpenVerslag.Image"), System.Drawing.Image)
        Me.ToolStripButtonOpenVerslag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonOpenVerslag.Name = "ToolStripButtonOpenVerslag"
        Me.ToolStripButtonOpenVerslag.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButtonOpenVerslag.Text = "Open verslag"
        '
        'ToolStripButtonRemark
        '
        Me.ToolStripButtonRemark.Image = CType(resources.GetObject("ToolStripButtonRemark.Image"), System.Drawing.Image)
        Me.ToolStripButtonRemark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemark.Name = "ToolStripButtonRemark"
        Me.ToolStripButtonRemark.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButtonRemark.Text = "Geef opm"
        Me.ToolStripButtonRemark.ToolTipText = "Geef opmerking Inkoopdienst"
        Me.ToolStripButtonRemark.Visible = False
        '
        'ToolStripButtonMailsentNull
        '
        Me.ToolStripButtonMailsentNull.Image = CType(resources.GetObject("ToolStripButtonMailsentNull.Image"), System.Drawing.Image)
        Me.ToolStripButtonMailsentNull.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMailsentNull.Name = "ToolStripButtonMailsentNull"
        Me.ToolStripButtonMailsentNull.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripButtonMailsentNull.Text = "Datum mail sent leeg"
        Me.ToolStripButtonMailsentNull.ToolTipText = "Maak datum Mail sent IKP leeg"
        Me.ToolStripButtonMailsentNull.Visible = False
        '
        'UltraGridInkoop
        '
        Me.UltraGridInkoop.DataMember = "TDSInkoopBrandweer"
        Me.UltraGridInkoop.DataSource = Me._dataBrandweerInkoop1
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn22.Header.VisiblePosition = 18
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Header.VisiblePosition = 19
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.Caption = "Interventietype"
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.Caption = "Volgnr"
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Header.Caption = "Jaar"
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Header.Caption = "Datum opr."
        UltraGridColumn27.Header.VisiblePosition = 3
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn28.Header.Caption = "Afd"
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn29.Header.Caption = "Plaats tussenkomst"
        UltraGridColumn29.Header.VisiblePosition = 5
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.Caption = "Aard"
        UltraGridColumn30.Header.VisiblePosition = 6
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn31.Header.Caption = "Oorzaak"
        UltraGridColumn31.Header.VisiblePosition = 7
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn32.Header.Caption = "Geblust afd"
        UltraGridColumn32.Header.VisiblePosition = 8
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn33.Header.Caption = "Geblust BW"
        UltraGridColumn33.Header.VisiblePosition = 9
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn34.Header.Caption = "Oproep BW"
        UltraGridColumn34.Header.VisiblePosition = 10
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn35.Header.Caption = "Inc. Verslag"
        UltraGridColumn35.Header.VisiblePosition = 11
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Header.Caption = "Datum verz rapp."
        UltraGridColumn36.Header.VisiblePosition = 12
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn37.Header.Caption = "Datum goedkeuring"
        UltraGridColumn37.Header.VisiblePosition = 13
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn38.Header.Caption = "Datum verz best."
        UltraGridColumn38.Header.VisiblePosition = 14
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 20
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.Caption = "Brand extra info"
        UltraGridColumn40.Header.VisiblePosition = 15
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Header.Caption = "Vera Rapport"
        UltraGridColumn41.Header.VisiblePosition = 16
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Header.Caption = "Ivm contractant"
        UltraGridColumn42.Header.VisiblePosition = 17
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        SummarySettings1.DisplayFormat = "Aantal: {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance1
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridInkoop.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridInkoop.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UltraGridInkoop.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.UltraGridInkoop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridInkoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridInkoop.Location = New System.Drawing.Point(0, 25)
        Me.UltraGridInkoop.Name = "UltraGridInkoop"
        Me.UltraGridInkoop.Size = New System.Drawing.Size(1181, 573)
        Me.UltraGridInkoop.TabIndex = 16
        '
        '_dataBrandweerInkoop1
        '
        Me._dataBrandweerInkoop1.DataSetName = "TDSBrandweerInkoop"
        Me._dataBrandweerInkoop1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBrandweerInkoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 598)
        Me.Controls.Add(Me.UltraGridInkoop)
        Me.Controls.Add(Me.ToolStripInkoopBrandweer)
        Me.Name = "FormBrandweerInkoop"
        Me.Text = "Lijst inkoop (Bestemmeling IKP) - Brandweer"
        Me.ToolStripInkoopBrandweer.ResumeLayout(False)
        Me.ToolStripInkoopBrandweer.PerformLayout()
        CType(Me.UltraGridInkoop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataBrandweerInkoop1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolStripInkoopBrandweer As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonOpenVerslag As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonRemark As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonMailsentNull As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGridInkoop As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataBrandweerInkoop1 As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandweerInkoop
End Class
