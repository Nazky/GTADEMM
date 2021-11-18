Public Class Credit

    Private Sub Credit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundedpic(PictureBox1)
    End Sub
    Sub roundedpic(pic As PictureBox)
        Dim radius As New Drawing2D.GraphicsPath
        radius.AddEllipse(30, 30, 120, 120)
        pic.Region = New Region(radius)
    End Sub

    Private curB As Integer
    Private curR As Integer
    Private curG As Integer
    Private dirB As Integer = 1
    Private dirR As Integer = 1
    Private dirG As Integer = -1
    Private rd As New Random

    Private Sub rainbowback(back As PictureBox)
        curB += 13 * dirB
        curR += 7 * dirR
        curG += 11 * dirG

        If curB > 255 Then
            curB = 255 - (curB - 255)
            dirB = -1
        ElseIf curB < 0 Then
            curB = -curB
            dirB = 1
        End If

        If curR > 255 Then
            curR = 255 - (curR - 255)
            dirR = -1
        ElseIf curR < 0 Then
            curR = -curR
            dirR = 1
        End If

        If curG > 255 Then
            curG = 255 - (curG - 255)
            dirG = -1
        ElseIf curG < 0 Then
            curG = -curG
            dirG = 1
        End If

        back.BackColor = System.Drawing.Color.FromArgb(curR, curG, curB)
        back.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        rainbowback(PictureBox1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://twitter.com/NazkyYT")
        Process.Start("https://ko-fi.com/nazkyyt")
    End Sub
End Class