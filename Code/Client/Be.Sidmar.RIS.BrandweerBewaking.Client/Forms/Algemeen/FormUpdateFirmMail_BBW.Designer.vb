<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateFirmMail_BBW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateFirmMail_BBW))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBBW_FirmEmail = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBoxBBW_FirmRemark = New System.Windows.Forms.TextBox()
        Me.ComboBoxLanguage = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSave = New Infragistics.Win.Misc.UltraButton()
        Me.ButtonCancel = New Infragistics.Win.Misc.UltraButton()
        Me.LabelFirmNrName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firma email contactpersoon/personen:"
        '
        'TextBoxBBW_FirmEmail
        '
        Me.TextBoxBBW_FirmEmail.Location = New System.Drawing.Point(209, 40)
        Me.TextBoxBBW_FirmEmail.MaxLength = 250
        Me.TextBoxBBW_FirmEmail.Name = "TextBoxBBW_FirmEmail"
        Me.TextBoxBBW_FirmEmail.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxBBW_FirmEmail.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBoxBBW_FirmEmail, "indien meerdere mail-adressen: gescheiden door ;")
        '
        'TextBoxBBW_FirmRemark
        '
        Me.TextBoxBBW_FirmRemark.Location = New System.Drawing.Point(209, 73)
        Me.TextBoxBBW_FirmRemark.MaxLength = 250
        Me.TextBoxBBW_FirmRemark.Name = "TextBoxBBW_FirmRemark"
        Me.TextBoxBBW_FirmRemark.Size = New System.Drawing.Size(503, 20)
        Me.TextBoxBBW_FirmRemark.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBoxBBW_FirmRemark, "bv. mail niet gekend door betrokkene")
        '
        'ComboBoxLanguage
        '
        Me.ComboBoxLanguage.FormattingEnabled = True
        Me.ComboBoxLanguage.Items.AddRange(New Object() {"NL", "FR", "EN", "DU"})
        Me.ComboBoxLanguage.Location = New System.Drawing.Point(209, 110)
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        Me.ComboBoxLanguage.Size = New System.Drawing.Size(47, 21)
        Me.ComboBoxLanguage.TabIndex = 2
        Me.ComboBoxLanguage.Text = "NL"
        Me.ToolTip1.SetToolTip(Me.ComboBoxLanguage, "In welke taal de mail naar de contacpersonen versturen")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Firma opmerking:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firma taal (NL, EN, ...):"
        '
        'ButtonSave
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.ButtonSave.Appearance = Appearance1
        Me.ButtonSave.ImageSize = New System.Drawing.Size(14, 14)
        Me.ButtonSave.Location = New System.Drawing.Point(624, 168)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(88, 23)
        Me.ButtonSave.TabIndex = 3
        Me.ButtonSave.Text = "Opslaan"
        '
        'ButtonCancel
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.ButtonCancel.Appearance = Appearance2
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(529, 168)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(88, 23)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Sluiten"
        '
        'LabelFirmNrName
        '
        Me.LabelFirmNrName.AutoSize = True
        Me.LabelFirmNrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirmNrName.Location = New System.Drawing.Point(13, 9)
        Me.LabelFirmNrName.Name = "LabelFirmNrName"
        Me.LabelFirmNrName.Size = New System.Drawing.Size(14, 17)
        Me.LabelFirmNrName.TabIndex = 5
        Me.LabelFirmNrName.Text = "-"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 43)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gelieve email-adres aan de betrokken persoon te vragen (=> firma zal verslag ontv" & _
            "angen bij verzenden naar bestemmelingen)"
        '
        'FormUpdateFirmMail_BBW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(724, 211)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelFirmNrName)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboBoxLanguage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxBBW_FirmRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBBW_FirmEmail)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdateFirmMail_BBW"
        Me.Text = "Update firma BBW: mail/opmerking/taal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBBW_FirmEmail As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBBW_FirmRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ButtonCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelFirmNrName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
