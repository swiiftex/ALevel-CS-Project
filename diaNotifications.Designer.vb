<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diaNotifications
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
        Me.datagridNotifications = New System.Windows.Forms.DataGridView()
        Me.columnTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnButtons = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.datagridNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.topPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagridNotifications
        '
        Me.datagridNotifications.AllowUserToAddRows = False
        Me.datagridNotifications.AllowUserToDeleteRows = False
        Me.datagridNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridNotifications.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnTime, Me.columnSender, Me.columnType, Me.columnButtons})
        Me.datagridNotifications.Location = New System.Drawing.Point(0, 23)
        Me.datagridNotifications.Name = "datagridNotifications"
        Me.datagridNotifications.ReadOnly = True
        Me.datagridNotifications.Size = New System.Drawing.Size(697, 430)
        Me.datagridNotifications.TabIndex = 1
        '
        'columnTime
        '
        Me.columnTime.HeaderText = "Time"
        Me.columnTime.Name = "columnTime"
        Me.columnTime.ReadOnly = True
        '
        'columnSender
        '
        Me.columnSender.HeaderText = "From"
        Me.columnSender.Name = "columnSender"
        Me.columnSender.ReadOnly = True
        '
        'columnType
        '
        Me.columnType.HeaderText = ""
        Me.columnType.Name = "columnType"
        Me.columnType.ReadOnly = True
        Me.columnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnType.Width = 350
        '
        'columnButtons
        '
        Me.columnButtons.HeaderText = ""
        Me.columnButtons.Name = "columnButtons"
        Me.columnButtons.ReadOnly = True
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.topPanel.Controls.Add(Me.Label15)
        Me.topPanel.Controls.Add(Me.btnClose)
        Me.topPanel.Location = New System.Drawing.Point(0, -1)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(719, 24)
        Me.topPanel.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Notifications"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(671, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 24)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'diaNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 452)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.datagridNotifications)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diaNotifications"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notifications"
        CType(Me.datagridNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagridNotifications As DataGridView
    Friend WithEvents columnTime As DataGridViewTextBoxColumn
    Friend WithEvents columnSender As DataGridViewTextBoxColumn
    Friend WithEvents columnType As DataGridViewTextBoxColumn
    Friend WithEvents columnButtons As DataGridViewButtonColumn
    Friend WithEvents topPanel As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents btnClose As Button
End Class
