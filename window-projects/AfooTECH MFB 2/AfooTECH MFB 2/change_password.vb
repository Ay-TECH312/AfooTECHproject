Imports MySql.Data.MySqlClient
Public Class change_password
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub change_password_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_password_btn.Click
        If old_password_txt.Text = "" Or new_password_txt.Text = "" Or confirmed_password_txt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim connection = Functions.connection
            Dim result = Functions.getPassword(UserLogin.login_customer_id)
            Dim old_password = result
            Dim hashedPassword = Functions.HashPassword(old_password_txt.Text.Trim())

            If hashedPassword = old_password Then
                If new_password_txt.Text = confirmed_password_txt.Text Then
                    connection.open()
                    query = "UPDATE customer_tab SET password=@password WHERE customer_id=@customer_id"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@password", Functions.HashPassword(new_password_txt.Text.Trim()))
                    command.Parameters.AddWithValue("@customer_id", UserLogin.login_customer_id)
                    reader = command.ExecuteReader
                    connection.Close()
                    MessageBox.Show("SUCCESS! Password has been updated successfully", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Overlay.Close()
                Else
                    MessageBox.Show("ERROR! New Password don't match with Confirmed Password!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("ERROR! Old Password is Incorrect", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
End Class