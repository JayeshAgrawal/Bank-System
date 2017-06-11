Public Class loadingform
    Dim z As Integer
    Private Sub loadingform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 5
        Label1.Visible = False
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Visible = True
        z += 1
        If z < 25 Then
            Label1.Text = "Initializing....."
        ElseIf z < 50 Then
            Label1.Text = "Loading components....."
        ElseIf z < 75 Then
            Label1.Text = "Integrating Database...."
        ElseIf z < 100 Then
            Label1.Text = "Please wait..."
        ElseIf z > 100 Then
            Dim m1 As New a_bank()
            bankmatch = m1.matchabnk()
            If bankmatch = True Then
                Me.Hide()
                bankprofile.Show()
                Timer1.Enabled = False
                Label1.Visible = False
            Else
                Me.Hide()
                loginform.Show()
                Timer1.Enabled = False
                Label1.Visible = False
            End If
        End If
        ProgressBar1.Value = z
    End Sub




  
End Class