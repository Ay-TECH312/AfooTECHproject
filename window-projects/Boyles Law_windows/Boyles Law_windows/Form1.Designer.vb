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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.p1_btn = New System.Windows.Forms.Button()
        Me.p2_btn = New System.Windows.Forms.Button()
        Me.v1_btn = New System.Windows.Forms.Button()
        Me.v2_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.v2_txt = New System.Windows.Forms.TextBox()
        Me.p2_txt = New System.Windows.Forms.TextBox()
        Me.v1_txt = New System.Windows.Forms.TextBox()
        Me.p1_txt = New System.Windows.Forms.TextBox()
        Me.v2_Label = New System.Windows.Forms.Label()
        Me.p2_Label = New System.Windows.Forms.Label()
        Me.v1_Label = New System.Windows.Forms.Label()
        Me.p1_Label = New System.Windows.Forms.Label()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOYLE'S LAW CALCULATOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.p1_btn)
        Me.GroupBox1.Controls.Add(Me.p2_btn)
        Me.GroupBox1.Controls.Add(Me.v1_btn)
        Me.GroupBox1.Controls.Add(Me.v2_btn)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Value To Calculate"
        '
        'p1_btn
        '
        Me.p1_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.p1_btn.FlatAppearance.BorderSize = 0
        Me.p1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p1_btn.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_btn.Location = New System.Drawing.Point(23, 25)
        Me.p1_btn.Name = "p1_btn"
        Me.p1_btn.Size = New System.Drawing.Size(223, 69)
        Me.p1_btn.TabIndex = 6
        Me.p1_btn.Text = "Initial Pressure(p1) (atm)  "
        Me.p1_btn.UseVisualStyleBackColor = False
        '
        'p2_btn
        '
        Me.p2_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.p2_btn.FlatAppearance.BorderSize = 0
        Me.p2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p2_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_btn.Location = New System.Drawing.Point(517, 25)
        Me.p2_btn.Name = "p2_btn"
        Me.p2_btn.Size = New System.Drawing.Size(224, 69)
        Me.p2_btn.TabIndex = 4
        Me.p2_btn.Text = "Final Pressure (p2) (atm)"
        Me.p2_btn.UseVisualStyleBackColor = False
        '
        'v1_btn
        '
        Me.v1_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.v1_btn.FlatAppearance.BorderSize = 0
        Me.v1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.v1_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1_btn.Location = New System.Drawing.Point(276, 25)
        Me.v1_btn.Name = "v1_btn"
        Me.v1_btn.Size = New System.Drawing.Size(221, 69)
        Me.v1_btn.TabIndex = 2
        Me.v1_btn.Text = "Initial Volume (v1) (ml)"
        Me.v1_btn.UseVisualStyleBackColor = False
        '
        'v2_btn
        '
        Me.v2_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.v2_btn.FlatAppearance.BorderSize = 0
        Me.v2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.v2_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2_btn.Location = New System.Drawing.Point(769, 25)
        Me.v2_btn.Name = "v2_btn"
        Me.v2_btn.Size = New System.Drawing.Size(205, 69)
        Me.v2_btn.TabIndex = 0
        Me.v2_btn.Text = "Final volume  (v2) (ml)"
        Me.v2_btn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.v2_txt)
        Me.GroupBox2.Controls.Add(Me.p2_txt)
        Me.GroupBox2.Controls.Add(Me.v1_txt)
        Me.GroupBox2.Controls.Add(Me.p1_txt)
        Me.GroupBox2.Controls.Add(Me.v2_Label)
        Me.GroupBox2.Controls.Add(Me.p2_Label)
        Me.GroupBox2.Controls.Add(Me.v1_Label)
        Me.GroupBox2.Controls.Add(Me.p1_Label)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(62, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 146)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Value To Calculate"
        '
        'v2_txt
        '
        Me.v2_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.v2_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v2_txt.BackColor = System.Drawing.Color.White
        Me.v2_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v2_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2_txt.Location = New System.Drawing.Point(769, 88)
        Me.v2_txt.Multiline = True
        Me.v2_txt.Name = "v2_txt"
        Me.v2_txt.Size = New System.Drawing.Size(205, 52)
        Me.v2_txt.TabIndex = 18
        '
        'p2_txt
        '
        Me.p2_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.p2_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p2_txt.BackColor = System.Drawing.Color.White
        Me.p2_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p2_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_txt.Location = New System.Drawing.Point(517, 88)
        Me.p2_txt.Multiline = True
        Me.p2_txt.Name = "p2_txt"
        Me.p2_txt.Size = New System.Drawing.Size(224, 52)
        Me.p2_txt.TabIndex = 17
        '
        'v1_txt
        '
        Me.v1_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.v1_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v1_txt.BackColor = System.Drawing.Color.White
        Me.v1_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v1_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1_txt.Location = New System.Drawing.Point(276, 88)
        Me.v1_txt.Multiline = True
        Me.v1_txt.Name = "v1_txt"
        Me.v1_txt.Size = New System.Drawing.Size(221, 52)
        Me.v1_txt.TabIndex = 16
        '
        'p1_txt
        '
        Me.p1_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.p1_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p1_txt.BackColor = System.Drawing.Color.White
        Me.p1_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p1_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_txt.Location = New System.Drawing.Point(23, 88)
        Me.p1_txt.Multiline = True
        Me.p1_txt.Name = "p1_txt"
        Me.p1_txt.Size = New System.Drawing.Size(223, 52)
        Me.p1_txt.TabIndex = 15
        '
        'v2_Label
        '
        Me.v2_Label.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2_Label.Location = New System.Drawing.Point(765, 35)
        Me.v2_Label.Name = "v2_Label"
        Me.v2_Label.Size = New System.Drawing.Size(205, 60)
        Me.v2_Label.TabIndex = 14
        Me.v2_Label.Text = "Final Volume (v2)"
        '
        'p2_Label
        '
        Me.p2_Label.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_Label.Location = New System.Drawing.Point(513, 35)
        Me.p2_Label.Name = "p2_Label"
        Me.p2_Label.Size = New System.Drawing.Size(228, 60)
        Me.p2_Label.TabIndex = 13
        Me.p2_Label.Text = "Final Pressure (p2)"
        '
        'v1_Label
        '
        Me.v1_Label.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1_Label.Location = New System.Drawing.Point(276, 35)
        Me.v1_Label.Name = "v1_Label"
        Me.v1_Label.Size = New System.Drawing.Size(221, 60)
        Me.v1_Label.TabIndex = 12
        Me.v1_Label.Text = "Initial Volume (v1)"
        '
        'p1_Label
        '
        Me.p1_Label.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_Label.Location = New System.Drawing.Point(19, 35)
        Me.p1_Label.Name = "p1_Label"
        Me.p1_Label.Size = New System.Drawing.Size(227, 60)
        Me.p1_Label.TabIndex = 11
        Me.p1_Label.Text = "Initial Pressure (p1)"
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.Location = New System.Drawing.Point(298, 388)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(560, 52)
        Me.calculate_btn.TabIndex = 3
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 56)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Result"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'result_txt
        '
        Me.result_txt.BackColor = System.Drawing.Color.White
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(231, 489)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(267, 56)
        Me.result_txt.TabIndex = 16
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatAppearance.BorderSize = 0
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(903, 489)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(157, 56)
        Me.clear_btn.TabIndex = 17
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 613)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "BOYLE'S LAW CALCULATOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents p1_btn As System.Windows.Forms.Button
    Friend WithEvents p2_btn As System.Windows.Forms.Button
    Friend WithEvents v1_btn As System.Windows.Forms.Button
    Friend WithEvents v2_btn As System.Windows.Forms.Button
    Friend WithEvents v2_txt As System.Windows.Forms.TextBox
    Friend WithEvents p2_txt As System.Windows.Forms.TextBox
    Friend WithEvents v1_txt As System.Windows.Forms.TextBox
    Friend WithEvents p1_txt As System.Windows.Forms.TextBox
    Friend WithEvents v2_Label As System.Windows.Forms.Label
    Friend WithEvents p2_Label As System.Windows.Forms.Label
    Friend WithEvents v1_Label As System.Windows.Forms.Label
    Friend WithEvents p1_Label As System.Windows.Forms.Label
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button

End Class
