<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CVK2
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Pacijent_IDLabel As System.Windows.Forms.Label
        Dim RegistarskiBRLabel As System.Windows.Forms.Label
        Dim MaticniBRLabel As System.Windows.Forms.Label
        Dim Datum_stavljanjaLabel As System.Windows.Forms.Label
        Dim RadilišteLabel As System.Windows.Forms.Label
        Dim Vrsta_CVKLabel As System.Windows.Forms.Label
        Dim Mjesto_CVKLabel As System.Windows.Forms.Label
        Dim LijecnikLabel As System.Windows.Forms.Label
        Dim SestraLabel As System.Windows.Forms.Label
        Dim HitnoLabel As System.Windows.Forms.Label
        Dim Datum_vađenjaLabel As System.Windows.Forms.Label
        Dim Razlog_vađenjaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CVK2))
        Me.DataSet4 = New Skrlin.DataSet4()
        Me.CVKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CVKTableAdapter = New Skrlin.DataSet4TableAdapters.CVKTableAdapter()
        Me.TableAdapterManager = New Skrlin.DataSet4TableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Pacijent_IDTextBox = New System.Windows.Forms.TextBox()
        Me.RegistarskiBRTextBox = New System.Windows.Forms.TextBox()
        Me.MaticniBRTextBox = New System.Windows.Forms.TextBox()
        Me.Datum_stavljanjaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RadilišteTextBox = New System.Windows.Forms.TextBox()
        Me.Vrsta_CVKTextBox = New System.Windows.Forms.TextBox()
        Me.Mjesto_CVKTextBox = New System.Windows.Forms.TextBox()
        Me.LijecnikTextBox = New System.Windows.Forms.TextBox()
        Me.SestraTextBox = New System.Windows.Forms.TextBox()
        Me.HitnoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Datum_vađenjaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Razlog_vađenjaTextBox = New System.Windows.Forms.TextBox()
        Me.Generalije_Control1 = New Skrlin.Generalije_Control()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        IDLabel = New System.Windows.Forms.Label()
        Pacijent_IDLabel = New System.Windows.Forms.Label()
        RegistarskiBRLabel = New System.Windows.Forms.Label()
        MaticniBRLabel = New System.Windows.Forms.Label()
        Datum_stavljanjaLabel = New System.Windows.Forms.Label()
        RadilišteLabel = New System.Windows.Forms.Label()
        Vrsta_CVKLabel = New System.Windows.Forms.Label()
        Mjesto_CVKLabel = New System.Windows.Forms.Label()
        LijecnikLabel = New System.Windows.Forms.Label()
        SestraLabel = New System.Windows.Forms.Label()
        HitnoLabel = New System.Windows.Forms.Label()
        Datum_vađenjaLabel = New System.Windows.Forms.Label()
        Razlog_vađenjaLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CVKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CVKBindingSource
        '
        Me.CVKBindingSource.DataMember = "CVK"
        Me.CVKBindingSource.DataSource = Me.DataSet4
        '
        'CVKTableAdapter
        '
        Me.CVKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CVKTableAdapter = Me.CVKTableAdapter
        Me.TableAdapterManager.UpdateOrder = Skrlin.DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(45, 150)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(139, 147)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'Pacijent_IDLabel
        '
        Pacijent_IDLabel.AutoSize = True
        Pacijent_IDLabel.Location = New System.Drawing.Point(45, 176)
        Pacijent_IDLabel.Name = "Pacijent_IDLabel"
        Pacijent_IDLabel.Size = New System.Drawing.Size(62, 13)
        Pacijent_IDLabel.TabIndex = 3
        Pacijent_IDLabel.Text = "Pacijent ID:"
        '
        'Pacijent_IDTextBox
        '
        Me.Pacijent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Pacijent_ID", True))
        Me.Pacijent_IDTextBox.Location = New System.Drawing.Point(139, 173)
        Me.Pacijent_IDTextBox.Name = "Pacijent_IDTextBox"
        Me.Pacijent_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pacijent_IDTextBox.TabIndex = 4
        '
        'RegistarskiBRLabel
        '
        RegistarskiBRLabel.AutoSize = True
        RegistarskiBRLabel.Location = New System.Drawing.Point(45, 202)
        RegistarskiBRLabel.Name = "RegistarskiBRLabel"
        RegistarskiBRLabel.Size = New System.Drawing.Size(80, 13)
        RegistarskiBRLabel.TabIndex = 5
        RegistarskiBRLabel.Text = "Registarski BR:"
        '
        'RegistarskiBRTextBox
        '
        Me.RegistarskiBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "RegistarskiBR", True))
        Me.RegistarskiBRTextBox.Location = New System.Drawing.Point(139, 199)
        Me.RegistarskiBRTextBox.Name = "RegistarskiBRTextBox"
        Me.RegistarskiBRTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RegistarskiBRTextBox.TabIndex = 6
        '
        'MaticniBRLabel
        '
        MaticniBRLabel.AutoSize = True
        MaticniBRLabel.Location = New System.Drawing.Point(45, 228)
        MaticniBRLabel.Name = "MaticniBRLabel"
        MaticniBRLabel.Size = New System.Drawing.Size(62, 13)
        MaticniBRLabel.TabIndex = 7
        MaticniBRLabel.Text = "Maticni BR:"
        '
        'MaticniBRTextBox
        '
        Me.MaticniBRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "MaticniBR", True))
        Me.MaticniBRTextBox.Location = New System.Drawing.Point(139, 225)
        Me.MaticniBRTextBox.Name = "MaticniBRTextBox"
        Me.MaticniBRTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MaticniBRTextBox.TabIndex = 8
        '
        'Datum_stavljanjaLabel
        '
        Datum_stavljanjaLabel.AutoSize = True
        Datum_stavljanjaLabel.Location = New System.Drawing.Point(45, 255)
        Datum_stavljanjaLabel.Name = "Datum_stavljanjaLabel"
        Datum_stavljanjaLabel.Size = New System.Drawing.Size(88, 13)
        Datum_stavljanjaLabel.TabIndex = 9
        Datum_stavljanjaLabel.Text = "Datum stavljanja:"
        '
        'Datum_stavljanjaDateTimePicker
        '
        Me.Datum_stavljanjaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CVKBindingSource, "Datum_stavljanja", True))
        Me.Datum_stavljanjaDateTimePicker.Location = New System.Drawing.Point(139, 251)
        Me.Datum_stavljanjaDateTimePicker.Name = "Datum_stavljanjaDateTimePicker"
        Me.Datum_stavljanjaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_stavljanjaDateTimePicker.TabIndex = 10
        '
        'RadilišteLabel
        '
        RadilišteLabel.AutoSize = True
        RadilišteLabel.Location = New System.Drawing.Point(45, 280)
        RadilišteLabel.Name = "RadilišteLabel"
        RadilišteLabel.Size = New System.Drawing.Size(50, 13)
        RadilišteLabel.TabIndex = 11
        RadilišteLabel.Text = "Radilište:"
        '
        'RadilišteTextBox
        '
        Me.RadilišteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Radilište", True))
        Me.RadilišteTextBox.Location = New System.Drawing.Point(139, 277)
        Me.RadilišteTextBox.Name = "RadilišteTextBox"
        Me.RadilišteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RadilišteTextBox.TabIndex = 12
        '
        'Vrsta_CVKLabel
        '
        Vrsta_CVKLabel.AutoSize = True
        Vrsta_CVKLabel.Location = New System.Drawing.Point(45, 306)
        Vrsta_CVKLabel.Name = "Vrsta_CVKLabel"
        Vrsta_CVKLabel.Size = New System.Drawing.Size(58, 13)
        Vrsta_CVKLabel.TabIndex = 13
        Vrsta_CVKLabel.Text = "Vrsta CVK:"
        '
        'Vrsta_CVKTextBox
        '
        Me.Vrsta_CVKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Vrsta_CVK", True))
        Me.Vrsta_CVKTextBox.Location = New System.Drawing.Point(139, 303)
        Me.Vrsta_CVKTextBox.Name = "Vrsta_CVKTextBox"
        Me.Vrsta_CVKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vrsta_CVKTextBox.TabIndex = 14
        '
        'Mjesto_CVKLabel
        '
        Mjesto_CVKLabel.AutoSize = True
        Mjesto_CVKLabel.Location = New System.Drawing.Point(45, 332)
        Mjesto_CVKLabel.Name = "Mjesto_CVKLabel"
        Mjesto_CVKLabel.Size = New System.Drawing.Size(65, 13)
        Mjesto_CVKLabel.TabIndex = 15
        Mjesto_CVKLabel.Text = "Mjesto CVK:"
        '
        'Mjesto_CVKTextBox
        '
        Me.Mjesto_CVKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Mjesto_CVK", True))
        Me.Mjesto_CVKTextBox.Location = New System.Drawing.Point(139, 329)
        Me.Mjesto_CVKTextBox.Name = "Mjesto_CVKTextBox"
        Me.Mjesto_CVKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mjesto_CVKTextBox.TabIndex = 16
        '
        'LijecnikLabel
        '
        LijecnikLabel.AutoSize = True
        LijecnikLabel.Location = New System.Drawing.Point(45, 358)
        LijecnikLabel.Name = "LijecnikLabel"
        LijecnikLabel.Size = New System.Drawing.Size(46, 13)
        LijecnikLabel.TabIndex = 17
        LijecnikLabel.Text = "Lijecnik:"
        '
        'LijecnikTextBox
        '
        Me.LijecnikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Lijecnik", True))
        Me.LijecnikTextBox.Location = New System.Drawing.Point(139, 355)
        Me.LijecnikTextBox.Name = "LijecnikTextBox"
        Me.LijecnikTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LijecnikTextBox.TabIndex = 18
        '
        'SestraLabel
        '
        SestraLabel.AutoSize = True
        SestraLabel.Location = New System.Drawing.Point(45, 384)
        SestraLabel.Name = "SestraLabel"
        SestraLabel.Size = New System.Drawing.Size(40, 13)
        SestraLabel.TabIndex = 19
        SestraLabel.Text = "Sestra:"
        '
        'SestraTextBox
        '
        Me.SestraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Sestra", True))
        Me.SestraTextBox.Location = New System.Drawing.Point(139, 381)
        Me.SestraTextBox.Name = "SestraTextBox"
        Me.SestraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SestraTextBox.TabIndex = 20
        '
        'HitnoLabel
        '
        HitnoLabel.AutoSize = True
        HitnoLabel.Location = New System.Drawing.Point(45, 412)
        HitnoLabel.Name = "HitnoLabel"
        HitnoLabel.Size = New System.Drawing.Size(35, 13)
        HitnoLabel.TabIndex = 21
        HitnoLabel.Text = "Hitno:"
        '
        'HitnoCheckBox
        '
        Me.HitnoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CVKBindingSource, "Hitno", True))
        Me.HitnoCheckBox.Location = New System.Drawing.Point(139, 407)
        Me.HitnoCheckBox.Name = "HitnoCheckBox"
        Me.HitnoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.HitnoCheckBox.TabIndex = 22
        Me.HitnoCheckBox.Text = "CheckBox1"
        Me.HitnoCheckBox.UseVisualStyleBackColor = True
        '
        'Datum_vađenjaLabel
        '
        Datum_vađenjaLabel.AutoSize = True
        Datum_vađenjaLabel.Location = New System.Drawing.Point(45, 441)
        Datum_vađenjaLabel.Name = "Datum_vađenjaLabel"
        Datum_vađenjaLabel.Size = New System.Drawing.Size(83, 13)
        Datum_vađenjaLabel.TabIndex = 23
        Datum_vađenjaLabel.Text = "Datum vađenja:"
        '
        'Datum_vađenjaDateTimePicker
        '
        Me.Datum_vađenjaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CVKBindingSource, "Datum_vađenja", True))
        Me.Datum_vađenjaDateTimePicker.Location = New System.Drawing.Point(139, 437)
        Me.Datum_vađenjaDateTimePicker.Name = "Datum_vađenjaDateTimePicker"
        Me.Datum_vađenjaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vađenjaDateTimePicker.TabIndex = 24
        '
        'Razlog_vađenjaLabel
        '
        Razlog_vađenjaLabel.AutoSize = True
        Razlog_vađenjaLabel.Location = New System.Drawing.Point(45, 466)
        Razlog_vađenjaLabel.Name = "Razlog_vađenjaLabel"
        Razlog_vađenjaLabel.Size = New System.Drawing.Size(85, 13)
        Razlog_vađenjaLabel.TabIndex = 25
        Razlog_vađenjaLabel.Text = "Razlog vađenja:"
        '
        'Razlog_vađenjaTextBox
        '
        Me.Razlog_vađenjaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CVKBindingSource, "Razlog_vađenja", True))
        Me.Razlog_vađenjaTextBox.Location = New System.Drawing.Point(139, 463)
        Me.Razlog_vađenjaTextBox.Name = "Razlog_vađenjaTextBox"
        Me.Razlog_vađenjaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Razlog_vađenjaTextBox.TabIndex = 26
        '
        'Generalije_Control1
        '
        Me.Generalije_Control1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Generalije_Control1.Location = New System.Drawing.Point(12, 12)
        Me.Generalije_Control1.Name = "Generalije_Control1"
        Me.Generalije_Control1.R = Nothing
        Me.Generalije_Control1.Size = New System.Drawing.Size(495, 71)
        Me.Generalije_Control1.TabIndex = 28
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(903, 25)
        Me.BindingNavigator1.TabIndex = 29
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CVK2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 595)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Generalije_Control1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Pacijent_IDLabel)
        Me.Controls.Add(Me.Pacijent_IDTextBox)
        Me.Controls.Add(RegistarskiBRLabel)
        Me.Controls.Add(Me.RegistarskiBRTextBox)
        Me.Controls.Add(MaticniBRLabel)
        Me.Controls.Add(Me.MaticniBRTextBox)
        Me.Controls.Add(Datum_stavljanjaLabel)
        Me.Controls.Add(Me.Datum_stavljanjaDateTimePicker)
        Me.Controls.Add(RadilišteLabel)
        Me.Controls.Add(Me.RadilišteTextBox)
        Me.Controls.Add(Vrsta_CVKLabel)
        Me.Controls.Add(Me.Vrsta_CVKTextBox)
        Me.Controls.Add(Mjesto_CVKLabel)
        Me.Controls.Add(Me.Mjesto_CVKTextBox)
        Me.Controls.Add(LijecnikLabel)
        Me.Controls.Add(Me.LijecnikTextBox)
        Me.Controls.Add(SestraLabel)
        Me.Controls.Add(Me.SestraTextBox)
        Me.Controls.Add(HitnoLabel)
        Me.Controls.Add(Me.HitnoCheckBox)
        Me.Controls.Add(Datum_vađenjaLabel)
        Me.Controls.Add(Me.Datum_vađenjaDateTimePicker)
        Me.Controls.Add(Razlog_vađenjaLabel)
        Me.Controls.Add(Me.Razlog_vađenjaTextBox)
        Me.Name = "CVK2"
        Me.Text = "CVK2"
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CVKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet4 As Skrlin.DataSet4
    Friend WithEvents CVKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CVKTableAdapter As Skrlin.DataSet4TableAdapters.CVKTableAdapter
    Friend WithEvents TableAdapterManager As Skrlin.DataSet4TableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pacijent_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistarskiBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaticniBRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_stavljanjaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadilišteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vrsta_CVKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mjesto_CVKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LijecnikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SestraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HitnoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Datum_vađenjaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Razlog_vađenjaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Generalije_Control1 As Skrlin.Generalije_Control
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
