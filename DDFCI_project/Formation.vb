Imports System.Data.SqlClient

Public Class Formation
    Private bdd As BD
    Private MonDataSet As New DataSet
    Private NomFormation As String
    Private SessionFormation As String
    Private TableSF As DataTable 'Table contenant la liste des intervenants

    Private o_Intervenant As Onglet_intervenant
    Private o_Stagiaire As Onglet_stagiaire


#Region "Propriétés"

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

    ''' <summary>
    ''' Retourne un dataset
    ''' </summary>
    ''' <returns></returns>
    Property dataset As DataSet
        Set(value As DataSet)

        End Set
        Get
            Return MonDataSet
        End Get
    End Property

    ''' <summary>
    ''' Retourne le nom de la formation sélectionné
    ''' </summary>
    ''' <returns></returns>
    Property Formation As String
        Set(value As String)
            NomFormation = value
        End Set
        Get
            Return NomFormation
        End Get
    End Property

    ''' <summary>
    ''' Retourne le nom de la session de formation sélectionné
    ''' </summary>
    ''' <returns></returns>
    Property Session As String
        Set(value As String)

        End Set
        Get
            Return SessionFormation
        End Get
    End Property

    Property TableIntervenant As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return TableSF
        End Get
    End Property
#End Region


    Private Sub Formation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username)
        CreerArborescence()
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

        Try
            MonAdaptateur.Fill(MonDataSet, "session_par_formation")
            For Each Ligne As DataRow In MonDataSet.Tables("session_par_formation").Rows()
                Node.Nodes.Add(Ligne("AnneeSession").ToString)
            Next
            MonDataSet.Tables("session_par_formation").Clear()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#End Region

#Region "Onglet Intervenant"


    'Sub RemplirFichePersonelleIntervenant()
    '    Try
    '        'Dim MonView As New DataView(MonDataSet.Tables("profils_intervenant"))
    '        'MonView.Sort = "where NomP = '"
    '        Dim index As Integer
    '        Dim Ligne As DataRow
    '        index = ListeIntervenants.SelectedIndex
    '        Ligne = TableSF.Rows().Item(index)
    '        Me.TB_Nom.Text = Ligne("NomP").ToString
    '        Me.TB_Prenom.Text = Ligne("PrenomP").ToString
    '        Me.TB_DateNaissance.Text = Ligne("DateNaissanceI").ToString
    '        Me.TB_Telephone.Text = Ligne("NumTelP").ToString
    '        Me.LinkEmailIntervenant.Text = Ligne("MailP").ToString
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '    End Try
    'End Sub

    Sub Remplir_DG_Liste_Intervenants()
        Me.DG_Liste_Intervenants.DataSource = o_Intervenant.Intervenants
        Dim nb As Integer = Me.DG_Liste_Intervenants.RowCount

        Me.DG_Liste_Intervenants.Columns("NomP").HeaderText = "Nom"
        Me.DG_Liste_Intervenants.Columns("PrenomP").HeaderText = "Prénom"
        Me.DG_Liste_Intervenants.Columns("CiviliteP").HeaderText = "Civ"

        For Each col As DataGridViewColumn In Me.DG_Liste_Intervenants.Columns
            If col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" And col.HeaderText IsNot "Civ." Then
                col.Visible = False
            End If
        Next

        Me.LBL_Intervenant_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Sub Remplir_DG_Liste_Interventions()
        Me.DG_Liste_Interventions.DataSource = o_Intervenant.Interventions
        Me.DG_Liste_Interventions.Columns("NomF").HeaderText = "Formation"
        Me.DG_Liste_Interventions.Columns("TypeIntervention").HeaderText = "Type d'intervention"
        'Date
        Me.DG_Liste_Interventions.Columns("NbHeure").HeaderText = "Nb d'heures"
        'Salle
        Me.DG_Liste_Interventions.Columns("HeureDebut").HeaderText = "Début"
        Me.DG_Liste_Interventions.Columns("HeureFin").HeaderText = "Fin"

        For Each col As DataGridViewColumn In Me.DG_Liste_Interventions.Columns
            If col.HeaderText IsNot "Formation" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Salle" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
                col.Visible = False
            End If
        Next

    End Sub

    Sub Init_champs_Information()
        Me.CB_I_Civilite.Text = ""
    End Sub

    Sub Remplir_Onglet_Information(ByVal DG As DataGridView, ByVal index As Integer)
        Me.CB_I_Civilite.Text = DG.Rows(index).Cells("CiviliteP").Value
        Me.TB_I_Nom.Text = DG.Rows(index).Cells("NomP").Value
        Me.TB_I_Prenom.Text = DG.Rows(index).Cells("PrenomP").Value
        Me.RTB_I_Adresse.Text = DG.Rows(index).Cells("AdresseP").Value & ", " & DG.Rows(index).Cells("CP").Value & " " & DG.Rows(index).Cells("VilleP").Value
        Me.TB_I_Pays.Text = DG.Rows(index).Cells("PaysP").Value
        Me.TB_I_Telephone.Text = DG.Rows(index).Cells("NumTelP").Value

        Me.DTP_I_DateN.Value = DG.Rows(index).Cells("DateNaissanceI").Value
        Me.TB_I_LieuN.Text = DG.Rows(index).Cells("LieuNaissanceI").Value
        Me.TB_I_PaysN.Text = DG.Rows(index).Cells("PaysNaissanceI").Value
        Me.TB_I_NumSS.Text = DG.Rows(index).Cells("NumSSI").Value

        Me.CB_I_TypeIntervenant.Text = DG.Rows(index).Cells("TypeIntervenant").Value



        Me.RTB_I_Fonction.Text = DG.Rows(index).Cells("NumTelP").Value
    End Sub

    ''' <summary>
    ''' Ouvre le service de messagerie pour l'envoi d'un mail
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LinkLabel_Mail_Intervenant_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Mail_Intervenant.LinkClicked
        System.Diagnostics.Process.Start("mailto: " & Me.LinkLabel_Mail_Intervenant.Text)
    End Sub

    Private Sub DG_Liste_Intervenants_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Liste_Intervenants.CellContentClick
        Init_champs_Information()
        Remplir_Onglet_Information(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Intervenants_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Intervenants.RowHeaderMouseClick
        Init_champs_Information()
        Remplir_Onglet_Information(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

#End Region

#Region "Onglet Stagiaire"

    Sub Remplir_DG_Liste_Stagiaires()
        Me.DG_Liste_Stagiaires.DataSource = o_Stagiaire.Stagiaires
        Dim nb As Integer = Me.DG_Liste_Stagiaires.RowCount

        Me.DG_Liste_Stagiaires.Columns("NomP").HeaderText = "Nom"
        Me.DG_Liste_Stagiaires.Columns("PrenomP").HeaderText = "Prénom"

        For Each col As DataGridViewColumn In Me.DG_Liste_Stagiaires.Columns
            If col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" Then
                col.Visible = False
            End If
        Next

        Me.LBL_Stagiaire_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
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


#End Region

#Region "Documents"

    Sub RemplirControlsDoc(ByRef SF As SessionFormation)
        RemplirCB_Intervenants(SF)
    End Sub

    Sub RemplirCB_Intervenants(ByRef SF As SessionFormation)
        'CB_I_DSE.Items.Clear()
        'For Each Ligne As DataRow In SF.Liste_intervenants.Rows()
        '    CB_I_DSE.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
        '    CB_FSF.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
        '    CB_convoc.Items.Add(Ligne("NomP").ToString & " " & Ligne("PrenomP").ToString)
        'Next
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


    Private Sub TV_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Menu.AfterSelect
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

        Dim Inter = New Onglet_intervenant(bdd, SF)
        Dim Stagiaire = New Onglet_stagiaire(bdd, SF)
        o_Intervenant = Inter
        o_Stagiaire = Stagiaire

        Me.RTB_I_Formation.Text = NomFormation
        Me.RTB_S_Formation.Text = NomFormation
        Me.TB_I_Session.Text = SessionFormation
        Me.TB_S_Session.Text = SessionFormation
        Me.TB_I_NB_Intervenants.Text = o_Intervenant.Intervenants.Rows.Count
        Me.TB_S_NB_Intervenants.Text = o_Intervenant.Intervenants.Rows.Count
        Me.TB_I_NB_Stagiaires.Text = o_Stagiaire.Stagiaires.Rows.Count
        Me.TB_S_NB_Stagiaires.Text = o_Stagiaire.Stagiaires.Rows.Count

        Remplir_DG_Liste_Intervenants()
        Remplir_DG_Liste_Interventions()
        Remplir_DG_Liste_Stagiaires()
        'RemplirControlsDoc(SF)
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim index As Integer = Me.CB_DSE.SelectedIndex
    '    If index >= 0 Then
    '        Dim FicheEngagement As New Document(TableSF, index, bdd)
    '        FicheEngagement.GenereDossierEngagement()
    '    End If
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim index As Integer = Me.CB_FSF.SelectedIndex
    '    If index >= 0 Then
    '        Dim FSF As New Document(TableSF, index, bdd)
    '        FSF.GenereFicheServicefait()
    '    End If
    'End Sub

    Private Sub BT_FichePerso_Click(sender As Object, e As EventArgs)
        FichePersoIntervenant.Show()
    End Sub

    Private Sub CréerUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnUtilisateurToolStripMenuItem.Click
        Dim aj As New Ajout_Utilisateur(bdd)
        aj.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
    End Sub

End Class