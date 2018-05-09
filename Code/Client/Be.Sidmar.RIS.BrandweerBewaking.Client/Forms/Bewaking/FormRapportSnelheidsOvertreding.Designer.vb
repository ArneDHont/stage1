<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRapportSnelheidsOvertreding
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
        Me.ReportViewerSnelheidsOvertredingen = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._dataConfiguratie = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie()
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerSnelheidsOvertredingen
        '
        Me.ReportViewerSnelheidsOvertredingen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerSnelheidsOvertredingen.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerSnelheidsOvertredingen.Name = "ReportViewerSnelheidsOvertredingen"
        Me.ReportViewerSnelheidsOvertredingen.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewerSnelheidsOvertredingen.ServerReport.ReportPath = "/GENT/PLANT/PEB/BBW/SnelheidsOvertreding"
        Me.ReportViewerSnelheidsOvertredingen.ServerReport.ReportServerUrl = New System.Uri("reporting-dvlp2.sidmar.be/ReportServer", System.UriKind.Relative)
        Me.ReportViewerSnelheidsOvertredingen.Size = New System.Drawing.Size(567, 748)
        Me.ReportViewerSnelheidsOvertredingen.TabIndex = 0
        '
        '_dataConfiguratie
        '
        Me._dataConfiguratie.DataSetName = "TDSConfiguratie"
        Me._dataConfiguratie.Locale = New System.Globalization.CultureInfo("en-US")
        Me._dataConfiguratie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormRapportSnelheidsOvertreding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 748)
        Me.Controls.Add(Me.ReportViewerSnelheidsOvertredingen)
        Me.Name = "FormRapportSnelheidsOvertreding"
        Me.Text = "Rapport Snelheidsovertreding"
        CType(Me._dataConfiguratie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerSnelheidsOvertredingen As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents _dataConfiguratie As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSConfiguratie
End Class
