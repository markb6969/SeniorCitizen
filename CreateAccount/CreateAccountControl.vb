Public Class CreateAccountControl
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim mainForm As CreateAccountHolder = TryCast(Me.ParentForm, CreateAccountHolder)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToCreatePassControl()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CreateAccountHolder.Show()
        Me.Hide()

    End Sub
End Class
