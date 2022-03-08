Imports Skrlin.SQL2Škrlin

Public Class Prikaz_Radilista
    Public N As DataSet1.NeotpusteniRow
    Public P As DataSet1.RegistarRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Prikaz_Radilista_Load(sender As Object, e As EventArgs) Handles Me.Load
        
        'TODO: This line of code loads data into the 'DataSet1.Neotpusteni' table. You can move, or remove it, as needed.
        Me.NeotpusteniTableAdapter.Fill(Me.DataSet1.Neotpusteni)

        Me.RadilisteTableAdapter.Fill(Me.DataSet1.Radiliste)
        Me.WindowState = FormWindowState.Maximized
        Panel1.Height = Me.Height - 4


        If My.User.IsInRole("Admin") Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If

        Dim ta As New DataSet5TableAdapters.aspnet_UsersTableAdapter
        Dim dt As New DataSet5.aspnet_UsersDataTable
        Dim dr As DataSet5.aspnet_UsersRow
        dt = ta.GetDataByUserName(My.User.Name)
        If dt.Rows.Count = 0 Then Exit Sub
        dr = dt(0)

        Dim taR As New DataSet5TableAdapters.RadilisteTableAdapter
        Dim dtR As DataSet5.RadilisteDataTable
        Dim taUR As New DataSet5TableAdapters.UserRadilisteTableAdapter
        Dim dtUR As New DataSet5.UserRadilisteDataTable
        dtR = taR.GetData
        dtUR = taUR.GetDataByUserId(dr.UserId)

        'Provjeri je li može pristupiti svim radilištima
        If dr.Moze_mijenjati_radiliste Then     'Ako ima pristup svim radilištima, napiuni ComboBox1 popisom svih radilista
            ComboBox1.DataSource = dtR
            ComboBox1.DisplayMember = "Naziv"
            ComboBox1.ValueMember = "ID"
        Else                                    'Napuni ComboBox1 sa vrijednostima iz tablice UserRadiliste
            dtR.Clear()
            For i As Integer = 0 To dtUR.Rows.Count - 1
                Dim r1 As DataSet5.RadilisteRow
                Dim dtr1 As New DataSet5.RadilisteDataTable
                dtr1 = taR.GetDataByID(dtUR(i).radiliste)
                r1 = dtr1(0)
                Try
                    dtR.ImportRow(r1)
                Catch ex As Exception

                End Try

            Next
            ComboBox1.DataSource = dtR
            ComboBox1.DisplayMember = "Naziv"
            ComboBox1.ValueMember = "ID"
        End If
        'Postavi defaultno radilište
        If dr.Pocetno_radiliste <> Nothing Then ComboBox1.SelectedValue = dr.Pocetno_radiliste



        'dio starog koda. 
        'If dr.Moze_mijenjati_radiliste Then
        'ComboBox1.Enabled = True
        'Else
        'ComboBox1.Enabled = False
        'End If

        Me.Text = Me.Text + " - Korisnik: " + dr.Ime + " " + dr.Prezime


        Me.NeotpusteniTableAdapter.FillByRadilisteID(Me.DataSet1.Neotpusteni, ComboBox1.SelectedValue)
        If Me.DataSet1.Neotpusteni.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

        DateTimePicker1.Value = Today

        Osvjezi_panel2()



    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Cursor.Current = Cursors.WaitCursor
        N = DirectCast(DataGridView1.SelectedRows(0).DataBoundItem.row, DataSet1.NeotpusteniRow)
        'MsgBox(P.RegistarskiBR)

        Dim dt As New Skrlin.DataSet1.RegistarDataTable
        dt = GetData_Registar_by_RegistarskiBR(N.RegistarskiBR)
        P = dt(0)
        Dim f As New Pacijent(P)
        f.ShowDialog()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.NeotpusteniTableAdapter.FillByRadilisteID(Me.DataSet1.Neotpusteni, ComboBox1.SelectedValue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.User.CurrentPrincipal = Nothing
        Dim f As New Skrlin.LoginForm1
        f.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Skrlin.Form1
        f.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Skrlin.Admin_panel
        f.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.NeotpusteniTableAdapter.FillByRadilisteID(Me.DataSet1.Neotpusteni, ComboBox1.SelectedValue)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (Not N Is Nothing) Then Osvjezi_panel2()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Osvjezi_panel2()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        StatusiBindingSource.EndEdit()
        StatusiTableAdapter.Update(Me.DataSet5.Statusi)
        Osvjezi_panel2()

    End Sub

    Private Sub Osvjezi_panel2()
        Dim d As String
        d = DateTimePicker1.Value.ToString("dd.MM.yyyy")
        N = DirectCast(DataGridView1.SelectedRows(0).DataBoundItem.row, DataSet1.NeotpusteniRow)
        StatusiTableAdapter.FillByRBRDatum(Me.DataSet5.Statusi, N.RegistarskiBR, DateTimePicker1.Value.ToShortDateString)
        If Me.DataSet5.Statusi.Rows.Count = 0 Then StatusiBindingSource.AddNew()
        'StatusiBindingSource.DataSource = Me.DataSet5.Statusi
        PacijentRBRTextBox.Text = N.RegistarskiBR
        TextBox1.Text = DateTimePicker1.Text
        RadilišteTextBox.Text = ComboBox1.SelectedValue

        'VitalniGridView.DataSource = SQL2Škrlin.GetData_Vitalni_by_RBRDatum(N.RegistarskiBR, d)

    End Sub

    
    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f As New Skrlin.Password_change
        f.ShowDialog()
    End Sub
End Class