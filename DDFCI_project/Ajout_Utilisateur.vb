Imports System.Data.SqlClient

Public Class Ajout_Utilisateur
    Private bdd As BD

    Sub New(base As BD)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
    End Sub

#Region "Boutons"

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Creer_Click(sender As Object, e As EventArgs) Handles BT_Creer.Click
        If TB_user.Text IsNot "" And TB_pwd.Text IsNot "" And CB_fct.SelectedIndex >= 0 Then
            Dim Req As String = "exec AjoutPersonnel @login = '" & TB_user.Text & "'
            ,@pwd = '" & TB_pwd.Text & "',@fonction= '" & CB_fct.SelectedItem.ToString & "'
            ,@mail='" & TB_mail.Text & "'"
            Dim cmd As New SqlCommand(Req, bdd.connect)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Utilisateur/trice ajouté(e)")
                Me.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            cmd.Dispose()
        End If
    End Sub

#End Region

End Class