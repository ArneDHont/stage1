Option Explicit On
Option Strict On

Imports System.Runtime.CompilerServices


Namespace Helpers

    Friend Module Extensions

        ''' <summary>
        ''' Properly cases the words in a string, so that each word starts with a capital.
        ''' </summary>
        ''' <param name="s">The string.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <Extension()>
        Public Function ProperCase(ByVal s As String) As String
            Dim a As Char() = s.ToCharArray()
            Dim i As Integer = 0

            Do While i < a.Length

                If Char.IsLetter(a(i)) Then
                    a(i) = Char.ToUpper(a(i))
                    i += 1

                    Do While i < a.Length AndAlso Char.IsLetter(a(i))
                        a(i) = Char.ToLower(a(i))
                        i += 1
                    Loop
                End If

                i += 1
            Loop

            Return New String(a)
        End Function

    End Module

End Namespace