<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        Button1 = New Button()
        txtStopwatchTime = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(365, 146)
        txtName.Name = "txtName"
        txtName.Size = New Size(307, 27)
        txtName.TabIndex = 9
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(365, 238)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(307, 27)
        txtEmail.TabIndex = 10
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(365, 319)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(307, 27)
        txtPhoneNumber.TabIndex = 11
        txtPhoneNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(365, 411)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(307, 27)
        txtGithubLink.TabIndex = 12
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.LightBlue
        Button1.Location = New Point(60, 504)
        Button1.Name = "Button1"
        Button1.Size = New Size(295, 40)
        Button1.TabIndex = 14
        Button1.Text = "TOGGLE STOPWATCH"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(447, 511)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(177, 27)
        txtStopwatchTime.TabIndex = 15
        txtStopwatchTime.Text = "00:00:00"
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightCoral
        Button2.Location = New Point(87, 581)
        Button2.Name = "Button2"
        Button2.Size = New Size(508, 40)
        Button2.TabIndex = 16
        Button2.Text = "SUBMIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 17
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 18
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 326)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 19
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 411)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 20
        Label4.Text = "Github_Link"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(228, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(281, 20)
        Label5.TabIndex = 21
        Label5.Text = "Surith , Slidely Task 2 - Create Submission"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 660)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(txtStopwatchTime)
        Controls.Add(Button1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
