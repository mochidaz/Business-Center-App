Public Class FormChangePassword
    Dim connect As New AuthController

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormChangePassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearTextBox(Me)
        kondisiawalshwpw()
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        If TB_CurrentPW.Text.Length > 0 And TB_NewPW.Text.Length > 0 And TB_ConfirmNpw.Text.Length > 0 Then
            Dim log = connect.ChangePassword(vUid, TB_CurrentPW.Text, TB_NewPW.Text, TB_ConfirmNpw.Text)
            If log = Status.Success Then
                MessageBox.Show("Berhasil mengganti Password, Silahkan melakukan sign in kembali")
                Me.Close()
                BusinessCenter.ClearPanel(Me)
                BusinessCenter.LoginShow()
            ElseIf log = Status.DataIncomplete Then
                MessageBox.Show("Error")
            ElseIf log = Status.WrongCurrentPassword Then
                MessageBox.Show("Password salah")
            ElseIf log = Status.PasswordDoesNotMatch Then
                MessageBox.Show("Password baru tidak cocok")
            End If
        Else
            MessageBox.Show("Harap isi form apabila ingin mengganti password!!")
        End If

    End Sub

    Private Sub TB_CurrentPW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_CurrentPW.KeyPress, TB_NewPW.KeyPress, TB_ConfirmNpw.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_CurrentPW_TextChanged(sender As Object, e As EventArgs) Handles TB_CurrentPW.TextChanged
        If TB_CurrentPW.Text.Length > 0 Then
            BTN_Showcpw.Visible = True
        Else
            BTN_Showcpw.Visible = False
        End If
    End Sub

    Private Sub TB_NewPW_TextChanged(sender As Object, e As EventArgs) Handles TB_NewPW.TextChanged
        If TB_NewPW.Text.Length > 0 Then
            BTN_Shownpw.Visible = True
        Else
            BTN_Shownpw.Visible = False
        End If
    End Sub

    Private Sub TB_ConfirmNpw_TextChanged(sender As Object, e As EventArgs) Handles TB_ConfirmNpw.TextChanged
        If TB_ConfirmNpw.Text.Length > 0 Then
            BTN_Showcnfnpw.Visible = True
        Else
            BTN_Showcnfnpw.Visible = False
        End If
    End Sub

    Private Sub BTN_Showcpw_Click(sender As Object, e As EventArgs) Handles BTN_Showcpw.Click
        If TB_CurrentPW.PasswordChar = "*" Then
            TB_CurrentPW.PasswordChar = ""
            BTN_Showcpw.Checked = True
        Else
            TB_CurrentPW.PasswordChar = "*"
            BTN_Showcpw.Checked = False
        End If
    End Sub

    Private Sub BTN_Shownpw_Click(sender As Object, e As EventArgs) Handles BTN_Shownpw.Click
        If TB_NewPW.PasswordChar = "*" Then
            TB_NewPW.PasswordChar = ""
            BTN_Shownpw.Checked = True
        Else
            TB_NewPW.PasswordChar = "*"
            BTN_Shownpw.Checked = False
        End If
    End Sub

    Private Sub BTN_Showcnfnpw_Click(sender As Object, e As EventArgs) Handles BTN_Showcnfnpw.Click
        If TB_ConfirmNpw.PasswordChar = "*" Then
            TB_ConfirmNpw.PasswordChar = ""
            BTN_Showcnfnpw.Checked = True
        Else
            TB_ConfirmNpw.PasswordChar = "*"
            BTN_Showcnfnpw.Checked = False
        End If
    End Sub

    Sub kondisiawalshwpw()
        TB_CurrentPW.PasswordChar = "*"
        TB_NewPW.PasswordChar = "*"
        TB_ConfirmNpw.PasswordChar = "*"
        BTN_Showcpw.Checked = False
        BTN_Shownpw.Checked = False
        BTN_Showcnfnpw.Checked = False
    End Sub
End Class