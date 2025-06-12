Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ViewCustomer
    Dim reader As MySqlDataReader
    Dim query As String

    Private Sub ViewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.getGender(genderComboBox)
        Functions.getStatus(StatusComboBox)
        Functions.getCustomerID()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
        Admin_Dashboard.Show()
    End Sub
    Private Sub select_customer_image_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_customer_image.Click
        Functions.selectPassport(CustomerPictureBox)
    End Sub

    Private Sub viewadminRecordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewcustomerRecordBtn.Click
        customerRecord.Show()
        Me.Hide()
    End Sub

    Private Sub customer_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customer_clear_btn.Click
        Functions.clearFunction()
        profile_id.SelectedIndex = -1
    End Sub

    Private Sub customer_submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customer_submit_btn.Click
        Dim answer As DialogResult
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Or nin_txt.Text = "" Or bvn_txt.Text = "" Or genderComboBox.Text = "SELECT GENDER" Or StatusComboBox.Text = "SELECT STATUS" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf mobile_txt.Text.Length <> 11 Then
            MessageBox.Show("Mobile number must be exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mobile_txt.Focus() ' Set focus back to the text box
            Return
        ElseIf CustomerPictureBox.Image Is Nothing Then
            MessageBox.Show("Please upload a passport photo.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If profile_id.Text = "SELECT CUSTOMER" Or profile_id.Text = "" Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    reader = Functions.customerEmailCheck(email_txt.Text)
                    If reader.HasRows Then
                        MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        Functions.customerRegistration()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    reader = Functions.CustomerupdateEmailCheck(email_txt.Text)
                    If reader.HasRows Then
                        MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Functions.UpdateCustomer()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub fetch_customer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_customer_btn.Click
        If profile_id.Text = "SELECT CUSTOMER" Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Functions.CustomerFetching()
        End If
    End Sub

   Private Sub fullname_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles fullname_txt.KeyPress
        Functions.RestrictToCharacters(sender, e)
    End Sub

    Private Sub nin_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nin_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub bvn_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles bvn_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

    Private Sub mobile_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles mobile_txt.KeyPress
        Functions.HandleMobileKeyPress(sender, e)
    End Sub

End Class