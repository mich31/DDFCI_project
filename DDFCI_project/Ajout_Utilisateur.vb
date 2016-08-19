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
            Dim MaReq As String = "select*from Personnel where Login='" & TB_user.Text & "'"
            Dim MaCmd As New SqlCommand(MaReq, bdd.connect)

            Try
                Dim MonReader As SqlDataReader = MaCmd.ExecuteReader()
                If MonReader.Read() Then
                    MsgBox("Un utilisateur à ce nom existe déjà!")
                    MaCmd.Dispose()
                    MonReader.Close()
                Else
                    MaCmd.Dispose()
                    MonReader.Close()
                    AjouterUtilisateur()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    'Fonction d'ajout d'un nouvel utilisateur
    Sub AjouterUtilisateur()
        Dim Req As String = "exec AjoutPersonnel @login = '" & TB_user.Text & "'
            ,@pwd = '" & TB_pwd.Text & "',@fonction= '" & CB_fct.SelectedItem.ToString & "'
            ,@mail='" & TB_mail.Text & "',@telephone= '" & TB_Telephone.Text & "',@telecopie= '" & TB_Telecopie.Text & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Utilisateur/trice ajouté(e)")
            Me.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub



#End Region

End Class