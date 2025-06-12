<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserTransfer
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.account_id_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.transferVERIFYbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(467, -2)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(52, 51)
        Me.Guna2Button1.TabIndex = 14
        Me.Guna2Button1.Text = "x"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(-5, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(525, 44)
        Me.Guna2Panel1.TabIndex = 30
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
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(355, 20)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "USER VERIFY TRANSFER FORM"
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
        Me.clear_btn.Location = New System.Drawing.Point(334, 174)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(125, 39)
        Me.clear_btn.TabIndex = 40
        Me.clear_btn.Text = "CLEAR"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GunaGroupBox1.Controls.Add(Me.account_id_txt)
        Me.GunaGroupBox1.Controls.Add(Me.clear_btn)
        Me.GunaGroupBox1.Controls.Add(Me.transferVERIFYbtn)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(11, 57)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(487, 260)
        Me.GunaGroupBox1.TabIndex = 32
        Me.GunaGroupBox1.Text = "PAYMENT INFORMATION"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(20, 70)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(193, 15)
        Me.Guna2HtmlLabel3.TabIndex = 58
        Me.Guna2HtmlLabel3.Text = "Account Number"
        '
        'account_id_txt
        '
        Me.account_id_txt.BackColor = System.Drawing.SystemColors.Control
        Me.account_id_txt.BorderRadius = 5
        Me.account_id_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.account_id_txt.DefaultText = ""
        Me.account_id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.account_id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.account_id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.account_id_txt.DisabledState.Parent = Me.account_id_txt
        Me.account_id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.account_id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.account_id_txt.FocusedState.Parent = Me.account_id_txt
        Me.account_id_txt.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_id_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.account_id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.account_id_txt.HoverState.Parent = Me.account_id_txt
        Me.account_id_txt.Location = New System.Drawing.Point(18, 91)
        Me.account_id_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.account_id_txt.Name = "account_id_txt"
        Me.account_id_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.account_id_txt.PlaceholderText = "Enter Account Number"
        Me.account_id_txt.SelectedText = ""
        Me.account_id_txt.ShadowDecoration.Parent = Me.account_id_txt
        Me.account_id_txt.Size = New System.Drawing.Size(441, 42)
        Me.account_id_txt.TabIndex = 57
        '
        'transferVERIFYbtn
        '
        Me.transferVERIFYbtn.BorderRadius = 7
        Me.transferVERIFYbtn.CheckedState.Parent = Me.transferVERIFYbtn
        Me.transferVERIFYbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transferVERIFYbtn.CustomImages.Parent = Me.transferVERIFYbtn
        Me.transferVERIFYbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transferVERIFYbtn.ForeColor = System.Drawing.Color.White
        Me.transferVERIFYbtn.HoverState.Parent = Me.transferVERIFYbtn
        Me.transferVERIFYbtn.Location = New System.Drawing.Point(18, 174)
        Me.transferVERIFYbtn.Name = "transferVERIFYbtn"
        Me.transferVERIFYbtn.ShadowDecoration.Parent = Me.transferVERIFYbtn
        Me.transferVERIFYbtn.Size = New System.Drawing.Size(125, 39)
        Me.transferVERIFYbtn.TabIndex = 41
        Me.transferVERIFYbtn.Text = "VERIFY"
        '
        'UserTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserTransfer"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents transferVERIFYbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents account_id_txt As Guna.UI2.WinForms.Guna2TextBox
End Class
