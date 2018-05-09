Option Explicit On
Option Infer On
Option Strict On

Imports System.Windows.Forms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers

Namespace Forms.Bewaking

    Public Class FormBewakingSnelheidPrintExt

        Private Const MsgTitle As String = "Brief Snelheidsovertreding"
        Private Const MsgNotFound As String = "De registratie werd niet teruggevonden. Er kan geen brief afgedrukt worden."
        Private Const MsgNoAddress As String = "Kies eerst een firma om de brief naartoe te sturen!"

        Private _proxy As Proxy.BBWServiceManagementServicesProxy

        Private Property IdFirma As Integer

        ''' <summary>
        ''' De ID van de registratie.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property RegistratieId As Integer

        ''' <summary>
        ''' Initiële opmaak van het scherm.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBewakingSnelheidPrintExtLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            _proxy = New Proxy.BBWServiceManagementServicesProxy

            ' Haal de info op
            ' ---------------
            Dim ds = _proxy.GetBriefSnelheidsovertredingInfo(RegistratieId)
            If ds Is Nothing OrElse ds.Info.Rows.Count < 1 Then
                MessageBox.Show(Me, MsgNotFound, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim info = ds.Info(0)

            ' Default taal = Nederlands
            ' -------------------------
            Select Case If(info.IsTaalNull(), "", info.Taal)
                Case "NL"
                    RadioButtonNL.Checked = True
                Case "FR"
                    RadioButtonFR.Checked = True
                Case "EN"
                    RadioButtonEN.Checked = True
                Case "DE"
                    RadioButtonDE.Checked = True
                Case Else
                    RadioButtonNL.Checked = True
            End Select

            ' Recidivebepaling
            ' ----------------
            Select Case info.Aantal
                Case 0, 1
                    RadioButtonInbr1.Checked = True
                Case 2
                    RadioButtonInbr2.Checked = True
                Case Else
                    RadioButtonInbr3.Checked = True
            End Select

            ' Vaststelling
            ' ------------
            TextBoxDriverName.Text = If(info.IsDriverNameNull(), "", info.DriverName)
            TextBoxNrPlate.Text = If(info.IsLicensePlateNull(), "", info.LicensePlate)
            TextBoxVoertuig.Text = If(info.IsVehiculeTypeNull(), "", info.VehiculeType)
            TextBoxSnelheid.Text = If(info.IsMeasuredSpeedNull(), "", info.MeasuredSpeed.ToString())
            TextBoxMaxSnelheid.Text = If(info.IsMaximumSpeedNull(), "", info.MaximumSpeed.ToString())

            ' Externe Firma
            ' -------------
            IdFirma = If(info.IsIdFirmaNull(), 0, info.IdFirma)
            TextBoxFirmName.Text = If(info.IsNaamFirmaNull(), "", info.NaamFirma)
            TextBoxAddress.Text = If(info.IsAdresFirmaNull(), "", info.AdresFirma)
            TextBoxCity.Text = If(info.IsPostNrFirmaNull(), "", info.PostNrFirma + " ") + If(info.IsPlaatsFirmaNull(), "", info.PlaatsFirma)

            ' Disable the OK Button
            ' ---------------------
            ButtonOK.Enabled = (0 <> IdFirma)
        End Sub

        ''' <summary>
        ''' Zoek de gegevens van een externe firma op.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonZoekFirmaClick(sender As Object, e As EventArgs) Handles ButtonZoekFirma.Click

            Using f = New FormBewakingFirmas
                f.ShowDialog(Me)

                If f.DialogResult = DialogResult.OK Then
                    IdFirma = f.IdFirma
                    TextBoxFirmName.Text = f.NaamFirma
                    TextBoxAddress.Text = f.AdresFirma
                    TextBoxCity.Text = f.PostNrFirma & " " & f.GemeenteFirma
                    ButtonOK.Enabled = True
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Druk een brief af.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonOkClick(sender As Object, e As EventArgs) Handles ButtonOK.Click

            ' Controleer of er een adres ingevuld is
            ' --------------------------------------
            If IdFirma = 0 Then
                MessageBox.Show(Me, MsgNoAddress, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End If

            ' Interpreteer de selectie
            ' ------------------------
            Dim datumAfdruk = DateTime.Now
            Dim taal = GeselecteerdeTaal()
            Dim recidive = GeselecteerdeRecidive()

            ' Sla de gegevens op in de database
            ' ---------------------------------
            Using New WaitCursor(Me)
                _proxy.BewaarSnelheidsOvertredingBrief(RegistratieId, datumAfdruk, taal, recidive, IdFirma)
            End Using

            ' Druk een brief af via reporting services
            ' ----------------------------------------
            Using frm = New FormRapportSnelheidPrintExt
                frm.RegistrationID = RegistratieId
                frm.ShowDialog()
            End Using

            ' That's all, Folks!
            ' ------------------
            DialogResult = DialogResult.OK
            Close()
        End Sub

        ''' <summary>
        ''' Sluit dit scherm af zonder verdere actie.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonCancelClick(sender As Object, e As EventArgs) Handles ButtonCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Bepaal de taal die door de gebruiker gekozen werd.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GeselecteerdeTaal() As String
            If RadioButtonNL.Checked Then Return "NL"
            If RadioButtonFR.Checked Then Return "FR"
            If RadioButtonEN.Checked Then Return "EN"
            Return "DE"
        End Function

        ''' <summary>
        ''' Bepaal de recidive die door de gebruiker gekozen werd.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GeselecteerdeRecidive() As Integer
            If RadioButtonInbr1.Checked Then Return 1
            If RadioButtonInbr2.Checked Then Return 2
            Return 3
        End Function

    End Class

End Namespace