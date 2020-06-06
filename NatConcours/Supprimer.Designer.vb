<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supprimer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supprimer))
		Me.LabelType = New System.Windows.Forms.Label()
		Me.ComboBoxNumNomPrénom = New System.Windows.Forms.ComboBox()
		Me.ButtonSupp = New System.Windows.Forms.Button()
		Me.ButtonRetour = New System.Windows.Forms.Button()
		Me.GroupBoxNumIden = New System.Windows.Forms.GroupBox()
		Me.RadioButtonNuméro = New System.Windows.Forms.RadioButton()
		Me.RadioButtonIdentifiant = New System.Windows.Forms.RadioButton()
		Me.Titre = New System.Windows.Forms.Label()
		Me.TextBoxID = New System.Windows.Forms.TextBox()
		Me.GroupBoxNumIden.SuspendLayout()
		Me.SuspendLayout()
		'
		'LabelType
		'
		Me.LabelType.AutoSize = True
		Me.LabelType.Location = New System.Drawing.Point(16, 135)
		Me.LabelType.Name = "LabelType"
		Me.LabelType.Size = New System.Drawing.Size(56, 13)
		Me.LabelType.TabIndex = 16
		Me.LabelType.Text = "Identifiant:"
		'
		'ComboBoxNumNomPrénom
		'
		Me.ComboBoxNumNomPrénom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBoxNumNomPrénom.FormattingEnabled = True
		Me.ComboBoxNumNomPrénom.Location = New System.Drawing.Point(78, 132)
		Me.ComboBoxNumNomPrénom.Name = "ComboBoxNumNomPrénom"
		Me.ComboBoxNumNomPrénom.Size = New System.Drawing.Size(147, 21)
		Me.ComboBoxNumNomPrénom.Sorted = True
		Me.ComboBoxNumNomPrénom.TabIndex = 15
		'
		'ButtonSupp
		'
		Me.ButtonSupp.Location = New System.Drawing.Point(121, 168)
		Me.ButtonSupp.Name = "ButtonSupp"
		Me.ButtonSupp.Size = New System.Drawing.Size(104, 31)
		Me.ButtonSupp.TabIndex = 17
		Me.ButtonSupp.Text = "Supprimer"
		Me.ButtonSupp.UseVisualStyleBackColor = True
		'
		'ButtonRetour
		'
		Me.ButtonRetour.Location = New System.Drawing.Point(19, 168)
		Me.ButtonRetour.Name = "ButtonRetour"
		Me.ButtonRetour.Size = New System.Drawing.Size(96, 31)
		Me.ButtonRetour.TabIndex = 18
		Me.ButtonRetour.Text = "Accueil"
		Me.ButtonRetour.UseVisualStyleBackColor = True
		'
		'GroupBoxNumIden
		'
		Me.GroupBoxNumIden.Controls.Add(Me.RadioButtonNuméro)
		Me.GroupBoxNumIden.Controls.Add(Me.RadioButtonIdentifiant)
		Me.GroupBoxNumIden.Location = New System.Drawing.Point(19, 73)
		Me.GroupBoxNumIden.Name = "GroupBoxNumIden"
		Me.GroupBoxNumIden.Size = New System.Drawing.Size(206, 49)
		Me.GroupBoxNumIden.TabIndex = 29
		Me.GroupBoxNumIden.TabStop = False
		Me.GroupBoxNumIden.Text = "Numéro ou identifiant "
		'
		'RadioButtonNuméro
		'
		Me.RadioButtonNuméro.AutoSize = True
		Me.RadioButtonNuméro.Location = New System.Drawing.Point(103, 19)
		Me.RadioButtonNuméro.Name = "RadioButtonNuméro"
		Me.RadioButtonNuméro.Size = New System.Drawing.Size(62, 17)
		Me.RadioButtonNuméro.TabIndex = 26
		Me.RadioButtonNuméro.Text = "Numéro"
		Me.RadioButtonNuméro.UseVisualStyleBackColor = True
		'
		'RadioButtonIdentifiant
		'
		Me.RadioButtonIdentifiant.AutoSize = True
		Me.RadioButtonIdentifiant.Checked = True
		Me.RadioButtonIdentifiant.Location = New System.Drawing.Point(13, 19)
		Me.RadioButtonIdentifiant.Name = "RadioButtonIdentifiant"
		Me.RadioButtonIdentifiant.Size = New System.Drawing.Size(71, 17)
		Me.RadioButtonIdentifiant.TabIndex = 27
		Me.RadioButtonIdentifiant.TabStop = True
		Me.RadioButtonIdentifiant.Text = "Identifiant"
		Me.RadioButtonIdentifiant.UseVisualStyleBackColor = True
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(12, 19)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(213, 38)
		Me.Titre.TabIndex = 28
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxID
		'
		Me.TextBoxID.Location = New System.Drawing.Point(78, 132)
		Me.TextBoxID.Name = "TextBoxID"
		Me.TextBoxID.Size = New System.Drawing.Size(146, 20)
		Me.TextBoxID.TabIndex = 30
		'
		'Supprimer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(236, 206)
		Me.Controls.Add(Me.TextBoxID)
		Me.Controls.Add(Me.Titre)
		Me.Controls.Add(Me.GroupBoxNumIden)
		Me.Controls.Add(Me.ButtonRetour)
		Me.Controls.Add(Me.ButtonSupp)
		Me.Controls.Add(Me.LabelType)
		Me.Controls.Add(Me.ComboBoxNumNomPrénom)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Supprimer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Suppression"
		Me.GroupBoxNumIden.ResumeLayout(False)
		Me.GroupBoxNumIden.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents LabelType As Label
	Friend WithEvents ComboBoxNumNomPrénom As ComboBox
	Friend WithEvents ButtonSupp As Button
	Friend WithEvents ButtonRetour As Button
	Friend WithEvents GroupBoxNumIden As GroupBox
	Friend WithEvents RadioButtonNuméro As RadioButton
	Friend WithEvents RadioButtonIdentifiant As RadioButton
	Friend WithEvents Titre As Label
	Friend WithEvents TextBoxID As TextBox
End Class
