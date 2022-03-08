Public Class MultipleCheckBoxUserControl
    Property V As Integer = 0
    Property HSize As Integer = 240
    Property VSize As Integer = 20
    Property HOrientation As Boolean = True
    Property HStep As Integer = 40
    Property VStep As Integer = 20
    Property Num_Boxes As Integer = 3
    Property Show_Text As Boolean = True


    Public Delegate Sub MultipleCheckBoxEventHandler(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event CheckedStateChanged As MultipleCheckBoxEventHandler

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = HSize
        Me.Height = VSize


    End Sub

    Sub Postavi()
        Select Case V
            Case 0
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = True
            Case 1
                Me.CheckBox1.Checked = True
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = False
            Case 2
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = True
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = False
            Case 3
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = True
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = False
            Case 4
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = True
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = False
            Case 5
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = True
                Me.CheckBox6.Checked = False
            Case Else
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.CheckBox3.Checked = False
                Me.CheckBox4.Checked = False
                Me.CheckBox5.Checked = False
                Me.CheckBox6.Checked = False
        End Select

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox1.Checked Then
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            V = 1
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox2.Checked Then
            Me.CheckBox1.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            V = 2
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox3.Checked Then
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            V = 3
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox4.Checked Then
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox5.Checked = False
            V = 4
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox5.Checked Then
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            V = 5
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        V = 0
        If CheckBox1.Checked Then V = 1
        If CheckBox2.Checked Then V = 2
        If CheckBox3.Checked Then V = 3
        If CheckBox4.Checked Then V = 4
        If CheckBox5.Checked Then V = 5
        If CheckBox6.Checked Then V = 0
        If CheckBox6.Checked Then
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            V = 0
        End If
        RaiseEvent CheckedStateChanged(Me, e)
    End Sub
End Class
