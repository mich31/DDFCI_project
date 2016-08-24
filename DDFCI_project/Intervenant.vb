Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word

Public Class Intervenant
    Private MonDataSet As New DataSet
    Private bdd As BD
    Private id As Integer

    Private NomFormation As String
    Private Session As String
    Private utilisateur As Utilisateur

    Private TableInterventions As DataTable

    Sub New(ByRef base As BD, ByVal ListeIntervenants As DataTable, ByVal ListeInterventions As DataTable, ByVal DonneesPro As DataTable, ByVal index As Integer, ByVal _Session As String, ByVal _NomFormation As String, ByVal _utilisateur As Utilisateur)
        bdd = base
        Dim Ligne As DataRow
        Ligne = ListeIntervenants.Rows().Item(index)
        id = Ligne("idPersonne").ToString
        NomFormation = _NomFormation
        Session = _Session
        utilisateur = _utilisateur
        TableInterventions = ListeInterventions

        GenereInfosPerso()
        GenereInfosPro()
        GenereInterventions()
    End Sub

    Sub GenereInfosPerso()
        Dim Req As String = "select*from profils_intervenant where idPersonne='" & id & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "fiche_perso_intervenant")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereInfosPro()
        Dim Req As String = "select*from emplois where idPersonne='" & id & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "fiche_pro_intervenant")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereInterventions()
        Dim Req As String = "select*from liste_interventions where idIntervenant='" & id & "' and NomF='" & NomFormation & "' 
            and AnneeSession='" & Session & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "tableau_interventions")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

#Region "Propriétés"

    Property interventions As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("tableau_interventions")
        End Get
    End Property

#End Region

#Region "Edition des documents"

    Sub GenereDossierEngagement()
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\INTERVENANTS\Test\Dossier_Engagement.docx")
        'Rendre le document visible
        oWord.Visible = True

        For Each Ligne As DataRow In MonDataSet.Tables("fiche_perso_intervenant").Rows()
            oDoc.Bookmarks.Item("Civilité").Range.Text = Ligne("CiviliteP").ToString
            oDoc.Bookmarks.Item("Nom").Range.Text = Ligne("NomP").ToString
            oDoc.Bookmarks.Item("NomJeuneFille").Range.Text = Ligne("NomJeuneFille").ToString
            oDoc.Bookmarks.Item("Prénom").Range.Text = Ligne("PrenomP").ToString
            oDoc.Bookmarks.Item("DateNaissance").Range.Text = Ligne("DateNaissanceI").ToString
            oDoc.Bookmarks.Item("LieuNaissance").Range.Text = Ligne("LieuNaissanceI").ToString
            oDoc.Bookmarks.Item("PaysNaissance").Range.Text = Ligne("PaysNaissanceI").ToString
            oDoc.Bookmarks.Item("NumSS").Range.Text = Ligne("NumSSI").ToString
            oDoc.Bookmarks.Item("Nationalité").Range.Text = Ligne("NationaliteP").ToString
            oDoc.Bookmarks.Item("Adresse").Range.Text = Ligne("AdresseP").ToString
            oDoc.Bookmarks.Item("CP").Range.Text = Ligne("CP").ToString
            oDoc.Bookmarks.Item("Ville").Range.Text = Ligne("VilleP").ToString
            oDoc.Bookmarks.Item("Pays").Range.Text = Ligne("PaysP").ToString
            oDoc.Bookmarks.Item("NumTel").Range.Text = Ligne("NumTelP").ToString
            oDoc.Bookmarks.Item("Mail").Range.Text = Ligne("MailP").ToString

            oDoc.Bookmarks.Item("NomIntervenant").Range.Text = Ligne("NomP").ToString.ToUpper & " " & Ligne("PrenomP").ToString
            oDoc.Bookmarks.Item("DécisionDirecteur").Range.Text = Ligne("CiviliteP").ToString & "  " & Ligne("NomP").ToString.ToUpper & " " & Ligne("PrenomP").ToString & "  "

        Next

        For Each Ligne As DataRow In MonDataSet.Tables("fiche_pro_intervenant").Rows()
            oDoc.Bookmarks.Item("Profession").Range.Text = Ligne("Fonction").ToString
            oDoc.Bookmarks.Item("NomEntreprise").Range.Text = Ligne("NomE").ToString
            oDoc.Bookmarks.Item("Anciennete").Range.Text = Ligne("Anciennete").ToString
            oDoc.Bookmarks.Item("AdresseEntreprise").Range.Text = Ligne("AdresseE").ToString
        Next

        oDoc.Bookmarks.Item("FaitA").Range.Text = "Vaulx en Velin"
        oDoc.Bookmarks.Item("Année").Range.Text = DateTime.Now.Year.ToString
        oDoc.Bookmarks.Item("Date").Range.Text = DateTime.Now.Date.ToString("d")
    End Sub

    Sub GenereFicheServicefait()

        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\INTERVENANTS\Test\Fiche service fait.docx")
        'Rendre le document visible
        oWord.Visible = True

        oDoc.Bookmarks.Item("Année").Range.Text = DateTime.Now.Year.ToString
        oDoc.Bookmarks.Item("AnnéeCivile").Range.Text = DateTime.Now.Year.ToString
        oDoc.Bookmarks.Item("DateValidation").Range.Text = DateTime.Now.Date.ToString("d")

        For Each Ligne As DataRow In MonDataSet.Tables("fiche_perso_intervenant").Rows()
            oDoc.Bookmarks.Item("NomIntervenant").Range.Text = Ligne("NomP").ToString.ToUpper & " " & Ligne("PrenomP").ToString
        Next

    End Sub

    Sub GenereConvocationIntervenant()
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\INTERVENANTS\Test\Convocation.doc")
        'Rendre le document visible
        oWord.Visible = True

        For Each Ligne As DataRow In MonDataSet.Tables("fiche_perso_intervenant").Rows()
            oDoc.Bookmarks.Item("NomIntervenant").Range.Text = Ligne("NomP").ToString.ToUpper & " " & Ligne("PrenomP").ToString
            oDoc.Bookmarks.Item("Date").Range.Text = DateTime.Now.Date.ToString("d")
            oDoc.Bookmarks.Item("NomFormation").Range.Text = NomFormation
            oDoc.Bookmarks.Item("Contact").Range.Text = utilisateur.email

        Next

    End Sub

#End Region


End Class
