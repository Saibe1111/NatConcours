Public Class InscriptionPart2
    Private Sub InscriptionPart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNomAff.Text = "Nom: " + InscriptionPart1.TextBoxNom.Text
        LabelPrénomAff.Text = "Prénom: " + InscriptionPart1.TextBoxPrénom.Text
    End Sub

    Private Sub InscriptionPart2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub
End Class