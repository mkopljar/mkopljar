Public Class MV
    Public P As DataSet1.RegistarRow
    Public Novi As Boolean
    Public MV_ID As Integer

    Public Radilista As DataSet5.RadilisteDataTable

    Public Sub New(p1 As DataSet1.RegistarRow, c1 As Integer, n1 As Boolean)

        ' This call is required by the designer.
        InitializeComponent()
        P = p1
        MV_ID = c1
        Novi = n1
        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub MV_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet4.MV' table. You can move, or remove it, as needed.
        Me.MVTableAdapter.Fill(Me.DataSet4.MV)

        Radilista = SQL2Škrlin.GetData_Radilista5
        ComboBox1.DataSource = Radilista
        ComboBox1.DisplayMember = "Naziv"
        ComboBox1.ValueMember = "ID"


        If Novi Then
            'Dim tr As Skrlin.DataSet4.MVRow
            'tr = DataSet4.MV.NewMVRow
            'DataSet4.MV.AddMVRow(tr)
            'MVTableAdapter.Update(DataSet4.MV)
            MVBindingSource.AddNew()
            'IDTextBox.Text = Me.InfekcijaTableAdapter.ScopeIdentity
            MV_ID = IDTextBox.Text
            RegistarskiBRTextBox.Text = P.RegistarskiBR
        Else
            Me.MVTableAdapter.FillByID(Me.DataSet4.MV, MV_ID)
        End If

        Cursor.Current = Cursors.Default

        Generalije_Control1.R = P
        Generalije_Control1.Prikaz()
        If (RadilišteTextBox.Text <> "") Then ComboBox1.SelectedValue = RadilišteTextBox.Text

    End Sub



    Private Sub Zapamti_Click(sender As Object, e As EventArgs) Handles Zapamti.Click
        Me.Validate()
        Me.MVBindingSource.EndEdit()
        MVTableAdapter.Update(Me.DataSet4.MV)
    End Sub

    Private Sub Povratak_Click(sender As Object, e As EventArgs) Handles Povratak.Click
        'Me.Validate()
        'Me.MVBindingSource.EndEdit()
        'MVTableAdapter.Update(Me.DataSet4.MV)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Datum_stavljanjaTextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Datum_vađenjaTextBox.Text = ""
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Datum_stavljanjaTextBox.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Datum_vađenjaTextBox.Text = DateTimePicker2.Value.ToShortDateString
    End Sub


    Private Sub RadilišteTextBox_DoubleClick(sender As Object, e As EventArgs) Handles RadilišteTextBox.DoubleClick
        Dim s() As String = {"Naziv", "NazivDugi"}
        Dim indeks As String = "ID"
        Dim odabir As String = ""
        Dim f As New Pretrazi(GetType(DataSet5.RadilisteDataTable), s, indeks, odabir)
        f.ShowDialog()
        RadilišteTextBox.Text = odabir

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RadilišteTextBox.Text = ComboBox1.SelectedValue.ToString
        Radiliste_tekstTextBox.Text = ComboBox1.Text
    End Sub


End Class