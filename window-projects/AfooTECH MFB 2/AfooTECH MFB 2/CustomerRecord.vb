Public Class customerRecord

    Private Sub customerRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.UserRecord()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
        Admin_Dashboard.Show()
    End Sub

    Private Sub customerBackBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerBackBTN.Click
        Me.Close()
        ViewCustomer.Show()
    End Sub
End Class