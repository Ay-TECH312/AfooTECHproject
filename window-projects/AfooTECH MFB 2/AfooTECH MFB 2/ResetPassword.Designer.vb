<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassword))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_login_closeBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nextPassword_btn = New Guna.UI.WinForms.GunaButton()
        Me.Admin_back_btn = New Guna.UI.WinForms.GunaButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.admin_login_closeBTN)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(-10, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(485, 41)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 10)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(274, 22)
        Me.Guna2HtmlLabel4.TabIndex = 19
        Me.Guna2HtmlLabel4.Text = "ADMIN RESET PASSWORD FORM"
        '
        'admin_login_closeBTN
        '
        Me.admin_login_closeBTN.BackColor = System.Drawing.Color.Red
        Me.admin_login_closeBTN.CheckedState.Parent = Me.admin_login_closeBTN
        Me.admin_login_closeBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_login_closeBTN.CustomImages.Parent = Me.admin_login_closeBTN
        Me.admin_login_closeBTN.FillColor = System.Drawing.Color.DarkRed
        Me.admin_login_closeBTN.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_login_closeBTN.ForeColor = System.Drawing.Color.White
        Me.admin_login_closeBTN.HoverState.Parent = Me.admin_login_closeBTN
        Me.admin_login_closeBTN.Location = New System.Drawing.Point(437, -2)
        Me.admin_login_closeBTN.Margin = New System.Windows.Forms.Padding(2)
        Me.admin_login_closeBTN.Name = "admin_login_closeBTN"
        Me.admin_login_closeBTN.PressedColor = System.Drawing.Color.Yellow
        Me.admin_login_closeBTN.ShadowDecoration.Parent = Me.admin_login_closeBTN
        Me.admin_login_closeBTN.Size = New System.Drawing.Size(47, 41)
        Me.admin_login_closeBTN.TabIndex = 0
        Me.admin_login_closeBTN.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.nextPassword_btn)
        Me.GroupBox1.Controls.Add(Me.Admin_back_btn)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(450, 365)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Log-in"
        '
        'nextPassword_btn
        '
        Me.nextPassword_btn.AnimationHoverSpeed = 0.07!
        Me.nextPassword_btn.AnimationSpeed = 0.03!
        Me.nextPassword_btn.BackColor = System.Drawing.Color.Transparent
        Me.nextPassword_btn.BaseColor = System.Drawing.Color.CornflowerBlue
        Me.nextPassword_btn.BorderColor = System.Drawing.Color.Black
        Me.nextPassword_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextPassword_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nextPassword_btn.FocusedColor = System.Drawing.Color.Empty
        Me.nextPassword_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextPassword_btn.ForeColor = System.Drawing.Color.White
        Me.nextPassword_btn.Image = CType(resources.GetObject("nextPassword_btn.Image"), System.Drawing.Image)
        Me.nextPassword_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.nextPassword_btn.Location = New System.Drawing.Point(242, 174)
        Me.nextPassword_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.nextPassword_btn.Name = "nextPassword_btn"
        Me.nextPassword_btn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.nextPassword_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nextPassword_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.nextPassword_btn.OnHoverImage = Nothing
        Me.nextPassword_btn.OnPressedColor = System.Drawing.Color.Black
        Me.nextPassword_btn.Radius = 7
        Me.nextPassword_btn.Size = New System.Drawing.Size(168, 43)
        Me.nextPassword_btn.TabIndex = 29
        Me.nextPassword_btn.Text = "Proceed"
        Me.nextPassword_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Admin_back_btn
        '
        Me.Admin_back_btn.AnimationHoverSpeed = 0.07!
        Me.Admin_back_btn.AnimationSpeed = 0.03!
        Me.Admin_back_btn.BackColor = System.Drawing.Color.Transparent
        Me.Admin_back_btn.BaseColor = System.Drawing.Color.DarkRed
        Me.Admin_back_btn.BorderColor = System.Drawing.Color.Black
        Me.Admin_back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Admin_back_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Admin_back_btn.FocusedColor = System.Drawing.Color.Empty
        Me.Admin_back_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_back_btn.ForeColor = System.Drawing.Color.White
        Me.Admin_back_btn.Image = CType(resources.GetObject("Admin_back_btn.Image"), System.Drawing.Image)
        Me.Admin_back_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Admin_back_btn.Location = New System.Drawing.Point(34, 174)
        Me.Admin_back_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Admin_back_btn.Name = "Admin_back_btn"
        Me.Admin_back_btn.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.Admin_back_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Admin_back_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Admin_back_btn.OnHoverImage = Nothing
        Me.Admin_back_btn.OnPressedColor = System.Drawing.Color.Black
        Me.Admin_back_btn.Radius = 7
        Me.Admin_back_btn.Size = New System.Drawing.Size(168, 43)
        Me.Admin_back_btn.TabIndex = 28
        Me.Admin_back_btn.Text = "Back"
        Me.Admin_back_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.email_txt.Location = New System.Drawing.Point(34, 79)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Enter Your Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(381, 54)
        Me.email_txt.TabIndex = 20
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ResetPassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPassword"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_login_closeBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Admin_back_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nextPassword_btn As Guna.UI.WinForms.GunaButton
End Class
