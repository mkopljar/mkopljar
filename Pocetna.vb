Public Class Pocetna

    Private Sub Pocetna_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim f As New Skrlin.LoginForm1
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Close()
    End Sub
End Class