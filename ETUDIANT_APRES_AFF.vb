Imports System.Data.OleDb
Public Class ETUDIANT_APRES_AFF
    Private matricule As String
    Private id_place As String
    Private modules As String
    Private mod_aff As String
    Private cmd As OleDbCommand


    Sub New(ByVal matrcl As String, ByVal id_p As String, ByVal mdl As String, ByVal mod_af As String)
        Me.matricule = matrcl
        Me.id_place = id_p
        Me.modules = mdl
        Me.mod_aff = mod_af
    End Sub

    Public Sub affecter(ByVal con As OleDbConnection)
        cmd = New OleDbCommand("INSERT INTO ETUDIANT_APRES_AFF ([MATRICULE],[ID_PLACE],[module],[MODE_AFF]) VALUES (@MATRICULE,@ID_PLACE,@module,@MODE_AFF)", con)
        cmd.Parameters.Add(New OleDbParameter("@MATRICULE", OleDbType.VarChar)).Value = matricule
        cmd.Parameters.Add(New OleDbParameter("@ID_PLACE", OleDbType.VarChar)).Value = id_place
        cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = modules
        cmd.Parameters.Add(New OleDbParameter("@MODE_AFF", OleDbType.VarChar)).Value = mod_aff
        cmd.ExecuteNonQuery()
    End Sub
End Class
