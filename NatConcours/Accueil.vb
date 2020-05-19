Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OuvrirInscrits()
    End Sub

    Private Sub EnregistrerButton_Click(sender As Object, e As EventArgs) Handles EnregistrerButton.Click
        InscriptionPart1.Show()
        Me.Hide()
    End Sub

    Private Sub ModifierButton_Click(sender As Object, e As EventArgs) Handles ModifierButton.Click
        InscriptionPart1.Show()
        Me.Hide()
    End Sub

    Private Sub EtatButton_Click(sender As Object, e As EventArgs) Handles EtatButton.Click
        Etat.Show()
        Me.Hide()
    End Sub

    Private Sub BilanButton_Click(sender As Object, e As EventArgs) Handles BilanButton.Click
        Bilan.Show()
        Me.Hide()
    End Sub

    Private Sub FinButton_Click(sender As Object, e As EventArgs) Handles FinButton.Click
        Bilan.ButtonQuitter.Visible = True
        Bilan.Show()
        Me.Hide()
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
        Inscription.EnregistrerInscrits()
    End Sub
End Class
