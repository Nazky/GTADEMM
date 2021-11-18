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
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            ElseIf modinfo.Extension = ".rar" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)

            ElseIf modinfo.Extension = ".7zip" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            ElseIf modinfo.Extension = ".7z" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTASAP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            Else
                MsgBox("Current supported files extension :" & vbCrLf & "- zip" & vbCrLf & "- rar" & vbCrLf & "- 7zip" & vbCrLf & "- 7zip", MsgBoxStyle.Critical)

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
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            ElseIf modinfo.Extension = ".rar" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)

            ElseIf modinfo.Extension = ".7zip" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTAVCP & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            Else
                MsgBox("Current supported files extension :" & vbCrLf & "- zip" & vbCrLf & "- rar" & vbCrLf & "- 7zip" & vbCrLf & "- 7zip", MsgBoxStyle.Critical)

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
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            ElseIf modinfo.Extension = ".rar" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)

            ElseIf modinfo.Extension = ".7zip" Then
                Dim archive As IArchive = ArchiveFactory.Open(ModPath)
                Directory.CreateDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath))

                For Each entry In archive.Entries
                    If Not entry.IsDirectory Then
                        Console.WriteLine(entry.Key)
                        entry.WriteToDirectory(My.Settings.GTA3P & "/Gameface/Content/Paks/mods/" & Path.GetFileNameWithoutExtension(ModPath), New ExtractionOptions With
                                              {.ExtractFullPath = True, .Overwrite = True})
                    End If
                Next
                MsgBox("Mod Installed !", MsgBoxStyle.Information)
            Else
                MsgBox("Current supported files extension :" & vbCrLf & "- zip" & vbCrLf & "- rar" & vbCrLf & "- 7zip" & vbCrLf & "- 7zip", MsgBoxStyle.Critical)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
