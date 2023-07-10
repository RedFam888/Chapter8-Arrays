Imports System.ComponentModel
Imports System.Data.Common
Imports System.Diagnostics.CodeAnalysis
Imports System.Net.Security
Imports System.Security.Cryptography.Pkcs
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form1

    Private Sub btnDisplayArray_Click(sender As Object, e As EventArgs) Handles btnDisplayArray.Click

        'Create an app that creates an array for "Sales" and displays each element of the Array to the user

        Dim sales(3) As Integer
        Dim results As String = ""

        sales(0) = 25500
        sales(1) = 46750
        sales(2) = 21000
        sales(3) = 35500

        For Each element As Integer In sales
            results += element.ToString & vbCrLf
            txtDisplayArrayResults.Text = results
        Next element
    End Sub

    Private Sub btnStoring1_Click(sender As Object, e As EventArgs) Handles btnStoring1.Click

        'Storing Data in A One-Dimensional Array Example 1 from the Book page 345

        Dim city(5) As String
        Dim results As String = ""

        city(0) = "Nashville"
        city(1) = "Raleigh"
        city(2) = "Portland"
        city(3) = "Visalia"
        city(4) = "New Orleans"
        city(5) = "Bunnlevel"

        For Each element As String In city
            results += element & vbCrLf
            txtStroingDataResults.Text = results
        Next element
    End Sub

    Private Sub btnStoring2_Click(sender As Object, e As EventArgs) Handles btnStoring2.Click

        'Storing Data in A One-Dimensional Array Example 2 from the Book page 345

        Dim numbers(4) As Integer

        For x As Integer = 1 To 5
            numbers(x - 1) = x ^ 2
            txtStroingDataResults.Text += numbers(x - 1).ToString & vbCrLf
        Next x
    End Sub

    Private Sub btnStoring3_Click(sender As Object, e As EventArgs) Handles btnStoring3.Click

        'Storing Data in A One-Dimensional Array Example 3 from the Book page 345

        Dim numbers(4) As Integer
        Dim subScript As Integer

        Do While subScript < 5
            numbers(subScript) = 100
            txtStroingDataResults.Text += numbers(subScript).ToString & vbCrLf
            subScript += 1
        Loop
    End Sub

    Private Sub btnStoring4_Click(sender As Object, e As EventArgs) Handles btnStoring4.Click

        'Storing Data in A One-Dimensional Array Example 4 from the Book page 345

        Dim price() As Double = {45.25, 56.99, 33.75}

        For x As Integer = 0 To price.GetUpperBound(0)
            price(x) *= 1.25
            txtStroingDataResults.Text += price(x).ToString("c2") & vbCrLf
        Next
    End Sub

    Private Sub btnStoring5_Click(sender As Object, e As EventArgs) Handles btnStoring5.Click

        'Storing Data in A One-Dimensional Array Example 5 from the Book page 345

        Dim rates(10) As Double
        Static count As Integer = 0

        If count < rates.GetUpperBound(0) Then
            Double.TryParse(txtStoringDataInput.Text, rates(count))
            txtStroingDataResults.Text += rates(count).ToString & vbCrLf
            count += 1
        Else
            MessageBox.Show("No more room in the array")
        End If
    End Sub

    Private Sub btnLengthProperty_Click(sender As Object, e As EventArgs) Handles btnLengthProperty.Click

        'An array has a property known as "LENGTH" this will show the number of elements that an array can store as an Integer

        'Syntax:  ( arrayName.Length )

        Dim Names(3) As String
        Dim numElements As Integer

        numElements = Names.Length

        txtNumberOfElementsResults.Text = numElements.ToString
    End Sub

    Private Sub btnUpperBoundProperty_Click(sender As Object, e As EventArgs) Handles btnUpperBoundProperty.Click

        'An array also has a property known as "GETUPPERBOUND" this will show the array's highest subscript as an Integer

        'Syntax:  ( arrayName.GetUpperBound )

        Dim Names(3) As String
        Dim numElements As Integer

        numElements = Names.GetUpperBound(0)

        txtNumberOfElementsResults.Text = numElements.ToString
    End Sub

    Private Sub btnYouDoIt1_Click(sender As Object, e As EventArgs) Handles btnYouDoIt1.Click

        'Code a program that creates an Array set to "2, 4, 6 , 8 , 10, 12" Have the procedure then display the array's LENGTH property in one label and GETUPPERBOUND property in another label

        Dim numbers() As Integer = {2, 4, 6, 8, 10, 12}
        Dim length As Integer = numbers.Length
        Dim upperBound As Integer = numbers.GetUpperBound(0)

        lblDoIt1Results.Text = length
        lblDoIt1Results2.Text = upperBound
    End Sub

    Private Sub btnUpperBound_Click(sender As Object, e As EventArgs) Handles btnUpperBound.Click

        'To Traverse(Look at Each Element) you use a loop. You can either use the "GETUPPERBOUND" or the "Length - 1" This method will use a For..Next Statement and the "UpperBound Method"

        Dim Names() As String = {"Mason", "Veronica", "Gracie", "Owen", "Barry"}
        Dim highSub As Integer = Names.GetUpperBound(0)

        For nameSub As Integer = 0 To highSub
            txtTraverseResults.Text += Names(nameSub) & vbCrLf
        Next nameSub
    End Sub

    Private Sub btnLengthMethod_Click(sender As Object, e As EventArgs) Handles btnLengthMethod.Click

        'To Traverse(Look at Each Element) you use a loop. You can either use the "GETUPPERBOUND" or the "Length - 1" This method will use a Do Loop Statement and the "Length - 1 Method"

        Dim Names() As String = {"Mason", "Veronica", "Gracie", "Owen", "Barry"}
        Dim highSub As Integer = Names.Length - 1
        Dim nameSub As Integer

        While nameSub <= highSub
            txtTraverseResults.Text += Names(nameSub) & vbCrLf
            nameSub += 1
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add Names to the Harry Pooter List Box-- The reason this is far btter than just adding the names to the list box is that now the array PotterNames can be expanded and the listbox automatically expands with it or the array PooterNames can be used 
        'elsewhere within the code outside of the listbox.

        Dim potterNames() As String = {"Harry", "Ron", "Hermione", "Draco", "Dumbeldore"}
        Dim highSub As Integer = potterNames.GetUpperBound(0)
        Dim potterSub As Integer

        While potterSub <= highSub
            lstHarryPotter.Items.Add(potterNames(potterSub))
            potterSub += 1
        End While

        lstHarryPotter.SelectedIndex = 0

        'Another way to code this into a listbox would be to use a FOR EACH... NEXT statement. This is very valuable when your code doesn't need to change the variables but only read them.

        'For Each element as String In potterNames
        'lstHarrypotter.Items.Add(element)
        'Next element

        'Waterson Stock Average---- ListBox for Prices
        'Waterson Highest Stock---- ListBox for Prices
        'Excercise 1 List Boxes

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}

        For Each element As Double In stockPrices
            lstWatersonStock.Items.Add(element.ToString("C2"))
            lstHighStock.Items.Add(element.ToString("c2"))
            lstExcercise1.Items.Add(element.ToString("c2"))
        Next element

        'Add Presidents to ListBox President App

        Dim presidents() As String = {"George Washington", "George Bush", "Bill Clinton", "Geroge W. Bush", "Barack Obama", "Donald J. Trump"}

        For Each element As String In presidents
            lstPresidents.Items.Add(element)
        Next element

        'Add Candy to ListBox for Warren School App

        Dim candy() As String = {"Choco Bar", "Peanuts", "Kit Kat", "PB Cups", "Take 5"}

        For Each element As String In candy
            lstCandy.Items.Add(element)
        Next element

        'Add PayCodes to ListBox for Excercise 3

        Dim paycodes() As String = {"P23", "P56", "P45", "P68", "P96"}

        For Each element As String In paycodes
            lstPayCodes.Items.Add(element)
        Next element

        'Selected Index for Juarez Application

        lstJuarez.SelectedIndex = 0

        'Selected Index for computers ListBox

        lstComputers.SelectedIndex = 0

        'Add Items to Listboxes ID and COLOR for Excercise 18

        Dim itemColor() As String = {"Blue", "Red", "Blue", "Red", "White", "Red", "Blue", "Black", "White", "Blue"}
        Dim itemId() As String = {"101", "102", "103", "104", "105", "106", "107", "108", "109", "110"}

        For Each element As String In itemId
            lstItemID.Items.Add(element)
        Next element
        lstItemID.SelectedIndex = 0

        For Each element As String In itemColor
            lstItemColor.Items.Add(element)
        Next element
        lstItemColor.SelectedIndex = 0
    End Sub

    Private Sub lstHarryPotter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHarryPotter.SelectedIndexChanged

        'Displays Slected Item From Listbox into Label for User

        lblHarryPotterResults.Text = lstHarryPotter.SelectedItem
    End Sub

    Private Sub btnYouDoIt2_Click(sender As Object, e As EventArgs) Handles btnYouDoIt2.Click

        'Create an app that declares an array of names and then uses a different looping procedure to display the contents of the array to listboxes


        Dim familyNames() As String = {"Mason", "Veronica", "Gracie", "Owen"}
        Dim fnHighSub As Integer = familyNames.GetUpperBound(0)
        Dim fnSub As Integer

        For nameSub As Integer = 0 To fnHighSub
            lstForNext.Items.Add(familyNames(nameSub))
        Next

        For Each element As String In familyNames
            lstForEach.Items.Add(element)
        Next element

        While fnSub <= fnHighSub
            lstDoLoop.Items.Add(familyNames(fnSub))
            fnSub += 1
        End While
    End Sub

    Private Sub btnWatersonAverage_Click(sender As Object, e As EventArgs) Handles btnWatersonAverage.Click

        'Create an app that will take in the total of the stock prices for Waterson company and find the average using the "FOR EACH...NEXT" statement

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}
        Dim total As Double

        For Each element As Double In stockPrices
            total += element
        Next element

        Dim average As Double

        average = total / stockPrices.Length

        lblAveragePriceResults.Text = average.ToString("c2")
    End Sub

    Private Sub btnWatersonAverage2_Click(sender As Object, e As EventArgs) Handles btnWatersonAverage2.Click

        'Create an app that will take in the total of the stock prices for Waterson company and find the average using the "FOR...NEXT" statement

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}
        Dim total As Double
        Dim highSub As Integer = stockPrices.Length - 1

        For stockSub As Integer = 0 To highSub
            total += stockPrices(stockSub)
        Next stockSub

        Dim average As Double

        average = total / stockPrices.Length

        lblAveragePriceResults.Text = average.ToString("c2")
    End Sub

    Private Sub btnWatersonAverage3_Click(sender As Object, e As EventArgs) Handles btnWatersonAverage3.Click

        'Create an app that will take in the total of the stock prices for Waterson company and find the average using a "DO LOOP"

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}
        Dim total As Double
        Dim highSub As Integer = stockPrices.GetUpperBound(0)
        Dim stockSub As Integer

        While stockSub <= highSub
            total += stockPrices(stockSub)
            stockSub += 1
        End While

        Dim average As Double

        average = total / stockPrices.Length

        lblAveragePriceResults.Text = average.ToString("c2")
    End Sub

    Private Sub btnYouCanDoIt3_Click(sender As Object, e As EventArgs) Handles btnYouCanDoIt3.Click

        'Create and app that creates an array of any 5 numbers then finds the average using a "FOR EACH...NEXT", "FOR...NEXT", and a "DO LOOP"

        Dim numbers() As Integer = {867, 987, 345, 937, 732}
        Dim highSub As Integer = numbers.GetUpperBound(0)
        Dim numSub As Integer

        For Each element As Integer In numbers
            Dim total As Integer
            total += element
            Dim average As Integer
            average = total / numbers.Length
            lblDoit3one.Text = average.ToString
        Next element

        For intSub As Integer = 0 To highSub
            Dim total As Integer
            total += numbers(intSub)
            Dim average As Integer
            average = total / numbers.Length
            lblDoit3two.Text = average.ToString
        Next intSub

        Do While numSub <= highSub
            Dim total As Integer
            total += numbers(numSub)
            Dim average As Integer
            average = total / numbers.Length
            lbldoIt3three.Text = average.ToString
            numSub += 1
        Loop
    End Sub

    Private Sub btnHighStock_Click(sender As Object, e As EventArgs) Handles btnHighStock.Click

        'Create an App that will find the Highest Stock Value for the Waterson Stock from the past 10 days and how many days it was at that value

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}
        Dim highestStock As Double = stockPrices(0)
        Dim days As Integer = 1

        For Each element As Double In stockPrices
            If highestStock = element Then
                days += 1
            ElseIf highestStock < element Then
                highestStock = element
                days = 1
            End If
        Next element

        'EXCERCISE 6 is a slight modification to this app instead of displaying the HIGHEST Stock you will now display the LOWEST stock and the days it was at that price

        Dim lowestStock As Double = stockPrices(0)
        Dim days2 As Integer = 1

        For Each element As Double In stockPrices
            If lowestStock = element Then
                days2 = +1
            ElseIf lowestStock > element Then
                lowestStock = element
                days2 = 1
            End If
        Next element

        lblHighStockResults.Text = highestStock.ToString("c2") & vbCrLf & lowestStock.ToString("c2")
        lblDaysResults.Text = days.ToString & vbCrLf & days2.ToString
    End Sub

    Private Sub btnDoIt4_Click(sender As Object, e As EventArgs) Handles btnDoIt4.Click

        'Create an app that creates an array of numbers then find the "LOWEST" value in the array and display the results

        Dim numbers(4) As Integer
        Dim highSub As Integer = numbers.GetUpperBound(0)
        Dim generator As New Random

        For intSub As Integer = 0 To highSub
            numbers(intSub) = generator.Next(1, 51)
        Next intSub

        Dim lowestNumber As Integer = numbers(0)
        Dim count As Integer = 1

        For Each element As Integer In numbers
            If lowestNumber = element Then
                count += 1
            ElseIf lowestNumber > element Then
                lowestNumber = element
                count = 1
            End If
        Next element

        lblDoIt4Results.Text = "The lowest number is " & lowestNumber.ToString & vbCrLf & "The number of times" & vbCrLf & "it appears is " & count.ToString
    End Sub

    Private Sub btnSortExample1_Click(sender As Object, e As EventArgs) Handles btnSortExample1.Click

        'Arrays have sorting Methods. One is to Sort in Ascending Order and the other is to Sort in Reverse order. This means to get a descending order you must first sort in Ascending and then in Reverse Example 3 will show this

        'Syntax:   ( Array.Sort(arrayName) )--- Sorts in Ascending Order
        'Syntax:   ( Array.Reverse(arrayName)  )--Sorts in Reverse Order

        Dim scores() As Integer = {78, 90, 75, 83}
        Dim results As String = ""
        Array.Sort(scores)

        For Each element As Integer In scores
            results += element.ToString & " "
            lblSortResults.Text = "The array was sorted from" & vbCrLf & "78 90 75 83 to " & vbCrLf & results.ToString
        Next element
    End Sub

    Private Sub btnSortExample2_Click(sender As Object, e As EventArgs) Handles btnSortExample2.Click

        'Arrays have sorting Methods. One is to Sort in Ascending Order and the other is to Sort in Reverse order. This means to get a descending order you must first sort in Ascending and then in Reverse Example 3 will show this

        'Syntax:   ( Array.Sort(arrayName) )--- Sorts in Ascending Order
        'Syntax:   ( Array.Reverse(arrayName)  )--Sorts in Reverse Order

        Dim scores() As Integer = {78, 90, 75, 83}
        Dim results As String = ""
        Array.Reverse(scores)

        For Each element As Integer In scores
            results += element.ToString & " "
            lblSortResults.Text = "The array was sorted from" & vbCrLf & "78 90 75 83 to " & vbCrLf & results.ToString
        Next element
    End Sub

    Private Sub btnSortExample3_Click(sender As Object, e As EventArgs) Handles btnSortExample3.Click

        'Arrays have sorting Methods. One is to Sort in Ascending Order and the other is to Sort in Reverse order. This means to get a descending order you must first sort in Ascending and then in Reverse Example 3 will show this

        'Syntax:   ( Array.Sort(arrayName) )--- Sorts in Ascending Order
        'Syntax:   ( Array.Reverse(arrayName)  )--Sorts in Reverse Order

        Dim scores() As Integer = {78, 90, 75, 83}
        Dim results As String = ""
        Array.Sort(scores)
        Array.Reverse(scores)

        For Each element As Integer In scores
            results += element.ToString & " "
            lblSortResults.Text = "The array was sorted from" & vbCrLf & "78 90 75 83 to " & vbCrLf & results.ToString
        Next element
    End Sub

    Private Sub btnConAscend_Click(sender As Object, e As EventArgs) Handles btnConAscend.Click

        'Create an App that lists the Continents of the World in Ascending Order and Also in Descending Order

        Dim continents() As String = {"North America", "Africa", "Europe", "Asia", "South America", "Antarctica", "Australia"}
        Dim highSub As Integer = continents.GetUpperBound(0)
        Array.Sort(continents)

        lstContinents.Items.Clear()
        For intSub As Integer = 0 To highSub
            lstContinents.Items.Add(continents(intSub))
        Next intSub
    End Sub

    Private Sub btnConDescend_Click(sender As Object, e As EventArgs) Handles btnConDescend.Click

        'Create an App that lists the Continents of the World in Ascending Order and Also in Descending Order

        Dim continents() As String = {"North America", "Africa", "Europe", "Asia", "South America", "Antarctica", "Australia"}
        Dim highSub As Integer = continents.GetUpperBound(0)
        Array.Sort(continents)
        Array.Reverse(continents)

        lstContinents.Items.Clear()
        For intSub As Integer = 0 To highSub
            lstContinents.Items.Add(continents(intSub))
        Next intSub
    End Sub

    Private Sub btn2Dstore1_Click(sender As Object, e As EventArgs) Handles btn2Dstore1.Click

        'Storing Data in a 2D Array is slightly different than a single array. Since 2D Arrays act like tables you have both a column and a row to specify a cell location
        ' to declare a 2D Array you can use the these two syntaxes:
        ' (  {Dim|Private|Static} arrayName(,) as dataType = {(Values),(Values)}  ) 
        ' (  {Dim|Private|Static} arrayName(highestSubScriptRow, highestSubScriptColumn) as dataType  ) 
        'When storing data use both the ROW and COLUMN location you want the data to be inputed into.

        Dim states(49, 1) As String

        states(0, 0) = "Alabama"
        states(0, 1) = "Montgomery"

        txt2DStoreResults.Text = states(0, 1) & ", " & states(0, 0)

        'This array is a 50 Row 2 Column Array
    End Sub

    Private Sub btn2Dstore2_Click(sender As Object, e As EventArgs) Handles btn2Dstore2.Click

        'Storing Data in a 2D Array is slightly different than a single array. Since 2D Arrays act like tables you have both a column and a row to specify a cell location
        ' to declare a 2D Array you can use the these two syntaxes:
        ' (  {Dim|Private|Static} arrayName(,) as dataType = {(Values),(Values)}  ) 
        ' (  {Dim|Private|Static} arrayName(highestSubScriptRow, highestSubScriptColumn) as dataType  ) 
        'When storing data use both the ROW and COLUMN location you want the data to be inputed into.

        Dim numbers(5, 4) As Integer

        For row As Integer = 0 To 5
            For column As Integer = 0 To 4
                numbers(row, column) = 1
                txt2DStoreResults.Text += numbers(row, column).ToString
            Next column
        Next row
    End Sub

    Private Sub btn2Dstore3_Click(sender As Object, e As EventArgs) Handles btn2Dstore3.Click

        'Storing Data in a 2D Array is slightly different than a single array. Since 2D Arrays act like tables you have both a column and a row to specify a cell location
        ' to declare a 2D Array you can use the these two syntaxes:
        ' (  {Dim|Private|Static} arrayName(,) as dataType = {(Values),(Values)}  ) 
        ' (  {Dim|Private|Static} arrayName(highestSubScriptRow, highestSubScriptColumn) as dataType  ) 
        'When storing data use both the ROW and COLUMN location you want the data to be inputed into.

        Dim sales(,) As Double = {{75.33, 9.65}, {23.55, 6.89}, {4.5, 89.3}, {100.67, 38.92}}
        Dim row As Integer
        Dim column As Integer

        While row <= sales.GetUpperBound(0)
            column = 0
            While column <= sales.GetUpperBound(1)
                sales(row, column) *= 1.1
                txt2DStoreResults.Text += sales(row, column).ToString("c2") & vbCrLf
                column += 1
            End While
            row += 1
        End While
    End Sub

    Private Sub btn2Dstore4_Click(sender As Object, e As EventArgs) Handles btn2Dstore4.Click

        'Storing Data in a 2D Array is slightly different than a single array. Since 2D Arrays act like tables you have both a column and a row to specify a cell location
        ' to declare a 2D Array you can use the these two syntaxes:
        ' (  {Dim|Private|Static} arrayName(,) as dataType = {(Values),(Values)}  ) 
        ' (  {Dim|Private|Static} arrayName(highestSubScriptRow, highestSubScriptColumn) as dataType  ) 
        'When storing data use both the ROW and COLUMN location you want the data to be inputed into.

        Dim sales(,) As Double = {{75.33, 9.65}, {23.55, 6.89}, {4.5, 89.3}, {100.67, 38.92}}

        For x As Integer = 0 To sales.GetUpperBound(0)
            For y As Integer = 0 To sales.GetUpperBound(1)
                sales(x, y) *= 0.07
                txt2DStoreResults.Text += sales(x, y).ToString("c2") & vbCrLf
            Next y
        Next x
    End Sub

    Private Sub btn2Dstore5_Click(sender As Object, e As EventArgs) Handles btn2Dstore5.Click

        'Storing Data in a 2D Array is slightly different than a single array. Since 2D Arrays act like tables you have both a column and a row to specify a cell location
        ' to declare a 2D Array you can use the these two syntaxes:
        ' (  {Dim|Private|Static} arrayName(,) as dataType = {(Values),(Values)}  ) 
        ' (  {Dim|Private|Static} arrayName(highestSubScriptRow, highestSubScriptColumn) as dataType  ) 
        'When storing data use both the ROW and COLUMN location you want the data to be inputed into.

        Dim userArray(5, 4) As Integer
        Static rowCount As Integer = 0
        Static colCount As Integer = 0

        If rowCount <= userArray.GetUpperBound(0) AndAlso colCount <= userArray.GetUpperBound(1) Then
            Integer.TryParse(txt2DStoreInput.Text, userArray(rowCount, colCount))
            txt2DStoreResults.Text += userArray(rowCount, colCount).ToString & vbCrLf
            colCount += 1
            If colCount > 4 And rowCount < 6 Then
                colCount = 0
                rowCount += 1
            End If
        Else
            MessageBox.Show("No More room in Array")
        End If
    End Sub

    Private Sub btnTraverse2Done_Click(sender As Object, e As EventArgs) Handles btnTraverse2Done.Click

        'Recall that you use a loop to traverse a 1D Array. To traverse a 2D Array you typically use "2 LOOPS" A outer and inner loop. One keeps track of the row subscript and the other keeps track of the column subscript
        'You can alternatively use a "FOR EACH...NEXT" statement to traverse a 2D Array but will lack the ability to modify  any of the values.

        'Create an app that will create a 2D Array of the first 4 months of the year and the last date of each month. Use a "FOR...NEXT" statement, a "DO LOOP" and also a "FOR EACH...NEXT" statement to traverse the array and
        'display its contents in the listbox control.

        '"FOR...NEXT STATEMENT"

        Dim months(,) As String = {{"Jan", "31"}, {"Feb", "28 or 29"}, {"Mar", "31"}, {"Apr", "30"}}
        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)

        lstTraverse2D.Items.Clear()

        For row As Integer = 0 To highRow
            For col As Integer = 0 To highCol
                lstTraverse2D.Items.Add(months(row, col))
            Next col
        Next row
    End Sub

    Private Sub btnTraverse2Dtwo_Click(sender As Object, e As EventArgs) Handles btnTraverse2Dtwo.Click

        'Recall that you use a loop to traverse a 1D Array. To traverse a 2D Array you typically use "2 LOOPS" A outer and inner loop. One keeps track of the row subscript and the other keeps track of the column subscript
        'You can alternatively use a "FOR EACH...NEXT" statement to traverse a 2D Array but will lack the ability to modify  any of the values.

        'Create an app that will create a 2D Array of the first 4 months of the year and the last date of each month. Use a "FOR...NEXT" statement, a "DO LOOP" and also a "FOR EACH...NEXT" statement to traverse the array and
        'display its contents in the listbox control.

        '"DO LOOP STATEMENT"

        Dim months(,) As String = {{"Jan", "31"}, {"Feb", "28 or 29"}, {"Mar", "31"}, {"Apr", "30"}}
        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)
        Dim row As Integer
        Dim col As Integer

        lstTraverse2D.Items.Clear()

        While col <= highCol
            row = 0
            While row <= highRow
                lstTraverse2D.Items.Add(months(row, col))
                row += 1
            End While
            col += 1
        End While

        ' OR can code this way

        'While row <= highRow
        'col = 0
        'While col <= highCol
        'lstTraverse2D.Items.Add(months(row, col))
        'col += 1
        'End While
        'row += 1
        ' End While
    End Sub

    Private Sub btnTraverse2Dthree_Click(sender As Object, e As EventArgs) Handles btnTraverse2Dthree.Click

        'Recall that you use a loop to traverse a 1D Array. To traverse a 2D Array you typically use "2 LOOPS" A outer and inner loop. One keeps track of the row subscript and the other keeps track of the column subscript
        'You can alternatively use a "FOR EACH...NEXT" statement to traverse a 2D Array but will lack the ability to modify  any of the values.

        'Create an app that will create a 2D Array of the first 4 months of the year and the last date of each month. Use a "FOR...NEXT" statement, a "DO LOOP" and also a "FOR EACH...NEXT" statement to traverse the array and
        'display its contents in the listbox control.

        '"FOR EACH...NEXT STATEMENT"

        Dim months(,) As String = {{"Jan", "31"}, {"Feb", "28 or 29"}, {"Mar", "31"}, {"Apr", "30"}}

        lstTraverse2D.Items.Clear()

        For Each element As String In months
            lstTraverse2D.Items.Add(element)
        Next element
    End Sub

    Private Sub btnJenkoCalc_Click(sender As Object, e As EventArgs) Handles btnJenkoCalc.Click

        'Create an App that creates a 2D array to store the monthly sales from Jenkos 3 store locations. Each store will have sales from PaperBack and Hardcover then total the monthly sales from each store and display to the user

        Dim monthlysales(,) As Integer = {{1500, 2535}, {2300, 3675}, {1850, 2475}}
        Dim total As Integer

        For Each element As Integer In monthlysales
            total += element
            lblJenkoResults.Text = total.ToString("c2")
        Next
    End Sub

    Private Sub btnDoItFive1_Click(sender As Object, e As EventArgs) Handles btnDoItFive1.Click

        'Create an app the will declare a 2D Array that has 3 ROWS and 2 COLUMNS and imput Integers as values. Use a "FOR EACH...NEXT' statement a "FOR...NExt" statement and also a "DO LOOP" to total the values

        ' "FOR...NEXT STATEMENT"

        Dim monthlysales(,) As Integer = {{1700, 2230}, {2890, 3932}, {4350, 3975}}
        Dim total As Integer
        Dim highRow As Integer = monthlysales.GetUpperBound(0)
        Dim highCol As Integer = monthlysales.GetUpperBound(1)

        For row As Integer = 0 To highRow
            For col As Integer = 0 To highCol
                total += monthlysales(row, col)
                lblFiveDoITResults.Text = total.ToString("c2")
            Next col
        Next row
    End Sub

    Private Sub btnDoItFive2_Click(sender As Object, e As EventArgs) Handles btnDoItFive2.Click

        'Create an app the will declare a 2D Array that has 3 ROWS and 2 COLUMNS and imput Integers as values. Use a "FOR EACH...NEXT' statement a "FOR...NExt" statement and also a "DO LOOP" to total the values

        ' "DO LOOP STATEMENT"

        Dim monthlysales(,) As Integer = {{1880, 3230}, {6890, 7932}, {4390, 9975}}
        Dim total As Integer
        Dim highRow As Integer = monthlysales.GetUpperBound(0)
        Dim highCol As Integer = monthlysales.GetUpperBound(1)
        Dim row As Integer
        Dim col As Integer

        While row <= highRow
            col = 0
            While col <= highCol
                total += monthlysales(row, col)
                lblFiveDoITResults.Text = total.ToString("c0")
                col += 1
            End While
            row += 1
        End While
    End Sub

    Private Sub btnDoItFive3_Click(sender As Object, e As EventArgs) Handles btnDoItFive3.Click

        'Create an app the will declare a 2D Array that has 3 ROWS and 2 COLUMNS and imput Integers as values. Use a "FOR EACH...NEXT' statement a "FOR...NExt" statement and also a "DO LOOP" to total the values

        ' "FOR EACH...NEXT STATEMENT"

        Dim monthlysales(,) As Integer = {{9700, 3230}, {7890, 2932}, {3350, 8975}}
        Dim total As Integer

        For Each element As Integer In monthlysales
            total += element
            lblFiveDoITResults.Text = total.ToString("c1")
        Next
    End Sub

    Private Sub lstPresidents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPresidents.SelectedIndexChanged

        'Arrays and Collections share a commonalities that allow them to assocaite with one another. Each group is treated as ONE UNIT, 2nd Each group is referred to by a specific number identifier. a INDEX when referring to a Collection
        ' but a SUBSCRIPT when referring to an Array, LAstylt each of these numbers both start at ZERO ( 0 )

        'Create an app that adds the Presidents to a Listbox control and when the selectedIndex has been changed display the assocaited Vice President from the Vice Presidents Array. The index value of the Listbox with be the SUBSCRIPT location
        'to look at within the Vice Presidents Array.

        Dim vicePresidents() As String = {"John Adams", "Dan Quayle", "Albert Gore", "Richard Cheney", "Joesph R. Biden", "Mike Pence"}

        lblVicePresidentResults.Text = vicePresidents(lstPresidents.SelectedIndex)
    End Sub

    Private Sub btnAddTotal_Click(sender As Object, e As EventArgs) Handles btnAddTotal.Click

        'Warren school is having a fundraiser selling candy. Create an app that will allow the user to select a type of candy from the ListBox the user will then input the amout of candy that was sold and when the Add to Total button has been clicked
        'the value will update and be displayed in the textbox control to the user.

        Static candyTotal(4) As Integer
        Dim sold As Integer

        Integer.TryParse(txtCandySoldInput.Text, sold)

        candyTotal(lstCandy.SelectedIndex) += sold

        txtChoco.Text = candyTotal(0).ToString
        txtPeanuts.Text = candyTotal(1).ToString
        txtKitKat.Text = candyTotal(2).ToString
        txtPBCups.Text = candyTotal(3).ToString
        txtTake5.Text = candyTotal(4).ToString

        txtCandySoldInput.Focus()
    End Sub

    Private Sub btnPaperWarehouse_Click(sender As Object, e As EventArgs) Handles btnPaperWarehouse.Click

        'Create an app that will create two 1D Arrays that are parallel to each other. One will contain Item IDs and the other will contain their prices. Parallel Arrays are arrays whose data is coorrelating through sharing the same subscripts.
        'In the ID Array the information at id(0) will match to the data in the PRICE Array at price(0). This way you can have two different data types in arrays and they have relation to one another.

        Dim itemID() As String = {"AB12", "CD34", "EF56", "GH78", "IJ90"}
        Dim prices() As Double = {8.99, 12.99, 11.99, 9.99, 7.99}

        Dim searchId As String = txtPaperWarehouseInput.Text.ToUpper
        Dim idSub As Integer

        Do Until idSub = itemID.Length OrElse itemID(idSub) = searchId
            idSub += 1
        Loop

        If idSub < itemID.Length Then
            txtPaperWarehouseResults.Text = prices(idSub).ToString("c2")
        Else
            MessageBox.Show("Invalid ID")
        End If
    End Sub

    Private Sub btn2DPaperWarehouse_Click(sender As Object, e As EventArgs) Handles btn2DPaperWarehouse.Click

        'In the previous version you used parallel arrays to coorrelate different datatypes together in this version you will use a 2D Array to house the data. Since this data has to be the same type the prices will have to be as Strings. If you were
        'to need to use these strings as numbers they would need to be converted

        'Create an app that will create a 2D Array that will house both Item ID and Prices. Search all the rows of the First Column for the user SearchID and if found then display the Price. The book formats the price later in the lbltext but thats stupid
        'since it is a string already I will put the dollar sign into the array.

        Dim items(,) As String = {{"AB12", "$8.99"}, {"CD34", "$12.99"}, {"EF56", "$11.99"}, {"GH78", "$9.99"}, {"IJ90", "$7.99"}}

        Dim searchId As String = txt2DPaperInput.Text.ToUpper
        Dim idSub As Integer

        Do Until idSub > items.GetUpperBound(0) OrElse items(idSub, 0) = searchId
            idSub += 1
        Loop

        If idSub < items.GetUpperBound(0) Then
            txt2DPaperResults.Text = items(idSub, 1)
        Else
            MessageBox.Show("Invalid ID")
        End If
    End Sub

    Private Sub btnExcercise1_Click(sender As Object, e As EventArgs) Handles btnExcercise1.Click

        'EXCERCISE 1
        'Create an App that will find the Highest Stock Value for the Waterson Stock from the past 10 days and how many days it was at that value- Make sure to code it using a "DO LOOP" Statement

        Dim stockPrices() As Double = {85.7, 89.5, 91.0, 99.0, 97.5, 96.0, 96.8, 96.8, 96.0, 99.0}
        Dim highestStock As Double = stockPrices(0)
        Dim days As Integer = 1
        Dim stockSub As Integer

        Do Until stockSub > stockPrices.GetUpperBound(0)
            If highestStock = stockPrices(stockSub) Then
                days += 1
            ElseIf highestStock < stockPrices(stockSub) Then
                highestStock = stockPrices(stockSub)
                days = 1
            End If
            stockSub += 1
        Loop

        lblExcercise1High.Text = highestStock.ToString("c2")
        lblExcercise1Days.Text = days.ToString
    End Sub

    Private Sub btnExcercise2_Click(sender As Object, e As EventArgs) Handles btnExcercise2.Click

        'EXCERCISE 2
        'Create an App the declares an Array of monthly electric bills. Find the average monthly cost for the year and display to the user. Make sure to code it using a "FOR EACH...NEXT" Statement

        Dim electricBill() As Double = {119.1, 99.91, 121.89, 156.67, 187.26, 132.12, 176.34, 174.87, 187.45, 111.11, 78.98, 132.73}
        Dim total As Double

        For Each element As Double In electricBill
            total += element
            Dim average As Double
            average = total / electricBill.Length
            txtExcercise2Results.Text = average.ToString("c2")
        Next
    End Sub

    Private Sub btnExcercise3_Click(sender As Object, e As EventArgs) Handles btnExcercise3.Click

        'Create an App that has Employee PayCodes listed in a ListBox. Allow a Uaer to enter the amount of Hours worked and select their PayCode. Based Upon their selection calculate their total pay. Hours over 40 should be paid a 1.5x the rate
        'The Array PayRates is the hourly wage that employees have based upon their selected PayCodes. It is what will be used to calculate their total pay.

        Dim payrates() As Double = {10.5, 12.5, 14.25, 15.75, 17.65}
        Dim hours As Double
        Dim totalPay As Double

        Double.TryParse(txtExcerice3Hours.Text, hours)

        If hours <= 40 Then
            totalPay = hours * payrates(lstPayCodes.SelectedIndex)
        ElseIf hours > 40 Then
            totalPay = (40 * payrates(lstPayCodes.SelectedIndex)) + ((hours - 40) * (payrates(lstPayCodes.SelectedIndex) * 1.5))
        End If

        txtExcercise3Results.Text = totalPay.ToString("c2")
    End Sub

    Private Sub btnExcercise4_Click(sender As Object, e As EventArgs) Handles btnExcercise4.Click

        'Create an App that declaares two Parallel 1D Arrays one havinf 5 States and the other their 5 capitals. Using a loop add the city and state to the listbox control with this format
        ' (  cityName, stateName  )

        Dim states() As String = {"NC", "OR", "LA", "CA", "CT"}
        Dim cities() As String = {"Raleigh", "Salem", "Baton Rogue", "Sacramento", "Hartford"}
        Dim subScript As Integer

        lstCityState.Items.Clear()
        While subScript <= states.GetUpperBound(0)
            lstCityState.Items.Add(cities(subScript) & "," & " " & states(subScript))
            subScript += 1
        End While
    End Sub

    Private Sub btnJuarezApplication_Click(sender As Object, e As EventArgs) Handles btnJuarezApplication.Click

        'EXCERCISE 5
        'Create an app that declares 2 parralel 1D Arrays one Names and the other Grades both can be strings. When the User selects a grade in the ListBox display the Names of students that have that grade as well as the number of students

        Dim students() As String = {"Ricky", "Mason", "Owen", "Veronica", "Gracie", "Barry"}
        Dim grades() As String = {"E", "A", "B", "A", "B", "C"}

        Dim gradeSearch As String = lstJuarez.SelectedItem.ToString.ToUpper
        Dim results As String = ""
        Dim count As Integer

        For intSub As Integer = 0 To grades.GetUpperBound(0)
            If gradeSearch = grades(intSub) Then
                results += students(intSub) & vbCrLf
                count += 1
            End If
        Next intSub

        lblStudentsResults.Text = results
        lblStudentNumber.Text = count.ToString

        'EXCERCISE 7 is a modification to this app instead of a two 1D parallel arrays you will use a single 2D array to store the data then search for the grades and display to the user.

        Dim allStudentData(,) As String = {{"Ricky", "E"}, {"Mason", "A"}, {"Owen", "B"}, {"Veronica", "A"}, {"Gracie", "B"}, {"Barry", "C"}}
        Dim searchGrade As String = lstJuarez.SelectedItem.ToString.ToUpper
        Dim resultsTwo As String = ""
        Dim countTwo As Integer

        For intSub As Integer = 0 To allStudentData.GetUpperBound(0)
            If searchGrade = allStudentData(intSub, 1) Then
                resultsTwo += allStudentData(intSub, 0) & vbCrLf
                countTwo += 1
            End If
        Next intSub

        lblStudentsResults.Text = resultsTwo
        lblStudentNumber.Text = countTwo.ToString
    End Sub

    Private Sub btnCalories_Click(sender As Object, e As EventArgs) Handles btnCalories.Click

        'EXCERCISE 8
        'Create an App that stores a months worth of Calorie data. Find the average of the calories for each day and then also keep a record of the days that were either above the average, below the average or lastly the same as the average

        Dim calories() As Integer = {2000, 2200, 2000, 2400, 2200, 2000, 2000, 2000, 2500, 2400, 2000, 2000, 2000, 2200, 2000, 1800, 2300, 2000, 2000, 1800, 2200, 2000, 1900, 2000, 2100, 2000, 2000, 2200, 2000, 1800}
        Dim total As Integer
        Dim average As Integer
        Dim above As Integer
        Dim below As Integer
        Dim same As Integer

        For Each element As Integer In calories
            total += element
        Next element

        average = total / calories.Length

        For Each element As Integer In calories
            If element > average Then
                above += 1
            ElseIf element = average Then
                same += 1
            ElseIf element < average Then
                below += 1
            End If
        Next element

        lblCalorieAverage.Text = average.ToString
        lblCalorieAbove.Text = above.ToString
        lblCalorieSame.Text = same.ToString
        lblCalorieBelow.Text = below.ToString
    End Sub

    Private Sub btnExcercise9_Click(sender As Object, e As EventArgs) Handles btnExcercise9.Click

        'EXCERCISE 9
        'create an app that will allow a user to select the type of computer sold and then enter in the amount of each type that was sold. Display the totals in the txt control labels.

        Static computersSold(2) As Integer
        Dim amountSold As Integer

        Integer.TryParse(txtComputerInput.Text, amountSold)

        computersSold(lstComputers.SelectedIndex) += amountSold

        txtNewCompResults.Text = computersSold(0)
        txtUsedCompResults.Text = computersSold(1)
    End Sub

    Private Sub btnExcercise10_Click(sender As Object, e As EventArgs) Handles btnExcercise10.Click

        'EXCERCISE 10 AND 11
        'Create an App that will take in a User's input and then display the grade earned based upon how many points the user entered. 
        'the 1st iteration will use two parallel 1D Array and the @nd iteration will use a 2D Array

        Dim gradeScale() As Integer = {0, 300, 350, 415, 465}
        Dim grade() As String = {"F", "D", "C", "B", "A"}
        Dim userScore As Integer

        Integer.TryParse(txtPointsExcercise10.Text, userScore)

        For intSub As Integer = 0 To gradeScale.GetUpperBound(0)
            If userScore >= gradeScale(intSub) Then
                lblPointsExcercise10Results.Text = grade(intSub)
            End If
        Next intSub

        'EXCERCISE 11

        'Dim gradingRubic(,) As String = {{"0", "F"}, {"300", "D"}, {"350", "C"}, {"415", "B"}, {"465", "A"}}
        'Dim userInput As Integer

        'Integer.TryParse(txtPointsExcercise10.Text, userInput)

        'For intSub As Integer = 0 To gradingRubic.GetUpperBound(0)
        'Dim points As Integer
        'Integer.TryParse(gradingRubic(intSub, 0), points)
        'If userInput >= points Then
        'lblPointsExcercise10Results.Text = gradingRubic(intSub, 1)
        'End If
        'Next intSub

    End Sub

    Private Sub btnExcercise12_Click(sender As Object, e As EventArgs) Handles btnExcercise12.Click

        'EXCERCISE 12
        ' Create an app that takes in from the user how many of any item has been ordered. Based upon the amount ordered the shipping charge will vary. Create a 2D Array that houses the data for the shipping costs and stipulations
        ' and display to the user the shipping cost.

        Dim shippingCosts(,) As Double = {{0, 0}, {1, 10.99}, {6, 7.99}, {11, 3.99}, {21, 0}}
        Dim userAmount As Double

        Double.TryParse(txtKrastonExcercise12Input.Text, userAmount)

        For intSub As Integer = 0 To shippingCosts.GetUpperBound(0)
            If userAmount >= shippingCosts(intSub, 0) Then
                lblKrastonExcercise12Results.Text = shippingCosts(intSub, 1).ToString("c2")
            End If
        Next intSub
    End Sub

    Private Sub btnExcercise13_Click(sender As Object, e As EventArgs) Handles btnExcercise13.Click


        'EXCERCISE 13
        'Create an app that will take in Shipping Depots monthly shipping for each of the 3 mail carriers FEDEX UPS and USPS. Display to the user the total amount of ALL packages that were delivered for the month. Then how much did each
        'individual carrier take and lastly whatg percent of the total was this. Display all data to the user.

        'Dim packages(,) As Integer = {{225, 216, 150}, {199, 225, 215}, {230, 200, 225}, {150, 175, 200}}
        'Dim fedexTotal As Integer
        'Dim upsTotal As Integer
        'Dim uspsTotal As Integer
        'Dim total As Integer

        'For intRow As Integer = 0 To packages.GetUpperBound(0)
        'For intCol As Integer = 0 To packages.GetUpperBound(1)
        'total += packages(intRow, intCol)
        'Next intCol
        'Next intRow

        'For intRow As Integer = 0 To packages.GetUpperBound(0)
        'fedexTotal += packages(intRow, 0)
        'upsTotal += packages(intRow, 1)
        'uspsTotal += packages(intRow, 2)
        'Next intRow

        'Dim fedexPercent As Double = (fedexTotal / total)
        'Dim upsPercent As Double = (upsTotal / total)
        'Dim uspsPercent As Double = (uspsTotal / total)

        'txtShippingTotal.Text = total.ToString
        'txtFedExTotal.Text = fedexTotal.ToString
        'txtFedExPercent.Text = fedexPercent.ToString("P0")
        'txtUPSTotal.Text = upsTotal.ToString
        'txtUPSpercent.Text = upsPercent.ToString("P0")
        'txtUSPSTotal.Text = uspsTotal.ToString
        'txtUSPSperecent.Text = uspsPercent.ToString("P0")


        'EXCERCISE 14
        'In this excercise you are asked to modify the array to be 3 ROWS and 4 COLUMNS using the same data

        Dim shipped(,) As Integer = {{225, 199, 230, 150}, {216, 225, 200, 175}, {150, 215, 225, 200}}
        Dim shippedAmount As Integer
        Dim fedexAmount As Integer
        Dim upsAmount As Integer
        Dim uspsAmount As Integer

        For intRow As Integer = 0 To shipped.GetUpperBound(0)
            For intCol As Integer = 0 To shipped.GetUpperBound(1)
                shippedAmount += shipped(intRow, intCol)
            Next intCol
        Next intRow

        For intCol As Integer = 0 To shipped.GetUpperBound(1)
            fedexAmount += shipped(0, intCol)
            upsAmount += shipped(1, intCol)
            uspsAmount += shipped(2, intCol)
        Next intCol

        Dim fedexPercentAmount As Double = (fedexAmount / shippedAmount)
        Dim upsPercentAmount As Double = (upsAmount / shippedAmount)
        Dim uspsPercentAmount As Double = (uspsAmount / shippedAmount)

        txtShippingTotal.Text = shippedAmount.ToString
        txtFedExTotal.Text = fedexAmount.ToString
        txtFedExPercent.Text = fedexPercentAmount.ToString("P0")
        txtUPSTotal.Text = upsAmount.ToString
        txtUPSpercent.Text = upsPercentAmount.ToString("P0")
        txtUSPSTotal.Text = uspsAmount.ToString
        txtUSPSperecent.Text = uspsPercentAmount.ToString("P0")
    End Sub

    Private Sub btnLotteryExcercise14_Click(sender As Object, e As EventArgs) Handles btnLotteryExcercise14.Click

        'EXCERCISE 15  
        'Create an app that generates 6 random numbers and then displays them to the user

        Dim numbers(5) As Integer
        Dim generator As New Random
        Dim intSub As Integer

        lblLotteryResultsExcercise14.Text = ""
        Do While intSub <= numbers.GetUpperBound(0)
            numbers(intSub) = generator.Next(1, 66)
            lblLotteryResultsExcercise14.Text += numbers(intSub).ToString & " "
            intSub += 1
        Loop
    End Sub

    Private Sub btnExcercise16Increase_Click(sender As Object, e As EventArgs) Handles btnExcercise16Increase.Click

        'EXCERCISE 16   
        'Create an app that declares a Double Array that will store 30 days of Gas Prices. Then display how many days the price increased from the day before or decreased from the day before or stayed the same as the day before
        'the book has 3 buttons for this project which is simple enough, but I will code it into one button and display it all in one go

        Dim gasPrices() As Double = {2.25, 2.25, 2.24, 2.15, 2.05, 1.97, 2.25, 2.87, 2.5, 2.4, 2.25, 2.35, 2.45, 2.5, 2.25, 2.15, 2.1, 2.25, 2.3, 2.37, 2.4, 2.45, 2.5, 2.35, 2.25, 2.25, 2.25, 2.05, 1.98, 2.03}
        Dim daysIncreased As Integer = 0
        Dim daysDecreased As Integer = 0
        Dim daysEqual As Integer = 0

        For intSub As Integer = 0 To gasPrices.GetUpperBound(0) - 1
            If gasPrices(intSub + 1) > gasPrices(intSub) Then
                daysIncreased += 1
            ElseIf gasPrices(intSub + 1) < gasPrices(intSub) Then
                daysDecreased += 1
            ElseIf gasPrices(intSub + 1) = gasPrices(intSub) Then
                daysEqual += 1
            End If
        Next intSub

        txtGasEX16increase.Text = daysIncreased.ToString
        txtGasEX16decrease.Text = daysDecreased.ToString
        txtGasEX16equal.Text = daysEqual.ToString
    End Sub

    Private Sub btnExcercise17_Click(sender As Object, e As EventArgs) Handles btnExcercise17.Click


        'EXCERCISE 17
        'Create an App that creates a 2D Array to store the monthly Sales of Organic Markets regional areas. Display the Monthly sales to the User as well as the Total of the monthly sales as well as the total Sales and the percentage of Sales

        'Array
        Dim salesChart(,) As Integer = {{1, 120000, 90000, 65000}, {2, 190000, 85000, 64000}, {3, 175000, 80000, 71000}, {4, 188000, 83000, 67000}, {5, 125000, 87000, 65000}, {6, 163000, 80000, 64000}}

        'Variables- totals
        Dim UStotals As Integer
        Dim Canadatotals As Integer
        Dim Mexicototals As Integer
        Dim totalSales As Integer
        Dim USpercents As Double
        Dim Canadapercents As Double
        Dim Mexicopercents As Double
        Dim monthlytotal As Integer

        'finding total of all sales
        For Each element As Integer In salesChart
            totalSales += element
        Next element

        'finding Total of Regional Sales and Getting Percent of Total Sales
        For intRow As Integer = 0 To salesChart.GetUpperBound(0)
            lstUSSales.Items.Add(salesChart(intRow, 1).ToString("C0"))
            UStotals += salesChart(intRow, 1)
            USpercents = UStotals / totalSales
            lstCanadaSales.Items.Add(salesChart(intRow, 2).ToString("C0"))
            Canadatotals += salesChart(intRow, 2)
            Canadapercents = Canadatotals / totalSales
            lstMexicoSales.Items.Add(salesChart(intRow, 3).ToString("C0"))
            Mexicototals += salesChart(intRow, 3)
            Mexicopercents = Mexicototals / totalSales
        Next intRow

        'Adding Formatting and Percent of Sales to US List Box
        lstUSSales.Items.Add("")
        lstUSSales.Items.Add("% of Sales - ")
        lstUSSales.Items.Add("")
        lstUSSales.Items.Add(USpercents.ToString("p0"))

        'Adding Formatting and Percent of Sales to Canada List Box
        lstCanadaSales.Items.Add("")
        lstCanadaSales.Items.Add("% of Sales - ")
        lstCanadaSales.Items.Add("")
        lstCanadaSales.Items.Add(Canadapercents.ToString("p0"))

        'Adding Formatting and Percent of Sales to Mexico List Box
        lstMexicoSales.Items.Add("")
        lstMexicoSales.Items.Add("% of Sales - ")
        lstMexicoSales.Items.Add("")
        lstMexicoSales.Items.Add(Mexicopercents.ToString("p0"))

        'Finding Monthly Total Sales
        For intRow As Integer = 0 To salesChart.GetUpperBound(0)
            monthlytotal = salesChart(intRow, 1) + salesChart(intRow, 2) + salesChart(intRow, 3) & vbCrLf
            lstMonthlySales.Items.Add(monthlytotal.ToString("C0"))
        Next intRow

        'Adding Formatting and Total Sales to Monthly Sales List Box
        lstMonthlySales.Items.Add("")
        lstMonthlySales.Items.Add("Total Sales-")
        lstMonthlySales.Items.Add("")
        lstMonthlySales.Items.Add(totalSales.ToString("c0"))

        'Display total Sales in a label
        lblOrganicResults.Text = "the total overall sales" & vbCrLf & "from all regions is " & vbCrLf & totalSales.ToString("c0")
    End Sub

    Private Sub btn18Excercise_Click(sender As Object, e As EventArgs) Handles btn18Excercise.Click

        'EXCERCISE 18
        'Create an app that will allow a user to select item IDs from a Listbox and display their color and price. When the user selects a color from the listbox all the Item IDs with that color and their price shoudl be displayed
        'when a user searches a price all Item Ids color and Prices with that price and UNDER should be displayed

        Dim items(,) As String = {{"101", "Blue", "4.99"}, {"102", "Red", "4.99"}, {"103", "Blue", "10.49"}, {"104", "Red", "10.49"}, {"105", "White", "6.79"},
                                  {"106", "Red", "6.79"}, {"107", "Blue", "6.79"}, {"108", "Black", "21.99"}, {"109", "White", "21.99"}, {"110", "Blue", "21.99"}}

        Dim userSearch As Double
        Double.TryParse(txt18ExcerciseInput.Text, userSearch)
        Dim results As String = ""

        lblPriceSearchResults.Text = ""
        For intRow As Integer = 0 To items.GetUpperBound(0)
            Dim priceCheck As Double
            Double.TryParse(items(intRow, 2), priceCheck)
            If userSearch >= priceCheck Then
                results += items(intRow, 0) & " " & items(intRow, 1) & " " & items(intRow, 2) & vbCrLf
            End If
        Next

        lblPriceSearchResults.Text = results

    End Sub

    Private Sub lstItemID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemID.SelectedIndexChanged

        'EXCERCISE 18
        'Create an app that will allow a user to select item IDs from a Listbox and display their color and price. When the user selects a color from the listbox all the Item IDs with that color and their price shoudl be displayed
        'when a user searches a price all Item Ids color and Prices with that price and UNDER should be displayed

        Dim idSearch As String = lstItemID.SelectedItem.ToString
        Dim items(,) As String = {{"101", "Blue", "4.99"}, {"102", "Red", "4.99"}, {"103", "Blue", "10.49"}, {"104", "Red", "10.49"}, {"105", "White", "6.79"},
                                  {"106", "Red", "6.79"}, {"107", "Blue", "6.79"}, {"108", "Black", "21.99"}, {"109", "White", "21.99"}, {"110", "Blue", "21.99"}}

        lbl18ExcerciseResults.Text = ""
        For intRow As Integer = 0 To items.GetUpperBound(0)
            For intCol As Integer = 0 To items.GetUpperBound(1)
                If idSearch = items(intRow, 0) Then
                    lbl18ExcerciseResults.Text += items(intRow, intCol) & " "
                End If
            Next intCol
        Next intRow

    End Sub

    Private Sub lstItemColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemColor.SelectedIndexChanged

        'EXCERCISE 18
        'Create an app that will allow a user to select item IDs from a Listbox and display their color and price. When the user selects a color from the listbox all the Item IDs with that color and their price shoudl be displayed
        'when a user searches a price all Item Ids color and Prices with that price and UNDER should be displayed

        Dim colorSearch As String = lstItemColor.SelectedItem.ToString
        Dim items(,) As String = {{"101", "Blue", "4.99"}, {"102", "Red", "4.99"}, {"103", "Blue", "10.49"}, {"104", "Red", "10.49"}, {"105", "White", "6.79"},
                                  {"106", "Red", "6.79"}, {"107", "Blue", "6.79"}, {"108", "Black", "21.99"}, {"109", "White", "21.99"}, {"110", "Blue", "21.99"}}
        Dim results As String = ""

        lbl18Results2.Text = ""
        For intRow As Integer = 0 To items.GetUpperBound(0)
            If colorSearch = items(intRow, 1) Then
                results += items(intRow, 0) & " " & items(intRow, 1) & " " & items(intRow, 2) & vbCrLf
            End If
        Next intRow

        lbl18Results2.Text = results
    End Sub

    Private Sub btnExcercise19two_Click(sender As Object, e As EventArgs) Handles btnExcercise19two.Click

        'EXCERCISE 19   
        'Create an app to display the sales of the company Project Adaline. Controls in group box 1 should display the sales totals of the slected items in the Listboxes. If all and both are selected then you should display the total sales in the txtcontrol
        'if Sue Chen and 2018 is selected then 4000 should be displayed. If all and 2019 are slected then only the totals from 2019 should be displayed.

        'Array for Excercise 19

        Dim sales(,) As Integer = {{4000, 7200}, {4000, 5000}, {2500, 6500}, {4000, 7200}, {3900, 6000}, {3600, 7000}}
        Dim total As Integer
        Dim salesIndex As Integer = lstSalesPeople.SelectedIndex
        Dim yearIndex As Integer = lstYears1.SelectedIndex

        If salesIndex = 0 Then
            If yearIndex = 0 Then
                For Each element As Integer In sales
                    total += element
                    txtSales20Results.Text = total.ToString("C2")
                Next element
            ElseIf yearIndex = 1 Then
                For intSub As Integer = 0 To sales.GetUpperBound(0)
                    total += sales(intSub, 0)
                    txtSales20Results.Text = total.ToString("C2")
                Next intSub
            ElseIf yearIndex = 2 Then
                For intSub As Integer = 0 To sales.GetUpperBound(0)
                    total += sales(intSub, 1)
                    txtSales20Results.Text = total.ToString("C2")
                Next intSub
            End If
        ElseIf salesIndex >= 1 Then
            If yearIndex = 0 Then
                total = sales(salesIndex - 1, 0) + sales(salesIndex - 1, 1)
                txtSales20Results.Text = total.ToString("C2")
            ElseIf yearIndex = 1 Then
                total = sales(salesIndex - 1, 0)
                txtSales20Results.Text = total.ToString("C2")
            ElseIf yearIndex = 2 Then
                total = sales(salesIndex - 1, 1)
                txtSales20Results.Text = total.ToString("C2")
            End If
        End If

    End Sub

    Private Sub btnExcercise19_Click(sender As Object, e As EventArgs) Handles btnExcercise19.Click

        'EXCERCISE 19
        'In this portion of the App the user can Select a Year and Either High or Low. Based Upon the Selection Display the high or low total for the year and the SalesPeople who made that sale.

        Dim sales(,) As Integer = {{4000, 7200}, {4000, 5000}, {2500, 6500}, {4000, 7200}, {3900, 6000}, {3600, 7000}}
        Dim names() As String = {"Jacob Schmidt", "Joe Smith", "Rex Parker", "Sue Chen", "Sue Perez", "Suman Patel"}
        Dim saleHighLow As Integer = lstHighLow.SelectedIndex
        Dim yearIndex As Integer = lstYears2.SelectedIndex
        Dim sale2018 As Integer = 4000
        Dim sale2019 As Integer = sales(0, 1)
        Dim employee As String = ""

        '2018 ListBoxes
        If yearIndex = 0 AndAlso saleHighLow = 0 Then
            For intRow As Integer = 0 To sales.GetUpperBound(0)
                If sale2018 <= sales(intRow, 0) Then
                    sale2018 = sales(intRow, 0)
                    employee = names(intRow) & vbCrLf
                End If
            Next intRow
            lstSalesNames.Items.Add(employee)
        ElseIf yearIndex = 0 AndAlso saleHighLow = 1 Then
            For intRow As Integer = 0 To sales.GetUpperBound(0)
                If sale2018 >= sales(intRow, 0) Then
                    sale2018 = sales(intRow, 0)
                    employee = names(intRow)
                End If
            Next intRow
            lstSalesNames.Items.Add(employee)
        End If

        '2019 ListBoxes
        If yearIndex = 1 AndAlso saleHighLow = 0 Then
            For intRow As Integer = 0 To sales.GetUpperBound(0)
                If sale2019 <= sales(intRow, 1) Then
                    sale2019 = sales(intRow, 1)
                End If
            Next intRow
            lstSalesNames.Items.Clear()
            For intSub As Integer = 0 To sales.GetUpperBound(0)
                If sale2019 = sales(intSub, 1) Then
                    lstSalesNames.Items.Add(names(intSub))
                    txtSales20Resultstwo.Text = sale2019.ToString("c2")
                End If
            Next intSub
        ElseIf yearIndex = 1 AndAlso saleHighLow = 1 Then
            For intRow As Integer = 0 To sales.GetUpperBound(0)
                If sale2019 > sales(intRow, 1) Then
                    sale2019 = sales(intRow, 1)
                End If
            Next intRow
            lstSalesNames.Items.Clear()
            For intSub As Integer = 0 To sales.GetUpperBound(0)
                If sale2019 = sales(intSub, 1) Then
                    lstSalesNames.Items.Add(names(intSub))
                    txtSales20Resultstwo.Text = sale2019.ToString("c2")
                End If
            Next intSub
        End If
    End Sub
End Class
