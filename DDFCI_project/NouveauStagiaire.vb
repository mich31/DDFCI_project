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
            'GenereID(TB_Nom.Text, TB_Prenom.Text)
            MsgBox(id)
            'LiaisonIntervention()
            MsgBox(Res - 1 & " Intervenant(e) ajouté(e)")
            'Me.Dispose()
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
End Class