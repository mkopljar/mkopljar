Public Class Generalije_Control
    Property R As Škrlin.DataSet1.RegistarRow

    Sub Prikaz()
        Label1.Text = R.PrezimeIme
        Label2.Text = R.RodjenDatum.ToShortDateString
        Label3.Text = R.Adresa
    End Sub

End Class
