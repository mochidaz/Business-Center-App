<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_CurrentPW = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_NewPW = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Cencel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_ConfirmNpw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Showcpw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_Shownpw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_Showcnfnpw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Password           :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password                :"
        '
        'TB_CurrentPW
        '
        Me.TB_CurrentPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_CurrentPW.DefaultText = ""
        Me.TB_CurrentPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_CurrentPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_CurrentPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurrentPW.DisabledState.Parent = Me.TB_CurrentPW
        Me.TB_CurrentPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_CurrentPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurrentPW.FocusedState.Parent = Me.TB_CurrentPW
        Me.TB_CurrentPW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_CurrentPW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_CurrentPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_CurrentPW.HoverState.Parent = Me.TB_CurrentPW
        Me.TB_CurrentPW.Location = New System.Drawing.Point(156, 37)
        Me.TB_CurrentPW.MaxLength = 30
        Me.TB_CurrentPW.Name = "TB_CurrentPW"
        Me.TB_CurrentPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_CurrentPW.PlaceholderText = ""
        Me.TB_CurrentPW.SelectedText = ""
        Me.TB_CurrentPW.ShadowDecoration.Parent = Me.TB_CurrentPW
        Me.TB_CurrentPW.Size = New System.Drawing.Size(200, 25)
        Me.TB_CurrentPW.TabIndex = 3
        '
        'TB_NewPW
        '
        Me.TB_NewPW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NewPW.DefaultText = ""
        Me.TB_NewPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_NewPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_NewPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NewPW.DisabledState.Parent = Me.TB_NewPW
        Me.TB_NewPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_NewPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NewPW.FocusedState.Parent = Me.TB_NewPW
        Me.TB_NewPW.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_NewPW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_NewPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_NewPW.HoverState.Parent = Me.TB_NewPW
        Me.TB_NewPW.Location = New System.Drawing.Point(156, 81)
        Me.TB_NewPW.MaxLength = 30
        Me.TB_NewPW.Name = "TB_NewPW"
        Me.TB_NewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_NewPW.PlaceholderText = ""
        Me.TB_NewPW.SelectedText = ""
        Me.TB_NewPW.ShadowDecoration.Parent = Me.TB_NewPW
        Me.TB_NewPW.Size = New System.Drawing.Size(200, 25)
        Me.TB_NewPW.TabIndex = 4
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(165, 185)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(81, 30)
        Me.BTN_Save.TabIndex = 5
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Cencel
        '
        Me.BTN_Cencel.Location = New System.Drawing.Point(262, 185)
        Me.BTN_Cencel.Name = "BTN_Cencel"
        Me.BTN_Cencel.Size = New System.Drawing.Size(81, 30)
        Me.BTN_Cencel.TabIndex = 5
        Me.BTN_Cencel.Text = "Cencel"
        Me.BTN_Cencel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm New Password :"
        '
        'TB_ConfirmNpw
        '
        Me.TB_ConfirmNpw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_ConfirmNpw.DefaultText = ""
        Me.TB_ConfirmNpw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_ConfirmNpw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_ConfirmNpw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_ConfirmNpw.DisabledState.Parent = Me.TB_ConfirmNpw
        Me.TB_ConfirmNpw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_ConfirmNpw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_ConfirmNpw.FocusedState.Parent = Me.TB_ConfirmNpw
        Me.TB_ConfirmNpw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_ConfirmNpw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_ConfirmNpw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_ConfirmNpw.HoverState.Parent = Me.TB_ConfirmNpw
        Me.TB_ConfirmNpw.Location = New System.Drawing.Point(156, 125)
        Me.TB_ConfirmNpw.MaxLength = 30
        Me.TB_ConfirmNpw.Name = "TB_ConfirmNpw"
        Me.TB_ConfirmNpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_ConfirmNpw.PlaceholderText = ""
        Me.TB_ConfirmNpw.SelectedText = ""
        Me.TB_ConfirmNpw.ShadowDecoration.Parent = Me.TB_ConfirmNpw
        Me.TB_ConfirmNpw.Size = New System.Drawing.Size(200, 25)
        Me.TB_ConfirmNpw.TabIndex = 4
        '
        'BTN_Showcpw
        '
        Me.BTN_Showcpw.BackColor = System.Drawing.Color.White
        Me.BTN_Showcpw.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTN_Showcpw.CheckedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcpw.CheckedState.Parent = Me.BTN_Showcpw
        Me.BTN_Showcpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Showcpw.HoverState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcpw.HoverState.Parent = Me.BTN_Showcpw
        Me.BTN_Showcpw.Image = CType(resources.GetObject("BTN_Showcpw.Image"), System.Drawing.Image)
        Me.BTN_Showcpw.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Showcpw.ImageRotate = 0!
        Me.BTN_Showcpw.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcpw.Location = New System.Drawing.Point(333, 38)
        Me.BTN_Showcpw.Name = "BTN_Showcpw"
        Me.BTN_Showcpw.PressedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcpw.PressedState.Parent = Me.BTN_Showcpw
        Me.BTN_Showcpw.ShadowDecoration.Parent = Me.BTN_Showcpw
        Me.BTN_Showcpw.Size = New System.Drawing.Size(22, 22)
        Me.BTN_Showcpw.TabIndex = 8
        '
        'BTN_Shownpw
        '
        Me.BTN_Shownpw.BackColor = System.Drawing.Color.White
        Me.BTN_Shownpw.CheckedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BTN_Shownpw.CheckedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Shownpw.CheckedState.Parent = Me.BTN_Shownpw
        Me.BTN_Shownpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Shownpw.HoverState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Shownpw.HoverState.Parent = Me.BTN_Shownpw
        Me.BTN_Shownpw.Image = CType(resources.GetObject("BTN_Shownpw.Image"), System.Drawing.Image)
        Me.BTN_Shownpw.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Shownpw.ImageRotate = 0!
        Me.BTN_Shownpw.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Shownpw.Location = New System.Drawing.Point(333, 82)
        Me.BTN_Shownpw.Name = "BTN_Shownpw"
        Me.BTN_Shownpw.PressedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Shownpw.PressedState.Parent = Me.BTN_Shownpw
        Me.BTN_Shownpw.ShadowDecoration.Parent = Me.BTN_Shownpw
        Me.BTN_Shownpw.Size = New System.Drawing.Size(22, 22)
        Me.BTN_Shownpw.TabIndex = 8
        '
        'BTN_Showcnfnpw
        '
        Me.BTN_Showcnfnpw.BackColor = System.Drawing.Color.White
        Me.BTN_Showcnfnpw.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.BTN_Showcnfnpw.CheckedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcnfnpw.CheckedState.Parent = Me.BTN_Showcnfnpw
        Me.BTN_Showcnfnpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Showcnfnpw.HoverState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcnfnpw.HoverState.Parent = Me.BTN_Showcnfnpw
        Me.BTN_Showcnfnpw.Image = CType(resources.GetObject("BTN_Showcnfnpw.Image"), System.Drawing.Image)
        Me.BTN_Showcnfnpw.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Showcnfnpw.ImageRotate = 0!
        Me.BTN_Showcnfnpw.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcnfnpw.Location = New System.Drawing.Point(333, 127)
        Me.BTN_Showcnfnpw.Name = "BTN_Showcnfnpw"
        Me.BTN_Showcnfnpw.PressedState.ImageSize = New System.Drawing.Size(22, 22)
        Me.BTN_Showcnfnpw.PressedState.Parent = Me.BTN_Showcnfnpw
        Me.BTN_Showcnfnpw.ShadowDecoration.Parent = Me.BTN_Showcnfnpw
        Me.BTN_Showcnfnpw.Size = New System.Drawing.Size(22, 22)
        Me.BTN_Showcnfnpw.TabIndex = 8
        '
        'FormChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.BTN_Showcnfnpw)
        Me.Controls.Add(Me.BTN_Shownpw)
        Me.Controls.Add(Me.BTN_Showcpw)
        Me.Controls.Add(Me.BTN_Cencel)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.TB_ConfirmNpw)
        Me.Controls.Add(Me.TB_NewPW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_CurrentPW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "FormChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_CurrentPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_NewPW As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_Cencel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_ConfirmNpw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Showcpw As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_Shownpw As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_Showcnfnpw As Guna.UI2.WinForms.Guna2ImageButton
End Class
