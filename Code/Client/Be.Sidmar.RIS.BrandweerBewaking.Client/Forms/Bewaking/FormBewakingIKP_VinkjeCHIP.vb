Option Explicit On
Option Strict On

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection
Imports Infragistics.Win
Imports System.Reflection.MethodBase

Public Class FormBewakingIKP_VinkjeCHIP

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 06/07/2015</remarks>
    Private Sub ButtonShow_Click(sender As System.Object, e As System.EventArgs) Handles ButtonShow.Click
        Try
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy
            Dim strDate As String = DateTimePickerIKP.Value.Year & "-" & DateTimePickerIKP.Value.Month & "-" & DateTimePickerIKP.Value.Day

            _dataInkoopFirmaCHIP.Clear()
            _dataInkoopFirmaCHIP.Merge(proxy.GetLijstInkoopFirmaVinkjeCHIP(strDate))

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingIKP_VinkjeCHIP (Load) " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click
        Try
            '06/07/2015 - naco
            Cursor = Cursors.WaitCursor

            UltraGridIKP_firma.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
            UltraGridIKP_firma.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

            For Each row As UltraWinGrid.UltraGridRow In UltraGridIKP_firma.Rows
                row.Selected = True
            Next row

            UltraGridIKP_firma.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

            UltraGridIKP_firma.Selected.Rows.Clear()
            UltraGridIKP_firma.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
            UltraGridIKP_firma.ActiveRow = UltraGridIKP_firma.ActiveRowScrollRegion.FirstRow

            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                "Message: " & ex.Message & vbCrLf & _
                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FormBewakingIKP_VinkjeCHIP_Invalidated(sender As Object, e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        DateTimePickerIKP.Value = New DateTime(Now.Year, 1, 1)
    End Sub
End Class