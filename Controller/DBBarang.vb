Imports System.Data.SqlClient
Public Class DBBarang
    Inherits BaseConnection

    Public Function TambahBarang(nama_barang As String, harga_beli As Integer, harga_jual As Integer, stok As Integer)
        If barang_exist(nama_barang) = False Then
            Cmd = New SqlCommand("INSERT INTO tbl_barang (nama_barang, harga_beli, harga_jual, stok) 
                                  VALUES ('" & nama_barang & "','" & harga_beli & "','" & harga_jual & "','" & stok & "')", Conn)
            Call openConn()
            Try
                If MessageBox.Show("Yakin ingin menambahkan barang tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    Exit Function
                Else
                    Cmd.ExecuteNonQuery()
                End If
            Catch ex As Exception
                Call closeConn()
                Return Status.DataIncomplete
            End Try
            Call closeConn()
            Return Status.Success
        Else
            Return Status.BarangExist
        End If
        Call closeConn()
    End Function

    Public Function DeleteBarang(id_barang As Integer)
        Cmd = New SqlCommand("DELETE FROM tbl_barang WHERE id_barang = @id_barang", Conn)
        Cmd.Parameters.Add("@id_barang", SqlDbType.Int).Value = id_barang
        Try
            If MessageBox.Show("Yakin ingin menghapus barang tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Function
            Else
                Call openConn()
                Cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Call closeConn()
            Debug.WriteLine("Failed to delete barang!!")
            Return Status.DataIncomplete
        End Try
        Call closeConn()
        IDBRGidentityreset()
        Return Status.Success
    End Function

    Public Function EditBarang(id_barang As Integer, nama_barang As String, harga_beli As Integer, harga_jual As Integer, stok As Integer)
        If nama_barang = eBname Or barang_exist(nama_barang) = False Then
            If nama_barang = eBname And harga_beli = eBhb And harga_jual = eBhj And stok = eBstok Then
                Return Status.NothingChanged
            Else
                Cmd = New SqlCommand("UPDATE tbl_barang 
                                      SET nama_barang = @nama_barang  , harga_beli = @harga_beli , harga_jual = @harga_jual , stok = @stok WHERE id_barang = @id_barang", Conn)
                Cmd.Parameters.Add("@id_barang", SqlDbType.Int).Value = id_barang
                Cmd.Parameters.Add("@nama_barang", SqlDbType.VarChar).Value = nama_barang
                Cmd.Parameters.Add("@harga_beli", SqlDbType.Int).Value = harga_beli
                Cmd.Parameters.Add("@harga_jual", SqlDbType.Int).Value = harga_jual
                Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok
                Try
                    If MessageBox.Show("Yakin ingin menyimpan perubahan pada barang tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
                        DialogResult.No Then
                        Exit Function
                    Else
                        Call openConn()
                        Cmd.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    Call closeConn()
                    Debug.WriteLine("Failed to edit barang!!")
                    Return Status.DataIncomplete
                End Try
                Call closeConn()
                Debug.WriteLine("succes edit barang!!")
                Return Status.Success
            End If
        Else
            Return Status.BarangExist
        End If
    End Function

    Public Function selectBarang(id_barang As Integer)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE id_barang = @id_barang", Conn)
        Cmd.Parameters.Add("@id_barang", SqlDbType.Int).Value = id_barang
        Using adapter = New SqlDataAdapter(Cmd)
            Using table = New DataTable
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("Error Select Barang from Id barang")
                    Return Status.DataError
                Else
                    eBname = table.Rows(0)("nama_barang")
                    eBhb = table.Rows(0)("harga_beli")
                    eBhj = table.Rows(0)("harga_jual")
                    eBstok = table.Rows(0)("stok")
                    Return Status.Success
                End If
            End Using
        End Using
    End Function

    Public Function barang_exist(nama_barang As String)
        Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang WHERE nama_barang = @nama_barang", Conn)
        Cmd.Parameters.Add("@nama_barang", SqlDbType.VarChar).Value = nama_barang
        Call openConn()
        Dim result = Cmd.ExecuteScalar()
        If Convert.ToInt32(result) = 0 Then
            Return False
        Else
            Return True
        End If
        Call closeConn()
    End Function

    'Public Function readBarang()
    '    Dim listid As New List(Of Integer)
    '    Dim listnm As New List(Of String)
    '    Dim listhb As New List(Of Integer)
    '    Dim listhj As New List(Of Integer)
    '    Dim liststk As New List(Of Integer)
    '    Cmd = New SqlCommand("SELECT * FROM tbl_barang", Conn)
    '    Call openConn()
    '    Using rd = Cmd.ExecuteReader
    '        While rd.Read()
    '            listid.Add(rd.GetInt32(0))
    '            listnm.Add(rd.GetString(1))
    '            listhb.Add(rd.GetInt32(2))                     USED ON FormDBarangContent_HARD // UNDONE // maybe usable next time
    '            listhj.Add(rd.GetInt32(3))
    '            liststk.Add(rd.GetInt32(4))
    '        End While
    '    End Using
    '    id_barang = listid.Select(Function(x) x.ToString()).ToArray()
    '    nama_barang = listnm.ToArray
    '    harga_beli = listhb.Select(Function(x) x.ToString()).ToArray()
    '    harga_jual = listhj.Select(Function(x) x.ToString()).ToArray()
    '    stok = liststk.Select(Function(x) x.ToString()).ToArray()
    '    Call closeConn()
    'End Function

    Public Function tblbarang()
        Cmd = New SqlCommand("SELECT * FROM tbl_barang", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function searchBarang(searchbox As String)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE nama_barang LIKE '%" + searchbox + "%' OR id_barang LIKE '%" + searchbox + "%'", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function IDBRGidentityreset()
        Call openConn()
        Dim objReader = New IO.StreamReader(".\IDBRGidentityreset.sql")
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = objReader.ReadToEnd
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine("reset id barang failed!!")
            Return Status.FiledToResetUid
        End Try
        Call closeConn()
        Debug.WriteLine("reset id barang success!!")
        Return Status.Success
    End Function

    Public Function get_total_stock()
        openConn()
        Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang WHERE stok > 0", Conn)
        Dim val As Integer
        Try
            val = Cmd.ExecuteScalar()
        Catch ex As Exception
            closeConn()
            Return Status.DataError
        End Try
        closeConn()
        If val < 1 Then
            Return 0
        Else
            Return val
        End If
    End Function

    Public Function getBarangHabis()
        openConn()
        Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang WHERE stok = 0", Conn)
        Dim val As Integer
        Try
            val = Cmd.ExecuteScalar()
        Catch ex As Exception
            closeConn()
            Return Status.DataError
        End Try
        closeConn()
        If val < 1 Then
            Return 0
        Else
            Return val
        End If
    End Function

End Class
'Module varbar
'    Public id_barang As String()
'    Public nama_barang As String()
'    Public harga_beli As String()                       USED ON FormDBarangContent_HARD (maybe?) // UNDONE // maybe usable next time
'    Public harga_jual As String()
'    Public stok As String()
'End Module


