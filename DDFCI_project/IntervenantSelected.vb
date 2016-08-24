Imports System.Data.SqlClient

Public Class IntervenantSelected
    Private bdd As BD
    Private MonDataSet As New DataSet
    Private index As Integer
    Private Nom As String
    Private Prenom As String


    Property interventions As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_interventions_intervenant")
        End Get
    End Property

    Sub New(ByRef DT As DataTable, ByVal i As Integer, ByRef base As BD)
        Dim Ligne As DataRow

        index = i
        bdd = base

        Ligne = DT.Rows().Item(i)
        Nom = Ligne("NomP").ToString
        Prenom = Ligne("PrenomP").ToString
        GenereMonDataTable()
    End Sub

    Sub GenereMonDataTable()
        Dim Req As String = "select*from liste_interventions where NomP='" & Nom & "' and PrenomP='" & Prenom & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)
        Dim res As New DataTable
        Try
            MonAdaptateur.Fill(MonDataSet, "liste_interventions_intervenant")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

End Class
