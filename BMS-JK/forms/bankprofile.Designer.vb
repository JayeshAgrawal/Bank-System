<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bankprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bankprofile))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtslogan = New System.Windows.Forms.TextBox
        Me.txtwebsite = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtbankname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(9, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Logo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtslogan)
        Me.GroupBox2.Controls.Add(Me.txtwebsite)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtbankname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(207, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 211)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS"
        '
        'txtslogan
        '
        Me.txtslogan.Location = New System.Drawing.Point(140, 141)
        Me.txtslogan.Name = "txtslogan"
        Me.txtslogan.Size = New System.Drawing.Size(215, 23)
        Me.txtslogan.TabIndex = 7
        '
        'txtwebsite
        '
        Me.txtwebsite.Location = New System.Drawing.Point(140, 112)
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.Size = New System.Drawing.Size(215, 23)
        Me.txtwebsite.TabIndex = 6
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(140, 83)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(215, 23)
        Me.txtemail.TabIndex = 5
        '
        'txtbankname
        '
        Me.txtbankname.Location = New System.Drawing.Point(140, 50)
        Me.txtbankname.Name = "txtbankname"
        Me.txtbankname.Size = New System.Drawing.Size(215, 23)
        Me.txtbankname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Slogan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Web Site :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E-Mail ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 63)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(7, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(101, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.Location = New System.Drawing.Point(196, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(290, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 27)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(385, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 27)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "CENCEL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button7.Location = New System.Drawing.Point(479, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 27)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "CLOSE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'bankprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(619, 312)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "bankprofile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Profile"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtslogan As System.Windows.Forms.TextBox
    Friend WithEvents txtwebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtbankname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
