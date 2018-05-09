Option Explicit On
Option Infer On
Option Strict On

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection
Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.Threading.Tasks
Imports Be.Sidmar.RIS.BrandweerBewaking.Proxy

Namespace Forms.Bewaking

    Public Class FormBewakingSnelheidsovertredingen

        Private _controller As ControllerGetData

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBewakingSnelheidsovertredingenLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Try
                Dim proxy As New Proxy.BBWServiceManagementServicesProxy

                _controller = New ControllerGetData
                _dataSnelheidsOvertredingenIntern.Merge(_controller.GetLijstSnelheidsovertredingen(True))
                _dataSnelheidsOvertredingenExtern.Merge(_controller.GetLijstSnelheidsovertredingen(False))

                _dataBewakingSnelheidSanction.Merge(proxy.GetSnelheidSanction)
                _dataBewakingSnelheidSanctionMatrix.Merge(proxy.GetSnelheidSanctionMatrix)

                UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
                UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

                With UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Bands(0)
                    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(Year(Today), 1, 1))
                    '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Like, "Arcelor Gent")
                    .Columns("OvertrederType").Hidden = True
                End With

                With UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Bands(0)
                    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(Year(Today), 1, 1))
                    '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.NotLike, "Arcelor Gent")
                End With

                Task.Factory.StartNew(Sub()
                                          MarkeerHogeSnelheden(UltraGridLijstSnelheidsovertredingenIntern)
                                          MarkeerHogeSnelheden(UltraGridLijstSnelheidsovertredingenExtern)
                                      End Sub)

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in FormBewakingSnelheidsovertreding (Load) " & ex.Message & vbCrLf & ex.StackTrace,
                                "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        Private Sub MarkeerHogeSnelheden(ByVal grid As UltraGrid)

            For Each row As UltraGridRow In grid.Rows
                If ((CInt(row.Cells("GeregistreerdeSnelheid").Value) - CInt(row.Cells("ToegelatenSnelheid").Value)) >= 20) Then
                    'row.Appearance.BackColor = Color.Orange
                    row.Appearance.ForeColor = Color.Red
                    row.Appearance.FontData.Bold = DefaultableBoolean.True
                    row.Tag = "70+"
                    row.Cells("70+").Value = True
                    row.Update()
                Else
                    row.Tag = "70-"
                    row.Cells("70+").Value = False
                    row.Update()
                End If
            Next
        End Sub

        ''' <summary>
        ''' Afsluiten van dit scherm.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>lawv</remarks>
        Private Sub UltraButtonSluitenClick(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonSluiten.Click
            Try
                Dispose()

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Knop 'Maak een Afdruk van een Overtreding'.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraButtonAfdrukkenClick(ByVal sender As Object, ByVal e As EventArgs) Handles UltraButtonAfdrukken.Click

            If (UltraTabControlForGrids.ActiveTab.Index = 0) Then

                If UltraGridLijstSnelheidsovertredingenIntern.ActiveRow Is Nothing Then Return
                If Not UltraGridLijstSnelheidsovertredingenIntern.ActiveRow.IsDataRow Then Return

                AfdrukSnelheidsovertreding(UltraGridLijstSnelheidsovertredingenIntern.ActiveRow)
            Else

                If UltraGridLijstSnelheidsovertredingenExtern.ActiveRow Is Nothing Then Return
                If Not UltraGridLijstSnelheidsovertredingenExtern.ActiveRow.IsDataRow Then Return

                AfdrukBriefVoorExterneFirma(UltraGridLijstSnelheidsovertredingenExtern.ActiveRow)
            End If
        End Sub

        ''' <summary>
        ''' Knop 'Open het Verslag van een Overtreding'.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraButtonOpenVerslagClick(sender As Object, e As EventArgs) Handles UltraButtonOpenVerslag.Click

            Dim grid = If(UltraTabControlForGrids.ActiveTab.Index = 0,
                          UltraGridLijstSnelheidsovertredingenIntern,
                          UltraGridLijstSnelheidsovertredingenExtern)

            If grid.ActiveRow Is Nothing Then Return
            If Not grid.ActiveRow.IsDataRow Then Return

            Dim idRegistratie = Convert.ToInt32(grid.ActiveRow.GetCellValue("RegistratieID"))
            If idRegistratie <= 0 Then Return

            Using f = New FormBewakingInbreukReglementen(idRegistratie)
                f.ShowDialog(Me)
            End Using
        End Sub

        ''' <summary>
        ''' Dubbelklik op de lijst met Internen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGridLijstSnelheidsovertredingenInternDoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridLijstSnelheidsovertredingenIntern.DoubleClickRow

            AfdrukSnelheidsovertreding(e.Row)
        End Sub

        ''' <summary>
        ''' Dubbelklik op de lijst met Externen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub UltraGridLijstSnelheidsovertredingenExternDoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles UltraGridLijstSnelheidsovertredingenExtern.DoubleClickRow

            AfdrukBriefVoorExterneFirma(e.Row)
        End Sub

        ''' <summary>
        ''' Afdrukken van de Snelheidsovertreding (of rijverbod wegens snelheidsovertreding) van de geselecteerde rij.
        ''' </summary>
        ''' <remarks>Auteur: Lawrence Verbruggen - Datum Creatie: 13/04/2011</remarks>
        Private Sub AfdrukSnelheidsovertreding(ByVal selectedRow As UltraGridRow)

            'Dim hrsProxy As HRSServiceManagementServicesProxy = New HRSServiceManagementServicesProxy()

            Try
                Using New WaitCursor(Me)

                    Dim sodieID = If(selectedRow.Cells("SoDieContactId").Value Is DBNull.Value, -1, CInt(selectedRow.Cells("SoDieContactId").Value))

                    If ((CInt(selectedRow.Cells("GeregistreerdeSnelheid").Value) - CInt(selectedRow.Cells("ToegelatenSnelheid").Value)) < 20) Then

                        ' Geregistreerde Snelheid < 70
                        ' ----------------------------
                        Using frm As New FormRapportSnelheidsOvertreding()

                            frm.RegistrationID = CInt(selectedRow.Cells("RegistratieID").Value)
                            frm.SoDieContactID = sodieID

                            If frm.ShowDialog() = DialogResult.OK Then
                                selectedRow.Cells("AfdrukTijdstip").Value = DateTime.Now
                                selectedRow.Update()
                            End If
                        End Using

                    Else
                        ' Geregistreerde Snelheid >= 70
                        ' -----------------------------
                        Using formParams As New FormBewakingRijverbodParameters()

                            If selectedRow.Cells("AfspraakPBH").Value IsNot DBNull.Value Then
                                formParams.DatumAfspraakPBH = CDate(selectedRow.Cells("AfspraakPBH").Value)
                            End If

                            If selectedRow.Cells("RijverbodVan").Value IsNot DBNull.Value Then
                                formParams.DatumRijverbodVan = CDate(selectedRow.Cells("RijverbodVan").Value)
                            End If

                            If selectedRow.Cells("RijverbodTot").Value IsNot DBNull.Value Then
                                formParams.DatumRijverbodTot = CDate(selectedRow.Cells("RijverbodTot").Value)
                            End If

                            If formParams.ShowDialog() = DialogResult.OK Then

                                If formParams.pDatesEmpty Then 'Lege datums

                                    Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                                    proxy.UpdateRijverbodLegeDatums(CInt(selectedRow.Cells("RegistratieID").Value))

                                    Using formPrintSORijverbod As New FormRapportSORijverbod()
                                        formPrintSORijverbod.RegistrationID = CInt(selectedRow.Cells("RegistratieID").Value)
                                        'formPrintSORijverbod.GetPostvak = hrsProxy.GetPostVak("StamnrOvertreder").ToString()
                                        formPrintSORijverbod.SoDieContactID = sodieID

                                        formPrintSORijverbod.ShowDialog()
                                    End Using
                                Else
                                    Dim afspraak As DateTime = formParams.DatumAfspraakPBH
                                    Dim rijverbodVan As DateTime = formParams.DatumRijverbodVan
                                    Dim rijverbodTot As DateTime = formParams.DatumRijverbodTot

                                    Dim proxy As New Proxy.BBWServiceManagementServicesProxy
                                    proxy.UpdateRijverbod(CInt(selectedRow.Cells("RegistratieID").Value), rijverbodVan, rijverbodTot, afspraak, sodieID)

                                    Using formPrintSORijverbod As New FormRapportSORijverbod()

                                        formPrintSORijverbod.RegistrationID = CInt(selectedRow.Cells("RegistratieID").Value)
                                        'formPrintSORijverbod.GetPostvak = hrsProxy.GetPostVak("StamnrOvertreder").ToString()
                                        formPrintSORijverbod.SoDieContactID = sodieID

                                        If formPrintSORijverbod.ShowDialog() = DialogResult.OK Then
                                            selectedRow.Cells("AfdrukTijdstip").Value = DateTime.Now
                                            selectedRow.Cells("RijverbodVan").Value = rijverbodVan
                                            selectedRow.Cells("RijverbodTot").Value = rijverbodTot
                                            selectedRow.Cells("AfspraakPBH").Value = afspraak
                                            selectedRow.Update()
                                        End If
                                    End Using
                                End If
                            End If
                        End Using
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Afdruk van een brief voor de externe firma van de overtreder.
        ''' </summary>
        ''' <remarks>GMAE - 30/10/2012</remarks>
        Private Sub AfdrukBriefVoorExterneFirma(ByVal selectedRow As UltraGridRow)

            Try
                Using frm As New FormBewakingSnelheidPrintExt
                    frm.RegistratieId = Convert.ToInt32(selectedRow.Cells("RegistratieID").Value)

                    If frm.ShowDialog(Me) = DialogResult.OK Then

                        Using info = _controller.GetLijstSnelheidsovertredingen(False)
                            _dataSnelheidsOvertredingenExtern.Clear()
                            _dataSnelheidsOvertredingenExtern.Merge(info)
                        End Using
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' Grid kopiëren naar clipboard
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Nancy Coppens - 19/11/2012</remarks>
        Private Sub ToolStripButtonCopy_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonCopy.Click
            Try
                Cursor = Cursors.WaitCursor
                Dim row As Infragistics.Win.UltraWinGrid.UltraGridRow

                Select Case UltraTabControlForGrids.ActiveTab.Index
                    Case 0
                        UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                        UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

                        For Each row In UltraGridLijstSnelheidsovertredingenIntern.Rows
                            row.Selected = True
                        Next row

                        UltraGridLijstSnelheidsovertredingenIntern.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

                        UltraGridLijstSnelheidsovertredingenIntern.Selected.Rows.Clear()
                        UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
                        UltraGridLijstSnelheidsovertredingenIntern.ActiveRow = UltraGridLijstSnelheidsovertredingenIntern.ActiveRowScrollRegion.FirstRow

                    Case 1
                        UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                        UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All

                        For Each row In UltraGridLijstSnelheidsovertredingenExtern.Rows
                            row.Selected = True
                        Next row

                        UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Default
                        UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                        UltraGridLijstSnelheidsovertredingenExtern.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)

                        UltraGridLijstSnelheidsovertredingenExtern.Selected.Rows.Clear()
                        UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
                        UltraGridLijstSnelheidsovertredingenExtern.ActiveRow = UltraGridLijstSnelheidsovertredingenExtern.ActiveRowScrollRegion.FirstRow

                    Case 2

                End Select

                Cursor = Cursors.Default

                MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden: " & vbCrLf & ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>Nancy Coppens - 19/11/2012</remarks>
        Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click
            Try
                _controller = New ControllerGetData

                _dataSnelheidsOvertredingenIntern.Clear()
                _dataSnelheidsOvertredingenIntern.Merge(_controller.GetLijstSnelheidsovertredingen(True))

                _dataSnelheidsOvertredingenExtern.Clear()
                _dataSnelheidsOvertredingenExtern.Merge(_controller.GetLijstSnelheidsovertredingen(False))

                UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
                UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False

                With UltraGridLijstSnelheidsovertredingenIntern.DisplayLayout.Bands(0)
                    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(Year(Today), 1, 1))
                    '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Like, "Arcelor Gent")
                    .Columns("OvertrederType").Hidden = True
                End With

                With UltraGridLijstSnelheidsovertredingenExtern.DisplayLayout.Bands(0)
                    .ColumnFilters("Tijdstip").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThanOrEqualTo, New DateTime(Year(Today), 1, 1))
                    '.ColumnFilters("OvertrederType").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.NotLike, "Arcelor Gent")
                End With

                Task.Factory.StartNew(Sub()
                                          MarkeerHogeSnelheden(UltraGridLijstSnelheidsovertredingenIntern)
                                          MarkeerHogeSnelheden(UltraGridLijstSnelheidsovertredingenExtern)
                                      End Sub)

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in FormBewakingSnelheidsovertreding - Refresh" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace,
                                "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>naco - 23/11/2012</remarks>
        Private Sub UltraTabControlForGrids_SelectedTabChanged(sender As System.Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControlForGrids.SelectedTabChanged
            Try
                Select Case UltraTabControlForGrids.SelectedTab.Index
                    Case 0, 1
                        UltraButtonAfdrukken.Enabled = True
                        UltraButtonOpenVerslag.Enabled = True
                        ToolStripButtonCopy.Enabled = True
                        ToolStripButtonRefresh.Enabled = True

                    Case 2
                        UltraButtonAfdrukken.Enabled = False
                        UltraButtonOpenVerslag.Enabled = False
                        ToolStripButtonCopy.Enabled = False
                        ToolStripButtonRefresh.Enabled = False
                End Select
            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in FormBewakingSnelheidsovertreding - UltraTabControlForGrids_SelectedTabChanged" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace,
                                "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), ReThrowOptions.PublishOnly)
            End Try
        End Sub

        Private Sub UltraGridLijstSnelheidsovertredingenExtern_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridLijstSnelheidsovertredingenExtern.InitializeLayout

        End Sub
    End Class

End Namespace

