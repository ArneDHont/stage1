Option Strict On
Option Explicit On

Imports System.Windows.Forms

Namespace Helpers

    Public Class WaitCursor
        Implements IDisposable

        Private Property TargetForm As Form
        Private Property OldCursor As Cursor

        Public Sub New(ByVal target As Form)
            TargetForm = target
            OldCursor = target.Cursor
            target.Cursor = Cursors.WaitCursor
        End Sub

        Public Sub New(ByVal target As Form, ByVal newCursor As Cursor)
            TargetForm = target
            OldCursor = target.Cursor
            target.Cursor = newCursor
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            TargetForm.Cursor = OldCursor
        End Sub

    End Class

End Namespace
