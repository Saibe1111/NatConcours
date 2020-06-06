Public Class InscriptionPart2
    Public temp As Integer
    Public Sub rebootTimer()
        temp = 90
    End Sub
    Private Sub InscriptionPart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rebootTimer()
        ComboBoxRegion.SelectedIndex = 0
        Timer.Start()
    End Sub

    Private Sub InscriptionPart2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        InscriptionPart1.Close()
        Accueil.Show()
        temp = -1
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Gestion du timer dans la barre
        temp = temp - 1
        Me.Text = "NatConcours - " + InscriptionPart1.type + " 2/2 - " + TimeOfDay + " - Fin : " + CStr(temp \ 60) + "m " + CStr(temp Mod 60) + "s"
        If temp = 0 Then
            Me.Close()
            MsgBox("Temps dépassé", vbExclamation, "Temps dépassé")
            Accueil.Show()
        End If
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
        InscriptionPart1.Close()
        Accueil.Show()
        temp = -1
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxGestionEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxGestionEcrit.CheckStateChanged
        If CheckBoxGestionOral.Enabled Then
            CheckBoxGestionOral.Enabled = False
        Else
            CheckBoxGestionOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxGestionOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxGestionOral.CheckStateChanged
        If CheckBoxGestionEcrit.Enabled Then
            CheckBoxGestionEcrit.Enabled = False
        Else
            CheckBoxGestionEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxRéseauEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxRéseauEcrit.CheckStateChanged
        If CheckBoxRéseauOral.Enabled Then
            CheckBoxRéseauOral.Enabled = False
        Else
            CheckBoxRéseauOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxRéseauOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxRéseauOral.CheckStateChanged
        If CheckBoxRéseauEcrit.Enabled Then
            CheckBoxRéseauEcrit.Enabled = False
        Else
            CheckBoxRéseauEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxDroitEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxDroitEcrit.CheckStateChanged
        If CheckBoxDroitOral.Enabled Then
            CheckBoxDroitOral.Enabled = False
        Else
            CheckBoxDroitOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxDroitOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxDroitOral.CheckStateChanged
        If CheckBoxDroitEcrit.Enabled Then
            CheckBoxDroitEcrit.Enabled = False
        Else
            CheckBoxDroitEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxExpressionEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxExpressionEcrit.CheckStateChanged
        If CheckBoxExpressionOral.Enabled Then
            CheckBoxExpressionOral.Enabled = False
        Else
            CheckBoxExpressionOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxExpressionOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxExpressionOral.CheckStateChanged
        If CheckBoxExpressionEcrit.Enabled Then
            CheckBoxExpressionEcrit.Enabled = False
        Else
            CheckBoxExpressionEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxMathématiquesOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxMathématiquesOral.CheckStateChanged
        If CheckBoxMathématiquesEcrit.Enabled Then
            CheckBoxMathématiquesEcrit.Enabled = False
        Else
            CheckBoxMathématiquesEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxMathématiquesEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxMathématiquesEcrit.CheckStateChanged
        If CheckBoxMathématiquesOral.Enabled Then
            CheckBoxMathématiquesOral.Enabled = False
        Else
            CheckBoxMathématiquesOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxSystèmeEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxSystèmeEcrit.CheckStateChanged
        If CheckBoxSystèmeOral.Enabled Then
            CheckBoxSystèmeOral.Enabled = False
        Else
            CheckBoxSystèmeOral.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub
    'On block le choix a l'oral ou inversement
    Private Sub CheckBoxSystèmeOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxSystèmeOral.CheckStateChanged
        If CheckBoxSystèmeEcrit.Enabled Then
            CheckBoxSystèmeEcrit.Enabled = False
        Else
            CheckBoxSystèmeEcrit.Enabled = True
        End If
        OralCompteur()
        EcritCompteur()
    End Sub

    Private cptOral As Integer = 3
    'On compte le nombre de choix restant
    Private Sub OralCompteur()
        Dim cpt As Integer = 3
        For Each check In GroupBoxOral.Controls.OfType(Of CheckBox)()
            If check.Checked Then
                If cpt = 1 Then
                    For Each check2 In GroupBoxOral.Controls.OfType(Of CheckBox)()
                        If check2.Checked = False Then
                            check2.Enabled = False
                        End If
                    Next check2
                Else
                    For Each check2 In GroupBoxOral.Controls.OfType(Of CheckBox)()
                        If check2.Checked = False Then
                            check2.Enabled = True
                            For Each check3 In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
                                If check3.Text = check2.Text And check3.Checked Then
                                    check2.Enabled = False
                                End If
                            Next check3
                        End If
                    Next check2
                End If
                cpt = cpt - 1
            End If
        Next check
        cptOral = cpt
        LabelChoixOral.Text = "Choix restants: " + CStr(cpt)
    End Sub

    Private cptEcrit As Integer = 4
    'On compte le nombre de choix restant
    Private Sub EcritCompteur()
        Dim cpt As Integer = 4
        For Each check In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
            If check.Checked Then
                If cpt = 1 Then
                    For Each check2 In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
                        If check2.Checked = False Then
                            check2.Enabled = False
                        End If
                    Next check2
                Else
                    For Each check2 In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
                        If check2.Checked = False Then
                            check2.Enabled = True
                            For Each check3 In GroupBoxOral.Controls.OfType(Of CheckBox)()
                                If check3.Text = check2.Text And check3.Checked Then
                                    check2.Enabled = False
                                End If
                            Next check3
                        End If
                    Next check2
                End If
                cpt = cpt - 1
            End If
        Next check
        cptEcrit = cpt
        LabelChoixEcrit.Text = "Choix restants: " + CStr(cpt)
    End Sub

    Private Sub CheckBoxAlgorithmiqueEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxAlgorithmiqueEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxBaseDeDonnéesEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxBaseDeDonnéesEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxLangageCEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxLangageCEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxLangageJavaEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxLangageJavaEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxProgrammationWebEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxProgrammationWebEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxVisualBasicNETEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxVisualBasicNETEcrit.CheckStateChanged
        EcritCompteur()
    End Sub

    Private Sub CheckBoxAnglaisOral_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAnglaisOral.CheckedChanged
        OralCompteur()
    End Sub

    Private Sub CheckBoxChinoisOral_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxChinoisOral.CheckedChanged
        OralCompteur()
    End Sub

    Private Sub CheckBoxEspagnolOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxEspagnolOral.CheckStateChanged
        OralCompteur()
    End Sub

    Private Sub RadioButtonOui_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOui.CheckedChanged

        ComboBoxOption.Visible = True
        GroupBoxEcrit.Enabled = False
        GroupBoxOral.Enabled = False
        'On regarde les matières inutilisé
        For Each check In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
            If check.Checked = False Then
                Dim test As Boolean = False
                For Each check2 In GroupBoxOral.Controls.OfType(Of CheckBox)()
                    If check2.Text = check.Text Then
                        If check.Checked Or check2.Checked Then
                            test = True
                        End If
                    End If
                Next check2

                If check.Checked = False And test = False Then
                    If ComboBoxOption.Items.Contains(check.Text) = False Then
                        ComboBoxOption.Items.Add(check.Text)
                    End If
                End If
            End If
        Next check
        'On regarde les matières inutilisé
        For Each check In GroupBoxOral.Controls.OfType(Of CheckBox)()
            If check.Checked = False Then
                Dim test As Boolean = False
                For Each check2 In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
                    If check2.Text = check.Text Then
                        If check.Checked Or check2.Checked Then
                            test = True
                        End If
                    End If
                Next check2
                If check.Checked = False And test = False Then
                    'On les ajoutes dans la combobox
                    If ComboBoxOption.Items.Contains(check.Text) = False Then
                        ComboBoxOption.Items.Add(check.Text)
                    End If
                End If
            End If
        Next check
    End Sub

    Private Sub RadioButtonNon_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNon.CheckedChanged
        ComboBoxOption.Visible = False
        GroupBoxEcrit.Enabled = True
        GroupBoxOral.Enabled = True
    End Sub

    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        'On vérifie que tout les champs sont réspécté
        If Not cptEcrit = 0 Or Not cptOral = 0 Or (RadioButtonOui.Checked And ComboBoxOption.Text = "") Then
            Dim MSG As String = "Des erreurs ont été détécté:" + Chr(13) + Chr(10)

            If RadioButtonOui.Checked And ComboBoxOption.Text = "" Then
                MSG = MSG + "- Choix Option" + Chr(13) + Chr(10)
            End If

            If Not cptEcrit = 0 Then
                MSG = MSG + "- Choix Ecrits insufisant" + Chr(13) + Chr(10)
            End If
            If Not cptOral = 0 Then
                MSG = MSG + "- Choix Oraux insufisant" + Chr(13) + Chr(10)
            End If
            MsgBox(MSG, vbCritical, "Erreurs détéctés")
        Else
            Me.Hide()
            Récapitulatif.Show()
            temp = -1
        End If

    End Sub
End Class