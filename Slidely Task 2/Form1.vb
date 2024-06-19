Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        'to set the button colours 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.LightBlue
        Button2.BackColor = Color.LightCoral
        Button2.ForeColor = Color.Black

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New Form2()
        viewForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New Form3()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.H Then
            ShowShortcuts()
        End If
    End Sub
    Private Sub ShowShortcuts()
        Dim shortcuts As String =
                                  "Ctrl + V: View Submissions" & vbCrLf &
                                  "Ctrl + N: Create New Submission" & vbCrLf &
                                  "Ctrl + P: Previous Submission (in View Submissions)" & vbCrLf &
                                  "Ctrl + N: Next Submission (in View Submissions)" & vbCrLf &
                                  "Ctrl + S: Submit Form (in Create New Submission)" & vbCrLf &
                                  "Ctrl + T: Start/Stop Stopwatch (in Create New Submission)" & vbCrLf &
                                  "Ctrl + H: Show Keyboard Shortcuts"
        MessageBox.Show(shortcuts, "Keyboard Shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
