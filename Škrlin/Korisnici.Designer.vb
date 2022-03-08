<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Korisnici
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
        Me.DataSet3 = New Škrlin.DataSet3()
        Me.Aspnet_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_UsersTableAdapter = New Škrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter()
        Me.TableAdapterManager = New Škrlin.DataSet3TableAdapters.TableAdapterManager()
        Me.Aspnet_UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Aspnet_UsersBindingSource
        '
        Me.Aspnet_UsersBindingSource.DataMember = "aspnet_Users"
        Me.Aspnet_UsersBindingSource.DataSource = Me.DataSet3
        '
        'Aspnet_UsersTableAdapter
        '
        Me.Aspnet_UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.aspnet_MembershipTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_RolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersInRolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersTableAdapter = Me.Aspnet_UsersTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Škrlin.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Aspnet_UsersDataGridView
        '
        Me.Aspnet_UsersDataGridView.AllowUserToAddRows = False
        Me.Aspnet_UsersDataGridView.AllowUserToDeleteRows = False
        Me.Aspnet_UsersDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Aspnet_UsersDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Aspnet_UsersDataGridView.AutoGenerateColumns = False
        Me.Aspnet_UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Aspnet_UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Aspnet_UsersDataGridView.DataSource = Me.Aspnet_UsersBindingSource
        Me.Aspnet_UsersDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Aspnet_UsersDataGridView.MultiSelect = False
        Me.Aspnet_UsersDataGridView.Name = "Aspnet_UsersDataGridView"
        Me.Aspnet_UsersDataGridView.ReadOnly = True
        Me.Aspnet_UsersDataGridView.RowHeadersVisible = False
        Me.Aspnet_UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Aspnet_UsersDataGridView.Size = New System.Drawing.Size(872, 373)
        Me.Aspnet_UsersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Prezime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Prezime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 300
        '
        'Button1
        '
        Me.Button1.Image = Global.Škrlin.My.Resources.Resources.Clipboard01
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Novi korisnik"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Škrlin.My.Resources.Resources.Icon_Exit1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(764, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Izlazak"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Korisnici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 438)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Aspnet_UsersDataGridView)
        Me.Name = "Korisnici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Korisnici"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet3 As Škrlin.DataSet3
    Friend WithEvents Aspnet_UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_UsersTableAdapter As Škrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter
    Friend WithEvents TableAdapterManager As Škrlin.DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Aspnet_UsersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
