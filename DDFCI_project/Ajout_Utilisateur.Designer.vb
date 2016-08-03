<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Utilisateur
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
        Me.CB_fct = New System.Windows.Forms.ComboBox()
        Me.TB_mail = New System.Windows.Forms.TextBox()
        Me.TB_pwd = New System.Windows.Forms.TextBox()
        Me.TB_user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Creer = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CB_fct)
        Me.Panel1.Controls.Add(Me.TB_mail)
        Me.Panel1.Controls.Add(Me.TB_pwd)
        Me.Panel1.Controls.Add(Me.TB_user)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 173)
        Me.Panel1.TabIndex = 0
        '
        'CB_fct
        '
        Me.CB_fct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_fct.FormattingEnabled = True
        Me.CB_fct.Items.AddRange(New Object() {"Assistant(e) de formation", "Chef(fe) de projet", "Direction", "Autres"})
        Me.CB_fct.Location = New System.Drawing.Point(114, 89)
        Me.CB_fct.Name = "CB_fct"
        Me.CB_fct.Size = New System.Drawing.Size(129, 21)
        Me.CB_fct.TabIndex = 7
        '
        'TB_mail
        '
        Me.TB_mail.Location = New System.Drawing.Point(114, 125)
        Me.TB_mail.Name = "TB_mail"
        Me.TB_mail.Size = New System.Drawing.Size(129, 20)
        Me.TB_mail.TabIndex = 6
        '
        'TB_pwd
        '
        Me.TB_pwd.Location = New System.Drawing.Point(114, 53)
        Me.TB_pwd.Name = "TB_pwd"
        Me.TB_pwd.Size = New System.Drawing.Size(129, 20)
        Me.TB_pwd.TabIndex = 5
        '
        'TB_user
        '
        Me.TB_user.Location = New System.Drawing.Point(114, 18)
        Me.TB_user.Name = "TB_user"
        Me.TB_user.Size = New System.Drawing.Size(129, 20)
        Me.TB_user.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail:*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fonction:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mot de passe:*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom d'utilisateur:*"
        '
        'BT_Creer
        '
        Me.BT_Creer.Location = New System.Drawing.Point(57, 271)
        Me.BT_Creer.Name = "BT_Creer"
        Me.BT_Creer.Size = New System.Drawing.Size(75, 23)
        Me.BT_Creer.TabIndex = 1
        Me.BT_Creer.Text = "Créer"
        Me.BT_Creer.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(165, 271)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 2
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'Ajout_Utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 324)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Creer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ajout_Utilisateur"
        Me.Text = "Ajouter un utilisateur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_fct As ComboBox
    Friend WithEvents TB_mail As TextBox
    Friend WithEvents TB_pwd As TextBox
    Friend WithEvents BT_Creer As Button
    Friend WithEvents BT_Annuler As Button
End Class
