Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports ADF
Imports Be.Sidmar.RIS.BrandweerBewaking.BS
Imports Be.Sidmar.RIS.BrandweerBewaking.BS2
Imports ADF.Configuration.ConfigurationSettings
Imports System.Reflection
Imports ADF.ExceptionHandling
Imports System.Collections.Generic


<WebService(Namespace:="http://tempuri.org/BBWService.Management/Services")>
Public Class Services
    Inherits WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    Private _svc As BS.BusinessServiceFacade
    Private _svc2 As BS2.BusinessServiceFacade

    Private ReadOnly Property SVC() As BS.BusinessServiceFacade
        Get
            If _svc Is Nothing Then _svc = New BS.BusinessServiceFacade(MyConnection)
            Return _svc
        End Get
    End Property

    Private ReadOnly Property SVC2() As BS2.BusinessServiceFacade
        Get
            If _svc2 Is Nothing Then _svc2 = New BS2.BusinessServiceFacade(MyConnection)
            Return _svc2
        End Get
    End Property

    Private ReadOnly Property MyConnection As String
        Get
            Return Databases.Item("SQLConnection").ConnectionString
        End Get
    End Property

    <WebMethod()>
    Public Function InfoWebservice() As String
        Return "Webservice voor programma BBW - Brandweer Bewaking Verslagen"
    End Function

#Region "GetCodeTables"

    <WebMethod()>
    Public Function GetInterventieType() As TDSIntvType
        Try
            Return SVC.GetInterventieType
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVoertuigTypes() As TDSVoertuigTypes
        Try
            Return SVC.GetVoertuigTypes
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAanspreektitel() As TDSAanspreektitel
        Try
            Return SVC.GetAanspreektitel
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetPloeg() As TDSPloeg
        Try
            Return SVC.GetPloeg
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetGebruikVoertuig() As TDSGebruikVoertuig
        Try
            Return SVC.GetGebruikVoertuig
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetEenheden() As TDSEenheden
        Try
            Return SVC.GetEenheden
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetArtikelGroepen() As TDSArtikelgroep
        Try
            Return SVC.GetArtikelGroepen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegistratieType() As TDSRegType
        Try
            Return SVC.GetRegistratieType()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetIndividuTypes() As TDSIndividuType
        Try
            Return SVC.GetIndividuTypes()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetTypeBetrokkenen() As TDSTypeBetrokkene
        Try
            Return SVC.GetTypeBetrokkenen()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAfdelingen() As TDSAfdelingen
        Try
            Return SVC.GetAfdelingen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetOorzaken(ByVal intvType As Integer) As TDSOorzaken
        Try
            Return SVC.GetOorzaken(intvType)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAarden(ByVal intvType As Integer) As TDSAarden
        Try
            Return SVC.GetAarden(intvType)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetInbreukArt(ByVal inbrType As Integer) As TDSInbrArt
        Try
            Return SVC.GetInbreukArt(inbrType)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetInbreukType() As TDSInbrType
        Try
            Return SVC.GetInbreukType()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetScadObjecten() As TDSScadObjecten
        Try
            Return SVC.GetScadObjecten()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetDiefDup() As TDSDiefDup
        Try
            Return SVC.GetDiefDup()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetWerfVoertuig() As TDSWerfVoertuig
        Try
            Return SVC.GetWerfVoertuig()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetToestandType() As TDSToestandType
        Try
            Return SVC.GetToestandType()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetToestanden() As TDSToestanden
        Try
            Return SVC.GetToestanden()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBewakingDup() As TDSBewakingDup
        Try
            Return SVC.GetBewakingDup()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVaststellerAanrijding() As TDSVaststellerAanrijding
        Try
            Return SVC.GetVaststellerAanrijding()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBBBWPersoneel() As TDSBBBWPERS
        Try
            Return SVC.GetBBBWPersoneel
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAFDAMC() As TDSBBAFDAMC
        Try
            Return SVC.getBBAFDAMC()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "GetBBWData"

    <WebMethod()>
    Public Function GetMaxBBTSP() As Integer
        Try
            Return SVC.GetMaxBBTSP()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Function

    <WebMethod()>
    Public Function GetIndividuen() As TDSIndividuen
        Try
            Return SVC.GetIndividuen()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetIndividu(ByVal id_ind As Integer) As TDSIndividuen
        Try
            Return SVC.GetIndividu(id_ind)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetInterventies() As TDSIntvBr
        Try
            Return SVC.GetBRInterventies()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetMilieuverontreinigingen() As TDSIntvBr
        Try
            Return SVC.GetMilieuverontreinigingen()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetMilieuVerontreinigingenBewaking() As TDSRegBew
        Try
            Return SVC.GetMilieuVerontreiningenBewaking()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBBBRPersoneel() As TDSBBBRPers
        Try
            Return SVC.GetBBBRPersoneel()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod(Description:="Actieve brandweermannen ophalen - voor nieuwe interventies")>
    Public Function GetBBBRPersoneelActief() As TDSBBBRPers
        Try
            Return SVC.GetBBBRPersoneelActief()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBBWAKPersoneel() As TDSBBWAKPers
        Try
            Return SVC.GetBBWAKPersoneel()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod(Description:="Actieve bewakers ophalen - voor nieuwe registraties")>
    Public Function GetBBWAKPersoneelActief() As TDSBBWAKPers
        Try
            Return SVC.GetBBWAKPersoneelActief()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetInterventie(ByVal IdIntvBrdw As Integer) As TDSInterventie
        Try
            Return SVC.GetInterventie(IdIntvBrdw)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegistraties() As TDSRegBew
        Try
            Return SVC.GetRegistratiesBew
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegSchadegeval(ByVal IdRegBew As Integer) As TDSSchadegeval
        Try
            Return SVC.GetRegSchadegeval(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAanrijding(ByVal id_Reg As Integer) As TDSAanrijding
        Try
            Return SVC.GetAanrijding(id_Reg)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod()),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegAlcoholtest(ByVal IdRegBew As Integer) As TDSAlcoholtest
        Try
            Return SVC.GetRegAlcoholtest(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegDiefstal(ByVal IdRegBew As Integer) As TDSDiefstal
        Try
            Return SVC.GetRegDiefstal(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegOpenKleerkast(ByVal IdRegBew As Integer) As TDSOpenKleerkast
        Try
            Return SVC.GetRegOpenKleerkast(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegDivRegistratie(ByVal IdRegBew As Integer) As TDSDivRegistratie
        Try
            Return SVC.GetRegDivRegistratie(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegInbreukRegl(ByVal IdRegBew As Integer) As TDSInbreukRegl
        Try
            Return SVC.GetRegInbreukRegl(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetRegControleVoertuig(ByVal IdRegBew As Integer) As TDSControleVoertuig
        Try
            Return SVC.GetRegControleVoertuig(IdRegBew)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVastgesteldeInbreuken(ByVal IdInd As Integer, ByVal IdRegistratie As Integer) _
        As TDSVastgesteldeInbreuken
        Try
            Return SVC.GetVastgesteldeInbreuken(IdInd, IdRegistratie)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetOvertrederType() As TDSInbrIndTy
        Try
            Return SVC.GetOvertrederTypeInbreukRegl
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVerzFirmas() As TDSVerzFirmas
        Try
            Return SVC.GetVerzFirmas
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetFirmaIdForRegistration(ByVal pRegistratieId As Integer) As TDSFirmas
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            Return SVC.GetFirmaIdForRegistration(pRegistratieId, strConnectionSql)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetFirmas() As TDSFirmas
        Try
            Return SVC.GetFirmas
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVoertuig(ByVal id_tsp As Integer) As TDSVoertuigen
        Try
            Return SVC.GetVoertuig(id_tsp)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetVoertuigen() As TDSVoertuigen
        Try
            Return SVC.GetVoertuigen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetInterventieArtikelen() As TDSIntvArt
        Try
            Return SVC.GetInterventieArtikelen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod(Description:="Alle verbruiksartikelen (brandweer magazijn stock) ophalen")>
    Public Function GetVerbruiksArtikelen() As TDSVerbruiksArtikel
        Try
            Return SVC.GetVerbruiksArtikelen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <
        WebMethod _
            (Description:="Verbruiksartikelen (brandweer magazijn stock) ophalen waarvoor huidige stock < min stock")>
    Public Function GetVerbruiksArtikelenMinStock() As TDSVerbruiksArtikel
        'Doel:   alle verbruiksartikelen (brandweer magazijn stock) ophalen waarvoor huidige stock < min stock
        'Auteur: Nancy Coppens - 07/12/2006
        Try
            Return SVC.GetVerbruiksArtikelenMinStock
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Sub GetMaxValuesInterventie(ByVal InterventieTypeID As Integer,
                                        ByVal AfdelingID As Integer,
                                        ByVal jaartal As Integer,
                                        ByRef maxInterventieID As Integer,
                                        ByRef maxAfdelingVolgnummer As Integer,
                                        ByRef maxJaarVolgnummer As Integer)
        Try
            SVC.GetMaxValuesInterventie(InterventieTypeID, AfdelingID, jaartal,
                                         maxInterventieID, maxAfdelingVolgnummer, maxJaarVolgnummer)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Sub

    <WebMethod()>
    Public Sub GetMaxValuesRegistratie(ByVal tmsRegistratie As Date,
                                        ByRef id_reg As Integer,
                                        ByRef volgnr_reg_jaar As Integer)
        Try
            SVC.GetMaxValuesRegistratie(tmsRegistratie, id_reg, volgnr_reg_jaar)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Sub

    <WebMethod()>
    Public Function GetBrandenPerAfdelingMaand(ByVal Maand As Integer, ByVal Jaar As Integer) As TDSBrandenPerAfdeling
        Try
            Dim dsResult As TDSBrandenPerAfdeling
            dsResult = SVC.GetBrandenPerAfdelingMaand(Maand, Jaar)
            Return dsResult

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBrandenPerAfdelingJaar(ByVal Jaar As Integer) As TDSBrandenPerAfdeling
        Try
            Dim dsResult As TDSBrandenPerAfdeling
            dsResult = SVC.GetBrandenPerAfdelingJaar(Jaar)
            Return dsResult

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBrandenPerAfdelingAardJaar(ByVal Jaar As Integer) As TDSBrandenPerAfdeling
        Try
            Dim dsResult As TDSBrandenPerAfdeling
            dsResult = SVC.GetBrandenPerAfdelingAardJaar(Jaar)
            Return dsResult

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBrandenPerAfdelingOorzaakJaar(ByVal Jaar As Integer) As TDSBrandenPerAfdeling
        Try
            Dim dsResult As TDSBrandenPerAfdeling
            dsResult = SVC.GetBrandenPerAfdelingOorzaakJaar(Jaar)
            Return dsResult

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetSpecBestForMailWitBijlage() As TDSBBBSTBY
        Try
            Dim dsResult As TDSBBBSTBY
            dsResult = SVC.GetSpecBestForMailWithBijlage

            Return dsResult

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod([Description]:="Retrieve the personalIds from the persons that had to be avoided from automatedMailing")>
    Public Function GetHierarchicalPersonalIdsToAvoid() As List(Of String)

        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            Return SVC.GetHierarchicalPersonalIdsToAvoid(strConnectionSql)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try

    End Function

    <WebMethod([Description]:="Determine tge sanction of speeding based on a give set of parameters")>
    Public Function DetermineSpeedingSanction(ByVal pIsTruck As Boolean,
                                            ByVal pSpeedingLimit As Integer,
                                            ByVal pVelocity As Integer,
                                            ByVal pRecidive As Integer) As Integer
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            Return SVC.DetermineSpeedingSanction(pIsTruck, pSpeedingLimit, pVelocity, pRecidive, strConnectionSql)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try

    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'June 2013 : Stijn Vranken
    ' Code put out of service => Sodie interaction switched to serverside
    ' This following the insert/update of an record in BBW-Database
    ' ''' <summary>
    ' ''' This function returns if the selected traffic infraction is required within Sodie
    ' ''' </summary>
    ' ''' <param name="pArtNbrId">ArticleNbr of the infractions$</param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    '<WebMethod([Description]:="This function returns if the selected traffic infraction is required within Sodie")>
    'Public Function DetermineSodieInfraction(ByVal pArtNbrId As Integer) As Boolean
    '    Try
    '        Return SVC.DetermineSodieInfraction(pArtNbrId, Databases.Item("SQLConnection").ConnectionString)

    '    Catch ex As Exception
    '        ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
    '        Return Nothing
    '    End Try
    'End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

#End Region

#Region "Get Configuration Settings"

    <WebMethod()>
    Public Function GetConfigurationSettings() As TDSConfiguratie
        Try
            Return SVC.GetConfigurationSettings()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAddresseesFromConfig(ByVal configKey As String) As TDSBBBestemmelingen

        Try
            Return SVC.GetAddresseesFromConfig(configKey, MyConnection)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBaseLinkVera() As String

        Try
            Return SVC.GetBaseLinkVera(MyConnection)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterInterventie"

    <WebMethod()>
    Public Function RegisterInterventie(ByVal data As TDSInterventie, ByVal user As String) As TDSInterventie
        'Doel:   Creeren en updaten brandweer interventie
        'Auteur: Koen - Rajiv - 06/04/2006
        Try
            Return SVC.RegisterInterventie(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register personeel"

    <WebMethod()>
    Public Function RegisterPersoneel(ByVal data As TDSBBBWPERS, ByVal user As String) As TDSBBBWPERS
        'Doel: register personeel
        'Auteur: dien - okt. 2006
        Try
            Return SVC.RegisterPersoneel(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register AFDAMC"

    <WebMethod()>
    Public Function RegisterAFDAMC(ByVal data As TDSBBAFDAMC, ByVal user As String) As TDSBBAFDAMC
        'Doel: register afdelingsmilieucoordinator
        'Auteur: dien - mei 2009
        Try
            Return SVC.RegisterAFDAMC(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetBestemmelingenAfdeling(ByVal idAfd As Integer) As TDSBeheerAFDAMC
        'Doel: ophalen van alle bestemmelingen van een afdeling
        'Auteur: dien - mei 09
        Try

            Return SVC.GetBestemmelingenAfdeling(idAfd)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register Registratie Bewaking"

    <WebMethod()>
    Public Function RegisterRegistratieAlcoholtest(ByVal data As TDSAlcoholtest, ByVal user As String) _
        As TDSAlcoholtest
        'Doel:   Creeren en updaten bewakingsregistratie van een alcoholtest
        'Auteur: Koen - Rajiv - 24/04/2006
        Try
            Return SVC.RegisterRegistratieAlcoholtest(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieDiefstal(ByVal data As TDSDiefstal, ByVal user As String) As TDSDiefstal
        'Doel:   Creeren en updaten bewakingsregistratie van een diefstal
        'Auteur: Koen - Rajiv - 28/04/2006
        Try
            'Dim test As Boolean = SVC.TestSoDie()
            Dim dsDief As New TDSDiefstal

            dsDief = SVC.RegisterRegistratieDiefstal(data, user)
            Return dsDief
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieOpenKleerkast(ByVal data As TDSOpenKleerkast, ByVal user As String) _
        As TDSOpenKleerkast
        'Doel:   Creeren en updaten bewakingsregistratie van een openmaking kleerkast
        'Auteur: Koen - Rajiv - 28/04/2006
        Try
            Return SVC.RegisterRegistratieOpenKleerkast(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieAanrijding(ByVal data As TDSAanrijding, ByVal user As String) As TDSAanrijding
        'Doel: opslaan aanrijding
        'Auteur: Siddien okt 2006
        Try
            Return SVC.registerRegistratieAanrijding(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieSchadegeval(ByVal data As TDSSchadegeval, ByVal user As String) _
        As TDSSchadegeval
        'Doel:   Creeren en updaten bewakingsregistratie van een schadegeval
        'Auteur: Koen - Rajiv - 28/04/2006
        Try
            Return SVC.RegisterRegistratieSchadegeval(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieDivRegistratie(ByVal data As TDSDivRegistratie, ByVal user As String) _
        As TDSDivRegistratie
        'Doel:   Creeren en updaten bewakingsregistratie van een diverse registratie
        'Auteur: Koen - Rajiv - 03/05/2006
        Try
            Return SVC.RegisterRegistratieDivRegistratie(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieControleVoertuig(ByVal data As TDSControleVoertuig, ByVal user As String) _
        As TDSControleVoertuig
        'Doel:   Creeren en updaten bewakingsregistratie van een controle voertuig
        'Auteur: Koen - Rajiv - 04/05/2006
        Try
            Return SVC.RegisterRegistratieControleVoertuig(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterRegistratieInbreukRegl(ByVal data As TDSInbreukRegl, ByVal user As String) _
        As TDSInbreukRegl
        'Doel:   Creeren en updaten bewakingsregistratie van een inbreuk reglementen
        'Auteur: Koen - Rajiv - 04/05/2006
        Try
            Return SVC.RegisterRegistratieInbreukRegl(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register CodeTables"

#Region "RegisterAarden"

    <WebMethod()>
    Public Function RegisterAarden(ByVal data As TDSAarden, ByVal user As String) As TDSAarden
        'Doel:   Creeren en updaten aarden
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterAarden(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterOorzaken"

    <WebMethod()>
    Public Function RegisterOorzaken(ByVal data As TDSOorzaken, ByVal user As String) As TDSOorzaken
        'Doel:   Creeren en updaten oorzaken
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterOorzaken(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterInterventietype"

    <WebMethod()>
    Public Function RegisterInterventietype(ByVal data As TDSIntvType, ByVal user As String) As TDSIntvType
        'Doel:   Creeren en updaten interventietypes
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterInterventietype(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterAfdelingen"

    <WebMethod()>
    Public Function RegisterAfdelingen(ByVal data As TDSAfdelingen, ByVal user As String) As TDSAfdelingen
        'Doel:   Creeren en updaten afdelingen
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterAfdelingen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterEenheden"

    <WebMethod()>
    Public Function RegisterEenheden(ByVal data As TDSEenheden, ByVal user As String) As TDSEenheden
        'Doel:   Creeren en updaten eenheden
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterEenheden(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterArtikelgroepen"

    <WebMethod()>
    Public Function RegisterArtikelgroepen(ByVal data As TDSArtikelgroep, ByVal user As String) As TDSArtikelgroep
        'Doel:   Creeren en updaten artikelgroepen
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterArtikelgroepen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterInbreuktypes"

    <WebMethod()>
    Public Function RegisterInbreuktypes(ByVal data As TDSInbrType, ByVal user As String) As TDSInbrType
        'Doel:   Creeren en updaten inbreuktypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Try
            Return SVC.RegisterInbreuktypes(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterRegistratietypes"

    <WebMethod()>
    Public Function RegisterRegistratietypes(ByVal data As TDSRegType, ByVal user As String) As TDSRegType
        'Doel:   Creeren en updaten registratietypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Try
            Return SVC.RegisterRegistratietypes(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterIndividutypes"

    <WebMethod()>
    Public Function RegisterIndividutypes(ByVal data As TDSIndividuType, ByVal user As String) As TDSIndividuType
        'Doel:   Creeren en updaten individutypes
        'Auteur: Koen/Rajiv - 20/04/2006

        Try
            Return SVC.RegisterIndividutypes(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterInbreukartikelen"

    <WebMethod()>
    Public Function RegisterInbreukartikelen(ByVal data As TDSInbrArt, ByVal user As String) As TDSInbrArt
        'Doel:   Creeren en updaten inbreukartikelen
        'Auteur: Koen/Rajiv - 20/04/2006

        Try
            Return SVC.RegisterInbreukartikelen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterTypesBetrokkenen"

    <WebMethod()>
    Public Function RegisterTypesBetrokkenen(ByVal data As TDSTypeBetrokkene, ByVal user As String) _
        As TDSTypeBetrokkene
        'Doel:   Creeren en updaten types betrokkenen
        'Auteur: Koen/Rajiv - 20/04/2006

        Try
            Return SVC.RegisterTypesBetrokkenen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterTypesVoertuigen"

    <WebMethod()>
    Public Function RegisterTypesVoertuigen(ByVal data As TDSVoertuigTypes, ByVal user As String) As TDSVoertuigTypes
        'Doel:   Creeren en updaten types voertuigen
        'Auteur: Koen/Rajiv - 21/04/2006

        Try
            Return SVC.RegisterTypesVoertuigen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterAanspreektitels"

    <WebMethod()>
    Public Function RegisterAanspreektitels(ByVal data As TDSAanspreektitel, ByVal user As String) As TDSAanspreektitel
        'Doel:   Creeren en updaten aanspreektitels
        'Auteur: Koen/Rajiv - 21/04/2006

        Try
            Return SVC.RegisterAanspreektitels(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterPloeg"

    <WebMethod()>
    Public Function RegisterPloeg(ByVal data As TDSPloeg, ByVal user As String) As TDSPloeg
        'Doel:   Creeren en updaten ploegen
        'Auteur: Koen/Rajiv - 21/04/2006

        Try
            Return SVC.RegisterPloeg(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterSchadeAan"

    <WebMethod()>
    Public Function RegisterSchadeAan(ByVal data As TDSScadObjecten, ByVal user As String) As TDSScadObjecten
        'Doel:   Creeren en updaten SchadeAan
        'Auteur: Koen/Rajiv - 21/04/2006

        Try
            Return SVC.RegisterSchadeAan(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterGebruikVoertuig"

    <WebMethod()>
    Public Function RegisterGebruikVoertuig(ByVal data As TDSGebruikVoertuig, ByVal user As String) _
        As TDSGebruikVoertuig
        'Doel:   Creeren en updaten GebruikVoertuig
        'Auteur: Koen/Rajiv - 21/04/2006

        Try
            Return SVC.RegisterGebruikVoertuig(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterWerfvoertuig"

    <WebMethod()>
    Public Function RegisterWerfvoertuig(ByVal data As TDSWerfVoertuig, ByVal user As String) As TDSWerfVoertuig
        'Doel:   Creeren en updaten werfvoertuigen
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterWerfvoertuig(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterInterventieartikelen"

    <WebMethod()>
    Public Function RegisterInterventieartikelen(ByVal data As TDSIntvArt, ByVal user As String) As TDSIntvArt
        'Doel:   Creeren en updaten interventieartikelen
        'Auteur: Koen/Rajiv - 02/05/2006

        Try
            Return SVC.RegisterInterventieartikelen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#End Region

#Region "RegisterStock"

    <WebMethod()>
    Public Function RegisterStock(ByVal data As TDSVerbruiksArtikel, ByVal user As String) As TDSVerbruiksArtikel
        'Doel:   Creeren en updaten Stock
        'Auteur: Koen/Rajiv - 19/04/2006

        Try
            Return SVC.RegisterStock(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

    <WebMethod()>
    Public Sub updateIndividuBestemmeling(ByVal idInd As Integer,
                                           ByVal mailAdres As String,
                                           ByVal user As String)
        'Doel: Updaten individu --> set bestemmeling
        'Auteur: Siddien - sept 2006
        Try
            SVC.updateIndividuBestemmeling(idInd, mailAdres, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Sub

#Region "Register voertuigen"

    <WebMethod()>
    Public Function RegisterVoertuigen(ByVal data As TDSVoertuigen, ByVal user As String) As TDSVoertuigen
        'Doel: creëren en updaten voertuigne
        'Auteur: DIEN - okt. 2006
        Try
            Return SVC.RegisterVoertuigen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

#End Region


#Region "register firma's"

    <WebMethod()>
    Public Function RegisterFirma(ByVal data As TDSFirmas, ByVal user As String) As TDSFirmas
        'Doel: creëren en updaten firma
        'Auteur: DIEn - sept 2006
        Try
            Return SVC.RegisterFirmas(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register verz. firma's"

    <WebMethod()>
    Public Function RegisterVerzFirmas(ByVal data As TDSVerzFirmas, ByVal user As String) As TDSVerzFirmas
        'Doel: verzfirma's
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.RegisterVerzFirmas(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "RegisterDagverslagRegistratieType"

    <WebMethod()>
    Public Function RegisterDagverslagRegistratieType(ByVal data As TDSDagverslagRegistratieType, ByVal user As String) _
        As TDSDagverslagRegistratieType
        'Doel: dagverslag registratietype
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.RegisterDagverslagRegistratieType(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Register individu"

    <WebMethod()>
    Public Function RegisterIndividu(ByVal data As TDSIndividuen, ByVal user As String) As TDSIndividuen
        'Doel: creëren en updaten individu
        'Auteur: dien -sept 2006
        Try
            Return SVC.RegisterIndividu(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

#End Region

    <WebMethod()>
    Public Function DagverslagRegistratieTypes() As TDSDagverslagRegistratieType
        'Doel: ophalen registratietypes 
        'Auteur: Dien - okt 2006
        Try
            Return SVC.GetRegistratieTypesDagverslag()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterDagverslagPersoneel(ByVal data As TDSDagverslagPersoneel, ByVal user As String) _
        As TDSDagverslagPersoneel
        'Doel: registreren dagverslag personeel
        'Auteur: dien - okt 2006
        Try
            Return SVC.RegisterDagverslagPersoneel(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterDagverslagInlichtingType(ByVal data As TDSDagverslagInlichtingType, ByVal user As String) _
        As TDSDagverslagInlichtingType
        'Doel: registreren dagverslag inlichtingtype.
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.RegisterDagverslagInlichtingType(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetDagverslagenPersoneel(ByVal datumVanaf As DateTime) As TDSDagverslagPersoneel
        'Doel: dagverslagen personeel 
        'Auteur: DIEN - okt. 2006
        Try
            Return SVC.GetDagverslagenPersoneel(datumVanaf)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetLastStamnummer() As Integer
        'Doel: laatste stamnummer --> om externe toe te voegen
        'Auteur: DIEN - okt. 2006
        Try
            Return SVC.GetLastStamnummer()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Function

    <WebMethod()>
    Public Function GetDagverslagInlichtingen(ByVal datumVanaf As DateTime,
                                               ByVal datumTot As DateTime) As TDSDagverslagInlichtingen
        'Doel: dagverslag inlichtingen
        'Auteur: DIEN - okt. 2006
        Try
            Return SVC.GetDagverslagInlichtingen(datumVanaf, datumTot)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetDagverslagInlichtingenType() As TDSDagverslagInlichtingType
        'Doel: dagverslag inlichtingen type
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.GetDagverslagInlichtingenType()
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function BestaatDagverslagInlichtingVoorDag(ByVal datum As DateTime) As Boolean
        'Doel: zijn de records reeds aangemaakt voor een bepaalde dag.
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.BestaatDagverslagInlichtingVoorDag(datum)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod()),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function RegisterDagverslagInlichtingen(ByVal data As TDSDagverslagInlichtingen,
                                                    ByVal user As String) As TDSDagverslagInlichtingen
        'Doel: updaten/toevoegen records dagverslag inlichtingen
        'Auteur: Dien - okt. 2006
        Try
            Return SVC.RegisterDagverslagInlichtingen(data, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
            Return Nothing
        End Try
    End Function

    <WebMethod()>
    Public Function GetAanrijdingBetrokkenen(ByVal idReg As Integer) As TDSBBBTROGV
        'Doel: ophalen betrokkenen van een aanrijding.
        'Auteur: DIEN - Okt. 2006
        Try
            Return SVC.GetBetrokkenenAanrijding(idReg)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

#Region "Maandverslag Bewaking - Inbreuk reglementen"

    <WebMethod()>
    Public Function GetLijstInbreukReglementen() As TDSLijstInbreukRegl
        'Doel:   Lijst inbreuk reglementen (voor maandrapporten)
        'Auteur: Nancy Coppens - 19/12/2006
        Try
            Return SVC.GetLijstInbreukReglementen
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Snelheidsovertredingen"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="intern">True or False => like Arcelor Gent</param>
    ''' <returns></returns>
    ''' <remarks>may 2011</remarks>
    <WebMethod([Description]:="Get List Overtredingen (for HR department) - Intern = True or False")>
    Public Function GetLijstOvertredingen(ByVal intern As Boolean,
                                          ByVal aDateFrom As DateTime) As TDSOvertreding
        'Doel:   Lijst snelheidsovertredingen
        'Auteur: Lawrence Verbruggen - 12/04/2011
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            Return SVC.GetOvertredingen(intern, strConnectionSql, aDateFrom)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="intern">True or False => like Arcelor Gent</param>
    ''' <returns></returns>
    ''' <remarks>may 2011</remarks>
    <WebMethod([Description]:="Get List Snelheidsovertredingen (for HR department) - Intern = True or False")>
    Public Function GetLijstSnelheidsovertredingen(ByVal intern As Boolean) As TDSSnelheidsOvertredingen
        'Doel:   Lijst snelheidsovertredingen
        'Auteur: Lawrence Verbruggen - 12/04/2011
        Try
            Return SVC.GetLijstSnelheidsovertredingen(intern)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

    <WebMethod([Description]:="Save parameters of driving prohibition")>
    Public Sub UpdateRijverbod(ByVal aID_REG As Integer,
                                ByVal aRijverbodVan As DateTime,
                                ByVal aRijverbodTot As DateTime,
                                ByVal aAfspraakPBH As DateTime,
                                ByVal aContactId As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            SVC.UpdateRijverbod(aID_REG, aRijverbodVan, aRijverbodTot, aAfspraakPBH, strConnectionSql, aContactId)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    <WebMethod([Description]:="Save parameters of driving prohibition - empty dates >= 70")>
    Public Sub UpdateRijverbodLegeDatums(ByVal aID_REG As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011 - aangepast sidnaco 30/05/2011
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            SVC.UpdateRijverbodLegeDatums(aID_REG)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    <WebMethod([Description]:="Save time of print")>
    Public Sub UpdateSnelheidsovertredingPrint(ByVal aID_REG As Integer, ByVal aAfdruk As DateTime,
                                                ByVal aContactId As Integer)
        'Auteur: Lawrence Verbruggen - 14/04/2011
        Try
            Dim strConnectionSql As String = Databases.Item("SQLConnection").ConnectionString
            SVC.UpdateSnelheidsovertredingPrint(aID_REG, aAfdruk, strConnectionSql, aContactId)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'June 2013 : Stijn Vranken
    ' Code put out of service => Sodie interaction switched to serverside
    ' This following the insert/update of an record in BBW-Database
    '<WebMethod([Description]:="Insert SoDie data")>
    'Public Sub InsertSoDie(ByVal aStamNr As Integer, ByVal aRegID As Integer)
    '    'Auteur: Lawrence Verbruggen - 19/04/2011
    '    Try
    '        Dim newContactId As Integer
    '        newContactId = SVC.InsertSoDie(aStamNr)

    '        SVC.UpdateRegSoDieContactId(aRegID, newContactId)
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    ''' <summary>
    ''' This function updates the date on which PEB sent the letter to the firm
    ''' </summary>
    ''' <param name="aID_REG">The id of the registration</param>
    ''' <param name="aDateSent">The date on which the letter was sent</param>
    ''' <remarks>02/05/2013 SIDVRST</remarks>
    <WebMethod([Description]:="This function updates the date on which PEB sent the letter to the firm")>
    Public Sub UpdateDateLetterSent(ByVal aID_REG As Integer, ByVal aDateSent As DateTime)
        Try
            SVC.UpdateDateLetterSent(aID_REG, aDateSent)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Sub

    <WebMethod([Description]:="Test SoDie data")>
    Public Function TestSoDie() As Boolean
        'Auteur: Lawrence Verbruggen - 23/05/2011
        Try
            If (SVC.TestSoDie()) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Verslag Bewaking - Diefstallen per trimester"

    <WebMethod()>
    Public Function GetDiefstallenPerTrimester() As TDSTrimesterDiefstal
        'Doel:   Lijst diefstallen (per trimester)
        'Auteur: Mieke Duynslager - 14/06/2007
        Try
            Return SVC.GetDiefstallenPerTrimester
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsBusinessException)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Dagverslag personeel"

    <WebMethod()>
    Public Sub ToevoegenDagverslagPersoneel(ByVal datum As DateTime)
        Try
            SVC.ToevoegenDagverslagPersoneel(datum)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Sub

    <WebMethod()>
    Public Function dagVerslagPersoneelReedsDoorgestuurd(ByVal datum As DateTime) As Boolean
        Try
            Return SVC.dagVerslagPersoneelReedsDoorgestuurd(datum)
        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                      ReThrowOptions.RethrowAsSoapException)
        End Try
    End Function

#End Region

#Region "AMC'"

    <WebMethod([Description]:="Bewaren AMC (milieudienst)")>
    Public Sub saveAMC(ByVal aTdsAMC As TDSBeheerAFDAMC)
        For Each aRow As TDSBeheerAFDAMC.BBAFDAMCRow In aTdsAMC.BBAFDAMC
            'Controle of er een e-mail adres werd toegevoegd
            'Vlag bestemmeling aanzetten in individu tabel


            SVC.updateIndividuBestemmeling(aRow.ID_IND, aRow.MAIL, "")

            If aRow.RowState = DataRowState.Modified Then
                aRow.AcceptChanges()
                'update niet saven

            End If
        Next


        'Toevoegen/updaten/verwijderen BBAFDAMC
        Dim aTdsADFAMC As New TDSBBAFDAMC
        aTdsADFAMC.Merge(aTdsAMC, True, MissingSchemaAction.Ignore)


        SVC.RegisterAFDAMC(aTdsADFAMC, "")
    End Sub

    ''' <summary>
    ''' Update of AMC's didn't work - workaround
    ''' </summary>
    ''' <param name="aID_AFD"></param>
    ''' <param name="aID_IND"></param>
    ''' <remarks>Nancy Coppens - 22/02/2010</remarks>
    <WebMethod([Description]:="Update AMC of a certain department")>
    Public Sub UpdateAFDAMC(ByVal aID_AFD As Integer, ByVal aID_IND As Integer, ByVal aOldID_IND As Integer)
        Try

            SVC.UpdateAFDAMC(aID_AFD, aID_IND, aOldID_IND)
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
    <WebMethod([Description]:="Get Chip Complaints from date to date (yyyy-MM-dd")>
    Public Function CHIPGetComplaintsBBW(ByVal aDateFrom As String, ByVal aDateTo As String) As TDSChipKlachten
        Try
            Return SVC.GetChipComplaints(aDateFrom, aDateTo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Doel: Lijst van Klachten, geldig voor CHIP systeem - voor een bepaalde firma (uitbreiding nov 2017 - op vraag van Jeroen/Bart)
    ''' </summary>
    ''' <param name="aDateFrom">yyyy-MM-dd</param>
    ''' <param name="aDateTo">yyyy-MM-dd</param>
    ''' <returns></returns>
    ''' <remarks>naco - 17/11/2017</remarks>
    <WebMethod([Description]:="Get Chip Complaints from date to date (yyyy-MM-dd) - for a SAP firm ID")>
    Public Function CHIPGetComplaintsBBW_SAPfirmanr(ByVal aDateFrom As String, ByVal aDateTo As String, ByVal aSAPfirmanr As String) As TDSChipKlachten
        Try
            Return SVC.GetChipComplaints_SAPfirmanr(aDateFrom, aDateTo, aSAPfirmanr)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Update verslag gelezen - BBW
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 04/12/2017</remarks>
    <WebMethod([Description]:="Update Verslag gelezen in CHIP door leverancier - BBW")>
    Public Function CHIPUpdate_BBW_ReportReadOK(ByVal aID_REG As Long, ByVal aRemark As String) As String
        Try
            Return SVC.CHIPUpdate_BBW_ReportReadOK(aID_REG, aRemark)
        Catch ex As Exception
            Return "NOK - error: " & ex.InnerException.ToString
        End Try

    End Function

    ''' <summary>
    ''' Doel: Chip Data updaten in de registratietabel
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aSAP_SUPPLIER_ID"></param>
    ''' <param name="aDT_CHIP"></param>
    ''' <remarks>Auteur: Lawrence Verbruggen - 03/03/2011</remarks>
    <WebMethod([Description]:="Update CHIP Data for a certain Registration")>
    Public Sub CHIPUpdate(ByVal aID_REG As Integer, ByVal aSAP_SUPPLIER_ID As String,
                           ByVal aDT_CHIP As DateTime, ByVal aOPM_CHIP As String)
        Try
            SVC.UpdateCHIP(aID_REG, aSAP_SUPPLIER_ID, aDT_CHIP, aOPM_CHIP)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Doel: Chip Data updaten in de registratietabel
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aCHIP_YN"></param>
    ''' <remarks>Auteur: Lawrence Verbruggen - 03/03/2011</remarks>
    <WebMethod([Description]:="Update Registration to enable/disable it for CHIP")>
    Public Sub CHIPRegistration(ByVal aID_REG As Integer, ByVal aCHIP_YN As Boolean)
        Try
            SVC.UpdateCHIP(aID_REG, aCHIP_YN)
        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region

#Region "Brandweermateriaal"

#Region "Brandweermateriaal - augustus 2011"

    <WebMethod(Description:="Get list of fire brigade material (fire extinguishers, fire hydrants, ...)")>
    Public Function GetBrandweerMateriaalLijst() As TDSBrandweerMateriaal

        Try

            Dim ds As New TDSBrandweerMateriaal
            ds.Merge(SVC.GetBrandweerMateriaalLijst(MyConnection))

            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    <
        WebMethod _
            (
                Description:=
                "Get a piece of fire brigade material (fire extinguishers, fire hydrants, ...) using the PK.")>
    Public Function GetBrandweerMateriaalByTypeVolgnr(ByVal typeMateriaal As Integer, ByVal volgnummer As Integer) _
        As TDSBrandweerMateriaalItem

        Dim ds As New TDSBrandweerMateriaalItem
        ds.Merge(SVC.GetBrandweerMateriaalByTypeVolgnr(MyConnection, typeMateriaal, volgnummer))

        Return ds
    End Function

    <WebMethod(Description:="Get list of types of fire brigade material (fire extinguishers, fire hydrants, ...)")>
    Public Function GetBrandweerMaterialTypes() As TDSBrandweerMateriaalTypes

        Dim ds As New TDSBrandweerMateriaalTypes
        ds.Merge(SVC.GetBrandweerMaterialTypes(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of types of fire extinguishers.")>
    Public Function GetBrandweerExtinguisherTypes() As TDSBrandweerExtinguisherTypes

        Dim ds As New TDSBrandweerExtinguisherTypes
        ds.Merge(SVC.GetBrandweerExtinguisherTypes(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of suppliers of fire brigade material.")>
    Public Function GetBrandweerSuppliers() As TDSBrandweerLeveranciers

        Dim ds As New TDSBrandweerLeveranciers
        ds.Merge(SVC.GetBrandweerSuppliers(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of departments - in the point of view of the fire brigade.")>
    Public Function GetBrandweerDepartments() As TDSBrandweerAfdelingen

        Dim ds As New TDSBrandweerAfdelingen
        ds.Merge(SVC.GetBrandweerDepartments(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of the stati for the fire brigade material.")>
    Public Function GetBrandweerStatus() As TDSBrandweerStatus

        Dim ds As New TDSBrandweerStatus
        ds.Merge(SVC.GetBrandweerStatus(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of the managers for the fire brigade material.")>
    Public Function GetBrandweerManagers() As TDSBrandweerBeheerderAfdeling

        Dim ds As New TDSBrandweerBeheerderAfdeling
        ds.Merge(SVC.GetBrandweerManagers(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get list of the send history for the fire brigade material.")>
    Public Function GetBrandweerVerzending() As TDSBrandweerVerzending

        Dim ds As New TDSBrandweerVerzending
        ds.Merge(SVC.GetBrandweerVerzending(MyConnection))

        Return ds
    End Function

    <
        WebMethod _
            (
                Description:=
                "Check if a combination of material type, location and location number exists in the database.")>
    Public Function BrandweerMateriaalBestaat(ByVal typeMateriaal As Integer, ByVal locatieId As Integer,
                                               ByVal locatieNr As String) As Boolean

        Return SVC.BrandweerMateriaalBestaat(MyConnection, typeMateriaal, locatieId, locatieNr)
    End Function

    <
        WebMethod _
            (
                Description:=
                "Save the information on a piece of fire brigade material (fire extinguishers, fire hydrants, ...)")>
    Public Function SaveBrandweerMateriaal(ByVal materiaal As TDSBrandweerMateriaalItem) As Boolean

        Return SVC.SaveBrandweerMateriaal(MyConnection, materiaal)
    End Function

    <WebMethod(Description:="Materiaal brandweer - delete (datedeleted en userdeleted)")>
    Public Function UpdateMateriaalDateDeleted(ByVal aType As Integer, ByVal aVolgnr As Integer, ByVal aUserDeleted As String) As Boolean

        Return SVC.UpdateMateriaalDateDeleted(MyConnection, aType, aVolgnr, aUserDeleted)

    End Function

#End Region

#Region "Brandweer - Vervangmateriaal"

    <WebMethod(Description:="Mark a piece of equipment as a temporary replacement.")>
    Public Function BrandweerMarkeerVervangMateriaal(ByVal type As Integer, ByVal volgnr As Integer,
                                                      ByVal plaats As Integer) As Boolean

        Return SVC.BrandweerMarkeerVervangMateriaal(MyConnection, type, volgnr, plaats)
    End Function

    <WebMethod(Description:="Unmark a piece of equipment as a temporary replacement.")>
    Public Function BrandweerVrijgaveVervangMateriaal(ByVal type As Integer, ByVal volgnr As Integer) As Boolean

        Return SVC.BrandweerVrijgaveVervangMateriaal(MyConnection, type, volgnr)
    End Function

    <WebMethod(Description:="Get list of available fire extinguishers for temprorary replacements.)")>
    Public Function GetBrandweerVervangLijst(ByVal type As Integer) As TDSBrandweerMateriaal

        Dim ds As New TDSBrandweerMateriaal
        ds.Merge(SVC.GetBrandweerVervangLijst(MyConnection, type))

        Return ds
    End Function

    <WebMethod(Description:="Get material description for MateriaalVolgnr.)")>
    Public Function BrandweerGetMateriaalOmschr(ByVal aMateriaalvolgnr As Integer) As String

        Return SVC.BrandweerGetMateriaalOmschr(MyConnection, aMateriaalvolgnr)
    End Function

#End Region

#Region "Brandweer - Materiaalfiche"

    <WebMethod(Description:="Get the list of all actions.")>
    Public Function GetBrandweerActie() As TDSBrandweerActie

        Dim ds As New TDSBrandweerActie
        ds.Merge(SVC.GetBrandweerActie())

        Return ds
    End Function

    <WebMethod(Description:="Get the list of actions and measured weights for a piece of material.")>
    Public Function GetMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer) As TDSBrandweerMateriaalActie

        Dim ds As New TDSBrandweerMateriaalActie
        ds.Merge(SVC.GetMateriaalActie(type, volgnr))

        Return ds
    End Function

    <WebMethod(Description:="Store aa action and measured weight for a piece of material.")>
    Public Function StoreMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime,
                                         ByVal actie As Integer?, ByVal gewicht As Decimal?) As Boolean

        Return SVC.StoreMateriaalActie(type, volgnr, datum, actie, gewicht)
    End Function

    <WebMethod(Description:="Delete an action / measured weight for a piece of material.")>
    Public Function DeleteMateriaalActieById(ByVal id As Integer) As Boolean

        Return SVC.DeleteMateriaalActieById(id)
    End Function

    <WebMethod(Description:="Delete an action / measured weight for a piece of material.")>
    Public Function DeleteMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime) _
        As Boolean

        Return SVC.DeleteMateriaalActie(type, volgnr, datum)
    End Function

#End Region

#Region "Brandweermateriaal - Rapporten"

    <WebMethod(Description:="Get the overview of refilled fire extingoushers.")>
    Public Function GetMateriaalHervuld(ByVal jaar As Integer, ByVal perAfdeling As Boolean) _
        As TDSBrandweerReportHervuldeBlustoestellen

        Dim ds As New TDSBrandweerReportHervuldeBlustoestellen
        ds.Merge(SVC.GetMateriaalHervuld(MyConnection, jaar, perAfdeling))

        Return ds
    End Function

    <WebMethod(Description:="Get the list of materials that must be inspected.")>
    Public Function GetMateriaalControleLijst(ByVal isVisueleControle As Boolean, ByVal datumVorigeControle As DateTime) _
        As TDSBrandweerMateriaalControleLijst

        Dim ds As New TDSBrandweerMateriaalControleLijst
        ds.Merge(SVC.GetMateriaalControleLijst(MyConnection, isVisueleControle, datumVorigeControle))

        Return ds
    End Function

    <WebMethod(Description:="Save the list of materials that must be inspected.")>
    Public Function SaveMateriaalControleLijst(ByVal controleLijst As TDSBrandweerMateriaalControleLijst,
                                                ByVal isVisueleControle As Boolean, ByVal nieuweDatum As DateTime) _
        As Boolean

        Return SVC.SaveMateriaalControleLijst(MyConnection, controleLijst, isVisueleControle, nieuweDatum)
    End Function

#End Region

#Region "Brandweer Verzending"

    <WebMethod(Description:="Get the overview of material that has been shipped to the supplier.")>
    Public Function GetVerzendingLijst() As TDSBrandweerVerzendingLijst

        Dim ds As New TDSBrandweerVerzendingLijst
        ds.Merge(SVC.GetVerzendingLijst(MyConnection))

        Return ds
    End Function

    <WebMethod(Description:="Get a shipping record.")>
    Public Function GetVerzending(ByVal id As Integer) As TDSBrandweerVerzending

        Dim ds As New TDSBrandweerVerzending
        ds.Merge(SVC.GetVerzending(MyConnection, id))

        Return ds
    End Function

    <WebMethod(Description:="Store the 'sent' information for a list of material.")>
    Public Function StoreVerzending(ByVal verzending As TDSBrandweerVerzending) As Boolean
        Return SVC.StoreVerzending(MyConnection, verzending)
    End Function

    <WebMethod(Description:="Delete the 'sent' information for a list of material.")>
    Public Function DeleteVerzending(ByVal verzending As TDSBrandweerVerzending) As Boolean
        Return SVC.DeleteVerzending(MyConnection, verzending)
    End Function

#End Region

#Region "Brandweermateriaal - Afdeling"

    <WebMethod(Description:="Get the material for a given department.")>
    Public Function GetAfdelingMateriaal(ByVal afdelingID1 As Integer, ByVal afdelingID2 As Integer, ByVal afdelingID3 As Integer) As TDSBrandweerAfdelingMateriaal

        Dim ds As New TDSBrandweerAfdelingMateriaal
        ds.Merge(SVC.GetAfdelingMateriaal(MyConnection, afdelingID1, afdelingID2, afdelingID3))

        Return ds
    End Function

    <WebMethod(Description:="Get the departemental manager for a given piece of material.")>
    Public Function GetMateriaalBeheerderAfdeling(ByVal typeMatId As Integer, ByVal volgnr As Integer) _
        As TDSBrandweerMateriaalBeheerderAfdeling

        Dim ds As New TDSBrandweerMateriaalBeheerderAfdeling
        ds.Merge(SVC.GetMateriaalBeheerderAfdeling(MyConnection, typeMatId, volgnr))

        Return ds
    End Function

    <WebMethod(Description:="Update the departemental manager for a given piece of material.")>
    Public Function UpdateMateriaalBeheerderAfdeling(ByVal info As TDSBrandweerMateriaalBeheerderAfdeling) As Boolean
        Return SVC.UpdateMateriaalBeheerderAfdeling(MyConnection, info)
    End Function

    <WebMethod(Description:="Update the departemental serial nr for a given piece of material.")>
    Public Function UpdateMateriaalAfdelingVolgnr(ByVal aTypeMatId As Integer, _
                                                             ByVal aMatVolgnr As Integer, _
                                                             ByVal aVolgnummerAfdeling As Integer) As Boolean
        Return SVC.UpdateMateriaalAfdelingVolgnr(MyConnection, aTypeMatId, aMatVolgnr, aVolgnummerAfdeling)
    End Function

    <WebMethod(Description:="Get the list of managers for a given departement1, afd2 and afd3.")>
    Public Function GetBeheerderAfdeling(ByVal afdeling As Integer, ByVal aAfdeling2 As Integer, ByVal aAfdeling3 As Integer) As TDSBrandweerBeheerderAfdeling

        Dim ds As New TDSBrandweerBeheerderAfdeling
        ds.Merge(SVC.GetBeheerderAfdeling(MyConnection, afdeling, aAfdeling2, aAfdeling3))

        Return ds
    End Function

    <WebMethod(Description:="Add a departemental manager.")>
    Public Function AddBeheerderAfdeling(ByVal afdeling As Integer, ByVal naam As String) As Boolean
        Return SVC.AddBeheerderAfdeling(MyConnection, afdeling, naam)
    End Function

    <WebMethod(Description:="Delete a departemental manager with a gived ID.")>
    Public Function DeleteBeheerderAfdeling(ByVal id As Integer) As Boolean
        Return SVC.DeleteBeheerderAfdeling(MyConnection, id)
    End Function

    <WebMethod(Description:="Get the departement AfdelingID that a user belongs to.")>
    Public Function GetAfdelingVoorGebruiker(ByVal gebruiker As String) As Integer
        Return SVC.GetAfdelingVoorGebruiker(MyConnection, gebruiker)
    End Function

    <WebMethod(Description:="Get the departement AfdelingID2 that a user belongs to.")>
    Public Function GetAfdelingVoorGebruiker2(ByVal gebruiker As String) As Integer
        Return SVC.GetAfdelingVoorGebruiker2(MyConnection, gebruiker)
    End Function

    <WebMethod(Description:="Get the departement AfdelingID3 that a user belongs to.")>
    Public Function GetAfdelingVoorGebruiker3(ByVal gebruiker As String) As Integer
        Return SVC.GetAfdelingVoorGebruiker3(MyConnection, gebruiker)
    End Function

    <WebMethod(Description:="Get brandweer users - BMA.")>
    Public Function GetUserBrandweer(ByVal aUser As String) As String
        'naco - 09/02/2017
        Return SVC.GetUserBrandweer(MyConnection, aUser)
    End Function

#End Region

#End Region

#Region "Dienstverslag Brandweer (BS2)"

    <WebMethod(Description:="Get the list of months with 'dienstverslagen'.")>
    Public Function DienstVerslagGetMonths() As TDSDienstverslagMaanden
        Return SVC2.DienstVerslagGetMonths(MyConnection)
    End Function

    <WebMethod(Description:="Get the list of 'dienstverslagen' for a given month.")>
    Public Function DienstVerslagGetLijst(ByVal jaar As Integer, ByVal maand As Integer) As TDSDienstverslagLijst
        Return SVC2.DienstVerslagGetLijst(MyConnection, jaar, maand)
    End Function

    <WebMethod(Description:="Get the list of the fire brigade teams.")>
    Public Function DienstVerslagGetTeams() As TDSDienstVerslagDetailTeams
        Return SVC2.DienstVerslagGetTeams(MyConnection)
    End Function

    <WebMethod(Description:="Get the list of the members of a fire brigade teams.")>
    Public Function DienstVerslagGetTeamMembers(ByVal ploegId As Integer) As TDSDienstVerslagDetailTeamMembers
        Return SVC2.DienstVerslagGetTeamMembers(MyConnection, ploegId)
    End Function

    <WebMethod(Description:="Get the list of possible superior for the fire brigade teams.")>
    Public Function DienstVerslagGetSuperiors() As TDSDienstVerslagDetailOversten
        Return SVC2.DienstVerslagGetSuperiors(MyConnection)
    End Function

    <WebMethod(Description:="Get the list of departments for the fire brigade teams.")>
    Public Function DienstVerslagGetDepartments() As TDSDienstverslagAfdelingen
        Return SVC2.DienstVerslagGetDepartments(MyConnection)
    End Function

    <WebMethod(Description:="Get the list of possible actions for the fire brigade teams.")>
    Public Function DienstVerslagGetActions() As TDSDienstverslagDetailActies
        Return SVC2.DienstVerslagGetActions(MyConnection)
    End Function

    <WebMethod(Description:="Get the details for a 'dienstverslag'.")>
    Public Function DienstVerslagGetDetail(ByVal datum As DateTime, ByVal ploegId As Integer) As TDSDienstVerslagDetail
        Return SVC2.DienstVerslagGetDetail(MyConnection, datum, ploegId)
    End Function

    <WebMethod(Description:="Save the details of a 'dienstverslag'.")>
    Public Function DienstVerslagSave(ByVal detail As TDSDienstVerslagDetail) As Boolean
        Return SVC2.DienstVerslagSave(MyConnection, detail)
    End Function

#End Region

#Region "Brieven Snelheidsovertredingen"

    <WebMethod(Description:="Snelheidsovertreding extern: Haal de basisinformatie om een brief voor een snelheidsovertreding op te maken.")>
    Public Function GetBriefSnelheidsovertredingInfo(ByVal idRegistratie As Integer) As TDSBriefSnelheidsovertredingInfo
        Return SVC2.GetBriefSnelheidsovertredingInfo(MyConnection, idRegistratie)
    End Function

    <WebMethod(Description:="Snelheidsovertreding extern: sla de basisgegevens van een brief op.")>
    Public Sub BewaarSnelheidsOvertredingBrief(ByVal idRegistratie As Integer,
                                                ByVal datumAfdruk As DateTime,
                                                ByVal taal As String,
                                                ByVal recidive As Integer,
                                                ByVal idFirm As Integer)
        SVC2.BewaarSnelheidsOvertredingBrief(MyConnection, idRegistratie, datumAfdruk, taal, recidive, idFirm)
    End Sub

    <WebMethod(Description:="Snelheidsovertreding extern: sanction tabel")>
    Public Function GetSnelheidSanction() As TDSBewakingSnelheidSanction
        Return BS.BusinessServiceFacade.GetSnelheidSanction(MyConnection)
    End Function

    <WebMethod(Description:="Snelheidsovertreding extern: sanction matrix tabel")>
    Public Function GetSnelheidSanctionMatrix() As TDSBewakingSnelheidSanctionMatrix
        Return BS.BusinessServiceFacade.GetSnelheidSanctionMatrix(MyConnection)
    End Function

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
    <WebMethod(Description:="The update of a sanction according to the values given in print-screen")>
    Public Sub UpdateOvertredingPrint(ByVal aID_REG As Integer, ByVal aPrintDate As DateTime,
                                      ByVal aDoubleUp As Boolean, ByVal aKindOfSanction As String,
                                      ByVal aDuration As Integer, ByVal aSanctionPeriod As String,
                                      ByVal aSanctionId As Integer,
                                      ByVal aDatumBrief As DateTime,
                                      ByVal aRevokedDrivingFrom As DateTime,
                                      ByVal aRevokedDrivingTo As DateTime,
                                      ByVal aMeetingPBH As DateTime,
                                      ByVal aFirmId As Integer, ByVal aTaal As String, ByVal aPersonalId As Integer)

        Try
            SVC.UpdateOvertredingPrint(aID_REG, aPrintDate, aDoubleUp, aKindOfSanction, aDuration, aSanctionPeriod,
                                        aSanctionId, aRevokedDrivingFrom, aRevokedDrivingTo, aMeetingPBH, aDatumBrief, aFirmId, aTaal, aPersonalId)
        Catch ex As Exception
            ExceptionManager.Publish(ex, ReThrowOptions.RethrowAsSoapException)
        End Try


    End Sub

    ''' <summary>
    ''' This function clears all sanctions linked to a specific registration
    ''' </summary>
    ''' <param name="aID_Reg">The id of the registration</param>
    ''' <remarks>June 2013 Stijn V.</remarks>
    <WebMethod(Description:="This function clears all sanctions linked to a specific registration")>
    Public Sub ClearSanction(ByVal aID_Reg As Integer)
        Try
            SVC.ClearSanction(aID_Reg)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function add a remark to a specified infraction
    ''' </summary>
    ''' <param name="aID_Reg">The id of the registration</param>
    ''' <remarks>June 2013 Stijn V.</remarks>
    <WebMethod(Description:="This function clears all sanctions linked to a specific registration")>
    Public Sub InsertRemark(ByVal aID_Reg As Integer, ByVal aRemark As String)
        Try
            SVC.InsertRemark(aID_Reg, aRemark)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function makes a report invalid
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    ''' <param name="remark">A remark why the report has been invalidated</param>
    ''' <param name="user">The user who has requested the invalidation</param>
    <WebMethod(Description:="This function makes a report invalid")>
    Public Sub InvalidateReport(ByVal idReg As Integer, ByVal remark As String, ByVal user As String)
        Try
            SVC.InvalidateReport(idReg, remark, user)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function checks whether a report has been invalidated
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    <WebMethod(Description:="This function checks whether a report has been invalidated")>
    Public Function IsReportInvalid(ByVal idReg As Integer) As Boolean
        Try
            Return SVC.IsReportInvalid(idReg)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Throw
        End Try
    End Function

#End Region

#Region "Overzichtslijst inkoop"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - 23/11/2012</remarks>
    <WebMethod(Description:="Lijst bewakingsverslagen met als bestemmeling inkoop IKP")>
    Public Function GetLijstInkoop() As TDSInkoop
        Return BS.BusinessServiceFacade.GetLijstInkoop(MyConnection)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - 06/07/2015</remarks>
    <WebMethod(Description:="Lijst bewakingsverslagen waarvoor vinkje Naar CHIP is aangevinkt (TmsInc = yyyy-MM-dd)")>
    Public Function GetLijstInkoopFirmaVinkjeCHIP(ByVal aTmsInc As String) As TDSInkoopFirmaCHIP
        Return BS.BusinessServiceFacade.GetLijstInkoopFirmaVinkjeCHIP(MyConnection, aTmsInc)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - 23/11/2012</remarks>
    <WebMethod(Description:="Lijst brandweerverslagen met als bestemmeling inkoop IKP")>
    Public Function GetLijstInkoopBrandweer() As TDSBrandweerInkoop
        Return BS.BusinessServiceFacade.GetLijstInkoopBrandweer(MyConnection)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aOPM_IKP"></param>
    ''' <remarks>Nancy Coppens - 04/12/2012</remarks>
    <WebMethod(Description:="Update opmerking IKP")>
    Public Sub UpdateIKPOpmerking(ByVal aOPM_IKP As String, ByVal aID_REG As Integer)
        Try
            SVC.UpdateIKPOpmerking(aOPM_IKP, aID_REG)
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
    <WebMethod(Description:="Update tms send mail IKP")>
    Public Sub UpdateIKPSendMail(ByVal aTMS_IKP_SENDMAIL As String, ByVal aID_REG As Integer)
        Try
            SVC.UpdateIKPSendMail(aTMS_IKP_SENDMAIL, aID_REG)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <remarks>Nancy Coppens - 14/12/2012</remarks>
    <WebMethod(Description:="Update tms send mail IKP = null")>
    Public Sub UpdateIKPSendMailNull(ByVal aID_REG As Integer)
        Try
            SVC.UpdateIKPSendMailNull(aID_REG)
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "BBW - update firm - dec 2015"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pID_FRM"></param>
    ''' <remarks>naco - Thomas Beirens - dec 2015</remarks>
    <WebMethod(Description:="UpdateBBFRM_SAPWithAddress")>
    Public Sub UpdateBBFRM_SAPWithaddress(ByVal pID_FRM As Integer, ByVal pIdFirmSAP As Integer, ByVal pNameSAP As String, ByVal pStreetSAP As String, ByVal pPostcodeSAP As String, ByVal pPlaceSAP As String)

        Try

            SVC.UpdateFirmasBBW(pIdFirmSAP, pNameSAP, pID_FRM, pStreetSAP, pPostcodeSAP, pPlaceSAP)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                     ReThrowOptions.RethrowAsSoapException)
        End Try

    End Sub

    ''' <summary>
    ''' Update Firma: mailcontact, remark, language (necessary if firm is not known in SAP)
    ''' </summary>
    ''' <param name="pID_FRM"></param>
    ''' <param name="pEmailContact"></param>
    ''' <param name="pRemark"></param>
    ''' <param name="pLanguage"></param>
    ''' <remarks>naco - maart 2017</remarks>
    <WebMethod(Description:="UpdateBBFRM with Emailcontact, Remark and Language")>
    Public Sub UpdateBBFRM_EmailRemarkLanguage(ByVal pID_FRM As Integer, ByVal pEmailContact As String, ByVal pRemark As String, ByVal pLanguage As String)

        Try

            SVC.UpdateBBFRM_EmailRemarkLanguage(pID_FRM, pEmailContact, pRemark, pLanguage)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                     ReThrowOptions.RethrowAsSoapException)
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pID_FRM"></param>
    ''' <remarks>naco - Thomas Beirens - dec 2015</remarks>
    <WebMethod(Description:="Update SAP data in BBFRM")>
    Public Sub UpdateBBFRM_SAP(ByVal pID_FRM As Integer, ByVal pIdFirmSAP As Integer, ByVal pNameSAP As String)

        Try

            SVC.UpdateFirmasBBW(pIdFirmSAP, pNameSAP, pID_FRM)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod),
                                     ReThrowOptions.RethrowAsSoapException)
        End Try

    End Sub

#End Region

#Region "CHIP - firm SAP nr (automatically send mail to supplier)"

    ''' <summary>
    ''' Return SAP firm nr for parameter BBW ID_FRM
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 09/09/2016</remarks>
    <WebMethod([Description]:="Get SAP Firm nr (ID_FRM)")>
    Public Function GetCHIP_SAPFirmNr(ByVal aID_FRM As Integer) As Integer
        Try
            Return BS.BusinessServiceFacade.GetSAPFirmNr(MyConnection, aID_FRM)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Return email-addresses of contact persons of a supplier nr
    ''' </summary>
    ''' <returns>string with email-addresses</returns>
    ''' <remarks>Nancy Coppens - 09/09/2016</remarks>
    <WebMethod([Description]:="Get email-contacts of a SAP Firm nr)")>
    Public Function GetCHIP_SAPFirm_EmailContact(ByVal aID_FRM As Integer) As String
        'OPGELET - sidnaco - maart 2017 => wordt niet meer gebruikt
        'vervangen door Firma webservice van Bart Bories (rechtstreeks vanuit de client)
        Try
            Return BS.BusinessServiceFacade.GetSAPFirm_EmailContact(aID_FRM)
        Catch ex As Exception
            Throw
        End Try
    End Function


    ''' <summary>
    ''' Return ID_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
    ''' Necessary to show automatically firm when selecting personal nr
    ''' </summary>
    ''' <returns>ID_FRM</returns>
    ''' <remarks>Nancy Coppens - april 2017</remarks>
    <WebMethod([Description]:="Get ID_FRM (table BBFRM) for SAP firmnr")>
    Public Function GetFirm_ID_FRMforSAPnr(ByVal aNR_IND_FRM_SAP As Integer) As Integer
        'OPGELET - sidnaco - maart 2017 => wordt niet meer gebruikt
        'vervangen door Firma webservice van Bart Bories (rechtstreeks vanuit de client)
        Try
            Return BS.BusinessServiceFacade.GetFirm_ID_FRMforSAPnr(MyConnection, aNR_IND_FRM_SAP)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Return NM_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
    ''' Necessary to show automatically firm when selecting personal nr
    ''' </summary>
    ''' <returns>NM_FRM</returns>
    ''' <remarks>Nancy Coppens - april 2017</remarks>
    <WebMethod([Description]:="Get NM_FRM (table BBFRM) for SAP firmnr")>
    Public Function GetFirm_NM_FRMforSAPnr(ByVal aNR_IND_FRM_SAP As Integer) As String
        'OPGELET - sidnaco - maart 2017 => wordt niet meer gebruikt
        'vervangen door Firma webservice van Bart Bories (rechtstreeks vanuit de client)
        Try
            Return BS.BusinessServiceFacade.GetFirm_NM_FRMforSAPnr(MyConnection, aNR_IND_FRM_SAP)
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

End Class
