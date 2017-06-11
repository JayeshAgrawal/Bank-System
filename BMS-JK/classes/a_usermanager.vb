Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_usermanager
    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da, da1, da2 As OleDbDataAdapter

    Dim total_rows, i, count As Long
    Dim ut, ur, up, un, uti As String

    Public Sub loaduser()
        da = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")
        total_rows = ds.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            usermanager.ListBox1.Items.Add(ds.Tables("a_newuser").Rows(i).Item("username").ToString)
        Next

        da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_usertype")
        Dim s1, s2, s3 As String
        s1 = "Master"
        s2 = "Super"
        s3 = "User"
        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_usertype").Rows(i).Item("usertype")
            If s1 = ut Then
                usermanager.txtmastercode.Text = ds1.Tables("a_usertype").Rows(i).Item("code").ToString
            ElseIf s2 = ut Then
                usermanager.txtsupercode.Text = ds1.Tables("a_usertype").Rows(i).Item("code").ToString
                usermanager.ComboBox1.Items.Add(ut)
            ElseIf s3 = ut Then
                usermanager.txtusercode.Text = ds1.Tables("a_usertype").Rows(i).Item("code").ToString
                usermanager.ComboBox1.Items.Add(ut)
            End If
        Next
    End Sub
    Public Sub loadfeatures(ByVal s1 As String)
        usermanager.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_usertype")

        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_usertype").Rows(i).Item("usertype")
            If s1 = ut Then
                uti = ds1.Tables("a_usertype").Rows(i).Item("usertypeid").ToString
            End If
        Next

        da2 = New OleDbDataAdapter("SELECT * FROM a_userfeatures WHERE usertypeid ='" & uti & "'", objConn1)
        ds2 = New DataSet("B_DataSet1")
        da2.Fill(ds2, "a_userfeatures")
        usermanager.featuregv1.Rows.Clear()
        total_rows = ds2.Tables("a_userfeatures").Rows.Count - 1
        Dim I2 As Integer

        For I2 = 0 To total_rows
            usermanager.featuregv1.Rows.Add()
            usermanager.featuregv1.Rows(I2).Cells(0).Value = ds2.Tables("a_userfeatures").Rows(I2).Item("status").ToString
            usermanager.featuregv1.Rows(I2).Cells(1).Value = ds2.Tables("a_userfeatures").Rows(I2).Item("feature").ToString
        Next
        usermanager.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub

    Public Function getid(ByVal s1 As String)
        da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_usertype")

        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_usertype").Rows(i).Item("usertype")
            If s1 = ut Then
                uti = ds1.Tables("a_usertype").Rows(i).Item("usertypeid").ToString
            End If
        Next
        Return uti
    End Function
    Public Sub savefeature(ByVal s1 As String, ByVal s2 As String, ByVal s3 As Boolean)
        usermanager.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True

        da2 = New OleDbDataAdapter("SELECT * FROM a_userfeatures ", objConn1)
        ds2 = New DataSet("B_DataSet1")
        da2.Fill(ds2, "a_userfeatures")

        da2.UpdateCommand = New OleDbCommand("UPDATE a_userfeatures SET status=@status Where (feature='" & s2 & "') And (usertypeid ='" & s1 & "')", objConn1)
        da2.UpdateCommand.CommandType = CommandType.Text

        da2.UpdateCommand.Parameters.Add("@status", OleDbType.Boolean, 50, "status")

        ds2.Tables("a_userfeatures").Rows(0).Item("status") = s3

        Try
            da2.Update(ds2, "a_userfeatures")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        usermanager.Cursor = Cursors.Arrow
        home.ToolStripProgressBar1.Visible = False
    End Sub

    Public Function setcode(ByVal v1 As String) As Boolean
        da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)

        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_usertype")

        Dim v2 As String = "Master"

        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_usertype").Rows(i).Item("usertype")
            If v2 = ut Then
                count = ds1.Tables("a_usertype").Rows(i).Item("code")
                If count = v1 Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Public Sub changesetcode(ByVal v1 As String, ByVal v2 As String)
        da = New OleDbDataAdapter("select * from a_usertype", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_usertype")
        da.UpdateCommand = New OleDbCommand("UPDATE a_usertype SET [code]=@code Where (Usertype='" & v1 & "')", objConn1)
        da.UpdateCommand.CommandType = CommandType.Text

        da.UpdateCommand.Parameters.Add("@code", OleDbType.Char, 50, "code")

        ds.Tables("a_usertype").Rows(0).Item("code") = v2

        Try
            da.Update(ds, "a_usertype")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
