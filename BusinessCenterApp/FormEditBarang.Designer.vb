<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditBarang
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
        Me.BTN_SIMPAN = New System.Windows.Forms.Button()
        Me.BTN_DELETBARANG = New System.Windows.Forms.Button()
        Me.BTN_EDITHJual = New System.Windows.Forms.Button()
        Me.BTN_EDITHBeli = New System.Windows.Forms.Button()
        Me.BTN_EDITNBarang = New System.Windows.Forms.Button()
        Me.BTN_OKUID = New System.Windows.Forms.Button()
        Me.TB_HBeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_NBarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_IDbarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_HJual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_Stok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_EDITSTOK = New System.Windows.Forms.Button()
        Me.TB_CurHb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_CurHj = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'BTN_SIMPAN
        '
        Me.BTN_SIMPAN.Location = New System.Drawing.Point(393, 272)
        Me.BTN_SIMPAN.Name = "BTN_SIMPAN"
        Me.BTN_SIMPAN.Size = New System.Drawing.Size(112, 27)
        Me.BTN_SIMPAN.TabIndex = 23
        Me.BTN_SIMPAN.TabStop = False
        Me.BTN_SIMPAN.Text = "Simpan"
        Me.BTN_SIMPAN.UseVisualStyleBackColor = True
        '
        'BTN_DELETBARANG
        '
        Me.BTN_DELETBARANG.Location = New System.Drawing.Point(38, 272)
        Me.BTN_DELETBARANG.Name = "BTN_DELETBARANG"
        Me.BTN_DELETBARANG.Size = New System.Drawing.Size(112, 27)
        Me.BTN_DELETBARANG.TabIndex = 24
        Me.BTN_DELETBARANG.TabStop = False
        Me.BTN_DELETBARANG.Text = "Delete Barang"
        Me.BTN_DELETBARANG.UseVisualStyleBackColor = True
        '
        'BTN_EDITHJual
        '
        Me.BTN_EDITHJual.Location = New System.Drawing.Point(430, 152)
        Me.BTN_EDITHJual.Name = "BTN_EDITHJual"
        Me.BTN_EDITHJual.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITHJual.TabIndex = 22
        Me.BTN_EDITHJual.TabStop = False
        Me.BTN_EDITHJual.Text = "Edit"
        Me.BTN_EDITHJual.UseVisualStyleBackColor = True
        '
        'BTN_EDITHBeli
        '
        Me.BTN_EDITHBeli.Location = New System.Drawing.Point(430, 94)
        Me.BTN_EDITHBeli.Name = "BTN_EDITHBeli"
        Me.BTN_EDITHBeli.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITHBeli.TabIndex = 21
        Me.BTN_EDITHBeli.TabStop = False
        Me.BTN_EDITHBeli.Text = "Edit"
        Me.BTN_EDITHBeli.UseVisualStyleBackColor = True
        '
        'BTN_EDITNBarang
        '
        Me.BTN_EDITNBarang.Location = New System.Drawing.Point(430, 65)
        Me.BTN_EDITNBarang.Name = "BTN_EDITNBarang"
        Me.BTN_EDITNBarang.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITNBarang.TabIndex = 20
        Me.BTN_EDITNBarang.TabStop = False
        Me.BTN_EDITNBarang.Text = "Edit"
        Me.BTN_EDITNBarang.UseVisualStyleBackColor = True
        '
        'BTN_OKUID
        '
        Me.BTN_OKUID.Location = New System.Drawing.Point(430, 36)
        Me.BTN_OKUID.Name = "BTN_OKUID"
        Me.BTN_OKUID.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OKUID.TabIndex = 19
        Me.BTN_OKUID.TabStop = False
        Me.BTN_OKUID.Text = "OK"
        Me.BTN_OKUID.UseVisualStyleBackColor = True
        '
        'TB_HBeli
        '
        Me.TB_HBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_HBeli.DefaultText = ""
        Me.TB_HBeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_HBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_HBeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HBeli.DisabledState.Parent = Me.TB_HBeli
        Me.TB_HBeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HBeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HBeli.FocusedState.Parent = Me.TB_HBeli
        Me.TB_HBeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_HBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_HBeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HBeli.HoverState.Parent = Me.TB_HBeli
        Me.TB_HBeli.Location = New System.Drawing.Point(183, 94)
        Me.TB_HBeli.MaxLength = 50
        Me.TB_HBeli.Name = "TB_HBeli"
        Me.TB_HBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HBeli.PlaceholderText = ""
        Me.TB_HBeli.SelectedText = ""
        Me.TB_HBeli.ShadowDecoration.Parent = Me.TB_HBeli
        Me.TB_HBeli.Size = New System.Drawing.Size(241, 23)
        Me.TB_HBeli.TabIndex = 16
        Me.TB_HBeli.TabStop = False
        '
        'TB_NBarang
        '
        Me.TB_NBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NBarang.DefaultText = ""
        Me.TB_NBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_NBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_NBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NBarang.DisabledState.Parent = Me.TB_NBarang
        Me.TB_NBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NBarang.FocusedState.Parent = Me.TB_NBarang
        Me.TB_NBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_NBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_NBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NBarang.HoverState.Parent = Me.TB_NBarang
        Me.TB_NBarang.Location = New System.Drawing.Point(183, 65)
        Me.TB_NBarang.MaxLength = 50
        Me.TB_NBarang.Name = "TB_NBarang"
        Me.TB_NBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NBarang.PlaceholderText = ""
        Me.TB_NBarang.SelectedText = ""
        Me.TB_NBarang.ShadowDecoration.Parent = Me.TB_NBarang
        Me.TB_NBarang.Size = New System.Drawing.Size(241, 23)
        Me.TB_NBarang.TabIndex = 14
        Me.TB_NBarang.TabStop = False
        '
        'TB_IDbarang
        '
        Me.TB_IDbarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_IDbarang.DefaultText = ""
        Me.TB_IDbarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_IDbarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_IDbarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_IDbarang.DisabledState.Parent = Me.TB_IDbarang
        Me.TB_IDbarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_IDbarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_IDbarang.FocusedState.Parent = Me.TB_IDbarang
        Me.TB_IDbarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_IDbarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_IDbarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_IDbarang.HoverState.Parent = Me.TB_IDbarang
        Me.TB_IDbarang.Location = New System.Drawing.Point(183, 36)
        Me.TB_IDbarang.MaxLength = 4
        Me.TB_IDbarang.Name = "TB_IDbarang"
        Me.TB_IDbarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_IDbarang.PlaceholderText = ""
        Me.TB_IDbarang.SelectedText = ""
        Me.TB_IDbarang.ShadowDecoration.Parent = Me.TB_IDbarang
        Me.TB_IDbarang.Size = New System.Drawing.Size(241, 23)
        Me.TB_IDbarang.TabIndex = 12
        Me.TB_IDbarang.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 52)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Harga Jual"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 52)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Harga Beli"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Barang"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Stok"
        '
        'TB_HJual
        '
        Me.TB_HJual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_HJual.DefaultText = ""
        Me.TB_HJual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_HJual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_HJual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HJual.DisabledState.Parent = Me.TB_HJual
        Me.TB_HJual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_HJual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HJual.FocusedState.Parent = Me.TB_HJual
        Me.TB_HJual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_HJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_HJual.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HJual.HoverState.Parent = Me.TB_HJual
        Me.TB_HJual.Location = New System.Drawing.Point(183, 152)
        Me.TB_HJual.MaxLength = 50
        Me.TB_HJual.Name = "TB_HJual"
        Me.TB_HJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HJual.PlaceholderText = ""
        Me.TB_HJual.SelectedText = ""
        Me.TB_HJual.ShadowDecoration.Parent = Me.TB_HJual
        Me.TB_HJual.Size = New System.Drawing.Size(241, 23)
        Me.TB_HJual.TabIndex = 16
        Me.TB_HJual.TabStop = False
        '
        'TB_Stok
        '
        Me.TB_Stok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Stok.DefaultText = ""
        Me.TB_Stok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Stok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Stok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Stok.DisabledState.Parent = Me.TB_Stok
        Me.TB_Stok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Stok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Stok.FocusedState.Parent = Me.TB_Stok
        Me.TB_Stok.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Stok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_Stok.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Stok.HoverState.Parent = Me.TB_Stok
        Me.TB_Stok.Location = New System.Drawing.Point(183, 210)
        Me.TB_Stok.MaxLength = 50
        Me.TB_Stok.Name = "TB_Stok"
        Me.TB_Stok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Stok.PlaceholderText = ""
        Me.TB_Stok.SelectedText = ""
        Me.TB_Stok.ShadowDecoration.Parent = Me.TB_Stok
        Me.TB_Stok.Size = New System.Drawing.Size(241, 23)
        Me.TB_Stok.TabIndex = 16
        Me.TB_Stok.TabStop = False
        '
        'BTN_EDITSTOK
        '
        Me.BTN_EDITSTOK.Location = New System.Drawing.Point(430, 210)
        Me.BTN_EDITSTOK.Name = "BTN_EDITSTOK"
        Me.BTN_EDITSTOK.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITSTOK.TabIndex = 22
        Me.BTN_EDITSTOK.TabStop = False
        Me.BTN_EDITSTOK.Text = "Edit"
        Me.BTN_EDITSTOK.UseVisualStyleBackColor = True
        '
        'TB_CurHb
        '
        Me.TB_CurHb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_CurHb.DefaultText = ""
        Me.TB_CurHb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_CurHb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_CurHb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurHb.DisabledState.Parent = Me.TB_CurHb
        Me.TB_CurHb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurHb.Enabled = False
        Me.TB_CurHb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurHb.FocusedState.Parent = Me.TB_CurHb
        Me.TB_CurHb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_CurHb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_CurHb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurHb.HoverState.Parent = Me.TB_CurHb
        Me.TB_CurHb.Location = New System.Drawing.Point(183, 123)
        Me.TB_CurHb.MaxLength = 50
        Me.TB_CurHb.Name = "TB_CurHb"
        Me.TB_CurHb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_CurHb.PlaceholderText = ""
        Me.TB_CurHb.SelectedText = ""
        Me.TB_CurHb.ShadowDecoration.Parent = Me.TB_CurHb
        Me.TB_CurHb.Size = New System.Drawing.Size(241, 23)
        Me.TB_CurHb.TabIndex = 16
        Me.TB_CurHb.TabStop = False
        '
        'TB_CurHj
        '
        Me.TB_CurHj.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_CurHj.DefaultText = ""
        Me.TB_CurHj.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_CurHj.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_CurHj.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurHj.DisabledState.Parent = Me.TB_CurHj
        Me.TB_CurHj.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurHj.Enabled = False
        Me.TB_CurHj.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurHj.FocusedState.Parent = Me.TB_CurHj
        Me.TB_CurHj.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_CurHj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_CurHj.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurHj.HoverState.Parent = Me.TB_CurHj
        Me.TB_CurHj.Location = New System.Drawing.Point(183, 181)
        Me.TB_CurHj.MaxLength = 50
        Me.TB_CurHj.Name = "TB_CurHj"
        Me.TB_CurHj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_CurHj.PlaceholderText = ""
        Me.TB_CurHj.SelectedText = ""
        Me.TB_CurHj.ShadowDecoration.Parent = Me.TB_CurHj
        Me.TB_CurHj.Size = New System.Drawing.Size(241, 23)
        Me.TB_CurHj.TabIndex = 16
        Me.TB_CurHj.TabStop = False
        '
        'FormEditBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 339)
        Me.Controls.Add(Me.BTN_SIMPAN)
        Me.Controls.Add(Me.BTN_DELETBARANG)
        Me.Controls.Add(Me.BTN_EDITSTOK)
        Me.Controls.Add(Me.BTN_EDITHJual)
        Me.Controls.Add(Me.BTN_EDITHBeli)
        Me.Controls.Add(Me.BTN_EDITNBarang)
        Me.Controls.Add(Me.BTN_OKUID)
        Me.Controls.Add(Me.TB_Stok)
        Me.Controls.Add(Me.TB_CurHj)
        Me.Controls.Add(Me.TB_HJual)
        Me.Controls.Add(Me.TB_CurHb)
        Me.Controls.Add(Me.TB_HBeli)
        Me.Controls.Add(Me.TB_NBarang)
        Me.Controls.Add(Me.TB_IDbarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Barang"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_SIMPAN As Button
    Friend WithEvents BTN_DELETBARANG As Button
    Friend WithEvents BTN_EDITHJual As Button
    Friend WithEvents BTN_EDITHBeli As Button
    Friend WithEvents BTN_EDITNBarang As Button
    Friend WithEvents BTN_OKUID As Button
    Friend WithEvents TB_HBeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_NBarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_IDbarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_HJual As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_Stok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_EDITSTOK As Button
    Friend WithEvents TB_CurHb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_CurHj As Guna.UI2.WinForms.Guna2TextBox
End Class
