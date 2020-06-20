Imports System.Data.OleDb
Public Class ETAT
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tb As New DataTable()
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        adapter = New OleDbDataAdapter("SELECT MODULES_SALLES.* , TIME_.*  From TIME_ ,MODULES_SALLES
         WHERE  MODULES_SALLES.ID_TIME = TIME_.ID_TIME   AND  TIME_.DATE BETWEEN #" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "# AND  #" & DateTimePicker2.Value.ToString("dd-MM-yyyy") & "# ", con)

        adapter.Fill(tb)
        BunifuCustomDataGrid1.DataSource = tb
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Me.Hide()
        MAPESI_P1.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class