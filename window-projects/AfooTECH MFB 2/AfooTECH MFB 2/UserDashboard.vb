Imports MySql.Data.MySqlClient
Imports System.IO

Public Class UserDashboard
    Private Sub UserDashboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AfooTECH_MFB.Show()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
    End Sub

    Private Sub UserDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserDashboard()

    End Sub

    Public Sub UserDashboard()
        Guna2Panel2.BackColor = Color.FromArgb(180, 255, 255, 255)

        Dim result = Functions.getCustomerProfile(UserLogin.login_customer_id)
        Dim arrimage() As Byte = result.item7
        user_mobile_label.Text = result.item1.ToString
        user_fullname_label.Text = result.item2.ToString
        last_login_label.Text = "Last Login Date:" & " " & result.item3.ToString
        acct_bal_txt.Text = "NGN" & " " & result.item4.ToString
        loan_bal_txt.Text = "NGN" & " " & result.item5.ToString
        Dim mstream = New MemoryStream(arrimage)
        passport.Image = Image.FromStream(mstream)
    End Sub

    Private Sub user_logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_logout_btn.Click
        Functions.UserLogOutCloseBtn()
    End Sub

    Private Sub viewadmin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewadmin_btn.Click
        requestFORloan.Show()
        Overlay.Show()
    End Sub

    Private Sub viewcostomer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewcostomer_btn.Click
        UserLoanSchedule.Show()
        Overlay.Show()
    End Sub

    Private Sub deposit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        UserTransfer.Show()
        Overlay.Show()
    End Sub

    Private Sub adminsetting_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminsetting_btn.Click
        change_password.Show()
        Overlay.Show()
    End Sub

    Private Sub depositBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles depositBtn.Click
        User_transaction.Show()
        Overlay.Show()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class