<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playerProfile
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
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.listPersonalParticipation = New System.Windows.Forms.ListBox()
        Me.groupMyInfo = New System.Windows.Forms.GroupBox()
        Me.lblProfileTeamName = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.topPanel.SuspendLayout()
        Me.groupMyInfo.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.topPanel.Controls.Add(Me.btnClose)
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(752, 24)
        Me.topPanel.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(360, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'listPersonalParticipation
        '
        Me.listPersonalParticipation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listPersonalParticipation.FormattingEnabled = True
        Me.listPersonalParticipation.ItemHeight = 16
        Me.listPersonalParticipation.Location = New System.Drawing.Point(206, 64)
        Me.listPersonalParticipation.Name = "listPersonalParticipation"
        Me.listPersonalParticipation.Size = New System.Drawing.Size(170, 180)
        Me.listPersonalParticipation.TabIndex = 9
        '
        'groupMyInfo
        '
        Me.groupMyInfo.Controls.Add(Me.lblProfileTeamName)
        Me.groupMyInfo.Controls.Add(Me.picProfile)
        Me.groupMyInfo.Controls.Add(Me.lblUsername)
        Me.groupMyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupMyInfo.Location = New System.Drawing.Point(12, 30)
        Me.groupMyInfo.Name = "groupMyInfo"
        Me.groupMyInfo.Size = New System.Drawing.Size(171, 217)
        Me.groupMyInfo.TabIndex = 8
        Me.groupMyInfo.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Medals:"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Lime
        Me.btnAccept.ForeColor = System.Drawing.Color.Black
        Me.btnAccept.Location = New System.Drawing.Point(268, 250)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(56, 23)
        Me.btnAccept.TabIndex = 11
        Me.btnAccept.TabStop = False
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDecline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDecline.Location = New System.Drawing.Point(330, 250)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(56, 23)
        Me.btnDecline.TabIndex = 11
        Me.btnDecline.TabStop = False
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'playerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(390, 280)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listPersonalParticipation)
        Me.Controls.Add(Me.groupMyInfo)
        Me.Controls.Add(Me.topPanel)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "playerProfile"
        Me.Text = "playerProfile"
        Me.topPanel.ResumeLayout(False)
        Me.groupMyInfo.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents topPanel As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents listPersonalParticipation As ListBox
    Friend WithEvents groupMyInfo As GroupBox
    Friend WithEvents lblProfileTeamName As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDecline As Button
End Class
