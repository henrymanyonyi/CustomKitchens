Imports System.Text.RegularExpressions

Public Class Account

    Public name, email, phone As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Trim().Length = 0 And txtUserEmail.Text.Trim().Length = 0 Or txtUserPhone.Text.Trim().Length = 0 Then
            MessageBox.Show("Invalid parameters")
        Else
            validateAndStore()
        End If

    End Sub

    Private Sub validateAndStore()
        If Not Regex.IsMatch(txtUserEmail.Text.Trim(), "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") Then
            MessageBox.Show("Invalid Email Address")
        ElseIf Not Regex.IsMatch(txtUserPhone.Text.Trim(), "^([0]+\d{9})$") Then
            MessageBox.Show("Invalid Phone Number" + vbCr + "Your phone should be in the format : 0712345678")
        Else
            name = txtUserName.Text.Trim
            email = txtUserEmail.Text.Trim
            phone = txtUserPhone.Text.Trim

            Customize.Show()

            Me.Hide()
        End If

    End Sub
End Class