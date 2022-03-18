Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class diaCreateMatch

    Dim home As Team
    Dim away As Team

    Private Sub diaCreateMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        home = New Team(MyUser.TeamID)
        Dim curRow = FormMain.DataGridLadder.SelectedRows(0).Index
        away = New Team(Team.GetID(FormMain.DataGridLadder.Item(2, curRow).Value))
        txtHome.Text = home.Name
        txtAway.Text = FormMain.DataGridLadder.SelectedCells(0).Value
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim noti As New Notification(0, "MatchRequest", datePicker.Value.ToShortDateString & "," & lblTime.Text, New User(away.Captain), MyUser, -1)
        Notification.Send(noti)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub trackbarTime_Scroll(sender As Object, e As EventArgs) Handles trackbarTime.Scroll
        lblTime.Text = 12 + trackbarTime.Value & ":00"
    End Sub
End Class
