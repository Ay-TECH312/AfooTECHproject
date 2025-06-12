Imports MySql.Data.MySqlClient
Public Class UserTransfer
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public sender_customer_id, receiver_customer_id, receiver_account_id, receiver_fullname As String

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub UserTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Functions.getCustomerID()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Functions.DepositClearFunction()
    End Sub

    Private Sub transferVERIFYbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transferVERIFYbtn.Click

        Dim sender_customer_id = UserLogin.login_customer_id
        Dim customer_account_id As String = account_id_txt.Text

        If String.IsNullOrEmpty(account_id_txt.Text) Then
            MessageBox.Show("Please provide an Account ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = Functions.connection
                connection.Open()
                command = New MySqlCommand("SELECT a.customer_account_id, a.customer_id, b.fullname FROM customer_account_tab a , customer_tab b WHERE a.customer_id = b.customer_id AND a.customer_account_id = @customer_account_id ", connection)
                command.Parameters.AddWithValue("@customer_account_id", customer_account_id)
                reader = command.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Dim receiver_fullname As String = reader("fullname").ToString()
                    Dim receiver_account_id As String = reader("customer_account_id").ToString()
                    Dim receiver_customer_id As String = reader("customer_id").ToString()

                    Dim success_transfer_form As New UserTransferConfirm
                    success_transfer_form.GetCustomerDetails(sender_customer_id, receiver_customer_id, receiver_account_id, receiver_fullname)
                    success_transfer_form.Show()
                    Overlay.Show()
                    Overlay.Show()
                    Me.Close()

                Else
                    MsgBox("Account ID verification failed. No matching record found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub account_id_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles account_id_txt.KeyPress
        Functions.RestrictToWholenumber(sender, e)
    End Sub
End Class