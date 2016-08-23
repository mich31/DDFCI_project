Imports System.Data.SqlClient

Public Class Edit_Formation
    Private bdd As BD

    Sub New(ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
    End Sub

    Private Sub Edit_Formation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Formation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
        Me.BindingNavigator1.Hide()

    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        If TB_Nom.TextLength > 2 Then
            Dim Req As String = "Insert into Formation (NomF,Type) values ('" & Me.TB_Nom.Text & "','" & Me.CB_Type.Text & "')"
            Dim cmd As New SqlCommand(Req, bdd.connect)
            Dim res As Integer = 0

            Try
                res = cmd.ExecuteNonQuery()
                MsgBox(res & " formation ajoutée!")
            Catch ex As Exception
                MsgBox(ex.Message)
                Console.WriteLine(ex.Message)
            End Try
            cmd.Dispose()
        Else
            MsgBox("Veuillez saisir un nom de plus de 2 caractères")
        End If
    End Sub



    Private Sub BT_Enregistrer_Click(sender As Object, e As EventArgs) Handles BT_Enregistrer.Click
        Me.EnregistrerToolStripButton.PerformClick()
        MsgBox("Enregistré!")
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        Me.BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub BT_Modifier_Click(sender As Object, e As EventArgs) Handles BT_Modifier.Click
        Me.DG_ListeFormations.ReadOnly = False
    End Sub
End Class