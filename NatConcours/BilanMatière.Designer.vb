<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilanMatière
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BilanMatière))
		Me.GroupBoxRégion = New System.Windows.Forms.GroupBox()
		Me.LabelRégion = New System.Windows.Forms.Label()
		Me.ComboBoxMatière = New System.Windows.Forms.ComboBox()
		Me.Titre = New System.Windows.Forms.Label()
		Me.LabelNom = New System.Windows.Forms.Label()
		Me.ListBoxPrénom = New System.Windows.Forms.ListBox()
		Me.LabelPrénom = New System.Windows.Forms.Label()
		Me.ListBoxNom = New System.Windows.Forms.ListBox()
		Me.LabelNuméro = New System.Windows.Forms.Label()
		Me.ListBoxNuméro = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.GroupBoxRégion.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxRégion
		'
		Me.GroupBoxRégion.Controls.Add(Me.LabelRégion)
		Me.GroupBoxRégion.Controls.Add(Me.ComboBoxMatière)
		Me.GroupBoxRégion.Location = New System.Drawing.Point(11, 70)
		Me.GroupBoxRégion.Name = "GroupBoxRégion"
		Me.GroupBoxRégion.Size = New System.Drawing.Size(432, 48)
		Me.GroupBoxRégion.TabIndex = 17
		Me.GroupBoxRégion.TabStop = False
		'
		'LabelRégion
		'
		Me.LabelRégion.AutoSize = True
		Me.LabelRégion.Location = New System.Drawing.Point(6, 19)
		Me.LabelRégion.Name = "LabelRégion"
		Me.LabelRégion.Size = New System.Drawing.Size(48, 13)
		Me.LabelRégion.TabIndex = 14
		Me.LabelRégion.Text = "Matière :"
		'
		'ComboBoxMatière
		'
		Me.ComboBoxMatière.FormattingEnabled = True
		Me.ComboBoxMatière.Location = New System.Drawing.Point(60, 16)
		Me.ComboBoxMatière.Name = "ComboBoxMatière"
		Me.ComboBoxMatière.Size = New System.Drawing.Size(366, 21)
		Me.ComboBoxMatière.TabIndex = 12
		'
		'Titre
		'
		Me.Titre.AutoSize = True
		Me.Titre.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Titre.Location = New System.Drawing.Point(78, 9)
		Me.Titre.Name = "Titre"
		Me.Titre.Size = New System.Drawing.Size(291, 52)
		Me.Titre.TabIndex = 16
		Me.Titre.Text = "NatConcours"
		Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelNom
		'
		Me.LabelNom.AutoSize = True
		Me.LabelNom.Location = New System.Drawing.Point(194, 125)
		Me.LabelNom.Name = "LabelNom"
		Me.LabelNom.Size = New System.Drawing.Size(32, 13)
		Me.LabelNom.TabIndex = 23
		Me.LabelNom.Text = "Nom:"
		'
		'ListBoxPrénom
		'
		Me.ListBoxPrénom.FormattingEnabled = True
		Me.ListBoxPrénom.Location = New System.Drawing.Point(323, 144)
		Me.ListBoxPrénom.Name = "ListBoxPrénom"
		Me.ListBoxPrénom.Size = New System.Drawing.Size(120, 199)
		Me.ListBoxPrénom.TabIndex = 22
		'
		'LabelPrénom
		'
		Me.LabelPrénom.AutoSize = True
		Me.LabelPrénom.Location = New System.Drawing.Point(320, 125)
		Me.LabelPrénom.Name = "LabelPrénom"
		Me.LabelPrénom.Size = New System.Drawing.Size(49, 13)
		Me.LabelPrénom.TabIndex = 21
		Me.LabelPrénom.Text = "Prénom: "
		'
		'ListBoxNom
		'
		Me.ListBoxNom.FormattingEnabled = True
		Me.ListBoxNom.Location = New System.Drawing.Point(197, 144)
		Me.ListBoxNom.Name = "ListBoxNom"
		Me.ListBoxNom.Size = New System.Drawing.Size(120, 199)
		Me.ListBoxNom.TabIndex = 20
		'
		'LabelNuméro
		'
		Me.LabelNuméro.AutoSize = True
		Me.LabelNuméro.Location = New System.Drawing.Point(9, 125)
		Me.LabelNuméro.Name = "LabelNuméro"
		Me.LabelNuméro.Size = New System.Drawing.Size(50, 13)
		Me.LabelNuméro.TabIndex = 19
		Me.LabelNuméro.Text = "Numéro: "
		'
		'ListBoxNuméro
		'
		Me.ListBoxNuméro.FormattingEnabled = True
		Me.ListBoxNuméro.Location = New System.Drawing.Point(12, 144)
		Me.ListBoxNuméro.Name = "ListBoxNuméro"
		Me.ListBoxNuméro.Size = New System.Drawing.Size(53, 199)
		Me.ListBoxNuméro.TabIndex = 18
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(68, 125)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(32, 13)
		Me.Label1.TabIndex = 25
		Me.Label1.Text = "Nom:"
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(71, 144)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(120, 199)
		Me.ListBox1.TabIndex = 24
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(197, 349)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(248, 31)
		Me.Button2.TabIndex = 27
		Me.Button2.Text = "Accueil"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 349)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(179, 31)
		Me.Button1.TabIndex = 26
		Me.Button1.Text = "Retour"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'BilanMatière
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(457, 390)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.LabelNom)
		Me.Controls.Add(Me.ListBoxPrénom)
		Me.Controls.Add(Me.LabelPrénom)
		Me.Controls.Add(Me.ListBoxNom)
		Me.Controls.Add(Me.LabelNuméro)
		Me.Controls.Add(Me.ListBoxNuméro)
		Me.Controls.Add(Me.GroupBoxRégion)
		Me.Controls.Add(Me.Titre)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "BilanMatière"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NatConcours - Bilan par matière"
		Me.GroupBoxRégion.ResumeLayout(False)
		Me.GroupBoxRégion.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBoxRégion As GroupBox
	Friend WithEvents LabelRégion As Label
	Friend WithEvents ComboBoxMatière As ComboBox
	Friend WithEvents Titre As Label
	Friend WithEvents LabelNom As Label
	Friend WithEvents ListBoxPrénom As ListBox
	Friend WithEvents LabelPrénom As Label
	Friend WithEvents ListBoxNom As ListBox
	Friend WithEvents LabelNuméro As Label
	Friend WithEvents ListBoxNuméro As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
End Class
