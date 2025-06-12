<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.current_year_txt = New System.Windows.Forms.TextBox()
        Me.current_month_txt = New System.Windows.Forms.TextBox()
        Me.current_day_txt = New System.Windows.Forms.TextBox()
        Me.year = New System.Windows.Forms.Label()
        Me.month = New System.Windows.Forms.Label()
        Me.current = New System.Windows.Forms.Label()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.birth_year_txt = New System.Windows.Forms.TextBox()
        Me.birth_month_txt = New System.Windows.Forms.TextBox()
        Me.birth_day_txt = New System.Windows.Forms.TextBox()
        Me.y = New System.Windows.Forms.Label()
        Me.m = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.age_year_txt = New System.Windows.Forms.TextBox()
        Me.age_month_txt = New System.Windows.Forms.TextBox()
        Me.age_day_txt = New System.Windows.Forms.TextBox()
        Me.ar = New System.Windows.Forms.Label()
        Me.mon = New System.Windows.Forms.Label()
        Me.ag = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGE CALCULATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.current_year_txt)
        Me.GroupBox1.Controls.Add(Me.current_month_txt)
        Me.GroupBox1.Controls.Add(Me.current_day_txt)
        Me.GroupBox1.Controls.Add(Me.year)
        Me.GroupBox1.Controls.Add(Me.month)
        Me.GroupBox1.Controls.Add(Me.current)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Today's Date"
        '
        'current_year_txt
        '
        Me.current_year_txt.BackColor = System.Drawing.Color.White
        Me.current_year_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.current_year_txt.Enabled = False
        Me.current_year_txt.Location = New System.Drawing.Point(274, 56)
        Me.current_year_txt.Multiline = True
        Me.current_year_txt.Name = "current_year_txt"
        Me.current_year_txt.Size = New System.Drawing.Size(71, 35)
        Me.current_year_txt.TabIndex = 14
        Me.current_year_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'current_month_txt
        '
        Me.current_month_txt.BackColor = System.Drawing.Color.White
        Me.current_month_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.current_month_txt.Enabled = False
        Me.current_month_txt.Location = New System.Drawing.Point(138, 56)
        Me.current_month_txt.Multiline = True
        Me.current_month_txt.Name = "current_month_txt"
        Me.current_month_txt.Size = New System.Drawing.Size(77, 35)
        Me.current_month_txt.TabIndex = 12
        Me.current_month_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'current_day_txt
        '
        Me.current_day_txt.BackColor = System.Drawing.Color.White
        Me.current_day_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.current_day_txt.Enabled = False
        Me.current_day_txt.Location = New System.Drawing.Point(12, 56)
        Me.current_day_txt.Multiline = True
        Me.current_day_txt.Name = "current_day_txt"
        Me.current_day_txt.Size = New System.Drawing.Size(65, 35)
        Me.current_day_txt.TabIndex = 6
        Me.current_day_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.year.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.year.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(280, 21)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(65, 27)
        Me.year.TabIndex = 10
        Me.year.Text = "Year"
        '
        'month
        '
        Me.month.AutoSize = True
        Me.month.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.month.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.month.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month.Location = New System.Drawing.Point(133, 26)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(88, 27)
        Me.month.TabIndex = 8
        Me.month.Text = "Month"
        '
        'current
        '
        Me.current.AutoSize = True
        Me.current.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.current.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.current.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current.Location = New System.Drawing.Point(20, 21)
        Me.current.Name = "current"
        Me.current.Size = New System.Drawing.Size(57, 27)
        Me.current.TabIndex = 6
        Me.current.Text = "Day"
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.Color.DarkGray
        Me.calculate_btn.FlatAppearance.BorderSize = 0
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.Color.Black
        Me.calculate_btn.Location = New System.Drawing.Point(67, 305)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(262, 40)
        Me.calculate_btn.TabIndex = 3
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.DarkRed
        Me.clear_btn.FlatAppearance.BorderSize = 0
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(332, 424)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(79, 41)
        Me.clear_btn.TabIndex = 5
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.birth_year_txt)
        Me.GroupBox2.Controls.Add(Me.birth_month_txt)
        Me.GroupBox2.Controls.Add(Me.birth_day_txt)
        Me.GroupBox2.Controls.Add(Me.y)
        Me.GroupBox2.Controls.Add(Me.m)
        Me.GroupBox2.Controls.Add(Me.b)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 97)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Birth"
        '
        'birth_year_txt
        '
        Me.birth_year_txt.BackColor = System.Drawing.Color.White
        Me.birth_year_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birth_year_txt.Location = New System.Drawing.Point(274, 56)
        Me.birth_year_txt.Multiline = True
        Me.birth_year_txt.Name = "birth_year_txt"
        Me.birth_year_txt.Size = New System.Drawing.Size(71, 35)
        Me.birth_year_txt.TabIndex = 14
        Me.birth_year_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'birth_month_txt
        '
        Me.birth_month_txt.BackColor = System.Drawing.Color.White
        Me.birth_month_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birth_month_txt.Location = New System.Drawing.Point(138, 56)
        Me.birth_month_txt.Multiline = True
        Me.birth_month_txt.Name = "birth_month_txt"
        Me.birth_month_txt.Size = New System.Drawing.Size(77, 35)
        Me.birth_month_txt.TabIndex = 12
        Me.birth_month_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'birth_day_txt
        '
        Me.birth_day_txt.BackColor = System.Drawing.Color.White
        Me.birth_day_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birth_day_txt.Location = New System.Drawing.Point(12, 56)
        Me.birth_day_txt.Multiline = True
        Me.birth_day_txt.Name = "birth_day_txt"
        Me.birth_day_txt.Size = New System.Drawing.Size(65, 35)
        Me.birth_day_txt.TabIndex = 6
        Me.birth_day_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.y.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.y.Location = New System.Drawing.Point(280, 21)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(65, 27)
        Me.y.TabIndex = 10
        Me.y.Text = "Year"
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.m.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.m.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.Location = New System.Drawing.Point(133, 21)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(88, 27)
        Me.m.TabIndex = 8
        Me.m.Text = "Month"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(20, 21)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(57, 27)
        Me.b.TabIndex = 6
        Me.b.Text = "Day"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.age_year_txt)
        Me.GroupBox3.Controls.Add(Me.age_month_txt)
        Me.GroupBox3.Controls.Add(Me.age_day_txt)
        Me.GroupBox3.Controls.Add(Me.ar)
        Me.GroupBox3.Controls.Add(Me.mon)
        Me.GroupBox3.Controls.Add(Me.ag)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 368)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 97)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Age"
        '
        'age_year_txt
        '
        Me.age_year_txt.BackColor = System.Drawing.Color.White
        Me.age_year_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.age_year_txt.Enabled = False
        Me.age_year_txt.Location = New System.Drawing.Point(199, 56)
        Me.age_year_txt.Multiline = True
        Me.age_year_txt.Name = "age_year_txt"
        Me.age_year_txt.Size = New System.Drawing.Size(67, 35)
        Me.age_year_txt.TabIndex = 14
        Me.age_year_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'age_month_txt
        '
        Me.age_month_txt.BackColor = System.Drawing.Color.White
        Me.age_month_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.age_month_txt.Enabled = False
        Me.age_month_txt.Location = New System.Drawing.Point(98, 56)
        Me.age_month_txt.Multiline = True
        Me.age_month_txt.Name = "age_month_txt"
        Me.age_month_txt.Size = New System.Drawing.Size(69, 35)
        Me.age_month_txt.TabIndex = 12
        Me.age_month_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'age_day_txt
        '
        Me.age_day_txt.BackColor = System.Drawing.Color.White
        Me.age_day_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.age_day_txt.Enabled = False
        Me.age_day_txt.Location = New System.Drawing.Point(6, 56)
        Me.age_day_txt.Multiline = True
        Me.age_day_txt.Name = "age_day_txt"
        Me.age_day_txt.Size = New System.Drawing.Size(71, 35)
        Me.age_day_txt.TabIndex = 6
        Me.age_day_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ar
        '
        Me.ar.AutoSize = True
        Me.ar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ar.Location = New System.Drawing.Point(201, 21)
        Me.ar.Name = "ar"
        Me.ar.Size = New System.Drawing.Size(65, 27)
        Me.ar.TabIndex = 10
        Me.ar.Text = "Year"
        '
        'mon
        '
        Me.mon.AutoSize = True
        Me.mon.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.mon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mon.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mon.Location = New System.Drawing.Point(110, 21)
        Me.mon.Name = "mon"
        Me.mon.Size = New System.Drawing.Size(88, 27)
        Me.mon.TabIndex = 8
        Me.mon.Text = "Month"
        '
        'ag
        '
        Me.ag.AutoSize = True
        Me.ag.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ag.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag.Location = New System.Drawing.Point(20, 21)
        Me.ag.Name = "ag"
        Me.ag.Size = New System.Drawing.Size(57, 27)
        Me.ag.TabIndex = 6
        Me.ag.Text = "Day"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(443, 518)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SOFTWARE FOR AGE CALCULATOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents year As System.Windows.Forms.Label
    Friend WithEvents month As System.Windows.Forms.Label
    Friend WithEvents current As System.Windows.Forms.Label
    Friend WithEvents current_year_txt As System.Windows.Forms.TextBox
    Friend WithEvents current_month_txt As System.Windows.Forms.TextBox
    Friend WithEvents current_day_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents birth_year_txt As System.Windows.Forms.TextBox
    Friend WithEvents birth_month_txt As System.Windows.Forms.TextBox
    Friend WithEvents birth_day_txt As System.Windows.Forms.TextBox
    Friend WithEvents y As System.Windows.Forms.Label
    Friend WithEvents m As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents age_year_txt As System.Windows.Forms.TextBox
    Friend WithEvents age_month_txt As System.Windows.Forms.TextBox
    Friend WithEvents age_day_txt As System.Windows.Forms.TextBox
    Friend WithEvents ar As System.Windows.Forms.Label
    Friend WithEvents mon As System.Windows.Forms.Label
    Friend WithEvents ag As System.Windows.Forms.Label

End Class
