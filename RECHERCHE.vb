Imports System.Data.OleDb
Public Class RECHERCHE
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private dt As New DataTable()
    Private dtetud As New DataTable()
    Private dtapresaff As New DataTable()
    Private dtsalles As New DataTable()
    Dim max As Integer
    Dim max2 As Integer
    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

    End Sub
End Class