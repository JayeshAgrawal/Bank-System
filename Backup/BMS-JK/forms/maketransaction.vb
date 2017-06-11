Public Class maketransaction
    Private Sub maketransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_transaction()
        m1.loadacclist()
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Enabled = False
        newtransaction.Show()
        newtransaction.Activate()
        newtransaction.txtaccno.Text = txtaccno.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim m1 As New a_transaction()
        m1.loadaccdata(ListBox1.SelectedItem)
        Button1.Enabled = True
    End Sub
End Class