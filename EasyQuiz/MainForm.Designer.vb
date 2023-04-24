<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnScience = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnMath = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 84)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the quiz application, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "which quiz would you like to take?"
        '
        'btnScience
        '
        Me.btnScience.Location = New System.Drawing.Point(59, 312)
        Me.btnScience.Name = "btnScience"
        Me.btnScience.Size = New System.Drawing.Size(172, 86)
        Me.btnScience.TabIndex = 1
        Me.btnScience.Text = "Science"
        Me.btnScience.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(293, 312)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(172, 86)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnMath
        '
        Me.btnMath.Location = New System.Drawing.Point(539, 312)
        Me.btnMath.Name = "btnMath"
        Me.btnMath.Size = New System.Drawing.Size(172, 86)
        Me.btnMath.TabIndex = 3
        Me.btnMath.Text = "Math"
        Me.btnMath.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(341, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMath)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnScience)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Quiz Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnScience As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnMath As Button
    Friend WithEvents btnExit As Button
End Class
