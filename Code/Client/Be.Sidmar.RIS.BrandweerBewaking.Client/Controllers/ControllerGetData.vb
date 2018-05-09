Public Class ControllerGetData
    Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

#Region "GetCodeTables"

    Public Function GetInterventieType() As Proxy.BBWService.Mgt.TDSIntvType
        'Doel: alle interventietypes (codetabel) ophalen
        'Auteur: Koen/Rajiv - 30/03/2006

        Dim result As New Proxy.BBWService.Mgt.TDSIntvType
        result.Merge(_proxy.GetInterventieType)
        Return result
    End Function

    Public Function GetEenheden() As Proxy.BBWService.Mgt.TDSEenheden
        'Doel: alle eenheden (codetabel) ophalen
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSEenheden
        result.Merge(_proxy.GetEenheden)
        Return result
    End Function

    Public Function GetVoertuigTypes() As Proxy.BBWService.Mgt.TDSVoertuigTypes
        'Doel: alle types voertuigen (codetabel) ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVoertuigTypes
        result.Merge(_proxy.GetVoertuigTypes)
        Return result
    End Function

    Public Function GetAanspreektitel() As Proxy.BBWService.Mgt.TDSAanspreektitel
        'Doel: alle aanspreektitels (codetabel) ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSAanspreektitel
        result.Merge(_proxy.GetAanspreektitel)
        Return result
    End Function

    Public Function GetPloeg() As Proxy.BBWService.Mgt.TDSPloeg
        'Doel: alle ploegen (codetabel) ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSPloeg
        result.Merge(_proxy.GetPloeg)
        Return result
    End Function

    Public Function GetGebruikVoertuig() As Proxy.BBWService.Mgt.TDSGebruikVoertuig
        'Doel: alle gebruik van voertuigen (codetabel) ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSGebruikVoertuig
        result.Merge(_proxy.GetGebruikVoertuig)
        Return result
    End Function

    Public Function GetArtikelGroepen() As Proxy.BBWService.Mgt.TDSArtikelgroep
        'Doel: alle artikelgroepen (codetabel) ophalen
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSArtikelgroep
        result.Merge(_proxy.GetArtikelgroepen)
        Return result
    End Function

    Public Function GetRegistratieType() As Proxy.BBWService.Mgt.TDSRegType
        'Doel: alle registratietypes (codetabel) ophalen van de bewaking
        'Auteur: Koen/Rajiv - 31/03/2006

        Dim result As New Proxy.BBWService.Mgt.TDSRegType
        result.Merge(_proxy.GetRegistratieType)
        Return result
    End Function

    Public Function GetIndividuTypes() As Proxy.BBWService.Mgt.TDSIndividuType
        'Doel: alle eenheden (codetabel) ophalen
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSIndividuType
        result.Merge(_proxy.GetIndividutypes)
        Return result
    End Function

    Public Function GetTypeBetrokkenen() As Proxy.BBWService.Mgt.TDSTypeBetrokkene
        'Doel: alle types betrokkenen (codetabel) ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSTypeBetrokkene
        result.Merge(_proxy.GetTypeBetrokkenen)
        Return result
    End Function

    Public Function GetAfdelingen() As Proxy.BBWService.Mgt.TDSAfdelingen
        'Doel: alle afdelingen ophalen
        'Auteur: Koen/Rajiv - 31/03/2006

        Dim result As New Proxy.BBWService.Mgt.TDSAfdelingen
        result.Merge(_proxy.GetAfdelingen)
        Return result
    End Function

    Public Function GetInbreukArtikel(ByVal type As Integer) As Proxy.BBWService.Mgt.TDSInbrArt
        'Doel: alle inbreukartikelen ophalen
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSInbrArt
        result.Merge(_proxy.GetInbreukArtikel(type))
        Return result
    End Function

    Public Function GetOorzaken(ByVal IntvType As Integer) As Proxy.BBWService.Mgt.TDSOorzaken
        'Doel: alle oorzaken ophalen
        'Auteur: Koen/Rajiv - 03/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSOorzaken
        result.Merge(_proxy.GetOorzaken(IntvType))
        Return result
    End Function

    Public Function GetAarden(ByVal IntvType As Integer) As Proxy.BBWService.Mgt.TDSAarden
        'Doel: alle aarden ophalen
        'Auteur: Koen/Rajiv - 04/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSAarden
        result.Merge(_proxy.GetAarden(IntvType))
        Return result
    End Function

    Public Function GetInbrType() As Proxy.BBWService.Mgt.TDSInbrType
        'Doel: alle inbreuktypes ophalen
        'Auteur: Koen/Rajiv - 04/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSInbrType
        result.Merge(_proxy.GetInbrType())
        Return result
    End Function

    Public Function GetLijstInbreuken() As Proxy.BBWService.Mgt.TDSLijstInbreukRegl
        'Doel: lijst van alle inbreuken ophalen
        'Auteur: Nancy Coppens - 19/02/2006

        Dim result As New Proxy.BBWService.Mgt.TDSLijstInbreukRegl
        result.Merge(_proxy.GetLijstInbreukReglementen)
        Return result
    End Function

    Public Function GetOvertrederType() As Proxy.BBWService.Mgt.TDSInbrIndTy
        'Doel: alle overtredertypes (voor inbreuk reglementen) ophalen
        'Auteur: Nancy Coppens - 19/12/2006

        Dim result As New Proxy.BBWService.Mgt.TDSInbrIndTy
        result.Merge(_proxy.GetOvertrederType())
        Return result
    End Function

    Public Function GetScadObjecten() As Proxy.BBWService.Mgt.TDSScadObjecten
        'Doel: alle inbreuktypes ophalen
        'Auteur: Koen/Rajiv - 04/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSScadObjecten
        result.Merge(_proxy.GetScadObjecten())
        Return result
    End Function

    Public Function GetDiefDup() As Proxy.BBWService.Mgt.TDSDiefDup
        'Doel: alle mogelijke gedupeerde van een diefstal ophalen
        'Auteur: Koen/Rajiv - 10/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSDiefDup
        result.Merge(_proxy.GetDiefDup())
        Return result
    End Function

    Public Function GetWerfVoertuig() As Proxy.BBWService.Mgt.TDSWerfVoertuig
        'Doel: alle mogelijke werfvoertuigen ophalen
        'Auteur: Koen/Rajiv - 19/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSWerfVoertuig
        result.Merge(_proxy.GetWerfVoertuig())
        Return result
    End Function

    Public Function GetToestandType() As Proxy.BBWService.Mgt.TDSToestandType
        'Doel: alle mogelijke toestandtypes ophalen
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSToestandType
        result.Merge(_proxy.GetToestandType())
        Return result
    End Function

    Public Function GetToestanden() As Proxy.BBWService.Mgt.TDSToestanden
        'Doel: alle mogelijke toestanden ophalen
        'Auteur: Koen/Rajiv - 20/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSToestanden
        result.Merge(_proxy.GetToestanden())
        Return result
    End Function

    Public Function GetBewakingDup() As Proxy.BBWService.Mgt.TDSBewakingDup
        'Doel: alle mogelijke benadeelden ophalen
        'Auteur: Koen/Rajiv - 02/05/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBewakingDup
        result.Merge(_proxy.GetBewakingDup())
        Return result
    End Function

    Public Function GetVaststellerAanrijding() As Proxy.BBWService.Mgt.TDSVaststellerAanrijding
        'Doel: alle mogelijke vaststellers van een aanrijding ophalen
        'Auteur: Koen/Rajiv - 12/05/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVaststellerAanrijding
        result.Merge(_proxy.GetVaststellerAanrijding())
        Return result
    End Function

    Public Function GetDagverslagRegistratieType() As Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
        'Doel: ophalen registratietypes
        'Auteur: dien - okt. 2006
        Dim result As New Proxy.BBWService.Mgt.TDSDagverslagRegistratieType
        result.Merge(_proxy.DagverslagRegistratieTypes())

        Return result
    End Function

    Public Function GetDagverslagInlichtingType() As Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
        'Doel: ophalen dagverslag inlichtingtype
        'Auteur: Dien - okt. 2006
        Dim result As New Proxy.BBWService.Mgt.TDSDagverslagInlichtingType
        result.Merge(_proxy.GetDagverslagInlichtingTypes())
        Return result
    End Function

    Public Function getPersoneel() As Proxy.BBWService.Mgt.TDSBBBWPERS
        'Doel: ophalen personeelsgegevens
        'Auteur: Dien - okt. 2006
        Dim result As New Proxy.BBWService.Mgt.TDSBBBWPERS
        result.Merge(_proxy.GetBBBWPersoneel)
        Return result
    End Function

    Public Function getAFDAMC() As Proxy.BBWService.Mgt.TDSBBAFDAMC
        'Doel ophalen afdelingsmilieucoordinatoren
        'Auteur: dien - mei 2009
        Dim result As New Proxy.BBWService.Mgt.TDSBBAFDAMC
        result.Merge(_proxy.getafdamc())
        Return result
    End Function

#End Region

#Region "GetBBWData"

    Public Function GetAanrijding(ByVal id_Reg As Integer) As Proxy.BBWService.Mgt.TDSAanrijding
        'Doel: aanrijding opvragen
        'Auteur: DIEN - okt. 2006
        Dim result As New Proxy.BBWService.Mgt.TDSAanrijding
        result.Merge(_proxy.GetAanrijding(id_Reg))

        Return result
    End Function

    Public Function GetDiefstallenPerTrimester() As Proxy.BBWService.Mgt.TDSTrimesterDiefstal
        'Doel: Diefstallen opvragen
        'Auteur: DUMI - juni. 2007

        Dim result As New Proxy.BBWService.Mgt.TDSTrimesterDiefstal
        result.Merge(_proxy.GetDiefstallenPerTrimester)
        Return result
    End Function

    Public Function GetBetrokkenAanrijding(ByVal id_reg As Integer) As Proxy.BBWService.Mgt.TDSBBBTROGV
        'Doel: alle betrokkenen van een aanrijding opvragen
        'Auteur: Siddien -) okt2006

        Dim result As New Proxy.BBWService.Mgt.TDSBBBTROGV
        result.Merge(_proxy.GetAanrijdingBetrokkenen(id_reg))
        Return result
    End Function

    Public Function GetIndividuen() As Proxy.BBWService.Mgt.TDSIndividuen
        'Doel: alle individuen ophalen
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSIndividuen
        result.Merge(_proxy.GetIndividuen)
        Return result
    End Function

    Public Function GetIndividu(ByVal id_ind As Integer) As Proxy.BBWService.Mgt.TDSIndividuen
        'Doel: één individu ophalen
        'Auteur: Siddien - sept 2006
        Dim result As New Proxy.BBWService.Mgt.TDSIndividuen
        result.Merge(_proxy.GetIndividu(id_ind))
        Return result
    End Function

    Public Function GetInterventies() As Proxy.BBWService.Mgt.TDSIntvBr
        'Doel: alle interventies ophalen
        'Auteur: Koen/Rajiv - 31/03/2006

        Dim result As New Proxy.BBWService.Mgt.TDSIntvBr
        result.Merge(_proxy.GetInterventies)
        Return result
    End Function

    Public Function GetMilieuverontreinigingen() As Proxy.BBWService.Mgt.TDSIntvBr
        'Doel: alle milieuverontreinigingen ophalen
        'Auteur: DUMI - 23/05/2007

        Dim result As New Proxy.BBWService.Mgt.TDSIntvBr
        result.Merge(_proxy.GetMilieuverontreinigingen)
        Return result
    End Function

    Public Function GetMilieuverontreinigingenBewaking() As Proxy.BBWService.Mgt.TDSRegBew
        'Doel: milieuVerontreiningen ophalen bewaking
        'Auteur: dien 2009

        Dim result As New Proxy.BBWService.Mgt.TDSRegBew
        result.Merge(_proxy.GetMilieuVerontreinigingenBewaking)
        Return result
    End Function

    Public Function GetBWPersoneel() As Proxy.BBWService.Mgt.TDSBBWAKPers
        'Doel: alle Bewakingspersoneelsleden ophalen
        'Auteur: Koen/Rajiv - 13/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBBWAKPers
        result.Merge(_proxy.GetBWPersoneel())
        Return result
    End Function

    Public Function GetBWPersoneelActief() As Proxy.BBWService.Mgt.TDSBBWAKPers
        'Doel: alle Bewakingspersoneelsleden ophalen
        'Auteur: naco - 08/02/2017

        Dim result As New Proxy.BBWService.Mgt.TDSBBWAKPers
        result.Merge(_proxy.GetBWPersoneelActief())
        Return result
    End Function

    Public Function GetBRPersoneel() As Proxy.BBWService.Mgt.TDSBBBRPers
        'Doel: alle Brandweerpersoneelsleden ophalen
        'Auteur: Koen/Rajiv - 13/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBBBRPers
        result.Merge(_proxy.GetBRPersoneel())
        Return result
    End Function

    Public Function GetBRPersoneelActief() As Proxy.BBWService.Mgt.TDSBBBRPers
        'Doel: alle Brandweerpersoneelsleden ophalen
        'Auteur: naco - 08/02/2017

        Dim result As New Proxy.BBWService.Mgt.TDSBBBRPers
        result.Merge(_proxy.GetBRPersoneelActief())
        Return result
    End Function

    Public Function GetInterventie(ByVal IdIntvBrdw As Integer) As Proxy.BBWService.Mgt.TDSInterventie
        'Doel: één bepaalde interventie ophalen
        'Auteur: Koen/Rajiv - 04/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSInterventie
        result.Merge(_proxy.GetInterventie(IdIntvBrdw))
        Return result
    End Function

    Public Function GetRegistraties() As Proxy.BBWService.Mgt.TDSRegBew
        'Doel: alle registraties ophalen
        'Auteur: Koen/Rajiv - 05/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSRegBew
        result.Merge(_proxy.GetRegistraties)
        Return result
    End Function

    Public Function GetRegSchadegeval(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSSchadegeval
        'Doel: 1 schadegeval ophalen
        'Auteur: Koen/Rajiv - 10/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSSchadegeval
        result.Merge(_proxy.GetRegSchadegeval(IdRegBew))
        Return result
    End Function

    Public Function GetRegAlcoholtest(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSAlcoholtest
        'Doel: 1 alcoholtest ophalen
        'Auteur: Koen/Rajiv - 11/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSAlcoholtest
        result.Merge(_proxy.GetRegAlcoholtest(IdRegBew))
        'result.Merge(_proxy.GetRegAlcoholtest(IdRegBew))
        Return result
    End Function

    Public Function GetRegDiefstal(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSDiefstal
        'Doel: 1 diefstal ophalen
        'Auteur: Koen/Rajiv - 12/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSDiefstal
        result.Merge(_proxy.GetRegDiefstal(IdRegBew))
        Return result
    End Function

    Public Function GetRegOpenKleerkast(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSOpenKleerkast
        'Doel: 1 openmaken kleerkast ophalen
        'Auteur: Koen/Rajiv - 13/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSOpenKleerkast
        result.Merge(_proxy.GetRegOpenKleerkast(IdRegBew))
        Return result
    End Function

    Public Function GetRegDivRegistratie(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSDivRegistratie
        'Doel: 1 diverse registratie ophalen
        'Auteur: Koen/Rajiv - 14/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSDivRegistratie
        result.Merge(_proxy.GetRegDivRegistratie(IdRegBew))
        Return result
    End Function

    Public Function GetRegInbreukRegl(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSInbreukRegl
        'Doel: 1 inbreuk op reglementen ophalen
        'Auteur: Koen/Rajiv - 18/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSInbreukRegl
        result.Merge(_proxy.GetRegInbreukRegl(IdRegBew))
        Return result
    End Function

    Public Function GetRegControleVoertuig(ByVal IdRegBew As Integer) As Proxy.BBWService.Mgt.TDSControleVoertuig
        'Doel: 1 controle op een voertuig ophalen
        'Auteur: Koen/Rajiv - 04/05/2006

        Dim result As New Proxy.BBWService.Mgt.TDSControleVoertuig
        result.Merge(_proxy.GetRegControleVoertuig(IdRegBew))
        Return result
    End Function

    Public Function GetVastgesteldeInbreuken(ByVal IdInd As Integer, ByVal IdRegistratie As Integer) As Proxy.BBWService.Mgt.TDSVastgesteldeInbreuken
        'Doel: vastgestelde inbreuken van een individu ophalen
        'Auteur: Koen/Rajiv - 05/05/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVastgesteldeInbreuken
        result.Merge(_proxy.GetVastgesteldeInbreuken(IdInd, IdRegistratie))
        Return result
    End Function

    Public Function GetVerzFirmas() As Proxy.BBWService.Mgt.TDSVerzFirmas
        'Doel: alle verzekeringsfirma's ophalen
        'Auteur: Koen/Rajiv - 05/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVerzFirmas
        result.Merge(_proxy.GetVerzFirmas)
        Return result
    End Function

    Public Function GetFirmas() As Proxy.BBWService.Mgt.TDSFirmas
        'Doel: alle firma's ophalen
        'Auteur: Koen/Rajiv - 05/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSFirmas
        result.Merge(_proxy.GetFirmas)
        Return result
    End Function

    Public Function GetVoertuigen() As Proxy.BBWService.Mgt.TDSVoertuigen
        'Doel: alle firma's ophalen
        'Auteur: Koen/Rajiv - 03/05/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVoertuigen
        result.Merge(_proxy.GetVoertuigen)
        Return result
    End Function

    Public Function GetInterventieArtikelen() As Proxy.BBWService.Mgt.TDSIntvArt
        'Doel: alle interventieartikelen ophalen
        'Auteur: Koen/Rajiv - 07/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSIntvArt
        result.Merge(_proxy.GetInterventieArtikelen)
        Return result
    End Function

    Public Function GetVerbruiksArtikelen() As Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        'Doel: alle verbruiksartikelen ophalen
        'Auteur: Koen/Rajiv - 21/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        result.Merge(_proxy.GetVerbruiksArtikelen)
        Return result
    End Function

    Public Function GetVerbruiksArtikelenMinStock() As Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        'Doel:   alle verbruiksartikelen ophalen waarvoor stock < min stock
        'Auteur: Nancy Coppens - 07/12/2006

        Dim result As New Proxy.BBWService.Mgt.TDSVerbruiksArtikel
        result.Merge(_proxy.GetVerbruiksArtikelenMinStock)
        Return result

    End Function

    Public Function GetBrandenPerAfdelingMaand(ByVal Maand As Integer, ByVal Jaar As Integer) As Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        'Doel: alle gegevens voor maandrapport Branden per afdeling ophalen
        'Auteur: - 25/07/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        result.Merge(_proxy.GetBrandenPerAfdelingMaand(Maand, Jaar))
        Return result
    End Function

    Public Function GetBrandenPerAfdelingJaar(ByVal Jaar As Integer) As Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        'Doel: alle gegevens voor jaarrapport Branden per afdeling ophalen
        'Auteur: - 27/07/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        result.Merge(_proxy.GetBrandenPerAfdelingJaar(Jaar))
        Return result
    End Function

    Public Function GetBrandenPerAfdelingAardJaar(ByVal Jaar As Integer) As Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        'Doel: alle gegevens voor jaarrapport Branden per afdeling en aard ophalen
        'Auteur: - 27/07/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        result.Merge(_proxy.GetBrandenPerAfdelingAardJaar(Jaar))
        Return result
    End Function

    Public Function GetBrandenPerAfdelingOorzaakJaar(ByVal Jaar As Integer) As Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        'Doel: alle gegevens voor jaarrapport Branden per afdeling en oorzaak ophalen
        'Auteur: - 27/07/2006

        Dim result As New Proxy.BBWService.Mgt.TDSBrandenPerAfdeling
        result.Merge(_proxy.GetBrandenPerAfdelingOorzaakJaar(Jaar))
        Return result
    End Function

    Public Sub GetMaxValuesInterventie(ByVal InterventieTypeID As Integer, _
                                        ByVal AfdelingID As Integer, _
                                        ByVal jaartal As Integer, _
                                        ByRef maxInterventieID As Integer, _
                                        ByRef maxAfdelingVolgnummer As Integer, _
                                        ByRef maxJaarVolgnummer As Integer)
        'Doel: de maximum interventiewaarden ophalen
        'Auteur: Koen/Rajiv - 10/04/2006
        _proxy.GetMaxValuesInterventie(InterventieTypeID, AfdelingID, jaartal, _
                             maxInterventieID, maxAfdelingVolgnummer, maxJaarVolgnummer)
    End Sub

    Public Sub GetMaxValuesRegistratie(ByVal tmsRegistratie As Date, _
                                       ByRef id_reg As Integer, _
                                       ByRef volgnr_reg_jaar As Integer)
        'Doel: de maximum ophalen van een registratie
        'Auteur: Koen/Rajiv - 27/04/2006
        _proxy.GetMaxValuesRegistratie(tmsRegistratie, id_reg, volgnr_reg_jaar)
    End Sub

    Public Function GetLijstSnelheidsovertredingen(ByVal Intern As Boolean) As Proxy.BBWService.Mgt.TDSSnelheidsOvertredingen
        'Doel: alle snelheidsovertredingen ophalen
        'Auteur: Lawrence Verbruggen - 13/04/2011

        Dim result As New Proxy.BBWService.Mgt.TDSSnelheidsOvertredingen
        result.Merge(_proxy.GetLijstSnelheidsovertredingen(Intern))
        Return result
    End Function

    ''' <summary>
    ''' This function checks whether a report has been invalidated
    ''' </summary>
    ''' <param name="idReg">The id of the registration</param>
    Public Function IsReportInvalid(ByVal idReg As Integer) As Boolean
        Return _proxy.IsReportInvalid(idReg)
    End Function

#End Region

#Region "Configuration Settings"

    Public Function GetConfigurationSettings() As Proxy.BBWService.Mgt.TDSConfiguratie
        'Doel: alle configuratie settings ophalen
        'Auteur: Koen/Rajiv - 24/04/2006

        Dim result As New Proxy.BBWService.Mgt.TDSConfiguratie
        result.Merge(_proxy.GetConfigurationSettings)
        Return result
    End Function

#End Region

End Class
