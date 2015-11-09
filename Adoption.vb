Public Class Adoption


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Details_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        DateTimePicker1.Enabled = False
        TextBox2.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click

    End Sub




End Class