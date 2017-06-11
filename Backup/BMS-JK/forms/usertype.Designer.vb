<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usertype
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtcode = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Code For Your User Type :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(129, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 60)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(26, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(50, 43)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcode.Size = New System.Drawing.Size(135, 23)
        Me.txtcode.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 85)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER TYPE CODE"
        '
        'usertype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(292, 182)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "usertype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Type"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
