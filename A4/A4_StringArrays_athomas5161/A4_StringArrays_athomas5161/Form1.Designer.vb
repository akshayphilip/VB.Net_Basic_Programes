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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.txtArray = New System.Windows.Forms.TextBox()
        Me.LstResults1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstResults2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblAvgresults = New System.Windows.Forms.Label()
        Me.LblTotResults = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(557, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert the String to Upper Case letters"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(557, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Display your student number"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(557, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Swap the order of the First and Last name"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(557, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Find the Total of All the Digits in the String"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LblResults
        '
        Me.LblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblResults.Location = New System.Drawing.Point(12, 274)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(557, 40)
        Me.LblResults.TabIndex = 4
        Me.LblResults.Text = "The results will be displayed in the label"
        Me.LblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtArray
        '
        Me.txtArray.Location = New System.Drawing.Point(21, 17)
        Me.txtArray.Name = "txtArray"
        Me.txtArray.Size = New System.Drawing.Size(557, 22)
        Me.txtArray.TabIndex = 5
        '
        'LstResults1
        '
        Me.LstResults1.FormattingEnabled = True
        Me.LstResults1.ItemHeight = 16
        Me.LstResults1.Location = New System.Drawing.Point(595, 54)
        Me.LstResults1.Name = "LstResults1"
        Me.LstResults1.Size = New System.Drawing.Size(159, 260)
        Me.LstResults1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(619, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Orginal Data"
        '
        'LstResults2
        '
        Me.LstResults2.FormattingEnabled = True
        Me.LstResults2.ItemHeight = 16
        Me.LstResults2.Location = New System.Drawing.Point(775, 54)
        Me.LstResults2.Name = "LstResults2"
        Me.LstResults2.Size = New System.Drawing.Size(146, 260)
        Me.LstResults2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(788, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sorted Data"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(595, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 34)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "List Orginal Data"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(775, 331)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(146, 34)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Sort Ascending"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(965, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Average :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(965, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 44)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "total no of parts:"
        '
        'LblAvgresults
        '
        Me.LblAvgresults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAvgresults.Location = New System.Drawing.Point(1050, 54)
        Me.LblAvgresults.Name = "LblAvgresults"
        Me.LblAvgresults.Size = New System.Drawing.Size(100, 23)
        Me.LblAvgresults.TabIndex = 14
        Me.LblAvgresults.Text = "0"
        Me.LblAvgresults.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotResults
        '
        Me.LblTotResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotResults.Location = New System.Drawing.Point(1050, 94)
        Me.LblTotResults.Name = "LblTotResults"
        Me.LblTotResults.Size = New System.Drawing.Size(100, 23)
        Me.LblTotResults.TabIndex = 15
        Me.LblTotResults.Text = "0"
        Me.LblTotResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(968, 141)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(166, 37)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Analysis"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.LblTotResults)
        Me.Controls.Add(Me.LblAvgresults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LstResults2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstResults1)
        Me.Controls.Add(Me.txtArray)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "String Parsing and Arrays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LblResults As Label
    Friend WithEvents txtArray As TextBox
    Friend WithEvents LstResults1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LstResults2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblAvgresults As Label
    Friend WithEvents LblTotResults As Label
    Friend WithEvents Button7 As Button
End Class
