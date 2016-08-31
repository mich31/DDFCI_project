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
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.TypeFormation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.TypeFormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.TypeFormation)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Formation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Formation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
        Me.BindingNavigator1.Hide()

    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click

        If TB_Nom.TextLength > 2 Then
            Dim Req As String = "Insert into Formation (NomF,Projet,Type) values ('" & Me.TB_Nom.Text & "','" & Me.CB_projet.Text & "','" & Me.CB_Type.Text & "')"
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
        Me.FormationTableAdapter.Update(Me.Formation_ContinueDataSet1.Formation.DataSet)
        Me.DG_ListeFormations.ReadOnly = True
        MsgBox("Enregistré!")
    End Sub

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        Me.BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub BT_Modifier_Click(sender As Object, e As EventArgs) Handles BT_Modifier.Click
        Me.DG_ListeFormations.ReadOnly = False
    End Sub

    Private Sub BT_Actualiser_Click(sender As Object, e As EventArgs) Handles BT_Actualiser.Click
        Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
    End Sub

    'Private Sub FillBy_type_projetToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.TypeFormationTableAdapter.FillBy_type_projet(Me.Formation_ContinueDataSet1.TypeFormation)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub CB_projet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_projet.SelectedIndexChanged
        Select Case Me.CB_projet.Text
            Case "Mastère spécialisé"
                Me.CB_Type.Items.Clear()
                Me.CB_Type.Items.Add("Mastère spécialisé")

            Case "Offres internationales"
                Me.CB_Type.Enabled = True
                Me.CB_Type.Items.Clear()
                Me.CB_Type.Items.Add("Séminaires")
                Me.CB_Type.Items.Add("CES")
                Me.CB_Type.Items.Add("Offres AO")
            Case "Offres institutionnelles"
                Me.CB_Type.Enabled = True
                Me.CB_Type.Items.Clear()
                Me.CB_Type.Items.Add("Offres Avec Marchés")
                Me.CB_Type.Items.Add("Offres Sans Marchés")
            Case "Offres payantes"
                Me.CB_Type.Enabled = True
                Me.CB_Type.Items.Clear()
                Me.CB_Type.Items.Add("Offres Payantes Intra(Sollicitation)")
                Me.CB_Type.Items.Add("Offres Payantes Extra")
                Me.CB_Type.Items.Add("Offres AO")
        End Select

    End Sub
End Class