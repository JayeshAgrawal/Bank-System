Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_transfer
    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da, da1, da2 As OleDbDataAdapter

    Dim total_rows, i, count, total_rows1, j, z As Long
    Dim td, id, cr, mm, pm, p1, p2, at As String
    Public Sub insertdata(ByVal v1 As Date, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String)
        transfer.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds = New DataSet("B_DataSet4")
        da.Fill(ds, "a_transactions")

        da.InsertCommand = New OleDbCommand("INSERT INTO a_transactions (Transactionsdate,Paymentmethod ,Accountno,Amount,Transactionsmode,Datedcleared,Particulars) Values(@Transactionsdate,@Paymentmethod ,@Accountno,@Amount,@Transactionsmode,@Datedcleared,@Particulars)", objConn1)
        da.InsertCommand.CommandType = CommandType.Text

        da.InsertCommand.Parameters.Add("@Transactionsdate", System.Data.OleDb.OleDbType.Date, 50, "Transactionsdate")
        da.InsertCommand.Parameters.Add("@Paymentmethod", System.Data.OleDb.OleDbType.Char, 50, "Paymentmethod")
        da.InsertCommand.Parameters.Add("@Accountno", System.Data.OleDb.OleDbType.Char, 50, "Accountno")
        da.InsertCommand.Parameters.Add("@Amount", System.Data.OleDb.OleDbType.Char, 50, "Amount")
        da.InsertCommand.Parameters.Add("@Transactionsmode", System.Data.OleDb.OleDbType.Char, 50, "Transactionsmode")
        da.InsertCommand.Parameters.Add("@Datedcleared", System.Data.OleDb.OleDbType.Date, 50, "Datedcleared")
        da.InsertCommand.Parameters.Add("@Particulars", System.Data.OleDb.OleDbType.Char, 50, "Particulars")


        Dim dr As DataRow = ds.Tables("a_transactions").NewRow()

        Dim vp As String = "TRANSFER"
        Dim vm As String = "Debit"
        Dim pt As String = "To acc " & v4

        dr("Transactionsdate") = v1
        dr("Paymentmethod") = vp
        dr("Accountno") = v2
        dr("Amount") = v3
        dr("Transactionsmode") = vm
        dr("Datedcleared") = v1
        dr("Particulars") = pt

        ds.Tables("a_transactions").Rows.Add(dr)
        da.Update(ds, "a_transactions")

        da2 = New OleDbDataAdapter("select * from a_transferdetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transferdetails")

        da2.InsertCommand = New OleDbCommand("INSERT INTO a_transferdetails (Transactionid,Toaccountno,status) Values(@Transactionid,@Toaccountno,@status)", objConn1)
        da2.InsertCommand.CommandType = CommandType.Text

        da2.InsertCommand.Parameters.Add("@Transactionid", OleDbType.Integer, 5, "Transactionid")
        da2.InsertCommand.Parameters.Add("@Toaccountno", OleDbType.Char, 50, "Toaccountno")
        da2.InsertCommand.Parameters.Add("@status", OleDbType.Boolean, 50, "status")

        Dim dr2 As DataRow = ds2.Tables("a_transferdetails").NewRow()

        da1 = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds1 = New DataSet("B_DataSet4")
        da1.Fill(ds1, "a_transactions")
        total_rows = ds1.Tables("a_transactions").Rows.Count - 1

        For i = 0 To total_rows
            td = ds1.Tables("a_transactions").Rows(i).Item("Transactionsdate").ToString
            id = ds1.Tables("a_transactions").Rows(i).Item("Accountno").ToString
            cr = ds1.Tables("a_transactions").Rows(i).Item("Amount").ToString
            mm = ds1.Tables("a_transactions").Rows(i).Item("Transactionsmode").ToString
            pm = ds1.Tables("a_transactions").Rows(i).Item("Paymentmethod").ToString
            If v1 = td And v2 = id And v3 = cr And vp = pm And vm = mm Then
                count = ds1.Tables("a_transactions").Rows(i).Item("Transactionsid")
            End If
        Next
        dr2("Transactionid") = count
        dr2("Toaccountno") = v4
        dr2("status") = True

        ds2.Tables("a_transferdetails").Rows.Add(dr2)
        da2.Update(ds2, "a_transferdetails")


        da = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds = New DataSet("B_DataSet4")
        da.Fill(ds, "a_transactions")

        da.InsertCommand = New OleDbCommand("INSERT INTO a_transactions (Transactionsdate,Paymentmethod ,Accountno,Amount,Transactionsmode,Datedcleared,Particulars) Values(@Transactionsdate,@Paymentmethod ,@Accountno,@Amount,@Transactionsmode,@Datedcleared,@Particulars)", objConn1)
        da.InsertCommand.CommandType = CommandType.Text

        da.InsertCommand.Parameters.Add("@Transactionsdate", System.Data.OleDb.OleDbType.Date, 50, "Transactionsdate")
        da.InsertCommand.Parameters.Add("@Paymentmethod", System.Data.OleDb.OleDbType.Char, 50, "Paymentmethod")
        da.InsertCommand.Parameters.Add("@Accountno", System.Data.OleDb.OleDbType.Char, 50, "Accountno")
        da.InsertCommand.Parameters.Add("@Amount", System.Data.OleDb.OleDbType.Char, 50, "Amount")
        da.InsertCommand.Parameters.Add("@Transactionsmode", System.Data.OleDb.OleDbType.Char, 50, "Transactionsmode")
        da.InsertCommand.Parameters.Add("@Datedcleared", System.Data.OleDb.OleDbType.Date, 50, "Datedcleared")
        da.InsertCommand.Parameters.Add("@Particulars", System.Data.OleDb.OleDbType.Char, 50, "Particulars")

        Dim dr3 As DataRow = ds.Tables("a_transactions").NewRow()

        vp = "TRANSFER"
        vm = "Credit"
        pt = "From acc " & v2

        dr3("Transactionsdate") = v1
        dr3("Paymentmethod") = vp
        dr3("Accountno") = v4
        dr3("Amount") = v3
        dr3("Transactionsmode") = vm
        dr3("Datedcleared") = v1
        dr3("Particulars") = pt

        ds.Tables("a_transactions").Rows.Add(dr3)
        da.Update(ds, "a_transactions")

        da2 = New OleDbDataAdapter("select * from a_transactiondetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transactiondetails")

        da2.InsertCommand = New OleDbCommand("INSERT INTO a_transactiondetails (transactionid,status) Values(@transactionid,@status)", objConn1)
        da2.InsertCommand.CommandType = CommandType.Text

        da2.InsertCommand.Parameters.Add("@transactionid", OleDbType.Integer, 5, "transactionid")
        da2.InsertCommand.Parameters.Add("@status", OleDbType.Boolean, 50, "status")

        Dim dr4 As DataRow = ds2.Tables("a_transactiondetails").NewRow()

        da1 = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds1 = New DataSet("B_DataSet4")
        da1.Fill(ds1, "a_transactions")

        total_rows = ds1.Tables("a_transactions").Rows.Count - 1

        For i = 0 To total_rows
            td = ds1.Tables("a_transactions").Rows(i).Item("Transactionsdate").ToString
            id = ds1.Tables("a_transactions").Rows(i).Item("Accountno").ToString
            cr = ds1.Tables("a_transactions").Rows(i).Item("Amount").ToString
            mm = ds1.Tables("a_transactions").Rows(i).Item("Transactionsmode").ToString
            pm = ds1.Tables("a_transactions").Rows(i).Item("Paymentmethod").ToString
            If v1 = td And v2 = id And v3 = cr And vp = pm And vm = mm Then
                count = ds1.Tables("a_transactions").Rows(i).Item("Transactionsid")
            End If
        Next

        dr4("Transactionid") = count
        dr4("status") = True

        ds2.Tables("a_transactiondetails").Rows.Add(dr4)
        da2.Update(ds2, "a_transactiondetails")


        da2 = New OleDbDataAdapter("select * from a_transactiondetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transactiondetails")

        da2.InsertCommand = New OleDbCommand("INSERT INTO a_transactiondetails (transactionid,status) Values(@transactionid,@status)", objConn1)
        da2.InsertCommand.CommandType = CommandType.Text

        da2.InsertCommand.Parameters.Add("@transactionid", OleDbType.Integer, 5, "transactionid")
        da2.InsertCommand.Parameters.Add("@status", OleDbType.Boolean, 50, "status")

        Dim dr5 As DataRow = ds2.Tables("a_transactiondetails").NewRow()

        da1 = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds1 = New DataSet("B_DataSet4")
        da1.Fill(ds1, "a_transactions")

        total_rows = ds1.Tables("a_transactions").Rows.Count - 1

        For i = 0 To total_rows
            td = ds1.Tables("a_transactions").Rows(i).Item("Transactionsdate").ToString
            id = ds1.Tables("a_transactions").Rows(i).Item("Accountno").ToString
            cr = ds1.Tables("a_transactions").Rows(i).Item("Amount").ToString
            mm = ds1.Tables("a_transactions").Rows(i).Item("Transactionsmode").ToString
            pm = ds1.Tables("a_transactions").Rows(i).Item("Paymentmethod").ToString
            If v1 = td And v4 = id And v3 = cr And vp = pm And vm = mm Then
                count = ds1.Tables("a_transactions").Rows(i).Item("Transactionsid")
            End If
        Next

        dr5("Transactionid") = count
        dr5("status") = True

        ds2.Tables("a_transactiondetails").Rows.Add(dr5)
        Try
            da2.Update(ds2, "a_transactiondetails")
            transfer.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Transfer made successfully....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub loadacclist()
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            internaltransfer.ListBox1.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub


    Public Sub loadaccdata(ByVal v1 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                internaltransfer.txtaccno.Text = ds.Tables("a_accounts").Rows(i).Item("Accountno").ToString
                internaltransfer.txtacctype.Text = ds.Tables("a_accounts").Rows(i).Item("Holderaccounttype").ToString
                internaltransfer.txtcstno.Text = ds.Tables("a_accounts").Rows(i).Item("Customerno").ToString
                internaltransfer.txtaccname.Text = ds.Tables("a_accounts").Rows(i).Item("Accountname").ToString
                id = ds.Tables("a_accounts").Rows(i).Item("Accounttypeid").ToString
                da1 = New OleDbDataAdapter("SELECT * FROM a_accounttype", objConn1)
                ds1 = New DataSet("B_DataSet3")
                da1.Fill(ds1, "a_accounttype")
                total_rows1 = ds1.Tables("a_accounttype").Rows.Count - 1
                For j = 0 To total_rows1
                    If id = ds1.Tables("a_accounttype").Rows(j).Item("Accounttypeid") Then
                        internaltransfer.txtacc.Text = ds1.Tables("a_accounttype").Rows(j).Item("Accounttype")
                    End If
                Next
                internaltransfer.txtcurr.Text = ds.Tables("a_accounts").Rows(i).Item("Currencytype").ToString
                internaltransfer.txtbal.Text = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
            End If
        Next
        da2 = New OleDbDataAdapter("SELECT * FROM a_customer", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_customer")
        total_rows = ds2.Tables("a_customer").Rows.Count - 1
        For i = 0 To total_rows
            If internaltransfer.txtcstno.Text = ds2.Tables("a_customer").Rows(i).Item("Customerno") Then
                internaltransfer.txtfname.Text = ds2.Tables("a_customer").Rows(i).Item("Fullname").ToString
                internaltransfer.txtgender.Text = ds2.Tables("a_customer").Rows(i).Item("Gender").ToString
                internaltransfer.txtoffno.Text = ds2.Tables("a_customer").Rows(i).Item("Officephone").ToString
                internaltransfer.txtmono.Text = ds2.Tables("a_customer").Rows(i).Item("Mobilephone").ToString
                internaltransfer.txtmail.Text = ds2.Tables("a_customer").Rows(i).Item("Email").ToString
                p1 = ds2.Tables("a_customer").Rows(i).Item("Digitalsign").ToString
                If p1 <> "" Then
                    internaltransfer.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & p1)
                End If
                p2 = ds2.Tables("a_customer").Rows(i).Item("Picture").ToString
                If p2 <> "" Then
                    internaltransfer.PictureBox2.Image = Image.FromFile(Application.StartupPath & "\resources\" & p2)
                End If
            End If
        Next

        da = New OleDbDataAdapter("SELECT * FROM a_transactions", objConn1)
        ds = New DataSet("B_DataSet4")
        da.Fill(ds, "a_transactions")
        total_rows1 = ds.Tables("a_transactions").Rows.Count - 1

        da2 = New OleDbDataAdapter("SELECT * FROM a_transferdetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transferdetails")
        total_rows = ds2.Tables("a_transferdetails").Rows.Count - 1
        z = 0
        internaltransfer.DataGridView1.Rows.Clear()
        For i = total_rows To 0 Step -1
            id = ds2.Tables("a_transferdetails").Rows(i).Item("Transactionid").ToString
            For j = 0 To total_rows1
                If v1 = ds.Tables("a_transactions").Rows(j).Item("Accountno").ToString And id = ds.Tables("a_transactions").Rows(j).Item("Transactionsid").ToString Then
                    internaltransfer.DataGridView1.Rows.Add()
                    internaltransfer.DataGridView1.Rows(z).Cells(0).Value = Format(CDate(ds.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy")
                    internaltransfer.DataGridView1.Rows(z).Cells(2).Value = ds.Tables("a_transactions").Rows(j).Item("Amount").ToString

                    internaltransfer.DataGridView1.Rows(z).Cells(1).Value = ds2.Tables("a_transferdetails").Rows(i).Item("Toaccountno").ToString
                    internaltransfer.DataGridView1.Rows(z).Cells(3).Value = ds2.Tables("a_transferdetails").Rows(i).Item("Status").ToString
                    z = z + 1
                End If
            Next
        Next
    End Sub


    Public Sub toacclist(ByVal v1 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_accounts WHERE Not Accountno ='" & v1 & "'", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            transfer.ComboBox1.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub
    Public Function amountvalid(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            If v2 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                pm = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
                td = ds.Tables("a_accounts").Rows(i).Item("Accounttypeid").ToString
            End If
        Next
        Dim longs, cat As Long
        longs = CLng(pm)
        cat = CLng(v1)

        longs = longs - cat

        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")
        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            If td = ds1.Tables("a_accounttype").Rows(i).Item("Accounttypeid") Then
                at = ds1.Tables("a_accounttype").Rows(i).Item("Minimumbalance").ToString
            End If
        Next
        Dim tr As Long
        tr = CLng(at)

        If tr < longs Then
            pm = longs.ToString
            Dim com As New OleDbCommand("Update a_accounts set Balance='" & pm & "' where Accountno='" & v2 & "'", objConn1)
            objConn1.Open()
            com.ExecuteNonQuery()
            objConn1.Close()
            da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
            ds = New DataSet("B_DataSet3")
            da.Fill(ds, "a_accounts")
            total_rows = ds.Tables("a_accounts").Rows.Count - 1
            For i = 0 To total_rows
                If v3 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                    pm = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
                End If
            Next
            longs = CLng(pm)
            cat = CLng(v1)
            longs = longs + cat
            pm = longs.ToString

            Dim com1 As New OleDbCommand("Update a_accounts set Balance='" & pm & "' where Accountno='" & v3 & "'", objConn1)
            objConn1.Open()
            com1.ExecuteNonQuery()
            objConn1.Close()

            Return True
        Else
            MsgBox("you don't have enough Balance in " & v2 & " account." & (Chr(13)) & " you must have more than " & at & " Rupee ", MsgBoxStyle.Information)
            Return False
        End If

    End Function
End Class
