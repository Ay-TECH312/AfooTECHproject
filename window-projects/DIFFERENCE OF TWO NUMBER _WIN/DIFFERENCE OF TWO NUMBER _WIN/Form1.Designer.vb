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
        Dim calc_btn As System.Windows.Forms.Button
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Result_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.second_num_txt = New System.Windows.Forms.TextBox()
        Me.first_num_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        calc_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_btn.Location = New System.Drawing.Point(291, 376)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(100, 35)
        Me.clear_btn.TabIndex = 28
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Result_txt
        '
        Me.Result_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Result_txt.BackColor = System.Drawing.Color.White
        Me.Result_txt.Enabled = False
        Me.Result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_txt.Location = New System.Drawing.Point(67, 374)
        Me.Result_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Result_txt.Name = "Result_txt"
        Me.Result_txt.Size = New System.Drawing.Size(186, 38)
        Me.Result_txt.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 26)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Result"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'calc_btn
        '
        calc_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        calc_btn.FlatAppearance.BorderSize = 0
        calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        calc_btn.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        calc_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        calc_btn.Location = New System.Drawing.Point(72, 278)
        calc_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        calc_btn.Name = "calc_btn"
        calc_btn.Size = New System.Drawing.Size(324, 40)
        calc_btn.TabIndex = 25
        calc_btn.Text = "CALCULATE"
        calc_btn.UseVisualStyleBackColor = False
        AddHandler calc_btn.Click, AddressOf Me.calc_btn_Click
        '
        'second_num_txt
        '
        Me.second_num_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.second_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_num_txt.Location = New System.Drawing.Point(72, 199)
        Me.second_num_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.second_num_txt.Multiline = True
        Me.second_num_txt.Name = "second_num_txt"
        Me.second_num_txt.Size = New System.Drawing.Size(324, 38)
        Me.second_num_txt.TabIndex = 24
        '
        'first_num_txt
        '
        Me.first_num_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.first_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_num_txt.Location = New System.Drawing.Point(72, 96)
        Me.first_num_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.first_num_txt.Multiline = True
        Me.first_num_txt.Name = "first_num_txt"
        Me.first_num_txt.Size = New System.Drawing.Size(324, 40)
        Me.first_num_txt.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = " Enter First Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter Second Number"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "DIFFERENCE OF TWO NUMBER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 458)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Result_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(calc_btn)
        Me.Controls.Add(Me.second_num_txt)
        Me.Controls.Add(Me.first_num_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents second_num_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_num_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
