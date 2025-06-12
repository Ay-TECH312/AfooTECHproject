Public Class PaymentReceiptForm
    Public Property Recipient_FullName As String
    Public Property RecipientAccountNumber As String
    Public Property SenderFullName As String
    Public Property TransactionDescription As String
    Public Property TransactionReferenceID As String
    Public Property TransactionAmountValue As Double
    Public Property TransactionDateTime As DateTime
    Public Property TransactionStatusText As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub PaymentReceiptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            receiver_fullname.Text = Recipient_FullName
            receiver_account_number.Text = RecipientAccountNumber
            Sender_fullname.Text = SenderFullName
            transaction_description_txt.Text = TransactionDescription
            TransactionI_ID.Text = TransactionReferenceID
            transfer_amount.Text = TransactionAmountValue.ToString("N2")
            TransactionDate.Text = TransactionDateTime.ToString("MMM dd, yyyy HH:mm:ss")
            TransactionStatus.Text = TransactionStatusText
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading payment receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class