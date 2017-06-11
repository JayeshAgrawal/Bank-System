Imports System.Windows.Forms

Public Class home
    
    Private Sub userprofilemenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userprofilemenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        userprofile.MdiParent = Me
        userprofile.txtusername.Text = ToolStripStatusLabel2.Text
        userprofile.Show()
        userprofile.urdet = 0
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub bankaccountsmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bankaccountsmenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        bankaccounts.MdiParent = Me
        bankaccounts.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub bankprofilemenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bankprofilemenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        bankprofile.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub bankbranchesmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bankbranchesmenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        bankbranches.MdiParent = Me
        bankbranches.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub chequebookmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chequebookmenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        chequebooks.MdiParent = Me
        chequebooks.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub accounttypemenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accounttypemenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        accounttype.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = Me.MinimumSize
      
    End Sub
    Private Sub maketransactionmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maketransactionmenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        maketransaction.MdiParent = Me
        maketransaction.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub usermanagermenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usermanagermenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        usermanager.MdiParent = Me
        usermanager.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub
    Private Sub internaltransfermenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles internaltransfermenu.Click
        Me.IsMdiContainer = True
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        internaltransfer.MdiParent = Me
        internaltransfer.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub
    Private Sub calculatormenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatormenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        Calculator.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        aboutus.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = TimeOfDay + "   " + Format(Now.Date, "MMMM dd, yyyy")
    End Sub

    Public Sub logoutmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutmenu.Click
        If MsgBox("Are you sure? Do you want Log out ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            ToolStripProgressBar1.Visible = True
            Dim ldate, stat As String
            ldate = ToolStripStatusLabel4.Text
            stat = "Disabled"
            Dim dtw As New a_loginform()
            dtw.lastcall(ToolStripStatusLabel2.Text, ldate, stat)
            userprofile.Close()
            bankaccounts.Close()
            bankprofile.Close()
            bankbranches.Close()
            chequebooks.Close()
            accounttype.Close()
            maketransaction.Close()
            usermanager.Close()
            internaltransfer.Close()
            Calculator.Close()
            aboutus.Close()
            Me.Hide()
            loginform.Show()
            loginform.Activate()
            Me.Cursor = Cursors.Arrow
            ToolStripProgressBar1.Visible = False
        End If
    End Sub

    Private Sub exitmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitmenu.Click
        If MsgBox("Are you sure? Do you want close application ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        bankprofile.Close()
        accounttype.Close()
        Calculator.Close()
        aboutus.Close()
        Dim ldate, stat As String
        ldate = ToolStripStatusLabel4.Text
        stat = "Disabled"
        Dim dtw As New a_loginform()
        dtw.lastcall(ToolStripStatusLabel2.Text, ldate, stat)
    End Sub

    Private Sub accountstatementsmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountstatementsmenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        accountstatement.MdiParent = Me
        accountstatement.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub alltransactionreportsmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alltransactionreportsmenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        alltransactions.MdiParent = Me
        alltransactions.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub customerreportsmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerreportsmenu.Click
        Me.Cursor = Cursors.WaitCursor
        ToolStripProgressBar1.Visible = True
        customerreports.MdiParent = Me
        customerreports.Show()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Visible = False
    End Sub


End Class
