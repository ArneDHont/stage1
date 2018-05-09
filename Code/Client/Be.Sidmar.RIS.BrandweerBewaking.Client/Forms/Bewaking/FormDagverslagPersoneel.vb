Imports system.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormDagverslagPersoneel
    Inherits System.Windows.Forms.Form

    Private _isUpdate As Boolean = False

    Private _id_dg_pers As Integer
    Private _datDagverslagPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal id_dg_pers As Integer, _
                   ByVal datDagverslagPersoneel As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel)
        Me.New()
        Me._id_dg_pers = id_dg_pers
        Me._datDagverslagPersoneel = datDagverslagPersoneel

        If Me._id_dg_pers > 0 Then
            Me._isUpdate = True
        End If
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
    Friend WithEvents UltraButtonAnnuleer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonOpslaan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelStamnr As System.Windows.Forms.Label
    Friend WithEvents LabelDatumRegistratie As System.Windows.Forms.Label
    Friend WithEvents ButtonKiesPersoonMelder As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCommentaar As System.Windows.Forms.TextBox
    Friend WithEvents cobRegistratie As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblNaam As System.Windows.Forms.Label
    Friend WithEvents lblSapDirectie As System.Windows.Forms.Label
    Friend WithEvents lblSapAfdeling As System.Windows.Forms.Label
    Friend WithEvents dtpUurRegistratie As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents dtpDatumRegistratie As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents TextBoxStamnummer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents _dataDagverslagRegistratieType As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType
    Friend WithEvents lblVoornaam As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDagverslagPersoneel))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBDGTYREG", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DG_PERS_TY_REG")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SCF_DG_PERS_TY_REG")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraButtonAnnuleer = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonOpslaan = New Infragistics.Win.Misc.UltraButton
        Me.LabelStamnr = New System.Windows.Forms.Label
        Me.LabelDatumRegistratie = New System.Windows.Forms.Label
        Me.ButtonKiesPersoonMelder = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cobRegistratie = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me._dataDagverslagRegistratieType = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSDagverslagRegistratieType
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxCommentaar = New System.Windows.Forms.TextBox
        Me.lblNaam = New System.Windows.Forms.Label
        Me.lblSapDirectie = New System.Windows.Forms.Label
        Me.lblSapAfdeling = New System.Windows.Forms.Label
        Me.dtpUurRegistratie = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.dtpDatumRegistratie = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.TextBoxStamnummer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.lblVoornaam = New System.Windows.Forms.Label
        CType(Me.cobRegistratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._dataDagverslagRegistratieType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDatumRegistratie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxStamnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraButtonAnnuleer
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.UltraButtonAnnuleer.Appearance = Appearance1
        Me.UltraButtonAnnuleer.Location = New System.Drawing.Point(104, 256)
        Me.UltraButtonAnnuleer.Name = "UltraButtonAnnuleer"
        Me.UltraButtonAnnuleer.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonAnnuleer.TabIndex = 9
        Me.UltraButtonAnnuleer.Text = "Annuleer"
        '
        'UltraButtonOpslaan
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.UltraButtonOpslaan.Appearance = Appearance2
        Me.UltraButtonOpslaan.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonOpslaan.Location = New System.Drawing.Point(216, 256)
        Me.UltraButtonOpslaan.Name = "UltraButtonOpslaan"
        Me.UltraButtonOpslaan.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonOpslaan.TabIndex = 8
        Me.UltraButtonOpslaan.Text = "Opslaan"
        '
        'LabelStamnr
        '
        Me.LabelStamnr.AutoSize = True
        Me.LabelStamnr.Location = New System.Drawing.Point(8, 8)
        Me.LabelStamnr.Name = "LabelStamnr"
        Me.LabelStamnr.Size = New System.Drawing.Size(75, 16)
        Me.LabelStamnr.TabIndex = 10
        Me.LabelStamnr.Text = "Stamnummer:"
        '
        'LabelDatumRegistratie
        '
        Me.LabelDatumRegistratie.AutoSize = True
        Me.LabelDatumRegistratie.Location = New System.Drawing.Point(8, 120)
        Me.LabelDatumRegistratie.Name = "LabelDatumRegistratie"
        Me.LabelDatumRegistratie.Size = New System.Drawing.Size(94, 16)
        Me.LabelDatumRegistratie.TabIndex = 11
        Me.LabelDatumRegistratie.Text = "Datum registratie:"
        '
        'ButtonKiesPersoonMelder
        '
        Me.ButtonKiesPersoonMelder.Location = New System.Drawing.Point(216, 8)
        Me.ButtonKiesPersoonMelder.Name = "ButtonKiesPersoonMelder"
        Me.ButtonKiesPersoonMelder.Size = New System.Drawing.Size(80, 20)
        Me.ButtonKiesPersoonMelder.TabIndex = 1
        Me.ButtonKiesPersoonMelder.Text = "Kies persoon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Naam:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "SAP directie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "SAP afdeling:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Uur registratie:"
        '
        'cobRegistratie
        '
        Me.cobRegistratie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cobRegistratie.DataSource = Me._dataDagverslagRegistratieType
        Appearance3.BackColor = System.Drawing.SystemColors.Window
        Appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cobRegistratie.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Omschrijving"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 200
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cobRegistratie.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cobRegistratie.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cobRegistratie.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.cobRegistratie.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobRegistratie.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.cobRegistratie.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cobRegistratie.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.cobRegistratie.DisplayLayout.MaxColScrollRegions = 1
        Me.cobRegistratie.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cobRegistratie.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.SystemColors.Highlight
        Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cobRegistratie.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.cobRegistratie.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cobRegistratie.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.cobRegistratie.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cobRegistratie.DisplayLayout.Override.CellAppearance = Appearance10
        Me.cobRegistratie.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cobRegistratie.DisplayLayout.Override.CellPadding = 0
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.cobRegistratie.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Left
        Me.cobRegistratie.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.cobRegistratie.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cobRegistratie.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.cobRegistratie.DisplayLayout.Override.RowAppearance = Appearance13
        Me.cobRegistratie.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cobRegistratie.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.cobRegistratie.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cobRegistratie.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cobRegistratie.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cobRegistratie.DisplayMember = "SCF_DG_PERS_TY_REG"
        Me.cobRegistratie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobRegistratie.Location = New System.Drawing.Point(104, 184)
        Me.cobRegistratie.Name = "cobRegistratie"
        Me.cobRegistratie.Size = New System.Drawing.Size(200, 21)
        Me.cobRegistratie.TabIndex = 6
        Me.cobRegistratie.ValueMember = "ID_DG_PERS_TY_REG"
        '
        '_dataDagverslagRegistratieType
        '
        Me._dataDagverslagRegistratieType.DataSetName = "TDSDagverslagRegistratieType"
        Me._dataDagverslagRegistratieType.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Registratie:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Commentaar:"
        '
        'TextBoxCommentaar
        '
        Me.TextBoxCommentaar.Location = New System.Drawing.Point(104, 216)
        Me.TextBoxCommentaar.MaxLength = 50
        Me.TextBoxCommentaar.Name = "TextBoxCommentaar"
        Me.TextBoxCommentaar.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCommentaar.TabIndex = 7
        Me.TextBoxCommentaar.Text = ""
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(104, 40)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(34, 16)
        Me.lblNaam.TabIndex = 2
        Me.lblNaam.Text = "Naam"
        '
        'lblSapDirectie
        '
        Me.lblSapDirectie.AutoSize = True
        Me.lblSapDirectie.Location = New System.Drawing.Point(104, 64)
        Me.lblSapDirectie.Name = "lblSapDirectie"
        Me.lblSapDirectie.Size = New System.Drawing.Size(66, 16)
        Me.lblSapDirectie.TabIndex = 2
        Me.lblSapDirectie.Text = "SAP directie"
        '
        'lblSapAfdeling
        '
        Me.lblSapAfdeling.AutoSize = True
        Me.lblSapAfdeling.Location = New System.Drawing.Point(104, 88)
        Me.lblSapAfdeling.Name = "lblSapAfdeling"
        Me.lblSapAfdeling.Size = New System.Drawing.Size(70, 16)
        Me.lblSapAfdeling.TabIndex = 3
        Me.lblSapAfdeling.Text = "SAP afdeling"
        '
        'dtpUurRegistratie
        '
        Me.dtpUurRegistratie.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Time
        Me.dtpUurRegistratie.InputMask = "{time}"
        Me.dtpUurRegistratie.Location = New System.Drawing.Point(104, 152)
        Me.dtpUurRegistratie.Name = "dtpUurRegistratie"
        Me.dtpUurRegistratie.Size = New System.Drawing.Size(40, 20)
        'Me.dtpUurRegistratie.SupportThemes = False 'Dien - aug2008 - migratie 2008
        Me.dtpUurRegistratie.UseOsThemes = Infragistics.Win.DefaultableBoolean.False
        Me.dtpUurRegistratie.TabIndex = 5
        Me.dtpUurRegistratie.Text = ":"
        '
        'dtpDatumRegistratie
        '
        Me.dtpDatumRegistratie.Location = New System.Drawing.Point(104, 120)
        Me.dtpDatumRegistratie.Name = "dtpDatumRegistratie"
        Me.dtpDatumRegistratie.Size = New System.Drawing.Size(88, 21)
        'Me.dtpDatumRegistratie.SupportThemes = False 'Dien - aug2008 - migratie 2008
        Me.dtpDatumRegistratie.UseOsThemes = Infragistics.Win.DefaultableBoolean.False
        Me.dtpDatumRegistratie.TabIndex = 4
        '
        'TextBoxStamnummer
        '
        Me.TextBoxStamnummer.Location = New System.Drawing.Point(104, 8)
        Me.TextBoxStamnummer.Name = "TextBoxStamnummer"
        Me.TextBoxStamnummer.Nullable = True
        Me.TextBoxStamnummer.PromptChar = Microsoft.VisualBasic.ChrW(32)
        Me.TextBoxStamnummer.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxStamnummer.TabIndex = 0
        Me.TextBoxStamnummer.Value = Nothing
        '
        'lblVoornaam
        '
        Me.lblVoornaam.AutoSize = True
        Me.lblVoornaam.Location = New System.Drawing.Point(216, 40)
        Me.lblVoornaam.Name = "lblVoornaam"
        Me.lblVoornaam.Size = New System.Drawing.Size(56, 16)
        Me.lblVoornaam.TabIndex = 26
        Me.lblVoornaam.Text = "Voornaam"
        '
        'FormDagverslagPersoneel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 286)
        Me.Controls.Add(Me.lblVoornaam)
        Me.Controls.Add(Me.TextBoxStamnummer)
        Me.Controls.Add(Me.dtpUurRegistratie)
        Me.Controls.Add(Me.dtpDatumRegistratie)
        Me.Controls.Add(Me.lblSapAfdeling)
        Me.Controls.Add(Me.lblSapDirectie)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.TextBoxCommentaar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelDatumRegistratie)
        Me.Controls.Add(Me.LabelStamnr)
        Me.Controls.Add(Me.cobRegistratie)
        Me.Controls.Add(Me.ButtonKiesPersoonMelder)
        Me.Controls.Add(Me.UltraButtonAnnuleer)
        Me.Controls.Add(Me.UltraButtonOpslaan)
        Me.KeyPreview = True
        Me.Name = "FormDagverslagPersoneel"
        Me.Text = "Dagverslag personeel"
        CType(Me.cobRegistratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._dataDagverslagRegistratieType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDatumRegistratie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxStamnummer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormDagverslagPersoneel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Ophalen registratietypes
            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            Me.cobRegistratie.DataSource = proxy.DagverslagRegistratieTypes

            If Me._isUpdate = True Then
                invullenRegistratie()
                invullenIndividu()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonKiesPersoonMelder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKiesPersoonMelder.Click
        Try
            Dim oFrmSelectiePersoneel As New FormIndividuen(False, String.Empty)
            oFrmSelectiePersoneel.ShowDialog(Me)

            If oFrmSelectiePersoneel.Individu Is Nothing Then
                Exit Sub
            Else
                Me.TextBoxStamnummer.Text = oFrmSelectiePersoneel.idIndi
                If oFrmSelectiePersoneel.Individu.IsNM_INDNull = False Then
                    Me.lblNaam.Text = oFrmSelectiePersoneel.Individu.NM_IND
                Else
                    Me.lblNaam.Text = ""
                End If
                If oFrmSelectiePersoneel.Individu.IsVNM_INDNull = False Then
                    Me.lblvoornaam.text = oFrmSelectiePersoneel.Individu.VNM_IND
                Else
                    Me.lblvoornaam.text = ""
                End If
                If oFrmSelectiePersoneel.Individu.IsSAP_DIRNull = False Then
                    Me.lblSapDirectie.Text = oFrmSelectiePersoneel.Individu.SAP_DIR
                Else
                    Me.lblSapDirectie.Text = ""
                End If
                If oFrmSelectiePersoneel.Individu.IsSAP_AFDNull = False Then
                    Me.lblSapAfdeling.Text = oFrmSelectiePersoneel.Individu.SAP_AFD
                Else
                    Me.lblSapAfdeling.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub TextBoxStamnummer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxStamnummer.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'ophalen van individu
                If Me.TextBoxStamnummer.Text = "" Then
                    MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    invullenIndividu()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub invullenRegistratie()
        Try

            If Me._id_dg_pers > 0 Then
                Dim tmpRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel.BBDGPERSRow
                tmpRow = Me._datDagverslagPersoneel.BBDGPERS.FindByID_DG_PERS(Me._id_dg_pers)
                Me.TextBoxStamnummer.Text = tmpRow.ID_IND
                Me.dtpDatumRegistratie.Value = tmpRow.TMS_REG_DG_PERS
                Me.dtpUurRegistratie.Value = tmpRow.TMS_REG_DG_PERS
                Me.cobRegistratie.Value = tmpRow.ID_DG_PERS_TY_REG
                If tmpRow.IsOPMNull = True Then
                    Me.TextBoxCommentaar.Text = ""
                Else
                    Me.TextBoxCommentaar.Text = tmpRow.OPM
                End If
            Else
                'Me.TextBoxStamnummer.Value = 0
                Me.dtpDatumRegistratie.Value = Now
                Me.dtpUurRegistratie.Value = Now
                Me.TextBoxCommentaar.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
    Private Sub invullenIndividu()
        Try
            'Naam & sap directie & sap afdeling.
            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen.BBINDRow = CType(FormManager.Current.DataIndividuen, Be.Sidmar.RIS.BrandweerBewaking.Client.TDSIndividuen).BBIND.FindByID_IND(Me.TextBoxStamnummer.Text.Trim)
            If Not aRow Is Nothing Then
                If aRow.IsNM_INDNull = False Then
                    Me.lblNaam.Text = aRow.NM_IND
                Else
                    Me.lblNaam.Text = ""
                End If
                If aRow.IsVNM_INDNull = False Then
                    Me.lblVoornaam.Text = aRow.VNM_IND
                Else
                    Me.lblVoornaam.Text = ""
                End If

                If aRow.IsSAP_DIRNull = False Then
                    Me.lblSapDirectie.Text = aRow.SAP_DIR
                Else
                    Me.lblSapDirectie.Text = ""
                End If
                If aRow.IsSAP_AFDNull = False Then
                    Me.lblSapAfdeling.Text = aRow.SAP_AFD
                Else
                    Me.lblSapAfdeling.Text = ""
                End If
            Else
                MessageBox.Show("Stamnummer niet gevonden.", "Ongeldig stamnummer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonOpslaan.Click
        Try
            'Opslaan Nieuw/update
            'Siddien - 2 oktober 2006
            '
            UltraButtonOpslaan.Enabled = False  '29/03/2010 - concurrency error occured (proma 529218)
            'ik vermoed dat er wordt dubbelgeklikt op de knop bewaren

            'Controle velden correct ingevuld
            If Me.dtpUurRegistratie.Value Is DBNull.Value Then
                MessageBox.Show("Gelieve een uur in te geven.", "Ongeldig tijdstip.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.cobRegistratie.Value Is Nothing Then
                MessageBox.Show("Gelieve een registratietype te selecteren.", "Registratietype", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Int(Me.TextBoxStamnummer.Text.Trim) <= 0 Then
                MessageBox.Show("Gelieve een stamnummer te selecteren.", "Stamnummer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Dim aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel.BBDGPERSRow
            If Me._isUpdate = False Then
                aRow = Me._datDagverslagPersoneel.BBDGPERS.NewBBDGPERSRow()
            Else
                aRow = Me._datDagverslagPersoneel.BBDGPERS.FindByID_DG_PERS(Me._id_dg_pers)
            End If

            aRow.NM_IND = Me.lblNaam.Text
            aRow.VNM_IND = Me.lblVoornaam.Text

            aRow.jaar = CType(Me.dtpDatumRegistratie.Value, DateTime).Year
            aRow.maand = CType(Me.dtpDatumRegistratie.Value, DateTime).Month

            aRow.ID_IND = Me.TextBoxStamnummer.Text.Trim.Trim
            Dim aDate As New DateTime(CType(Me.dtpDatumRegistratie.Value, DateTime).Year, _
                                      CType(Me.dtpDatumRegistratie.Value, DateTime).Month, _
                                      CType(Me.dtpDatumRegistratie.Value, DateTime).Day, _
                                      CType(Me.dtpUurRegistratie.Value, DateTime).Hour, _
                                      CType(Me.dtpUurRegistratie.Value, DateTime).Minute, _
                                      CType(Me.dtpUurRegistratie.Value, DateTime).Second)
            aRow.TMS_REG_DG_PERS = aDate
            aRow.ID_DG_PERS_TY_REG = Me.cobRegistratie.Value
            aRow.OPM = Me.TextBoxCommentaar.Text

            If Me._isUpdate = False Then
                Me._datDagverslagPersoneel.BBDGPERS.AddBBDGPERSRow(aRow)
            End If

            Dim aProxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            aProxy.RegisterDagverslagPersoneel(Me._datDagverslagPersoneel.GetChanges(), System.Environment.UserName)

            Me._datDagverslagPersoneel.AcceptChanges()
            UltraButtonOpslaan.Enabled = True
            Me.Close()

        Catch ex As Exception
            UltraButtonOpslaan.Enabled = True
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAnnuleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAnnuleer.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub TextBoxStamnummer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxStamnummer.Leave
        Try
            'ophalen van individu
            If Me.TextBoxStamnummer.Text = "" Then
                MessageBox.Show("Gelieve een stamnummer in te geven.", "Stamnummer.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                invullenIndividu()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


End Class
