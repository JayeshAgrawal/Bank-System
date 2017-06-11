Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Public Class a_usertype
    Dim ds, ds1 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da1, da As OleDbDataAdapter

    Dim total_rows, i, count As Long
    Dim uc As String


    Public Function getusertype(ByVal g1 As String)
        da = New System.Data.OleDb.OleDbDataAdapter("select * from a_usertype", objConn1)

        ds1 = New DataSet("B_DataSet1")
        da.Fill(ds1, "a_usertype")

        total_rows = ds1.Tables("a_usertype").Rows.Count - 1
        For i = 0 To total_rows
            uc = ds1.Tables("a_usertype").Rows(i).Item("code")
            If g1 = uc Then
                count = ds1.Tables("a_usertype").Rows(i).Item("usertypeid")
            End If
        Next
        Return count
    End Function
End Class
