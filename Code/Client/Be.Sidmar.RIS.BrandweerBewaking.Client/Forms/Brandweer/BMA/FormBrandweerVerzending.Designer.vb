Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerVerzending
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
            Dim DateButton5 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Dim DateButton6 As Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton = New Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton()
            Me._dataBrandweerVerzending = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerVerzending()
            Me.TextBoxVolgnr = New System.Windows.Forms.TextBox()
            Me.ComboBoxLeverancier = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerLeveranciers = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerLeveranciers()
            Me.CheckBoxHerkeurd = New System.Windows.Forms.CheckBox()
            Me.TextBoxOpmerkingen = New System.Windows.Forms.TextBox()
            Me.ButtonOpslaan = New System.Windows.Forms.Button()
            Me.ButtonAnnuleer = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.ButtonZoekMateriaal = New System.Windows.Forms.Button()
            Me.ComboBoxTypeMateriaal = New System.Windows.Forms.ComboBox()
            Me._dataBrandweerTypeMateriaal = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerTypeMateriaal()
            Me.DateTimePickerDatumVerstuurd = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.DateTimePickerDatumTerug = New Infragistics.Win.UltraWinSchedule.UltraCalendarCombo()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.LabelMateriaalOmschr = New System.Windows.Forms.Label()
            CType(Me._dataBrandweerVerzending, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerLeveranciers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._dataBrandweerTypeMateriaal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateTimePickerDatumVerstuurd, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateTimePickerDatumTerug, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_dataBrandweerVerzending
            '
            Me._dataBrandweerVerzending.DataSetName = "TDSBrandweerVerzending"
            Me._dataBrandweerVerzending.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'TextBoxVolgnr
            '
            Me.TextBoxVolgnr.Location = New System.Drawing.Point(134, 7)
            Me.TextBoxVolgnr.Name = "TextBoxVolgnr"
            Me.TextBoxVolgnr.ReadOnly = True
            Me.TextBoxVolgnr.Size = New System.Drawing.Size(100, 20)
            Me.TextBoxVolgnr.TabIndex = 15
            '
            'ComboBoxLeverancier
            '
            Me.ComboBoxLeverancier.DataSource = Me._dataBrandweerLeveranciers
            Me.ComboBoxLeverancier.DisplayMember = "Leverancier.NaamLeverancier"
            Me.ComboBoxLeverancier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxLeverancier.FormattingEnabled = True
            Me.ComboBoxLeverancier.Location = New System.Drawing.Point(134, 84)
            Me.ComboBoxLeverancier.Name = "ComboBoxLeverancier"
            Me.ComboBoxLeverancier.Size = New System.Drawing.Size(248, 21)
            Me.ComboBoxLeverancier.TabIndex = 2
            Me.ComboBoxLeverancier.ValueMember = "Leverancier.LeverancierID"
            '
            '_dataBrandweerLeveranciers
            '
            Me._dataBrandweerLeveranciers.DataSetName = "TDSBrandweerLeveranciers"
            Me._dataBrandweerLeveranciers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CheckBoxHerkeurd
            '
            Me.CheckBoxHerkeurd.AutoSize = True
            Me.CheckBoxHerkeurd.Location = New System.Drawing.Point(134, 164)
            Me.CheckBoxHerkeurd.Name = "CheckBoxHerkeurd"
            Me.CheckBoxHerkeurd.Size = New System.Drawing.Size(70, 17)
            Me.CheckBoxHerkeurd.TabIndex = 7
            Me.CheckBoxHerkeurd.Text = "Herkeurd"
            Me.CheckBoxHerkeurd.UseVisualStyleBackColor = True
            '
            'TextBoxOpmerkingen
            '
            Me.TextBoxOpmerkingen.AcceptsReturn = True
            Me.TextBoxOpmerkingen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBoxOpmerkingen.Location = New System.Drawing.Point(134, 191)
            Me.TextBoxOpmerkingen.Multiline = True
            Me.TextBoxOpmerkingen.Name = "TextBoxOpmerkingen"
            Me.TextBoxOpmerkingen.Size = New System.Drawing.Size(286, 125)
            Me.TextBoxOpmerkingen.TabIndex = 9
            '
            'ButtonOpslaan
            '
            Me.ButtonOpslaan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOpslaan.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Save
            Me.ButtonOpslaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonOpslaan.Location = New System.Drawing.Point(241, 322)
            Me.ButtonOpslaan.Name = "ButtonOpslaan"
            Me.ButtonOpslaan.Size = New System.Drawing.Size(89, 23)
            Me.ButtonOpslaan.TabIndex = 10
            Me.ButtonOpslaan.Text = "Opslaan"
            Me.ButtonOpslaan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.ButtonOpslaan, "Verzending bewaren")
            Me.ButtonOpslaan.UseVisualStyleBackColor = True
            '
            'ButtonAnnuleer
            '
            Me.ButtonAnnuleer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonAnnuleer.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
            Me.ButtonAnnuleer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonAnnuleer.Location = New System.Drawing.Point(336, 322)
            Me.ButtonAnnuleer.Name = "ButtonAnnuleer"
            Me.ButtonAnnuleer.Size = New System.Drawing.Size(84, 23)
            Me.ButtonAnnuleer.TabIndex = 11
            Me.ButtonAnnuleer.Text = "Annuleren"
            Me.ButtonAnnuleer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonAnnuleer.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(77, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Type Materiaal"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 10)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 13)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "Volgnummer"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(14, 87)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(89, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Naar Leverancier"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(14, 115)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(86, 13)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Datum Verstuurd"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(14, 142)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(69, 13)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "Datum Terug"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(14, 191)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(70, 13)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "Opmerkingen"
            '
            'ButtonZoekMateriaal
            '
            Me.ButtonZoekMateriaal.Location = New System.Drawing.Point(241, 5)
            Me.ButtonZoekMateriaal.Name = "ButtonZoekMateriaal"
            Me.ButtonZoekMateriaal.Size = New System.Drawing.Size(24, 23)
            Me.ButtonZoekMateriaal.TabIndex = 0
            Me.ButtonZoekMateriaal.Text = "..."
            Me.ToolTip1.SetToolTip(Me.ButtonZoekMateriaal, "Kies materiaal (dubbelklikken in lijst materiaal)")
            Me.ButtonZoekMateriaal.UseVisualStyleBackColor = True
            '
            'ComboBoxTypeMateriaal
            '
            Me.ComboBoxTypeMateriaal.DataSource = Me._dataBrandweerTypeMateriaal
            Me.ComboBoxTypeMateriaal.DisplayMember = "BrandweerMateriaalTypes.TypeMatOmschr"
            Me.ComboBoxTypeMateriaal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxTypeMateriaal.Enabled = False
            Me.ComboBoxTypeMateriaal.FormattingEnabled = True
            Me.ComboBoxTypeMateriaal.Location = New System.Drawing.Point(134, 57)
            Me.ComboBoxTypeMateriaal.Name = "ComboBoxTypeMateriaal"
            Me.ComboBoxTypeMateriaal.Size = New System.Drawing.Size(248, 21)
            Me.ComboBoxTypeMateriaal.TabIndex = 13
            Me.ComboBoxTypeMateriaal.ValueMember = "BrandweerMateriaalTypes.TypeMatID"
            '
            '_dataBrandweerTypeMateriaal
            '
            Me._dataBrandweerTypeMateriaal.DataSetName = "TDSBrandweerTypeMateriaal"
            Me._dataBrandweerTypeMateriaal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DateTimePickerDatumVerstuurd
            '
            Me.DateTimePickerDatumVerstuurd.DateButtons.Add(DateButton5)
            Me.DateTimePickerDatumVerstuurd.Format = "dd MMM yyyy"
            Me.DateTimePickerDatumVerstuurd.Location = New System.Drawing.Point(134, 112)
            Me.DateTimePickerDatumVerstuurd.Name = "DateTimePickerDatumVerstuurd"
            Me.DateTimePickerDatumVerstuurd.NonAutoSizeHeight = 21
            Me.DateTimePickerDatumVerstuurd.Size = New System.Drawing.Size(131, 21)
            Me.DateTimePickerDatumVerstuurd.TabIndex = 4
            Me.DateTimePickerDatumVerstuurd.Value = ""
            '
            'DateTimePickerDatumTerug
            '
            Me.DateTimePickerDatumTerug.DateButtons.Add(DateButton6)
            Me.DateTimePickerDatumTerug.Format = "dd MMM yyyy"
            Me.DateTimePickerDatumTerug.Location = New System.Drawing.Point(134, 139)
            Me.DateTimePickerDatumTerug.Name = "DateTimePickerDatumTerug"
            Me.DateTimePickerDatumTerug.NonAutoSizeHeight = 21
            Me.DateTimePickerDatumTerug.Size = New System.Drawing.Size(131, 21)
            Me.DateTimePickerDatumTerug.TabIndex = 6
            Me.DateTimePickerDatumTerug.Value = ""
            '
            'LabelMateriaalOmschr
            '
            Me.LabelMateriaalOmschr.AutoSize = True
            Me.LabelMateriaalOmschr.Location = New System.Drawing.Point(134, 27)
            Me.LabelMateriaalOmschr.Name = "LabelMateriaalOmschr"
            Me.LabelMateriaalOmschr.Size = New System.Drawing.Size(10, 13)
            Me.LabelMateriaalOmschr.TabIndex = 16
            Me.LabelMateriaalOmschr.Text = "-"
            '
            'FormBrandweerVerzending
            '
            Me.AcceptButton = Me.ButtonOpslaan
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonAnnuleer
            Me.ClientSize = New System.Drawing.Size(432, 356)
            Me.Controls.Add(Me.LabelMateriaalOmschr)
            Me.Controls.Add(Me.DateTimePickerDatumTerug)
            Me.Controls.Add(Me.DateTimePickerDatumVerstuurd)
            Me.Controls.Add(Me.ComboBoxTypeMateriaal)
            Me.Controls.Add(Me.ButtonZoekMateriaal)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ButtonAnnuleer)
            Me.Controls.Add(Me.ButtonOpslaan)
            Me.Controls.Add(Me.TextBoxOpmerkingen)
            Me.Controls.Add(Me.CheckBoxHerkeurd)
            Me.Controls.Add(Me.ComboBoxLeverancier)
            Me.Controls.Add(Me.TextBoxVolgnr)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(440, 260)
            Me.Name = "FormBrandweerVerzending"
            Me.Text = "Materiaal verzending"
            CType(Me._dataBrandweerVerzending, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerLeveranciers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._dataBrandweerTypeMateriaal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateTimePickerDatumVerstuurd, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateTimePickerDatumTerug, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents _dataBrandweerVerzending As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerVerzending
        Friend WithEvents TextBoxVolgnr As System.Windows.Forms.TextBox
        Friend WithEvents ComboBoxLeverancier As System.Windows.Forms.ComboBox
        Friend WithEvents CheckBoxHerkeurd As System.Windows.Forms.CheckBox
        Friend WithEvents TextBoxOpmerkingen As System.Windows.Forms.TextBox
        Friend WithEvents ButtonOpslaan As System.Windows.Forms.Button
        Friend WithEvents ButtonAnnuleer As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents ButtonZoekMateriaal As System.Windows.Forms.Button
        Friend WithEvents ComboBoxTypeMateriaal As System.Windows.Forms.ComboBox
        Friend WithEvents _dataBrandweerLeveranciers As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerLeveranciers
        Friend WithEvents _dataBrandweerTypeMateriaal As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerTypeMateriaal
        Friend WithEvents DateTimePickerDatumVerstuurd As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents DateTimePickerDatumTerug As Infragistics.Win.UltraWinSchedule.UltraCalendarCombo
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents LabelMateriaalOmschr As System.Windows.Forms.Label
    End Class
End Namespace