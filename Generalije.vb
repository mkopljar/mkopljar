Public Class Generalije

    Dim R As DataSet1.RegistarRow

    Public Sub New(ByVal r1 As DataSet1.RegistarRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        R = r1
    End Sub



    Private Sub Generalije_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = R.PrezimeIme
        Label2.Text = R.RodjenDatum
        Label3.Text = R.Adresa
    End Sub
End Class