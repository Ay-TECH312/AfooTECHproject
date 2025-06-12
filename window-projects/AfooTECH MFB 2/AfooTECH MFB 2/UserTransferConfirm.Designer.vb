<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserTransferConfirm
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
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.transferPROCEEDbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.transaction_description_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.receiver_fullname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.receiver_account_number = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transfer_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.close_btn.Location = New System.Drawing.Point(535, -2)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(52, 51)
        Me.close_btn.TabIndex = 14
        Me.close_btn.Text = "x"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(591, 44)
        Me.Guna2Panel1.TabIndex = 31
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(13, 12)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(389, 20)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "USER CONFIRM TRANSFER FORM"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.transferPROCEEDbtn)
        Me.GunaGroupBox1.Controls.Add(Me.clear_btn)
        Me.GunaGroupBox1.Controls.Add(Me.transaction_description_txt)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.receiver_fullname)
        Me.GunaGroupBox1.Controls.Add(Me.receiver_account_number)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.transfer_amount)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(559, 398)
        Me.GunaGroupBox1.TabIndex = 32
        Me.GunaGroupBox1.Text = "PAYMENT INFORMATION"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'transferPROCEEDbtn
        '
        Me.transferPROCEEDbtn.BorderRadius = 7
        Me.transferPROCEEDbtn.CheckedState.Parent = Me.transferPROCEEDbtn
        Me.transferPROCEEDbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transferPROCEEDbtn.CustomImages.Parent = Me.transferPROCEEDbtn
        Me.transferPROCEEDbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transferPROCEEDbtn.ForeColor = System.Drawing.Color.White
        Me.transferPROCEEDbtn.HoverState.Parent = Me.transferPROCEEDbtn
        Me.transferPROCEEDbtn.Location = New System.Drawing.Point(20, 313)
        Me.transferPROCEEDbtn.Name = "transferPROCEEDbtn"
        Me.transferPROCEEDbtn.ShadowDecoration.Parent = Me.transferPROCEEDbtn
        Me.transferPROCEEDbtn.Size = New System.Drawing.Size(125, 39)
        Me.transferPROCEEDbtn.TabIndex = 64
        Me.transferPROCEEDbtn.Text = "PROCEED"
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
        Me.clear_btn.Location = New System.Drawing.Point(406, 304)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(125, 39)
        Me.clear_btn.TabIndex = 63
        Me.clear_btn.Text = "CLEAR"
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
        Me.transaction_description_txt.Location = New System.Drawing.Point(20, 227)
        Me.transaction_description_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.transaction_description_txt.Name = "transaction_description_txt"
        Me.transaction_description_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transaction_description_txt.PlaceholderText = "Enter Description"
        Me.transaction_description_txt.SelectedText = ""
        Me.transaction_description_txt.ShadowDecoration.Parent = Me.transaction_description_txt
        Me.transaction_description_txt.Size = New System.Drawing.Size(511, 42)
        Me.transaction_description_txt.TabIndex = 67
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(22, 72)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(123, 23)
        Me.Guna2HtmlLabel4.TabIndex = 76
        Me.Guna2HtmlLabel4.Text = "Recipient Name    "
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(22, 42)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(123, 23)
        Me.Guna2HtmlLabel3.TabIndex = 75
        Me.Guna2HtmlLabel3.Text = "Account Number "
        '
        'receiver_fullname
        '
        Me.receiver_fullname.AutoSize = False
        Me.receiver_fullname.BackColor = System.Drawing.Color.Transparent
        Me.receiver_fullname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver_fullname.Location = New System.Drawing.Point(145, 72)
        Me.receiver_fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.receiver_fullname.Name = "receiver_fullname"
        Me.receiver_fullname.Size = New System.Drawing.Size(362, 23)
        Me.receiver_fullname.TabIndex = 74
        Me.receiver_fullname.Text = Nothing
        '
        'receiver_account_number
        '
        Me.receiver_account_number.AutoSize = False
        Me.receiver_account_number.BackColor = System.Drawing.Color.Transparent
        Me.receiver_account_number.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver_account_number.Location = New System.Drawing.Point(145, 42)
        Me.receiver_account_number.Margin = New System.Windows.Forms.Padding(2)
        Me.receiver_account_number.Name = "receiver_account_number"
        Me.receiver_account_number.Size = New System.Drawing.Size(362, 23)
        Me.receiver_account_number.TabIndex = 73
        Me.receiver_account_number.Text = Nothing
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(22, 130)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(193, 15)
        Me.Guna2HtmlLabel1.TabIndex = 72
        Me.Guna2HtmlLabel1.Text = "Amount Transfer"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(22, 206)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(193, 15)
        Me.Guna2HtmlLabel2.TabIndex = 71
        Me.Guna2HtmlLabel2.Text = "Transaction Description"
        '
        'transfer_amount
        '
        Me.transfer_amount.BackColor = System.Drawing.SystemColors.Control
        Me.transfer_amount.BorderRadius = 5
        Me.transfer_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transfer_amount.DefaultText = ""
        Me.transfer_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.transfer_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.transfer_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transfer_amount.DisabledState.Parent = Me.transfer_amount
        Me.transfer_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transfer_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transfer_amount.FocusedState.Parent = Me.transfer_amount
        Me.transfer_amount.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transfer_amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.transfer_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transfer_amount.HoverState.Parent = Me.transfer_amount
        Me.transfer_amount.Location = New System.Drawing.Point(20, 148)
        Me.transfer_amount.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.transfer_amount.Name = "transfer_amount"
        Me.transfer_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transfer_amount.PlaceholderText = "0:00"
        Me.transfer_amount.SelectedText = ""
        Me.transfer_amount.ShadowDecoration.Parent = Me.transfer_amount
        Me.transfer_amount.Size = New System.Drawing.Size(511, 42)
        Me.transfer_amount.TabIndex = 65
        '
        'UserTransferConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(583, 476)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserTransferConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserTransferConfirm"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents transaction_description_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents transferPROCEEDbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents transfer_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents receiver_fullname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents receiver_account_number As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
