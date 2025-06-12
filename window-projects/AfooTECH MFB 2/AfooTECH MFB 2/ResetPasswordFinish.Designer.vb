<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPasswordFinish
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPasswordFinish))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_login_closeBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.psswordOTPlabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.confirmpass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.createnewpass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resetpasssubmit_btn = New Guna.UI.WinForms.GunaButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.otp_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordHashCode_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.passHashCode_btn = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(580, 45)
        Me.Guna2Panel1.TabIndex = 2
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(330, 22)
        Me.Guna2HtmlLabel4.TabIndex = 19
        Me.Guna2HtmlLabel4.Text = "ADMIN RESET PASSWORD FINISH FORM"
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
        Me.admin_login_closeBTN.Location = New System.Drawing.Point(521, 0)
        Me.admin_login_closeBTN.Margin = New System.Windows.Forms.Padding(2)
        Me.admin_login_closeBTN.Name = "admin_login_closeBTN"
        Me.admin_login_closeBTN.PressedColor = System.Drawing.Color.Yellow
        Me.admin_login_closeBTN.ShadowDecoration.Parent = Me.admin_login_closeBTN
        Me.admin_login_closeBTN.Size = New System.Drawing.Size(55, 53)
        Me.admin_login_closeBTN.TabIndex = 0
        Me.admin_login_closeBTN.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.passHashCode_btn)
        Me.GroupBox1.Controls.Add(Me.passwordHashCode_btn)
        Me.GroupBox1.Controls.Add(Me.psswordOTPlabel)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GroupBox1.Controls.Add(Me.confirmpass_txt)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox1.Controls.Add(Me.createnewpass_txt)
        Me.GroupBox1.Controls.Add(Me.resetpasssubmit_btn)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.otp_txt)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(545, 467)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Log-in"
        '
        'psswordOTPlabel
        '
        Me.psswordOTPlabel.AutoSize = False
        Me.psswordOTPlabel.BackColor = System.Drawing.Color.Transparent
        Me.psswordOTPlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.psswordOTPlabel.Location = New System.Drawing.Point(34, 22)
        Me.psswordOTPlabel.Margin = New System.Windows.Forms.Padding(2)
        Me.psswordOTPlabel.Name = "psswordOTPlabel"
        Me.psswordOTPlabel.Size = New System.Drawing.Size(473, 80)
        Me.psswordOTPlabel.TabIndex = 34
        Me.psswordOTPlabel.Text = "Guna2HtmlLabel5"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(34, 297)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(276, 20)
        Me.Guna2HtmlLabel3.TabIndex = 33
        Me.Guna2HtmlLabel3.Text = "CONFIRM PASSWORD"
        '
        'confirmpass_txt
        '
        Me.confirmpass_txt.BorderRadius = 5
        Me.confirmpass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.confirmpass_txt.BorderThickness = 2
        Me.confirmpass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpass_txt.DefaultText = ""
        Me.confirmpass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass_txt.DisabledState.Parent = Me.confirmpass_txt
        Me.confirmpass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass_txt.FocusedState.Parent = Me.confirmpass_txt
        Me.confirmpass_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpass_txt.ForeColor = System.Drawing.Color.Black
        Me.confirmpass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass_txt.HoverState.Parent = Me.confirmpass_txt
        Me.confirmpass_txt.Location = New System.Drawing.Point(34, 323)
        Me.confirmpass_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.confirmpass_txt.Name = "confirmpass_txt"
        Me.confirmpass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmpass_txt.PlaceholderText = "CONFIRM NEW PASSWORD"
        Me.confirmpass_txt.SelectedText = ""
        Me.confirmpass_txt.ShadowDecoration.Parent = Me.confirmpass_txt
        Me.confirmpass_txt.Size = New System.Drawing.Size(473, 54)
        Me.confirmpass_txt.TabIndex = 32
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(34, 207)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(276, 20)
        Me.Guna2HtmlLabel2.TabIndex = 31
        Me.Guna2HtmlLabel2.Text = "CREATE NEW PASSWORD"
        '
        'createnewpass_txt
        '
        Me.createnewpass_txt.BorderRadius = 5
        Me.createnewpass_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.createnewpass_txt.BorderThickness = 2
        Me.createnewpass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.createnewpass_txt.DefaultText = ""
        Me.createnewpass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.createnewpass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.createnewpass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.createnewpass_txt.DisabledState.Parent = Me.createnewpass_txt
        Me.createnewpass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.createnewpass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createnewpass_txt.FocusedState.Parent = Me.createnewpass_txt
        Me.createnewpass_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createnewpass_txt.ForeColor = System.Drawing.Color.Black
        Me.createnewpass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createnewpass_txt.HoverState.Parent = Me.createnewpass_txt
        Me.createnewpass_txt.Location = New System.Drawing.Point(34, 226)
        Me.createnewpass_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.createnewpass_txt.Name = "createnewpass_txt"
        Me.createnewpass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.createnewpass_txt.PlaceholderText = "ENTER NEW PASSWORD"
        Me.createnewpass_txt.SelectedText = ""
        Me.createnewpass_txt.ShadowDecoration.Parent = Me.createnewpass_txt
        Me.createnewpass_txt.Size = New System.Drawing.Size(473, 54)
        Me.createnewpass_txt.TabIndex = 30
        '
        'resetpasssubmit_btn
        '
        Me.resetpasssubmit_btn.AnimationHoverSpeed = 0.07!
        Me.resetpasssubmit_btn.AnimationSpeed = 0.03!
        Me.resetpasssubmit_btn.BackColor = System.Drawing.Color.Transparent
        Me.resetpasssubmit_btn.BaseColor = System.Drawing.Color.CornflowerBlue
        Me.resetpasssubmit_btn.BorderColor = System.Drawing.Color.Black
        Me.resetpasssubmit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetpasssubmit_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.resetpasssubmit_btn.FocusedColor = System.Drawing.Color.Empty
        Me.resetpasssubmit_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetpasssubmit_btn.ForeColor = System.Drawing.Color.White
        Me.resetpasssubmit_btn.Image = CType(resources.GetObject("resetpasssubmit_btn.Image"), System.Drawing.Image)
        Me.resetpasssubmit_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.resetpasssubmit_btn.Location = New System.Drawing.Point(34, 406)
        Me.resetpasssubmit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.resetpasssubmit_btn.Name = "resetpasssubmit_btn"
        Me.resetpasssubmit_btn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.resetpasssubmit_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.resetpasssubmit_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.resetpasssubmit_btn.OnHoverImage = Nothing
        Me.resetpasssubmit_btn.OnPressedColor = System.Drawing.Color.Black
        Me.resetpasssubmit_btn.Radius = 7
        Me.resetpasssubmit_btn.Size = New System.Drawing.Size(168, 43)
        Me.resetpasssubmit_btn.TabIndex = 29
        Me.resetpasssubmit_btn.Text = "SUBMIT"
        Me.resetpasssubmit_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(34, 106)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(276, 20)
        Me.Guna2HtmlLabel1.TabIndex = 21
        Me.Guna2HtmlLabel1.Text = "OTP"
        '
        'otp_txt
        '
        Me.otp_txt.BorderRadius = 5
        Me.otp_txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.otp_txt.BorderThickness = 2
        Me.otp_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otp_txt.DefaultText = ""
        Me.otp_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.otp_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.otp_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.DisabledState.Parent = Me.otp_txt
        Me.otp_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.FocusedState.Parent = Me.otp_txt
        Me.otp_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otp_txt.ForeColor = System.Drawing.Color.Black
        Me.otp_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.HoverState.Parent = Me.otp_txt
        Me.otp_txt.Location = New System.Drawing.Point(34, 125)
        Me.otp_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.otp_txt.Name = "otp_txt"
        Me.otp_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.otp_txt.PlaceholderText = "ENTER OTP"
        Me.otp_txt.SelectedText = ""
        Me.otp_txt.ShadowDecoration.Parent = Me.otp_txt
        Me.otp_txt.Size = New System.Drawing.Size(473, 54)
        Me.otp_txt.TabIndex = 20
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
        Me.passwordHashCode_btn.Location = New System.Drawing.Point(437, 241)
        Me.passwordHashCode_btn.Name = "passwordHashCode_btn"
        Me.passwordHashCode_btn.ShadowDecoration.Parent = Me.passwordHashCode_btn
        Me.passwordHashCode_btn.Size = New System.Drawing.Size(58, 24)
        Me.passwordHashCode_btn.TabIndex = 35
        '
        'passHashCode_btn
        '
        Me.passHashCode_btn.BorderRadius = 4
        Me.passHashCode_btn.CheckedState.Parent = Me.passHashCode_btn
        Me.passHashCode_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passHashCode_btn.CustomImages.Parent = Me.passHashCode_btn
        Me.passHashCode_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passHashCode_btn.ForeColor = System.Drawing.Color.White
        Me.passHashCode_btn.HoverState.Parent = Me.passHashCode_btn
        Me.passHashCode_btn.Location = New System.Drawing.Point(437, 338)
        Me.passHashCode_btn.Name = "passHashCode_btn"
        Me.passHashCode_btn.ShadowDecoration.Parent = Me.passHashCode_btn
        Me.passHashCode_btn.Size = New System.Drawing.Size(58, 24)
        Me.passHashCode_btn.TabIndex = 36
        '
        'ResetPasswordFinish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ResetPasswordFinish"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPasswordFinish"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_login_closeBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents resetpasssubmit_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents otp_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents confirmpass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents createnewpass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents psswordOTPlabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passHashCode_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passwordHashCode_btn As Guna.UI2.WinForms.Guna2Button
End Class
