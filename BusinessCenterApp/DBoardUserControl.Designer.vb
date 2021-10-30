<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBoardUserControl
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
        Me.PNL = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_TGL = New System.Windows.Forms.Label()
        Me.LBL_JML = New System.Windows.Forms.Label()
        Me.LBL_NAMA = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.White
        Me.PNL.Controls.Add(Me.LBL_TGL)
        Me.PNL.Controls.Add(Me.LBL_JML)
        Me.PNL.Controls.Add(Me.LBL_NAMA)
        Me.PNL.Controls.Add(Me.LBL_ID)
        Me.PNL.CustomBorderColor = System.Drawing.SystemColors.Control
        Me.PNL.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.ShadowDecoration.Parent = Me.PNL
        Me.PNL.Size = New System.Drawing.Size(487, 40)
        Me.PNL.TabIndex = 2
        '
        'LBL_TGL
        '
        Me.LBL_TGL.AutoSize = True
        Me.LBL_TGL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TGL.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_TGL.Location = New System.Drawing.Point(355, 11)
        Me.LBL_TGL.Name = "LBL_TGL"
        Me.LBL_TGL.Size = New System.Drawing.Size(66, 17)
        Me.LBL_TGL.TabIndex = 3
        Me.LBL_TGL.Text = "TANGGAL"
        '
        'LBL_JML
        '
        Me.LBL_JML.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_JML.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_JML.Location = New System.Drawing.Point(239, 11)
        Me.LBL_JML.Name = "LBL_JML"
        Me.LBL_JML.Size = New System.Drawing.Size(59, 17)
        Me.LBL_JML.TabIndex = 2
        Me.LBL_JML.Text = "JUMLAH"
        Me.LBL_JML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_NAMA
        '
        Me.LBL_NAMA.AutoSize = True
        Me.LBL_NAMA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NAMA.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_NAMA.Location = New System.Drawing.Point(88, 11)
        Me.LBL_NAMA.Name = "LBL_NAMA"
        Me.LBL_NAMA.Size = New System.Drawing.Size(48, 17)
        Me.LBL_NAMA.TabIndex = 1
        Me.LBL_NAMA.Text = "NAMA"
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ID.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_ID.Location = New System.Drawing.Point(12, 11)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(21, 17)
        Me.LBL_ID.TabIndex = 0
        Me.LBL_ID.Text = "ID"
        '
        'DBoardUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PNL)
        Me.Name = "DBoardUserControl"
        Me.Size = New System.Drawing.Size(487, 40)
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LBL_TGL As Label
    Friend WithEvents LBL_JML As Label
    Friend WithEvents LBL_NAMA As Label
    Friend WithEvents LBL_ID As Label
End Class
