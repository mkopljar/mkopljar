Public Class Boravak
    Public R As DataSet1.RegistarRow
    Public M As DataSet1.BoravciRow


    Private Sub Boravak_Load(sender As Object, e As EventArgs) Handles Me.Load
        
        'TODO: This line of code loads data into the 'DataSet2.Boravci' table. You can move, or remove it, as needed.

        Me.BoravciTableAdapter.FillByMB(Me.DataSet2.Boravci, M.MaticniBR)


        If Me.DataSet2.Boravci.Rows.Count = 0 Then
            Dim tr As DataSet2.BoravciRow
            tr = DataSet2.Boravci.NewBoravciRow
            Me.DataSet2.Boravci.AddBoravciRow(tr)

        End If

        Generalije_Control1.R = R
        Generalije_Control1.Prikaz()

        'Prepopuliranje podataka

        Broj_pov_bolTextBox.Text = M.MaticniBR
        Datum_prijemaDateTimePicker.Value = M.DatumPrijema
        Hitni_prijemCheckBox.Checked = (M.PHitni = 1)
        OdjelTextBox.Text = M.OdjelNaziv

        Try
            Dijagnoza_prijem_MKBTextBox.Text = M.ZavrsnaDijagnozaSifra
            Dijagnoza_prijemTextBox.Text = M.ZavrsnaDijagnozaNaziv.ToString
            Vrsta_otpustaTextBox.Text = M.StanjeOtpustaNaziv.ToString
        Catch ex As Exception
        End Try

        Try
            Datum_otpustaDateTimePicker.Value = M.DatumOtpusta
        Catch ex As Exception
            Datum_otpustaDateTimePicker.Visible = False
        End Try

        If Dijagnoza_prijem_MKBTextBox.Text = "" Then Dijagnoza_prijem_MKBTextBox.Text = M.UputnaDijagnozaSifra
        If Dijagnoza_prijemTextBox.Text = "" Then Dijagnoza_prijemTextBox.Text = M.UputnaDijagnozaNaziv

        Cursor.Current = Cursors.Default
        'Ishod_lijecenjaTextBox .Text = M.

    End Sub

    Public Sub New(ByVal R1 As DataSet1.RegistarRow, ByVal M1 As DataSet1.BoravciRow)

        ' This call is required by the designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.
        R = R1
        M = M1

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.BoravciBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DataSet2)
        Me.BoravciTableAdapter.Update(Me.DataSet2.Boravci)

        Me.Close()
    End Sub


    Private Sub Dodaj_infekciju_Click(sender As Object, e As EventArgs) Handles Dodaj_infekciju.Click
        Dim f As New Infekcija(R, M.MaticniBR, 0, True)
        f.ShowDialog()
    End Sub
End Class