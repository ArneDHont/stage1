<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBMA_herkeuring
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
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonAnnuleer = New System.Windows.Forms.Button()
        Me.DateTimePickerHerkeuring = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(108, 59)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 7
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonAnnuleer
        '
        Me.ButtonAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAnnuleer.Location = New System.Drawing.Point(189, 59)
        Me.ButtonAnnuleer.Name = "ButtonAnnuleer"
        Me.ButtonAnnuleer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnuleer.TabIndex = 8
        Me.ButtonAnnuleer.Text = "Annuleer"
        Me.ButtonAnnuleer.UseVisualStyleBackColor = True
        '
        'DateTimePickerHerkeuring
        '
        Me.DateTimePickerHerkeuring.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHerkeuring.Location = New System.Drawing.Point(135, 21)
        Me.DateTimePickerHerkeuring.Name = "DateTimePickerHerkeuring"
        Me.DateTimePickerHerkeuring.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePickerHerkeuring.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Datum ""herkeuring"" <="
        '
        'FormBMA_herkeuring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 94)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.ButtonAnnuleer)
        Me.Controls.Add(Me.DateTimePickerHerkeuring)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBMA_herkeuring"
        Me.Text = "Herkeuring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonAnnuleer As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerHerkeuring As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
