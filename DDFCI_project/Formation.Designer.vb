﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleFormationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervenantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StagiaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableauDesVacationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerUnUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierUtilisateurToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerUtilisateurToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TV_Menu = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Calendar1 = New WindowsFormsCalendar.Calendar()
        Me.MonCalendrier = New System.Windows.Forms.MonthCalendar()
        Me.TabIntervenants = New System.Windows.Forms.TabPage()
        Me.Panel_Intervenants_details = New System.Windows.Forms.Panel()
        Me.BT_Actualiser_Intervenants = New System.Windows.Forms.Button()
        Me.BN_Intervenants = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProfilsintervenantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BN_Intervenants_DeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NouveauToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OuvrirToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Enregistrer_Intervenants = New System.Windows.Forms.ToolStripButton()
        Me.ImprimerToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CopierToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CollerToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FillBy_liste_intervenantsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdSToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_DG_Intervenants = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_liste_intervenantsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NouveauToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OuvrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EnregistrerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopierToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CollerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy_interventions_NPToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomFormationToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_NomFormation_NP = New System.Windows.Forms.ToolStripTextBox()
        Me.SessionToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Session_NP = New System.Windows.Forms.ToolStripTextBox()
        Me.NomToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Nom_NP = New System.Windows.Forms.ToolStripTextBox()
        Me.PrenomToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Prenom_NP = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_interventions_NPToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BT_Enregistrer_Intervenants = New System.Windows.Forms.Button()
        Me.BT_Nouvel_Intervenant = New System.Windows.Forms.Button()
        Me.BT_Modifier_DG_ListeIntervenants = New System.Windows.Forms.Button()
        Me.BT_Supprimer_intervenant = New System.Windows.Forms.Button()
        Me.BT_Export_DG_ListeIntervenants = New System.Windows.Forms.Button()
        Me.LBL_Intervenant_NB_Enregistrement = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BT_I_Enregistrer = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DTP_I_Anciennete = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.RTB_I_Entreprise = New System.Windows.Forms.RichTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CB_I_TypeIntervenant = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RTB_I_Fonction = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TB_I_NumSS = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_I_PaysN = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TB_I_LieuN = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DTP_I_DateN = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel_Mail_Intervenant = New System.Windows.Forms.LinkLabel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TB_I_Telephone = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TB_I_Pays = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RTB_I_Adresse = New System.Windows.Forms.RichTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_I_Prenom = New System.Windows.Forms.TextBox()
        Me.TB_I_Nom = New System.Windows.Forms.TextBox()
        Me.CB_I_Civilite = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.FillBy_interventionsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomFormationToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_NomFormation = New System.Windows.Forms.ToolStripTextBox()
        Me.SessionToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Session = New System.Windows.Forms.ToolStripTextBox()
        Me.NomToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Nom = New System.Windows.Forms.ToolStripTextBox()
        Me.PrenomToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Prenom = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_interventionsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ListeinterventionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BN_Interventions_DeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.NouveauToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.OuvrirToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.EnregistrerToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ImprimerToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CopierToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.CollerToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BT_Enregistrer_Interventions = New System.Windows.Forms.Button()
        Me.BT_Supprimer_Intervention = New System.Windows.Forms.Button()
        Me.BT_Ajouter_Intervention = New System.Windows.Forms.Button()
        Me.DG_Liste_Interventions = New System.Windows.Forms.DataGridView()
        Me.NomP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idIntervenant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSeance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSessionFormation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnneeSession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeInterventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureDebutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbHeureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutPaiementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.FillBy_interventions_PToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NomFormationToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_NomFormation1_P = New System.Windows.Forms.ToolStripTextBox()
        Me.SessionToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Session1_P = New System.Windows.Forms.ToolStripTextBox()
        Me.NomToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Nom1_P = New System.Windows.Forms.ToolStripTextBox()
        Me.PrenomToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Prenom1_P = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_interventions_PToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DG_Liste_Interventions_nonpayees = New System.Windows.Forms.DataGridView()
        Me.ListeinterventionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Liste_Interventions_payees = New System.Windows.Forms.DataGridView()
        Me.ListeinterventionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Liste_Intervenants = New System.Windows.Forms.DataGridView()
        Me.idPersonne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilitePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomJeuneFille = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeIntervenantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateNaissanceIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieuNaissanceI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaysNaissanceI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationaliteP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresseP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaysP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumTelP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSSI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel_Stagiaires_détails = New System.Windows.Forms.Panel()
        Me.BT_Refresh_Stagiaires = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BT_Export_stagiaires = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.BT_Modifier_Stagiaires = New System.Windows.Forms.Button()
        Me.BT_Nouveau_Stagiaire = New System.Windows.Forms.Button()
        Me.LBL_Stagiaire_NB_Enregistrement = New System.Windows.Forms.Label()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.DG_Liste_Stagiaires = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TB_Debut_Session = New System.Windows.Forms.TextBox()
        Me.TB_Fin_Session = New System.Windows.Forms.TextBox()
        Me.TB_I_NB_Stagiaires = New System.Windows.Forms.TextBox()
        Me.TB_I_NB_Intervenants = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CB_AF = New System.Windows.Forms.ComboBox()
        Me.CB_CP = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TB_Session = New System.Windows.Forms.TextBox()
        Me.RTB_Formation = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Profils_intervenantTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.profils_intervenantTableAdapter()
        Me.Liste_interventionsTableAdapter = New DDFCI_project.Formation_ContinueDataSet1TableAdapters.liste_interventionsTableAdapter()
        Me.NomPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdIntervenantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSeanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSessionFormationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnneeSessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeInterventionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureDebutDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureFinDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbHeureDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutPaiementDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdIntervenantDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomFDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSeanceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSessionFormationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnneeSessionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeInterventionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureDebutDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureFinDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbHeureDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutPaiementDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabIntervenants.SuspendLayout()
        Me.Panel_Intervenants_details.SuspendLayout()
        CType(Me.BN_Intervenants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_Intervenants.SuspendLayout()
        CType(Me.ProfilsintervenantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy_liste_intervenantsToolStrip.SuspendLayout()
        Me.FillBy_interventions_NPToolStrip.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.FillBy_interventionsToolStrip.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ListeinterventionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Liste_Interventions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.FillBy_interventions_PToolStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DG_Liste_Interventions_nonpayees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeinterventionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Liste_Interventions_payees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeinterventionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Liste_Intervenants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel_Stagiaires_détails.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DG_Liste_Stagiaires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.FormationToolStripMenuItem, Me.UtilisateurToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1253, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormationToolStripMenuItem1, Me.IntervenantToolStripMenuItem, Me.StagiaireToolStripMenuItem})
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'FormationToolStripMenuItem1
        '
        Me.FormationToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleFormationToolStripMenuItem, Me.NouvelleSessionToolStripMenuItem})
        Me.FormationToolStripMenuItem1.Name = "FormationToolStripMenuItem1"
        Me.FormationToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.FormationToolStripMenuItem1.Text = "Formation"
        '
        'NouvelleFormationToolStripMenuItem
        '
        Me.NouvelleFormationToolStripMenuItem.Name = "NouvelleFormationToolStripMenuItem"
        Me.NouvelleFormationToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NouvelleFormationToolStripMenuItem.Text = "Nouvelle formation"
        '
        'NouvelleSessionToolStripMenuItem
        '
        Me.NouvelleSessionToolStripMenuItem.Name = "NouvelleSessionToolStripMenuItem"
        Me.NouvelleSessionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NouvelleSessionToolStripMenuItem.Text = "Nouvelle session"
        '
        'IntervenantToolStripMenuItem
        '
        Me.IntervenantToolStripMenuItem.Name = "IntervenantToolStripMenuItem"
        Me.IntervenantToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.IntervenantToolStripMenuItem.Text = "Intervenant"
        '
        'StagiaireToolStripMenuItem
        '
        Me.StagiaireToolStripMenuItem.Name = "StagiaireToolStripMenuItem"
        Me.StagiaireToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.StagiaireToolStripMenuItem.Text = "Stagiaire"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'FormationToolStripMenuItem
        '
        Me.FormationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableauDesVacationsToolStripMenuItem})
        Me.FormationToolStripMenuItem.Name = "FormationToolStripMenuItem"
        Me.FormationToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.FormationToolStripMenuItem.Text = "Formation"
        '
        'TableauDesVacationsToolStripMenuItem
        '
        Me.TableauDesVacationsToolStripMenuItem.Name = "TableauDesVacationsToolStripMenuItem"
        Me.TableauDesVacationsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.TableauDesVacationsToolStripMenuItem.Text = "Tableau des vacations"
        '
        'UtilisateurToolStripMenuItem
        '
        Me.UtilisateurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréerUnUtilisateurToolStripMenuItem, Me.ModifierUtilisateurToolStripMenu, Me.SupprimerUtilisateurToolStripMenu})
        Me.UtilisateurToolStripMenuItem.Name = "UtilisateurToolStripMenuItem"
        Me.UtilisateurToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UtilisateurToolStripMenuItem.Text = "Utilisateur"
        '
        'CréerUnUtilisateurToolStripMenuItem
        '
        Me.CréerUnUtilisateurToolStripMenuItem.Name = "CréerUnUtilisateurToolStripMenuItem"
        Me.CréerUnUtilisateurToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CréerUnUtilisateurToolStripMenuItem.Text = "Créer un utilisateur"
        '
        'ModifierUtilisateurToolStripMenu
        '
        Me.ModifierUtilisateurToolStripMenu.Name = "ModifierUtilisateurToolStripMenu"
        Me.ModifierUtilisateurToolStripMenu.Size = New System.Drawing.Size(215, 22)
        Me.ModifierUtilisateurToolStripMenu.Text = "Modifier mes informations"
        '
        'SupprimerUtilisateurToolStripMenu
        '
        Me.SupprimerUtilisateurToolStripMenu.Name = "SupprimerUtilisateurToolStripMenu"
        Me.SupprimerUtilisateurToolStripMenu.Size = New System.Drawing.Size(215, 22)
        Me.SupprimerUtilisateurToolStripMenu.Text = "Supprimer un utilisateur"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1253, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TV_Menu
        '
        Me.TV_Menu.Location = New System.Drawing.Point(21, 52)
        Me.TV_Menu.Name = "TV_Menu"
        Me.TV_Menu.Size = New System.Drawing.Size(191, 437)
        Me.TV_Menu.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabIntervenants)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(255, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 855)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Calendar1)
        Me.TabPage2.Controls.Add(Me.MonCalendrier)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(990, 829)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Planning"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Calendar1
        '
        Me.Calendar1.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour
        Me.Calendar1.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Calendar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Calendar1.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue
        Me.Calendar1.ItemsFont = Nothing
        Me.Calendar1.ItemsForeColor = System.Drawing.Color.Black
        Me.Calendar1.Location = New System.Drawing.Point(111, 208)
        Me.Calendar1.MaximumViewDays = 700
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Calendar1.Scrollbars = WindowsFormsCalendar.CalendarScrollBars.Vertical
        Me.Calendar1.Size = New System.Drawing.Size(800, 600)
        Me.Calendar1.TabIndex = 1
        Me.Calendar1.Text = "Calendar1"
        Me.Calendar1.TimeScale = WindowsFormsCalendar.CalendarTimeScale.FifteenMinutes
        '
        'MonCalendrier
        '
        Me.MonCalendrier.Location = New System.Drawing.Point(403, 12)
        Me.MonCalendrier.Name = "MonCalendrier"
        Me.MonCalendrier.TabIndex = 0
        '
        'TabIntervenants
        '
        Me.TabIntervenants.AutoScroll = True
        Me.TabIntervenants.BackColor = System.Drawing.SystemColors.Control
        Me.TabIntervenants.Controls.Add(Me.Panel_Intervenants_details)
        Me.TabIntervenants.Location = New System.Drawing.Point(4, 22)
        Me.TabIntervenants.Name = "TabIntervenants"
        Me.TabIntervenants.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIntervenants.Size = New System.Drawing.Size(990, 829)
        Me.TabIntervenants.TabIndex = 2
        Me.TabIntervenants.Text = "Intervenants"
        '
        'Panel_Intervenants_details
        '
        Me.Panel_Intervenants_details.Controls.Add(Me.BT_Actualiser_Intervenants)
        Me.Panel_Intervenants_details.Controls.Add(Me.BN_Intervenants)
        Me.Panel_Intervenants_details.Controls.Add(Me.FillBy_liste_intervenantsToolStrip)
        Me.Panel_Intervenants_details.Controls.Add(Me.GroupBox6)
        Me.Panel_Intervenants_details.Controls.Add(Me.LBL_Intervenant_NB_Enregistrement)
        Me.Panel_Intervenants_details.Controls.Add(Me.ToolStrip2)
        Me.Panel_Intervenants_details.Controls.Add(Me.ToolStrip4)
        Me.Panel_Intervenants_details.Controls.Add(Me.TabControl2)
        Me.Panel_Intervenants_details.Controls.Add(Me.DG_Liste_Intervenants)
        Me.Panel_Intervenants_details.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Intervenants_details.Name = "Panel_Intervenants_details"
        Me.Panel_Intervenants_details.Size = New System.Drawing.Size(985, 820)
        Me.Panel_Intervenants_details.TabIndex = 1
        '
        'BT_Actualiser_Intervenants
        '
        Me.BT_Actualiser_Intervenants.Location = New System.Drawing.Point(855, 279)
        Me.BT_Actualiser_Intervenants.Name = "BT_Actualiser_Intervenants"
        Me.BT_Actualiser_Intervenants.Size = New System.Drawing.Size(75, 23)
        Me.BT_Actualiser_Intervenants.TabIndex = 12
        Me.BT_Actualiser_Intervenants.Text = "Actualiser"
        Me.BT_Actualiser_Intervenants.UseVisualStyleBackColor = True
        '
        'BN_Intervenants
        '
        Me.BN_Intervenants.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BN_Intervenants.BindingSource = Me.ProfilsintervenantBindingSource
        Me.BN_Intervenants.CountItem = Me.BindingNavigatorCountItem
        Me.BN_Intervenants.DeleteItem = Me.BN_Intervenants_DeleteItem
        Me.BN_Intervenants.Dock = System.Windows.Forms.DockStyle.None
        Me.BN_Intervenants.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BN_Intervenants_DeleteItem, Me.NouveauToolStripButton1, Me.OuvrirToolStripButton1, Me.Enregistrer_Intervenants, Me.ImprimerToolStripButton1, Me.toolStripSeparator2, Me.CouperToolStripButton1, Me.CopierToolStripButton1, Me.CollerToolStripButton1, Me.toolStripSeparator3, Me.ToolStripButton1})
        Me.BN_Intervenants.Location = New System.Drawing.Point(532, 28)
        Me.BN_Intervenants.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BN_Intervenants.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BN_Intervenants.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BN_Intervenants.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BN_Intervenants.Name = "BN_Intervenants"
        Me.BN_Intervenants.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_Intervenants.Size = New System.Drawing.Size(453, 25)
        Me.BN_Intervenants.TabIndex = 11
        Me.BN_Intervenants.Text = "BindingNavigator1"
        Me.BN_Intervenants.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'ProfilsintervenantBindingSource
        '
        Me.ProfilsintervenantBindingSource.DataMember = "profils_intervenant"
        Me.ProfilsintervenantBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BN_Intervenants_DeleteItem
        '
        Me.BN_Intervenants_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BN_Intervenants_DeleteItem.Image = CType(resources.GetObject("BN_Intervenants_DeleteItem.Image"), System.Drawing.Image)
        Me.BN_Intervenants_DeleteItem.Name = "BN_Intervenants_DeleteItem"
        Me.BN_Intervenants_DeleteItem.RightToLeftAutoMirrorImage = True
        Me.BN_Intervenants_DeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BN_Intervenants_DeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NouveauToolStripButton1
        '
        Me.NouveauToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NouveauToolStripButton1.Image = CType(resources.GetObject("NouveauToolStripButton1.Image"), System.Drawing.Image)
        Me.NouveauToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripButton1.Name = "NouveauToolStripButton1"
        Me.NouveauToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.NouveauToolStripButton1.Text = "&Nouveau"
        '
        'OuvrirToolStripButton1
        '
        Me.OuvrirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OuvrirToolStripButton1.Image = CType(resources.GetObject("OuvrirToolStripButton1.Image"), System.Drawing.Image)
        Me.OuvrirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripButton1.Name = "OuvrirToolStripButton1"
        Me.OuvrirToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.OuvrirToolStripButton1.Text = "&Ouvrir"
        '
        'Enregistrer_Intervenants
        '
        Me.Enregistrer_Intervenants.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Enregistrer_Intervenants.Image = CType(resources.GetObject("Enregistrer_Intervenants.Image"), System.Drawing.Image)
        Me.Enregistrer_Intervenants.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Enregistrer_Intervenants.Name = "Enregistrer_Intervenants"
        Me.Enregistrer_Intervenants.Size = New System.Drawing.Size(23, 22)
        Me.Enregistrer_Intervenants.Text = "&Enregistrer"
        '
        'ImprimerToolStripButton1
        '
        Me.ImprimerToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimerToolStripButton1.Image = CType(resources.GetObject("ImprimerToolStripButton1.Image"), System.Drawing.Image)
        Me.ImprimerToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripButton1.Name = "ImprimerToolStripButton1"
        Me.ImprimerToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ImprimerToolStripButton1.Text = "&Imprimer"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CouperToolStripButton1
        '
        Me.CouperToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CouperToolStripButton1.Image = CType(resources.GetObject("CouperToolStripButton1.Image"), System.Drawing.Image)
        Me.CouperToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CouperToolStripButton1.Name = "CouperToolStripButton1"
        Me.CouperToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.CouperToolStripButton1.Text = "C&ouper"
        '
        'CopierToolStripButton1
        '
        Me.CopierToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopierToolStripButton1.Image = CType(resources.GetObject("CopierToolStripButton1.Image"), System.Drawing.Image)
        Me.CopierToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopierToolStripButton1.Name = "CopierToolStripButton1"
        Me.CopierToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.CopierToolStripButton1.Text = "Co&pier"
        '
        'CollerToolStripButton1
        '
        Me.CollerToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollerToolStripButton1.Image = CType(resources.GetObject("CollerToolStripButton1.Image"), System.Drawing.Image)
        Me.CollerToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CollerToolStripButton1.Name = "CollerToolStripButton1"
        Me.CollerToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.CollerToolStripButton1.Text = "Co&ller"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "&?"
        '
        'FillBy_liste_intervenantsToolStrip
        '
        Me.FillBy_liste_intervenantsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_liste_intervenantsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdSToolStripLabel, Me.Param_DG_Intervenants, Me.FillBy_liste_intervenantsToolStripButton, Me.NouveauToolStripButton, Me.OuvrirToolStripButton, Me.EnregistrerToolStripButton, Me.ImprimerToolStripButton, Me.toolStripSeparator, Me.CouperToolStripButton, Me.CopierToolStripButton, Me.CollerToolStripButton, Me.toolStripSeparator1, Me.ToolStripButton})
        Me.FillBy_liste_intervenantsToolStrip.Location = New System.Drawing.Point(17, 25)
        Me.FillBy_liste_intervenantsToolStrip.Name = "FillBy_liste_intervenantsToolStrip"
        Me.FillBy_liste_intervenantsToolStrip.Size = New System.Drawing.Size(471, 25)
        Me.FillBy_liste_intervenantsToolStrip.TabIndex = 5
        Me.FillBy_liste_intervenantsToolStrip.Text = "FillBy_liste_intervenantsToolStrip"
        Me.FillBy_liste_intervenantsToolStrip.Visible = False
        '
        'IdSToolStripLabel
        '
        Me.IdSToolStripLabel.Name = "IdSToolStripLabel"
        Me.IdSToolStripLabel.Size = New System.Drawing.Size(26, 22)
        Me.IdSToolStripLabel.Text = "idS:"
        '
        'Param_DG_Intervenants
        '
        Me.Param_DG_Intervenants.Name = "Param_DG_Intervenants"
        Me.Param_DG_Intervenants.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_liste_intervenantsToolStripButton
        '
        Me.FillBy_liste_intervenantsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_liste_intervenantsToolStripButton.Name = "FillBy_liste_intervenantsToolStripButton"
        Me.FillBy_liste_intervenantsToolStripButton.Size = New System.Drawing.Size(135, 22)
        Me.FillBy_liste_intervenantsToolStripButton.Text = "FillBy_liste_intervenants"
        '
        'NouveauToolStripButton
        '
        Me.NouveauToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NouveauToolStripButton.Image = CType(resources.GetObject("NouveauToolStripButton.Image"), System.Drawing.Image)
        Me.NouveauToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripButton.Name = "NouveauToolStripButton"
        Me.NouveauToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NouveauToolStripButton.Text = "&Nouveau"
        '
        'OuvrirToolStripButton
        '
        Me.OuvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OuvrirToolStripButton.Image = CType(resources.GetObject("OuvrirToolStripButton.Image"), System.Drawing.Image)
        Me.OuvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripButton.Name = "OuvrirToolStripButton"
        Me.OuvrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OuvrirToolStripButton.Text = "&Ouvrir"
        '
        'EnregistrerToolStripButton
        '
        Me.EnregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnregistrerToolStripButton.Image = CType(resources.GetObject("EnregistrerToolStripButton.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripButton.Name = "EnregistrerToolStripButton"
        Me.EnregistrerToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EnregistrerToolStripButton.Text = "&Enregistrer"
        '
        'ImprimerToolStripButton
        '
        Me.ImprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimerToolStripButton.Image = CType(resources.GetObject("ImprimerToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripButton.Name = "ImprimerToolStripButton"
        Me.ImprimerToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimerToolStripButton.Text = "&Imprimer"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CouperToolStripButton
        '
        Me.CouperToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CouperToolStripButton.Image = CType(resources.GetObject("CouperToolStripButton.Image"), System.Drawing.Image)
        Me.CouperToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CouperToolStripButton.Name = "CouperToolStripButton"
        Me.CouperToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CouperToolStripButton.Text = "C&ouper"
        '
        'CopierToolStripButton
        '
        Me.CopierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopierToolStripButton.Image = CType(resources.GetObject("CopierToolStripButton.Image"), System.Drawing.Image)
        Me.CopierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopierToolStripButton.Name = "CopierToolStripButton"
        Me.CopierToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopierToolStripButton.Text = "Co&pier"
        '
        'CollerToolStripButton
        '
        Me.CollerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollerToolStripButton.Image = CType(resources.GetObject("CollerToolStripButton.Image"), System.Drawing.Image)
        Me.CollerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CollerToolStripButton.Name = "CollerToolStripButton"
        Me.CollerToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CollerToolStripButton.Text = "Co&ller"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton
        '
        Me.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton.Image = CType(resources.GetObject("ToolStripButton.Image"), System.Drawing.Image)
        Me.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton.Name = "ToolStripButton"
        Me.ToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton.Text = "&?"
        '
        'FillBy_interventions_NPToolStrip
        '
        Me.FillBy_interventions_NPToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_interventions_NPToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomFormationToolStripLabel1, Me.Param_NomFormation_NP, Me.SessionToolStripLabel1, Me.Param_Session_NP, Me.NomToolStripLabel, Me.Param_Nom_NP, Me.PrenomToolStripLabel, Me.Param_Prenom_NP, Me.FillBy_interventions_NPToolStripButton})
        Me.FillBy_interventions_NPToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy_interventions_NPToolStrip.Name = "FillBy_interventions_NPToolStrip"
        Me.FillBy_interventions_NPToolStrip.Size = New System.Drawing.Size(713, 25)
        Me.FillBy_interventions_NPToolStrip.TabIndex = 5
        Me.FillBy_interventions_NPToolStrip.Text = "FillBy_interventions_NPToolStrip"
        '
        'NomFormationToolStripLabel1
        '
        Me.NomFormationToolStripLabel1.Name = "NomFormationToolStripLabel1"
        Me.NomFormationToolStripLabel1.Size = New System.Drawing.Size(92, 22)
        Me.NomFormationToolStripLabel1.Text = "NomFormation:"
        '
        'Param_NomFormation_NP
        '
        Me.Param_NomFormation_NP.Name = "Param_NomFormation_NP"
        Me.Param_NomFormation_NP.Size = New System.Drawing.Size(100, 25)
        '
        'SessionToolStripLabel1
        '
        Me.SessionToolStripLabel1.Name = "SessionToolStripLabel1"
        Me.SessionToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.SessionToolStripLabel1.Text = "Session:"
        '
        'Param_Session_NP
        '
        Me.Param_Session_NP.Name = "Param_Session_NP"
        Me.Param_Session_NP.Size = New System.Drawing.Size(100, 25)
        '
        'NomToolStripLabel
        '
        Me.NomToolStripLabel.Name = "NomToolStripLabel"
        Me.NomToolStripLabel.Size = New System.Drawing.Size(37, 22)
        Me.NomToolStripLabel.Text = "Nom:"
        '
        'Param_Nom_NP
        '
        Me.Param_Nom_NP.Name = "Param_Nom_NP"
        Me.Param_Nom_NP.Size = New System.Drawing.Size(100, 25)
        '
        'PrenomToolStripLabel
        '
        Me.PrenomToolStripLabel.Name = "PrenomToolStripLabel"
        Me.PrenomToolStripLabel.Size = New System.Drawing.Size(52, 22)
        Me.PrenomToolStripLabel.Text = "Prenom:"
        '
        'Param_Prenom_NP
        '
        Me.Param_Prenom_NP.Name = "Param_Prenom_NP"
        Me.Param_Prenom_NP.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_interventions_NPToolStripButton
        '
        Me.FillBy_interventions_NPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_interventions_NPToolStripButton.Name = "FillBy_interventions_NPToolStripButton"
        Me.FillBy_interventions_NPToolStripButton.Size = New System.Drawing.Size(63, 22)
        Me.FillBy_interventions_NPToolStripButton.Text = "Actualiser"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BT_Enregistrer_Intervenants)
        Me.GroupBox6.Controls.Add(Me.BT_Nouvel_Intervenant)
        Me.GroupBox6.Controls.Add(Me.BT_Modifier_DG_ListeIntervenants)
        Me.GroupBox6.Controls.Add(Me.BT_Supprimer_intervenant)
        Me.GroupBox6.Controls.Add(Me.BT_Export_DG_ListeIntervenants)
        Me.GroupBox6.Location = New System.Drawing.Point(839, 53)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(108, 220)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'BT_Enregistrer_Intervenants
        '
        Me.BT_Enregistrer_Intervenants.Location = New System.Drawing.Point(16, 98)
        Me.BT_Enregistrer_Intervenants.Name = "BT_Enregistrer_Intervenants"
        Me.BT_Enregistrer_Intervenants.Size = New System.Drawing.Size(75, 23)
        Me.BT_Enregistrer_Intervenants.TabIndex = 10
        Me.BT_Enregistrer_Intervenants.Text = "Enregistrer"
        Me.BT_Enregistrer_Intervenants.UseVisualStyleBackColor = True
        '
        'BT_Nouvel_Intervenant
        '
        Me.BT_Nouvel_Intervenant.Location = New System.Drawing.Point(16, 19)
        Me.BT_Nouvel_Intervenant.Name = "BT_Nouvel_Intervenant"
        Me.BT_Nouvel_Intervenant.Size = New System.Drawing.Size(75, 23)
        Me.BT_Nouvel_Intervenant.TabIndex = 7
        Me.BT_Nouvel_Intervenant.Text = "Nouveau"
        Me.BT_Nouvel_Intervenant.UseVisualStyleBackColor = True
        '
        'BT_Modifier_DG_ListeIntervenants
        '
        Me.BT_Modifier_DG_ListeIntervenants.Location = New System.Drawing.Point(16, 57)
        Me.BT_Modifier_DG_ListeIntervenants.Name = "BT_Modifier_DG_ListeIntervenants"
        Me.BT_Modifier_DG_ListeIntervenants.Size = New System.Drawing.Size(75, 23)
        Me.BT_Modifier_DG_ListeIntervenants.TabIndex = 9
        Me.BT_Modifier_DG_ListeIntervenants.Text = "Modifier"
        Me.BT_Modifier_DG_ListeIntervenants.UseVisualStyleBackColor = True
        '
        'BT_Supprimer_intervenant
        '
        Me.BT_Supprimer_intervenant.Location = New System.Drawing.Point(16, 139)
        Me.BT_Supprimer_intervenant.Name = "BT_Supprimer_intervenant"
        Me.BT_Supprimer_intervenant.Size = New System.Drawing.Size(75, 23)
        Me.BT_Supprimer_intervenant.TabIndex = 8
        Me.BT_Supprimer_intervenant.Text = "Supprimer"
        Me.BT_Supprimer_intervenant.UseVisualStyleBackColor = True
        '
        'BT_Export_DG_ListeIntervenants
        '
        Me.BT_Export_DG_ListeIntervenants.Location = New System.Drawing.Point(16, 180)
        Me.BT_Export_DG_ListeIntervenants.Name = "BT_Export_DG_ListeIntervenants"
        Me.BT_Export_DG_ListeIntervenants.Size = New System.Drawing.Size(75, 23)
        Me.BT_Export_DG_ListeIntervenants.TabIndex = 4
        Me.BT_Export_DG_ListeIntervenants.Text = "Exporter"
        Me.BT_Export_DG_ListeIntervenants.UseVisualStyleBackColor = True
        '
        'LBL_Intervenant_NB_Enregistrement
        '
        Me.LBL_Intervenant_NB_Enregistrement.AutoSize = True
        Me.LBL_Intervenant_NB_Enregistrement.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LBL_Intervenant_NB_Enregistrement.Location = New System.Drawing.Point(361, 37)
        Me.LBL_Intervenant_NB_Enregistrement.Name = "LBL_Intervenant_NB_Enregistrement"
        Me.LBL_Intervenant_NB_Enregistrement.Size = New System.Drawing.Size(96, 13)
        Me.LBL_Intervenant_NB_Enregistrement.TabIndex = 3
        Me.LBL_Intervenant_NB_Enregistrement.Text = "0 enregistrement(s)"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip4.TabIndex = 5
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel3.Text = "Liste des intervenant(s)"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Location = New System.Drawing.Point(17, 320)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(825, 494)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Menu
        Me.TabPage3.Controls.Add(Me.BT_I_Enregistrer)
        Me.TabPage3.Controls.Add(Me.GroupBox10)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(817, 468)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Informations"
        '
        'BT_I_Enregistrer
        '
        Me.BT_I_Enregistrer.Location = New System.Drawing.Point(326, 405)
        Me.BT_I_Enregistrer.Name = "BT_I_Enregistrer"
        Me.BT_I_Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.BT_I_Enregistrer.TabIndex = 3
        Me.BT_I_Enregistrer.Text = "Enregistrer"
        Me.BT_I_Enregistrer.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox10.Controls.Add(Me.DTP_I_Anciennete)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.RTB_I_Entreprise)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.CB_I_TypeIntervenant)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.RTB_I_Fonction)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Location = New System.Drawing.Point(517, 99)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(209, 273)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        '
        'DTP_I_Anciennete
        '
        Me.DTP_I_Anciennete.Enabled = False
        Me.DTP_I_Anciennete.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_I_Anciennete.Location = New System.Drawing.Point(47, 238)
        Me.DTP_I_Anciennete.Name = "DTP_I_Anciennete"
        Me.DTP_I_Anciennete.Size = New System.Drawing.Size(126, 20)
        Me.DTP_I_Anciennete.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(76, 221)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 13)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Ancienneté:"
        '
        'RTB_I_Entreprise
        '
        Me.RTB_I_Entreprise.Enabled = False
        Me.RTB_I_Entreprise.Location = New System.Drawing.Point(47, 174)
        Me.RTB_I_Entreprise.Name = "RTB_I_Entreprise"
        Me.RTB_I_Entreprise.Size = New System.Drawing.Size(126, 39)
        Me.RTB_I_Entreprise.TabIndex = 5
        Me.RTB_I_Entreprise.Text = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(82, 152)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Entreprise:"
        '
        'CB_I_TypeIntervenant
        '
        Me.CB_I_TypeIntervenant.Enabled = False
        Me.CB_I_TypeIntervenant.FormattingEnabled = True
        Me.CB_I_TypeIntervenant.Location = New System.Drawing.Point(47, 49)
        Me.CB_I_TypeIntervenant.Name = "CB_I_TypeIntervenant"
        Me.CB_I_TypeIntervenant.Size = New System.Drawing.Size(121, 21)
        Me.CB_I_TypeIntervenant.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(58, 26)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(98, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Type d'intervenant:"
        '
        'RTB_I_Fonction
        '
        Me.RTB_I_Fonction.Enabled = False
        Me.RTB_I_Fonction.Location = New System.Drawing.Point(47, 104)
        Me.RTB_I_Fonction.Name = "RTB_I_Fonction"
        Me.RTB_I_Fonction.Size = New System.Drawing.Size(126, 41)
        Me.RTB_I_Fonction.TabIndex = 1
        Me.RTB_I_Fonction.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(82, 82)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Fonction:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox3.Controls.Add(Me.TB_I_NumSS)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.TB_I_PaysN)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.TB_I_LieuN)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.DTP_I_DateN)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'TB_I_NumSS
        '
        Me.TB_I_NumSS.Enabled = False
        Me.TB_I_NumSS.Location = New System.Drawing.Point(50, 220)
        Me.TB_I_NumSS.Name = "TB_I_NumSS"
        Me.TB_I_NumSS.Size = New System.Drawing.Size(100, 20)
        Me.TB_I_NumSS.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(55, 204)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(79, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Numero de SS:"
        '
        'TB_I_PaysN
        '
        Me.TB_I_PaysN.Enabled = False
        Me.TB_I_PaysN.Location = New System.Drawing.Point(50, 167)
        Me.TB_I_PaysN.Name = "TB_I_PaysN"
        Me.TB_I_PaysN.Size = New System.Drawing.Size(103, 20)
        Me.TB_I_PaysN.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(52, 142)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Pays de naissance:"
        '
        'TB_I_LieuN
        '
        Me.TB_I_LieuN.Enabled = False
        Me.TB_I_LieuN.Location = New System.Drawing.Point(50, 107)
        Me.TB_I_LieuN.Name = "TB_I_LieuN"
        Me.TB_I_LieuN.Size = New System.Drawing.Size(101, 20)
        Me.TB_I_LieuN.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(52, 82)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Lieu de naissance:"
        '
        'DTP_I_DateN
        '
        Me.DTP_I_DateN.Enabled = False
        Me.DTP_I_DateN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_I_DateN.Location = New System.Drawing.Point(50, 48)
        Me.DTP_I_DateN.Name = "DTP_I_DateN"
        Me.DTP_I_DateN.Size = New System.Drawing.Size(101, 20)
        Me.DTP_I_DateN.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(52, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(99, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Date de naissance:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox2.Controls.Add(Me.LinkLabel_Mail_Intervenant)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.TB_I_Telephone)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.TB_I_Pays)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.RTB_I_Adresse)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TB_I_Prenom)
        Me.GroupBox2.Controls.Add(Me.TB_I_Nom)
        Me.GroupBox2.Controls.Add(Me.CB_I_Civilite)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'LinkLabel_Mail_Intervenant
        '
        Me.LinkLabel_Mail_Intervenant.AutoSize = True
        Me.LinkLabel_Mail_Intervenant.Location = New System.Drawing.Point(65, 244)
        Me.LinkLabel_Mail_Intervenant.Name = "LinkLabel_Mail_Intervenant"
        Me.LinkLabel_Mail_Intervenant.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel_Mail_Intervenant.TabIndex = 13
        Me.LinkLabel_Mail_Intervenant.TabStop = True
        Me.LinkLabel_Mail_Intervenant.Text = "LinkLabel1"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 244)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 13)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Mail:"
        '
        'TB_I_Telephone
        '
        Me.TB_I_Telephone.Enabled = False
        Me.TB_I_Telephone.Location = New System.Drawing.Point(68, 213)
        Me.TB_I_Telephone.Name = "TB_I_Telephone"
        Me.TB_I_Telephone.Size = New System.Drawing.Size(115, 20)
        Me.TB_I_Telephone.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 214)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Téléphone:"
        '
        'TB_I_Pays
        '
        Me.TB_I_Pays.Enabled = False
        Me.TB_I_Pays.Location = New System.Drawing.Point(68, 171)
        Me.TB_I_Pays.Name = "TB_I_Pays"
        Me.TB_I_Pays.Size = New System.Drawing.Size(115, 20)
        Me.TB_I_Pays.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 174)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Pays:"
        '
        'RTB_I_Adresse
        '
        Me.RTB_I_Adresse.Enabled = False
        Me.RTB_I_Adresse.Location = New System.Drawing.Point(62, 120)
        Me.RTB_I_Adresse.Name = "RTB_I_Adresse"
        Me.RTB_I_Adresse.Size = New System.Drawing.Size(121, 45)
        Me.RTB_I_Adresse.TabIndex = 7
        Me.RTB_I_Adresse.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Adresse:"
        '
        'TB_I_Prenom
        '
        Me.TB_I_Prenom.Enabled = False
        Me.TB_I_Prenom.Location = New System.Drawing.Point(68, 82)
        Me.TB_I_Prenom.Name = "TB_I_Prenom"
        Me.TB_I_Prenom.Size = New System.Drawing.Size(115, 20)
        Me.TB_I_Prenom.TabIndex = 5
        '
        'TB_I_Nom
        '
        Me.TB_I_Nom.Enabled = False
        Me.TB_I_Nom.Location = New System.Drawing.Point(68, 52)
        Me.TB_I_Nom.Name = "TB_I_Nom"
        Me.TB_I_Nom.Size = New System.Drawing.Size(115, 20)
        Me.TB_I_Nom.TabIndex = 4
        '
        'CB_I_Civilite
        '
        Me.CB_I_Civilite.Enabled = False
        Me.CB_I_Civilite.FormattingEnabled = True
        Me.CB_I_Civilite.Items.AddRange(New Object() {"Mlle.", "Mme.", "Mr."})
        Me.CB_I_Civilite.Location = New System.Drawing.Point(68, 23)
        Me.CB_I_Civilite.Name = "CB_I_Civilite"
        Me.CB_I_Civilite.Size = New System.Drawing.Size(115, 21)
        Me.CB_I_Civilite.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Civilité:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Prénom:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nom:"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage7.Controls.Add(Me.GroupBox1)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(817, 468)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Documents"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(240, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intervenants"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(174, 182)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Générer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(174, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Générer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(174, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Générer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Convocation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Service fait:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dossier d'engagement:"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage8.Controls.Add(Me.FillBy_interventionsToolStrip)
        Me.TabPage8.Controls.Add(Me.BindingNavigator1)
        Me.TabPage8.Controls.Add(Me.BT_Enregistrer_Interventions)
        Me.TabPage8.Controls.Add(Me.BT_Supprimer_Intervention)
        Me.TabPage8.Controls.Add(Me.BT_Ajouter_Intervention)
        Me.TabPage8.Controls.Add(Me.DG_Liste_Interventions)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(817, 468)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "Interventions(s)"
        '
        'FillBy_interventionsToolStrip
        '
        Me.FillBy_interventionsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomFormationToolStripLabel, Me.Param_NomFormation, Me.SessionToolStripLabel, Me.Param_Session, Me.NomToolStripLabel3, Me.Param_Nom, Me.PrenomToolStripLabel3, Me.Param_Prenom, Me.FillBy_interventionsToolStripButton})
        Me.FillBy_interventionsToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.FillBy_interventionsToolStrip.Name = "FillBy_interventionsToolStrip"
        Me.FillBy_interventionsToolStrip.Size = New System.Drawing.Size(811, 25)
        Me.FillBy_interventionsToolStrip.TabIndex = 5
        Me.FillBy_interventionsToolStrip.Text = "FillBy_interventionsToolStrip"
        '
        'NomFormationToolStripLabel
        '
        Me.NomFormationToolStripLabel.Name = "NomFormationToolStripLabel"
        Me.NomFormationToolStripLabel.Size = New System.Drawing.Size(92, 22)
        Me.NomFormationToolStripLabel.Text = "NomFormation:"
        '
        'Param_NomFormation
        '
        Me.Param_NomFormation.Name = "Param_NomFormation"
        Me.Param_NomFormation.Size = New System.Drawing.Size(100, 25)
        '
        'SessionToolStripLabel
        '
        Me.SessionToolStripLabel.Name = "SessionToolStripLabel"
        Me.SessionToolStripLabel.Size = New System.Drawing.Size(49, 22)
        Me.SessionToolStripLabel.Text = "Session:"
        '
        'Param_Session
        '
        Me.Param_Session.Name = "Param_Session"
        Me.Param_Session.Size = New System.Drawing.Size(100, 25)
        '
        'NomToolStripLabel3
        '
        Me.NomToolStripLabel3.Name = "NomToolStripLabel3"
        Me.NomToolStripLabel3.Size = New System.Drawing.Size(37, 22)
        Me.NomToolStripLabel3.Text = "Nom:"
        '
        'Param_Nom
        '
        Me.Param_Nom.Name = "Param_Nom"
        Me.Param_Nom.Size = New System.Drawing.Size(100, 25)
        '
        'PrenomToolStripLabel3
        '
        Me.PrenomToolStripLabel3.Name = "PrenomToolStripLabel3"
        Me.PrenomToolStripLabel3.Size = New System.Drawing.Size(52, 22)
        Me.PrenomToolStripLabel3.Text = "Prenom:"
        '
        'Param_Prenom
        '
        Me.Param_Prenom.Name = "Param_Prenom"
        Me.Param_Prenom.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_interventionsToolStripButton
        '
        Me.FillBy_interventionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_interventionsToolStripButton.Name = "FillBy_interventionsToolStripButton"
        Me.FillBy_interventionsToolStripButton.Size = New System.Drawing.Size(63, 22)
        Me.FillBy_interventionsToolStripButton.Text = "Actualiser"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.ListeinterventionsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BN_Interventions_DeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BN_Interventions_DeleteItem, Me.NouveauToolStripButton2, Me.OuvrirToolStripButton2, Me.EnregistrerToolStripButton1, Me.ImprimerToolStripButton2, Me.toolStripSeparator4, Me.CouperToolStripButton2, Me.CopierToolStripButton2, Me.CollerToolStripButton2, Me.toolStripSeparator5, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(330, 33)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(453, 25)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Ajouter nouveau"
        '
        'ListeinterventionsBindingSource
        '
        Me.ListeinterventionsBindingSource.DataMember = "liste_interventions"
        Me.ListeinterventionsBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Nombre total d'éléments"
        '
        'BN_Interventions_DeleteItem
        '
        Me.BN_Interventions_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BN_Interventions_DeleteItem.Image = CType(resources.GetObject("BN_Interventions_DeleteItem.Image"), System.Drawing.Image)
        Me.BN_Interventions_DeleteItem.Name = "BN_Interventions_DeleteItem"
        Me.BN_Interventions_DeleteItem.RightToLeftAutoMirrorImage = True
        Me.BN_Interventions_DeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BN_Interventions_DeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'NouveauToolStripButton2
        '
        Me.NouveauToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NouveauToolStripButton2.Image = CType(resources.GetObject("NouveauToolStripButton2.Image"), System.Drawing.Image)
        Me.NouveauToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NouveauToolStripButton2.Name = "NouveauToolStripButton2"
        Me.NouveauToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.NouveauToolStripButton2.Text = "&Nouveau"
        '
        'OuvrirToolStripButton2
        '
        Me.OuvrirToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OuvrirToolStripButton2.Image = CType(resources.GetObject("OuvrirToolStripButton2.Image"), System.Drawing.Image)
        Me.OuvrirToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OuvrirToolStripButton2.Name = "OuvrirToolStripButton2"
        Me.OuvrirToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.OuvrirToolStripButton2.Text = "&Ouvrir"
        '
        'EnregistrerToolStripButton1
        '
        Me.EnregistrerToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnregistrerToolStripButton1.Image = CType(resources.GetObject("EnregistrerToolStripButton1.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripButton1.Name = "EnregistrerToolStripButton1"
        Me.EnregistrerToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.EnregistrerToolStripButton1.Text = "&Enregistrer"
        '
        'ImprimerToolStripButton2
        '
        Me.ImprimerToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimerToolStripButton2.Image = CType(resources.GetObject("ImprimerToolStripButton2.Image"), System.Drawing.Image)
        Me.ImprimerToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimerToolStripButton2.Name = "ImprimerToolStripButton2"
        Me.ImprimerToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ImprimerToolStripButton2.Text = "&Imprimer"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'CouperToolStripButton2
        '
        Me.CouperToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CouperToolStripButton2.Image = CType(resources.GetObject("CouperToolStripButton2.Image"), System.Drawing.Image)
        Me.CouperToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CouperToolStripButton2.Name = "CouperToolStripButton2"
        Me.CouperToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.CouperToolStripButton2.Text = "C&ouper"
        '
        'CopierToolStripButton2
        '
        Me.CopierToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopierToolStripButton2.Image = CType(resources.GetObject("CopierToolStripButton2.Image"), System.Drawing.Image)
        Me.CopierToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopierToolStripButton2.Name = "CopierToolStripButton2"
        Me.CopierToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.CopierToolStripButton2.Text = "Co&pier"
        '
        'CollerToolStripButton2
        '
        Me.CollerToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollerToolStripButton2.Image = CType(resources.GetObject("CollerToolStripButton2.Image"), System.Drawing.Image)
        Me.CollerToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CollerToolStripButton2.Name = "CollerToolStripButton2"
        Me.CollerToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.CollerToolStripButton2.Text = "Co&ller"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "&?"
        '
        'BT_Enregistrer_Interventions
        '
        Me.BT_Enregistrer_Interventions.Location = New System.Drawing.Point(315, 383)
        Me.BT_Enregistrer_Interventions.Name = "BT_Enregistrer_Interventions"
        Me.BT_Enregistrer_Interventions.Size = New System.Drawing.Size(75, 23)
        Me.BT_Enregistrer_Interventions.TabIndex = 7
        Me.BT_Enregistrer_Interventions.Text = "Enregistrer"
        Me.BT_Enregistrer_Interventions.UseVisualStyleBackColor = True
        '
        'BT_Supprimer_Intervention
        '
        Me.BT_Supprimer_Intervention.Location = New System.Drawing.Point(417, 383)
        Me.BT_Supprimer_Intervention.Name = "BT_Supprimer_Intervention"
        Me.BT_Supprimer_Intervention.Size = New System.Drawing.Size(75, 23)
        Me.BT_Supprimer_Intervention.TabIndex = 2
        Me.BT_Supprimer_Intervention.Text = "Supprimer"
        Me.BT_Supprimer_Intervention.UseVisualStyleBackColor = True
        '
        'BT_Ajouter_Intervention
        '
        Me.BT_Ajouter_Intervention.Location = New System.Drawing.Point(207, 383)
        Me.BT_Ajouter_Intervention.Name = "BT_Ajouter_Intervention"
        Me.BT_Ajouter_Intervention.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ajouter_Intervention.TabIndex = 1
        Me.BT_Ajouter_Intervention.Text = "Ajouter"
        Me.BT_Ajouter_Intervention.UseVisualStyleBackColor = True
        '
        'DG_Liste_Interventions
        '
        Me.DG_Liste_Interventions.AutoGenerateColumns = False
        Me.DG_Liste_Interventions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Interventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Interventions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomP, Me.PrenomP, Me.idIntervenant, Me.NomF, Me.idSeance, Me.idSessionFormation, Me.AnneeSession, Me.TypeInterventionDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.HeureDebutDataGridViewTextBoxColumn, Me.HeureFinDataGridViewTextBoxColumn, Me.NbHeureDataGridViewTextBoxColumn, Me.Salle, Me.StatutPaiementDataGridViewTextBoxColumn})
        Me.DG_Liste_Interventions.DataSource = Me.ListeinterventionsBindingSource
        Me.DG_Liste_Interventions.Location = New System.Drawing.Point(86, 61)
        Me.DG_Liste_Interventions.Name = "DG_Liste_Interventions"
        Me.DG_Liste_Interventions.RowHeadersWidth = 31
        Me.DG_Liste_Interventions.Size = New System.Drawing.Size(593, 303)
        Me.DG_Liste_Interventions.TabIndex = 0
        '
        'NomP
        '
        Me.NomP.DataPropertyName = "NomP"
        Me.NomP.HeaderText = "NomP"
        Me.NomP.Name = "NomP"
        Me.NomP.Visible = False
        '
        'PrenomP
        '
        Me.PrenomP.DataPropertyName = "PrenomP"
        Me.PrenomP.HeaderText = "PrenomP"
        Me.PrenomP.Name = "PrenomP"
        Me.PrenomP.Visible = False
        '
        'idIntervenant
        '
        Me.idIntervenant.DataPropertyName = "idIntervenant"
        Me.idIntervenant.HeaderText = "idIntervenant"
        Me.idIntervenant.Name = "idIntervenant"
        Me.idIntervenant.Visible = False
        '
        'NomF
        '
        Me.NomF.DataPropertyName = "NomF"
        Me.NomF.HeaderText = "NomF"
        Me.NomF.Name = "NomF"
        Me.NomF.Visible = False
        '
        'idSeance
        '
        Me.idSeance.DataPropertyName = "idSeance"
        Me.idSeance.HeaderText = "idSeance"
        Me.idSeance.Name = "idSeance"
        Me.idSeance.Visible = False
        '
        'idSessionFormation
        '
        Me.idSessionFormation.DataPropertyName = "idSessionFormation"
        Me.idSessionFormation.HeaderText = "idSessionFormation"
        Me.idSessionFormation.Name = "idSessionFormation"
        Me.idSessionFormation.Visible = False
        '
        'AnneeSession
        '
        Me.AnneeSession.DataPropertyName = "AnneeSession"
        Me.AnneeSession.HeaderText = "AnneeSession"
        Me.AnneeSession.Name = "AnneeSession"
        Me.AnneeSession.Visible = False
        '
        'TypeInterventionDataGridViewTextBoxColumn
        '
        Me.TypeInterventionDataGridViewTextBoxColumn.DataPropertyName = "TypeIntervention"
        Me.TypeInterventionDataGridViewTextBoxColumn.HeaderText = "Type d'intervention"
        Me.TypeInterventionDataGridViewTextBoxColumn.Name = "TypeInterventionDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'HeureDebutDataGridViewTextBoxColumn
        '
        Me.HeureDebutDataGridViewTextBoxColumn.DataPropertyName = "HeureDebut"
        Me.HeureDebutDataGridViewTextBoxColumn.HeaderText = "Début"
        Me.HeureDebutDataGridViewTextBoxColumn.Name = "HeureDebutDataGridViewTextBoxColumn"
        '
        'HeureFinDataGridViewTextBoxColumn
        '
        Me.HeureFinDataGridViewTextBoxColumn.DataPropertyName = "HeureFin"
        Me.HeureFinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.HeureFinDataGridViewTextBoxColumn.Name = "HeureFinDataGridViewTextBoxColumn"
        '
        'NbHeureDataGridViewTextBoxColumn
        '
        Me.NbHeureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NbHeureDataGridViewTextBoxColumn.DataPropertyName = "NbHeure"
        Me.NbHeureDataGridViewTextBoxColumn.HeaderText = "Nb d'heure"
        Me.NbHeureDataGridViewTextBoxColumn.Name = "NbHeureDataGridViewTextBoxColumn"
        Me.NbHeureDataGridViewTextBoxColumn.Width = 78
        '
        'Salle
        '
        Me.Salle.DataPropertyName = "Salle"
        Me.Salle.HeaderText = "Salle"
        Me.Salle.Name = "Salle"
        Me.Salle.Visible = False
        '
        'StatutPaiementDataGridViewTextBoxColumn
        '
        Me.StatutPaiementDataGridViewTextBoxColumn.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn.HeaderText = "Paiement"
        Me.StatutPaiementDataGridViewTextBoxColumn.Name = "StatutPaiementDataGridViewTextBoxColumn"
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage9.Controls.Add(Me.FillBy_interventions_PToolStrip1)
        Me.TabPage9.Controls.Add(Me.GroupBox8)
        Me.TabPage9.Controls.Add(Me.DG_Liste_Interventions_nonpayees)
        Me.TabPage9.Controls.Add(Me.FillBy_interventions_NPToolStrip)
        Me.TabPage9.Controls.Add(Me.DG_Liste_Interventions_payees)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(817, 468)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "Paiement(s)"
        '
        'FillBy_interventions_PToolStrip1
        '
        Me.FillBy_interventions_PToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_interventions_PToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomFormationToolStripLabel3, Me.Param_NomFormation1_P, Me.SessionToolStripLabel3, Me.Param_Session1_P, Me.NomToolStripLabel2, Me.Param_Nom1_P, Me.PrenomToolStripLabel2, Me.Param_Prenom1_P, Me.FillBy_interventions_PToolStripButton1})
        Me.FillBy_interventions_PToolStrip1.Location = New System.Drawing.Point(3, 240)
        Me.FillBy_interventions_PToolStrip1.Name = "FillBy_interventions_PToolStrip1"
        Me.FillBy_interventions_PToolStrip1.Size = New System.Drawing.Size(713, 25)
        Me.FillBy_interventions_PToolStrip1.TabIndex = 5
        Me.FillBy_interventions_PToolStrip1.Text = "FillBy_interventions_PToolStrip1"
        '
        'NomFormationToolStripLabel3
        '
        Me.NomFormationToolStripLabel3.Name = "NomFormationToolStripLabel3"
        Me.NomFormationToolStripLabel3.Size = New System.Drawing.Size(92, 22)
        Me.NomFormationToolStripLabel3.Text = "NomFormation:"
        '
        'Param_NomFormation1_P
        '
        Me.Param_NomFormation1_P.Name = "Param_NomFormation1_P"
        Me.Param_NomFormation1_P.Size = New System.Drawing.Size(100, 25)
        '
        'SessionToolStripLabel3
        '
        Me.SessionToolStripLabel3.Name = "SessionToolStripLabel3"
        Me.SessionToolStripLabel3.Size = New System.Drawing.Size(49, 22)
        Me.SessionToolStripLabel3.Text = "Session:"
        '
        'Param_Session1_P
        '
        Me.Param_Session1_P.Name = "Param_Session1_P"
        Me.Param_Session1_P.Size = New System.Drawing.Size(100, 25)
        '
        'NomToolStripLabel2
        '
        Me.NomToolStripLabel2.Name = "NomToolStripLabel2"
        Me.NomToolStripLabel2.Size = New System.Drawing.Size(37, 22)
        Me.NomToolStripLabel2.Text = "Nom:"
        '
        'Param_Nom1_P
        '
        Me.Param_Nom1_P.Name = "Param_Nom1_P"
        Me.Param_Nom1_P.Size = New System.Drawing.Size(100, 25)
        '
        'PrenomToolStripLabel2
        '
        Me.PrenomToolStripLabel2.Name = "PrenomToolStripLabel2"
        Me.PrenomToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.PrenomToolStripLabel2.Text = "Prenom:"
        '
        'Param_Prenom1_P
        '
        Me.Param_Prenom1_P.Name = "Param_Prenom1_P"
        Me.Param_Prenom1_P.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_interventions_PToolStripButton1
        '
        Me.FillBy_interventions_PToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_interventions_PToolStripButton1.Name = "FillBy_interventions_PToolStripButton1"
        Me.FillBy_interventions_PToolStripButton1.Size = New System.Drawing.Size(63, 22)
        Me.FillBy_interventions_PToolStripButton1.Text = "Actualiser"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button9)
        Me.GroupBox8.Controls.Add(Me.Button2)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Location = New System.Drawing.Point(632, 70)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(107, 132)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(16, 22)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Enregistrer"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Payé"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DG_Liste_Interventions_nonpayees
        '
        Me.DG_Liste_Interventions_nonpayees.AutoGenerateColumns = False
        Me.DG_Liste_Interventions_nonpayees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Interventions_nonpayees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Interventions_nonpayees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomPDataGridViewTextBoxColumn1, Me.PrenomPDataGridViewTextBoxColumn1, Me.IdIntervenantDataGridViewTextBoxColumn, Me.NomFDataGridViewTextBoxColumn, Me.IdSeanceDataGridViewTextBoxColumn, Me.IdSessionFormationDataGridViewTextBoxColumn, Me.AnneeSessionDataGridViewTextBoxColumn, Me.TypeInterventionDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1, Me.HeureDebutDataGridViewTextBoxColumn1, Me.HeureFinDataGridViewTextBoxColumn1, Me.NbHeureDataGridViewTextBoxColumn1, Me.SalleDataGridViewTextBoxColumn, Me.StatutPaiementDataGridViewTextBoxColumn1})
        Me.DG_Liste_Interventions_nonpayees.DataSource = Me.ListeinterventionsBindingSource1
        Me.DG_Liste_Interventions_nonpayees.Location = New System.Drawing.Point(59, 28)
        Me.DG_Liste_Interventions_nonpayees.Name = "DG_Liste_Interventions_nonpayees"
        Me.DG_Liste_Interventions_nonpayees.RowHeadersWidth = 31
        Me.DG_Liste_Interventions_nonpayees.Size = New System.Drawing.Size(547, 203)
        Me.DG_Liste_Interventions_nonpayees.TabIndex = 1
        '
        'ListeinterventionsBindingSource1
        '
        Me.ListeinterventionsBindingSource1.DataMember = "liste_interventions"
        Me.ListeinterventionsBindingSource1.DataSource = Me.Formation_ContinueDataSet1
        '
        'DG_Liste_Interventions_payees
        '
        Me.DG_Liste_Interventions_payees.AutoGenerateColumns = False
        Me.DG_Liste_Interventions_payees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Interventions_payees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Interventions_payees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomPDataGridViewTextBoxColumn2, Me.PrenomPDataGridViewTextBoxColumn2, Me.IdIntervenantDataGridViewTextBoxColumn1, Me.NomFDataGridViewTextBoxColumn1, Me.IdSeanceDataGridViewTextBoxColumn1, Me.IdSessionFormationDataGridViewTextBoxColumn1, Me.AnneeSessionDataGridViewTextBoxColumn1, Me.TypeInterventionDataGridViewTextBoxColumn2, Me.DateDataGridViewTextBoxColumn2, Me.HeureDebutDataGridViewTextBoxColumn2, Me.HeureFinDataGridViewTextBoxColumn2, Me.NbHeureDataGridViewTextBoxColumn2, Me.SalleDataGridViewTextBoxColumn1, Me.StatutPaiementDataGridViewTextBoxColumn2})
        Me.DG_Liste_Interventions_payees.DataSource = Me.ListeinterventionsBindingSource2
        Me.DG_Liste_Interventions_payees.Location = New System.Drawing.Point(59, 268)
        Me.DG_Liste_Interventions_payees.Name = "DG_Liste_Interventions_payees"
        Me.DG_Liste_Interventions_payees.RowHeadersWidth = 31
        Me.DG_Liste_Interventions_payees.Size = New System.Drawing.Size(547, 194)
        Me.DG_Liste_Interventions_payees.TabIndex = 0
        '
        'ListeinterventionsBindingSource2
        '
        Me.ListeinterventionsBindingSource2.DataMember = "liste_interventions"
        Me.ListeinterventionsBindingSource2.DataSource = Me.Formation_ContinueDataSet1
        '
        'DG_Liste_Intervenants
        '
        Me.DG_Liste_Intervenants.AutoGenerateColumns = False
        Me.DG_Liste_Intervenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Intervenants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPersonne, Me.CivilitePDataGridViewTextBoxColumn, Me.NomPDataGridViewTextBoxColumn, Me.NomJeuneFille, Me.PrenomPDataGridViewTextBoxColumn, Me.TypeIntervenantDataGridViewTextBoxColumn, Me.DateNaissanceIDataGridViewTextBoxColumn, Me.LieuNaissanceI, Me.PaysNaissanceI, Me.NationaliteP, Me.AdresseP, Me.CP, Me.VilleP, Me.PaysP, Me.NumTelP, Me.MailP, Me.NumSSI})
        Me.DG_Liste_Intervenants.DataSource = Me.ProfilsintervenantBindingSource
        Me.DG_Liste_Intervenants.Location = New System.Drawing.Point(46, 53)
        Me.DG_Liste_Intervenants.Name = "DG_Liste_Intervenants"
        Me.DG_Liste_Intervenants.ReadOnly = True
        Me.DG_Liste_Intervenants.RowHeadersWidth = 31
        Me.DG_Liste_Intervenants.Size = New System.Drawing.Size(760, 261)
        Me.DG_Liste_Intervenants.TabIndex = 1
        '
        'idPersonne
        '
        Me.idPersonne.DataPropertyName = "idPersonne"
        Me.idPersonne.HeaderText = "idPersonne"
        Me.idPersonne.Name = "idPersonne"
        Me.idPersonne.ReadOnly = True
        Me.idPersonne.Visible = False
        '
        'CivilitePDataGridViewTextBoxColumn
        '
        Me.CivilitePDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CivilitePDataGridViewTextBoxColumn.DataPropertyName = "CiviliteP"
        Me.CivilitePDataGridViewTextBoxColumn.HeaderText = "Civilité"
        Me.CivilitePDataGridViewTextBoxColumn.Name = "CivilitePDataGridViewTextBoxColumn"
        Me.CivilitePDataGridViewTextBoxColumn.ReadOnly = True
        Me.CivilitePDataGridViewTextBoxColumn.Width = 62
        '
        'NomPDataGridViewTextBoxColumn
        '
        Me.NomPDataGridViewTextBoxColumn.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomPDataGridViewTextBoxColumn.Name = "NomPDataGridViewTextBoxColumn"
        Me.NomPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomJeuneFille
        '
        Me.NomJeuneFille.DataPropertyName = "NomJeuneFille"
        Me.NomJeuneFille.HeaderText = "NomJeuneFille"
        Me.NomJeuneFille.Name = "NomJeuneFille"
        Me.NomJeuneFille.ReadOnly = True
        Me.NomJeuneFille.Visible = False
        '
        'PrenomPDataGridViewTextBoxColumn
        '
        Me.PrenomPDataGridViewTextBoxColumn.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.PrenomPDataGridViewTextBoxColumn.Name = "PrenomPDataGridViewTextBoxColumn"
        Me.PrenomPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeIntervenantDataGridViewTextBoxColumn
        '
        Me.TypeIntervenantDataGridViewTextBoxColumn.DataPropertyName = "TypeIntervenant"
        Me.TypeIntervenantDataGridViewTextBoxColumn.HeaderText = "Type d'intervenant"
        Me.TypeIntervenantDataGridViewTextBoxColumn.Name = "TypeIntervenantDataGridViewTextBoxColumn"
        Me.TypeIntervenantDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateNaissanceIDataGridViewTextBoxColumn
        '
        Me.DateNaissanceIDataGridViewTextBoxColumn.DataPropertyName = "DateNaissanceI"
        Me.DateNaissanceIDataGridViewTextBoxColumn.HeaderText = "Date de naissance"
        Me.DateNaissanceIDataGridViewTextBoxColumn.Name = "DateNaissanceIDataGridViewTextBoxColumn"
        Me.DateNaissanceIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LieuNaissanceI
        '
        Me.LieuNaissanceI.DataPropertyName = "LieuNaissanceI"
        Me.LieuNaissanceI.HeaderText = "LieuNaissanceI"
        Me.LieuNaissanceI.Name = "LieuNaissanceI"
        Me.LieuNaissanceI.ReadOnly = True
        Me.LieuNaissanceI.Visible = False
        '
        'PaysNaissanceI
        '
        Me.PaysNaissanceI.DataPropertyName = "PaysNaissanceI"
        Me.PaysNaissanceI.HeaderText = "PaysNaissanceI"
        Me.PaysNaissanceI.Name = "PaysNaissanceI"
        Me.PaysNaissanceI.ReadOnly = True
        Me.PaysNaissanceI.Visible = False
        '
        'NationaliteP
        '
        Me.NationaliteP.DataPropertyName = "NationaliteP"
        Me.NationaliteP.HeaderText = "NationaliteP"
        Me.NationaliteP.Name = "NationaliteP"
        Me.NationaliteP.ReadOnly = True
        Me.NationaliteP.Visible = False
        '
        'AdresseP
        '
        Me.AdresseP.DataPropertyName = "AdresseP"
        Me.AdresseP.HeaderText = "AdresseP"
        Me.AdresseP.Name = "AdresseP"
        Me.AdresseP.ReadOnly = True
        Me.AdresseP.Visible = False
        '
        'CP
        '
        Me.CP.DataPropertyName = "CP"
        Me.CP.HeaderText = "CP"
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        Me.CP.Visible = False
        '
        'VilleP
        '
        Me.VilleP.DataPropertyName = "VilleP"
        Me.VilleP.HeaderText = "VilleP"
        Me.VilleP.Name = "VilleP"
        Me.VilleP.ReadOnly = True
        Me.VilleP.Visible = False
        '
        'PaysP
        '
        Me.PaysP.DataPropertyName = "PaysP"
        Me.PaysP.HeaderText = "PaysP"
        Me.PaysP.Name = "PaysP"
        Me.PaysP.ReadOnly = True
        '
        'NumTelP
        '
        Me.NumTelP.DataPropertyName = "NumTelP"
        Me.NumTelP.HeaderText = "NumTelP"
        Me.NumTelP.Name = "NumTelP"
        Me.NumTelP.ReadOnly = True
        Me.NumTelP.Visible = False
        '
        'MailP
        '
        Me.MailP.DataPropertyName = "MailP"
        Me.MailP.HeaderText = "MailP"
        Me.MailP.Name = "MailP"
        Me.MailP.ReadOnly = True
        Me.MailP.Visible = False
        '
        'NumSSI
        '
        Me.NumSSI.DataPropertyName = "NumSSI"
        Me.NumSSI.HeaderText = "NumSSI"
        Me.NumSSI.Name = "NumSSI"
        Me.NumSSI.ReadOnly = True
        Me.NumSSI.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.Panel_Stagiaires_détails)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(990, 829)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Stagiaires"
        '
        'Panel_Stagiaires_détails
        '
        Me.Panel_Stagiaires_détails.Controls.Add(Me.BT_Refresh_Stagiaires)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.GroupBox7)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.LBL_Stagiaire_NB_Enregistrement)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.ToolStrip5)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.DG_Liste_Stagiaires)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.ToolStrip3)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.TabControl3)
        Me.Panel_Stagiaires_détails.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Stagiaires_détails.Name = "Panel_Stagiaires_détails"
        Me.Panel_Stagiaires_détails.Size = New System.Drawing.Size(1041, 826)
        Me.Panel_Stagiaires_détails.TabIndex = 1
        '
        'BT_Refresh_Stagiaires
        '
        Me.BT_Refresh_Stagiaires.Location = New System.Drawing.Point(852, 253)
        Me.BT_Refresh_Stagiaires.Name = "BT_Refresh_Stagiaires"
        Me.BT_Refresh_Stagiaires.Size = New System.Drawing.Size(75, 23)
        Me.BT_Refresh_Stagiaires.TabIndex = 7
        Me.BT_Refresh_Stagiaires.Text = "Actualiser"
        Me.BT_Refresh_Stagiaires.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BT_Export_stagiaires)
        Me.GroupBox7.Controls.Add(Me.Button14)
        Me.GroupBox7.Controls.Add(Me.BT_Modifier_Stagiaires)
        Me.GroupBox7.Controls.Add(Me.BT_Nouveau_Stagiaire)
        Me.GroupBox7.Location = New System.Drawing.Point(844, 53)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(89, 178)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        '
        'BT_Export_stagiaires
        '
        Me.BT_Export_stagiaires.Location = New System.Drawing.Point(8, 138)
        Me.BT_Export_stagiaires.Name = "BT_Export_stagiaires"
        Me.BT_Export_stagiaires.Size = New System.Drawing.Size(75, 23)
        Me.BT_Export_stagiaires.TabIndex = 3
        Me.BT_Export_stagiaires.Text = "Exporter"
        Me.BT_Export_stagiaires.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(6, 97)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 2
        Me.Button14.Text = "Supprimer"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'BT_Modifier_Stagiaires
        '
        Me.BT_Modifier_Stagiaires.Location = New System.Drawing.Point(6, 58)
        Me.BT_Modifier_Stagiaires.Name = "BT_Modifier_Stagiaires"
        Me.BT_Modifier_Stagiaires.Size = New System.Drawing.Size(75, 23)
        Me.BT_Modifier_Stagiaires.TabIndex = 1
        Me.BT_Modifier_Stagiaires.Text = "Modifier"
        Me.BT_Modifier_Stagiaires.UseVisualStyleBackColor = True
        '
        'BT_Nouveau_Stagiaire
        '
        Me.BT_Nouveau_Stagiaire.Location = New System.Drawing.Point(6, 19)
        Me.BT_Nouveau_Stagiaire.Name = "BT_Nouveau_Stagiaire"
        Me.BT_Nouveau_Stagiaire.Size = New System.Drawing.Size(75, 23)
        Me.BT_Nouveau_Stagiaire.TabIndex = 0
        Me.BT_Nouveau_Stagiaire.Text = "Nouveau"
        Me.BT_Nouveau_Stagiaire.UseVisualStyleBackColor = True
        '
        'LBL_Stagiaire_NB_Enregistrement
        '
        Me.LBL_Stagiaire_NB_Enregistrement.AutoSize = True
        Me.LBL_Stagiaire_NB_Enregistrement.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LBL_Stagiaire_NB_Enregistrement.Location = New System.Drawing.Point(358, 35)
        Me.LBL_Stagiaire_NB_Enregistrement.Name = "LBL_Stagiaire_NB_Enregistrement"
        Me.LBL_Stagiaire_NB_Enregistrement.Size = New System.Drawing.Size(96, 13)
        Me.LBL_Stagiaire_NB_Enregistrement.TabIndex = 5
        Me.LBL_Stagiaire_NB_Enregistrement.Text = "0 enregistrement(s)"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip5.TabIndex = 4
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'DG_Liste_Stagiaires
        '
        Me.DG_Liste_Stagiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Stagiaires.Location = New System.Drawing.Point(50, 51)
        Me.DG_Liste_Stagiaires.Name = "DG_Liste_Stagiaires"
        Me.DG_Liste_Stagiaires.ReadOnly = True
        Me.DG_Liste_Stagiaires.RowHeadersWidth = 31
        Me.DG_Liste_Stagiaires.Size = New System.Drawing.Size(759, 268)
        Me.DG_Liste_Stagiaires.TabIndex = 3
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripLabel1.Text = "Liste des stagiaire(s)"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage10)
        Me.TabControl3.Controls.Add(Me.TabPage11)
        Me.TabControl3.Location = New System.Drawing.Point(3, 352)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(775, 465)
        Me.TabControl3.TabIndex = 1
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage10.Controls.Add(Me.GroupBox14)
        Me.TabPage10.Controls.Add(Me.GroupBox13)
        Me.TabPage10.Controls.Add(Me.GroupBox12)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(767, 439)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Informations"
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox14.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox14.Controls.Add(Me.Label48)
        Me.GroupBox14.Controls.Add(Me.RichTextBox2)
        Me.GroupBox14.Controls.Add(Me.Label49)
        Me.GroupBox14.Controls.Add(Me.ComboBox2)
        Me.GroupBox14.Controls.Add(Me.Label50)
        Me.GroupBox14.Controls.Add(Me.RichTextBox3)
        Me.GroupBox14.Controls.Add(Me.Label51)
        Me.GroupBox14.Location = New System.Drawing.Point(488, 116)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(209, 273)
        Me.GroupBox14.TabIndex = 3
        Me.GroupBox14.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(47, 238)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(126, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(76, 221)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(64, 13)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "Ancienneté:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Enabled = False
        Me.RichTextBox2.Location = New System.Drawing.Point(47, 174)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(126, 39)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(82, 152)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(57, 13)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Entreprise:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(47, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(58, 26)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(98, 13)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Type d'intervenant:"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Enabled = False
        Me.RichTextBox3.Location = New System.Drawing.Point(47, 104)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(126, 41)
        Me.RichTextBox3.TabIndex = 1
        Me.RichTextBox3.Text = ""
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(82, 82)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(51, 13)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Fonction:"
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox13.Controls.Add(Me.TextBox9)
        Me.GroupBox13.Controls.Add(Me.Label44)
        Me.GroupBox13.Controls.Add(Me.TextBox10)
        Me.GroupBox13.Controls.Add(Me.Label45)
        Me.GroupBox13.Controls.Add(Me.TextBox11)
        Me.GroupBox13.Controls.Add(Me.Label46)
        Me.GroupBox13.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox13.Controls.Add(Me.Label47)
        Me.GroupBox13.Location = New System.Drawing.Point(247, 116)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox13.TabIndex = 2
        Me.GroupBox13.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(50, 220)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 6
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(55, 204)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(79, 13)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Numero de SS:"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(50, 167)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(103, 20)
        Me.TextBox10.TabIndex = 5
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(52, 142)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(99, 13)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Pays de naissance:"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(50, 107)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(101, 20)
        Me.TextBox11.TabIndex = 3
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(52, 82)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 13)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Lieu de naissance:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(50, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(52, 23)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(99, 13)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Date de naissance:"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox12.Controls.Add(Me.LinkLabel1)
        Me.GroupBox12.Controls.Add(Me.Label37)
        Me.GroupBox12.Controls.Add(Me.TextBox1)
        Me.GroupBox12.Controls.Add(Me.Label38)
        Me.GroupBox12.Controls.Add(Me.TextBox6)
        Me.GroupBox12.Controls.Add(Me.Label39)
        Me.GroupBox12.Controls.Add(Me.RichTextBox1)
        Me.GroupBox12.Controls.Add(Me.Label40)
        Me.GroupBox12.Controls.Add(Me.TextBox7)
        Me.GroupBox12.Controls.Add(Me.TextBox8)
        Me.GroupBox12.Controls.Add(Me.ComboBox1)
        Me.GroupBox12.Controls.Add(Me.Label41)
        Me.GroupBox12.Controls.Add(Me.Label42)
        Me.GroupBox12.Controls.Add(Me.Label43)
        Me.GroupBox12.Location = New System.Drawing.Point(27, 116)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(65, 244)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(13, 244)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 13)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Mail:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(68, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 214)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(61, 13)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "Téléphone:"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(68, 171)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(115, 20)
        Me.TextBox6.TabIndex = 9
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(11, 174)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(33, 13)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "Pays:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(62, 120)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(121, 45)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(11, 123)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(48, 13)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Adresse:"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(68, 82)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(115, 20)
        Me.TextBox7.TabIndex = 5
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(68, 52)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(115, 20)
        Me.TextBox8.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mlle.", "Mme.", "Mr."})
        Me.ComboBox1.Location = New System.Drawing.Point(68, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(10, 26)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 13)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Civilité:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(10, 87)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(46, 13)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Prénom:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(10, 55)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(32, 13)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Nom:"
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage11.Controls.Add(Me.Button11)
        Me.TabPage11.Controls.Add(Me.Label36)
        Me.TabPage11.Controls.Add(Me.Button10)
        Me.TabPage11.Controls.Add(Me.Label35)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(767, 439)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "Documents"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(315, 149)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "Générer"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(32, 154)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(105, 13)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Fiche d'emargement:"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(313, 85)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Générer"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(30, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(125, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Convention de formation:"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.MonthCalendar1)
        Me.TabPage5.Controls.Add(Me.DateTimePicker3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(990, 829)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Temps agent"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(100, 151)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2016, 8, 22, 0, 0, 0, 0), New Date(2016, 8, 26, 0, 0, 0, 0))
        Me.MonthCalendar1.TabIndex = 1
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(98, 75)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(990, 829)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Bilan de formation"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TB_Debut_Session
        '
        Me.TB_Debut_Session.Enabled = False
        Me.TB_Debut_Session.Location = New System.Drawing.Point(59, 112)
        Me.TB_Debut_Session.Name = "TB_Debut_Session"
        Me.TB_Debut_Session.Size = New System.Drawing.Size(100, 20)
        Me.TB_Debut_Session.TabIndex = 7
        '
        'TB_Fin_Session
        '
        Me.TB_Fin_Session.Enabled = False
        Me.TB_Fin_Session.Location = New System.Drawing.Point(59, 147)
        Me.TB_Fin_Session.Name = "TB_Fin_Session"
        Me.TB_Fin_Session.Size = New System.Drawing.Size(100, 20)
        Me.TB_Fin_Session.TabIndex = 6
        '
        'TB_I_NB_Stagiaires
        '
        Me.TB_I_NB_Stagiaires.Enabled = False
        Me.TB_I_NB_Stagiaires.Location = New System.Drawing.Point(48, 71)
        Me.TB_I_NB_Stagiaires.Name = "TB_I_NB_Stagiaires"
        Me.TB_I_NB_Stagiaires.Size = New System.Drawing.Size(111, 20)
        Me.TB_I_NB_Stagiaires.TabIndex = 5
        '
        'TB_I_NB_Intervenants
        '
        Me.TB_I_NB_Intervenants.Enabled = False
        Me.TB_I_NB_Intervenants.Location = New System.Drawing.Point(49, 32)
        Me.TB_I_NB_Intervenants.Name = "TB_I_NB_Intervenants"
        Me.TB_I_NB_Intervenants.Size = New System.Drawing.Size(110, 20)
        Me.TB_I_NB_Intervenants.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Nombre de stagiaires:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(46, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Nombre  d'intervenants:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fin:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Début:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CB_AF)
        Me.GroupBox5.Controls.Add(Me.CB_CP)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 785)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(207, 122)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gestion de la formation"
        '
        'CB_AF
        '
        Me.CB_AF.Enabled = False
        Me.CB_AF.FormattingEnabled = True
        Me.CB_AF.Location = New System.Drawing.Point(45, 85)
        Me.CB_AF.Name = "CB_AF"
        Me.CB_AF.Size = New System.Drawing.Size(121, 21)
        Me.CB_AF.TabIndex = 3
        '
        'CB_CP
        '
        Me.CB_CP.Enabled = False
        Me.CB_CP.FormattingEnabled = True
        Me.CB_CP.Location = New System.Drawing.Point(45, 35)
        Me.CB_CP.Name = "CB_CP"
        Me.CB_CP.Size = New System.Drawing.Size(121, 21)
        Me.CB_CP.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Assistant(e) de formation:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Chef(fe) de projet:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TB_Fin_Session)
        Me.GroupBox4.Controls.Add(Me.TB_Debut_Session)
        Me.GroupBox4.Controls.Add(Me.TB_Session)
        Me.GroupBox4.Controls.Add(Me.RTB_Formation)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 495)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 184)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Formation"
        '
        'TB_Session
        '
        Me.TB_Session.Enabled = False
        Me.TB_Session.Location = New System.Drawing.Point(59, 75)
        Me.TB_Session.Name = "TB_Session"
        Me.TB_Session.Size = New System.Drawing.Size(132, 20)
        Me.TB_Session.TabIndex = 3
        '
        'RTB_Formation
        '
        Me.RTB_Formation.Enabled = False
        Me.RTB_Formation.Location = New System.Drawing.Point(59, 19)
        Me.RTB_Formation.Name = "RTB_Formation"
        Me.RTB_Formation.Size = New System.Drawing.Size(132, 50)
        Me.RTB_Formation.TabIndex = 2
        Me.RTB_Formation.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Session:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TB_I_NB_Stagiaires)
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.TB_I_NB_Intervenants)
        Me.GroupBox11.Location = New System.Drawing.Point(13, 679)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(206, 100)
        Me.GroupBox11.TabIndex = 4
        Me.GroupBox11.TabStop = False
        '
        'Profils_intervenantTableAdapter
        '
        Me.Profils_intervenantTableAdapter.ClearBeforeFill = True
        '
        'Liste_interventionsTableAdapter
        '
        Me.Liste_interventionsTableAdapter.ClearBeforeFill = True
        '
        'NomPDataGridViewTextBoxColumn1
        '
        Me.NomPDataGridViewTextBoxColumn1.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn1.HeaderText = "NomP"
        Me.NomPDataGridViewTextBoxColumn1.Name = "NomPDataGridViewTextBoxColumn1"
        Me.NomPDataGridViewTextBoxColumn1.Visible = False
        '
        'PrenomPDataGridViewTextBoxColumn1
        '
        Me.PrenomPDataGridViewTextBoxColumn1.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn1.HeaderText = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn1.Name = "PrenomPDataGridViewTextBoxColumn1"
        Me.PrenomPDataGridViewTextBoxColumn1.Visible = False
        '
        'IdIntervenantDataGridViewTextBoxColumn
        '
        Me.IdIntervenantDataGridViewTextBoxColumn.DataPropertyName = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn.HeaderText = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn.Name = "IdIntervenantDataGridViewTextBoxColumn"
        Me.IdIntervenantDataGridViewTextBoxColumn.Visible = False
        '
        'NomFDataGridViewTextBoxColumn
        '
        Me.NomFDataGridViewTextBoxColumn.DataPropertyName = "NomF"
        Me.NomFDataGridViewTextBoxColumn.HeaderText = "NomF"
        Me.NomFDataGridViewTextBoxColumn.Name = "NomFDataGridViewTextBoxColumn"
        Me.NomFDataGridViewTextBoxColumn.Visible = False
        '
        'IdSeanceDataGridViewTextBoxColumn
        '
        Me.IdSeanceDataGridViewTextBoxColumn.DataPropertyName = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn.HeaderText = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn.Name = "IdSeanceDataGridViewTextBoxColumn"
        Me.IdSeanceDataGridViewTextBoxColumn.Visible = False
        '
        'IdSessionFormationDataGridViewTextBoxColumn
        '
        Me.IdSessionFormationDataGridViewTextBoxColumn.DataPropertyName = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn.HeaderText = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn.Name = "IdSessionFormationDataGridViewTextBoxColumn"
        Me.IdSessionFormationDataGridViewTextBoxColumn.Visible = False
        '
        'AnneeSessionDataGridViewTextBoxColumn
        '
        Me.AnneeSessionDataGridViewTextBoxColumn.DataPropertyName = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn.HeaderText = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn.Name = "AnneeSessionDataGridViewTextBoxColumn"
        Me.AnneeSessionDataGridViewTextBoxColumn.Visible = False
        '
        'TypeInterventionDataGridViewTextBoxColumn1
        '
        Me.TypeInterventionDataGridViewTextBoxColumn1.DataPropertyName = "TypeIntervention"
        Me.TypeInterventionDataGridViewTextBoxColumn1.HeaderText = "TypeIntervention"
        Me.TypeInterventionDataGridViewTextBoxColumn1.Name = "TypeInterventionDataGridViewTextBoxColumn1"
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'HeureDebutDataGridViewTextBoxColumn1
        '
        Me.HeureDebutDataGridViewTextBoxColumn1.DataPropertyName = "HeureDebut"
        Me.HeureDebutDataGridViewTextBoxColumn1.HeaderText = "HeureDebut"
        Me.HeureDebutDataGridViewTextBoxColumn1.Name = "HeureDebutDataGridViewTextBoxColumn1"
        '
        'HeureFinDataGridViewTextBoxColumn1
        '
        Me.HeureFinDataGridViewTextBoxColumn1.DataPropertyName = "HeureFin"
        Me.HeureFinDataGridViewTextBoxColumn1.HeaderText = "HeureFin"
        Me.HeureFinDataGridViewTextBoxColumn1.Name = "HeureFinDataGridViewTextBoxColumn1"
        '
        'NbHeureDataGridViewTextBoxColumn1
        '
        Me.NbHeureDataGridViewTextBoxColumn1.DataPropertyName = "NbHeure"
        Me.NbHeureDataGridViewTextBoxColumn1.HeaderText = "NbHeure"
        Me.NbHeureDataGridViewTextBoxColumn1.Name = "NbHeureDataGridViewTextBoxColumn1"
        '
        'SalleDataGridViewTextBoxColumn
        '
        Me.SalleDataGridViewTextBoxColumn.DataPropertyName = "Salle"
        Me.SalleDataGridViewTextBoxColumn.HeaderText = "Salle"
        Me.SalleDataGridViewTextBoxColumn.Name = "SalleDataGridViewTextBoxColumn"
        Me.SalleDataGridViewTextBoxColumn.Visible = False
        '
        'StatutPaiementDataGridViewTextBoxColumn1
        '
        Me.StatutPaiementDataGridViewTextBoxColumn1.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn1.HeaderText = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn1.Name = "StatutPaiementDataGridViewTextBoxColumn1"
        '
        'NomPDataGridViewTextBoxColumn2
        '
        Me.NomPDataGridViewTextBoxColumn2.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn2.HeaderText = "NomP"
        Me.NomPDataGridViewTextBoxColumn2.Name = "NomPDataGridViewTextBoxColumn2"
        Me.NomPDataGridViewTextBoxColumn2.Visible = False
        '
        'PrenomPDataGridViewTextBoxColumn2
        '
        Me.PrenomPDataGridViewTextBoxColumn2.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn2.HeaderText = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn2.Name = "PrenomPDataGridViewTextBoxColumn2"
        Me.PrenomPDataGridViewTextBoxColumn2.Visible = False
        '
        'IdIntervenantDataGridViewTextBoxColumn1
        '
        Me.IdIntervenantDataGridViewTextBoxColumn1.DataPropertyName = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn1.HeaderText = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn1.Name = "IdIntervenantDataGridViewTextBoxColumn1"
        Me.IdIntervenantDataGridViewTextBoxColumn1.Visible = False
        '
        'NomFDataGridViewTextBoxColumn1
        '
        Me.NomFDataGridViewTextBoxColumn1.DataPropertyName = "NomF"
        Me.NomFDataGridViewTextBoxColumn1.HeaderText = "NomF"
        Me.NomFDataGridViewTextBoxColumn1.Name = "NomFDataGridViewTextBoxColumn1"
        Me.NomFDataGridViewTextBoxColumn1.Visible = False
        '
        'IdSeanceDataGridViewTextBoxColumn1
        '
        Me.IdSeanceDataGridViewTextBoxColumn1.DataPropertyName = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn1.HeaderText = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn1.Name = "IdSeanceDataGridViewTextBoxColumn1"
        Me.IdSeanceDataGridViewTextBoxColumn1.Visible = False
        '
        'IdSessionFormationDataGridViewTextBoxColumn1
        '
        Me.IdSessionFormationDataGridViewTextBoxColumn1.DataPropertyName = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn1.HeaderText = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn1.Name = "IdSessionFormationDataGridViewTextBoxColumn1"
        Me.IdSessionFormationDataGridViewTextBoxColumn1.Visible = False
        '
        'AnneeSessionDataGridViewTextBoxColumn1
        '
        Me.AnneeSessionDataGridViewTextBoxColumn1.DataPropertyName = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn1.HeaderText = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn1.Name = "AnneeSessionDataGridViewTextBoxColumn1"
        Me.AnneeSessionDataGridViewTextBoxColumn1.Visible = False
        '
        'TypeInterventionDataGridViewTextBoxColumn2
        '
        Me.TypeInterventionDataGridViewTextBoxColumn2.DataPropertyName = "TypeIntervention"
        Me.TypeInterventionDataGridViewTextBoxColumn2.HeaderText = "TypeIntervention"
        Me.TypeInterventionDataGridViewTextBoxColumn2.Name = "TypeInterventionDataGridViewTextBoxColumn2"
        '
        'DateDataGridViewTextBoxColumn2
        '
        Me.DateDataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn2.Name = "DateDataGridViewTextBoxColumn2"
        '
        'HeureDebutDataGridViewTextBoxColumn2
        '
        Me.HeureDebutDataGridViewTextBoxColumn2.DataPropertyName = "HeureDebut"
        Me.HeureDebutDataGridViewTextBoxColumn2.HeaderText = "HeureDebut"
        Me.HeureDebutDataGridViewTextBoxColumn2.Name = "HeureDebutDataGridViewTextBoxColumn2"
        '
        'HeureFinDataGridViewTextBoxColumn2
        '
        Me.HeureFinDataGridViewTextBoxColumn2.DataPropertyName = "HeureFin"
        Me.HeureFinDataGridViewTextBoxColumn2.HeaderText = "HeureFin"
        Me.HeureFinDataGridViewTextBoxColumn2.Name = "HeureFinDataGridViewTextBoxColumn2"
        '
        'NbHeureDataGridViewTextBoxColumn2
        '
        Me.NbHeureDataGridViewTextBoxColumn2.DataPropertyName = "NbHeure"
        Me.NbHeureDataGridViewTextBoxColumn2.HeaderText = "NbHeure"
        Me.NbHeureDataGridViewTextBoxColumn2.Name = "NbHeureDataGridViewTextBoxColumn2"
        '
        'SalleDataGridViewTextBoxColumn1
        '
        Me.SalleDataGridViewTextBoxColumn1.DataPropertyName = "Salle"
        Me.SalleDataGridViewTextBoxColumn1.HeaderText = "Salle"
        Me.SalleDataGridViewTextBoxColumn1.Name = "SalleDataGridViewTextBoxColumn1"
        Me.SalleDataGridViewTextBoxColumn1.Visible = False
        '
        'StatutPaiementDataGridViewTextBoxColumn2
        '
        Me.StatutPaiementDataGridViewTextBoxColumn2.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn2.HeaderText = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn2.Name = "StatutPaiementDataGridViewTextBoxColumn2"
        '
        'Formation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 944)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TV_Menu)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDFCI Project"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabIntervenants.ResumeLayout(False)
        Me.Panel_Intervenants_details.ResumeLayout(False)
        Me.Panel_Intervenants_details.PerformLayout()
        CType(Me.BN_Intervenants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_Intervenants.ResumeLayout(False)
        Me.BN_Intervenants.PerformLayout()
        CType(Me.ProfilsintervenantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy_liste_intervenantsToolStrip.ResumeLayout(False)
        Me.FillBy_liste_intervenantsToolStrip.PerformLayout()
        Me.FillBy_interventions_NPToolStrip.ResumeLayout(False)
        Me.FillBy_interventions_NPToolStrip.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.FillBy_interventionsToolStrip.ResumeLayout(False)
        Me.FillBy_interventionsToolStrip.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ListeinterventionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Liste_Interventions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.FillBy_interventions_PToolStrip1.ResumeLayout(False)
        Me.FillBy_interventions_PToolStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DG_Liste_Interventions_nonpayees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListeinterventionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Liste_Interventions_payees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListeinterventionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Liste_Intervenants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel_Stagiaires_détails.ResumeLayout(False)
        Me.Panel_Stagiaires_détails.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DG_Liste_Stagiaires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TV_Menu As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabIntervenants As TabPage
    Friend WithEvents Panel_Intervenants_details As Panel
    Friend WithEvents DG_Liste_Intervenants As DataGridView
    Friend WithEvents LBL_Intervenant_NB_Enregistrement As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents Panel_Stagiaires_détails As Panel
    Friend WithEvents DG_Liste_Stagiaires As DataGridView
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents UtilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerUnUtilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierUtilisateurToolStripMenu As ToolStripMenuItem
    Friend WithEvents SupprimerUtilisateurToolStripMenu As ToolStripMenuItem
    Friend WithEvents DG_Liste_Interventions As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DG_Liste_Interventions_nonpayees As DataGridView
    Friend WithEvents DG_Liste_Interventions_payees As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Session As TextBox
    Friend WithEvents RTB_Formation As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CB_AF As ComboBox
    Friend WithEvents CB_CP As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TB_Debut_Session As TextBox
    Friend WithEvents TB_Fin_Session As TextBox
    Friend WithEvents TB_I_NB_Stagiaires As TextBox
    Friend WithEvents TB_I_NB_Intervenants As TextBox
    Friend WithEvents MonCalendrier As MonthCalendar
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_I_Prenom As TextBox
    Friend WithEvents TB_I_Nom As TextBox
    Friend WithEvents CB_I_Civilite As ComboBox
    Friend WithEvents RTB_I_Adresse As RichTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TB_I_Pays As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TB_I_Telephone As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LinkLabel_Mail_Intervenant As LinkLabel
    Friend WithEvents Label27 As Label
    Friend WithEvents DTP_I_DateN As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents TB_I_PaysN As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TB_I_LieuN As TextBox
    Friend WithEvents TB_I_NumSS As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents RTB_I_Fonction As RichTextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents CB_I_TypeIntervenant As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents RTB_I_Entreprise As RichTextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents DTP_I_Anciennete As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BT_Export_DG_ListeIntervenants As Button
    Friend WithEvents BT_Supprimer_Intervention As Button
    Friend WithEvents BT_Ajouter_Intervention As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Calendar1 As WindowsFormsCalendar.Calendar
    Friend WithEvents Label35 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents BT_Supprimer_intervenant As Button
    Friend WithEvents BT_Nouvel_Intervenant As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BT_Modifier_DG_ListeIntervenants As Button
    Friend WithEvents TableauDesVacationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IntervenantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StagiaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_I_Enregistrer As Button
    Friend WithEvents NouvelleFormationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleSessionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label48 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label47 As Label
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStrip5 As ToolStrip
    Friend WithEvents LBL_Stagiaire_NB_Enregistrement As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BT_Export_stagiaires As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents BT_Modifier_Stagiaires As Button
    Friend WithEvents BT_Nouveau_Stagiaire As Button
    Friend WithEvents BT_Refresh_Stagiaires As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Formation_ContinueDataSet1 As Formation_ContinueDataSet1
    Friend WithEvents ProfilsintervenantBindingSource As BindingSource
    Friend WithEvents Profils_intervenantTableAdapter As Formation_ContinueDataSet1TableAdapters.profils_intervenantTableAdapter
    Friend WithEvents FillBy_liste_intervenantsToolStrip As ToolStrip
    Friend WithEvents IdSToolStripLabel As ToolStripLabel
    Friend WithEvents Param_DG_Intervenants As ToolStripTextBox
    Friend WithEvents FillBy_liste_intervenantsToolStripButton As ToolStripButton
    Friend WithEvents NouveauToolStripButton As ToolStripButton
    Friend WithEvents OuvrirToolStripButton As ToolStripButton
    Friend WithEvents EnregistrerToolStripButton As ToolStripButton
    Friend WithEvents ImprimerToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CouperToolStripButton As ToolStripButton
    Friend WithEvents CopierToolStripButton As ToolStripButton
    Friend WithEvents CollerToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton As ToolStripButton
    Friend WithEvents ListeinterventionsBindingSource As BindingSource
    Friend WithEvents Liste_interventionsTableAdapter As Formation_ContinueDataSet1TableAdapters.liste_interventionsTableAdapter
    Friend WithEvents ListeinterventionsBindingSource1 As BindingSource
    Friend WithEvents FillBy_interventions_NPToolStrip As ToolStrip
    Friend WithEvents NomFormationToolStripLabel1 As ToolStripLabel
    Friend WithEvents Param_NomFormation_NP As ToolStripTextBox
    Friend WithEvents SessionToolStripLabel1 As ToolStripLabel
    Friend WithEvents Param_Session_NP As ToolStripTextBox
    Friend WithEvents NomToolStripLabel As ToolStripLabel
    Friend WithEvents Param_Nom_NP As ToolStripTextBox
    Friend WithEvents PrenomToolStripLabel As ToolStripLabel
    Friend WithEvents Param_Prenom_NP As ToolStripTextBox
    Friend WithEvents FillBy_interventions_NPToolStripButton As ToolStripButton
    Friend WithEvents ListeinterventionsBindingSource2 As BindingSource
    Friend WithEvents FillBy_interventions_PToolStrip As ToolStrip
    Friend WithEvents NomFormationToolStripLabel2 As ToolStripLabel
    Friend WithEvents Param_NomFormation_P As ToolStripTextBox
    Friend WithEvents SessionToolStripLabel2 As ToolStripLabel
    Friend WithEvents Param_Session_P As ToolStripTextBox
    Friend WithEvents NomToolStripLabel1 As ToolStripLabel
    Friend WithEvents Param_Nom_P As ToolStripTextBox
    Friend WithEvents PrenomToolStripLabel1 As ToolStripLabel
    Friend WithEvents Param_Prenom_P As ToolStripTextBox
    Friend WithEvents FillBy_interventions_PToolStripButton As ToolStripButton
    Friend WithEvents ToolStrip6 As ToolStrip
    Friend WithEvents FillBy_interventions_PToolStrip1 As ToolStrip
    Friend WithEvents NomFormationToolStripLabel3 As ToolStripLabel
    Friend WithEvents Param_NomFormation1_P As ToolStripTextBox
    Friend WithEvents SessionToolStripLabel3 As ToolStripLabel
    Friend WithEvents Param_Session1_P As ToolStripTextBox
    Friend WithEvents NomToolStripLabel2 As ToolStripLabel
    Friend WithEvents Param_Nom1_P As ToolStripTextBox
    Friend WithEvents PrenomToolStripLabel2 As ToolStripLabel
    Friend WithEvents Param_Prenom1_P As ToolStripTextBox
    Friend WithEvents FillBy_interventions_PToolStripButton1 As ToolStripButton
    Friend WithEvents BN_Intervenants As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BN_Intervenants_DeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BT_Enregistrer_Intervenants As Button
    Friend WithEvents NouveauToolStripButton1 As ToolStripButton
    Friend WithEvents OuvrirToolStripButton1 As ToolStripButton
    Friend WithEvents Enregistrer_Intervenants As ToolStripButton
    Friend WithEvents ImprimerToolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CouperToolStripButton1 As ToolStripButton
    Friend WithEvents CopierToolStripButton1 As ToolStripButton
    Friend WithEvents CollerToolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BT_Actualiser_Intervenants As Button
    Friend WithEvents BT_Enregistrer_Interventions As Button
    Friend WithEvents idPersonne As DataGridViewTextBoxColumn
    Friend WithEvents CivilitePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomJeuneFille As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeIntervenantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateNaissanceIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LieuNaissanceI As DataGridViewTextBoxColumn
    Friend WithEvents PaysNaissanceI As DataGridViewTextBoxColumn
    Friend WithEvents NationaliteP As DataGridViewTextBoxColumn
    Friend WithEvents AdresseP As DataGridViewTextBoxColumn
    Friend WithEvents CP As DataGridViewTextBoxColumn
    Friend WithEvents VilleP As DataGridViewTextBoxColumn
    Friend WithEvents PaysP As DataGridViewTextBoxColumn
    Friend WithEvents NumTelP As DataGridViewTextBoxColumn
    Friend WithEvents MailP As DataGridViewTextBoxColumn
    Friend WithEvents NumSSI As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BN_Interventions_DeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents NouveauToolStripButton2 As ToolStripButton
    Friend WithEvents OuvrirToolStripButton2 As ToolStripButton
    Friend WithEvents EnregistrerToolStripButton1 As ToolStripButton
    Friend WithEvents ImprimerToolStripButton2 As ToolStripButton
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CouperToolStripButton2 As ToolStripButton
    Friend WithEvents CopierToolStripButton2 As ToolStripButton
    Friend WithEvents CollerToolStripButton2 As ToolStripButton
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents FillBy_interventionsToolStrip As ToolStrip
    Friend WithEvents NomFormationToolStripLabel As ToolStripLabel
    Friend WithEvents Param_NomFormation As ToolStripTextBox
    Friend WithEvents SessionToolStripLabel As ToolStripLabel
    Friend WithEvents Param_Session As ToolStripTextBox
    Friend WithEvents NomToolStripLabel3 As ToolStripLabel
    Friend WithEvents Param_Nom As ToolStripTextBox
    Friend WithEvents PrenomToolStripLabel3 As ToolStripLabel
    Friend WithEvents Param_Prenom As ToolStripTextBox
    Friend WithEvents FillBy_interventionsToolStripButton As ToolStripButton
    Friend WithEvents NomP As DataGridViewTextBoxColumn
    Friend WithEvents PrenomP As DataGridViewTextBoxColumn
    Friend WithEvents idIntervenant As DataGridViewTextBoxColumn
    Friend WithEvents NomF As DataGridViewTextBoxColumn
    Friend WithEvents idSeance As DataGridViewTextBoxColumn
    Friend WithEvents idSessionFormation As DataGridViewTextBoxColumn
    Friend WithEvents AnneeSession As DataGridViewTextBoxColumn
    Friend WithEvents TypeInterventionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeureDebutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeureFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NbHeureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Salle As DataGridViewTextBoxColumn
    Friend WithEvents StatutPaiementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdIntervenantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdSeanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdSessionFormationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnneeSessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeInterventionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HeureDebutDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HeureFinDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NbHeureDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatutPaiementDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NomPDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdIntervenantDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NomFDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdSeanceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdSessionFormationDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AnneeSessionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TypeInterventionDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HeureDebutDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HeureFinDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NbHeureDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SalleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StatutPaiementDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
