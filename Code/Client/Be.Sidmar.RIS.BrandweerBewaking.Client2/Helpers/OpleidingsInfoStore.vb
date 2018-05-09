Option Explicit On
Option Strict On
Option Infer On


Namespace Helpers

    Public Class InfoStore(Of T)

        Private ReadOnly _store As New Dictionary(Of Integer, Dictionary(Of Integer, T))

        ''' <summary>
        ''' Retrieve a value.
        ''' </summary>
        ''' <param name="index1">The first index.</param>
        ''' <param name="index2">The second index.</param>
        ''' <returns>The value.</returns>
        ''' <remarks></remarks>
        Public Function GetValue(ByVal index1 As Integer, ByVal index2 As Integer) As T

            Dim subStore = GetSubStore(index1)

            If subStore.ContainsKey(index2) Then
                Return subStore(index2)
            End If

            Return Nothing
        End Function

        ''' <summary>
        ''' Store a value.
        ''' </summary>
        ''' <param name="index1">The first index.</param>
        ''' <param name="index2">The second index.</param>
        ''' <param name="value">The value.</param>
        ''' <remarks></remarks>
        Public Sub SetValue(ByVal index1 As Integer, ByVal index2 As Integer, ByVal value As T)

            Dim subStore = GetSubStore(index1)

            If value.Equals(Nothing) Then
                subStore.Remove(index2)
            Else
                subStore(index2) = value
            End If
        End Sub

        ''' <summary>
        ''' Private function to handle the first level indexing.
        ''' </summary>
        ''' <param name="index"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetSubStore(ByVal index As Integer) As Dictionary(Of Integer, T)

            If _store.ContainsKey(index) Then
                Return _store(index)
            End If

            Dim subStore = New Dictionary(Of Integer, T)()
            _store(index) = subStore
            Return subStore
        End Function

    End Class

End Namespace
