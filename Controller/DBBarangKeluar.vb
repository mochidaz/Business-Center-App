Imports System.Data.SqlClient
Public Class DBBarangKeluar
    Inherits BaseConnection

#Region "fungsi pada buat laporan barang keluar"

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

    Public Function TambahLaporanBK(dgv As DataGridView, nota As String, uid As Integer)
        ' dgv cell 0 = id barang
        ' dgv cell 1 = nama barang
        ' dgv cell 2 = harga beli
        ' dgv cell 3 = harga jual
        ' dgv cell 4 = jumlah
        ' dgv cell 5 = subtotal
        ' dgv cell 6 = keuntungan
        ' dgv cell 7 = kerugian
        For b As Integer = 0 To dgv.Rows.Count - 1
            Cmd = New SqlCommand("INSERT INTO tbl_barang_keluar (no_nota_keluar, id_barang, jumlah, subtotal, tanggal, 
                                                                 uid, keuntungan, kerugian, jam, harga_beli, harga_jual)
                                  VALUES 
                                  ('" & nota & "','" & dgv.Rows(b).Cells(0).Value & "',
                                   '" & dgv.Rows(b).Cells(4).Value & "','" & dgv.Rows(b).Cells(5).Value & "',
                                   '" & Date.Now.ToString("yyyy/MM/dd") & "','" & uid & "','" & dgv.Rows(b).Cells(6).Value & "',
                                   '" & dgv.Rows(b).Cells(7).Value & "','" & TimeOfDay.ToString("HH:mm:ss") & "',
                                   '" & dgv.Rows(b).Cells(2).Value & "','" & dgv.Rows(b).Cells(3).Value & "')", conn)
            Try
                openConn()
                Cmd.ExecuteNonQuery()
            Catch ex As Exception
                closeConn()
                Debug.WriteLine("Error tambah laporan")
                Return Status.DataIncomplete
            End Try
            closeConn()
            penguranganStok(dgv.Rows(b).Cells(0).Value, Val(dgv.Rows(b).Cells(4).Value))
            Debug.WriteLine(dgv.Rows(b).Cells(0).Value)
        Next
        Return Status.Success
    End Function

#End Region

#Region "fungsi pada edit / delete laporan barang keluar"

    Public Function EditLaporanBK(dgv As DataGridView, nota As String)
        Dim a
        Dim list As New ArrayList
        For b As Integer = 0 To dgv.Rows.Count - 1
            a = tambahkurangStok(dgv.Rows(b).Cells(0).Value, nota, dgv.Rows(b).Cells(4).Value, dgv.Rows(b).Cells(5).Value,
                             dgv.Rows(b).Cells(6).Value, dgv.Rows(b).Cells(7).Value)
        Next

        If a <> Status.StokBarangKosong Then
            If a > 0 Then
                Return Status.Success
            Else
                Return Status.DataIncomplete
            End If
        Else
            Return Status.StokBarangKosong
        End If
    End Function

    Public Function DeleteBarangLPBK(nota As String, idbrg As Integer, dgv As DataGridView)
        Cmd = New SqlCommand("DELETE FROM tbl_barang_keluar WHERE no_nota_keluar = '" & nota & "' AND id_barang = '" & idbrg & "'", conn)
        Try
            If MessageBox.Show("Yakin ingin menghapus barang yang dipilih?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Function
            Else
                Call openConn()
                Cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Call closeConn()
            Debug.WriteLine("Failed to delete barang in lpbk!!")
            Return Status.DataIncomplete
        End Try
        Call closeConn()
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells(0).Value.ToString = idbrg Then
                pengembalianStok(idbrg, Val(row.Cells(4).Value))
            End If
        Next
        Return Status.Success
    End Function

    Public Function DeleteLaporanBK(nota As String, dgv As DataGridView)
        Cmd = New SqlCommand("DELETE FROM tbl_barang_keluar WHERE no_nota_keluar = '" & nota & "'", conn)
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
        For b As Integer = 0 To dgv.Rows.Count - 1
            pengembalianStok(dgv.Rows(b).Cells(0).Value, Val(dgv.Rows(b).Cells(4).Value))
        Next
        Return Status.Success
    End Function

    Public Function showdgvbk_nota(nota As String, dgv As DataGridView)
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.id_barang, tbl_barang.nama_barang, tbl_barang_keluar.harga_beli, 
                                     tbl_barang_keluar.harga_jual, tbl_barang_keluar.jumlah, tbl_barang_keluar.subtotal,
                                     tbl_barang_keluar.keuntungan, tbl_barang_keluar.kerugian, tbl_barang_keluar.tanggal,
                                     tbl_barang_keluar.jam 
                              FROM tbl_barang_keluar
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang
                              WHERE no_nota_keluar = '" & nota & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    Debug.WriteLine("Error Select Barang from nota keluar")
                    Return Status.DataError
                Else
                    ebKtgl = ds.Tables(0).Rows(0)("tanggal")
                    ebKjam = ds.Tables(0).Rows(0)("jam").ToString
                    For Each row As DataRow In ds.Tables(0).Rows
                        dgv.Rows.Add(row(columnName:="id_barang"), row(columnName:="nama_barang"),
                                     row(columnName:="harga_beli"), row(columnName:="harga_jual"),
                                     row(columnName:="jumlah"), row(columnName:="subtotal"),
                                     row(columnName:="keuntungan"), row(columnName:="kerugian"))
                    Next
                    closeConn()
                    Return Status.Success
                End If
            End Using
        End Using
        closeConn()
    End Function

    Public Function showinfbk_idbrg(nota As String, idbrg As Integer, dgv As DataGridView)
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.harga_beli, tbl_barang_keluar.harga_jual, tbl_barang.stok 
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang
                              WHERE tbl_barang_keluar.no_nota_keluar = '" & nota & "' AND tbl_barang_keluar.id_barang = '" & idbrg & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using table = New DataTable
                openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("Error show info barang from nota and id barang")
                    Return Status.DataError
                Else
                    ebKhb = table.Rows(0)("harga_beli")
                    ebKhj = table.Rows(0)("harga_jual")
                    ebKstok = table.Rows(0)("stok")
                    Return Status.Success
                End If
            End Using
        End Using
        closeConn()
    End Function
#End Region

#Region "Fungsi perubahan stok"

    Public Function tambahkurangStok(idbrg As Integer, nota As String, stok_edit As Integer, subtotal As Integer, keuntungan As Integer, kerugian As Integer)
        openConn()
        Cmd = New SqlCommand("SELECT stok FROM tbl_barang WHERE id_barang = @id_barang", conn)
        Cmd.Parameters.Add("@id_barang", SqlDbType.Int).Value = idbrg
        Dim stok_sekarang = Cmd.ExecuteScalar()
        closeConn()
        openConn()
        Cmd = New SqlCommand("SELECT jumlah FROM tbl_barang_keluar WHERE no_nota_keluar = '" & nota & "' AND id_barang = @id_barang", conn)
        Cmd.Parameters.Add("@id_barang", SqlDbType.Int).Value = idbrg
        Dim jumlah_keluar = Cmd.ExecuteScalar()
        closeConn()
        If stok_edit > stok_sekarang + jumlah_keluar Then
            Return Status.StokBarangKosong
        Else
            ' Menentukan apakah jumlah keluar tidak sama dengan stok edit lebih dari satu
            If jumlah_keluar <> stok_edit Then
                jum += 1
            End If
            openConn()
            Cmd = New SqlCommand("UPDATE tbl_barang SET stok = @stok WHERE id_barang = @id", conn)
            Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok_sekarang + jumlah_keluar
            Cmd.Parameters.Add("@id", SqlDbType.Int).Value = idbrg
            Cmd.ExecuteNonQuery()
            closeConn()
            openConn()
            Cmd = New SqlCommand("SELECT stok FROM tbl_barang WHERE id_barang = @id", conn)
            Cmd.Parameters.Add("@id", SqlDbType.Int).Value = idbrg
            Dim stok_kemudian = Cmd.ExecuteScalar()
            closeConn()
            openConn()
            Cmd = New SqlCommand("UPDATE tbl_barang SET stok = @stok WHERE id_barang = @id", conn)
            Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok_kemudian - stok_edit
            Cmd.Parameters.Add("@id", SqlDbType.Int).Value = idbrg
            Cmd.ExecuteNonQuery()
            closeConn()
            openConn()
            Cmd = New SqlCommand("UPDATE tbl_barang_keluar SET jumlah = @stok, subtotal = @subtotal, keuntungan = @keuntungan, kerugian = @kerugian 
                                  WHERE no_nota_keluar = @nota AND id_barang = '" & idbrg & "'", conn)
            Cmd.Parameters.Add("@stok", SqlDbType.Int).Value = stok_edit
            Cmd.Parameters.Add("@nota", SqlDbType.VarChar).Value = nota
            Cmd.Parameters.Add("@subtotal", SqlDbType.Int).Value = subtotal
            Cmd.Parameters.Add("@keuntungan", SqlDbType.Int).Value = keuntungan
            Cmd.Parameters.Add("@kerugian", SqlDbType.Int).Value = kerugian
            Cmd.ExecuteNonQuery()
            closeConn()
            Return jum
        End If
    End Function

    Public Function penguranganStok(id_barang As Integer, jmlkeluar As Integer)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE id_barang = '" & id_barang & "'", conn)
        openConn()
        Using rd = Cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Cmd = New SqlCommand("UPDATE tbl_barang SET stok = '" & rd.Item("stok") - jmlkeluar & "' WHERE id_barang = '" & id_barang & "' ", conn)
                rd.Close()
                Cmd.ExecuteNonQuery()
                Debug.WriteLine("Succes pengurangan stok!!")
            End If
        End Using
        closeConn()
    End Function

    Public Function pengembalianStok(id_barang As Integer, jmlkeluar As Integer)
        Cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE id_barang = '" & id_barang & "'", conn)
        openConn()
        Using rd = Cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Cmd = New SqlCommand("UPDATE tbl_barang SET stok = '" & rd.Item("stok") + jmlkeluar & "' WHERE id_barang = '" & id_barang & "' ", conn)
                rd.Close()
                Cmd.ExecuteNonQuery()
                Debug.WriteLine("Succes pengembalian stok!!")
            End If
        End Using
        closeConn()
    End Function

#End Region

#Region "Fungsi mendapatkan total"

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

#End Region

    Public Function LaporanExist(nota_keluar As String)
        Using Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_barang_keluar WHERE no_nota_keluar = '" & nota_keluar & "'", conn)
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

    Public Function searchLPBK(searchbox As String)
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.no_nota_keluar as 'NOTA', tbl_barang.nama_barang as 'NAMA BARANG', 
                              tbl_barang_keluar.harga_beli as 'HARGA BELI', tbl_barang_keluar.harga_jual as 'HARGA JUAL', 
                              tbl_barang_keluar.jumlah as 'JUMLAH', tbl_barang_keluar.subtotal as 'SUBTOTAL', 
                              tbl_barang_keluar.keuntungan as 'KEUNTUNGAN', tbl_barang_keluar.kerugian as 'KERUGIAN', 
                              tbl_barang_keluar.tanggal as 'TANGGAL', tbl_barang_keluar.jam as 'JAM', tbl_user.fullname as 'PETUGAS' 
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang 
                              JOIN tbl_user ON tbl_barang_keluar.uid = tbl_user.uid
                              WHERE tbl_barang.nama_barang LIKE '%" + searchbox + "%' OR tbl_barang_keluar.no_nota_keluar LIKE '%" + searchbox + "%'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function SelectToTable()
        Cmd = New SqlCommand("SELECT tbl_barang_keluar.no_nota_keluar as 'NOTA', tbl_barang.nama_barang as 'NAMA BARANG', 
                              tbl_barang_keluar.harga_beli as 'HARGA BELI', tbl_barang_keluar.harga_jual as 'HARGA JUAL', 
                              tbl_barang_keluar.jumlah as 'JUMLAH', tbl_barang_keluar.subtotal as 'SUBTOTAL', 
                              tbl_barang_keluar.keuntungan as 'KEUNTUNGAN', tbl_barang_keluar.kerugian as 'KERUGIAN', 
                              tbl_barang_keluar.tanggal as 'TANGGAL', tbl_barang_keluar.jam as 'JAM', tbl_user.fullname as 'PETUGAS' 
                              FROM tbl_barang_keluar 
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang 
                              JOIN tbl_user ON tbl_barang_keluar.uid = tbl_user.uid", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function newest_barang_keluar()
        Cmd = New SqlCommand("SELECT TOP 10 tbl_barang.nama_barang, tbl_barang_keluar.jumlah, tbl_barang_keluar.tanggal, tbl_barang_keluar.jam, tbl_user.fullname 
                              FROM tbl_barang_keluar
                              JOIN tbl_user ON tbl_barang_keluar.uid = tbl_user.uid
                              JOIN tbl_barang ON tbl_barang_keluar.id_barang = tbl_barang.id_barang ORDER BY tbl_barang_keluar.tanggal DESC, tbl_barang_keluar.jam DESC", conn)
        Dim adapter = New SqlDataAdapter(Cmd)
        Dim ds = New DataSet
        adapter.Fill(ds)
        Return ds

    End Function

    Public Function log_penjualan(id_user, no_nota_keluar, tanggal_berubah)
        Cmd = New SqlCommand("INSERT INTO tbl_log (id_user, no_nota_keluar, tanggal_berubah) VALUES (@id_user, @nota, @tanggal)", conn)
        Cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user
        Cmd.Parameters.Add("@nota", SqlDbType.VarChar).Value = no_nota_keluar
        Cmd.Parameters.Add("@tanggal", SqlDbType.DateTime).Value = tanggal_berubah
        openConn()
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            closeConn()
            Return Status.DataError
        End Try
        closeConn()
        Return Status.Success
    End Function

    Public Function LogTotable()
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.no_nota_keluar as 'NOTA KELUAR', 
                                     tbl_log.tanggal_berubah as 'TANGGAL EDIT', tbl_user.fullname as 'OLEH'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                Call openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        Call closeConn()
    End Function

#Region "Perhitungan untung rugi"

    ' UNIMPLEMENTED
    'Private Function count_items(list As List(Of Integer))
    '    Dim dict As New Dictionary(Of Integer, Integer)
    '    Dim arr As New ArrayList()

    '    Dim groups = list.GroupBy(Function(value) value)
    '    For Each grp In groups
    '        dict.Add(grp(0), grp.Count)
    '    Next

    '    Return dict

    'End Function

    Public Function get_total_pendapatan_bulanan(year As Integer, month As Integer)
        Cmd = New SqlCommand("SELECT SUM(subtotal) FROM tbl_barang_keluar WHERE MONTH(tanggal) = @month AND YEAR(tanggal) = @year", conn)
        Cmd.Parameters.Add("@month", SqlDbType.Int).Value = month
        Cmd.Parameters.Add("@year", SqlDbType.Int).Value = year
        openConn()
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                pendapatanB = rd.GetInt32(0)
            Else
                pendapatanB = Nothing
            End If
        End While
        closeConn()
        Return pendapatanB
    End Function

    'Format: YYYY-MM-DD
    Public Function get_total_pendapatan_harian(tgl)
        openConn()
        Cmd = New SqlCommand("SELECT SUM(subtotal) FROM tbl_barang_keluar WHERE tanggal = '" & tgl & "'", conn)
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                pendapatanH = rd.GetInt32(0)
            Else
                pendapatanH = Nothing
            End If
        End While
        closeConn()
        Return pendapatanH
    End Function

    'Public Function get_total_barang_keluar_bulanan(year, month)
    '    openConn()
    '    Cmd = New SqlCommand("SELECT COUNT(no_nota_keluar) FROM tbl_barang_keluar WHERE MONTH(tanggal) = @month AND YEAR(tanggal) = @year", conn)
    '    Cmd.Parameters.Add("@month", SqlDbType.Int).Value = month
    '    Cmd.Parameters.Add("@year", SqlDbType.Int).Value = year                    //UNIMPLEMENTED//
    '    Dim total = Cmd.ExecuteScalar()
    '    closeConn()
    '    Return total
    'End Function

    Public Function get_total_barang_keluar_harian()
        openConn()
        Cmd = New SqlCommand("SELECT COUNT(no_nota_keluar) FROM tbl_barang_keluar WHERE tanggal = '" & DateTime.Now.ToString("yyyy/MM/dd") & "'", conn)
        Dim total = Cmd.ExecuteScalar()
        closeConn()
        Return total
    End Function

    Public Function get_total_keuntungan_harian(tgl)
        openConn()
        Cmd = New SqlCommand("Select SUM(keuntungan) FROM tbl_barang_keluar WHERE tanggal = '" & tgl & "'", conn)
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                keuntunganH = rd.GetInt32(0)
            Else
                keuntunganH = Nothing
            End If
        End While
        closeConn()
        Return keuntunganH
    End Function

    Public Function get_total_keuntungan_bulanan(year, month)
        openConn()
        Cmd = New SqlCommand("SELECT SUM(keuntungan) FROM tbl_barang_keluar WHERE MONTH(tanggal) = @month AND YEAR(tanggal) = @year", conn)
        Cmd.Parameters.Add("@month", SqlDbType.Int).Value = month
        Cmd.Parameters.Add("@year", SqlDbType.Int).Value = year
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                keuntunganB = rd.GetInt32(0)
            Else
                keuntunganB = Nothing
            End If
        End While
        closeConn()
        Return keuntunganB
    End Function

    Public Function get_total_kerugian_harian(tgl)
        Cmd = New SqlCommand("Select SUM(kerugian) FROM tbl_barang_keluar WHERE tanggal = '" & tgl & "'", conn)
        openConn()
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                kerugianH = rd.GetInt32(0)
            Else
                kerugianH = Nothing
            End If
        End While
        closeConn()
        Return kerugianH
    End Function

    Public Function get_total_kerugian_bulanan(year, month)
        openConn()
        Cmd = New SqlCommand("SELECT SUM(kerugian) FROM tbl_barang_keluar WHERE MONTH(tanggal) = @month AND YEAR(tanggal) = @year", conn)
        Cmd.Parameters.Add("@month", SqlDbType.Int).Value = month
        Cmd.Parameters.Add("@year", SqlDbType.Int).Value = year
        Dim rd = Cmd.ExecuteReader
        While rd.Read
            If (rd.Item(0) IsNot DBNull.Value) Then
                kerugianB = rd.GetInt32(0)
            Else
                kerugianB = Nothing
            End If
        End While
        closeConn()
        Return kerugianB
    End Function
#End Region

End Class
