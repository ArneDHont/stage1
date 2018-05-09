Option Explicit On
Option Strict On
Option Infer On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers
Imports Infragistics.Win

Namespace Forms

    Public Class FormDienstverslagKiesMedewerker

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' Incoming: the list of ID's that should be excluded from the list.
        ''' </summary>
        Public Property ExcludeIds As IEnumerable(Of Integer)

        ''' <summary>
        ''' Outgoing: The ID of the selected co-worker.
        ''' </summary>
        Public Property SelectedId As Integer

        ''' <summary>
        ''' Outgoing: The name of the selected co-worker.
        ''' </summary>
        Public Property SelectedName As String

        ''' <summary>
        ''' Outgoing: The given name of the selected co-worker.
        ''' </summary>
        Public Property SelectedFirstname As String

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormDienstverslagKiesMedewerkerLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            UltraGrid1.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.false

            Dim filter = New HashSet(Of Integer)(ExcludeIds)

            Using dsIn = _proxy.DienstVerslagGetTeamMembers(-1)
                _dataDienstVerslagDetailTeamMembers.Clear()

                For Each row As Proxy.BBWService.Mgt.TDSDienstVerslagDetailTeamMembers.TeamMembersRow In dsIn.TeamMembers
                    If Not filter.Contains(row.ID_IND) Then
                        _dataDienstVerslagDetailTeamMembers.TeamMembers.AddTeamMembersRow(row.SCF_PLG_IND, row.ID_IND, row.NM_IND.Trim.ProperCase, row.VNM_IND.Trim.ProperCase)
                    End If
                Next
            End Using
        End Sub

        ''' <summary>
        ''' A selection was made.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click, UltraGrid1.DoubleClickCell

            Dim row = UltraGrid1.ActiveRow
            If row Is Nothing OrElse row.IsFilterRow Then Return

            SelectedId = CInt(row.GetCellValue("ID_IND"))
            SelectedName = CStr(row.GetCellValue("NM_IND"))
            SelectedFirstname = CStr(row.GetCellValue("VNM_IND"))

            DialogResult = DialogResult.OK
            Close()
        End Sub

    End Class

End Namespace
