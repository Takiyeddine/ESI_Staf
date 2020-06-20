Imports System.Data.OleDb
Public Class AFFICHAGE_HISTORIQUE_SALLES
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tb As New DataTable()
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        adapter = New OleDbDataAdapter("SELECT * FROM ETUDIANTS
WHERE Promo = '1CP';", con)
        adapter.Fill(tb)
        BunifuCustomDataGrid1.DataSource = tb
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Me.Hide()
        HISTORIQUE.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class