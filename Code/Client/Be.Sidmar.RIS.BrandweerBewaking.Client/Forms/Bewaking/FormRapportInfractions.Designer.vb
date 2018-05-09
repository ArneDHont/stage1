<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRapportInfractions
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
        Me.ReportViewerInfractions = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerInfractions
        '
        Me.ReportViewerInfractions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerInfractions.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerInfractions.Name = "ReportViewerInfractions"
        Me.ReportViewerInfractions.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewerInfractions.ShowCredentialPrompts = False
        Me.ReportViewerInfractions.ShowParameterPrompts = False
        Me.ReportViewerInfractions.Size = New System.Drawing.Size(570, 421)
        Me.ReportViewerInfractions.TabIndex = 0
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormRapportInfractions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 421)
        Me.Controls.Add(Me.ReportViewerInfractions)
        Me.Name = "FormRapportInfractions"
        Me.Text = "Rapport Inbreuken"
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerInfractions As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
End Class
