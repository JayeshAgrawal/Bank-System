<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alltransactions
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1362, 79)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(584, 103)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(46, 19)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "All"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(752, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 19)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Uncleared"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(650, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 19)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cleared"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(486, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(222, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 23)
        Me.TextBox1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cheque No : "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(438, 21)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 23)
        Me.DateTimePicker2.TabIndex = 12
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(416, 26)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(389, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "From"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(258, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(486, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Transaction Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Transaction Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(279, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 23)
        Me.DateTimePicker1.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(222, 61)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.Text = "----------SELECT----------"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cheque", "Deposit", "Withdrawal", "Cash", "TRANSFER"})
        Me.ComboBox2.Location = New System.Drawing.Point(640, 61)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Text = "----------SELECT----------"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 76)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(602, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(369, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(127, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(230, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 327)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(3, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(908, 263)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Transaction Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 217
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Account No"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cheque No"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Particulars"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 145
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Amount :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(629, 288)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 32)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'alltransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1362, 744)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "alltransactions"
        Me.Text = "All Transactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
End Class
