Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection.MethodBase

Public Class FormBewakingAddRemarks

    Private _regId As Integer
    Private _myProxy As BBWServiceManagementServicesProxy

    Public Sub New(ByVal aRegId As Integer, ByVal aRemark As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _regId = aRegId
        TextBoxRemark.Text = aRemark.ToString()
        _myProxy = New BBWServiceManagementServicesProxy
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        Try
            Cursor = Cursors.WaitCursor
            _myProxy.InsertRemark(_regId, TextBoxRemark.Text.Replace("'", "''"))
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
End Class