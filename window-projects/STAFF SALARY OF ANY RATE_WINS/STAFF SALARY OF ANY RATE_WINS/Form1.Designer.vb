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
        Me.percentage = New System.Windows.Forms.Label()
        Me.salary = New System.Windows.Forms.Label()
        Me.salary_txt = New System.Windows.Forms.TextBox()
        Me.percentage_txt = New System.Windows.Forms.TextBox()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.total_balance_txt = New System.Windows.Forms.TextBox()
        Me.taxdeduction_txt = New System.Windows.Forms.TextBox()
        Me.taxdeduction = New System.Windows.Forms.Label()
        Me.total_amount = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Enabled = False
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF SALARY OF ANY RATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'percentage
        '
        Me.percentage.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage.ForeColor = System.Drawing.SystemColors.MenuText
        Me.percentage.Location = New System.Drawing.Point(38, 125)
        Me.percentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(235, 30)
        Me.percentage.TabIndex = 2
        Me.percentage.Text = "Enter Percentage"
        '
        'salary
        '
        Me.salary.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary.ForeColor = System.Drawing.SystemColors.MenuText
        Me.salary.Location = New System.Drawing.Point(40, 51)
        Me.salary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(235, 27)
        Me.salary.TabIndex = 4
        Me.salary.Text = "Enter Salary"
        '
        'salary_txt
        '
        Me.salary_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salary_txt.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary_txt.Location = New System.Drawing.Point(43, 73)
        Me.salary_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.salary_txt.Multiline = True
        Me.salary_txt.Name = "salary_txt"
        Me.salary_txt.Size = New System.Drawing.Size(282, 40)
        Me.salary_txt.TabIndex = 5
        '
        'percentage_txt
        '
        Me.percentage_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.percentage_txt.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage_txt.Location = New System.Drawing.Point(43, 149)
        Me.percentage_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.percentage_txt.Multiline = True
        Me.percentage_txt.Name = "percentage_txt"
        Me.percentage_txt.Size = New System.Drawing.Size(282, 39)
        Me.percentage_txt.TabIndex = 7
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.Color.Silver
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.calculate_btn.Location = New System.Drawing.Point(43, 198)
        Me.calculate_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(282, 37)
        Me.calculate_btn.TabIndex = 8
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.total_balance_txt)
        Me.GroupBox1.Controls.Add(Me.taxdeduction_txt)
        Me.GroupBox1.Controls.Add(Me.taxdeduction)
        Me.GroupBox1.Controls.Add(Me.total_amount)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(43, 251)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(209, 180)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'total_balance_txt
        '
        Me.total_balance_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_balance_txt.Enabled = False
        Me.total_balance_txt.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_balance_txt.Location = New System.Drawing.Point(8, 132)
        Me.total_balance_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.total_balance_txt.Multiline = True
        Me.total_balance_txt.Name = "total_balance_txt"
        Me.total_balance_txt.Size = New System.Drawing.Size(186, 48)
        Me.total_balance_txt.TabIndex = 11
        '
        'taxdeduction_txt
        '
        Me.taxdeduction_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxdeduction_txt.Enabled = False
        Me.taxdeduction_txt.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxdeduction_txt.Location = New System.Drawing.Point(8, 47)
        Me.taxdeduction_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.taxdeduction_txt.Multiline = True
        Me.taxdeduction_txt.Name = "taxdeduction_txt"
        Me.taxdeduction_txt.Size = New System.Drawing.Size(186, 43)
        Me.taxdeduction_txt.TabIndex = 10
        '
        'taxdeduction
        '
        Me.taxdeduction.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxdeduction.ForeColor = System.Drawing.SystemColors.MenuText
        Me.taxdeduction.Location = New System.Drawing.Point(5, 25)
        Me.taxdeduction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxdeduction.Name = "taxdeduction"
        Me.taxdeduction.Size = New System.Drawing.Size(235, 27)
        Me.taxdeduction.TabIndex = 9
        Me.taxdeduction.Text = "TaxDeduction"
        '
        'total_amount
        '
        Me.total_amount.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_amount.ForeColor = System.Drawing.SystemColors.MenuText
        Me.total_amount.Location = New System.Drawing.Point(5, 108)
        Me.total_amount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.total_amount.Name = "total_amount"
        Me.total_amount.Size = New System.Drawing.Size(235, 30)
        Me.total_amount.TabIndex = 8
        Me.total_amount.Text = "Total Amount"
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatAppearance.BorderSize = 0
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(256, 397)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(69, 34)
        Me.clear_btn.TabIndex = 11
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(364, 470)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.percentage_txt)
        Me.Controls.Add(Me.salary_txt)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SOFTWARE TO CALCULATE STAFF SALARY OF ANY RATE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents percentage As System.Windows.Forms.Label
    Friend WithEvents salary As System.Windows.Forms.Label
    Friend WithEvents salary_txt As System.Windows.Forms.TextBox
    Friend WithEvents percentage_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents total_balance_txt As System.Windows.Forms.TextBox
    Friend WithEvents taxdeduction_txt As System.Windows.Forms.TextBox
    Friend WithEvents taxdeduction As System.Windows.Forms.Label
    Friend WithEvents total_amount As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button

End Class
