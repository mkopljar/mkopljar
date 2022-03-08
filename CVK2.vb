Public Class CVK2
    Public P As DataSet1.RegistarRow
    Public Novi As Boolean
    Public CVK_ID As Integer
    Public Sub New(p1 As DataSet1.RegistarRow, c1 As Integer, n1 As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        P = p1
        CVK_ID = c1
        Novi = n1
    End Sub

    Private Sub CVK2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSet4.CVK' table. You can move, or remove it, as needed.
        Me.CVKTableAdapter.Fill(Me.DataSet4.CVK)


        Me.StartPosition = FormStartPosition.CenterScreen

        If Novi Then
            Dim tr As Skrlin.DataSet4.CVKRow
            tr = DataSet4.CVK.NewCVKRow
            DataSet4.CVK.AddCVKRow(tr)
            CVKTableAdapter.Update(DataSet4.CVK)
            'IDTextBox.Text = Me.InfekcijaTableAdapter.ScopeIdentity
            CVK_ID = IDTextBox.Text
            RegistarskiBRTextBox.Text = P.RegistarskiBR
        Else

        End If
        Me.CVKTableAdapter.FillByID(Me.DataSet4.CVK, CVK_ID)
        Cursor.Current = Cursors.Default

        Generalije_Control1.R = P
        Generalije_Control1.Prikaz()
    End Sub

    Private Sub CVKBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CVKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet4)

    End Sub

    Private Sub CVKBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CVKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet4)

    End Sub
End Class