Imports System.Data.SqlClient

Public Class NouveauStagiaire
    Private bdd As BD
    Private id As Integer
    Private idSession As String

    Sub New(ByRef base As BD, ByVal idS As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
        idSession = idS
    End Sub

    Sub Ajoute_stagiaire()
        Dim Req As String = "exec InscriptionStagiaire @Civ = '" & Me.CB_civ.Text & "',@Nom = '" & Me.TB_Nom.Text & "',
        @NomJeuneFille = '',@Prenom='" & Me.TB_Prenom.Text & "',@Nationalite = '" & Me.TB_Nationalite.Text & "',
        @Adresse = '',@CP = '',@Ville = '',@Pays = '',@NumTel = '" & Me.TB_Tel.Text & "',
        @Mail = '" & Me.TB_Mail.Text & "',@IDSessionF = '" & idSession & "',@Attentes = '',@Avis = ''"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim Res As Integer = 0

        Try
            Res = cmd.ExecuteNonQuery()
            cmd.Dispose()
            GenereID(TB_Nom.Text, TB_Prenom.Text)
            MsgBox(Res - 1 & " stagiaire ajouté(e)")
            Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'cmd.Dispose()
    End Sub

    Sub GenereID(ByVal Nom As String, ByVal Prenom As String)
        Dim Req As String = "select*from profils_stagiaires where NomP='" & Nom & "' and PrenomP='" & Prenom & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader
            If MonReader.Read() Then
                id = MonReader("idPersonne").ToString
            End If
            MonReader.Close()
            cmd.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        Ajoute_stagiaire()
    End Sub

    Private Sub BT_rechercher_Click(sender As Object, e As EventArgs) Handles BT_rechercher.Click
        If Me.TB_Nom_R IsNot "" Then
            Me.PersonneTableAdapter.GetPersonne(Me.Formation_ContinueDataSet1.Personne, "%" + Me.TB_Nom_R.Text + "%", "%" + Me.TB_Prenom_R.Text + "%")
        End If
    End Sub

    Private Sub NouveauStagiaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonneTableAdapter.Fill(Me.Formation_ContinueDataSet1.Personne)

    End Sub

    Private Sub BT_R_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_R_Ajouter.Click
        Dim id As String = Me.DG_Liste_personne.CurrentRow.Cells(0).Value
        Dim MonBool As Boolean
        MonBool = Recherche_Stagiaire_BD(id)

        If MonBool = False Then
            CreerStagiaire(id)

        End If
        LiaisonStagiaireSession(id)
        MsgBox("1 intervenant(e) ajouté(e)!")
    End Sub

    Private Function Recherche_Stagiaire_BD(ByVal id As String)
        Dim req1 As String = "select*from Stagiaire where idStagiaire='" & id & "'"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim MonBool As Boolean = False

        Try
            Dim MonReader As SqlDataReader = cmd1.ExecuteReader()
            If MonReader.Read() Then
                MonBool = True
            End If
            MonReader.Close()
            cmd1.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Recherche " & ex.Message)
        End Try
        Return MonBool
    End Function

    Private Sub CreerStagiaire(ByVal id As String)
        Dim req1 As String = "insert into Stagiaire(idStagiaire) 
        values ('" & id & "')"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd1.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Creation stagiaire " & ex.Message)
        End Try
        cmd1.Dispose()
    End Sub

    Private Sub LiaisonStagiaireSession(ByVal id As String)
        Dim req1 As String = "insert into inscription values ('" & id & "','" & idSession & "','','',0,'Non payé')"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd1.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("LiaisonStagiaireSession" & ex.Message)
        End Try
        cmd1.Dispose()

    End Sub
End Class