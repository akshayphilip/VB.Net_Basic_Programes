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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad500 = New System.Windows.Forms.RadioButton()
        Me.rad125 = New System.Windows.Forms.RadioButton()
        Me.rad375 = New System.Windows.Forms.RadioButton()
        Me.rad250 = New System.Windows.Forms.RadioButton()
        Me.cboMinStockSize = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMaxStockSize = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudMaxAllowedSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCuttingSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LstResults = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudMaxAllowedSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCuttingSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad500)
        Me.GroupBox1.Controls.Add(Me.rad125)
        Me.GroupBox1.Controls.Add(Me.rad375)
        Me.GroupBox1.Controls.Add(Me.rad250)
        Me.GroupBox1.Location = New System.Drawing.Point(529, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 190)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Size Increment"
        '
        'rad500
        '
        Me.rad500.AutoSize = True
        Me.rad500.Location = New System.Drawing.Point(17, 144)
        Me.rad500.Name = "rad500"
        Me.rad500.Size = New System.Drawing.Size(87, 21)
        Me.rad500.TabIndex = 4
        Me.rad500.TabStop = True
        Me.rad500.Text = ".500 inch"
        Me.rad500.UseVisualStyleBackColor = True
        '
        'rad125
        '
        Me.rad125.AutoSize = True
        Me.rad125.Location = New System.Drawing.Point(17, 34)
        Me.rad125.Name = "rad125"
        Me.rad125.Size = New System.Drawing.Size(87, 21)
        Me.rad125.TabIndex = 1
        Me.rad125.TabStop = True
        Me.rad125.Text = ".125 inch"
        Me.rad125.UseVisualStyleBackColor = True
        '
        'rad375
        '
        Me.rad375.AutoSize = True
        Me.rad375.Location = New System.Drawing.Point(17, 107)
        Me.rad375.Name = "rad375"
        Me.rad375.Size = New System.Drawing.Size(87, 21)
        Me.rad375.TabIndex = 3
        Me.rad375.TabStop = True
        Me.rad375.Text = ".375 inch"
        Me.rad375.UseVisualStyleBackColor = True
        '
        'rad250
        '
        Me.rad250.AutoSize = True
        Me.rad250.Location = New System.Drawing.Point(17, 70)
        Me.rad250.Name = "rad250"
        Me.rad250.Size = New System.Drawing.Size(87, 21)
        Me.rad250.TabIndex = 2
        Me.rad250.TabStop = True
        Me.rad250.Text = ".250 inch"
        Me.rad250.UseVisualStyleBackColor = True
        '
        'cboMinStockSize
        '
        Me.cboMinStockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinStockSize.FormattingEnabled = True
        Me.cboMinStockSize.Items.AddRange(New Object() {".250", ".500", ".750", "1.000", "1.250", "1.500", "1.750", "2.000", "2.250", "2.500", "2.750", "3.000", "3.250", "3.500", "3.750", "4.000"})
        Me.cboMinStockSize.Location = New System.Drawing.Point(235, 6)
        Me.cboMinStockSize.Name = "cboMinStockSize"
        Me.cboMinStockSize.Size = New System.Drawing.Size(121, 24)
        Me.cboMinStockSize.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Minimum Stock Size (inches)"
        '
        'cboMaxStockSize
        '
        Me.cboMaxStockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaxStockSize.FormattingEnabled = True
        Me.cboMaxStockSize.Items.AddRange(New Object() {".500", ".750", "1.000", "1.250", "1.500", "1.750", "2.000", "2.250", "2.500", "2.750", "3.000", "3.250", "3.500", "3.750", "4.000"})
        Me.cboMaxStockSize.Location = New System.Drawing.Point(236, 41)
        Me.cboMaxStockSize.Name = "cboMaxStockSize"
        Me.cboMaxStockSize.Size = New System.Drawing.Size(121, 24)
        Me.cboMaxStockSize.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maximum Stock Size (inches)"
        '
        'nudMaxAllowedSpeed
        '
        Me.nudMaxAllowedSpeed.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudMaxAllowedSpeed.Location = New System.Drawing.Point(239, 78)
        Me.nudMaxAllowedSpeed.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudMaxAllowedSpeed.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudMaxAllowedSpeed.Name = "nudMaxAllowedSpeed"
        Me.nudMaxAllowedSpeed.Size = New System.Drawing.Size(120, 22)
        Me.nudMaxAllowedSpeed.TabIndex = 5
        Me.nudMaxAllowedSpeed.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Maximum Spindle Speed (rpm)"
        '
        'nudCuttingSpeed
        '
        Me.nudCuttingSpeed.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudCuttingSpeed.Location = New System.Drawing.Point(236, 113)
        Me.nudCuttingSpeed.Maximum = New Decimal(New Integer() {160, 0, 0, 0})
        Me.nudCuttingSpeed.Minimum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.nudCuttingSpeed.Name = "nudCuttingSpeed"
        Me.nudCuttingSpeed.Size = New System.Drawing.Size(120, 22)
        Me.nudCuttingSpeed.TabIndex = 7
        Me.nudCuttingSpeed.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cutting Speed (ft/min)"
        '
        'LstResults
        '
        Me.LstResults.FormattingEnabled = True
        Me.LstResults.ItemHeight = 16
        Me.LstResults.Location = New System.Drawing.Point(15, 215)
        Me.LstResults.Name = "LstResults"
        Me.LstResults.Size = New System.Drawing.Size(412, 228)
        Me.LstResults.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(9, 151)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(157, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(235, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(357, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "RPM required for selected cutting speed and diameter :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.LstResults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudCuttingSpeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudMaxAllowedSpeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMaxStockSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMinStockSize)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spindle Speed Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudMaxAllowedSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCuttingSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad500 As RadioButton
    Friend WithEvents rad125 As RadioButton
    Friend WithEvents rad375 As RadioButton
    Friend WithEvents rad250 As RadioButton
    Friend WithEvents cboMinStockSize As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMaxStockSize As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudMaxAllowedSpeed As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudCuttingSpeed As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents LstResults As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
End Class
