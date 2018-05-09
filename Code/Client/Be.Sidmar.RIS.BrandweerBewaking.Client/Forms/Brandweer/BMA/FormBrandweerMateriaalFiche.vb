Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports Infragistics.Win.UltraWinGrid

Namespace Forms.Brandweer

    Public Class FormBrandweerMateriaalFiche

        Private Property TypeMateriaalId As Integer
        Private Property MateriaalVolgnummer As Integer

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

#Region "Form Initialisation"

        ''' <summary>
        ''' Set the primary key of the maaterial that needs editing.
        ''' </summary>
        ''' <param name="typeMateriaal">The ID of the material type.</param>
        ''' <param name="volgnummer">The sequence number within the material type.</param>
        ''' <remarks></remarks>
        Public Sub SetPrimaryKey(ByVal typeMateriaal As Integer, ByVal volgnummer As Integer)
            TypeMateriaalId = typeMateriaal
            MateriaalVolgnummer = volgnummer
        End Sub

#End Region

#Region "Event Handlers"

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerMateriaalFicheLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))
        End Sub

        ''' <summary>
        ''' Toevoegen van een nieuwe actie.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonNieuwClick(sender As Object, e As EventArgs) Handles ToolStripButtonNieuw.Click
            Using schermpje As New FormBrandweerMateriaalWeging
                If schermpje.ShowDialog(Me) = DialogResult.OK Then
                    _proxy.StoreMateriaalActie(TypeMateriaalId, MateriaalVolgnummer, schermpje.Datum, schermpje.Actie, schermpje.Gewicht)
                    _dataBrandweerMateriaalActie.Clear()
                    _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Wijzigen van een bestaande entry.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonEditClick(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
            Dim actieId As Integer

            Dim row As UltraGridRow = UltraGrid1.ActiveRow
            If row Is Nothing OrElse row.IsFilterRow Then Return

            If Not Integer.TryParse(CStr(row.GetCellValue("ActieId")), actieId) Then Return

            Using schermpje As New FormBrandweerMateriaalWeging

                Dim datum As DateTime
                If Not IsDBNull(row.GetCellValue("Datum")) AndAlso DateTime.TryParse(CStr(row.GetCellValue("Datum")), datum) Then
                    schermpje.Datum = datum
                End If

                Dim actie As Integer
                If IsDBNull(row.GetCellValue("ActieCodeID")) OrElse Not Integer.TryParse(CStr(row.GetCellValue("ActieCodeID")), actie) Then
                    schermpje.Actie = Nothing
                Else
                    schermpje.Actie = actie
                End If

                Dim gewicht As Decimal
                If IsDBNull(row.GetCellValue("Gewicht")) OrElse Not Decimal.TryParse(CStr(row.GetCellValue("Gewicht")), gewicht) Then
                    schermpje.Gewicht = Nothing
                Else
                    schermpje.Gewicht = gewicht
                End If

                If schermpje.ShowDialog(Me) = DialogResult.OK Then
                    _proxy.DeleteMateriaalActieById(actieId)
                    _proxy.StoreMateriaalActie(TypeMateriaalId, MateriaalVolgnummer, schermpje.Datum, schermpje.Actie, schermpje.Gewicht)
                    _dataBrandweerMateriaalActie.Clear()
                    _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))
                End If
            End Using
        End Sub

        Private Sub UltraGrid1DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGrid1.DoubleClickRow
            ToolStripButtonEditClick(sender, e)
        End Sub

        ''' <summary>
        ''' Schrappen van een entry.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonDeleteClick(sender As Object, e As EventArgs) Handles ToolStripButtonDelete.Click
            Dim actieId As Integer

            Dim row As UltraGridRow = UltraGrid1.ActiveRow
            If row Is Nothing OrElse row.IsFilterRow Then Return

            If Not Integer.TryParse(CStr(row.GetCellValue("ActieId")), actieId) Then Return

            If MessageBox.Show(Me, "Bent u zeker dat u de geselecteerde actie wil verwijderen?", "Schrappen Actie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            _proxy.DeleteMateriaalActieById(actieId)
            _dataBrandweerMateriaalActie.Clear()
            _dataBrandweerMateriaalActie.Merge(_proxy.GetMateriaalActie(TypeMateriaalId, MateriaalVolgnummer))
        End Sub

        ''' <summary>
        ''' Afsluiten van de materiaalfiche.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonCancelClick(sender As Object, e As EventArgs) Handles ToolStripButtonCancel.Click
            Close()
        End Sub

        ''' <summary>
        ''' Afdrukken van de materiaalfiche.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonPrintClick(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click
            UltraPrintPreviewDialog1.ShowDialog(Me)
        End Sub

        ''' <summary>
        ''' Exporteer de grid naar het clipboard.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonCopyClick(sender As Object, e As EventArgs) Handles ToolStripButtonCopy.Click

            Using zandloper As New WaitCursor(Me)

                For Each row As UltraGridRow In UltraGrid1.Rows
                    row.Selected = True
                Next row

                UltraGrid1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                UltraGrid1.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ''' <summary>
        ''' Initialize Print Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGrid1InitializePrint(sender As Object, e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGrid1.InitializePrint
            SetupPrint(e)
        End Sub

        Private Sub UltraGridPrintDocument1PageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDocument1.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & UltraGridPrintDocument1.PageNumber '& "/" & NrOfPages
        End Sub

#End Region

#Region "Printing Helpers"

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
                e.DefaultLogicalPageLayoutInfo.PageHeader = "ArcelorMittal Gent - Materiaal Fiche - " & Now()
                e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerMateriaalFiche - SetupPrint" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

#End Region

    End Class

End Namespace
