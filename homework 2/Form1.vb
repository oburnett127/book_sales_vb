'Course: CMSC2413 Visual Programming, Spring 2011
'Assignment: Programming Assignment 2
'Program: Form1.vb
'Author: Owen Burnett
'Description: Calculates individual sales and discounts.  Calculates the 
'total number of books solde, the total number of discounts given, the 
'total discounted amount, and the average discount per sale.  Contains 
'error handling, so that missing or nonnumeric data will not cause a run-time error.

Public Class Form1

    Dim intNumberOfSales As Integer = 0
    Dim intTotalNumberOfBooks As Integer = 0
    Dim dblTotalDiscountsGiven As Double = 0.0
    Dim dblTotalDiscountedAmounts As Double = 0.0
    Dim dblAverageDiscount As Double = 0.0

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the current form and application
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intQuantity As Integer = 0
        Dim dblPrice As Double = 0.0
        Dim dblExtendedPrice As Double = 0.0
        Dim dblFifteenPercentDiscount As Double = 0.0
        Dim dblDiscountedPrice As Double = 0.0

        Const dblDISCOUNT_RATE As Double = 0.15

        Try
            'Convert quantity to an integer
            intQuantity = CInt(txtQuantity.Text)
            Try
                'Convert price to a double, calculate individual sale and summary information
                dblPrice = CDbl(txtPrice.Text)
                dblExtendedPrice = dblPrice * intQuantity
                dblFifteenPercentDiscount = dblExtendedPrice * dblDISCOUNT_RATE
                dblDiscountedPrice = dblExtendedPrice - dblFifteenPercentDiscount
                intTotalNumberOfBooks = intTotalNumberOfBooks + intQuantity
                dblTotalDiscountsGiven = dblTotalDiscountsGiven + dblFifteenPercentDiscount
                dblTotalDiscountedAmounts = dblTotalDiscountedAmounts + dblDiscountedPrice
                intNumberOfSales = intNumberOfSales + 1
                dblAverageDiscount = dblTotalDiscountsGiven / intNumberOfSales

                'Convert calculated individual sale and summary data to String data type and
                'display results in textboxes
                txtExtendedPrice.Text = dblExtendedPrice.ToString("c")
                txtFifteenPercentDiscount.Text = dblFifteenPercentDiscount.ToString("c")
                txtDiscountedPrice.Text = dblDiscountedPrice.ToString("c")
                txtTotalNumberOfBooks.Text = intTotalNumberOfBooks
                txtTotalDiscountsGiven.Text = dblTotalDiscountsGiven.ToString("c")
                txtTotalDiscountedAmounts.Text = dblTotalDiscountedAmounts.ToString("c")
                txtAverageDiscount.Text = dblAverageDiscount.ToString("c")
            Catch
                'Display error message explaining error to user, set focus to txtPrice, 
                'and select text in txtPrice
                MessageBox.Show("Quantity must be numeric", "Data Entry Error", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPrice.Focus()
                txtPrice.SelectAll()
            End Try
        Catch
            'Display error message explaining error to user, set focus to txtQuantity, 
            'and select text in txtQuantity
            MessageBox.Show("Quantity must be numeric", "Data Entry Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            txtQuantity.SelectAll()
        End Try
    End Sub

    Private Sub btnClearSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSale.Click
        ' Clear text boxes that apply to individual sale
        txtQuantity.Clear()
        txtTitle.Clear()
        txtPrice.Clear()
        txtExtendedPrice.Clear()
        txtFifteenPercentDiscount.Clear()
        txtDiscountedPrice.Clear()

        ' Set focus to txtQuantity for user convenience
        txtQuantity.Focus()
    End Sub
End Class
