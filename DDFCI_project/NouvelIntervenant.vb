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
            Ajoute_Intervenant()
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
            MsgBox(idP)
            LiaisonIntervention()
            MsgBox(Res - 1 & " Intervenant(e) ajouté(e)")
            'Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


    Sub LiaisonIntervention()
        'Dim Req As String = "exec Intervenant_intervient_Seance @_idIntervenant = " & idP & ", @_idSeance = 1"
        Dim Req As String = "insert into intervientSurSession values ('" & idP & "','" & idS & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim Res As Integer
        Try
            Res = cmd.ExecuteNonQuery()
            MsgBox(Res & "interventions")
            Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
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
        End Try
    End Sub
End Class