Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win


Namespace Forms.Brandweer

    Public Class FormBrandweerJaaroverzichtHervuldeBlustoestellen

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        Private Property Jaartal As Integer
        Private Property PerAfdeling As Boolean

        Public Sub Initialize(ByVal jaar As Decimal, ByVal isPerAfdeling As Boolean)

            Debug.Assert(jaar >= 1990 And jaar <= 2100)

            Jaartal = CInt(jaar)
            PerAfdeling = isPerAfdeling
        End Sub

        Private Sub FormBrandweerJaaroverzichtHervuldeBlustoestellenLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            Dim info As String = If(PerAfdeling, "Afdeling", "Type")

            Text = String.Format("Jaaroverzicht Hervulde Blustoestellen - per {0}", info)
            LabelTitel1.Text = String.Format("JAARVERSLAG - {0}", Jaartal)
            LabelTitel2.Text = String.Format("Jaaroverzicht Hervulde Blustoestellen per {0}", info)
            UltraGridJaarRapport.DisplayLayout.Bands(0).Columns(0).Header.Caption = info

            _dataBrandweerReportHervuldeBlustoestellen.Clear()
            _dataBrandweerReportHervuldeBlustoestellen.Merge(_proxy.GetMateriaalHervuld(Jaartal, PerAfdeling))
        End Sub

        Private Sub UltraGrid1InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridJaarRapport.InitializeLayout
            With UltraGridJaarRapport.DisplayLayout.Bands(0)
                .Summaries.Add(SummaryType.Sum, .Columns("AantalSchriftelijk"))
                .Summaries.Add(SummaryType.Sum, .Columns("AantalTelefonisch"))
                .Summaries.Add(SummaryType.Sum, .Columns("AantalNietGemeld"))
                .Summaries.Add(SummaryType.Sum, .Columns("AantalTotaal"))
            End With
        End Sub

        Private Sub UltraGrid1InitializePrint(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridJaarRapport.InitializePrint
            SetupPrint(e)
        End Sub

        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDoc.PageFooterPrinting
            e.Section.TextLeft = String.Format("Datum afdruk: {0:dd/MM/yyyy HH:mm}", DateTime.Now)
            e.Section.TextRight = String.Format("Pg {0}", _UltraGridPrintDoc.PageNumber)
        End Sub

        Private Sub ButtonPrintClick(sender As Object, e As EventArgs) Handles ButtonPrint.Click
            UltraPrintPreviewDialogGrid.ShowDialog(Me)
        End Sub

        Private Sub ButtonCloseClick(sender As Object, e As EventArgs) Handles ButtonClose.Click
            Close()
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
                    Dim info As String = If(PerAfdeling, "Afdeling", "Type")

                    e.PrintDocument.PrinterSettings.PrintRange = Drawing.Printing.PrintRange.AllPages
                    e.PrintDocument.DefaultPageSettings.Landscape = True
                    e.DefaultLogicalPageLayoutInfo.PageHeader = String.Format("Jaaroverzicht Hervulde Blustoestellen - {0} - per {1}", Jaartal, info)
                    e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                    e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                    e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                    e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40
                End Using

            Catch ex As Exception
                Dim msg As String = String.Format("Fout opgetreden in BBW:" & vbCrLf &
                                                  "Form: FormBrandweerJaaroverzichtHervuldeBlustoestellen - SetupPrint" & vbCrLf &
                                                  "Message: {0}" & vbCrLf &
                                                  "Stacktrace: {1}",
                                                  ex.Message, ex.StackTrace)
                MessageBox.Show(msg, "BBW Brandweer Bewaking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub UltraGridPrintDoc_PagePrinting(sender As System.Object, e As Infragistics.Win.Printing.PagePrintingEventArgs) Handles UltraGridPrintDoc.PagePrinting

        End Sub

        Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCopy.Click
            Using zandloper As New WaitCursor(Me)

                For Each row As UltraGridRow In UltraGridJaarRapport.Rows
                    row.Selected = True
                Next row

                UltraGridJaarRapport.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                UltraGridJaarRapport.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class

End Namespace