Imports System.Data.SqlClient

Public Class Connexion
    Dim bdd As New BD("Data source=SI-SQLTEST;Initial Catalog=Formation Continue;Integrated Security=True;")

    Private Sub BTN_connecter_Click(sender As Object, e As EventArgs) Handles BTN_connecter.Click
        If bdd.Connect_bd = False Then 'Si l'application n'est pas connectée à la BD
            bdd.connexionBD()
            TB_ecran.Text = bdd.Message
            If bdd.Connect_bd = True Then
                bdd.connexionUser(TXT_Login.Text, TXT_mdp.Text)
                TB_ecran.Text += vbCrLf & bdd.Message
                If bdd.Connect_user = True Then
                    Formation.base = bdd
                    Formation.Show()
                    'Me.Dispose()
                Else
                    TB_ecran.Text = "Mauvais nom d'utilisateur ou mot de passe"
                End If
            Else
                TB_ecran.Text = "Problème de connexion à la base de données" & vbCrLf & bdd.Message
            End If
        Else 'Si elle est connectée
            If bdd.Connect_user = False Then 'Si l'utilisateur n'est pas connecté
                bdd.connexionUser(TXT_Login.Text, TXT_mdp.Text)
                TB_ecran.Text += vbCrLf & bdd.Message
                If bdd.Connect_user = True Then
                    Formation.base = bdd
                    Formation.Show()
                    'Me.Dispose()
                Else
                    TB_ecran.Text = "Mauvais nom d'utilisateur ou mot de passe"
                End If
            End If
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        'bdd.deconnexion()
        Me.Close()
    End Sub

End Class
