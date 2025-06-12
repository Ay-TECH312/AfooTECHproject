Imports MySql.Data.MySqlClient
Public Class systemSettings
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub systemSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim result = Functions.system_settings
        minimum_acc_balance.Text = Convert.ToDouble(result.item1).ToString("N2")
        maximum_loan_amount.Text = Convert.ToDouble(result.item2).ToString("N2")
        minimum_loan_amount.Text = Convert.ToDouble(result.item3).ToString("N2")
        maximum_loan_duration.Text = Convert.ToDouble(result.item4).ToString()
        loan_rate.Text = Convert.ToDouble(result.item5).ToString()
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click

        Dim minBalance, maxLoan, minLoan, maxDuration, rate As Double

        If Not Double.TryParse(minimum_acc_balance.Text, minBalance) OrElse minBalance < 1 Then
            MessageBox.Show("ERROR! Invalid input in Minimum Account Balance. Please enter a valid number greater than 0.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not Double.TryParse(maximum_loan_amount.Text, maxLoan) OrElse maxLoan < 1 Then
            MessageBox.Show("ERROR! Invalid input in Maximum Loan Amount. Please enter a valid number greater than 0.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not Double.TryParse(minimum_loan_amount.Text, minLoan) OrElse minLoan < 1 Then
            MessageBox.Show("ERROR! Invalid input in Minimum Loan Amount. Please enter a valid number greater than 0.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not Double.TryParse(maximum_loan_duration.Text, maxDuration) OrElse maxDuration < 1 Then
            MessageBox.Show("ERROR! Invalid input in Maximum Loan Duration. Please enter a valid number greater than 0.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not Double.TryParse(loan_rate.Text, rate) OrElse rate < 1 Then
            MessageBox.Show("ERROR! Invalid input in Loan Rate. Please enter a valid number greater than 0.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim connection = Functions.connection
            connection.Open()
            command = New MySqlCommand("UPDATE system_settings_tab SET minimum_account_balance=@minimum_account_balance, maximum_loan_amount=@maximum_loan_amount, minimum_loan_amount=@minimum_loan_amount, maximum_duration=@maximum_duration, loan_rate=@loan_rate", connection)
            command.Parameters.AddWithValue("@minimum_account_balance", Convert.ToDouble(minimum_acc_balance.Text).ToString)
            command.Parameters.AddWithValue("@maximum_loan_amount", Convert.ToDouble(maximum_loan_amount.Text).ToString)
            command.Parameters.AddWithValue("@minimum_loan_amount", Convert.ToDouble(minimum_loan_amount.Text).ToString)
            command.Parameters.AddWithValue("@maximum_duration", Convert.ToDouble(maximum_loan_duration.Text).ToString)
            command.Parameters.AddWithValue("@loan_rate", Convert.ToDouble(loan_rate.Text).ToString)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("SUCCESS! Settings Successfully updated", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub minimum_acc_balance_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles minimum_acc_balance.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub maximum_loan_amount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles maximum_loan_amount.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub minimum_loan_amount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles minimum_loan_amount.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub maximum_loan_duration_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles maximum_loan_duration.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub loan_rate_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles loan_rate.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub
End Class