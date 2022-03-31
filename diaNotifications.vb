Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class diaNotifications

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Dim Notifications As List(Of Notification)

    Private Sub diaNotifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear notifications
        datagridNotifications.Rows.Clear()

        Notifications = New List(Of Notification)

        If MyTeam.Captain = MyUser.ID Then
            'Insert notifications for each weekly match with a TimeSet of -1
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From Matches Where TimeSet = @TimeSet AND (OrangeTeam = @TeamID OR BlueTeam = @TeamID)"
                    .Parameters.AddWithValue("@TimeSet", -1)
                    .Parameters.AddWithValue("@TeamID", MyTeam.ID)
                    Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                    Do Until rs.Read = False
                        Dim noti As New Notification(Nothing, "WeeklyMatch", "Weekly", MyUser, New User(-1), rs("MatchID"))
                        Notifications.Add(noti)
                    Loop
                End With
            End If
        End If

        'Load the notifications into the DataGridView.
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Notification Where RecipientID = @RecipientID"
                .Parameters.AddWithValue("@RecipientID", MyUser.ID)
                Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                Do Until rs.Read = False
                    Dim noti As New Notification(rs("NotifID"), rs("NotifiType"), rs("TimeSent"), New User(rs("RecipientID")), New User(rs("SenderID")), rs("MatchID"))
                    Notifications.Add(noti)
                Loop
            End With
        End If

        For Each Noti As Notification In Notifications

            'Get the sender (-1 = system, otherwise get the username from the ID given)
            Dim send As String
            If Noti.Sender.ID = -1 Then
                send = "System"
            Else
                send = Noti.Sender.Username
            End If

            Dim senderTeam As New Team(Noti.Sender.TeamID)
            Dim btnText As String = Nothing
            Dim text As String = Nothing
            If Noti.Type = "MatchRequest" Then
                text = "Match requested from " & senderTeam.Name
                btnText = "Accept"
            ElseIf Noti.Type = "ScoreReminder" Then
                text = "Input your scores for a recently played match: " & Noti.MatchID
                btnText = "Submit"
            ElseIf Noti.Type = "TeamJoinRequest" Then
                text = Noti.Sender.Username & "(" & Noti.Sender.DiscordTag & ") is requesting to join your team!"
                btnText = "Review"
            ElseIf Noti.Type = "WeeklyMatch" Then
                Dim ThisMatch As Match = Match.GetExisting(Noti.MatchID)
                text = "Your weekly match is ready! " & ThisMatch.OrangeTeam.Name & " vs " & ThisMatch.BlueTeam.Name
                btnText = "Play"
            Else
                Dim x() As String
                x = Noti.Type.Split
                text = x(1)
                btnText = "Dismiss"
            End If

            'Create row to put into the table
            Dim row As String() = New String() {Noti.TimeSent, send, text, btnText}

            'Add the row
            datagridNotifications.Rows.Add(row)
        Next


    End Sub

    ' // Custom border style
    'Buttons
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

    Private Sub datagridNotifications_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridNotifications.CellContentClick
        'Notification button clicked
        If e.ColumnIndex = 3 Then
            Dim selectedNoti As Notification = Notifications(e.RowIndex)
            'TeamJoinRequest
            If selectedNoti.Type = "TeamJoinRequest" Then
                Dim openPlayer As New playerProfile(selectedNoti.Sender.ID, True, selectedNoti.ID)
                openPlayer.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub topPanel_Paint(sender As Object, e As PaintEventArgs) Handles topPanel.Paint

    End Sub
End Class
