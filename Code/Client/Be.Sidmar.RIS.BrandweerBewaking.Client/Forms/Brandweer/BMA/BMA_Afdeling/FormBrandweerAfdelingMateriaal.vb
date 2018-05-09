Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid


Namespace Forms.Brandweer

    Public Class FormBrandweerAfdelingMateriaal

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ' Omschrijvingen van de codes voor de geselecteerde record.
        Private Property CodeAndere As String
        Private Property CodeBlustoestellen As String
        Private Property CodeBrandkranen As String
        Private Property CodeStijgleidingen As String

        ''' <summary>
        ''' The ID of the department.
        ''' </summary>
        Public Property Afdeling As Integer
        Public Property Afdeling2 As Integer
        Public Property Afdeling3 As Integer

        ''' <summary>
        ''' The load event of the form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerAfdelingMateriaalLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            'Debug.Assert(Afdeling > 0) - naco 22/12/2016 - in commentaar (code van Geert Maertens)

            ComboBoxAfd.Text = "KWA"

            ReadCodeDescriptions()
            ReadData()
        End Sub

        ''' <summary>
        ''' Change the manager for the selected record.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonWijzigenClick(sender As Object, e As EventArgs) Handles ToolStripButtonWijzigen.Click, UltraGridAfdMat.DoubleClickRow

            Dim row As UltraGridRow = UltraGridAfdMat.ActiveRow
            If row Is Nothing Or row.IsFilterRow Then Return

            Using schermpje As New FormBrandweerAfdelingBeheerders
                schermpje.AfdelingId = Afdeling
                schermpje.Afdeling2 = Afdeling2
                schermpje.Afdeling3 = Afdeling3

                If schermpje.ShowDialog(Me) = DialogResult.OK Then
                    'beheerder afdeling
                    Using ds As New Proxy.BBWService.Mgt.TDSBrandweerMateriaalBeheerderAfdeling
                        ds.BeheerderAfdeling.AddBeheerderAfdelingRow(CInt(row.GetCellValue("TypeMatID")), CInt(row.GetCellValue("MateriaalVolgNr")), Afdeling,
                                                                     CStr(row.GetCellValue("AfdelingCode")), CStr(row.GetCellValue("LocatieZone")), schermpje.SelectedManager)
                        If Not _proxy.UpdateMateriaalBeheerderAfdeling(ds) Then
                            MessageBox.Show(Me, "Fout bij het opslaan van de wijziging - beheerder materiaal afdeling!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using

                    ReadData()
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Export the current selection to the clipboard.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonCopyClick(sender As Object, e As EventArgs) Handles ToolStripButtonCopy.Click

            Using zandloper As New WaitCursor(Me)

                UltraGridAfdMat.DisplayLayout.Bands(0).Columns("CodeMat").Hidden = False

                For Each row As UltraGridRow In UltraGridAfdMat.Rows
                    row.Selected = True
                Next row

                UltraGridAfdMat.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                UltraGridAfdMat.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

                UltraGridAfdMat.DisplayLayout.Bands(0).Columns("CodeMat").Hidden = True
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ''' <summary>
        ''' Make a printout of the current selection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonPrintClick(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click
            Me.UltraGridAfdMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            UltraGridAfdMat.DisplayLayout.Bands(0).Columns("CodeMat").Hidden = False
            Application.DoEvents()

            UltraPrintPreviewDialog1.ShowDialog(Me)

            Me.UltraGridAfdMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            UltraGridAfdMat.DisplayLayout.Bands(0).Columns("CodeMat").Hidden = True
            Application.DoEvents()
        End Sub

        ''' <summary>
        ''' Leave this Form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonExitClick(sender As Object, e As EventArgs) Handles ToolStripButtonExit.Click
            Close()
        End Sub

        ''' <summary>
        ''' Initialize the print process.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1InitializePrint(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridAfdMat.InitializePrint
            SetupPrint(e)
        End Sub

        ''' <summary>
        ''' Create a footer on the printed pages.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = String.Format(System.Environment.UserName & " - Datum afdruk: {0:dd/MM/yyyy HH:mm}", DateTime.Now)
            e.Section.TextRight = String.Format("Pg {0}", _UltraGridPrintDocument1.PageNumber)
            e.Section.TextCenter = LabelCodes.Text
        End Sub

        ''' <summary>
        ''' The selected row has been changed.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridAfdMat.AfterRowActivate
            Dim row As UltraGridRow = UltraGridAfdMat.ActiveRow
            If row Is Nothing Or row.IsFilterRow Then
                ShowCodeDesciption(0)
            Else
                ShowCodeDesciption(CInt(row.GetCellValue("TypeMatID")))
            End If
        End Sub

        ''' <summary>
        ''' Doel:   rapport instellingen
        ''' Auteur: Nancy Coppens - 05/10/2006
        ''' Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        ''' </summary>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SetupPrint(ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs)
            Try
                Using zandloper As New WaitCursor(Me)
                    e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
                    e.PrintDocument.DefaultPageSettings.Landscape = True
                    e.DefaultLogicalPageLayoutInfo.PageHeader = String.Format("ArcelorMittal Gent - Brandweermateriaal van Afdeling")
                    e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                    e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                    e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40
                End Using

            Catch ex As Exception
                Dim msg As String = String.Format("Fout opgetreden in BBW:" & vbCrLf &
                                                  "Form: FormBrandweerAfdelingMateriaal - SetupPrint" & vbCrLf &
                                                  "Message: {0}" & vbCrLf &
                                                  "Stacktrace: {1}",
                                                  ex.Message, ex.StackTrace)
                MessageBox.Show(msg, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Lees de data voor de grid.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ReadData()
            _dataBrandweerAfdelingMateriaal.Clear()

            If Afdeling = 0 Then 'brandweer ingelogd
                ComboBoxAfd.Visible = True
                LabelAfd.Visible = True
                Application.DoEvents()

                Afdeling = 6 '6 = KWA
                'hard gecodeerd - dit is enkel voor de brandweer zodat zij een zicht hebben hoe het scherm voor de afdelingusers er uit ziet
                ToolStripButtonWijzigen.Enabled = False
                _dataBrandweerAfdelingMateriaal.Merge(_proxy.GetAfdelingMateriaal(Afdeling, 0, 0))
            Else
                _dataBrandweerAfdelingMateriaal.Merge(_proxy.GetAfdelingMateriaal(Afdeling, Afdeling2, Afdeling3))
            End If



        End Sub

        ''' <summary>
        ''' Lees de omschrijvingen van de codes voor de verschillende types materialen.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ReadCodeDescriptions()
            Dim row As TDSConfiguratie.BBCONFRow

            Using info As New TDSConfiguratie
                info.Merge(_proxy.GetConfigurationSettings())

                row = info.BBCONF.FindByGR_SLESLE("Brandweer", "CodesLijstAfdAndere")
                CodeAndere = If(row Is Nothing, "???", row.WD)

                row = info.BBCONF.FindByGR_SLESLE("Brandweer", "CodesLijstAfdBlustoestellen")
                CodeBlustoestellen = If(row Is Nothing, "???", row.WD)

                row = info.BBCONF.FindByGR_SLESLE("Brandweer", "CodesLijstAfdBrandkranen")
                CodeBrandkranen = If(row Is Nothing, "???", row.WD)

                row = info.BBCONF.FindByGR_SLESLE("Brandweer", "CodesLijstAfdStijgleiding")
                CodeStijgleidingen = If(row Is Nothing, "???", row.WD)
            End Using
        End Sub

        ''' <summary>
        ''' Toon de omschrijving van de codes voor een gegeven type materiaal.
        ''' </summary>
        ''' <param name="typeMateriaal"></param>
        ''' <remarks></remarks>
        Private Sub ShowCodeDesciption(ByVal typeMateriaal As Integer)
            Select Case typeMateriaal

                Case 0
                    LabelCodes.Text = ""

                Case 1
                    LabelCodes.Text = CodeBlustoestellen

                Case 2
                    LabelCodes.Text = CodeBrandkranen

                Case 8
                    LabelCodes.Text = CodeStijgleidingen

                Case Else
                    LabelCodes.Text = CodeAndere

            End Select
        End Sub


        Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click
            'naco - 29/12/2016 - workaround om numeriek te sorteren op alfanumeriek veld LocatieNr
            Using zandloper As New Helpers.WaitCursor(Me)

                If ComboBoxAfd.Visible = True Then 'naco - 08/02/2017
                    Select Case ComboBoxAfd.Text
                        Case "COO"
                            Afdeling = 13
                        Case "DD"
                            Afdeling = 1
                        Case "DECO"
                            Afdeling = 35
                        Case "GHV"
                            Afdeling = 21
                        Case "GLT"
                            Afdeling = 3
                        Case "HOO"
                            Afdeling = 9
                        Case "KBH"
                            Afdeling = 16
                        Case "KWA"
                            Afdeling = 6
                        Case "LPK"
                            Afdeling = 20
                        Case "RBV"
                            Afdeling = 7
                        Case "SGL"
                            Afdeling = 27
                        Case "STL"
                            Afdeling = 14
                        Case "TBG"
                            Afdeling = 28
                        Case "WWA"
                            Afdeling = 12
                    End Select

                End If

                ReadData()

                UltraGridAfdMat.DisplayLayout.Bands(0).Columns("LocatieNr").SortIndicator = SortIndicator.None
                UltraGridAfdMat.DisplayLayout.Bands(0).Columns("TypeMatOmschr").SortIndicator = SortIndicator.Ascending 'om de sortering op LocatieNr numeriek te maken
            End Using
        End Sub

        Private Sub UltraGridAfdMat_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridAfdMat.InitializeLayout

        End Sub

        Private Sub LabelCodes_Click(sender As System.Object, e As System.EventArgs) Handles LabelCodes.Click

        End Sub

        'naco - 10/07/2017
        Private Sub ToolStripButtonEditMateriaalvolgnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonEditMateriaalvolgnr.Click
            Dim row As UltraGridRow = UltraGridAfdMat.ActiveRow
            If row Is Nothing Or row.IsFilterRow Then Return

            Using schermpje As New FormBrandweerAfdelingVolgnr
                If IsDBNull(row.GetCellValue("VolgnummerAfdeling")) Then
                    schermpje.SelectedMatDepartmentNr = 0
                Else
                    schermpje.SelectedMatDepartmentNr = CInt(row.GetCellValue("VolgnummerAfdeling"))
                End If

                If schermpje.ShowDialog(Me) = DialogResult.OK Then
                    'volgnr afdeling
                    If Not _proxy.UpdateMateriaalAfdelingVolgnr(CInt(row.GetCellValue("TypeMatID")), CInt(row.GetCellValue("MateriaalVolgNr")), schermpje.SelectedMatDepartmentNr) Then
                        MessageBox.Show(Me, "Fout bij het opslaan van de wijziging - materiaal volgnr afdeling!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    ReadData()
                End If
            End Using
        End Sub
    End Class

End Namespace
