Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaalVisueleEnPoederSelectie
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.RadioButtonPoederControle = New System.Windows.Forms.RadioButton()
            Me.RadioButtonVisueleControle = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DateTimePickerVorigeNazicht = New System.Windows.Forms.DateTimePicker()
            Me.ButtonAnnuleer = New System.Windows.Forms.Button()
            Me.ButtonOk = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.RadioButtonPoederControle)
            Me.GroupBox1.Controls.Add(Me.RadioButtonVisueleControle)
            Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(279, 79)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Soort"
            '
            'RadioButtonPoederControle
            '
            Me.RadioButtonPoederControle.AutoSize = True
            Me.RadioButtonPoederControle.Location = New System.Drawing.Point(7, 44)
            Me.RadioButtonPoederControle.Name = "RadioButtonPoederControle"
            Me.RadioButtonPoederControle.Size = New System.Drawing.Size(147, 17)
            Me.RadioButtonPoederControle.TabIndex = 1
            Me.RadioButtonPoederControle.TabStop = True
            Me.RadioButtonPoederControle.Text = "Poeder / Schuim Controle"
            Me.RadioButtonPoederControle.UseVisualStyleBackColor = True
            '
            'RadioButtonVisueleControle
            '
            Me.RadioButtonVisueleControle.AutoSize = True
            Me.RadioButtonVisueleControle.Location = New System.Drawing.Point(7, 20)
            Me.RadioButtonVisueleControle.Name = "RadioButtonVisueleControle"
            Me.RadioButtonVisueleControle.Size = New System.Drawing.Size(101, 17)
            Me.RadioButtonVisueleControle.TabIndex = 0
            Me.RadioButtonVisueleControle.TabStop = True
            Me.RadioButtonVisueleControle.Text = "Visuele Controle"
            Me.RadioButtonVisueleControle.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 103)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(147, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Datum ""volgende nazicht"" <="
            '
            'DateTimePickerVorigeNazicht
            '
            Me.DateTimePickerVorigeNazicht.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePickerVorigeNazicht.Location = New System.Drawing.Point(163, 98)
            Me.DateTimePickerVorigeNazicht.Name = "DateTimePickerVorigeNazicht"
            Me.DateTimePickerVorigeNazicht.Size = New System.Drawing.Size(129, 20)
            Me.DateTimePickerVorigeNazicht.TabIndex = 2
            '
            'ButtonAnnuleer
            '
            Me.ButtonAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonAnnuleer.Location = New System.Drawing.Point(217, 132)
            Me.ButtonAnnuleer.Name = "ButtonAnnuleer"
            Me.ButtonAnnuleer.Size = New System.Drawing.Size(75, 23)
            Me.ButtonAnnuleer.TabIndex = 4
            Me.ButtonAnnuleer.Text = "Annuleer"
            Me.ButtonAnnuleer.UseVisualStyleBackColor = True
            '
            'ButtonOk
            '
            Me.ButtonOk.Location = New System.Drawing.Point(136, 132)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.ButtonOk.TabIndex = 3
            Me.ButtonOk.Text = "OK"
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'ToolTip1
            '
            Me.ToolTip1.ToolTipTitle = "Poeder: controle + 2 jaar / Schuim: controle + 6 jaar"
            '
            'FormBrandweerMateriaalVisueleEnPoederSelectie
            '
            Me.AcceptButton = Me.ButtonOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonAnnuleer
            Me.ClientSize = New System.Drawing.Size(304, 167)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.ButtonAnnuleer)
            Me.Controls.Add(Me.DateTimePickerVorigeNazicht)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBrandweerMateriaalVisueleEnPoederSelectie"
            Me.ShowInTaskbar = False
            Me.Text = "Controlelijst"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents RadioButtonPoederControle As System.Windows.Forms.RadioButton
        Friend WithEvents RadioButtonVisueleControle As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateTimePickerVorigeNazicht As System.Windows.Forms.DateTimePicker
        Friend WithEvents ButtonAnnuleer As System.Windows.Forms.Button
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    End Class
End Namespace