<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddRecipe
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_recipe = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_buyer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.dginsert = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Kodeobat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaObat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_process = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_kodekain = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.panelkodekain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_lebarinput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgkodekain = New System.Windows.Forms.DataGridView()
        Me.txt_gsminput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_kodekaininput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelbuyer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgbuyer = New System.Windows.Forms.DataGridView()
        Me.txt_buyerinput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_kodebuyerinput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
        Me.panelinsert = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valueinsert = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_namaobatinsert = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_kodeobatinsert = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_jenisobatinsert = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dginsert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelkodekain.SuspendLayout()
        CType(Me.dgkodekain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelbuyer.SuspendLayout()
        CType(Me.dgbuyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelinsert.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_recipe
        '
        Me.txt_recipe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_recipe.DefaultText = ""
        Me.txt_recipe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_recipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_recipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_recipe.DisabledState.Parent = Me.txt_recipe
        Me.txt_recipe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_recipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_recipe.FocusedState.Parent = Me.txt_recipe
        Me.txt_recipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_recipe.HoverState.Parent = Me.txt_recipe
        Me.txt_recipe.Location = New System.Drawing.Point(140, 22)
        Me.txt_recipe.Name = "txt_recipe"
        Me.txt_recipe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_recipe.PlaceholderText = ""
        Me.txt_recipe.SelectedText = ""
        Me.txt_recipe.ShadowDecoration.Parent = Me.txt_recipe
        Me.txt_recipe.Size = New System.Drawing.Size(200, 36)
        Me.txt_recipe.TabIndex = 0
        '
        'txt_buyer
        '
        Me.txt_buyer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_buyer.DefaultText = ""
        Me.txt_buyer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_buyer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_buyer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buyer.DisabledState.Parent = Me.txt_buyer
        Me.txt_buyer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buyer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buyer.FocusedState.Parent = Me.txt_buyer
        Me.txt_buyer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buyer.HoverState.Parent = Me.txt_buyer
        Me.txt_buyer.Location = New System.Drawing.Point(496, 64)
        Me.txt_buyer.Name = "txt_buyer"
        Me.txt_buyer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_buyer.PlaceholderText = ""
        Me.txt_buyer.SelectedText = ""
        Me.txt_buyer.ShadowDecoration.Parent = Me.txt_buyer
        Me.txt_buyer.Size = New System.Drawing.Size(101, 36)
        Me.txt_buyer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Recipe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Process"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buyer"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(565, 501)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 18
        Me.Guna2Button1.Text = "Oke"
        '
        'dginsert
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dginsert.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dginsert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dginsert.BackgroundColor = System.Drawing.Color.White
        Me.dginsert.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dginsert.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dginsert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginsert.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dginsert.ColumnHeadersHeight = 40
        Me.dginsert.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kodeobat, Me.NamaObat, Me.Value, Me.Jenis})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dginsert.DefaultCellStyle = DataGridViewCellStyle6
        Me.dginsert.EnableHeadersVisualStyles = False
        Me.dginsert.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginsert.Location = New System.Drawing.Point(16, 215)
        Me.dginsert.Name = "dginsert"
        Me.dginsert.RowHeadersVisible = False
        Me.dginsert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dginsert.Size = New System.Drawing.Size(729, 269)
        Me.dginsert.TabIndex = 19
        Me.dginsert.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dginsert.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dginsert.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dginsert.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dginsert.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dginsert.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dginsert.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dginsert.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginsert.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginsert.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dginsert.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dginsert.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dginsert.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dginsert.ThemeStyle.HeaderStyle.Height = 40
        Me.dginsert.ThemeStyle.ReadOnly = False
        Me.dginsert.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dginsert.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dginsert.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dginsert.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dginsert.ThemeStyle.RowsStyle.Height = 22
        Me.dginsert.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginsert.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Kodeobat
        '
        Me.Kodeobat.HeaderText = "Kode Obat"
        Me.Kodeobat.Name = "Kodeobat"
        '
        'NamaObat
        '
        Me.NamaObat.HeaderText = "Nama Obat"
        Me.NamaObat.Name = "NamaObat"
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'Jenis
        '
        Me.Jenis.HeaderText = "Jenis"
        Me.Jenis.Name = "Jenis"
        '
        'cmb_process
        '
        Me.cmb_process.BackColor = System.Drawing.Color.Transparent
        Me.cmb_process.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_process.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_process.FocusedState.Parent = Me.cmb_process
        Me.cmb_process.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_process.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_process.FormattingEnabled = True
        Me.cmb_process.HoverState.Parent = Me.cmb_process
        Me.cmb_process.ItemHeight = 30
        Me.cmb_process.Items.AddRange(New Object() {"CPB", "PAD"})
        Me.cmb_process.ItemsAppearance.Parent = Me.cmb_process
        Me.cmb_process.Location = New System.Drawing.Point(140, 64)
        Me.cmb_process.Name = "cmb_process"
        Me.cmb_process.ShadowDecoration.Parent = Me.cmb_process
        Me.cmb_process.Size = New System.Drawing.Size(200, 36)
        Me.cmb_process.TabIndex = 20
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(603, 64)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button2.TabIndex = 21
        Me.Guna2Button2.Text = "↓"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(652, 64)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button3.TabIndex = 22
        Me.Guna2Button3.Text = "+"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(652, 22)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button4.TabIndex = 26
        Me.Guna2Button4.Text = "+"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(603, 22)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button5.TabIndex = 25
        Me.Guna2Button5.Text = "↓"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Kode Kain"
        '
        'txt_kodekain
        '
        Me.txt_kodekain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_kodekain.DefaultText = ""
        Me.txt_kodekain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_kodekain.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_kodekain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodekain.DisabledState.Parent = Me.txt_kodekain
        Me.txt_kodekain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodekain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodekain.FocusedState.Parent = Me.txt_kodekain
        Me.txt_kodekain.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodekain.HoverState.Parent = Me.txt_kodekain
        Me.txt_kodekain.Location = New System.Drawing.Point(496, 22)
        Me.txt_kodekain.Name = "txt_kodekain"
        Me.txt_kodekain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kodekain.PlaceholderText = ""
        Me.txt_kodekain.SelectedText = ""
        Me.txt_kodekain.ShadowDecoration.Parent = Me.txt_kodekain
        Me.txt_kodekain.Size = New System.Drawing.Size(101, 36)
        Me.txt_kodekain.TabIndex = 23
        '
        'Guna2Button6
        '
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Location = New System.Drawing.Point(16, 173)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(215, 36)
        Me.Guna2Button6.TabIndex = 27
        Me.Guna2Button6.Text = "Insert Multiple Rows"
        '
        'panelkodekain
        '
        Me.panelkodekain.BackColor = System.Drawing.Color.LightGray
        Me.panelkodekain.Controls.Add(Me.Label6)
        Me.panelkodekain.Controls.Add(Me.txt_lebarinput)
        Me.panelkodekain.Controls.Add(Me.Guna2Button8)
        Me.panelkodekain.Controls.Add(Me.Label5)
        Me.panelkodekain.Controls.Add(Me.Label4)
        Me.panelkodekain.Controls.Add(Me.dgkodekain)
        Me.panelkodekain.Controls.Add(Me.txt_gsminput)
        Me.panelkodekain.Controls.Add(Me.Guna2Button7)
        Me.panelkodekain.Controls.Add(Me.txt_kodekaininput)
        Me.panelkodekain.Location = New System.Drawing.Point(216, 120)
        Me.panelkodekain.Name = "panelkodekain"
        Me.panelkodekain.ShadowDecoration.Parent = Me.panelkodekain
        Me.panelkodekain.Size = New System.Drawing.Size(362, 364)
        Me.panelkodekain.TabIndex = 28
        Me.panelkodekain.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Lebar"
        '
        'txt_lebarinput
        '
        Me.txt_lebarinput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lebarinput.DefaultText = ""
        Me.txt_lebarinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lebarinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lebarinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lebarinput.DisabledState.Parent = Me.txt_lebarinput
        Me.txt_lebarinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lebarinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lebarinput.FocusedState.Parent = Me.txt_lebarinput
        Me.txt_lebarinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lebarinput.HoverState.Parent = Me.txt_lebarinput
        Me.txt_lebarinput.Location = New System.Drawing.Point(17, 100)
        Me.txt_lebarinput.Name = "txt_lebarinput"
        Me.txt_lebarinput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lebarinput.PlaceholderText = ""
        Me.txt_lebarinput.SelectedText = ""
        Me.txt_lebarinput.ShadowDecoration.Parent = Me.txt_lebarinput
        Me.txt_lebarinput.Size = New System.Drawing.Size(192, 36)
        Me.txt_lebarinput.TabIndex = 36
        '
        'Guna2Button8
        '
        Me.Guna2Button8.CheckedState.Parent = Me.Guna2Button8
        Me.Guna2Button8.CustomImages.Parent = Me.Guna2Button8
        Me.Guna2Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.HoverState.Parent = Me.Guna2Button8
        Me.Guna2Button8.Location = New System.Drawing.Point(301, 307)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.ShadowDecoration.Parent = Me.Guna2Button8
        Me.Guna2Button8.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button8.TabIndex = 35
        Me.Guna2Button8.Text = "Close"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "GSM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Kode kain"
        '
        'dgkodekain
        '
        Me.dgkodekain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkodekain.Location = New System.Drawing.Point(17, 157)
        Me.dgkodekain.Name = "dgkodekain"
        Me.dgkodekain.Size = New System.Drawing.Size(327, 144)
        Me.dgkodekain.TabIndex = 32
        '
        'txt_gsminput
        '
        Me.txt_gsminput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_gsminput.DefaultText = ""
        Me.txt_gsminput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_gsminput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_gsminput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_gsminput.DisabledState.Parent = Me.txt_gsminput
        Me.txt_gsminput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_gsminput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_gsminput.FocusedState.Parent = Me.txt_gsminput
        Me.txt_gsminput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_gsminput.HoverState.Parent = Me.txt_gsminput
        Me.txt_gsminput.Location = New System.Drawing.Point(221, 36)
        Me.txt_gsminput.Name = "txt_gsminput"
        Me.txt_gsminput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_gsminput.PlaceholderText = ""
        Me.txt_gsminput.SelectedText = ""
        Me.txt_gsminput.ShadowDecoration.Parent = Me.txt_gsminput
        Me.txt_gsminput.Size = New System.Drawing.Size(123, 36)
        Me.txt_gsminput.TabIndex = 31
        '
        'Guna2Button7
        '
        Me.Guna2Button7.CheckedState.Parent = Me.Guna2Button7
        Me.Guna2Button7.CustomImages.Parent = Me.Guna2Button7
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.Parent = Me.Guna2Button7
        Me.Guna2Button7.Location = New System.Drawing.Point(221, 100)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.ShadowDecoration.Parent = Me.Guna2Button7
        Me.Guna2Button7.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button7.TabIndex = 30
        Me.Guna2Button7.Text = "ADD"
        '
        'txt_kodekaininput
        '
        Me.txt_kodekaininput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_kodekaininput.DefaultText = ""
        Me.txt_kodekaininput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_kodekaininput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_kodekaininput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodekaininput.DisabledState.Parent = Me.txt_kodekaininput
        Me.txt_kodekaininput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodekaininput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodekaininput.FocusedState.Parent = Me.txt_kodekaininput
        Me.txt_kodekaininput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodekaininput.HoverState.Parent = Me.txt_kodekaininput
        Me.txt_kodekaininput.Location = New System.Drawing.Point(17, 36)
        Me.txt_kodekaininput.Name = "txt_kodekaininput"
        Me.txt_kodekaininput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kodekaininput.PlaceholderText = ""
        Me.txt_kodekaininput.SelectedText = ""
        Me.txt_kodekaininput.ShadowDecoration.Parent = Me.txt_kodekaininput
        Me.txt_kodekaininput.Size = New System.Drawing.Size(192, 36)
        Me.txt_kodekaininput.TabIndex = 29
        '
        'panelbuyer
        '
        Me.panelbuyer.BackColor = System.Drawing.Color.LightGray
        Me.panelbuyer.Controls.Add(Me.Guna2Button10)
        Me.panelbuyer.Controls.Add(Me.Guna2Button9)
        Me.panelbuyer.Controls.Add(Me.Label9)
        Me.panelbuyer.Controls.Add(Me.Label10)
        Me.panelbuyer.Controls.Add(Me.dgbuyer)
        Me.panelbuyer.Controls.Add(Me.txt_buyerinput)
        Me.panelbuyer.Controls.Add(Me.txt_kodebuyerinput)
        Me.panelbuyer.Location = New System.Drawing.Point(198, 120)
        Me.panelbuyer.Name = "panelbuyer"
        Me.panelbuyer.ShadowDecoration.Parent = Me.panelbuyer
        Me.panelbuyer.Size = New System.Drawing.Size(362, 364)
        Me.panelbuyer.TabIndex = 38
        Me.panelbuyer.Visible = False
        '
        'Guna2Button9
        '
        Me.Guna2Button9.CheckedState.Parent = Me.Guna2Button9
        Me.Guna2Button9.CustomImages.Parent = Me.Guna2Button9
        Me.Guna2Button9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button9.ForeColor = System.Drawing.Color.White
        Me.Guna2Button9.HoverState.Parent = Me.Guna2Button9
        Me.Guna2Button9.Location = New System.Drawing.Point(301, 307)
        Me.Guna2Button9.Name = "Guna2Button9"
        Me.Guna2Button9.ShadowDecoration.Parent = Me.Guna2Button9
        Me.Guna2Button9.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button9.TabIndex = 35
        Me.Guna2Button9.Text = "Close"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(103, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Buyer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Kode buyer"
        '
        'dgbuyer
        '
        Me.dgbuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbuyer.Location = New System.Drawing.Point(17, 93)
        Me.dgbuyer.Name = "dgbuyer"
        Me.dgbuyer.Size = New System.Drawing.Size(327, 208)
        Me.dgbuyer.TabIndex = 32
        '
        'txt_buyerinput
        '
        Me.txt_buyerinput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_buyerinput.DefaultText = ""
        Me.txt_buyerinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_buyerinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_buyerinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buyerinput.DisabledState.Parent = Me.txt_buyerinput
        Me.txt_buyerinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buyerinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buyerinput.FocusedState.Parent = Me.txt_buyerinput
        Me.txt_buyerinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buyerinput.HoverState.Parent = Me.txt_buyerinput
        Me.txt_buyerinput.Location = New System.Drawing.Point(111, 38)
        Me.txt_buyerinput.Name = "txt_buyerinput"
        Me.txt_buyerinput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_buyerinput.PlaceholderText = ""
        Me.txt_buyerinput.SelectedText = ""
        Me.txt_buyerinput.ShadowDecoration.Parent = Me.txt_buyerinput
        Me.txt_buyerinput.Size = New System.Drawing.Size(165, 36)
        Me.txt_buyerinput.TabIndex = 31
        '
        'txt_kodebuyerinput
        '
        Me.txt_kodebuyerinput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_kodebuyerinput.DefaultText = ""
        Me.txt_kodebuyerinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_kodebuyerinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_kodebuyerinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodebuyerinput.DisabledState.Parent = Me.txt_kodebuyerinput
        Me.txt_kodebuyerinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodebuyerinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodebuyerinput.FocusedState.Parent = Me.txt_kodebuyerinput
        Me.txt_kodebuyerinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodebuyerinput.HoverState.Parent = Me.txt_kodebuyerinput
        Me.txt_kodebuyerinput.Location = New System.Drawing.Point(17, 38)
        Me.txt_kodebuyerinput.Name = "txt_kodebuyerinput"
        Me.txt_kodebuyerinput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kodebuyerinput.PlaceholderText = ""
        Me.txt_kodebuyerinput.SelectedText = ""
        Me.txt_kodebuyerinput.ShadowDecoration.Parent = Me.txt_kodebuyerinput
        Me.txt_kodebuyerinput.Size = New System.Drawing.Size(83, 36)
        Me.txt_kodebuyerinput.TabIndex = 29
        '
        'Guna2Button10
        '
        Me.Guna2Button10.CheckedState.Parent = Me.Guna2Button10
        Me.Guna2Button10.CustomImages.Parent = Me.Guna2Button10
        Me.Guna2Button10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button10.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.HoverState.Parent = Me.Guna2Button10
        Me.Guna2Button10.Location = New System.Drawing.Point(286, 38)
        Me.Guna2Button10.Name = "Guna2Button10"
        Me.Guna2Button10.ShadowDecoration.Parent = Me.Guna2Button10
        Me.Guna2Button10.Size = New System.Drawing.Size(58, 36)
        Me.Guna2Button10.TabIndex = 36
        Me.Guna2Button10.Text = "ADD"
        '
        'panelinsert
        '
        Me.panelinsert.BackColor = System.Drawing.Color.LightGray
        Me.panelinsert.Controls.Add(Me.Label13)
        Me.panelinsert.Controls.Add(Me.txt_jenisobatinsert)
        Me.panelinsert.Controls.Add(Me.Label8)
        Me.panelinsert.Controls.Add(Me.txt_valueinsert)
        Me.panelinsert.Controls.Add(Me.Guna2Button11)
        Me.panelinsert.Controls.Add(Me.Label11)
        Me.panelinsert.Controls.Add(Me.Label12)
        Me.panelinsert.Controls.Add(Me.txt_namaobatinsert)
        Me.panelinsert.Controls.Add(Me.Guna2Button12)
        Me.panelinsert.Controls.Add(Me.txt_kodeobatinsert)
        Me.panelinsert.Location = New System.Drawing.Point(83, 106)
        Me.panelinsert.Name = "panelinsert"
        Me.panelinsert.ShadowDecoration.Parent = Me.panelinsert
        Me.panelinsert.Size = New System.Drawing.Size(362, 212)
        Me.panelinsert.TabIndex = 38
        Me.panelinsert.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Value"
        '
        'txt_valueinsert
        '
        Me.txt_valueinsert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_valueinsert.DefaultText = ""
        Me.txt_valueinsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_valueinsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_valueinsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_valueinsert.DisabledState.Parent = Me.txt_valueinsert
        Me.txt_valueinsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_valueinsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_valueinsert.FocusedState.Parent = Me.txt_valueinsert
        Me.txt_valueinsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_valueinsert.HoverState.Parent = Me.txt_valueinsert
        Me.txt_valueinsert.Location = New System.Drawing.Point(17, 100)
        Me.txt_valueinsert.Name = "txt_valueinsert"
        Me.txt_valueinsert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_valueinsert.PlaceholderText = ""
        Me.txt_valueinsert.SelectedText = ""
        Me.txt_valueinsert.ShadowDecoration.Parent = Me.txt_valueinsert
        Me.txt_valueinsert.Size = New System.Drawing.Size(149, 36)
        Me.txt_valueinsert.TabIndex = 31
        '
        'Guna2Button11
        '
        Me.Guna2Button11.CheckedState.Parent = Me.Guna2Button11
        Me.Guna2Button11.CustomImages.Parent = Me.Guna2Button11
        Me.Guna2Button11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button11.ForeColor = System.Drawing.Color.White
        Me.Guna2Button11.HoverState.Parent = Me.Guna2Button11
        Me.Guna2Button11.Location = New System.Drawing.Point(172, 156)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.ShadowDecoration.Parent = Me.Guna2Button11
        Me.Guna2Button11.Size = New System.Drawing.Size(43, 36)
        Me.Guna2Button11.TabIndex = 35
        Me.Guna2Button11.Text = "Close"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Nama Obat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Kode Obat"
        '
        'txt_namaobatinsert
        '
        Me.txt_namaobatinsert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_namaobatinsert.DefaultText = ""
        Me.txt_namaobatinsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_namaobatinsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_namaobatinsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_namaobatinsert.DisabledState.Parent = Me.txt_namaobatinsert
        Me.txt_namaobatinsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_namaobatinsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_namaobatinsert.FocusedState.Parent = Me.txt_namaobatinsert
        Me.txt_namaobatinsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_namaobatinsert.HoverState.Parent = Me.txt_namaobatinsert
        Me.txt_namaobatinsert.Location = New System.Drawing.Point(172, 36)
        Me.txt_namaobatinsert.Name = "txt_namaobatinsert"
        Me.txt_namaobatinsert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_namaobatinsert.PlaceholderText = ""
        Me.txt_namaobatinsert.SelectedText = ""
        Me.txt_namaobatinsert.ShadowDecoration.Parent = Me.txt_namaobatinsert
        Me.txt_namaobatinsert.Size = New System.Drawing.Size(172, 36)
        Me.txt_namaobatinsert.TabIndex = 30
        '
        'Guna2Button12
        '
        Me.Guna2Button12.CheckedState.Parent = Me.Guna2Button12
        Me.Guna2Button12.CustomImages.Parent = Me.Guna2Button12
        Me.Guna2Button12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button12.ForeColor = System.Drawing.Color.White
        Me.Guna2Button12.HoverState.Parent = Me.Guna2Button12
        Me.Guna2Button12.Location = New System.Drawing.Point(226, 156)
        Me.Guna2Button12.Name = "Guna2Button12"
        Me.Guna2Button12.ShadowDecoration.Parent = Me.Guna2Button12
        Me.Guna2Button12.Size = New System.Drawing.Size(123, 36)
        Me.Guna2Button12.TabIndex = 30
        Me.Guna2Button12.Text = "ADD"
        '
        'txt_kodeobatinsert
        '
        Me.txt_kodeobatinsert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_kodeobatinsert.DefaultText = ""
        Me.txt_kodeobatinsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_kodeobatinsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_kodeobatinsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodeobatinsert.DisabledState.Parent = Me.txt_kodeobatinsert
        Me.txt_kodeobatinsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_kodeobatinsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodeobatinsert.FocusedState.Parent = Me.txt_kodeobatinsert
        Me.txt_kodeobatinsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kodeobatinsert.HoverState.Parent = Me.txt_kodeobatinsert
        Me.txt_kodeobatinsert.Location = New System.Drawing.Point(17, 36)
        Me.txt_kodeobatinsert.Name = "txt_kodeobatinsert"
        Me.txt_kodeobatinsert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kodeobatinsert.PlaceholderText = ""
        Me.txt_kodeobatinsert.SelectedText = ""
        Me.txt_kodeobatinsert.ShadowDecoration.Parent = Me.txt_kodeobatinsert
        Me.txt_kodeobatinsert.Size = New System.Drawing.Size(149, 36)
        Me.txt_kodeobatinsert.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(169, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Jenis Obat"
        '
        'txt_jenisobatinsert
        '
        Me.txt_jenisobatinsert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_jenisobatinsert.DefaultText = ""
        Me.txt_jenisobatinsert.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_jenisobatinsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_jenisobatinsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_jenisobatinsert.DisabledState.Parent = Me.txt_jenisobatinsert
        Me.txt_jenisobatinsert.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_jenisobatinsert.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_jenisobatinsert.FocusedState.Parent = Me.txt_jenisobatinsert
        Me.txt_jenisobatinsert.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_jenisobatinsert.HoverState.Parent = Me.txt_jenisobatinsert
        Me.txt_jenisobatinsert.Location = New System.Drawing.Point(172, 100)
        Me.txt_jenisobatinsert.Name = "txt_jenisobatinsert"
        Me.txt_jenisobatinsert.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_jenisobatinsert.PlaceholderText = ""
        Me.txt_jenisobatinsert.SelectedText = ""
        Me.txt_jenisobatinsert.ShadowDecoration.Parent = Me.txt_jenisobatinsert
        Me.txt_jenisobatinsert.Size = New System.Drawing.Size(172, 36)
        Me.txt_jenisobatinsert.TabIndex = 32
        '
        'FormAddRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 591)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_kodekain)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.cmb_process)
        Me.Controls.Add(Me.dginsert)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_buyer)
        Me.Controls.Add(Me.txt_recipe)
        Me.Controls.Add(Me.panelkodekain)
        Me.Controls.Add(Me.panelbuyer)
        Me.Controls.Add(Me.panelinsert)
        Me.Name = "FormAddRecipe"
        Me.Text = "FormAddRecipe"
        CType(Me.dginsert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelkodekain.ResumeLayout(False)
        Me.panelkodekain.PerformLayout()
        CType(Me.dgkodekain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelbuyer.ResumeLayout(False)
        Me.panelbuyer.PerformLayout()
        CType(Me.dgbuyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelinsert.ResumeLayout(False)
        Me.panelinsert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_recipe As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_buyer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dginsert As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmb_process As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_kodekain As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelkodekain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgkodekain As DataGridView
    Friend WithEvents txt_gsminput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_kodekaininput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Kodeobat As DataGridViewTextBoxColumn
    Friend WithEvents NamaObat As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Jenis As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_lebarinput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelbuyer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgbuyer As DataGridView
    Friend WithEvents txt_buyerinput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_kodebuyerinput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelinsert As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_jenisobatinsert As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valueinsert As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_namaobatinsert As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button12 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_kodeobatinsert As Guna.UI2.WinForms.Guna2TextBox
End Class
