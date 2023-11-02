Public Class frm_gestion
    Dim qt As ComboBox
    Dim pu As Integer
    Dim montantHT As Integer
    Dim prod As ComboBox
    Dim totalmontantHT1 As Integer
    Dim remise As Integer
    Private Sub init()
        txt_pu.Clear()
        txt_montantHT.Clear()
        lst_prod1.Text
        lst_qt.Text
        txt_totalepu1.Clear()
        txt_totalqté1.Clear()
        txt_totalmontantHT1.Clear()
        txt_TVA.Clear()
        txt_remise.Clear()
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        init()
        Me.Hide()
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        lst_prod1.Items.Remove(lst_prod1.SelectedItem)
        lst_qté1.Items.Remove(lst_qté1.SelectedItem)
        lst_pu1.Items.Remove(lst_pu1.SelectedItem)
        lst_montantHT1.Items.Remove(lst_montantHT1.SelectedItem)
    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        Dim pu As Double
        If (pu > 0) Then
            montantHT = pu * lst_qt.SelectedItem
        End If
        totalmontantHT1 = Val(txt_totalmontantHT1.Text)
        remise = totalmontantHT1 - (totalmontantHT1 * 0.01)
        If (totalmontantHT1 > 1000) Then
            remise = totalmontantHT1 * 0.01
            totalmontantHT1 = totalmontantHT1 - remise
        End If
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim prod As String
        Dim qté As String
        Dim pu As String
        lst_prod1.Text()
        lst_qté1.Text()
        prod = lst_pu1.SelectedItem
        qté = lst_qté1.SelectedItem
        pu = txt_pu.Text







    End Sub

    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_vider.Click
        init()
    End Sub
End Class