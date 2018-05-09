Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Reflection
Imports ADF.ExceptionHandling


Namespace DMC

    Public NotInheritable Class GetVerzendingBBW

#Region "Brandweermateriaal - Verzending"

        ''' <summary>
        ''' Get the overview of material that has been shipped to the supplier.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetVerzendingLijst(ByVal dbConnection As String) As TDSBrandweerVerzendingLijst

            Const sql As String =
                "SELECT " &
                "v.VerzendingId			""Id"", " &
                "t.TypeMatOmschr		""TypeMateriaal"", " &
                "s.SoortTypeMatOmschr	""SoortMateriaal"", " &
                "a.AfdelingNaam			""Afdeling"", " &
                "c.LocatieZone			""Zone"", " &
                "m.LocatieNr			""Nr"", " &
                "m.MateriaalVolgNr		""Volgnr"", " &
                "v.DatumVerstuurd		""Verstuurd"", " &
                "v.DatumTerug			""Terug"", " &
                "v.HerkeurdYN			""Herkeurd"", " &
                "m.FabricatieNr			""FabricatieNr"", " &
                "l.NaamLeverancier		""Leverancier"", " &
                "v.Opmerking			""Opmerking"" " &
                "FROM	    dbo.bmVerzending v " &
                "INNER JOIN	dbo.bmMateriaal m			ON m.TypeMatID = v.TypeMatId AND m.MateriaalVolgNr = v.MateriaalVolgNr " &
                "LEFT JOIN	dbo.bmTypeMateriaal t		ON t.TypeMatID = m.TypeMatId " &
                "LEFT JOIN	dbo.bmSoortTypeMateriaal s	ON s.SoortTypeMatID = m.SoortTypeMatId " &
                "LEFT JOIN	dbo.bmLocatie c				ON c.LocatieID = m.LocatieID " &
                "LEFT JOIN	dbo.bmAfdeling a			ON a.AfdelingID = c.AfdelingID " &
                "LEFT JOIN	dbo.bmLeverancier l			ON l.LeverancierID = v.LeverancierID "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        Dim dsResult As New TDSBrandweerVerzendingLijst

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Verzending")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVerzendingLijst")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get a shipping record.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="id">The ID of the shipping record.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetVerzending(ByVal dbConnection As String, ByVal id As Integer) As TDSBrandweerVerzending
            Const sql As String =
                "SELECT VerzendingId, TypeMatID, MateriaalVolgNr, LeverancierID, DatumVerstuurd, DatumTerug, HerkeurdYN, Opmerking " &
                "FROM	dbo.bmVerzending " &
                "WHERE  VerzendingId = @id"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id

                        Dim dsResult As New TDSBrandweerVerzending

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "Verzending")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetVerzending")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Store the 'sent' information for a piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="verzending"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function StoreVerzending(ByVal dbConnection As String, ByVal verzending As TDSBrandweerVerzending) As Boolean

            Const sql As String =
                "IF @VerzendingID > 0 " &
                "  UPDATE dbo.bmVerzending " &
                "  SET TypeMatID = @TypeMatID, " &
                "  MateriaalVolgNr = @MateriaalVolgNr, " &
                "  LeverancierID = @LeverancierID, " &
                "  DatumVerstuurd = @DatumVerstuurd, " &
                "  DatumTerug = @DatumTerug, " &
                "  HerkeurdYN = @HerkeurdYN, " &
                "  Opmerking = @Opmerking " &
                "  WHERE VerzendingID = @VerzendingID " &
                "ELSE " &
                "  INSERT INTO dbo.bmVerzending (TypeMatID, MateriaalVolgNr, LeverancierID, DatumVerstuurd, DatumTerug, HerkeurdYN, Opmerking) " &
                "  VALUES (@TypeMatID, @MateriaalVolgNr, @LeverancierID, @DatumVerstuurd, @DatumTerug, @HerkeurdYN, @Opmerking) "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        For Each row As TDSBrandweerVerzending.VerzendingRow In verzending.Verzending.Rows
                            '1ste actie: 
                            With command.Parameters
                                .Clear()
                                .Add("@VerzendingID", SqlDbType.Int).Value = row.VerzendingID
                                .Add("@TypeMatID", SqlDbType.Int).Value = row.TypeMatID
                                .Add("@MateriaalVolgNr", SqlDbType.Int).Value = row.MateriaalVolgNr
                                .Add("@LeverancierID", SqlDbType.Int).Value = row.LeverancierID
                                .Add("@DatumVerstuurd", SqlDbType.DateTime).Value = row.DatumVerstuurd
                                .Add("@DatumTerug", SqlDbType.DateTime).Value = If(row.IsDatumTerugNull(), DBNull.Value, DirectCast(row.DatumTerug, Object))
                                .Add("@HerkeurdYN", SqlDbType.Bit).Value = If(row.IsHerkeurdYNNull(), 0, If(row.HerkeurdYN, 1, 0))
                                .Add("@Opmerking", SqlDbType.NText).Value = If(row.IsOpmerkingNull(), DBNull.Value, DirectCast(row.Opmerking, Object))
                            End With

                            command.ExecuteNonQuery()

                            '2de actie: record bewaren in bmMateriaalActie (02/05/2017 - naco)
                            If row.IsDatumTerugNull() Then
                                GetDataBbw.StoreMateriaalActie(dbConnection, row.TypeMatID, row.MateriaalVolgNr, row.DatumVerstuurd, 3, 0)
                                'ActieCodeID 3 = Verzenden
                            Else
                                GetDataBbw.StoreMateriaalActie(dbConnection, row.TypeMatID, row.MateriaalVolgNr, row.DatumTerug, 6, 0)
                                'ActieCodeID 6 = Terug van leverancier
                            End If

                        Next

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - StoreVerzending")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Delete the 'sent' information for a list of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="verzending"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DeleteVerzending(ByVal dbConnection As String, ByVal verzending As TDSBrandweerVerzending) As Boolean

            Const sql As String =
                "DELETE FROM dbo.bmVerzending WHERE VerzendingID = @id "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        For Each row As TDSBrandweerVerzending.VerzendingRow In verzending.Verzending.Rows
                            With command.Parameters
                                .Clear()
                                .Add("@id", SqlDbType.Int).Value = row.VerzendingID
                            End With

                            command.ExecuteNonQuery()
                        Next

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DeleteVerzending")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

#End Region

    End Class

End Namespace
