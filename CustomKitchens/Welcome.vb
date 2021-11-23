Public Class Welcome

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        If DataClass.userInfo IsNot Nothing Then
            Customize.Show()
        Else
            Account.Show()
        End If

        Me.Hide()
    End Sub

End Class
