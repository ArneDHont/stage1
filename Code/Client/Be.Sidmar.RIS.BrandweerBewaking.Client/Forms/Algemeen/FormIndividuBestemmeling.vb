Imports System.Windows.Forms
Imports System.Reflection
Imports ADF.ExceptionHandling

Public Class FormIndividuBestemmeling
    Inherits System.Windows.Forms.Form

    Private _rowIndividu As TDSIndividuen.BBINDRow
    Private _hasChanged As Boolean = False


#Region "property"
    Public ReadOnly Property hasChanged() As Boolean
        Get
            Return Me._hasChanged
        End Get
    End Property
#End Region

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
    Friend WithEvents lblStamnummer As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblEmail As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnZoek As System.Windows.Forms.Button
    Friend WithEvents txtMail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtStamnummer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents btnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblStamnummer = New Infragistics.Win.Misc.UltraLabel
        Me.lblEmail = New Infragistics.Win.Misc.UltraLabel
        Me.btnZoek = New System.Windows.Forms.Button
        Me.txtMail = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtStamnummer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.txtMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStamnummer
        '
        Me.lblStamnummer.Location = New System.Drawing.Point(24, 24)
        Me.lblStamnummer.Name = "lblStamnummer"
        Me.lblStamnummer.Size = New System.Drawing.Size(100, 16)
        Me.lblStamnummer.TabIndex = 2
        Me.lblStamnummer.Text = "Stamnummer"
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(24, 48)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 16)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "E-mail"
        '
        'btnZoek
        '
        Me.btnZoek.Location = New System.Drawing.Point(328, 24)
        Me.btnZoek.Name = "btnZoek"
        Me.btnZoek.Size = New System.Drawing.Size(160, 23)
        Me.btnZoek.TabIndex = 6
        Me.btnZoek.Text = "Bestaat stamnummer?"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(144, 48)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(376, 21)
        Me.txtMail.TabIndex = 8
        '
        'txtStamnummer
        '
        Me.txtStamnummer.Location = New System.Drawing.Point(144, 24)
        Me.txtStamnummer.Name = "txtStamnummer"
        Me.txtStamnummer.Size = New System.Drawing.Size(168, 21)
        Me.txtStamnummer.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(400, 72)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Opslaan"
        '
        'FormIndividuBestemmeling
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 102)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStamnummer)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.btnZoek)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblStamnummer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormIndividuBestemmeling"
        Me.Text = "Bestemmeling"
        CType(Me.txtMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStamnummer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnZoek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoek.Click
        Try
            If Me.txtStamnummer.Value Is Nothing Then
                MsgBox("Gelieve een stamnummer in te geven.", MsgBoxStyle.Information, "Stamnummer")
            Else
                If checkIfStamnummerExists(Me.txtStamnummer.Value) = True Then
                    MsgBox("Stamnummer bestaat. (" & Me._rowIndividu.NM_IND & ")", MsgBoxStyle.Information, "Stamnummer")
                Else
                    MsgBox("Stamnummer bestaat niet.", MsgBoxStyle.Information, "Stamnummer")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub

    Private Function checkIfStamnummerExists(ByVal stamnummer As String) As Boolean
        'Opzoeken van het record van de persoon met dit stamnummer.
        Dim a As TDSIndividuen = FormManager.Current.DataIndividuen()
        Dim resulRows() As TDSIndividuen.BBINDRow = a.BBIND.Select("ID_IND = " & Me.txtStamnummer.Value)

        If resulRows.Length > 0 Then
            _rowIndividu = resulRows(0)
            Return True
        Else
            _rowIndividu = Nothing
            Return False
        End If
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Purpose:
        'Author: Dieter Vanneste - november 2006
        'Changes: naco - 02/03/2007 - test if email is filled in
        Try
            If checkIfStamnummerExists(Me.txtStamnummer.Value) = True Then
                If Len(Trim(txtMail.Text)) = 0 Then
                    MessageBox.Show("Gelieve email-adres (voornaam.naam@arcelormittal.com) in te vullen aub.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'updaten van het veld bestemmeling en e-mailadres.
                    Dim proxy As New Be.Sidmar.RIS.BrandweerBewaking.Proxy.BBWServiceManagementServicesProxy
                    proxy.updateIndividuBestemmeling(Me._rowIndividu.ID_IND, Me.txtMail.Text.Trim, System.Environment.UserName)

                    'Rij wijzigen in lokale dataset.
                    Me._rowIndividu.BST_IND = True
                    Me._rowIndividu.AD_EMAL_IND = Me.txtMail.Text.Trim
                    Me._rowIndividu.AcceptChanges()

                    Me._hasChanged = True

                    Me.Close()
                End If
            Else
                MsgBox("Stamnummer bestaat niet.", MsgBoxStyle.Information, "Stamnummer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ExceptionManager.Publish(ex, New ADF.Method(MethodBase.GetCurrentMethod), _
                                                    ReThrowOptions.PublishOnly)
        End Try
    End Sub
End Class
