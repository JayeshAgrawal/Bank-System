Public Class setcode
    Dim sn As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        usermanager.Enabled = True
        usermanager.Activate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txto_code.Text = "" Then
            MsgBox("Please Enter Old Master Code....", MsgBoxStyle.Critical)
        End If
        If txto_code.Text = "" Or txtn_code.Text = "" Or txtc_code.Text = "" Then
            MsgBox("Please Enter Old Master Code and New " & txtusertype.Text & " Code and Confirm " & txtusertype.Text & " Code....", MsgBoxStyle.Critical)
        Else
            Dim d1 As New a_usermanager()
            sn = d1.setcode(txto_code.Text)
            If sn = False Then
                MsgBox("Old Master code is Invalid....Please Enter Valid Master code.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtn_code.Text = txtc_code.Text = False Then
                MsgBox("Confirm " & txtusertype.Text & " code Not Match", MsgBoxStyle.Critical)
                txtn_code.Clear()
                txtc_code.Clear()
                txtn_code.Focus()
                Exit Sub
            End If

            Dim d2 As New a_usermanager()
            d2.changesetcode(txtusertype.Text, txtn_code.Text)

            MsgBox(txtusertype.Text & " code is Changed Successfully.")
            Me.Hide()
            usermanager.Enabled = True
            usermanager.Activate()
            If txtusertype.Text = "Master" Then
                usermanager.txtmastercode.Text = txtn_code.Text
            ElseIf txtusertype.Text = "Super" Then
                usermanager.txtsupercode.Text = txtn_code.Text
            ElseIf txtusertype.Text = "User" Then
                usermanager.txtusercode.Text = txtn_code.Text
            End If
        End If
    End Sub

    Private Sub setcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusertype.Enabled = False
        txto_code.Focus()
    End Sub
End Class