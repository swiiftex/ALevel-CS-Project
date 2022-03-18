Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class diaCreateAccount

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            Try
                'Add a new user with the username and password
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Insert into Users (Username, Pass, DiscordTag, ProfilePicture, TeamID, Mon, Tue, Wed, Thu, Fri, Sat, Sun) " &
                    "Values (@Username, @Pass, @DiscordTag, @ProfilePicture, -1, '1-11', '1-11', '1-11', '1-11', '1-11', '1-11', '1-11')"
                    .Parameters.AddWithValue("@Username", txtUsername.Text)
                    .Parameters.AddWithValue("@Pass", txtPassword.Text)
                    .Parameters.AddWithValue("@DiscordTag", txtDiscord.Text)
                    .Parameters.AddWithValue("@ProfilePicture", defaultProfilePicture)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cn.Close()
        End If

        MsgBox("User has been successfully created. You may now log in.")
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
