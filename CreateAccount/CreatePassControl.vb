Public Class CreatePassControl
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim mainForm As CreateAccountHolder = TryCast(Me.ParentForm, CreateAccountHolder)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToCreateImageControl()
        End If
    End Sub
End Class
