Imports System.IO
Public Class userprofile
    Dim strPicSource, strPicName, strPicExtension, strPicExtension1, strPicturename(), outFileName As String
    Dim op As Integer = 0
    Public urdet As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        jkkk()
    End Sub

    Public Sub copingfile()
        outFileName = strPicSource
        Dim pos As Integer
        pos = strPicSource.LastIndexOf(".")
        If (pos > 0) Then
            outFileName = outFileName.Substring(0, pos)
        End If
        outFileName += strPicExtension
        Dim pic_str As String
        pic_str = Application.StartupPath & "\resources\"
        op = op + 1
        SaveFileDialog1.FileName = pic_str & txtusername.Text & op & strPicExtension '& outFileName
        Try
            File.Copy(strPicSource, SaveFileDialog1.FileName, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        outFileName = SaveFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(outFileName)

        strPicturename = outFileName.Split("\\")
        strPicName = strPicturename(strPicturename.Length - 1).ToString()
        strPicExtension1 = New FileInfo(SaveFileDialog1.FileName).Extension
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Enabled = False
        changepassword.Show()
        changepassword.txtusername.Text = txtusername.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = False
        If urdet = 1 Then
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub userprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        GroupBox4.Enabled = True
        GroupBox1.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        GroupBox3.Enabled = True
        Dim d1 As New a_userprofile()
        d1.loaduser(txtusername.Text)

        If txtstatus.Text = "Enabled" Then
            txtstatus.BackColor = Color.Green
        ElseIf txtstatus.Text = "Disabled" Then
            txtstatus.BackColor = Color.Red
        End If
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim d2 As New a_userprofile()
        d2.saveuser(txtusername.Text, txtfullname.Text, txtpassword.Text, txtstatus.Text, dtl_logindate.Text, strPicName)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Are you sure? Do you want delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim d3 As New a_userprofile
            d3.deleteuser(txtusername.Text)
            Me.Close()
            If urdet = 0 Then
                home.Close()
            End If
        End If
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        jkkk()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        GroupBox2.Enabled = False
        GroupBox4.Enabled = True
        GroupBox1.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button3.Enabled = True
    End Sub

    Private Sub jkkk()
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.FixedSingle
            strPicSource = OpenFileDialog1.FileName
            strPicExtension = New FileInfo(OpenFileDialog1.FileName).Extension
            copingfile()
        End If
    End Sub
End Class