Imports System.Data
Imports System.Data.OleDb
Public Class alltransactions
    Dim da, da2, da3 As New OleDbDataAdapter()
    Dim ds, ds2, ds3 As New DataSet()
    Dim i, j, z, total_rows, total_rows1, p As Long
    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim tdt, id, s, ty, ch1, ch As String
    Dim chk As Boolean
    Dim dat, dat1, dat2 As Date
    Dim df As Boolean
    Dim st As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        ComboBox3.Text = "----------SELECT----------"
        ComboBox2.Text = "----------SELECT----------"
        TextBox1.Clear()
        RadioButton3.Checked = True
        ListView1.Items.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            DateTimePicker2.Enabled = True
        Else
            DateTimePicker2.Enabled = False
            DateTimePicker2.Text = DateTimePicker1.Text
        End If
    End Sub

    Private Sub alltransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker2.Enabled = DateTimePicker1.Enabled
        da = New OleDbDataAdapter("SELECT * FROM a_accounts", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_accounts")
        total_rows = ds.Tables("a_accounts").Rows.Count - 1
        For i = 0 To total_rows
            ComboBox3.Items.Add(ds.Tables("a_accounts").Rows(i).Item("Accountno"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And ComboBox3.Text = "----------SELECT----------" And ComboBox2.Text = "----------SELECT----------" And TextBox1.Text = "" Then
            MsgBox("Please Fill Any one Field.", MsgBoxStyle.Information)
        ElseIf ComboBox2.Text = "----------SELECT----------" And TextBox1.Text = "" And ComboBox3.Text <> "----------SELECT----------" And (CheckBox1.Checked = True Or CheckBox2.Checked = True) Then
            Me.Cursor = Cursors.WaitCursor
            home.ToolStripProgressBar1.Visible = True
            If RadioButton1.Checked = True Then
                chk = True
                s = "SELECT * FROM a_transactiondetails WHERE Status=" & chk & ""
            ElseIf RadioButton2.Checked = True Then
                chk = False
                s = "SELECT * FROM a_transactiondetails WHERE Status=" & chk & ""
            ElseIf RadioButton3.Checked = True Then
                s = "SELECT * FROM a_transactiondetails"
            End If
            If TextBox1.Text = "" Then
                ch1 = "lno"
            Else
                ch1 = TextBox1.Text
            End If
            If CheckBox1.Checked = False Then
                DateTimePicker1.Text = DateTimePicker2.Text
            End If
            If CheckBox2.Checked = False Then
                DateTimePicker2.Text = DateTimePicker1.Text
            End If
            da2 = New OleDbDataAdapter(s, objConn1)
            ds2 = New DataSet("B_DataSet4")
            da2.Fill(ds2, "a_transactiondetails")
            total_rows = ds2.Tables("a_transactiondetails").Rows.Count - 1

            dat1 = CDate(DateTimePicker1.Text)
            dat2 = CDate(DateTimePicker2.Text)
            da3 = New OleDbDataAdapter("SELECT * FROM a_transactions WHERE (Transactionsdate BETWEEN  #" & dat1 & "#  AND #" & dat2 & "#) AND Accountno='" & ComboBox3.Text & "' ORDER BY Transactionsid DESC", objConn1)
            ds3 = New DataSet("B_DataSet4")
            da3.Fill(ds3, "a_transactions")
            total_rows1 = ds3.Tables("a_transactions").Rows.Count - 1

            ListView1.Items.Clear()
            TextBox3.Clear()
            z = 0

            p = 0
            Dim lst As ListViewItem

            For j = 0 To total_rows1
                dat = Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy")
                id = ds3.Tables("a_transactions").Rows(j).Item("Transactionsid").ToString
                tdt = ds3.Tables("a_transactions").Rows(j).Item("Accountno").ToString
                ty = ds3.Tables("a_transactions").Rows(j).Item("Paymentmethod").ToString
                ch = ds3.Tables("a_transactions").Rows(j).Item("Checknumber").ToString
                Format(dat, "dd-MMM-yyyy")

                For i = 0 To total_rows
                    If id = ds2.Tables("a_transactiondetails").Rows(i).Item("Transactionid") Then
                        lst = ListView1.Items.Add(Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy"))
                        lst.SubItems.Add(ty)
                        lst.SubItems.Add(tdt)
                        lst.SubItems.Add(ch)
                        lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString)
                        z = z + CLng(ds3.Tables("a_transactions").Rows(j).Item("Amount"))
                        lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Particulars").ToString)

                        df = ds2.Tables("a_transactiondetails").Rows(i).Item("Status")
                        If df = True Then
                            st = "Cleared"
                        Else
                            st = "Uncleared"
                        End If

                        lst.SubItems.Add(st)
                        p = p + 1
                    End If
                Next
            Next
            Me.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False

            If p = 0 Then
                MsgBox("THERE IS NO RECORDS FOUND....", MsgBoxStyle.Information)
            Else
                MsgBox(p & " RECORDS FOUND.", MsgBoxStyle.Information)
                TextBox3.Text = z
            End If
        Else
            Me.Cursor = Cursors.WaitCursor
            home.ToolStripProgressBar1.Visible = True
            If RadioButton1.Checked = True Then
                chk = True
                s = "SELECT * FROM a_transactiondetails WHERE Status=" & chk & ""
            ElseIf RadioButton2.Checked = True Then
                chk = False
                s = "SELECT * FROM a_transactiondetails WHERE Status=" & chk & ""
            ElseIf RadioButton3.Checked = True Then
                s = "SELECT * FROM a_transactiondetails"
            End If
            If TextBox1.Text = "" Then
                ch1 = "lno"
            Else
                ch1 = TextBox1.Text
            End If
            If CheckBox1.Checked = False Then
                DateTimePicker1.Text = DateTimePicker2.Text
            End If
            If CheckBox2.Checked = False Then
                DateTimePicker2.Text = DateTimePicker1.Text
            End If
            da2 = New OleDbDataAdapter(s, objConn1)
            ds2 = New DataSet("B_DataSet4")
            da2.Fill(ds2, "a_transactiondetails")
            total_rows = ds2.Tables("a_transactiondetails").Rows.Count - 1

            dat1 = CDate(DateTimePicker1.Text)
            dat2 = CDate(DateTimePicker2.Text)

            da3 = New OleDbDataAdapter("SELECT * FROM a_transactions WHERE (Transactionsdate BETWEEN  #" & dat1 & "#  AND #" & dat2 & "#) OR Accountno='" & ComboBox3.Text & "' OR Paymentmethod='" & ComboBox2.Text & "' OR Checknumber='" & ch1 & "' ORDER BY Transactionsid DESC", objConn1)
            ds3 = New DataSet("B_DataSet4")
            da3.Fill(ds3, "a_transactions")
            total_rows1 = ds3.Tables("a_transactions").Rows.Count - 1

            ListView1.Items.Clear()
            TextBox3.Clear()
            z = 0

            p = 0
            Dim lst As ListViewItem

            For j = 0 To total_rows1
                dat = Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy")
                id = ds3.Tables("a_transactions").Rows(j).Item("Transactionsid").ToString
                tdt = ds3.Tables("a_transactions").Rows(j).Item("Accountno").ToString
                ty = ds3.Tables("a_transactions").Rows(j).Item("Paymentmethod").ToString
                ch = ds3.Tables("a_transactions").Rows(j).Item("Checknumber").ToString
                Format(dat, "dd-MMM-yyyy")

                For i = 0 To total_rows
                    If id = ds2.Tables("a_transactiondetails").Rows(i).Item("Transactionid") Then
                        lst = ListView1.Items.Add(Format(CDate(ds3.Tables("a_transactions").Rows(j).Item("Transactionsdate")), "dd-MMM-yyyy"))
                        lst.SubItems.Add(ty)
                        lst.SubItems.Add(tdt)
                        lst.SubItems.Add(ch)
                        lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Amount").ToString)
                        lst.SubItems.Add(ds3.Tables("a_transactions").Rows(j).Item("Particulars").ToString)
                        df = ds2.Tables("a_transactiondetails").Rows(i).Item("Status")
                        If df = True Then
                            st = "Cleared"
                            z = z + CLng(ds3.Tables("a_transactions").Rows(j).Item("Amount"))
                        Else
                            st = "Uncleared"
                        End If

                        lst.SubItems.Add(st)
                        p = p + 1
                    End If
                Next

            Next

            Me.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False

            If p = 0 Then
                MsgBox("THERE IS NO RECORDS FOUND....", MsgBoxStyle.Information)
            Else
                MsgBox(p & " RECORDS FOUND.", MsgBoxStyle.Information)
                TextBox3.Text = z
            End If
        End If
    End Sub
End Class