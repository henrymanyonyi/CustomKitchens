<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpKitchenCounter = New System.Windows.Forms.GroupBox()
        Me.lblKitchenLayoutTitle = New System.Windows.Forms.Label()
        Me.rdbGranite = New System.Windows.Forms.RadioButton()
        Me.rdbWoodBlock = New System.Windows.Forms.RadioButton()
        Me.rdbLaminate = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpBillingDetails = New System.Windows.Forms.GroupBox()
        Me.lblAmenitiesShipping = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDishwasher = New System.Windows.Forms.CheckBox()
        Me.chkDoubleOven = New System.Windows.Forms.CheckBox()
        Me.chkSingleOven = New System.Windows.Forms.CheckBox()
        Me.chkHob = New System.Windows.Forms.CheckBox()
        Me.chkAmericanFridge = New System.Windows.Forms.CheckBox()
        Me.chkBasicFridge = New System.Windows.Forms.CheckBox()
        Me.grpInstallation = New System.Windows.Forms.GroupBox()
        Me.rdbNoInstallation = New System.Windows.Forms.RadioButton()
        Me.rdbYesInstallation = New System.Windows.Forms.RadioButton()
        Me.btnConfirmOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.grpKitchenCounter.SuspendLayout()
        Me.grpBillingDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpInstallation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpKitchenCounter
        '
        Me.grpKitchenCounter.Controls.Add(Me.lblKitchenLayoutTitle)
        Me.grpKitchenCounter.Controls.Add(Me.rdbGranite)
        Me.grpKitchenCounter.Controls.Add(Me.rdbWoodBlock)
        Me.grpKitchenCounter.Controls.Add(Me.rdbLaminate)
        Me.grpKitchenCounter.Controls.Add(Me.Label2)
        Me.grpKitchenCounter.Location = New System.Drawing.Point(13, 195)
        Me.grpKitchenCounter.Name = "grpKitchenCounter"
        Me.grpKitchenCounter.Size = New System.Drawing.Size(410, 137)
        Me.grpKitchenCounter.TabIndex = 0
        Me.grpKitchenCounter.TabStop = False
        Me.grpKitchenCounter.Text = "Kitchen Layout"
        '
        'lblKitchenLayoutTitle
        '
        Me.lblKitchenLayoutTitle.AutoSize = True
        Me.lblKitchenLayoutTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKitchenLayoutTitle.Location = New System.Drawing.Point(5, 24)
        Me.lblKitchenLayoutTitle.Name = "lblKitchenLayoutTitle"
        Me.lblKitchenLayoutTitle.Size = New System.Drawing.Size(170, 16)
        Me.lblKitchenLayoutTitle.TabIndex = 5
        Me.lblKitchenLayoutTitle.Text = "Small L-shaped Kitchen"
        '
        'rdbGranite
        '
        Me.rdbGranite.AutoSize = True
        Me.rdbGranite.Location = New System.Drawing.Point(227, 75)
        Me.rdbGranite.Name = "rdbGranite"
        Me.rdbGranite.Size = New System.Drawing.Size(76, 17)
        Me.rdbGranite.TabIndex = 4
        Me.rdbGranite.Text = "Granite @ "
        Me.rdbGranite.UseVisualStyleBackColor = True
        '
        'rdbWoodBlock
        '
        Me.rdbWoodBlock.AutoSize = True
        Me.rdbWoodBlock.Location = New System.Drawing.Point(9, 103)
        Me.rdbWoodBlock.Name = "rdbWoodBlock"
        Me.rdbWoodBlock.Size = New System.Drawing.Size(101, 17)
        Me.rdbWoodBlock.TabIndex = 3
        Me.rdbWoodBlock.Text = "Wood Block @ "
        Me.rdbWoodBlock.UseVisualStyleBackColor = True
        '
        'rdbLaminate
        '
        Me.rdbLaminate.AutoSize = True
        Me.rdbLaminate.Location = New System.Drawing.Point(9, 75)
        Me.rdbLaminate.Name = "rdbLaminate"
        Me.rdbLaminate.Size = New System.Drawing.Size(85, 17)
        Me.rdbLaminate.TabIndex = 1
        Me.rdbLaminate.Text = "Laminate @ "
        Me.rdbLaminate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please select the Counter Top of your desire"
        '
        'grpBillingDetails
        '
        Me.grpBillingDetails.Controls.Add(Me.lblAmenitiesShipping)
        Me.grpBillingDetails.Controls.Add(Me.Label3)
        Me.grpBillingDetails.Controls.Add(Me.lblTotalPrice)
        Me.grpBillingDetails.Controls.Add(Me.Label8)
        Me.grpBillingDetails.Controls.Add(Me.lblPhone)
        Me.grpBillingDetails.Controls.Add(Me.Label6)
        Me.grpBillingDetails.Controls.Add(Me.lblEmailAddress)
        Me.grpBillingDetails.Controls.Add(Me.Label4)
        Me.grpBillingDetails.Controls.Add(Me.lblUsername)
        Me.grpBillingDetails.Controls.Add(Me.Label1)
        Me.grpBillingDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpBillingDetails.Name = "grpBillingDetails"
        Me.grpBillingDetails.Size = New System.Drawing.Size(410, 168)
        Me.grpBillingDetails.TabIndex = 1
        Me.grpBillingDetails.TabStop = False
        Me.grpBillingDetails.Text = "Billing Details"
        '
        'lblAmenitiesShipping
        '
        Me.lblAmenitiesShipping.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmenitiesShipping.AutoSize = True
        Me.lblAmenitiesShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmenitiesShipping.Location = New System.Drawing.Point(354, 88)
        Me.lblAmenitiesShipping.Name = "lblAmenitiesShipping"
        Me.lblAmenitiesShipping.Size = New System.Drawing.Size(50, 16)
        Me.lblAmenitiesShipping.TabIndex = 9
        Me.lblAmenitiesShipping.Text = "2500 /="
        Me.lblAmenitiesShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amenities + Shipping"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.Location = New System.Drawing.Point(332, 134)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(72, 17)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "12500 /="
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(346, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Price"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(7, 136)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(87, 15)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "0712345678"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone Number"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblEmailAddress.Location = New System.Drawing.Point(6, 88)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(103, 15)
        Me.lblEmailAddress.TabIndex = 3
        Me.lblEmailAddress.Text = "john@doe.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email Address"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.Location = New System.Drawing.Point(7, 45)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 15)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "John Doe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDishwasher)
        Me.GroupBox1.Controls.Add(Me.chkDoubleOven)
        Me.GroupBox1.Controls.Add(Me.chkSingleOven)
        Me.GroupBox1.Controls.Add(Me.chkHob)
        Me.GroupBox1.Controls.Add(Me.chkAmericanFridge)
        Me.GroupBox1.Controls.Add(Me.chkBasicFridge)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optional Kitchen Appliances"
        '
        'chkDishwasher
        '
        Me.chkDishwasher.AutoSize = True
        Me.chkDishwasher.Location = New System.Drawing.Point(228, 65)
        Me.chkDishwasher.Name = "chkDishwasher"
        Me.chkDishwasher.Size = New System.Drawing.Size(98, 17)
        Me.chkDishwasher.TabIndex = 8
        Me.chkDishwasher.Text = "Dishwasher @ "
        Me.chkDishwasher.UseVisualStyleBackColor = True
        '
        'chkDoubleOven
        '
        Me.chkDoubleOven.AutoSize = True
        Me.chkDoubleOven.Location = New System.Drawing.Point(228, 42)
        Me.chkDoubleOven.Name = "chkDoubleOven"
        Me.chkDoubleOven.Size = New System.Drawing.Size(106, 17)
        Me.chkDoubleOven.TabIndex = 7
        Me.chkDoubleOven.Text = "Double Oven @ "
        Me.chkDoubleOven.UseVisualStyleBackColor = True
        '
        'chkSingleOven
        '
        Me.chkSingleOven.AutoSize = True
        Me.chkSingleOven.Location = New System.Drawing.Point(228, 19)
        Me.chkSingleOven.Name = "chkSingleOven"
        Me.chkSingleOven.Size = New System.Drawing.Size(101, 17)
        Me.chkSingleOven.TabIndex = 6
        Me.chkSingleOven.Text = "Single Oven @ "
        Me.chkSingleOven.UseVisualStyleBackColor = True
        '
        'chkHob
        '
        Me.chkHob.AutoSize = True
        Me.chkHob.Location = New System.Drawing.Point(6, 65)
        Me.chkHob.Name = "chkHob"
        Me.chkHob.Size = New System.Drawing.Size(66, 17)
        Me.chkHob.TabIndex = 5
        Me.chkHob.Text = "HOB @ "
        Me.chkHob.UseVisualStyleBackColor = True
        '
        'chkAmericanFridge
        '
        Me.chkAmericanFridge.AutoSize = True
        Me.chkAmericanFridge.Location = New System.Drawing.Point(6, 42)
        Me.chkAmericanFridge.Name = "chkAmericanFridge"
        Me.chkAmericanFridge.Size = New System.Drawing.Size(180, 17)
        Me.chkAmericanFridge.TabIndex = 4
        Me.chkAmericanFridge.Text = "American Style Fridge Freeze @ "
        Me.chkAmericanFridge.UseVisualStyleBackColor = True
        '
        'chkBasicFridge
        '
        Me.chkBasicFridge.AutoSize = True
        Me.chkBasicFridge.Location = New System.Drawing.Point(6, 19)
        Me.chkBasicFridge.Name = "chkBasicFridge"
        Me.chkBasicFridge.Size = New System.Drawing.Size(139, 17)
        Me.chkBasicFridge.TabIndex = 3
        Me.chkBasicFridge.Text = "Basic Fridge Freezer @ "
        Me.chkBasicFridge.UseVisualStyleBackColor = True
        '
        'grpInstallation
        '
        Me.grpInstallation.Controls.Add(Me.rdbNoInstallation)
        Me.grpInstallation.Controls.Add(Me.rdbYesInstallation)
        Me.grpInstallation.Location = New System.Drawing.Point(12, 462)
        Me.grpInstallation.Name = "grpInstallation"
        Me.grpInstallation.Size = New System.Drawing.Size(410, 56)
        Me.grpInstallation.TabIndex = 3
        Me.grpInstallation.TabStop = False
        Me.grpInstallation.Text = "Do you want Installation Service @  "
        '
        'rdbNoInstallation
        '
        Me.rdbNoInstallation.AutoSize = True
        Me.rdbNoInstallation.Checked = True
        Me.rdbNoInstallation.Location = New System.Drawing.Point(228, 24)
        Me.rdbNoInstallation.Name = "rdbNoInstallation"
        Me.rdbNoInstallation.Size = New System.Drawing.Size(39, 17)
        Me.rdbNoInstallation.TabIndex = 1
        Me.rdbNoInstallation.TabStop = True
        Me.rdbNoInstallation.Text = "No"
        Me.rdbNoInstallation.UseVisualStyleBackColor = True
        '
        'rdbYesInstallation
        '
        Me.rdbYesInstallation.AutoSize = True
        Me.rdbYesInstallation.Location = New System.Drawing.Point(6, 23)
        Me.rdbYesInstallation.Name = "rdbYesInstallation"
        Me.rdbYesInstallation.Size = New System.Drawing.Size(43, 17)
        Me.rdbYesInstallation.TabIndex = 0
        Me.rdbYesInstallation.TabStop = True
        Me.rdbYesInstallation.Text = "Yes"
        Me.rdbYesInstallation.UseVisualStyleBackColor = True
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnConfirmOrder.Location = New System.Drawing.Point(156, 552)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.Size = New System.Drawing.Size(267, 42)
        Me.btnConfirmOrder.TabIndex = 7
        Me.btnConfirmOrder.Text = "Confirm Purchase"
        Me.btnConfirmOrder.UseVisualStyleBackColor = False
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(10, 552)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(135, 42)
        Me.btnCancelOrder.TabIndex = 8
        Me.btnCancelOrder.Text = "Cancel"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'OrderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(448, 615)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnConfirmOrder)
        Me.Controls.Add(Me.grpInstallation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBillingDetails)
        Me.Controls.Add(Me.grpKitchenCounter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "OrderItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Summary"
        Me.grpKitchenCounter.ResumeLayout(False)
        Me.grpKitchenCounter.PerformLayout()
        Me.grpBillingDetails.ResumeLayout(False)
        Me.grpBillingDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpInstallation.ResumeLayout(False)
        Me.grpInstallation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpKitchenCounter As GroupBox
    Friend WithEvents grpBillingDetails As GroupBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKitchenLayoutTitle As Label
    Friend WithEvents rdbGranite As RadioButton
    Friend WithEvents rdbWoodBlock As RadioButton
    Friend WithEvents rdbLaminate As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkDishwasher As CheckBox
    Friend WithEvents chkDoubleOven As CheckBox
    Friend WithEvents chkSingleOven As CheckBox
    Friend WithEvents chkHob As CheckBox
    Friend WithEvents chkAmericanFridge As CheckBox
    Friend WithEvents chkBasicFridge As CheckBox
    Friend WithEvents grpInstallation As GroupBox
    Friend WithEvents rdbNoInstallation As RadioButton
    Friend WithEvents rdbYesInstallation As RadioButton
    Friend WithEvents btnConfirmOrder As Button
    Friend WithEvents lblAmenitiesShipping As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelOrder As Button
End Class
