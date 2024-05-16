Imports System.Collections.Generic
Imports System.Data.OleDb
Module Library

    Public Const vbDQ As String = Chr(34)

    Public DB_Connection As New OleDbConnection

    Public Function DB_Init() As Boolean

        Try
            'change the file directory to wherever you have put the project folder
            Dim FileName As String = "..\GamesDB.mdb"
            Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FileName
            DB_Connection = New OleDbConnection
            DB_Connection.ConnectionString = ConnectionString
            DB_Connection.Open()

            If DB_Connection.State <> 1 Then
                MsgBox("Error database connection", vbCritical, "DB_Init")
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox("Error creating connection" & vbCrLf & ex.Message, vbCritical, "DB_Init")
            Return False
        End Try



    End Function

    Public Function dbString(ByVal Value As String) As String
        Try
            Return vbDQ & Value & vbDQ
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Sub Close_DB()
        DB_Connection.Close()
    End Sub
End Module
