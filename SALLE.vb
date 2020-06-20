Imports System.Data.OleDb
Public Class SALLE
    Private id_time As Integer
    Private salle, place, module_salle As New DataTable
    Private adapter As New OleDbDataAdapter
    Private cmd As OleDbCommand
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")

    Public Sub set_id_time(ByVal id_tm As Integer)
        Me.id_time = id_tm
    End Sub
    Public Function cree_requete(ByVal req As String)
        Dim requete As String
        requete = req
        Return requete
    End Function
    Public Sub chargement_sale(ByVal requete As String)
        con.Open()
        adapter = New OleDbDataAdapter(requete, con)
        adapter.Fill(salle)
        con.Close()
    End Sub
    Public Sub chargement_place(ByVal requete As String)
        con.Open()
        adapter = New OleDbDataAdapter(requete, con)
        adapter.Fill(place)
        con.Close()
    End Sub

    Public Function recup(ByVal position As Integer)
        Dim _Matricule = ":("
        If Not IsDBNull(salle.Rows(position).Item(0)) Then
            _Matricule = salle.Rows(position).Item(0)
        End If
        Return _Matricule
    End Function
    Public Function recup_id_place(ByVal position As Integer)
        Dim id_place = ":("
        If Not IsDBNull(place.Rows(position).Item(0)) Then
            id_place = place.Rows(position).Item(0)
        End If
        Return id_place
    End Function
    Public Function recup_cod_sal(ByVal position As Integer)
        Dim cod_sal = ":("
        If Not IsDBNull(place.Rows(position).Item(3)) Then
            cod_sal = place.Rows(position).Item(3)
        End If
        Return cod_sal
    End Function
    Public Function recup_id_time(ByVal position As Integer)
        Dim id_time = ":("
        If Not IsDBNull(place.Rows(position).Item(2)) Then
            id_time = place.Rows(position).Item(2)
        End If
        Return id_time
    End Function

    Public Sub update(ByVal id_plc As String, ByVal id_tm As String)
        Dim rq As String
        rq = "UPDATE TABLES_SALLES SET VAL_AFF=2 WHERE ID_PLACE = @id_plc and ID_TIME = @it_tm "
        cmd = New OleDbCommand(rq, con)
        cmd.Parameters.Add(New OleDbParameter("@ID_PLACE", OleDbType.VarChar)).Value = id_plc
        cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = id_tm
        cmd.Parameters.Add(New OleDbParameter("@VAL_AFF", OleDbType.VarChar)).Value = 2
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub vider_place()
        place.Rows.Clear()
    End Sub
End Class
