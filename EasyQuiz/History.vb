Public Class History
    Dim ans1, ans2, ans3, ans4, ans5 As String

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim mainForm As New MainForm
        Me.Hide()
        mainForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnChkAns_Click(sender As Object, e As EventArgs) Handles btnChkAns.Click
        ans1 = "Reconstruction"
        ans2 = "False"
        ans3 = "Madam C.J. Walker"
        ans4 = "Braunau am Inn, Austria"
        ans5 = "Russia"
        Dim score As Integer
        score = 0
        If txtAns1.Text = ans1 Then
            score += 1
        End If
        If txtAns2.Text = ans2 Then
            score += 1
        End If
        If txtAns3.Text = ans3 Then
            score += 1
        End If
        If txtAns4.Text = ans4 Then
            score += 1
        End If
        If txtAns5.Text = ans5 Then
            score += 1
        End If
        txtScore.Text = CStr(score) + "/5"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAns1.Clear()
        txtAns2.Clear()
        txtAns3.Clear()
        txtAns4.Clear()
        txtAns5.Clear()
        txtScore.Clear()
    End Sub

    Private Sub btnShowAns_Click(sender As Object, e As EventArgs) Handles btnShowAns.Click
        txtAns1.Text = ans1
        txtAns2.Text = ans2
        txtAns3.Text = ans3
        txtAns4.Text = ans4
        txtAns5.Text = ans5
    End Sub
End Class