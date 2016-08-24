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
        Me.TV_Menu.TopNode = Me.TV_Menu.Nodes.Add(bdd.username)
        CreerArborescence()
        CreerUtilisateur()
        Creation_DG()
        GestionDesDroits()
        OrdonneOnglets()
        MAJ_planning()
    End Sub

    Sub OrdonneOnglets()
        Dim Temp As TabPage
        Temp = Me.TabPage7
        Me.TabControl2.TabPages.Item(1) = Me.TabPage8
        Me.TabControl2.TabPages.Item(2) = Temp
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

    Sub Remplir_DG_Liste_Intervenants()
        Me.DG_Liste_Intervenants.DataSource = o_Intervenant.Intervenants
        Dim nb As Integer = Me.DG_Liste_Intervenants.RowCount

        Me.DG_Liste_Intervenants.Columns("NomP").HeaderText = "Nom"
        Me.DG_Liste_Intervenants.Columns("PrenomP").HeaderText = "Prénom"
        Me.DG_Liste_Intervenants.Columns("CiviliteP").HeaderText = "Civilité"
        Me.DG_Liste_Intervenants.Columns("TypeIntervenant").HeaderText = "Type intervenant"
        Me.DG_Liste_Intervenants.Columns("DateNaissanceI").HeaderText = "Date de naissance"

        For Each col As DataGridViewColumn In Me.DG_Liste_Intervenants.Columns
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" And col.HeaderText IsNot "Civilité" And col.HeaderText IsNot "Type intervenant" And col.HeaderText IsNot "Date de naissance" Then
                col.Visible = False
            End If
            'col.ReadOnly = True
            If col.HeaderText Is "" Then
                'col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                col.ReadOnly = False
            End If
        Next

        Me.LBL_Intervenant_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Sub Remplir_DG_Liste_Interventions()
        Me.DG_Liste_Interventions.DataSource = o_Intervenant.Interventions
        Me.DG_Liste_Interventions.Columns("NomF").HeaderText = "Formation"
        Me.DG_Liste_Interventions.Columns("TypeIntervention").HeaderText = "Type d'intervention"
        Me.DG_Liste_Interventions.Columns("Date").HeaderText = "Date"
        Me.DG_Liste_Interventions.Columns("NbHeure").HeaderText = "Nb d'heures"
        Me.DG_Liste_Interventions.Columns("Salle").HeaderText = "Salle"
        Me.DG_Liste_Interventions.Columns("HeureDebut").HeaderText = "Début"
        Me.DG_Liste_Interventions.Columns("HeureFin").HeaderText = "Fin"

        For Each col As DataGridViewColumn In Me.DG_Liste_Interventions.Columns
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Salle" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
                col.Visible = False
            End If
            col.ReadOnly = True
            If col.HeaderText Is "" Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                col.ReadOnly = False
            End If
        Next

        Remplir_DG_Liste_Interventions_payees()
        Remplir_DG_Liste_Interventions_nonpayees()
    End Sub

    Sub Remplir_DG_Liste_Interventions_payees()
        Dim MonView = New DataView(Me.DG_Liste_Interventions.DataSource, "StatutPaiement = 'Payé'", "StatutPaiement Desc", DataViewRowState.CurrentRows)
        Me.DG_Liste_Interventions_payees.DataSource = MonView
        Me.DG_Liste_Interventions_payees.Columns("NomF").HeaderText = "Formation"
        Me.DG_Liste_Interventions_payees.Columns("TypeIntervention").HeaderText = "Type d'intervention"
        Me.DG_Liste_Interventions_payees.Columns("Date").HeaderText = "Date"
        Me.DG_Liste_Interventions_payees.Columns("NbHeure").HeaderText = "Nb d'heures"
        Me.DG_Liste_Interventions_payees.Columns("Salle").HeaderText = "Salle"
        Me.DG_Liste_Interventions_payees.Columns("HeureDebut").HeaderText = "Début"
        Me.DG_Liste_Interventions_payees.Columns("HeureFin").HeaderText = "Fin"
        Me.DG_Liste_Interventions_payees.Columns("StatutPaiement").HeaderText = "Paiement"

        For Each col As DataGridViewColumn In Me.DG_Liste_Interventions_payees.Columns
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Paiement" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
                col.Visible = False
            End If
            col.ReadOnly = True
            If col.HeaderText Is "" Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                col.ReadOnly = False
            End If
        Next

    End Sub

    Sub Remplir_DG_Liste_Interventions_nonpayees()
        Dim MonView = New DataView(Me.DG_Liste_Interventions.DataSource, "StatutPaiement = 'Non payé'", "StatutPaiement Desc", DataViewRowState.CurrentRows)
        Me.DG_Liste_Interventions_nonpayees.DataSource = MonView
        Me.DG_Liste_Interventions_nonpayees.Columns("NomF").HeaderText = "Formation"
        Me.DG_Liste_Interventions_nonpayees.Columns("TypeIntervention").HeaderText = "Type d'intervention"
        Me.DG_Liste_Interventions_nonpayees.Columns("Date").HeaderText = "Date"
        Me.DG_Liste_Interventions_nonpayees.Columns("NbHeure").HeaderText = "Nb d'heures"
        Me.DG_Liste_Interventions_nonpayees.Columns("Salle").HeaderText = "Salle"
        Me.DG_Liste_Interventions_nonpayees.Columns("HeureDebut").HeaderText = "Début"
        Me.DG_Liste_Interventions_nonpayees.Columns("HeureFin").HeaderText = "Fin"
        Me.DG_Liste_Interventions_nonpayees.Columns("StatutPaiement").HeaderText = "Paiement"

        For Each col As DataGridViewColumn In Me.DG_Liste_Interventions_nonpayees.Columns
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Paiement" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
                col.Visible = False
            End If
            col.ReadOnly = True
            If col.HeaderText Is "" Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                col.ReadOnly = False
            End If
        Next

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

    Sub Remplir_Onglet_Information(ByVal DG As DataGridView, ByVal index As Integer)
        Dim id As String = DG.Rows(index).Cells("idPersonne").Value

        Me.CB_I_Civilite.Text = DG.Rows(index).Cells("CiviliteP").Value
        Me.TB_I_Nom.Text = DG.Rows(index).Cells("NomP").Value
        Me.TB_I_Prenom.Text = DG.Rows(index).Cells("PrenomP").Value
        Me.RTB_I_Adresse.Text = DG.Rows(index).Cells("AdresseP").Value & ", " & DG.Rows(index).Cells("CP").Value & " " & DG.Rows(index).Cells("VilleP").Value
        Me.TB_I_Pays.Text = DG.Rows(index).Cells("PaysP").Value
        Me.TB_I_Telephone.Text = DG.Rows(index).Cells("NumTelP").Value
        Me.LinkLabel_Mail_Intervenant.Text = DG.Rows(index).Cells("MailP").Value

        Me.DTP_I_DateN.Value = DG.Rows(index).Cells("DateNaissanceI").Value
        Me.TB_I_LieuN.Text = DG.Rows(index).Cells("LieuNaissanceI").Value
        Me.TB_I_PaysN.Text = DG.Rows(index).Cells("PaysNaissanceI").Value
        Me.TB_I_NumSS.Text = DG.Rows(index).Cells("NumSSI").Value

        Me.CB_I_TypeIntervenant.Text = DG.Rows(index).Cells("TypeIntervenant").Value

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
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur)
        Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Remplir_DG_Liste_Interventions_nonpayees()
        Remplir_DG_Liste_Interventions_payees()

        Remplir_Onglet_Information(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Intervenants_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Intervenants.RowHeaderMouseClick
        Init_champs_Information()
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur)
        Me.DG_Liste_Interventions.DataSource = intervenant_select.interventions

        Remplir_DG_Liste_Interventions_nonpayees()
        Remplir_DG_Liste_Interventions_payees()

        Remplir_Onglet_Information(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub BT_Nouvel_Intervenant_Click(sender As Object, e As EventArgs) Handles BT_Nouvel_Intervenant.Click
        Dim Nouv As New NouvelIntervenant(bdd, idSession)
        Nouv.Show()
    End Sub

    Private Sub BT_Supprimer_intervenant_Click(sender As Object, e As EventArgs) Handles BT_Supprimer_intervenant.Click
        Dim id As String
        For Each Ligne As DataGridViewRow In Me.DG_Liste_Intervenants.Rows
            If Ligne.Cells.Item(0).Value = True Then
                id = Ligne.Cells.Item(1).Value
                SupprimeIntervenant(id)
            End If
        Next
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
        For Each Ligne As DataGridViewRow In Me.DG_Liste_Intervenants.Rows
            If Ligne.Cells.Item(0).Value = True Then
                Ligne.ReadOnly = False
                MsgBox("coché")
            End If
        Next
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

        ' Ajout et redimensionnement des cases à cocher
        Dim TB As New DataGridViewCheckBoxColumn
        Me.DG_Liste_Stagiaires.Columns.Add(TB)
        TB.DisplayIndex = 1
        TB.Width = 21

        Me.LBL_Stagiaire_NB_Enregistrement.Text = nb - 1 & " enregistrement(s)"
    End Sub

    Private Sub BT_Nouveau_Stagiaire_Click(sender As Object, e As EventArgs) Handles BT_Nouveau_Stagiaire.Click
        Dim Nouv As New NouveauStagiaire(bdd, idSession)
        Nouv.Show()
    End Sub

    Private Sub BT_Refresh_Click(sender As Object, e As EventArgs) Handles BT_Refresh.Click
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation)
        o_Stagiaire = New Onglet_stagiaire(bdd, SF)
        Remplir_DG_Liste_Stagiaires()
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
        Me.Dispose()
        PageConnexion.Show()
    End Sub


    Private Sub TV_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Menu.AfterSelect
        'Si le noeud sélectionné est une session de formation
        If Me.TV_Menu.SelectedNode.Level = 2 Then
            NomFormation = Me.TV_Menu.SelectedNode.Parent.Text
            SessionFormation = Me.TV_Menu.SelectedNode.Text
            GenereIDs(NomFormation, SessionFormation)
            MAJ_infos()
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
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation)

        o_Planning = New Onglet_planning(bdd, SF)
        o_Intervenant = New Onglet_intervenant(bdd, SF)
        o_Stagiaire = New Onglet_stagiaire(bdd, SF)

        Me.RTB_I_Formation.Text = NomFormation

        Me.TB_I_Session.Text = SessionFormation

        Me.TB_I_NB_Intervenants.Text = o_Intervenant.Intervenants.Rows.Count

        Me.TB_I_NB_Stagiaires.Text = o_Stagiaire.Stagiaires.Rows.Count


        MAJ_planning()
        Remplir_DG_Liste_Intervenants()
        Remplir_DG_Liste_Interventions()
        Remplir_DG_Liste_Stagiaires()
    End Sub

    Private Sub BT_FichePerso_Click(sender As Object, e As EventArgs)
        FichePersoIntervenant.Show()
    End Sub

    Private Sub CréerUnUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnUtilisateurToolStripMenuItem.Click
        Dim aj As New Ajout_Utilisateur(bdd)
        aj.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereDossierEngagement()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereFicheServicefait()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim index As Integer = Me.DG_Liste_Intervenants.CurrentRow.Index
        If index >= 0 Then
            intervenant_select.GenereConvocationIntervenant()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DG_Liste_Interventions_payees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Si les modifications sont activées
        If Me.DG_Liste_Interventions_payees.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2 Then
            For Each Ligne As DataGridViewRow In Me.DG_Liste_Interventions_payees.Rows
                If Ligne.Cells.Item(0).OwningColumn.Name Is "_" And Ligne.Cells.Item(0).Value = True Then
                    Ligne.Cells.Item(14).Value = "Non payé"
                    'Me.DG_Liste_Interventions_payees.Rows.IndexOf(Ligne) = 1
                    'Ligne.Index += 1
                End If
            Next
        End If
    End Sub

    Private Sub BT_Export_DG_ListeIntervenants_Click(sender As Object, e As EventArgs) Handles BT_Export_DG_ListeIntervenants.Click
        ExportExcel("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\test.xls", Me.DG_Liste_Intervenants)
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each Ligne As DataGridViewRow In Me.DG_Liste_Interventions.Rows
            If Ligne.Cells.Item(0).OwningColumn.Name Is "_" And Ligne.Cells.Item(0).Value = True Then
                Me.DG_Liste_Interventions.Rows.Remove(Ligne)
            End If
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation)
        For Each Ligne As DataGridViewRow In Me.DG_Liste_Interventions.Rows
            o_Intervenant.MAJ_Interventions(SF, Ligne, "Non payé")
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim nb As Integer = Me.DG_Liste_Stagiaires.RowCount 'Nombre de stagiaires
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        Dim oTable As Word.Table

        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\Docs à éditer\STAGIAIRES\Test\fiche Emargement.doc")
        'Rendre le document visible
        oWord.Visible = True

        oDoc.Bookmarks.Item("Date").Range.Text = DateTime.Now.Date.ToString("d")
        oDoc.Bookmarks.Item("Formation").Range.Text = NomFormation

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("Tableau").Range, nb - 1, 6)
        oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle

        For ligne = 1 To nb - 1
            oTable.Cell(ligne, 1).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne).Cells.Item(1).Value
            oTable.Cell(ligne, 2).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne).Cells.Item(2).Value
            oTable.Cell(ligne, 3).Range.Text = Me.DG_Liste_Stagiaires.Rows.Item(ligne).Cells.Item(3).Value
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

End Class