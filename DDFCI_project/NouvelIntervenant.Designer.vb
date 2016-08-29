<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouvelIntervenant
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_Type = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_civ = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Mail = New System.Windows.Forms.TextBox()
        Me.TB_Tel = New System.Windows.Forms.TextBox()
        Me.TB_Nationalite = New System.Windows.Forms.TextBox()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Liste_personne = New System.Windows.Forms.DataGridView()
        Me.PersonneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.BT_rechercher = New System.Windows.Forms.Button()
        Me.TB_Prenom_R = New System.Windows.Forms.TextBox()
        Me.TB_Nom_R = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PersonneTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.PersonneTableAdapter()
        Me.IdPersonneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilitePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomJeuneFilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalitePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VillePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaysPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumTelPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_Ajouter_R = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Liste_personne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CB_Type)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CB_civ)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TB_Mail)
        Me.Panel1.Controls.Add(Me.TB_Tel)
        Me.Panel1.Controls.Add(Me.TB_Nationalite)
        Me.Panel1.Controls.Add(Me.TB_Prenom)
        Me.Panel1.Controls.Add(Me.TB_Nom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 234)
        Me.Panel1.TabIndex = 0
        '
        'CB_Type
        '
        Me.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.Items.AddRange(New Object() {"Externe", "Interne"})
        Me.CB_Type.Location = New System.Drawing.Point(117, 203)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(106, 21)
        Me.CB_Type.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Type d'intervenant:"
        '
        'CB_civ
        '
        Me.CB_civ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_civ.FormattingEnabled = True
        Me.CB_civ.Items.AddRange(New Object() {"Mme.", "M."})
        Me.CB_civ.Location = New System.Drawing.Point(117, 6)
        Me.CB_civ.Name = "CB_civ"
        Me.CB_civ.Size = New System.Drawing.Size(55, 21)
        Me.CB_civ.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Civilité:"
        '
        'TB_Mail
        '
        Me.TB_Mail.Location = New System.Drawing.Point(117, 173)
        Me.TB_Mail.Name = "TB_Mail"
        Me.TB_Mail.Size = New System.Drawing.Size(154, 20)
        Me.TB_Mail.TabIndex = 9
        '
        'TB_Tel
        '
        Me.TB_Tel.Location = New System.Drawing.Point(117, 137)
        Me.TB_Tel.Name = "TB_Tel"
        Me.TB_Tel.Size = New System.Drawing.Size(154, 20)
        Me.TB_Tel.TabIndex = 8
        '
        'TB_Nationalite
        '
        Me.TB_Nationalite.Location = New System.Drawing.Point(117, 102)
        Me.TB_Nationalite.Name = "TB_Nationalite"
        Me.TB_Nationalite.Size = New System.Drawing.Size(154, 20)
        Me.TB_Nationalite.TabIndex = 7
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Location = New System.Drawing.Point(117, 66)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(154, 20)
        Me.TB_Prenom.TabIndex = 6
        '
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(117, 33)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(154, 20)
        Me.TB_Nom.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Téléphone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nationalité:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénom(s):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Location = New System.Drawing.Point(65, 290)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter.TabIndex = 1
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(161, 290)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 2
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_Liste_personne)
        Me.GroupBox1.Controls.Add(Me.BT_rechercher)
        Me.GroupBox1.Controls.Add(Me.TB_Prenom_R)
        Me.GroupBox1.Controls.Add(Me.TB_Nom_R)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(326, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 243)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher"
        '
        'DG_Liste_personne
        '
        Me.DG_Liste_personne.AutoGenerateColumns = False
        Me.DG_Liste_personne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_personne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_personne.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonneDataGridViewTextBoxColumn, Me.CivilitePDataGridViewTextBoxColumn, Me.NomPDataGridViewTextBoxColumn, Me.NomJeuneFilleDataGridViewTextBoxColumn, Me.PrenomPDataGridViewTextBoxColumn, Me.NationalitePDataGridViewTextBoxColumn, Me.AdressePDataGridViewTextBoxColumn, Me.CPDataGridViewTextBoxColumn, Me.VillePDataGridViewTextBoxColumn, Me.PaysPDataGridViewTextBoxColumn, Me.NumTelPDataGridViewTextBoxColumn, Me.MailPDataGridViewTextBoxColumn})
        Me.DG_Liste_personne.DataSource = Me.PersonneBindingSource
        Me.DG_Liste_personne.Location = New System.Drawing.Point(19, 99)
        Me.DG_Liste_personne.Name = "DG_Liste_personne"
        Me.DG_Liste_personne.Size = New System.Drawing.Size(305, 131)
        Me.DG_Liste_personne.TabIndex = 5
        '
        'PersonneBindingSource
        '
        Me.PersonneBindingSource.DataMember = "Personne"
        Me.PersonneBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BT_rechercher
        '
        Me.BT_rechercher.Location = New System.Drawing.Point(115, 70)
        Me.BT_rechercher.Name = "BT_rechercher"
        Me.BT_rechercher.Size = New System.Drawing.Size(75, 23)
        Me.BT_rechercher.TabIndex = 4
        Me.BT_rechercher.Text = "Rechercher"
        Me.BT_rechercher.UseVisualStyleBackColor = True
        '
        'TB_Prenom_R
        '
        Me.TB_Prenom_R.Location = New System.Drawing.Point(174, 40)
        Me.TB_Prenom_R.Name = "TB_Prenom_R"
        Me.TB_Prenom_R.Size = New System.Drawing.Size(117, 20)
        Me.TB_Prenom_R.TabIndex = 3
        '
        'TB_Nom_R
        '
        Me.TB_Nom_R.Location = New System.Drawing.Point(30, 40)
        Me.TB_Nom_R.Name = "TB_Nom_R"
        Me.TB_Nom_R.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nom_R.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(207, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Prénom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nom"
        '
        'PersonneTableAdapter
        '
        Me.PersonneTableAdapter.ClearBeforeFill = True
        '
        'IdPersonneDataGridViewTextBoxColumn
        '
        Me.IdPersonneDataGridViewTextBoxColumn.DataPropertyName = "idPersonne"
        Me.IdPersonneDataGridViewTextBoxColumn.HeaderText = "idPersonne"
        Me.IdPersonneDataGridViewTextBoxColumn.Name = "IdPersonneDataGridViewTextBoxColumn"
        Me.IdPersonneDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPersonneDataGridViewTextBoxColumn.Visible = False
        '
        'CivilitePDataGridViewTextBoxColumn
        '
        Me.CivilitePDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CivilitePDataGridViewTextBoxColumn.DataPropertyName = "CiviliteP"
        Me.CivilitePDataGridViewTextBoxColumn.HeaderText = "Civilité"
        Me.CivilitePDataGridViewTextBoxColumn.Name = "CivilitePDataGridViewTextBoxColumn"
        Me.CivilitePDataGridViewTextBoxColumn.Visible = False
        Me.CivilitePDataGridViewTextBoxColumn.Width = 62
        '
        'NomPDataGridViewTextBoxColumn
        '
        Me.NomPDataGridViewTextBoxColumn.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomPDataGridViewTextBoxColumn.Name = "NomPDataGridViewTextBoxColumn"
        '
        'NomJeuneFilleDataGridViewTextBoxColumn
        '
        Me.NomJeuneFilleDataGridViewTextBoxColumn.DataPropertyName = "NomJeuneFille"
        Me.NomJeuneFilleDataGridViewTextBoxColumn.HeaderText = "NomJeuneFille"
        Me.NomJeuneFilleDataGridViewTextBoxColumn.Name = "NomJeuneFilleDataGridViewTextBoxColumn"
        Me.NomJeuneFilleDataGridViewTextBoxColumn.Visible = False
        '
        'PrenomPDataGridViewTextBoxColumn
        '
        Me.PrenomPDataGridViewTextBoxColumn.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.PrenomPDataGridViewTextBoxColumn.Name = "PrenomPDataGridViewTextBoxColumn"
        '
        'NationalitePDataGridViewTextBoxColumn
        '
        Me.NationalitePDataGridViewTextBoxColumn.DataPropertyName = "NationaliteP"
        Me.NationalitePDataGridViewTextBoxColumn.HeaderText = "NationaliteP"
        Me.NationalitePDataGridViewTextBoxColumn.Name = "NationalitePDataGridViewTextBoxColumn"
        Me.NationalitePDataGridViewTextBoxColumn.Visible = False
        '
        'AdressePDataGridViewTextBoxColumn
        '
        Me.AdressePDataGridViewTextBoxColumn.DataPropertyName = "AdresseP"
        Me.AdressePDataGridViewTextBoxColumn.HeaderText = "AdresseP"
        Me.AdressePDataGridViewTextBoxColumn.Name = "AdressePDataGridViewTextBoxColumn"
        Me.AdressePDataGridViewTextBoxColumn.Visible = False
        '
        'CPDataGridViewTextBoxColumn
        '
        Me.CPDataGridViewTextBoxColumn.DataPropertyName = "CP"
        Me.CPDataGridViewTextBoxColumn.HeaderText = "CP"
        Me.CPDataGridViewTextBoxColumn.Name = "CPDataGridViewTextBoxColumn"
        Me.CPDataGridViewTextBoxColumn.Visible = False
        '
        'VillePDataGridViewTextBoxColumn
        '
        Me.VillePDataGridViewTextBoxColumn.DataPropertyName = "VilleP"
        Me.VillePDataGridViewTextBoxColumn.HeaderText = "VilleP"
        Me.VillePDataGridViewTextBoxColumn.Name = "VillePDataGridViewTextBoxColumn"
        Me.VillePDataGridViewTextBoxColumn.Visible = False
        '
        'PaysPDataGridViewTextBoxColumn
        '
        Me.PaysPDataGridViewTextBoxColumn.DataPropertyName = "PaysP"
        Me.PaysPDataGridViewTextBoxColumn.HeaderText = "PaysP"
        Me.PaysPDataGridViewTextBoxColumn.Name = "PaysPDataGridViewTextBoxColumn"
        Me.PaysPDataGridViewTextBoxColumn.Visible = False
        '
        'NumTelPDataGridViewTextBoxColumn
        '
        Me.NumTelPDataGridViewTextBoxColumn.DataPropertyName = "NumTelP"
        Me.NumTelPDataGridViewTextBoxColumn.HeaderText = "NumTelP"
        Me.NumTelPDataGridViewTextBoxColumn.Name = "NumTelPDataGridViewTextBoxColumn"
        Me.NumTelPDataGridViewTextBoxColumn.Visible = False
        '
        'MailPDataGridViewTextBoxColumn
        '
        Me.MailPDataGridViewTextBoxColumn.DataPropertyName = "MailP"
        Me.MailPDataGridViewTextBoxColumn.HeaderText = "MailP"
        Me.MailPDataGridViewTextBoxColumn.Name = "MailPDataGridViewTextBoxColumn"
        Me.MailPDataGridViewTextBoxColumn.Visible = False
        '
        'BT_Ajouter_R
        '
        Me.BT_Ajouter_R.Location = New System.Drawing.Point(471, 290)
        Me.BT_Ajouter_R.Name = "BT_Ajouter_R"
        Me.BT_Ajouter_R.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter_R.TabIndex = 4
        Me.BT_Ajouter_R.Text = "Ajouter"
        Me.BT_Ajouter_R.UseVisualStyleBackColor = True
        '
        'NouvelIntervenant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 338)
        Me.Controls.Add(Me.BT_Ajouter_R)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Ajouter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NouvelIntervenant"
        Me.Text = "Ajouter un(e) intervenant(e)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Liste_personne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BT_Ajouter As Button
    Friend WithEvents BT_Annuler As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Mail As TextBox
    Friend WithEvents TB_Tel As TextBox
    Friend WithEvents TB_Nationalite As TextBox
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_civ As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_Type As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TB_Prenom_R As TextBox
    Friend WithEvents TB_Nom_R As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BT_rechercher As Button
    Friend WithEvents DG_Liste_personne As DataGridView
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents PersonneBindingSource As BindingSource
    Friend WithEvents PersonneTableAdapter As Formation_ContinueDataSet1TableAdapters.PersonneTableAdapter
    Friend WithEvents IdPersonneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivilitePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomJeuneFilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NationalitePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdressePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VillePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaysPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumTelPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BT_Ajouter_R As Button
End Class
