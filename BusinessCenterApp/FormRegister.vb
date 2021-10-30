Public Class FormRegister
    Dim connect = New AuthController

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim cp As CreateParams = MyBase.CreateParams

            cp.ExStyle = cp.ExStyle Or 33554432

            Return cp

        End Get

    End Property

    Private Sub BTN_SIGNUP_Click(sender As Object, e As EventArgs) Handles BTN_SIGNUP.Click
        If emptyTextBox(Me) = False Then
            Dim reg = connect.AuthRegister(TB_FULLNAME.Text, TB_UNAMEREG.Text, TB_PASSREG.Text, TB_CNFRPASS.Text)
            If reg = Status.Success Then
                MessageBox.Show("Anda berhasil terdaftar, harap untuk melakukan sign in!!")
                BusinessCenter.ClearPanel(Me)
                BusinessCenter.LoginShow()
            ElseIf reg = Status.UsernameExistInvalid Then
                MessageBox.Show("Username tidak valid atau sudah terdaftar!!")
                TB_PASSREG.Text = ""
                TB_CNFRPASS.Text = ""
            ElseIf reg = Status.DataIncomplete Then
                MessageBox.Show("Isi semua kolom form!!")
            ElseIf reg = Status.PasswordDoesNotMatch Then
                MessageBox.Show("Password tidak cocok!!")
            End If
        End If

    End Sub

    Private Sub LNK_SIGNIN_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNK_SIGNIN.LinkClicked
        BusinessCenter.ClearPanel(Me)
        BusinessCenter.LoginShow()
    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBox(Me)
        BTN_Showpw.Visible = False
        BTN_ShowCnfrmPw.Visible = False
    End Sub

    Private Sub TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_UNAMEREG.KeyPress, TB_PASSREG.KeyPress, TB_CNFRPASS.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_FULLNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_FULLNAME.KeyPress
        e.Handled = Not (ValidCharsWithSpaceNoNum.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub BTN_Showpw_Click(sender As Object, e As EventArgs) Handles BTN_Showpw.Click
        If TB_PASSREG.PasswordChar = "*" Then
            TB_PASSREG.PasswordChar = ""
            BTN_Showpw.Checked = True
        Else
            TB_PASSREG.PasswordChar = "*"
            BTN_Showpw.Checked = False
        End If
    End Sub

    Private Sub BTN_ShowCnfrmPw_Click(sender As Object, e As EventArgs) Handles BTN_ShowCnfrmPw.Click
        If TB_CNFRPASS.PasswordChar = "*" Then
            TB_CNFRPASS.PasswordChar = ""
            BTN_ShowCnfrmPw.Checked = True
        Else
            TB_CNFRPASS.PasswordChar = "*"
            BTN_ShowCnfrmPw.Checked = False
        End If
    End Sub

    Private Sub TB_PASSREG_TextChanged(sender As Object, e As EventArgs) Handles TB_PASSREG.TextChanged
        If TB_PASSREG.Text.Length > 0 Then
            BTN_Showpw.Visible = True
        Else
            BTN_Showpw.Visible = False
        End If
    End Sub

    Private Sub TB_CNFRPASS_TextChanged(sender As Object, e As EventArgs) Handles TB_CNFRPASS.TextChanged
        If TB_CNFRPASS.Text.Length > 0 Then
            BTN_ShowCnfrmPw.Visible = True
        Else
            BTN_ShowCnfrmPw.Visible = False
        End If
    End Sub

    Private Sub BTN_Showpw_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Showpw.MouseEnter
        BTN_Showpw.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BTN_Showpw_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Showpw.MouseLeave
        BTN_Showpw.BackColor = Color.White
    End Sub

    Private Sub BTN_ShowCnfrmPw_MouseEnter(sender As Object, e As EventArgs) Handles BTN_ShowCnfrmPw.MouseEnter
        BTN_ShowCnfrmPw.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BTN_ShowCnfrmPw_MouseLeave(sender As Object, e As EventArgs) Handles BTN_ShowCnfrmPw.MouseLeave
        BTN_ShowCnfrmPw.BackColor = Color.White
    End Sub

End Class