Public Class InscriptionPart2
    Dim temp As Integer
    Private Sub InscriptionPart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        temp = 90
        LabelNomAff.Text = "Nom: " + InscriptionPart1.TextBoxNom.Text
        LabelPrénomAff.Text = "Prénom: " + InscriptionPart1.TextBoxPrénom.Text
        ComboBoxRegion.SelectedIndex = 0
        Timer.Start()

    End Sub

    Private Sub InscriptionPart2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
        temp = -1
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        temp = temp - 1
        Me.Text = "NatConcours - Inscription 2/2 - " + TimeOfDay + " - Fin : " + CStr(temp \ 60) + "m " + CStr(temp Mod 60) + "s"
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

    Private Sub CheckBoxGestionEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxGestionEcrit.CheckStateChanged
        If CheckBoxGestionOral.Enabled Then
            CheckBoxGestionOral.Enabled = False
        Else
            CheckBoxGestionOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxGestionOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxGestionOral.CheckStateChanged
        If CheckBoxGestionEcrit.Enabled Then
            CheckBoxGestionEcrit.Enabled = False
        Else
            CheckBoxGestionEcrit.Enabled = True
        End If
        OralCompteur()
    End Sub

    Private Sub CheckBoxRéseauEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxRéseauEcrit.CheckStateChanged
        If CheckBoxRéseauOral.Enabled Then
            CheckBoxRéseauOral.Enabled = False
        Else
            CheckBoxRéseauOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxRéseauOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxRéseauOral.CheckStateChanged
        If CheckBoxRéseauEcrit.Enabled Then
            CheckBoxRéseauEcrit.Enabled = False
        Else
            CheckBoxRéseauEcrit.Enabled = True
        End If
        OralCompteur()
    End Sub

    Private Sub CheckBoxDroitEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxDroitEcrit.CheckStateChanged
        If CheckBoxDroitOral.Enabled Then
            CheckBoxDroitOral.Enabled = False
        Else
            CheckBoxDroitOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxDroitOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxDroitOral.CheckStateChanged
        If CheckBoxDroitEcrit.Enabled Then
            CheckBoxDroitEcrit.Enabled = False
        Else
            CheckBoxDroitEcrit.Enabled = True
        End If
        OralCompteur()
    End Sub

    Private Sub CheckBoxExpressionEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxExpressionEcrit.CheckStateChanged
        If CheckBoxExpressionOral.Enabled Then
            CheckBoxExpressionOral.Enabled = False
        Else
            CheckBoxExpressionOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxExpressionOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxExpressionOral.CheckStateChanged
        If CheckBoxExpressionEcrit.Enabled Then
            CheckBoxExpressionEcrit.Enabled = False
        Else
            CheckBoxExpressionEcrit.Enabled = True
        End If
        OralCompteur()
    End Sub

    Private Sub CheckBoxMathématiquesOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxMathématiquesOral.CheckStateChanged
        If CheckBoxMathématiquesEcrit.Enabled Then
            CheckBoxMathématiquesEcrit.Enabled = False
        Else
            CheckBoxMathématiquesEcrit.Enabled = True
        End If
        OralCompteur()
    End Sub

    Private Sub CheckBoxMathématiquesEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxMathématiquesEcrit.CheckStateChanged
        If CheckBoxMathématiquesOral.Enabled Then
            CheckBoxMathématiquesOral.Enabled = False
        Else
            CheckBoxMathématiquesOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxSystèmeEcrit_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxSystèmeEcrit.CheckStateChanged
        If CheckBoxSystèmeOral.Enabled Then
            CheckBoxSystèmeOral.Enabled = False
        Else
            CheckBoxSystèmeOral.Enabled = True
        End If
        EcritCompteur()
    End Sub

    Private Sub CheckBoxSystèmeOral_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxSystèmeOral.CheckStateChanged
        If CheckBoxSystèmeEcrit.Enabled Then
            CheckBoxSystèmeEcrit.Enabled = False
        Else
            CheckBoxSystèmeEcrit.Enabled = True
        End If

    End Sub

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
                        End If
                    Next check2
                End If
                cpt = cpt - 1
            End If
        Next check
        LabelChoixOral.Text = "Choix restants: " + CStr(cpt)
    End Sub
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
                        End If
                    Next check2
                End If
                cpt = cpt - 1
            End If
        Next check
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

        For Each check In GroupBoxEcrit.Controls.OfType(Of CheckBox)()
            If check.Checked = False Then
                ComboBoxOption.Items.Add(check.Text)
            End If
        Next check
        For Each check In GroupBoxOral.Controls.OfType(Of CheckBox)()
            If check.Checked = False Then
                If ComboBoxOption.Items.Contains(check.Text) = False Then
                    ComboBoxOption.Items.Add(check.Text)
                End If
            End If
        Next check
    End Sub

    Private Sub RadioButtonNon_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNon.CheckedChanged
        ComboBoxOption.Visible = False
        GroupBoxEcrit.Enabled = True
        GroupBoxOral.Enabled = True
    End Sub
End Class