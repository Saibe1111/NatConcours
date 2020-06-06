Public Class BilanCandidature

    Public temp As Boolean

    Private tab(getNombreCandidat()) As String
    Private tabNB(getNombreCandidat()) As String

    Private Sub BilanCandidature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonQuitter.Visible = line
        temp = False
        'on stock les donnés dans un tableau pour ensuite les trier par nom prénom
        For i = 0 To getNombreCandidat() - 1
            tab(i) = getCandidat(i).Nom + " " + getCandidat(i).Prénom + " " + CStr(getCandidat(i).Numéro)
        Next
        Array.Sort(tab)

        'On récupere les données pour les inserer dans l'ordre

        For i = 0 To getNombreCandidat() - 1
            Dim Splitage As String()
            Splitage = Split(tab(i + 1))
            Dim Num As Integer = CInt(Splitage(Splitage.Length - 1))

            For j = 0 To getNombreCandidat() - 1
                If getCandidat(j).Numéro = Num Then
                    Num = j
                    Exit For
                End If
            Next
            ComboBoxNomPrénom.Items.Add(getCandidat(Num).Nom + " " + getCandidat(Num).Prénom)
            tabNB(i) = getCandidat(Num).Numéro
        Next

        'Si on a des items on fixe par default sur le premier
        If Not ComboBoxNomPrénom.Items.Count = 0 Then
            ComboBoxNomPrénom.SelectedIndex = 0
        End If

    End Sub

    Private Sub BilanCandidature_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not temp Then
            Accueil.Show()
        End If

    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        temp = True
        Me.Close()
        Bilan.Show()
    End Sub

    Private Sub ButtonAccueil_Click(sender As Object, e As EventArgs) Handles ButtonAccueil.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxNomPrénom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNomPrénom.SelectedIndexChanged
        'On affiche le numéro
        LabelNuméro.Text = "Numéro candidat: " + tabNB(ComboBoxNomPrénom.SelectedIndex)
        Dim Num As Integer
        For j = 0 To getNombreCandidat() - 1
            If getCandidat(j).Numéro = tabNB(ComboBoxNomPrénom.SelectedIndex) Then
                Num = j
                Exit For
            End If
        Next
        'On affiche l'Age
        LabelAge.Text = "Age : " + CStr(getCandidat(Num).Age)
        'On affiche l'Adresse
        LabelAdresse.Text = "Adresse : " + getCandidat(Num).Adresse
        'On affiche la Ville
        LabelVille.Text = "Ville : " + getCandidat(Num).Ville
        'On affiche le Code postal
        LabelCP.Text = "Code postal : " + getCandidat(Num).CodePostal
        'On affiche la Région de passage
        LabelRegion.Text = "Région de passage  : " + getCandidat(Num).Region
        'On affiche les matière Oral
        Dim cpt As Integer = 0
        For Each lab In GroupBoxOral.Controls.OfType(Of Label)()
            lab.Text = getCandidat(Num).MatièreOral(cpt)
            cpt = cpt + 1
        Next lab
        'On affiche les matière ecrite
        cpt = 0
        For Each lab In GroupBoxEcrit.Controls.OfType(Of Label)()
            lab.Text = getCandidat(Num).MatièreEcrit(cpt)
            cpt = cpt + 1
        Next lab
        'On affiche l'option ou aucune si on en a pas
        LabelOptionMatière1.Text = "Option : " + getCandidat(Num).MatièreOption

    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Accueil.Close()
    End Sub
End Class