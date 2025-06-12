
Public Class Form1
    Dim first_number, second_number, result As Double
    Dim operators As String

    Private Sub calc_btn_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn_txt.Click
        ' Convert the input numbers to Double
        If Not Double.TryParse(first_no_txt.Text, first_number) Then
            MessageBox.Show("Please enter a valid number for the first number.")
            Exit Sub
        End If

        If Not Double.TryParse(second_no_txt.Text, second_number) Then
            MessageBox.Show("Please enter a valid number for the second number.")
            Exit Sub
        End If

        Select Case operators
            Case "+"
                result = first_number + second_number
            Case "-"
                result = first_number - second_number
            Case "x"
                result = first_number * second_number
            Case "/"
                If second_number <> 0 Then
                    result = first_number / second_number
                Else
                    MessageBox.Show("Division by zero is not allowed.")
                    Exit Sub
                End If
            Case Else
                MessageBox.Show("Invalid operator.")
                Exit Sub
        End Select

        ' Display the result
        result_txt.Text = result.ToString()
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        first_no_txt.Text = ""
        second_no_txt.Text = ""
        result_txt.Text = ""
        operator_txt.Text = ""

    End Sub

    Private Sub sum_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum_btn.Click
        operators = "+"
        operator_txt.Text = "+"
        operator_txt.Visible = True

    End Sub

    Private Sub product_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles product_btn.Click
        operators = "x"
        operator_txt.Text = "x"
        operator_txt.Visible = True

    End Sub

    Private Sub minus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus_btn.Click
        operators = "-"
        operator_txt.Text = "-"
        operator_txt.Visible = True

    End Sub

    Private Sub division_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles division_btn.Click
        operators = "/"
        operator_txt.Text = "/"
        operator_txt.Visible = True

    End Sub

    ' Prevent non-numeric input and show error message
    Private Sub first_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles first_no_txt.KeyPress
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

    Private Sub second_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles second_no_txt.KeyPress
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