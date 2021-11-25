Public Class Welcome

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        'Checks if the program has a user already registered in the system from the DataClass
        If DataClass.userInfo IsNot Nothing Then
            'If there is a user, close this form then direct to Customize form
            Customize.Show()
        Else
            'If there is no user, close this form then direct to Account form
            Account.Show()
        End If

        Me.Hide()
    End Sub

End Class
