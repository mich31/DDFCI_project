<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formation
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TV_Menu = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabIntervenants = New System.Windows.Forms.TabPage()
        Me.DG_Intervenant = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkEmailIntervenant = New System.Windows.Forms.LinkLabel()
        Me.TB_Telephone = New System.Windows.Forms.TextBox()
        Me.TB_DateNaissance = New System.Windows.Forms.TextBox()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListeIntervenants = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DG_Stagiaire = New System.Windows.Forms.DataGridView()
        Me.BT_Ajout_Stagiaire = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CB_convoc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CB_FSF = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_DSE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BT_FichePerso = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabIntervenants.SuspendLayout()
        CType(Me.DG_Intervenant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DG_Stagiaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.FormationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'FormationToolStripMenuItem
        '
        Me.FormationToolStripMenuItem.Name = "FormationToolStripMenuItem"
        Me.FormationToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.FormationToolStripMenuItem.Text = "Formation"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1234, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TV_Menu
        '
        Me.TV_Menu.Location = New System.Drawing.Point(12, 52)
        Me.TV_Menu.Name = "TV_Menu"
        Me.TV_Menu.Size = New System.Drawing.Size(179, 404)
        Me.TV_Menu.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabIntervenants)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(208, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 761)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(803, 735)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tableau de bord"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(49, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(803, 735)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Planning"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabIntervenants
        '
        Me.TabIntervenants.BackColor = System.Drawing.SystemColors.Control
        Me.TabIntervenants.Controls.Add(Me.DG_Intervenant)
        Me.TabIntervenants.Controls.Add(Me.GroupBox1)
        Me.TabIntervenants.Controls.Add(Me.ListeIntervenants)
        Me.TabIntervenants.Location = New System.Drawing.Point(4, 22)
        Me.TabIntervenants.Name = "TabIntervenants"
        Me.TabIntervenants.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIntervenants.Size = New System.Drawing.Size(803, 735)
        Me.TabIntervenants.TabIndex = 2
        Me.TabIntervenants.Text = "Intervenants"
        '
        'DG_Intervenant
        '
        Me.DG_Intervenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Intervenant.Location = New System.Drawing.Point(190, 271)
        Me.DG_Intervenant.Name = "DG_Intervenant"
        Me.DG_Intervenant.ReadOnly = True
        Me.DG_Intervenant.Size = New System.Drawing.Size(535, 209)
        Me.DG_Intervenant.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_FichePerso)
        Me.GroupBox1.Controls.Add(Me.LinkEmailIntervenant)
        Me.GroupBox1.Controls.Add(Me.TB_Telephone)
        Me.GroupBox1.Controls.Add(Me.TB_DateNaissance)
        Me.GroupBox1.Controls.Add(Me.TB_Prenom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_Nom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 191)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiche Personnelle"
        '
        'LinkEmailIntervenant
        '
        Me.LinkEmailIntervenant.AutoSize = True
        Me.LinkEmailIntervenant.Location = New System.Drawing.Point(120, 130)
        Me.LinkEmailIntervenant.Name = "LinkEmailIntervenant"
        Me.LinkEmailIntervenant.Size = New System.Drawing.Size(89, 13)
        Me.LinkEmailIntervenant.TabIndex = 9
        Me.LinkEmailIntervenant.TabStop = True
        Me.LinkEmailIntervenant.Text = "Email Intervenant"
        '
        'TB_Telephone
        '
        Me.TB_Telephone.Enabled = False
        Me.TB_Telephone.Location = New System.Drawing.Point(123, 104)
        Me.TB_Telephone.Name = "TB_Telephone"
        Me.TB_Telephone.Size = New System.Drawing.Size(147, 20)
        Me.TB_Telephone.TabIndex = 8
        '
        'TB_DateNaissance
        '
        Me.TB_DateNaissance.Enabled = False
        Me.TB_DateNaissance.Location = New System.Drawing.Point(123, 79)
        Me.TB_DateNaissance.Name = "TB_DateNaissance"
        Me.TB_DateNaissance.Size = New System.Drawing.Size(147, 20)
        Me.TB_DateNaissance.TabIndex = 7
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Enabled = False
        Me.TB_Prenom.Location = New System.Drawing.Point(123, 53)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(147, 20)
        Me.TB_Prenom.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Téléphone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date de naissance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prenom(s):"
        '
        'TB_Nom
        '
        Me.TB_Nom.Enabled = False
        Me.TB_Nom.Location = New System.Drawing.Point(123, 25)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(147, 20)
        Me.TB_Nom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'ListeIntervenants
        '
        Me.ListeIntervenants.FormattingEnabled = True
        Me.ListeIntervenants.Location = New System.Drawing.Point(17, 24)
        Me.ListeIntervenants.Name = "ListeIntervenants"
        Me.ListeIntervenants.Size = New System.Drawing.Size(126, 355)
        Me.ListeIntervenants.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.DG_Stagiaire)
        Me.TabPage4.Controls.Add(Me.BT_Ajout_Stagiaire)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(803, 735)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Stagiaires"
        '
        'DG_Stagiaire
        '
        Me.DG_Stagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Stagiaire.Location = New System.Drawing.Point(138, 160)
        Me.DG_Stagiaire.Name = "DG_Stagiaire"
        Me.DG_Stagiaire.Size = New System.Drawing.Size(563, 328)
        Me.DG_Stagiaire.TabIndex = 1
        '
        'BT_Ajout_Stagiaire
        '
        Me.BT_Ajout_Stagiaire.Location = New System.Drawing.Point(38, 53)
        Me.BT_Ajout_Stagiaire.Name = "BT_Ajout_Stagiaire"
        Me.BT_Ajout_Stagiaire.Size = New System.Drawing.Size(85, 31)
        Me.BT_Ajout_Stagiaire.TabIndex = 0
        Me.BT_Ajout_Stagiaire.Text = "Ajouter"
        Me.BT_Ajout_Stagiaire.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(803, 735)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Documents"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(56, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 305)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stagiaire(s)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.CB_convoc)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CB_FSF)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CB_DSE)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 272)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Intervenant(s)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Générer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CB_convoc
        '
        Me.CB_convoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_convoc.FormattingEnabled = True
        Me.CB_convoc.Location = New System.Drawing.Point(154, 144)
        Me.CB_convoc.Name = "CB_convoc"
        Me.CB_convoc.Size = New System.Drawing.Size(149, 21)
        Me.CB_convoc.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Convocation:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(336, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Générer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CB_FSF
        '
        Me.CB_FSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FSF.FormattingEnabled = True
        Me.CB_FSF.Location = New System.Drawing.Point(154, 97)
        Me.CB_FSF.Name = "CB_FSF"
        Me.CB_FSF.Size = New System.Drawing.Size(149, 21)
        Me.CB_FSF.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fiche service fait:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Générer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_DSE
        '
        Me.CB_DSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DSE.FormattingEnabled = True
        Me.CB_DSE.Location = New System.Drawing.Point(154, 55)
        Me.CB_DSE.Name = "CB_DSE"
        Me.CB_DSE.Size = New System.Drawing.Size(149, 21)
        Me.CB_DSE.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Dossier d'engagement:"
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(803, 735)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Temps de travail"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'BT_FichePerso
        '
        Me.BT_FichePerso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_FichePerso.Location = New System.Drawing.Point(146, 159)
        Me.BT_FichePerso.Name = "BT_FichePerso"
        Me.BT_FichePerso.Size = New System.Drawing.Size(30, 26)
        Me.BT_FichePerso.TabIndex = 10
        Me.BT_FichePerso.Text = "V"
        Me.BT_FichePerso.UseVisualStyleBackColor = True
        '
        'Formation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 942)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TV_Menu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDFCI Project"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabIntervenants.ResumeLayout(False)
        CType(Me.DG_Intervenant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DG_Stagiaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TV_Menu As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabIntervenants As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeIntervenants As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Telephone As TextBox
    Friend WithEvents TB_DateNaissance As TextBox
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkEmailIntervenant As LinkLabel
    Friend WithEvents DG_Intervenant As DataGridView
    Friend WithEvents BT_Ajout_Stagiaire As Button
    Friend WithEvents DG_Stagiaire As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CB_DSE As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CB_FSF As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_convoc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BT_FichePerso As Button
End Class
