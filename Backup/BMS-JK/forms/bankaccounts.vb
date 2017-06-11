Public Class bankaccounts
    Dim cnt As Integer = 0
    Dim bal As Boolean

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cnt = 1
        jkk()
        nb()
        ListBox1.Enabled = False
        Button5.Enabled = True
        Button2.Text = "ADD"
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If cmbcustomerno.Text = "" Or txtaccname.Text = "" Or cmbacctype.Text = "---------------------SELECT----------------------" Or txtintdeposit.Text = "" Then
            MsgBox("Please fill all fields....", MsgBoxStyle.Information)
        Else

            Dim j1 As New a_bankaccount()
            bal = j1.validbal(cmbacctype.Text, txtintdeposit.Text)
            If bal = False Then
                Exit Sub
            End If
            txtbalance.Text = txtintdeposit.Text
            If cnt = 1 Then
                Dim m1 As New a_bankaccount()
                Dim noo As String
                noo = m1.giveaccno()
                txtaccountno.Text = noo
                m1.enterbankacc(txtaccountno.Text, txtaccname.Text, cmbholderacctype.Text, cmbacctype.Text, cmbcurrency.Text, txtintdeposit.Text, txtbalance.Text, CDate(DateTimePicker1.Text), cmbcustomerno.Text)
            ElseIf cnt = 2 Then
                Dim m2 As New a_bankaccount()
                m2.updatebankacc(txtaccountno.Text, cmbholderacctype.Text, txtaccname.Text, cmbacctype.Text, cmbcurrency.Text)
                DateTimePicker1.Enabled = True
                txtintdeposit.ReadOnly = False
            End If
            ListBox1.Items.Clear()
            Dim m3 As New a_bankaccount()
            m3.loadacclist()
            jkk()
            nm()
            Button4.Enabled = False

        End If
      
    End Sub
    Private Sub nb()
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
       
        Dim m3 As New a_bankaccount()
        m3.deletebankacc(txtaccountno.Text)
        Dim m1 As New a_bankaccount()
        ListBox1.Items.Clear()
        m1.loadacclist()
        jkk()
        nm()
        Button4.Enabled = False
        DateTimePicker1.Enabled = True
        txtintdeposit.ReadOnly = False
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Enabled = False
        customerdetail.Show()
        customerdetail.Activate()
        customerdetail.Button2.Enabled = False
        If cmbcustomerno.Text <> "" Then
            Dim m1 As New a_customer()
            m1.loadcust(cmbcustomerno.Text)
            customerdetail.Button1.Enabled = False
            customerdetail.Button2.Enabled = True
        End If
    End Sub

    Private Sub jkk()
        txtaccountno.Clear()
        cmbcustomerno.Clear()
        txtaccname.Clear()
        cmbacctype.Text = "---------------------SELECT----------------------"
        txtintdeposit.Clear()
        txtbalance.Clear()
        DateTimePicker1.Text = ""
    End Sub

    Private Sub nm()
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        ListBox1.Enabled = True
        Button3.Enabled = True
    End Sub
    Private Sub bankaccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nm()
        Button4.Enabled = False
        Dim m1 As New a_bankaccount()
        m1.loadacclist()
        m1.loadtype()
        jkk()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        jkk()
        nm()
        Button4.Enabled = False
        DateTimePicker1.Enabled = True
        txtintdeposit.ReadOnly = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cnt = 2
        nb()
        Button2.Text = "SHOW"
        ListBox1.Enabled = False
        Button4.Enabled = False
        DateTimePicker1.Enabled = False

        txtintdeposit.ReadOnly = True
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim m1 As New a_bankaccount()
        m1.loadaccinfo(ListBox1.SelectedItem)
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub


   
   
End Class