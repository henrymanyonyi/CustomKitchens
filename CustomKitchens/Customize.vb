Public Class Customize

    'Declaring dimensions as Integers
    Dim dimensLength, dimensWidth As Integer

    'Declaring and storing/ hardcoding all data involving kitchen layouts e.g width = kitchenlayout(3)
    Dim kitchenLayouts() As Object = {(1, "Small L-shaped Kitchen", 250, 180, 3500, 4500, 5750),
        (2, "Medium L-shaped Kitchen", 350, 240, 6500, 7750, 9500),
        (3, "Large L-shaped Kitchen", 450, 350, 8250, 9500, 12500),
        (4, "Small Straight Kitchen", 150, 60, 1000, 1500, 2200),
        (5, "Medium Straight Kitchen", 350, 60, 5250, 6200, 8000),
        (6, "Large Straight Kitchen", 250, 180, 3500, 4500, 5750),
        (7, "Large Island Kitchen", 450, 450, 12500, 15000, 23000)}

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        For Each layout As Object In kitchenLayouts
            updateListView(layout)
        Next

    End Sub

    Private Sub btnSendDimens_Click(sender As Object, e As EventArgs) Handles btnSendDimens.Click

        If IsNumeric(txtLength.Text.Trim) And IsNumeric(txtWidth.Text.Trim) Then
            lvKitchenLayouts.Items.Clear()

            dimensLength = txtLength.Text
            dimensWidth = txtWidth.Text

            Dim counter As Integer

            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                    counter += 1
                End If
            Next

            If counter > 1 Then

                If grpKitchenLayouts.Enabled.Equals(False) Then
                    grpKitchenLayouts.Enabled = True
                End If

                For Each layout As Object In kitchenLayouts

                    If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                        updateListView(layout)
                    End If

                Next

            Else
                If grpKitchenLayouts.Enabled.Equals(True) Then
                    grpKitchenLayouts.Enabled = False
                End If

                MessageBox.Show("Sorry, we do not have any items with your Kitchen dimensions")
            End If
        Else
            If grpKitchenLayouts.Enabled.Equals(True) Then
                grpKitchenLayouts.Enabled = False
            End If
            MessageBox.Show("Invalid Dimension inputs")
        End If

    End Sub

    Private Sub cboPriceRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPriceRange.SelectedIndexChanged

        lvKitchenLayouts.Items.Clear()

        If cboPriceRange.SelectedIndex.Equals(0) Then
            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth Then
                    updateListView(layout)
                End If
            Next
        ElseIf cboPriceRange.SelectedIndex.Equals(1) Then
            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth And layout.Item5 <= 5000 Or layout.Item6 <= 5000 Or layout.Item7 <= 5000 Then
                    updateListView(layout)
                End If
            Next
        ElseIf cboPriceRange.SelectedIndex.Equals(2) Then
            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth And layout.Item5 > 5000 And layout.Item5 <= 7000 Or layout.Item6 >= 5000 And layout.Item6 <= 7000 Or layout.Item7 >= 5000 And layout.Item7 <= 7000 Then
                    updateListView(layout)
                End If
            Next

        ElseIf cboPriceRange.SelectedIndex.Equals(3) Then
            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth And layout.Item5 > 7000 And layout.Item5 <= 9000 Or layout.Item6 > 7000 And layout.Item6 <= 9000 Or layout.Item7 > 7000 And layout.Item7 <= 9000 Then
                    updateListView(layout)
                End If
            Next

        ElseIf cboPriceRange.SelectedIndex.Equals(4) Then
            For Each layout As Object In kitchenLayouts
                If layout.Item3 <= dimensLength And layout.Item4 <= dimensWidth And layout.Item5 > 9000 Or layout.Item6 > 9000 Or layout.Item7 > 9000 Then
                    updateListView(layout)
                End If
            Next
        End If
    End Sub

    Private Sub updateListView(layout As Object)
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