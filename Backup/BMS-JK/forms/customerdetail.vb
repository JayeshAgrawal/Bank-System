Imports System.IO
Public Class customerdetail
    Dim value, income As String
    Dim strPicSource, strPicName, strPicName1, strPicExtension, strPicExtension1, strPicExtension2, strPicturename(), strPicturename1(), outFileName As String
    Dim cstno As String
    Dim op As Integer = 0
    Dim cnt As Integer = 0

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.FixedSingle
            strPicSource = OpenFileDialog1.FileName
            strPicExtension = New FileInfo(OpenFileDialog1.FileName).Extension
            copingfile()
            PictureBox1.Image = Image.FromFile(outFileName)

            strPicturename = outFileName.Split("\\")
            strPicName1 = strPicturename(strPicturename.Length - 1).ToString()
            strPicExtension1 = New FileInfo(SaveFileDialog1.FileName).Extension
        End If
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
        SaveFileDialog1.FileName = pic_str & txtfirstname.Text & op & cstno & strPicExtension '& outFileName
        Try
            File.Copy(strPicSource, SaveFileDialog1.FileName, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        outFileName = SaveFileDialog1.FileName
       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.FixedSingle
            strPicSource = OpenFileDialog1.FileName
            strPicExtension = New FileInfo(OpenFileDialog1.FileName).Extension
            copingfile()
            PictureBox1.Image = Image.FromFile(outFileName)

            strPicturename = outFileName.Split("\\")
            strPicName1 = strPicturename(strPicturename.Length - 1).ToString()
            strPicExtension1 = New FileInfo(SaveFileDialog1.FileName).Extension
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.BorderStyle = BorderStyle.FixedSingle
            strPicSource = OpenFileDialog1.FileName
            strPicExtension = New FileInfo(OpenFileDialog1.FileName).Extension
            copingfile()
            PictureBox2.Image = Image.FromFile(outFileName)

            strPicturename1 = outFileName.Split("\\")
            strPicName = strPicturename1(strPicturename1.Length - 1).ToString()
            strPicExtension2 = New FileInfo(SaveFileDialog1.FileName).Extension
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.BorderStyle = BorderStyle.FixedSingle
            strPicSource = OpenFileDialog1.FileName
            strPicExtension = New FileInfo(OpenFileDialog1.FileName).Extension
            copingfile()
            PictureBox2.Image = Image.FromFile(outFileName)

            strPicturename1 = outFileName.Split("\\")
            strPicName = strPicturename1(strPicturename1.Length - 1).ToString()
            strPicExtension2 = New FileInfo(SaveFileDialog1.FileName).Extension
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cnt = 1
        Button3.Enabled = True
        Button1.Enabled = False
        TabPage1.Enabled = True
        TabPage2.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        bankaccounts.Enabled = True
        bankaccounts.Activate()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
        If txtfullname.Text = "" Or txtfirstname.Text = "" Or DateTimePicker1.Text = "" Or txtplacebirth.Text = "" Or txtoccap.Text = "" Or (txtoffph.Text = "" And txthomeph.Text = "" And txtmoph.Text = "") Or txtemail.Text = "" Or txtnational.Text = "" Or ComboBox3.Text = "" Or txtidentificationno.Text = "" Or DateTimePicker2.Text = "" Or txtissuedat.Text = "" Then
            MsgBox("Please  fill all field. Some fields are blank....", MsgBoxStyle.Information)
        Else
            If cnt = 1 Then
                If RadioButton1.Checked = True Then
                    value = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    value = RadioButton2.Text
                End If
                If RadioButton3.Checked = True Then
                    income = RadioButton3.Text
                ElseIf RadioButton4.Checked = True Then
                    income = RadioButton4.Text
                ElseIf RadioButton5.Checked = True Then
                    income = RadioButton5.Text
                ElseIf RadioButton6.Checked = True Then
                    income = RadioButton6.Text
                ElseIf RadioButton7.Checked = True Then
                    income = RadioButton7.Text
                End If
                Dim d1 As New a_customer()
                cstno = d1.custno()
                bankaccounts.cmbcustomerno.Text = cstno
                d1.datainsert(cstno, txtfullname.Text, ComboBox1.Text, ComboBox2.Text, txtfirstname.Text, value, CDate(DateTimePicker1.Text), txtplacebirth.Text, txtoccap.Text, txtoffph.Text, txthomeph.Text, txtmoph.Text, txtemail.Text, txtnational.Text, strPicName, strPicName1, income, ComboBox3.Text, txtidentificationno.Text, CDate(DateTimePicker2.Text), txtissuedat.Text, txtissuedby.Text, txtresidence.Text)
                Me.Hide()
                bankaccounts.Enabled = True
                bankaccounts.Activate()

            ElseIf cnt = 2 Then
                If RadioButton1.Checked = True Then
                    value = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    value = RadioButton2.Text
                End If
                If RadioButton3.Checked = True Then
                    income = RadioButton3.Text
                ElseIf RadioButton4.Checked = True Then
                    income = RadioButton4.Text
                ElseIf RadioButton5.Checked = True Then
                    income = RadioButton5.Text
                ElseIf RadioButton6.Checked = True Then
                    income = RadioButton6.Text
                ElseIf RadioButton7.Checked = True Then
                    income = RadioButton7.Text
                End If
                Dim d2 As New a_customer()
                d2.datasave(cstno, txtfullname.Text, ComboBox1.Text, ComboBox2.Text, txtfirstname.Text, value, CDate(DateTimePicker1.Text), txtplacebirth.Text, txtoccap.Text, txtoffph.Text, txthomeph.Text, txtmoph.Text, txtemail.Text, txtnational.Text, strPicName, strPicName1, income, ComboBox3.Text, txtidentificationno.Text, CDate(DateTimePicker2.Text), txtissuedat.Text, txtissuedby.Text, txtresidence.Text)
                bankaccounts.cmbcustomerno.Text = cstno
                Me.Hide()
                bankaccounts.Enabled = True
                bankaccounts.Activate()
            End If
        End If

    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cnt = 2
        Button3.Enabled = True
        Button2.Enabled = False
        TabPage1.Enabled = True
        TabPage2.Enabled = True
    End Sub

    Private Sub customerdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        TabPage1.Enabled = False
        TabPage2.Enabled = False
    End Sub

   
End Class