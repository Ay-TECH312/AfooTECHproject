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
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.sum_btn = New System.Windows.Forms.Button()
        Me.product_btn = New System.Windows.Forms.Button()
        Me.minus_btn = New System.Windows.Forms.Button()
        Me.division_btn = New System.Windows.Forms.Button()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.calc_btn_txt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.operator_txt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIMPLE CALCULATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter First Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.first_no_txt.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(23, 112)
        Me.first_no_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(331, 43)
        Me.first_no_txt.TabIndex = 3
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.second_no_txt.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(22, 286)
        Me.second_no_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(331, 43)
        Me.second_no_txt.TabIndex = 4
        '
        'sum_btn
        '
        Me.sum_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.sum_btn.FlatAppearance.BorderSize = 0
        Me.sum_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sum_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum_btn.Location = New System.Drawing.Point(22, 169)
        Me.sum_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sum_btn.Name = "sum_btn"
        Me.sum_btn.Size = New System.Drawing.Size(61, 50)
        Me.sum_btn.TabIndex = 7
        Me.sum_btn.Text = "+"
        Me.sum_btn.UseVisualStyleBackColor = False
        '
        'product_btn
        '
        Me.product_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.product_btn.FlatAppearance.BorderSize = 0
        Me.product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.product_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_btn.Location = New System.Drawing.Point(107, 169)
        Me.product_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.product_btn.Name = "product_btn"
        Me.product_btn.Size = New System.Drawing.Size(64, 50)
        Me.product_btn.TabIndex = 7
        Me.product_btn.Text = "x"
        Me.product_btn.UseVisualStyleBackColor = False
        '
        'minus_btn
        '
        Me.minus_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.minus_btn.FlatAppearance.BorderSize = 0
        Me.minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus_btn.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus_btn.Location = New System.Drawing.Point(195, 169)
        Me.minus_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minus_btn.Name = "minus_btn"
        Me.minus_btn.Size = New System.Drawing.Size(64, 50)
        Me.minus_btn.TabIndex = 7
        Me.minus_btn.Text = "-"
        Me.minus_btn.UseVisualStyleBackColor = False
        '
        'division_btn
        '
        Me.division_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.division_btn.FlatAppearance.BorderSize = 0
        Me.division_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.division_btn.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.division_btn.Location = New System.Drawing.Point(289, 169)
        Me.division_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.division_btn.Name = "division_btn"
        Me.division_btn.Size = New System.Drawing.Size(60, 50)
        Me.division_btn.TabIndex = 7
        Me.division_btn.Text = "/"
        Me.division_btn.UseVisualStyleBackColor = False
        '
        'result_txt
        '
        Me.result_txt.BackColor = System.Drawing.Color.White
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.ForeColor = System.Drawing.Color.Black
        Me.result_txt.Location = New System.Drawing.Point(23, 451)
        Me.result_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(175, 43)
        Me.result_txt.TabIndex = 10
        '
        'calc_btn_txt
        '
        Me.calc_btn_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.calc_btn_txt.BackColor = System.Drawing.Color.Silver
        Me.calc_btn_txt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.calc_btn_txt.FlatAppearance.BorderSize = 0
        Me.calc_btn_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.calc_btn_txt.Location = New System.Drawing.Point(22, 346)
        Me.calc_btn_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.calc_btn_txt.Name = "calc_btn_txt"
        Me.calc_btn_txt.Size = New System.Drawing.Size(331, 53)
        Me.calc_btn_txt.TabIndex = 12
        Me.calc_btn_txt.Text = "CALCULATE"
        Me.calc_btn_txt.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 243)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 42)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Enter Second Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 404)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.SaddleBrown
        Me.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.clear.Location = New System.Drawing.Point(223, 451)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(131, 43)
        Me.clear.TabIndex = 11
        Me.clear.Text = "CLEAR"
        Me.clear.UseVisualStyleBackColor = False
        '
        'operator_txt
        '
        Me.operator_txt.BackColor = System.Drawing.Color.Transparent
        Me.operator_txt.Enabled = False
        Me.operator_txt.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operator_txt.Location = New System.Drawing.Point(22, 224)
        Me.operator_txt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.operator_txt.Name = "operator_txt"
        Me.operator_txt.Size = New System.Drawing.Size(327, 19)
        Me.operator_txt.TabIndex = 15
        Me.operator_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.operator_txt.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(379, 524)
        Me.Controls.Add(Me.operator_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.calc_btn_txt)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.division_btn)
        Me.Controls.Add(Me.minus_btn)
        Me.Controls.Add(Me.product_btn)
        Me.Controls.Add(Me.sum_btn)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPLE CALCULATOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents sum_btn As System.Windows.Forms.Button
    Friend WithEvents product_btn As System.Windows.Forms.Button
    Friend WithEvents minus_btn As System.Windows.Forms.Button
    Friend WithEvents division_btn As System.Windows.Forms.Button
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents calc_btn_txt As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents operator_txt As System.Windows.Forms.Label

End Class
