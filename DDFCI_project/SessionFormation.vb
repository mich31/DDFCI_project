﻿Imports System.Data.SqlClient

Public Class SessionFormation
    Private MonDataSet As New DataSet
    Private bdd As BD
    Private idSession As String
    Private idFormation As String

    Public NomFormation As String
    Public Session As String
    Public Debut As String
    Public Fin As String
    Public Chef_de_projet As String = ""
    Public Assistante As String = ""


#Region "Propriétés"

    Property Liste_stagiaires As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_stagiaires")
        End Get
    End Property

    Property Liste_intervenants As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("liste_intervenants")
        End Get
    End Property

    Property infos_session As DataTable
        Set(value As DataTable)

        End Set
        Get
            Return MonDataSet.Tables("infos_session")
        End Get
    End Property

#End Region


    Sub New(ByRef base As BD, _nomF As String, _session As String, idS As String, idF As String)
        bdd = base
        NomFormation = _nomF
        Session = _session
        idSession = idS
        idFormation = idF

        GenereListeStagiaires()
        GenereListeIntervenants()
        GenereDateSession()
        Genere_CP()
        Genere_AF()
        GenereInfosSession()
    End Sub

    Sub GenereListeStagiaires()
        Dim Req As String = "select*from profils_stagiaires 
        where idPersonne in 
        (select idStagiaire from liste_inscriptions where NomF = '" & NomFormation & "' 
        and AnneeSession = '" & Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_stagiaires")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereListeIntervenants()
        Dim Req As String = "select*from profils_intervenant 
        where idPersonne in 
        (select idIntervenant from liste_interventions where NomF = '" & NomFormation & "' 
        and AnneeSession = '" & Session & "')"
        Dim cmd As New SqlCommand(Req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)

        Try
            MonAdaptateur.Fill(MonDataSet, "liste_intervenants")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereDateSession()
        Dim req As String = "select*from SessionFormation where idSessionFormation='" & idSession & "' and idFormation='" & idFormation & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim _Debut, _Fin As Date

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                _Debut = MonReader("DateDebut").ToString
                _Fin = MonReader("DateFin").ToString
                Debut = _Debut.Date
                Fin = _Fin.Date
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub GenereInfosSession()
        Dim req As String = "select*from liste_sessions where idFormation='" & idFormation & "' and idSessionFormation ='" & idSession & "'"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim MonAdaptateur As New SqlDataAdapter(cmd)
        Try
            MonAdaptateur.Fill(MonDataSet, "infos_session")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub Genere_CP()
        Dim req As String = "select*from travailleSurFormation T join Personnel P on T.Login = P.Login 
            and T.idSessionFormation = '" & idSession & "' and P.Fonction = 'Chef(fe) de projet'"
        Dim cmd As New SqlCommand(req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Chef_de_projet = MonReader("Login").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

    Sub Genere_AF()
        Dim req As String = "select*from travailleSurFormation T join Personnel P on T.Login = P.Login 
            and T.idSessionFormation = '" & idSession & "' and P.Fonction = 'Assistant(e) de formation'"
        Dim cmd As New SqlCommand(req, bdd.connect)

        Try
            Dim MonReader As SqlDataReader = cmd.ExecuteReader()
            If MonReader.Read() Then
                Assistante = MonReader("Login").ToString
            End If
            MonReader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        cmd.Dispose()
    End Sub

End Class
