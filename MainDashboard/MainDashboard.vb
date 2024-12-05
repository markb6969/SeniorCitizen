Public Class MainDashboard
    Public Sub switchTableLayoutPanel(tlp As TableLayoutPanel, newControl As UserControl)
        tlp.Controls.Clear()
        newControl.Dock = DockStyle.Fill
        tlp.Controls.Add(newControl, 0, 0)
    End Sub

    'REGISTRERED USER
    Public Sub SwitchToRegisterdUserControl()
        switchTableLayoutPanel(tlpMain, New RegisterdUsersHomeControl())
    End Sub
    Public Sub SwitchToUpdateRegisterControl()
        switchTableLayoutPanel(tlpMain, New UpdateUserControl())
    End Sub



    'NAV
    Private Sub btnRegisteredUsers_Click(sender As Object, e As EventArgs) Handles btnRegisteredUsers.Click
        SwitchToRegisterdUserControl()
    End Sub



    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnBarangay.Click

    End Sub

    Private Sub MainDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub
End Class