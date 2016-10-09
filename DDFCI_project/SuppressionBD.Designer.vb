<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppressionBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppressionBD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Liste_personne = New System.Windows.Forms.DataGridView()
        Me.PersonneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.BT_rechercher = New System.Windows.Forms.Button()
        Me.TB_Prenom_R = New System.Windows.Forms.TextBox()
        Me.TB_Nom_R = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BT_Suppr = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.PersonneTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.PersonneTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Liste_personne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(22, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 243)
        Me.GroupBox1.TabIndex = 4
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
        Me.DG_Liste_personne.Location = New System.Drawing.Point(30, 99)
        Me.DG_Liste_personne.Name = "DG_Liste_personne"
        Me.DG_Liste_personne.Size = New System.Drawing.Size(272, 131)
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
        Me.BT_rechercher.Location = New System.Drawing.Point(131, 70)
        Me.BT_rechercher.Name = "BT_rechercher"
        Me.BT_rechercher.Size = New System.Drawing.Size(75, 23)
        Me.BT_rechercher.TabIndex = 4
        Me.BT_rechercher.Text = "Rechercher"
        Me.BT_rechercher.UseVisualStyleBackColor = True
        '
        'TB_Prenom_R
        '
        Me.TB_Prenom_R.Location = New System.Drawing.Point(203, 40)
        Me.TB_Prenom_R.Name = "TB_Prenom_R"
        Me.TB_Prenom_R.Size = New System.Drawing.Size(99, 20)
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
        Me.Label9.Location = New System.Drawing.Point(216, 23)
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
        'BT_Suppr
        '
        Me.BT_Suppr.Location = New System.Drawing.Point(97, 286)
        Me.BT_Suppr.Name = "BT_Suppr"
        Me.BT_Suppr.Size = New System.Drawing.Size(75, 23)
        Me.BT_Suppr.TabIndex = 5
        Me.BT_Suppr.Text = "Supprimer"
        Me.BT_Suppr.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(214, 286)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 6
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'PersonneTableAdapter
        '
        Me.PersonneTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.PersonneBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(391, 25)
        Me.BindingNavigator1.TabIndex = 7
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.CivilitePDataGridViewTextBoxColumn.DataPropertyName = "CiviliteP"
        Me.CivilitePDataGridViewTextBoxColumn.HeaderText = "CiviliteP"
        Me.CivilitePDataGridViewTextBoxColumn.Name = "CivilitePDataGridViewTextBoxColumn"
        Me.CivilitePDataGridViewTextBoxColumn.Visible = False
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
        Me.PrenomPDataGridViewTextBoxColumn.HeaderText = "Prenom"
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
        'SuppressionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 348)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Suppr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SuppressionBD"
        Me.Text = "Supprimer intervenant(e)/stagiaire"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Liste_personne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DG_Liste_personne As DataGridView
    Friend WithEvents BT_rechercher As Button
    Friend WithEvents TB_Prenom_R As TextBox
    Friend WithEvents TB_Nom_R As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BT_Suppr As Button
    Friend WithEvents BT_Annuler As Button
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents PersonneBindingSource As BindingSource
    Friend WithEvents PersonneTableAdapter As Formation_ContinueDataSet1TableAdapters.PersonneTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
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
End Class
