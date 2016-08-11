Imports System.Data.SqlClient
'Imports Calendar
Imports WindowsFormsCalendar
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Formation
    Private bdd As BD
    Private MonDataSet As New DataSet
    Private NomFormation As String
    Private SessionFormation As String
    Private TableSF As DataTable 'Table contenant la liste des intervenants

    Private utilisateur As Utilisateur
    Private o_Intervenant As Onglet_intervenant
    Private o_Stagiaire As Onglet_stagiaire
    Private o_Planning As Onglet_planning
    Private intervenant_select As Intervenant

    'Private m_apps As New List(Of Appointment)


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
        MAJ_planning()
    End Sub

    Sub CreerUtilisateur()
        Dim Requete As String = "select*from Personnel where Login='" & bdd.username & "'"
        Dim cmd As New SqlCommand(Requete, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                utilisateur = New Utilisateur(MonReader("Login").ToString, MonReader("Password").ToString, MonReader("Fonction").ToString, MonReader("Mail").ToString)
            End If
            cmd.Dispose()
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

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
        Me.DG_Liste_Intervenants.Columns("CiviliteP").HeaderText = "Civ"

        For Each col As DataGridViewColumn In Me.DG_Liste_Intervenants.Columns
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Nom" And col.HeaderText IsNot "Prénom" And col.HeaderText IsNot "Civ" Then
                col.Visible = False
            End If
            col.ReadOnly = True
            If col.HeaderText Is "" Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
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
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Paiement" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Salle" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
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
            If col.HeaderText IsNot "" And col.HeaderText IsNot "Paiement" And col.HeaderText IsNot "Type d'intervention" And col.HeaderText IsNot "Date" And col.HeaderText IsNot "Nb d'heures" And col.HeaderText IsNot "Salle" And col.HeaderText IsNot "Début" And col.HeaderText IsNot "Fin" Then
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
        Remplir_Onglet_Information(Me.DG_Liste_Intervenants, Me.DG_Liste_Intervenants.CurrentRow.Index)
    End Sub

    Private Sub DG_Liste_Intervenants_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Liste_Intervenants.RowHeaderMouseClick
        Init_champs_Information()
        intervenant_select = New Intervenant(bdd, o_Intervenant.Intervenants, o_Intervenant.Interventions, o_Intervenant.DonneesEntreprises, Me.DG_Liste_Intervenants.CurrentRow.Index, SessionFormation, NomFormation, utilisateur)
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

        ' Ajout et redimensionnement des cases à cocher
        Dim TB As New DataGridViewCheckBoxColumn
        Me.DG_Liste_Stagiaires.Columns.Add(TB)
        TB.DisplayIndex = 1
        TB.Width = 21

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
        Dim it_cal As New CalendarItem(Me.Calendar2, CDate("11/08/2016 09:15:00"), CDate("11/08/2016 10:00:00"), "Mon RDV")
        Calendar2.Items.Add(it_cal)
        MsgBox(CDate("11/08/2016 09:15:00"))
    End Sub

    ''' <summary>
    ''' Lorsque l'utilisateur sélectionne une date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonCalendrier.DateChanged
        'MonDayView.StartDate = MonCalendrier.SelectionStart
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
            MAJ_infos()
        ElseIf Me.TV_Menu.SelectedNode.Level = 1 Then 'Si le noeud sélectionné est une formation
            NomFormation = Me.TV_Menu.SelectedNode.Text
        End If
    End Sub

    Private Sub MAJ_infos()
        Dim SF As New SessionFormation(bdd, NomFormation, SessionFormation)

        o_Planning = New Onglet_planning(bdd, SF)
        o_Intervenant = New Onglet_intervenant(bdd, SF)
        o_Stagiaire = New Onglet_stagiaire(bdd, SF)
        'o_Intervenant = Inter
        'o_Stagiaire = Stagiaire

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
        Dim MonAdaptateur As New SqlDataAdapter()
        'Dim MonDataSet As New DataSet
        'MonAdaptateur.Fill(MonDataSet)
        MonAdaptateur.Update(o_Intervenant.Interventions)
    End Sub

    Private Sub Calendar2_LoadItems(sender As Object, e As System.Windows.Forms.Calendar.CalendarLoadEventArgs)
        Dim it_cal As New CalendarItem(Me.Calendar2, CDate("11/08/2016 09:15:00"), CDate("11/08/2016 10:00:00"), "Mon RDV")
        Calendar2.Items.Add(it_cal)
        MsgBox(CDate("11/08/2016 09:15:00"))
    End Sub
End Class