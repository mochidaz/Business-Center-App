﻿Imports System.ComponentModel
Imports System.IO

Public Class FormDBarangContent
    Dim connect As New DBBarang

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub DBarangContent_simple__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showtblbarang()
        DataGridView1.ClearSelection()
        If ustatus = "admin" Then
            BTN_TambahBarang.Visible = True
            BTN_EditBarang.Visible = True
        Else
            BTN_TambahBarang.Visible = False
            BTN_EditBarang.Visible = False
        End If
        DataGridView1.Columns(2).DefaultCellStyle.Format = "Rp##,0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "Rp##,0"
    End Sub

    Sub showtblbarang()
        Dim binfo = connect.tblbarang
        Dim table As New DataTable
        For Each table In binfo.tables
            DataGridView1.DataSource = table
        Next
    End Sub

    Private Sub BTN_TambahBarang_Click(sender As Object, e As EventArgs) Handles BTN_TambahBarang.Click
        FormTambahBarang.ShowDialog()
    End Sub

    Private Sub BTN_EditBarang_Click(sender As Object, e As EventArgs) Handles BTN_EditBarang.Click
        FormEditBarang.ShowDialog()
    End Sub

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        If TB_Search.Text.Length > 0 Then
            Dim binfo = connect.searchBarang(TB_Search.Text)
            Dim table As New DataTable
            For Each table In binfo.tables
                DataGridView1.DataSource = table
            Next
        Else
            showtblbarang()
        End If
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DBarangContent_simple__MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Label1.Focus()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub BTN_Refreshtbl_Click(sender As Object, e As EventArgs) Handles BTN_Refreshtbl.Click
        showtblbarang()
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

    Private Sub BTN_Excel_Click(sender As Object, e As EventArgs) Handles BTN_Excel.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog
        sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
        sfd.FilterIndex = 0
        sfd.Title = "Save As"
        sfd.ShowDialog()
        If sfd.FileName <> "" Then
            Dim ex = connect.get_excel_barang(sfd.FileName, DataGridView1)
            If ex = Status.Success Then
                MessageBox.Show("Berhasil disimpan")
            Else
                MessageBox.Show("Gagal menyimpan")
            End If
        End If
    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.HeaderCell.Value = String.Format("{0}", row.Index + 1)
        Next
    End Sub
End Class