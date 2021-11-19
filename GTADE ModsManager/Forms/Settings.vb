Imports System.IO
Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G3P.Text = My.Settings.GTA3P
        GVCP.Text = My.Settings.GTAVCP
        GSAP.Text = My.Settings.GTASAP
        DX12E.Checked = My.Settings.DX12
        VKE.Checked = My.Settings.VULKAN
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Folder As New FolderBrowserDialog
        Folder.Description = "Choose the GTA III - Definitive Edition folder"
        If Folder.ShowDialog = DialogResult.OK Then
            If File.Exists(Folder.SelectedPath & "/index.bin") Then
                Label2.Visible = True
                G3P.Text = Folder.SelectedPath
            Else
                MsgBox("index.bin not found !", MsgBoxStyle.Critical, "GTADE MM")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Folder As New FolderBrowserDialog
        Folder.Description = "Choose the GTA San Andreas - Definitive Edition folder"
        If Folder.ShowDialog = DialogResult.OK Then
            If File.Exists(Folder.SelectedPath & "/index.bin") Then
                Label3.Visible = True
                GSAP.Text = Folder.SelectedPath
            Else
                MsgBox("index.bin not found !", MsgBoxStyle.Critical, "GTADE MM")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Folder As New FolderBrowserDialog
        Folder.Description = "Choose the GTA Vice City - Definitive Edition folder"
        If Folder.ShowDialog = DialogResult.OK Then
            If File.Exists(Folder.SelectedPath & "/index.bin") Then
                Label5.Visible = True
                GVCP.Text = Folder.SelectedPath
            Else
                MsgBox("index.bin not found !", MsgBoxStyle.Critical, "GTADE MM")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.DX12 = DX12E.Checked
        My.Settings.VULKAN = VKE.Checked
        My.Settings.GTAVCP = GVCP.Text
        My.Settings.GTASAP = GSAP.Text
        My.Settings.GTA3P = G3P.Text
        MsgBox("Saved !", MsgBoxStyle.Information, "GTADE MM")
        Me.Close()
    End Sub
End Class