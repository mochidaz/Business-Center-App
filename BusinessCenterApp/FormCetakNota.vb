Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormCetakNota

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub FormCetakNota_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TB_NoNota.Text = Nothing
        CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim crypt As New ReportDocument
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New ReportNota
            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldDefinition As ParameterFieldDefinition
            Dim crParameterValues As New ParameterValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue
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
            If TB_NoNota.Text <> "" Then
                crParameterDiscreteValue.Value = TB_NoNota.Text
                crParameterFieldDefinitions = crypt.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("noNota")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                CrystalReportViewer1.ReportSource = crypt
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.RefreshReport()
            Else
                    MessageBox.Show("Harap untuk mengisi no nota terlebih dahulu!!")
            End If

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