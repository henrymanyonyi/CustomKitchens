Imports System.Text.RegularExpressions
'From the System Class, import ReqularExpressions Subroutine which will be used to validate user Phone and Email

Public Class Account
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Trim().Length = 0 And txtUserEmail.Text.Trim().Length = 0 Or txtUserPhone.Text.Trim().Length = 0 Then
            'Show a message when the user input provided is empty
            MessageBox.Show("Invalid parameters")
        Else
            'Validate and store user info using the subroutine validateAndStore()
            validateAndStore()
        End If

    End Sub

    Private Sub validateAndStore()
        If Not Regex.IsMatch(txtUserEmail.Text.Trim(), "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") Then
            'If the Email provided does not match the Regex for the correct email, inform the user
            MessageBox.Show("Invalid Email Address")
        ElseIf Not Regex.IsMatch(txtUserPhone.Text.Trim(), "^([0]+\d{9})$") Then
            'If the Phone provided does not match the Regex for the correct phone, inform the user
            MessageBox.Show("Invalid Phone Number" + vbCr + "Your phone should be in the format : 0712345678")
        Else
            'If all values provided are correct, add the user in the system via the Data Class then open Customize Form 
            DataClass.userInfo = (txtUserName.Text.Trim, txtUserEmail.Text.Trim, txtUserPhone.Text.Trim)

            Customize.Show()

            Me.Hide()
        End If

    End Sub
End Class