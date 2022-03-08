Public Class MultipleCheckBoxUserControl
    Property V As Integer = 0
    Property HOrientation As Boolean = True
    Property HStep As Integer = 50
    Property VStep As Integer = 20
    Property Num_Boxes As Integer = 5
    Property Show_Text As Boolean = True
    Property Descriptors As String() = {"1", "2", "3", "4", "5"}



    Public Delegate Sub MultipleCheckBoxEventHandler(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event CheckedStateChanged As MultipleCheckBoxEventHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If HOrientation Then
            Me.Width = Num_Boxes * HStep + 10
            Me.Height = VStep
        Else
            Me.Width = HStep
            Me.Height = Num_Boxes * VStep + 2
        End If
        
        For i As Integer = 1 To Num_Boxes Step 1
            Dim c As New CheckBox
            Dim xy As New System.Drawing.Point
            Dim ss As New System.Drawing.Size
            ss.Width = HStep - 3
            ss.Height = VStep - 3
            c.Size = ss

            If Show_Text Then c.Text = Descriptors(i - 1) Else c.Text = ""
            If HOrientation Then
                xy.X = 5 + (i - 1) * HStep
                xy.Y = 0
            Else
                xy.X = 5
                xy.Y = 2 + (i - 1) * VStep
            End If
            c.Location = xy
            c.Checked = False
            c.Name = i.ToString
            c.Visible = True
            AddHandler c.Click, AddressOf Me.CheckedChanged
            Me.Controls.Add(c)
            c.Show()
        Next
    End Sub

    Sub Postavi()
        For i As Integer = 1 To Num_Boxes
            Dim c As CheckBox = Me.Controls.Find(i.ToString, False).First
            If V = c.Name Then c.Checked = True
        Next
    End Sub

    Sub CheckedChanged(sender As Object, e As EventArgs)
        Dim c As CheckBox
        c = sender
        For i As Integer = 1 To Num_Boxes
            If i <> c.Name Then CType(Me.Controls(i - 1), CheckBox).Checked = False
        Next
        CType(Me.Controls(CType(c.Name, Integer) - 1), CheckBox).Checked = c.Checked
        V = 0
        For i As Integer = 1 To Num_Boxes
            If CType(Me.Controls(i - 1), CheckBox).Checked = True Then V = i
        Next
        Dim e1 As New System.EventArgs
        RaiseEvent CheckedStateChanged(Me, e1)
    End Sub

   
End Class
