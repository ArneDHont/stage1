Option Explicit On
Option Strict On

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Imports Microsoft.Office.Interop 'mails versturen voor IKP - naco - 30/11/2012
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Imports Infragistics.Win
Imports System.Reflection.MethodBase

Public Class FormBewakingInkoop
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 26/11/2012</remarks>
    Private Sub FormBewakingInkoop_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy

            _dataInkoop.Merge(proxy.GetLijstInkoop)


        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingSnelheidsovertreding (Load) " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 26/11/2012</remarks>
    Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click
        Try
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy

            _dataInkoop.Clear()
            _dataInkoop.Merge(proxy.GetLijstInkoop)


        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in ToolStripButtonRefresh_Click (Load) " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 28/11/2012</remarks>
    Private Sub ToolStripButtonOpenVerslag_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonOpenVerslag.Click

        Try
            If UltraGridLijstInkoop.ActiveRow Is Nothing Then Return
            If Not UltraGridLijstInkoop.ActiveRow.IsDataRow Then Return

            Dim idRegistratie As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_REG"))
            If idRegistratie <= 0 Then Return

            Dim RegistratieType As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_TY_REG"))
            '1      Aanrijding
            '2      Controle Voertuigen
            '3      Diefstal
            '4	    Inbreuk op Reglementen
            '5      Schadegeval
            '6      Openmaken Kleerkast
            '7      Diverse Registratie
            '8      Alcoholtest
            '9      Milieuverslag

            Cursor.Current = Cursors.WaitCursor
            Select Case RegistratieType
                Case 1
                    FormManager.Current.OpenFormAanrijding(False, False, True, idRegistratie)
                Case 2
                    FormManager.Current.OpenFormControleVoertuigen(False, False, True, idRegistratie)
                Case 3
                    FormManager.Current.OpenFormDiefstal(False, False, True, idRegistratie)
                Case 4
                    FormManager.Current.OpenFormInbreukReglementen(False, False, True, idRegistratie)
                Case 5
                    FormManager.Current.OpenFormSchadegeval(False, False, True, idRegistratie)
                Case 6
                    FormManager.Current.OpenFormOpenmakenKleerkast(False, False, True, idRegistratie)
                Case 7
                    FormManager.Current.OpenFormDiverseRegistratie(False, False, True, idRegistratie)
                Case 8
                    FormManager.Current.OpenFormAlcoholtest(False, False, True, idRegistratie)
                Case 9
                    FormManager.Current.OpenFormBewakingMilieuVerontreiniging(False, False, True, idRegistratie)
            End Select
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show("Fout opgetreden in FormBewakingInkoop - ToolStripButtonOpenVerslag_Click " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridLijstInkoop_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridLijstInkoop.DoubleClickRow
        Try
            If UltraGridLijstInkoop.ActiveRow Is Nothing Then Return
            If Not UltraGridLijstInkoop.ActiveRow.IsDataRow Then Return

            Dim idRegistratie As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_REG"))
            If idRegistratie <= 0 Then Return

            Dim RegistratieType As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_TY_REG"))
            '1      Aanrijding
            '2      Controle Voertuigen
            '3      Diefstal
            '4	    Inbreuk op Reglementen
            '5      Schadegeval
            '6      Openmaken Kleerkast
            '7      Diverse Registratie
            '8      Alcoholtest
            '9      Milieuverslag

            Cursor.Current = Cursors.WaitCursor
            Select Case RegistratieType
                Case 1
                    FormManager.Current.OpenFormAanrijding(False, False, True, idRegistratie)
                Case 2
                    FormManager.Current.OpenFormControleVoertuigen(False, False, True, idRegistratie)
                Case 3
                    FormManager.Current.OpenFormDiefstal(False, False, True, idRegistratie)
                Case 4
                    FormManager.Current.OpenFormInbreukReglementen(False, False, True, idRegistratie)
                Case 5
                    FormManager.Current.OpenFormSchadegeval(False, False, True, idRegistratie)
                Case 6
                    FormManager.Current.OpenFormOpenmakenKleerkast(False, False, True, idRegistratie)
                Case 7
                    FormManager.Current.OpenFormDiverseRegistratie(False, False, True, idRegistratie)
                Case 8
                    FormManager.Current.OpenFormAlcoholtest(False, False, True, idRegistratie)
                Case 9
                    FormManager.Current.OpenFormBewakingMilieuVerontreiniging(False, False, True, idRegistratie)
            End Select
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show("Fout opgetreden in FormBewakingInkoop - UltraGridLijstInkoop_DoubleClickRow " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridLijstInkoop_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridLijstInkoop.InitializeLayout

    End Sub

    Private Sub ToolStripButtonSendMail_Click(sender As Object, e As System.EventArgs)

        Try
            If UltraGridLijstInkoop.ActiveRow Is Nothing Then Return
            If Not UltraGridLijstInkoop.ActiveRow.IsDataRow Then Return

            Dim idRegistratie As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_REG"))
            If idRegistratie <= 0 Then Return

            Dim RegistratieType As Int32 = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.GetCellValue("ID_TY_REG"))
            '1      Aanrijding
            '2      Controle Voertuigen
            '3      Diefstal
            '4	    Inbreuk op Reglementen
            '5      Schadegeval
            '6      Openmaken Kleerkast
            '7      Diverse Registratie
            '8      Alcoholtest
            '9      Milieuverslag

            Cursor.Current = Cursors.WaitCursor
            Select Case RegistratieType
                Case 1
                    FormManager.Current.OpenFormAanrijding(False, False, True, idRegistratie)
                Case 2
                    FormManager.Current.OpenFormControleVoertuigen(False, False, True, idRegistratie)
                Case 3
                    FormManager.Current.OpenFormDiefstal(False, False, True, idRegistratie)
                Case 4
                    FormManager.Current.OpenFormInbreukReglementen(False, False, True, idRegistratie)

                Case 5
                    FormManager.Current.OpenFormSchadegeval(False, False, True, idRegistratie)
                Case 6
                    FormManager.Current.OpenFormOpenmakenKleerkast(False, False, True, idRegistratie)
                Case 7
                    FormManager.Current.OpenFormDiverseRegistratie(False, False, True, idRegistratie)
                Case 8
                    FormManager.Current.OpenFormAlcoholtest(False, False, True, idRegistratie)
                Case 9
                    FormManager.Current.OpenFormBewakingMilieuVerontreiniging(False, False, True, idRegistratie)
            End Select
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show("Fout opgetreden in FormBewakingInkoop - ToolStripButtonOpenVerslag_Click " & ex.Message & vbCrLf & ex.StackTrace,
                            "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 05/12/2012</remarks>
    Private Sub ToolStripButtonRemark_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRemark.Click
        Try

            If UltraGridLijstInkoop.ActiveRow.IsFilterRow Then
                MessageBox.Show("Gelieve een verslag te selecteren aub.", "Verslag", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Using frm As New FormBewakingInkoopRemark
                    frm.RegistratieId = Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.Cells("ID_REG").Value)
                    frm.LabelVerslag.Text = "Verslag: " & UltraGridLijstInkoop.ActiveRow.Cells("VLG_REG_JR_BPL").Value.ToString & " - " &
                                                UltraGridLijstInkoop.ActiveRow.Cells("SCF_TY_REG").Value.ToString & " - " &
                                                UltraGridLijstInkoop.ActiveRow.Cells("TMS_INC").Value.ToString

                    frm.TextBoxRemark.Text = UltraGridLijstInkoop.ActiveRow.Cells("OPM_IKP").Value.ToString

                    If frm.ShowDialog(Me) = DialogResult.OK Then

                        Dim proxy As New Proxy.BBWServiceManagementServicesProxy

                        UltraGridLijstInkoop.ActiveRow.Cells("OPM_IKP").Value = frm.TextBoxRemark.Text
                        UltraGridLijstInkoop.ActiveRow.Update()
                    End If
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingInkoop - ToolStripButtonRemark_Click: " & ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Dim strMail As String = String.Empty
        'Dim pathPDFfile As String
        Dim pathsAttachment As New ArrayList
        Dim f_rap As New FormRapportenPreview
        Dim specBest As New ArrayList
        Dim specPathsAttachment As New ArrayList

        Try


            'Dim urlstring As String
            'Dim textMailURL As String

            'Dan mail versturen met PDF-file in attachment
            strMail &= "<a href='http://wfdocprod.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0900f6f0803013c3&latestflag=y'</a>" & vbCrLf & vbCr


            Dim outlookAppClass As New Outlook.Application
            outlookAppClass.CreateObject("outlook.application")

            Dim olmail As Outlook.MailItem
            olmail = CType(outlookAppClass.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)
            olmail.Subject = "Verslag bewaking ArcelorMittal Gent3"
            olmail.BodyFormat = Outlook.OlBodyFormat.olFormatRichText
            olmail.Body = strMail


            olmail.Display(False)


        Catch ex As Exception
            MessageBox.Show("Er is een fout gebeurd in BBW: " & vbCrLf & _
                                                  "Foutboodschap:" & ex.Message & Environment.NewLine & Environment.NewLine &
                                                  "Form: " & Me.Name & Environment.NewLine &
                                                  "Method: " & MethodBase.GetCurrentMethod().ToString, "Fout Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Nancy Coppens - 14/12/2012</remarks>
    Private Sub ToolStripButtonMailsentNull_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonMailsentNull.Click
        Try

            If UltraGridLijstInkoop.ActiveRow.IsFilterRow Then
                MessageBox.Show("Gelieve een verslag te selecteren aub.", "Verslag", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Wenst u de datum Sent mail IKP op leeg te plaatsen?", "Datum leeg", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                    proxy.UpdateIKPSendMailNull(Convert.ToInt32(UltraGridLijstInkoop.ActiveRow.Cells("ID_REG").Value))

                    UltraGridLijstInkoop.ActiveRow.Cells("TMS_IKP_SENDMAIL").Value = DBNull.Value
                    UltraGridLijstInkoop.ActiveRow.Update()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Er is een fout gebeurd in BBW: " & vbCrLf & _
                            "Foutboodschap:" & ex.Message & Environment.NewLine & Environment.NewLine &
                            "Form: " & Me.Name & Environment.NewLine &
                            "Method: " & MethodBase.GetCurrentMethod().ToString, "Fout Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ToolStripButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonCopy.Click
        Try
            Cursor = Cursors.WaitCursor

            UltraGridLijstInkoop.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
            UltraGridLijstInkoop.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

            For Each row As UltraWinGrid.UltraGridRow In UltraGridLijstInkoop.Rows
                row.Selected = True
            Next row

            UltraGridLijstInkoop.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

            UltraGridLijstInkoop.Selected.Rows.Clear()
            UltraGridLijstInkoop.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
            UltraGridLijstInkoop.ActiveRow = UltraGridLijstInkoop.ActiveRowScrollRegion.FirstRow

            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                "Form: " & Me.Name & " - " & GetCurrentMethod().Name & vbCrLf & _
                "Message: " & ex.Message & vbCrLf & _
                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class