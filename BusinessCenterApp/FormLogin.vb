Imports System.Drawing
Public Class FormLogin
    Dim connect As New AuthController

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub BTN_SIGNIN_Click(sender As Object, e As EventArgs) Handles BTN_SIGNIN.Click
        If TB_UNAMELOG.Text.Length > 0 And TB_PASSLOG.Text.Length > 0 Then
            Dim log = connect.AuthLogin(TB_UNAMELOG.Text, TB_PASSLOG.Text)
            If log = Status.Success Then
                MessageBox.Show("Login berhasil!! Selamat datang, " & fname)
                connect.log(vUid, uname, DateTime.Now(), "login", "account")
                BusinessCenter.ClearPanel(Me)
                BusinessCenter.HomeShow()
            Else
                MessageBox.Show("Username atau Password invalid!!")
            End If
        Else
            MessageBox.Show("Masukkan Username dan Password anda!!")
        End If

    End Sub

    Private Sub LNK_SIGNUP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNK_SIGNUP.LinkClicked
        BusinessCenter.ClearPanel(Me)
        BusinessCenter.RegisterShow()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBox(Me)
        BTN_Showpw.Visible = False
        connect.ClearVariable()
    End Sub

    Private Sub TB_PASSLOG_TextChanged(sender As Object, e As EventArgs) Handles TB_PASSLOG.TextChanged
        If TB_PASSLOG.Text.Length > 0 Then
            BTN_Showpw.Visible = True
        Else
            BTN_Showpw.Visible = False
        End If
    End Sub

    Private Sub TB_PASSLOG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_PASSLOG.KeyPress, TB_UNAMELOG.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub BTN_Showpw_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Showpw.MouseEnter
        BTN_Showpw.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BTN_Showpw_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Showpw.MouseLeave
        BTN_Showpw.BackColor = Color.White
    End Sub

    Private Sub BTN_Showpw_Click(sender As Object, e As EventArgs) Handles BTN_Showpw.Click
        If TB_PASSLOG.PasswordChar = "*" Then
            TB_PASSLOG.PasswordChar = ""
            BTN_Showpw.Checked = True
        Else
            TB_PASSLOG.PasswordChar = "*"
            BTN_Showpw.Checked = False
        End If
    End Sub

End Class
