'AKSHAY PHILIP THOMAS,PROG8240,Structured Programming, STUDENT NO: 8795161
Public Class Form1
    ' delclare the no of parts as integer for an array in global varible
    Dim arparts() As Integer = {355, 840, 906, 498, 222, 750, 672, 888, 1234, 1066, 567, 789}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declare array and varibles
        Dim myarray() As String
        Dim textvarible As String
        textvarible = CStr(txtArray.Text)

        'split the text into array
        myarray = textvarible.Split(",")
        LblResults.Text = ""

        'using the for loop finding the convert lower case into upper case
        For i As Integer = 0 To myarray.GetUpperBound(0)
            myarray(i) = myarray(i).ToUpper

        Next

        'display the result in the label box
        For i As Integer = 0 To myarray.GetUpperBound(0)
            LblResults.Text &= myarray(i) & ","

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'declare array and varibles
        Dim myarray() As String
        Dim textvarible As String
        textvarible = CStr(txtArray.Text)

        myarray = textvarible.Split(",")
        LblResults.Text = ""

        'display the results in the label box
        LblResults.Text = myarray(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'declare array and varibles
        Dim myarray() As String
        Dim textvarible, firstname, lastname As String
        Dim m, n, x, y As Integer
        textvarible = CStr(txtArray.Text)

        myarray = textvarible.Split(",")
        LblResults.Text = ""

        'using the index method to find the postion of the letters
        m = myarray(0).IndexOf(" ")
        n = Len(myarray(0))
        x = m + 1
        y = n - m - 1
        firstname = myarray(0).Substring(0, m)
        lastname = myarray(0).Substring(x, y)

        'appending the first and last name and assign to the array
        myarray(0) = lastname & " " & firstname

        'displaying the results

        For i As Integer = 0 To myarray.GetUpperBound(0)
            LblResults.Text &= myarray(i) & ","

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'declare array and varibles

        Dim myarray() As String
        Dim textvarible As String
        Dim num1, num2, sum1, sum2, TotalSum As Integer
        Dim R1, R2 As Integer
        textvarible = CStr(txtArray.Text)

        myarray = textvarible.Split(",")
        LblResults.Text = ""

        'using the while loop and algorithm , to find sum of numbers
        num1 = myarray(1)

        Do While (num1 > 0)
            R1 = num1 Mod 10
            sum1 = sum1 + R1
            num1 = num1 \ 10
        Loop

        num2 = myarray(4)

        Do While (num2 > 0)
            R2 = num2 Mod 10
            sum2 = sum2 + R2
            num2 = num2 \ 10
        Loop

        TotalSum = sum1 + sum2

        'display the results in label box
        LblResults.Text = TotalSum
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'declare array and varibles
        Dim montharr() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"}

        LstResults1.Items.Clear()

        'adding values to the list box using a for loop
        LstResults1.Items.Add("Months " & vbTab & "Parts ")
        LstResults1.Items.Add(" " & vbTab & " ")
        LstResults1.Items.Add("--------------------- ")

        For i As Integer = 0 To arparts.GetUpperBound(0)
            LstResults1.Items.Add(montharr(i) & vbTab & arparts(i))

        Next


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'declare array and varibles

        Dim average As Double
        Dim totparts As Integer

        'calculating the total no of parts

        For i As Integer = 0 To 5
            totparts = arparts(i) + totparts
        Next
        ' calculating the average no of parts
        average = totparts / 6

        LblAvgresults.Text = average.ToString("N2")
        LblTotResults.Text = totparts
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim arrsort(11) As Integer
        Dim MonthPositon As Integer
        Dim montharr() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", " Oct", "Nov", "Dec"}
        Array.Copy(arparts, arrsort, arrsort.Length)
        Array.Sort(arrsort)



        LstResults2.Items.Clear()
        LstResults2.Items.Add("Months " & vbTab & "Parts ")
        LstResults2.Items.Add(" " & vbTab & " ")
        LstResults2.Items.Add("--------------------- ")


        For i As Integer = 0 To arrsort.GetUpperBound(0)

            'using the index of method finding out the month index for corresponding sorted array
            MonthPositon = Array.IndexOf(arparts, arrsort(i))
            LstResults2.Items.Add(montharr(MonthPositon) & vbTab & arrsort(i))

        Next


    End Sub

End Class
