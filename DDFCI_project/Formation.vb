Imports System.Data.SqlClient

Public Class Formation
    Private bdd As BD
    Private MonDataSet As New DataSet
<<<<<<< HEAD
    Private NomFormation As String
    Private SessionFormation As String
    Private TableSF As DataTable

#Region "Propriétés"
=======
>>>>>>> origin/master

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

        RemplirDG_Stagiaire()
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

<<<<<<< HEAD
#End Region

#Region "Onglet Intervenant"

    Sub GenereListeIntervenant(ByRef SF As SessionFormation)
        TableSF = SF.Liste_intervenants
        For Each Ligne As DataRow In SF.Liste_intervenants.Rows()
            ListeIntervenants.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
        Next
    End Sub

=======
>>>>>>> origin/master
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

    Sub RemplirDG_Intervenant()
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

        Me.DG_Intervenant.DataSource = MonDataSet.Tables("profils_intervenant")
    End Sub

    Sub RemplirDG_Stagiaire()
        Dim Req As String = "select * from profils_stagiaires"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "profils_stagiaires")
            Me.DG_Stagiaire.DataSource = MonDataSet.Tables("profils_stagiaires")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub Ajout_Stagiaire(ByRef St As Stagiaire)
        Dim Req As String = "exec AjoutStagiaire @_Civ = '" & St.civ &
            "',@_Nom = '" & St.nom & "',@_NomJeuneFille = '" & St.nomJF & "',@_Prenom='" &
            St.prenom & "',@_Nationalite = '" & St.nationalite & "',@_Adresse = '" &
            St.adresse & "',@_CP = '" & St.cp & "',@_Ville = '" & St.ville & "',@_Pays ='" &
            St.pays & "',@_NumTel = '" & St.telephone & "',@_Mail = '" & St.mail & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#Region "Arborescence Formations"

    ''' <summary>
    ''' Crée l'arborescence des formations et sessions de formations sur lesquelles l'utilisateur travaille
    ''' </summary>
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

    ''' <summary>
    ''' Crée l'arborescence des sessions de formations par utilisateur
    ''' </summary>
    ''' <param name="NomFormation"></param>
    ''' <param name="NodeActuel"></param>
    Sub CreerArborescenceFormation(ByVal NomFormation As String, ByVal NodeActuel As TreeNode)
        Dim Node As TreeNode = NodeActuel.Nodes(NomFormation)
        Dim Req As String = "select * from travaille_sur_formation where Login='" & bdd.username & "' and NomF='" & NomFormation & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

<<<<<<< HEAD
=======
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

<<<<<<< HEAD
#Region "Onglet Documents"

    Sub RemplirControlsDoc(ByRef SF As SessionFormation)
        RemplirCB_Intervenants(SF)
    End Sub

    Sub RemplirCB_Intervenants(ByRef SF As SessionFormation)
        CB_DSE.Items.Clear()
        For Each Ligne As DataRow In SF.Liste_intervenants.Rows()
            CB_DSE.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
        Next
    End Sub

=======
>>>>>>> origin/master
#End Region
>>>>>>> 88fe6d94df20b9089233b97735a172b53d30de67

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

<<<<<<< HEAD
    Private Sub TV_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Menu.AfterSelect
        ListeIntervenants.Items.Clear()
        'Si le noeud sélectionné est une session de formation
        If Me.TV_Menu.SelectedNode.Level = 2 Then
            NomFormation = Me.TV_Menu.SelectedNode.Parent.Text
            SessionFormation = Me.TV_Menu.SelectedNode.Text
            MAJ_infos()
        ElseIf Me.TV_Menu.SelectedNode.Level = 1 Then 'Si le noeud sélectionné est une formation
            NomFormation = Me.TV_Menu.SelectedNode.Text
        End If
    End Sub

    Private Sub MAJ_infos()
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation)
        GenereListeIntervenant(SF)
        RemplirDG_Stagiaire(SF)
<<<<<<< HEAD
=======
        RemplirControlsDoc(SF)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.CB_DSE.SelectedIndex >= 0 Then
            Dim FicheEngagement As New Document(TableSF, Me.CB_DSE.SelectedIndex, bdd)
            FicheEngagement.GenereDossierEngagement()
        End If
=======
    Private Sub ListeIntervenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeIntervenants.SelectedIndexChanged
        RemplirFichePersonelleIntervenant()
        Dim Intervenant As New IntervenantSelected(MonDataSet.Tables("profils_intervenant"), Me.ListeIntervenants.SelectedIndex, bdd)
        Me.DG_Intervenant.DataSource = Intervenant.data_table
        'RemplirDataGrid()
    End Sub


    ''' <summary>
    ''' Lorsqu'on double clique sur une céllule de la grille
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DG_Intervenant_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Intervenant.CellContentDoubleClick

    End Sub

    Private Sub BT_Ajout_Stagiaire_Click(sender As Object, e As EventArgs) Handles BT_Ajout_Stagiaire.Click
        AjouterStagiaire.Show()
>>>>>>> origin/master
>>>>>>> 88fe6d94df20b9089233b97735a172b53d30de67
    End Sub
End Class