Public Class FIRST_PAGE
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub FIRST_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class