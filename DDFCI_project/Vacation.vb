Imports System.Data.SqlClient

Public Class Vacation
    Private bdd As BD
    Private MonDataSet As New DataSet


    Sub New(ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
    End Sub

    Private Sub Vacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet.Vacation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.VacationTableAdapter.Fill(Me.Formation_ContinueDataSet.Vacation)
        Me.BindingNavigator1.Hide()
        'Me.DG_Vacations.DataSource = MonDataSet.Tables("table_vacation")
    End Sub

    Private Sub GenereTableVacation()
        Dim Req As String = "select*from Vacation"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "table_vacation")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Enregistrer_Click(sender As Object, e As EventArgs) Handles BT_Enregistrer.Click
        EnregistrerToolStripButton.PerformClick()
        'Me.Formation_ContinueDataSet.Vacation.GetChanges()
        'Me.Formation_ContinueDataSet.Vacation.DataSet.AcceptChanges()
        Me.VacationTableAdapter.Update(Me.Formation_ContinueDataSet.Vacation.DataSet)

        MsgBox("Enregistré!")
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        Me.BindingNavigatorDeleteItem.PerformClick()
    End Sub
End Class