Public Class User_transaction

    Private Sub User_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = UserLogin.login_customer_id
        Functions.customerDepositTransaction(customer_id, userRecord)
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub
End Class