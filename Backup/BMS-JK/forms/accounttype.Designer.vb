<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounttype
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.txtaccounttype = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.txtineterestrate = New System.Windows.Forms.TextBox
        Me.txtminibal = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.txtaccounttype)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtineterestrate)
        Me.GroupBox1.Controls.Add(Me.txtminibal)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAILS"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(7, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(221, 199)
        Me.ListBox1.TabIndex = 9
        '
        'txtaccounttype
        '
        Me.txtaccounttype.Location = New System.Drawing.Point(365, 22)
        Me.txtaccounttype.Name = "txtaccounttype"
        Me.txtaccounttype.Size = New System.Drawing.Size(202, 23)
        Me.txtaccounttype.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Interest Rate :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minimum Balance :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Account Type :"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(365, 113)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(202, 123)
        Me.txtdescription.TabIndex = 3
        '
        'txtineterestrate
        '
        Me.txtineterestrate.Location = New System.Drawing.Point(365, 83)
        Me.txtineterestrate.Name = "txtineterestrate"
        Me.txtineterestrate.Size = New System.Drawing.Size(202, 23)
        Me.txtineterestrate.TabIndex = 2
        '
        'txtminibal
        '
        Me.txtminibal.Location = New System.Drawing.Point(365, 53)
        Me.txtminibal.Name = "txtminibal"
        Me.txtminibal.Size = New System.Drawing.Size(202, 23)
        Me.txtminibal.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(101, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 27)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "EDIT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(7, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "ADD NEW"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.Location = New System.Drawing.Point(196, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(290, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(479, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(385, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'accounttype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(619, 351)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "accounttype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Type "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtineterestrate As System.Windows.Forms.TextBox
    Friend WithEvents txtminibal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtaccounttype As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
