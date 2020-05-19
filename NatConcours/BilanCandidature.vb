Public Class BilanCandidature
    Private Sub BilanCandidature_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To getNombreCandidat() - 1
            ComboBoxNomPrénom.Items.Add(getCandidat(i).Nom + " " + getCandidat(i).Prénom)
        Next



    End Sub

    Private Sub BilanCandidature_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub ComboBoxNomPrénom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNomPrénom.SelectedIndexChanged

    End Sub
End Class