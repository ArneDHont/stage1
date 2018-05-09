Option Strict On
Option Explicit On

Imports ADF.ExceptionHandling
Imports Be.Sidmar.RIS.BrandweerBewaking.BS2.DMC
Imports System.Reflection


Public Class BusinessServiceFacade

    Private Property MyConnection As String

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="dbConnection"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal dbConnection As String)
        MyConnection = dbConnection
    End Sub

#Region "Dienstverslagen"

    ''' <summary>
    ''' Get the list of months with 'dienstverslagen'.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns>The list of available months.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetMonths(ByVal dbConnection As String) As TDSDienstverslagMaanden

        Try
            Dim result As New TDSDienstverslagMaanden
            result.Merge(GetDienstverslag.DienstVerslagGetMonths(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of 'diensterslagen' for a given month.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="jaar">The year for the selection.</param>
    ''' <param name="maand">The month for the selection.</param>
    ''' <returns>The overview of the 'dienstverslagen'.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetLijst(ByVal dbConnection As String, ByVal jaar As Integer, ByVal maand As Integer) As TDSDienstverslagLijst

        Try
            Dim result As New TDSDienstverslagLijst
            result.Merge(GetDienstverslag.DienstVerslagGetLijst(dbConnection, jaar, maand))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of the fire brigade teams.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns>The list of available months.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetTeams(ByVal dbConnection As String) As TDSDienstVerslagDetailTeams

        Try
            Dim result As New TDSDienstVerslagDetailTeams
            result.Merge(GetDienstverslag.DienstVerslagGetTeams(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of the members of a fire brigade teams.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="ploegId">The ID of the team. (Use -1 to get the members of all teams.)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetTeamMembers(ByVal dbConnection As String, ByVal ploegId As Integer) As TDSDienstVerslagDetailTeamMembers

        Try
            Dim result As New TDSDienstVerslagDetailTeamMembers
            result.Merge(GetDienstverslag.DienstVerslagGetTeamMembers(dbConnection, ploegId))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of possible superior for the fire brigade teams.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns>The list of available months.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetSuperiors(ByVal dbConnection As String) As TDSDienstVerslagDetailOversten

        Try
            Dim result As New TDSDienstVerslagDetailOversten
            result.Merge(GetDienstverslag.DienstVerslagGetSuperiors(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of departments for the fire brigade teams.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns>The list of available months.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetDepartments(ByVal dbConnection As String) As TDSDienstverslagAfdelingen

        Try
            Dim result As New TDSDienstverslagAfdelingen
            result.Merge(GetDienstverslag.DienstVerslagGetDepartments(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Get the list of possible actions for the fire brigade teams.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <returns>The list of available actions.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagGetActions(ByVal dbConnection As String) As TDSDienstverslagDetailActies

        Try
            Dim result As New TDSDienstverslagDetailActies
            result.Merge(GetDienstverslag.DienstVerslagGetActions(dbConnection))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
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
    Public Function DienstVerslagGetDetail(ByVal dbConnection As String, ByVal datum As DateTime, ByVal ploegId As Integer) As TDSDienstVerslagDetail

        Try
            Dim result As New TDSDienstVerslagDetail
            result.Merge(GetDienstverslag.DienstVerslagGetDetail(dbConnection, datum, ploegId))
            Return result

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Save the details of a 'dienstverslag'.
    ''' </summary>
    ''' <param name="dbConnection">SQL server connection to BBW database.</param>
    ''' <param name="detail">A typed dataset with all details on the 'dienstverslag'.</param>
    ''' <returns>True if the data was successfully saved.</returns>
    ''' <remarks></remarks>
    Public Function DienstVerslagSave(ByVal dbConnection As String, ByVal detail As TDSDienstVerslagDetail) As Boolean

        Try
            Return GetDienstverslag.DienstVerslagSave(dbConnection, detail)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return False
        End Try
    End Function

#End Region

#Region "Brieven Snelheidsovertredingen"

    ''' <summary>
    ''' Haal de basisinformatie om een brief voor een snelheidsovertreding op te maken.
    ''' </summary>
    ''' <param name="dbConnection"></param>
    ''' <param name="idRegistratie"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetBriefSnelheidsovertredingInfo(ByVal dbConnection As String, ByVal idRegistratie As Integer) As TDSBriefSnelheidsovertredingInfo

        Try
            Return BriefSnelheidsovertreding.GetBriefSnelheidsovertredingInfo(dbConnection, idRegistratie)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            Return Nothing
        End Try
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
    Public Sub BewaarSnelheidsOvertredingBrief(ByVal dbConnection As String,
                                               ByVal idRegistratie As Integer,
                                               ByVal datumAfdruk As DateTime,
                                               ByVal taal As String,
                                               ByVal recidive As Integer,
                                               ByVal idFirm As Integer)

        Try
            BriefSnelheidsovertreding.BewaarSnelheidsOvertredingBrief(dbConnection, idRegistratie, datumAfdruk, taal, recidive, idFirm)

        Catch ex As Exception
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

#End Region

End Class
