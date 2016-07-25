<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.TXT_Login = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_mdp = New System.Windows.Forms.MaskedTextBox()
        Me.LBL_Login = New System.Windows.Forms.Label()
        Me.LBL_mdp = New System.Windows.Forms.Label()
        Me.BTN_connecter = New System.Windows.Forms.Button()
        Me.TB_ecran = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Fichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_Login
        '
        Me.TXT_Login.Location = New System.Drawing.Point(105, 132)
        Me.TXT_Login.Name = "TXT_Login"
        Me.TXT_Login.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Login.TabIndex = 0
        '
        'TXT_mdp
        '
        Me.TXT_mdp.Location = New System.Drawing.Point(105, 173)
        Me.TXT_mdp.Name = "TXT_mdp"
        Me.TXT_mdp.Size = New System.Drawing.Size(100, 20)
        Me.TXT_mdp.TabIndex = 1
        Me.TXT_mdp.UseSystemPasswordChar = True
        '
        'LBL_Login
        '
        Me.LBL_Login.AutoSize = True
        Me.LBL_Login.Location = New System.Drawing.Point(12, 132)
        Me.LBL_Login.Name = "LBL_Login"
        Me.LBL_Login.Size = New System.Drawing.Size(87, 13)
        Me.LBL_Login.TabIndex = 2
        Me.LBL_Login.Text = "Nom d'utilisateur:"
        '
        'LBL_mdp
        '
        Me.LBL_mdp.AutoSize = True
        Me.LBL_mdp.Location = New System.Drawing.Point(25, 173)
        Me.LBL_mdp.Name = "LBL_mdp"
        Me.LBL_mdp.Size = New System.Drawing.Size(74, 13)
        Me.LBL_mdp.TabIndex = 3
        Me.LBL_mdp.Text = "Mot de passe:"
        '
        'BTN_connecter
        '
        Me.BTN_connecter.Location = New System.Drawing.Point(105, 213)
        Me.BTN_connecter.Name = "BTN_connecter"
        Me.BTN_connecter.Size = New System.Drawing.Size(87, 23)
        Me.BTN_connecter.TabIndex = 4
        Me.BTN_connecter.Text = "Se connecter"
        Me.BTN_connecter.UseVisualStyleBackColor = True
        '
        'TB_ecran
        '
        Me.TB_ecran.BackColor = System.Drawing.SystemColors.InfoText
        Me.TB_ecran.ForeColor = System.Drawing.SystemColors.Info
        Me.TB_ecran.Location = New System.Drawing.Point(28, 30)
        Me.TB_ecran.Name = "TB_ecran"
        Me.TB_ecran.Size = New System.Drawing.Size(220, 96)
        Me.TB_ecran.TabIndex = 5
        Me.TB_ecran.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fichier})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(273, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Fichier
        '
        Me.Fichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.Fichier.Name = "Fichier"
        Me.Fichier.Size = New System.Drawing.Size(54, 20)
        Me.Fichier.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 262)
        Me.Controls.Add(Me.TB_ecran)
        Me.Controls.Add(Me.BTN_connecter)
        Me.Controls.Add(Me.LBL_mdp)
        Me.Controls.Add(Me.LBL_Login)
        Me.Controls.Add(Me.TXT_mdp)
        Me.Controls.Add(Me.TXT_Login)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Connexion"
        Me.Text = "DDFCI Project"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Login As MaskedTextBox
    Friend WithEvents TXT_mdp As MaskedTextBox
    Friend WithEvents LBL_Login As Label
    Friend WithEvents LBL_mdp As Label
    Friend WithEvents BTN_connecter As Button
    Friend WithEvents TB_ecran As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Fichier As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
End Class
