<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.TB_UNAMELOG = New System.Windows.Forms.TextBox()
        Me.TB_PASSLOG = New System.Windows.Forms.TextBox()
        Me.BTN_SIGNIN = New System.Windows.Forms.Button()
        Me.LNK_SIGNUP = New System.Windows.Forms.LinkLabel()
        Me.BTN_Showpw = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'TB_UNAMELOG
        '
        Me.TB_UNAMELOG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_UNAMELOG.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TB_UNAMELOG.Font = New System.Drawing.Font("Segoe UI Historic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UNAMELOG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_UNAMELOG.Location = New System.Drawing.Point(926, 269)
        Me.TB_UNAMELOG.Name = "TB_UNAMELOG"
        Me.TB_UNAMELOG.Size = New System.Drawing.Size(247, 23)
        Me.TB_UNAMELOG.TabIndex = 2
        '
        'TB_PASSLOG
        '
        Me.TB_PASSLOG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_PASSLOG.Font = New System.Drawing.Font("Segoe UI Historic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSLOG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TB_PASSLOG.Location = New System.Drawing.Point(926, 375)
        Me.TB_PASSLOG.Name = "TB_PASSLOG"
        Me.TB_PASSLOG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_PASSLOG.Size = New System.Drawing.Size(222, 23)
        Me.TB_PASSLOG.TabIndex = 3
        '
        'BTN_SIGNIN
        '
        Me.BTN_SIGNIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SIGNIN.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SIGNIN.Location = New System.Drawing.Point(943, 479)
        Me.BTN_SIGNIN.Name = "BTN_SIGNIN"
        Me.BTN_SIGNIN.Size = New System.Drawing.Size(189, 40)
        Me.BTN_SIGNIN.TabIndex = 4
        Me.BTN_SIGNIN.Text = "Sign In"
        Me.BTN_SIGNIN.UseVisualStyleBackColor = True
        '
        'LNK_SIGNUP
        '
        Me.LNK_SIGNUP.AutoSize = True
        Me.LNK_SIGNUP.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LNK_SIGNUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LNK_SIGNUP.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNK_SIGNUP.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LNK_SIGNUP.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LNK_SIGNUP.Location = New System.Drawing.Point(1109, 549)
        Me.LNK_SIGNUP.Name = "LNK_SIGNUP"
        Me.LNK_SIGNUP.Size = New System.Drawing.Size(85, 28)
        Me.LNK_SIGNUP.TabIndex = 6
        Me.LNK_SIGNUP.TabStop = True
        Me.LNK_SIGNUP.Text = "Sign Up"
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
        Me.BTN_Showpw.Location = New System.Drawing.Point(1145, 372)
        Me.BTN_Showpw.Name = "BTN_Showpw"
        Me.BTN_Showpw.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.BTN_Showpw.PressedState.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.ShadowDecoration.Parent = Me.BTN_Showpw
        Me.BTN_Showpw.Size = New System.Drawing.Size(30, 30)
        Me.BTN_Showpw.TabIndex = 7
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.BTN_Showpw)
        Me.Controls.Add(Me.LNK_SIGNUP)
        Me.Controls.Add(Me.BTN_SIGNIN)
        Me.Controls.Add(Me.TB_PASSLOG)
        Me.Controls.Add(Me.TB_UNAMELOG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "FormLogin"
        Me.Text = "Business Center App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_UNAMELOG As TextBox
    Friend WithEvents TB_PASSLOG As TextBox
    Friend WithEvents BTN_SIGNIN As Button
    Friend WithEvents LNK_SIGNUP As LinkLabel
    Friend WithEvents BTN_Showpw As Guna.UI2.WinForms.Guna2ImageButton
End Class
