Imports System.Data.SqlClient
Public Class DBBarangKeluar
    Inherits BaseConnection
    Public Function selectBarang_id(id_barang As Integer)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE id_barang = '" & id_barang & "'", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using table = New DataTable
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("Error Select Barang from Id barang")
                    Return Status.DataError
                Else
                    bKname = table.Rows(0)("nama_barang")
                    bKhb = table.Rows(0)("harga_beli")
                    bKhj = table.Rows(0)("harga_jual")
                    bKstok = table.Rows(0)("stok")
                    Return Status.Success
                End If
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function selectBarang_name(nama_barang As String)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE nama_barang = '" & nama_barang & "'", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using table = New DataTable
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("Error Select Barang from nama barang")
                    Return Status.DataError
                Else
                    bKid = table.Rows(0)("id_barang")
                    bKhb = table.Rows(0)("harga_beli")
                    bKhj = table.Rows(0)("harga_jual")
                    bKstok = table.Rows(0)("stok")
                    Return Status.Success
                End If
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function TambahLaporanBK(nota_keluar As String, id_barang As Integer, jumlah As Integer, subtotal As Integer, uid As Integer, keuntungan As Integer, kerugian As Integer, stok As Integer)
        If LaporanExist(nota_keluar) = False Then
            If jumlah <= bKstok Then
                Cmd = New SqlCommand("INSERT INTO tbl_barang_keluar (no_nota_keluar, id_barang, jumlah, subtotal, tanggal, uid, keuntungan, kerugian)
                                  VALUES ('" & nota_keluar & "','" & id_barang & "','" & jumlah & "','" & subtotal & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm") & "','" & uid & "','" & keuntungan & "','" & kerugian & "')", Conn)
                Call openConn()
                Try
                    If MessageBox.Show("Yakin ingin menyimpan laporan tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                        Exit Function
                    Else
                        Cmd.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    Call closeConn()
                    Debug.WriteLine("Error tambah laporan")
                    Return Status.DataIncomplete
                End Try
                Call closeConn()
                penguranganStok(id_barang, stok, jumlah)
                Return Status.Success
            Else
                Return Status.StokBarangKosong
            End If
        Else
            Return Status.LaporanExist
        End If
    End Function

    Public Function EditLaporanBK()

    End Function

    Public Function DeleteLaporanBK(no_nota_keluar As String, id_barang As Integer, stokbrg As Integer, jmlkeluar As Integer)
        Cmd = New SqlCommand("DELETE FROM tbl_barang_keluar WHERE no_nota_keluar = '" & no_nota_keluar & "'", Conn)
        Try
            If MessageBox.Show("Yakin ingin menghapus Laporan Barang Keluar tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Function
            Else
                Call openConn()
                Cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Call closeConn()
            Debug.WriteLine("Failed to delete laporan barang keluar!!")
            Return Status.DataIncomplete
        End Try
        Call closeConn()
        pengembalianStok(id_barang, stokbrg, jmlkeluar)
        Return Status.Success
    End Function

    Public Function LaporanExist(nota_keluar As String)
        Using Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang_keluar WHERE no_nota_keluar = '" & nota_keluar & "'", Conn)
            Call openConn()
            Dim result = Cmd.ExecuteScalar()
            If Convert.ToInt32(result) = 0 Then
                Return False
            Else
                Return True
            End If
        End Using
        Call closeConn()
    End Function

    Public Function searchLPBK(nama_barang As String)
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.no_nota_keluar, tbl_barang.nama_barang, tbl_barang.harga_beli, tbl_barang.harga_jual, 
                              tbl_barang_keluar.jumlah, tbl_barang_keluar.subtotal, tbl_barang_keluar.keuntungan, tbl_barang_keluar.kerugian, 
                              tbl_barang_keluar.tanggal, tbl_user.fullname 
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang 
                              JOIN tbl_user ON tbl_barang_keluar.uid = tbl_user.uid
                              WHERE tbl_barang.nama_barang LIKE '%" + nama_barang + "%'", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function penguranganStok(id_barang As Integer, stokbrg As Integer, jmlkeluar As Integer)
        Cmd = New SqlCommand("UPDATE tbl_barang SET stok = '" & stokbrg - jmlkeluar & "' WHERE id_barang = '" & id_barang & "' ", Conn)
        Try
            Call openConn()
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine("Error pengurangan stok!!")
            Call closeConn()
        End Try
        Call closeConn()
        Debug.WriteLine("Succes pengurangan stok!!")
        Return Status.Success
    End Function

    Public Function pengembalianStok(id_barang As Integer, stokbrg As Integer, jmlkeluar As Integer)
        Cmd = New SqlCommand("UPDATE tbl_barang SET stok = '" & stokbrg + jmlkeluar & "' WHERE id_barang = '" & id_barang & "' ", Conn)
        Try
            Call openConn()
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine("Error pengembalian stok!!")
            Call closeConn()
        End Try
        Call closeConn()
        Debug.WriteLine("Succes pengembalian stok!!")
        Return Status.Success
    End Function

    Public Function SelectToTable()
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.no_nota_keluar, tbl_barang.nama_barang, tbl_barang.harga_beli, tbl_barang.harga_jual, 
                              tbl_barang_keluar.jumlah, tbl_barang_keluar.subtotal, tbl_barang_keluar.keuntungan, tbl_barang_keluar.kerugian, 
                              tbl_barang_keluar.tanggal, tbl_user.fullname 
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang 
                              JOIN tbl_user ON tbl_barang_keluar.uid = tbl_user.uid", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function getinfobrgkluar(no_nota_keluar As String)
        Cmd = New SqlCommand("SELECT tbl_barang.nama_barang, tbl_barang.harga_beli, tbl_barang.harga_jual, tbl_barang_keluar.jumlah, tbl_barang_keluar.tanggal,
                              tbl_barang.id_barang, tbl_barang.stok
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang 
                              WHERE no_nota_keluar = '" & no_nota_keluar & "'", Conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using table = New DataTable
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("Error Select Barang from nota keluar")
                    Return Status.DataError
                Else
                    ebKname = table.Rows(0)("nama_barang")
                    ebKhb = table.Rows(0)("harga_beli")
                    ebKhj = table.Rows(0)("harga_jual")
                    ebKjml = table.Rows(0)("jumlah")
                    ebKtgl = table.Rows(0)("tanggal")
                    ebKid = table.Rows(0)("id_barang")
                    ebKstok = table.Rows(0)("stok")
                    Return Status.Success
                End If
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function totalPendapatan()
        Cmd = New SqlCommand("SELECT SUM(subtotal) FROM tbl_barang_keluar", Conn)
        Call openConn()
        Dim rd = Cmd.ExecuteReader
        rd.Read()
        If (rd.Item(0) IsNot DBNull.Value) Then
            pendapatan = rd.GetInt32(0)
        Else
            pendapatan = Nothing
        End If
        Call closeConn()
        Return pendapatan
    End Function

    Public Function totalKeuntungan()
        Cmd = New SqlCommand("SELECT SUM(keuntungan) FROM tbl_barang_keluar", Conn)
        Call openConn()
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                keuntungan = rd.GetInt32(0)
            Else
                keuntungan = Nothing
            End If
        End While
        Call closeConn()
        Return keuntungan
    End Function

    Public Function totalKerugian()
        Cmd = New SqlCommand("SELECT SUM (kerugian) FROM tbl_barang_keluar", Conn)
        Call openConn()
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                kerugian = rd.GetInt32(0)
            Else
                kerugian = Nothing
            End If
        End While
        Call closeConn()
        Return kerugian
    End Function

    Public Function total_brg_keluar()
        openConn()
        Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang_keluar", Conn)
        Dim val = Cmd.ExecuteScalar()
        closeConn()
        If IsDBNull(val) Then
            Return 0
        Else
            Return val
        End If
    End Function

    Public Function restore_stock(nota, stok_edit)
        openConn()
        Cmd = New SqlCommand("SELECT id_barang FROM tbl_barang_keluar WHERE no_nota_keluar = @nota", Conn)
        Cmd.Parameters.Add("@nota", SqlDbType.VarChar).Value = nota
        Dim rd = Cmd.ExecuteReader()
        Dim r As Integer
        While rd.Read()
            r = rd.GetInt32(0)
        End While
        closeConn()
        openConn()
        Cmd = New SqlCommand("SELECT stok FROM tbl_barang WHERE id_barang = @id", Conn)
        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = r
        Dim stok_sekarang = Cmd.ExecuteScalar()
        closeConn()
        openConn()
        Cmd = New SqlCommand($"SELECT jumlah FROM tbl_barang_keluar WHERE no_nota_keluar = @nota", Conn)
        Cmd.Parameters.Add("@nota", SqlDbType.VarChar).Value = nota
        Dim jumlah_keluar = Cmd.ExecuteScalar()
        closeConn()
        openConn()
        Cmd = New SqlCommand($"UPDATE tbl_barang SET stok = @stok WHERE id_barang = @id", Conn)
        Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok_sekarang + jumlah_keluar
        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = r
        Cmd.ExecuteNonQuery()
        closeConn()
        openConn()
        Cmd = New SqlCommand("SELECT stok FROM tbl_barang WHERE id_barang = @id", Conn)
        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = r
        Dim stok_kemudian = Cmd.ExecuteScalar()
        closeConn()
        openConn()
        Cmd = New SqlCommand($"UPDATE tbl_barang SET stok = @stok WHERE id_barang = @id", Conn)
        Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok_kemudian - Val(stok_edit)
        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = r
        Cmd.ExecuteNonQuery()
        closeConn()
        openConn()
        Cmd = New SqlCommand("UPDATE tbl_barang_keluar SET jumlah = @stok WHERE no_nota_keluar = @nota", Conn)
        Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = Val(stok_edit)
        Cmd.Parameters.Add("@nota", SqlDbType.VarChar).Value = nota
        Cmd.ExecuteNonQuery()
        closeConn()
        Return Status.Success
    End Function
End Class
