Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_transaction
    Dim ds, ds1, ds2, ds3 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da, da1, da2, da3 As OleDbDataAdapter

    Dim total_rows, i, count, total_rows1, j, z As Long
    Dim td, id, cr, mm, pm, at, p1, p2, tdt As String
    Dim ch As Boolean
    Public Sub insertdata(ByVal v1 As Date, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String, ByVal v6 As String, ByVal v7 As Date, ByVal v8 As String, ByVal che As String, ByVal v9 As String)
        newtransaction.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_transactions", objConn1)
        ds = New DataSet("B_DataSet4")
        da.Fill(ds, "a_transactions")

        da.InsertCommand = New OleDbCommand("INSERT INTO a_transactions (Transactionsdate,Paymentmethod ,Checknumber,Accountno,Amount,Transactionsmode,Datedcleared,Particulars) Values(@Transactionsdate,@Paymentmethod ,@Checknumber,@Accountno,@Amount,@Transactionsmode,@Datedcleared,@Particulars)", objConn1)
        da.InsertCommand.CommandType = CommandType.Text

        da.InsertCommand.Parameters.Add("@Transactionsdate", System.Data.OleDb.OleDbType.Date, 50, "Transactionsdate")
        da.InsertCommand.Parameters.Add("@Paymentmethod", System.Data.OleDb.OleDbType.Char, 50, "Paymentmethod")
        da.InsertCommand.Parameters.Add("@Checknumber", System.Data.OleDb.OleDbType.Char, 50, "Checknumber")
        da.InsertCommand.Parameters.Add("@Accountno", System.Data.OleDb.OleDbType.Char, 50, "Accountno")
        da.InsertCommand.Parameters.Add("@Amount", System.Data.OleDb.OleDbType.Char, 50, "Amount")
        da.InsertCommand.Parameters.Add("@Transactionsmode", System.Data.OleDb.OleDbType.Char, 50, "Transactionsmode")
        da.InsertCommand.Parameters.Add("@Datedcleared", System.Data.OleDb.OleDbType.Date, 50, "Datedcleared")
        da.InsertCommand.Parameters.Add("@Particulars", System.Data.OleDb.OleDbType.Char, 50, "Particulars")

        Dim dr As DataRow = ds.Tables("a_transactions").NewRow()

        dr("Transactionsdate") = v1
        dr("Paymentmethod") = v2

        If che = 1 Then
            dr("Checknumber") = v3
        Else
            dr("Checknumber") = " "
        End If
        dr("Accountno") = v4
        dr("Amount") = v5
        dr("Transactionsmode") = v6
        dr("Datedcleared") = v7
        dr("Particulars") = v8
        ds.Tables("a_transactions").Rows.Add(dr)
        da.Update(ds, "a_transactions")

        da2 = New OleDbDataAdapter("select * from a_transactiondetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transactiondetails")

        da2.InsertCommand = New OleDbCommand("INSERT INTO a_transactiondetails (transactionid,status) Values(@transactionid,@status)", objConn1)
        da2.InsertCommand.CommandType = CommandType.Text

        da2.InsertCommand.Parameters.Add("@transactionid", OleDbType.Integer, 5, "transactionid")
        da2.InsertCommand.Parameters.Add("@status", OleDbType.Boolean, 50, "status")

        Dim dr2 As DataRow = ds2.Tables("a_transactiondetails").NewRow()

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
            If v1 = td And v4 = id And v5 = cr And v2 = pm And v6 = mm Then
                count = ds1.Tables("a_transactions").Rows(i).Item("Transactionsid")
            End If
        Next

        dr2("Transactionid") = count
        dr2("status") = v9
        ds2.Tables("a_transactiondetails").Rows.Add(dr2)
        Try
            da2.Update(ds2, "a_transactiondetails")
            newtransaction.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Transaction made successfully....", MsgBoxStyle.Information)
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
            maketransaction.ListBox1.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub

    Public Sub loadaccdata(ByVal v1 As String)
        newtransaction.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                maketransaction.txtaccno.Text = ds.Tables("a_accounts").Rows(i).Item("Accountno").ToString
                maketransaction.txtacctype.Text = ds.Tables("a_accounts").Rows(i).Item("Holderaccounttype").ToString
                maketransaction.txtcstno.Text = ds.Tables("a_accounts").Rows(i).Item("Customerno").ToString
                maketransaction.txtaccname.Text = ds.Tables("a_accounts").Rows(i).Item("Accountname").ToString
                id = ds.Tables("a_accounts").Rows(i).Item("Accounttypeid").ToString
                da1 = New OleDbDataAdapter("SELECT * FROM a_accounttype", objConn1)
                ds1 = New DataSet("B_DataSet3")
                da1.Fill(ds1, "a_accounttype")
                total_rows1 = ds1.Tables("a_accounttype").Rows.Count - 1
                For j = 0 To total_rows1
                    If id = ds1.Tables("a_accounttype").Rows(j).Item("Accounttypeid") Then
                        maketransaction.txtacc.Text = ds1.Tables("a_accounttype").Rows(j).Item("Accounttype")
                    End If
                Next
                maketransaction.txtcurr.Text = ds.Tables("a_accounts").Rows(i).Item("Currencytype").ToString
                maketransaction.txtbal.Text = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
            End If
        Next
        da2 = New OleDbDataAdapter("SELECT * FROM a_customer", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_customer")
        total_rows = ds2.Tables("a_customer").Rows.Count - 1
        For i = 0 To total_rows
            If maketransaction.txtcstno.Text = ds2.Tables("a_customer").Rows(i).Item("Customerno") Then
                maketransaction.txtfname.Text = ds2.Tables("a_customer").Rows(i).Item("Fullname").ToString
                maketransaction.txtgender.Text = ds2.Tables("a_customer").Rows(i).Item("Gender").ToString
                maketransaction.txtoffno.Text = ds2.Tables("a_customer").Rows(i).Item("Officephone").ToString
                maketransaction.txtmono.Text = ds2.Tables("a_customer").Rows(i).Item("Mobilephone").ToString
                maketransaction.txtmail.Text = ds2.Tables("a_customer").Rows(i).Item("Email").ToString
                p1 = ds2.Tables("a_customer").Rows(i).Item("Digitalsign").ToString
                If p1 <> "" Then
                    maketransaction.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & p1)
                End If
                p2 = ds2.Tables("a_customer").Rows(i).Item("Picture").ToString
                If p2 <> "" Then
                    maketransaction.PictureBox2.Image = Image.FromFile(Application.StartupPath & "\resources\" & p2)
                End If
            End If
        Next

        da2 = New OleDbDataAdapter("SELECT * FROM a_transactiondetails", objConn1)
        ds2 = New DataSet("B_DataSet4")
        da2.Fill(ds2, "a_transactiondetails")
        total_rows = ds2.Tables("a_transactiondetails").Rows.Count - 1

        da3 = New OleDbDataAdapter("SELECT * FROM a_transactions ORDER BY Transactionsid DESC", objConn1)
        ds3 = New DataSet("B_DataSet4")
        da3.Fill(ds3, "a_transactions")
        total_rows1 = ds3.Tables("a_transactions").Rows.Count - 1
        maketransaction.DataGridView1.Rows.Clear()
        z = 0
        For j = 0 To total_rows1
            If v1 = ds3.Tables("a_transactions").Rows(j).Item("Accountno") Then

                maketransaction.DataGridView1.Rows.Add()
                maketransaction.DataGridView1.Rows(z).Cells(0).Value = Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy")
                maketransaction.DataGridView1.Rows(z).Cells(1).Value = ds3.Tables("a_transactions").Rows(j).Item("Paymentmethod").ToString
                maketransaction.DataGridView1.Rows(z).Cells(2).Value = ds3.Tables("a_transactions").Rows(j).Item("Checknumber").ToString
                maketransaction.DataGridView1.Rows(z).Cells(3).Value = ds3.Tables("a_transactions").Rows(j).Item("Particulars").ToString
                tdt = ds3.Tables("a_transactions").Rows(j).Item("Transactionsmode").ToString
                If tdt = "Credit" Then
                    maketransaction.DataGridView1.Rows(z).Cells(4).Value = ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString
                ElseIf tdt = "Debit" Then
                    maketransaction.DataGridView1.Rows(z).Cells(5).Value = ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString
                End If
                id = ds3.Tables("a_transactions").Rows(j).Item("Transactionsid").ToString

                For i = 0 To total_rows
                    If id = ds2.Tables("a_transactiondetails").Rows(i).Item("Transactionid") Then
                        maketransaction.DataGridView1.Rows(z).Cells(6).Value = ds2.Tables("a_transactiondetails").Rows(i).Item("Status").ToString
                    End If
                Next
                z = z + 1
            End If
        Next
        newtransaction.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub

    Public Function amountvalid(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                pm = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
                td = ds.Tables("a_accounts").Rows(i).Item("Accounttypeid").ToString
            End If
        Next
        Dim longs, cat As Long
        longs = CLng(pm)
        cat = CLng(v2)

        If v3 = "Credit" Then
            longs = longs + cat
        ElseIf v3 = "Debit" Then
            longs = longs - cat
        End If

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
            Dim com As New OleDbCommand("Update a_accounts set Balance='" & pm & "' where Accountno='" & v1 & "'", objConn1)
            objConn1.Open()
            com.ExecuteNonQuery()
            objConn1.Close()
            Return True
        Else
            MsgBox("you don't have enough Balance in " & v1 & " account." & (Chr(13)) & " you must have more than " & at & " Rupee ", MsgBoxStyle.Information)
            Return False
        End If
    End Function
End Class
