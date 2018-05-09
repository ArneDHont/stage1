Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy

Public Enum Sanctions_InbreukKlasse
    Speeding
    ClassOne
    ClassTwo
    InvalidClass
End Enum



Public Class SanctionHelper

    Private _currentInfraction As Sanctions_InbreukKlasse
    Private _recidive As Integer
    Private _myProxy As BBWServiceManagementServicesProxy

    Public Property DoubleUpLastSanction() As Boolean
    Public Sub New(ByVal pInbreukklasse As String,
                   ByVal pRecidive As Integer)
        StringToEnumSanctions_InbreukKlasse(pInbreukklasse)
        _recidive = pRecidive
        _myProxy = New BBWServiceManagementServicesProxy

        DoubleUpLastSanction = False
    End Sub

    Public Function StringToEnumSanctions_InbreukKlasse(ByVal pInbreukKlasse As String) As Sanctions_InbreukKlasse
        Select Case True
            Case pInbreukKlasse.ToLower.Trim().Equals("klasse 1")
                _currentInfraction = Sanctions_InbreukKlasse.ClassOne
            Case pInbreukKlasse.ToLower.Trim().Equals("klasse 2")
                _currentInfraction = Sanctions_InbreukKlasse.ClassTwo
            Case pInbreukKlasse.ToLower.Trim().Equals("snelheid")
                _currentInfraction = Sanctions_InbreukKlasse.Speeding
            Case Else
                _currentInfraction = Sanctions_InbreukKlasse.InvalidClass
        End Select
    End Function

    Public Function CalculateSanction(Optional ByVal pLastSanction As Integer = 0,
                                      Optional ByVal pSpeedLimit As Integer = 0,
                                      Optional ByVal pVelocity As Integer = 0,
                                      Optional ByVal pIsTruck As Boolean = False) As Integer

        Select Case _currentInfraction
            Case Sanctions_InbreukKlasse.Speeding
                If (pVelocity > 0) Then
                    Return _myProxy.DetermineSpeedingSanction(pIsTruck, pSpeedLimit, pVelocity, _recidive)
                End If
            Case Sanctions_InbreukKlasse.ClassTwo
                Select Case _recidive
                    Case 0
                        Return 0
                    Case 1
                        Return 1
                    Case 2
                        Return 2
                    Case Else
                        Return 2
                End Select
                If _recidive < 2 Then
                    Return 1 'Schriftelijke Berisping
                Else
                    Return 2 '1 week rijverbod
                End If
            Case Sanctions_InbreukKlasse.ClassOne
                If _recidive = 0 Then
                    Return 2 '1 week rijverbod
                Else
                    DoubleUpLastSanction = True
                    If (pLastSanction = 0 Or pLastSanction = 1) Then
                        Return 2
                    Else
                        Return pLastSanction
                    End If
                End If
        End Select


    End Function
End Class
