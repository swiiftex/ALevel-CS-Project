Public Class AdminPanel

    Private Function GetMatches() As List(Of Match)
        If DbConnect() Then
            Dim OutputMatches As New List(Of Match)
            Dim SQLCmd As New OleDb.OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "SELECT * FROM Matches ORDER BY TimeSet ASC"
                Dim rs As OleDb.OleDbDataReader = .ExecuteReader
                While rs.Read
                    OutputMatches.Add(Match.GetExisting(rs("MatchID")))
                End While
            End With
            Return OutputMatches
        End If
    End Function

    Private Sub GenerateMatches()

        'Get all teams in order of MMR
        If DbConnect() Then
            Dim OrderedTeams As New List(Of Team)
            Dim SQLCmd As New OleDb.OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "SELECT * FROM Team WHERE Region = @Region ORDER BY Ranking DESC"
                .Parameters.AddWithValue("@Region", comboRegion.Text)
                Dim rs As OleDb.OleDbDataReader = .ExecuteReader
                While rs.Read
                    OrderedTeams.Add(New Team(rs("TeamID")))
                End While
            End With

            'For each team, create a match for the team under it, unless it is the last team.
            Dim counter As Integer = 0
            Dim GeneratedMatches As List(Of Match) = New List(Of Match)

            For Each ThisTeam As Team In OrderedTeams
                'Checks if its the last team
                If OrderedTeams.Last.ID <> ThisTeam.ID Then
                    'Create match
                    Dim enemyTeam As Team = OrderedTeams(counter + 1)
                    GeneratedMatches.Add(New Match(ThisTeam.ID, enemyTeam.ID, -1, ThisTeam.Region, numSeason.Value))
                End If
                counter += 1
            Next

            'Display generated matches
            For Each ThisMatch As Match In GeneratedMatches
                ListBoxMatches.Items.Add(ThisMatch.OrangeTeam.Name & " vs " & ThisMatch.BlueTeam.Name)

                'Submit the matches
                ThisMatch.Submit()
            Next

            MsgBox("Matches successfully generated!")
        End If

    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add all current matches to ListBox
        Dim AllMatches As List(Of Match) = New List(Of Match)
        If GetMatches().Count <> 0 Then
            AllMatches = GetMatches()
            For Each ThisMatch As Match In AllMatches
                ListBoxMatches.Items.Add("(" & ThisMatch.ID & ") | " & ThisMatch.OrangeTeam.Name & " vs " & ThisMatch.BlueTeam.Name)
            Next
        End If



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If ListBoxMatches.SelectedItem <> Nothing Then

        End If
    End Sub

    Private Sub btnGenMatches_Click(sender As Object, e As EventArgs) Handles btnGenMatches.Click
        GenerateMatches()
    End Sub
End Class