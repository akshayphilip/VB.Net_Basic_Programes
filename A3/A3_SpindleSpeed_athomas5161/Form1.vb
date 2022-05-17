'AKSHAY PHILIP THOMAS,PROG8240,Structured Programming, STUDENT NO: 8795161
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'declare the varibles

        Dim cutspeed, dia, upperlimt, lowerlimt, maxspeed As Double
        Dim rpm As Integer

        'assigning the varibles

        lowerlimt = Val(cboMinStockSize.Text)
        upperlimt = Val(cboMaxStockSize.Text)

        maxspeed = Val(nudMaxAllowedSpeed.Value)
        cutspeed = nudCuttingSpeed.Value
        Const pi As Double = 3.1415926

        ' checking if conditions for the 4 radio buttons

        If (rad125.Checked = True) Then

            LstResults.Items.Clear()
            LstResults.Items.Add("Stock size " & vbTab & "RPM ")
            LstResults.Items.Add(" " & vbTab & " ")

            'using for loop find the the values of RPM using differnt increment

            For dia = lowerlimt To upperlimt Step 0.125
                rpm = (12 * cutspeed) / (pi * dia)

                If (rpm < maxspeed) Then
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & rpm)

                Else
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & "OVER MAX")
                End If

            Next

            'using for loop find the the values of RPM using differnt increment
        ElseIf (rad250.Checked = True) Then

            LstResults.Items.Clear()
            LstResults.Items.Add("Stock size " & vbTab & "RPM ")
            LstResults.Items.Add(" " & vbTab & " ")

            For dia = lowerlimt To upperlimt Step 0.25
                rpm = (12 * cutspeed) / (pi * dia)
                If (rpm < maxspeed) Then
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & rpm)

                Else
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & "OVER MAX")
                End If
            Next

            'using for loop find the the values of RPM using differnt increment
        ElseIf (rad375.Checked = True) Then
            LstResults.Items.Clear()
            LstResults.Items.Add("Stock size " & vbTab & "RPM ")
            LstResults.Items.Add(" " & vbTab & " ")

            For dia = lowerlimt To upperlimt Step 0.375
                rpm = (12 * cutspeed) / (pi * dia)
                If (rpm < maxspeed) Then
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & rpm)

                Else
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & "OVER MAX")
                End If
            Next

            'using for loop find the the values of RPM using differnt increment
        ElseIf (rad500.Checked = True) Then
            LstResults.Items.Clear()
            LstResults.Items.Add("Stock size " & vbTab & "RPM ")
            LstResults.Items.Add(" " & vbTab & " ")

            For dia = lowerlimt To upperlimt Step 0.5
                rpm = (12 * cutspeed) / (pi * dia)
                If (rpm < maxspeed) Then
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & rpm)

                Else
                    LstResults.Items.Add(dia.ToString("N3") & vbTab & vbTab & "OVER MAX")
                End If
            Next

        End If
    End Sub

    'when close button is pressed the program quits
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
