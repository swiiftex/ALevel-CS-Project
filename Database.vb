Imports System.Data.OleDb

Module Database

    Public Const DataBasePath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='VRMLDatabase.mdb';Persist Security Info=False;"
    Public cn As OleDbConnection

    Public defaultProfilePicture As String = "https://thumbs.dreamstime.com/b/default-avatar-profile-flat-icon-social-media-user-vector-portrait-unknown-human-image-default-avatar-profile-flat-icon-184330869.jpg"

    Public loggedIn As Boolean = False
    Public MyUser As User

    Public Function DbConnect() As Boolean
        Try
            cn = New OleDbConnection(DataBasePath)
            cn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Unable to open the database: " & ex.Message)
            Return False
            Application.Exit()
        End Try
    End Function

    Public Class User
        Public ID As Integer
        Public Username As String
        Public DiscordTag As String
        Public ProfilePic As String
        Public TeamID As Integer
        Public IsModerator As Boolean
        Public IsAdmin As Boolean
        Public AvailMon(2), AvailTue(2), AvailWed(2), AvailThu(2), AvailFri(2), AvailSat(2), AvailSun(2) As String

        Sub New(NewID As Integer)
            ID = NewID
            'Fill the rest of the data based on the ID
            If DbConnect() And (ID = -1) = False Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From Users where UserID = @UserID"
                    .Parameters.AddWithValue("@UserID", NewID)
                    Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                    If rs.Read Then
                        Username = rs("Username")
                        DiscordTag = rs("DiscordTag")
                        ProfilePic = rs("ProfilePicture")
                        TeamID = rs("TeamID")
                        IsModerator = rs("Moderator")
                        IsAdmin = rs("Administrator")
                        AvailMon = ConvertAvailability(rs("Mon"))
                        AvailTue = ConvertAvailability(rs("Tue"))
                        AvailWed = ConvertAvailability(rs("Wed"))
                        AvailThu = ConvertAvailability(rs("Thu"))
                        AvailFri = ConvertAvailability(rs("Fri"))
                        AvailSat = ConvertAvailability(rs("Sat"))
                        AvailSun = ConvertAvailability(rs("Sun"))
                    End If
                End With
            End If
        End Sub
    End Class

    Public Class Notification
        Public ID As Integer
        Public Type As String
        Public TimeSent As String
        Public Recipient As User
        Public Sender As User
        Public MatchID As Integer

        Sub New(NewID As Integer, NewType As String, NewTime As String, NewRecipient As User, NewSender As User, Optional NewMatchID As Integer = -1)
            If ID = Nothing = False Then
                ID = NewID
            End If
            Type = NewType
            TimeSent = NewTime
            Recipient = NewRecipient
            Sender = NewSender
            MatchID = NewMatchID
        End Sub

        Public Shared Sub Send(ID As Notification)
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Insert into Notification (NotifiType, TimeSent, RecipientID, SenderID, MatchID) Values (@Type, @Time, @Recipient, @Sender, @Match)"
                    .Parameters.AddWithValue("@Type", ID.Type)
                    .Parameters.AddWithValue("@Time", ID.TimeSent)
                    .Parameters.AddWithValue("@Recipient", ID.Recipient.ID)
                    .Parameters.AddWithValue("@Sender", ID.Sender.ID)
                    .Parameters.AddWithValue("@Match", ID.MatchID)
                    .ExecuteNonQuery()
                End With
                MsgBox("Notification sent!")
            End If
        End Sub
    End Class

    Public Class Team
        Public ID As Integer
        Public Name As String
        Public Captain As Integer
        Public Player2 As Integer
        Public Player3 As Integer
        Public Player4 As Integer
        Public Sub1 As Integer
        Public Sub2 As Integer
        Public Logo As String
        Public Region As String
        Public LookingForPlayers As Boolean
        Public Ranking As Integer

        Sub New(NewID As Integer)
            ID = NewID
            'Fill the rest of the data based on the ID
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From Team where TeamID = @TeamID"
                    .Parameters.AddWithValue("@TeamID", NewID)
                    Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                    If rs.Read Then
                        Name = rs("TeamName")
                        Captain = rs("PlayerCaptain")
                        Player2 = rs("Player2")
                        Player3 = rs("Player3")
                        Player4 = rs("Player4")
                        Sub1 = rs("Sub1")
                        Sub2 = rs("Sub2")
                        Logo = rs("TeamLogoURL")
                        Region = rs("Region")
                        LookingForPlayers = rs("LookingForPlayers")
                        Ranking = rs("Ranking")
                    End If
                End With
            End If
        End Sub

        Public Shared Function GetID(TeamName As String) As Integer
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From Team where TeamName = @TeamName"
                    .Parameters.AddWithValue("@TeamName", TeamName)
                    Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                    If rs.Read Then
                        Return rs("TeamID")
                    End If
                    Return Nothing
                End With
            End If
        End Function

        Public Function GetEmptySlot() As String
            'Returns the closest empty team slot
            If Player2 = Nothing Then
                Return "Player2"
            ElseIf Player3 = Nothing Then
                Return "Player3"
            ElseIf Player4 = Nothing Then
                Return "Player4"
            ElseIf Sub1 = Nothing Then
                Return "Sub1"
            ElseIf Sub2 = Nothing Then
                Return "Sub2"
            Else
                Return Nothing
            End If
        End Function

    End Class

    Public Function Login(username As String, Pass As String) As Boolean
        'Check if username and Pass matches database.
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Users where Username = @Username"
                .Parameters.AddWithValue("@Username", username)
                Dim rs As OleDbDataReader = SQLCmd.ExecuteReader

                If rs.Read Then
                    If rs("Pass") = Pass Then
                        'Case: Pass matches username
                        MyUser = New User(rs("UserID"))
                        loggedIn = True
                    Else
                        Return False
                    End If

                    Return loggedIn
                End If
                Return False
            End With
        End If
    End Function

    Public Sub RefreshUserInfo()
        FormMain.UpdateUserInfo()
    End Sub

    Public Function CalculateRank(ranking As Integer)
        If ranking < 100 Then
            Return "Bronze"
        ElseIf 100 <= ranking < 200 Then
            Return "Silver"
        ElseIf 200 <= ranking < 300 Then
            Return "Gold"
        ElseIf 300 <= ranking < 400 Then
            Return "Platinum"
        ElseIf ranking > 400 Then
            Return "Diamond"
        Else
            Return "Ranking Error"
        End If
    End Function

    Public Function GetRankLogo(rank As String) As String
        If rank = "Bronze" Then
            Return "https://vrmasterleague.com/images/div_bronze_4_40.png"
        ElseIf rank = "Silver" Then
            Return "https://vrmasterleague.com/images/div_silver_1_40.png"
        ElseIf rank = "Gold" Then
            Return "https://vrmasterleague.com/images/div_gold_4_40.png"
        ElseIf rank = "Platinum" Then
            Return "https://vrmasterleague.com/images/div_platinum_4_40.png"
        ElseIf rank = "Diamond" Then
            Return "https://vrmasterleague.com/images/div_diamond_4_40.png"
        ElseIf rank = "Master" Then
            Return "https://vrmasterleague.com/images/div_master_40.png"
        Else
            Return ""
        End If
    End Function

    Public Function ConvertArrayToDatabaseSchedule(input() As String) As String
        Dim ReturnValue As String
        ReturnValue = input(0) & "-" & input(1)
        Return ReturnValue
    End Function

    Public Function GetProfilePicture(userID As Integer) As String
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Users where UserID = @UserID"
                .Parameters.AddWithValue("@UserID", userID)
                Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                If rs.Read Then
                    Return rs("ProfilePicture")
                End If
            End With
            Return defaultProfilePicture
        End If
    End Function

    Public Function GetUsername(userID As Integer) As String
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From Users where UserID = @UserID"
                .Parameters.AddWithValue("@UserID", userID)
                Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
                If rs.Read Then
                    Return rs("Username")
                End If
                Return Nothing
            End With
        End If
    End Function

    Public Function ConvertAvailability(availability) As String()
        'Availability conversion
        'Return format is a string array.
        '// 0 = Start
        '// 1 = End
        '// 2 = Both in a readable format

        Dim newValues() As String = availability.Split("-")
        Dim finalValues(2) As String

        finalValues(0) = newValues(0)
        finalValues(1) = newValues(1)

        If newValues(0) = "0" Then
            finalValues(2) = "12AM - " & newValues(1) & "PM"
        Else
            finalValues(2) = newValues(0) & "PM - " & newValues(1) & "PM"
        End If
        Return finalValues

    End Function

    Public Function UpdateAvailabilities()
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Update Users Set Mon = @Mon, Tue = @Tue, Wed = @Wed, Thu = @Thu, Fri = @Fri, Sat = @Sat, Sun = @Sun WHERE UserID = @UserID"
                .Parameters.AddWithValue("@Mon", ConvertArrayToDatabaseSchedule(MyUser.AvailMon))
                .Parameters.AddWithValue("@Tue", ConvertArrayToDatabaseSchedule(MyUser.AvailTue))
                .Parameters.AddWithValue("@Wed", ConvertArrayToDatabaseSchedule(MyUser.AvailWed))
                .Parameters.AddWithValue("@Thu", ConvertArrayToDatabaseSchedule(MyUser.AvailThu))
                .Parameters.AddWithValue("@Fri", ConvertArrayToDatabaseSchedule(MyUser.AvailFri))
                .Parameters.AddWithValue("@Sat", ConvertArrayToDatabaseSchedule(MyUser.AvailSat))
                .Parameters.AddWithValue("@Sun", ConvertArrayToDatabaseSchedule(MyUser.AvailSun))
                .Parameters.AddWithValue("@UserID", MyUser.ID)
                .ExecuteNonQuery()
            End With
        End If

    End Function

    Public Function ConvertSliderValToTime(slider As DoubleTrackBar) As String
        'Changes the value given by the double track bar, and outputs a time formatted string
        Dim values(1) As Integer
        values(0) = slider.ValueLeft
        values(1) = slider.ValueRight

        Dim outputs(1) As String
        For i = 0 To 1
            If values(i) > 0 Then
                If values(i) Mod 2 = 0 Then
                    outputs(i) = 12 + (values(i) / 2) & ":00"
                Else
                    outputs(i) = 12 + ((values(i) - 1) / 2) & ":30"
                End If
            Else
                outputs(i) = "12:00"
            End If
        Next

        Return outputs(0) & "-" & outputs(1)
    End Function

    Public Sub CreateMatch(orange As Team, blue As Team, time As String, season As Integer)
        If DbConnect() Then
            Dim sqlcmd As New OleDbCommand
            With sqlcmd
                .Connection = cn
                .CommandText = "Insert into Matches (OrangeScore, BlueScore, OrangeTeam, BlueTeam, TimeSet, SeasonNumber, Casted, Region) Values (-1, -1, @OrangeTeam, @BlueTeam, @TimeSet, @SeasonNumber, False, @Region);"
                .Parameters.AddWithValue("@OrangeTeam", orange.ID)
                .Parameters.AddWithValue("@BlueTeam", blue.ID)
                .Parameters.AddWithValue("@TimeSet", time)
                .Parameters.AddWithValue("@SeasonNumber", season)
                .Parameters.AddWithValue("@Region", orange.Region)
                .ExecuteNonQuery()
            End With
        End If
    End Sub

    Public Function FormatTimeToDb(time As DateTime) As String
        Dim timeReturn As String
        timeReturn = time.Date.ToShortDateString & "," & time.ToShortTimeString
        Return timeReturn
    End Function

End Module


'// OLD UNUSED CODE

'Public Function GetNotifications(UserID As Integer)
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Notification Where RecipientID = @RecipientID"
'            .Parameters.AddWithValue("@RecipientID", UserID)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            Dim Notifications As List(Of Notification)
'            If rs.Read Then
'                Dim noti As Notification
'                Do Until rs.Read = False
'                    noti.ID = rs("NotifID")
'                    noti.Type = rs("NotifiType")
'                    noti.TimeSent = rs("TimeSent")
'                    noti.Recipient = rs("RecipientID")
'                    noti.Sender = rs("SenderID")
'                    noti.MatchID = rs("MatchID")
'                    MsgBox(noti.ID)
'                    Notifications.Add(noti)
'                Loop
'                Return Notifications
'            End If
'            rs.Close()
'        End With
'        Return Nothing
'    End If
'End Function

'Function GetTeamID(TeamName As String) As Integer
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team where TeamName = @TeamName"
'            .Parameters.AddWithValue("@TeamName", TeamName)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            If rs.Read Then
'                Return rs("TeamID")
'            End If
'            Return Nothing
'        End With
'    End If
'End Function

'Function GetLogo(TeamID As Integer)
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team where TeamID = @TeamID"
'            .Parameters.AddWithValue("@TeamID", TeamID)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            If rs.Read Then
'                Return rs("TeamLogoURL")
'            End If
'            Return Nothing
'        End With
'    End If
'End Function

'Function GetRanking(TeamID As Integer)
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team where TeamID = @TeamID"
'            .Parameters.AddWithValue("@TeamID", TeamID)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            If rs.Read Then
'                Return rs("Ranking")
'            End If
'            Return Nothing
'        End With
'    End If
'End Function


'Function GetTeamName(TeamID As Integer)
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team where TeamID = @TeamID"
'            .Parameters.AddWithValue("@TeamID", TeamID)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            If rs.Read Then
'                Return rs("TeamName")
'            End If
'            Return Nothing
'        End With
'    End If
'End Function



'Function GetTeamIDFromCaptain(UserID As Integer)

'    If DbConnect() Then
'        Dim SQLCmd As New OleDb.OleDbCommand
'        'Find team ID
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team Where PlayerCaptain = @MyUserID;"
'            .Parameters.AddWithValue("@MyUserID", UserID)
'            Dim rs As OleDb.OleDbDataReader = .ExecuteReader()
'            If rs.Read Then
'                Return rs("TeamID")
'            End If
'            rs.Close()
'        End With
'    End If

'End Function

'Function GetTeamCaptain(TeamID As Integer) As Integer

'    If DbConnect() Then
'        Dim SQLCmd As New OleDb.OleDbCommand
'        'Find team captain
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team Where TeamID = @MyUser.ID;"
'            .Parameters.AddWithValue("@MyUser.ID", TeamID)
'            Dim rs As OleDb.OleDbDataReader = .ExecuteReader()
'            If rs.Read Then
'                Return rs("PlayerCaptain")
'            End If
'            rs.Close()
'        End With
'    End If

'End Function

'Function RemovePlayer(playerID As Integer, teamID As Integer)
'    If DbConnect() Then
'        Dim sqlcmd As New OleDbCommand
'        With sqlcmd
'            .Connection = cn
'            .CommandText = "SELECT * FROM Team WHERE TeamID = @TeamID"
'            .Parameters.AddWithValue("@TeamID", teamID)
'        End With
'    End If

'End Function

'Function GetTeamRegion(TeamID As Integer)
'    If DbConnect() Then
'        Dim SQLCmd As New OleDbCommand
'        With SQLCmd
'            .Connection = cn
'            .CommandText = "Select * From Team where TeamID = @TeamID"
'            .Parameters.AddWithValue("@TeamID", TeamID)
'            Dim rs As OleDbDataReader = SQLCmd.ExecuteReader
'            If rs.Read Then
'                Return rs("Region")
'            End If
'            Return Nothing
'        End With
'    End If
'End Function