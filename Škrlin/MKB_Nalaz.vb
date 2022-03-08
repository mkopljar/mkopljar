Public Class MKB_Nalaz
    Dim R As DataSet1.RegistarRow
    Dim M As DataSet1.MKB_NalaziRow


    Public Sub New(ByVal r1 As DataSet1.RegistarRow, ByVal m1 As DataSet1.MKB_NalaziRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        R = r1
        M = m1
    End Sub


    Private Sub MKB_Nalaz_Load(sender As Object, e As EventArgs) Handles Me.Load

        Generalije_Control1.R = R
        Generalije_Control1.Prikaz()

        VrijemeVađenjaTextBox.Text = M.VrijemeVadjenja.ToLongDateString
        OdjelTextBox.Text = M.OdjelUputio
        UzorakTextBox.Text = M.Zahvat

        MKBNalazFullGridView.DataSource = SQL2Škrlin.GetData_MKBNalazFull(M.ID)

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class