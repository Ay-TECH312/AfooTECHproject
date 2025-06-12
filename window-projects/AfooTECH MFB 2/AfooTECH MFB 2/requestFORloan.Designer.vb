<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requestFORloan
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.loan_duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loan_amount_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox2.Controls.Add(Me.loan_duration_txt)
        Me.GroupBox2.Controls.Add(Me.loan_amount_txt)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GroupBox2.Controls.Add(Me.clear_btn)
        Me.GroupBox2.Controls.Add(Me.submit_btn)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 64)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(500, 305)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOAN INFORMATION"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 28)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(268, 18)
        Me.Guna2HtmlLabel1.TabIndex = 38
        Me.Guna2HtmlLabel1.Text = "Loan Amount"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(25, 111)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(268, 18)
        Me.Guna2HtmlLabel2.TabIndex = 37
        Me.Guna2HtmlLabel2.Text = "Loan Duration"
        '
        'loan_duration_txt
        '
        Me.loan_duration_txt.BorderRadius = 5
        Me.loan_duration_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_duration_txt.DefaultText = ""
        Me.loan_duration_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_duration_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_duration_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration_txt.DisabledState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_duration_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.FocusedState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_duration_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.HoverState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Location = New System.Drawing.Point(23, 132)
        Me.loan_duration_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.loan_duration_txt.Name = "loan_duration_txt"
        Me.loan_duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_duration_txt.PlaceholderText = "0.00"
        Me.loan_duration_txt.SelectedText = ""
        Me.loan_duration_txt.ShadowDecoration.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Size = New System.Drawing.Size(447, 47)
        Me.loan_duration_txt.TabIndex = 29
        '
        'loan_amount_txt
        '
        Me.loan_amount_txt.BorderRadius = 5
        Me.loan_amount_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_amount_txt.DefaultText = ""
        Me.loan_amount_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_amount_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_amount_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_amount_txt.DisabledState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_amount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.FocusedState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_amount_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_amount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.HoverState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Location = New System.Drawing.Point(25, 48)
        Me.loan_amount_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.loan_amount_txt.Name = "loan_amount_txt"
        Me.loan_amount_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_amount_txt.PlaceholderText = "0:00"
        Me.loan_amount_txt.SelectedText = ""
        Me.loan_amount_txt.ShadowDecoration.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Size = New System.Drawing.Size(447, 47)
        Me.loan_amount_txt.TabIndex = 28
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(27, -46)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(243, 19)
        Me.Guna2HtmlLabel4.TabIndex = 26
        Me.Guna2HtmlLabel4.Text = "Full Name"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 7
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(273, 223)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(197, 41)
        Me.clear_btn.TabIndex = 26
        Me.clear_btn.Text = "CLEAR"
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 7
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(25, 223)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(197, 41)
        Me.submit_btn.TabIndex = 25
        Me.submit_btn.Text = "SUBMIT"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(530, 48)
        Me.Guna2Panel1.TabIndex = 32
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(17, 14)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(242, 25)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "LOAN REQUEST FORM"
        '
        'close_btn
        '
        Me.close_btn.CheckedState.Parent = Me.close_btn
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.CustomImages.Parent = Me.close_btn
        Me.close_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.close_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.Color.White
        Me.close_btn.HoverState.ForeColor = System.Drawing.Color.Yellow
        Me.close_btn.HoverState.Parent = Me.close_btn
        Me.close_btn.Location = New System.Drawing.Point(475, -4)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(52, 54)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "x"
        '
        'requestFORloan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 386)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "requestFORloan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "requestFORloan"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents loan_duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents loan_amount_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
