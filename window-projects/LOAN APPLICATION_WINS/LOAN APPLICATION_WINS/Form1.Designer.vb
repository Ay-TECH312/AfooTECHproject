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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.loan_duration_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loan_amount_txt = New System.Windows.Forms.TextBox()
        Me.lstRepaymentDetails = New System.Windows.Forms.ListBox()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.total_monthly_repayment_txt = New System.Windows.Forms.TextBox()
        Me.total_monthly_duration_txt = New System.Windows.Forms.Label()
        Me.total_interest_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOAN APPLICATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter loan amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.loan_duration_txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.loan_amount_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 92)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputut value to calculate"
        '
        'loan_duration_txt
        '
        Me.loan_duration_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.loan_duration_txt.Location = New System.Drawing.Point(254, 50)
        Me.loan_duration_txt.Multiline = True
        Me.loan_duration_txt.Name = "loan_duration_txt"
        Me.loan_duration_txt.Size = New System.Drawing.Size(127, 33)
        Me.loan_duration_txt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter loan Duration"
        '
        'loan_amount_txt
        '
        Me.loan_amount_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.loan_amount_txt.Location = New System.Drawing.Point(12, 49)
        Me.loan_amount_txt.Multiline = True
        Me.loan_amount_txt.Name = "loan_amount_txt"
        Me.loan_amount_txt.Size = New System.Drawing.Size(208, 34)
        Me.loan_amount_txt.TabIndex = 2
        '
        'lstRepaymentDetails
        '
        Me.lstRepaymentDetails.Enabled = False
        Me.lstRepaymentDetails.FormattingEnabled = True
        Me.lstRepaymentDetails.ItemHeight = 25
        Me.lstRepaymentDetails.Location = New System.Drawing.Point(20, 242)
        Me.lstRepaymentDetails.Name = "lstRepaymentDetails"
        Me.lstRepaymentDetails.Size = New System.Drawing.Size(436, 204)
        Me.lstRepaymentDetails.TabIndex = 8
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.Location = New System.Drawing.Point(74, 179)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(327, 38)
        Me.calculate_btn.TabIndex = 6
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.total_monthly_repayment_txt)
        Me.GroupBox3.Controls.Add(Me.total_monthly_duration_txt)
        Me.GroupBox3.Controls.Add(Me.total_interest_txt)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 459)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 81)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        '
        'total_monthly_repayment_txt
        '
        Me.total_monthly_repayment_txt.BackColor = System.Drawing.Color.White
        Me.total_monthly_repayment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_monthly_repayment_txt.Enabled = False
        Me.total_monthly_repayment_txt.Location = New System.Drawing.Point(173, 43)
        Me.total_monthly_repayment_txt.Multiline = True
        Me.total_monthly_repayment_txt.Name = "total_monthly_repayment_txt"
        Me.total_monthly_repayment_txt.Size = New System.Drawing.Size(173, 33)
        Me.total_monthly_repayment_txt.TabIndex = 4
        '
        'total_monthly_duration_txt
        '
        Me.total_monthly_duration_txt.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_monthly_duration_txt.Location = New System.Drawing.Point(175, 23)
        Me.total_monthly_duration_txt.Name = "total_monthly_duration_txt"
        Me.total_monthly_duration_txt.Size = New System.Drawing.Size(200, 25)
        Me.total_monthly_duration_txt.TabIndex = 3
        Me.total_monthly_duration_txt.Text = "Total Monthly Repayment"
        '
        'total_interest_txt
        '
        Me.total_interest_txt.BackColor = System.Drawing.Color.White
        Me.total_interest_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_interest_txt.Enabled = False
        Me.total_interest_txt.Location = New System.Drawing.Point(12, 42)
        Me.total_interest_txt.Multiline = True
        Me.total_interest_txt.Name = "total_interest_txt"
        Me.total_interest_txt.Size = New System.Drawing.Size(144, 34)
        Me.total_interest_txt.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Interest"
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatAppearance.BorderSize = 0
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(380, 495)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(76, 40)
        Me.clear_btn.TabIndex = 7
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(491, 603)
        Me.Controls.Add(Me.lstRepaymentDetails)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SOFTWARE FOR LOAN APPLICATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents loan_duration_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents loan_amount_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents total_monthly_repayment_txt As System.Windows.Forms.TextBox
    Friend WithEvents total_monthly_duration_txt As System.Windows.Forms.Label
    Friend WithEvents total_interest_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents lstRepaymentDetails As System.Windows.Forms.ListBox

End Class
