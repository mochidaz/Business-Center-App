<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Me.TB_FULLNAME = New System.Windows.Forms.TextBox()
        Me.TB_UNAMEREG = New System.Windows.Forms.TextBox()
        Me.TB_PASSREG = New System.Windows.Forms.TextBox()
        Me.TB_CNFRPASS = New System.Windows.Forms.TextBox()
        Me.BTN_SIGNUP = New System.Windows.Forms.Button()
        Me.LNK_SIGNIN = New System.Windows.Forms.LinkLabel()
        Me.BTN_Showpw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_ShowCnfrmPw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'TB_FULLNAME
        '
        Me.TB_FULLNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_FULLNAME.Font = New System.Drawing.Font("Segoe UI Historic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FULLNAME.Location = New System.Drawing.Point(945, 244)
        Me.TB_FULLNAME.Name = "TB_FULLNAME"
        Me.TB_FULLNAME.Size = New System.Drawing.Size(209, 20)
        Me.TB_FULLNAME.TabIndex = 0
        '
        'TB_UNAMEREG
        '
        Me.TB_UNAMEREG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_UNAMEREG.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TB_UNAMEREG.Font = New System.Drawing.Font("Segoe UI Historic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UNAMEREG.Location = New System.Drawing.Point(945, 323)
        Me.TB_UNAMEREG.Name = "TB_UNAMEREG"
        Me.TB_UNAMEREG.Size = New System.Drawing.Size(209, 20)
        Me.TB_UNAMEREG.TabIndex = 2
        '
        'TB_PASSREG
        '
        Me.TB_PASSREG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_PASSREG.Font = New System.Drawing.Font("Segoe UI Historic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSREG.Location = New System.Drawing.Point(945, 399)
        Me.TB_PASSREG.Name = "TB_PASSREG"
        Me.TB_PASSREG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_PASSREG.Size = New System.Drawing.Size(187, 20)
        Me.TB_PASSREG.TabIndex = 3
        '
        'TB_CNFRPASS
        '
        Me.TB_CNFRPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_CNFRPASS.Font = New System.Drawing.Font("Segoe UI Historic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CNFRPASS.Location = New System.Drawing.Point(945, 475)
        Me.TB_CNFRPASS.Name = "TB_CNFRPASS"
        Me.TB_CNFRPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_CNFRPASS.Size = New System.Drawing.Size(187, 20)
        Me.TB_CNFRPASS.TabIndex = 4
        '
        'BTN_SIGNUP
        '
        Me.BTN_SIGNUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SIGNUP.Font = New System.Drawing.Font("Segoe UI Historic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SIGNUP.Location = New System.Drawing.Point(953, 552)
        Me.BTN_SIGNUP.Name = "BTN_SIGNUP"
        Me.BTN_SIGNUP.Size = New System.Drawing.Size(161, 34)
        Me.BTN_SIGNUP.TabIndex = 5
        Me.BTN_SIGNUP.Text = "Sign Up"
        Me.BTN_SIGNUP.UseVisualStyleBackColor = True
        '
        'LNK_SIGNIN
        '
        Me.LNK_SIGNIN.AutoSize = True
        Me.LNK_SIGNIN.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LNK_SIGNIN.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNK_SIGNIN.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LNK_SIGNIN.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LNK_SIGNIN.Location = New System.Drawing.Point(1077, 613)
        Me.LNK_SIGNIN.Name = "LNK_SIGNIN"
        Me.LNK_SIGNIN.Size = New System.Drawing.Size(71, 25)
        Me.LNK_SIGNIN.TabIndex = 6
        Me.LNK_SIGNIN.TabStop = True
        Me.LNK_SIGNIN.Text = "Sign In"
        Me.LNK_SIGNIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_Showpw
        '
        Me.BTN_Showpw.BackColor = System.Drawing.Color.White
        Me.BTN_Showpw.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTN_Showpw.CheckedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.CheckedState.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Showpw.HoverState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.HoverState.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.Image = CType(resources.GetObject("BTN_Showpw.Image"), System.Drawing.Image)
        Me.BTN_Showpw.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Showpw.ImageRotate = 0!
        Me.BTN_Showpw.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.Location = New System.Drawing.Point(1132, 397)
        Me.BTN_Showpw.Name = "BTN_Showpw"
        Me.BTN_Showpw.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.PressedState.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.ShadowDecoration.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.Size = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.TabIndex = 8
        '
        'BTN_ShowCnfrmPw
        '
        Me.BTN_ShowCnfrmPw.BackColor = System.Drawing.Color.White
        Me.BTN_ShowCnfrmPw.CheckedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BTN_ShowCnfrmPw.CheckedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_ShowCnfrmPw.CheckedState.Parent = Me.BTN_ShowCnfrmPw
        Me.BTN_ShowCnfrmPw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ShowCnfrmPw.HoverState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_ShowCnfrmPw.HoverState.Parent = Me.BTN_ShowCnfrmPw
        Me.BTN_ShowCnfrmPw.Image = CType(resources.GetObject("BTN_ShowCnfrmPw.Image"), System.Drawing.Image)
        Me.BTN_ShowCnfrmPw.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_ShowCnfrmPw.ImageRotate = 0!
        Me.BTN_ShowCnfrmPw.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_ShowCnfrmPw.Location = New System.Drawing.Point(1132, 474)
        Me.BTN_ShowCnfrmPw.Name = "BTN_ShowCnfrmPw"
        Me.BTN_ShowCnfrmPw.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_ShowCnfrmPw.PressedState.Parent = Me.BTN_ShowCnfrmPw
        Me.BTN_ShowCnfrmPw.ShadowDecoration.Parent = Me.BTN_ShowCnfrmPw
        Me.BTN_ShowCnfrmPw.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ShowCnfrmPw.TabIndex = 9
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.BTN_ShowCnfrmPw)
        Me.Controls.Add(Me.BTN_Showpw)
        Me.Controls.Add(Me.LNK_SIGNIN)
        Me.Controls.Add(Me.BTN_SIGNUP)
        Me.Controls.Add(Me.TB_CNFRPASS)
        Me.Controls.Add(Me.TB_PASSREG)
        Me.Controls.Add(Me.TB_UNAMEREG)
        Me.Controls.Add(Me.TB_FULLNAME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormRegister"
        Me.Text = "Form Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_FULLNAME As TextBox
    Friend WithEvents TB_UNAMEREG As TextBox
    Friend WithEvents TB_PASSREG As TextBox
    Friend WithEvents TB_CNFRPASS As TextBox
    Friend WithEvents BTN_SIGNUP As Button
    Friend WithEvents LNK_SIGNIN As LinkLabel
    Friend WithEvents BTN_Showpw As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_ShowCnfrmPw As Guna.UI2.WinForms.Guna2ImageButton
End Class
