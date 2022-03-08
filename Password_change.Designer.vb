<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password_change
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Old_Pass_TextBox = New System.Windows.Forms.TextBox()
        Me.New_Pass_TextBox1 = New System.Windows.Forms.TextBox()
        Me.New_Pass_TextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Korisnik:"
        '
        'User_label
        '
        Me.User_label.AutoSize = True
        Me.User_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.User_label.Location = New System.Drawing.Point(66, 13)
        Me.User_label.Name = "User_label"
        Me.User_label.Size = New System.Drawing.Size(0, 13)
        Me.User_label.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stara lozinka:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nova lozinka:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ponovite novu lozinku:"
        '
        'Old_Pass_TextBox
        '
        Me.Old_Pass_TextBox.Location = New System.Drawing.Point(142, 55)
        Me.Old_Pass_TextBox.Name = "Old_Pass_TextBox"
        Me.Old_Pass_TextBox.Size = New System.Drawing.Size(214, 20)
        Me.Old_Pass_TextBox.TabIndex = 5
        '
        'New_Pass_TextBox1
        '
        Me.New_Pass_TextBox1.Location = New System.Drawing.Point(142, 135)
        Me.New_Pass_TextBox1.Name = "New_Pass_TextBox1"
        Me.New_Pass_TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.New_Pass_TextBox1.TabIndex = 6
        '
        'New_Pass_TextBox
        '
        Me.New_Pass_TextBox.Location = New System.Drawing.Point(142, 96)
        Me.New_Pass_TextBox.Name = "New_Pass_TextBox"
        Me.New_Pass_TextBox.Size = New System.Drawing.Size(214, 20)
        Me.New_Pass_TextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Image = Global.Skrlin.My.Resources.Resources.password_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Zapamti"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Skrlin.My.Resources.Resources.Icon_Exit1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(256, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Odustani"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Password_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.New_Pass_TextBox)
        Me.Controls.Add(Me.New_Pass_TextBox1)
        Me.Controls.Add(Me.Old_Pass_TextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.User_label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Password_change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promjena lozinke"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents User_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Old_Pass_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents New_Pass_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents New_Pass_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
