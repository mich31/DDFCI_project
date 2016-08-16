Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word


Public Class Stagiaire
    Private MonDataSet As New DataSet
    Private bdd As BD
    Private id As Integer

    Private NomFormation As String
    Private Session As String
    Private utilisateur As Utilisateur



    Sub New(ByRef base As BD, ByVal ListeStagiaires As DataTable, ByVal DonneesPro As DataTable, ByVal index As Integer, ByVal _Session As String, ByVal _NomFormation As String, ByVal _utilisateur As Utilisateur)
        bdd = base
        Dim Ligne As DataRow
        Ligne = ListeStagiaires.Rows().Item(index)
        id = Ligne("idPersonne").ToString
        NomFormation = _NomFormation
        Session = _Session
        utilisateur = _utilisateur

        GenereInfosPerso()
        GenereInfosPro()
    End Sub

    Sub GenereInfosPerso()
        Dim Req As String = "select*from profils_stagiaires where idPersonne='" & id & "'"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "fiche_perso_stagiaire")
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
            MonAdaptateur.Fill(MonDataSet, "fiche_pro_stagiaire")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub


#Region "Edition des documents"

    Sub GenereConvention()
        'Crée une instance de Word
        Dim oWord As New Word.Application
        Dim oDoc As New Word.Document
        'Ouvrir un document
        oDoc = oWord.Documents.Open("C:\Users\michel.edjoa\Documents\Outils de gestion\Formation Continue\Docs à éditer\STAGIAIRES\Test\Convention.doc")
        'Rendre le document visible
        oWord.Visible = True

        'oDoc.Bookmarks.Item("Année").Range.Text = DateTime.Now.Year.ToString
        'oDoc.Bookmarks.Item("AnnéeCivile").Range.Text = DateTime.Now.Year.ToString
        'oDoc.Bookmarks.Item("DateValidation").Range.Text = DateTime.Now.Date.ToString("d")

        'For Each Ligne As DataRow In MonDataSet.Tables("fiche_perso_intervenant").Rows()
        '    oDoc.Bookmarks.Item("NomIntervenant").Range.Text = Ligne("NomP").ToString.ToUpper & " " & Ligne("PrenomP").ToString
        'Next
    End Sub

#End Region
End Class
