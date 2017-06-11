<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutus))
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.TextBoxDescription = New System.Windows.Forms.Label
        Me.LabelCopyright = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OKButton = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(46, 19)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(207, 19)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "BANK MANAGEMENT SYSTEM"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(47, 64)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(196, 15)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Version - JKJ  001.021.035 "
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.AutoSize = True
        Me.TextBoxDescription.Location = New System.Drawing.Point(47, 143)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(238, 45)
        Me.TextBoxDescription.TabIndex = 2
        Me.TextBoxDescription.Text = "Developed by -  Jayesh A. Agrawal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                Kishan D. Mistry" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            " & _
            "    Jay B. Patel"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(47, 100)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(105, 15)
        Me.LabelCopyright.TabIndex = 3
        Me.LabelCopyright.Text = "Copyright @ JK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Licence - Freeware"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(304, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.DarkKhaki
        Me.OKButton.Location = New System.Drawing.Point(304, 191)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(172, 34)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'aboutus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(495, 238)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelProductName)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aboutus"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Us"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OKButton As System.Windows.Forms.Button

End Class
