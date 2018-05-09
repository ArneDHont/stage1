Option Explicit On
Option Strict On
Option Infer On

Imports Infragistics.Win.UltraWinGrid


Namespace Helpers

    Public Class TimeSpanAggregator
        Implements ICustomSummaryCalculator

        Private ReadOnly _column As String
        Private _total As TimeSpan

        ''' <summary>
        ''' Public constructor.
        ''' </summary>
        ''' <param name="columnName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal columnName As String)
            _column = columnName
        End Sub

        ''' <summary>
        ''' Initialize the aggregator - is called by the Infragistics grid.
        ''' </summary>
        ''' <param name="summarySettings"></param>
        ''' <param name="rows"></param>
        ''' <remarks></remarks>
        Public Sub BeginCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) Implements ICustomSummaryCalculator.BeginCustomSummary
            _total = New TimeSpan()
        End Sub

        ''' <summary>
        ''' Add a value to the aggregation - is called by the Infragistics grid.
        ''' </summary>
        ''' <param name="summarySettings"></param>
        ''' <param name="row"></param>
        ''' <remarks></remarks>
        Public Sub AggregateCustomSummary(ByVal summarySettings As SummarySettings, ByVal row As UltraGridRow) Implements ICustomSummaryCalculator.AggregateCustomSummary

            Dim valueIn = row.GetCellValue(_column)
            If IsDBNull(valueIn) Then Return

            Dim valueUit As TimeSpan
            If TimeSpan.TryParse(CStr(valueIn), valueUit) Then
                _total = _total.Add(valueUit)
            End If
        End Sub

        ''' <summary>
        ''' Fetch the aggregation result - is called by the Infragistics grid.
        ''' </summary>
        ''' <param name="summarySettings"></param>
        ''' <param name="rows"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function EndCustomSummary(ByVal summarySettings As SummarySettings, ByVal rows As RowsCollection) As Object Implements ICustomSummaryCalculator.EndCustomSummary
            Return _total.ToString("hh\:mm")
        End Function
    End Class

End Namespace
