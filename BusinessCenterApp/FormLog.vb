Imports System.ComponentModel

Public Class FormLog
    Dim connect As New Log

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormLogEditLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountclick()
    End Sub

#Region "Show Table"

    Sub showtblacc()
        Dim linfo = connect.logAccSemua(btn_account)
        Dim table As New DataTable
        For Each table In linfo.tables
            dgv.DataSource = table
        Next
        sorttbl()
    End Sub

    Sub showtblbrg()
        Dim linfo = connect.logBrgSemua(btn_barang)
        Dim table As New DataTable
        For Each table In linfo.tables
            dgv.DataSource = table
        Next
        sorttbl()
    End Sub

    Sub showtbllpbk()
        Dim linfo = connect.logLpbkSemua(btn_lpbk)
        Dim table As New DataTable
        For Each table In linfo.tables
            dgv.DataSource = table
        Next
        sorttbl()
    End Sub

    Sub showtbldatus()
        Dim linfo = connect.logDataUserSemua(btn_datus)
        Dim table As New DataTable
        For Each table In linfo.tables
            dgv.DataSource = table
        Next
        sorttbl()
    End Sub

#End Region

#Region "Click"
    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        accountclick()
    End Sub

    Private Sub btn_barang_Click(sender As Object, e As EventArgs) Handles btn_barang.Click
        barangclick()
    End Sub

    Private Sub btn_lpbk_Click(sender As Object, e As EventArgs) Handles btn_lpbk.Click
        lpbkclick()
    End Sub

    Private Sub btn_datus_Click(sender As Object, e As EventArgs) Handles btn_datus.Click
        datusclick()
    End Sub

    Sub accountclick()
        TB_Search.Clear()
        showtblacc()
        btn_account.Checked = True
        btn_account.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_barang.Checked = False
        btn_barang.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_lpbk.Checked = False
        btn_lpbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_datus.Checked = False
        btn_datus.CustomBorderThickness = New Padding(0, 0, 0, 2)
        rb1.Text = "Login"
        rb2.Text = "Register"
        rb3.Visible = False
        rb2.Location = New Point(181, 115)
        rb3.Location = New Point(255, 115)
        rb0.Checked = True
    End Sub

    Sub barangclick()
        TB_Search.Clear()
        showtblbrg()
        btn_barang.Checked = True
        btn_barang.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_lpbk.Checked = False
        btn_lpbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_account.Checked = False
        btn_account.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_datus.Checked = False
        btn_datus.CustomBorderThickness = New Padding(0, 0, 0, 2)
        rb1.Text = "Tambah"
        rb2.Text = "Edit"
        rb3.Text = "Delete"
        rb3.Visible = True
        rb2.Location = New Point(191, 115)
        rb3.Location = New Point(245, 115)
        rb0.Checked = True
    End Sub

    Sub lpbkclick()
        TB_Search.Clear()
        showtbllpbk()
        btn_lpbk.Checked = True
        btn_lpbk.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_barang.Checked = False
        btn_barang.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_account.Checked = False
        btn_account.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_datus.Checked = False
        btn_datus.CustomBorderThickness = New Padding(0, 0, 0, 2)
        rb1.Text = "Tambah"
        rb2.Text = "Edit"
        rb3.Text = "Delete"
        rb3.Visible = True
        rb2.Location = New Point(191, 115)
        rb3.Location = New Point(245, 115)
        rb0.Checked = True
    End Sub

    Sub datusclick()
        TB_Search.Clear()
        showtbldatus()
        btn_datus.Checked = True
        btn_datus.CustomBorderThickness = New Padding(0, 0, 0, 3)
        btn_account.Checked = False
        btn_account.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_barang.Checked = False
        btn_barang.CustomBorderThickness = New Padding(0, 0, 0, 2)
        btn_lpbk.Checked = False
        btn_lpbk.CustomBorderThickness = New Padding(0, 0, 0, 2)
        rb1.Text = "Edit"
        rb2.Text = "Delete"
        rb3.Visible = False
        rb2.Location = New Point(175, 115)
        rb3.Location = New Point(241, 115)
        rb0.Checked = True
    End Sub

#End Region

#Region "rb filter"

    Private Sub rb0_CheckedChanged(sender As Object, e As EventArgs) Handles rb0.CheckedChanged
        If btn_account.Checked = True Then
            showtblacc()
        ElseIf btn_barang.Checked = True Then
            showtblbrg()
        ElseIf btn_lpbk.Checked = True Then
            showtbllpbk()
        ElseIf btn_datus.Checked = True Then
            showtbldatus()
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If btn_account.Checked = True Then
            Dim linfo = connect.logAccFilter(btn_account, rb1)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_barang.Checked = True Then
            Dim linfo = connect.logBrgFilter(btn_barang, rb1)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_lpbk.Checked = True Then
            Dim linfo = connect.logLpbkFilter(btn_lpbk, rb1)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_datus.Checked = True Then
            Dim linfo = connect.logDataUserFilter(btn_datus, rb1)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If btn_account.Checked = True Then
            Dim linfo = connect.logAccFilter(btn_account, rb2)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_barang.Checked = True Then
            Dim linfo = connect.logBrgFilter(btn_barang, rb2)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_lpbk.Checked = True Then
            Dim linfo = connect.logLpbkFilter(btn_lpbk, rb2)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_datus.Checked = True Then
            Dim linfo = connect.logDataUserFilter(btn_datus, rb2)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If btn_barang.Checked = True Then
            Dim linfo = connect.logBrgFilter(btn_barang, rb3)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        ElseIf btn_lpbk.Checked = True Then
            Dim linfo = connect.logLpbkFilter(btn_lpbk, rb3)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
            TB_Search.Clear()
            sorttbl()
        End If
    End Sub

#End Region

#Region "Etc"

    Sub sorttbl()
        If dgv.Rows.Count > 0 Then
            dgv.Sort(dgv.Columns(0), ListSortDirection.Descending)
        End If
    End Sub

    Private Sub dgv_bk_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv.DataBindingComplete
        For Each row As DataGridViewRow In dgv.Rows
            row.HeaderCell.Value = String.Format("{0}", row.Index + 1)
        Next
        dgv.ClearSelection()
    End Sub

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        If TB_Search.Text.Length > 0 Then
            Dim linfo = connect.logSearch(TB_Search.Text)
            Dim table As New DataTable
            For Each table In linfo.tables
                dgv.DataSource = table
            Next
        Else
            If btn_account.Checked = True Then
                accountclick()
            ElseIf btn_barang.Checked = True Then
                barangclick()
            ElseIf btn_lpbk.Checked = True Then
                lpbkclick()
            End If
        End If
    End Sub

    Private Sub BTN_Refreshtbl_Click(sender As Object, e As EventArgs) Handles BTN_Refreshtbl.Click
        TB_Search.Clear()
        accountclick()
    End Sub

#End Region

End Class