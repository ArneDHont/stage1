Option Strict On
Option Explicit On 

Imports System.Reflection
Imports System.Windows.Forms
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports ADF.ExceptionHandling

Public Class FormBewakingVerzekeringsfirma
    Inherits System.Windows.Forms.Form

    Private _controller As ControllerGetData
    Private _canceled As Boolean = True
    Private _idVerzFirma As Integer
    Private _verzFirma As TDSVerzFirmas.BBVZKFRMRow

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
    Friend WithEvents _dataVerzFirmas As Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas
    Friend WithEvents GroupBoxOpties As System.Windows.Forms.GroupBox
    Friend WithEvents UltraButtonAfdrukken As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonWijzig As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSelecteer As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButtonSluiten As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridVerzFirmas As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BBVZKFRM", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_FRM_VZK")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NM_FRM_VZK", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AD_FRM_VZK")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PLA_FRM_VZK")
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormBewakingVerzekeringsfirma))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me._dataVerzFirmas = New Be.Sidmar.RIS.BrandweerBewaking.Client.TDSVerzFirmas
        Me.UltraGridVerzFirmas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBoxOpties = New System.Windows.Forms.GroupBox
        Me.UltraButtonAfdrukken = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonWijzig = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSelecteer = New Infragistics.Win.Misc.UltraButton
        Me.UltraButtonSluiten = New Infragistics.Win.Misc.UltraButton
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridVerzFirmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOpties.SuspendLayout()
        Me.SuspendLayout()
        '
        '_dataVerzFirmas
        '
        Me._dataVerzFirmas.DataSetName = "TDSVerzFirmas"
        Me._dataVerzFirmas.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'UltraGridVerzFirmas
        '
        Me.UltraGridVerzFirmas.DataMember = "BBVZKFRM"
        Me.UltraGridVerzFirmas.DataSource = Me._dataVerzFirmas
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridVerzFirmas.DisplayLayout.Appearance = Appearance1
        Me.UltraGridVerzFirmas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridBand1.AddButtonCaption = "Verzekering"
        UltraGridColumn1.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn1.Header.Caption = "ID"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 52
        UltraGridColumn2.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn2.Header.Caption = "Naam"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 179
        UltraGridColumn3.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn3.Header.Caption = "Adres"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 321
        UltraGridColumn4.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        UltraGridColumn4.Header.Caption = "Plaats"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 203
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.UltraGridVerzFirmas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGridVerzFirmas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridVerzFirmas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzFirmas.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVerzFirmas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.UltraGridVerzFirmas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridVerzFirmas.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.UltraGridVerzFirmas.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridVerzFirmas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridVerzFirmas.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridVerzFirmas.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.UltraGridVerzFirmas.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.UltraGridVerzFirmas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridVerzFirmas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False
        Me.UltraGridVerzFirmas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridVerzFirmas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzFirmas.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridVerzFirmas.DisplayLayout.Override.CellAppearance = Appearance8
        Me.UltraGridVerzFirmas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridVerzFirmas.DisplayLayout.Override.CellPadding = 0
        Me.UltraGridVerzFirmas.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.UltraGridVerzFirmas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridVerzFirmas.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGridVerzFirmas.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.UltraGridVerzFirmas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridVerzFirmas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridVerzFirmas.DisplayLayout.Override.RowAppearance = Appearance11
        Me.UltraGridVerzFirmas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGridVerzFirmas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridVerzFirmas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.UltraGridVerzFirmas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridVerzFirmas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridVerzFirmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridVerzFirmas.Location = New System.Drawing.Point(8, 8)
        Me.UltraGridVerzFirmas.Name = "UltraGridVerzFirmas"
        Me.UltraGridVerzFirmas.Size = New System.Drawing.Size(776, 408)
        Me.UltraGridVerzFirmas.TabIndex = 0
        '
        'GroupBoxOpties
        '
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonAfdrukken)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonWijzig)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSelecteer)
        Me.GroupBoxOpties.Controls.Add(Me.UltraButtonSluiten)
        Me.GroupBoxOpties.Location = New System.Drawing.Point(8, 416)
        Me.GroupBoxOpties.Name = "GroupBoxOpties"
        Me.GroupBoxOpties.Size = New System.Drawing.Size(776, 48)
        Me.GroupBoxOpties.TabIndex = 7
        Me.GroupBoxOpties.TabStop = False
        Me.GroupBoxOpties.Text = "Opties"
        '
        'UltraButtonAfdrukken
        '
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Me.UltraButtonAfdrukken.Appearance = Appearance13
        Me.UltraButtonAfdrukken.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonAfdrukken.Location = New System.Drawing.Point(112, 16)
        Me.UltraButtonAfdrukken.Name = "UltraButtonAfdrukken"
        Me.UltraButtonAfdrukken.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonAfdrukken.TabIndex = 1
        Me.UltraButtonAfdrukken.Text = "Afdrukken"
        Me.UltraButtonAfdrukken.Visible = False
        '
        'UltraButtonWijzig
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Me.UltraButtonWijzig.Appearance = Appearance14
        Me.UltraButtonWijzig.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonWijzig.Location = New System.Drawing.Point(208, 16)
        Me.UltraButtonWijzig.Name = "UltraButtonWijzig"
        Me.UltraButtonWijzig.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonWijzig.TabIndex = 2
        Me.UltraButtonWijzig.Text = "Wijzig"
        Me.UltraButtonWijzig.Visible = False
        '
        'UltraButtonSelecteer
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.UltraButtonSelecteer.Appearance = Appearance15
        Me.UltraButtonSelecteer.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSelecteer.Location = New System.Drawing.Point(424, 16)
        Me.UltraButtonSelecteer.Name = "UltraButtonSelecteer"
        Me.UltraButtonSelecteer.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSelecteer.TabIndex = 3
        Me.UltraButtonSelecteer.Text = "Selecteer"
        '
        'UltraButtonSluiten
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.UltraButtonSluiten.Appearance = Appearance16
        Me.UltraButtonSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UltraButtonSluiten.ImageSize = New System.Drawing.Size(14, 14)
        Me.UltraButtonSluiten.Location = New System.Drawing.Point(520, 16)
        Me.UltraButtonSluiten.Name = "UltraButtonSluiten"
        Me.UltraButtonSluiten.Size = New System.Drawing.Size(88, 24)
        Me.UltraButtonSluiten.TabIndex = 4
        Me.UltraButtonSluiten.Text = "Sluiten"
        '
        'FormBewakingVerzekeringsfirma
        '
        Me.AcceptButton = Me.UltraButtonSelecteer
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.UltraButtonSluiten
        Me.ClientSize = New System.Drawing.Size(792, 466)
        Me.Controls.Add(Me.GroupBoxOpties)
        Me.Controls.Add(Me.UltraGridVerzFirmas)
        Me.Name = "FormBewakingVerzekeringsfirma"
        Me.Text = "Selecteer Verzekeringsfirma"
        CType(Me._dataVerzFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridVerzFirmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOpties.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Properties"
    Public ReadOnly Property Canceled() As Boolean
        Get
            Return _canceled
        End Get
    End Property
    Public ReadOnly Property Firma() As TDSVerzFirmas.BBVZKFRMRow
        Get
            Return _verzFirma
        End Get
    End Property

    Public ReadOnly Property IdFirma() As Integer
        Get
            Return _idVerzFirma
        End Get
    End Property
#End Region

    Private Sub FormBewakingVerzekeringsfirma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _controller = New ControllerGetData

            Me._dataVerzFirmas.Merge(Me._controller.GetVerzFirmas)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSelecteer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSelecteer.Click, UltraGridVerzFirmas.DoubleClick
        Try
            If UltraGridVerzFirmas.Selected.Rows.Count() <> 0 Then
                Me._idVerzFirma = CInt(UltraGridVerzFirmas.Selected.Rows(0).Cells("ID_FRM_VZK").Value)
                Me._verzFirma = Me._dataVerzFirmas.BBVZKFRM.FindByID_FRM_VZK(Me._idVerzFirma)
                Me._canceled = False
                Me.Hide()
            Else
                MessageBox.Show("Geen firma geselecteerd.", "Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraButtonSluiten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButtonSluiten.Click
        Try
            Me._canceled = True
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Sub UltraGridVerzFirmas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGridVerzFirmas.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add(SummaryType.Count, e.Layout.Bands(0).Columns("ID_FRM_VZK"))
            summary.SummaryPosition = SummaryPosition.Left
            e.Layout.Bands(0).SummaryFooterCaption = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

End Class
