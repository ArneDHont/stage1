Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Reflection
Imports ADF.ExceptionHandling
Imports System.IO


Namespace DMC

    Public Class GetDienstverslag

        ''' <summary>
        ''' Get the list of months with 'dienstverslagen'.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns>The list of available months.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetMonths(ByVal dbConnection As String) As TDSDienstverslagMaanden

            Const sql As String =
                "SELECT year(v.datum) as ""Jaar"", month(v.datum) as ""Maand"" FROM dbo.bvDagverslag v " &
                "WHERE EXISTS(SELECT * FROM dbo.bbbwpers g WHERE g.id_plg_ind = v.ploegId AND g.brdw = 1) " &
                "UNION " &
                "SELECT year(GetDate()), month(GetDate())"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Maanden")

                            Dim dsResult As New TDSDienstverslagMaanden
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetMonths")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of 'dienstverslagen' for a given month.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="jaar">The year for the selection.</param>
        ''' <param name="maand">The month for the selection.</param>
        ''' <returns>The overview of the 'dienstverslagen'.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetLijst(ByVal dbConnection As String, ByVal jaar As Integer, ByVal maand As Integer) As TDSDienstverslagLijst

            Const sql As String =
                "SELECT v.Datum, p.id_plg_ind as ""PloegId"", p.scf_plg_ind as ""Ploeg"", rtrim(i.nm_ind) + ', ' + rtrim(i.vnm_ind) as ""Verantwoordelijke"", v.Opmerkingen " &
                "FROM dbo.bvDagverslag v " &
                "INNER JOIN dbo.bbbwplg p ON p.id_plg_ind = v.ploegId " &
                "INNER JOIN dbo.bbind i ON i.id_ind = v.ploegoversteId " &
                "WHERE year(v.datum) = @jaar AND month(v.datum) = @maand " &
                "AND EXISTS( SELECT * FROM dbo.bbbwpers g WHERE g.id_plg_ind = p.id_plg_ind AND g.brdw = 1 )"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add(New SqlParameter("@jaar", SqlDbType.Int)).Value = jaar
                            .Add(New SqlParameter("@maand", SqlDbType.Int)).Value = maand
                        End With

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Dienstverslag")

                            Dim dsResult As New TDSDienstverslagLijst
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetLijst")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of the fire brigade teams.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns>The list of available months.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetTeams(ByVal dbConnection As String) As TDSDienstVerslagDetailTeams

            Const sql As String =
                "SELECT DISTINCT g.id_plg_ind AS ""Id"", g.scf_plg_ind AS ""Naam"" " &
                "FROM dbo.bbbwplg g " &
                "INNER JOIN dbo.bbbwpers p ON p.id_plg_ind = g.id_plg_ind " &
                "WHERE p.brdw = 1"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Teams")

                            Dim dsResult As New TDSDienstVerslagDetailTeams
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetTeams")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of the members of a fire brigade teams.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="ploegId">The ID of the team. (Use -1 to get the members of all teams.)</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetTeamMembers(ByVal dbConnection As String, ByVal ploegId As Integer) As TDSDienstVerslagDetailTeamMembers

            Const sql As String =
                "SELECT g.SCF_PLG_IND, i.ID_IND, i.NM_IND, i.VNM_IND " &
                "FROM BBBWPLG g " &
                "INNER JOIN BBBWPERS p ON g.ID_PLG_IND = p.ID_PLG_IND " &
                "INNER JOIN BBIND i ON p.ID_IND = i.ID_IND " &
                "WHERE p.BRDW = 1 " &
                "AND (g.ID_PLG_IND = @ploeg OR @ploeg = -1)"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@ploeg", SqlDbType.Int).Value = ploegId

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "TeamMembers")

                            Dim dsResult As New TDSDienstVerslagDetailTeamMembers
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetTeamMembers")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of possible superiors for the fire brigade teams.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns>The list of available months.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetSuperiors(ByVal dbConnection As String) As TDSDienstVerslagDetailOversten

            Const sql As String =
                "SELECT i.ID_IND AS ""Id"", rtrim(i.NM_IND) + ', ' + rtrim(i.VNM_IND) AS ""Naam"" " &
                "FROM dbo.BBBWPLG g " &
                "INNER JOIN dbo.BBBWPERS p ON p.ID_PLG_IND = g.ID_PLG_IND " &
                "INNER JOIN dbo.BBIND i    ON i.ID_IND = p.ID_IND " &
                "WHERE p.BRDW = 1 " &
                "ORDER BY 2"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Oversten")

                            Dim dsResult As New TDSDienstVerslagDetailOversten
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetSuperiors")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of departments for the fire brigade teams.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns>The list of available months.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetDepartments(ByVal dbConnection As String) As TDSDienstverslagAfdelingen

            Const sql As String = "SELECT AfdelingID, AfdelingCode, AfdelingNaam FROM dbo.bmAfdeling WHERE AfdelingNaam != '' ORDER BY AfdelingNaam"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Afdeling")

                            Dim dsResult As New TDSDienstverslagAfdelingen
                            queryAdapter.Fill(dsResult)
                            Return dsResult
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetDepartments")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of possible actions for the fire brigade teams.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns>The list of available actions.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetActions(ByVal dbConnection As String) As TDSDienstverslagDetailActies

            Const sqlGroep As String =
                "SELECT ActieCodeGroepId, ActieCodeGroepOmschr " &
                "FROM dbo.bvActieGroep " &
                "WHERE ActieCodeGroepId < 11 "
            ' "WHERE brdw = 1 "

            Const sqlActie As String =
                "SELECT g.ActieCodeGroepId, a.ActieCodeId, a.ActieOmschr " &
                "FROM dbo.bvActie a " &
                "INNER JOIN dbo.bvActieGroep g ON g.ActieCodeGroepId = a.ActieCodeGroepId " &
                "WHERE g.ActieCodeGroepId < 11 and a.InDagVerslagYN = 1 "
            ' "WHERE g.brdw = 1 and a.InDagVerslagYN = 1 "

            Try
                Dim dsResult As New TDSDienstverslagDetailActies

                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sqlGroep, connection)
                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Actiegroepen")
                            queryAdapter.Fill(dsResult)
                        End Using
                    End Using

                    Using command As New SqlCommand(sqlActie, connection)
                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Acties")
                            queryAdapter.Fill(dsResult)
                        End Using
                    End Using

                End Using

                Return dsResult

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetActions")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the details for a 'dienstverslag'.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="datum">The date of the report.</param>
        ''' <param name="ploegId">The ID of the team for the report.</param>
        ''' <returns>The 'dienstverslag'.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagGetDetail(ByVal dbConnection As String, ByVal datum As DateTime, ByVal ploegId As Integer) As TDSDienstVerslagDetail

            Const sqlHeader As String = "SELECT * FROM dbo.bvDagverslag WHERE Datum = @datum AND PloegId = @ploegId"

            Const sqlDetail As String = "SELECT * FROM dbo.bvDagVerslagActie WHERE DagVerslagId = @verslagId"

            Const sqlWerknemers As String =
                "SELECT id_ind AS ""WerknemerId"", rtrim(vnm_ind) + ' ' + rtrim(nm_ind) AS ""WerknemerNaam"" " &
                "FROM dbo.bbind " &
                "WHERE id_ind IN (SELECT WerknemerId FROM dbo.bvDagVerslagActie WHERE DagVerslagId = @verslagId) " &
                "AND (dt_uit_dns > GetDate() OR dt_uit_dns IS NULL)"

            Try
                Dim dsResult As New TDSDienstVerslagDetail

                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    ' Read the Header
                    ' ---------------
                    Using command As New SqlCommand(sqlHeader, connection)
                        With command.Parameters
                            .Add(New SqlParameter("@datum", SqlDbType.DateTime)).Value = datum
                            .Add(New SqlParameter("@ploegId", SqlDbType.Int)).Value = ploegId
                        End With

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Header")
                            queryAdapter.Fill(dsResult)
                        End Using
                    End Using

                    If dsResult.Header.Rows.Count > 0 Then
                        Debug.Assert(dsResult.Header.Rows.Count = 1)
                        Dim verslagId As Integer = DirectCast(dsResult.Header.Rows(0), TDSDienstVerslagDetail.HeaderRow).DagVerslagID

                        ' Read the Detail Entries
                        ' -----------------------
                        Using command As New SqlCommand(sqlDetail, connection)
                            command.Parameters.Add(New SqlParameter("@verslagId", SqlDbType.Int)).Value = verslagId

                            Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                                queryAdapter.TableMappings.Add("Table", "Detail")
                                queryAdapter.Fill(dsResult)
                            End Using
                        End Using

                        ' Read the List of Employees
                        ' --------------------------
                        Using command As New SqlCommand(sqlWerknemers, connection)
                            command.Parameters.Add(New SqlParameter("@verslagId", SqlDbType.Int)).Value = verslagId

                            Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                                queryAdapter.TableMappings.Add("Table", "Werknemer")
                                queryAdapter.Fill(dsResult)
                            End Using
                        End Using
                    End If

                    Return dsResult
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagGetDienstVerslag")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Save the details of a 'dienstverslag'.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="detail">A typed dataset with all details on the 'dienstverslag'.</param>
        ''' <returns>True if the data was successfully saved.</returns>
        ''' <remarks></remarks>
        Public Shared Function DienstVerslagSave(ByVal dbConnection As String, ByVal detail As TDSDienstVerslagDetail) As Boolean

            Const sqlDeleteHeader = "DELETE FROM dbo.bvDagverslag WHERE Datum = @datum AND PloegId = @ploegId"

            Const sqlDeleteDetail = "DELETE FROM dbo.bvDagVerslagActie " &
                "WHERE DagVerslagId = (SELECT DagVerslagId FROM dbo.bvDagverslag WHERE Datum = @datum AND PloegId = @ploegId)"

            Const sqlInsertHeader = "INSERT INTO dbo.bvDagVerslag (Datum, PloegOversteID, PloegID, Opmerkingen) " &
                "VALUES (@datum, @overste, @ploegId, @opmerkingen); " &
                "SELECT @@identity"

            Const sqlInsertDetail = "INSERT INTO dbo.bvDagVerslagActie (DagVerslagID, WerknemerID, ActieCodeID, AantalUur, AantalMinuten, OpleidingAfdelingID, OpleidingAantalPersonen) " &
                "VALUES (@verslagId, @werknemer, @actieId, @uren, @minuten, @afdeling, @personen)"

            Try
                Dim header = detail.Header
                Dim acties = detail.Detail

                If header.Rows.Count = 0 Then Throw New InvalidDataException("No data available to save")
                If header.Rows.Count > 1 Then Throw New InvalidDataException("Saving more than 1 'dienstverslag' in a single call is not (yet) supported")

                Dim headerRow = DirectCast(header.Rows(0), TDSDienstVerslagDetail.HeaderRow)

                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Dim transaction = connection.BeginTransaction()
                    Try

                        ' Cleanup of any old information
                        ' ------------------------------
                        Using command As New SqlCommand(sqlDeleteDetail, connection, transaction)
                            With command.Parameters
                                .Add("@datum", SqlDbType.DateTime).Value = headerRow.Datum
                                .Add("@ploegId", SqlDbType.Int).Value = headerRow.PloegID
                            End With
                            command.ExecuteNonQuery()
                        End Using

                        Using command As New SqlCommand(sqlDeleteHeader, connection, transaction)
                            With command.Parameters
                                .Add("@datum", SqlDbType.DateTime).Value = headerRow.Datum
                                .Add("@ploegId", SqlDbType.Int).Value = headerRow.PloegID
                            End With
                            command.ExecuteNonQuery()
                        End Using

                        ' No new detail = deleting the entry
                        ' ----------------------------------
                        If acties.Rows.Count = 0 Then Return True

                        ' Store the new header information
                        ' --------------------------------
                        Dim dagverslagId As Integer
                        Using command As New SqlCommand(sqlInsertHeader, connection, transaction)
                            With command.Parameters
                                .Add("@datum", SqlDbType.DateTime).Value = headerRow.Datum
                                .Add("@overste", SqlDbType.Int).Value = headerRow.PloegoversteID
                                .Add("@ploegId", SqlDbType.Int).Value = headerRow.PloegID
                                .Add("@opmerkingen", SqlDbType.NText).Value = headerRow.Opmerkingen
                            End With
                            dagverslagId = CInt(command.ExecuteScalar())
                        End Using

                        ' Store the new detail information
                        ' --------------------------------
                        Using command As New SqlCommand(sqlInsertDetail, connection, transaction)
                            For Each row As TDSDienstVerslagDetail.DetailRow In acties.Rows
                                With command.Parameters
                                    .Clear()
                                    .Add("@verslagId", SqlDbType.Int).Value = dagverslagId
                                    .Add("@werknemer", SqlDbType.Int).Value = row.WerknemerID
                                    .Add("@actieId", SqlDbType.Int).Value = row.ActieCodeID
                                    .Add("@uren", SqlDbType.Int).Value = row.AantalUur
                                    .Add("@minuten", SqlDbType.Int).Value = row.AantalMinuten
                                    .Add("@afdeling", SqlDbType.Int).Value = If(row.IsOpleidingAfdelingIDNull(), DBNull.Value, CObj(row.OpleidingAfdelingID))
                                    .Add("@personen", SqlDbType.SmallInt).Value = If(row.IsOpleidingAantalPersonenNull(), DBNull.Value, CObj(row.OpleidingAantalPersonen))
                                End With
                                command.ExecuteNonQuery()
                            Next
                        End Using

                        ' We're through!
                        ' --------------
                        transaction.Commit()

                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using

                Return True

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DienstVerslagSave")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

    End Class

End Namespace
