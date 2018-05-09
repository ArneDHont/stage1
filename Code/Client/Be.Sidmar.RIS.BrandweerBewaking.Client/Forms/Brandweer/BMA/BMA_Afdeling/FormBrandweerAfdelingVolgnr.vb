Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid

Public Class FormBrandweerAfdelingVolgnr
    Public Property SelectedMatDepartmentNr As Integer

    Private Sub TextBoxVolgnrAfd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxVolgnrAfd.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FormBrandweerAfdelingVolgnr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBoxVolgnrAfd.Text = SelectedMatDepartmentNr.ToString

    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        'naco - 10/07/2017

        If TextBoxVolgnrAfd.Text = "" Then 'naco - 10/07/2017 - vergeten overzetten van VB6 - VB.net
            'als je bestaand volgnr wil leegmaken => 0 meegeven
            SelectedMatDepartmentNr = 0
        Else
            SelectedMatDepartmentNr = CInt(TextBoxVolgnrAfd.Text)
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub


End Class