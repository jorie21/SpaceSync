Public Class Instructor
    Dim sql As String

    Sub addNewInstructor(instructor_no As Integer firstname As String, lastname As String, gender As String, email As String, employment_status As String, availability As String)
        Try
            sql = "INSERT INTO tbl_instructor(instructor_no, firstname, lastname, gender, email, employment_status,	availability) VALUE ('" & instructor_no & ", " & firstname & ", " & lastname & ", " & gender & ", " & email & ", " & employment_status & ", " & availability & "')"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub getAllInstructor()
        Try
            sql = "SELECT * FROM tbl_instructor"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub getInstructorById(id As Integer)
        Try
            sql = "SELECT * FROM tbl_instructor WHERE ID = '" & id & "' "
            executeCommand(sql)

        Catch ex As Exception

        End Try
    End Sub

    Sub SearchInstructors(keyword As String)
        Try
            sql = "SELECT * FROM tbl_instructor WHERE firstname LIKE '%" & keyword & "%' OR lastname LIKE '%" & keyword & "%'"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub updateInstructorById(instructor_no As Integer, firstname As String, lastname As String, gender As String, email As String, employment_status As String, availability As String)
        Try
            sql = "UPDATE tbl_instructor SET instructor_no = '" & instructor_no & "', firstname = '" & firstname & "', lastname = '" & lastname & "', gender = '" & gender & "', email = '" & email & ", employment_status = '" & employment_status & "' , availability = '" & availability & "'' WHERE ID = " & id
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub DeleteInstructorById(id As Integer)
        Try
            sql = "DELETE FROM tbl_instructor WHERE ID = '" & id & "'"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub deleteAllInstructor()
        Try
            sql = "DELETE FROM tbl_instructor"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub


End Class
