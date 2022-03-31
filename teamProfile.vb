Imports System.Windows.Forms

Public Class teamProfile

    Dim thisTeam As Team

    Sub New(teamID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Load team info
        thisTeam = New Team(teamID)
        lblTopText.Text = thisTeam.Name

        'Load player info
        If thisTeam.ID = -1 = False Then
            If DbConnect() Then
                Dim SQLCmd As New OleDb.OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From Team Where TeamID = @TeamID"
                    .Parameters.AddWithValue("@TeamID", thisTeam.ID)
                    Dim rs As OleDb.OleDbDataReader = .ExecuteReader

                    If rs.Read Then
                        'Team Name and Logo, Rank details
                        lblTeamName.Text = thisTeam.Name
                        lblTeamRanking.Text = CalculateRank(thisTeam.Ranking)
                        lblTeamRegion.Text = thisTeam.ranking
                        picTeamRank.Load(GetRankLogo(lblTeamRanking.Text))
                        picTeamLogo.Load(thisTeam.Logo)

                        'Recruiting info/join button
                        If thisTeam.LookingForPlayers = False Then
                            lblRecruit.Text = "This team is NOT currently recruiting."
                            lblRecruit.ForeColor = Color.Red
                            btnJoin.Enabled = False
                        ElseIf thisTeam.ID = MyUser.TeamID Then
                            'Stops the user from requesting to join their own team.
                            lblRecruit.Text = "This is your team."
                            lblRecruit.ForeColor = Color.Lime
                            btnJoin.Enabled = False
                        ElseIf MyUser.TeamID <> -1 Then
                            'Stops the user from joining a team when they are already in a team.
                            lblRecruit.Text = "You are already in a team."
                            lblRecruit.ForeColor = Color.Orange
                            btnJoin.Enabled = False
                        End If

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
                    End If
                    rs.Close()
                End With
            End If
        End If
    End Sub

    Private Sub lblPlayer1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer1.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Captain)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer2.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Player2)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer3.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Player3)
        playerPopout.Show()
    End Sub

    Private Sub lblPlayer4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPlayer4.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Player4)
        playerPopout.Show()
    End Sub

    Private Sub lblSub1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSub1.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Sub1)
        playerPopout.Show()
    End Sub

    Private Sub lblSub2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSub2.LinkClicked
        Dim playerPopout As New playerProfile(thisTeam.Sub2)
        playerPopout.Show()
    End Sub

    ' // Custom border style
    'Buttons
    Private Sub btnMinimize_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        Dim capt As New User(thisTeam.Captain)
        'Send TeamJoinRequest notification to the team captain.
        Dim x As New Notification(Nothing, "TeamJoinRequest", DateTime.Now.ToLongDateString, capt, MyUser)
        Notification.Send(x)
    End Sub

    Private Sub teamProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
