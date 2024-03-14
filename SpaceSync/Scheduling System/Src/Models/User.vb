Public Class User
    Dim sql As String
    Sub addNewUser(username As String, password As String, role As String)
        Try
            sql = "INSERT INTO tbl_users (username, password, role) VALUES('" & username & ", " & password & ", " & role & "')"
            executeCommand(sql)

        Catch ex As Exception

        End Try

    End Sub

    Sub getAllUser()
        Try
            sql = "SELECT * FROM tbl_users"
            executeCommand(sql)

        Catch ex As Exception

        End Try
    End Sub

    Sub getUserById(id As Integer)
        Try
            sql = "SELECT * FROM tbl_users WHERE ID = '" & id & "' "
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub updateUserById(username As String, password As String, role As String)
        Try
            sql = "UPDATE tbl_users SET username = '" & username & "', password = '" & password & "', role = '" & role & "' WHERE ID = " & id
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub
    Sub DeleteUserById(id As Integer)
        Try
            sql = "DELETE FROM tbl_users WHERE ID = '" & id & "'"
            executeCommand(sql)
        Catch ex As Exception

        End Try

    End Sub

    Sub deleteAllUser()
        Try
            sql = "DELETE FROM tbl_users"
            executeCommand()
        Catch ex As Exception

        End Try

    End Sub
End Class
