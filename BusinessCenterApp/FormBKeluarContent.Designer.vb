<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBKeluarContent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBKeluarContent))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_TambahBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_EditBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Refreshtbl = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_cetak_nota = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersWidth = 55
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(948, 486)
        Me.DataGridView1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Laporan Barang Keluar"
        '
        'BTN_TambahBarang
        '
        Me.BTN_TambahBarang.BorderRadius = 5
        Me.BTN_TambahBarang.CheckedState.Parent = Me.BTN_TambahBarang
        Me.BTN_TambahBarang.CustomImages.Parent = Me.BTN_TambahBarang
        Me.BTN_TambahBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TambahBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TambahBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_TambahBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_TambahBarang.DisabledState.Parent = Me.BTN_TambahBarang
        Me.BTN_TambahBarang.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_TambahBarang.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_TambahBarang.ForeColor = System.Drawing.Color.White
        Me.BTN_TambahBarang.HoverState.Parent = Me.BTN_TambahBarang
        Me.BTN_TambahBarang.Location = New System.Drawing.Point(810, 20)
        Me.BTN_TambahBarang.Name = "BTN_TambahBarang"
        Me.BTN_TambahBarang.ShadowDecoration.Parent = Me.BTN_TambahBarang
        Me.BTN_TambahBarang.Size = New System.Drawing.Size(180, 35)
        Me.BTN_TambahBarang.TabIndex = 9
        Me.BTN_TambahBarang.Text = "+ Buat Laporan Baru"
        '
        'BTN_EditBarang
        '
        Me.BTN_EditBarang.BorderRadius = 5
        Me.BTN_EditBarang.CheckedState.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.CustomImages.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_EditBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_EditBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_EditBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_EditBarang.DisabledState.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BTN_EditBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EditBarang.ForeColor = System.Drawing.Color.White
        Me.BTN_EditBarang.HoverState.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.Location = New System.Drawing.Point(671, 20)
        Me.BTN_EditBarang.Name = "BTN_EditBarang"
        Me.BTN_EditBarang.ShadowDecoration.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.Size = New System.Drawing.Size(106, 35)
        Me.BTN_EditBarang.TabIndex = 10
        Me.BTN_EditBarang.Text = "Edit Laporan"
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
        Me.TB_Search.Location = New System.Drawing.Point(42, 76)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TB_Search.PlaceholderText = "Cari disini"
        Me.TB_Search.SelectedText = ""
        Me.TB_Search.ShadowDecoration.Parent = Me.TB_Search
        Me.TB_Search.Size = New System.Drawing.Size(892, 35)
        Me.TB_Search.TabIndex = 12
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
        Me.BTN_Refreshtbl.Location = New System.Drawing.Point(958, 76)
        Me.BTN_Refreshtbl.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_Refreshtbl.Name = "BTN_Refreshtbl"
        Me.BTN_Refreshtbl.PressedState.ImageSize = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.PressedState.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.ShadowDecoration.Parent = Me.BTN_Refreshtbl
        Me.BTN_Refreshtbl.Size = New System.Drawing.Size(32, 32)
        Me.BTN_Refreshtbl.TabIndex = 0
        '
        'btn_cetak_nota
        '
        Me.btn_cetak_nota.BorderRadius = 5
        Me.btn_cetak_nota.CheckedState.Parent = Me.btn_cetak_nota
        Me.btn_cetak_nota.CustomImages.Parent = Me.btn_cetak_nota
        Me.btn_cetak_nota.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cetak_nota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cetak_nota.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cetak_nota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cetak_nota.DisabledState.Parent = Me.btn_cetak_nota
        Me.btn_cetak_nota.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_cetak_nota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak_nota.ForeColor = System.Drawing.Color.White
        Me.btn_cetak_nota.HoverState.Parent = Me.btn_cetak_nota
        Me.btn_cetak_nota.Location = New System.Drawing.Point(463, 629)
        Me.btn_cetak_nota.Name = "btn_cetak_nota"
        Me.btn_cetak_nota.ShadowDecoration.Parent = Me.btn_cetak_nota
        Me.btn_cetak_nota.Size = New System.Drawing.Size(106, 35)
        Me.btn_cetak_nota.TabIndex = 13
        Me.btn_cetak_nota.Text = "Cetak Nota"
        '
        'FormBKeluarContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 680)
        Me.Controls.Add(Me.btn_cetak_nota)
        Me.Controls.Add(Me.BTN_Refreshtbl)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_TambahBarang)
        Me.Controls.Add(Me.BTN_EditBarang)
        Me.Controls.Add(Me.TB_Search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1030, 680)
        Me.MinimumSize = New System.Drawing.Size(1030, 680)
        Me.Name = "FormBKeluarContent"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_TambahBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_EditBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Refreshtbl As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_cetak_nota As Guna.UI2.WinForms.Guna2Button
End Class
