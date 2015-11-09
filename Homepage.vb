Public Class Homepage

    Private Sub btncontinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontinue.Click

        MAinform.Show()
        Me.Hide()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel)
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Close()
        End If

    End Sub
End Class
