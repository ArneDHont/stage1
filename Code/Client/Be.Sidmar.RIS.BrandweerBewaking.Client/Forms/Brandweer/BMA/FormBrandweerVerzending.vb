Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports System.Linq


Namespace Forms.Brandweer

    Public Class FormBrandweerVerzending

        Private ReadOnly _proxy As New Proxy.BBWServiceManagementServicesProxy
        Private Property Dirty As Boolean

        Public Property VerzendingId As Integer

#Region "Event Handlers"

        ''' <summary>
        ''' Form Load Event.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FormBrandweerVerzendingLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            ReadData()
        End Sub

        ''' <summary>
        ''' Save button handler.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonOpslaanClick(sender As Object, e As EventArgs) Handles ButtonOpslaan.Click
            If WriteData() Then
                DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show(Me, "Fout bij het wegschrijven van de wijzigingen!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        ''' <summary>
        ''' Cancel all pending changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonAnnuleerClick(sender As Object, e As EventArgs) Handles ButtonAnnuleer.Click
            If Dirty Then
                If MessageBox.Show(Me, "Wijzigingen annuleren?", "Annuleren", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return
                End If
            End If

            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        ''' <summary>
        ''' Search for a material item.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ButtonZoekMateriaalClick(sender As Object, e As EventArgs) Handles ButtonZoekMateriaal.Click

            Using f As New FormBrandweerMateriaalOpLocatie With {.Mode = BbwFormMode.AsSelection}

                If f.ShowDialog(Me) = DialogResult.OK Then
                    ComboBoxTypeMateriaal.SelectedValue = f.TypeMatId
                    TextBoxVolgnr.Text = CStr(f.MateriaalVolgnr)
                    LabelMateriaalOmschr.Text = f.MateriaalOmschr
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Changed any of the passive controls, set the dirty flag.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub ValueChanged(sender As Object, e As EventArgs) Handles ComboBoxLeverancier.SelectedIndexChanged, CheckBoxHerkeurd.CheckedChanged, TextBoxOpmerkingen.TextChanged, DateTimePickerDatumVerstuurd.ValueChanged, DateTimePickerDatumTerug.ValueChanged
            Dirty = True
        End Sub

#End Region

#Region "Read/Write Data"

        ''' <summary>
        ''' Read the data for an existing entry.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ReadData()

            ' Lijst metmateriaaltypes
            ' -----------------------
            If Not _dataBrandweerTypeMateriaal.BrandweerMateriaalTypes.Any() Then
                _dataBrandweerTypeMateriaal.Merge(_proxy.GetBrandweerMaterialTypes())
            End If

            ' Lijst van Leveranciers
            ' ----------------------
            If Not _dataBrandweerLeveranciers.Leverancier.Any() Then
                _dataBrandweerLeveranciers.Merge(_proxy.GetBrandweerSuppliers())
            End If

            ' Informatie Verzending
            ' ---------------------
            _dataBrandweerVerzending.Clear()

            If VerzendingId < 1 Then
                ComboBoxTypeMateriaal.SelectedIndex = -1
                TextBoxVolgnr.Text = ""
                ComboBoxLeverancier.SelectedIndex = -1
                DateTimePickerDatumVerstuurd.Value = DateTime.Today
                DateTimePickerDatumTerug.Value = Nothing
                CheckBoxHerkeurd.Checked = False
                TextBoxOpmerkingen.Text = ""

                ButtonZoekMateriaal.Visible = True

            Else
                _dataBrandweerVerzending.Merge(_proxy.GetVerzending(VerzendingId))

                Dim info As TDSBrandweerVerzending.VerzendingRow = _dataBrandweerVerzending.Verzending.First()
                ComboBoxTypeMateriaal.SelectedValue = If(info.IsTypeMatIDNull, -1, info.TypeMatID)
                TextBoxVolgnr.Text = If(info.IsMateriaalVolgNrNull(), "", CStr(info.MateriaalVolgNr))
                ComboBoxLeverancier.SelectedValue = If(info.IsLeverancierIDNull(), -1, info.LeverancierID)
                DateTimePickerDatumVerstuurd.Value = If(info.IsDatumVerstuurdNull(), Nothing, DirectCast(info.DatumVerstuurd, Object))
                DateTimePickerDatumTerug.Value = If(info.IsDatumTerugNull(), Nothing, DirectCast(info.DatumTerug, Object))
                CheckBoxHerkeurd.Checked = (Not info.IsHerkeurdYNNull()) AndAlso info.HerkeurdYN
                TextBoxOpmerkingen.Text = If(info.IsOpmerkingNull(), "", info.Opmerking)

                ButtonZoekMateriaal.Visible = False

            End If

            ' Initialise the dirty flag
            ' -------------------------
            Dirty = False
        End Sub

        ''' <summary>
        ''' Write the data to the database.
        ''' </summary>
        ''' <returns>True on success.</returns>
        ''' <remarks></remarks>
        Private Function WriteData() As Boolean
            Dim i As Integer
            Dim d As DateTime

            ' Maak een nieuwe data set
            ' ------------------------
            Dim info As New Proxy.BBWService.Mgt.TDSBrandweerVerzending
            Dim row As Proxy.BBWService.Mgt.TDSBrandweerVerzending.VerzendingRow = info.Verzending.NewVerzendingRow()

            With row
                .VerzendingID = VerzendingId

                If Integer.TryParse(CStr(ComboBoxTypeMateriaal.SelectedValue), i) Then
                    .TypeMatID = i
                Else
                    .SetTypeMatIDNull()
                End If

                If Integer.TryParse(TextBoxVolgnr.Text, i) Then
                    .MateriaalVolgNr = i
                Else
                    .SetMateriaalVolgNrNull()
                End If

                If ComboBoxLeverancier.SelectedValue Is Nothing Then
                    .SetLeverancierIDNull()
                Else
                    .LeverancierID = CInt(ComboBoxLeverancier.SelectedValue)
                End If

                If IsDBNull(DateTimePickerDatumVerstuurd.Value) OrElse Not DateTime.TryParse(CStr(DateTimePickerDatumVerstuurd.Value), d) Then
                    .SetDatumVerstuurdNull()
                Else
                    .DatumVerstuurd = d
                End If

                If IsDBNull(DateTimePickerDatumTerug.Value) OrElse Not DateTime.TryParse(CStr(DateTimePickerDatumTerug.Value), d) Then
                    .SetDatumTerugNull()
                Else
                    .DatumTerug = d
                End If

                .HerkeurdYN = CheckBoxHerkeurd.Checked
                .Opmerking = TextBoxOpmerkingen.Text
            End With

            info.Verzending.AddVerzendingRow(row)

            ' Op naar de server
            ' -----------------
            Return _proxy.StoreVerzending(info)
        End Function

#End Region

    End Class

End Namespace