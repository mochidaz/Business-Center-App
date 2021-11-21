<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.PNL_TOPMENU = New System.Windows.Forms.Panel()
        Me.LBL_APPNAME = New System.Windows.Forms.Label()
        Me.PNL_ACCOUNT = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.LBL_FNAME = New System.Windows.Forms.Label()
        Me.LBL_STATUS = New System.Windows.Forms.Label()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.PNL_SIDE = New System.Windows.Forms.Panel()
        Me.PNL_Menu = New System.Windows.Forms.Panel()
        Me.PNL_btndboard = New System.Windows.Forms.Panel()
        Me.DBoard_SELECTED = New System.Windows.Forms.Panel()
        Me.PNL_downdate = New System.Windows.Forms.Panel()
        Me.LBL_Date = New System.Windows.Forms.Label()
        Me.PNL_CONTENT = New System.Windows.Forms.Panel()
        Me.PNL_TOP = New System.Windows.Forms.Panel()
        Me.BTN_MENU = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MENUSTRIP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datetimer = New System.Windows.Forms.Timer(Me.components)
        Me.sessiontimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_sbmlap = New System.Windows.Forms.Panel()
        Me.BMasuk_SELECTED = New System.Windows.Forms.Panel()
        Me.BKeluar_SELECTED = New System.Windows.Forms.Panel()
        Me.BTN_BRGKELUAR = New System.Windows.Forms.Button()
        Me.BTN_BRGMASUK = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_LAPORAN = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DBarang_SELECTED = New System.Windows.Forms.Panel()
        Me.BTN_DATABARANG = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BTN_Log = New System.Windows.Forms.Button()
        Me.Log_SELECTED = New System.Windows.Forms.Panel()
        Me.PNL_TOPMENU.SuspendLayout()
        Me.PNL_ACCOUNT.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_SIDE.SuspendLayout()
        Me.PNL_Menu.SuspendLayout()
        Me.PNL_btndboard.SuspendLayout()
        Me.PNL_downdate.SuspendLayout()
        Me.PNL_TOP.SuspendLayout()
        Me.MENUSTRIP.SuspendLayout()
        Me.pnl_sbmlap.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_TOPMENU
        '
        Me.PNL_TOPMENU.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PNL_TOPMENU.Controls.Add(Me.LBL_APPNAME)
        Me.PNL_TOPMENU.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_TOPMENU.Location = New System.Drawing.Point(0, 0)
        Me.PNL_TOPMENU.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_TOPMENU.Name = "PNL_TOPMENU"
        Me.PNL_TOPMENU.Size = New System.Drawing.Size(250, 40)
        Me.PNL_TOPMENU.TabIndex = 0
        '
        'LBL_APPNAME
        '
        Me.LBL_APPNAME.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_APPNAME.AutoSize = True
        Me.LBL_APPNAME.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_APPNAME.ForeColor = System.Drawing.Color.White
        Me.LBL_APPNAME.Location = New System.Drawing.Point(45, 5)
        Me.LBL_APPNAME.Margin = New System.Windows.Forms.Padding(0)
        Me.LBL_APPNAME.Name = "LBL_APPNAME"
        Me.LBL_APPNAME.Size = New System.Drawing.Size(160, 25)
        Me.LBL_APPNAME.TabIndex = 0
        Me.LBL_APPNAME.Text = "Business Center"
        '
        'PNL_ACCOUNT
        '
        Me.PNL_ACCOUNT.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PNL_ACCOUNT.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.PNL_ACCOUNT.Controls.Add(Me.LBL_FNAME)
        Me.PNL_ACCOUNT.Controls.Add(Me.LBL_STATUS)
        Me.PNL_ACCOUNT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_ACCOUNT.Location = New System.Drawing.Point(0, 40)
        Me.PNL_ACCOUNT.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_ACCOUNT.Name = "PNL_ACCOUNT"
        Me.PNL_ACCOUNT.Size = New System.Drawing.Size(250, 90)
        Me.PNL_ACCOUNT.TabIndex = 1
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(12, 17)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2CirclePictureBox1.TabIndex = 3
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'LBL_FNAME
        '
        Me.LBL_FNAME.AutoSize = True
        Me.LBL_FNAME.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FNAME.ForeColor = System.Drawing.Color.White
        Me.LBL_FNAME.Location = New System.Drawing.Point(72, 23)
        Me.LBL_FNAME.Name = "LBL_FNAME"
        Me.LBL_FNAME.Size = New System.Drawing.Size(147, 21)
        Me.LBL_FNAME.TabIndex = 1
        Me.LBL_FNAME.Text = "Get From Fullname"
        '
        'LBL_STATUS
        '
        Me.LBL_STATUS.AutoSize = True
        Me.LBL_STATUS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_STATUS.ForeColor = System.Drawing.Color.White
        Me.LBL_STATUS.Location = New System.Drawing.Point(73, 44)
        Me.LBL_STATUS.Name = "LBL_STATUS"
        Me.LBL_STATUS.Size = New System.Drawing.Size(38, 13)
        Me.LBL_STATUS.TabIndex = 2
        Me.LBL_STATUS.Text = "status"
        '
        'BTN_DASHBOARD
        '
        Me.BTN_DASHBOARD.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_DASHBOARD.FlatAppearance.BorderSize = 0
        Me.BTN_DASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DASHBOARD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DASHBOARD.ForeColor = System.Drawing.Color.White
        Me.BTN_DASHBOARD.Image = CType(resources.GetObject("BTN_DASHBOARD.Image"), System.Drawing.Image)
        Me.BTN_DASHBOARD.Location = New System.Drawing.Point(0, 0)
        Me.BTN_DASHBOARD.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_DASHBOARD.Name = "BTN_DASHBOARD"
        Me.BTN_DASHBOARD.Size = New System.Drawing.Size(250, 72)
        Me.BTN_DASHBOARD.TabIndex = 2
        Me.BTN_DASHBOARD.TabStop = False
        Me.BTN_DASHBOARD.Text = "Dashboard"
        Me.BTN_DASHBOARD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_DASHBOARD.UseVisualStyleBackColor = True
        '
        'PNL_SIDE
        '
        Me.PNL_SIDE.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PNL_SIDE.Controls.Add(Me.PNL_Menu)
        Me.PNL_SIDE.Controls.Add(Me.PNL_downdate)
        Me.PNL_SIDE.Controls.Add(Me.PNL_ACCOUNT)
        Me.PNL_SIDE.Controls.Add(Me.PNL_TOPMENU)
        Me.PNL_SIDE.Dock = System.Windows.Forms.DockStyle.Left
        Me.PNL_SIDE.Location = New System.Drawing.Point(0, 0)
        Me.PNL_SIDE.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_SIDE.Name = "PNL_SIDE"
        Me.PNL_SIDE.Size = New System.Drawing.Size(250, 720)
        Me.PNL_SIDE.TabIndex = 7
        '
        'PNL_Menu
        '
        Me.PNL_Menu.AutoScroll = True
        Me.PNL_Menu.Controls.Add(Me.Panel11)
        Me.PNL_Menu.Controls.Add(Me.pnl_sbmlap)
        Me.PNL_Menu.Controls.Add(Me.Panel2)
        Me.PNL_Menu.Controls.Add(Me.Panel9)
        Me.PNL_Menu.Controls.Add(Me.PNL_btndboard)
        Me.PNL_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Menu.Location = New System.Drawing.Point(0, 130)
        Me.PNL_Menu.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_Menu.Name = "PNL_Menu"
        Me.PNL_Menu.Size = New System.Drawing.Size(250, 548)
        Me.PNL_Menu.TabIndex = 21
        '
        'PNL_btndboard
        '
        Me.PNL_btndboard.Controls.Add(Me.DBoard_SELECTED)
        Me.PNL_btndboard.Controls.Add(Me.BTN_DASHBOARD)
        Me.PNL_btndboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_btndboard.Location = New System.Drawing.Point(0, 0)
        Me.PNL_btndboard.Name = "PNL_btndboard"
        Me.PNL_btndboard.Size = New System.Drawing.Size(250, 72)
        Me.PNL_btndboard.TabIndex = 12
        '
        'DBoard_SELECTED
        '
        Me.DBoard_SELECTED.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DBoard_SELECTED.Location = New System.Drawing.Point(0, 0)
        Me.DBoard_SELECTED.Name = "DBoard_SELECTED"
        Me.DBoard_SELECTED.Size = New System.Drawing.Size(10, 72)
        Me.DBoard_SELECTED.TabIndex = 6
        '
        'PNL_downdate
        '
        Me.PNL_downdate.Controls.Add(Me.LBL_Date)
        Me.PNL_downdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_downdate.Location = New System.Drawing.Point(0, 678)
        Me.PNL_downdate.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_downdate.Name = "PNL_downdate"
        Me.PNL_downdate.Size = New System.Drawing.Size(250, 42)
        Me.PNL_downdate.TabIndex = 20
        '
        'LBL_Date
        '
        Me.LBL_Date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Date.ForeColor = System.Drawing.Color.White
        Me.LBL_Date.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Date.Margin = New System.Windows.Forms.Padding(0)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(250, 42)
        Me.LBL_Date.TabIndex = 2
        Me.LBL_Date.Text = "DD/MM/YYYY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HH/MM/SS"
        Me.LBL_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PNL_CONTENT
        '
        Me.PNL_CONTENT.BackColor = System.Drawing.Color.White
        Me.PNL_CONTENT.Location = New System.Drawing.Point(250, 40)
        Me.PNL_CONTENT.Margin = New System.Windows.Forms.Padding(0)
        Me.PNL_CONTENT.Name = "PNL_CONTENT"
        Me.PNL_CONTENT.Size = New System.Drawing.Size(1030, 680)
        Me.PNL_CONTENT.TabIndex = 2
        '
        'PNL_TOP
        '
        Me.PNL_TOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PNL_TOP.Controls.Add(Me.BTN_MENU)
        Me.PNL_TOP.Controls.Add(Me.Label1)
        Me.PNL_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_TOP.Location = New System.Drawing.Point(250, 0)
        Me.PNL_TOP.Name = "PNL_TOP"
        Me.PNL_TOP.Size = New System.Drawing.Size(1030, 40)
        Me.PNL_TOP.TabIndex = 1
        '
        'BTN_MENU
        '
        Me.BTN_MENU.BackgroundImage = CType(resources.GetObject("BTN_MENU.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MENU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_MENU.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_MENU.FlatAppearance.BorderSize = 0
        Me.BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.BTN_MENU.Location = New System.Drawing.Point(985, 0)
        Me.BTN_MENU.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_MENU.Name = "BTN_MENU"
        Me.BTN_MENU.Size = New System.Drawing.Size(45, 40)
        Me.BTN_MENU.TabIndex = 3
        Me.BTN_MENU.TabStop = False
        Me.BTN_MENU.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1030, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MENUSTRIP
        '
        Me.MENUSTRIP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditUserToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MENUSTRIP.Name = "MENUSTRIP"
        Me.MENUSTRIP.Size = New System.Drawing.Size(169, 92)
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Image = CType(resources.GetObject("EditUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangMasukBulananToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.BarangKeluarBulananToolStripMenuItem})
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Enabled = False
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk (Harian)"
        '
        'BarangMasukBulananToolStripMenuItem
        '
        Me.BarangMasukBulananToolStripMenuItem.Enabled = False
        Me.BarangMasukBulananToolStripMenuItem.Name = "BarangMasukBulananToolStripMenuItem"
        Me.BarangMasukBulananToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BarangMasukBulananToolStripMenuItem.Text = "Barang Masuk (Bulanan)"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar (Harian)"
        '
        'BarangKeluarBulananToolStripMenuItem
        '
        Me.BarangKeluarBulananToolStripMenuItem.Name = "BarangKeluarBulananToolStripMenuItem"
        Me.BarangKeluarBulananToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BarangKeluarBulananToolStripMenuItem.Text = "Barang Keluar (Bulanan)"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'datetimer
        '
        '
        'sessiontimer
        '
        '
        'pnl_sbmlap
        '
        Me.pnl_sbmlap.Controls.Add(Me.BMasuk_SELECTED)
        Me.pnl_sbmlap.Controls.Add(Me.BKeluar_SELECTED)
        Me.pnl_sbmlap.Controls.Add(Me.BTN_BRGKELUAR)
        Me.pnl_sbmlap.Controls.Add(Me.BTN_BRGMASUK)
        Me.pnl_sbmlap.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_sbmlap.Location = New System.Drawing.Point(0, 216)
        Me.pnl_sbmlap.Name = "pnl_sbmlap"
        Me.pnl_sbmlap.Size = New System.Drawing.Size(250, 144)
        Me.pnl_sbmlap.TabIndex = 25
        '
        'BMasuk_SELECTED
        '
        Me.BMasuk_SELECTED.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.BMasuk_SELECTED.Location = New System.Drawing.Point(0, 0)
        Me.BMasuk_SELECTED.Name = "BMasuk_SELECTED"
        Me.BMasuk_SELECTED.Size = New System.Drawing.Size(10, 72)
        Me.BMasuk_SELECTED.TabIndex = 9
        '
        'BKeluar_SELECTED
        '
        Me.BKeluar_SELECTED.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.BKeluar_SELECTED.Location = New System.Drawing.Point(0, 72)
        Me.BKeluar_SELECTED.Name = "BKeluar_SELECTED"
        Me.BKeluar_SELECTED.Size = New System.Drawing.Size(10, 72)
        Me.BKeluar_SELECTED.TabIndex = 10
        '
        'BTN_BRGKELUAR
        '
        Me.BTN_BRGKELUAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BTN_BRGKELUAR.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_BRGKELUAR.FlatAppearance.BorderSize = 0
        Me.BTN_BRGKELUAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BRGKELUAR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BRGKELUAR.ForeColor = System.Drawing.Color.White
        Me.BTN_BRGKELUAR.Image = CType(resources.GetObject("BTN_BRGKELUAR.Image"), System.Drawing.Image)
        Me.BTN_BRGKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_BRGKELUAR.Location = New System.Drawing.Point(0, 72)
        Me.BTN_BRGKELUAR.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_BRGKELUAR.Name = "BTN_BRGKELUAR"
        Me.BTN_BRGKELUAR.Size = New System.Drawing.Size(250, 72)
        Me.BTN_BRGKELUAR.TabIndex = 8
        Me.BTN_BRGKELUAR.TabStop = False
        Me.BTN_BRGKELUAR.Text = "Barang Keluar"
        Me.BTN_BRGKELUAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_BRGKELUAR.UseVisualStyleBackColor = False
        '
        'BTN_BRGMASUK
        '
        Me.BTN_BRGMASUK.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BTN_BRGMASUK.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_BRGMASUK.Enabled = False
        Me.BTN_BRGMASUK.FlatAppearance.BorderSize = 0
        Me.BTN_BRGMASUK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BRGMASUK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BRGMASUK.ForeColor = System.Drawing.Color.White
        Me.BTN_BRGMASUK.Image = CType(resources.GetObject("BTN_BRGMASUK.Image"), System.Drawing.Image)
        Me.BTN_BRGMASUK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_BRGMASUK.Location = New System.Drawing.Point(0, 0)
        Me.BTN_BRGMASUK.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_BRGMASUK.Name = "BTN_BRGMASUK"
        Me.BTN_BRGMASUK.Size = New System.Drawing.Size(250, 72)
        Me.BTN_BRGMASUK.TabIndex = 7
        Me.BTN_BRGMASUK.TabStop = False
        Me.BTN_BRGMASUK.Text = "Barang Masuk"
        Me.BTN_BRGMASUK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_BRGMASUK.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTN_LAPORAN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 72)
        Me.Panel2.TabIndex = 24
        '
        'BTN_LAPORAN
        '
        Me.BTN_LAPORAN.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_LAPORAN.FlatAppearance.BorderSize = 0
        Me.BTN_LAPORAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LAPORAN.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LAPORAN.ForeColor = System.Drawing.Color.White
        Me.BTN_LAPORAN.Image = CType(resources.GetObject("BTN_LAPORAN.Image"), System.Drawing.Image)
        Me.BTN_LAPORAN.Location = New System.Drawing.Point(0, 0)
        Me.BTN_LAPORAN.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_LAPORAN.Name = "BTN_LAPORAN"
        Me.BTN_LAPORAN.Size = New System.Drawing.Size(250, 72)
        Me.BTN_LAPORAN.TabIndex = 5
        Me.BTN_LAPORAN.TabStop = False
        Me.BTN_LAPORAN.Text = "Laporan"
        Me.BTN_LAPORAN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_LAPORAN.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.DBarang_SELECTED)
        Me.Panel9.Controls.Add(Me.BTN_DATABARANG)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 72)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(250, 72)
        Me.Panel9.TabIndex = 23
        '
        'DBarang_SELECTED
        '
        Me.DBarang_SELECTED.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.DBarang_SELECTED.Location = New System.Drawing.Point(0, 0)
        Me.DBarang_SELECTED.Name = "DBarang_SELECTED"
        Me.DBarang_SELECTED.Size = New System.Drawing.Size(10, 72)
        Me.DBarang_SELECTED.TabIndex = 9
        '
        'BTN_DATABARANG
        '
        Me.BTN_DATABARANG.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_DATABARANG.FlatAppearance.BorderSize = 0
        Me.BTN_DATABARANG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DATABARANG.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DATABARANG.ForeColor = System.Drawing.Color.White
        Me.BTN_DATABARANG.Image = CType(resources.GetObject("BTN_DATABARANG.Image"), System.Drawing.Image)
        Me.BTN_DATABARANG.Location = New System.Drawing.Point(0, 0)
        Me.BTN_DATABARANG.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_DATABARANG.Name = "BTN_DATABARANG"
        Me.BTN_DATABARANG.Size = New System.Drawing.Size(250, 70)
        Me.BTN_DATABARANG.TabIndex = 8
        Me.BTN_DATABARANG.TabStop = False
        Me.BTN_DATABARANG.Text = "Data Barang"
        Me.BTN_DATABARANG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_DATABARANG.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Log_SELECTED)
        Me.Panel11.Controls.Add(Me.BTN_Log)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 360)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(250, 72)
        Me.Panel11.TabIndex = 26
        '
        'BTN_Log
        '
        Me.BTN_Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BTN_Log.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_Log.FlatAppearance.BorderSize = 0
        Me.BTN_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Log.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Log.ForeColor = System.Drawing.Color.White
        Me.BTN_Log.Image = CType(resources.GetObject("BTN_Log.Image"), System.Drawing.Image)
        Me.BTN_Log.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Log.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_Log.Name = "BTN_Log"
        Me.BTN_Log.Size = New System.Drawing.Size(250, 72)
        Me.BTN_Log.TabIndex = 12
        Me.BTN_Log.TabStop = False
        Me.BTN_Log.Text = " Log"
        Me.BTN_Log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Log.UseVisualStyleBackColor = False
        '
        'Log_SELECTED
        '
        Me.Log_SELECTED.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Log_SELECTED.Location = New System.Drawing.Point(0, 0)
        Me.Log_SELECTED.Name = "Log_SELECTED"
        Me.Log_SELECTED.Size = New System.Drawing.Size(10, 72)
        Me.Log_SELECTED.TabIndex = 13
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PNL_TOP)
        Me.Controls.Add(Me.PNL_SIDE)
        Me.Controls.Add(Me.PNL_CONTENT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormHome"
        Me.Text = "Form Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL_TOPMENU.ResumeLayout(False)
        Me.PNL_TOPMENU.PerformLayout()
        Me.PNL_ACCOUNT.ResumeLayout(False)
        Me.PNL_ACCOUNT.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_SIDE.ResumeLayout(False)
        Me.PNL_Menu.ResumeLayout(False)
        Me.PNL_btndboard.ResumeLayout(False)
        Me.PNL_downdate.ResumeLayout(False)
        Me.PNL_TOP.ResumeLayout(False)
        Me.MENUSTRIP.ResumeLayout(False)
        Me.pnl_sbmlap.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL_TOPMENU As Panel
    Friend WithEvents PNL_ACCOUNT As Panel
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents PNL_SIDE As Panel
    Friend WithEvents PNL_CONTENT As Panel
    Friend WithEvents LBL_APPNAME As Label
    Friend WithEvents LBL_FNAME As Label
    Friend WithEvents DBoard_SELECTED As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PNL_TOP As Panel
    Friend WithEvents BTN_MENU As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MENUSTRIP As ContextMenuStrip
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datetimer As Timer
    Friend WithEvents LBL_STATUS As Label
    Friend WithEvents LBL_Date As Label
    Friend WithEvents sessiontimer As Timer
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukBulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluarBulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PNL_btndboard As Panel
    Friend WithEvents PNL_downdate As Panel
    Friend WithEvents PNL_Menu As Panel
    Friend WithEvents pnl_sbmlap As Panel
    Friend WithEvents BMasuk_SELECTED As Panel
    Friend WithEvents BKeluar_SELECTED As Panel
    Friend WithEvents BTN_BRGKELUAR As Button
    Friend WithEvents BTN_BRGMASUK As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_LAPORAN As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents DBarang_SELECTED As Panel
    Friend WithEvents BTN_DATABARANG As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BTN_Log As Button
    Friend WithEvents Log_SELECTED As Panel
End Class
