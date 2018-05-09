Option Explicit On
Option Strict On

Imports System.Windows.Forms


Namespace Forms.Brandweer

    Public Class FormBrandweerMateriaalWeging

        Public Property Datum As DateTime = DateTime.Today
        Public Property Actie As Integer?
        Public Property Gewicht As Decimal?

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        Private ReadOnly _decimalSeparator As String = My.Application.Culture.NumberFormat.CurrencyDecimalSeparator

        ''' <summary>
        ''' Load evet of the form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerMateriaalWegingLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim ds As Proxy.BBWService.Mgt.TDSBrandweerActie = _proxy.GetBrandweerActie()
            ds.Actie.AddActieRow(0, "<geen actie>")
            _dataBrandweerActie.Merge(ds)

            DateTimePicker1.Value = Datum
            ComboBoxActie.SelectedValue = If(Actie Is Nothing, 0, Actie)
            TextBoxGewicht.Text = If(Gewicht Is Nothing, "", String.Format("{0:F2}", Gewicht))
        End Sub

        ''' <summary>
        ''' Save the changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click

            ' Datum
            ' -----
            Datum = DateTimePicker1.Value

            ' Actie
            ' -----
            If CInt(ComboBoxActie.SelectedValue) = 0 Then
                Actie = Nothing
            Else
                Actie = CInt(ComboBoxActie.SelectedValue)
            End If

            ' Gewicht
            ' -------
            Dim g As Decimal
            If String.IsNullOrWhiteSpace(TextBoxGewicht.Text) Then
                Gewicht = Nothing
            ElseIf Decimal.TryParse(TextBoxGewicht.Text, g) Then
                Gewicht = g
            Else
                MessageBox.Show(Me, "Gelieve een geldig gewicht in te vullen!", "Foutieve invoer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ' That's all, Folks!
            ' ------------------
            If Actie.HasValue OrElse Gewicht.HasValue Then
                DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show(Me, "Gelieve een actie te selecteren of een gewicht in te vullen!", "Foutieve invoer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        ''' <summary>
        ''' Cancel the changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonCancelClick(sender As Object, e As EventArgs) Handles ButtonCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Make sure the user is typing a valid number for the weight field.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub TextBoxGewichtKeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxGewicht.KeyPress
            If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = _decimalSeparator Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

    End Class

End Namespace
