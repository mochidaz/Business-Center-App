<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarBarangUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_Stok = New System.Windows.Forms.Label()
        Me.LBL_Harual = New System.Windows.Forms.Label()
        Me.LBL_Harbel = New System.Windows.Forms.Label()
        Me.LBL_Nama = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.LBL_Stok)
        Me.Guna2Panel4.Controls.Add(Me.LBL_Harual)
        Me.Guna2Panel4.Controls.Add(Me.LBL_Harbel)
        Me.Guna2Panel4.Controls.Add(Me.LBL_Nama)
        Me.Guna2Panel4.Controls.Add(Me.LBL_ID)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1030, 60)
        Me.Guna2Panel4.TabIndex = 7
        '
        'LBL_Stok
        '
        Me.LBL_Stok.AutoSize = True
        Me.LBL_Stok.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Stok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LBL_Stok.Location = New System.Drawing.Point(892, 20)
        Me.LBL_Stok.Name = "LBL_Stok"
        Me.LBL_Stok.Size = New System.Drawing.Size(39, 17)
        Me.LBL_Stok.TabIndex = 0
        Me.LBL_Stok.Text = "STOK"
        '
        'LBL_Harual
        '
        Me.LBL_Harual.AutoSize = True
        Me.LBL_Harual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Harual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LBL_Harual.Location = New System.Drawing.Point(674, 20)
        Me.LBL_Harual.Name = "LBL_Harual"
        Me.LBL_Harual.Size = New System.Drawing.Size(82, 17)
        Me.LBL_Harual.TabIndex = 0
        Me.LBL_Harual.Text = "HARGA JUAL"
        '
        'LBL_Harbel
        '
        Me.LBL_Harbel.AutoSize = True
        Me.LBL_Harbel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Harbel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LBL_Harbel.Location = New System.Drawing.Point(474, 20)
        Me.LBL_Harbel.Name = "LBL_Harbel"
        Me.LBL_Harbel.Size = New System.Drawing.Size(77, 17)
        Me.LBL_Harbel.TabIndex = 0
        Me.LBL_Harbel.Text = "HARGA BELI"
        '
        'LBL_Nama
        '
        Me.LBL_Nama.AutoSize = True
        Me.LBL_Nama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LBL_Nama.Location = New System.Drawing.Point(194, 20)
        Me.LBL_Nama.Name = "LBL_Nama"
        Me.LBL_Nama.Size = New System.Drawing.Size(46, 17)
        Me.LBL_Nama.TabIndex = 0
        Me.LBL_Nama.Text = "NAMA"
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LBL_ID.Location = New System.Drawing.Point(94, 20)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(20, 17)
        Me.LBL_ID.TabIndex = 0
        Me.LBL_ID.Text = "ID"
        '
        'DaftarBarangUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Name = "DaftarBarangUserControl"
        Me.Size = New System.Drawing.Size(1030, 60)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LBL_Stok As Label
    Friend WithEvents LBL_Harual As Label
    Friend WithEvents LBL_Harbel As Label
    Friend WithEvents LBL_Nama As Label
    Friend WithEvents LBL_ID As Label
End Class
