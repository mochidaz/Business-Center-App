<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogEditLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogEditLaporan))
        Me.dgv_bm = New System.Windows.Forms.DataGridView()
        Me.dgv_bk = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_SearchLogBK = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_editbk = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_hapusbk = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_semuabk = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv_bm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_bm
        '
        Me.dgv_bm.AllowUserToAddRows = False
        Me.dgv_bm.AllowUserToDeleteRows = False
        Me.dgv_bm.AllowUserToResizeColumns = False
        Me.dgv_bm.AllowUserToResizeRows = False
        Me.dgv_bm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_bm.BackgroundColor = System.Drawing.Color.White
        Me.dgv_bm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_bm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bm.Enabled = False
        Me.dgv_bm.Location = New System.Drawing.Point(12, 167)
        Me.dgv_bm.Name = "dgv_bm"
        Me.dgv_bm.ReadOnly = True
        Me.dgv_bm.Size = New System.Drawing.Size(492, 501)
        Me.dgv_bm.TabIndex = 0
        '
        'dgv_bk
        '
        Me.dgv_bk.AllowUserToAddRows = False
        Me.dgv_bk.AllowUserToDeleteRows = False
        Me.dgv_bk.AllowUserToResizeColumns = False
        Me.dgv_bk.AllowUserToResizeRows = False
        Me.dgv_bk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_bk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bk.BackgroundColor = System.Drawing.Color.White
        Me.dgv_bk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_bk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bk.Location = New System.Drawing.Point(526, 167)
        Me.dgv_bk.Name = "dgv_bk"
        Me.dgv_bk.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bk.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_bk.RowHeadersWidth = 40
        Me.dgv_bk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_bk.RowTemplate.Height = 25
        Me.dgv_bk.RowTemplate.ReadOnly = True
        Me.dgv_bk.Size = New System.Drawing.Size(492, 501)
        Me.dgv_bk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Barang Masuk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Historic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(528, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Barang Keluar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_Search
        '
        Me.TB_Search.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TB_Search.BorderRadius = 10
        Me.TB_Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Search.DefaultText = ""
        Me.TB_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Search.DisabledState.Parent = Me.TB_Search
        Me.TB_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_Search.Enabled = False
        Me.TB_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Search.FocusedState.Parent = Me.TB_Search
        Me.TB_Search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Search.HoverState.Parent = Me.TB_Search
        Me.TB_Search.IconRight = CType(resources.GetObject("TB_Search.IconRight"), System.Drawing.Image)
        Me.TB_Search.Location = New System.Drawing.Point(12, 80)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TB_Search.PlaceholderText = "Cari disini"
        Me.TB_Search.SelectedText = ""
        Me.TB_Search.ShadowDecoration.Parent = Me.TB_Search
        Me.TB_Search.Size = New System.Drawing.Size(492, 35)
        Me.TB_Search.TabIndex = 13
        '
        'TB_SearchLogBK
        '
        Me.TB_SearchLogBK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TB_SearchLogBK.BorderRadius = 10
        Me.TB_SearchLogBK.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_SearchLogBK.DefaultText = ""
        Me.TB_SearchLogBK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_SearchLogBK.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_SearchLogBK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SearchLogBK.DisabledState.Parent = Me.TB_SearchLogBK
        Me.TB_SearchLogBK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SearchLogBK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SearchLogBK.FocusedState.Parent = Me.TB_SearchLogBK
        Me.TB_SearchLogBK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_SearchLogBK.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SearchLogBK.HoverState.Parent = Me.TB_SearchLogBK
        Me.TB_SearchLogBK.IconRight = CType(resources.GetObject("TB_SearchLogBK.IconRight"), System.Drawing.Image)
        Me.TB_SearchLogBK.Location = New System.Drawing.Point(526, 80)
        Me.TB_SearchLogBK.Name = "TB_SearchLogBK"
        Me.TB_SearchLogBK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SearchLogBK.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TB_SearchLogBK.PlaceholderText = "Cari disini"
        Me.TB_SearchLogBK.SelectedText = ""
        Me.TB_SearchLogBK.ShadowDecoration.Parent = Me.TB_SearchLogBK
        Me.TB_SearchLogBK.Size = New System.Drawing.Size(492, 35)
        Me.TB_SearchLogBK.TabIndex = 14
        '
        'btn_editbk
        '
        Me.btn_editbk.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_editbk.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_editbk.CheckedState.Parent = Me.btn_editbk
        Me.btn_editbk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editbk.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_editbk.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_editbk.CustomImages.Parent = Me.btn_editbk
        Me.btn_editbk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_editbk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_editbk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_editbk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_editbk.DisabledState.Parent = Me.btn_editbk
        Me.btn_editbk.FillColor = System.Drawing.Color.Transparent
        Me.btn_editbk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_editbk.ForeColor = System.Drawing.Color.Black
        Me.btn_editbk.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_editbk.HoverState.Parent = Me.btn_editbk
        Me.btn_editbk.Location = New System.Drawing.Point(64, 5)
        Me.btn_editbk.Name = "btn_editbk"
        Me.btn_editbk.PressedColor = System.Drawing.Color.Transparent
        Me.btn_editbk.ShadowDecoration.Parent = Me.btn_editbk
        Me.btn_editbk.Size = New System.Drawing.Size(55, 25)
        Me.btn_editbk.TabIndex = 22
        Me.btn_editbk.Text = "Edit"
        '
        'btn_hapusbk
        '
        Me.btn_hapusbk.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_hapusbk.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_hapusbk.CheckedState.Parent = Me.btn_hapusbk
        Me.btn_hapusbk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hapusbk.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_hapusbk.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_hapusbk.CustomImages.Parent = Me.btn_hapusbk
        Me.btn_hapusbk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_hapusbk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_hapusbk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_hapusbk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_hapusbk.DisabledState.Parent = Me.btn_hapusbk
        Me.btn_hapusbk.FillColor = System.Drawing.Color.Transparent
        Me.btn_hapusbk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_hapusbk.ForeColor = System.Drawing.Color.Black
        Me.btn_hapusbk.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_hapusbk.HoverState.Parent = Me.btn_hapusbk
        Me.btn_hapusbk.Location = New System.Drawing.Point(119, 5)
        Me.btn_hapusbk.Name = "btn_hapusbk"
        Me.btn_hapusbk.PressedColor = System.Drawing.Color.Transparent
        Me.btn_hapusbk.ShadowDecoration.Parent = Me.btn_hapusbk
        Me.btn_hapusbk.Size = New System.Drawing.Size(61, 25)
        Me.btn_hapusbk.TabIndex = 23
        Me.btn_hapusbk.Text = "Hapus"
        '
        'btn_semuabk
        '
        Me.btn_semuabk.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_semuabk.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_semuabk.CheckedState.Parent = Me.btn_semuabk
        Me.btn_semuabk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_semuabk.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_semuabk.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_semuabk.CustomImages.Parent = Me.btn_semuabk
        Me.btn_semuabk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_semuabk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_semuabk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_semuabk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_semuabk.DisabledState.Parent = Me.btn_semuabk
        Me.btn_semuabk.FillColor = System.Drawing.Color.Transparent
        Me.btn_semuabk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_semuabk.ForeColor = System.Drawing.Color.Black
        Me.btn_semuabk.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_semuabk.HoverState.Parent = Me.btn_semuabk
        Me.btn_semuabk.Location = New System.Drawing.Point(0, 5)
        Me.btn_semuabk.Name = "btn_semuabk"
        Me.btn_semuabk.PressedColor = System.Drawing.Color.Transparent
        Me.btn_semuabk.ShadowDecoration.Parent = Me.btn_semuabk
        Me.btn_semuabk.Size = New System.Drawing.Size(64, 25)
        Me.btn_semuabk.TabIndex = 27
        Me.btn_semuabk.Text = "Semua"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btn_semuabk)
        Me.Guna2Panel1.Controls.Add(Me.btn_editbk)
        Me.Guna2Panel1.Controls.Add(Me.btn_hapusbk)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(533, 121)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(477, 30)
        Me.Guna2Panel1.TabIndex = 28
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel2.Enabled = False
        Me.Guna2Panel2.Location = New System.Drawing.Point(17, 121)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(477, 30)
        Me.Guna2Panel2.TabIndex = 29
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 5)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(64, 25)
        Me.Guna2Button1.TabIndex = 27
        Me.Guna2Button1.Text = "Semua"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.DisabledState.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(64, 5)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(55, 25)
        Me.Guna2Button2.TabIndex = 22
        Me.Guna2Button2.Text = "Edit"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.DisabledState.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(119, 5)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(61, 25)
        Me.Guna2Button3.TabIndex = 23
        Me.Guna2Button3.Text = "Hapus"
        '
        'FormLogEditLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 680)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TB_SearchLogBK)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_bk)
        Me.Controls.Add(Me.dgv_bm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1030, 680)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1030, 680)
        Me.Name = "FormLogEditLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_bm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_bk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_bm As DataGridView
    Friend WithEvents dgv_bk As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_SearchLogBK As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_editbk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_hapusbk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_semuabk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
