<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnfill = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enquieriescount = New System.Windows.Forms.TextBox()
        Me.enquieriescount1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.regrequestcount1 = New System.Windows.Forms.Label()
        Me.regrequestcount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(22, 47)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(154, 54)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add child to Database"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnfill
        '
        Me.btnfill.Location = New System.Drawing.Point(241, 47)
        Me.btnfill.Name = "btnfill"
        Me.btnfill.Size = New System.Drawing.Size(154, 54)
        Me.btnfill.TabIndex = 2
        Me.btnfill.Text = "Fill in adoption form"
        Me.btnfill.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.Location = New System.Drawing.Point(716, 218)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(154, 35)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "What action do you wish to perform?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 54)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Enquieries"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(45, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "New Enquierie(s)"
        '
        'enquieriescount
        '
        Me.enquieriescount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.enquieriescount.Location = New System.Drawing.Point(19, 239)
        Me.enquieriescount.Name = "enquieriescount"
        Me.enquieriescount.Size = New System.Drawing.Size(20, 13)
        Me.enquieriescount.TabIndex = 7
        '
        'enquieriescount1
        '
        Me.enquieriescount1.AutoSize = True
        Me.enquieriescount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enquieriescount1.ForeColor = System.Drawing.Color.Red
        Me.enquieriescount1.Location = New System.Drawing.Point(482, 47)
        Me.enquieriescount1.Name = "enquieriescount1"
        Me.enquieriescount1.Size = New System.Drawing.Size(13, 13)
        Me.enquieriescount1.TabIndex = 8
        Me.enquieriescount1.Text = "0"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(703, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 54)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Activate/Deactivate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Accounts"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'regrequestcount1
        '
        Me.regrequestcount1.AutoSize = True
        Me.regrequestcount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regrequestcount1.ForeColor = System.Drawing.Color.Red
        Me.regrequestcount1.Location = New System.Drawing.Point(700, 47)
        Me.regrequestcount1.Name = "regrequestcount1"
        Me.regrequestcount1.Size = New System.Drawing.Size(13, 13)
        Me.regrequestcount1.TabIndex = 10
        Me.regrequestcount1.Text = "0"
        '
        'regrequestcount
        '
        Me.regrequestcount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regrequestcount.Location = New System.Drawing.Point(163, 239)
        Me.regrequestcount.Name = "regrequestcount"
        Me.regrequestcount.Size = New System.Drawing.Size(20, 13)
        Me.regrequestcount.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(189, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Registraton Request(s)"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 261)
        Me.Controls.Add(Me.regrequestcount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.regrequestcount1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.enquieriescount1)
        Me.Controls.Add(Me.enquieriescount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnfill)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnfill As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents enquieriescount As System.Windows.Forms.TextBox
    Friend WithEvents enquieriescount1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents regrequestcount1 As System.Windows.Forms.Label
    Friend WithEvents regrequestcount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
