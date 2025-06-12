<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLoan))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.loan_duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loan_amount_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loan_schedule_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.loan_id_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mobile_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullname_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.customer_clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(719, 37)
        Me.Guna2Panel1.TabIndex = 27
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(17, 9)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(242, 19)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "LOAN RECORD FORM"
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
        Me.close_btn.Location = New System.Drawing.Point(669, 1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(45, 36)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "x"
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
        Me.profile_id.ForeColor = System.Drawing.Color.Black
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(20, 16)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(638, 36)
        Me.profile_id.TabIndex = 2
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
        Me.loan_duration_txt.Enabled = False
        Me.loan_duration_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.FocusedState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_duration_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_duration_txt.HoverState.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Location = New System.Drawing.Point(20, 389)
        Me.loan_duration_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.loan_duration_txt.Name = "loan_duration_txt"
        Me.loan_duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_duration_txt.PlaceholderText = "Loan Duration"
        Me.loan_duration_txt.SelectedText = ""
        Me.loan_duration_txt.ShadowDecoration.Parent = Me.loan_duration_txt
        Me.loan_duration_txt.Size = New System.Drawing.Size(409, 44)
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
        Me.loan_amount_txt.Enabled = False
        Me.loan_amount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.FocusedState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_amount_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_amount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_amount_txt.HoverState.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Location = New System.Drawing.Point(20, 320)
        Me.loan_amount_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.loan_amount_txt.Name = "loan_amount_txt"
        Me.loan_amount_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_amount_txt.PlaceholderText = "Loan Amount"
        Me.loan_amount_txt.SelectedText = ""
        Me.loan_amount_txt.ShadowDecoration.Parent = Me.loan_amount_txt
        Me.loan_amount_txt.Size = New System.Drawing.Size(409, 44)
        Me.loan_amount_txt.TabIndex = 28
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.Controls.Add(Me.loan_schedule_btn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(-1, 37)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(719, 46)
        Me.Guna2Panel2.TabIndex = 28
        '
        'loan_schedule_btn
        '
        Me.loan_schedule_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.loan_schedule_btn.BorderRadius = 7
        Me.loan_schedule_btn.CheckedState.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loan_schedule_btn.CustomImages.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.loan_schedule_btn.ForeColor = System.Drawing.Color.White
        Me.loan_schedule_btn.HoverState.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Location = New System.Drawing.Point(16, 5)
        Me.loan_schedule_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.loan_schedule_btn.Name = "loan_schedule_btn"
        Me.loan_schedule_btn.ShadowDecoration.Parent = Me.loan_schedule_btn
        Me.loan_schedule_btn.Size = New System.Drawing.Size(141, 34)
        Me.loan_schedule_btn.TabIndex = 0
        Me.loan_schedule_btn.Text = "LOAN SCHEDULE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.profile_id)
        Me.GroupBox1.Controls.Add(Me.fetch_btn)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(679, 102)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER ID"
        '
        'fetch_btn
        '
        Me.fetch_btn.BorderRadius = 7
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(494, 56)
        Me.fetch_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(164, 39)
        Me.fetch_btn.TabIndex = 1
        Me.fetch_btn.Text = "FETCH CUSTOMER"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.loan_duration_txt)
        Me.GroupBox2.Controls.Add(Me.loan_id_txt)
        Me.GroupBox2.Controls.Add(Me.loan_amount_txt)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GroupBox2.Controls.Add(Me.email_txt)
        Me.GroupBox2.Controls.Add(Me.mobile_txt)
        Me.GroupBox2.Controls.Add(Me.fullname_txt)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 197)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(445, 447)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER INFORMATION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "FullName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Mobile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Loan ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Loan Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Loan Duration"
        '
        'loan_id_txt
        '
        Me.loan_id_txt.BorderRadius = 5
        Me.loan_id_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loan_id_txt.DefaultText = ""
        Me.loan_id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loan_id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loan_id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_id_txt.DisabledState.Parent = Me.loan_id_txt
        Me.loan_id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loan_id_txt.Enabled = False
        Me.loan_id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_id_txt.FocusedState.Parent = Me.loan_id_txt
        Me.loan_id_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_id_txt.ForeColor = System.Drawing.Color.Black
        Me.loan_id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loan_id_txt.HoverState.Parent = Me.loan_id_txt
        Me.loan_id_txt.Location = New System.Drawing.Point(21, 251)
        Me.loan_id_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.loan_id_txt.Name = "loan_id_txt"
        Me.loan_id_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loan_id_txt.PlaceholderText = "BVN"
        Me.loan_id_txt.SelectedText = ""
        Me.loan_id_txt.ShadowDecoration.Parent = Me.loan_id_txt
        Me.loan_id_txt.Size = New System.Drawing.Size(409, 44)
        Me.loan_id_txt.TabIndex = 27
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
        'email_txt
        '
        Me.email_txt.BorderRadius = 5
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.Enabled = False
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(20, 113)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(409, 44)
        Me.email_txt.TabIndex = 22
        '
        'mobile_txt
        '
        Me.mobile_txt.BorderRadius = 5
        Me.mobile_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mobile_txt.DefaultText = ""
        Me.mobile_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mobile_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mobile_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobile_txt.DisabledState.Parent = Me.mobile_txt
        Me.mobile_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobile_txt.Enabled = False
        Me.mobile_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.FocusedState.Parent = Me.mobile_txt
        Me.mobile_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile_txt.ForeColor = System.Drawing.Color.Black
        Me.mobile_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.HoverState.Parent = Me.mobile_txt
        Me.mobile_txt.Location = New System.Drawing.Point(20, 183)
        Me.mobile_txt.Margin = New System.Windows.Forms.Padding(5)
        Me.mobile_txt.Name = "mobile_txt"
        Me.mobile_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mobile_txt.PlaceholderText = "Mobile Number "
        Me.mobile_txt.SelectedText = ""
        Me.mobile_txt.ShadowDecoration.Parent = Me.mobile_txt
        Me.mobile_txt.Size = New System.Drawing.Size(409, 44)
        Me.mobile_txt.TabIndex = 21
        '
        'fullname_txt
        '
        Me.fullname_txt.BackColor = System.Drawing.SystemColors.Control
        Me.fullname_txt.BorderRadius = 5
        Me.fullname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_txt.DefaultText = ""
        Me.fullname_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.DisabledState.Parent = Me.fullname_txt
        Me.fullname_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.Enabled = False
        Me.fullname_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.FocusedState.Parent = Me.fullname_txt
        Me.fullname_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_txt.ForeColor = System.Drawing.Color.Black
        Me.fullname_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.HoverState.Parent = Me.fullname_txt
        Me.fullname_txt.Location = New System.Drawing.Point(20, 42)
        Me.fullname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_txt.PlaceholderText = "Full Name"
        Me.fullname_txt.SelectedText = ""
        Me.fullname_txt.ShadowDecoration.Parent = Me.fullname_txt
        Me.fullname_txt.Size = New System.Drawing.Size(409, 44)
        Me.fullname_txt.TabIndex = 20
        '
        'PictureBox
        '
        Me.PictureBox.BackgroundImage = CType(resources.GetObject("PictureBox.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox.Location = New System.Drawing.Point(8, 18)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(197, 235)
        Me.PictureBox.TabIndex = 18
        Me.PictureBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.PictureBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(480, 197)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(215, 264)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECT PASSPORT"
        '
        'customer_clear_btn
        '
        Me.customer_clear_btn.BorderRadius = 7
        Me.customer_clear_btn.CheckedState.Parent = Me.customer_clear_btn
        Me.customer_clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customer_clear_btn.CustomImages.Parent = Me.customer_clear_btn
        Me.customer_clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.customer_clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_clear_btn.ForeColor = System.Drawing.Color.White
        Me.customer_clear_btn.HoverState.Parent = Me.customer_clear_btn
        Me.customer_clear_btn.Location = New System.Drawing.Point(500, 584)
        Me.customer_clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.customer_clear_btn.Name = "customer_clear_btn"
        Me.customer_clear_btn.ShadowDecoration.Parent = Me.customer_clear_btn
        Me.customer_clear_btn.Size = New System.Drawing.Size(197, 41)
        Me.customer_clear_btn.TabIndex = 31
        Me.customer_clear_btn.Text = "CLOSE"
        '
        'ViewLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(713, 667)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.customer_clear_btn)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewLoan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewLoan"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loan_schedule_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents loan_duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents loan_amount_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents loan_id_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mobile_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fullname_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents customer_clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
