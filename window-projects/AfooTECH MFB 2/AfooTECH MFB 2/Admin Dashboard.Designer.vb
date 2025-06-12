<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimize_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.admin_logout_btn = New Guna.UI.WinForms.GunaButton()
        Me.home_page_panel = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.withdrawl_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.deposit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.amin_logoutBTN = New Guna.UI.WinForms.GunaButton()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.settings_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_loan_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_customer_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.viewadmin_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.admina_dashboard_btn = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.role_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.admin_image = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.last_login_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.staff_fullname_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.role_id = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.time_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel5 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel6 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel7 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.total_admin_label = New System.Windows.Forms.Label()
        Me.total_customer_label = New System.Windows.Forms.Label()
        Me.total_loan_label = New System.Windows.Forms.Label()
        Me.total_balance_label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.home_page_panel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.admin_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.Guna2CustomGradientPanel5.SuspendLayout()
        Me.Guna2CustomGradientPanel6.SuspendLayout()
        Me.Guna2CustomGradientPanel4.SuspendLayout()
        Me.Guna2CustomGradientPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.minimize_btn)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1945, 69)
        Me.Panel1.TabIndex = 15
        '
        'minimize_btn
        '
        Me.minimize_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize_btn.BackColor = System.Drawing.Color.Transparent
        Me.minimize_btn.CheckedState.Parent = Me.minimize_btn
        Me.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize_btn.CustomImages.Parent = Me.minimize_btn
        Me.minimize_btn.FillColor = System.Drawing.Color.LightGray
        Me.minimize_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimize_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.minimize_btn.HoverState.FillColor = System.Drawing.Color.Silver
        Me.minimize_btn.HoverState.Parent = Me.minimize_btn
        Me.minimize_btn.Location = New System.Drawing.Point(1806, 0)
        Me.minimize_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minimize_btn.Name = "minimize_btn"
        Me.minimize_btn.ShadowDecoration.Parent = Me.minimize_btn
        Me.minimize_btn.Size = New System.Drawing.Size(70, 69)
        Me.minimize_btn.TabIndex = 5
        Me.minimize_btn.Text = "-"
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.CheckedState.Parent = Me.close_btn
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.CustomImages.Parent = Me.close_btn
        Me.close_btn.FillColor = System.Drawing.Color.LightGray
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.close_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.close_btn.HoverState.ForeColor = System.Drawing.Color.White
        Me.close_btn.HoverState.Parent = Me.close_btn
        Me.close_btn.Location = New System.Drawing.Point(1876, 0)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(70, 69)
        Me.close_btn.TabIndex = 4
        Me.close_btn.Text = "X"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1320, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "WELCOME TO AfooTECH MICROFINANCE BANK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'admin_logout_btn
        '
        Me.admin_logout_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admin_logout_btn.AnimationHoverSpeed = 0.07!
        Me.admin_logout_btn.AnimationSpeed = 0.03!
        Me.admin_logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.admin_logout_btn.BaseColor = System.Drawing.Color.Chocolate
        Me.admin_logout_btn.BorderColor = System.Drawing.Color.Black
        Me.admin_logout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_logout_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.admin_logout_btn.FocusedColor = System.Drawing.Color.Empty
        Me.admin_logout_btn.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_logout_btn.ForeColor = System.Drawing.Color.White
        Me.admin_logout_btn.Image = CType(resources.GetObject("admin_logout_btn.Image"), System.Drawing.Image)
        Me.admin_logout_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.admin_logout_btn.Location = New System.Drawing.Point(1392, 15)
        Me.admin_logout_btn.Name = "admin_logout_btn"
        Me.admin_logout_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.admin_logout_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.admin_logout_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.admin_logout_btn.OnHoverImage = Nothing
        Me.admin_logout_btn.OnPressedColor = System.Drawing.Color.Black
        Me.admin_logout_btn.Radius = 5
        Me.admin_logout_btn.Size = New System.Drawing.Size(164, 57)
        Me.admin_logout_btn.TabIndex = 4
        Me.admin_logout_btn.Text = "LOG OUT"
        '
        'home_page_panel
        '
        Me.home_page_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.home_page_panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.home_page_panel.Controls.Add(Me.Guna2PictureBox1)
        Me.home_page_panel.Controls.Add(Me.withdrawl_btn)
        Me.home_page_panel.Controls.Add(Me.deposit_btn)
        Me.home_page_panel.Controls.Add(Me.amin_logoutBTN)
        Me.home_page_panel.Controls.Add(Me.Guna2Button5)
        Me.home_page_panel.Controls.Add(Me.settings_btn)
        Me.home_page_panel.Controls.Add(Me.view_loan_btn)
        Me.home_page_panel.Controls.Add(Me.view_customer_btn)
        Me.home_page_panel.Controls.Add(Me.viewadmin_btn)
        Me.home_page_panel.Controls.Add(Me.admina_dashboard_btn)
        Me.home_page_panel.Location = New System.Drawing.Point(3, 68)
        Me.home_page_panel.Name = "home_page_panel"
        Me.home_page_panel.Size = New System.Drawing.Size(357, 1037)
        Me.home_page_panel.TabIndex = 16
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 5
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.WhatsApp_Image_2024_09_19_at_18_57_36_fa613b3b
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(15, 18)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(328, 262)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 38
        Me.Guna2PictureBox1.TabStop = False
        '
        'withdrawl_btn
        '
        Me.withdrawl_btn.BorderRadius = 5
        Me.withdrawl_btn.CheckedState.Parent = Me.withdrawl_btn
        Me.withdrawl_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.withdrawl_btn.CustomImages.Parent = Me.withdrawl_btn
        Me.withdrawl_btn.FillColor = System.Drawing.Color.LightGray
        Me.withdrawl_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdrawl_btn.ForeColor = System.Drawing.Color.Black
        Me.withdrawl_btn.HoverState.Parent = Me.withdrawl_btn
        Me.withdrawl_btn.Location = New System.Drawing.Point(14, 725)
        Me.withdrawl_btn.Name = "withdrawl_btn"
        Me.withdrawl_btn.ShadowDecoration.Parent = Me.withdrawl_btn
        Me.withdrawl_btn.Size = New System.Drawing.Size(330, 75)
        Me.withdrawl_btn.TabIndex = 21
        Me.withdrawl_btn.Text = "WITHDRAWAL"
        '
        'deposit_btn
        '
        Me.deposit_btn.BorderRadius = 5
        Me.deposit_btn.CheckedState.Parent = Me.deposit_btn
        Me.deposit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deposit_btn.CustomImages.Parent = Me.deposit_btn
        Me.deposit_btn.FillColor = System.Drawing.Color.LightGray
        Me.deposit_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deposit_btn.ForeColor = System.Drawing.Color.Black
        Me.deposit_btn.HoverState.Parent = Me.deposit_btn
        Me.deposit_btn.Location = New System.Drawing.Point(14, 640)
        Me.deposit_btn.Name = "deposit_btn"
        Me.deposit_btn.ShadowDecoration.Parent = Me.deposit_btn
        Me.deposit_btn.Size = New System.Drawing.Size(330, 75)
        Me.deposit_btn.TabIndex = 20
        Me.deposit_btn.Text = "DEPOSIT"
        '
        'amin_logoutBTN
        '
        Me.amin_logoutBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.amin_logoutBTN.AnimationHoverSpeed = 0.07!
        Me.amin_logoutBTN.AnimationSpeed = 0.03!
        Me.amin_logoutBTN.BackColor = System.Drawing.Color.Transparent
        Me.amin_logoutBTN.BaseColor = System.Drawing.Color.Chocolate
        Me.amin_logoutBTN.BorderColor = System.Drawing.Color.Black
        Me.amin_logoutBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.amin_logoutBTN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.amin_logoutBTN.FocusedColor = System.Drawing.Color.Empty
        Me.amin_logoutBTN.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amin_logoutBTN.ForeColor = System.Drawing.Color.White
        Me.amin_logoutBTN.Image = CType(resources.GetObject("amin_logoutBTN.Image"), System.Drawing.Image)
        Me.amin_logoutBTN.ImageSize = New System.Drawing.Size(20, 20)
        Me.amin_logoutBTN.Location = New System.Drawing.Point(14, 949)
        Me.amin_logoutBTN.Name = "amin_logoutBTN"
        Me.amin_logoutBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.amin_logoutBTN.OnHoverBorderColor = System.Drawing.Color.Black
        Me.amin_logoutBTN.OnHoverForeColor = System.Drawing.Color.White
        Me.amin_logoutBTN.OnHoverImage = Nothing
        Me.amin_logoutBTN.OnPressedColor = System.Drawing.Color.Black
        Me.amin_logoutBTN.Radius = 5
        Me.amin_logoutBTN.Size = New System.Drawing.Size(330, 75)
        Me.amin_logoutBTN.TabIndex = 19
        Me.amin_logoutBTN.Text = "LOG OUT"
        Me.amin_logoutBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button5.BorderRadius = 5
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.Chocolate
        Me.Guna2Button5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(12, 1387)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(330, 75)
        Me.Guna2Button5.TabIndex = 18
        Me.Guna2Button5.Text = "LOG OUT"
        '
        'settings_btn
        '
        Me.settings_btn.BorderRadius = 5
        Me.settings_btn.CheckedState.Parent = Me.settings_btn
        Me.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_btn.CustomImages.Parent = Me.settings_btn
        Me.settings_btn.FillColor = System.Drawing.Color.LightGray
        Me.settings_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_btn.ForeColor = System.Drawing.Color.Black
        Me.settings_btn.HoverState.Parent = Me.settings_btn
        Me.settings_btn.Location = New System.Drawing.Point(14, 811)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.ShadowDecoration.Parent = Me.settings_btn
        Me.settings_btn.Size = New System.Drawing.Size(330, 75)
        Me.settings_btn.TabIndex = 17
        Me.settings_btn.Text = "SETTINGS"
        '
        'view_loan_btn
        '
        Me.view_loan_btn.BorderRadius = 5
        Me.view_loan_btn.CheckedState.Parent = Me.view_loan_btn
        Me.view_loan_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_loan_btn.CustomImages.Parent = Me.view_loan_btn
        Me.view_loan_btn.FillColor = System.Drawing.Color.LightGray
        Me.view_loan_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_loan_btn.ForeColor = System.Drawing.Color.Black
        Me.view_loan_btn.HoverState.Parent = Me.view_loan_btn
        Me.view_loan_btn.Location = New System.Drawing.Point(14, 554)
        Me.view_loan_btn.Name = "view_loan_btn"
        Me.view_loan_btn.ShadowDecoration.Parent = Me.view_loan_btn
        Me.view_loan_btn.Size = New System.Drawing.Size(330, 75)
        Me.view_loan_btn.TabIndex = 16
        Me.view_loan_btn.Text = "VIEW LOAN"
        '
        'view_customer_btn
        '
        Me.view_customer_btn.BorderRadius = 5
        Me.view_customer_btn.CheckedState.Parent = Me.view_customer_btn
        Me.view_customer_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_customer_btn.CustomImages.Parent = Me.view_customer_btn
        Me.view_customer_btn.FillColor = System.Drawing.Color.LightGray
        Me.view_customer_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_customer_btn.ForeColor = System.Drawing.Color.Black
        Me.view_customer_btn.HoverState.Parent = Me.view_customer_btn
        Me.view_customer_btn.Location = New System.Drawing.Point(14, 469)
        Me.view_customer_btn.Name = "view_customer_btn"
        Me.view_customer_btn.ShadowDecoration.Parent = Me.view_customer_btn
        Me.view_customer_btn.Size = New System.Drawing.Size(330, 75)
        Me.view_customer_btn.TabIndex = 15
        Me.view_customer_btn.Text = "VIEW CUSTOMER"
        '
        'viewadmin_btn
        '
        Me.viewadmin_btn.BorderRadius = 5
        Me.viewadmin_btn.CheckedState.Parent = Me.viewadmin_btn
        Me.viewadmin_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewadmin_btn.CustomImages.Parent = Me.viewadmin_btn
        Me.viewadmin_btn.FillColor = System.Drawing.Color.LightGray
        Me.viewadmin_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewadmin_btn.ForeColor = System.Drawing.Color.Black
        Me.viewadmin_btn.HoverState.Parent = Me.viewadmin_btn
        Me.viewadmin_btn.Location = New System.Drawing.Point(14, 385)
        Me.viewadmin_btn.Name = "viewadmin_btn"
        Me.viewadmin_btn.ShadowDecoration.Parent = Me.viewadmin_btn
        Me.viewadmin_btn.Size = New System.Drawing.Size(330, 75)
        Me.viewadmin_btn.TabIndex = 14
        Me.viewadmin_btn.Text = "VIEW ADMIN"
        '
        'admina_dashboard_btn
        '
        Me.admina_dashboard_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admina_dashboard_btn.AnimationHoverSpeed = 0.07!
        Me.admina_dashboard_btn.AnimationSpeed = 0.03!
        Me.admina_dashboard_btn.BackColor = System.Drawing.Color.Transparent
        Me.admina_dashboard_btn.BaseColor = System.Drawing.Color.LightGray
        Me.admina_dashboard_btn.BorderColor = System.Drawing.Color.Black
        Me.admina_dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admina_dashboard_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.admina_dashboard_btn.FocusedColor = System.Drawing.Color.Empty
        Me.admina_dashboard_btn.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admina_dashboard_btn.ForeColor = System.Drawing.Color.Black
        Me.admina_dashboard_btn.Image = CType(resources.GetObject("admina_dashboard_btn.Image"), System.Drawing.Image)
        Me.admina_dashboard_btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.admina_dashboard_btn.Location = New System.Drawing.Point(14, 298)
        Me.admina_dashboard_btn.Name = "admina_dashboard_btn"
        Me.admina_dashboard_btn.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.admina_dashboard_btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.admina_dashboard_btn.OnHoverForeColor = System.Drawing.Color.White
        Me.admina_dashboard_btn.OnHoverImage = Nothing
        Me.admina_dashboard_btn.OnPressedColor = System.Drawing.Color.Black
        Me.admina_dashboard_btn.Radius = 5
        Me.admina_dashboard_btn.Size = New System.Drawing.Size(330, 75)
        Me.admina_dashboard_btn.TabIndex = 5
        Me.admina_dashboard_btn.Text = "DASHBOARD"
        Me.admina_dashboard_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.admin_logout_btn)
        Me.Panel3.Controls.Add(Me.role_txt)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Location = New System.Drawing.Point(374, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1572, 86)
        Me.Panel3.TabIndex = 31
        '
        'role_txt
        '
        Me.role_txt.AutoSize = False
        Me.role_txt.BackColor = System.Drawing.Color.Transparent
        Me.role_txt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role_txt.ForeColor = System.Drawing.Color.White
        Me.role_txt.Location = New System.Drawing.Point(98, 29)
        Me.role_txt.Name = "role_txt"
        Me.role_txt.Size = New System.Drawing.Size(345, 43)
        Me.role_txt.TabIndex = 34
        Me.role_txt.Text = "Admin Dashboard"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(34, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 8
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.admin_image)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.last_login_label)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.staff_fullname_label)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.role_id)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(374, 163)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1047, 182)
        Me.Guna2CustomGradientPanel1.TabIndex = 36
        '
        'admin_image
        '
        Me.admin_image.BorderRadius = 4
        Me.admin_image.Image = Global.AfooTECH_MFB_2.My.Resources.Resources.IMAGE
        Me.admin_image.Location = New System.Drawing.Point(40, 25)
        Me.admin_image.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.admin_image.Name = "admin_image"
        Me.admin_image.ShadowDecoration.Parent = Me.admin_image
        Me.admin_image.Size = New System.Drawing.Size(135, 134)
        Me.admin_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_image.TabIndex = 46
        Me.admin_image.TabStop = False
        '
        'last_login_label
        '
        Me.last_login_label.AutoSize = False
        Me.last_login_label.BackColor = System.Drawing.Color.Transparent
        Me.last_login_label.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.last_login_label.Location = New System.Drawing.Point(196, 126)
        Me.last_login_label.Name = "last_login_label"
        Me.last_login_label.Size = New System.Drawing.Size(548, 32)
        Me.last_login_label.TabIndex = 43
        Me.last_login_label.Text = "xxxxxxxxxx"
        '
        'staff_fullname_label
        '
        Me.staff_fullname_label.AutoSize = False
        Me.staff_fullname_label.BackColor = System.Drawing.Color.Transparent
        Me.staff_fullname_label.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_fullname_label.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.staff_fullname_label.Location = New System.Drawing.Point(196, 86)
        Me.staff_fullname_label.Name = "staff_fullname_label"
        Me.staff_fullname_label.Size = New System.Drawing.Size(556, 43)
        Me.staff_fullname_label.TabIndex = 41
        Me.staff_fullname_label.Text = "SETON ERI-OLUWA EMMANUEL"
        Me.staff_fullname_label.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'role_id
        '
        Me.role_id.AutoSize = False
        Me.role_id.BackColor = System.Drawing.Color.Transparent
        Me.role_id.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role_id.ForeColor = System.Drawing.Color.Black
        Me.role_id.Location = New System.Drawing.Point(196, 47)
        Me.role_id.Name = "role_id"
        Me.role_id.Size = New System.Drawing.Size(458, 39)
        Me.role_id.TabIndex = 42
        Me.role_id.Text = "Position name"
        Me.role_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.BorderRadius = 8
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.date_label)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.time_label)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(1464, 163)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(470, 182)
        Me.Guna2CustomGradientPanel2.TabIndex = 37
        '
        'date_label
        '
        Me.date_label.AutoSize = False
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.ForeColor = System.Drawing.Color.Black
        Me.date_label.Location = New System.Drawing.Point(50, 115)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(402, 35)
        Me.date_label.TabIndex = 41
        Me.date_label.Text = "xxxxx"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(50, 37)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(402, 45)
        Me.Guna2HtmlLabel2.TabIndex = 39
        Me.Guna2HtmlLabel2.Text = "Current Time"
        '
        'time_label
        '
        Me.time_label.AutoSize = False
        Me.time_label.BackColor = System.Drawing.Color.Transparent
        Me.time_label.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.ForeColor = System.Drawing.Color.DarkRed
        Me.time_label.Location = New System.Drawing.Point(50, 80)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(402, 35)
        Me.time_label.TabIndex = 40
        Me.time_label.Text = "xxxx"
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel3.BorderRadius = 8
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2CustomGradientPanel5)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2CustomGradientPanel6)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2CustomGradientPanel4)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Guna2CustomGradientPanel7)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(374, 364)
        Me.Guna2CustomGradientPanel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(1560, 734)
        Me.Guna2CustomGradientPanel3.TabIndex = 4
        '
        'Guna2CustomGradientPanel5
        '
        Me.Guna2CustomGradientPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CustomGradientPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel5.BorderRadius = 10
        Me.Guna2CustomGradientPanel5.Controls.Add(Me.total_loan_label)
        Me.Guna2CustomGradientPanel5.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel5.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel5.FillColor3 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2CustomGradientPanel5.Location = New System.Drawing.Point(799, 35)
        Me.Guna2CustomGradientPanel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel5.Name = "Guna2CustomGradientPanel5"
        Me.Guna2CustomGradientPanel5.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel5
        Me.Guna2CustomGradientPanel5.Size = New System.Drawing.Size(360, 200)
        Me.Guna2CustomGradientPanel5.TabIndex = 10
        '
        'Guna2CustomGradientPanel6
        '
        Me.Guna2CustomGradientPanel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel6.BorderRadius = 10
        Me.Guna2CustomGradientPanel6.Controls.Add(Me.total_admin_label)
        Me.Guna2CustomGradientPanel6.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel6.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel6.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel6.FillColor3 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel6.FillColor4 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2CustomGradientPanel6.Location = New System.Drawing.Point(32, 35)
        Me.Guna2CustomGradientPanel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel6.Name = "Guna2CustomGradientPanel6"
        Me.Guna2CustomGradientPanel6.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel6
        Me.Guna2CustomGradientPanel6.Size = New System.Drawing.Size(360, 200)
        Me.Guna2CustomGradientPanel6.TabIndex = 10
        '
        'Guna2CustomGradientPanel4
        '
        Me.Guna2CustomGradientPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CustomGradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel4.BorderRadius = 10
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.total_customer_label)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel4.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2CustomGradientPanel4.Location = New System.Drawing.Point(422, 35)
        Me.Guna2CustomGradientPanel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Me.Guna2CustomGradientPanel4.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel4
        Me.Guna2CustomGradientPanel4.Size = New System.Drawing.Size(360, 200)
        Me.Guna2CustomGradientPanel4.TabIndex = 7
        '
        'Guna2CustomGradientPanel7
        '
        Me.Guna2CustomGradientPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CustomGradientPanel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel7.BorderRadius = 10
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.total_balance_label)
        Me.Guna2CustomGradientPanel7.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel7.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel7.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel7.FillColor3 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel7.FillColor4 = System.Drawing.Color.CornflowerBlue
        Me.Guna2CustomGradientPanel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2CustomGradientPanel7.Location = New System.Drawing.Point(1186, 35)
        Me.Guna2CustomGradientPanel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel7.Name = "Guna2CustomGradientPanel7"
        Me.Guna2CustomGradientPanel7.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel7
        Me.Guna2CustomGradientPanel7.Size = New System.Drawing.Size(360, 200)
        Me.Guna2CustomGradientPanel7.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 43)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 43)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Customer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 43)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Loan Balance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 43)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Account Balance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_admin_label
        '
        Me.total_admin_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_admin_label.Location = New System.Drawing.Point(7, 105)
        Me.total_admin_label.Name = "total_admin_label"
        Me.total_admin_label.Size = New System.Drawing.Size(318, 43)
        Me.total_admin_label.TabIndex = 7
        Me.total_admin_label.Text = "0"
        Me.total_admin_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_customer_label
        '
        Me.total_customer_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_customer_label.Location = New System.Drawing.Point(12, 105)
        Me.total_customer_label.Name = "total_customer_label"
        Me.total_customer_label.Size = New System.Drawing.Size(318, 43)
        Me.total_customer_label.TabIndex = 8
        Me.total_customer_label.Text = "0"
        Me.total_customer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_loan_label
        '
        Me.total_loan_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_loan_label.Location = New System.Drawing.Point(11, 105)
        Me.total_loan_label.Name = "total_loan_label"
        Me.total_loan_label.Size = New System.Drawing.Size(318, 43)
        Me.total_loan_label.TabIndex = 9
        Me.total_loan_label.Text = "0"
        Me.total_loan_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_balance_label
        '
        Me.total_balance_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_balance_label.Location = New System.Drawing.Point(7, 105)
        Me.total_balance_label.Name = "total_balance_label"
        Me.total_balance_label.Size = New System.Drawing.Size(318, 43)
        Me.total_balance_label.TabIndex = 10
        Me.total_balance_label.Text = "0"
        Me.total_balance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Admin_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1946, 1106)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.home_page_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin_Dashboard"
        Me.Text = "Admin_Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.home_page_panel.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.admin_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel5.ResumeLayout(False)
        Me.Guna2CustomGradientPanel6.ResumeLayout(False)
        Me.Guna2CustomGradientPanel4.ResumeLayout(False)
        Me.Guna2CustomGradientPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents home_page_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents role_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents admin_logout_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents settings_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_loan_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_customer_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewadmin_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admina_dashboard_btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents amin_logoutBTN As Guna.UI.WinForms.GunaButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents deposit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents withdrawl_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents last_login_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents staff_fullname_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents role_id As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents time_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel5 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel6 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel7 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents minimize_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents admin_image As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents total_loan_label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents total_admin_label As System.Windows.Forms.Label
    Friend WithEvents total_customer_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents total_balance_label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
