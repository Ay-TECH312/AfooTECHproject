Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Admin_Dashboard

    Private Sub Admin_Dashboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AfooTECH_MFB.Show()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
    End Sub

    Private Sub amin_logoutBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amin_logoutBTN.Click
        AdminLogOutCloseBtn()
    End Sub

    Private Sub admin_logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_logout_btn.Click
        AdminLogOutCloseBtn()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_label.Text = TimeOfDay
        date_label.Text = Today.ToString(" dddd, MMMM dd, yyyy")
    End Sub

    Private Sub viewadmin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewadmin_btn.Click
        Overlay.Show()
        ViewAmin.Show()
    End Sub

    Private Sub viewcostomer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_customer_btn.Click
        ViewCustomer.Show()
        Overlay.Show()
    End Sub

    Private Sub viewloan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_loan_btn.Click
        ViewLoan.Show()
        Overlay.Show()
    End Sub

    Private Sub depositBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deposit_btn.Click
        DepositRecord.Show()
        Overlay.Show()
    End Sub

    Private Sub withdrawl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles withdrawl_btn.Click
        AdminWithdrawlForm.Show()
        Overlay.Show()
    End Sub

    Private Sub adminsetting_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings_btn.Click
        systemSettings.Show()
        Overlay.Show()
    End Sub

    Private Sub Admin_Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Admin_Dashboard()
    End Sub

    Public Sub Admin_Dashboard()



        Dim result = Functions.getStaffProfile(Admin_Login.login_staff_id)
        Dim arrimage() As Byte = result.item3
        role_id.Text = result.item4.ToString
        staff_fullname_label.Text = result.item1.ToString
        last_login_label.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        admin_image.Image = Image.FromStream(mstream)

        Dim allCounts = Functions.allCounts()
        total_admin_label.Text = allCounts.item1.ToString
        total_customer_label.Text = allCounts.item2.ToString
        total_loan_label.Text = "NGN" & allCounts.item3.ToString
        total_balance_label.Text = "NGN" & allCounts.item4.ToString

        If Admin_Login.login_role_id >= 2 Then
            viewadmin_btn.Hide()
            view_customer_btn.Location = New Point(5, 243)
            view_loan_btn.Location = New Point(6, 297)
            deposit_btn.Location = New Point(6, 350)
            withdrawl_btn.Location = New Point(6, 404)
            settings_btn.Location = New Point(7, 459)
        End If
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

End Class