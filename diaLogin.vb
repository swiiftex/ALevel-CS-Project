Imports System.Windows.Forms

Public Class diaLogin

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If Login(txtUsername.Text, txtPassword.Text) = True Then
            'Login is successful
            RefreshUserInfo()
            My.Settings.username = txtUsername.Text
            If chkRememberPass.Checked Then
                My.Settings.stayLoggedIn = True
                My.Settings.password = txtPassword.Text
            Else
                My.Settings.stayLoggedIn = False
            End If
            Me.Close()
            FormMain.Show()
        Else
            'Login unsuccessful.
            MsgBox("Incorrect username or password.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            If MyUser.ID = Nothing = False Then
                MyUser.TeamID = -1
                MyUser.Username = Nothing
                loggedIn = False
                MyUser.IsAdmin = False
                MyUser.IsModerator = False
                My.Settings.username = Nothing
                My.Settings.password = Nothing
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Application.Exit()
                Me.Close()
            End If
        Catch Ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub CreateAccount_Button_Click(sender As Object, e As EventArgs) Handles CreateAccount_Button.Click
        diaCreateAccount.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub diaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Clear()
        txtPassword.Clear()
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


    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class
