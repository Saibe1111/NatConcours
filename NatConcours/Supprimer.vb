Public Class Supprimer
    Private Sub Supprimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On ajoute les différents inscrits
        For i As Integer = 0 To getNombreCandidat() - 1
            ComboBoxNumNomPrénom.Items.Add(getCandidat(i).Prénom + " " + getCandidat(i).Nom + " " + CStr(getCandidat(i).Numéro))
        Next
    End Sub

    Private Sub Supprimer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click

        If RadioButtonNuméro.Checked Then
            For i As Integer = 0 To getNombreCandidat() - 1
                'on regarde quel case correspond à cette combobox
                If TextBoxID.Text = CStr(getCandidat(i).Numéro) Then
                    Dim msg As String = "Confirmez-vous la suppression des informations de ce candidat ? " + Chr(13) + Chr(10)
                    msg = msg + "Numéro: " + CStr(getCandidat(i).Numéro) + Chr(13) + Chr(10)
                    msg = msg + "Nom: " + getCandidat(i).Nom + Chr(13) + Chr(10)
                    msg = msg + "Prénom: " + getCandidat(i).Prénom + Chr(13) + Chr(10)
                    msg = msg + "Age: " + CStr(getCandidat(i).Age) + Chr(13) + Chr(10)
                    msg = msg + "Adresse: " + getCandidat(i).Adresse + Chr(13) + Chr(10)
                    msg = msg + "Code Postal: " + getCandidat(i).CodePostal + Chr(13) + Chr(10)
                    msg = msg + "Ville: " + getCandidat(i).Ville + Chr(13) + Chr(10)
                    msg = msg + "Région de passage : " + getCandidat(i).Region + Chr(13) + Chr(10)
                    msg = msg + "Matières écrites: "
                    For Each mat In getCandidat(i).MatièreEcrit
                        msg = msg + mat
                    Next
                    msg = msg + Chr(13) + Chr(10)
                    msg = msg + "Matières Orals: "
                    For Each mat In getCandidat(i).MatièreOral
                        msg = msg + mat
                    Next
                    msg = msg + Chr(13) + Chr(10)
                    msg = msg + "Matière facultative: " + getCandidat(i).MatièreOption + Chr(13) + Chr(10)
                    Dim rep
                    rep = MsgBox(msg, vbQuestion + vbYesNo, "Supression")

                    If rep = vbYes Then
                        'On supprime
                        SupprimerCandidat(i)
                    End If
                    Exit For
                End If
            Next
        Else
            'On supprime l'inscription selon la combobox
            Dim str As String
            For i As Integer = 0 To getNombreCandidat() - 1
                'on regarde quel case correspond à cette combobox
                str = (getCandidat(i).Prénom + " " + getCandidat(i).Nom + " " + CStr(getCandidat(i).Numéro))
                If ComboBoxNumNomPrénom.Text = str Then
                    Dim msg As String = "Confirmez-vous la suppression des informations de ce candidat ? " + Chr(13) + Chr(10)
                    msg = msg + "Numéro: " + CStr(getCandidat(i).Numéro) + Chr(13) + Chr(10)
                    msg = msg + "Nom: " + getCandidat(i).Nom + Chr(13) + Chr(10)
                    msg = msg + "Prénom: " + getCandidat(i).Prénom + Chr(13) + Chr(10)
                    msg = msg + "Age: " + CStr(getCandidat(i).Age) + Chr(13) + Chr(10)
                    msg = msg + "Adresse: " + getCandidat(i).Adresse + Chr(13) + Chr(10)
                    msg = msg + "Code Postal: " + getCandidat(i).CodePostal + Chr(13) + Chr(10)
                    msg = msg + "Ville: " + getCandidat(i).Ville + Chr(13) + Chr(10)
                    msg = msg + "Région de passage : " + getCandidat(i).Region + Chr(13) + Chr(10)
                    msg = msg + "Matières écrites: "
                    For Each mat In getCandidat(i).MatièreEcrit
                        msg = msg + mat + " "
                    Next
                    msg = msg + Chr(13) + Chr(10)
                    msg = msg + "Matières Orals: "
                    For Each mat In getCandidat(i).MatièreOral
                        msg = msg + mat + " "
                    Next
                    msg = msg + Chr(13) + Chr(10)
                    msg = msg + "Matière facultative: " + getCandidat(i).MatièreOption + Chr(13) + Chr(10)
                    Dim rep
                    rep = MsgBox(msg, vbQuestion + vbYesNo, "Supression")

                    If rep = vbYes Then
                        'On supprime
                        SupprimerCandidat(i)
                    End If

                    Exit For
                End If
            Next
        End If
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub RadioButtonNuméro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNuméro.CheckedChanged
        LabelType.Text = "Numéro: "
        ComboBoxNumNomPrénom.Visible = False
        TextBoxID.Visible = True
    End Sub

    Private Sub RadioButtonIdentifiant_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIdentifiant.CheckedChanged
        LabelType.Text = "Identifiant: "
        ComboBoxNumNomPrénom.Visible = True
        TextBoxID.Visible = False

    End Sub
End Class