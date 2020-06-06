Public Class BilanMatière

    Public temp As Boolean

    Private Sub BilanMatière_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On affiche des boutons si on est dans le bilan final
        ButtonQuitter.Visible = line
        temp = False
        ButtonQuitter.Visible = line
        ComboBoxMatière.SelectedIndex = 0
    End Sub

    Private Sub BilanMatière_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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

    Private Sub ComboBoxMatière_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMatière.SelectedIndexChanged
        'On vide les textboxs 
        ListBoxNuméro.Items.Clear()
        ListBoxNom.Items.Clear()
        ListBoxPrénom.Items.Clear()
        ListBoxRegion.Items.Clear()
        'On tri par région , nom ,prénom
        Dim tab(getNombreCandidat()) As String
        For i = 0 To getNombreCandidat() - 1
            tab(i) = getCandidat(i).Region + " " + getCandidat(i).Nom + " " + getCandidat(i).Prénom + " " + CStr(getCandidat(i).Numéro)
        Next
        Array.Sort(tab)
        'On récupère le tri et on l'inject dans l'ordre dans les textbox
        For i = 0 To getNombreCandidat() - 1
            Dim Splitage As String()
            Splitage = Split(tab(i + 1))
            Dim Num As Integer = CInt(Splitage(Splitage.Length - 1))
            'récupération du candidat
            For j = 0 To getNombreCandidat() - 1
                If getCandidat(j).Numéro = Num Then
                    Num = j
                    Exit For
                End If
            Next
            'On regarde si il a la matière
            Dim oui As Boolean = False
            For Each oral As String In getCandidat(Num).MatièreEcrit()
                If oral = ComboBoxMatière.Text Then
                    oui = True
                End If
            Next
            For Each oral As String In getCandidat(Num).MatièreOral()
                If oral = ComboBoxMatière.Text Then
                    oui = True
                End If
            Next
            If getCandidat(Num).MatièreOption = ComboBoxMatière.Text Then
                oui = True
            End If
            'On injecte dans les listboxs
            If oui Then
                ListBoxNuméro.Items.Add(getCandidat(Num).Numéro)
                ListBoxNom.Items.Add(getCandidat(Num).Nom)
                ListBoxPrénom.Items.Add(getCandidat(Num).Prénom)
                ListBoxRegion.Items.Add(getCandidat(Num).Region)
            End If

        Next
    End Sub

    Private Sub ListBoxNuméro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNuméro.SelectedIndexChanged
        changeIndex(ListBoxNuméro.SelectedIndex)
    End Sub

    Private Sub changeIndex(num As Integer)
        'On synchronise les listbox
        ListBoxNuméro.SelectedIndex = num
        ListBoxNuméro.TopIndex = num

        ListBoxNom.SelectedIndex = num
        ListBoxNom.TopIndex = num

        ListBoxPrénom.SelectedIndex = num
        ListBoxPrénom.TopIndex = num

        ListBoxRegion.SelectedIndex = num
        ListBoxRegion.TopIndex = num
    End Sub

    Private Sub ListBoxRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRegion.SelectedIndexChanged
        changeIndex(ListBoxRegion.SelectedIndex)
    End Sub

    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged
        changeIndex(ListBoxNom.SelectedIndex)
    End Sub

    Private Sub ListBoxPrénom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrénom.SelectedIndexChanged
        changeIndex(ListBoxPrénom.SelectedIndex)
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Accueil.Close()
    End Sub
End Class