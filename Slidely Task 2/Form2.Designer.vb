<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.ForeColor = SystemColors.GradientActiveCaption
        Button1.Location = New Point(38, 528)
        Button1.Name = "Button1"
        Button1.Size = New Size(284, 49)
        Button1.TabIndex = 1
        Button1.Text = "PREVIOUS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightCoral
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(370, 528)
        Button2.Name = "Button2"
        Button2.Size = New Size(294, 49)
        Button2.TabIndex = 2
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(357, 138)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.ScrollBars = ScrollBars.Vertical
        txtName.Size = New Size(307, 27)
        txtName.TabIndex = 8
        txtName.Text = "John Doe"
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(357, 215)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(307, 27)
        txtEmail.TabIndex = 9
        txtEmail.Text = "johndoe@gmail.com"
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(357, 296)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(307, 27)
        txtPhoneNumber.TabIndex = 10
        txtPhoneNumber.Text = "9876543210"
        txtPhoneNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(357, 376)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(307, 27)
        txtGithubLink.TabIndex = 11
        txtGithubLink.Text = "https://github.com/john_doe/my_slidely_task/"
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(357, 450)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(307, 27)
        txtStopwatchTime.TabIndex = 12
        txtStopwatchTime.Text = "00:01:19"
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 13
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(114, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 14
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(84, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 15
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 376)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 16
        Label4.Text = "Github_Link"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 453)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 17
        Label5.Text = "StopWatch Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(202, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(276, 20)
        Label6.TabIndex = 18
        Label6.Text = "Surith , Slidely Task 2 - View Submissions"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(703, 658)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Button2)
        Controls.Add(Button1)
        KeyPreview = True
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
