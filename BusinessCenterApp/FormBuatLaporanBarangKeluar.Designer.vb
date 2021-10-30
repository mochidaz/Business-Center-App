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
        Me.TB_NoNota = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_IDBRG = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_NamaBrg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_HargaJual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Batal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Jumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Subtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RBTN_IDBRG = New System.Windows.Forms.RadioButton()
        Me.RBTN_NMBRG = New System.Windows.Forms.RadioButton()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_HargaBeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_untungrugi = New System.Windows.Forms.Label()
        Me.TB_Keuntungan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
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
        Me.TB_NoNota.Location = New System.Drawing.Point(171, 44)
        Me.TB_NoNota.MaxLength = 50
        Me.TB_NoNota.Name = "TB_NoNota"
        Me.TB_NoNota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NoNota.PlaceholderText = ""
        Me.TB_NoNota.SelectedText = ""
        Me.TB_NoNota.ShadowDecoration.Parent = Me.TB_NoNota
        Me.TB_NoNota.Size = New System.Drawing.Size(241, 23)
        Me.TB_NoNota.TabIndex = 1
        Me.TB_NoNota.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Nota Keluar"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Barang"
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
        Me.TB_IDBRG.Location = New System.Drawing.Point(171, 73)
        Me.TB_IDBRG.MaxLength = 4
        Me.TB_IDBRG.Name = "TB_IDBRG"
        Me.TB_IDBRG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IDBRG.PlaceholderText = ""
        Me.TB_IDBRG.SelectedText = ""
        Me.TB_IDBRG.ShadowDecoration.Parent = Me.TB_IDBRG
        Me.TB_IDBRG.Size = New System.Drawing.Size(241, 23)
        Me.TB_IDBRG.TabIndex = 2
        Me.TB_IDBRG.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Barang"
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
        Me.TB_NamaBrg.Location = New System.Drawing.Point(171, 102)
        Me.TB_NamaBrg.MaxLength = 50
        Me.TB_NamaBrg.Name = "TB_NamaBrg"
        Me.TB_NamaBrg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NamaBrg.PlaceholderText = ""
        Me.TB_NamaBrg.SelectedText = ""
        Me.TB_NamaBrg.ShadowDecoration.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Size = New System.Drawing.Size(241, 23)
        Me.TB_NamaBrg.TabIndex = 3
        Me.TB_NamaBrg.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Harga Jual"
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
        Me.TB_HargaJual.Location = New System.Drawing.Point(171, 163)
        Me.TB_HargaJual.MaxLength = 50
        Me.TB_HargaJual.Name = "TB_HargaJual"
        Me.TB_HargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HargaJual.PlaceholderText = ""
        Me.TB_HargaJual.SelectedText = ""
        Me.TB_HargaJual.ShadowDecoration.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Size = New System.Drawing.Size(241, 23)
        Me.TB_HargaJual.TabIndex = 4
        Me.TB_HargaJual.TabStop = False
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Location = New System.Drawing.Point(220, 303)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(93, 34)
        Me.BTN_Simpan.TabIndex = 0
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Batal
        '
        Me.BTN_Batal.Location = New System.Drawing.Point(319, 303)
        Me.BTN_Batal.Name = "BTN_Batal"
        Me.BTN_Batal.Size = New System.Drawing.Size(93, 34)
        Me.BTN_Batal.TabIndex = 0
        Me.BTN_Batal.Text = "Batal"
        Me.BTN_Batal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jumlah"
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
        Me.TB_Jumlah.Location = New System.Drawing.Point(171, 192)
        Me.TB_Jumlah.MaxLength = 50
        Me.TB_Jumlah.Name = "TB_Jumlah"
        Me.TB_Jumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Jumlah.PlaceholderText = ""
        Me.TB_Jumlah.SelectedText = ""
        Me.TB_Jumlah.ShadowDecoration.Parent = Me.TB_Jumlah
        Me.TB_Jumlah.Size = New System.Drawing.Size(241, 23)
        Me.TB_Jumlah.TabIndex = 5
        Me.TB_Jumlah.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Subtotal"
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
        Me.TB_Subtotal.Location = New System.Drawing.Point(171, 221)
        Me.TB_Subtotal.MaxLength = 50
        Me.TB_Subtotal.Name = "TB_Subtotal"
        Me.TB_Subtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Subtotal.PlaceholderText = ""
        Me.TB_Subtotal.SelectedText = ""
        Me.TB_Subtotal.ShadowDecoration.Parent = Me.TB_Subtotal
        Me.TB_Subtotal.Size = New System.Drawing.Size(241, 23)
        Me.TB_Subtotal.TabIndex = 6
        Me.TB_Subtotal.TabStop = False
        '
        'RBTN_IDBRG
        '
        Me.RBTN_IDBRG.AutoSize = True
        Me.RBTN_IDBRG.Location = New System.Drawing.Point(430, 78)
        Me.RBTN_IDBRG.Name = "RBTN_IDBRG"
        Me.RBTN_IDBRG.Size = New System.Drawing.Size(14, 13)
        Me.RBTN_IDBRG.TabIndex = 7
        Me.RBTN_IDBRG.TabStop = True
        Me.RBTN_IDBRG.UseVisualStyleBackColor = True
        '
        'RBTN_NMBRG
        '
        Me.RBTN_NMBRG.AutoSize = True
        Me.RBTN_NMBRG.Location = New System.Drawing.Point(430, 107)
        Me.RBTN_NMBRG.Name = "RBTN_NMBRG"
        Me.RBTN_NMBRG.Size = New System.Drawing.Size(14, 13)
        Me.RBTN_NMBRG.TabIndex = 7
        Me.RBTN_NMBRG.TabStop = True
        Me.RBTN_NMBRG.UseVisualStyleBackColor = True
        '
        'BTN_OK
        '
        Me.BTN_OK.Location = New System.Drawing.Point(461, 102)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(60, 23)
        Me.BTN_OK.TabIndex = 8
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Harga Beli"
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
        Me.TB_HargaBeli.Location = New System.Drawing.Point(171, 131)
        Me.TB_HargaBeli.MaxLength = 50
        Me.TB_HargaBeli.Name = "TB_HargaBeli"
        Me.TB_HargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HargaBeli.PlaceholderText = ""
        Me.TB_HargaBeli.SelectedText = ""
        Me.TB_HargaBeli.ShadowDecoration.Parent = Me.TB_HargaBeli
        Me.TB_HargaBeli.Size = New System.Drawing.Size(241, 23)
        Me.TB_HargaBeli.TabIndex = 4
        Me.TB_HargaBeli.TabStop = False
        '
        'lbl_untungrugi
        '
        Me.lbl_untungrugi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_untungrugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_untungrugi.Location = New System.Drawing.Point(33, 250)
        Me.lbl_untungrugi.Name = "lbl_untungrugi"
        Me.lbl_untungrugi.Size = New System.Drawing.Size(120, 32)
        Me.lbl_untungrugi.TabIndex = 0
        Me.lbl_untungrugi.Text = "Keuntungan"
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
        Me.TB_Keuntungan.Location = New System.Drawing.Point(171, 250)
        Me.TB_Keuntungan.MaxLength = 50
        Me.TB_Keuntungan.Name = "TB_Keuntungan"
        Me.TB_Keuntungan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Keuntungan.PlaceholderText = ""
        Me.TB_Keuntungan.SelectedText = ""
        Me.TB_Keuntungan.ShadowDecoration.Parent = Me.TB_Keuntungan
        Me.TB_Keuntungan.Size = New System.Drawing.Size(241, 23)
        Me.TB_Keuntungan.TabIndex = 6
        Me.TB_Keuntungan.TabStop = False
        '
        'FormBuatLaporanBarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 384)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.RBTN_NMBRG)
        Me.Controls.Add(Me.RBTN_IDBRG)
        Me.Controls.Add(Me.BTN_Batal)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuatLaporanBarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buat Laporan Barang Keluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_NoNota As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_IDBRG As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_NamaBrg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_HargaJual As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Batal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_Jumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Subtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RBTN_IDBRG As RadioButton
    Friend WithEvents RBTN_NMBRG As RadioButton
    Friend WithEvents BTN_OK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_HargaBeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_untungrugi As Label
    Friend WithEvents TB_Keuntungan As Guna.UI2.WinForms.Guna2TextBox
End Class
