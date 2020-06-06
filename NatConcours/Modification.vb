Public Class Modification
    Private Sub Modification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On ajoute les différents inscrits
        For i As Integer = 0 To getNombreCandidat() - 1
            ComboBoxNumNomPrénom.Items.Add(getCandidat(i).Prénom + " " + getCandidat(i).Nom + " " + CStr(getCandidat(i).Numéro))
        Next


        TextBoxID.Visible = False
        modif = 0
        id = 0
    End Sub

    Private Sub Modification_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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

    Public modif As Integer
    Public id As Integer

    Private Sub ButtonMod_Click(sender As Object, e As EventArgs) Handles ButtonMod.Click

        Dim i As Integer
        If RadioButtonNuméro.Checked Then
            'On récupère le numéro 
            If TextBoxID.Text = "" Then
                'Si la textbox est vide
                MsgBox("Merci de renseigner un numéro valide", vbExclamation, "Problème")
                Exit Sub
            Else
                modif = CInt(TextBoxID.Text)
                For j = 0 To getNombreCandidat() - 1
                    If getCandidat(j).Numéro = CInt(TextBoxID.Text) Then
                        id = j
                        i = j

                    End If
                Next
            End If

        Else
            'On récupère l'identifiant
            If ComboBoxNumNomPrénom.Text = "" Then
                'Si la textbox est vide
                MsgBox("Merci de renseigner un identifiant valide", vbExclamation, "Problème")
                Exit Sub
            Else
                'On prend les ids
                Dim str As String
                For j As Integer = 0 To getNombreCandidat() - 1
                    'on regarde quel case correspond à cette combobox
                    str = (getCandidat(j).Prénom + " " + getCandidat(j).Nom + " " + CStr(getCandidat(j).Numéro))
                    If ComboBoxNumNomPrénom.Text = str Then
                        id = j
                        i = j
                        modif = getCandidat(j).Numéro
                    End If
                Next

            End If
        End If

        Try
            'Si la case existe pas on a un pb
            InscriptionPart1.TextBoxPrénom.Text = getCandidat(i).Prénom
        Catch ex As Exception
            MsgBox("Merci de renseigner un numéro valide", vbExclamation, "Problème")
            Exit Sub
        End Try


        'On affiche les formulaire
        InscriptionPart2.Show()
        InscriptionPart2.Hide()
        InscriptionPart1.Show()
        InscriptionPart1.type = "Modification"
        Me.Hide()
        'On remplis les formulaire
        InscriptionPart1.TextBoxPrénom.Text = getCandidat(i).Prénom
        InscriptionPart1.TextBoxNom.Text = getCandidat(i).Nom
        InscriptionPart1.LabelAgeValeur.Text = getCandidat(i).Age
        InscriptionPart1.HScrollBarAge.Value = getCandidat(i).Age

        InscriptionPart1.TextBoxAdresse.Text = getCandidat(i).Adresse
        InscriptionPart1.TextBoxCP.Text = getCandidat(i).CodePostal
        InscriptionPart1.TextBoxVille.Text = getCandidat(i).Ville


        InscriptionPart2.ComboBoxRegion.Text = getCandidat(i).Region
        'On remplis les formulaire
        For Each check In InscriptionPart2.GroupBoxEcrit.Controls.OfType(Of CheckBox)()
            For Each mat As String In getCandidat(i).MatièreEcrit
                If check.Text = mat Then
                    check.Checked = True
                End If
            Next mat
        Next check
        For Each check In InscriptionPart2.GroupBoxOral.Controls.OfType(Of CheckBox)()
            For Each mat As String In getCandidat(i).MatièreOral
                If check.Text = mat Then
                    check.Checked = True
                End If
            Next mat
        Next check
        'On remplis les formulaire
        If Not getCandidat(i).MatièreOption = "Aucune" Then
            InscriptionPart2.RadioButtonOui.Checked = True
            InscriptionPart2.ComboBoxOption.Text = getCandidat(i).MatièreOption
        End If


    End Sub
End Class