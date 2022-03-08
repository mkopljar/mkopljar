<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operacija
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
        Dim Datum_operacijeLabel As System.Windows.Forms.Label
        Dim Vrsta_anestezijeLabel As System.Windows.Forms.Label
        Dim Hitna_operacijaLabel As System.Windows.Forms.Label
        Dim ASALabel As System.Windows.Forms.Label
        Dim Preoperativno_brijanjeLabel As System.Windows.Forms.Label
        Dim Intraop_transfuzijaLabel As System.Windows.Forms.Label
        Dim DrenLabel As System.Windows.Forms.Label
        Dim OperaterLabel As System.Windows.Forms.Label
        Dim AsistentLabel As System.Windows.Forms.Label
        Dim InstrumentarkaLabel As System.Windows.Forms.Label
        Dim OperacijaLabel As System.Windows.Forms.Label
        Dim Preoperativno_klipanjeLabel As System.Windows.Forms.Label
        Dim ProtokolBRLabel As System.Windows.Forms.Label
        Dim MaticniBRLabel As System.Windows.Forms.Label
        Dim Početak_operacijeLabel As System.Windows.Forms.Label
        Dim Kraj_operacijeLabel As System.Windows.Forms.Label
        Dim Trajanje_operacijeLabel As System.Windows.Forms.Label
        Me.Datum_operacijeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OperacijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Škrlin.DataSet2()
        Me.Hitna_operacijaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Preoperativno_brijanjeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Intraop_transfuzijaCheckBox = New System.Windows.Forms.CheckBox()
        Me.DrenCheckBox = New System.Windows.Forms.CheckBox()
        Me.OperaterTextBox = New System.Windows.Forms.TextBox()
        Me.AsistentTextBox = New System.Windows.Forms.TextBox()
        Me.InstrumentarkaTextBox = New System.Windows.Forms.TextBox()
        Me.Preoperativno_klipanjeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProtokolBRTextBox = New System.Windows.Forms.TextBox()
        Me.MaticniBRTextBox = New System.Windows.Forms.TextBox()
        Me.Početak_operacijeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Kraj_operacijeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Trajanje_operacijeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PostupciGridView = New System.Windows.Forms.DataGridView()
        Me.SifraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NazivDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Škrlin.DataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StacGridView = New System.Windows.Forms.DataGridView()
        Me.SifraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NazivNezasticeniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STACBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Konac_za_kožu = New System.Windows.Forms.Button()
        Me.Button_Strano_tijelo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Konac_za_kožuID = New System.Windows.Forms.TextBox()
        Me.Strano_tijeloID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Konac_za_kožu_Label = New System.Windows.Forms.Label()
        Me.Strano_tijelo_Label = New System.Windows.Forms.Label()
        Me.DTSTableAdapter = New Škrlin.DataSet1TableAdapters.DTSTableAdapter()
        Me.STACTableAdapter = New Škrlin.DataSet1TableAdapters.STACTableAdapter()
        Me.Generalije_Control1 = New Škrlin.Generalije_Control()
        Me.OperacijaTableAdapter = New Škrlin.DataSet2TableAdapters.OperacijaTableAdapter()
        Me.TableAdapterManager = New Škrlin.DataSet2TableAdapters.TableAdapterManager()
        Me.OperacijaComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoviOperacijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipovi_OperacijaTableAdapter = New Škrlin.DataSet2TableAdapters.Tipovi_OperacijaTableAdapter()
        Me.VrstaAnestezijeComboBox = New System.Windows.Forms.ComboBox()
        Me.VrsteAnestezijeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vrste_AnestezijeTableAdapter = New Škrlin.DataSet2TableAdapters.Vrste_AnestezijeTableAdapter()
        Me.ASABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASATableAdapter = New Škrlin.DataSet2TableAdapters.ASATableAdapter()
        Me.MultipleCheckBoxUserControl1 = New Škrlin.MultipleCheckBoxUserControl()
        Me.Button2 = New System.Windows.Forms.Button()
        Datum_operacijeLabel = New System.Windows.Forms.Label()
        Vrsta_anestezijeLabel = New System.Windows.Forms.Label()
        Hitna_operacijaLabel = New System.Windows.Forms.Label()
        ASALabel = New System.Windows.Forms.Label()
        Preoperativno_brijanjeLabel = New System.Windows.Forms.Label()
        Intraop_transfuzijaLabel = New System.Windows.Forms.Label()
        DrenLabel = New System.Windows.Forms.Label()
        OperaterLabel = New System.Windows.Forms.Label()
        AsistentLabel = New System.Windows.Forms.Label()
        InstrumentarkaLabel = New System.Windows.Forms.Label()
        OperacijaLabel = New System.Windows.Forms.Label()
        Preoperativno_klipanjeLabel = New System.Windows.Forms.Label()
        ProtokolBRLabel = New System.Windows.Forms.Label()
        MaticniBRLabel = New System.Windows.Forms.Label()
        Početak_operacijeLabel = New System.Windows.Forms.Label()
        Kraj_operacijeLabel = New System.Windows.Forms.Label()
        Trajanje_operacijeLabel = New System.Windows.Forms.Label()
        CType(Me.OperacijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostupciGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StacGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STACBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoviOperacijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrsteAnestezijeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datum_operacijeLabel
        '
        Datum_operacijeLabel.AutoSize = True
        Datum_operacijeLabel.Location = New System.Drawing.Point(21, 132)
        Datum_operacijeLabel.Name = "Datum_operacijeLabel"
        Datum_operacijeLabel.Size = New System.Drawing.Size(87, 13)
        Datum_operacijeLabel.TabIndex = 5
        Datum_operacijeLabel.Text = "Datum operacije:"
        '
        'Vrsta_anestezijeLabel
        '
        Vrsta_anestezijeLabel.AutoSize = True
        Vrsta_anestezijeLabel.Location = New System.Drawing.Point(275, 498)
        Vrsta_anestezijeLabel.Name = "Vrsta_anestezijeLabel"
        Vrsta_anestezijeLabel.Size = New System.Drawing.Size(84, 13)
        Vrsta_anestezijeLabel.TabIndex = 7
        Vrsta_anestezijeLabel.Text = "Vrsta anestezije:"
        '
        'Hitna_operacijaLabel
        '
        Hitna_operacijaLabel.AutoSize = True
        Hitna_operacijaLabel.Location = New System.Drawing.Point(260, 132)
        Hitna_operacijaLabel.Name = "Hitna_operacijaLabel"
        Hitna_operacijaLabel.Size = New System.Drawing.Size(81, 13)
        Hitna_operacijaLabel.TabIndex = 9
        Hitna_operacijaLabel.Text = "Hitna operacija:"
        '
        'ASALabel
        '
        ASALabel.AutoSize = True
        ASALabel.Location = New System.Drawing.Point(275, 523)
        ASALabel.Name = "ASALabel"
        ASALabel.Size = New System.Drawing.Size(31, 13)
        ASALabel.TabIndex = 13
        ASALabel.Text = "ASA:"
        '
        'Preoperativno_brijanjeLabel
        '
        Preoperativno_brijanjeLabel.AutoSize = True
        Preoperativno_brijanjeLabel.Location = New System.Drawing.Point(24, 498)
        Preoperativno_brijanjeLabel.Name = "Preoperativno_brijanjeLabel"
        Preoperativno_brijanjeLabel.Size = New System.Drawing.Size(112, 13)
        Preoperativno_brijanjeLabel.TabIndex = 15
        Preoperativno_brijanjeLabel.Text = "Preoperativno brijanje:"
        '
        'Intraop_transfuzijaLabel
        '
        Intraop_transfuzijaLabel.AutoSize = True
        Intraop_transfuzijaLabel.Location = New System.Drawing.Point(24, 546)
        Intraop_transfuzijaLabel.Name = "Intraop_transfuzijaLabel"
        Intraop_transfuzijaLabel.Size = New System.Drawing.Size(93, 13)
        Intraop_transfuzijaLabel.TabIndex = 17
        Intraop_transfuzijaLabel.Text = "Intraop transfuzija:"
        '
        'DrenLabel
        '
        DrenLabel.AutoSize = True
        DrenLabel.Location = New System.Drawing.Point(24, 569)
        DrenLabel.Name = "DrenLabel"
        DrenLabel.Size = New System.Drawing.Size(33, 13)
        DrenLabel.TabIndex = 19
        DrenLabel.Text = "Dren:"
        '
        'OperaterLabel
        '
        OperaterLabel.AutoSize = True
        OperaterLabel.Location = New System.Drawing.Point(21, 166)
        OperaterLabel.Name = "OperaterLabel"
        OperaterLabel.Size = New System.Drawing.Size(51, 13)
        OperaterLabel.TabIndex = 21
        OperaterLabel.Text = "Operater:"
        '
        'AsistentLabel
        '
        AsistentLabel.AutoSize = True
        AsistentLabel.Location = New System.Drawing.Point(21, 192)
        AsistentLabel.Name = "AsistentLabel"
        AsistentLabel.Size = New System.Drawing.Size(47, 13)
        AsistentLabel.TabIndex = 23
        AsistentLabel.Text = "Asistent:"
        '
        'InstrumentarkaLabel
        '
        InstrumentarkaLabel.AutoSize = True
        InstrumentarkaLabel.Location = New System.Drawing.Point(21, 218)
        InstrumentarkaLabel.Name = "InstrumentarkaLabel"
        InstrumentarkaLabel.Size = New System.Drawing.Size(80, 13)
        InstrumentarkaLabel.TabIndex = 25
        InstrumentarkaLabel.Text = "Instrumentarka:"
        '
        'OperacijaLabel
        '
        OperacijaLabel.AutoSize = True
        OperacijaLabel.Location = New System.Drawing.Point(24, 434)
        OperacijaLabel.Name = "OperacijaLabel"
        OperacijaLabel.Size = New System.Drawing.Size(55, 13)
        OperacijaLabel.TabIndex = 27
        OperacijaLabel.Text = "Operacija:"
        '
        'Preoperativno_klipanjeLabel
        '
        Preoperativno_klipanjeLabel.AutoSize = True
        Preoperativno_klipanjeLabel.Location = New System.Drawing.Point(24, 522)
        Preoperativno_klipanjeLabel.Name = "Preoperativno_klipanjeLabel"
        Preoperativno_klipanjeLabel.Size = New System.Drawing.Size(115, 13)
        Preoperativno_klipanjeLabel.TabIndex = 35
        Preoperativno_klipanjeLabel.Text = "Preoperativno klipanje:"
        '
        'ProtokolBRLabel
        '
        ProtokolBRLabel.AutoSize = True
        ProtokolBRLabel.Location = New System.Drawing.Point(21, 105)
        ProtokolBRLabel.Name = "ProtokolBRLabel"
        ProtokolBRLabel.Size = New System.Drawing.Size(67, 13)
        ProtokolBRLabel.TabIndex = 41
        ProtokolBRLabel.Text = "Protokol BR:"
        '
        'MaticniBRLabel
        '
        MaticniBRLabel.AutoSize = True
        MaticniBRLabel.Location = New System.Drawing.Point(386, 105)
        MaticniBRLabel.Name = "MaticniBRLabel"
        MaticniBRLabel.Size = New System.Drawing.Size(62, 13)
        MaticniBRLabel.TabIndex = 43
        MaticniBRLabel.Text = "Maticni BR:"
        '
        'Početak_operacijeLabel
        '
        Početak_operacijeLabel.AutoSize = True
        Početak_operacijeLabel.Location = New System.Drawing.Point(399, 132)
        Početak_operacijeLabel.Name = "Početak_operacijeLabel"
        Početak_operacijeLabel.Size = New System.Drawing.Size(96, 13)
        Početak_operacijeLabel.TabIndex = 45
        Početak_operacijeLabel.Text = "Početak operacije:"
        '
        'Kraj_operacijeLabel
        '
        Kraj_operacijeLabel.AutoSize = True
        Kraj_operacijeLabel.Location = New System.Drawing.Point(595, 132)
        Kraj_operacijeLabel.Name = "Kraj_operacijeLabel"
        Kraj_operacijeLabel.Size = New System.Drawing.Size(74, 13)
        Kraj_operacijeLabel.TabIndex = 47
        Kraj_operacijeLabel.Text = "Kraj operacije:"
        '
        'Trajanje_operacijeLabel
        '
        Trajanje_operacijeLabel.AutoSize = True
        Trajanje_operacijeLabel.Location = New System.Drawing.Point(770, 132)
        Trajanje_operacijeLabel.Name = "Trajanje_operacijeLabel"
        Trajanje_operacijeLabel.Size = New System.Drawing.Size(94, 13)
        Trajanje_operacijeLabel.TabIndex = 48
        Trajanje_operacijeLabel.Text = "Trajanje operacije:"
        '
        'Datum_operacijeDateTimePicker
        '
        Me.Datum_operacijeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Datum_operacije", True))
        Me.Datum_operacijeDateTimePicker.Location = New System.Drawing.Point(111, 128)
        Me.Datum_operacijeDateTimePicker.Name = "Datum_operacijeDateTimePicker"
        Me.Datum_operacijeDateTimePicker.Size = New System.Drawing.Size(118, 20)
        Me.Datum_operacijeDateTimePicker.TabIndex = 6
        '
        'OperacijaBindingSource
        '
        Me.OperacijaBindingSource.DataMember = "Operacija"
        Me.OperacijaBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hitna_operacijaCheckBox
        '
        Me.Hitna_operacijaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OperacijaBindingSource, "Hitna_operacija", True))
        Me.Hitna_operacijaCheckBox.Location = New System.Drawing.Point(341, 127)
        Me.Hitna_operacijaCheckBox.Name = "Hitna_operacijaCheckBox"
        Me.Hitna_operacijaCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.Hitna_operacijaCheckBox.TabIndex = 10
        Me.Hitna_operacijaCheckBox.UseVisualStyleBackColor = True
        '
        'Preoperativno_brijanjeCheckBox
        '
        Me.Preoperativno_brijanjeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OperacijaBindingSource, "Preoperativno_brijanje", True))
        Me.Preoperativno_brijanjeCheckBox.Location = New System.Drawing.Point(145, 493)
        Me.Preoperativno_brijanjeCheckBox.Name = "Preoperativno_brijanjeCheckBox"
        Me.Preoperativno_brijanjeCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.Preoperativno_brijanjeCheckBox.TabIndex = 16
        Me.Preoperativno_brijanjeCheckBox.UseVisualStyleBackColor = True
        '
        'Intraop_transfuzijaCheckBox
        '
        Me.Intraop_transfuzijaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OperacijaBindingSource, "Intraop_transfuzija", True))
        Me.Intraop_transfuzijaCheckBox.Location = New System.Drawing.Point(145, 541)
        Me.Intraop_transfuzijaCheckBox.Name = "Intraop_transfuzijaCheckBox"
        Me.Intraop_transfuzijaCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.Intraop_transfuzijaCheckBox.TabIndex = 18
        Me.Intraop_transfuzijaCheckBox.UseVisualStyleBackColor = True
        '
        'DrenCheckBox
        '
        Me.DrenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OperacijaBindingSource, "Dren", True))
        Me.DrenCheckBox.Location = New System.Drawing.Point(145, 564)
        Me.DrenCheckBox.Name = "DrenCheckBox"
        Me.DrenCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.DrenCheckBox.TabIndex = 20
        Me.DrenCheckBox.UseVisualStyleBackColor = True
        '
        'OperaterTextBox
        '
        Me.OperaterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Operater", True))
        Me.OperaterTextBox.Location = New System.Drawing.Point(142, 163)
        Me.OperaterTextBox.Name = "OperaterTextBox"
        Me.OperaterTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OperaterTextBox.TabIndex = 22
        '
        'AsistentTextBox
        '
        Me.AsistentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Asistent", True))
        Me.AsistentTextBox.Location = New System.Drawing.Point(142, 189)
        Me.AsistentTextBox.Name = "AsistentTextBox"
        Me.AsistentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AsistentTextBox.TabIndex = 24
        '
        'InstrumentarkaTextBox
        '
        Me.InstrumentarkaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Instrumentarka", True))
        Me.InstrumentarkaTextBox.Location = New System.Drawing.Point(142, 215)
        Me.InstrumentarkaTextBox.Name = "InstrumentarkaTextBox"
        Me.InstrumentarkaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InstrumentarkaTextBox.TabIndex = 26
        '
        'Preoperativno_klipanjeCheckBox
        '
        Me.Preoperativno_klipanjeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OperacijaBindingSource, "Preoperativno_klipanje", True))
        Me.Preoperativno_klipanjeCheckBox.Location = New System.Drawing.Point(145, 517)
        Me.Preoperativno_klipanjeCheckBox.Name = "Preoperativno_klipanjeCheckBox"
        Me.Preoperativno_klipanjeCheckBox.Size = New System.Drawing.Size(35, 24)
        Me.Preoperativno_klipanjeCheckBox.TabIndex = 36
        Me.Preoperativno_klipanjeCheckBox.UseVisualStyleBackColor = True
        '
        'ProtokolBRTextBox
        '
        Me.ProtokolBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "ProtokolBR", True))
        Me.ProtokolBRTextBox.Location = New System.Drawing.Point(94, 102)
        Me.ProtokolBRTextBox.Name = "ProtokolBRTextBox"
        Me.ProtokolBRTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProtokolBRTextBox.TabIndex = 42
        '
        'MaticniBRTextBox
        '
        Me.MaticniBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "MaticniBR", True))
        Me.MaticniBRTextBox.Location = New System.Drawing.Point(454, 102)
        Me.MaticniBRTextBox.Name = "MaticniBRTextBox"
        Me.MaticniBRTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MaticniBRTextBox.TabIndex = 44
        '
        'Početak_operacijeDateTimePicker
        '
        Me.Početak_operacijeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Početak_operacije", True))
        Me.Početak_operacijeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Početak_operacijeDateTimePicker.Location = New System.Drawing.Point(498, 128)
        Me.Početak_operacijeDateTimePicker.Name = "Početak_operacijeDateTimePicker"
        Me.Početak_operacijeDateTimePicker.ShowUpDown = True
        Me.Početak_operacijeDateTimePicker.Size = New System.Drawing.Size(74, 20)
        Me.Početak_operacijeDateTimePicker.TabIndex = 46
        '
        'Kraj_operacijeDateTimePicker
        '
        Me.Kraj_operacijeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Kraj_operacije", True))
        Me.Kraj_operacijeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Kraj_operacijeDateTimePicker.Location = New System.Drawing.Point(675, 128)
        Me.Kraj_operacijeDateTimePicker.Name = "Kraj_operacijeDateTimePicker"
        Me.Kraj_operacijeDateTimePicker.ShowUpDown = True
        Me.Kraj_operacijeDateTimePicker.Size = New System.Drawing.Size(67, 20)
        Me.Kraj_operacijeDateTimePicker.TabIndex = 48
        '
        'Trajanje_operacijeTextBox
        '
        Me.Trajanje_operacijeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Trajanje_operacije", True))
        Me.Trajanje_operacijeTextBox.Location = New System.Drawing.Point(870, 129)
        Me.Trajanje_operacijeTextBox.Name = "Trajanje_operacijeTextBox"
        Me.Trajanje_operacijeTextBox.Size = New System.Drawing.Size(69, 20)
        Me.Trajanje_operacijeTextBox.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(945, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "minuta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Postupci"
        '
        'PostupciGridView
        '
        Me.PostupciGridView.AllowUserToAddRows = False
        Me.PostupciGridView.AllowUserToDeleteRows = False
        Me.PostupciGridView.AutoGenerateColumns = False
        Me.PostupciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PostupciGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SifraDataGridViewTextBoxColumn, Me.NazivDataGridViewTextBoxColumn})
        Me.PostupciGridView.DataSource = Me.DTSBindingSource
        Me.PostupciGridView.Location = New System.Drawing.Point(24, 267)
        Me.PostupciGridView.Name = "PostupciGridView"
        Me.PostupciGridView.ReadOnly = True
        Me.PostupciGridView.RowHeadersVisible = False
        Me.PostupciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PostupciGridView.Size = New System.Drawing.Size(539, 150)
        Me.PostupciGridView.TabIndex = 55
        '
        'SifraDataGridViewTextBoxColumn
        '
        Me.SifraDataGridViewTextBoxColumn.DataPropertyName = "Sifra"
        Me.SifraDataGridViewTextBoxColumn.HeaderText = "Šifra"
        Me.SifraDataGridViewTextBoxColumn.Name = "SifraDataGridViewTextBoxColumn"
        Me.SifraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NazivDataGridViewTextBoxColumn
        '
        Me.NazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.HeaderText = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.Name = "NazivDataGridViewTextBoxColumn"
        Me.NazivDataGridViewTextBoxColumn.ReadOnly = True
        Me.NazivDataGridViewTextBoxColumn.Width = 400
        '
        'DTSBindingSource
        '
        Me.DTSBindingSource.DataMember = "DTS"
        Me.DTSBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Image = Global.Škrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(883, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Izlazak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StacGridView
        '
        Me.StacGridView.AllowUserToAddRows = False
        Me.StacGridView.AllowUserToDeleteRows = False
        Me.StacGridView.AutoGenerateColumns = False
        Me.StacGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StacGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SifraDataGridViewTextBoxColumn1, Me.NazivNezasticeniDataGridViewTextBoxColumn})
        Me.StacGridView.DataSource = Me.STACBindingSource
        Me.StacGridView.Location = New System.Drawing.Point(598, 267)
        Me.StacGridView.Name = "StacGridView"
        Me.StacGridView.ReadOnly = True
        Me.StacGridView.RowHeadersVisible = False
        Me.StacGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StacGridView.Size = New System.Drawing.Size(385, 150)
        Me.StacGridView.TabIndex = 57
        '
        'SifraDataGridViewTextBoxColumn1
        '
        Me.SifraDataGridViewTextBoxColumn1.DataPropertyName = "Sifra"
        Me.SifraDataGridViewTextBoxColumn1.HeaderText = "Šifra"
        Me.SifraDataGridViewTextBoxColumn1.Name = "SifraDataGridViewTextBoxColumn1"
        Me.SifraDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NazivNezasticeniDataGridViewTextBoxColumn
        '
        Me.NazivNezasticeniDataGridViewTextBoxColumn.DataPropertyName = "NazivNezasticeni"
        Me.NazivNezasticeniDataGridViewTextBoxColumn.HeaderText = "Naziv"
        Me.NazivNezasticeniDataGridViewTextBoxColumn.Name = "NazivNezasticeniDataGridViewTextBoxColumn"
        Me.NazivNezasticeniDataGridViewTextBoxColumn.ReadOnly = True
        Me.NazivNezasticeniDataGridViewTextBoxColumn.Width = 250
        '
        'STACBindingSource
        '
        Me.STACBindingSource.DataMember = "STAC"
        Me.STACBindingSource.DataSource = Me.DataSet1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Materijali"
        '
        'Button_Konac_za_kožu
        '
        Me.Button_Konac_za_kožu.Location = New System.Drawing.Point(749, 239)
        Me.Button_Konac_za_kožu.Name = "Button_Konac_za_kožu"
        Me.Button_Konac_za_kožu.Size = New System.Drawing.Size(103, 23)
        Me.Button_Konac_za_kožu.TabIndex = 59
        Me.Button_Konac_za_kožu.Text = "Konac za kožu"
        Me.Button_Konac_za_kožu.UseVisualStyleBackColor = True
        '
        'Button_Strano_tijelo
        '
        Me.Button_Strano_tijelo.Location = New System.Drawing.Point(858, 239)
        Me.Button_Strano_tijelo.Name = "Button_Strano_tijelo"
        Me.Button_Strano_tijelo.Size = New System.Drawing.Size(103, 23)
        Me.Button_Strano_tijelo.TabIndex = 60
        Me.Button_Strano_tijelo.Text = "Strano tijelo"
        Me.Button_Strano_tijelo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Konac za kožu:"
        '
        'Konac_za_kožuID
        '
        Me.Konac_za_kožuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Konac_za_kožuID", True))
        Me.Konac_za_kožuID.Location = New System.Drawing.Point(691, 431)
        Me.Konac_za_kožuID.Name = "Konac_za_kožuID"
        Me.Konac_za_kožuID.Size = New System.Drawing.Size(65, 20)
        Me.Konac_za_kožuID.TabIndex = 62
        '
        'Strano_tijeloID
        '
        Me.Strano_tijeloID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperacijaBindingSource, "Strano_tijeloID", True))
        Me.Strano_tijeloID.Location = New System.Drawing.Point(691, 456)
        Me.Strano_tijeloID.Name = "Strano_tijeloID"
        Me.Strano_tijeloID.Size = New System.Drawing.Size(65, 20)
        Me.Strano_tijeloID.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(603, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Strano tijelo:"
        '
        'Konac_za_kožu_Label
        '
        Me.Konac_za_kožu_Label.AutoSize = True
        Me.Konac_za_kožu_Label.Location = New System.Drawing.Point(762, 434)
        Me.Konac_za_kožu_Label.Name = "Konac_za_kožu_Label"
        Me.Konac_za_kožu_Label.Size = New System.Drawing.Size(10, 13)
        Me.Konac_za_kožu_Label.TabIndex = 65
        Me.Konac_za_kožu_Label.Text = " "
        '
        'Strano_tijelo_Label
        '
        Me.Strano_tijelo_Label.AutoSize = True
        Me.Strano_tijelo_Label.Location = New System.Drawing.Point(762, 459)
        Me.Strano_tijelo_Label.Name = "Strano_tijelo_Label"
        Me.Strano_tijelo_Label.Size = New System.Drawing.Size(10, 13)
        Me.Strano_tijelo_Label.TabIndex = 66
        Me.Strano_tijelo_Label.Text = " "
        '
        'DTSTableAdapter
        '
        Me.DTSTableAdapter.ClearBeforeFill = True
        '
        'STACTableAdapter
        '
        Me.STACTableAdapter.ClearBeforeFill = True
        '
        'Generalije_Control1
        '
        Me.Generalije_Control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Generalije_Control1.Location = New System.Drawing.Point(13, 13)
        Me.Generalije_Control1.Name = "Generalije_Control1"
        Me.Generalije_Control1.R = Nothing
        Me.Generalije_Control1.Size = New System.Drawing.Size(495, 71)
        Me.Generalije_Control1.TabIndex = 56
        '
        'OperacijaTableAdapter
        '
        Me.OperacijaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ASATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoravciTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_LijekTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_MKBTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.InfekcijaTableAdapter = Nothing
        Me.TableAdapterManager.OperacijaTableAdapter = Me.OperacijaTableAdapter
        Me.TableAdapterManager.Tipovi_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Škrlin.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vrste_AnestezijeTableAdapter = Nothing
        Me.TableAdapterManager.Vrste_InfekcijeTableAdapter = Nothing
        '
        'OperacijaComboBox
        '
        Me.OperacijaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoviOperacijaBindingSource, "Puni_naziv", True))
        Me.OperacijaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OperacijaBindingSource, "Operacija", True))
        Me.OperacijaComboBox.DataSource = Me.TipoviOperacijaBindingSource
        Me.OperacijaComboBox.DisplayMember = "Puni_naziv"
        Me.OperacijaComboBox.FormattingEnabled = True
        Me.OperacijaComboBox.Location = New System.Drawing.Point(85, 431)
        Me.OperacijaComboBox.Name = "OperacijaComboBox"
        Me.OperacijaComboBox.Size = New System.Drawing.Size(478, 21)
        Me.OperacijaComboBox.TabIndex = 67
        Me.OperacijaComboBox.ValueMember = "Puni_naziv"
        '
        'TipoviOperacijaBindingSource
        '
        Me.TipoviOperacijaBindingSource.DataMember = "Tipovi_Operacija"
        Me.TipoviOperacijaBindingSource.DataSource = Me.DataSet2
        '
        'Tipovi_OperacijaTableAdapter
        '
        Me.Tipovi_OperacijaTableAdapter.ClearBeforeFill = True
        '
        'VrstaAnestezijeComboBox
        '
        Me.VrstaAnestezijeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OperacijaBindingSource, "Vrsta_anestezije", True))
        Me.VrstaAnestezijeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VrsteAnestezijeBindingSource, "Naziv_Anestezije", True))
        Me.VrstaAnestezijeComboBox.DataSource = Me.VrsteAnestezijeBindingSource
        Me.VrstaAnestezijeComboBox.DisplayMember = "Naziv_Anestezije"
        Me.VrstaAnestezijeComboBox.FormattingEnabled = True
        Me.VrstaAnestezijeComboBox.Location = New System.Drawing.Point(365, 495)
        Me.VrstaAnestezijeComboBox.Name = "VrstaAnestezijeComboBox"
        Me.VrstaAnestezijeComboBox.Size = New System.Drawing.Size(160, 21)
        Me.VrstaAnestezijeComboBox.TabIndex = 68
        Me.VrstaAnestezijeComboBox.ValueMember = "Naziv_Anestezije"
        '
        'VrsteAnestezijeBindingSource
        '
        Me.VrsteAnestezijeBindingSource.DataMember = "Vrste_Anestezije"
        Me.VrsteAnestezijeBindingSource.DataSource = Me.DataSet2
        '
        'Vrste_AnestezijeTableAdapter
        '
        Me.Vrste_AnestezijeTableAdapter.ClearBeforeFill = True
        '
        'ASABindingSource
        '
        Me.ASABindingSource.DataMember = "ASA"
        Me.ASABindingSource.DataSource = Me.DataSet2
        '
        'ASATableAdapter
        '
        Me.ASATableAdapter.ClearBeforeFill = True
        '
        'MultipleCheckBoxUserControl1
        '
        Me.MultipleCheckBoxUserControl1.DataBindings.Add(New System.Windows.Forms.Binding("V", Me.OperacijaBindingSource, "ASA", True))
        Me.MultipleCheckBoxUserControl1.Descriptors = New String() {"1", "2", "3", "4", "5"}
        Me.MultipleCheckBoxUserControl1.HOrientation = True
        Me.MultipleCheckBoxUserControl1.HStep = 50
        Me.MultipleCheckBoxUserControl1.Location = New System.Drawing.Point(365, 520)
        Me.MultipleCheckBoxUserControl1.Name = "MultipleCheckBoxUserControl1"
        Me.MultipleCheckBoxUserControl1.Num_Boxes = 5
        Me.MultipleCheckBoxUserControl1.Show_Text = True
        Me.MultipleCheckBoxUserControl1.Size = New System.Drawing.Size(260, 20)
        Me.MultipleCheckBoxUserControl1.TabIndex = 71
        Me.MultipleCheckBoxUserControl1.V = 0
        Me.MultipleCheckBoxUserControl1.VStep = 20
        '
        'Button2
        '
        Me.Button2.Image = Global.Škrlin.My.Resources.Resources.document_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(883, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "OP Lista"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Operacija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 610)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MultipleCheckBoxUserControl1)
        Me.Controls.Add(Me.VrstaAnestezijeComboBox)
        Me.Controls.Add(Me.OperacijaComboBox)
        Me.Controls.Add(Me.Strano_tijelo_Label)
        Me.Controls.Add(Me.Konac_za_kožu_Label)
        Me.Controls.Add(Me.Strano_tijeloID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Konac_za_kožuID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_Strano_tijelo)
        Me.Controls.Add(Me.Button_Konac_za_kožu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StacGridView)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Controls.Add(Me.PostupciGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Trajanje_operacijeLabel)
        Me.Controls.Add(Me.Trajanje_operacijeTextBox)
        Me.Controls.Add(Datum_operacijeLabel)
        Me.Controls.Add(Me.Datum_operacijeDateTimePicker)
        Me.Controls.Add(Vrsta_anestezijeLabel)
        Me.Controls.Add(Hitna_operacijaLabel)
        Me.Controls.Add(Me.Hitna_operacijaCheckBox)
        Me.Controls.Add(ASALabel)
        Me.Controls.Add(Preoperativno_brijanjeLabel)
        Me.Controls.Add(Me.Preoperativno_brijanjeCheckBox)
        Me.Controls.Add(Intraop_transfuzijaLabel)
        Me.Controls.Add(Me.Intraop_transfuzijaCheckBox)
        Me.Controls.Add(DrenLabel)
        Me.Controls.Add(Me.DrenCheckBox)
        Me.Controls.Add(OperaterLabel)
        Me.Controls.Add(Me.OperaterTextBox)
        Me.Controls.Add(AsistentLabel)
        Me.Controls.Add(Me.AsistentTextBox)
        Me.Controls.Add(InstrumentarkaLabel)
        Me.Controls.Add(Me.InstrumentarkaTextBox)
        Me.Controls.Add(OperacijaLabel)
        Me.Controls.Add(Preoperativno_klipanjeLabel)
        Me.Controls.Add(Me.Preoperativno_klipanjeCheckBox)
        Me.Controls.Add(ProtokolBRLabel)
        Me.Controls.Add(Me.ProtokolBRTextBox)
        Me.Controls.Add(MaticniBRLabel)
        Me.Controls.Add(Me.MaticniBRTextBox)
        Me.Controls.Add(Početak_operacijeLabel)
        Me.Controls.Add(Me.Početak_operacijeDateTimePicker)
        Me.Controls.Add(Kraj_operacijeLabel)
        Me.Controls.Add(Me.Kraj_operacijeDateTimePicker)
        Me.Location = New System.Drawing.Point(100, 50)
        Me.Name = "Operacija"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Operacija"
        CType(Me.OperacijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostupciGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StacGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STACBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoviOperacijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrsteAnestezijeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OperacijaTableAdapter As Škrlin.DataSet2TableAdapters.OperacijaTableAdapter
    Friend WithEvents TableAdapterManager As Škrlin.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Datum_operacijeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hitna_operacijaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Preoperativno_brijanjeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Intraop_transfuzijaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DrenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OperaterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AsistentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InstrumentarkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Preoperativno_klipanjeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProtokolBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaticniBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Početak_operacijeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Kraj_operacijeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Trajanje_operacijeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PostupciGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SifraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazivDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Škrlin.DataSet1
    Friend WithEvents DTSTableAdapter As Škrlin.DataSet1TableAdapters.DTSTableAdapter
    Friend WithEvents DataSet2 As Škrlin.DataSet2
    Friend WithEvents OperacijaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Generalije_Control1 As Škrlin.Generalije_Control
    Friend WithEvents StacGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SifraDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazivNezasticeniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STACBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STACTableAdapter As Škrlin.DataSet1TableAdapters.STACTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_Konac_za_kožu As System.Windows.Forms.Button
    Friend WithEvents Button_Strano_tijelo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Konac_za_kožuID As System.Windows.Forms.TextBox
    Friend WithEvents Strano_tijeloID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Konac_za_kožu_Label As System.Windows.Forms.Label
    Friend WithEvents Strano_tijelo_Label As System.Windows.Forms.Label
    Friend WithEvents OperacijaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoviOperacijaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipovi_OperacijaTableAdapter As Škrlin.DataSet2TableAdapters.Tipovi_OperacijaTableAdapter
    Friend WithEvents VrstaAnestezijeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VrsteAnestezijeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vrste_AnestezijeTableAdapter As Škrlin.DataSet2TableAdapters.Vrste_AnestezijeTableAdapter
    Friend WithEvents ASABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASATableAdapter As Škrlin.DataSet2TableAdapters.ASATableAdapter
    Friend WithEvents MultipleCheckBoxUserControl1 As Škrlin.MultipleCheckBoxUserControl
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
