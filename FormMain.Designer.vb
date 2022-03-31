<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.groupMyInfo = New System.Windows.Forms.GroupBox()
        Me.btnChangeProfilePic = New System.Windows.Forms.Button()
        Me.lblProfileTeamName = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.TabProfile = New System.Windows.Forms.TabPage()
        Me.btnAdminPanel = New System.Windows.Forms.Button()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.listPersonalParticipation = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.availText = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sliderSun = New VRMLScheduler.DoubleTrackBar()
        Me.sliderSat = New VRMLScheduler.DoubleTrackBar()
        Me.sliderFri = New VRMLScheduler.DoubleTrackBar()
        Me.sliderThur = New VRMLScheduler.DoubleTrackBar()
        Me.sliderWed = New VRMLScheduler.DoubleTrackBar()
        Me.sliderTue = New VRMLScheduler.DoubleTrackBar()
        Me.sliderMon = New VRMLScheduler.DoubleTrackBar()
        Me.btnSaveAvailability = New System.Windows.Forms.Button()
        Me.TabFindTeam = New System.Windows.Forms.TabPage()
        Me.listRecruitingTeams = New System.Windows.Forms.ListView()
        Me.RankImages = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRefreshRecruiting = New System.Windows.Forms.Button()
        Me.btnCreateTeam = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabTeam = New System.Windows.Forms.TabPage()
        Me.btnLeaveTeam = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listRecentMatches = New System.Windows.Forms.ListBox()
        Me.listAvail = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKickSub2 = New System.Windows.Forms.Button()
        Me.btnKickSub1 = New System.Windows.Forms.Button()
        Me.lblSub2 = New System.Windows.Forms.LinkLabel()
        Me.lblSub1 = New System.Windows.Forms.LinkLabel()
        Me.picSub2 = New System.Windows.Forms.PictureBox()
        Me.picSub1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblteamAvail = New System.Windows.Forms.Label()
        Me.btnKickPlayer4 = New System.Windows.Forms.Button()
        Me.btnKickPlayer3 = New System.Windows.Forms.Button()
        Me.btnKickPlayer2 = New System.Windows.Forms.Button()
        Me.lblPlayer4 = New System.Windows.Forms.LinkLabel()
        Me.lblPlayer3 = New System.Windows.Forms.LinkLabel()
        Me.lblPlayer2 = New System.Windows.Forms.LinkLabel()
        Me.lblPlayer1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picTeamRank = New System.Windows.Forms.PictureBox()
        Me.picTeamLogo = New System.Windows.Forms.PictureBox()
        Me.lblTeamRanking = New System.Windows.Forms.Label()
        Me.lblTeamRegion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.TabMatches = New System.Windows.Forms.TabPage()
        Me.btnRefreshMatches = New System.Windows.Forms.Button()
        Me.DataGridMatches = New System.Windows.Forms.DataGridView()
        Me.ColumnTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Region = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ranking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnOrange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnBlue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caster = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabLadder = New System.Windows.Forms.TabPage()
        Me.btnRefreshLadder = New System.Windows.Forms.Button()
        Me.btnCreateMatch = New System.Windows.Forms.Button()
        Me.DataGridLadder = New System.Windows.Forms.DataGridView()
        Me.MMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.AvailabilityToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupMyInfo.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.TabProfile.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabFindTeam.SuspendLayout()
        Me.TabTeam.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picSub2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSub1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeamRank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeamLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMatches.SuspendLayout()
        CType(Me.DataGridMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLadder.SuspendLayout()
        CType(Me.DataGridLadder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(14, 161)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(142, 18)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Not Logged In"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'groupMyInfo
        '
        Me.groupMyInfo.Controls.Add(Me.btnChangeProfilePic)
        Me.groupMyInfo.Controls.Add(Me.lblProfileTeamName)
        Me.groupMyInfo.Controls.Add(Me.picProfile)
        Me.groupMyInfo.Controls.Add(Me.lblUsername)
        Me.groupMyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupMyInfo.Location = New System.Drawing.Point(15, 20)
        Me.groupMyInfo.Name = "groupMyInfo"
        Me.groupMyInfo.Size = New System.Drawing.Size(171, 217)
        Me.groupMyInfo.TabIndex = 1
        Me.groupMyInfo.TabStop = False
        '
        'btnChangeProfilePic
        '
        Me.btnChangeProfilePic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeProfilePic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnChangeProfilePic.Location = New System.Drawing.Point(6, 13)
        Me.btnChangeProfilePic.Name = "btnChangeProfilePic"
        Me.btnChangeProfilePic.Size = New System.Drawing.Size(54, 24)
        Me.btnChangeProfilePic.TabIndex = 4
        Me.btnChangeProfilePic.Text = "Change"
        Me.btnChangeProfilePic.UseVisualStyleBackColor = True
        '
        'lblProfileTeamName
        '
        Me.lblProfileTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileTeamName.Location = New System.Drawing.Point(14, 185)
        Me.lblProfileTeamName.Name = "lblProfileTeamName"
        Me.lblProfileTeamName.Size = New System.Drawing.Size(142, 18)
        Me.lblProfileTeamName.TabIndex = 3
        Me.lblProfileTeamName.Text = "No Team Name"
        Me.lblProfileTeamName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picProfile
        '
        Me.picProfile.Location = New System.Drawing.Point(18, 21)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(135, 135)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 2
        Me.picProfile.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.Location = New System.Drawing.Point(659, 6)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'tabMain
        '
        Me.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMain.Controls.Add(Me.TabProfile)
        Me.tabMain.Controls.Add(Me.TabFindTeam)
        Me.tabMain.Controls.Add(Me.TabTeam)
        Me.tabMain.Controls.Add(Me.TabMatches)
        Me.tabMain.Controls.Add(Me.TabLadder)
        Me.tabMain.HotTrack = True
        Me.tabMain.ItemSize = New System.Drawing.Size(170, 30)
        Me.tabMain.Location = New System.Drawing.Point(0, 23)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(751, 523)
        Me.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMain.TabIndex = 2
        Me.tabMain.TabStop = False
        '
        'TabProfile
        '
        Me.TabProfile.BackColor = System.Drawing.Color.DimGray
        Me.TabProfile.Controls.Add(Me.btnAdminPanel)
        Me.TabProfile.Controls.Add(Me.btnNotifications)
        Me.TabProfile.Controls.Add(Me.Label5)
        Me.TabProfile.Controls.Add(Me.listPersonalParticipation)
        Me.TabProfile.Controls.Add(Me.btnLogout)
        Me.TabProfile.Controls.Add(Me.GroupBox3)
        Me.TabProfile.Controls.Add(Me.groupMyInfo)
        Me.TabProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabProfile.Location = New System.Drawing.Point(4, 34)
        Me.TabProfile.Name = "TabProfile"
        Me.TabProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProfile.Size = New System.Drawing.Size(743, 485)
        Me.TabProfile.TabIndex = 0
        Me.TabProfile.Text = "My Profile"
        '
        'btnAdminPanel
        '
        Me.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminPanel.ForeColor = System.Drawing.Color.Black
        Me.btnAdminPanel.Location = New System.Drawing.Point(451, 6)
        Me.btnAdminPanel.Name = "btnAdminPanel"
        Me.btnAdminPanel.Size = New System.Drawing.Size(98, 23)
        Me.btnAdminPanel.TabIndex = 3
        Me.btnAdminPanel.Text = "Admin Panel"
        Me.btnAdminPanel.UseVisualStyleBackColor = False
        Me.btnAdminPanel.Visible = False
        '
        'btnNotifications
        '
        Me.btnNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.ForeColor = System.Drawing.Color.Black
        Me.btnNotifications.Location = New System.Drawing.Point(555, 6)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(98, 23)
        Me.btnNotifications.TabIndex = 3
        Me.btnNotifications.Text = "Notifications"
        Me.btnNotifications.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "My Availability:"
        '
        'listPersonalParticipation
        '
        Me.listPersonalParticipation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listPersonalParticipation.FormattingEnabled = True
        Me.listPersonalParticipation.ItemHeight = 16
        Me.listPersonalParticipation.Location = New System.Drawing.Point(16, 257)
        Me.listPersonalParticipation.Name = "listPersonalParticipation"
        Me.listPersonalParticipation.Size = New System.Drawing.Size(170, 196)
        Me.listPersonalParticipation.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.availText)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.sliderSun)
        Me.GroupBox3.Controls.Add(Me.sliderSat)
        Me.GroupBox3.Controls.Add(Me.sliderFri)
        Me.GroupBox3.Controls.Add(Me.sliderThur)
        Me.GroupBox3.Controls.Add(Me.sliderWed)
        Me.GroupBox3.Controls.Add(Me.sliderTue)
        Me.GroupBox3.Controls.Add(Me.sliderMon)
        Me.GroupBox3.Controls.Add(Me.btnSaveAvailability)
        Me.GroupBox3.Location = New System.Drawing.Point(214, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 422)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'availText
        '
        Me.availText.AutoSize = True
        Me.availText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availText.Location = New System.Drawing.Point(197, 36)
        Me.availText.Name = "availText"
        Me.availText.Size = New System.Drawing.Size(129, 24)
        Me.availText.TabIndex = 8
        Me.availText.Text = "12:00 - 24:00"
        Me.availText.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 24)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Sun"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 24)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Sat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 24)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fri"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Thu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Wed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tue"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(456, 361)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 15)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "24:00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "12:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mon"
        '
        'sliderSun
        '
        Me.sliderSun.BackColor = System.Drawing.Color.DimGray
        Me.sliderSun.Location = New System.Drawing.Point(64, 326)
        Me.sliderSun.Maximum = 24
        Me.sliderSun.Minimum = 0
        Me.sliderSun.Name = "sliderSun"
        Me.sliderSun.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderSun.Size = New System.Drawing.Size(426, 22)
        Me.sliderSun.SmallChange = 1
        Me.sliderSun.TabIndex = 6
        Me.sliderSun.ValueLeft = 1
        Me.sliderSun.ValueRight = 11
        '
        'sliderSat
        '
        Me.sliderSat.BackColor = System.Drawing.Color.DimGray
        Me.sliderSat.Location = New System.Drawing.Point(64, 286)
        Me.sliderSat.Maximum = 24
        Me.sliderSat.Minimum = 0
        Me.sliderSat.Name = "sliderSat"
        Me.sliderSat.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderSat.Size = New System.Drawing.Size(426, 22)
        Me.sliderSat.SmallChange = 1
        Me.sliderSat.TabIndex = 7
        Me.sliderSat.ValueLeft = 1
        Me.sliderSat.ValueRight = 11
        '
        'sliderFri
        '
        Me.sliderFri.BackColor = System.Drawing.Color.DimGray
        Me.sliderFri.Location = New System.Drawing.Point(64, 243)
        Me.sliderFri.Maximum = 24
        Me.sliderFri.Minimum = 0
        Me.sliderFri.Name = "sliderFri"
        Me.sliderFri.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderFri.Size = New System.Drawing.Size(426, 22)
        Me.sliderFri.SmallChange = 1
        Me.sliderFri.TabIndex = 8
        Me.sliderFri.Text = " "
        Me.sliderFri.ValueLeft = 1
        Me.sliderFri.ValueRight = 11
        '
        'sliderThur
        '
        Me.sliderThur.BackColor = System.Drawing.Color.DimGray
        Me.sliderThur.Location = New System.Drawing.Point(64, 201)
        Me.sliderThur.Maximum = 24
        Me.sliderThur.Minimum = 0
        Me.sliderThur.Name = "sliderThur"
        Me.sliderThur.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderThur.Size = New System.Drawing.Size(426, 22)
        Me.sliderThur.SmallChange = 1
        Me.sliderThur.TabIndex = 9
        Me.sliderThur.ValueLeft = 1
        Me.sliderThur.ValueRight = 11
        '
        'sliderWed
        '
        Me.sliderWed.BackColor = System.Drawing.Color.DimGray
        Me.sliderWed.Location = New System.Drawing.Point(64, 159)
        Me.sliderWed.Maximum = 24
        Me.sliderWed.Minimum = 0
        Me.sliderWed.Name = "sliderWed"
        Me.sliderWed.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderWed.Size = New System.Drawing.Size(426, 22)
        Me.sliderWed.SmallChange = 1
        Me.sliderWed.TabIndex = 10
        Me.sliderWed.ValueLeft = 1
        Me.sliderWed.ValueRight = 11
        '
        'sliderTue
        '
        Me.sliderTue.BackColor = System.Drawing.Color.DimGray
        Me.sliderTue.Location = New System.Drawing.Point(64, 114)
        Me.sliderTue.Maximum = 24
        Me.sliderTue.Minimum = 0
        Me.sliderTue.Name = "sliderTue"
        Me.sliderTue.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderTue.Size = New System.Drawing.Size(426, 22)
        Me.sliderTue.SmallChange = 1
        Me.sliderTue.TabIndex = 11
        Me.sliderTue.ValueLeft = 1
        Me.sliderTue.ValueRight = 11
        '
        'sliderMon
        '
        Me.sliderMon.BackColor = System.Drawing.Color.DimGray
        Me.sliderMon.Location = New System.Drawing.Point(64, 72)
        Me.sliderMon.Maximum = 24
        Me.sliderMon.Minimum = 0
        Me.sliderMon.Name = "sliderMon"
        Me.sliderMon.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderMon.Size = New System.Drawing.Size(426, 22)
        Me.sliderMon.SmallChange = 1
        Me.sliderMon.TabIndex = 12
        Me.sliderMon.ValueLeft = 1
        Me.sliderMon.ValueRight = 11
        '
        'btnSaveAvailability
        '
        Me.btnSaveAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSaveAvailability.Location = New System.Drawing.Point(439, 393)
        Me.btnSaveAvailability.Name = "btnSaveAvailability"
        Me.btnSaveAvailability.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAvailability.TabIndex = 1
        Me.btnSaveAvailability.Text = "Save"
        Me.btnSaveAvailability.UseVisualStyleBackColor = True
        '
        'TabFindTeam
        '
        Me.TabFindTeam.BackColor = System.Drawing.Color.DimGray
        Me.TabFindTeam.Controls.Add(Me.listRecruitingTeams)
        Me.TabFindTeam.Controls.Add(Me.btnRefreshRecruiting)
        Me.TabFindTeam.Controls.Add(Me.btnCreateTeam)
        Me.TabFindTeam.Controls.Add(Me.Label4)
        Me.TabFindTeam.Location = New System.Drawing.Point(4, 34)
        Me.TabFindTeam.Name = "TabFindTeam"
        Me.TabFindTeam.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFindTeam.Size = New System.Drawing.Size(743, 485)
        Me.TabFindTeam.TabIndex = 4
        Me.TabFindTeam.Text = "Find a Team"
        '
        'listRecruitingTeams
        '
        Me.listRecruitingTeams.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.listRecruitingTeams.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listRecruitingTeams.HideSelection = False
        Me.listRecruitingTeams.LargeImageList = Me.RankImages
        Me.listRecruitingTeams.Location = New System.Drawing.Point(10, 41)
        Me.listRecruitingTeams.Name = "listRecruitingTeams"
        Me.listRecruitingTeams.Size = New System.Drawing.Size(724, 434)
        Me.listRecruitingTeams.TabIndex = 3
        Me.listRecruitingTeams.UseCompatibleStateImageBehavior = False
        Me.listRecruitingTeams.View = System.Windows.Forms.View.Tile
        '
        'RankImages
        '
        Me.RankImages.ImageStream = CType(resources.GetObject("RankImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RankImages.TransparentColor = System.Drawing.Color.Transparent
        Me.RankImages.Images.SetKeyName(0, "Bronze")
        Me.RankImages.Images.SetKeyName(1, "Silver")
        Me.RankImages.Images.SetKeyName(2, "Gold")
        Me.RankImages.Images.SetKeyName(3, "Diamond")
        Me.RankImages.Images.SetKeyName(4, "Master")
        '
        'btnRefreshRecruiting
        '
        Me.btnRefreshRecruiting.Location = New System.Drawing.Point(529, 6)
        Me.btnRefreshRecruiting.Name = "btnRefreshRecruiting"
        Me.btnRefreshRecruiting.Size = New System.Drawing.Size(74, 29)
        Me.btnRefreshRecruiting.TabIndex = 2
        Me.btnRefreshRecruiting.Text = "Refresh"
        Me.btnRefreshRecruiting.UseVisualStyleBackColor = True
        '
        'btnCreateTeam
        '
        Me.btnCreateTeam.Location = New System.Drawing.Point(609, 6)
        Me.btnCreateTeam.Name = "btnCreateTeam"
        Me.btnCreateTeam.Size = New System.Drawing.Size(125, 29)
        Me.btnCreateTeam.TabIndex = 2
        Me.btnCreateTeam.Text = "Create New Team"
        Me.btnCreateTeam.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Teams currently recruiting:"
        '
        'TabTeam
        '
        Me.TabTeam.BackColor = System.Drawing.Color.DimGray
        Me.TabTeam.Controls.Add(Me.btnLeaveTeam)
        Me.TabTeam.Controls.Add(Me.Label3)
        Me.TabTeam.Controls.Add(Me.listRecentMatches)
        Me.TabTeam.Controls.Add(Me.listAvail)
        Me.TabTeam.Controls.Add(Me.GroupBox2)
        Me.TabTeam.Controls.Add(Me.GroupBox1)
        Me.TabTeam.Controls.Add(Me.picTeamRank)
        Me.TabTeam.Controls.Add(Me.picTeamLogo)
        Me.TabTeam.Controls.Add(Me.lblTeamRanking)
        Me.TabTeam.Controls.Add(Me.lblTeamRegion)
        Me.TabTeam.Controls.Add(Me.Label2)
        Me.TabTeam.Controls.Add(Me.lblTeamName)
        Me.TabTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabTeam.Location = New System.Drawing.Point(4, 34)
        Me.TabTeam.Name = "TabTeam"
        Me.TabTeam.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTeam.Size = New System.Drawing.Size(743, 485)
        Me.TabTeam.TabIndex = 1
        Me.TabTeam.Text = "My Team"
        '
        'btnLeaveTeam
        '
        Me.btnLeaveTeam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLeaveTeam.Location = New System.Drawing.Point(652, 10)
        Me.btnLeaveTeam.Name = "btnLeaveTeam"
        Me.btnLeaveTeam.Size = New System.Drawing.Size(82, 25)
        Me.btnLeaveTeam.TabIndex = 9
        Me.btnLeaveTeam.Text = "Leave Team"
        Me.btnLeaveTeam.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Recent Match Results"
        '
        'listRecentMatches
        '
        Me.listRecentMatches.FormattingEnabled = True
        Me.listRecentMatches.Location = New System.Drawing.Point(215, 302)
        Me.listRecentMatches.Name = "listRecentMatches"
        Me.listRecentMatches.Size = New System.Drawing.Size(210, 147)
        Me.listRecentMatches.TabIndex = 7
        '
        'listAvail
        '
        Me.listAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listAvail.FormattingEnabled = True
        Me.listAvail.ItemHeight = 16
        Me.listAvail.Location = New System.Drawing.Point(19, 300)
        Me.listAvail.Name = "listAvail"
        Me.listAvail.Size = New System.Drawing.Size(155, 148)
        Me.listAvail.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKickSub2)
        Me.GroupBox2.Controls.Add(Me.btnKickSub1)
        Me.GroupBox2.Controls.Add(Me.lblSub2)
        Me.GroupBox2.Controls.Add(Me.lblSub1)
        Me.GroupBox2.Controls.Add(Me.picSub2)
        Me.GroupBox2.Controls.Add(Me.picSub1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(467, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 165)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rostered Substitutes"
        '
        'btnKickSub2
        '
        Me.btnKickSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickSub2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKickSub2.Location = New System.Drawing.Point(147, 135)
        Me.btnKickSub2.Name = "btnKickSub2"
        Me.btnKickSub2.Size = New System.Drawing.Size(50, 21)
        Me.btnKickSub2.TabIndex = 10
        Me.btnKickSub2.Text = "Kick"
        Me.btnKickSub2.UseVisualStyleBackColor = True
        Me.btnKickSub2.Visible = False
        '
        'btnKickSub1
        '
        Me.btnKickSub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickSub1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKickSub1.Location = New System.Drawing.Point(43, 136)
        Me.btnKickSub1.Name = "btnKickSub1"
        Me.btnKickSub1.Size = New System.Drawing.Size(50, 21)
        Me.btnKickSub1.TabIndex = 10
        Me.btnKickSub1.Text = "Kick"
        Me.btnKickSub1.UseVisualStyleBackColor = True
        Me.btnKickSub1.Visible = False
        '
        'lblSub2
        '
        Me.lblSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSub2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblSub2.LinkColor = System.Drawing.Color.MediumSpringGreen
        Me.lblSub2.Location = New System.Drawing.Point(124, 113)
        Me.lblSub2.Name = "lblSub2"
        Me.lblSub2.Size = New System.Drawing.Size(101, 23)
        Me.lblSub2.TabIndex = 10
        Me.lblSub2.TabStop = True
        Me.lblSub2.Text = "No Player"
        Me.lblSub2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblSub2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lblSub1
        '
        Me.lblSub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSub1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblSub1.LinkColor = System.Drawing.Color.MediumSpringGreen
        Me.lblSub1.Location = New System.Drawing.Point(17, 113)
        Me.lblSub1.Name = "lblSub1"
        Me.lblSub1.Size = New System.Drawing.Size(101, 23)
        Me.lblSub1.TabIndex = 10
        Me.lblSub1.TabStop = True
        Me.lblSub1.Text = "No Player"
        Me.lblSub1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblSub1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'picSub2
        '
        Me.picSub2.Location = New System.Drawing.Point(142, 47)
        Me.picSub2.Name = "picSub2"
        Me.picSub2.Size = New System.Drawing.Size(60, 60)
        Me.picSub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSub2.TabIndex = 6
        Me.picSub2.TabStop = False
        '
        'picSub1
        '
        Me.picSub1.Location = New System.Drawing.Point(39, 47)
        Me.picSub1.Name = "picSub1"
        Me.picSub1.Size = New System.Drawing.Size(60, 60)
        Me.picSub1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSub1.TabIndex = 6
        Me.picSub1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblteamAvail)
        Me.GroupBox1.Controls.Add(Me.btnKickPlayer4)
        Me.GroupBox1.Controls.Add(Me.btnKickPlayer3)
        Me.GroupBox1.Controls.Add(Me.btnKickPlayer2)
        Me.GroupBox1.Controls.Add(Me.lblPlayer4)
        Me.GroupBox1.Controls.Add(Me.lblPlayer3)
        Me.GroupBox1.Controls.Add(Me.lblPlayer2)
        Me.GroupBox1.Controls.Add(Me.lblPlayer1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.picPlayer4)
        Me.GroupBox1.Controls.Add(Me.picPlayer3)
        Me.GroupBox1.Controls.Add(Me.picPlayer2)
        Me.GroupBox1.Controls.Add(Me.picPlayer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(186, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 217)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Roster"
        '
        'lblteamAvail
        '
        Me.lblteamAvail.AutoSize = True
        Me.lblteamAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblteamAvail.Location = New System.Drawing.Point(327, 196)
        Me.lblteamAvail.Name = "lblteamAvail"
        Me.lblteamAvail.Size = New System.Drawing.Size(185, 18)
        Me.lblteamAvail.TabIndex = 10
        Me.lblteamAvail.Text = "Availability: 0:00 - 24:00"
        '
        'btnKickPlayer4
        '
        Me.btnKickPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickPlayer4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKickPlayer4.Location = New System.Drawing.Point(384, 146)
        Me.btnKickPlayer4.Name = "btnKickPlayer4"
        Me.btnKickPlayer4.Size = New System.Drawing.Size(50, 21)
        Me.btnKickPlayer4.TabIndex = 10
        Me.btnKickPlayer4.Text = "Kick"
        Me.btnKickPlayer4.UseVisualStyleBackColor = True
        Me.btnKickPlayer4.Visible = False
        '
        'btnKickPlayer3
        '
        Me.btnKickPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickPlayer3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKickPlayer3.Location = New System.Drawing.Point(284, 146)
        Me.btnKickPlayer3.Name = "btnKickPlayer3"
        Me.btnKickPlayer3.Size = New System.Drawing.Size(50, 21)
        Me.btnKickPlayer3.TabIndex = 10
        Me.btnKickPlayer3.Text = "Kick"
        Me.btnKickPlayer3.UseVisualStyleBackColor = True
        Me.btnKickPlayer3.Visible = False
        '
        'btnKickPlayer2
        '
        Me.btnKickPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKickPlayer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKickPlayer2.Location = New System.Drawing.Point(182, 147)
        Me.btnKickPlayer2.Name = "btnKickPlayer2"
        Me.btnKickPlayer2.Size = New System.Drawing.Size(50, 21)
        Me.btnKickPlayer2.TabIndex = 10
        Me.btnKickPlayer2.Text = "Kick"
        Me.btnKickPlayer2.UseVisualStyleBackColor = True
        Me.btnKickPlayer2.Visible = False
        '
        'lblPlayer4
        '
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPlayer4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblPlayer4.LinkColor = System.Drawing.Color.Cyan
        Me.lblPlayer4.Location = New System.Drawing.Point(361, 128)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(101, 23)
        Me.lblPlayer4.TabIndex = 9
        Me.lblPlayer4.TabStop = True
        Me.lblPlayer4.Text = "No Player"
        Me.lblPlayer4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPlayer4.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lblPlayer3
        '
        Me.lblPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPlayer3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblPlayer3.LinkColor = System.Drawing.Color.Cyan
        Me.lblPlayer3.Location = New System.Drawing.Point(259, 128)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(101, 23)
        Me.lblPlayer3.TabIndex = 9
        Me.lblPlayer3.TabStop = True
        Me.lblPlayer3.Text = "No Player"
        Me.lblPlayer3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPlayer3.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lblPlayer2
        '
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPlayer2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblPlayer2.LinkColor = System.Drawing.Color.Cyan
        Me.lblPlayer2.Location = New System.Drawing.Point(157, 128)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(101, 23)
        Me.lblPlayer2.TabIndex = 9
        Me.lblPlayer2.TabStop = True
        Me.lblPlayer2.Text = "No Player"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPlayer2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'lblPlayer1
        '
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPlayer1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblPlayer1.LinkColor = System.Drawing.Color.Cyan
        Me.lblPlayer1.Location = New System.Drawing.Point(50, 128)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(101, 23)
        Me.lblPlayer1.TabIndex = 9
        Me.lblPlayer1.TabStop = True
        Me.lblPlayer1.Text = "No Player"
        Me.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPlayer1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Team Captain"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPlayer4
        '
        Me.picPlayer4.Location = New System.Drawing.Point(379, 65)
        Me.picPlayer4.Name = "picPlayer4"
        Me.picPlayer4.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer4.TabIndex = 6
        Me.picPlayer4.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.Location = New System.Drawing.Point(279, 65)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer3.TabIndex = 6
        Me.picPlayer3.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Location = New System.Drawing.Point(177, 65)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 6
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Location = New System.Drawing.Point(73, 65)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 6
        Me.picPlayer1.TabStop = False
        '
        'picTeamRank
        '
        Me.picTeamRank.Location = New System.Drawing.Point(19, 205)
        Me.picTeamRank.Name = "picTeamRank"
        Me.picTeamRank.Size = New System.Drawing.Size(35, 35)
        Me.picTeamRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeamRank.TabIndex = 4
        Me.picTeamRank.TabStop = False
        '
        'picTeamLogo
        '
        Me.picTeamLogo.Location = New System.Drawing.Point(27, 28)
        Me.picTeamLogo.Name = "picTeamLogo"
        Me.picTeamLogo.Size = New System.Drawing.Size(125, 125)
        Me.picTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeamLogo.TabIndex = 3
        Me.picTeamLogo.TabStop = False
        '
        'lblTeamRanking
        '
        Me.lblTeamRanking.AutoSize = True
        Me.lblTeamRanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamRanking.Location = New System.Drawing.Point(62, 223)
        Me.lblTeamRanking.Name = "lblTeamRanking"
        Me.lblTeamRanking.Size = New System.Drawing.Size(96, 18)
        Me.lblTeamRanking.TabIndex = 0
        Me.lblTeamRanking.Text = "No Ranking"
        '
        'lblTeamRegion
        '
        Me.lblTeamRegion.AutoSize = True
        Me.lblTeamRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamRegion.Location = New System.Drawing.Point(62, 203)
        Me.lblTeamRegion.Name = "lblTeamRegion"
        Me.lblTeamRegion.Size = New System.Drawing.Size(88, 18)
        Me.lblTeamRegion.TabIndex = 0
        Me.lblTeamRegion.Text = "No Region"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Availability:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(44, 165)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(96, 24)
        Me.lblTeamName.TabIndex = 0
        Me.lblTeamName.Text = "No Team"
        '
        'TabMatches
        '
        Me.TabMatches.BackColor = System.Drawing.Color.DimGray
        Me.TabMatches.Controls.Add(Me.btnRefreshMatches)
        Me.TabMatches.Controls.Add(Me.DataGridMatches)
        Me.TabMatches.Location = New System.Drawing.Point(4, 34)
        Me.TabMatches.Name = "TabMatches"
        Me.TabMatches.Size = New System.Drawing.Size(743, 485)
        Me.TabMatches.TabIndex = 2
        Me.TabMatches.Text = "Matches"
        '
        'btnRefreshMatches
        '
        Me.btnRefreshMatches.Location = New System.Drawing.Point(659, 459)
        Me.btnRefreshMatches.Name = "btnRefreshMatches"
        Me.btnRefreshMatches.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshMatches.TabIndex = 3
        Me.btnRefreshMatches.Text = "Refresh"
        Me.btnRefreshMatches.UseVisualStyleBackColor = True
        '
        'DataGridMatches
        '
        Me.DataGridMatches.AllowUserToAddRows = False
        Me.DataGridMatches.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMatches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnTime, Me.Region, Me.Ranking, Me.ColumnOrange, Me.ColumnBlue, Me.Caster})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMatches.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridMatches.Location = New System.Drawing.Point(8, 15)
        Me.DataGridMatches.MultiSelect = False
        Me.DataGridMatches.Name = "DataGridMatches"
        Me.DataGridMatches.ReadOnly = True
        Me.DataGridMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridMatches.Size = New System.Drawing.Size(726, 438)
        Me.DataGridMatches.TabIndex = 0
        Me.DataGridMatches.TabStop = False
        '
        'ColumnTime
        '
        Me.ColumnTime.HeaderText = "Time"
        Me.ColumnTime.Name = "ColumnTime"
        Me.ColumnTime.ReadOnly = True
        Me.ColumnTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnTime.Width = 125
        '
        'Region
        '
        Me.Region.HeaderText = "Region"
        Me.Region.Name = "Region"
        Me.Region.ReadOnly = True
        Me.Region.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Region.Width = 50
        '
        'Ranking
        '
        Me.Ranking.HeaderText = "Ranking"
        Me.Ranking.Name = "Ranking"
        Me.Ranking.ReadOnly = True
        Me.Ranking.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ranking.Width = 50
        '
        'ColumnOrange
        '
        Me.ColumnOrange.HeaderText = "ORANGE"
        Me.ColumnOrange.Name = "ColumnOrange"
        Me.ColumnOrange.ReadOnly = True
        Me.ColumnOrange.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnOrange.Width = 175
        '
        'ColumnBlue
        '
        Me.ColumnBlue.HeaderText = "BLUE"
        Me.ColumnBlue.Name = "ColumnBlue"
        Me.ColumnBlue.ReadOnly = True
        Me.ColumnBlue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumnBlue.Width = 175
        '
        'Caster
        '
        Me.Caster.HeaderText = "Cast"
        Me.Caster.Name = "Caster"
        Me.Caster.ReadOnly = True
        Me.Caster.UseColumnTextForButtonValue = True
        '
        'TabLadder
        '
        Me.TabLadder.BackColor = System.Drawing.Color.DimGray
        Me.TabLadder.Controls.Add(Me.btnRefreshLadder)
        Me.TabLadder.Controls.Add(Me.btnCreateMatch)
        Me.TabLadder.Controls.Add(Me.DataGridLadder)
        Me.TabLadder.Location = New System.Drawing.Point(4, 34)
        Me.TabLadder.Name = "TabLadder"
        Me.TabLadder.Size = New System.Drawing.Size(743, 485)
        Me.TabLadder.TabIndex = 3
        Me.TabLadder.Text = "Ladder"
        '
        'btnRefreshLadder
        '
        Me.btnRefreshLadder.Location = New System.Drawing.Point(584, 6)
        Me.btnRefreshLadder.Name = "btnRefreshLadder"
        Me.btnRefreshLadder.Size = New System.Drawing.Size(145, 20)
        Me.btnRefreshLadder.TabIndex = 3
        Me.btnRefreshLadder.Text = "Refresh"
        Me.btnRefreshLadder.UseVisualStyleBackColor = True
        '
        'btnCreateMatch
        '
        Me.btnCreateMatch.Location = New System.Drawing.Point(631, 452)
        Me.btnCreateMatch.Name = "btnCreateMatch"
        Me.btnCreateMatch.Size = New System.Drawing.Size(98, 23)
        Me.btnCreateMatch.TabIndex = 3
        Me.btnCreateMatch.Text = "Request match"
        Me.btnCreateMatch.UseVisualStyleBackColor = True
        '
        'DataGridLadder
        '
        Me.DataGridLadder.AllowUserToAddRows = False
        Me.DataGridLadder.AllowUserToDeleteRows = False
        Me.DataGridLadder.AllowUserToResizeColumns = False
        Me.DataGridLadder.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridLadder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridLadder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLadder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMR, Me.Division, Me.TeamName})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridLadder.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridLadder.Location = New System.Drawing.Point(8, 4)
        Me.DataGridLadder.MultiSelect = False
        Me.DataGridLadder.Name = "DataGridLadder"
        Me.DataGridLadder.ReadOnly = True
        Me.DataGridLadder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridLadder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridLadder.ShowCellErrors = False
        Me.DataGridLadder.ShowCellToolTips = False
        Me.DataGridLadder.ShowEditingIcon = False
        Me.DataGridLadder.Size = New System.Drawing.Size(726, 442)
        Me.DataGridLadder.TabIndex = 4
        Me.DataGridLadder.TabStop = False
        '
        'MMR
        '
        Me.MMR.HeaderText = "MMR"
        Me.MMR.Name = "MMR"
        Me.MMR.ReadOnly = True
        '
        'Division
        '
        Me.Division.HeaderText = "Div"
        Me.Division.Name = "Division"
        Me.Division.ReadOnly = True
        '
        'TeamName
        '
        Me.TeamName.HeaderText = "Team Name"
        Me.TeamName.Name = "TeamName"
        Me.TeamName.ReadOnly = True
        Me.TeamName.Width = 350
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.topPanel.Controls.Add(Me.Label15)
        Me.topPanel.Controls.Add(Me.btnClose)
        Me.topPanel.Controls.Add(Me.btnMinimize)
        Me.topPanel.Location = New System.Drawing.Point(-1, -1)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(752, 24)
        Me.topPanel.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "VR MASTER LEAGUE "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(722, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(696, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 24)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 544)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.tabMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "VRML Scheduler"
        Me.groupMyInfo.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.TabProfile.ResumeLayout(False)
        Me.TabProfile.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabFindTeam.ResumeLayout(False)
        Me.TabFindTeam.PerformLayout()
        Me.TabTeam.ResumeLayout(False)
        Me.TabTeam.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picSub2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSub1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeamRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeamLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMatches.ResumeLayout(False)
        CType(Me.DataGridMatches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLadder.ResumeLayout(False)
        CType(Me.DataGridLadder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUsername As Label
    Friend WithEvents groupMyInfo As GroupBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabProfile As TabPage
    Friend WithEvents TabTeam As TabPage
    Friend WithEvents TabMatches As TabPage
    Friend WithEvents TabLadder As TabPage
    Friend WithEvents picTeamLogo As PictureBox
    Friend WithEvents lblTeamRanking As Label
    Friend WithEvents lblTeamRegion As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents picTeamRank As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents listRecentMatches As ListBox
    Friend WithEvents listAvail As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picSub2 As PictureBox
    Friend WithEvents picSub1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picPlayer4 As PictureBox
    Friend WithEvents picPlayer3 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabFindTeam As TabPage
    Friend WithEvents btnCreateTeam As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPlayer1 As LinkLabel
    Friend WithEvents lblSub2 As LinkLabel
    Friend WithEvents lblSub1 As LinkLabel
    Friend WithEvents lblPlayer4 As LinkLabel
    Friend WithEvents lblPlayer3 As LinkLabel
    Friend WithEvents lblPlayer2 As LinkLabel
    Friend WithEvents btnLeaveTeam As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRefreshRecruiting As Button
    Friend WithEvents listRecruitingTeams As ListView
    Friend WithEvents RankImages As ImageList
    Friend WithEvents lblProfileTeamName As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSaveAvailability As Button
    Friend WithEvents DataGridMatches As DataGridView
    Friend WithEvents btnRefreshMatches As Button
    Friend WithEvents btnCreateMatch As Button
    Friend WithEvents btnRefreshLadder As Button
    Friend WithEvents DataGridLadder As DataGridView
    Friend WithEvents MMR As DataGridViewTextBoxColumn
    Friend WithEvents Division As DataGridViewTextBoxColumn
    Friend WithEvents TeamName As DataGridViewTextBoxColumn
    Friend WithEvents btnNotifications As Button
    Friend WithEvents topPanel As Panel
    Friend WithEvents listPersonalParticipation As ListBox
    Friend WithEvents sliderSun As DoubleTrackBar
    Friend WithEvents sliderSat As DoubleTrackBar
    Friend WithEvents sliderFri As DoubleTrackBar
    Friend WithEvents sliderThur As DoubleTrackBar
    Friend WithEvents sliderWed As DoubleTrackBar
    Friend WithEvents sliderTue As DoubleTrackBar
    Friend WithEvents sliderMon As DoubleTrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents AvailabilityToolTip As ToolTip
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents availText As Label
    Friend WithEvents btnChangeProfilePic As Button
    Friend WithEvents ColumnTime As DataGridViewTextBoxColumn
    Friend WithEvents Region As DataGridViewTextBoxColumn
    Friend WithEvents Ranking As DataGridViewTextBoxColumn
    Friend WithEvents ColumnOrange As DataGridViewTextBoxColumn
    Friend WithEvents ColumnBlue As DataGridViewTextBoxColumn
    Friend WithEvents Caster As DataGridViewButtonColumn
    Friend WithEvents btnKickSub2 As Button
    Friend WithEvents btnKickSub1 As Button
    Friend WithEvents btnKickPlayer4 As Button
    Friend WithEvents btnKickPlayer3 As Button
    Friend WithEvents btnKickPlayer2 As Button
    Friend WithEvents lblteamAvail As Label
    Friend WithEvents btnAdminPanel As Button
End Class
