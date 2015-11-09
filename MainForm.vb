Imports System.Data.SqlClient

Public Class MAinform
    Dim sqlconn As New SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim server = "Data source= RM5059-THINK\SQLEXPRESS;Initial Catalog = Adoption;Integrated Security= SSPI"
    Dim sql As String
   

    Private Sub btnparents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnparents.Click

        Dim result = MsgBox("hello there future parent and welcome to Pata toto adoption agency.For reference we would like you to fill in a few forms. Before you fill in the folowing please make sure that you have contacted an agent formally in order to gain your authentication ID.click 'ok' to proceed and 'cancel' to exit", MsgBoxStyle.OkCancel, )

        If result = MsgBoxResult.Ok Then
            Dim result1 = MsgBox("Are you already registered with Pata toto as a Parent?", MsgBoxStyle.YesNo, )

            If result1 = MsgBoxResult.Yes Then
                ParentsLogin.Show()

                Me.Hide()
                Exit Sub
            Else
                If result1 = DialogResult.No Then
                    Parents.Show()


                End If



                If result = DialogResult.Cancel Then
                    Me.Show()

                End If
            End If



        End If


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel)
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Close()
        End If

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub btnagent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagent.Click
        AgentLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnother.Click
        Otherfrom.Show()
        Me.Hide()
    End Sub
End Class