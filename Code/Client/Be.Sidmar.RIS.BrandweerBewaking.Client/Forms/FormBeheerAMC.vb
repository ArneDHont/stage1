Imports ADF.ExceptionHandling
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormBeheerAMC

    Private _controller As ControllerGetData

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me._controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

        loadTDS()
    End Sub

    Private Sub loadTDS()
        Me._dataIndividuen.Merge(Me._controller.GetIndividuen())
        Me._dataAfdelingen.Merge(Me._controller.GetAfdelingen)
        Me._dataBeheerAFDAMC.Merge(Me._controller.getAFDAMC())
    End Sub


    Private Sub FormBeheerAMC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub UltraDropDownIndividu_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraDropDownIndividu.InitializeRow
        e.Row.Cells("NM_IND_VNM_IND").Value = e.Row.Cells("NM_IND").Value & " " & e.Row.Cells("VNM_IND").Value & " (" & e.Row.Cells("ID_IND").Value & ")"
    End Sub

    Private Sub UltraDropDownIndividu_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles UltraDropDownIndividu.RowSelected
        If Not UltraGridBeheerAMC.ActiveRow Is Nothing Then
            If Not e.Row Is Nothing Then

                UltraGridBeheerAMC.ActiveRow.Cells("MAIL").Value = e.Row.Cells("AD_EMAL_IND").Value
            End If
        End If
    End Sub

    Private Sub btnOpslaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpslaan.Click
        Try

            'Controle
            If Len(Trim(UltraComboAMCNew.Text)) = 0 Then
                MessageBox.Show("Gelieve een AMC aan te duiden aub.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Len(Trim(TextBoxEmailNew.Text)) = 0 Then
                MessageBox.Show("Gelieve een correct email-adres op te geven voor de nieuwe AMC.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            _dataBeheerAFDAMC.BBAFDAMC.AddBBAFDAMCRow(UltraComboAfdelingNew.Value, UltraComboAMCNew.Value, TextBoxEmailNew.Text)

            Dim ds As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC()
            ds.Merge(Me._dataBeheerAFDAMC.GetChanges())

            'save
            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            proxy.saveAMC(ds)

            Me._dataBeheerAFDAMC.AcceptChanges()

            TextBoxEmailNew.Text = ""
            UltraComboAfdelingNew.Text = ""
            UltraComboAMCNew.Text = ""

            MessageBox.Show("Nieuwe AMC succesvol bewaard.", "Nieuwe AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' workaround - this code did only work for new AMC's, not for updates
    ''' </summary>
    ''' <remarks>Nancy Coppens - 22/02/2010</remarks>
    Private Sub OpslaanOldCode()
        Try
            If Me._dataBeheerAFDAMC.HasChanges() = True Then

                'Controle
                For Each row As TDSBeheerAFDAMC.BBAFDAMCRow In Me._dataBeheerAFDAMC.BBAFDAMC
                    If row.IsMAILNull = True Then
                        row.RowError = "Gelieve een correct e-mail adres op te geven."
                    End If
                Next

                If Me._dataBeheerAFDAMC.HasErrors = True Then
                    MessageBox.Show("Ongeldige data (mail)", "Ongeldige data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Dim ds As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC()
                ds.Merge(Me._dataBeheerAFDAMC.GetChanges())

                'save
                Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                proxy.saveAMC(ds)

                Me._dataBeheerAFDAMC.AcceptChanges()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 22/02/2010</remarks>
    Private Sub UltraGridBeheerAMC_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGridBeheerAMC.AfterRowActivate

        TextBoxAfdUpdate.Text = UltraGridBeheerAMC.ActiveRow.Cells("ID_AFD").Text
        UltraComboAMCUpdate.Value = CInt(UltraGridBeheerAMC.ActiveRow.Cells("ID_IND").Value)
        TextBoxEmailUpdate.Text = UltraGridBeheerAMC.ActiveRow.Cells("MAIL").Text

    End Sub

    ''' <summary>
    ''' Workaround, because update didn't work
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 22/02/2010</remarks>
    Private Sub ButtonSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveUpdate.Click

        Try

            'Controle
            If Len(Trim(UltraComboAMCUpdate.Text)) = 0 Then
                MessageBox.Show("Gelieve een AMC aan te duiden aub.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Len(Trim(TextBoxEmailUpdate.Text)) = 0 Then
                MessageBox.Show("Gelieve een correct email-adres op te geven voor de AMC.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
            'updaten van het veld bestemmeling en e-mailadres.
            proxy.updateIndividuBestemmeling(CInt(UltraComboAMCUpdate.Value), _
                                             TextBoxEmailUpdate.Text.Trim, System.Environment.UserName)

            proxy.UpdateAFDAMC(CInt(UltraGridBeheerAMC.ActiveRow.Cells("ID_AFD").Value), _
                               UltraComboAMCUpdate.Value, _
                               CInt(UltraGridBeheerAMC.ActiveRow.Cells("ID_IND").Value))

            Me._dataBeheerAFDAMC.Clear()
            Me._dataBeheerAFDAMC.Merge(Me._controller.getAFDAMC()) 'refresh

            MessageBox.Show("AMC van afdeling " & TextBoxAfdUpdate.Text & " is succesvol bewaard.", "Nieuwe AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraCombo2_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

    End Sub

    Private Sub UltraComboAMCNew_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraComboAMCNew.AfterCloseUp
        TextBoxEmailNew.Text = UltraComboAMCNew.ActiveRow.Cells("AD_EMAL_IND").Text
    End Sub

    Private Sub UltraComboAMCNew_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraComboAMCNew.InitializeLayout

    End Sub

    Private Sub UltraComboAMCUpdate_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraComboAMCUpdate.AfterCloseUp
        TextBoxEmailUpdate.Text = UltraComboAMCUpdate.ActiveRow.Cells("AD_EMAL_IND").Text

    End Sub
End Class