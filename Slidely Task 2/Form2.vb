Public Class Form2
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission_1)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        submissions = SubmissionRepositry.GetSubmissions()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            ShowSubmission(currentIndex)
        End If

        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.LightBlue
        Button2.BackColor = Color.LightCoral
        Button2.ForeColor = Color.Black


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub ShowSubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.PhoneNumber
            txtGithubLink.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

End Class
Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String

End Class