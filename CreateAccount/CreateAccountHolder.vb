Public Class CreateAccountHolder


    Public Sub switchTableLayoutPanel(tlp As TableLayoutPanel, newControl As UserControl)
        tlp.Controls.Clear()
        newControl.Dock = DockStyle.Fill
        tlp.Controls.Add(newControl, 0, 0)
    End Sub

    Public Sub SwitchToCreateAccountControl()
        switchTableLayoutPanel(tlpCreateAcc, New CreateAccountControl())
    End Sub

    Public Sub SwitchToCreatePassControl()
        switchTableLayoutPanel(tlpCreateAcc, New CreatePassControl())
    End Sub

    Public Sub SwitchToCreateImageControl()
        switchTableLayoutPanel(tlpCreateAcc, New CreateImageControl())
    End Sub


    Private Sub btnSuperAdmin_Click(sender As Object, e As EventArgs)
        SwitchToCreateAccountControl()
    End Sub

    Private Sub CreateAccountHolder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnSuperAdmin_Click_1(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        SwitchToCreateAccountControl()
    End Sub
End Class