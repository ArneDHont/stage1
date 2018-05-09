Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid


Namespace Forms.Brandweer

    Public Class FormBrandweerAfdelingBeheerders

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' The department that needs editing.
        ''' </summary>
        Public Property AfdelingId As Integer
        Public Property Afdeling2 As Integer
        Public Property Afdeling3 As Integer

        ''' <summary>
        ''' The manager who was selected using this form.
        ''' </summary>
        Public Property SelectedManager As Integer

        ''' <summary>
        ''' Form load event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerAfdelingBeheerdersLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            ReadData()
        End Sub

        ''' <summary>
        ''' Selecteer de aangeklikte manager.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGrid1.DoubleClickRow

            UpdateBeheerder()
        End Sub

        ''' <summary>
        ''' Toevoegen van een nieuwe beheerder.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonNieuwClick(sender As Object, e As EventArgs) Handles ToolStripButtonNieuw.Click
            Using schermpje As New FormBrandweerAfdelingBeheerderNieuw
                If schermpje.ShowDialog(Me) = DialogResult.OK Then
                    _proxy.AddBeheerderAfdeling(AfdelingId, schermpje.Beheerder)
                    ReadData()
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Schrappen van een bestaande beheerder.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonDeleteClick(sender As Object, e As EventArgs) Handles ToolStripButtonDelete.Click

            Dim row As UltraGridRow = UltraGrid1.ActiveRow
            If row Is Nothing OrElse row.IsFilterRow Then Return

            If MessageBox.Show(Me, "De geselecteerde beheerder schrappen?", "Schrappen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                If Not _proxy.DeleteBeheerderAfdeling(CInt(row.GetCellValue("BeheerderAfdelingID"))) Then
                    MessageBox.Show(Me, "Dit record kan niet geschrapt worden. Wellicht wordt deze beheerder nog gebruikt.", "Schrappen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ReadData()
            End If
        End Sub

        ''' <summary>
        ''' Verlaat het scherm.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonExitClick(sender As Object, e As EventArgs) Handles ToolStripButtonExit.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Get the lsit of managers from the database.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ReadData()
            Using ds As Proxy.BBWService.Mgt.TDSBrandweerBeheerderAfdeling = _proxy.GetBeheerderAfdeling(AfdelingId, Afdeling2, Afdeling3)
                _dataBrandweerBeheerderAfdeling.Clear()
                _dataBrandweerBeheerderAfdeling.Merge(ds)
            End Using
        End Sub

        Public Sub UpdateBeheerder()
            Dim row As UltraGridRow = UltraGrid1.ActiveRow
            If row Is Nothing OrElse row.IsFilterRow Then Return

            SelectedManager = CInt(row.GetCellValue("BeheerderAfdelingID"))

            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub ToolStripButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonSave.Click
            UpdateBeheerder()
        End Sub

    End Class

End Namespace