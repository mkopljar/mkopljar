Public Class Pacijent

    Public P As DataSet1.RegistarRow


    Public Sub New(p1 As DataSet1.RegistarRow)

        ' This call is required by the designer.
        InitializeComponent()
        P = p1
        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub Pacijent_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet1.Maticni' table. You can move, or remove it, as needed.

        Me.WindowState = FormWindowState.Maximized

        Generalije_Control1.R = P
        Generalije_Control1.Prikaz()

        BoravciGridView.DataSource = SQL2Škrlin.GetData_Boravci_by_RegistarskiBR(P.RegistarskiBR)
        MKBNalaziGridView.DataSource = SQL2Škrlin.GetData_MKB_Nalazi_by_RegistarskiBR(P.RegistarskiBR)
        OperacijeGridView.DataSource = SQL2Škrlin.GetData_Operacije_by_RegistarskiBR(P.RegistarskiBR)
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub OperacijeGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OperacijeGridView.CellDoubleClick
        Dim O As DataSet1.OperacijeRow

        Cursor.Current = Cursors.WaitCursor

        O = DirectCast(OperacijeGridView.SelectedRows(0).DataBoundItem.row, DataSet1.OperacijeRow)
        Dim f As New Škrlin.Operacija(P, O)
        f.ShowDialog()

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub BoravciGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BoravciGridView.CellDoubleClick
        Dim M As DataSet1.BoravciRow

        Cursor.Current = Cursors.WaitCursor

        M = DirectCast(BoravciGridView.SelectedRows(0).DataBoundItem.row, DataSet1.BoravciRow)
        Dim f As New Škrlin.Boravak(P, M)
        f.ShowDialog()
        InfekcijeGridView.DataSource = InfekcijaTableAdapter.GetDatabyRegistarskiBR(P.RegistarskiBR)
        Cursor.Current = Cursors.Default
    End Sub

    
    Private Sub InfekcijeGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles InfekcijeGridView.CellDoubleClick
        Dim i As DataSet2.InfekcijaRow

        i = DirectCast(InfekcijeGridView.SelectedRows(0).DataBoundItem.row, DataSet2.InfekcijaRow)
        Dim f As New Škrlin.Infekcija(P, i.MaticniBR, i.ID, False)
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
        Dim f As New Škrlin.MKB_Nalaz(P, M)
        f.ShowDialog()

        Cursor.Current = Cursors.Default
    End Sub
End Class