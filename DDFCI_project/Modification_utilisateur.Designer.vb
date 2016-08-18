<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification_utilisateur
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
        Me.TB_telecopie = New System.Windows.Forms.TextBox()
        Me.TB_telephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_mail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Nv_mdp2 = New System.Windows.Forms.TextBox()
        Me.TB_Nv_mdp1 = New System.Windows.Forms.TextBox()
        Me.TB_user = New System.Windows.Forms.TextBox()
        Me.RB_Non = New System.Windows.Forms.RadioButton()
        Me.RB_Oui = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Enregistrer = New System.Windows.Forms.Button()
        Me.BT_Annuler = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TB_telecopie)
        Me.Panel1.Controls.Add(Me.TB_telephone)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TB_mail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TB_Nv_mdp2)
        Me.Panel1.Controls.Add(Me.TB_Nv_mdp1)
        Me.Panel1.Controls.Add(Me.TB_user)
        Me.Panel1.Controls.Add(Me.RB_Non)
        Me.Panel1.Controls.Add(Me.RB_Oui)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 250)
        Me.Panel1.TabIndex = 0
        '
        'TB_telecopie
        '
        Me.TB_telecopie.Location = New System.Drawing.Point(125, 215)
        Me.TB_telecopie.Name = "TB_telecopie"
        Me.TB_telecopie.Size = New System.Drawing.Size(129, 20)
        Me.TB_telecopie.TabIndex = 12
        '
        'TB_telephone
        '
        Me.TB_telephone.Location = New System.Drawing.Point(125, 185)
        Me.TB_telephone.Name = "TB_telephone"
        Me.TB_telephone.Size = New System.Drawing.Size(129, 20)
        Me.TB_telephone.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Télécopie:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Téléphone:"
        '
        'TB_mail
        '
        Me.TB_mail.Location = New System.Drawing.Point(125, 153)
        Me.TB_mail.Name = "TB_mail"
        Me.TB_mail.Size = New System.Drawing.Size(129, 20)
        Me.TB_mail.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "E-mail:"
        '
        'TB_Nv_mdp2
        '
        Me.TB_Nv_mdp2.Location = New System.Drawing.Point(44, 119)
        Me.TB_Nv_mdp2.Name = "TB_Nv_mdp2"
        Me.TB_Nv_mdp2.Size = New System.Drawing.Size(159, 20)
        Me.TB_Nv_mdp2.TabIndex = 6
        Me.TB_Nv_mdp2.UseSystemPasswordChar = True
        '
        'TB_Nv_mdp1
        '
        Me.TB_Nv_mdp1.Location = New System.Drawing.Point(44, 84)
        Me.TB_Nv_mdp1.Name = "TB_Nv_mdp1"
        Me.TB_Nv_mdp1.Size = New System.Drawing.Size(159, 20)
        Me.TB_Nv_mdp1.TabIndex = 5
        Me.TB_Nv_mdp1.UseSystemPasswordChar = True
        '
        'TB_user
        '
        Me.TB_user.Location = New System.Drawing.Point(125, 21)
        Me.TB_user.Name = "TB_user"
        Me.TB_user.Size = New System.Drawing.Size(129, 20)
        Me.TB_user.TabIndex = 4
        '
        'RB_Non
        '
        Me.RB_Non.AutoSize = True
        Me.RB_Non.Location = New System.Drawing.Point(209, 54)
        Me.RB_Non.Name = "RB_Non"
        Me.RB_Non.Size = New System.Drawing.Size(45, 17)
        Me.RB_Non.TabIndex = 3
        Me.RB_Non.TabStop = True
        Me.RB_Non.Text = "Non"
        Me.RB_Non.UseVisualStyleBackColor = True
        '
        'RB_Oui
        '
        Me.RB_Oui.AutoSize = True
        Me.RB_Oui.Location = New System.Drawing.Point(162, 54)
        Me.RB_Oui.Name = "RB_Oui"
        Me.RB_Oui.Size = New System.Drawing.Size(41, 17)
        Me.RB_Oui.TabIndex = 2
        Me.RB_Oui.TabStop = True
        Me.RB_Oui.Text = "Oui"
        Me.RB_Oui.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Changer le mot de passe?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom d'utilisateur:"
        '
        'BT_Enregistrer
        '
        Me.BT_Enregistrer.Location = New System.Drawing.Point(59, 309)
        Me.BT_Enregistrer.Name = "BT_Enregistrer"
        Me.BT_Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.BT_Enregistrer.TabIndex = 1
        Me.BT_Enregistrer.Text = "Enregistrer"
        Me.BT_Enregistrer.UseVisualStyleBackColor = True
        '
        'BT_Annuler
        '
        Me.BT_Annuler.Location = New System.Drawing.Point(161, 309)
        Me.BT_Annuler.Name = "BT_Annuler"
        Me.BT_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.BT_Annuler.TabIndex = 2
        Me.BT_Annuler.Text = "Annuler"
        Me.BT_Annuler.UseVisualStyleBackColor = True
        '
        'Modification_utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 354)
        Me.Controls.Add(Me.BT_Annuler)
        Me.Controls.Add(Me.BT_Enregistrer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Modification_utilisateur"
        Me.Text = "Modifier mes informations"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RB_Non As RadioButton
    Friend WithEvents RB_Oui As RadioButton
    Friend WithEvents TB_user As TextBox
    Friend WithEvents TB_Nv_mdp2 As TextBox
    Friend WithEvents TB_Nv_mdp1 As TextBox
    Friend WithEvents TB_mail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_telecopie As TextBox
    Friend WithEvents TB_telephone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BT_Enregistrer As Button
    Friend WithEvents BT_Annuler As Button
End Class
