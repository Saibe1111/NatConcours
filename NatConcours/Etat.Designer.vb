<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Etat
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Etat))
		Me.ListBoxNuméro = New System.Windows.Forms.ListBox()
		Me.Titre = New System.Windows.Forms.Label()
		Me.LabelNuméro = New System.Windows.Forms.Label()
		Me.LabelPrénom = New System.Windows.Forms.Label()
		Me.ListBoxNom = New System.Windows.Forms.ListBox()
		Me.LabelNom = New System.Windows.Forms.Label()
		Me.ListBoxPrénom = New System.Windows.Forms.ListBox()
		Me.ListBoxMatièreEcrite = New System.Windows.Forms.ListBox()
		Me.LabelMatièreEcrit = New System.Windows.Forms.Label()
		Me.ListBoxMatièreOral = New System.Windows.Forms.ListBox()
		Me.LabelMatièreOral = New System.Windows.Forms.Label()
		Me.ListBoxMatièreFacultative = New System.Windows.Forms.ListBox()
		Me.LabelMatièreFacultative = New System.Windows.Forms.Label()
		Me.ButtonAccueil = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ListBoxNuméro
		'
		Me.ListBoxNuméro.FormattingEnabled = True
		Me.ListBoxNuméro.Location = New System.Drawing.Point(12, 103)
		Me.ListBoxNuméro.Name = "ListBoxNuméro"
		Me.ListBoxNuméro.Size = New System.Drawing.Size(53, 199)
		Me.ListBoxNuméro.TabIndex = 0
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(188, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 11
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelNuméro
		'
		Me.LabelNuméro.AutoSize = True
		Me.LabelNuméro.Location = New System.Drawing.Point(9, 84)
		Me.LabelNuméro.Name = "LabelNuméro"
		Me.LabelNuméro.Size = New System.Drawing.Size(50, 13)
		Me.LabelNuméro.TabIndex = 12
		Me.LabelNuméro.Text = "Numéro: "
		'
		'LabelPrénom
		'
		Me.LabelPrénom.AutoSize = True
		Me.LabelPrénom.Location = New System.Drawing.Point(194, 84)
		Me.LabelPrénom.Name = "LabelPrénom"
		Me.LabelPrénom.Size = New System.Drawing.Size(49, 13)
		Me.LabelPrénom.TabIndex = 14
		Me.LabelPrénom.Text = "Prénom: "
		'
		'ListBoxNom
		'
		Me.ListBoxNom.FormattingEnabled = True
		Me.ListBoxNom.Location = New System.Drawing.Point(71, 103)
		Me.ListBoxNom.Name = "ListBoxNom"
		Me.ListBoxNom.Size = New System.Drawing.Size(120, 199)
		Me.ListBoxNom.TabIndex = 13
		'
		'LabelNom
		'
		Me.LabelNom.AutoSize = True
		Me.LabelNom.Location = New System.Drawing.Point(68, 84)
		Me.LabelNom.Name = "LabelNom"
		Me.LabelNom.Size = New System.Drawing.Size(32, 13)
		Me.LabelNom.TabIndex = 16
		Me.LabelNom.Text = "Nom:"
		'
		'ListBoxPrénom
		'
		Me.ListBoxPrénom.FormattingEnabled = True
		Me.ListBoxPrénom.Location = New System.Drawing.Point(197, 103)
		Me.ListBoxPrénom.Name = "ListBoxPrénom"
		Me.ListBoxPrénom.Size = New System.Drawing.Size(120, 199)
		Me.ListBoxPrénom.TabIndex = 15
		'
		'ListBoxMatièreEcrite
		'
		Me.ListBoxMatièreEcrite.FormattingEnabled = True
		Me.ListBoxMatièreEcrite.Location = New System.Drawing.Point(323, 103)
		Me.ListBoxMatièreEcrite.Name = "ListBoxMatièreEcrite"
		Me.ListBoxMatièreEcrite.Size = New System.Drawing.Size(117, 199)
		Me.ListBoxMatièreEcrite.TabIndex = 18
		'
		'LabelMatièreEcrit
		'
		Me.LabelMatièreEcrit.AutoSize = True
		Me.LabelMatièreEcrit.Location = New System.Drawing.Point(320, 84)
		Me.LabelMatièreEcrit.Name = "LabelMatièreEcrit"
		Me.LabelMatièreEcrit.Size = New System.Drawing.Size(81, 13)
		Me.LabelMatièreEcrit.TabIndex = 17
		Me.LabelMatièreEcrit.Text = "Matières écrits: "
		'
		'ListBoxMatièreOral
		'
		Me.ListBoxMatièreOral.FormattingEnabled = True
		Me.ListBoxMatièreOral.Location = New System.Drawing.Point(446, 102)
		Me.ListBoxMatièreOral.Name = "ListBoxMatièreOral"
		Me.ListBoxMatièreOral.Size = New System.Drawing.Size(103, 199)
		Me.ListBoxMatièreOral.TabIndex = 20
		'
		'LabelMatièreOral
		'
		Me.LabelMatièreOral.AutoSize = True
		Me.LabelMatièreOral.Location = New System.Drawing.Point(443, 83)
		Me.LabelMatièreOral.Name = "LabelMatièreOral"
		Me.LabelMatièreOral.Size = New System.Drawing.Size(80, 13)
		Me.LabelMatièreOral.TabIndex = 19
		Me.LabelMatièreOral.Text = "Matières Orals: "
		'
		'ListBoxMatièreFacultative
		'
		Me.ListBoxMatièreFacultative.FormattingEnabled = True
		Me.ListBoxMatièreFacultative.Location = New System.Drawing.Point(555, 102)
		Me.ListBoxMatièreFacultative.Name = "ListBoxMatièreFacultative"
		Me.ListBoxMatièreFacultative.Size = New System.Drawing.Size(124, 199)
		Me.ListBoxMatièreFacultative.TabIndex = 22
		'
		'LabelMatièreFacultative
		'
		Me.LabelMatièreFacultative.AutoSize = True
		Me.LabelMatièreFacultative.Location = New System.Drawing.Point(552, 83)
		Me.LabelMatièreFacultative.Name = "LabelMatièreFacultative"
		Me.LabelMatièreFacultative.Size = New System.Drawing.Size(100, 13)
		Me.LabelMatièreFacultative.TabIndex = 21
		Me.LabelMatièreFacultative.Text = "Matière facultative: "
		'
		'ButtonAccueil
		'
		Me.ButtonAccueil.Location = New System.Drawing.Point(12, 308)
		Me.ButtonAccueil.Name = "ButtonAccueil"
		Me.ButtonAccueil.Size = New System.Drawing.Size(667, 31)
		Me.ButtonAccueil.TabIndex = 24
		Me.ButtonAccueil.Text = "Accueil"
		Me.ButtonAccueil.UseVisualStyleBackColor = True
		'
		'Etat
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(688, 347)
		Me.Controls.Add(Me.ButtonAccueil)
		Me.Controls.Add(Me.ListBoxMatièreFacultative)
		Me.Controls.Add(Me.LabelMatièreFacultative)
		Me.Controls.Add(Me.ListBoxMatièreOral)
		Me.Controls.Add(Me.LabelMatièreOral)
		Me.Controls.Add(Me.ListBoxMatièreEcrite)
		Me.Controls.Add(Me.LabelMatièreEcrit)
		Me.Controls.Add(Me.LabelNom)
		Me.Controls.Add(Me.ListBoxPrénom)
		Me.Controls.Add(Me.LabelPrénom)
		Me.Controls.Add(Me.ListBoxNom)
		Me.Controls.Add(Me.LabelNuméro)
		Me.Controls.Add(Me.Titre)
		Me.Controls.Add(Me.ListBoxNuméro)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Etat"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Etat Inscriptions"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ListBoxNuméro As ListBox
	Friend WithEvents Titre As Label
	Friend WithEvents LabelNuméro As Label
	Friend WithEvents LabelPrénom As Label
	Friend WithEvents ListBoxNom As ListBox
	Friend WithEvents LabelNom As Label
	Friend WithEvents ListBoxPrénom As ListBox
	Friend WithEvents ListBoxMatièreEcrite As ListBox
	Friend WithEvents LabelMatièreEcrit As Label
	Friend WithEvents ListBoxMatièreOral As ListBox
	Friend WithEvents LabelMatièreOral As Label
	Friend WithEvents ListBoxMatièreFacultative As ListBox
	Friend WithEvents LabelMatièreFacultative As Label
	Friend WithEvents ButtonAccueil As Button
End Class
