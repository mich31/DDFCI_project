Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word

Public Class Document
    Private bdd As BD 'la connexion à la base
    Private index As Integer
    Private id As String

    Private MonDataSet As New DataSet

    Sub New(ByRef DT As DataTable, ByVal i As Integer, ByRef base As BD)
        Dim Ligne As DataRow
        index = i
        bdd = base

        Ligne = DT.Rows().Item(i)
        id = Ligne("idPersonne").ToString
        GenereInfosPerso()
        GenereInfosPro()
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
        Next

        For Each Ligne As DataRow In MonDataSet.Tables("fiche_pro_intervenant").Rows()
            oDoc.Bookmarks.Item("Profession").Range.Text = Ligne("Fonction").ToString
            oDoc.Bookmarks.Item("NomEntreprise").Range.Text = Ligne("NomE").ToString
            oDoc.Bookmarks.Item("Anciennete").Range.Text = Ligne("Anciennete").ToString
            oDoc.Bookmarks.Item("AdresseEntreprise").Range.Text = Ligne("AdresseE").ToString
            oDoc.Bookmarks.Item("FaitA").Range.Text = "Vaulx en velin"
        Next
    End Sub
End Class
