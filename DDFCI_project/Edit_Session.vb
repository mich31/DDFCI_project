﻿Imports System.Data.SqlClient

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
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.liste_sessions'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_sessionsTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_sessions)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Formation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.FormationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Formation)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_assistantes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_assistantesTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_assistantes)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_chefs_de_projets'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_chefs_de_projetsTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_chefs_de_projets)
        'Remplir_DG()
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
        Me.TB_Session.Text = DG.Rows(index).Cells("AnneeSession").Value
        Me.DTP_Debut.Value = DG.Rows(index).Cells("DateDebut").Value
        Me.DTP_Fin.Value = DG.Rows(index).Cells("DateFin").Value

        Remplir_champ_CP(Me.CB_Formation.Text, Me.TB_Session.Text)
        Remplir_champ_AF(Me.CB_Formation.Text, Me.TB_Session.Text)
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
            values ('" & idF & "','" & Me.TB_Session.Text & "','" & Me.DTP_Debut.Value & "','" & Me.DTP_Fin.Value & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim res As Integer

        Try
            'Ajout d'une nouvelle session de formation
            res = cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Liaison de la nouvelle session avec un chef de projet et une assistante
            Dim idS As String = GenereID_Session(idF)
            Liaison_Session_Personnel(idS)

            MsgBox(res & " session ajoutée")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Me.Liste_sessionsTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_sessions)
    End Sub

    Sub Liaison_Session_Personnel(ByVal idS As String)
        Dim req1 As String = "insert into travailleSurFormation values ('" & Me.CB_CP.Text & "','" & idS & "')"
        Dim req2 As String = "insert into travailleSurFormation values ('" & Me.CB_AF.Text & "','" & idS & "')"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim cmd2 As New SqlCommand(req2, bdd.connect)
        Dim res1 As String = "0"
        Dim res2 As String = "0"

        Try
            res1 = cmd1.ExecuteNonQuery()
            cmd1.Dispose()
            'MsgBox(res1 & " Chef de projet")
            res2 = cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            'MsgBox(res2 & " Assistante ")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Function GenereID_Session(ByVal ID_Formation As String) As String
        Dim req As String = "select*from SessionFormation where idFormation='" & ID_Formation & "' 
            and AnneeSession='" & Me.TB_Session.Text & "' and DateDebut='" & Me.DTP_Debut.Value & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As String = "0"

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                res = MonReader("idSessionFormation").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()

        Return res
    End Function

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

    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        supprime_session()
        Me.Liste_sessionsTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_sessions)
    End Sub

    Private Sub supprime_session()
        Dim idSession As String = Me.DG_Liste_Sessions.CurrentRow.Cells(2).Value
        Dim req As String = "delete from SessionFormation where idSessionFormation = '" & idSession & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer

        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Session supprimée!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

End Class