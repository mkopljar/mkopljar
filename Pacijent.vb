Public Class Pacijent

    Public P As DataSet1.RegistarRow


    Public Sub New(p1 As DataSet1.RegistarRow)

        ' This call is required by the designer.
        InitializeComponent()
        P = p1
        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub Pacijent_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

        Generalije_Control1.R = P
        Generalije_Control1.Prikaz()


        Panel1.Visible = True
        Label1.Text = "Učitavam podatke o hospitalizacijama"
        Panel1.Refresh()
        BoravciGridView.DataSource = SQL2Škrlin.GetData_Boravci_by_RegistarskiBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o MKB nalazima"
        Panel1.Refresh()
        MKBNalaziGridView.DataSource = SQL2Škrlin.GetData_MKB_Nalazi_by_RegistarskiBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o operacijama"
        Panel1.Refresh()
        OperacijeGridView.DataSource = SQL2Škrlin.GetData_Operacije_by_RegistarskiBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o infekcijama"
        Panel1.Refresh()
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o CVK"
        Panel1.Refresh()
        CVKGridView.DataSource = CVKTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o urinarnim kateterima"
        Panel1.Refresh()
        UKGridView.DataSource = UKTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Label1.Text = "Učitavam podatke o mehaničkoj ventilaciji"
        Panel1.Refresh()
        MVGridView.DataSource = MVTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Panel1.Visible = False

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub OperacijeGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OperacijeGridView.CellDoubleClick
        Dim O As DataSet1.OperacijeRow

        Cursor.Current = Cursors.WaitCursor

        O = DirectCast(OperacijeGridView.SelectedRows(0).DataBoundItem.row, DataSet1.OperacijeRow)
        Dim f As New Skrlin.Operacija(P, O)
        f.ShowDialog()

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BoravciGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BoravciGridView.CellDoubleClick
        Dim M As DataSet1.BoravciRow

        Cursor.Current = Cursors.WaitCursor

        M = DirectCast(BoravciGridView.SelectedRows(0).DataBoundItem.row, DataSet1.BoravciRow)
        Dim f As New Skrlin.Boravak(P, M)
        f.ShowDialog()
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub InfekcijeGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles InfekcijeGridView.CellDoubleClick
        Dim i As DataSet2.InfekcijaRow

        i = DirectCast(InfekcijeGridView.SelectedRows(0).DataBoundItem.row, DataSet2.InfekcijaRow)
        Dim f As New Skrlin.Infekcija(P, i.MaticniBR, i.ID, False)
        f.ShowDialog()
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As DataSet2.InfekcijaRow
        If InfekcijeGridView.SelectedRows.Count = 0 Then Exit Sub
        i = DirectCast(InfekcijeGridView.SelectedRows(0).DataBoundItem.row, DataSet2.InfekcijaRow)

        If MsgBox("Želite li doista obrisati ovu infekciju ?", MsgBoxStyle.YesNo, "UPOZORENJE !") = MsgBoxResult.Yes Then
            InfekcijaTableAdapter.DeleteQuery(i.ID)
        End If
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)
    End Sub

    Private Sub MKBNalaziGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MKBNalaziGridView.CellDoubleClick
        Dim M As DataSet1.MKB_NalaziRow

        Cursor.Current = Cursors.WaitCursor

        M = DirectCast(MKBNalaziGridView.SelectedRows(0).DataBoundItem.row, DataSet1.MKB_NalaziRow)
        Dim f As New Skrlin.MKB_Nalaz(P, M)
        f.ShowDialog()

        Cursor.Current = Cursors.Default
    End Sub

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New Skrlin.CVK1(P, 0, True)
        f.ShowDialog()
        CVKGridView.DataSource = CVKTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub CVKGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CVKGridView.CellDoubleClick
        Dim c As DataSet4.CVKRow

        c = DirectCast(CVKGridView.SelectedRows(0).DataBoundItem.row, DataSet4.CVKRow)
        Dim f As New Skrlin.CVK1(P, c.ID, False)
        f.ShowDialog()
        CVKGridView.DataSource = CVKTableAdapter.GetDataByRBR(P.RegistarskiBR)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New Skrlin.UK(P, 0, True)
        f.ShowDialog()
        UKGridView.DataSource = UKTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub UKGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UKGridView.CellDoubleClick
        Dim c As DataSet4.UKRow
        c = DirectCast(UKGridView.SelectedRows(0).DataBoundItem.row, DataSet4.UKRow)
        Dim f As New Skrlin.UK(P, c.ID, False)
        f.ShowDialog()
        UKGridView.DataSource = UKTableAdapter.GetDataByRBR(P.RegistarskiBR)
    End Sub
    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Cursor.Current = Cursors.WaitCursor
        Dim f As New Skrlin.MV(P, 0, True)
        f.ShowDialog()
        MVGridView.DataSource = MVTableAdapter.GetDataByRBR(P.RegistarskiBR)
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub MVGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MVGridView.CellDoubleClick
        Dim c As DataSet4.MVRow
        c = DirectCast(MVGridView.SelectedRows(0).DataBoundItem.row, DataSet4.MVRow)
        Dim f As New Skrlin.MV(P, c.ID, False)
        f.ShowDialog()
        MVGridView.DataSource = MVTableAdapter.GetDataByRBR(P.RegistarskiBR)
    End Sub
End Class