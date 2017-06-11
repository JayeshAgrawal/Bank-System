<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maketransaction
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtcstno = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.txtoffno = New System.Windows.Forms.TextBox
        Me.txtmono = New System.Windows.Forms.TextBox
        Me.txtmail = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtaccname = New System.Windows.Forms.TextBox
        Me.txtacc = New System.Windows.Forms.TextBox
        Me.txtbal = New System.Windows.Forms.TextBox
        Me.txtcurr = New System.Windows.Forms.TextBox
        Me.txtacctype = New System.Windows.Forms.TextBox
        Me.txtaccno = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Transactionsdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Paymentmethod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Checknumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Particulars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Credit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1282, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcstno)
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.txtacctype)
        Me.GroupBox2.Controls.Add(Me.txtaccno)
        Me.GroupBox2.Location = New System.Drawing.Point(478, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 294)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS :"
        '
        'txtcstno
        '
        Me.txtcstno.Location = New System.Drawing.Point(165, 45)
        Me.txtcstno.Name = "txtcstno"
        Me.txtcstno.ReadOnly = True
        Me.txtcstno.Size = New System.Drawing.Size(171, 20)
        Me.txtcstno.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.PictureBox2)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 227)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(137, 60)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SIGN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Image = Global.BMS_JK.My.Resources.Resources.NoSignature
        Me.PictureBox2.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hold Account Type :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PictureBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(137, 149)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "PHOTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = Global.BMS_JK.My.Resources.Resources.NoPicture
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer NO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account NO :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtfname)
        Me.GroupBox5.Controls.Add(Me.txtgender)
        Me.GroupBox5.Controls.Add(Me.txtoffno)
        Me.GroupBox5.Controls.Add(Me.txtmono)
        Me.GroupBox5.Controls.Add(Me.txtmail)
        Me.GroupBox5.Location = New System.Drawing.Point(165, 72)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(262, 215)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CUSTOMER DETAILS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "E-Mail ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Mobile Phone No :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Office Phone No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Gender :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Full Name :"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(115, 20)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(141, 20)
        Me.txtfname.TabIndex = 0
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(115, 60)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(141, 20)
        Me.txtgender.TabIndex = 1
        '
        'txtoffno
        '
        Me.txtoffno.Location = New System.Drawing.Point(115, 100)
        Me.txtoffno.Name = "txtoffno"
        Me.txtoffno.ReadOnly = True
        Me.txtoffno.Size = New System.Drawing.Size(141, 20)
        Me.txtoffno.TabIndex = 2
        '
        'txtmono
        '
        Me.txtmono.Location = New System.Drawing.Point(115, 140)
        Me.txtmono.Name = "txtmono"
        Me.txtmono.ReadOnly = True
        Me.txtmono.Size = New System.Drawing.Size(141, 20)
        Me.txtmono.TabIndex = 3
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(115, 180)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.ReadOnly = True
        Me.txtmail.Size = New System.Drawing.Size(141, 20)
        Me.txtmail.TabIndex = 4
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtaccname)
        Me.GroupBox6.Controls.Add(Me.txtacc)
        Me.GroupBox6.Controls.Add(Me.txtbal)
        Me.GroupBox6.Controls.Add(Me.txtcurr)
        Me.GroupBox6.Location = New System.Drawing.Point(434, 73)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(262, 215)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ACCOUNT DETAILS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Account Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Account Type :'"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Currency Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Balance :"
        '
        'txtaccname
        '
        Me.txtaccname.Location = New System.Drawing.Point(115, 33)
        Me.txtaccname.Name = "txtaccname"
        Me.txtaccname.ReadOnly = True
        Me.txtaccname.Size = New System.Drawing.Size(141, 20)
        Me.txtaccname.TabIndex = 5
        '
        'txtacc
        '
        Me.txtacc.Location = New System.Drawing.Point(115, 77)
        Me.txtacc.Name = "txtacc"
        Me.txtacc.ReadOnly = True
        Me.txtacc.Size = New System.Drawing.Size(141, 20)
        Me.txtacc.TabIndex = 6
        '
        'txtbal
        '
        Me.txtbal.Location = New System.Drawing.Point(115, 168)
        Me.txtbal.Name = "txtbal"
        Me.txtbal.ReadOnly = True
        Me.txtbal.Size = New System.Drawing.Size(141, 20)
        Me.txtbal.TabIndex = 8
        '
        'txtcurr
        '
        Me.txtcurr.Location = New System.Drawing.Point(115, 123)
        Me.txtcurr.Name = "txtcurr"
        Me.txtcurr.ReadOnly = True
        Me.txtcurr.Size = New System.Drawing.Size(141, 20)
        Me.txtcurr.TabIndex = 7
        '
        'txtacctype
        '
        Me.txtacctype.Location = New System.Drawing.Point(496, 19)
        Me.txtacctype.Name = "txtacctype"
        Me.txtacctype.ReadOnly = True
        Me.txtacctype.Size = New System.Drawing.Size(171, 20)
        Me.txtacctype.TabIndex = 1
        '
        'txtaccno
        '
        Me.txtaccno.Location = New System.Drawing.Point(165, 19)
        Me.txtaccno.Name = "txtaccno"
        Me.txtaccno.ReadOnly = True
        Me.txtaccno.Size = New System.Drawing.Size(171, 20)
        Me.txtaccno.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(490, 581)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(686, 59)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(384, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 34)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "CLOSE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(119, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "NEW TRANSACTION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 550)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCOUNTS"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(253, 524)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(478, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 183)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRANSACTION DETAILS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Transactionsdate, Me.Paymentmethod, Me.Checknumber, Me.Particulars, Me.Credit, Me.Debit, Me.Status})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(714, 164)
        Me.DataGridView1.TabIndex = 0
        '
        'Transactionsdate
        '
        Me.Transactionsdate.HeaderText = "Transactions date"
        Me.Transactionsdate.Name = "Transactionsdate"
        Me.Transactionsdate.ReadOnly = True
        Me.Transactionsdate.Width = 80
        '
        'Paymentmethod
        '
        Me.Paymentmethod.HeaderText = "Payment Method"
        Me.Paymentmethod.Name = "Paymentmethod"
        Me.Paymentmethod.ReadOnly = True
        Me.Paymentmethod.Width = 120
        '
        'Checknumber
        '
        Me.Checknumber.HeaderText = "Check Number"
        Me.Checknumber.Name = "Checknumber"
        Me.Checknumber.ReadOnly = True
        Me.Checknumber.Width = 115
        '
        'Particulars
        '
        Me.Particulars.HeaderText = "Particulars"
        Me.Particulars.Name = "Particulars"
        Me.Particulars.ReadOnly = True
        Me.Particulars.Width = 130
        '
        'Credit
        '
        Me.Credit.HeaderText = "Credit"
        Me.Credit.Name = "Credit"
        Me.Credit.ReadOnly = True
        Me.Credit.Width = 80
        '
        'Debit
        '
        Me.Debit.HeaderText = "Debit"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        Me.Debit.Width = 80
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status.Width = 47
        '
        'maketransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1282, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "maketransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Make Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtoffno As System.Windows.Forms.TextBox
    Friend WithEvents txtmono As System.Windows.Forms.TextBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtaccname As System.Windows.Forms.TextBox
    Friend WithEvents txtacc As System.Windows.Forms.TextBox
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents txtcurr As System.Windows.Forms.TextBox
    Friend WithEvents txtacctype As System.Windows.Forms.TextBox
    Friend WithEvents txtaccno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtcstno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Transactionsdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paymentmethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Checknumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Particulars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
