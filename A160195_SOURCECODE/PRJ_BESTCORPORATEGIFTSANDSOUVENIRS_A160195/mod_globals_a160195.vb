﻿Module mod_globals_a160195

    Public username As String

    Public userid As String

    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BESTCORPORATEGIFTSANDSOUVENIRS_A160195.accdb;Persist Security Info=False;"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_sql_query(ByVal mysql As String) As DataTable

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try

            myreader.Fill(mydatatable)

        Catch ex As Exception

            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return mydatatable

    End Function

    Public Sub run_sql_command(ByVal thissql As String)

        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered,as shown below:" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub
End Module
