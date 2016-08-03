Public Class Utilisateur
    Private login As String
    Private mdp As String
    Private fct As String
    Private mail As String

    Sub New(ByVal _login As String, ByVal _mdp As String, ByVal _fct As String, ByVal _mail As String)
        login = _login
        mdp = _mdp
        fct = _fct
        mail = _mail
    End Sub

#Region "Propriétés"

    Property user As String
        Set(value As String)

        End Set
        Get
            Return login
        End Get
    End Property

    Property pwd As String
        Set(value As String)
            mdp = value
        End Set
        Get
            Return mdp
        End Get
    End Property

    Property fonction As String
        Set(value As String)
            fct = value
        End Set
        Get
            Return fct
        End Get
    End Property

    Property email As String
        Set(value As String)
            mail = value
        End Set
        Get
            Return mail
        End Get
    End Property

#End Region
End Class
