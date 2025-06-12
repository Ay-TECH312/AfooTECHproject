<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Login))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_login_closeBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passwordHashCode_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_login_btn = New Guna.UI.WinForms.GunaButton()
        Me.ForgetPassword_linklabel = New System.Windows.Forms.LinkLabel()
        Me.password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.admin_login_closeBTN)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(579, 41)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(228, 22)
        Me.Guna2HtmlLabel4.TabIndex = 19
        Me.Guna2HtmlLabel4.Text = "ADMIN LOG-IN FORM"
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
        Me.admin_login_closeBTN.Location = New System.Drawing.Point(530, 0)
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
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.passwordHashCode_btn)
        Me.GroupBox1.Controls.Add(Me.admin_login_btn)
        Me.GroupBox1.Controls.Add(Me.ForgetPassword_linklabel)
        Me.GroupBox1.Controls.Add(Me.password_txt)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(545, 467)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 32)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Administative Log-in Portal"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.Untitled_8
        Me.PictureBox3.Location = New System.Drawing.Point(48, 268)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.Untitled_7
        Me.PictureBox2.Location = New System.Drawing.Point(47, 161)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.WhatsApp_Image_2024_09_19_at_18_57_36_fa613b3b
        Me.PictureBox1.Location = New System.Drawing.Point(35, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'passwordHashCode_btn
        '
        Me.passwordHashCode_btn.BorderRadius = 4
        Me.passwordHashCode_btn.CheckedState.Parent = Me.passwordHashCode_btn
        Me.passwordHashCode_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passwordHashCode_btn.CustomImages.Parent = Me.passwordHashCode_btn
        Me.passwordHashCode_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordHashCode_btn.ForeColor = System.Drawing.Color.White
        Me.passwordHashCode_btn.HoverState.Parent = Me.passwordHashCode_btn
        Me.passwordHashCode_btn.Location = New System.Drawing.Point(439, 308)
        Me.passwordHashCode_btn.Name = "passwordHashCode_btn"
        Me.passwordHashCode_btn.ShadowDecoration.Parent = Me.passwordHashCode_btn
        Me.passwordHashCode_btn.Size = New System.Drawing.Size(58, 24)
        Me.passwordHashCode_btn.TabIndex = 30
        '
        'admin_login_btn
        '
        Me.admin_login_btn.AnimationHoverSpeed = 0.07!
        Me.admin_login_btn.AnimationSpeed = 0.03!
        Me.admin_login_btn.BackColor = System.Drawing.Color.Transparent
        Me.admin_login_btn.BaseColor = System.Drawing.Color.CornflowerBlue
        Me.admin_login_btn.BorderColor = System.Drawing.Color.Black
        Me.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_login_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.admin_login_btn.FocusedColor = System.Drawing.Color.Empty
        Me.admin_login_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_login_btn.ForeColor = System.Drawing.Color.White
        Me.admin_login_btn.Image = CType(resources.GetObject("admin_login_btn.Image"), System.Drawing.Image)
        Me.admin_login_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.admin_login_btn.Location = New System.Drawing.Point(34, 405)
        Me.admin_login_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.admin_login_btn.Name = "admin_login_btn"
        Me.admin_login_btn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.admin_login_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.admin_login_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.admin_login_btn.OnHoverImage = Nothing
        Me.admin_login_btn.OnPressedColor = System.Drawing.Color.Black
        Me.admin_login_btn.Radius = 7
        Me.admin_login_btn.Size = New System.Drawing.Size(168, 43)
        Me.admin_login_btn.TabIndex = 28
        Me.admin_login_btn.Text = "LOG-IN "
        Me.admin_login_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForgetPassword_linklabel
        '
        Me.ForgetPassword_linklabel.BackColor = System.Drawing.Color.Transparent
        Me.ForgetPassword_linklabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgetPassword_linklabel.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgetPassword_linklabel.LinkColor = System.Drawing.Color.Black
        Me.ForgetPassword_linklabel.Location = New System.Drawing.Point(33, 361)
        Me.ForgetPassword_linklabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ForgetPassword_linklabel.Name = "ForgetPassword_linklabel"
        Me.ForgetPassword_linklabel.Size = New System.Drawing.Size(202, 24)
        Me.ForgetPassword_linklabel.TabIndex = 27
        Me.ForgetPassword_linklabel.TabStop = True
        Me.ForgetPassword_linklabel.Text = "Forget Password ?"
        '
        'password_txt
        '
        Me.password_txt.BorderRadius = 5
        Me.password_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_txt.DefaultText = ""
        Me.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.DisabledState.Parent = Me.password_txt
        Me.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.FocusedState.Parent = Me.password_txt
        Me.password_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.Black
        Me.password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.HoverState.Parent = Me.password_txt
        Me.password_txt.Location = New System.Drawing.Point(35, 293)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_txt.PlaceholderText = "Enter Your Password"
        Me.password_txt.SelectedText = ""
        Me.password_txt.ShadowDecoration.Parent = Me.password_txt
        Me.password_txt.Size = New System.Drawing.Size(473, 54)
        Me.password_txt.TabIndex = 23
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(76, 269)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(190, 18)
        Me.Guna2HtmlLabel2.TabIndex = 22
        Me.Guna2HtmlLabel2.Text = "PASSWORD"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(73, 162)
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
        Me.email_txt.Location = New System.Drawing.Point(34, 186)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Enter Your Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(473, 54)
        Me.email_txt.TabIndex = 20
        '
        'Admin_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Login"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents admin_login_closeBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ForgetPassword_linklabel As System.Windows.Forms.LinkLabel
    Friend WithEvents password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents admin_login_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents passwordHashCode_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
