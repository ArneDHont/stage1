Imports System.Windows.Forms

Public Class FormBrandweerMateriaalLogin

    Public Property pUserOK As String = "NOK"
    Public Property pUserLogin As String = "-"

    Private Sub ButtonOk_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOk.Click
        'naco - 09/02/2017

        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
        Dim strP As String

        If TextBoxUsername.Text.Trim = "" Or TextBoxPassword.Text.Trim = "" Then
            MessageBox.Show("Gelieve user en paswoord in te vullen aub.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxUsername.Focus()

            Exit Sub
        End If

        strP = proxy.GetUserBrandweer(TextBoxUsername.Text)

        If strP = "UNKNOWN" Then
            MessageBox.Show("User niet gekend: " & TextBoxUsername.Text & "." & vbCrLf & vbCrLf & "Gelieve rechten aan te vragen bij de postoverste van de brandweer.", "User niet gekend", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If strP <> TextBoxPassword.Text Then
                MessageBox.Show("Foutief paswoord. Gelieve aan de postoverste van de brandweer het paswoord na te vragen.", "Paswoord", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                pUserOK = "OK"
                pUserLogin = TextBoxUsername.Text.ToUpper
                Me.Close()
            End If
        End If

    End Sub

    Private Sub ButtonAnnuleer_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnnuleer.Click
        Me.Close()
    End Sub

    Private Sub FormBrandweerMateriaalLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class