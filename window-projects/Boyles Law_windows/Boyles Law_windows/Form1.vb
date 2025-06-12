
Public Class Form1
    Dim v1, v2, p1, p2, result As Double
    Dim calculationType As String

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub v1_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles v1_btn.Click
        calculationType = "v1"
        SetFormState(False, True, True, True)
        ClearInputFields()
        v1_txt.Text = "?"
    End Sub

    Private Sub v2_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles v2_btn.Click
        calculationType = "v2"
        SetFormState(True, False, True, True)
        ClearInputFields()
        v2_txt.Text = "?"
    End Sub

    Private Sub p1_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p1_btn.Click
        calculationType = "p1"
        SetFormState(True, True, False, True)
        ClearInputFields()
        p1_txt.Text = "?"
    End Sub

    Private Sub p2_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles p2_btn.Click
        calculationType = "p2"
        SetFormState(True, True, True, False)
        ClearInputFields()
        p2_txt.Text = "?"
    End Sub

    Private Sub calculate_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calculate_btn.Click
        If Not ValidateInputFields() Then
            MessageBox.Show("Kindly fill all the input fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        v1 = If(Double.TryParse(v1_txt.Text, v1), v1, 0)
        v2 = If(Double.TryParse(v2_txt.Text, v2), v2, 0)
        p1 = If(Double.TryParse(p1_txt.Text, p1), p1, 0)
        p2 = If(Double.TryParse(p2_txt.Text, p2), p2, 0)

        Select Case calculationType
            Case "v1"
                result = (p2 * v2) / p1
                result_txt.Text = "V1 = " & result.ToString("N") & " ml"
            Case "v2"
                result = (p1 * v1) / p2
                result_txt.Text = "V2 = " & result.ToString("N") & " ml³"
            Case "p1"
                result = (v2 * p2) / v1
                result_txt.Text = "P1 = " & result.ToString("N") & " atm"
            Case "p2"
                result = (v1 * p1) / v2
                result_txt.Text = "P2 = " & result.ToString("N") & " atm"
        End Select
    End Sub

    Private Sub clear_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clear_btn.Click
        ResetForm()
    End Sub

    Private Sub SetFormState(ByVal v1Enabled As Boolean, ByVal v2Enabled As Boolean, ByVal p1Enabled As Boolean, ByVal p2Enabled As Boolean)
        v1_txt.Enabled = v1Enabled
        v2_txt.Enabled = v2Enabled
        p1_txt.Enabled = p1Enabled
        p2_txt.Enabled = p2Enabled
    End Sub

    Private Sub ClearInputFields()
        v1_txt.Text = ""
        v2_txt.Text = ""
        p1_txt.Text = ""
        p2_txt.Text = ""
        result_txt.Text = ""
    End Sub

    Private Sub ResetForm()
        SetFormState(True, True, True, True)
        ClearInputFields()
        calculationType = ""
    End Sub

    Private Function ValidateInputFields() As Boolean
        If calculationType = "v1" AndAlso (String.IsNullOrWhiteSpace(p1_txt.Text) Or String.IsNullOrWhiteSpace(p2_txt.Text) Or String.IsNullOrWhiteSpace(v2_txt.Text)) Then Return False
        If calculationType = "v2" AndAlso (String.IsNullOrWhiteSpace(p1_txt.Text) Or String.IsNullOrWhiteSpace(p2_txt.Text) Or String.IsNullOrWhiteSpace(v1_txt.Text)) Then Return False
        If calculationType = "p1" AndAlso (String.IsNullOrWhiteSpace(v1_txt.Text) Or String.IsNullOrWhiteSpace(p2_txt.Text) Or String.IsNullOrWhiteSpace(v2_txt.Text)) Then Return False
        If calculationType = "p2" AndAlso (String.IsNullOrWhiteSpace(v1_txt.Text) Or String.IsNullOrWhiteSpace(p1_txt.Text) Or String.IsNullOrWhiteSpace(v2_txt.Text)) Then Return False
        Return True
    End Function

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles v1_txt.KeyPress, v2_txt.KeyPress, p1_txt.KeyPress, p2_txt.KeyPress
        Dim txtBox As TextBox = DirectCast(sender, TextBox)

        ' Do not allow starting with a decimal point
        If e.KeyChar = "." AndAlso txtBox.TextLength = 0 Then
            e.Handled = True
            MessageBox.Show("Input must start with a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso txtBox.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Input can only contain one decimal point", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Allow digits, decimal point, and control keys (Backspace, Delete)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("Input must be numeric", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
End Class