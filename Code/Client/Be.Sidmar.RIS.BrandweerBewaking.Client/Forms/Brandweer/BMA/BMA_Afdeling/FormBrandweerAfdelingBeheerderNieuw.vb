Option Explicit On
Option Strict On

Imports System.Windows.Forms


Namespace Forms.Brandweer

    Public Class FormBrandweerAfdelingBeheerderNieuw

        Public Property Beheerder As String

        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click

            Dim s As String = TextBoxBeheerder.Text
            If Not String.IsNullOrWhiteSpace(s) Then
                Beheerder = s
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

    End Class

End Namespace