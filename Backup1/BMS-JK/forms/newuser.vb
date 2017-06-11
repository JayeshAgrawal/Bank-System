Public Class newuser

    Dim valid, sn As Boolean
    Private Sub newuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        txtusername.Clear()
        txtusertype.Clear()
        txtpassword.Clear()
        txtc_password.Clear()
        txtusername.Focus()
        txtusertype.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtusername.Text = "" = False Then
            Dim s1 As New a_newuser()
            sn = s1.samename(txtusername.Text)
            If sn = False Then
                Exit Sub
            End If
        End If
        If IsNumeric(txtusername.Text) = True Or txtusertype.Text = "" Or txtpassword.Text = "" Or txtc_password.Text = "" Then
            MsgBox("The Type of User or UserName Or Password Or Confirm Password is Empty" + Chr(13) + "Check The Fields" + Chr(13) + "UserName May be not Numeric", MsgBoxStyle.Critical)
            txtusername.Clear()
            txtusertype.Clear()
            txtpassword.Clear()
            txtc_password.Clear()
            txtusername.Focus()

        ElseIf txtpassword.Text.Length < 5 Then
            MsgBox("The password must be at least 5 characters long", MsgBoxStyle.Critical)
            txtpassword.Clear()
            txtc_password.Clear()
            txtpassword.Focus()
        Else
            Dim d1 As New a_newuser()
            valid = d1.validatepassword(txtpassword.Text)
            If valid = True Then
                MsgBox("The password must contain at least one character that is not a letter or digit.")
                valid = False
                txtpassword.Clear()
                txtc_password.Clear()
                txtpassword.Focus()
                Exit Sub
            End If

            If txtpassword.Text = txtc_password.Text = False Then
                MsgBox("Confirm Password Not Match", MsgBoxStyle.Critical)
                txtpassword.Clear()
                txtc_password.Clear()
                txtpassword.Focus()
                Exit Sub
            End If

            Dim d2 As New a_newuser()
            Dim stat As String
            stat = "Disabled"
            d1.datainsert(txtusername.Text, txtpassword.Text, txtusertype.Text, stat)

            txtusername.Clear()
            txtusertype.Clear()
            txtpassword.Clear()
            txtc_password.Clear()
            txtusername.Focus()
            Me.Hide()
            loginform.Show()
            loginform.Activate()
            loginform.txtusertype.Visible = False
            loginform.Label3.Visible = False
            loginform.declar()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtusername.Clear()
        txtusertype.Clear()
        txtpassword.Clear()
        txtc_password.Clear()
        txtusername.Focus()
        Me.Hide()
        loginform.Show()
        loginform.Activate()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        usertype.Show()
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        ToolTip1.Show("Must enter Numeric Values...", txtusername)
        ToolTip1.Hide(txtpassword)
    End Sub
  
    Private Sub txtusername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyUp
        If IsNumeric(txtusername.Text) = True Then
            txtusername.Clear()
            txtusername.Focus()
            MsgBox("Try Only Numeric Values....")
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        ToolTip1.Show("Password must be more than 5 Characters....", txtpassword)
        ToolTip1.Hide(txtusername)
    End Sub

    Private Sub txtpassword_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.MouseHover
        ToolTip1.Show("Password must be more than 5 Characters....", txtpassword)
    End Sub
End Class