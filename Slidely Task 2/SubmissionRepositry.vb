Public Class Submission_1
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String

End Class

Public Class SubmissionRepositry
    Private Shared submissions As New List(Of Submission_1)
    Public Shared Sub AddSubmission(submission_1 As Submission_1)
        submissions.Add(submission_1)
    End Sub

    Public Shared Function GetSubmissions() As List(Of Submission_1)
        Return submissions
    End Function
End Class
