Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb

Public Class a_customer
    Dim ds, ds1, ds2, ds3 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da1, da, da2, da3 As OleDbDataAdapter

    Dim total_rows, i, j, count As Long
    Dim ut, ur, bn, id, vl, p1, p2, im As String
    Public Sub datainsert(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByRef v4 As String, ByVal v5 As String, ByRef v6 As String, ByRef v7 As Date, ByRef v8 As String, ByRef v9 As String, ByRef v10 As String, ByRef v11 As String, ByRef v12 As String, ByRef v13 As String, ByRef v14 As String, ByRef v15 As String, ByVal v16 As String, ByRef v17 As String, ByRef v18 As String, ByRef v19 As String, ByRef v20 As Date, ByRef v21 As String, ByRef v22 As String, ByRef v23 As String)
        customerdetail.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_customer", objConn1)
        ds = New DataSet("B_DataSet3")
        da1.Fill(ds, "a_customer")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_customer (Customerno,Fullname, Customertype,Title,Firstname,Gender,DOB,Placeofbirth,Occupation,Officephone,Homephone,Mobilephone,Email,Nationality,Digitalsign,Picture,Salary,Identificationdetailsid) Values(@Customerno,@Fullname, @Customertype,@Title,@Firstname,@Gender,@DOB,@Placeofbirth,@Occupation,@Officephone,@Homephone,@Mobilephone,@Email,@Nationality,@Digitalsign,@Picture,@Salary,@Identificationdetailsid)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Customerno", OleDbType.Char, 50, "Customerno")
        da1.InsertCommand.Parameters.Add("@Fullname", OleDbType.Char, 50, "Fullname")
        da1.InsertCommand.Parameters.Add("@Customertype", OleDbType.Char, 50, "Customertype")
        da1.InsertCommand.Parameters.Add("@Title", OleDbType.Char, 50, "Title")
        da1.InsertCommand.Parameters.Add("@Firstname", OleDbType.Char, 50, "Firstname")
        da1.InsertCommand.Parameters.Add("@Gender", OleDbType.Char, 50, "Gender")
        da1.InsertCommand.Parameters.Add("@DOB", OleDbType.Date, 50, "DOB")
        da1.InsertCommand.Parameters.Add("@Placeofbirth", OleDbType.Char, 50, "Placeofbirth")
        da1.InsertCommand.Parameters.Add("@Occupation", OleDbType.Char, 50, "Occupation")
        da1.InsertCommand.Parameters.Add("@Officephone", OleDbType.Char, 50, "Officephone")
        da1.InsertCommand.Parameters.Add("@Homephone", OleDbType.Char, 50, "Homephone")
        da1.InsertCommand.Parameters.Add("@Mobilephone", OleDbType.Char, 50, "Mobilephone")
        da1.InsertCommand.Parameters.Add("@Email", OleDbType.Char, 50, "Email")
        da1.InsertCommand.Parameters.Add("@Nationality", OleDbType.Char, 50, "Nationality")
        da1.InsertCommand.Parameters.Add("@Digitalsign", OleDbType.Char, 50, "Digitalsign")
        da1.InsertCommand.Parameters.Add("@Picture", OleDbType.Char, 50, "Picture")
        da1.InsertCommand.Parameters.Add("@Salary", OleDbType.Char, 50, "Salary")
        da1.InsertCommand.Parameters.Add("@Identificationdetailsid", OleDbType.Integer, 5, "Identificationdetailsid")

        Dim dr1 As DataRow = ds.Tables("a_customer").NewRow()

        dr1("Customerno") = v1
        dr1("Fullname") = v2.ToLower
        dr1("Customertype") = v3
        dr1("Title") = v4
        dr1("Firstname") = v5.ToLower
        dr1("Gender") = v6
        dr1("DOB") = v7
        dr1("Placeofbirth") = v8
        dr1("Occupation") = v9
        dr1("Officephone") = v10
        dr1("Homephone") = v11
        dr1("Mobilephone") = v12
        dr1("Email") = v13
        dr1("Nationality") = v14.ToLower
        dr1("Digitalsign") = v15
        dr1("Picture") = v16
        dr1("Salary") = v17

        da2 = New OleDbDataAdapter("select * from a_identificationdetails", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_identificationdetails")

        da2.InsertCommand = New OleDbCommand("INSERT INTO a_identificationdetails (Identifitiontype,Identificationno,Dateissued,Issuedat,Issuedby,Residenedpermitno) Values(@Identifitiontype,@Identificationno,@Dateissued,@Issuedat,@Issuedby,@Residenedpermitno)", objConn1)
        da2.InsertCommand.CommandType = CommandType.Text
        da2.InsertCommand.Parameters.Add("@Identifitiontype", OleDbType.Char, 50, "Identifitiontype")
        da2.InsertCommand.Parameters.Add("@Identificationno", OleDbType.Char, 50, "Identificationno")
        da2.InsertCommand.Parameters.Add("@Dateissued", OleDbType.Date, 50, "Dateissued")
        da2.InsertCommand.Parameters.Add("@Issuedat", OleDbType.Char, 50, "Issuedat")
        da2.InsertCommand.Parameters.Add("@Issuedby", OleDbType.Char, 50, "Issuedby")
        da2.InsertCommand.Parameters.Add("@Residenedpermitno", OleDbType.Char, 50, "Residenedpermitno")

        Dim dr2 As DataRow = ds2.Tables("a_identificationdetails").NewRow()

        dr2("Identifitiontype") = v18
        dr2("Identificationno") = v19
        dr2("Dateissued") = v20
        dr2("Issuedat") = v21
        dr2("Issuedby") = v22
        dr2("Residenedpermitno") = v23

        ds2.Tables("a_identificationdetails").Rows.Add(dr2)
        da2.Update(ds2, "a_identificationdetails")

        da3 = New OleDbDataAdapter("select * from a_identificationdetails", objConn1)
        ds3 = New DataSet("B_DataSet3")
        da3.Fill(ds3, "a_identificationdetails")
        total_rows = ds3.Tables("a_identificationdetails").Rows.Count - 1
        For i = 0 To total_rows
            id = ds3.Tables("a_identificationdetails").Rows(i).Item("Identificationno")
            If v19 = id Then
                count = ds3.Tables("a_identificationdetails").Rows(i).Item("Identificationdetailsid")
            End If
        Next

        dr1("Identificationdetailsid") = count

        ds.Tables("a_customer").Rows.Add(dr1)

        Try
            da1.Update(ds, "a_customer")
            customerdetail.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Customer is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub datasave(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByRef v4 As String, ByVal v5 As String, ByRef v6 As String, ByRef v7 As Date, ByRef v8 As String, ByRef v9 As String, ByRef v10 As String, ByRef v11 As String, ByRef v12 As String, ByRef v13 As String, ByRef v14 As String, ByRef v15 As String, ByVal v16 As String, ByRef v17 As String, ByRef v18 As String, ByRef v19 As String, ByRef v20 As Date, ByRef v21 As String, ByRef v22 As String, ByRef v23 As String)
        customerdetail.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_customer", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_customer")
        da.UpdateCommand = New OleDbCommand("UPDATE a_customer SET Fullname=@Fullname,Customertype=@Customertype,Title=@Title,Firstname=@Firstname,Gender=@Gender,DOB=@DOB,Placeofbirth=@Placeofbirth,Occupation=@Occupation,Officephone=@Officephone,Homephone=@Homephone,Mobilephone=@Mobilephone,Email=@Email,Nationality=@Nationality,Digitalsign=@Digitalsign,Picture=@Picture,Salary=@Salary Where (Customerno='" & v1 & "')", objConn1)
        da.UpdateCommand.CommandType = CommandType.Text

        da.UpdateCommand.Parameters.Add("@Fullname", OleDbType.Char, 50, "Fullname")
        da.UpdateCommand.Parameters.Add("@Customertype", OleDbType.Char, 50, "Customertype")
        da.UpdateCommand.Parameters.Add("@Title", OleDbType.Char, 50, "Title")
        da.UpdateCommand.Parameters.Add("@Firstname", OleDbType.Char, 50, "Firstname")
        da.UpdateCommand.Parameters.Add("@Gender", OleDbType.Char, 50, "Gender")
        da.UpdateCommand.Parameters.Add("@DOB", OleDbType.Date, 50, "DOB")
        da.UpdateCommand.Parameters.Add("@Placeofbirth", OleDbType.Char, 50, "Placeofbirth")
        da.UpdateCommand.Parameters.Add("@Occupation", OleDbType.Char, 50, "Occupation")
        da.UpdateCommand.Parameters.Add("@Officephone", OleDbType.Char, 50, "Officephone")
        da.UpdateCommand.Parameters.Add("@Homephone", OleDbType.Char, 50, "Homephone")
        da.UpdateCommand.Parameters.Add("@Mobilephone", OleDbType.Char, 50, "Mobilephone")
        da.UpdateCommand.Parameters.Add("@Email", OleDbType.Char, 50, "Email")
        da.UpdateCommand.Parameters.Add("@Nationality", OleDbType.Char, 50, "Nationality")
        da.UpdateCommand.Parameters.Add("@Digitalsign", OleDbType.Char, 50, "Digitalsign")
        da.UpdateCommand.Parameters.Add("@Picture", OleDbType.Char, 50, "Picture")
        da.UpdateCommand.Parameters.Add("@Salary", OleDbType.Char, 50, "Salary")

        ds.Tables("a_customer").Rows(0).Item("Fullname") = v2.ToLower
        ds.Tables("a_customer").Rows(0).Item("Customertype") = v3
        ds.Tables("a_customer").Rows(0).Item("Title") = v4
        ds.Tables("a_customer").Rows(0).Item("Firstname") = v5.ToLower
        ds.Tables("a_customer").Rows(0).Item("Gender") = v6
        ds.Tables("a_customer").Rows(0).Item("DOB") = v7
        ds.Tables("a_customer").Rows(0).Item("Placeofbirth") = v8
        ds.Tables("a_customer").Rows(0).Item("Occupation") = v9
        ds.Tables("a_customer").Rows(0).Item("Officephone") = v10
        ds.Tables("a_customer").Rows(0).Item("Homephone") = v11
        ds.Tables("a_customer").Rows(0).Item("Mobilephone") = v12
        ds.Tables("a_customer").Rows(0).Item("Email") = v13
        ds.Tables("a_customer").Rows(0).Item("Nationality") = v14.ToLower
        ds.Tables("a_customer").Rows(0).Item("Digitalsign") = v15
        ds.Tables("a_customer").Rows(0).Item("Picture") = v16
        ds.Tables("a_customer").Rows(0).Item("Salary") = v17

        da.Update(ds, "a_customer")

        da1 = New OleDbDataAdapter("select * from  a_customer", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_customer")

        total_rows = ds1.Tables("a_customer").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_customer").Rows(i).Item("Customerno")
            If v1 = ut Then
                count = ds1.Tables("a_customer").Rows(i).Item("Identificationdetailsid")
            End If
        Next

        da2 = New OleDbDataAdapter("select * from a_identificationdetails", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_identificationdetails")

        da2.UpdateCommand = New OleDbCommand("UPDATE a_identificationdetails SET Identifitiontype=@Identifitiontype,Identificationno=@Identificationno,Dateissued=@Dateissued,Issuedat=@Issuedat,Issuedby=@Issuedby,Residenedpermitno=@Residenedpermitno WHERE (Identificationdetailsid= " & count & " )", objConn1)
        da2.UpdateCommand.CommandType = CommandType.Text

        da2.UpdateCommand.Parameters.Add("@Identifitiontype", OleDbType.Char, 50, "Identifitiontype")
        da2.UpdateCommand.Parameters.Add("@Identificationno", OleDbType.Char, 50, "Identificationno")
        da2.UpdateCommand.Parameters.Add("@Dateissued", OleDbType.Date, 50, "Dateissued")
        da2.UpdateCommand.Parameters.Add("@Issuedat", OleDbType.Char, 50, "Issuedat")
        da2.UpdateCommand.Parameters.Add("@Issuedby", OleDbType.Char, 50, "Issuedby")
        da2.UpdateCommand.Parameters.Add("@Residenedpermitno", OleDbType.Char, 50, "Residenedpermitno")

        ds2.Tables("a_identificationdetails").Rows(0).Item("Identifitiontype") = v18
        ds2.Tables("a_identificationdetails").Rows(0).Item("Identificationno") = v19
        ds2.Tables("a_identificationdetails").Rows(0).Item("Dateissued") = v20
        ds2.Tables("a_identificationdetails").Rows(0).Item("Issuedat") = v21
        ds2.Tables("a_identificationdetails").Rows(0).Item("Issuedby") = v22
        ds2.Tables("a_identificationdetails").Rows(0).Item("Residenedpermitno") = v23

        da2.Update(ds2, "a_identificationdetails")

        Try
            customerdetail.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Customer Information is UpDateed....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Function custno()
        Dim strbrhno As String
        Dim intlastno As Integer
        da = New OleDbDataAdapter("SELECT Customerno FROM a_customer ORDER BY Customerid DESC", objConn1)
        ds = New DataSet("B_dataset3")
        da.Fill(ds, "a_customer")
        total_rows = ds.Tables("a_customer").Rows().Count - 1
        For i = 0 To total_rows
            If ds.Tables("a_customer").Rows(i).Item("Customerno") = "" Then
                Return "CS-000001"
            Else
                strbrhno = ds.Tables("a_customer").Rows(i).Item("Customerno").ToString()
                intlastno = Integer.Parse(strbrhno.Substring(3, 6)) + 1
                Return "CS-" + intlastno.ToString("000000")
            End If
        Next
        Return "CS-000001"
    End Function

    Public Sub loadcust(ByVal v1 As String)
        customerdetail.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("SELECT * FROM a_customer", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_customer")

        total_rows = ds.Tables("a_customer").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_customer").Rows(i).Item("Customerno") Then
                customerdetail.txtfullname.Text = ds.Tables("a_customer").Rows(i).Item("Fullname")
                customerdetail.ComboBox1.Text = ds.Tables("a_customer").Rows(i).Item("Customertype")
                customerdetail.ComboBox2.Text = ds.Tables("a_customer").Rows(i).Item("Title")
                customerdetail.txtfirstname.Text = ds.Tables("a_customer").Rows(i).Item("Firstname")
                vl = ds.Tables("a_customer").Rows(i).Item("Gender")
                If vl = customerdetail.RadioButton1.Text Then
                    customerdetail.RadioButton1.Checked = True
                ElseIf vl = customerdetail.RadioButton2.Text Then
                    customerdetail.RadioButton2.Checked = True
                End If
                customerdetail.DateTimePicker1.Text = ds.Tables("a_customer").Rows(i).Item("DOB")
                customerdetail.txtplacebirth.Text = ds.Tables("a_customer").Rows(i).Item("Placeofbirth")
                customerdetail.txtoccap.Text = ds.Tables("a_customer").Rows(i).Item("Occupation")
                customerdetail.txtoffph.Text = ds.Tables("a_customer").Rows(i).Item("Officephone")
                customerdetail.txthomeph.Text = ds.Tables("a_customer").Rows(i).Item("Homephone")
                customerdetail.txtmoph.Text = ds.Tables("a_customer").Rows(i).Item("Mobilephone")
                customerdetail.txtemail.Text = ds.Tables("a_customer").Rows(i).Item("Email")
                customerdetail.txtnational.Text = ds.Tables("a_customer").Rows(i).Item("Nationality")
                p1 = ds.Tables("a_customer").Rows(i).Item("Digitalsign").ToString
                If p1 <> "" Then
                    customerdetail.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & p1)
                End If
                p2 = ds.Tables("a_customer").Rows(i).Item("Picture").ToString
                If p2 <> "" Then
                    customerdetail.PictureBox2.Image = Image.FromFile(Application.StartupPath & "\resources\" & p2)
                End If
                im = ds.Tables("a_customer").Rows(i).Item("Salary")
                If im = customerdetail.RadioButton3.Text Then
                    customerdetail.RadioButton3.Checked = True
                ElseIf im = customerdetail.RadioButton4.Text Then
                    customerdetail.RadioButton4.Checked = True
                ElseIf im = customerdetail.RadioButton5.Text Then
                    customerdetail.RadioButton5.Checked = True
                ElseIf im = customerdetail.RadioButton6.Text Then
                    customerdetail.RadioButton6.Checked = True
                ElseIf im = customerdetail.RadioButton7.Text Then
                    customerdetail.RadioButton7.Checked = True
                End If
                ut = ds.Tables("a_customer").Rows(i).Item("Identificationdetailsid")
                da1 = New OleDbDataAdapter("SELECT * FROM a_identificationdetails", objConn1)
                ds1 = New DataSet("B_Dataset3")
                da1.Fill(ds1, "a_identificationdetails")
                total_rows = ds1.Tables("a_identificationdetails").Rows.Count - 1
                For j = 0 To total_rows
                    If ut = ds1.Tables("a_identificationdetails").Rows(j).Item("Identificationdetailsid") Then
                        customerdetail.ComboBox3.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Identifitiontype")
                        customerdetail.txtidentificationno.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Identificationno")
                        customerdetail.DateTimePicker2.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Dateissued")
                        customerdetail.txtissuedat.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Issuedat")
                        customerdetail.txtissuedby.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Issuedby")
                        customerdetail.txtresidence.Text = ds1.Tables("a_identificationdetails").Rows(i).Item("Residenedpermitno")
                    End If
                Next
            End If
        Next
        customerdetail.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub

End Class
