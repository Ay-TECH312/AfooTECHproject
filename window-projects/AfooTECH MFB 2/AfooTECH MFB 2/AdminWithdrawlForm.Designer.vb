<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminWithdrawlForm
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
        Me.transBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transaction_description_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.withdrawlSUBMITbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.withdrawl_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'transBtn
        '
        Me.transBtn.Animated = True
        Me.transBtn.BorderRadius = 5
        Me.transBtn.CheckedState.Parent = Me.transBtn
        Me.transBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transBtn.CustomImages.Parent = Me.transBtn
        Me.transBtn.FillColor = System.Drawing.Color.CornflowerBlue
        Me.transBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.transBtn.ForeColor = System.Drawing.Color.White
        Me.transBtn.HoverState.Parent = Me.transBtn
        Me.transBtn.Location = New System.Drawing.Point(413, 107)
        Me.transBtn.Name = "transBtn"
        Me.transBtn.ShadowDecoration.Parent = Me.transBtn
        Me.transBtn.Size = New System.Drawing.Size(112, 32)
        Me.transBtn.TabIndex = 57
        Me.transBtn.Text = "TRANSACTION"
        '
        'profile_id
        '
        Me.profile_id.BackColor = System.Drawing.Color.Transparent
        Me.profile_id.BorderRadius = 5
        Me.profile_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id.FocusedState.Parent = Me.profile_id
        Me.profile_id.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.profile_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(17, 48)
        Me.profile_id.Margin = New System.Windows.Forms.Padding(2)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(508, 36)
        Me.profile_id.TabIndex = 56
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(18, 236)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(195, 15)
        Me.Guna2HtmlLabel6.TabIndex = 54
        Me.Guna2HtmlLabel6.Text = "Transaction Description"
        '
        'transaction_description_txt
        '
        Me.transaction_description_txt.BackColor = System.Drawing.SystemColors.Control
        Me.transaction_description_txt.BorderRadius = 5
        Me.transaction_description_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transaction_description_txt.DefaultText = ""
        Me.transaction_description_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.transaction_description_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.transaction_description_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transaction_description_txt.DisabledState.Parent = Me.transaction_description_txt
        Me.transaction_description_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transaction_description_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transaction_description_txt.FocusedState.Parent = Me.transaction_description_txt
        Me.transaction_description_txt.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transaction_description_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.transaction_description_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transaction_description_txt.HoverState.Parent = Me.transaction_description_txt
        Me.transaction_description_txt.Location = New System.Drawing.Point(17, 255)
        Me.transaction_description_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.transaction_description_txt.Name = "transaction_description_txt"
        Me.transaction_description_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transaction_description_txt.PlaceholderText = "Enter Description"
        Me.transaction_description_txt.SelectedText = ""
        Me.transaction_description_txt.ShadowDecoration.Parent = Me.transaction_description_txt
        Me.transaction_description_txt.Size = New System.Drawing.Size(508, 42)
        Me.transaction_description_txt.TabIndex = 53
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(-12, -5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(593, 40)
        Me.Guna2Panel1.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.afoo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(62, 14)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(351, 20)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "ADMIN WITHDRAWAL PAYMENT FORM"
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
        Me.close_btn.Location = New System.Drawing.Point(536, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(45, 36)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "x"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 7
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(400, 343)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(125, 38)
        Me.clear_btn.TabIndex = 40
        Me.clear_btn.Text = "CLEAR"
        '
        'withdrawlSUBMITbtn
        '
        Me.withdrawlSUBMITbtn.BorderRadius = 7
        Me.withdrawlSUBMITbtn.CheckedState.Parent = Me.withdrawlSUBMITbtn
        Me.withdrawlSUBMITbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.withdrawlSUBMITbtn.CustomImages.Parent = Me.withdrawlSUBMITbtn
        Me.withdrawlSUBMITbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdrawlSUBMITbtn.ForeColor = System.Drawing.Color.White
        Me.withdrawlSUBMITbtn.HoverState.Parent = Me.withdrawlSUBMITbtn
        Me.withdrawlSUBMITbtn.Location = New System.Drawing.Point(17, 343)
        Me.withdrawlSUBMITbtn.Name = "withdrawlSUBMITbtn"
        Me.withdrawlSUBMITbtn.ShadowDecoration.Parent = Me.withdrawlSUBMITbtn
        Me.withdrawlSUBMITbtn.Size = New System.Drawing.Size(125, 38)
        Me.withdrawlSUBMITbtn.TabIndex = 41
        Me.withdrawlSUBMITbtn.Text = "SUBMIT"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(17, 150)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(193, 15)
        Me.Guna2HtmlLabel1.TabIndex = 44
        Me.Guna2HtmlLabel1.Text = "Amount Withdrawal"
        '
        'withdrawl_amount
        '
        Me.withdrawl_amount.BackColor = System.Drawing.SystemColors.Control
        Me.withdrawl_amount.BorderRadius = 5
        Me.withdrawl_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.withdrawl_amount.DefaultText = ""
        Me.withdrawl_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.withdrawl_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.withdrawl_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.withdrawl_amount.DisabledState.Parent = Me.withdrawl_amount
        Me.withdrawl_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.withdrawl_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.withdrawl_amount.FocusedState.Parent = Me.withdrawl_amount
        Me.withdrawl_amount.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdrawl_amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.withdrawl_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.withdrawl_amount.HoverState.Parent = Me.withdrawl_amount
        Me.withdrawl_amount.Location = New System.Drawing.Point(18, 169)
        Me.withdrawl_amount.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.withdrawl_amount.Name = "withdrawl_amount"
        Me.withdrawl_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.withdrawl_amount.PlaceholderText = "0:00"
        Me.withdrawl_amount.SelectedText = ""
        Me.withdrawl_amount.ShadowDecoration.Parent = Me.withdrawl_amount
        Me.withdrawl_amount.Size = New System.Drawing.Size(508, 42)
        Me.withdrawl_amount.TabIndex = 42
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.transBtn)
        Me.GunaGroupBox1.Controls.Add(Me.profile_id)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.GunaGroupBox1.Controls.Add(Me.transaction_description_txt)
        Me.GunaGroupBox1.Controls.Add(Me.clear_btn)
        Me.GunaGroupBox1.Controls.Add(Me.withdrawlSUBMITbtn)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.withdrawl_amount)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(545, 409)
        Me.GunaGroupBox1.TabIndex = 33
        Me.GunaGroupBox1.Text = "PAYMENT INFORMATION"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'AdminWithdrawlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 472)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminWithdrawlForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminWithdrawlForm"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents transBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents transaction_description_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents withdrawlSUBMITbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents withdrawl_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
