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
        Dim Pocetno_radilisteLabel As System.Windows.Forms.Label
        Dim Moze_mijenjati_radilisteLabel As System.Windows.Forms.Label
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.Aspnet_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New Skrlin.DataSet3()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.ImeTextBox = New System.Windows.Forms.TextBox()
        Me.PrezimeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Aspnet_MembershipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsApprovedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.HashedPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox1 = New System.Windows.Forms.TextBox()
        Me.RolesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aspnet_RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_UsersTableAdapter = New Skrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter()
        Me.TableAdapterManager = New Skrlin.DataSet3TableAdapters.TableAdapterManager()
        Me.Aspnet_MembershipTableAdapter = New Skrlin.DataSet3TableAdapters.aspnet_MembershipTableAdapter()
        Me.Aspnet_RolesTableAdapter = New Skrlin.DataSet3TableAdapters.aspnet_RolesTableAdapter()
        Me.Moze_mijenjati_radilisteCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadilisteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet5 = New Skrlin.DataSet5()
        Me.RadilisteTableAdapter = New Skrlin.DataSet5TableAdapters.RadilisteTableAdapter()
        Me.RadilisteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NazivDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadilisteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserRadilisteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserRadilisteTableAdapter = New Skrlin.DataSet5TableAdapters.UserRadilisteTableAdapter()
        UserNameLabel = New System.Windows.Forms.Label()
        ImeLabel = New System.Windows.Forms.Label()
        PrezimeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IsApprovedLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Pocetno_radilisteLabel = New System.Windows.Forms.Label()
        Moze_mijenjati_radilisteLabel = New System.Windows.Forms.Label()
        CType(Me.Aspnet_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_MembershipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RolesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Aspnet_RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadilisteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadilisteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadilisteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRadilisteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(7, 27)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(75, 13)
        UserNameLabel.TabIndex = 90
        UserNameLabel.Text = "Korisničko ime"
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(369, 27)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(24, 13)
        ImeLabel.TabIndex = 91
        ImeLabel.Text = "Ime"
        '
        'PrezimeLabel
        '
        PrezimeLabel.AutoSize = True
        PrezimeLabel.Location = New System.Drawing.Point(369, 53)
        PrezimeLabel.Name = "PrezimeLabel"
        PrezimeLabel.Size = New System.Drawing.Size(44, 13)
        PrezimeLabel.TabIndex = 92
        PrezimeLabel.Text = "Prezime"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(369, 80)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 93
        EmailLabel.Text = "E-mail"
        '
        'IsApprovedLabel
        '
        IsApprovedLabel.AutoSize = True
        IsApprovedLabel.Location = New System.Drawing.Point(7, 109)
        IsApprovedLabel.Name = "IsApprovedLabel"
        IsApprovedLabel.Size = New System.Drawing.Size(43, 13)
        IsApprovedLabel.TabIndex = 94
        IsApprovedLabel.Text = "Aktivan"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(7, 53)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(44, 13)
        PasswordLabel.TabIndex = 95
        PasswordLabel.Text = "Lozinka"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 81)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 13)
        Label1.TabIndex = 96
        Label1.Text = "Ponoviti lozinku"
        '
        'Pocetno_radilisteLabel
        '
        Pocetno_radilisteLabel.AutoSize = True
        Pocetno_radilisteLabel.Location = New System.Drawing.Point(7, 139)
        Pocetno_radilisteLabel.Name = "Pocetno_radilisteLabel"
        Pocetno_radilisteLabel.Size = New System.Drawing.Size(88, 13)
        Pocetno_radilisteLabel.TabIndex = 96
        Pocetno_radilisteLabel.Text = "Početno radilište:"
        '
        'Moze_mijenjati_radilisteLabel
        '
        Moze_mijenjati_radilisteLabel.AutoSize = True
        Moze_mijenjati_radilisteLabel.Location = New System.Drawing.Point(12, 400)
        Moze_mijenjati_radilisteLabel.Name = "Moze_mijenjati_radilisteLabel"
        Moze_mijenjati_radilisteLabel.Size = New System.Drawing.Size(146, 13)
        Moze_mijenjati_radilisteLabel.TabIndex = 97
        Moze_mijenjati_radilisteLabel.Text = "Može pristupiti svim radilištima"
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "UserId", True))
        Me.UserIdTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox.Location = New System.Drawing.Point(618, 236)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.ReadOnly = True
        Me.UserIdTextBox.Size = New System.Drawing.Size(96, 13)
        Me.UserIdTextBox.TabIndex = 81
        Me.UserIdTextBox.TabStop = False
        '
        'Aspnet_UsersBindingSource
        '
        Me.Aspnet_UsersBindingSource.DataMember = "aspnet_Users"
        Me.Aspnet_UsersBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ImeTextBox.Location = New System.Drawing.Point(468, 24)
        Me.ImeTextBox.Name = "ImeTextBox"
        Me.ImeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ImeTextBox.TabIndex = 2
        '
        'PrezimeTextBox
        '
        Me.PrezimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_UsersBindingSource, "Prezime", True))
        Me.PrezimeTextBox.Location = New System.Drawing.Point(468, 50)
        Me.PrezimeTextBox.Name = "PrezimeTextBox"
        Me.PrezimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrezimeTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_MembershipBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(468, 77)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'Aspnet_MembershipBindingSource
        '
        Me.Aspnet_MembershipBindingSource.DataMember = "aspnet_Membership"
        Me.Aspnet_MembershipBindingSource.DataSource = Me.DataSet3
        '
        'IsApprovedCheckBox
        '
        Me.IsApprovedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Aspnet_MembershipBindingSource, "IsApproved", True))
        Me.IsApprovedCheckBox.Location = New System.Drawing.Point(106, 104)
        Me.IsApprovedCheckBox.Name = "IsApprovedCheckBox"
        Me.IsApprovedCheckBox.Size = New System.Drawing.Size(49, 24)
        Me.IsApprovedCheckBox.TabIndex = 5
        Me.IsApprovedCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Skrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(840, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Izlaz"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(106, 50)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(167, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.Location = New System.Drawing.Point(106, 78)
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
        Me.HashedPasswordTextBox.Location = New System.Drawing.Point(614, 272)
        Me.HashedPasswordTextBox.Name = "HashedPasswordTextBox"
        Me.HashedPasswordTextBox.ReadOnly = True
        Me.HashedPasswordTextBox.Size = New System.Drawing.Size(90, 13)
        Me.HashedPasswordTextBox.TabIndex = 80
        Me.HashedPasswordTextBox.TabStop = False
        '
        'UserIdTextBox1
        '
        Me.UserIdTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserIdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Aspnet_MembershipBindingSource, "UserId", True))
        Me.UserIdTextBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.UserIdTextBox1.Location = New System.Drawing.Point(614, 303)
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
        Me.RolesDataGridView.Location = New System.Drawing.Point(462, 163)
        Me.RolesDataGridView.Name = "RolesDataGridView"
        Me.RolesDataGridView.RowHeadersVisible = False
        Me.RolesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RolesDataGridView.Size = New System.Drawing.Size(478, 234)
        Me.RolesDataGridView.TabIndex = 8
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
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'Aspnet_RolesBindingSource
        '
        Me.Aspnet_RolesBindingSource.DataMember = "aspnet_Roles"
        Me.Aspnet_RolesBindingSource.DataSource = Me.DataSet3
        '
        'Aspnet_UsersTableAdapter
        '
        Me.Aspnet_UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.aspnet_MembershipTableAdapter = Me.Aspnet_MembershipTableAdapter
        Me.TableAdapterManager.aspnet_RolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersInRolesTableAdapter = Nothing
        Me.TableAdapterManager.aspnet_UsersTableAdapter = Me.Aspnet_UsersTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Skrlin.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Aspnet_MembershipTableAdapter
        '
        Me.Aspnet_MembershipTableAdapter.ClearBeforeFill = True
        '
        'Aspnet_RolesTableAdapter
        '
        Me.Aspnet_RolesTableAdapter.ClearBeforeFill = True
        '
        'Moze_mijenjati_radilisteCheckBox
        '
        Me.Moze_mijenjati_radilisteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Aspnet_UsersBindingSource, "Moze_mijenjati_radiliste", True))
        Me.Moze_mijenjati_radilisteCheckBox.Location = New System.Drawing.Point(163, 395)
        Me.Moze_mijenjati_radilisteCheckBox.Name = "Moze_mijenjati_radilisteCheckBox"
        Me.Moze_mijenjati_radilisteCheckBox.Size = New System.Drawing.Size(25, 24)
        Me.Moze_mijenjati_radilisteCheckBox.TabIndex = 98
        Me.Moze_mijenjati_radilisteCheckBox.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Aspnet_UsersBindingSource, "Pocetno_radiliste", True))
        Me.ComboBox1.DataSource = Me.RadilisteBindingSource
        Me.ComboBox1.DisplayMember = "Naziv"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(333, 21)
        Me.ComboBox1.TabIndex = 99
        Me.ComboBox1.ValueMember = "ID"
        '
        'RadilisteBindingSource
        '
        Me.RadilisteBindingSource.DataMember = "Radiliste"
        Me.RadilisteBindingSource.DataSource = Me.DataSet5
        '
        'DataSet5
        '
        Me.DataSet5.DataSetName = "DataSet5"
        Me.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadilisteTableAdapter
        '
        Me.RadilisteTableAdapter.ClearBeforeFill = True
        '
        'RadilisteDataGridView
        '
        Me.RadilisteDataGridView.AllowUserToAddRows = False
        Me.RadilisteDataGridView.AllowUserToDeleteRows = False
        Me.RadilisteDataGridView.AllowUserToResizeRows = False
        Me.RadilisteDataGridView.AutoGenerateColumns = False
        Me.RadilisteDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RadilisteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RadilisteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.IDDataGridViewTextBoxColumn, Me.NazivDataGridViewTextBoxColumn})
        Me.RadilisteDataGridView.DataSource = Me.RadilisteBindingSource1
        Me.RadilisteDataGridView.Location = New System.Drawing.Point(10, 163)
        Me.RadilisteDataGridView.Name = "RadilisteDataGridView"
        Me.RadilisteDataGridView.RowHeadersVisible = False
        Me.RadilisteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RadilisteDataGridView.Size = New System.Drawing.Size(446, 234)
        Me.RadilisteDataGridView.TabIndex = 100
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NazivDataGridViewTextBoxColumn
        '
        Me.NazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.HeaderText = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.Name = "NazivDataGridViewTextBoxColumn"
        Me.NazivDataGridViewTextBoxColumn.Width = 300
        '
        'RadilisteBindingSource1
        '
        Me.RadilisteBindingSource1.DataMember = "Radiliste"
        Me.RadilisteBindingSource1.DataSource = Me.DataSet5BindingSource
        '
        'DataSet5BindingSource
        '
        Me.DataSet5BindingSource.DataSource = Me.DataSet5
        Me.DataSet5BindingSource.Position = 0
        '
        'UserRadilisteBindingSource
        '
        Me.UserRadilisteBindingSource.DataMember = "UserRadiliste"
        Me.UserRadilisteBindingSource.DataSource = Me.DataSet5
        '
        'UserRadilisteTableAdapter
        '
        Me.UserRadilisteTableAdapter.ClearBeforeFill = True
        '
        'Korisnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 464)
        Me.Controls.Add(Me.RadilisteDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Moze_mijenjati_radilisteLabel)
        Me.Controls.Add(Me.Moze_mijenjati_radilisteCheckBox)
        Me.Controls.Add(Pocetno_radilisteLabel)
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
        CType(Me.Aspnet_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_MembershipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RolesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Aspnet_RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadilisteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadilisteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadilisteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRadilisteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet3 As Skrlin.DataSet3
    Friend WithEvents Aspnet_UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Aspnet_UsersTableAdapter As Skrlin.DataSet3TableAdapters.aspnet_UsersTableAdapter
    Friend WithEvents TableAdapterManager As Skrlin.DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Aspnet_MembershipTableAdapter As Skrlin.DataSet3TableAdapters.aspnet_MembershipTableAdapter
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
    Friend WithEvents Aspnet_RolesTableAdapter As Skrlin.DataSet3TableAdapters.aspnet_RolesTableAdapter
    Friend WithEvents RolesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moze_mijenjati_radilisteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet5 As Skrlin.DataSet5
    Friend WithEvents RadilisteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RadilisteTableAdapter As Skrlin.DataSet5TableAdapters.RadilisteTableAdapter
    Friend WithEvents RadilisteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents UserRadilisteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserRadilisteTableAdapter As Skrlin.DataSet5TableAdapters.UserRadilisteTableAdapter
    Friend WithEvents RadilisteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazivDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
