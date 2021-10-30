Public Class FormBuatLaporanBarangKeluar
    Dim connect As New DBBarangKeluar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim cp As CreateParams = MyBase.CreateParams

            cp.ExStyle = cp.ExStyle Or 33554432

            Return cp

        End Get

    End Property

    Private Sub FormBuatLaporanBarangKeluar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kondisiawal()
    End Sub

    Private Sub FormBuatLaporanBarangKeluar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        kondisiawal()
    End Sub

    Private Sub TB_IDBRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_IDBRG.KeyPress, TB_Jumlah.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TB_NoNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NoNota.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_NamaBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NamaBrg.KeyPress
        e.Handled = Not (ValidCharsWithSpaceNoNum.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub RBTN_IDBRG_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_IDBRG.CheckedChanged
        If RBTN_IDBRG.Checked = True Then
            RBTN_NMBRG.Checked = False
            BTN_OK.Enabled = False
            TB_IDBRG.Enabled = True
        Else
            TB_NamaBrg.Text = Nothing
            TB_IDBRG.Text = Nothing
            clearTB()
            TB_IDBRG.Enabled = False
        End If
    End Sub

    Private Sub TB_IDBRG_TextChanged(sender As Object, e As EventArgs) Handles TB_IDBRG.TextChanged
        clearTB()
        If TB_IDBRG.Text = Nothing Then
            TB_NamaBrg.Text = Nothing
            clearTB()
            clearVar()
        Else
            Dim lpbk = connect.selectBarang_id(Val(TB_IDBRG.Text))
            If lpbk = Status.Success Then
                TB_NamaBrg.Text = bKname
                TB_HargaBeli.Text = bKhb
                TB_HargaJual.Text = bKhj
                TB_Jumlah.Enabled = True
            Else
                TB_NamaBrg.Text = Nothing
                clearTB()
                clearVar()
                MessageBox.Show("ID Barang tidak ada!!")
            End If
        End If
    End Sub

    Private Sub RBTN_NMBRG_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_NMBRG.CheckedChanged
        If RBTN_NMBRG.Checked = True Then
            RBTN_IDBRG.Checked = False
            BTN_OK.Enabled = True
            TB_NamaBrg.Enabled = True
        Else
            TB_NamaBrg.Text = Nothing
            TB_IDBRG.Text = Nothing
            clearTB()
            TB_NamaBrg.Enabled = False
        End If
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        If BTN_OK.Text = "OK" Then
            If TB_NamaBrg.Text = Nothing Then
                TB_IDBRG.Text = Nothing
                clearTB()
                clearVar()
                MessageBox.Show("Harap masukkan nama barangnya!!")
            Else
                Dim lpbk = connect.selectBarang_name(TB_NamaBrg.Text)
                If lpbk = Status.Success Then
                    TB_IDBRG.Text = bKid
                    TB_HargaBeli.Text = bKhb
                    TB_HargaJual.Text = bKhj
                    TB_Jumlah.Enabled = True
                    BTN_OK.Text = "CENCEL"
                    TB_NamaBrg.Enabled = False
                Else
                    TB_IDBRG.Text = Nothing
                    clearTB()
                    clearVar()
                    MessageBox.Show("Nama Barang tidak ada!!")
                End If
            End If
        Else
            BTN_OK.Text = "OK"
            TB_NamaBrg.Enabled = True
            TB_IDBRG.Text = Nothing
            clearTB()
            clearVar()
        End If

    End Sub

    Private Sub BTN_Simpan_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        If emptyTextBox(Me) = False Then
            Dim insert = connect.TambahLaporanBK(TB_NoNota.Text, Val(TB_IDBRG.Text), Val(TB_Jumlah.Text), Val(TB_Subtotal.Text), vUid, bKuntung, bKrugi, bKstok)
            If insert = Status.Success Then
                MessageBox.Show("Berhasil menambahkan laporan barang keluar")
                ClearTextBox(Me)
                FormBKeluarContent.showtbl()
            ElseIf insert = Status.LaporanExist Then
                MessageBox.Show("Laporan dengan no nota yang sama sudah ada!!")
            ElseIf insert = Status.StokBarangKosong Then
                MessageBox.Show("Tidak dapat membuat laporan, karena jumlah barang keluar melebihi stok barang yang ada!!")
            End If
        End If
    End Sub

    Private Sub BTN_Batal_Click(sender As Object, e As EventArgs) Handles BTN_Batal.Click
        Me.Close()
    End Sub

    Private Sub TB_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles TB_Jumlah.TextChanged
        TB_Subtotal.Text = Val(TB_HargaJual.Text) * Val(TB_Jumlah.Text)
        If Val(TB_HargaBeli.Text) < Val(TB_HargaJual.Text) Then
            lbl_untungrugi.Text = "Keuntungan"
            bKuntung = (Val(TB_HargaJual.Text) - Val(TB_HargaBeli.Text)) * Val(TB_Jumlah.Text)
            bKrugi = 0
            TB_Keuntungan.Text = bKuntung
        ElseIf Val(TB_HargaBeli.Text) > Val(TB_HargaJual.Text) Then
            lbl_untungrugi.Text = "Kerugian"
            bKrugi = (Val(TB_HargaBeli.Text) - Val(TB_HargaJual.Text)) * Val(TB_Jumlah.Text)
            bKuntung = 0
            TB_Keuntungan.Text = bKrugi
        End If
    End Sub

    Sub kondisiawal()
        TB_Jumlah.Enabled = False
        ClearTextBox(Me)
        RBTN_IDBRG.Checked = True
        RBTN_NMBRG.Checked = False
        BTN_OK.Enabled = False
        clearVar()
    End Sub

    Sub clearTB()
        TB_HargaJual.Text = Nothing
        TB_Jumlah.Text = Nothing
        TB_Subtotal.Text = Nothing
        TB_Jumlah.Enabled = False
        TB_HargaBeli.Text = Nothing
        TB_Keuntungan.Text = Nothing
        lbl_untungrugi.Text = "Keuntungan"
    End Sub

    Sub clearVar()
        bKname = vbNullString
        bKhj = Nothing
        bKhb = Nothing
        bKid = Nothing
        bKuntung = Nothing
        bKrugi = Nothing
        bKjml = Nothing
        bKstok = Nothing
    End Sub

End Class