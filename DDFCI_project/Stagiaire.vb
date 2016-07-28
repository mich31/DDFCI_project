Public Class Stagiaire
    Public civ As String
    Public nom As String
    Public nomJF As String
    Public prenom As String
    Public nationalite As String
    Public adresse As String
    Public cp As String
    Public ville As String
    Public pays As String
    Public telephone As String
    Public mail As String

    Sub New(ByVal _civ As String, _nom As String, _nomJF As String, _prenom As String, _nat As String,
            _adr As String, _cp As String, _ville As String, _pays As String, _tel As String, _mail As String)
        civ = _civ
        nom = _nom
        nomJF = _nomJF
        prenom = _prenom
        nationalite = _nat
        adresse = _adr
        cp = _cp
        ville = _ville
        pays = _pays
        telephone = _tel
        mail = _mail
    End Sub
End Class
