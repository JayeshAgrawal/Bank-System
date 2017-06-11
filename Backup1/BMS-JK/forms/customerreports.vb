Imports System.Data
Imports System.Data.OleDb
Public Class customerreports
    Dim da, da2, da3 As New OleDbDataAdapter()
    Dim ds, ds2, ds3 As New DataSet()
    Dim i, j, total_rows, total_rows1, m, p As Long
    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim tdt, id As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        ComboBox1.Text = "--------------SELECT--------------"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Text = "--------------SELECT--------------"
        TextBox4.Clear()
    End Sub

    Private Sub customerreports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("SELECT * FROM a_customer", objConn1)
        ds = New DataSet("B_Dataset3")
        da.Fill(ds, "a_customer")
        total_rows = ds.Tables("a_customer").Rows.Count - 1
        For i = 0 To total_rows
            ComboBox1.Items.Add(ds.Tables("a_customer").Rows(i).Item("Customerno"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "--------------SELECT--------------" And TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "--------------SELECT--------------" And TextBox4.Text = "" Then
            MsgBox("Please Fill Any One Field.", MsgBoxStyle.Information)
        Else
            Me.Cursor = Cursors.WaitCursor
            home.ToolStripProgressBar1.Visible = True
            Dim cstn, fl, fn, gd, nl As String
            If ComboBox1.Text = "--------------SELECT--------------" Then
                cstn = "00"
            Else
                cstn = ComboBox1.Text
            End If
            If TextBox1.Text = "" Then
                fl = "00"
            Else
                fl = TextBox1.Text
            End If
            If TextBox2.Text = "" Then
                fn = "00"
            Else
                fn = TextBox2.Text
            End If
            If TextBox3.Text = "--------------SELECT--------------" Then
                gd = "00"
            Else
                gd = TextBox3.Text
            End If
            If TextBox4.Text = "" Then
                nl = "00"
            Else
                nl = TextBox4.Text
            End If
            da3 = New OleDbDataAdapter("SELECT * FROM a_customer WHERE Customerno='" & cstn & "' OR Fullname LIKE '%" & fl.ToLower & "%' OR Firstname LIKE '%" & fn.ToLower & "%' OR Gender='" & gd & "' OR Nationality LIKE '%" & nl.ToLower & "%' ORDER BY Customerid DESC  ", objConn1)
            ds3 = New DataSet("B_DataSet3")
            da3.Fill(ds3, "a_customer")
            total_rows1 = ds3.Tables("a_customer").Rows.Count - 1
            ListView1.Items.Clear()
            p = 0
            Dim lst As ListViewItem
            For j = 0 To total_rows1
                lst = ListView1.Items.Add(ds3.Tables("a_customer").Rows(j).Item("Customerno"))
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Customertype").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Fullname").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Firstname").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Title").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Gender").ToString)
                lst.SubItems.Add(Format(CDate(ds3.Tables("a_customer").Rows(j).Item("DOB")), "dd-MMM-yyyy"))
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Placeofbirth").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Occupation").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Officephone").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Homephone").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Mobilephone").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Email").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Nationality").ToString)
                lst.SubItems.Add(ds3.Tables("a_customer").Rows(j).Item("Salary").ToString)
                p = p + 1
            Next
            Me.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False

            If p = 0 Then
                MsgBox("THERE IS NO RECORDS FOUND....", MsgBoxStyle.Information)
            Else
                MsgBox(p & " RECORDS FOUND.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    
End Class