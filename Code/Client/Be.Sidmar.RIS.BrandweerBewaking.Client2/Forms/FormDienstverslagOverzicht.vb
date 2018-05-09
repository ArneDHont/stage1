Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client2.Helpers
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling
Imports System.Reflection


Namespace Forms

    Public Class FormDienstverslagOverzicht

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        Private _initialFill As Boolean

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Geert Maertens - feb 2012</remarks>
        Private Sub FormDienstverslagOverzichtLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                UltraGrid1.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
                LoadData(False)
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Another month was selected.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Geert Maertens - feb 2012</remarks>
        Private Sub ComboBoxMonthsSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMonths.SelectedIndexChanged
            Try
                _dataDienstverslagLijst.Clear()

                If _initialFill Then Return
                If ComboBoxMonths.SelectedIndex < 0 Then Return
                Dim jaarMaand As Integer = CInt(ComboBoxMonths.SelectedValue)

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstverslagLijst = _proxy.DienstverslagGetLijst(jaarMaand \ 100, jaarMaand Mod 100)

                    If dsIn Is Nothing Then
                        MessageBox.Show("Geen data gevonden voor jaar-maand: " & jaarMaand & ".", "Dienstverslagen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else

                        For Each r As Proxy.BBWService.Mgt.TDSDienstverslagLijst.DienstverslagRow In dsIn.Dienstverslag
                            _dataDienstverslagLijst.Dienstverslag.AddDienstverslagRow(r.Datum, r.Ploeg, r.Verantwoordelijke.ProperCase(), r.Opmerkingen, r.PloegId)
                        Next
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Add a new row.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Geert Maertens - feb 2012</remarks>
        Private Sub ToolStripButtonNewClick(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonNew.Click
            Try
                Using fNew As New FormDienstVerslagNieuw
                    If fNew.ShowDialog(Me) = DialogResult.OK Then

                        Using fEntry As New FormDienstverslagEntry
                            fEntry.Datum = fNew.Datum
                            fEntry.PloegId = fNew.PloegId
                            fEntry.PloegNaam = fNew.PloegNaam
                            fEntry.ShowDialog()
                        End Using

                        LoadData(True)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try

        End Sub

        ''' <summary>
        ''' Edit the selected row.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Geert Maertens - feb 2012</remarks>
        Private Sub ToolStripButtonEditClick(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click, UltraGrid1.DoubleClickCell
            Try
                If UltraGrid1.ActiveRow Is Nothing Then Return
                If UltraGrid1.ActiveRow.IsFilterRow Then Return

                Using f As New FormDienstverslagEntry
                    f.Datum = CDate(UltraGrid1.ActiveRow.GetCellValue("Datum"))
                    f.PloegId = CInt(UltraGrid1.ActiveRow.GetCellValue("PloegId"))
                    f.PloegNaam = CStr(UltraGrid1.ActiveRow.GetCellValue("Ploeg"))
                    f.ShowDialog()
                End Using

                LoadData(True)

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Make a print-out of the grid.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonPrintClick(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click
            UltraPrintPreviewDialog1.ShowDialog(Me)
        End Sub

        ''' <summary>
        ''' Copy the contents of the grid to the clipboard.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Geert Maertens - feb 2012</remarks>
        Private Sub ToolStripButtonCopyClipboardClick(sender As Object, e As EventArgs) Handles ToolStripButtonCopyClipboard.Click

            Try
                Using zandloper As New WaitCursor(Me)

                    For Each row As UltraGridRow In UltraGrid1.Rows
                        row.Selected = True
                    Next row

                    UltraGrid1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                    UltraGrid1.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)
                End Using

                MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try

        End Sub

        ''' <summary>
        ''' Close the window.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonExitClick(sender As Object, e As EventArgs) Handles ToolStripButtonExit.Click
            Close()
        End Sub

        ''' <summary>
        ''' Initialize Print Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1InitializePrint(sender As Object, e As CancelablePrintEventArgs) Handles UltraGrid1.InitializePrint
            SetupPrint(e)
        End Sub

        Private Sub UltraGridPrintDocument1PageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & UltraGridPrintDocument1.PageNumber '& "/" & NrOfPages
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
                e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
                e.PrintDocument.DefaultPageSettings.Landscape = True
                e.DefaultLogicalPageLayoutInfo.PageHeader = "Overzicht Dagverslag - " & Now()
                e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormDagverslagOverzicht - SetupPrint" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Fill the grid.
        ''' </summary>
        ''' <param name="withReposition">Reposition the view on the current selection?</param>
        ''' <remarks></remarks>
        Private Sub LoadData(ByVal withReposition As Boolean)

            Try

                ' Store the current Positions
                ' ---------------------------
                Dim oldPosMonth As Integer = ComboBoxMonths.SelectedIndex
                Dim oldPosGrid As Integer = If(UltraGrid1.ActiveRow Is Nothing, 0, UltraGrid1.ActiveRow.Index)

                ' Fill up the datasource
                ' ----------------------
                _dataDienstverslagMaanden.Clear()

                Using dsIn As Proxy.BBWService.Mgt.TDSDienstverslagMaanden = _proxy.DienstverslagGetMonths()

                    _initialFill = True
                    For Each r As Proxy.BBWService.Mgt.TDSDienstverslagMaanden.MaandenRow In dsIn.Maanden
                        _dataDienstverslagMaanden.Maanden.AddMaandenRow(r.Jaar, r.Maand, r.Jaar * 100 + r.Maand, String.Format("{0} {1}", MonthName(r.Maand), r.Jaar))
                    Next
                    _initialFill = False

                    ' Restore the active selection
                    ' ----------------------------
                    If withReposition Then
                        ComboBoxMonths.SelectedIndex = Math.Min(oldPosMonth, dsIn.Maanden.Rows.Count - 1)
                        Dim newPosGrid As Integer = Math.Min(oldPosGrid, UltraGrid1.Rows.Count - 1)
                        UltraGrid1.ActiveRow = If(newPosGrid >= 0, UltraGrid1.Rows(newPosGrid), Nothing)
                    Else
                        ComboBoxMonths.SelectedIndex = If(dsIn.Maanden.Rows.Count > 0, 0, -1)
                    End If

                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                        ReThrowOptions.PublishOnly)
            End Try
        End Sub

    End Class

End Namespace
