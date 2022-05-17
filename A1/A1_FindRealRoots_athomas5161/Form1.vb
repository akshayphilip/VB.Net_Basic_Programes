'AKSHAY PHILIP THOMAS,PROG8240,Structured Programming, STUDENT NO: 8795161
Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declare varibles for the coefficent and roots
        Dim a, b, c, descriminant, root1, root2 As Double

        'Assign Varibles to coefficents of the quadratic equation
        a = txtCoeffA.Text
        b = txtCoeffB.Text
        c = txtCoeffC.Text

        'finding the descriminant
        descriminant = b * b - (4 * a * c)

        'using the three if conditions 

        'if descriminant is greater than zero condition
        If (descriminant > 0) Then
            root1 = (-b + Math.Sqrt(descriminant)) / (2 * a)
            root2 = (-b - Math.Sqrt(descriminant)) / (2 * a)
            LBLRootX1.Text = Math.Round(root1, 2)
            LBLRootX2.Text = Math.Round(root2, 2)
            RootBox.Text = ("QUADRATIC EQUATION HAS TWO DISTINCT REAL ROOTS")
        End If

        'if descriminant is equal to zero condition
        If (descriminant = 0) Then
            root1 = -b / (2 * a)
            root2 = root1
            LBLRootX1.Text = Math.Round(root1, 2)
            LBLRootX2.Text = Math.Round(root2, 2)
            RootBox.Text = ("QUADRATIC EQUATION HAS TWO EQUAL ROOTS")
        End If

        'if descriminant is less than zero condition
        If (descriminant < 0) Then
            RootBox.Text = ("QUADRATIC EQUATION HAS NO REAL ROOTS")
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'close the window when is quit button is pressed
        Me.Close()
    End Sub

    Private Sub txtCoeffA_TextChanged(sender As Object, e As EventArgs) Handles txtCoeffA.TextChanged
        'clear the Display ouputs when new input is entered
        LBLRootX1.Text = ""
        LBLRootX2.Text = ""
        RootBox.Text = ""
    End Sub

    Private Sub txtCoeffB_TextChanged(sender As Object, e As EventArgs) Handles txtCoeffB.TextChanged
        'clear the Display ouputs when new input is entered
        LBLRootX1.Text = ""
        LBLRootX2.Text = ""
        RootBox.Text = ""
    End Sub

    Private Sub txtCoeffC_TextChanged(sender As Object, e As EventArgs) Handles txtCoeffC.TextChanged
        'clear the Display ouputs when new input is entered
        LBLRootX1.Text = ""
        LBLRootX2.Text = ""
        RootBox.Text = ""
    End Sub

End Class
