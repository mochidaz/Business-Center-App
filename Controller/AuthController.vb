Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AuthController
    Inherits BaseConnection

    Public Function AuthLogin(username As String, password As String)
        Cmd = New SqlCommand("SELECT * FROM tbl_user WHERE username = @username AND password = @password ", Conn)
        Cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username.ToLower()
        Cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = GetHash(password.ToLower)
        Using adapter As New SqlDataAdapter(Cmd)
            Using table As New DataTable()
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("User Id: error!!")
                    Debug.WriteLine("Fullname: error!!")
                    Debug.WriteLine("Status: error!!")
                    Return Status.LoginFailed
                Else
                    Dim uid = table.Rows(0)("uid")
                    uname = table.Rows(0)("username")
                    setUid(uid)
                    setFullname(uid)
                    setStatus(uid)
                    Debug.WriteLine("User Id: " + vUid)
                    Debug.WriteLine("Fullname: " + fname)
                    Debug.WriteLine("Status: " + ustatus)
                    Return Status.Success
                End If
            End Using
        End Using
        Call closeConn()
    End Function

    Private Function username_exists(username As String)
        Cmd = New SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE username = @username", Conn)
        Cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username.ToLower()
        Call openConn()
        Dim Result = Cmd.ExecuteScalar()
        If Convert.ToInt32(result) = 0 Then
            Return False
        Else
            Return True
        End If
        Call closeConn()
    End Function

    Private Function username_isvalid(username As String)
        Dim special_char = {
            "+", "-", "&&", "||", "!", "(", ")", "{", "}", "[", "]", "^",
            "~", "*", "?", ":", """", "\"
        }
        If special_char.Any(Function(x) username.ToLower().Contains(x.ToLower())) Or username.Any(Function(x) Char.IsWhiteSpace(x)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function AuthRegister(fullname As String, username As String, password As String, confirm_password As String)
        If username_exists(username) = False And username_isvalid(username) Then
            If validate_password(password, confirm_password) = True Then
                Call openConn()
                Cmd = New SqlCommand("INSERT INTO tbl_user (fullname, username, password, status) 
                                      VALUES ('" & fullname & "','" & username.ToLower() & "','" & GetHash(password.ToLower) & "','" & vbNullString & "')", Conn)
                Try
                    Cmd.ExecuteNonQuery()
                Catch e As Exception
                    Call closeConn()
                    Return Status.DataIncomplete
                End Try
                Call closeConn()
                updateStatus(username)
                Return Status.Success
            Else
                Return Status.PasswordDoesNotMatch
            End If
        Else
            Return Status.UsernameExistInvalid
        End If
        Conn.Close()
    End Function

    Public Function updateUser(uid As Integer, fullname As String, username As String, stats As String)
        If username = eUuname Or username_exists(username) = False And username_isvalid(username) Then
            If fullname = eUfname And username = eUuname And stats = eUstatus Then
                Return Status.NothingChanged
            Else
                Cmd = New SqlCommand("UPDATE tbl_user SET fullname = @fullname , username = @username , status = @status WHERE uid = @uid", Conn)
                Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
                Cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname
                Cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username.ToLower
                Cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = stats
                Try
                    If MessageBox.Show("Yakin ingin menyimpan perubahan pada akun tersebut?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
                        DialogResult.No Then
                        Exit Function
                    Else
                        Call openConn()
                        Cmd.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    Call closeConn()
                    Debug.WriteLine("Failed to edit user!!")
                    Return Status.DataIncomplete
                End Try
                Call closeConn()
                Debug.WriteLine("succes edit user!!")
                Return Status.Success
            End If
        Else
            Return Status.UsernameExistInvalid
            Debug.WriteLine("Error username exist or invalid!!")
        End If
    End Function

    Public Function ChangePassword(uid As Integer, password As String, newpw As String, confirmnpw As String)
        If validate_password(newpw, confirmnpw) = True Then
            Cmd = New SqlCommand("SELECT password FROM tbl_user WHERE uid = @uid AND password = @password", Conn)
            Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
            Cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = GetHash(password.ToLower)
            Using adapter As New SqlDataAdapter(Cmd)
                Using table As New DataTable()
                    Call openConn()
                    adapter.Fill(table)
                    If table.Rows.Count() = 0 Then
                        Debug.WriteLine("invalid password")
                        Return Status.WrongCurrentPassword
                    Else
                        Cmd = New SqlCommand("UPDATE tbl_user SET password = @newpw WHERE uid = @uid", Conn)
                        Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
                        Cmd.Parameters.Add("@newpw", SqlDbType.VarChar).Value = GetHash(newpw.ToLower)
                        Try
                            If MessageBox.Show("Yakin ingin menyimpan perubahan password?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                Exit Function
                            Else
                                Cmd.ExecuteNonQuery()
                            End If
                        Catch ex As Exception
                            Call closeConn()
                            Debug.WriteLine("failled to change password!!")
                            Return Status.DataIncomplete
                        End Try
                        Call closeConn()
                        Debug.WriteLine("succes change password!!")
                        Return Status.Success
                    End If
                End Using
            End Using
        Else
            Return Status.PasswordDoesNotMatch
        End If

    End Function

    Private Function validate_password(password As String, confirm_password As String)
        If password = confirm_password Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            Dim sBuilder As New StringBuilder()
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using

    End Function

    Public Function setUname(uid As Integer)
        Cmd = New SqlCommand("SELECT username FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
        Call openConn()
        Using rd = Cmd.ExecuteReader
            While rd.Read
                uname = rd.GetString(0)
            End While
        End Using
    End Function

    Public Function setUid(uid As Integer)
        Cmd = New SqlCommand("SELECT uid FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
        Call openConn()
        Using rd = Cmd.ExecuteReader()
            While rd.Read
                vUid = rd.GetInt32(0)
            End While
        End Using
        Call closeConn()
        Return vUid
    End Function

    Public Function setFullname(uid As Integer)
        Cmd = New SqlCommand("SELECT fullname FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid
        Call openConn()
        Using rd = Cmd.ExecuteReader()
            While rd.Read
                fname = rd.GetString(0)
            End While
        End Using
        Call closeConn()
        Return fname
    End Function

    Public Function setStatus(uid As Integer)
        Cmd = New SqlCommand("SELECT status FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = uid
        Call openConn()
        Using rd = Cmd.ExecuteReader()
            While rd.Read
                ustatus = rd.GetString(0)
            End While
        End Using
        Call closeConn()
        Return ustatus
    End Function


    Public Function updateStatus(username As String)
        Cmd = New SqlCommand("SELECT status, uid FROM tbl_user WHERE username = @username", Conn)
        Cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username.ToLower()
        Call openConn()
        Using rd = Cmd.ExecuteReader()
            While rd.Read
                Using Cmd = New SqlCommand("UPDATE tbl_user SET status = @status WHERE username = @username", Conn)
                    Cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username.ToLower()
                    If String.IsNullOrEmpty(rd.GetString(0)) Then
                        If rd.Item("uid") = 1 Then
                            Cmd.Parameters.AddWithValue("@status", "admin")
                            rd.Close()
                            Cmd.ExecuteNonQuery()
                            Debug.WriteLine("succes update status as admin")
                            Call closeConn()
                            Return Status.Success
                        Else
                            Cmd.Parameters.AddWithValue("@status", "user")
                            rd.Close()
                            Cmd.ExecuteNonQuery()
                            Debug.WriteLine("succes update status as user")
                            Call closeConn()
                            Return Status.Success
                        End If
                    Else
                        Debug.WriteLine("status is already fill as " + ustatus)
                    End If
                End Using
            End While
        End Using
    End Function

    Public Function UIDidentReset()
        Call openConn()
        Dim objReader = New IO.StreamReader(".\UIDidentityreset.sql")
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = objReader.ReadToEnd
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Debug.WriteLine("reset uid failled!!")
            Return Status.FiledToResetUid
        End Try
        Call closeConn()
        Debug.WriteLine("reset uid sucess!!")
        Return Status.Success
    End Function

    Public Function deleteUser(uid As Integer)
        Cmd = New SqlCommand("DELETE FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
        Try
            If MessageBox.Show("Yakin ingin menghapus akun ini?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Function
            Else
                Call openConn()
                Cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Call closeConn()
            Debug.WriteLine("Failed to delete user!!")
            Return Status.FailedToDeleteUser
        End Try
        Call closeConn()
        UIDidentReset()
        Return Status.Success
    End Function

    Public Function ClearVariable()
        uname = vbNullString
        fname = vbNullString
        ustatus = vbNullString
        vUid = vbNullString
    End Function

    Public Function selectUser(uid As Integer)
        Cmd = New SqlCommand("SELECT fullname, username, status FROM tbl_user WHERE uid = @uid", Conn)
        Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid
        Using adapter As New SqlDataAdapter(Cmd)
            Using table As New DataTable
                Call openConn()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    Debug.WriteLine("error get user info from UID!!")
                    Return Status.DataError
                Else
                    eUfname = table.Rows(0)("fullname")
                    eUuname = table.Rows(0)("username")
                    eUstatus = table.Rows(0)("status")
                    Return Status.Success
                End If
            End Using
        End Using
        Call closeConn()
    End Function

    Public Function showUser()
        Cmd = New SqlCommand("SELECT uid, fullname, username, status FROM tbl_user", Conn)
        Using adapter As New SqlDataAdapter(Cmd)
            Using Ds As New DataSet()
                Call openConn()
                adapter.Fill(Ds)
                Return Ds
            End Using
        End Using
        Call closeConn()
    End Function

End Class