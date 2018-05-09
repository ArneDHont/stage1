Option Explicit On
Option Strict On

Imports System.Data.SqlClient
Imports System.Reflection
Imports ADF.ExceptionHandling


Namespace DMC

    Public NotInheritable Class GetAfdelingBBW

        ''' <summary>
        ''' Get the material for a given department.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="afdeling">Department ID.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetAfdelingMateriaal(ByVal dbConnection As String, _
                                                    ByVal afdelingID1 As Integer, ByVal afdelingID2 As Integer, ByVal afdelingID3 As Integer) As TDSBrandweerAfdelingMateriaal
            'afdelingID2 en afdeling3 zullen meestal 0 zijn

            Const sql As String =
                "SELECT	m.TypeMatID, " &
                "		t.TypeMatOmschr, " &
                "		m.MateriaalVolgNr, " &
                "		s.SoortTypeMatOmschr, " &
                "		a.AfdelingCode, " &
                "		l.LocatieZone, " &
                "		m.LocatieOmschr, " &
                "		m.LocatieNr, " &
                "		b.BeheerderAfdelingNaam,  " &
                "       m.VolgnummerAfdeling " &
                "FROM		dbo.bmMateriaal m " &
                "INNER JOIN	dbo.bmTypeMateriaal t ON t.TypeMatID = m.TypeMatID " &
                "LEFT JOIN	dbo.bmSoortTypeMateriaal s ON s.SoortTypeMatID = m.SoortTypeMatID " &
                "INNER JOIN	dbo.bmLocatie l ON l.LocatieID = m.LocatieID " &
                "INNER JOIN	dbo.bmAfdeling a ON a.AfdelingID = l.AfdelingID " &
                "LEFT JOIN	dbo.bmAfdelingBeheerder b ON b.BeheerderAfdelingID = m.BeheerderAfdelingID " &
                "WHERE a.AfdelingID IN (@afdeling1, @afdeling2, @afdeling3) " &
                "AND m.DateDeleted IS NULL " &
                "ORDER BY CASE " &
                "   WHEN ISNUMERIC(replace(LocatieNr, '.', '_')) = 1 THEN CONVERT(int, LocatieNr) " &
                "   ELSE 9999999 " &
                "   END " &
                "   , 	LocatieNr"
            'naco - 23/12/2016 - numeriek sorteren op volgnummer

            'LEFT join = noodzakelijk om ook de toestellen <> blustoestellen te kunnen tonen
            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@afdeling1", SqlDbType.Int).Value = afdelingID1
                        command.Parameters.Add("@afdeling2", SqlDbType.Int).Value = afdelingID2
                        command.Parameters.Add("@afdeling3", SqlDbType.Int).Value = afdelingID3

                        Dim dsResult As New TDSBrandweerAfdelingMateriaal

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "AfdelingMateriaal")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAfdelingMateriaal")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
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
        Public Shared Function GetMateriaalBeheerderAfdeling(ByVal dbConnection As String, ByVal typeMatId As Integer, ByVal volgnr As Integer) As BS.TDSBrandweerMateriaalBeheerderAfdeling

            Const sql As String =
                "SELECT	m.TypeMatID, " &
                "		m.MateriaalVolgNr, " &
                "		a.AfdelingID, " &
                "		a.AfdelingNaam, " &
                "		l.LocatieZone, " &
                "		m.BeheerderAfdelingID " &
                "FROM		dbo.bmMateriaal m " &
                "INNER JOIN	dbo.bmLocatie l ON l.LocatieID = m.LocatieID " &
                "INNER JOIN	dbo.bmAfdeling a ON a.AfdelingID = l.AfdelingID " &
                "WHERE  m.TypeMatID = @typeId AND m.MateriaalVolgNr = @volgNr"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@typeId", SqlDbType.Int).Value = typeMatId
                            .Add("@volgNr", SqlDbType.Int).Value = volgnr
                        End With

                        Dim dsResult As New TDSBrandweerMateriaalBeheerderAfdeling

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BeheerderAfdeling")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetMateriaalBeheerderAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Update the departemental manager for a given piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="info"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function UpdateMateriaalBeheerderAfdeling(ByVal dbConnection As String, ByVal info As BS.TDSBrandweerMateriaalBeheerderAfdeling) As Boolean

            Const sql As String =
                "UPDATE dbo.bmMateriaal " &
                "SET BeheerderAfdelingID = @id " &
                "WHERE TypeMatID = @typeMatId AND MateriaalVolgNr = @volgNr "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)

                        For Each row As TDSBrandweerMateriaalBeheerderAfdeling.BeheerderAfdelingRow In info.BeheerderAfdeling.Rows
                            With command.Parameters
                                .Clear()
                                .Add("@id", SqlDbType.Int).Value = row.BeheerderAfdelingID
                                .Add("@typeMatID", SqlDbType.Int).Value = row.TypeMatID
                                .Add("@volgNr", SqlDbType.Int).Value = row.MateriaalVolgNr
                            End With

                            command.ExecuteNonQuery()
                        Next

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - UpdateMateriaalBeheerderAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Update the department serial number for a given piece of material.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <returns></returns>
        ''' <remarks>naco - 10/07/2017</remarks>
        Public Shared Function UpdateMateriaalAfdelingVolgnr(ByVal dbConnection As String, _
                                                             ByVal aTypeMatId As Integer, _
                                                             ByVal aMatVolgnr As Integer, _
                                                             ByVal aVolgnummerAfdeling As Integer) As Boolean

            Const sql As String =
                "UPDATE dbo.bmMateriaal " &
                "SET VolgnummerAfdeling = @id " &
                "WHERE TypeMatID = @typeMatId AND MateriaalVolgNr = @volgNr "

            Const sql2 As String =
                "UPDATE dbo.bmMateriaal " &
                "SET VolgnummerAfdeling = null " &
                "WHERE TypeMatID = @typeMatId AND MateriaalVolgNr = @volgNr "

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    If aVolgnummerAfdeling = 0 Then
                        Using command As New SqlCommand(sql2, connection)
                            With command.Parameters
                                .Clear()
                                .Add("@typeMatID", SqlDbType.Int).Value = aTypeMatId
                                .Add("@volgNr", SqlDbType.Int).Value = aMatVolgnr
                            End With

                            command.ExecuteNonQuery()

                            Return True
                        End Using
                    Else
                        Using command As New SqlCommand(sql, connection)
                            With command.Parameters
                                .Clear()
                                .Add("@id", SqlDbType.Int).Value = aVolgnummerAfdeling
                                .Add("@typeMatID", SqlDbType.Int).Value = aTypeMatId
                                .Add("@volgNr", SqlDbType.Int).Value = aMatVolgnr
                            End With

                            command.ExecuteNonQuery()

                            Return True
                        End Using
                    End If

                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - UpdateMateriaalAfdelingVolgnr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the list of managers for a given departement.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="afdeling">ID of the departement.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetBeheerderAfdeling(ByVal dbConnection As String, ByVal afdeling As Integer, ByVal aAfdeling2 As Integer, ByVal aAfdeling3 As Integer) As TDSBrandweerBeheerderAfdeling

            Const sql As String =
                "SELECT	BeheerderAfdelingID, BeheerderAfdelingNaam, AfdelingID " &
                "FROM dbo.bmAfdelingBeheerder " &
                "WHERE AfdelingID IN (@afdeling, @afd2, @afd3) " &
                "ORDER BY BeheerderAfdelingNaam"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@afdeling", SqlDbType.Int).Value = afdeling
                        command.Parameters.Add("@afd2", SqlDbType.Int).Value = aAfdeling2
                        command.Parameters.Add("@afd3", SqlDbType.Int).Value = aAfdeling3


                        Dim dsResult As New TDSBrandweerBeheerderAfdeling

                        Using queryAdapter As SqlDataAdapter = New SqlDataAdapter(command)
                            queryAdapter.TableMappings.Add("Table", "BeheerderAfdeling")
                            queryAdapter.Fill(dsResult)
                        End Using

                        Return dsResult
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetBeheerderAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
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
        Public Shared Function AddBeheerderAfdeling(ByVal dbConnection As String, ByVal afdeling As Integer, ByVal naam As String) As Boolean

            Const sql As String = "INSERT INTO dbo.bmAfdelingBeheerder (BeheerderAfdelingNaam, AfdelingID) VALUES (@naam, @afdeling)"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        With command.Parameters
                            .Add("@naam", SqlDbType.NVarChar, 80).Value = naam
                            .Add("@afdeling", SqlDbType.Int).Value = afdeling
                        End With

                        command.ExecuteNonQuery()

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - AddBeheerderAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Delete a departemental manager with a gived ID.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="id">ID of the departemental manager.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DeleteBeheerderAfdeling(ByVal dbConnection As String, ByVal id As Integer) As Boolean

            Const sqlTest As String = "SELECT count(*) FROM dbo.bmMateriaal WHERE BeheerderAfdelingID = @id"

            Const sql As String = "DELETE FROM dbo.bmAfdelingBeheerder WHERE BeheerderAfdelingID = @id"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    'Don't delete if the entry is still being used...
                    Using command As New SqlCommand(sqlTest, connection)
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id

                        If CInt(command.ExecuteScalar()) > 0 Then
                            Return False
                        End If
                    End Using

                    ' Okay, it's safe to remove this manager from the list.
                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id

                        command.ExecuteNonQuery()

                        Return True
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - DeleteBeheerderAfdeling")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Get the departement that a user belongs to.
        ''' </summary>
        ''' <param name="dbConnection">SQL server connection to BBW database.</param>
        ''' <param name="gebruiker">The login ID of the user (e.g. SIDXXXX).</param>
        ''' <returns>The department ID (or -1 if the user cannot be found).</returns>
        ''' <remarks></remarks>
        Public Shared Function GetAfdelingVoorGebruiker(ByVal dbConnection As String, ByVal gebruiker As String) As Integer

            Const sql As String = "SELECT AfdelingID FROM dbo.bmAfdelingUser WHERE LoginNaam = @gebruiker"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@gebruiker", SqlDbType.NVarChar, 16).Value = gebruiker

                        Dim value As Object = command.ExecuteScalar()

                        Return If(value Is Nothing, -1, CInt(value))
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAfdelingVoorGebruiker")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Shared Function GetAfdeling2VoorGebruiker(ByVal dbConnection As String, ByVal gebruiker As String) As Integer
            'naco - 11/01/2017
            Const sql As String = "SELECT AfdelingID2 FROM dbo.bmAfdelingUser WHERE LoginNaam = @gebruiker"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@gebruiker", SqlDbType.NVarChar, 16).Value = gebruiker

                        Dim value As Object = command.ExecuteScalar()

                        Return If(value Is Nothing, -1, CInt(value))
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAfdelingVoorGebruiker")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Shared Function GetAfdeling3VoorGebruiker(ByVal dbConnection As String, ByVal gebruiker As String) As Integer
            'naco - 11/01/2017
            Const sql As String = "SELECT AfdelingID3 FROM dbo.bmAfdelingUser WHERE LoginNaam = @gebruiker"

            Try
                Using connection As New SqlConnection(dbConnection)
                    connection.Open()

                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.Add("@gebruiker", SqlDbType.NVarChar, 16).Value = gebruiker

                        Dim value As Object = command.ExecuteScalar()

                        Return If(value Is Nothing, -1, CInt(value))
                    End Using
                End Using

            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - GetAfdelingVoorGebruiker")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

    End Class

End Namespace
