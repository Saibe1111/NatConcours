Public Class InscriptionPart1
    Public temp As Integer
    Public type As String = "Inscription"

    Public Sub rebootTimer()
        temp = 60
    End Sub

    Private Sub InscriptionPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rebootTimer()
        Timer.Start()
    End Sub
    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click

        InscriptionPart2.LabelNomAff.Text = "Nom: " + TextBoxNom.Text
        InscriptionPart2.LabelPrénomAff.Text = "Prénom: " + TextBoxPrénom.Text

        'On vérifie que tout les champs sont réspécté
        If TextBoxNom.Text = "" Or TextBoxPrénom.Text = "" Or Not Len(TextBoxCP.Text) = 5 Or TextBoxAdresse.Text = "" Or TextBoxCP.Text = "" Or TextBoxVille.Text = "" Then
            Dim MSG As String = "Des erreurs ont été détécté dans les champs suivant:" + Chr(13) + Chr(10)

            If TextBoxNom.Text = "" Then
                MSG = MSG + "- Nom" + Chr(13) + Chr(10)
            End If

            If TextBoxPrénom.Text = "" Then
                MSG = MSG + "- Prénom" + Chr(13) + Chr(10)
            End If

            If TextBoxAdresse.Text = "" Then
                MSG = MSG + "- Adresse" + Chr(13) + Chr(10)
            End If

            If TextBoxCP.Text = "" Or Not Len(TextBoxCP.Text) = 5 Then
                MSG = MSG + "- Code postal" + Chr(13) + Chr(10)
            End If

            If TextBoxVille.Text = "" Then
                MSG = MSG + "- Ville"
            End If
            MsgBox(MSG, vbCritical, "Erreurs détéctés")
        Else
            'si tout est respecté
            Me.Hide()
            InscriptionPart2.Show()
            temp = -1
            InscriptionPart2.rebootTimer()
        End If
    End Sub

    Private Sub InscriptionPart1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
        temp = -1
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Gestion du timer dans la barre
        temp = temp - 1
        Me.Text = "NatConcours - " + type + " 1/2 - " + TimeOfDay + " - Fin : " + CStr(temp \ 60) + "m " + CStr(temp Mod 60) + "s"
        If temp = 0 Then
            Me.Close()
            MsgBox("Temps dépassé", vbExclamation, "Temps dépassé")
            Accueil.Show()

        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
        Accueil.Show()
        InscriptionPart2.Close()
        temp = -1
    End Sub

    Private Sub TextBoxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNom.KeyPress
        'on interdit certaine saisie
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBoxPrénom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrénom.KeyPress
        'on interdit certaine saisie
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxAdresse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAdresse.KeyPress
        'on interdit certaine saisie
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCP.KeyPress
        'on interdit certaine saisie
        If Len(TextBoxCP.Text) = 1 And TextBoxCP.Text = "0" Then
            If e.KeyChar = "0" Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxVille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxVille.KeyPress
        'on interdit certaine saisie
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HScrollBarAge_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBarAge.ValueChanged
        LabelAgeValeur.Text = HScrollBarAge.Value
    End Sub

    Private Sub HScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarAge.Scroll

    End Sub
End Class