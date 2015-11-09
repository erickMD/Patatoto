<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Otherfrom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enquiery = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enquieryid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please state the nature of your enquiries:"
        '
        'enquiery
        '
        Me.enquiery.Location = New System.Drawing.Point(25, 184)
        Me.enquiery.Multiline = True
        Me.enquiery.Name = "enquiery"
        Me.enquiery.Size = New System.Drawing.Size(706, 212)
        Me.enquiery.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(942, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enquiry ID"
        '
        'enquieryid
        '
        Me.enquieryid.Enabled = False
        Me.enquieryid.Location = New System.Drawing.Point(91, 12)
        Me.enquieryid.Name = "enquieryid"
        Me.enquieryid.ReadOnly = True
        Me.enquieryid.Size = New System.Drawing.Size(100, 20)
        Me.enquieryid.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Name"
        '
        'name
        '
        Me.name.Location = New System.Drawing.Point(91, 47)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(276, 20)
        Me.name.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email Adress"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(91, 88)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(276, 20)
        Me.email.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 47)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Otherfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 528)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.enquieryid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.enquiery)
        Me.Controls.Add(Me.Label1)
        'Me.Name = "Otherfrom"
        Me.Text = "Otherfrom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents enquiery As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents enquieryid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
