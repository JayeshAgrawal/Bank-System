Public Class transfer
    Dim kl As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        internaltransfer.Enabled = True
        internaltransfer.Activate()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtamount.Text = "" Or ComboBox1.Text = "---------SELECT---------" Then
            MsgBox("Please fill all field....", MsgBoxStyle.Information)

        ElseIf txtfromaccno.Text = ComboBox1.Text Then
            MsgBox("From-account no and To-account no is not same...", MsgBoxStyle.Critical)
            ComboBox1.Text = "---------SELECT---------"
        Else
            Dim m1 As New a_transfer
            kl = m1.amountvalid(txtamount.Text, txtfromaccno.Text, ComboBox1.Text)
            If kl = False Then
                Exit Sub
            End If
            m1.insertdata(CDate(DateTimePicker1.Text), txtfromaccno.Text, txtamount.Text, ComboBox1.Text)
            m1.loadaccdata(txtfromaccno.Text)
        End If
    End Sub

   
    Private Sub transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_transfer
        m1.toacclist(internaltransfer.txtaccno.Text)
    End Sub

   
End Class