Imports Excel = Microsoft.Office.Interop.Excel
Public Class MathQuiz
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub btnShowAnswers_Click(sender As Object, e As EventArgs) Handles btnShowAnswers.Click
        txtAnswer1.Text = "9"
        txtAnswer2.Text = "6"
        txtAnswer3.Text = "11"
        txtAnswer4.Text = "5"
        txtAnswer5.Text = "144"
        lblScore.Text = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnswer1.Text = String.Empty
        txtAnswer2.Text = String.Empty
        txtAnswer3.Text = String.Empty
        txtAnswer4.Text = String.Empty
        txtAnswer5.Text = String.Empty
        lblScore.Text = String.Empty
    End Sub

    Private Sub btnCheckAnswers_Click(sender As Object, e As EventArgs) Handles btnCheckAnswers.Click
        Dim J As Integer
        J = 0
        If txtAnswer1.Text = "9" Then
            J += 1
        End If
        If txtAnswer2.Text = "6" Then
            J += 1
        End If
        If txtAnswer3.Text = "11" Then
            J += 1
        End If
        If txtAnswer4.Text = "5" Then
            J += 1
        End If
        If txtAnswer5.Text = "144" Then
            J += 1
        End If
        lblScore.Text = CStr(J) + "/5"
    End Sub
End Class