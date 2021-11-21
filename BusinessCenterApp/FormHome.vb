Imports System.Windows.Forms

Public Class FormHome

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Dim connect As New AuthController
    Dim sessionFname = fname
    Dim sessionUname = uname
    Dim sessionStatus = ustatus

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DboardShow()
        pnl_sbmlap.Visible = False
        LBL_FNAME.Text = fname
        LBL_STATUS.Text = ustatus
        DBoard_SELECTED.Visible = True
        DBarang_SELECTED.Visible = False
        BMasuk_SELECTED.Visible = False
        BKeluar_SELECTED.Visible = False
        Log_SELECTED.Visible = False
        BTN_LAPORAN.Enabled = True
        BTN_DASHBOARD.BackColor = Color.FromArgb(15, 0, 53)
        BTN_DATABARANG.BackColor = Color.FromArgb(53, 40, 91)
        BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
        BTN_Log.BackColor = Color.FromArgb(53, 40, 91)
        Label1.Text = "Dashboard"
        sessiontimer.Enabled = True
        datetimer.Enabled = True
        Label1.Focus()
        If ustatus = "admin" Then
            EditUserToolStripMenuItem.Visible = True
            BTN_Log.Visible = True
        Else
            EditUserToolStripMenuItem.Visible = False
            BTN_Log.Visible = False
        End If
    End Sub

#Region "Menu Click"

    Private Sub BTN_DASHBOARD_Click(sender As Object, e As EventArgs) Handles BTN_DASHBOARD.Click
        DBoard_SELECTED.Visible = True
        DBarang_SELECTED.Visible = False
        BMasuk_SELECTED.Visible = False
        BKeluar_SELECTED.Visible = False
        Log_SELECTED.Visible = False
        BTN_LAPORAN.Enabled = True
        BTN_DASHBOARD.BackColor = Color.FromArgb(15, 0, 53)
        BTN_DATABARANG.BackColor = Color.FromArgb(53, 40, 91)
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
        BTN_Log.BackColor = Color.FromArgb(53, 40, 91)
        FormDBarangContent.Close()
        FormBMasukContent.Close()
        FormBKeluarContent.Close()
        FormLog.Close()
        DboardShow()
        Label1.Text = "Dashboard"
    End Sub

    Private Sub BTN_DATABARANG_Click(sender As Object, e As EventArgs) Handles BTN_DATABARANG.Click
        DBoard_SELECTED.Visible = False
        DBarang_SELECTED.Visible = True
        BMasuk_SELECTED.Visible = False
        BKeluar_SELECTED.Visible = False
        Log_SELECTED.Visible = False
        BTN_LAPORAN.Enabled = True
        BTN_DASHBOARD.BackColor = Color.FromArgb(53, 40, 91)
        BTN_DATABARANG.BackColor = Color.FromArgb(15, 0, 53)
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
        BTN_Log.BackColor = Color.FromArgb(53, 40, 91)
        FormDBoardContent.Close()
        FormBMasukContent.Close()
        FormBKeluarContent.Close()
        FormLog.Close()
        DbarangShow()
        Label1.Text = "Data Barang"
    End Sub

    Private Sub BTN_LAPORAN_Click(sender As Object, e As EventArgs) Handles BTN_LAPORAN.Click
        ShowSubMenuLap()
        If DBoard_SELECTED.Visible = True Then
            BTN_DASHBOARD.BackColor = Color.FromArgb(15, 0, 53)
        ElseIf DBarang_SELECTED.Visible = True Then
            BTN_DATABARANG.BackColor = Color.FromArgb(15, 0, 53)
        End If
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
    End Sub

    Private Sub BTN_BRGMASUK_Click(sender As Object, e As EventArgs) Handles BTN_BRGMASUK.Click
        DBoard_SELECTED.Visible = False
        DBarang_SELECTED.Visible = False
        BMasuk_SELECTED.Visible = True
        BKeluar_SELECTED.Visible = False
        Log_SELECTED.Visible = False
        BTN_LAPORAN.Enabled = False
        BTN_DASHBOARD.BackColor = Color.FromArgb(53, 40, 91)
        BTN_DATABARANG.BackColor = Color.FromArgb(53, 40, 91)
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(15, 0, 53)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
        BTN_Log.BackColor = Color.FromArgb(53, 40, 91)
        FormDBoardContent.Close()
        FormDBarangContent.Close()
        FormBKeluarContent.Close()
        FormLog.Close()
        BmasukShow()
        Label1.Text = "Barang Masuk"
    End Sub

    Private Sub BTN_BRGKELUAR_Click(sender As Object, e As EventArgs) Handles BTN_BRGKELUAR.Click
        DBoard_SELECTED.Visible = False
        DBarang_SELECTED.Visible = False
        BMasuk_SELECTED.Visible = False
        BKeluar_SELECTED.Visible = True
        Log_SELECTED.Visible = False
        BTN_LAPORAN.Enabled = False
        BTN_DASHBOARD.BackColor = Color.FromArgb(53, 40, 91)
        BTN_DATABARANG.BackColor = Color.FromArgb(53, 40, 91)
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(15, 0, 53)
        BTN_Log.BackColor = Color.FromArgb(53, 40, 91)
        FormDBoardContent.Close()
        FormDBarangContent.Close()
        FormBMasukContent.Close()
        FormLog.Close()
        BkeluarShow()
        Label1.Text = "Barang Keluar"
    End Sub

    Private Sub BTN_Log_Click(sender As Object, e As EventArgs) Handles BTN_Log.Click
        DBoard_SELECTED.Visible = False
        DBarang_SELECTED.Visible = False
        BMasuk_SELECTED.Visible = False
        BKeluar_SELECTED.Visible = False
        Log_SELECTED.Visible = True
        BTN_LAPORAN.Enabled = True
        BTN_DASHBOARD.BackColor = Color.FromArgb(53, 40, 91)
        BTN_DATABARANG.BackColor = Color.FromArgb(53, 40, 91)
        If pnl_sbmlap.Visible = True Then
            BTN_LAPORAN.BackColor = Color.FromArgb(42, 30, 78)
        Else
            BTN_LAPORAN.BackColor = Color.FromArgb(53, 40, 91)
        End If
        BTN_BRGMASUK.BackColor = Color.FromArgb(35, 28, 58)
        BTN_BRGKELUAR.BackColor = Color.FromArgb(35, 28, 58)
        BTN_Log.BackColor = Color.FromArgb(15, 0, 53)
        FormDBoardContent.Close()
        FormDBarangContent.Close()
        FormBMasukContent.Close()
        FormBKeluarContent.Close()
        LogBrgShow()
        Label1.Text = "Log"
    End Sub

#End Region

    Sub HideSubMenuLap()
        If pnl_sbmlap.Visible = True Then
            pnl_sbmlap.Visible = False
        End If
    End Sub

    Sub ShowSubMenuLap()
        If pnl_sbmlap.Visible = False Then
            pnl_sbmlap.Visible = True
        Else
            pnl_sbmlap.Visible = False
        End If
    End Sub

    Sub DboardShow()
        FormDBoardContent.TopLevel = False
        PNL_CONTENT.Controls.Add(FormDBoardContent)
        FormDBoardContent.Show()
    End Sub

    Sub DbarangShow()
        FormDBarangContent.TopLevel = False
        PNL_CONTENT.Controls.Add(FormDBarangContent)
        FormDBarangContent.Show()
    End Sub

    Sub BmasukShow()
        FormBMasukContent.TopLevel = False
        PNL_CONTENT.Controls.Add(FormBMasukContent)
        FormBMasukContent.Show()
    End Sub

    Sub BkeluarShow()
        FormBKeluarContent.TopLevel = False
        PNL_CONTENT.Controls.Add(FormBKeluarContent)
        FormBKeluarContent.Show()
    End Sub

    Sub LogBrgShow()
        FormLog.TopLevel = False
        PNL_CONTENT.Controls.Add(FormLog)
        FormLog.Show()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        FormEditUser.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BusinessCenter.ClearPanel(Me)
        BusinessCenter.LoginShow()
        Debug.WriteLine(vUid)
        Debug.WriteLine(fname)
    End Sub

    Private Sub BTN_MENU_Click(sender As Object, e As EventArgs) Handles BTN_MENU.Click
        Label1.Focus()
        MENUSTRIP.Show(BTN_MENU, -124, BTN_MENU.Height)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        FormChangePassword.ShowDialog()
    End Sub

    Private Sub datetimer_Tick(sender As Object, e As EventArgs) Handles datetimer.Tick
        LBL_Date.Text = DateTime.Today.ToLongDateString & "
" & DateTime.Now.ToLongTimeString
    End Sub

    Private Sub sessiontimer_Tick(sender As Object, e As EventArgs) Handles sessiontimer.Tick
        connect.setFullname(vUid)
        connect.setUname(vUid)
        connect.setStatus(vUid)
        If sessionFname = fname And sessionUname = uname And sessionStatus = ustatus Then
        Else
            sessiontimer.Enabled = False
            FormEditUser.Close()
            MessageBox.Show("Data akun telah diganti, harap untuk melakukan sign in kembali")
            BusinessCenter.ClearPanel(Me)
            BusinessCenter.LoginShow()
        End If
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        FormReportBKHarian.ShowDialog()
    End Sub

    Private Sub BarangKeluarBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarBulananToolStripMenuItem.Click
        FormReportBKBulanan.ShowDialog()
    End Sub
End Class