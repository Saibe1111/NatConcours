Public Class InscriptionPart1
    Private Sub InscriptionPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        Me.Hide()
        InscriptionPart2.Show()
    End Sub

    Private Sub InscriptionPart1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub
End Class