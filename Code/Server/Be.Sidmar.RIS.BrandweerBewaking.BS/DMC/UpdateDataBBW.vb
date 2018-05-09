Option Strict On
Option Explicit On
Option Infer On

Imports ADF.Data.SqlClient
Imports System.Data.SqlClient
Imports System.Linq

Namespace DMC

    Public Class UpdateDataBBW

#Region "Interventie Brandweer"
        Public Function CreateUpdateInterventie(ByVal data As TDSInterventie, ByVal user As String) As TDSInterventie
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 06/04/2006
            Dim da As SqlDataAdapter
            '1. Interventie
            da = UpdateDataAdaptersBBW.daBBINTVBR(SqlHelper.GetTableMapping(data.BBINTVBR))
            SqlHelper.Update(data, user, da)

            '2. Interventietijden
            da = UpdateDataAdaptersBBW.daBBINTVDU(SqlHelper.GetTableMapping(data.BBINTVDU))
            SqlHelper.Update(data, user, da)

            '3. Kosten
            da = UpdateDataAdaptersBBW.daBBMATPR(SqlHelper.GetTableMapping(data.BBMATPR))
            SqlHelper.Update(data, user, da)

            '4. Bijlagen
            da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
            SqlHelper.Update(data, user, da)

            '5. Bestemmelingen
            da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
            SqlHelper.Update(data, user, da)

            Return data

        End Function

        Public Function CreateUpdateInterventieTijden(ByVal data As TDSInterventie, ByVal user As String) As TDSInterventie
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 06/04/2006

            Dim da As SqlDataAdapter = UpdateDataAdaptersBBW.daBBINTVBR(SqlHelper.GetTableMapping(data.BBINTVDU))
            SqlHelper.Update(data, user, da)
            Return data

        End Function

        ''' <summary>
        ''' Update van een Interventie met extra informatie over branden.
        ''' </summary>
        ''' <param name="data"></param>
        ''' <remarks></remarks>
        Public Shared Sub UpdateInterventieExtraInfoBrand(ByVal data As TDSInterventie)
            Const sql As String = "UPDATE dbo.bbintvbr SET FireCauseExtraInfoId = @idInfo WHERE id_intv_brdw = @idIntv"
            Using cmd = New SqlCommand(sql)
                With cmd.Parameters
                    .Add(New SqlParameter("@idIntv", SqlDbType.Int)).Value = data.BBINTVBR.First.ID_INTV_BRDW
                    .Add(New SqlParameter("@idInfo", SqlDbType.Int)).Value = data.BBINTVBR.First.FireCauseExtraInfoId
                End With
                SqlHelper.ExecuteNonQuery(cmd)
            End Using
        End Sub

#End Region

#Region "Registratie Bewaking"
#Region "Alcoholtest"
        Public Function CreateUpdateRegistratieAlcoholtest(ByVal data As TDSAlcoholtest, ByVal user As String) As TDSAlcoholtest
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 24/04/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Alcoholtest
                da = UpdateDataAdaptersBBW.daBBALCTST(SqlHelper.GetTableMapping(data.BBALCTST))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region
#Region "Diefstal"
        Public Function CreateUpdateRegistratieDiefstal(ByVal data As TDSDiefstal, ByVal user As String) As TDSDiefstal
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 28/04/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Diefstal
                da = UpdateDataAdaptersBBW.daBBDIEFST(SqlHelper.GetTableMapping(data.BBDIEFST))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region
#Region "Openmaken kleerkast"
        Public Function CreateUpdateRegistratieOpenKleerkast(ByVal data As TDSOpenKleerkast, ByVal user As String) As TDSOpenKleerkast
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 28/04/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Openmaken kleerkast
                da = UpdateDataAdaptersBBW.daBBOPKAST(SqlHelper.GetTableMapping(data.BBOPKAST))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region

#Region "Aanrijding"


        Public Function createUpdateRegistratieAanrijding(ByVal data As TDSAanrijding, ByVal user As String) As TDSAanrijding
            'Doel: opslaan update
            'Auteur: DIEN - okt 2006
            Dim da As SqlDataAdapter

            Try
                Dim id_reg As Integer
                '1. BewakingRegistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                id_reg = CType(data.BBBEWREG.Rows(0), TDSAanrijding.BBBEWREGRow).ID_REG

                '2. AanrijdingRegistratie
                da = UpdateDataAdaptersBBW.daBBOGVTSP(SqlHelper.GetTableMapping(data.BBOGVTSP))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                '5. Betrokkene aanrijding
                da = UpdateDataAdaptersBBW.daBBBTROGV(SqlHelper.GetTableMapping(data.BBBTROGV))
                SqlHelper.Update(data, user, da)


                '6. Aanrijding toestanden
                'eerst alles verwijderen
                Dim cmdDelete As SqlCommand
                cmdDelete = SqlHelper.GetSqlCommand("USP_WY_BBOGVSTA_DELETE_REGID")
                SqlHelper.AddParameter(cmdDelete, "@ID_REG", SqlDbType.Int, 4, id_reg)
                SqlHelper.ExecuteNonQuery(cmdDelete)

                da = UpdateDataAdaptersBBW.daBBOGVSTA(SqlHelper.GetTableMapping(data.BBOGVSTA))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region

#Region "Schadegeval"
        Public Function CreateUpdateRegistratieSchadegeval(ByVal data As TDSSchadegeval, ByVal user As String) As TDSSchadegeval
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 02/05/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Schadegeval
                da = UpdateDataAdaptersBBW.daBBSCAD(SqlHelper.GetTableMapping(data.BBSCAD))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region
#Region "Diverse Registratie"
        Public Function CreateUpdateRegistratieDiverseRegistratie(ByVal data As TDSDivRegistratie, ByVal user As String) As TDSDivRegistratie
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 03/05/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Diverse registratie
                da = UpdateDataAdaptersBBW.daBBREGVSH(SqlHelper.GetTableMapping(data.BBREGVSH))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region
#Region "Controle Voertuig"
        Public Function CreateUpdateRegistratieControleVoertuig(ByVal data As TDSControleVoertuig, ByVal user As String) As TDSControleVoertuig
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 04/05/2006
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)

                '2. Controle Voertuig
                da = UpdateDataAdaptersBBW.daBBKEUTSP(SqlHelper.GetTableMapping(data.BBKEUTSP))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region

#Region "Inbreuk op reglementen"
        Public Function CreateUpdateRegistratieInbreukRegl(ByVal data As TDSInbreukRegl, ByVal user As String) As TDSInbreukRegl
            'Doel:   via gegenereerde stored procedure
            'Auteur: Koen - Rajiv - 04/05/2006
            'Aanpassing: Lawrence Verbruggen - 18/04/2011 - Snelheidsovertredingen automatisch registreren in SoDie
            Dim da As SqlDataAdapter

            Try
                '1. Bewakingregistratie
                da = UpdateDataAdaptersBBW.daBBBEWREG(SqlHelper.GetTableMapping(data.BBBEWREG))
                SqlHelper.Update(data, user, da)



                '2. Inbreuk op reglementen
                da = UpdateDataAdaptersBBW.daBBINBRRG(SqlHelper.GetTableMapping(data.BBINBRRG))
                SqlHelper.Update(data, user, da)



                '2. Inbreuken
                da = UpdateDataAdaptersBBW.daBBINBRVA(SqlHelper.GetTableMapping(data.BBINBRVA))
                SqlHelper.Update(data, user, da)

                '3. Bijlagen
                da = UpdateDataAdaptersBBW.daBBBYLG(SqlHelper.GetTableMapping(data.BBBYLG))
                SqlHelper.Update(data, user, da)

                '4. Bestemmelingen
                da = UpdateDataAdaptersBBW.daBBBST(SqlHelper.GetTableMapping(data.BBBST))
                SqlHelper.Update(data, user, da)

                Return data
            Catch ex As Exception
                Throw
            End Try
        End Function
#End Region

#Region "Snelheidsovertreding afdrukken"

        ''' <summary>
        ''' Ingegeven Datums opslaan voor een rijverbod ten gevolge van een snelheidsovertreding hoger dan 70 km/u
        ''' </summary>
        ''' <param name="aID_REG">Registratie Id</param>
        ''' <param name="aRijverbodVan">Start van het rijverbod</param>
        ''' <param name="aRijverbodTot">Einde van het rijverbod</param>
        ''' <param name="aAfspraakPBH">Afspraak met personeelsbeheer</param>
        ''' <remarks></remarks>
        Public Sub UpdateRijverbod(ByVal aID_REG As Integer, ByVal aRijverbodVan As DateTime, _
                                              ByVal aRijverbodTot As DateTime, ByVal aAfspraakPBH As DateTime)
            'Auteur: Lawrence Verbruggen - 14/04/2011
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                    "SET [PBH_NOK_SNL_DT_VAN] = @RijverbodVan " & _
                                    ",[PBH_NOK_SNL_DT_TOT] = @RijverbodTot " & _
                                    ",[PBH_DT_OVK] = @AfspraakPBH " & _
                                    "WHERE [ID_REG] = @RegId " & _
                                    "AND SNL_REG > 0"

                cmdDv.Parameters.Add(New SqlParameter("@RijverbodVan", SqlDbType.DateTime)).Value = aRijverbodVan
                cmdDv.Parameters.Add(New SqlParameter("@RijverbodTot", SqlDbType.DateTime)).Value = aRijverbodTot
                cmdDv.Parameters.Add(New SqlParameter("@AfspraakPBH", SqlDbType.DateTime)).Value = aAfspraakPBH
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int, 4)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Ingegeven Datums opslaan voor een rijverbod ten gevolge van een snelheidsovertreding hoger dan 70 km/u
        ''' </summary>
        ''' <param name="aID_REG">Registratie Id</param>
        ''' <remarks>naco - 30/05/2011</remarks>
        Public Sub UpdateRijverbodLegeDatums(ByVal aID_REG As Integer)
            'Auteur: Lawrence Verbruggen - 14/04/2011
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                    "SET [PBH_NOK_SNL_DT_VAN] = null " & _
                                        ",[PBH_NOK_SNL_DT_TOT] = null " & _
                                        ",[PBH_DT_OVK] = null " & _
                                    "WHERE [ID_REG] = @RegId " & _
                                    "AND SNL_REG > 0"
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int, 4)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
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
        Public Sub UpdateSnelheidsovertredingPrint(ByVal aID_REG As Integer, ByVal aAfdruk As DateTime)
            'Auteur: Lawrence Verbruggen - 14/04/2011
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                    "SET [PBH_TMS_PRINT] = @Afdruk " & _
                                    "WHERE [ID_REG] = @RegId " & _
                                    "AND SNL_REG > 0"

                cmdDv.Parameters.Add(New SqlParameter("@Afdruk", SqlDbType.DateTime)).Value = aAfdruk
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int, 4)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub UpdateSnelheidsovertredingSoDieContactID(ByVal aID_REG As Integer, ByVal aSoDieCNTID As Integer)
            'Auteur: Lawrence Verbruggen - 19/04/2011
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                    "SET [SODIE_CNT_ID] = @SoDieCNTID " & _
                                    "WHERE [ID_REG] = @RegId " & _
                                    "AND SNL_REG > 0"

                cmdDv.Parameters.Add(New SqlParameter("@SoDieCNTID", SqlDbType.Int, 4)).Value = aSoDieCNTID
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int, 4)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)

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
                                          ByVal aFirmId As Integer, ByVal aTaal As String,
                                          ByVal aDatumBrief As DateTime,
                                          ByVal aRevokedDrivingFrom As DateTime?,
                                          ByVal aRevokedDrivingTo As DateTime?,
                                          ByVal aMeetingPBH As DateTime?)

            Try
                Dim cmdDv As New SqlCommand
                Dim strSql As String = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                       "SET [PBH_TMS_PRINT] = @afdrukDatum, " & _
                                       "[LastSanctionDoubledYN] = @lastDoubleYN, " & _
                                       "[KindOfSanction] = @kindSanction, " & _
                                       "[SanctionID] = @sanctionId "

                If aDuration > 0 Then
                    strSql &= ",[SanctionDuration] = @sanctionDuration, " & _
                              " [SanctionPeriod] = @sanctionPeriod "
                    cmdDv.Parameters.Add(New SqlParameter("@sanctionDuration", SqlDbType.Int)).Value = aDuration
                    cmdDv.Parameters.Add(New SqlParameter("@sanctionPeriod", SqlDbType.NVarChar)).Value = aSanctionPeriod.ToString
                Else
                    strSql &= ",[SanctionDuration] = NULL, " & _
                              " [SanctionPeriod] = NULL "
                End If
                If Not aFirmId = 0 Then
                    strSql = strSql & ", [IdFirm] = @idFirm "
                    cmdDv.Parameters.Add(New SqlParameter("@idFirm", SqlDbType.Int)).Value = aFirmId
                    strSql = strSql & ", [DatePrintLetterExt] =@DatePrintLetterExt"
                    cmdDv.Parameters.Add(New SqlParameter("@DatePrintLetterExt", SqlDbType.DateTime)).Value = aDatumBrief
                End If

                If Not aTaal.Equals(String.Empty) Then
                    strSql = strSql & ", [Language] = @language "
                    cmdDv.Parameters.Add(New SqlParameter("@language", SqlDbType.NVarChar)).Value = aTaal
                End If

                If Not (aRevokedDrivingFrom = DateTime.MinValue) Then
                    strSql = strSql & ", [PBH_NOK_SNL_DT_VAN] = @drivedRevokedFrom "
                    cmdDv.Parameters.Add(New SqlParameter("@drivedRevokedFrom", SqlDbType.DateTime)).Value = aRevokedDrivingFrom
                Else
                    strSql = strSql & ", [PBH_NOK_SNL_DT_VAN] = NULL "
                End If

                If Not (aRevokedDrivingTo = DateTime.MinValue) Then
                    strSql = strSql & ", [PBH_NOK_SNL_DT_TOT] = @drivedRevokedTo "
                    cmdDv.Parameters.Add(New SqlParameter("@drivedRevokedTo", SqlDbType.DateTime)).Value = aRevokedDrivingTo
                Else
                    strSql = strSql & ", [PBH_NOK_SNL_DT_TOT] = NULL "
                End If

                If Not (aMeetingPBH = DateTime.MinValue) Then
                    strSql = strSql & ", [PBH_DT_OVK] = @dateMeetingPBH "
                    cmdDv.Parameters.Add(New SqlParameter("@dateMeetingPBH", SqlDbType.DateTime)).Value = aMeetingPBH
                Else
                    strSql = strSql & ", [PBH_DT_OVK] = NULL "
                End If

                strSql = strSql & " WHERE [ID_REG] = @RegId "
                cmdDv.CommandText = strSql

                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int)).Value = aID_REG
                cmdDv.Parameters.Add(New SqlParameter("@afdrukDatum", SqlDbType.DateTime)).Value = aPrintDate
                cmdDv.Parameters.Add(New SqlParameter("@lastDoubleYN", SqlDbType.Bit)).Value = aDoubleUp
                cmdDv.Parameters.Add(New SqlParameter("@kindSanction", SqlDbType.NVarChar)).Value = aKindOfSanction
                cmdDv.Parameters.Add(New SqlParameter("@sanctionId", SqlDbType.Int)).Value = aSanctionId


                SqlHelper.ExecuteNonQuery(cmdDv)
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
                Dim cmdDv As New SqlCommand
                Dim strSql As String = "UPDATE [BBW].[dbo].[BBINBRVA] " & _
                                       "SET [PBH_DT_OVK] = @dateMeetingPBH " & _
                                       " WHERE [ID_REG] = @RegId "

                cmdDv.CommandText = strSql
                cmdDv.Parameters.Add(New SqlParameter("@dateMeetingPBH", SqlDbType.DateTime)).Value = aDateSent
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
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
                Dim cmdDv As New SqlCommand
                Dim strSql As String
                strSql = "UPDATE BBINBRVA SET " &
                    "PBH_NOK_SNL_DT_VAN=NULL," &
                    "PBH_NOK_SNL_DT_TOT=NULL," &
                    "PBH_DT_OVK=NULL," &
                    "PBH_TMS_PRINT=NULL, " &
                    "SODIE_CNT_ID=NULL, " &
                    "DatePrintLetterExt=NULL, " &
                    "Language=NULL," &
                    "Recidive=NULL," &
                    "KindOfSanction=NULL," &
                    "SanctionID= NULL," &
                    "SanctionDuration=NULL," &
                    "SanctionPeriod=NULL," &
                    "LastSanctionDoubledYN=0 " &
                    "WHERE ID_REG=@RegId"

                cmdDv.CommandText = strSql
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int)).Value = aID_Reg

                SqlHelper.ExecuteNonQuery(cmdDv)
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
                Dim cmdDv As New SqlCommand
                Dim strSql As String
                strSql = "UPDATE BBINBRVA SET " &
                    "Remark=@Remark " &
                    "WHERE ID_REG=@RegId"

                cmdDv.CommandText = strSql
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int)).Value = aID_Reg
                cmdDv.Parameters.Add(New SqlParameter("@Remark", SqlDbType.VarChar)).Value = aRemark

                SqlHelper.ExecuteNonQuery(cmdDv)
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
                Dim cmdDv As New SqlCommand
                Dim strSql As String
                strSql = "UPDATE BBBEWREG SET " &
                    "DateInvalid    = getdate(), " &
                    "UserInvalid    = @UserInvalid, " &
                    "RemarkInvalid  = @RemarkInvalid " &
                    "WHERE ID_REG   = @RegId"

                cmdDv.CommandText = strSql
                cmdDv.Parameters.Add(New SqlParameter("@UserInvalid", SqlDbType.VarChar)).Value = user
                cmdDv.Parameters.Add(New SqlParameter("@RemarkInvalid", SqlDbType.VarChar)).Value = remark
                cmdDv.Parameters.Add(New SqlParameter("@RegId", SqlDbType.Int)).Value = idReg

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

#End Region

#End Region

#Region "Register CodeTables"

#Region "RegisterAarden"
        'Doel:   Aarden creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met aarden

        Public Overridable Function RegisterAarden(ByVal ds As TDSAarden, ByVal user As String) As TDSAarden
            Dim daBBBRTY As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBRTY(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBRTY))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBBRTY)
            Return ds
        End Function
#End Region
#Region "RegisterOorzaken"
        'Doel:   Oorzaken creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met oorzaken

        Public Overridable Function RegisterOorzaken(ByVal ds As TDSOorzaken, ByVal user As String) As TDSOorzaken
            Dim daBBBRRD As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBRRD(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBRRD))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBBRRD)
            Return ds
        End Function
#End Region
#Region "RegisterInterventietypes"
        'Doel:   Interventietypes creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met Interventietypes

        Public Overridable Function RegisterInterventietypes(ByVal ds As TDSIntvType, ByVal user As String) As TDSIntvType
            Dim daBBINTVTY As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINTVTY(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINTVTY))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBINTVTY)
            Return ds
        End Function
#End Region
#Region "RegisterAfdelingen"
        'Doel:   Afdelingen creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met afdelingen

        Public Overridable Function RegisterAfdelingen(ByVal ds As TDSAfdelingen, ByVal user As String) As TDSAfdelingen
            Dim daBBAFD As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBAFD(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBAFD))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBAFD)
            Return ds
        End Function
#End Region
#Region "RegisterEenheden"
        'Doel:   Eenheden creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met eenheden

        Public Overridable Function RegisterEenheden(ByVal ds As TDSEenheden, ByVal user As String) As TDSEenheden
            Dim daBBEH As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBEH(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBEH))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBEH)
            Return ds
        End Function
#End Region
#Region "RegisterArtikelgroep"
        'Doel:   Artikelgroepen creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met artikelgroepen

        Public Overridable Function RegisterArtikelgroepen(ByVal ds As TDSArtikelgroep, ByVal user As String) As TDSArtikelgroep
            Dim daBBARTGR As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBARTGR(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBARTGR))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBARTGR)
            Return ds
        End Function
#End Region
#Region "RegisterInbreuktypes"
        'Doel:   Inbreuktypes creeren en updaten
        'Auteur: Koen/Rajiv - 20/04/2006
        'Returns: dataset met inbreuktypes

        Public Overridable Function RegisterInbreuktypes(ByVal ds As TDSInbrType, ByVal user As String) As TDSInbrType
            Dim daBBINBRTY As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINBRTY(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINBRTY))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBINBRTY)
            Return ds
        End Function
#End Region
#Region "RegisterRegistratietypes"
        'Doel:   Registratietypes creeren en updaten
        'Auteur: Koen/Rajiv - 20/04/2006
        'Returns: dataset met registratietypes

        Public Overridable Function RegisterRegistratietypes(ByVal ds As TDSRegType, ByVal user As String) As TDSRegType
            Dim daBBREGTY As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBREGTY(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBREGTY))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBREGTY)
            Return ds
        End Function
#End Region
#Region "RegisterIndividutypes"
        'Doel:   Individutypes creeren en updaten
        'Auteur: Koen/Rajiv - 20/04/2006
        'Returns: dataset met Individutypes

        Public Overridable Function RegisterIndividutypes(ByVal ds As TDSIndividuType, ByVal user As String) As TDSIndividuType
            Dim daBBINDTY As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINDTY(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINDTY))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBINDTY)
            Return ds
        End Function
#End Region
#Region "RegisterIndividu"
        'Doel: updaten van het individu
        Public Overridable Function RegisterIndividu(ByVal ds As TDSIndividuen, ByVal user As String) As TDSIndividuen
            Dim daBBIND As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBIND(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBIND))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBIND)
            Return ds
        End Function


#End Region
#Region "RegisterInbreukartikelen"
        'Doel:   Inbreukartikelen creeren en updaten
        'Auteur: Koen/Rajiv - 20/04/2006
        'Returns: dataset met Inbreukartikelen

        Public Overridable Function RegisterInbreukartikelen(ByVal ds As TDSInbrArt, ByVal user As String) As TDSInbrArt
            Dim daBBINBR As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINBRAR(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINBRAR))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBINBR)
            Return ds
        End Function
#End Region
#Region "RegisterTypesBetrokkenen"
        'Doel:   Types betrokkenen creeren en updaten
        'Auteur: Koen/Rajiv - 20/04/2006
        'Returns: dataset met types betrokkenen 

        Public Overridable Function RegisterTypesBetrokkenen(ByVal ds As TDSTypeBetrokkene, ByVal user As String) As TDSTypeBetrokkene
            Dim daTYBTRK As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBTYBTRK(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBTYBTRK))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daTYBTRK)
            Return ds
        End Function
#End Region
#Region "RegisterTypesVoertuigen"
        'Doel:   Types voertuigen creeren en updaten
        'Auteur: Koen/Rajiv - 21/04/2006
        'Returns: dataset met types voertuigen

        Public Overridable Function RegisterTypesVoertuigen(ByVal ds As TDSVoertuigTypes, ByVal user As String) As TDSVoertuigTypes
            Dim daTYTSP As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBTYTSP(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBTYTSP))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daTYTSP)
            Return ds
        End Function
#End Region
#Region "RegisterAanspreektitels"
        'Doel:   Aanspreektitels creeren en updaten
        'Auteur: Koen/Rajiv - 21/04/2006
        'Returns: dataset met aanspreektitels

        Public Overridable Function RegisterAanspreektitels(ByVal ds As TDSAanspreektitel, ByVal user As String) As TDSAanspreektitel
            Dim daINDGSL As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINDGSL(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINDGSL))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daINDGSL)
            Return ds
        End Function
#End Region
#Region "RegisterPloegen"
        'Doel:   Ploegen creeren en updaten
        'Auteur: Koen/Rajiv - 21/04/2006
        'Returns: dataset met ploegen

        Public Overridable Function RegisterPloegen(ByVal ds As TDSPloeg, ByVal user As String) As TDSPloeg
            Dim daPLG As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBWPLG(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBWPLG))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daPLG)
            Return ds
        End Function
#End Region
#Region "RegisterSchadeAan"
        'Doel:   SchadeAan creeren en updaten
        'Auteur: Koen/Rajiv - 21/04/2006
        'Returns: dataset met SchadeAan

        Public Overridable Function RegisterSchadeAan(ByVal ds As TDSScadObjecten, ByVal user As String) As TDSScadObjecten
            Dim daSCAD As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBSCADAN(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBSCADAN))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daSCAD)
            Return ds
        End Function
#End Region
#Region "RegisterGebruikVoertuig"
        'Doel:   GebruikVoertuig creeren en updaten
        'Auteur: Koen/Rajiv - 21/04/2006
        'Returns: dataset met GebruikVoertuig

        Public Overridable Function RegisterGebruikVoertuig(ByVal ds As TDSGebruikVoertuig, ByVal user As String) As TDSGebruikVoertuig
            Dim daBRKTSP As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBRKTSP(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBRKTSP))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBRKTSP)
            Return ds
        End Function
#End Region
#Region "RegisterWerfvoertuigen"
        'Doel:   Werfvoertuigen creeren en updaten
        'Auteur: Koen/Rajiv - 19/04/2006
        'Returns: dataset met werfvoertuigen

        Public Overridable Function RegisterWerfvoertuigen(ByVal ds As TDSWerfVoertuig, ByVal user As String) As TDSWerfVoertuig
            Dim daBBBWRFTSP As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBWRFTSP(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBWRFTSP))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBBWRFTSP)
            Return ds
        End Function
#End Region
#Region "RegisterInterventieartikelen"
        'Doel:   Interventieartikelen creeren en updaten
        'Auteur: Koen/Rajiv - 02/05/2006
        'Returns: dataset met Interventieartikelen

        Public Overridable Function RegisterInterventieartikelen(ByVal ds As TDSIntvArt, ByVal user As String) As TDSIntvArt
            Dim daBBINTART As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBINTART(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBINTART))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBINTART)
            Return ds
        End Function
#End Region
#End Region

#Region "RegisterStock"
        'Doel:   Stock creeren en updaten
        'Auteur: Koen/Rajiv - 24/04/2006
        'Returns: dataset met stockartikelen

        Public Overridable Function RegisterStock(ByVal ds As TDSVerbruiksArtikel, ByVal user As String) As TDSVerbruiksArtikel
            Dim daBBBRKART As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBRKART(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBRKART))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBBRKART)
            Return ds
        End Function
#End Region

#Region "Register voertuigen"
        'Doel: registreren voertuigen
        'Auteur: SIDDIEN - okt. 2006
        Public Overridable Function RegisterVoertuigen(ByVal ds As TDSVoertuigen, ByVal user As String) As TDSVoertuigen
            Dim daBBTSP As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBTSP(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBTSP))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBTSP)
            Return ds
        End Function
#End Region

#Region "Register firma's"
        'Doel: codetabel firma's
        'Auteur: SIDDIEN - 29sep 06
        Public Overridable Function RegisterFirmas(ByVal ds As TDSFirmas, ByVal user As String) As TDSFirmas
            Dim daBBFRM As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBFRM(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBFRM))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBFRM)
            Return ds
        End Function
#End Region

#Region "Register verzekeringfirma's"
        Public Overridable Function RegisterVerzFirmas(ByVal ds As TDSVerzFirmas, ByVal user As String) As TDSVerzFirmas
            Dim daBBVZKFRM As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBVZKFRM(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBVZKFRM))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBVZKFRM)
            Return ds
        End Function
#End Region

#Region "Register dagverslag personeel"
        'Auteur: dien - okt 2006
        'Doel: opslaan/wijzigen dagverslag personeel
        Public Function RegisterDagverslagPersoneel(ByVal ds As TDSDagverslagPersoneel, ByVal user As String) As TDSDagverslagPersoneel
            Dim daBBDGPERS As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBDGPERS(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBDGPERS))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBDGPERS)
            Return ds
        End Function
#End Region

#Region "Register dagverslag registratietypes"
        'Auteur: Dien - okt. 2006
        'Doel: opslaan dagverslag registratietypes.
        Public Function registerDagverslagRegistratieTypes(ByVal ds As TDSDagverslagRegistratieType, ByVal user As String) As TDSDagverslagRegistratieType
            Dim daBBDGTYREG As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBDGTYREG(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBDGTYREG))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBDGTYREG)
            Return ds
        End Function
#End Region

#Region "Register dagverslag inlichtingen"
        'Auteur: Dien -okt 2006
        'Doel: opslaan/wijzigen dagverslag inlichting
        Public Function RegisterDagverslagInlichting(ByVal ds As TDSDagverslagInlichtingen, ByVal user As String) As TDSDagverslagInlichtingen
            Dim daBBDGPO As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBDGPO(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBDGPO))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBDGPO)
            Return ds
        End Function
#End Region

#Region "Register dagverslag inlichtingType"
        'Auteur: Dien - okt. 2006
        'Doel: Opslaan dagverslag inlichtingtype.
        Public Function registerDagverslagInlichtingType(ByVal ds As TDSDagverslagInlichtingType, ByVal user As String) As TDSDagverslagInlichtingType
            Dim daBBDGPODL As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBDGPODL(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBDGPODL))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBDGPODL)
            Return ds
        End Function
#End Region

#Region "Register personeel"
        'Auteur: Dien - okt. 2006
        Public Function registerPersoneel(ByVal ds As TDSBBBWPERS, ByVal user As String) As TDSBBBWPERS
            Dim daBBBWPERS As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBBWPERS(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBBWPERS))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBBWPERS)
            Return ds
        End Function
#End Region

#Region "Register afdelingsmilieucoordinator"
        'Auteur: dien - mei 2009
        Public Function registerAFDAMC(ByVal ds As TDSBBAFDAMC, ByVal user As String) As TDSBBAFDAMC
            Dim daBBAFDAMC As System.Data.SqlClient.SqlDataAdapter = UpdateDataAdaptersBBW.daBBAFDAMC(ADF.Data.SqlClient.SqlHelper.GetTableMapping(ds.BBAFDAMC))
            ADF.Data.SqlClient.SqlHelper.Update(ds, user, daBBAFDAMC)
            Return ds
        End Function
#End Region

#Region "Dagverslag personeel"
        Public Sub ToevoegenDagverslagPersoneel(ByVal datum As DateTime)
            'Auteur: Siddien - jan 2007
            Try
                Dim cmdDv As SqlCommand
                cmdDv = SqlHelper.GetSqlCommand("USP_WY_BBDGPERSVZ_INSERT")
                SqlHelper.AddParameter(cmdDv, "@DT_VZ ", SqlDbType.DateTime, 8, datum)
                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub
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
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBAFDAMC SET ID_IND = " & aID_IND & _
                                    " WHERE ID_AFD = " & aID_AFD & _
                                    " AND ID_IND = " & aOldID_IND
                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub
#End Region

#Region "CHIP"
        ''' <summary>
        ''' Update of BBEWREG with CHIP data
        ''' </summary>
        ''' <param name="aID_REG"></param>
        ''' <param name="aSAP_SUPPLIER_ID"></param>
        ''' <param name="aDT_CHIP"></param>
        ''' <param name="aOPM_CHIP"></param>
        ''' <remarks>Lawrence - 03/03/2011</remarks>
        Public Sub UpdateCHIP(ByVal aID_REG As Integer, ByVal aSAP_SUPPLIER_ID As String, _
                                ByVal aDT_CHIP As DateTime, ByVal aOPM_CHIP As String)
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET SAP_SUPPLIER_ID = @SAP_SUPPLIER_ID, " & _
                                    "DT_CHIP = @DT_CHIP ," & _
                                    "OPM_CHIP = @OPM_CHIP " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@SAP_SUPPLIER_ID", SqlDbType.VarChar, 30)).Value = aSAP_SUPPLIER_ID
                cmdDv.Parameters.Add(New SqlParameter("@DT_CHIP", SqlDbType.DateTime)).Value = aDT_CHIP
                cmdDv.Parameters.Add(New SqlParameter("@OPM_CHIP", SqlDbType.VarChar, 100)).Value = aOPM_CHIP
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' vraag van Jeroen/Bart (ibo-aanvraag PEB - Eddy Van Renterghem)
        ''' vanuit CHIP kan leverancier aanduiden of verslag gelezen is
        ''' </summary>
        ''' <param name="aID_REG"></param>
        ''' <remarks>Nancy Coppens - 05/12/2017</remarks>
        Public Function CHIPUpdate_BBW_ReportReadOK(ByVal aID_REG As Long, ByVal aRemark As String) As String
            Try
                'ByVal aTmsReadBySupplier As String
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET CHIPReadYN = 1, " & _
                                    "CHIPReadTms = getdate()," & _
                                    "CHIPRemark = @OPM_CHIP " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@OPM_CHIP", SqlDbType.VarChar, 100)).Value = aRemark
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
                Return "OK"

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
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET CHIP_YN = @CHIP_YN " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@CHIP_YN", SqlDbType.Bit)).Value = aCHIP_YN
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub
#End Region

        Function TestSodie() As Boolean
            Throw New NotImplementedException
        End Function

#Region "Update IKP"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="aID_REG"></param>
        ''' <param name="aOPM_IKP"></param>
        ''' <remarks>Nancy Coppens - 04/12/2012</remarks>
        Public Sub UpdateIKPOpmerking(ByVal aOPM_IKP As String, ByVal aID_REG As Integer)
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET OPM_IKP = @OPM_IKP " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@OPM_IKP", SqlDbType.VarChar)).Value = aOPM_IKP
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
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
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET TMS_IKP_SENDMAIL = @TMS_IKP_SENDMAIL " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@TMS_IKP_SENDMAIL", SqlDbType.DateTime)).Value = aTMS_IKP_SENDMAIL
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Set datum Tms_IKP_Sendmail = null
        ''' </summary>
        ''' <param name="aID_REG"></param>
        ''' <remarks>Nancy Coppens - 14/12/2012</remarks>
        Public Sub UpdateIKPSendMailNull(ByVal aID_REG As Integer)
            Try
                Dim cmdDv As New SqlCommand
                cmdDv.CommandText = "UPDATE BBBEWREG " & _
                                    "SET TMS_IKP_SENDMAIL = null " & _
                                    "WHERE ID_REG = @ID_REG"
                cmdDv.Parameters.Add(New SqlParameter("@ID_REG", SqlDbType.Int, 32)).Value = aID_REG

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

#End Region

#Region "Update Firma's"

        Public Sub UpdateBBFRM_SAP(ByVal aSAP_FRMNR As Integer, ByVal aSAP_FRMNM As String, _
                                   ByVal aBBFRM_ID_FRM As Integer, ByVal aBBFRM_STRA As String, _
                                   ByVal aBBFRM_POSTCODE As String, ByVal aBBFRM_PLAATS As String)
            'Code: Thomas Beirens - 2015
            'aangepast met NM_FRM = @FRMNM (door naco - 11/08/2016)
            Try
                Dim cmdDv As New SqlCommand

                cmdDv.CommandText = "UPDATE BBFRM " & _
                                "SET NR_IND_FRM_SAP = @FRMNR, " &
                                "NM_FRM = @FRMNM, " &
                                "NM_FRM_SAP = @FRMNM, " &
                                "STRA_FRM = @STRAFRM, " &
                                "PO_COD_PLA_FRM = @POCODEFRM, " &
                                "PLA_FRM= @PLAFRM " &
                                "WHERE ID_FRM = @ID_FRM"
                cmdDv.Parameters.Add(New SqlParameter("@FRMNR", SqlDbType.Int, 32)).Value = aSAP_FRMNR
                cmdDv.Parameters.Add(New SqlParameter("@FRMNM", SqlDbType.VarChar)).Value = Mid(Trim(aSAP_FRMNM), 1, 50)
                cmdDv.Parameters.Add(New SqlParameter("@ID_FRM", SqlDbType.Int, 32)).Value = aBBFRM_ID_FRM

                cmdDv.Parameters.Add(New SqlParameter("@STRAFRM", SqlDbType.VarChar)).Value = aBBFRM_STRA
                cmdDv.Parameters.Add(New SqlParameter("@POCODEFRM", SqlDbType.VarChar)).Value = aBBFRM_POSTCODE
                cmdDv.Parameters.Add(New SqlParameter("@PLAFRM", SqlDbType.VarChar)).Value = aBBFRM_PLAATS

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub UpdateBBFRM_EmailRemarkLanguage(pID_FRM As Integer, pEmailContact As String, pRemark As String, pLanguage As String)
            'Code: naco - maart 2017
            'Update Firma: mailcontact, remark, language (necessary if firm is not known in SAP)

            Try
                Dim cmdDv As New SqlCommand

                cmdDv.CommandText = "UPDATE BBFRM " & _
                                "SET BBW_FirmEmailContacts = @pEmailContact, " &
                                "BBW_FirmRemark = @pRemark, " &
                                "BBW_FirmLanguage = @pLanguage " &
                                "WHERE ID_FRM = @ID_FRM"

                cmdDv.Parameters.Add(New SqlParameter("@ID_FRM", SqlDbType.Int, 32)).Value = pID_FRM
                cmdDv.Parameters.Add(New SqlParameter("@pEmailContact", SqlDbType.VarChar)).Value = pEmailContact
                cmdDv.Parameters.Add(New SqlParameter("@pRemark", SqlDbType.VarChar)).Value = pRemark
                cmdDv.Parameters.Add(New SqlParameter("@pLanguage", SqlDbType.VarChar)).Value = pLanguage

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub UpdateBBFRM_SAP(ByVal aSAP_FRMNR As Integer, ByVal aSAP_FRMNM As String, ByVal aBBFRM_ID_FRM As Integer)
            'Code: Thomas Beirens - 2015
            'aangepast met NM_FRM = @FRMNM (door naco - 11/08/2016)
            Try
                Dim cmdDv As New SqlCommand

                cmdDv.CommandText = "UPDATE BBFRM " & _
                                    "SET NR_IND_FRM_SAP = @FRMNR, " &
                                    "NM_FRM = @FRMNM, " &
                                    "NM_FRM_SAP = @FRMNM " &
                                    "WHERE ID_FRM = @ID_FRM"

                cmdDv.Parameters.Add(New SqlParameter("@FRMNR", SqlDbType.Int, 32)).Value = aSAP_FRMNR
                cmdDv.Parameters.Add(New SqlParameter("@FRMNM", SqlDbType.VarChar)).Value = aSAP_FRMNM
                cmdDv.Parameters.Add(New SqlParameter("@ID_FRM", SqlDbType.Int, 32)).Value = aBBFRM_ID_FRM

                SqlHelper.ExecuteNonQuery(cmdDv)
            Catch ex As Exception
                Throw
            End Try
        End Sub


#End Region

    End Class




End Namespace