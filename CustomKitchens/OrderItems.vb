Public Class OrderItems

    Dim laminatePrice, woodblockPrice, granitePrice, basicFridgePrice, americanFridgePrice, hobPrice, singleOvenPrice, doubleOvenPrice, dishwasherPrice, installationPrice, shippingPrice, amenitiesPrice, fullPrice As Integer
    Dim houseNo, streetName, town_city, postCode, creditCard As String

    Private Sub rdbYesInstallation_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYesInstallation.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the Radio Button for YES Installation
        If rdbYesInstallation.Checked Then
            amenitiesPrice = amenitiesPrice + installationPrice - shippingPrice
            fullPrice = fullPrice + installationPrice - shippingPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub rdbNoInstallation_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNoInstallation.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the Radio Button for NO Installation
        If rdbNoInstallation.Checked Then
            amenitiesPrice = amenitiesPrice - installationPrice + shippingPrice
            fullPrice = fullPrice - installationPrice + shippingPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkDishwasher_CheckedChanged(sender As Object, e As EventArgs) Handles chkDishwasher.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox DishWasher
        If chkDishwasher.Checked Then
            amenitiesPrice += dishwasherPrice
            fullPrice += dishwasherPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= dishwasherPrice
            fullPrice -= dishwasherPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkDoubleOven_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoubleOven.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox Double Oven
        If chkDoubleOven.Checked Then
            amenitiesPrice += doubleOvenPrice
            fullPrice += doubleOvenPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= doubleOvenPrice
            fullPrice -= doubleOvenPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkSingleOven_CheckedChanged(sender As Object, e As EventArgs) Handles chkSingleOven.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox Single Oven
        If chkSingleOven.Checked Then
            amenitiesPrice += singleOvenPrice
            fullPrice += singleOvenPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= singleOvenPrice
            fullPrice -= singleOvenPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkHob_CheckedChanged(sender As Object, e As EventArgs) Handles chkHob.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox HOB
        If chkHob.Checked Then
            amenitiesPrice += hobPrice
            fullPrice += hobPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= hobPrice
            fullPrice -= hobPrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkAmericanFridge_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmericanFridge.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox American Fridge
        If chkAmericanFridge.Checked Then
            amenitiesPrice += americanFridgePrice
            fullPrice += americanFridgePrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= americanFridgePrice
            fullPrice -= americanFridgePrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub chkBasicFridge_CheckedChanged(sender As Object, e As EventArgs) Handles chkBasicFridge.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the CheckBox Basic Fridge
        If chkBasicFridge.Checked Then
            amenitiesPrice += basicFridgePrice
            fullPrice += basicFridgePrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        Else
            amenitiesPrice -= basicFridgePrice
            fullPrice -= basicFridgePrice
            lblTotalPrice.Text = fullPrice.ToString()
            lblAmenitiesShipping.Text = amenitiesPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub rdbGranite_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGranite.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the Radio Button Granite
        If rdbGranite.Checked Then
            fullPrice += granitePrice
            lblTotalPrice.Text = fullPrice.ToString()
        Else
            fullPrice -= granitePrice
            lblTotalPrice.Text = fullPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub rdbWoodBlock_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWoodBlock.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the Radio Button WoodBlock
        If rdbWoodBlock.Checked Then
            fullPrice += woodblockPrice
            lblTotalPrice.Text = fullPrice.ToString()
        Else
            fullPrice -= woodblockPrice
            lblTotalPrice.Text = fullPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub rdbLaminate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLaminate.CheckedChanged
        'This updates the Prices and refreshes the Form upon clicking the Radio Button Laminate
        If rdbLaminate.Checked Then
            fullPrice += laminatePrice
            lblTotalPrice.Text = fullPrice.ToString()
        Else
            fullPrice -= laminatePrice
            lblTotalPrice.Text = fullPrice.ToString()
        End If
        Refresh()
    End Sub

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click
        If Not rdbLaminate.Checked Or rdbWoodBlock.Checked Or rdbGranite.Checked Then
            'Confirm that the user has selected a Kitchen Counter top
            MessageBox.Show("Please input Countertop preference")
        ElseIf Not rdbYesInstallation.Checked Or rdbNoInstallation.Checked Then
            'Confirm that the user has selected whether he/she wants Installation service
            MessageBox.Show("Please specify if you wish to have installation service")
        Else
            'Fetch user info
            houseNo = InputBox("Enter your house number", "Payment Details for " & DataClass.userInfo.Item1)

            streetName = InputBox("Enter your Street Name", "Payment Details for " & DataClass.userInfo.Item1)

            town_city = InputBox("Enter your Town/City", "Payment Details for " & DataClass.userInfo.Item1)

            postCode = InputBox("Enter your Postal Code", "Payment Details for " & DataClass.userInfo.Item1)

            creditCard = InputBox("Enter your Credit Card details", "Payment Details for " & DataClass.userInfo.Item1)

            'Print to .txt file : User Details, Total price 
            Dim file As IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Dan Mwangi\source\repos\CustomKitchens\CustomKitchens\obj\Debug\KitchenReceipt.txt", True)
            file.WriteLine("--------------------------------" & vbCr & vbCr & "Customer Name : " & DataClass.userInfo.Item1 & vbCr & "Cost of purchase : " & fullPrice.ToString() & vbCr & vbCr & "--------------------------------")
            file.Close()

            'Inform the user that he has completed the Order Process
            MessageBox.Show("Success! We have placed your Order.")
        End If
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Me.Dispose()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        lblUsername.Text = DataClass.userInfo.Item1
        lblEmailAddress.Text = DataClass.userInfo.Item2
        lblPhone.Text = DataClass.userInfo.Item3

        basicFridgePrice = 180
        americanFridgePrice = 750
        hobPrice = 100
        singleOvenPrice = 340
        doubleOvenPrice = 550
        dishwasherPrice = 270

        shippingPrice = 95

        lblAmenitiesShipping.Text = (amenitiesPrice + shippingPrice).ToString()
        lblTotalPrice.Text = fullPrice.ToString()

        For Each layout As Object In DataClass.KitchenLayouts
            If layout.Item1.Equals(DataClass.selectedLayout) Then

                laminatePrice = layout.Item5
                woodblockPrice = layout.Item6
                granitePrice = layout.Item7

                If layout.Item1.Equals(1) Then
                    installationPrice = 1250
                ElseIf layout.Item1.Equals(2) Then
                    installationPrice = 2750
                ElseIf layout.Item1.Equals(3) Then
                    installationPrice = 3750
                ElseIf layout.Item1.Equals(4) Then
                    installationPrice = 750
                ElseIf layout.Item1.Equals(5) Then
                    installationPrice = 1500
                ElseIf layout.Item1.Equals(6) Then
                    installationPrice = 2500
                ElseIf layout.Item1.Equals(7) Then
                    installationPrice = 4750
                End If

                lblKitchenLayoutTitle.Text = layout.Item2

            End If

        Next


        rdbLaminate.Text = rdbLaminate.Text & laminatePrice.ToString() & " /="
        rdbWoodBlock.Text = rdbWoodBlock.Text & woodblockPrice.ToString() & " /="
        rdbGranite.Text = rdbGranite.Text & granitePrice.ToString() & " /="

        chkBasicFridge.Text = chkBasicFridge.Text & basicFridgePrice.ToString() & " /="
        chkAmericanFridge.Text = chkAmericanFridge.Text & americanFridgePrice.ToString() & " /="
        chkHob.Text = chkHob.Text & hobPrice.ToString() & " /="
        chkSingleOven.Text = chkSingleOven.Text & singleOvenPrice.ToString() & " /="
        chkDoubleOven.Text = chkDoubleOven.Text & doubleOvenPrice.ToString() & " /="
        chkDishwasher.Text = chkDishwasher.Text & dishwasherPrice.ToString() & " /="

        grpInstallation.Text = grpInstallation.Text & installationPrice.ToString() & " /="

    End Sub

End Class