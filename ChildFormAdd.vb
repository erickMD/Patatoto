Imports System.Data.SqlClient
Public Class ChildFormAdd
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim sqlconn As New SqlConnection
    Dim reader As SqlDataReader
    Dim server = "Data source= ERICK;Initial Catalog = Patatoto;Integrated Security= SSPI"

        

   
    Public Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        If txtchildid.Text = " " Then
            MsgBox("Please ensure that you have input a valid child id ")
            Exit Sub
        End If

        Dim CountTab As Integer = 1
        Dim MaxTab As Integer
        If Not CountTab = MaxTab Then

            TabControl1.SelectTab(CountTab)

            CountTab += 1
        End If




    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CountTab As Integer = 2
        Dim MaxTab As Integer
        If Not CountTab = MaxTab Then

            TabControl1.SelectTab(CountTab)

            CountTab += 1

        End If

    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CountTab As Integer = 2
        Dim MaxTab As Integer
        If Not CountTab = MaxTab Then
            TabControl1.SelectTab(CountTab)

            CountTab -= 1

        End If
        TabControl1.SelectTab(CountTab)
    End Sub

    Public Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged

        If RadioButton6.Checked = True Then
            alergyspec.Enabled = False
            alergyspec.ReadOnly = True
            alergyspec.Text = "None"
        End If
    End Sub

    Public Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alergyspec.TextChanged

    End Sub

    Public Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        alergyspec.Clear()
        If RadioButton5.Checked = True Then
            alergyspec.Enabled = True
            alergyspec.ReadOnly = False
        End If
    End Sub

    Public Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        disabilityspec.Clear()
        If RadioButton7.Checked = True Then
            disabilityspec.Enabled = True
            disabilityspec.ReadOnly = False

        End If
    End Sub

    Public Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            disabilityspec.Enabled = False
            disabilityspec.Text = "None"
            disabilityspec.ReadOnly = True
        End If

    End Sub

    Public Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = Nothing
            End If
        Next


        For Each y In TabPage2.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
            End If
        Next

        If RadioButton3.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox1.IsAccessible = True
            gbcitizenship.Enabled = True
            txtcitizenship.Enabled = True
            txttribe.Enabled = True
            txtparentage.Text = "Known"
        End If
    End Sub

    Public Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox1.Enabled = False
            GroupBox1.IsAccessible = False
            gbcitizenship.Enabled = False
            txtcitizenship.Enabled = False
            txttribe.Enabled = False
            txtparentage.Text = "Unknown"
            Dim x, y As Control
            For Each x In GroupBox1.Controls
                If TypeOf x Is TextBox Then
                    x.Text = "N/A"
                End If
            Next

            For Each y In TabPage2.Controls
                If TypeOf y Is TextBox Then
                    y.Text = "N/A"
                End If
            Next


        End If
    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim CountTab As Integer = 3
        'Dim MaxTab As Integer
        'If Not CountTab = MaxTab Then
        '    TabControl1.SelectTab(CountTab)

        '    CountTab -= 1

        'End If
        'TabControl1.SelectTab(CountTab)
    End Sub

    Public Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        txtcitizenship.Clear()
        country.Clear()
        If RadioButton14.Checked = True Then
            txtcitizenship.Enabled = True
            txtcitizenship.ReadOnly = False
            country.Enabled = True
        End If
    End Sub

    Public Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged

        If RadioButton13.Checked = True Then
            txtcitizenship.Enabled = False
            txtcitizenship.ReadOnly = True
            country.Enabled = False
        End If
        txtcitizenship.Text = "Kenyan"
        country.Text = "Kenya"
    End Sub

    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If additionalnotes.Text = Nothing Then
            additionalnotes.Text = "N/A"
        End If
        Try
            sqlconn.ConnectionString = server
            sqlconn.Open()
            sql = "insert into children values ('" & txtchildid.Text & _
                "','" & txtfirst.Text & _
                "','" & txtmid.Text & _
                "','" & txtlast.Text & _
                "','" & DateTimePicker1.Text & _
                "','" & txtage.Text & _
                "','" & cmbxgender.Text & _
                "','" & txtparentage.Text & _
                "','" & momfirst.Text & _
                "','" & momlast.Text & _
                "','" & dadfirst.Text & _
                "','" & dadlast.Text & _
                "','" & tell.Text & _
                "','" & country.Text & _
                "','" & postadd.Text & _
                "','" & postcode.Text & _
                "','" & town.Text & _
                "','" & txtcitizenship.Text & _
                "','" & txttribe.Text & _
                "','" & alergyspec.Text & _
                "','" & disabilityspec.Text & _
                "','" & abuserec.Text & _
                "','" & crimerec.Text & _
                "','" & additionalnotes.Text & "','Pre-Adoption')"
            cmd = New SqlCommand(sql, sqlconn)
            cmd.ExecuteNonQuery()
            MsgBox("Child Details successfuly added to database", MsgBoxStyle.Information, "DATABASE UPDATED")


            TabControl1.SelectTab(TabPage1) 'this ensures that focus is returned to the first tab supposing one wants to add anther record

            'Me.Hide()
            'officialfrom.Show()

            Dim x, y, z As Control
            For Each x In GroupBox1.Controls
                If TypeOf x Is TextBox Then
                    x.Text = Nothing
                End If
            Next



            For Each x In TabPage1.Controls
                If TypeOf x Is TextBox Then
                    x.Text = Nothing
                End If
            Next

            For Each y In TabPage2.Controls
                If TypeOf y Is TextBox Then
                    y.Text = Nothing
                End If
            Next

            For Each z In TabPage3.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next
            childID_autogen() 'calls the id auto gen sub so as to generate id incase one wants to add another record

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try

       
       
    End Sub
    Private Sub autochild_id()
       
    End Sub

    Public Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchildid.TextChanged



    End Sub

    Public Sub txtfirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfirst.TextChanged

    End Sub

    Public Sub txtmid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmid.TextChanged

    End Sub

    Public Sub txtlast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlast.TextChanged

    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged

    End Sub

    Public Sub cmbxage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxgender.SelectedIndexChanged

    End Sub

    Public Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles momfirst.TextChanged

    End Sub

    Public Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dadfirst.TextChanged

    End Sub

    Public Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles momlast.TextChanged

    End Sub

    Public Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dadlast.TextChanged

    End Sub

    Public Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tell.TextChanged
        'Dim intValue As Integer
        'If Not Integer.TryParse(tell.Text, intValue) OrElse intValue < 0 OrElse intValue > 10 Then
        '    MessageBox.Show("Please Enter a valid number ")
        ' End If
    End Sub

    Public Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles country.TextChanged

    End Sub

    Public Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postadd.TextChanged

    End Sub

    Public Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles postcode.TextChanged

    End Sub

    Public Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles town.TextChanged

    End Sub

    Public Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttribe.TextChanged

    End Sub

    Public Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcitizenship.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ChildFormAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        childID_autogen()

    End Sub

    Private Sub btnattach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnattach.Click

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbcitizenship.Enter

    End Sub

    Private Sub gbdisability_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbdisability.Enter

    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        abuserec.Clear()
        If RadioButton9.Checked = True Then
            GroupBox2.Enabled = True
            GroupBox2.IsAccessible = True

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton9.Checked = False Then
            GroupBox2.Enabled = False
            GroupBox2.IsAccessible = False

        End If
        abuserec.Text = "No Record"
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        crimerec.Clear()
        If RadioButton11.Checked = True Then
            GroupBox3.Enabled = True
            GroupBox3.IsAccessible = True

        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton11.Checked = False Then
            GroupBox3.Enabled = False
            GroupBox3.IsAccessible = False

        End If
        crimerec.Text = "No Record"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        yearob.Text = DateTimePicker1.Value.Year.ToString
        txtage.Text = Date.Today.Year.ToString - yearob.Text
        
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNoCancel)
        If result = DialogResult.No Or result = DialogResult.Cancel Then
            Exit Sub
        Else
            Me.Hide()
            AdminHome.Show()
        End If
    End Sub
End Class