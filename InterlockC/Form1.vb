Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Viewb()
        ViewC()
        CntB()
        CntC()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        Timer2.Enabled = True
    End Sub

    Sub CntB()
        For i = 0 To 8
            Dim Bs As String
            Bs = DataGridView1.Rows(0).Cells(i).Value
            If Bs = "OPEN" Then
                tutupB = DataC(i)
                updateB()
            End If
        Next
    End Sub

    Sub CntC()
        For i = 0 To 8
            Dim Bs As String
            Bs = DataGridView2.Rows(0).Cells(i).Value
            If Bs = "OPEN" Then
                tutupC = DataB(i)
                updateC()
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        BunifuCircleProgress1.Value = BunifuCircleProgress1.Value + 1
        If BunifuCircleProgress1.Value = 100 Then
            Timer2.Enabled = False
            BunifuCircleProgress1.Visible = False
            Shell("cmd.exe /k python tesmodbus.py", AppWinStyle.MinimizedFocus)
            DataGridView1.Visible = True
            DataGridView2.Visible = True
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Shell("taskkill /F /IM cmd.exe")
        Shell("taskkill /F /IM python.exe")
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Shell("cmd.exe /k python tesmodbus.py", AppWinStyle.MinimizedFocus)
        Timer4.Enabled = False
    End Sub
End Class
