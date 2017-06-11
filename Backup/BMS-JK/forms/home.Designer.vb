<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.homemenu = New System.Windows.Forms.ToolStripMenuItem
        Me.userprofilemenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.logoutmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.exitmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.adminmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.bankprofilemenu = New System.Windows.Forms.ToolStripMenuItem
        Me.bankbranchesmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.bankaccountsmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.chequebookmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.accounttypemenu = New System.Windows.Forms.ToolStripMenuItem
        Me.usermanagermenu = New System.Windows.Forms.ToolStripMenuItem
        Me.transactionmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.maketransactionmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.internaltransfermenu = New System.Windows.Forms.ToolStripMenuItem
        Me.reportsmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.customerreportsmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.alltransactionreportsmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.accountstatementsmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.utilitymenu = New System.Windows.Forms.ToolStripMenuItem
        Me.calculatormenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homemenu, Me.adminmenu, Me.transactionmenu, Me.reportsmenu, Me.utilitymenu, Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip.ShowItemToolTips = True
        Me.MenuStrip.Size = New System.Drawing.Size(1026, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        Me.ToolTip.SetToolTip(Me.MenuStrip, "Please The Menu......")
        '
        'homemenu
        '
        Me.homemenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userprofilemenu, Me.ToolStripSeparator4, Me.logoutmenu, Me.exitmenu})
        Me.homemenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.homemenu.Name = "homemenu"
        Me.homemenu.Size = New System.Drawing.Size(46, 20)
        Me.homemenu.Text = "&Home"
        '
        'userprofilemenu
        '
        Me.userprofilemenu.ImageTransparentColor = System.Drawing.Color.Black
        Me.userprofilemenu.Name = "userprofilemenu"
        Me.userprofilemenu.Size = New System.Drawing.Size(140, 22)
        Me.userprofilemenu.Text = "&User Profile"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(137, 6)
        '
        'logoutmenu
        '
        Me.logoutmenu.Name = "logoutmenu"
        Me.logoutmenu.Size = New System.Drawing.Size(140, 22)
        Me.logoutmenu.Text = "&Log Out"
        '
        'exitmenu
        '
        Me.exitmenu.Name = "exitmenu"
        Me.exitmenu.Size = New System.Drawing.Size(140, 22)
        Me.exitmenu.Text = "&Exit"
        '
        'adminmenu
        '
        Me.adminmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bankprofilemenu, Me.bankbranchesmenu, Me.ToolStripSeparator6, Me.bankaccountsmenu, Me.chequebookmenu, Me.ToolStripSeparator7, Me.accounttypemenu, Me.usermanagermenu})
        Me.adminmenu.Name = "adminmenu"
        Me.adminmenu.Size = New System.Drawing.Size(48, 20)
        Me.adminmenu.Text = "&Admin"
        '
        'bankprofilemenu
        '
        Me.bankprofilemenu.Name = "bankprofilemenu"
        Me.bankprofilemenu.Size = New System.Drawing.Size(155, 22)
        Me.bankprofilemenu.Text = "&Bank Profile"
        '
        'bankbranchesmenu
        '
        Me.bankbranchesmenu.Name = "bankbranchesmenu"
        Me.bankbranchesmenu.Size = New System.Drawing.Size(155, 22)
        Me.bankbranchesmenu.Text = "Ba&nk Braches"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'bankaccountsmenu
        '
        Me.bankaccountsmenu.Name = "bankaccountsmenu"
        Me.bankaccountsmenu.Size = New System.Drawing.Size(155, 22)
        Me.bankaccountsmenu.Text = "Bank &Accounts"
        '
        'chequebookmenu
        '
        Me.chequebookmenu.Name = "chequebookmenu"
        Me.chequebookmenu.Size = New System.Drawing.Size(155, 22)
        Me.chequebookmenu.Text = "&Cheque Book"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(152, 6)
        '
        'accounttypemenu
        '
        Me.accounttypemenu.Name = "accounttypemenu"
        Me.accounttypemenu.Size = New System.Drawing.Size(155, 22)
        Me.accounttypemenu.Text = "Account &Type"
        '
        'usermanagermenu
        '
        Me.usermanagermenu.Name = "usermanagermenu"
        Me.usermanagermenu.Size = New System.Drawing.Size(155, 22)
        Me.usermanagermenu.Text = "&User Manager"
        '
        'transactionmenu
        '
        Me.transactionmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.maketransactionmenu, Me.internaltransfermenu})
        Me.transactionmenu.Name = "transactionmenu"
        Me.transactionmenu.Size = New System.Drawing.Size(75, 20)
        Me.transactionmenu.Text = "&Transaction"
        '
        'maketransactionmenu
        '
        Me.maketransactionmenu.Name = "maketransactionmenu"
        Me.maketransactionmenu.Size = New System.Drawing.Size(169, 22)
        Me.maketransactionmenu.Text = "&Make Transaction"
        '
        'internaltransfermenu
        '
        Me.internaltransfermenu.Name = "internaltransfermenu"
        Me.internaltransfermenu.Size = New System.Drawing.Size(169, 22)
        Me.internaltransfermenu.Text = "&Internal Transfer"
        '
        'reportsmenu
        '
        Me.reportsmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customerreportsmenu, Me.alltransactionreportsmenu, Me.accountstatementsmenu})
        Me.reportsmenu.Name = "reportsmenu"
        Me.reportsmenu.Size = New System.Drawing.Size(57, 20)
        Me.reportsmenu.Text = "&Reports"
        '
        'customerreportsmenu
        '
        Me.customerreportsmenu.Name = "customerreportsmenu"
        Me.customerreportsmenu.Size = New System.Drawing.Size(196, 22)
        Me.customerreportsmenu.Text = "&Customer Reports"
        '
        'alltransactionreportsmenu
        '
        Me.alltransactionreportsmenu.Name = "alltransactionreportsmenu"
        Me.alltransactionreportsmenu.Size = New System.Drawing.Size(196, 22)
        Me.alltransactionreportsmenu.Text = "&All Transaction Reports"
        '
        'accountstatementsmenu
        '
        Me.accountstatementsmenu.Name = "accountstatementsmenu"
        Me.accountstatementsmenu.Size = New System.Drawing.Size(196, 22)
        Me.accountstatementsmenu.Text = "&Account Statements"
        '
        'utilitymenu
        '
        Me.utilitymenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.calculatormenu})
        Me.utilitymenu.Name = "utilitymenu"
        Me.utilitymenu.Size = New System.Drawing.Size(46, 20)
        Me.utilitymenu.Text = "&Utility"
        '
        'calculatormenu
        '
        Me.calculatormenu.Name = "calculatormenu"
        Me.calculatormenu.Size = New System.Drawing.Size(133, 22)
        Me.calculatormenu.Text = "&Calculator"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripMenuItem1.Text = "&About us"
        '
        'StatusStrip
        '
        Me.StatusStrip.AllowDrop = True
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.ToolStripProgressBar1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 714)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1026, 22)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(96, 17)
        Me.ToolStripStatusLabel1.Text = "User Name :"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel2.Text = "Jayesh"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(31, 17)
        Me.ToolStripStatusLabel3.Text = "        "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(118, 17)
        Me.ToolStripStatusLabel4.Text = "System Time"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(140, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.BackgroundImage = Global.BMS_JK.My.Resources.Resources.jay_copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 736)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BANK MANAGEMENT SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculatormenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents logoutmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userprofilemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents homemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents transactionmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents utilitymenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reportsmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents maketransactionmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents internaltransfermenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customerreportsmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents alltransactionreportsmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents accountstatementsmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents adminmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bankprofilemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bankbranchesmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bankaccountsmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chequebookmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents accounttypemenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents usermanagermenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
