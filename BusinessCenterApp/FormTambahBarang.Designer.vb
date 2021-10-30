<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahBarang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_HargaJual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB__HargaBeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_NamaBrg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_Stok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Simpan = New System.Windows.Forms.Button()
        Me.BTN_Batal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga Jual"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Harga Beli"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Barang"
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
        Me.TB_HargaJual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaJual.FocusedState.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_HargaJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_HargaJual.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_HargaJual.HoverState.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Location = New System.Drawing.Point(165, 91)
        Me.TB_HargaJual.MaxLength = 30
        Me.TB_HargaJual.Name = "TB_HargaJual"
        Me.TB_HargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_HargaJual.PlaceholderText = ""
        Me.TB_HargaJual.SelectedText = ""
        Me.TB_HargaJual.ShadowDecoration.Parent = Me.TB_HargaJual
        Me.TB_HargaJual.Size = New System.Drawing.Size(241, 23)
        Me.TB_HargaJual.TabIndex = 10
        Me.TB_HargaJual.TabStop = False
        '
        'TB__HargaBeli
        '
        Me.TB__HargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB__HargaBeli.DefaultText = ""
        Me.TB__HargaBeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB__HargaBeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB__HargaBeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB__HargaBeli.DisabledState.Parent = Me.TB__HargaBeli
        Me.TB__HargaBeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB__HargaBeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB__HargaBeli.FocusedState.Parent = Me.TB__HargaBeli
        Me.TB__HargaBeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB__HargaBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB__HargaBeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB__HargaBeli.HoverState.Parent = Me.TB__HargaBeli
        Me.TB__HargaBeli.Location = New System.Drawing.Point(165, 59)
        Me.TB__HargaBeli.MaxLength = 30
        Me.TB__HargaBeli.Name = "TB__HargaBeli"
        Me.TB__HargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB__HargaBeli.PlaceholderText = ""
        Me.TB__HargaBeli.SelectedText = ""
        Me.TB__HargaBeli.ShadowDecoration.Parent = Me.TB__HargaBeli
        Me.TB__HargaBeli.Size = New System.Drawing.Size(241, 23)
        Me.TB__HargaBeli.TabIndex = 9
        Me.TB__HargaBeli.TabStop = False
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
        Me.TB_NamaBrg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NamaBrg.FocusedState.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_NamaBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_NamaBrg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NamaBrg.HoverState.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Location = New System.Drawing.Point(165, 27)
        Me.TB_NamaBrg.MaxLength = 50
        Me.TB_NamaBrg.Name = "TB_NamaBrg"
        Me.TB_NamaBrg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_NamaBrg.PlaceholderText = ""
        Me.TB_NamaBrg.SelectedText = ""
        Me.TB_NamaBrg.ShadowDecoration.Parent = Me.TB_NamaBrg
        Me.TB_NamaBrg.Size = New System.Drawing.Size(241, 23)
        Me.TB_NamaBrg.TabIndex = 8
        Me.TB_NamaBrg.TabStop = False
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
        Me.TB_Stok.Location = New System.Drawing.Point(165, 123)
        Me.TB_Stok.MaxLength = 6
        Me.TB_Stok.Name = "TB_Stok"
        Me.TB_Stok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_Stok.PlaceholderText = ""
        Me.TB_Stok.SelectedText = ""
        Me.TB_Stok.ShadowDecoration.Parent = Me.TB_Stok
        Me.TB_Stok.Size = New System.Drawing.Size(241, 23)
        Me.TB_Stok.TabIndex = 11
        Me.TB_Stok.TabStop = False
        '
        'BTN_Simpan
        '
        Me.BTN_Simpan.Location = New System.Drawing.Point(196, 184)
        Me.BTN_Simpan.Name = "BTN_Simpan"
        Me.BTN_Simpan.Size = New System.Drawing.Size(93, 33)
        Me.BTN_Simpan.TabIndex = 12
        Me.BTN_Simpan.Text = "Simpan"
        Me.BTN_Simpan.UseVisualStyleBackColor = True
        '
        'BTN_Batal
        '
        Me.BTN_Batal.Location = New System.Drawing.Point(313, 184)
        Me.BTN_Batal.Name = "BTN_Batal"
        Me.BTN_Batal.Size = New System.Drawing.Size(93, 33)
        Me.BTN_Batal.TabIndex = 13
        Me.BTN_Batal.Text = "Batal"
        Me.BTN_Batal.UseVisualStyleBackColor = True
        '
        'FormTambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.BTN_Batal)
        Me.Controls.Add(Me.BTN_Simpan)
        Me.Controls.Add(Me.TB_Stok)
        Me.Controls.Add(Me.TB_HargaJual)
        Me.Controls.Add(Me.TB__HargaBeli)
        Me.Controls.Add(Me.TB_NamaBrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTambahBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Barang"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_HargaJual As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB__HargaBeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_NamaBrg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_Stok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Simpan As Button
    Friend WithEvents BTN_Batal As Button
End Class
