Imports System.IO
Imports Guna.UI2.WinForms

Module utils
    Public ReadOnly ValidChars As String =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

    Public ReadOnly ValidCharsWithSpaceNoNum As String =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "

    Private path As String = ".\config.conf"

    Public jum = 0

    Public Function config()
        Dim dictionary = New Dictionary(Of String, String)
        Try
            Using Reader As New StreamReader(path)
                While Reader.Peek <> -1
                    Dim splitter = Reader.ReadLine().Trim().Split("=")
                    Dim one = splitter(0).Trim()
                    Dim two = splitter(1).Trim()
                    dictionary.Add(one, two)
                End While
            End Using
        Catch ex As Exception
            MsgBox("File config.conf tidak ditemukan!!")
            BusinessCenter.Close()
        End Try
        Debug.WriteLine(dictionary.ContainsValue("penjualan_db"))
        Debug.WriteLine(dictionary.ContainsKey("SERVER"))
        Dim d = New List(Of String)
        For Each kvp As KeyValuePair(Of String, String) In dictionary
            d.Add(kvp.Value)
        Next
        Return d
    End Function

    Public Function is_empty(frm As Form)
        Dim list = New List(Of Control)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                If String.IsNullOrWhiteSpace(Control.Text) Or String.IsNullOrEmpty(Control.Text) Then
                    list.Add(Control)
                End If
            End If
        Next Control
        If list.Count() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = Nothing
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = Nothing
            End If
            If TypeOf ctrl Is Guna2TextBox Then
                CType(ctrl, Guna2TextBox).Text = Nothing
            End If
            If TypeOf ctrl Is Guna2ComboBox Then
                CType(ctrl, Guna2ComboBox).Text = Nothing
            End If
        Next ctrl
    End Sub

    Public Function emptyTextBox(frm As Form)
        Dim emptyTextBoxes =
            From txt In frm.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name

        Dim gunaemptyTextBoxes =
            From txt In frm.Controls.OfType(Of Guna2TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name

        If emptyTextBoxes.Any Or gunaemptyTextBoxes.Any Then
            MessageBox.Show("Harap isi semua kolom form!!")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function formatUang(Text As Guna2TextBox)
        If Len(Text.Text) > 0 Then
            Text.Text = FormatCurrency(CDbl(Text.Text), 0)
            Dim x As Integer = Text.SelectionStart.ToString
            If x = 0 Then
                Text.SelectionStart = Len(Text.Text)
                Text.SelectionLength = 0
            Else
                Text.SelectionStart = x
                Text.SelectionLength = 0
            End If
        End If
    End Function

End Module
