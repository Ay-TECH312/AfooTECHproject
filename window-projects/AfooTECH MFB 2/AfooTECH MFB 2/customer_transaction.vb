Public Class customer_transaction

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub customer_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = DepositRecord.profile_id.SelectedValue
        Functions.customerDepositTransaction(customer_id, userRecord)
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        DepositRecord.Show()
    End Sub
End Class