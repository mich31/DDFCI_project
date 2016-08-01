Imports System.Data.SqlClient

Public Class SessionFormation
    Private MonDataSet As New DataSet
    Private bdd As BD

    Public NomFormation As String
    Public Session As String


    Property Liste_stagiaires As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_stagiaires")
        End Get
    End Property

    Property Liste_intervenants As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_intervenants")
        End Get
    End Property

    Sub New(ByRef base As BD, _nomF As String, _session As String)
        bdd = base
        NomFormation = _nomF
        Session = _session

        GenereListeStagiaires()
        GenereListeIntervenants()
    End Sub

    Sub GenereListeStagiaires()
        Dim Req As String = "select*from profils_stagiaires 
        where idPersonne in 
        (select idStagiaire from liste_inscriptions where NomF = '" & NomFormation & "' 
        and AnneeSession = '" & Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_stagiaires")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereListeIntervenants()
        Dim Req As String = "select*from profils_intervenant 
        where idPersonne in 
        (select idIntervenant from liste_interventions where NomF = '" & NomFormation & "' 
        and AnneeSession = '" & Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_intervenants")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub
End Class
