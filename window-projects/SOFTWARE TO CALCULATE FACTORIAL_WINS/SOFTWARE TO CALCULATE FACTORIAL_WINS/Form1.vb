Public Class Form1
    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        Dim number As Integer
        Dim factorial As Long = 1

        If number_txt.Text = "" Then
            MessageBox.Show("Kindly fill the space", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Integer.TryParse(number_txt.Text, number) AndAlso number >= 0 Then
                For i As Integer = 1 To number
                    factorial *= i
                    factorial_txt.Text = factorial.ToString
                Next
            Else
                MessageBox.Show("Please enter a valid positive integer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub number_txt_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles number_txt.KeyPress
        ' Accept only control keys and digits
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field can accept only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        number_txt.Clear()
        factorial_txt.Clear()
    End Sub
End Class