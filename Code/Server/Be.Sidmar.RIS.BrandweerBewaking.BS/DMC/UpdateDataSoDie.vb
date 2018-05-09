Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports ADF.ExceptionHandling
Imports System.Reflection

Namespace DMC

    Public Class UpdateDataSoDie

#Region "Properties"
        Private _connectionString As String
        Public Property ConnectionString() As String
            Get
                Return _connectionString
            End Get
            Set(ByVal value As String)
                _connectionString = value
            End Set
        End Property

        Private _accessConnection As OleDbConnection
        Public Property AccessConnection() As OleDbConnection
            Get
                Return _accessConnection
            End Get
            Set(ByVal value As OleDb.OleDbConnection)
                _accessConnection = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Public Sub New(ByVal aConnectionString As String)
            ConnectionString = aConnectionString
            AccessConnection = New OleDbConnection(ConnectionString)
        End Sub
#End Region

        Public Function InsertSoDie(ByVal aStamNr As Integer, ByVal aBbwSanctieOmschr As String, ByVal aSoortId As Integer) As Integer
            Try
                Dim newContactId As Integer = -1

                If (SelectStamNr(aStamNr)) Then
                    If (InsertSoDieContact(aStamNr, aBbwSanctieOmschr)) Then
                        newContactId = SelectInsertSoDieContact(aStamNr)

                        If (newContactId > -1) Then
                            InsertSoDieArbeidsreglementInfo(newContactId, aSoortId)
                        End If

                    End If
                End If
                Return newContactId
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - InsertSoDie")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        ''' <summary>
        ''' Controleren indien meegegeven stamnummer bestaat in de Sodie-Database
        ''' LAWV: 2011
        ''' </summary>
        ''' <param name="aStamNr"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SelectStamNr(ByVal aStamNr As Integer) As Boolean
            Try
                Dim comm As New OleDbCommand()
                Dim bExists As Boolean = False

                comm.Connection = _accessConnection
                comm.CommandType = CommandType.Text

                Dim cmdInstertContact As String = "SELECT StamnummerID FROM WERKNEMER " & _
                                                  "WHERE StamnummerID = @StamNr "

                comm.CommandText = cmdInstertContact
                comm.Parameters.Add("@StamNr", OleDbType.Integer, 4).Value = aStamNr

                comm.Connection.Open()

                Dim reader As OleDbDataReader = comm.ExecuteReader()

                If (reader.Read()) Then
                    bExists = True
                End If

                _accessConnection.Close()

                Return bExists
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - SelectStamNr")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function


        Public Function InsertSoDieContact(ByVal aStamNr As Integer, ByVal aBbwSanctieOmschr As String) As Boolean
            Try
                Dim comm As New OleDbCommand()
                Dim bSuccess As Boolean = False

                comm.Connection = _accessConnection
                comm.CommandType = CommandType.Text

                Dim cmdInstertContact As String = "INSERT INTO CONTACT " & _
                                                  "(StamnummerID, DatumContact, AuteurID, ContactMediumID, VerslagYN, ConfidentieelYN, RubriekID, ContactOMSCH) " & _
                                                  "VALUES (@StamNr, @DatumContact, @AuteurID, @ContactMediumID, @VerslagYN, @ConfidentieelYN, @RubriekID, @ContactOMSCH) "
                comm.CommandText = cmdInstertContact
                comm.Parameters.Add("@StamNr", OleDbType.Integer, 4).Value = aStamNr
                comm.Parameters.Add("@DatumContact", OleDbType.Date, 8).Value = DateTime.Today.Date
                comm.Parameters.Add("@AuteurID", OleDbType.VarChar, 10).Value = "BBW"
                comm.Parameters.Add("@ContactMediumID", OleDbType.Integer, 4).Value = 8
                comm.Parameters.Add("@VerslagYN", OleDbType.Boolean, 2).Value = False
                comm.Parameters.Add("@ConfidentieelYN", OleDbType.Boolean, 2).Value = False
                comm.Parameters.Add("@RubriekID", OleDbType.Integer, 4).Value = 7
                comm.Parameters.Add("@ContactOMSCH", OleDbType.VarChar, 250).Value = "BBW - " & aBbwSanctieOmschr
                comm.Connection.Open()

                If (comm.ExecuteNonQuery() > 0) Then
                    bSuccess = True
                End If
                _accessConnection.Close()

                Return bSuccess
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - InsertSoDieContact")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function SelectInsertSoDieContact(ByVal aStamNr As Integer) As Integer
            Try
                Dim comm As New OleDbCommand()
                Dim iReturn As Integer = -1

                comm.Connection = _accessConnection
                comm.CommandType = CommandType.Text

                Dim cmdInstertContact As String = "SELECT MAX(ContactID) FROM CONTACT " & _
                                                  "WHERE StamnummerID = @StamNr " & _
                                                  "AND RubriekID = 7" & _
                                                  "AND AuteurId = 'BBW'"

                comm.CommandText = cmdInstertContact
                comm.Parameters.Add("@StamNr", OleDbType.Integer, 4).Value = aStamNr

                comm.Connection.Open()

                Dim reader As OleDbDataReader = comm.ExecuteReader()

                If (reader.Read() And Not reader.IsDBNull(0)) Then
                    iReturn = reader.GetInt32(0)
                Else
                    'What if stamNr is not found?
                    Exit Function
                End If

                comm.Connection.Close()

                Return iReturn
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - SelectInsertSoDieContact")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function InsertSoDieArbeidsreglementInfo(ByVal aContactId As Integer,
                                                        ByVal aSoortId As Integer) As Boolean
            Try
                Dim comm As New OleDbCommand()
                Dim bSuccess As Boolean = False

                comm.Connection = _accessConnection
                comm.CommandType = CommandType.Text

                Dim cmdInstertContact As String = "INSERT INTO ARBEIDSREGLEMENTINFO " & _
                                                  "(ContactID,RedenARContactID, ARSoortID) " & _
                                                  "VALUES (@ContactID, @RedenARContactID, @ARSoortID) "
                comm.CommandText = cmdInstertContact
                comm.Parameters.Add("@ContactID", OleDbType.Integer, 4).Value = aContactId
                comm.Parameters.Add("@RedenARContactID", OleDbType.Integer, 4).Value = 1
                'comm.Parameters.Add("@WordPath", OleDbType.VarChar, 80).Value = ""
                comm.Parameters.Add("@ARSoortID", OleDbType.Integer, 4).Value = aSoortId

                comm.Connection.Open()

                If (comm.ExecuteNonQuery() > 0) Then
                    bSuccess = True
                End If
                _accessConnection.Close()

                Return bSuccess
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - InsertSoDieArbeidsreglementInfo")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Public Function UpdateSoDieContactDatum(ByVal aContactID As Integer, ByVal aDatum As DateTime) As Boolean
            Try
                Dim bSuccess As Boolean = False

                If (aContactID > -1) Then

                    Dim updateCmd As String
                    updateCmd = "UPDATE CONTACT SET " & _
                                "DatumContact = @DatumContact " & _
                                "WHERE ContactID = @ContactID"
                    Dim cmdUpdate As New OleDbCommand(updateCmd, AccessConnection)
                    cmdUpdate.Parameters.Add("@DatumContact", OleDbType.Date, 8).Value = aDatum.Date
                    cmdUpdate.Parameters.Add("@ContactID", OleDbType.Integer, 4).Value = aContactID

                    cmdUpdate.Connection.Open()
                    bSuccess = cmdUpdate.ExecuteNonQuery() > 0
                    _accessConnection.Close()
                End If

                Return bSuccess
            Catch ex As Exception
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
                Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - UpdateSoDieContactDatum")
                Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
                Throw exc
            End Try
        End Function

        Function TestSodie() As Boolean
            'Try
            '    Dim comm As New OleDbCommand()
            '    Dim bSuccess As Boolean = False

            '    comm.Connection = _accessConnection
            '    comm.CommandType = CommandType.Text

            '    Dim cmdInstertContact As String = "SELECT * FROM CONTACT"
            '    comm.CommandText = cmdInstertContact

            '    comm.Connection.Open()

            '    If (comm.ExecuteReader().Read()) Then
            '        bSuccess = True
            '    End If
            '    _accessConnection.Close()

            '    Return bSuccess
            'Catch ex As Exception
            '    ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            '    Dim errmsg As New ADF.ExceptionHandling.ErrorMessage("", "Fout op BS - TestSodie")
            '    Dim exc As New ADF.ExceptionHandling.BusinessExceptions.BaseBusinessException(errmsg, ex)
            '    Throw exc
            'End Try
        End Function

    End Class

End Namespace

