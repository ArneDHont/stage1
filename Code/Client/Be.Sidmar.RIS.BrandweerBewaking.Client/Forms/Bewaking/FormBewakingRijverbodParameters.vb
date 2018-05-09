Public Class FormBewakingRijverbodParameters


    Private _datumAfspraakPBH As DateTime
    Public Property DatumAfspraakPBH() As DateTime
        Get
            Return _datumAfspraakPBH
        End Get
        Set(ByVal value As DateTime)
            _datumAfspraakPBH = value
        End Set
    End Property


    Private _datumRijverbodVan As DateTime
    Public Property DatumRijverbodVan() As DateTime
        Get
            Return _datumRijverbodVan
        End Get
        Set(ByVal value As DateTime)
            _datumRijverbodVan = value
        End Set
    End Property


    Private _datumRijverbodTot As DateTime
    Public Property DatumRijverbodTot() As DateTime
        Get
            Return _datumRijverbodTot
        End Get
        Set(ByVal value As DateTime)
            _datumRijverbodTot = value
        End Set
    End Property

    Private _datesEmpty As Boolean 'toegevoegd door sidnaco 30/05/2011
    Public Property pDatesEmpty() As Boolean
        Get
            Return _datesEmpty
        End Get
        Set(ByVal value As Boolean)
            _datesEmpty = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Lawrence Verbruggen mei 2011 - aangepast door naco met radiobuttons (op vraag van Isabelle Hebbrecht)</remarks>
    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click

        If RadioButtonDatesEmpty.Checked = True Then
            Me.pDatesEmpty = True

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Hide()
        Else
            Me.pDatesEmpty = False

            If (UltraDateAfspraakPBH.Value <> Nothing And UltraDateRijverbodVan.Value <> Nothing And UltraDateRijverbodTot.Value <> Nothing) Then
                If (CDate(UltraDateAfspraakPBH.Value).Year > 1900 And CDate(UltraDateAfspraakPBH.Value).Year > 1900 And CDate(UltraDateAfspraakPBH.Value).Year > 1900) Then
                    If (CDate(UltraDateRijverbodTot.Value).Date >= CDate(UltraDateRijverbodVan.Value).Date) Then

                        Me.DatumAfspraakPBH = CDate(UltraDateAfspraakPBH.Value)
                        Me.DatumRijverbodVan = CDate(UltraDateRijverbodVan.Value)
                        Me.DatumRijverbodTot = CDate(UltraDateRijverbodTot.Value)

                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        Me.Hide()
                    Else
                        System.Windows.Forms.MessageBox.Show("De datum vanaf wanneer het rijverbod geldt, moet kleiner zijn dan de einddatum van het verbod.", "Datums Rijverbod kloppen niet", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
                    End If
                Else
                    System.Windows.Forms.MessageBox.Show("Alle datums moeten ingevuld zijn om door te gaan.", "Eén of meerdere datums niet ingevuld", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
                End If
            Else
                System.Windows.Forms.MessageBox.Show("Alle datums moeten ingevuld zijn om door te gaan.", "Eén of meerdere datums niet ingevuld", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub FormBewakingRijverbodParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DatumAfspraakPBH <> Nothing Then
            UltraDateAfspraakPBH.Value = DatumAfspraakPBH
            RadioButtonDates.Checked = True
        End If

        If DatumRijverbodVan <> Nothing Then
            UltraDateRijverbodVan.Value = DatumRijverbodVan
        End If

        If DatumRijverbodTot <> Nothing Then
            UltraDateRijverbodTot.Value = DatumRijverbodTot
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 30/05/2011</remarks>
    Private Sub RadioButtonDates_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonDates.CheckedChanged

        If RadioButtonDates.Checked = True Then
            UltraDateAfspraakPBH.Enabled = True
            UltraDateRijverbodVan.Enabled = True
            UltraDateRijverbodTot.Enabled = True
        Else
            UltraDateAfspraakPBH.Enabled = False
            UltraDateRijverbodVan.Enabled = False
            UltraDateRijverbodTot.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>naco - 30/05/2011</remarks>
    Private Sub RadioButtonDatesEmpty_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButtonDatesEmpty.CheckedChanged
        If RadioButtonDates.Checked = True Then
            UltraDateAfspraakPBH.Enabled = True
            UltraDateRijverbodVan.Enabled = True
            UltraDateRijverbodTot.Enabled = True
        Else
            UltraDateAfspraakPBH.Enabled = False
            UltraDateRijverbodVan.Enabled = False
            UltraDateRijverbodTot.Enabled = False
        End If
    End Sub
End Class