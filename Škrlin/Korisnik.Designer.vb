<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Korisnik
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim ImeLabel As System.Windows.Forms.Label
        Dim PrezimeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IsApprovedLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.ImeTextBox = New System.Windows.Forms.TextBox()
        Me.PrezimeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.IsApprovedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.HashedPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox1 = New System.Windows.Forms.TextBox()
        Me.RolesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Aspnet_RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New Škrlin.DataSet3()
        Me.Aspnet_MembershipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_UsersTableAdapter = New Škrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter()
        Me.TableAdapterManager = New Škrlin.DataSet3TableAdapters.TableAdapterManager()
        Me.Aspnet_MembershipTableAdapter = New Škrlin.DataSet3TableAdapters.aspnet_MembershipTableAdapter()
        Me.Aspnet_RolesTableAdapter = New Škrlin.DataSet3TableAdapters.aspnet_RolesTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        UserNameLabel = New System.Windows.Forms.Label()
        ImeLabel = New System.Windows.Forms.Label()
        PrezimeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IsApprovedLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RolesDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Aspnet_RolesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataSet3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Aspnet_MembershipBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Aspnet_UsersBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = true
        UserNameLabel.Location = New System.Drawing.Point(7, 27)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(75, 13)
        UserNameLabel.TabIndex = 90
        UserNameLabel.Text = "Korisničko ime"
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = true
        ImeLabel.Location = New System.Drawing.Point(7, 53)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(24, 13)
        ImeLabel.TabIndex = 91
        ImeLabel.Text = "Ime"
        '
        'PrezimeLabel
        '
        PrezimeLabel.AutoSize = true
        PrezimeLabel.Location = New System.Drawing.Point(7, 79)
        PrezimeLabel.Name = "PrezimeLabel"
        PrezimeLabel.Size = New System.Drawing.Size(44, 13)
        PrezimeLabel.TabIndex = 92
        PrezimeLabel.Text = "Prezime"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = true
        EmailLabel.Location = New System.Drawing.Point(7, 106)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 93
        EmailLabel.Text = "E-mail"
        '
        'IsApprovedLabel
        '
        IsApprovedLabel.AutoSize = true
        IsApprovedLabel.Location = New System.Drawing.Point(7, 132)
        IsApprovedLabel.Name = "IsApprovedLabel"
        IsApprovedLabel.Size = New System.Drawing.Size(43, 13)
        IsApprovedLabel.TabIndex = 94
        IsApprovedLabel.Text = "Aktivan"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = true
        PasswordLabel.Location = New System.Drawing.Point(382, 27)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(44, 13)
        PasswordLabel.TabIndex = 95
        PasswordLabel.Text = "Lozinka"
        '
        'Label1
        '
        Label1.AutoSize = true
        Label1.Location = New System.Drawing.Point(382, 55)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 13)
        Label1.TabIndex = 96
        Label1.Text = "Ponoviti lozinku"
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "UserId", True))
        Me.UserIdTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox.Location = New System.Drawing.Point(385, 97)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.ReadOnly = True
        Me.UserIdTextBox.Size = New System.Drawing.Size(96, 13)
        Me.UserIdTextBox.TabIndex = 81
        Me.UserIdTextBox.TabStop = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(106, 24)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserNameTextBox.TabIndex = 1
        '
        'ImeTextBox
        '
        Me.ImeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "Ime", True))
        Me.ImeTextBox.Location = New System.Drawing.Point(106, 50)
        Me.ImeTextBox.Name = "ImeTextBox"
        Me.ImeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ImeTextBox.TabIndex = 2
        '
        'PrezimeTextBox
        '
        Me.PrezimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "Prezime", True))
        Me.PrezimeTextBox.Location = New System.Drawing.Point(106, 76)
        Me.PrezimeTextBox.Name = "PrezimeTextBox"
        Me.PrezimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrezimeTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_MembershipBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(106, 103)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'IsApprovedCheckBox
        '
        Me.IsApprovedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Aspnet_MembershipBindingSource, "IsApproved", True))
        Me.IsApprovedCheckBox.Location = New System.Drawing.Point(106, 127)
        Me.IsApprovedCheckBox.Name = "IsApprovedCheckBox"
        Me.IsApprovedCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IsApprovedCheckBox.TabIndex = 5
        Me.IsApprovedCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Škrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(614, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Izlaz"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(481, 24)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(167, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.Location = New System.Drawing.Point(481, 52)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(167, 20)
        Me.PasswordTextBox1.TabIndex = 7
        '
        'HashedPasswordTextBox
        '
        Me.HashedPasswordTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.HashedPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HashedPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_MembershipBindingSource, "Password", True))
        Me.HashedPasswordTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.HashedPasswordTextBox.Location = New System.Drawing.Point(385, 78)
        Me.HashedPasswordTextBox.Name = "HashedPasswordTextBox"
        Me.HashedPasswordTextBox.ReadOnly = True
        Me.HashedPasswordTextBox.Size = New System.Drawing.Size(263, 13)
        Me.HashedPasswordTextBox.TabIndex = 80
        Me.HashedPasswordTextBox.TabStop = False
        '
        'UserIdTextBox1
        '
        Me.UserIdTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserIdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_MembershipBindingSource, "UserId", True))
        Me.UserIdTextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox1.Location = New System.Drawing.Point(548, 97)
        Me.UserIdTextBox1.Name = "UserIdTextBox1"
        Me.UserIdTextBox1.ReadOnly = True
        Me.UserIdTextBox1.Size = New System.Drawing.Size(100, 13)
        Me.UserIdTextBox1.TabIndex = 82
        Me.UserIdTextBox1.TabStop = False
        '
        'RolesDataGridView
        '
        Me.RolesDataGridView.AllowUserToAddRows = False
        Me.RolesDataGridView.AllowUserToDeleteRows = False
        Me.RolesDataGridView.AllowUserToResizeRows = False
        Me.RolesDataGridView.AutoGenerateColumns = False
        Me.RolesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RolesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.RolesDataGridView.DataSource = Me.Aspnet_RolesBindingSource
        Me.RolesDataGridView.Location = New System.Drawing.Point(12, 165)
        Me.RolesDataGridView.Name = "RolesDataGridView"
        Me.RolesDataGridView.RowHeadersVisible = False
        Me.RolesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RolesDataGridView.Size = New System.Drawing.Size(581, 220)
        Me.RolesDataGridView.TabIndex = 8
        '
        'Aspnet_RolesBindingSource
        '
        Me.Aspnet_RolesBindingSource.DataMember = "aspnet_Roles"
        Me.Aspnet_RolesBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Aspnet_MembershipBindingSource
        '
        Me.Aspnet_MembershipBindingSource.DataMember = "aspnet_Membership"
        Me.Aspnet_MembershipBindingSource.DataSource = Me.DataSet3
        '
        'Aspnet_UsersBindingSource
        '
        Me.Aspnet_UsersBindingSource.DataMember = "aspnet_Users"
        Me.Aspnet_UsersBindingSource.DataSource = Me.DataSet3
        '
        'Aspnet_UsersTableAdapter
        '
        Me.Aspnet_UsersTableAdapter.ClearBeforeFill = true
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.aspnet_MembershipTableAdapter = Me.Aspnet_MembershipTableAdapter
        Me.TableAdapterManager.aspnet_RolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersInRolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersTableAdapter = Me.Aspnet_UsersTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = false
        Me.TableAdapterManager.UpdateOrder = Škrlin.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Aspnet_MembershipTableAdapter
        '
        Me.Aspnet_MembershipTableAdapter.ClearBeforeFill = true
        '
        'Aspnet_RolesTableAdapter
        '
        Me.Aspnet_RolesTableAdapter.ClearBeforeFill = true
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RoleName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Uloga"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = true
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = true
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'Korisnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 418)
        Me.Controls.Add(Me.RolesDataGridView)
        Me.Controls.Add(Me.UserIdTextBox1)
        Me.Controls.Add(Me.HashedPasswordTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PasswordTextBox1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(IsApprovedLabel)
        Me.Controls.Add(Me.IsApprovedCheckBox)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(ImeLabel)
        Me.Controls.Add(Me.ImeTextBox)
        Me.Controls.Add(PrezimeLabel)
        Me.Controls.Add(Me.PrezimeTextBox)
        Me.Name = "Korisnik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Korisnik"
        CType(Me.RolesDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Aspnet_RolesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataSet3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Aspnet_MembershipBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Aspnet_UsersBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataSet3 As Škrlin.DataSet3
    Friend WithEvents Aspnet_UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_UsersTableAdapter As Škrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter
    Friend WithEvents TableAdapterManager As Škrlin.DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Aspnet_MembershipTableAdapter As Škrlin.DataSet3TableAdapters.aspnet_MembershipTableAdapter
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrezimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Aspnet_MembershipBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsApprovedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HashedPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Aspnet_RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_RolesTableAdapter As Škrlin.DataSet3TableAdapters.aspnet_RolesTableAdapter
    Friend WithEvents RolesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
