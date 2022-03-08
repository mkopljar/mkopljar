<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MKB_Nalaz
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
        Me.components = New System.ComponentModel.Container()
        Me.Generalije_Control1 = New Škrlin.Generalije_Control()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VrijemeVađenjaTextBox = New System.Windows.Forms.TextBox()
        Me.OdjelTextBox = New System.Windows.Forms.TextBox()
        Me.UzorakTextBox = New System.Windows.Forms.TextBox()
        Me.MKBNalazFullGridView = New System.Windows.Forms.DataGridView()
        Me.UzrocnikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OsjetljivostIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LijekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KomentarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MKBFullBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Škrlin.DataSet1()
        Me.MKB_FullTableAdapter = New Škrlin.DataSet1TableAdapters.MKB_FullTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MKBNalazFullGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MKBFullBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generalije_Control1
        '
        Me.Generalije_Control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Generalije_Control1.Location = New System.Drawing.Point(13, 13)
        Me.Generalije_Control1.Name = "Generalije_Control1"
        Me.Generalije_Control1.R = Nothing
        Me.Generalije_Control1.Size = New System.Drawing.Size(495, 71)
        Me.Generalije_Control1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vrijeme vađenja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Odjel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Uzorak"
        '
        'VrijemeVađenjaTextBox
        '
        Me.VrijemeVađenjaTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.VrijemeVađenjaTextBox.Location = New System.Drawing.Point(101, 103)
        Me.VrijemeVađenjaTextBox.Name = "VrijemeVađenjaTextBox"
        Me.VrijemeVađenjaTextBox.ReadOnly = True
        Me.VrijemeVađenjaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeVađenjaTextBox.TabIndex = 4
        '
        'OdjelTextBox
        '
        Me.OdjelTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.OdjelTextBox.Location = New System.Drawing.Point(259, 103)
        Me.OdjelTextBox.Name = "OdjelTextBox"
        Me.OdjelTextBox.ReadOnly = True
        Me.OdjelTextBox.Size = New System.Drawing.Size(264, 20)
        Me.OdjelTextBox.TabIndex = 5
        '
        'UzorakTextBox
        '
        Me.UzorakTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.UzorakTextBox.Location = New System.Drawing.Point(588, 103)
        Me.UzorakTextBox.Name = "UzorakTextBox"
        Me.UzorakTextBox.ReadOnly = True
        Me.UzorakTextBox.Size = New System.Drawing.Size(348, 20)
        Me.UzorakTextBox.TabIndex = 6
        '
        'MKBNalazFullGridView
        '
        Me.MKBNalazFullGridView.AllowUserToAddRows = False
        Me.MKBNalazFullGridView.AllowUserToDeleteRows = False
        Me.MKBNalazFullGridView.AllowUserToResizeRows = False
        Me.MKBNalazFullGridView.AutoGenerateColumns = False
        Me.MKBNalazFullGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MKBNalazFullGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UzrocnikDataGridViewTextBoxColumn, Me.OsjetljivostIDDataGridViewTextBoxColumn, Me.LijekDataGridViewTextBoxColumn, Me.KomentarDataGridViewTextBoxColumn})
        Me.MKBNalazFullGridView.DataSource = Me.MKBFullBindingSource
        Me.MKBNalazFullGridView.Location = New System.Drawing.Point(15, 142)
        Me.MKBNalazFullGridView.Name = "MKBNalazFullGridView"
        Me.MKBNalazFullGridView.ReadOnly = True
        Me.MKBNalazFullGridView.RowHeadersVisible = False
        Me.MKBNalazFullGridView.Size = New System.Drawing.Size(921, 295)
        Me.MKBNalazFullGridView.TabIndex = 7
        '
        'UzrocnikDataGridViewTextBoxColumn
        '
        Me.UzrocnikDataGridViewTextBoxColumn.DataPropertyName = "Uzrocnik"
        Me.UzrocnikDataGridViewTextBoxColumn.HeaderText = "Uzrocnik"
        Me.UzrocnikDataGridViewTextBoxColumn.Name = "UzrocnikDataGridViewTextBoxColumn"
        Me.UzrocnikDataGridViewTextBoxColumn.ReadOnly = True
        Me.UzrocnikDataGridViewTextBoxColumn.Width = 200
        '
        'OsjetljivostIDDataGridViewTextBoxColumn
        '
        Me.OsjetljivostIDDataGridViewTextBoxColumn.DataPropertyName = "OsjetljivostID"
        Me.OsjetljivostIDDataGridViewTextBoxColumn.HeaderText = "Osjetljivost"
        Me.OsjetljivostIDDataGridViewTextBoxColumn.Name = "OsjetljivostIDDataGridViewTextBoxColumn"
        Me.OsjetljivostIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OsjetljivostIDDataGridViewTextBoxColumn.Width = 75
        '
        'LijekDataGridViewTextBoxColumn
        '
        Me.LijekDataGridViewTextBoxColumn.DataPropertyName = "Lijek"
        Me.LijekDataGridViewTextBoxColumn.HeaderText = "Lijek"
        Me.LijekDataGridViewTextBoxColumn.Name = "LijekDataGridViewTextBoxColumn"
        Me.LijekDataGridViewTextBoxColumn.ReadOnly = True
        Me.LijekDataGridViewTextBoxColumn.Width = 150
        '
        'KomentarDataGridViewTextBoxColumn
        '
        Me.KomentarDataGridViewTextBoxColumn.DataPropertyName = "Komentar"
        Me.KomentarDataGridViewTextBoxColumn.HeaderText = "Komentar"
        Me.KomentarDataGridViewTextBoxColumn.Name = "KomentarDataGridViewTextBoxColumn"
        Me.KomentarDataGridViewTextBoxColumn.ReadOnly = True
        Me.KomentarDataGridViewTextBoxColumn.Width = 400
        '
        'MKBFullBindingSource
        '
        Me.MKBFullBindingSource.DataMember = "MKB_Full"
        Me.MKBFullBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MKB_FullTableAdapter
        '
        Me.MKB_FullTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Škrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(942, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Izlaz"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MKB_Nalaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MKBNalazFullGridView)
        Me.Controls.Add(Me.UzorakTextBox)
        Me.Controls.Add(Me.OdjelTextBox)
        Me.Controls.Add(Me.VrijemeVađenjaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Name = "MKB_Nalaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MKB Nalaz"
        CType(Me.MKBNalazFullGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MKBFullBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Generalije_Control1 As Škrlin.Generalije_Control
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VrijemeVađenjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OdjelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UzorakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MKBNalazFullGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UzrocnikDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OsjetljivostIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LijekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KomentarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MKBFullBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Škrlin.DataSet1
    Friend WithEvents MKB_FullTableAdapter As Škrlin.DataSet1TableAdapters.MKB_FullTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
