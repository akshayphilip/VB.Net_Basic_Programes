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
        Me.txtMass = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtAngleChange = New System.Windows.Forms.TextBox()
        Me.xtNumOfPos = New System.Windows.Forms.TextBox()
        Me.LstAngles = New System.Windows.Forms.ListBox()
        Me.LstMoments = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mass (kg):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Length (m):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Angle Change (deg):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Positions:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Angle (deg)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(637, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Moment (N-m)"
        '
        'txtMass
        '
        Me.txtMass.Location = New System.Drawing.Point(335, 89)
        Me.txtMass.Name = "txtMass"
        Me.txtMass.Size = New System.Drawing.Size(100, 22)
        Me.txtMass.TabIndex = 6
        Me.txtMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(335, 143)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 22)
        Me.txtLength.TabIndex = 7
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAngleChange
        '
        Me.txtAngleChange.Location = New System.Drawing.Point(335, 207)
        Me.txtAngleChange.Name = "txtAngleChange"
        Me.txtAngleChange.Size = New System.Drawing.Size(100, 22)
        Me.txtAngleChange.TabIndex = 8
        Me.txtAngleChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'xtNumOfPos
        '
        Me.xtNumOfPos.Location = New System.Drawing.Point(335, 253)
        Me.xtNumOfPos.Name = "xtNumOfPos"
        Me.xtNumOfPos.Size = New System.Drawing.Size(100, 22)
        Me.xtNumOfPos.TabIndex = 9
        Me.xtNumOfPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LstAngles
        '
        Me.LstAngles.FormattingEnabled = True
        Me.LstAngles.ItemHeight = 16
        Me.LstAngles.Location = New System.Drawing.Point(463, 43)
        Me.LstAngles.Name = "LstAngles"
        Me.LstAngles.Size = New System.Drawing.Size(139, 308)
        Me.LstAngles.TabIndex = 10
        '
        'LstMoments
        '
        Me.LstMoments.FormattingEnabled = True
        Me.LstMoments.ItemHeight = 16
        Me.LstMoments.Location = New System.Drawing.Point(640, 43)
        Me.LstMoments.Name = "LstMoments"
        Me.LstMoments.Size = New System.Drawing.Size(139, 308)
        Me.LstMoments.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(178, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(335, 328)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.LstMoments)
        Me.Controls.Add(Me.LstAngles)
        Me.Controls.Add(Me.xtNumOfPos)
        Me.Controls.Add(Me.txtAngleChange)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtMass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load Moments on a Beam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMass As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtAngleChange As TextBox
    Friend WithEvents xtNumOfPos As TextBox
    Friend WithEvents LstAngles As ListBox
    Friend WithEvents LstMoments As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnQuit As Button
End Class
