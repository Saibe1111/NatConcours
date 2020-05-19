Public Class InscriptionPart1
    Dim temp As Integer
    Private Sub InscriptionPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temp = 60
        Timer.Start()
    End Sub
    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        Me.Hide()
        InscriptionPart2.Show()
        temp = -1
    End Sub

    Private Sub InscriptionPart1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
        temp = -1
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        temp = temp - 1
        Me.Text = "NatConcours - Inscription 1/2 - " + TimeOfDay + " - Fin : " + CStr(temp \ 60) + "m " + CStr(temp Mod 60) + "s"
        If temp = 0 Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
        Accueil.Show()
        temp = -1
    End Sub

    Private Sub TextBoxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNom.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBoxPrénom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrénom.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxAdresse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAdresse.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCP.KeyPress

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
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HScrollBarAge_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBarAge.ValueChanged
        LabelAgeValeur.Text = HScrollBarAge.Value
    End Sub
End Class