Imports Guna.UI2.WinForms
Public Class FormTambahBarang
    Dim connect As New DBBarang

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub BTN_Simpan_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        Label1.Focus()
        If emptyTextBox(Me) = False Then
            Dim insert = connect.TambahBarang(TB_NamaBrg.Text, Val(TB__HargaBeli.Text), Val(TB_HargaJual.Text), Val(TB_Stok.Text))
            If insert = Status.Success Then
                MessageBox.Show("Berhasil Menambahkan Barang!")
                FormDBarangContent.showtblbarang()
                ClearTextBox(Me)

            ElseIf insert = Status.BarangExist Then
                MessageBox.Show("Barang sudah ada!")
            End If
        End If

    End Sub

    Private Sub BTN_Batal_Click(sender As Object, e As EventArgs) Handles BTN_Batal.Click
        Label1.Focus()
        Me.Close()
    End Sub

    Private Sub FormTambahBarang_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearTextBox(Me)
        Label1.Focus()
    End Sub

    Private Sub TB_NamaBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NamaBrg.KeyPress
        e.Handled = Not (ValidCharsWithSpaceNoNum.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub TB__HargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB__HargaBeli.KeyPress, TB_HargaJual.KeyPress, TB_Stok.KeyPress, TB_CurHj.KeyPress, TB_CurHb.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TB__HargaBeli_TextChanged(sender As Object, e As EventArgs) Handles TB__HargaBeli.TextChanged
        TB_CurHb.Text = TB__HargaBeli.Text
    End Sub

    Private Sub TB_HargaJual_TextChanged(sender As Object, e As EventArgs) Handles TB_HargaJual.TextChanged
        TB_CurHj.Text = TB_HargaJual.Text
    End Sub

    Private Sub TB_CurHb_TextChanged(sender As Object, e As EventArgs) Handles TB_CurHb.TextChanged
        formatUang(TB_CurHb)
    End Sub

    Private Sub TB_CurHj_TextChanged(sender As Object, e As EventArgs) Handles TB_CurHj.TextChanged
        formatUang(TB_CurHj)
    End Sub

End Class