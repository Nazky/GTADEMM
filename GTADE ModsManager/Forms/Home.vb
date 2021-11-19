Public Class Home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If My.Settings.GTAVCP = "" Then
                MsgBox("Please put the GTA Vice City directory in the setting !", MsgBoxStyle.Critical)
            Else
                If My.Settings.DX12 = True Then
                    Process.Start(My.Settings.GTAVCP & "/GameFace/Binaries/Win64/ViceCity.exe", "-dx12")
                ElseIf My.Settings.VULKAN = True Then
                    Process.Start(My.Settings.GTAVCP & "/GameFace/Binaries/Win64/ViceCity.exe", "-vulkan")
                Else
                    Process.Start(My.Settings.GTAVCP & "/GameFace/Binaries/Win64/ViceCity.exe")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If My.Settings.GTASAP = "" Then
                MsgBox("Please put the GTA San Andreas directory in the setting !", MsgBoxStyle.Critical)
            Else
                If My.Settings.DX12 = True Then
                    Process.Start(My.Settings.GTASAP & "/GameFace/Binaries/Win64/SanAndreas.exe", "-dx12")
                ElseIf My.Settings.VULKAN = True Then
                    Process.Start(My.Settings.GTASAP & "/GameFace/Binaries/Win64/SanAndreas.exe", "-vulkan")
                Else
                    Process.Start(My.Settings.GTASAP & "/GameFace/Binaries/Win64/SanAndreas.exe")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If My.Settings.GTA3P = "" Then
                MsgBox("Please put the GTA III directory in the setting !", MsgBoxStyle.Critical)
            Else
                If My.Settings.DX12 = True Then
                    Process.Start(My.Settings.GTA3P & "/GameFace/Binaries/Win64/LibertyCity.exe", "-dx12")
                ElseIf My.Settings.VULKAN = True Then
                    Process.Start(My.Settings.GTA3P & "/GameFace/Binaries/Win64/LibertyCity.exe", "-vulkan")
                Else
                    Process.Start(My.Settings.GTA3P & "/GameFace/Binaries/Win64/LibertyCity.exe")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GTAVCM.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTransparency(Panel4, 50)
        SetTransparency(Panel5, 50)
        SetTransparency(Panel6, 50)
    End Sub

    Public Sub SetTransparency(ByRef ctrl As Control, ByVal percentTransparent As Integer)

        Dim alpha As Decimal = percentTransparent / 100 * 255

        ctrl.BackColor = Color.FromArgb(alpha, ctrl.BackColor)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GTASCM.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GTA3CM.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Credit.Show()
    End Sub
End Class
