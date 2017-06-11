Imports System.IO
Public Class bankprofile
    Dim strPicSource, strPicName, strPicExtension, strPicExtension1, strPicturename(), outFileName As String
    Dim cnt As Integer = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
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
        SaveFileDialog1.FileName = pic_str & txtbankname.Text & strPicExtension '& outFileName
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        jkkk()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nmm()
        cnt = 1
        Button5.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtbankname.Text = "" Or txtemail.Text = "" Or txtwebsite.Text = "" Or txtslogan.Text = "" Or strPicName = "" Then
            MsgBox("Please Fill All Field and give Log.... ", MsgBoxStyle.Information)
        Else
            If cnt = 1 Then
                Dim d1 As New a_bank()
                d1.datainsert(txtbankname.Text, txtemail.Text, txtwebsite.Text, txtslogan.Text, strPicName)
                dsaa()
                Dim m1 As New a_bank()
                m1.loadbank()
                If bankmatch = True Then
                    Me.Hide()
                    loginform.Show()
                End If
            ElseIf cnt = 2 Then
                Dim d2 As New a_bank()
                d2.savebank(txtbankname.Text, txtemail.Text, txtwebsite.Text, txtslogan.Text, strPicName)
                dsaa()
                Dim m1 As New a_bank()
                m1.loadbank()
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dsaa()
        If txtbankname.Text = "" Then
            Button2.Enabled = True
        End If
    End Sub
    Private Sub dsaa()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button3.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
   
        Dim d3 As New a_bank()
        d3.deletebank(txtbankname.Text)
        dsaa()
        Dim m1 As New a_bank()
        m1.loadbank()
        Button2.Enabled = True
        home.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        nmm()
        cnt = 2
    End Sub
    Private Sub nmm()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button3.Enabled = False
        Button2.Enabled = False
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

    Private Sub bankprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_bank()
        m1.loadbank()
        Button2.Enabled = False
        If txtbankname.Text = "" Then
            Button2.Enabled = True
            Button3.Enabled = False
        End If
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
    End Sub
End Class