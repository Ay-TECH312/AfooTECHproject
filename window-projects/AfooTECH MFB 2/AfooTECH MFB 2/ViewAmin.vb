Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ViewAmin
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub ViewAmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.getRole()
        Functions.getStatus(StatusComboBox)
        Functions.getGender(genderComboBox)
        Functions.getStaffID()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub viewadminRecordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewadminRecordBtn.Click
        AdminRecord.Show()
        Me.Hide()
    End Sub

    Private Sub admin_select_image_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_select_image_btn.Click
        Functions.selectPassport(AdminPictureBox)
    End Sub

    Private Sub admin_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_clear_btn.Click
        clearFunction()
        profile_id.SelectedIndex = -1
    End Sub

    Private Sub admin_submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_submit_btn.Click
        Dim answer As DialogResult
        If fullname_txt.Text = "" Or email_txt.Text = "" Or mobile_txt.Text = "" Or nin_txt.Text = "" Or genderComboBox.Text = "SELECT GENDER" Or RoleComboBox.Text = "SELECT ROLE" Or StatusComboBox.Text = "SELECT STATUS" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AdminPictureBox.Image Is Nothing Then
            MessageBox.Show("Please upload a passport photo.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If profile_id.Text = "SELECT STAFF" Or profile_id.Text = "" Then

                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    reader = Functions.StaffemailCheck(email_txt.Text)
                    If reader.HasRows Then
                        MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        Functions.staffRegistration()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    reader = Functions.StaffupdateEmailCheck(email_txt.Text)
                    If reader.HasRows Then
                        MessageBox.Show("ERROR! Emaill Address is already Exist, Kindly Enter a new Email Address to Continue!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Functions.UpdateStaff()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub fetch_staff_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_staff_btn.Click
        If profile_id.Text = "SELECT STAFF" Then
            MessageBox.Show("SELECT STAFF TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Functions.StaffFetching()
        End If
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles fullname_txt.KeyPress
        Functions.RestrictToCharacters(sender, e)
    End Sub

    Private Sub mobile_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles mobile_txt.KeyPress
        Functions.RestrictToNumeric(sender, e)
    End Sub

    Private Sub nin_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles nin_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub

End Class