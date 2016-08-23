Imports System.Data.SqlClient

Public Class Edit_Session
    Private bdd As BD
    Private MonUtilisateur As Utilisateur

    Sub New(ByRef user As Utilisateur, ByRef base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        MonUtilisateur = user
        bdd = base
    End Sub

    Private Sub Edit_Session_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Formation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_assistantes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_assistantesTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_assistantes)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_chefs_de_projets'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_chefs_de_projetsTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_chefs_de_projets)
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
        Me.CB_Formation.Text = DG.Rows(index).Cells("NomF").Value
        Me.DTP_Session.Value = DG.Rows(index).Cells("AnneeSession").Value
        Me.DTP_Debut.Value = DG.Rows(index).Cells("DateDebut").Value
        Me.DTP_Fin.Value = DG.Rows(index).Cells("DateFin").Value

        Remplir_champ_CP(Me.CB_Formation.Text, Me.DTP_Session.Value)
        Remplir_champ_AF(Me.CB_Formation.Text, Me.DTP_Session.Value)
    End Sub

    Sub Remplir_champ_CP(ByVal NomFormation As String, ByVal Session As String)
        Dim req As String = "select*from travaille_sur_formation where NomF = '" & NomFormation & "' 
            and AnneeSession = '" & Session & "' and Fonction = 'Chef(fe) de projet'"
        Dim cmd As New SqlCommand(req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Me.CB_CP.Text = MonReader("Fonction").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub Remplir_champ_AF(ByVal NomFormation As String, ByVal Session As String)
        Dim req As String = "select*from travaille_sur_formation where NomF = '" & NomFormation & "' 
            and AnneeSession = '" & Session & "' and Fonction = 'Assistant(e) de formation'"
        Dim cmd As New SqlCommand(req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Me.CB_AF.Text = MonReader("Fonction").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        Dim idF As String = GenereID_Formation(Me.CB_Formation.Text)
        Dim Req As String = "insert into SessionFormation (idFormation,AnneeSession,DateDebut,DateFin) 
            values ('" & idF & "','" & Me.DTP_Session.Value & "','" & Me.DTP_Debut.Value & "','" & Me.DTP_Fin.Value & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim res As Integer

        Try
            res = cmd.ExecuteNonQuery()
            MsgBox(res & " session ajoutée")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Function GenereID_Formation(ByVal NomFormation As String) As String
        Dim req As String = "select*from Formation where NomF='" & NomFormation & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As String = "0"

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                res = MonReader("idFormation").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()

        Return res
    End Function
End Class