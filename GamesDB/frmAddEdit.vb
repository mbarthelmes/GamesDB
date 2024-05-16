Public Class frmAddEdit
    Dim CurrentGameId As Integer = -1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Going to create a new record here
        Me.Text = "Add New"
        labelGame.Text = "Add New Game"
        labelGame.Left = (Me.ClientSize.Width / 2) - (labelGame.Width / 2)
    End Sub
    Public Sub New(ByVal GameId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CurrentGameId = GameId
        PopulateGame(GameId)
        Me.Text = "Edit"
        labelGame.Text = "Edit Game"
        labelGame.Left = (Me.ClientSize.Width / 2) - (labelGame.Width / 2)
    End Sub

    Private Sub PopulateGame(ByVal GameId As Integer)
        'Populates the boxes with the game information that the user wishes to edit.
        Try
            Dim SQL As String = "SELECT * FROM GameList WHERE GameListID = " & GameId
            Dim Command As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, DB_Connection)
            Dim reader As OleDb.OleDbDataReader
            reader = Command.ExecuteReader()

            If reader.HasRows Then

                While reader.Read()
                    txtGameName.Text = reader("GameName")
                    txtGameYear.Text = reader("GameYear")
                    comboGamePlatform.Text = reader("Platform")
                    comboGameMediaType.Text = reader("MediaType")
                End While
            Else


            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveExistingGame()
        'Saves a pre-existing game into the database. Only used in the Edit page.
        Dim SQL As String = ""
        'SQL = "UPDATE GameList SET GameName = " & Chr(34) & txtGameName.Text & Chr(34) & ", GameYear=" & Chr(34) & txtGameYear & Chr(34) & " WHERE GameListID = " & GameId
        SQL = "UPDATE GameList SET GameName = " & vbDQ & txtGameName.Text & vbDQ & ", GameYear=" & vbDQ & txtGameYear.Text & vbDQ & " WHERE GameListID = " & CurrentGameId


        SQL = "UPDATE GameList SET " &
            " GameName = " & dbString(txtGameName.Text) & ", " &
            " GameYear = " & dbString(txtGameYear.Text) & ", " &
            " Platform = " & dbString(comboGamePlatform.Text) & ", " &
            " MediaType = " & dbString(comboGameMediaType.Text) &
            " WHERE GameListID = " & CurrentGameId



        SQL = "UPDATE GameList SET " &
            " GameName = '" & txtGameName.Text & "', " &
            " GameYear = '" & txtGameYear.Text & "', " &
            " Platform = '" & comboGamePlatform.Text & "', " &
            " MediaType = '" & comboGameMediaType.Text & "'" &
            " WHERE GameListID = " & CurrentGameId

        Dim Command As New OleDb.OleDbCommand(SQL, DB_Connection)
        Command.ExecuteNonQuery()




        Debug.Print(SQL)


        'Dim a = 1
        'a = 2



    End Sub


    Private Sub SaveNewGame()
        'Saves a new game into the database
        Try
            Dim SQL As String = ""


            SQL = "INSERT INTO GameList (GameName, GameYear, Platform, MediaType) VALUES " &
            "(" &
            " '" & txtGameName.Text & "', " &
            " '" & txtGameYear.Text & "', " &
            " '" & comboGamePlatform.Text & "', " &
            " '" & comboGameMediaType.Text & "'" &
            ")"

            Dim Command As New OleDb.OleDbCommand(SQL, DB_Connection)
            Command.ExecuteNonQuery()



        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Runs a save command based on if the application is in the "Add" or "Edit" state.
        If CurrentGameId = -1 Then
            SaveNewGame()
        Else
            SaveExistingGame()
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Closes the page without saving anything.
        Me.Close()
    End Sub
End Class