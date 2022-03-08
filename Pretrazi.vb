
Public Class Pretrazi
    Public D As DataSet
    Public C() As String
    Public indeks As String
    Public odabir As String

    Public Sub New(ByVal d1 As Type, ByVal c1() As String, ByVal i1 As String, ByRef i2 As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        D = System.Activator.CreateInstance(d1)

        C = c1
        indeks = i1
        odabir = i2


    End Sub

    Private Sub Pretrazi_Load(sender As Object, e As EventArgs) Handles Me.Load

        DataGridView1.DataSource = D
        Dim i As Integer
        For i = 0 To DataGridView1.Columns.Count - 1
            If C.Contains(DataGridView1.Columns(i).Name) Then
                DataGridView1.Columns(i).Visible = True
            Else
                DataGridView1.Columns(i).Visible = False
            End If
        Next
        DataGridView1.Columns(indeks).Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        odabir = ""
        If DataGridView1.SelectedRows.Count > 0 Then odabir = DataGridView1.SelectedRows(0).Cells(indeks).Value
        Me.Close()
    End Sub
End Class