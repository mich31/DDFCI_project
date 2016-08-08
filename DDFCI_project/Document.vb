Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word

Public Class Document
    Private bdd As BD 'la connexion à la base
    Private index As Integer
    Private id As String

    Private infos_I_perso As DataRow
    Private infos_I_pro As DataTable

    'Private MonDataSet As New DataSet


    Sub New(ByRef base As BD, ByRef donnees_perso As DataRow, ByRef donnees_pro As DataTable)
        bdd = base
        infos_I_perso = donnees_perso
        infos_I_pro = donnees_pro
    End Sub


    Sub GenereDossierEngagement()
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\INTERVENANTS\Test\Dossier_Engagement.docx")
        'Rendre le document visible
        oWord.Visible = True

        oDoc.Bookmarks.Item("Civilité").Range.Text = infos_I_perso("CiviliteP").ToString
        oDoc.Bookmarks.Item("Nom").Range.Text = infos_I_perso("NomP").ToString
        oDoc.Bookmarks.Item("NomJeuneFille").Range.Text = infos_I_perso("NomJeuneFille").ToString
        oDoc.Bookmarks.Item("Prénom").Range.Text = infos_I_perso("PrenomP").ToString
        oDoc.Bookmarks.Item("DateNaissance").Range.Text = infos_I_perso("DateNaissanceI").ToString
        oDoc.Bookmarks.Item("LieuNaissance").Range.Text = infos_I_perso("LieuNaissanceI").ToString
        oDoc.Bookmarks.Item("PaysNaissance").Range.Text = infos_I_perso("PaysNaissanceI").ToString
        oDoc.Bookmarks.Item("NumSS").Range.Text = infos_I_perso("NumSSI").ToString
        oDoc.Bookmarks.Item("Nationalité").Range.Text = infos_I_perso("NationaliteP").ToString
        oDoc.Bookmarks.Item("Adresse").Range.Text = infos_I_perso("AdresseP").ToString
        oDoc.Bookmarks.Item("CP").Range.Text = infos_I_perso("CP").ToString
        oDoc.Bookmarks.Item("Ville").Range.Text = infos_I_perso("VilleP").ToString
        oDoc.Bookmarks.Item("Pays").Range.Text = infos_I_perso("PaysP").ToString
        oDoc.Bookmarks.Item("NumTel").Range.Text = infos_I_perso("NumTelP").ToString
        oDoc.Bookmarks.Item("Mail").Range.Text = infos_I_perso("MailP").ToString

        oDoc.Bookmarks.Item("NomIntervenant").Range.Text = infos_I_perso("NomP").ToString.ToUpper & " " & infos_I_perso("PrenomP").ToString
        oDoc.Bookmarks.Item("DécisionDirecteur").Range.Text = infos_I_perso("CiviliteP").ToString & "  " & infos_I_perso("NomP").ToString.ToUpper & " " & infos_I_perso("PrenomP").ToString & "  "


        For Each Ligne As DataRow In infos_I_pro.Rows()
            oDoc.Bookmarks.Item("Profession").Range.Text = Ligne("Fonction").ToString
            oDoc.Bookmarks.Item("NomEntreprise").Range.Text = Ligne("NomE").ToString
            oDoc.Bookmarks.Item("Anciennete").Range.Text = Ligne("Anciennete").ToString
            oDoc.Bookmarks.Item("AdresseEntreprise").Range.Text = Ligne("AdresseE").ToString
        Next

        oDoc.Bookmarks.Item("FaitA").Range.Text = "Vaulx en velin"
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

        oDoc.Bookmarks.Item("NomIntervenant").Range.Text = infos_I_perso("NomP").ToString.ToUpper & " " & infos_I_perso("PrenomP").ToString

    End Sub

    Sub GenereConvocationIntervenant()
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\INTERVENANTS\Test\Convocation.doc")
        'Rendre le document visible
        oWord.Visible = True

        oDoc.Bookmarks.Item("NomIntervenant").Range.Text = infos_I_perso("NomP").ToString.ToUpper & " " & infos_I_perso("PrenomP").ToString
        oDoc.Bookmarks.Item("Date").Range.Text = DateTime.Now.Date.ToString("d")
        'oDoc.Bookmarks.Item("NomFormation").Range.Text = 
    End Sub

End Class
