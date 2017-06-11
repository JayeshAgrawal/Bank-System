<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newuser
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtc_password = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(22, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 69)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(220, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(68, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtc_password)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusertype)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 194)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(161, 32)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(131, 23)
        Me.txtusername.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button3.Location = New System.Drawing.Point(310, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "User Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password :"
        '
        'txtc_password
        '
        Me.txtc_password.Location = New System.Drawing.Point(161, 146)
        Me.txtc_password.Name = "txtc_password"
        Me.txtc_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtc_password.Size = New System.Drawing.Size(131, 23)
        Me.txtc_password.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirm Password :"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(161, 108)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(131, 23)
        Me.txtpassword.TabIndex = 17
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusertype
        '
        Me.txtusertype.Location = New System.Drawing.Point(161, 70)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.ReadOnly = True
        Me.txtusertype.Size = New System.Drawing.Size(131, 23)
        Me.txtusertype.TabIndex = 16
        '
        'newuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(425, 300)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "newuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtc_password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
