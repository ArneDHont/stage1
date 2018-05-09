Option Explicit On
Option Strict On


Namespace Forms

    Public Class FormDienstVerslagNieuw

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' The date for the edit operation.
        ''' </summary>
        Public Property Datum As DateTime = DateTime.Today

        ''' <summary>
        ''' The team for the edit operation.
        ''' </summary>
        ''' <value></value>
        Public Property PloegId As Integer

        ''' <summary>
        ''' The name of the team for the edit operation.
        ''' </summary>
        ''' <value></value>
        Public Property PloegNaam As String

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormDienstVerslagNieuwLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            Using dsIn As Proxy.BBWService.Mgt.TDSDienstVerslagDetailTeams = _proxy.DienstverslagGetTeams()
                _dataDienstVerslagDetailTeams.Clear()
                _dataDienstVerslagDetailTeams.Merge(dsIn)
            End Using

            DateTimePicker1.Value = Datum
        End Sub

        ''' <summary>
        ''' User clicked OK.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOk.Click

            Datum = DateTimePicker1.Value

            With DirectCast(DirectCast(ComboBoxPloeg.SelectedItem, DataRowView).Row, TDSDienstVerslagDetailTeams.TeamsRow)
                PloegId = .Id
                PloegNaam = .Naam
            End With
        End Sub

    End Class

End Namespace
