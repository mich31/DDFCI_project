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

    ''' <summary>
    ''' Initialise la fenêtre en chargeant les tables de la base de données
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Formation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.TempsAgent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.TempsAgentTableAdapter.Fill(Me.Formation_ContinueDataSet1.TempsAgent)
        Me.TempsAgentTableAdapter.FillBy_user(Me.Formation_ContinueDataSet1.TempsAgent, bdd.username)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.liste_seances'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_seancesTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_seances)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.liste_seances'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_seancesTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_seances)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.liste_seances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Liste_seancesTableAdapter.Fill(Me.Formation_ContinueDataSet2.liste_seances)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.temps_agent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.Temps_agentTableAdapter.Fill(Me.Formation_ContinueDataSet1.temps_agent)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet2.inscription_stagiaires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Inscription_stagiairesTableAdapter.Fill(Me.Formation_ContinueDataSet2.inscription_stagiaires)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.liste_interventions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Liste_interventionsTableAdapter.Fill(Me.Formation_ContinueDataSet1.liste_interventions)
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.profils_intervenant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Profils_intervenantTableAdapter.Fill(Me.Formation_ContinueDataSet1.profils_intervenant)

        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username) 'Crée le noeud principal de l'arborescence
        CreerUtilisateur()
        CreerArborescence()
        GestionDesDroits()
        OrdonneOnglets()
    End Sub

    ''' <summary>
    ''' Gère l'ordre des onglets de la fenêtre
    ''' </summary>
    Sub OrdonneOnglets()

        Dim Temp As TabPage
        Temp = Me.TabPage7
        Me.TabControl2.TabPages.Item(1) = Me.TabPage1
        Me.TabControl2.TabPages.Item(3) = Me.TabPage9

        Me.TabControl2.TabPages.Item(4) = Temp

        ' Suppression de l'onglet Paiement(s) à l'affichage
        Me.TabControl2.TabPages.Remove(Me.TabPage9)
        Me.TabControl1.TabPages.Remove(Me.TabPage6)
    End Sub

    ''' <summary>
    ''' Allocation des droits à certains utilisateurs en activant certains boutons
    ''' </summary>
    Sub GestionDesDroits()
        If utilisateur.fonction = "Admin" Or utilisateur.fonction = "Direction" Then
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

        Dim Login As String = ""
        Dim Pwd As String = ""
        Dim Fct As String = ""
        Dim Mail As String = ""
        Dim Telephone As String = ""
        Dim Telecopie As String = ""

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Login = MonReader("Login").ToString
                Pwd = MonReader("Password").ToString
                Fct = MonReader("Fonction").ToString
                Mail = MonReader("Mail").ToString
                Telephone = MonReader("Telephone").ToString
                Telecopie = MonReader("Telecopie").ToString
            End If
            MonReader.Close()
            utilisateur = New Utilisateur(Login, Pwd, Fct, Mail, Telephone, Telecopie, bdd)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub


#Region "Arborescence Formations"

    ''' <summary>
    ''' Actualise l'arborescence
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BT_Actualiser_TV_Click(sender As Object, e As EventArgs) Handles BT_Actualiser_TV.Click
        Me.TV_Menu.Nodes.Clear()
        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username)
        ActualiserArborescence()
    End Sub

    Sub ActualiserArborescence()
        Dim Req As String = "select distinct NomF from travaille_sur_formation where Login='" & bdd.username & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)
        MonDataSet.Tables("travaille_sur_formation").Clear()

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
    ''' Charge les données en fonction de la session de formation selectionnée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
            Me.BT_Ajouter.Enabled = True
        ElseIf Me.TV_Menu.SelectedNode.Level = 1 Then 'Si le noeud sélectionné est une formation
            NomFormation = Me.TV_Menu.SelectedNode.Text
            Me.BT_Ajouter.Enabled = False
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

        'o_Planning = New Onglet_planning(bdd, SF)
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

        Remplir_DG_Seances()
        Remplir_panel()
        Remplir_LB_Taches()

        If utilisateur.fonction = "Admin" Or utilisateur.fonction = "Direction" Then
            Me.TempsAgentTableAdapter.FillBy_user_session(Me.Formation_ContinueDataSet1.TempsAgent, "%", NomFormation, SessionFormation)
        Else
            Me.TempsAgentTableAdapter.FillBy_user_session(Me.Formation_ContinueDataSet1.TempsAgent, bdd.username, NomFormation, SessionFormation)
        End If

    End Sub


    ''' <summary>
    ''' Crée l'arborescence des formations et sessions de formations sur lesquelles l'utilisateur travaille
    ''' </summary>
    Sub CreerArborescence()
        If utilisateur.fonction = "Admin" Or utilisateur.fonction = "Direction" Then
            Dim Req As String = "select distinct NomF from Formation"
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
        Else
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
        End If
    End Sub


    ''' <summary>
    ''' Crée l'arborescence des sessions de formations par utilisateur
    ''' </summary>
    ''' <param name="NomFormation"></param>
    ''' <param name="NodeActuel"></param>
    Sub CreerArborescenceFormation(ByVal NomFormation As String, ByVal NodeActuel As TreeNode)
        Dim Node As TreeNode = NodeActuel.Nodes(NomFormation)
        If utilisateur.fonction = "Admin" Or utilisateur.fonction = "Direction" Then
            Dim Req As String = "select*from SessionFormation S, Formation F 
                where S.idFormation = F.idFormation and NomF = '" & NomFormation & "'"
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
        Else
            Dim Req As String = "Select * from travaille_sur_formation where Login='" & bdd.username & "' and NomF='" & NomFormation & "'"
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
        End If
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

        Me.LBL_Intervenant_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Sub Remplir_DG_Liste_Interventions()
        Me.Param_NomFormation.Text = NomFormation
        Me.Param_Session.Text = SessionFormation

        FillBy_interventionsToolStripButton.PerformClick()

    End Sub

    Private Sub BT_Actualiser_paiement_Click(sender As Object, e As EventArgs) Handles BT_Actualiser_paiement.Click
        Try
            Me.Liste_interventionsTableAdapter.FillBy_interventions(Me.Formation_ContinueDataSet1.liste_interventions, Param_NomFormation.Text, Param_Session.Text, Param_Nom.Text, Param_Prenom.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
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
        Me.TB_I_Ville.Text = ""
        Me.TB_I_CP.Text = ""
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
        Me.TB_I_Ville.Enabled = True
        Me.TB_I_CP.Enabled = True
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
        Me.TB_I_Ville.Enabled = False
        Me.TB_I_CP.Enabled = False
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
        Me.RTB_I_Adresse.Text = DG.Rows(index).Cells(10).Value
        Me.TB_I_Ville.Text = DG.Rows(index).Cells(12).Value
        Me.TB_I_CP.Text = DG.Rows(index).Cells(11).Value
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
        Me.Param_Prenom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value

        Remplir_DG_Liste_Interventions()

        Remplir_Onglet_Information_Intervenant(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Intervenants_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Intervenants.RowHeaderMouseClick
        Init_champs_Information()
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur, SF.infos_session)
        'Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Me.Param_Nom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        'Me.Param_Nom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value
        'Me.Param_Nom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(2).Value

        Me.Param_Prenom.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        ' Me.Param_Prenom1_P.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value
        'Me.Param_Prenom_NP.Text = Me.DG_Liste_Intervenants.CurrentRow.Cells(4).Value

        Remplir_DG_Liste_Interventions()

        Remplir_Onglet_Information_Intervenant(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub BT_Supprimer_Intervention_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_Intervention.Click
        supprime_intervention()
        Me.BN_Interventions_DeleteItem.PerformClick()
    End Sub

    Private Sub supprime_intervention()
        Dim idIntervenant As String = Me.DG_Liste_Interventions.CurrentRow.Cells(2).Value
        Dim idSeance As String = Me.DG_Liste_Interventions.CurrentRow.Cells(4).Value
        Dim req As String = "delete from intervient where idIntervenant = '" & idIntervenant & "' and idSeance = '" & idSeance & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Intervention supprimée!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BT_Ajouter_Intervention_Click(sender As Object, e As EventArgs) Handles BT_Ajouter_Intervention.Click
        'Me.BN_Interventions_AddItem.PerformClick()
    End Sub

    Private Sub BT_Nouvel_Intervenant_Click(sender As Object, e As EventArgs) Handles BT_Nouvel_Intervenant.Click
        Dim Nouv As New NouvelIntervenant(bdd, idSession)
        Nouv.Show()
    End Sub

    Private Sub BT_Supprimer_intervenant_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_intervenant.Click
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
        Me.BT_Actualiser_Intervenants.PerformClick()

    End Sub

    ''' <summary>
    ''' Enregistre les modifications sur les infos de l'intervenant sélectionné
    ''' </summary>
    Sub Enregistrer_infos_intervenant()
        Dim req1 As String = "update profils_intervenant set CiviliteP = '" & Me.CB_I_Civilite.Text & "',NomP='" & Me.TB_I_Nom.Text & "'
            ,PrenomP='" & Me.TB_I_Prenom.Text & "',PaysP='" & Me.TB_I_Pays.Text & "',NumTelP='" & Me.TB_I_Telephone.Text & "'
            ,MailP='" & Me.LinkLabel_Mail_Intervenant.Text & "',AdresseP='" & Me.RTB_I_Adresse.Text & "',CP='" & Me.TB_I_CP.Text & "'
            ,VilleP='" & Me.TB_I_Ville.Text & "'
            where idPersonne = '" & Me.DG_Liste_Intervenants.CurrentRow.Cells("idPersonne").Value & "'"
        Dim req2 As String = "update profils_intervenant set DateNaissanceI ='" & Me.DTP_I_DateN.Value.ToString("yyyy-MM-dd") & "',LieuNaissanceI='" & Me.TB_I_LieuN.Text & "'
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

    Private Sub DG_Liste_Interventions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Liste_Interventions.CellContentClick
        Me.CB_Statut.Text = Me.DG_Liste_Interventions.CurrentRow.Cells(13).Value
    End Sub

    Private Sub DG_Liste_Interventions_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Interventions.RowHeaderMouseClick
        Me.CB_Statut.Text = Me.DG_Liste_Interventions.CurrentRow.Cells(13).Value
    End Sub

    Private Sub BT_Statut_Paiement_Click(sender As Object, e As EventArgs) Handles BT_Statut_Paiement.Click
        Dim Statut As String = Me.CB_Statut.Text
        Dim idIntervenant As String = Me.DG_Liste_Interventions.CurrentRow.Cells(2).Value
        Dim idSeance As String = Me.DG_Liste_Interventions.CurrentRow.Cells(4).Value
        Dim req As String = "update liste_interventions set StatutPaiement = '" & Statut & "' 
            where idIntervenant = '" & idIntervenant & "' and idSeance = '" & idSeance & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer
        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Statut changé!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox(ex.Message)
        End Try
        Me.BT_Actualiser_paiement.PerformClick()

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

        Me.TB_Prix.Text = DG.Rows(index).Cells(17).Value.ToString

        Me.CB_StatutPaiement.Text = DG.Rows(index).Cells(18).Value

    End Sub

    Sub Init_champs_Information_stagiaires()
        Me.CB_S_Civ.Text = ""
        Me.TB_S_Nom.Text = ""
        Me.TB_S_Prenom.Text = ""
        Me.RTB_S_Adresse.Text = ""
        Me.TB_S_CP.Text = ""
        Me.TB_S_Ville.Text = ""
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
        Me.TB_S_Ville.Enabled = True
        Me.TB_S_CP.Enabled = True
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
        Me.TB_S_Ville.Enabled = False
        Me.TB_S_CP.Enabled = False
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
        Me.BT_Refresh_Stagiaires.PerformClick()

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
        Me.BT_Enregistrer_stagiaires.PerformClick()

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
        'Calendar1.ViewStart = MonCalendrier.SelectionStart.AddHours(5)
        'Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4).AddHours(5)
        RemplirPlanning()

    End Sub

    Sub RemplirPlanning()
        'Dim item1 As New CalendarItem(Me.Calendar1, CDate("12/08/2016 09:15:00"), CDate("12/08/2016 10:00:00"), "Mon RDV")
        'Dim item2 As New CalendarItem(Me.Calendar1, CDate("13/08/2016 10:30:00"), CDate("13/08/2016 12:00:00"), "Mon 2e RDV")

        'For Each Ligne As DataRow In o_Planning.Seances.Rows()
        '    Dim item As New CalendarItem(Me.Calendar1, CDate(Ligne("HeureDebut").ToString), CDate(Ligne("HeureFin").ToString), Ligne("Salle").ToString)
        '    If item.Date >= Me.Calendar1.ViewStart.Date And item.Date <= Me.Calendar1.ViewEnd.Date.AddDays(1) Then
        '        Calendar1.Items.Add(item)
        '    End If
        'Next
    End Sub

    ''' <summary>
    ''' Lorsque l'utilisateur sélectionne une date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs)
        'MonDayView.StartDate = MonCalendrier.SelectionStart
        'If Me.MonCalendrier.SelectionStart > Me.Calendar1.ViewStart Then
        '    Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4)
        '    Calendar1.ViewStart = MonCalendrier.SelectionStart
        'Else
        '    Calendar1.ViewStart = MonCalendrier.SelectionStart
        '    Calendar1.ViewEnd = MonCalendrier.SelectionStart.AddDays(4)
        'End If
        'Me.Calendar1.SetViewRange(MonCalendrier.SelectionStart, MonCalendrier.SelectionStart.AddDays(4))
        RemplirPlanning()
    End Sub

#End Region

#Region " Sous onglet Séances"

    Private Sub BT_Ajouter_seance_Click(sender As Object, e As EventArgs) Handles BT_Ajouter_seance.Click
        Ajoute_seance()
        Me.BT_Actualiser.PerformClick()
    End Sub

    Private Sub Ajoute_seance()
        Dim MaDate As Date = Me.DTP_Seance.Value.Date
        Dim req As String = "insert into Seance (idSessionFormation,Module,Date,HeureDebut,HeureFin) 
            values ('" & idSession & "','" & Me.TB_Module.Text & "','" & MaDate.ToString("yyyy-MM-dd") & "','" & Me.TB_Heure_DebutSeance.Text & "','" & Me.TB_Heure_FinSeance.Text & "')"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Séance ajoutée!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub BT_Ajout_intervention_Click(sender As Object, e As EventArgs) Handles BT_Ajout_intervention.Click
        Dim ajout As New Ajout_intervention(bdd, Me.DG_Liste_Intervenants.CurrentRow, Me.DG_Seances.CurrentRow)
        ajout.Show()
        'Ajoute_intervention()
    End Sub

    Private Sub BT_Actualiser_Click(sender As Object, e As EventArgs) Handles BT_Actualiser.Click
        Remplir_DG_Seances()
    End Sub

    Private Sub BT_supprimer_seance_Click(sender As Object, e As EventArgs) Handles BT_supprimer_seance.Click
        supprime_seance()
        Me.BT_Actualiser.PerformClick()
    End Sub

    Private Sub supprime_seance()
        Dim req As String = "delete from Seance where idSeance ='" & Me.DG_Seances.CurrentRow.Cells(0).Value & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer = 0
        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Séance supprimée!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub Remplir_DG_Seances()
        Try
            Me.Liste_seancesTableAdapter.FillBy_Seances(Me.Formation_ContinueDataSet2.liste_seances, NomFormation, SessionFormation)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Temps Agent"

    Sub Remplir_panel()
        Me.TB_Agent.Text = bdd.username
        Me.TB_NomFormation.Text = NomFormation
        Me.TB_NomSession.Text = SessionFormation
    End Sub

    Sub Remplir_LB_Taches()
        Dim Type, Projet As String
        Type = infos_type_formation()
        Projet = infos_projet_formation()
        Me.TB_Type_Projet.Text = Projet
        Me.TB_Type_Formation.Text = Type

        Dim Liste_MSpe As New List(Of String) From {"Etude de marché", "Etablissement du pré-projet", "Elaboration dossier d'accréditation", "Vie du MSpé", "Renouvellement Accréditation annuel"}

        Dim Liste_Offres_institutionelles_AvecMarches As New List(Of String) From {"Prise de commande", "Elaboration de l'offre", "Contractualisation/Marché", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}
        Dim Liste_Offres_institutionelles_SansMarches As New List(Of String) From {"Prise de commande", "Elaboration de l'offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}

        Dim Liste_Offres_payantes_intra As New List(Of String) From {"Prise de commande", "Elaboration Pré-Projet", "Elaboration/Constitution de l'offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}
        Dim Liste_Offres_payantes_extra As New List(Of String) From {"Prise de commande", "Elaboration Pré-Projet", "Contractualisation/Marché", "Elaboration de l'Offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}
        Dim Liste_Offres_payantes_AO As New List(Of String) From {"Réponse AO", "Elaboration/Constitution de l'Offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}

        Dim Liste_Offres_internationales_seminaires As New List(Of String) From {"Elaboration Pré-Projet", "Recherche de Financement/Communication", "Elaboration/Constitution de l'Offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}
        Dim Liste_Offres_internationales_ces As New List(Of String) From {"Elaboration/Constitution de l'Offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}
        Dim Liste_Offres_internationales_AO As New List(Of String) From {"Réponse AO", "Elaboration/Constitution de l'Offre", "Mise en oeuvre/Suivi", "Evaluation/Bilan"}

        Me.LB_Taches.Items.Clear()

        If Projet.Equals("Mastère spécialisé") Then
            For Each tache As String In Liste_MSpe
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres institutionnelles") And Type.Equals("Offres Avec Marchés") Then
            For Each tache As String In Liste_Offres_institutionelles_AvecMarches
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres institutionnelles") And Type.Equals("Offres Sans Marchés") Then
            For Each tache As String In Liste_Offres_institutionelles_SansMarches
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres payantes") And Type.Equals("Offres Payantes Intra(Sollicitation)") Then
            For Each tache As String In Liste_Offres_payantes_intra
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres payantes") And Type.Equals("Offres Payantes Extra") Then
            For Each tache As String In Liste_Offres_payantes_extra
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres payantes") And Type.Equals("Offres AO") Then
            For Each tache As String In Liste_Offres_payantes_AO
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres internationales") And Type.Equals("Séminaires") Then
            For Each tache As String In Liste_Offres_internationales_seminaires
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres internationales") And Type.Equals("CES") Then
            For Each tache As String In Liste_Offres_internationales_ces
                Me.LB_Taches.Items.Add(tache)
            Next
        ElseIf Projet.Equals("Offres internationales") And Type.Equals("Offres AO") Then
            For Each tache As String In Liste_Offres_internationales_AO
                Me.LB_Taches.Items.Add(tache)
            Next
        End If
    End Sub

    Function infos_type_formation() As String
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

    Function infos_projet_formation() As String
        Dim req As String = "select*from Formation where idFormation='" & idFormation & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As String = ""

        Try
            Dim Monreader As SqlDataReader = cmd.ExecuteReader()
            If Monreader.Read() Then
                res = Monreader("Projet").ToString
            End If
            Monreader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
        Return res
    End Function

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        test_ajout_temps()
        Me.TempsAgentTableAdapter.FillBy_user_session(Me.Formation_ContinueDataSet1.TempsAgent, utilisateur.user, NomFormation, SessionFormation)
    End Sub

    Private Sub ajoute_temps()
        Dim Type_projet As String = Me.TB_Type_Projet.Text
        Dim Type_Formation As String = Me.TB_Type_Formation.Text
        Dim nb As Double = Me.NUP_nb_jours.Value
        Dim temps As String = nb.ToString.Replace(",", ".")
        Dim req As String = "insert into TempsAgent 
            values ('" & idSession & "','" & utilisateur.user & "','" & NomFormation & "','" & SessionFormation & "',
            '" & Type_projet & "','" & Type_Formation & "','" & Me.LB_Taches.SelectedItem.ToString.Replace("'", "''") & "'," & temps & ",'" & Me.DTP_Periode.Value.ToString("yyyy-MM-dd") & "')"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer
        Try
            res = cmd.ExecuteNonQuery()
            If res = 1 Then
                MsgBox("Temps ajouté!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Private Sub test_ajout_temps()
        Dim max As Date = trouve_date_max()
        'MsgBox(max)
        Dim MaDate As Date = Me.DTP_Periode.Value
        'MsgBox(MaDate)
        If MaDate > max.AddDays(7) Then
            'MsgBox("Go")
            ajoute_temps()
        Else
            MsgBox("Veuillez saisir une date ultérieure au " & max.AddDays(7))
        End If
    End Sub

    Private Function trouve_date_max() As Date
        Dim req As String = "select MAX(Date) as max from TempsAgent T 
        where T.Login = '" & bdd.username & "' and T.Formation = '" & NomFormation & "' and T.Session = '" & SessionFormation & "' 
        and T.Tache = '" & Me.LB_Taches.SelectedItem.ToString.Replace("'", "''") & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Date
        Dim MonReader As SqlDataReader = cmd.ExecuteReader()
        Try
            If MonReader.Read() Then
                res = MonReader("max").ToString
            End If

        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            'MsgBox(ex.Message)
            res = "1900-01-01"
        End Try
        MonReader.Close()
        cmd.Dispose()

        Return res
    End Function


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


#End Region

#Region "Export"

    Private Sub BT_Export_DG_ListeIntervenants_Click(sender As Object, e As EventArgs) Handles BT_Export_DG_ListeIntervenants.Click
        ExportExcel("S:\Outil FC\Exports\Liste_intervenants_" & NomFormation & "_" & SessionFormation & "_" & bdd.username & ".xls", Me.DG_Liste_Intervenants)
    End Sub

    Private Sub BT_Export_Interventions_Click(sender As Object, e As EventArgs) Handles BT_Export_Interventions.Click
        ExportInterventions("S:\Outil FC\Exports\Vacations\" & NomFormation & "_" & SessionFormation & "_" & bdd.username & "_" & Me.Param_Nom.Text & "_" & Me.Param_Prenom.Text & ".xls", Me.DG_Liste_Interventions)
        'ExportInterventions("C:\Test\Vacations\" & NomFormation & "_" & SessionFormation & "_" & bdd.username & "_" & Me.Param_Nom.Text & "_" & Me.Param_Prenom.Text & ".xls", Me.DG_Liste_Interventions)
    End Sub

    Private Sub BT_Export_stagiaires_Click(sender As Object, e As EventArgs) Handles BT_Export_stagiaires.Click
        ExportExcel("S:\Outil FC\Exports\Liste_" & NomFormation & "_" & SessionFormation & "_" & bdd.username & ".xls", Me.DG_Liste_Stagiaires)
    End Sub

    Private Sub BT_Export_Temps_Click(sender As Object, e As EventArgs) Handles BT_Export_Temps.Click
        ExportExcel("S:\Outil FC\Exports\Temps_Travail_" & bdd.username & ".xls", Me.DG_Temps_saisie)
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
            For j = 0 To DG.ColumnCount - 1
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

    Sub ExportInterventions(ByVal Filename As String, ByRef DG As DataGridView)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i, j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Feuil1")

        'Entête du fichier excel
        xlWorkSheet.Cells(1, 1) = "Formation"
        xlWorkSheet.Cells(1, 2) = "Type d'intervention"
        xlWorkSheet.Cells(1, 3) = "Date"
        xlWorkSheet.Cells(1, 4) = "Nombre"
        xlWorkSheet.Cells(1, 5) = "Quantification HETD"
        xlWorkSheet.Cells(1, 6) = "Total HETD"
        xlWorkSheet.Cells(1, 7) = "Total en euros"
        xlWorkSheet.Cells(1, 8) = "Paiement"

        For i = 0 To DG.RowCount - 2
            xlWorkSheet.Cells(i + 2, 1) = DG(3, i).Value.ToString()
            xlWorkSheet.Cells(i + 2, 2) = DG(7, i).Value.ToString() 'Type d'intervention
            xlWorkSheet.Cells(i + 2, 3) = DG(8, i).Value.ToString() 'Date
            xlWorkSheet.Cells(i + 2, 4) = DG(11, i).Value.ToString() 'Nb d'heure
            xlWorkSheet.Cells(i + 2, 5) = DG(16, i).Value.ToString() 'Taux

            xlWorkSheet.Cells(i + 2, 7) = DG(14, i).Value.ToString() 'Cout
            xlWorkSheet.Cells(i + 2, 8) = DG(13, i).Value.ToString() 'Statut
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


    Private Sub Button9_Click(sender As Object, e As EventArgs)
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


    Private Sub SupprimerUtilisateurToolStripMenu_Click(sender As Object, e As EventArgs) Handles SupprimerUtilisateurToolStripMenu.Click
        Dim suppr_utilisateur As New SupprimerUtilisateur(bdd)
        suppr_utilisateur.Show()
    End Sub

    Private Sub SessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SessionToolStripMenuItem.Click
        Dim Nvelle_session As New Edit_Session(utilisateur, bdd)
        Nvelle_session.Show()
    End Sub

    Private Sub FormationToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles FormationToolStripMenuItem2.Click
        Dim Modif_formation As New Edit_Formation(bdd)
        Modif_formation.Show()
    End Sub

    Private Sub SuppressionBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppressionBDToolStripMenuItem.Click
        Dim suppr As New SuppressionBD(bdd)
        suppr.Show()
    End Sub
End Class