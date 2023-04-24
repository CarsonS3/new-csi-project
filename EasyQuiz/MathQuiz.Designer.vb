<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathQuiz
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnswer1 = New System.Windows.Forms.TextBox()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer3 = New System.Windows.Forms.TextBox()
        Me.txtAnswer4 = New System.Windows.Forms.TextBox()
        Me.txtAnswer5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCheckAnswers = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnShowAnswers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4 + 5 ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "3 X 2 ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "24 - 13 ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "15 / 5 ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "12 X 12 ="
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Location = New System.Drawing.Point(254, 36)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer1.TabIndex = 5
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Location = New System.Drawing.Point(254, 104)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer2.TabIndex = 6
        '
        'txtAnswer3
        '
        Me.txtAnswer3.Location = New System.Drawing.Point(254, 169)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer3.TabIndex = 7
        '
        'txtAnswer4
        '
        Me.txtAnswer4.Location = New System.Drawing.Point(254, 232)
        Me.txtAnswer4.Name = "txtAnswer4"
        Me.txtAnswer4.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer4.TabIndex = 8
        '
        'txtAnswer5
        '
        Me.txtAnswer5.Location = New System.Drawing.Point(254, 297)
        Me.txtAnswer5.Name = "txtAnswer5"
        Me.txtAnswer5.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Your Score: "
        '
        'btnCheckAnswers
        '
        Me.btnCheckAnswers.Location = New System.Drawing.Point(594, 15)
        Me.btnCheckAnswers.Name = "btnCheckAnswers"
        Me.btnCheckAnswers.Size = New System.Drawing.Size(165, 74)
        Me.btnCheckAnswers.TabIndex = 11
        Me.btnCheckAnswers.Text = "Check Answers"
        Me.btnCheckAnswers.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(594, 104)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(165, 76)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Answers"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(594, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 67)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(594, 366)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(165, 46)
        Me.btnMainMenu.TabIndex = 14
        Me.btnMainMenu.Text = "Return to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(280, 368)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 32)
        Me.lblScore.TabIndex = 15
        '
        'btnShowAnswers
        '
        Me.btnShowAnswers.Location = New System.Drawing.Point(594, 200)
        Me.btnShowAnswers.Name = "btnShowAnswers"
        Me.btnShowAnswers.Size = New System.Drawing.Size(165, 67)
        Me.btnShowAnswers.TabIndex = 16
        Me.btnShowAnswers.Text = "Show Answers"
        Me.btnShowAnswers.UseVisualStyleBackColor = True
        '
        'MathQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowAnswers)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckAnswers)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAnswer5)
        Me.Controls.Add(Me.txtAnswer4)
        Me.Controls.Add(Me.txtAnswer3)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.txtAnswer1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MathQuiz"
        Me.Text = "Math Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnswer1 As TextBox
    Friend WithEvents txtAnswer2 As TextBox
    Friend WithEvents txtAnswer3 As TextBox
    Friend WithEvents txtAnswer4 As TextBox
    Friend WithEvents txtAnswer5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCheckAnswers As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents btnShowAnswers As Button
End Class
