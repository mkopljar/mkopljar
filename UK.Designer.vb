<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UK
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
        Dim Datum_stavljanjaLabel As System.Windows.Forms.Label
        Dim RadilišteLabel As System.Windows.Forms.Label
        Dim LijecnikLabel As System.Windows.Forms.Label
        Dim SestraLabel As System.Windows.Forms.Label
        Dim HitnoLabel As System.Windows.Forms.Label
        Dim Datum_vađenjaLabel As System.Windows.Forms.Label
        Dim Razlog_vađenjaLabel As System.Windows.Forms.Label
        Dim NapomenaLabel As System.Windows.Forms.Label
        Dim HigijenaLabel As System.Windows.Forms.Label
        Dim Zastitna_odjecaLabel As System.Windows.Forms.Label
        Dim Antisepsa_kozeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UK))
        Dim Pravila_asepseLabel As System.Windows.Forms.Label
        Dim Mjesto_insercijeLabel As System.Windows.Forms.Label
        Dim IndikacijaLabel As System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet4 = New Skrlin.DataSet4()
        Me.Pacijent_IDTextBox = New System.Windows.Forms.TextBox()
        Me.RegistarskiBRTextBox = New System.Windows.Forms.TextBox()
        Me.MaticniBRTextBox = New System.Windows.Forms.TextBox()
        Me.RadilišteTextBox = New System.Windows.Forms.TextBox()
        Me.LijecnikTextBox = New System.Windows.Forms.TextBox()
        Me.SestraTextBox = New System.Windows.Forms.TextBox()
        Me.HitnoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Zapamti = New System.Windows.Forms.Button()
        Me.Povratak = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Datum_stavljanjaTextBox = New System.Windows.Forms.TextBox()
        Me.Datum_vađenjaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.NapomenaTextBox = New System.Windows.Forms.TextBox()
        Me.HigijenaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Zastitna_odjecaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Antisepsa_kozeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Pravila_asepseCheckBox = New System.Windows.Forms.CheckBox()
        Me.Mjesto_insercijeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Generalije_Control1 = New Skrlin.Generalije_Control()
        Me.Radiliste_tekstTextBox = New System.Windows.Forms.TextBox()
        Me.UKTableAdapter = New Skrlin.DataSet4TableAdapters.UKTableAdapter()
        Me.TableAdapterManager = New Skrlin.DataSet4TableAdapters.TableAdapterManager()
        Me.IndikacijaComboBox = New System.Windows.Forms.ComboBox()
        Datum_stavljanjaLabel = New System.Windows.Forms.Label()
        RadilišteLabel = New System.Windows.Forms.Label()
        LijecnikLabel = New System.Windows.Forms.Label()
        SestraLabel = New System.Windows.Forms.Label()
        HitnoLabel = New System.Windows.Forms.Label()
        Datum_vađenjaLabel = New System.Windows.Forms.Label()
        Razlog_vađenjaLabel = New System.Windows.Forms.Label()
        NapomenaLabel = New System.Windows.Forms.Label()
        HigijenaLabel = New System.Windows.Forms.Label()
        Zastitna_odjecaLabel = New System.Windows.Forms.Label()
        Antisepsa_kozeLabel = New System.Windows.Forms.Label()
        Pravila_asepseLabel = New System.Windows.Forms.Label()
        Mjesto_insercijeLabel = New System.Windows.Forms.Label()
        IndikacijaLabel = New System.Windows.Forms.Label()
        CType(Me.UKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datum_stavljanjaLabel
        '
        Datum_stavljanjaLabel.AutoSize = True
        Datum_stavljanjaLabel.Location = New System.Drawing.Point(12, 147)
        Datum_stavljanjaLabel.Name = "Datum_stavljanjaLabel"
        Datum_stavljanjaLabel.Size = New System.Drawing.Size(88, 13)
        Datum_stavljanjaLabel.TabIndex = 9
        Datum_stavljanjaLabel.Text = "Datum stavljanja:"
        '
        'RadilišteLabel
        '
        RadilišteLabel.AutoSize = True
        RadilišteLabel.Location = New System.Drawing.Point(12, 172)
        RadilišteLabel.Name = "RadilišteLabel"
        RadilišteLabel.Size = New System.Drawing.Size(50, 13)
        RadilišteLabel.TabIndex = 11
        RadilišteLabel.Text = "Radilište:"
        '
        'LijecnikLabel
        '
        LijecnikLabel.AutoSize = True
        LijecnikLabel.Location = New System.Drawing.Point(12, 198)
        LijecnikLabel.Name = "LijecnikLabel"
        LijecnikLabel.Size = New System.Drawing.Size(46, 13)
        LijecnikLabel.TabIndex = 17
        LijecnikLabel.Text = "Lijecnik:"
        '
        'SestraLabel
        '
        SestraLabel.AutoSize = True
        SestraLabel.Location = New System.Drawing.Point(309, 198)
        SestraLabel.Name = "SestraLabel"
        SestraLabel.Size = New System.Drawing.Size(40, 13)
        SestraLabel.TabIndex = 19
        SestraLabel.Text = "Sestra:"
        '
        'HitnoLabel
        '
        HitnoLabel.AutoSize = True
        HitnoLabel.Location = New System.Drawing.Point(274, 148)
        HitnoLabel.Name = "HitnoLabel"
        HitnoLabel.Size = New System.Drawing.Size(35, 13)
        HitnoLabel.TabIndex = 21
        HitnoLabel.Text = "Hitno:"
        '
        'Datum_vađenjaLabel
        '
        Datum_vađenjaLabel.AutoSize = True
        Datum_vađenjaLabel.Location = New System.Drawing.Point(12, 329)
        Datum_vađenjaLabel.Name = "Datum_vađenjaLabel"
        Datum_vađenjaLabel.Size = New System.Drawing.Size(83, 13)
        Datum_vađenjaLabel.TabIndex = 23
        Datum_vađenjaLabel.Text = "Datum vađenja:"
        '
        'Razlog_vađenjaLabel
        '
        Razlog_vađenjaLabel.AutoSize = True
        Razlog_vađenjaLabel.Location = New System.Drawing.Point(12, 354)
        Razlog_vađenjaLabel.Name = "Razlog_vađenjaLabel"
        Razlog_vađenjaLabel.Size = New System.Drawing.Size(85, 13)
        Razlog_vađenjaLabel.TabIndex = 25
        Razlog_vađenjaLabel.Text = "Razlog vađenja:"
        '
        'NapomenaLabel
        '
        NapomenaLabel.AutoSize = True
        NapomenaLabel.Location = New System.Drawing.Point(12, 384)
        NapomenaLabel.Name = "NapomenaLabel"
        NapomenaLabel.Size = New System.Drawing.Size(62, 13)
        NapomenaLabel.TabIndex = 43
        NapomenaLabel.Text = "Napomena:"
        '
        'HigijenaLabel
        '
        HigijenaLabel.AutoSize = True
        HigijenaLabel.Location = New System.Drawing.Point(543, 133)
        HigijenaLabel.Name = "HigijenaLabel"
        HigijenaLabel.Size = New System.Drawing.Size(215, 39)
        HigijenaLabel.TabIndex = 44
        HigijenaLabel.Text = "HIGIJENA RUKU   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pranje ruku tekućim  sapunom i  vodom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Antisepsa  Desderman N  " & _
    "prije uvođenja UK"
        '
        'Zastitna_odjecaLabel
        '
        Zastitna_odjecaLabel.AutoSize = True
        Zastitna_odjecaLabel.Location = New System.Drawing.Point(543, 197)
        Zastitna_odjecaLabel.Name = "Zastitna_odjecaLabel"
        Zastitna_odjecaLabel.Size = New System.Drawing.Size(297, 26)
        Zastitna_odjecaLabel.TabIndex = 45
        Zastitna_odjecaLabel.Text = "PRIPREMA MATERIJALA  - prema Mapi protokola, PBI KBD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "„Postavljanje i održavanje" & _
    " urinarnog katetera"""
        '
        'Antisepsa_kozeLabel
        '
        Antisepsa_kozeLabel.AutoSize = True
        Antisepsa_kozeLabel.Location = New System.Drawing.Point(543, 246)
        Antisepsa_kozeLabel.Name = "Antisepsa_kozeLabel"
        Antisepsa_kozeLabel.Size = New System.Drawing.Size(352, 52)
        Antisepsa_kozeLabel.TabIndex = 46
        Antisepsa_kozeLabel.Text = resources.GetString("Antisepsa_kozeLabel.Text")
        '
        'Pravila_asepseLabel
        '
        Pravila_asepseLabel.AutoSize = True
        Pravila_asepseLabel.Location = New System.Drawing.Point(543, 314)
        Pravila_asepseLabel.Name = "Pravila_asepseLabel"
        Pravila_asepseLabel.Size = New System.Drawing.Size(226, 39)
        Pravila_asepseLabel.TabIndex = 47
        Pravila_asepseLabel.Text = "KORISTITI ZATVORENI SUSTAV DRENAŽE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sterilna drenažna vrećica  sa ispustom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "smješ" & _
    "tena ispod razine mokraćnog mjehura"
        '
        'Mjesto_insercijeLabel
        '
        Mjesto_insercijeLabel.AutoSize = True
        Mjesto_insercijeLabel.Location = New System.Drawing.Point(543, 377)
        Mjesto_insercijeLabel.Name = "Mjesto_insercijeLabel"
        Mjesto_insercijeLabel.Size = New System.Drawing.Size(156, 26)
        Mjesto_insercijeLabel.TabIndex = 48
        Mjesto_insercijeLabel.Text = "VELIČINA  KATETERA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Optimalna (16 - 18 CH) ili 20 CH"
        '
        'IndikacijaLabel
        '
        IndikacijaLabel.AutoSize = True
        IndikacijaLabel.Location = New System.Drawing.Point(12, 241)
        IndikacijaLabel.Name = "IndikacijaLabel"
        IndikacijaLabel.Size = New System.Drawing.Size(55, 13)
        IndikacijaLabel.TabIndex = 50
        IndikacijaLabel.Text = "Indikacija:"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "ID", True))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.IDTextBox.Location = New System.Drawing.Point(12, 89)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(72, 13)
        Me.IDTextBox.TabIndex = 2
        Me.IDTextBox.TabStop = False
        '
        'UKBindingSource
        '
        Me.UKBindingSource.DataMember = "UK"
        Me.UKBindingSource.DataSource = Me.DataSet4
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pacijent_IDTextBox
        '
        Me.Pacijent_IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Pacijent_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pacijent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Pacijent_ID", True))
        Me.Pacijent_IDTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.Pacijent_IDTextBox.Location = New System.Drawing.Point(214, 89)
        Me.Pacijent_IDTextBox.Name = "Pacijent_IDTextBox"
        Me.Pacijent_IDTextBox.Size = New System.Drawing.Size(84, 13)
        Me.Pacijent_IDTextBox.TabIndex = 4
        Me.Pacijent_IDTextBox.TabStop = False
        '
        'RegistarskiBRTextBox
        '
        Me.RegistarskiBRTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RegistarskiBRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegistarskiBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "RegistarskiBR", True))
        Me.RegistarskiBRTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.RegistarskiBRTextBox.Location = New System.Drawing.Point(90, 89)
        Me.RegistarskiBRTextBox.Name = "RegistarskiBRTextBox"
        Me.RegistarskiBRTextBox.Size = New System.Drawing.Size(103, 13)
        Me.RegistarskiBRTextBox.TabIndex = 6
        Me.RegistarskiBRTextBox.TabStop = False
        '
        'MaticniBRTextBox
        '
        Me.MaticniBRTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MaticniBRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaticniBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "MaticniBR", True))
        Me.MaticniBRTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.MaticniBRTextBox.Location = New System.Drawing.Point(315, 89)
        Me.MaticniBRTextBox.Name = "MaticniBRTextBox"
        Me.MaticniBRTextBox.Size = New System.Drawing.Size(72, 13)
        Me.MaticniBRTextBox.TabIndex = 8
        Me.MaticniBRTextBox.TabStop = False
        '
        'RadilišteTextBox
        '
        Me.RadilišteTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RadilišteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RadilišteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Radilište", True))
        Me.RadilišteTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.RadilišteTextBox.Location = New System.Drawing.Point(205, 89)
        Me.RadilišteTextBox.Name = "RadilišteTextBox"
        Me.RadilišteTextBox.Size = New System.Drawing.Size(58, 13)
        Me.RadilišteTextBox.TabIndex = 12
        '
        'LijecnikTextBox
        '
        Me.LijecnikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Lijecnik", True))
        Me.LijecnikTextBox.Location = New System.Drawing.Point(104, 195)
        Me.LijecnikTextBox.Name = "LijecnikTextBox"
        Me.LijecnikTextBox.Size = New System.Drawing.Size(118, 20)
        Me.LijecnikTextBox.TabIndex = 18
        '
        'SestraTextBox
        '
        Me.SestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Sestra", True))
        Me.SestraTextBox.Location = New System.Drawing.Point(361, 195)
        Me.SestraTextBox.Name = "SestraTextBox"
        Me.SestraTextBox.Size = New System.Drawing.Size(118, 20)
        Me.SestraTextBox.TabIndex = 20
        '
        'HitnoCheckBox
        '
        Me.HitnoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Hitno", True))
        Me.HitnoCheckBox.Location = New System.Drawing.Point(315, 143)
        Me.HitnoCheckBox.Name = "HitnoCheckBox"
        Me.HitnoCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.HitnoCheckBox.TabIndex = 22
        Me.HitnoCheckBox.UseVisualStyleBackColor = True
        '
        'Zapamti
        '
        Me.Zapamti.Image = Global.Skrlin.My.Resources.Resources.document_icon
        Me.Zapamti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Zapamti.Location = New System.Drawing.Point(796, 343)
        Me.Zapamti.Name = "Zapamti"
        Me.Zapamti.Size = New System.Drawing.Size(95, 35)
        Me.Zapamti.TabIndex = 30
        Me.Zapamti.Text = "Zapamti"
        Me.Zapamti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Zapamti.UseVisualStyleBackColor = True
        '
        'Povratak
        '
        Me.Povratak.Image = Global.Skrlin.My.Resources.Resources.Icon_Exit1
        Me.Povratak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Povratak.Location = New System.Drawing.Point(796, 384)
        Me.Povratak.Name = "Povratak"
        Me.Povratak.Size = New System.Drawing.Size(95, 35)
        Me.Povratak.TabIndex = 29
        Me.Povratak.Text = "Povratak"
        Me.Povratak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Povratak.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Skrlin.My.Resources.Resources.Clipboard02
        Me.Button1.Location = New System.Drawing.Point(223, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 20)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(21, 20)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.Image = Global.Skrlin.My.Resources.Resources.Clipboard02
        Me.Button2.Location = New System.Drawing.Point(223, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 20)
        Me.Button2.TabIndex = 39
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(205, 326)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(21, 20)
        Me.DateTimePicker2.TabIndex = 38
        '
        'Datum_stavljanjaTextBox
        '
        Me.Datum_stavljanjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Datum_stavljanja", True))
        Me.Datum_stavljanjaTextBox.Location = New System.Drawing.Point(106, 144)
        Me.Datum_stavljanjaTextBox.Name = "Datum_stavljanjaTextBox"
        Me.Datum_stavljanjaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Datum_stavljanjaTextBox.TabIndex = 1
        '
        'Datum_vađenjaTextBox
        '
        Me.Datum_vađenjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Datum_vađenja", True))
        Me.Datum_vađenjaTextBox.Location = New System.Drawing.Point(106, 326)
        Me.Datum_vađenjaTextBox.Name = "Datum_vađenjaTextBox"
        Me.Datum_vađenjaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Datum_vađenjaTextBox.TabIndex = 41
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Radiliste.ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(375, 21)
        Me.ComboBox1.TabIndex = 42
        Me.ComboBox1.ValueMember = "Radiliste.ID"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Razlog_vađenja", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Prestanak indikacije", "Ispao/Iščupao", "Infekcija", "Drugo"})
        Me.ComboBox2.Location = New System.Drawing.Point(106, 351)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(261, 21)
        Me.ComboBox2.TabIndex = 43
        '
        'NapomenaTextBox
        '
        Me.NapomenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Napomena", True))
        Me.NapomenaTextBox.Location = New System.Drawing.Point(106, 381)
        Me.NapomenaTextBox.Name = "NapomenaTextBox"
        Me.NapomenaTextBox.Size = New System.Drawing.Size(351, 20)
        Me.NapomenaTextBox.TabIndex = 44
        '
        'HigijenaCheckBox
        '
        Me.HigijenaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Higijena_ruku", True))
        Me.HigijenaCheckBox.Location = New System.Drawing.Point(519, 128)
        Me.HigijenaCheckBox.Name = "HigijenaCheckBox"
        Me.HigijenaCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.HigijenaCheckBox.TabIndex = 45
        Me.HigijenaCheckBox.UseVisualStyleBackColor = True
        '
        'Zastitna_odjecaCheckBox
        '
        Me.Zastitna_odjecaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Priprema_materijala", True))
        Me.Zastitna_odjecaCheckBox.Location = New System.Drawing.Point(519, 193)
        Me.Zastitna_odjecaCheckBox.Name = "Zastitna_odjecaCheckBox"
        Me.Zastitna_odjecaCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.Zastitna_odjecaCheckBox.TabIndex = 46
        Me.Zastitna_odjecaCheckBox.UseVisualStyleBackColor = True
        '
        'Antisepsa_kozeCheckBox
        '
        Me.Antisepsa_kozeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Asepticna_tehnika", True))
        Me.Antisepsa_kozeCheckBox.Location = New System.Drawing.Point(519, 241)
        Me.Antisepsa_kozeCheckBox.Name = "Antisepsa_kozeCheckBox"
        Me.Antisepsa_kozeCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.Antisepsa_kozeCheckBox.TabIndex = 47
        Me.Antisepsa_kozeCheckBox.UseVisualStyleBackColor = True
        '
        'Pravila_asepseCheckBox
        '
        Me.Pravila_asepseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Zatvoren_sustav", True))
        Me.Pravila_asepseCheckBox.Location = New System.Drawing.Point(519, 309)
        Me.Pravila_asepseCheckBox.Name = "Pravila_asepseCheckBox"
        Me.Pravila_asepseCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.Pravila_asepseCheckBox.TabIndex = 48
        Me.Pravila_asepseCheckBox.UseVisualStyleBackColor = True
        '
        'Mjesto_insercijeCheckBox
        '
        Me.Mjesto_insercijeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UKBindingSource, "Velicina_katetera", True))
        Me.Mjesto_insercijeCheckBox.Location = New System.Drawing.Point(519, 372)
        Me.Mjesto_insercijeCheckBox.Name = "Mjesto_insercijeCheckBox"
        Me.Mjesto_insercijeCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.Mjesto_insercijeCheckBox.TabIndex = 49
        Me.Mjesto_insercijeCheckBox.UseVisualStyleBackColor = True
        '
        'Generalije_Control1
        '
        Me.Generalije_Control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Generalije_Control1.Location = New System.Drawing.Point(12, 12)
        Me.Generalije_Control1.Name = "Generalije_Control1"
        Me.Generalije_Control1.R = Nothing
        Me.Generalije_Control1.Size = New System.Drawing.Size(495, 71)
        Me.Generalije_Control1.TabIndex = 27
        '
        'Radiliste_tekstTextBox
        '
        Me.Radiliste_tekstTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Radiliste_tekstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Radiliste_tekstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Radiliste_tekst", True))
        Me.Radiliste_tekstTextBox.ForeColor = System.Drawing.SystemColors.Control
        Me.Radiliste_tekstTextBox.Location = New System.Drawing.Point(361, 86)
        Me.Radiliste_tekstTextBox.Name = "Radiliste_tekstTextBox"
        Me.Radiliste_tekstTextBox.Size = New System.Drawing.Size(100, 13)
        Me.Radiliste_tekstTextBox.TabIndex = 50
        '
        'UKTableAdapter
        '
        Me.UKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CVKTableAdapter = Nothing
        Me.TableAdapterManager.UKTableAdapter = Me.UKTableAdapter
        Me.TableAdapterManager.UpdateOrder = Skrlin.DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IndikacijaComboBox
        '
        Me.IndikacijaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UKBindingSource, "Indikacija", True))
        Me.IndikacijaComboBox.FormattingEnabled = True
        Me.IndikacijaComboBox.Items.AddRange(New Object() {"", "Retencija", "Diureza", "Inkontinencija", "Preoperacijski"})
        Me.IndikacijaComboBox.Location = New System.Drawing.Point(73, 238)
        Me.IndikacijaComboBox.Name = "IndikacijaComboBox"
        Me.IndikacijaComboBox.Size = New System.Drawing.Size(408, 21)
        Me.IndikacijaComboBox.TabIndex = 51
        '
        'UK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 439)
        Me.Controls.Add(IndikacijaLabel)
        Me.Controls.Add(Me.IndikacijaComboBox)
        Me.Controls.Add(Me.Radiliste_tekstTextBox)
        Me.Controls.Add(Mjesto_insercijeLabel)
        Me.Controls.Add(Me.Mjesto_insercijeCheckBox)
        Me.Controls.Add(Pravila_asepseLabel)
        Me.Controls.Add(Me.Pravila_asepseCheckBox)
        Me.Controls.Add(Antisepsa_kozeLabel)
        Me.Controls.Add(Me.Antisepsa_kozeCheckBox)
        Me.Controls.Add(Zastitna_odjecaLabel)
        Me.Controls.Add(Me.Zastitna_odjecaCheckBox)
        Me.Controls.Add(HigijenaLabel)
        Me.Controls.Add(Me.HigijenaCheckBox)
        Me.Controls.Add(NapomenaLabel)
        Me.Controls.Add(Me.NapomenaTextBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Datum_vađenjaTextBox)
        Me.Controls.Add(Me.Datum_stavljanjaTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Zapamti)
        Me.Controls.Add(Me.Povratak)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Pacijent_IDTextBox)
        Me.Controls.Add(Me.RegistarskiBRTextBox)
        Me.Controls.Add(Me.MaticniBRTextBox)
        Me.Controls.Add(Datum_stavljanjaLabel)
        Me.Controls.Add(RadilišteLabel)
        Me.Controls.Add(Me.RadilišteTextBox)
        Me.Controls.Add(LijecnikLabel)
        Me.Controls.Add(Me.LijecnikTextBox)
        Me.Controls.Add(SestraLabel)
        Me.Controls.Add(Me.SestraTextBox)
        Me.Controls.Add(HitnoLabel)
        Me.Controls.Add(Me.HitnoCheckBox)
        Me.Controls.Add(Datum_vađenjaLabel)
        Me.Controls.Add(Razlog_vađenjaLabel)
        Me.Name = "UK"
        Me.Text = "Urinarni kateter"
        CType(Me.UKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pacijent_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistarskiBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaticniBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RadilišteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LijecnikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HitnoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Generalije_Control1 As Skrlin.Generalije_Control
    Friend WithEvents Zapamti As System.Windows.Forms.Button
    Friend WithEvents Povratak As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datum_stavljanjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vađenjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataSet4 As Skrlin.DataSet4
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents NapomenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HigijenaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Zastitna_odjecaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Antisepsa_kozeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Pravila_asepseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Mjesto_insercijeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Radiliste_tekstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UKTableAdapter As Skrlin.DataSet4TableAdapters.UKTableAdapter
    Friend WithEvents TableAdapterManager As Skrlin.DataSet4TableAdapters.TableAdapterManager
    Friend WithEvents IndikacijaComboBox As System.Windows.Forms.ComboBox
End Class
