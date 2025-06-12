<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sum of Two Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(68, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter first number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(68, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Enter second number"
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(73, 275)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(376, 63)
        Me.second_no_txt.TabIndex = 1
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.first_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(73, 125)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(376, 60)
        Me.first_no_txt.TabIndex = 1
        '
        'result_txt
        '
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(221, 494)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(228, 52)
        Me.result_txt.TabIndex = 1
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.Color.SlateGray
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.calculate_btn.Location = New System.Drawing.Point(73, 392)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(376, 72)
        Me.calculate_btn.TabIndex = 2
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(68, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Result"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(516, 576)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "form1"
        Me.Text = "Sum Of Two Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
