Imports MySql.Data.MySqlClient
Public Class UserTransferConfirm
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public senderCustomerID, receiverCustomerID, receiverAccountID, receiverFullName As String

    Public Sub GetCustomerDetails(ByVal senderID As String, ByVal receiverID As String, ByVal accountID As String, ByVal fullName As String)
        senderCustomerID = senderID
        receiverCustomerID = receiverID
        receiverAccountID = accountID
        receiverFullName = fullName
    End Sub
    Private Sub UserTransferConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        receiver_fullname.Text = receiverFullName
        receiver_account_number.Text = receiverAccountID

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub transferPROCEEDbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transferPROCEEDbtn.Click
        Try
            If String.IsNullOrWhiteSpace(transfer_amount.Text) OrElse Not IsNumeric(transfer_amount.Text) Then
                MessageBox.Show("ERROR! Enter a valid transfer amount.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf String.IsNullOrWhiteSpace(transaction_description_txt.Text) Then
                MessageBox.Show("ERROR! Enter a transaction description.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Convert.ToDouble(transfer_amount.Text) < 10 Then
                MessageBox.Show("Transfer amount must be greater than ₦10.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf senderCustomerID = receiverCustomerID Then
                MessageBox.Show("Sender and receiver IDs cannot be the same.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim senderProfile = Functions.getCustomerProfile(senderCustomerID)
                Dim senderFullName As String = senderProfile.Item2
                Dim transferAmount As Double = Convert.ToDouble(transfer_amount.Text)
                Dim description As String = transaction_description_txt.Text

                Dim transaction_id As String = "CTRN" & Now.ToString("yyyyMMddss") & Functions.countId("CTRN")
                Dim result = Functions.Transaction(senderCustomerID, receiverCustomerID, transferAmount, description, transaction_id)

                If result Is Nothing Then
                    MessageBox.Show("Transaction failed. Please try again.", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim receiptForm As New PaymentReceiptForm With {
                    .Recipient_FullName = receiverFullName,
                    .RecipientAccountNumber = receiverAccountID,
                     .SenderFullName = senderFullName,
                    .TransactionDescription = description,
                    .TransactionReferenceID = transaction_id,
                    .TransactionAmountValue = transferAmount,
                    .TransactionDateTime = DateTime.Now,
                    .TransactionStatusText = "Successful"
                }
                MessageBox.Show("Transfer has been successfully completed!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UserDashboard.UserDashboard()
                receiptForm.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class