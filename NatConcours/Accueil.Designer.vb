<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
		Me.EnregistrerButton = New System.Windows.Forms.Button()
		Me.ModifierButton = New System.Windows.Forms.Button()
		Me.SupprimerButton = New System.Windows.Forms.Button()
		Me.EtatButton = New System.Windows.Forms.Button()
		Me.BilanButton = New System.Windows.Forms.Button()
		Me.FinButton = New System.Windows.Forms.Button()
		Me.Titre = New System.Windows.Forms.Label()
		Me.NomPrénomGroupe = New System.Windows.Forms.StatusStrip()
		Me.TitrePied = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ButtonQuitter = New System.Windows.Forms.Button()
		Me.ButtonRecommencer = New System.Windows.Forms.Button()
		Me.NomPrénomGroupe.SuspendLayout()
		Me.SuspendLayout()
		'
		'EnregistrerButton
		'
		Me.EnregistrerButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EnregistrerButton.Location = New System.Drawing.Point(12, 76)
		Me.EnregistrerButton.Name = "EnregistrerButton"
		Me.EnregistrerButton.Size = New System.Drawing.Size(144, 52)
		Me.EnregistrerButton.TabIndex = 0
		Me.EnregistrerButton.Text = "Enregistrer une inscription"
		Me.EnregistrerButton.UseVisualStyleBackColor = True
		'
		'ModifierButton
		'
		Me.ModifierButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ModifierButton.Location = New System.Drawing.Point(162, 76)
		Me.ModifierButton.Name = "ModifierButton"
		Me.ModifierButton.Size = New System.Drawing.Size(144, 52)
		Me.ModifierButton.TabIndex = 1
		Me.ModifierButton.Text = "Modifier une inscription"
		Me.ModifierButton.UseVisualStyleBackColor = True
		'
		'SupprimerButton
		'
		Me.SupprimerButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SupprimerButton.Location = New System.Drawing.Point(12, 134)
		Me.SupprimerButton.Name = "SupprimerButton"
		Me.SupprimerButton.Size = New System.Drawing.Size(144, 52)
		Me.SupprimerButton.TabIndex = 2
		Me.SupprimerButton.Text = "Supprimer une inscription"
		Me.SupprimerButton.UseVisualStyleBackColor = True
		'
		'EtatButton
		'
		Me.EtatButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EtatButton.Location = New System.Drawing.Point(162, 134)
		Me.EtatButton.Name = "EtatButton"
		Me.EtatButton.Size = New System.Drawing.Size(144, 52)
		Me.EtatButton.TabIndex = 3
		Me.EtatButton.Text = "Afficher l’état actuel des inscriptions"
		Me.EtatButton.UseVisualStyleBackColor = True
		'
		'BilanButton
		'
		Me.BilanButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BilanButton.Location = New System.Drawing.Point(12, 192)
		Me.BilanButton.Name = "BilanButton"
		Me.BilanButton.Size = New System.Drawing.Size(144, 52)
		Me.BilanButton.TabIndex = 4
		Me.BilanButton.Text = "Bilan"
		Me.BilanButton.UseVisualStyleBackColor = True
		'
		'FinButton
		'
		Me.FinButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FinButton.Location = New System.Drawing.Point(162, 192)
		Me.FinButton.Name = "FinButton"
		Me.FinButton.Size = New System.Drawing.Size(144, 52)
		Me.FinButton.TabIndex = 5
		Me.FinButton.Text = "Mettre fin aux inscriptions"
		Me.FinButton.UseVisualStyleBackColor = True
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(12, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 6
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'NomPrénomGroupe
		'
		Me.NomPrénomGroupe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitrePied})
		Me.NomPrénomGroupe.Location = New System.Drawing.Point(0, 309)
		Me.NomPrénomGroupe.Name = "NomPrénomGroupe"
		Me.NomPrénomGroupe.Size = New System.Drawing.Size(318, 22)
		Me.NomPrénomGroupe.TabIndex = 7
		Me.NomPrénomGroupe.Text = "StatusStrip1"
		'
		'TitrePied
		'
		Me.TitrePied.Name = "TitrePied"
		Me.TitrePied.Size = New System.Drawing.Size(146, 17)
		Me.TitrePied.Text = "Sébastien CUVELLIER - 111"
		'
		'ButtonQuitter
		'
		Me.ButtonQuitter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonQuitter.Location = New System.Drawing.Point(12, 250)
		Me.ButtonQuitter.Name = "ButtonQuitter"
		Me.ButtonQuitter.Size = New System.Drawing.Size(294, 52)
		Me.ButtonQuitter.TabIndex = 8
		Me.ButtonQuitter.Text = "Quitter le logiciel"
		Me.ButtonQuitter.UseVisualStyleBackColor = True
		'
		'ButtonRecommencer
		'
		Me.ButtonRecommencer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonRecommencer.Location = New System.Drawing.Point(162, 192)
		Me.ButtonRecommencer.Name = "ButtonRecommencer"
		Me.ButtonRecommencer.Size = New System.Drawing.Size(144, 52)
		Me.ButtonRecommencer.TabIndex = 9
		Me.ButtonRecommencer.Text = "Recommencer les inscriptions"
		Me.ButtonRecommencer.UseVisualStyleBackColor = True
		Me.ButtonRecommencer.Visible = False
		'
		'Accueil
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.ClientSize = New System.Drawing.Size(318, 331)
		Me.Controls.Add(Me.ButtonRecommencer)
		Me.Controls.Add(Me.ButtonQuitter)
		Me.Controls.Add(Me.NomPrénomGroupe)
		Me.Controls.Add(Me.Titre)
		Me.Controls.Add(Me.FinButton)
		Me.Controls.Add(Me.BilanButton)
		Me.Controls.Add(Me.EtatButton)
		Me.Controls.Add(Me.SupprimerButton)
		Me.Controls.Add(Me.ModifierButton)
		Me.Controls.Add(Me.EnregistrerButton)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Accueil"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Accueil"
		Me.NomPrénomGroupe.ResumeLayout(False)
		Me.NomPrénomGroupe.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents EnregistrerButton As Button
	Friend WithEvents ModifierButton As Button
	Friend WithEvents SupprimerButton As Button
	Friend WithEvents EtatButton As Button
	Friend WithEvents BilanButton As Button
	Friend WithEvents FinButton As Button
	Friend WithEvents Titre As Label
	Friend WithEvents NomPrénomGroupe As StatusStrip
	Friend WithEvents TitrePied As ToolStripStatusLabel
	Friend WithEvents ButtonQuitter As Button
	Friend WithEvents ButtonRecommencer As Button
End Class
