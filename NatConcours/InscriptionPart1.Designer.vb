<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InscriptionPart1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InscriptionPart1))
		Me.PersonneGroup = New System.Windows.Forms.GroupBox()
		Me.HScrollBarAge = New System.Windows.Forms.HScrollBar()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.TextBoxAge = New System.Windows.Forms.TextBox()
		Me.LabelPrénom = New System.Windows.Forms.Label()
		Me.TextBoxNom = New System.Windows.Forms.TextBox()
		Me.TextBoxPrénom = New System.Windows.Forms.TextBox()
		Me.LabelNom = New System.Windows.Forms.Label()
		Me.AdresseGroup = New System.Windows.Forms.GroupBox()
		Me.TextBoxVille = New System.Windows.Forms.TextBox()
		Me.LabelVille = New System.Windows.Forms.Label()
		Me.TextBoxAdresse = New System.Windows.Forms.TextBox()
		Me.LabelAdresse = New System.Windows.Forms.Label()
		Me.TextBoxCP = New System.Windows.Forms.TextBox()
		Me.LabelCP = New System.Windows.Forms.Label()
		Me.ButtonSuivant = New System.Windows.Forms.Button()
		Me.Titre = New System.Windows.Forms.Label()
		Me.ButtonQuitter = New System.Windows.Forms.Button()
		Me.PersonneGroup.SuspendLayout()
		Me.AdresseGroup.SuspendLayout()
		Me.SuspendLayout()
		'
		'PersonneGroup
		'
		Me.PersonneGroup.Controls.Add(Me.HScrollBarAge)
		Me.PersonneGroup.Controls.Add(Me.LabelAge)
		Me.PersonneGroup.Controls.Add(Me.TextBoxAge)
		Me.PersonneGroup.Controls.Add(Me.LabelPrénom)
		Me.PersonneGroup.Controls.Add(Me.TextBoxNom)
		Me.PersonneGroup.Controls.Add(Me.TextBoxPrénom)
		Me.PersonneGroup.Controls.Add(Me.LabelNom)
		Me.PersonneGroup.Location = New System.Drawing.Point(8, 54)
		Me.PersonneGroup.Name = "PersonneGroup"
		Me.PersonneGroup.Size = New System.Drawing.Size(196, 106)
		Me.PersonneGroup.TabIndex = 0
		Me.PersonneGroup.TabStop = False
		'
		'HScrollBarAge
		'
		Me.HScrollBarAge.Location = New System.Drawing.Point(61, 71)
		Me.HScrollBarAge.Name = "HScrollBarAge"
		Me.HScrollBarAge.Size = New System.Drawing.Size(123, 20)
		Me.HScrollBarAge.TabIndex = 7
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(6, 74)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(32, 13)
		Me.LabelAge.TabIndex = 6
		Me.LabelAge.Text = "Age :"
		'
		'TextBoxAge
		'
		Me.TextBoxAge.Location = New System.Drawing.Point(38, 71)
		Me.TextBoxAge.Name = "TextBoxAge"
		Me.TextBoxAge.Size = New System.Drawing.Size(20, 20)
		Me.TextBoxAge.TabIndex = 5
		'
		'LabelPrénom
		'
		Me.LabelPrénom.AutoSize = True
		Me.LabelPrénom.Location = New System.Drawing.Point(6, 22)
		Me.LabelPrénom.Name = "LabelPrénom"
		Me.LabelPrénom.Size = New System.Drawing.Size(49, 13)
		Me.LabelPrénom.TabIndex = 2
		Me.LabelPrénom.Text = "Prénom :"
		'
		'TextBoxNom
		'
		Me.TextBoxNom.Location = New System.Drawing.Point(47, 45)
		Me.TextBoxNom.Name = "TextBoxNom"
		Me.TextBoxNom.Size = New System.Drawing.Size(137, 20)
		Me.TextBoxNom.TabIndex = 3
		'
		'TextBoxPrénom
		'
		Me.TextBoxPrénom.Location = New System.Drawing.Point(61, 19)
		Me.TextBoxPrénom.Name = "TextBoxPrénom"
		Me.TextBoxPrénom.Size = New System.Drawing.Size(123, 20)
		Me.TextBoxPrénom.TabIndex = 1
		'
		'LabelNom
		'
		Me.LabelNom.AutoSize = True
		Me.LabelNom.Location = New System.Drawing.Point(6, 48)
		Me.LabelNom.Name = "LabelNom"
		Me.LabelNom.Size = New System.Drawing.Size(35, 13)
		Me.LabelNom.TabIndex = 0
		Me.LabelNom.Text = "Nom :"
		'
		'AdresseGroup
		'
		Me.AdresseGroup.Controls.Add(Me.TextBoxVille)
		Me.AdresseGroup.Controls.Add(Me.LabelVille)
		Me.AdresseGroup.Controls.Add(Me.TextBoxAdresse)
		Me.AdresseGroup.Controls.Add(Me.LabelAdresse)
		Me.AdresseGroup.Controls.Add(Me.TextBoxCP)
		Me.AdresseGroup.Controls.Add(Me.LabelCP)
		Me.AdresseGroup.Location = New System.Drawing.Point(210, 54)
		Me.AdresseGroup.Name = "AdresseGroup"
		Me.AdresseGroup.Size = New System.Drawing.Size(251, 106)
		Me.AdresseGroup.TabIndex = 8
		Me.AdresseGroup.TabStop = False
		'
		'TextBoxVille
		'
		Me.TextBoxVille.Location = New System.Drawing.Point(44, 70)
		Me.TextBoxVille.Name = "TextBoxVille"
		Me.TextBoxVille.Size = New System.Drawing.Size(199, 20)
		Me.TextBoxVille.TabIndex = 5
		'
		'LabelVille
		'
		Me.LabelVille.AutoSize = True
		Me.LabelVille.Location = New System.Drawing.Point(6, 73)
		Me.LabelVille.Name = "LabelVille"
		Me.LabelVille.Size = New System.Drawing.Size(32, 13)
		Me.LabelVille.TabIndex = 4
		Me.LabelVille.Text = "Ville :"
		'
		'TextBoxAdresse
		'
		Me.TextBoxAdresse.Location = New System.Drawing.Point(63, 19)
		Me.TextBoxAdresse.Name = "TextBoxAdresse"
		Me.TextBoxAdresse.Size = New System.Drawing.Size(180, 20)
		Me.TextBoxAdresse.TabIndex = 1
		'
		'LabelAdresse
		'
		Me.LabelAdresse.AutoSize = True
		Me.LabelAdresse.Location = New System.Drawing.Point(6, 22)
		Me.LabelAdresse.Name = "LabelAdresse"
		Me.LabelAdresse.Size = New System.Drawing.Size(51, 13)
		Me.LabelAdresse.TabIndex = 2
		Me.LabelAdresse.Text = "Adresse :"
		'
		'TextBoxCP
		'
		Me.TextBoxCP.Location = New System.Drawing.Point(80, 44)
		Me.TextBoxCP.Name = "TextBoxCP"
		Me.TextBoxCP.Size = New System.Drawing.Size(163, 20)
		Me.TextBoxCP.TabIndex = 3
		'
		'LabelCP
		'
		Me.LabelCP.AutoSize = True
		Me.LabelCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LabelCP.Location = New System.Drawing.Point(6, 47)
		Me.LabelCP.Name = "LabelCP"
		Me.LabelCP.Size = New System.Drawing.Size(69, 13)
		Me.LabelCP.TabIndex = 0
		Me.LabelCP.Text = "Code postal :"
		'
		'ButtonSuivant
		'
		Me.ButtonSuivant.Location = New System.Drawing.Point(210, 167)
		Me.ButtonSuivant.Name = "ButtonSuivant"
		Me.ButtonSuivant.Size = New System.Drawing.Size(251, 42)
		Me.ButtonSuivant.TabIndex = 9
		Me.ButtonSuivant.Text = "Suivant"
		Me.ButtonSuivant.UseVisualStyleBackColor = True
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(90, 3)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 10
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButtonQuitter
		'
		Me.ButtonQuitter.Location = New System.Drawing.Point(8, 166)
		Me.ButtonQuitter.Name = "ButtonQuitter"
		Me.ButtonQuitter.Size = New System.Drawing.Size(196, 42)
		Me.ButtonQuitter.TabIndex = 11
		Me.ButtonQuitter.Text = "Quitter"
		Me.ButtonQuitter.UseVisualStyleBackColor = True
		'
		'InscriptionPart1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(473, 221)
		Me.Controls.Add(Me.ButtonQuitter)
		Me.Controls.Add(Me.Titre)
		Me.Controls.Add(Me.ButtonSuivant)
		Me.Controls.Add(Me.AdresseGroup)
		Me.Controls.Add(Me.PersonneGroup)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "InscriptionPart1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Inscription 1/2 - 00:00:00"
		Me.PersonneGroup.ResumeLayout(False)
		Me.PersonneGroup.PerformLayout()
		Me.AdresseGroup.ResumeLayout(False)
		Me.AdresseGroup.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PersonneGroup As GroupBox
	Friend WithEvents TextBoxPrénom As TextBox
	Friend WithEvents LabelNom As Label
	Friend WithEvents HScrollBarAge As HScrollBar
	Friend WithEvents LabelAge As Label
	Friend WithEvents TextBoxAge As TextBox
	Friend WithEvents LabelPrénom As Label
	Friend WithEvents TextBoxNom As TextBox
	Friend WithEvents AdresseGroup As GroupBox
	Friend WithEvents TextBoxVille As TextBox
	Friend WithEvents LabelVille As Label
	Friend WithEvents TextBoxAdresse As TextBox
	Friend WithEvents LabelAdresse As Label
	Friend WithEvents TextBoxCP As TextBox
	Friend WithEvents LabelCP As Label
	Friend WithEvents ButtonSuivant As Button
	Friend WithEvents Titre As Label
	Friend WithEvents ButtonQuitter As Button
End Class
