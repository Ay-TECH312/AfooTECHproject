
Public Class Form1
    Dim SDT101, MAD102, SDA103, WAD104, NS105, AGD106 As Integer
    Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6 As Integer
    Dim GPA, TGP, TCU As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler SDT101_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MAD102_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler SDA103_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler WAD104_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler NS105_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler AGD106_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler SDT101_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MAD102_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler SDA103_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler WAD104_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler NS105_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler AGD106_txt.TextChanged, AddressOf TextBox_TextChanged
    End Sub
    Private Function GetGradePoint(ByVal score As Integer, ByVal creditUnits As Integer) As Integer
        Select Case score
            Case 80 To 100
                Return creditUnits * 4
            Case 70 To 79
                Return creditUnits * 3.5
            Case 60 To 69
                Return creditUnits * 3
            Case 50 To 59
                Return creditUnits * 2.5
            Case 40 To 49
                Return creditUnits * 2
            Case Else
                Return creditUnits * 0
        End Select
    End Function

    Private Sub calculate_btn_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn_txt.Click
        Try
            SDT101 = Double.Parse(SDT101_txt.Text)
            MAD102 = Double.Parse(MAD102_txt.Text)
            SDA103 = Double.Parse(SDA103_txt.Text)
            WAD104 = Double.Parse(WAD104_txt.Text)
            NS105 = Double.Parse(NS105_txt.Text)
            AGD106 = Double.Parse(AGD106_txt.Text)

            If (SDT101 < 0 Or SDT101 > 100) Or (MAD102 < 0 Or MAD102 > 100) Or (SDA103 < 0 Or SDA103 > 100) Or (WAD104 < 0 Or WAD104 > 100) Or (NS105 < 0 Or NS105 > 100) Or (AGD106 < 0 Or AGD106 > 100) Then
                MessageBox.Show("Scores Must Not < 0 or > 100.", " Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Gradepoint1 = GetGradePoint(SDT101, 4)
            Gradepoint2 = GetGradePoint(MAD102, 4)
            Gradepoint3 = GetGradePoint(SDA103, 5)
            Gradepoint4 = GetGradePoint(WAD104, 4)
            Gradepoint5 = GetGradePoint(NS105, 4)
            Gradepoint6 = GetGradePoint(AGD106, 4)

            TGP = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6
            TCU = 25
            GPA = TGP / TCU
            result_tgp_txt.Text = "  " & TGP.ToString
            result_tcu_txt.Text = "  " & TCU.ToString
            result_cgpa_txt.Text = "  " & GPA.ToString("F2")

            If GPA >= 3.5 And GPA <= 4.0 Then
                result_grade_txt.Text = "  " & "DISTINCTION"
            ElseIf GPA >= 3.0 And GPA <= 3.49 Then
                result_grade_txt.Text = "  " & "UPPER CREDIT"
            ElseIf GPA >= 2.5 And GPA <= 2.99 Then
                result_grade_txt.Text = "  " & "LOWER CREDIT"
            ElseIf GPA >= 2.0 And GPA <= 2.49 Then
                result_grade_txt.Text = "  " & "PASS"
            Else
                result_grade_txt.Text = "  " & "FAIL"
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter valid scores in ")
            Exit Sub
        End Try
    End Sub

 
    Private Sub clear_bnt_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_bnt_txt.Click
        SDT101_txt.Text = ""
        MAD102_txt.Text = ""
        SDA103_txt.Text = ""
        WAD104_txt.Text = ""
        NS105_txt.Text = ""
        AGD106_txt.Text = ""
        result_tgp_txt.Text = ""
        result_tcu_txt.Text = ""
        result_cgpa_txt.Text = ""
        result_grade_txt.Text = ""
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)

        ' Allow only digits, one decimal point, and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("Please enter only digits or one decimal point.")
            Return
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)
        Dim text As String = textBox.Text

        ' Ensure the input does not start with a decimal point
        If text.StartsWith(".") Then
            textBox.Text = ""
            MessageBox.Show("Scores must not start with a decimal point.")
            Return
        End If

        ' Ensure no more than 3 digits before the decimal point
        If text.Length > 3 AndAlso Not text.Contains(".") Then
            textBox.Text = text.Substring(0, 3)
            MessageBox.Show("Scores must not exceed 3 digits.")
            Return
        End If

        ' Ensure only one decimal point is allowed
        If text.Count(Function(c) c = "."c) > 1 Then
            textBox.Text = text.Remove(text.LastIndexOf("."c), 1)
            MessageBox.Show("Only one decimal point is allowed.")
            Return
        End If

        ' Reset the cursor position
        textBox.SelectionStart = textBox.Text.Length
    End Sub

End Class