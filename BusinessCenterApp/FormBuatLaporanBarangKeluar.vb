﻿Public Class FormBuatLaporanBarangKeluar
    Dim connect As New DBBarangKeluar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormLaporanBK_NewUnimplemented_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        kondisiawal()
        TB_NoNota.Text = Nothing
        TB_IDBRG.Text = Nothing
        TB_NamaBrg.Text = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub FormLaporanBK_NewUnimplemented_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        kondisiawal()
        TB_NoNota.Text = Nothing
        TB_IDBRG.Text = Nothing
        TB_NamaBrg.Text = Nothing
        DataGridView1.Rows.Clear()
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
            BTN_OKib.Enabled = True
            BTN_OKib.Visible = True
            BTN_OKnb.Enabled = False
            BTN_OKnb.Visible = False
            TB_IDBRG.Enabled = True
        Else
            BTN_OKib.Enabled = False
            BTN_OKib.Visible = False
            BTN_OKnb.Enabled = True
            BTN_OKnb.Visible = True
            TB_NamaBrg.Text = Nothing
            TB_IDBRG.Text = Nothing
            clearTB()
            TB_IDBRG.Enabled = False
        End If
    End Sub

    Private Sub RBTN_NMBRG_CheckedChanged(sender As Object, e As EventArgs) Handles RBTN_NMBRG.CheckedChanged
        If RBTN_NMBRG.Checked = True Then
            RBTN_IDBRG.Checked = False
            BTN_OKnb.Enabled = True
            BTN_OKnb.Visible = True
            TB_NamaBrg.Enabled = True
            BTN_OKib.Enabled = False
            BTN_OKib.Visible = False
            BTN_OKnb.Enabled = True
            BTN_OKnb.Visible = True
        Else
            BTN_OKib.Enabled = True
            BTN_OKib.Visible = True
            BTN_OKnb.Enabled = False
            BTN_OKnb.Visible = False
            TB_NamaBrg.Text = Nothing
            TB_IDBRG.Text = Nothing
            clearTB()
            TB_NamaBrg.Enabled = False
        End If
    End Sub

    Private Sub BTN_OKnb_Click(sender As Object, e As EventArgs) Handles BTN_OKnb.Click
        If BTN_OKnb.Text = "OK" Then
            If TB_NamaBrg.Text = Nothing Then
                TB_IDBRG.Text = Nothing
                RBTN_NMBRG.Enabled = True
                RBTN_IDBRG.Enabled = True
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
                    BTN_OKnb.Text = "Cancel"
                    TB_NamaBrg.Enabled = False
                    RBTN_NMBRG.Enabled = False
                    RBTN_IDBRG.Enabled = False
                Else
                    RBTN_NMBRG.Enabled = True
                    RBTN_IDBRG.Enabled = True
                    TB_IDBRG.Text = Nothing
                    clearTB()
                    clearVar()
                    MessageBox.Show("Nama Barang tidak ada!!")
                End If
            End If
        Else
            RBTN_NMBRG.Enabled = True
            RBTN_IDBRG.Enabled = True
            BTN_OKnb.Text = "OK"
            TB_NamaBrg.Enabled = True
            TB_IDBRG.Text = Nothing
            clearTB()
            clearVar()
        End If
    End Sub

    Private Sub BTN_OKib_Click(sender As Object, e As EventArgs) Handles BTN_OKib.Click
        If BTN_OKib.Text = "OK" Then
            If TB_IDBRG.Text = Nothing Then
                RBTN_NMBRG.Enabled = True
                RBTN_IDBRG.Enabled = True
                TB_NamaBrg.Text = Nothing
                clearTB()
                clearVar()
                MessageBox.Show("Harap masukkan id barangnya!!")
            Else
                Dim lpbk = connect.selectBarang_id(Val(TB_IDBRG.Text))
                If lpbk = Status.Success Then
                    TB_NamaBrg.Text = bKname
                    TB_HargaBeli.Text = bKhb
                    TB_HargaJual.Text = bKhj
                    TB_Jumlah.Enabled = True
                    BTN_OKib.Text = "Cancel"
                    TB_IDBRG.Enabled = False
                    RBTN_NMBRG.Enabled = False
                    RBTN_IDBRG.Enabled = False
                Else
                    RBTN_NMBRG.Enabled = True
                    RBTN_IDBRG.Enabled = True
                    TB_NamaBrg.Text = Nothing
                    clearTB()
                    clearVar()
                    MessageBox.Show("ID Barang tidak ada!!")
                End If
            End If
        Else
            RBTN_NMBRG.Enabled = True
            RBTN_IDBRG.Enabled = True
            BTN_OKib.Text = "OK"
            TB_IDBRG.Enabled = True
            TB_NamaBrg.Text = Nothing
            clearTB()
            clearVar()
        End If
    End Sub

    Private Sub BTN_TambahBrg_Click(sender As Object, e As EventArgs) Handles BTN_TambahBrg.Click
        Dim bln As Boolean = False
        If TB_Jumlah.Text = Nothing Then
            MessageBox.Show("Jumlah tidak boleh kosong")
        Else
            If bKstok >= TB_Jumlah.Text Then
                For b As Integer = 0 To DataGridView1.Rows.Count - 1
                    If TB_IDBRG.Text = DataGridView1.Rows(b).Cells(0).Value Then
                        MessageBox.Show("Barang sudah ada dalam daftar")
                        bln = True
                    Else
                        bln = False
                    End If
                Next
                If bln = False Then
                    DataGridView1.Rows.Add(TB_IDBRG.Text, TB_NamaBrg.Text, bKhb, bKhj, TB_Jumlah.Text, bKstotal, bKuntung, bKrugi)
                    BTN_DeleteBrg.Enabled = True
                    BTN_Simpan.Enabled = True
                    kondisisetelahOK()
                End If
            Else
                MessageBox.Show("Jumlah barang keluar melebihi stok barang yang ada!!")
            End If
        End If
    End Sub

    Private Sub BTN_DeleteBrg_Click(sender As Object, e As EventArgs) Handles BTN_DeleteBrg.Click
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(i)
        If DataGridView1.RowCount > 0 Then
            BTN_DeleteBrg.Enabled = True
            BTN_Simpan.Enabled = True
        Else
            BTN_DeleteBrg.Enabled = False
            BTN_Simpan.Enabled = False
        End If
    End Sub

    Private Sub BTN_Simpan_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        If DataGridView1.RowCount > 0 Then
            Dim lpbk = connect.TambahLaporanBK(DataGridView1, TB_NoNota.Text, vUid)
            If lpbk = Status.Success Then
                MessageBox.Show("Berhasil menambahkan laporan!!")
                connect.log(vUid, TB_NoNota.Text, DateTime.Now(), "tambah", "lpbk")
                ClearTextBox(Me)
                kondisiawal()
                FormBKeluarContent.showtbl()
            Else
                MessageBox.Show("Gagal menambahkan laporan!!")
            End If
        Else
            MessageBox.Show("Barang belum ditambahkan!!")
        End If
    End Sub

    Private Sub BTN_Batal_Click(sender As Object, e As EventArgs) Handles BTN_Batal.Click
        Me.Close()
    End Sub

    Private Sub TB_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles TB_Jumlah.TextChanged
        Try
            bKstotal = bKhj * Val(TB_Jumlah.Text)
            TB_Subtotal.Text = bKstotal
            If bKhb < bKhj Then
                lbl_untungrugi.Text = "Keuntungan"
                bKuntung = (bKhj - bKhb) * Val(TB_Jumlah.Text)
                bKrugi = 0
                TB_Keuntungan.Text = bKuntung
            ElseIf bKhb > bKhj Then
                lbl_untungrugi.Text = "Kerugian"
                bKrugi = (bKhb - bKhj) * Val(TB_Jumlah.Text)
                bKuntung = 0
                TB_Keuntungan.Text = bKrugi
            End If
            If TB_Jumlah.Text.Length > 0 Then
                BTN_TambahBrg.Enabled = True
            Else
                BTN_TambahBrg.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Jumlah terlalu banyak!!")
            TB_Jumlah.Text = "0"
        End Try
    End Sub

    Private Sub BTN_OKNota_Click(sender As Object, e As EventArgs) Handles BTN_OKNota.Click
        If BTN_OKNota.Text = "OK" Then
            If TB_NoNota.Text.Length > 0 Then
                Dim Le = connect.LaporanExist(TB_NoNota.Text)
                If Le = False Then
                    kondisisetelahOK()
                Else
                    MessageBox.Show("No Nota sudah ada!")
                End If
            Else
                MessageBox.Show("No Nota tidak boleh kosong!")
            End If
        Else
            kondisiawal()
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Sub kondisisetelahOK()
        clearTB()
        clearVar()
        BTN_OKNota.Text = "Cancel"
        BTN_OKnb.Text = "OK"
        BTN_OKib.Enabled = True
        BTN_OKib.Text = "OK"
        TB_NoNota.Enabled = False
        TB_IDBRG.Enabled = True
        RBTN_IDBRG.Enabled = True
        RBTN_NMBRG.Enabled = True
        RBTN_IDBRG.Checked = True
        RBTN_NMBRG.Checked = False
        TB_IDBRG.Text = Nothing
        TB_NamaBrg.Text = Nothing
    End Sub

    Sub kondisiawal()
        clearTB()
        clearVar()
        DataGridView1.Rows.Clear()
        RBTN_IDBRG.Checked = True
        RBTN_NMBRG.Checked = False
        TB_NoNota.Text = Nothing
        TB_IDBRG.Text = Nothing
        TB_NamaBrg.Text = Nothing
        RBTN_IDBRG.Enabled = False
        RBTN_NMBRG.Enabled = False
        BTN_OKnb.Enabled = False
        TB_IDBRG.Enabled = False
        TB_NamaBrg.Enabled = False
        TB_Jumlah.Enabled = False
        TB_NoNota.Enabled = True
        BTN_Simpan.Enabled = False
        BTN_DeleteBrg.Enabled = False
        BTN_TambahBrg.Enabled = False
        BTN_OKnb.Visible = False
        BTN_OKib.Enabled = False
        BTN_OKib.Visible = True
        BTN_OKnb.Text = "OK"
        BTN_OKib.Text = "OK"
        BTN_OKNota.Text = "OK"
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

    Private Sub TB_HargaBeli_TextChanged(sender As Object, e As EventArgs) Handles TB_HargaBeli.TextChanged
        formatUang(TB_HargaBeli)
    End Sub

    Private Sub TB_HargaJual_TextChanged(sender As Object, e As EventArgs) Handles TB_HargaJual.TextChanged
        formatUang(TB_HargaJual)
    End Sub

    Private Sub TB_Subtotal_TextChanged(sender As Object, e As EventArgs) Handles TB_Subtotal.TextChanged
        formatUang(TB_Subtotal)
    End Sub

    Private Sub TB_Keuntungan_TextChanged(sender As Object, e As EventArgs) Handles TB_Keuntungan.TextChanged
        formatUang(TB_Keuntungan)
    End Sub

End Class