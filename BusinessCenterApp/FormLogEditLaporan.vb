Public Class FormLogEditLaporan
    Dim connect As New DBBarangKeluar
    Private Sub FormLogEditLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showtbl()
        semuaclick()
    End Sub

    Sub showtbl()
        Dim linfo = connect.LogTotable
        Dim table As New DataTable
        For Each table In linfo.tables
            dgv_bk.DataSource = table
        Next
    End Sub

    Private Sub dgv_bk_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv_bk.DataBindingComplete
        dgv_bk.ClearSelection()
    End Sub

    Private Sub btn_editbk_Click(sender As Object, e As EventArgs) Handles btn_editbk.Click
        editclick()
    End Sub

    Private Sub btn_hapusbk_Click(sender As Object, e As EventArgs) Handles btn_hapusbk.Click
        hapusclick()
    End Sub

    Private Sub btn_semuabk_Click(sender As Object, e As EventArgs) Handles btn_semuabk.Click
        semuaclick()
    End Sub

    Private Sub TB_SearchLogBK_TextChanged(sender As Object, e As EventArgs) Handles TB_SearchLogBK.TextChanged

    End Sub

    Sub editclick()
        btn_editbk.Checked = True
        btn_editbk.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_hapusbk.Checked = False
        btn_hapusbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_semuabk.Checked = False
        btn_semuabk.CustomBorderThickness = New Padding(0, 0, 0, 2)
    End Sub

    Sub hapusclick()
        btn_hapusbk.Checked = True
        btn_hapusbk.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_editbk.Checked = False
        btn_editbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_semuabk.Checked = False
        btn_semuabk.CustomBorderThickness = New Padding(0, 0, 0, 2)
    End Sub

    Sub semuaclick()
        btn_semuabk.Checked = True
        btn_semuabk.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_editbk.Checked = False
        btn_editbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_hapusbk.Checked = False
        btn_hapusbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
    End Sub
End Class