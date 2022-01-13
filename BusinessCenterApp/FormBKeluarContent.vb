Imports System.ComponentModel

Public Class FormBKeluarContent
    Dim connect As New DBBarangKeluar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub BTN_TambahBarang_Click(sender As Object, e As EventArgs) Handles BTN_TambahBarang.Click
        FormBuatLaporanBarangKeluar.ShowDialog()
    End Sub

    Private Sub FormBKeluarContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showtbl()
        If ustatus = "admin" Then
            BTN_EditBarang.Visible = True
        Else
            BTN_EditBarang.Visible = False
        End If
        DataGridView1.Columns(2).DefaultCellStyle.Format = "Rp##,0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "Rp##,0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp##,0"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "Rp##,0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "Rp##,0"
    End Sub

    Sub showtbl()
        Dim bkinfo = connect.SelectToTable
        Dim table As New DataTable
        For Each table In bkinfo.tables
            DataGridView1.DataSource = table
        Next
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Descending)
        End If
    End Sub

    Private Sub BTN_Refreshtbl_Click(sender As Object, e As EventArgs) Handles BTN_Refreshtbl.Click
        showtbl()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub BTN_Refreshtbl_MouseEnter(sender As Object, e As EventArgs) Handles BTN_Refreshtbl.MouseEnter
        BTN_Refreshtbl.BackColor = Color.FromKnownColor(KnownColor.ControlLight)
    End Sub

    Private Sub BTN_Refreshtbl_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Refreshtbl.MouseLeave
        BTN_Refreshtbl.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub BTN_Refreshtbl_MouseDown(sender As Object, e As MouseEventArgs) Handles BTN_Refreshtbl.MouseDown
        BTN_Refreshtbl.BackColor = Color.Gray
    End Sub

    Private Sub BTN_Refreshtbl_MouseUp(sender As Object, e As MouseEventArgs) Handles BTN_Refreshtbl.MouseUp
        BTN_Refreshtbl.BackColor = Color.FromKnownColor(KnownColor.ControlLight)
    End Sub

    Private Sub BTN_EditBarang_Click(sender As Object, e As EventArgs) Handles BTN_EditBarang.Click
        FormEditLaporanBarangKeluar.ShowDialog()
    End Sub

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        If TB_Search.Text.Length > 0 Then
            Dim bkinfo = connect.searchLPBK(TB_Search.Text)
            Dim table As New DataTable
            For Each table In bkinfo.tables
                DataGridView1.DataSource = table
            Next
        Else
            showtbl()
        End If
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.HeaderCell.Value = String.Format("{0}", row.Index + 1)
        Next
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btn_cetak_nota_Click(sender As Object, e As EventArgs) Handles btn_cetak_nota.Click
        FormCetakNota.ShowDialog()
    End Sub
End Class