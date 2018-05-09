Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerAfdelingBeheerderNieuw
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBoxBeheerder = New System.Windows.Forms.TextBox()
            Me.ButtonOk = New System.Windows.Forms.Button()
            Me.ButtonVerlaat = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Naam"
            '
            'TextBoxBeheerder
            '
            Me.TextBoxBeheerder.Location = New System.Drawing.Point(89, 13)
            Me.TextBoxBeheerder.Name = "TextBoxBeheerder"
            Me.TextBoxBeheerder.Size = New System.Drawing.Size(120, 20)
            Me.TextBoxBeheerder.TabIndex = 1
            '
            'ButtonOk
            '
            Me.ButtonOk.Location = New System.Drawing.Point(255, 13)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.ButtonOk.TabIndex = 2
            Me.ButtonOk.Text = "Opslaan"
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'ButtonVerlaat
            '
            Me.ButtonVerlaat.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonVerlaat.Location = New System.Drawing.Point(255, 43)
            Me.ButtonVerlaat.Name = "ButtonVerlaat"
            Me.ButtonVerlaat.Size = New System.Drawing.Size(75, 23)
            Me.ButtonVerlaat.TabIndex = 3
            Me.ButtonVerlaat.Text = "Verlaat"
            Me.ButtonVerlaat.UseVisualStyleBackColor = True
            '
            'FormBrandweerAfdelingBeheerderNieuw
            '
            Me.AcceptButton = Me.ButtonOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonVerlaat
            Me.ClientSize = New System.Drawing.Size(342, 79)
            Me.Controls.Add(Me.ButtonVerlaat)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.TextBoxBeheerder)
            Me.Controls.Add(Me.Label1)
            Me.Name = "FormBrandweerAfdelingBeheerderNieuw"
            Me.Text = "Nieuwe Beheerder"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBoxBeheerder As System.Windows.Forms.TextBox
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
        Friend WithEvents ButtonVerlaat As System.Windows.Forms.Button
    End Class
End Namespace