Imports System.Data.SqlClient
Imports WindowsFormsCalendar
Imports Excel = Microsoft.Office.Interop.Excel
Imports Word = Microsoft.Office.Interop.Word


Public Class Formation
    Private bdd As BD
    Private MonDataSet As New DataSet
    Private NomFormation As String
    Private SessionFormation As String
    Private idSession As String
    Private idFormation As String
    Private TableSF As DataTable 'Table contenant la liste des intervenants
    Dim SF As SessionFormation

    Private utilisateur As Utilisateur
    Private o_Intervenant As Onglet_intervenant
    Private o_Stagiaire As Onglet_stagiaire
    Private o_Planning As Onglet_planning
    Private intervenant_select As Intervenant



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
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.temps_agent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Temps_agentTableAdapter.Fill(Me.Formation_ContinueDataSet1.temps_agent)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.inscription_stagiaires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Inscription_stagiairesTableAdapter.Fill(Me.Formation_ContinueDataSet2.inscription_stagiaires)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_interventionsTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_interventions)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.profils_intervenant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Profils_intervenantTableAdapter.Fill(Me.Formation_ContinueDataSet1.profils_intervenant)

        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username)
        CreerArborescence()
        CreerUtilisateur()
        'Creation_DG()
        GestionDesDroits()
        OrdonneOnglets()
        'MAJ_planning()
    End Sub

    Sub OrdonneOnglets()
        Dim Temp As TabPage
        Temp = Me.TabPage7
        Me.TabControl2.TabPages.Item(1) = Me.TabPage8
        Me.TabControl2.TabPages.Item(2) = Me.TabPage9

        Me.TabControl2.TabPages.Item(3) = Temp

    End Sub

    Sub GestionDesDroits()
        If utilisateur.fonction = "Admin" Then
            Me.CréerUnUtilisateurToolStripMenuItem.Enabled = True
            Me.SupprimerUtilisateurToolStripMenu.Enabled = True
        Else
            Me.CréerUnUtilisateurToolStripMenuItem.Enabled = False
            Me.SupprimerUtilisateurToolStripMenu.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Créé une instance Utilisateur
    ''' </summary>
    Sub CreerUtilisateur()
        Dim Requete As String = "select*from Personnel where Login='" & bdd.username & "'"
        Dim cmd As New SqlCommand(Requete, bdd.connect)

        Dim Login, Pwd, Fct, Mail, Telephone, Telecopie As String

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Login = MonReader("Login").ToString
                Pwd = MonReader("Password").ToString
                Fct = MonReader("Fonction").ToString
                Mail = MonReader("Mail").ToString
                Telephone = MonReader("Telephone").ToString
                Telecopie = MonReader("Telecopie").ToString

                MonReader.Close()

                utilisateur = New Utilisateur(Login, Pwd, Fct, Mail, Telephone, Telecopie, bdd)
            End If
            cmd.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute des cases à cocher sur tous les datagridview 
    ''' </summary>
    Sub Creation_DG()

        ' Ajout et redimensionnement des cases à cocher
        Dim Chk1, Chk2, Chk3, Chk4 As New DataGridViewCheckBoxColumn
        Me.DG_Liste_Intervenants.Columns.Add(Chk1)
        Me.DG_Liste_Interventions.Columns.Add(Chk2)
        Me.DG_Liste_Interventions_nonpayees.Columns.Add(Chk3)
        Me.DG_Liste_Interventions_payees.Columns.Add(Chk4)
        Chk1.DisplayIndex = 0
        Chk2.DisplayIndex = 0
        Chk3.DisplayIndex = 0
        Chk4.DisplayIndex = 0

        'Chk3.Width = 21

        Chk1.Name = "_"
        Chk2.Name = "_"
        Chk3.Name = "_"
        Chk4.Name = "_"

        Chk1.HeaderText = ""
        Chk2.HeaderText = ""
        Chk3.HeaderText = ""
        Chk4.HeaderText = ""

    End Sub

#Region "Arborescence Formations"

    Private Sub TV_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Menu.AfterSelect
        'Si le noeud sélectionné est une session de formation
        If Me.TV_Menu.SelectedNode.Level = 2 Then
            NomFormation = Me.TV_Menu.SelectedNode.Parent.Text
            SessionFormation = Me.TV_Menu.SelectedNode.Text
            GenereIDs(NomFormation, SessionFormation)
            MAJ_infos()
            Me.DG_Liste_Intervenants.Enabled = True
            Me.DG_Liste_Stagiaires.Enabled = True
            Me.DG_Liste_Interventions.Enabled = True
        ElseIf Me.TV_Menu.SelectedNode.Level = 1 Then 'Si le noeud sélectionné est une formation
            NomFormation = Me.TV_Menu.SelectedNode.Text
        End If
    End Sub

    Private Sub GenereIDs(ByVal NomF As String, ByVal Session As String)
        Dim Req As String = "select*from SessionFormation SF join Formation F on SF.idFormation = F.idFormation 
                        where F.NomF = '" & NomFormation & "' and SF.AnneeSession = '" & SessionFormation & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                idSession = MonReader("idSessionFormation").ToString
                idFormation = MonReader("idFormation").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub MAJ_infos()
        SF = New SessionFormation(bdd, NomFormation, SessionFormation, idSession, idFormation)

        o_Planning = New Onglet_planning(bdd, SF)
        o_Intervenant = New Onglet_intervenant(bdd, SF, idSession)
        o_Stagiaire = New Onglet_stagiaire(bdd, SF)

        Me.RTB_Formation.Text = NomFormation

        Me.TB_Session.Text = SessionFormation

        Me.TB_Debut_Session.Text = SF.Debut
        Me.TB_Fin_Session.Text = SF.Fin
        Me.CB_CP.Text = SF.Chef_de_projet
        Me.CB_AF.Text = SF.Assistante

        Me.TB_I_NB_Intervenants.Text = o_Intervenant.Intervenants.Rows.Count

        Me.TB_I_NB_Stagiaires.Text = o_Stagiaire.Stagiaires.Rows.Count

        'MAJ_planning()
        Remplir_DG_Liste_Intervenants()
        Remplir_DG_Liste_Interventions()
        Remplir_DG_Liste_Stagiaires()

        Remplir_panel()
        Remplir_LB_Taches()
    End Sub


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

    Private Sub FillBy_liste_intervenantsToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_liste_intervenantsToolStripButton.Click
        Try
            Me.Profils_intervenantTableAdapter.FillBy_liste_intervenants(Me.Formation_ContinueDataSet1.profils_intervenant, CType(Param_DG_Intervenants.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy_liste_interventionsToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Liste_interventionsTableAdapter.FillBy_liste_interventions(Me.Formation_ContinueDataSet1.liste_interventions, Param_NomFormation.Text, Param_Session.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy_interventions_NPToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_interventions_NPToolStripButton.Click
        Try
            Me.Liste_interventionsTableAdapter.FillBy_interventions_NP(Me.Formation_ContinueDataSet1.liste_interventions, Param_NomFormation_NP.Text, Param_Session_NP.Text, Param_Nom_NP.Text, Param_Prenom_NP.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy_interventions_PToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillBy_interventions_PToolStripButton1.Click
        Try
            Me.Liste_interventionsTableAdapter.FillBy_interventions_P(Me.Formation_ContinueDataSet1.liste_interventions, Param_NomFormation1_P.Text, Param_Session1_P.Text, Param_Nom1_P.Text, Param_Prenom1_P.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy_interventionsToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_interventionsToolStripButton.Click
        Try
            Me.Liste_interventionsTableAdapter.FillBy_interventions(Me.Formation_ContinueDataSet1.liste_interventions, Param_NomFormation.Text, Param_Session.Text, Param_Nom.Text, Param_Prenom.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Remplir_DG_Liste_Intervenants()
        Me.Param_DG_Intervenants.Text = idSession
        Me.FillBy_liste_intervenantsToolStripButton.PerformClick()
        'Me.DG_Liste_Intervenants.DataSource = o_Intervenant.Intervenants
        Dim nb As Integer = Me.DG_Liste_Intervenants.RowCount

        'Me.DG_Liste_Intervenants.Columns("NomP").HeaderText = "Nom"
        'Me.DG_Liste_Intervenants.Columns("PrenomP").HeaderText = "Prénom"
        'Me.DG_Liste_Intervenants.Columns("CiviliteP").HeaderText = "Civilité"
        'Me.DG_Liste_Intervenants.Columns("TypeIntervenant").HeaderText = "Type intervenant"
        'Me.DG_Liste_Intervenants.Columns("DateNaissanceI").HeaderText = "Date de naissance"

        'For Each col As DataGridViewColumn In Me.DG_Liste_Intervenants.Columns
        '    If col.HeaderText IsNot "" And col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" And col.HeaderText IsNot "Civilité" And col.HeaderText IsNot "Type intervenant" And col.HeaderText IsNot "Date de naissance" Then
        '        col.Visible = False
        '    End If
        '    'col.ReadOnly = True
        '    If col.HeaderText Is "" Then
        '        'col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        '        col.ReadOnly = False
        '    End If
        'Next

        Me.LBL_Intervenant_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Sub Remplir_DG_Liste_Interventions()
        Me.Param_NomFormation.Text = NomFormation
        Me.Param_Session.Text = SessionFormation

        FillBy_interventionsToolStripButton.PerformClick()

        Remplir_DG_Liste_Interventions_payees()
        Remplir_DG_Liste_Interventions_nonpayees()

    End Sub

    Sub Remplir_DG_Liste_Interventions_payees()
        Me.Param_NomFormation1_P.Text = NomFormation
        Me.Param_Session1_P.Text = SessionFormation

        Me.FillBy_interventions_PToolStripButton1.PerformClick()

    End Sub

    Sub Remplir_DG_Liste_Interventions_nonpayees()
        Me.Param_NomFormation_NP.Text = NomFormation
        Me.Param_Session_NP.Text = SessionFormation
        Me.FillBy_interventions_NPToolStripButton.PerformClick()

    End Sub


    Private Sub BT_Actualiser_Intervenants_Click(sender As Object, e As EventArgs) Handles BT_Actualiser_Intervenants.Click
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation, idSession, idFormation)
        o_Intervenant = New Onglet_intervenant(bdd, SF, idSession)
        Remplir_DG_Liste_Intervenants()
    End Sub

    Sub Init_champs_Information()
        Me.CB_I_Civilite.Text = ""
        Me.TB_I_Nom.Text = ""
        Me.TB_I_Prenom.Text = ""
        Me.RTB_I_Adresse.Text = ""
        Me.TB_I_Pays.Text = ""
        Me.TB_I_Telephone.Text = ""
        Me.LinkLabel_Mail_Intervenant.Text = ""
        Me.DTP_I_DateN.Value = System.DateTime.Today
        Me.TB_I_LieuN.Text = ""
        Me.TB_I_PaysN.Text = ""
        Me.TB_I_NumSS.Text = ""
        Me.CB_I_TypeIntervenant.Text = ""
        Me.RTB_I_Fonction.Text = ""
        Me.RTB_I_Entreprise.Text = ""
        Me.DTP_I_Anciennete.Value = System.DateTime.Today
    End Sub

    Sub OuvertureDesChamps()
        Me.CB_I_Civilite.Enabled = True
        Me.TB_I_Nom.Enabled = True
        Me.TB_I_Prenom.Enabled = True
        Me.RTB_I_Adresse.Enabled = True
        Me.TB_I_Pays.Enabled = True
        Me.TB_I_Telephone.Enabled = True
        Me.LinkLabel_Mail_Intervenant.Enabled = True
        Me.DTP_I_DateN.Enabled = True
        Me.TB_I_LieuN.Enabled = True
        Me.TB_I_PaysN.Enabled = True
        Me.TB_I_NumSS.Enabled = True
        Me.CB_I_TypeIntervenant.Enabled = True
        Me.RTB_I_Fonction.Enabled = True
        Me.RTB_I_Entreprise.Enabled = True
        Me.DTP_I_Anciennete.Enabled = True
    End Sub

    Sub FermetureDesChamps()
        Me.CB_I_Civilite.Enabled = False
        Me.TB_I_Nom.Enabled = False
        Me.TB_I_Prenom.Enabled = False
        Me.RTB_I_Adresse.Enabled = False
        Me.TB_I_Pays.Enabled = False
        Me.TB_I_Telephone.Enabled = False
        'Me.LinkLabel_Mail_Intervenant.Enabled = False
        Me.DTP_I_DateN.Enabled = False
        Me.TB_I_LieuN.Enabled = False
        Me.TB_I_PaysN.Enabled = False
        Me.TB_I_NumSS.Enabled = False
        Me.CB_I_TypeIntervenant.Enabled = False
        Me.RTB_I_Fonction.Enabled = False
        Me.RTB_I_Entreprise.Enabled = False
        Me.DTP_I_Anciennete.Enabled = False
    End Sub

    Sub Remplir_Onglet_Information_Intervenant(ByVal DG As DataGridView, ByVal index As Integer)
        Dim id As String = DG.Rows(index).Cells("idPersonne").Value

        Me.CB_I_Civilite.Text = DG.Rows(index).Cells(1).Value
        Me.TB_I_Nom.Text = DG.Rows(index).Cells(2).Value
        Me.TB_I_Prenom.Text = DG.Rows(index).Cells(4).Value
        Me.RTB_I_Adresse.Text = DG.Rows(index).Cells(10).Value & ", " & DG.Rows(index).Cells(11).Value & " " & DG.Rows(index).Cells(12).Value
        Me.TB_I_Pays.Text = DG.Rows(index).Cells(13).Value
        Me.TB_I_Telephone.Text = DG.Rows(index).Cells(14).Value
        Me.LinkLabel_Mail_Intervenant.Text = DG.Rows(index).Cells(15).Value

        Me.DTP_I_DateN.Value = DG.Rows(index).Cells(6).Value
        Me.TB_I_LieuN.Text = DG.Rows(index).Cells(7).Value
        Me.TB_I_PaysN.Text = DG.Rows(index).Cells(8).Value
        Me.TB_I_NumSS.Text = DG.Rows(index).Cells(16).Value

        Me.CB_I_TypeIntervenant.Text = DG.Rows(index).Cells(5).Value

        For Each Ligne As DataRow In o_Intervenant.DonneesEntreprises.Rows()
            If Ligne("idPersonne").ToString = id Then
                Me.RTB_I_Fonction.Text = Ligne("Fonction").ToString
                Me.RTB_I_Entreprise.Text = Ligne("NomE").ToString
                Me.DTP_I_Anciennete.Value = Ligne("Anciennete").ToString
            End If
        Next

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
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur, SF.infos_session)
        'Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Me.Param_Nom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        Me.Param_Nom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        Me.Param_Nom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value

        Me.Param_Prenom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        Me.Param_Prenom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        Me.Param_Prenom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value

        Remplir_DG_Liste_Interventions()
        Remplir_DG_Liste_Interventions_nonpayees()
        Remplir_DG_Liste_Interventions_payees()

        Remplir_Onglet_Information_Intervenant(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Intervenants_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Intervenants.RowHeaderMouseClick
        Init_champs_Information()
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur, SF.infos_session)
        'Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Me.Param_Nom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        Me.Param_Nom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        Me.Param_Nom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value

        Me.Param_Prenom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        Me.Param_Prenom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        Me.Param_Prenom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value

        Remplir_DG_Liste_Interventions()
        Remplir_DG_Liste_Interventions_nonpayees()
        Remplir_DG_Liste_Interventions_payees()

        Remplir_Onglet_Information_Intervenant(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub BT_Supprimer_Intervention_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_Intervention.Click
        Me.BN_Interventions_DeleteItem.PerformClick()
    End Sub

    Private Sub BT_Ajouter_Intervention_Click(sender As Object, e As EventArgs) Handles BT_Ajouter_Intervention.Click
        'Me.BN_Interventions_AddItem.PerformClick()
    End Sub

    Private Sub BT_Nouvel_Intervenant_Click(sender As Object, e As EventArgs) Handles BT_Nouvel_Intervenant.Click
        Dim Nouv As New NouvelIntervenant(bdd, idSession)
        Nouv.Show()
    End Sub

    Private Sub BT_Supprimer_intervenant_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_intervenant.Click
        'Dim id As String
        'For Each Ligne As DataGridViewRow In Me.DG_Liste_Intervenants.Rows
        '    If Ligne.Cells.Item(0).Value = True Then
        '        id = Ligne.Cells.Item(1).Value
        '        SupprimeIntervenant(id)
        '    End If
        'Next
        Suppression_Intervenant_BD(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
        Me.BN_Intervenants_DeleteItem.PerformClick()
    End Sub

    Private Sub BT_Enregistrer_Intervenants_Click(sender As Object, e As EventArgs) Handles BT_Enregistrer_Intervenants.Click
        Me.Enregistrer_Intervenants.PerformClick()
        'Profils_intervenantTableAdapter.Adapter.Update(Me.Formation_ContinueDataSet1.profils_intervenant.DataSet)
    End Sub

    Private Sub Suppression_Intervenant_BD(ByVal DG As DataGridView, ByVal index As Integer)
        Dim idPersonne As String = DG.Rows(index).Cells("idPersonne").Value
        Dim idS As String = idSession
        Dim Req As String = "DELETE FROM intervientSurSession WHERE idIntervenant = '" & idPersonne & "' AND 
        idSessionFormation = '" & idS & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub SupprimeIntervenant(ByVal id As String)
        Dim req As String = "delete from intervient where idIntervenant = '" & id & "' and 
                idSeance in (select idSeance from Seance where idSessionFormation = '" & idSession & "')"
        Dim cmd As New SqlCommand(req, bdd.connect)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BT_Modifier_DG_ListeIntervenants_Click(sender As Object, e As EventArgs) Handles BT_Modifier_DG_ListeIntervenants.Click
        OuvertureDesChamps()
        Me.DG_Liste_Intervenants.ReadOnly = False
    End Sub

    Private Sub BT_I_Enregistrer_Click(sender As Object, e As EventArgs) Handles BT_I_Enregistrer.Click
        FermetureDesChamps()
        Enregistrer_infos_intervenant()
        Me.DG_Liste_Intervenants.ReadOnly = True
    End Sub

    ''' <summary>
    ''' Enregistre les modifications sur les infos de l'intervenant sélectionné
    ''' </summary>
    Sub Enregistrer_infos_intervenant()
        Dim req1 As String = "update profils_intervenant set CiviliteP = '" & Me.CB_I_Civilite.Text & "',NomP='" & Me.TB_I_Nom.Text & "'
            ,PrenomP='" & Me.TB_I_Prenom.Text & "',PaysP='" & Me.TB_I_Pays.Text & "',NumTelP='" & Me.TB_I_Telephone.Text & "'
            ,MailP='" & Me.LinkLabel_Mail_Intervenant.Text & "'
            where idPersonne = '" & Me.DG_Liste_Intervenants.CurrentRow.Cells("idPersonne").Value & "'"
        Dim req2 As String = "update profils_intervenant set DateNaissanceI ='" & Me.DTP_I_DateN.Value.ToShortDateString() & "',LieuNaissanceI='" & Me.TB_I_LieuN.Text & "'
            , PaysNaissanceI ='" & Me.TB_I_PaysN.Text & "',NumSSI='" & Me.TB_I_NumSS.Text & "',TypeIntervenant='" & Me.CB_I_TypeIntervenant.Text & "' 
            where idPersonne = '" & Me.DG_Liste_Intervenants.CurrentRow.Cells("idPersonne").Value & "'"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim cmd2 As New SqlCommand(req2, bdd.connect)
        Dim res1 As Integer = 0
        Dim res2 As Integer = 0

        Try
            res1 = cmd1.ExecuteNonQuery()
            cmd1.Dispose()
            res2 = cmd2.ExecuteNonQuery()
            cmd2.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

#End Region

#Region "Onglet Stagiaire"

    Private Sub FillBy_StagiairesToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_StagiairesToolStripButton.Click
        Try
            Me.Inscription_stagiairesTableAdapter.FillBy_Stagiaires(Me.Formation_ContinueDataSet2.inscription_stagiaires, Param_Session_Stagiaires.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Remplir_DG_Liste_Stagiaires()
        Me.Param_Session_Stagiaires.Text = SessionFormation
        Me.FillBy_StagiairesToolStripButton.PerformClick()
        'Me.DG_Liste_Stagiaires.DataSource = o_Stagiaire.Stagiaires
        Dim nb As Integer = Me.DG_Liste_Stagiaires.RowCount

        'Me.DG_Liste_Stagiaires.Columns("NomP").HeaderText = "Nom"
        'Me.DG_Liste_Stagiaires.Columns("PrenomP").HeaderText = "Prénom"
        'Me.DG_Liste_Stagiaires.Columns("Prix").HeaderText = "Frais d'inscription"
        'Me.DG_Liste_Stagiaires.Columns("Paiement").HeaderText = "Paiement"

        'For Each col As DataGridViewColumn In Me.DG_Liste_Stagiaires.Columns
        '    If col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" And col.HeaderText IsNot "Frais d'inscription" And col.HeaderText IsNot "Paiement" Then
        '        col.Visible = False
        '    End If
        'Next

        '' Ajout et redimensionnement des cases à cocher
        'Dim TB As New DataGridViewCheckBoxColumn
        'Me.DG_Liste_Stagiaires.Columns.Add(TB)
        'TB.DisplayIndex = 1
        'TB.Width = 21

        Me.LBL_Stagiaire_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Sub Remplir_Onglet_Information_Stagiaire(ByVal DG As DataGridView, ByVal index As Integer)
        Dim id As String = DG.Rows(index).Cells(0).Value

        Me.CB_S_Civ.Text = DG.Rows(index).Cells(1).Value
        Me.TB_S_Nom.Text = DG.Rows(index).Cells(2).Value
        Me.TB_S_Prenom.Text = DG.Rows(index).Cells(4).Value
        Me.RTB_S_Adresse.Text = DG.Rows(index).Cells(6).Value & ", " & DG.Rows(index).Cells(7).Value & " " & DG.Rows(index).Cells(8).Value
        Me.TB_S_Pays.Text = DG.Rows(index).Cells(9).Value
        Me.TB_S_Tel.Text = DG.Rows(index).Cells(10).Value
        Me.Email_Stagiaire.Text = DG.Rows(index).Cells(11).Value

        For Each Ligne As DataRow In o_Stagiaire.Donnees_entreprises.Rows()
            If Ligne("idPersonne").ToString = id Then
                Me.RTB_S_Fonction.Text = Ligne("Fonction").ToString
                Me.RTB_S_Entreprise.Text = Ligne("NomE").ToString
                Me.DTP_S_Anciennete.Value = Ligne("Anciennete").ToString
            End If
        Next

        Me.TB_Prix.Text = DG.Rows(index).Cells(17).Value
        Me.CB_StatutPaiement.Text = DG.Rows(index).Cells(18).Value

    End Sub

    Sub Init_champs_Information_stagiaires()
        Me.CB_S_Civ.Text = ""
        Me.TB_S_Nom.Text = ""
        Me.TB_S_Prenom.Text = ""
        Me.RTB_S_Adresse.Text = ""
        Me.TB_S_Pays.Text = ""
        Me.TB_S_Tel.Text = ""
        Me.Email_Stagiaire.Text = ""
        Me.DTP_I_DateN.Value = System.DateTime.Today
        Me.RTB_S_Fonction.Text = ""
        Me.RTB_S_Entreprise.Text = ""
        Me.DTP_S_Anciennete.Value = System.DateTime.Today
        Me.TB_Prix.Text = ""
    End Sub

    Sub OuvertureDesChamps_stagiaires()
        Me.CB_S_Civ.Enabled = True
        Me.TB_S_Nom.Enabled = True
        Me.TB_S_Prenom.Enabled = True
        Me.RTB_S_Adresse.Enabled = True
        Me.TB_S_Pays.Enabled = True
        Me.TB_S_Tel.Enabled = True
        Me.Email_Stagiaire.Enabled = True
        'Me.DTP_I_DateN.Enabled = True
        'Me.TB_I_LieuN.Enabled = True
        'Me.TB_I_PaysN.Enabled = True
        'Me.TB_I_NumSS.Enabled = True
        Me.RTB_S_Fonction.Enabled = True
        Me.RTB_S_Entreprise.Enabled = True
        Me.DTP_S_Anciennete.Enabled = True
        Me.TB_Prix.Enabled = True
        Me.CB_StatutPaiement.Enabled = True
    End Sub

    Sub FermetureDesChamps_stagiaires()
        Me.CB_S_Civ.Enabled = False
        Me.TB_S_Nom.Enabled = False
        Me.TB_S_Prenom.Enabled = False
        Me.RTB_S_Adresse.Enabled = False
        Me.TB_S_Pays.Enabled = False
        Me.TB_S_Tel.Enabled = False

        'Me.DTP_I_DateN.Enabled = True
        'Me.TB_I_LieuN.Enabled = True
        'Me.TB_I_PaysN.Enabled = True
        'Me.TB_I_NumSS.Enabled = True
        Me.RTB_S_Fonction.Enabled = False
        Me.RTB_S_Entreprise.Enabled = False
        Me.DTP_S_Anciennete.Enabled = False
        Me.TB_Prix.Enabled = False
        Me.CB_StatutPaiement.Enabled = False
    End Sub

    Private Sub DG_Liste_Stagiaires_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Liste_Stagiaires.CellContentClick
        Init_champs_Information_stagiaires()
        'intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur)
        'Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Remplir_Onglet_Information_Stagiaire(Me.DG_Liste_Stagiaires, Me.DG_Liste_Stagiaires.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Stagiaires_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Stagiaires.RowHeaderMouseClick
        Init_champs_Information_stagiaires()
        'intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur)
        'Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Remplir_Onglet_Information_Stagiaire(Me.DG_Liste_Stagiaires, Me.DG_Liste_Stagiaires.CurrentRow.Index)
    End Sub

    Private Sub BT_Nouveau_Stagiaire_Click(sender As Object, e As EventArgs) Handles BT_Nouveau_Stagiaire.Click
        Dim Nouv As New NouveauStagiaire(bdd, idSession)
        Nouv.Show()
    End Sub

    Private Sub BindingNavigatorAddNewItem2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem2.Click
        Me.BT_Nouveau_Stagiaire.PerformClick()
    End Sub

    Private Sub BT_Refresh_Stagiaires_Click(sender As Object, e As EventArgs) Handles BT_Refresh_Stagiaires.Click
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation, idSession, idFormation)
        o_Stagiaire = New Onglet_stagiaire(bdd, SF)
        Remplir_DG_Liste_Stagiaires()
    End Sub

    Private Sub BT_Modifier_Stagiaires_Click(sender As Object, e As EventArgs) Handles BT_Modifier_Stagiaires.Click
        OuvertureDesChamps_stagiaires()
    End Sub

    Private Sub BT_S_Enregistrer_Click(sender As Object, e As EventArgs) Handles BT_S_Enregistrer.Click
        Enregistrer_infos_stagiaire()
        FermetureDesChamps_stagiaires()
    End Sub

    Private Sub Enregistrer_infos_stagiaire()
        Dim req1 As String = "update inscription_stagiaires set CiviliteP='" & Me.CB_S_Civ.Text & "',NomP='" & Me.TB_S_Nom.Text & "'
        ,PrenomP='" & Me.TB_S_Prenom.Text & "',PaysP='" & Me.TB_S_Pays.Text & "',NumTelP='" & Me.TB_S_Tel.Text & "'
        ,MailP='" & Me.Email_Stagiaire.Text & "' 
        where idPersonne='" & Me.DG_Liste_Stagiaires.CurrentRow.Cells(0).Value & "'"
        Dim req3 As String = "update inscription_stagiaires set Prix='" & Me.TB_Prix.Text & "',Paiement='" & Me.CB_StatutPaiement.Text & "'
            where idPersonne='" & Me.DG_Liste_Stagiaires.CurrentRow.Cells(0).Value & "'"
        Dim cmd1 As New SqlCommand(req1, bdd.connect)
        Dim cmd3 As New SqlCommand(req3, bdd.connect)
        Dim res1 As Integer = 0
        Dim res3 As Integer = 0

        Try
            res1 = cmd1.ExecuteNonQuery()
            cmd1.Dispose()
            res3 = cmd3.ExecuteNonQuery()
            cmd3.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub BT_Supprimer_Stagiaire_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_Stagiaire.Click
        Me.BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub BT_Enregistrer_stagiaires_Click(sender As Object, e As EventArgs) Handles BT_Enregistrer_stagiaires.Click
        Me.Enregistrer_Stagiaires.PerformClick()
        Inscription_stagiairesTableAdapter.Adapter.Update(Me.Formation_ContinueDataSet2.inscription_stagiaires.DataSet)
    End Sub

#End Region

#Region "Onglet Planning"

    Sub MAJ_planning()
        'Dim m_app As New WindowsFormsCalendar.C

        'm_app.StartDate = CDate("12/08/2016 09:15:00")
        'm_app.EndDate = "12/08/2016 10:15:00"
        'm_app.BorderColor = Color.Red
        'Me.Calendar2.Invalidate()
        'Me.Calendar2.Refresh()

        'MonDayView.AllowInplaceEditing = True
        'MonDayView.n
        'MonDayView.CreateControl()
        'm_apps.Add(m_app)
        'MonDayView.Refresh()

        'MonDayView.Invalidate()
        'MonDayView.Refresh()

        'Calendar1.SetViewRange(MonthView1.SelectionStart, MonthView1.SelectionStart.AddDays(4))
        Calendar1.ViewStart = MonCalendrier.SelectionStart.AddHours(5)
        Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4).AddHours(5)
        RemplirPlanning()

    End Sub

    Sub RemplirPlanning()
        'Dim item1 As New CalendarItem(Me.Calendar1, CDate("12/08/2016 09:15:00"), CDate("12/08/2016 10:00:00"), "Mon RDV")
        'Dim item2 As New CalendarItem(Me.Calendar1, CDate("13/08/2016 10:30:00"), CDate("13/08/2016 12:00:00"), "Mon 2e RDV")

        For Each Ligne As DataRow In o_Planning.Seances.Rows()
            Dim item As New CalendarItem(Me.Calendar1, CDate(Ligne("HeureDebut").ToString), CDate(Ligne("HeureFin").ToString), Ligne("Salle").ToString)
            If item.Date >= Me.Calendar1.ViewStart.Date And item.Date <= Me.Calendar1.ViewEnd.Date.AddDays(1) Then
                Calendar1.Items.Add(item)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Lorsque l'utilisateur sélectionne une date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonCalendrier.DateSelected
        'MonDayView.StartDate = MonCalendrier.SelectionStart
        If Me.MonCalendrier.SelectionStart > Me.Calendar1.ViewStart Then
            Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4)
            Calendar1.ViewStart = MonCalendrier.SelectionStart
        Else
            Calendar1.ViewStart = MonCalendrier.SelectionStart
            Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4)
        End If
        'Me.Calendar1.SetViewRange(MonCalendrier.SelectionStart, MonCalendrier.SelectionStart.AddDays(4))
        RemplirPlanning()
    End Sub

#End Region

#Region "Temps Agent"

    Sub Remplir_panel()
        Me.TB_Agent.Text = bdd.username
        Me.TB_NomFormation.Text = NomFormation
        Me.TB_NomSession.Text = SessionFormation
    End Sub

    Sub Remplir_LB_Taches()
        Dim Type As String
        Type = infos_formation()
        Dim Liste_Offres_institutionelles As New List(Of String) From {"Prise de commande", "Elaboration de l'offre", "Contractualisation/Marché", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}

        Select Case Type
            Case "Offres institutionnelles"
                For Each tache As String In Liste_Offres_institutionelles
                    Me.LB_Taches.Items.Add(tache)
                Next

            Case "Mastère spécialisé"
                Me.LB_Taches.Items.Add("M1")
        End Select
    End Sub

    Function infos_formation() As String
        Dim req As String = "select*from Formation where idFormation='" & idFormation & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As String = ""

        Try
            Dim Monreader As SqlDataReader = cmd.ExecuteReader()
            If Monreader.Read() Then
                res = Monreader("Type").ToString
            End If
            Monreader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
        Return res
    End Function

    Sub TempsAgent()
        'Me.MonthCalendar1
    End Sub

#End Region

#Region "Documents"

    Private Sub BT_DossierEngagement_Click(sender As Object, e As EventArgs) Handles BT_DossierEngagement.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereDossierEngagement()
        End If
    End Sub

    Private Sub BT_Service_fait_Click(sender As Object, e As EventArgs) Handles BT_Service_fait.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereFicheServicefait()
        End If
    End Sub

    Private Sub BT_Convocation_Click(sender As Object, e As EventArgs) Handles BT_Convocation.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereConvocationIntervenant()
        End If
    End Sub

    Private Sub BT_Fiche_Emargement_Click(sender As Object, e As EventArgs) Handles BT_Fiche_Emargement.Click
        Dim fichier As String = "S:\Outil FC\Documents\fiche Emargement.doc"
        Dim nb As Integer = Me.DG_Liste_Stagiaires.RowCount 'Nombre de stagiaires
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        Dim oTable As Word.Table

        'Ouvrir un document
        oDoc = oWord.Documents.Open(fichier)
        'Rendre le document visible
        oWord.Visible = True

        oDoc.Bookmarks.Item("Date").Range.Text = DateTime.Now.Date.ToString("d")
        oDoc.Bookmarks.Item("Formation").Range.Text = NomFormation

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("Tableau").Range, nb - 1, 6)
        oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle

        For ligne = 1 To nb - 1
            oTable.Cell(ligne, 1).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne - 1).Cells.Item(1).Value
            oTable.Cell(ligne, 2).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne - 1).Cells.Item(2).Value.ToString.ToUpper
            oTable.Cell(ligne, 3).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne - 1).Cells.Item(4).Value
            oTable.Cell(ligne, 4).Range.Text = TrouverEntreprise(Me.DG_Liste_Stagiaires.Rows.Item(ligne - 1).Cells.Item(0).Value)
        Next

    End Sub

    Private Function TrouverEntreprise(ByVal id As String) As String
        Dim req As String = "select*from emplois where idPersonne ='" & id & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As String = ""
        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                res = MonReader("NomE").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
        Return res
    End Function

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

#Region "Export"

    Private Sub BT_Export_DG_ListeIntervenants_Click(sender As Object, e As EventArgs) Handles BT_Export_DG_ListeIntervenants.Click
        ExportExcel("S:\Outil FC\Exports\Liste_intervenants.xls", Me.DG_Liste_Intervenants)
    End Sub

    Private Sub BT_Export_stagiaires_Click(sender As Object, e As EventArgs) Handles BT_Export_stagiaires.Click
        ExportExcel("S:\Outil FC\Exports\Liste_stagiaires.xls", Me.DG_Liste_Stagiaires)
    End Sub

    Sub ExportExcel(ByVal Filename As String, ByRef DG As DataGridView)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i, j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Feuil1")


        For i = 0 To DG.RowCount - 2
            For j = 1 To DG.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) = DG(j, i).Value.ToString()
            Next
        Next

        xlWorkBook.SaveAs(Filename,
                          Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                          Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MessageBox.Show("Tableau exporté")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region

    ''' <summary>
    ''' Effectue la déconnexion à la base de données et ferme le programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        bdd.deconnexion()
        Me.Dispose()
        PageConnexion.Show()
    End Sub



    Private Sub BT_FichePerso_Click(sender As Object, e As EventArgs)
        FichePersoIntervenant.Show()
    End Sub

    Private Sub CréerUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnUtilisateurToolStripMenuItem.Click
        Dim aj As New Ajout_Utilisateur(bdd)
        aj.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BT_Statut_Paiement.Click
        ''Si les modifications sont activées
        'If Me.DG_Liste_Interventions_nonpayees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2 Then
        '    For Each Ligne As DataGridViewRow In Me.DG_Liste_Interventions_nonpayees.Rows
        '        If Ligne.Cells.Item(0).OwningColumn.Name Is "_" And Ligne.Cells.Item(0).Value = True Then
        '            Ligne.Cells.Item(14).Value = "Payé"
        '            'Me.DG_Liste_Interventions_payees.Rows.IndexOf(Ligne) = 1
        '            'Ligne.Index += 1
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation, idSession, idFormation)
        For Each Ligne As DataGridViewRow In Me.DG_Liste_Interventions.Rows
            o_Intervenant.MAJ_Interventions(SF, Ligne, "Non payé")
        Next
    End Sub

    Private Sub ModifierUtilisateurToolStripMenu_Click(sender As Object, e As EventArgs) Handles ModifierUtilisateurToolStripMenu.Click
        Dim Modif_User As New Modification_utilisateur(bdd, utilisateur)
        Modif_User.Show()
    End Sub

    Private Sub TableauDesVacationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableauDesVacationsToolStripMenuItem.Click
        Dim TableVac As New Vacation(bdd)
        TableVac.Show()
    End Sub

    Private Sub NouvelleFormationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleFormationToolStripMenuItem.Click
        Dim Modif_formation As New Edit_Formation(bdd)
        Modif_formation.Show()
    End Sub

    Private Sub NouvelleSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleSessionToolStripMenuItem.Click
        Dim Nvelle_session As New Edit_Session(utilisateur, bdd)
        Nvelle_session.Show()

    End Sub

    Private Sub SupprimerUtilisateurToolStripMenu_Click(sender As Object, e As EventArgs) Handles SupprimerUtilisateurToolStripMenu.Click
        Dim suppr_utilisateur As New SupprimerUtilisateur(bdd)
        suppr_utilisateur.Show()
    End Sub

End Class