Public Class FichePersoIntervenant

    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub FichePersoIntervenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableIntervenant As DataTable = Formation.TableIntervenant

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Dispose()
    End Sub

End Class