Public Class GamesDBForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If DB_Init() Then
            Dim x As String = vbDQ
            populateGames()

        Else
            End
        End If
    End Sub

    Private Sub populateGames()
        'Populates the big box with the database
        Try
            Dim SQL As String = "SELECT * FROM GameList"
            'Dim SQL As String = "SELECT GameName, GameYear, Platform, MediaType FROM GameList"
            Dim Command As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, DB_Connection)
            Dim Reader As OleDb.OleDbDataReader
            Reader = Command.ExecuteReader()

            Dim dtGames As New DataTable()
            dtGames.Load(Reader)

            Dim bindSource As New BindingSource(dtGames, Nothing)
            DGV_Games.DataSource = bindSource

            Reader.Close()
            Command.Dispose()
        Catch ex As Exception

        End Try



    End Sub
    Private Sub populateSearch(searchstr As String)
        'Populates the big box with elements in the database whose GameName contain the searched String.
        Try
            'Debug.Print(searchstr)
            Dim SQL As String = ""
            SQL = "SELECT * FROM GameList WHERE GameName LIKE '%" & searchstr & "%'"
            Dim Command As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, DB_Connection)
            Dim Reader As OleDb.OleDbDataReader
            Reader = Command.ExecuteReader()

            Dim dtGames As New DataTable()
            dtGames.Load(Reader)

            Dim bindSource As New BindingSource(dtGames, Nothing)
            DGV_Games.DataSource = bindSource

            Reader.Close()
            Command.Dispose()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the database
        ' Debug.Print("asdf")
        Close_DB()
        End

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Opens the Add Game window
        Dim form As New frmAddEdit()
        form.ShowDialog()
        populateGames()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        'Deletes an element from the database, then repopulates the app.
        If DGV_Games.SelectedRows.Count > 0 Then
            Dim SelectedRow As DataGridViewRow = DGV_Games.SelectedRows(0)
            Dim GameID As Integer = SelectedRow.Cells("GameListID").Value
            Try
                Dim SQL As String = ""

                SQL = "DELETE FROM GameList WHERE GameListId = " & GameID

                Dim Command As New OleDb.OleDbCommand(SQL, DB_Connection)
                Command.ExecuteNonQuery()
                populateGames()

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Opens the Edit Game window
        Dim GameID As Integer = -1
        If DGV_Games.SelectedRows.Count > 0 Then
            Dim SelectedRow As DataGridViewRow = DGV_Games.SelectedRows(0)
            GameID = SelectedRow.Cells("GameListID").Value
        End If

        If GameID >= 0 Then
            Dim form As New frmAddEdit(GameID)
            form.ShowDialog()
            populateGames()
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        'Clears the search box then repopulates the app
        searchBox.Text = ""
        populateGames()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        'Takes the string in the search box to summon populateSearch
        Dim search As String
        search = searchBox.Text
        populateSearch(search)
    End Sub
End Class
