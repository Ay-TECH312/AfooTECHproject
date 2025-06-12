Public Class Form1
    Dim first_nunber, second_number, result As Double
    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Convert the input numbers to Double
        If Not Double.TryParse(first_num_txt.Text, first_nunber) Then
            MessageBox.Show("Please enter a valid number for the first number.")
            Exit Sub
        End If
        If Not Double.TryParse(second_num_txt.Text, second_number) Then
            MessageBox.Show("Please enter a valid number for the second number.")
            Exit Sub
        End If

        first_nunber = first_num_txt.Text
        second_number = second_num_txt.Text
        result = first_nunber / second_number
        If second_number <> 0 Then
            result = first_nunber / second_number
        Else
            MessageBox.Show("Division by zero is not allowed.")
            Exit Sub
        End If
        Result_txt.Text = result

    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        first_num_txt.Text = ""
        second_num_txt.Text = ""
        Result_txt.Text = ""

    End Sub
    ' Prevent non-numeric input and show error message
    Private Sub first_num_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles first_num_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If

        ' Do not allow the input to start with a decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            MessageBox.Show("Input cannot start with a decimal point.")
        End If

        ' Only allow one decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.")
        End If
    End Sub

    Private Sub second_num_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles second_num_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If

        ' Do not allow the input to start with a decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            MessageBox.Show("Input cannot start with a decimal point.")
        End If

        ' Only allow one decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.")
        End If
    End Sub
End Class
