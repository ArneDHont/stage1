Public Class FormBrandweerDienstverslag
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents UltraLabelBrandweerDienstverslag As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UltraLabelBrandweerDienstverslag = New Infragistics.Win.Misc.UltraLabel()
        Me.SuspendLayout()
        '
        'UltraLabelBrandweerDienstverslag
        '
        Me.UltraLabelBrandweerDienstverslag.Location = New System.Drawing.Point(24, 16)
        Me.UltraLabelBrandweerDienstverslag.Name = "UltraLabelBrandweerDienstverslag"
        Me.UltraLabelBrandweerDienstverslag.Size = New System.Drawing.Size(160, 23)
        Me.UltraLabelBrandweerDienstverslag.TabIndex = 0
        Me.UltraLabelBrandweerDienstverslag.Text = "Dienstverslag Brandweer"
        '
        'FormBrandweerDienstverslag
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.UltraLabelBrandweerDienstverslag)
        Me.Name = "FormBrandweerDienstverslag"
        Me.ShowInTaskbar = False
        Me.Text = "Dienstverslag Brandweer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormBrandweerDienstverslag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
