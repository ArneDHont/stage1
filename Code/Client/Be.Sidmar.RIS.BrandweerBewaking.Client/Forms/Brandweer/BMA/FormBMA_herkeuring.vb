Imports System.Windows.Forms

Public Class FormBMA_herkeuring

    Public Property DatumHerkeuring As DateTime

    Private Sub ButtonAnnuleer_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnnuleer.Click
        DialogResult = DialogResult.Cancel
        Close()

    End Sub

    Private Sub FormBMA_herkeuring_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DateTimePickerHerkeuring.Value = DateTime.Now
    End Sub


    Private Sub ButtonOk_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOk.Click
        'naco - 31/01/2017

        DatumHerkeuring = DateTimePickerHerkeuring.Value

        MessageBox.Show("Er zal een filter ingesteld worden op Datum volgende keuring <= " & Format(DatumHerkeuring, "dd/MM/yyyy") & "." & vbCrLf & vbCrLf &
                        "Filter op Type materiaal: brandblusapparaat" & vbCrLf &
                        "Filter op Soort materiaal: CO2", "Datum herkeuring", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class