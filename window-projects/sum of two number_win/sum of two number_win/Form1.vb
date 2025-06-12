Public Class form1

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        Dim first_no, second_no, result As Double

        first_no = first_no_txt.Text
        second_no = second_no_txt.Text

        result = first_no + second_no
        result_txt.Text = result
    End Sub

End Class
