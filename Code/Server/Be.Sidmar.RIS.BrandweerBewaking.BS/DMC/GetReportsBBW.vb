Option Explicit On
Option Strict On

Imports ADF.ExceptionHandling
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Text


Namespace DMC

    Public NotInheritable Class GetReportsBBW

#Region "Brandweermateriaal - Rapporten"

        ''' <summary>
        ''' Get the overview of refilled fire extingoushers.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="jaar">The year for this report.</param>
        ''' <param name="perAfdeling">True = by department, False = by Type.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetMateriaalHervuld(ByVal dbConnection As String, ByVal jaar As Integer, ByVal perAfdeling As Boolean) As BS.TDSBrandweerReportHervuldeBlustoestellen

            Const sqlPerAfdeling As String =
                "WITH Totalen(Afdeling, HervullingGemeld, Aantal) " &
                "AS " &
                "( " &
                "	SELECT AfdelingCode, HervullingGemeld, count(*) " &
                "	FROM bmMateriaal " &
                "	JOIN bmLocatie ON bmMateriaal.LocatieId = bmLocatie.LocatieId " &
                "	JOIN bmAfdeling ON bmLocatie.AfdelingId = bmAfdeling.AfdelingId " &
                "	WHERE year(DatumHervullingNagebruik) = @jaar " &
                "	GROUP BY AfdelingCode, HervullingGemeld " &
                ") " &
                "SELECT	DISTINCT Afdeling as ""Label"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.Afdeling = t.Afdeling AND s.HervullingGemeld = 0) as ""AantalSchriftelijk"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.Afdeling = t.Afdeling AND s.HervullingGemeld = 1) as ""AantalTelefonisch"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.Afdeling = t.Afdeling AND (s.HervullingGemeld NOT IN (0, 1) OR s.HervullingGemeld IS NULL)) as ""AantalNietGemeld"" " &
                "FROM Totalen t "

            Const sqlPerType As String =
                "WITH Totalen(TypeMat, HervullingGemeld, Aantal) " &
                "AS " &
                "( " &
                "	SELECT SoortTypeMatOmschr, HervullingGemeld, count(*) " &
                "	FROM bmMateriaal " &
                "	JOIN bmSoortTypeMateriaal ON bmMateriaal.SoortTypeMatId = bmSoortTypeMateriaal.SoortTypeMatId " &
                "	WHERE year(DatumHervullingNagebruik) = @jaar " &
                "	GROUP BY SoortTypeMatOmschr, HervullingGemeld " &
                ") " &
                "SELECT	DISTINCT TypeMat as ""Label"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.TypeMat = t.TypeMat AND s.HervullingGemeld = 0) as ""AantalSchriftelijk"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.TypeMat = t.TypeMat AND s.HervullingGemeld = 1) as ""AantalTelefonisch"", " &
                "		(SELECT coalesce(sum(s.Aantal),0) FROM Totalen s WHERE s.TypeMat = t.TypeMat AND (s.HervullingGemeld NOT IN (0, 1) OR s.HervullingGemeld IS NULL)) as ""AantalNietGemeld"" " &
                "FROM Totalen t "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(If(perAfdeling, sqlPerAfdeling, sqlPerType), connection)
                        command.Parameters.Add("@jaar", SqlDbType.Int).Value = jaar

                        Dim dsResult As New TDSBrandweerReportHervuldeBlustoestellen

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Report")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMateriaalHervuldPerAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
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
        Public Shared Function GetMateriaalControleLijst(ByVal dbConnection As String, ByVal isVisueleControle As Boolean, ByVal datumVorigeControle As DateTime) As BS.TDSBrandweerMateriaalControleLijst

            Const sqlTemplate1 As String =
                "SELECT	t.TypeMatOmschr ""TypeMateriaal"", " &
                "		s.SoortTypeMatOmschr ""TypeBlustoestel"", " &
                "		a.AfdelingCode ""Afdeling"", l.LocatieZone ""Zone"", m.LocatieNr ""Nr"", " &
                "		x.Status, m.LocatieOmschr, " &
                "		b.BeheerderAfdelingNaam ""NaamBeheerderAfdeling"", " &
                "		0 ""Gecontroleerd"", " &
                "		m."

            Const sqlTemplate2 As String =
                " ""DatumControle"", " &
                "		c.Gewicht ""VorigGewicht"", " &
                "		NULL ""NieuwGewicht"", " &
                "       m.TypeMatID, " &
                "       m.MateriaalVolgNr, " &
                "       m.DatumVisueleKeuring, " &
                "       m.DatumPoederControle, " &
                "       m.DatumVolgendePoederControle " &
                "FROM		dbo.bmMateriaal m " &
                "JOIN		dbo.bmTypeMateriaal t ON t.TypeMatID = m.TypeMatId " &
                "LEFT JOIN		dbo.bmSoortTypeMateriaal s ON s.SoortTypeMatID = m.SoortTypeMatId " &
                "JOIN		dbo.bmLocatie l ON l.LocatieID = m.LocatieID " &
                "JOIN		dbo.bmAfdeling a ON a.AfdelingID = l.AfdelingID " &
                "LEFT JOIN	dbo.bmStatus x ON x.StatusId = m.StatusId " &
                "LEFT JOIN	dbo.bmAfdelingBeheerder b ON b.BeheerderAfdelingID = m.BeheerderAfdelingID " &
                "LEFT JOIN	dbo.bmMateriaalActie c ON c.TypeMatID = m.TypeMatId AND c.MateriaalVolgNr = m.MateriaalVolgNr " &
                "WHERE m.DateDeleted IS NULL " &
                "    And ( c.Datum IS NULL " &
                "          OR	c.Datum = ( SELECT max(Datum) " &
                "					FROM dbo.bmMateriaalActie " &
                "					WHERE TypeMatID = m.TypeMatId AND MateriaalVolgNr = m.MateriaalVolgNr )) "

            Dim sql As New StringBuilder()
            If isVisueleControle Then
                sql.Append(sqlTemplate1)
                sql.Append("DatumVisueleKeuring")
                sql.Append(sqlTemplate2)
                sql.Append("  AND	( m.DatumVisueleKeuring IS NULL OR DATEADD(month, m.VisueleControleFreq, m.DatumVisueleKeuring) < @datum ) ")
            Else
                sql.Append(sqlTemplate1)
                sql.Append("DatumPoederControle")
                sql.Append(sqlTemplate2)
                sql.Append(" AND	( m.DatumVolgendePoederControle IS NULL OR m.DatumVolgendePoederControle < @datum )")
                sql.Append(" AND (m.SoortTypeMatID in (SELECT SoortTypeMatID FROM dbo.bmSoortTypeMateriaal WHERE brandbluscodeid in (1,5)))") 'enkel de poeder en schuim blustoestellen tonen

            End If

            'naco - 23/12/2016 - numeriek sorteren op volgnummer
            'sql.Append(" order by  CASE " &
            '           "WHEN ISNUMERIC(replace(LocatieNr, '.', '_')) = 1 THEN CONVERT(int, LocatieNr) " &
            '           "ELSE 9999999 " &
            '           "END " &
            '           ", 	LocatieNr")
            sql.Append(" ORDER BY dbo.fn_CreateAlphanumericSortValue(LocatieNr, 1)")

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql.ToString(), connection)
                        command.Parameters.Add("@datum", SqlDbType.DateTime).Value = datumVorigeControle

                        Dim dsResult As New TDSBrandweerMateriaalControleLijst

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "ControleLijst")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

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
        Public Shared Function SaveMateriaalControleLijst(ByVal dbConnection As String, ByVal controleLijst As TDSBrandweerMateriaalControleLijst, _
                                                          ByVal isVisueleControle As Boolean, ByVal nieuweDatum As DateTime) As Boolean

            Const sqlVisueel As String =
                "UPDATE dbo.bmMateriaal " &
                "SET DatumVisueleKeuring = @datum " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr"

            'Const sqlPoeder As String =
            '"UPDATE dbo.bmMateriaal " &
            '"SET DatumPoederControle = @datum, DatumVolgendePoederControle = DATEADD(year, 2, @datum) " &
            '"WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr"
            Const sqlPoeder As String =
                "UPDATE dbo.bmMateriaal " &
                "SET DatumPoederControle = @datum, DatumVolgendePoederControle = DATEADD(month, 24, @datum) " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND SoortTypeMatID in (SELECT SoortTypeMatID FROM dbo.bmSoortTypeMateriaal WHERE brandbluscodeid = 1);" &
                "UPDATE dbo.bmMateriaal " &
                "SET DatumPoederControle = @datum, DatumVolgendePoederControle = DATEADD(month, 72, @datum) " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND SoortTypeMatID in (SELECT SoortTypeMatID FROM dbo.bmSoortTypeMateriaal WHERE brandbluscodeid = 5);"

            '05/01/2017 - overleg met Hans De Vijlder en Steven De Smaele (Brandweer):
            'poeder = volgende controle + 2 jaar (poeder = brandbluscode 5)
            'schuim = volgende controle + 6 jaar (schuim = brandbluscode 1)
            'van de 2 SQL-statements zal er maar één uitgevoerd worden (door SoortTypeMatID

            'BrandblusCodeID	BrandblusCodeOmschr	GroteControleFreq
            '1                  poeder              24
            '2	                CO2, Halon, Schuim	120
            '3                  N2                  120
            '4                  CO2                 120
            '5                  Schuim              72

            Const sqlGewicht As String = "DELETE FROM dbo.bmMateriaalActie " &
                "WHERE TypeMatID = @type AND MateriaalVolgNr = @volgnr AND Datum = @datum; " &
                " " &
                "INSERT INTO dbo.bmMateriaalActie (TypeMatID, MateriaalVolgNr, Datum, ActieCodeID, Gewicht) " &
                "VALUES (@type, @volgnr, @datum, 5, @gewicht);"
            'naco - 23/12/2016 - code van Geert Maertens => uitgeschakeld - oude acties mogen blijven


            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(If(isVisueleControle, sqlVisueel, sqlPoeder), connection)
                        Using commandGewicht As New SqlCommand(sqlGewicht, connection)

                            For Each row As TDSBrandweerMateriaalControleLijst.ControleLijstRow In controleLijst.ControleLijst
                                With command.Parameters
                                    .Clear()
                                    .Add("@type", SqlDbType.Int).Value = row.TypeMatID
                                    .Add("@volgnr", SqlDbType.Int).Value = row.MateriaalVolgNr
                                    .Add("@datum", SqlDbType.DateTime).Value = nieuweDatum
                                End With

                                command.ExecuteNonQuery()

                                If Not row.IsNieuwGewichtNull() Then
                                    With commandGewicht.Parameters
                                        .Clear()
                                        .Add("@type", SqlDbType.Int).Value = row.TypeMatID
                                        .Add("@volgnr", SqlDbType.Int).Value = row.MateriaalVolgNr
                                        .Add("@datum", SqlDbType.DateTime).Value = nieuweDatum
                                        .Add("@gewicht", SqlDbType.Float).Value = row.NieuwGewicht ' CDbl(Replace(row.NieuwGewicht.ToString, ",", "."))
                                    End With

                                    commandGewicht.ExecuteNonQuery()
                                End If
                            Next

                            Return True
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                'Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - SaveMateriaalControleLijst")
                'Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw
            End Try
        End Function

#End Region

    End Class

End Namespace