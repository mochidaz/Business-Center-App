<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLog
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLog))
        Me.btn_lpbk = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_barang = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_account = New Guna.UI2.WinForms.Guna2Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_Refreshtbl = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.TB_Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.rb0 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rb1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rb2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rb3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btn_datus = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_lpbk
        '
        Me.btn_lpbk.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_lpbk.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_lpbk.CheckedState.Parent = Me.btn_lpbk
        Me.btn_lpbk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lpbk.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_lpbk.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_lpbk.CustomImages.Parent = Me.btn_lpbk
        Me.btn_lpbk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_lpbk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_lpbk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_lpbk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_lpbk.DisabledState.Parent = Me.btn_lpbk
        Me.btn_lpbk.FillColor = System.Drawing.Color.Transparent
        Me.btn_lpbk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_lpbk.ForeColor = System.Drawing.Color.Black
        Me.btn_lpbk.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_lpbk.HoverState.Parent = Me.btn_lpbk
        Me.btn_lpbk.Location = New System.Drawing.Point(142, 5)
        Me.btn_lpbk.Name = "btn_lpbk"
        Me.btn_lpbk.PressedColor = System.Drawing.Color.Transparent
        Me.btn_lpbk.ShadowDecoration.Parent = Me.btn_lpbk
        Me.btn_lpbk.Size = New System.Drawing.Size(61, 25)
        Me.btn_lpbk.TabIndex = 23
        Me.btn_lpbk.Text = "LPBK"
        '
        'btn_barang
        '
        Me.btn_barang.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_barang.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_barang.CheckedState.Parent = Me.btn_barang
        Me.btn_barang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_barang.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_barang.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_barang.CustomImages.Parent = Me.btn_barang
        Me.btn_barang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_barang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_barang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_barang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_barang.DisabledState.Parent = Me.btn_barang
        Me.btn_barang.FillColor = System.Drawing.Color.Transparent
        Me.btn_barang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_barang.ForeColor = System.Drawing.Color.Black
        Me.btn_barang.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_barang.HoverState.Parent = Me.btn_barang
        Me.btn_barang.Location = New System.Drawing.Point(75, 5)
        Me.btn_barang.Name = "btn_barang"
        Me.btn_barang.PressedColor = System.Drawing.Color.Transparent
        Me.btn_barang.ShadowDecoration.Parent = Me.btn_barang
        Me.btn_barang.Size = New System.Drawing.Size(66, 25)
        Me.btn_barang.TabIndex = 22
        Me.btn_barang.Text = "Barang"
        '
        'btn_account
        '
        Me.btn_account.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_account.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_account.CheckedState.Parent = Me.btn_account
        Me.btn_account.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_account.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_account.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_account.CustomImages.Parent = Me.btn_account
        Me.btn_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_account.DisabledState.Parent = Me.btn_account
        Me.btn_account.FillColor = System.Drawing.Color.Transparent
        Me.btn_account.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_account.ForeColor = System.Drawing.Color.Black
        Me.btn_account.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_account.HoverState.Parent = Me.btn_account
        Me.btn_account.Location = New System.Drawing.Point(0, 5)
        Me.btn_account.Name = "btn_account"
        Me.btn_account.PressedColor = System.Drawing.Color.Transparent
        Me.btn_account.ShadowDecoration.Parent = Me.btn_account
        Me.btn_account.Size = New System.Drawing.Size(75, 25)
        Me.btn_account.TabIndex = 27
        Me.btn_account.Text = "Account"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(42, 144)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.RowHeadersWidth = 55
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(948, 514)
        Me.dgv.TabIndex = 1
        '
        'BTN_Refreshtbl
        '
        Me.BTN_Refreshtbl.CheckedState.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.CheckedState.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Refreshtbl.HoverState.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.HoverState.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.Image = CType(resources.GetObject("BTN_Refreshtbl.Image"), System.Drawing.Image)
        Me.BTN_Refreshtbl.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Refreshtbl.ImageRotate = 0!
        Me.BTN_Refreshtbl.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.Location = New System.Drawing.Point(958, 27)
        Me.BTN_Refreshtbl.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_Refreshtbl.Name = "BTN_Refreshtbl"
        Me.BTN_Refreshtbl.PressedState.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.PressedState.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.ShadowDecoration.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.Size = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.TabIndex = 28
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
        Me.TB_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Search.FocusedState.Parent = Me.TB_Search
        Me.TB_Search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_Search.HoverState.Parent = Me.TB_Search
        Me.TB_Search.IconRight = CType(resources.GetObject("TB_Search.IconRight"), System.Drawing.Image)
        Me.TB_Search.Location = New System.Drawing.Point(42, 27)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TB_Search.PlaceholderText = "Cari disini"
        Me.TB_Search.SelectedText = ""
        Me.TB_Search.ShadowDecoration.Parent = Me.TB_Search
        Me.TB_Search.Size = New System.Drawing.Size(892, 35)
        Me.TB_Search.TabIndex = 33
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btn_datus)
        Me.Guna2Panel1.Controls.Add(Me.btn_account)
        Me.Guna2Panel1.Controls.Add(Me.btn_barang)
        Me.Guna2Panel1.Controls.Add(Me.btn_lpbk)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(42, 75)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(948, 30)
        Me.Guna2Panel1.TabIndex = 28
        '
        'rb0
        '
        Me.rb0.AutoSize = True
        Me.rb0.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb0.CheckedState.BorderThickness = 0
        Me.rb0.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb0.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb0.CheckedState.InnerOffset = -4
        Me.rb0.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb0.Location = New System.Drawing.Point(57, 115)
        Me.rb0.Name = "rb0"
        Me.rb0.Size = New System.Drawing.Size(59, 17)
        Me.rb0.TabIndex = 34
        Me.rb0.Text = "Semua"
        Me.rb0.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb0.UncheckedState.BorderThickness = 2
        Me.rb0.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb0.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb1.CheckedState.BorderThickness = 0
        Me.rb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb1.CheckedState.InnerOffset = -4
        Me.rb1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(121, 115)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(45, 17)
        Me.rb1.TabIndex = 35
        Me.rb1.Text = "Edit"
        Me.rb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb1.UncheckedState.BorderThickness = 2
        Me.rb1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb2.CheckedState.BorderThickness = 0
        Me.rb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb2.CheckedState.InnerOffset = -4
        Me.rb2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(175, 115)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(58, 17)
        Me.rb2.TabIndex = 36
        Me.rb2.Text = "Delete"
        Me.rb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb2.UncheckedState.BorderThickness = 2
        Me.rb2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb3.CheckedState.BorderThickness = 0
        Me.rb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rb3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb3.CheckedState.InnerOffset = -4
        Me.rb3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rb3.Location = New System.Drawing.Point(241, 115)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(31, 17)
        Me.rb3.TabIndex = 37
        Me.rb3.Text = "3"
        Me.rb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb3.UncheckedState.BorderThickness = 2
        Me.rb3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btn_datus
        '
        Me.btn_datus.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_datus.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_datus.CheckedState.Parent = Me.btn_datus
        Me.btn_datus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_datus.CustomBorderColor = System.Drawing.Color.Silver
        Me.btn_datus.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_datus.CustomImages.Parent = Me.btn_datus
        Me.btn_datus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_datus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_datus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_datus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_datus.DisabledState.Parent = Me.btn_datus
        Me.btn_datus.FillColor = System.Drawing.Color.Transparent
        Me.btn_datus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_datus.ForeColor = System.Drawing.Color.Black
        Me.btn_datus.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_datus.HoverState.Parent = Me.btn_datus
        Me.btn_datus.Location = New System.Drawing.Point(203, 5)
        Me.btn_datus.Name = "btn_datus"
        Me.btn_datus.PressedColor = System.Drawing.Color.Transparent
        Me.btn_datus.ShadowDecoration.Parent = Me.btn_datus
        Me.btn_datus.Size = New System.Drawing.Size(77, 25)
        Me.btn_datus.TabIndex = 28
        Me.btn_datus.Text = "Data User"
        '
        'FormLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 680)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.rb0)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.BTN_Refreshtbl)
        Me.Controls.Add(Me.TB_Search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1030, 680)
        Me.MinimumSize = New System.Drawing.Size(1030, 680)
        Me.Name = "FormLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormLog"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_lpbk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_barang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_account As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BTN_Refreshtbl As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents TB_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rb0 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rb1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rb2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rb3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_datus As Guna.UI2.WinForms.Guna2Button
End Class
