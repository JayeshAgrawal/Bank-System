Imports System.IO
Public Class bankbranches
    Dim strPicSource, strPicName, strPicExtension, strPicExtension1, strPicturename(), outFileName As String
    Dim cnt As Integer = 0
    Dim op As Integer = 0

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        pic()
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
        SaveFileDialog1.FileName = pic_str & txtbranchname.Text & op & strPicExtension '& outFileName
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
    Private Sub pic()
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pic()
    End Sub
    Private Sub jkkk()
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kill()

        GroupBox1.Enabled = False
        Button2.Enabled = False
        cnt = 1
        jkkk()
        Button3.Enabled = False
        Button5.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
      
        If txtbranchname.Text = "" Or txtph1.Text = "" Or txtph2.Text = "" Or txtfax1.Text = "" Or txtfax2.Text = "" Or txtpobox.Text = "" Or txtweb.Text = "" Or txtcity.Text = "" Or txtcountry.Text = "" Or txtaddress.Text = "" Or strPicName = "" Then
            MsgBox("Please fill all fields and log....", MsgBoxStyle.Information)
            kill()
        Else
            If cnt = 1 Then
                Dim d1 As New a_bank()
                Dim bbno As String
                bbno = d1.giveno()
                txtbranchno.Text = bbno
                d1.insertbranch(txtbranchno.Text, txtbranchname.Text, txtph1.Text, txtph2.Text, txtfax1.Text, txtfax2.Text, txtpobox.Text, txtweb.Text, txtcity.Text, txtcountry.Text, txtaddress.Text, strPicName)
                Dim m1 As New a_bank()
                ListBox1.Items.Clear()
                m1.loadlistbank()
            ElseIf cnt = 2 Then
                Dim d2 As New a_bank()
                d2.savebranch(txtbranchno.Text, txtbranchname.Text, txtph1.Text, txtph2.Text, txtfax1.Text, txtfax2.Text, txtpobox.Text, txtweb.Text, txtcity.Text, txtcountry.Text, txtaddress.Text, strPicName)
                Dim m1 As New a_bank()
                ListBox1.Items.Clear()
                m1.loadlistbank()
            End If
            kill()
            GroupBox2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button2.Enabled = True
            GroupBox1.Enabled = True
        End If
     
    End Sub
    Private Sub kill()
        txtbranchno.Text = ""
        txtbranchname.Clear()
        txtph1.Clear()
        txtph2.Clear()
        txtfax1.Clear()
        txtfax2.Clear()
        txtpobox.Clear()
        txtweb.Clear()
        txtcity.Clear()
        txtcountry.Clear()
        txtaddress.Clear()
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\resources\NoLogo.bmp")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim d3 As New a_bank()
        d3.deletebranch(txtbranchno.Text)
        Dim m1 As New a_bank()
        ListBox1.Items.Clear()
        m1.loadlistbank()
        kill()
        GroupBox2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button2.Enabled = True
        GroupBox1.Enabled = True
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Me.IsMdiContainer = False
    End Sub

    Private Sub bankbranches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m1 As New a_bank()
        m1.loadlistbank()
        GroupBox2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim m1 As New a_bank()
        m1.loadlistbank1(ListBox1.SelectedItem)
        Button2.Enabled = False
        Button3.Enabled = True
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cnt = 2
        jkkk()
        Button3.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GroupBox2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button2.Enabled = True
        GroupBox1.Enabled = True
        kill()
    End Sub

 
   
End Class