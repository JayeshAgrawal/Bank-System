Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class a_bank
    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da1, da, da2 As OleDbDataAdapter

    Dim total_rows, i, count As Long
    Dim ut, ur, bn As String


    Public Sub datainsert(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByRef v4 As String, ByRef v5 As String)
        bankprofile.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_bank", objConn1)
        ds = New DataSet("B_DataSet2")
        da1.Fill(ds, "a_bank")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_bank (Bankname,Email,Website,Slogan,Logo) Values(@Bankname,@Email,@Website,@Slogan,@Logo)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Bankname", OleDbType.Char, 50, "Bankname")
        da1.InsertCommand.Parameters.Add("@Email", OleDbType.Char, 50, "Email")
        da1.InsertCommand.Parameters.Add("@Website", OleDbType.Char, 50, "Website")
        da1.InsertCommand.Parameters.Add("@Slogan", OleDbType.Char, 50, "Slogan")
        da1.InsertCommand.Parameters.Add("@Logo", OleDbType.Char, 50, "Logo")



        Dim dr1 As DataRow = ds.Tables("a_bank").NewRow()

        dr1("Bankname") = v1
        dr1("Email") = v2
        dr1("Website") = v3
        dr1("Slogan") = v4
        dr1("Logo") = v5

        ds.Tables("a_bank").Rows.Add(dr1)

        Try
            da1.Update(ds, "a_bank")
            bankprofile.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
      
    End Sub

    Public Sub savebank(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String)
        bankprofile.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da2 = New OleDbDataAdapter("select * from a_bank", objConn1)
        ds2 = New DataSet("B_DataSet2")
        da2.Fill(ds2, "a_bank")
        da2.UpdateCommand = New OleDbCommand("UPDATE a_bank SET Email=@Email,Website=@Website,Slogan=@Slogan,Logo=@Logo Where (Bankname='" & v1 & "')", objConn1)
        da2.UpdateCommand.CommandType = CommandType.Text

        da2.UpdateCommand.Parameters.Add("@Email", OleDbType.Char, 50, "Email")
        da2.UpdateCommand.Parameters.Add("@Website", OleDbType.Char, 50, "Website")
        da2.UpdateCommand.Parameters.Add("@Slogan", OleDbType.Char, 50, "Slogan")
        da2.UpdateCommand.Parameters.Add("@Logo", OleDbType.Char, 50, "Logo")

        ds2.Tables("a_bank").Rows(0).Item("Email") = v2
        ds2.Tables("a_bank").Rows(0).Item("Website") = v3
        ds2.Tables("a_bank").Rows(0).Item("Slogan") = v4
        ds2.Tables("a_bank").Rows(0).Item("Logo") = v5

        Try
            da2.Update(ds2, "a_bank")
            bankprofile.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is UpDateed....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
     
    End Sub

    Public Sub deletebank(ByVal v1 As String)
        bankprofile.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from  a_bank", objConn1)
        ds = New DataSet("B_DataSet2")
        da.Fill(ds, "a_bank")

        da.DeleteCommand = New OleDbCommand("DELETE FROM  a_bank WHERE (Bankname='" & v1 & "')", objConn1)
        da.DeleteCommand.CommandType = CommandType.Text
        da.DeleteCommand.Parameters.Add("@Bankname", OleDb.OleDbType.Char, 255, "Bankname")

        total_rows = ds.Tables("a_bank").Rows.Count - 1
        For i = 0 To total_rows
            bn = ds.Tables("a_bank").Rows(i).Item("Bankname")

            If v1 = bn Then
                If MsgBox("Are you sure ? " & (Chr(13)) & "Delete " & v1, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ds.Tables("a_bank").Rows(i).Delete()
                    Dim com1 As New OleDbCommand("DELETE FROM a_accounts", objConn1)
                    Dim com2 As New OleDbCommand("DELETE FROM a_accounttype", objConn1)
                    Dim com3 As New OleDbCommand("DELETE FROM a_bankbranches", objConn1)
                    Dim com4 As New OleDbCommand("DELETE FROM a_chequebooks", objConn1)
                    Dim com5 As New OleDbCommand("DELETE FROM a_chequebooksdetails", objConn1)
                    Dim com6 As New OleDbCommand("DELETE FROM a_customer", objConn1)
                    Dim com7 As New OleDbCommand("DELETE FROM a_identificationdetails", objConn1)
                    Dim com8 As New OleDbCommand("DELETE FROM a_newuser", objConn1)
                    Dim com9 As New OleDbCommand("DELETE FROM a_transactiondetails", objConn1)
                    Dim com10 As New OleDbCommand("DELETE FROM a_transactions", objConn1)
                    Dim com11 As New OleDbCommand("DELETE FROM a_transferdetails", objConn1)

                    objConn1.Open()
                    com1.ExecuteNonQuery()
                    com2.ExecuteNonQuery()
                    com3.ExecuteNonQuery()
                    com4.ExecuteNonQuery()
                    com5.ExecuteNonQuery()
                    com6.ExecuteNonQuery()
                    com7.ExecuteNonQuery()
                    com8.ExecuteNonQuery()
                    com9.ExecuteNonQuery()
                    com10.ExecuteNonQuery()
                    com11.ExecuteNonQuery()
                    objConn1.Close()
                    Directory.Delete(Application.StartupPath & "\resources")
                    Directory.CreateDirectory(Application.StartupPath & "\resources")
                    i = total_rows + 1
                    Try
                        da.Update(ds, "a_bank")
                        bankprofile.Cursor = Cursors.Arrow
                        home.ToolStripProgressBar1.Visible = False
                        MsgBox("Data of '" & v1 & "' is deleted", MsgBoxStyle.Information)
                        MsgBox("Application Have Bank For" & (Chr(13)) & " This Application Is Close.")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                End If
            End If
        Next
     
    End Sub

    Public Sub insertbranch(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByRef v4 As String, ByRef v5 As String, ByRef v6 As String, ByRef v7 As String, ByRef v8 As String, ByRef v9 As String, ByRef v10 As String, ByRef v11 As String, ByRef v12 As String)
        bankbranches.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_bankbranches", objConn1)
        ds = New DataSet("B_DataSet2")
        da1.Fill(ds, "a_bankbranches")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_bankbranches (Bankid,Branchno,Branchname,Phoneno1,Phoneno2,Faxno1,Faxno2,PoBox,Website,City,Country,Address,Logo) Values(@Bankid,@Branchno,@Branchname,@Phoneno1,@Phoneno2,@Faxno1,@Faxno2,@PoBox,@Website,@City,@Country,@Address,@Logo)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Bankid", OleDbType.Integer, 5, "Bankid")
        da1.InsertCommand.Parameters.Add("@Branchno", OleDbType.Char, 50, "Branchno")
        da1.InsertCommand.Parameters.Add("@Branchname", OleDbType.Char, 50, "Branchname")
        da1.InsertCommand.Parameters.Add("@Phoneno1", OleDbType.Char, 50, "Phoneno1")
        da1.InsertCommand.Parameters.Add("@Phoneno2", OleDbType.Char, 50, "Phoneno2")
        da1.InsertCommand.Parameters.Add("@Faxno1", OleDbType.Char, 50, "Faxno1")
        da1.InsertCommand.Parameters.Add("@Faxno2", OleDbType.Char, 50, "Faxno2")
        da1.InsertCommand.Parameters.Add("@PoBox", OleDbType.Char, 50, "PoBox")
        da1.InsertCommand.Parameters.Add("@Website", OleDbType.Char, 50, "Website")
        da1.InsertCommand.Parameters.Add("@City", OleDbType.Char, 50, "City")
        da1.InsertCommand.Parameters.Add("@Country", OleDbType.Char, 50, "Country")
        da1.InsertCommand.Parameters.Add("@Address", OleDbType.Char, 50, "Address")
        da1.InsertCommand.Parameters.Add("@Logo", OleDbType.Char, 50, "Logo")

        Dim dr1 As DataRow = ds.Tables("a_bankbranches").NewRow()

        dr1("Bankid") = 1
        dr1("Branchno") = v1
        dr1("Branchname") = v2
        dr1("Phoneno1") = v3
        dr1("Phoneno2") = v4
        dr1("Faxno1") = v5
        dr1("Faxno2") = v6
        dr1("PoBox") = v7
        dr1("Website") = v8
        dr1("City") = v9
        dr1("Country") = v10
        dr1("Address") = v11
        dr1("Logo") = v12

        ds.Tables("a_bankbranches").Rows.Add(dr1)

        Try
            da1.Update(ds, "a_bankbranches")
            bankbranches.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
     
    End Sub

    Public Sub savebranch(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByRef v4 As String, ByRef v5 As String, ByRef v6 As String, ByRef v7 As String, ByRef v8 As String, ByRef v9 As String, ByRef v10 As String, ByRef v11 As String, ByRef v12 As String)
        bankbranches.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True

        da2 = New OleDbDataAdapter("select * from a_bankbranches", objConn1)
        ds2 = New DataSet("B_DataSet2")
        da2.Fill(ds2, "a_bankbranches")
        da2.UpdateCommand = New OleDbCommand("UPDATE a_bankbranches SET Branchname=@Branchname,Phoneno1=@Phoneno1,Phoneno2=@Phoneno2,Faxno1=@Faxno1,Faxno2=@Faxno2,PoBox=@PoBox,Website=@Website,City=@City,Country=@Country,Address=@Address,Logo=@Logo Where (Branchno='" & v1 & "')", objConn1)
        da2.UpdateCommand.CommandType = CommandType.Text

        da2.UpdateCommand.Parameters.Add("@Branchname", OleDbType.Char, 50, "Branchname")
        da2.UpdateCommand.Parameters.Add("@Phoneno1", OleDbType.Char, 50, "Phoneno1")
        da2.UpdateCommand.Parameters.Add("@Phoneno2", OleDbType.Char, 50, "Phoneno2")
        da2.UpdateCommand.Parameters.Add("@Faxno1", OleDbType.Char, 50, "Faxno1")
        da2.UpdateCommand.Parameters.Add("@Faxno2", OleDbType.Char, 50, "Faxno2")
        da2.UpdateCommand.Parameters.Add("@PoBox", OleDbType.Char, 50, "PoBox")
        da2.UpdateCommand.Parameters.Add("@Website", OleDbType.Char, 50, "Website")
        da2.UpdateCommand.Parameters.Add("@City", OleDbType.Char, 50, "City")
        da2.UpdateCommand.Parameters.Add("@Country", OleDbType.Char, 50, "Country")
        da2.UpdateCommand.Parameters.Add("@Address", OleDbType.Char, 50, "Address")
        da2.UpdateCommand.Parameters.Add("@Logo", OleDbType.Char, 50, "Logo")

        ds2.Tables("a_bankbranches").Rows(0).Item("Branchname") = v2
        ds2.Tables("a_bankbranches").Rows(0).Item("Phoneno1") = v3
        ds2.Tables("a_bankbranches").Rows(0).Item("Phoneno2") = v4
        ds2.Tables("a_bankbranches").Rows(0).Item("Faxno1") = v5
        ds2.Tables("a_bankbranches").Rows(0).Item("Faxno2") = v6
        ds2.Tables("a_bankbranches").Rows(0).Item("PoBox") = v7
        ds2.Tables("a_bankbranches").Rows(0).Item("Website") = v8
        ds2.Tables("a_bankbranches").Rows(0).Item("City") = v9
        ds2.Tables("a_bankbranches").Rows(0).Item("Country") = v10
        ds2.Tables("a_bankbranches").Rows(0).Item("Address") = v11
        ds2.Tables("a_bankbranches").Rows(0).Item("Logo") = v12

        Try
            da2.Update(ds2, "a_bankbranches")
            bankbranches.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Branches information successfully updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
      
    End Sub

    Public Sub deletebranch(ByVal v1 As String)
        bankbranches.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True

        da = New OleDbDataAdapter("select * from  a_bankbranches", objConn1)
        ds = New DataSet("B_DataSet2")
        da.Fill(ds, "a_bankbranches")

        da.DeleteCommand = New OleDbCommand("DELETE FROM a_bankbranches WHERE (Branchno='" & v1 & "')", objConn1)
        da.DeleteCommand.CommandType = CommandType.Text
        da.DeleteCommand.Parameters.Add("@Bankname", OleDb.OleDbType.Char, 255, "Branchno")

        total_rows = ds.Tables("a_bankbranches").Rows.Count - 1
        For i = 0 To total_rows
            bn = ds.Tables("a_bankbranches").Rows(i).Item("Branchno")

            If v1 = bn Then
                If MsgBox("Are you sure ? " & (Chr(13)) & "Delete " & v1, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                 

                    ds.Tables("a_bankbranches").Rows(i).Delete()

                    i = total_rows + 1
                    Try
                        da.Update(ds, "a_bankbranches")
                        bankbranches.Cursor = Cursors.Arrow
                        home.ToolStripProgressBar1.Visible = False
                        MsgBox("Data of '" & v1 & "' is deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                End If
            End If
        Next
      
    End Sub

    Public Function giveno() As String
        Dim strbrhno As String
        Dim intlastno As Integer
        da = New OleDbDataAdapter("SELECT Branchno FROM a_bankbranches ORDER BY Branchid DESC", objConn1)
        ds = New DataSet("B_dataset2")
        da.Fill(ds, "a_bankbranches")
        total_rows = ds.Tables("a_bankbranches").Rows().Count - 1
        For i = 0 To total_rows
            If ds.Tables("a_bankbranches").Rows(i).Item("Branchno") = "" Then
                Return "BRH-000001"
            Else
                strbrhno = ds.Tables("a_bankbranches").Rows(i).Item("Branchno").ToString()
                intlastno = Integer.Parse(strbrhno.Substring(4, 6)) + 1
                Return "BRH-" + intlastno.ToString("000000")
            End If
        Next
        Return "BRH-000001"
    End Function
    Public Sub loadbank()
        da = New OleDbDataAdapter("SELECT * FROM a_bank", objConn1)
        ds = New DataSet("B_Dataset2")
        da.Fill(ds, "a_bank")
        Dim up As String
        total_rows = ds.Tables("a_bank").Rows().Count - 1
        For i = 0 To total_rows
            bankprofile.txtbankname.Text = ds.Tables("a_bank").Rows(i).Item("Bankname").ToString
            bankprofile.txtemail.Text = ds.Tables("a_bank").Rows(i).Item("Email").ToString
            bankprofile.txtwebsite.Text = ds.Tables("a_bank").Rows(i).Item("Website").ToString
            bankprofile.txtslogan.Text = ds.Tables("a_bank").Rows(i).Item("Slogan").ToString
            up = ds.Tables("a_bank").Rows(i).Item("Logo").ToString
            If up <> "" Then
                bankprofile.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & up)
            End If
        Next
    End Sub

    Public Sub loadlistbank()
        da = New OleDbDataAdapter("SELECT * FROM a_bankbranches", objConn1)
        ds = New DataSet("B_Dataset2")
        da.Fill(ds, "a_bankbranches")
        total_rows = ds.Tables("a_bankbranches").Rows.Count - 1
        For i = 0 To total_rows
            bankbranches.ListBox1.Items.Add(ds.Tables("a_bankbranches").Rows(i).Item("Branchno"))
        Next
    End Sub

    Public Sub loadlistbank1(ByVal v1 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_bankbranches", objConn1)
        ds = New DataSet("B_Dataset2")
        da.Fill(ds, "a_bankbranches")
        Dim up As String
        total_rows = ds.Tables("a_bankbranches").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_bankbranches").Rows(i).Item("Branchno") Then
                bankbranches.txtbranchno.Text = ds.Tables("a_bankbranches").Rows(i).Item("Branchno").ToString
                bankbranches.txtbranchname.Text = ds.Tables("a_bankbranches").Rows(i).Item("Branchname").ToString
                bankbranches.txtph1.Text = ds.Tables("a_bankbranches").Rows(i).Item("Phoneno1").ToString
                bankbranches.txtph2.Text = ds.Tables("a_bankbranches").Rows(i).Item("Phoneno2").ToString
                bankbranches.txtfax1.Text = ds.Tables("a_bankbranches").Rows(i).Item("Faxno1").ToString
                bankbranches.txtfax2.Text = ds.Tables("a_bankbranches").Rows(i).Item("Faxno2").ToString
                bankbranches.txtpobox.Text = ds.Tables("a_bankbranches").Rows(i).Item("PoBox").ToString
                bankbranches.txtweb.Text = ds.Tables("a_bankbranches").Rows(i).Item("Website").ToString
                bankbranches.txtcity.Text = ds.Tables("a_bankbranches").Rows(i).Item("City").ToString
                bankbranches.txtcountry.Text = ds.Tables("a_bankbranches").Rows(i).Item("Country").ToString
                bankbranches.txtaddress.Text = ds.Tables("a_bankbranches").Rows(i).Item("Address").ToString
                up = ds.Tables("a_bankbranches").Rows(i).Item("logo").ToString
                If up <> "" Then
                    bankbranches.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & up)
                End If
            End If
        Next
    End Sub


    Public Function matchabnk() As Boolean
        count = 0
        da = New OleDbDataAdapter("SELECT * FROM a_bank", objConn1)
        ds = New DataSet("B_Dataset2")
        da.Fill(ds, "a_bank")

        total_rows = ds.Tables("a_bank").Rows().Count - 1
        For i = 0 To total_rows
            count = count + 1
        Next

        If count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class




