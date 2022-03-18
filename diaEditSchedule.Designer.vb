<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaEditSchedule
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.GroupBoxSat = New System.Windows.Forms.GroupBox()
        Me.lblSatEnd = New System.Windows.Forms.Label()
        Me.lblSatStart = New System.Windows.Forms.Label()
        Me.sliderSat = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxFri = New System.Windows.Forms.GroupBox()
        Me.lblFriEnd = New System.Windows.Forms.Label()
        Me.lblFriStart = New System.Windows.Forms.Label()
        Me.sliderFri = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxThu = New System.Windows.Forms.GroupBox()
        Me.lblThurEnd = New System.Windows.Forms.Label()
        Me.lblThurStart = New System.Windows.Forms.Label()
        Me.sliderThur = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxWed = New System.Windows.Forms.GroupBox()
        Me.lblWedEnd = New System.Windows.Forms.Label()
        Me.lblWedStart = New System.Windows.Forms.Label()
        Me.sliderWed = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxTue = New System.Windows.Forms.GroupBox()
        Me.lblTueEnd = New System.Windows.Forms.Label()
        Me.lblTueStart = New System.Windows.Forms.Label()
        Me.sliderTue = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxMon = New System.Windows.Forms.GroupBox()
        Me.lblMonEnd = New System.Windows.Forms.Label()
        Me.lblMonStart = New System.Windows.Forms.Label()
        Me.sliderMon = New VRMLScheduler.DoubleTrackBar()
        Me.GroupBoxSun = New System.Windows.Forms.GroupBox()
        Me.lblSunEnd = New System.Windows.Forms.Label()
        Me.lblSunStart = New System.Windows.Forms.Label()
        Me.sliderSun = New VRMLScheduler.DoubleTrackBar()
        Me.chkAvailChangeAll = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSat.SuspendLayout()
        Me.GroupBoxFri.SuspendLayout()
        Me.GroupBoxThu.SuspendLayout()
        Me.GroupBoxWed.SuspendLayout()
        Me.GroupBoxTue.SuspendLayout()
        Me.GroupBoxMon.SuspendLayout()
        Me.GroupBoxSun.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(382, 474)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
        '
        'GroupBoxSat
        '
        Me.GroupBoxSat.Controls.Add(Me.lblSatEnd)
        Me.GroupBoxSat.Controls.Add(Me.lblSatStart)
        Me.GroupBoxSat.Controls.Add(Me.sliderSat)
        Me.GroupBoxSat.Location = New System.Drawing.Point(12, 340)
        Me.GroupBoxSat.Name = "GroupBoxSat"
        Me.GroupBoxSat.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxSat.TabIndex = 7
        Me.GroupBoxSat.TabStop = False
        Me.GroupBoxSat.Text = "Saturday"
        '
        'lblSatEnd
        '
        Me.lblSatEnd.AutoSize = True
        Me.lblSatEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblSatEnd.Name = "lblSatEnd"
        Me.lblSatEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblSatEnd.TabIndex = 4
        Me.lblSatEnd.Text = "11 PM"
        '
        'lblSatStart
        '
        Me.lblSatStart.AutoSize = True
        Me.lblSatStart.Location = New System.Drawing.Point(8, 21)
        Me.lblSatStart.Name = "lblSatStart"
        Me.lblSatStart.Size = New System.Drawing.Size(32, 13)
        Me.lblSatStart.TabIndex = 3
        Me.lblSatStart.Text = "1 PM"
        '
        'sliderSat
        '
        Me.sliderSat.BackColor = System.Drawing.SystemColors.Control
        Me.sliderSat.Location = New System.Drawing.Point(6, 32)
        Me.sliderSat.Maximum = 12
        Me.sliderSat.Minimum = 0
        Me.sliderSat.Name = "sliderSat"
        Me.sliderSat.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderSat.Size = New System.Drawing.Size(426, 22)
        Me.sliderSat.SmallChange = 1
        Me.sliderSat.TabIndex = 5
        Me.sliderSat.ValueLeft = 1
        Me.sliderSat.ValueRight = 11
        '
        'GroupBoxFri
        '
        Me.GroupBoxFri.Controls.Add(Me.lblFriEnd)
        Me.GroupBoxFri.Controls.Add(Me.lblFriStart)
        Me.GroupBoxFri.Controls.Add(Me.sliderFri)
        Me.GroupBoxFri.Location = New System.Drawing.Point(12, 272)
        Me.GroupBoxFri.Name = "GroupBoxFri"
        Me.GroupBoxFri.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxFri.TabIndex = 6
        Me.GroupBoxFri.TabStop = False
        Me.GroupBoxFri.Text = "Friday"
        '
        'lblFriEnd
        '
        Me.lblFriEnd.AutoSize = True
        Me.lblFriEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblFriEnd.Name = "lblFriEnd"
        Me.lblFriEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblFriEnd.TabIndex = 4
        Me.lblFriEnd.Text = "11 PM"
        '
        'lblFriStart
        '
        Me.lblFriStart.AutoSize = True
        Me.lblFriStart.Location = New System.Drawing.Point(8, 21)
        Me.lblFriStart.Name = "lblFriStart"
        Me.lblFriStart.Size = New System.Drawing.Size(32, 13)
        Me.lblFriStart.TabIndex = 3
        Me.lblFriStart.Text = "1 PM"
        '
        'sliderFri
        '
        Me.sliderFri.BackColor = System.Drawing.SystemColors.Control
        Me.sliderFri.Location = New System.Drawing.Point(6, 32)
        Me.sliderFri.Maximum = 12
        Me.sliderFri.Minimum = 0
        Me.sliderFri.Name = "sliderFri"
        Me.sliderFri.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderFri.Size = New System.Drawing.Size(426, 22)
        Me.sliderFri.SmallChange = 1
        Me.sliderFri.TabIndex = 5
        Me.sliderFri.ValueLeft = 1
        Me.sliderFri.ValueRight = 11
        '
        'GroupBoxThu
        '
        Me.GroupBoxThu.Controls.Add(Me.lblThurEnd)
        Me.GroupBoxThu.Controls.Add(Me.lblThurStart)
        Me.GroupBoxThu.Controls.Add(Me.sliderThur)
        Me.GroupBoxThu.Location = New System.Drawing.Point(12, 207)
        Me.GroupBoxThu.Name = "GroupBoxThu"
        Me.GroupBoxThu.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxThu.TabIndex = 6
        Me.GroupBoxThu.TabStop = False
        Me.GroupBoxThu.Text = "Thursday"
        '
        'lblThurEnd
        '
        Me.lblThurEnd.AutoSize = True
        Me.lblThurEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblThurEnd.Name = "lblThurEnd"
        Me.lblThurEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblThurEnd.TabIndex = 4
        Me.lblThurEnd.Text = "11 PM"
        '
        'lblThurStart
        '
        Me.lblThurStart.AutoSize = True
        Me.lblThurStart.Location = New System.Drawing.Point(8, 21)
        Me.lblThurStart.Name = "lblThurStart"
        Me.lblThurStart.Size = New System.Drawing.Size(32, 13)
        Me.lblThurStart.TabIndex = 3
        Me.lblThurStart.Text = "1 PM"
        '
        'sliderThur
        '
        Me.sliderThur.BackColor = System.Drawing.SystemColors.Control
        Me.sliderThur.Location = New System.Drawing.Point(6, 32)
        Me.sliderThur.Maximum = 12
        Me.sliderThur.Minimum = 0
        Me.sliderThur.Name = "sliderThur"
        Me.sliderThur.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderThur.Size = New System.Drawing.Size(426, 22)
        Me.sliderThur.SmallChange = 1
        Me.sliderThur.TabIndex = 5
        Me.sliderThur.ValueLeft = 1
        Me.sliderThur.ValueRight = 11
        '
        'GroupBoxWed
        '
        Me.GroupBoxWed.Controls.Add(Me.lblWedEnd)
        Me.GroupBoxWed.Controls.Add(Me.lblWedStart)
        Me.GroupBoxWed.Controls.Add(Me.sliderWed)
        Me.GroupBoxWed.Location = New System.Drawing.Point(12, 142)
        Me.GroupBoxWed.Name = "GroupBoxWed"
        Me.GroupBoxWed.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxWed.TabIndex = 6
        Me.GroupBoxWed.TabStop = False
        Me.GroupBoxWed.Text = "Wednesday"
        '
        'lblWedEnd
        '
        Me.lblWedEnd.AutoSize = True
        Me.lblWedEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblWedEnd.Name = "lblWedEnd"
        Me.lblWedEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblWedEnd.TabIndex = 4
        Me.lblWedEnd.Text = "11 PM"
        '
        'lblWedStart
        '
        Me.lblWedStart.AutoSize = True
        Me.lblWedStart.Location = New System.Drawing.Point(8, 21)
        Me.lblWedStart.Name = "lblWedStart"
        Me.lblWedStart.Size = New System.Drawing.Size(32, 13)
        Me.lblWedStart.TabIndex = 3
        Me.lblWedStart.Text = "1 PM"
        '
        'sliderWed
        '
        Me.sliderWed.BackColor = System.Drawing.SystemColors.Control
        Me.sliderWed.Location = New System.Drawing.Point(6, 32)
        Me.sliderWed.Maximum = 12
        Me.sliderWed.Minimum = 0
        Me.sliderWed.Name = "sliderWed"
        Me.sliderWed.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderWed.Size = New System.Drawing.Size(426, 22)
        Me.sliderWed.SmallChange = 1
        Me.sliderWed.TabIndex = 5
        Me.sliderWed.ValueLeft = 1
        Me.sliderWed.ValueRight = 11
        '
        'GroupBoxTue
        '
        Me.GroupBoxTue.Controls.Add(Me.lblTueEnd)
        Me.GroupBoxTue.Controls.Add(Me.lblTueStart)
        Me.GroupBoxTue.Controls.Add(Me.sliderTue)
        Me.GroupBoxTue.Location = New System.Drawing.Point(12, 77)
        Me.GroupBoxTue.Name = "GroupBoxTue"
        Me.GroupBoxTue.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxTue.TabIndex = 6
        Me.GroupBoxTue.TabStop = False
        Me.GroupBoxTue.Text = "Tuesday"
        '
        'lblTueEnd
        '
        Me.lblTueEnd.AutoSize = True
        Me.lblTueEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblTueEnd.Name = "lblTueEnd"
        Me.lblTueEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblTueEnd.TabIndex = 4
        Me.lblTueEnd.Text = "11 PM"
        '
        'lblTueStart
        '
        Me.lblTueStart.AutoSize = True
        Me.lblTueStart.Location = New System.Drawing.Point(8, 21)
        Me.lblTueStart.Name = "lblTueStart"
        Me.lblTueStart.Size = New System.Drawing.Size(32, 13)
        Me.lblTueStart.TabIndex = 3
        Me.lblTueStart.Text = "1 PM"
        '
        'sliderTue
        '
        Me.sliderTue.BackColor = System.Drawing.SystemColors.Control
        Me.sliderTue.Location = New System.Drawing.Point(6, 32)
        Me.sliderTue.Maximum = 12
        Me.sliderTue.Minimum = 0
        Me.sliderTue.Name = "sliderTue"
        Me.sliderTue.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderTue.Size = New System.Drawing.Size(426, 22)
        Me.sliderTue.SmallChange = 1
        Me.sliderTue.TabIndex = 5
        Me.sliderTue.ValueLeft = 1
        Me.sliderTue.ValueRight = 11
        '
        'GroupBoxMon
        '
        Me.GroupBoxMon.Controls.Add(Me.lblMonEnd)
        Me.GroupBoxMon.Controls.Add(Me.lblMonStart)
        Me.GroupBoxMon.Controls.Add(Me.sliderMon)
        Me.GroupBoxMon.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxMon.Name = "GroupBoxMon"
        Me.GroupBoxMon.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxMon.TabIndex = 6
        Me.GroupBoxMon.TabStop = False
        Me.GroupBoxMon.Text = "Monday"
        '
        'lblMonEnd
        '
        Me.lblMonEnd.AutoSize = True
        Me.lblMonEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblMonEnd.Name = "lblMonEnd"
        Me.lblMonEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblMonEnd.TabIndex = 4
        Me.lblMonEnd.Text = "11 PM"
        '
        'lblMonStart
        '
        Me.lblMonStart.AutoSize = True
        Me.lblMonStart.Location = New System.Drawing.Point(8, 21)
        Me.lblMonStart.Name = "lblMonStart"
        Me.lblMonStart.Size = New System.Drawing.Size(32, 13)
        Me.lblMonStart.TabIndex = 3
        Me.lblMonStart.Text = "1 PM"
        '
        'sliderMon
        '
        Me.sliderMon.BackColor = System.Drawing.SystemColors.Control
        Me.sliderMon.Location = New System.Drawing.Point(6, 32)
        Me.sliderMon.Maximum = 12
        Me.sliderMon.Minimum = 0
        Me.sliderMon.Name = "sliderMon"
        Me.sliderMon.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderMon.Size = New System.Drawing.Size(426, 22)
        Me.sliderMon.SmallChange = 1
        Me.sliderMon.TabIndex = 5
        Me.sliderMon.ValueLeft = 1
        Me.sliderMon.ValueRight = 11
        '
        'GroupBoxSun
        '
        Me.GroupBoxSun.Controls.Add(Me.lblSunEnd)
        Me.GroupBoxSun.Controls.Add(Me.lblSunStart)
        Me.GroupBoxSun.Controls.Add(Me.sliderSun)
        Me.GroupBoxSun.Location = New System.Drawing.Point(12, 405)
        Me.GroupBoxSun.Name = "GroupBoxSun"
        Me.GroupBoxSun.Size = New System.Drawing.Size(438, 59)
        Me.GroupBoxSun.TabIndex = 7
        Me.GroupBoxSun.TabStop = False
        Me.GroupBoxSun.Text = "Sunday"
        '
        'lblSunEnd
        '
        Me.lblSunEnd.AutoSize = True
        Me.lblSunEnd.Location = New System.Drawing.Point(390, 22)
        Me.lblSunEnd.Name = "lblSunEnd"
        Me.lblSunEnd.Size = New System.Drawing.Size(38, 13)
        Me.lblSunEnd.TabIndex = 4
        Me.lblSunEnd.Text = "11 PM"
        '
        'lblSunStart
        '
        Me.lblSunStart.AutoSize = True
        Me.lblSunStart.Location = New System.Drawing.Point(8, 21)
        Me.lblSunStart.Name = "lblSunStart"
        Me.lblSunStart.Size = New System.Drawing.Size(32, 13)
        Me.lblSunStart.TabIndex = 3
        Me.lblSunStart.Text = "1 PM"
        '
        'sliderSun
        '
        Me.sliderSun.BackColor = System.Drawing.SystemColors.Control
        Me.sliderSun.Location = New System.Drawing.Point(6, 32)
        Me.sliderSun.Maximum = 12
        Me.sliderSun.Minimum = 0
        Me.sliderSun.Name = "sliderSun"
        Me.sliderSun.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.sliderSun.Size = New System.Drawing.Size(426, 22)
        Me.sliderSun.SmallChange = 1
        Me.sliderSun.TabIndex = 5
        Me.sliderSun.ValueLeft = 1
        Me.sliderSun.ValueRight = 11
        '
        'chkAvailChangeAll
        '
        Me.chkAvailChangeAll.AutoSize = True
        Me.chkAvailChangeAll.Location = New System.Drawing.Point(18, 478)
        Me.chkAvailChangeAll.Name = "chkAvailChangeAll"
        Me.chkAvailChangeAll.Size = New System.Drawing.Size(77, 17)
        Me.chkAvailChangeAll.TabIndex = 8
        Me.chkAvailChangeAll.Text = "Change All"
        Me.chkAvailChangeAll.UseVisualStyleBackColor = True
        '
        'diaEditSchedule
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 507)
        Me.Controls.Add(Me.chkAvailChangeAll)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.GroupBoxSun)
        Me.Controls.Add(Me.GroupBoxSat)
        Me.Controls.Add(Me.GroupBoxFri)
        Me.Controls.Add(Me.GroupBoxThu)
        Me.Controls.Add(Me.GroupBoxMon)
        Me.Controls.Add(Me.GroupBoxWed)
        Me.Controls.Add(Me.GroupBoxTue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diaEditSchedule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "diaEditSchedule"
        Me.GroupBoxSat.ResumeLayout(False)
        Me.GroupBoxSat.PerformLayout()
        Me.GroupBoxFri.ResumeLayout(False)
        Me.GroupBoxFri.PerformLayout()
        Me.GroupBoxThu.ResumeLayout(False)
        Me.GroupBoxThu.PerformLayout()
        Me.GroupBoxWed.ResumeLayout(False)
        Me.GroupBoxWed.PerformLayout()
        Me.GroupBoxTue.ResumeLayout(False)
        Me.GroupBoxTue.PerformLayout()
        Me.GroupBoxMon.ResumeLayout(False)
        Me.GroupBoxMon.PerformLayout()
        Me.GroupBoxSun.ResumeLayout(False)
        Me.GroupBoxSun.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSat As GroupBox
    Friend WithEvents lblSatEnd As Label
    Friend WithEvents lblSatStart As Label
    Friend WithEvents sliderSat As DoubleTrackBar
    Friend WithEvents GroupBoxFri As GroupBox
    Friend WithEvents lblFriEnd As Label
    Friend WithEvents lblFriStart As Label
    Friend WithEvents sliderFri As DoubleTrackBar
    Friend WithEvents GroupBoxThu As GroupBox
    Friend WithEvents lblThurEnd As Label
    Friend WithEvents lblThurStart As Label
    Friend WithEvents sliderThur As DoubleTrackBar
    Friend WithEvents GroupBoxWed As GroupBox
    Friend WithEvents lblWedEnd As Label
    Friend WithEvents lblWedStart As Label
    Friend WithEvents sliderWed As DoubleTrackBar
    Friend WithEvents GroupBoxTue As GroupBox
    Friend WithEvents lblTueEnd As Label
    Friend WithEvents lblTueStart As Label
    Friend WithEvents sliderTue As DoubleTrackBar
    Friend WithEvents GroupBoxMon As GroupBox
    Friend WithEvents lblMonEnd As Label
    Friend WithEvents lblMonStart As Label
    Friend WithEvents sliderMon As DoubleTrackBar
    Friend WithEvents GroupBoxSun As GroupBox
    Friend WithEvents lblSunEnd As Label
    Friend WithEvents lblSunStart As Label
    Friend WithEvents sliderSun As DoubleTrackBar
    Friend WithEvents chkAvailChangeAll As CheckBox
End Class
