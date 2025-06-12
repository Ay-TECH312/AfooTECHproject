<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_password
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.confirmed_password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.change_password_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.new_password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.old_password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(584, 48)
        Me.Guna2Panel1.TabIndex = 39
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(17, 11)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(300, 25)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "CHANGE PASSWORD FORM"
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
        Me.close_btn.Location = New System.Drawing.Point(524, -4)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(57, 51)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "x"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.confirmed_password_txt)
        Me.GroupBox1.Controls.Add(Me.change_password_btn)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.new_password_txt)
        Me.GroupBox1.Controls.Add(Me.old_password_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 405)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PASSWORD DETAILS"
        '
        'confirmed_password_txt
        '
        Me.confirmed_password_txt.BorderRadius = 5
        Me.confirmed_password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmed_password_txt.DefaultText = ""
        Me.confirmed_password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmed_password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmed_password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmed_password_txt.DisabledState.Parent = Me.confirmed_password_txt
        Me.confirmed_password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmed_password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmed_password_txt.FocusedState.Parent = Me.confirmed_password_txt
        Me.confirmed_password_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmed_password_txt.ForeColor = System.Drawing.Color.Black
        Me.confirmed_password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmed_password_txt.HoverState.Parent = Me.confirmed_password_txt
        Me.confirmed_password_txt.Location = New System.Drawing.Point(18, 261)
        Me.confirmed_password_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.confirmed_password_txt.Name = "confirmed_password_txt"
        Me.confirmed_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmed_password_txt.PlaceholderText = "Confirmed Password"
        Me.confirmed_password_txt.SelectedText = ""
        Me.confirmed_password_txt.ShadowDecoration.Parent = Me.confirmed_password_txt
        Me.confirmed_password_txt.Size = New System.Drawing.Size(522, 47)
        Me.confirmed_password_txt.TabIndex = 52
        '
        'change_password_btn
        '
        Me.change_password_btn.BorderRadius = 7
        Me.change_password_btn.CheckedState.Parent = Me.change_password_btn
        Me.change_password_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_password_btn.CustomImages.Parent = Me.change_password_btn
        Me.change_password_btn.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_password_btn.ForeColor = System.Drawing.Color.White
        Me.change_password_btn.HoverState.Parent = Me.change_password_btn
        Me.change_password_btn.Location = New System.Drawing.Point(11, 346)
        Me.change_password_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.change_password_btn.Name = "change_password_btn"
        Me.change_password_btn.ShadowDecoration.Parent = Me.change_password_btn
        Me.change_password_btn.Size = New System.Drawing.Size(185, 46)
        Me.change_password_btn.TabIndex = 46
        Me.change_password_btn.Text = "CHANGE PASSWORD"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(18, 235)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(230, 18)
        Me.Guna2HtmlLabel3.TabIndex = 51
        Me.Guna2HtmlLabel3.Text = "Confirmed Password"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 130)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(230, 18)
        Me.Guna2HtmlLabel2.TabIndex = 50
        Me.Guna2HtmlLabel2.Text = "New Password"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 29)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(230, 18)
        Me.Guna2HtmlLabel1.TabIndex = 49
        Me.Guna2HtmlLabel1.Text = "Old Password"
        '
        'new_password_txt
        '
        Me.new_password_txt.BorderRadius = 5
        Me.new_password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_password_txt.DefaultText = ""
        Me.new_password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.new_password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.new_password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_password_txt.DisabledState.Parent = Me.new_password_txt
        Me.new_password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_password_txt.FocusedState.Parent = Me.new_password_txt
        Me.new_password_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_password_txt.ForeColor = System.Drawing.Color.Black
        Me.new_password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_password_txt.HoverState.Parent = Me.new_password_txt
        Me.new_password_txt.Location = New System.Drawing.Point(18, 156)
        Me.new_password_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.new_password_txt.Name = "new_password_txt"
        Me.new_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.new_password_txt.PlaceholderText = "Enter New Password"
        Me.new_password_txt.SelectedText = ""
        Me.new_password_txt.ShadowDecoration.Parent = Me.new_password_txt
        Me.new_password_txt.Size = New System.Drawing.Size(522, 47)
        Me.new_password_txt.TabIndex = 48
        '
        'old_password_txt
        '
        Me.old_password_txt.BackColor = System.Drawing.SystemColors.Control
        Me.old_password_txt.BorderRadius = 5
        Me.old_password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.old_password_txt.DefaultText = ""
        Me.old_password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.old_password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.old_password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.old_password_txt.DisabledState.Parent = Me.old_password_txt
        Me.old_password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.old_password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.old_password_txt.FocusedState.Parent = Me.old_password_txt
        Me.old_password_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_password_txt.ForeColor = System.Drawing.Color.Black
        Me.old_password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.old_password_txt.HoverState.Parent = Me.old_password_txt
        Me.old_password_txt.Location = New System.Drawing.Point(18, 54)
        Me.old_password_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.old_password_txt.Name = "old_password_txt"
        Me.old_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.old_password_txt.PlaceholderText = "Enter Old Password"
        Me.old_password_txt.SelectedText = ""
        Me.old_password_txt.ShadowDecoration.Parent = Me.old_password_txt
        Me.old_password_txt.Size = New System.Drawing.Size(522, 47)
        Me.old_password_txt.TabIndex = 47
        '
        'change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 481)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "change_password"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change_password"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents confirmed_password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents change_password_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents new_password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents old_password_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
