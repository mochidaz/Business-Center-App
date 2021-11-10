Public Class FormEditLaporanBarangKeluar
    Dim connect As New DBBarangKeluar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormEditLaporanBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
        TB_NoNota.Text = Nothing
    End Sub

    Private Sub FormEditLaporanBarangKeluar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        TB_NoNota.Text = Nothing
        kondisiawal()
    End Sub

    Private Sub TB_NoNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NoNota.KeyPress
        e.Handled = Not (ValidChars.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB_Jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Jumlah.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTN_OKnota_Click(sender As Object, e As EventArgs) Handles BTN_OKnota.Click
        If BTN_OKnota.Text = "OK" Then
            If TB_NoNota.Text = Nothing Then
                MessageBox.Show("Harap masukkan No Nota Keluar yang ingin di edit atau dihapus")
                kondisiawal()
            Else
                Dim bkinfo = connect.showdgvbk_nota(TB_NoNota.Text, DataGridView1)
                If bkinfo = Status.Success Then
                    kondisiOKnota()
                    TB_Tanggal.Text = ebKtgl
                    TB_Jam.Text = ebKjam
                Else
                    MessageBox.Show("No Nota Keluar tidak ada!!")
                    kondisiawal()
                End If
            End If
        Else
            kondisiawal()
        End If
    End Sub

    Private Sub BTN_OKid_Click(sender As Object, e As EventArgs) Handles BTN_OKid.Click
        If TB_IDBRG.Text = Nothing Then
            clearTB()
            clearVar()
            BTN_DeleteBrg.Enabled = False
            MessageBox.Show("Harap masukkan id barang disamping yang ingin dihapus atau diedit!!")
        Else
            Dim lpbk = connect.showinfbk_idbrg(TB_NoNota.Text, Val(TB_IDBRG.Text), DataGridView1)
            If lpbk = Status.Success Then
                TB_HargaBeli.Text = ebKhb
                TB_HargaJual.Text = ebKhj
                kondisiOKid()
            Else
                BTN_DeleteBrg.Enabled = False
                clearTB()
                clearVar()
                MessageBox.Show("ID Barang tidak ada!!")
            End If
        End If
    End Sub

    Private Sub BTN_SimpanBrg_Click(sender As Object, e As EventArgs) Handles BTN_SimpanBrg.Click
        If Val(TB_Jumlah.Text) = ebKjml Then
            MessageBox.Show("Tidak ada yang dirubah")
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).Value = Val(TB_IDBRG.Text) Then
                    row.Cells(4).Value = Val(TB_Jumlah.Text)
                    row.Cells(5).Value = ebKstot
                    row.Cells(6).Value = ebKuntung
                    row.Cells(7).Value = ebKrugi
                End If
            Next
            BTN_SimpanNota.Enabled = True
        End If

    End Sub

    Private Sub BTN_DeleteBrg_Click(sender As Object, e As EventArgs) Handles BTN_DeleteBrg.Click
        Dim dlt = connect.DeleteBarangLPBK(TB_NoNota.Text, Val(TB_IDBRG.Text), DataGridView1)
        If dlt = Status.Success Then
            MessageBox.Show("Berhasil menghapus barang!!")
            kondisiawal()
            FormBKeluarContent.showtbl()
        End If
    End Sub

    Private Sub BTN_SimpanNota_Click(sender As Object, e As EventArgs) Handles BTN_SimpanNota.Click
        Dim r = connect.EditLaporanBK(DataGridView1, TB_NoNota.Text)
        If r = Status.Success Then
            MessageBox.Show("Edit Nota Berhasil!!")
            kondisiawal()
            BTN_OKid.Enabled = False
            FormBKeluarContent.showtbl()
            jum = 0
            connect.log_penjualan(vUid, TB_NoNota.Text, DateTime.Now())
        ElseIf r = Status.DataIncomplete Then
            MessageBox.Show("Tidak ada yang diedit!!")
        Else
            MessageBox.Show("Jumlah pada salah satu barang melebihi stok yang ada!!")
        End If
    End Sub

    Private Sub BTN_DeleteNota_Click(sender As Object, e As EventArgs) Handles BTN_DeleteNota.Click
        Dim bk = connect.DeleteLaporanBK(TB_NoNota.Text, DataGridView1)
        If bk = Status.Success Then
            MessageBox.Show("Berhasil menghapus Laporan Barang Keluar")
            kondisiawal()
            TB_NoNota.Text = Nothing
            FormBKeluarContent.showtbl()
        End If
    End Sub

    Private Sub TB_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles TB_Jumlah.TextChanged
        ebKstot = ebKhj * Val(TB_Jumlah.Text)
        TB_Subtotal.Text = ebKstot
        If ebKhb < ebKhj Then
            lbl_untungrugi.Text = "Keuntungan"
            ebKuntung = (ebKhj - ebKhb) * Val(TB_Jumlah.Text)
            ebKrugi = 0
            TB_Keuntungan.Text = ebKuntung
        ElseIf ebKhb > ebKhj Then
            lbl_untungrugi.Text = "Kerugian"
            ebKrugi = (ebKhb - ebKhj) * Val(TB_Jumlah.Text)
            ebKuntung = 0
            TB_Keuntungan.Text = ebKrugi
        End If
        If TB_Jumlah.Text.Length > 0 Then
            BTN_SimpanBrg.Enabled = True
        Else
            BTN_SimpanBrg.Enabled = False
        End If
    End Sub

    Private Sub TB_IDBRG_TextChanged(sender As Object, e As EventArgs) Handles TB_IDBRG.TextChanged
        clearTB()
        clearVar()
        TB_Jumlah.Enabled = False
        BTN_OKid.Enabled = True
        BTN_DeleteBrg.Enabled = False
    End Sub

    Sub kondisiawal()
        DataGridView1.Rows.Clear()
        BTN_OKnota.Text = "OK"
        TB_NoNota.Enabled = True
        BTN_OKnota.Enabled = True
        TB_Jumlah.Enabled = False
        BTN_OKid.Enabled = False
        BTN_SimpanNota.Enabled = False
        BTN_DeleteNota.Enabled = False
        BTN_SimpanBrg.Enabled = False
        BTN_DeleteBrg.Enabled = False
        BTN_OKid.Enabled = False
        TB_IDBRG.Enabled = False
        TB_IDBRG.Text = Nothing
        TB_Tanggal.Text = Nothing
        TB_Jam.Text = Nothing
        clearTB()
        clearVar()
    End Sub

    Sub kondisiOKid()
        kondisiOKnota()
        BTN_SimpanNota.Enabled = False
        BTN_SimpanBrg.Enabled = False
        BTN_OKnota.Enabled = True
        BTN_DeleteBrg.Enabled = True
        TB_Jumlah.Enabled = True
    End Sub

    Sub kondisiOKnota()
        BTN_OKnota.Text = "Cancel"
        BTN_OKid.Enabled = True
        TB_NoNota.Enabled = False
        TB_IDBRG.Enabled = True
        BTN_DeleteNota.Enabled = True
    End Sub

    Sub clearTB()
        TB_HargaBeli.Text = Nothing
        TB_HargaJual.Text = Nothing
        TB_Jumlah.Text = Nothing
        TB_Subtotal.Text = Nothing
        TB_Keuntungan.Text = Nothing
    End Sub

    Sub clearVar()
        ebKname = vbNullString
        eBhb = Nothing
        ebKhj = Nothing
        ebKjml = Nothing
        ebKuntung = Nothing
        ebKrugi = Nothing
        ebKid = Nothing
        ebKstok = Nothing
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class