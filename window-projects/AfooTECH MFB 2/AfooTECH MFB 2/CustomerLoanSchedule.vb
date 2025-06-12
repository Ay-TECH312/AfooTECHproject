Public Class CustomerLoanSchedule

    Private Sub CustomerLoanSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customer_id = ViewLoan.profile_id.SelectedValue
        Functions.customerLoanSchedule(customer_id, loanScheduleRecord)
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub BackBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBTN.Click
        Me.Close()
        ViewLoan.Show()
    End Sub

End Class