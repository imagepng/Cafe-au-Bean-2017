Public Class Form1

    ' The variables created for the Cappuccino coffee type
    Dim cappuccinoDailyTotal, cappuccinoTotalDouble, cappuccinoQuantityDouble As Double

    ' The variables created for the Espresso coffee type
    Dim espressoDailyTotal, espressoQuantityDouble, espressoTotalDouble As Double

    ' The variables created for the Latte coffe type
    Dim latteDailyTotal, latteQuantityDouble, latteTotalDouble As Double

    ' The variables created for the Iced coffee type
    Dim icedDailyTotal, icedQuantityDouble, icedTotalDouble As Double

    ' The variables created for both calculating and storing the different tax values
    Dim taxTotalDouble, taxTotalDoubleRound, costBeforeTaxDouble As Double

    ' Variable which holds the total quantity of coffees sold throughout the day
    Dim totalCoffeeSalesQuantity As Double

    ' Variable which holds the total money spent on coffees throughout the day
    Dim dailyGrandTotal As Double


    ' Variables for the prices for each coffee type, and the cost of takeaway/tax
    Dim cappuccinoPrice As Decimal = 3
    Dim espressoPrice As Decimal = 2.25
    Dim lattePrice As Decimal = 2.5
    Dim icedPrice As Decimal = 2.5
    Dim taxRate As Decimal = 0.05


    ' Functions for setting the variables to their required value, when any number of coffees of that type are bought
    Private Function setCappuccinoValues()
        cappuccinoQuantityDouble = cappuccinoQuantity.Value
        cappuccinoTotalDouble = cappuccinoQuantityDouble * cappuccinoPrice
        cappuccinoTotal.Text = ("$" & cappuccinoTotalDouble)
        cappuccinoDailyTotal = cappuccinoDailyTotal + cappuccinoQuantityDouble
    End Function


    Private Function setEspressoValues()
        espressoQuantityDouble = espressoQuantity.Value
        espressoTotalDouble = espressoQuantityDouble * espressoPrice
        espressoTotal.Text = ("$" & espressoTotalDouble)
        espressoDailyTotal = espressoDailyTotal + espressoQuantityDouble
    End Function

    Private Function setLatteValues()
        latteQuantityDouble = latteQuantity.Value
        latteTotalDouble = latteQuantityDouble * lattePrice
        latteTotal.Text = ("$" & latteTotalDouble)
        latteDailyTotal = latteDailyTotal + latteQuantityDouble
    End Function

    Private Function setIcedValues()
        icedQuantityDouble = icedQuantity.Value
        icedTotalDouble = icedQuantityDouble * icedPrice
        icedTotal.Text = ("$" & icedTotalDouble)
        icedDailyTotal = icedDailyTotal + icedQuantityDouble
    End Function


    ' functions for setting the variables to zero, when no coffees of that type are bought
    Private Function setCappuccinoValuesZero()
        cappuccinoTotal.Text = ("$0")
        cappuccinoDailyTotal = cappuccinoDailyTotal + 0
        cappuccinoTotalDouble = 0
        cappuccinoQuantityDouble = 0
    End Function

    Private Function setEspressoValuesZero()
        espressoTotal.Text = ("$0")
        espressoDailyTotal = espressoDailyTotal + 0
        espressoTotalDouble = 0
        espressoQuantityDouble = 0
    End Function

    Private Function SetLatteValuesZero()
        latteTotal.Text = ("$0")
        latteDailyTotal = latteDailyTotal + 0
        latteTotalDouble = 0
        latteQuantityDouble = 0
    End Function

    Private Function setIcedValuesZero()
        icedTotal.Text = ("$0")
        icedDailyTotal = icedDailyTotal + 0
        icedTotalDouble = 0
        icedQuantityDouble = 0
    End Function

    ' This function calculates the total tax to be payed
    Private Function CalculateTax()
        costBeforeTaxDouble = (cappuccinoTotalDouble + espressoTotalDouble + latteTotalDouble + icedTotalDouble)
        costBeforeTax.Text = ("$" & costBeforeTaxDouble)
    End Function

    ' This is for checking if the customer wants the coffee as takeaway, and if so, they are charged a 5% tax on top of the price of the coffees
    ' After calculating 5% of the total cost, the program then rounds the cost of tax to two decimal points
    ' The cost of tax is then displayed in a label
    ' If the customer has not chosen to takeaway, then they are charged $0 in tax
    Private Function checkTakeaway()
        If takeawayCheckbox.Checked = True Then
            taxTotalDouble = 0.05 * costBeforeTaxDouble
            taxTotalDoubleRound = Decimal.Round(taxTotalDouble, 2, MidpointRounding.AwayFromZero)
            TaxTotal.Text = ("$" & taxTotalDoubleRound)
        Else
            TaxTotal.Text = ("$0")
            taxTotalDouble = 0
        End If
    End Function

    ' This calculates all the totals, such as grand total, daily grand total and total coffee sales
    Private Function calculateTotals()
        grandTotal.Text = ("$" & costBeforeTaxDouble + taxTotalDoubleRound)

        dailyGrandTotal = dailyGrandTotal + (costBeforeTaxDouble + taxTotalDoubleRound)

        If cappuccinoQuantity.Value >= 1 Or espressoQuantity.Value >= 1 Or latteQuantity.Value >= 1 Or icedQuantity.Value >= 1 Then
            totalCoffeeSalesQuantity = totalCoffeeSalesQuantity + (cappuccinoQuantityDouble + espressoQuantityDouble + latteQuantityDouble + icedQuantityDouble)
        Else
            totalCoffeeSalesQuantity = totalCoffeeSalesQuantity
        End If
    End Function


    ' This resets all variables back to zero, except the daily totals
    Private Function resetOrderFunc()
        cappuccinoDailyTotal = 0
        cappuccinoTotalDouble = 0
        cappuccinoQuantityDouble = 0
        cappuccinoQuantity.Value = 0


        espressoDailyTotal = 0
        espressoTotalDouble = 0
        espressoQuantityDouble = 0
        espressoQuantity.Value = 0

        latteDailyTotal = 0
        latteTotalDouble = 0
        latteQuantityDouble = 0
        latteQuantity.Value = 0

        icedDailyTotal = 0
        icedTotalDouble = 0
        icedQuantityDouble = 0
        icedQuantity.Value = 0

        costBeforeTax.Text = ("$0")
        costBeforeTaxDouble = 0

        takeawayCheckbox.CheckState = False
        TaxTotal.Text = ("$0")
        taxTotalDouble = 0
        taxTotalDoubleRound = 0

        dailyGrandTotal = 0
        grandTotal.Text = ("$0")


    End Function

    ' This section is for the Daily quantites button, where when it is pressed, a message box pops up showing the total quantity sold for each coffee type, as well as the total quantity sold and total money earnt in sales
    Private Function checkDailyTotals()
        MessageBox.Show("You have sold " & cappuccinoDailyTotal & " cappuccinos today" &
                         vbCrLf + "You have sold " & espressoDailyTotal & " espressos today" &
                         vbCrLf + "You have sold " & latteDailyTotal & " lattes today" &
                         vbCrLf + "You have sold " & icedDailyTotal & " iced coffees today" &
                         vbCrLf &
                         vbCrLf + "You have sold " & totalCoffeeSalesQuantity & " coffees total, adding to a total of $" & dailyGrandTotal & " in sales", "Daily Totals")

    End Function

    Private Function resetDailyTotals()
        cappuccinoDailyTotal = 0
        espressoDailyTotal = 0
        latteDailyTotal = 0
        icedDailyTotal = 0
        totalCoffeeSalesQuantity = 0
        dailyGrandTotal = 0
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    ' The bulk of the code is completed here, where once the 'calculateCosts' button is pressed, all costs and numbers are calculated
    Private Sub CalculateCosts_Click(sender As Object, e As EventArgs) Handles CalculateCosts.Click


        ' This is for caluclating the cost of the cappuccinos as well as the quantity of cappuccinos purchased
        ' If the customer has ordered at least one coffee, then the quantity is multiplied by $3, then stored in a variable. It is then shown in the GUI through a label
        ' If the customer has orderd no Cappuccinos, then the cost of the cappuccinos is set to $0
        ' Each of the following four  IF statements (CappuccinoQuantity, EspressoQuantity, LatteQuantity, and IcedQuantity) all do the same thing, but for each different coffee type
        If cappuccinoQuantity.Value >= 1 Then
            setCappuccinoValues()
        Else
            setCappuccinoValuesZero()
        End If


        If espressoQuantity.Value >= 1 Then
            setEspressoValues()
        Else
            setEspressoValuesZero()
        End If


        If latteQuantity.Value >= 1 Then
            setLatteValues()
        Else
            SetLatteValuesZero()
        End If


        If icedQuantity.Value >= 1 Then
            setIcedValues()
        Else
            setIcedValuesZero()
        End If

        ' This is to calculate the total cost before tax, which is then displayed in a label
        costBeforeTaxDouble = ("$" & (cappuccinoTotalDouble + espressoTotalDouble + latteTotalDouble + icedTotalDouble))
        costBeforeTax.Text = ("$" & costBeforeTaxDouble)


        checkTakeaway()

        ' This is to calculate the total cost including tax, which is done simply by adding the rounded tax total to the before-tax total
        ' The daily grand total is then updated with this information, as well as the total coffee sales, which is updated with the total quantity of coffees sold
        calculateTotals()


    End Sub

    Private Sub TotalQuantities_Click(sender As Object, e As EventArgs) Handles TotalQuantities.Click
        checkDailyTotals()

    End Sub

    Private Sub ResetOrder_Click(sender As Object, e As EventArgs) Handles ResetOrder.Click
        resetOrderFunc()
    End Sub


    Private Sub resetDailyTotalsButton_Click(sender As Object, e As EventArgs) Handles resetDailyTotalsButton.Click
        resetDailyTotals()
    End Sub

    Private Sub TaxMultiplier_Click(sender As Object, e As EventArgs) Handles TaxMultiplier.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
