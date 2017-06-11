<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bankbranches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bankbranches))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtbranchno = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbranchname = New System.Windows.Forms.TextBox
        Me.txtph1 = New System.Windows.Forms.TextBox
        Me.txtph2 = New System.Windows.Forms.TextBox
        Me.txtfax1 = New System.Windows.Forms.TextBox
        Me.txtfax2 = New System.Windows.Forms.TextBox
        Me.txtpobox = New System.Windows.Forms.TextBox
        Me.txtweb = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtcountry = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(94, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 399)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BANK BRANCHES"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(17, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(297, 364)
        Me.ListBox1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(94, 483)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1093, 80)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(37, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 43)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ADD NEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(212, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 43)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.Location = New System.Drawing.Point(386, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 43)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(567, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 43)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(743, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 43)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "CANCEL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button7.Location = New System.Drawing.Point(916, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 43)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "CLOSE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtbranchno)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtbranchname)
        Me.GroupBox2.Controls.Add(Me.txtph1)
        Me.GroupBox2.Controls.Add(Me.txtph2)
        Me.GroupBox2.Controls.Add(Me.txtfax1)
        Me.GroupBox2.Controls.Add(Me.txtfax2)
        Me.GroupBox2.Controls.Add(Me.txtpobox)
        Me.GroupBox2.Controls.Add(Me.txtweb)
        Me.GroupBox2.Controls.Add(Me.txtcity)
        Me.GroupBox2.Controls.Add(Me.txtcountry)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(480, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 399)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BRANCH DETAILS"
        '
        'txtbranchno
        '
        Me.txtbranchno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbranchno.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtbranchno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbranchno.Location = New System.Drawing.Point(421, 49)
        Me.txtbranchno.Name = "txtbranchno"
        Me.txtbranchno.Size = New System.Drawing.Size(248, 23)
        Me.txtbranchno.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(301, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Address :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Country :"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(301, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "City :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(301, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Website :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(301, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PO Box :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Fax Number2 :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fax Number1 :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Phone No2 :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Phone No1 :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Branch Name :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Branch No :"
        '
        'txtbranchname
        '
        Me.txtbranchname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbranchname.Location = New System.Drawing.Point(421, 78)
        Me.txtbranchname.Name = "txtbranchname"
        Me.txtbranchname.Size = New System.Drawing.Size(248, 23)
        Me.txtbranchname.TabIndex = 3
        '
        'txtph1
        '
        Me.txtph1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtph1.Location = New System.Drawing.Point(421, 107)
        Me.txtph1.Name = "txtph1"
        Me.txtph1.Size = New System.Drawing.Size(248, 23)
        Me.txtph1.TabIndex = 4
        '
        'txtph2
        '
        Me.txtph2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtph2.Location = New System.Drawing.Point(421, 136)
        Me.txtph2.Name = "txtph2"
        Me.txtph2.Size = New System.Drawing.Size(248, 23)
        Me.txtph2.TabIndex = 5
        '
        'txtfax1
        '
        Me.txtfax1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfax1.Location = New System.Drawing.Point(421, 165)
        Me.txtfax1.Name = "txtfax1"
        Me.txtfax1.Size = New System.Drawing.Size(248, 23)
        Me.txtfax1.TabIndex = 6
        '
        'txtfax2
        '
        Me.txtfax2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfax2.Location = New System.Drawing.Point(421, 194)
        Me.txtfax2.Name = "txtfax2"
        Me.txtfax2.Size = New System.Drawing.Size(248, 23)
        Me.txtfax2.TabIndex = 7
        '
        'txtpobox
        '
        Me.txtpobox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpobox.Location = New System.Drawing.Point(421, 223)
        Me.txtpobox.Name = "txtpobox"
        Me.txtpobox.Size = New System.Drawing.Size(248, 23)
        Me.txtpobox.TabIndex = 8
        '
        'txtweb
        '
        Me.txtweb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtweb.Location = New System.Drawing.Point(421, 252)
        Me.txtweb.Name = "txtweb"
        Me.txtweb.Size = New System.Drawing.Size(248, 23)
        Me.txtweb.TabIndex = 9
        '
        'txtcity
        '
        Me.txtcity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcity.Location = New System.Drawing.Point(421, 281)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(248, 23)
        Me.txtcity.TabIndex = 10
        '
        'txtcountry
        '
        Me.txtcountry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcountry.Location = New System.Drawing.Point(421, 310)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(248, 23)
        Me.txtcountry.TabIndex = 11
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaddress.Location = New System.Drawing.Point(421, 339)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(248, 23)
        Me.txtaddress.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 283)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LOGO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(6, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD LOGO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1282, 84)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bank Branches"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 605)
        Me.Panel2.TabIndex = 0
        '
        'bankbranches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1282, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "bankbranches"
        Me.Text = "Bank Branches"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbranchno As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbranchname As System.Windows.Forms.TextBox
    Friend WithEvents txtph1 As System.Windows.Forms.TextBox
    Friend WithEvents txtph2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfax1 As System.Windows.Forms.TextBox
    Friend WithEvents txtfax2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpobox As System.Windows.Forms.TextBox
    Friend WithEvents txtweb As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtcountry As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
