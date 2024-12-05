Public Class DeleteBarangayControl
    Private Sub lblFirstName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToBarangayHomeControl()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToBarangayHomeControl()
        End If
    End Sub
End Class
