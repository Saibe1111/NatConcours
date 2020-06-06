<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BilanCandidature
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BilanCandidature))
		Me.GroupBoxNomPrénom = New System.Windows.Forms.GroupBox()
		Me.LabelNomPrénom = New System.Windows.Forms.Label()
		Me.ComboBoxNomPrénom = New System.Windows.Forms.ComboBox()
		Me.Titre = New System.Windows.Forms.Label()
		Me.GroupBoxInformation = New System.Windows.Forms.GroupBox()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.LabelNuméro = New System.Windows.Forms.Label()
		Me.GroupBoxAdresse = New System.Windows.Forms.GroupBox()
		Me.LabelVille = New System.Windows.Forms.Label()
		Me.LabelAdresse = New System.Windows.Forms.Label()
		Me.LabelCP = New System.Windows.Forms.Label()
		Me.GroupBoxEpreuve = New System.Windows.Forms.GroupBox()
		Me.GroupBoxOption = New System.Windows.Forms.GroupBox()
		Me.LabelOptionMatière1 = New System.Windows.Forms.Label()
		Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
		Me.LabelOralMatière3 = New System.Windows.Forms.Label()
		Me.LabelOralMatière2 = New System.Windows.Forms.Label()
		Me.LabelOralMatière1 = New System.Windows.Forms.Label()
		Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
		Me.LabelEcritMatière4 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière3 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière2 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière1 = New System.Windows.Forms.Label()
		Me.LabelRegion = New System.Windows.Forms.Label()
		Me.ButtonRetour = New System.Windows.Forms.Button()
		Me.ButtonAccueil = New System.Windows.Forms.Button()
		Me.ButtonQuitter = New System.Windows.Forms.Button()
		Me.GroupBoxNomPrénom.SuspendLayout()
		Me.GroupBoxInformation.SuspendLayout()
		Me.GroupBoxAdresse.SuspendLayout()
		Me.GroupBoxEpreuve.SuspendLayout()
		Me.GroupBoxOption.SuspendLayout()
		Me.GroupBoxOral.SuspendLayout()
		Me.GroupBoxEcrit.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxNomPrénom
		'
		Me.GroupBoxNomPrénom.Controls.Add(Me.LabelNomPrénom)
		Me.GroupBoxNomPrénom.Controls.Add(Me.ComboBoxNomPrénom)
		Me.GroupBoxNomPrénom.Location = New System.Drawing.Point(9, 70)
		Me.GroupBoxNomPrénom.Name = "GroupBoxNomPrénom"
		Me.GroupBoxNomPrénom.Size = New System.Drawing.Size(379, 48)
		Me.GroupBoxNomPrénom.TabIndex = 15
		Me.GroupBoxNomPrénom.TabStop = False
		'
		'LabelNomPrénom
		'
		Me.LabelNomPrénom.AutoSize = True
		Me.LabelNomPrénom.Location = New System.Drawing.Point(6, 19)
		Me.LabelNomPrénom.Name = "LabelNomPrénom"
		Me.LabelNomPrénom.Size = New System.Drawing.Size(85, 13)
		Me.LabelNomPrénom.TabIndex = 14
		Me.LabelNomPrénom.Text = "Nom et prénom :"
		'
		'ComboBoxNomPrénom
		'
		Me.ComboBoxNomPrénom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxNomPrénom.FormattingEnabled = True
		Me.ComboBoxNomPrénom.Location = New System.Drawing.Point(97, 16)
		Me.ComboBoxNomPrénom.Name = "ComboBoxNomPrénom"
		Me.ComboBoxNomPrénom.Size = New System.Drawing.Size(270, 21)
		Me.ComboBoxNomPrénom.TabIndex = 12
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(57, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 13
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GroupBoxInformation
		'
		Me.GroupBoxInformation.Controls.Add(Me.LabelAge)
		Me.GroupBoxInformation.Controls.Add(Me.LabelNuméro)
		Me.GroupBoxInformation.Location = New System.Drawing.Point(9, 125)
		Me.GroupBoxInformation.Name = "GroupBoxInformation"
		Me.GroupBoxInformation.Size = New System.Drawing.Size(379, 43)
		Me.GroupBoxInformation.TabIndex = 16
		Me.GroupBoxInformation.TabStop = False
		Me.GroupBoxInformation.Text = "Information"
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(193, 20)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(32, 13)
		Me.LabelAge.TabIndex = 1
		Me.LabelAge.Text = "Age: "
		'
		'LabelNuméro
		'
		Me.LabelNuméro.AutoSize = True
		Me.LabelNuméro.Location = New System.Drawing.Point(7, 20)
		Me.LabelNuméro.Name = "LabelNuméro"
		Me.LabelNuméro.Size = New System.Drawing.Size(94, 13)
		Me.LabelNuméro.TabIndex = 0
		Me.LabelNuméro.Text = "Numéro candidat: "
		'
		'GroupBoxAdresse
		'
		Me.GroupBoxAdresse.Controls.Add(Me.LabelVille)
		Me.GroupBoxAdresse.Controls.Add(Me.LabelAdresse)
		Me.GroupBoxAdresse.Controls.Add(Me.LabelCP)
		Me.GroupBoxAdresse.Location = New System.Drawing.Point(12, 174)
		Me.GroupBoxAdresse.Name = "GroupBoxAdresse"
		Me.GroupBoxAdresse.Size = New System.Drawing.Size(376, 106)
		Me.GroupBoxAdresse.TabIndex = 17
		Me.GroupBoxAdresse.TabStop = False
		Me.GroupBoxAdresse.Text = "Localisation"
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
		'LabelAdresse
		'
		Me.LabelAdresse.AutoSize = True
		Me.LabelAdresse.Location = New System.Drawing.Point(6, 22)
		Me.LabelAdresse.Name = "LabelAdresse"
		Me.LabelAdresse.Size = New System.Drawing.Size(51, 13)
		Me.LabelAdresse.TabIndex = 2
		Me.LabelAdresse.Text = "Adresse :"
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
		'GroupBoxEpreuve
		'
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxOption)
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxOral)
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxEcrit)
		Me.GroupBoxEpreuve.Controls.Add(Me.LabelRegion)
		Me.GroupBoxEpreuve.Location = New System.Drawing.Point(13, 287)
		Me.GroupBoxEpreuve.Name = "GroupBoxEpreuve"
		Me.GroupBoxEpreuve.Size = New System.Drawing.Size(375, 227)
		Me.GroupBoxEpreuve.TabIndex = 18
		Me.GroupBoxEpreuve.TabStop = False
		Me.GroupBoxEpreuve.Text = "Epreuve"
		'
		'GroupBoxOption
		'
		Me.GroupBoxOption.Controls.Add(Me.LabelOptionMatière1)
		Me.GroupBoxOption.Location = New System.Drawing.Point(6, 176)
		Me.GroupBoxOption.Name = "GroupBoxOption"
		Me.GroupBoxOption.Size = New System.Drawing.Size(363, 44)
		Me.GroupBoxOption.TabIndex = 7
		Me.GroupBoxOption.TabStop = False
		Me.GroupBoxOption.Text = "Option"
		'
		'LabelOptionMatière1
		'
		Me.LabelOptionMatière1.AutoSize = True
		Me.LabelOptionMatière1.Location = New System.Drawing.Point(7, 20)
		Me.LabelOptionMatière1.Name = "LabelOptionMatière1"
		Me.LabelOptionMatière1.Size = New System.Drawing.Size(51, 13)
		Me.LabelOptionMatière1.TabIndex = 0
		Me.LabelOptionMatière1.Text = "Matière 1"
		'
		'GroupBoxOral
		'
		Me.GroupBoxOral.Controls.Add(Me.LabelOralMatière3)
		Me.GroupBoxOral.Controls.Add(Me.LabelOralMatière2)
		Me.GroupBoxOral.Controls.Add(Me.LabelOralMatière1)
		Me.GroupBoxOral.Location = New System.Drawing.Point(194, 54)
		Me.GroupBoxOral.Name = "GroupBoxOral"
		Me.GroupBoxOral.Size = New System.Drawing.Size(175, 116)
		Me.GroupBoxOral.TabIndex = 7
		Me.GroupBoxOral.TabStop = False
		Me.GroupBoxOral.Text = "Oral"
		'
		'LabelOralMatière3
		'
		Me.LabelOralMatière3.AutoSize = True
		Me.LabelOralMatière3.Location = New System.Drawing.Point(6, 70)
		Me.LabelOralMatière3.Name = "LabelOralMatière3"
		Me.LabelOralMatière3.Size = New System.Drawing.Size(51, 13)
		Me.LabelOralMatière3.TabIndex = 3
		Me.LabelOralMatière3.Text = "Matière 3"
		'
		'LabelOralMatière2
		'
		Me.LabelOralMatière2.AutoSize = True
		Me.LabelOralMatière2.Location = New System.Drawing.Point(7, 45)
		Me.LabelOralMatière2.Name = "LabelOralMatière2"
		Me.LabelOralMatière2.Size = New System.Drawing.Size(51, 13)
		Me.LabelOralMatière2.TabIndex = 1
		Me.LabelOralMatière2.Text = "Matière 2"
		'
		'LabelOralMatière1
		'
		Me.LabelOralMatière1.AutoSize = True
		Me.LabelOralMatière1.Location = New System.Drawing.Point(7, 20)
		Me.LabelOralMatière1.Name = "LabelOralMatière1"
		Me.LabelOralMatière1.Size = New System.Drawing.Size(51, 13)
		Me.LabelOralMatière1.TabIndex = 0
		Me.LabelOralMatière1.Text = "Matière 1"
		'
		'GroupBoxEcrit
		'
		Me.GroupBoxEcrit.Controls.Add(Me.LabelEcritMatière4)
		Me.GroupBoxEcrit.Controls.Add(Me.LabelEcritMatière3)
		Me.GroupBoxEcrit.Controls.Add(Me.LabelEcritMatière2)
		Me.GroupBoxEcrit.Controls.Add(Me.LabelEcritMatière1)
		Me.GroupBoxEcrit.Location = New System.Drawing.Point(6, 54)
		Me.GroupBoxEcrit.Name = "GroupBoxEcrit"
		Me.GroupBoxEcrit.Size = New System.Drawing.Size(175, 116)
		Me.GroupBoxEcrit.TabIndex = 2
		Me.GroupBoxEcrit.TabStop = False
		Me.GroupBoxEcrit.Text = "Ecrit"
		'
		'LabelEcritMatière4
		'
		Me.LabelEcritMatière4.AutoSize = True
		Me.LabelEcritMatière4.Location = New System.Drawing.Point(6, 95)
		Me.LabelEcritMatière4.Name = "LabelEcritMatière4"
		Me.LabelEcritMatière4.Size = New System.Drawing.Size(51, 13)
		Me.LabelEcritMatière4.TabIndex = 6
		Me.LabelEcritMatière4.Text = "Matière 4"
		'
		'LabelEcritMatière3
		'
		Me.LabelEcritMatière3.AutoSize = True
		Me.LabelEcritMatière3.Location = New System.Drawing.Point(6, 70)
		Me.LabelEcritMatière3.Name = "LabelEcritMatière3"
		Me.LabelEcritMatière3.Size = New System.Drawing.Size(51, 13)
		Me.LabelEcritMatière3.TabIndex = 3
		Me.LabelEcritMatière3.Text = "Matière 3"
		'
		'LabelEcritMatière2
		'
		Me.LabelEcritMatière2.AutoSize = True
		Me.LabelEcritMatière2.Location = New System.Drawing.Point(7, 45)
		Me.LabelEcritMatière2.Name = "LabelEcritMatière2"
		Me.LabelEcritMatière2.Size = New System.Drawing.Size(51, 13)
		Me.LabelEcritMatière2.TabIndex = 1
		Me.LabelEcritMatière2.Text = "Matière 2"
		'
		'LabelEcritMatière1
		'
		Me.LabelEcritMatière1.AutoSize = True
		Me.LabelEcritMatière1.Location = New System.Drawing.Point(7, 20)
		Me.LabelEcritMatière1.Name = "LabelEcritMatière1"
		Me.LabelEcritMatière1.Size = New System.Drawing.Size(51, 13)
		Me.LabelEcritMatière1.TabIndex = 0
		Me.LabelEcritMatière1.Text = "Matière 1"
		'
		'LabelRegion
		'
		Me.LabelRegion.AutoSize = True
		Me.LabelRegion.Location = New System.Drawing.Point(6, 26)
		Me.LabelRegion.Name = "LabelRegion"
		Me.LabelRegion.Size = New System.Drawing.Size(108, 13)
		Me.LabelRegion.TabIndex = 0
		Me.LabelRegion.Text = "Région de passage  :"
		'
		'ButtonRetour
		'
		Me.ButtonRetour.Location = New System.Drawing.Point(13, 521)
		Me.ButtonRetour.Name = "ButtonRetour"
		Me.ButtonRetour.Size = New System.Drawing.Size(181, 31)
		Me.ButtonRetour.TabIndex = 19
		Me.ButtonRetour.Text = "Retour"
		Me.ButtonRetour.UseVisualStyleBackColor = True
		'
		'ButtonAccueil
		'
		Me.ButtonAccueil.Location = New System.Drawing.Point(207, 521)
		Me.ButtonAccueil.Name = "ButtonAccueil"
		Me.ButtonAccueil.Size = New System.Drawing.Size(181, 31)
		Me.ButtonAccueil.TabIndex = 20
		Me.ButtonAccueil.Text = "Accueil"
		Me.ButtonAccueil.UseVisualStyleBackColor = True
		'
		'ButtonQuitter
		'
		Me.ButtonQuitter.Location = New System.Drawing.Point(207, 521)
		Me.ButtonQuitter.Name = "ButtonQuitter"
		Me.ButtonQuitter.Size = New System.Drawing.Size(181, 31)
		Me.ButtonQuitter.TabIndex = 21
		Me.ButtonQuitter.Text = "Quitter"
		Me.ButtonQuitter.UseVisualStyleBackColor = True
		'
		'BilanCandidature
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(403, 562)
		Me.Controls.Add(Me.ButtonQuitter)
		Me.Controls.Add(Me.ButtonAccueil)
		Me.Controls.Add(Me.ButtonRetour)
		Me.Controls.Add(Me.GroupBoxEpreuve)
		Me.Controls.Add(Me.GroupBoxAdresse)
		Me.Controls.Add(Me.GroupBoxInformation)
		Me.Controls.Add(Me.GroupBoxNomPrénom)
		Me.Controls.Add(Me.Titre)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "BilanCandidature"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Bilan par candidature"
		Me.GroupBoxNomPrénom.ResumeLayout(False)
		Me.GroupBoxNomPrénom.PerformLayout()
		Me.GroupBoxInformation.ResumeLayout(False)
		Me.GroupBoxInformation.PerformLayout()
		Me.GroupBoxAdresse.ResumeLayout(False)
		Me.GroupBoxAdresse.PerformLayout()
		Me.GroupBoxEpreuve.ResumeLayout(False)
		Me.GroupBoxEpreuve.PerformLayout()
		Me.GroupBoxOption.ResumeLayout(False)
		Me.GroupBoxOption.PerformLayout()
		Me.GroupBoxOral.ResumeLayout(False)
		Me.GroupBoxOral.PerformLayout()
		Me.GroupBoxEcrit.ResumeLayout(False)
		Me.GroupBoxEcrit.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GroupBoxNomPrénom As GroupBox
	Friend WithEvents LabelNomPrénom As Label
	Friend WithEvents ComboBoxNomPrénom As ComboBox
	Friend WithEvents Titre As Label
	Friend WithEvents GroupBoxInformation As GroupBox
	Friend WithEvents LabelAge As Label
	Friend WithEvents LabelNuméro As Label
	Friend WithEvents GroupBoxAdresse As GroupBox
	Friend WithEvents LabelVille As Label
	Friend WithEvents LabelAdresse As Label
	Friend WithEvents LabelCP As Label
	Friend WithEvents GroupBoxEpreuve As GroupBox
	Friend WithEvents LabelRegion As Label
	Friend WithEvents GroupBoxOption As GroupBox
	Friend WithEvents LabelOptionMatière1 As Label
	Friend WithEvents GroupBoxOral As GroupBox
	Friend WithEvents LabelOralMatière3 As Label
	Friend WithEvents LabelOralMatière2 As Label
	Friend WithEvents LabelOralMatière1 As Label
	Friend WithEvents GroupBoxEcrit As GroupBox
	Friend WithEvents LabelEcritMatière4 As Label
	Friend WithEvents LabelEcritMatière3 As Label
	Friend WithEvents LabelEcritMatière2 As Label
	Friend WithEvents LabelEcritMatière1 As Label
	Friend WithEvents ButtonRetour As Button
	Friend WithEvents ButtonAccueil As Button
	Friend WithEvents ButtonQuitter As Button
End Class
