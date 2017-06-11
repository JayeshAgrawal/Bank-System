<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadingform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loadingform))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Green
        Me.ProgressBar1.Location = New System.Drawing.Point(341, 136)
        Me.ProgressBar1.MarqueeAnimationSpeed = 0
        Me.ProgressBar1.Maximum = 101
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(237, 21)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(407, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Wait...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(321, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 68)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(31, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 304)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Purple
        Me.Label10.Location = New System.Drawing.Point(487, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Roll No: 035"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Purple
        Me.Label9.Location = New System.Drawing.Point(342, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Jay B. Patel"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(487, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Roll No: 021"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(342, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kishan D. Mistry"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(342, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jayesh A. Agrawal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(342, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 27)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "(Diploma 5th I.T)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(487, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Roll No: 001"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 258)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(324, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DEVELOPED BY:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'loadingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(702, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(702, 358)
        Me.MinimumSize = New System.Drawing.Size(702, 358)
        Me.Name = "loadingform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loadingform"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
