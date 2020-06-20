Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private tb, tbmodules As New DataTable()
    Private max As New Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '********************************
        BunifuFlatButton1.Enabled = False
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton3.Enabled = False
        BunifuFlatButton4.Enabled = False
        '********************************
        Dim nbr As Integer
        Dim nbrtt As Integer
        con.Open()
        cmd = New OleDbCommand("SELECT COUNT (*) FROM ETUDIANTS
WHERE Promo = '1CP' OR Promo = '2CP';", con)
        nbr = Convert.ToInt32(cmd.ExecuteScalar())
        Label2.Text = cmd.ExecuteScalar()
        cmd = New OleDbCommand("SELECT COUNT (*) FROM ETUDIANTS
WHERE Promo = '1CS' OR Promo = '2SL' OR Promo = '2SQ' OR Promo = '2ST';", con)
        Label5.Text = cmd.ExecuteScalar()
        nbr = nbr + Convert.ToInt32(cmd.ExecuteScalar())
        Label11.Text = nbr.ToString
        '********************************
        cmd = New OleDbCommand("SELECT COUNT (*) FROM MOYENNE
WHERE Decision = 'Redouble' OR Decision = 'Maladie' OR Decision = 'Admis' OR Decision = 'Admis avec rachat';", con)
        nbrtt = Convert.ToInt32(cmd.ExecuteScalar())
        cmd = New OleDbCommand("SELECT COUNT (*) FROM MOYENNE
WHERE Decision = 'Redouble';", con)
        nbr = Convert.ToInt32(cmd.ExecuteScalar())
        nbr = (nbr * 100) / nbrtt
        BunifuCircleProgressbar3.Value = nbr
        '********************************
        cmd = New OleDbCommand("SELECT COUNT (*) FROM MOYENNE
WHERE Decision = 'Maladie';", con)
        nbr = Convert.ToInt32(cmd.ExecuteScalar())
        nbr = (nbr * 100) / nbrtt
        BunifuCircleProgressbar2.Value = nbr
        '********************************
        cmd = New OleDbCommand("SELECT COUNT (*) FROM MOYENNE
WHERE Decision = 'Admis avec rachat';", con)
        nbr = Convert.ToInt32(cmd.ExecuteScalar())
        nbr = (nbr * 100) / nbrtt
        BunifuCircleProgressbar1.Value = nbr
        '********************************
        cmd = New OleDbCommand("SELECT COUNT (*) FROM MOYENNE
WHERE Decision = 'Admis';", con)
        nbr = Convert.ToInt32(cmd.ExecuteScalar())
        nbr = (nbr * 100) / nbrtt
        BunifuCircleProgressbar4.Value = nbr
        '********************************
        con.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        INITIALISATION.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        AFFECTATION.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Hide()
        HISTORIQUE.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.Hide()
        ETAT.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class