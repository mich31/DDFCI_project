Imports System.Data.SqlClient

Public Class PageConnexion

    Dim bdd As New BD("Data source=SI-SQLTEST;Initial Catalog=Formation Continue;Integrated Security=True;")

    ' TODO: insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Connexion()
        'My.User.CurrentPrincipal = Formation
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Sub Connexion()
        If bdd.Connect_bd = False Then 'Si l'application n'est pas connectée à la BD
            bdd.connexionBD()
            'TB_ecran.Text = bdd.Message
            If bdd.Connect_bd = True Then
                bdd.connexionUser(UsernameTextBox.Text, PasswordTextBox.Text)
                'TB_ecran.Text += vbCrLf & bdd.Message
                If bdd.Connect_user = True Then
                    Formation.base = bdd
                    Formation.Show()
                    Me.Hide()
                    'Me.Dispose()
                Else
                    'TB_ecran.Text = "Mauvais nom d'utilisateur ou mot de passe"
                    MsgBox("Mauvais nom d'utilisateur ou mot de passe")
                End If
            Else
                MsgBox("Problème de connexion à la base de données" & vbCrLf & bdd.Message)
            End If
        Else 'Si elle est connectée
            If bdd.Connect_user = False Then 'Si l'utilisateur n'est pas connecté
                bdd.connexionUser(UsernameTextBox.Text, PasswordTextBox.Text)
                'TB_ecran.Text += vbCrLf & bdd.Message
                If bdd.Connect_user = True Then
                    Formation.base = bdd
                    Formation.Show()
                    Me.Hide()
                    'Me.Dispose()
                Else
                    MsgBox("Mauvais nom d'utilisateur ou mot de passe")
                End If
            End If
        End If
    End Sub

    Private Sub PageConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
