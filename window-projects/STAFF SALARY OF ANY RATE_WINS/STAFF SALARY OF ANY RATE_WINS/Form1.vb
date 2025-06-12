
Public Class Form1

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        If salary_txt.Text = "" Then
            MessageBox.Show("Kindly Enter your Salary")
        Else
            Dim salary As Double
            Dim percentage As Double
            Dim taxDeduction As Double
            Dim totalBalance As Double

            If Double.TryParse(salary_txt.Text, salary) AndAlso Double.TryParse(percentage_txt.Text, percentage) Then
                taxDeduction = (percentage / 100) * salary
                taxdeduction_txt.Text = "#" & taxDeduction.ToString("F2") ' Format to 2 decimal places with $

                totalBalance = salary - taxDeduction
                total_balance_txt.Text = "#" & totalBalance.ToString("F2") ' Format to 2 decimal places with $
            Else
                MessageBox.Show("Please enter valid numbers for Salary and Percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        salary_txt.Text = ""
        percentage_txt.Text = ""
        taxdeduction_txt.Text = ""
        total_balance_txt.Text = ""
    End Sub

    Private Sub salary_txt_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles salary_txt.KeyPress, percentage_txt.KeyPress
        ' Accept Control Keys, Digit, and dot
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("This field can accept only numbers and a decimal point", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Only allow one decimal point
        If e.KeyChar = "." AndAlso (CType(sender, TextBox)).Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

        ' Do not allow the input to start with a decimal point
        If e.KeyChar = "." AndAlso (CType(sender, TextBox)).SelectionStart = 0 Then
            e.Handled = True
            MessageBox.Show("Input must start with a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class