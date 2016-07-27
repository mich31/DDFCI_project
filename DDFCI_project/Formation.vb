Imports System.Data.SqlClient

Public Class Formation
    Private bdd As BD
    Private MonDataSet As New DataSet

    ''' <summary>
    ''' contient les informations de connexion à la base de données
    ''' </summary>
    ''' <returns></returns>
    Property base As BD
        Set(value As BD)
            bdd = value
        End Set
        Get
            Return bdd
        End Get
    End Property

    Private Sub Formation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username)
        CreerArborescence()
        GenereListeIntervenant()
    End Sub

    Sub GenereListeIntervenant()
        Dim Req As String = "select * from profils_intervenant"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "profils_intervenant")
            'Analyse du dataset
            For Each Ligne As DataRow In MonDataSet.Tables("profils_intervenant").Rows()
                ListeIntervenants.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub RemplirFichePersonelleIntervenant()
        Try
            'Dim MonView As New DataView(MonDataSet.Tables("profils_intervenant"))
            'MonView.Sort = "where NomP = '"
            Dim index As Integer
            Dim Ligne As DataRow
            index = ListeIntervenants.SelectedIndex
            Ligne = MonDataSet.Tables("profils_intervenant").Rows().Item(index)
            Me.TB_Nom.Text = Ligne("NomP").ToString
            Me.TB_Prenom.Text = Ligne("PrenomP").ToString
            Me.TB_DateNaissance.Text = Ligne("DateNaissanceI").ToString
            Me.TB_Telephone.Text = Ligne("NumTelP").ToString
            Me.LinkEmailIntervenant.Text = Ligne("MailP").ToString
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub RemplirDataGrid()
        Dim index As Integer
        index = ListeIntervenants.SelectedIndex
        Dim Req As String = ""
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)
        Dim Nom, Prenom As String
        Dim Ligne As DataRow
        Ligne = MonDataSet.Tables("profils_intervenant").Rows().Item(index)
        Nom = Ligne("NomP").ToString
        Prenom = Ligne("PrenomP").ToString

        Me.DataGridView1.DataSource = MonDataSet.Tables("profils_intervenant")
    End Sub

#Region "Arborescence Formations"

    Sub CreerArborescence()
        Dim Req As String = "select distinct NomF from travaille_sur_formation where Login='" & bdd.username & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "travaille_sur_formation")
            'Analyse du dataset
            For Each Ligne As DataRow In MonDataSet.Tables("travaille_sur_formation").Rows()
                Me.TV_Menu.TopNode.Nodes.Add(Ligne("NomF").ToString, Ligne("NomF").ToString)
                CreerArborescenceFormation(Ligne("NomF").ToString, Me.TV_Menu.TopNode)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub CreerArborescenceFormation(ByVal NomFormation As String, ByVal NodeActuel As TreeNode)
        Dim Node As TreeNode = NodeActuel.Nodes(NomFormation)
        Dim Req As String = "select * from travaille_sur_formation where Login='" & bdd.username & "' and NomF='" & NomFormation & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "session_par_formation")
            For Each Ligne As DataRow In MonDataSet.Tables("session_par_formation").Rows()
                Node.Nodes.Add(Ligne("AnneeSession").ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#End Region

    ''' <summary>
    ''' Effectue la déconnexion à la base de données et ferme le programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        bdd.deconnexion()
        Connexion.Show()
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Ouvre le service de messagerie pour l'envoi d'un mail
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEmailIntervenant.LinkClicked
        System.Diagnostics.Process.Start("mailto:" & Me.LinkEmailIntervenant.Text)
    End Sub

    Private Sub ListeIntervenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeIntervenants.SelectedIndexChanged
        RemplirFichePersonelleIntervenant()
        Dim Intervenant As New IntervenantSelected(MonDataSet.Tables("profils_intervenant"), Me.ListeIntervenants.SelectedIndex, bdd)
        Me.DataGridView1.DataSource = Intervenant.data_table
        'RemplirDataGrid()
    End Sub


    ''' <summary>
    ''' Lorsqu'on double clique sur une céllule
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub
End Class