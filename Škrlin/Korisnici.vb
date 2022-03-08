Public Class Korisnici

    Private Sub Korisnici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.User.CurrentPrincipal.IsInRole("Admin") Then
            MsgBox("Nemate ovlaštenja !", MsgBoxStyle.Critical, "Neuspješna autorizacija")
            Me.Close()
        End If

        'TODO: This line of code loads data into the 'DataSet3.aspnet_Users' table. You can move, or remove it, as needed.
        Me.Aspnet_UsersTableAdapter.Fill(Me.DataSet3.aspnet_Users)

    End Sub

    Private Sub Aspnet_UsersDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Aspnet_UsersDataGridView.CellDoubleClick
        Dim r As DataSet3.aspnet_UsersRow
        r = DirectCast(Aspnet_UsersDataGridView.SelectedRows(0).DataBoundItem.row, DataSet3.aspnet_UsersRow)
        Dim f As New Korisnik(r.UserId)
        f.ShowDialog()
        Me.Aspnet_UsersTableAdapter.Fill(Me.DataSet3.aspnet_Users)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Korisnik(0)
        f.ShowDialog()
        Me.Aspnet_UsersTableAdapter.Fill(Me.DataSet3.aspnet_Users)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class