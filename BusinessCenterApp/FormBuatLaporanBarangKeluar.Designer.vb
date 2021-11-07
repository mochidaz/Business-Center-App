<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatLaporanBarangKeluar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RBTN_NMBRG = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_OKnb = New System.Windows.Forms.Button()
        Me.RBTN_IDBRG = New System.Windows.Forms.RadioButton()
        Me.BTN_Batal = New System.Windows.Forms.Button()
        Me.BTN_TambahBrg = New System.Windows.Forms.Button()
        Me.BTN_DeleteBrg = New System.Windows.Forms.Button()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.TB_Keuntungan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_untungrugi = New System.Windows.Forms.Label()
        Me.TB_Subtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Jumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_HargaBeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_HargaJual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_NamaBrg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_IDBRG = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_NoNota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_OKNota = New System.Windows.Forms.Button()
        Me.BTN_OKib = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBTN_NMBRG
        '
        Me.RBTN_NMBRG.AutoSize = True
        Me.RBTN_NMBRG.Location = New System.Drawing.Point(404, 97)
        Me.RBTN_NMBRG.Name = "RBTN_NMBRG"
        Me.RBTN_NMBRG.Size = New System.Drawing.Size(14, 13)
        Me.RBTN_NMBRG.TabIndex = 31
        Me.RBTN_NMBRG.TabStop = True
        Me.RBTN_NMBRG.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(501, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(464, 412)
        Me.DataGridView1.TabIndex = 33
        '
        'Column8
        '
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 43
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Nama Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 97
        '
        'Column2
        '
        Me.Column2.HeaderText = "Harga Beli"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 81
        '
        'Column3
        '
        Me.Column3.HeaderText = "Harga Jual"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 83
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "Subtotal"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 71
        '
        'Column6
        '
        Me.Column6.HeaderText = "Keuntungan"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "Kerugian"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 74
        '
        'BTN_OKnb
        '
        Me.BTN_OKnb.Location = New System.Drawing.Point(424, 92)
        Me.BTN_OKnb.Name = "BTN_OKnb"
        Me.BTN_OKnb.Size = New System.Drawing.Size(60, 23)
        Me.BTN_OKnb.TabIndex = 32
        Me.BTN_OKnb.Text = "OK"
        Me.BTN_OKnb.UseVisualStyleBackColor = True
        '
        'RBTN_IDBRG
        '
        Me.RBTN_IDBRG.AutoSize = True
        Me.RBTN_IDBRG.Location = New System.Drawing.Point(404, 68)
        Me.RBTN_IDBRG.Name = "RBTN_IDBRG"
        Me.RBTN_IDBRG.Size = New System.Drawing.Size(14, 13)
        Me.RBTN_IDBRG.TabIndex = 30
        Me.RBTN_IDBRG.TabStop = True
        Me.RBTN_IDBRG.UseVisualStyleBackColor = True
        '
        'BTN_Batal
        '
        Me.BTN_Batal.Location = New System.Drawing.Point(872, 481)
        Me.BTN_Batal.Name = "BTN_Batal"
        Me.BTN_Batal.Size = New System.Drawing.Size(93, 34)
        Me.BTN_Batal.TabIndex = 20
        Me.BTN_Batal.Text = "Batal"
        Me.BTN_Batal.UseVisualStyleBackColor = True
        '
        'BTN_TambahBrg
        '
        Me.BTN_TambahBrg.Location = New System.Drawing.Point(298, 282)
        Me.BTN_TambahBrg.Name = "BTN_TambahBrg"
        Me.BTN_TambahBrg.Size = New System.Drawing.Size(100, 34)
        Me.BTN_TambahBrg.TabIndex = 19
        Me.BTN_TambahBrg.Text = "Tambah Barang"
        Me.BTN_TambahBrg.UseVisualStyleBackColor = True
        '
        'BTN_DeleteBrg
        '
        Me.BTN_DeleteBrg.Location = New System.Drawing.Point(19, 282)
        Me.BTN_DeleteBrg.Name = "BTN_DeleteBrg"
        Me.BTN_DeleteBrg.Size = New System.Drawing.Size(101, 34)
        Me.BTN_DeleteBrg.TabIndex = 18
        Me.BTN_DeleteBrg.Text = "Delete Barang"
        Me.BTN_DeleteBrg.UseVisualStyleBackColor = True
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Location = New System.Drawing.Point(773, 481)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(93, 34)
        Me.BTN_Simpan.TabIndex = 21
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'TB_Keuntungan
        '
        Me.TB_Keuntungan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Keuntungan.DefaultText = ""
        Me.TB_Keuntungan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Keuntungan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Keuntungan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Keuntungan.DisabledState.Parent = Me.TB_Keuntungan
        Me.TB_Keuntungan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Keuntungan.Enabled = False
        Me.TB_Keuntungan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Keuntungan.FocusedState.Parent = Me.TB_Keuntungan
        Me.TB_Keuntungan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Keuntungan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_Keuntungan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Keuntungan.HoverState.Parent = Me.TB_Keuntungan
        Me.TB_Keuntungan.Location = New System.Drawing.Point(157, 239)
        Me.TB_Keuntungan.MaxLength = 50
        Me.TB_Keuntungan.Name = "TB_Keuntungan"
        Me.TB_Keuntungan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Keuntungan.PlaceholderText = ""
        Me.TB_Keuntungan.SelectedText = ""
        Me.TB_Keuntungan.ShadowDecoration.Parent = Me.TB_Keuntungan
        Me.TB_Keuntungan.Size = New System.Drawing.Size(241, 23)
        Me.TB_Keuntungan.TabIndex = 28
        Me.TB_Keuntungan.TabStop = False
        '
        'lbl_untungrugi
        '
        Me.lbl_untungrugi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_untungrugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_untungrugi.Location = New System.Drawing.Point(19, 239)
        Me.lbl_untungrugi.Name = "lbl_untungrugi"
        Me.lbl_untungrugi.Size = New System.Drawing.Size(120, 23)
        Me.lbl_untungrugi.TabIndex = 16
        Me.lbl_untungrugi.Text = "Keuntungan"
        '
        'TB_Subtotal
        '
        Me.TB_Subtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Subtotal.DefaultText = ""
        Me.TB_Subtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Subtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Subtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Subtotal.DisabledState.Parent = Me.TB_Subtotal
        Me.TB_Subtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Subtotal.Enabled = False
        Me.TB_Subtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Subtotal.FocusedState.Parent = Me.TB_Subtotal
        Me.TB_Subtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Subtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_Subtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Subtotal.HoverState.Parent = Me.TB_Subtotal
        Me.TB_Subtotal.Location = New System.Drawing.Point(157, 210)
        Me.TB_Subtotal.MaxLength = 50
        Me.TB_Subtotal.Name = "TB_Subtotal"
        Me.TB_Subtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Subtotal.PlaceholderText = ""
        Me.TB_Subtotal.SelectedText = ""
        Me.TB_Subtotal.ShadowDecoration.Parent = Me.TB_Subtotal
        Me.TB_Subtotal.Size = New System.Drawing.Size(241, 23)
        Me.TB_Subtotal.TabIndex = 29
        Me.TB_Subtotal.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Subtotal"
        '
        'TB_Jumlah
        '
        Me.TB_Jumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Jumlah.DefaultText = ""
        Me.TB_Jumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Jumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Jumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Jumlah.DisabledState.Parent = Me.TB_Jumlah
        Me.TB_Jumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Jumlah.Enabled = False
        Me.TB_Jumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Jumlah.FocusedState.Parent = Me.TB_Jumlah
        Me.TB_Jumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Jumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_Jumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Jumlah.HoverState.Parent = Me.TB_Jumlah
        Me.TB_Jumlah.Location = New System.Drawing.Point(157, 181)
        Me.TB_Jumlah.MaxLength = 50
        Me.TB_Jumlah.Name = "TB_Jumlah"
        Me.TB_Jumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Jumlah.PlaceholderText = ""
        Me.TB_Jumlah.SelectedText = ""
        Me.TB_Jumlah.ShadowDecoration.Parent = Me.TB_Jumlah
        Me.TB_Jumlah.Size = New System.Drawing.Size(241, 23)
        Me.TB_Jumlah.TabIndex = 27
        Me.TB_Jumlah.TabStop = False
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Jumlah"
        '
        'TB_HargaBeli
        '
        Me.TB_HargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_HargaBeli.DefaultText = ""
        Me.TB_HargaBeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_HargaBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_HargaBeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HargaBeli.DisabledState.Parent = Me.TB_HargaBeli
        Me.TB_HargaBeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HargaBeli.Enabled = False
        Me.TB_HargaBeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaBeli.FocusedState.Parent = Me.TB_HargaBeli
        Me.TB_HargaBeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_HargaBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_HargaBeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaBeli.HoverState.Parent = Me.TB_HargaBeli
        Me.TB_HargaBeli.Location = New System.Drawing.Point(157, 123)
        Me.TB_HargaBeli.MaxLength = 50
        Me.TB_HargaBeli.Name = "TB_HargaBeli"
        Me.TB_HargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HargaBeli.PlaceholderText = ""
        Me.TB_HargaBeli.SelectedText = ""
        Me.TB_HargaBeli.ShadowDecoration.Parent = Me.TB_HargaBeli
        Me.TB_HargaBeli.Size = New System.Drawing.Size(241, 23)
        Me.TB_HargaBeli.TabIndex = 25
        Me.TB_HargaBeli.TabStop = False
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Harga Beli"
        '
        'TB_HargaJual
        '
        Me.TB_HargaJual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_HargaJual.DefaultText = ""
        Me.TB_HargaJual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_HargaJual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_HargaJual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HargaJual.DisabledState.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HargaJual.Enabled = False
        Me.TB_HargaJual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaJual.FocusedState.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_HargaJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_HargaJual.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaJual.HoverState.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Location = New System.Drawing.Point(157, 152)
        Me.TB_HargaJual.MaxLength = 50
        Me.TB_HargaJual.Name = "TB_HargaJual"
        Me.TB_HargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HargaJual.PlaceholderText = ""
        Me.TB_HargaJual.SelectedText = ""
        Me.TB_HargaJual.ShadowDecoration.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Size = New System.Drawing.Size(241, 23)
        Me.TB_HargaJual.TabIndex = 26
        Me.TB_HargaJual.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Harga Jual"
        '
        'TB_NamaBrg
        '
        Me.TB_NamaBrg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NamaBrg.DefaultText = ""
        Me.TB_NamaBrg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_NamaBrg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_NamaBrg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NamaBrg.DisabledState.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NamaBrg.Enabled = False
        Me.TB_NamaBrg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NamaBrg.FocusedState.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_NamaBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_NamaBrg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NamaBrg.HoverState.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Location = New System.Drawing.Point(157, 94)
        Me.TB_NamaBrg.MaxLength = 50
        Me.TB_NamaBrg.Name = "TB_NamaBrg"
        Me.TB_NamaBrg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NamaBrg.PlaceholderText = ""
        Me.TB_NamaBrg.SelectedText = ""
        Me.TB_NamaBrg.ShadowDecoration.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Size = New System.Drawing.Size(241, 23)
        Me.TB_NamaBrg.TabIndex = 24
        Me.TB_NamaBrg.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama Barang"
        '
        'TB_IDBRG
        '
        Me.TB_IDBRG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_IDBRG.DefaultText = ""
        Me.TB_IDBRG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_IDBRG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_IDBRG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_IDBRG.DisabledState.Parent = Me.TB_IDBRG
        Me.TB_IDBRG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_IDBRG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_IDBRG.FocusedState.Parent = Me.TB_IDBRG
        Me.TB_IDBRG.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_IDBRG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_IDBRG.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_IDBRG.HoverState.Parent = Me.TB_IDBRG
        Me.TB_IDBRG.Location = New System.Drawing.Point(157, 65)
        Me.TB_IDBRG.MaxLength = 4
        Me.TB_IDBRG.Name = "TB_IDBRG"
        Me.TB_IDBRG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IDBRG.PlaceholderText = ""
        Me.TB_IDBRG.SelectedText = ""
        Me.TB_IDBRG.ShadowDecoration.Parent = Me.TB_IDBRG
        Me.TB_IDBRG.Size = New System.Drawing.Size(241, 23)
        Me.TB_IDBRG.TabIndex = 23
        Me.TB_IDBRG.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID Barang"
        '
        'TB_NoNota
        '
        Me.TB_NoNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NoNota.DefaultText = ""
        Me.TB_NoNota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_NoNota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_NoNota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NoNota.DisabledState.Parent = Me.TB_NoNota
        Me.TB_NoNota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NoNota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NoNota.FocusedState.Parent = Me.TB_NoNota
        Me.TB_NoNota.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_NoNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_NoNota.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NoNota.HoverState.Parent = Me.TB_NoNota
        Me.TB_NoNota.Location = New System.Drawing.Point(157, 36)
        Me.TB_NoNota.MaxLength = 50
        Me.TB_NoNota.Name = "TB_NoNota"
        Me.TB_NoNota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NoNota.PlaceholderText = ""
        Me.TB_NoNota.SelectedText = ""
        Me.TB_NoNota.ShadowDecoration.Parent = Me.TB_NoNota
        Me.TB_NoNota.Size = New System.Drawing.Size(241, 23)
        Me.TB_NoNota.TabIndex = 22
        Me.TB_NoNota.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "No Nota Keluar"
        '
        'BTN_OKNota
        '
        Me.BTN_OKNota.Location = New System.Drawing.Point(424, 36)
        Me.BTN_OKNota.Name = "BTN_OKNota"
        Me.BTN_OKNota.Size = New System.Drawing.Size(60, 23)
        Me.BTN_OKNota.TabIndex = 32
        Me.BTN_OKNota.Text = "OK"
        Me.BTN_OKNota.UseVisualStyleBackColor = True
        '
        'BTN_OKib
        '
        Me.BTN_OKib.Location = New System.Drawing.Point(424, 65)
        Me.BTN_OKib.Name = "BTN_OKib"
        Me.BTN_OKib.Size = New System.Drawing.Size(60, 23)
        Me.BTN_OKib.TabIndex = 34
        Me.BTN_OKib.Text = "OK"
        Me.BTN_OKib.UseVisualStyleBackColor = True
        '
        'FormBuatLaporanBarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 551)
        Me.Controls.Add(Me.BTN_OKib)
        Me.Controls.Add(Me.RBTN_NMBRG)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_OKNota)
        Me.Controls.Add(Me.BTN_OKnb)
        Me.Controls.Add(Me.RBTN_IDBRG)
        Me.Controls.Add(Me.BTN_Batal)
        Me.Controls.Add(Me.BTN_TambahBrg)
        Me.Controls.Add(Me.BTN_DeleteBrg)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.TB_Keuntungan)
        Me.Controls.Add(Me.lbl_untungrugi)
        Me.Controls.Add(Me.TB_Subtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_Jumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_HargaBeli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_HargaJual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_NamaBrg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_IDBRG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_NoNota)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormBuatLaporanBarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buat Laporan Barang Keluar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBTN_NMBRG As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_OKnb As Button
    Friend WithEvents RBTN_IDBRG As RadioButton
    Friend WithEvents BTN_Batal As Button
    Friend WithEvents BTN_TambahBrg As Button
    Friend WithEvents BTN_DeleteBrg As Button
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents TB_Keuntungan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_untungrugi As Label
    Friend WithEvents TB_Subtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Jumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_HargaBeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_HargaJual As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_NamaBrg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_IDBRG As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_NoNota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_OKNota As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents BTN_OKib As Button
End Class
