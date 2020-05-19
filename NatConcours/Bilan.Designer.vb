<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bilan
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bilan))
		Me.Titre = New System.Windows.Forms.Label()
		Me.ButtonIndiv = New System.Windows.Forms.Button()
		Me.ButtonMatière = New System.Windows.Forms.Button()
		Me.ButtonRetour = New System.Windows.Forms.Button()
		Me.ButtonQuitter = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(12, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 12
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButtonIndiv
		'
		Me.ButtonIndiv.Location = New System.Drawing.Point(12, 64)
		Me.ButtonIndiv.Name = "ButtonIndiv"
		Me.ButtonIndiv.Size = New System.Drawing.Size(296, 39)
		Me.ButtonIndiv.TabIndex = 13
		Me.ButtonIndiv.Text = "Bilan individuel d’une candidature"
		Me.ButtonIndiv.UseVisualStyleBackColor = True
		'
		'ButtonMatière
		'
		Me.ButtonMatière.Location = New System.Drawing.Point(12, 109)
		Me.ButtonMatière.Name = "ButtonMatière"
		Me.ButtonMatière.Size = New System.Drawing.Size(296, 39)
		Me.ButtonMatière.TabIndex = 14
		Me.ButtonMatière.Text = "Bilan des inscriptions dans une matière"
		Me.ButtonMatière.UseVisualStyleBackColor = True
		'
		'ButtonRetour
		'
		Me.ButtonRetour.Location = New System.Drawing.Point(12, 154)
		Me.ButtonRetour.Name = "ButtonRetour"
		Me.ButtonRetour.Size = New System.Drawing.Size(296, 39)
		Me.ButtonRetour.TabIndex = 15
		Me.ButtonRetour.Text = "Retour"
		Me.ButtonRetour.UseVisualStyleBackColor = True
		'
		'ButtonQuitter
		'
		Me.ButtonQuitter.Location = New System.Drawing.Point(12, 154)
		Me.ButtonQuitter.Name = "ButtonQuitter"
		Me.ButtonQuitter.Size = New System.Drawing.Size(296, 39)
		Me.ButtonQuitter.TabIndex = 16
		Me.ButtonQuitter.Text = "Quitter"
		Me.ButtonQuitter.UseVisualStyleBackColor = True
		Me.ButtonQuitter.Visible = False
		'
		'Bilan
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(320, 203)
		Me.Controls.Add(Me.ButtonQuitter)
		Me.Controls.Add(Me.ButtonRetour)
		Me.Controls.Add(Me.ButtonMatière)
		Me.Controls.Add(Me.ButtonIndiv)
		Me.Controls.Add(Me.Titre)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Bilan"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Bilan"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Titre As Label
	Friend WithEvents ButtonIndiv As Button
	Friend WithEvents ButtonMatière As Button
	Friend WithEvents ButtonRetour As Button
	Friend WithEvents ButtonQuitter As Button
End Class
