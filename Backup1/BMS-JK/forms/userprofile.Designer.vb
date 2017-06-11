<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userprofile))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.featuregv1 = New System.Windows.Forms.DataGridView
        Me.feature = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtl_logindate = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtstatus = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtusertype = New System.Windows.Forms.TextBox
        Me.txtfullname = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.featuregv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(159, 382)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 68)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button7.Location = New System.Drawing.Point(780, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 33)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(597, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 33)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(412, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 33)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.Location = New System.Drawing.Point(226, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(44, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(153, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1282, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Profile"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(159, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 299)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(7, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Photo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox4.Controls.Add(Me.featuregv1)
        Me.GroupBox4.Location = New System.Drawing.Point(159, 456)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(968, 208)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Available Features"
        '
        'featuregv1
        '
        Me.featuregv1.AllowUserToAddRows = False
        Me.featuregv1.AllowUserToDeleteRows = False
        Me.featuregv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.feature, Me.status})
        Me.featuregv1.Location = New System.Drawing.Point(17, 22)
        Me.featuregv1.Name = "featuregv1"
        Me.featuregv1.ReadOnly = True
        Me.featuregv1.Size = New System.Drawing.Size(934, 171)
        Me.featuregv1.TabIndex = 0
        '
        'feature
        '
        Me.feature.HeaderText = "feature"
        Me.feature.Name = "feature"
        Me.feature.ReadOnly = True
        Me.feature.Width = 702
        '
        'status
        '
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 170
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.dtl_logindate)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtstatus)
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.txtusertype)
        Me.GroupBox2.Controls.Add(Me.txtfullname)
        Me.GroupBox2.Controls.Add(Me.txtusername)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 299)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Details"
        '
        'dtl_logindate
        '
        Me.dtl_logindate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtl_logindate.CustomFormat = "MMMM dd, yyyy hh:mm:ss tt"
        Me.dtl_logindate.Enabled = False
        Me.dtl_logindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtl_logindate.Location = New System.Drawing.Point(264, 252)
        Me.dtl_logindate.Name = "dtl_logindate"
        Me.dtl_logindate.Size = New System.Drawing.Size(240, 23)
        Me.dtl_logindate.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(550, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtstatus
        '
        Me.txtstatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtstatus.Location = New System.Drawing.Point(264, 207)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(240, 23)
        Me.txtstatus.TabIndex = 10
        Me.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpassword.Location = New System.Drawing.Point(264, 161)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.ReadOnly = True
        Me.txtpassword.Size = New System.Drawing.Size(240, 23)
        Me.txtpassword.TabIndex = 9
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusertype
        '
        Me.txtusertype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusertype.Location = New System.Drawing.Point(264, 116)
        Me.txtusertype.Name = "txtusertype"
        Me.txtusertype.ReadOnly = True
        Me.txtusertype.Size = New System.Drawing.Size(240, 23)
        Me.txtusertype.TabIndex = 8
        '
        'txtfullname
        '
        Me.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfullname.Location = New System.Drawing.Point(264, 75)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(240, 23)
        Me.txtfullname.TabIndex = 7
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.Location = New System.Drawing.Point(264, 34)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.ReadOnly = True
        Me.txtusername.Size = New System.Drawing.Size(240, 23)
        Me.txtusername.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "LAST LOGIN DATE :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CURRENT STATUS :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PASSWORD :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "USER TYPE :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FULL NAME :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USER NAME :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 718)
        Me.Panel2.TabIndex = 0
        '
        'userprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1282, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1590, 781)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1278, 720)
        Me.Name = "userprofile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Profile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.featuregv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents featuregv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtl_logindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusertype As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents feature As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
