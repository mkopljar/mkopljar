Public Class Korisnik
    Public ID As Integer = 0

    Public Sub New(ByVal ID1 As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ID = ID1
    End Sub

    Private Sub Korisnik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.aspnet_Roles' table. You can move, or remove it, as needed.
        Me.Aspnet_RolesTableAdapter.Fill(Me.DataSet3.aspnet_Roles)

        If (ID > 0) Then
            Me.Aspnet_MembershipTableAdapter.FillBy(Me.DataSet3.aspnet_Membership, ID)
            Me.Aspnet_UsersTableAdapter.FillBy(Me.DataSet3.aspnet_Users, ID)
            Me.PasswordTextBox.Visible = False
            Me.PasswordTextBox1.Visible = False
            Me.UserNameTextBox.ReadOnly = True 'Korisničko ime se ne može mijenjati
        Else
            Dim tr As DataSet3.aspnet_UsersRow
            tr = DataSet3.aspnet_Users.Newaspnet_UsersRow
            Me.DataSet3.aspnet_Users.Addaspnet_UsersRow(tr)
            Me.Aspnet_UsersTableAdapter.Update(Me.DataSet3.aspnet_Users)

            Dim tr1 As DataSet3.aspnet_MembershipRow
            tr1 = DataSet3.aspnet_Membership.Newaspnet_MembershipRow
            tr1.UserId = tr.UserId
            tr1.CreateDate = Now
            Me.DataSet3.aspnet_Membership.Addaspnet_MembershipRow(tr1)
            Me.Aspnet_MembershipTableAdapter.Update(Me.DataSet3.aspnet_Membership)
        End If

        'Prikaži role za korisnika NAKON što je dobio UserId
        Dim ta As New DataSet3TableAdapters.aspnet_UsersInRolesTableAdapter
        Dim dt As New DataSet3.aspnet_UsersInRolesDataTable
        Dim UId = UserIdTextBox.Text
        For i As Integer = 0 To RolesDataGridView.RowCount - 1
            Dim r As DataSet3.aspnet_RolesRow = DirectCast(RolesDataGridView.Rows(i).DataBoundItem.row, DataSet3.aspnet_RolesRow)
            If ta.IsAssociated(UId, r.RoleId) Then RolesDataGridView.Rows(i).Cells(0).Value = True
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Provjeri je li upisan Username
        If Me.UserNameTextBox.Text = "" Then
            MsgBox("Morate upisati korisničko ime !", MsgBoxStyle.Critical, "Pogreška !")
            Me.UserNameTextBox.Focus()
            Exit Sub
        End If

        'Samo za nove korisnike
        If ID = 0 Then

            'Provjeri postoji li već ovo korisničko ime
            Dim ta As New DataSet3TableAdapters.QueriesTableAdapter
            If ta.UserExists(Me.UserNameTextBox.Text) Then
                MsgBox("Ovo korisničko ime već postoji !", MsgBoxStyle.Critical, "Pogreška !")
                Me.UserNameTextBox.Focus()
                Exit Sub
            End If

            'Provjeri je li upisana lozinka, samo za nove korisnike
            If Me.PasswordTextBox.Text = "" Then
                MsgBox("Morate upisati lozinku !", MsgBoxStyle.Critical, "Pogreška !")
                Me.PasswordTextBox.Focus()
                Exit Sub
            End If

            'Provjeri jesu li obje lozinke iste
            If (ID = 0) Then
                If PasswordTextBox.Text <> PasswordTextBox1.Text Then
                    MsgBox("Lozinka i ponovljena lozinka moraju biti iste !", MsgBoxStyle.Critical, "Pogreška !")
                    Me.PasswordTextBox1.Focus()
                    Exit Sub
                End If
                Me.HashedPasswordTextBox.Text = SampleIIdentity.GetMd5Hash(Me.PasswordTextBox.Text)
            End If
        End If

        Me.Validate()
        Me.Aspnet_UsersBindingSource.EndEdit()
        Me.Aspnet_MembershipBindingSource.EndEdit()

        Me.Aspnet_MembershipTableAdapter.Update(Me.DataSet3.aspnet_Membership)
        Me.Aspnet_UsersTableAdapter.Update(Me.DataSet3.aspnet_Users)

        'Ažuriranje poveznica rola
        Dim UId = UserIdTextBox.Text
        For i As Integer = 0 To RolesDataGridView.RowCount - 1
            Dim r As DataSet3.aspnet_RolesRow = DirectCast(RolesDataGridView.Rows(i).DataBoundItem.Row, DataSet3.aspnet_RolesRow)
            Dim ta As New DataSet3TableAdapters.aspnet_UsersInRolesTableAdapter
            If Convert.ToBoolean(RolesDataGridView.Rows(i).Cells(0).Value) Then
                If ta.IsAssociated(UId, r.RoleId) = 0 Then
                    Dim uir_dt As New DataSet3.aspnet_UsersInRolesDataTable
                    Dim uir_r As DataSet3.aspnet_UsersInRolesRow
                    uir_r = uir_dt.Newaspnet_UsersInRolesRow
                    uir_r.UserId = UId
                    uir_r.RoleId = r.RoleId
                    uir_dt.Addaspnet_UsersInRolesRow(uir_r)
                    ta.Update(uir_dt)
                End If
            Else
                ta.DeleteQuery(UId, r.RoleId)
            End If
        Next


        Me.Close()
    End Sub
End Class