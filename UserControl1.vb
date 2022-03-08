Public Class UserControl1
    Property R As Škrlin.DataSet1.RegistarRow


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.    
    End Sub

    Public Sub Pokazi()
        Label1.Text = R.PrezimeIme
        Label2.Text = R.RodjenDatum.ToShortDateString
        Label3.Text = R.Adresa
    End Sub

End Class
