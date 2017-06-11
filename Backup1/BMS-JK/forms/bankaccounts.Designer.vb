<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bankaccounts
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbcurrency = New System.Windows.Forms.TextBox
        Me.txtaccname = New System.Windows.Forms.TextBox
        Me.cmbacctype = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.txtintdeposit = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbcustomerno = New System.Windows.Forms.TextBox
        Me.cmbholderacctype = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtaccountno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 77)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1282, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bank Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbcurrency)
        Me.GroupBox3.Controls.Add(Me.txtaccname)
        Me.GroupBox3.Controls.Add(Me.cmbacctype)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.txtbalance)
        Me.GroupBox3.Controls.Add(Me.txtintdeposit)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(499, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(765, 309)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Detail"
        '
        'cmbcurrency
        '
        Me.cmbcurrency.Location = New System.Drawing.Point(306, 125)
        Me.cmbcurrency.Name = "cmbcurrency"
        Me.cmbcurrency.ReadOnly = True
        Me.cmbcurrency.Size = New System.Drawing.Size(357, 23)
        Me.cmbcurrency.TabIndex = 12
        Me.cmbcurrency.Text = "INDIAN CURRENCY(INR)"
        Me.cmbcurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaccname
        '
        Me.txtaccname.Location = New System.Drawing.Point(306, 49)
        Me.txtaccname.Name = "txtaccname"
        Me.txtaccname.Size = New System.Drawing.Size(357, 23)
        Me.txtaccname.TabIndex = 7
        '
        'cmbacctype
        '
        Me.cmbacctype.FormattingEnabled = True
        Me.cmbacctype.Location = New System.Drawing.Point(306, 87)
        Me.cmbacctype.Name = "cmbacctype"
        Me.cmbacctype.Size = New System.Drawing.Size(357, 23)
        Me.cmbacctype.TabIndex = 11
        Me.cmbacctype.Text = "---------------------SELECT----------------------"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy "
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(306, 242)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(357, 23)
        Me.DateTimePicker1.TabIndex = 10
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(306, 202)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(357, 23)
        Me.txtbalance.TabIndex = 8
        '
        'txtintdeposit
        '
        Me.txtintdeposit.Location = New System.Drawing.Point(306, 163)
        Me.txtintdeposit.Name = "txtintdeposit"
        Me.txtintdeposit.Size = New System.Drawing.Size(357, 23)
        Me.txtintdeposit.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(128, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Data Opened :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Balance :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Initial Deposit :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Currency Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Account Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Account Name :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Location = New System.Drawing.Point(99, 574)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1165, 75)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button7.Location = New System.Drawing.Point(797, 24)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(154, 36)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "CANCEL"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button8.Location = New System.Drawing.Point(978, 24)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(154, 36)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "CLOSE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button6.Location = New System.Drawing.Point(605, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(154, 36)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "DELETE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(420, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 36)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.Location = New System.Drawing.Point(224, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 36)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "EDIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(35, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 36)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "ADD ACCOUNT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbcustomerno)
        Me.GroupBox2.Controls.Add(Me.cmbholderacctype)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtaccountno)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(499, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(765, 158)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'cmbcustomerno
        '
        Me.cmbcustomerno.Location = New System.Drawing.Point(306, 116)
        Me.cmbcustomerno.Name = "cmbcustomerno"
        Me.cmbcustomerno.ReadOnly = True
        Me.cmbcustomerno.Size = New System.Drawing.Size(252, 23)
        Me.cmbcustomerno.TabIndex = 14
        '
        'cmbholderacctype
        '
        Me.cmbholderacctype.Location = New System.Drawing.Point(306, 69)
        Me.cmbholderacctype.Name = "cmbholderacctype"
        Me.cmbholderacctype.ReadOnly = True
        Me.cmbholderacctype.Size = New System.Drawing.Size(252, 23)
        Me.cmbholderacctype.TabIndex = 13
        Me.cmbholderacctype.Text = "Holder Account"
        Me.cmbholderacctype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer No :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(626, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SHOW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtaccountno
        '
        Me.txtaccountno.Location = New System.Drawing.Point(306, 22)
        Me.txtaccountno.Name = "txtaccountno"
        Me.txtaccountno.ReadOnly = True
        Me.txtaccountno.Size = New System.Drawing.Size(252, 23)
        Me.txtaccountno.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hold Account Type  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account No  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 473)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accounts"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(3, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(297, 439)
        Me.ListBox1.TabIndex = 0
        '
        'bankaccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1282, 744)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "bankaccounts"
        Me.Text = "Bank Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbcurrency As System.Windows.Forms.TextBox
    Friend WithEvents txtaccname As System.Windows.Forms.TextBox
    Friend WithEvents cmbacctype As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtintdeposit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbholderacctype As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtaccountno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents cmbcustomerno As System.Windows.Forms.TextBox
End Class
