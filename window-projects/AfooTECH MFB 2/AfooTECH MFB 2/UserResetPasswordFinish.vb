Imports MySql.Data.MySqlClient
Public Class UserResetPasswordFinish
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Private isPasswordVisible As Boolean = False

    Private Sub UserResetPasswordFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        psswordOTPlabel.Text = "Dear" & " " & UserResetPassword.fullname & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & UserResetPassword.email_address & ")"

        createnewpass_txt.PasswordChar = "*"
        confirmpass_txt.PasswordChar = "*"
        passwordHashCode_btn.Text = "SHOW"
        passHashCode_btn.Text = "SHOW"
    End Sub

    Private Sub user_closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_closeBTN.Click
        Me.Close()
        UserResetPassword.Close()
        UserLogin.Close()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub Usersubmit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usersubmit_btn.Click

        If otp_txt.Text = "" Or createnewpass_txt.Text = "" Or confirmpass_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(otp_txt.Text) OrElse otp_txt.Text.Length <> 6 Then
            MessageBox.Show("ERROR! OTP must be a valid 6-digit number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If createnewpass_txt.Text = confirmpass_txt.Text Then
                Try
                    Dim connection = Functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM customer_tab WHERE otp=@otp AND customer_id=@customer_id", connection)
                    command.Parameters.AddWithValue("@customer_id", UserResetPassword.customer_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.close()
                        connection.open()
                        command = New MySqlCommand("UPDATE customer_tab SET password=@password WHERE customer_id=@customer_id", connection)

                        Dim hashedPassword As String = Functions.HashPassword(createnewpass_txt.Text)
                        command.Parameters.AddWithValue("@password", hashedPassword)
                        command.Parameters.AddWithValue("@customer_id", UserResetPassword.customer_id)
                        reader = command.ExecuteReader
                        connection.Close()
                        MessageBox.Show("SUCCESS! Password has been successfully updated", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        UserResetPassword.Close()
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