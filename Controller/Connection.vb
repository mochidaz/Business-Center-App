Imports System.Data.SqlClient
Module Account
    Public uname As String = vbNullString
    Public fname As String = vbNullString
    Public vUid As String = vbNullString
    Public ustatus As String = vbNullString
End Module

Module barangKeluar
    Public bKname As String = vbNullString
    Public bKhj As Integer = Nothing
    Public bKhb As Integer = Nothing
    Public bKid As Integer = Nothing
    Public bKuntung As Integer = Nothing
    Public bKrugi As Integer = Nothing
    Public bKstok As Integer = Nothing
    Public bKjml As Integer = Nothing
    Public bKstotal As Integer = Nothing
    Public pendapatan As Integer = Nothing
    Public keuntungan As Integer = Nothing
    Public kerugian As Integer = Nothing
End Module

Module editbarangKeluar
    Public ebKname As String = vbNullString
    Public ebKtgl As String = vbNullString
    Public ebKjam As String = vbNullString
    Public ebKhj As Integer = Nothing
    Public ebKhb As Integer = Nothing
    Public ebKjml As Integer = Nothing
    Public ebKuntung As Integer = Nothing
    Public ebKrugi As Integer = Nothing
    Public ebKid As Integer = Nothing
    Public ebKstok As Integer = Nothing
End Module

Module editBarang
    Public eBname As String = vbNullString
    Public eBhb As Integer = Nothing
    Public eBhj As Integer = Nothing
    Public eBstok As Integer = Nothing

End Module

Module editUser
    Public eUfname As String = vbNullString
    Public eUuname As String = vbNullString
    Public eUstatus As String = vbNullString
End Module

Public MustInherit Class BaseConnection
    Public Property conn As SqlConnection = New SqlConnection("Server = " & config()(0) & "; Database = " & config()(1) & "; Integrated Security = true")
    Public Property Cmd As SqlCommand

    Public Sub openConn()
        If conn.State = ConnectionState.Closed Then
            Debug.WriteLine($"DEBUG: {config()(0)}")
            conn.Open()
        End If
    End Sub

    Public Sub closeConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Class