<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setcode
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
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtc_code = New System.Windows.Forms.TextBox
        Me.txtn_code = New System.Windows.Forms.TextBox
        Me.txto_code = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtusertype)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtc_code)
        Me.GroupBox1.Controls.Add(Me.txtn_code)
        Me.GroupBox1.Controls.Add(Me.txto_code)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SETCODE"
        '
        'txtusertype
        '
        Me.txtusertype.Location = New System.Drawing.Point(168, 22)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.ReadOnly = True
        Me.txtusertype.Size = New System.Drawing.Size(152, 23)
        Me.txtusertype.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Code :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "New Code For Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Master Code :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Type :"
        '
        'txtc_code
        '
        Me.txtc_code.Location = New System.Drawing.Point(168, 109)
        Me.txtc_code.Name = "txtc_code"
        Me.txtc_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtc_code.Size = New System.Drawing.Size(152, 23)
        Me.txtc_code.TabIndex = 3
        Me.txtc_code.UseSystemPasswordChar = True
        '
        'txtn_code
        '
        Me.txtn_code.Location = New System.Drawing.Point(168, 80)
        Me.txtn_code.Name = "txtn_code"
        Me.txtn_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtn_code.Size = New System.Drawing.Size(152, 23)
        Me.txtn_code.TabIndex = 2
        Me.txtn_code.UseSystemPasswordChar = True
        '
        'txto_code
        '
        Me.txto_code.Location = New System.Drawing.Point(168, 51)
        Me.txto_code.Name = "txto_code"
        Me.txto_code.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txto_code.Size = New System.Drawing.Size(152, 23)
        Me.txto_code.TabIndex = 1
        Me.txto_code.UseSystemPasswordChar = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(201, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(57, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'setcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(388, 260)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "setcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "setcode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtc_code As System.Windows.Forms.TextBox
    Friend WithEvents txtn_code As System.Windows.Forms.TextBox
    Friend WithEvents txto_code As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
End Class
