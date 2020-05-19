Public Class Bilan

    Private Sub Bilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bilan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If ButtonQuitter.Visible = False Then
            Accueil.Show()
        Else
            Accueil.Close()
        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Accueil.Close()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Accueil.Show()
    End Sub

    Private Sub ButtonIndiv_Click(sender As Object, e As EventArgs) Handles ButtonIndiv.Click
        Me.Hide()
        BilanCandidature.Show()
    End Sub

    Private Sub ButtonMatière_Click(sender As Object, e As EventArgs) Handles ButtonMatière.Click
        Me.Hide()
        BilanMatière.Show()
    End Sub
End Class