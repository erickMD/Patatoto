Public Class AdoptionForm


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Details_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'DateTimePicker1.Enabled = False
        'TextBox2.ReadOnly = True
        'TextBox4.ReadOnly = True
        'TextBox7.ReadOnly = True
        'TextBox8.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

    End Sub



    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel)
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Hide()
            AdminHome.Show()
        End If
    End Sub
End Class