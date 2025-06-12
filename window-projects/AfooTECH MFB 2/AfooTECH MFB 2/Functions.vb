Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Module Functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=mfb")
        Return conn
    End Function

    Function countId(ByVal mast_count_id As String)
        Dim connection = Functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE master_count_tab SET mast_count_value=mast_count_value+1 WHERE mast_count_id=@mast_count_id", connection)
        command.Parameters.AddWithValue("@mast_count_id", mast_count_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT mast_count_value FROM master_count_tab WHERE mast_count_id=@mast_count_id", connection)
        command.Parameters.AddWithValue("@mast_count_id", mast_count_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("mast_count_value")
        connection.Close()
        Return counter_value
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim regex As New Regex("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$")
        If String.IsNullOrEmpty(email) Then
            Return False
        End If
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function

    Function StaffemailCheck(ByVal email_address As String)
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function customerEmailCheck(ByVal email_address As String)
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function StaffupdateEmailCheck(ByVal email_address As String)
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address AND staff_id!=@staff_id", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        command.Parameters.AddWithValue("@staff_id", ViewAmin.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function CustomerupdateEmailCheck(ByVal email_address As String)
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address AND customer_id!=@customer_id", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        command.Parameters.AddWithValue("@customer_id", ViewCustomer.profile_id.SelectedValue)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function selectPassport(ByVal passport)
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
        Return passport
    End Function

    Public Sub AdminLogOutCloseBtn()
        Dim closeValidation = MessageBox.Show("Are you sure you want to LOG-OUT", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Admin_Dashboard.Close()
            Admin_Login.Show()
            AfooTECH_MFB.Show()
            AfooTECH_MFB.Panel2.Hide()
            AfooTECH_MFB.Panel4.Hide()
        End If
    End Sub

    Public Sub UserLogOutCloseBtn()
        Dim closeValidation = MessageBox.Show("Are you sure you want to LOG-OUT", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            UserDashboard.Close()
            UserLogin.Show()
            AfooTECH_MFB.Show()
            AfooTECH_MFB.Panel2.Hide()
            AfooTECH_MFB.Panel4.Hide()
        End If
    End Sub

    Public Sub directToDashboard()
        AfooTECH_MFB.Hide()
        Admin_Login.Hide()
        Admin_Login.email_txt.Text = ""
        Admin_Login.password_txt.Text = ""
        Admin_Dashboard.Show()
    End Sub

    Public Sub directToUserDashboard()
        AfooTECH_MFB.Hide()
        UserLogin.Hide()
        UserLogin.email_txt.Text = ""
        UserLogin.password_txt.Text = ""
        UserDashboard.Show()
    End Sub

    Public Sub directToAdminLogin()
        ResetPasswordFinish.Hide()
        Admin_Login.Show()
        ResetPasswordFinish.otp_txt.Text = ""
        ResetPasswordFinish.createnewpass_txt.Text = ""
        ResetPasswordFinish.confirmpass_txt.Text = ""
    End Sub

    Public Sub directToUserLogin()
        UserResetPasswordFinish.Hide()
        UserLogin.Show()
        UserResetPasswordFinish.otp_txt.Text = ""
        UserResetPasswordFinish.createnewpass_txt.Text = ""
        UserResetPasswordFinish.confirmpass_txt.Text = ""
    End Sub

    Function getStaffProfile(ByVal staff_id As String)
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT a.fullname, a.last_login, a.passport, b.role_name  FROM staff_tab a, setup_role_tab b WHERE staff_id=@staff_id AND a.role_id=b.role_id", connection)
        command.Parameters.AddWithValue("@staff_id", staff_id)
        reader = command.ExecuteReader
        reader.Read()

        Dim role_name = reader("role_name")
        Dim fullname = reader("fullname")
        Dim last_login = reader("last_login")
        Dim arrimage() As Byte = reader("passport")
        connection.close()
        Return Tuple.Create(fullname, last_login, arrimage, role_name)
    End Function
    Function getPassword(ByVal customer_id As String)

        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT password FROM customer_tab WHERE customer_id=@customer_id", connection)
        command.Parameters.AddWithValue("@customer_id", customer_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim password = reader("password")

        Return password
        connection.close()

    End Function
    Function getCustomerProfile(ByVal customer_id As String)
        Try
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT a.mobile_number, a.fullname, a.last_login, a.passport, a.password,FORMAT(b.account_balance, 2) AS formatted_account_balance, FORMAT(b.loan_balance, 2) AS formatted_loan_balance, b.customer_account_id FROM customer_tab a, customer_account_tab b WHERE a.customer_id=b.customer_id AND a.customer_id=@customer_id", connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            reader = command.ExecuteReader
            reader.Read()

            Dim mobile_number = reader("mobile_number")
            Dim fullname = reader("fullname")
            Dim last_login = reader("last_login")
            Dim account_balance = reader("formatted_account_balance")
            Dim loan_balance = reader("formatted_loan_balance")
            Dim customer_account_id = reader("customer_account_id")
            Dim arrimage() As Byte = reader("passport")
            Dim password = reader("password")

            Return Tuple.Create(mobile_number, fullname, last_login, account_balance, loan_balance, customer_account_id, arrimage, password)
            connection.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Public Sub getStaffID()
        Dim DT As New DataTable
        Dim connection = Functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("staff_id") = ""
        defaultRow("gender_id") = 0
        defaultRow("role_id") = 0
        defaultRow("status_id") = 0
        defaultRow("fullname") = "SELECT STAFF"
        defaultRow("email_address") = ""
        defaultRow("mobile_number") = ""
        defaultRow("nin") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        DT.Rows.InsertAt(defaultRow, 0)


        ViewAmin.profile_id.DataSource = DT
        ViewAmin.profile_id.DisplayMember = "fullname"
        ViewAmin.profile_id.ValueMember = "staff_id"
    End Sub

    Public Sub getCustomerID()
        Dim DT As New DataTable
        Dim connection = Functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("customer_id") = ""
        defaultRow("gender_id") = 0
        defaultRow("status_id") = 0
        defaultRow("fullname") = "SELECT CUSTOMER"
        defaultRow("email_address") = ""
        defaultRow("mobile_number") = 0
        defaultRow("nin") = ""
        defaultRow("bvn") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        defaultRow("status_name") = ""
        defaultRow("gender_name") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        ViewCustomer.profile_id.DataSource = DT
        ViewCustomer.profile_id.DisplayMember = "fullname"
        ViewCustomer.profile_id.ValueMember = "customer_id"

        DepositRecord.profile_id.DataSource = DT
        DepositRecord.profile_id.DisplayMember = "fullname"
        DepositRecord.profile_id.ValueMember = "customer_id"

        AdminWithdrawlForm.profile_id.DataSource = DT
        AdminWithdrawlForm.profile_id.DisplayMember = "fullname"
        AdminWithdrawlForm.profile_id.ValueMember = "customer_id"
    End Sub

    Public Sub getCustomerLoanID()
        Dim DT As New DataTable
        Dim connection = Functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.* FROM customer_tab a, loan_tab b WHERE a.customer_id=b.customer_id;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("customer_id") = ""
        defaultRow("customer_id1") = ""
        defaultRow("staff_id") = ""
        defaultRow("status_id") = 0
        defaultRow("gender_id") = 0
        defaultRow("loan_rate") = 0
        defaultRow("fullname") = "SELECT CUSTOMER"
        defaultRow("staff_fullname") = ""
        defaultRow("email_address") = ""
        defaultRow("mobile_number") = ""
        defaultRow("nin") = ""
        defaultRow("bvn") = ""
        defaultRow("password") = ""
        defaultRow("otp") = 0
        defaultRow("customer_id") = ""
        defaultRow("loan_id") = ""
        defaultRow("loan_amount") = 0
        defaultRow("loan_duration") = 0
        defaultRow("created_time") = Now.ToString
        defaultRow("created_time1") = Now.ToString
        DT.Rows.InsertAt(defaultRow, 0)

        ViewLoan.profile_id.DataSource = DT
        ViewLoan.profile_id.DisplayMember = "fullname"
        ViewLoan.profile_id.ValueMember = "customer_id"
    End Sub

    Public Sub getRole()
        Try
            Dim DT As New DataTable
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("role_id") = 0
            defaultRow("role_name") = "SELECT ROLE"
            DT.Rows.InsertAt(defaultRow, 0)

            ViewAmin.RoleComboBox.DataSource = DT
            ViewAmin.RoleComboBox.DisplayMember = "role_name"
            ViewAmin.RoleComboBox.ValueMember = "role_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function getStatus(ByVal combo)
        Try
            Dim DT As New DataTable
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_status_tab  WHERE status_id IN (1, 2, 3);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("status_id") = 0
            defaultRow("status_name") = "SELECT STATUS"
            DT.Rows.InsertAt(defaultRow, 0)

            combo.DataSource = DT
            combo.DisplayMember = "status_name"
            combo.ValueMember = "status_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading statuses: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return combo
    End Function

    Function getGender(ByVal combo)
        Try
            Dim DT As New DataTable
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM gender_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("gender_id") = 0
            defaultRow("gender_name") = "SELECT GENDER"
            DT.Rows.InsertAt(defaultRow, 0)

            combo.DataSource = DT
            combo.DisplayMember = "gender_name"
            combo.ValueMember = "gender_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading genders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return combo
    End Function

    Function passportSave(ByVal passportBox)
        Dim arrimage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        passportBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Return arrimage
    End Function

    Public Sub clearFunction()
        ViewAmin.fullname_txt.Text = ""
        ViewAmin.email_txt.Text = ""
        ViewAmin.mobile_txt.Text = ""
        ViewAmin.nin_txt.Text = ""
        ViewAmin.profile_id.Text = "SELECT STAFF"
        ViewAmin.RoleComboBox.Text = "SELECT ROLE"
        ViewAmin.StatusComboBox.Text = "SELECT STATUS"
        ViewAmin.genderComboBox.Text = "SELECT GENDER"
        ViewAmin.AdminPictureBox.Image = Nothing

        ViewCustomer.fullname_txt.Text = ""
        ViewCustomer.email_txt.Text = ""
        ViewCustomer.mobile_txt.Text = ""
        ViewCustomer.nin_txt.Text = ""
        ViewCustomer.bvn_txt.Text = ""
        ViewCustomer.profile_id.Text = "SELECT CUSTOMER"
        ViewCustomer.genderComboBox.Text = "SELECT GENDER"
        ViewCustomer.StatusComboBox.Text = "SELECT STATUS"
        ViewCustomer.CustomerPictureBox.Image = Nothing
    End Sub

    Public Sub LogInClearFunction()
        Admin_Login.email_txt.Text = ""
        ResetPassword.email_txt.Text = ""
        Admin_Login.password_txt.Text = ""

        UserLogin.email_txt.Text = ""
        UserResetPassword.email_txt.Text = ""
        UserLogin.password_txt.Text = ""

    End Sub

    Public Sub DepositClearFunction()
        DepositRecord.transfer_amount.Text = ""
        DepositRecord.transaction_description_txt.Text = ""

        AdminWithdrawlForm.withdrawl_amount.Text = ""
        AdminWithdrawlForm.transaction_description_txt.Text = ""


        UserTransfer.account_id_txt.Text = ""
        UserTransferConfirm.transfer_amount.Text = ""
        UserTransferConfirm.transaction_description_txt.Text = ""

    End Sub

    Public Sub loanClearFunction()
        requestFORloan.loan_amount_txt.Text = ""
        requestFORloan.loan_duration_txt.Text = ""
    End Sub

    Public Function HashPassword(ByVal defaultPassword As String) As String
        Using md5 As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(defaultPassword)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Sub staffRegistration()
        Try
            Dim staff_id = "STAFF" & Now.ToString("yyyyMMddss") & Functions.countId("STAFF")
            Dim passport = Functions.passportSave(ViewAmin.AdminPictureBox)
            Dim defaultPassword = "STAFF "
            Dim hashedPassword As String = Functions.HashPassword(defaultPassword)
            Dim connection = Functions.connection


            connection.Open()
            query = "INSERT INTO `staff_tab`(`staff_id`, `fullname`, `mobile_number`, `email_address`, `gender_id`, `nin`, `role_id`, `status_id`, `passport`, `password`, `created_time`) " &
                    "VALUES (@staff_id, @fullname, @mobile_number, @email_address, @gender_id, @nin, @role_id, @status_id, @passport, @password, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@staff_id", staff_id)
            command.Parameters.AddWithValue("@fullname", ViewAmin.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@mobile_number", ViewAmin.mobile_txt.Text)
            command.Parameters.AddWithValue("@email_address", ViewAmin.email_txt.Text)
            command.Parameters.AddWithValue("@nin", ViewAmin.nin_txt.Text)
            command.Parameters.AddWithValue("@gender_id", ViewAmin.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@role_id", ViewAmin.RoleComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", ViewAmin.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@password", hashedPassword)
            reader = command.ExecuteReader()
            connection.Close()

            MessageBox.Show("SUCCESS! Staff Registration Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Functions.clearFunction()
            Functions.getStaffID()
            Functions.staffRecord()
        Catch ex As Exception
            MessageBox.Show("Staff Registration Failed: " & ex.Message, "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub customerRegistration()
        Try
            Dim result = Functions.getStaffProfile(Admin_Login.login_staff_id)
            Dim staff_fullname = result.item1.ToString()
            Dim staff_id = Admin_Login.login_staff_id

            Dim customer_id = "CUST" & Now.ToString("yyyyMMddss") & Functions.countId("CUST")
            Dim customer_account_id = "0" & Now.ToString("yyyyMMdd") & Functions.countId("0")
            Dim passport = Functions.passportSave(ViewCustomer.CustomerPictureBox)
            Dim defaultPassword = "STAFF "
            Dim hashedPassword As String = Functions.HashPassword(defaultPassword)
            Dim connection = Functions.connection

            connection.Open()
            query = "INSERT INTO `customer_tab`(`customer_id`, `staff_id`, `staff_fullname`, `fullname`, `mobile_number`, `email_address`, `nin`, `bvn`, `gender_id`, `status_id`, `passport`, `password`, `created_time`) VALUES(@customer_id, @staff_id, @staff_fullname, @fullname, @mobile_number, @email_address, @nin, @bvn, @gender_id, @status_id, @passport, @password, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@staff_id", staff_id)
            command.Parameters.AddWithValue("@staff_fullname", staff_fullname)
            command.Parameters.AddWithValue("@fullname", ViewCustomer.fullname_txt.Text.ToUpper())
            command.Parameters.AddWithValue("@mobile_number", ViewCustomer.mobile_txt.Text)
            command.Parameters.AddWithValue("@email_address", ViewCustomer.email_txt.Text)
            command.Parameters.AddWithValue("@nin", ViewCustomer.nin_txt.Text)
            command.Parameters.AddWithValue("@bvn", ViewCustomer.nin_txt.Text)
            command.Parameters.AddWithValue("@gender_id", ViewCustomer.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", ViewCustomer.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@password", hashedPassword)
            reader = command.ExecuteReader
            connection.Close()

            connection.open()
            query = "INSERT INTO `customer_account_tab`(`customer_account_id`, `customer_id`, `account_balance`, `loan_balance`, `status_id`, `created_time`, `updated_time`) " &
                    "VALUES(@customer_account_id, @customer_id, 0.0, 0.0, @status_id, NOW(), NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_account_id", customer_account_id)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@status_id", ViewCustomer.StatusComboBox.SelectedValue)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! Customer Registration Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Functions.clearFunction()
            Functions.getCustomerID()
            Functions.UserRecord()
        Catch ex As Exception
            MessageBox.Show("Customer Registration failed: " & ex.Message, "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub StaffFetching()
        Try
            Dim connection = Functions.connection
            connection.Open()

            query = "SELECT a.*, b.role_name, c.status_name,d.gender_name FROM staff_tab a, setup_role_tab b, setup_status_tab c,gender_tab d WHERE a.status_id=c.status_id AND a.role_id=b.role_id AND a.gender_id=d.gender_id AND staff_id=@staff_id;"

            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", ViewAmin.profile_id.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            Dim arrimage() As Byte

            ViewAmin.fullname_txt.Text = reader("fullname")
            ViewAmin.mobile_txt.Text = reader("mobile_number")
            ViewAmin.email_txt.Text = reader("email_address")
            ViewAmin.nin_txt.Text = reader("nin")
            ViewAmin.genderComboBox.Text = (reader("gender_name"))
            ViewAmin.genderComboBox.SelectedValue = reader("gender_id")
            ViewAmin.RoleComboBox.Text = (reader("role_name"))
            ViewAmin.RoleComboBox.SelectedValue = reader("role_id")
            ViewAmin.StatusComboBox.Text = (reader("status_name"))
            ViewAmin.StatusComboBox.SelectedValue = reader("status_id")
            arrimage = reader("passport")

            Dim mstream = New MemoryStream(arrimage)
            ViewAmin.AdminPictureBox.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub CustomerFetching()
        Try
            Dim connection = Functions.connection
            connection.Open()
            query = "SELECT a.*, b.status_name, c.gender_name FROM customer_tab a, setup_status_tab b, gender_tab c WHERE a.status_id=b.status_id AND a.gender_id=c.gender_id AND customer_id=@customer_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@customer_id", ViewCustomer.profile_id.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            Dim arrimage() As Byte

            ViewCustomer.fullname_txt.Text = reader("fullname")
            ViewCustomer.email_txt.Text = reader("email_address")
            ViewCustomer.mobile_txt.Text = reader("mobile_number")
            ViewCustomer.nin_txt.Text = reader("nin")
            ViewCustomer.bvn_txt.Text = reader("bvn")
            ViewCustomer.genderComboBox.Text = (reader("gender_name"))
            ViewCustomer.genderComboBox.SelectedValue = reader("gender_id")
            ViewCustomer.StatusComboBox.Text = (reader("status_name"))
            ViewCustomer.StatusComboBox.SelectedValue = reader("status_id")
            arrimage = reader("passport")

            Dim mstream = New MemoryStream(arrimage)
            ViewCustomer.CustomerPictureBox.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateStaff()
        Try
            Dim passport = Functions.passportSave(ViewAmin.AdminPictureBox)
            Dim connection = Functions.connection

            connection.open()
            query = "UPDATE staff_tab SET fullname=@fullname, mobile_number=@mobile_number, email_address=@email_address, nin=@nin, gender_id=@gender_id, role_id=@role_id, status_id=@status_id, passport=@passport WHERE staff_id=@staff_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@staff_id", ViewAmin.profile_id.SelectedValue)
            command.Parameters.AddWithValue("@fullname", ViewAmin.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@mobile_number", ViewAmin.mobile_txt.Text)
            command.Parameters.AddWithValue("@email_address", ViewAmin.email_txt.Text)
            command.Parameters.AddWithValue("@nin", ViewAmin.nin_txt.Text)
            command.Parameters.AddWithValue("@gender_id", ViewAmin.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@role_id", ViewAmin.RoleComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", ViewAmin.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@passport", passport)
            reader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("SUCCESS! Staff Updated Successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Functions.getStaffID()

        Catch ex As Exception
            MsgBox("User updated failed: " & ex.ToString)
        End Try
    End Sub

    Public Sub UpdateCustomer()
        Try
            Dim passport = Functions.passportSave(ViewCustomer.CustomerPictureBox)
            Dim connection = Functions.connection

            connection.open()
            query = "UPDATE customer_tab SET fullname=@fullname, gender_id=@gender_id, status_id=@status_id, email_address=@email_address, mobile_number=@mobile_number, nin=@nin, bvn=@bvn, passport=@passport WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", ViewCustomer.profile_id.SelectedValue)
            command.Parameters.AddWithValue("@gender_id", ViewCustomer.genderComboBox.SelectedValue)
            command.Parameters.AddWithValue("@status_id", ViewCustomer.StatusComboBox.SelectedValue)
            command.Parameters.AddWithValue("@fullname", ViewCustomer.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", ViewCustomer.email_txt.Text)
            command.Parameters.AddWithValue("@mobile_number", ViewCustomer.mobile_txt.Text)
            command.Parameters.AddWithValue("@nin", ViewCustomer.nin_txt.Text)
            command.Parameters.AddWithValue("@bvn", ViewCustomer.bvn_txt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! Customer Updated Successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Functions.getCustomerID()
            Functions.UserRecord()
        Catch ex As Exception
            MsgBox("User updated failed: " & ex.ToString)
        End Try
    End Sub

    Public Sub staffRecord()

        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = Functions.connection
            Dim command As New MySqlCommand("SELECT a.staff_id, a.fullname, a.mobile_number, a.email_address, a.nin, a.passport, a.created_time, a.updated_time, a.last_login, b.status_name, c.role_name, d.gender_name FROM staff_tab a, setup_status_tab b, setup_role_tab c, gender_tab d WHERE a.status_id = b.status_id AND a.role_id = c.role_id AND a.gender_id = d.gender_id ; ", connection)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            AdminRecord.staffRecords.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email_address").ToString())
                listItem.SubItems.Add(row("mobile_number").ToString())
                listItem.SubItems.Add(row("nin").ToString())
                listItem.SubItems.Add(row("gender_name").ToString())
                listItem.SubItems.Add(row("role_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("created_time").ToString())
                listItem.SubItems.Add(row("updated_time").ToString())
                listItem.SubItems.Add(row("last_login").ToString())


                AdminRecord.staffRecords.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub UserRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = Functions.connection
            Dim command As New MySqlCommand("SELECT CONCAT(a.staff_id, ' / ', a.staff_fullname) AS registered_by, a.*, b.status_name, FORMAT(c.account_balance, 2) AS formatted_account_balance, FORMAT(c.loan_balance, 2) AS formatted_loan_balance, d.gender_name FROM customer_tab a, setup_status_tab b, customer_account_tab c, gender_tab d WHERE a.status_id=b.status_id AND a.customer_id=c.customer_id AND a.gender_id=d.gender_id;", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            customerRecord.userRecord.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("customer_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("email_address").ToString())
                listItem.SubItems.Add(row("mobile_number").ToString())
                listItem.SubItems.Add(row("formatted_loan_balance").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("registered_by").ToString())
                listItem.SubItems.Add(row("created_time").ToString())
                listItem.SubItems.Add(row("formatted_account_balance").ToString())
                listItem.SubItems.Add(row("last_login").ToString())
                listItem.SubItems.Add(row("updated_time").ToString())
                listItem.SubItems.Add(row("gender_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())

                customerRecord.userRecord.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Function customerLoanSchedule(ByVal customer_id As String, ByVal listview As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = Functions.connection
            Dim command As New MySqlCommand("SELECT a.*, b.month, FORMAT(b.principal, 2) as formatted_principal, FORMAT(b.repayment, 2) as formatted_repayment, FORMAT(b.interest, 2) as formatted_interest, FORMAT(b.monthly_repayment, 2) as formatted_monthly_repayment, b.loan_date FROM loan_tab a, loan_schedule_tab b WHERE a.loan_id=b.loan_id AND a.customer_id=@customer_id;", connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            listview.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("loan_id").ToString())
                listItem.SubItems.Add(row("month").ToString())
                listItem.SubItems.Add(row("formatted_principal").ToString())
                listItem.SubItems.Add(row("formatted_repayment").ToString())
                listItem.SubItems.Add(row("formatted_interest").ToString())
                listItem.SubItems.Add(row("formatted_monthly_repayment").ToString())
                listItem.SubItems.Add(row("loan_date").ToString())
                listItem.SubItems.Add(row("created_time").ToString())

                listview.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview
    End Function

    Function PerformTransaction(ByVal amount_deposit_txt As Double, ByVal transaction_description_txt As String, ByVal customer_id As String)
        Try
            Dim connection = Functions.connection

            Dim customer_transaction_id = "CTRN" & Now.ToString("yyyyMMddss") & Functions.countId("CTRN")

            Dim result = Functions.getCustomerProfile(customer_id)

            Dim balance_before As Double = result.item4.ToString
            Dim balance_after = balance_before + amount_deposit_txt

            connection.open()
            query = "INSERT INTO `customer_transaction_tab`(`customer_transaction_id`, `customer_id`, `transaction_type_id`, `transaction_method_id`, `transaction_amount`, `transaction_description`, `balance_before`, `balance_after`, `status_id`, `created_time`) " &
                        "VALUES (@customer_transaction_id, @customer_id, @transaction_type_id, @transaction_method_id, @transaction_amount, @transaction_description, @balance_before, @balance_after, @status_id, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_transaction_id", customer_transaction_id)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@transaction_type_id", 1)
            command.Parameters.AddWithValue("@transaction_method_id", 2)
            command.Parameters.AddWithValue("@transaction_amount", amount_deposit_txt)
            command.Parameters.AddWithValue("@transaction_description", transaction_description_txt)
            command.Parameters.AddWithValue("@balance_before", balance_before)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            command.Parameters.AddWithValue("@status_id", 4)
            reader = command.ExecuteReader
            connection.close()

            connection.open()
            query = "UPDATE customer_account_tab SET account_balance=@balance_after WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            reader = command.ExecuteReader
            connection.close()
            Functions.allCounts()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Tuple.Create(amount_deposit_txt, transaction_description_txt, customer_id)
    End Function

    Function PerformTransactionWithdrawl(ByVal amount_withdrawl_txt As Double, ByVal transaction_description_txt As String, ByVal customer_id As String)
        Try
            Dim connection = Functions.connection

            Dim customer_transaction_id = "CTRN" & Now.ToString("yyyyMMddss") & Functions.countId("CTRN")

            Dim result = Functions.getCustomerProfile(customer_id)

            Dim balance_before As Double = result.item4.ToString
            Dim balance_after = balance_before - amount_withdrawl_txt

            connection.open()
            query = "INSERT INTO `customer_transaction_tab`(`customer_transaction_id`, `customer_id`, `transaction_type_id`, `transaction_method_id`, `transaction_amount`, `transaction_description`, `balance_before`, `balance_after`, `status_id`, `created_time`) " &
                        "VALUES (@customer_transaction_id, @customer_id, @transaction_type_id, @transaction_method_id, @transaction_amount, @transaction_description, @balance_before, @balance_after, @status_id, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_transaction_id", customer_transaction_id)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@transaction_type_id", 2)
            command.Parameters.AddWithValue("@transaction_method_id", 2)
            command.Parameters.AddWithValue("@transaction_amount", amount_withdrawl_txt)
            command.Parameters.AddWithValue("@transaction_description", transaction_description_txt)
            command.Parameters.AddWithValue("@balance_before", balance_before)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            command.Parameters.AddWithValue("@status_id", 4)
            reader = command.ExecuteReader
            connection.close()

            connection.open()
            query = "UPDATE customer_account_tab SET account_balance=@balance_after WHERE customer_id=@customer_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            command.Parameters.AddWithValue("@balance_after", balance_after)
            reader = command.ExecuteReader
            connection.close()
            Functions.allCounts()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Tuple.Create(amount_withdrawl_txt, transaction_description_txt, customer_id)
    End Function

  Public Function Transaction(ByVal sender_customer_id As String, ByVal receiver_customer_id As String, ByVal transfer_amount As Double, ByVal description As String, ByVal transaction_id As String) As Tuple(Of String, String, Double, String)
        Dim connection As MySqlConnection = Nothing
        Dim transactions As MySqlTransaction = Nothing

        Try
            connection = Functions.connection
            connection.Open()
            transactions = connection.BeginTransaction()

            Dim senderResult = Functions.getCustomerProfile(sender_customer_id)
            Dim sender_balance_before As Double = senderResult.item4
            Dim sender_account_id As String = senderResult.item6
            Dim sender_balance_after = sender_balance_before - transfer_amount

            If sender_balance_before < transfer_amount Then
                MsgBox("Insufficient funds in sender's account.")
                transactions.Rollback()
                connection.Close()
                Return Nothing
            End If

            Dim receiverResult = Functions.getCustomerProfile(receiver_customer_id)
            Dim receiver_balance_before As Double = receiverResult.item4
            Dim receiver_account_id As String = receiverResult.item6
            Dim receiver_balance_after = receiver_balance_before + transfer_amount

            Dim query = "INSERT INTO `customer_transaction_tab`(`customer_transaction_id`, `customer_id`, `customer_account_id`, `transaction_type_id`, `transaction_method_id`, `transaction_amount`, `transaction_description`, `balance_before`, `balance_after`, `status_id`, `created_time`) VALUES (@sender_transaction_id, @sender_customer_id, @customer_account_id, @transaction_type_id, @transaction_method_id, @transaction_amount, @transaction_description , @balance_before, @balance_after, @status_id, NOW())"
            Dim command = New MySqlCommand(query, connection, transactions)
            command.Parameters.AddWithValue("@sender_transaction_id", transaction_id)
            command.Parameters.AddWithValue("@sender_customer_id", sender_customer_id)
            command.Parameters.AddWithValue("@customer_account_id", sender_account_id)
            command.Parameters.AddWithValue("@transaction_type_id", 3)
            command.Parameters.AddWithValue("@transaction_method_id", 1)
            command.Parameters.AddWithValue("@transaction_amount", transfer_amount)
            command.Parameters.AddWithValue("@transaction_description", description)
            command.Parameters.AddWithValue("@balance_before", sender_balance_before)
            command.Parameters.AddWithValue("@balance_after", sender_balance_after)
            command.Parameters.AddWithValue("@status_id", 4)
            command.ExecuteNonQuery()

            query = "UPDATE `customer_account_tab` SET `account_balance` = @balance_after WHERE `customer_id` = @customer_id"
            command = New MySqlCommand(query, connection, transactions)
            command.Parameters.AddWithValue("@balance_after", sender_balance_after)
            command.Parameters.AddWithValue("@customer_id", sender_customer_id)
            command.ExecuteNonQuery()

            query = "INSERT INTO `customer_transaction_tab`(`customer_transaction_id`, `customer_id`, `customer_account_id`, `transaction_type_id`, `transaction_method_id`, `transaction_amount`, `transaction_description`, `balance_before`, `balance_after`, `status_id`, `created_time`) " & _
                    "VALUES (@receiver_transaction_id, @receiver_customer_id, @customer_account_id, @transaction_type_id, @transaction_method_id, @transaction_amount, @transaction_description, @balance_before, @balance_after, @status_id, NOW())"
            command = New MySqlCommand(query, connection, transactions)
            command.Parameters.AddWithValue("@receiver_transaction_id", transaction_id)
            command.Parameters.AddWithValue("@receiver_customer_id", receiver_customer_id)
            command.Parameters.AddWithValue("@customer_account_id", receiver_account_id)
            command.Parameters.AddWithValue("@transaction_type_id", 1)
            command.Parameters.AddWithValue("@transaction_method_id", 1)
            command.Parameters.AddWithValue("@transaction_amount", transfer_amount)
            command.Parameters.AddWithValue("@transaction_description", description)
            command.Parameters.AddWithValue("@balance_before", receiver_balance_before)
            command.Parameters.AddWithValue("@balance_after", receiver_balance_after)
            command.Parameters.AddWithValue("@status_id", 4)
            command.ExecuteNonQuery()

            query = "UPDATE `customer_account_tab` SET `account_balance` = @balance_after WHERE `customer_id` = @customer_id"
            command = New MySqlCommand(query, connection, transactions)
            command.Parameters.AddWithValue("@balance_after", receiver_balance_after)
            command.Parameters.AddWithValue("@customer_id", receiver_customer_id)
            command.ExecuteNonQuery()

            transactions.Commit()
            connection.Close()

            Return Tuple.Create(sender_customer_id, receiver_customer_id, transfer_amount, description)

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MessageBoxIcon.Error)
            If transactions IsNot Nothing Then
                Try
                    transactions.Rollback()
                Catch rollbackEx As Exception
                    MsgBox("Rollback failed: " & rollbackEx.Message, MessageBoxIcon.Error)
                End Try
            End If
            Return Nothing
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function

    Function customerDepositTransaction(ByVal customer_id As String, ByVal listview_form As Object)
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = Functions.connection
            Dim command As New MySqlCommand("SELECT a.customer_transaction_id, a.transaction_description, a.created_time, FORMAT(a.balance_before, 2) AS formatted_balance_before, FORMAT(a.transaction_amount, 2) AS formatted_transaction_amount, FORMAT(a.balance_after, 2) AS formatted_balance_after, b.fullname, b.customer_id, c.transaction_type_name, d.transaction_method_name, e.status_name FROM customer_transaction_tab a, customer_tab b, setup_transaction_type_tab c, setup_transaction_method_tab d, setup_status_tab e WHERE a.customer_id=b.customer_id AND a.transaction_type_id=c.transaction_type_id  AND a.transaction_method_id=d.transaction_method_id  AND a.status_id=e.status_id  AND a.customer_id=@customer_id;", connection)
            command.Parameters.AddWithValue("@customer_id", customer_id)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            listview_form.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("customer_id").ToString())
                listItem.SubItems.Add(row("customer_transaction_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("formatted_balance_before").ToString())
                listItem.SubItems.Add(row("formatted_transaction_amount").ToString())
                listItem.SubItems.Add(row("formatted_balance_after").ToString())
                listItem.SubItems.Add(row("transaction_type_name").ToString())
                listItem.SubItems.Add(row("transaction_method_name").ToString())
                listItem.SubItems.Add(row("transaction_description").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("created_time").ToString())

                listview_form.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return listview_form
    End Function

    Function allCounts()
        Dim connection = Functions.connection
        connection.open()
        query = "SELECT (SELECT COUNT(*) FROM staff_tab) AS total_staff, (SELECT COUNT(*) FROM customer_tab) AS total_customer, (SELECT SUM(loan_balance) FROM customer_account_tab) AS total_loan, (SELECT SUM(account_balance) FROM customer_account_tab) AS total_balance;"
        command = New MySqlCommand(query, connection)
        reader = command.ExecuteReader
        reader.Read()
        Dim total_staff = reader("total_staff")
        Dim total_customer = reader("total_customer")
        Dim total_loan = Convert.ToDouble(reader("total_loan")).ToString("N2")
        Dim total_balance = Convert.ToDouble(reader("total_balance")).ToString("N2")
        Return Tuple.Create(total_staff, total_customer, total_loan, total_balance)
    End Function

    Function system_settings()
        Dim connection = Functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM system_settings_tab", connection)
        reader = command.ExecuteReader
        reader.Read()
        Dim minimum_account_balance = reader("minimum_account_balance")
        Dim maximum_loan_amount = reader("maximum_loan_amount")
        Dim minimum_loan_amount = reader("minimum_loan_amount")
        Dim maximum_duration = reader("maximum_duration")
        Dim loan_rate = reader("loan_rate")
        connection.close()
        Return Tuple.Create(minimum_account_balance, maximum_loan_amount, minimum_loan_amount, maximum_duration, loan_rate)
    End Function

    Function RestrictToCharacters(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(8) AndAlso e.KeyChar <> ChrW(32) Then
            e.Handled = True
            MessageBox.Show("Please enter characters only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return e
    End Function

    Function RestrictToNumeric(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso
        Not Char.IsWhiteSpace(e.KeyChar) AndAlso
        Not Char.IsControl(e.KeyChar) AndAlso
        e.KeyChar <> "+"c AndAlso
        e.KeyChar <> "-"c AndAlso
        e.KeyChar <> "("c AndAlso
        e.KeyChar <> ")"c Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers and valid symbols (+, -", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Public Sub HandleMobileKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            Dim gunaTextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Please enter positive whole numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If gunaTextBox.Text.Length = 0 AndAlso e.KeyChar <> "0"c Then
                e.Handled = True
                MessageBox.Show("Mobile number must start with '0'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If gunaTextBox.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("Mobile number cannot exceed 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("An unexpected error occurred. Please ensure the correct control is being used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Function RestrictToWholenumber(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> ChrW(8) Then
            e.Handled = True
            MessageBox.Show("Please enter positive whole number  only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return e
    End Function

    Public Sub TogglePasswordVisibility(ByVal guna2TextBox As Guna.UI2.WinForms.Guna2TextBox, ByVal guna2Button As Guna.UI2.WinForms.Guna2Button, ByRef isPasswordVisible As Boolean)
        If isPasswordVisible Then
            guna2TextBox.PasswordChar = "*"
            guna2Button.Text = "SHOW"
        Else
            guna2TextBox.PasswordChar = ControlChars.NullChar
            guna2Button.Text = "HIDE"
        End If
        isPasswordVisible = Not isPasswordVisible
    End Sub

    Function AccountID_verify(ByVal customer_id As String, ByVal receiver_customer_id As String, ByVal receiver_fullname As Guna.UI2.WinForms.Guna2HtmlLabel, ByVal receiver_account_number As Guna.UI2.WinForms.Guna2HtmlLabel) As Boolean
        Try
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT a.customer_account_id, b.customer_id, b.fullname FROM customer_account_tab a , customer_tab b WHERE a.customer_id = b.customer_id AND a.customer_account_id = @customer_account_id ", connection)
            command.Parameters.AddWithValue("@customer_account_id", receiver_account_number)
            reader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                receiver_fullname.Text = reader("fullname").ToString()
                receiver_account_number.Text = reader("customer_account_id").ToString()
                receiver_customer_id = reader("customer_id").ToString()
                Return True
            Else
                MsgBox("Account ID verification failed. No matching record found.", MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

End Module