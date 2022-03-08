Public Class Operacija
    Public R As DataSet1.RegistarRow
    Public OP As DataSet1.OperacijeRow
    Public O As DataSet1.Operacija_extRow


    Public Sub New(ByVal r1 As DataSet1.RegistarRow, ByVal op1 As DataSet1.OperacijeRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        R = r1
        OP = op1

    End Sub


    Private Sub Operacija_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet2.ASA' table. You can move, or remove it, as needed.
        Me.ASATableAdapter.Fill(Me.DataSet2.ASA)
        'TODO: This line of code loads data into the 'DataSet2.Vrste_Anestezije' table. You can move, or remove it, as needed.
        Me.Vrste_AnestezijeTableAdapter.Fill(Me.DataSet2.Vrste_Anestezije)
        'TODO: This line of code loads data into the 'DataSet2.Tipovi_Operacija' table. You can move, or remove it, as needed.
        Me.Tipovi_OperacijaTableAdapter.Fill(Me.DataSet2.Tipovi_Operacija)
        Dim novo As Boolean = False

        'TODO: This line of code loads data into the 'DataSet2.Operacija' table. You can move, or remove it, as needed.
        Me.OperacijaTableAdapter.FillByProtokolBR(Me.DataSet2.Operacija, OP.ProtokolBR, OP.MaticniBR)

        If Me.DataSet2.Operacija.Rows.Count = 0 Then
            Dim tr As DataSet2.OperacijaRow
            tr = DataSet2.Operacija.NewOperacijaRow
            Me.DataSet2.Operacija.AddOperacijaRow(tr)
            novo = True
        End If

        Generalije_Control1.R = R
        Generalije_Control1.Prikaz()

        'dohvati operacija_ext za protokol
        O = SQL2Škrlin.GetData_Operacija_ext_by_ProtokolBR(OP.ProtokolBR, OP.MaticniBR)


        'prepopuliranje podataka
        ProtokolBRTextBox.Text = O.ProtokolBR
        MaticniBRTextBox.Text = O.MaticniBR
        Datum_operacijeDateTimePicker.Value = O.Datum
        Hitna_operacijaCheckBox.Checked = O.HitnoDaNe

        Try
            Početak_operacijeDateTimePicker.Value = O.PocetakOperacije
        Catch ex As Exception
            Početak_operacijeDateTimePicker.Visible = False
        End Try

        Try
            Kraj_operacijeDateTimePicker.Value = O.KrajOperacije
        Catch ex As Exception
            Kraj_operacijeDateTimePicker.Visible = False
        End Try

        Try
            Trajanje_operacijeTextBox.Text = DateDiff(DateInterval.Minute, O.PocetakOperacije, O.KrajOperacije)
        Catch ex As Exception

        End Try
        OperaterTextBox.Text = O.Operater.ToUpper
        AsistentTextBox.Text = O.Asistent1.ToUpper
        InstrumentarkaTextBox.Text = O.Instrumentarka.ToUpper
        PostupciGridView.DataSource = SQL2Škrlin.GetData_DTS(O.ProtokolBR, O.MaticniBR)
        StacGridView.DataSource = SQL2Škrlin.GetData_STAC(O.ProtokolBR, O.MaticniBR)

        Konac_za_kožu_Label.Text = SQL2Škrlin.GetData_Materijal_Naziv_za_Šifru(Konac_za_kožuID.Text)
        Strano_tijelo_Label.Text = SQL2Škrlin.GetData_Materijal_Naziv_za_Šifru(Strano_tijeloID.Text)

        'If novo Then
        For i As Integer = 0 To StacGridView.RowCount - 1
            If StacGridView.Rows(i).Cells(1).Value.ToString.ToUpper.Contains("ERITROCIT") Then Intraop_transfuzijaCheckBox.Checked = True
            If StacGridView.Rows(i).Cells(1).Value.ToString.ToUpper.Contains("DREN") Then DrenCheckBox.Checked = True
        Next
        'End If

        For i As Integer = 0 To PostupciGridView.RowCount - 1
            If PostupciGridView.Rows(i).Cells(1).Value.ToString.ToUpper.Contains("OPĆA ANEST") Then VrstaAnestezijeComboBox.SelectedValue = "OET"
        Next

        MultipleCheckBoxUserControl1.Postavi()


        Cursor.Current = Cursors.Default
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Cursor.Current = Cursors.WaitCursor

        Me.Validate()
        Me.OperacijaBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DataSet2)
        Me.OperacijaTableAdapter.Update(Me.DataSet2.Operacija)

        Me.Close()
    End Sub

    
    Private Sub Button_Konac_za_kožu_Click(sender As Object, e As EventArgs) Handles Button_Konac_za_kožu.Click
        Dim dr As DataSet1.STACRow
        If StacGridView.SelectedRows.Count = 0 Then Exit Sub
        dr = DirectCast(StacGridView.SelectedRows(0).DataBoundItem.row, DataSet1.STACRow)
        Konac_za_kožuID.Text = dr.Sifra
        Konac_za_kožu_Label.Text = dr.NazivNezasticeni
    End Sub

    Private Sub Button_Strano_tijelo_Click(sender As Object, e As EventArgs) Handles Button_Strano_tijelo.Click
        Dim dr As DataSet1.STACRow
        If StacGridView.SelectedRows.Count = 0 Then Exit Sub
        dr = DirectCast(StacGridView.SelectedRows(0).DataBoundItem.row, DataSet1.STACRow)
        Strano_tijeloID.Text = dr.Sifra
        Strano_tijelo_Label.Text = dr.NazivNezasticeni
    End Sub

    Private Sub Konac_za_kožuID_TextChanged(sender As Object, e As EventArgs) Handles Konac_za_kožuID.TextChanged
        Konac_za_kožu_Label.Text = SQL2Škrlin.GetData_Materijal_Naziv_za_Šifru(Konac_za_kožuID.Text)
    End Sub

    Private Sub Strano_tijeloID_TextChanged(sender As Object, e As EventArgs) Handles Strano_tijeloID.TextChanged
        Strano_tijelo_Label.Text = SQL2Škrlin.GetData_Materijal_Naziv_za_Šifru(Strano_tijeloID.Text)
    End Sub

   
    Private Sub PostupciGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PostupciGridView.CellFormatting
        For Each dr As DataGridViewRow In PostupciGridView.Rows
            If (DirectCast(dr.DataBoundItem.row, DataSet1.DTSRow).Kirurški = 1) Then
                dr.DefaultCellStyle.ForeColor = Color.Black
            Else
                dr.DefaultCellStyle.ForeColor = Color.Red
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New Škrlin.Operacijska_lista_tekst(O.ProtokolBR, O.MaticniBR)
        f.ShowDialog()

    End Sub
End Class