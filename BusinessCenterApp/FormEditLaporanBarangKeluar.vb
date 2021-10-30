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
    End Sub

    Private Sub FormEditLaporanBarangKeluar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        TB_NoNota.Text = Nothing
        kondisiawal()
    End Sub

    Private Sub TB_NoNota_TextChanged(sender As Object, e As EventArgs) Handles TB_NoNota.TextChanged
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

    Private Sub BTN_OKUID_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        If TB_NoNota.Text = Nothing Then
            MessageBox.Show("Harap masukkan No Nota Keluar yang ingin di edit atau dihapus")
            kondisiawal()
        Else
            Dim bkinfo = connect.getinfobrgkluar(TB_NoNota.Text)
            If bkinfo = Status.Success Then
                TB_NamaBrg.Text = ebKname
                TB_HargaBeli.Text = ebKhb
                TB_HargaJual.Text = ebKhj
                TB_Jumlah.Text = ebKjml
                TB_Tanggal.Text = ebKtgl
                kondisiOK()
            Else
                MessageBox.Show("No Nota Keluar tidak ada!!")
                kondisiawal()
            End If
        End If
    End Sub

    'Private Sub BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles BTN_SIMPAN.Click
    '    If TB_Jumlah.Text.Length > 0 Then
    '        Dim editbk = connect.EditLaporanBK

    '    End If
    'End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim bk = connect.DeleteLaporanBK(TB_NoNota.Text, ebKid, ebKstok, Val(TB_Jumlah.Text))
        If bk = Status.Success Then
            MessageBox.Show("Berhasil menghapus Laporan Barang Keluar")
            kondisiawal()
            FormBKeluarContent.showtbl()
        End If
    End Sub

    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        If BTN_Edit.Text = "Edit" Then
            BTN_Edit.Text = "Cancel"
            TB_Jumlah.Enabled = True
            BTN_SIMPAN.Enabled = True
            TB_NoNota.Enabled = False
            BTN_OK.Enabled = False
            BTN_DELETE.Enabled = False
        Else
            BTN_Edit.Text = "Edit"
            TB_Jumlah.Text = ebKjml
            TB_Jumlah.Enabled = False
            BTN_SIMPAN.Enabled = False
            TB_NoNota.Enabled = True
            BTN_OK.Enabled = True
            BTN_DELETE.Enabled = True
        End If
    End Sub

    Private Sub TB_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles TB_Jumlah.TextChanged
        TB_Subtotal.Text = ebKhj * Val(TB_Jumlah.Text)
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
    End Sub

    Sub kondisiawal()
        TB_Jumlah.Enabled = False
        BTN_SIMPAN.Enabled = False
        BTN_DELETE.Enabled = False
        BTN_Edit.Enabled = False
        clearTB()
        clearVar()
    End Sub

    Sub kondisiOK()
        BTN_Edit.Enabled = True
        BTN_DELETE.Enabled = True
    End Sub

    Sub clearTB()
        TB_NamaBrg.Text = Nothing
        TB_Tanggal.Text = Nothing
        TB_HargaBeli.Text = Nothing
        TB_HargaJual.Text = Nothing
        TB_Jumlah.Text = Nothing
        TB_Subtotal.Text = Nothing
        TB_Keuntungan.Text = Nothing
    End Sub

    Sub clearVar()
        ebKname = vbNullString
        ebKtgl = vbNullString
        eBhb = Nothing
        ebKhj = Nothing
        ebKjml = Nothing
        ebKuntung = Nothing
        ebKrugi = Nothing
        ebKid = Nothing
        ebKstok = Nothing
    End Sub

    Private Sub BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles BTN_SIMPAN.Click
        Dim r = connect.restore_stock(TB_NoNota.Text, TB_Jumlah.Text)
        If r = Status.Success Then
            MessageBox.Show("Berhasil mengedit!")
            kondisiawal()
            FormBKeluarContent.showtbl()
        End If
        TB_NoNota.Enabled = True
    End Sub
    Private Sub TB_HargaBeli_TextChanged(sender As Object, e As EventArgs) Handles TB_HargaBeli.TextChanged
        formatUang(TB_HargaBeli)
    End Sub

    Private Sub TB_HargaJual_TextChanged(sender As Object, e As EventArgs) Handles TB_HargaJual.TextChanged
        formatUang(TB_HargaJual)
    End Sub

    Private Sub TB_Subtotal_TextChanged(sender As Object, e As EventArgs) Handles TB_Subtotal.TextChanged
        TB_CurStot.Text = TB_Subtotal.Text
    End Sub

    Private Sub TB_Keuntungan_TextChanged(sender As Object, e As EventArgs) Handles TB_Keuntungan.TextChanged
        TB_CurKun.Text = TB_Keuntungan.Text
    End Sub

    Private Sub TB_CurStot_TextChanged(sender As Object, e As EventArgs) Handles TB_CurStot.TextChanged
        formatUang(TB_CurStot)
    End Sub

    Private Sub TB_CurKun_TextChanged(sender As Object, e As EventArgs) Handles TB_CurKun.TextChanged
        formatUang(TB_CurKun)
    End Sub
End Class