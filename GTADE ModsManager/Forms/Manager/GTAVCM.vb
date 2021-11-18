Imports System.IO

Public Class GTAVCM

    Sub CheckME()
        If Directory.Exists(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods") Then
            Timer1.Start()
        Else
            Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods")
            Timer1.Start()
        End If
    End Sub

    Sub InstallM(modpath As String)
        ModInstaller.GTAVC(modpath)
        refershlist()
    End Sub

    Sub UnistallM()

    End Sub

    Private Sub GTAVCM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.GTAVCP = "" Then
            MsgBox("Please set the path of the game in the setting", MsgBoxStyle.Critical)
            Me.Close()
        Else
            Label2.Text = My.Settings.GTAVCP
            Panel1.AllowDrop = True
            CheckME()
            refershlist()
        End If

    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            InstallM(path)
        Next
    End Sub

    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Sub refershlist()
        lstDirectories.Items.Clear()
        Dim di As New DirectoryInfo(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods")
        'for every subdirectory in the folder, add its name to the listbox
        For Each subdi As DirectoryInfo In di.GetDirectories
            Try
                lstDirectories.Items.Add(subdi.Name)
            Catch ex As Exception

            End Try

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refershlist()
    End Sub

    Private Sub lstDirectories_MouseDown(sender As Object, e As MouseEventArgs) Handles lstDirectories.MouseDown
        If e.Button = MouseButtons.Right Then
            lstDirectories.SelectedIndex = lstDirectories.IndexFromPoint(e.X, e.Y)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ModUnistaller.GTAVC(lstDirectories.SelectedItem.ToString)
        refershlist()
    End Sub
End Class