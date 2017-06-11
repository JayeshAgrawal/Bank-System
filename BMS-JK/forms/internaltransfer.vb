Public Class internaltransfer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Enabled = False
        transfer.Show()
        transfer.Activate()
        transfer.txtfromaccno.Text = txtaccno.Text
    End Sub

  
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub internaltransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_transfer()
        m1.loadacclist()
        Button1.Enabled = False
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Button1.Enabled = True
        Dim m1 As New a_transfer()
        m1.loadaccdata(ListBox1.SelectedItem)
    End Sub
End Class