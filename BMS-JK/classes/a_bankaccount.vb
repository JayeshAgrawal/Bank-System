Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb

Public Class a_bankaccount
    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da1, da, da2 As OleDbDataAdapter

    Dim total_rows, i, j, count As Long
    Dim at As String

    Public Sub enteracctype(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String)
        accounttype.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_accounttype (Accounttype,Minimumbalance,Rate,Description) Values(@Accounttype,@Minimumbalance,@Rate,@Description)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Accounttype", OleDbType.Char, 50, "Accounttype")
        da1.InsertCommand.Parameters.Add("@Minimumbalance", OleDbType.Char, 50, "Minimumbalance")
        da1.InsertCommand.Parameters.Add("@Rate", OleDbType.Char, 50, "Rate")
        da1.InsertCommand.Parameters.Add("@Description", OleDbType.Char, 50, "Description")

        Dim dr1 As DataRow = ds1.Tables("a_accounttype").NewRow()

        dr1("Accounttype") = v1
        dr1("Minimumbalance") = v2
        dr1("Rate") = v3
        dr1("Description") = v4

        ds1.Tables("a_accounttype").Rows.Add(dr1)

        Try
            da1.Update(ds1, "a_accounttype")
            accounttype.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
       
    End Sub
    Public Sub updateacctype(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String)
        accounttype.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounttype")
        da.UpdateCommand = New OleDbCommand("UPDATE a_accounttype SET Accounttype=@Accounttype, Minimumbalance=@Minimumbalance,Rate=@Rate,Description=@Description Where (Accounttype='" & v1 & "')", objConn1)
        da.UpdateCommand.CommandType = CommandType.Text

        da.UpdateCommand.Parameters.Add("@Accounttype", OleDbType.Char, 50, "Accounttype")
        da.UpdateCommand.Parameters.Add("@Minimumbalance", OleDbType.Char, 50, "Minimumbalance")
        da.UpdateCommand.Parameters.Add("@Rate", OleDbType.Char, 50, "Rate")
        da.UpdateCommand.Parameters.Add("@Description", OleDbType.Char, 50, "Description")

        ds.Tables("a_accounttype").Rows(0).Item("Accounttype") = v2
        ds.Tables("a_accounttype").Rows(0).Item("Minimumbalance") = v3
        ds.Tables("a_accounttype").Rows(0).Item("Rate") = v4
        ds.Tables("a_accounttype").Rows(0).Item("Description") = v5

        Try
            da.Update(ds, "a_accounttype")
            accounttype.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is UpDateed....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
     
    End Sub
    Public Sub deleteacctype(ByVal v1 As String)
        accounttype.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da2 = New OleDbDataAdapter("select * from  a_accounttype", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_accounttype")

        da2.DeleteCommand = New OleDbCommand("DELETE FROM  a_accounttype WHERE (Accounttype='" & v1 & "')", objConn1)
        da2.DeleteCommand.CommandType = CommandType.Text
        da2.DeleteCommand.Parameters.Add("@Accounttype", OleDb.OleDbType.Char, 255, "Accounttype")


        total_rows = ds2.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            at = ds2.Tables("a_accounttype").Rows(i).Item("Accounttype")

            If v1 = at Then
                If MsgBox("Are you sure ? " & (Chr(13)) & "Delete " & v1, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    ds2.Tables("a_accounttype").Rows(i).Delete()
                    i = total_rows + 1
                    Try
                        da2.Update(ds2, "a_accounttype")
                        accounttype.Cursor = Cursors.Arrow
                        home.ToolStripProgressBar1.Visible = False
                        MsgBox("Data of '" & v1 & "' is deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                End If
            End If
        Next
      
    End Sub
    Public Sub loadacctype()
        accounttype.ListBox1.Items.Clear()
        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")

        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            accounttype.ListBox1.Items.Add(ds1.Tables("a_accounttype").Rows(i).Item("Accounttype"))
        Next
    End Sub

    Public Sub fillacctype(ByVal v1 As String)
        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")

        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            at = ds1.Tables("a_accounttype").Rows(i).Item("Accounttype")
            If v1 = at Then
                accounttype.txtaccounttype.Text = ds1.Tables("a_accounttype").Rows(i).Item("Accounttype")
                accounttype.txtminibal.Text = ds1.Tables("a_accounttype").Rows(i).Item("Minimumbalance")
                accounttype.txtineterestrate.Text = ds1.Tables("a_accounttype").Rows(i).Item("Rate")
                accounttype.txtdescription.Text = ds1.Tables("a_accounttype").Rows(i).Item("Description")
            End If
        Next
    End Sub

    
    Public Sub enterbankacc(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String, ByVal v6 As String, ByVal v7 As String, ByVal v8 As Date, ByVal v9 As String)
        bankaccounts.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_accounts", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounts")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_accounts (Accountno,Accountname,Holderaccounttype,Customerno,Accounttypeid,Currencytype,Initialdeposit,Balance,Dateopened) Values(@Accountno,@Accountname,@Holderaccounttype,@Customerno,@Accounttypeid,@Currencytype,@Initialdeposit,@Balance,@Dateopened)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Accountno", OleDbType.Char, 50, "Accountno")
        da1.InsertCommand.Parameters.Add("@Accountname", OleDbType.Char, 50, "Accountname")
        da1.InsertCommand.Parameters.Add("@Holderaccounttype", OleDbType.Char, 50, "Holderaccounttype")
        da1.InsertCommand.Parameters.Add("@Customerno", OleDbType.Char, 50, "Customerno")
        da1.InsertCommand.Parameters.Add("@Accounttypeid", OleDbType.Char, 50, "Accounttypeid")
        da1.InsertCommand.Parameters.Add("@Currencytype", OleDbType.Char, 50, "Currencytype")
        da1.InsertCommand.Parameters.Add("@Initialdeposit", OleDbType.Char, 50, "Initialdeposit")
        da1.InsertCommand.Parameters.Add("@Balance", OleDbType.Char, 50, "Balance")
        da1.InsertCommand.Parameters.Add("@Dateopened", OleDbType.Date, 50, "Dateopened")

        Dim dr1 As DataRow = ds1.Tables("a_accounts").NewRow()

        dr1("Accountno") = v1
        dr1("Accountname") = v2
        dr1("Holderaccounttype") = v3
        dr1("Customerno") = v9

        da = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_accounttype")

        total_rows = ds.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            at = ds.Tables("a_accounttype").Rows(i).Item("Accounttype")
            If v4 = at Then
                count = ds.Tables("a_accounttype").Rows(i).Item("Accounttypeid")
            End If
        Next

        dr1("Accounttypeid") = count
        dr1("Currencytype") = v5
        dr1("Initialdeposit") = v6
        dr1("Balance") = v7
        dr1("Dateopened") = v8

        ds1.Tables("a_accounts").Rows.Add(dr1)

        Try
            da1.Update(ds1, "a_accounts")
            bankaccounts.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Account is opened successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub updatebankacc(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String)
        bankaccounts.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_accounts", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_accounts")
        da.UpdateCommand = New OleDbCommand("UPDATE a_accounts SET Accountname=@Accountname, Holderaccounttype=@Holderaccounttype,Accounttypeid=@Accounttypeid,Currencytype=@Currencytype Where (Accountno='" & v1 & "')", objConn1)
        da.UpdateCommand.CommandType = CommandType.Text

        da.UpdateCommand.Parameters.Add("@Accountname", OleDbType.Char, 50, "Accountname")
        da.UpdateCommand.Parameters.Add("@Holderaccounttype", OleDbType.Char, 50, "Holderaccounttype")
        da.UpdateCommand.Parameters.Add("@Accounttypeid", OleDbType.Char, 50, "Accounttypeid")
        da.UpdateCommand.Parameters.Add("@Currencytype", OleDbType.Char, 50, "Currencytype")

        ds.Tables("a_accounts").Rows(0).Item("Accountname") = v2
        ds.Tables("a_accounts").Rows(0).Item("Holderaccounttype") = v3

        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_accounttype")

        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            at = ds1.Tables("a_accounttype").Rows(i).Item("Accounttype")
            If v4 = at Then
                count = ds1.Tables("a_accounttype").Rows(i).Item("Accounttypeid")
            End If
        Next

        ds.Tables("a_accounts").Rows(0).Item("Accounttypeid") = count
        ds.Tables("a_accounts").Rows(0).Item("Currencytype") = v5

        Try
            da.Update(ds, "a_accounts")
            bankaccounts.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Account is UpDateed....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub


    Public Sub deletebankacc(ByVal v1 As String)
        bankaccounts.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da2 = New OleDbDataAdapter("select * from  a_accounts", objConn1)
        ds2 = New DataSet("B_DataSet3")
        da2.Fill(ds2, "a_accounts")

        da2.DeleteCommand = New OleDbCommand("DELETE FROM  a_accounts WHERE (Accountno='" & v1 & "')", objConn1)
        da2.DeleteCommand.CommandType = CommandType.Text
        da2.DeleteCommand.Parameters.Add("@Accountno", OleDb.OleDbType.Char, 255, "Accountno")


        total_rows = ds2.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            at = ds2.Tables("a_accounts").Rows(i).Item("Accountno")

            If v1 = at Then
                If MsgBox("Are you sure ? " & (Chr(13)) & "Delete " & v1, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    ds2.Tables("a_accounts").Rows(i).Delete()
                    i = total_rows + 1
                    Try
                        da2.Update(ds2, "a_accounts")
                        bankaccounts.Cursor = Cursors.Arrow
                        home.ToolStripProgressBar1.Visible = False
                        MsgBox("Data of '" & v1 & "' is deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                End If
            End If
        Next
    
    End Sub

    Public Sub newchequebook(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String)
        chequebooks.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_Chequebooks", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_Chequebooks")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_Chequebooks (Chequebookno,Accountno,Dateissued,Startno,Endno) Values(@Chequebookno,@Accountno,@Dateissued,@Startno,@Endno)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Chequebookno", OleDbType.Char, 50, "Chequebookno")
        da1.InsertCommand.Parameters.Add("@Accountno", OleDbType.Char, 50, "Accountno")
        da1.InsertCommand.Parameters.Add("@Dateissued", OleDbType.Char, 50, "Dateissued")
        da1.InsertCommand.Parameters.Add("@Startno", OleDbType.Char, 50, "Startno")
        da1.InsertCommand.Parameters.Add("@Endno", OleDbType.Char, 50, "Endno")

        Dim dr1 As DataRow = ds1.Tables("a_Chequebooks").NewRow()

        dr1("Chequebookno") = v1
        dr1("Accountno") = v2
        dr1("Dateissued") = v3
        dr1("Startno") = v4
        dr1("Endno") = v5

        ds1.Tables("a_Chequebooks").Rows.Add(dr1)
        da1.Update(ds1, "a_Chequebooks")

  
        da = New OleDbDataAdapter("select * from a_Chequebooksdetails", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_Chequebooksdetails")
        Dim ll As Long = CLng(v5)
        For j = 0 To ll

            da.InsertCommand = New OleDbCommand("INSERT INTO a_Chequebooksdetails (Chequebookno,Chequeno,Status) Values(@Chequebookno,@Chequeno,@Status)", objConn1)
            da.InsertCommand.CommandType = CommandType.Text

            da.InsertCommand.Parameters.Add("@Chequebookno", OleDbType.Char, 50, "Chequebookno")
            da.InsertCommand.Parameters.Add("@Chequeno", OleDbType.Char, 50, "Chequeno")
            da.InsertCommand.Parameters.Add("@Status", OleDbType.Char, 50, "Status")

            Dim dr3 As DataRow = ds.Tables("a_Chequebooksdetails").NewRow()

            Dim noo As String
            noo = cheno()

            dr3("Chequebookno") = v1
            dr3("Chequeno") = noo
            dr3("Status") = 0
            ds.Tables("a_Chequebooksdetails").Rows.Add(dr3)
            Try

                da.Update(ds, "a_Chequebooksdetails")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

        Next
        Try
            chequebooks.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
  
    End Sub
    Public Function giveaccno()
        Dim strbrhno As String
        Dim intlastno As Integer
        da = New OleDbDataAdapter("SELECT Accountno FROM a_accounts ORDER BY Accountid DESC", objConn1)
        ds = New DataSet("B_dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows().Count - 1
        For i = 0 To total_rows
            If ds.Tables("a_accounts").Rows(i).Item("Accountno") = "" Then
                Return "AJK-0000000001"
            Else
                strbrhno = ds.Tables("a_accounts").Rows(i).Item("Accountno").ToString()
                intlastno = Integer.Parse(strbrhno.Substring(4, 10)) + 1
                Return "AJK-" + intlastno.ToString("0000000000")
            End If
        Next
        Return "AJK-0000000001"

    End Function

    Public Sub loadacclist()
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            bankaccounts.ListBox1.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub

    Public Sub loadtype()

        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")

        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            bankaccounts.cmbacctype.Items.Add(ds1.Tables("a_accounttype").Rows(i).Item("Accounttype"))
        Next

    End Sub

    Public Sub loadaccinfo(ByVal v1 As String)
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                bankaccounts.txtaccountno.Text = ds.Tables("a_accounts").Rows(i).Item("Accountno").ToString
                bankaccounts.cmbcustomerno.Text = ds.Tables("a_accounts").Rows(i).Item("Customerno").ToString
                bankaccounts.cmbholderacctype.Text = ds.Tables("a_accounts").Rows(i).Item("Holderaccounttype").ToString
                bankaccounts.txtaccname.Text = ds.Tables("a_accounts").Rows(i).Item("Accountname").ToString
                at = ds.Tables("a_accounts").Rows(i).Item("Accounttypeid").ToString

                da1 = New OleDbDataAdapter("SELECT * FROM a_accounttype", objConn1)
                ds1 = New DataSet("B_Dataset3")
                da1.Fill(ds1, "a_accounttype")
                total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
                For j = 0 To total_rows
                    If at = ds1.Tables("a_accounttype").Rows(j).Item("Accounttypeid") Then
                        bankaccounts.cmbacctype.Text = ds1.Tables("a_accounttype").Rows(j).Item("Accounttype")
                    End If
                Next
                bankaccounts.cmbcurrency.Text = ds.Tables("a_accounts").Rows(i).Item("Currencytype").ToString
                bankaccounts.txtintdeposit.Text = ds.Tables("a_accounts").Rows(i).Item("Initialdeposit").ToString
                bankaccounts.txtbalance.Text = ds.Tables("a_accounts").Rows(i).Item("Balance").ToString
                bankaccounts.DateTimePicker1.Text = ds.Tables("a_accounts").Rows(i).Item("Dateopened").ToString
            End If
        Next
    End Sub

    Public Function validbal(ByVal v1 As String, ByVal v2 As String) As Boolean
        da1 = New OleDbDataAdapter("select * from a_accounttype", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounttype")
        total_rows = ds1.Tables("a_accounttype").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds1.Tables("a_accounttype").Rows(i).Item("Accounttype") Then
                at = ds1.Tables("a_accounttype").Rows(i).Item("Minimumbalance")
            End If
        Next
        Dim longs, cge As Long
        longs = CLng(at)
        cge = CLng(v2)
        If longs < cge Then
            Return True
        Else
            MsgBox("Please Depositing more than " & at & " Rupee....", MsgBoxStyle.Information)
            Return False
        End If
    End Function

    Public Sub loadchequebook()
        chequebooks.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("SELECT * FROM a_chequebooks", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_chequebooks")

        total_rows = ds.Tables("a_chequebooks").Rows.Count - 1
        For i = 0 To total_rows
            chequebooks.ListBox1.Items.Add(ds.Tables("a_chequebooks").Rows(i).Item("Chequebookno"))
        Next

        da1 = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_accounts")
        total_rows = ds1.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            chequebooks.cmbaccno.Items.Add(ds1.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
        chequebooks.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub

    Public Sub loadcheinfo(ByVal v1 As String)
        chequebooks.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("SELECT * FROM a_chequebooks", objConn1)
        ds = New DataSet("B_DataSet3")
        da.Fill(ds, "a_chequebooks")
        total_rows = ds.Tables("a_chequebooks").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds.Tables("a_chequebooks").Rows(i).Item("Chequebookno") Then
                chequebooks.txtchequebookno.Text = ds.Tables("a_chequebooks").Rows(i).Item("Chequebookno").ToString
                chequebooks.DateTimePicker1.Text = ds.Tables("a_chequebooks").Rows(i).Item("Dateissued").ToString
                chequebooks.cmbaccno.Text = ds.Tables("a_chequebooks").Rows(i).Item("Accountno").ToString
                chequebooks.txtnoofsheet.Text = ds.Tables("a_chequebooks").Rows(i).Item("Endno").ToString
            End If
        Next
        da1 = New OleDbDataAdapter("SELECT * FROM a_chequebooksdetails", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_chequebooksdetails")
        total_rows = ds1.Tables("a_chequebooksdetails").Rows.Count - 1
        For i = 0 To total_rows
            If v1 = ds1.Tables("a_chequebooksdetails").Rows(i).Item("Chequebookno") Then
                chequebooks.DataGridView1.Rows.Add()
                chequebooks.DataGridView1.Rows(i).Cells(0).Value = ds1.Tables("a_chequebooksdetails").Rows(i).Item("Chequeno").ToString
                at = ds1.Tables("a_chequebooksdetails").Rows(i).Item("Status").ToString
                If at = 0 Then
                    chequebooks.DataGridView1.Rows(i).Cells(1).Value = "UNUSED"
                End If
            End If
        Next
        chequebooks.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub
    Public Function givecheno()
        Dim strbrhno As String
        Dim intlastno As Integer
        da = New OleDbDataAdapter("SELECT Chequebookno FROM a_chequebooks ORDER BY Chequebookid DESC", objConn1)
        ds = New DataSet("B_dataset3")
        da.Fill(ds, "a_chequebooks")
        total_rows = ds.Tables("a_chequebooks").Rows().Count - 1
        For i = 0 To total_rows
            If ds.Tables("a_chequebooks").Rows(i).Item("Chequebookno") = "" Then
                Return "CB-000001"
            Else
                strbrhno = ds.Tables("a_chequebooks").Rows(i).Item("Chequebookno").ToString()
                intlastno = Integer.Parse(strbrhno.Substring(3, 6)) + 1
                Return "CB-" + intlastno.ToString("000000")
            End If
        Next
        Return "CB-000001"
    End Function

    Public Function cheno()
        Dim strbrhno As String
        Dim intlastno As Integer
        da2 = New OleDbDataAdapter("SELECT Chequeno FROM a_chequebooksdetails ORDER BY Chequeid DESC", objConn1)
        ds2 = New DataSet("B_dataset3")
        da2.Fill(ds2, "a_chequebooksdetails")
        total_rows = ds2.Tables("a_chequebooksdetails").Rows().Count - 1
        For i = 0 To total_rows
            If ds2.Tables("a_chequebooksdetails").Rows(i).Item("Chequeno") = "" Then
                Return "C-000001"
            Else
                strbrhno = ds2.Tables("a_chequebooksdetails").Rows(i).Item("Chequeno").ToString()
                intlastno = Integer.Parse(strbrhno.Substring(2, 6)) + 1
                Return "C-" + intlastno.ToString("000000")
            End If
        Next
        Return "C-000001"
    End Function
    Public Function chkvalid(ByVal v1 As String) As Boolean
        da1 = New OleDbDataAdapter("SELECT * FROM a_chequebooksdetails", objConn1)
        ds1 = New DataSet("B_DataSet3")
        da1.Fill(ds1, "a_chequebooksdetails")
        total_rows = ds1.Tables("a_chequebooksdetails").Rows.Count - 1

        For i = 0 To total_rows
            If v1 = ds1.Tables("a_chequebooksdetails").Rows(i).Item("Chequeno") Then
                at = ds1.Tables("a_chequebooksdetails").Rows(i).Item("Status").ToString
                If at = 0 Then
                    Dim cm As New OleDbCommand("UPDATE a_chequebooksdetails SET Status=1 WHERE Chequeno='" & v1 & "'", objConn1)
                    objConn1.Open()
                    cm.ExecuteNonQuery()
                    objConn1.Close()
                    Return True
                ElseIf at = 1 Then
                    MsgBox("Cheque is All-ready used.", MsgBoxStyle.Information)
                    Return False
                End If
            End If
        Next
    End Function
End Class
