<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterStagiaire
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
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_NomJF = New System.Windows.Forms.TextBox()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.CB_civ = New System.Windows.Forms.ComboBox()
        Me.TB_Nationalite = New System.Windows.Forms.TextBox()
        Me.TB_Adresse = New System.Windows.Forms.TextBox()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.TB_Ville = New System.Windows.Forms.TextBox()
        Me.TB_Pays = New System.Windows.Forms.TextBox()
        Me.TB_NumTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_Mail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(112, 52)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Civilité:"
        '
        'TB_NomJF
        '
        Me.TB_NomJF.Location = New System.Drawing.Point(112, 78)
        Me.TB_NomJF.Name = "TB_NomJF"
        Me.TB_NomJF.Size = New System.Drawing.Size(100, 20)
        Me.TB_NomJF.TabIndex = 2
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Location = New System.Drawing.Point(112, 104)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(100, 20)
        Me.TB_Prenom.TabIndex = 3
        '
        'CB_civ
        '
        Me.CB_civ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_civ.FormattingEnabled = True
        Me.CB_civ.Items.AddRange(New Object() {"Mademoiselle", "Monsieur", "Madame"})
        Me.CB_civ.Location = New System.Drawing.Point(112, 25)
        Me.CB_civ.Name = "CB_civ"
        Me.CB_civ.Size = New System.Drawing.Size(100, 21)
        Me.CB_civ.TabIndex = 4
        '
        'TB_Nationalite
        '
        Me.TB_Nationalite.Location = New System.Drawing.Point(112, 130)
        Me.TB_Nationalite.Name = "TB_Nationalite"
        Me.TB_Nationalite.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nationalite.TabIndex = 5
        '
        'TB_Adresse
        '
        Me.TB_Adresse.Location = New System.Drawing.Point(112, 156)
        Me.TB_Adresse.Name = "TB_Adresse"
        Me.TB_Adresse.Size = New System.Drawing.Size(100, 20)
        Me.TB_Adresse.TabIndex = 6
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(112, 181)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(100, 20)
        Me.TB_CP.TabIndex = 7
        '
        'TB_Ville
        '
        Me.TB_Ville.Location = New System.Drawing.Point(112, 208)
        Me.TB_Ville.Name = "TB_Ville"
        Me.TB_Ville.Size = New System.Drawing.Size(100, 20)
        Me.TB_Ville.TabIndex = 8
        '
        'TB_Pays
        '
        Me.TB_Pays.Location = New System.Drawing.Point(112, 234)
        Me.TB_Pays.Name = "TB_Pays"
        Me.TB_Pays.Size = New System.Drawing.Size(100, 20)
        Me.TB_Pays.TabIndex = 9
        '
        'TB_NumTel
        '
        Me.TB_NumTel.Location = New System.Drawing.Point(112, 260)
        Me.TB_NumTel.Name = "TB_NumTel"
        Me.TB_NumTel.Size = New System.Drawing.Size(100, 20)
        Me.TB_NumTel.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nom:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nom de jeune fille:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Prénom:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nationalité:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Adresse:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Code postal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Ville:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pays:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Téléphone:"
        '
        'TB_Mail
        '
        Me.TB_Mail.Location = New System.Drawing.Point(112, 286)
        Me.TB_Mail.Name = "TB_Mail"
        Me.TB_Mail.Size = New System.Drawing.Size(100, 20)
        Me.TB_Mail.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "E-mail:"
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Location = New System.Drawing.Point(123, 328)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter.TabIndex = 22
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'AjouterStagiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 373)
        Me.Controls.Add(Me.BT_Ajouter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TB_Mail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_NumTel)
        Me.Controls.Add(Me.TB_Pays)
        Me.Controls.Add(Me.TB_Ville)
        Me.Controls.Add(Me.TB_CP)
        Me.Controls.Add(Me.TB_Adresse)
        Me.Controls.Add(Me.TB_Nationalite)
        Me.Controls.Add(Me.CB_civ)
        Me.Controls.Add(Me.TB_Prenom)
        Me.Controls.Add(Me.TB_NomJF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Nom)
        Me.Name = "AjouterStagiaire"
        Me.Text = "Ajouter un stagiaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_NomJF As TextBox
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents CB_civ As ComboBox
    Friend WithEvents TB_Nationalite As TextBox
    Friend WithEvents TB_Adresse As TextBox
    Friend WithEvents TB_CP As TextBox
    Friend WithEvents TB_Ville As TextBox
    Friend WithEvents TB_Pays As TextBox
    Friend WithEvents TB_NumTel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_Mail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BT_Ajouter As Button
End Class
