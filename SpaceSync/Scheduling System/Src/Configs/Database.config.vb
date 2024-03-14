Imports MySql.Data.MySqlClient

Module Database
    Public conn As MySqlConnection
    Public cmd As MySqlCommand

    Sub openConn()
        conn.ConnectionString = "server=localhost;user=root;password=;database=scheduling_schema"
        conn.Open()
    End Sub

    Sub closeConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Sub executeCommand(sql As String)
        openConn()
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        closeConn()
    End Sub
End Module
