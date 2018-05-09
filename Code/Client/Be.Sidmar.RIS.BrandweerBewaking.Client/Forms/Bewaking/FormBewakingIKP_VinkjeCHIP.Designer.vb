<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBewakingIKP_VinkjeCHIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBewakingIKP_VinkjeCHIP))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("vw_IKP_firmaCHIP", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_REG")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_REG")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_OPS")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_INC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_REG")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_INC")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Firma_InbrRegl")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Firma_Diverse")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SAP_SUPPLIER_ID")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT_CHIP")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_CHIP")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CHIP_YN")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_IKP")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_IKP_SENDMAIL")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_PEB")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TMS_PEB_SENDMAIL")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VeraReference")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VerslagContractantYN")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VKLR_INBR")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OPM_EX_INBR_VSF")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diverse_KorteOmschr")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diverse_LangeOmschr")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "ID_REG", 0, True, "vw_IKP_firmaCHIP", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, "ID_REG", 0, True)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.ButtonShow = New System.Windows.Forms.Button()
        Me.DateTimePickerIKP = New System.Windows.Forms.DateTimePicker()
        Me.UltraGridIKP_firma = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me._dataInkoopFirmaCHIP = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInkoopFirmaCHIP()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraGridIKP_firma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataInkoopFirmaCHIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCopy)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonShow)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerIKP)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraGridIKP_firma)
        Me.SplitContainer1.Size = New System.Drawing.Size(1022, 532)
        Me.SplitContainer1.SplitterDistance = 45
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(498, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Opm: deze lijst is een workaround om bewakingsverslagen te raadplegen, met firma," & _
    " indien het verslag nog niet beschikbaar is in CHIP."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vanaf datum:"
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCopy.Location = New System.Drawing.Point(381, 12)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCopy.TabIndex = 2
        Me.ButtonCopy.Text = "Kopieer"
        Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'ButtonShow
        '
        Me.ButtonShow.Image = CType(resources.GetObject("ButtonShow.Image"), System.Drawing.Image)
        Me.ButtonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonShow.Location = New System.Drawing.Point(285, 12)
        Me.ButtonShow.Name = "ButtonShow"
        Me.ButtonShow.Size = New System.Drawing.Size(75, 23)
        Me.ButtonShow.TabIndex = 1
        Me.ButtonShow.Text = "Toon"
        Me.ButtonShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonShow.UseVisualStyleBackColor = True
        '
        'DateTimePickerIKP
        '
        Me.DateTimePickerIKP.Location = New System.Drawing.Point(79, 13)
        Me.DateTimePickerIKP.Name = "DateTimePickerIKP"
        Me.DateTimePickerIKP.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerIKP.TabIndex = 0
        '
        'UltraGridIKP_firma
        '
        Me.UltraGridIKP_firma.DataMember = "vw_IKP_firmaCHIP"
        Me.UltraGridIKP_firma.DataSource = Me._dataInkoopFirmaCHIP
        UltraGridColumn1.Header.Caption = "RegID"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Type Reg"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Tms Inc"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.Caption = "Omschrijving"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 151
        UltraGridColumn6.Header.Caption = "Plaats"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.Caption = "SAP FirmaID"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 21
        UltraGridColumn12.Header.VisiblePosition = 22
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 13
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 15
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn20.Header.Caption = "Verklaring Inbr"
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Opm Inbr"
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Width = 154
        UltraGridColumn22.Header.VisiblePosition = 19
        UltraGridColumn23.Header.VisiblePosition = 20
        UltraGridColumn23.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        SummarySettings1.DisplayFormat = "Aantal = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance1
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridIKP_firma.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridIKP_firma.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UltraGridIKP_firma.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGridIKP_firma.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.UltraGridIKP_firma.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGridIKP_firma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridIKP_firma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridIKP_firma.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridIKP_firma.Name = "UltraGridIKP_firma"
        Me.UltraGridIKP_firma.Size = New System.Drawing.Size(1022, 483)
        Me.UltraGridIKP_firma.TabIndex = 0
        '
        '_dataInkoopFirmaCHIP
        '
        Me._dataInkoopFirmaCHIP.DataSetName = "TDSInkoopFirmaCHIP"
        Me._dataInkoopFirmaCHIP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormBewakingIKP_VinkjeCHIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 532)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormBewakingIKP_VinkjeCHIP"
        Me.Text = "Lijst Inkoop met firma: Diverse, Milieuverontr., Schadegeval, Inbr regl"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraGridIKP_firma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataInkoopFirmaCHIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
    Friend WithEvents ButtonShow As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerIKP As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraGridIKP_firma As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _dataInkoopFirmaCHIP As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSInkoopFirmaCHIP
End Class
