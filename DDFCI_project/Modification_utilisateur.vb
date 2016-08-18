Imports System.Data.SqlClient

Public Class Modification_utilisateur
    Private bdd As BD
    Private MonUtilisateur As Utilisateur

    Sub New(base As BD, _user As Utilisateur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
        MonUtilisateur = _user
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub Modification_utilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TB_user.Text = MonUtilisateur.user
        Me.TB_mail.Text = MonUtilisateur.email
        Me.RB_Non.Checked = True
        'Me.TB_Nv_mdp1.Enabled = False
        'Me.TB_Nv_mdp2.Enabled = False
        Me.TB_telephone.Text = MonUtilisateur.telephone
        Me.TB_telecopie.Text = MonUtilisateur.telecopie
    End Sub

    Private Sub RB_Oui_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Oui.CheckedChanged
        Me.TB_Nv_mdp1.Enabled = True
        Me.TB_Nv_mdp2.Enabled = True
    End Sub

    Private Sub RB_Non_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Non.CheckedChanged
        Me.TB_Nv_mdp1.Text = ""
        Me.TB_Nv_mdp2.Text = ""
        Me.TB_Nv_mdp1.Enabled = False
        Me.TB_Nv_mdp2.Enabled = False
    End Sub

    Private Sub BT_Enregistrer_Click(sender As Object, e As EventArgs) Handles BT_Enregistrer.Click
        If TB_user.Text IsNot "" And TB_mail.Text IsNot "" And TB_telephone.Text IsNot "" Then
            If Me.RB_Non.Checked Then 'Si on ne modifie pas le mot de passe
                Enregistrement(False)
            ElseIf Me.TB_Nv_mdp1.Text.Length = Me.TB_Nv_mdp2.Text.Length And Me.TB_Nv_mdp1.Text = Me.TB_Nv_mdp2.Text Then
                If Me.TB_Nv_mdp1.TextLength <= 3 Then
                    MsgBox("Veuillez saisir un mot de passe de plus de 3 caractères")
                Else
                    Enregistrement(True)
                End If
            Else 'Si les 2 mots de passe sont différents
                MsgBox("Veuillez saisir le même mot de passe dans les 2 champs!")
            End If
        End If
    End Sub

    Sub Enregistrement(ByVal MonBool As Boolean)
        Dim Req1 As String = "update Personnel 
            set Login = '" & Me.TB_user.Text & "',Mail = '" & Me.TB_mail.Text & "',
            Telephone = '" & Me.TB_telephone.Text & "',Telecopie = '" & Me.TB_telecopie.Text & "'
            where Login = '" & MonUtilisateur.user & "'"
        Dim Req2 As String = "update Personnel 
            set Login = '" & Me.TB_user.Text & "',Mail = '" & Me.TB_mail.Text & "',Password = '" & Me.TB_Nv_mdp1.Text & "',
            Telephone = '" & Me.TB_telephone.Text & "',Telecopie = '" & Me.TB_telecopie.Text & "'
            where Login = '" & MonUtilisateur.user & "'"

        If MonBool = True Then 'Si le mdp est à modifier
            Dim cmd As New SqlCommand(Req2, bdd.connect)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Vos informations ont bien été modifiées")
                Me.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd.Dispose()
        Else
            Dim cmd As New SqlCommand(Req1, bdd.connect)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Vos informations ont bien été modifiées")
                Me.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd.Dispose()
        End If
    End Sub
End Class