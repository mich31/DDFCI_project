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
        Me.CB_I_Convoc = New System.Windows.Forms.ComboBox()
        Me.CB_I_FSF = New System.Windows.Forms.ComboBox()
        Me.CB_I_DSE = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.FillBy_liste_interventionsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomFormationToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_NomFormation = New System.Windows.Forms.ToolStripTextBox()
        Me.SessionToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param_Session = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_liste_interventionsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DG_Liste_Interventions = New System.Windows.Forms.DataGridView()
        Me.TypeInterventionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureDebutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeureFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbHeureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutPaiementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListeinterventionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Formation_ContinueDataSet1 = New DDFCI_project.Formation_ContinueDataSet1()
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
        Me.ListeinterventionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Liste_Interventions_payees = New System.Windows.Forms.DataGridView()
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
        Me.ListeinterventionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Liste_Intervenants = New System.Windows.Forms.DataGridView()
        Me.CivilitePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeIntervenantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateNaissanceIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaysP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilsintervenantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel_Stagiaires_détails = New System.Windows.Forms.Panel()
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
        Me.BT_Refresh = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button15 = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabIntervenants.SuspendLayout()
        Me.Panel_Intervenants_details.SuspendLayout()
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
        Me.FillBy_liste_interventionsToolStrip.SuspendLayout()
        CType(Me.DG_Liste_Interventions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeinterventionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.FillBy_interventions_PToolStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DG_Liste_Interventions_nonpayees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeinterventionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Liste_Interventions_payees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListeinterventionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Liste_Intervenants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilsintervenantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel_Stagiaires_détails.SuspendLayout()
        Me.FillBy_liste_intervenantsToolStrip.SuspendLayout()
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
        Me.Panel_Intervenants_details.Controls.Add(Me.FillBy_interventions_NPToolStrip)
        Me.Panel_Intervenants_details.Controls.Add(Me.GroupBox6)
        Me.Panel_Intervenants_details.Controls.Add(Me.LBL_Intervenant_NB_Enregistrement)
        Me.Panel_Intervenants_details.Controls.Add(Me.ToolStrip2)
        Me.Panel_Intervenants_details.Controls.Add(Me.ToolStrip4)
        Me.Panel_Intervenants_details.Controls.Add(Me.TabControl2)
        Me.Panel_Intervenants_details.Controls.Add(Me.DG_Liste_Intervenants)
        Me.Panel_Intervenants_details.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Intervenants_details.Name = "Panel_Intervenants_details"
        Me.Panel_Intervenants_details.Size = New System.Drawing.Size(984, 820)
        Me.Panel_Intervenants_details.TabIndex = 1
        '
        'FillBy_interventions_NPToolStrip
        '
        Me.FillBy_interventions_NPToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_interventions_NPToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomFormationToolStripLabel1, Me.Param_NomFormation_NP, Me.SessionToolStripLabel1, Me.Param_Session_NP, Me.NomToolStripLabel, Me.Param_Nom_NP, Me.PrenomToolStripLabel, Me.Param_Prenom_NP, Me.FillBy_interventions_NPToolStripButton})
        Me.FillBy_interventions_NPToolStrip.Location = New System.Drawing.Point(17, 354)
        Me.FillBy_interventions_NPToolStrip.Name = "FillBy_interventions_NPToolStrip"
        Me.FillBy_interventions_NPToolStrip.Size = New System.Drawing.Size(784, 25)
        Me.FillBy_interventions_NPToolStrip.TabIndex = 5
        Me.FillBy_interventions_NPToolStrip.Text = "FillBy_interventions_NPToolStrip"
        Me.FillBy_interventions_NPToolStrip.Visible = False
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
        Me.FillBy_interventions_NPToolStripButton.Size = New System.Drawing.Size(134, 22)
        Me.FillBy_interventions_NPToolStripButton.Text = "FillBy_interventions_NP"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BT_Nouvel_Intervenant)
        Me.GroupBox6.Controls.Add(Me.BT_Modifier_DG_ListeIntervenants)
        Me.GroupBox6.Controls.Add(Me.BT_Supprimer_intervenant)
        Me.GroupBox6.Controls.Add(Me.BT_Export_DG_ListeIntervenants)
        Me.GroupBox6.Location = New System.Drawing.Point(839, 53)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(108, 170)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
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
        Me.BT_Supprimer_intervenant.Location = New System.Drawing.Point(16, 95)
        Me.BT_Supprimer_intervenant.Name = "BT_Supprimer_intervenant"
        Me.BT_Supprimer_intervenant.Size = New System.Drawing.Size(75, 23)
        Me.BT_Supprimer_intervenant.TabIndex = 8
        Me.BT_Supprimer_intervenant.Text = "Supprimer"
        Me.BT_Supprimer_intervenant.UseVisualStyleBackColor = True
        '
        'BT_Export_DG_ListeIntervenants
        '
        Me.BT_Export_DG_ListeIntervenants.Location = New System.Drawing.Point(16, 133)
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
        Me.ToolStrip2.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(984, 25)
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
        Me.GroupBox1.Controls.Add(Me.CB_I_Convoc)
        Me.GroupBox1.Controls.Add(Me.CB_I_FSF)
        Me.GroupBox1.Controls.Add(Me.CB_I_DSE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intervenants"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(362, 182)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Générer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(362, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Générer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(362, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Générer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CB_I_Convoc
        '
        Me.CB_I_Convoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_I_Convoc.FormattingEnabled = True
        Me.CB_I_Convoc.Location = New System.Drawing.Point(184, 184)
        Me.CB_I_Convoc.Name = "CB_I_Convoc"
        Me.CB_I_Convoc.Size = New System.Drawing.Size(135, 21)
        Me.CB_I_Convoc.TabIndex = 5
        '
        'CB_I_FSF
        '
        Me.CB_I_FSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_I_FSF.FormattingEnabled = True
        Me.CB_I_FSF.Location = New System.Drawing.Point(184, 120)
        Me.CB_I_FSF.Name = "CB_I_FSF"
        Me.CB_I_FSF.Size = New System.Drawing.Size(135, 21)
        Me.CB_I_FSF.TabIndex = 4
        '
        'CB_I_DSE
        '
        Me.CB_I_DSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_I_DSE.FormattingEnabled = True
        Me.CB_I_DSE.Location = New System.Drawing.Point(184, 61)
        Me.CB_I_DSE.Name = "CB_I_DSE"
        Me.CB_I_DSE.Size = New System.Drawing.Size(135, 21)
        Me.CB_I_DSE.TabIndex = 3
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
        Me.TabPage8.Controls.Add(Me.FillBy_liste_interventionsToolStrip)
        Me.TabPage8.Controls.Add(Me.Button8)
        Me.TabPage8.Controls.Add(Me.Button7)
        Me.TabPage8.Controls.Add(Me.DG_Liste_Interventions)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(817, 468)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "Interventions(s)"
        '
        'FillBy_liste_interventionsToolStrip
        '
        Me.FillBy_liste_interventionsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_liste_interventionsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomFormationToolStripLabel, Me.Param_NomFormation, Me.SessionToolStripLabel, Me.Param_Session, Me.FillBy_liste_interventionsToolStripButton})
        Me.FillBy_liste_interventionsToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.FillBy_liste_interventionsToolStrip.Name = "FillBy_liste_interventionsToolStrip"
        Me.FillBy_liste_interventionsToolStrip.Size = New System.Drawing.Size(496, 25)
        Me.FillBy_liste_interventionsToolStrip.TabIndex = 5
        Me.FillBy_liste_interventionsToolStrip.Text = "FillBy_liste_interventionsToolStrip"
        Me.FillBy_liste_interventionsToolStrip.Visible = False
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
        'FillBy_liste_interventionsToolStripButton
        '
        Me.FillBy_liste_interventionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_liste_interventionsToolStripButton.Name = "FillBy_liste_interventionsToolStripButton"
        Me.FillBy_liste_interventionsToolStripButton.Size = New System.Drawing.Size(139, 22)
        Me.FillBy_liste_interventionsToolStripButton.Text = "FillBy_liste_interventions"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(362, 383)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Supprimer"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(207, 383)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Ajouter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DG_Liste_Interventions
        '
        Me.DG_Liste_Interventions.AutoGenerateColumns = False
        Me.DG_Liste_Interventions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Liste_Interventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Interventions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeInterventionDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.HeureDebutDataGridViewTextBoxColumn, Me.HeureFinDataGridViewTextBoxColumn, Me.NbHeureDataGridViewTextBoxColumn, Me.StatutPaiementDataGridViewTextBoxColumn})
        Me.DG_Liste_Interventions.DataSource = Me.ListeinterventionsBindingSource
        Me.DG_Liste_Interventions.Location = New System.Drawing.Point(86, 61)
        Me.DG_Liste_Interventions.Name = "DG_Liste_Interventions"
        Me.DG_Liste_Interventions.RowHeadersWidth = 31
        Me.DG_Liste_Interventions.Size = New System.Drawing.Size(547, 303)
        Me.DG_Liste_Interventions.TabIndex = 0
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
        Me.HeureDebutDataGridViewTextBoxColumn.HeaderText = "Debut"
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
        'StatutPaiementDataGridViewTextBoxColumn
        '
        Me.StatutPaiementDataGridViewTextBoxColumn.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn.HeaderText = "Paiement"
        Me.StatutPaiementDataGridViewTextBoxColumn.Name = "StatutPaiementDataGridViewTextBoxColumn"
        '
        'ListeinterventionsBindingSource
        '
        Me.ListeinterventionsBindingSource.DataMember = "liste_interventions"
        Me.ListeinterventionsBindingSource.DataSource = Me.Formation_ContinueDataSet1
        '
        'Formation_ContinueDataSet1
        '
        Me.Formation_ContinueDataSet1.DataSetName = "Formation_ContinueDataSet1"
        Me.Formation_ContinueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage9
        '
        Me.TabPage9.AutoScroll = True
        Me.TabPage9.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage9.Controls.Add(Me.FillBy_interventions_PToolStrip1)
        Me.TabPage9.Controls.Add(Me.GroupBox8)
        Me.TabPage9.Controls.Add(Me.DG_Liste_Interventions_nonpayees)
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
        Me.FillBy_interventions_PToolStrip1.Location = New System.Drawing.Point(11, 315)
        Me.FillBy_interventions_PToolStrip1.Name = "FillBy_interventions_PToolStrip1"
        Me.FillBy_interventions_PToolStrip1.Size = New System.Drawing.Size(775, 25)
        Me.FillBy_interventions_PToolStrip1.TabIndex = 5
        Me.FillBy_interventions_PToolStrip1.Text = "FillBy_interventions_PToolStrip1"
        Me.FillBy_interventions_PToolStrip1.Visible = False
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
        Me.FillBy_interventions_PToolStripButton1.Size = New System.Drawing.Size(125, 22)
        Me.FillBy_interventions_PToolStripButton1.Text = "FillBy_interventions_P"
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
        Me.DG_Liste_Interventions_nonpayees.Location = New System.Drawing.Point(59, 12)
        Me.DG_Liste_Interventions_nonpayees.Name = "DG_Liste_Interventions_nonpayees"
        Me.DG_Liste_Interventions_nonpayees.RowHeadersWidth = 31
        Me.DG_Liste_Interventions_nonpayees.Size = New System.Drawing.Size(547, 228)
        Me.DG_Liste_Interventions_nonpayees.TabIndex = 1
        '
        'NomPDataGridViewTextBoxColumn1
        '
        Me.NomPDataGridViewTextBoxColumn1.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn1.HeaderText = "NomP"
        Me.NomPDataGridViewTextBoxColumn1.Name = "NomPDataGridViewTextBoxColumn1"
        '
        'PrenomPDataGridViewTextBoxColumn1
        '
        Me.PrenomPDataGridViewTextBoxColumn1.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn1.HeaderText = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn1.Name = "PrenomPDataGridViewTextBoxColumn1"
        '
        'IdIntervenantDataGridViewTextBoxColumn
        '
        Me.IdIntervenantDataGridViewTextBoxColumn.DataPropertyName = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn.HeaderText = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn.Name = "IdIntervenantDataGridViewTextBoxColumn"
        '
        'NomFDataGridViewTextBoxColumn
        '
        Me.NomFDataGridViewTextBoxColumn.DataPropertyName = "NomF"
        Me.NomFDataGridViewTextBoxColumn.HeaderText = "NomF"
        Me.NomFDataGridViewTextBoxColumn.Name = "NomFDataGridViewTextBoxColumn"
        '
        'IdSeanceDataGridViewTextBoxColumn
        '
        Me.IdSeanceDataGridViewTextBoxColumn.DataPropertyName = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn.HeaderText = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn.Name = "IdSeanceDataGridViewTextBoxColumn"
        '
        'IdSessionFormationDataGridViewTextBoxColumn
        '
        Me.IdSessionFormationDataGridViewTextBoxColumn.DataPropertyName = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn.HeaderText = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn.Name = "IdSessionFormationDataGridViewTextBoxColumn"
        '
        'AnneeSessionDataGridViewTextBoxColumn
        '
        Me.AnneeSessionDataGridViewTextBoxColumn.DataPropertyName = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn.HeaderText = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn.Name = "AnneeSessionDataGridViewTextBoxColumn"
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
        '
        'StatutPaiementDataGridViewTextBoxColumn1
        '
        Me.StatutPaiementDataGridViewTextBoxColumn1.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn1.HeaderText = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn1.Name = "StatutPaiementDataGridViewTextBoxColumn1"
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
        Me.DG_Liste_Interventions_payees.Location = New System.Drawing.Point(59, 256)
        Me.DG_Liste_Interventions_payees.Name = "DG_Liste_Interventions_payees"
        Me.DG_Liste_Interventions_payees.RowHeadersWidth = 31
        Me.DG_Liste_Interventions_payees.Size = New System.Drawing.Size(547, 194)
        Me.DG_Liste_Interventions_payees.TabIndex = 0
        '
        'NomPDataGridViewTextBoxColumn2
        '
        Me.NomPDataGridViewTextBoxColumn2.DataPropertyName = "NomP"
        Me.NomPDataGridViewTextBoxColumn2.HeaderText = "NomP"
        Me.NomPDataGridViewTextBoxColumn2.Name = "NomPDataGridViewTextBoxColumn2"
        '
        'PrenomPDataGridViewTextBoxColumn2
        '
        Me.PrenomPDataGridViewTextBoxColumn2.DataPropertyName = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn2.HeaderText = "PrenomP"
        Me.PrenomPDataGridViewTextBoxColumn2.Name = "PrenomPDataGridViewTextBoxColumn2"
        '
        'IdIntervenantDataGridViewTextBoxColumn1
        '
        Me.IdIntervenantDataGridViewTextBoxColumn1.DataPropertyName = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn1.HeaderText = "idIntervenant"
        Me.IdIntervenantDataGridViewTextBoxColumn1.Name = "IdIntervenantDataGridViewTextBoxColumn1"
        '
        'NomFDataGridViewTextBoxColumn1
        '
        Me.NomFDataGridViewTextBoxColumn1.DataPropertyName = "NomF"
        Me.NomFDataGridViewTextBoxColumn1.HeaderText = "NomF"
        Me.NomFDataGridViewTextBoxColumn1.Name = "NomFDataGridViewTextBoxColumn1"
        '
        'IdSeanceDataGridViewTextBoxColumn1
        '
        Me.IdSeanceDataGridViewTextBoxColumn1.DataPropertyName = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn1.HeaderText = "idSeance"
        Me.IdSeanceDataGridViewTextBoxColumn1.Name = "IdSeanceDataGridViewTextBoxColumn1"
        '
        'IdSessionFormationDataGridViewTextBoxColumn1
        '
        Me.IdSessionFormationDataGridViewTextBoxColumn1.DataPropertyName = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn1.HeaderText = "idSessionFormation"
        Me.IdSessionFormationDataGridViewTextBoxColumn1.Name = "IdSessionFormationDataGridViewTextBoxColumn1"
        '
        'AnneeSessionDataGridViewTextBoxColumn1
        '
        Me.AnneeSessionDataGridViewTextBoxColumn1.DataPropertyName = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn1.HeaderText = "AnneeSession"
        Me.AnneeSessionDataGridViewTextBoxColumn1.Name = "AnneeSessionDataGridViewTextBoxColumn1"
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
        '
        'StatutPaiementDataGridViewTextBoxColumn2
        '
        Me.StatutPaiementDataGridViewTextBoxColumn2.DataPropertyName = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn2.HeaderText = "StatutPaiement"
        Me.StatutPaiementDataGridViewTextBoxColumn2.Name = "StatutPaiementDataGridViewTextBoxColumn2"
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
        Me.DG_Liste_Intervenants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CivilitePDataGridViewTextBoxColumn, Me.NomPDataGridViewTextBoxColumn, Me.PrenomPDataGridViewTextBoxColumn, Me.TypeIntervenantDataGridViewTextBoxColumn, Me.DateNaissanceIDataGridViewTextBoxColumn, Me.PaysP})
        Me.DG_Liste_Intervenants.DataSource = Me.ProfilsintervenantBindingSource
        Me.DG_Liste_Intervenants.Location = New System.Drawing.Point(46, 53)
        Me.DG_Liste_Intervenants.Name = "DG_Liste_Intervenants"
        Me.DG_Liste_Intervenants.ReadOnly = True
        Me.DG_Liste_Intervenants.RowHeadersWidth = 31
        Me.DG_Liste_Intervenants.Size = New System.Drawing.Size(760, 261)
        Me.DG_Liste_Intervenants.TabIndex = 1
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
        'PaysP
        '
        Me.PaysP.DataPropertyName = "PaysP"
        Me.PaysP.HeaderText = "PaysP"
        Me.PaysP.Name = "PaysP"
        Me.PaysP.ReadOnly = True
        '
        'ProfilsintervenantBindingSource
        '
        Me.ProfilsintervenantBindingSource.DataMember = "profils_intervenant"
        Me.ProfilsintervenantBindingSource.DataSource = Me.Formation_ContinueDataSet1
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
        Me.Panel_Stagiaires_détails.Controls.Add(Me.FillBy_liste_intervenantsToolStrip)
        Me.Panel_Stagiaires_détails.Controls.Add(Me.BT_Refresh)
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
        'FillBy_liste_intervenantsToolStrip
        '
        Me.FillBy_liste_intervenantsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy_liste_intervenantsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdSToolStripLabel, Me.Param_DG_Intervenants, Me.FillBy_liste_intervenantsToolStripButton, Me.NouveauToolStripButton, Me.OuvrirToolStripButton, Me.EnregistrerToolStripButton, Me.ImprimerToolStripButton, Me.toolStripSeparator, Me.CouperToolStripButton, Me.CopierToolStripButton, Me.CollerToolStripButton, Me.toolStripSeparator1, Me.ToolStripButton})
        Me.FillBy_liste_intervenantsToolStrip.Location = New System.Drawing.Point(3, 25)
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
        'BT_Refresh
        '
        Me.BT_Refresh.Location = New System.Drawing.Point(852, 253)
        Me.BT_Refresh.Name = "BT_Refresh"
        Me.BT_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.BT_Refresh.TabIndex = 7
        Me.BT_Refresh.Text = "Raffraîchir"
        Me.BT_Refresh.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button15)
        Me.GroupBox7.Controls.Add(Me.Button14)
        Me.GroupBox7.Controls.Add(Me.BT_Modifier_Stagiaires)
        Me.GroupBox7.Controls.Add(Me.BT_Nouveau_Stagiaire)
        Me.GroupBox7.Location = New System.Drawing.Point(844, 53)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(89, 178)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(8, 138)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 23)
        Me.Button15.TabIndex = 3
        Me.Button15.Text = "Exporter"
        Me.Button15.UseVisualStyleBackColor = True
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
        Me.DG_Liste_Stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Liste_Stagiaires.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG_Liste_Stagiaires.Location = New System.Drawing.Point(50, 51)
        Me.DG_Liste_Stagiaires.Name = "DG_Liste_Stagiaires"
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
        Me.FillBy_liste_interventionsToolStrip.ResumeLayout(False)
        Me.FillBy_liste_interventionsToolStrip.PerformLayout()
        CType(Me.DG_Liste_Interventions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListeinterventionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Formation_ContinueDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ProfilsintervenantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel_Stagiaires_détails.ResumeLayout(False)
        Me.Panel_Stagiaires_détails.PerformLayout()
        Me.FillBy_liste_intervenantsToolStrip.ResumeLayout(False)
        Me.FillBy_liste_intervenantsToolStrip.PerformLayout()
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
    Friend WithEvents CB_I_Convoc As ComboBox
    Friend WithEvents CB_I_FSF As ComboBox
    Friend WithEvents CB_I_DSE As ComboBox
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
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
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents BT_Modifier_Stagiaires As Button
    Friend WithEvents BT_Nouveau_Stagiaire As Button
    Friend WithEvents BT_Refresh As Button
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
    Friend WithEvents FillBy_liste_interventionsToolStrip As ToolStrip
    Friend WithEvents NomFormationToolStripLabel As ToolStripLabel
    Friend WithEvents Param_NomFormation As ToolStripTextBox
    Friend WithEvents SessionToolStripLabel As ToolStripLabel
    Friend WithEvents Param_Session As ToolStripTextBox
    Friend WithEvents FillBy_liste_interventionsToolStripButton As ToolStripButton
    Friend WithEvents TypeInterventionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeureDebutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeureFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NbHeureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatutPaiementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CivilitePDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrenomPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeIntervenantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateNaissanceIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaysP As DataGridViewTextBoxColumn
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
End Class
