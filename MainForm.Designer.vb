<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAinform
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
        Me.components = New System.ComponentModel.Container()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnparents = New System.Windows.Forms.Button()
        Me.btnagent = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnother = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(20, 450)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(172, 39)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(646, 446)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(208, 42)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click the category under which you best fit"
        '
        'btnparents
        '
        Me.btnparents.Location = New System.Drawing.Point(47, 129)
        Me.btnparents.Name = "btnparents"
        Me.btnparents.Size = New System.Drawing.Size(145, 27)
        Me.btnparents.TabIndex = 3
        Me.btnparents.Text = "Parents"
        Me.ToolTip1.SetToolTip(Me.btnparents, "Click here if you are an interested parent")
        Me.btnparents.UseVisualStyleBackColor = True
        '
        'btnagent
        '
        Me.btnagent.Location = New System.Drawing.Point(693, 129)
        Me.btnagent.Name = "btnagent"
        Me.btnagent.Size = New System.Drawing.Size(145, 27)
        Me.btnagent.TabIndex = 7
        Me.btnagent.Text = "Agent/ Adminstrator"
        Me.btnagent.UseVisualStyleBackColor = True
        '
        'btnother
        '
        Me.btnother.Location = New System.Drawing.Point(321, 379)
        Me.btnother.Name = "btnother"
        Me.btnother.Size = New System.Drawing.Size(145, 27)
        Me.btnother.TabIndex = 8
        Me.btnother.Text = "Other"
        Me.btnother.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.projo.My.Resources.Resources.images1
        Me.PictureBox4.Location = New System.Drawing.Point(310, 146)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(175, 215)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.projo.My.Resources.Resources.sad_woman_filling_financial_documents_elderly_blonde_table_home_interior_48958835__1_
        Me.PictureBox3.Location = New System.Drawing.Point(693, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(182, 86)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projo.My.Resources.Resources.download1
        Me.PictureBox1.Location = New System.Drawing.Point(15, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 87)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MAinform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(878, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnother)
        Me.Controls.Add(Me.btnagent)
        Me.Controls.Add(Me.btnparents)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnback)
        Me.MaximizeBox = False
        Me.Name = "MAinform"
        Me.Text = "MAinform"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnparents As System.Windows.Forms.Button
    Friend WithEvents btnagent As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnother As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
End Class
