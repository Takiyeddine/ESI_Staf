Imports System.Data.OleDb
Public Class SALLES_MODULES
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tbmodules As New DataTable()
    Private tbsalles As New DataTable()
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub SALLES_MODULES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim max = 0
        adapter = New OleDbDataAdapter("SELECT DISTINCT MODULES.Code_Mat FROM MODULES
WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(tbmodules)
        con.Open()
        cmd = New OleDbCommand("SELECT DISTINCT COUNT (MODULES.Code_Mat) FROM MODULES
WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        For j As Integer = 0 To max - 1
            CheckedListBox1.Items.Add(tbmodules.Rows(j).Item(0))
        Next
        '***************************************
        max = 0
        adapter = New OleDbDataAdapter("SELECT * FROM SALLES_MAX;", con)
        adapter.Fill(tbsalles)
        con.Open()
        cmd = New OleDbCommand("SELECT COUNT (*) FROM SALLES_MAX;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        For j As Integer = 0 To max - 1
            CheckedListBox2.Items.Add(tbsalles.Rows(j).Item(0))
        Next
        '***************************************    
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        con.Open()
        Dim emploi As New EMPLOI
        emploi = New EMPLOI()
        emploi.set_promo(INITIALISATION.ComboBox27.Text)
        emploi.chargement(emploi.cree_requete("SELECT * FROM EMPLOI_DE_TEMPS"))
        For k = 0 To CheckedListBox1.CheckedItems.Count - 1
            For j = 0 To CheckedListBox2.CheckedItems.Count - 1
                For s = 0 To emploi.long_emploi - 1
                    If emploi.recup_module(s) = CheckedListBox1.CheckedItems(k) Then
                        cmd = New OleDbCommand("INSERT INTO MODULES_SALLES ([code_salle],[ID_TIME],[module]) VALUES (@code_salle,@ID_PLACE,@module)", con)
                        cmd.Parameters.Add(New OleDbParameter("@code_salle", OleDbType.VarChar)).Value = CheckedListBox2.CheckedItems(j)
                        cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = emploi.recup_idtime(s)
                        cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = emploi.recup_module(s)
                        cmd.ExecuteNonQuery()
                    End If
                Next
            Next
        Next
        Me.Hide()
        Me.Show()
        con.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class