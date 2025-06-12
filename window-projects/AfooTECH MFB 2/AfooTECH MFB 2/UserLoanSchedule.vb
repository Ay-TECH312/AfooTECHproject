Public Class UserLoanSchedule
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub UserLoanSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = UserLogin.login_customer_id
        Functions.customerLoanSchedule(customer_id, loanScheduleRecord)
    End Sub
End Class