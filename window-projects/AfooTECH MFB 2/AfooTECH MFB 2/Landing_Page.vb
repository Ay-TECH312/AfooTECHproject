Imports MySql.Data.MySqlClient
Public Class AfooTECH_MFB

    Private Sub AfooTECH_MFB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = Functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()

            Panel2.BackColor = Color.FromArgb(220, 255, 255, 255)
            Panel4.BackColor = Color.FromArgb(170, 0, 0, 0)
        End Try
    End Sub

    Private Sub admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_btn.Click
        Admin_Login.Show()
        Panel2.Hide()
        Panel4.Hide()
    End Sub

    Private Sub user_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btn.Click
        UserLogin.Show()
        Panel2.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

  
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class