﻿Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnScience_Click(sender As Object, e As EventArgs) Handles btnScience.Click

    End Sub

    Private Sub btnMath_Click(sender As Object, e As EventArgs) Handles btnMath.Click
        Me.Hide()
        MathQuiz.Show()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim history As New History
        Me.Hide()
        history.Show()
    End Sub
End Class
