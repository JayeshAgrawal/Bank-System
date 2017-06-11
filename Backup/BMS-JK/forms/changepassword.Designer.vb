<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtc_password = New System.Windows.Forms.TextBox
        Me.txtnewpassword = New System.Windows.Forms.TextBox
        Me.txtoldpassword = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtc_password)
        Me.GroupBox1.Controls.Add(Me.txtnewpassword)
        Me.GroupBox1.Controls.Add(Me.txtoldpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER NAME :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OLD PASSWORD :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NEW PASSWORD :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CONFIRM PASSWORD :"
        '
        'txtc_password
        '
        Me.txtc_password.Location = New System.Drawing.Point(189, 183)
        Me.txtc_password.Name = "txtc_password"
        Me.txtc_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtc_password.Size = New System.Drawing.Size(161, 23)
        Me.txtc_password.TabIndex = 3
        Me.txtc_password.UseSystemPasswordChar = True
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Location = New System.Drawing.Point(189, 135)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.Size = New System.Drawing.Size(161, 23)
        Me.txtnewpassword.TabIndex = 2
        Me.txtnewpassword.UseSystemPasswordChar = True
        '
        'txtoldpassword
        '
        Me.txtoldpassword.Location = New System.Drawing.Point(189, 84)
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpassword.Size = New System.Drawing.Size(161, 23)
        Me.txtoldpassword.TabIndex = 1
        Me.txtoldpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(189, 35)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(161, 23)
        Me.txtusername.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 65)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(40, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(224, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(435, 340)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "changepassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtc_password As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtoldpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
