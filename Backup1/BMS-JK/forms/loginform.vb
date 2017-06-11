Imports System.Drawing
Public Class loginform

    Dim wrg As Boolean = False
    Dim cnt As Integer = 0
    Dim count As Integer

    Private Sub loginform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Focus()
        txtusertype.Visible = False
        Label3.Visible = False

        ToolTip1.IsBalloon = True
        ToolTip1.Active = True
        NotifyIcon1.ShowBalloonTip(2000)
        Dim gsz As New Size(356, 120)
        GroupBox2.Size = gsz
        Dim fsz As New Size(401, 241)
        Me.Size = fsz
        Dim gln As New Point(19, 140)
        GroupBox1.Location = gln
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        NotifyIcon1.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        NotifyIcon1.Dispose()
        newuser.Show()
    End Sub
    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        NotifyIcon1.ShowBalloonTip(2000)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = "" Then

            MsgBox("Enter User Name ")

        ElseIf txtusername.Text = "" Then

            ToolTip1.Show("Enter Password", txtpassword, 3000)
            txtpassword.Focus()

        Else
            If wrg = True Then
                If txtusertype.Text = "" Then
                    MsgBox("Enter User type ")
                    Exit Sub
                End If
            End If


            If wrg = True Then
                Dim l1 As New a_loginform()
                count = l1.login(txtusername.Text, txtpassword.Text, txtusertype.Text)
            Else
                Dim l1 As New a_loginform()
                count = l1.login(txtusername.Text, txtpassword.Text)
            End If

            If count = 1 Then
                Me.Cursor = Cursors.WaitCursor
                Me.Hide()
                home.ToolStripStatusLabel2.Text = txtusername.Text
                home.Show()
                Dim stat As String
                stat = "Enabled"
                Dim dtw As New a_loginform()
                dtw.service(txtusername.Text, stat)
                dtw.traplay()
                txtpassword.Text = ""
                txtusername.Text = ""
                txtusertype.Text = ""
                count = 0
                Me.Cursor = Cursors.Arrow
                NotifyIcon1.Dispose()
            Else

                MsgBox("You are not Authentic User" + (Chr(13)) + "Try Again.....", MsgBoxStyle.Critical)
                wrg = True
                cnt = cnt + 1
                If cnt > 2 Then
                    MsgBox("Closeing Your Application.", MsgBoxStyle.Critical)
                    wrg = False
                    Me.Close()
                End If
                Dim gsz As New Size(356, 187)
                GroupBox2.Size = gsz
                Dim fsz As New Size(401, 312)
                Me.Size = fsz
                Dim gln As New Point(19, 206)
                GroupBox1.Location = gln
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
            End If
            If wrg = True Then
                txtusertype.Visible = True
                Label3.Visible = True
            End If
        End If

    End Sub
    Public Sub declar()
        wrg = False
        cnt = 0
    End Sub
End Class