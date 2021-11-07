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
        Label5.Text = connect.total_brg_keluar()
        Jmlh_BT.Text = db_barang.get_total_stock()
        Label3.Text = db_barang.getBarangHabis()
        Guna2DataGridView1.ReadOnly = True
        Dim x = connect.newest_barang_keluar()
        Dim table As New DataTable
        For Each table In x.tables
            Guna2DataGridView1.DataSource = table
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bkinfo = connect.totalPendapatan And connect.totalKeuntungan And connect.totalKerugian
        If pendapatan = Nothing Then
            LBL_PendapatanH.Text = "0"
        Else
            LBL_PendapatanH.Text = pendapatan.ToString("#,###.00")
        End If
        If keuntungan = Nothing Then
            lbl_keuntungan.Text = "0"
        Else
            lbl_keuntungan.Text = keuntungan.ToString("#,###.00")
        End If
        If kerugian = Nothing Then
            lbl_kerugian.Text = "0"
        Else
            lbl_kerugian.Text = kerugian.ToString("#,###.00")
        End If
        Label5.Text = connect.total_brg_keluar()
        Jmlh_BT.Text = db_barang.get_total_stock()
        Label3.Text = db_barang.getBarangHabis()
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

End Class