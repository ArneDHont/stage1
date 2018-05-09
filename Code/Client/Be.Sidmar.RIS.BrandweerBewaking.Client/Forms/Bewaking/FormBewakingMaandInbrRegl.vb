Option Strict On
Option Explicit On 

Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports ADF.ExceptionHandling
Imports System.Reflection

Public Class FormBewakingMaandInbrRegl
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents _dataInbreukRegl As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSLijstInbreukRegl
    Friend WithEvents UltraGridPrintDocumentInbreuken As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents UltraPrintPreviewDialogInbreuken As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents UltraGridLijstInbreuken As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lijst_InbreukReglementen", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RegistratieID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OvertrederType")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tijdstip", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Maand")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jaar")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Plaats")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ToegelatenSnelheid")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GeregistreerdeSnelheid")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artnr")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Artikel")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InbreukType")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Volgnr")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naam")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voornaam")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StamnrOvertreder")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "RegistratieID", 0, True, "Lijst_InbreukReglementen", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormBewakingMaandInbrRegl))
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me._dataInbreukRegl = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSLijstInbreukRegl
        Me.UltraGridLijstInbreuken = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGridPrintDocumentInbreuken = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.UltraPrintPreviewDialogInbreuken = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton
        CType(Me._dataInbreukRegl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridLijstInbreuken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_dataInbreukRegl
        '
        Me._dataInbreukRegl.DataSetName = "_dataInbreukRegl"
        Me._dataInbreukRegl.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraGridLijstInbreuken
        '
        Me.UltraGridLijstInbreuken.DataMember = "Lijst_InbreukReglementen"
        Me.UltraGridLijstInbreuken.DataSource = Me._dataInbreukRegl
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridLijstInbreuken.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn2.Header.VisiblePosition = 6
        UltraGridColumn2.Width = 97
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn6.Header.VisiblePosition = 10
        UltraGridColumn7.Header.Caption = "Toegelaten"
        UltraGridColumn7.Header.VisiblePosition = 13
        UltraGridColumn7.Width = 79
        UltraGridColumn8.Header.VisiblePosition = 14
        UltraGridColumn8.Width = 133
        UltraGridColumn9.Header.VisiblePosition = 11
        UltraGridColumn9.Width = 67
        UltraGridColumn10.Header.VisiblePosition = 12
        UltraGridColumn11.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Width = 78
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn13.Header.VisiblePosition = 8
        UltraGridColumn14.Header.VisiblePosition = 9
        UltraGridColumn14.Width = 77
        UltraGridColumn15.Header.Caption = "Overtreder"
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridColumn15.Width = 80
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        SummarySettings1.DisplayFormat = "Aantal = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance2
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.UltraGridLijstInbreuken.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridLijstInbreuken.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridLijstInbreuken.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridLijstInbreuken.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridLijstInbreuken.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.UltraGridLijstInbreuken.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridLijstInbreuken.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.UltraGridLijstInbreuken.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridLijstInbreuken.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.CellAppearance = Appearance9
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.RowAppearance = Appearance12
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridLijstInbreuken.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.UltraGridLijstInbreuken.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridLijstInbreuken.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridLijstInbreuken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridLijstInbreuken.Location = New System.Drawing.Point(8, 8)
        Me.UltraGridLijstInbreuken.Name = "UltraGridLijstInbreuken"
        Me.UltraGridLijstInbreuken.Size = New System.Drawing.Size(1008, 536)
        Me.UltraGridLijstInbreuken.TabIndex = 0
        Me.UltraGridLijstInbreuken.Text = "UltraGrid1"
        '
        'UltraGridPrintDocumentInbreuken
        '
        Me.UltraGridPrintDocumentInbreuken.Grid = Me.UltraGridLijstInbreuken
        '
        'UltraPrintPreviewDialogInbreuken
        '
        Me.UltraPrintPreviewDialogInbreuken.Document = Me.UltraGridPrintDocumentInbreuken
        Me.UltraPrintPreviewDialogInbreuken.Name = "UltraPrintPreviewDialogInbreuken"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBox1.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 544)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "(Opm: via filters op Maand en Jaar kan maandrapport opgevraagd worden.)"
        '
        'UltraButtonAfdrukken
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance14
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(8, 9)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(90, 23)
        Me.UltraButtonAfdrukken.TabIndex = 8
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        '
        'UltraButtonSluiten
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance15
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(916, 9)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 23)
        Me.UltraButtonSluiten.TabIndex = 7
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'FormBewakingMaandInbrRegl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 590)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UltraGridLijstInbreuken)
        Me.Name = "FormBewakingMaandInbrRegl"
        Me.Text = "Maandrapport Inbreuk reglementen"
        CType(Me._dataInbreukRegl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridLijstInbreuken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _controller As Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData

    Private Sub FormBewakingMaandInbrRegl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Doel:   Maandrapport lijst inbreuk reglementen (op vraag van Luc Van Hamme)
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            _controller = New Be.Sidmar.RIS.BrandweerBewaking.Client.ControllerGetData
            Me._dataInbreukRegl.Merge(Me._controller.GetLijstInbreuken)
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingMaandInbrRegl (Load) " & _
                             ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Fout opgetreden in FormBewakingMaandInbrRegl (Sluiten) " & _
                             ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonAfdrukken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonAfdrukken.Click
        'Doel:   Maandrapport lijst inbreuk reglementen afdrukken
        'Auteur: Nancy Coppens - 19/12/2006

        Try
            Me.UltraPrintPreviewDialogInbreuken.ShowDialog(Me.UltraGridLijstInbreuken)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridPrintDocumentinbreuken_PageFooterPrinting(ByVal sender As Object, ByVal e As Infragistics.Win.Printing.HeaderFooterPrintingEventArgs) _
            Handles UltraGridPrintDocumentInbreuken.PageFooterPrinting
        Try
            e.Section.TextRight = "Pg: " & Me.UltraGridPrintDocumentInbreuken.PageNumber
            e.Section.TextLeft = "Datum afdruk: " & Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub


    Private Sub UltraGridLijstInbreuken_InitializePrint(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs) Handles UltraGridLijstInbreuken.InitializePrint
        'Doel: instellingen voor printout
        'Auteur: Nancy Coppens - 19/12/2006
        'Gebaseerd op sample: C:\Program Files\Infragistics\NetAdvantage 2005 Volume 2\Windows Forms\Samples\WinGrid\Vb\SamplesExplorer
        Try
            e.PrintDocument.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
            e.PrintDocument.DefaultPageSettings.Landscape = True
            e.PrintDocument.DocumentName = "Lijst Bewaking: Inbreuken op reglement"
            e.DefaultLogicalPageLayoutInfo.PageHeader = "Lijst Bewaking: Inbreuken op reglement"

            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1
            e.PrintDocument.DefaultPageSettings.Margins.Left = 25
            e.PrintDocument.DefaultPageSettings.Margins.Right = 40
            e.PrintDocument.DefaultPageSettings.Margins.Top = 25
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 40

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
