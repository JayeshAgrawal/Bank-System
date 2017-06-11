Public Class newtransaction
    Dim pm, tm As String
    Dim che As Long
    Dim kl, ll As Boolean
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        maketransaction.Enabled = True
        maketransaction.Activate()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DateTimePicker1.Text = "" Or txtamount.Text = "" Then
            MsgBox("Some fields are blank, please it...", MsgBoxStyle.Information)
        Else
            If RadioButton3.Checked = True Then
                pm = RadioButton3.Text
                che = 1
            ElseIf RadioButton4.Checked = True Then
                pm = RadioButton4.Text
                che = 0
            ElseIf RadioButton5.Checked = True Then
                pm = RadioButton5.Text
                che = 0
            ElseIf RadioButton6.Checked = True Then
                pm = RadioButton6.Text
                che = 0
            End If
            If RadioButton1.Checked = True Then
                tm = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                tm = RadioButton2.Text
            End If
            If txtcheno.Visible = True Then
                If txtcheno.Text = "" Then
                    MsgBox("Please Fill Cheque No.", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    Dim mg1 As Boolean
                    Dim mg As New a_bankaccount()
                    mg1 = mg.chkvalid(txtcheno.Text)
                    If mg1 = False Then
                        Exit Sub
                    End If
                End If
            End If
            Dim dat As Date = CDate(DateTimePicker2.Text)
            Dim m1 As New a_transaction()
            If dat = Format(Now, "dd-MMM-yyyy") Then
                ll = True
                kl = m1.amountvalid(txtaccno.Text, txtamount.Text, tm)
                If kl = False Then
                    Exit Sub
                End If
            Else
                ll = False
            End If
            m1.insertdata(CDate(DateTimePicker1.Text), pm, txtcheno.Text, txtaccno.Text, txtamount.Text, tm, CDate(DateTimePicker2.Text), txtparticulars.Text, che, ll)
            m1.loadaccdata(txtaccno.Text)
        End If
    End Sub

    Private Sub newtransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcheno.Visible = False
        Label3.Visible = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        txtcheno.Visible = False
        Label3.Visible = False
    End Sub

   
    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked = True Then
            txtcheno.Visible = True
            Label3.Visible = True
            RadioButton2.Checked = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click
        RadioButton2.Enabled = True
        RadioButton2.Checked = True
        RadioButton1.Enabled = False
    End Sub

   

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        RadioButton1.Checked = True
        RadioButton2.Enabled = False
        RadioButton1.Enabled = True
    End Sub

    Private Sub RadioButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton6.Click
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub
End Class