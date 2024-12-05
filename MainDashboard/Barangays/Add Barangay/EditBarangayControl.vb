Public Class EditBarangayControl
    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToBarangayHomeControl()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToBarangayHomeControl()
        End If
    End Sub
End Class
