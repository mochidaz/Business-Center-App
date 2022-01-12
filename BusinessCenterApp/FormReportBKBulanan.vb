Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormReportBKBulanan

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormReportBKBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_bln.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthGenitiveNames.Take(12).ToList()
        CB_bln.SelectedItem = DateTime.Now.ToString("MMMM")
        CB_thn.DataSource = Enumerable.Range(2021, DateTime.Now.Year - 2021 + 1).ToList()
        CB_thn.SelectedItem = DateTime.Now.Year
    End Sub

    Private Sub FormReportBKBulanan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim crypt As New ReportDocument
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New ReportLaporanBKBulanan
            crypt = laporan
            With crconnectioninfo
                .ServerName = config()(0)
                .DatabaseName = config()(1)
                .IntegratedSecurity = "true"
            End With
            crtables = crypt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            CrystalReportViewer1.SelectionFormula = "MONTH({tbl_barang_keluar.tanggal})= 
                                                    " & Val(DateTime.ParseExact(CB_bln.SelectedItem, "MMMM", CultureInfo.CurrentCulture).Month) &
                                                    " And Year({tbl_barang_keluar.tanggal}) = " & Val(CB_thn.Text) & ""
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CrystalReportViewer1.ExportReport()
    End Sub
End Class