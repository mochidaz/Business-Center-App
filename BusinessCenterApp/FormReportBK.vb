Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormReportBK
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim crypt As New ReportDocument
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New ReportLaporanBK
            crypt = laporan
            With crconnectioninfo
                .ServerName = "ZAPC\SQLEXPRESS"
                .DatabaseName = "db_apk"
                .IntegratedSecurity = "true"
            End With
            crtables = crypt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            CrystalReportViewer1.SelectionFormula = "({tbl_barang_keluar.tanggal})= date ('" & tanggal.Text & "')"
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
            Debug.WriteLine(tanggal.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CrystalReportViewer1.ExportReport()
    End Sub

    Private Sub FormReportBK_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        CrystalReportViewer1.ReportSource = Nothing
    End Sub
End Class