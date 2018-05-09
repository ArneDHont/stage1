Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection.MethodBase

Public Class FormBewakingOngeldigVerslag

    Private ReadOnly _regId As Integer
    Private ReadOnly _typeOfRegistration As String
    Private ReadOnly _registrationSequenceId As Integer
    Private ReadOnly _myProxy As BBWServiceManagementServicesProxy

    Public Sub New(ByVal regId As Integer, ByVal typeOfRegistration As String, ByVal registrationSequenceId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _regId = regId
        _typeOfRegistration = typeOfRegistration
        _registrationSequenceId = registrationSequenceId
        _myProxy = New BBWServiceManagementServicesProxy

        Text = String.Format("{0} {1} - {2}", Text, _registrationSequenceId, _typeOfRegistration)
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub ButtonOK_Click(sender As System.Object, e As EventArgs) Handles ButtonOK.Click
        Try
            Cursor = Cursors.WaitCursor
            _myProxy.InvalidateReport(_regId, TextBoxRemark.Text, Environment.UserName)
            DialogResult = DialogResult.OK
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class