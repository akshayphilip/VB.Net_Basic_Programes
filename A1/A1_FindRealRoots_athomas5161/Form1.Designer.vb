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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLRootX1 = New System.Windows.Forms.Label()
        Me.LBLRootX2 = New System.Windows.Forms.Label()
        Me.txtCoeffA = New System.Windows.Forms.TextBox()
        Me.txtCoeffB = New System.Windows.Forms.TextBox()
        Me.txtCoeffC = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.RootBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Three Coefficients:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "a ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "b ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "c ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "The Real Roots are:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "x1 ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "x2 ="
        '
        'LBLRootX1
        '
        Me.LBLRootX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLRootX1.Location = New System.Drawing.Point(116, 223)
        Me.LBLRootX1.Name = "LBLRootX1"
        Me.LBLRootX1.Size = New System.Drawing.Size(100, 23)
        Me.LBLRootX1.TabIndex = 7
        Me.LBLRootX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLRootX2
        '
        Me.LBLRootX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLRootX2.Location = New System.Drawing.Point(297, 223)
        Me.LBLRootX2.Name = "LBLRootX2"
        Me.LBLRootX2.Size = New System.Drawing.Size(100, 23)
        Me.LBLRootX2.TabIndex = 8
        Me.LBLRootX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCoeffA
        '
        Me.txtCoeffA.Location = New System.Drawing.Point(121, 112)
        Me.txtCoeffA.Name = "txtCoeffA"
        Me.txtCoeffA.Size = New System.Drawing.Size(100, 22)
        Me.txtCoeffA.TabIndex = 9
        '
        'txtCoeffB
        '
        Me.txtCoeffB.Location = New System.Drawing.Point(297, 110)
        Me.txtCoeffB.Name = "txtCoeffB"
        Me.txtCoeffB.Size = New System.Drawing.Size(100, 22)
        Me.txtCoeffB.TabIndex = 10
        '
        'txtCoeffC
        '
        Me.txtCoeffC.Location = New System.Drawing.Point(487, 107)
        Me.txtCoeffC.Name = "txtCoeffC"
        Me.txtCoeffC.Size = New System.Drawing.Size(100, 22)
        Me.txtCoeffC.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(116, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(349, 326)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'RootBox
        '
        Me.RootBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RootBox.Location = New System.Drawing.Point(116, 266)
        Me.RootBox.Name = "RootBox"
        Me.RootBox.Size = New System.Drawing.Size(461, 40)
        Me.RootBox.TabIndex = 14
        Me.RootBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RootBox)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCoeffC)
        Me.Controls.Add(Me.txtCoeffB)
        Me.Controls.Add(Me.txtCoeffA)
        Me.Controls.Add(Me.LBLRootX2)
        Me.Controls.Add(Me.LBLRootX1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment #1: Find Real Roots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLRootX1 As Label
    Friend WithEvents LBLRootX2 As Label
    Friend WithEvents txtCoeffA As TextBox
    Friend WithEvents txtCoeffB As TextBox
    Friend WithEvents txtCoeffC As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents RootBox As Label
End Class
