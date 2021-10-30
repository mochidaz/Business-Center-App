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
        Timer1.Enabled = True

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
        LBL_JmlBK.Text = connect.total_brg_keluar()
        Jmlh_BT.Text = db_barang.get_total_stock()
        LBL_JmlBH.Text = db_barang.getBarangHabis()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Jmlh_BT_Click(sender As Object, e As EventArgs) Handles Jmlh_BT.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LBL_JmlBK.Click

    End Sub

    Private Sub PNL_BKLIST_Paint(sender As Object, e As PaintEventArgs) Handles PNL_BKLIST.Paint

    End Sub
End Class