Imports System.Data.OleDb
Public Class AFFECTATION
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As New OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tb As New DataTable
    Public fout As String
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        AFF_EXECUTE.Show()
    End Sub
    Private Sub BunifuThinButton231_Click(sender As Object, e As EventArgs) Handles BunifuThinButton231.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        fout = "NOM"
        Me.Hide()
        AFF_EXECUTE.Show()

    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        fout = "ALEA"
        Me.Hide()
        AFF_EXECUTE.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        fout = "MATR"
        Me.Hide()
        AFF_EXECUTE.Show()
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        fout = "MOY"
        Me.Hide()
        AFF_EXECUTE.Show()
    End Sub
    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        fout = "RANG"
        Me.Hide()
        AFF_EXECUTE.Show()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub
End Class