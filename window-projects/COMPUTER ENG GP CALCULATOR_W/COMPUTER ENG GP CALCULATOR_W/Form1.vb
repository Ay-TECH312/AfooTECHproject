Public Class Form1
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub minimize_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        home_page_panel.Show()
        home_page_panel_btn.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        nd2_first_panel.Hide()
        nd2_second_panel.Hide()
        hnd1_first_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()

        'Assign event handlers to TextBoxes for ND1 FIRST SEMESTER'
        AddHandler GNS101_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS102_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH112_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler STAIII_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MEC101_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MEC107_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MEC113_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC113_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC116_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler COM111_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler GNS101_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS102_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH112_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler STAIII_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MEC101_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MEC107_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MEC113_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC113_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC116_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler COM111_txt.TextChanged, AddressOf TextBox_TextChanged

        'Assign event handlers to TextBoxes for ND1 SECOND SEMESTER'
        AddHandler GNS202_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS128_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH211_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MEC102_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MEC108_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC124_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC126_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler COM122_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler COM221_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE121_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE122_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler GNS202_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS128_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH211_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MEC102_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MEC108_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC124_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC126_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler COM122_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler COM221_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE121_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE122_txt.TextChanged, AddressOf TextBox_TextChanged

        ' Assign event handlers to TextBoxes for ND2 FIRST SEMESTER
        AddHandler GNS201_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH202_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC239_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC234_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE231_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE232_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE233_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE234_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE235_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE236_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler GNS201_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH202_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC239_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC234_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE231_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE232_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE233_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE234_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE235_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE236_txt.TextChanged, AddressOf TextBox_TextChanged


        ' Assign event handlers to TextBoxes for ND2 SECOND  SEMESTER
        AddHandler GNS202_2_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH122_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC249_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE245_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE241_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE242_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE243_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE244_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE246_txt.KeyPress, AddressOf TextBox_KeyPress
        
        AddHandler GNS202_2_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH202_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC249_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE245_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE241_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE242_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE243_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE244_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE246_txt.TextChanged, AddressOf TextBox_TextChanged


        ' Assign event handlers to TextBoxes for HND1 FIRST  SEMESTER
        AddHandler CTE313_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE314_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE315_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE316_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC313_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC314_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC315_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC316_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS311_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH311_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler CTE313_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE314_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE315_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE316_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC313_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC314_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC315_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC316_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS311_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH311_txt.TextChanged, AddressOf TextBox_TextChanged

        ' Assign event handlers to TextBoxes for HND1 SECOND  SEMESTER
        AddHandler CTE321_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE322_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE323_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC323_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC324_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC328_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC325_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS323_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS323_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH322_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler CTE321_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE322_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE323_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC323_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC324_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC328_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC325_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS323_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS323_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH322_txt.TextChanged, AddressOf TextBox_TextChanged

        ' Assign event handlers to TextBoxes for HND2 FIRST  SEMESTER
        AddHandler CTE410_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE411_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE412_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE413_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE414_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EEC415_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler EED416_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler GNS417_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH418_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE419_txt.KeyPress, AddressOf TextBox_KeyPress

        AddHandler CTE410_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE411_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE412_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE413_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE414_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EEC415_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler EED416_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler GNS417_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH418_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE419_txt.TextChanged, AddressOf TextBox_TextChanged

        ' Assign event handlers to TextBoxes for HND2 SECOND  SEMESTER
        AddHandler CTE421_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE422_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE423_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE424_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE428_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler CTE429_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler ICT425_txt.KeyPress, AddressOf TextBox_KeyPress
        AddHandler MTH423_txt.KeyPress, AddressOf TextBox_KeyPress
      
        AddHandler CTE421_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE422_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE423_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE424_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE428_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler CTE429_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler ICT425_txt.TextChanged, AddressOf TextBox_TextChanged
        AddHandler MTH423_txt.TextChanged, AddressOf TextBox_TextChanged

    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        home_page_panel.Hide()
        home_page_panel_btn.Show()
        nd1_first_panel.Show()
        nd1_second_panel.Hide()
        nd2_first_panel.Hide()
        nd2_second_panel.Hide()
        hnd1_first_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        home_page_panel.Hide()
        home_page_panel_btn.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Show()
        nd2_first_panel.Hide()
        nd2_second_panel.Hide()
        hnd1_first_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nd2_first_panel.Show()
        home_page_panel.Hide()
        home_page_panel_btn.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        nd2_second_panel.Hide()
        hnd1_first_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nd2_second_panel.Show()
        nd2_first_panel.Hide()
        home_page_panel.Hide()
        home_page_panel_btn.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        hnd1_first_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        hnd1_first_panel.Show()
        nd2_second_panel.Hide()
        nd2_first_panel.Hide()
        home_page_panel.Hide()
        home_page_panel_btn.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_page_panel_btn.Click
        home_page_panel_btn.Show()
        hnd1_first_panel.Hide()
        nd2_second_panel.Hide()
        nd2_first_panel.Hide()
        home_page_panel.Show()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        hnd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        hnd1_second_panel.Show()
        home_page_panel_btn.Show()
        hnd1_first_panel.Hide()
        nd2_second_panel.Hide()
        nd2_first_panel.Hide()
        home_page_panel.Hide()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        hnd2_first_panel.Hide()
        hnd2_second_panel.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        hnd2_first_panel.Show()
        hnd1_second_panel.Hide()
        home_page_panel_btn.Show()
        hnd1_first_panel.Hide()
        nd2_second_panel.Hide()
        nd2_first_panel.Hide()
        home_page_panel.Hide()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
        hnd2_second_panel.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        hnd2_second_panel.Show()
        hnd2_first_panel.Hide()
        hnd1_second_panel.Hide()
        home_page_panel_btn.Show()
        hnd1_first_panel.Hide()
        nd2_second_panel.Hide()
        nd2_first_panel.Hide()
        home_page_panel.Hide()
        nd1_first_panel.Hide()
        nd1_second_panel.Hide()
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

    ' Declare variables to store scores  for ND1 FIRST SEMESTER S

    Dim GNS101, GNS102, MTH112, STA111, MEC101, MEC107, MEC113, EEC113, EEC116, COM111 As Integer
    Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, Gradepoint7, Gradepoint8, Gradepoint9, Gradepoint10 As Double
    Dim GPA, TGP, TCU As Double

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        Try
            GNS101 = Double.Parse(GNS101_txt.Text)
            GNS102 = Double.Parse(GNS102_txt.Text)
            MTH112 = Double.Parse(MTH112_txt.Text)
            STA111 = Double.Parse(STAIII_txt.Text)
            MEC101 = Double.Parse(MEC101_txt.Text)
            MEC107 = Double.Parse(MEC107_txt.Text)
            MEC113 = Double.Parse(MEC113_txt.Text)
            EEC113 = Double.Parse(EEC113_txt.Text)
            EEC116 = Double.Parse(EEC116_txt.Text)
            COM111 = Double.Parse(COM111_txt.Text)
        Catch ex As Exception
            MessageBox.Show("This field supports only number.")
            Exit Sub
        End Try

        If GNS101 < 0 Or GNS101 > 100 Or GNS102 < 0 Or GNS102 > 100 Or MTH112 < 0 Or MTH112 > 100 Or STA111 < 0 Or STA111 > 100 Or MEC101 < 0 Or MEC101 > 100 Or MEC107 < 0 Or MEC107 > 100 Or MEC113 < 0 Or MEC113 > 100 Or EEC113 < 0 Or EEC113 > 100 Or EEC116 < 0 Or EEC116 > 100 Or COM111 < 0 Or COM111 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        Gradepoint1 = CalculateGradePoint(GNS101, 2)
        Gradepoint2 = CalculateGradePoint(GNS102, 2)
        Gradepoint3 = CalculateGradePoint(MTH112, 2)
        Gradepoint4 = CalculateGradePoint(STA111, 2)
        Gradepoint5 = CalculateGradePoint(MEC101, 2)
        Gradepoint6 = CalculateGradePoint(MEC107, 3)
        Gradepoint7 = CalculateGradePoint(MEC113, 3)
        Gradepoint8 = CalculateGradePoint(EEC113, 2)
        Gradepoint9 = CalculateGradePoint(EEC116, 2)
        Gradepoint10 = CalculateGradePoint(COM111, 2)

        TGP = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6 + Gradepoint7 + Gradepoint8 + Gradepoint9 + Gradepoint10
        TCU = 22
        GPA = TGP / TCU
        result_TGP_txt.Text = "  " & TGP.ToString
        result_TCU_txt.Text = "  " & TCU.ToString
        result_CGPA_txt.Text = "  " & GPA.ToString("n2")


        If GPA >= 3.5 And GPA <= 4.0 Then
            result_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA >= 3.0 And GPA <= 3.49 Then
            result_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA >= 2.5 And GPA <= 2.99 Then
            result_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA >= 2.0 And GPA <= 2.49 Then
            result_GRADE_txt.Text = "  " & "PASS"
        Else
            result_GRADE_txt.Text = "  " & "FAIL"
        End If

    End Sub

    Private Function CalculateGradePoint(ByVal score As Integer, ByVal units As Integer) As Double
        Dim gradePoint As Double

        Select Case score
            Case 75 To 100
                gradePoint = units * 4.0
            Case 70 To 74
                gradePoint = units * 3.5
            Case 65 To 69
                gradePoint = units * 3.25
            Case 60 To 64
                gradePoint = units * 3.0
            Case 55 To 59
                gradePoint = units * 2.75
            Case 50 To 54
                gradePoint = units * 2.5
            Case 45 To 49
                gradePoint = units * 2.25
            Case 40 To 44
                gradePoint = units * 2.0
            Case Else
                gradePoint = units * 0.0
        End Select
        Return gradePoint
    End Function

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        GNS101_txt.Text = ""
        GNS102_txt.Text = ""
        MTH112_txt.Text = ""
        STAIII_txt.Text = ""
        MEC101_txt.Text = ""
        MEC107_txt.Text = ""
        MEC113_txt.Text = ""
        EEC113_txt.Text = ""
        EEC116_txt.Text = ""
        COM111_txt.Text = ""
        result_CGPA_txt.Text = ""
        result_TCU_txt.Text = ""
        result_TGP_txt.Text = ""
        result_GRADE_txt.Text = ""
    End Sub

    ' Declare variables to store scores for ND1 SECOND SEMESTER  
 Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n1_2nd_calculate_btn.Click
        Dim GNS202, GNS128, MTH211, MEC102, MEC108, EEC124, EEC126, COM122, COM221, CTE121, CTE122 As Integer
        Dim Gradepoint11, Gradepoint12, Gradepoint13, Gradepoint14, Gradepoint15, Gradepoint16, Gradepoint17, Gradepoint18, Gradepoint19, Gradepoint20, Gradepoint201 As Double
        Dim GPA2, TGP2, TCU2 As Double

        Try
            GNS202 = Double.Parse(GNS202_txt.Text)
            GNS128 = Double.Parse(GNS128_txt.Text)
            MTH211 = Double.Parse(MTH211_txt.Text)
            MEC102 = Double.Parse(MEC102_txt.Text)
            MEC108 = Double.Parse(MEC108_txt.Text)
            EEC124 = Double.Parse(EEC124_txt.Text)
            EEC126 = Double.Parse(EEC126_txt.Text)
            COM122 = Double.Parse(COM122_txt.Text)
            COM221 = Double.Parse(COM221_txt.Text)
            CTE121 = Double.Parse(CTE121_txt.Text)
            CTE122 = Double.Parse(CTE122_txt.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If GNS202 < 0 Or GNS202 > 100 Or GNS128 < 0 Or GNS128 > 100 Or MTH211 < 0 Or MTH211 > 100 Or MEC102 < 0 Or MEC102 > 100 Or MEC108 < 0 Or MEC108 > 100 Or EEC124 < 0 Or EEC124 > 100 Or EEC126 < 0 Or EEC126 > 100 Or COM122 < 0 Or COM122 > 100 Or COM221 < 0 Or COM221 > 100 Or CTE121 < 0 Or CTE121 > 100 Or CTE122 < 0 Or CTE122 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        Gradepoint11 = CalculateGradePoint(GNS202, 2)
        Gradepoint12 = CalculateGradePoint(GNS128, 2)
        Gradepoint13 = CalculateGradePoint(MTH211, 2)
        Gradepoint14 = CalculateGradePoint(MEC102, 2)
        Gradepoint15 = CalculateGradePoint(MEC108, 2)
        Gradepoint16 = CalculateGradePoint(EEC124, 3)
        Gradepoint17 = CalculateGradePoint(EEC126, 1)
        Gradepoint18 = CalculateGradePoint(COM122, 2)
        Gradepoint19 = CalculateGradePoint(COM221, 3)
        Gradepoint20 = CalculateGradePoint(CTE121, 2)
        Gradepoint201 = CalculateGradePoint(CTE122, 2)

        TGP2 = Gradepoint11 + Gradepoint12 + Gradepoint13 + Gradepoint14 + Gradepoint15 + Gradepoint16 + Gradepoint17 + Gradepoint18 + Gradepoint19 + Gradepoint20 + Gradepoint201
        TCU2 = 23
        GPA2 = TGP2 / TCU2
        nd1_2nd_TCU_txt.Text = "  " & TGP2.ToString
        nd1_2nd_TGP_txt.Text = "  " & TCU2.ToString
        nd1_2nd_GPA_txt.Text = "  " & GPA2.ToString("n2")

        If GPA2 >= 3.5 And GPA2 <= 4.0 Then
            nd1_2nd_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA2 >= 3.0 And GPA2 <= 3.49 Then
            nd1_2nd_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA2 >= 2.5 And GPA2 <= 2.99 Then
            nd1_2nd_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA2 >= 2.0 And GPA2 <= 2.49 Then
            nd1_2nd_GRADE_txt.Text = "  " & "PASS"
        Else
            nd1_2nd_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub
    Private Sub nd1_2nd_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd1_2nd_clear_btn.Click
        GNS202_txt.Text = ""
        GNS128_txt.Text = ""
        MTH211_txt.Text = ""
        MEC102_txt.Text = ""
        MEC108_txt.Text = ""
        EEC124_txt.Text = ""
        EEC126_txt.Text = ""
        COM122_txt.Text = ""
        COM221_txt.Text = ""
        CTE121_txt.Text = ""
        CTE122_txt.Text = ""
        nd1_2nd_TCU_txt.Text = ""
        nd1_2nd_TGP_txt.Text = ""
        nd1_2nd_GPA_txt.Text = ""
        nd1_2nd_GRADE_txt.Text = ""
    End Sub

    ' Declare variables to store scores for ND2 FIRST SEMESTER
    Private Sub nd2_first_calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd2_first_calculate_btn.Click
        Dim GNS201, MTH202, EEC239, EEC234, CTE231, CTE232, CTE233, CTE234, CTE235, CTE236 As Integer
        Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF, GradepointG, GradepointH, Gradepoint19I, Gradepoint2J As Double
        Dim GPA3, TGP3, TCU3 As Double

        Try
            GNS201 = Double.Parse(GNS201_txt.Text)
            MTH202 = Double.Parse(MTH202_txt.Text)
            EEC239 = Double.Parse(EEC239_txt.Text)
            EEC234 = Double.Parse(EEC234_txt.Text)
            CTE231 = Double.Parse(CTE231_txt.Text)
            CTE232 = Double.Parse(CTE232_txt.Text)
            CTE233 = Double.Parse(CTE233_txt.Text)
            CTE234 = Double.Parse(CTE234_txt.Text)
            CTE235 = Double.Parse(CTE235_txt.Text)
            CTE236 = Double.Parse(CTE236_txt.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If GNS201 < 0 Or GNS201 > 100 Or MTH202 < 0 Or MTH202 > 100 Or EEC239 < 0 Or EEC239 > 100 Or EEC234 < 0 Or EEC234 > 100 Or CTE231 < 0 Or CTE231 > 100 Or CTE232 < 0 Or CTE232 > 100 Or CTE233 < 0 Or CTE233 > 100 Or CTE234 < 0 Or CTE234 > 100 Or CTE235 < 0 Or CTE235 > 100 Or CTE236 < 0 Or CTE236 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        GradepointA = CalculateGradePoint(GNS201, 2)
        GradepointB = CalculateGradePoint(MTH202, 2)
        GradepointC = CalculateGradePoint(EEC239, 2)
        GradepointD = CalculateGradePoint(EEC234, 3)
        GradepointE = CalculateGradePoint(CTE231, 3)
        GradepointF = CalculateGradePoint(CTE232, 2)
        GradepointG = CalculateGradePoint(CTE233, 3)
        GradepointH = CalculateGradePoint(CTE234, 1)
        Gradepoint19I = CalculateGradePoint(CTE235, 2)
        Gradepoint2J = CalculateGradePoint(CTE236, 2)

        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP3 = GradepointA + GradepointB + GradepointC + GradepointD + GradepointE + GradepointF + GradepointG + GradepointH + Gradepoint19I + Gradepoint2J
        TCU3 = 22
        GPA3 = TGP3 / TCU3
        nd2_first_TGP_txt.Text = "  " & TGP3.ToString
        nd2_first_TCU_txt.Text = "  " & TCU3.ToString
        nd2_first_GPA_txt.Text = "  " & GPA3.ToString("n2")

        If GPA3 >= 3.5 And GPA3 <= 4.0 Then
            nd2_first_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA3 >= 3.0 And GPA3 <= 3.49 Then
            nd2_first_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA3 >= 2.5 And GPA3 <= 2.99 Then
            nd2_first_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA3 >= 2.0 And GPA3 <= 2.49 Then
            nd2_first_GRADE_txt.Text = "  " & "PASS"
        Else
            nd2_first_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub nd2_first_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd2_first_clear_btn.Click
        GNS201_txt.Text = ""
        MTH202_txt.Text = ""
        EEC239_txt.Text = ""
        EEC234_txt.Text = ""
        CTE231_txt.Text = ""
        CTE232_txt.Text = ""
        CTE233_txt.Text = ""
        CTE234_txt.Text = ""
        CTE235_txt.Text = ""
        CTE236_txt.Text = ""
        nd2_first_TGP_txt.Text = ""
        nd2_first_TCU_txt.Text = ""
        nd2_first_GPA_txt.Text = ""
        nd2_first_GRADE_txt.Text = ""
    End Sub

    ' Declare variables to store scores for ND2 SECOND SEMESTER
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd2_2nd_calculate_btn.Click
        Dim GNS202_2, MTH122, EEC249, CTE245, CTE241, CTE242, CTE243, CTE244, CTE246 As Integer
        Dim Gradepoint01, Gradepoint02, Gradepoint03, Gradepoint04, Gradepoint05, Gradepoint06, Gradepoint07, Gradepoint08, Gradepoint09 As Double
        Dim GPA4, TGP4, TCU4 As Double

        Try
            GNS202_2 = Double.Parse(GNS202_2_txt.Text)
            MTH122 = Double.Parse(MTH122_txt.Text)
            EEC249 = Double.Parse(EEC249_txt.Text)
            CTE245 = Double.Parse(CTE245_txt.Text)
            CTE241 = Double.Parse(CTE241_txt.Text)
            CTE242 = Double.Parse(CTE242_txt.Text)
            CTE243 = Double.Parse(CTE243_txt.Text)
            CTE244 = Double.Parse(CTE244_txt.Text)
            CTE246 = Double.Parse(CTE246_txt.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If GNS202_2 < 0 Or GNS202_2 > 100 Or MTH122 < 0 Or MTH122 > 100 Or EEC249 < 0 Or EEC249 > 100 Or CTE245 < 0 Or CTE245 > 100 Or CTE241 < 0 Or CTE241 > 100 Or CTE242 < 0 Or CTE242 > 100 Or CTE243 < 0 Or CTE243 > 100 Or CTE244 < 0 Or CTE244 > 100 Or CTE246 < 0 Or CTE246 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        Gradepoint01 = CalculateGradePoint(GNS202_2, 2)
        Gradepoint02 = CalculateGradePoint(MTH122, 2)
        Gradepoint03 = CalculateGradePoint(EEC249, 2)
        Gradepoint04 = CalculateGradePoint(CTE245, 3)
        Gradepoint05 = CalculateGradePoint(CTE241, 2)
        Gradepoint06 = CalculateGradePoint(CTE242, 1)
        Gradepoint07 = CalculateGradePoint(CTE243, 2)
        Gradepoint08 = CalculateGradePoint(CTE244, 2)
        Gradepoint09 = CalculateGradePoint(CTE246, 6)
       
        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP4 = Gradepoint01 + Gradepoint02 + Gradepoint03 + Gradepoint04 + Gradepoint05 + Gradepoint06 + Gradepoint07 + Gradepoint08 + Gradepoint09
        TCU4 = 22
        GPA4 = TGP4 / TCU4
        nd2_2nd_TGP_txt.Text = "  " & TGP4.ToString
        nd2_2nd_TCU_txt.Text = "  " & TCU4.ToString
        nd2_2nd_GPA_txt.Text = "  " & GPA4.ToString("n2")

        If GPA4 >= 3.5 And GPA4 <= 4.0 Then
            nd2_2nd_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA4 >= 3.0 And GPA4 <= 3.49 Then
            nd2_2nd_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA4 >= 2.5 And GPA4 <= 2.99 Then
            nd2_2nd_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA4 >= 2.0 And GPA4 <= 2.49 Then
            nd2_2nd_GRADE_txt.Text = "  " & "PASS"
        Else
            nd2_2nd_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub nd2_2nd_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd2_2nd_clear_btn.Click
        GNS202_2_txt.Text = ""
        MTH122_txt.Text = ""
        EEC249_txt.Text = ""
        CTE245_txt.Text = ""
        CTE241_txt.Text = ""
        CTE242_txt.Text = ""
        CTE243_txt.Text = ""
        CTE244_txt.Text = ""
        CTE246_txt.Text = ""
        nd2_2nd_TGP_txt.Text = ""
        nd2_2nd_TCU_txt.Text = ""
        nd2_2nd_GPA_txt.Text = ""
        nd2_2nd_GRADE_txt.Text = ""
    End Sub
   
    ' Declare variables to store scores for HND1 FIRST SEMESTER
    Private Sub hnd1_first_calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd1_first_calculate_btn.Click
        Dim CTE313, CTE314, CTE315, CTE316, EEC313, EEC314, EEC315, EEC316, GNS311, MTH311 As Integer
        Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, Gradepoint7, Gradepoint8, Gradepoint9, Gradepoint10 As Double
        Dim GPA5, TGP5, TCU5 As Double
        Try
            CTE313 = Double.Parse(CTE313_txt.Text)
            CTE314 = Double.Parse(CTE314_txt.Text)
            CTE315 = Double.Parse(CTE315_txt.Text)
            CTE316 = Double.Parse(CTE316_txt.Text)
            EEC313 = Double.Parse(EEC313_txt.Text)
            EEC314 = Double.Parse(EEC314_txt.Text)
            EEC315 = Double.Parse(EEC315_txt.Text)
            EEC316 = Double.Parse(EEC316_txt.Text)
            GNS311 = Double.Parse(GNS311_txt.Text)
            MTH311 = Double.Parse(MTH311_txt.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If CTE313 < 0 Or CTE313 > 100 Or CTE314 < 0 Or CTE314 > 100 Or CTE315 < 0 Or CTE315 > 100 Or CTE316 < 0 Or CTE316 > 100 Or EEC313 < 0 Or EEC313 > 100 Or EEC314 < 0 Or EEC314 > 100 Or EEC315 < 0 Or EEC315 > 100 Or EEC316 < 0 Or EEC316 > 100 Or GNS311 < 0 Or GNS311 > 100 Or MTH311 < 0 Or MTH311 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        Gradepoint1 = CalculateGradePoint(CTE313, 2)
        Gradepoint2 = CalculateGradePoint(CTE314, 2)
        Gradepoint3 = CalculateGradePoint(CTE315, 2)
        Gradepoint4 = CalculateGradePoint(CTE316, 3)
        Gradepoint5 = CalculateGradePoint(EEC313, 2)
        Gradepoint6 = CalculateGradePoint(EEC314, 2)
        Gradepoint7 = CalculateGradePoint(EEC315, 2)
        Gradepoint8 = CalculateGradePoint(EEC316, 3)
        Gradepoint9 = CalculateGradePoint(GNS311, 2)
        Gradepoint10 = CalculateGradePoint(MTH311, 2)

        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP5 = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6 + Gradepoint7 + Gradepoint8 + Gradepoint9 + Gradepoint10
        TCU5 = 22
        GPA5 = TGP5 / TCU5
        hnd1_first_TGP_txt.Text = "  " & TGP5.ToString
        hnd1_first_TCU_txt.Text = "  " & TCU5.ToString
        hnd1_first_GPA_txt.Text = "  " & GPA5.ToString("n2")

        If GPA5 >= 3.5 And GPA5 <= 4.0 Then
            hnd1_first_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA5 >= 3.0 And GPA5 <= 3.49 Then
            hnd1_first_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA5 >= 2.5 And GPA5 <= 2.99 Then
            hnd1_first_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA5 >= 2.0 And GPA5 <= 2.49 Then
            hnd1_first_GRADE_txt.Text = "  " & "PASS"
        Else
            hnd1_first_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub hnd1_first_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd1_first_clear_btn.Click
        CTE313_txt.Text = ""
        CTE314_txt.Text = ""
        CTE315_txt.Text = ""
        CTE316_txt.Text = ""
        EEC313_txt.Text = ""
        EEC314_txt.Text = ""
        EEC315_txt.Text = ""
        EEC316_txt.Text = ""
        MTH311_txt.Text = ""
        GNS311_txt.Text = ""
        hnd1_first_TGP_txt.Text = ""
        hnd1_first_TCU_txt.Text = ""
        hnd1_first_GPA_txt.Text = ""
        hnd1_first_GRADE_txt.Text = ""
    End Sub
  
    ' Declare variables to store scores for HND1 SECOND SEMESTER
    Private Sub hnd1_second_calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd1_second_calculate_btn.Click
        Dim CTE321, CTE322, CTE323, EEC323, EEC324, EEC328, EEC325, GNS322, GNS323, MTH322 As Integer
        Dim Gradepoint1A1, Gradepoint1A2, Gradepoint1A3, Gradepoint1A4, Gradepoint1A5, Gradepoint1A6, Gradepoint1A7, Gradepoint1A8, Gradepoint1A9, Gradepoint2A0 As Double
        Dim GPA6, TGP6, TCU6 As Double
        Try
            CTE321 = Double.Parse(CTE321_txt.Text)
            CTE322 = Double.Parse(CTE322_txt.Text)
            CTE323 = Double.Parse(CTE323_txt.Text)
            EEC323 = Double.Parse(EEC323_txt.Text)
            EEC324 = Double.Parse(EEC324_txt.Text)
            EEC328 = Double.Parse(EEC328_txt.Text)
            EEC325 = Double.Parse(EEC325_txt.Text)
            GNS322 = Double.Parse(GNS322_txt.Text)
            GNS323 = Double.Parse(GNS323_txt.Text)
            MTH322 = Double.Parse(MTH322_txt.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If CTE321 < 0 Or CTE321 > 100 Or CTE322 < 0 Or CTE322 > 100 Or CTE323 < 0 Or CTE323 > 100 Or EEC323 < 0 Or EEC323 > 100 Or EEC324 < 0 Or EEC324 > 100 Or EEC328 < 0 Or EEC328 > 100 Or EEC325 < 0 Or EEC325 > 100 Or GNS322 < 0 Or GNS322 > 100 Or GNS323 < 0 Or GNS323 > 100 Or MTH322 < 0 Or MTH322 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        Gradepoint1A1 = CalculateGradePoint(CTE321, 2)
        Gradepoint1A2 = CalculateGradePoint(CTE322, 2)
        Gradepoint1A3 = CalculateGradePoint(CTE323, 2)
        Gradepoint1A4 = CalculateGradePoint(EEC323, 3)
        Gradepoint1A5 = CalculateGradePoint(EEC324, 3)
        Gradepoint1A6 = CalculateGradePoint(EEC328, 2)
        Gradepoint1A7 = CalculateGradePoint(EEC325, 2)
        Gradepoint1A8 = CalculateGradePoint(GNS322, 2)
        Gradepoint1A9 = CalculateGradePoint(GNS323, 2)
        Gradepoint2A0 = CalculateGradePoint(MTH322, 2)

        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP6 = Gradepoint1A1 + Gradepoint1A2 + Gradepoint1A3 + Gradepoint1A4 + Gradepoint1A5 + Gradepoint1A6 + Gradepoint1A7 + Gradepoint1A8 + Gradepoint1A9 + Gradepoint2A0
        TCU6 = 22
        GPA6 = TGP6 / TCU6
        hnd1_second_TGP_txt.Text = "  " & TGP6.ToString
        hnd1_second_TCU_txt.Text = "  " & TCU6.ToString
        hnd1_second_GPA_txt.Text = "  " & GPA6.ToString("n2")

        If GPA6 >= 3.5 And GPA6 <= 4.0 Then
            hnd1_second_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA6 >= 3.0 And GPA6 <= 3.49 Then
            hnd1_second_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA6 >= 2.5 And GPA6 <= 2.99 Then
            hnd1_second_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA6 >= 2.0 And GPA6 <= 2.49 Then
            hnd1_second_GRADE_txt.Text = "  " & "PASS"
        Else
            hnd1_second_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub hnd1_second_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd1_second_clear_btn.Click
        CTE321_txt.Text = ""
        CTE322_txt.Text = ""
        CTE323_txt.Text = ""
        EEC323_txt.Text = ""
        EEC324_txt.Text = ""
        EEC328_txt.Text = ""
        EEC325_txt.Text = ""
        GNS322_txt.Text = ""
        GNS323_txt.Text = ""
        MTH322_txt.Text = ""
        hnd1_second_TGP_txt.Text = ""
        hnd1_second_TCU_txt.Text = ""
        hnd1_second_GPA_txt.Text = ""
        hnd1_second_GRADE_txt.Text = ""
    End Sub
  
    ' Declare variables to store scores for HND2 FIRST SEMESTER
    Private Sub hnd2_first_calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd2_first_calculate_btn.Click
        Dim CTE410, CTE411, CTE412, CTE413, CTE414, EEC415, EED416, GNS417, MTH418, CTE419 As Integer
        Dim GradepointAA, GradepointAB, GradepointAC, GradepointAD, GradepointAE, GradepointAF, GradepointAG, GradepointAH, GradepointAI, GradepointAJ As Double
        Dim GPA7, TGP7, TCU7 As Double
        Try
            CTE410 = Double.Parse(CTE410_txt.Text)
            CTE411 = Double.Parse(CTE411_txt.Text)
            CTE412 = Double.Parse(CTE412_txt.Text)
            CTE413 = Double.Parse(CTE413_txt.Text)
            CTE414 = Double.Parse(CTE414_txt.Text)
            EEC415 = Double.Parse(EEC415_txt.Text)
            EED416 = Double.Parse(EED416_txt.Text)
            GNS417 = Double.Parse(GNS417_txt.Text)
            MTH418 = Double.Parse(MTH418_txt.Text)
            CTE419 = Double.Parse(CTE419_txt.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If CTE410 < 0 Or CTE410 > 100 Or CTE411 < 0 Or CTE411 > 100 Or CTE412 < 0 Or CTE412 > 100 Or CTE413 < 0 Or CTE413 > 100 Or CTE414 < 0 Or CTE414 > 100 Or EEC415 < 0 Or EEC415 > 100 Or EED416 < 0 Or EED416 > 100 Or GNS417 < 0 Or GNS417 > 100 Or MTH418 < 0 Or MTH418 > 100 Or CTE419 < 0 Or CTE419 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        GradepointAA = CalculateGradePoint(CTE410, 2)
        GradepointAB = CalculateGradePoint(CTE411, 2)
        GradepointAC = CalculateGradePoint(CTE412, 2)
        GradepointAD = CalculateGradePoint(CTE413, 2)
        GradepointAE = CalculateGradePoint(CTE414, 2)
        GradepointAF = CalculateGradePoint(EEC415, 2)
        GradepointAG = CalculateGradePoint(EED416, 2)
        GradepointAH = CalculateGradePoint(GNS417, 2)
        GradepointAI = CalculateGradePoint(MTH418, 2)
        GradepointAJ = CalculateGradePoint(CTE419, 1)

        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP7 = GradepointAA + GradepointAB + GradepointAC + GradepointAD + GradepointAE + GradepointAF + GradepointAG + GradepointAH + GradepointAI + GradepointAJ
        TCU7 = 19
        GPA7 = TGP7 / TCU7
        hnd2_first_TGP_txt.Text = "  " & TGP7.ToString
        hnd2_first_TCU_txt.Text = "  " & TCU7.ToString
        hnd2_first_GPA_txt.Text = "  " & GPA7.ToString("n2")

        If GPA7 >= 3.5 And GPA7 <= 4.0 Then
            hnd2_first_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA7 >= 3.0 And GPA7 <= 3.49 Then
            hnd2_first_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA7 >= 2.5 And GPA7 <= 2.99 Then
            hnd2_first_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA7 >= 2.0 And GPA7 <= 2.49 Then
            hnd2_first_GRADE_txt.Text = "  " & "PASS"
        Else
            hnd2_first_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub hnd2_first_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd2_first_clear_btn.Click
        CTE410_txt.Text = ""
        CTE411_txt.Text = ""
        CTE412_txt.Text = ""
        CTE413_txt.Text = ""
        CTE414_txt.Text = ""
        EEC415_txt.Text = ""
        EED416_txt.Text = ""
        GNS417_txt.Text = ""
        MTH418_txt.Text = ""
        CTE419_txt.Text = ""
        hnd2_first_TGP_txt.Text = ""
        hnd2_first_TCU_txt.Text = ""
        hnd2_first_GPA_txt.Text = ""
        hnd2_first_GRADE_txt.Text = ""
    End Sub
  
    ' Declare variables to store scores for HND2 SECOND SEMESTER
    Private Sub hnd2_second_calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd2_second_calculate_btn.Click
        Dim CTE421, CTE422, CTE423, CTE424, CTE428, CTE429, ICT425, MTH423 As Integer
        Dim GradepointZ, GradepointY, GradepointX, GradepointW, GradepointN, GradepointM, GradepointP, GradepointQ As Double
        Dim GPA8, TGP8, TCU8 As Double
        Try
            CTE421 = Double.Parse(CTE421_txt.Text)
            CTE422 = Double.Parse(CTE422_txt.Text)
            CTE423 = Double.Parse(CTE423_txt.Text)
            CTE424 = Double.Parse(CTE424_txt.Text)
            CTE428 = Double.Parse(CTE428_txt.Text)
            CTE429 = Double.Parse(CTE429_txt.Text)
            ICT425 = Double.Parse(ICT425_txt.Text)
            MTH423 = Double.Parse(MTH423_txt.Text)
          
        Catch ex As Exception
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End Try

        If CTE421 < 0 Or CTE421 > 100 Or CTE422 < 0 Or CTE422 > 100 Or CTE423 < 0 Or CTE423 > 100 Or CTE424 < 0 Or CTE424 > 100 Or CTE428 < 0 Or CTE428 > 100 Or CTE429 < 0 Or CTE429 > 100 Or ICT425 < 0 Or ICT425 > 100 Or MTH423 < 0 Or MTH423 > 100 Then
            MessageBox.Show("Please enter valid scores between 0 and 100.")
            Exit Sub
        End If

        GradepointZ = CalculateGradePoint(CTE421, 3)
        GradepointY = CalculateGradePoint(CTE422, 3)
        GradepointX = CalculateGradePoint(CTE423, 2)
        GradepointW = CalculateGradePoint(CTE424, 2)
        GradepointN = CalculateGradePoint(CTE428, 3)
        GradepointM = CalculateGradePoint(CTE429, 6)
        GradepointP = CalculateGradePoint(ICT425, 1)
        GradepointQ = CalculateGradePoint(MTH423, 2)
       

        ' Calculate Total Grade Points,Total Course Units and GPA
        TGP8 = GradepointZ + GradepointY + GradepointX + GradepointW + GradepointN + GradepointM + GradepointP + GradepointQ
        TCU8 = 22
        GPA8 = TGP8 / TCU8
        hnd2_second_TGP_txt.Text = "  " & TGP8.ToString
        hnd2_second_TCU_txt.Text = "  " & TCU8.ToString
        hnd2_second_GPA_txt.Text = "  " & GPA8.ToString("n2")

        If GPA8 >= 3.5 And GPA8 <= 4.0 Then
            hnd2_second_GRADE_txt.Text = "  " & "DISTINCTION"
        ElseIf GPA8 >= 3.0 And GPA8 <= 3.49 Then
            hnd2_second_GRADE_txt.Text = "  " & "UPPER CREDIT"
        ElseIf GPA8 >= 2.5 And GPA8 <= 2.99 Then
            hnd2_second_GRADE_txt.Text = "  " & "LOWER CREDIT"
        ElseIf GPA8 >= 2.0 And GPA8 <= 2.49 Then
            hnd2_second_GRADE_txt.Text = "  " & "PASS"
        Else
            hnd2_first_GRADE_txt.Text = "  " & "FAIL"
        End If
    End Sub

    Private Sub hnd2_second_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hnd2_second_clear_btn.Click
        CTE421_txt.Text = ""
        CTE422_txt.Text = ""
        CTE423_txt.Text = ""
        CTE424_txt.Text = ""
        CTE428_txt.Text = ""
        CTE429_txt.Text = ""
        ICT425_txt.Text = ""
        MTH423_txt.Text = ""
        hnd2_second_TGP_txt.Text = ""
        hnd2_second_TCU_txt.Text = ""
        hnd2_second_GPA_txt.Text = ""
        hnd2_second_GRADE_txt.Text = ""
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