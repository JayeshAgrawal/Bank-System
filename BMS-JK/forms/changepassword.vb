Public Class changepassword
    Dim sn As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        userprofile.Enabled = True
        userprofile.Activate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtoldpassword.Text = "" Then
            MsgBox("Please Enter Old Password....", MsgBoxStyle.Critical)
        End If
        If txtoldpassword.Text = "" Or txtnewpassword.Text = "" Or txtc_password.Text = "" Then
            MsgBox("Please Enter Old Password and New Password and Confirm Password....", MsgBoxStyle.Critical)


        ElseIf txtnewpassword.Text.Length < 5 Then
            MsgBox("The password must be at least 5 characters long", MsgBoxStyle.Critical)
            txtnewpassword.Clear()
            txtc_password.Clear()
            txtnewpassword.Focus()
        Else
            Dim d1 As New a_userprofile()
            sn = d1.changepassword(txtusername.Text, txtoldpassword.Text)
            If sn = False Then
                MsgBox("Old Password is Invalid....Please Enter Valid Password.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtnewpassword.Text = txtc_password.Text = False Then
                MsgBox("Confirm Password Not Match", MsgBoxStyle.Critical)
                txtnewpassword.Clear()
                txtc_password.Clear()
                txtnewpassword.Focus()
                Exit Sub
            End If
            MsgBox("Password is Changed Successfully.")
            Me.Hide()
            userprofile.Enabled = True
            userprofile.Activate()
            userprofile.txtpassword.Text = txtnewpassword.Text
        End If
    End Sub

    Private Sub changepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Enabled = False
        txtoldpassword.Focus()
    End Sub
End Class