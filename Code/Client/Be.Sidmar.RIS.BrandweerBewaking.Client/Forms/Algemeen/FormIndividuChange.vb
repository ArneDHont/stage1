Imports System.Windows.Forms

Public Class FormIndividuChange
    Inherits Form

    'Auteur: Siddien
    'Datum: okt. 2006
    'Doel: toevoegen en wijzigen van een nieuw / oud individu.

    Private ReadOnly _aRow As TDSIndividuen.BBINDRow
    Private WithEvents chkActiveBst As CheckBox
    Private WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Private _isUpdate As Boolean = False

    ' GMAE - 2013-06-20: changed the alternate colour in the grid from 'InactiveCaptionText' into 'Info'

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal aRowSelected As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow)
        Me.New()
        Me._aRow = aRowSelected
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
    Friend WithEvents lblStamnummer As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNaam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblVoornaam As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblAdres As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPostcode As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblWoonplaats As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblMail As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblGeslacht As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtStamnummer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtNaam As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtVoornaam As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAdres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtPostcode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtWoonplaats As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtEmail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraOptionSetGeslacht As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblType As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents _dataTypeIndividu As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype
    Friend WithEvents cboType As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBINDTY", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_TY_IND")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_TY_IND")
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
        Me.lblStamnummer = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNaam = New Infragistics.Win.Misc.UltraLabel()
        Me.lblVoornaam = New Infragistics.Win.Misc.UltraLabel()
        Me.lblAdres = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPostcode = New Infragistics.Win.Misc.UltraLabel()
        Me.lblWoonplaats = New Infragistics.Win.Misc.UltraLabel()
        Me.lblMail = New Infragistics.Win.Misc.UltraLabel()
        Me.lblGeslacht = New Infragistics.Win.Misc.UltraLabel()
        Me.txtStamnummer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtNaam = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtVoornaam = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtAdres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtPostcode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtWoonplaats = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtEmail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraOptionSetGeslacht = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.btnOpslaan = New Infragistics.Win.Misc.UltraButton()
        Me.lblType = New Infragistics.Win.Misc.UltraLabel()
        Me.cboType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me._dataTypeIndividu = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividutype()
        Me.chkActiveBst = New System.Windows.Forms.CheckBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNaam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoornaam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWoonplaats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraOptionSetGeslacht, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataTypeIndividu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStamnummer
        '
        Me.lblStamnummer.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblStamnummer.Location = New System.Drawing.Point(16, 16)
        Me.lblStamnummer.Name = "lblStamnummer"
        Me.lblStamnummer.Size = New System.Drawing.Size(100, 24)
        Me.lblStamnummer.TabIndex = 0
        Me.lblStamnummer.Text = "Stamnummer:"
        '
        'lblNaam
        '
        Me.lblNaam.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblNaam.Location = New System.Drawing.Point(16, 40)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(100, 24)
        Me.lblNaam.TabIndex = 1
        Me.lblNaam.Text = "Naam:"
        '
        'lblVoornaam
        '
        Me.lblVoornaam.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblVoornaam.Location = New System.Drawing.Point(16, 64)
        Me.lblVoornaam.Name = "lblVoornaam"
        Me.lblVoornaam.Size = New System.Drawing.Size(100, 24)
        Me.lblVoornaam.TabIndex = 2
        Me.lblVoornaam.Text = "Voornaam:"
        '
        'lblAdres
        '
        Me.lblAdres.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblAdres.Location = New System.Drawing.Point(16, 88)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(100, 24)
        Me.lblAdres.TabIndex = 3
        Me.lblAdres.Text = "Adres:"
        '
        'lblPostcode
        '
        Me.lblPostcode.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblPostcode.Location = New System.Drawing.Point(16, 112)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(100, 24)
        Me.lblPostcode.TabIndex = 4
        Me.lblPostcode.Text = "Postcode:"
        '
        'lblWoonplaats
        '
        Me.lblWoonplaats.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblWoonplaats.Location = New System.Drawing.Point(246, 112)
        Me.lblWoonplaats.Name = "lblWoonplaats"
        Me.lblWoonplaats.Size = New System.Drawing.Size(100, 24)
        Me.lblWoonplaats.TabIndex = 5
        Me.lblWoonplaats.Text = "Woonplaats:"
        '
        'lblMail
        '
        Me.lblMail.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblMail.Location = New System.Drawing.Point(16, 136)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(100, 24)
        Me.lblMail.TabIndex = 6
        Me.lblMail.Text = "E-mail:"
        '
        'lblGeslacht
        '
        Me.lblGeslacht.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblGeslacht.Location = New System.Drawing.Point(16, 160)
        Me.lblGeslacht.Name = "lblGeslacht"
        Me.lblGeslacht.Size = New System.Drawing.Size(100, 24)
        Me.lblGeslacht.TabIndex = 7
        Me.lblGeslacht.Text = "Geslacht:"
        '
        'txtStamnummer
        '
        Me.txtStamnummer.Location = New System.Drawing.Point(150, 16)
        Me.txtStamnummer.Name = "txtStamnummer"
        Me.txtStamnummer.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtStamnummer.Size = New System.Drawing.Size(232, 21)
        Me.txtStamnummer.TabIndex = 8
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(150, 40)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(504, 21)
        Me.txtNaam.TabIndex = 9
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Location = New System.Drawing.Point(150, 64)
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(504, 21)
        Me.txtVoornaam.TabIndex = 10
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(150, 88)
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(504, 21)
        Me.txtAdres.TabIndex = 11
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(150, 112)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(64, 21)
        Me.txtPostcode.TabIndex = 12
        '
        'txtWoonplaats
        '
        Me.txtWoonplaats.Location = New System.Drawing.Point(350, 112)
        Me.txtWoonplaats.Name = "txtWoonplaats"
        Me.txtWoonplaats.Size = New System.Drawing.Size(304, 21)
        Me.txtWoonplaats.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(504, 21)
        Me.txtEmail.TabIndex = 14
        '
        'UltraOptionSetGeslacht
        '
        ValueListItem1.DataValue = CType(1, Byte)
        ValueListItem1.DisplayText = "Man"
        ValueListItem2.DataValue = CType(2, Byte)
        ValueListItem2.DisplayText = "Vrouw"
        Me.UltraOptionSetGeslacht.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.UltraOptionSetGeslacht.Location = New System.Drawing.Point(150, 160)
        Me.UltraOptionSetGeslacht.Name = "UltraOptionSetGeslacht"
        Me.UltraOptionSetGeslacht.Size = New System.Drawing.Size(504, 24)
        Me.UltraOptionSetGeslacht.TabIndex = 15
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(582, 232)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.btnOpslaan.TabIndex = 16
        Me.btnOpslaan.Text = "Opslaan"
        '
        'lblType
        '
        Me.lblType.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.lblType.Location = New System.Drawing.Point(16, 184)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 24)
        Me.lblType.TabIndex = 17
        Me.lblType.Text = "Type"
        '
        'cboType
        '
        Me.cboType.DataMember = "BBINDTY"
        Me.cboType.DataSource = Me._dataTypeIndividu
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.Info
        Me.cboType.DisplayLayout.Appearance = Appearance1
        Me.cboType.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 243
        UltraGridColumn4.Header.Caption = "Type"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 213
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.cboType.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cboType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.cboType.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.cboType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboType.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.cboType.DisplayLayout.MaxColScrollRegions = 1
        Me.cboType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboType.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cboType.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.cboType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cboType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.cboType.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cboType.DisplayLayout.Override.CellAppearance = Appearance8
        Me.cboType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboType.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.cboType.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.cboType.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.cboType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.cboType.DisplayLayout.Override.RowAppearance = Appearance11
        Me.cboType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.cboType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboType.DisplayMember = "SCF_TY_IND"
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.Location = New System.Drawing.Point(150, 184)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(232, 22)
        Me.cboType.TabIndex = 18
        Me.cboType.ValueMember = "ID_TY_IND"
        '
        '_dataTypeIndividu
        '
        Me._dataTypeIndividu.DataSetName = "TDSIndividutype"
        Me._dataTypeIndividu.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataTypeIndividu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkActiveBst
        '
        Me.chkActiveBst.AutoSize = True
        Me.chkActiveBst.Location = New System.Drawing.Point(150, 217)
        Me.chkActiveBst.Name = "chkActiveBst"
        Me.chkActiveBst.Size = New System.Drawing.Size(15, 14)
        Me.chkActiveBst.TabIndex = 19
        Me.chkActiveBst.UseVisualStyleBackColor = True
        '
        'UltraLabel1
        '
        Me.UltraLabel1.InnerBorderPadding = New System.Drawing.Size(10, 5)
        Me.UltraLabel1.Location = New System.Drawing.Point(17, 209)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(127, 43)
        Me.UltraLabel1.TabIndex = 20
        Me.UltraLabel1.Text = "Toon in lijst bestemmelingen:"
        '
        'FormIndividuChange
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 267)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.chkActiveBst)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.UltraOptionSetGeslacht)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtWoonplaats)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtAdres)
        Me.Controls.Add(Me.txtVoornaam)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.txtStamnummer)
        Me.Controls.Add(Me.lblGeslacht)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblWoonplaats)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.lblAdres)
        Me.Controls.Add(Me.lblVoornaam)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblStamnummer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormIndividuChange"
        Me.Text = "Individu"
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNaam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoornaam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWoonplaats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraOptionSetGeslacht, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataTypeIndividu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FormIndividuChange_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            UltraOptionSetGeslacht.Value = 1

            'Ophalen van type individuen
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            cboType.DataSource = proxy.GetIndividutypes()

            If Not _aRow Is Nothing Then
                _isUpdate = True

                txtStamnummer.Enabled = False

                txtStamnummer.Text = _aRow.ID_IND
                txtNaam.Text = _aRow.NM_IND
                txtVoornaam.Text = IIf(_aRow.Item("VNM_IND") Is DBNull.Value, "", _aRow.Item("VNM_IND"))
                txtAdres.Text = IIf(_aRow.Item("AD_IND") Is DBNull.Value, "", _aRow.Item("AD_IND"))
                txtPostcode.Text = IIf(_aRow.Item("PO_COD_WNPL_IND") Is DBNull.Value, "", _aRow.Item("PO_COD_WNPL_IND"))
                txtWoonplaats.Text = IIf(_aRow.Item("WNPL_IND") Is DBNull.Value, "", _aRow.Item("WNPL_IND"))
                txtEmail.Text = IIf(_aRow.Item("AD_EMAL_IND") Is DBNull.Value, "", _aRow.Item("AD_EMAL_IND"))
                If Not _aRow.Item("ID_GSL_IND") Is DBNull.Value Then
                    UltraOptionSetGeslacht.Value = _aRow.ID_GSL_IND
                End If

                cboType.Value = _aRow.ID_TY_IND
                chkActiveBst.Checked = _aRow.BST_ACTIVE
            Else
                'Nieuw stamnummer creëren (laatste boven 1 miljoen + 1)
                Dim stamnummer As Integer = proxy.GetLastStamnummer()
                If stamnummer < 1000000 Then
                    stamnummer = 1000001
                Else
                    stamnummer += 1
                End If

                txtStamnummer.Text = CStr(stamnummer)
            End If
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking - Load:  " & vbCrLf & _
                          "Form: FormIndividuChange" & vbCrLf & _
                          "Message: " & ex.Message & vbCrLf & _
                          "Stacktrace: " & ex.StackTrace, "btnOpslaan_Click", _
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnOpslaan_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOpslaan.Click
        Try
            'controle 
            If txtStamnummer.Text.Trim = "" Then
                MessageBox.Show("Gelieve een stamnummer in te vullen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If cboType.Value Is Nothing Then
                MessageBox.Show("Gelieve een type te selecteren.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtNaam.Text.Trim = "" Then
                MessageBox.Show("Gelieve een naam in te vullen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtVoornaam.Text.Trim.Trim = "" Then
                MessageBox.Show("Gelieve een voornaam in te vullen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim aDat As New Proxy.BBWService.Mgt.TDSIndividuen
            addRowToTable(aDat)

            'wegschrijven naar DB
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy

            If _isUpdate = True Then
                Dim updateDat As Proxy.BBWService.Mgt.TDSIndividuen
                updateDat = proxy.GetIndividu(_aRow.ID_IND) 'old stamnummer opvragen
                updateDat.BBIND(0).ID_IND = txtStamnummer.Text.Trim
                updateDat.BBIND(0).NM_IND = txtNaam.Text.Trim
                updateDat.BBIND(0).VNM_IND = txtVoornaam.Text.Trim
                updateDat.BBIND(0).AD_IND = txtAdres.Text.Trim
                updateDat.BBIND(0).PO_COD_WNPL_IND = txtPostcode.Text.Trim
                updateDat.BBIND(0).WNPL_IND = txtWoonplaats.Text.Trim
                updateDat.BBIND(0).AD_EMAL_IND = txtEmail.Text.Trim
                updateDat.BBIND(0).ID_GSL_IND = UltraOptionSetGeslacht.Value
                updateDat.BBIND(0).ID_TY_IND = cboType.Value
                updateDat.BBIND(0).BST_ACTIVE = chkActiveBst.Checked
                proxy.RegisterIndividu(updateDat, Environment.UserName)

                'Indien OK --> local dataset aanpassen
                _aRow.ID_IND = txtStamnummer.Text.Trim
                _aRow.NM_IND = txtNaam.Text.Trim
                _aRow.VNM_IND = txtVoornaam.Text.Trim
                _aRow.AD_IND = txtAdres.Text.Trim
                _aRow.PO_COD_WNPL_IND = txtPostcode.Text.Trim
                _aRow.WNPL_IND = txtWoonplaats.Text.Trim
                _aRow.AD_EMAL_IND = txtEmail.Text.Trim
                _aRow.ID_GSL_IND = UltraOptionSetGeslacht.Value
                _aRow.ID_TY_IND = cboType.Value
                _aRow.SCF_TY_IND = cboType.Text
                _aRow.BST_ACTIVE = chkActiveBst.Checked
                _aRow.AcceptChanges()
            Else
                proxy.RegisterIndividu(aDat, Environment.UserName)
                'Indien OK --> local dataset aanpassen
                addRowToTable(CType(FormManager.Current.DataIndividuen, TDSIndividuen))
                addRowToTable(FormManager.Current.DataIndividuen_Bestemmelingen)
            End If

            'OK --> sluiten form
            Close()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                      "Form: FormIndividuChange" & vbCrLf & _
                                      "Message: " & ex.Message & vbCrLf & _
                                      "Stacktrace: " & ex.StackTrace, "btnOpslaan_Click", _
                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Overloads Sub addRowToTable(ByVal table As TDSIndividuen)
        Try
            Dim aRow As TDSIndividuen.BBINDRow = table.BBIND.NewBBINDRow()
            aRow.ID_IND = txtStamnummer.Text.Trim
            aRow.NM_IND = txtNaam.Text.Trim
            aRow.VNM_IND = txtVoornaam.Text.Trim
            aRow.AD_IND = txtAdres.Text.Trim
            aRow.PO_COD_WNPL_IND = txtPostcode.Text.Trim
            aRow.WNPL_IND = txtWoonplaats.Text.Trim
            aRow.AD_EMAL_IND = txtEmail.Text.Trim
            aRow.ID_GSL_IND = UltraOptionSetGeslacht.Value
            aRow.ID_TY_IND = cboType.Value
            aRow.SCF_TY_IND = cboType.Text
            aRow.BST_ACTIVE = chkActiveBst.Checked

            table.BBIND.AddBBINDRow(aRow)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Overloads Sub addRowToTable(ByVal table As Proxy.BBWService.Mgt.TDSIndividuen)
        Try
            Dim aRow As Proxy.BBWService.Mgt.TDSIndividuen.BBINDRow = table.BBIND.NewBBINDRow()
            aRow.ID_IND = txtStamnummer.Text.Trim
            aRow.NM_IND = txtNaam.Text.Trim
            aRow.VNM_IND = txtVoornaam.Text.Trim
            aRow.AD_IND = txtAdres.Text.Trim
            aRow.PO_COD_WNPL_IND = txtPostcode.Text.Trim
            aRow.WNPL_IND = txtWoonplaats.Text.Trim
            aRow.AD_EMAL_IND = txtEmail.Text.Trim
            aRow.ID_GSL_IND = UltraOptionSetGeslacht.Value
            aRow.ID_TY_IND = cboType.Value
            aRow.SCF_TY_IND = cboType.Text
            aRow.BST_ACTIVE = chkActiveBst.Checked

            table.BBIND.AddBBINDRow(aRow)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class