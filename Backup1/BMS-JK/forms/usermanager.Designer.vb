<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usermanager
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.featuregv1 = New System.Windows.Forms.DataGridView
        Me.status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.feature = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtusercode = New System.Windows.Forms.TextBox
        Me.txtsupercode = New System.Windows.Forms.TextBox
        Me.txtmastercode = New System.Windows.Forms.TextBox
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.featuregv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(7, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 514)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.ListBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(50, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(261, 593)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Users"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button8.Location = New System.Drawing.Point(7, 22)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(247, 38)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "SHOW DETAILS"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 70)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1282, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Manager"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 628)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 478)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FEATURES MANAGER"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "User Type :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Location = New System.Drawing.Point(50, 398)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(779, 68)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button7.Location = New System.Drawing.Point(422, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(283, 31)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "CLOSE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Location = New System.Drawing.Point(73, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(283, 31)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(329, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(331, 23)
        Me.ComboBox1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.featuregv1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(870, 341)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECT FEATURES"
        '
        'featuregv1
        '
        Me.featuregv1.AllowUserToAddRows = False
        Me.featuregv1.AllowUserToDeleteRows = False
        Me.featuregv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.featuregv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.featuregv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.status, Me.feature})
        Me.featuregv1.Location = New System.Drawing.Point(17, 22)
        Me.featuregv1.Name = "featuregv1"
        Me.featuregv1.Size = New System.Drawing.Size(837, 303)
        Me.featuregv1.TabIndex = 0
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.status.Width = 160
        '
        'feature
        '
        Me.feature.HeaderText = "Feature"
        Me.feature.Name = "feature"
        Me.feature.ReadOnly = True
        Me.feature.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.feature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.feature.Width = 618
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtusercode)
        Me.GroupBox1.Controls.Add(Me.txtsupercode)
        Me.GroupBox1.Controls.Add(Me.txtmastercode)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CODE MANAGER"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "User Code :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Super Code :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Master Code :"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.Location = New System.Drawing.Point(652, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "RESET"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Location = New System.Drawing.Point(652, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Location = New System.Drawing.Point(652, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtusercode
        '
        Me.txtusercode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusercode.Location = New System.Drawing.Point(215, 74)
        Me.txtusercode.Name = "txtusercode"
        Me.txtusercode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtusercode.ReadOnly = True
        Me.txtusercode.Size = New System.Drawing.Size(357, 23)
        Me.txtusercode.TabIndex = 7
        Me.txtusercode.UseSystemPasswordChar = True
        '
        'txtsupercode
        '
        Me.txtsupercode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsupercode.Location = New System.Drawing.Point(215, 44)
        Me.txtsupercode.Name = "txtsupercode"
        Me.txtsupercode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsupercode.ReadOnly = True
        Me.txtsupercode.Size = New System.Drawing.Size(357, 23)
        Me.txtsupercode.TabIndex = 1
        Me.txtsupercode.UseSystemPasswordChar = True
        '
        'txtmastercode
        '
        Me.txtmastercode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmastercode.Location = New System.Drawing.Point(215, 14)
        Me.txtmastercode.Name = "txtmastercode"
        Me.txtmastercode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmastercode.ReadOnly = True
        Me.txtmastercode.Size = New System.Drawing.Size(357, 23)
        Me.txtmastercode.TabIndex = 0
        Me.txtmastercode.UseSystemPasswordChar = True
        '
        'usermanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "usermanager"
        Me.Text = "User Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.featuregv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtusercode As System.Windows.Forms.TextBox
    Friend WithEvents txtsupercode As System.Windows.Forms.TextBox
    Friend WithEvents txtmastercode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents featuregv1 As System.Windows.Forms.DataGridView
    Friend WithEvents status As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents feature As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
