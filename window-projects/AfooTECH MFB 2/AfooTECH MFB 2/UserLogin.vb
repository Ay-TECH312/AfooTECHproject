Imports MySql.Data.MySqlClient
Imports System.IO
Public Class UserLogin
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_customer_id, login_status_id As String
    Private isPasswordVisible As Boolean = False

    Private Sub User_login_closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_login_closeBTN.Click
        Me.Close()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub user_login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_login_btn.Click
        If email_txt.Text = "" Or password_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = Functions.connection
            Dim hashedPassword As String = HashPassword(password_txt.Text.Trim())

            Try
                connection.Open()
                command = New MySqlCommand("SELECT * FROM customer_tab WHERE email_address=@email_address AND password=@password", connection)
                command.Parameters.AddWithValue("@email_address", email_txt.Text.Trim())
                command.Parameters.AddWithValue("@password", hashedPassword)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    login_customer_id = reader("customer_id")
                    login_status_id = reader("status_id")
                    connection.close()

                    If login_status_id = 1 Then
                        connection.open()
                        command = New MySqlCommand("UPDATE customer_tab SET last_login=NOW() WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", login_customer_id)
                        reader = command.ExecuteReader
                        connection.close()
                        Functions.directToUserDashboard()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("invalid email address or password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ForgetPassword_linklabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgetPassword_linklabel.LinkClicked
        UserResetPassword.Show()
        Me.Hide()
        Functions.LogInClearFunction()
    End Sub

    Private Sub UserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password_txt.PasswordChar = "*"
        passwordHashCode_btn.Text = "SHOW"
       
    End Sub

    Private Sub passwordHashCode_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordHashCode_btn.Click
     TogglePasswordVisibility(password_txt, passwordHashCode_btn, isPasswordVisible)
    End Sub
End Class