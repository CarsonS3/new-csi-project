Public Class Science
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Question6.Click

    End Sub

    Private Sub Science_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ans1.Clear()
        Ans2.Clear()
        Ans3.Clear()
        Ans4.Clear()
        Ans5.Clear()
        txtScore.Clear()
    End Sub

    Dim Ans100, Ans200, Ans300, Ans400, Ans500 As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mainForm As New MainForm
        Me.Hide()
        mainForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Ans100 = "Andromeda"
        Ans200 = "H20"
        Ans300 = "Mercury"
        Ans400 = "Venus"
        Ans500 = "Mitochondria"
        Dim score As Integer
        score = 0
        If Ans1.Text = Ans100 Then
            score += 1
        End If
        If Ans2.Text = Ans200 Then
            score += 1
        End If
        If Ans3.Text = Ans300 Then
            score += 1
        End If
        If Ans4.Text = Ans400 Then
            score += 1
        End If
        If Ans5.Text = Ans500 Then
            score += 1
        End If
        txtScore.Text = CStr(score) + "/5"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ans1.Text = Ans100
        Ans2.Text = Ans200
        Ans3.Text = Ans300
        Ans4.Text = Ans400
        Ans5.Text = Ans500
    End Sub
End Class