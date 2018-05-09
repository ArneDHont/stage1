Option Strict On
Option Infer On
Option Explicit On

Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports ADF
Imports ADF.ExceptionHandling

Public Class UserControlSAPPresence

    'naco juni 2013 - implementing the new webservice
    Private _wsSapPersNew As SappersDataNew.Service_ZHR_BAPI_SAPPERS_P_STANDARD

    Private Const _sapUser As String = "SID#PCOLD"
    Private Const _sapPassword As String = "PCAPPLIC"

    Public Property PersonalNr() As String

    Private _pDate As DateTime
    Public Property Datum() As DateTime
        Get
            Return _pDate
        End Get
        Set(ByVal Value As Date)
            _pDate = Value
            DateTimePickerPresence.Value = If(Value = DateTime.MinValue, Now.Date, Value)
        End Set
    End Property

    ''' <summary>
    ''' Get presence info of SAP for one person.
    ''' </summary>
    ''' <remarks>Nancy Coppens - 01/06/2007</remarks>
    Public Sub ShowPresenceSAP()
        Try
            Me.Cursor = Cursors.WaitCursor

            _wsSapPersNew = New SappersDataNew.Service_ZHR_BAPI_SAPPERS_P_STANDARD
            _wsSapPersNew.Url = ADF.Configuration.ConfigurationSettings.UsedWebServices.Item("SappersDataNew").URL
            _wsSapPersNew.Credentials = New Net.NetworkCredential(_sapUser, _sapPassword)
            _wsSapPersNew.Timeout = 1000 * 60 * 30

            If String.IsNullOrWhiteSpace(PersonalNr.Trim) Then
                MessageBox.Show("Gelieve een stamnummer te selecteren aub.", "Stamnr", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf Not IsNumeric(Me.PersonalNr.Trim) Then
                MessageBox.Show("Voor deze werknemer kan geen aanwezigheidsinfo van SAP getoond worden (speciaal stamnummer).", "Maak afspraak", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Get all presence dates of the employee between begindate and enddate

            '--- nieuwe code 17 juni 2013
            Dim reqSAPpers As New SappersDataNew.ZBapiPresentGetlist
            Dim resp As New SappersDataNew.ZBapiPresentGetlistResponse
            Dim persNo(0) As SappersDataNew.Zpersno

            reqSAPpers.Actief = "X"
            reqSAPpers.Begda = DateTimePickerPresence.Value.ToString("yyyy-MM-dd")
            reqSAPpers.Endda = DateTimePickerPresence.Value.AddDays(14).ToString("yyyy-MM-dd")

            Dim persNo1 As SappersDataNew.Zpersno = New SappersDataNew.Zpersno 'set van stamnummers samenstellen
            persNo1.Pernr = PersonalNr
            persNo(0) = persNo1

            reqSAPpers.Persno = persNo

            resp = _wsSapPersNew.ZBapiPresentGetlist(reqSAPpers)
            '---

            Dim ds As New TDSPresenceEmployee

            Dim drZPresent As TDSPresenceEmployee.ZPRESENTRow
            Dim objSAPaanw As SappersDataNew.Zpresent
            For Each objSAPaanw In resp.Present
                drZPresent = ds.ZPRESENT.NewZPRESENTRow

                drZPresent.PERNR = objSAPaanw.Pernr
                drZPresent.DATUM = Replace(objSAPaanw.Datum, "-", "")
                drZPresent.AWART = objSAPaanw.Awart
                drZPresent.BEGUZ = objSAPaanw.Beguz
                drZPresent.ENDUZ = objSAPaanw.Enduz

                ds.ZPRESENT.AddZPRESENTRow(drZPresent)
            Next

            Me._dataPresenceEmployee.Clear()
            Me._dataPresenceEmployee.Merge(ds.ZPRESENT)

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Mediplan:  " & vbCrLf &
                            "UserControl: UserControlSAPPresence - ShowPresenceSAP" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "MDP Mediplan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Show the date of the datetimepicker in red in the grid.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 04/06/2007</remarks>
    Private Sub UltraGridSAPPresence_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridSAPPresence.InitializeRow
        Try
            If e.Row.Cells("DATUM").Value.ToString <= DateTime.Today.ToString("yyyyMMdd") Then
                e.Row.Appearance.ForeColor = System.Drawing.Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Mediplan:  " & vbCrLf &
                            "UserControl: UserControlSAPPresence - UltraGridSAPPresence_InitializeRow" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "MDP Mediplan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' Clear grid Presence SAP.
    ''' </summary>
    ''' <remarks>Nancy Coppens - 13/06/2007</remarks>
    Public Sub ClearGridPresence()
        Try
            _dataPresenceEmployee.Clear()

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Mediplan:  " & vbCrLf &
                            "UserControl: UserControlSAPPresence - ClearGridPresence" & vbCrLf &
                            "Message: " & ex.Message & vbCrLf &
                            "Stacktrace: " & ex.StackTrace, "MDP Mediplan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' Show of hide the grid, based on the selection.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DateTimePickerPresence_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePickerPresence.ValueChanged
        If String.IsNullOrWhiteSpace(PersonalNr) Then
            ClearGridPresence()
        Else
            ShowPresenceSAP()
        End If
    End Sub

End Class
