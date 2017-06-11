Public Class chequebooks

    
    Dim start As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DateTimePicker1.Text = "" Or cmbaccno.Text = "----------------SELECT--------------" Or txtnoofsheet.Text = "" Then
            MsgBox("Please fill all fields...", MsgBoxStyle.Information)
        Else
            Me.Cursor = Cursors.WaitCursor
            home.ToolStripProgressBar1.Visible = True
            start = "1"
            Dim d1 As New a_bankaccount()
            Dim noo As String
            noo = d1.givecheno()
            txtchequebookno.Text = noo
            d1.newchequebook(txtchequebookno.Text, cmbaccno.Text, DateTimePicker1.Text, start, txtnoofsheet.Text)
            Me.Cursor = Cursors.Arrow
            home.ToolStripProgressBar1.Visible = False
            ListBox1.Items.Clear()
            Dim m1 As New a_bankaccount()
            m1.loadchequebook()
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button1.Enabled = True
            ListBox1.Enabled = True
            jkk()
        End If
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Enabled = False
        Button1.Enabled = False
        GroupBox2.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        jkk()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub chequebooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_bankaccount()
        m1.loadchequebook()
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
    Private Sub txtnoofsheet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoofsheet.KeyPress
        ToolTip1.Show("Number Of Sheet must be 10,25 Sheets....", txtnoofsheet)
        ToolTip1.Hide(txtnoofsheet)
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim m1 As New a_bankaccount()
        m1.loadcheinfo(ListBox1.SelectedItem)
        Button1.Enabled = False
        ListBox1.Enabled = False
        GroupBox2.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub
    Private Sub jkk()
        txtchequebookno.Clear()
        DateTimePicker1.Text = ""
        cmbaccno.Text = "----------------SELECT--------------"
        txtnoofsheet.Clear()
        DataGridView1.Rows.Clear()
    End Sub
  
 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
        ListBox1.Enabled = True
        jkk()
    End Sub

   
End Class