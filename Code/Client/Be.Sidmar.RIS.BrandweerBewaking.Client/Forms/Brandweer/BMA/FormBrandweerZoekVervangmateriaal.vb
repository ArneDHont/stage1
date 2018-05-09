Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid


Namespace Forms.Brandweer

    Public Class FormBrandweerZoekVervangmateriaal

        ' TODO: deze constante hoort in de config file te staan...
        Private Const LocatieMagazijnBrandweer As String = "BRA"

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' On input, the material type for this search panel.  This value won't be changed.
        ''' </summary>
        Public Property MateriaalType As Integer

        ''' <summary>
        ''' On output, the sequence number of the material item that was selected.
        ''' </summary>
        Public Property MateriaalVolgNr As Integer

        ''' <summary>
        ''' Load event of the form.
        ''' </summary>
        ''' <param name="sender">Object that sends this event.</param>
        ''' <param name="e">Event arguments.</param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerZoekVervangmateriaalLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            Debug.Assert(MateriaalType > 0)

            _dataBrandweerMateriaal.Clear()
            _dataBrandweerMateriaal.Merge(_proxy.GetBrandweerVervangLijst(MateriaalType))

            Dim filter As ColumnFilter = UltraGridVervangLijst.Rows(0).Band.ColumnFilters("AfdelingCode")
            filter.FilterConditions.Add(FilterComparisionOperator.StartsWith, LocatieMagazijnBrandweer)
        End Sub

        ''' <summary>
        ''' Handler for the 'OK' button.
        ''' </summary>
        ''' <param name="sender">Object that sends this event.</param>
        ''' <param name="e">Event arguments.</param>
        ''' <remarks></remarks>
        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click

            Dim row As UltraGridRow = UltraGridVervangLijst.ActiveRow
            If row Is Nothing Then Return

            Dim selectie As String = CStr(row.GetCellValue("MateriaalVolgNr"))
            Dim nr As Integer

            If Integer.TryParse(selectie, nr) Then
                Debug.Assert(nr <> 0)

                MateriaalVolgNr = nr
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

        ''' <summary>
        ''' Handler for the 'CANCEL' button.
        ''' </summary>
        ''' <param name="sender">Object that sends this event.</param>
        ''' <param name="e">Event arguments.</param>
        ''' <remarks></remarks>
        Private Sub ButtonCancelClick(sender As Object, e As EventArgs) Handles ButtonCancel.Click
            MateriaalVolgNr = 0
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

    End Class
End Namespace