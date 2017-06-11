Public Class usermanager

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Enabled = False
        setcode.Show()
        setcode.Activate()
        setcode.txtusertype.Text = "Master"
        setcode.Label2.Text = "Old Master Code"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Enabled = False
        setcode.Show()
        setcode.Activate()
        setcode.txtusertype.Text = "Super"
        setcode.Label2.Text = "Master Code"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        setcode.Show()
        setcode.Activate()
        setcode.txtusertype.Text = "User"
        setcode.Label2.Text = "Master Code"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        userprofile.txtusername.Text = ListBox1.SelectedItem
        userprofile.MdiParent = home
        userprofile.Show()
        userprofile.Activate()
        userprofile.urdet = 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub usermanager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtmastercode.Enabled = False
        txtsupercode.Enabled = False
        txtusercode.Enabled = False
        Button5.Enabled = False
        ComboBox1.Text = "----------------SELECT USER------------------"

        Dim d1 As New a_usermanager()
        d1.loaduser()
    End Sub
   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim d4 As New a_usermanager()
        d4.loadfeatures(ComboBox1.Text)
        Button5.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        
        Dim d6 As New a_usermanager()
        Dim i As New Integer
        Dim fe, ids As String
        Dim st As Boolean
        Me.Cursor = Cursors.WaitCursor
        home.ToolStripProgressBar1.Visible = True
        ids = d6.getid(ComboBox1.Text)
        For i = 0 To featuregv1.RowCount - 1
            st = featuregv1.Rows(i).Cells.Item("status").Value
            fe = featuregv1.Rows(i).Cells.Item("feature").Value
            d6.savefeature(ids, fe, st)
        Next
        MsgBox("Data is UpDateed....", MsgBoxStyle.Information)
        If MsgBox("Do you want to Updating your System...." & "then Press yes and Log out....", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            home.logoutmenu_click(sender, e)
        End If
    End Sub

   

End Class