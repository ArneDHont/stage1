Option Explicit On
Option Strict On

Imports Be.Sidmar.RIS.BrandweerBewaking.Client.Helpers
Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid


Namespace Forms.Brandweer

    Public Enum BbwFormMode
        AsView
        AsSelection
    End Enum

    Public Class FormBrandweerMateriaalOpLocatie

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy

        ''' <summary>
        ''' Flag die het gedrag van de form bepaalt: een browse met editeermogelijkheden of een selectiescherm.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Mode As BbwFormMode = BbwFormMode.AsView

        ''' <summary>
        ''' Resultaat 'Type Materiaal' indien de form als selectiescherm gebruikt wordt.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TypeMatId As Integer

        ''' <summary>
        ''' Resultaat 'Materiaal Volgnummer' indien de form als selectiescherm gebruikt wordt.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MateriaalVolgnr As Integer
        Public Property MateriaalOmschr As String 'teruggeven aan scherm Verzending
        Public Property pAllowEditBrandweerYN As Boolean = False

#Region "Cache for Entry Form"

        Private _cacheMateriaalTypes As Task(Of Proxy.BBWService.Mgt.TDSBrandweerMateriaalTypes)
        Private _cacheBlustoestellen As Task(Of Proxy.BBWService.Mgt.TDSBrandweerExtinguisherTypes)
        Private _cacheLeveranciers As Task(Of Proxy.BBWService.Mgt.TDSBrandweerLeveranciers)
        Private _cacheBeheerders As Task(Of Proxy.BBWService.Mgt.TDSBrandweerBeheerderAfdeling)
        Private _cacheAfdelingen As Task(Of Proxy.BBWService.Mgt.TDSBrandweerAfdelingen)
        Private _cacheStatus As Task(Of Proxy.BBWService.Mgt.TDSBrandweerStatus)

        Private ReadOnly Property CacheMateriaalTypes As Proxy.BBWService.Mgt.TDSBrandweerMateriaalTypes
            Get
                Return _cacheMateriaalTypes.Result
            End Get
        End Property

        Private ReadOnly Property CacheBlustoestellen As Proxy.BBWService.Mgt.TDSBrandweerExtinguisherTypes
            Get
                Return _cacheBlustoestellen.Result
            End Get
        End Property

        Private ReadOnly Property CacheLeveranciers As Proxy.BBWService.Mgt.TDSBrandweerLeveranciers
            Get
                Return _cacheLeveranciers.Result
            End Get
        End Property

        Private ReadOnly Property CacheBeheerders As Proxy.BBWService.Mgt.TDSBrandweerBeheerderAfdeling
            Get
                Return _cacheBeheerders.Result
            End Get
        End Property

        Private ReadOnly Property CacheAfdelingen As Proxy.BBWService.Mgt.TDSBrandweerAfdelingen
            Get
                Return _cacheAfdelingen.Result
            End Get
        End Property

        Private ReadOnly Property CacheStatus As Proxy.BBWService.Mgt.TDSBrandweerStatus
            Get
                Return _cacheStatus.Result
            End Get
        End Property

#End Region

        Private Sub FormBrandweerMateriaalOpLocatieLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            GetMaterials()

            If Mode = BbwFormMode.AsView Then
                Text = "Overzicht Brandweer Materiaal"
                If _cacheMateriaalTypes Is Nothing Then _cacheMateriaalTypes = Task.Factory.StartNew(Function() _proxy.GetBrandweerMaterialTypes())
                If _cacheBlustoestellen Is Nothing Then _cacheBlustoestellen = Task.Factory.StartNew(Function() _proxy.GetBrandweerExtinguisherTypes())
                If _cacheLeveranciers Is Nothing Then _cacheLeveranciers = task.Factory.StartNew(Function() _proxy.GetBrandweerSuppliers())
                If _cacheBeheerders Is Nothing Then _cacheBeheerders = task.Factory.StartNew(Function() _proxy.GetBrandweerManagers())
                If _cacheAfdelingen Is Nothing Then _cacheAfdelingen = task.Factory.StartNew(Function() _proxy.GetBrandweerDepartments())
                If _cacheStatus Is Nothing Then _cacheStatus = task.Factory.StartNew(Function() _proxy.GetBrandweerStatus())

            Else 'BbwFormMode.AsSelection 'selectiemode => bij selecteren materiaal voor verzending
                Text = "Opzoeken Brandweer Materiaal - dubbelklik voor selectie materiaal"

            End If

        End Sub

        Private Sub GetMaterials()
            Try

                _dataBrandweerMateriaal.Clear()
                _dataBrandweerMateriaal.Merge(_proxy.GetBrandweerMateriaalLijst)

            Catch ex As Exception
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerMateriaalOpLocatie - GetMaterials" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "InnerException: " & ex.InnerException.ToString & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        ''' <summary>
        ''' Create a new material entry.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>GMAE - 19/08/2011</remarks>
        Private Sub ToolStripButtonNewClick(sender As Object, e As EventArgs) Handles ToolStripButtonNew.Click
            If Mode = BbwFormMode.AsView Then
                ShowEntryForm(Nothing)
            End If
        End Sub

        ''' <summary>
        ''' Edit a new material entry.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>GMAE - 19/08/2011</remarks>
        Private Sub ToolStripButtonEditClick(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
            If Mode = BbwFormMode.AsView Then
                ShowEntryForm(UltraGridMaterial.ActiveRow)
            End If
        End Sub

        ''' <summary>
        ''' Copy data of grid to clipboard (user can paste it in Excel)
        ''' </summary>
        ''' <remarks>naco - 18/08/2011</remarks>
        Private Sub ToolStripButtonCopyClipboardClick(sender As Object, e As EventArgs) Handles ToolStripButtonCopyClipboard.Click

            Using zandloper As New WaitCursor(Me)

                For Each row As UltraGridRow In UltraGridMaterial.Rows
                    row.Selected = True
                Next row

                UltraGridMaterial.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.All
                UltraGridMaterial.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.Copy)
            End Using

            MessageBox.Show("Grid is gekopieerd naar het clipboard.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ''' <summary>
        ''' Make a print-out of the 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>naco - 18/08/2011</remarks>
        Private Sub ToolStripButtonPrintClick(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click

            ' januari 2018 
            'Nancy,
            'Zoals telefonisch afgesproken , laat ik u weten welke kolommen wij graag afgedrukt zien per blad van de controlelijsten voor herkeuringen blustoestellen : 
            '•	Type
            '•	Soort
            '•	Afdeling
            '•	Zone
            '•	Nr
            '•	Locatie
            '•	Leverancier
            '•	Fabricatienummer
            '•	Volgende keuring 3
            'Dit mag eventueel recto-verso gebeuren , als het maar vlot leesbaar Is op A4.
            'Alvast bedankt, Luc Haenebalcke 
            If MessageBox.Show("Wenst u een beperkt aantal kolommen in het Afdrukvoorbeeld te tonen (leesbaarheid rapport)?", "10 kolommen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                SetColumnsHiddenInGrid(True)
                UltraPrintPreviewDialogGrid.ShowDialog(Me)
                SetColumnsHiddenInGrid(False)
            Else
                UltraPrintPreviewDialogGrid.ShowDialog(Me)
            End If

        End Sub

        Private Sub SetColumnsHiddenInGrid(ByVal blnHidden As Boolean)
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("BeheerderAfdelingNaam").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("LeveringsDatum").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("VisueleControleFreq").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("DatumVisueleKeuring").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("DatumPoederControle").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("DatumHervullingNaGebruik").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("HervullingGemeld").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("Status").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("VolgnummerAfdeling").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("MateriaalVolgnr").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("DatumHerkeuringLeverancier").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("VervangenDoor").Hidden = blnHidden
            UltraGridMaterial.DisplayLayout.Bands(0).Columns("BrandblusCodeomschr").Hidden = blnHidden
            Application.DoEvents()

        End Sub

        Private Sub UltraGridMaterialDoubleClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles UltraGridMaterial.DoubleClickCell

            If pAllowEditBrandweerYN = True Then
                Select Case Mode

                    Case BbwFormMode.AsView
                        ShowEntryForm(UltraGridMaterial.ActiveRow)

                    Case BbwFormMode.AsSelection 'selectiemode => bij selecteren materiaal voor verzending
                        Dim row As UltraGridRow = UltraGridMaterial.ActiveRow
                        If Not (row Is Nothing OrElse row.IsFilterRow) Then
                            TypeMatId = CInt(row.GetCellValue("TypeMatID"))

                            MateriaalVolgnr = CInt(row.GetCellValue("MateriaalVolgnr"))
                            MateriaalOmschr = row.GetCellValue("AfdelingCode").ToString & " - " &
                                              row.GetCellValue("LocatieZone").ToString & " - " &
                                              row.GetCellValue("LocatieNr").ToString

                            DialogResult = DialogResult.OK
                            Close()
                        End If

                End Select
            End If
        End Sub

        Private Sub UltraGridMaterialInitializePrint(sender As Object, e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridMaterial.InitializePrint
            SetupPrint(e)
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
                e.DefaultLogicalPageLayoutInfo.PageHeader = "ArcelorMittal Gent - Lijst materiaal brandweer"
                e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
                e.PrintDocument.DefaultPageSettings.Margins.Left = 25
                e.PrintDocument.DefaultPageSettings.Margins.Right = 40
                e.PrintDocument.DefaultPageSettings.Margins.Top = 25
                e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Fout opgetreden in BBW:" & vbCrLf &
                                "Form: FormBrandweerMateriaalOpLocatie - SetupPrint" & vbCrLf &
                                "Message: " & ex.Message & vbCrLf &
                                "Stacktrace: " & ex.StackTrace, "BBW Brandweer Bewaking",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub UltraGridPrintDocPageFooterPrinting(sender As Object, e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) Handles UltraGridPrintDoc.PageFooterPrinting
            e.Section.TextLeft = "Datum afdruk: " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            e.Section.TextRight = "Pg " & _UltraGridPrintDoc.PageNumber '& "/" & NrOfPages
        End Sub

        ''' <summary>
        ''' Create a list of the missing numbers is the current selection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>GMAE - 19/08/2011</remarks>
        Private Sub ToolStripButtonMissingNrClick(sender As Object, e As EventArgs) Handles ToolStripButtonMissingNr.Click

            ' Haal de Selectiecriteria
            ' ------------------------
            Dim row As UltraGridRow = UltraGridMaterial.ActiveRow

            If row Is Nothing OrElse row.IsFilterRow Then
                row = UltraGridMaterial.Rows(0)
            End If

            Dim typeMateriaalCode As Integer = CInt(row.Cells("TypeMatId").Value)
            Dim typeMateriaalNaam As String = CStr(row.Cells("TypeMatOmschr").Value).Trim
            Dim afdeling As String = CStr(row.Cells("AfdelingCode").Value).Trim
            Dim zone As String = CStr(row.Cells("LocatieZone").Value).Trim

            ' Verzamel de nummers in gebruik
            ' ------------------------------
            Dim nummers As IEnumerable(Of Integer) =
                    From record As TDSBrandweerMateriaal.BrandweerMateriaalRow In _dataBrandweerMateriaal.BrandweerMateriaal.AsQueryable
                    Where (record.TypeMatID = typeMateriaalCode AndAlso record.AfdelingCode.Trim = afdeling AndAlso record.LocatieZone.Trim = zone)
                    Select SafeToInt(record.LocatieNr)

            ' Maak de lijst van de ontbrekende nummers
            ' ----------------------------------------
            Dim max As Integer = If(nummers.Any, nummers.Max, 0)
            Dim ontbrekendeNrs As IEnumerable(Of Integer) = Enumerable.Range(1, max).Except(nummers)

            ' Toon de resultaten
            ' ------------------
            Const maxResults As Integer = 100
            Dim info As String
            If ontbrekendeNrs.Any Then

                Dim lijst As String
                If ontbrekendeNrs.Count > maxResults Then
                    lijst = String.Join(", ", ontbrekendeNrs.Take(maxResults)) & ", ..."
                Else
                    lijst = String.Join(", ", ontbrekendeNrs)
                End If

                info = String.Format("Voor de zone {0} in {1} ontbreken gegevens voor volgende {2}:{3}{3}Nummers: {4}",
                                     zone, afdeling, typeMateriaalNaam, vbCrLf, lijst)
            Else
                info = String.Format("Geen ontbrekende nummers gevonden voor de zone {0} in {1}.", zone, afdeling)
            End If

            MessageBox.Show(Me, info, "Ontbrekende Nummers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Function SafeToInt(ByVal s As String) As Integer
            Dim i As Integer
            Return If(Integer.TryParse(s, i), i, 0)
        End Function

        ''' <summary>
        ''' Create the check list.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonCheckListClick(sender As Object, e As EventArgs) Handles ToolStripButtonCheckList.Click

            Dim isVisueleControle As Boolean
            Dim vorigeControle As DateTime

            Using selectieForm As New FormBrandweerMateriaalVisueleEnPoederSelectie
                If selectieForm.ShowDialog(Me) <> DialogResult.OK Then Return
                isVisueleControle = selectieForm.IsVisueleControle
                vorigeControle = selectieForm.DatumVorigeControle
            End Using

            Using editForm As New FormBrandweerMateriaalVisueleEnPoederControle
                editForm.IsVisueleControle = isVisueleControle
                editForm.DatumVorigeControle = vorigeControle

                If editForm.ShowDialog(Me) = DialogResult.OK Then

                    Using zandloper As New Helpers.WaitCursor(Me)
                        GetMaterials()
                        UltraGridMaterial.Refresh()
                    End Using
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Show the form to add or create a material.
        ''' </summary>
        ''' <param name="row">The active row in the grid. Pass 'Nothing' for new entries.</param>
        ''' <remarks></remarks>
        Private Sub ShowEntryForm(ByVal row As UltraGridRow)

            Using form As New FormBrandweerMateriaal

                Using zandloper As New Helpers.WaitCursor(Me)
                    If Not (row Is Nothing OrElse row.IsFilterRow) Then
                        form.SetPrimaryKey(CInt(row.Cells("TypeMatId").Value), CInt(row.Cells("MateriaalVolgNr").Value))
                    End If
                    form.SetCodeTables(CacheMateriaalTypes, CacheBlustoestellen, CacheLeveranciers, CacheBeheerders, CacheAfdelingen, CacheStatus)
                End Using

                If form.ShowDialog(Me) = DialogResult.OK Then

                    Using zandloper As New Helpers.WaitCursor(Me)
                        GetMaterials()
                        UltraGridMaterial.Refresh()
                    End Using
                End If
            End Using
        End Sub

        Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMateriaal.ItemClicked

        End Sub

        Private Sub ToolStrip1_StyleChanged(sender As Object, e As System.EventArgs) Handles ToolStripMateriaal.StyleChanged

        End Sub

        Private Sub UltraGridPrintDoc_PagePrinting(sender As System.Object, e As Infragistics.Win.Printing.PagePrintingEventArgs) Handles UltraGridPrintDoc.PagePrinting

        End Sub

        Private Sub ToolStripButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRefresh.Click

            RefreshGridMateriaal()

        End Sub

        Private Sub RefreshGridMateriaal()

            'naco - 29/12/2016 - workaround om numeriek te sorteren op alfanumeriek veld LocatieNr
            Using zandloper As New Helpers.WaitCursor(Me)
                GetMaterials()

                For i As Integer = 0 To UltraGridMaterial.DisplayLayout.Bands(0).Columns.Count - 1 'deze knop werkt pas goed als alle sorteringen van de kolommen zijn weggehaald
                    UltraGridMaterial.DisplayLayout.Bands(0).Columns(i).SortIndicator = SortIndicator.None
                Next

                UltraGridMaterial.DisplayLayout.Bands(0).Columns("TypeMatOmschr").SortIndicator = SortIndicator.Ascending 'om de sortering op LocatieNr numeriek te maken
            End Using
        End Sub

        ''' <summary>
        ''' naco - 06/01/2017 - print onmiddellijk materiaalfiche (nodig om bv gebreken in te vullen op papier en mee te geven aan controlerende brandweerman)
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ToolStripButtonPrintFiche_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonPrintFiche.Click

            Dim rowMat As UltraGridRow = UltraGridMaterial.ActiveRow
            If (rowMat Is Nothing OrElse rowMat.IsFilterRow) Then
                MessageBox.Show("Gelieve een materiaalrij te selecteren aub.", "Materiaal printen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Using form As New FormBrandweerMateriaal

                Using zandloper As New Helpers.WaitCursor(Me)
                    If Not (rowMat Is Nothing OrElse rowMat.IsFilterRow) Then
                        form.SetPrimaryKey(CInt(rowMat.Cells("TypeMatId").Value), CInt(rowMat.Cells("MateriaalVolgNr").Value))
                    End If
                    form.SetCodeTables(CacheMateriaalTypes, CacheBlustoestellen, CacheLeveranciers, CacheBeheerders, CacheAfdelingen, CacheStatus)
                End Using

                form.PrintFiche()

                form.Close()

            End Using

        End Sub

        Private Sub ToolStripButtonHerkeuring_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonHerkeuring.Click
            'naco - 31/01/2017 - set filter on datum volgende keuring

            Using datumForm As New FormBMA_herkeuring
                If datumForm.ShowDialog(Me) <> DialogResult.OK Then Return

                UltraGridMaterial.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()

                'vraag van brandweer - 2 extra filters op blustoestellen en CO2 (Marnix - 27/06/2017)
                UltraGridMaterial.DisplayLayout.Bands(0).ColumnFilters("TypeMatOmschr").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains, "brandblus")
                UltraGridMaterial.DisplayLayout.Bands(0).ColumnFilters("SoortTypeMatOmschr").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains, "CO2")

                UltraGridMaterial.DisplayLayout.Bands(0).ColumnFilters("DatumVolgendeKeuring").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.LessThanOrEqualTo, _
                                           datumForm.DatumHerkeuring)

                UltraGridMaterial.DisplayLayout.Bands(0).ColumnFilters("DatumVolgendeKeuring").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.NotEquals, _
                                                           DBNull.Value)

            End Using

        End Sub


        Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
            Process.Start("http://wfdocprod.sidmar.be/docclient.hic/ShowDoc.aspx?i_chronicle_id=0900f6f0805fab32&latestflag=y")
        End Sub


        Private Sub UltraGridMaterial_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridMaterial.InitializeLayout

        End Sub

        Private Sub ToolStripButtonLogin_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonLogin.Click
            'naco - 09/02/2017

            Dim f_Login As New FormBrandweerMateriaalLogin

            f_Login.ShowDialog()

            If f_Login.pUserOK = "OK" Then
                ToolStripButtonNew.Enabled = True
                ToolStripButtonEdit.Enabled = True

                ToolStripButtonCheckList.Enabled = True
                ToolStripButtonHerkeuring.Enabled = True
                ToolStripButtonDeleteMaterial.Enabled = True

                LabelUserLogin.Text = f_Login.pUserLogin
                pAllowEditBrandweerYN = True

            Else
                ToolStripButtonNew.Enabled = False
                ToolStripButtonEdit.Enabled = False

                ToolStripButtonCheckList.Enabled = False
                ToolStripButtonHerkeuring.Enabled = False
                ToolStripButtonDeleteMaterial.Enabled = False

                LabelUserLogin.Text = ""
                pAllowEditBrandweerYN = False

            End If
        End Sub

        Private Sub ToolStripButtonDeleteMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDeleteMaterial.Click
            'naco - 10/07/2017 - op vraag van brandweer Marnix
            'DateDeleted en UserDeleted op materiaal instellen

            Dim rowMat As UltraGridRow = UltraGridMaterial.ActiveRow
            If (rowMat Is Nothing OrElse rowMat.IsFilterRow) Then
                MessageBox.Show("Gelieve een materiaalrij te selecteren aub.", "Materiaal printen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim msg As String = "Bent u zeker dat u dit materiaal wenst te verwijderen:" & vbCrLf & vbCrLf
            Dim strMsgMat As String = rowMat.Cells("TypeMatOmschr").Value.ToString & " - " & rowMat.Cells("SoortTypeMatOmschr").Value.ToString & vbCrLf &
                rowMat.Cells("AfdelingCode").Value.ToString & " - " & rowMat.Cells("LocatieZone").Value.ToString & " - " & rowMat.Cells("LocatieNr").Value.ToString & vbCrLf &
                rowMat.Cells("LocatieOmschr").Value.ToString

            If MessageBox.Show(msg & strMsgMat, "Verwijderen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                If _proxy.UpdateMateriaalDateDeleted(CInt(rowMat.Cells("TypeMatId").Value), CInt(rowMat.Cells("MateriaalVolgNr").Value), System.Environment.UserName) = False Then
                    MessageBox.Show("Fout opgetreden bij instellen DateDeleted voor materiaal: " & vbCrLf & vbCrLf & strMsgMat & ".", "DateDeleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    RefreshGridMateriaal()
                End If

            End If

        End Sub
    End Class

End Namespace