Public Class login

    Private Sub btnrudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrudi.Click
        Me.Hide()
        MAinform.Show()
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click

        connect()

    End Sub

    Private Sub Agentform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtpass_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus
        Dim tt As ToolTip = New ToolTip

        tt.InitialDelay = 0
        tt.IsBalloon = True
        tt.Show(String.Empty, txtpass)
        tt.Show("Password Is CASE sensitive", txtpass, 0)


    End Sub
End Class