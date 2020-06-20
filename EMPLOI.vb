Imports System.Data.OleDb
Public Class EMPLOI
    Private promo As String
    Public adapter As New OleDbDataAdapter()
    Private emploi_temp As New DataTable
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Public Sub set_promo(ByVal prm As String)
        Me.promo = prm
    End Sub
    Public Function cree_requete(ByVal req As String)
        Dim requete As String
        requete = req + " WHERE Promo = '" & Me.promo & "'"
        Return requete
    End Function
    Public Sub chargement(ByVal requete As String)
        con.Open()
        adapter = New OleDbDataAdapter(requete, con)
        adapter.Fill(emploi_temp)
        con.Close()
    End Sub
    Public Function recup_module(ByVal position As Integer)
        Dim _module As String = ":("
        If Not IsDBNull(emploi_temp.Rows(position).Item(1)) Then
            _module = emploi_temp.Rows(position).Item(1)
        End If
        Return _module
    End Function
    Public Function recup_idtime(ByVal position As Integer)
        Dim idtime As String = ":("
        If Not IsDBNull(emploi_temp.Rows(position).Item(2)) Then
            idtime = emploi_temp.Rows(position).Item(2)
        End If
        Return idtime
    End Function
    Public Function long_emploi()
        Return emploi_temp.Rows.Count
    End Function

End Class
