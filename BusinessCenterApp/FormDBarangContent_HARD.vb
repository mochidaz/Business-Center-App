'Public Class FormDBarangContent
'    Dim connect As New DBBarang
'    Private Sub BTN_TambahBarang_Click(sender As Object, e As EventArgs) Handles BTN_TambahBarang.Click
'        FormTambahBarang.ShowDialog()
'    End Sub

'    Private Sub BTN_Semua_Click(sender As Object, e As EventArgs) Handles BTN_Semua.Click
'        BTN_Semua.Checked = True
'        BTN_Stokkosong.Checked = False
'        BTN_Semua.CustomBorderThickness = New Padding(0, 0, 0, 2)
'        BTN_Stokkosong.CustomBorderThickness = New Padding(0, 0, 0, 1)
'    End Sub

'    Private Sub BTN_Stokkosong_Click(sender As Object, e As EventArgs) Handles BTN_Stokkosong.Click
'        BTN_Semua.Checked = False
'        BTN_Stokkosong.Checked = True
'        BTN_Stokkosong.CustomBorderThickness = New Padding(0, 0, 0, 2)
'        BTN_Semua.CustomBorderThickness = New Padding(0, 0, 0, 1)
'    End Sub

'    Private Sub kondisiawal()
'        BTN_Semua.Checked = True
'        BTN_Stokkosong.Checked = False
'        BTN_Semua.CustomBorderThickness = New Padding(0, 0, 0, 2)
'        BTN_Stokkosong.CustomBorderThickness = New Padding(0, 0, 0, 1)

'    End Sub
'                                                                                                       // UNDONE // maybe next time?
'    Private Sub DBarangContent_Load(sender As Object, e As EventArgs) Handles Me.Load
'        kondisiawal()
'        showBarang()
'    End Sub

'    Private Sub showBarang()
'        Dim binfo = connect.readBarang()
'        For i As Integer = 0 To id_barang.Length - 1
'            Dim c As DaftarBarangUserControl = New DaftarBarangUserControl
'            c.Dock = DockStyle.Top
'            c.LBL_ID.Text = id_barang(i)
'            c.LBL_Nama.Text = nama_barang(i)
'            c.LBL_Harbel.Text = harga_beli(i)
'            c.LBL_Harual.Text = harga_jual(i)
'            c.LBL_Stok.Text = stok(i)
'            PNL_Daftarbrg.Controls.Add(c)
'            Timer1.Enabled = False
'        Next
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        showBarang()
'    End Sub
'End Class