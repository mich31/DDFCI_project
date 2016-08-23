Imports System.Data.SqlClient

Public Class Utilisateur
    Private bdd As BD
    Private MonDataSet As New DataSet

    Private login As String
    Private mdp As String
    Private fct As String
    Private mail As String
    Private tel As String
    Private telecop As String

    Sub New(ByVal _login As String, ByVal _mdp As String, ByVal _fct As String, ByVal _mail As String, ByVal _telephone As String, ByVal _telecopie As String, ByRef base As BD)
        login = _login
        mdp = _mdp
        fct = _fct
        mail = _mail
        tel = _telephone
        telecop = _telecopie

        bdd = base

        GenereSessions()
    End Sub

    Sub GenereSessions()
        Dim Req As String = "select F.NomF,S.AnneeSession,S.DateDebut,S.DateFin
            from SessionFormation S,Formation F
            where S.idSessionFormation in (select idSessionFormation from travaille_sur_formation where Login='" & login & "')
            and S.idFormation = F.idFormation"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_sessions")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()

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

    Property telephone As String
        Set(value As String)
            tel = value
        End Set
        Get
            Return tel
        End Get
    End Property

    Property telecopie As String
        Set(value As String)
            telecop = value
        End Set
        Get
            Return telecop
        End Get
    End Property

    Property sessions As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_sessions")
        End Get
    End Property

#End Region
End Class
