Imports System.Data.SqlClient

Public Class BD
    Public connect As SqlConnection
    Private msg As String
    Private bool_bd As Boolean 'Teste la connexion entre l'application et la BDD
    Private bool_user As Boolean 'Teste la connexion de l'utilisateur

    Sub New(ByVal str As String)
        connect = New SqlConnection(str)
        bool_bd = False
        bool_user = False
    End Sub

    ''' <summary>
    ''' Etablie la connexion à la base de données
    ''' </summary>
    Sub connexionBD()
        Try
            connect.Open()
            msg = New String("Connexion réussie!")
            bool_bd = True
        Catch ex As Exception
            msg = New String(ex.Message)
            bool_bd = False
        End Try
    End Sub

    ''' <summary>
    ''' Vérifie que l'utilisateur courant fait bien parti du personnel ayant les droits d'accès
    ''' </summary>
    ''' <param name="login">Nom d'utilisateur</param>
    ''' <param name="mdp">Mot de passe</param>
    Sub connexionUser(ByVal login As String, ByVal mdp As String)
        Dim Requete As String = "select*from Personnel where Login='" & login & "' and Password='" & mdp & "'"
        Dim cmd As New SqlCommand(Requete, connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                msg = "Bienvenue " & MonReader("Login").ToString
                bool_user = True
            Else
                msg = "Erreur de connexion!!!"
                bool_user = False
            End If
            cmd.Dispose()
            MonReader.Close()
        Catch ex As Exception
            msg = ex.Message
            bool_user = False
        End Try
    End Sub

    ''' <summary>
    ''' Déconnexion à la base de données
    ''' </summary>
    Sub deconnexion()
        connect.Close()
        bool_bd = False
        bool_user = False
        msg = New String("Déconnexion!")
    End Sub

#Region "Propriétés"

    Public Property Message As String
        Set(value As String)

        End Set
        Get
            Return msg
        End Get
    End Property

    ''' <summary>
    ''' Renvoie vrai si la connexion entre l'application et la base de données est établie, faux sinon.
    ''' </summary>
    ''' <returns></returns>
    Public Property Connect_bd As Boolean
        Set(value As Boolean)
            bool_bd = value
        End Set
        Get
            Return bool_bd
        End Get
    End Property

    ''' <summary>
    ''' Renvoie vrai si l'utilisateur est connecté, faux sinon
    ''' </summary>
    ''' <returns></returns>
    Public Property Connect_user As Boolean
        Set(value As Boolean)
            bool_user = value
        End Set
        Get
            Return bool_user
        End Get
    End Property

#End Region
End Class
