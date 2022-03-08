<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Infekcija
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
        Dim Vrsta_infekcijeLabel As System.Windows.Forms.Label
        Dim Datum_infekcijeLabel As System.Windows.Forms.Label
        Dim Dijagnoza_infekcijeLabel As System.Windows.Forms.Label
        Dim Dijagnoza_infekcije_MKBLabel As System.Windows.Forms.Label
        Dim DonešenaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Generalije_Control1 = New Skrlin.Generalije_Control()
        Me.InfekcijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Skrlin.DataSet2()
        Me.Datum_infekcijeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Dijagnoza_infekcijeTextBox = New System.Windows.Forms.TextBox()
        Me.Dijagnoza_infekcije_MKBTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DonešenaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VrsteInfekcijeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistarskiBRTextBox = New System.Windows.Forms.TextBox()
        Me.MaticniBRTextBox = New System.Windows.Forms.TextBox()
        Me.InfekcijaTableAdapter = New Skrlin.DataSet2TableAdapters.InfekcijaTableAdapter()
        Me.TableAdapterManager = New Skrlin.DataSet2TableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OperacijeGridView = New System.Windows.Forms.DataGridView()
        Me.Povezano = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaticniBRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtokolBRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistarskiBRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperacijeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Skrlin.DataSet1()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MKBNalazGridViewX = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VrijemeVadjenjaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PotpisVrijemeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdjelUputioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZahvatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MKBNalaziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OperacijeTableAdapter = New Skrlin.DataSet1TableAdapters.OperacijeTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Vrste_InfekcijeTableAdapter = New Skrlin.DataSet2TableAdapters.Vrste_InfekcijeTableAdapter()
        Me.MKB_NalaziTableAdapter = New Skrlin.DataSet1TableAdapters.MKB_NalaziTableAdapter()
        Vrsta_infekcijeLabel = New System.Windows.Forms.Label()
        Datum_infekcijeLabel = New System.Windows.Forms.Label()
        Dijagnoza_infekcijeLabel = New System.Windows.Forms.Label()
        Dijagnoza_infekcije_MKBLabel = New System.Windows.Forms.Label()
        DonešenaLabel = New System.Windows.Forms.Label()
        CType(Me.InfekcijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrsteInfekcijeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.OperacijeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperacijeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MKBNalazGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MKBNalaziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vrsta_infekcijeLabel
        '
        Vrsta_infekcijeLabel.AutoSize = True
        Vrsta_infekcijeLabel.Location = New System.Drawing.Point(12, 141)
        Vrsta_infekcijeLabel.Name = "Vrsta_infekcijeLabel"
        Vrsta_infekcijeLabel.Size = New System.Drawing.Size(67, 13)
        Vrsta_infekcijeLabel.TabIndex = 9
        Vrsta_infekcijeLabel.Text = "Tip infekcije:"
        '
        'Datum_infekcijeLabel
        '
        Datum_infekcijeLabel.AutoSize = True
        Datum_infekcijeLabel.Location = New System.Drawing.Point(12, 112)
        Datum_infekcijeLabel.Name = "Datum_infekcijeLabel"
        Datum_infekcijeLabel.Size = New System.Drawing.Size(83, 13)
        Datum_infekcijeLabel.TabIndex = 11
        Datum_infekcijeLabel.Text = "Datum infekcije:"
        '
        'Dijagnoza_infekcijeLabel
        '
        Dijagnoza_infekcijeLabel.AutoSize = True
        Dijagnoza_infekcijeLabel.Location = New System.Drawing.Point(12, 168)
        Dijagnoza_infekcijeLabel.Name = "Dijagnoza_infekcijeLabel"
        Dijagnoza_infekcijeLabel.Size = New System.Drawing.Size(99, 13)
        Dijagnoza_infekcijeLabel.TabIndex = 13
        Dijagnoza_infekcijeLabel.Text = "Dijagnoza infekcije:"
        '
        'Dijagnoza_infekcije_MKBLabel
        '
        Dijagnoza_infekcije_MKBLabel.AutoSize = True
        Dijagnoza_infekcije_MKBLabel.Location = New System.Drawing.Point(12, 194)
        Dijagnoza_infekcije_MKBLabel.Name = "Dijagnoza_infekcije_MKBLabel"
        Dijagnoza_infekcije_MKBLabel.Size = New System.Drawing.Size(125, 13)
        Dijagnoza_infekcije_MKBLabel.TabIndex = 15
        Dijagnoza_infekcije_MKBLabel.Text = "Dijagnoza infekcije MKB:"
        '
        'DonešenaLabel
        '
        DonešenaLabel.AutoSize = True
        DonešenaLabel.Location = New System.Drawing.Point(422, 141)
        DonešenaLabel.Name = "DonešenaLabel"
        DonešenaLabel.Size = New System.Drawing.Size(59, 13)
        DonešenaLabel.TabIndex = 23
        DonešenaLabel.Text = "Donešena:"
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
        'InfekcijaBindingSource
        '
        Me.InfekcijaBindingSource.DataMember = "Infekcija"
        Me.InfekcijaBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Datum_infekcijeDateTimePicker
        '
        Me.Datum_infekcijeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "Datum_infekcije", True))
        Me.Datum_infekcijeDateTimePicker.Location = New System.Drawing.Point(97, 110)
        Me.Datum_infekcijeDateTimePicker.Name = "Datum_infekcijeDateTimePicker"
        Me.Datum_infekcijeDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.Datum_infekcijeDateTimePicker.TabIndex = 12
        '
        'Dijagnoza_infekcijeTextBox
        '
        Me.Dijagnoza_infekcijeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "Dijagnoza_infekcije", True))
        Me.Dijagnoza_infekcijeTextBox.Location = New System.Drawing.Point(143, 165)
        Me.Dijagnoza_infekcijeTextBox.Name = "Dijagnoza_infekcijeTextBox"
        Me.Dijagnoza_infekcijeTextBox.Size = New System.Drawing.Size(363, 20)
        Me.Dijagnoza_infekcijeTextBox.TabIndex = 14
        '
        'Dijagnoza_infekcije_MKBTextBox
        '
        Me.Dijagnoza_infekcije_MKBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "Dijagnoza_infekcije_MKB", True))
        Me.Dijagnoza_infekcije_MKBTextBox.Location = New System.Drawing.Point(143, 191)
        Me.Dijagnoza_infekcije_MKBTextBox.Name = "Dijagnoza_infekcije_MKBTextBox"
        Me.Dijagnoza_infekcije_MKBTextBox.Size = New System.Drawing.Size(69, 20)
        Me.Dijagnoza_infekcije_MKBTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Image = Global.Skrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(848, 558)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Izlaz"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DonešenaCheckBox
        '
        Me.DonešenaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.InfekcijaBindingSource, "Donešena", True))
        Me.DonešenaCheckBox.Location = New System.Drawing.Point(487, 136)
        Me.DonešenaCheckBox.Name = "DonešenaCheckBox"
        Me.DonešenaCheckBox.Size = New System.Drawing.Size(54, 24)
        Me.DonešenaCheckBox.TabIndex = 24
        Me.DonešenaCheckBox.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InfekcijaBindingSource, "Tip_infekcije", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VrsteInfekcijeBindingSource, "Naziv", True))
        Me.ComboBox1.DataSource = Me.VrsteInfekcijeBindingSource
        Me.ComboBox1.DisplayMember = "Naziv"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(319, 21)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.ValueMember = "Naziv"
        '
        'VrsteInfekcijeBindingSource
        '
        Me.VrsteInfekcijeBindingSource.DataMember = "Vrste_Infekcije"
        Me.VrsteInfekcijeBindingSource.DataSource = Me.DataSet2
        '
        'RegistarskiBRTextBox
        '
        Me.RegistarskiBRTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RegistarskiBRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistarskiBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "RegistarskiBR", True))
        Me.RegistarskiBRTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.RegistarskiBRTextBox.Location = New System.Drawing.Point(524, 13)
        Me.RegistarskiBRTextBox.Name = "RegistarskiBRTextBox"
        Me.RegistarskiBRTextBox.ReadOnly = True
        Me.RegistarskiBRTextBox.Size = New System.Drawing.Size(100, 13)
        Me.RegistarskiBRTextBox.TabIndex = 26
        '
        'MaticniBRTextBox
        '
        Me.MaticniBRTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MaticniBRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaticniBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "MaticniBR", True))
        Me.MaticniBRTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.MaticniBRTextBox.Location = New System.Drawing.Point(524, 39)
        Me.MaticniBRTextBox.Name = "MaticniBRTextBox"
        Me.MaticniBRTextBox.ReadOnly = True
        Me.MaticniBRTextBox.Size = New System.Drawing.Size(100, 13)
        Me.MaticniBRTextBox.TabIndex = 27
        '
        'InfekcijaTableAdapter
        '
        Me.InfekcijaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ASATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoravciTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_LijekTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_MKBTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.InfekcijaTableAdapter = Me.InfekcijaTableAdapter
        Me.TableAdapterManager.OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.Tipovi_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Skrlin.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vrste_AnestezijeTableAdapter = Nothing
        Me.TableAdapterManager.Vrste_InfekcijeTableAdapter = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(15, 238)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 314)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.OperacijeGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 288)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operacije"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'OperacijeGridView
        '
        Me.OperacijeGridView.AllowUserToAddRows = False
        Me.OperacijeGridView.AllowUserToDeleteRows = False
        Me.OperacijeGridView.AllowUserToResizeColumns = False
        Me.OperacijeGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OperacijeGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OperacijeGridView.AutoGenerateColumns = False
        Me.OperacijeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OperacijeGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Povezano, Me.MaticniBRDataGridViewTextBoxColumn, Me.ProtokolBRDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.RegistarskiBRDataGridViewTextBoxColumn})
        Me.OperacijeGridView.DataSource = Me.OperacijeBindingSource
        Me.OperacijeGridView.Location = New System.Drawing.Point(3, 3)
        Me.OperacijeGridView.MultiSelect = False
        Me.OperacijeGridView.Name = "OperacijeGridView"
        Me.OperacijeGridView.RowHeadersVisible = False
        Me.OperacijeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OperacijeGridView.Size = New System.Drawing.Size(484, 278)
        Me.OperacijeGridView.TabIndex = 0
        '
        'Povezano
        '
        Me.Povezano.HeaderText = ""
        Me.Povezano.Name = "Povezano"
        Me.Povezano.Width = 50
        '
        'MaticniBRDataGridViewTextBoxColumn
        '
        Me.MaticniBRDataGridViewTextBoxColumn.DataPropertyName = "MaticniBR"
        Me.MaticniBRDataGridViewTextBoxColumn.HeaderText = "MaticniBR"
        Me.MaticniBRDataGridViewTextBoxColumn.Name = "MaticniBRDataGridViewTextBoxColumn"
        '
        'ProtokolBRDataGridViewTextBoxColumn
        '
        Me.ProtokolBRDataGridViewTextBoxColumn.DataPropertyName = "ProtokolBR"
        Me.ProtokolBRDataGridViewTextBoxColumn.HeaderText = "ProtokolBR"
        Me.ProtokolBRDataGridViewTextBoxColumn.Name = "ProtokolBRDataGridViewTextBoxColumn"
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        DataGridViewCellStyle2.Format = "d"
        Me.DatumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        '
        'RegistarskiBRDataGridViewTextBoxColumn
        '
        Me.RegistarskiBRDataGridViewTextBoxColumn.DataPropertyName = "RegistarskiBR"
        Me.RegistarskiBRDataGridViewTextBoxColumn.HeaderText = "RegistarskiBR"
        Me.RegistarskiBRDataGridViewTextBoxColumn.Name = "RegistarskiBRDataGridViewTextBoxColumn"
        '
        'OperacijeBindingSource
        '
        Me.OperacijeBindingSource.DataMember = "Operacije"
        Me.OperacijeBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MKBNalazGridViewX)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(925, 288)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MKB"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MKBNalazGridViewX
        '
        Me.MKBNalazGridViewX.AllowUserToAddRows = False
        Me.MKBNalazGridViewX.AllowUserToDeleteRows = False
        Me.MKBNalazGridViewX.AllowUserToResizeColumns = False
        Me.MKBNalazGridViewX.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MKBNalazGridViewX.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MKBNalazGridViewX.AutoGenerateColumns = False
        Me.MKBNalazGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MKBNalazGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.VrijemeVadjenjaDataGridViewTextBoxColumn, Me.PotpisVrijemeDataGridViewTextBoxColumn, Me.OdjelUputioDataGridViewTextBoxColumn, Me.ZahvatDataGridViewTextBoxColumn})
        Me.MKBNalazGridViewX.DataSource = Me.MKBNalaziBindingSource
        Me.MKBNalazGridViewX.Location = New System.Drawing.Point(3, 3)
        Me.MKBNalazGridViewX.Name = "MKBNalazGridViewX"
        Me.MKBNalazGridViewX.RowHeadersVisible = False
        Me.MKBNalazGridViewX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MKBNalazGridViewX.Size = New System.Drawing.Size(916, 282)
        Me.MKBNalazGridViewX.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'VrijemeVadjenjaDataGridViewTextBoxColumn
        '
        Me.VrijemeVadjenjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeVadjenja"
        DataGridViewCellStyle4.Format = "d"
        Me.VrijemeVadjenjaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.VrijemeVadjenjaDataGridViewTextBoxColumn.HeaderText = "Uzorkovan"
        Me.VrijemeVadjenjaDataGridViewTextBoxColumn.Name = "VrijemeVadjenjaDataGridViewTextBoxColumn"
        '
        'PotpisVrijemeDataGridViewTextBoxColumn
        '
        Me.PotpisVrijemeDataGridViewTextBoxColumn.DataPropertyName = "PotpisVrijeme"
        DataGridViewCellStyle5.Format = "d"
        Me.PotpisVrijemeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PotpisVrijemeDataGridViewTextBoxColumn.HeaderText = "Završen"
        Me.PotpisVrijemeDataGridViewTextBoxColumn.Name = "PotpisVrijemeDataGridViewTextBoxColumn"
        '
        'OdjelUputioDataGridViewTextBoxColumn
        '
        Me.OdjelUputioDataGridViewTextBoxColumn.DataPropertyName = "OdjelUputio"
        Me.OdjelUputioDataGridViewTextBoxColumn.HeaderText = "Odjel"
        Me.OdjelUputioDataGridViewTextBoxColumn.Name = "OdjelUputioDataGridViewTextBoxColumn"
        Me.OdjelUputioDataGridViewTextBoxColumn.Width = 300
        '
        'ZahvatDataGridViewTextBoxColumn
        '
        Me.ZahvatDataGridViewTextBoxColumn.DataPropertyName = "Zahvat"
        Me.ZahvatDataGridViewTextBoxColumn.HeaderText = "Zahvat"
        Me.ZahvatDataGridViewTextBoxColumn.Name = "ZahvatDataGridViewTextBoxColumn"
        Me.ZahvatDataGridViewTextBoxColumn.Width = 300
        '
        'MKBNalaziBindingSource
        '
        Me.MKBNalaziBindingSource.DataMember = "MKB_Nalazi"
        Me.MKBNalaziBindingSource.DataSource = Me.DataSet1
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(925, 288)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Terapije"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'OperacijeTableAdapter
        '
        Me.OperacijeTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InfekcijaBindingSource, "ID", True))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.IDTextBox.Location = New System.Drawing.Point(549, 64)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 13)
        Me.IDTextBox.TabIndex = 29
        '
        'Vrste_InfekcijeTableAdapter
        '
        Me.Vrste_InfekcijeTableAdapter.ClearBeforeFill = True
        '
        'MKB_NalaziTableAdapter
        '
        Me.MKB_NalaziTableAdapter.ClearBeforeFill = True
        '
        'Infekcija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 613)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MaticniBRTextBox)
        Me.Controls.Add(Me.RegistarskiBRTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(DonešenaLabel)
        Me.Controls.Add(Me.DonešenaCheckBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Vrsta_infekcijeLabel)
        Me.Controls.Add(Datum_infekcijeLabel)
        Me.Controls.Add(Me.Datum_infekcijeDateTimePicker)
        Me.Controls.Add(Dijagnoza_infekcijeLabel)
        Me.Controls.Add(Me.Dijagnoza_infekcijeTextBox)
        Me.Controls.Add(Dijagnoza_infekcije_MKBLabel)
        Me.Controls.Add(Me.Dijagnoza_infekcije_MKBTextBox)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Location = New System.Drawing.Point(100, 50)
        Me.Name = "Infekcija"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Infekcija"
        CType(Me.InfekcijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrsteInfekcijeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.OperacijeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperacijeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MKBNalazGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MKBNalaziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Generalije_Control1 As Skrlin.Generalije_Control
    Friend WithEvents Datum_infekcijeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dijagnoza_infekcijeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dijagnoza_infekcije_MKBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DonešenaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RegistarskiBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaticniBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataSet2 As Skrlin.DataSet2
    Friend WithEvents InfekcijaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InfekcijaTableAdapter As Skrlin.DataSet2TableAdapters.InfekcijaTableAdapter
    Friend WithEvents TableAdapterManager As Skrlin.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents OperacijeGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OperacijeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Skrlin.DataSet1
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents OperacijeTableAdapter As Skrlin.DataSet1TableAdapters.OperacijeTableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VrsteInfekcijeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vrste_InfekcijeTableAdapter As Skrlin.DataSet2TableAdapters.Vrste_InfekcijeTableAdapter
    Friend WithEvents Povezano As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MaticniBRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProtokolBRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistarskiBRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MKBNalazGridViewX As System.Windows.Forms.DataGridView
    Friend WithEvents MKBNalaziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MKB_NalaziTableAdapter As Skrlin.DataSet1TableAdapters.MKB_NalaziTableAdapter
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VrijemeVadjenjaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PotpisVrijemeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdjelUputioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZahvatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
