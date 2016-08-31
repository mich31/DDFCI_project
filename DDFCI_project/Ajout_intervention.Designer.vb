<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_intervention
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_NB_Heures = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTP_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Type = New System.Windows.Forms.ComboBox()
        Me.VacationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.VacationTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.VacationTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VacationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TB_NB_Heures)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DTP_Date)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CB_Type)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TB_Prenom)
        Me.Panel1.Controls.Add(Me.TB_Nom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(29, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 282)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP_Debut)
        Me.GroupBox1.Controls.Add(Me.DTP_Fin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 43)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Heure d'intervention"
        '
        'DTP_Debut
        '
        Me.DTP_Debut.CustomFormat = "HH:mm"
        Me.DTP_Debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Debut.Location = New System.Drawing.Point(44, 17)
        Me.DTP_Debut.Name = "DTP_Debut"
        Me.DTP_Debut.Size = New System.Drawing.Size(64, 20)
        Me.DTP_Debut.TabIndex = 3
        '
        'DTP_Fin
        '
        Me.DTP_Fin.CustomFormat = "HH:mm"
        Me.DTP_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Fin.Location = New System.Drawing.Point(155, 16)
        Me.DTP_Fin.Name = "DTP_Fin"
        Me.DTP_Fin.Size = New System.Drawing.Size(65, 20)
        Me.DTP_Fin.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Début:"
        '
        'TB_NB_Heures
        '
        Me.TB_NB_Heures.Enabled = False
        Me.TB_NB_Heures.Location = New System.Drawing.Point(109, 248)
        Me.TB_NB_Heures.Name = "TB_NB_Heures"
        Me.TB_NB_Heures.Size = New System.Drawing.Size(48, 20)
        Me.TB_NB_Heures.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nombre d'heures:"
        '
        'DTP_Date
        '
        Me.DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Date.Location = New System.Drawing.Point(73, 151)
        Me.DTP_Date.Name = "DTP_Date"
        Me.DTP_Date.Size = New System.Drawing.Size(100, 20)
        Me.DTP_Date.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fin:"
        '
        'CB_Type
        '
        Me.CB_Type.DataSource = Me.VacationBindingSource
        Me.CB_Type.DisplayMember = "Libelle"
        Me.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.Location = New System.Drawing.Point(57, 100)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(136, 21)
        Me.CB_Type.TabIndex = 2
        '
        'VacationBindingSource
        '
        Me.VacationBindingSource.DataMember = "Vacation"
        Me.VacationBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Type d'intervention:"
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Enabled = False
        Me.TB_Prenom.Location = New System.Drawing.Point(57, 42)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(100, 20)
        Me.TB_Prenom.TabIndex = 1
        '
        'TB_Nom
        '
        Me.TB_Nom.Enabled = False
        Me.TB_Nom.Location = New System.Drawing.Point(57, 13)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom:"
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Location = New System.Drawing.Point(66, 315)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter.TabIndex = 1
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(165, 315)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 2
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'VacationTableAdapter
        '
        Me.VacationTableAdapter.ClearBeforeFill = True
        '
        'Ajout_intervention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 350)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Ajouter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ajout_intervention"
        Me.Text = "Ajouter une intervention"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VacationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Prenom As TextBox
    Friend WithEvents TB_Nom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Type As ComboBox
    Friend WithEvents BT_Ajouter As Button
    Friend WithEvents BT_Annuler As Button
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents VacationBindingSource As BindingSource
    Friend WithEvents VacationTableAdapter As Formation_ContinueDataSet1TableAdapters.VacationTableAdapter
    Friend WithEvents DTP_Date As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_NB_Heures As TextBox
    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents DTP_Fin As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
End Class
