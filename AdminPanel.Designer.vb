<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.btnGenMatches = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ListBoxMatches = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboRegion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numSeason = New System.Windows.Forms.NumericUpDown()
        CType(Me.numSeason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenMatches
        '
        Me.btnGenMatches.Location = New System.Drawing.Point(34, 12)
        Me.btnGenMatches.Name = "btnGenMatches"
        Me.btnGenMatches.Size = New System.Drawing.Size(164, 51)
        Me.btnGenMatches.TabIndex = 0
        Me.btnGenMatches.Text = "Generate Weekly Matches"
        Me.btnGenMatches.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(249, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 21)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel Match"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ListBoxMatches
        '
        Me.ListBoxMatches.FormattingEnabled = True
        Me.ListBoxMatches.Location = New System.Drawing.Point(12, 93)
        Me.ListBoxMatches.Name = "ListBoxMatches"
        Me.ListBoxMatches.Size = New System.Drawing.Size(334, 251)
        Me.ListBoxMatches.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Generated Matches:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Region:"
        '
        'comboRegion
        '
        Me.comboRegion.FormattingEnabled = True
        Me.comboRegion.Items.AddRange(New Object() {"Europe", "America"})
        Me.comboRegion.Location = New System.Drawing.Point(213, 35)
        Me.comboRegion.Name = "comboRegion"
        Me.comboRegion.Size = New System.Drawing.Size(58, 21)
        Me.comboRegion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Season:"
        '
        'numSeason
        '
        Me.numSeason.Location = New System.Drawing.Point(288, 35)
        Me.numSeason.Name = "numSeason"
        Me.numSeason.Size = New System.Drawing.Size(41, 20)
        Me.numSeason.TabIndex = 5
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 380)
        Me.Controls.Add(Me.numSeason)
        Me.Controls.Add(Me.comboRegion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxMatches)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenMatches)
        Me.Name = "AdminPanel"
        Me.Text = "AdminPanel"
        CType(Me.numSeason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenMatches As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ListBoxMatches As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comboRegion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numSeason As NumericUpDown
End Class
