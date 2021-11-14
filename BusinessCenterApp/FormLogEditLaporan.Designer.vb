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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_bm = New System.Windows.Forms.DataGridView()
        Me.dgv_bk = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_bm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bk, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv_bm.Location = New System.Drawing.Point(12, 81)
        Me.dgv_bm.Name = "dgv_bm"
        Me.dgv_bm.ReadOnly = True
        Me.dgv_bm.Size = New System.Drawing.Size(492, 587)
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
        Me.dgv_bk.Location = New System.Drawing.Point(526, 81)
        Me.dgv_bk.Name = "dgv_bk"
        Me.dgv_bk.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bk.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_bk.RowHeadersWidth = 40
        Me.dgv_bk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_bk.RowTemplate.Height = 25
        Me.dgv_bk.RowTemplate.ReadOnly = True
        Me.dgv_bk.Size = New System.Drawing.Size(492, 587)
        Me.dgv_bk.TabIndex = 1
        '
        'Label1
        '
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
        'FormLogEditLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 680)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_bm As DataGridView
    Friend WithEvents dgv_bk As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
