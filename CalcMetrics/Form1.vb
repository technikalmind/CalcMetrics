Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("You must enter a numeric value!", Title:="Number Error", Buttons:=MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim eigrp_Bandwidth As Integer = TextBox1.Text
        Dim eigrp_Formula As Integer = 0
        Dim eigrp_Result As Integer
        Dim eigrp_Delay As Integer
        Dim K1, K2, K3, K4, K5 As Integer

        If CheckBox1.Checked = True Then
            K1 = 1
        Else : K1 = 0
        End If

        If CheckBox2.Checked = True Then
            K2 = 1
        Else : K2 = 0
        End If

        If CheckBox3.Checked = True Then
            K3 = 1
        Else : K3 = 0
        End If

        If CheckBox4.Checked = True Then
            K4 = 1
        Else : K4 = 0
        End If

        If CheckBox5.Checked = True Then
            K5 = 1
        Else : K5 = 0
        End If

        If RadioButton1.Checked = True Then
            eigrp_Delay = 100
        ElseIf RadioButton2.Checked = True Then
            eigrp_Delay = 20000
        End If

        If K2 Or K4 Or K5 = 1 Then
            MsgBox("Use of K2, K3, K4, and K5 no implemented yet.")
        End If

        eigrp_Bandwidth = 10 ^ 7 / eigrp_Bandwidth
        eigrp_Delay = eigrp_Delay / 10
        eigrp_Formula = (K1 * eigrp_Bandwidth + K3 * eigrp_Delay)
        eigrp_Result = eigrp_Formula * 256
        MessageBox.Show(eigrp_Result, caption:="EIGRP Metric")
        'MessageBox.Show("K1: " & K1 & vbLf & _
        '                "K2: " & K2 & vbLf & _
        '                "K3: " & K3 & vbLf & _
        '                "K4: " & K4 & vbLf & _
        '                "K5: " & K5)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("You must enter a numeric value!", Title:="Number Error", Buttons:=MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim ospf_Bandwidth As Integer = TextBox1.Text * 1000
        Dim ospf_Const As Integer = 10 ^ 8
        Dim ospf_Metric As Integer = 0

        ospf_Metric = ospf_Const / ospf_Bandwidth
        MsgBox(ospf_Metric, Title:="OSPF Metric")
    End Sub
End Class
