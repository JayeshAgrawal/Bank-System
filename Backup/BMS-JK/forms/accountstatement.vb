Imports System.Data
Imports System.Data.OleDb
Public Class accountstatement
    Dim da, da2, da3 As New OleDbDataAdapter()
    Dim ds, ds2, ds3 As New DataSet()
    Dim i, j, z, x, y, total_rows, total_rows1, m, p As Long
    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim tdt, id As String
    Dim chk As Boolean = True

    Private Sub accountstatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            ListBox1.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        TextBox1.Text = ListBox1.SelectedItem
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Fill Account No Box,Select From List.", MsgBoxStyle.Information)
        Else
            Me.Cursor = Cursors.WaitCursor
            home.ToolStripProgressBar1.Visible = True

            da2 = New OleDbDataAdapter("SELECT * FROM a_transactiondetails", objConn1)
            ds2 = New DataSet("B_DataSet4")
            da2.Fill(ds2, "a_transactiondetails")
            total_rows = ds2.Tables("a_transactiondetails").Rows.Count - 1

            da3 = New OleDbDataAdapter("SELECT * FROM a_transactions ORDER BY Transactionsid DESC", objConn1)
            ds3 = New DataSet("B_DataSet4")
            da3.Fill(ds3, "a_transactions")
            total_rows1 = ds3.Tables("a_transactions").Rows.Count - 1

            ListView1.Items.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            z = 0
            x = 0
            p = 0
            Dim lst As ListViewItem

            For j = 0 To total_rows1

                If TextBox1.Text = ds3.Tables("a_transactions").Rows(j).Item("Accountno") Then
                    id = ds3.Tables("a_transactions").Rows(j).Item("Transactionsid").ToString

                    For i = 0 To total_rows
                        If id = ds2.Tables("a_transactiondetails").Rows(i).Item("Transactionid") Then
                            If chk = ds2.Tables("a_transactiondetails").Rows(i).Item("Status") Then
                                lst = ListView1.Items.Add(Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy"))

                                lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Paymentmethod").ToString)

                                tdt = ds3.Tables("a_transactions").Rows(j).Item("Transactionsmode").ToString
                                If tdt = "Credit" Then
                                    lst.SubItems.Add("0")
                                    lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString)
                                    z = z + CLng(ds3.Tables("a_transactions").Rows(j).Item("Amount"))
                                ElseIf tdt = "Debit" Then
                                    lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString)
                                    lst.SubItems.Add("0")
                                    x = x + CLng(ds3.Tables("a_transactions").Rows(j).Item("Amount"))
                                End If
                                p = p + 1
                            End If
                        End If
                    Next

                End If

            Next

            Me.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False


            da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
            ds = New DataSet("B_Dataset3")
            da.Fill(ds, "a_accounts")
            total_rows = ds.Tables("a_accounts").Rows.Count - 1
            For i = 0 To total_rows
                If TextBox1.Text = ds.Tables("a_accounts").Rows(i).Item("Accountno") Then
                    m = CLng(ds.Tables("a_accounts").Rows(i).Item("Initialdeposit"))
                End If
            Next
            If p = 0 Then
                MsgBox("THERE IS NO RECORDS FOUND....", MsgBoxStyle.Information)
            Else
                MsgBox(p & " RECORDS FOUND.", MsgBoxStyle.Information)
            End If
            TextBox5.Text = m
            TextBox2.Text = z
            TextBox3.Text = x
            y = m + z - x
            TextBox4.Text = y
        End If
    End Sub

   
End Class