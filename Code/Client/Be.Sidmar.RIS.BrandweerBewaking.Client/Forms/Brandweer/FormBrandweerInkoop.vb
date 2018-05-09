Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection
Imports Infragistics.Win
Imports System.Reflection.MethodBase

Public Class FormBrandweerInkoop

    Private _myProxy As Proxy.BBWServiceManagementServicesProxy


    Private Sub FormBrandweerInkoop_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        _myProxy = New Proxy.BBWServiceManagementServicesProxy

        LoadInterventions()
    End Sub

    Private Sub ToolStripButtonOpenVerslag_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonOpenVerslag.Click
        OpenReportIntervention()
    End Sub

    Private Sub UltraGridInkoop_DoubleClickCell(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles UltraGridInkoop.DoubleClickCell
        OpenReportIntervention()
    End Sub

    Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click
        LoadInterventions()
    End Sub

    Private Sub OpenReportIntervention()
        Try
            If UltraGridInkoop.ActiveRow Is Nothing Then Return
            If Not UltraGridInkoop.ActiveRow.IsDataRow Then Return

            Dim interventieId As Int32 = Convert.ToInt32(UltraGridInkoop.ActiveRow.GetCellValue("ID_INTV_BRDW"))
            If interventieId <= 0 Then Return

            Dim RegistratieType As Int32 = Convert.ToInt32(UltraGridInkoop.ActiveRow.GetCellValue("ID_TY_INTV"))

            Cursor.Current = Cursors.WaitCursor

            FormManager.Current.OpenFormNieuweBrandweerInterventies(False, False, True, RegistratieType, "", interventieId)
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LoadInterventions()
        Try
            Cursor = Cursors.WaitCursor
            _dataBrandweerInkoop1.Clear()
            _dataBrandweerInkoop1.Merge(_myProxy.GetLijstInkoopBrandweerInterventies)
        Catch ex As Exception
            Cursor = Cursors.Default
            ExceptionManager.Publish(ex)
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                 "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                 "Message: " & ex.Message & vbCrLf & _
                 "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Cursor = Cursors.Default
    End Sub


    Private Sub ToolStripButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonCopy.Click
        Try
            Cursor = Cursors.WaitCursor

            UltraGridInkoop.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
            UltraGridInkoop.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

            For Each row As UltraWinGrid.UltraGridRow In UltraGridInkoop.Rows
                row.Selected = True
            Next row

            UltraGridInkoop.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

            UltraGridInkoop.Selected.Rows.Clear()
            UltraGridInkoop.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
            UltraGridInkoop.ActiveRow = UltraGridInkoop.ActiveRowScrollRegion.FirstRow

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
End Class