Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDienstVerslagNieuw
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.ComboBoxPloeg = New System.Windows.Forms.ComboBox()
            Me.ButtonOk = New System.Windows.Forms.Button()
            Me.ButtonCancel = New System.Windows.Forms.Button()
            Me._dataDienstVerslagDetailTeams = New Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailTeams()
            CType(Me._dataDienstVerslagDetailTeams, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(38, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Datum"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 35)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Ploeg"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Location = New System.Drawing.Point(56, 5)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
            Me.DateTimePicker1.TabIndex = 1
            '
            'ComboBoxPloeg
            '
            Me.ComboBoxPloeg.DataSource = Me._dataDienstVerslagDetailTeams
            Me.ComboBoxPloeg.DisplayMember = "Teams.Naam"
            Me.ComboBoxPloeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxPloeg.FormattingEnabled = True
            Me.ComboBoxPloeg.Location = New System.Drawing.Point(56, 32)
            Me.ComboBoxPloeg.Name = "ComboBoxPloeg"
            Me.ComboBoxPloeg.Size = New System.Drawing.Size(121, 21)
            Me.ComboBoxPloeg.TabIndex = 3
            Me.ComboBoxPloeg.ValueMember = "Teams.Id"
            '
            'ButtonOk
            '
            Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.ButtonOk.Location = New System.Drawing.Point(102, 66)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
            Me.ButtonOk.TabIndex = 4
            Me.ButtonOk.Text = "Aanmaken"
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'ButtonCancel
            '
            Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonCancel.Location = New System.Drawing.Point(188, 66)
            Me.ButtonCancel.Name = "ButtonCancel"
            Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
            Me.ButtonCancel.TabIndex = 5
            Me.ButtonCancel.Text = "Cancel"
            Me.ButtonCancel.UseVisualStyleBackColor = True
            '
            '_dataDienstVerslagDetailTeams
            '
            Me._dataDienstVerslagDetailTeams.DataSetName = "TDSDienstVerslagDetailTeams"
            Me._dataDienstVerslagDetailTeams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'FormDienstVerslagNieuw
            '
            Me.AcceptButton = Me.ButtonOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonCancel
            Me.ClientSize = New System.Drawing.Size(275, 101)
            Me.Controls.Add(Me.ButtonCancel)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.ComboBoxPloeg)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Name = "FormDienstVerslagNieuw"
            Me.Text = "Nieuw Dienstverslag"
            CType(Me._dataDienstVerslagDetailTeams, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents ComboBoxPloeg As System.Windows.Forms.ComboBox
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
        Friend WithEvents ButtonCancel As System.Windows.Forms.Button
        Friend WithEvents _dataDienstVerslagDetailTeams As Be.Sidmar.RIS.BrandweerBewaking.Client2.TDSDienstVerslagDetailTeams
    End Class
End Namespace