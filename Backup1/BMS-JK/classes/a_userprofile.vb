Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_userprofile
    Dim ds, ds1, ds2 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da, da1, da2 As OleDbDataAdapter

    Dim total_rows, i, count As Long
    Dim ut, ur, up, un As String
    Dim bb As Integer

    Public Sub loaduser(ByRef s1 As String)

        da = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")
        total_rows = ds.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            ur = ds.Tables("a_newuser").Rows(i).Item("username")
            If s1 = ur Then
                userprofile.txtusername.Text = ds.Tables("a_newuser").Rows(i).Item("username").ToString
                userprofile.txtfullname.Text = ds.Tables("a_newuser").Rows(i).Item("fullname").ToString
                bb = ds.Tables("a_newuser").Rows(i).Item("usertypeid")

                da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)
                ds1 = New DataSet("B_DataSet1")
                da1.Fill(ds1, "a_usertype")

                userprofile.txtusertype.Text = ds1.Tables("a_usertype").Rows(bb - 1).Item("usertype").ToString
                userprofile.txtpassword.Text = ds.Tables("a_newuser").Rows(i).Item("password").ToString
                userprofile.txtstatus.Text = ds.Tables("a_newuser").Rows(i).Item("status").ToString
                userprofile.dtl_logindate.Text = ds.Tables("a_newuser").Rows(i).Item("lastlogindate").ToString
                up = ds.Tables("a_newuser").Rows(i).Item("picture").ToString
                If up <> "" Then
                    userprofile.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\" & up)
                End If
            End If
        Next

        da1 = New OleDbDataAdapter("SELECT * FROM a_userfeatures WHERE usertypeid ='" & bb & "'", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_userfeatures")
        userprofile.featuregv1.Rows.Clear()
        total_rows = ds1.Tables("a_userfeatures").Rows.Count - 1
        Dim I2 As Integer

        For I2 = 0 To total_rows
            userprofile.featuregv1.Rows.Add()
            userprofile.featuregv1.Rows(I2).Cells(0).Value = ds1.Tables("a_userfeatures").Rows(I2).Item("feature").ToString
            userprofile.featuregv1.Rows(I2).Cells(1).Value = ds1.Tables("a_userfeatures").Rows(I2).Item("status").ToString
        Next

    End Sub


    Public Sub saveuser(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String, ByVal v4 As String, ByVal v5 As String, ByVal v6 As String)
        home.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")
        da.UpdateCommand = New OleDbCommand("UPDATE a_newuser SET Fullname=@Fullname,[Password]=@Password,Status=@Status,Lastlogindate=@Lastlogindate,Picture=@Picture Where (Username='" & v1 & "')", objConn1)
        da.UpdateCommand.CommandType = CommandType.Text

        da.UpdateCommand.Parameters.Add("@Fullname", OleDbType.Char, 50, "Fullname")
        da.UpdateCommand.Parameters.Add("@Password", OleDbType.Char, 50, "Password")
        da.UpdateCommand.Parameters.Add("@Status", OleDbType.Char, 50, "Status")
        da.UpdateCommand.Parameters.Add("@Lastlogindate", OleDbType.Char, 50, "Lastlogindate")
        da.UpdateCommand.Parameters.Add("@Picture", OleDbType.Char, 50, "Picture")

        ds.Tables("a_newuser").Rows(0).Item("Fullname") = v2
        ds.Tables("a_newuser").Rows(0).Item("Password") = v3
        ds.Tables("a_newuser").Rows(0).Item("Status") = v4
        ds.Tables("a_newuser").Rows(0).Item("Lastlogindate") = v5
        ds.Tables("a_newuser").Rows(0).Item("Picture") = v6

        Try
            da.Update(ds, "a_newuser")
            home.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            MsgBox("Data is UpDateed....", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
     
    End Sub


    Public Sub deleteuser(ByVal v1 As String)
        userprofile.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        da2 = New OleDbDataAdapter("select * from  a_newuser", objConn1)
        ds2 = New DataSet("B_DataSet1")
        da2.Fill(ds2, "a_newuser")

        da2.DeleteCommand = New OleDbCommand("DELETE FROM  a_newuser WHERE (username='" & v1 & "')", objConn1)
        da2.DeleteCommand.CommandType = CommandType.Text
        da2.DeleteCommand.Parameters.Add("@username", OleDb.OleDbType.Char, 255, "username")


        total_rows = ds2.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            un = ds2.Tables("a_newuser").Rows(i).Item("username")

            If v1 = un Then
                If MsgBox("Are you sure ? " & (Chr(13)) & "Delete " & v1, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                  

                    ds2.Tables("a_newuser").Rows(i).Delete()

                    i = total_rows + 1
                    Try
                        da2.Update(ds2, "a_newuser")
                        userprofile.Cursor = Cursors.Arrow
                        home.ToolStripProgressBar1.Visible = False
                        MsgBox("Data of '" & v1 & "' is deleted", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                End If
            End If
        Next
    
    End Sub



    Public Function changepassword(ByVal v1 As String, ByVal v2 As String) As Boolean
        da1 = New OleDbDataAdapter("select * from a_newuser", objConn1)

        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_newuser")

        total_rows = ds1.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            ut = ds1.Tables("a_newuser").Rows(i).Item("username")
            If v1 = ut Then
                count = ds1.Tables("a_newuser").Rows(i).Item("password")
                If count = v2 Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

End Class
