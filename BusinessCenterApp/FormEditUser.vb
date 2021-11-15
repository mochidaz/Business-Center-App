Public Class FormEditUser
    Dim connect As New AuthController

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim cp As CreateParams = MyBase.CreateParams

            cp.ExStyle = cp.ExStyle Or 33554432

            Return cp

        End Get

    End Property

    Private Sub FormEditUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kondisiawal()
    End Sub

    Private Sub FormEditUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        kondisiawal()
    End Sub

    Private Sub FormEditUser_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, TB_UID.MouseClick, TB_FNAME.MouseClick, TB_UNAME.MouseClick,
        CB_STATUS.MouseClick, BTN_OKUID.MouseClick, BTN_EDITFNM.MouseClick, BTN_EDITUNAME.MouseClick, BTN_EDITSTATUS.MouseClick, BTN_SIMPAN.MouseClick,
        BTN_DELETUSER.MouseClick
        DataGridView1.ClearSelection()
    End Sub

    Private Sub TB_UID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_UID.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TB_FNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_FNAME.KeyPress
        e.Handled = Not (ValidCharsWithSpaceNoNum.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_UNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_UNAME.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_UID_TextChanged(sender As Object, e As EventArgs) Handles TB_UID.TextChanged
        hideBtn()
        clearTB()
        If TB_UID.Text = vUid Then
            BTN_DELETUSER.Visible = False
            BTN_EDITSTATUS.Visible = False
        Else
            BTN_DELETUSER.Visible = True
            BTN_EDITSTATUS.Visible = True
        End If
    End Sub

    Private Sub BTN_OKUID_Click(sender As Object, e As EventArgs) Handles BTN_OKUID.Click
        Label1.Focus()
        If TB_UID.Text = Nothing Then
            MessageBox.Show("Harap masukkan UID pengguna yang ingin diedit atau dihapus")
            clearTB()
            hideBtn()
        Else
            Dim log = connect.selectUser(Val(TB_UID.Text))
            If log = Status.Success Then
                TB_FNAME.Text = eUfname
                TB_UNAME.Text = eUuname
                CB_STATUS.Text = eUstatus
                showEditBtn()
                BTN_DELETUSER.Enabled = True
            Else
                MessageBox.Show("UID yang anda masukkan tidak ada / tidak terdaftar")
                clearTB()
                hideBtn()
            End If
        End If
    End Sub

    Public Sub BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles BTN_SIMPAN.Click
        If TB_FNAME.Text.Length > 0 And TB_UNAME.Text.Length > 0 Then
            Dim log = connect.updateUser(Val(TB_UID.Text), TB_FNAME.Text, TB_UNAME.Text, CB_STATUS.Text)
            If log = Status.Success Then
                MessageBox.Show("Edit user berhasil")
                connect.log(vUid, TB_UNAME.Text, DateTime.Now(), "edit", "user")
                kondisiawal()
            ElseIf log = Status.UsernameExistInvalid Then
                MessageBox.Show("Username telah tersedia harap untuk menggunakan yang lain!!")
            ElseIf log = Status.NothingChanged Then
                MessageBox.Show("Data tidak ada yang diubah")
            End If
        Else
            MessageBox.Show("Data tidak boleh kosong!!")
        End If
    End Sub

    Private Sub BTN_DELETUSER_Click(sender As Object, e As EventArgs) Handles BTN_DELETUSER.Click
        Dim log = connect.deleteUser(Val(TB_UID.Text))
        If log = Status.Success Then
            connect.log(vUid, TB_UNAME.Text, DateTime.Now(), "delete", "user")
            MessageBox.Show("Berhasil Menghapus Akun")
            kondisiawal()
        End If
    End Sub

    Private Sub BTN_EDITFNM_Click(sender As Object, e As EventArgs) Handles BTN_EDITFNM.Click
        Label2.Focus()
        If BTN_EDITFNM.Text = "Edit" Then
            BTN_EDITFNM.Text = "Cencel"
            TB_FNAME.Enabled = True
            BTN_SIMPAN.Enabled = True
            BTN_OKUID.Enabled = False
            TB_UID.Enabled = False
            BTN_DELETUSER.Enabled = False
        Else
            BTN_EDITFNM.Text = "Edit"
            TB_FNAME.Text = eUfname
            TB_FNAME.Enabled = False
            If BTN_EDITUNAME.Text = "Cencel" Or BTN_EDITSTATUS.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_UID.Enabled = True
                BTN_DELETUSER.Enabled = True
            End If
        End If
    End Sub

    Private Sub BTN_EDITUNAME_Click(sender As Object, e As EventArgs) Handles BTN_EDITUNAME.Click
        Label3.Focus()
        If BTN_EDITUNAME.Text = "Edit" Then
            BTN_EDITUNAME.Text = "Cencel"
            TB_UNAME.Enabled = True
            BTN_SIMPAN.Enabled = True
            BTN_OKUID.Enabled = False
            TB_UID.Enabled = False
            BTN_DELETUSER.Enabled = False
        Else
            BTN_EDITUNAME.Text = "Edit"
            TB_UNAME.Text = eUuname
            TB_UNAME.Enabled = False
            If BTN_EDITFNM.Text = "Cencel" Or BTN_EDITSTATUS.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_UID.Enabled = True
                BTN_DELETUSER.Enabled = True
            End If
        End If
    End Sub

    Private Sub BTN_EDITSTATUS_Click(sender As Object, e As EventArgs) Handles BTN_EDITSTATUS.Click
        Label4.Focus()
        If BTN_EDITSTATUS.Text = "Edit" Then
            BTN_EDITSTATUS.Text = "Cencel"
            CB_STATUS.Enabled = True
            BTN_SIMPAN.Enabled = True
            BTN_OKUID.Enabled = False
            TB_UID.Enabled = False
            BTN_DELETUSER.Enabled = False
        Else
            BTN_EDITSTATUS.Text = "Edit"
            CB_STATUS.Text = eUstatus
            CB_STATUS.Enabled = False
            If BTN_EDITUNAME.Text = "Cencel" Or BTN_EDITFNM.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_UID.Enabled = True
                BTN_DELETUSER.Enabled = True
            End If
        End If
    End Sub

    Private Sub kondisiawal()
        ClearValUser()
        textedit()
        hideTB()
        hideBtn()
        ClearTextBox(Me)
        showUserinfo()
        BTN_OKUID.Enabled = True
        TB_UID.Enabled = True
        DataGridView1.ClearSelection()
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub showUserinfo()
        Dim uinfo = connect.showUser
        Dim table As New DataTable
        For Each table In uinfo.tables
            DataGridView1.DataSource = table
        Next
    End Sub

    Private Sub ClearValUser()
        eUfname = vbNullString
        eUuname = vbNullString
        eUstatus = vbNullString
    End Sub

    Private Sub clearTB()
        TB_FNAME.Text = vbNullString
        TB_UNAME.Text = vbNullString
        CB_STATUS.Text = vbNullString
    End Sub

    Private Sub showEditBtn()
        BTN_EDITFNM.Enabled = True
        BTN_EDITSTATUS.Enabled = True
        BTN_EDITUNAME.Enabled = True
    End Sub

    Private Sub hideBtn()
        BTN_EDITFNM.Enabled = False
        BTN_EDITSTATUS.Enabled = False
        BTN_EDITUNAME.Enabled = False
        BTN_DELETUSER.Enabled = False
        BTN_SIMPAN.Enabled = False
    End Sub

    Private Sub hideTB()
        TB_FNAME.Enabled = False
        TB_UNAME.Enabled = False
        CB_STATUS.Enabled = False
    End Sub

    Private Sub textedit()
        BTN_EDITSTATUS.Text = "Edit"
        BTN_EDITFNM.Text = "Edit"
        BTN_EDITUNAME.Text = "Edit"
    End Sub

End Class