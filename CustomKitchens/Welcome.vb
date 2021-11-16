Public Class Welcome

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        If Account.name IsNot Nothing And Account.email IsNot Nothing Or Account.phone IsNot Nothing Then
            Customize.Show()
        Else
            Account.Show()
        End If
        Me.Hide()
    End Sub

End Class
