Public Class FichePersoIntervenant
    Private bdd As BD
    Private ligne As DataRow

    Sub New(ByRef base As BD, ByRef _ligne As DataRow)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
        ligne = _ligne
    End Sub

    Private Sub FichePersoIntervenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableIntervenant As DataTable = Formation.TableIntervenant
        CB_civilite.Text = ligne("CiviliteP").ToString
        TB_Nom.Text = ligne("NomP").ToString
        TB_NomJF.Text = ligne("NomJeuneFille").ToString
        TB_Prenom.Text = ligne("PrenomP").ToString
        TB_DateNaissance.Text = ligne("DateNaissanceI").ToString
        TB_LieuNaissance.Text = ligne("LieuNaissanceI").ToString

        TB_Telephone.Text = ligne("NumTelP").ToString
        RTB_Adresse.Text = ligne("AdresseP").ToString
        'TB_Pays.Text = ligne("Pays").ToString
        TB_NumSS.Text = ligne("NumSSI").ToString
        Me.LinkLabelMail.Text = ligne("MailP").ToString
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Dispose()
    End Sub

End Class