Public Class Form1


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the current form and application
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '
        Dim intQuantity As Integer = 0
        Dim intTotalNumberOfBooks As Integer = 0
        Dim intNumberOfSales = 0
        Dim strTitle As String = ""
        Dim dblPrice As Double = 0.0
        Dim dblExtendedPrice As Double = 0.0
        Dim dblFifteenPercentDiscount As Double = 0.0
        Dim dblDiscountedPrice As Double = 0.0
        Dim dblTotalDiscountsGiven As Double = 0.0
        Dim dblTotalDiscountedAmounts As Double = 0.0
        Dim dblAverageDiscount As Double = 0.0

        '
        strTitle = txtTitle.Text

        '
        intQuantity = CInt(txtQuantity.Text)
        dblPrice = CDbl(txtPrice.Text)

        '
        dblExtendedPrice = dblPrice * intQuantity
        dblFifteenPercentDiscount = dblExtendedPrice * 0.15
        dblDiscountedPrice = dblExtendedPrice - dblFifteenPercentDiscount
        intTotalNumberOfBooks = intTotalNumberOfBooks + intQuantity
        dblTotalDiscountsGiven = dblTotalDiscountsGiven + dblFifteenPercentDiscount
        dblTotalDiscountedAmounts = dblTotalDiscountedAmounts + dblDiscountedPrice
        intNumberOfSales = intNumberOfSales + 1
        dblAverageDiscount = dblTotalDiscountsGiven / intNumberOfSales

        '
        txtExtendedPrice.Text = dblExtendedPrice
        txtFifteenPercentDiscount.Text = dblFifteenPercentDiscount
        txtDiscountedPrice.Text = dblDiscountedPrice
        txtTotalNumberOfBooks.Text = intTotalNumberOfBooks
        txtTotalDiscountsGiven.Text = dblTotalDiscountsGiven
        txtTotalDiscountedAmounts.Text = dblTotalDiscountedAmounts
        txtAverageDiscount.Text = dblAverageDiscount
    End Sub

    Private Sub btnClearSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSale.Click

    End Sub
End Class
