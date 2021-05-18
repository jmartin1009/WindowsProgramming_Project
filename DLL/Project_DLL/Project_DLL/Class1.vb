Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Module Class1
    Private conFlag As Boolean = False
    'Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EmployeeDB.mdb"
    Private con As OleDbConnection = New OleDbConnection

    'Checks connection to database, only opens connection if connection flag indicates a connection has not been made
    Public Sub connectionCheck(conString As String)
        Try
            'Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=#"
            'conString = conString.Replace("#", filePath)
            If con.State = ConnectionState.Open Then
                If con.ConnectionString <> conString Then
                    conFlag = False
                    con.Close()
                End If
            End If
            If (conFlag = False) Then
                con = New OleDbConnection(conString)
                con.Open()
                con.Close()
                conFlag = True
            End If
            If Not (con.State = ConnectionState.Open) Then
                'Throw New Exception("Database Connection failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Creates and returns a command given the query string
    Private Function doCommand(query As String)
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandText = query
        Return cmd
    End Function

    'Handles showing the database table contents
    Public Function fnShow(sqlString As String, conString As String)
        Dim con = New OleDbConnection(conString)
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Try
            cmd.Connection = con
            cmd.CommandText = sqlString
            con.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Handles deleting a row from the table based on ID entered
    Public Sub fnDeleteOld(userID As String, conString As String)
        connectionCheck(conString)
        Dim cmd = doCommand("DELETE FROM tblEmployee WHERE empID='" & userID & "'")
        Try
            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Throw New Exception("Query Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function fnDelete(sqlString As String, conString As String)
        Dim con = New OleDbConnection(conString)
        Dim cmd As New OleDb.OleDbCommand
        Try
            cmd.Connection = con
            cmd.CommandText = sqlString
            con.Open()

            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Handles inserting data into a given table
    Public Function fnInsert(sqlString As String, conString As String)
        Dim con = New OleDbConnection(conString)
        Dim cmd As New OleDb.OleDbCommand
        Try
            cmd.Connection = con
            cmd.CommandText = sqlString
            con.Open()

            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function fnUpdate(sqlString As String, conString As String)
        Dim con = New OleDbConnection(conString)
        Dim cmd As New OleDb.OleDbCommand
        Try
            cmd.Connection = con
            cmd.CommandText = sqlString
            con.Open()

            Dim check = cmd.ExecuteNonQuery
            If check < 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function fnQuery(sqlString As String, conString As String)
        Dim con = New OleDbConnection(conString)
        Dim cmd As New OleDb.OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Try
            cmd.Connection = con
            cmd.CommandText = sqlString
            con.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex
        End Try
    End Function

End Module
