<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operacijska_lista_tekst
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Indikacija_TextBox = New System.Windows.Forms.TextBox()
        Me.Operacija_TextBox = New System.Windows.Forms.TextBox()
        Me.Postupak_TextBox = New System.Windows.Forms.TextBox()
        Me.Dijagnoza_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INDIKACIJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OPERACIJA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "POSTUPAK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DIJAGNOZA"
        '
        'Indikacija_TextBox
        '
        Me.Indikacija_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Indikacija_TextBox.Location = New System.Drawing.Point(96, 13)
        Me.Indikacija_TextBox.Multiline = True
        Me.Indikacija_TextBox.Name = "Indikacija_TextBox"
        Me.Indikacija_TextBox.ReadOnly = True
        Me.Indikacija_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Indikacija_TextBox.Size = New System.Drawing.Size(871, 50)
        Me.Indikacija_TextBox.TabIndex = 4
        '
        'Operacija_TextBox
        '
        Me.Operacija_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Operacija_TextBox.Location = New System.Drawing.Point(97, 69)
        Me.Operacija_TextBox.Multiline = True
        Me.Operacija_TextBox.Name = "Operacija_TextBox"
        Me.Operacija_TextBox.ReadOnly = True
        Me.Operacija_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Operacija_TextBox.Size = New System.Drawing.Size(871, 84)
        Me.Operacija_TextBox.TabIndex = 5
        '
        'Postupak_TextBox
        '
        Me.Postupak_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Postupak_TextBox.Location = New System.Drawing.Point(97, 159)
        Me.Postupak_TextBox.Multiline = True
        Me.Postupak_TextBox.Name = "Postupak_TextBox"
        Me.Postupak_TextBox.ReadOnly = True
        Me.Postupak_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Postupak_TextBox.Size = New System.Drawing.Size(871, 268)
        Me.Postupak_TextBox.TabIndex = 6
        '
        'Dijagnoza_TextBox
        '
        Me.Dijagnoza_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Dijagnoza_TextBox.Location = New System.Drawing.Point(97, 433)
        Me.Dijagnoza_TextBox.Multiline = True
        Me.Dijagnoza_TextBox.Name = "Dijagnoza_TextBox"
        Me.Dijagnoza_TextBox.ReadOnly = True
        Me.Dijagnoza_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dijagnoza_TextBox.Size = New System.Drawing.Size(872, 84)
        Me.Dijagnoza_TextBox.TabIndex = 7
        '
        'Operacijska_lista_tekst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 529)
        Me.Controls.Add(Me.Dijagnoza_TextBox)
        Me.Controls.Add(Me.Postupak_TextBox)
        Me.Controls.Add(Me.Operacija_TextBox)
        Me.Controls.Add(Me.Indikacija_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Operacijska_lista_tekst"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operacijska lista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Indikacija_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Operacija_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Postupak_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dijagnoza_TextBox As System.Windows.Forms.TextBox
End Class
