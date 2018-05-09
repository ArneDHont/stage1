Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Forms
Imports System.Windows.Forms


Public Class FormManager
    Inherits ADF.Presentation.Windows.Forms.FormManagerBase

#Region "Singleton Implementation"

    Private Shared _current As FormManager

    Private Sub New(ByVal parent As Form)
        MyBase.New(parent)
        Debug.Assert(parent IsNot Nothing)
    End Sub

    Public Shared ReadOnly Property Current() As FormManager
        Get
            Debug.Assert(_current IsNot Nothing)
            Return _current
        End Get
    End Property

    Public Shared Sub Create(ByVal parent As Form)
        If _current Is Nothing Then _current = New FormManager(parent)
    End Sub

#End Region

    Public Sub OpenFormDienstverslagOverzicht(ByVal modal As Boolean, ByVal asSingleton As Boolean, ByVal asMDIChild As Boolean)
        OpenChildForm(GetType(FormDienstverslagOverzicht), modal, asSingleton, asMDIChild)
    End Sub

End Class
