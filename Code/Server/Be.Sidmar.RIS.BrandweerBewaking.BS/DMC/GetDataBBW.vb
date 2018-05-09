Option Explicit On
Option Infer On
Option Strict On

Imports ADF.ExceptionHandling
Imports System.Reflection
Imports ADF.Data.SqlClient
Imports System.Data.SqlClient
Imports System.Collections.Generic


Namespace DMC

    Public NotInheritable Class GetDataBbw

#Region "GetCodeTables"
        Public Function GetInterventieType() As TDSIntvType
            'Doel:   Tabel BBINTVTY ophalen
            'Auteur: Rajiv/Koen - 25/03/2006
            'Returns: dataset met interventietypes

            Dim dsResult As New TDSIntvType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINTVTY")

                SqlHelper.AddTableMapping(0, "BBINTVTY", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetEenheden() As TDSEenheden
            'Doel:   Tabel BBEH ophalen
            'Auteur: Rajiv/Koen - 18/04/2006
            'Returns: dataset met eenheden

            Dim dsResult As New TDSEenheden
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBEH")

                SqlHelper.AddTableMapping(0, "BBEH", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetArtikelGroepen() As TDSArtikelgroep
            'Doel:   Tabel BBARTGR ophalen
            'Auteur: Rajiv/Koen - 18/04/2006
            'Returns: dataset met artikelgroepen

            Dim dsResult As New TDSArtikelgroep
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBARTGR")

                SqlHelper.AddTableMapping(0, "BBARTGR", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetIndividuTypes() As TDSIndividuType
            'Doel:   Tabel BBINDTY ophalen
            'Auteur: Rajiv/Koen - 18/04/2006
            'Returns: dataset met individutypes

            Dim dsResult As New TDSIndividuType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINDTY")

                SqlHelper.AddTableMapping(0, "BBINDTY", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetTypeBetrokkenen() As TDSTypeBetrokkene
            'Doel:   Tabel BBTYBTRK ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met types betrokkenen

            Dim dsResult As New TDSTypeBetrokkene
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBTYBTRK")

                SqlHelper.AddTableMapping(0, "BBTYBTRK", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetRegistratieType() As TDSRegType
            'Doel:   Tabel BBREGTY ophalen
            'Auteur: Rajiv/Koen - 25/03/2006
            'Returns: dataset met registratietypes

            Dim dsResult As New TDSRegType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBREGTY")

                SqlHelper.AddTableMapping(0, "BBREGTY", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetAfdelingen() As TDSAfdelingen
            'Doel:   Tabel BBAFD ophalen
            'Auteur: Rajiv/Koen - 31/03/2006
            'Returns: dataset met afdelingen
            Dim dsResult As New TDSAfdelingen
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBAFD")

                SqlHelper.AddTableMapping(0, "BBAFD", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetOorzaken(ByVal intvType As Integer) As TDSOorzaken
            'Doel:   Tabel BBBRRD ophalen
            'Auteur: Rajiv/Koen - 31/03/2006
            '-1: ophalen van alle oorzaken
            'Returns: dataset met oorzaken van interventies
            Dim dsResult As New TDSOorzaken
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRRD")

                SqlHelper.AddTableMapping(0, "BBBRRD", da)
                If intvType <> -1 Then
                    SqlHelper.AddParameter("@IntvType", SqlDbType.Int, 2, intvType, da)
                Else
                    SqlHelper.AddParameter("@IntvType", SqlDbType.Int, 2, DBNull.Value, da)
                End If

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetAarden(ByVal intvType As Integer) As TDSAarden
            'Doel:   Tabel BBBRTY ophalen
            'Auteur: Rajiv/Koen - 31/03/2006
            '-1: ophalen van alle aarden
            'Returns: dataset met aarden
            Dim dsResult As New TDSAarden
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRTY")

                SqlHelper.AddTableMapping(0, "BBBRTY", da)
                If intvType <> -1 Then
                    SqlHelper.AddParameter("@IntvType", SqlDbType.Int, 2, intvType, da)
                Else
                    SqlHelper.AddParameter("@IntvType", SqlDbType.Int, 2, DBNull.Value, da)
                End If

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetInbreukArt(ByVal inbrType As Integer) As TDSInbrArt
            'Doel:   Tabel BBINBRAR ophalen
            'Auteur: Rajiv/Koen - 04/04/2006
            'Returns: dataset met afdelingen
            Dim dsResult As New TDSInbrArt
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_BBINBRAR")

                SqlHelper.AddTableMapping(0, "BBINBRAR", da)
                SqlHelper.AddParameter("@InbrType", SqlDbType.Int, 2, inbrType, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetInbreukType() As TDSInbrType
            'Doel:   Tabel BBINBRTY ophalen
            'Auteur: Rajiv/Koen - 04/04/2006
            'Returns: dataset met afdelingen
            Dim dsResult As New TDSInbrType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINBRTY")

                SqlHelper.AddTableMapping(0, "BBINBRTY", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetVoertuigTypes() As TDSVoertuigTypes
            'Doel:   Tabel BBTYTSP ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met voertuigtypes
            Dim dsResult As New TDSVoertuigTypes
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBTYTSP")

                SqlHelper.AddTableMapping(0, "BBTYTSP", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetAanspreektitel() As TDSAanspreektitel
            'Doel:   Tabel BBINDGSP ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met aanspreektitels
            Dim dsResult As New TDSAanspreektitel
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINDGSL")

                SqlHelper.AddTableMapping(0, "BBINDGSL", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetGebruikVoertuig() As TDSGebruikVoertuig
            'Doel:   Tabel BBBRKTSP ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met gebruik van voertuigen
            Dim dsResult As New TDSGebruikVoertuig
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRKTSP")

                SqlHelper.AddTableMapping(0, "BBBRKTSP", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetPloeg() As TDSPloeg
            'Doel:   Tabel BBBWPLG ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met ploegen
            Dim dsResult As New TDSPloeg
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBWPLG")

                SqlHelper.AddTableMapping(0, "BBBWPLG", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetDiefDup() As TDSDiefDup
            'Doel:   Tabel BBDIEFDU ophalen
            'Auteur: Rajiv/Koen - 12/04/2006
            'Returns: dataset met mogelijke gedupeerden ophalen
            Dim dsResult As New TDSDiefDup
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDIEFDU")

                SqlHelper.AddTableMapping(0, "BBDIEFDU", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetScadObjecten() As TDSScadObjecten
            'Doel:   Tabel BBSCADAN ophalen
            'Auteur: Rajiv/Koen - 10/04/2006
            'Returns: dataset met schadeobjecten
            Dim dsResult As New TDSScadObjecten
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBSCADAN")

                SqlHelper.AddTableMapping(0, "BBSCADAN", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetWerfVoertuig() As TDSWerfVoertuig
            'Doel:   Tabel BBWRFTSP ophalen
            'Auteur: Rajiv/Koen - 19/04/2006
            'Returns: dataset met werfvoertuigen
            Dim dsResult As New TDSWerfVoertuig
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBWRFTSP")

                SqlHelper.AddTableMapping(0, "BBWRFTSP", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetToestandType() As TDSToestandType
            'Doel:   Tabel BBTYSTA ophalen
            'Auteur: Rajiv/Koen - 20/04/2006
            'Returns: dataset met toestandtypes (bewaking)
            Dim dsResult As New TDSToestandType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBTYSTA")

                SqlHelper.AddTableMapping(0, "BBTYSTA", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetToestanden() As TDSToestanden
            'Doel:   Tabel BBSTA ophalen
            'Auteur: Rajiv/Koen - 20/04/2006
            'Returns: dataset met toestanden (bewaking)
            Dim dsResult As New TDSToestanden
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBSTA")

                SqlHelper.AddTableMapping(0, "BBSTA", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetBewakingDup() As TDSBewakingDup
            'Doel:   Tabel BBBEWDUP ophalen
            'Auteur: Rajiv/Koen - 02/05/2006
            'Returns: dataset met benadeelden (bewaking)
            Dim dsResult As New TDSBewakingDup
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBEWDUP")

                SqlHelper.AddTableMapping(0, "BBBEWDUP", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetVaststellerAanrijding() As TDSVaststellerAanrijding
            'Doel:   Tabel BBVASTOGV ophalen
            'Auteur: Rajiv/Koen - 12/05/2006
            'Returns: dataset met vaststellers aanrijding (bewaking)
            Dim dsResult As New TDSVaststellerAanrijding
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBVASTOGV")

                SqlHelper.AddTableMapping(0, "BBVASTOGV", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return Nothing
            End Try
        End Function

        Public Function GetMaxBBTSP() As Integer
            'Doel: max ID_TSP BBTSP ophalen
            'Auteur: Dien okt 2006
            Try
                Dim idTsp As Integer
                Dim aCommand As SqlCommand = SqlHelper.GetSqlCommand("USP_BBW_GET_LAST_BBTSP")
                idTsp = CInt(SqlHelper.ExecuteScalar(aCommand))

                Return idTsp
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.RethrowAsSoapException)
                Return 0
            End Try
        End Function

#End Region

#Region "GetBBWData"

        Public Function GetBestemmelingenAfdeling(ByVal idAfdeling As Integer) As TDSBeheerAFDAMC

            Dim dsResult As New TDSBeheerAFDAMC
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_BestemmelingenAfdeling")
                SqlHelper.AddTableMapping(0, "BBAFDAMC", da)
                SqlHelper.AddParameter("@id_afd", SqlDbType.Int, 4, idAfdeling, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBestemmelingenAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetLastStamnummer() As Integer
            'Doel: opvragen van het laatste stamnummer
            'Auteur: Siddien - oktober 2006
            Dim stamnummer As Integer
            'Dim da As SqlDataAdapter
            Try
                'da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_LAST_STAMNR", Data.DbHelper.ActionEnum.Fill)

                Dim aCommand As SqlCommand = SqlHelper.GetSqlCommand("USP_BBW_GET_LAST_STAMNR")
                stamnummer = CInt(SqlHelper.ExecuteScalar(aCommand))


                Return stamnummer
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLastStamnummer")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetIndividuen() As TDSIndividuen
            'Doel:   Tabel BBIND ophalen
            'Auteur: Rajiv/Koen - 21/04/2006
            'Returns: dataset met alle individuen

            Dim dsResult As New TDSIndividuen
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBIND")

                SqlHelper.AddTableMapping(0, "BBIND", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetIndividuen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetIndividu(ByVal idInd As Integer) As TDSIndividuen
            'Doel: returnen van één individu
            'Auteur: Siddien - 30 sept 2006
            Dim dsResult As New TDSIndividuen
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBIND")
                SqlHelper.AddTableMapping(0, "BBIND", da)
                SqlHelper.AddParameter("@id_ind", SqlDbType.Int, 4, idInd, da)

                SqlHelper.Fill(dsResult, da)
                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetIndividu")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetInterventies() As TDSIntvBr
            'Doel:   Tabel BBINTVBR ophalen
            'Auteur: Rajiv/Koen - 31/03/2006
            'Returns: dataset met interventies

            Dim dsResult As New TDSIntvBr
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINTVBR")

                SqlHelper.AddTableMapping(0, "BBINTVBR", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetInterventies")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetMilieuverontreinigingen() As TDSIntvBr
            'Doel:   Ophalen van alle milieuverontreinigingen
            'Auteur: Mieke Duynslager - 23/05/2007
            'Returns: dataset met milieuverontreinigingen

            Dim dsResult As New TDSIntvBr
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_milieuverontreinigingen")

                SqlHelper.AddTableMapping(0, "BBINTVBR", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetInterventies")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetMilieuverontreinigingenBewaking() As TDSRegBew
            'Doel: Ophalen van alle milieuverontreiningen bewaking
            'Auteur: dien mei 09
            Dim dsResult As New TDSRegBew
            Dim da As SqlDataAdapter
            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_milieuverontreinigingenBewaking")
                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.Fill(dsResult, da)
                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMilieuVerontreiningenBewaking")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBBBWPersoneel() As TDSBBBWPERS
            'Doel:  Tabel BBBWPersoneel
            'Auteur: Dien - okt. 2006
            'Ophalen van alle personeelsleden.

            Dim dsResult As New TDSBBBWPERS
            Dim da As SqlDataAdapter
            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBWPERS")

                SqlHelper.AddTableMapping(0, "BBBWPERS", da)
                SqlHelper.Fill(dsResult, da)
                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBBWPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function getAFDAMC() As TDSBBAFDAMC
            Dim dsResult As New TDSBBAFDAMC
            Dim da As SqlDataAdapter
            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBAFDAMC")

                SqlHelper.AddTableMapping(0, "BBAFDAMC", da)
                SqlHelper.Fill(dsResult, da)
                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - getAFDAMC")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try

        End Function

        Public Function GetBBBRPersoneel() As TDSBBBRPers
            'Doel:   Tabel BBBRPERS ophalen
            'Auteur: Rajiv/Koen - 13/04/2006
            'Returns: dataset met brandweerpersoneelsleden

            Dim dsResult As New TDSBBBRPers
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRPERS")

                SqlHelper.AddTableMapping(0, "BBBRPERS", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBBRPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBBBRPersoneelActief() As TDSBBBRPers
            'Doel:   Tabel BBBRPERS ophalen - actieve werknemers brandweer en bewaking ophalen
            'Auteur: naco - 08/02/2017
            'Returns: dataset met brandweerpersoneelsleden

            Dim dsResult As New TDSBBBRPers
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRPERS_ACTIEF")

                SqlHelper.AddTableMapping(0, "BBBRPERS", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBBRPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBBWAKPersoneel() As TDSBBWAKPers
            'Doel:   Tabel BBWAKPERS ophalen
            'Auteur: Rajiv/Koen - 13/04/2006
            'Returns: dataset met bewakingspersoneelsleden

            Dim dsResult As New TDSBBWAKPers
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBWAKPERS")

                SqlHelper.AddTableMapping(0, "BBWAKPERS", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBWAKPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBBWAKPersoneelActief() As TDSBBWAKPers
            'Doel:   Tabel BBWAKPERS ophalen  - actieve werknemers brandweer en bewaking ophalen
            'Auteur: naco - 08/02/2017
            'Returns: dataset met bewakingspersoneelsleden

            Dim dsResult As New TDSBBWAKPers
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBWAKPERS_ACTIEF")

                SqlHelper.AddTableMapping(0, "BBWAKPERS", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBWAKPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBBWInterventie(ByVal idIntvBrdw As Integer) As TDSInterventie
            'Doel:   Tabel BBINTVBR ophalen
            'Auteur: Rajiv/Koen - 04/04/2006
            'Returns: dataset met een interventie

            Dim dsResult As New TDSInterventie
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBINTVBR")

                SqlHelper.AddTableMapping(0, "BBINTVBR", da)
                SqlHelper.AddTableMapping(1, "BBMATPR", da)
                SqlHelper.AddTableMapping(2, "BBINTVDU", da)
                SqlHelper.AddTableMapping(3, "BBBYLG", da)
                SqlHelper.AddTableMapping(4, "BBBST", da)
                SqlHelper.AddParameter("@IdIntvBrdw ", SqlDbType.Int, 2, idIntvBrdw, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBBWInterventie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegistraties() As TDSRegBew
            'Doel:   Alle registraties ophalen (bewaking)
            'Auteur: Rajiv/Koen - 05/04/2006
            'Returns: dataset met registraties

            Dim dsResult As New TDSRegBew
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBEWREG")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegistraties")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegSchadegeval(ByVal idBewReg As Integer) As TDSSchadegeval
            'Doel:   Een schadegeval ophalen (bewaking)
            'Auteur: Rajiv/Koen - 10/04/2006
            'Returns: dataset met een schadegeval (bewaking)

            Dim dsResult As New TDSSchadegeval
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBSCAD")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBSCAD", da)
                SqlHelper.AddTableMapping(4, "BBTSP", da)
                SqlHelper.AddTableMapping(5, "BBFRM", da)
                SqlHelper.AddTableMapping(6, "BBVZKFRM", da)


                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegSchadegeval")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetAanrijding(ByVal idReg As Integer) As TDSAanrijding
            'Doel: opslaan aanrijding
            'Auteur: dien - okt. 2006
            Dim dsResult As New TDSAanrijding
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBOGVTSP")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBOGVTSP", da)
                SqlHelper.AddTableMapping(4, "BBOGVSTA", da)
                SqlHelper.AddTableMapping(5, "BBBTROGV", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAanrijding")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try

        End Function

        Public Function GetRegAlcoholtest(ByVal idBewReg As Integer) As TDSAlcoholtest
            'Doel:   Een alcoholtest ophalen (bewaking)
            'Auteur: Rajiv/Koen - 11/04/2006
            'Returns: dataset met een alcoholtest (bewaking)

            Dim dsResult As New TDSAlcoholtest
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBALCTST")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBALCTST", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegAlcoholtest")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegDiefstal(ByVal idBewReg As Integer) As TDSDiefstal
            'Doel:   Een diefstal ophalen (bewaking)
            'Auteur: Rajiv/Koen - 12/04/2006
            'Returns: dataset met een diefstal (bewaking)

            Dim dsResult As New TDSDiefstal
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBDIEFST")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBDIEFST", da)
                SqlHelper.AddTableMapping(4, "BBFRM", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegDiefstal")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegOpenKleerkast(ByVal idBewReg As Integer) As TDSOpenKleerkast
            'Doel:   Een openmaken kleerkast ophalen (bewaking)
            'Auteur: Rajiv/Koen - 13/04/2006
            'Returns: dataset met een openmaken kleerkast (bewaking)

            Dim dsResult As New TDSOpenKleerkast
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBOPKAST")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBOPKAST", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegOpenKleerkast")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegDivRegistratie(ByVal idBewReg As Integer) As TDSDivRegistratie
            'Doel:   Een diverse registratie ophalen (bewaking)
            'Auteur: Rajiv/Koen - 14/04/2006
            'Returns: dataset met een diverse registratie (bewaking)

            Dim dsResult As New TDSDivRegistratie
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBREGVSH")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBREGVSH", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegDivRegistratie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegInbreukRegl(ByVal idBewReg As Integer) As TDSInbreukRegl
            'Doel:   Een inbreuk op reglementenregistratie ophalen (bewaking)
            'Auteur: Rajiv/Koen - 18/04/2006
            'Returns: dataset met een inbreuk op reglementen (bewaking)

            Dim dsResult As New TDSInbreukRegl
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBINBRRG")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBINBRRG", da)
                SqlHelper.AddTableMapping(4, "BBINBRVA", da)
                SqlHelper.AddTableMapping(5, "BBTSP", da)
                SqlHelper.AddTableMapping(6, "BBFRM", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegInbreukRegl")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetOvertrederTypeInbreukRegl() As TDSInbrIndTy
            'Doel:   Type overtreder ophalen voor inbreuk reglementen (Arcelor Gent, Externe firma, Bezoeker, Vrachtvervoerder)
            'Auteur: Nancy Coppens - 19/12/2006

            Dim dsResult As New TDSInbrIndTy
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINBRINDTY")

                SqlHelper.AddTableMapping(0, "BBINBRINDTY", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetOvertrederTypeInbreukRegl")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegControleVoertuig(ByVal idBewReg As Integer) As TDSControleVoertuig
            'Doel:   Een controle voertuigenregistratie ophalen (bewaking)
            'Auteur: Rajiv/Koen - 04/05/2006
            'Returns: dataset met een controle op een voertuig (bewaking)

            Dim dsResult As New TDSControleVoertuig
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBBEWREG_BBKEUTSP")

                SqlHelper.AddTableMapping(0, "BBBEWREG", da)
                SqlHelper.AddTableMapping(1, "BBBYLG", da)
                SqlHelper.AddTableMapping(2, "BBBST", da)
                SqlHelper.AddTableMapping(3, "BBKEUTSP", da)
                SqlHelper.AddTableMapping(4, "BBTSP", da)
                SqlHelper.AddTableMapping(5, "BBFRM", da)

                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idBewReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegControleVoertuig")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVastgesteldeInbreuken(ByVal idInd As Integer, ByVal idRegistratie As Integer) As TDSVastgesteldeInbreuken
            'Doel:   Reeds vastgestelde inbreuken van een bepaalde individu ophalen (bewaking)
            'Auteur: Rajiv/Koen - 05/05/2006
            'Returns: dataset met vastgestelde inbreuken (bewaking)

            Dim dsResult As New TDSVastgesteldeInbreuken
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINBRVA_BBIND")

                SqlHelper.AddTableMapping(0, "BBINBRVA", da)

                SqlHelper.AddParameter("@IdInd", SqlDbType.Int, 2, idInd, da)
                SqlHelper.AddParameter("@IdBewReg", SqlDbType.Int, 2, idRegistratie, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVastgesteldeInbreuken")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVerzFirmas() As TDSVerzFirmas
            'Doel:   Alle verzekeringsfirma's ophalen (bewaking)
            'Auteur: Rajiv/Koen - 05/04/2006
            'Returns: dataset met verzekeringsfirma's

            Dim dsResult As New TDSVerzFirmas
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBVZKFRM")

                SqlHelper.AddTableMapping(0, "BBVZKFRM", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVerzFirmas")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetFirmas() As TDSFirmas
            'Doel:   Alle firma's ophalen (bewaking)
            'Auteur: Rajiv/Koen - 05/04/2006
            'Returns: dataset met firma's

            Dim dsResult As New TDSFirmas
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBFRM")

                SqlHelper.AddTableMapping(0, "BBFRM", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetFirmas")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetFirmaIdForRegistration(ByVal pRegistratieid As Integer,
                                                  ByVal pConnectionString As String) As TDSFirmas
            'Doel:   Alle firma's ophalen (bewaking)
            'Auteur: Rajiv/Koen - 05/04/2006
            'Returns: dataset met firma's

            Dim dsResult As New TDSFirmas

            Try
                Dim strSql As String
                strSql = " select BBFRM.* " &
                         " from BBFRM " &
                      " join BBINBRRG on BBFRM.ID_FRM = BBINBRRG.ID_FRM " &
                      " where BBINBRRG.ID_REG = @IdBewReg "

                Using sqlDa As SqlDataAdapter = New SqlDataAdapter()

                    Dim cmdSelectPbhAfspraak As New SqlCommand(strSql, New SqlConnection(pConnectionString))
                    cmdSelectPbhAfspraak.CommandType = CommandType.Text
                    cmdSelectPbhAfspraak.Parameters.Add("@IdBewReg", SqlDbType.Int).Value = pRegistratieid
                    sqlDa.SelectCommand = cmdSelectPbhAfspraak
                    sqlDa.Fill(dsResult, dsResult.BBFRM.TableName)

                End Using

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetFirmas")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVoertuig(ByVal idTsp As Integer) As TDSVoertuigen
            'Doel: ophalen van één voertuig
            'Auteur: Dieter - okt. 2006
            '
            Dim dsResult As New TDSVoertuigen
            Dim da As SqlDataAdapter
            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ONE_BBTSP")
                SqlHelper.AddTableMapping(0, "BBTSP", da)
                SqlHelper.AddParameter("@ID_TSP", SqlDbType.Int, 4, idTsp, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVoertuig")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVoertuigen() As TDSVoertuigen
            'Doel:   Alle voertuigen ophalen (bewaking)
            'Auteur: Rajiv/Koen - 03/05/2006
            'Returns: dataset met voertuigen

            Dim dsResult As New TDSVoertuigen
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBTSP")

                SqlHelper.AddTableMapping(0, "BBTSP", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVoertuigen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetInterventieArtikelen() As TDSIntvArt
            'Doel:   Tabel BBINTART ophalen
            'Auteur: Rajiv/Koen - 07/04/2006
            'Returns: dataset met interventieartikelen

            Dim dsResult As New TDSIntvArt
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBINTART")

                SqlHelper.AddTableMapping(0, "BBINTART", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetInterventieArtikelen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVerbruiksArtikelen() As TDSVerbruiksArtikel
            'Doel:   Tabel BBBRKART ophalen
            'Auteur: Rajiv/Koen - 21/04/2006
            'Returns: dataset met verbruiksartikelen

            Dim dsResult As New TDSVerbruiksArtikel
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRKART")

                SqlHelper.AddTableMapping(0, "BBBRKART", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVerbruiksArtikelen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetVerbruiksArtikelenMinStock() As TDSVerbruiksArtikel
            'Doel:   Tabel BBBRKART waarvoor huidige stock < minimum stock ophalen
            'Auteur: Nancy Coppens - 07/12/2006
            'Returns: dataset met verbruiksartikelen

            Dim dsResult As New TDSVerbruiksArtikel
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBRKART_MINSTOCK")

                SqlHelper.AddTableMapping(0, "BBBRKART", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVerbruiksArtikelen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Sub GetMaxValuesInterventie(ByVal interventieTypeId As Integer, _
                                                ByVal afdelingId As Integer, _
                                                ByVal jaartal As Integer, _
                                                ByRef maxInterventieId As Integer, _
                                                ByRef maxAfdelingVolgnummer As Integer, _
                                                ByRef maxJaarVolgnummer As Integer)
            'doel: insert van nieuwe brandweerinterventie
            'Opgelet: stored procedure met 3 output parameters

            Try
                Dim cmd As SqlCommand = SqlHelper.GetSqlCommand("USP_BBW_GET_BBINTVBR_MAX_VALUES")
                SqlHelper.AddParameter(cmd, "@ID_TY_INTV", SqlDbType.SmallInt, 4, interventieTypeId)
                SqlHelper.AddParameter(cmd, "@jaarIntv", SqlDbType.SmallInt, 4, jaartal)
                SqlHelper.AddParameter(cmd, "@ID_Afd", SqlDbType.SmallInt, 4, afdelingId)
                SqlHelper.AddParameter(cmd, "@id_intv", SqlDbType.SmallInt, 4, 0, ParameterDirection.Output)
                SqlHelper.AddParameter(cmd, "@aantalIntvJaar", SqlDbType.SmallInt, 4, 0, ParameterDirection.Output)
                SqlHelper.AddParameter(cmd, "@aantalIntvAfd", SqlDbType.SmallInt, 4, 0, ParameterDirection.Output)

                SqlHelper.ExecuteNonQuery(cmd)

                maxInterventieId = CInt(cmd.Parameters("@id_intv").Value)
                maxAfdelingVolgnummer = CInt(cmd.Parameters("@aantalIntvJaar").Value)
                maxJaarVolgnummer = CInt(cmd.Parameters("@aantalIntvAfd").Value)
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMaxValuesInterventie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Sub

        Public Sub GetMaxValuesRegistratie(ByVal tmsRegistratie As Date, _
                                       ByRef idReg As Integer, _
                                       ByRef volgnrRegJaar As Integer)
            'doel: insert van nieuwe brandweerinterventie
            'Opgelet: stored procedure met 2 output parameters

            Try
                Dim cmd As SqlCommand = SqlHelper.GetSqlCommand("USP_BBW_GET_BBBEWREG_MAX_VALUES")
                SqlHelper.AddParameter(cmd, "@tmsRegistratie", SqlDbType.DateTime, 4, tmsRegistratie)
                SqlHelper.AddParameter(cmd, "@id_reg", SqlDbType.SmallInt, 4, 0, ParameterDirection.Output)
                SqlHelper.AddParameter(cmd, "@volgnr_reg_jaar", SqlDbType.SmallInt, 4, 0, ParameterDirection.Output)

                SqlHelper.ExecuteNonQuery(cmd)

                idReg = CInt(cmd.Parameters("@id_reg").Value)
                volgnrRegJaar = CInt(cmd.Parameters("@volgnr_reg_jaar").Value)
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMaxValuesRegistratie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Sub

        Public Function GetBrandenPerAfdelingMaand(ByVal maand As Integer, _
                                         ByVal jaar As Integer) As TDSBrandenPerAfdeling

            'doel: gegevens ophalen voor het maandrapport "Branden per afdeling"

            Dim dsResult As New TDSBrandenPerAfdeling
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BMA_GET_REPORT_MND_BRANDEN_PER_AFD")

                SqlHelper.AddTableMapping(0, "BBBRRD", da)

                SqlHelper.AddParameter("@Maand", SqlDbType.Int, 2, maand, da)
                SqlHelper.AddParameter("@Jaar", SqlDbType.Int, 4, jaar, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandenPerAfdelingMaand")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBrandenPerAfdelingJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling

            'doel: gegevens ophalen voor het jaarrapport "Branden per afdeling"

            Dim dsResult As New TDSBrandenPerAfdeling
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BMA_GET_REPORT_JR_BRANDEN_PER_AFD")

                SqlHelper.AddTableMapping(0, "BBBRRD", da)

                SqlHelper.AddParameter("@Jaar", SqlDbType.Int, 4, jaar, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandenPerAfdelingJaar")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBrandenPerAfdelingAardJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling

            'doel: gegevens ophalen voor het jaarrapport "Branden per afdeling en aard"

            Dim dsResult As New TDSBrandenPerAfdeling
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BMA_GET_REPORT_JR_BRANDEN_PER_AFD_AARD")

                SqlHelper.AddTableMapping(0, "BBBRRD", da)

                SqlHelper.AddParameter("@Jaar", SqlDbType.Int, 4, jaar, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandenPerAfdelingAardJaar")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBrandenPerAfdelingOorzaakJaar(ByVal jaar As Integer) As TDSBrandenPerAfdeling

            'doel: gegevens ophalen voor het jaarrapport "Branden per afdeling en oorzaak"

            Dim dsResult As New TDSBrandenPerAfdeling
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BMA_GET_REPORT_JR_BRANDEN_PER_AFD_RD")

                SqlHelper.AddTableMapping(0, "BBBRRD", da)

                SqlHelper.AddParameter("@Jaar", SqlDbType.Int, 4, jaar, da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandenPerAfdelingOorzaakJaar")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetRegistratieTypesDagverslag() As TDSDagverslagRegistratieType
            'Doel: ophalen van alle registratietypes dagverslagen.
            'Auteur: Siddien
            'Datum: okt. 2006

            Dim dsResult As New TDSDagverslagRegistratieType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDGTYREG")

                SqlHelper.AddTableMapping(0, "BBDGTYREG", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetRegistratieTypesDagverslag")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetDagverslagenPersoneel(ByVal datumVanaf As DateTime) As TDSDagverslagPersoneel
            'Doel: ophalen van alle dagverslagenPersoneel
            'Auteur: Dien
            'Datum: okt 2006
            Dim dsResult As New TDSDagverslagPersoneel
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDGPERS")

                SqlHelper.AddTableMapping(0, "BBDGPERS", da)
                SqlHelper.AddParameter("@datumVanaf", SqlDbType.DateTime, 8, datumVanaf, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetDagverslagenPersoneel")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetDagverslagenPersoneelVerstuurd(ByVal datumVanaf As DateTime) As TDSBBDGPERSVZ
            'Doel: ophalen van dagverslag verstuurd
            'Auteur: Dien
            'datum: jan 2007
            Dim dsResult As New TDSBBDGPERSVZ
            Dim da As SqlDataAdapter
            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_BBDGPERSVZ")

                SqlHelper.AddTableMapping(0, "BBDGPERSVZ", da)
                SqlHelper.AddParameter("@DT_VZ", SqlDbType.DateTime, 8, datumVanaf, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Throw
            End Try
        End Function

        Public Function GetDagverslagInlichtingen(ByVal datumVanaf As DateTime, _
                                                  ByVal datumTot As DateTime) As TDSDagverslagInlichtingen
            'Doel: ophalen van alle dagverslagen inlichtingen tss twee datums
            'Auteur: Dien
            'Datum: okt 2006
            Dim dsResult As New TDSDagverslagInlichtingen
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDGPO")

                SqlHelper.AddTableMapping(0, "BBDGPO", da)
                SqlHelper.AddParameter("@datumVanaf", SqlDbType.DateTime, 8, datumVanaf, da)
                SqlHelper.AddParameter("@datumTot", SqlDbType.DateTime, 8, datumTot, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetDagverslagInlichtingen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetDagverslagInlichtingTypes() As TDSDagverslagInlichtingType
            'Doel: ophalen van alle dagverslaginlichtingentypes
            'Auteur: Siddien
            'Datum: okt. 2006
            Dim dsResult As New TDSDagverslagInlichtingType
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDGPODL")

                SqlHelper.AddTableMapping(0, "BBDGPODL", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetDagverslagInlichtingTypes")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetAtlDagverslagInlichtingenVoorDag(ByVal datum As DateTime) As Integer
            'Doel: ophalen van aantal dagverslage inlichtingen voor dag ...
            'Auteur: DIEN
            'Datum: okt. 2006
            Try
                Dim oCommand As SqlCommand = SqlHelper.GetSqlCommand("USP_BBW_EXIST_BBDGPO")
                SqlHelper.AddParameter(oCommand, "@datum", SqlDbType.DateTime, 8, datum)
                Return CInt(SqlHelper.ExecuteScalar(oCommand))
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAtlDagverslagInlichtingenVoorDag")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetBetrokkenenAanrijding(ByVal idReg As Integer) As TDSBBBTROGV
            'Doel: ophalen van alle betrokkenen van een aanrijding
            'Auteur: DIEN 
            'Datum: okt. 2006
            Try
                Dim dsResult As New TDSBBBTROGV
                Dim da As SqlDataAdapter

                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBTROGV", ADF.Data.DbHelper.ActionEnum.Fill)
                SqlHelper.AddTableMapping(0, "BBBTROGV")
                SqlHelper.AddParameter("@id_Reg", SqlDbType.Int, 4, idReg, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception

                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBetrokkenenAanrijding")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetLijstInbreukReglementen() As TDSLijstInbreukRegl
            'Doel:   Lijst inbreuk reglementen (voor maandrapporten)
            'Auteur: Nancy Coppens - 19/12/2006

            Try
                Dim dsResult As New TDSLijstInbreukRegl
                Dim da As SqlDataAdapter

                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_InbreukReglementen")
                SqlHelper.AddTableMapping(0, "Lijst_InbreukReglementen", da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBetrokkenenAanrijding")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetDiefstallenPerTrimester() As TDSTrimesterDiefstal
            'Doel:   Overzicht diefstallen 
            'Auteur: Mieke Duynslager - 14/06/2007

            Try
                Dim da As SqlDataAdapter
                Dim ds As TDSTrimesterDiefstal = New TDSTrimesterDiefstal
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBDIEFST_TRIMESTER")
                SqlHelper.AddTableMapping(0, "DiefstalTrimester", da)
                SqlHelper.Fill(ds, da)
                Return ds
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetDiefstallen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetSpecBestForMailMetBijlage() As TDSBBBSTBY
            'Doel:   Overzicht van de bestemmelingen waarvoor een mail met bijlagen moet verstuurd worden i.p.v. Documentum URL
            'Auteur: Mieke Duynslager - 18/09/2007
            Try
                Dim da As SqlDataAdapter
                Dim ds As TDSBBBSTBY = New TDSBBBSTBY
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBBSTBY_WITH_BYLG")
                SqlHelper.AddTableMapping(0, "BBBSTBY", da)
                SqlHelper.Fill(ds, da)
                Return ds
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSpecBestForMailMetBijlage")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetLijstSnelheidsOvertredingen(ByVal intern As Boolean) As TDSSnelheidsOvertredingen
            'Doel:   Lijst snelheidsovertredingen
            'Auteur: Lawrence Verbruggen - 12/04/2011

            Try
                Using da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_SNELHEIDSOVERTREDINGEN")
                    SqlHelper.AddTableMapping(0, "Lijst_Snelheidsovertredingen", da)
                    SqlHelper.AddParameter("@Intern", SqlDbType.Bit, 1, intern, da)

                    Dim dsResult As New TDSSnelheidsOvertredingen
                    SqlHelper.Fill(dsResult, da)
                    Return dsResult
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstSnelheidsovertredingen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetOvertredingen(ByVal intern As Boolean,
                                         ByVal aConnectionString As String,
                                         ByVal aDatefrom As DateTime) As TDSOvertreding

            Try
                ' GMae, 2014-06-30: Bepaling van de omschrijving van de sanctie is gewijzigd in samenspraak met Nancy Coppens en Isabelle Hebbrechts.
                '                   Ingeval van overtredingen die niet 'Klasse 1', 'Klasse 2' of 'Snelheid' zijn, wordt de omschrijving 'Geen sanctie nodig'.

                Dim strSql As String = "SELECT	bbinbrrg.id_reg AS RegistratieID," &
                    "bbind.nm_ind AS Naam," &
                    "bbind.vnm_ind AS Voornaam," &
                    "bbind.id_ind AS StamnrOvertreder," &
                    "bbinbrindty.scf_inbr_ind_ty AS OvertrederType," &
                    "bbbewreg.tms_inc AS Tijdstip, " &
                    "month(bbbewreg.tms_inc) AS Maand," &
                    "year(bbbewreg.tms_inc) AS Jaar," &
                    "bbbewreg.pla_inc AS Plaats," &
                    "bbinbrva.snl_ok AS ToegelatenSnelheid," &
                    "bbinbrva.snl_reg AS GeregistreerdeSnelheid," &
                    "bbinbrar.nr_art_inbr AS Artnr, " &
                    "bbinbrar.InbreukKlasseId as inbreukKlasseId, " &
                    "bbinbrar.scf_art_inbr AS Artikel, " &
                    "bbinbrty.scf_ty_inbr AS InbreukType, " &
                    "bbbewreg.vlg_reg_jr_bpl AS Volgnr," &
                    "bbinbrva.pbh_nok_snl_dt_van AS RijverbodVan," &
                    "bbinbrva.pbh_nok_snl_dt_tot AS RijverbodTot, " &
                    "bbinbrva.pbh_dt_ovk AS AfspraakPBH, " &
                    "bbinbrva.pbh_tms_print AS AfdrukTijdstip," &
                    "bbinbrva.sodie_cnt_id AS SoDieContactId, " &
                    "bbind.sap_dir, " &
                    "bbind.sap_afd, " &
                    "bbind.sap_sect," &
                    "dbo.bbinbrva.DatePrintLetterExt AS DatumBrief, " &
                    "dbo.bbinbrva.KindOfSanction     AS SoortSanctie, " &
                    "dbo.bbinbrva.[Language]         AS TaalBrief, " &
                    "dbo.bbfrm.nm_frm                AS NaamFirma, " &
                    "coalesce(dbo.BBINBRSanction.SanctionDescr, CASE WHEN (@Intern = 1) AND (dbo.BBINBRAR.InbreukKlasseID IN (1, 2, 4)) THEN null ELSE 'Geen sanctie nodig' END) AS SanctieOmschrijving, " &
                    "bbinbrva.SanctionDuration As SanctieDuur, " &
                    "bbinbrva.SanctionPeriod As SanctiePeriode, " &
                    "dbo.BBINBRKlasse.InbreukKlasse As Inbreukklasse, " &
                    "bbinbrva.LastSanctionDoubledYN AS LastSanctionDoubledYN, " &
                    "dbo.BBFRM.ID_FRM AS FirmaId, " &
                    "dbo.BBINBRSanction.SanctionID as SanctionId, " &
                    "dbo.BBINBRVA.Remark as Remarks " &
                    "FROM dbo.BBINBRRG INNER JOIN " &
                    "dbo.BBINBRVA ON bbinbrrg.id_reg = bbinbrva.id_reg INNER JOIN " &
                    "dbo.BBINBRAR ON bbinbrva.id_art_inbr = bbinbrar.id_art_inbr INNER JOIN " &
                    "dbo.BBINBRTY ON bbinbrar.id_ty_inbr = bbinbrty.id_ty_inbr INNER JOIN " &
                    "dbo.BBBEWREG ON bbinbrrg.id_reg = bbbewreg.id_reg INNER JOIN " &
                    "dbo.BBIND ON bbinbrrg.id_inbr = bbind.id_ind INNER JOIN " &
                    "dbo.BBINBRKlasse ON dbo.BBINBRAR.InbreukKlasseID = dbo.BBINBRKlasse.InbreukKlasseID LEFT OUTER JOIN " &
                    "dbo.BBINBRSanction ON dbo.BBINBRVA.SanctionID = dbo.BBINBRSanction.SanctionID LEFT OUTER JOIN " &
                    "dbo.BBFRM ON bbinbrva.idfirm = bbfrm.id_frm LEFT OUTER JOIN " &
                    "dbo.BBINBRINDTY ON bbinbrrg.id_inbr_ind_ty = bbinbrindty.id_inbr_ind_ty " &
                    "WHERE (((@Intern = 1 AND bbinbrindty.scf_inbr_ind_ty Like '%Arcelor Gent%') OR " &
                    "(@Intern != 1 AND bbinbrindty.scf_inbr_ind_ty Not Like '%Arcelor Gent%'))) AND " &
                    "(bbbewreg.tms_inc >= '" & aDatefrom.ToString("yyyy-MM-dd") & "') AND " &
                    "(bbbewreg.DateInvalid IS NULL) " &
                    "ORDER By bbind.id_ind    DESC"

                Dim dsResult As New TDSOvertreding

                Using sqlDa As SqlDataAdapter = New SqlDataAdapter()
                    Dim sqlCmd As SqlCommand = New SqlCommand
                    sqlCmd.Connection = New SqlConnection(aConnectionString)
                    sqlCmd.CommandText = strSql
                    sqlCmd.Parameters.Add(New SqlParameter("@Intern", SqlDbType.Bit)).Value = intern
                    sqlCmd.Connection.Open()
                    sqlDa.SelectCommand = sqlCmd
                    sqlDa.Fill(dsResult, dsResult.Lijst_Overtredingen.TableName)
                    sqlCmd.Connection.Close()
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstSnelheidsovertredingen")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try

        End Function

        Public Function GetSnelheidsovertredingPBHAfspraak(ByVal regId As Integer, ByVal aConnectionString As String) As DateTime
            Try
                Dim pbhAfspraak As DateTime
                Dim selectCmd As String

                selectCmd = "SELECT PBH_DT_OVK, PBH_TMS_PRINT FROM BBINBRVA " & _
                            "WHERE [ID_REG] = @RegId " & _
                            "AND SNL_REG > 0"
                Dim cmdSelectPbhAfspraak As New SqlCommand(selectCmd, New SqlConnection(aConnectionString))
                cmdSelectPbhAfspraak.CommandType = CommandType.Text
                cmdSelectPbhAfspraak.Parameters.Add("@RegId", SqlDbType.Int, 4).Value = regId
                cmdSelectPbhAfspraak.Connection.Open()
                Dim reader As SqlDataReader = cmdSelectPbhAfspraak.ExecuteReader()

                If (reader.Read()) Then
                    If (Not reader.IsDBNull(0)) Then
                        pbhAfspraak = reader.GetDateTime(0)
                    ElseIf (Not reader.IsDBNull(1)) Then
                        pbhAfspraak = reader.GetDateTime(1)
                    Else
                        pbhAfspraak = DateTime.Now
                    End If
                Else
                    pbhAfspraak = DateTime.Now
                End If

                cmdSelectPbhAfspraak.Connection.Close()

                Return pbhAfspraak
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSnelheidsovertredingPBHAfspraak")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function GetHierarchicalPersonalIdsToAvoid(ByVal aConnectionString As String) As List(Of String)
            Try
                Dim strSql As String
                strSql = "Select WD FROM BBCONF " &
                    " WHERE GR_SLE='EMAIL_EXCLUDE' AND SLE='PERSONALIDS' "

                Dim sqlConn As SqlConnection = New SqlConnection(aConnectionString)
                Dim selectConf As New SqlCommand(strSql, sqlConn)

                sqlConn.Open()
                Dim result As Object = selectConf.ExecuteScalar()
                sqlConn.Close()

                If Not (result Is Nothing) Then
                    Dim newList As List(Of String) = New List(Of String)
                    newList.AddRange(result.ToString().Split(CChar(";")))
                    Return newList
                End If
                Return Nothing
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSnelheidsovertredingPBHAfspraak")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function DetermineSpeedingSanction(ByVal pIsTruck As Boolean,
                                                ByVal pSpeedingLimit As Integer,
                                                ByVal pVelocity As Integer,
                                                ByVal pRecidive As Integer,
                                                ByVal aConnectionString As String) As Integer
            Dim columnToSelect As String = String.Empty
            Select Case pRecidive
                Case 0
                    columnToSelect = "Sanction1"
                Case 1
                    columnToSelect = "Sanction2_24months"
                Case Else
                    columnToSelect = "Sanction3_24months"
            End Select

            Dim strSql As String
            strSql = " SELECT " & columnToSelect &
                " FROM BBINBRSanctionMatrix " &
                " WHERE TruckYN=@truck AND " &
                " Zone=@speedingLimit AND " &
                " SpeedFrom <=@Velocity AND SpeedTo >= @Velocity"

            Dim sqlConn As SqlConnection = New SqlConnection(aConnectionString)
            Dim selectConf As New SqlCommand(strSql, sqlConn)

            selectConf.Parameters.Add(New SqlParameter("@truck", SqlDbType.Bit) With {.Value = pIsTruck})
            selectConf.Parameters.Add(New SqlParameter("@speedingLimit", SqlDbType.Int) With {.Value = pSpeedingLimit})
            selectConf.Parameters.Add(New SqlParameter("@Velocity", SqlDbType.Int) With {.Value = pVelocity})

            sqlConn.Open()
            Dim result As Object = selectConf.ExecuteScalar()
            sqlConn.Close()

            If Not (result Is Nothing) Then
                Return Convert.ToInt32(result)
            Else
                Return 0
            End If

        End Function

        'Public Function GetOvertrederInbreukReglement(ByVal aIdReg As Integer, ByVal aConnectionString As String) As Integer
        '    Try
        '        Dim overtrederId As Integer = -1
        '        Dim selectCmd As String

        '        selectCmd = "SELECT ID_INBR FROM BBINBRRG " & _
        '                    "WHERE [ID_REG] = @RegId"
        '        Dim cmdSelectPbhAfspraak As New SqlCommand(selectCmd, New SqlConnection(aConnectionString))
        '        cmdSelectPbhAfspraak.CommandType = CommandType.Text
        '        cmdSelectPbhAfspraak.Parameters.Add("@RegId", SqlDbType.Int, 4).Value = aIdReg
        '        cmdSelectPbhAfspraak.Connection.Open()
        '        Dim reader As SqlDataReader = cmdSelectPbhAfspraak.ExecuteReader()

        '        If (reader.Read() And Not reader.IsDBNull(0)) Then
        '            overtrederId = reader.GetInt32(0)
        '        End If

        '        cmdSelectPbhAfspraak.Connection.Close()

        '        Return overtrederId
        '    Catch ex As Exception
        '        ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        '        Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetOvertrederInbreukReglement")
        '        Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
        '        Throw exc
        '    End Try
        'End Function

        ''' <summary>
        ''' This function returns the data needed for Sodie
        ''' With
        ''' 1) Data to determine if the infractions in valiable for SoDie
        ''' 2) Data to insert into Sodie
        ''' </summary>
        ''' <param name="pConnectionstring">The connectionstring needed to access the database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetSodieData(ByVal pInbrReg As Integer,
                                     ByVal pConnectionstring As String) As TDSINBRVASOD
            Dim strSql As String
            strSql = "SELECT dbo.BBINBRVA.SanctionID, dbo.BBINBRVA.PBH_TMS_PRINT, dbo.BBINBRKlasse.InbreukKlasseID, dbo.BBINBRVA.ID_REG, " &
            "dbo.BBINBRVA.SODIE_CNT_ID, dbo.BBINBRAR.NR_ART_INBR, dbo.BBINBRVA.ID_INBRVA " &
            "FROM dbo.BBINBRAR INNER JOIN " &
            "dbo.BBINBRKlasse ON dbo.BBINBRAR.InbreukKlasseID = dbo.BBINBRKlasse.InbreukKlasseID INNER JOIN " &
            "dbo.BBINBRVA ON dbo.BBINBRAR.ID_ART_INBR = dbo.BBINBRVA.ID_ART_INBR " &
            "WHERE ID_REG= @RegId"

            Dim dsResult As TDSINBRVASOD = New TDSINBRVASOD
            Using sqlDa As SqlDataAdapter = New SqlDataAdapter()

                Dim cmdSelectPbhAfspraak As New SqlCommand(strSql, New SqlConnection(pConnectionstring))
                cmdSelectPbhAfspraak.CommandType = CommandType.Text
                cmdSelectPbhAfspraak.Parameters.Add("@RegId", SqlDbType.Int).Value = pInbrReg
                sqlDa.SelectCommand = cmdSelectPbhAfspraak
                sqlDa.Fill(dsResult.BBINBRVA)

            End Using

            Return dsResult

        End Function

        ''' <summary>
        ''' This function returns the translation of BBW. This function returns a dictionary.
        ''' In this dictionary we will see a combination of Key (Inbreukklasse => BBW Db) and Value (ARSoortId => Sodie Db)
        ''' </summary>
        ''' <remarks>Juni 2013 Stijn Vranken</remarks>
        Public Function GetSodieARKindOfContactTranslation(ByVal aConnectionString As String) As Dictionary(Of Integer, Integer)
            Dim strSql As String
            strSql = "SELECT WD " &
                "From BBCONF " &
                "WHERE GR_SLE='SODIE' AND SLE='ContactARSoort' "

            Dim dttValues As DataTable = New DataTable()
            Using sqlDa As SqlDataAdapter = New SqlDataAdapter()

                Dim cmdSelectPbhAfspraak As New SqlCommand(strSql, New SqlConnection(aConnectionString))
                cmdSelectPbhAfspraak.CommandType = CommandType.Text
                sqlDa.SelectCommand = cmdSelectPbhAfspraak
                sqlDa.Fill(dttValues)

            End Using

            Dim returnMap As New Dictionary(Of Integer, Integer)

            If (dttValues.Rows.Count > 0) Then
                Dim StringCombination As List(Of String) = New List(Of String)
                'First split. We retrieve the combinations based on the intermediate ';'
                StringCombination.AddRange(dttValues.Rows(0).Item(0).ToString.Split(CChar(";")))
                'For each combination we split based on the '='
                For Each stringObj As String In StringCombination
                    Dim tempArr() As String = stringObj.Split(CChar("="))
                    If (tempArr.Length > 0) Then
                        returnMap.Add(CInt(tempArr(0).ToString), CInt(tempArr(1).ToString))
                    End If

                Next

            End If

            Return returnMap
        End Function

#End Region

#Region "CHIP Data"

        ''' <summary>
        ''' Doel: Lijst van Klachten, geldig voor CHIP systeem
        ''' </summary>
        ''' <param name="aDateFrom">yyyy-MM-dd</param>
        ''' <param name="aDateTo">yyyy-MM-dd</param>
        ''' <returns></returns>
        ''' <remarks>Auteur: Lawrence Verbruggen - 21/02/2011</remarks>
        ''' 
        Public Function GetChipComplaints(ByVal aDateFrom As String, ByVal aDateTo As String) As TDSChipKlachten
            Try
                Dim dsResult As New TDSChipKlachten
                Dim da As SqlDataAdapter

                aDateFrom = aDateFrom & " 00:00:00"
                aDateTo = aDateTo & " 23:59:59"

                da = SqlHelper.GetSqlDataAdapter("UPS_BBW_GET_ALL_CHIP_KLACHTEN")
                SqlHelper.AddTableMapping(0, "VW_CHIP_KLACHTEN", da)
                SqlHelper.AddParameter("@DateFrom", SqlDbType.NVarChar, 19, aDateFrom, da)
                SqlHelper.AddParameter("@DateTo", SqlDbType.NVarChar, 19, aDateTo, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetChipKlachten")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Doel: Lijst van Klachten, geldig voor CHIP systeem
        ''' </summary>
        ''' <param name="aDateFrom">yyyy-MM-dd</param>
        ''' <param name="aDateTo">yyyy-MM-dd</param>
        ''' <returns></returns>
        ''' <remarks>Auteur: Lawrence Verbruggen - 21/02/2011</remarks>
        ''' 
        Public Function GetChipComplaints_SAPfirmanr(ByVal aDateFrom As String, ByVal aDateTo As String, ByVal aSAPfirmanr As String) As TDSChipKlachten
            Try
                Dim dsResult As New TDSChipKlachten
                Dim da As SqlDataAdapter

                aDateFrom = aDateFrom & " 00:00:00"
                aDateTo = aDateTo & " 23:59:59"

                da = SqlHelper.GetSqlDataAdapter("UPS_BBW_GET_ALL_CHIP_KLACHTEN_SAPfirmanr")
                SqlHelper.AddTableMapping(0, "VW_CHIP_KLACHTEN", da)
                SqlHelper.AddParameter("@DateFrom", SqlDbType.NVarChar, 19, aDateFrom, da)
                SqlHelper.AddParameter("@DateTo", SqlDbType.NVarChar, 19, aDateTo, da)
                SqlHelper.AddParameter("@SAP_SUPPLIER_ID", SqlDbType.NVarChar, 30, aSAPfirmanr, da)
                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetChipKlachten")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

#End Region

#Region "Brandweermateriaal - augustus 2011"

        ''' <summary>
        ''' Get list of material of the fire brigade
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database</param>
        ''' <returns></returns>
        ''' <remarks>naco - gmae - aug 2011</remarks>
        Public Shared Function GetBrandweerMateriaalLijst(ByVal dbConnection As String) As TDSBrandweerMateriaal

            Const sql As String =
                "SELECT	dbo.bmMateriaal.TypeMatID, dbo.bmMateriaal.MateriaalVolgNr, dbo.bmTypeMateriaal.TypeMatOmschr, " &
                "dbo.bmSoortTypeMateriaal.SoortTypeMatOmschr, dbo.bmMateriaal.FabricatieNr, dbo.bmAfdeling.AfdelingCode, dbo.bmLocatie.LocatieZone, " &
                "dbo.bmMateriaal.LocatieNr, dbo.bmMateriaal.LocatieOmschr, dbo.bmLeverancier.NaamLeverancier, " &
                "dbo.bmAfdelingBeheerder.BeheerderAfdelingNaam, dbo.bmMateriaal.LeveringsDatum, dbo.bmMateriaal.VisueleControleFreq, " &
                "dbo.bmMateriaal.DatumVisueleKeuring, dbo.bmStatus.Status, dbo.bmMateriaal.DatumPoederControle, " &
                "dbo.bmMateriaal.DatumHervullingNaGebruik, dbo.bmMateriaal.HervullingGemeld, " &
                "dbo.bmMateriaal.DatumLaatsteKeuring, DateAdd(year, 10, dbo.bmMateriaal.DatumLaatsteKeuring) As DatumVolgendeKeuring,  " &
                "dbo.bmBrandblusCode.BrandblusCodeOmschr, " &
                "dbo.bmBrandblusCode.GroteControleFreq, " &
                "dbo.bmMateriaal.VervangenDoor, dbo.bmMateriaal.DatumHerkeuringLeverancier " &
                "FROM             dbo.bmAfdeling " &
                "RIGHT OUTER JOIN dbo.bmLocatie            ON dbo.bmAfdeling.AfdelingID = dbo.bmLocatie.AfdelingID " &
                "RIGHT OUTER JOIN dbo.bmMateriaal          ON dbo.bmLocatie.LocatieID = dbo.bmMateriaal.LocatieID " &
                "LEFT OUTER JOIN  dbo.bmTypeMateriaal      ON dbo.bmMateriaal.TypeMatID = dbo.bmTypeMateriaal.TypeMatID " &
                "LEFT OUTER JOIN  dbo.bmLeverancier        ON dbo.bmMateriaal.LeverancierID = dbo.bmLeverancier.LeverancierID " &
                "LEFT OUTER JOIN  dbo.bmAfdelingBeheerder  ON dbo.bmMateriaal.BeheerderAfdelingID = dbo.bmAfdelingBeheerder.BeheerderAfdelingID " &
                "LEFT OUTER JOIN  dbo.bmSoortTypeMateriaal ON dbo.bmMateriaal.SoortTypeMatID = dbo.bmSoortTypeMateriaal.SoortTypeMatID " &
    "LEFT OUTER JOIN  dbo.bmBrandblusCode      ON dbo.bmSoortTypeMateriaal.BrandblusCodeID = dbo.bmBrandblusCode.BrandblusCodeID " &
                "LEFT OUTER JOIN  dbo.bmStatus             ON dbo.bmMateriaal.StatusId = dbo.bmStatus.StatusId " &
                "WHERE dbo.bmMateriaal.DateDeleted is null " &
                "ORDER BY dbo.fn_CreateAlphanumericSortValue(LocatieNr, 1)"
            '"ORDER BY CASE " &
            '       "WHEN ISNUMERIC(replace(LocatieNr, '.', '_')) = 1 THEN CONVERT(int, LocatieNr) " &
            '       "ELSE 9999999 " &
            '       "END " &
            '       ", 	LocatieNr"
            'naco - 23/12/2016 - numeriek sorteren op volgnummer

            'naco - 05/01/2016 - CO2 blustoestellen (BrandblusCodeID = 4)


            Try
                Dim dsResult As New TDSBrandweerMateriaal

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "BrandweerMateriaal")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerMateriaalLijst")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
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
        Public Shared Function GetBrandweerMateriaalByTypeVolgnr(ByVal dbConnection As String, ByVal typeMateriaal As Integer, ByVal volgnummer As Integer) As TDSBrandweerMateriaalItem

            Const sqlFormat As String =
                    "SELECT TypeMatID, MateriaalVolgNr, LocatieID, LocatieNr, LocatieOmschr, VisueleControleFreq, " &
                    "BeheerderID, SoortTypeMatID, LeverancierID, FabricatieNr, LeveringsDatum, DatumLaatsteKeuring, " &
                    "DatumVisueleKeuring, DatumPoederControle, DatumVolgendePoederControle, " &
                    "DatumHervullingNaGebruik, HervullingGemeld, DatumHerkeuringLeverancier, VervangenDoor, Opmerking, " &
                    "GecontroleerdYN, GecontroleerdPoederYN, BeheerderAfdelingID, VolgnummerAfdeling, StatusId " &
                    "FROM dbo.bmMateriaal " &
                    "WHERE TypeMatId = {0} AND MateriaalVolgNr = {1}"

            Try
                Dim sql As String = String.Format(sqlFormat, typeMateriaal, volgnummer)

                Dim dsResult As New TDSBrandweerMateriaalItem

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Materiaal")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerMaterialTypes")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of types of fire brigade material (fire extinguishers, fire hydrants, ...).
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerMaterialTypes(ByVal dbConnection As String) As TDSBrandweerMateriaalTypes

            Const sql As String = "SELECT TypeMatID, TypeMatOmschr, KleineControleFreq FROM dbo.bmTypeMateriaal ORDER BY TypeMatOmschr"

            Try
                Dim dsResult As New TDSBrandweerMateriaalTypes

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "BrandweerMateriaalTypes")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerMaterialTypes")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of types of fire extinguishers.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerExtinguisherTypes(ByVal dbConnection As String) As TDSBrandweerExtinguisherTypes

            Const sql1 As String = "SELECT BrandblusCodeID, BrandblusCodeOmschr, GroteControleFreq FROM dbo.bmBrandblusCode ORDER BY BrandblusCodeOmschr"
            Const sql2 As String = "SELECT SoortTypeMatID, TypeMatID, BrandblusCodeID, BrandblusInhoud, SoortTypeMatOmschr FROM dbo.bmSoortTypeMateriaal ORDER BY TypeMatID, SoortTypeMatOmschr"

            Try
                Dim dsResult As New TDSBrandweerExtinguisherTypes

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql1, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "BrandblusCode")
                    queryAdapter.Fill(dsResult)
                End Using

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql2, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "TypeBlustoestel")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerExtinguisherTypes")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of suppliers of fire brigade material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerSuppliers(ByVal dbConnection As String) As TDSBrandweerLeveranciers

            Const sql As String = "SELECT LeverancierId, NaamLeverancier FROM dbo.bmLeverancier ORDER BY NaamLeverancier"

            Try
                Dim dsResult As New TDSBrandweerLeveranciers

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Leverancier")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerSuppliers")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of departments - in the point of view of the fire brigade.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerDepartments(ByVal dbConnection As String) As TDSBrandweerAfdelingen

            Const sql1 As String = "SELECT AfdelingID, AfdelingCode, AfdelingNaam FROM dbo.bmAfdeling ORDER BY AfdelingCode"
            Const sql2 As String = "SELECT LocatieID, AfdelingID, LocatieZone FROM dbo.bmLocatie ORDER BY LocatieZone"
            Const sql3 As String = "SELECT AfdelingUserID, LoginNaam, AfdelingID, AfdelingOmschr FROM dbo.bmAfdelingUser ORDER BY LoginNaam"

            Try
                Dim dsResult As New TDSBrandweerAfdelingen

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql1, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Afdeling")
                    queryAdapter.Fill(dsResult)
                End Using

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql2, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Zone")
                    queryAdapter.Fill(dsResult)
                End Using

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql3, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "AfdelingUser")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerDepartments")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of the stati for the fire brigade material.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerStatus(ByVal dbConnection As String) As TDSBrandweerStatus

            Const sql As String = "SELECT StatusId, Status FROM dbo.bmStatus ORDER BY Status"

            Try
                Dim dsResult As New TDSBrandweerStatus

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Status")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerStatus")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of the managers for the fire brigade material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerManagers(ByVal dbConnection As String) As TDSBrandweerBeheerderAfdeling

            Const sql As String = "SELECT BeheerderAfdelingID, BeheerderAfdelingNaam, AfdelingID FROM dbo.bmAfdelingBeheerder ORDER BY BeheerderAfdelingNaam"

            Try
                Dim dsResult As New TDSBrandweerBeheerderAfdeling

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "BeheerderAfdeling")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerManagers")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of the send history for the fire brigade material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerVerzending(ByVal dbConnection As String) As TDSBrandweerVerzending

            Const sql As String = "SELECT VerzendingID, TypeMatID, MateriaalVolgNr, LeverancierID, DatumVerstuurd, DatumTerug, HerkeurdYN, Opmerking FROM dbo.bmVerzending"

            Try
                Dim dsResult As New TDSBrandweerVerzending

                Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(sql, dbConnection)
                    queryAdapter.TableMappings.Add("Table", "Verzending")
                    queryAdapter.Fill(dsResult)
                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerVerzending")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
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
        Public Shared Function BrandweerMateriaalBestaat(ByVal dbConnection As String, ByVal typeMateriaal As Integer, ByVal locatieId As Integer, ByVal locatieNr As String) As Boolean

            Const sql As String = "SELECT count(*) FROM dbo.bmMateriaal " &
                                   "WHERE TypeMatId = @TypeMatId AND LocatieID = @LocatieID AND LocatieNr = @LocatieNr " &
                                   "AND DateDeleted IS NULL"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@TypeMatID", SqlDbType.Int).Value = typeMateriaal
                            .Add("@LocatieID", SqlDbType.Int).Value = locatieId
                            .Add("@LocatieNr", SqlDbType.NVarChar).Value = locatieNr
                        End With

                        Return 0 <> CInt(command.ExecuteScalar())
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - BrandweerMateriaalBestaat")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' This function checks whether a report has been invalidated
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="idReg">The id of the registration</param>
        Public Shared Function IsReportInvalid(ByVal dbConnection As String, ByVal idReg As Integer) As Boolean

            Const sql As String = "select count(*) from BBBEWREG where DateInvalid  is not null and id_reg = @Id_Reg"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@Id_Reg", SqlDbType.Int).Value = idReg
                        End With

                        Return 0 <> CInt(command.ExecuteScalar())
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - IsReportInvalid")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Save the information on a piece of fire brigade material (fire extinguishers, fire hydrants, ...).
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="materiaal">The information on the material.</param>
        ''' <returns>True if the material was successfully saved.</returns>
        ''' <remarks></remarks>
        Public Shared Function SaveBrandweerMateriaal(ByVal dbConnection As String, ByVal materiaal As TDSBrandweerMateriaalItem) As Boolean

            Debug.Assert(Not String.IsNullOrEmpty(dbConnection))
            Debug.Assert(materiaal IsNot Nothing)
            Debug.Assert(materiaal.Materiaal.Count = 1)

            Const sql As String =
                "IF exists( SELECT * FROM dbo.bmMateriaal WHERE TypeMatID = @TypeMatID AND MateriaalVolgNr = @MateriaalVolgNr )" &
                "   UPDATE dbo.bmMateriaal" &
                "   SET LocatieID = @LocatieID," &
                "       LocatieNr = @LocatieNr," &
                "       LocatieOmschr = @LocatieOmschr," &
                "       VisueleControleFreq = @VisueleControleFreq," &
                "       BeheerderID = @BeheerderID," &
                "       SoortTypeMatID = @SoortTypeMatID," &
                "       LeverancierID = @LeverancierID," &
                "       FabricatieNr = @FabricatieNr," &
                "       LeveringsDatum = @LeveringsDatum," &
                "       DatumLaatsteKeuring = @DatumLaatsteKeuring," &
                "       DatumVisueleKeuring = @DatumVisueleKeuring," &
                "       DatumPoederControle = @DatumPoederControle," &
                "       DatumVolgendePoederControle = @DatumVolgendePoederControle," &
                "       DatumHervullingNaGebruik = @DatumHervullingNaGebruik," &
                "       HervullingGemeld = @HervullingGemeld," &
                "       DatumHerkeuringLeverancier = @DatumHerkeuringLeverancier," &
                "       VervangenDoor = @VervangenDoor," &
                "       Opmerking = @Opmerking," &
                "       GecontroleerdYN = @GecontroleerdYN," &
                "       GecontroleerdPoederYN = @GecontroleerdPoederYN," &
                "       BeheerderAfdelingID = @BeheerderAfdelingID," &
                "       VolgnummerAfdeling = @VolgnummerAfdeling," &
                "       StatusId = @StatusId" &
                "   WHERE TypeMatID = @TypeMatID AND MateriaalVolgNr = @MateriaalVolgNr;" &
                " ELSE" &
                " BEGIN" &
                "   DECLARE @nr int;" &
                "   SELECT @nr = coalesce(max(MateriaalVolgNr), 0) FROM dbo.bmMateriaal WHERE TypeMatID = @TypeMatID;" &
                "   INSERT INTO dbo.bmMateriaal(TypeMatID, MateriaalVolgNr, LocatieID, LocatieNr, LocatieOmschr, VisueleControleFreq, BeheerderID, SoortTypeMatID, LeverancierID, FabricatieNr, LeveringsDatum, DatumLaatsteKeuring, DatumVisueleKeuring, DatumPoederControle, DatumVolgendePoederControle, DatumHervullingNaGebruik, HervullingGemeld, DatumHerkeuringLeverancier, VervangenDoor, Opmerking, GecontroleerdYN, GecontroleerdPoederYN, BeheerderAfdelingID, VolgnummerAfdeling, StatusId)" &
                "   VALUES(@TypeMatID, @nr + 1, @LocatieID, @LocatieNr, @LocatieOmschr, @VisueleControleFreq, @BeheerderID, @SoortTypeMatID, @LeverancierID, @FabricatieNr, @LeveringsDatum, @DatumLaatsteKeuring, @DatumVisueleKeuring, @DatumPoederControle, @DatumVolgendePoederControle, @DatumHervullingNaGebruik, @HervullingGemeld, @DatumHerkeuringLeverancier, @VervangenDoor, @Opmerking, @GecontroleerdYN, @GecontroleerdPoederYN, @BeheerderAfdelingID, @VolgnummerAfdeling, @StatusId);" &
                " END"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Dim row As TDSBrandweerMateriaalItem.MateriaalRow = DirectCast(materiaal.Materiaal.Rows(0), TDSBrandweerMateriaalItem.MateriaalRow)

                        With command.Parameters
                            .Add("@TypeMatID", SqlDbType.Int).Value = row.TypeMatID
                            .Add("@MateriaalVolgNr", SqlDbType.Int).Value = row.MateriaalVolgNr
                            .Add("@LocatieID", SqlDbType.Int).Value = If(row.IsLocatieIDNull(), DBNull.Value, DirectCast(row.LocatieID, Object))
                            .Add("@LocatieNr", SqlDbType.NVarChar).Value = If(row.IsLocatieNrNull(), DBNull.Value, DirectCast(row.LocatieNr, Object))
                            .Add("@LocatieOmschr", SqlDbType.NVarChar).Value = If(row.IsLocatieOmschrNull(), DBNull.Value, DirectCast(row.LocatieOmschr, Object))
                            .Add("@VisueleControleFreq", SqlDbType.Int).Value = If(row.IsVisueleControleFreqNull(), DBNull.Value, DirectCast(row.VisueleControleFreq, Object))
                            .Add("@BeheerderID", SqlDbType.NVarChar).Value = If(row.IsBeheerderIDNull(), DBNull.Value, DirectCast(row.BeheerderID, Object))
                            .Add("@SoortTypeMatID", SqlDbType.Int).Value = If(row.IsSoortTypeMatIDNull(), DBNull.Value, DirectCast(row.SoortTypeMatID, Object))
                            .Add("@LeverancierID", SqlDbType.Int).Value = If(row.IsLeverancierIDNull(), DBNull.Value, DirectCast(row.LeverancierID, Object))
                            .Add("@FabricatieNr", SqlDbType.NVarChar).Value = If(row.IsFabricatieNrNull(), DBNull.Value, DirectCast(row.FabricatieNr, Object))
                            .Add("@LeveringsDatum", SqlDbType.DateTime).Value = If(row.IsLeveringsDatumNull(), DBNull.Value, DirectCast(row.LeveringsDatum, Object))
                            .Add("@DatumLaatsteKeuring", SqlDbType.DateTime).Value = If(row.IsDatumLaatsteKeuringNull(), DBNull.Value, DirectCast(row.DatumLaatsteKeuring, Object))
                            .Add("@DatumVisueleKeuring", SqlDbType.DateTime).Value = If(row.IsDatumVisueleKeuringNull(), DBNull.Value, DirectCast(row.DatumVisueleKeuring, Object))
                            .Add("@DatumPoederControle", SqlDbType.DateTime).Value = If(row.IsDatumPoederControleNull(), DBNull.Value, DirectCast(row.DatumPoederControle, Object))
                            .Add("@DatumVolgendePoederControle", SqlDbType.DateTime).Value = If(row.IsDatumVolgendePoederControleNull(), DBNull.Value, DirectCast(row.DatumVolgendePoederControle, Object))
                            .Add("@DatumHervullingNaGebruik", SqlDbType.DateTime).Value = If(row.IsDatumHervullingNaGebruikNull(), DBNull.Value, DirectCast(row.DatumHervullingNaGebruik, Object))
                            .Add("@HervullingGemeld", SqlDbType.Int).Value = If(row.IsHervullingGemeldNull(), DBNull.Value, DirectCast(row.HervullingGemeld, Object))
                            .Add("@DatumHerkeuringLeverancier", SqlDbType.DateTime).Value = If(row.IsDatumHerkeuringLeverancierNull(), DBNull.Value, DirectCast(row.DatumHerkeuringLeverancier, Object))
                            .Add("@VervangenDoor", SqlDbType.Int).Value = If(row.IsVervangenDoorNull(), DBNull.Value, DirectCast(row.VervangenDoor, Object))
                            .Add("@Opmerking", SqlDbType.NText).Value = If(row.IsOpmerkingNull(), DBNull.Value, DirectCast(row.Opmerking, Object))
                            .Add("@GecontroleerdYN", SqlDbType.Bit).Value = If(row.IsGecontroleerdYNNull(), DBNull.Value, DirectCast(row.GecontroleerdYN, Object))
                            .Add("@GecontroleerdPoederYN", SqlDbType.Bit).Value = If(row.IsGecontroleerdPoederYNNull(), DBNull.Value, DirectCast(row.GecontroleerdPoederYN, Object))
                            .Add("@BeheerderAfdelingID", SqlDbType.Int).Value = If(row.IsBeheerderAfdelingIDNull(), DBNull.Value, DirectCast(row.BeheerderAfdelingID, Object))
                            .Add("@VolgnummerAfdeling", SqlDbType.Int).Value = If(row.IsVolgnummerAfdelingNull(), DBNull.Value, DirectCast(row.VolgnummerAfdeling, Object))
                            .Add("@StatusId", SqlDbType.Int).Value = If(row.IsStatusIdNull(), DBNull.Value, DirectCast(row.StatusId, Object))
                        End With

                        command.ExecuteNonQuery()
                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - SaveBrandweerMateriaal")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Shared Function UpdateMateriaalDateDeleted(ByVal dbConnection As String, ByVal aType As Integer, ByVal aVolgnr As Integer, ByVal aUserDeleted As String) As Boolean
            'naco - 10/07/2017 - actie vergeten bij overzetten VB6 -> VB.net
            Const sql As String =
                "UPDATE dbo.bmMateriaal " &
                "SET DateDeleted = getdate(), " &
                "    UserDeleted = @UserDeleted " &
                "WHERE (TypeMatId = @type And MateriaalVolgNr = @volgnr)"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = aType
                            .Add("@volgnr", SqlDbType.Int).Value = aVolgnr
                            .Add("@UserDeleted", SqlDbType.NVarChar).Value = aUserDeleted
                        End With

                        command.ExecuteNonQuery()
                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - UpdateMateriaalDateDeleted")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function
        ''' <summary>
        ''' Mark a piece of equipment as a temporary replacement.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <param name="volgnr">The material number.</param>
        ''' <param name="plaats">The material number of the equiment that is being replaced.</param>
        ''' <remarks></remarks>
        Public Shared Function BrandweerMarkeerVervangMateriaal(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer, ByVal plaats As Integer) As Boolean

            Const sql As String =
                "UPDATE dbo.bmMateriaal " &
                "SET LocatieId = (SELECT LocatieId FROM dbo.bmMateriaal WHERE TypeMatID = @type and MateriaalVolgNr = @plaats), " &
                "    LocatieNr = (SELECT LocatieNr FROM dbo.bmMateriaal WHERE TypeMatID = @type and MateriaalVolgNr = @plaats), " &
                "    LocatieOmschr = (SELECT LocatieOmschr FROM dbo.bmMateriaal WHERE TypeMatID = @type and MateriaalVolgNr = @plaats) " &
                "WHERE(TypeMatId = @type And MateriaalVolgNr = @volgnr)"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = type
                            .Add("@volgnr", SqlDbType.Int).Value = volgnr
                            .Add("@plaats", SqlDbType.NVarChar).Value = plaats
                        End With

                        command.ExecuteNonQuery()
                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - BrandweerMarkeerVervangMateriaal")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get material description for MateriaalVolgNr (necessary for Tijdelijk vervangen door)
        ''' eg. 3963 = COO 5 3
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <returns></returns>
        ''' <remarks>naco - 13/04/2017</remarks>
        Public Shared Function BrandweerGetMateriaalOmschr(ByVal dbConnection As String, ByVal aMateriaalvolgnr As Integer) As String
            Dim strSql As String
            strSql = "SELECT afdelingcode + ' ' + locatiezone + ' ' + locatienr + ' (' + cast(materiaalvolgnr as varchar(10)) + ')' As MatDescription " &
                     "FROM bmMateriaal " &
                     "INNER JOIN bmLocatie " &
                     "ON bmMateriaal.LocatieID = bmLocatie.LocatieID " &
                     "INNER JOIN bmAfdeling ON bmLocatie.AfdelingID = bmAfdeling.AfdelingID " &
                     "WHERE materiaalvolgnr = " & aMateriaalvolgnr

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "bmMateriaal")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                Return dsResult.Rows(0).Item("MatDescription").ToString()
                            Else
                                Return String.Empty
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - BrandweerGetMateriaalOmschr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function


        ''' <summary>
        ''' Unmark a piece of equipment as a temporary replacement.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <param name="volgnr">The material number.</param>
        ''' <remarks></remarks>
        Public Shared Function BrandweerVrijgaveVervangMateriaal(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer) As Boolean

            Const sql As String =
                "UPDATE dbo.bmMateriaal " &
                "SET LocatieID = @id, " &
                "LocatieNr     = (SELECT max(cast(LocatieNr AS INT)) + 1 FROM bmMateriaal WHERE TypeMatId = @type AND LocatieId = @id), " &
                "LocatieOmschr = @locatie " &
                "WHERE TypeMatId = @type AND MateriaalVolgNr = @volgnr"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = type
                            .Add("@volgnr", SqlDbType.Int).Value = volgnr
                            .Add("@id", SqlDbType.Int).Value = 70 ' TODO: GMAE - locatie 70 is het brandweermagazijn => parameter in config file
                            .Add("@locatie", SqlDbType.NVarChar).Value = "in magazijn"
                        End With

                        command.ExecuteNonQuery()
                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - BrandweerVrijgaveVervangMateriaal")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get list of available fire extinguishers for temprorary replacements.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerVervangLijst(ByVal dbConnection As String, ByVal type As Integer) As TDSBrandweerMateriaal

            Const sql As String =
                "SELECT	dbo.bmMateriaal.TypeMatID, dbo.bmMateriaal.MateriaalVolgNr, dbo.bmTypeMateriaal.TypeMatOmschr, " &
                "dbo.bmSoortTypeMateriaal.SoortTypeMatOmschr, dbo.bmMateriaal.FabricatieNr, dbo.bmAfdeling.AfdelingCode, dbo.bmLocatie.LocatieZone, " &
                "dbo.bmMateriaal.LocatieNr, dbo.bmMateriaal.LocatieOmschr, dbo.bmLeverancier.NaamLeverancier, " &
                "dbo.bmAfdelingBeheerder.BeheerderAfdelingNaam, dbo.bmMateriaal.LeveringsDatum, dbo.bmMateriaal.VisueleControleFreq, " &
                "dbo.bmMateriaal.DatumVisueleKeuring " &
                "FROM             dbo.bmAfdeling " &
                "RIGHT OUTER JOIN dbo.bmLocatie            ON dbo.bmAfdeling.AfdelingID = dbo.bmLocatie.AfdelingID " &
                "RIGHT OUTER JOIN dbo.bmMateriaal          ON dbo.bmLocatie.LocatieID = dbo.bmMateriaal.LocatieID " &
                "LEFT OUTER JOIN  dbo.bmTypeMateriaal      ON dbo.bmMateriaal.TypeMatID = dbo.bmTypeMateriaal.TypeMatID " &
                "LEFT OUTER JOIN  dbo.bmLeverancier        ON dbo.bmMateriaal.LeverancierID = dbo.bmLeverancier.LeverancierID " &
                "LEFT OUTER JOIN  dbo.bmAfdelingBeheerder  ON dbo.bmMateriaal.BeheerderAfdelingID = dbo.bmAfdelingBeheerder.BeheerderAfdelingID " &
                "LEFT OUTER JOIN  dbo.bmSoortTypeMateriaal ON dbo.bmMateriaal.SoortTypeMatID = dbo.bmSoortTypeMateriaal.SoortTypeMatID " &
                "WHERE dbo.bmMateriaal.TypeMatId = @type "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@type", SqlDbType.Int).Value = type

                        Dim dsResult As New TDSBrandweerMateriaal

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BrandweerMateriaal")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerVervangLijst")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of all actions.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBrandweerActie(ByVal dbConnection As String) As TDSBrandweerActie

            Const sql As String =
                "SELECT ActieCodeID, ActieOmschr FROM dbo.bmActieCode ORDER BY 2"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Dim dsResult As New TDSBrandweerActie

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Actie")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBrandweerActie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of actions and measured weights for a piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <param name="volgnr">The material number.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetMateriaalActie(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer) As TDSBrandweerMateriaalActie

            Const sql As String =
                "SELECT a.ActieId, a.TypeMatID, a.MateriaalVolgNr, a.Datum, a.ActieCodeID, b.ActieOmschr, a.Gewicht " &
                "FROM dbo.bmMateriaalActie a " &
                "LEFT JOIN dbo.bmActieCode b ON a.ActieCodeID = b.ActieCodeID " &
                "WHERE a.TypeMatID = @type AND a.MateriaalVolgNr = @volgnr " &
                "ORDER BY a.Datum DESC"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = type
                            .Add("@volgnr", SqlDbType.Int).Value = volgnr
                        End With

                        Dim dsResult As New TDSBrandweerMateriaalActie

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "MateriaalActie")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMateriaalActie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Store an action and measured weight for a piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <param name="volgnr">The material number.</param>
        ''' <param name="datum"></param>
        ''' <param name="gewicht"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function StoreMateriaalActie(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime, ByVal actie As Integer?, ByVal gewicht As Decimal?) As Boolean

            Const sql As String =
                "IF exists(SELECT * FROM dbo.bmMateriaalActie WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND Datum = @datum) " &
                "UPDATE dbo.bmMateriaalActie " &
                "SET ActieCodeID = coalesce(@actie, ActieCodeID), Gewicht = coalesce(@gewicht, Gewicht) " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND Datum = @datum " &
                "ELSE " &
                "INSERT INTO dbo.bmMateriaalActie (TypeMatID, MateriaalVolgNr, Datum, ActieCodeID, Gewicht) " &
                "VALUES (@type, @volgnr, @datum, @actie, @gewicht)"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = type
                            .Add("@volgnr", SqlDbType.Int).Value = volgnr
                            .Add("@datum", SqlDbType.DateTime).Value = datum.Date
                            .Add("@actie", SqlDbType.Int).Value = IIf(actie Is Nothing, DBNull.Value, actie)
                            .Add("@gewicht", SqlDbType.Decimal).Value = IIf(gewicht Is Nothing, DBNull.Value, gewicht)
                        End With

                        command.ExecuteNonQuery()

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - StoreMateriaalActie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Delete an action / measured weight for a piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="id">The ID of the action record.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DeleteMateriaalActieById(ByVal dbConnection As String, ByVal id As Integer) As Boolean

            Const sql As String = "DELETE FROM dbo.bmMateriaalActie WHERE ActieID = @id"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id

                        command.ExecuteNonQuery()

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DeleteMateriaalActieById")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Delete an action / measured weight for a piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="type">The material type.</param>
        ''' <param name="volgnr">The material number.</param>
        ''' <param name="datum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DeleteMateriaalActie(ByVal dbConnection As String, ByVal type As Integer, ByVal volgnr As Integer, ByVal datum As DateTime) As Boolean

            Const sql As String =
                "DELETE FROM dbo.bmMateriaalActie " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND Datum = @datum"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@type", SqlDbType.Int).Value = type
                            .Add("@volgnr", SqlDbType.Int).Value = volgnr
                            .Add("@datum", SqlDbType.DateTime).Value = datum.Date
                        End With

                        command.ExecuteNonQuery()

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DeleteMateriaalActie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

#End Region

#Region "Helper Functions"

#End Region

#Region "Configuration Settings"

        Public Shared Function GetConfigurationSettings() As TDSConfiguratie
            'Doel:   Tabel BBCONF ophalen
            'Auteur: Rajiv/Koen - 24/04/2006
            'Returns: dataset met alle configuration settings

            Dim dsResult As New TDSConfiguratie
            Dim da As SqlDataAdapter

            Try
                da = SqlHelper.GetSqlDataAdapter("USP_BBW_GET_ALL_BBCONF")

                SqlHelper.AddTableMapping(0, "BBCONF", da)

                SqlHelper.Fill(dsResult, da)

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetConfigurationSettings")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Shared Function GetAddresseesFromConfig(ByVal configKey As String,
                                                       ByVal dbConnection As String) As TDSBBBestemmelingen
            Dim strSql As String
            strSql = "SELECT BBIND.ID_IND,BBIND.NM_IND, BBIND.VNM_IND, BBIND.AD_EMAL_IND " &
                "FROM BBCONF " &
                "INNER JOIN BBIND " &
                "ON BBIND.ID_IND = BBCONF.WD " &
                "WHERE GR_SLE='" & configKey & "'"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBBST")

                            Dim dsResult As New TDSBBBestemmelingen
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstInkoop")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Shared Function GetBaseLinkVera(ByVal dbConnection As String) As String
            Dim strSql As String
            strSql = "SELECT * " &
                "FROM BBCONF " &
                "WHERE GR_SLE='PATH_URL_VERA'"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBBST")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                Return dsResult.Rows(0).Item("WD").ToString()
                            Else
                                Return String.Empty
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstInkoop")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
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

            Const sql As String =
                "SELECT * FROM BBINBRSanction"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBINBRSanction")

                            Dim dsResult As New TDSBewakingSnelheidSanction
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSnelheidSanction")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Matrix sancties voor snelheidsovertredingen externen
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
        Public Shared Function GetSnelheidSanctionMatrix(ByVal dbConnection As String) As TDSBewakingSnelheidSanctionMatrix

            Const sql As String =
                "SELECT * FROM BBINBRSanctionMatrix"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBINBRSanctionMatrix")

                            Dim dsResult As New TDSBewakingSnelheidSanctionMatrix
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSnelheidSanction")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function
#End Region

#Region "Bewaking - Inkoop"

        ''' <summary>
        ''' Lijst met bestemmeling David Martens (IKP - Inkoop)
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - 23/11/2012</remarks>

        Public Shared Function GetLijstInkoop(ByVal dbConnection As String) As TDSInkoop

            Const sql As String = "SELECT distinct dbo.BBBEWREG.ID_REG, dbo.BBBEWREG.ID_TY_REG, dbo.BBIND.NM_IND, dbo.BBIND.VNM_IND, " &
                      "dbo.BBBWPLG.SCF_PLG_IND, dbo.BBREGTY.SCF_TY_REG, dbo.BBBEWREG.VLG_REG_JR_BPL, YEAR(dbo.BBBEWREG.TMS_INC) AS JR_REG, " &
                      "MONTH(dbo.BBBEWREG.TMS_INC) AS MONTH_REG, dbo.BBBEWREG.TMS_INC, dbo.BBBEWREG.TMS_OPS_REG, dbo.BBBEWREG.PLA_INC, " &
                      "dbo.BBBEWREG.DT_VZ_RAP_NW, dbo.BBBEWREG.DT_OK, dbo.BBBEWREG.DT_VZ_BST, dbo.BBBEWREG.ID_OPS, dbo.BBBEWREG.SCF_REG, " &
                      "dbo.BBBEWREG.SAP_SUPPLIER_ID, dbo.BBBEWREG.DT_CHIP, dbo.BBBEWREG.OPM_CHIP, dbo.BBBEWREG.OPM_IKP, dbo.BBBEWREG.TMS_IKP_SENDMAIL," &
                      "CAST(CASE WHEN BBBEWREG.CHIP_YN IS NULL " &
                      "          THEN 0 " &
                      "          ELSE BBBEWREG.CHIP_YN END AS Bit) AS CHIP_YN, dbo.BBBEWREG.VeraReference, dbo.BBBEWREG.VerslagContractantYN " &
                      "FROM BBBEWREG INNER JOIN " &
                      "BBREGTY ON BBBEWREG.ID_TY_REG = BBREGTY.ID_TY_REG INNER JOIN " &
                      "BBBWPERS ON BBBEWREG.ID_OPS = BBBWPERS.ID_IND INNER JOIN " &
                      "BBIND ON BBBWPERS.ID_IND = BBIND.ID_IND INNER JOIN " &
                      "BBBWPLG ON BBBWPERS.ID_PLG_IND = BBBWPLG.ID_PLG_IND INNER JOIN " &
                      "BBBST ON dbo.BBBEWREG.ID_REG = BBBST.ID_REG " &
                      "WHERE DT_VZ_RAP_NW IS NOT NULL " &
                      "AND DT_OK IS NOT NULL " &
                      "AND BBBST.ID_IND IN " &
                      "  (select wd from bbconf " &
                      "  where gr_sle = 'IKP' and sle = 'Stamnr1' " &
                      "  union " &
                      "  select wd from bbconf " &
                      "  where gr_sle = 'IKP' and sle = 'Stamnr2') " &
                      "ORDER BY BBBEWREG.TMS_OPS_REG"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "vwInkoop")

                            Dim dsResult As New TDSInkoop
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstInkoop")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Lijst brandweerinterventies met bestemmeling David Martens (IKP - Inkoop)
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - 23/11/2012</remarks>
        Public Shared Function GetLijstInkoopBrandweer(ByVal dbConnection As String) As TDSBrandweerInkoop


            Const sql As String = "SELECT     TOP (100) PERCENT dbo.BBINTVBR.ID_INTV_BRDW, BBINTVBR.ID_TY_INTV, dbo.BBINTVTY.SCF_TY_INTV, " &
                "dbo.BBINTVBR.VLG_TY_INTV_JR,YEAR(dbo.BBINTVBR.TMS_INTV) AS 'YEAR', dbo.BBINTVBR.TMS_INTV, dbo.BBAFD.KRT_AFD, " &
                "dbo.BBINTVBR.PLA_INTV, dbo.BBBRTY.SCF_BR_TY_INTV, dbo.BBBRRD.SCF_BR_RD_INTV, dbo.BBINTVBR.INDI_BRD_BLUS_AFD, " &
                "dbo.BBINTVBR.INDI_BRD_BLUS_SID, dbo.BBINTVBR.INDI_BRDW_SID_OPR, dbo.BBINTVBR.INDI_RAP_INC_OTV, dbo.BBINTVBR.DT_VZ_RAP_NW, " &
                "dbo.BBINTVBR.DT_OK, dbo.BBINTVBR.DT_VZ_BST, f.FireCauseExtraInfoId, f.FireCauseExtraInfo, BBINTVBR.VeraReference, " &
                "BBINTVBR.VerslagContractantYN " &
                "FROM dbo.BBINTVBR INNER JOIN " &
                "dbo.BBINTVTY ON BBINTVBR.ID_TY_INTV = BBINTVTY.ID_TY_INTV INNER JOIN " &
                "dbo.BBAFD ON BBAFD.ID_AFD = BBINTVBR.ID_AFD INNER JOIN " &
                "dbo.BBBRTY ON BBBRTY.ID_BR_TY_INTV = BBINTVBR.ID_BR_TY_INTV INNER JOIN " &
                "dbo.BBBRRD ON BBBRRD.ID_BR_RD_INTV = BBINTVBR.ID_BR_RD_INTV INNER JOIN " &
                "dbo.BBFireCauseExtraInfo AS f ON f.FireCauseExtraInfoId = BBINTVBR.FireCauseExtraInfoId INNER JOIN " &
                "dbo.BBBST ON dbo.BBINTVBR.ID_INTV_BRDW = dbo.BBBST.ID_INTV_BRDW " &
                "WHERE (dbo.BBINTVBR.DT_OK IS NOT NULL) AND " &
                "(dbo.BBINTVBR.DT_VZ_RAP_NW IS NOT NULL) AND " &
                "(BBBST.ID_IND IN (SELECT WD FROM dbo.BBCONF WHERE GR_SLE = 'IKP')) " &
                "ORDER BY BBINTVBR.ID_INTV_BRDW "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "TDSInkoopBrandweer")

                            Dim dsResult As New TDSBrandweerInkoop
                            queryAdapter.Fill(dsResult.TDSInkoopBrandweer)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstInkoop")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Lijst met firma's - indien de knop "Naar CHIP" nog niet is ingedrukt (IKP - Inkoop), maar vinkje "Naar CHIP" is wel aangevinkt
        ''' Tijdelijke noodoplossing voor David Martens => Query in DEX gemaakt "BBW - vinkje CHIP (IKP)"
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="aTmsInc">yyyy-mm-dd</param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - 23/11/2012</remarks>

        Public Shared Function GetLijstInkoopFirmaVinkjeCHIP(ByVal dbConnection As String, ByVal aTmsInc As String) As TDSInkoopFirmaCHIP

            Dim sql As String

            sql = "SELECT BBBEWREG.ID_REG, BBREGTY.SCF_TY_REG, BBBEWREG.ID_OPS,  BBBEWREG.TMS_INC, " &
                      "BBBEWREG.SCF_REG, BBBEWREG.PLA_INC, BBBEWREG.VLG_REG_JR_BPL As Volgnr, BBFRM.NM_FRM AS Firma_InbrRegl, " &
                      "BBFRM_1.NM_FRM as Firma_Diverse, BBBEWREG.SAP_SUPPLIER_ID, BBBEWREG.DT_CHIP, " &
                      "BBBEWREG.OPM_CHIP, BBBEWREG.CHIP_YN, BBBEWREG.OPM_IKP, BBBEWREG.TMS_IKP_SENDMAIL, BBBEWREG.OPM_PEB, " &
                      "BBBEWREG.TMS_PEB_SENDMAIL, BBBEWREG.VeraReference, BBBEWREG.VerslagContractantYN,  " &
                      "BBINBRRG.VKLR_INBR, BBINBRRG.OPM_EX_INBR_VSF, BBREGVSH.SCF_KRT_REG_VSH AS Diverse_KorteOmschr,  " &
                      "BBREGVSH.SCF_LNG_REG_VSH AS Diverse_LangeOmschr "

            sql = sql &
                      "FROM BBFRM " &
                      "FULL OUTER JOIN BBINBRRG " &
                      "FULL OUTER JOIN BBREGVSH " &
                      "LEFT OUTER JOIN BBFRM AS BBFRM_1 " &
                      "ON BBREGVSH.ID_FRM = BBFRM_1.ID_FRM " &
                      "FULL OUTER JOIN BBBEWREG " &
                      "INNER JOIN BBREGTY ON BBBEWREG.ID_TY_REG = BBREGTY.ID_TY_REG " &
                      "ON BBREGVSH.ID_REG = BBBEWREG.ID_REG " &
                      "ON BBINBRRG.ID_REG = BBBEWREG.ID_REG " &
                      "ON BBFRM.ID_FRM = BBINBRRG.ID_FRM "

            sql = sql &
                      "WHERE BBBEWREG.TMS_INC >= '" & aTmsInc & "' " &
                      "AND BBBEWREG.CHIP_YN = 1 " &
                      "ORDER BY tms_inc"


            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "vw_IKP_firmaCHIP")

                            Dim dsResult As New TDSInkoopFirmaCHIP
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetLijstInkoop")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

#End Region

        Public Shared Function GetUserBrandweer(ByVal dbConnection As String, ByVal aUser As String) As String
            'naco - 09/02/2017 - inloggen beheer BMA Brandweer Materiaal

            Dim strSql As String
            strSql = "SELECT * " &
                    "FROM BBUserBrandweer " &
                    "WHERE UserName = '" & aUser.Trim.ToUpper & "'"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBUserBrandweer")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                Return dsResult.Rows(0).Item("UserPw").ToString()
                            Else
                                Return "UNKNOWN"
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Throw
            End Try
        End Function
#Region "SAP firmanr ophalen - voor CHIP"
        ''' <summary>
        ''' Return Firmnr SAP from table BBFRM - necessary to send automatically to CHIP
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="aID_FRM"></param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - 09/09/2016</remarks>
        Public Shared Function GetSAPFirmNr(ByVal dbConnection As String, ByVal aID_FRM As Integer) As Integer

            Dim strSql As String

            strSql = "SELECT NR_IND_FRM_SAP " &
                  "FROM BBFRM " &
                  "WHERE ID_FRM = " & aID_FRM

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBBST")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                If IsDBNull(dsResult.Rows(0).Item("NR_IND_FRM_SAP")) Then
                                    Return 0
                                Else

                                    Return CInt(dsResult.Rows(0).Item("NR_IND_FRM_SAP").ToString)
                                End If

                            Else
                                Return 0
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSAPFirmNr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get email-contacts of a SAP Firm nr - necessary to send automatically mail
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="aID_FRM"></param>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens/Bart Bories - 12/09/2016</remarks>
        Public Shared Function GetSAPFirm_EmailContact(ByVal aID_FRM As Integer) As String

            'OPGELET - sidnaco - maart 2017 => wordt niet meer gebruikt
            'vervangen door Firma webservice van Bart Bories (rechtstreeks vanuit de client)
            Try

                Dim svc As New SSOUserManagementService.UserManagementServiceClient() 'svc door Bart Bories/Jeroen Tassaert ontwikkeld
                Dim result() As SSOUserManagementService.User
                result = svc.GetUsers("lev." & aID_FRM, False) 'bv. lev.72533

                'normaal gezien zal je maar één user terugkrijgen (= zelfde email-adres dat ook in CHIP wordt gebruikt
                If result.Length = 0 Then
                    Return ""
                Else
                    Return result(0).Email
                End If

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetSAPFirm_EmailContact")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Return ID_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - april 2017</remarks>
        Public Shared Function GetFirm_ID_FRMforSAPnr(ByVal dbConnection As String, ByVal aNR_IND_FRM_SAP As Integer) As Integer

            Dim strSql As String

            strSql = "SELECT ID_FRM " &
                  "FROM BBFRM " &
                  "WHERE NR_IND_FRM_SAP = " & aNR_IND_FRM_SAP

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBFRM")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                If IsDBNull(dsResult.Rows(0).Item("ID_FRM")) Then
                                    Return 0
                                Else

                                    Return CInt(dsResult.Rows(0).Item("ID_FRM").ToString)
                                End If

                            Else
                                Return 0
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetFirm_ID_FRMforSAPnr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try

        End Function

        ''' <summary>
        ''' Return NM_FRM from table BBFRM for SAP idfirm (linked with personal nr in BBIND)
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>Nancy Coppens - april 2017</remarks>
        Public Shared Function GetFirm_NM_FRMforSAPnr(ByVal dbConnection As String, ByVal aNR_IND_FRM_SAP As Integer) As String

            Dim strSql As String

            strSql = "SELECT NM_FRM " &
                  "FROM BBFRM " &
                  "WHERE NR_IND_FRM_SAP = " & aNR_IND_FRM_SAP

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(strSql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BBFRM")

                            Dim dsResult As New DataTable
                            queryAdapter.Fill(dsResult)
                            If (dsResult.Rows.Count > 0) Then
                                If IsDBNull(dsResult.Rows(0).Item("NM_FRM")) Then
                                    Return ""
                                Else

                                    Return dsResult.Rows(0).Item("NM_FRM").ToString
                                End If

                            Else
                                Return ""
                            End If

                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetFirm_NM_FRMforSAPnr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try

        End Function

#End Region

    End Class

End Namespace
