<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InscriptionPart2
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InscriptionPart2))
		Me.ButtonSuivant = New System.Windows.Forms.Button()
		Me.Titre = New System.Windows.Forms.Label()
		Me.GroupBoxNomPrénom = New System.Windows.Forms.GroupBox()
		Me.LabelPrénomAff = New System.Windows.Forms.Label()
		Me.LabelNomAff = New System.Windows.Forms.Label()
		Me.ComboBoxRegion = New System.Windows.Forms.ComboBox()
		Me.GroupBoxRégion = New System.Windows.Forms.GroupBox()
		Me.LabelRégion = New System.Windows.Forms.Label()
		Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
		Me.CheckBoxVisualBasicNETEcrit = New System.Windows.Forms.CheckBox()
		Me.LabelChoixEcrit = New System.Windows.Forms.Label()
		Me.CheckBoxMathématiquesEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxExpressionEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxSystèmeEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxLangageJavaEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxDroitEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxRéseauEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxLangageCEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxBaseDeDonnéesEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxProgrammationWebEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxGestionEcrit = New System.Windows.Forms.CheckBox()
		Me.CheckBoxAlgorithmiqueEcrit = New System.Windows.Forms.CheckBox()
		Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
		Me.LabelChoixOral = New System.Windows.Forms.Label()
		Me.CheckBoxEspagnolOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxChinoisOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxAnglaisOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxMathématiquesOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxExpressionOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxSystèmeOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxDroitOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxRéseauOral = New System.Windows.Forms.CheckBox()
		Me.CheckBoxGestionOral = New System.Windows.Forms.CheckBox()
		Me.GroupBoxOption = New System.Windows.Forms.GroupBox()
		Me.RadioButtonNon = New System.Windows.Forms.RadioButton()
		Me.RadioButtonOui = New System.Windows.Forms.RadioButton()
		Me.ButtonQuitter = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.GroupBoxNomPrénom.SuspendLayout()
		Me.GroupBoxRégion.SuspendLayout()
		Me.GroupBoxEcrit.SuspendLayout()
		Me.GroupBoxOral.SuspendLayout()
		Me.GroupBoxOption.SuspendLayout()
		Me.SuspendLayout()
		'
		'ButtonSuivant
		'
		Me.ButtonSuivant.Location = New System.Drawing.Point(201, 495)
		Me.ButtonSuivant.Name = "ButtonSuivant"
		Me.ButtonSuivant.Size = New System.Drawing.Size(187, 42)
		Me.ButtonSuivant.TabIndex = 9
		Me.ButtonSuivant.Text = "Suivant"
		Me.ButtonSuivant.UseVisualStyleBackColor = True
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(57, 4)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 10
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GroupBoxNomPrénom
		'
		Me.GroupBoxNomPrénom.Controls.Add(Me.LabelPrénomAff)
		Me.GroupBoxNomPrénom.Controls.Add(Me.LabelNomAff)
		Me.GroupBoxNomPrénom.Location = New System.Drawing.Point(12, 59)
		Me.GroupBoxNomPrénom.Name = "GroupBoxNomPrénom"
		Me.GroupBoxNomPrénom.Size = New System.Drawing.Size(379, 37)
		Me.GroupBoxNomPrénom.TabIndex = 11
		Me.GroupBoxNomPrénom.TabStop = False
		'
		'LabelPrénomAff
		'
		Me.LabelPrénomAff.AutoSize = True
		Me.LabelPrénomAff.Location = New System.Drawing.Point(154, 15)
		Me.LabelPrénomAff.Name = "LabelPrénomAff"
		Me.LabelPrénomAff.Size = New System.Drawing.Size(52, 13)
		Me.LabelPrénomAff.TabIndex = 2
		Me.LabelPrénomAff.Text = "Prénom : "
		'
		'LabelNomAff
		'
		Me.LabelNomAff.AutoSize = True
		Me.LabelNomAff.Location = New System.Drawing.Point(7, 15)
		Me.LabelNomAff.Name = "LabelNomAff"
		Me.LabelNomAff.Size = New System.Drawing.Size(38, 13)
		Me.LabelNomAff.TabIndex = 0
		Me.LabelNomAff.Text = "Nom : "
		'
		'ComboBoxRegion
		'
		Me.ComboBoxRegion.FormattingEnabled = True
		Me.ComboBoxRegion.Items.AddRange(New Object() {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"})
		Me.ComboBoxRegion.Location = New System.Drawing.Point(170, 16)
		Me.ComboBoxRegion.Name = "ComboBoxRegion"
		Me.ComboBoxRegion.Size = New System.Drawing.Size(197, 21)
		Me.ComboBoxRegion.TabIndex = 12
		'
		'GroupBoxRégion
		'
		Me.GroupBoxRégion.Controls.Add(Me.LabelRégion)
		Me.GroupBoxRégion.Controls.Add(Me.ComboBoxRegion)
		Me.GroupBoxRégion.Location = New System.Drawing.Point(12, 102)
		Me.GroupBoxRégion.Name = "GroupBoxRégion"
		Me.GroupBoxRégion.Size = New System.Drawing.Size(379, 48)
		Me.GroupBoxRégion.TabIndex = 12
		Me.GroupBoxRégion.TabStop = False
		'
		'LabelRégion
		'
		Me.LabelRégion.AutoSize = True
		Me.LabelRégion.Location = New System.Drawing.Point(6, 19)
		Me.LabelRégion.Name = "LabelRégion"
		Me.LabelRégion.Size = New System.Drawing.Size(158, 13)
		Me.LabelRégion.TabIndex = 14
		Me.LabelRégion.Text = "Choix de la région de passage  :"
		'
		'GroupBoxEcrit
		'
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxVisualBasicNETEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.LabelChoixEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxMathématiquesEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxExpressionEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxSystèmeEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxLangageJavaEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxDroitEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxRéseauEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxLangageCEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxBaseDeDonnéesEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxProgrammationWebEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxGestionEcrit)
		Me.GroupBoxEcrit.Controls.Add(Me.CheckBoxAlgorithmiqueEcrit)
		Me.GroupBoxEcrit.Location = New System.Drawing.Point(13, 157)
		Me.GroupBoxEcrit.Name = "GroupBoxEcrit"
		Me.GroupBoxEcrit.Size = New System.Drawing.Size(182, 332)
		Me.GroupBoxEcrit.TabIndex = 13
		Me.GroupBoxEcrit.TabStop = False
		Me.GroupBoxEcrit.Text = "Ecrit"
		'
		'CheckBoxVisualBasicNETEcrit
		'
		Me.CheckBoxVisualBasicNETEcrit.AutoSize = True
		Me.CheckBoxVisualBasicNETEcrit.Location = New System.Drawing.Point(9, 303)
		Me.CheckBoxVisualBasicNETEcrit.Name = "CheckBoxVisualBasicNETEcrit"
		Me.CheckBoxVisualBasicNETEcrit.Size = New System.Drawing.Size(111, 17)
		Me.CheckBoxVisualBasicNETEcrit.TabIndex = 11
		Me.CheckBoxVisualBasicNETEcrit.Text = "Visual Basic .NET"
		Me.CheckBoxVisualBasicNETEcrit.UseVisualStyleBackColor = True
		'
		'LabelChoixEcrit
		'
		Me.LabelChoixEcrit.AutoSize = True
		Me.LabelChoixEcrit.Location = New System.Drawing.Point(6, 24)
		Me.LabelChoixEcrit.Name = "LabelChoixEcrit"
		Me.LabelChoixEcrit.Size = New System.Drawing.Size(79, 13)
		Me.LabelChoixEcrit.TabIndex = 15
		Me.LabelChoixEcrit.Text = "Choix restants: "
		'
		'CheckBoxMathématiquesEcrit
		'
		Me.CheckBoxMathématiquesEcrit.AutoSize = True
		Me.CheckBoxMathématiquesEcrit.Location = New System.Drawing.Point(9, 280)
		Me.CheckBoxMathématiquesEcrit.Name = "CheckBoxMathématiquesEcrit"
		Me.CheckBoxMathématiquesEcrit.Size = New System.Drawing.Size(98, 17)
		Me.CheckBoxMathématiquesEcrit.TabIndex = 10
		Me.CheckBoxMathématiquesEcrit.Text = "Mathématiques"
		Me.CheckBoxMathématiquesEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxExpressionEcrit
		'
		Me.CheckBoxExpressionEcrit.AutoSize = True
		Me.CheckBoxExpressionEcrit.Location = New System.Drawing.Point(9, 257)
		Me.CheckBoxExpressionEcrit.Name = "CheckBoxExpressionEcrit"
		Me.CheckBoxExpressionEcrit.Size = New System.Drawing.Size(77, 17)
		Me.CheckBoxExpressionEcrit.TabIndex = 9
		Me.CheckBoxExpressionEcrit.Text = "Expression"
		Me.CheckBoxExpressionEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxSystèmeEcrit
		'
		Me.CheckBoxSystèmeEcrit.AutoSize = True
		Me.CheckBoxSystèmeEcrit.Location = New System.Drawing.Point(9, 235)
		Me.CheckBoxSystèmeEcrit.Name = "CheckBoxSystèmeEcrit"
		Me.CheckBoxSystèmeEcrit.Size = New System.Drawing.Size(66, 17)
		Me.CheckBoxSystèmeEcrit.TabIndex = 8
		Me.CheckBoxSystèmeEcrit.Text = "Système"
		Me.CheckBoxSystèmeEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxLangageJavaEcrit
		'
		Me.CheckBoxLangageJavaEcrit.AutoSize = True
		Me.CheckBoxLangageJavaEcrit.Location = New System.Drawing.Point(9, 212)
		Me.CheckBoxLangageJavaEcrit.Name = "CheckBoxLangageJavaEcrit"
		Me.CheckBoxLangageJavaEcrit.Size = New System.Drawing.Size(94, 17)
		Me.CheckBoxLangageJavaEcrit.TabIndex = 7
		Me.CheckBoxLangageJavaEcrit.Text = "Langage Java"
		Me.CheckBoxLangageJavaEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxDroitEcrit
		'
		Me.CheckBoxDroitEcrit.AutoSize = True
		Me.CheckBoxDroitEcrit.Location = New System.Drawing.Point(9, 189)
		Me.CheckBoxDroitEcrit.Name = "CheckBoxDroitEcrit"
		Me.CheckBoxDroitEcrit.Size = New System.Drawing.Size(48, 17)
		Me.CheckBoxDroitEcrit.TabIndex = 6
		Me.CheckBoxDroitEcrit.Text = "Droit"
		Me.CheckBoxDroitEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxRéseauEcrit
		'
		Me.CheckBoxRéseauEcrit.AutoSize = True
		Me.CheckBoxRéseauEcrit.Location = New System.Drawing.Point(9, 166)
		Me.CheckBoxRéseauEcrit.Name = "CheckBoxRéseauEcrit"
		Me.CheckBoxRéseauEcrit.Size = New System.Drawing.Size(63, 17)
		Me.CheckBoxRéseauEcrit.TabIndex = 5
		Me.CheckBoxRéseauEcrit.Text = "Réseau"
		Me.CheckBoxRéseauEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxLangageCEcrit
		'
		Me.CheckBoxLangageCEcrit.AutoSize = True
		Me.CheckBoxLangageCEcrit.Location = New System.Drawing.Point(9, 143)
		Me.CheckBoxLangageCEcrit.Name = "CheckBoxLangageCEcrit"
		Me.CheckBoxLangageCEcrit.Size = New System.Drawing.Size(78, 17)
		Me.CheckBoxLangageCEcrit.TabIndex = 4
		Me.CheckBoxLangageCEcrit.Text = "Langage C"
		Me.CheckBoxLangageCEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxBaseDeDonnéesEcrit
		'
		Me.CheckBoxBaseDeDonnéesEcrit.AutoSize = True
		Me.CheckBoxBaseDeDonnéesEcrit.Location = New System.Drawing.Point(9, 120)
		Me.CheckBoxBaseDeDonnéesEcrit.Name = "CheckBoxBaseDeDonnéesEcrit"
		Me.CheckBoxBaseDeDonnéesEcrit.Size = New System.Drawing.Size(109, 17)
		Me.CheckBoxBaseDeDonnéesEcrit.TabIndex = 3
		Me.CheckBoxBaseDeDonnéesEcrit.Text = "Base de données"
		Me.CheckBoxBaseDeDonnéesEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxProgrammationWebEcrit
		'
		Me.CheckBoxProgrammationWebEcrit.AutoSize = True
		Me.CheckBoxProgrammationWebEcrit.Location = New System.Drawing.Point(9, 97)
		Me.CheckBoxProgrammationWebEcrit.Name = "CheckBoxProgrammationWebEcrit"
		Me.CheckBoxProgrammationWebEcrit.Size = New System.Drawing.Size(119, 17)
		Me.CheckBoxProgrammationWebEcrit.TabIndex = 2
		Me.CheckBoxProgrammationWebEcrit.Text = "Programmation web"
		Me.CheckBoxProgrammationWebEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxGestionEcrit
		'
		Me.CheckBoxGestionEcrit.AutoSize = True
		Me.CheckBoxGestionEcrit.Location = New System.Drawing.Point(9, 74)
		Me.CheckBoxGestionEcrit.Name = "CheckBoxGestionEcrit"
		Me.CheckBoxGestionEcrit.Size = New System.Drawing.Size(62, 17)
		Me.CheckBoxGestionEcrit.TabIndex = 1
		Me.CheckBoxGestionEcrit.Text = "Gestion"
		Me.CheckBoxGestionEcrit.UseVisualStyleBackColor = True
		'
		'CheckBoxAlgorithmiqueEcrit
		'
		Me.CheckBoxAlgorithmiqueEcrit.AutoSize = True
		Me.CheckBoxAlgorithmiqueEcrit.Location = New System.Drawing.Point(9, 51)
		Me.CheckBoxAlgorithmiqueEcrit.Name = "CheckBoxAlgorithmiqueEcrit"
		Me.CheckBoxAlgorithmiqueEcrit.Size = New System.Drawing.Size(89, 17)
		Me.CheckBoxAlgorithmiqueEcrit.TabIndex = 0
		Me.CheckBoxAlgorithmiqueEcrit.Text = "Algorithmique"
		Me.CheckBoxAlgorithmiqueEcrit.UseVisualStyleBackColor = True
		'
		'GroupBoxOral
		'
		Me.GroupBoxOral.Controls.Add(Me.LabelChoixOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxEspagnolOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxChinoisOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxAnglaisOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxMathématiquesOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxExpressionOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxSystèmeOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxDroitOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxRéseauOral)
		Me.GroupBoxOral.Controls.Add(Me.CheckBoxGestionOral)
		Me.GroupBoxOral.Location = New System.Drawing.Point(201, 157)
		Me.GroupBoxOral.Name = "GroupBoxOral"
		Me.GroupBoxOral.Size = New System.Drawing.Size(190, 252)
		Me.GroupBoxOral.TabIndex = 14
		Me.GroupBoxOral.TabStop = False
		Me.GroupBoxOral.Text = "Oral"
		'
		'LabelChoixOral
		'
		Me.LabelChoixOral.AutoSize = True
		Me.LabelChoixOral.Location = New System.Drawing.Point(6, 24)
		Me.LabelChoixOral.Name = "LabelChoixOral"
		Me.LabelChoixOral.Size = New System.Drawing.Size(79, 13)
		Me.LabelChoixOral.TabIndex = 16
		Me.LabelChoixOral.Text = "Choix restants: "
		'
		'CheckBoxEspagnolOral
		'
		Me.CheckBoxEspagnolOral.AutoSize = True
		Me.CheckBoxEspagnolOral.Location = New System.Drawing.Point(6, 231)
		Me.CheckBoxEspagnolOral.Name = "CheckBoxEspagnolOral"
		Me.CheckBoxEspagnolOral.Size = New System.Drawing.Size(70, 17)
		Me.CheckBoxEspagnolOral.TabIndex = 8
		Me.CheckBoxEspagnolOral.Text = "Espagnol"
		Me.CheckBoxEspagnolOral.UseVisualStyleBackColor = True
		'
		'CheckBoxChinoisOral
		'
		Me.CheckBoxChinoisOral.AutoSize = True
		Me.CheckBoxChinoisOral.Location = New System.Drawing.Point(6, 208)
		Me.CheckBoxChinoisOral.Name = "CheckBoxChinoisOral"
		Me.CheckBoxChinoisOral.Size = New System.Drawing.Size(60, 17)
		Me.CheckBoxChinoisOral.TabIndex = 7
		Me.CheckBoxChinoisOral.Text = "Chinois"
		Me.CheckBoxChinoisOral.UseVisualStyleBackColor = True
		'
		'CheckBoxAnglaisOral
		'
		Me.CheckBoxAnglaisOral.AutoSize = True
		Me.CheckBoxAnglaisOral.Location = New System.Drawing.Point(6, 185)
		Me.CheckBoxAnglaisOral.Name = "CheckBoxAnglaisOral"
		Me.CheckBoxAnglaisOral.Size = New System.Drawing.Size(60, 17)
		Me.CheckBoxAnglaisOral.TabIndex = 6
		Me.CheckBoxAnglaisOral.Text = "Anglais"
		Me.CheckBoxAnglaisOral.UseVisualStyleBackColor = True
		'
		'CheckBoxMathématiquesOral
		'
		Me.CheckBoxMathématiquesOral.AutoSize = True
		Me.CheckBoxMathématiquesOral.Location = New System.Drawing.Point(6, 162)
		Me.CheckBoxMathématiquesOral.Name = "CheckBoxMathématiquesOral"
		Me.CheckBoxMathématiquesOral.Size = New System.Drawing.Size(98, 17)
		Me.CheckBoxMathématiquesOral.TabIndex = 5
		Me.CheckBoxMathématiquesOral.Text = "Mathématiques"
		Me.CheckBoxMathématiquesOral.UseVisualStyleBackColor = True
		'
		'CheckBoxExpressionOral
		'
		Me.CheckBoxExpressionOral.AutoSize = True
		Me.CheckBoxExpressionOral.Location = New System.Drawing.Point(6, 139)
		Me.CheckBoxExpressionOral.Name = "CheckBoxExpressionOral"
		Me.CheckBoxExpressionOral.Size = New System.Drawing.Size(77, 17)
		Me.CheckBoxExpressionOral.TabIndex = 4
		Me.CheckBoxExpressionOral.Text = "Expression"
		Me.CheckBoxExpressionOral.UseVisualStyleBackColor = True
		'
		'CheckBoxSystèmeOral
		'
		Me.CheckBoxSystèmeOral.AutoSize = True
		Me.CheckBoxSystèmeOral.Location = New System.Drawing.Point(6, 116)
		Me.CheckBoxSystèmeOral.Name = "CheckBoxSystèmeOral"
		Me.CheckBoxSystèmeOral.Size = New System.Drawing.Size(66, 17)
		Me.CheckBoxSystèmeOral.TabIndex = 3
		Me.CheckBoxSystèmeOral.Text = "Système"
		Me.CheckBoxSystèmeOral.UseVisualStyleBackColor = True
		'
		'CheckBoxDroitOral
		'
		Me.CheckBoxDroitOral.AutoSize = True
		Me.CheckBoxDroitOral.Location = New System.Drawing.Point(6, 93)
		Me.CheckBoxDroitOral.Name = "CheckBoxDroitOral"
		Me.CheckBoxDroitOral.Size = New System.Drawing.Size(48, 17)
		Me.CheckBoxDroitOral.TabIndex = 2
		Me.CheckBoxDroitOral.Text = "Droit"
		Me.CheckBoxDroitOral.UseVisualStyleBackColor = True
		'
		'CheckBoxRéseauOral
		'
		Me.CheckBoxRéseauOral.AutoSize = True
		Me.CheckBoxRéseauOral.Location = New System.Drawing.Point(6, 70)
		Me.CheckBoxRéseauOral.Name = "CheckBoxRéseauOral"
		Me.CheckBoxRéseauOral.Size = New System.Drawing.Size(63, 17)
		Me.CheckBoxRéseauOral.TabIndex = 1
		Me.CheckBoxRéseauOral.Text = "Réseau"
		Me.CheckBoxRéseauOral.UseVisualStyleBackColor = True
		'
		'CheckBoxGestionOral
		'
		Me.CheckBoxGestionOral.AutoSize = True
		Me.CheckBoxGestionOral.Location = New System.Drawing.Point(6, 48)
		Me.CheckBoxGestionOral.Name = "CheckBoxGestionOral"
		Me.CheckBoxGestionOral.Size = New System.Drawing.Size(62, 17)
		Me.CheckBoxGestionOral.TabIndex = 0
		Me.CheckBoxGestionOral.Text = "Gestion"
		Me.CheckBoxGestionOral.UseVisualStyleBackColor = True
		'
		'GroupBoxOption
		'
		Me.GroupBoxOption.Controls.Add(Me.ComboBox1)
		Me.GroupBoxOption.Controls.Add(Me.RadioButtonNon)
		Me.GroupBoxOption.Controls.Add(Me.RadioButtonOui)
		Me.GroupBoxOption.Location = New System.Drawing.Point(202, 415)
		Me.GroupBoxOption.Name = "GroupBoxOption"
		Me.GroupBoxOption.Size = New System.Drawing.Size(186, 74)
		Me.GroupBoxOption.TabIndex = 17
		Me.GroupBoxOption.TabStop = False
		Me.GroupBoxOption.Text = "Option"
		'
		'RadioButtonNon
		'
		Me.RadioButtonNon.AutoSize = True
		Me.RadioButtonNon.Location = New System.Drawing.Point(91, 19)
		Me.RadioButtonNon.Name = "RadioButtonNon"
		Me.RadioButtonNon.Size = New System.Drawing.Size(45, 17)
		Me.RadioButtonNon.TabIndex = 1
		Me.RadioButtonNon.TabStop = True
		Me.RadioButtonNon.Text = "Non"
		Me.RadioButtonNon.UseVisualStyleBackColor = True
		'
		'RadioButtonOui
		'
		Me.RadioButtonOui.AutoSize = True
		Me.RadioButtonOui.Location = New System.Drawing.Point(44, 19)
		Me.RadioButtonOui.Name = "RadioButtonOui"
		Me.RadioButtonOui.Size = New System.Drawing.Size(41, 17)
		Me.RadioButtonOui.TabIndex = 0
		Me.RadioButtonOui.TabStop = True
		Me.RadioButtonOui.Text = "Oui"
		Me.RadioButtonOui.UseVisualStyleBackColor = True
		'
		'ButtonQuitter
		'
		Me.ButtonQuitter.Location = New System.Drawing.Point(10, 495)
		Me.ButtonQuitter.Name = "ButtonQuitter"
		Me.ButtonQuitter.Size = New System.Drawing.Size(185, 42)
		Me.ButtonQuitter.TabIndex = 18
		Me.ButtonQuitter.Text = "Quitter"
		Me.ButtonQuitter.UseVisualStyleBackColor = True
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(8, 41)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(172, 21)
		Me.ComboBox1.TabIndex = 2
		'
		'InscriptionPart2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(400, 549)
		Me.Controls.Add(Me.ButtonQuitter)
		Me.Controls.Add(Me.GroupBoxOral)
		Me.Controls.Add(Me.GroupBoxEcrit)
		Me.Controls.Add(Me.GroupBoxRégion)
		Me.Controls.Add(Me.GroupBoxNomPrénom)
		Me.Controls.Add(Me.Titre)
		Me.Controls.Add(Me.ButtonSuivant)
		Me.Controls.Add(Me.GroupBoxOption)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "InscriptionPart2"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Inscription 2/2 - 00:00:00"
		Me.GroupBoxNomPrénom.ResumeLayout(False)
		Me.GroupBoxNomPrénom.PerformLayout()
		Me.GroupBoxRégion.ResumeLayout(False)
		Me.GroupBoxRégion.PerformLayout()
		Me.GroupBoxEcrit.ResumeLayout(False)
		Me.GroupBoxEcrit.PerformLayout()
		Me.GroupBoxOral.ResumeLayout(False)
		Me.GroupBoxOral.PerformLayout()
		Me.GroupBoxOption.ResumeLayout(False)
		Me.GroupBoxOption.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ButtonSuivant As Button
	Friend WithEvents Titre As Label
	Friend WithEvents GroupBoxNomPrénom As GroupBox
	Friend WithEvents ComboBoxRegion As ComboBox
	Friend WithEvents GroupBoxRégion As GroupBox
	Friend WithEvents LabelRégion As Label
	Friend WithEvents LabelPrénomAff As Label
	Friend WithEvents LabelNomAff As Label
	Friend WithEvents GroupBoxEcrit As GroupBox
	Friend WithEvents CheckBoxVisualBasicNETEcrit As CheckBox
	Friend WithEvents CheckBoxMathématiquesEcrit As CheckBox
	Friend WithEvents CheckBoxExpressionEcrit As CheckBox
	Friend WithEvents CheckBoxSystèmeEcrit As CheckBox
	Friend WithEvents CheckBoxLangageJavaEcrit As CheckBox
	Friend WithEvents CheckBoxDroitEcrit As CheckBox
	Friend WithEvents CheckBoxRéseauEcrit As CheckBox
	Friend WithEvents CheckBoxLangageCEcrit As CheckBox
	Friend WithEvents CheckBoxBaseDeDonnéesEcrit As CheckBox
	Friend WithEvents CheckBoxProgrammationWebEcrit As CheckBox
	Friend WithEvents CheckBoxGestionEcrit As CheckBox
	Friend WithEvents CheckBoxAlgorithmiqueEcrit As CheckBox
	Friend WithEvents GroupBoxOral As GroupBox
	Friend WithEvents LabelChoixEcrit As Label
	Friend WithEvents LabelChoixOral As Label
	Friend WithEvents CheckBoxEspagnolOral As CheckBox
	Friend WithEvents CheckBoxChinoisOral As CheckBox
	Friend WithEvents CheckBoxAnglaisOral As CheckBox
	Friend WithEvents CheckBoxMathématiquesOral As CheckBox
	Friend WithEvents CheckBoxExpressionOral As CheckBox
	Friend WithEvents CheckBoxSystèmeOral As CheckBox
	Friend WithEvents CheckBoxDroitOral As CheckBox
	Friend WithEvents CheckBoxRéseauOral As CheckBox
	Friend WithEvents CheckBoxGestionOral As CheckBox
	Friend WithEvents GroupBoxOption As GroupBox
	Friend WithEvents RadioButtonNon As RadioButton
	Friend WithEvents RadioButtonOui As RadioButton
	Friend WithEvents ButtonQuitter As Button
	Friend WithEvents ComboBox1 As ComboBox
End Class
