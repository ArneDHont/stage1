Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.Printing
Imports System.Linq


Namespace Forms.Brandweer

    Public Class FormBrandweerVerzendingen

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' Ophalen van de data voor de form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerVerzendingenLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            GetVerzendingen()
        End Sub

        ''' <summary>
        ''' Add a new record to the 'sent' list.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub NewToolStripButtonClick(sender As Object, e As EventArgs) Handles NewToolStripButton.Click

            Using f As New FormBrandweerVerzending With {.VerzendingId = 0}
                f.Text = "Materiaal verzending - nieuw"

                If f.ShowDialog(Me) = DialogResult.OK Then
                    GetVerzendingen()
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Edit a record from the 'sent' list.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub EditToolStripButtonClick(sender As Object, e As EventArgs) Handles EditToolStripButton.Click, UltraGridVerzendingen.DoubleClickRow

            Dim row As UltraGridRow = UltraGridVerzendingen.ActiveRow

            If row Is Nothing OrElse row.IsFilterRow Then Return

            Using f As New FormBrandweerVerzending With {.VerzendingId = CInt(row.GetCellValue("ID"))}
                f.Text = "Materiaal verzending - wijzig"
                f.LabelMateriaalOmschr.Text = UltraGridVerzendingen.ActiveRow.Cells("Afdeling").Value.ToString & " - " &
                                              UltraGridVerzendingen.ActiveRow.Cells("Zone").Value.ToString & " - " &
                                              UltraGridVerzendingen.ActiveRow.Cells("Nr").Value.ToString

                If f.ShowDialog(Me) = DialogResult.OK Then
                    GetVerzendingen()
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Delete the selected records.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub DeleteToolStripButtonClick(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click

            If UltraGridVerzendingen.Rows.Any(Function(row) row.Selected) Then

                Dim strSelectedMaterialVerzending As String = ""
                Dim strMat As String = ""
                Dim intMat As Integer = 0

                For Each row As UltraGridRow In UltraGridVerzendingen.Rows
                    If row.Selected Then

                        intMat = intMat + 1
                        strMat = intMat.ToString & ". " & row.GetCellValue("Afdeling").ToString & " - " & row.GetCellValue("Zone").ToString & " - " & row.GetCellValue("Nr").ToString

                        If strSelectedMaterialVerzending = "" Then
                            strSelectedMaterialVerzending = strMat
                        Else
                            strSelectedMaterialVerzending = strSelectedMaterialVerzending & vbCrLf & strMat
                        End If

                    End If
                Next


                If MessageBox.Show(Me, "Alle " & intMat.ToString & " geselecteerde records in de tabel verzending worden geschrapt! Bent u zeker om deze te verwijderen?" & vbCrLf & vbCrLf & strSelectedMaterialVerzending, "Opgepast", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    Using zandloper As New WaitCursor(Me)
                        Using ds As New Proxy.BBWService.Mgt.TDSBrandweerVerzending

                            For Each row As UltraGridRow In UltraGridVerzendingen.Rows
                                If row.Selected Then
                                    Dim info As Proxy.BBWService.Mgt.TDSBrandweerVerzending.VerzendingRow
                                    info = ds.Verzending.NewVerzendingRow()
                                    info.VerzendingID = CInt(row.GetCellValue("Id"))
                                    ds.Verzending.AddVerzendingRow(info)
                                End If
                            Next

                            _proxy.DeleteVerzending(ds)
                        End Using

                        GetVerzendingen()
                    End Using
                End If
            End If

        End Sub

        ''' <summary>
        ''' Get a printout of the 'sent' list'.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub PrintToolStripButtonClick(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
            UltraPrintPreviewDialog1.ShowDialog(Me)
        End Sub

        ''' <summary>
        ''' Copy the list to the clipboard.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub CopyToolStripButtonClick(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click

            Using zandloper As New WaitCursor(Me)

                For Each row As UltraGridRow In UltraGridVerzendingen.Rows
                    row.Selected = True
                Next row

                UltraGridVerzendingen.DisplayLayout.Override.AllowMultiCellOperations = AllowMultiCellOperation.All
                UltraGridVerzendingen.PerformAction(UltraGridAction.Copy)
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ''' <summary>
        ''' Initialize the layout of a printout.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGridMaterialInitializePrint(sender As Object, e As CancelablePrintEventArgs) Handles UltraGridVerzendingen.InitializePrint
            SetupPrint(e)
        End Sub

        ''' <summary>
        ''' Doel:   rapport instellingen
        ''' Auteur: Nancy Coppens - 05/10/2006
        ''' Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        ''' </summary>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SetupPrint(ByVal e As CancelablePrintEventArgs)
            Try

                e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
                e.PrintDocument.DefaultPageSettings.Landscape = True
                e.DefaultLogicalPageLayoutInfo.PageHeader = "ArcelorMittal Gent - Lijst Brandweer Verzendingen"
                e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerVerzendingen - SetupPrint" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & _UltraGridPrintDocument1.PageNumber '& "/" & NrOfPages
        End Sub

        ''' <summary>
        ''' Get the data for the view.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub GetVerzendingen()

            Try
                _dataBrandweerVerzendingLijst.Clear()
                _dataBrandweerVerzendingLijst.Merge(_proxy.GetVerzendingLijst())

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerVerzendingen - GetVerzendingen" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub ToolStripButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonRefresh.Click
            GetVerzendingen()
        End Sub
    End Class

End Namespace
