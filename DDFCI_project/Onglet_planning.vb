Imports System.Data.SqlClient
'Imports Calendar

Public Class Onglet_planning
    Private MonDataSet As New DataSet
    Private bdd As BD
    'Private RDVs As New List(Of Appointment)

    Sub New(ByRef base As BD, ByVal SF As SessionFormation)
        bdd = base
        Genere_DT_Seance(SF)
    End Sub

    Sub Genere_DT_Seance(ByRef SF As SessionFormation)
        Dim Req As String = "select*from liste_seances where NomF = '" & SF.NomFormation & "' and AnneeSession = '" & SF.Session & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_seances")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#Region "Propriétés"

    Property Seances As DataTable
        Get
            Return MonDataSet.Tables("liste_seances")
        End Get
        Set(value As DataTable)

        End Set
    End Property

#End Region

End Class
