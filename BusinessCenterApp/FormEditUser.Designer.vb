<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_UID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_FNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_UNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_STATUS = New System.Windows.Forms.ComboBox()
        Me.BTN_OKUID = New System.Windows.Forms.Button()
        Me.BTN_EDITFNM = New System.Windows.Forms.Button()
        Me.BTN_EDITUNAME = New System.Windows.Forms.Button()
        Me.BTN_EDITSTATUS = New System.Windows.Forms.Button()
        Me.BTN_DELETUSER = New System.Windows.Forms.Button()
        Me.BTN_SIMPAN = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UID"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fullname"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'TB_UID
        '
        Me.TB_UID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_UID.DefaultText = ""
        Me.TB_UID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_UID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_UID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_UID.DisabledState.Parent = Me.TB_UID
        Me.TB_UID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_UID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_UID.FocusedState.Parent = Me.TB_UID
        Me.TB_UID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_UID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_UID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_UID.HoverState.Parent = Me.TB_UID
        Me.TB_UID.Location = New System.Drawing.Point(169, 28)
        Me.TB_UID.MaxLength = 4
        Me.TB_UID.Name = "TB_UID"
        Me.TB_UID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_UID.PlaceholderText = ""
        Me.TB_UID.SelectedText = ""
        Me.TB_UID.ShadowDecoration.Parent = Me.TB_UID
        Me.TB_UID.Size = New System.Drawing.Size(241, 23)
        Me.TB_UID.TabIndex = 1
        Me.TB_UID.TabStop = False
        '
        'TB_FNAME
        '
        Me.TB_FNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_FNAME.DefaultText = ""
        Me.TB_FNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_FNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_FNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FNAME.DisabledState.Parent = Me.TB_FNAME
        Me.TB_FNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FNAME.FocusedState.Parent = Me.TB_FNAME
        Me.TB_FNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_FNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_FNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FNAME.HoverState.Parent = Me.TB_FNAME
        Me.TB_FNAME.Location = New System.Drawing.Point(169, 60)
        Me.TB_FNAME.MaxLength = 50
        Me.TB_FNAME.Name = "TB_FNAME"
        Me.TB_FNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_FNAME.PlaceholderText = ""
        Me.TB_FNAME.SelectedText = ""
        Me.TB_FNAME.ShadowDecoration.Parent = Me.TB_FNAME
        Me.TB_FNAME.Size = New System.Drawing.Size(241, 23)
        Me.TB_FNAME.TabIndex = 2
        Me.TB_FNAME.TabStop = False
        '
        'TB_UNAME
        '
        Me.TB_UNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_UNAME.DefaultText = ""
        Me.TB_UNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_UNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_UNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_UNAME.DisabledState.Parent = Me.TB_UNAME
        Me.TB_UNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_UNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_UNAME.FocusedState.Parent = Me.TB_UNAME
        Me.TB_UNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_UNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_UNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_UNAME.HoverState.Parent = Me.TB_UNAME
        Me.TB_UNAME.Location = New System.Drawing.Point(169, 92)
        Me.TB_UNAME.MaxLength = 50
        Me.TB_UNAME.Name = "TB_UNAME"
        Me.TB_UNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_UNAME.PlaceholderText = ""
        Me.TB_UNAME.SelectedText = ""
        Me.TB_UNAME.ShadowDecoration.Parent = Me.TB_UNAME
        Me.TB_UNAME.Size = New System.Drawing.Size(241, 23)
        Me.TB_UNAME.TabIndex = 3
        Me.TB_UNAME.TabStop = False
        '
        'CB_STATUS
        '
        Me.CB_STATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_STATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_STATUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_STATUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CB_STATUS.FormattingEnabled = True
        Me.CB_STATUS.Items.AddRange(New Object() {"admin", "user"})
        Me.CB_STATUS.Location = New System.Drawing.Point(169, 124)
        Me.CB_STATUS.Name = "CB_STATUS"
        Me.CB_STATUS.Size = New System.Drawing.Size(241, 23)
        Me.CB_STATUS.TabIndex = 4
        Me.CB_STATUS.TabStop = False
        '
        'BTN_OKUID
        '
        Me.BTN_OKUID.Location = New System.Drawing.Point(416, 28)
        Me.BTN_OKUID.Name = "BTN_OKUID"
        Me.BTN_OKUID.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OKUID.TabIndex = 5
        Me.BTN_OKUID.TabStop = False
        Me.BTN_OKUID.Text = "OK"
        Me.BTN_OKUID.UseVisualStyleBackColor = True
        '
        'BTN_EDITFNM
        '
        Me.BTN_EDITFNM.Location = New System.Drawing.Point(416, 60)
        Me.BTN_EDITFNM.Name = "BTN_EDITFNM"
        Me.BTN_EDITFNM.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITFNM.TabIndex = 6
        Me.BTN_EDITFNM.TabStop = False
        Me.BTN_EDITFNM.Text = "Edit"
        Me.BTN_EDITFNM.UseVisualStyleBackColor = True
        '
        'BTN_EDITUNAME
        '
        Me.BTN_EDITUNAME.Location = New System.Drawing.Point(416, 92)
        Me.BTN_EDITUNAME.Name = "BTN_EDITUNAME"
        Me.BTN_EDITUNAME.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITUNAME.TabIndex = 7
        Me.BTN_EDITUNAME.TabStop = False
        Me.BTN_EDITUNAME.Text = "Edit"
        Me.BTN_EDITUNAME.UseVisualStyleBackColor = True
        '
        'BTN_EDITSTATUS
        '
        Me.BTN_EDITSTATUS.Location = New System.Drawing.Point(416, 124)
        Me.BTN_EDITSTATUS.Name = "BTN_EDITSTATUS"
        Me.BTN_EDITSTATUS.Size = New System.Drawing.Size(75, 23)
        Me.BTN_EDITSTATUS.TabIndex = 8
        Me.BTN_EDITSTATUS.TabStop = False
        Me.BTN_EDITSTATUS.Text = "Edit"
        Me.BTN_EDITSTATUS.UseVisualStyleBackColor = True
        '
        'BTN_DELETUSER
        '
        Me.BTN_DELETUSER.Location = New System.Drawing.Point(24, 187)
        Me.BTN_DELETUSER.Name = "BTN_DELETUSER"
        Me.BTN_DELETUSER.Size = New System.Drawing.Size(112, 27)
        Me.BTN_DELETUSER.TabIndex = 10
        Me.BTN_DELETUSER.TabStop = False
        Me.BTN_DELETUSER.Text = "Delete User"
        Me.BTN_DELETUSER.UseVisualStyleBackColor = True
        '
        'BTN_SIMPAN
        '
        Me.BTN_SIMPAN.Location = New System.Drawing.Point(379, 187)
        Me.BTN_SIMPAN.Name = "BTN_SIMPAN"
        Me.BTN_SIMPAN.Size = New System.Drawing.Size(112, 27)
        Me.BTN_SIMPAN.TabIndex = 9
        Me.BTN_SIMPAN.TabStop = False
        Me.BTN_SIMPAN.Text = "Simpan"
        Me.BTN_SIMPAN.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(24, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(467, 243)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'FormEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(516, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_SIMPAN)
        Me.Controls.Add(Me.BTN_DELETUSER)
        Me.Controls.Add(Me.BTN_EDITSTATUS)
        Me.Controls.Add(Me.BTN_EDITUNAME)
        Me.Controls.Add(Me.BTN_EDITFNM)
        Me.Controls.Add(Me.BTN_OKUID)
        Me.Controls.Add(Me.CB_STATUS)
        Me.Controls.Add(Me.TB_UNAME)
        Me.Controls.Add(Me.TB_FNAME)
        Me.Controls.Add(Me.TB_UID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(532, 545)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(532, 545)
        Me.Name = "FormEditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_UID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_FNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_UNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CB_STATUS As ComboBox
    Friend WithEvents BTN_OKUID As Button
    Friend WithEvents BTN_EDITFNM As Button
    Friend WithEvents BTN_EDITUNAME As Button
    Friend WithEvents BTN_EDITSTATUS As Button
    Friend WithEvents BTN_DELETUSER As Button
    Friend WithEvents BTN_SIMPAN As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
