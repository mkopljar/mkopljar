Imports Skrlin.SQL2Škrlin
Public Class Form1

    Public P As DataSet1.RegistarRow

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Threading.Thread.Sleep(2000)
        Me.WindowState = FormWindowState.Maximized

        If My.User.IsInRole("Admin") Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor

        If TextBox1.Text.Length = 0 Then Exit Sub

        Try
            DataGridView1.DataSource = SQL2Škrlin.GetData_Registar_by_PrezimeIme(TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Cursor.Current = Cursors.WaitCursor
        P = DirectCast(DataGridView1.SelectedRows(0).DataBoundItem.row, DataSet1.RegistarRow)
        'MsgBox(P.RegistarskiBR)
        Dim f As New Pacijent(P)
        f.ShowDialog()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f As New Korisnici
        f.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.User.CurrentPrincipal = Nothing
        Dim f As New Skrlin.LoginForm1
        f.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f As New Skrlin.Password_change
        f.ShowDialog()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim f As New Skrlin.Prikaz_Radilista
        f.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Skrlin.Admin_panel
        f.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
