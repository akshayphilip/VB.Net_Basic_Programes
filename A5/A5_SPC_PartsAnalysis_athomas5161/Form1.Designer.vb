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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNominalSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudUpperTol = New System.Windows.Forms.NumericUpDown()
        Me.nudLowerTol = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LstRework = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LstAccpeted = New System.Windows.Forms.ListBox()
        Me.LstScap = New System.Windows.Forms.ListBox()
        Me.btnMeasurement = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudUpperTol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLowerTol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNominalSize)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nudUpperTol)
        Me.GroupBox1.Controls.Add(Me.nudLowerTol)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machining Specs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nominal Size:"
        '
        'txtNominalSize
        '
        Me.txtNominalSize.Location = New System.Drawing.Point(120, 27)
        Me.txtNominalSize.Name = "txtNominalSize"
        Me.txtNominalSize.Size = New System.Drawing.Size(100, 22)
        Me.txtNominalSize.TabIndex = 4
        Me.txtNominalSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Upper Tolerance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lower Tolerance:"
        '
        'nudUpperTol
        '
        Me.nudUpperTol.DecimalPlaces = 3
        Me.nudUpperTol.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudUpperTol.Location = New System.Drawing.Point(461, 28)
        Me.nudUpperTol.Maximum = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudUpperTol.Name = "nudUpperTol"
        Me.nudUpperTol.Size = New System.Drawing.Size(120, 22)
        Me.nudUpperTol.TabIndex = 5
        Me.nudUpperTol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudLowerTol
        '
        Me.nudLowerTol.DecimalPlaces = 3
        Me.nudLowerTol.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.nudLowerTol.Location = New System.Drawing.Point(461, 72)
        Me.nudLowerTol.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudLowerTol.Minimum = New Decimal(New Integer() {5, 0, 0, -2147352576})
        Me.nudLowerTol.Name = "nudLowerTol"
        Me.nudLowerTol.Size = New System.Drawing.Size(120, 22)
        Me.nudLowerTol.TabIndex = 6
        Me.nudLowerTol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LstRework)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LstAccpeted)
        Me.GroupBox2.Controls.Add(Me.LstScap)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 209)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sorted Sizes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Scrap:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Accepted:"
        '
        'LstRework
        '
        Me.LstRework.FormattingEnabled = True
        Me.LstRework.ItemHeight = 16
        Me.LstRework.Location = New System.Drawing.Point(497, 38)
        Me.LstRework.Name = "LstRework"
        Me.LstRework.Size = New System.Drawing.Size(165, 148)
        Me.LstRework.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Reworkable:"
        '
        'LstAccpeted
        '
        Me.LstAccpeted.FormattingEnabled = True
        Me.LstAccpeted.ItemHeight = 16
        Me.LstAccpeted.Location = New System.Drawing.Point(252, 38)
        Me.LstAccpeted.Name = "LstAccpeted"
        Me.LstAccpeted.Size = New System.Drawing.Size(162, 148)
        Me.LstAccpeted.TabIndex = 12
        '
        'LstScap
        '
        Me.LstScap.FormattingEnabled = True
        Me.LstScap.ItemHeight = 16
        Me.LstScap.Location = New System.Drawing.Point(6, 38)
        Me.LstScap.Name = "LstScap"
        Me.LstScap.Size = New System.Drawing.Size(183, 148)
        Me.LstScap.TabIndex = 11
        '
        'btnMeasurement
        '
        Me.btnMeasurement.Location = New System.Drawing.Point(278, 372)
        Me.btnMeasurement.Name = "btnMeasurement"
        Me.btnMeasurement.Size = New System.Drawing.Size(213, 30)
        Me.btnMeasurement.TabIndex = 14
        Me.btnMeasurement.Text = "Get Measurements"
        Me.btnMeasurement.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(542, 372)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(105, 30)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMeasurement)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Size Sorter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudUpperTol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLowerTol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNominalSize As TextBox
    Friend WithEvents nudUpperTol As NumericUpDown
    Friend WithEvents nudLowerTol As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LstScap As ListBox
    Friend WithEvents LstAccpeted As ListBox
    Friend WithEvents LstRework As ListBox
    Friend WithEvents btnMeasurement As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
