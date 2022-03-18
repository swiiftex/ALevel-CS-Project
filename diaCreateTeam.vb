Imports System.Windows.Forms

Public Class diaCreateTeam

    Dim teamLogo As String = defaultProfilePicture

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        If txtTeamName.Text = Nothing Then
            MsgBox("You must enter a team name.")
        ElseIf comboRegion.Text = Nothing Then
            MsgBox("You must select a region.")
        Else
            'Create a new team in the database.
            If DbConnect() Then
                'Create team
                Dim SQLCmd As New OleDb.OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Insert into Team (TeamName, PlayerCaptain, TeamLogoURL, Region, LookingForPlayers, Ranking, Player2, Player3, Player4, Sub1, Sub2 ) " &
                     "Values (@TeamName, @PlayerCaptain, @TeamLogoURL, @Region, @LookingForPlayers, 250, 0, 0, 0, 0, 0);"
                    .Parameters.AddWithValue("@TeamName", txtTeamName.Text)
                    .Parameters.AddWithValue("@PlayerCaptain", MyUser.ID)
                    .Parameters.AddWithValue("@TeamLogoURL", teamLogo)
                    .Parameters.AddWithValue("@Region", comboRegion.Text)
                    .Parameters.AddWithValue("@LookingForPlayers", checkRecruiting.Checked)
                    .ExecuteNonQuery()
                End With
                MsgBox("Team successfully created.")

                MyUser.TeamID = Team.GetID(txtTeamName.Text)

                'Update foreign key for team on player record
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Update Users Set TeamID = " & MyUser.TeamID & " Where UserID = " & MyUser.ID
                    .ExecuteNonQuery()
                    MsgBox("Team ID updated to " & MyUser.TeamID)
                End With

            End If
            RefreshUserInfo()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub diaCreateTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Load(defaultProfilePicture)
    End Sub

    Private Sub btnChangeLogo_Click(sender As Object, e As EventArgs) Handles btnChangeLogo.Click
        teamLogo = InputBox("Enter image URL.", "Change Logo", defaultProfilePicture)
        picLogo.Load(teamLogo)
    End Sub

    'Custom border style
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

End Class
