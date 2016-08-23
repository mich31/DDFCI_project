Imports System.Data.SqlClient

Public Class Onglet_intervenant
    Private MonDataSet As New DataSet
    Private bdd As BD
    Private MonAdaptateur As SqlDataAdapter

    Sub New(ByRef base As BD, ByVal SF As SessionFormation)
        bdd = base
        GenereListeInterventions(SF)
        GenereListeIntervenants(SF)
        GenereDonneesEntreprise(SF)
    End Sub

    Sub GenereListeIntervenants(ByRef SF As SessionFormation)
        Dim Req As String = "select*from profils_intervenant 
        where idPersonne in 
        (select idIntervenant from liste_interventions where NomF = '" & SF.NomFormation & "' 
        and AnneeSession = '" & SF.Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        MonAdaptateur = New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_intervenants")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub MAJ_Interventions(ByRef SF As SessionFormation, ByRef Ligne As DataGridViewRow, ByVal Statut As String)
        Dim Req As String = "update liste_interventions set StatutPaiement = '" & Ligne.Cells.Item(14).Value & "' 
        where idIntervenant = " & Ligne.Cells.Item(3).Value & " and idSeance = " & Ligne.Cells.Item(5).Value
        Dim cmd As New SqlCommand(Req, bdd.connect)

        MonAdaptateur.UpdateCommand = New SqlCommand(Req, bdd.connect)
        MonAdaptateur.Update(MonDataSet.Tables("liste_interventions"))
        cmd.Dispose()

    End Sub

    Sub GenereListeInterventions(ByRef SF As SessionFormation)
        Dim Req As String = "select*from liste_interventions where NomF = '" & SF.NomFormation & "' 
        and AnneeSession = '" & SF.Session & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_interventions")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereDonneesEntreprise(ByRef SF As SessionFormation)
        Dim Req As String = "select*from emplois 
        where idPersonne in 
        (select idPersonne from liste_interventions where NomF = '" & SF.NomFormation & "' 
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

    Property Intervenants As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_intervenants")
        End Get
    End Property

    Property Interventions As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_interventions")
        End Get
    End Property

    Property DonneesEntreprises As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("donnees_entreprise")
        End Get
    End Property

#End Region

End Class
