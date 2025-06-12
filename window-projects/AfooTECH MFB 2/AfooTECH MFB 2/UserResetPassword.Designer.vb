<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserResetPassword))
        Me.user_next_btn = New Guna.UI.WinForms.GunaButton()
        Me.user_back_btn = New Guna.UI.WinForms.GunaButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.closeBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'user_next_btn
        '
        Me.user_next_btn.AnimationHoverSpeed = 0.07!
        Me.user_next_btn.AnimationSpeed = 0.03!
        Me.user_next_btn.BackColor = System.Drawing.Color.Transparent
        Me.user_next_btn.BaseColor = System.Drawing.Color.CornflowerBlue
        Me.user_next_btn.BorderColor = System.Drawing.Color.Black
        Me.user_next_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_next_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.user_next_btn.FocusedColor = System.Drawing.Color.Empty
        Me.user_next_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_next_btn.ForeColor = System.Drawing.Color.White
        Me.user_next_btn.Image = CType(resources.GetObject("user_next_btn.Image"), System.Drawing.Image)
        Me.user_next_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.user_next_btn.Location = New System.Drawing.Point(247, 174)
        Me.user_next_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.user_next_btn.Name = "user_next_btn"
        Me.user_next_btn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.user_next_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.user_next_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.user_next_btn.OnHoverImage = Nothing
        Me.user_next_btn.OnPressedColor = System.Drawing.Color.Black
        Me.user_next_btn.Radius = 7
        Me.user_next_btn.Size = New System.Drawing.Size(168, 43)
        Me.user_next_btn.TabIndex = 29
        Me.user_next_btn.Text = "Proceed"
        Me.user_next_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'user_back_btn
        '
        Me.user_back_btn.AnimationHoverSpeed = 0.07!
        Me.user_back_btn.AnimationSpeed = 0.03!
        Me.user_back_btn.BackColor = System.Drawing.Color.Transparent
        Me.user_back_btn.BaseColor = System.Drawing.Color.DarkRed
        Me.user_back_btn.BorderColor = System.Drawing.Color.Black
        Me.user_back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_back_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.user_back_btn.FocusedColor = System.Drawing.Color.Empty
        Me.user_back_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_back_btn.ForeColor = System.Drawing.Color.White
        Me.user_back_btn.Image = CType(resources.GetObject("user_back_btn.Image"), System.Drawing.Image)
        Me.user_back_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.user_back_btn.Location = New System.Drawing.Point(34, 174)
        Me.user_back_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.user_back_btn.Name = "user_back_btn"
        Me.user_back_btn.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.user_back_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.user_back_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.user_back_btn.OnHoverImage = Nothing
        Me.user_back_btn.OnPressedColor = System.Drawing.Color.Black
        Me.user_back_btn.Radius = 7
        Me.user_back_btn.Size = New System.Drawing.Size(168, 43)
        Me.user_back_btn.TabIndex = 28
        Me.user_back_btn.Text = "Back"
        Me.user_back_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(34, 60)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(190, 20)
        Me.Guna2HtmlLabel1.TabIndex = 21
        Me.Guna2HtmlLabel1.Text = "EMAIL ADDRESS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.user_next_btn)
        Me.GroupBox1.Controls.Add(Me.user_back_btn)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(456, 402)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Log-in"
        '
        'email_txt
        '
        Me.email_txt.BorderRadius = 5
        Me.email_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.email_txt.BorderThickness = 2
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(34, 84)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Enter Your Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(387, 54)
        Me.email_txt.TabIndex = 20
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 14)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(274, 22)
        Me.Guna2HtmlLabel4.TabIndex = 19
        Me.Guna2HtmlLabel4.Text = "USER RESET PASSWORD FORM"
        '
        'closeBTN
        '
        Me.closeBTN.BackColor = System.Drawing.Color.Red
        Me.closeBTN.CheckedState.Parent = Me.closeBTN
        Me.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBTN.CustomImages.Parent = Me.closeBTN
        Me.closeBTN.FillColor = System.Drawing.Color.DarkRed
        Me.closeBTN.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBTN.ForeColor = System.Drawing.Color.White
        Me.closeBTN.HoverState.Parent = Me.closeBTN
        Me.closeBTN.Location = New System.Drawing.Point(457, 1)
        Me.closeBTN.Margin = New System.Windows.Forms.Padding(2)
        Me.closeBTN.Name = "closeBTN"
        Me.closeBTN.PressedColor = System.Drawing.Color.Yellow
        Me.closeBTN.ShadowDecoration.Parent = Me.closeBTN
        Me.closeBTN.Size = New System.Drawing.Size(47, 45)
        Me.closeBTN.TabIndex = 0
        Me.closeBTN.Text = "X"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.closeBTN)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(-4, -3)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(505, 45)
        Me.Guna2Panel1.TabIndex = 3
        '
        'UserResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UserResetPassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserResetPassword"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents user_next_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents user_back_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents closeBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
