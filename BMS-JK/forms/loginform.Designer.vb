<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Softwere Made By : JAYESH AGRAWAL " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                 Kishan Mistr" & _
            "y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                 Jay Patel"
        Me.NotifyIcon1.BalloonTipTitle = "About Software Devloper"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtusertype)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.txtusername)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Violet
        Me.GroupBox2.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 197)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "For Login Please Enter User Type ...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name :"
        '
        'txtusertype
        '
        Me.txtusertype.Location = New System.Drawing.Point(113, 147)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.Size = New System.Drawing.Size(226, 23)
        Me.txtusertype.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(113, 74)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(226, 23)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(113, 33)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(226, 23)
        Me.txtusername.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Violet
        Me.GroupBox1.Location = New System.Drawing.Point(19, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 60)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button3.Location = New System.Drawing.Point(243, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(134, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "NEW USER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(391, 284)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(401, 320)
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOG IN"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
