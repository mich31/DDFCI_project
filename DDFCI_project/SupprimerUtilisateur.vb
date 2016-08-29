Imports System.Data.SqlClient

Public Class SupprimerUtilisateur
    Private bdd As BD

    Sub New(ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
    End Sub

    Private Sub SupprimerUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Personnel'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonnelTableAdapter.Fill(Me.Formation_ContinueDataSet1.Personnel)

    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        Dim req As String = "delete from Personnel where Login = '" & Me.DG_Liste_utilisateurs.CurrentRow.Cells(0).Value & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer = 0

        Try
            res = cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Utilisateur supprimé!")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub BT_Actualiser_Click(sender As Object, e As EventArgs) Handles BT_Actualiser.Click
        Me.PersonnelTableAdapter.Fill(Me.Formation_ContinueDataSet1.Personnel)
    End Sub
End Class