Imports System.IO
Imports System.IO.Compression
Imports SharpCompress.Archives
Imports SharpCompress.Common

Public Class ModInstaller
    Shared Sub GTASA(ModPath As String)
        Try
            Dim modinfo As New FileInfo(ModPath)
            If modinfo.Extension = ".zip" Then
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                ZipFile.ExtractToDirectory(ModPath, My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                SucessInstalled()
            ElseIf modinfo.Extension = ".rar" OrElse modinfo.Extension = ".7zip" OrElse modinfo.Extension = ".7z" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                SucessInstalled()
            ElseIf modinfo.Extension = ".pak" Then
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                File.Copy(ModPath, My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath) & "/" & Path.GetFileName(ModPath))
                SucessInstalled()
            Else
                ErrorInstalled()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Shared Sub GTAVC(ModPath As String)
        Try
            Dim modinfo As New FileInfo(ModPath)
            If modinfo.Extension = ".zip" Then
                Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                ZipFile.ExtractToDirectory(ModPath, My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                SucessInstalled()
            ElseIf modinfo.Extension = ".rar" OrElse modinfo.Extension = ".7zip" OrElse modinfo.Extension = ".7z" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                SucessInstalled()
            ElseIf modinfo.Extension = ".pak" Then
                Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                File.Copy(ModPath, My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath) & "/" & Path.GetFileName(ModPath))
                SucessInstalled()
            Else
                ErrorInstalled()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Shared Sub GTAIII(ModPath As String)
        Try
            Dim modinfo As New FileInfo(ModPath)
            If modinfo.Extension = ".zip" Then
                Directory.CreateDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                ZipFile.ExtractToDirectory(ModPath, My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                SucessInstalled()
            ElseIf modinfo.Extension = ".rar" OrElse modinfo.Extension = ".7zip" OrElse modinfo.Extension = ".7z" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                SucessInstalled()
            ElseIf modinfo.Extension = ".pak" Then
                Directory.CreateDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))
                File.Copy(ModPath, My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath) & "/" & Path.GetFileName(ModPath))
                SucessInstalled()
            Else
                ErrorInstalled()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Shared Sub SucessInstalled()
        MsgBox("Mod Installed !", MsgBoxStyle.Information)
    End Sub

    Shared Sub ErrorInstalled()
        MsgBox("Current supported files extension :" & vbCrLf & "- zip" & vbCrLf & "- rar" & vbCrLf & "- 7z" & vbCrLf & "- 7zip", MsgBoxStyle.Critical)
    End Sub
End Class
