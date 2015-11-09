Imports System.Data.SqlClient
Module patatoto_connect
    Dim query As String
    Dim cmd As New SqlCommand
    Dim dbconn As New SqlConnection
    Dim reader As SqlDataReader
    Dim SDA As SqlDataAdapter
    Dim dbDataset As New DataTable
    Dim bSource As Binding
    Dim server = "Data source= ERICK;Initial Catalog = Patatoto;Integrated Security= SSPI"

    Public Sub ParentID_autogen()
        Try


            dbconn.ConnectionString = server
            dbconn.Open()
            query = "select MAX(ParentID) from Parents"
            cmd = New SqlCommand(query, dbconn)



            If IsDBNull(cmd.ExecuteScalar) Then
                Parents.ParentID.Text = 1
            Else
                Parents.ParentID.Text = cmd.ExecuteScalar + 1

            End If
            cmd.Dispose()
            dbconn.Close()
            dbconn.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Sub eNQUIERYID_autogen()
        Try


            dbconn.ConnectionString = server
            dbconn.Open()
            query = "select MAX(EnquiryID) from Enquiries"
            cmd = New SqlCommand(query, dbconn)



            If IsDBNull(cmd.ExecuteScalar) Then
                Otherfrom.enquieryid.Text = 1
            Else
                Otherfrom.enquieryid.Text = cmd.ExecuteScalar + 1

            End If
            cmd.Dispose()
            dbconn.Close()
            dbconn.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub childID_autogen()
        Try


            dbconn.ConnectionString = server
            dbconn.Open()
            query = "select MAX(ChildId) from Children"
            cmd = New SqlCommand(query, dbconn)


          
            If IsDBNull(cmd.ExecuteScalar) Then
                ChildFormAdd.txtchildid.Text = 1
            Else
                ChildFormAdd.txtchildid.Text = cmd.ExecuteScalar + 1

            End If
            cmd.Dispose()
            dbconn.Close()
            dbconn.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Public Sub connect()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server
        Dim reader As SqlDataReader

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "select * from authentication where Authid='" & AgentLogin.txtuser.Text & "'and Password='" & AgentLogin.txtpass.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"
            cmd = New SqlCommand(query, dbconn)
            reader = cmd.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1

            End While
            If count = 1 Then
                MsgBox("wellcome to Pata Toto")
                AgentLogin.txtuser.Clear()
                AgentLogin.txtpass.Clear()
                AdminHome.Show()
                AgentLogin.Hide()
                AgentLogin.txtpass.Clear()
                AgentLogin.txtuser.Clear()
            ElseIf count > 1 Then
                MsgBox("duplicates")
            Else
                MsgBox("wrong username password combination")
                AgentLogin.txtuser.Clear()
                AgentLogin.txtpass.Clear()
                AgentLogin.txtuser.Focus()

            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try
    End Sub

    Public Sub load_parentsdetails()

        Try
            dbconn.ConnectionString = server
            dbconn.Open()
            query = "insert into parents values ('" & Parents.ParentID.Text & _
                "','" & Parents.PostAdd.Text & _
                "','" & Parents.PostCode.Text & _
                "','" & Parents.Residential.Text & _
                "','" & Parents.Marital.Text & _
                "','" & Parents.gender.Text & _
                "','" & Parents.MFName.Text & _
                "','" & Parents.MLName.Text & _
                "','" & Parents.MID.Text & _
                "','" & Parents.MEmail.Text & _
                "','" & Parents.MTell.Text & _
                "','" & Parents.DateTimePicker1.Text & _
                "','" & Parents.MAge.Text & _
                "','" & Parents.MJobStatusOther.Text & _
                "','" & Parents.MCareer.Text & _
                "','" & Parents.Mpicpath.Text & _
                "','" & Parents.DFName.Text & _
                "','" & Parents.DLName.Text & _
                "','" & Parents.DID.Text & _
                "','" & Parents.DEmail.Text & _
                "','" & Parents.DTell.Text & _
                "','" & Parents.DateTimePicker2.Text & _
                "','" & Parents.DAge.Text & _
                "','" & Parents.DJobStatusOther.Text & _
                "','" & Parents.DCareer.Text & _
                "','" & Parents.Dpicpath.Text & _
                "','" & Parents.uname.Text & _
                "','" & Parents.pword1.Text & _
                "','Pending')"
            cmd = New SqlCommand(query, dbconn)
            cmd.ExecuteNonQuery()
            MsgBox("Registration request has been submited, You will receive an email once your account has been set up.", MsgBoxStyle.Information, "REQUEST SUBMITED")


            Parents.Dpicpath.Text = Nothing
            Parents.Mpicpath.Text = Nothing
            Parents.gender.Text = Nothing
            Parents.Marital.Text = Nothing
            Parents.GBdad.Enabled = True
            Parents.GBmom.Enabled = True
            Parents.rbfemale.Checked = False
            Parents.rbmale.Checked = False
            Parents.rbyes.Checked = False
            Parents.rbno.Checked = False

            Dim z As Control
            For Each z In Parents.GBmom.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next

            For Each z In Parents.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next
            'Dim z As Control
            For Each z In Parents.GBdad.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next
            For Each z In Parents.GroupBox1.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next
            Parents.PictureBox3.Image = Nothing
            Parents.PictureBox4.Image = Nothing

            For Each z In Parents.GroupBox9.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            dbconn.Close()
            dbconn.Dispose()
        End Try

        Parents.PostAdd.Focus()

        ParentID_autogen()

    End Sub

    Public Sub UsernameCheck()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server
        Dim reader As SqlDataReader

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "select username from Parents where username ='" & Parents.uname.Text & "'"
            cmd = New SqlCommand(query, dbconn)
            reader = cmd.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1

            End While
            If count = 1 Then
                MsgBox("The username already exists in the system. Kindly choose another one")
                Parents.uname.Clear()
                Parents.pword.Clear()
                Parents.pword1.Clear()
                Parents.uname.Focus()
            Else
                MsgBox("The username is available. You may proceed")
                Parents.unameava.Text = Parents.uname.Text
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try
    End Sub

    Public Sub UsernameCheck1()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server
        Dim reader As SqlDataReader

        Try
            If Parents.unameava.Text = "" Then


                dbconn.Open()
                cmd = New SqlCommand
                query = "select username from Parents where username ='" & Parents.uname.Text & "'"
                cmd = New SqlCommand(query, dbconn)
                reader = cmd.ExecuteReader
                Dim count As Integer = 0
                While reader.Read
                    count = count + 1

                End While
                If count = 1 Then
                    MsgBox("The username already exists in the system. Kindly choose another one")
                    Parents.uname.Clear()
                    Parents.pword.Clear()
                    Parents.pword1.Clear()
                    Parents.uname.Focus()
                Else
                    If Parents.pword.Text = Parents.pword1.Text Then
                        MsgBox("Logon Credentials Submited")
                        Parents.GroupBox1.Enabled = False
                        

                    Else
                        MsgBox("Passwords do not match. Kindly try again")
                        Parents.pword.Clear()
                        Parents.pword1.Clear()
                        Parents.pword.Focus()

                    End If
                    Parents.unameava.Text = Parents.uname.Text
                End If
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()

        End Try

    End Sub

    Sub RegRequestCheck()

        dbconn = New SqlConnection
        dbconn.ConnectionString = server


        '    dbconn.Open()
        '    query = "select COUNT(AccountStatus) from Parents where AccountStatus = 'Pending'"
        '    cmd = New SqlCommand(query, dbconn)





        '    AdminHome.regrequestcount1.Text = cmd.ExecuteScalar
        '    AdminHome.regrequestcount.Text = cmd.ExecuteScalar.ToString

        '    cmd.Dispose()
        '    dbconn.Close()
        '    dbconn.Dispose()


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "select COUNT(AccountStatus) from Parents where AccountStatus = 'Pending'"
            cmd = New SqlCommand(query, dbconn)

            AdminHome.regrequestcount1.Text = cmd.ExecuteScalar
            AdminHome.regrequestcount.Text = cmd.ExecuteScalar.ToString


        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try


    End Sub

    Public Sub ParentsConnect()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server
        Dim reader As SqlDataReader

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "select Username,Password,AccountStatus from Parents where Username ='" & ParentsLogin.puser.Text & "'and Password='" & ParentsLogin.ppword.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"
            cmd = New SqlCommand(query, dbconn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then

                reader.Read()
                ParentsLogin.status.Text = reader.Item("AccountStatus")
                ParentsLogin.unamecheck.Text = reader.Item("Username")
                ParentsLogin.pwordcheck.Text = reader.Item("password")

                'If reader.Item("AccountStatus") = "Confirmed" Then
                '    ParentsLogin.status.Text = "Confirmed"
                'Else
                '    ParentsLogin.status.Text = "Pending"
                'End If

            End If


            Dim count As Integer = 0




            While reader.Read
                count = count + 1

            End While

            If ParentsLogin.unamecheck.Text = ParentsLogin.puser.Text And ParentsLogin.ppword.Text = ParentsLogin.pwordcheck.Text And ParentsLogin.status.Text = "Active" Then
                MsgBox("wellcome to Pata Toto")
                ParentsLogin.puser.Clear()
                ParentsLogin.ppword.Clear()
                ParentsLogin.status.Clear()
                ParentsLogin.unamecheck.Clear()
                ParentsLogin.pwordcheck.Clear()
                ParentsHome.Show()
                ParentsLogin.Hide()

            ElseIf ParentsLogin.unamecheck.Text = ParentsLogin.puser.Text And ParentsLogin.ppword.Text = ParentsLogin.pwordcheck.Text And ParentsLogin.status.Text = "Pending" Then
                MsgBox("Your Account is yet to be confirmed. Kindly check back after a while")
                ParentsLogin.puser.Clear()
                ParentsLogin.ppword.Clear()
                ParentsLogin.status.Clear()
                ParentsLogin.unamecheck.Clear()
                ParentsLogin.pwordcheck.Clear()
                ParentsLogin.Hide()
                MAinform.Show()

            Else
                MsgBox("wrong username password combination")
                ParentsLogin.puser.Clear()
                ParentsLogin.ppword.Clear()
                ParentsLogin.status.Clear()
                ParentsLogin.unamecheck.Clear()
                ParentsLogin.pwordcheck.Clear()
                ParentsLogin.puser.Focus()

            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try
    End Sub

    Public Sub LoadAccountReq()



        Try
            query = "select ParentID,ResidentialArea,MaritalStatus,AccountStatus from Parents where AccountStatus = 'Pending'"
            dbconn = New SqlConnection
            dbconn.ConnectionString = server
            SDA = New SqlDataAdapter(query, dbconn)
            Dim ds As New DataSet()
            dbconn.Open()
            SDA.Fill(ds, "Authors_table")
            dbconn.Close()
            AuthorizeAccounts.DataGridView1.DataSource = ds
            AuthorizeAccounts.DataGridView1.DataMember = "Authors_table"

        Catch ex As SqlException
            MsgBox(ex.Message)

        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try



        'dbconn = New SqlConnection
        'dbconn.ConnectionString = server


        'Try
        '    dbconn.Open()
        '    cmd = New SqlCommand
        '    query = "select * from Parents where AccountStatus = 'Pending'"
        '    cmd = New SqlCommand(query, dbconn)
        '    cmd = SDA.SelectCommand
        '    SDA.Fill(dbDataset)
        '    dbDataset = bSource.DataSource
        '    AuthorizeAccounts.DataGridView1.DataSource = bSource
        '    SDA.Update(dbDataset)
        'Catch ex As SqlException
        '    MsgBox(ex.Message)
        'Finally
        '    dbconn.Close()
        '    dbconn.Dispose()
        'End Try
    End Sub


    Public Sub LoadAllAcc()



        Try
            query = "select ParentID,ResidentialArea,MaritalStatus,AccountStatus from Parents"
            dbconn = New SqlConnection
            dbconn.ConnectionString = server
            SDA = New SqlDataAdapter(query, dbconn)
            Dim ds As New DataSet()
            dbconn.Open()
            SDA.Fill(ds, "Authors_table")
            dbconn.Close()
            AuthorizeAccounts.DataGridView1.DataSource = ds
            AuthorizeAccounts.DataGridView1.DataMember = "Authors_table"

        Catch ex As SqlException
            MsgBox(ex.Message)

        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try



        'dbconn = New SqlConnection
        'dbconn.ConnectionString = server


        'Try
        '    dbconn.Open()
        '    cmd = New SqlCommand
        '    query = "select * from Parents where AccountStatus = 'Pending'"
        '    cmd = New SqlCommand(query, dbconn)
        '    cmd = SDA.SelectCommand
        '    SDA.Fill(dbDataset)
        '    dbDataset = bSource.DataSource
        '    AuthorizeAccounts.DataGridView1.DataSource = bSource
        '    SDA.Update(dbDataset)
        'Catch ex As SqlException
        '    MsgBox(ex.Message)
        'Finally
        '    dbconn.Close()
        '    dbconn.Dispose()
        'End Try
    End Sub


    Public Sub LoadEnquieries()

        Try
            dbconn.ConnectionString = server
            dbconn.Open()
            query = "insert into Enquiries values ('" & Otherfrom.enquieryid.Text & "','" & Otherfrom.name.Text & "','" & Otherfrom.email.Text & "','" & Otherfrom.enquiery.Text & "','Pending')"
            cmd = New SqlCommand(query, dbconn)
            cmd.ExecuteNonQuery()
            MsgBox("" & Otherfrom.name.Text & ",Your enquiery has been submited and we will get back to you within 24 hours. Thank you for showing interest in giving a child a home.", MsgBoxStyle.Information, "ENQUIRY SUBMITED")


            Dim z As Control
            For Each z In Otherfrom.Controls
                If TypeOf z Is TextBox Then
                    z.Text = Nothing
                End If
            Next

            



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            dbconn.Close()
            dbconn.Dispose()
        End Try

        Otherfrom.Hide()
        MAinform.Show()

    End Sub


    Public Sub EnquireCheck()
        Try
            dbconn.ConnectionString = server
            dbconn.Open()
            cmd = New SqlCommand
            query = "select COUNT(EnquiryStatus) from Enquiries where EnquiryStatus = 'Pending'"
            cmd = New SqlCommand(query, dbconn)

            AdminHome.enquieriescount1.Text = cmd.ExecuteScalar
            AdminHome.enquieriescount.Text = cmd.ExecuteScalar.ToString


        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub


    Public Sub detailedParentsreq()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server
        Dim reader As SqlDataReader

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "select * from Parents where ParentID ='" & AuthorizeAccounts.PID.Text & "'"
            cmd = New SqlCommand(query, dbconn)
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                AuthorizeAccounts.Gender.Text = reader.Item("Gender")
                AuthorizeAccounts.Uname.Text = reader.Item("Username")
                AuthorizeAccounts.Pword.Text = reader.Item("Password")
                AuthorizeAccounts.AccState.Text = reader.Item("AccountStatus")
                AuthorizeAccounts.MFName.Text = reader.Item("MFirstName")
                AuthorizeAccounts.MLName.Text = reader.Item("MLastName")
                AuthorizeAccounts.MID.Text = reader.Item("MIDNumber")
                AuthorizeAccounts.MEmail.Text = reader.Item("MEmail")
                AuthorizeAccounts.MTell.Text = reader.Item("MTell")
                AuthorizeAccounts.MDOB.Text = reader.Item("MDOB")
                AuthorizeAccounts.MJstatus.Text = reader.Item("MJobStatus")
                AuthorizeAccounts.MCareer.Text = reader.Item("Mcareer")
                AuthorizeAccounts.Mpic.Text = reader.Item("MPhoto")

                AuthorizeAccounts.DFName.Text = reader.Item("DFirstName")
                AuthorizeAccounts.DLName.Text = reader.Item("DLastName")
                AuthorizeAccounts.DID.Text = reader.Item("DIDNumber")
                AuthorizeAccounts.DEmail.Text = reader.Item("DEmail")
                AuthorizeAccounts.DTell.Text = reader.Item("DTell")
                AuthorizeAccounts.DDOB.Text = reader.Item("DDOB")
                AuthorizeAccounts.DJstatus.Text = reader.Item("DJobStatus")
                AuthorizeAccounts.Dcareer.Text = reader.Item("Dcareer")
                AuthorizeAccounts.Dpic.Text = reader.Item("DPhoto")



                reader.Close()

                AuthorizeAccounts.PictureBox3.Image = System.Drawing.Bitmap.FromFile(AuthorizeAccounts.Mpic.Text)
                AuthorizeAccounts.PictureBox1.Image = System.Drawing.Bitmap.FromFile(AuthorizeAccounts.Dpic.Text)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub


    Public Sub ActivateAccount()
        Try
            dbconn.ConnectionString = server
            dbconn.Open()
            cmd = New SqlCommand
            query = "update parents set AccountStatus = 'Activated' where ParentID = '" & AuthorizeAccounts.PID.Text & "'"
            cmd = New SqlCommand(query, dbconn)

            
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub


    Public Sub DectivateAccount()
        Try
            dbconn.ConnectionString = server
            dbconn.Open()
            cmd = New SqlCommand
            query = "update parents set AccountStatus = 'Pending' where ParentID = ''" & AuthorizeAccounts.PID.Text & "''"

            '            UPDATE Customers
            'SET ContactName='Alfred Schmidt', City='Hamburg'
            'WHERE CustomerName='Alfreds Futterkiste'

            cmd = New SqlCommand(query, dbconn)


        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub

    Public Sub ActivateAccount1()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "Update Parents set AccountStatus = 'Active' where ParentId = ' " & AuthorizeAccounts.PID.Text & " ' "
            cmd = New SqlCommand(query, dbconn)
            cmd.ExecuteNonQuery()

            ' MsgBox("book status set to borrowed")

            dbconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Dispose()


        End Try

    End Sub


    Public Sub DeactivateAccount1()
        dbconn = New SqlConnection
        dbconn.ConnectionString = server

        Try
            dbconn.Open()
            cmd = New SqlCommand
            query = "Update Parents set AccountStatus = 'Pending' where ParentId = ' " & AuthorizeAccounts.PID.Text & " ' "
            cmd = New SqlCommand(query, dbconn)
            cmd.ExecuteNonQuery()

            ' MsgBox("book status set to borrowed")

            dbconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconn.Dispose()


        End Try

    End Sub


    Public Sub LoadPendingEnquieries()



        Try
            query = "select * from Enquiries where EnquiryStatus = 'Pending'"
            dbconn = New SqlConnection
            dbconn.ConnectionString = server
            SDA = New SqlDataAdapter(query, dbconn)
            Dim ds As New DataSet()
            dbconn.Open()
            SDA.Fill(ds, "Authors_table")
            dbconn.Close()
            Enquieries.DataGridView1.DataSource = ds
            Enquieries.DataGridView1.DataSource.DataMember = "Authors_table"

        Catch ex As SqlException
            MsgBox(ex.Message)

        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub


    Public Sub LoadRepliedEnquieries()



        Try
            query = "select * from Enquiries where EnquiryStatus = 'Replied'"
            dbconn = New SqlConnection
            dbconn.ConnectionString = server
            SDA = New SqlDataAdapter(query, dbconn)
            Dim ds As New DataSet()
            dbconn.Open()
            SDA.Fill(ds, "Authors_table")
            dbconn.Close()
            Enquieries.DataGridView1.DataSource = ds
            Enquieries.DataGridView1.DataSource.DataMember = "Authors_table"

        Catch ex As SqlException
            MsgBox(ex.Message)

        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub

    Public Sub LoadAllEnquieries()



        Try
            query = "select * from Enquiries"
            dbconn = New SqlConnection
            dbconn.ConnectionString = server
            SDA = New SqlDataAdapter(query, dbconn)
            Dim ds As New DataSet()
            dbconn.Open()
            SDA.Fill(ds, "Authors_table")
            dbconn.Close()
            Enquieries.DataGridView1.DataSource = ds
            Enquieries.DataGridView1.DataSource.DataMember = "Authors_table"

        Catch ex As SqlException
            MsgBox(ex.Message)

        Finally
            dbconn.Close()
            dbconn.Dispose()
        End Try

    End Sub



End Module
