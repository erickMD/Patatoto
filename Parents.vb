Public Class Parents



    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbyes.Checked = True Then
            rbmale.Enabled = True
            rbfemale.Enabled = True

        End If
    End Sub

    Private Sub rbno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbno.Checked = True Then
            rbmale.Enabled = True
            rbfemale.Enabled = True
        End If
    End Sub

    Private Sub rbmale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbmale.Checked = True Then
            GBmom.Enabled = False
            GBdad.Enabled = True
        End If
    End Sub

    Private Sub labelmum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbfemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbfemale.Checked = True Then
            GBmom.Enabled = True
            GBdad.Enabled = False
        End If
    End Sub

    Private Sub rbyes_CheckedChanged_1(sender As Object, e As EventArgs)
        'If rbyes.Checked = True Then
        '    Maritalstatus.Text = "Single"
        '    rbfemale.Checked = False
        '    rbmale.Checked = False
        '    GroupBox3.Enabled = True
        '    GroupBox3.IsAccessible = True

        'End If
    End Sub

    Private Sub rbno_CheckedChanged_1(sender As Object, e As EventArgs)
        'If rbno.Checked = True Then
        '    Maritalstatus.Text = "Married"
        '    gender.Text = Nothing
        '    GroupBox3.Enabled = False
        '    GroupBox3.IsAccessible = False
        '    Me.GBdad.Enabled = True
        '    Me.GBmom.Enabled = True
        '    MFName.Focus()
        '    'TabControl1.SelectedTab = TabPage1
        '    gender.Text = "Not Applicable"
        '    Dim z As Control
        '    For Each z In GBmom.Controls
        '        If TypeOf z Is TextBox Then
        '            z.Text = Nothing
        '        End If
        '    Next

        '    'Dim z As Control
        '    For Each z In GBdad.Controls
        '        If TypeOf z Is TextBox Then
        '            z.Text = Nothing
        '        End If
        '    Next


        'End If

        'If rbmale.Checked = True Then
        '    MTell.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'ElseIf rbfemale.Checked = True Then
        '    MAge.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'End If

    End Sub

    Private Sub rbmale_CheckedChanged_1(sender As Object, e As EventArgs)
        'Dim y As Control
        'For Each y In GBdad.Controls
        '    If TypeOf y Is TextBox Then
        '        y.Text = Nothing
        '        DJobStatus.Text = ""


        '    End If
        'Next
        'Dpicpath.Text = Nothing
        'PictureBox3.Image = Nothing
        'Mpicpath.Text = Nothing
        'PictureBox4.Image = Nothing
        'If rbmale.Checked = True Then
        '    gender.Text = "Male"
        '    Me.GBmom.Enabled = False
        '    Me.GBdad.Enabled = True
        '    DFName.Focus()

        '    'TabControl1.SelectedTab = TabPage1

        '    Dim x As Control
        '    For Each x In GBmom.Controls
        '        If TypeOf x Is TextBox Then
        '            x.Text = "Not Applicable"
        '            DJobStatus.Text = "Not Applicable"
        '        End If
        '    Next

        'End If

        'If rbmale.Checked = True Then
        '    Mpicpath.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'ElseIf rbfemale.Checked = True Then
        '    Dpicpath.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'End If
    End Sub


    Private Sub rbfemale_CheckedChanged_1(sender As Object, e As EventArgs)
        Dim y As Control
        For Each y In GBmom.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
                MJobStatus.Text = ""
            End If
        Next
        If rbfemale.Checked = True Then
            gender.Text = "Female"
            Me.GBdad.Enabled = False
            Me.GBmom.Enabled = True
            MFName.Focus()

            'TabControl1.SelectedTab = TabPage2

            Dim x As Control
            For Each x In GBdad.Controls
                If TypeOf x Is TextBox Then
                    x.Text = "Not Applicable"
                    MJobStatus.Text = "Not Applicable"
                End If
            Next

        End If

        'If rbmale.Checked = True Then
        '    TextBox3.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'ElseIf rbfemale.Checked = True Then
        '    TextBox8.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        'End If

    End Sub

    Private Sub MJobStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MJobStatus.SelectedIndexChanged
        If MJobStatus.SelectedItem = "Employed" Then
            MJobStatusOther.Visible = False
            Label6.Visible = False
            MJobStatusOther.Text = "Employed"
        ElseIf MJobStatus.SelectedItem = "Self Employed" Then
            MJobStatusOther.Visible = False
            Label6.Visible = False
            MJobStatusOther.Text = "Self Employed"
        ElseIf MJobStatus.SelectedItem = "None" Then
            MJobStatusOther.Visible = False
            Label6.Visible = False
            MJobStatusOther.Text = "None"
        Else
            MJobStatusOther.Text = ""
            MJobStatusOther.Visible = True
            Label6.Visible = True
            MJobStatusOther.Focus()

        End If
    End Sub


    Private Sub rbyes_CheckedChanged_2(sender As Object, e As EventArgs) Handles rbyes.CheckedChanged
        If rbyes.Checked = True Then
            GBdad.Enabled = False
            GBmom.Enabled = False
            GroupBox1.Enabled = False
            GroupBox9.Enabled = False
            Marital.Text = "Single"
            rbfemale.Checked = False
            rbmale.Checked = False
            GroupBox3.Enabled = True
            GroupBox3.IsAccessible = True
            gender.Text = ""

        End If
    End Sub

    Private Sub rbmale_CheckedChanged_2(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        Dim y As Control
        For Each y In GBdad.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
                DJobStatus.Text = ""
            End If
        Next

        For Each y In GroupBox9.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
            End If
        Next

        For Each y In GroupBox1.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
            End If
        Next

        ParentID_autogen()
        Dpicpath.Text = Nothing
        PictureBox3.Image = Nothing
        Mpicpath.Text = Nothing
        PictureBox4.Image = Nothing
        If rbmale.Checked = True Then
            gender.Text = "Male"
            

            Dim x As Control
            For Each x In GBmom.Controls
                If TypeOf x Is TextBox Then
                    x.Text = "Not Applicable"
                    DJobStatus.Text = "Not Applicable"
                End If
            Next

        End If

        If rbmale.Checked = True Then
            GroupBox9.Enabled = True
            Mpicpath.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        ElseIf rbfemale.Checked = True Then
            Dpicpath.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        End If
    End Sub

    Private Sub rbno_CheckedChanged_2(sender As Object, e As EventArgs) Handles rbno.CheckedChanged
        If rbno.Checked = True Then
            GBdad.Enabled = False
            GBmom.Enabled = False
            GroupBox1.Enabled = False
            'GroupBox9.Enabled = False
            GroupBox9.Enabled = True
            Marital.Text = "Married"
            gender.Text = Nothing
            GroupBox3.Enabled = False
            GroupBox3.IsAccessible = False
            'Me.GBdad.Enabled = True
            'Me.GBmom.Enabled = True
            'MFName.Focus()
            'TabControl1.SelectedTab = TabPage1
            gender.Text = "Not Applicable"
            Dim z As Control
            For Each z In GBmom.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next

            'Dim z As Control
            For Each z In GBdad.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next


        End If

        If rbmale.Checked = True Then
            MTell.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        ElseIf rbfemale.Checked = True Then
            MAge.Text = "C:\Users\Public\Pictures\Sample Pictures\not_applicable.png"
        End If
        rbfemale.Checked = False
        rbmale.Checked = False
    End Sub

    Private Sub rbfemale_CheckedChanged_2(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        Dim y As Control
        For Each y In GBmom.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
                MJobStatus.Text = ""
            End If
        Next

        For Each y In GroupBox9.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
            End If
        Next

        For Each y In GroupBox1.Controls
            If TypeOf y Is TextBox Then
                y.Text = Nothing
            End If
        Next

        ParentID_autogen()

        If rbfemale.Checked = True Then
            GroupBox9.Enabled = True
            gender.Text = "Female"

            Dim x As Control
            For Each x In GBdad.Controls
                If TypeOf x Is TextBox Then
                    x.Text = "Not Applicable"
                    MJobStatus.Text = "Not Applicable"
                End If
            Next

        End If
    End Sub

    Private Sub DJobStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DJobStatus.SelectedIndexChanged
        If DJobStatus.SelectedItem = "Employed" Then
            DJobStatusOther.Visible = False
            Label28.Visible = False
            DJobStatusOther.Text = "Employed"
        ElseIf DJobStatus.SelectedItem = "Self Employed" Then
            DJobStatusOther.Visible = False
            Label28.Visible = False
            DJobStatusOther.Text = "Self Employed"
        ElseIf DJobStatus.SelectedItem = "None" Then
            DJobStatusOther.Visible = False
            Label28.Visible = False
            DJobStatusOther.Text = "None"
        Else
            DJobStatusOther.Text = ""
            DJobStatusOther.Visible = True
            Label28.Visible = True
            DJobStatusOther.Focus()

        End If
    End Sub

    Private Sub MAge_TextChanged(sender As Object, e As EventArgs) Handles MAge.TextChanged
        'Dim age As Double = Date.Today - DateTimePicker1
        'DueDate.Text = due.ToString("MM/dd/yyyy")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MAge.Text = Date.Today.Year - DateTimePicker1.Value.Year
        If MAge.Text >= 25 And MAge.Text <= 65 Then
            MsgBox("Age requirement of " & vbCrLf & "above 25" & vbCrLf & "and less than 65" & vbCrLf & "years has been met")

        Else

            MsgBox("SOrry" & vbCrLf & "You are not within the age bracket allowed to adopt." & vbCrLf & "The Process will now terminate")
            Me.Hide()
            AdminHome.Show()

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        DAge.Text = Date.Today.Year - DateTimePicker2.Value.Year
        If DAge.Text >= 25 And DAge.Text <= 65 Then
            MsgBox("Age requirement of " & vbCrLf & "above 25" & vbCrLf & "and less than 65" & vbCrLf & "years has been met")

        Else

            MsgBox("SOrry" & vbCrLf & "You are not within the age bracket allowed to adopt." & vbCrLf & "The Process will now terminate")
            Me.Hide()
            AdminHome.Show()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Mpicpath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Dpicpath.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.ShowDialog()
        PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        OpenFileDialog2.ShowDialog()
        PictureBox4.Image = Image.FromFile(OpenFileDialog2.FileName)
    End Sub

    Private Sub PArentsfor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParentID_autogen()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load_parentsdetails()
        GBdad.Enabled = False
        GBmom.Enabled = False
        GroupBox1.Enabled = False
        GroupBox9.Enabled = False
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If uname.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        ElseIf pword.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        ElseIf pword1.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        Else
            UsernameCheck1()
        End If

        If gender.Text = "Male" Then
            GBdad.Enabled = True
            DFName.Focus()
        ElseIf gender.Text = "Female" Then
            GBmom.Enabled = True
            MFName.Focus()
        Else
            GBdad.Enabled = True
            GBmom.Enabled = True

        End If



        'If pword.Text = pword1.Text Then
        '    MsgBox("Logon Credentials Submited")
        '    GroupBox1.Enabled = False
        'Else
        '    MsgBox("Passwords do not match. Kindly try again")
        '    pword.Clear()
        '    pword1.Clear()
        '    pword.Focus()

        'End If


        'GBmom.Enabled = True
        'GBdad.Enabled = True
        'MFName.Focus()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UsernameCheck()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Dim a As Control
        'For Each a In GroupBox1.Controls
        '    If TypeOf a Is TextBox Then
        '        If a.Text = "" Then
        '            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        '        End If
        '    End If
        'Next

        If PostAdd.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        ElseIf PostCode.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        ElseIf Residential.Text = "" Then
            MsgBox("Ensure all the above fields are filled before proceeding.", MsgBoxStyle.Critical)
        Else
            GroupBox1.Enabled = True
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class