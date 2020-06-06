Public Class Récapitulatif
    Private MatièreOral(3) As String
    Private MatièreEcrit(4) As String
    Private Retour As Boolean

    Private Sub Récapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If InscriptionPart1.type = "Modification" Then
            ButtonEnregistrement.Text = "Enregistrement modification"
        End If
        Retour = False
        'Initialisation des texboxs  avec les informations précédentes
        LabelNomPrénom.Text = "Nom et prénom : " + InscriptionPart1.TextBoxNom.Text + " " + InscriptionPart1.TextBoxPrénom.Text
        LabelAge.Text = "Age : " + InscriptionPart1.LabelAgeValeur.Text
        LabelAdresse.Text = "Adresse : " + InscriptionPart1.TextBoxAdresse.Text
        LabelCP.Text = "Code postal : " + InscriptionPart1.TextBoxCP.Text
        LabelVille.Text = "Ville : " + InscriptionPart1.TextBoxVille.Text
        LabelRegion.Text = "Région de passage : " + InscriptionPart2.ComboBoxRegion.Text
        'On regarde les matières oral cochés
        Dim cpt As Integer = 0
        For Each check In InscriptionPart2.GroupBoxOral.Controls.OfType(Of CheckBox)()
            If check.Checked Then
                MatièreOral(cpt) = check.Text
                cpt = cpt + 1
            End If
        Next check
        cpt = 0
        'On regarde les matières ecrit cochés
        For Each check In InscriptionPart2.GroupBoxEcrit.Controls.OfType(Of CheckBox)()
            If check.Checked Then
                MatièreEcrit(cpt) = check.Text
                cpt = cpt + 1
            End If
        Next check
        'On affiche l'option
        If InscriptionPart2.RadioButtonOui.Checked Then
            LabelOptionMatière1.Text = InscriptionPart2.ComboBoxOption.Text
        Else
            LabelOptionMatière1.Text = "Aucune"
        End If
        cpt = 0
        'On affecte les matières au label
        For Each lab In GroupBoxOral.Controls.OfType(Of Label)()
            lab.Text = MatièreOral(cpt)
            cpt = cpt + 1
        Next lab
        cpt = 0
        'On affecte les matières au label
        For Each lab In GroupBoxEcrit.Controls.OfType(Of Label)()
            lab.Text = MatièreEcrit(cpt)
            cpt = cpt + 1
        Next lab
    End Sub

    Private Sub Récapitulatif_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Retour = False Then
            Accueil.Show()
        End If
    End Sub


    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Retour = True
        Me.Close()
        InscriptionPart1.Show()
        InscriptionPart1.rebootTimer()
    End Sub

    Private Sub ButtonAnnulation_Click(sender As Object, e As EventArgs) Handles ButtonAnnulation.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub ButtonEnregistrement_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrement.Click

        If Not Modification.modif = 0 Then
            'si on à une modification on réinscrit avec les nouvelles informations et on supprime l'ancien
            InscrireCandidat(Modification.modif, InscriptionPart1.TextBoxNom.Text, InscriptionPart1.TextBoxPrénom.Text, InscriptionPart1.LabelAgeValeur.Text, InscriptionPart1.TextBoxAdresse.Text, InscriptionPart1.TextBoxCP.Text, InscriptionPart1.TextBoxVille.Text, InscriptionPart2.ComboBoxRegion.Text, MatièreOral, MatièreEcrit, LabelOptionMatière1.Text)
            SupprimerCandidat(Modification.id)
        Else
            'Sinon on inscrit simplement la personne
            InscrireCandidat(InscriptionPart1.TextBoxNom.Text, InscriptionPart1.TextBoxPrénom.Text, InscriptionPart1.LabelAgeValeur.Text, InscriptionPart1.TextBoxAdresse.Text, InscriptionPart1.TextBoxCP.Text, InscriptionPart1.TextBoxVille.Text, InscriptionPart2.ComboBoxRegion.Text, MatièreOral, MatièreEcrit, LabelOptionMatière1.Text)
            'On affiche le numéro du candidat
            MsgBox("Numéro candidat : " + CStr(getNumDernierInscrit()), vbInformation, "Numéro candidat")
        End If
        InscriptionPart1.Close()
        InscriptionPart2.Close()
        Modification.Close()
        Me.Close()
        Accueil.Show()
    End Sub
End Class