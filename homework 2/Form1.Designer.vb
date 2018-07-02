<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFifteenPercentDiscount = New System.Windows.Forms.TextBox()
        Me.txtDiscountedPrice = New System.Windows.Forms.TextBox()
        Me.txtExtendedPrice = New System.Windows.Forms.TextBox()
        Me.lblDiscountedPrice = New System.Windows.Forms.Label()
        Me.lblFifteenPercentDiscount = New System.Windows.Forms.Label()
        Me.lblExtendedPrice = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDiscountedAmounts = New System.Windows.Forms.TextBox()
        Me.txtTotalDiscountsGiven = New System.Windows.Forms.TextBox()
        Me.txtTotalNumberOfBooks = New System.Windows.Forms.TextBox()
        Me.txtAverageDiscount = New System.Windows.Forms.TextBox()
        Me.lblAverageDiscount = New System.Windows.Forms.Label()
        Me.lblTotalDiscountedAmounts = New System.Windows.Forms.Label()
        Me.lblTotalDiscountsGiven = New System.Windows.Forms.Label()
        Me.lblTotalNumberOfBooks = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClearSale = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(450, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(18, 87)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(40, 17)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "&Price"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(18, 55)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(35, 17)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "&Title"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(18, 23)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(61, 17)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "&Quantity"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(90, 52)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(290, 22)
        Me.txtTitle.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(90, 84)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(95, 22)
        Me.txtPrice.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(90, 20)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(95, 22)
        Me.txtQuantity.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFifteenPercentDiscount)
        Me.GroupBox2.Controls.Add(Me.txtDiscountedPrice)
        Me.GroupBox2.Controls.Add(Me.txtExtendedPrice)
        Me.GroupBox2.Controls.Add(Me.lblDiscountedPrice)
        Me.GroupBox2.Controls.Add(Me.lblFifteenPercentDiscount)
        Me.GroupBox2.Controls.Add(Me.lblExtendedPrice)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 166)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(450, 116)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'txtFifteenPercentDiscount
        '
        Me.txtFifteenPercentDiscount.Location = New System.Drawing.Point(320, 52)
        Me.txtFifteenPercentDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFifteenPercentDiscount.Name = "txtFifteenPercentDiscount"
        Me.txtFifteenPercentDiscount.ReadOnly = True
        Me.txtFifteenPercentDiscount.Size = New System.Drawing.Size(100, 22)
        Me.txtFifteenPercentDiscount.TabIndex = 1
        Me.txtFifteenPercentDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountedPrice
        '
        Me.txtDiscountedPrice.Location = New System.Drawing.Point(320, 84)
        Me.txtDiscountedPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountedPrice.Name = "txtDiscountedPrice"
        Me.txtDiscountedPrice.ReadOnly = True
        Me.txtDiscountedPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscountedPrice.TabIndex = 3
        Me.txtDiscountedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExtendedPrice
        '
        Me.txtExtendedPrice.Location = New System.Drawing.Point(320, 20)
        Me.txtExtendedPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtendedPrice.Name = "txtExtendedPrice"
        Me.txtExtendedPrice.ReadOnly = True
        Me.txtExtendedPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtExtendedPrice.TabIndex = 0
        Me.txtExtendedPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscountedPrice
        '
        Me.lblDiscountedPrice.AutoSize = True
        Me.lblDiscountedPrice.Location = New System.Drawing.Point(180, 87)
        Me.lblDiscountedPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscountedPrice.Name = "lblDiscountedPrice"
        Me.lblDiscountedPrice.Size = New System.Drawing.Size(115, 17)
        Me.lblDiscountedPrice.TabIndex = 0
        Me.lblDiscountedPrice.Text = "Discounted Price"
        '
        'lblFifteenPercentDiscount
        '
        Me.lblFifteenPercentDiscount.AutoSize = True
        Me.lblFifteenPercentDiscount.Location = New System.Drawing.Point(180, 55)
        Me.lblFifteenPercentDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFifteenPercentDiscount.Name = "lblFifteenPercentDiscount"
        Me.lblFifteenPercentDiscount.Size = New System.Drawing.Size(95, 17)
        Me.lblFifteenPercentDiscount.TabIndex = 5
        Me.lblFifteenPercentDiscount.Text = "15% Discount"
        '
        'lblExtendedPrice
        '
        Me.lblExtendedPrice.AutoSize = True
        Me.lblExtendedPrice.Location = New System.Drawing.Point(180, 23)
        Me.lblExtendedPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtendedPrice.Name = "lblExtendedPrice"
        Me.lblExtendedPrice.Size = New System.Drawing.Size(103, 17)
        Me.lblExtendedPrice.TabIndex = 4
        Me.lblExtendedPrice.Text = "Extended Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotalDiscountedAmounts)
        Me.GroupBox3.Controls.Add(Me.txtTotalDiscountsGiven)
        Me.GroupBox3.Controls.Add(Me.txtTotalNumberOfBooks)
        Me.GroupBox3.Controls.Add(Me.txtAverageDiscount)
        Me.GroupBox3.Controls.Add(Me.lblAverageDiscount)
        Me.GroupBox3.Controls.Add(Me.lblTotalDiscountedAmounts)
        Me.GroupBox3.Controls.Add(Me.lblTotalDiscountsGiven)
        Me.GroupBox3.Controls.Add(Me.lblTotalNumberOfBooks)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 292)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(450, 170)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'txtTotalDiscountedAmounts
        '
        Me.txtTotalDiscountedAmounts.Location = New System.Drawing.Point(320, 84)
        Me.txtTotalDiscountedAmounts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDiscountedAmounts.Name = "txtTotalDiscountedAmounts"
        Me.txtTotalDiscountedAmounts.ReadOnly = True
        Me.txtTotalDiscountedAmounts.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalDiscountedAmounts.TabIndex = 2
        Me.txtTotalDiscountedAmounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDiscountsGiven
        '
        Me.txtTotalDiscountsGiven.Location = New System.Drawing.Point(320, 52)
        Me.txtTotalDiscountsGiven.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDiscountsGiven.Name = "txtTotalDiscountsGiven"
        Me.txtTotalDiscountsGiven.ReadOnly = True
        Me.txtTotalDiscountsGiven.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalDiscountsGiven.TabIndex = 1
        Me.txtTotalDiscountsGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalNumberOfBooks
        '
        Me.txtTotalNumberOfBooks.Location = New System.Drawing.Point(320, 20)
        Me.txtTotalNumberOfBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalNumberOfBooks.Name = "txtTotalNumberOfBooks"
        Me.txtTotalNumberOfBooks.ReadOnly = True
        Me.txtTotalNumberOfBooks.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalNumberOfBooks.TabIndex = 0
        Me.txtTotalNumberOfBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAverageDiscount
        '
        Me.txtAverageDiscount.Location = New System.Drawing.Point(320, 116)
        Me.txtAverageDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAverageDiscount.Name = "txtAverageDiscount"
        Me.txtAverageDiscount.ReadOnly = True
        Me.txtAverageDiscount.Size = New System.Drawing.Size(100, 22)
        Me.txtAverageDiscount.TabIndex = 3
        Me.txtAverageDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAverageDiscount
        '
        Me.lblAverageDiscount.AutoSize = True
        Me.lblAverageDiscount.Location = New System.Drawing.Point(130, 119)
        Me.lblAverageDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAverageDiscount.Name = "lblAverageDiscount"
        Me.lblAverageDiscount.Size = New System.Drawing.Size(120, 17)
        Me.lblAverageDiscount.TabIndex = 7
        Me.lblAverageDiscount.Text = "Average Discount"
        '
        'lblTotalDiscountedAmounts
        '
        Me.lblTotalDiscountedAmounts.AutoSize = True
        Me.lblTotalDiscountedAmounts.Location = New System.Drawing.Point(130, 87)
        Me.lblTotalDiscountedAmounts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDiscountedAmounts.Name = "lblTotalDiscountedAmounts"
        Me.lblTotalDiscountedAmounts.Size = New System.Drawing.Size(174, 17)
        Me.lblTotalDiscountedAmounts.TabIndex = 6
        Me.lblTotalDiscountedAmounts.Text = "Total Discounted Amounts"
        '
        'lblTotalDiscountsGiven
        '
        Me.lblTotalDiscountsGiven.AutoSize = True
        Me.lblTotalDiscountsGiven.Location = New System.Drawing.Point(130, 55)
        Me.lblTotalDiscountsGiven.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDiscountsGiven.Name = "lblTotalDiscountsGiven"
        Me.lblTotalDiscountsGiven.Size = New System.Drawing.Size(147, 17)
        Me.lblTotalDiscountsGiven.TabIndex = 5
        Me.lblTotalDiscountsGiven.Text = "Total Discounts Given"
        '
        'lblTotalNumberOfBooks
        '
        Me.lblTotalNumberOfBooks.AutoSize = True
        Me.lblTotalNumberOfBooks.Location = New System.Drawing.Point(130, 23)
        Me.lblTotalNumberOfBooks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalNumberOfBooks.Name = "lblTotalNumberOfBooks"
        Me.lblTotalNumberOfBooks.Size = New System.Drawing.Size(153, 17)
        Me.lblTotalNumberOfBooks.TabIndex = 4
        Me.lblTotalNumberOfBooks.Text = "Total Number of Books"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(62, 505)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 30)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculate sale information.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClearSale
        '
        Me.btnClearSale.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearSale.Location = New System.Drawing.Point(224, 505)
        Me.btnClearSale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearSale.Name = "btnClearSale"
        Me.btnClearSale.Size = New System.Drawing.Size(100, 30)
        Me.btnClearSale.TabIndex = 2
        Me.btnClearSale.Text = "Clear &Sale"
        Me.btnClearSale.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 505)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(208, 7)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 27)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Book Sales"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClearSale
        Me.ClientSize = New System.Drawing.Size(540, 546)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearSale)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClearSale As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtFifteenPercentDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountedPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtExtendedPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountedPrice As System.Windows.Forms.Label
    Friend WithEvents lblFifteenPercentDiscount As System.Windows.Forms.Label
    Friend WithEvents lblExtendedPrice As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiscountedAmounts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDiscountsGiven As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNumberOfBooks As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblAverageDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiscountedAmounts As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiscountsGiven As System.Windows.Forms.Label
    Friend WithEvents lblTotalNumberOfBooks As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
