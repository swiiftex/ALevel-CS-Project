Public Class playerProfile

    Dim player As User

    Sub New(playerID As Integer, Optional requestingJoin As Boolean = False, Optional NotifID As Integer = Nothing)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Load player info
        player = New User(playerID)
        picProfile.Load(player.ProfilePic)
        lblUsername.Text = player.Username

        'Load team info
        If player.TeamID = -1 = False Then
            Dim playerTeam As New Team(player.TeamID)
            lblProfileTeamName.Text = playerTeam.Name
        End If

        'Add Accept and Decline button if the player is requesting to join
        If requestingJoin = True Then
            btnAccept.Show()
            btnDecline.Show()
        Else
            btnAccept.Hide()
            btnDecline.Hide()
        End If
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

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim MyTeam As New Team(MyUser.TeamID)
        If player.TeamID = -1 And (MyTeam.GetEmptySlot = Nothing = False) Then
            If MyTeam.GetEmptySlot = "Sub1" Or MyTeam.GetEmptySlot = "Sub2" Then
                MsgBox("All roster slots are full. Moving player to substitute position.")
            End If
            Try
                'Add user to team
                If DbConnect() Then
                    Dim sqlcmd As New OleDb.OleDbCommand
                    Dim sqlcmd2 As New OleDb.OleDbCommand
                    Dim sqlcmd3 As New OleDb.OleDbCommand
                    With sqlcmd
                        'Update User table
                        .Connection = cn
                        .CommandText = "UPDATE Users SET TeamID = @NewTeamID WHERE UserID = @UserID"
                        .Parameters.AddWithValue("@NewTeamID", MyUser.TeamID)
                        .Parameters.AddWithValue("@UserID", player.ID)
                        .ExecuteNonQuery()
                    End With
                    With sqlcmd2
                        'Add user to team page
                        .Connection = cn
                        .CommandText = "UPDATE Team SET " & MyTeam.GetEmptySlot & " = @UserID WHERE TeamID = @TeamID"
                        .Parameters.AddWithValue("@UserID", player.ID)
                        .Parameters.AddWithValue("@TeamID", MyUser.TeamID)
                        .ExecuteNonQuery()
                    End With
                    'Remove notification
                    With sqlcmd3
                        .Connection = cn
                        .CommandText = "Select * From Notification WHERE NotifiType = @TeamJoinRequest AND SenderID = @PlayerID"
                        .Parameters.AddWithValue("@TeamJoinRequest", "TeamJoinRequest")
                        .Parameters.AddWithValue("@PlayerID", player.ID)
                        Dim rs As OleDb.OleDbDataReader = .ExecuteReader
                        If rs.Read Then
                            Notification.Delete(rs("NotifID"))
                        End If
                    End With
                End If
            Catch ex As Exception
                MsgBox("Error adding player: " & ex.Message)
            End Try
        Else
            MsgBox("Error: User is already in a team or there are no empty slots.")
        End If

        RefreshUserInfo()
        Me.Close()
    End Sub

    Private Sub topPanel_Paint(sender As Object, e As PaintEventArgs) Handles topPanel.Paint

    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click

    End Sub

    Private Sub playerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class