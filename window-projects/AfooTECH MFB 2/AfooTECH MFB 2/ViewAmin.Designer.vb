<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAmin))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.viewadminRecordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.fetch_staff_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AdminPictureBox = New System.Windows.Forms.PictureBox()
        Me.admin_select_image_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.nin_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mobile_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullname_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.genderComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RoleComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.StatusComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(777, 37)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(17, 8)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(250, 19)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "ADMIN FORM"
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
        Me.close_btn.Location = New System.Drawing.Point(724, -1)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(45, 37)
        Me.close_btn.TabIndex = 1
        Me.close_btn.Text = "x"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.Controls.Add(Me.viewadminRecordBtn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(777, 46)
        Me.Guna2Panel2.TabIndex = 2
        '
        'viewadminRecordBtn
        '
        Me.viewadminRecordBtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.viewadminRecordBtn.BorderRadius = 7
        Me.viewadminRecordBtn.CheckedState.Parent = Me.viewadminRecordBtn
        Me.viewadminRecordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewadminRecordBtn.CustomImages.Parent = Me.viewadminRecordBtn
        Me.viewadminRecordBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.viewadminRecordBtn.ForeColor = System.Drawing.Color.White
        Me.viewadminRecordBtn.HoverState.Parent = Me.viewadminRecordBtn
        Me.viewadminRecordBtn.Location = New System.Drawing.Point(16, 8)
        Me.viewadminRecordBtn.Name = "viewadminRecordBtn"
        Me.viewadminRecordBtn.ShadowDecoration.Parent = Me.viewadminRecordBtn
        Me.viewadminRecordBtn.Size = New System.Drawing.Size(129, 29)
        Me.viewadminRecordBtn.TabIndex = 0
        Me.viewadminRecordBtn.Text = "ADMIN RECORD"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.profile_id)
        Me.GroupBox1.Controls.Add(Me.fetch_staff_btn)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 113)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STAFF ID"
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
        Me.profile_id.Location = New System.Drawing.Point(26, 19)
        Me.profile_id.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(695, 36)
        Me.profile_id.TabIndex = 2
        '
        'fetch_staff_btn
        '
        Me.fetch_staff_btn.BorderRadius = 7
        Me.fetch_staff_btn.CheckedState.Parent = Me.fetch_staff_btn
        Me.fetch_staff_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_staff_btn.CustomImages.Parent = Me.fetch_staff_btn
        Me.fetch_staff_btn.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_staff_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_staff_btn.HoverState.Parent = Me.fetch_staff_btn
        Me.fetch_staff_btn.Location = New System.Drawing.Point(551, 65)
        Me.fetch_staff_btn.Name = "fetch_staff_btn"
        Me.fetch_staff_btn.ShadowDecoration.Parent = Me.fetch_staff_btn
        Me.fetch_staff_btn.Size = New System.Drawing.Size(169, 33)
        Me.fetch_staff_btn.TabIndex = 1
        Me.fetch_staff_btn.Text = "FETCH ADMIN"
        '
        'admin_clear_btn
        '
        Me.admin_clear_btn.BorderRadius = 7
        Me.admin_clear_btn.CheckedState.Parent = Me.admin_clear_btn
        Me.admin_clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_clear_btn.CustomImages.Parent = Me.admin_clear_btn
        Me.admin_clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.admin_clear_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_clear_btn.ForeColor = System.Drawing.Color.White
        Me.admin_clear_btn.HoverState.Parent = Me.admin_clear_btn
        Me.admin_clear_btn.Location = New System.Drawing.Point(534, 587)
        Me.admin_clear_btn.Name = "admin_clear_btn"
        Me.admin_clear_btn.ShadowDecoration.Parent = Me.admin_clear_btn
        Me.admin_clear_btn.Size = New System.Drawing.Size(201, 40)
        Me.admin_clear_btn.TabIndex = 1
        Me.admin_clear_btn.Text = "CLEAR"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.AdminPictureBox)
        Me.GroupBox3.Controls.Add(Me.admin_select_image_btn)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(507, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 294)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECT PASSPORT"
        '
        'AdminPictureBox
        '
        Me.AdminPictureBox.BackgroundImage = CType(resources.GetObject("AdminPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.AdminPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminPictureBox.Location = New System.Drawing.Point(21, 20)
        Me.AdminPictureBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AdminPictureBox.Name = "AdminPictureBox"
        Me.AdminPictureBox.Size = New System.Drawing.Size(201, 206)
        Me.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminPictureBox.TabIndex = 18
        Me.AdminPictureBox.TabStop = False
        '
        'admin_select_image_btn
        '
        Me.admin_select_image_btn.BorderRadius = 7
        Me.admin_select_image_btn.CheckedState.Parent = Me.admin_select_image_btn
        Me.admin_select_image_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_select_image_btn.CustomImages.Parent = Me.admin_select_image_btn
        Me.admin_select_image_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_select_image_btn.ForeColor = System.Drawing.Color.White
        Me.admin_select_image_btn.HoverState.Parent = Me.admin_select_image_btn
        Me.admin_select_image_btn.Location = New System.Drawing.Point(21, 240)
        Me.admin_select_image_btn.Name = "admin_select_image_btn"
        Me.admin_select_image_btn.ShadowDecoration.Parent = Me.admin_select_image_btn
        Me.admin_select_image_btn.Size = New System.Drawing.Size(201, 40)
        Me.admin_select_image_btn.TabIndex = 17
        Me.admin_select_image_btn.Text = "SELECT PASSPORT"
        '
        'admin_submit_btn
        '
        Me.admin_submit_btn.BorderRadius = 7
        Me.admin_submit_btn.CheckedState.Parent = Me.admin_submit_btn
        Me.admin_submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_submit_btn.CustomImages.Parent = Me.admin_submit_btn
        Me.admin_submit_btn.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_submit_btn.ForeColor = System.Drawing.Color.White
        Me.admin_submit_btn.HoverState.Parent = Me.admin_submit_btn
        Me.admin_submit_btn.Location = New System.Drawing.Point(530, 519)
        Me.admin_submit_btn.Name = "admin_submit_btn"
        Me.admin_submit_btn.ShadowDecoration.Parent = Me.admin_submit_btn
        Me.admin_submit_btn.Size = New System.Drawing.Size(201, 40)
        Me.admin_submit_btn.TabIndex = 1
        Me.admin_submit_btn.Text = "SUBMIT"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GroupBox2.Controls.Add(Me.nin_txt)
        Me.GroupBox2.Controls.Add(Me.email_txt)
        Me.GroupBox2.Controls.Add(Me.mobile_txt)
        Me.GroupBox2.Controls.Add(Me.fullname_txt)
        Me.GroupBox2.Controls.Add(Me.genderComboBox)
        Me.GroupBox2.Controls.Add(Me.RoleComboBox)
        Me.GroupBox2.Controls.Add(Me.StatusComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 428)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STAFF INFORMATION"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(28, -44)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(250, 19)
        Me.Guna2HtmlLabel4.TabIndex = 26
        Me.Guna2HtmlLabel4.Text = "Full Name"
        '
        'nin_txt
        '
        Me.nin_txt.BorderRadius = 5
        Me.nin_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nin_txt.DefaultText = ""
        Me.nin_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nin_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nin_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nin_txt.DisabledState.Parent = Me.nin_txt
        Me.nin_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nin_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nin_txt.FocusedState.Parent = Me.nin_txt
        Me.nin_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nin_txt.ForeColor = System.Drawing.Color.Black
        Me.nin_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nin_txt.HoverState.Parent = Me.nin_txt
        Me.nin_txt.Location = New System.Drawing.Point(28, 190)
        Me.nin_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.nin_txt.Name = "nin_txt"
        Me.nin_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nin_txt.PlaceholderText = "Enter Your NIN"
        Me.nin_txt.SelectedText = ""
        Me.nin_txt.ShadowDecoration.Parent = Me.nin_txt
        Me.nin_txt.Size = New System.Drawing.Size(413, 44)
        Me.nin_txt.TabIndex = 23
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
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_txt.ForeColor = System.Drawing.Color.Black
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(28, 135)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = "Enter Your Email Address"
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(413, 44)
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
        Me.mobile_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.FocusedState.Parent = Me.mobile_txt
        Me.mobile_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile_txt.ForeColor = System.Drawing.Color.Black
        Me.mobile_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobile_txt.HoverState.Parent = Me.mobile_txt
        Me.mobile_txt.Location = New System.Drawing.Point(28, 79)
        Me.mobile_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.mobile_txt.Name = "mobile_txt"
        Me.mobile_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mobile_txt.PlaceholderText = "Enter Your Mobile "
        Me.mobile_txt.SelectedText = ""
        Me.mobile_txt.ShadowDecoration.Parent = Me.mobile_txt
        Me.mobile_txt.Size = New System.Drawing.Size(413, 44)
        Me.mobile_txt.TabIndex = 21
        '
        'fullname_txt
        '
        Me.fullname_txt.BorderRadius = 5
        Me.fullname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_txt.DefaultText = ""
        Me.fullname_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.DisabledState.Parent = Me.fullname_txt
        Me.fullname_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.FocusedState.Parent = Me.fullname_txt
        Me.fullname_txt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_txt.ForeColor = System.Drawing.Color.Black
        Me.fullname_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.HoverState.Parent = Me.fullname_txt
        Me.fullname_txt.Location = New System.Drawing.Point(28, 23)
        Me.fullname_txt.Margin = New System.Windows.Forms.Padding(6)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_txt.PlaceholderText = "Enter Your Full Name"
        Me.fullname_txt.SelectedText = ""
        Me.fullname_txt.ShadowDecoration.Parent = Me.fullname_txt
        Me.fullname_txt.Size = New System.Drawing.Size(413, 44)
        Me.fullname_txt.TabIndex = 20
        '
        'genderComboBox
        '
        Me.genderComboBox.AllowDrop = True
        Me.genderComboBox.BackColor = System.Drawing.Color.Transparent
        Me.genderComboBox.BorderRadius = 5
        Me.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.genderComboBox.FocusedState.Parent = Me.genderComboBox
        Me.genderComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.genderComboBox.ForeColor = System.Drawing.Color.Black
        Me.genderComboBox.FormattingEnabled = True
        Me.genderComboBox.HoverState.Parent = Me.genderComboBox
        Me.genderComboBox.ItemHeight = 40
        Me.genderComboBox.Items.AddRange(New Object() {"ENTER YOUR GENDER"})
        Me.genderComboBox.ItemsAppearance.Parent = Me.genderComboBox
        Me.genderComboBox.Location = New System.Drawing.Point(27, 248)
        Me.genderComboBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.genderComboBox.Name = "genderComboBox"
        Me.genderComboBox.ShadowDecoration.Parent = Me.genderComboBox
        Me.genderComboBox.Size = New System.Drawing.Size(412, 46)
        Me.genderComboBox.TabIndex = 16
        '
        'RoleComboBox
        '
        Me.RoleComboBox.AllowDrop = True
        Me.RoleComboBox.BackColor = System.Drawing.Color.Transparent
        Me.RoleComboBox.BorderRadius = 5
        Me.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.RoleComboBox.FocusedState.Parent = Me.RoleComboBox
        Me.RoleComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RoleComboBox.ForeColor = System.Drawing.Color.Black
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.HoverState.Parent = Me.RoleComboBox
        Me.RoleComboBox.ItemHeight = 40
        Me.RoleComboBox.ItemsAppearance.Parent = Me.RoleComboBox
        Me.RoleComboBox.Location = New System.Drawing.Point(26, 308)
        Me.RoleComboBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.ShadowDecoration.Parent = Me.RoleComboBox
        Me.RoleComboBox.Size = New System.Drawing.Size(412, 46)
        Me.RoleComboBox.TabIndex = 18
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AllowDrop = True
        Me.StatusComboBox.BackColor = System.Drawing.Color.Transparent
        Me.StatusComboBox.BorderRadius = 5
        Me.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.StatusComboBox.FocusedState.Parent = Me.StatusComboBox
        Me.StatusComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StatusComboBox.ForeColor = System.Drawing.Color.Black
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.HoverState.Parent = Me.StatusComboBox
        Me.StatusComboBox.ItemHeight = 40
        Me.StatusComboBox.ItemsAppearance.Parent = Me.StatusComboBox
        Me.StatusComboBox.Location = New System.Drawing.Point(26, 367)
        Me.StatusComboBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.ShadowDecoration.Parent = Me.StatusComboBox
        Me.StatusComboBox.Size = New System.Drawing.Size(412, 46)
        Me.StatusComboBox.TabIndex = 17
        '
        'ViewAmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(768, 657)
        Me.Controls.Add(Me.admin_submit_btn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.admin_clear_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewAmin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAmin"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents viewadminRecordBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fetch_staff_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents admin_clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents admin_select_image_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AdminPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents nin_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mobile_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fullname_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents genderComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RoleComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents StatusComboBox As Guna.UI2.WinForms.Guna2ComboBox
End Class
