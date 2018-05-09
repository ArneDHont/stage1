Option Explicit On
Option Strict On

Imports System.Windows.Forms

Namespace Forms.Brandweer

    Public Class FormBrandweerMateriaalVisueleEnPoederSelectie

        Public Property IsVisueleControle As Boolean
        Public Property DatumVorigeControle As DateTime

        Private Sub FormBrandweerMateriaalVisueleEnPoederSelectieLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            DateTimePickerVorigeNazicht.Value = DateTime.Now
        End Sub

        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click
            If RadioButtonVisueleControle.Checked OrElse RadioButtonPoederControle.Checked Then
                IsVisueleControle = RadioButtonVisueleControle.Checked
                DatumVorigeControle = DateTimePickerVorigeNazicht.Value
                DialogResult = DialogResult.OK
                Close()

            Else
                MessageBox.Show(Me, "Gelieve uw selectie te maken.", "Controlelijst", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub ButtonAnnuleerClick(sender As Object, e As EventArgs) Handles ButtonAnnuleer.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

    End Class

End Namespace