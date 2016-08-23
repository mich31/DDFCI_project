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


End Class