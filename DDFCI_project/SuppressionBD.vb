Imports System.Data.SqlClient

Public Class SuppressionBD

    Private bdd As BD

    Sub New(ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_rechercher_Click(sender As Object, e As EventArgs) Handles BT_rechercher.Click
        If Me.TB_Nom_R IsNot "" Then
            Me.PersonneTableAdapter.GetPersonne(Me.Formation_ContinueDataSet1.Personne, "%" + Me.TB_Nom_R.Text + "%", "%" + Me.TB_Prenom_R.Text + "%")
        End If
    End Sub

    Private Sub SuppressionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonneTableAdapter.Fill(Me.Formation_ContinueDataSet1.Personne)

    End Sub

    Private Sub BT_Suppr_Click(sender As Object, e As EventArgs) Handles BT_Suppr.Click
        Dim Nom As String = Me.DG_Liste_personne.SelectedRows.Item(0).Cells(2).Value.ToString
        Dim Prenom As String = Me.DG_Liste_personne.SelectedRows.Item(0).Cells(4).Value.ToString
        Me.BindingNavigatorDeleteItem.PerformClick()
        Me.PersonneTableAdapter.Delete(Nom, Prenom)
    End Sub

End Class