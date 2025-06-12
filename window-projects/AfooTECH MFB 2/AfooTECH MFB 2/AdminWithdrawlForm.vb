Imports MySql.Data.MySqlClient
Public Class AdminWithdrawlForm
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub AdminWithdrawlForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.getCustomerID()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Functions.DepositClearFunction()
    End Sub

    Private Sub transBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transBtn.Click
        Me.Hide()
        customer_transaction.Show()
    End Sub

    Private Sub withdrawlSUBMITbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdrawlSUBMITbtn.Click
        Try
            If profile_id.Text = "SELECT CUSTOMER" Then
                MessageBox.Show("ERROR! Select a customer to continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf String.IsNullOrWhiteSpace(withdrawl_amount.Text) OrElse Not IsNumeric(withdrawl_amount.Text) Then
                MessageBox.Show("ERROR! Enter a valid deposit amount.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf String.IsNullOrWhiteSpace(transaction_description_txt.Text) Then
                MessageBox.Show("ERROR! Enter a transaction description.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            Else
                Dim withdrawl As Double = Convert.ToDouble(withdrawl_amount.Text)
                Dim description As String = transaction_description_txt.Text
                Dim customer_id As String = profile_id.SelectedValue.ToString()

                Functions.PerformTransactionWithdrawl(withdrawl, description, customer_id)
            End If

            MessageBox.Show("Withdrawl has been successfully submitted!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DepositClearFunction()
            Me.Close()
            Overlay.Close()
            Admin_Dashboard.Admin_Dashboard()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub withdrawl_amount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles withdrawl_amount.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub
    
End Class