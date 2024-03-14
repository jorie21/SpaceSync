Public Class Students
    Dim sql As String

    Sub addNewStudents(student_no As Integer, firstname As String, lastname As String, program As String, student_type As String)
        Try
            sql = "INSERT INTO tbl_students (student_no, firstname,	lastname, program, student_type) VALUES ('" & student_no & ", " & firstname & ", " & lastname & ", " & program & ", " & student_type & "')"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub getAllStudents()
        Try
            sql = "SELECT * FROM tbl_students"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub getStudentsById(id As Integer)
        Try
            sql = "SELECT * FROM tbl_students WHERE = '" & id & "'"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub SearchInstructors(keyword As String)
        Try
            sql = "SELECT * FROM tbl_students WHERE firstname LIKE '%" & keyword & "%' OR lastname LIKE '%" & keyword & "%'"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub updateStudentsById(student_no As Integer, firstname As String, lastname As String, program As String, student_type As String)
        Try
            sql = "UPDATE tbl_students SET student_no = '" & student_no & "', firstname = '" & firstname & "', lastname = '" & lastname & "' , program = '" & program & "', student_type = '" & student_type & "' WHERE ID = " & id
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub deleteStudentById(id As Integer)
        Try
            sql = "DELETE FROM tbl_student WHERE id = '" & id & "'"
            executeCommand(sql)
        Catch ex As Exception

        End Try
    End Sub

    Sub deleteAllStudents()
        Try
            sql = "DELETE FROM tbl_students"
        Catch ex As Exception

        End Try
    End Sub
End Class
