<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boravak
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
        Dim VisinaLabel As System.Windows.Forms.Label
        Dim TezinaLabel As System.Windows.Forms.Label
        Dim BMILabel As System.Windows.Forms.Label
        Dim Broj_pov_bolLabel As System.Windows.Forms.Label
        Dim PusenjeLabel As System.Windows.Forms.Label
        Dim PretilostLabel As System.Windows.Forms.Label
        Dim DijabetesLabel As System.Windows.Forms.Label
        Dim Prethodna_hospLabel As System.Windows.Forms.Label
        Dim SteroidiLabel As System.Windows.Forms.Label
        Dim Prethodna_hosp_gdjeLabel As System.Windows.Forms.Label
        Dim Datum_prijemaLabel As System.Windows.Forms.Label
        Dim Hitni_prijemLabel As System.Windows.Forms.Label
        Dim Dijagnoza_prijem_MKBLabel As System.Windows.Forms.Label
        Dim Prethodna_ATB_terapijaLabel As System.Windows.Forms.Label
        Dim Prethodna_ATB_profilaksaLabel As System.Windows.Forms.Label
        Dim BSILabel As System.Windows.Forms.Label
        Dim UTILabel As System.Windows.Forms.Label
        Dim RILabel As System.Windows.Forms.Label
        Dim VAPLabel As System.Windows.Forms.Label
        Dim Ishod_lijecenjaLabel As System.Windows.Forms.Label
        Dim Datum_otpustaLabel As System.Windows.Forms.Label
        Dim Vrsta_otpustaLabel As System.Windows.Forms.Label
        Dim NapomenaLabel As System.Windows.Forms.Label
        Dim JILLabel As System.Windows.Forms.Label
        Dim SSILabel As System.Windows.Forms.Label
        Dim OdjelLabel As System.Windows.Forms.Label
        Dim Datum_1_kontroleLabel As System.Windows.Forms.Label
        Dim Opis_kontroleLabel As System.Windows.Forms.Label
        Me.VisinaTextBox = New System.Windows.Forms.TextBox()
        Me.BoravciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Skrlin.DataSet2()
        Me.TezinaTextBox = New System.Windows.Forms.TextBox()
        Me.BMITextBox = New System.Windows.Forms.TextBox()
        Me.Broj_pov_bolTextBox = New System.Windows.Forms.TextBox()
        Me.PusenjeCheckBox = New System.Windows.Forms.CheckBox()
        Me.PretilostCheckBox = New System.Windows.Forms.CheckBox()
        Me.DijabetesCheckBox = New System.Windows.Forms.CheckBox()
        Me.Prethodna_hospCheckBox = New System.Windows.Forms.CheckBox()
        Me.SteroidiCheckBox = New System.Windows.Forms.CheckBox()
        Me.Prethodna_hosp_gdjeTextBox = New System.Windows.Forms.TextBox()
        Me.Datum_prijemaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hitni_prijemCheckBox = New System.Windows.Forms.CheckBox()
        Me.Dijagnoza_prijemTextBox = New System.Windows.Forms.TextBox()
        Me.Dijagnoza_prijem_MKBTextBox = New System.Windows.Forms.TextBox()
        Me.Prethodna_ATB_terapijaTextBox = New System.Windows.Forms.TextBox()
        Me.Prethodna_ATB_profilaksaTextBox = New System.Windows.Forms.TextBox()
        Me.BSICheckBox = New System.Windows.Forms.CheckBox()
        Me.UTICheckBox = New System.Windows.Forms.CheckBox()
        Me.RICheckBox = New System.Windows.Forms.CheckBox()
        Me.VAPCheckBox = New System.Windows.Forms.CheckBox()
        Me.Ishod_lijecenjaTextBox = New System.Windows.Forms.TextBox()
        Me.Datum_otpustaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Vrsta_otpustaTextBox = New System.Windows.Forms.TextBox()
        Me.NapomenaTextBox = New System.Windows.Forms.TextBox()
        Me.JILCheckBox = New System.Windows.Forms.CheckBox()
        Me.SSICheckBox = New System.Windows.Forms.CheckBox()
        Me.OdjelTextBox = New System.Windows.Forms.TextBox()
        Me.Datum_1_kontroleDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Opis_kontroleTextBox = New System.Windows.Forms.TextBox()
        Me.BoravciTableAdapter = New Skrlin.DataSet2TableAdapters.BoravciTableAdapter()
        Me.TableAdapterManager = New Skrlin.DataSet2TableAdapters.TableAdapterManager()
        Me.Generalije_Control1 = New Skrlin.Generalije_Control()
        Me.Dodaj_infekciju = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        VisinaLabel = New System.Windows.Forms.Label()
        TezinaLabel = New System.Windows.Forms.Label()
        BMILabel = New System.Windows.Forms.Label()
        Broj_pov_bolLabel = New System.Windows.Forms.Label()
        PusenjeLabel = New System.Windows.Forms.Label()
        PretilostLabel = New System.Windows.Forms.Label()
        DijabetesLabel = New System.Windows.Forms.Label()
        Prethodna_hospLabel = New System.Windows.Forms.Label()
        SteroidiLabel = New System.Windows.Forms.Label()
        Prethodna_hosp_gdjeLabel = New System.Windows.Forms.Label()
        Datum_prijemaLabel = New System.Windows.Forms.Label()
        Hitni_prijemLabel = New System.Windows.Forms.Label()
        Dijagnoza_prijem_MKBLabel = New System.Windows.Forms.Label()
        Prethodna_ATB_terapijaLabel = New System.Windows.Forms.Label()
        Prethodna_ATB_profilaksaLabel = New System.Windows.Forms.Label()
        BSILabel = New System.Windows.Forms.Label()
        UTILabel = New System.Windows.Forms.Label()
        RILabel = New System.Windows.Forms.Label()
        VAPLabel = New System.Windows.Forms.Label()
        Ishod_lijecenjaLabel = New System.Windows.Forms.Label()
        Datum_otpustaLabel = New System.Windows.Forms.Label()
        Vrsta_otpustaLabel = New System.Windows.Forms.Label()
        NapomenaLabel = New System.Windows.Forms.Label()
        JILLabel = New System.Windows.Forms.Label()
        SSILabel = New System.Windows.Forms.Label()
        OdjelLabel = New System.Windows.Forms.Label()
        Datum_1_kontroleLabel = New System.Windows.Forms.Label()
        Opis_kontroleLabel = New System.Windows.Forms.Label()
        CType(Me.BoravciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisinaLabel
        '
        VisinaLabel.AutoSize = True
        VisinaLabel.Location = New System.Drawing.Point(403, 330)
        VisinaLabel.Name = "VisinaLabel"
        VisinaLabel.Size = New System.Drawing.Size(38, 13)
        VisinaLabel.TabIndex = 6
        VisinaLabel.Text = "Visina:"
        '
        'TezinaLabel
        '
        TezinaLabel.AutoSize = True
        TezinaLabel.Location = New System.Drawing.Point(403, 356)
        TezinaLabel.Name = "TezinaLabel"
        TezinaLabel.Size = New System.Drawing.Size(42, 13)
        TezinaLabel.TabIndex = 8
        TezinaLabel.Text = "Tezina:"
        '
        'BMILabel
        '
        BMILabel.AutoSize = True
        BMILabel.Location = New System.Drawing.Point(403, 382)
        BMILabel.Name = "BMILabel"
        BMILabel.Size = New System.Drawing.Size(29, 13)
        BMILabel.TabIndex = 10
        BMILabel.Text = "BMI:"
        '
        'Broj_pov_bolLabel
        '
        Broj_pov_bolLabel.AutoSize = True
        Broj_pov_bolLabel.Location = New System.Drawing.Point(30, 113)
        Broj_pov_bolLabel.Name = "Broj_pov_bolLabel"
        Broj_pov_bolLabel.Size = New System.Drawing.Size(66, 13)
        Broj_pov_bolLabel.TabIndex = 12
        Broj_pov_bolLabel.Text = "Broj pov bol:"
        '
        'PusenjeLabel
        '
        PusenjeLabel.AutoSize = True
        PusenjeLabel.Location = New System.Drawing.Point(30, 330)
        PusenjeLabel.Name = "PusenjeLabel"
        PusenjeLabel.Size = New System.Drawing.Size(48, 13)
        PusenjeLabel.TabIndex = 14
        PusenjeLabel.Text = "Pusenje:"
        '
        'PretilostLabel
        '
        PretilostLabel.AutoSize = True
        PretilostLabel.Location = New System.Drawing.Point(30, 360)
        PretilostLabel.Name = "PretilostLabel"
        PretilostLabel.Size = New System.Drawing.Size(47, 13)
        PretilostLabel.TabIndex = 16
        PretilostLabel.Text = "Pretilost:"
        '
        'DijabetesLabel
        '
        DijabetesLabel.AutoSize = True
        DijabetesLabel.Location = New System.Drawing.Point(30, 390)
        DijabetesLabel.Name = "DijabetesLabel"
        DijabetesLabel.Size = New System.Drawing.Size(54, 13)
        DijabetesLabel.TabIndex = 18
        DijabetesLabel.Text = "Dijabetes:"
        '
        'Prethodna_hospLabel
        '
        Prethodna_hospLabel.AutoSize = True
        Prethodna_hospLabel.Location = New System.Drawing.Point(30, 236)
        Prethodna_hospLabel.Name = "Prethodna_hospLabel"
        Prethodna_hospLabel.Size = New System.Drawing.Size(85, 13)
        Prethodna_hospLabel.TabIndex = 20
        Prethodna_hospLabel.Text = "Prethodna hosp:"
        '
        'SteroidiLabel
        '
        SteroidiLabel.AutoSize = True
        SteroidiLabel.Location = New System.Drawing.Point(30, 420)
        SteroidiLabel.Name = "SteroidiLabel"
        SteroidiLabel.Size = New System.Drawing.Size(45, 13)
        SteroidiLabel.TabIndex = 22
        SteroidiLabel.Text = "Steroidi:"
        '
        'Prethodna_hosp_gdjeLabel
        '
        Prethodna_hosp_gdjeLabel.AutoSize = True
        Prethodna_hosp_gdjeLabel.Location = New System.Drawing.Point(217, 236)
        Prethodna_hosp_gdjeLabel.Name = "Prethodna_hosp_gdjeLabel"
        Prethodna_hosp_gdjeLabel.Size = New System.Drawing.Size(108, 13)
        Prethodna_hosp_gdjeLabel.TabIndex = 24
        Prethodna_hosp_gdjeLabel.Text = "Prethodna hosp gdje:"
        '
        'Datum_prijemaLabel
        '
        Datum_prijemaLabel.AutoSize = True
        Datum_prijemaLabel.Location = New System.Drawing.Point(346, 113)
        Datum_prijemaLabel.Name = "Datum_prijemaLabel"
        Datum_prijemaLabel.Size = New System.Drawing.Size(77, 13)
        Datum_prijemaLabel.TabIndex = 26
        Datum_prijemaLabel.Text = "Datum prijema:"
        '
        'Hitni_prijemLabel
        '
        Hitni_prijemLabel.AutoSize = True
        Hitni_prijemLabel.Location = New System.Drawing.Point(595, 113)
        Hitni_prijemLabel.Name = "Hitni_prijemLabel"
        Hitni_prijemLabel.Size = New System.Drawing.Size(61, 13)
        Hitni_prijemLabel.TabIndex = 28
        Hitni_prijemLabel.Text = "Hitni prijem:"
        '
        'Dijagnoza_prijem_MKBLabel
        '
        Dijagnoza_prijem_MKBLabel.AutoSize = True
        Dijagnoza_prijem_MKBLabel.Location = New System.Drawing.Point(30, 166)
        Dijagnoza_prijem_MKBLabel.Name = "Dijagnoza_prijem_MKBLabel"
        Dijagnoza_prijem_MKBLabel.Size = New System.Drawing.Size(57, 13)
        Dijagnoza_prijem_MKBLabel.TabIndex = 32
        Dijagnoza_prijem_MKBLabel.Text = "Dijagnoza:"
        '
        'Prethodna_ATB_terapijaLabel
        '
        Prethodna_ATB_terapijaLabel.AutoSize = True
        Prethodna_ATB_terapijaLabel.Location = New System.Drawing.Point(30, 268)
        Prethodna_ATB_terapijaLabel.Name = "Prethodna_ATB_terapijaLabel"
        Prethodna_ATB_terapijaLabel.Size = New System.Drawing.Size(120, 13)
        Prethodna_ATB_terapijaLabel.TabIndex = 34
        Prethodna_ATB_terapijaLabel.Text = "Prethodna ATB terapija:"
        '
        'Prethodna_ATB_profilaksaLabel
        '
        Prethodna_ATB_profilaksaLabel.AutoSize = True
        Prethodna_ATB_profilaksaLabel.Location = New System.Drawing.Point(30, 294)
        Prethodna_ATB_profilaksaLabel.Name = "Prethodna_ATB_profilaksaLabel"
        Prethodna_ATB_profilaksaLabel.Size = New System.Drawing.Size(131, 13)
        Prethodna_ATB_profilaksaLabel.TabIndex = 36
        Prethodna_ATB_profilaksaLabel.Text = "Prethodna ATB profilaksa:"
        '
        'BSILabel
        '
        BSILabel.AutoSize = True
        BSILabel.Location = New System.Drawing.Point(217, 330)
        BSILabel.Name = "BSILabel"
        BSILabel.Size = New System.Drawing.Size(27, 13)
        BSILabel.TabIndex = 38
        BSILabel.Text = "BSI:"
        BSILabel.Visible = False
        '
        'UTILabel
        '
        UTILabel.AutoSize = True
        UTILabel.Location = New System.Drawing.Point(217, 360)
        UTILabel.Name = "UTILabel"
        UTILabel.Size = New System.Drawing.Size(28, 13)
        UTILabel.TabIndex = 40
        UTILabel.Text = "UTI:"
        UTILabel.Visible = False
        '
        'RILabel
        '
        RILabel.AutoSize = True
        RILabel.Location = New System.Drawing.Point(217, 390)
        RILabel.Name = "RILabel"
        RILabel.Size = New System.Drawing.Size(21, 13)
        RILabel.TabIndex = 42
        RILabel.Text = "RI:"
        RILabel.Visible = False
        '
        'VAPLabel
        '
        VAPLabel.AutoSize = True
        VAPLabel.Location = New System.Drawing.Point(217, 420)
        VAPLabel.Name = "VAPLabel"
        VAPLabel.Size = New System.Drawing.Size(31, 13)
        VAPLabel.TabIndex = 44
        VAPLabel.Text = "VAP:"
        VAPLabel.Visible = False
        '
        'Ishod_lijecenjaLabel
        '
        Ishod_lijecenjaLabel.AutoSize = True
        Ishod_lijecenjaLabel.Location = New System.Drawing.Point(269, 194)
        Ishod_lijecenjaLabel.Name = "Ishod_lijecenjaLabel"
        Ishod_lijecenjaLabel.Size = New System.Drawing.Size(77, 13)
        Ishod_lijecenjaLabel.TabIndex = 46
        Ishod_lijecenjaLabel.Text = "Ishod liječenja:"
        '
        'Datum_otpustaLabel
        '
        Datum_otpustaLabel.AutoSize = True
        Datum_otpustaLabel.Location = New System.Drawing.Point(30, 194)
        Datum_otpustaLabel.Name = "Datum_otpustaLabel"
        Datum_otpustaLabel.Size = New System.Drawing.Size(79, 13)
        Datum_otpustaLabel.TabIndex = 48
        Datum_otpustaLabel.Text = "Datum otpusta:"
        '
        'Vrsta_otpustaLabel
        '
        Vrsta_otpustaLabel.AutoSize = True
        Vrsta_otpustaLabel.Location = New System.Drawing.Point(595, 194)
        Vrsta_otpustaLabel.Name = "Vrsta_otpustaLabel"
        Vrsta_otpustaLabel.Size = New System.Drawing.Size(72, 13)
        Vrsta_otpustaLabel.TabIndex = 50
        Vrsta_otpustaLabel.Text = "Vrsta otpusta:"
        '
        'NapomenaLabel
        '
        NapomenaLabel.AutoSize = True
        NapomenaLabel.Location = New System.Drawing.Point(30, 492)
        NapomenaLabel.Name = "NapomenaLabel"
        NapomenaLabel.Size = New System.Drawing.Size(62, 13)
        NapomenaLabel.TabIndex = 52
        NapomenaLabel.Text = "Napomena:"
        '
        'JILLabel
        '
        JILLabel.AutoSize = True
        JILLabel.Location = New System.Drawing.Point(628, 236)
        JILLabel.Name = "JILLabel"
        JILLabel.Size = New System.Drawing.Size(24, 13)
        JILLabel.TabIndex = 54
        JILLabel.Text = "JIL:"
        '
        'SSILabel
        '
        SSILabel.AutoSize = True
        SSILabel.Location = New System.Drawing.Point(217, 449)
        SSILabel.Name = "SSILabel"
        SSILabel.Size = New System.Drawing.Size(27, 13)
        SSILabel.TabIndex = 56
        SSILabel.Text = "SSI:"
        SSILabel.Visible = False
        '
        'OdjelLabel
        '
        OdjelLabel.AutoSize = True
        OdjelLabel.Location = New System.Drawing.Point(30, 139)
        OdjelLabel.Name = "OdjelLabel"
        OdjelLabel.Size = New System.Drawing.Size(34, 13)
        OdjelLabel.TabIndex = 58
        OdjelLabel.Text = "Odjel:"
        '
        'Datum_1_kontroleLabel
        '
        Datum_1_kontroleLabel.AutoSize = True
        Datum_1_kontroleLabel.Location = New System.Drawing.Point(30, 524)
        Datum_1_kontroleLabel.Name = "Datum_1_kontroleLabel"
        Datum_1_kontroleLabel.Size = New System.Drawing.Size(91, 13)
        Datum_1_kontroleLabel.TabIndex = 60
        Datum_1_kontroleLabel.Text = "Datum 1 kontrole:"
        '
        'Opis_kontroleLabel
        '
        Opis_kontroleLabel.AutoSize = True
        Opis_kontroleLabel.Location = New System.Drawing.Point(30, 549)
        Opis_kontroleLabel.Name = "Opis_kontroleLabel"
        Opis_kontroleLabel.Size = New System.Drawing.Size(72, 13)
        Opis_kontroleLabel.TabIndex = 62
        Opis_kontroleLabel.Text = "Opis kontrole:"
        '
        'VisinaTextBox
        '
        Me.VisinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Visina", True))
        Me.VisinaTextBox.Location = New System.Drawing.Point(447, 327)
        Me.VisinaTextBox.Name = "VisinaTextBox"
        Me.VisinaTextBox.Size = New System.Drawing.Size(74, 20)
        Me.VisinaTextBox.TabIndex = 7
        '
        'BoravciBindingSource
        '
        Me.BoravciBindingSource.DataMember = "Boravci"
        Me.BoravciBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TezinaTextBox
        '
        Me.TezinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Tezina", True))
        Me.TezinaTextBox.Location = New System.Drawing.Point(447, 353)
        Me.TezinaTextBox.Name = "TezinaTextBox"
        Me.TezinaTextBox.Size = New System.Drawing.Size(74, 20)
        Me.TezinaTextBox.TabIndex = 9
        '
        'BMITextBox
        '
        Me.BMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "BMI", True))
        Me.BMITextBox.Location = New System.Drawing.Point(447, 379)
        Me.BMITextBox.Name = "BMITextBox"
        Me.BMITextBox.Size = New System.Drawing.Size(74, 20)
        Me.BMITextBox.TabIndex = 11
        '
        'Broj_pov_bolTextBox
        '
        Me.Broj_pov_bolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Broj_pov_bol", True))
        Me.Broj_pov_bolTextBox.Location = New System.Drawing.Point(102, 110)
        Me.Broj_pov_bolTextBox.Name = "Broj_pov_bolTextBox"
        Me.Broj_pov_bolTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Broj_pov_bolTextBox.TabIndex = 13
        '
        'PusenjeCheckBox
        '
        Me.PusenjeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Pusenje", True))
        Me.PusenjeCheckBox.Location = New System.Drawing.Point(84, 325)
        Me.PusenjeCheckBox.Name = "PusenjeCheckBox"
        Me.PusenjeCheckBox.Size = New System.Drawing.Size(97, 24)
        Me.PusenjeCheckBox.TabIndex = 15
        Me.PusenjeCheckBox.UseVisualStyleBackColor = True
        '
        'PretilostCheckBox
        '
        Me.PretilostCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Pretilost", True))
        Me.PretilostCheckBox.Location = New System.Drawing.Point(84, 355)
        Me.PretilostCheckBox.Name = "PretilostCheckBox"
        Me.PretilostCheckBox.Size = New System.Drawing.Size(97, 24)
        Me.PretilostCheckBox.TabIndex = 17
        Me.PretilostCheckBox.UseVisualStyleBackColor = True
        '
        'DijabetesCheckBox
        '
        Me.DijabetesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Dijabetes", True))
        Me.DijabetesCheckBox.Location = New System.Drawing.Point(84, 385)
        Me.DijabetesCheckBox.Name = "DijabetesCheckBox"
        Me.DijabetesCheckBox.Size = New System.Drawing.Size(97, 24)
        Me.DijabetesCheckBox.TabIndex = 19
        Me.DijabetesCheckBox.UseVisualStyleBackColor = True
        '
        'Prethodna_hospCheckBox
        '
        Me.Prethodna_hospCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Prethodna_hosp", True))
        Me.Prethodna_hospCheckBox.Location = New System.Drawing.Point(121, 231)
        Me.Prethodna_hospCheckBox.Name = "Prethodna_hospCheckBox"
        Me.Prethodna_hospCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.Prethodna_hospCheckBox.TabIndex = 21
        Me.Prethodna_hospCheckBox.UseVisualStyleBackColor = True
        '
        'SteroidiCheckBox
        '
        Me.SteroidiCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Steroidi", True))
        Me.SteroidiCheckBox.Location = New System.Drawing.Point(84, 415)
        Me.SteroidiCheckBox.Name = "SteroidiCheckBox"
        Me.SteroidiCheckBox.Size = New System.Drawing.Size(97, 24)
        Me.SteroidiCheckBox.TabIndex = 23
        Me.SteroidiCheckBox.UseVisualStyleBackColor = True
        '
        'Prethodna_hosp_gdjeTextBox
        '
        Me.Prethodna_hosp_gdjeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Prethodna_hosp_gdje", True))
        Me.Prethodna_hosp_gdjeTextBox.Location = New System.Drawing.Point(331, 233)
        Me.Prethodna_hosp_gdjeTextBox.Name = "Prethodna_hosp_gdjeTextBox"
        Me.Prethodna_hosp_gdjeTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Prethodna_hosp_gdjeTextBox.TabIndex = 25
        '
        'Datum_prijemaDateTimePicker
        '
        Me.Datum_prijemaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Datum_prijema", True))
        Me.Datum_prijemaDateTimePicker.Location = New System.Drawing.Point(429, 110)
        Me.Datum_prijemaDateTimePicker.Name = "Datum_prijemaDateTimePicker"
        Me.Datum_prijemaDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.Datum_prijemaDateTimePicker.TabIndex = 27
        '
        'Hitni_prijemCheckBox
        '
        Me.Hitni_prijemCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "Hitni_prijem", True))
        Me.Hitni_prijemCheckBox.Location = New System.Drawing.Point(662, 108)
        Me.Hitni_prijemCheckBox.Name = "Hitni_prijemCheckBox"
        Me.Hitni_prijemCheckBox.Size = New System.Drawing.Size(86, 24)
        Me.Hitni_prijemCheckBox.TabIndex = 29
        Me.Hitni_prijemCheckBox.UseVisualStyleBackColor = True
        '
        'Dijagnoza_prijemTextBox
        '
        Me.Dijagnoza_prijemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Dijagnoza_prijem", True))
        Me.Dijagnoza_prijemTextBox.Location = New System.Drawing.Point(167, 163)
        Me.Dijagnoza_prijemTextBox.Name = "Dijagnoza_prijemTextBox"
        Me.Dijagnoza_prijemTextBox.Size = New System.Drawing.Size(448, 20)
        Me.Dijagnoza_prijemTextBox.TabIndex = 31
        '
        'Dijagnoza_prijem_MKBTextBox
        '
        Me.Dijagnoza_prijem_MKBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Dijagnoza_prijem_MKB", True))
        Me.Dijagnoza_prijem_MKBTextBox.Location = New System.Drawing.Point(94, 163)
        Me.Dijagnoza_prijem_MKBTextBox.Name = "Dijagnoza_prijem_MKBTextBox"
        Me.Dijagnoza_prijem_MKBTextBox.Size = New System.Drawing.Size(72, 20)
        Me.Dijagnoza_prijem_MKBTextBox.TabIndex = 33
        '
        'Prethodna_ATB_terapijaTextBox
        '
        Me.Prethodna_ATB_terapijaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Prethodna_ATB_terapija", True))
        Me.Prethodna_ATB_terapijaTextBox.Location = New System.Drawing.Point(167, 265)
        Me.Prethodna_ATB_terapijaTextBox.Name = "Prethodna_ATB_terapijaTextBox"
        Me.Prethodna_ATB_terapijaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Prethodna_ATB_terapijaTextBox.TabIndex = 35
        '
        'Prethodna_ATB_profilaksaTextBox
        '
        Me.Prethodna_ATB_profilaksaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Prethodna_ATB_profilaksa", True))
        Me.Prethodna_ATB_profilaksaTextBox.Location = New System.Drawing.Point(167, 291)
        Me.Prethodna_ATB_profilaksaTextBox.Name = "Prethodna_ATB_profilaksaTextBox"
        Me.Prethodna_ATB_profilaksaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Prethodna_ATB_profilaksaTextBox.TabIndex = 37
        '
        'BSICheckBox
        '
        Me.BSICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "BSI", True))
        Me.BSICheckBox.Location = New System.Drawing.Point(250, 325)
        Me.BSICheckBox.Name = "BSICheckBox"
        Me.BSICheckBox.Size = New System.Drawing.Size(92, 24)
        Me.BSICheckBox.TabIndex = 39
        Me.BSICheckBox.UseVisualStyleBackColor = True
        Me.BSICheckBox.Visible = False
        '
        'UTICheckBox
        '
        Me.UTICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "UTI", True))
        Me.UTICheckBox.Location = New System.Drawing.Point(250, 355)
        Me.UTICheckBox.Name = "UTICheckBox"
        Me.UTICheckBox.Size = New System.Drawing.Size(92, 24)
        Me.UTICheckBox.TabIndex = 41
        Me.UTICheckBox.UseVisualStyleBackColor = True
        Me.UTICheckBox.Visible = False
        '
        'RICheckBox
        '
        Me.RICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "RI", True))
        Me.RICheckBox.Location = New System.Drawing.Point(250, 385)
        Me.RICheckBox.Name = "RICheckBox"
        Me.RICheckBox.Size = New System.Drawing.Size(92, 24)
        Me.RICheckBox.TabIndex = 43
        Me.RICheckBox.UseVisualStyleBackColor = True
        Me.RICheckBox.Visible = False
        '
        'VAPCheckBox
        '
        Me.VAPCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "VAP", True))
        Me.VAPCheckBox.Location = New System.Drawing.Point(250, 415)
        Me.VAPCheckBox.Name = "VAPCheckBox"
        Me.VAPCheckBox.Size = New System.Drawing.Size(92, 24)
        Me.VAPCheckBox.TabIndex = 45
        Me.VAPCheckBox.UseVisualStyleBackColor = True
        Me.VAPCheckBox.Visible = False
        '
        'Ishod_lijecenjaTextBox
        '
        Me.Ishod_lijecenjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Ishod_lijecenja", True))
        Me.Ishod_lijecenjaTextBox.Location = New System.Drawing.Point(352, 191)
        Me.Ishod_lijecenjaTextBox.Name = "Ishod_lijecenjaTextBox"
        Me.Ishod_lijecenjaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ishod_lijecenjaTextBox.TabIndex = 47
        '
        'Datum_otpustaDateTimePicker
        '
        Me.Datum_otpustaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Datum_otpusta", True))
        Me.Datum_otpustaDateTimePicker.Location = New System.Drawing.Point(115, 190)
        Me.Datum_otpustaDateTimePicker.Name = "Datum_otpustaDateTimePicker"
        Me.Datum_otpustaDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.Datum_otpustaDateTimePicker.TabIndex = 49
        '
        'Vrsta_otpustaTextBox
        '
        Me.Vrsta_otpustaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Vrsta_otpusta", True))
        Me.Vrsta_otpustaTextBox.Location = New System.Drawing.Point(673, 191)
        Me.Vrsta_otpustaTextBox.Name = "Vrsta_otpustaTextBox"
        Me.Vrsta_otpustaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vrsta_otpustaTextBox.TabIndex = 51
        '
        'NapomenaTextBox
        '
        Me.NapomenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Napomena", True))
        Me.NapomenaTextBox.Location = New System.Drawing.Point(109, 489)
        Me.NapomenaTextBox.Name = "NapomenaTextBox"
        Me.NapomenaTextBox.Size = New System.Drawing.Size(443, 20)
        Me.NapomenaTextBox.TabIndex = 53
        '
        'JILCheckBox
        '
        Me.JILCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "JIL", True))
        Me.JILCheckBox.Location = New System.Drawing.Point(658, 231)
        Me.JILCheckBox.Name = "JILCheckBox"
        Me.JILCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.JILCheckBox.TabIndex = 55
        Me.JILCheckBox.UseVisualStyleBackColor = True
        '
        'SSICheckBox
        '
        Me.SSICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BoravciBindingSource, "SSI", True))
        Me.SSICheckBox.Location = New System.Drawing.Point(250, 444)
        Me.SSICheckBox.Name = "SSICheckBox"
        Me.SSICheckBox.Size = New System.Drawing.Size(92, 24)
        Me.SSICheckBox.TabIndex = 57
        Me.SSICheckBox.UseVisualStyleBackColor = True
        Me.SSICheckBox.Visible = False
        '
        'OdjelTextBox
        '
        Me.OdjelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Odjel", True))
        Me.OdjelTextBox.Location = New System.Drawing.Point(75, 136)
        Me.OdjelTextBox.Name = "OdjelTextBox"
        Me.OdjelTextBox.Size = New System.Drawing.Size(304, 20)
        Me.OdjelTextBox.TabIndex = 59
        '
        'Datum_1_kontroleDateTimePicker
        '
        Me.Datum_1_kontroleDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Datum_1_kontrole", True))
        Me.Datum_1_kontroleDateTimePicker.Location = New System.Drawing.Point(127, 520)
        Me.Datum_1_kontroleDateTimePicker.Name = "Datum_1_kontroleDateTimePicker"
        Me.Datum_1_kontroleDateTimePicker.ShowCheckBox = True
        Me.Datum_1_kontroleDateTimePicker.Size = New System.Drawing.Size(132, 20)
        Me.Datum_1_kontroleDateTimePicker.TabIndex = 61
        '
        'Opis_kontroleTextBox
        '
        Me.Opis_kontroleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BoravciBindingSource, "Opis_kontrole", True))
        Me.Opis_kontroleTextBox.Location = New System.Drawing.Point(127, 546)
        Me.Opis_kontroleTextBox.Name = "Opis_kontroleTextBox"
        Me.Opis_kontroleTextBox.Size = New System.Drawing.Size(425, 20)
        Me.Opis_kontroleTextBox.TabIndex = 63
        '
        'BoravciTableAdapter
        '
        Me.BoravciTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ASATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoravciTableAdapter = Me.BoravciTableAdapter
        Me.TableAdapterManager.CVKTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_LijekTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_MKBTableAdapter = Nothing
        Me.TableAdapterManager.Infekcija_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.InfekcijaTableAdapter = Nothing
        Me.TableAdapterManager.OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.Tipovi_OperacijaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Skrlin.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vrste_AnestezijeTableAdapter = Nothing
        Me.TableAdapterManager.Vrste_InfekcijeTableAdapter = Nothing
        '
        'Generalije_Control1
        '
        Me.Generalije_Control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Generalije_Control1.Location = New System.Drawing.Point(13, 13)
        Me.Generalije_Control1.Name = "Generalije_Control1"
        Me.Generalije_Control1.R = Nothing
        Me.Generalije_Control1.Size = New System.Drawing.Size(495, 71)
        Me.Generalije_Control1.TabIndex = 65
        '
        'Dodaj_infekciju
        '
        Me.Dodaj_infekciju.Image = Global.Skrlin.My.Resources.Resources.Clipboard01
        Me.Dodaj_infekciju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dodaj_infekciju.Location = New System.Drawing.Point(828, 531)
        Me.Dodaj_infekciju.Name = "Dodaj_infekciju"
        Me.Dodaj_infekciju.Size = New System.Drawing.Size(120, 35)
        Me.Dodaj_infekciju.TabIndex = 66
        Me.Dodaj_infekciju.Text = "Dodaj infekciju"
        Me.Dodaj_infekciju.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Dodaj_infekciju.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Skrlin.My.Resources.Resources.Icon_Exit1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(848, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Izlazak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Boravak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 630)
        Me.Controls.Add(Me.Dodaj_infekciju)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(VisinaLabel)
        Me.Controls.Add(Me.VisinaTextBox)
        Me.Controls.Add(TezinaLabel)
        Me.Controls.Add(Me.TezinaTextBox)
        Me.Controls.Add(BMILabel)
        Me.Controls.Add(Me.BMITextBox)
        Me.Controls.Add(Broj_pov_bolLabel)
        Me.Controls.Add(Me.Broj_pov_bolTextBox)
        Me.Controls.Add(PusenjeLabel)
        Me.Controls.Add(Me.PusenjeCheckBox)
        Me.Controls.Add(PretilostLabel)
        Me.Controls.Add(Me.PretilostCheckBox)
        Me.Controls.Add(DijabetesLabel)
        Me.Controls.Add(Me.DijabetesCheckBox)
        Me.Controls.Add(Prethodna_hospLabel)
        Me.Controls.Add(Me.Prethodna_hospCheckBox)
        Me.Controls.Add(SteroidiLabel)
        Me.Controls.Add(Me.SteroidiCheckBox)
        Me.Controls.Add(Prethodna_hosp_gdjeLabel)
        Me.Controls.Add(Me.Prethodna_hosp_gdjeTextBox)
        Me.Controls.Add(Datum_prijemaLabel)
        Me.Controls.Add(Me.Datum_prijemaDateTimePicker)
        Me.Controls.Add(Hitni_prijemLabel)
        Me.Controls.Add(Me.Hitni_prijemCheckBox)
        Me.Controls.Add(Me.Dijagnoza_prijemTextBox)
        Me.Controls.Add(Dijagnoza_prijem_MKBLabel)
        Me.Controls.Add(Me.Dijagnoza_prijem_MKBTextBox)
        Me.Controls.Add(Prethodna_ATB_terapijaLabel)
        Me.Controls.Add(Me.Prethodna_ATB_terapijaTextBox)
        Me.Controls.Add(Prethodna_ATB_profilaksaLabel)
        Me.Controls.Add(Me.Prethodna_ATB_profilaksaTextBox)
        Me.Controls.Add(BSILabel)
        Me.Controls.Add(Me.BSICheckBox)
        Me.Controls.Add(UTILabel)
        Me.Controls.Add(Me.UTICheckBox)
        Me.Controls.Add(RILabel)
        Me.Controls.Add(Me.RICheckBox)
        Me.Controls.Add(VAPLabel)
        Me.Controls.Add(Me.VAPCheckBox)
        Me.Controls.Add(Ishod_lijecenjaLabel)
        Me.Controls.Add(Me.Ishod_lijecenjaTextBox)
        Me.Controls.Add(Datum_otpustaLabel)
        Me.Controls.Add(Me.Datum_otpustaDateTimePicker)
        Me.Controls.Add(Vrsta_otpustaLabel)
        Me.Controls.Add(Me.Vrsta_otpustaTextBox)
        Me.Controls.Add(NapomenaLabel)
        Me.Controls.Add(Me.NapomenaTextBox)
        Me.Controls.Add(JILLabel)
        Me.Controls.Add(Me.JILCheckBox)
        Me.Controls.Add(SSILabel)
        Me.Controls.Add(Me.SSICheckBox)
        Me.Controls.Add(OdjelLabel)
        Me.Controls.Add(Me.OdjelTextBox)
        Me.Controls.Add(Datum_1_kontroleLabel)
        Me.Controls.Add(Me.Datum_1_kontroleDateTimePicker)
        Me.Controls.Add(Opis_kontroleLabel)
        Me.Controls.Add(Me.Opis_kontroleTextBox)
        Me.Name = "Boravak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boravak"
        CType(Me.BoravciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TezinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Broj_pov_bolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PusenjeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PretilostCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DijabetesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Prethodna_hospCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SteroidiCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Prethodna_hosp_gdjeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_prijemaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hitni_prijemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Dijagnoza_prijemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dijagnoza_prijem_MKBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prethodna_ATB_terapijaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Prethodna_ATB_profilaksaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BSICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UTICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VAPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Ishod_lijecenjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_otpustaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Vrsta_otpustaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NapomenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JILCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SSICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OdjelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_1_kontroleDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Opis_kontroleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet2 As Skrlin.DataSet2
    Friend WithEvents BoravciBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BoravciTableAdapter As Skrlin.DataSet2TableAdapters.BoravciTableAdapter
    Friend WithEvents TableAdapterManager As Skrlin.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents Generalije_Control1 As Skrlin.Generalije_Control
    Friend WithEvents Dodaj_infekciju As System.Windows.Forms.Button
End Class
