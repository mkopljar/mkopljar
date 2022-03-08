Public Class Password_change

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Password_change_Load(sender As Object, e As EventArgs) Handles Me.Load
        User_label.Text = My.User.CurrentPrincipal.Identity.Name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'provjeri je li stara lozinka ispravna
        If Not SampleIIdentity.IsValidNameAndPassword(User_label.Text, Me.Old_Pass_TextBox.Text) Then
            MsgBox("Pogrešna lozinka !", MsgBoxStyle.Critical, "Pogreška")
            Exit Sub
        End If

        'provjeri je li upisana nova lozinka
        If Me.New_Pass_TextBox.Text = "" Then
            MsgBox("Morate upisati lozinku !", MsgBoxStyle.Critical, "Pogreška")
            Exit Sub
        End If

        'provjeri jesu li nova i ponovljena lozinka iste
        If Me.New_Pass_TextBox.Text <> Me.New_Pass_TextBox1.Text Then
            MsgBox("Lozinka i ponovljena lozinka moraju biti iste ! ", MsgBoxStyle.Critical, "Pogreška")
            Exit Sub
        End If

        'promijeni lozinku
        Dim ta As New DataSet3TableAdapters.aspnet_MembershipTableAdapter
        Dim ta1 As New DataSet3TableAdapters.QueriesTableAdapter
        Dim dt As New DataSet3.aspnet_MembershipDataTable
        dt = ta.GetDataBy(ta1.Get_UserId_for_userName(My.User.CurrentPrincipal.Identity.Name))
        Dim dr As DataSet3.aspnet_MembershipRow
        If dt.Rows.Count = 0 Then
            MsgBox("Korisnik ne postoji ! ", MsgBoxStyle.Critical, "Pogreška")
            Exit Sub
        End If
        dr = dt.Rows(0)
        dr.Password = SampleIIdentity.GetMd5Hash(Me.New_Pass_TextBox.Text)
        Try
            ta.Update(dt)
            MsgBox("Lozinka je uspješno promijenjena", MsgBoxStyle.Information, "")
        Catch ex As Exception
            MsgBox("Neočekivana pogreška ! Pokušajte ponovno.", MsgBoxStyle.Information, "")
        End Try
        Me.Close()
    End Sub
End Class