Public Class usertype
    Dim count As Integer
    Private Sub usertype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcode.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t1 As New a_usertype()
        count = t1.getusertype(txtcode.Text)
        If count = 1 Then
            txtcode.Clear()
            Me.Hide()
            newuser.Enabled = True
            newuser.Activate()
            newuser.txtusertype.Text = "Master"
        ElseIf count = 2 Then
            txtcode.Clear()
            Me.Hide()
            newuser.Enabled = True
            newuser.Activate()
            newuser.txtusertype.Text = "Super"
        ElseIf count = 3 Then
            txtcode.Clear()
            Me.Hide()
            newuser.Enabled = True
            newuser.Activate()
            newuser.txtusertype.Text = "User"
        Else
            MessageBox.Show("Invalid Code.", "MSG")
            txtcode.Clear()
            txtcode.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtcode.Clear()
        txtcode.Focus()
        Me.Hide()
        newuser.Enabled = True
        newuser.Activate()
    End Sub
End Class