Imports System.Diagnostics
Public Class Form3
    Private stopwatch As Stopwatch
    Private stopwatchRunning As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.LightBlue
        Button2.BackColor = Color.LightCoral
        Button2.ForeColor = Color.Black
        stopwatch = New Stopwatch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatchDisplay()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newSubmission As New Submission_1 With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGithubLink.Text,
            .StopwatchTime = txtStopwatchTime.Text
        }
        SubmissionRepositry.AddSubmission(newSubmission)
        MessageBox.Show("Submission Done !")
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
End Class