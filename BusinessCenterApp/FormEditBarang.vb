Public Class FormEditBarang
    Dim connect As New DBBarang

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormEditBarang_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kondisiAwal()
    End Sub

    Private Sub FormEditBarang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        kondisiAwal()
    End Sub

    Private Sub TB_IDbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_IDbarang.KeyPress, TB_HBeli.KeyPress, TB_HJual.KeyPress, TB_Stok.KeyPress, TB_CurHj.KeyPress, TB_CurHb.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TB_NBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NBarang.KeyPress
        e.Handled = Not (ValidCharsWithSpaceNoNum.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_IDbarang_TextChanged(sender As Object, e As EventArgs) Handles TB_IDbarang.TextChanged
        hideBTN()
        clearTB()
    End Sub

    Private Sub TB_HBeli_TextChanged(sender As Object, e As EventArgs) Handles TB_HBeli.TextChanged
        TB_CurHb.Text = TB_HBeli.Text
    End Sub

    Private Sub TB_HJual_TextChanged(sender As Object, e As EventArgs) Handles TB_HJual.TextChanged
        TB_CurHj.Text = TB_HJual.Text
    End Sub

    Private Sub TB_CurHb_TextChanged(sender As Object, e As EventArgs) Handles TB_CurHb.TextChanged
        formatUang(TB_CurHb)
    End Sub

    Private Sub TB_CurHj_TextChanged(sender As Object, e As EventArgs) Handles TB_CurHj.TextChanged
        formatUang(TB_CurHj)
    End Sub

    Private Sub BTN_OKUID_Click(sender As Object, e As EventArgs) Handles BTN_OKUID.Click
        Label1.Focus()
        If TB_IDbarang.Text = Nothing Then
            MessageBox.Show("Harap Masukkan ID Barang yang ingin diedit atau dihapus")
            ClearTextBox(Me)
            hideBTN()
        Else
            Dim binfo = connect.selectBarang(Val(TB_IDbarang.Text))
            If binfo = Status.Success Then
                TB_NBarang.Text = eBname
                TB_HBeli.Text = eBhb
                TB_HJual.Text = eBhj
                TB_Stok.Text = eBstok
                showEditBTN()
                BTN_DELETBARANG.Enabled = True
            Else
                MessageBox.Show("ID Barang yang anda masukkan tidak ada")
                clearTB()
                hideBTN()
            End If
        End If
    End Sub

    Private Sub BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles BTN_SIMPAN.Click
        If TB_NBarang.Text.Length > 0 And TB_HBeli.Text.Length > 0 And TB_HJual.Text.Length > 0 And TB_Stok.Text.Length > 0 Then
            Dim brg = connect.EditBarang(Val(TB_IDbarang.Text), TB_NBarang.Text, TB_HBeli.Text, TB_HJual.Text, TB_Stok.Text)
            If brg = Status.Success Then
                MessageBox.Show("Edit Barang Berhasil!!")
                connect.log(vUid, TB_IDbarang.Text, DateTime.Now(), "edit", "barang")
                kondisiAwal()
                FormDBarangContent.showtblbarang()
            ElseIf brg = Status.NothingChanged Then
                MessageBox.Show("Data tidak ada yang diubah!!")
            ElseIf brg = Status.BarangExist Then
                MessageBox.Show("Barang Sudah Ada!!")
            End If
        Else
            MessageBox.Show("Data tidak boleh kosong!!")
        End If
    End Sub

    Private Sub BTN_DELETBARANG_Click(sender As Object, e As EventArgs) Handles BTN_DELETBARANG.Click
        Dim brg = connect.DeleteBarang(Val(TB_IDbarang.Text))
        If brg = Status.Success Then
            MessageBox.Show("Berhasil Menghapus Barang!!")
            connect.log(vUid, TB_IDbarang.Text, DateTime.Now(), "delete", "barang")
            kondisiAwal()
            FormDBarangContent.showtblbarang()
        End If
    End Sub

    Private Sub BTN_EDITNB_Click(sender As Object, e As EventArgs) Handles BTN_EDITNBarang.Click
        Label1.Focus()
        If BTN_EDITNBarang.Text = "Edit" Then
            BTN_EDITNBarang.Text = "Cencel"
            TB_NBarang.Enabled = True
            TB_IDbarang.Enabled = False
            BTN_SIMPAN.Enabled = True
            BTN_DELETBARANG.Enabled = False
            BTN_OKUID.Enabled = False
        Else
            BTN_EDITNBarang.Text = "Edit"
            TB_NBarang.Text = eBname
            TB_NBarang.Enabled = False
            If BTN_EDITHBeli.Text = "Cencel" Or BTN_EDITHJual.Text = "Cencel" Or BTN_EDITSTOK.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_IDbarang.Enabled = True
                BTN_DELETBARANG.Enabled = True
            End If
        End If
    End Sub

    Private Sub BTN_EDITHB_Click(sender As Object, e As EventArgs) Handles BTN_EDITHBeli.Click
        Label1.Focus()
        If BTN_EDITHBeli.Text = "Edit" Then
            BTN_EDITHBeli.Text = "Cencel"
            TB_HBeli.Enabled = True
            TB_IDbarang.Enabled = False
            BTN_SIMPAN.Enabled = True
            BTN_DELETBARANG.Enabled = False
            BTN_OKUID.Enabled = False
        Else
            BTN_EDITHBeli.Text = "Edit"
            TB_HBeli.Text = eBhb
            TB_HBeli.Enabled = False
            If BTN_EDITNBarang.Text = "Cencel" Or BTN_EDITHJual.Text = "Cencel" Or BTN_EDITSTOK.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_IDbarang.Enabled = True
                BTN_DELETBARANG.Enabled = True
            End If
        End If
    End Sub

    Private Sub BTN_EDITHJ_Click(sender As Object, e As EventArgs) Handles BTN_EDITHJual.Click
        Label1.Focus()
        If BTN_EDITHJual.Text = "Edit" Then
            BTN_EDITHJual.Text = "Cencel"
            TB_HJual.Enabled = True
            TB_IDbarang.Enabled = False
            BTN_SIMPAN.Enabled = True
            BTN_DELETBARANG.Enabled = False
            BTN_OKUID.Enabled = False
        Else
            BTN_EDITHJual.Text = "Edit"
            TB_HJual.Text = eBhj
            TB_HJual.Enabled = False
            If BTN_EDITNBarang.Text = "Cencel" Or BTN_EDITHBeli.Text = "Cencel" Or BTN_EDITSTOK.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_IDbarang.Enabled = True
                BTN_DELETBARANG.Enabled = True
            End If
        End If
    End Sub

    Private Sub BTN_EDITSTOK_Click(sender As Object, e As EventArgs) Handles BTN_EDITSTOK.Click
        Label1.Focus()
        If BTN_EDITSTOK.Text = "Edit" Then
            BTN_EDITSTOK.Text = "Cencel"
            TB_Stok.Enabled = True
            TB_IDbarang.Enabled = False
            BTN_SIMPAN.Enabled = True
            BTN_DELETBARANG.Enabled = False
            BTN_OKUID.Enabled = False
        Else
            BTN_EDITSTOK.Text = "Edit"
            TB_Stok.Text = eBstok
            TB_Stok.Enabled = False
            If BTN_EDITNBarang.Text = "Cencel" Or BTN_EDITHBeli.Text = "Cencel" Or BTN_EDITHJual.Text = "Cencel" Then
                BTN_SIMPAN.Enabled = True
            Else
                BTN_SIMPAN.Enabled = False
                BTN_OKUID.Enabled = True
                TB_IDbarang.Enabled = True
                BTN_DELETBARANG.Enabled = True
            End If
        End If
    End Sub

    Private Sub kondisiAwal()
        ClearTextBox(Me)
        hideBTN()
        clearVarBrg()
        hideTB()
        textedit()
        BTN_OKUID.Enabled = True
        TB_IDbarang.Enabled = True
    End Sub

    Private Sub clearTB()
        TB_NBarang.Text = vbNullString
        TB_HBeli.Text = vbNullString
        TB_HJual.Text = vbNullString
        TB_Stok.Text = vbNullString
    End Sub

    Private Sub clearVarBrg()
        eBname = vbNullString
        eBhb = Nothing
        eBhj = Nothing
        eBstok = Nothing
    End Sub

    Private Sub hideBTN()
        BTN_EDITNBarang.Enabled = False
        BTN_EDITHBeli.Enabled = False
        BTN_EDITHJual.Enabled = False
        BTN_EDITSTOK.Enabled = False
        BTN_SIMPAN.Enabled = False
        BTN_DELETBARANG.Enabled = False
    End Sub


    Private Sub showEditBTN()
        BTN_EDITNBarang.Enabled = True
        BTN_EDITHBeli.Enabled = True
        BTN_EDITHJual.Enabled = True
        BTN_EDITSTOK.Enabled = True
    End Sub

    Private Sub hideTB()
        TB_NBarang.Enabled = False
        TB_HBeli.Enabled = False
        TB_HJual.Enabled = False
        TB_Stok.Enabled = False
    End Sub

    Private Sub textedit()
        BTN_EDITNBarang.Text = "Edit"
        BTN_EDITHBeli.Text = "Edit"
        BTN_EDITHJual.Text = "Edit"
        BTN_EDITSTOK.Text = "Edit"
    End Sub

End Class