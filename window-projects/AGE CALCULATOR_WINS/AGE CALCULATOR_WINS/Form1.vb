
Public Class Form1
    ' Declare variables to hold date values
    Dim current_day, current_month, current_year As Integer
    Dim birth_day, birth_month, birth_year As Integer
    Dim age_day, age_month, age_year As Integer

    ' Error provider for displaying error messages
    Dim errorProvider As New ErrorProvider()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Initialize current date values
        current_day = DateTime.Now.Day
        current_month = DateTime.Now.Month
        current_year = DateTime.Now.Year

        ' Display current date in textboxes
        current_day_txt.Text = current_day.ToString()
        current_month_txt.Text = current_month.ToString()
        current_year_txt.Text = current_year.ToString()

        ' Set up error provider settings
        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink ' Optional: Prevents blinking of error icon
    End Sub

    Private Sub birth_day_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles birth_day_txt.TextChanged
        ' Validate birth day input
        If Not Integer.TryParse(birth_day_txt.Text, birth_day) OrElse
           birth_day <= 0 OrElse birth_day > 31 Then
            errorProvider.SetError(birth_day_txt, "Invalid day. Enter a valid day (1-31).")
            birth_month_txt.Enabled = False ' Disable subsequent inputs
            birth_year_txt.Enabled = False
        Else
            errorProvider.SetError(birth_day_txt, "")
            birth_month_txt.Enabled = True ' Enable subsequent inputs
            birth_year_txt.Enabled = True
        End If
    End Sub

    Private Sub birth_month_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles birth_month_txt.TextChanged
        ' Validate birth month input
        If Not Integer.TryParse(birth_month_txt.Text, birth_month) OrElse
           birth_month <= 0 OrElse birth_month > 12 Then
            errorProvider.SetError(birth_month_txt, "Invalid month. Enter a valid month (1-12).")
            birth_year_txt.Enabled = False ' Disable subsequent inputs
        Else
            errorProvider.SetError(birth_month_txt, "")
            birth_year_txt.Enabled = True ' Enable subsequent inputs
        End If
    End Sub
    Private Sub birth_year_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles birth_year_txt.TextChanged
        ' Validate birth year input
        If Not Integer.TryParse(birth_year_txt.Text, birth_year) OrElse
           birth_year <= 0 OrElse birth_year > current_year Then
            errorProvider.SetError(birth_year_txt, "Invalid year. Enter a valid year.")
            Return
        End If
    End Sub

    Private Sub calculate_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calculate_btn.Click
        ' Check if all inputs are valid
        If Not Integer.TryParse(birth_year_txt.Text, birth_year) Then
            MessageBox.Show("Date is incorrect, Enter the correct date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf birth_year < 0 Then
            MessageBox.Show("Invalid Date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf birth_day > DateTime.DaysInMonth(birth_year, birth_month) Then
            MessageBox.Show("Invalid Date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else

            ' Calculate age
            age_year = current_year - birth_year

            If current_month >= birth_month Then
                age_month = current_month - birth_month
            Else
                age_month = 12 + current_month - birth_month
                age_year -= 1
            End If

            If current_day >= birth_day Then
                age_day = current_day - birth_day
            Else
                age_month -= 1
                age_day = DateTime.DaysInMonth(birth_year, birth_month) + current_day - birth_day
            End If
            If age_month < 0 Then
                age_month = 11
                age_year -= 1
            End If
            If age_year < 0 Then
                MessageBox.Show("Invalid Date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Display age in textboxes
            age_day_txt.Text = age_day.ToString()
            age_month_txt.Text = age_month.ToString()
            age_year_txt.Text = age_year.ToString()

        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate all inputs
        If birth_day <= 0 Or birth_day > 31 Then
            errorProvider.SetError(birth_day_txt, "Invalid day. Enter a valid day (1-31).")
            Return False
        End If

        If birth_month <= 0 Or birth_month > 12 Then
            errorProvider.SetError(birth_month_txt, "Invalid month. Enter a valid month (1-12).")
            Return False
        End If

        If birth_year <= 0 Or birth_year > current_year Then
            errorProvider.SetError(birth_year_txt, "Invalid year. Enter a valid year.")
            Return False
        End If

        ' Validate leap year for birth year
        If Not DateTime.IsLeapYear(birth_year) Then
            errorProvider.SetError(birth_year_txt, "Not a leap year. Enter a valid leap year.")
            Return False
        End If

        ' Clear any existing error messages
        errorProvider.SetError(birth_day_txt, "")
        errorProvider.SetError(birth_month_txt, "")
        errorProvider.SetError(birth_year_txt, "")
        Return True
    End Function

    Private Sub clear_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clear_btn.Click
        ' Clear all input and output textboxes
        birth_day_txt.Text = ""
        birth_month_txt.Text = ""
        birth_year_txt.Text = ""
        age_day_txt.Text = ""
        age_month_txt.Text = ""
        age_year_txt.Text = ""

        ' Clear error providers
        errorProvider.SetError(birth_day_txt, "")
        errorProvider.SetError(birth_month_txt, "")
        errorProvider.SetError(birth_year_txt, "")
    End Sub
End Class