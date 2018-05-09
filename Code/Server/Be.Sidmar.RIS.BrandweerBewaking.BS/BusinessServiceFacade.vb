Option Strict On
Option Explicit On

Imports ADF.Diagnostics.PerformanceCounters
Imports ADF.Configuration.ConfigurationSettings
Imports System.Reflection
Imports ADF.ExceptionHandling
Imports Be.Sidmar.RIS.BrandweerBewaking.BS.DMC
Imports System.Collections.Generic


Public Class BusinessServiceFacade

    Private Shared ReadOnly CurrentApp As String = Application.Name
    Private _svcGetData As GetDataBbw
    Private _svcUpdateData As UpdateDataBBW
    Private _svcUpdateDataSodie As UpdateDataSoDie
    Private _dataConfiguratie As TDSConfiguratie

    Private ReadOnly Property SvcGetData() As GetDataBbw
        Get
            If _svcGetData Is Nothing Then _svcGetData = New GetDataBbw
            Return _svcGetData
        End Get
    End Property

    Private ReadOnly Property SvcUpdateData() As UpdateDataBBW
        Get
            If _svcUpdateData Is Nothing Then _svcUpdateData = New UpdateDataBBW
            Return _svcUpdateData
        End Get
    End Property

    Private ReadOnly Property SvcUpdateDataSodie() As UpdateDataSoDie
        Get
            If _svcUpdateDataSodie Is Nothing Then _svcUpdateDataSodie = New UpdateDataSoDie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("SODIE", "ConnectionString").WD.Replace("456", "TOMMY"))
            Return _svcUpdateDataSodie
        End Get
    End Property

    Private Property MyConnection As String
    Private Property MySodieConnection As String

#Region "Constructors"

    Public Sub New(ByVal dbConnection As String)
        MyConnection = dbConnection

        _dataConfiguratie = New TDSConfiguratie
        _dataConfiguratie = GetConfigurationSettings()

    End Sub

#End Region

#Region "GetCodeTables"
    Public Function GetInterventieType() As TDSIntvType
        'Doel:   Tabel BBINTVTY ophalen
        'Auteur: Rajiv/Koen - 30/03/2006
        'Returns: dataset met interventietypes
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIntvType

            result.Merge(myBc.GetInterventieType())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVoertuigTypes() As TDSVoertuigTypes
        'Doel:   Tabel BBTYTSP ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met voertuigtypes
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVoertuigTypes

            result.Merge(myBc.GetVoertuigTypes())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetAanspreektitel() As TDSAanspreektitel
        'Doel:   Tabel BBINDGSL ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met aanspreektitels
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSAanspreektitel

            result.Merge(myBc.GetAanspreektitel)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetGebruikVoertuig() As TDSGebruikVoertuig
        'Doel:   Tabel BBBRKTSP ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met gebruik van voertuigen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSGebruikVoertuig

            result.Merge(myBc.GetGebruikVoertuig)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetPloeg() As TDSPloeg
        'Doel:   Tabel BBBWPLG ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met ploegen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSPloeg

            result.Merge(myBc.GetPloeg)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetEenheden() As TDSEenheden
        'Doel:   Tabel BBEH ophalen
        'Auteur: Rajiv/Koen - 18/04/2006
        'Returns: dataset met eenheden
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSEenheden

            result.Merge(myBc.GetEenheden())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetArtikelGroepen() As TDSArtikelgroep
        'Doel:   Tabel BBARTGR ophalen
        'Auteur: Rajiv/Koen - 18/04/2006
        'Returns: dataset met artikelgroepen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSArtikelgroep

            result.Merge(myBc.GetArtikelGroepen())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetIndividuTypes() As TDSIndividuType
        'Doel:   Tabel BBINDTY ophalen
        'Auteur: Rajiv/Koen - 18/04/2006
        'Returns: dataset met individutypes
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIndividuType

            result.Merge(myBc.GetIndividuTypes())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetTypeBetrokkenen() As TDSTypeBetrokkene
        'Doel:   Tabel BBTYBTRK ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met types betrokkenen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSTypeBetrokkene

            result.Merge(myBc.GetTypeBetrokkenen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegistratieType() As TDSRegType
        'Doel:   Tabel BBREGTY ophalen
        'Auteur: Rajiv/Koen - 31/03/2006
        'Returns: dataset met registratietypes
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSRegType

            result.Merge(myBc.GetRegistratieType())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetAfdelingen() As TDSAfdelingen
        'Doel:   Tabel BBAFD ophalen
        'Auteur: Rajiv/Koen - 31/03/2006
        'Returns: dataset met afdelingen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSAfdelingen

            result.Merge(myBc.GetAfdelingen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetOorzaken(ByVal intvType As Integer) As TDSOorzaken
        'Doel:   Tabel BBBRRD ophalen
        'Auteur: Rajiv/Koen - 31/03/2006
        'Returns: dataset met oorzaken van een interventie
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSOorzaken

            result.Merge(myBc.GetOorzaken(intvType))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetAarden(ByVal intvType As Integer) As TDSAarden
        'Doel:   Tabel BBBRTY ophalen
        'Auteur: Rajiv/Koen - 31/03/2006
        'Returns: dataset met aarden van een interventie
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSAarden

            result.Merge(myBc.GetAarden(intvType))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function


    Public Function GetInbreukArt(ByVal inbrType As Integer) As TDSInbrArt
        'Doel:   Tabel BBINBRAR ophalen
        'Auteur: Rajiv/Koen - 04/04/2006
        'Returns: dataset met inbreukartikelen van een bewakingsregistratie
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSInbrArt

            result.Merge(myBc.GetInbreukArt(inbrType))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetOvertrederTypeInbreukRegl() As TDSInbrIndTy
        'Doel:   Tabel BBINBRINDTY (type overtreder) ophalen
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSInbrIndTy

            result.Merge(myBc.GetOvertrederTypeInbreukRegl)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetDiefDup() As TDSDiefDup
        'Doel:   Tabel BBDIEFDU ophalen
        'Auteur: Rajiv/Koen - 04/04/2006
        'Returns: dataset met mogelijke gedupeerden van een diefstal
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDiefDup

            result.Merge(myBc.GetDiefDup)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetInbreukType() As TDSInbrType
        'Doel:   Tabel BBINBRTY ophalen
        'Auteur: Rajiv/Koen - 04/04/2006
        'Returns: dataset met inbreuktypes van een bewakingsregistratie
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSInbrType

            result.Merge(myBc.GetInbreukType())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetScadObjecten() As TDSScadObjecten
        'Doel:   Tabel BBSCADAN ophalen
        'Auteur: Rajiv/Koen - 10/04/2006
        'Returns: dataset met schadeobjecten (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSScadObjecten

            result.Merge(myBc.GetScadObjecten())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetWerfVoertuig() As TDSWerfVoertuig
        'Doel:   Tabel BBWRFTSP ophalen
        'Auteur: Rajiv/Koen - 19/04/2006
        'Returns: dataset met werf voertuigen (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSWerfVoertuig

            result.Merge(myBc.GetWerfVoertuig())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetToestandType() As TDSToestandType
        'Doel:   Tabel BBTYSTA ophalen
        'Auteur: Rajiv/Koen - 20/04/2006
        'Returns: dataset met toestandtypes (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSToestandType

            result.Merge(myBc.GetToestandType())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetToestanden() As TDSToestanden
        'Doel:   Tabel BBSTA ophalen
        'Auteur: Rajiv/Koen - 20/04/2006
        'Returns: dataset met toestanden (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSToestanden

            result.Merge(myBc.GetToestanden())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBewakingDup() As TDSBewakingDup
        'Doel:   Tabel BBBEWDUP ophalen
        'Auteur: Rajiv/Koen - 02/05/2006
        'Returns: dataset met benadeelden (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBewakingDup

            result.Merge(myBc.GetBewakingDup())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVaststellerAanrijding() As TDSVaststellerAanrijding
        'Doel:   Tabel BBVASTOGV ophalen
        'Auteur: Rajiv/Koen - 12/05/2006
        'Returns: dataset met vaststellers van een aanrijding (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVaststellerAanrijding

            result.Merge(myBc.GetVaststellerAanrijding())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "GetBBWData"

    Public Function GetMaxBBTSP() As Integer
        'Doel: ophalen laatste bbtsp
        'Auteur: dien okt 2006
        Try
            Dim myBc As New GetDataBbw
            Return myBc.GetMaxBBTSP()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetIndividuen() As TDSIndividuen
        'Doel:   Alle individuen ophalen
        'Auteur: Rajiv/Koen - 21/04/2006
        'Returns: dataset met individuen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIndividuen

            result.Merge(myBc.GetIndividuen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetIndividu(ByVal idInd As Integer) As TDSIndividuen
        'Doel: Ophalen van één individu
        'Auteur: Siddien - sept 2006
        'Returns: dataset met één individu
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIndividuen

            result.Merge(myBc.GetIndividu(idInd))

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    Public Sub GetMaxValuesInterventie(ByVal interventieTypeId As Integer, _
                                            ByVal afdelingId As Integer, _
                                            ByVal jaartal As Integer, _
                                            ByRef maxInterventieId As Integer, _
                                            ByRef maxAfdelingVolgnummer As Integer, _
                                            ByRef maxJaarVolgnummer As Integer)
        'Doel:   Alle maximumwaarden ophalen
        'Auteur: Rajiv/Koen - 10/04/2006
        'Returns: integers met max waarden
        Try
            Dim myBc As New GetDataBbw

            myBc.GetMaxValuesInterventie(interventieTypeId, afdelingId, jaartal, _
                                         maxInterventieId, maxAfdelingVolgnummer, maxJaarVolgnummer)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Sub

    Public Sub GetMaxValuesRegistratie(ByVal tmsRegistratie As Date, _
                                       ByRef idReg As Integer, _
                                       ByRef volgnrRegJaar As Integer)
        'Doel:   Alle maximumwaarden ophalen
        'Auteur: Rajiv/Koen - 27/04/2006
        'Returns: integers met max waarden
        Try
            Dim myBc As New GetDataBbw

            myBc.GetMaxValuesRegistratie(tmsRegistratie, idReg, volgnrRegJaar)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Sub

    Public Function GetBRInterventies() As TDSIntvBr
        'Doel:   Alle interventies ophalen
        'Auteur: Rajiv/Koen - 31/03/2006
        'Returns: dataset met interventies
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIntvBr

            result.Merge(myBc.GetInterventies)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetMilieuverontreinigingen() As TDSIntvBr
        'Doel:   Alle milieuverontreinigingen ophalen
        'Auteur: Mieke Duynslager - 23/05/2007
        'Returns: dataset met milieuverontreinigingen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIntvBr

            result.Merge(myBc.GetMilieuverontreinigingen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetMilieuVerontreiningenBewaking() As TDSRegBew
        'Doel: milieuverontreiningen bewaking ophalen
        'Auteur: dien - mei 2009
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSRegBew
            result.Merge(myBc.GetMilieuverontreinigingenBewaking)

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Function

    Public Function GetBBBRPersoneel() As TDSBBBRPers
        'Doel:   Alle brandweerpersoneelsleden
        'Auteur: Rajiv/Koen - 13/04/2006
        'Returns: dataset met brandweerpersoneelsleden
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBBRPers

            result.Merge(myBc.GetBBBRPersoneel())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBBBRPersoneelActief() As TDSBBBRPers
        'Doel:   Alle brandweerpersoneelsleden
        'Auteur: naco - 08/02/2017
        'Returns: dataset met brandweerpersoneelsleden
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBBRPers

            result.Merge(myBc.GetBBBRPersoneelActief())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBBWAKPersoneel() As TDSBBWAKPers
        'Doel:   Alle bewakingspersoneelsleden
        'Auteur: Rajiv/Koen - 13/04/2006
        'Returns: dataset met bewakingspersoneelsleden
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBWAKPers

            result.Merge(myBc.GetBBWAKPersoneel())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBBWAKPersoneelActief() As TDSBBWAKPers
        'Doel:   Alle bewakingspersoneelsleden
        'Auteur: naco - 08/02/2017
        'Returns: dataset met bewakingspersoneelsleden
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBWAKPers

            result.Merge(myBc.GetBBWAKPersoneelActief())

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetInterventie(ByVal idIntvBrdw As Integer) As TDSInterventie
        'Doel:   Tabel BBINTVBR ophalen
        'Auteur: Rajiv/Koen - 04/04/2006
        'Returns: dataset met oorzaken van een interventie
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSInterventie

            result.Merge(myBc.GetBBWInterventie(idIntvBrdw))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegistratiesBew() As TDSRegBew
        'Doel:   Alle registraties ophalen (bewaking)
        'Auteur: Rajiv/Koen - 05/04/2006
        'Returns: dataset met registraties
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSRegBew

            result.Merge(myBc.GetRegistraties)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegSchadegeval(ByVal idBewReg As Integer) As TDSSchadegeval
        'Doel:   Een schadegeval ophalen (bewaking)
        'Auteur: Rajiv/Koen - 10/04/2006
        'Returns: dataset met een schadegeval (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSSchadegeval

            result.Merge(myBc.GetRegSchadegeval(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetAanrijding(ByVal idReg As Integer) As TDSAanrijding
        'Doel ophalen aanrijding
        'Auteur: dien - okt. 2006
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSAanrijding

            result.Merge(myBc.GetAanrijding(idReg))
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegAlcoholtest(ByVal idBewReg As Integer) As TDSAlcoholtest
        'Doel:   Een alcoholtest ophalen (bewaking)
        'Auteur: Rajiv/Koen - 11/04/2006
        'Returns: dataset met een alcoholtest (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSAlcoholtest

            result.Merge(myBc.GetRegAlcoholtest(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegDiefstal(ByVal idBewReg As Integer) As TDSDiefstal
        'Doel:   Een diefstal ophalen (bewaking)
        'Auteur: Rajiv/Koen - 12/04/2006
        'Returns: dataset met een diefstal (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDiefstal

            result.Merge(myBc.GetRegDiefstal(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegOpenKleerkast(ByVal idBewReg As Integer) As TDSOpenKleerkast
        'Doel:   Een openmaken kleerkasten ophalen (bewaking)
        'Auteur: Rajiv/Koen - 13/04/2006
        'Returns: dataset met een openmaken kleerkast (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSOpenKleerkast

            result.Merge(myBc.GetRegOpenKleerkast(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegDivRegistratie(ByVal idBewReg As Integer) As TDSDivRegistratie
        'Doel:   Een diverse registratie ophalen (bewaking)
        'Auteur: Rajiv/Koen - 14/04/2006
        'Returns: dataset met een diverse registratie (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDivRegistratie

            result.Merge(myBc.GetRegDivRegistratie(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegInbreukRegl(ByVal idBewReg As Integer) As TDSInbreukRegl
        'Doel:   Een inbreuk op reglementenregistratie ophalen (bewaking)
        'Auteur: Rajiv/Koen - 18/04/2006
        'Returns: dataset met een inbreuk op reglementen (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSInbreukRegl

            result.Merge(myBc.GetRegInbreukRegl(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetRegControleVoertuig(ByVal idBewReg As Integer) As TDSControleVoertuig
        'Doel:   Een controle op een voertuigregistratie ophalen (bewaking)
        'Auteur: Rajiv/Koen - 04/05/2006
        'Returns: dataset met een controle op voertuig (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSControleVoertuig

            result.Merge(myBc.GetRegControleVoertuig(idBewReg))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVastgesteldeInbreuken(ByVal idInd As Integer, ByVal idRegistratie As Integer) As TDSVastgesteldeInbreuken
        'Doel:   Vastgestelde inbreuken van een individu ophalen (bewaking)
        'Auteur: Rajiv/Koen - 05/05/2006
        'Returns: dataset met vastgestelde inbreuken op reglementen (bewaking)
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVastgesteldeInbreuken

            result.Merge(myBc.GetVastgesteldeInbreuken(idInd, idRegistratie))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVerzFirmas() As TDSVerzFirmas
        'Doel:   Alle verzekeringsfirma's ophalen (bewaking)
        'Auteur: Rajiv/Koen - 05/04/2006
        'Returns: dataset met verzekeringsfirma's
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVerzFirmas

            result.Merge(myBc.GetVerzFirmas)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetFirmas() As TDSFirmas
        'Doel:   Alle firma's ophalen (bewaking)
        'Auteur: Rajiv/Koen - 05/04/2006
        'Returns: dataset met firma's
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSFirmas

            result.Merge(myBc.GetFirmas)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVoertuig(ByVal idTsp As Integer) As TDSVoertuigen
        'Doel: ophalen van één voertuig
        'Auteur: DIEN - okt.2006
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVoertuigen

            result.Merge(myBc.GetVoertuig(idTsp))

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVoertuigen() As TDSVoertuigen
        'Doel:   Alle voertuigen ophalen (bewaking)
        'Auteur: Rajiv/Koen - 03/05/2006
        'Returns: dataset met voertuigen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVoertuigen

            result.Merge(myBc.GetVoertuigen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetInterventieArtikelen() As TDSIntvArt
        'Doel:   Alle interventieartikelen ophalen
        'Auteur: Rajiv/Koen - 07/04/2006
        'Returns: dataset met interventieartikelen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSIntvArt

            result.Merge(myBc.GetInterventieArtikelen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVerbruiksArtikelen() As TDSVerbruiksArtikel
        'Doel:   Alle verbruiksartikelen ophalen
        'Auteur: Rajiv/Koen - 21/04/2006
        'Returns: dataset met verbruiksartikelen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVerbruiksArtikel

            result.Merge(myBc.GetVerbruiksArtikelen)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetVerbruiksArtikelenMinStock() As TDSVerbruiksArtikel
        'Doel:   Alle verbruiksartikelen ophalen waarvoor huidige stock < min stock
        'Auteur: Nancy Coppens - 07/12/2006
        'Returns: dataset met verbruiksartikelen
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSVerbruiksArtikel

            result.Merge(myBc.GetVerbruiksArtikelenMinStock)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBrandenPerAfdelingMaand(ByVal maand As Integer, ByVal jaar As Integer) As TDSBrandenPerAfdeling
        'Doel:   Alle gegevens ophalen voor het maandrapport Branden per afdeling
        'Auteur: Stein - 25/07/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBrandenPerAfdeling

            result.Merge(myBc.GetBrandenPerAfdelingMaand(maand, jaar))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBrandenPerAfdelingJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling
        'Doel:   Alle gegevens ophalen voor het jaarrapport Branden per afdeling
        'Auteur: Stein - 27/07/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBrandenPerAfdeling

            result.Merge(myBc.GetBrandenPerAfdelingJaar(jaar))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBrandenPerAfdelingAardJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling
        'Doel:   Alle gegevens ophalen voor het jaarrapport Branden per afdeling en aard
        'Auteur: Stein - 27/07/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBrandenPerAfdeling

            result.Merge(myBc.GetBrandenPerAfdelingAardJaar(jaar))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBrandenPerAfdelingOorzaakJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling
        'Doel:   Alle gegevens ophalen voor het jaarrapport Branden per afdeling en aard
        'Auteur: Stein - 27/07/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBrandenPerAfdeling

            result.Merge(myBc.GetBrandenPerAfdelingOorzaakJaar(jaar))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetSpecBestForMailWithBijlage() As TDSBBBSTBY
        'Doel:   Alle speciale bestemmelingen ophalen waarvoor een mail met bijlagen moet verstuurd worden (geen URL)
        'Auteur: Mieke Duynslager - Sept 2007

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBBSTBY

            result.Merge(myBc.GetSpecBestForMailMetBijlage)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetDagverslagInlichtingen(ByVal datumVanaf As DateTime, _
                                               ByVal datumTot As DateTime) As TDSDagverslagInlichtingen
        'Doel: ophalen van alle dagverslagen inlichtingen
        'Auteur: Siddien
        'Datum: okt. 2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDagverslagInlichtingen

            result.Merge(myBc.GetDagverslagInlichtingen(datumVanaf, datumTot))
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetDagverslagInlichtingenType() As TDSDagverslagInlichtingType
        'Doel: ophalen van alle dagverslaginlichtingen types 
        'Auteur: Siddien
        'Datum: okt. 2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDagverslagInlichtingType

            result.Merge(myBc.GetDagverslagInlichtingTypes)
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBetrokkenenAanrijding(ByVal idReg As Integer) As TDSBBBTROGV
        'Doel: ophalen van alle betrokkenen van een aanrijding
        'Auteur: Dien
        'Datum: Okt. 2006
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBBTROGV

            result.Merge(myBc.GetBetrokkenenAanrijding(idReg))
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBBBWPersoneel() As TDSBBBWPERS
        'Doel: ophalen van alle personeelsleden
        'Auteur: Dien
        'Datum: okt. 2006
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBBWPERS

            result.Merge(myBc.GetBBBWPersoneel())
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function getBBAFDAMC() As TDSBBAFDAMC
        'Doel: ophalen alle afdelingsmilieucoördinatoren
        'Auteur: dien
        'Datum: mei 2009
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSBBAFDAMC

            result.Merge(myBc.getAFDAMC())
            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetLijstSnelheidsovertredingen(ByVal intern As Boolean) As TDSSnelheidsOvertredingen
        'Doel:   Lijst snelheidsovertredingen
        'Auteur: Lawrence Verbruggen - 12/04/2011

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSSnelheidsOvertredingen

            result.Merge(myBc.GetLijstSnelheidsOvertredingen(intern))

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    Public Function GetOvertredingen(ByVal intern As Boolean,
                                     ByVal aConnectionString As String,
                                     ByVal aDateFrom As DateTime) As TDSOvertreding
        'Doel:   Lijst snelheidsovertredingen
        'Auteur: Lawrence Verbruggen - 12/04/2011

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSOvertreding

            result.Merge(myBc.GetOvertredingen(intern, aConnectionString, aDateFrom))

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    Public Function GetHierarchicalPersonalIdsToAvoid(ByVal aConnectionString As String) As List(Of String)

        Try

            Dim myBc As New GetDataBbw
            Return myBc.GetHierarchicalPersonalIdsToAvoid(aConnectionString)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try

    End Function

    Public Function DetermineSpeedingSanction(ByVal pIsTruck As Boolean,
                                                ByVal pSpeedingLimit As Integer,
                                                ByVal pVelocity As Integer,
                                                ByVal pRecidive As Integer,
                                                ByVal aConnectionString As String) As Integer
        Try

            Dim myBc As New GetDataBbw
            Return myBc.DetermineSpeedingSanction(pIsTruck, pSpeedingLimit, pVelocity, pRecidive, aConnectionString)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try

    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'June 2013 Stijn Vranken : BBW Adjustment for Sodie-Interaction
    ' ''' <summary>
    ' ''' This function returns if the selected traffic infraction is required within Sodie
    ' ''' </summary>
    ' ''' <param name="pArtNbrId">ArticleNbr of the infractions$</param>
    ' ''' <param name="pConnectionstring">The connectionstring needed to access the database</param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function DetermineSodieInfraction(ByVal pArtNbrId As Integer,
    '                                         ByVal pConnectionstring As String) As Boolean
    '    Try

    '        Dim myBc As New GetDataBbw
    '        Return myBc.DetermineSodieInfraction(pArtNbrId, pConnectionstring)

    '    Catch ex As Exception
    '        ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
    '        Return Nothing
    '    End Try
    'End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    Public Function GetFirmaIdForRegistration(ByVal pRegistratieId As Integer,
                                              ByVal pConnectionString As String) As TDSFirmas
        Try

            Dim myBc As New GetDataBbw
            Return myBc.GetFirmaIdForRegistration(pRegistratieId, pConnectionString)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Get Configuration Settings"
    Public Function GetConfigurationSettings() As TDSConfiguratie
        'Doel:   Alle configuration settings ophalen
        'Auteur: Rajiv/Koen - 24/04/2006
        'Returns: dataset met configuration settings
        Try
            Dim result As New TDSConfiguratie
            result.Merge(GetDataBbw.GetConfigurationSettings)
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetAddresseesFromConfig(ByVal configKey As String,
                                            ByVal dbConnection As String) As TDSBBBestemmelingen
        'Doel:   Get addressees defined in config based on the given configkey
        'Auteur: Stijn V. 14/03/2013

        Try
            Return GetDataBbw.GetAddresseesFromConfig(configKey, dbConnection)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetBaseLinkVera(ByVal dbConnection As String) As String
        'Doel:   This function returns the base link of vera
        'Auteur: Stijn V. 14/03/2013

        Try
            Return GetDataBbw.GetBaseLinkVera(dbConnection)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "Update Interventie Brandweer"

    Private Shared _CPSRegisterINTVBR As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTVBR")
    Private Shared _AVGRegisterINTVBR As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTVBR")

    Public Function RegisterInterventie(ByVal data As TDSInterventie, ByVal user As String) As TDSInterventie
        'Doel:   creeren en updaten Interventie Brandweer
        'Auteur: Koen - Rajiv - 06/04/2006
        Dim timer As Long
        Try
            'Start Timer
            _CPSRegisterINTVBR.CountSingleCall()
            timer = _AVGRegisterINTVBR.TimerStart()

            Dim myBp As New BP.RegisterInterventieBrandweer(data, user)
            myBp.Execute()
            UpdateDataBBW.UpdateInterventieExtraInfoBrand(data)
            Return myBp.Result

        Finally
            'Stop Timer
            _AVGRegisterINTVBR.TimerStop(timer)
        End Try
    End Function

#End Region

#Region "Register Registratie Bewaking"
#Region "Register Alcoholtest"
    Private Shared _CPSRegisterBBALCTST As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieAlcoholtest")
    Private Shared _AVGRegisterBBALCTST As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieAlcoholtest")

    Public Function RegisterRegistratieAlcoholtest(ByVal data As TDSAlcoholtest, ByVal user As String) As TDSAlcoholtest
        'Doel:   creeren en updaten van een alcoholtest-registratie 
        'Auteur: Koen - Rajiv - 24/04/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBALCTST.CountSingleCall()
            _Timer = _AVGRegisterBBALCTST.TimerStart()

            Dim myBP As New BP.RegisterRegistratieAlcoholtest(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBALCTST.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register Diefstal"
    Private Shared _CPSRegisterBBDIEFST As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieDiefstal")
    Private Shared _AVGRegisterBBDIEFST As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieDiefstal")

    Public Function RegisterRegistratieDiefstal(ByVal data As TDSDiefstal, ByVal user As String) As TDSDiefstal
        'Doel:   creeren en updaten van een diefstal-registratie 
        'Auteur: Koen - Rajiv - 28/04/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBALCTST.CountSingleCall()
            _Timer = _AVGRegisterBBDIEFST.TimerStart()

            Dim myBP As New BP.RegisterRegistratieDiefstal(data, user)
            myBP.Execute()
            Return myBP.Result
        Catch ex As Exception
            Throw
        Finally
            'Stop Timer
            _AVGRegisterBBALCTST.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register OpenKleerkast"
    Private Shared _CPSRegisterBBOPKAST As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieOpenKleerkast")
    Private Shared _AVGRegisterBBOPKAST As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieOpenKleerkast")

    Public Function RegisterRegistratieOpenKleerkast(ByVal data As TDSOpenKleerkast, ByVal user As String) As TDSOpenKleerkast
        'Doel:   creeren en updaten van een openkleerkast-registratie 
        'Auteur: Koen - Rajiv - 28/04/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBOPKAST.CountSingleCall()
            _Timer = _AVGRegisterBBOPKAST.TimerStart()

            Dim myBP As New BP.RegisterRegistratieOpenKleerkast(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBOPKAST.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Register Aanrijding"
    Private Shared _CPSRegisterBBOGVTSP As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieAanrijding")
    Private Shared _AVGRegisterBBOGVTSP As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieAanrijding")

    Public Function registerRegistratieAanrijding(ByVal data As TDSAanrijding, ByVal user As String) As TDSAanrijding
        'Doel: opslaan aanrijding
        'Auteur: Siddien - okt. 2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBOGVTSP.CountSingleCall()
            _Timer = _AVGRegisterBBOGVTSP.TimerStart()

            Dim myBP As New BP.RegisterRegistratieAanrijding(data, user)
            myBP.Execute()
            Return myBP.Result
        Finally
            'Stop Timer
            _AVGRegisterBBOGVTSP.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register Schadegeval"
    Private Shared _CPSRegisterBBSCAD As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieSchadegeval")
    Private Shared _AVGRegisterBBSCAD As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieSchadegeval")

    Public Function RegisterRegistratieSchadegeval(ByVal data As TDSSchadegeval, ByVal user As String) As TDSSchadegeval
        'Doel:   creeren en updaten van een schadegeval-registratie 
        'Auteur: Koen - Rajiv - 02/05/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBSCAD.CountSingleCall()
            _Timer = _AVGRegisterBBSCAD.TimerStart()

            Dim myBP As New BP.RegisterRegistratieSchadegeval(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBSCAD.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register Diverse Registratie"
    Private Shared _CPSRegisterBBREGVSH As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieDiverseRegistratie")
    Private Shared _AVGRegisterBBREGVSH As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieDiverseRegistratie")

    Public Function RegisterRegistratieDivRegistratie(ByVal data As TDSDivRegistratie, ByVal user As String) As TDSDivRegistratie
        'Doel:   creeren en updaten van een diverse registratie
        'Auteur: Koen - Rajiv - 03/05/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBREGVSH.CountSingleCall()
            _Timer = _AVGRegisterBBREGVSH.TimerStart()

            Dim myBP As New BP.RegisterRegistratieDivRegistratie(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBSCAD.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register Controle Voertuig"
    Private Shared _CPSRegisterBBKEUTSP As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieControleVoertuig")
    Private Shared _AVGRegisterBBKEUTSP As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieControleVoertuig")

    Public Function RegisterRegistratieControleVoertuig(ByVal data As TDSControleVoertuig, ByVal user As String) As TDSControleVoertuig
        'Doel:   creeren en updaten van een controle voertuig
        'Auteur: Koen - Rajiv - 04/05/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBKEUTSP.CountSingleCall()
            _Timer = _AVGRegisterBBKEUTSP.TimerStart()

            Dim myBP As New BP.RegisterRegistratieControleVoertuig(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBKEUTSP.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "Register Inbreuk op reglementen"
    Private Shared _CPSRegisterBBINBRRG As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieInbreukRegl")
    Private Shared _AVGRegisterBBINBRRG As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRegistratieInbreukRegl")

    Public Function RegisterRegistratieInbreukRegl(ByVal data As TDSInbreukRegl, ByVal user As String) As TDSInbreukRegl
        'Doel:   creeren en updaten van een inbreuk op reglementen
        'Auteur: Koen - Rajiv - 04/05/2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBINBRRG.CountSingleCall()
            _Timer = _AVGRegisterBBINBRRG.TimerStart()

            Dim myBP As New BP.RegisterRegistratieInbreukRegl(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterBBINBRRG.TimerStop(_Timer)
        End Try
    End Function
#End Region
#End Region

#Region "Register CodeTables"

#Region "RegisterAarden"
    Private Shared _CPSRegisterTY As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTY")
    Private Shared _AVGRegisterTY As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTY")

    Public Function RegisterAarden(ByVal data As TDSAarden, ByVal user As String) As TDSAarden

        'Doel:   creeren en updaten aarden
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterTY.CountSingleCall()
            _Timer = _AVGRegisterTY.TimerStart()

            Dim myBP As New BP.RegisterAarden(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterTY.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterOorzaken"
    Private Shared _CPSRegisterRD As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRD")
    Private Shared _AVGRegisterRD As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterRD")

    Public Function RegisterOorzaken(ByVal data As TDSOorzaken, ByVal user As String) As TDSOorzaken

        'Doel:   creeren en updaten oorzaken
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterRD.CountSingleCall()
            _Timer = _AVGRegisterRD.TimerStart()

            Dim myBP As New BP.RegisterOorzaken(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterRD.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterInterventietype"
    Private Shared _CPSRegisterINTVTY As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTVTY")
    Private Shared _AVGRegisterINTVTY As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTVTY")

    Public Function RegisterInterventietype(ByVal data As TDSIntvType, ByVal user As String) As TDSIntvType

        'Doel:   creeren en updaten interventietypes
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINTVTY.CountSingleCall()
            _Timer = _AVGRegisterINTVTY.TimerStart()

            Dim myBP As New BP.RegisterInterventietypes(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterINTVTY.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterAfdelingen"
    Private Shared _CPSRegisterAFD As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterAFD")
    Private Shared _AVGRegisterAFD As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterAFD")

    Public Function RegisterAfdelingen(ByVal data As TDSAfdelingen, ByVal user As String) As TDSAfdelingen

        'Doel:   creeren en updaten afdelingen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterAFD.CountSingleCall()
            _Timer = _AVGRegisterAFD.TimerStart()

            Dim myBP As New BP.RegisterAfdelingen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterAFD.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterEenheden"
    Private Shared _CPSRegisterEH As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterEH")
    Private Shared _AVGRegisterEH As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterEH")

    Public Function RegisterEenheden(ByVal data As TDSEenheden, ByVal user As String) As TDSEenheden

        'Doel:   creeren en updaten eenheden
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterEH.CountSingleCall()
            _Timer = _AVGRegisterEH.TimerStart()

            Dim myBP As New BP.RegisterEenheden(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterEH.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterArtikelgroepen"
    Private Shared _CPSRegisterART As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterART")
    Private Shared _AVGRegisterART As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterART")

    Public Function RegisterArtikelgroepen(ByVal data As TDSArtikelgroep, ByVal user As String) As TDSArtikelgroep

        'Doel:   creeren en updaten artikelgroepen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterART.CountSingleCall()
            _Timer = _AVGRegisterART.TimerStart()

            Dim myBP As New BP.RegisterArtikelgroepen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterART.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterInbreuktypes"
    Private Shared _CPSRegisterINBR As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINBR")
    Private Shared _AVGRegisterINBR As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINBR")

    Public Function RegisterInbreuktypes(ByVal data As TDSInbrType, ByVal user As String) As TDSInbrType

        'Doel:   creeren en updaten inbreuktypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINBR.CountSingleCall()
            _Timer = _AVGRegisterINBR.TimerStart()

            Dim myBP As New BP.RegisterInbreuktypes(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterINBR.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterRegistratietypes"
    Private Shared _CPSRegisterREG As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterREG")
    Private Shared _AVGRegisterREG As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterREG")

    Public Function RegisterRegistratietypes(ByVal data As TDSRegType, ByVal user As String) As TDSRegType

        'Doel:   creeren en updaten inbreuktypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterREG.CountSingleCall()
            _Timer = _AVGRegisterREG.TimerStart()

            Dim myBP As New BP.RegisterRegistratietypes(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterREG.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterIndividutypes"
    Private Shared _CPSRegisterIND As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterIND")
    Private Shared _AVGRegisterIND As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterIND")

    Public Function RegisterIndividutypes(ByVal data As TDSIndividuType, ByVal user As String) As TDSIndividuType

        'Doel:   creeren en updaten individutypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterIND.CountSingleCall()
            _Timer = _AVGRegisterIND.TimerStart()

            Dim myBP As New BP.RegisterIndividutypes(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterIND.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterInbreukartikelen"
    Private Shared _CPSRegisterINBRART As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINBRART")
    Private Shared _AVGRegisterINBRART As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINBRART")

    Public Function RegisterInbreukartikelen(ByVal data As TDSInbrArt, ByVal user As String) As TDSInbrArt

        'Doel:   creeren en updaten inbreukartikelen
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINBRART.CountSingleCall()
            _Timer = _AVGRegisterINBRART.TimerStart()

            Dim myBP As New BP.RegisterInbreukartikelen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterINBRART.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterTypesBetrokkenen"
    Private Shared _CPSRegisterTYBTRK As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTYBTRK")
    Private Shared _AVGRegisterTYBTRK As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTYBTRK")

    Public Function RegisterTypesBetrokkenen(ByVal data As TDSTypeBetrokkene, ByVal user As String) As TDSTypeBetrokkene

        'Doel:   creeren en updaten types betrokkenen
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterTYBTRK.CountSingleCall()
            _Timer = _AVGRegisterTYBTRK.TimerStart()

            Dim myBP As New BP.RegisterTypesBetrokkenen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterTYBTRK.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterTypesVoertuigen"
    Private Shared _CPSRegisterTYTSP As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTYTSP")
    Private Shared _AVGRegisterTYTSP As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterTYTSP")

    Public Function RegisterTypesVoertuigen(ByVal data As TDSVoertuigTypes, ByVal user As String) As TDSVoertuigTypes

        'Doel:   creeren en updaten types voertuigen
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterTYBTRK.CountSingleCall()
            _Timer = _AVGRegisterTYTSP.TimerStart()

            Dim myBP As New BP.RegisterTypesVoertuigen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterTYTSP.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterAanspreektitels"
    Private Shared _CPSRegisterINDGSL As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINDGSL")
    Private Shared _AVGRegisterINDGSL As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINDGSL")

    Public Function RegisterAanspreektitels(ByVal data As TDSAanspreektitel, ByVal user As String) As TDSAanspreektitel

        'Doel:   creeren en updaten aanspreektitels
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINDGSL.CountSingleCall()
            _Timer = _AVGRegisterINDGSL.TimerStart()

            Dim myBP As New BP.RegisterAanspreektitels(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterINDGSL.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterPloeg"
    Private Shared _CPSRegisterPLG As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterPLG")
    Private Shared _AVGRegisterPLG As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterPLG")

    Public Function RegisterPloeg(ByVal data As TDSPloeg, ByVal user As String) As TDSPloeg

        'Doel:   creeren en updaten ploegen
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterPLG.CountSingleCall()
            _Timer = _AVGRegisterPLG.TimerStart()

            Dim myBP As New BP.RegisterPloeg(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterPLG.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterSchadeAan"
    Private Shared _CPSRegisterSCAD As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterSCAD")
    Private Shared _AVGRegisterSCAD As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterSCAD")

    Public Function RegisterSchadeAan(ByVal data As TDSScadObjecten, ByVal user As String) As TDSScadObjecten

        'Doel:   creeren en updaten SchadeAan
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterSCAD.CountSingleCall()
            _Timer = _AVGRegisterSCAD.TimerStart()

            Dim myBP As New BP.RegisterSchadeAan(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterSCAD.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterGebruikVoertuig"
    Private Shared _CPSRegisterGEBR As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterGEBR")
    Private Shared _AVGRegisterGEBR As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterGEBR")

    Public Function RegisterGebruikVoertuig(ByVal data As TDSGebruikVoertuig, ByVal user As String) As TDSGebruikVoertuig

        'Doel:   creeren en updaten GebruikVoertuig
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterGEBR.CountSingleCall()
            _Timer = _AVGRegisterGEBR.TimerStart()

            Dim myBP As New BP.RegisterGebruikVoertuig(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterGEBR.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterWerfvoertuig"
    Private Shared _CPSRegisterWRF As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterWRF")
    Private Shared _AVGRegisterWRF As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterWRF")

    Public Function RegisterWerfvoertuig(ByVal data As TDSWerfVoertuig, ByVal user As String) As TDSWerfVoertuig

        'Doel:   creeren en updaten werfvoertuigen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterWRF.CountSingleCall()
            _Timer = _AVGRegisterWRF.TimerStart()

            Dim myBP As New BP.RegisterWerfVoertuigen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterWRF.TimerStop(_Timer)
        End Try
    End Function
#End Region
#Region "RegisterInterventieartikelen"
    Private Shared _CPSRegisterINTART As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTART")
    Private Shared _AVGRegisterINTART As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterINTART")

    Public Function RegisterInterventieartikelen(ByVal data As TDSIntvArt, ByVal user As String) As TDSIntvArt

        'Doel:   creeren en updaten interventieartikelen
        'Auteur: Koen/Rajiv - 02/05/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINTART.CountSingleCall()
            _Timer = _AVGRegisterINTART.TimerStart()

            Dim myBP As New BP.RegisterInterventieArtikelen(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterINTART.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Register registratietype dagverslag"
    Private Shared _CPSRegisterBBDGTYREG As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.registerDagverslagRegistratieType")
    Private Shared _AVGRegisterBBDGTYREG As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.registerDagverslagRegistratieType")

    Public Function RegisterDagverslagRegistratieType(ByVal data As TDSDagverslagRegistratieType, ByVal user As String) As TDSDagverslagRegistratieType
        'Doel: creëren en updaten dagverslag registratietype
        'Auteur: Dien - okt. 2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBDGTYREG.CountSingleCall()
            _Timer = _AVGRegisterBBDGTYREG.TimerStart()

            Dim myBP As New BP.RegisterDagverslagRegistratieTypes(data, user)
            myBP.Execute()
            Return myBP.Result
        Finally
            'Stop Timer 
            _AVGRegisterBBDGTYREG.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Register dagverslag inlichtingenType (rubriek)"
    Private Shared _CPSRegisterBBDGPODL As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBDGPODL")
    Private Shared _AVGRegisterBBDGPODL As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBDGPODL")

    Public Function RegisterDagverslagInlichtingType(ByVal data As TDSDagverslagInlichtingType, ByVal user As String) As TDSDagverslagInlichtingType
        'Doel: creëren en updaten dagverslag inlichtingtype
        'Auteur: Dien -okt. 2006
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBDGPODL.CountSingleCall()
            _Timer = _AVGRegisterBBDGPODL.TimerStart()

            Dim myBP As New BP.RegisterDagverslagInlichtingType(data, user)
            myBP.Execute()
            Return myBP.Result
        Finally
            'Stop timer
            _AVGRegisterBBDGPODL.TimerStop(_Timer)
        End Try
    End Function

#End Region

#Region "Register personeel"
    Private Shared _CPSRegisterBBBWPERS As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBBWPERS")
    Private Shared _AVGRegisterBBBWPERS As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBBWPERS")

    Public Function RegisterPersoneel(ByVal data As TDSBBBWPERS, ByVal user As String) As TDSBBBWPERS
        'Doel: creëren en updaten personeelsgegevens
        'Auteur: Siddien - okt. 2006
        Dim _Timer As Long
        Try
            'Start timer
            _CPSRegisterBBBWPERS.CountSingleCall()
            _Timer = _AVGRegisterBBBWPERS.TimerStart

            Dim myBP As New BP.RegisterPersoneel(data, user)
            myBP.Execute()

            Return myBP.Result
        Finally
            'Stop timer
            _AVGRegisterBBBWPERS.TimerStop(_Timer)
        End Try
    End Function
#End Region
#End Region

#Region "Register AFDAMC"
    Public Function RegisterAFDAMC(ByVal data As TDSBBAFDAMC, ByVal user As String) As TDSBBAFDAMC
        'Auteur: DIEN-mei09
        Dim myBP As New BP.RegisterAFDAMC(data, user)
        myBP.Execute()
        Return myBP.Result
    End Function
#End Region

#Region "RegisterStock"
    Private Shared _CPSRegisterStock As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterStock")
    Private Shared _AVGRegisterStock As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterStock")

    Public Function RegisterStock(ByVal data As TDSVerbruiksArtikel, ByVal user As String) As TDSVerbruiksArtikel

        'Doel:   creeren en updaten Stock
        'Auteur: Koen/Rajiv - 24/04/2006

        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterWRF.CountSingleCall()
            _Timer = _AVGRegisterStock.TimerStart()

            Dim myBP As New BP.RegisterStock(data, user)
            myBP.Execute()
            Return myBP.Result

        Finally
            'Stop Timer
            _AVGRegisterStock.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "update individu"
    Private Shared _CPSRegisterINDBest As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterIndBest")
    Private Shared _AVGRegisterINDBest As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterIntBest")

    Public Sub updateIndividuBestemmeling(ByVal id_ind As Integer, _
                                          ByVal mailAdres As String, _
                                          ByVal user As String)
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterINDBest.CountSingleCall()
            _Timer = _AVGRegisterINDBest.TimerStart()

            'opvragen van record individu
            Dim data As TDSIndividuen = Me.GetIndividu(id_ind)
            If data.BBIND.Count = 1 Then
                'Set bestemmeling op true
                'mailadres invullen
                data.BBIND(0).BST_IND = True
                data.BBIND(0).AD_EMAL_IND = mailAdres
                data.BBIND(0).BST_ACTIVE = True

                Dim myBP As New BP.RegisterIndividu(data, user)
                myBP.Execute()
            Else
                Throw New ApplicationException("Individu bestaat niet.")
            End If
        Finally
            'Stop Timer
            _AVGRegisterINDBest.TimerStop(_Timer)
        End Try
    End Sub
#End Region

#Region "firma's"
    Private Shared _CPSRegisterBBFRM As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBFRM")
    Private Shared _AVGRegisterBBFRM As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBFRM")

    Public Function RegisterFirmas(ByVal data As TDSFirmas, ByVal user As String) As TDSFirmas
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBFRM.CountSingleCall()
            _Timer = _AVGRegisterBBFRM.TimerStart()

            Dim myBP As New BP.RegisterFirmas(data, user)
            myBP.Execute()
            Return myBP.Result
        Finally
            'Stop Timer
            _AVGRegisterBBFRM.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Verzekering firma's"
    Private Shared _CPSRegisterBBVZKFRM As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterVerzFirmas")
    Private Shared _AVGRegisterBBVZKFRM As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterVerzFirmas")

    Public Function RegisterVerzFirmas(ByVal data As TDSVerzFirmas, ByVal user As String) As TDSVerzFirmas
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterBBVZKFRM.CountSingleCall()
            _Timer = _AVGRegisterBBVZKFRM.TimerStart()

            Dim myBP As New BP.RegisterVerzFirma(data, user)
            myBP.Execute()
            Return myBP.Result
        Finally
            'Stop Timer
            _AVGRegisterBBVZKFRM.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Register Voertuigen"
    Private Shared _CPSRegisterBBTSP As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterVoertuig")
    Private Shared _AVGRegisterBBTSP As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterVoertuig")

    Public Function RegisterVoertuigen(ByVal data As TDSVoertuigen, ByVal user As String) As TDSVoertuigen
        Dim _Timer As Long
        Try
            'Start Timer 
            _CPSRegisterBBTSP.CountSingleCall()
            _Timer = _AVGRegisterBBTSP.TimerStart()

            Dim myBP As New BP.RegisterVoertuigen(data, user)
            myBP.Execute()

            Return myBP.Result
        Finally
            'Stop Timer 
            _AVGRegisterBBTSP.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "Register individu"
    Private Shared _CPSRegisterBBINDOne As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBINDOne")
    Private Shared _AVGRegisterBBINDOne As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.RegisterBBINDone")

    Public Function RegisterIndividu(ByVal data As TDSIndividuen, ByVal user As String) As TDSIndividuen
        Dim _Timer As Long
        Try
            'Start timer
            _CPSRegisterBBINDOne.CountSingleCall()
            _Timer = _AVGRegisterBBINDOne.TimerStart()

            Dim mybp As New BP.RegisterIndividu(data, user)
            mybp.Execute()
            Return mybp.Result
        Finally
            'Stop timer
            _AVGRegisterBBINDOne.TimerStop(_Timer)
        End Try
    End Function
#End Region

    Private Shared _CPSRegisterDagverslagPersoneel As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBDGPERS")
    Private Shared _AVGRegisterDagverslagPersoneel As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBDGPERS")

    Public Function RegisterDagverslagPersoneel(ByVal data As TDSDagverslagPersoneel, ByVal user As String) As TDSDagverslagPersoneel
        Dim timer As Long
        Try
            'Start timer
            _CPSRegisterDagverslagPersoneel.CountSingleCall()
            timer = _AVGRegisterDagverslagPersoneel.TimerStart()

            Dim mybp As New BP.RegisterDagverslagPersoneel(data, user)
            mybp.Execute()

            Return mybp.Result
        Finally
            'Stop timer
            _AVGRegisterDagverslagPersoneel.TimerStop(timer)
        End Try
    End Function

#Region "Dagverslag inlichtingen"
    'Siddien - okt. 2006
    Private Shared _CPSRegisterDagverslagInlichtingen As CallsPerSecondCounter = New CallsPerSecondCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBDGPO")
    Private Shared _AVGRegisterDagverslagInlichtingen As AverageTimeCounter = New AverageTimeCounter(CurrentApp, PerformanceConstants.PFSLayerName, "BS.BBDGPO")

    Public Function RegisterDagverslagInlichtingen(ByVal data As TDSDagverslagInlichtingen, ByVal user As String) As TDSDagverslagInlichtingen
        Dim _Timer As Long
        Try
            'Start Timer
            _CPSRegisterDagverslagInlichtingen.CountSingleCall()
            _Timer = _AVGRegisterDagverslagInlichtingen.TimerStart()

            Dim myBp As New BP.RegisterDagverslagInlichting(data, user)
            myBp.Execute()

            Return myBp.Result()
        Finally
            'Stop timer 
            _AVGRegisterDagverslagInlichtingen.TimerStop(_Timer)
        End Try
    End Function
#End Region

#Region "dagverslag registratietypes"
    Public Function GetRegistratieTypesDagverslag() As TDSDagverslagRegistratieType
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDagverslagRegistratieType

            result.Merge(myBc.GetRegistratieTypesDagverslag)

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "Dagverslagen personeel"
    'SIDDIEN - okt. 2006
    Public Function GetDagverslagenPersoneel(ByVal datumVanaf As DateTime) As TDSDagverslagPersoneel
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSDagverslagPersoneel

            result.Merge(myBc.GetDagverslagenPersoneel(datumVanaf))

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Laatste stamnummer"
    'Siddien - okt. 2006
    Public Function GetLastStamnummer() As Integer
        Try
            Dim myBc As New GetDataBbw

            Return myBc.GetLastStamnummer()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

    'Siddien -okt. 2006
    Public Function BestaatDagverslagInlichtingVoorDag(ByVal datum As DateTime) As Boolean
        Try
            Dim myBc As New GetDataBbw

            Dim atlVerslagInlichtingen As Integer = myBc.GetAtlDagverslagInlichtingenVoorDag(datum)

            If atlVerslagInlichtingen = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

#Region "Maandverslag Bewaking - Inbreuk reglementen"
    Public Function GetLijstInbreukReglementen() As TDSLijstInbreukRegl
        'Doel:   Lijst inbreuk reglementen (voor maandrapporten)
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSLijstInbreukRegl

            result.Merge(myBc.GetLijstInbreukReglementen)

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Lijst Snelheidsovertredingen"

#End Region

#Region "Verslag Bewaking - Diefstallen per trimester"
    Public Function GetDiefstallenPerTrimester() As TDSTrimesterDiefstal
        'Doel:   Lijst diefstallen per trimester (voor rapporten)
        'Auteur: Mieke Duynslager - 14/06/2007

        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSTrimesterDiefstal

            result.Merge(myBc.GetDiefstallenPerTrimester)

            Return result
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Dagverslag personeel"
    'Dien - jan 2006
    Public Sub ToevoegenDagverslagPersoneel(ByVal datum As DateTime)
        Try
            If dagVerslagPersoneelReedsDoorgestuurd(datum) = False Then
                Me.SvcUpdateData.ToevoegenDagverslagPersoneel(datum)
            End If
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Sub

    Public Function dagVerslagPersoneelReedsDoorgestuurd(ByVal datum As DateTime) As Boolean
        'Dien - jan 2006
        Try
            Dim o As TDSBBDGPERSVZ
            o = Me.SvcGetData.GetDagverslagenPersoneelVerstuurd(datum)
            If o.BBDGPERSVZ.Count > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "Bestemmelingen"
    Public Function GetBestemmelingenAfdeling(ByVal id_afd As Integer) As BS.TDSBeheerAFDAMC
        Try
            Dim myBc As New GetDataBbw

            Return myBc.GetBestemmelingenAfdeling(id_afd)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod()), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "AFDAMC"
    ''' <summary>
    ''' Update of AMC's didn't work - workaround
    ''' </summary>
    ''' <param name="aID_AFD"></param>
    ''' <param name="aID_IND"></param>
    ''' <remarks>Nancy Coppens - 22/02/2010</remarks>
    Public Sub UpdateAFDAMC(ByVal aID_AFD As Integer, ByVal aID_IND As Integer, ByVal aOldID_IND As Integer)
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateAFDAMC(aID_AFD, aID_IND, aOldID_IND)

        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "CHIP Data"
    ''' <summary>
    ''' Doel: Lijst van Klachten, geldig voor CHIP systeem
    ''' </summary>
    ''' <param name="aDateFrom">yyyy-MM-dd</param>
    ''' <param name="aDateTo">yyyy-MM-dd</param>
    ''' <returns></returns>
    ''' <remarks>Auteur: Lawrence Verbruggen - 21/02/2011</remarks>
    Public Function GetChipComplaints(ByVal aDateFrom As String, ByVal aDateTo As String) As TDSChipKlachten
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSChipKlachten

            result.Merge(myBc.GetChipComplaints(aDateFrom, aDateTo))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    Public Function GetChipComplaints_SAPfirmanr(ByVal aDateFrom As String, ByVal aDateTo As String, ByVal aSAPfirmanr As String) As TDSChipKlachten
        'naco - 17/11/2017
        Try
            Dim myBc As New GetDataBbw
            Dim result As New TDSChipKlachten

            result.Merge(myBc.GetChipComplaints_SAPfirmanr(aDateFrom, aDateTo, aSAPfirmanr))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Doel: Update van de registratietabel met CHIP data
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aSAP_SUPPLIER_ID"></param>
    ''' <param name="aDT_CHIP"></param>
    ''' <remarks>Auteur: Lawrence Verbruggen - 03/03/2011</remarks>
    Public Sub UpdateCHIP(ByVal aID_REG As Integer, ByVal aSAP_SUPPLIER_ID As String, _
                            ByVal aDT_CHIP As DateTime, ByVal aOPM_CHIP As String)
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateCHIP(aID_REG, aSAP_SUPPLIER_ID, aDT_CHIP, aOPM_CHIP)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aRemark"></param>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 05/12/2017</remarks>
    Public Function CHIPUpdate_BBW_ReportReadOK(ByVal aID_REG As Long, ByVal aRemark As String) As String
        Try
            Dim myBc As New DMC.UpdateDataBBW
            Return myBc.CHIPUpdate_BBW_ReportReadOK(aID_REG, aRemark)

        Catch ex As Exception
            Throw
        End Try
    End Function


    ''' <summary>
    ''' Update of BBEWREG with CHIP data
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aCHIP_YN"></param>
    ''' <remarks>Lawrence - 04/03/2011</remarks>
    Public Sub UpdateCHIP(ByVal aID_REG As Integer, ByVal aCHIP_YN As Boolean)
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateCHIP(aID_REG, aCHIP_YN)

        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "Snelheidsovertredingen"
    ''' <summary>
    ''' Ingegeven Datums opslaan voor een rijverbod ten gevolge van een snelheidsovertreding hoger dan 70 km/u
    ''' </summary>
    ''' <param name="aID_REG">Registratie Id</param>
    ''' <param name="aRijverbodVan">Start van het rijverbod</param>
    ''' <param name="aRijverbodTot">Einde van het rijverbod</param>
    ''' <param name="aAfspraakPBH">Afspraak met personeelsbeheer</param>
    ''' <remarks></remarks>
    Public Sub UpdateRijverbod(ByVal aID_REG As Integer, ByVal aRijverbodVan As DateTime, _
                                              ByVal aRijverbodTot As DateTime, ByVal aAfspraakPBH As DateTime, _
                                              ByVal aConnectionString As String, ByVal aContactId As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateRijverbod(aID_REG, aRijverbodVan, aRijverbodTot, aAfspraakPBH)

            Dim myBc2 As New GetDataBbw()
            Dim datAfspraak As DateTime = myBc2.GetSnelheidsovertredingPBHAfspraak(aID_REG, aConnectionString)
            'Dim StamNr As Integer = myBc2.GetOvertrederInbreukReglement(aID_REG, aConnectionString)

            Dim mySDbc As New DMC.UpdateDataSoDie(_dataConfiguratie.BBCONF.FindByGR_SLESLE("SODIE", "ConnectionString").WD.Replace("456", "TOMMY"))
            mySDbc.UpdateSoDieContactDatum(aContactId, datAfspraak)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' The update of a sanction according to the values given in print-screen
    ''' </summary>
    ''' <param name="aID_REG">Id of Registration</param>
    ''' <param name="aPrintDate">Date of printing</param>
    ''' <param name="aDoubleUp">Double sanction</param>
    ''' <param name="aKindOfSanction">Kind of sanction</param>
    ''' <param name="aDuration">The duration of the sanction</param>
    ''' <param name="aSanctionId">The id of the sanction</param>
    ''' <param name="aRevokedDrivingFrom">Access to AM revoked from</param>
    ''' <param name="aRevokedDrivingTo">Access to AM revoked to</param>
    ''' <param name="aMeetingPBH">Date of meeting at PBH</param>
    ''' <remarks></remarks>
    Public Sub UpdateOvertredingPrint(ByVal aID_REG As Integer, ByVal aPrintDate As DateTime,
                                      ByVal aDoubleUp As Boolean, ByVal aKindOfSanction As String,
                                      ByVal aDuration As Integer, ByVal aSanctionPeriod As String,
                                      ByVal aSanctionId As Integer,
                                      ByVal aRevokedDrivingFrom As DateTime,
                                      ByVal aRevokedDrivingTo As DateTime,
                                      ByVal aMeetingPBH As DateTime,
                                      ByVal aDatumBrief As DateTime,
                                      ByVal aFirmId As Integer, ByVal aTaal As String,
                                      ByVal aPersonalId As Integer)

        Try
            Dim myBc As New DMC.UpdateDataBBW
            If (aRevokedDrivingFrom.Date <> aRevokedDrivingTo.Date) Then
                myBc.UpdateOvertredingPrint(aID_REG, aPrintDate, aDoubleUp, aKindOfSanction, aDuration, aSanctionPeriod, aSanctionId, aFirmId, aTaal,
                            aDatumBrief, aRevokedDrivingFrom, aRevokedDrivingTo, aMeetingPBH)
            Else
                myBc.UpdateOvertredingPrint(aID_REG, aPrintDate, aDoubleUp, aKindOfSanction, aDuration, aSanctionPeriod, aSanctionId, aFirmId, aTaal,
                            aDatumBrief, Nothing, Nothing, Nothing)
            End If

            'Alterations Mai 2013.
            'Saving into Sodie now only possible when printing the infraction
            Dim tdsSodData As New TDSINBRVASOD
            tdsSodData.Merge(SvcGetData.GetSodieData(aID_REG, MyConnection))

            If (tdsSodData.BBINBRVA.Rows.Count > 0) Then
                If (ValidateSodieInteraction(tdsSodData.BBINBRVA(0))) Then
                    Dim newContactId As Integer
                    Dim conversionDictionary As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
                    'Ophalen koppeling tussen contactsoort (Sodie) en inbreukklasse (BBW) 
                    conversionDictionary = SvcGetData.GetSodieARKindOfContactTranslation(MyConnection)
                    'Wegschrijven naar Sodie
                    'Benodigde waarden stamnummer, artikelnr van overtreding (voor omschrijving) , contactsoort (geconverteerd van inbreukklasse)
                    newContactId = InsertSoDie(aPersonalId, tdsSodData.BBINBRVA(0).NR_ART_INBR, conversionDictionary(CInt(tdsSodData.BBINBRVA(0).InbreukKlasseID)))
                        UpdateRegSoDieContactId(aID_REG, newContactId)
                End If
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    'This function validates whether there should be interaction with Sodie
    'Stijn Vranken : Juni 2013
    Private Function ValidateSodieInteraction(ByVal pTdsRow As TDSINBRVASOD.BBINBRVARow) As Boolean
        'SodieId al aanwezig?
        If Not (pTdsRow.IsSODIE_CNT_IDNull()) Then
            Return False
        End If
        'Al opgeslagen geweest
        'If Not (pTdsRow.IsPBH_TMS_PRINTNull()) Then
        '    Return False
        'End If
        ' Geldige Sanctie
        If (pTdsRow.IsSanctionIDNull) Then
            Return False
        Else
            'Niet gesanctioneerde overtredingen moeten niet worden weggeschreven.
            If (pTdsRow.SanctionID = 0) Then
                Return False
            End If
        End If
        Return True
    End Function

    ''' <summary>
    ''' Ingegeven Datums opslaan voor een rijverbod ten gevolge van een snelheidsovertreding hoger dan 70 km/u
    ''' </summary>
    ''' <param name="aID_REG">Registratie Id</param>
    ''' <remarks>naco - 30/05/2011</remarks>
    Public Sub UpdateRijverbodLegeDatums(ByVal aID_REG As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateRijverbodLegeDatums(aID_REG)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Opslaan van het tijdstip van afdruk
    ''' </summary>
    ''' <param name="aID_REG">Registratie Id</param>
    ''' <param name="aAfdruk">Tijdstip van de afdruk</param>
    ''' <remarks></remarks>
    Public Sub UpdateSnelheidsovertredingPrint(ByVal aID_REG As Integer, ByVal aAfdruk As DateTime, _
                                              ByVal aConnectionString As String, ByVal aContactId As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011
        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateSnelheidsovertredingPrint(aID_REG, aAfdruk)

            Dim myBc2 As New GetDataBbw()
            Dim datAfspraak As DateTime = myBc2.GetSnelheidsovertredingPBHAfspraak(aID_REG, aConnectionString)
            'Dim StamNr As Integer = myBc2.GetOvertrederInbreukReglement(aID_REG, aConnectionString)

            Dim _dataConfiguratie As TDSConfiguratie
            _dataConfiguratie = GetConfigurationSettings()
            Dim mySDbc As New DMC.UpdateDataSoDie(MySodieConnection)
            mySDbc.UpdateSoDieContactDatum(aContactId, datAfspraak)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Opslaan van snelheidsovertredings-contact voor de SOciale DIEnst
    ''' </summary>
    ''' <param name="aStamNr">StamNr van de overtreder</param>
    ''' <remarks></remarks>
    Public Function InsertSoDie(ByVal aStamNr As Integer, ByVal aBbwSanctieOmschr As String, ByVal aSoortId As Integer) As Integer
        'Auteur: Lawrence Verbruggen - 19/04/2011
        Try
            Dim newContactID As Integer
            newContactID = SvcUpdateDataSodie.InsertSoDie(aStamNr, aBbwSanctieOmschr, aSoortId)
            Return newContactID
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub UpdateRegSoDieContactId(aRegID As Integer, newContactId As Integer)
        Try
            Dim myBc As New DMC.UpdateDataBBW()
            myBc.UpdateSnelheidsovertredingSoDieContactID(aRegID, newContactId)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function updates the date on which PEB sent the letter to the firm
    ''' </summary>
    ''' <param name="aID_REG">The id of the registration</param>
    ''' <param name="aDateSent">The date on which the letter was sent</param>
    ''' <remarks>02/05/2013 SIDVRST</remarks>
    Public Sub UpdateDateLetterSent(ByVal aID_REG As Integer, ByVal aDateSent As DateTime)
        Try
            Dim myBc As New DMC.UpdateDataBBW()
            myBc.UpdateDateLetterSent(aID_REG, aDateSent)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function clears all sanctions linked to a specific registration
    ''' </summary>
    ''' <param name="aID_Reg">The id of the registration</param>
    ''' <remarks>June 2013 Stijn V.</remarks>
    Public Sub ClearSanction(ByVal aID_Reg As Integer)


        Try
            Dim myBc As New DMC.UpdateDataBBW()
            myBc.ClearSanction(aID_Reg)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function add a remark to a specified infraction
    ''' </summary>
    ''' <param name="aID_Reg">The id of the registration</param>
    ''' <remarks>June 2013 Stijn V.</remarks>
    Public Sub InsertRemark(ByVal aID_Reg As Integer, ByVal aRemark As String)
        Try
            Dim myBc As New DMC.UpdateDataBBW()
            myBc.InsertRemark(aID_Reg, aRemark)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function makes a report invalid
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    ''' <param name="remark">A remark why the report has been invalidated</param>
    ''' <param name="user">The user who has requested the invalidation</param>
    Public Sub InvalidateReport(ByVal idReg As Integer, ByVal remark As String, ByVal user As String)
        Try
            Dim myBc As New UpdateDataBBW()
            myBc.InvalidateReport(idReg, remark, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function checks whether a report has been invalidated
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    Public Function IsReportInvalid(ByVal idReg As Integer) As Boolean
        Try
            Return SvcGetData.IsReportInvalid(MyConnection, idReg)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Function


#End Region

    Function TestSoDie() As Boolean
        Try
            Dim dataConfiguratie As TDSConfiguratie
            dataConfiguratie = GetConfigurationSettings()
            Dim mySDbc As New UpdateDataSoDie(dataConfiguratie.BBCONF.FindByGR_SLESLE("SODIE", "ConnectionString").WD.Replace("456", "TOMMY"))

            If (mySDbc.TestSodie()) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

#Region "Brandweermateriaal - augustus 2011"

    ''' <summary>
    ''' Get list of fire brigade material (fire extinguishers, fire hydrants, ...).
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks>naco - gmae - 19/08/2011</remarks>
    Public Function GetBrandweerMateriaalLijst(ByVal dbConnection As String) As TDSBrandweerMateriaal

        Try
            Dim result As New TDSBrandweerMateriaal
            result.Merge(GetDataBbw.GetBrandweerMateriaalLijst(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Get a piece of fire brigade material (fire extinguishers, fire hydrants, ...) using the PK.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="typeMateriaal"></param>
    ''' <param name="volgnummer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerMateriaalByTypeVolgnr(ByVal dbConnection As String, ByVal typeMateriaal As Integer, ByVal volgnummer As Integer) As TDSBrandweerMateriaalItem

        Try
            Dim result As New TDSBrandweerMateriaalItem
            result.Merge(GetDataBbw.GetBrandweerMateriaalByTypeVolgnr(dbConnection, typeMateriaal, volgnummer))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of types of fire brigade material (fire extinguishers, fire hydrants, ...).
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerMaterialTypes(ByVal dbConnection As String) As TDSBrandweerMateriaalTypes

        Try
            Dim result As New TDSBrandweerMateriaalTypes
            result.Merge(GetDataBbw.GetBrandweerMaterialTypes(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of types of fire extinguishers.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerExtinguisherTypes(ByVal dbConnection As String) As TDSBrandweerExtinguisherTypes

        Try
            Dim result As New TDSBrandweerExtinguisherTypes
            result.Merge(GetDataBbw.GetBrandweerExtinguisherTypes(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of suppliers of fire brigade material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerSuppliers(ByVal dbConnection As String) As TDSBrandweerLeveranciers

        Try
            Dim result As New TDSBrandweerLeveranciers
            result.Merge(GetDataBbw.GetBrandweerSuppliers(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of departments - in the point of view of the fire brigade.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerDepartments(ByVal dbConnection As String) As TDSBrandweerAfdelingen

        Try
            Dim result As New TDSBrandweerAfdelingen
            result.Merge(GetDataBbw.GetBrandweerDepartments(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of the stati for the fire brigade material.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerStatus(ByVal dbConnection As String) As TDSBrandweerStatus

        Try
            Dim result As New TDSBrandweerStatus
            result.Merge(GetDataBbw.GetBrandweerStatus(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of the managers for the fire brigade material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerManagers(ByVal dbConnection As String) As TDSBrandweerBeheerderAfdeling

        Try
            Dim result As New TDSBrandweerBeheerderAfdeling
            result.Merge(GetDataBbw.GetBrandweerManagers(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get list of the send history for the fire brigade material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerVerzending(ByVal dbConnection As String) As TDSBrandweerVerzending

        Try
            Dim result As New TDSBrandweerVerzending
            result.Merge(GetDataBbw.GetBrandweerVerzending(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Check if a combination of material type, location and location number exists in the database.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="typeMateriaal">The ID of the type of material.</param>
    ''' <param name="locatieId">The ID of the location.</param>
    ''' <param name="locatieNr">The number for the location.</param>
    ''' <returns>True if such a material exists, false otherwise.</returns>
    ''' <remarks></remarks>
    Public Function BrandweerMateriaalBestaat(ByVal dbConnection As String, ByVal typeMateriaal As Integer, ByVal locatieId As Integer, ByVal locatieNr As String) As Boolean

        Try
            Return GetDataBbw.BrandweerMateriaalBestaat(dbConnection, typeMateriaal, locatieId, locatieNr)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Save the information on a piece of fire brigade material (fire extinguishers, fire hydrants, ...).
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="materiaal">The information on the material.</param>
    ''' <returns>True if the material was successfully saved.</returns>
    ''' <remarks></remarks>
    Public Function SaveBrandweerMateriaal(ByVal dbConnection As String, ByVal materiaal As TDSBrandweerMateriaalItem) As Boolean

        Try
            Return GetDataBbw.SaveBrandweerMateriaal(dbConnection, materiaal)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    Public Function UpdateMateriaalDateDeleted(ByVal dbConnection As String, ByVal aType As Integer, ByVal aVolgnr As Integer, ByVal aUserDeleted As String) As Boolean
        'naco - 10/07/2017 - actie vergeten bij overzetten VB6 -> VB.net
        'Materiaal deleten => DateDeleted (en user) invullen

        Try
            Return GetDataBbw.UpdateMateriaalDateDeleted(dbConnection, aType, aVolgnr, aUserDeleted)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Get material description for MateriaalVolgNr (necessary for Tijdelijk vervangen door)
    ''' eg. 3963 = COO 5 3
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <remarks></remarks>
    Public Function BrandweerGetMateriaalOmschr(ByVal dbConnection As String, ByVal aMateriaalvolgnr As Integer) As String

        Try
            Return GetDataBbw.BrandweerGetMateriaalOmschr(dbConnection, aMateriaalvolgnr)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return ""
        End Try
    End Function

    Public Function BrandweerMarkeerVervangMateriaal(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer, ByVal plaats As Integer) As Boolean

        Try
            Return GetDataBbw.BrandweerMarkeerVervangMateriaal(dbConnection, type, volgnr, plaats)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Unmark a piece of equipment as a temporary replacement.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <remarks></remarks>
    Public Function BrandweerVrijgaveVervangMateriaal(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer) As Boolean

        Try
            Return GetDataBbw.BrandweerVrijgaveVervangMateriaal(dbConnection, type, volgnr)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Get list of available fire extinguishers for temprorary replacements.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="type">The material type.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerVervangLijst(ByVal dbConnection As String, ByVal type As Integer) As TDSBrandweerMateriaal

        Try
            Dim result As New TDSBrandweerMateriaal
            result.Merge(GetDataBbw.GetBrandweerVervangLijst(dbConnection, type))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of all actions.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerActie() As TDSBrandweerActie

        Try
            Dim result As New TDSBrandweerActie
            result.Merge(GetDataBbw.GetBrandweerActie(MyConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of actions and measured weights for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer) As TDSBrandweerMateriaalActie

        Try
            Dim result As New TDSBrandweerMateriaalActie
            result.Merge(GetDataBbw.GetMateriaalActie(MyConnection, type, volgnr))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Store an action and measured weight for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <param name="datum"></param>
    ''' <param name="gewicht"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StoreMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime, ByVal actie As Integer?, ByVal gewicht As Decimal?) As Boolean

        Try
            Return GetDataBbw.StoreMateriaalActie(MyConnection, type, volgnr, datum, actie, gewicht)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Delete an action / measured weight for a piece of material.
    ''' </summary>
    ''' <param name="id">The ID of the action record.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteMateriaalActieById(ByVal id As Integer) As Boolean

        Try
            Return GetDataBbw.DeleteMateriaalActieById(MyConnection, id)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Delete an action / measured weight for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <param name="datum"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime) As Boolean

        Try
            Return GetDataBbw.DeleteMateriaalActie(MyConnection, type, volgnr, datum)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

#End Region

#Region "Brandweermateriaal - Rapporten"

    ''' <summary>
    ''' Get the overview of refilled fire extingoushers.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="jaar">The year for this report.</param>
    ''' <param name="perAfdeling">True = by department, False = by Type.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalHervuld(ByVal dbConnection As String, ByVal jaar As Integer, ByVal perAfdeling As Boolean) As TDSBrandweerReportHervuldeBlustoestellen

        Try
            Dim result As New TDSBrandweerReportHervuldeBlustoestellen

            Using ds As TDSBrandweerReportHervuldeBlustoestellen = GetReportsBBW.GetMateriaalHervuld(dbConnection, jaar, perAfdeling)

                Dim totaalSchriftelijk As Integer
                Dim totaalTelefonisch As Integer
                Dim totaalNietGemeld As Integer
                Dim totaalAantal As Integer
                Dim totaalRij As Integer

                For Each row As TDSBrandweerReportHervuldeBlustoestellen.ReportRow In ds.Report
                    totaalSchriftelijk += row.AantalSchriftelijk
                    totaalTelefonisch += row.AantalTelefonisch
                    totaalNietGemeld += row.AantalNietGemeld
                Next
                totaalAantal = totaalSchriftelijk + totaalTelefonisch + totaalNietGemeld

                For Each row As TDSBrandweerReportHervuldeBlustoestellen.ReportRow In ds.Report
                    totaalRij = row.AantalSchriftelijk + row.AantalTelefonisch + row.AantalNietGemeld
                    result.Report.AddReportRow(row.Label,
                                               row.AantalSchriftelijk, CDec(row.AantalSchriftelijk / totaalSchriftelijk),
                                               row.AantalTelefonisch, CDec(row.AantalTelefonisch / totaalTelefonisch),
                                               row.AantalNietGemeld, CDec(row.AantalNietGemeld / totaalNietGemeld),
                                               totaalRij, CDec(totaalRij / totaalAantal))
                Next
            End Using

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of materials that must be inspected.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="isVisueleControle">True = visuele controle, False = Poedercontrole</param>
    ''' <param name="datumVorigeControle">Datum waarvoor de vorige controle moet liggen.</param>
    ''' <returns>De lijst van materiaal dat geïnspecteerd moet worden.</returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalControleLijst(ByVal dbConnection As String, ByVal isVisueleControle As Boolean, ByVal datumVorigeControle As DateTime) As TDSBrandweerMateriaalControleLijst

        Try
            Dim result As New TDSBrandweerMateriaalControleLijst
            result.Merge(GetReportsBBW.GetMateriaalControleLijst(dbConnection, isVisueleControle, datumVorigeControle))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Save the list of materials that must be inspected.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="controleLijst">De list van geïnspecteerd materiaal</param>
    ''' <param name="isVisueleControle">True = visuele controle, False = Poedercontrole</param>
    ''' <param name="nieuweDatum">De datum waarop de controles uitgevoerd werden.</param>
    ''' <returns>True als de wijzigingen correct opgeslagen zijn.</returns>
    ''' <remarks></remarks>
    Public Function SaveMateriaalControleLijst(ByVal dbConnection As String, ByVal controleLijst As TDSBrandweerMateriaalControleLijst, ByVal isVisueleControle As Boolean, ByVal nieuweDatum As DateTime) As Boolean

        Try
            Return GetReportsBBW.SaveMateriaalControleLijst(dbConnection, controleLijst, isVisueleControle, nieuweDatum)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

#End Region

#Region "Brandweermateriaal - Verzending"

    ''' <summary>
    ''' Get the overview of material that has been shipped to the supplier.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVerzendingLijst(ByVal dbConnection As String) As TDSBrandweerVerzendingLijst

        Try
            Dim result As New TDSBrandweerVerzendingLijst
            result.Merge(GetVerzendingBBW.GetVerzendingLijst(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get a shipping record.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="id">The ID of the shipping record.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVerzending(ByVal dbConnection As String, ByVal id As Integer) As TDSBrandweerVerzending

        Try
            Dim result As New TDSBrandweerVerzending
            result.Merge(GetVerzendingBBW.GetVerzending(dbConnection, id))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Store the 'sent' information for a list of material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="verzending"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StoreVerzending(ByVal dbConnection As String, ByVal verzending As TDSBrandweerVerzending) As Boolean

        Try
            Return GetVerzendingBBW.StoreVerzending(dbConnection, verzending)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Delete the 'sent' information for a list of material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="verzending"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteVerzending(ByVal dbConnection As String, ByVal verzending As TDSBrandweerVerzending) As Boolean

        Try
            Return GetVerzendingBBW.DeleteVerzending(dbConnection, verzending)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

#End Region

#Region "Brandweermateriaal - Afdeling"

    ''' <summary>
    ''' Get the material for a given department.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="afdeling">Department ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAfdelingMateriaal(ByVal dbConnection As String, ByVal afdelingID1 As Integer, ByVal afdelingID2 As Integer, ByVal afdelingID3 As Integer) As TDSBrandweerAfdelingMateriaal

        Try
            Dim result As New TDSBrandweerAfdelingMateriaal
            result.Merge(GetAfdelingBBW.GetAfdelingMateriaal(dbConnection, afdelingID1, afdelingID2, afdelingID3))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the departemental manager for a given piece of material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="typeMatId">ID of the material type.</param>
    ''' <param name="volgnr">Sequence number of the material.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalBeheerderAfdeling(ByVal dbConnection As String, ByVal typeMatId As Integer, ByVal volgnr As Integer) As TDSBrandweerMateriaalBeheerderAfdeling

        Try
            Dim result As New TDSBrandweerMateriaalBeheerderAfdeling
            result.Merge(GetAfdelingBBW.GetMateriaalBeheerderAfdeling(dbConnection, typeMatId, volgnr))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Update the departemental manager for a given piece of material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="info"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UpdateMateriaalBeheerderAfdeling(ByVal dbConnection As String, ByVal info As TDSBrandweerMateriaalBeheerderAfdeling) As Boolean

        Try
            Return GetAfdelingBBW.UpdateMateriaalBeheerderAfdeling(dbConnection, info)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Update the department serial number for a given piece of material.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns></returns>
    ''' <remarks>naco - 10/07/2017</remarks>
    Public Function UpdateMateriaalAfdelingVolgnr(ByVal dbConnection As String, _
                                                             ByVal aTypeMatId As Integer, _
                                                             ByVal aMatVolgnr As Integer, _
                                                             ByVal aVolgnummerAfdeling As Integer) As Boolean

        Try
            Return GetAfdelingBBW.UpdateMateriaalAfdelingVolgnr(dbConnection, aTypeMatId, aMatVolgnr, aVolgnummerAfdeling)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of managers for a given departement.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="afdeling">ID of the departement.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBeheerderAfdeling(ByVal dbConnection As String, ByVal afdeling As Integer, ByVal aAfdeling2 As Integer, ByVal aAfdeling3 As Integer) As TDSBrandweerBeheerderAfdeling

        Try
            Dim result As New TDSBrandweerBeheerderAfdeling
            result.Merge(GetAfdelingBBW.GetBeheerderAfdeling(dbConnection, afdeling, aAfdeling2, aAfdeling3))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Add a departemental manager.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="afdeling">ID of the departement.</param>
    ''' <param name="naam">Name of the manager.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddBeheerderAfdeling(ByVal dbConnection As String, ByVal afdeling As Integer, ByVal naam As String) As Boolean

        Try
            Return GetAfdelingBBW.AddBeheerderAfdeling(dbConnection, afdeling, naam)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Delete a departemental manager with a gived ID.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="id">ID of the departemental manager.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteBeheerderAfdeling(ByVal dbConnection As String, ByVal id As Integer) As Boolean

        Try
            Return GetAfdelingBBW.DeleteBeheerderAfdeling(dbConnection, id)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the departement that a user belongs to.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="gebruiker">The login ID of the user (e.g. SIDXXXX).</param>
    ''' <returns>The department ID (or -1 if the user cannot be found).</returns>
    ''' <remarks></remarks>
    Public Function GetAfdelingVoorGebruiker(ByVal dbConnection As String, ByVal gebruiker As String) As Integer

        Try
            Return GetAfdelingBBW.GetAfdelingVoorGebruiker(dbConnection, gebruiker)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    Public Function GetAfdelingVoorGebruiker2(ByVal dbConnection As String, ByVal gebruiker As String) As Integer

        Try
            Return GetAfdelingBBW.GetAfdeling2VoorGebruiker(dbConnection, gebruiker)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    Public Function GetAfdelingVoorGebruiker3(ByVal dbConnection As String, ByVal gebruiker As String) As Integer

        Try
            Return GetAfdelingBBW.GetAfdeling3VoorGebruiker(dbConnection, gebruiker)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Bewaking - snelheid externen"
    ''' <summary>
    ''' Sancties voor snelheidsovertredingen externen
    ''' </summary>
    ''' <param name="dbConnection"></param>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Shared Function GetSnelheidSanction(ByVal dbConnection As String) As TDSBewakingSnelheidSanction

        Try
            Dim result As New TDSBewakingSnelheidSanction

            result.Merge(GetDataBbw.GetSnelheidSanction(dbConnection))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Matrix sancties voor snelheidsovertredingen externen
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Shared Function GetSnelheidSanctionMatrix(ByVal dbConnection As String) As TDSBewakingSnelheidSanctionMatrix

        Try
            Dim result As New TDSBewakingSnelheidSanctionMatrix

            result.Merge(GetDataBbw.GetSnelheidSanctionMatrix(dbConnection))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function
#End Region

#Region "Overzicht inkoop"
    ''' <summary>
    ''' Lijst met bestemmeling David Martens (IKP - Inkoop)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Shared Function GetLijstInkoop(ByVal dbConnection As String) As TDSInkoop

        Try
            Dim result As New TDSInkoop

            result.Merge(GetDataBbw.GetLijstInkoop(dbConnection))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lijst brandweerinterventies met bestemmeling David Martens (IKP - Inkoop)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Shared Function GetLijstInkoopBrandweer(ByVal dbConnection As String) As TDSBrandweerInkoop

        Try
            Dim result As New TDSBrandweerInkoop

            result.Merge(GetDataBbw.GetLijstInkoopBrandweer(dbConnection))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Lijst van bewakingregistraties
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens -06/07/2015</remarks>
    Public Shared Function GetLijstInkoopFirmaVinkjeCHIP(ByVal dbConnection As String, ByVal aTmsInc As String) As TDSInkoopFirmaCHIP

        Try
            Dim result As New TDSInkoopFirmaCHIP

            result.Merge(GetDataBbw.GetLijstInkoopFirmaVinkjeCHIP(dbConnection, aTmsInc))

            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aOPM_IKP"></param>
    ''' <remarks>Nancy Coppens - 04/12/2012</remarks>
    Public Sub UpdateIKPOpmerking(ByVal aOPM_IKP As String, ByVal aID_REG As Integer)
        Try
            Try
                Dim myBc As New DMC.UpdateDataBBW
                myBc.UpdateIKPOpmerking(aOPM_IKP, aID_REG)

            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aTMS_IKP_SENDMAIL"></param>
    ''' <remarks>Nancy Coppens - 04/12/2012</remarks>
    Public Sub UpdateIKPSendMail(ByVal aTMS_IKP_SENDMAIL As String, ByVal aID_REG As Integer)
        Try
            Try
                Dim myBc As New DMC.UpdateDataBBW
                myBc.UpdateIKPSendMail(aTMS_IKP_SENDMAIL, aID_REG)

            Catch ex As Exception
                Throw
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <remarks>Nancy Coppens - 04/12/2012</remarks>
    Public Sub UpdateIKPSendMailNull(ByVal aID_REG As Integer)
        Try
            Try
                Dim myBc As New DMC.UpdateDataBBW
                myBc.UpdateIKPSendMailNull(aID_REG)

            Catch ex As Exception
                Throw
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

#Region "Update Firma's SAP"
    ''' <summary>
    ''' Update Firm: mailcontact, remark, language (necessary if firm is not known in SAP)
    ''' </summary>
    ''' <remarks>naco - maart 2017</remarks>
    Public Sub UpdateBBFRM_EmailRemarkLanguage(ByVal pID_FRM As Integer, ByVal pEmailContact As String, ByVal pRemark As String, ByVal pLanguage As String)

        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateBBFRM_EmailRemarkLanguage(pID_FRM, pEmailContact, pRemark, pLanguage)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Sub

    Public Sub UpdateFirmasBBW(ByVal aSAP_FrmNr As Integer, ByVal aSAP_FRMNM As String, ByVal aBBFRM_Id_FRM As Integer, ByVal aBBFRM_STRA As String, ByVal aBBFRM_POSTCPDE As String, ByVal aBBFRM_PLAATS As String)

        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateBBFRM_SAP(aSAP_FrmNr, aSAP_FRMNM, aBBFRM_Id_FRM, aBBFRM_STRA, aBBFRM_POSTCPDE, aBBFRM_PLAATS)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Sub

    ''' <summary>
    ''' Update Firma's
    ''' </summary>
    ''' <remarks>Thomas Beirens - 2/12/2015</remarks>
    Public Sub UpdateFirmasBBW(ByVal aSAP_FrmNr As Integer, ByVal aSAP_FRMNM As String, ByVal aBBFRM_Id_FRM As Integer)

        Try
            Dim myBc As New DMC.UpdateDataBBW
            myBc.UpdateBBFRM_SAP(aSAP_FrmNr, aSAP_FRMNM, aBBFRM_Id_FRM)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Sub

#End Region

#Region "SAP firmanr ophalen - voor CHIP"
    ''' <summary>
    ''' Return Firmnr SAP from table BBFRM - necessary to send automatically to CHIP
    ''' </summary>
    ''' <param name="dbConnection"></param>
    ''' <param name="aID_FRM"></param>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 09/09/2016</remarks>
    Public Shared Function GetSAPFirmNr(ByVal dbConnection As String, ByVal aID_FRM As Integer) As Integer
        Try
            Return GetDataBbw.GetSAPFirmNr(dbConnection, aID_FRM)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Function

    ''' <summary>
    ''' Get email-contacts of a SAP Firm nr - necessary to send automatically mail
    ''' </summary>
    ''' <param name="aID_FRM"></param>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 12/09/2016</remarks>
    Public Shared Function GetSAPFirm_EmailContact(ByVal aID_FRM As Integer) As String

        'OPGELET - sidnaco - maart 2017 => wordt niet meer gebruikt
        'vervangen door Firma webservice van Bart Bories (rechtstreeks vanuit de client)
        Try
            Return GetDataBbw.GetSAPFirm_EmailContact(aID_FRM)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Function

    ''' <summary>
    ''' Return ID_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - april 2017</remarks>
    Public Shared Function GetFirm_ID_FRMforSAPnr(ByVal dbConnection As String, ByVal aNR_IND_FRM_SAP As Integer) As Integer

        Try
            Return GetDataBbw.GetFirm_ID_FRMforSAPnr(dbConnection, aNR_IND_FRM_SAP)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Function

    ''' <summary>
    ''' Return NM_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - april 2017</remarks>
    Public Shared Function GetFirm_NM_FRMforSAPnr(ByVal dbConnection As String, ByVal aNR_IND_FRM_SAP As Integer) As String

        Try
            Return GetDataBbw.GetFirm_NM_FRMforSAPnr(dbConnection, aNR_IND_FRM_SAP)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Throw
        End Try

    End Function

#End Region

    Public Function GetUserBrandweer(ByVal dbConnection As String, ByVal aUser As String) As String
        'naco - 09/02/2017
        Try
            Return GetDataBbw.GetUserBrandweer(dbConnection, aUser)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function
End Class
