<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBewakingRijverbodParameters
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
        Me.UltraDateAfspraakPBH = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateRijverbodVan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraDateRijverbodTot = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.LabelAfspraak = New System.Windows.Forms.Label()
        Me.LabelRijverbodVan = New System.Windows.Forms.Label()
        Me.LabelRijverbodTot = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDatesEmpty = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDates = New System.Windows.Forms.RadioButton()
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraDateAfspraakPBH
        '
        Me.UltraDateAfspraakPBH.Enabled = False
        Me.UltraDateAfspraakPBH.Location = New System.Drawing.Point(245, 56)
        Me.UltraDateAfspraakPBH.Name = "UltraDateAfspraakPBH"
        Me.UltraDateAfspraakPBH.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateAfspraakPBH.TabIndex = 0
        '
        'UltraDateRijverbodVan
        '
        Me.UltraDateRijverbodVan.Enabled = False
        Me.UltraDateRijverbodVan.Location = New System.Drawing.Point(245, 82)
        Me.UltraDateRijverbodVan.Name = "UltraDateRijverbodVan"
        Me.UltraDateRijverbodVan.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodVan.TabIndex = 1
        '
        'UltraDateRijverbodTot
        '
        Me.UltraDateRijverbodTot.Enabled = False
        Me.UltraDateRijverbodTot.Location = New System.Drawing.Point(245, 109)
        Me.UltraDateRijverbodTot.Name = "UltraDateRijverbodTot"
        Me.UltraDateRijverbodTot.Size = New System.Drawing.Size(92, 21)
        Me.UltraDateRijverbodTot.TabIndex = 2
        '
        'LabelAfspraak
        '
        Me.LabelAfspraak.AutoSize = True
        Me.LabelAfspraak.Location = New System.Drawing.Point(80, 60)
        Me.LabelAfspraak.Name = "LabelAfspraak"
        Me.LabelAfspraak.Size = New System.Drawing.Size(160, 13)
        Me.LabelAfspraak.TabIndex = 3
        Me.LabelAfspraak.Text = "Afspraak met Personeelsbeheer:"
        '
        'LabelRijverbodVan
        '
        Me.LabelRijverbodVan.AutoSize = True
        Me.LabelRijverbodVan.Location = New System.Drawing.Point(80, 86)
        Me.LabelRijverbodVan.Name = "LabelRijverbodVan"
        Me.LabelRijverbodVan.Size = New System.Drawing.Size(116, 13)
        Me.LabelRijverbodVan.TabIndex = 4
        Me.LabelRijverbodVan.Text = "Rijverbod geldig vanaf:"
        '
        'LabelRijverbodTot
        '
        Me.LabelRijverbodTot.AutoSize = True
        Me.LabelRijverbodTot.Location = New System.Drawing.Point(80, 113)
        Me.LabelRijverbodTot.Name = "LabelRijverbodTot"
        Me.LabelRijverbodTot.Size = New System.Drawing.Size(101, 13)
        Me.LabelRijverbodTot.TabIndex = 5
        Me.LabelRijverbodTot.Text = "Rijverbod geldig tot:"
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(205, 153)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 6
        Me.ButtonOk.Text = "&OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(286, 153)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 7
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDates)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDatesEmpty)
        Me.GroupBox1.Controls.Add(Me.UltraDateAfspraakPBH)
        Me.GroupBox1.Controls.Add(Me.LabelRijverbodTot)
        Me.GroupBox1.Controls.Add(Me.UltraDateRijverbodVan)
        Me.GroupBox1.Controls.Add(Me.LabelRijverbodVan)
        Me.GroupBox1.Controls.Add(Me.UltraDateRijverbodTot)
        Me.GroupBox1.Controls.Add(Me.LabelAfspraak)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 139)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Afdruk datums"
        '
        'RadioButtonDatesEmpty
        '
        Me.RadioButtonDatesEmpty.AutoSize = True
        Me.RadioButtonDatesEmpty.Checked = True
        Me.RadioButtonDatesEmpty.Location = New System.Drawing.Point(17, 19)
        Me.RadioButtonDatesEmpty.Name = "RadioButtonDatesEmpty"
        Me.RadioButtonDatesEmpty.Size = New System.Drawing.Size(143, 17)
        Me.RadioButtonDatesEmpty.TabIndex = 0
        Me.RadioButtonDatesEmpty.TabStop = True
        Me.RadioButtonDatesEmpty.Text = "Rapport met lege datums"
        Me.RadioButtonDatesEmpty.UseVisualStyleBackColor = True
        '
        'RadioButtonDates
        '
        Me.RadioButtonDates.AutoSize = True
        Me.RadioButtonDates.Location = New System.Drawing.Point(17, 39)
        Me.RadioButtonDates.Name = "RadioButtonDates"
        Me.RadioButtonDates.Size = New System.Drawing.Size(120, 17)
        Me.RadioButtonDates.TabIndex = 1
        Me.RadioButtonDates.Text = "Rapport met datums"
        Me.RadioButtonDates.UseVisualStyleBackColor = True
        '
        'FormBewakingRijverbodParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(372, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.MaximumSize = New System.Drawing.Size(450, 220)
        Me.MinimumSize = New System.Drawing.Size(380, 175)
        Me.Name = "FormBewakingRijverbodParameters"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rijverbod Parameters"
        CType(Me.UltraDateAfspraakPBH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateRijverbodTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraDateAfspraakPBH As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateRijverbodVan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateRijverbodTot As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents LabelAfspraak As System.Windows.Forms.Label
    Friend WithEvents LabelRijverbodVan As System.Windows.Forms.Label
    Friend WithEvents LabelRijverbodTot As System.Windows.Forms.Label
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDates As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDatesEmpty As System.Windows.Forms.RadioButton
End Class
