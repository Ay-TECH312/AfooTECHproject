Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ViewLoan
    Dim reader As MySqlDataReader
    Dim query As String

    Private Sub ViewLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getCustomerLoanID()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub customer_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customer_clear_btn.Click
        Me.Close()
        Overlay.Close()
    End Sub

    Private Sub loan_schedule_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_schedule_btn.Click
        CustomerLoanSchedule.Show()
        Me.Hide()
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If profile_id.Text = "SELECT CUSTOMER" Then
            MessageBox.Show("SELECT CUSTOMER TO CONTINUE!", "Bank Application Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = Functions.connection
                connection.Open()
                query = "SELECT a.*, b.* FROM customer_tab a, loan_tab b WHERE a.customer_id=b.customer_id AND a.customer_id=@customer_id;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@customer_id", profile_id.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullname_txt.Text = reader("fullname")
                email_txt.Text = reader("email_address")
                mobile_txt.Text = reader("mobile_number")
                loan_id_txt.Text = reader("loan_id")
                loan_amount_txt.Text = Double.Parse(reader("loan_amount")).ToString("N2")
                loan_duration_txt.Text = reader("loan_duration")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                PictureBox.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class