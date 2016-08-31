Imports System.Data.SqlClient

Public Class NouvelIntervenant
    Private bdd As BD
    Private idP As Integer
    Private idS As String

    Sub New(ByRef base As BD, ByVal idSession As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
        idS = idSession
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        If TB_Nom.TextLength >= 2 And TB_Nationalite.TextLength >= 2 And TB_Tel.TextLength >= 4 And TB_Mail.Text.Contains("@") And TB_Mail.TextLength >= 3 Then
            MsgBox("Ajout en cours")
            Ajoute_Intervenant()
            MsgBox("Fin de l'ajout")
        End If
    End Sub

    Sub Ajoute_Intervenant()
        Dim Req As String = "exec AjoutIntervenant @_Civ = '" & Me.CB_civ.Text & "',@_Nom = '" & Me.TB_Nom.Text & "',@_NomJeuneFille = '',
            @_Prenom='" & Me.TB_Prenom.Text & "',@_Nationalite = '" & Me.TB_Nationalite.Text & "',@_Adresse = '',
            @_CP = '',@_Ville = '',@_Pays = '',@_NumTel = '" & Me.TB_Tel.Text & "',@_Mail = '" & Me.TB_Mail.Text & "',
            @_Datenaissance = '1900-01-01',@_LieuNaissance = '',@_PaysNaissance = '',@_NumSS = '',
            @_TypeIntervenant = '" & Me.CB_Type.Text & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim Res As Integer = 0
        Try
            Res = cmd.ExecuteNonQuery()
            cmd.Dispose()
            GenereID_Personne(TB_Nom.Text, TB_Prenom.Text)
            LiaisonIntervention()
            MsgBox(Res - 1 & " Intervenant(e) ajouté(e)")
            'Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Ajoute " & ex.Message)
        End Try
    End Sub


    Sub LiaisonIntervention()
        'Dim Req As String = "exec Intervenant_intervient_Seance @_idIntervenant = " & idP & ", @_idSeance = 1"
        Dim Req As String = "insert into intervientSurSession values ('" & idP & "','" & idS & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim Res As Integer
        Try
            Res = cmd.ExecuteNonQuery()
            'MsgBox(Res & "interventions")
            cmd.Dispose()
            Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Liaison" & ex.Message)
        End Try
    End Sub


    Sub GenereID_Personne(ByVal Nom As String, ByVal Prenom As String)
        Dim Req As String = "select*from profils_intervenant where NomP='" & Nom & "' and PrenomP='" & Prenom & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader
            If MonReader.Read() Then
                idP = MonReader("idPersonne").ToString
            End If
            MonReader.Close()
            cmd.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("GenereID " & ex.Message)
        End Try
    End Sub

    Private Sub NouvelIntervenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Personne'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PersonneTableAdapter.Fill(Me.Formation_ContinueDataSet1.Personne)

    End Sub

    Private Sub BT_rechercher_Click(sender As Object, e As EventArgs) Handles BT_rechercher.Click
        If Me.TB_Nom_R IsNot "" Then
            Me.PersonneTableAdapter.GetPersonne(Me.Formation_ContinueDataSet1.Personne, Me.TB_Nom_R.Text, Me.TB_Prenom_R.Text)
        End If
    End Sub

    Private Sub BT_Ajouter_R_Click(sender As Object, e As EventArgs) Handles BT_Ajouter_R.Click
        Dim id As String = Me.DG_Liste_personne.CurrentRow.Cells(0).Value
        Dim MonBool As Boolean
        MonBool = Recherche_Intervenant_BD(id)

        If MonBool = False Then
            CreerIntervenant(id)

        End If
        LiaisonIntervenantSession(id)
        MsgBox("1 intervenant(e) ajouté(e)!")
    End Sub

    Private Sub CreerIntervenant(ByVal id As String)
        Dim req1 As String = "insert into Intervenant(idIntervenant,DateNaissanceI,LieuNaissanceI,PaysNaissanceI,NumSSI,TypeIntervenant) 
        values ('" & id & "','1900-01-01','','','','Externe')"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd1.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("CreerIntervenant " & ex.Message)
        End Try
        cmd1.Dispose()
    End Sub

    Private Sub LiaisonIntervenantSession(ByVal id As String)
        Dim req1 As String = "insert into intervientSurSession values ('" & id & "','" & idS & "')"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd1.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("LiaisonIntervenantSession" & ex.Message)
        End Try
        cmd1.Dispose()

    End Sub

    Private Function Recherche_Intervenant_BD(ByVal id As String)
        Dim req1 As String = "select*from Intervenant where idIntervenant='" & id & "'"
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
End Class