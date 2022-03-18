Imports System.Windows.Forms

Public Class diaEditSchedule

    Private Sub diaEditSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// Update slider positions to availabilities
        sliderMon.ValueLeft = MyUser.AvailMon(0)
        sliderMon.ValueRight = MyUser.AvailMon(1)

        sliderTue.ValueLeft = MyUser.AvailTue(0)
        sliderTue.ValueRight = MyUser.AvailTue(1)

        sliderWed.ValueLeft = MyUser.AvailWed(0)
        sliderWed.ValueRight = MyUser.AvailWed(1)

        sliderThur.ValueLeft = MyUser.AvailThu(0)
        sliderThur.ValueRight = MyUser.AvailThu(1)

        sliderFri.ValueLeft = MyUser.AvailFri(0)
        sliderFri.ValueRight = MyUser.AvailFri(1)

        sliderSat.ValueLeft = MyUser.AvailSat(0)
        sliderSat.ValueRight = MyUser.AvailSat(1)

        sliderSun.ValueLeft = MyUser.AvailSun(0)
        sliderSun.ValueRight = MyUser.AvailSun(1)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        '// Save slider values to variables, then update the database.
        MyUser.AvailMon(0) = sliderMon.ValueLeft
        MyUser.AvailMon(1) = sliderMon.ValueRight

        MyUser.AvailTue(0) = sliderTue.ValueLeft
        MyUser.AvailTue(1) = sliderTue.ValueRight

        MyUser.AvailWed(0) = sliderWed.ValueLeft
        MyUser.AvailWed(1) = sliderWed.ValueRight

        MyUser.AvailThu(0) = sliderThur.ValueLeft
        MyUser.AvailThu(1) = sliderThur.ValueRight

        MyUser.AvailFri(0) = sliderFri.ValueLeft
        MyUser.AvailFri(1) = sliderFri.ValueRight

        MyUser.AvailSat(0) = sliderSat.ValueLeft
        MyUser.AvailSat(1) = sliderSat.ValueRight

        MyUser.AvailSun(0) = sliderSun.ValueLeft
        MyUser.AvailSun(1) = sliderSun.ValueRight

        UpdateAvailabilities()
        FormMain.UpdateUserInfo()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkAvailChangeAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailChangeAll.CheckedChanged
        If chkAvailChangeAll.Checked Then
            GroupBoxMon.Text = "Every day"
            GroupBoxTue.Enabled = False
            GroupBoxWed.Enabled = False
            GroupBoxThu.Enabled = False
            GroupBoxFri.Enabled = False
            GroupBoxSat.Enabled = False
            GroupBoxSun.Enabled = False
        Else
            GroupBoxMon.Text = "Monday"
            GroupBoxTue.Enabled = True
            GroupBoxWed.Enabled = True
            GroupBoxThu.Enabled = True
            GroupBoxFri.Enabled = True
            GroupBoxSat.Enabled = True
            GroupBoxSun.Enabled = True
        End If
    End Sub

    Private Sub sliderMon_UpdateValues(sender As Object, e As EventArgs) Handles sliderMon.ValueChanged
        lblMonStart.Text = ConvertSliderValToTime(sliderMon.ValueLeft)
        lblMonEnd.Text = ConvertSliderValToTime(sliderMon.ValueRight)

        If chkAvailChangeAll.Checked Then
            '// Change all values at once
            sliderTue.ValueLeft = sliderMon.ValueLeft
            sliderWed.ValueLeft = sliderMon.ValueLeft
            sliderThur.ValueLeft = sliderMon.ValueLeft
            sliderFri.ValueLeft = sliderMon.ValueLeft
            sliderSat.ValueLeft = sliderMon.ValueLeft
            sliderSun.ValueLeft = sliderMon.ValueLeft
        End If
    End Sub

    Private Sub sliderTue_UpdateValues(sender As Object, e As EventArgs) Handles sliderTue.ValueChanged
        lblTueStart.Text = ConvertSliderValToTime(sliderTue.ValueLeft)
        lblTueEnd.Text = ConvertSliderValToTime(sliderTue.ValueRight)
    End Sub

    Private Sub sliderWed_UpdateValues(sender As Object, e As EventArgs) Handles sliderWed.ValueChanged
        lblWedStart.Text = ConvertSliderValToTime(sliderWed.ValueLeft)
        lblWedEnd.Text = ConvertSliderValToTime(sliderWed.ValueRight)
    End Sub

    Private Sub sliderThu_UpdateValues(sender As Object, e As EventArgs) Handles sliderThur.ValueChanged
        lblThurStart.Text = ConvertSliderValToTime(sliderThur.ValueLeft)
        lblThurEnd.Text = ConvertSliderValToTime(sliderThur.ValueRight)
    End Sub

    Private Sub sliderFri_UpdateValues(sender As Object, e As EventArgs) Handles sliderFri.ValueChanged
        lblFriStart.Text = ConvertSliderValToTime(sliderFri.ValueLeft)
        lblFriEnd.Text = ConvertSliderValToTime(sliderFri.ValueRight)
    End Sub

    Private Sub sliderSat_UpdateValues(sender As Object, e As EventArgs) Handles sliderSat.ValueChanged
        lblSatStart.Text = ConvertSliderValToTime(sliderSat.ValueLeft)
        lblSatEnd.Text = ConvertSliderValToTime(sliderSat.ValueRight)
    End Sub

    Private Sub sliderSun_UpdateValues(sender As Object, e As EventArgs) Handles sliderSun.ValueChanged
        lblSunStart.Text = ConvertSliderValToTime(sliderSun.ValueLeft)
        lblSunEnd.Text = ConvertSliderValToTime(sliderSun.ValueRight)
    End Sub

    Private Function ConvertSliderValToTime(sliderVal As Integer) As String
        'Changes the value given by the double track bar, and outputs a time formatted string
        If sliderVal > 0 Then
            Return sliderVal & " PM"
        Else
            Return "12 AM"
        End If
    End Function

End Class
