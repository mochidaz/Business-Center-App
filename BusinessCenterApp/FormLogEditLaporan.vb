Public Class FormLogEditLaporan
    Dim connect As New DBBarangKeluar
    Private Sub FormLogEditLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showtbl()
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
End Class