Imports System.Math

Public Class Calculator
    Dim ms, m, x As Double
    Dim op1, op2, op3 As Double
    Dim flag As Integer
    Dim BS As Boolean
    Dim operand As Boolean
    Dim result As Double
    Dim op As Boolean
    Dim str As String

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text & btn0.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndot.Click
        txtDisplay.Text = txtDisplay.Text & btndot.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text & btn2.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text & btn3.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text & btn4.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text & btn5.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text & btn7.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text & btn8.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text & btn9.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text & btn6.Text
        'operand = False
        op = False
        BS = True
    End Sub
    Private Sub btn1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text & btn1.Text
        op = False
        BS = True
    End Sub
    Private Sub frmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDisplay.Focus()
        flag = -1
        operand = True
        op = False
        BS = True
    End Sub
    Private Sub btnequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequal.Click
        If Not operand Then
            op2 = Val(txtDisplay.Text)
            flag = -1
        Else
            If txtDisplay.Text = " " Then
                op2 = op1
                op = True

            Else
                If Not op Then
                    op2 = Val(txtDisplay.Text)
                Else
                    op2 = op2
                End If
            End If
        End If

        Select Case flag
            Case "1"
                If (op2 = 0 And op1 > 0) Then
                    txtDisplay.Text = "Cannot divide by zero."
                Else
                    result = op1 / op2
                    txtDisplay.Text = result.ToString()
                End If
            Case "2"
                result = op1 * op2
                txtDisplay.Text = result.ToString()
            Case "3"
                result = op1 - op2
                txtDisplay.Text = result.ToString()
            Case "4"
                result = op1 + op2
                txtDisplay.Text = result.ToString()
            Case Else
                result = op2
                txtDisplay.Text = result.ToString()
        End Select
        op1 = result
        BS = False
    End Sub
    Private Sub btndiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiv.Click
        flag = 1
        operand = True
        op = False
        op1 = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        txtDisplay.Focus()
        BS = False
    End Sub
    Private Sub btnmul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmul.Click
        flag = 2
        op = False
        op1 = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        txtDisplay.Focus()
        operand = True
        BS = False
    End Sub
    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        flag = 3
        operand = True
        op = False
        op1 = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        txtDisplay.Focus()
        BS = False
    End Sub
    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        flag = 4
        operand = True
        op = False
        op1 = Val(txtDisplay.Text)
        txtDisplay.Text = " "
        txtDisplay.Focus()
        BS = False
    End Sub
    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        Call allclear()
    End Sub
    Private Sub allclear()
        op1 = 0
        op2 = 0
        result = 0
        flag = -1
        txtDisplay.Text = "0"
        operand = False
        op = False
        BS = True
    End Sub

    Private Sub btnCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
        operand = False
        op = False
        BS = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If BS Then
            str = txtDisplay.Text
            If Len(str) > 1 Then
                str = Mid(str, 1, Len(str) - 1)
            Else
                str = "0"
            End If
            ' If all we are left is the minus sign, reset.
            If str = "-" Then
                str = "0"
            End If
            txtDisplay.Text = str
        End If
    End Sub

    Private Sub btnsqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsqrt.Click
        op3 = Val(txtDisplay.Text)
        txtDisplay.Text = Sqrt(op3)
    End Sub

    Private Sub ButtonPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPN.Click
        With txtDisplay
            If (Mid(.Text, 1, 1)) = "-" Then
                .Text = Mid(.Text, 2)
            Else
                If .Text <> "0" Then
                    .Text = "-" & .Text
                End If
            End If
        End With

    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        op2 = Val(txtDisplay.Text)
        m = (op1 * op2) / 100
        txtDisplay.Text = m
    End Sub

    Private Sub btndivx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivx.Click
        x = txtDisplay.Text
        x = 1 / x
        txtDisplay.Text = x
    End Sub

    Private Sub btnMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMS.Click
        ms = txtDisplay.Text
        lblM.Text = "M"
        BS = False
    End Sub

    Private Sub btnMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMR.Click
        txtDisplay.Text = ms
        BS = False
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        ms = ms + Val(txtDisplay.Text)
        BS = False
    End Sub

    Private Sub btnMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMC.Click
        ms = 0
        lblM.Text = " "
    End Sub

End Class
