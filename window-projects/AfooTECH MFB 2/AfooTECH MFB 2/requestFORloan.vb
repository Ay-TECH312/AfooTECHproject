Imports MySql.Data.MySqlClient
Public Class requestFORloan
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Dim connection = Functions.connection
        If loan_amount_txt.Text = "" Or loan_duration_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result = Functions.system_settings
            Dim minimum_account_balance = Double.Parse(result.item1)
            Dim maximum_loan_amount = Double.Parse(result.item2)
            Dim minimum_loan_amount = Double.Parse(result.item3)
            Dim maximum_duration = Int32.Parse(result.item4)
            Dim loan_rate = Double.Parse(result.item5)

            result = Functions.getCustomerProfile(UserLogin.login_customer_id)
            Dim account_balance = Double.Parse(result.item4)
            Dim loan_balance = Double.Parse(result.item5)

            Dim loan_amount = Decimal.Parse(loan_amount_txt.Text)
            Dim loan_duration = Int32.Parse(loan_duration_txt.Text)

            If loan_balance > 1 Then
                MessageBox.Show("ERROR! You're not eligible to request for this loan this time, you have " & loan_balance.ToString("N2") & " " & "loan_balance left, " & "Kindly pay to request for another!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf account_balance < minimum_account_balance Then
                MessageBox.Show("ERROR! You're not eligible to request for this loan due to low balance. " & "Minimum of " & minimum_account_balance.ToString("N2") & " " & "required to get this loan!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf loan_amount > maximum_loan_amount Then
                MessageBox.Show("ERROR! Maximum of " & maximum_loan_amount.ToString("N2") & " " & "is required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf loan_amount < minimum_loan_amount Then
                MessageBox.Show("ERROR! Minmum of " & minimum_loan_amount.ToString("N2") & " " & "is required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf loan_duration > maximum_duration Then
                MessageBox.Show("ERROR! Maximum of " & maximum_duration & " " & "months " & "is required", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else


                Dim loan_id = "LN" & Now.ToString("yyyyMMddss") & Functions.countId("LN")

                connection.open()
                query = "INSERT INTO `loan_tab`(`customer_id`, `loan_id`, `loan_amount`, `loan_duration`, `loan_rate`, `created_time`) VALUES(@customer_id, @loan_id, @loan_amount, @loan_duration, @loan_rate, NOW())"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@customer_id", UserLogin.login_customer_id)
                command.Parameters.AddWithValue("@loan_id", loan_id)
                command.Parameters.AddWithValue("@loan_amount", loan_amount)
                command.Parameters.AddWithValue("@loan_duration", loan_duration)
                command.Parameters.AddWithValue("@loan_rate", loan_rate)
                reader = command.ExecuteReader
                connection.Close()

                connection.open()
                query = "UPDATE customer_account_tab SET loan_balance=@loan_balance WHERE customer_id=@customer_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@loan_balance", loan_amount)
                command.Parameters.AddWithValue("@customer_id", UserLogin.login_customer_id)
                reader = command.ExecuteReader
                connection.Close()

                Dim amount_borrowed As Decimal = Convert.ToDecimal(loan_amount_txt.Text)
                Dim repay_month As Integer = Convert.ToInt32(loan_duration_txt.Text)
                Dim amount_return_monthly As Decimal = amount_borrowed / repay_month
                Dim remaining_balance As Decimal = amount_borrowed
                Dim total_monthly_return As Decimal
                Dim interest As Decimal
                Dim initial_loan_date As Date = Date.Now

                For month As Integer = 1 To repay_month
                    interest = (loan_rate / 100) * remaining_balance
                    total_monthly_return = amount_return_monthly + interest

                    Dim loan_date As Date = DateAdd(DateInterval.Month, month - 1, initial_loan_date)

                    connection.open()
                    query = "INSERT INTO loan_schedule_tab (month, principal, repayment, interest, monthly_repayment, loan_date, loan_id) VALUES (@month, @principal, @repayment, @interest, @monthly_repayment, @loan_date, @loan_id)"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@month", month)
                    command.Parameters.AddWithValue("@principal", remaining_balance)
                    command.Parameters.AddWithValue("@repayment", amount_return_monthly)
                    command.Parameters.AddWithValue("@interest", interest)
                    command.Parameters.AddWithValue("@monthly_repayment", total_monthly_return)
                    command.Parameters.AddWithValue("@loan_date", loan_date.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@loan_id", loan_id)
                    reader = command.ExecuteReader
                    connection.Close()
                    remaining_balance -= amount_return_monthly
                Next
                MessageBox.Show("SUCCESS! Loan Application Successfully Saved", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Functions.loanClearFunction()
                UserDashboard.UserDashboard()
            End If
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Functions.loanClearFunction()
    End Sub

    Private Sub loan_amount_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles loan_amount_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub loan_duration_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles loan_duration_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub loan_amount_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_amount_txt.TextChanged

    End Sub

  
End Class