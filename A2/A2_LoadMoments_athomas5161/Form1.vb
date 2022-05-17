'AKSHAY PHILIP THOMAS,PROG8240,Structured Programming, STUDENT NO: 8795161
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declare the varibles 
        Dim mass, lenght, angle, noofpos, moment, weight, anglechange As Double
        Const pi As Double = 3.1415926
        Const G As Double = 9.81

        'Assiging the varibles

        mass = txtMass.Text
        lenght = txtLength.Text
        anglechange = txtAngleChange.Text
        noofpos = xtNumOfPos.Text

        weight = mass * G
        angle = 0

        'using for loop to calculate the moment in different angle position
        For i As Integer = 1 To noofpos
            moment = weight * lenght * Math.Cos(angle * (pi / 180))

            LstAngles.Items.Add((Math.Round(angle, 2)))
            LstMoments.Items.Add(moment.ToString("N2"))
            angle = angle + anglechange  'increment angle with anglechange with every cycle in the for loop
        Next



    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Close when quit button is pressed
        Me.Close()

    End Sub

    Private Sub txtMass_TextChanged(sender As Object, e As EventArgs) Handles txtMass.TextChanged
        'Clear the list box when mass is edited
        LstAngles.Items.Clear()
        LstMoments.Items.Clear()
    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        'Clear the list box when lenght is edited
        LstAngles.Items.Clear()
        LstMoments.Items.Clear()
    End Sub

    Private Sub txtAngleChange_TextChanged(sender As Object, e As EventArgs) Handles txtAngleChange.TextChanged
        'Clear the list box when angle change  is edited
        LstAngles.Items.Clear()
        LstMoments.Items.Clear()
    End Sub

    Private Sub xtNumOfPos_TextChanged(sender As Object, e As EventArgs) Handles xtNumOfPos.TextChanged
        'Clear the list box when no of positions  is edited
        LstAngles.Items.Clear()
        LstMoments.Items.Clear()
    End Sub
End Class
