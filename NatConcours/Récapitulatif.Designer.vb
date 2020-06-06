<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Récapitulatif
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Récapitulatif))
		Me.ButtonEnregistrement = New System.Windows.Forms.Button()
		Me.LabelEcritMatière4 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière3 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière2 = New System.Windows.Forms.Label()
		Me.LabelEcritMatière1 = New System.Windows.Forms.Label()
		Me.LabelOralMatière3 = New System.Windows.Forms.Label()
		Me.LabelOralMatière2 = New System.Windows.Forms.Label()
		Me.LabelOralMatière1 = New System.Windows.Forms.Label()
		Me.LabelOptionMatière1 = New System.Windows.Forms.Label()
		Me.ButtonModif = New System.Windows.Forms.Button()
		Me.GroupBoxEpreuve = New System.Windows.Forms.GroupBox()
		Me.GroupBoxOption = New System.Windows.Forms.GroupBox()
		Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
		Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
		Me.LabelRegion = New System.Windows.Forms.Label()
		Me.LabelVille = New System.Windows.Forms.Label()
		Me.LabelAdresse = New System.Windows.Forms.Label()
		Me.GroupBoxAdresse = New System.Windows.Forms.GroupBox()
		Me.LabelCP = New System.Windows.Forms.Label()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.GroupBoxInformation = New System.Windows.Forms.GroupBox()
		Me.LabelNomPrénom = New System.Windows.Forms.Label()
		Me.Titre = New System.Windows.Forms.Label()
		Me.ButtonAnnulation = New System.Windows.Forms.Button()
		Me.GroupBoxEpreuve.SuspendLayout()
		Me.GroupBoxOption.SuspendLayout()
		Me.GroupBoxOral.SuspendLayout()
		Me.GroupBoxEcrit.SuspendLayout()
		Me.GroupBoxAdresse.SuspendLayout()
		Me.GroupBoxInformation.SuspendLayout()
		Me.SuspendLayout()
		'
		'ButtonEnregistrement
		'
		Me.ButtonEnregistrement.Location = New System.Drawing.Point(216, 463)
		Me.ButtonEnregistrement.Name = "ButtonEnregistrement"
		Me.ButtonEnregistrement.Size = New System.Drawing.Size(169, 31)
		Me.ButtonEnregistrement.TabIndex = 27
		Me.ButtonEnregistrement.Text = "Enregistrement"
		Me.ButtonEnregistrement.UseVisualStyleBackColor = True
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
		'LabelOptionMatière1
		'
		Me.LabelOptionMatière1.AutoSize = True
		Me.LabelOptionMatière1.Location = New System.Drawing.Point(7, 20)
		Me.LabelOptionMatière1.Name = "LabelOptionMatière1"
		Me.LabelOptionMatière1.Size = New System.Drawing.Size(51, 13)
		Me.LabelOptionMatière1.TabIndex = 0
		Me.LabelOptionMatière1.Text = "Matière 1"
		'
		'ButtonModif
		'
		Me.ButtonModif.Location = New System.Drawing.Point(10, 463)
		Me.ButtonModif.Name = "ButtonModif"
		Me.ButtonModif.Size = New System.Drawing.Size(97, 31)
		Me.ButtonModif.TabIndex = 26
		Me.ButtonModif.Text = "Modification"
		Me.ButtonModif.UseVisualStyleBackColor = True
		'
		'GroupBoxEpreuve
		'
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxOption)
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxOral)
		Me.GroupBoxEpreuve.Controls.Add(Me.GroupBoxEcrit)
		Me.GroupBoxEpreuve.Controls.Add(Me.LabelRegion)
		Me.GroupBoxEpreuve.Location = New System.Drawing.Point(10, 229)
		Me.GroupBoxEpreuve.Name = "GroupBoxEpreuve"
		Me.GroupBoxEpreuve.Size = New System.Drawing.Size(375, 227)
		Me.GroupBoxEpreuve.TabIndex = 25
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
		'LabelRegion
		'
		Me.LabelRegion.AutoSize = True
		Me.LabelRegion.Location = New System.Drawing.Point(6, 26)
		Me.LabelRegion.Name = "LabelRegion"
		Me.LabelRegion.Size = New System.Drawing.Size(105, 13)
		Me.LabelRegion.TabIndex = 0
		Me.LabelRegion.Text = "Région de passage :"
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
		'GroupBoxAdresse
		'
		Me.GroupBoxAdresse.Controls.Add(Me.LabelVille)
		Me.GroupBoxAdresse.Controls.Add(Me.LabelAdresse)
		Me.GroupBoxAdresse.Controls.Add(Me.LabelCP)
		Me.GroupBoxAdresse.Location = New System.Drawing.Point(9, 116)
		Me.GroupBoxAdresse.Name = "GroupBoxAdresse"
		Me.GroupBoxAdresse.Size = New System.Drawing.Size(376, 106)
		Me.GroupBoxAdresse.TabIndex = 24
		Me.GroupBoxAdresse.TabStop = False
		Me.GroupBoxAdresse.Text = "Localisation"
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
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(307, 18)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(35, 13)
		Me.LabelAge.TabIndex = 1
		Me.LabelAge.Text = "Age : "
		'
		'GroupBoxInformation
		'
		Me.GroupBoxInformation.Controls.Add(Me.LabelNomPrénom)
		Me.GroupBoxInformation.Controls.Add(Me.LabelAge)
		Me.GroupBoxInformation.Location = New System.Drawing.Point(6, 67)
		Me.GroupBoxInformation.Name = "GroupBoxInformation"
		Me.GroupBoxInformation.Size = New System.Drawing.Size(379, 43)
		Me.GroupBoxInformation.TabIndex = 23
		Me.GroupBoxInformation.TabStop = False
		Me.GroupBoxInformation.Text = "Information"
		'
		'LabelNomPrénom
		'
		Me.LabelNomPrénom.AutoSize = True
		Me.LabelNomPrénom.Location = New System.Drawing.Point(6, 18)
		Me.LabelNomPrénom.Name = "LabelNomPrénom"
		Me.LabelNomPrénom.Size = New System.Drawing.Size(85, 13)
		Me.LabelNomPrénom.TabIndex = 15
		Me.LabelNomPrénom.Text = "Nom et prénom :"
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(54, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 21
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButtonAnnulation
		'
		Me.ButtonAnnulation.Location = New System.Drawing.Point(113, 463)
		Me.ButtonAnnulation.Name = "ButtonAnnulation"
		Me.ButtonAnnulation.Size = New System.Drawing.Size(97, 31)
		Me.ButtonAnnulation.TabIndex = 28
		Me.ButtonAnnulation.Text = "Annulation"
		Me.ButtonAnnulation.UseVisualStyleBackColor = True
		'
		'Récapitulatif
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(398, 504)
		Me.Controls.Add(Me.ButtonAnnulation)
		Me.Controls.Add(Me.ButtonEnregistrement)
		Me.Controls.Add(Me.ButtonModif)
		Me.Controls.Add(Me.GroupBoxEpreuve)
		Me.Controls.Add(Me.GroupBoxAdresse)
		Me.Controls.Add(Me.GroupBoxInformation)
		Me.Controls.Add(Me.Titre)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Récapitulatif"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours -Récapitulatif"
		Me.GroupBoxEpreuve.ResumeLayout(False)
		Me.GroupBoxEpreuve.PerformLayout()
		Me.GroupBoxOption.ResumeLayout(False)
		Me.GroupBoxOption.PerformLayout()
		Me.GroupBoxOral.ResumeLayout(False)
		Me.GroupBoxOral.PerformLayout()
		Me.GroupBoxEcrit.ResumeLayout(False)
		Me.GroupBoxEcrit.PerformLayout()
		Me.GroupBoxAdresse.ResumeLayout(False)
		Me.GroupBoxAdresse.PerformLayout()
		Me.GroupBoxInformation.ResumeLayout(False)
		Me.GroupBoxInformation.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonEnregistrement As Button
	Friend WithEvents LabelEcritMatière4 As Label
	Friend WithEvents LabelEcritMatière3 As Label
	Friend WithEvents LabelEcritMatière2 As Label
	Friend WithEvents LabelEcritMatière1 As Label
	Friend WithEvents LabelOralMatière3 As Label
	Friend WithEvents LabelOralMatière2 As Label
	Friend WithEvents LabelOralMatière1 As Label
	Friend WithEvents LabelOptionMatière1 As Label
	Friend WithEvents ButtonModif As Button
	Friend WithEvents GroupBoxEpreuve As GroupBox
	Friend WithEvents GroupBoxOption As GroupBox
	Friend WithEvents GroupBoxOral As GroupBox
	Friend WithEvents GroupBoxEcrit As GroupBox
	Friend WithEvents LabelRegion As Label
	Friend WithEvents LabelVille As Label
	Friend WithEvents LabelAdresse As Label
	Friend WithEvents GroupBoxAdresse As GroupBox
	Friend WithEvents LabelCP As Label
	Friend WithEvents LabelAge As Label
	Friend WithEvents GroupBoxInformation As GroupBox
	Friend WithEvents Titre As Label
	Friend WithEvents ButtonAnnulation As Button
	Friend WithEvents LabelNomPrénom As Label
End Class
