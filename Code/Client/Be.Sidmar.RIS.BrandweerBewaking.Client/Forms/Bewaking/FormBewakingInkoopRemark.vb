Option Explicit On
Option Strict On

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormBewakingInkoopRemark

    ''' <summary>
    ''' De ID van de registratie.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RegistratieId As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 05/12/2012</remarks>
    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        Try
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            proxy.UpdateIKPOpmerking(TextBoxRemark.Text, RegistratieId)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingInkoopRemark - ButtonSave_Click: " & ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub
End Class