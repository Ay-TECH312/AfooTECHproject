<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentReceiptForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentReceiptForm))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transfer_amount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TransactionStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TransactionDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.TransactionI_ID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TransactionIID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.receiver_fullname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.transaction_description_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sender_fullname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.receiver_account_number = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RecipientFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TransactionI_disc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RecipientAccountID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaLinePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(526, 44)
        Me.Guna2Panel1.TabIndex = 32
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
        Me.close_btn.Location = New System.Drawing.Point(471, -2)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(55, 51)
        Me.close_btn.TabIndex = 14
        Me.close_btn.Text = "x"
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
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(246, 20)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "PAYMENT RECEIPT FORM"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(56, 12)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(123, 23)
        Me.Guna2HtmlLabel4.TabIndex = 80
        Me.Guna2HtmlLabel4.Text = "AfooTECH MFB"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(334, 12)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(156, 23)
        Me.Guna2HtmlLabel3.TabIndex = 79
        Me.Guna2HtmlLabel3.Text = "Transaction Receipt"
        '
        'transfer_amount
        '
        Me.transfer_amount.AutoSize = False
        Me.transfer_amount.BackColor = System.Drawing.Color.Transparent
        Me.transfer_amount.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transfer_amount.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.transfer_amount.Location = New System.Drawing.Point(191, 66)
        Me.transfer_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.transfer_amount.Name = "transfer_amount"
        Me.transfer_amount.Size = New System.Drawing.Size(298, 19)
        Me.transfer_amount.TabIndex = 78
        Me.transfer_amount.Text = "N0.00"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(51, 33)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 81
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'TransactionStatus
        '
        Me.TransactionStatus.AutoSize = False
        Me.TransactionStatus.BackColor = System.Drawing.Color.Transparent
        Me.TransactionStatus.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionStatus.Location = New System.Drawing.Point(202, 89)
        Me.TransactionStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionStatus.Name = "TransactionStatus"
        Me.TransactionStatus.Size = New System.Drawing.Size(193, 15)
        Me.TransactionStatus.TabIndex = 82
        Me.TransactionStatus.Text = "xxxx"
        '
        'TransactionDate
        '
        Me.TransactionDate.AutoSize = False
        Me.TransactionDate.BackColor = System.Drawing.Color.Transparent
        Me.TransactionDate.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TransactionDate.Location = New System.Drawing.Point(191, 111)
        Me.TransactionDate.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.Size = New System.Drawing.Size(193, 15)
        Me.TransactionDate.TabIndex = 83
        Me.TransactionDate.Text = "xxxx"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GunaLinePanel1.Controls.Add(Me.TransactionDate)
        Me.GunaLinePanel1.Controls.Add(Me.transfer_amount)
        Me.GunaLinePanel1.Controls.Add(Me.TransactionStatus)
        Me.GunaLinePanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GunaLinePanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(12, 47)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(493, 134)
        Me.GunaLinePanel1.TabIndex = 84
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Controls.Add(Me.TransactionI_ID)
        Me.GunaLinePanel2.Controls.Add(Me.TransactionIID)
        Me.GunaLinePanel2.Controls.Add(Me.receiver_fullname)
        Me.GunaLinePanel2.Controls.Add(Me.transaction_description_txt)
        Me.GunaLinePanel2.Controls.Add(Me.Sender_fullname)
        Me.GunaLinePanel2.Controls.Add(Me.receiver_account_number)
        Me.GunaLinePanel2.Controls.Add(Me.RecipientFullName)
        Me.GunaLinePanel2.Controls.Add(Me.TransactionI_disc)
        Me.GunaLinePanel2.Controls.Add(Me.Sender)
        Me.GunaLinePanel2.Controls.Add(Me.RecipientAccountID)
        Me.GunaLinePanel2.LineBottom = 1
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(12, 181)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(493, 159)
        Me.GunaLinePanel2.TabIndex = 85
        '
        'TransactionI_ID
        '
        Me.TransactionI_ID.AutoSize = False
        Me.TransactionI_ID.BackColor = System.Drawing.Color.Transparent
        Me.TransactionI_ID.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionI_ID.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TransactionI_ID.Location = New System.Drawing.Point(187, 123)
        Me.TransactionI_ID.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionI_ID.Name = "TransactionI_ID"
        Me.TransactionI_ID.Size = New System.Drawing.Size(302, 18)
        Me.TransactionI_ID.TabIndex = 101
        Me.TransactionI_ID.Text = "TransactionIID"
        '
        'TransactionIID
        '
        Me.TransactionIID.AutoSize = False
        Me.TransactionIID.BackColor = System.Drawing.Color.Transparent
        Me.TransactionIID.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionIID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TransactionIID.Location = New System.Drawing.Point(10, 122)
        Me.TransactionIID.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionIID.Name = "TransactionIID"
        Me.TransactionIID.Size = New System.Drawing.Size(151, 18)
        Me.TransactionIID.TabIndex = 100
        Me.TransactionIID.Text = "TransactionIID"
        '
        'receiver_fullname
        '
        Me.receiver_fullname.AutoSize = False
        Me.receiver_fullname.BackColor = System.Drawing.Color.Transparent
        Me.receiver_fullname.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver_fullname.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.receiver_fullname.Location = New System.Drawing.Point(187, 15)
        Me.receiver_fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.receiver_fullname.Name = "receiver_fullname"
        Me.receiver_fullname.Size = New System.Drawing.Size(302, 18)
        Me.receiver_fullname.TabIndex = 99
        Me.receiver_fullname.Text = "receiver_fullname"
        '
        'transaction_description_txt
        '
        Me.transaction_description_txt.AutoSize = False
        Me.transaction_description_txt.BackColor = System.Drawing.Color.Transparent
        Me.transaction_description_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transaction_description_txt.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.transaction_description_txt.Location = New System.Drawing.Point(187, 97)
        Me.transaction_description_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.transaction_description_txt.Name = "transaction_description_txt"
        Me.transaction_description_txt.Size = New System.Drawing.Size(302, 18)
        Me.transaction_description_txt.TabIndex = 98
        Me.transaction_description_txt.Text = "Transaction_Description"
        '
        'Sender_fullname
        '
        Me.Sender_fullname.AutoSize = False
        Me.Sender_fullname.BackColor = System.Drawing.Color.Transparent
        Me.Sender_fullname.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender_fullname.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Sender_fullname.Location = New System.Drawing.Point(187, 69)
        Me.Sender_fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.Sender_fullname.Name = "Sender_fullname"
        Me.Sender_fullname.Size = New System.Drawing.Size(302, 18)
        Me.Sender_fullname.TabIndex = 96
        Me.Sender_fullname.Text = "Sender_fullname"
        '
        'receiver_account_number
        '
        Me.receiver_account_number.AutoSize = False
        Me.receiver_account_number.BackColor = System.Drawing.Color.Transparent
        Me.receiver_account_number.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver_account_number.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.receiver_account_number.Location = New System.Drawing.Point(187, 41)
        Me.receiver_account_number.Margin = New System.Windows.Forms.Padding(2)
        Me.receiver_account_number.Name = "receiver_account_number"
        Me.receiver_account_number.Size = New System.Drawing.Size(302, 18)
        Me.receiver_account_number.TabIndex = 95
        Me.receiver_account_number.Text = "receiver_account_number"
        '
        'RecipientFullName
        '
        Me.RecipientFullName.AutoSize = False
        Me.RecipientFullName.BackColor = System.Drawing.Color.Transparent
        Me.RecipientFullName.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipientFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecipientFullName.Location = New System.Drawing.Point(10, 14)
        Me.RecipientFullName.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipientFullName.Name = "RecipientFullName"
        Me.RecipientFullName.Size = New System.Drawing.Size(151, 18)
        Me.RecipientFullName.TabIndex = 94
        Me.RecipientFullName.Text = "Recipient Name"
        '
        'TransactionI_disc
        '
        Me.TransactionI_disc.AutoSize = False
        Me.TransactionI_disc.BackColor = System.Drawing.Color.Transparent
        Me.TransactionI_disc.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionI_disc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TransactionI_disc.Location = New System.Drawing.Point(10, 96)
        Me.TransactionI_disc.Margin = New System.Windows.Forms.Padding(2)
        Me.TransactionI_disc.Name = "TransactionI_disc"
        Me.TransactionI_disc.Size = New System.Drawing.Size(151, 18)
        Me.TransactionI_disc.TabIndex = 93
        Me.TransactionI_disc.Text = "Description"
        '
        'Sender
        '
        Me.Sender.AutoSize = False
        Me.Sender.BackColor = System.Drawing.Color.Transparent
        Me.Sender.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sender.Location = New System.Drawing.Point(10, 68)
        Me.Sender.Margin = New System.Windows.Forms.Padding(2)
        Me.Sender.Name = "Sender"
        Me.Sender.Size = New System.Drawing.Size(151, 18)
        Me.Sender.TabIndex = 91
        Me.Sender.Text = "Sender Name"
        '
        'RecipientAccountID
        '
        Me.RecipientAccountID.AutoSize = False
        Me.RecipientAccountID.BackColor = System.Drawing.Color.Transparent
        Me.RecipientAccountID.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipientAccountID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecipientAccountID.Location = New System.Drawing.Point(10, 40)
        Me.RecipientAccountID.Margin = New System.Windows.Forms.Padding(2)
        Me.RecipientAccountID.Name = "RecipientAccountID"
        Me.RecipientAccountID.Size = New System.Drawing.Size(151, 18)
        Me.RecipientAccountID.TabIndex = 90
        Me.RecipientAccountID.Text = "Recipient Account No"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.AutoSize = False
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(13, 345)
        Me.Guna2HtmlLabel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(492, 37)
        Me.Guna2HtmlLabel13.TabIndex = 94
        Me.Guna2HtmlLabel13.Text = "please call out 24-hour contact centre on 0915628902 or contactcentre@afootech.co" & _
            "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PaymentReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(517, 396)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Controls.Add(Me.GunaLinePanel2)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentReceiptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentReceiptForm"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents transfer_amount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TransactionStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TransactionDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents TransactionI_disc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RecipientAccountID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RecipientFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents receiver_fullname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents transaction_description_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sender_fullname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents receiver_account_number As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TransactionI_ID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TransactionIID As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
