Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Admin_Login
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_staff_id, login_role_id, login_status_id As String
    Private isPasswordVisible As Boolean = False

    Private Sub admin_login_closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_closeBTN.Click
        Me.Close()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub admin_login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_btn.Click
        If (email_txt.Text = "") Or (password_txt.Text = "") Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = Functions.connection
            Dim hashedPassword As String = HashPassword(password_txt.Text.Trim())

            Try

                connection.Open()

                command = New MySqlCommand("SELECT * FROM staff_tab WHERE email_address=@email_address AND password=@password", connection)
                command.Parameters.AddWithValue("@email_address", email_txt.Text.Trim())
                command.Parameters.AddWithValue("@password", hashedPassword)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then

                    login_staff_id = reader("staff_id")
                    login_status_id = reader("status_id")
                    login_role_id = reader("role_id")

                    connection.Close()

                    If login_status_id = 1 Then
                        connection.Open()
                        command = New MySqlCommand("UPDATE staff_tab SET last_login=NOW() WHERE staff_id=@StaffID", connection)
                        command.Parameters.AddWithValue("@StaffID", login_staff_id)
                        command.ExecuteNonQuery()
                        connection.Close()

                        Functions.directToDashboard()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show("Invalid email address or password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub


    Private Sub ForgetPassword_linklabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgetPassword_linklabel.LinkClicked
        ResetPassword.Show()
        Functions.LogInClearFunction()
        Me.Hide()
    End Sub

    Private Sub Admin_Login_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password_txt.PasswordChar = "*"
        passwordHashCode_btn.Text = "SHOW"
    End Sub

    Private Sub passwordHashCode_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordHashCode_btn.Click
        TogglePasswordVisibility(password_txt, passwordHashCode_btn, isPasswordVisible)
    End Sub

    Private Sub email_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_txt.TextChanged

    End Sub
End Class