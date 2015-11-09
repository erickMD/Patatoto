Imports System.Data.SqlClient
Public Class Otherfrom
    Dim sqlconn As New SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim server = "Data source= RM5059-THINK\SQLEXPRESS;Initial Catalog = Adoption;Integrated Security= SSPI"
    Dim sql As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadEnquieries()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enquieryid.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MAinform.Show()

    End Sub

    Private Sub Otherfrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eNQUIERYID_autogen()
    End Sub
End Class