Imports System.Globalization

Public Class FormDBoardContent
    Dim connect As New DBBarangKeluar
    Dim db_barang As New DBBarang

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub DBoardContent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Focus()
        Timer1.Enabled = True
        Guna2DataGridView1.ReadOnly = True
        Dim x = connect.newest_barang_keluar()
        Dim table As New DataTable
        For Each table In x.tables
            Guna2DataGridView1.DataSource = table
        Next
        fill_date()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
        pdptharian()
        pdptbulanan()
        lbl_bk.Text = connect.get_total_barang_keluar_harian()
        lbl_bt.Text = db_barang.get_total_stock()
        lbl_bh.Text = db_barang.getBarangHabis()

    End Sub

    Private Sub Guna2DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Guna2DataGridView1.CellFormatting
        Static counter As Integer = 0
        counter += 1
        Dim row = Guna2DataGridView1.Rows(e.RowIndex)
        If Not row.IsNewRow AndAlso e.ColumnIndex <> 0 Then
            Dim cell = row.Cells(0)
            cell.Value = (e.RowIndex + 1).ToString()
        End If
    End Sub

    Private Sub Guna2DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Guna2DataGridView1.DataBindingComplete
        Dim height As Integer = 0
        For Each dr As DataGridViewRow In Guna2DataGridView1.Rows
            height += dr.Height
        Next
        Guna2DataGridView1.Height = height
        Guna2DataGridView1.Columns(0).Width = 55
        Guna2DataGridView1.Columns(1).Width = 116
        Guna2DataGridView1.Columns(2).Width = 198
        Guna2DataGridView1.Columns(3).Width = 93
        Guna2DataGridView1.Columns(4).Width = 125
        Guna2DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Sub fill_date()
        PEND_cbbln.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthGenitiveNames.Take(12).ToList()
        PEND_cbbln.SelectedItem = DateTime.Now.ToString("MMMM")
        PEND_cbthn.DataSource = Enumerable.Range(2021, DateTime.Now.Year - 2021 + 1).ToList()
        PEND_cbthn.SelectedItem = DateTime.Now.Year
        PEND_date.Value = DateTime.Now
        PENG_cbbln.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthGenitiveNames.Take(12).ToList()
        PENG_cbbln.SelectedItem = DateTime.Now.ToString("MMMM")
        PENG_cbthn.DataSource = Enumerable.Range(2021, DateTime.Now.Year - 2021 + 1).ToList()
        PENG_cbthn.SelectedItem = DateTime.Now.Year
        PENG_date.Value = DateTime.Now
    End Sub

    Sub total()
        Dim bkinfo = connect.totalPendapatan And connect.totalKeuntungan And connect.totalKerugian
        If pendapatan = Nothing Then
            lbl_totpnd.Text = "0"
        Else
            lbl_totpnd.Text = pendapatan.ToString("#,###.00")
        End If
        If keuntungan = Nothing Then
            lbl_totkun.Text = "0"
        Else
            lbl_totkun.Text = keuntungan.ToString("#,###.00")
        End If
        If kerugian = Nothing Then
            lbl_totrugi.Text = "0"
        Else
            lbl_totrugi.Text = kerugian.ToString("#,###.00")
        End If
    End Sub

    Sub pdptbulanan()
        Dim pdpbln =
            connect.get_total_pendapatan_bulanan(PEND_cbthn.SelectedItem, DateTime.ParseExact(PEND_cbbln.SelectedItem, "MMMM", CultureInfo.CurrentCulture).Month) And
            connect.get_total_keuntungan_bulanan(PEND_cbthn.SelectedItem, DateTime.ParseExact(PEND_cbbln.SelectedItem, "MMMM", CultureInfo.CurrentCulture).Month) And
            connect.get_total_kerugian_bulanan(PENG_cbthn.SelectedItem, DateTime.ParseExact(PENG_cbbln.SelectedItem, "MMMM", CultureInfo.CurrentCulture).Month)
        If pendapatanB = Nothing Then
            LBL_PendapatanB.Text = "0"
        Else
            LBL_PendapatanB.Text = pendapatanB.ToString("#,###.00")
        End If
        If keuntunganB = Nothing Then
            lbl_kunbln.Text = "0"
        Else
            lbl_kunbln.Text = keuntunganB.ToString("#,###.00")
        End If
        If kerugianB = Nothing Then
            lbl_rugibln.Text = "0"
        Else
            lbl_rugibln.Text = kerugianB.ToString("#,###.00")
        End If
    End Sub

    Sub pdptharian()
        Dim pdphri = connect.get_total_pendapatan_harian(PEND_date.Text) And connect.get_total_keuntungan_harian(PEND_date.Text) And connect.get_total_kerugian_harian(PENG_date.Text)
        If pendapatanH = Nothing Then
            lbl_pendhar.Text = "0"
        Else
            lbl_pendhar.Text = pendapatanH.ToString("#,###.00")
        End If
        If keuntunganH = Nothing Then
            lbl_kunhari.Text = "0"
        Else
            lbl_kunhari.Text = keuntunganH.ToString("#,###.00")
        End If
        If kerugianH = Nothing Then
            lbl_rugihari.Text = "0"
        Else
            lbl_rugihari.Text = kerugianH.ToString("#,###.00")
        End If
    End Sub

End Class