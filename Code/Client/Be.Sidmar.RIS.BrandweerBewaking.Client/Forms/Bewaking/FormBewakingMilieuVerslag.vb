Imports System.Windows.Forms

Public Class FormBewakingMilieuVerslag

    Protected STANDAARDZIN As String '= Configuration.ConfigurationSettings.AppSettings("StandaardzinMilieuverslagBewaking")

    Protected Overrides Sub SetGUI()
        MyBase.SetGUI()

        Me.Text = "Milieuverslag"
        Me.LabelTitel.Text = "Milieuverslag"
    End Sub

    Protected Overrides Sub setLabelsVerplicht()
        MyBase.setLabelsVerplicht()

        Me.LabelAfdeling.Text &= " *"
    End Sub

    Protected Overrides Function getTyReg() As Integer
        Return 9
    End Function

    Protected Overrides Function controleVeldenOK() As Boolean
        Dim veldenOk As Boolean
        veldenOk = MyBase.controleVeldenOK()

        addStandaardZin()


        If Me.UltraComboAfdelingen.Text = "" Then
            Return False
        Else
            Return veldenOk
        End If
    End Function

    Protected Overrides Function getNaamVerslag() As String
        Return "Het milieuverslag"
    End Function

    Protected Sub addStandaardZin()
        STANDAARDZIN = _dataConfiguratie.BBCONF.FindByGR_SLESLE("MILIEU", "ExtraZinVerslag").WD
        If InStr(UCase(Me.TextBoxRelaas.Text), UCase(STANDAARDZIN)) = 0 Then
            Me.TextBoxRelaas.Text &= vbCrLf & vbCrLf & STANDAARDZIN
        End If
    End Sub

    ''' <summary>
    ''' Code of Dieter Vanneste - june 2009
    ''' Updated by sidnaco - 16/02/2010 (add the AMC's of department MIL)
    ''' </summary>
    ''' <param name="id_afd"></param>
    ''' <remarks></remarks>

    Protected Overrides Sub setBestemmelingen(ByVal id_afd As Integer)
        MyBase.setBestemmelingen(id_afd)

        Dim aTds As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC
        Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
        Dim aTableBestem As New Be.Sidmar.RIS.BrandweerBewaking.Component.TDSBBBestemmelingen

        'AMC's of the selected department
        '--------------------------------
        aTds = proxy.GetBestemmelingenAfdeling(id_afd)

        If aTds.BBAFDAMC.Rows.Count = 0 Then
            MessageBox.Show("Gelieve een AMC op te laden voor de afdeling.", "Geen bestemmelingen AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC.BBAFDAMCRow In aTds.BBAFDAMC
                aTableBestem.BBBST.AddBBBSTRow(Nothing, Me._idRegistratie, aRow.ID_IND, aRow.NM_IND, aRow.VNM_IND, aRow.MAIL)
            Next
        End If

        '16/02/2010 - naco
        'Telefoon Nico Hautekiet => also add the AMC's of deparment MIL to the addressees 
        Dim aTdsMIL As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC
        aTdsMIL = proxy.GetBestemmelingenAfdeling(54) 'id_afd = 54 = MIL

        If aTdsMIL.BBAFDAMC.Rows.Count = 0 Then
            MessageBox.Show("Gelieve een AMC op te laden voor de afdeling MIL.", "Geen bestemmelingen AMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each aRow As Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWService.Mgt.TDSBeheerAFDAMC.BBAFDAMCRow In aTdsMIL.BBAFDAMC
                aTableBestem.BBBST.AddBBBSTRow(Nothing, Me._idRegistratie, aRow.ID_IND, aRow.NM_IND, aRow.VNM_IND, aRow.MAIL)
            Next
        End If

        Me.UserControlGeneralFunctionsDivRegistratie.setBestemmelingenData(aTableBestem.BBBST)

    End Sub

    Private Sub ButtonMailIKP_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
