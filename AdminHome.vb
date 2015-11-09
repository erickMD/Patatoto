Public Class AdminHome

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
        AdoptionForm.Show()
        Me.Hide()

    End Sub

    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegRequestCheck()
        EnquireCheck()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AuthorizeAccounts.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Enquieries.Show()

        Me.Hide()
    End Sub
End Class