<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentsLogin
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
        Me.btngo = New System.Windows.Forms.Button()
        Me.btnrudi = New System.Windows.Forms.Button()
        Me.ppword = New System.Windows.Forms.TextBox()
        Me.puser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.unamecheck = New System.Windows.Forms.TextBox()
        Me.pwordcheck = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btngo
        '
        Me.btngo.Location = New System.Drawing.Point(405, 205)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(101, 45)
        Me.btngo.TabIndex = 13
        Me.btngo.Text = "Continue"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'btnrudi
        '
        Me.btnrudi.Location = New System.Drawing.Point(7, 205)
        Me.btnrudi.Name = "btnrudi"
        Me.btnrudi.Size = New System.Drawing.Size(101, 45)
        Me.btnrudi.TabIndex = 12
        Me.btnrudi.Text = "Back"
        Me.btnrudi.UseVisualStyleBackColor = True
        '
        'ppword
        '
        Me.ppword.Location = New System.Drawing.Point(146, 130)
        Me.ppword.Name = "ppword"
        Me.ppword.Size = New System.Drawing.Size(281, 20)
        Me.ppword.TabIndex = 11
        '
        'puser
        '
        Me.puser.Location = New System.Drawing.Point(146, 65)
        Me.puser.Name = "puser"
        Me.puser.Size = New System.Drawing.Size(281, 20)
        Me.puser.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Please confirm that you are registered with Pata Toto adoption Agency as a parent" & _
    ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(146, 313)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(281, 20)
        Me.status.TabIndex = 14
        Me.status.Visible = False
        '
        'unamecheck
        '
        Me.unamecheck.Location = New System.Drawing.Point(146, 260)
        Me.unamecheck.Name = "unamecheck"
        Me.unamecheck.Size = New System.Drawing.Size(281, 20)
        Me.unamecheck.TabIndex = 15
        Me.unamecheck.Visible = False
        '
        'pwordcheck
        '
        Me.pwordcheck.Location = New System.Drawing.Point(146, 286)
        Me.pwordcheck.Name = "pwordcheck"
        Me.pwordcheck.Size = New System.Drawing.Size(281, 20)
        Me.pwordcheck.TabIndex = 16
        Me.pwordcheck.Visible = False
        '
        'ParentsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 344)
        Me.Controls.Add(Me.pwordcheck)
        Me.Controls.Add(Me.unamecheck)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.btnrudi)
        Me.Controls.Add(Me.ppword)
        Me.Controls.Add(Me.puser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ParentsLogin"
        Me.Text = "ParentsLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents btnrudi As System.Windows.Forms.Button
    Friend WithEvents ppword As System.Windows.Forms.TextBox
    Friend WithEvents puser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents unamecheck As System.Windows.Forms.TextBox
    Friend WithEvents pwordcheck As System.Windows.Forms.TextBox
End Class
