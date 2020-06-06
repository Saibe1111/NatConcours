Public Class Etat

    Private Sub Etat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On stock les matières et leurs abréviations
        Dim tabMatière() As String = {"Algorithmique", "Base de données", "Droit", "Expression",
"Gestion", "Langage C", "Langage Java", "Mathématiques",
"Programmation web", "Réseau", "Système", "Visual Basic .NET", "Anglais", "Chinois", "Espagnol"}
        Dim tabMatièreAbrév() As String = {"Alg", "Bdd", "Dro", "Exp",
"Ges", "LaC", "Jav", "Mat", "Web", "Rés", "Sys", "VBN", "Ang", "Chi", "Esp"}

        Dim tab(getNombreCandidat()) As String
        'On tri
        For i = 0 To getNombreCandidat() - 1
            tab(i) = getCandidat(i).Nom + " " + getCandidat(i).Prénom + " " + CStr(getCandidat(i).Numéro)
        Next
        Array.Sort(tab)
        'On récupère les id de l'odre alphabétique
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

            'On injecte les informations
            ListBoxNuméro.Items.Add(getCandidat(Num).Numéro)
            ListBoxNom.Items.Add(getCandidat(Num).Nom)
            ListBoxPrénom.Items.Add(getCandidat(Num).Prénom)

            Dim str As String = ""
            'On injecte les informations
            For j = 0 To 3
                For k = 0 To tabMatière.Length - 1
                    If getCandidat(Num).MatièreEcrit(j) = tabMatière(k) Then
                        str = str + tabMatièreAbrév(k) + " "
                    End If
                Next
            Next
            ListBoxMatièreEcrite.Items.Add(str)
            str = ""
            For j = 0 To 2
                For k = 0 To tabMatière.Length - 1
                    If getCandidat(Num).MatièreOral(j) = tabMatière(k) Then
                        str = str + tabMatièreAbrév(k) + " "
                    End If
                Next
            Next
            ListBoxMatièreOral.Items.Add(str)
            ListBoxMatièreFacultative.Items.Add(getCandidat(Num).MatièreOption)

        Next

    End Sub

    Private Sub Etat_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub changeIndex(num As Integer)
        'On synchronise les listbox
        ListBoxNuméro.SelectedIndex = num
        ListBoxNuméro.TopIndex = num

        ListBoxNom.SelectedIndex = num
        ListBoxNom.TopIndex = num

        ListBoxPrénom.SelectedIndex = num
        ListBoxPrénom.TopIndex = num

        ListBoxMatièreEcrite.SelectedIndex = num
        ListBoxMatièreEcrite.TopIndex = num

        ListBoxMatièreOral.SelectedIndex = num
        ListBoxMatièreOral.TopIndex = num

        ListBoxMatièreFacultative.SelectedIndex = num
        ListBoxMatièreFacultative.TopIndex = num
    End Sub

    Private Sub ListBoxNuméro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNuméro.SelectedIndexChanged

        changeIndex(ListBoxNuméro.SelectedIndex)
    End Sub

    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged
        changeIndex(ListBoxNom.SelectedIndex)
    End Sub

    Private Sub ListBoxPrénom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrénom.SelectedIndexChanged
        changeIndex(ListBoxPrénom.SelectedIndex)
    End Sub

    Private Sub ListBoxMatièreEcrite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMatièreEcrite.SelectedIndexChanged
        changeIndex(ListBoxMatièreEcrite.SelectedIndex)
    End Sub

    Private Sub ListBoxMatièreFacultative_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMatièreFacultative.SelectedIndexChanged
        changeIndex(ListBoxMatièreFacultative.SelectedIndex)
    End Sub

    Private Sub ListBoxMatièreOral_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMatièreOral.SelectedIndexChanged
        changeIndex(ListBoxMatièreOral.SelectedIndex)
    End Sub

    Private Sub ButtonAccueil_Click(sender As Object, e As EventArgs) Handles ButtonAccueil.Click
        Me.Close()
    End Sub
End Class