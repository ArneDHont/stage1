Namespace Forms.Brandweer
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBrandweerMateriaalWeging
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.TextBoxGewicht = New System.Windows.Forms.TextBox()
            Me.ButtonCancel = New System.Windows.Forms.Button()
            Me.ButtonOk = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me._dataBrandweerActie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerActie()
            Me.ComboBoxActie = New System.Windows.Forms.ComboBox()
            Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            CType(Me._dataBrandweerActie, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(78, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Datum Weging"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 65)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Gewicht"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker1.Location = New System.Drawing.Point(122, 9)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(144, 20)
            Me.DateTimePicker1.TabIndex = 1
            Me.DateTimePicker1.Value = New Date(2011, 9, 28, 0, 0, 0, 0)
            '
            'TextBoxGewicht
            '
            Me.TextBoxGewicht.Location = New System.Drawing.Point(122, 62)
            Me.TextBoxGewicht.Name = "TextBoxGewicht"
            Me.TextBoxGewicht.Size = New System.Drawing.Size(100, 20)
            Me.TextBoxGewicht.TabIndex = 5
            '
            'ButtonCancel
            '
            Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButtonCancel.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Cancel
            Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonCancel.Location = New System.Drawing.Point(186, 93)
            Me.ButtonCancel.Name = "ButtonCancel"
            Me.ButtonCancel.Size = New System.Drawing.Size(80, 23)
            Me.ButtonCancel.TabIndex = 8
            Me.ButtonCancel.Text = "Annuleren"
            Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonCancel.UseVisualStyleBackColor = True
            '
            'ButtonOk
            '
            Me.ButtonOk.Image = Global.Be.Sidmar.RIS.BrandweerBewaking.Client.Resources.Save
            Me.ButtonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonOk.Location = New System.Drawing.Point(100, 93)
            Me.ButtonOk.Name = "ButtonOk"
            Me.ButtonOk.Size = New System.Drawing.Size(80, 23)
            Me.ButtonOk.TabIndex = 7
            Me.ButtonOk.Text = "Opslaan"
            Me.ButtonOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ButtonOk.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(228, 65)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(22, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "kg."
            '
            '_dataBrandweerActie
            '
            Me._dataBrandweerActie.DataSetName = "TDSBrandweerActie"
            Me._dataBrandweerActie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ComboBoxActie
            '
            Me.ComboBoxActie.DataSource = Me.BindingSource1
            Me.ComboBoxActie.DisplayMember = "ActieOmschr"
            Me.ComboBoxActie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxActie.FormattingEnabled = True
            Me.ComboBoxActie.Location = New System.Drawing.Point(122, 35)
            Me.ComboBoxActie.Name = "ComboBoxActie"
            Me.ComboBoxActie.Size = New System.Drawing.Size(143, 21)
            Me.ComboBoxActie.TabIndex = 3
            Me.ComboBoxActie.ValueMember = "ActieCodeID"
            '
            'BindingSource1
            '
            Me.BindingSource1.DataMember = "Actie"
            Me.BindingSource1.DataSource = Me._dataBrandweerActie
            Me.BindingSource1.Sort = "ActieOmschr"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(13, 38)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Actie"
            '
            'FormBrandweerMateriaalWeging
            '
            Me.AcceptButton = Me.ButtonOk
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.ButtonCancel
            Me.ClientSize = New System.Drawing.Size(277, 128)
            Me.ControlBox = False
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ComboBoxActie)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.ButtonOk)
            Me.Controls.Add(Me.ButtonCancel)
            Me.Controls.Add(Me.TextBoxGewicht)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBrandweerMateriaalWeging"
            Me.ShowInTaskbar = False
            Me.Text = "Registratie Weging"
            CType(Me._dataBrandweerActie, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents TextBoxGewicht As System.Windows.Forms.TextBox
        Friend WithEvents ButtonCancel As System.Windows.Forms.Button
        Friend WithEvents ButtonOk As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents _dataBrandweerActie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSBrandweerActie
        Friend WithEvents ComboBoxActie As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    End Class
End Namespace