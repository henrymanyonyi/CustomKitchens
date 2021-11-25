Public Class Customize

    Dim dimensLength, dimensWidth As Integer

    Protected Overrides Sub OnLoad(e As EventArgs)
        'On loading the Form, populate the ListView with all Kitchen Layouts
        MyBase.OnLoad(e)

        For Each layout As Object In DataClass.KitchenLayouts
            UpdateListView(layout)
        Next

    End Sub

    Private Sub btnSendDimens_Click(sender As Object, e As EventArgs) Handles btnSendDimens.Click

        If IsNumeric(txtLength.Text.Trim) And IsNumeric(txtWidth.Text.Trim) Then
            'Validate user input from the Dimensions provided
            lvKitchenLayouts.Items.Clear()

            Try
                'Catch the OutOfBounds Exception incase a user enters a large dimensions
                dimensLength = txtLength.Text
                dimensWidth = txtWidth.Text
            Catch ex As Exception
                MessageBox.Show("Sorry, we cannot recognise your dimensions." + vbCr + "Please try lower values")
            End Try

            Dim counter As Integer = 0

            'Check if there are any Kitchen Layouts based on the user's dimensions
            For Each layout As Object In DataClass.KitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                    counter += 1
                End If
            Next

            If counter > 0 Then
                'Continue if there are kitchen layouts found 
                If grpKitchenLayouts.Enabled.Equals(False) Then
                    grpKitchenLayouts.Enabled = True
                End If

                For Each layout As Object In DataClass.KitchenLayouts
                    'Update the listview populating the values with all kitchen layouts that are valid
                    If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                        UpdateListView(layout)
                    End If

                Next

            Else
                'Disable the GroupBox and inform the user that there are no Layouts found based on the user's dimensions
                If grpKitchenLayouts.Enabled.Equals(True) Then
                    grpKitchenLayouts.Enabled = False
                End If

                MessageBox.Show("Sorry, we do not have any items with your Kitchen dimensions")
            End If
        Else
            'Inform the user that his/her input was invalid and disable the GroupBox
            If grpKitchenLayouts.Enabled.Equals(True) Then
                grpKitchenLayouts.Enabled = False
            End If
            MessageBox.Show("Invalid Dimension inputs")
        End If

    End Sub

    Private Sub lvKitchenLayouts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKitchenLayouts.SelectedIndexChanged
        'When the user selects a KitchenLayout from the ListView, Enable the purchase button
        btnPurchase.Enabled = True
    End Sub

    Private Sub cboPriceRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPriceRange.SelectedIndexChanged
        'This Subroutine updates the listview according to the user's set Price Range.
        lvKitchenLayouts.Items.Clear()

        If cboPriceRange.SelectedIndex.Equals(0) Then
            'Update the listview with all Kitchen Dimensions
            For Each layout As Object In DataClass.KitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                    UpdateListView(layout)
                End If
            Next
        ElseIf cboPriceRange.SelectedIndex.Equals(1) Then
            'Update the listview with all Kitchen Dimensions that fall in the range: Below 5000
            For Each layout As Object In DataClass.KitchenLayouts
                If (layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth) AndAlso (layout.Item5 <= 5000 Or layout.Item6 <= 5000 Or layout.Item7 <= 5000) Then
                    UpdateListView(layout)
                End If
            Next
        ElseIf cboPriceRange.SelectedIndex.Equals(2) Then
            'Update the listview with all Kitchen Dimensions that fall in the range: 5001 - 7000
            For Each layout As Object In DataClass.KitchenLayouts
                If (layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth) AndAlso (layout.Item5 > 5000 And layout.Item5 <= 7000 Or layout.Item6 > 5000 And layout.Item6 <= 7000 Or layout.Item7 > 5000 And layout.Item7 <= 7000) Then
                    UpdateListView(layout)
                End If
            Next

        ElseIf cboPriceRange.SelectedIndex.Equals(3) Then
            'Update the listview with all Kitchen Dimensions that fall in the range: 7001 - 9000
            For Each layout As Object In DataClass.KitchenLayouts
                If (layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth) AndAlso (layout.Item5 > 7000 And layout.Item5 <= 9000 Or layout.Item6 > 7000 And layout.Item6 <= 9000 Or layout.Item7 > 7000 And layout.Item7 <= 9000) Then
                    UpdateListView(layout)
                End If
            Next

        ElseIf cboPriceRange.SelectedIndex.Equals(4) Then
            'Update the listview with all Kitchen Dimensions that fall in the range: Above 9000
            For Each layout As Object In DataClass.KitchenLayouts
                If (layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth) AndAlso (layout.Item5 > 9000 Or layout.Item6 > 9000 Or layout.Item7 > 9000) Then
                    UpdateListView(layout)
                End If
            Next
        End If
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        If Not IsNothing(lvKitchenLayouts.FocusedItem) Then
            'Onclick the Purchase button, Check for the Selected Kitchen Layout and Update the DataClass then show the OrderSummary dialog box
            DataClass.selectedLayout = lvKitchenLayouts.FocusedItem.SubItems(0).Text
            OrderItems.ShowDialog()
        Else
            'Inform the user that they have not selected any Kitchen Layout
            MessageBox.Show("Please select a Kitchen Layout from the available layouts")
        End If

    End Sub

    Private Sub UpdateListView(layout As Object)
        'This Subroutine updates the ListView with Kitchen Values
        Dim newItem As New ListViewItem(layout.Item1.ToString())
        newItem.SubItems.Add(layout.Item2)
        newItem.SubItems.Add(layout.Item3)
        newItem.SubItems.Add(layout.Item4)
        newItem.SubItems.Add(layout.Item5)
        newItem.SubItems.Add(layout.Item6)
        newItem.SubItems.Add(layout.Item7)

        lvKitchenLayouts.Items.Add(newItem)
    End Sub

End Class