<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agentmainform
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
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(20, 52)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(154, 35)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add child to Database"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnfill
        '
        Me.btnfill.Location = New System.Drawing.Point(239, 52)
        Me.btnfill.Name = "btnfill"
        Me.btnfill.Size = New System.Drawing.Size(154, 35)
        Me.btnfill.TabIndex = 2
        Me.btnfill.Text = "Fill in adoption form"
        Me.btnfill.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(716, 196)
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
        'officialfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnfill)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "officialfrom"
        Me.Text = "officialfrom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnfill As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
