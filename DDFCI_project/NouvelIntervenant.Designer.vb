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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Nom = New System.Windows.Forms.TextBox()
        Me.TB_Prenom = New System.Windows.Forms.TextBox()
        Me.TB_Nationalite = New System.Windows.Forms.TextBox()
        Me.TB_Tel = New System.Windows.Forms.TextBox()
        Me.TB_Mail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_civ = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_Type = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
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
        'TB_Nom
        '
        Me.TB_Nom.Location = New System.Drawing.Point(117, 33)
        Me.TB_Nom.Name = "TB_Nom"
        Me.TB_Nom.Size = New System.Drawing.Size(154, 20)
        Me.TB_Nom.TabIndex = 5
        '
        'TB_Prenom
        '
        Me.TB_Prenom.Location = New System.Drawing.Point(117, 66)
        Me.TB_Prenom.Name = "TB_Prenom"
        Me.TB_Prenom.Size = New System.Drawing.Size(154, 20)
        Me.TB_Prenom.TabIndex = 6
        '
        'TB_Nationalite
        '
        Me.TB_Nationalite.Location = New System.Drawing.Point(117, 102)
        Me.TB_Nationalite.Name = "TB_Nationalite"
        Me.TB_Nationalite.Size = New System.Drawing.Size(154, 20)
        Me.TB_Nationalite.TabIndex = 7
        '
        'TB_Tel
        '
        Me.TB_Tel.Location = New System.Drawing.Point(117, 137)
        Me.TB_Tel.Name = "TB_Tel"
        Me.TB_Tel.Size = New System.Drawing.Size(154, 20)
        Me.TB_Tel.TabIndex = 8
        '
        'TB_Mail
        '
        Me.TB_Mail.Location = New System.Drawing.Point(117, 173)
        Me.TB_Mail.Name = "TB_Mail"
        Me.TB_Mail.Size = New System.Drawing.Size(154, 20)
        Me.TB_Mail.TabIndex = 9
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
        'NouvelIntervenant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 338)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Ajouter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NouvelIntervenant"
        Me.Text = "Ajouter un(e) intervenant(e)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
