<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teamProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.lblTopText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listRecentMatches = New System.Windows.Forms.ListBox()
        Me.listParticipation = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSub2 = New System.Windows.Forms.LinkLabel()
        Me.lblSub1 = New System.Windows.Forms.LinkLabel()
        Me.picSub2 = New System.Windows.Forms.PictureBox()
        Me.picSub1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRecruit = New System.Windows.Forms.Label()
        Me.topPanel.SuspendLayout()
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
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(594, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.topPanel.Controls.Add(Me.lblTopText)
        Me.topPanel.Controls.Add(Me.btnClose)
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(752, 24)
        Me.topPanel.TabIndex = 6
        '
        'lblTopText
        '
        Me.lblTopText.AutoSize = True
        Me.lblTopText.BackColor = System.Drawing.Color.Transparent
        Me.lblTopText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTopText.Location = New System.Drawing.Point(3, 3)
        Me.lblTopText.Name = "lblTopText"
        Me.lblTopText.Size = New System.Drawing.Size(179, 18)
        Me.lblTopText.TabIndex = 7
        Me.lblTopText.Text = "VR MASTER LEAGUE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Recent Match Results"
        '
        'listRecentMatches
        '
        Me.listRecentMatches.FormattingEnabled = True
        Me.listRecentMatches.Location = New System.Drawing.Point(183, 222)
        Me.listRecentMatches.Name = "listRecentMatches"
        Me.listRecentMatches.Size = New System.Drawing.Size(168, 108)
        Me.listRecentMatches.TabIndex = 19
        '
        'listParticipation
        '
        Me.listParticipation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listParticipation.FormattingEnabled = True
        Me.listParticipation.ItemHeight = 16
        Me.listParticipation.Location = New System.Drawing.Point(16, 290)
        Me.listParticipation.Name = "listParticipation"
        Me.listParticipation.Size = New System.Drawing.Size(155, 84)
        Me.listParticipation.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSub2)
        Me.GroupBox2.Controls.Add(Me.lblSub1)
        Me.GroupBox2.Controls.Add(Me.picSub2)
        Me.GroupBox2.Controls.Add(Me.picSub1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(367, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 126)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rostered Substitutes"
        '
        'lblSub2
        '
        Me.lblSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSub2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblSub2.LinkColor = System.Drawing.Color.MediumSpringGreen
        Me.lblSub2.Location = New System.Drawing.Point(119, 90)
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
        Me.lblSub1.Location = New System.Drawing.Point(17, 89)
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
        Me.picSub2.Location = New System.Drawing.Point(142, 23)
        Me.picSub2.Name = "picSub2"
        Me.picSub2.Size = New System.Drawing.Size(60, 60)
        Me.picSub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSub2.TabIndex = 6
        Me.picSub2.TabStop = False
        '
        'picSub1
        '
        Me.picSub1.Location = New System.Drawing.Point(39, 23)
        Me.picSub1.Name = "picSub1"
        Me.picSub1.Size = New System.Drawing.Size(60, 60)
        Me.picSub1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSub1.TabIndex = 6
        Me.picSub1.TabStop = False
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(183, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 131)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Roster"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPlayer4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblPlayer4.LinkColor = System.Drawing.Color.Cyan
        Me.lblPlayer4.Location = New System.Drawing.Point(317, 91)
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
        Me.lblPlayer3.Location = New System.Drawing.Point(215, 91)
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
        Me.lblPlayer2.Location = New System.Drawing.Point(113, 91)
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
        Me.lblPlayer1.Location = New System.Drawing.Point(6, 91)
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
        Me.Label1.Location = New System.Drawing.Point(10, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Team Captain"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPlayer4
        '
        Me.picPlayer4.Location = New System.Drawing.Point(335, 28)
        Me.picPlayer4.Name = "picPlayer4"
        Me.picPlayer4.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer4.TabIndex = 6
        Me.picPlayer4.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.Location = New System.Drawing.Point(235, 28)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer3.TabIndex = 6
        Me.picPlayer3.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Location = New System.Drawing.Point(133, 28)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 6
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Location = New System.Drawing.Point(29, 28)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(60, 60)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 6
        Me.picPlayer1.TabStop = False
        '
        'picTeamRank
        '
        Me.picTeamRank.Location = New System.Drawing.Point(16, 224)
        Me.picTeamRank.Name = "picTeamRank"
        Me.picTeamRank.Size = New System.Drawing.Size(35, 35)
        Me.picTeamRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeamRank.TabIndex = 15
        Me.picTeamRank.TabStop = False
        '
        'picTeamLogo
        '
        Me.picTeamLogo.Location = New System.Drawing.Point(24, 47)
        Me.picTeamLogo.Name = "picTeamLogo"
        Me.picTeamLogo.Size = New System.Drawing.Size(125, 125)
        Me.picTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeamLogo.TabIndex = 14
        Me.picTeamLogo.TabStop = False
        '
        'lblTeamRanking
        '
        Me.lblTeamRanking.AutoSize = True
        Me.lblTeamRanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamRanking.Location = New System.Drawing.Point(59, 242)
        Me.lblTeamRanking.Name = "lblTeamRanking"
        Me.lblTeamRanking.Size = New System.Drawing.Size(96, 18)
        Me.lblTeamRanking.TabIndex = 10
        Me.lblTeamRanking.Text = "No Ranking"
        '
        'lblTeamRegion
        '
        Me.lblTeamRegion.AutoSize = True
        Me.lblTeamRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamRegion.Location = New System.Drawing.Point(59, 222)
        Me.lblTeamRegion.Name = "lblTeamRegion"
        Me.lblTeamRegion.Size = New System.Drawing.Size(88, 18)
        Me.lblTeamRegion.TabIndex = 11
        Me.lblTeamRegion.Text = "No Region"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Medals:"
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(41, 184)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(96, 24)
        Me.lblTeamName.TabIndex = 13
        Me.lblTeamName.Text = "No Team"
        '
        'btnJoin
        '
        Me.btnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnJoin.Location = New System.Drawing.Point(302, 12)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(112, 23)
        Me.btnJoin.TabIndex = 21
        Me.btnJoin.Text = "Request to join"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnJoin)
        Me.GroupBox3.Controls.Add(Me.lblRecruit)
        Me.GroupBox3.Location = New System.Drawing.Point(183, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 43)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'lblRecruit
        '
        Me.lblRecruit.AutoSize = True
        Me.lblRecruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecruit.ForeColor = System.Drawing.Color.Lime
        Me.lblRecruit.Location = New System.Drawing.Point(10, 15)
        Me.lblRecruit.Name = "lblRecruit"
        Me.lblRecruit.Size = New System.Drawing.Size(227, 16)
        Me.lblRecruit.TabIndex = 20
        Me.lblRecruit.Text = "This team is currently recruiting!"
        '
        'teamProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(622, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listRecentMatches)
        Me.Controls.Add(Me.listParticipation)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picTeamRank)
        Me.Controls.Add(Me.picTeamLogo)
        Me.Controls.Add(Me.lblTeamRanking)
        Me.Controls.Add(Me.lblTeamRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.topPanel)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "teamProfile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "teamProfile"
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picSub2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSub1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeamRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeamLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents topPanel As Panel
    Friend WithEvents lblTopText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listRecentMatches As ListBox
    Friend WithEvents listParticipation As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSub2 As LinkLabel
    Friend WithEvents lblSub1 As LinkLabel
    Friend WithEvents picSub2 As PictureBox
    Friend WithEvents picSub1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlayer4 As LinkLabel
    Friend WithEvents lblPlayer3 As LinkLabel
    Friend WithEvents lblPlayer2 As LinkLabel
    Friend WithEvents lblPlayer1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents picPlayer4 As PictureBox
    Friend WithEvents picPlayer3 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents picTeamRank As PictureBox
    Friend WithEvents picTeamLogo As PictureBox
    Friend WithEvents lblTeamRanking As Label
    Friend WithEvents lblTeamRegion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTeamName As Label
    Friend WithEvents btnJoin As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblRecruit As Label
End Class
