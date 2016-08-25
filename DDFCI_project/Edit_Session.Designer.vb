<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Session
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
        Me.components = New System.ComponentModel.Container()
        Me.DG_Liste_Sessions = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_Formation = New System.Windows.Forms.ComboBox()
        Me.FormationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CB_AF = New System.Windows.Forms.ComboBox()
        Me.ListeassistantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_CP = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Liste_chefs_de_projetsTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.liste_chefs_de_projetsTableAdapter()
        Me.Liste_assistantesTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.liste_assistantesTableAdapter()
        Me.FormationTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.FormationTableAdapter()
        Me.TB_Session = New System.Windows.Forms.TextBox()
        CType(Me.DG_Liste_Sessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FormationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ListeassistantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Liste_Sessions
        '
        Me.DG_Liste_Sessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Sessions.Location = New System.Drawing.Point(14, 37)
        Me.DG_Liste_Sessions.Name = "DG_Liste_Sessions"
        Me.DG_Liste_Sessions.ReadOnly = True
        Me.DG_Liste_Sessions.Size = New System.Drawing.Size(374, 150)
        Me.DG_Liste_Sessions.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TB_Session)
        Me.Panel1.Controls.Add(Me.CB_Formation)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.BT_Ajouter)
        Me.Panel1.Controls.Add(Me.DTP_Fin)
        Me.Panel1.Controls.Add(Me.DTP_Debut)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(14, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 208)
        Me.Panel1.TabIndex = 1
        '
        'CB_Formation
        '
        Me.CB_Formation.DataSource = Me.FormationBindingSource
        Me.CB_Formation.DisplayMember = "NomF"
        Me.CB_Formation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Formation.FormattingEnabled = True
        Me.CB_Formation.Location = New System.Drawing.Point(89, 14)
        Me.CB_Formation.Name = "CB_Formation"
        Me.CB_Formation.Size = New System.Drawing.Size(145, 21)
        Me.CB_Formation.TabIndex = 13
        '
        'FormationBindingSource
        '
        Me.FormationBindingSource.DataMember = "Formation"
        Me.FormationBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(231, 172)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Enregistrer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Location = New System.Drawing.Point(139, 172)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter.TabIndex = 11
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'DTP_Fin
        '
        Me.DTP_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fin.Location = New System.Drawing.Point(89, 108)
        Me.DTP_Fin.Name = "DTP_Fin"
        Me.DTP_Fin.Size = New System.Drawing.Size(100, 20)
        Me.DTP_Fin.TabIndex = 10
        '
        'DTP_Debut
        '
        Me.DTP_Debut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Debut.Location = New System.Drawing.Point(89, 82)
        Me.DTP_Debut.Name = "DTP_Debut"
        Me.DTP_Debut.Size = New System.Drawing.Size(100, 20)
        Me.DTP_Debut.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CB_AF)
        Me.Panel2.Controls.Add(Me.CB_CP)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(274, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 127)
        Me.Panel2.TabIndex = 8
        '
        'CB_AF
        '
        Me.CB_AF.DataSource = Me.ListeassistantesBindingSource
        Me.CB_AF.DisplayMember = "Login"
        Me.CB_AF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_AF.FormattingEnabled = True
        Me.CB_AF.Location = New System.Drawing.Point(30, 84)
        Me.CB_AF.Name = "CB_AF"
        Me.CB_AF.Size = New System.Drawing.Size(121, 21)
        Me.CB_AF.TabIndex = 7
        '
        'ListeassistantesBindingSource
        '
        Me.ListeassistantesBindingSource.DataMember = "liste_assistantes"
        Me.ListeassistantesBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'CB_CP
        '
        Me.CB_CP.DataSource = Me.BindingSource1
        Me.CB_CP.DisplayMember = "Login"
        Me.CB_CP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CP.FormattingEnabled = True
        Me.CB_CP.Location = New System.Drawing.Point(30, 30)
        Me.CB_CP.Name = "CB_CP"
        Me.CB_CP.Size = New System.Drawing.Size(121, 21)
        Me.CB_CP.TabIndex = 6
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "liste_chefs_de_projets"
        Me.BindingSource1.DataSource = Me.Formation_ContinueDataSet1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Chef(fe) de projet:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Assistant(e) de formation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Début:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Session:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formation:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(412, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nouveau"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(412, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(412, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Enregistrer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Liste_chefs_de_projetsTableAdapter
        '
        Me.Liste_chefs_de_projetsTableAdapter.ClearBeforeFill = True
        '
        'Liste_assistantesTableAdapter
        '
        Me.Liste_assistantesTableAdapter.ClearBeforeFill = True
        '
        'FormationTableAdapter
        '
        Me.FormationTableAdapter.ClearBeforeFill = True
        '
        'TB_Session
        '
        Me.TB_Session.Location = New System.Drawing.Point(89, 51)
        Me.TB_Session.Name = "TB_Session"
        Me.TB_Session.Size = New System.Drawing.Size(100, 20)
        Me.TB_Session.TabIndex = 14
        '
        'Edit_Session
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 457)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DG_Liste_Sessions)
        Me.Name = "Edit_Session"
        Me.Text = "Session de formation"
        CType(Me.DG_Liste_Sessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FormationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ListeassistantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG_Liste_Sessions As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DTP_Fin As DateTimePicker
    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CB_CP As ComboBox
    Friend WithEvents CB_AF As ComboBox
    Friend WithEvents ListechefsdeprojetsBindingSource As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents BT_Ajouter As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Liste_chefs_de_projetsTableAdapter As Formation_ContinueDataSet1TableAdapters.liste_chefs_de_projetsTableAdapter
    Friend WithEvents ListeassistantesBindingSource As BindingSource
    Friend WithEvents Liste_assistantesTableAdapter As Formation_ContinueDataSet1TableAdapters.liste_assistantesTableAdapter
    Friend WithEvents CB_Formation As ComboBox
    Friend WithEvents FormationBindingSource As BindingSource
    Friend WithEvents FormationTableAdapter As Formation_ContinueDataSet1TableAdapters.FormationTableAdapter
    Friend WithEvents TB_Session As TextBox
End Class
