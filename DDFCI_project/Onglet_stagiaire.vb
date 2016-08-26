Imports System.Data.SqlClient

Public Class Onglet_stagiaire
    Private MonDataSet As New DataSet
    Private bdd As BD

    Sub New(ByRef base As BD, ByVal SF As SessionFormation)
        bdd = base
        GenereListeStagiaires(SF)
        GenereDonneesEntreprise(SF)
    End Sub


    Sub GenereListeStagiaires(ByRef SF As SessionFormation)
        'Dim Req As String = "select*from profils_stagiaires where idPersonne in
        '(select idStagiaire from liste_inscriptions where AnneeSession = '" & SF.Session & "');"
        Dim Req As String = "select*from profils_stagiaires P join liste_inscriptions L on L.idStagiaire = P.idPersonne 
            and AnneeSession ='" & SF.Session & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_stagiaires")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereDonneesEntreprise(ByRef SF As SessionFormation)
        Dim Req As String = "select*from emplois 
        where idPersonne in 
        (select idStagiaire from liste_inscriptions where NomF = '" & SF.NomFormation & "' 
        and AnneeSession = '" & SF.Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "donnees_entreprise")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#Region "Propriétés"

    Property Stagiaires As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_stagiaires")
        End Get
    End Property

    Property Donnees_entreprises As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("donnees_entreprise")
        End Get
    End Property

#End Region

End Class
