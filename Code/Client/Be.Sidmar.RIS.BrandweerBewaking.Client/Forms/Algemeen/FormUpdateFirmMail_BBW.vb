Imports System.Windows.Forms

Public Class FormUpdateFirmMail_BBW

    Public Property pFirmId As Integer
    Public Property pFirmName As String

    Public Property pFirmEmail As String = ""
    Public Property pFirmRemark As String = ""
    Public Property pFirmLanguage As String = "NL"

    Public Property pCanceled As Boolean = True

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        'naco - 14/03/2017

        If TextBoxBBW_FirmEmail.Text.Trim = "" Then
            If TextBoxBBW_FirmRemark.Text.Trim = "" Then
                MessageBox.Show("Indien email leeg is, gelieve een opmerking in te vullen (bv. email niet gekend door chauffeur).", "Mail - opm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBoxBBW_FirmRemark.Focus()
            End If
        Else
            If TextBoxBBW_FirmEmail.Text.Contains("@") And TextBoxBBW_FirmEmail.Text.Contains(".") Then
                pFirmEmail = TextBoxBBW_FirmEmail.Text
                pFirmRemark = TextBoxBBW_FirmRemark.Text
                pFirmLanguage = ComboBoxLanguage.Text

                pCanceled = False
                Me.Close()
            Else
                MessageBox.Show("Gelieve een geldig email adres in te vullen aub (bevat @ en .).", "Geldig email-adres", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBoxBBW_FirmEmail.Focus()
            End If
        End If


    End Sub
    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click

    End Sub

    Private Sub FormUpdateFirmMail_BBW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LabelFirmNrName.Text = pFirmId.ToString & " - " & pFirmName
    End Sub
End Class