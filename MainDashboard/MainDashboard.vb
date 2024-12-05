Public Class MainDashboard
    Public Sub switchTableLayoutPanel(tlp As TableLayoutPanel, newControl As UserControl)
        tlp.Controls.Clear()
        newControl.Dock = DockStyle.Fill
        tlp.Controls.Add(newControl, 0, 0)
    End Sub

    'DASHBOARD
    Public Sub SwitchToMainDashboardControl()
        switchTableLayoutPanel(tlpMain, New MainDashboardControl())
    End Sub

    'REGISTRERED USER
    Public Sub SwitchToRegisterdUserControl()
        switchTableLayoutPanel(tlpMain, New RegisterdUsersHomeControl())
    End Sub
    Public Sub SwitchToUpdateRegisterControl()
        switchTableLayoutPanel(tlpMain, New UpdateUserControl())
    End Sub

    'BARANGAY
    Public Sub SwitchToBarangayHomeControl()
        switchTableLayoutPanel(tlpMain, New HomeBarangay())
    End Sub
    Public Sub SwitchToAddBarangayControl()
        switchTableLayoutPanel(tlpMain, New AddBarangays())
    End Sub

    Public Sub SwitchToEditBarangayControl()
        switchTableLayoutPanel(tlpMain, New EditBarangayControl())
    End Sub
    Public Sub SwitchToDeleteBarangayControl()
        switchTableLayoutPanel(tlpMain, New DeleteBarangayControl())
    End Sub

    'REPORT
    Public Sub SwitchToReportControl()
        switchTableLayoutPanel(tlpMain, New ReportControl())
    End Sub




    'MANAGE USERS
    Public Sub SwitchToManageHomeControl()
        switchTableLayoutPanel(tlpMain, New ManageHomeControl())
    End Sub
    Public Sub SwitchToAccountDetailsControl()
        switchTableLayoutPanel(tlpMain, New AccountDetailsControl())
    End Sub
    Public Sub SwitchToUpdateAccountDetailsControl()
        switchTableLayoutPanel(tlpMain, New AccUpdateDetailsControl())
    End Sub
    Public Sub SwitchToAccountChangePassControl()
        switchTableLayoutPanel(tlpMain, New AccChangePassControl())
    End Sub













    'NAV
    Private Sub btnRegisteredUsers_Click(sender As Object, e As EventArgs) Handles btnRegisteredUsers.Click
        SwitchToRegisterdUserControl()
    End Sub


    Private Sub btnBarangay_Click(sender As Object, e As EventArgs) Handles btnBarangay.Click
        SwitchToBarangayHomeControl()
    End Sub


    Private Sub MainDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub

    Private Sub btnMainDB_Click(sender As Object, e As EventArgs) Handles btnMainDB.Click
        SwitchToMainDashboardControl()
    End Sub

    Private Sub btnManageInmate_Click(sender As Object, e As EventArgs) Handles btnManageInmate.Click
        SwitchToReportControl()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout.Show()
        Me.Hide()

    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        SwitchToManageHomeControl()
    End Sub
End Class