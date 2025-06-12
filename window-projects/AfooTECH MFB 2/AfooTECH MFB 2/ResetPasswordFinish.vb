Imports MySql.Data.MySqlClient
Public Class ResetPasswordFinish
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Private isPasswordVisible As Boolean = False


    Private Sub ResetPasswordFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        psswordOTPlabel.Text = "Dear" & " " & ResetPassword.fullname & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & ResetPassword.email_address & ")"

        createnewpass_txt.PasswordChar = "*"
        confirmpass_txt.PasswordChar = "*"
        passwordHashCode_btn.Text = "SHOW"
        passHashCode_btn.Text = "SHOW"
    End Sub

    Private Sub admin_login_closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_closeBTN.Click
        Me.Close()
        ResetPassword.Close()
        Admin_Login.Close()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetpasssubmit_btn.Click

        If otp_txt.Text = "" Or createnewpass_txt.Text = "" Or confirmpass_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(otp_txt.Text) OrElse otp_txt.Text.Length <> 6 Then
            MessageBox.Show("ERROR! OTP must be a valid 6-digit number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If createnewpass_txt.Text = confirmpass_txt.Text Then
                Try
                    Dim connection = Functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM staff_tab WHERE otp=@otp AND staff_id=@staff_id", connection)
                    command.Parameters.AddWithValue("@staff_id", ResetPassword.staff_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.Close()

                        connection.Open()
                        command = New MySqlCommand("UPDATE staff_tab SET password=@password WHERE staff_id=@staff_id", connection)

                        Dim hashedPassword As String = Functions.HashPassword(createnewpass_txt.Text)
                        command.Parameters.AddWithValue("@password", hashedPassword)
                        command.Parameters.AddWithValue("@staff_id", ResetPassword.staff_id)
                        reader = command.ExecuteReader
                        connection.Close()

                        MessageBox.Show("SUCCESS! Password has been successfully updated", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        directToAdminLogin()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New password and confirm password don't match", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub passwordHashCode_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordHashCode_btn.Click
        TogglePasswordVisibility(createnewpass_txt, passwordHashCode_btn, isPasswordVisible)
    End Sub

    Private Sub passHashCode_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passHashCode_btn.Click
        TogglePasswordVisibility(confirmpass_txt, passwordHashCode_btn, isPasswordVisible)
    End Sub
End Class