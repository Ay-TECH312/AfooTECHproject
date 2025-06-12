Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class ResetPassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public staff_id, fullname, email_address, status_id As String
    Private Sub admin_login_closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_closeBTN.Click
        Me.Close()
        Admin_Login.Hide()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub nextPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextPassword_btn.Click
        If email_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try

                reader = Functions.StaffemailCheck(email_txt.Text)
                If reader.HasRows Then
                    staff_id = reader("staff_id")
                    Dim status_id = reader("status_id")
                    fullname = reader("fullname")
                    email_address = reader("email_address")

                    If status_id = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = Functions.connection

                        connection.Open()
                        command = New MySqlCommand("UPDATE staff_tab SET otp=@otp WHERE staff_id=@staff_id", connection)
                        command.Parameters.AddWithValue("@staff_id", staff_id)
                        command.Parameters.AddWithValue("@otp", otp)
                        reader = command.ExecuteReader
                        connection.Close()

                        ResetPasswordFinish.Show()
                        Functions.LogInClearFunction()
                        Me.Hide()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email Address not Found!", "Bank System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Admin_back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Admin_back_btn.Click
        Me.Hide()
        Admin_Login.Show()
    End Sub
End Class