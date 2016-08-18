Imports System.Data.SqlClient

Public Class Vacation
    Private bdd As BD


    Sub New(ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base

    End Sub

    Private Sub Vacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Req As String = "select*from Vacation"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "fiche_perso_stagiaire")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub
End Class