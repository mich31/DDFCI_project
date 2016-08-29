<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupprimerUtilisateur
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
        Me.DG_Liste_utilisateurs = New System.Windows.Forms.DataGridView()
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonnelTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.PersonnelTableAdapter()
        Me.LoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FonctionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelecopieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BT_Supprimer = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.BT_Actualiser = New System.Windows.Forms.Button()
        CType(Me.DG_Liste_utilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Liste_utilisateurs
        '
        Me.DG_Liste_utilisateurs.AutoGenerateColumns = False
        Me.DG_Liste_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_utilisateurs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.FonctionDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.TelecopieDataGridViewTextBoxColumn})
        Me.DG_Liste_utilisateurs.DataSource = Me.PersonnelBindingSource
        Me.DG_Liste_utilisateurs.Location = New System.Drawing.Point(26, 46)
        Me.DG_Liste_utilisateurs.Name = "DG_Liste_utilisateurs"
        Me.DG_Liste_utilisateurs.Size = New System.Drawing.Size(313, 172)
        Me.DG_Liste_utilisateurs.TabIndex = 0
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonnelBindingSource
        '
        Me.PersonnelBindingSource.DataMember = "Personnel"
        Me.PersonnelBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'PersonnelTableAdapter
        '
        Me.PersonnelTableAdapter.ClearBeforeFill = True
        '
        'LoginDataGridViewTextBoxColumn
        '
        Me.LoginDataGridViewTextBoxColumn.DataPropertyName = "Login"
        Me.LoginDataGridViewTextBoxColumn.HeaderText = "Nom d'utilisateur"
        Me.LoginDataGridViewTextBoxColumn.Name = "LoginDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'FonctionDataGridViewTextBoxColumn
        '
        Me.FonctionDataGridViewTextBoxColumn.DataPropertyName = "Fonction"
        Me.FonctionDataGridViewTextBoxColumn.HeaderText = "Fonction"
        Me.FonctionDataGridViewTextBoxColumn.Name = "FonctionDataGridViewTextBoxColumn"
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "Mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.Visible = False
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.Visible = False
        '
        'TelecopieDataGridViewTextBoxColumn
        '
        Me.TelecopieDataGridViewTextBoxColumn.DataPropertyName = "Telecopie"
        Me.TelecopieDataGridViewTextBoxColumn.HeaderText = "Telecopie"
        Me.TelecopieDataGridViewTextBoxColumn.Name = "TelecopieDataGridViewTextBoxColumn"
        Me.TelecopieDataGridViewTextBoxColumn.Visible = False
        '
        'BT_Supprimer
        '
        Me.BT_Supprimer.Location = New System.Drawing.Point(26, 260)
        Me.BT_Supprimer.Name = "BT_Supprimer"
        Me.BT_Supprimer.Size = New System.Drawing.Size(75, 23)
        Me.BT_Supprimer.TabIndex = 1
        Me.BT_Supprimer.Text = "Supprimer"
        Me.BT_Supprimer.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(264, 260)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 2
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'BT_Actualiser
        '
        Me.BT_Actualiser.Location = New System.Drawing.Point(148, 260)
        Me.BT_Actualiser.Name = "BT_Actualiser"
        Me.BT_Actualiser.Size = New System.Drawing.Size(75, 23)
        Me.BT_Actualiser.TabIndex = 3
        Me.BT_Actualiser.Text = "Actualiser"
        Me.BT_Actualiser.UseVisualStyleBackColor = True
        '
        'SupprimerUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 328)
        Me.Controls.Add(Me.BT_Actualiser)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Supprimer)
        Me.Controls.Add(Me.DG_Liste_utilisateurs)
        Me.Name = "SupprimerUtilisateur"
        Me.Text = "Supprimer un utilisateur"
        CType(Me.DG_Liste_utilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG_Liste_utilisateurs As DataGridView
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents PersonnelBindingSource As BindingSource
    Friend WithEvents PersonnelTableAdapter As Formation_ContinueDataSet1TableAdapters.PersonnelTableAdapter
    Friend WithEvents LoginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FonctionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelecopieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BT_Supprimer As Button
    Friend WithEvents BT_Annuler As Button
    Friend WithEvents BT_Actualiser As Button
End Class
