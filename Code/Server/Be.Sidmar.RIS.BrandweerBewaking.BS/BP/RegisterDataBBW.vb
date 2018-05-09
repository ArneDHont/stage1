Option Strict On
Option Explicit On 

Imports ADF.BusinessProcessServices

Namespace BP 'BusinessProcessBase

#Region "Interventie brandweer"

    Friend Class RegisterInterventieBrandweer
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSInterventie
        Private ReadOnly _result As New TDSInterventie
        Private _user As String
        Public ReadOnly Property Result() As TDSInterventie
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSInterventie, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSInterventie

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateInterventie(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Stock brandweer"

    Friend Class RegisterStock
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSVerbruiksArtikel
        Private ReadOnly _result As New TDSVerbruiksArtikel
        Private _user As String
        Public ReadOnly Property Result() As TDSVerbruiksArtikel
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSVerbruiksArtikel, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSVerbruiksArtikel

            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterStock(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Registratie bewaking"

#Region "Alcoholtest"

    Friend Class RegisterRegistratieAlcoholtest
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSAlcoholtest
        Private ReadOnly _result As New TDSAlcoholtest
        Private _user As String
        Public ReadOnly Property Result() As TDSAlcoholtest
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSAlcoholtest, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSAlcoholtest

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieAlcoholtest(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Diefstal"

    Friend Class RegisterRegistratieDiefstal
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDiefstal
        Private ReadOnly _result As New TDSDiefstal
        Private _user As String
        Public ReadOnly Property Result() As TDSDiefstal
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSDiefstal, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDiefstal

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieDiefstal(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "OpenKleerkast"

    Friend Class RegisterRegistratieOpenKleerkast
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSOpenKleerkast
        Private ReadOnly _result As New TDSOpenKleerkast
        Private _user As String
        Public ReadOnly Property Result() As TDSOpenKleerkast
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSOpenKleerkast, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSOpenKleerkast

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieOpenKleerkast(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Aanrijding"

    Friend Class RegisterRegistratieAanrijding
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSAanrijding
        Private ReadOnly _result As New TDSAanrijding
        Private _user As String
        Public ReadOnly Property Result() As TDSAanrijding
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSAanrijding, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSAanrijding

            dsIn.Merge(_input)
            _result.Merge(myBS.createUpdateRegistratieAanrijding(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Schadegeval"

    Friend Class RegisterRegistratieSchadegeval
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSSchadegeval
        Private ReadOnly _result As New TDSSchadegeval
        Private _user As String
        Public ReadOnly Property Result() As TDSSchadegeval
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSSchadegeval, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSSchadegeval

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieSchadegeval(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Diverse Registratie"

    Friend Class RegisterRegistratieDivRegistratie
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDivRegistratie
        Private ReadOnly _result As New TDSDivRegistratie
        Private _user As String
        Public ReadOnly Property Result() As TDSDivRegistratie
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSDivRegistratie, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDivRegistratie

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieDiverseRegistratie(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Controle Voertuig"

    Friend Class RegisterRegistratieControleVoertuig
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSControleVoertuig
        Private ReadOnly _result As New TDSControleVoertuig
        Private _user As String
        Public ReadOnly Property Result() As TDSControleVoertuig
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSControleVoertuig, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSControleVoertuig

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieControleVoertuig(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Inbreuk op reglementen"

    Friend Class RegisterRegistratieInbreukRegl
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSInbreukRegl
        Private ReadOnly _result As New TDSInbreukRegl
        Private _user As String
        Public ReadOnly Property Result() As TDSInbreukRegl
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSInbreukRegl, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSInbreukRegl

            dsIn.Merge(_input)
            _result.Merge(myBS.CreateUpdateRegistratieInbreukRegl(dsIn, _user))
        End Sub
    End Class

#End Region

#End Region

#Region "Registratie Individu"

    Public Class RegisterIndividu
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSIndividuen
        Private ReadOnly _result As New TDSIndividuen
        Private _user As String
        Public ReadOnly Property Result() As TDSIndividuen
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSIndividuen, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSIndividuen

            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterIndividu(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Register Voertuig"

    Public Class RegisterVoertuigen
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSVoertuigen
        Private ReadOnly _result As New TDSVoertuigen
        Private _user As String
        Public ReadOnly Property Result() As TDSVoertuigen
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSVoertuigen, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSVoertuigen
            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterVoertuigen(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Register verzekeringfirma's"

    Public Class RegisterVerzFirma
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSVerzFirmas
        Private ReadOnly _result As New TDSVerzFirmas
        Private _user As String
        Public ReadOnly Property Result() As TDSVerzFirmas
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSVerzFirmas, ByVal user As String)
            _input = data
            _user = user
        End Sub
        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSVerzFirmas

            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterVerzFirmas(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Register firma's"

    Public Class RegisterFirmas
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSFirmas
        Private ReadOnly _result As New TDSFirmas
        Private _user As String
        Public ReadOnly Property Result() As TDSFirmas
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSFirmas, ByVal user As String)
            _input = data
            _user = user
        End Sub


        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSFirmas

            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterFirmas(dsIn, _user))
        End Sub
    End Class

#End Region

#Region "Register dagverslag"

    Public Class RegisterDagverslagInlichting
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDagverslagInlichtingen
        Private ReadOnly _result As New TDSDagverslagInlichtingen
        Private _user As String
        Public ReadOnly Property Result() As TDSDagverslagInlichtingen
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSDagverslagInlichtingen, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBs As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDagverslagInlichtingen

            dsIn.Merge(_input)
            _result.Merge(myBs.RegisterDagverslagInlichting(dsIn, _user))
        End Sub
    End Class

    Public Class RegisterDagverslagPersoneel
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDagverslagPersoneel
        Private ReadOnly _result As New TDSDagverslagPersoneel
        Private _user As String
        Public ReadOnly Property Result() As TDSDagverslagPersoneel
            Get
                Return _result
            End Get
        End Property
        Public Sub New(ByVal data As TDSDagverslagPersoneel, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDagverslagPersoneel

            dsIn.Merge(_input)
            _result.Merge(myBS.RegisterDagverslagPersoneel(dsIn, _user))
        End Sub
    End Class

    Public Class RegisterDagverslagRegistratieTypes
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDagverslagRegistratieType
        Private ReadOnly _result As New TDSDagverslagRegistratieType
        Private _user As String
        Public ReadOnly Property Result() As TDSDagverslagRegistratieType
            Get
                Return _result
            End Get
        End Property
        Public Sub New(ByVal data As TDSDagverslagRegistratieType, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBs As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDagverslagRegistratieType

            dsIn.Merge(_input)
            _result.Merge(myBs.registerDagverslagRegistratieTypes(dsIn, _user))
        End Sub
    End Class

    Public Class RegisterDagverslagInlichtingType
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSDagverslagInlichtingType
        Private ReadOnly _result As New TDSDagverslagInlichtingType
        Private _user As String
        Public ReadOnly Property Result() As TDSDagverslagInlichtingType
            Get
                Return _result
            End Get
        End Property
        Public Sub New(ByVal data As TDSDagverslagInlichtingType, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSDagverslagInlichtingType

            dsIn.Merge(_input)
            _result.Merge(myBS.registerDagverslagInlichtingType(dsIn, _user))
        End Sub
    End Class

    Public Class RegisterPersoneel
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSBBBWPERS
        Private ReadOnly _result As New TDSBBBWPERS
        Private _user As String
        Public ReadOnly Property Result() As TDSBBBWPERS
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSBBBWPERS, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSBBBWPERS

            dsIn.Merge(_input)
            _result.Merge(myBS.registerPersoneel(dsIn, _user))
        End Sub
    End Class

    Public Class RegisterAFDAMC
        Inherits BusinessProcessBase

        Private ReadOnly _input As TDSBBAFDAMC
        Private ReadOnly _result As New TDSBBAFDAMC
        Private _user As String
        Public ReadOnly Property Result() As TDSBBAFDAMC
            Get
                Return _result
            End Get
        End Property

        Public Sub New(ByVal data As TDSBBAFDAMC, ByVal user As String)
            _input = data
            _user = user
        End Sub

        Protected Overrides Sub ExecuteBusinessProcess()
            Dim myBS As New DMC.UpdateDataBBW
            Dim dsIn As New TDSBBAFDAMC

            dsIn.Merge(_input)
            _result.Merge(myBS.registerAFDAMC(dsIn, _user))
        End Sub
    End Class

#End Region

End Namespace


