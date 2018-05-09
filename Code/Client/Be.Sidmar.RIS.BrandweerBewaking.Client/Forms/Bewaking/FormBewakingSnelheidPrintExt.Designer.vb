Namespace Forms.Bewaking
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBewakingSnelheidPrintExt
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.RadioButtonDE = New System.Windows.Forms.RadioButton()
            Me.RadioButtonEN = New System.Windows.Forms.RadioButton()
            Me.RadioButtonFR = New System.Windows.Forms.RadioButton()
            Me.RadioButtonNL = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.RadioButtonInbr3 = New System.Windows.Forms.RadioButton()
            Me.RadioButtonInbr2 = New System.Windows.Forms.RadioButton()
            Me.RadioButtonInbr1 = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBoxDriverName = New System.Windows.Forms.TextBox()
            Me.TextBoxNrPlate = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBoxSnelheid = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.TextBoxMaxSnelheid = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.TextBoxVoertuig = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.TextBoxFirmName = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TextBoxAddress = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.TextBoxCity = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.ButtonCancel = New System.Windows.Forms.Button()
            Me.ButtonZoekFirma = New System.Windows.Forms.Button()
            Me.ButtonOK = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.RadioButtonDE)
            Me.GroupBox1.Controls.Add(Me.RadioButtonEN)
            Me.GroupBox1.Controls.Add(Me.RadioButtonFR)
            Me.GroupBox1.Controls.Add(Me.RadioButtonNL)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(166, 124)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Taal"
            '
            'RadioButtonDE
            '
            Me.RadioButtonDE.AutoSize = True
            Me.RadioButtonDE.Location = New System.Drawing.Point(7, 94)
            Me.RadioButtonDE.Name = "RadioButtonDE"
            Me.RadioButtonDE.Size = New System.Drawing.Size(49, 17)
            Me.RadioButtonDE.TabIndex = 3
            Me.RadioButtonDE.Text = "Duits"
            Me.RadioButtonDE.UseVisualStyleBackColor = True
            '
            'RadioButtonEN
            '
            Me.RadioButtonEN.AutoSize = True
            Me.RadioButtonEN.Location = New System.Drawing.Point(7, 71)
            Me.RadioButtonEN.Name = "RadioButtonEN"
            Me.RadioButtonEN.Size = New System.Drawing.Size(57, 17)
            Me.RadioButtonEN.TabIndex = 2
            Me.RadioButtonEN.Text = "Engels"
            Me.RadioButtonEN.UseVisualStyleBackColor = True
            '
            'RadioButtonFR
            '
            Me.RadioButtonFR.AutoSize = True
            Me.RadioButtonFR.Location = New System.Drawing.Point(7, 48)
            Me.RadioButtonFR.Name = "RadioButtonFR"
            Me.RadioButtonFR.Size = New System.Drawing.Size(51, 17)
            Me.RadioButtonFR.TabIndex = 1
            Me.RadioButtonFR.Text = "Frans"
            Me.RadioButtonFR.UseVisualStyleBackColor = True
            '
            'RadioButtonNL
            '
            Me.RadioButtonNL.AutoSize = True
            Me.RadioButtonNL.Checked = True
            Me.RadioButtonNL.Location = New System.Drawing.Point(7, 25)
            Me.RadioButtonNL.Name = "RadioButtonNL"
            Me.RadioButtonNL.Size = New System.Drawing.Size(79, 17)
            Me.RadioButtonNL.TabIndex = 0
            Me.RadioButtonNL.TabStop = True
            Me.RadioButtonNL.Text = "Nederlands"
            Me.RadioButtonNL.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.RadioButtonInbr3)
            Me.GroupBox2.Controls.Add(Me.RadioButtonInbr2)
            Me.GroupBox2.Controls.Add(Me.RadioButtonInbr1)
            Me.GroupBox2.Location = New System.Drawing.Point(207, 12)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(189, 124)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Inbreuk"
            '
            'RadioButtonInbr3
            '
            Me.RadioButtonInbr3.AutoSize = True
            Me.RadioButtonInbr3.Location = New System.Drawing.Point(7, 71)
            Me.RadioButtonInbr3.Name = "RadioButtonInbr3"
            Me.RadioButtonInbr3.Size = New System.Drawing.Size(154, 17)
            Me.RadioButtonInbr3.TabIndex = 2
            Me.RadioButtonInbr3.Text = "3de inbreuk in 24 maanden"
            Me.RadioButtonInbr3.UseVisualStyleBackColor = True
            '
            'RadioButtonInbr2
            '
            Me.RadioButtonInbr2.AutoSize = True
            Me.RadioButtonInbr2.Location = New System.Drawing.Point(7, 48)
            Me.RadioButtonInbr2.Name = "RadioButtonInbr2"
            Me.RadioButtonInbr2.Size = New System.Drawing.Size(154, 17)
            Me.RadioButtonInbr2.TabIndex = 1
            Me.RadioButtonInbr2.Text = "2de inbreuk in 24 maanden"
            Me.RadioButtonInbr2.UseVisualStyleBackColor = True
            '
            'RadioButtonInbr1
            '
            Me.RadioButtonInbr1.AutoSize = True
            Me.RadioButtonInbr1.Checked = True
            Me.RadioButtonInbr1.Location = New System.Drawing.Point(7, 25)
            Me.RadioButtonInbr1.Name = "RadioButtonInbr1"
            Me.RadioButtonInbr1.Size = New System.Drawing.Size(83, 17)
            Me.RadioButtonInbr1.TabIndex = 0
            Me.RadioButtonInbr1.TabStop = True
            Me.RadioButtonInbr1.Text = "1ste inbreuk"
            Me.RadioButtonInbr1.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 159)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(86, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Naam chauffeur:"
            '
            'TextBoxDriverName
            '
            Me.TextBoxDriverName.Location = New System.Drawing.Point(110, 156)
            Me.TextBoxDriverName.Name = "TextBoxDriverName"
            Me.TextBoxDriverName.ReadOnly = True
            Me.TextBoxDriverName.Size = New System.Drawing.Size(286, 20)
            Me.TextBoxDriverName.TabIndex = 3
            Me.TextBoxDriverName.TabStop = False
            '
            'TextBoxNrPlate
            '
            Me.TextBoxNrPlate.Location = New System.Drawing.Point(110, 182)
            Me.TextBoxNrPlate.Name = "TextBoxNrPlate"
            Me.TextBoxNrPlate.ReadOnly = True
            Me.TextBoxNrPlate.Size = New System.Drawing.Size(111, 20)
            Me.TextBoxNrPlate.TabIndex = 5
            Me.TextBoxNrPlate.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 185)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Nummerplaat:"
            '
            'TextBoxSnelheid
            '
            Me.TextBoxSnelheid.Location = New System.Drawing.Point(111, 234)
            Me.TextBoxSnelheid.Name = "TextBoxSnelheid"
            Me.TextBoxSnelheid.ReadOnly = True
            Me.TextBoxSnelheid.Size = New System.Drawing.Size(73, 20)
            Me.TextBoxSnelheid.TabIndex = 9
            Me.TextBoxSnelheid.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 237)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(51, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Snelheid:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(190, 237)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(32, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "km/h"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(189, 263)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(32, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "km/h"
            '
            'TextBoxMaxSnelheid
            '
            Me.TextBoxMaxSnelheid.Location = New System.Drawing.Point(111, 260)
            Me.TextBoxMaxSnelheid.Name = "TextBoxMaxSnelheid"
            Me.TextBoxMaxSnelheid.ReadOnly = True
            Me.TextBoxMaxSnelheid.Size = New System.Drawing.Size(73, 20)
            Me.TextBoxMaxSnelheid.TabIndex = 12
            Me.TextBoxMaxSnelheid.TabStop = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(12, 265)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(64, 13)
            Me.Label6.TabIndex = 11
            Me.Label6.Text = "Toegelaten:"
            '
            'TextBoxVoertuig
            '
            Me.TextBoxVoertuig.Location = New System.Drawing.Point(110, 208)
            Me.TextBoxVoertuig.Name = "TextBoxVoertuig"
            Me.TextBoxVoertuig.ReadOnly = True
            Me.TextBoxVoertuig.Size = New System.Drawing.Size(111, 20)
            Me.TextBoxVoertuig.TabIndex = 7
            Me.TextBoxVoertuig.TabStop = False
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(9, 211)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Type voertuig:"
            '
            'TextBoxFirmName
            '
            Me.TextBoxFirmName.Location = New System.Drawing.Point(111, 308)
            Me.TextBoxFirmName.Name = "TextBoxFirmName"
            Me.TextBoxFirmName.ReadOnly = True
            Me.TextBoxFirmName.Size = New System.Drawing.Size(285, 20)
            Me.TextBoxFirmName.TabIndex = 15
            Me.TextBoxFirmName.TabStop = False
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(12, 311)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(63, 13)
            Me.Label8.TabIndex = 14
            Me.Label8.Text = "Naam firma:"
            '
            'TextBoxAddress
            '
            Me.TextBoxAddress.Location = New System.Drawing.Point(111, 334)
            Me.TextBoxAddress.Name = "TextBoxAddress"
            Me.TextBoxAddress.ReadOnly = True
            Me.TextBoxAddress.Size = New System.Drawing.Size(285, 20)
            Me.TextBoxAddress.TabIndex = 18
            Me.TextBoxAddress.TabStop = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(12, 337)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(62, 13)
            Me.Label9.TabIndex = 17
            Me.Label9.Text = "Adres firma:"
            '
            'TextBoxCity
            '
            Me.TextBoxCity.Location = New System.Drawing.Point(111, 360)
            Me.TextBoxCity.Name = "TextBoxCity"
            Me.TextBoxCity.ReadOnly = True
            Me.TextBoxCity.Size = New System.Drawing.Size(285, 20)
            Me.TextBoxCity.TabIndex = 20
            Me.TextBoxCity.TabStop = False
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(12, 363)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(84, 13)
            Me.Label10.TabIndex = 19
            Me.Label10.Text = "Gemeente firma:"
            '
            'ButtonCancel
            '
            Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonCancel.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
            Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonCancel.Location = New System.Drawing.Point(304, 401)
            Me.ButtonCancel.Name = "ButtonCancel"
            Me.ButtonCancel.Size = New System.Drawing.Size(80, 25)
            Me.ButtonCancel.TabIndex = 23
            Me.ButtonCancel.Text = "Annuleren"
            Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonCancel.UseVisualStyleBackColor = True
            '
            'ButtonZoekFirma
            '
            Me.ButtonZoekFirma.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.find
            Me.ButtonZoekFirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonZoekFirma.Location = New System.Drawing.Point(403, 306)
            Me.ButtonZoekFirma.Name = "ButtonZoekFirma"
            Me.ButtonZoekFirma.Size = New System.Drawing.Size(64, 23)
            Me.ButtonZoekFirma.TabIndex = 16
            Me.ButtonZoekFirma.Text = "Zoek"
            Me.ButtonZoekFirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonZoekFirma.UseVisualStyleBackColor = True
            '
            'ButtonOK
            '
            Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOK.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Print
            Me.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonOK.Location = New System.Drawing.Point(390, 401)
            Me.ButtonOK.Name = "ButtonOK"
            Me.ButtonOK.Size = New System.Drawing.Size(80, 25)
            Me.ButtonOK.TabIndex = 24
            Me.ButtonOK.Text = "OK"
            Me.ButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonOK.UseVisualStyleBackColor = True
            '
            'FormBewakingSnelheidPrintExt
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonCancel
            Me.ClientSize = New System.Drawing.Size(482, 438)
            Me.Controls.Add(Me.ButtonZoekFirma)
            Me.Controls.Add(Me.ButtonCancel)
            Me.Controls.Add(Me.ButtonOK)
            Me.Controls.Add(Me.TextBoxCity)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.TextBoxAddress)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.TextBoxFirmName)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.TextBoxVoertuig)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.TextBoxMaxSnelheid)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TextBoxSnelheid)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBoxNrPlate)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TextBoxDriverName)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "FormBewakingSnelheidPrintExt"
            Me.Text = "Afdrukken snelheidsovertreding contractanten/vrachtwagens"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButtonDE As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonEN As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonFR As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonNL As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButtonInbr3 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonInbr2 As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonInbr1 As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBoxDriverName As System.Windows.Forms.TextBox
        Friend WithEvents TextBoxNrPlate As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBoxSnelheid As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TextBoxMaxSnelheid As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TextBoxVoertuig As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents TextBoxFirmName As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TextBoxCity As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents ButtonOK As System.Windows.Forms.Button
        Friend WithEvents ButtonCancel As System.Windows.Forms.Button
        Friend WithEvents ButtonZoekFirma As System.Windows.Forms.Button
    End Class
End Namespace