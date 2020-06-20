Imports System.Data.OleDb
Public Class ETUDIANT
    Public etudiants As New DataTable
    Public adapter As New OleDbDataAdapter()
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private promo As String
    Public Sub set_promo(ByVal prm As String)
        Me.promo = prm
    End Sub
    Public Function cree_requete(ByVal req As String, ByVal crit As String)
        Dim requete As String
        requete = req & " AND ETUDIANT.[Promo] LIKE '" + Me.promo + "' ORDER BY " + crit
        Return requete
    End Function
    Public Sub chargement(ByVal requete As String)
        con.Open()
        adapter = New OleDbDataAdapter(requete, con)
        adapter.Fill(etudiants)
        con.Close()
    End Sub
    Public Function recup(ByVal position As Integer)
        Dim _Matricule = ":("
        If Not IsDBNull(etudiants.Rows(position).Item(1)) Then
            _Matricule = etudiants.Rows(position).Item(1)
        End If
        Return _Matricule
    End Function
End Class
