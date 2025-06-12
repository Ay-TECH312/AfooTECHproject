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
        Me.number_txt = New System.Windows.Forms.TextBox()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.factorial_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTORIAL CALCULATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'number_txt
        '
        Me.number_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.number_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number_txt.Location = New System.Drawing.Point(51, 106)
        Me.number_txt.Multiline = True
        Me.number_txt.Name = "number_txt"
        Me.number_txt.Size = New System.Drawing.Size(387, 55)
        Me.number_txt.TabIndex = 2
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.Color.DarkGray
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.Location = New System.Drawing.Point(50, 188)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(388, 63)
        Me.calculate_btn.TabIndex = 3
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatAppearance.BorderSize = 0
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(330, 317)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(108, 59)
        Me.clear_btn.TabIndex = 5
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.factorial_txt)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 85)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'factorial_txt
        '
        Me.factorial_txt.BackColor = System.Drawing.Color.White
        Me.factorial_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.factorial_txt.Enabled = False
        Me.factorial_txt.Location = New System.Drawing.Point(17, 35)
        Me.factorial_txt.Multiline = True
        Me.factorial_txt.Name = "factorial_txt"
        Me.factorial_txt.Size = New System.Drawing.Size(250, 44)
        Me.factorial_txt.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(496, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.number_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SOFTWARE TO CALCULATE FACTORIAL NUMBER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents number_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents factorial_txt As System.Windows.Forms.TextBox

End Class
