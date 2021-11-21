Imports System.Data.SqlClient

Public Class Log
    Inherits BaseConnection

#Region "Select Semua"

    Public Function logAccSemua(btn)
        Cmd = New SqlCommand("SELECT id_log as 'ID LOG', id_objek as 'USERNAME', tanggal_berubah as 'TANGGAL',
                                     kegiatan as 'KEGIATAN', mengedit as 'BAGIAN'
                              FROM tbl_log
                              WHERE mengedit = '" & btn.text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logBrgSemua(btn)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'NAMA BARANG', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logLpbkSemua(btn)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'NO NOTA', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logDataUserSemua(btn)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'USERNAME', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

#End Region

#Region "Select Filter"
    Public Function logAccFilter(btn, rb)
        Cmd = New SqlCommand("SELECT id_log as 'ID LOG', id_objek as 'USERNAME', tanggal_berubah as 'TANGGAL',
                                     kegiatan as 'KEGIATAN', mengedit as 'BAGIAN' 
                              FROM tbl_log
                              WHERE mengedit = '" & btn.Text.ToLower & "' AND kegiatan = '" & rb.Text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logBrgFilter(btn, rb)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'NAMA BARANG', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.Text.ToLower & "' AND tbl_log.kegiatan = '" & rb.Text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logLpbkFilter(btn, rb)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'NO NOTA', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.Text.ToLower & "' AND tbl_log.kegiatan = '" & rb.Text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

    Public Function logDataUserFilter(btn, rb)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'USERNAME', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'OLEH', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.mengedit = '" & btn.Text.ToLower & "' AND tbl_log.kegiatan = '" & rb.Text.ToLower & "'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

#End Region

    Public Function logSearch(srch)
        Cmd = New SqlCommand("SELECT tbl_log.id_log as 'ID LOG', tbl_log.id_objek as 'OBJEK', tbl_log.tanggal_berubah as 'TANGGAL',
                                     tbl_log.kegiatan as 'KEGIATAN',  tbl_user.fullname as 'YBS', tbl_log.mengedit as 'BAGIAN'
                              FROM tbl_log
                              JOIN tbl_user ON tbl_log.id_user = tbl_user.uid
                              WHERE tbl_log.id_log LIKE '%" & srch & "%' OR tbl_log.id_objek LIKE '%" & srch & "%' OR 
                              tbl_user.fullname LIKE '%" & srch & "%'", conn)
        Using adapter = New SqlDataAdapter(Cmd)
            Using ds = New DataSet
                openConn()
                adapter.Fill(ds)
                Return ds
            End Using
        End Using
        closeConn()
    End Function

End Class
