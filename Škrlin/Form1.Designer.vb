<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegistarskiBRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezimeImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RodjenDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OIBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Škrlin.DataSet1()
        Me.RegistarTableAdapter = New Škrlin.DataSet1TableAdapters.RegistarTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(13, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegistarskiBRDataGridViewTextBoxColumn, Me.PrezimeImeDataGridViewTextBoxColumn, Me.RodjenDatumDataGridViewTextBoxColumn, Me.AdresaDataGridViewTextBoxColumn, Me.OIBDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(732, 343)
        Me.DataGridView1.TabIndex = 2
        '
        'RegistarskiBRDataGridViewTextBoxColumn
        '
        Me.RegistarskiBRDataGridViewTextBoxColumn.DataPropertyName = "RegistarskiBR"
        Me.RegistarskiBRDataGridViewTextBoxColumn.HeaderText = "RegistarskiBR"
        Me.RegistarskiBRDataGridViewTextBoxColumn.Name = "RegistarskiBRDataGridViewTextBoxColumn"
        Me.RegistarskiBRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezimeImeDataGridViewTextBoxColumn
        '
        Me.PrezimeImeDataGridViewTextBoxColumn.DataPropertyName = "PrezimeIme"
        Me.PrezimeImeDataGridViewTextBoxColumn.HeaderText = "Prezime i ime"
        Me.PrezimeImeDataGridViewTextBoxColumn.Name = "PrezimeImeDataGridViewTextBoxColumn"
        Me.PrezimeImeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrezimeImeDataGridViewTextBoxColumn.Width = 200
        '
        'RodjenDatumDataGridViewTextBoxColumn
        '
        Me.RodjenDatumDataGridViewTextBoxColumn.DataPropertyName = "RodjenDatum"
        Me.RodjenDatumDataGridViewTextBoxColumn.HeaderText = "Datum rođenja"
        Me.RodjenDatumDataGridViewTextBoxColumn.Name = "RodjenDatumDataGridViewTextBoxColumn"
        Me.RodjenDatumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdresaDataGridViewTextBoxColumn
        '
        Me.AdresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn.HeaderText = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn.Name = "AdresaDataGridViewTextBoxColumn"
        Me.AdresaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdresaDataGridViewTextBoxColumn.Width = 200
        '
        'OIBDataGridViewTextBoxColumn
        '
        Me.OIBDataGridViewTextBoxColumn.DataPropertyName = "OIB"
        Me.OIBDataGridViewTextBoxColumn.HeaderText = "OIB"
        Me.OIBDataGridViewTextBoxColumn.Name = "OIBDataGridViewTextBoxColumn"
        Me.OIBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegistarBindingSource
        '
        Me.RegistarBindingSource.DataMember = "Registar"
        Me.RegistarBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistarTableAdapter
        '
        Me.RegistarTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Škrlin.My.Resources.Resources.search_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(216, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Traži"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Škrlin.My.Resources.Resources.signout_icon
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(750, 360)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 35)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Odjava"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Škrlin.My.Resources.Resources.password_icon
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(750, 319)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 35)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Lozinka"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Škrlin.My.Resources.Resources.Settings
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(750, 278)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 35)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Postavke"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Škrlin.My.Resources.Resources.Profile_icon
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(750, 237)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 35)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Profil"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Škrlin.My.Resources.Resources.mirth_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(750, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Mirth"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Škrlin.My.Resources.Resources.Database_icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(750, 155)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Baza"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Škrlin.My.Resources.Resources.Users_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(750, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Korisnici"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Škrlin.My.Resources.Resources.Icon_Exit1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(750, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Izlaz"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 469)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "ŠKRLIN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Škrlin.DataSet1
    Friend WithEvents RegistarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistarTableAdapter As Škrlin.DataSet1TableAdapters.RegistarTableAdapter
    Friend WithEvents RegistarskiBRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezimeImeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RodjenDatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OIBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
