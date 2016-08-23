Imports System.Data.SqlClient

Public Class Edit_Session
    Private bdd As BD
    Private MonUtilisateur As Utilisateur

    Sub New(ByRef user As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        MonUtilisateur = user
    End Sub

    Private Sub Edit_Session_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_DG()
    End Sub

    Private Sub Remplir_DG()
        Me.DG_Liste_Sessions.DataSource = MonUtilisateur.sessions

        Me.DG_Liste_Sessions.Columns("NomF").HeaderText = "Nom de la formation"
        Me.DG_Liste_Sessions.Columns("AnneeSession").HeaderText = "Session"
        Me.DG_Liste_Sessions.Columns("DateDebut").HeaderText = "Début"
        Me.DG_Liste_Sessions.Columns("DateFin").HeaderText = "Fin"
    End Sub

    Private Sub DG_Liste_Sessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Liste_Sessions.CellContentClick
        Remplir_champs(Me.DG_Liste_Sessions, Me.DG_Liste_Sessions.CurrentRow.Index)
    End Sub

    Sub Remplir_champs(ByRef DG As DataGridView, ByVal index As Integer)
        Me.TB_NomFormation.Text = DG.Rows(index).Cells("NomF").Value
        Me.DTP_Session.Value = DG.Rows(index).Cells("AnneeSession").Value
        Me.DTP_Debut.Value = DG.Rows(index).Cells("DateDebut").Value
        Me.DTP_Fin.Value = DG.Rows(index).Cells("DateFin").Value
    End Sub
End Class