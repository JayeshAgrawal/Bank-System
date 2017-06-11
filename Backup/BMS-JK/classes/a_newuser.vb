Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_newuser

    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da1, da, da2 As OleDbDataAdapter

    Dim total_rows, i, count As Long
    Dim ut, ur As String

    Public Function samename(ByVal s1 As String) As Boolean
        da2 = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds2 = New DataSet("B_DataSet1")
        da2.Fill(ds2, "a_newuser")
        total_rows = ds2.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            ur = ds2.Tables("a_newuser").Rows(i).Item("username")
            If s1 = ur Then
                MsgBox("UserName is Same as Other User Name. Enter The Other Name")
                newuser.txtusername.Clear()
                newuser.txtusername.Focus()
                Return False
            End If
        Next
        Return True
    End Function


    Public Sub datainsert(ByRef v1 As String, ByRef v2 As String, ByRef v3 As String, ByVal v4 As String)
        da1 = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds = New DataSet("B_DataSet1")
        da1.Fill(ds, "a_newuser")
        da1.InsertCommand = New OleDbCommand("INSERT INTO a_newuser (Username,Usertypeid ,[Password],Status) Values(@Username,@Usertypeid,@Password,@Status)", objConn1)
        da1.InsertCommand.CommandType = CommandType.Text

        da1.InsertCommand.Parameters.Add("@Username", System.Data.OleDb.OleDbType.Char, 50, "Username")
        da1.InsertCommand.Parameters.Add("@Usertypeid", System.Data.OleDb.OleDbType.Integer, 5, "Usertypeid")
        da1.InsertCommand.Parameters.Add("@Password", System.Data.OleDb.OleDbType.Char, 50, "Password")
        da1.InsertCommand.Parameters.Add("@Status", System.Data.OleDb.OleDbType.Char, 50, "Status")

        Dim dr1 As DataRow = ds.Tables("a_newuser").NewRow()

        dr1("Username") = v1
        dr1("Password") = v2

        da = New OleDbDataAdapter("select * from a_usertype", objConn1)

        ds1 = New DataSet("B_DataSet1")
        da.Fill(ds1, "a_usertype")

        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_usertype").Rows(i).Item("usertype")

            If ut = v3 Then
                count = ds1.Tables("a_usertype").Rows(i).Item("usertypeid")
            End If
        Next

        dr1("Usertypeid") = count
        dr1("Status") = v4

        ds.Tables("a_newuser").Rows.Add(dr1)

        Try
            da1.Update(ds, "a_newuser")
            MsgBox("Data is Added successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Public Function validatepassword(ByVal password As String) As Boolean

        Dim i As Integer
        For i = 0 To password.Length - 1
            If Not Char.IsLetterOrDigit(password.Chars(i)) Then
                Return True
            End If
        Next
    End Function

End Class
