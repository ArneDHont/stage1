Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports System.Drawing

Public Class FormUpdateFirmaBBW

    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
    Dim bbfrm_firmaName As String = ""
    Dim bbfrm_id As Integer
    Dim sap_firmaName As String = ""
    Dim sap_firmaNr As String = ""
    Dim sap_straat As String = ""
    Dim sap_postcode As String = ""
    Dim sap_plaats As String = ""

    Private Sub UltraGridFirmas_AfterRowActivate(sender As Object, e As System.EventArgs) Handles UltraGridFirmas.AfterRowActivate
        'Thomas Beirens - 2015 - aangepast naco aug 2016

        Try

            Cursor = Cursors.WaitCursor

            If UltraGridFirmas.ActiveRow.IsFilterRow Then
                bbfrm_firmaName = ""
                bbfrm_id = 0

                firmaBBWtxtBx.Text = ""
                firmaNaamSaptxtBx.Text = ""
                firmaNrSaptxtBx.Text = "0"
            Else
                If UltraGridFirmas.ActiveRow.Cells Is Nothing Then
                    firmaNaamSaptxtBx.Text = ""
                    firmaNrSaptxtBx.Text = "0"

                    sap_firmaName = ""
                    sap_firmaNr = "0"

                    sap_straat = ""
                    sap_postcode = ""
                    sap_plaats = ""
                Else
                    bbfrm_firmaName = UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.NM_FRMColumn.ColumnName).Value
                    bbfrm_id = UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.ID_FRMColumn.ColumnName).Value

                    firmaBBWtxtBx.Text = bbfrm_firmaName
                    firmaNaamSaptxtBx.Text = ""
                    firmaNrSaptxtBx.Text = "0"

                    sap_firmaName = ""
                    sap_firmaNr = "0"

                    sap_straat = ""
                    sap_postcode = ""
                    sap_plaats = ""
                End If

            End If


            Cursor = Cursors.Default
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub


    Private Sub UltraGridAshFrima_AfterRowActivate(sender As Object, e As System.EventArgs) Handles UltraGridAshFrima.AfterRowActivate
        'Thomas Beirens - 2015 - aangepast naco aug 2016

        Cursor = Cursors.WaitCursor

        If UltraGridAshFrima.ActiveRow.IsFilterRow Then
            sap_firmaName = ""
            sap_firmaNr = "0"

            sap_straat = ""
            sap_postcode = ""
            sap_plaats = ""

            firmaNaamSaptxtBx.Text = ""
            firmaNrSaptxtBx.Text = "0"
        Else
            sap_firmaName = UltraGridAshFrima.ActiveRow.Cells("firmanaam").Value
            sap_firmaNr = UltraGridAshFrima.ActiveRow.Cells("firmanummer").Value

            sap_straat = UltraGridAshFrima.ActiveRow.Cells("Straat").Value
            sap_postcode = UltraGridAshFrima.ActiveRow.Cells("Postcode").Value

            sap_plaats = UltraGridAshFrima.ActiveRow.Cells("Plaats").Value
            If UltraGridAshFrima.ActiveRow.Cells("Landcode").Value = "BE" Then
            Else
                If UltraGridAshFrima.ActiveRow.Cells("Landcode").Value.ToString.Trim <> "" Then 'bv. PARIS (FR)
                    sap_plaats = UltraGridAshFrima.ActiveRow.Cells("Plaats").Value & " (" & UltraGridAshFrima.ActiveRow.Cells("Landcode").Value & ")"
                End If
            End If

            firmaNaamSaptxtBx.Text = sap_firmaName
            firmaNrSaptxtBx.Text = sap_firmaNr
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub UltraGridAshFrima_ClickCell(sender As System.Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles UltraGridAshFrima.ClickCell

    End Sub

    ''' <summary>
    ''' code geschreven door Thomas - aangepast door naco aug 2016
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub bewaarBtn_Click(sender As System.Object, e As System.EventArgs) Handles bewaarBtn.Click

        If firmaNaamSaptxtBx.Text.Trim <> "" Then

            Dim boxText = "Wenst u de SAP gegevens bij te werken voor BBW Firma " & ControlChars.NewLine &
                           ControlChars.NewLine &
                           "Id_frm: " + bbfrm_id.ToString() + " en naam: " + bbfrm_firmaName + " met " & ControlChars.NewLine &
                           "SAP id: " + sap_firmaNr.ToString() + " en SAP naam: " + sap_firmaName.ToString() + " ?"

            Dim dglRsltID As DialogResult = MessageBox.Show(boxText, "Bewaar stap 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (dglRsltID = System.Windows.Forms.DialogResult.Yes) Then

                Dim boxAddressText = "Wenst u het adres in BBW bij te werken naar de adresgegevens uit SAP " & ControlChars.NewLine &
                                     sap_straat & ControlChars.NewLine &
                                     sap_postcode + " " + sap_plaats + " ? "
                Dim dglRslt As DialogResult = MessageBox.Show(boxAddressText, "Bewaar stap 2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                If (dglRslt = System.Windows.Forms.DialogResult.Yes) Then 'adres ook updaten
                    Try
                        'Update bbfrm adres 2
                        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                        proxy.UpdateFirmasWithAddress(bbfrm_id, sap_firmaNr, sap_firmaName, sap_straat, sap_postcode, sap_plaats)

                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden bij Update Firma's Brandweer Bewaking:  " & vbCrLf &
                        "Form: FormUpdateFirmaBBW -  UpdateFirmasWithaddress" & vbCrLf &
                        "Message: " & ex.Message & vbCrLf &
                        "Stacktrace: " & ex.StackTrace, "BBW Update Firma's",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                        LoadBBWFirma()
                    End Try

                ElseIf (dglRslt = System.Windows.Forms.DialogResult.No) Then 'enkel firmanr sap en naam sap updaten
                    Try
                        'Update bbfrm adres 1
                        Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                        proxy.UpdateFirmas(bbfrm_id, sap_firmaNr, sap_firmaName)
                    Catch ex As Exception
                        MessageBox.Show("Fout opgetreden bij Update Firma's Brandweer Bewaking:  " & vbCrLf &
                       "Form: FormUpdateFirmaBBW -  UpdateFirmas" & vbCrLf &
                       "Message: " & ex.Message & vbCrLf &
                       "Stacktrace: " & ex.StackTrace, "BBW Update Firma's",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                        LoadBBWFirma()
                    End Try
                Else
                    'Update canceled
                End If
            Else

            End If
        Else
            MessageBox.Show("Gelieve eerst een BBW firma en SAP firma te selecteren.", "BBW Update Firma's", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub FormUpdateFirmaBBW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            LoadBBWFirma()
            LoadAshFrima()

        Catch ex As Exception

            'Logging
            MessageBox.Show("Fout opgetreden bij Update Firma's Brandweer Bewaking:  " & vbCrLf & _
                         "Form: FormUpdateFirmaBBW -  FormUpdateFirmaBBW_Load" & vbCrLf & _
                         "Message: " & ex.Message & vbCrLf & _
                         "Stacktrace: " & ex.StackTrace, "BBW Update Firma's", _
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub


    Private Sub LoadBBWFirma()
        'code Thomas LWA - 2015

        Dim dsFirmabbw As New TDSFirmas

        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData()

            Cursor = Cursors.WaitCursor
            'Load firma data from BBW service into DATAGRID
            dsFirmabbw.Merge(_controller.GetFirmas())
            _dataFirmas.Merge(dsFirmabbw.Tables("BBFRM").Select("", "NM_FRM ASC"))
            Me.UltraGridFirmas.DataSource = _dataFirmas

            Application.DoEvents()

            Cursor = Cursors.Default

        Catch ex As Exception
            'Logging
            MessageBox.Show("Fout opgetreden bij Update Firma's Brandweer Bewaking:  " & vbCrLf & _
                          "Form: FormUpdateFirmaBBW -  LoadBBWFirma" & vbCrLf & _
                          "Message: " & ex.Message & vbCrLf & _
                          "Stacktrace: " & ex.StackTrace, "BBW Update Firma's", _
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub LoadAshFrima()
        'code Thomas LWA - 2015

        Dim dsFirma As New TDSFirmaHRM
        Dim objFirma As New HRMdata

        Try

            'Load firma data from SAP into DATAGRID
            dsFirma.Merge(objFirma.GetFirma)
            _dataFirmaHRM.Merge(dsFirma.Tables("Firma").Select("", "firmanaam ASC"))
            Me.UltraGridAshFrima.DataSource = _dataFirmaHRM

        Catch ex As Exception
            'Logging
            MessageBox.Show("Fout opgetreden bij Update Firma's Brandweer Bewaking:  " & vbCrLf & _
                           "Form: FormUpdateFirmaBBW -  LoadAshFrima" & vbCrLf & _
                           "Message: " & ex.Message & vbCrLf & _
                           "Stacktrace: " & ex.StackTrace, "BBW Update Firma's", _
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub UltraGridAshFrima_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAshFrima.InitializeLayout

    End Sub

    Private Sub UltraGridFirmas_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridFirmas.InitializeLayout

    End Sub

    Private Sub ButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click

        For Each row As UltraGridRow In UltraGridFirmas.Rows
            row.Selected = True
        Next row

        UltraGridFirmas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
        UltraGridFirmas.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

        MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UltraGridFirmas_InitializeRow(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles UltraGridFirmas.InitializeRow
        Try
            If e.Row.Cells("NR_IND_FRM_SAP").Value.ToString.Trim = "" Then
            Else 'als nr_ind_frm_sap ingevuld => oranje tonen
                e.Row.Appearance.BackColor = Color.Orange
            End If
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub ButtonCheckInSAP_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCheckInSAP.Click
        'Nancy Coppens - augustus 2016
        '606 van de 3502 firma's gevonden (met zelfde naam en postcode) => automatisch firmanr SAP en firmanaam SAP invullen
        Dim strFirmIDBBW As String = ""
        Dim strFirmBBW As String = ""
        Dim strPostcodeBBW As String = ""
        Dim nrFound As Integer = 0
        Dim strFound As String = ""

        For i As Integer = 0 To _dataFirmas.BBFRM.Rows.Count - 1
            strFirmIDBBW = UltraGridFirmas.Rows(i).Cells("ID_FRM").Value.ToString.ToUpper
            strFirmBBW = UltraGridFirmas.Rows(i).Cells("NM_FRM").Value.ToString.ToUpper
            strPostcodeBBW = UltraGridFirmas.Rows(i).Cells("PO_COD_PLA_FRM").Value.ToString.ToUpper

            UltraGridAshFrima.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()

            UltraGridAshFrima.DisplayLayout.Bands(0).ColumnFilters("firmanaam").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains, _
                                                        strFirmBBW)
            UltraGridAshFrima.DisplayLayout.Bands(0).ColumnFilters("postcode").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains, _
                                            strPostcodeBBW)
            Dim proxy As New Proxy.BBWServiceManagementServicesProxy



            If UltraGridAshFrima.Rows.FilteredInRowCount > 0 Then
                'MessageBox.Show("OK gevonden - " & strFirmBBW & " -" & strPostcodeBBW)
                nrFound = nrFound + 1
                strFound = strFound & vbCrLf & nrFound & ". " & strFirmBBW & " - " & strPostcodeBBW

                Dim strSAPfirmanr As String = UltraGridAshFrima.Rows.GetFilteredInNonGroupByRows(0).Cells("firmanummer").Value.ToString.ToUpper
                Dim strSAPfirmaStraat As String = UltraGridAshFrima.Rows.GetFilteredInNonGroupByRows(0).Cells("Straat").Value.ToString.ToUpper
                Dim strSAPfirmaPlaats As String = UltraGridAshFrima.Rows.GetFilteredInNonGroupByRows(0).Cells("Plaats").Value.ToString.ToUpper
                Dim strSAPfirmaNaam As String = UltraGridAshFrima.Rows.GetFilteredInNonGroupByRows(0).Cells("firmanaam").Value.ToString.ToUpper

                'automatische update op de database van BBFRM
                proxy.UpdateFirmasWithAddress(strFirmIDBBW, strSAPfirmanr, strSAPfirmaNaam, strSAPfirmaStraat, strPostcodeBBW, strSAPfirmaPlaats)

            End If
        Next

        MessageBox.Show("aantal gevonden in SAP: " & nrFound)
        MessageBox.Show("firma's gevonden in SAP: " & strFound)

        TextBox1.Text = strFound

    End Sub


    Private Sub ButtonFillColumnMail_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFillColumnMail.Click
        'naco - 14/03/2017 - add email contactperson firm

        If MessageBox.Show("Het tonen van de mail-adressen in de grid kan enkele seconden duren. Wenst u de mail-adressen op te halen?",
                           "Opvullen email-adressen contactpersoon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim strFirmIDBBW As String = ""
            Dim strFirmIDSAP As String = ""
            Dim strFirmBBW As String = ""
            'strFirmBBW = UltraGridFirmas.Rows(i).Cells("NM_FRM").Value.ToString.ToUpper
            Dim strMailToFirm As String
            Dim lngRowsCount As String = _dataFirmas.BBFRM.Rows.Count.ToString

            For i As Integer = 0 To _dataFirmas.BBFRM.Rows.Count - 1
                strFirmIDSAP = UltraGridFirmas.Rows(i).Cells("NR_IND_FRM_SAP").Value.ToString.ToUpper
                strFirmIDBBW = UltraGridFirmas.Rows(i).Cells("ID_FRM").Value.ToString.ToUpper

                If strFirmIDSAP <> "" Then
                    strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(CInt(strFirmIDSAP)) 'eerst proberen met SAP firmanr

                    If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                        strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(CInt(strFirmIDBBW)) 'dan proberen met BBW firmanr
                        If strMailToFirm <> "" Then
                            UltraGridFirmas.Rows(i).Cells("ContactPersonMail_FRS").Value = strMailToFirm
                        End If
                    Else
                        UltraGridFirmas.Rows(i).Cells("ContactPersonMail_FRS").Value = strMailToFirm
                    End If

                Else
                    strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(CInt(strFirmIDBBW)) 'proberen met BBW firmanr

                    If strMailToFirm <> "" Then 'geen contactpersoon ingevuld op SAP
                        UltraGridFirmas.Rows(i).Cells("ContactPersonMail_FRS").Value = strMailToFirm
                    End If

                End If

                If i Mod 100 = 0 Then
                    LabelMailContactProgress.Text = i.ToString & "/" & lngRowsCount
                    Application.DoEvents()
                End If
            Next

            LabelMailContactProgress.Text = ""
        End If

    End Sub

    Private Sub ButtonEditBBFRM_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEditBBFRM.Click
        'naco - maart 2017

        Try

            If UltraGridFirmas.ActiveRow.Cells("NR_IND_FRM_SAP").Value.ToString = "" Then
                Dim f_firma As New FormUpdateFirmMail_BBW

                f_firma.pFirmId = CInt(UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.ID_FRMColumn.ColumnName).Value)
                f_firma.pFirmName = UltraGridFirmas.ActiveRow.Cells(_dataFirmas.BBFRM.NM_FRMColumn.ColumnName).Value

                f_firma.ShowDialog()

                If f_firma.pCanceled = False Then

                    Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                    proxy.UpdateBBFRM_EmailRemarkLanguage(f_firma.pFirmId, f_firma.pFirmEmail, f_firma.pFirmRemark, f_firma.pFirmLanguage)

                    LoadBBWFirma()

                End If

                f_firma = Nothing
            Else
                MessageBox.Show("Opgelet: deze firma heeft een koppeling met een SAP firmanummer." & vbCrLf &
                                "Gelieve het email-adres van de contactpersoon via CLIP schermen in te vullen aub.", "Koppeling SAP firmanummer", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in Brandweer Bewaking:  " & vbCrLf & _
                                        "Form: FormUpdateFirmaBBW" & vbCrLf & _
                                        "Message: " & ex.Message & vbCrLf & _
                                        "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking Verslagen", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ButtonInfoChip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInfoChip.Click
        'naco - 22/03/2017

        If UltraGridFirmas.ActiveRow Is Nothing OrElse Not UltraGridFirmas.ActiveRow.IsDataRow Then
            MessageBox.Show("Geen firma geselecteerd.", "Error", MessageBoxButtons.OK)
            Return
        End If

        Dim BBWServiceProxy As New Proxy.BBWServiceManagementServicesProxy
        Dim strFirmaNaamBBW As String = UltraGridFirmas.ActiveRow.Cells("NM_FRM").Value.ToString
        Dim intIDFRM_BBW As Integer = CInt(UltraGridFirmas.ActiveRow.Cells("ID_FRM").Value)

        If strFirmaNaamBBW = "" Then
            MessageBox.Show("Firmanaam is niet ingevuld: verslag kan niet automatisch naar CHIP gestuurd worden.", "Firmanaam - CHIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim intIDFirmSAP As Integer = BBWServiceProxy.GetCHIP_SAPFirmNr(intIDFRM_BBW)

            If intIDFirmSAP > 0 And intIDFRM_BBW <> 1001674 Then  'SAP firma nr gevonden of 1001674 = ArcelorMittal Gent (dan geen mail versturen naar CHIP)

                Dim strMailToFirm As String
                'strMailToFirm = BBWServiceProxy.GetCHIP_SAPFirm_EmailContact(intIDFirmSAP)
                strMailToFirm = HRMdata.GetSAPFirm_EmailContact_Firma(intIDFirmSAP)

                If strMailToFirm = "" Then 'geen contactpersoon ingevuld op SAP
                    MessageBox.Show("Geen contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firma nr: " & intIDFirmSAP & ".", "Geen contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else 'wel een contactpersoon => mail met verslag in bijlage versturen
                    MessageBox.Show("Contactpersoon voor BBW firma: " & strFirmaNaamBBW & vbCrLf &
                                    "met SAP firmanr: " & intIDFirmSAP & vbCrLf & vbCrLf & strMailToFirm, "Contactpersoon", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                If intIDFRM_BBW <> 1001674 Then '1001674 = ArcelorMittal Gent => geen msgbox tonen
                    MessageBox.Show("Verslag kan niet automatisch naar firma gestuurd worden en niet naar CHIP portaal." & vbCrLf & vbCrLf &
                                    "SAP firmanr niet gekend voor deze BBW firma: " & vbCrLf & strFirmaNaamBBW & ".", "Verslag automatisch naar CHIP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Verslag waarvoor BBW firma = ArcelorMittal Gent." & vbCrLf &
                                    "Verslagen voor AM Gent worden niet naar CHIP verstuurd.", "Verslag AM Gent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
End Class