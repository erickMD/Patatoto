Public Class agentmainform

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel)
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        ChildFormAdd.Show()
        ChildFormAdd.TabControl1.SelectTab(ChildFormAdd.TabPage1)
        Me.Hide()
        childID_autogen()
    End Sub

    Private Sub btnfill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfill.Click
        Adoption.Show()
        Me.Hide()

    End Sub
End Class