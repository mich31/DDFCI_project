﻿Imports System.Data.SqlClient

Public Class Ajout_intervention
    Private bdd As BD
    Private MonIntervenant As DataGridViewRow
    Private MaSeance As DataGridViewRow

    Sub New(base As BD, ByRef intervenant As DataGridViewRow, ByRef Seance As DataGridViewRow)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bdd = base
        MonIntervenant = intervenant
        MaSeance = Seance
    End Sub

    Private Sub Ajout_intervention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Formation_ContinueDataSet1.Vacation'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.VacationTableAdapter.Fill(Me.Formation_ContinueDataSet1.Vacation)
        Me.TB_Nom.Text = MonIntervenant.Cells(2).Value
        Me.TB_Prenom.Text = MonIntervenant.Cells(4).Value
        Me.DTP_Date.Value = MaSeance.Cells(2).Value
    End Sub

    Private Sub Ajoute_intervention()
        Dim idIntervenant As String = MonIntervenant.Cells(0).Value
        Dim idSeance As String = MaSeance.Cells(0).Value
        Dim nbh As TimeSpan = Me.DTP_Fin.Value - Me.DTP_Debut.Value
        Me.TB_NB_Heures.Text = Math.Round(nbh.TotalHours, 2)
        Dim nb As String = Replace(Me.TB_NB_Heures.Text, ",", ".")
        Dim Debut As String = Me.DTP_Debut.Value.TimeOfDay.ToString
        Dim Fin As String = Me.DTP_Fin.Value.TimeOfDay.ToString

        Dim req As String = "insert into intervient 
        values ('" & idIntervenant & "','" & idSeance & "','" & Me.CB_Type.Text & "','Non payé','0','Incomplet'," & nb & ",'" & Debut & "','" & Fin & "','')"
        Dim cmd As New SqlCommand(req, bdd.connect)
        Dim res As Integer = 0

        Try
            res = cmd.ExecuteNonQuery()

            If res = 1 Then
                MsgBox("Intervention ajoutée!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BT_Annuler_Click(sender As Object, e As EventArgs) Handles BT_Annuler.Click
        Me.Dispose()
    End Sub

    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        Ajoute_intervention()
    End Sub
End Class