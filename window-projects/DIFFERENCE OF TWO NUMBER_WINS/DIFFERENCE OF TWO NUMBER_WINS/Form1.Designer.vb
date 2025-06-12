<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result_txt
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIFFERENCE OF TWO NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter First Number"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Button1.Location = New System.Drawing.Point(112, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.first_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(112, 144)
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(300, 48)
        Me.first_no_txt.TabIndex = 5
        Me.first_no_txt.Text = " "
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(112, 253)
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(300, 48)
        Me.second_no_txt.TabIndex = 6
        Me.second_no_txt.Text = " "
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(204, 461)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 48)
        Me.TextBox3.TabIndex = 7
        '
        'Result_txt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 533)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.second_no_txt)
        Me.Controls.Add(Me.first_no_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Result_txt"
        Me.Text = "DIFFERENCE OF TWO NUMBER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

    Private Sub Result_txt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
