
Public Class Form1
    Dim loan_amount, loan_duration, repayment, monthly_repayment, interest_on_loan, total_interest, total_monthly_repayment As Double
    Private errorProvider As New ErrorProvider()

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        If Double.TryParse(loan_amount_txt.Text, loan_amount) AndAlso Double.TryParse(loan_duration_txt.Text, loan_duration) Then
            lstRepaymentDetails.Items.Clear()
            lstRepaymentDetails.Items.Add("Month | Repayment   | Interest       | Monthly Repayment")
            lstRepaymentDetails.Items.Add("__________________________________________________________")

            total_interest = 0
            total_monthly_repayment = 0

            For month As Integer = 1 To loan_duration
                repayment = loan_amount / loan_duration
                interest_on_loan = (1.5 / 100) * (loan_amount - ((month - 1) * repayment))
                monthly_repayment = repayment + interest_on_loan
                total_interest += interest_on_loan
                total_monthly_repayment += monthly_repayment

                lstRepaymentDetails.Items.Add(month.ToString().PadRight(9) & "|" & repayment.ToString("n2").PadRight(15) & "|" & interest_on_loan.ToString("n2").PadRight(15) & "|" & monthly_repayment.ToString("n2").PadRight(12))
            Next
            total_interest_txt.Text = ("#") & total_interest.ToString("n2")
            total_monthly_repayment_txt.Text = ("#") & total_monthly_repayment.ToString("n2")
        Else
            MessageBox.Show("Please enter valid numeric values for loan amount and duration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Clear_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clear_btn.Click
        loan_amount_txt.Clear()
        loan_duration_txt.Clear()
        total_interest_txt.Clear()
        total_monthly_repayment_txt.Clear()
        lstRepaymentDetails.Items.Clear()
        errorProvider.Clear()
    End Sub

    Private Sub loan_amount_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles loan_amount_txt.KeyPress
        ' Allow only digits and control characters (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Disallow entering a decimal point as the first character
        If e.KeyChar = "." AndAlso loan_amount_txt.Text.Length = 0 Then
            e.Handled = True
        End If

        ' Disallow entering more than one decimal point
        If e.KeyChar = "." AndAlso loan_amount_txt.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub loan_duration_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles loan_duration_txt.KeyPress
        ' Allow only digits and control characters (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub loan_amount_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles loan_amount_txt.TextChanged
        ValidateInput(loan_amount_txt)
    End Sub

    Private Sub loan_duration_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles loan_duration_txt.TextChanged
        ValidateInput(loan_duration_txt)
    End Sub

    Private Sub ValidateInput(ByVal textBox As TextBox)
        Dim value As Double
        If Not Double.TryParse(textBox.Text, value) Then
            errorProvider.SetError(textBox, "Invalid input. Please enter a numeric value.")
        Else
            errorProvider.SetError(textBox, "")
        End If
    End Sub
End Class