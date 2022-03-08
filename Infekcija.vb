Public Class Infekcija
    Public R As DataSet1.RegistarRow
    Public M As String
    Public Novi As Boolean
    Public InfekcijaID As Integer


    Public Sub New(ByVal R1 As DataSet1.RegistarRow, ByVal M1 As String, ByVal i As Integer, ByVal Novi1 As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        R = R1
        M = M1
        Novi = Novi1
        InfekcijaID = i
    End Sub


    Private Sub Infekcija_Load(sender As Object, e As EventArgs) Handles Me.Load
        
        Me.Vrste_InfekcijeTableAdapter.Fill(Me.DataSet2.Vrste_Infekcije)
        'TODO: This line of code loads data into the 'DataSet2.Vrste_Infekcije' table. You can move, or remove it, as needed.

        If Novi Then
            Dim tr As DataSet2.InfekcijaRow
            tr = DataSet2.Infekcija.NewInfekcijaRow
            Me.DataSet2.Infekcija.AddInfekcijaRow(tr)
            Me.InfekcijaTableAdapter.Update(Me.DataSet2.Infekcija)
            'IDTextBox.Text = Me.InfekcijaTableAdapter.ScopeIdentity
            InfekcijaID = IDTextBox.Text
            RegistarskiBRTextBox.Text = R.RegistarskiBR
            MaticniBRTextBox.Text = M
        Else
            Me.InfekcijaTableAdapter.FillByID(Me.DataSet2.Infekcija, InfekcijaID)
        End If

        Generalije_Control1.R = R
        Generalije_Control1.Prikaz()

        TabControl1.SelectTab(0)
        OperacijeGridView.DataSource = SQL2Škrlin.GetData_Operacije_by_RegistarskiBR(R.RegistarskiBR)
        For i As Integer = 0 To OperacijeGridView.RowCount - 1
            Dim o As DataSet1.OperacijeRow = DirectCast(OperacijeGridView.Rows(i).DataBoundItem.Row, DataSet1.OperacijeRow)
            Dim io As New DataSet2TableAdapters.Infekcija_OperacijaTableAdapter
            If io.Operacija_is_associated(InfekcijaID, o.ProtokolBR, o.MaticniBR) > 0 Then
                Me.OperacijeGridView.Rows(i).Cells(0).Value = True
            End If
        Next

        TabControl1.SelectTab(1)
        MKBNalazGridViewX.DataSource = SQL2Škrlin.GetData_MKB_Nalazi_by_RegistarskiBR(R.RegistarskiBR)
        For i As Integer = 0 To MKBNalazGridViewX.RowCount - 1
            Dim o As DataSet1.MKB_NalaziRow = DirectCast(MKBNalazGridViewX.Rows(i).DataBoundItem.Row, DataSet1.MKB_NalaziRow)
            Dim io As New DataSet2TableAdapters.Infekcija_MKBTableAdapter
            If io.MKB_is_associated(InfekcijaID, o.ID) > 0 Then
                Me.MKBNalazGridViewX.Rows(i).Cells(0).Value = True
            End If
        Next

        TabControl1.SelectTab(0)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Zatvaranje i savanje
        Me.Validate()
        Me.InfekcijaBindingSource.EndEdit()
        Me.InfekcijaTableAdapter.Update(Me.DataSet2.Infekcija)

        'ažuriranje povezanih operacija
        For i As Integer = 0 To OperacijeGridView.RowCount - 1
            Dim o As DataSet1.OperacijeRow = DirectCast(OperacijeGridView.Rows(i).DataBoundItem.Row, DataSet1.OperacijeRow)
            Dim io As New DataSet2TableAdapters.Infekcija_OperacijaTableAdapter

            If Convert.ToBoolean(OperacijeGridView.Rows(i).Cells(0).Value) Then
                If io.Operacija_is_associated(InfekcijaID, o.ProtokolBR, o.MaticniBR) = 0 Then
                    Dim iodt As New DataSet2.Infekcija_OperacijaDataTable
                    Dim ior As DataSet2.Infekcija_OperacijaRow
                    ior = iodt.NewInfekcija_OperacijaRow
                    ior.InfekcijaID = InfekcijaID
                    ior.ProtokolBR = o.ProtokolBR
                    ior.MaticniBR = o.MaticniBR
                    iodt.AddInfekcija_OperacijaRow(ior)
                    io.Update(iodt)
                End If
            Else
                io.DeleteQuery(InfekcijaID, o.ProtokolBR, o.MaticniBR)
            End If
        Next

        'ažuriranje povezanih MKB nalaza
        For i As Integer = 0 To MKBNalazGridViewX.RowCount - 1
            Dim o As DataSet1.MKB_NalaziRow = DirectCast(MKBNalazGridViewX.Rows(i).DataBoundItem.Row, DataSet1.MKB_NalaziRow)
            Dim io As New DataSet2TableAdapters.Infekcija_MKBTableAdapter

            If Convert.ToBoolean(MKBNalazGridViewX.Rows(i).Cells(0).Value) Then
                If io.MKB_is_associated(InfekcijaID, o.ID) = 0 Then
                    Dim iodt As New DataSet2.Infekcija_MKBDataTable
                    Dim ior As DataSet2.Infekcija_MKBRow
                    ior = iodt.NewInfekcija_MKBRow
                    ior.InfekcijaID = InfekcijaID
                    ior.MKB_NalazID = o.ID
                    iodt.AddInfekcija_MKBRow(ior)
                    io.Update(iodt)
                End If
            Else
                io.DeleteQuery(InfekcijaID, o.ID)
            End If
        Next


        Me.Close()

    End Sub

    Private Sub OperacijeGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OperacijeGridView.CellDoubleClick
        Dim op As DataSet1.OperacijeRow
        op = DirectCast(OperacijeGridView.SelectedRows(0).DataBoundItem.Row, DataSet1.OperacijeRow)
        Dim f As New Skrlin.Operacija(R, op)
        Cursor.Current = Cursors.WaitCursor
        f.ShowDialog()
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub MKBNalazGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MKBNalazGridViewX.CellDoubleClick
        Dim m As DataSet1.MKB_NalaziRow
        m = DirectCast(MKBNalazGridViewX.SelectedRows(0).DataBoundItem.Row, DataSet1.MKB_NalaziRow)
        Dim f As New Skrlin.MKB_Nalaz(R, m)
        Cursor.Current = Cursors.WaitCursor
        f.ShowDialog()
        Cursor.Current = Cursors.Default
    End Sub

   
    
End Class