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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Result_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        calculate_btn = New System.Windows.Forms.Button()
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
        calculate_btn.Location = New System.Drawing.Point(87, 275)
        calculate_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        calculate_btn.Name = "calculate_btn"
        calculate_btn.Size = New System.Drawing.Size(280, 40)
        calculate_btn.TabIndex = 6
        calculate_btn.Text = "CALCULATE"
        calculate_btn.UseVisualStyleBackColor = False
        AddHandler calculate_btn.Click, AddressOf Me.Button1_Click
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT OF TWO NUMBER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 22)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " Enter First Number"
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.first_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(87, 93)
        Me.first_no_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(280, 40)
        Me.first_no_txt.TabIndex = 4
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(87, 196)
        Me.second_no_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(280, 38)
        Me.second_no_txt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Result"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Result_txt
        '
        Me.Result_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Result_txt.BackColor = System.Drawing.Color.White
        Me.Result_txt.Enabled = False
        Me.Result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_txt.Location = New System.Drawing.Point(82, 371)
        Me.Result_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Result_txt.Name = "Result_txt"
        Me.Result_txt.Size = New System.Drawing.Size(186, 38)
        Me.Result_txt.TabIndex = 9
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_btn.Location = New System.Drawing.Point(290, 373)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(77, 35)
        Me.clear_btn.TabIndex = 10
        Me.clear_btn.Text = "clear"
        Me.clear_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(452, 470)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Result_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(calculate_btn)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = " PRODUCT OF TWO NUMBER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Result_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button

End Class
