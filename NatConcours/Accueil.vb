Public Class Accueil

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On ouvre le fichier d'inscription
        OuvrirInscrits()
        ' Si les inscriptions sont fermé on désactive des boutons
        If line Then
            EnregistrerButton.Enabled = False
            SupprimerButton.Enabled = False
            ModifierButton.Enabled = False
        End If

    End Sub

    Private Sub EnregistrerButton_Click(sender As Object, e As EventArgs) Handles EnregistrerButton.Click
        InscriptionPart1.Show()
        Me.Hide()
    End Sub

    Private Sub ModifierButton_Click(sender As Object, e As EventArgs) Handles ModifierButton.Click
        Modification.Show()
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
    Private Sub Accueil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not reset2 Then
            Inscription.EnregistrerInscrits()
        End If
    End Sub

    Private Sub SupprimerButton_Click(sender As Object, e As EventArgs) Handles SupprimerButton.Click
        Supprimer.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub FinButton_Click(sender As Object, e As EventArgs) Handles FinButton.Click
        'On ferme les inscriptions
        line = True
        Listing()
        Me.Hide()
        Bilan.Show()
    End Sub
    Public reset2 As Boolean = False
    Private Sub ButtonRecommencer_Click(sender As Object, e As EventArgs) Handles ButtonRecommencer.Click
        'On supprime les fichiers pour reset les inscriptions
        MsgBox("Fichier supprimé, le logiciel va ce nettoyer, relancement nécessaire !", vbInformation, "Fichier supprimé")
        Me.Close()
        Reset()
        reset2 = True
    End Sub
End Class
