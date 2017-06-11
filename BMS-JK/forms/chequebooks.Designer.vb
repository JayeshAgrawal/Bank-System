<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chequebooks
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Chequeno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbaccno = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnoofsheet = New System.Windows.Forms.TextBox
        Me.txtchequebookno = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1282, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cheque Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(462, 252)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(756, 78)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(203, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(579, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(391, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Cancel "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(17, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate  Cheque Book"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(462, 337)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(756, 308)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CHEQUES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chequeno, Me.Status})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(750, 286)
        Me.DataGridView1.TabIndex = 0
        '
        'Chequeno
        '
        Me.Chequeno.HeaderText = "Cheque No"
        Me.Chequeno.Name = "Chequeno"
        Me.Chequeno.ReadOnly = True
        Me.Chequeno.Width = 530
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 155
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.cmbaccno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtnoofsheet)
        Me.GroupBox2.Controls.Add(Me.txtchequebookno)
        Me.GroupBox2.Location = New System.Drawing.Point(462, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 151)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(327, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(275, 23)
        Me.DateTimePicker1.TabIndex = 9
        '
        'cmbaccno
        '
        Me.cmbaccno.FormattingEnabled = True
        Me.cmbaccno.Location = New System.Drawing.Point(327, 82)
        Me.cmbaccno.Name = "cmbaccno"
        Me.cmbaccno.Size = New System.Drawing.Size(275, 23)
        Me.cmbaccno.TabIndex = 8
        Me.cmbaccno.Text = "----------------SELECT--------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No. Of Sheets :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Issued :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cheque Book No :"
        '
        'txtnoofsheet
        '
        Me.txtnoofsheet.Location = New System.Drawing.Point(327, 112)
        Me.txtnoofsheet.Name = "txtnoofsheet"
        Me.txtnoofsheet.Size = New System.Drawing.Size(275, 23)
        Me.txtnoofsheet.TabIndex = 1
        '
        'txtchequebookno
        '
        Me.txtchequebookno.Location = New System.Drawing.Point(327, 22)
        Me.txtchequebookno.Name = "txtchequebookno"
        Me.txtchequebookno.ReadOnly = True
        Me.txtchequebookno.Size = New System.Drawing.Size(275, 23)
        Me.txtchequebookno.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 548)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHEQUE BOOKS"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(3, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(294, 514)
        Me.ListBox1.TabIndex = 1
        '
        'chequebooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1282, 707)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "chequebooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Books"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Chequeno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbaccno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnoofsheet As System.Windows.Forms.TextBox
    Friend WithEvents txtchequebookno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
