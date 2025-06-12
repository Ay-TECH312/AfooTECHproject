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
        Dim calculate_btn As System.Windows.Forms.Button
        Dim calc_btn As System.Windows.Forms.Button
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Result_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.first_num_txt = New System.Windows.Forms.TextBox()
        Me.second_num_txt = New System.Windows.Forms.TextBox()
        calculate_btn = New System.Windows.Forms.Button()
        calc_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calculate_btn
        '
        calculate_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        calculate_btn.BackColor = System.Drawing.SystemColors.ControlDark
        calculate_btn.FlatAppearance.BorderSize = 0
        calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        calculate_btn.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        calculate_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        calculate_btn.Location = New System.Drawing.Point(96, 359)
        calculate_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        calculate_btn.Name = "calculate_btn"
        calculate_btn.Size = New System.Drawing.Size(332, 50)
        calculate_btn.TabIndex = 16
        calculate_btn.Text = "CALCULATE"
        calculate_btn.UseVisualStyleBackColor = False
        '
        'calc_btn
        '
        calc_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        calc_btn.FlatAppearance.BorderSize = 0
        calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        calc_btn.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        calc_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        calc_btn.Location = New System.Drawing.Point(84, 359)
        calc_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        calc_btn.Name = "calc_btn"
        calc_btn.Size = New System.Drawing.Size(364, 50)
        calc_btn.TabIndex = 16
        calc_btn.Text = "CALCULATE"
        calc_btn.UseVisualStyleBackColor = False
        AddHandler calc_btn.Click, AddressOf Me.calc_btn_Click
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_btn.Location = New System.Drawing.Point(331, 481)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(112, 44)
        Me.clear_btn.TabIndex = 19
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Result_txt
        '
        Me.Result_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Result_txt.BackColor = System.Drawing.Color.White
        Me.Result_txt.Enabled = False
        Me.Result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_txt.Location = New System.Drawing.Point(84, 479)
        Me.Result_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Result_txt.Name = "Result_txt"
        Me.Result_txt.Size = New System.Drawing.Size(209, 44)
        Me.Result_txt.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Result"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(96, 260)
        Me.second_no_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(332, 48)
        Me.second_no_txt.TabIndex = 15
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.first_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(96, 131)
        Me.first_no_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(332, 50)
        Me.first_no_txt.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = " Enter First Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Enter Second Number"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DIVISION OF TWO NUMBER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'first_num_txt
        '
        Me.first_num_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.first_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_num_txt.Location = New System.Drawing.Point(84, 131)
        Me.first_num_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.first_num_txt.Multiline = True
        Me.first_num_txt.Name = "first_num_txt"
        Me.first_num_txt.Size = New System.Drawing.Size(364, 50)
        Me.first_num_txt.TabIndex = 14
        '
        'second_num_txt
        '
        Me.second_num_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.second_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_num_txt.Location = New System.Drawing.Point(84, 260)
        Me.second_num_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.second_num_txt.Multiline = True
        Me.second_num_txt.Name = "second_num_txt"
        Me.second_num_txt.Size = New System.Drawing.Size(364, 48)
        Me.second_num_txt.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 601)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Result_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(calc_btn)
        Me.Controls.Add(calculate_btn)
        Me.Controls.Add(Me.second_num_txt)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.first_num_txt)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents first_num_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_num_txt As System.Windows.Forms.TextBox

End Class
