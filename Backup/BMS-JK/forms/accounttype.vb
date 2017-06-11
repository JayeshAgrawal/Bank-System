Public Class accounttype
    Dim var As Integer = 0
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        var = 1
        Button5.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        txtaccounttype.Clear()
        txtminibal.Clear()
        txtineterestrate.Clear()
        txtdescription.Clear()
        Button1.Enabled = True
        ListBox1.Enabled = False
        txtaccounttype.Enabled = True
        txtminibal.Enabled = True
        txtineterestrate.Enabled = True
        txtdescription.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        
        If txtaccounttype.Text = "" Or txtminibal.Text = "" Or txtineterestrate.Text = "" Or txtdescription.Text = "" Then
            MsgBox("Please Fill All Field....", MsgBoxStyle.Information)
            txtaccounttype.Clear()
            txtminibal.Clear()
            txtineterestrate.Clear()
            txtdescription.Clear()
        Else
            If var = 1 Then
                Dim d1 As New a_bankaccount()
                d1.enteracctype(txtaccounttype.Text, txtminibal.Text, txtineterestrate.Text, txtdescription.Text)
                ListBox1.Items.Clear()
                d1.loadacctype()
            ElseIf var = 2 Then
                Dim d2 As New a_bankaccount()
                d2.updateacctype(ListBox1.SelectedItem, txtaccounttype.Text, txtminibal.Text, txtineterestrate.Text, txtdescription.Text)
                ListBox1.Items.Clear()
                d2.loadacctype()
            End If
            jmmmm()
        End If
     
    End Sub

    Private Sub accounttype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button1.Enabled = False
        txtaccounttype.Enabled = False
        txtminibal.Enabled = False
        txtineterestrate.Enabled = False
        txtdescription.Enabled = False
        ListBox1.Items.Clear()
        Dim d3 As New a_bankaccount()
        d3.loadacctype()
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim d4 As New a_bankaccount()
        d4.fillacctype(ListBox1.SelectedItem)
        Button6.Enabled = True
        Button5.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    
        Dim d5 As New a_bankaccount()
        d5.deleteacctype(ListBox1.SelectedItem)
        ListBox1.Items.Clear()
        d5.loadacctype()
        jmmmm()
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        jmmmm()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        var = 2
        Button6.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
        Button1.Enabled = True
        txtaccounttype.Enabled = True
        txtminibal.Enabled = True
        txtineterestrate.Enabled = True
        txtdescription.Enabled = True
    End Sub
    Public Sub jmmmm()
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button1.Enabled = False
        Button5.Enabled = True
        txtaccounttype.Clear()
        txtminibal.Clear()
        txtineterestrate.Clear()
        txtdescription.Clear()
        ListBox1.Enabled = True
        txtaccounttype.Enabled = False
        txtminibal.Enabled = False
        txtineterestrate.Enabled = False
        txtdescription.Enabled = False
    End Sub

    
   
    
End Class