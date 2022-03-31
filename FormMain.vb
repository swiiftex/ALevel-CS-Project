Imports System.Data.OleDb

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If logged in, launch, else ask user for Login information.
        If My.Settings.stayLoggedIn = True And My.Settings.username = Nothing = False Then
            Login(My.Settings.username, My.Settings.password)
            RefreshUserInfo()
        Else
            Me.Hide()
            diaLogin.ShowDialog()
            RefreshUserInfo()
        End If
    End Sub

    Public Sub UpdateUserInfo()
        If loggedIn = True Then
            MyUser = New User(MyUser.ID)
            lblUsername.Text = MyUser.Username

            'Load profile pictures
            Try
                picProfile.Load(MyUser.ProfilePic)
                picProfile.Refresh()
            Catch ex As Exception
                MsgBox("One or more profile pictures are invalid. Please check your internet connection")
                Application.Exit()
            End Try

            'Update personal availability list
            sliderMon.ValueLeft = MyUser.AvailMon(0)
            sliderMon.ValueRight = MyUser.AvailMon(1)

            sliderTue.ValueLeft = MyUser.AvailTue(0)
            sliderTue.ValueRight = MyUser.AvailTue(1)

            sliderWed.ValueLeft = MyUser.AvailWed(0)
            sliderWed.ValueRight = MyUser.AvailWed(1)

            sliderThur.ValueLeft = MyUser.AvailThu(0)
            sliderThur.ValueRight = MyUser.AvailThu(1)

            sliderFri.ValueLeft = MyUser.AvailFri(0)
            sliderFri.ValueRight = MyUser.AvailFri(1)

            sliderSat.ValueLeft = MyUser.AvailSat(0)
            sliderSat.ValueRight = MyUser.AvailSat(1)

            sliderSun.ValueLeft = MyUser.AvailSun(0)
            sliderSun.ValueRight = MyUser.AvailSun(1)

            'Check if the user is in a team. If yes, show only the "My Team" page. If no, show the "Find a team" page.
            If MyUser.TeamID = -1 Then
                tabMain.TabPages.Remove(TabTeam)
            Else
                tabMain.TabPages.Remove(TabFindTeam)
                'Update My team information
                If DbConnect() Then
                    Dim SQLCmd As New OleDb.OleDbCommand
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Select * From Team Where TeamID = @TeamID"
                        .Parameters.AddWithValue("@TeamID", MyUser.TeamID)
                        Dim rs As OleDb.OleDbDataReader = .ExecuteReader

                        If rs.Read Then
                            'Team Name and Logo, Rank details
                            lblTeamName.Text = rs("TeamName")
                            lblProfileTeamName.Text = rs("TeamName")
                            lblTeamRanking.Text = CalculateRank(rs("Ranking"))
                            lblTeamRegion.Text = rs("Region")
                            picTeamRank.Load(GetRankLogo(lblTeamRanking.Text))
                            picTeamLogo.Load(rs("TeamLogoURL"))

                            'Player Information
                            lblPlayer1.Text = GetUsername(rs("PlayerCaptain"))
                            picPlayer1.Load(GetProfilePicture(rs("PlayerCaptain")))
                            lblPlayer2.Text = GetUsername(rs("Player2"))
                            picPlayer2.Load(GetProfilePicture(rs("Player2")))
                            lblPlayer3.Text = GetUsername(rs("Player3"))
                            picPlayer3.Load(GetProfilePicture(rs("Player3")))
                            lblPlayer4.Text = GetUsername(rs("Player4"))
                            picPlayer4.Load(GetProfilePicture(rs("Player4")))
                            lblSub1.Text = GetUsername(rs("Sub1"))
                            picSub1.Load(GetProfilePicture(rs("Sub1")))
                            lblSub2.Text = GetUsername(rs("Sub2"))
                            picSub2.Load(GetProfilePicture(rs("Sub2")))

                            'If user is not a caster (moderator), hide the Cast button on matches.
                            If MyUser.IsModerator = False Then
                                DataGridMatches.Columns.Item(Caster.Index).Visible = False
                            End If

                            'If the user is an admin, show the admin panel
                            If MyUser.IsAdmin = True Then
                                btnAdminPanel.Show()
                            End If

                            'If the user is a captain, show the kick buttons
                            If MyTeam.Captain = MyUser.ID Then
                                If lblPlayer2.Text <> "" Then
                                    btnKickPlayer2.Show()
                                End If
                                If lblPlayer3.Text <> "" Then
                                    btnKickPlayer3.Show()
                                End If
                                If lblPlayer4.Text <> "" Then
                                    btnKickPlayer4.Show()
                                End If
                                If lblSub1.Text <> "" Then
                                    btnKickSub1.Show()
                                End If
                                If lblSub2.Text <> "" Then
                                    btnKickSub2.Show()
                                End If
                            End If

                            'Update Team availability
                            listAvail.Items.Clear()
                            Dim allAvail = MyTeam.GetTeamAvailability
                            listAvail.Items.Add("M: " & allAvail(0))
                            listAvail.Items.Add("T: " & allAvail(1))
                            listAvail.Items.Add("W: " & allAvail(2))
                            listAvail.Items.Add("T: " & allAvail(3))
                            listAvail.Items.Add("F: " & allAvail(4))
                            listAvail.Items.Add("S: " & allAvail(5))
                            listAvail.Items.Add("S: " & allAvail(6))
                        End If
                        'rs.Close()
                        'cn.Close()
                    End With
                End If
            End If
        End If
    End Sub


    Private Sub btnCreateTeam_Click(sender As Object, e As EventArgs) Handles btnCreateTeam.Click
        diaCreateTeam.ShowDialog()
    End Sub

    Private Sub btnLeaveTeam_Click(sender As Object, e As EventArgs) Handles btnLeaveTeam.Click
        Dim teamCaptain As Boolean = False
        Dim leaveTeam As Boolean = False

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'Check if the user is the team captain. If they say yes to the dialog, it will delete the team completely.
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Team where TeamID = @TeamID"
                .Parameters.AddWithValue("@TeamID", MyUser.TeamID)
                Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                If rs.Read Then
                    If rs("PlayerCaptain") = MyUser.ID Then
                        teamCaptain = True
                        leaveTeam = MessageBox.Show("You are the captain of this team. Leaving will delete the team. Are you sure?",
                                                    "Leave Team", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Else
                        leaveTeam = MessageBox.Show("Are you sure you want to leave the team?",
                                                    "Leave Team", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    End If
                End If
            End With

            If leaveTeam = True Then

                If teamCaptain = True Then
                    MyTeam.Delete()
                Else
                    'See what position the UserID is in, then remove the userID from that column.
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Update Team SET " & MyTeam.GetUserPosition(MyUser.ID) & " = 0 WHERE TeamID = @TeamID"
                        .Parameters.AddWithValue("@TeamID", MyUser.TeamID)
                        .ExecuteNonQuery()
                        MsgBox("Successfully left the team.")
                    End With
                End If
            End If

        End If


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MyUser.TeamID = -1
        MyUser.Username = Nothing
        loggedIn = False
        MyUser.IsAdmin = False
        MyUser.IsModerator = False
        My.Settings.username = Nothing
        My.Settings.password = Nothing
        Me.Hide()
        diaLogin.ShowDialog()
        RefreshUserInfo()
        Application.Restart()
    End Sub

    Private Function GetRecruitingTeams()
        Dim teams As List(Of Team) = New List(Of Team)
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "SELECT * FROM Team WHERE LookingForPlayers = True"

                Dim rs As OleDbDataReader = .ExecuteReader
                Do Until rs.Read = False
                    teams.Add(New Team(rs("TeamID")))
                Loop
            End With
        End If
        Return teams

    End Function

    Private Sub btnRefreshRecruiting_Click(sender As Object, e As EventArgs) Handles btnRefreshRecruiting.Click
        Dim teams As List(Of Team) = New List(Of Team)
        teams = GetRecruitingTeams()
        For Each RecruitingTeam As Team In teams
            listRecruitingTeams.Items.Add(RecruitingTeam.Name, CalculateRank(RecruitingTeam.Ranking))
        Next
    End Sub

    Private Sub btnEditAvailbility_Click(sender As Object, e As EventArgs) Handles btnSaveAvailability.Click
        Try
            '// Save slider values to variables, then update the database.
            MyUser.AvailMon(0) = sliderMon.ValueLeft
            MyUser.AvailMon(1) = sliderMon.ValueRight

            MyUser.AvailTue(0) = sliderTue.ValueLeft
            MyUser.AvailTue(1) = sliderTue.ValueRight

            MyUser.AvailWed(0) = sliderWed.ValueLeft
            MyUser.AvailWed(1) = sliderWed.ValueRight

            MyUser.AvailThu(0) = sliderThur.ValueLeft
            MyUser.AvailThu(1) = sliderThur.ValueRight

            MyUser.AvailFri(0) = sliderFri.ValueLeft
            MyUser.AvailFri(1) = sliderFri.ValueRight

            MyUser.AvailSat(0) = sliderSat.ValueLeft
            MyUser.AvailSat(1) = sliderSat.ValueRight

            MyUser.AvailSun(0) = sliderSun.ValueLeft
            MyUser.AvailSun(1) = sliderSun.ValueRight

            UpdateAvailabilities()
            MsgBox("Availability saved!")
        Catch ex As Exception
            MsgBox("Failed to save availabilities: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefreshMatches_Click(sender As Object, e As EventArgs) Handles btnRefreshMatches.Click

        DataGridMatches.Rows.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Matches"
                Dim rs As OleDbDataReader = .ExecuteReader
                Do Until rs.Read = False
                    Dim orangeTeam As New Team(rs("OrangeTeam"))
                    Dim blueTeam As New Team(rs("BlueTeam"))
                    Dim avgRank As Integer = (orangeTeam.Ranking + blueTeam.Ranking) / 2

                    Dim row As String() = New String() {rs("TimeSet"), rs("Region"), CalculateRank(avgRank), orangeTeam.Name, blueTeam.Name}
                    DataGridMatches.Rows.Add(row)
                Loop
            End With
        End If
    End Sub

    Private Sub btnCreateMatch_Click(sender As Object, e As EventArgs) Handles btnCreateMatch.Click
        diaCreateMatch.ShowDialog()
    End Sub

    Private Sub btnRefreshLadder_Click(sender As Object, e As EventArgs) Handles btnRefreshLadder.Click
        DataGridLadder.Rows.Clear()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Team ORDER BY Ranking DESC"
                Dim rs As OleDbDataReader = .ExecuteReader
                Do Until rs.Read = False
                    Dim row As String() = New String() {rs("Ranking"), CalculateRank(rs("Ranking")), rs("TeamName")}
                    DataGridLadder.Rows.Add(row)
                Loop
            End With
        End If

    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        diaNotifications.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        WindowState = WindowState.Minimized
    End Sub

    '// Availability Sliders

    Private Sub ResetAvailText(sender As Object, e As EventArgs) Handles sliderMon.MouseUp, sliderTue.MouseUp, sliderWed.MouseUp, sliderThur.MouseUp, sliderFri.MouseUp, sliderSat.MouseUp, sliderSun.MouseUp
        availText.Visible = False
    End Sub
    Private Sub sliderMon_Click(sender As Object, e As EventArgs) Handles sliderMon.MouseDown, sliderMon.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderMon)
    End Sub

    Private Sub sliderTue_Click(sender As Object, e As EventArgs) Handles sliderTue.MouseDown, sliderTue.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderTue)
    End Sub

    Private Sub sliderWed_Click(sender As Object, e As EventArgs) Handles sliderWed.MouseDown, sliderWed.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderWed)
    End Sub

    Private Sub sliderThur_Click(sender As Object, e As EventArgs) Handles sliderThur.MouseDown, sliderThur.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderThur)
    End Sub
    Private Sub sliderFri_Click(sender As Object, e As EventArgs) Handles sliderFri.MouseDown, sliderFri.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderFri)
    End Sub

    Private Sub sliderSat_Click(sender As Object, e As EventArgs) Handles sliderSat.MouseDown, sliderSat.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderSat)
    End Sub

    Private Sub sliderSun_Click(sender As Object, e As EventArgs) Handles sliderSun.MouseDown, sliderSun.ValueChanged
        availText.Visible = True
        availText.Text = ConvertSliderValToTime(sliderSun)
    End Sub

    ' // Custom border style
    'Buttons
    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'Mouse movement
    Dim mouse_move As System.Drawing.Point
    Private Sub topPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles topPanel.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
    Private Sub topPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles topPanel.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub sliderMon_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub sliderMon_Click(sender As Object, e As MouseEventArgs) Handles sliderMon.MouseDown

    End Sub

    Private Sub ResetAvailText(sender As Object, e As MouseEventArgs) Handles sliderWed.MouseUp, sliderTue.MouseUp, sliderThur.MouseUp, sliderSun.MouseUp, sliderSat.MouseUp, sliderMon.MouseUp, sliderFri.MouseUp

    End Sub

    Private Sub sliderSun_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub sliderSat_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub sliderFri_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub sliderThur_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub sliderWed_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub sliderTue_Click(sender As Object, e As MouseEventArgs)

    End Sub



    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TabLadder_Click(sender As Object, e As EventArgs) Handles TabLadder.Click

        'Refresh then hide the create match button, if the user is not in a team.
        btnRefreshLadder.PerformClick()
        If MyUser.TeamID = -1 Then
            btnCreateMatch.Enabled = False
        End If

    End Sub

    Private Sub lblPlayer1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer1.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Captain)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer2.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Player2)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer3.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Player3)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer4.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Player4)
        playerPopout.Show()
    End Sub

    Private Sub lblSub1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSub1.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Sub1)
        playerPopout.Show()
    End Sub

    Private Sub lblSub2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSub2.LinkClicked
        Dim myteam As New Team(MyUser.TeamID)
        Dim playerPopout As New playerProfile(myteam.Sub2)
        playerPopout.Show()
    End Sub

    Private Sub DataGridMatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMatches.CellContentClick
        If e.ColumnIndex = 3 Then
            'Orange team selected
            Dim openTeam As New teamProfile(Team.GetID(DataGridMatches.SelectedCells(0).Value))
            openTeam.Show()

        ElseIf e.ColumnIndex = 4 Then
            'Blue team selected
            Dim openTeam As New teamProfile(Team.GetID(DataGridMatches.SelectedCells(0).Value))
            openTeam.Show()
        ElseIf e.ColumnIndex = 5 Then
            'Cast button clicked
            MsgBox("Confirmed")
        End If
    End Sub

    Private Sub DataGridLadder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridLadder.CellContentClick
        'Team selected
        Dim curRow = DataGridLadder.SelectedRows(0).Index
        Dim openTeam As New teamProfile(Team.GetID(DataGridLadder.Item(2, curRow).Value))
        openTeam.Show()
    End Sub

    Private Sub btnChangeProfilePic_Click(sender As Object, e As EventArgs) Handles btnChangeProfilePic.Click
        Dim newProfilePic As String = InputBox("Enter URL of new profile picture:", "https://thumbs.dreamstime.com/b/default-avatar-profile-flat-icon-social-media-user-vector-portrait-unknown-human-image-default-avatar-profile-flat-icon-184330869.jpg")
        If DbConnect() Then
            Dim sqlcmd As New OleDbCommand
            With sqlcmd
                .Connection = cn
                .CommandText = ("Update Users SET ProfilePicture = @ProfilePic WHERE UserID = @UserID")
                .Parameters.AddWithValue("@ProfilePic", newProfilePic)
                .Parameters.AddWithValue("@UserID", MyUser.ID)
                .ExecuteNonQuery()
                RefreshUserInfo()
            End With
        End If
    End Sub

    Private Sub listRecruitingTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listRecruitingTeams.SelectedIndexChanged
        Dim teamID As Integer = Team.GetID(listRecruitingTeams.SelectedItems(0).Text)
        Dim openTeam As New teamProfile(teamID)
        openTeam.ShowDialog()
    End Sub

    Private Sub topPanel_Paint(sender As Object, e As PaintEventArgs) Handles topPanel.Paint

    End Sub

    Private Sub btnKickPlayer2_Click(sender As Object, e As EventArgs) Handles btnKickPlayer2.Click
        MyTeam.KickPlayer(MyTeam.Player2)
    End Sub

    Private Sub btnKickPlayer3_Click(sender As Object, e As EventArgs) Handles btnKickPlayer3.Click
        MyTeam.KickPlayer(MyTeam.Player3)
    End Sub

    Private Sub btnKickPlayer4_Click(sender As Object, e As EventArgs) Handles btnKickPlayer4.Click
        MyTeam.KickPlayer(MyTeam.Player4)
    End Sub

    Private Sub btnKickSub1_Click(sender As Object, e As EventArgs) Handles btnKickSub1.Click
        MyTeam.KickPlayer(MyTeam.Sub1)
    End Sub

    Private Sub btnKickSub2_Click(sender As Object, e As EventArgs) Handles btnKickSub2.Click
        MyTeam.KickPlayer(MyTeam.Sub2)
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnAdminPanel_Click(sender As Object, e As EventArgs) Handles btnAdminPanel.Click
        AdminPanel.Show()
    End Sub
End Class
