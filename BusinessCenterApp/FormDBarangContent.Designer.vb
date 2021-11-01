<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDBarangContent_simple_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDBarangContent_simple_))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_TambahBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_EditBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TB_Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Refreshtbl = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Daftar Barang"
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
        Me.BTN_TambahBarang.TabIndex = 4
        Me.BTN_TambahBarang.Text = "+ Tambah Barang"
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
        Me.BTN_EditBarang.Location = New System.Drawing.Point(675, 20)
        Me.BTN_EditBarang.Name = "BTN_EditBarang"
        Me.BTN_EditBarang.ShadowDecoration.Parent = Me.BTN_EditBarang
        Me.BTN_EditBarang.Size = New System.Drawing.Size(102, 35)
        Me.BTN_EditBarang.TabIndex = 5
        Me.BTN_EditBarang.Text = "Edit Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(948, 529)
        Me.DataGridView1.TabIndex = 6
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
        Me.TB_Search.TabIndex = 7
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
        Me.BTN_Refreshtbl.TabIndex = 8
        '
        'FormDBarangContent_simple_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 680)
        Me.Controls.Add(Me.BTN_Refreshtbl)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_TambahBarang)
        Me.Controls.Add(Me.BTN_EditBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1030, 680)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1030, 680)
        Me.Name = "FormDBarangContent_simple_"
        Me.Text = "DBarangContent_simple_"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_TambahBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_EditBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TB_Search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Refreshtbl As Guna.UI2.WinForms.Guna2ImageButton
End Class
