Option Explicit On
Option Infer On
Option Strict On

Imports System.Data.SqlClient


Namespace DMC

    Public Class BriefSnelheidsovertreding

        ''' <summary>
        ''' Haal de basisinformatie om een brief voor een snelheidsovertreding op te maken.
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="idRegistratie"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBriefSnelheidsovertredingInfo(ByVal dbConnection As String, ByVal idRegistratie As Integer) As TDSBriefSnelheidsovertredingInfo

            'Oude Query 
            'Leverde het foutieve type voertuig op
            'Nieuwe query houdt rekening met het type voertuig in de plaats van het privévoertuig/werkvoertuig
            'SIDVRST - SIDNACO 03/05/2013
            'Dit is een quick fix dus geen blijvende oplossing
            '<<<<<<<<<<<<<<<<<<<<<<<
            '-------QUERY-----------
            '>>>>>>>>>>>>>>>>>>>>>>>
            '"SELECT rtrim(dbo.bbind.vnm_ind) + ' ' + dbo.bbind.nm_ind as ""DriverName"", " +
            '"dbo.bbtsp.pl_nr_tsp as ""LicensePlate"", " +
            '"CASE bbtsp.indi_tsp_priv WHEN 1 THEN 'Personenwagens/motoren' ELSE 'Vrachtwagens' END as ""VehiculeType"", " +
            '"dbo.bbinbrva.snl_reg as ""MeasuredSpeed"", " +
            '"dbo.bbinbrva.snl_ok  as ""MaximumSpeed"", " +
            '"@aantal as ""Aantal"", " +
            '"dbo.bbinbrva.Language as ""Taal"", " +
            '"dbo.bbinbrva.IdFirm as ""IdFirma"", " +
            '"dbo.bbfrm.nm_frm as ""NaamFirma"", " +
            '"dbo.bbfrm.stra_frm as ""AdresFirma"", " +
            '"dbo.bbfrm.po_cod_pla_frm as ""PostnrFirma"", " +
            '"dbo.bbfrm.pla_frm as ""PlaatsFirma"" " +
            '"FROM dbo.bbbewreg " +
            '"INNER JOIN dbo.bbinbrrg ON dbo.bbbewreg.id_reg = dbo.bbinbrrg.id_reg " +
            '"INNER JOIN dbo.bbinbrva ON dbo.bbinbrrg.id_reg = dbo.bbinbrva.id_reg " +
            '"INNER JOIN dbo.bbind ON dbo.bbinbrrg.id_inbr = dbo.bbind.id_ind " +
            '"INNER JOIN dbo.bbtsp on dbo.bbinbrrg.id_tsp = dbo.bbtsp.id_tsp " +
            '"LEFT OUTER JOIN dbo.bbfrm ON dbo.bbfrm.id_frm = dbo.bbinbrva.idfirm " +
            '"WHERE dbo.bbinbrrg.id_reg = @id"


            Const sql As String =
                "SELECT rtrim(dbo.bbind.vnm_ind) + ' ' + dbo.bbind.nm_ind as ""DriverName"", " +
                "       dbo.bbtsp.pl_nr_tsp as ""LicensePlate"", " +
                "       CASE WHEN bbtsp.ID_TY_TSP In(2,6,15,20,27,28,30) THEN 'Vrachtwagens/autobussen' ELSE  'Personenwagens/motoren' END as ""VehiculeType"", " +
                "       dbo.bbinbrva.snl_reg as ""MeasuredSpeed"", " +
                "       dbo.bbinbrva.snl_ok  as ""MaximumSpeed"", " +
                "       @aantal as ""Aantal"", " +
                "       dbo.bbinbrva.Language as ""Taal"", " +
                "       dbo.bbinbrva.IdFirm as ""IdFirma"", " +
                "       dbo.bbfrm.nm_frm as ""NaamFirma"", " +
                "       dbo.bbfrm.stra_frm as ""AdresFirma"", " +
                "       dbo.bbfrm.po_cod_pla_frm as ""PostnrFirma"", " +
                "       dbo.bbfrm.pla_frm as ""PlaatsFirma"" " +
                "FROM dbo.bbbewreg " +
                "INNER JOIN dbo.bbinbrrg ON dbo.bbbewreg.id_reg = dbo.bbinbrrg.id_reg " +
                "INNER JOIN dbo.bbinbrva ON dbo.bbinbrrg.id_reg = dbo.bbinbrva.id_reg " +
                "INNER JOIN dbo.bbind ON dbo.bbinbrrg.id_inbr = dbo.bbind.id_ind " +
                "INNER JOIN dbo.bbtsp on dbo.bbinbrrg.id_tsp = dbo.bbtsp.id_tsp " +
                "LEFT OUTER JOIN dbo.bbfrm ON dbo.bbfrm.id_frm = dbo.bbinbrva.idfirm " +
                "WHERE dbo.bbinbrrg.id_reg = @id"

            Using cn = New SqlConnection(dbConnection)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idRegistratie
                    cmd.Parameters.Add("@aantal", SqlDbType.Int).Value = GetAantalOvertredingen(dbConnection, idRegistratie)

                    Using da = New SqlDataAdapter(cmd)

                        Dim result = New TDSBriefSnelheidsovertredingInfo
                        da.Fill(result.Info)

                        Return result
                    End Using
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Bepaal het aantal snelheidsovertredingen, begaan tijdens de laatste 24 maand.
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="idRegistratie"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function GetAantalOvertredingen(ByVal dbConnection As String, ByVal idRegistratie As Integer) As Integer

            Const sql As String =
                "SELECT count(*) " +
                "FROM dbo.bbbewreg " +
                "INNER JOIN dbo.bbinbrrg ON dbo.bbbewreg.id_reg = dbo.bbinbrrg.id_reg " +
                "INNER JOIN dbo.bbinbrva ON dbo.bbinbrrg.id_reg = dbo.bbinbrva.id_reg " +
                "INNER JOIN dbo.bbinbrar ON dbo.bbinbrva.id_art_inbr = dbo.bbinbrar.id_art_inbr " +
                "WHERE dbo.bbinbrar.id_ty_inbr = 2 " +
                "  AND id_inbr = (SELECT id_inbr FROM dbo.bbinbrrg WHERE id_reg = @id) " +
                "  AND dbo.bbbewreg.tms_ops_reg BETWEEN DateAdd(month, -24, GetDate()) AND GetDate()"

            Using cn = New SqlConnection(dbConnection)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idRegistratie

                    Dim aantal = cmd.ExecuteScalar()
                    Return If(IsDBNull(aantal), 0, Convert.ToInt32(aantal))
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Sla de basisgegevens van een brief op.
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="idRegistratie"></param>
        ''' <param name="datumAfdruk"></param>
        ''' <param name="taal"></param>
        ''' <param name="recidive"></param>
        ''' <param name="idFirm"></param>
        ''' <remarks></remarks>
        Public Shared Sub BewaarSnelheidsOvertredingBrief(ByVal dbConnection As String,
                                                          ByVal idRegistratie As Integer,
                                                          ByVal datumAfdruk As DateTime,
                                                          ByVal taal As String,
                                                          ByVal recidive As Integer,
                                                          ByVal idFirm As Integer)

            Const sql As String =
                      "UPDATE dbo.bbinbrva " +
                      "SET DatePrintLetterExt = @datum, " +
                      "    Language = @taal, " +
                      "    Recidive = @recidive, " +
                      "    KindOfSanction = @sanctie, " +
                      "    SanctionId = @sanctieId, " +
                      "    IdFirm = @firm " +
                      "WHERE Id_Reg = @id"

            Dim idSanctie = BepaalSanctie(dbConnection, idRegistratie, recidive)

            Using cn = New SqlConnection(dbConnection)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    With cmd.Parameters
                        .Add("@id", SqlDbType.Int).Value = idRegistratie
                        .Add("@datum", SqlDbType.DateTime).Value = datumAfdruk
                        .Add("@taal", SqlDbType.NVarChar).Value = taal
                        .Add("@recidive", SqlDbType.Int).Value = recidive
                        .Add("@sanctie", SqlDbType.NVarChar).Value = String.Format("{0}e inbreuk", recidive)
                        .Add("@sanctieId", SqlDbType.Int).Value = idSanctie
                        .Add("@firm", SqlDbType.Int).Value = idFirm
                    End With

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ''' <summary>
        ''' Bepaal de sanctie voor de bestuurder.
        ''' </summary>
        ''' <param name="dbConnection"></param>
        ''' <param name="idRegistratie"></param>
        ''' <param name="recidive"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function BepaalSanctie(ByVal dbConnection As String, ByVal idRegistratie As Integer, ByVal recidive As Integer) As Integer

            Const sql As String =
                "SELECT CASE @recidive " +
                "       WHEN 1 THEN Sanction1 " +
                "       WHEN 2 THEN Sanction2_24months " +
                "       ELSE Sanction3_24months END " +
                "FROM dbo.BBINBRSanctionMatrix " +
                "WHERE zone = (SELECT snl_ok FROM dbo.bbinbrva WHERE Id_Reg = @id) " +
                "  AND CarMotorYN = (SELECT bbtsp.indi_tsp_priv " +
                "                    FROM dbo.bbinbrrg  " +
                "                    INNER JOIN dbo.bbtsp ON dbo.bbinbrrg.id_tsp = dbo.bbtsp.id_tsp " +
                "                    WHERE Id_Reg = @id) " +
                "  AND (SELECT snl_reg FROM dbo.bbinbrva WHERE Id_Reg = @id) BETWEEN SpeedFrom AND SpeedTo"

            Using cn = New SqlConnection(dbConnection)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    With cmd.Parameters
                        .Add("@id", SqlDbType.Int).Value = idRegistratie
                        .Add("@recidive", SqlDbType.Int).Value = recidive
                    End With

                    Dim result = cmd.ExecuteScalar()
                    Return If(IsDBNull(result), 0, Convert.ToInt32(result))
                End Using
            End Using
        End Function

    End Class

End Namespace
