Option Strict On
Option Explicit On 

Imports ADF.BusinessProcessServices

Namespace BP 'BusinessProcessBase
#Region "RegisterAarden"
    Friend Class RegisterAarden
        Inherits BusinessProcessBase
        Private _user As String
        Private _input As TDSAarden
        Private _result As New TDSAarden

        Public ReadOnly Property Result() As TDSAarden
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSAarden, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSAarden
            'Dim result As New TDSMateriaal
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterAarden(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterOorzaken"
    Friend Class RegisterOorzaken
        Inherits BusinessProcessBase

        Private _input As TDSOorzaken
        Private _result As New TDSOorzaken
        Private _user As String

        Public ReadOnly Property Result() As TDSOorzaken
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSOorzaken, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSOorzaken
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterOorzaken(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterInterventietypes"
    Friend Class RegisterInterventietypes
        Inherits BusinessProcessBase

        Private _input As TDSIntvType
        Private _result As New TDSIntvType
        Private _user As String

        Public ReadOnly Property Result() As TDSIntvType
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSIntvType, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSIntvType
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterInterventietypes(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterAfdelingen"
    Friend Class RegisterAfdelingen
        Inherits BusinessProcessBase

        Private _input As TDSAfdelingen
        Private _result As New TDSAfdelingen
        Private _user As String
        Public ReadOnly Property Result() As TDSAfdelingen
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSAfdelingen, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSAfdelingen
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterAfdelingen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterEenheden"
    Friend Class RegisterEenheden
        Inherits BusinessProcessBase

        Private _input As TDSEenheden
        Private _result As New TDSEenheden
        Private _user As String
        Public ReadOnly Property Result() As TDSEenheden
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSEenheden, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSEenheden
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterEenheden(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterArtikelgroepen"
    Friend Class RegisterArtikelgroepen
        Inherits BusinessProcessBase

        Private _input As TDSArtikelgroep
        Private _result As New TDSArtikelgroep
        Private _user As String
        Public ReadOnly Property Result() As TDSArtikelgroep
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSArtikelgroep, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSArtikelgroep
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterArtikelgroepen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterInbreuktypes"
    Friend Class RegisterInbreuktypes
        Inherits BusinessProcessBase

        Private _input As TDSInbrType
        Private _result As New TDSInbrType
        Private _user As String
        Public ReadOnly Property Result() As TDSInbrType
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSInbrType, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSInbrType
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterInbreuktypes(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterRegistratietypes"
    Friend Class RegisterRegistratietypes
        Inherits BusinessProcessBase

        Private _input As TDSRegType
        Private _result As New TDSRegType
        Private _user As String
        Public ReadOnly Property Result() As TDSRegType
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSRegType, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSRegType
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterRegistratietypes(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterIndividutypes"
    Friend Class RegisterIndividutypes
        Inherits BusinessProcessBase

        Private _input As TDSIndividuType
        Private _result As New TDSIndividuType
        Private _user As String
        Public ReadOnly Property Result() As TDSIndividuType
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSIndividuType, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSIndividuType
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterIndividutypes(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterInbreukartikelen"
    Friend Class RegisterInbreukartikelen
        Inherits BusinessProcessBase

        Private _input As TDSInbrArt
        Private _result As New TDSInbrArt
        Private _user As String
        Public ReadOnly Property Result() As TDSInbrArt
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSInbrArt, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSInbrArt
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterInbreukartikelen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterTypesBetrokkenen"
    Friend Class RegisterTypesBetrokkenen
        Inherits BusinessProcessBase

        Private _input As TDSTypeBetrokkene
        Private _result As New TDSTypeBetrokkene
        Private _user As String
        Public ReadOnly Property Result() As TDSTypeBetrokkene
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSTypeBetrokkene, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSTypeBetrokkene
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterTypesBetrokkenen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterTypesVoertuigen"
    Friend Class RegisterTypesVoertuigen
        Inherits BusinessProcessBase

        Private _input As TDSVoertuigTypes
        Private _result As New TDSVoertuigTypes
        Private _user As String
        Public ReadOnly Property Result() As TDSVoertuigTypes
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSVoertuigTypes, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSVoertuigTypes
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterTypesVoertuigen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterAanspreektitels"
    Friend Class RegisterAanspreektitels
        Inherits BusinessProcessBase

        Private _input As TDSAanspreektitel
        Private _result As New TDSAanspreektitel
        Private _user As String
        Public ReadOnly Property Result() As TDSAanspreektitel
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSAanspreektitel, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSAanspreektitel
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterAanspreektitels(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterPloeg"
    Friend Class RegisterPloeg
        Inherits BusinessProcessBase

        Private _input As TDSPloeg
        Private _result As New TDSPloeg
        Private _user As String
        Public ReadOnly Property Result() As TDSPloeg
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSPloeg, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSPloeg
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterPloegen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterSchadeAan"
    Friend Class RegisterSchadeAan
        Inherits BusinessProcessBase

        Private _input As TDSScadObjecten
        Private _result As New TDSScadObjecten
        Private _user As String
        Public ReadOnly Property Result() As TDSScadObjecten
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSScadObjecten, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSScadObjecten
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterSchadeAan(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterGebruikVoertuig"
    Friend Class RegisterGebruikVoertuig
        Inherits BusinessProcessBase

        Private _input As TDSGebruikVoertuig
        Private _result As New TDSGebruikVoertuig
        Private _user As String
        Public ReadOnly Property Result() As TDSGebruikVoertuig
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSGebruikVoertuig, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSGebruikVoertuig
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterGebruikVoertuig(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterWerfVoertuigen"
    Friend Class RegisterWerfVoertuigen
        Inherits BusinessProcessBase

        Private _input As TDSWerfVoertuig
        Private _result As New TDSWerfVoertuig
        Private _user As String
        Public ReadOnly Property Result() As TDSWerfVoertuig
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSWerfVoertuig, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSWerfVoertuig
            'Dim result As New TDSMateriaal
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterWerfvoertuigen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
#Region "RegisterInterventieArtikelen"
    Friend Class RegisterInterventieArtikelen
        Inherits BusinessProcessBase

        Private _input As TDSIntvArt
        Private _result As New TDSIntvArt
        Private _user As String
        Public ReadOnly Property Result() As TDSIntvArt
            Get
                Return Me._result
            End Get
        End Property

        Public Sub New(ByVal data As TDSIntvArt, ByVal user As String)
            Me._input = data
            Me._user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New BS.DMC.UpdateDataBBW
            Dim dsIn As New BS.TDSIntvArt
            'Dim result As New TDSMateriaal
            dsIn.Merge(Me._input)
            _result.Merge(myBS.RegisterInterventieartikelen(dsIn, Me._user))

            'Return result
        End Sub
    End Class
#End Region
End Namespace
