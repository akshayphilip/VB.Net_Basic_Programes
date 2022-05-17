Imports System.IO
Public Class Form1
    'Declaration of string and streamreader varible
    Dim myArray() As String
    Dim srMeasure As StreamReader

    'Function to calculate the Maximum size
    Function CalcMaxsize() As Double
        'Declaration of varibles
        Dim nominalSize, upperSize, upperTol As Double

        nominalSize = CDbl(txtNominalSize.Text)
        upperTol = CDbl(nudUpperTol.Text)

        'Processing
        upperSize = nominalSize + upperTol

        'return value to the call function
        Return upperSize
    End Function

    'Function to calculate the Maximum size
    Function CalcMinsize() As Double

        'Declaration of varibles
        Dim nominalSize, lowerSize, lowerTol As Double
        nominalSize = CDbl(txtNominalSize.Text)
        lowerTol = CDbl(nudLowerTol.Text)

        'Processing
        lowerSize = nominalSize + lowerSize

        'return value to the call function
        Return lowerSize
    End Function

    'Procedure to clear the list box
    Sub clearlist()
        LstScap.Items.Clear()
        LstRework.Items.Clear()
        LstAccpeted.Items.Clear()
    End Sub

    Private Sub btnMeasurement_Click(sender As Object, e As EventArgs) Handles btnMeasurement.Click

        'declaring the varible 
        Dim FilePath As String

        'calling the clear list function
        clearlist()

        'assigning the path to the varible

        FilePath = "C:\Users\aksha\OneDrive - Conestoga College\Measurements.txt"
        srMeasure = File.OpenText(FilePath)

        'calling the sort part procedure
        Sortpart()

        'closing the file
        srMeasure.Close()
        srMeasure.Dispose()

    End Sub

    'sortpart procedure
    Sub Sortpart()

        'declaration of the varible
        Dim MaxSize, MinSize, PartSize As Double

        'calling CalcMaxsize and CalcMinsize function
        MaxSize = CalcMaxsize()
        MinSize = CalcMinsize()
        Do While srMeasure.EndOfStream = False

            'spliting and storing the value to the array
            myArray = srMeasure.ReadLine().Split(",")
            PartSize = Double.Parse(myArray(1))

            'checking the condtions for the various size and diplay the value to the list box
            If PartSize < MinSize Then
                LstScap.Items.Add("(" & myArray(0) & ") " & myArray(1) & " mm")
                LstScap.Items.Add(vbCrLf)

            ElseIf PartSize > MaxSize Then
                LstRework.Items.Add("(" & myArray(0) & ") " & myArray(1) & " mm")
                LstRework.Items.Add(vbCrLf)

            Else
                LstAccpeted.Items.Add("(" & myArray(0) & ") " & myArray(1) & " mm")
                LstAccpeted.Items.Add(vbCrLf)
            End If



        Loop
    End Sub
    'when Quit button is pressed program closes
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
