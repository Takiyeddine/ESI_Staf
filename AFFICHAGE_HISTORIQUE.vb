Imports System.Data.OleDb
Public Class AFFICHAGE_HISTORIQUE_ETUD
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tb As New DataTable()
    Private Sub AFFICHAGE_HISTORIQUE_ETUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox27.Items.Add("1CP")
        ComboBox27.Items.Add("2CP")
        ComboBox27.Items.Add("1CS")
        ComboBox27.Items.Add("2SL")
        ComboBox27.Items.Add("2SQ")
        ComboBox27.Items.Add("2ST")
        ComboBox1.Items.Add("G01")
        ComboBox1.Items.Add("G02")
        ComboBox1.Items.Add("G03")
        ComboBox1.Items.Add("G04")
        ComboBox1.Items.Add("G05")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim requette As String
        requette = "SELECT * FROM ETUDIANT_APRES_AFF_HISTO WHERE PROMO ='" & ComboBox27.Text & "' AND GROUPE ='" & ComboBox1.Text & "' AND ANNEE_SCOLAIRE='" & BunifuMaterialTextbox3.Text & "' AND MDL = '" & BunifuMaterialTextbox2.Text & "'"
        Dim cmd As New OleDbCommand
        cmd = New OleDbCommand(requette, con)

        adapter = New OleDbDataAdapter(cmd)

        adapter.Fill(tb)
        BunifuCustomDataGrid1.DataSource = tb
        BunifuCustomDataGrid1.DataSource = tb
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Me.Hide()
        HISTORIQUE.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class