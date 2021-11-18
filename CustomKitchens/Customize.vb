Public Class Customize

    '<<<<<<< HEAD
    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '        Dim check As Button
    '        Dim options As GroupBox
    '        options = New GroupBox()
    '        check = New Button()
    '        options.Name = "preferences"
    '        options.Text = "Preferences"
    '        check.Text = "Confirm"
    '        check.Name = "check"
    '        check.Location = New Point(50, 50)
    '        options.Controls.Add(check)
    '        Me.Controls.Add(options)
    '        Me.Refresh()
    '=======

    'Declaring dimensions as Integers
    Dim dimensLength, dimensWidth As Integer

    'Declaring and storing/ hardcoding all data involving kitchen layouts e.g width = kitchenlayout(3)
    Dim kitchenLayouts0() As Object = {("Small L-shaped Kitchen", 250, 180, "Laminate", "Wood block", "Granite", 3500, 4500, 5750),
        ("Medium L-shaped Kitchen", 350, 240, "Laminate", "Wood block", "Granite", 6500, 7750, 9500),
        ("Large L-shaped Kitchen", 450, 350, "Laminate", "Wood block", "Granite", 8250, 9500, 12500),
        ("Small Straight Kitchen", 150, 60, "Laminate", "Wood block", "Granite", 1000, 1500, 2200),
        ("Medium Straight Kitchen", 350, 60, "Laminate", "Wood block", "Granite", 5250, 6200, 8000),
        ("Large Straight Kitchen", 250, 180, "Laminate", "Wood block", "Granite", 3500, 4500, 5750),
        ("Large Island Kitchen", 450, 450, "Laminate", "Wood block", "Granite", 12500, 15000, 23000)}

    'Dim kitchenLayouts1() As Object = {1, "Small L-shaped Kitchen", 250, 180, "Laminate", "Wood block", "Granite", 3500, 4500, 5750}

    'Dim kitchenLayouts2() As Object = {2, "Medium L-shaped Kitchen", 350, 240, "Laminate", "Wood block", "Granite", 6500, 7750, 9500}

    'Dim kitchenLayouts3() As Object = {3, "Large L-shaped Kitchen", 450, 350, "Laminate", "Wood block", "Granite", 8250, 9500, 12500}

    'Dim kitchenLayouts4() As Object = {4, "Small Straight Kitchen", 150, 60, "Laminate", "Wood block", "Granite", 1000, 1500, 2200}

    'Dim kitchenLayouts5() As Object = {5, "Medium Straight Kitchen", 350, 60, "Laminate", "Wood block", "Granite", 5250, 6200, 8000}

    'Dim kitchenLayouts6() As Object = {6, "Large Straight Kitchen", 250, 180, "Laminate", "Wood block", "Granite", 3500, 4500, 5750}

    'Dim kitchenLayouts7() As Object = {7, "Large Island Kitchen", 450, 450, "Laminate", "Wood block", "Granite", 12500, 15000, 23000}

    'Onclicking the Confirm button, this code executes
    Private Sub btnSendDimens_Click(sender As Object, e As EventArgs) Handles btnSendDimens.Click

        'check is all user inputs are integers
        If IsNumeric(txtLength.Text) And IsNumeric(txtWidth.Text) Then
            'If the conditions are valid, store user input in dimensLength and dimensWidth
            dimensLength = txtLength.Text
            dimensWidth = txtWidth.Text

            'Initialize and array that stores all values that are in range of Dimension set by user
            Dim inDimensRange() As Object = {}

            For Each layout As Object In kitchenLayouts0

                If layout.Item2 <= dimensLength And layout.Item3 <= dimensWidth Then
                    ReDim Preserve inDimensRange(inDimensRange.Length)
                    inDimensRange(inDimensRange.Length - 1) = layout.Item1
                End If

            Next


            'If kitchenLayouts1(2) <= dimensLength And kitchenLayouts1(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts1(1)
            'End If
            'If kitchenLayouts2(2) <= dimensLength And kitchenLayouts2(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts2(1)
            'End If
            'If kitchenLayouts3(2) <= dimensLength And kitchenLayouts3(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts3(1)
            'End If
            'If kitchenLayouts4(2) <= dimensLength And kitchenLayouts4(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts4(1)
            'End If
            'If kitchenLayouts5(2) <= dimensLength And kitchenLayouts5(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts5(1)
            'End If
            'If kitchenLayouts6(2) <= dimensLength And kitchenLayouts6(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts6(1)
            'End If
            'If kitchenLayouts7(2) <= dimensLength And kitchenLayouts7(3) <= dimensWidth Then
            '    ReDim Preserve inDimensRange(inDimensRange.Length)
            '    inDimensRange(inDimensRange.Length - 1) = kitchenLayouts7(1)
            'End If

            Dim output As String = ""

            For Each name As String In inDimensRange
                output += name + vbCr
            Next


            MessageBox.Show(inDimensRange.Length.ToString() + vbCr + vbCr + output)

        Else
            MessageBox.Show("Incorrect Length or Width." + vbCr + "Please enter whole numbers")
            txtLength.Text = ""
            txtWidth.Text = ""
        End If
    End Sub

End Class