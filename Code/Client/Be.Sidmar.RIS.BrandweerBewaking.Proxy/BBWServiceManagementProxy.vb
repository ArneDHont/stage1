Option Explicit On
Option Strict On

Imports System.Collections.Generic
Imports System.Linq


Class BBWServiceManagementWSProxy
    Inherits BBWService.Mgt.Services


    '_user = ADF.Presentation.Windows.ApplicationSecurity.SecurityManager.CurrentSecurityManager.GetUserID()
    'OR using System.Environment.UserName
    Private _user As String = System.Environment.UserName

    Protected Overrides Function GetWebRequest(ByVal uri As System.Uri) As System.Net.WebRequest
        Dim wr As System.Net.WebRequest
        Dim language As String
        wr = MyBase.GetWebRequest(uri)
        language = Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        wr.Headers.Add("Accept-Language", language)
        wr.Headers.Add("UserName", _user)

        'Siddien - nov 2006 - domain account meegeven (windows Auth.)
        wr.Credentials = System.Net.CredentialCache.DefaultCredentials
        Return wr
    End Function
End Class


Class BBWServiceManagementProxy
    Inherits ADF.RemoteServices.WebServiceProxyBase

    Private _webService As BBWServiceManagementWSProxy

    Public Sub New()
        MyBase.New()
        Me.LogicalName = "BBWService.Mgt"
        _webService = New BBWServiceManagementWSProxy

        'weglaten
        '17/11/2006 - nee, zeker niet weglaten, want anders werkt de code niet op QA en PROD,
        'de code werkt dan enkel lokaal goed (localhost)!!!
        'sidnaco - Eric Uittenhove
        _webService.Url = Me.Url
    End Sub

    Public Overridable ReadOnly Property WebService As BBWServiceManagementWSProxy
        Get
            Return _webService
        End Get
    End Property
End Class


Public Class BBWServiceManagementServicesProxy

    Private myProxy As BBWServiceManagementProxy

    Public Sub New()
        MyBase.New()
        myProxy = New BBWServiceManagementProxy
    End Sub

#Region "GetCodeTables"

    Public Function GetInterventieType() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInterventieType()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing
    End Function

    Public Function GetInbreukArtikel(ByVal type As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInbreukArt(type)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing  'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVoertuigTypes() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVoertuigTypes
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAanspreektitel() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAanspreektitel
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetPloeg() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetPloeg
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetGebruikVoertuig() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetGebruikVoertuig
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetEenheden() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetEenheden()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegistratieType() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegistratieType()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetArtikelgroepen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetArtikelGroepen()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetIndividutypes() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetIndividuTypes()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAfdelingen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAfdelingen()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetTypeBetrokkenen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetTypeBetrokkenen()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetOorzaken(ByVal IntvType As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetOorzaken(IntvType)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAarden(ByVal IntvType As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAarden(IntvType)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005 
    End Function

    Public Function GetInbrType() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInbreukType()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetOvertrederType() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrIndTy
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetOvertrederType
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetScadObjecten() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetScadObjecten()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetDiefDup() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefDup
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetDiefDup()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetWerfVoertuig() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetWerfVoertuig()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetToestandType() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSToestandType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetToestandType()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetToestanden() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSToestanden
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetToestanden()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBewakingDup() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBewakingDup
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBewakingDup()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVaststellerAanrijding() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVaststellerAanrijding
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVaststellerAanrijding()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "GetBBWData"

    Public Function GetPersonalIdsToAvoidDuringMailing() As List(Of String)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Dim personList As String() = {}
                personList = myProxy.WebService.GetHierarchicalPersonalIdsToAvoid
                If personList.Length > 0 Then
                    Return personList.ToList()
                Else
                    Return New List(Of String)
                End If

            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetMaxBBTSP() As Integer
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetMaxBBTSP()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetIndividuen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetIndividuen
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetIndividu(ByVal id_ind As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
        Dim FirstTry As Boolean = True

        Do While ((myProxy.Finished = False) OrElse FirstTry)
            Try
                FirstTry = False
                Return myProxy.WebService.GetIndividu(id_ind)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetInterventies() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvBr
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInterventies
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetMilieuverontreinigingen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvBr
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetMilieuverontreinigingen
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBWPersoneel() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBWAKPers
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBBWAKPersoneel()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBWPersoneelActief() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBWAKPers
        'naco - 08/02/2017
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBBWAKPersoneelActief()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBRPersoneel() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBRPers
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBBBRPersoneel()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBRPersoneelActief() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBRPers
        'naco - 08/02/2017
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBBBRPersoneelActief()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetInterventie(ByVal IdIntvBrdw As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInterventie
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInterventie(IdIntvBrdw)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegistraties() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegBew
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegistraties
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegSchadegeval(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegSchadegeval(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAanrijding(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding
        Dim FirstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                OrElse FirstTry)
            Try
                FirstTry = False
                Return myProxy.WebService.GetAanrijding(IdRegBew)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetDiefstallenPerTrimester() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTrimesterDiefstal
        Dim FirstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                OrElse FirstTry)
            Try
                FirstTry = False
                Return myProxy.WebService.GetDiefstallenPerTrimester
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegAlcoholtest(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegAlcoholtest(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegDiefstal(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegDiefstal(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegOpenKleerkast(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegOpenKleerkast(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegDivRegistratie(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegDivRegistratie(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegInbreukRegl(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbreukRegl
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegInbreukRegl(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetRegControleVoertuig(ByVal IdRegBew As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetRegControleVoertuig(IdRegBew)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVastgesteldeInbreuken(ByVal IdInd As Integer, ByVal IdRegistratie As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVastgesteldeInbreuken
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVastgesteldeInbreuken(IdInd, IdRegistratie)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVerzFirmas() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVerzFirmas
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetFirmas() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetFirmas
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetFirmaIdForRegistration(ByVal pRegistratieId As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetFirmaIdForRegistration(pRegistratieId)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVoertuigen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVoertuigen
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetInterventieArtikelen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetInterventieArtikelen
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVerbruiksArtikelen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVerbruiksArtikelen
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetVerbruiksArtikelenMinStock() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetVerbruiksArtikelenMinStock
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Sub GetMaxValuesInterventie(ByVal InterventieTypeID As Integer, _
                                        ByVal AfdelingID As Integer, _
                                        ByVal jaartal As Integer, _
                                        ByRef maxInterventieID As Integer, _
                                        ByRef maxAfdelingVolgnummer As Integer, _
                                        ByRef maxJaarVolgnummer As Integer)
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.GetMaxValuesInterventie(InterventieTypeID, AfdelingID, jaartal, _
                             maxInterventieID, maxAfdelingVolgnummer, maxJaarVolgnummer)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
    End Sub

    Public Sub GetMaxValuesRegistratie(ByVal tmsRegistratie As Date, _
                                       ByRef id_reg As Integer, _
                                       ByRef volgnr_reg_jaar As Integer)
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.GetMaxValuesRegistratie(tmsRegistratie, id_reg, volgnr_reg_jaar)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
    End Sub

    Public Function GetBrandenPerAfdelingMaand(ByVal Maand As Integer, ByVal Jaar As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandenPerAfdeling

        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBrandenPerAfdelingMaand(Maand, Jaar)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBrandenPerAfdelingJaar(ByVal Jaar As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandenPerAfdeling

        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBrandenPerAfdelingJaar(Jaar)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBrandenPerAfdelingAardJaar(ByVal Jaar As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandenPerAfdeling

        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBrandenPerAfdelingAardJaar(Jaar)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBrandenPerAfdelingOorzaakJaar(ByVal Jaar As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBrandenPerAfdeling

        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBrandenPerAfdelingOorzaakJaar(Jaar)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetDagverslagPersoneel(ByVal datumVanaf As DateTime) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetDagverslagenPersoneel(datumVanaf)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetSpecBestForMailMetBijlage() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBSTBY
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetSpecBestForMailWitBijlage()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function DetermineSpeedingSanction(ByVal pIsTruck As Boolean,
                                            ByVal pSpeedingLimit As Integer,
                                            ByVal pVelocity As Integer,
                                            ByVal pRecidive As Integer) As Integer
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.DetermineSpeedingSanction(pIsTruck, pSpeedingLimit, pVelocity, pRecidive)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

#End Region


#Region "UpdateBBWData"

    Public Sub UpdateFirmasWithAddress(ByVal pID_FRM As Integer, ByVal pIdFirmSAP As Integer, ByVal pNameSAP As String, ByVal pStreetSAP As String, ByVal pPostcodeSAP As String, ByVal pPlaceSAP As String)

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateBBFRM_SAPWithaddress(pID_FRM, pIdFirmSAP, pNameSAP, pStreetSAP, pPostcodeSAP, pPlaceSAP)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop

    End Sub

    Public Sub UpdateFirmas(ByVal pID_FRM As Integer, ByVal pIdFirmSAP As Integer, ByVal pNameSAP As String)

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateBBFRM_SAP(pID_FRM, pIdFirmSAP, pNameSAP)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop

    End Sub

    Public Sub UpdateBBFRM_EmailRemarkLanguage(pID_FRM As Integer, pEmailContact As String, pRemark As String, pLanguage As String)

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateBBFRM_EmailRemarkLanguage(pID_FRM, pEmailContact, pRemark, pLanguage)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop

    End Sub

#End Region

#Region "Configuration Settings"
    Public Function GetConfigurationSettings() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSConfiguratie
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetConfigurationSettings
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAddresseesFromConfig(ByVal configKey As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBestemmelingen
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAddresseesFromConfig(configKey)
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBaseLinkVera() As String
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBaseLinkVera()
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try

        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Register Interventie Brandweer"
    Public Function RegisterInterventie(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInterventie, _
                                        ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInterventie
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInterventie
                dstemp = myProxy.WebService.RegisterInterventie(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Register personeel"
    Public Function RegisterPersoneel(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                OrElse firstTry)
            Try
                firstTry = False
                Dim dsTemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS
                dsTemp = myProxy.WebService.RegisterPersoneel(data, user)
                Return dsTemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Register AFDAMC"
    Public Function RegisterAFDAMC(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC, _
                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
            OrElse firstTry)
            Try
                firstTry = False
                Dim dsTemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC
                dsTemp = myProxy.WebService.RegisterAFDAMC(data, user)
                Return dsTemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing
    End Function
#End Region

#Region "Register Bewakingsregistratie"
#Region "Alcoholtest"

    Public Function RegisterRegistratieAlcoholtest(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAlcoholtest
                dstemp = myProxy.WebService.RegisterRegistratieAlcoholtest(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Diefstal"
    Public Function RegisterRegistratieDiefstal(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDiefstal
                dstemp = myProxy.WebService.RegisterRegistratieDiefstal(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "OpenKleerkast"
    Public Function RegisterRegistratieOpenKleerkast(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOpenKleerkast
                dstemp = myProxy.WebService.RegisterRegistratieOpenKleerkast(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Schadegeval"
    Public Function RegisterRegistratieSchadegeval(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSSchadegeval
                dstemp = myProxy.WebService.RegisterRegistratieSchadegeval(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Diverse Registratie"
    Public Function RegisterRegistratieDivRegistratie(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDivRegistratie
                dstemp = myProxy.WebService.RegisterRegistratieDivRegistratie(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Controle Voertuig"
    Public Function RegisterRegistratieControleVoertuig(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSControleVoertuig
                dstemp = myProxy.WebService.RegisterRegistratieControleVoertuig(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Inbreuk op reglementen"
    Public Function RegisterRegistratieInbreukRegl(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbreukRegl, _
                                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbreukRegl
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbreukRegl
                dstemp = myProxy.WebService.RegisterRegistratieInbreukRegl(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#End Region

#Region "Register CodeTables"

#Region "RegisterAarden"
    Public Function RegisterAarden(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAarden
                dstemp = myProxy.WebService.RegisterAarden(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterOorzaken"
    Public Function RegisterOorzaken(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSOorzaken
                dstemp = myProxy.WebService.RegisterOorzaken(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterInterventietype"
    Public Function RegisterInterventietype(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvType
                dstemp = myProxy.WebService.RegisterInterventietype(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterAfdelingen"
    Public Function RegisterAfdelingen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAfdelingen
                dstemp = myProxy.WebService.RegisterAfdelingen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterEenheden"
    Public Function RegisterEenheden(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSEenheden
                dstemp = myProxy.WebService.RegisterEenheden(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterArtikelgroepen"
    Public Function RegisterArtikelgroepen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSArtikelgroep
                dstemp = myProxy.WebService.RegisterArtikelgroepen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterInbreuktypes"
    Public Function RegisterInbreuktypes(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrType
                dstemp = myProxy.WebService.RegisterInbreuktypes(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterRegistratietypes"
    Public Function RegisterRegistratietypes(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegType
                dstemp = myProxy.WebService.RegisterRegistratietypes(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterIndividutypes"
    Public Function RegisterIndividutypes(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuType
                dstemp = myProxy.WebService.RegisterIndividutypes(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterInbreukartikelen"
    Public Function RegisterInbreukartikelen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSInbrArt
                dstemp = myProxy.WebService.RegisterInbreukartikelen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterTypesBetrokkenen"
    Public Function RegisterTypesBetrokkenen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSTypeBetrokkene
                dstemp = myProxy.WebService.RegisterTypesBetrokkenen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterTypesVoertuigen"
    Public Function RegisterTypesVoertuigen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigTypes
                dstemp = myProxy.WebService.RegisterTypesVoertuigen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterAanspreektitels"
    Public Function RegisterAanspreektitels(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanspreektitel
                dstemp = myProxy.WebService.RegisterAanspreektitels(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterPloeg"
    Public Function RegisterPloeg(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSPloeg
                dstemp = myProxy.WebService.RegisterPloeg(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterSchadeAan"
    Public Function RegisterSchadeAan(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSScadObjecten
                dstemp = myProxy.WebService.RegisterSchadeAan(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterGebruikVoertuig"
    Public Function RegisterGebruikVoertuig(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSGebruikVoertuig
                dstemp = myProxy.WebService.RegisterGebruikVoertuig(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterWerfvoertuigen"
    Public Function RegisterWerfvoertuig(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSWerfVoertuig
                dstemp = myProxy.WebService.RegisterWerfvoertuig(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "RegisterInterventieartikelen"
    Public Function RegisterInterventieartikelen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIntvArt
                dstemp = myProxy.WebService.RegisterInterventieartikelen(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region
#Region "Register dagverslag registratietypes"
    Public Function RegisterDagverslagRegistratieType(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType, _
                                                    ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Dim dsTemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
                dsTemp = myProxy.WebService.RegisterDagverslagRegistratieType(data, user)
                Return dsTemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#End Region

#Region "RegisterStock"
    Public Function RegisterStock(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel, _
                                       ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerbruiksArtikel
                dstemp = myProxy.WebService.RegisterStock(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Individu"
    Public Function RegisterIndividu(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen, _
                    ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
        'Siddien - sept 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSIndividuen
                dstemp = myProxy.WebService.RegisterIndividu(data, user)
                Return dstemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Sub updateIndividuBestemmeling(ByVal id_ind As Integer, _
                                          ByVal mailadres As String, _
                                          ByVal user As String)
        'Siddien - sept 2006
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.updateIndividuBestemmeling(id_ind, mailadres, user)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop

    End Sub
#End Region

#Region "Register firma's"
    Public Function RegisterFirmas(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas, _
                            ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSFirmas
                dstemp = myProxy.WebService.RegisterFirma(data, user)
                Return dstemp
            Catch ex As System.Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Register verz. firma's"
    Public Function RegisterVerzFirmas(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas, _
                                        ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Dim dsTemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVerzFirmas
                dsTemp = myProxy.WebService.RegisterVerzFirmas(data, user)
                Return dsTemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

    Public Function RegisterRegistratieAanrijding(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding, ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSAanrijding
        'Siddien - okt. 2006
        'Doel: opslaan registratie aanrijding
        Dim firsttry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firsttry)
            Try
                firsttry = False
                Return myProxy.WebService.RegisterRegistratieAanrijding(data, user)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function RegisterDagverslagPersoneel(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel, _
                                    ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel
        Dim firstTry As Boolean = True

        Do While ((myProxy.Finished = False) _
                OrElse firstTry)
            Try
                firstTry = False
                Dim dstemp As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagPersoneel
                dstemp = myProxy.WebService.RegisterDagverslagPersoneel(data, user)
                Return dstemp
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function DagverslagRegistratieTypes() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
        'Siddien - okt 2006
        'Doel: ophalen van de dagverslagen registratietypes
        Dim firsttry As Boolean = True

        Do While ((myProxy.Finished = False) _
                OrElse firsttry)
            Try
                firsttry = False
                Return myProxy.WebService.DagverslagRegistratieTypes()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetLastStamnummer() As Integer
        'Siddien - okt 2006
        'Doel: ophalen laatste stamnummer (om een externe toe te voegen)
        Dim firsttry As Boolean = True

        Do While ((myProxy.Finished = False) _
                    OrElse firsttry)
            Try
                firsttry = False
                Return myProxy.WebService.GetLastStamnummer()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetDagverslagInlichtingen(ByVal datumVanaf As DateTime, _
                                              ByVal datumTot As DateTime) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingen
        'Auteur: Siddien - okt 2006
        'Doel: Ophalen dagverslag inlichtingen.

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetDagverslagInlichtingen(datumVanaf, datumTot)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetDagverslagInlichtingTypes() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
        'Auteur: Siddien - okt 2006
        'Doel: Ophalen dagverslag inlichtingentypes

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetDagverslagInlichtingenType()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function BestaatDagverslagInlichtingVoorDag(ByVal datum As DateTime) As Boolean
        'Auteur: Siddien - okt 2006

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.BestaatDagverslagInlichtingVoorDag(datum)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function RegisterDagverslagInlichtingen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingen, ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingen
        'Auteur: Siddien - okt. 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.RegisterDagverslagInlichtingen(data, user)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function RegisterDagverslagInlichtingType(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType, ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
        'Auteur: Dien - okt 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.RegisterDagverslagInlichtingType(data, user)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function RegisterVoertuigen(ByVal data As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen, ByVal user As String) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSVoertuigen
        'Auteur: Siddien - okt. 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.RegisterVoertuigen(data, user)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetAanrijdingBetrokkenen(ByVal id_reg As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBTROGV
        'Auteur: DIEN - okt. 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) _
                    OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAanrijdingBetrokkenen(id_reg)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function GetBBBWPersoneel() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBBWPERS
        'Auteur: Dien - okt. 2006
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBBBWPersoneel()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    Public Function getafdamc() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBBAFDAMC
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetAFDAMC
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing
    End Function

#Region "Maandverslag Bewaking - Inbreuk reglementen"
    Public Function GetLijstInbreukReglementen() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSLijstInbreukRegl
        'Doel:   Lijst inbreuk reglementen (voor maandrapporten)
        'Auteur: Nancy Coppens - 19/12/2006

        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetLijstInbreukReglementen
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

#Region "Dagverslag personeel verstuurd"
    Public Sub ToevoegenDagverslagPersoneel(ByVal datum As DateTime)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.ToevoegenDagverslagPersoneel(datum)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    Public Function dagVerslagPersoneelReedsDoorgestuurd(ByVal datum As DateTime) As Boolean
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.dagVerslagPersoneelReedsDoorgestuurd(datum)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop

        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function
#End Region

    Public Sub saveAMC(ByVal atds As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.saveAMC(atds)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    Public Sub UpdateAFDAMC(ByVal aID_AFD As Integer, ByVal aID_IND As Integer, ByVal aOldID_IND As Integer)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateAFDAMC(aID_AFD, aID_IND, aOldID_IND)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    Public Function GetBestemmelingenAfdeling(ByVal id_afd As Integer) As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetBestemmelingenAfdeling(id_afd)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing
    End Function

    Public Function GetMilieuVerontreinigingenBewaking() As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSRegBew
        Dim FirstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse FirstTry)
            Try
                FirstTry = False
                Return myProxy.WebService.GetMilieuVerontreinigingenBewaking()
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing
    End Function

    Public Sub CHIPUpdate(ByVal aID_REG As Integer, ByVal aSAP_SUPPLIER_ID As String, _
                            ByVal aDT_CHIP As DateTime, ByVal aOPM_CHIP As String)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.CHIPUpdate(aID_REG, aSAP_SUPPLIER_ID, aDT_CHIP, aOPM_CHIP)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    Public Sub CHIPRegistration(ByVal aID_REG As Integer, ByVal aCHIP_YN As Boolean)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.CHIPRegistration(aID_REG, aCHIP_YN)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Intern"></param>
    ''' <returns></returns>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Public Function GetLijstSnelheidsovertredingen(ByVal Intern As Boolean) As BBWService.Mgt.TDSSnelheidsOvertredingen
        'Sidlawv - april 2011
        'Doel: ophalen van de snelheidsovertredingen
        Dim firsttry As Boolean = True

        Do While ((myProxy.Finished = False) _
                OrElse firsttry)
            Try
                firsttry = False
                Return myProxy.WebService.GetLijstSnelheidsovertredingen(Intern)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Intern"></param>
    ''' <returns></returns>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Public Function GetOvertredingen(ByVal Intern As Boolean,
                                     ByVal aDatefrom As DateTime) As BBWService.Mgt.TDSOvertreding
        'Sidlawv - april 2011
        'Doel: ophalen van de snelheidsovertredingen
        Dim firsttry As Boolean = True

        Do While ((myProxy.Finished = False) _
                OrElse firsttry)
            Try
                firsttry = False
                'Return myProxy.WebService.GetLijstOvertredingen(Intern, aDatefrom)
                Return myProxy.WebService.GetLijstOvertredingen(Intern, New DateTime(2000, 1, 1))
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
        Return Nothing 'Dien - aug2008 - migratie VS2005
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aRijverbodVan"></param>
    ''' <param name="aRijverbodTot"></param>
    ''' <param name="aAfspraakPBH"></param>
    ''' <param name="aContactID"></param>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Public Sub UpdateRijverbod(ByVal aID_REG As Integer, ByVal aRijverbodVan As DateTime, _
                                              ByVal aRijverbodTot As DateTime, ByVal aAfspraakPBH As DateTime, ByVal aContactID As Integer)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateRijverbod(aID_REG, aRijverbodVan, aRijverbodTot, aAfspraakPBH, aContactID)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Public Sub UpdateRijverbodLegeDatums(ByVal aID_REG As Integer)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateRijverbodLegeDatums(aID_REG)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_REG"></param>
    ''' <param name="aAfdruk"></param>
    ''' <param name="aContactID"></param>
    ''' <remarks>SIDVRST - 02/05/2013</remarks>
    Public Sub UpdateSnelheidsovertredingPrint(ByVal aID_REG As Integer, ByVal aAfdruk As DateTime, ByVal aContactID As Integer)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateSnelheidsovertredingPrint(aID_REG, aAfdruk, aContactID)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    ''' <summary>
    ''' This function updates the date on which PEB sent the letter to the firm
    ''' </summary>
    ''' <param name="aID_REG">The id of the registration</param>
    ''' <param name="aDateSent">The date on which the letter was sent</param>
    ''' <remarks>02/05/2013 SIDVRST</remarks>
    Public Sub UpdateDateLetterSent(ByVal aID_REG As Integer, ByVal aDateSent As DateTime)
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                myProxy.WebService.UpdateDateLetterSent(aID_REG, aDateSent)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Sub

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    ' June 2013: Stijn Vranken
    ' Code put out of service => Sodie interaction switched to serverside
    ' This following the insert/update of an record in BBW-Database
    'Public Sub InsertSoDie(ByVal aStamNr As Integer, ByVal aRegID As Integer)
    '    Dim firstTry As Boolean = True
    '    Do While ((myProxy.Finished = False) OrElse firstTry)
    '        Try
    '            firstTry = False
    '            myProxy.WebService.InsertSoDie(aStamNr, aRegID)
    '        Catch ex As Exception
    '            myProxy.HandleException(ex)
    '        End Try
    '    Loop
    'End Sub

    'Public Function DetermineSodieInfraction(ByVal aArtNrId As Integer) As Boolean
    '    Dim firstTry As Boolean = True
    '    Do While ((myProxy.Finished = False) OrElse firstTry)
    '        Try
    '            firstTry = False
    '            Return myProxy.WebService.DetermineSodieInfraction(aArtNrId)
    '        Catch ex As Exception
    '            myProxy.HandleException(ex)
    '        End Try
    '    Loop
    'End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

#Region "Brandweer"

#Region "Brandweer - Materiaal op Locatie - Aug 2011"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - gmae - 19/08/2011</remarks>
    Public Function GetBrandweerMateriaalLijst() As BBWService.Mgt.TDSBrandweerMateriaal
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerMateriaalLijst)
    End Function

    Public Function GetBrandweerMateriaalByTypeVolgnr(ByVal typeMateriaal As Integer, ByVal volgnummer As Integer) As BBWService.Mgt.TDSBrandweerMateriaalItem
        Return DoRetries(Function() myProxy.WebService.GetBrandweerMateriaalByTypeVolgnr(typeMateriaal, volgnummer))
    End Function

    Public Function GetBrandweerMaterialTypes() As BBWService.Mgt.TDSBrandweerMateriaalTypes
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerMaterialTypes)
    End Function

    Public Function GetBrandweerExtinguisherTypes() As BBWService.Mgt.TDSBrandweerExtinguisherTypes
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerExtinguisherTypes)
    End Function

    Public Function GetBrandweerSuppliers() As BBWService.Mgt.TDSBrandweerLeveranciers
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerSuppliers)
    End Function

    Public Function GetBrandweerDepartments() As BBWService.Mgt.TDSBrandweerAfdelingen
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerDepartments)
    End Function

    Public Function GetBrandweerStatus() As BBWService.Mgt.TDSBrandweerStatus
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerStatus)
    End Function

    Public Function GetBrandweerManagers() As BBWService.Mgt.TDSBrandweerBeheerderAfdeling
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerManagers)
    End Function

    Public Function GetBrandweerVerzending() As BBWService.Mgt.TDSBrandweerVerzending
        Return DoRetries(AddressOf myProxy.WebService.GetBrandweerVerzending)
    End Function

    Public Function BrandweerMateriaalBestaat(ByVal typeMateriaal As Integer, ByVal locatieId As Integer, ByVal locatieNr As String) As Boolean
        Return DoRetries(Function() myProxy.WebService.BrandweerMateriaalBestaat(typeMateriaal, locatieId, locatieNr))
    End Function

    Public Function SaveBrandweerMateriaal(ByVal materiaal As BBWService.Mgt.TDSBrandweerMateriaalItem) As Boolean
        Return DoRetries(Function() myProxy.WebService.SaveBrandweerMateriaal(materiaal))
    End Function

    Public Function UpdateMateriaalDateDeleted(ByVal aType As Integer, ByVal aVolgnr As Integer, ByVal aUserDeleted As String) As Boolean
        Return DoRetries(Function() myProxy.WebService.UpdateMateriaalDateDeleted(aType, aVolgnr, aUserDeleted))
    End Function


#End Region

#Region "Brandweer - Vervangmateriaal"

    Public Function BrandweerMarkeerVervangMateriaal(ByVal type As Integer, ByVal volgnr As Integer, ByVal plaats As Integer) As Boolean
        Return DoRetries(Function() myProxy.WebService.BrandweerMarkeerVervangMateriaal(type, volgnr, plaats))
    End Function

    Public Function BrandweerVrijgaveVervangMateriaal(ByVal type As Integer, ByVal volgnr As Integer) As Boolean
        Return DoRetries(Function() myProxy.WebService.BrandweerVrijgaveVervangMateriaal(type, volgnr))
    End Function

    Public Function GetBrandweerVervangLijst(ByVal type As Integer) As BBWService.Mgt.TDSBrandweerMateriaal
        Return DoRetries(Function() myProxy.WebService.GetBrandweerVervangLijst(type))
    End Function

    Public Function BrandweerGetMateriaalOmschr(ByVal aMateriaalvolgnr As Integer) As String
        Return DoRetries(Function() myProxy.WebService.BrandweerGetMateriaalOmschr(aMateriaalvolgnr))
    End Function

#End Region

#Region "Brandweer - Materiaalfiche"

    ''' <summary>
    ''' Get the list of all actions.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBrandweerActie() As BBWService.Mgt.TDSBrandweerActie
        Return DoRetries(Function() myProxy.WebService.GetBrandweerActie())
    End Function

    ''' <summary>
    ''' Get the list of actions and measured weights for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer) As BBWService.Mgt.TDSBrandweerMateriaalActie
        Return DoRetries(Function() myProxy.WebService.GetMateriaalActie(type, volgnr))
    End Function

    ''' <summary>
    ''' Store a measured weight for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <param name="datum"></param>
    ''' <param name="gewicht"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StoreMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime, ByVal actie As Integer?, ByVal gewicht As Decimal?) As Boolean
        Return DoRetries(Function() myProxy.WebService.StoreMateriaalActie(type, volgnr, datum, actie, gewicht))
    End Function

    ''' <summary>
    ''' Delete a measured weight for a piece of material.
    ''' </summary>
    ''' <param name="id">The ID of the material action entry.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteMateriaalActieById(ByVal id As Integer) As Boolean
        Return DoRetries(Function() myProxy.WebService.DeleteMateriaalActieById(id))
    End Function

    ''' <summary>
    ''' Delete a measured weight for a piece of material.
    ''' </summary>
    ''' <param name="type">The material type.</param>
    ''' <param name="volgnr">The material number.</param>
    ''' <param name="datum"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteMateriaalActie(ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime) As Boolean
        Return DoRetries(Function() myProxy.WebService.DeleteMateriaalActie(type, volgnr, datum))
    End Function

#End Region

#Region "Brandweer - Reports"

    ''' <summary>
    ''' Get the overview of refilled fire extingoushers.
    ''' </summary>
    ''' <param name="jaar">The year for this report.</param>
    ''' <param name="perAfdeling">True = by department, False = by type.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalHervuld(ByVal jaar As Integer, ByVal perAfdeling As Boolean) As BBWService.Mgt.TDSBrandweerReportHervuldeBlustoestellen
        Return DoRetries(Function() myProxy.WebService.GetMateriaalHervuld(jaar, perAfdeling))
    End Function

    ''' <summary>
    ''' Get the list of materials that must be inspected.
    ''' </summary>
    ''' <param name="isVisueleControle">True = visuele controle, False = Poedercontrole</param>
    ''' <param name="datumVorigeControle">Datum waarvoor de vorige controle moet liggen.</param>
    ''' <returns>De lijst van materiaal dat geïnspecteerd moet worden.</returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalControleLijst(ByVal isVisueleControle As Boolean, ByVal datumVorigeControle As DateTime) As BBWService.Mgt.TDSBrandweerMateriaalControleLijst
        Return DoRetries(Function() myProxy.WebService.GetMateriaalControleLijst(isVisueleControle, datumVorigeControle))
    End Function

    ''' <summary>
    ''' Save the list of materials that must be inspected.
    ''' </summary>
    ''' <param name="controleLijst">De list van geïnspecteerd materiaal</param>
    ''' <param name="isVisueleControle">True = visuele controle, False = Poedercontrole</param>
    ''' <param name="nieuweDatum">De datum waarop de controles uitgevoerd werden.</param>
    ''' <returns>True als de wijzigingen correct opgeslagen zijn.</returns>
    ''' <remarks></remarks>
    Public Function SaveMateriaalControleLijst(ByVal controleLijst As BBWService.Mgt.TDSBrandweerMateriaalControleLijst, ByVal isVisueleControle As Boolean, ByVal nieuweDatum As DateTime) As Boolean
        Return DoRetries(Function() myProxy.WebService.SaveMateriaalControleLijst(controleLijst, isVisueleControle, nieuweDatum))
    End Function

#End Region

#Region "Brandweer - Verzending"

    ''' <summary>
    ''' Get the overview of material that has been shipped to the supplier.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVerzendingLijst() As BBWService.Mgt.TDSBrandweerVerzendingLijst
        Return DoRetries(Function() myProxy.WebService.GetVerzendingLijst())
    End Function

    ''' <summary>
    ''' Get a shipping record.
    ''' </summary>
    ''' <param name="id">The ID of the shipping record.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVerzending(ByVal id As Integer) As BBWService.Mgt.TDSBrandweerVerzending
        Return DoRetries(Function() myProxy.WebService.GetVerzending(id))
    End Function

    ''' <summary>
    ''' Store the 'sent' information for a piece of material.
    ''' </summary>
    ''' <param name="verzending"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StoreVerzending(ByVal verzending As BBWService.Mgt.TDSBrandweerVerzending) As Boolean
        Return DoRetries(Function() myProxy.WebService.StoreVerzending(verzending))
    End Function

    ''' <summary>
    ''' Delete the 'sent' information for a piece of material.
    ''' </summary>
    ''' <param name="verzending"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteVerzending(ByVal verzending As BBWService.Mgt.TDSBrandweerVerzending) As Boolean
        Return DoRetries(Function() myProxy.WebService.DeleteVerzending(verzending))
    End Function

#End Region

#Region "Brandweermateriaal - Afdeling"

    ''' <summary>
    ''' Get the material for a given department.
    ''' </summary>
    ''' <param name="afdeling">Department ID.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAfdelingMateriaal(ByVal afdelingID1 As Integer, ByVal afdelingID2 As Integer, ByVal afdelingID3 As Integer) As BBWService.Mgt.TDSBrandweerAfdelingMateriaal
        Return DoRetries(Function() myProxy.WebService.GetAfdelingMateriaal(afdelingID1, afdelingID2, afdelingID3))
    End Function

    ''' <summary>
    ''' Get the departemental manager for a given piece of material.
    ''' </summary>
    ''' <param name="typeMatId">ID of the material type.</param>
    ''' <param name="volgnr">Sequence number of the material.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMateriaalBeheerderAfdeling(ByVal typeMatId As Integer, ByVal volgnr As Integer) As BBWService.Mgt.TDSBrandweerMateriaalBeheerderAfdeling
        Return DoRetries(Function() myProxy.WebService.GetMateriaalBeheerderAfdeling(typeMatId, volgnr))
    End Function

    ''' <summary>
    ''' Update the departemental serial material nr for a given piece of material.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - 10/07/2017</remarks>
    Public Function UpdateMateriaalAfdelingVolgnr(ByVal aTypeMatId As Integer, _
                                                             ByVal aMatVolgnr As Integer, _
                                                             ByVal aVolgnummerAfdeling As Integer) As Boolean
        Return DoRetries(Function() myProxy.WebService.UpdateMateriaalAfdelingVolgnr(aTypeMatId, aMatVolgnr, aVolgnummerAfdeling))
    End Function

    Public Function UpdateMateriaalBeheerderAfdeling(ByVal info As BBWService.Mgt.TDSBrandweerMateriaalBeheerderAfdeling) As Boolean
        Return DoRetries(Function() myProxy.WebService.UpdateMateriaalBeheerderAfdeling(info))
    End Function

    ''' <summary>
    ''' Get the list of managers for a given departement.
    ''' </summary>
    ''' <param name="afdeling">ID of the departement.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBeheerderAfdeling(ByVal afdeling As Integer, ByVal aAfdeling2 As Integer, ByVal aAfdeling3 As Integer) As BBWService.Mgt.TDSBrandweerBeheerderAfdeling
        Return DoRetries(Function() myProxy.WebService.GetBeheerderAfdeling(afdeling, aAfdeling2, aAfdeling3))
    End Function

    ''' <summary>
    ''' Add a departemental manager.
    ''' </summary>
    ''' <param name="afdeling">ID of the departement.</param>
    ''' <param name="naam">Name of the manager.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddBeheerderAfdeling(ByVal afdeling As Integer, ByVal naam As String) As Boolean
        Return DoRetries(Function() myProxy.WebService.AddBeheerderAfdeling(afdeling, naam))
    End Function

    ''' <summary>
    ''' Delete a departemental manager with a gived ID.
    ''' </summary>
    ''' <param name="id">ID of the departemental manager.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteBeheerderAfdeling(ByVal id As Integer) As Boolean
        Return DoRetries(Function() myProxy.WebService.DeleteBeheerderAfdeling(id))
    End Function

    ''' <summary>
    ''' Get the departement that a user belongs to.
    ''' </summary>
    ''' <param name="gebruiker">The login ID of the user (e.g. SIDXXXX).</param>
    ''' <returns>The department ID (or -1 if the user cannot be found).</returns>
    ''' <remarks></remarks>
    Public Function GetAfdelingVoorGebruiker(ByVal gebruiker As String) As Integer
        Return DoRetries(Function() myProxy.WebService.GetAfdelingVoorGebruiker(gebruiker))
    End Function

    Public Function GetAfdelingVoorGebruiker2(ByVal gebruiker As String) As Integer
        Return DoRetries(Function() myProxy.WebService.GetAfdelingVoorGebruiker2(gebruiker))
    End Function

    Public Function GetAfdelingVoorGebruiker3(ByVal gebruiker As String) As Integer
        Return DoRetries(Function() myProxy.WebService.GetAfdelingVoorGebruiker3(gebruiker))
    End Function

#End Region

#End Region

#Region "Dienstverslag"

    ''' <summary>
    ''' Get the list of months with 'dienstverslagen'.
    ''' </summary>
    ''' <returns>The list of available months.</returns>
    ''' <remarks></remarks>
    Public Function DienstverslagGetMonths() As BBWService.Mgt.TDSDienstverslagMaanden
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetMonths())
    End Function

    ''' <summary>
    ''' Get the list of 'dienstverslagen' for a given month.
    ''' </summary>
    ''' <param name="jaar">Het jaar.</param>
    ''' <param name="maand">De maand.</param>
    ''' <returns>The overview of the 'dienstverslagen'.</returns>
    ''' <remarks></remarks>
    Public Function DienstverslagGetLijst(ByVal jaar As Integer, ByVal maand As Integer) As BBWService.Mgt.TDSDienstverslagLijst
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetLijst(jaar, maand))
    End Function

    ''' <summary>
    ''' Get the list of the fire brigade teams.
    ''' </summary>
    ''' <returns>The ist of the fire brigade teams.</returns>
    ''' <remarks></remarks>
    Public Function DienstverslagGetTeams() As BBWService.Mgt.TDSDienstVerslagDetailTeams
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetTeams())
    End Function

    ''' <summary>
    ''' Get the list of the members of a fire brigade teams.
    ''' </summary>
    ''' <param name="ploegId">The ID of the team. (Use -1 to get the members of all teams.)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetTeamMembers(ByVal ploegId As Integer) As BBWService.Mgt.TDSDienstVerslagDetailTeamMembers
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetTeamMembers(ploegId))
    End Function

    ''' <summary>
    '''  Get the list of possible superiors for the fire brigade teams.
    ''' </summary>
    ''' <returns>The list of possible superiors.</returns>
    ''' <remarks></remarks>
    Public Function DienstverslagGetSuperiors() As BBWService.Mgt.TDSDienstVerslagDetailOversten
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetSuperiors())
    End Function

    ''' <summary>
    '''  Get the list of possible departments for the fire brigade teams.
    ''' </summary>
    ''' <returns>The list of possible superiors.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetDepartments() As BBWService.Mgt.TDSDienstverslagAfdelingen
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetDepartments())
    End Function

    ''' <summary>
    '''  Get the list of possible superior for the fire brigade teams.
    ''' </summary>
    ''' <returns>The list of possible superiors.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetActions() As BBWService.Mgt.TDSDienstverslagDetailActies
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetActions())
    End Function

    ''' <summary>
    ''' Get the details for a 'dienstverslag'.
    ''' </summary>
    ''' <param name="datum">The date of the report.</param>
    ''' <param name="ploegId">The ID of the team for the report.</param>
    ''' <returns>The 'dienstverslag'.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetDetail(ByVal datum As DateTime, ByVal ploegId As Integer) As BBWService.Mgt.TDSDienstVerslagDetail
        Return DoRetries(Function() myProxy.WebService.DienstVerslagGetDetail(datum, ploegId))
    End Function

    ''' <summary>
    ''' Save the details of a 'dienstverslag'.
    ''' </summary>
    ''' <param name="detail">A typed dataset with all details on the 'dienstverslag'.</param>
    ''' <returns>True if the data was successfully saved.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagSave(ByVal detail As BBWService.Mgt.TDSDienstVerslagDetail) As Boolean
        Return DoRetries(Function() myProxy.WebService.DienstVerslagSave(detail))
    End Function

#End Region

#Region "Brieven Snelheidsovertredingen"

    ''' <summary>
    ''' Haal de basisinformatie om een brief voor een snelheidsovertreding op te maken.
    ''' </summary>
    ''' <param name="idRegistratie"></param>
    ''' <returns></returns>
    ''' <remarks>Geert Maertens - oct 2012</remarks>
    Public Function GetBriefSnelheidsovertredingInfo(ByVal idRegistratie As Integer) As BBWService.Mgt.TDSBriefSnelheidsovertredingInfo
        Return DoRetries(Function() myProxy.WebService.GetBriefSnelheidsovertredingInfo(idRegistratie))
    End Function

    ''' <summary>
    ''' Sla de basisgegevens van een brief op.
    ''' </summary>
    ''' <param name="idRegistratie"></param>
    ''' <param name="datumAfdruk"></param>
    ''' <param name="taal"></param>
    ''' <param name="recidive"></param>
    ''' <param name="idFirm"></param>
    ''' <remarks>Geert Maertens - oct 2012</remarks>
    Public Sub BewaarSnelheidsOvertredingBrief(ByVal idRegistratie As Integer,
                                               ByVal datumAfdruk As DateTime,
                                               ByVal taal As String,
                                               ByVal recidive As Integer,
                                               ByVal idFirm As Integer)
        DoRetries(Sub() myProxy.WebService.BewaarSnelheidsOvertredingBrief(idRegistratie, datumAfdruk, taal, recidive, idFirm))
    End Sub

    ''' <summary>
    ''' Tabel SnelheidSanction
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Function GetSnelheidSanction() As BBWService.Mgt.TDSBewakingSnelheidSanction
        Return myProxy.WebService.GetSnelheidSanction()
    End Function

    ''' <summary>
    ''' Tabel SnelheidSanctionMatrix
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
    Public Function GetSnelheidSanctionMatrix() As BBWService.Mgt.TDSBewakingSnelheidSanctionMatrix
        Return myProxy.WebService.GetSnelheidSanctionMatrix()
    End Function

    ''' <summary>
    ''' Tabel Lijstinkoop (bestemmeling David Martens - ibo-aanvraag)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 26/11/2012</remarks>
    Public Function GetLijstInkoop() As BBWService.Mgt.TDSInkoop
        Return myProxy.WebService.GetLijstInkoop()
    End Function

    ''' <summary>
    ''' Lijst bewakingsverslagen waarvoor vinkje Naar CHIP is aangevinkt (TmsInc = yyyy-MM-dd)
    ''' ibo-aanvraag David Martens (aTmsInc = yyyy-MM-dd)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 06/07/2015</remarks>
    Public Function GetLijstInkoopFirmaVinkjeCHIP(ByVal aTmsInc As String) As BBWService.Mgt.TDSInkoopFirmaCHIP
        Return myProxy.WebService.GetLijstInkoopFirmaVinkjeCHIP(aTmsInc)
    End Function

    ''' <summary>
    ''' Lijst Brandweerinterventies inkoop (bestemmeling David Martens - ibo-aanvraag)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Nancy Coppens - 26/11/2012</remarks>
    Public Function GetLijstInkoopBrandweerInterventies() As BBWService.Mgt.TDSBrandweerInkoop
        Return myProxy.WebService.GetLijstInkoopBrandweer()
    End Function

    Public Sub UpdateIKPOpmerking(ByVal aOPM_IKP As String, ByVal aID_REG As Integer)
        Try
            Try
                myProxy.WebService.UpdateIKPOpmerking(aOPM_IKP, aID_REG)

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
                myProxy.WebService.UpdateIKPSendMail(aTMS_IKP_SENDMAIL, aID_REG)

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
    ''' <remarks>Nancy Coppens - 14/12/2012</remarks>
    Public Sub UpdateIKPSendMailNull(ByVal aID_REG As Integer)
        Try
            Try
                myProxy.WebService.UpdateIKPSendMailNull(aID_REG)

            Catch ex As Exception
                Throw
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub UpdateOvertredingPrint(ByVal aID_REG As Integer, ByVal aPrintDate As DateTime,
                                      ByVal aDoubleUp As Boolean, ByVal aKindOfSanction As String,
                                      ByVal aDuration As Integer, ByVal aSanctionPeriod As String,
                                      ByVal aSanctionId As Integer,
                                      ByVal aFirmId As Integer, ByVal aLanguage As String,
                                      ByVal aDatumBrief As DateTime,
                                      ByVal aRevokedDrivingFrom As DateTime,
                                      ByVal aRevokedDrivingTo As DateTime,
                                      ByVal aMeetingPBH As DateTime, ByVal aPersonalId As Integer)
        Try
            myProxy.WebService.UpdateOvertredingPrint(aID_REG, aPrintDate, aDoubleUp, aKindOfSanction, aDuration, aSanctionPeriod,
                                                      aSanctionId, aDatumBrief, aRevokedDrivingFrom, aRevokedDrivingTo, aMeetingPBH,
                                                      aFirmId, aLanguage, aPersonalId)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function add a remark to a specified infraction
    ''' </summary>
    ''' <param name="aID_Reg">The id of the registration</param>
    ''' <remarks>June 2013 Stijn V.</remarks>
    Public Sub InsertRemark(ByVal aID_REG As Integer, ByVal aRemark As String)
        Try
            myProxy.WebService.InsertRemark(aID_REG, aRemark)
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
            myProxy.WebService.InvalidateReport(idReg, remark, user)
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
            myProxy.WebService.ClearSanction(aID_Reg)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' This function checks whether a report has been invalidated
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    Public Function IsReportInvalid(ByVal idReg As Integer) As Boolean
        Try
            Return myProxy.WebService.IsReportInvalid(idReg)
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Generic Retry Functions"

    ''' <summary>
    ''' Generic function to call a web service using the retrying schema of this application.
    ''' </summary>
    ''' <typeparam name="T">Generic parameter for the data type of the web method result (can be deduced automatically).</typeparam>
    ''' <param name="code">The call to the web service as a lambda expression (or something that can be upcasted).</param>
    ''' <returns>The result of the web service.</returns>
    ''' <remarks></remarks>
    Private Function DoRetries(Of T)(ByVal code As Func(Of T)) As T
        Do
            Try
                Return code()

            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try

        Loop Until myProxy.Finished
        Return Nothing
    End Function

    ''' <summary>
    ''' Subroutien to call a web service using the retrying schema of this application.
    ''' </summary>
    ''' <param name="code">The call to the web service as a lambda expression (or something that can be upcasted).</param>
    ''' <remarks></remarks>
    Private Sub DoRetries(ByVal code As Action)
        Do
            Try
                code()

            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try

        Loop Until myProxy.Finished
    End Sub

#End Region

#Region "CHIP - automatically - sept 2016"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="aID_FRM"></param>
    ''' <returns></returns>
    ''' <remarks>naco - 12/09/2016</remarks>
    Public Function GetCHIP_SAPFirmNr(ByVal aID_FRM As Integer) As Integer
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetCHIP_SAPFirmNr(aID_FRM)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Function

    ''' <summary>
    ''' Get ID_FRM (table BBFRM) for SAP firmnr
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - april 2017</remarks>
    Public Function GetFirm_ID_FRMforSAPnr(ByVal aNR_IND_FRM_SAP As Integer) As Integer
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetFirm_ID_FRMforSAPnr(aNR_IND_FRM_SAP)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Function

    ''' <summary>
    ''' Get NM_FRM (table BBFRM) for SAP firmnr
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - april 2017</remarks>
    Public Function GetFirm_NM_FRMforSAPnr(ByVal aNR_IND_FRM_SAP As Integer) As String
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetFirm_NM_FRMforSAPnr(aNR_IND_FRM_SAP)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Function


#End Region

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>naco - 09/02/2017</remarks>
    Public Function GetUserBrandweer(ByVal aUser As String) As String
        Dim firstTry As Boolean = True
        Do While ((myProxy.Finished = False) OrElse firstTry)
            Try
                firstTry = False
                Return myProxy.WebService.GetUserBrandweer(aUser)
            Catch ex As Exception
                myProxy.HandleException(ex)
            End Try
        Loop
    End Function

End Class
