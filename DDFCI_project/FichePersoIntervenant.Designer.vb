<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FichePersoIntervenant
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_LieuNaissance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_DateNaissance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_NomJF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_civilite = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TB_NumSS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_Pays = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabelMail = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_Telephone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RTB_AdresseEntreprise = New System.Windows.Forms.RichTextBox()
        Me.RTB_Entreprise = New System.Windows.Forms.RichTextBox()
        Me.RTB_Profession = New System.Windows.Forms.RichTextBox()
        Me.RTB_Adresse = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.TB_LieuNaissance)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TB_DateNaissance)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TB_Prenom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TB_NomJF)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TB_Nom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CB_civilite)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(28, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 218)
        Me.Panel1.TabIndex = 0
        '
        'TB_LieuNaissance
        '
        Me.TB_LieuNaissance.Enabled = False
        Me.TB_LieuNaissance.Location = New System.Drawing.Point(98, 183)
        Me.TB_LieuNaissance.Name = "TB_LieuNaissance"
        Me.TB_LieuNaissance.Size = New System.Drawing.Size(97, 20)
        Me.TB_LieuNaissance.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "A:"
        '
        'TB_DateNaissance
        '
        Me.TB_DateNaissance.Enabled = False
        Me.TB_DateNaissance.Location = New System.Drawing.Point(98, 153)
        Me.TB_DateNaissance.Name = "TB_DateNaissance"
        Me.TB_DateNaissance.Size = New System.Drawing.Size(97, 20)
        Me.TB_DateNaissance.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Né(e) le:"
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Enabled = False
        Me.TB_Prenom.Location = New System.Drawing.Point(98, 121)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(97, 20)
        Me.TB_Prenom.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom:"
        '
        'TB_NomJF
        '
        Me.TB_NomJF.Enabled = False
        Me.TB_NomJF.Location = New System.Drawing.Point(98, 90)
        Me.TB_NomJF.Name = "TB_NomJF"
        Me.TB_NomJF.Size = New System.Drawing.Size(97, 20)
        Me.TB_NomJF.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nom de jeune fille:"
        '
        'TB_Nom
        '
        Me.TB_Nom.Enabled = False
        Me.TB_Nom.Location = New System.Drawing.Point(98, 56)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(97, 20)
        Me.TB_Nom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom:"
        '
        'CB_civilite
        '
        Me.CB_civilite.Enabled = False
        Me.CB_civilite.FormattingEnabled = True
        Me.CB_civilite.Items.AddRange(New Object() {"Mademoiselle", "Madame", "Monsieur"})
        Me.CB_civilite.Location = New System.Drawing.Point(98, 23)
        Me.CB_civilite.Name = "CB_civilite"
        Me.CB_civilite.Size = New System.Drawing.Size(97, 21)
        Me.CB_civilite.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Civilité:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TB_NumSS)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TB_Pays)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.LinkLabelMail)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TB_Telephone)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.RTB_Adresse)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(259, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 216)
        Me.Panel2.TabIndex = 2
        '
        'TB_NumSS
        '
        Me.TB_NumSS.Enabled = False
        Me.TB_NumSS.Location = New System.Drawing.Point(77, 142)
        Me.TB_NumSS.Name = "TB_NumSS"
        Me.TB_NumSS.Size = New System.Drawing.Size(120, 20)
        Me.TB_NumSS.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "N° SS:"
        '
        'TB_Pays
        '
        Me.TB_Pays.Enabled = False
        Me.TB_Pays.Location = New System.Drawing.Point(77, 113)
        Me.TB_Pays.Name = "TB_Pays"
        Me.TB_Pays.Size = New System.Drawing.Size(120, 20)
        Me.TB_Pays.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Pays:"
        '
        'LinkLabelMail
        '
        Me.LinkLabelMail.AutoSize = True
        Me.LinkLabelMail.Location = New System.Drawing.Point(74, 181)
        Me.LinkLabelMail.Name = "LinkLabelMail"
        Me.LinkLabelMail.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabelMail.TabIndex = 5
        Me.LinkLabelMail.TabStop = True
        Me.LinkLabelMail.Text = "LinkLabel1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Mail:"
        '
        'TB_Telephone
        '
        Me.TB_Telephone.Enabled = False
        Me.TB_Telephone.Location = New System.Drawing.Point(77, 22)
        Me.TB_Telephone.Name = "TB_Telephone"
        Me.TB_Telephone.Size = New System.Drawing.Size(120, 20)
        Me.TB_Telephone.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Téléphone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Adresse:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.RTB_AdresseEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.RTB_Entreprise)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.RTB_Profession)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(482, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 224)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entreprise"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Profession:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Entreprise:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Adresse:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Anciennete:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'RTB_AdresseEntreprise
        '
        Me.RTB_AdresseEntreprise.Enabled = False
        Me.RTB_AdresseEntreprise.Location = New System.Drawing.Point(76, 134)
        Me.RTB_AdresseEntreprise.Name = "RTB_AdresseEntreprise"
        Me.RTB_AdresseEntreprise.Size = New System.Drawing.Size(130, 41)
        Me.RTB_AdresseEntreprise.TabIndex = 5
        Me.RTB_AdresseEntreprise.Text = ""
        '
        'RTB_Entreprise
        '
        Me.RTB_Entreprise.Enabled = False
        Me.RTB_Entreprise.Location = New System.Drawing.Point(76, 82)
        Me.RTB_Entreprise.Name = "RTB_Entreprise"
        Me.RTB_Entreprise.Size = New System.Drawing.Size(130, 40)
        Me.RTB_Entreprise.TabIndex = 3
        Me.RTB_Entreprise.Text = ""
        '
        'RTB_Profession
        '
        Me.RTB_Profession.Enabled = False
        Me.RTB_Profession.Location = New System.Drawing.Point(76, 32)
        Me.RTB_Profession.Name = "RTB_Profession"
        Me.RTB_Profession.Size = New System.Drawing.Size(130, 39)
        Me.RTB_Profession.TabIndex = 1
        Me.RTB_Profession.Text = ""
        '
        'RTB_Adresse
        '
        Me.RTB_Adresse.Enabled = False
        Me.RTB_Adresse.Location = New System.Drawing.Point(77, 54)
        Me.RTB_Adresse.Name = "RTB_Adresse"
        Me.RTB_Adresse.Size = New System.Drawing.Size(120, 48)
        Me.RTB_Adresse.TabIndex = 1
        Me.RTB_Adresse.Text = ""
        '
        'FichePersoIntervenant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 329)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FichePersoIntervenant"
        Me.Text = "Fiche Personelle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CB_civilite As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_NomJF As TextBox
    Friend WithEvents TB_LieuNaissance As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_DateNaissance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabelMail As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_Telephone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Pays As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_NumSS As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RTB_Adresse As RichTextBox
    Friend WithEvents RTB_AdresseEntreprise As RichTextBox
    Friend WithEvents RTB_Entreprise As RichTextBox
    Friend WithEvents RTB_Profession As RichTextBox
End Class
