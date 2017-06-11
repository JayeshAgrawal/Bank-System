Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class a_loginform
    Dim ds, ds1 As DataSet

    Dim objConn1 As New OleDbConnection(strConnectionString)
    Dim da, da1 As OleDbDataAdapter

    Dim total_rows, i As Long
    Dim count As Integer = 0
    Dim ut As String
    Dim ty As Boolean
    Dim pass, user, type, kl, d1, d2, d3 As String
    Dim tdt As Date = Format(Now, "dd-MMM-yyyy")

    Public Function login(ByVal a1 As String, ByVal a2 As String)

        da = New OleDbDataAdapter("select * from a_newuser", objConn1)

        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")

        total_rows = ds.Tables("a_newuser").Rows.Count - 1

        For i = 0 To total_rows

            user = ds.Tables("a_newuser").Rows(i).Item("username")
            pass = ds.Tables("a_newuser").Rows(i).Item("password")

            If user = a1 And pass = a2 Then
                count = 1
            End If
        Next
        Return count
    End Function

    Public Function login(ByVal a1 As String, ByVal a2 As String, ByVal a3 As String)
        da = New OleDbDataAdapter("select * from a_newuser", objConn1)

        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")

        total_rows = ds.Tables("a_newuser").Rows.Count - 1

        For i = 0 To total_rows

            user = ds.Tables("a_newuser").Rows(i).Item("username")
            pass = ds.Tables("a_newuser").Rows(i).Item("password")
            ut = ds.Tables("a_newuser").Rows(i).Item("usertypeid")

            da1 = New OleDbDataAdapter("select * from a_usertype", objConn1)

            ds1 = New DataSet("B_DataSet1")
            da1.Fill(ds1, "a_usertype")

            type = ds1.Tables("a_usertype").Rows(ut - 1).Item("usertype")

            If user = a1 And pass = a2 And type = a3 Then
                count = 1
            End If
        Next
        Return count

    End Function


    Public Sub service(ByVal v1 As String, ByVal v3 As String)
        Dim com As New OleDbCommand("update a_newuser set Status ='" & v3 & "' where username='" & v1 & "'", objConn1)
        objConn1.Open()
        com.ExecuteNonQuery()
        objConn1.Close()

        da = New OleDbDataAdapter("select * from a_newuser", objConn1)
        ds = New DataSet("B_DataSet1")
        da.Fill(ds, "a_newuser")
        total_rows = ds.Tables("a_newuser").Rows.Count - 1
        For i = 0 To total_rows
            user = ds.Tables("a_newuser").Rows(i).Item("username")
            If v1 = user Then
                ut = ds.Tables("a_newuser").Rows(i).Item("usertypeid")
            End If
        Next

        da1 = New OleDbDataAdapter("SELECT * FROM a_userfeatures", objConn1)
        ds1 = New DataSet("B_DataSet1")
        da1.Fill(ds1, "a_userfeatures")
        total_rows = ds1.Tables("a_userfeatures").Rows.Count - 1
        For i = 0 To total_rows
            type = ds1.Tables("a_userfeatures").Rows(i).Item("usertypeid")
            If ut = type Then
                ty = ds1.Tables("a_userfeatures").Rows(i).Item("status")
                If ty = False Then
                    kl = ds1.Tables("a_userfeatures").Rows(i).Item("feature")
                    If kl = "User Profile" Then
                        home.userprofilemenu.Visible = False
                    ElseIf kl = "Bank Profile" Then
                        home.bankprofilemenu.Visible = False
                    ElseIf kl = "Bank Branches" Then
                        home.bankbranchesmenu.Visible = False
                    ElseIf kl = "Bank Accounts" Then
                        home.bankaccountsmenu.Visible = False
                    ElseIf kl = "Check Book" Then
                        home.chequebookmenu.Visible = False
                    ElseIf kl = "Account Type" Then
                        home.accounttypemenu.Visible = False
                    ElseIf kl = "User Manager" Then
                        home.usermanagermenu.Visible = False
                    ElseIf kl = "Make Transaction" Then
                        home.maketransactionmenu.Visible = False
                    ElseIf kl = "Internal Transfer" Then
                        home.internaltransfermenu.Visible = False
                    ElseIf kl = "Customer Report" Then
                        home.customerreportsmenu.Visible = False
                    ElseIf kl = "All Transaction Reports" Then
                        home.alltransactionreportsmenu.Visible = False
                    ElseIf kl = "Account Statements" Then
                        home.accountstatementsmenu.Visible = False
                    ElseIf kl = "Utility" Then
                        home.utilitymenu.Visible = False
                    ElseIf kl = "Status Bar" Then
                        home.StatusStrip.Visible = False
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub lastcall(ByVal V1 As String, ByVal v2 As String, ByVal v3 As String)
        Dim com As New OleDbCommand("update a_newuser set Lastlogindate='" & v2 & "' ,Status ='" & v3 & "' where username='" & v1 & "'", objConn1)
        objConn1.Open()
        com.ExecuteNonQuery()
        objConn1.Close()
    End Sub


    Public Sub traplay()
        Dim nm As Boolean = True
        da = New OleDbDataAdapter("SELECT * FROM a_transactions", objConn1)
        ds = New DataSet("B_Dataset4")
        da.Fill(ds, "a_transactions")
        total_rows = ds.Tables("a_transactions").Rows.Count - 1
        For i = 0 To total_rows
            user = ds.Tables("a_transactions").Rows(i).Item("Transactionsid")
            If tdt = Format(CDate(ds.Tables("a_transactions").Rows(i).Item("Datedcleared")), "dd-MMM-yyyy") Then
                Dim comm As New OleDbCommand("UPDATE a_transactiondetails SET Status=" & nm & " WHERE Transactionid=" & user & " ", objConn1)
                objConn1.Open()
                comm.ExecuteNonQuery()
                objConn1.Close()
                d1 = ds.Tables("a_transactions").Rows(i).Item("Accountno")
                d2 = ds.Tables("a_transactions").Rows(i).Item("Amount")
                d3 = ds.Tables("a_transactions").Rows(i).Item("Transactionsmode")
                Dim m1 As New a_transaction()
                m1.amountvalid(d1, d2, d3)
            End If
        Next
    End Sub

End Class
