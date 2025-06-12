Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class UserResetPassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public customer_id, fullname, email_address As String
    Private Sub closeBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBTN.Click
        Me.Close()
        UserLogin.Hide()
        AfooTECH_MFB.Panel2.Show()
        AfooTECH_MFB.Panel4.Show()
        Overlay.Close()
    End Sub

    Private Sub user_back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_back_btn.Click
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub user_next_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_next_btn.Click
        If email_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try

                reader = Functions.customerEmailCheck(email_txt.Text)
                If reader.HasRows Then
                    customer_id = reader("customer_id")
                    Dim status_id = reader("status_id")
                    fullname = reader("fullname")
                    email_address = reader("email_address")

                    If status_id = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = Functions.connection

                        connection.Open()
                        command = New MySqlCommand("UPDATE customer_tab SET otp=@otp WHERE customer_id=@customer_id", connection)
                        command.Parameters.AddWithValue("@customer_id", customer_id)
                        command.Parameters.AddWithValue("@otp", otp)
                        reader = command.ExecuteReader
                        connection.Close()

                        UserResetPasswordFinish.Show()
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
End Class