<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customize
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSendDimens = New System.Windows.Forms.Button()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpKitchenLayouts = New System.Windows.Forms.GroupBox()
        Me.cboPriceRange = New System.Windows.Forms.ComboBox()
        Me.lvKitchenLayouts = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chWidth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLaminatePrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chWoodblock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGranitePrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.grpKitchenLayouts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Monotype Corsiva", 19.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(271, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(268, 31)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Personalize your Kitchen"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendDimens)
        Me.GroupBox1.Controls.Add(Me.txtWidth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLength)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(239, 112)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What are your Kitchen Dimensions?"
        '
        'btnSendDimens
        '
        Me.btnSendDimens.Location = New System.Drawing.Point(12, 75)
        Me.btnSendDimens.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSendDimens.Name = "btnSendDimens"
        Me.btnSendDimens.Size = New System.Drawing.Size(218, 24)
        Me.btnSendDimens.TabIndex = 4
        Me.btnSendDimens.Text = "Confirm"
        Me.btnSendDimens.UseVisualStyleBackColor = True
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(132, 43)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(1)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Width :"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(12, 43)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Length :"
        '
        'grpKitchenLayouts
        '
        Me.grpKitchenLayouts.Controls.Add(Me.lvKitchenLayouts)
        Me.grpKitchenLayouts.Controls.Add(Me.cboPriceRange)
        Me.grpKitchenLayouts.Enabled = False
        Me.grpKitchenLayouts.Location = New System.Drawing.Point(12, 186)
        Me.grpKitchenLayouts.Name = "grpKitchenLayouts"
        Me.grpKitchenLayouts.Size = New System.Drawing.Size(795, 210)
        Me.grpKitchenLayouts.TabIndex = 3
        Me.grpKitchenLayouts.TabStop = False
        Me.grpKitchenLayouts.Text = "Available Kitchen Layouts"
        '
        'cboPriceRange
        '
        Me.cboPriceRange.FormattingEnabled = True
        Me.cboPriceRange.Items.AddRange(New Object() {"All", "Below 5,000", "5,001 - 7,000", "7,001 - 9,000", "Above 9,000 "})
        Me.cboPriceRange.Location = New System.Drawing.Point(667, 14)
        Me.cboPriceRange.Name = "cboPriceRange"
        Me.cboPriceRange.Size = New System.Drawing.Size(121, 21)
        Me.cboPriceRange.TabIndex = 1
        Me.cboPriceRange.Text = "Price range"
        '
        'lvKitchenLayouts
        '
        Me.lvKitchenLayouts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chTitle, Me.chLength, Me.chWidth, Me.chLaminatePrice, Me.chWoodblock, Me.chGranitePrice})
        Me.lvKitchenLayouts.HideSelection = False
        Me.lvKitchenLayouts.Location = New System.Drawing.Point(7, 41)
        Me.lvKitchenLayouts.Name = "lvKitchenLayouts"
        Me.lvKitchenLayouts.Size = New System.Drawing.Size(781, 163)
        Me.lvKitchenLayouts.TabIndex = 2
        Me.lvKitchenLayouts.UseCompatibleStateImageBehavior = False
        Me.lvKitchenLayouts.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "ID"
        '
        'chTitle
        '
        Me.chTitle.Text = "Title"
        Me.chTitle.Width = 158
        '
        'chLength
        '
        Me.chLength.Text = "Length"
        Me.chLength.Width = 62
        '
        'chWidth
        '
        Me.chWidth.Text = "Width"
        '
        'chLaminatePrice
        '
        Me.chLaminatePrice.Text = "Laminate Countertop Price"
        Me.chLaminatePrice.Width = 145
        '
        'chWoodblock
        '
        Me.chWoodblock.Text = "Woodblock Countertop Price"
        Me.chWoodblock.Width = 153
        '
        'chGranitePrice
        '
        Me.chGranitePrice.Text = "Granite Countertop Price"
        Me.chGranitePrice.Width = 128
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(819, 408)
        Me.Controls.Add(Me.grpKitchenLayouts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Customize"
        Me.Text = "Personalize your Kitchen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpKitchenLayouts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSendDimens As Button
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpKitchenLayouts As GroupBox
    Friend WithEvents cboPriceRange As ComboBox
    Friend WithEvents lvKitchenLayouts As ListView
    Friend WithEvents chId As ColumnHeader
    Friend WithEvents chTitle As ColumnHeader
    Friend WithEvents chLength As ColumnHeader
    Friend WithEvents chWidth As ColumnHeader
    Friend WithEvents chLaminatePrice As ColumnHeader
    Friend WithEvents chWoodblock As ColumnHeader
    Friend WithEvents chGranitePrice As ColumnHeader
End Class
