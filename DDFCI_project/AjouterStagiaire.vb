Public Class AjouterStagiaire

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click

        Dim S As New Stagiaire(Me.CB_civ.Text, Me.TB_Nom.Text, Me.TB_NomJF.Text,
                               Me.TB_Prenom.Text, Me.TB_Nationalite.Text, Me.TB_Adresse.Text,
                               Me.TB_CP.Text, Me.TB_Ville.Text, Me.TB_Pays.Text,
                               Me.TB_NumTel.Text, Me.TB_Mail.Text)
        Formation.Ajout_Stagiaire(S)
        Me.Dispose()
    End Sub
End Class